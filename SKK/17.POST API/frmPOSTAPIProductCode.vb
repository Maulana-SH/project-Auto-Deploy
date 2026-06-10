Imports System.IO
Imports System.Net
Imports System.Text
Imports DevExpress.XtraPrinting
Imports Newtonsoft.Json.Linq

Imports NCMODELlib
Imports Newtonsoft.Json
Imports Microsoft.SqlServer

Public Class frmPOSTAPIProductCode

#Region " Param Auth & Endpoint API"
    'Private URL_Add As String = "http://backoffice.sandradewigold.com/api-productcode/product-code/addproductcode"
    Private URL_Add As String = "http://jims.sentralkreasikencana.com/api/product-code/addproductcode"
    Private URL_GetByID As String = "http://backoffice.sandradewigold.com/api-productcode/product-code/getbyproductcode?productCode="
    Private URL_All As String = "http://backoffice.sandradewigold.com/api-productcode/product-code/getall"

    Private prm01_UserName As String = "citrix"
    Private prm02_password As String = "citrixpassword"

    Private EndPoint_Add As String = "addproductcode"

    Private objMDLAPI As clsMdlPostAPI

    Enum _nTargetMethods
        _01Postdata = 0
        _02GetAll = 1
        _03GetDetail = 2
    End Enum

    Private Function ctrlAPIModule(ByVal prmTarget As _nTargetMethods, ByVal prmObjValues As String) As HttpWebRequest

        Dim prmReq_URL As String = ""
        Dim prmMethods As String = ""

        Select Case prmTarget
            Case _nTargetMethods._01Postdata
                prmReq_URL = URL_Add
                prmMethods = "POST"
            Case _nTargetMethods._02GetAll
                prmReq_URL = URL_All
                prmMethods = "GET"
            Case _nTargetMethods._03GetDetail
                prmReq_URL = URL_GetByID + prmObjValues
                prmMethods = "GET"
        End Select

        Dim objhttpWebRequest As HttpWebRequest
        Try
            Dim httpWebRequest = DirectCast(WebRequest.Create(prmReq_URL), HttpWebRequest)
            Dim authInfo As String = prm01_UserName + ":" + prm02_password
            authInfo = Convert.ToBase64String(Encoding.[Default].GetBytes(authInfo))
            httpWebRequest.ContentType = "text/json"
            httpWebRequest.Method = prmMethods
            httpWebRequest.Headers("Authorization") = "Basic " & authInfo

            If prmTarget = _nTargetMethods._01Postdata Then 'hanya Untuk POST DATA
                Using streamWriter = New StreamWriter(httpWebRequest.GetRequestStream())

                    streamWriter.Write(prmObjValues)
                    streamWriter.Flush()
                    streamWriter.Close()
                End Using
                objhttpWebRequest = httpWebRequest
            Else 'Untuk Get data Get All
                objhttpWebRequest = httpWebRequest
            End If



        Catch ex As Exception
            Console.WriteLine("Send Request Error[{0}]", ex.Message)
            MsgBox("mPost Send Request Error[{0}]", ex.Message)

            Return Nothing
        End Try

        Return objhttpWebRequest
    End Function

    Private Function POSTDATA(ByVal JsonData As String) As HttpWebRequest

        Dim objhttpWebRequest As HttpWebRequest
        Try
            Dim httpWebRequest = DirectCast(WebRequest.Create(URL_Add), HttpWebRequest)
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

    'Private Function GetdataBYProductCode(ByVal prmProductCode As String) As HttpWebRequest

    '    Dim objhttpWebRequest As HttpWebRequest
    '    Try
    '        Dim httpWebRequest = DirectCast(WebRequest.Create(URL_GetByID + prmProductCode), HttpWebRequest)
    '        Dim authInfo As String = prm01_UserName + ":" + prm02_password
    '        authInfo = Convert.ToBase64String(Encoding.[Default].GetBytes(authInfo))
    '        httpWebRequest.ContentType = "text/json"
    '        httpWebRequest.Method = "GET"
    '        httpWebRequest.Headers("Authorization") = "Basic " & authInfo

    '        objhttpWebRequest = httpWebRequest

    '    Catch ex As Exception
    '        Console.WriteLine("Send Request Error[{0}]", ex.Message)
    '        MsgBox("mPost Send Request Error[{0}]", ex.Message)

    '        Return Nothing
    '    End Try

    '    Return objhttpWebRequest

    'End Function

    'Private Function GetAllProduct() As HttpWebRequest

    '    Dim objhttpWebRequest As HttpWebRequest
    '    Try
    '        Dim httpWebRequest = DirectCast(WebRequest.Create(URL_All), HttpWebRequest)
    '        Dim authInfo As String = prm01_UserName + ":" + prm02_password
    '        authInfo = Convert.ToBase64String(Encoding.[Default].GetBytes(authInfo))
    '        httpWebRequest.ContentType = "text/json"
    '        httpWebRequest.Method = "GET"
    '        httpWebRequest.Headers("Authorization") = "Basic " & authInfo

    '        objhttpWebRequest = httpWebRequest

    '    Catch ex As Exception
    '        Console.WriteLine("Send Request Error[{0}]", ex.Message)
    '        MsgBox("mPost Send Request Error[{0}]", ex.Message)

    '        Return Nothing
    '    End Try

    '    Return objhttpWebRequest

    'End Function

    Private Function getResponStringJSON(ByVal prmRes As String, ByVal prmKey As String) As String
        Dim res As String = ""

        ' Dim rawresp As String = "{'isError': true, 'message': 'Pesan String JSON'}"
        Dim json As JObject = JObject.Parse(prmRes)
        'MsgBox(json.Item("message"))
        res = json.Item(prmKey).ToString

        Return res
    End Function
#End Region

#Region " Costume Methods "

    Private pdtProduct As New DataTable

    Private Sub cm00Clear()
        _01ProductCode.EditValue = ""
        _02objJSON.Text = ""
    End Sub

    Private Sub cm01Getdata(ByVal prmKodeProduct As String)

        Me.Cursor = Cursors.WaitCursor

        Dim objJSON As String

        objJSON = ""
        pdtProduct.Clear()

        Using objGetdat As clsMRP_iface = New clsMRP_impl With {.prop_KeyInt01 = 2, .prop_KeyString01 = prmKodeProduct}
            pdtProduct = objGetdat.Sele21GetProductAPI
        End Using

        If pdtProduct.Rows.Count > 0 Then

            For Each itm As Object In pdtProduct.Rows
                objJSON = cm02ConvertJSONData(itm("k01cKodeProduct_v50"), itm("f01cNamaProduct_v50"),
                                              itm("f02cKodeDesignMaster_v50"), itm("f03cKodeItemProduct_v50"),
                                              itm("f04cNamaItemProduct_v50"), itm("f05cKodeBrand_v50"),
                                              itm("f06cNamaBrand_v50"), itm("f07cKodeMaterial_v50"),
                                              itm("f08cNamaMaterial_v50"), itm("f09cKodeKadar_v50"),
                                              itm("f10cNamaKadar_v50"), itm("f11cKodeColor_500"),
                                              itm("f12cNamaColor_v500"), itm("f13cKodeSize_v500"),
                                              itm("f14cNamaSize_v500"), itm("f17cKodeGender_v500"),
                                              itm("f18cNamaGender_v500"), itm("f15cKodeEngrave_v500"),
                                              itm("f16cNamaEngrave_v500"), itm("f17cKodePlating_v500"),
                                              itm("f18cNamaPlating_v500"), itm("f19cKodeFinishing_v500"),
                                              itm("f20cNamaFinishing_v500"), itm("f21cKodeStoneColor_v500"),
                                              itm("f22cNamaStoneColor_v500"), itm("f23ckodeStone_v500"),
                                              itm("f24cStoneDesc_v500"), itm("f25cKodeFinding_v1000"),
                                              itm("f26cNamaFinding_v1000"), itm("f27nEstimasiBerat_n92"),
                                              0, itm("f42dCreatedDate"),
                                              itm("f41cNamaUser_v50"))
            Next
            _02objJSON.Text = objJSON
        Else
            MsgBox("maaaf.. data product Tidak Ditemukan")
        End If

        Me.Cursor = Cursors.Default
    End Sub

    Private Function cm02ConvertJSONData(ByVal prm01ProductCode As String, ByVal prm02ProductCodeName As String,
                                         ByVal prm03KodeKaret As String, ByVal prm04KodeItem As String,
                                         ByVal prm05Item As String, ByVal prm06KodeSegmen As String,
                                         ByVal prm07Segmen As String, ByVal prm08KodeMaterial As String,
                                         ByVal prm09Material As String, ByVal prm10KodeKadarProduksi As String,
                                         ByVal prm11KadarProduksi As String, ByVal prm12KodeFGColor As String,
                                         ByVal prm13FGColor As String, ByVal prm14KodeSize As String,
                                         ByVal prm15Size As String, ByVal prm16KodeGender As String,
                                         ByVal prm17Gender As String, ByVal prm18KodeGrafir As String,
                                         ByVal prm19Grafir As String, ByVal prm20KodePlating As String,
                                         ByVal prm21Plating As String, ByVal prm22KodeFinishing As String,
                                         ByVal prm23Finishing As String, ByVal prm24KodeStoneColor As String,
                                         ByVal prm25StoneColor As String, ByVal prm26KodeStone As String,
                                         ByVal prm27Stone As String, ByVal prm28KodeFinding As String,
                                         ByVal prm29Finding As String, ByVal prm30BeratEstimasi As Double,
                                         ByVal prm31CollectionId As Integer, ByVal prm32CreatedAt As Date,
                                         ByVal prm33CreatedBy As String)

        Dim objJSON As String = ""

        objJSON = "{
                  'ProductCode':'" & prm01ProductCode & "',
                  'ProductCodeName':'" & prm02ProductCodeName & "',
                  'KodeKaret':'" & prm03KodeKaret & "',
                  'KodeItem':'" & prm04KodeItem & "',
                  'Item':'" & prm05Item & "',
                  'KodeSegmen':'" & prm06KodeSegmen & "',
                  'Segmen':'" & prm07Segmen & "',
                  'KodeMaterial':'" & prm08KodeMaterial & "',
                  'Material':'" & prm09Material & "',
                  'KodeKadarProduksi':'" & prm10KodeKadarProduksi & "',
                  'KadarProduksi':'" & prm11KadarProduksi & "',
                  'KodeFGColor':'" & prm12KodeFGColor & "',
                  'FGColor':'" & prm13FGColor & "',
                  'KodeSize':'" & prm14KodeSize & "',
                  'Size':'" & prm15Size & "',
                  'KodeGender':'" & prm16KodeGender & "',
                  'Gender':'" & prm17Gender & "',
                  'KodeGrafir':'" & prm18KodeGrafir & "',
                  'Grafir':'" & prm19Grafir & "',
                  'KodePlating':'" & prm20KodePlating & "',
                  'Plating':'" & prm21Plating & "',
                  'KodeFinishing':'" & prm22KodeFinishing & "',
                  'Finishing':'" & prm23Finishing & "',
                  'KodeStoneColor':'" & prm24KodeStoneColor & "',
                  'StoneColor':'" & prm25StoneColor & "',
                  'KodeStone':'" & prm26KodeStone & "',
                  'Stone':'" & prm27Stone & "',
                  'KodeFinding':'" & prm28KodeFinding & "',
                  'Finding':'" & prm29Finding & "',
                  'BeratEstimasi': " & prm30BeratEstimasi & ",
                  'ProductType':'" & "CZ" & "',
                  'CollectionId': " & prm31CollectionId & ",
                  'CreatedAt': '" & prm32CreatedAt & "',
                  'CreatedBy':'" & prm33CreatedBy & "',
                  'UpdatedAt': '2021-11-03T05:41:26.626Z',
                  'UpdatedBy':'',
                  'DeletedAt': '2021-11-03T05:41:26.626Z',
                  'DeletedBy':'',
                  'IsDeleted': true,
                  'cz_CollectionThemes': {
                    'Id': 0,
                    'CollectionName': '',
                    'Segmen': '',
                    'CreatedAt': '2021-11-03T05:41:26.626Z',
                    'CreatedBy': 'string',
                    'UpdatedAt': '2021-11-03T05:41:26.626Z',
                    'UpdatedBy': 'string',
                    'DeletedAt': '2021-11-03T05:41:26.626Z',
                    'DeletedBy': '',
                    'IsDeleted': true,
                    'cz_Collections': [
                      {
                        'Id': 0,
                        'CollectionThemeId': 0,
                        'ProductId': '',
                        'ProductCode': '',
                        'CreatedAt': '2021-11-03T05:41:26.626Z',
                        'CreatedBy': '',
                        'UpdatedAt': '2021-11-03T05:41:26.626Z',
                        'UpdatedBy': '',
                        'DeletedAt': '2021-11-03T05:41:26.626Z',
                        'DeletedBy': '',
                        'IsDeleted': true,
                        'cz_CollectionThemes': {}
                      }
                    ],
                    'cz_ProductCodes': [
                      {}
                    ]
                  }
                }"

        Return objJSON
    End Function

    Private Sub cm03PostDataToAPI(ByVal prmKodeProduct As String)
        Me.Cursor = Cursors.WaitCursor

        Dim pdtHAsil As New DataTable
        Dim objJSON As String
        objJSON = ""
        pdtHAsil.Clear()

        'variabel Reposnse API
        Dim DumJSON As String = ""
        Dim respons As String = ""
        Dim IsError As Boolean = False
        Dim strResponse As String = ""

        Using objGetdat As clsMRP_iface = New clsMRP_impl With {.prop_KeyInt01 = 2, .prop_KeyString01 = prmKodeProduct}
            pdtHAsil = objGetdat.Sele21GetProductAPI
        End Using

        If pdtHAsil.Rows.Count > 0 Then
            For Each itm As Object In pdtProduct.Rows
                objJSON = cm02ConvertJSONData(itm("k01cKodeProduct_v50"), itm("f01cNamaProduct_v50"),
                                              itm("f02cKodeDesignMaster_v50"), itm("f03cKodeItemProduct_v50"),
                                              itm("f04cNamaItemProduct_v50"), itm("f05cKodeBrand_v50"),
                                              itm("f06cNamaBrand_v50"), itm("f07cKodeMaterial_v50"),
                                              itm("f08cNamaMaterial_v50"), itm("f09cKodeKadar_v50"),
                                              itm("f10cNamaKadar_v50"), itm("f11cKodeColor_500"),
                                              itm("f12cNamaColor_v500"), itm("f13cKodeSize_v500"),
                                              itm("f14cNamaSize_v500"), itm("f17cKodeGender_v500"),
                                              itm("f18cNamaGender_v500"), itm("f15cKodeEngrave_v500"),
                                              itm("f16cNamaEngrave_v500"), itm("f17cKodePlating_v500"),
                                              itm("f18cNamaPlating_v500"), itm("f19cKodeFinishing_v500"),
                                              itm("f20cNamaFinishing_v500"), itm("f21cKodeStoneColor_v500"),
                                              itm("f22cNamaStoneColor_v500"), itm("f23ckodeStone_v500"),
                                              itm("f24cStoneDesc_v500"), itm("f25cKodeFinding_v1000"),
                                              itm("f26cNamaFinding_v1000"), itm("f27nEstimasiBerat_n92"),
                                              0, Date.Now,
                                              itm("f41cNamaUser_v50"))

            Next
            Console.WriteLine("Data JSON =>", objJSON)

            objMDLAPI.postData(objJSON)

            '_02objJSON.Text = objJSON

            ''post Data To APi
            ''Dim myRequest As HttpWebRequest = POSTDATA(objJSON) 'data nya dikirim
            'Dim myRequest As HttpWebRequest = ctrlAPIModule(_nTargetMethods._01Postdata, objJSON) 'data nya dikirim

            ''cek result DUM
            ''DumJSON = objarryJSON

            'Dim httpResponse = DirectCast(myRequest.GetResponse(), HttpWebResponse)
            'Dim responCode As Integer = httpResponse.StatusCode

            'Using streamReader = New StreamReader(httpResponse.GetResponseStream())
            '    respons = streamReader.ReadToEnd()
            'End Using

            ''Get Repons Result
            'IsError = CBool(getResponStringJSON(respons, "isError"))
            'strResponse = getResponStringJSON(respons, "message")

            'If Not IsError Then
            '    MsgBox(" respon API = " & CStr(strResponse))
            'Else
            '    MsgBox(" respon API = " & CStr(strResponse))
            'End If

        Else
            MsgBox("data POST API Tidak DI Temukan")
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cm04GetByProduct(ByVal prmProductCode As String)
        Me.Cursor = Cursors.WaitCursor
        Dim IsError As Boolean
        Dim message As String = ""
        Dim respons As String = ""
        Dim objData As String = ""

        ' Dim myRequest As HttpWebRequest = GetdataBYProductCode(prmProductCode) 'data nya dikirim
        Dim myRequest As HttpWebRequest = ctrlAPIModule(_nTargetMethods._03GetDetail, prmProductCode) 'data nya dikirim

        Dim httpResponse = DirectCast(myRequest.GetResponse(), HttpWebResponse)
        Dim responCode As Integer = httpResponse.StatusCode

        Using streamReader = New StreamReader(httpResponse.GetResponseStream())
            respons = streamReader.ReadToEnd()
        End Using

        'Get Reponsm from API {KEY : values} Result
        IsError = CBool(getResponStringJSON(respons, "isError"))
        message = getResponStringJSON(respons, "message")
        'objData = getResponStringJSON(respons, "result")
        objData = "{ result : " & getResponStringJSON(respons, "result") & " }"

        If Not IsError Then
            MsgBox(" respon API = " & CStr(message))
            _03GetByProductcode.Text = objData



            gridProduct.DataSource = Nothing
            gridProduct.DataSource = GetDataTableFromJsonString(objData)
            gridProduct.RefreshDataSource()
        Else
            MsgBox(" respon API = " & CStr(message))
        End If
        Me.Cursor = Cursors.Default

        ' respon from API
        '     "isError" false,
        '"message": "Success",
        '"result": [
    End Sub

    Private Sub cm05GETAllProduct()
        Me.Cursor = Cursors.WaitCursor
        Dim IsError As Boolean
        Dim message As String = ""
        Dim respons As String = ""
        Dim objData As String = ""

        '  Dim myRequest As HttpWebRequest = GetAllProduct() 'data nya dikirim
        Dim myRequest As HttpWebRequest = ctrlAPIModule(_nTargetMethods._03GetDetail, "")  'data nya dikirim

        Dim httpResponse = DirectCast(myRequest.GetResponse(), HttpWebResponse)
        Dim responCode As Integer = httpResponse.StatusCode
        Using streamReader = New StreamReader(httpResponse.GetResponseStream())
            respons = streamReader.ReadToEnd()
        End Using

        'Get Reponsm from API {KEY : values} Result
        IsError = CBool(getResponStringJSON(respons, "isError"))
        message = getResponStringJSON(respons, "message")
        objData = getResponStringJSON(respons, "result")

        If Not IsError Then
            MsgBox(" respon API = " & CStr(message))
            _04GetAllData.Text = objData
        Else
            MsgBox(" respon API = " & CStr(message))
        End If
        Me.Cursor = Cursors.Default
        '     "isError" false,
        '"message": "Success",
        '"result": [
    End Sub

    Public Function JSONTODataTabel(json As String) As DataTable
        Dim pdtResult As New DataTable

        Dim myDataSet As DataSet = JsonConvert.DeserializeObject(Of DataSet)(json)
        'Check Table Count in DataSet
        If (myDataSet.Tables.Count > 0) Then
            If (myDataSet.Tables(0).Rows.Count > 0) Then
                'Bind Table[0] into grdOrderDetails GridView
                pdtResult = myDataSet.Tables(0)
            End If

            If (myDataSet.Tables(1).Rows.Count > 0) Then
                'Bind Table[1] into grdCompanyDetails GridView
                pdtResult = myDataSet.Tables(1)
            End If

        End If

        Return pdtResult
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
#End Region

#Region " from Event"

    Private Sub frmPOSTAPIProductCode_Load(sender As Object, e As EventArgs) Handles Me.Load
        cm00Clear()
    End Sub

#End Region

#Region "  Control event "

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        If _01ProductCode.EditValue <> "" Then
            cm01Getdata(_01ProductCode.EditValue)
        End If

    End Sub

    Private Sub btnPost_Click(sender As Object, e As EventArgs) Handles btnPost.Click
        If _01ProductCode.EditValue <> "" Then
            If My.Computer.Network.IsAvailable Then

                cm03PostDataToAPI(_01ProductCode.EditValue)
            Else
                MsgBox("Computer is not connected.")
            End If

        End If
    End Sub

    Private Sub btnGetOne_Click(sender As Object, e As EventArgs) Handles btnGetOne.Click
        If _01ProductCode.EditValue <> "" Then

            cm04GetByProduct(_01ProductCode.EditValue)

            'prmFileName = "E:\Image-Product\" & CStr(itm("f02cKodeFGorComponent_v50")) & ".bmp"

        End If

        'Dim stRead As New StreamReader("D:\json.txt")
        'Dim dataTable As DataTable = GetDataTableFromJsonString(stRead.ReadToEnd())
        'GridView1.BestFitColumns()
        'gridProduct.DataSource = Nothing
        'gridProduct.DataSource = dataTable
        'gridProduct.RefreshDataSource()
    End Sub

    Private Sub btnGetAll_Click(sender As Object, e As EventArgs) Handles btnGetAll.Click
        cm05GETAllProduct()
    End Sub

#End Region


End Class