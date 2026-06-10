Imports System.Drawing.Printing

Public Class JCReportImg2D
    Implements IDisposable

    Public Property _01Prop_NamaImage As String
    Public Property _02Prop_Image As Image

    Private Sub JOBCARDReportImg2D_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.BeforePrint

        _01cNameImg.Text = _01Prop_NamaImage
        _02cImg.Image = _02Prop_Image

    End Sub
End Class