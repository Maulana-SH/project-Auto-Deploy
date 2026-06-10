Imports System.Drawing.Printing

Public Class BOMReportRouting
    Private Sub BOMReportRouting_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.BeforePrint
        _cm01SetFillColums()
    End Sub

#Region "Costum : Method"

    Sub _cm01SetFillColums()
        _col01NoUrutRouting.Text = "[k03nNoUrutRouting_int]"
        _col02k02cKodeProsesProduksi_v50.Text = "[f01cKodeProsesProduksi_v50]"
        _col03f01cMasterRoutingDesc_v50.Text = "[f03cNamaProsesProduksi_v50]"
    End Sub

#End Region

End Class