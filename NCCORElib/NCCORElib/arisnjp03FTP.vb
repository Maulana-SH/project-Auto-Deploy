Public Class arisnjp03FTP
    Implements IDisposable

    'Private Sub AllFTPProces()
    '    'Dim localPath As String = "D:\NEWRJS\"
    '    'Dim request As FtpWebRequest = CType(WebRequest.Create("ftp://192.168.2.119/"), FtpWebRequest)
    '    'request.Credentials = New NetworkCredential("NCSK01", "ASDF@123")
    '    'request.Method = WebRequestMethods.Ftp.ListDirectory
    '    'Dim streamReader As StreamReader = New StreamReader(request.GetResponse().GetResponseStream())
    '    'request = Nothing
    '    'Dim fileName As String = streamReader.ReadLine()

    '    'While fileName IsNot Nothing
    '    '    Dim requestFileDelete As FtpWebRequest = Nothing
    '    '    Dim responseFileDelete As FtpWebResponse = Nothing
    '    '    Dim requestFileDownload As FtpWebRequest = Nothing
    '    '    Dim responseFileDownload As FtpWebResponse = Nothing

    '    '    Try
    '    '        Console.WriteLine(fileName)
    '    '        requestFileDownload = CType(WebRequest.Create("ftp://103.247.217.11/" & fileName), FtpWebRequest)
    '    '        requestFileDownload.Credentials = New NetworkCredential("NCSK01", "ASDF@123")
    '    '        requestFileDownload.Method = WebRequestMethods.Ftp.DownloadFile
    '    '        responseFileDownload = CType(requestFileDownload.GetResponse(), FtpWebResponse)
    '    '        Dim responseStream As Stream = responseFileDownload.GetResponseStream()
    '    '        Dim writeStream As FileStream = New FileStream(localPath & fileName, FileMode.Create)
    '    '        Dim Length As Integer = 2048
    '    '        Dim buffer As Byte() = New Byte(Length - 1) {}
    '    '        Dim bytesRead As Integer = responseStream.Read(buffer, 0, Length)

    '    '        While bytesRead > 0
    '    '            writeStream.Write(buffer, 0, bytesRead)
    '    '            bytesRead = responseStream.Read(buffer, 0, Length)
    '    '        End While

    '    '        writeStream.Close()
    '    '        Console.WriteLine("Download Done")
    '    '        requestFileDelete = CType(WebRequest.Create("ftp://localhost/Source/" & fileName), FtpWebRequest)
    '    '        requestFileDelete.Credentials = New NetworkCredential("khanrahim", "arkhan22")
    '    '        requestFileDelete.Method = WebRequestMethods.Ftp.DeleteFile
    '    '        responseFileDelete = CType(requestFileDelete.GetResponse(), FtpWebResponse)
    '    '        Console.WriteLine("Delete status: {0}", responseFileDelete.StatusDescription)
    '    '    Catch exceptionObj As Exception
    '    '        Console.WriteLine(exceptionObj.Message.ToString())
    '    '    Finally
    '    '        responseFileDelete = Nothing
    '    '        requestFileDelete = Nothing
    '    '        requestFileDownload = Nothing
    '    '        responseFileDownload = Nothing
    '    '    End Try

    '    '    fileName = streamReader.ReadLine()
    '    'End While

    '    'request = Nothing
    '    'streamReader = Nothing

    '    '*****************************************************
    '    '*****************************************************
    '    'Dim requestFTPUploader As FtpWebRequest = Nothing
    '    'Dim files As String() = Directory.GetFiles(localPath)

    '    'For Each filepath As String In files
    '    '    fileName = Path.GetFileName(filepath)
    '    '    requestFTPUploader = CType(WebRequest.Create("ftp://127.0.0.1/Destination/" & fileName), FtpWebRequest)
    '    '    requestFTPUploader.Credentials = New NetworkCredential("khanrahim", "arkhan22")
    '    '    requestFTPUploader.Method = WebRequestMethods.Ftp.UploadFile
    '    '    Dim fileInfo As FileInfo = New FileInfo(filepath)
    '    '    Dim fileStream As FileStream = fileInfo.OpenRead()
    '    '    Dim bufferLength As Integer = 2048
    '    '    Dim buffer As Byte() = New Byte(bufferLength - 1) {}

    '    '    Try
    '    '        Dim uploadStream As Stream = requestFTPUploader.GetRequestStream()
    '    '        Dim contentLength As Integer = fileStream.Read(buffer, 0, bufferLength)

    '    '        While contentLength <> 0
    '    '            uploadStream.Write(buffer, 0, contentLength)
    '    '            contentLength = fileStream.Read(buffer, 0, bufferLength)
    '    '        End While

    '    '        uploadStream.Close()
    '    '        fileStream.Close()
    '    '    Catch exception As Exception
    '    '        Console.WriteLine(exception.Message.ToString())
    '    '    End Try

    '    '    Console.WriteLine(fileName & "Uploaded")
    '    'Next

    '    'requestFTPUploader = Nothing
    '    'Console.ReadLine()
    'End Sub

    Public Sub arisnjpFTPUpload(ByVal prmcNamaFile As List(Of String))

    End Sub

    Public Sub arisnjpFTPDownload(ByVal prmcNamaFile As List(Of String))

    End Sub

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        ' TODO: uncomment the following line if Finalize() is overridden above.
        ' GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
