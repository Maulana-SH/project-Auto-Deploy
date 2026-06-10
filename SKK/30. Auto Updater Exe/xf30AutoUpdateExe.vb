Imports System.IO
Imports System.Net
Imports DevExpress.Utils
Imports DevExpress.XtraEditors

Public Class xf30AutoUpdateExe
    Implements IDisposable

    Private prmDIRAPP As String = "D:\arif code\CITRIXAPPS\APP\"
    Private prmDIRAPP_OLD As String = "D:\arif code\CITRIXAPPS\APP_OLD\"

    Private prmInstalationsPATCH As String = Application.StartupPath() & "\"
    Private prmFolderName As String = "UpdateApps"

    Private prmListFile As New List(Of String)

#Region "From Evnt"
    Private Sub xf30AutoUpdateExe_Load(sender As Object, e As EventArgs) Handles Me.Load

        prmListFile.Add("NCCONTROLLERlib.dll")
        prmListFile.Add("NCMODELlib.dll")
        prmListFile.Add("NCREPOSITORYlib.dll")
        prmListFile.Add("NCVIEWMRPlib.dll")
        prmListFile.Add("SKK.exe")

        BtnUpdate.Enabled = False

    End Sub


#End Region

#Region "Custome Methods"

    Private Sub cm01CopyFile()


        '**********************************************
        ' (From Dir , TO Dir)
        ' Copy File satu file
        '**********************************************
        'My.Computer.FileSystem.CopyFile(prmDIRAPP & "\SetupEXE.txt",
        '                                prmDIRAPP_OLD & "\SetupEXE.txt")

        '*********************************************
        ' Copy All File from Dir , To Dir
        '*********************************************
        My.Computer.FileSystem.CopyDirectory(prmDIRAPP, prmDIRAPP_OLD, True)

        'MsgBox("Copy FIle Berhasil....")

    End Sub

    Private Sub cm03GetFIleNameFromDir()

        Dim di = New DirectoryInfo(prmDIRAPP)

        'ListBox1.Items.Clear()

        For Each fi In di.EnumerateFileSystemInfos()

            ' ListBox1.Items.Add(fi.ToString)

            If (fi.Attributes & FileAttributes.Directory) = FileAttributes.Directory Then
                Console.WriteLine(fi.FullName + " is a directory")
            Else
                Console.WriteLine(fi.FullName + " is a file")
            End If
        Next
    End Sub

    Private Sub cm05DownloadFileFromURL(ByVal prmURL As String)
        Me.Cursor = Cursors.WaitCursor


        Dim prmUpdsterFile As String = prmInstalationsPATCH & prmFolderName

        Dim prmURlSERVER As String = prmURL & "\"
        Dim prmUserName As String = ""
        Dim prmUserPass As String = ""

        Dim prmfileName As String = ""

        If Not System.IO.Directory.Exists(prmUpdsterFile) Then

            System.IO.Directory.CreateDirectory(prmUpdsterFile)

            _01LogProses.Text += "[ Folder Created ] " & DateTime.Now & " Folder name : " & prmFolderName & vbNewLine
        End If

        Using client As New WebClient()

            client.Credentials = New NetworkCredential(prmUserName, prmUserPass)

            For i As Integer = 0 To prmListFile.Count - 1

                prmfileName = ""
                prmfileName = prmListFile.Item(i).ToString

                client.DownloadFile(prmURlSERVER & prmfileName, prmUpdsterFile & "\" & prmfileName)

                ' Cek dulu jika file ada baru di copy

                If File.Exists(prmUpdsterFile & "\" & prmfileName) Then

                    _01LogProses.Text += "[ Download File Success ] " & DateTime.Now & " FileName : " & prmfileName & vbNewLine

                Else

                    _01LogProses.Text += "[ Download File Fails (File Not Found) ] " & DateTime.Now & " FileName : " & prmfileName & vbNewLine

                End If

            Next i

            'client.DownloadFile(prmURlSERVER, prmfileName)
            '(file from , file Save To)
            ' client.DownloadFile(prmURlSERVER & prmfileName, "D:\arif code\CITRIXAPPS\APP_OLD\" & prmfileName)
        End Using


        BtnUpdate.Enabled = True
        '  MsgBox("Donload Berhail...")

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cm06UpdaterExe()
        Dim prmFileName As String = ""

        Dim prmPATCHNew As String = prmInstalationsPATCH & prmFolderName & "\"

        ' Cek Folder Untuk Copy File Dll
        If Not System.IO.Directory.Exists(prmInstalationsPATCH & prmFolderName) Then

            MsgBox("folder Belum ada, dan sudah di buat")
            System.IO.Directory.CreateDirectory(prmInstalationsPATCH & prmFolderName)
        End If

        'Ambil Exe nya saja dan copy Ke folder => runing
        Dim prmFileExeName As String = ""

        prmFileExeName = prmListFile.Item(4)
        ' Cek dulu jika file ada baru di copy
        If File.Exists(prmInstalationsPATCH & prmFileExeName) Then
            MsgBox("File Exe Ditemukan " & prmFileExeName)

            'jika File add copy
            My.Computer.FileSystem.CopyFile(prmInstalationsPATCH & prmFileExeName,
                                                    prmPATCHNew & prmFileExeName, True)

            'Cek apakah berasil di copy ke folder baru
            If File.Exists(prmPATCHNew & prmFileExeName) Then
                MsgBox("File " & prmFileExeName & " Berhasil di Copy ")

                Application.Exit()
                Process.Start(prmInstalationsPATCH & prmFolderName & "\" & prmFileExeName)
            End If

        Else
            MsgBox("File Exe Tidak Ditemukan " & prmFileExeName)
        End If


    End Sub

    Private Function cm07GetFileExtnd(ByVal prmPACTHFile As String)
        Dim result As String = ""

        result = Path.GetExtension(prmPACTHFile)

        Return result
    End Function

    Private Function cm07GetFileNameOnly(ByVal prmPACTHFile As String)
        Dim result As String = ""

        result = Path.GetFileNameWithoutExtension(prmPACTHFile)

        Return result
    End Function

    Private Sub cm10Copy()
        ' Copy dari updater ke main DLL

        Dim prmFileName As String = ""

        Dim prmPATCHNew As String = prmInstalationsPATCH & prmFolderName & "\"


        For i As Integer = 0 To prmListFile.Count - 1

            prmFileName = ""
            prmFileName = prmListFile.Item(i).ToString


            ' Cek dulu jika file ada baru di copy
            If File.Exists(prmPATCHNew & prmFileName) Then

                'jika File add copy
                My.Computer.FileSystem.CopyFile(prmPATCHNew & prmFileName,
                                                prmInstalationsPATCH & prmFileName, True)

                'Cek file hasil Copy New
                If File.Exists(prmInstalationsPATCH & prmFileName) Then


                    _01LogProses.Text += "[Copy File Success ] " & DateTime.Now & " FileName : " & prmFileName & vbNewLine

                Else

                    _01LogProses.Text += "[Copy File Fails ] " & DateTime.Now & " FileName : " & prmFileName & vbNewLine
                End If

            Else

                _01LogProses.Text += "[Copy File Fails (File Not Found) ] " & DateTime.Now & " FileName : " & prmFileName & vbNewLine
            End If

        Next i

        Dim Pesan As String = ""
        Pesan = " Updater Selesai... Aplikasi akan Runing Ulang"

        If XtraMessageBox.Show(Pesan, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question, DefaultBoolean.True) = DialogResult.Yes Then

            Application.Exit()
            Process.Start(prmInstalationsPATCH & prmListFile.Item(4))

        Else

            Application.Exit()

        End If

    End Sub

    Private Sub cm11RenamFile()
        Dim prmFileName As String = ""  ' File name saja
        Dim prmFileNameExtns As String = "" ' filename + Extensi
        Dim prmFileExtns As String = ""

        Dim PatchNewFile As String = prmInstalationsPATCH & prmFolderName & "\"

        For i As Integer = 0 To prmListFile.Count - 1

            prmFileName = ""
            prmFileNameExtns = ""
            prmFileExtns = ""

            prmFileNameExtns = prmListFile.Item(i).ToString

            prmFileName = cm07GetFileNameOnly(PatchNewFile & prmFileName & prmListFile.Item(i).ToString)

            prmFileExtns = cm07GetFileExtnd(PatchNewFile & prmFileName & prmListFile.Item(i).ToString)

            My.Computer.FileSystem.RenameFile(PatchNewFile & prmFileNameExtns, prmFileName & "_old" & prmFileExtns)

        Next i

        MsgBox("Rename File Berhasil....")

        ' My.Computer.FileSystem.RenameFile("C:\Test.txt", "SecondTest.txt")

    End Sub

#End Region

#Region "Control Evnt"


    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If _01URL.Text <> "" Then
            cm05DownloadFileFromURL(_01URL.Text)
        Else
            MsgBox("Silhakan Masukan URL Download File Dll nya...")
        End If

    End Sub

    Private Sub SimpleButton3_Click_1(sender As Object, e As EventArgs) Handles BtnUpdate.Click
        cm10Copy()
    End Sub


#End Region

#Region "Grid Evnt"

#End Region

End Class