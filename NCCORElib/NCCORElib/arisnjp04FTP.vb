Imports System.Diagnostics
Imports System.Data
Imports System.Collections
Imports Microsoft.VisualBasic
Imports System.Collections.Generic
Imports System
Imports System.Net
Imports System.IO
Imports System.Text.RegularExpressions

Namespace arisnjp04FTP


    Public Class arisnjp04FTPClient
        Public Sub New()
        End Sub

        Public Sub New(ByVal Hostname As String)
            _hostname = Hostname
        End Sub

        Public Sub New(ByVal Hostname As String, ByVal Username As String, ByVal Password As String)
            _hostname = Hostname
            _username = Username
            _password = Password
        End Sub

        Public Function ListDirectory(ByVal directory As String) As List(Of String)
            Dim ftp As System.Net.FtpWebRequest = GetRequest(GetDirectory(directory))
            ftp.Method = System.Net.WebRequestMethods.Ftp.ListDirectory
            Dim str As String = GetStringResponse(ftp)
            str = str.Replace(vbCrLf, vbCr).TrimEnd(vbCr)
            Dim result As List(Of String) = New List(Of String)()
            result.AddRange(str.Split(vbCr))
            Return result
        End Function

        Public Function ListDirectoryDetail(ByVal directory As String) As FTPdirectory
            Dim ftp As System.Net.FtpWebRequest = GetRequest(GetDirectory(directory))
            ftp.Method = System.Net.WebRequestMethods.Ftp.ListDirectoryDetails
            Dim str As String = GetStringResponse(ftp)
            str = str.Replace(vbCrLf, vbCr).TrimEnd(vbCr)
            Return New FTPdirectory(str, _lastDirectory)
        End Function

        Public Function Upload(ByVal localFilename As String, ByVal targetFilename As String) As Boolean
            If Not File.Exists(localFilename) Then
                Throw (New ApplicationException("File " & localFilename & " not found"))
            End If

            Dim fi As FileInfo = New FileInfo(localFilename)
            Return Upload(fi, targetFilename)
        End Function

        Public Function Upload(ByVal fi As FileInfo, ByVal targetFilename As String) As Boolean
            Dim target As String

            If targetFilename.Trim() = "" Then
                target = Me.CurrentDirectory & fi.Name
            ElseIf targetFilename.Contains("/") Then
                target = AdjustDir(targetFilename)
            Else
                target = CurrentDirectory & targetFilename
            End If

            Dim URI As String = Hostname & target
            Dim ftp As System.Net.FtpWebRequest = GetRequest(URI)
            ftp.Method = System.Net.WebRequestMethods.Ftp.UploadFile
            ftp.UseBinary = True
            ftp.ContentLength = fi.Length
            Const BufferSize As Integer = 2048
            Dim content As Byte() = New Byte(2047) {}
            Dim dataRead As Integer

            Using fs As FileStream = fi.OpenRead()

                Try

                    Using rs As Stream = ftp.GetRequestStream()

                        Do
                            dataRead = fs.Read(content, 0, BufferSize)
                            rs.Write(content, 0, dataRead)
                        Loop While Not (dataRead < BufferSize)

                        rs.Close()
                    End Using

                Catch __unusedException1__ As Exception
                Finally
                    fs.Close()
                End Try
            End Using

            ftp = Nothing
            Return True
        End Function

        Public Function Download(ByVal sourceFilename As String, ByVal localFilename As String, ByVal PermitOverwrite As Boolean) As Boolean
            Dim fi As FileInfo = New FileInfo(localFilename)
            Return Me.Download(sourceFilename, fi, PermitOverwrite)
        End Function

        Public Function Download(ByVal file As FTPfileInfo, ByVal localFilename As String, ByVal PermitOverwrite As Boolean) As Boolean
            Return Me.Download(file.FullName, localFilename, PermitOverwrite)
        End Function

        Public Function Download(ByVal file As FTPfileInfo, ByVal localFI As FileInfo, ByVal PermitOverwrite As Boolean) As Boolean
            Return Me.Download(file.FullName, localFI, PermitOverwrite)
        End Function

        Public Function Download(ByVal sourceFilename As String, ByVal targetFI As FileInfo, ByVal PermitOverwrite As Boolean) As Boolean
            If targetFI.Exists AndAlso Not (PermitOverwrite) Then
                Throw (New ApplicationException("Target file already exists"))
            End If

            Dim target As String

            If sourceFilename.Trim() = "" Then
                Throw (New ApplicationException("File not specified"))
            ElseIf sourceFilename.Contains("/") Then
                target = AdjustDir(sourceFilename)
            Else
                target = CurrentDirectory & sourceFilename
            End If

            Dim URI As String = Hostname & target
            Dim ftp As System.Net.FtpWebRequest = GetRequest(URI)
            ftp.Method = System.Net.WebRequestMethods.Ftp.DownloadFile
            ftp.UseBinary = True

            Using response As FtpWebResponse = CType(ftp.GetResponse(), FtpWebResponse)

                Using responseStream As Stream = response.GetResponseStream()

                    Using fs As FileStream = targetFI.OpenWrite()

                        Try
                            Dim buffer As Byte() = New Byte(2047) {}
                            Dim read As Integer = 0

                            Do
                                read = responseStream.Read(buffer, 0, buffer.Length)
                                fs.Write(buffer, 0, read)
                            Loop While Not (read = 0)

                            responseStream.Close()
                            fs.Flush()
                            fs.Close()
                        Catch __unusedException1__ As Exception
                            fs.Close()
                            targetFI.Delete()
                            Throw
                        End Try
                    End Using

                    responseStream.Close()
                End Using

                response.Close()
            End Using

            Return True
        End Function

        Public Function FtpDelete(ByVal filename As String) As Boolean
            Dim URI As String = Me.Hostname & GetFullPath(filename)
            Dim ftp As System.Net.FtpWebRequest = GetRequest(URI)
            ftp.Method = System.Net.WebRequestMethods.Ftp.DeleteFile

            Try
                Dim str As String = GetStringResponse(ftp)
            Catch __unusedException1__ As Exception
                Return False
            End Try

            Return True
        End Function

        Public Function FtpFileExists(ByVal filename As String) As Boolean
            Try
                Dim size As Long = GetFileSize(filename)
                Return True
            Catch ex As Exception

                If TypeOf ex Is System.Net.WebException Then

                    If ex.Message.Contains("550") Then
                        Return False
                    Else
                        Throw
                    End If
                Else
                    Throw
                End If
            End Try
        End Function

        Public Function GetFileSize(ByVal filename As String) As Long
            Dim path As String

            If filename.Contains("/") Then
                path = AdjustDir(filename)
            Else
                path = Me.CurrentDirectory & filename
            End If

            Dim URI As String = Me.Hostname & path
            Dim ftp As System.Net.FtpWebRequest = GetRequest(URI)
            ftp.Method = System.Net.WebRequestMethods.Ftp.GetFileSize
            Dim tmp As String = Me.GetStringResponse(ftp)
            Return GetSize(ftp)
        End Function

        Public Function FtpRename(ByVal sourceFilename As String, ByVal newName As String) As Boolean
            Dim source As String = GetFullPath(sourceFilename)

            If Not FtpFileExists(source) Then
                Throw (New FileNotFoundException("File " & source & " not found"))
            End If

            Dim target As String = GetFullPath(newName)

            If target = source Then
                Throw (New ApplicationException("Source and target are the same"))
            ElseIf FtpFileExists(target) Then
                Throw (New ApplicationException("Target file " & target & " already exists"))
            End If

            Dim URI As String = Me.Hostname & source
            Dim ftp As System.Net.FtpWebRequest = GetRequest(URI)
            ftp.Method = System.Net.WebRequestMethods.Ftp.Rename
            ftp.RenameTo = target

            Try
                Dim str As String = GetStringResponse(ftp)
            Catch __unusedException1__ As Exception
                Return False
            End Try

            Return True
        End Function

        Public Function FtpCreateDirectory(ByVal dirpath As String) As Boolean
            Dim URI As String = Me.Hostname & AdjustDir(dirpath)
            Dim ftp As System.Net.FtpWebRequest = GetRequest(URI)
            ftp.Method = System.Net.WebRequestMethods.Ftp.MakeDirectory

            Try
                Dim str As String = GetStringResponse(ftp)
            Catch __unusedException1__ As Exception
                Return False
            End Try

            Return True
        End Function

        Public Function FtpDeleteDirectory(ByVal dirpath As String) As Boolean
            Dim URI As String = Me.Hostname & AdjustDir(dirpath)
            Dim ftp As System.Net.FtpWebRequest = GetRequest(URI)
            ftp.Method = System.Net.WebRequestMethods.Ftp.RemoveDirectory

            Try
                Dim str As String = GetStringResponse(ftp)
            Catch __unusedException1__ As Exception
                Return False
            End Try

            Return True
        End Function

        Private Function GetRequest(ByVal URI As String) As FtpWebRequest
            Dim result As FtpWebRequest = CType(FtpWebRequest.Create(URI), FtpWebRequest)
            result.Credentials = GetCredentials()
            result.KeepAlive = False
            Return result
        End Function

        Private Function GetCredentials() As System.Net.ICredentials
            Return New System.Net.NetworkCredential(Username, Password)
        End Function

        Private Function GetFullPath(ByVal file As String) As String
            If file.Contains("/") Then
                Return AdjustDir(file)
            Else
                Return Me.CurrentDirectory & file
            End If
        End Function

        Private Function AdjustDir(ByVal path As String) As String
            Return (If((path.StartsWith("/")), "", "/")).ToString() & path
        End Function

        Private Function GetDirectory(ByVal directory As String) As String
            Dim URI As String

            If directory = "" Then
                URI = Hostname & Me.CurrentDirectory
                _lastDirectory = Me.CurrentDirectory
            Else

                If Not directory.StartsWith("/") Then
                    Throw (New ApplicationException("Directory should start with /"))
                End If

                URI = Me.Hostname & directory
                _lastDirectory = directory
            End If

            Return URI
        End Function

        Private _lastDirectory As String = ""

        Private Function GetStringResponse(ByVal ftp As FtpWebRequest) As String
            Dim result As String = ""

            Using response As FtpWebResponse = CType(ftp.GetResponse(), FtpWebResponse)
                Dim size As Long = response.ContentLength

                Using datastream As Stream = response.GetResponseStream()

                    Using sr As StreamReader = New StreamReader(datastream)
                        result = sr.ReadToEnd()
                        sr.Close()
                    End Using

                    datastream.Close()
                End Using

                response.Close()
            End Using

            Return result
        End Function

        Private Function GetSize(ByVal ftp As FtpWebRequest) As Long
            Dim size As Long

            Using response As FtpWebResponse = CType(ftp.GetResponse(), FtpWebResponse)
                size = response.ContentLength
                response.Close()
            End Using

            Return size
        End Function

        Private _hostname As String

        Public Property Hostname As String
            Get

                If _hostname.StartsWith("ftp://") Then
                    Return _hostname
                Else
                    Return "ftp://" & _hostname
                End If
            End Get
            Set(ByVal value As String)
                _hostname = value
            End Set
        End Property

        Private _username As String

        Public Property Username As String
            Get
                Return (If(_username = "", "anonymous", _username))
            End Get
            Set(ByVal value As String)
                _username = value
            End Set
        End Property

        Private _password As String

        Public Property Password As String
            Get
                Return _password
            End Get
            Set(ByVal value As String)
                _password = value
            End Set
        End Property

        Private _currentDirectory As String = "/"

        Public Property CurrentDirectory As String
            Get
                Return _currentDirectory & (If((_currentDirectory.EndsWith("/")), "", "/")).ToString()
            End Get
            Set(ByVal value As String)

                If Not value.StartsWith("/") Then
                    Throw (New ApplicationException("Directory should start with /"))
                End If

                _currentDirectory = value
            End Set
        End Property
    End Class

    Public Class FTPfileInfo
            Public ReadOnly Property FullName As String
                Get
                    Return Path & Filename
                End Get
            End Property

            Public ReadOnly Property Filename As String
                Get
                    Return _filename
                End Get
            End Property

            Public ReadOnly Property Path As String
                Get
                    Return _path
                End Get
            End Property

            Public ReadOnly Property FileType As DirectoryEntryTypes
                Get
                    Return _fileType
                End Get
            End Property

            Public ReadOnly Property Size As Long
                Get
                    Return _size
                End Get
            End Property

            Public ReadOnly Property FileDateTime As DateTime
                Get
                    Return _fileDateTime
                End Get
            End Property

            Public ReadOnly Property Permission As String
                Get
                    Return _permission
                End Get
            End Property

            Public ReadOnly Property Extension As String
                Get
                    Dim i As Integer = Me.Filename.LastIndexOf(".")

                    If i >= 0 AndAlso i < (Me.Filename.Length - 1) Then
                        Return Me.Filename.Substring(i + 1)
                    Else
                        Return ""
                    End If
                End Get
            End Property

            Public ReadOnly Property NameOnly As String
                Get
                    Dim i As Integer = Me.Filename.LastIndexOf(".")

                    If i > 0 Then
                        Return Me.Filename.Substring(0, i)
                    Else
                        Return Me.Filename
                    End If
                End Get
            End Property

            Private _filename As String
            Private _path As String
            Private _fileType As DirectoryEntryTypes
            Private _size As Long
            Private _fileDateTime As DateTime
            Private _permission As String

            Public Enum DirectoryEntryTypes
                File
                Directory
            End Enum

            Public Sub New(ByVal line As String, ByVal path As String)
                Dim m As Match = GetMatchingRegex(line)

                If m Is Nothing Then
                    Throw (New ApplicationException("Unable to parse line: " & line))
                Else
                    _filename = m.Groups("name").Value
                    _path = path
                    Int64.TryParse(m.Groups("size").Value, _size)
                    _permission = m.Groups("permission").Value
                    Dim _dir As String = m.Groups("dir").Value

                    If _dir <> "" AndAlso _dir <> "-" Then
                        _fileType = DirectoryEntryTypes.Directory
                    Else
                        _fileType = DirectoryEntryTypes.File
                    End If

                    Try
                        _fileDateTime = DateTime.Parse(m.Groups("timestamp").Value)
                    Catch __unusedException1__ As Exception
                        _fileDateTime = Convert.ToDateTime(Now.Date)
                    End Try
                End If
            End Sub

            Private Function GetMatchingRegex(ByVal line As String) As Match
                Dim rx As Regex
                Dim m As Match

                For i As Integer = 0 To _ParseFormats.Length - 1
                    rx = New Regex(_ParseFormats(i))
                    m = rx.Match(line)

                    If m.Success Then
                        Return m
                    End If
                Next

                Return Nothing
            End Function

            Private Shared _ParseFormats As String() = New String() {"(?<dir>[\-d])(?<permission>([\-r][\-w][\-xs]){3})\s+\d+\s+\w+\s+\w+\s+(?<size>\d+)\s+(?<timestamp>\w+\s+\d+\s+\d{4})\s+(?<name>.+)", "(?<dir>[\-d])(?<permission>([\-r][\-w][\-xs]){3})\s+\d+\s+\d+\s+(?<size>\d+)\s+(?<timestamp>\w+\s+\d+\s+\d{4})\s+(?<name>.+)", "(?<dir>[\-d])(?<permission>([\-r][\-w][\-xs]){3})\s+\d+\s+\d+\s+(?<size>\d+)\s+(?<timestamp>\w+\s+\d+\s+\d{1,2}:\d{2})\s+(?<name>.+)", "(?<dir>[\-d])(?<permission>([\-r][\-w][\-xs]){3})\s+\d+\s+\w+\s+\w+\s+(?<size>\d+)\s+(?<timestamp>\w+\s+\d+\s+\d{1,2}:\d{2})\s+(?<name>.+)", "(?<dir>[\-d])(?<permission>([\-r][\-w][\-xs]){3})(\s+)(?<size>(\d+))(\s+)(?<ctbit>(\w+\s\w+))(\s+)(?<size2>(\d+))\s+(?<timestamp>\w+\s+\d+\s+\d{2}:\d{2})\s+(?<name>.+)", "(?<timestamp>\d{2}\-\d{2}\-\d{2}\s+\d{2}:\d{2}[Aa|Pp][mM])\s+(?<dir>\<\w+\>){0,1}(?<size>\d+){0,1}\s+(?<name>.+)"}
        End Class

    Public Class FTPdirectory
            Inherits List(Of FTPfileInfo)

            Public Sub New()
            End Sub

            Public Sub New(ByVal dir As String, ByVal path As String)
                For Each line As String In dir.Replace(vbLf, "").Split(System.Convert.ToChar(vbCr))

                    If line <> "" Then
                        Me.Add(New FTPfileInfo(line, path))
                    End If
                Next
            End Sub

            Public Function GetFiles(ByVal ext As String) As FTPdirectory
                Return Me.GetFileOrDir(FTPfileInfo.DirectoryEntryTypes.File, ext)
            End Function

            Public Function GetDirectories() As FTPdirectory
                Return Me.GetFileOrDir(FTPfileInfo.DirectoryEntryTypes.Directory, "")
            End Function

            Private Function GetFileOrDir(ByVal type As FTPfileInfo.DirectoryEntryTypes, ByVal ext As String) As FTPdirectory
                Dim result As FTPdirectory = New FTPdirectory()

                For Each fi As FTPfileInfo In Me

                    If fi.FileType = type Then

                        If ext = "" Then
                            result.Add(fi)
                        ElseIf ext = fi.Extension Then
                            result.Add(fi)
                        End If
                    End If
                Next

                Return result
            End Function

            Public Function FileExists(ByVal filename As String) As Boolean
                For Each ftpfile As FTPfileInfo In Me

                    If ftpfile.Filename = filename Then
                        Return True
                    End If
                Next

                Return False
            End Function

            Private Const slash As Char = "/"c

            Public Shared Function GetParentDirectory(ByVal dir As String) As String
                Dim tmp As String = dir.TrimEnd(slash)
                Dim i As Integer = tmp.LastIndexOf(slash)

                If i > 0 Then
                    Return tmp.Substring(0, i - 1)
                Else
                    Throw (New ApplicationException("No parent for root"))
                End If
            End Function
        End Class

End Namespace

