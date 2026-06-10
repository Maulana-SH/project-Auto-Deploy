Imports System.Data.SqlClient
Imports System.IO
Imports System.Net
Imports System.Text
Imports DevExpress.Data
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Views.Grid
Imports DevExpress.XtraPrinting
Imports NCCONTROLLERlib
Imports NCMODELlib
Imports Newtonsoft.Json.Linq

Public Class frmPOSTdataTOAPI

    Implements IDisposable

    '  Private apiURL As String = "https://ilygold.cuan.co/web/product-citrix"
    'Private prm01_UserName As String = "nv0001"
    'Private prm02_password As String = "qwerty"

    ''************************* STAGGING API ******************************************
    ''URL Staging = https : //backoffice.sandradewigold.com/api-staging/penerimaan-citrix
    '   Private apiURL As String = "http://jims.sentralkreasikencana.com/api/penerimaan-citrix" '"https://backoffice.sandradewigold.com/api-staging/penerimaan-citrix"
    Private apiURL As String = "https://backoffice.sandradewigold.com/api-staging/penerimaan-citrix"
    Private prm01_UserName As String = "NV0001"
    Private prm02_password As String = "QWERTYasdf2021#"

    ''************************* STAGGING API ******************************************

    ' Private apiURL As String = "https://backoffice.ilygold.com/web/product-citrix" '(ganti Domain Kamis, 04-02-2021)

    '************************* PRODUCTION API ******************************************
    'Private apiURL As String = "https://backoffice.sandradewigold.com/api-productcode/penerimaan-citrix" '(ganti Domain jUMAT, 11-11-2022)
    'Private prm01_UserName As String = "BRJ"
    'Private prm02_password As String = "P3Nerima4nBrJ"
    '************************* PRODUCTION API ******************************************


    Private pdtDataHeaderSPK As DataTable
    Private MdlHeaderSPK As clsControllerINISHGOODWHMasters

#Region "Form Load event"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()
        ' Add any initialization after the InitializeComponent() call.
        pdtDatainbound = New DataTable
        '**** Untuk krim Data KE Server BRIODGING WH
        pdtBridging = New DataTable
        MdlBridging = New clsControllerFINISHGOODS With {.prop_dtFINISHGOODS = pdtBridging}
        MdlBridging.dtInitFINISHGOODS()

        pdtDataHeaderSPK = New DataTable
        MdlHeaderSPK = New clsControllerINISHGOODWHMasters With {.prop_dtINISHGOODWHMasters = pdtDataHeaderSPK}
        MdlHeaderSPK.dtInitINISHGOODWHMasters

    End Sub
    Private Sub frmPOSTdataTOAPI_Load(sender As Object, e As EventArgs) Handles Me.Load
        _cm00InitFieldGrid()

        ' Retransfer BRIDGING SERVER
        cmb01InitCOntrol()
        cmb02InitFieldGrid()
    End Sub

#End Region

#Region "  01 Retransfer Data To API JIMS "

#Region "API POST Variabel and Function"
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

    Private Function getResponStringJSON(ByVal prmRes As String, ByVal prmKey As String) As String
        Dim res As String = ""

        ' Dim rawresp As String = "{'isError': true, 'message': 'Pesan String JSON'}"
        Dim json As JObject = JObject.Parse(prmRes)
        'MsgBox(json.Item("message"))
        res = json.Item(prmKey).ToString

        Return res
    End Function

    Private Function convertDataTabelToJSON(ByVal prm01Nama As String, ByVal prm02SetItem As Integer, ByVal prm03kadar As Double,
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
                                 ByVal prm35Findings As String, ByVal prm37OrderStatus As String) As String
        Dim result As String = ""

        result = "{'Nama': '" & prm01Nama & "',
                        'SetItem': " & prm02SetItem & ",
                        'Kadar': " & prm03kadar & ",
                        'Qty': " & prm04qtyr & ",
                        'CollectionName': '" & prm27Item & "',
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
                        'Findings': '" & prm35Findings & "',
                        'OrderStatus': '" & prm37OrderStatus & "'                
                      }"
        Return result
    End Function

    Function RemoveCharacter(ByVal stringToCleanUp, ByVal characterToRemove)
        ' replace the target with nothing
        ' Replace() returns a new String and does not modify the current one
        Return stringToCleanUp.Replace(characterToRemove, "")
    End Function

#End Region

#Region "Custome Methods"

    Private Sub _cm00InitFieldGrid()

        col01_f03cSKU.FieldName = "f03cSKU"
        col02_f02cKodeKaret.FieldName = "f02cKodeKaret"
        col03_f12nQtyLot.FieldName = "f12nQtyLot"
        col04_f13nBeratGross.FieldName = "f13nBeratGross"
        col05_f15nTGramZircon.FieldName = "f15nTGramZircon"
        col06_f14nBeratNett.FieldName = "f14nBeratNett"
        col07_f18cCustomers.FieldName = "f18cCustomers"
        col08_f11cNamaTipeBRJ.FieldName = "f11cNamaTipeBRJ"
        col09_f08cNamaMaterial_v50.FieldName = "f08cNamaMaterial_v50"
        col10_f09cNamaKadarEmas.FieldName = "f09cNamaKadarEmas"
        col11_f20cNamaPlating_v50.FieldName = "f20cNamaPlating_v50"
        col12_f17nSize.FieldName = "f17nSize"

    End Sub

    Private Sub _cm01GetdataFromCitrix()
        GridView1.ShowLoadingPanel()

        Dim pdtHAsil As New DataTable
        Using objDataFG2BridgingPerDoc As NCMODELlib.clsNEWCENTRAL_iface = New NCMODELlib.clsNEWCENTRAL_impl With {.prop_cNoDokumen = _01NoDO.EditValue}
            pdtHAsil = objDataFG2BridgingPerDoc.GetTP9HV02TransferFG2BridgingPerDoc()
        End Using

        If pdtHAsil.Rows.Count > 0 Then
            _clblData.Text = ""
            _clblData.Text = "No Doc " & _01NoDO.EditValue & " Memiliki " & pdtHAsil.Rows.Count.ToString & " Data"
            _gridResult.DataSource = Nothing
            _gridResult.DataSource = pdtHAsil
            _gridResult.RefreshDataSource()
            GridView1.HideLoadingPanel()
            _cm02KonvertJsonString(pdtHAsil)

            btnsend.Enabled = True
        Else
            _clblData.Text = ""
            MsgBox("DO Tidak Ditemukan")
        End If

    End Sub

    Private Sub _cm02KonvertJsonString(ByVal prmDataTable As DataTable)
        If prmDataTable.Rows.Count > 0 Then

            Dim objarryJSON As String = ""
            Dim DumJSON As String = ""
            Dim Size As Integer = 0
            Dim Counter As Integer = 0
            Dim CounterErr As Integer = 0

            _02JsonString.EditValue = ""
            For Each dtRow As DataRow In prmDataTable.Rows

                '=================== UNTUK CEK SIZE ======================
                ' Jika Size bukan integer di set 0
                ' Untuk Krim ke APP JIMS (SBU)
                '=========================================================
                'If Integer.TryParse(dtRow("f17nSize"), Size) Then
                '    'MsgBox("Value Benar Integer")
                '   
                'Else
                '    'MsgBox("Value Bukan Integer")
                '    Size = 0
                'End If

                objarryJSON = convertDataTabelToJSON(dtRow("f01cNoDO").ToString, 1, RemoveCharacter(CStr(dtRow("f09cNamaKadarEmas")), "%"),
                            CInt(dtRow("f12nQtyLot")), dtRow("f01cNoDO"), dtRow("f02cKodeKaret"),
                            dtRow("f07cNamaWarnaEmas"), dtRow("f03cSKU"), "Default-Status",
                            dtRow("f02cKodeKaret"), dtRow("f04cKodeNORO"), dtRow("f05cNamaNORO"),
                            dtRow("f06cKodeWarnaEmas"), dtRow("f07cNamaWarnaEmas"), dtRow("f08cKodeKadarEmas"), dtRow("f09cNamaKadarEmas"),
                            dtRow("f10cKodeTipeBRJ"), dtRow("f11cNamaTipeBRJ"),
                            CDbl(dtRow("f13nBeratGross")), CDbl(dtRow("f14nBeratNett")),
                            CDbl(dtRow("f15nTGramZircon")), CInt(dtRow("f16TButirZircon")), dtRow("f17nSize"),
                            dtRow("f18cKodeProduksi"), dtRow("f22cNamaFinishing_v50"), dtRow("f06cNamaBrand_v50"),
                             dtRow("f11cNamaTipeBRJ"), dtRow("f08cNamaMaterial_v50"), dtRow("f18cNamaGender_v50"),
                             dtRow("f16cNamaEngrave_v50"), dtRow("f28cNamaFinding_v50"), dtRow("f20cNamaPlating_v50"),
                             dtRow("f22cNamaFinishing_v50"), dtRow("f16cNamaEngrave_v50"),
                             dtRow("f28cNamaFinding_v50"), dtRow("f02cKodeStockPesanan_v2"))

                _02JsonString.EditValue += objarryJSON & vbNewLine
            Next
        End If
    End Sub

    Private Sub _cm04PostDataToAPI()
        Me.Cursor = Cursors.WaitCursor
        Dim pdtHAsil As New DataTable
        Using objDataFG2BridgingPerDoc As NCMODELlib.clsNEWCENTRAL_iface = New NCMODELlib.clsNEWCENTRAL_impl With {.prop_cNoDokumen = _01NoDO.EditValue}
            pdtHAsil = objDataFG2BridgingPerDoc.GetTP9HV02TransferFG2BridgingPerDoc()
        End Using

        If pdtHAsil.Rows.Count > 0 Then

            Dim objarryJSON As String = ""
            Dim DumJSON As String = ""
            Dim Size As Integer = 0
            Dim Counter As Integer = 0
            Dim CounterErr As Integer = 0

            'Get Repons Reques
            Dim respons As String
            Dim IsError As String
            Dim strResponse As String

            For Each dtRow As DataRow In pdtHAsil.Rows

                '=================== UNTUK CEK SIZE ======================
                ' Jika Size bukan integer di set 0
                ' Untuk Krim ke APP JIMS (SBU)
                '=========================================================
                'If Integer.TryParse(dtRow("f17nSize"), Size) Then
                '    'MsgBox("Value Benar Integer")
                '    Size = CInt(dtRow("f17nSize"))
                'Else
                '    'MsgBox("Value Bukan Integer")
                '    Size = 0
                'End If

                objarryJSON = convertDataTabelToJSON(dtRow("f01cNoDO").ToString, 1, RemoveCharacter(CStr(dtRow("f09cNamaKadarEmas")), "%"),
                            CInt(dtRow("f12nQtyLot")), dtRow("f01cNoDO"), dtRow("f02cKodeKaret"),
                            dtRow("f07cNamaWarnaEmas"), dtRow("f03cSKU"), "Default-Status",
                            dtRow("f02cKodeKaret"), dtRow("f04cKodeNORO"), dtRow("f05cNamaNORO"),
                            dtRow("f06cKodeWarnaEmas"), dtRow("f07cNamaWarnaEmas"), dtRow("f08cKodeKadarEmas"), dtRow("f09cNamaKadarEmas"),
                            dtRow("f10cKodeTipeBRJ"), dtRow("f11cNamaTipeBRJ"),
                            CDbl(dtRow("f13nBeratGross")), CDbl(dtRow("f14nBeratNett")),
                            CDbl(dtRow("f15nTGramZircon")), CInt(dtRow("f16TButirZircon")), CStr(dtRow("f17nSize")),
                            dtRow("f18cKodeProduksi"), dtRow("f22cNamaFinishing_v50"), dtRow("f06cNamaBrand_v50"),
                             dtRow("f11cNamaTipeBRJ"), dtRow("f08cNamaMaterial_v50"), CStr(dtRow("f18cNamaGender_v50")),
                             CStr(dtRow("f16cNamaEngrave_v50")), CStr(dtRow("f28cNamaFinding_v50")), CStr(dtRow("f20cNamaPlating_v50")),
                            CStr(dtRow("f22cNamaFinishing_v50")), CStr(dtRow("f16cNamaEngrave_v50")), CStr(dtRow("f28cNamaFinding_v50")), dtRow("f02cKodeStockPesanan_v2"))

                'post Data To APi
                Dim myRequest As HttpWebRequest = PostJSON(objarryJSON) 'data nya dikirim

                'cek result DUM
                DumJSON = objarryJSON

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
                    ' MsgBox(Counter & dtRow("f01cNoDO").ToString & " | Data Terikirim")
                    _03Response.EditValue = ""
                    _03Response.EditValue = strResponse
                Else
                    'Berhasil dan hitung total data yang terkirim
                    Counter += 1
                    'MsgBox(Counter & " | Data Terikirim")
                    _03Response.EditValue = ""
                    _03Response.EditValue = strResponse
                End If

            Next
            ' MsgBox(Counter & " Data Terkirim  " & vbNewLine & CounterErr & " | Tidak Terkirim")
            MsgBox(Counter & " Data Berhasil Terkirim  ")
            btnsend.Enabled = False
        Else
            MsgBox("DO Tidak Ditemukan")
        End If
        Me.Cursor = Cursors.Default
    End Sub

#End Region

#Region "Control Evnt"
    Private Sub btnGetdata_Click(sender As Object, e As EventArgs) Handles btnGetdata.Click

        If _01NoDO.EditValue <> "" Then
            _cm01GetdataFromCitrix()
        End If
    End Sub

    Private Sub btnsend_Click(sender As Object, e As EventArgs) Handles btnsend.Click
        If _01NoDO.EditValue <> "" Then
            '  _cm04PostDataToAPI()

            MsgBox($"Sudah Di Non-Aktifkan Per Tgl 05 Feb 2025..")
        End If
    End Sub


    Private Sub CheckEdit1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckEdit1.CheckedChanged
        If CheckEdit1.CheckState = CheckState.Checked Then
            lytResponseJIms.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Always
        Else
            lytResponseJIms.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        End If
    End Sub

    Private Sub _gridResult_Click(sender As Object, e As EventArgs) Handles _gridResult.Click

    End Sub

#End Region

#Region "Grid Evnt"

#End Region

#End Region


#Region " 02 Retransfer Data To Bridging Server "

    Private pdtDatainbound As DataTable
    Private pdtBridging As DataTable
    Private MdlBridging As clsControllerFINISHGOODS


#Region " Customer Methods "

    Private Sub cmb01InitCOntrol()

        Dim prmDataToday As DateTime = Date.Now
        Dim prmTglAwal As Date
        Dim prmTglAkhir As Date

        prmTglAwal = New DateTime(prmDataToday.Year, prmDataToday.Month, 1)
        prmTglAkhir = prmTglAwal.AddMonths(1).AddDays(-1)

        lyt_01TglAwal.Enabled = False
        lyt_02tglAkhir.Enabled = False

        _01TglAwal.EditValue = prmTglAwal
        _02tglAkhir.EditValue = prmTglAkhir
    End Sub
    Private Sub cmb02InitFieldGrid()

        gvBridging.IndicatorWidth = 50
        gvBridging.OptionsView.ColumnAutoWidth = False

        colB00_bCheck.FieldName = "bCheck"
        colB01_k02SPK.FieldName = "k02SPK"
        colB02_k03ProductCode.FieldName = "k03ProductCode"
        colB03_k04DesignCode.FieldName = "k04DesignCode"
        colB04_NamaNORO.FieldName = "NamaNORO"
        colB05_NamaWarnaEmas.FieldName = "NamaWarnaEmas"
        colB06_NamaKadar.FieldName = "NamaKadar"
        colB07_NamaTipeBRJ.FieldName = "NamaTipeBRJ"
        colB08_NamaSize.FieldName = "NamaSize"
        colB09_NamaBrand.FieldName = "NamaBrand"
        colB10_NamaMaterial.FieldName = "NamaMaterial"
        colB11_NamaGender.FieldName = "NamaGender"
        colB12_NamaEngrave.FieldName = "NamaEngrave"
        colB13_OrderStatus.FieldName = "OrderStatus"
        colB14_NoDocument.FieldName = "NoDocument"
        colB15_PCSSKU.FieldName = "PCSSKU"
        colB16_ButirSTone.FieldName = "ButirSTone"
        colB17_BeratGrosss.FieldName = "BeratGrosss"
        colB18_BeratNett.FieldName = "BeratNett"
        colB19_TglInbound.FieldName = "TglInbound"
        colB20_f01NamaUser.FieldName = "f01NamaUser"
        colB21_nTtlGrossPCS.FieldName = "nTtlGrossPCS"

        colB00_bCheck.SummaryItem.SummaryType = SummaryItemType.Custom
        colB00_bCheck.SummaryItem.FieldName = "bCheck"
        colB00_bCheck.SummaryItem.DisplayFormat = "{0:n0} SPK"
    End Sub

    Private Sub cm0b03GEtdataInbound()
        pdtDatainbound.Clear()

        Using objGetData As NCMODELlib.clsNEWCENTRAL_iface = New NCMODELlib.clsNEWCENTRAL_impl With {.prop_dTglAwal = _01TglAwal.EditValue,
                                                                                                    .prop_dTglAkhir = _02tglAkhir.EditValue}
            pdtDatainbound = objGetData.Sele25AM01RetransferDataInbound
        End Using


        If pdtDatainbound.Rows.Count = 0 Then
            MsgBox($"Tidak Ada Data yang di Temukan dari Periode {_01TglAwal.Text} S/d {_02tglAkhir.Text} yang di cari", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Info...")
        End If

        gcBridging.DataSource = Nothing
        gcBridging.DataSource = pdtDatainbound
        gcBridging.RefreshDataSource()
        gvBridging.BestFitColumns()


    End Sub


    Private Sub cmb04GetDataBySKU()
        Dim pdtSKUSaja As New DataTable
        Dim ctrlSKUSAJA As New NCCONTROLLERlib.clsControllerSKUSaja With {.prop_dtSKUSaja = pdtSKUSaja}
        ctrlSKUSAJA.dtInitSKUSaja()

        ctrlSKUSAJA.prop_dtSKUSaja.Clear()

        For i As Integer = 0 To gvBridging.RowCount - 1

            If gvBridging.GetRowCellValue(i, colB00_bCheck) = True Then
                ' DETAIL
                ctrlSKUSAJA.dtAddNewSKUSaja(gvBridging.GetRowCellValue(i, colB01_k02SPK))

                ' HEADER 
                MdlHeaderSPK.dtAddNewINISHGOODWHMasters(0,
                                                        gvBridging.GetRowCellValue(i, colB01_k02SPK),
                                                        gvBridging.GetRowCellValue(i, colB02_k03ProductCode),
                                                        gvBridging.GetRowCellValue(i, colB04_NamaNORO),
                                                        gvBridging.GetRowCellValue(i, colB05_NamaWarnaEmas),
                                                        gvBridging.GetRowCellValue(i, colB08_NamaSize),
                                                        gvBridging.GetRowCellValue(i, colB09_NamaBrand),
                                                        gvBridging.GetRowCellValue(i, colB13_OrderStatus),
                                                        gvBridging.GetRowCellValue(i, colB14_NoDocument),
                                                        gvBridging.GetRowCellValue(i, colB15_PCSSKU),
                                                        gvBridging.GetRowCellValue(i, colB21_nTtlGrossPCS),    ' gvBridging.GetRowCellValue(i, colB17_BeratGrosss),
                                                         gvBridging.GetRowCellValue(i, colB18_BeratNett),
                                                        gvBridging.GetRowCellValue(i, colB19_TglInbound),
                                                        gvBridging.GetRowCellValue(i, colB20_f01NamaUser))

                MdlHeaderSPK.prop_dtINISHGOODWHMasters.AcceptChanges()
            End If

        Next i

        If ctrlSKUSAJA.prop_dtSKUSaja.Rows.Count > 0 Then

            Dim pdtHasil As New DataTable
            pdtHasil.Clear()

            Using objGetData As NCMODELlib.clsNEWCENTRAL_iface = New NCMODELlib.clsNEWCENTRAL_impl With {.prop_tp01SKUSAJA = ctrlSKUSAJA.prop_dtSKUSaja}
                pdtHasil = objGetData.Sele25AM02GetDataInboundBySPK
            End Using


            If pdtHasil.Rows.Count = 0 Then
                MsgBox($"Tidak Ada Data yang di Temukan dari SKU yang di cari", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Info...")
            Else

                Dim HelperBridging As New clsTransferFGtoBridging

                If ocKirimParent.CheckState = CheckState.Checked Then
                    ' Kirim data Header nya(data By SPK)
                    HelperBridging._cm04TransferFG2BridgingHeader(MdlHeaderSPK.prop_dtINISHGOODWHMasters)
                End If

                If ocKirimSKUPerpcs.CheckState = CheckState.Checked Then

                    ' ini Data detail By SKU (Per PCS)
                    HelperBridging.prop_nTotalSPK = ctrlSKUSAJA.prop_dtSKUSaja.Rows.Count
                    HelperBridging._cm03TransferFG2Bridging(pdtHasil)
                End If

            End If

        Else
            MsgBox($"Tidak Ada Data yang dipilih ... ", MsgBoxStyle.Exclamation + MsgBoxStyle.OkOnly, "Info...")
        End If

    End Sub

    Private Function cmb05Validasi()
        Dim isValid As Boolean = True
        Dim MsgErr As String = ""

        If _01TglAwal.EditValue Is Nothing OrElse _02tglAkhir.EditValue Is Nothing Then
            isValid = False
            MsgErr = "Maaff... pastikan Data Tanggal Di Pilih..."
        Else
            If _01TglAwal.EditValue > _02tglAkhir.EditValue Then
                isValid = False
                MsgErr = "Maaff... Tgl Awal Tidak Boleh > Dari Tgl Akhir atau Sebalik nya.."

            End If
        End If

        If Not isValid Then
            MsgBox(MsgErr, MsgBoxStyle.Information, "Information")
        End If

        Return isValid
    End Function

    Private Sub cmb06FilterData()

        Dim prmDataToday As DateTime = Date.Now
        Dim prmTglAwal As Date
        Dim prmTglAkhir As Date

        If ocFilter.CheckState = CheckState.Checked Then

            prmTglAwal = New DateTime(prmDataToday.Year, prmDataToday.Month, 1)
            prmTglAkhir = prmTglAwal.AddMonths(1).AddDays(-1)

            lyt_01TglAwal.Enabled = True
            lyt_02tglAkhir.Enabled = True
        Else
            prmTglAwal = Date.Now
            prmTglAkhir = Date.Now

            lyt_01TglAwal.Enabled = False
            lyt_02tglAkhir.Enabled = False
        End If

        _01TglAwal.EditValue = prmTglAwal
        _02tglAkhir.EditValue = prmTglAkhir

    End Sub

    Private Sub cmb07SelectAll()

        Dim selected As Boolean = False

        selected = ocSelectAll.Checked

        For i As Integer = 0 To gvBridging.RowCount - 1

            gvBridging.SetRowCellValue(i, colB00_bCheck, selected)
            gvBridging.RefreshData()
        Next i

    End Sub

#End Region


#Region " Control Event "

    Private Sub btnGEtDataInbound_Click(sender As Object, e As EventArgs) Handles btnGEtDataInbound.Click
        If cmb05Validasi() Then
            cm0b03GEtdataInbound()
        End If
    End Sub

    Private Sub btnRetransferBridging_Click(sender As Object, e As EventArgs) Handles btnRetransferBridging.Click
        Dim plYes As MsgBoxResult = MsgBox("Apakah anda yakin data ini sudah benar ... ?", vbYesNo + MsgBoxStyle.Question, " Confirmasi")

        If plYes = MsgBoxResult.Yes Then
            cmb04GetDataBySKU()
        End If

    End Sub

    Private Sub ocSelectAll_CheckedChanged(sender As Object, e As EventArgs) Handles ocSelectAll.CheckedChanged
        cmb07SelectAll()
    End Sub

#End Region

#Region " Grid Event "

    Private Sub rscol00_bCheck_CheckedChanged(sender As Object, e As EventArgs) Handles rscol00_bCheck.CheckedChanged
        gvBridging.PostEditor()
        gvBridging.RefreshData()
    End Sub
    Private Sub gvBridging_CustomDrawRowIndicator(sender As Object, e As RowIndicatorCustomDrawEventArgs) Handles gvBridging.CustomDrawRowIndicator
        ' Put This code in Init FieldName    
        ' GridView1.IndicatorWidth = 50 

        '# Methods In GridView
        'CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1 'e.RowHandle.ToString()
        End If
    End Sub

    Private Sub ocFilter_CheckedChanged(sender As Object, e As EventArgs) Handles ocFilter.CheckedChanged
        cmb06FilterData()
    End Sub

    Private Sub gvBridging_RowCellStyle(sender As Object, e As RowCellStyleEventArgs) Handles gvBridging.RowCellStyle
        If e.RowHandle >= 0 Then

            If gvBridging.GetRowCellValue(e.RowHandle, "bCheck") = True Then
                e.Appearance.BackColor = Color.GreenYellow
                e.Appearance.ForeColor = Color.Black
            Else
                e.Appearance.BackColor = Color.Transparent
                e.Appearance.ForeColor = Color.Black
            End If

        End If
    End Sub

    Dim prmTotalSKU As Integer
    Private Sub gvBridging_CustomSummaryCalculate(sender As Object, e As CustomSummaryEventArgs) Handles gvBridging.CustomSummaryCalculate
        'CUstom SUmmary Berat BAtu
        Dim view As GridView = TryCast(sender, GridView)

        'colB00_bCheck
        If e.IsTotalSummary AndAlso (TryCast(e.Item, GridSummaryItem)).FieldName = "bCheck" Then

            Dim item As GridSummaryItem = TryCast(e.Item, GridSummaryItem)

            If item.FieldName = "bCheck" Then

                Select Case e.SummaryProcess

                    Case CustomSummaryProcess.Start
                        prmTotalSKU = 0
                    Case CustomSummaryProcess.Calculate

                        Dim prmDipilih As Boolean = CBool(view.GetRowCellValue(e.RowHandle, "bCheck"))

                        If prmDipilih Then

                            prmTotalSKU += 1

                        End If

                    Case CustomSummaryProcess.Finalize

                        e.TotalValue = prmTotalSKU


                End Select
            End If

        End If
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        gcBridging.ShowPrintPreview()
    End Sub


#End Region

#End Region

End Class