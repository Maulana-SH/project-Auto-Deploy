Imports System.Drawing.Printing

Public Class PROReportProImageSatu
    Implements IDisposable

    Public Property prop_IMG01 As Image
    Private Sub PROReportProImageSatu_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.BeforePrint
        PictureBrj.Image = prop_IMG01
    End Sub
End Class