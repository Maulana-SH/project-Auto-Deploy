Imports System.Drawing
Imports System.Drawing.Printing

Public Class PROReportRouting

#Region "Costum : Method"

    Private Sub _cm01SetFieldNameTable()
        ' PRONoBaris.Text = "[NoBaris]"
        ProRoutingf01cOprationDesc_v50.Text = "[f03cNamaProsesProduksi_v50]"
    End Sub

    Public Sub _cm02SetBackColorTableByBrand(ByVal Brand As String)
        'Throw New NotImplementedException()
        If Brand.Equals("SDW") Then
            PRORoutingHeaderTableA.BackColor = Color.Gold
            PRORoutingHeaderTableB.BackColor = Color.Gold
            PRORoutingHeaderTableC.BackColor = Color.Gold
        ElseIf Brand.Equals("ABC") Then
            'Biru
            PRORoutingHeaderTableA.BackColor = Color.LightBlue
            PRORoutingHeaderTableB.BackColor = Color.LightBlue
            PRORoutingHeaderTableC.BackColor = Color.LightBlue
        ElseIf Brand.Equals("EFG") Then
            'Merah
            PRORoutingHeaderTableA.BackColor = Color.LightGray
            PRORoutingHeaderTableB.BackColor = Color.LightGray
            PRORoutingHeaderTableC.BackColor = Color.LightGray
        End If
    End Sub

#End Region


    Private Sub ReportRoutingProductionOrder_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.BeforePrint
        _cm01SetFieldNameTable()
    End Sub


End Class