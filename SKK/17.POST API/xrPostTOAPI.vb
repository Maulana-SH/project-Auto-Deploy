Imports System.IO
Imports System.Net
Imports System.Text
Imports System.Web.Script.Serialization
Imports System.Xml
Imports Newtonsoft.Json
Imports Newtonsoft.Json.Linq

Public Class xrPostTOAPI

    '  Private apiURL As String = "https://ilygold.cuan.co/web/product-citrix"
    Private apiURL As String = "https://backoffice.ilygold.com/web/product-citrix" '(ganti Domain Kamis, 04-02-2021)
    Private prm01_UserName As String = "nv0001"
    Private prm02_password As String = "qwerty"

    Private pdHAsil As New DataTable

    Private Function PostJSON(ByVal JsonData As String) As HttpWebRequest
        Dim objhttpWebRequest As HttpWebRequest
        Try
            Dim httpWebRequest = DirectCast(WebRequest.Create(apiURL), HttpWebRequest)
            Dim authInfo As String = prm01_UserName + ":" + prm02_password
            authInfo = Convert.ToBase64String(Encoding.[Default].GetBytes(authInfo))
            httpWebRequest.ContentType = "text/json"
            httpWebRequest.Method = "POST"
            httpWebRequest.Headers("Authorization") = "Basic " & authInfo


            Using streamWriter = New StreamWriter(httpWebRequest.GetRequestStream())


                streamWriter.Write(JsonData)
                streamWriter.Flush()
                streamWriter.Close()
            End Using

            objhttpWebRequest = httpWebRequest

        Catch ex As Exception
            Console.WriteLine("Send Request Error[{0}]", ex.Message)
            MsgBox("mPost Send Request Error[{0}]", ex.Message)

            Return Nothing
        End Try

        Return objhttpWebRequest

    End Function

    Private Function GetResponse(ByVal httpWebRequest As HttpWebRequest) As String
        Dim strResponse As String = "Bad Request:400"
        Try
            Dim httpResponse = DirectCast(httpWebRequest.GetResponse(), HttpWebResponse)
            Dim result As String
            Using streamReader = New StreamReader(httpResponse.GetResponseStream())
                result = streamReader.ReadToEnd()
                strResponse = result.ToString()
            End Using
            MsgBox(" res :" & strResponse)
        Catch ex As Exception
            Console.WriteLine("GetResponse Error[{0}]", ex.Message)

            MsgBox("mGs catch - GetResponse Error[{0}] :" & ex.Message)

            Return ex.Message
        End Try

        Return strResponse

    End Function

#Region " COnvert DataTable to JSON"

    Dim pdtHAsil As New DataTable

    Private Sub _cmGetDataFCi()

        pdtHAsil.Clear()

        Using objGetFCI As NCMODELlib.clsMRP_iface = New NCMODELlib.clsMRP_impl With {.prop_KeyString01 = "FCI200216"}
            pdtHAsil = objGetFCI.Sele22MCFINDINGCOMPONENT
        End Using



    End Sub

#Region " Code Asli"
    Public Function jsonConvert01(ByVal table As DataTable) As String
        Dim jsSerializer As JavaScriptSerializer = New JavaScriptSerializer()
        Dim parentRow As List(Of Dictionary(Of String, Object)) = New List(Of Dictionary(Of String, Object))()
        Dim childRow As Dictionary(Of String, Object)

        For Each row As DataRow In table.Rows
            childRow = New Dictionary(Of String, Object)()

            For Each col As DataColumn In table.Columns
                childRow.Add(col.ColumnName, row(col))
            Next

            parentRow.Add(childRow)
        Next

        Return jsSerializer.Serialize(parentRow)
    End Function
#End Region

    Public Function cmCekKoneksi() As Boolean
        Dim isConnect As Boolean = False

        If My.Computer.Network.IsAvailable Then
            isConnect = True
        Else
            isConnect = False
            ' MsgBox("Computer is not connected.", MsgBoxStyle.Exclamation)
            MsgBox("Error Form { clsTFBRJBridgingAPI } " & vbNewLine & "No Internet Connection ..!", MsgBoxStyle.Exclamation)
        End If

        Return isConnect
    End Function

    'DataTableToJSONWithJavaScriptSerializer
    Public Function jsonConvert(ByVal table As DataTable) As String
        Dim result As String = ""

        Dim nTotalRow As Integer = table.Rows.Count
        If nTotalRow > 0 Then
            For Each row As DataRow In table.Rows
                result = "{'Nama': '" & row("k01cKodeItemFindingComponent_v50") & "',
                        'SetItem': 0,
                        'Kadar': 0,
                        'Qty': 0,
                        'CollectionName': " & row("f11cNamaTipeBRJ") & ",
                        'NoDo': 'string',
                        'KodeKaret': 'string',
                        'Color': 'string',
                        'NoSku': 'string',
                        'Status': 'string',
                        'MasterCode': 'string',
                        'KodeNORO': 'string',
                        'NamaNORO': 'string',
                        'KodeWarnaEmas': 'string',
                        'NamaWarnaEmas': 'string',
                        'KodeKadarEmas': 'string',
                        'NamaKadarEmas': 'string',
                        'KodeTipeBRJ': 'string',
                        'NamaTipeBRJ': 'string',
                        'BeratGross': 0,
                        'BeratNet': 0,
                        'GramZircon': 0,
                        'ButirZircon': 0,
                        'Size': 'string',
                        'KodeProduksi': 'string',
                        'FinishingColor': 'string',
                        'Brand': 'string',
                        'Item': 'string',
                        'Material': 'string',
                        'Gender': 'string',
                        'Grafir': 'string',
                        'Finding': 'string',
                        'Plating': 'string',
                        'Finishing': 'string',
                        'Stones': 'string',
                        'Findings': 'string'}"

                'Fungsi Send dan Lop perROW
            Next
        Else
            MsgBox("maaf.. data Transfer Tidak Ditemukan", MsgBoxStyle.Exclamation)
        End If

        Return result
    End Function

    Private Function cm03jsonConvert(ByVal prm01Nama As String, ByVal prm02SetItem As Integer, ByVal prm03kadar As Double,
                                 ByVal prm04qtyr As Integer, ByVal prm05NoDO As String, ByVal prm06KodeKaret As String,
                                 ByVal prm07Color As String, ByVal prm08NoSKU As String, ByVal prm09Status As String,
                                 ByVal prm10MasterCOde As String,
                                 ByVal prm11KodeNRO As String, ByVal prm12NamaNORO As String, ByVal prm13KodeWarnaEmas As String,
                                 ByVal prm14NamaWarnaEmas As String, ByVal prm15KodeKadar As String, ByVal prm16NamakAdar As String,
                                 ByVal prm17kodeTyprBRj As String, ByVal prm18NamaTiprBRJ As String, ByVal prm19BeratGross As Double,
                                 ByVal prm20BeratNet As Double, ByVal prm21GramZircon As Double, ByVal prm22ButirZircon As Integer,
                                 ByVal prm23Size As String, ByVal prm24KodeProduksi As String, ByVal prm25FinishingColor As String,
                                 ByVal prm26Brand As String, ByVal prm27Item As String, ByVal prm28Material As String,
                                 ByVal prm29Gender As String, ByVal prm30Grafir As String, ByVal prm31Finding As String,
                                 ByVal prm32Plating As String, ByVal prm33Finishing As String, ByVal prm34Tones As String,
                                 ByVal prm35Findings As String) As String
        Dim result As String = ""

        result = "{'Nama': '" & prm01Nama & "',
                        'SetItem': " & prm02SetItem & ",
                        'Kadar': " & prm03kadar & ",
                        'Qty': " & prm04qtyr & ",
                        'CollectionName': " & prm27Item & ",
                        'NoDo': '" & prm05NoDO & "',
                        'KodeKaret': '" & prm06KodeKaret & "',
                        'Color': '" & prm07Color & "',
                        'NoSku': '" & prm08NoSKU & "',
                        'Status': '" & prm09Status & "',
                        'MasterCode': '" & prm10MasterCOde & "',
                        'KodeNORO': '" & prm11KodeNRO & "',
                        'NamaNORO': '" & prm12NamaNORO & "',
                        'KodeWarnaEmas': '" & prm13KodeWarnaEmas & "',
                        'NamaWarnaEmas': '" & prm14NamaWarnaEmas & "',
                        'KodeKadarEmas': '" & prm15KodeKadar & "',
                        'NamaKadarEmas': '" & prm16NamakAdar & "',
                        'KodeTipeBRJ': '" & prm17kodeTyprBRj & "',
                        'NamaTipeBRJ': '" & prm18NamaTiprBRJ & "',
                        'BeratGross': " & prm19BeratGross & ",
                        'BeratNet': " & prm20BeratNet & ",
                        'GramZircon': " & prm21GramZircon & ",
                        'ButirZircon': " & prm22ButirZircon & ",
                        'Size': '" & prm23Size & "',
                        'KodeProduksi': '" & prm24KodeProduksi & "',
                        'FinishingColor': '" & prm25FinishingColor & "',
                        'Brand': '" & prm26Brand & "',
                        'Item': '" & prm27Item & "',
                        'Material': '" & prm28Material & "',
                        'Gender': '" & prm29Gender & "',
                        'Grafir': '" & prm30Grafir & "',
                        'Finding': '" & prm31Finding & "',
                        'Plating': '" & prm32Plating & "',
                        'Finishing': '" & prm33Finishing & "',
                        'Stones': '" & prm34Tones & "',
                        'Findings': '" & prm35Findings & "'}"
        Return result
    End Function

#End Region

    Private Function getResponStringJSON(ByVal prmRes As String, ByVal prmKey As String) As String
        Dim res As String = ""

        ' Dim rawresp As String = "{'isError': true, 'message': 'Pesan String JSON'}"
        Dim json As JObject = JObject.Parse(prmRes)
        'MsgBox(json.Item("message"))
        res = json.Item(prmKey).ToString

        Return res
    End Function


    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles btnSend.Click

        'Me.Cursor = Cursors.WaitCursor

        'Dim JsonData As String = _01Data.EditValue
        'Dim myRequest As HttpWebRequest = PostJSON(JsonData) 'data nya

        'Dim httpResponse = DirectCast(myRequest.GetResponse(), HttpWebResponse)
        'Dim responCode As Integer = httpResponse.StatusCode

        'Dim respons As String
        'Dim strResponse As String
        'Dim isError As Boolean = False
        'Dim Counter As Integer = 0
        'Using streamReader = New StreamReader(httpResponse.GetResponseStream())
        '    respons = streamReader.ReadToEnd()
        'End Using
        ''Respon FRM API
        '' {"isError":false,"message":"STRING telah berhasil di tambahkan."}
        ''Get Repons
        'isError = getResponStringJSON(respons, "isError")
        'strResponse = getResponStringJSON(respons, "message")

        'If isError Then
        '    'gagal
        '    MsgBox(Counter & " | Data Terikirim")
        '    _01Data.EditValue = ""
        '    _01Data.EditValue = strResponse
        'Else
        '    'Berhasil
        '    Counter += 1
        '    MsgBox(Counter & " | Data Terikirim")
        '    _01Data.EditValue = ""
        '    _01Data.EditValue = strResponse
        'End If

        '======== Solusion 01
        'Dim JsonData As String = _01Data.EditValue
        'Dim myRequest As HttpWebRequest = PostJSON(JsonData)
        'MsgBox("Response of Request:{0}", GetResponse(myRequest))
        ''MsgBox("Response of Request:{1}", GetResponse(myRequest))
        ''Console.ReadKey()

        ' Me.Cursor = Cursors.Default

        Using objDataFG2BridgingPerDoc As NCMODELlib.clsNEWCENTRAL_iface = New NCMODELlib.clsNEWCENTRAL_impl With {.prop_cNoDokumen = _NoDOTI.EditValue}
            pdHAsil = objDataFG2BridgingPerDoc.GetTP9HV02TransferFG2BridgingPerDoc()
        End Using


        _01Data.EditValue += jsonConvert(pdHAsil)

    End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        Me.Cursor = Cursors.WaitCursor

        If cmCekKoneksi() Then



            Using objDataFG2BridgingPerDoc As NCMODELlib.clsNEWCENTRAL_iface = New NCMODELlib.clsNEWCENTRAL_impl With {.prop_cNoDokumen = _NoDOTI.EditValue}
                pdHAsil = objDataFG2BridgingPerDoc.GetTP9HV02TransferFG2BridgingPerDoc()
            End Using

            If pdHAsil.Rows.Count > 0 Then

                Dim objarryJSON As String = ""
                Dim DumJSON As String = ""
                Dim Size As Integer = 0
                Dim Counter As Integer = 0
                Dim CounterErr As Integer = 0

                For Each dtRow As DataRow In pdHAsil.Rows

                    '=================== UNTUK CEK SIZE ======================
                    ' Jika Size bukan integer di set 0
                    ' Untuk Krim ke APP JIMS (SBU)
                    '=========================================================
                    If Integer.TryParse(dtRow("f17nSize"), Size) Then
                        'MsgBox("Value Benar Integer")
                        Size = CInt(dtRow("f17nSize"))
                    Else
                        'MsgBox("Value Bukan Integer")
                        Size = 0
                    End If
                    objarryJSON = cm03jsonConvert(dtRow("f01cNoDO").ToString, 1, RemoveCharacter(CStr(dtRow("f09cNamaKadarEmas")), "%"),
                                CInt(dtRow("f12nQtyLot")), dtRow("f01cNoDO"), dtRow("f02cKodeKaret"),
                                dtRow("f07cNamaWarnaEmas"), dtRow("f03cSKU"), "Default-Status",
                                dtRow("f02cKodeKaret"), dtRow("f04cKodeNORO"), dtRow("f05cNamaNORO"),
                                dtRow("f06cKodeWarnaEmas"), dtRow("f07cNamaWarnaEmas"), dtRow("f08cKodeKadarEmas"), dtRow("f09cNamaKadarEmas"),
                                dtRow("f10cKodeTipeBRJ"), dtRow("f11cNamaTipeBRJ"),
                                CDbl(dtRow("f13nBeratGross")), CDbl(dtRow("f14nBeratNett")),
                                CDbl(dtRow("f15nTGramZircon")), CInt(dtRow("f16TButirZircon")), Size,
                                dtRow("f18cKodeProduksi"), dtRow("f22cNamaFinishing_v50"), dtRow("f06cNamaBrand_v50"),
                                 dtRow("f11cNamaTipeBRJ"), dtRow("f08cNamaMaterial_v50"), dtRow("f18cNamaGender_v50"),
                                 dtRow("f16cNamaEngrave_v50"), dtRow("f28cNamaFinding_v50"), dtRow("f20cNamaPlating_v50"),
                                 dtRow("f22cNamaFinishing_v50"), dtRow("f16cNamaEngrave_v50"), dtRow("f28cNamaFinding_v50"))

                    'post Data To APi
                    Dim myRequest As HttpWebRequest = PostJSON(objarryJSON) 'data nya dikirim

                    'cek result DUM
                    DumJSON = objarryJSON

                    'Get Repons Reques
                    Dim respons As String
                    Dim IsError As String
                    Dim strResponse As String

                    Dim httpResponse = DirectCast(myRequest.GetResponse(), HttpWebResponse)
                    Dim responCode As Integer = httpResponse.StatusCode
                    Using streamReader = New StreamReader(httpResponse.GetResponseStream())
                        respons = streamReader.ReadToEnd()
                    End Using

                    'Get Repons Result
                    IsError = getResponStringJSON(respons, "isError")
                    strResponse = getResponStringJSON(respons, "message")

                    If IsError Then
                        'gagal
                        CounterErr += 1
                        MsgBox(Counter & dtRow("f01cNoDO").ToString & " | Data Terikirim")
                        _01Data.EditValue = ""
                        _01Data.EditValue = strResponse
                    Else
                        'Berhasil dan hitung total data yang terkirim
                        Counter += 1
                        MsgBox(Counter & " | Data Terikirim")
                        _01Data.EditValue = ""
                        _01Data.EditValue = strResponse
                    End If

                    ''Counter += 1
                    ''Dim strResponse As String
                    ''strResponse = result.ToString()
                    '' MsgBox("Status Code :" & responCode & " res :" & strResponse)
                    ''MsgBox(" res :" & strResponse)

                    ' MsgBox(Counter & " SKU " & dtRow("f03cSKU").ToString & " Terkirim ")
                    result.EditValue += objarryJSON
                Next
                MsgBox(Counter & " Data Terkirim  " & vbNewLine & CounterErr & " | Tidak Terkirim")
                '_01Data.EditValue = DumJSON
            End If
        Else
            MsgBox("Form { clsTFBRJBridgingAPI } " & vbNewLine & "Data Trasnsfer SBU Tidak Terikirim..", MsgBoxStyle.Exclamation)

        End If

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click

        cmCekKoneksi()

    End Sub
    Function RemoveCharacter(ByVal stringToCleanUp, ByVal characterToRemove)
        ' replace the target with nothing
        ' Replace() returns a new String and does not modify the current one
        Return stringToCleanUp.Replace(characterToRemove, "")
    End Function
    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click

        Dim kadar As String = "75.5%"
        MsgBox("Kadar :" & RemoveCharacter(kadar, "%"))

    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        '' Dim rawresp As String = "{'name':'hassan','age':24,'sex':'male'}"
        'Dim rawresp As String = "{'isError': true, 'message': 'Pesan String JSON'}"
        'Dim json As JObject = JObject.Parse(rawresp)
        'MsgBox(json.Item("message"))
    End Sub
End Class