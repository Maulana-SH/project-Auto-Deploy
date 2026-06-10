Public Class formMenu01
    Public Property prop_01nama As String
    Public Property prop_02tgl As Date

    Private Sub formMenu01_Load(sender As Object, e As EventArgs) Handles Me.Load

        'set params to Object
        '_01cNama.EditValue = prop_01nama
        '_02dTglSekarang.EditValue = prop_02tgl

    End Sub

End Class