Imports System.Drawing.Printing

Public Class ReportTecknicalDrawing
    Implements IDisposable

    Public Property _01prop_ProdcutCode As String
    Public Property _02prop_IMG_SP As Image
    Public Property _03prop_IMG_As As Image

    Private Sub ReportTecknicalDrawing_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.BeforePrint

        _02cProductCode.Text = _01prop_ProdcutCode
        _03cIMG_StonePart.Image = _02prop_IMG_SP
        _04cIMG_Assembly.Image = _03prop_IMG_As

    End Sub

End Class