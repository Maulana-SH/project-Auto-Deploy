Imports System.Drawing.Printing

Public Class JCReportRouting
    Implements IDisposable
    Private Sub JOBCARDReportRouting_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.BeforePrint

        col01_ProcessName.Text = "[f06cNamaProsesProduksi_v50]"
    End Sub

End Class