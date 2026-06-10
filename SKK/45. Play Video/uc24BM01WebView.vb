Public Class uc24BM01WebView
    Implements IDisposable

    Private prmheigth As Integer = 0
    Private prmWidth As Integer = 0
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        prmheigth = Me.Height
        prmWidth = Me.Width

    End Sub

    Public Property prop01_URL_Video As String

#Region " form Evnt "

#End Region

#Region " Custome Methods "

    Public Sub cm01PlayVideo()

        Dim html As String = "<html><head>"
        html &= "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>"
        html &= "<iframe id='video' src= 'https://www.youtube.com/embed/{0}?autoplay=1' width='" & prmWidth & "' height='" & prmheigth & "' frameborder='0' allowfullscreen></iframe>"
        html &= "</body></html>"

        Dim URL As String = prop01_URL_Video
        WebBrowser1.DocumentText = String.Format(html, URL.Split("=")(1))
    End Sub

#End Region

#Region " Control Evnt "

#End Region

#Region " Grid Evnt "

#End Region

End Class
