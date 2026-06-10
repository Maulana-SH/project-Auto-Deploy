Public Class frm24BM02Browserview
    Implements IDisposable

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

    Public Property prop01_URL_Video As String

#Region " form Evnt "

    Private Sub frm24BM02Browserview_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

#End Region

#Region " Custome Methods "

    Public Sub cm01PlayVideo()
        Dim heigth As Integer = Me.Height
        Dim Width As Integer = Me.Width

        Dim html As String = "<html><head>"
        html &= "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>"
        html &= "<iframe id='video' src= 'https://www.youtube.com/embed/{0}?autoplay=1' width='420' height='250' frameborder='0' allowfullscreen></iframe>"
        html &= "</body></html>"

        Dim URL As String = "https://www.youtube.com/watch?v=Wo8AsZlO0Lg"
        ' WebBrowser1.DocumentText = String.Format(html, prop01_URL_Video.Split("=")(1))
        WebBrowser1.DocumentText = String.Format(html, URL.Split("=")(1))
        MsgBox("Video playing")
    End Sub

#End Region

End Class