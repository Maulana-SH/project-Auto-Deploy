Imports System.IO
Imports System.Net

Public Class xf30UpdaterApps


    Private prmInstalationsPATCH As String = Application.StartupPath() & "\"
    Private prmFolderName As String = "UpdateApps"

    Private prmListFile As New List(Of String)


    Private Sub xf30UpdaterApps_Load(sender As Object, e As EventArgs) Handles Me.Load
        prmListFile.Add("NCCONTROLLERlib.dll")
        prmListFile.Add("NCMODELlib.dll")
        prmListFile.Add("NCREPOSITORYlib.dll")
        prmListFile.Add("NCVIEWMRPlib.dll")
        prmListFile.Add("SKK.exe")
        prmListFile.Add("SKK-UPDATER.exe")
    End Sub

    Private Sub cm05DownloadFileFromURL(ByVal prmURLDownload As String)
        Me.Cursor = Cursors.WaitCursor

        'Dim prmURL As String = "http://localhost/citrixapp/APP/"

        Dim prmUpdsterFile As String = prmInstalationsPATCH

        Dim prmURlSERVER As String = prmURLDownload
        Dim prmUserName As String = ""
        Dim prmUserPass As String = ""

        Dim prmfileName As String = ""


        Using client As New WebClient()

            client.Credentials = New NetworkCredential(prmUserName, prmUserPass)

            prmfileName = "SKK-UPDATER.exe"

            client.DownloadFile(prmURlSERVER & prmfileName, prmUpdsterFile & "\" & prmfileName)

            ' Cek dulu jika file ada baru di copy

            If File.Exists(prmUpdsterFile & "\" & prmfileName) Then

                MsgBox("Download Berhasil...")
                Application.Exit()
                Process.Start(prmUpdsterFile & prmfileName)

            Else

                MsgBox("Download Gagal...")

            End If

        End Using

        '  MsgBox("Donload Berhail...")

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        If _01Url.EditValue <> "" Then
            cm05DownloadFileFromURL(_01Url.EditValue)
        Else
            MsgBox("SIlhakan MAsukan Url Download")
        End If
    End Sub

End Class