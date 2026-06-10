Imports System.Net

Public Class xf37PingIpComputer
    Implements IDisposable

    Private second As Integer

#Region " form Evnt "
    Private Sub xf37PingIpComputer_Load(sender As Object, e As EventArgs) Handles Me.Load

        Timer1.Interval = 1000
    End Sub

#End Region


#Region " Costume Evnt "

    Private Function cm01CekWebsite(ByVal prmURL As String)
        Dim isOnline As Boolean

        Dim myRequest As HttpWebRequest
        Dim httpRess As HttpWebResponse

        Try
            myRequest = WebRequest.Create(prmURL)
            myRequest.AllowAutoRedirect = False

            httpRess = myRequest.GetResponse()

            If httpRess.StatusCode = HttpStatusCode.OK Then
                MsgBox("  Website is Online ")
                isOnline = True
            Else
                isOnline = False
                MsgBox("  Website Not Found ")
            End If


            _02ResultCode.EditValue = ""
            _02ResultCode.EditValue = httpRess.StatusCode
            httpRess.Close()
        Catch ex As Exception
            MsgBox(" Warning " & ex.Message)
            isOnline = False
        End Try






        Return isOnline
    End Function

    Private Sub SurroundingSub()
        Dim httpReq As HttpWebRequest = CType(WebRequest.Create("http://www.stackoverflow.com"), HttpWebRequest)
        httpReq.AllowAutoRedirect = False
        Dim httpRes As HttpWebResponse = CType(httpReq.GetResponse(), HttpWebResponse)

        If httpRes.StatusCode = HttpStatusCode.NotFound Then
        End If
    End Sub

    Public Function CheckAddress(ByVal URL As String) As Boolean
        Try
            Dim request As WebRequest = WebRequest.Create(URL)
            Dim response As WebResponse = request.GetResponse()
            MsgBox(response.Headers, MsgBoxStyle.Information, "INformastions")
        Catch ex As Exception
            MsgBox(ex.Message)
            Return False
        End Try
        Return True
    End Function

#End Region


#Region " Control Evnt "

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        If _01Url.EditValue <> "" Then
            cm01CekWebsite(_01Url.EditValue)

            'CheckAddress(_01Url.EditValue)
        End If

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        second += 1


    End Sub

#End Region


End Class