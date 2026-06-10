Imports System.Drawing.Printing

Public Class JCReportImg3D
    Implements IDisposable

    Public Property _01prop_NameIMG As String
    Public Property _02prop_ImgTampak01 As Image
    Public Property _03prop_ImgTampak02 As Image
    Public Property _04prop_ImgTampak03 As Image

    Private Sub JOBCARDReportImg3D_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.BeforePrint
        ' _cm01InitGambar()

    End Sub

    Sub _cm01InitGambar()
        _01cNameImg.Text = _01prop_NameIMG
        _02cImg_01.Image = _02prop_ImgTampak01
        _03cImg_02.Image = _03prop_ImgTampak02
        _04cImg_03.Image = _04prop_ImgTampak03
    End Sub


End Class