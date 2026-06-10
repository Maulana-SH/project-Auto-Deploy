Imports System.IO
Imports System.Net
Imports Newtonsoft.Json.Linq

Public Class frm29DOnloadJSONfile
    Implements IDisposable

    Const prmReq_URL As String = "https://equran.id/api/surat"

#Region " From Event"

#End Region


#Region "Costumer Mtehods"

    Private Function ctrlWebRequest(ByVal prmAPIUrl As String) As HttpWebRequest

        Dim prmReq_URL As String = ""
        Dim prmMethods As String = ""

        Dim objhttpWebRequest As HttpWebRequest
        Try
            Dim httpWebRequest = DirectCast(WebRequest.Create(prmAPIUrl), HttpWebRequest)
            'Dim authInfo As String = prm01_UserName + ":" + prm02_password
            'authInfo = Convert.ToBase64String(Encoding.[Default].GetBytes(authInfo))
            'httpWebRequest.ContentType = "text/json"
            'httpWebRequest.Method = prmMethods
            'httpWebRequest.Headers("Authorization") = "Basic " & authInfo

            objhttpWebRequest = httpWebRequest


        Catch ex As Exception
            Console.WriteLine("Send Request Error[{0}]", ex.Message)
            MsgBox("mPost Send Request Error[{0}]", ex.Message)

            Return Nothing
        End Try

        Return objhttpWebRequest
    End Function

    Private Function getResponStringJSON(ByVal prmRes As String, ByVal prmKey As String) As String
        Dim res As String = ""

        ' Dim rawresp As String = "{'isError': true, 'message': 'Pesan String JSON'}"
        Dim json As JObject = JObject.Parse(prmRes)
        'MsgBox(json.Item("message"))
        res = json.Item(prmKey).ToString

        Return res
    End Function

    Private Sub cm01GetData()
        Dim respons As String = ""
        Dim api_URL As String = ""
        api_URL = _01Api_URL.EditValue

        Dim myRequest As HttpWebRequest = ctrlWebRequest(api_URL) 'data nya dikirim

        Dim httpResponse = DirectCast(myRequest.GetResponse(), HttpWebResponse)
        Dim responCode As Integer = httpResponse.StatusCode

        Using streamReader = New StreamReader(httpResponse.GetResponseStream())
            respons = streamReader.ReadToEnd()
        End Using

        _02Result.Text = ""
        _02Result.Text = CStr(respons)
    End Sub

    Private Sub btnGet_Click(sender As Object, e As EventArgs) Handles btnGet.Click
        cm01GetData()
    End Sub
#End Region
End Class