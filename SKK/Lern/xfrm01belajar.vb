Public Class xfrm01belajar

    Private Sub xfrm01belajar_Load(sender As Object, e As EventArgs) Handles Me.Load

        'https://www.aguzrybudy.com/blog/vbnet/pengulangan-for-do-while-do-until-dan-while-di-vbnet
        'jenis Perulangan
        'For
        'For Each
        'Do While

        'For
        Dim hasil As String = ""
        _03cHasil.Text = ""

        For i As Integer = 0 To 5

            _03cHasil.Text += " perulangan ke " & i.ToString & vbNewLine

        Next i


    End Sub

    Private Sub _01MenuSatu_Click(sender As Object, e As EventArgs) Handles _01MenuSatu.Click

        Dim prm01Nama As String = ""
        Dim prm02Tgl As Date = "3000-01-01"
        Dim objMenu01 As New formMenu01

        'Cara Pertama
        'prm01Nama = _01cNama.EditValue
        'prm02Tgl = _02dTgl.EditValue
        'objMenu01 = New formMenu01 With {.prop_01nama = prm01Nama, .prop_02tgl = prm02Tgl}

        'Cara Kedua
        With objMenu01
            ._01cNama.EditValue = _01cNama.EditValue
            ._02dTglSekarang.EditValue = _02dTgl.EditValue
        End With

        'objMenu01.Show()
        'objMenu01.ShowDialog()

    End Sub

    Private Sub _02Menu0201_Click(sender As Object, e As EventArgs) Handles _02Menu0201.Click
        MsgBox("Menu 02.01 di Klik...")
    End Sub

End Class