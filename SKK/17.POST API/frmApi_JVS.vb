Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Text.RegularExpressions
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class frmApi_JVS
    Implements IDisposable

#Region " Param Auth & Endpoint API"
    ' Sementara untuk secure api nya pakai API key saja 
    Private URI_Businesstrip As String = "https://api.jatinom.my.id/api/Businesstrip"
    Private URI_Absensi As String = "https://api.jatinom.my.id/api/absensi"

    Private X_API_KEY As String = "X-JVS-Apikey"
    Private X_API_KEY_TOKEN As String = "jvskey@deskapp"

    'Private prm01_UserName As String = "jvs_admin"
    'Private prm02_password As String = "jvs@2020"
    Private objMDLAPI As clsMdlPostAPI

    Enum _nTargetMethods
        _01Postdata = 0
        _02GetAll = 1
        _03GetDetail = 2
    End Enum

    Private Function getResponStringJSON(ByVal prmRes As String, ByVal prmKey As String) As String
        Dim res As String = ""

        ' Dim rawresp As String = "{'isError': true, 'message': 'Pesan String JSON'}"
        Dim json As JObject = JObject.Parse(prmRes)
        'MsgBox(json.Item("message"))
        res = json.Item(prmKey).ToString

        Return res
    End Function

    Public Function GetDataTableFromJsonString(json As String) As DataTable

        'gvJsonToDataTable.DataSource = dataTable
        'gvJsonToDataTable.DataBind()

        Dim jsonLinq = JObject.Parse(json)

        ' Find the first array using Linq
        Dim srcArray = jsonLinq.Descendants().Where(Function(d) TypeOf d Is JArray).First()
        Dim trgArray = New JArray()
        For Each row As JObject In srcArray.Children(Of JObject)()
            Dim cleanRow = New JObject()
            For Each column As JProperty In row.Properties()
                ' Only include JValue types
                If TypeOf column.Value Is JValue Then
                    cleanRow.Add(column.Name, column.Value)
                End If
            Next
            trgArray.Add(cleanRow)
        Next

        Return JsonConvert.DeserializeObject(Of DataTable)(trgArray.ToString())
    End Function

    Private Function M_GET(ByVal prmURI As String) As HttpWebRequest

        Dim objhttpWebRequest As HttpWebRequest
        Try
            Dim httpWebRequest = DirectCast(WebRequest.Create(prmURI), HttpWebRequest)
            'Dim authInfo As String = prm01_UserName + ":" + prm02_password
            'authInfo = Convert.ToBase64String(Encoding.[Default].GetBytes(authInfo))
            httpWebRequest.ContentType = "text/json"
            httpWebRequest.Method = "GET"
            'httpWebRequest.Headers("Authorization") = "basic" & authInfo
            httpWebRequest.Headers(X_API_KEY) = X_API_KEY_TOKEN
            objhttpWebRequest = httpWebRequest
        Catch ex As Exception
            'Console.WriteLine("Send Request Error[{0}]", ex.Message)
            'MsgBox("mPost Send Request Error[{0}]", ex.Message)
            _02cResponse.Text = ex.Message
            Return Nothing
        End Try

        Return objhttpWebRequest

    End Function

    Private Function M_POST(ByVal prmURI As String, ByVal JsonData As String) As Boolean

        Dim webClient As New WebClient()
        Dim resByte As Byte()
        Dim resString As String
        Dim reqString() As Byte

        Try
            webClient.Headers("content-type") = "application/json"
            webClient.Headers(X_API_KEY) = X_API_KEY_TOKEN
            reqString = Encoding.Default.GetBytes(JsonConvert.SerializeObject(JsonData, Formatting.Indented))
            resByte = webClient.UploadData(prmURI, "POST", reqString)
            resString = Encoding.Default.GetString(resByte)
            Console.WriteLine(resString)
            _02cResponse.Text = resString
            webClient.Dispose()
            Return True
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Return False

    End Function

#End Region

#Region " Costum Methods"
    Private Function cm02ConvertJSONData(ByVal prmk01cNoSuratPenugasan_v50 As String, ByVal prmf01cNoSuratPenugasan_v50 As String,
                                         ByVal prmf02cNamaInspektor_v50 As String, ByVal prmf03cVessel_v250 As String,
                                         ByVal prmf04dTglInspeksi As Date, ByVal prmf05cFitUnfit_v50 As String,
                                         ByVal prmf06cAlamatLokasi_v500 As String,
                                         ByVal prmf07cLatitude_v50 As String, ByVal prmf08cLongitude_v50 As String,
                                         ByVal prmf09cNote_v200 As String, ByVal prmf10cKodeInspektor_v50 As String,
                                         ByVal prmf20cIDUser_v50 As String, ByVal prmf21cNamaUser_v50 As String)

        Dim objJSON As String = ""

        objJSON = "{    'k01cNoSuratPenugasan_v50': '" & prmk01cNoSuratPenugasan_v50 & "',
                        'f01cNoSuratPenugasan_v50': '" & prmf01cNoSuratPenugasan_v50 & " ',
                        'f02cNamaInspektor_v50': '" & prmf02cNamaInspektor_v50 & "',
                        'f03cVessel_v250': ' " & prmf03cVessel_v250 & "',
                        'f04dTglInspeksi': '" & prmf04dTglInspeksi & "',
                        'f05cFitUnfit_v50': '" & prmf05cFitUnfit_v50 & "',
                        'f06cAlamatLokasi_v500': '" & prmf06cAlamatLokasi_v500 & "',
                        'f07cLatitude_v50': '" & prmf07cLatitude_v50 & "',
                        'f08cLongitude_v50': '" & prmf08cLongitude_v50 & "',
                        'f09cNote_v200': '" & prmf09cNote_v200 & "',
                        'f10cKodeInspektor_v50': '" & prmf10cKodeInspektor_v50 & "',
                        'f20cIDUser_v50': '" & prmf20cIDUser_v50 & "',
                        'f21cNamaUser_v50': '" & prmf21cNamaUser_v50 & "',
                        'f22dCreatedDate': '" & Date.Now & "'
                    }"

        Return objJSON
    End Function

    Private Sub cm01Getdata()
        Me.Cursor = Cursors.WaitCursor
        Dim IsError As Boolean = False
        Dim respons As String = ""
        Dim objData As String = ""

        Dim url_API As String = _03cURL.EditValue

        If url_API IsNot Nothing Then
            Dim myRequest As HttpWebRequest = M_GET(url_API) 'data nya dikirim
            Dim httpResponse = DirectCast(myRequest.GetResponse(), HttpWebResponse)
            Dim responCode As Integer = httpResponse.StatusCode
            Using streamReader = New StreamReader(httpResponse.GetResponseStream())
                respons = streamReader.ReadToEnd()
            End Using
            ' {"status":true,"Rowrecord":2,"result":[]}

            IsError = CBool(getResponStringJSON(respons, "status"))
            objData = "{ result : " & getResponStringJSON(respons, "result") & " }"

            If CBool(IsError) = True Then
                ' MsgBox(" respon API =  berhasil konek")
                _02cResponse.Text = objData

                gcData.DataSource = Nothing
                gcData.DataSource = GetDataTableFromJsonString(objData)
                gcData.RefreshDataSource()
            Else
                MsgBox(" respon API =  gagal konek")
            End If
        Else
            MsgBox(" URL GET Belum Di Tambahkan")
        End If

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub cm02POSTDATA()
        Me.Cursor = Cursors.WaitCursor
        Dim IsError As Boolean = False
        Dim pesan As String = ""
        Dim respons As String = ""
        Dim objData As String = ""

        Dim url_API As String = _03cURL.EditValue
        Dim DataJSON As String = _01cJSONdata.EditValue

        If url_API.Length > 0 Then
            If DataJSON.Length > 0 Then
                'data nya dikirim
                If CBool(M_POST(url_API, DataJSON)) = True Then
                    ' MsgBox(" respon API =  berhasil konek")
                    '  _02cResponse.Text = respons

                    cm01Getdata()
                Else
                    MsgBox(" respon API =  gagal konek")
                End If
            Else
                MsgBox(" Data POST Tidak Boleh Kosong ")
            End If
        Else
            MsgBox(" URL POST Belum Di Tambahkan")
        End If
        Me.Cursor = Cursors.Default

    End Sub


    Public Function postData(ByVal dictData As Object) As Boolean
        Dim webClient As New WebClient()
        Dim resByte As Byte()
        Dim resString As String
        Dim reqString() As Byte

        Try
            'Dim authInfo As String = prm01_UserName + ":" + prm02_password
            'authInfo = Convert.ToBase64String(Encoding.[Default].GetBytes(authInfo))
            'webClient.Headers("Authorization") = "Basic " & authInfo
            webClient.Headers("content-type") = "application/json"
            webClient.Headers(X_API_KEY) = X_API_KEY_TOKEN
            reqString = Encoding.Default.GetBytes(JsonConvert.SerializeObject(dictData, Formatting.Indented))
            resByte = webClient.UploadData(URI_Absensi, "POST", reqString)
            resString = Encoding.Default.GetString(resByte)
            Console.WriteLine(resString)
            MsgBox("values = " & CStr(reqString.ToString))
            MsgBox("response = " & resString)
            webClient.Dispose()
            Return True
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        End Try
        Return False
    End Function

    Public Sub cm03AddDatAbsen()
        Dim myReq As HttpWebRequest = HttpWebRequest.Create(_03cURL.EditValue)
        myReq.Method = "POST"
        myReq.ContentType = "application/json"
        myReq.Headers(X_API_KEY) = X_API_KEY_TOKEN
        'Dim NewData As New JSON_Post
        'NewData.username = "Service_Provider_Username"
        'NewData.password = "Service_Provider_Password"
        'NewData.client_id = "client_id"
        'NewData.client_secret = "client_secret"
        'NewData.grant_type = "password"

        Dim PostString As String = JsonConvert.SerializeObject(_01cJSONdata.Text.Trim)
        Dim byteArray As Byte() = Encoding.UTF8.GetBytes(Regex.Replace(PostString, "\\r\\n", ""))
        myReq.ContentLength = byteArray.Length

        Dim dataStream As Stream = myReq.GetRequestStream()
        dataStream.Write(byteArray, 0, byteArray.Length)
        dataStream.Close() 'sends request

        Dim myResp As HttpWebResponse = myReq.GetResponse()
    End Sub

#End Region

#Region " control event"

    Private Sub btnGetData_Click(sender As Object, e As EventArgs) Handles btnGetData.Click
        cm01Getdata()
    End Sub

    Private Sub btnPOST_Click(sender As Object, e As EventArgs) Handles btnPOST.Click
        'cm02POSTDATA()

        Dim rs As Object = JsonConvert.SerializeObject(_01cJSONdata.Text, Formatting.Indented)
        _02cResponse.Text = rs
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        _01cJSONdata.Text = cm02ConvertJSONData("AKJ-12345", "", "", "", Date.Now, "UNPIT", "Alamat lokasi lengkap", "lat", "long",
                            "Notes ketrangan", "JV11", "admin", "admin")
    End Sub
#End Region

End Class