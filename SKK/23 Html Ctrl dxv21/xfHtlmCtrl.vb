Imports DevExpress.Utils.Html
Imports DevExpress.XtraEditors

Public Class xfHtlmCtrl

    Private Sub OnButtonClick(ByVal sender As Object, ByVal args As DxHtmlElementMouseEventArgs)

        Dim nama As String

        nama = args.Element.TagName = "NamaUser"

        If args.ElementId = "uploadBtn" Then
            XtraMessageBox.Show("Nama Saya adalah = " & nama)
        End If
        If args.ElementId = "removeBtn" Then
            XtraMessageBox.Show("Button hapus clicked")
        End If
        'XtraMessageBox.Show("Button " & args.ElementId & " clicked")
    End Sub

End Class