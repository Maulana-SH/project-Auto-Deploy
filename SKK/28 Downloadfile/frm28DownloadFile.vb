Imports System.IO
Imports DevExpress.XtraEditors

Public Class frm28DownloadFile


    Dim exePath As String = Application.ExecutablePath()
    Dim filePatchMaster As String = "C:\NEWRJS\maste_upload-saldo.xlsx"
    Dim fileName As String = "\master_data.xlsx"


    Function GetDirPath(ByVal file As String) As String
        Dim fi As New FileInfo(file)
        Return fi.Directory.ToString
    End Function



    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        'cm01DownloadFile()

        'Dim dialog As New FolderBrowserDialog() vb

        Dim dialog As New XtraFolderBrowserDialog
        dialog.RootFolder = Environment.SpecialFolder.Desktop
        dialog.Title = "Save Master Saldo"
        dialog.SelectedPath = "C:\"
        dialog.Description = "Pilih folder Save File"

        If dialog.ShowDialog() = Windows.Forms.DialogResult.OK Then
            Dim prmNewFileDownloded As String = ""
            _01patch.Text = dialog.SelectedPath.ToString

            prmNewFileDownloded = _01patch.Text & fileName

            'Fungsi Download file
            My.Computer.Network.DownloadFile(filePatchMaster, prmNewFileDownloded)

            'cek jika file usah ada
            If File.Exists(prmNewFileDownloded) Then
                MsgBox("Donload File Berhasil")
            Else
                MsgBox("gagal Donload File")
            End If


        End If

    End Sub

End Class