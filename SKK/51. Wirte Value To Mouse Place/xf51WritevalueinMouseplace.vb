
Public Class xf51WritevalueinMouseplace
    '************************************************************8
    Private Declare Function keybd_event Lib "user32.dll" (
        ByVal bVk As Byte,
        ByVal bScan As Byte,
        ByVal dwFlags As Integer,
        ByVal dwExtraInfo As Integer) As Integer

    Private Const KEYEVENTF_KEYUP As Integer = &H2
    Private Const VK_RETURN As Byte = &HD

    Private isTextSent As Boolean = False '

    Private Sub SendKeysToActiveWindow(text As String)
        For Each c As Char In text
            ' Kirim karakter ke aplikasi aktif
            keybd_event(Asc(c), 0, 0, 0)
            keybd_event(Asc(c), 0, KEYEVENTF_KEYUP, 0)
            Threading.Thread.Sleep(100) ' Tunggu sejenak sebelum mengirim karakter berikutnya
        Next

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim textToDisplay As String = "Halo, ini teks yang ditampilkan."

        SendKeys.Send(textToDisplay)


    End Sub

    Private Sub Cpn22CK01Timbangan1_Load(sender As Object, e As EventArgs) Handles cpnTimbangan.Load

        With cpnTimbangan  'Nama component
            ._01prop_BeratTimbngan = _03Berat  ' display input  di form yang menggunkan
        End With
        cpnTimbangan.cm00BindingAwal()

    End Sub
End Class