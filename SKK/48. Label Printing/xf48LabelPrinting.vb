Public Class xf48LabelPrinting
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim MldPrinting As New cls240619HelperPrinting

        _01Text.Text = MldPrinting.cm03GenerateLabelBelalai()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        'Dim MldPrinting As New cls240619HelperPrinting

        'Dim hasil As Decimal = 0

        'lbHasil.Text = ""
        'lbHasil.Text = MldPrinting.cm03PembulatanHarga(_01Nilai.EditValue)


        ' hitung Panjang character SKU
        Dim lengSKU As Integer
        lengSKU = Len("ZN20264614-005")

        lbHasil.Text = ""
        lbHasil.Text = lengSKU
    End Sub
End Class