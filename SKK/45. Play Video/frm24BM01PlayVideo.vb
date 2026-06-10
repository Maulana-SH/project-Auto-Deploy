Imports DevExpress.CodeParser
Imports DevExpress.Utils.Extensions

Public Class frm24BM01PlayVideo
    Implements IDisposable

#Region " form Evnt "

    Private Sub frm24BM01PlayVideo_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub

#End Region

#Region " Custome Methods "

    '*****************************************************
    ' MAIN CODE
    '*****************************************************
    'Private Sub cm01PlayVideo()
    '    Dim heigth As Integer = Me.Height
    '    Dim Width As Integer = Me.Width

    '    Dim html As String = "<html><head>"
    '    html &= "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>"
    '    html &= "<iframe id='video' src= 'https://www.youtube.com/embed/{0}?autoplay=1' width='420' height='250' frameborder='0' allowfullscreen></iframe>"
    '    html &= "</body></html>"

    '    WebBrowser1.DocumentText = String.Format(html, _01URL.Text.Split("=")(1))
    'End Sub


    Private Sub cm01Play()
        'TabMain.TabPages.Clear()

        Dim TotalTab As Integer = 5 '_02CountView.Text
        Dim NewTab As New TabPage

        Dim objViewWeb As New uc24BM01WebView
        objViewWeb.Dock = DockStyle.Fill

        With NewTab
            .Text = "View 01"
            .Name = "View 01"
            .Tag = "View 01"
            .Controls.Add(objViewWeb)
        End With
        objViewWeb.prop01_URL_Video = _01URL.Text
        objViewWeb.cm01PlayVideo()
        TabMain.TabPages.Add(NewTab)

        'For i As Integer = 0 To TotalTab


        'Next

    End Sub

#End Region

#Region " Control Evnt "

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If _01URL.Text <> "" Then
            ' cm01PlayVideo()

            cm01Play()
        Else
            MsgBox("Masukan URL vide DLU")
        End If
    End Sub
#End Region

#Region " Grid Evnt "

#End Region

End Class