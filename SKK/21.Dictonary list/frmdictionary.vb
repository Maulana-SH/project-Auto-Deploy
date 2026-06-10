Public Class frmdictionary
    Private listBuah As New Dictionary(Of String, Integer)


#Region " from Event"

#End Region


#Region " Custome Methods"

    Private Sub cmaddBuah(ByVal prmNamaBuah As String)

        Dim indx As Integer
        If listBuah.ContainsKey(prmNamaBuah) Then

            Dim indxkey As Integer

            For Each dics As KeyValuePair(Of String, Integer) In listBuah
                ' Console.WriteLine("COLOR: {0}, VALUE: {1}", dics.Key, dics.Value)

                If dics.Key = prmNamaBuah Then
                    indxkey = dics.Value
                End If
            Next


            MsgBox(prmNamaBuah & " Sudah ada pada urutan = " & indxkey)
        Else
            indx = listBuah.Count + 1
            listBuah.Add(prmNamaBuah, indx)
            MsgBox("berhasil di tambah")
        End If


        'Otput
        RichTextBox1.Text = ""
        For Each dics As KeyValuePair(Of String, Integer) In listBuah
            ' Console.WriteLine("COLOR: {0}, VALUE: {1}", dics.Key, dics.Value)
            RichTextBox1.Text += "key:" & dics.Key & "  VALUE: " & dics.Value & vbNewLine
        Next

        _01Buah.EditValue = ""
    End Sub


    Private Sub cm02Hapus(ByVal prmNamaBuah As String)
        If listBuah.ContainsKey(prmNamaBuah) Then

            listBuah.Remove(prmNamaBuah)

            MsgBox(prmNamaBuah & " berhasil Di Hapus")
        Else

            MsgBox(prmNamaBuah & " Tidak Di Temukan")
        End If


        'Otput
        RichTextBox1.Text = ""
        For Each dics As KeyValuePair(Of String, Integer) In listBuah
            ' Console.WriteLine("COLOR: {0}, VALUE: {1}", dics.Key, dics.Value)
            RichTextBox1.Text += "key:" & dics.Key & "  VALUE: " & dics.Value & vbNewLine
        Next

        _01Buah.EditValue = ""
    End Sub

#End Region


#Region " conrol Event"
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        cmaddBuah(_01Buah.EditValue)
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        cm02Hapus(_01Buah.EditValue)
    End Sub

#End Region




End Class