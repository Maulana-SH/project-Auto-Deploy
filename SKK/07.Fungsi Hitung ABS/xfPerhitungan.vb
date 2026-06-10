Public Class xfPerhitungan
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click



        Dim pnValueDataValid As Int32 = CType(Math.Abs(_01BeratBahan.EditValue - _02LMALLOY.EditValue), Int32)
        Dim pcIDCOREMas As String = ""

        _03HASIL.EditValue = pnValueDataValid
        'Toleransi range plusminus 15 gram
        If pnValueDataValid <= 15 Then

        End If

    End Sub
End Class