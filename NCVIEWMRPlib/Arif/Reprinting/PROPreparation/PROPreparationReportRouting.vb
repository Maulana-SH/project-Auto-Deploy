Imports System.Drawing
Imports System.Drawing.Printing

Public Class PROPreparationReportRouting


#Region "Costum : Method"

    Sub _cm01SetFieldName()
        ProPrepRouting_f03cNamaProsesProduksi_v50.Text = "[f03cNamaProsesProduksi_v50]"
        ProBOMNoUrut_k03nNoUrutRouting_int.Text = "[k03nNoUrutRouting_int]"

    End Sub

    Public Sub _cm02SetBackColorTableByBrand(ByVal Brand As String)
        'Throw New NotImplementedException()
        If Brand.Equals("SDW") Then
            ProPrepRoutingHeaderTable.BackColor = Color.Gold
        ElseIf Brand.Equals("ABC") Then
            'Biru
            ProPrepRoutingHeaderTable.BackColor = Color.LightBlue
        ElseIf Brand.Equals("EFG") Then
            'Merah
            ProPrepRoutingHeaderTable.BackColor = Color.LightGray
        End If
    End Sub

#End Region

    Private Sub PROPreparationReportRouting_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.BeforePrint
        _cm01SetFieldName()
    End Sub

End Class