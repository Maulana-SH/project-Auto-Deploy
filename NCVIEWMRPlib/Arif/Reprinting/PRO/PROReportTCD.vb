Imports System.Drawing.Printing

Public Class PROReportTCD
    Implements IDisposable

    Public Property prop_imgTcd01 As Image
    Public Property prop_imgTcd02 As Image
    Public Property prop_imgTcd03 As Image

    Private Sub PROReportTCD_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.BeforePrint

        ImgTCD01.Image = prop_imgTcd01
        ImgTCD02.Image = prop_imgTcd02
        ImgTCD03.Image = prop_imgTcd03
    End Sub
End Class