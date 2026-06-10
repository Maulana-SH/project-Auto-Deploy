Imports DevExpress.XtraEditors

Public Class xfStepperProgressBar


    Private Sub cm01CekPRo()

        'stpTracking.Items.Clear()
        Dim i As Integer = 0

        For i = 1 To 5
            Dim routing As New StepProgressBarItem
            routing.ContentBlock1.Caption = i
            routing.ContentBlock2.Caption = Date.Now
            routing.ContentBlock2.Description = " Description "

            If i <= 3 Then
                routing.Progress = 100
                routing.Appearance.ActiveIndicatorColor = Color.Lime
            End If

            stpTracking.Items.Add(routing)
        Next


    End Sub

    Private Sub cm02TrakingSKu(ByVal prmSKU As String)
        Dim pdtHasil As New DataTable

        pdtHasil.Clear()

        Using objGet As NCMODELlib.clsNEWCENTRAL_iface = New NCMODELlib.clsNEWCENTRAL_impl With {.prop_k01cSKU_v50 = prmSKU}
            pdtHasil = objGet.GetP6KE01TrackingSKU
        End Using

        If pdtHasil.Rows.Count > 0 Then

            For Each dtRow As DataRow In pdtHasil.Rows

                Dim routing As New StepProgressBarItem
                routing.ContentBlock1.Caption = CStr(dtRow("nNoBaris")) & " " & CStr(dtRow("f01cNamaProsesProduksi_v50"))
                routing.ContentBlock2.Caption = dtRow("f05dTglApproved")
                routing.ContentBlock2.Description = " Now Weihgt " + CStr(dtRow("f09nBeratAkhir_n92")) + vbNewLine + " Now Lot " + CStr(dtRow("f07nLotAkhir_int"))


                If dtRow("f05dTglApproved") <> "3000-01-01" Then
                    routing.Progress = 100
                    routing.Appearance.ActiveIndicatorColor = Color.Lime
                End If

                stpTracking.Items.Add(routing)

            Next

        Else
            MsgBox("Maaf SKu TIDAK DITEMUKAN ...")
        End If

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        'cm01CekPRo()
        cm02TrakingSKu(_01SKU.EditValue)
    End Sub
End Class