Public Class frm42Hasil
    Implements clsIface_hasil

    Public Property prop01_nilai01 As Integer Implements clsIface_hasil.prop01_nilai01


    Private Sub frm42Hasil_Load(sender As Object, e As EventArgs) Handles Me.Load
        lblHasil.Text = cm01Hitung()
    End Sub

    Public Function cm01Hitung() As Integer Implements clsIface_hasil.cm01Hitung
        Dim prmhasil As Integer
        prmhasil = prop01_nilai01


        Return prmhasil
    End Function
End Class