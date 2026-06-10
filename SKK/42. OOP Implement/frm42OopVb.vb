Public Class frm42OopVb
    Implements clsIface_hasil

    Public Property prop01_nilai01 As Integer Implements clsIface_hasil.prop01_nilai01


    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        Dim objNewfrm As New frm42Hasil
        objNewfrm.Show()

    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        prop01_nilai01 = cm01Hitung()
    End Sub

    Public Function cm01Hitung() As Integer Implements clsIface_hasil.cm01Hitung
        Dim hasil As Integer

        hasil = _01NIlai.Text

        Return hasil
    End Function
End Class