Imports DevExpress.XtraEditors

Public Class frm41TimbanganCOmponent
    Dim cpnTimbangan As New cpn22CK01Timbangan

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim objcpnTimbangan As New cpn22CK01Timbangan With {.Dock = DockStyle.Fill}
        objcpnTimbangan._01prop_BeratTimbngan = _01BeratReal
        objcpnTimbangan.cm00BindingAwal()
        Dim objFrm As New XtraForm

        objFrm.Controls.Add(objcpnTimbangan)
        objFrm.Show()

    End Sub

    Private Sub _01BeratReal_KeyDown(sender As Object, e As KeyEventArgs) Handles _01BeratReal.KeyDown
        If e.KeyCode = Keys.Enter Then
            cpnTimbangan._cm01GetDataTimbangan()
        End If
    End Sub
End Class