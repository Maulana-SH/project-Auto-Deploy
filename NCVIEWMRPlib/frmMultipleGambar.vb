Imports System.Windows.Forms

Public Class frmMultipleGambar
    Implements IDisposable

    Public Property prop_01dtGambar As DataTable
    Public Property prop_02cDataGUIDGambar As String
    Public Property prop_03f01objGambar As Byte()

    Private Sub OK_Button_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles OK_Button.Click
        prop_02cDataGUIDGambar = ""

        GridView1.OptionsSelection.MultiSelect = False
        GridView1.ClearSelection()

        Dim selectedRowHandles As Integer() = GridView1.GetSelectedRows()

        If selectedRowHandles.Length > 0 Then
            GridView1.FocusedRowHandle = selectedRowHandles(0)
            'GridView1.CopyToClipboard()
            For i As Integer = 0 To selectedRowHandles.Length - 1
                prop_02cDataGUIDGambar = GridView1.GetRowCellDisplayText(selectedRowHandles(i), _col02cKeyGUIDGambar)
                prop_03f01objGambar = GridView1.GetRowCellValue(selectedRowHandles(i), _col01f01objGambar)
            Next
        End If

        Me.DialogResult = DialogResult.OK
        Me.Close()
    End Sub

    Private Sub Cancel_Button_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Cancel_Button.Click
        Me.DialogResult = DialogResult.Cancel
        Me.Close()
    End Sub

    Private Sub frmMultipleGambar_Load(sender As Object, e As EventArgs) Handles Me.Load
        _rscol01f01objGambar.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        _rscol01f01objGambar.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        GridView1.OptionsView.RowAutoHeight = True

        _col01f01objGambar.FieldName = "f01objGambar"
        _col02cKeyGUIDGambar.FieldName = "cKeyGUIDGambar"

        GridControl1.DataSource = Nothing
        GridControl1.DataSource = prop_01dtGambar
        GridControl1.Refresh()
    End Sub

End Class
