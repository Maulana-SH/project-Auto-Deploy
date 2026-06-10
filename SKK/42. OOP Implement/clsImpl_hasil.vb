Public Class clsImpl_hasil
    Implements clsIface_hasil

    Public Property prop01_nilai01 As Integer Implements clsIface_hasil.prop01_nilai01

    Public Function cm01Hitung() As Integer Implements clsIface_hasil.cm01Hitung
        Dim hasil As Integer = 0

        hasil = prop01_nilai01

        Return hasil
    End Function

End Class
