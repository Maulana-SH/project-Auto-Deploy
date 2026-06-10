Public Class xrFCekValue
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim size As Integer

        If Integer.TryParse(TextEdit1.EditValue, size) Then
            ' childAge successfully parsed as Integer
            MsgBox("Value Benar Integer")
        Else
            ' childAge is not an Integer

            MsgBox("Value Bukan Integer")
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Cursor = Cursors.WaitCursor

        Dim pdtHasil As New DataTable

        pdtHasil.Clear()

        Using objGet As NCMODELlib.clsNEWCENTRAL_iface = New NCMODELlib.clsNEWCENTRAL_impl With {.prop_k01cNoKey_v50 = "PROSES02"}
            pdtHasil = objGet.GetDATABONPB
        End Using

        gridBON.DataSource = Nothing
        gridBON.DataSource = pdtHasil

        Cursor = Cursors.Default

    End Sub

End Class