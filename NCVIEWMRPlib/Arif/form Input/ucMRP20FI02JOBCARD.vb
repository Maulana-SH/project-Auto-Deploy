Imports System.Globalization
Imports System.IO
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports NCCONTROLLERlib
Imports NCMODELlib
Imports NCREPOSITORYlib

Public Class ucMRP20FI02JOBCARD
    Implements IDisposable

    'Data Master
    Public Property _01Prop_UserID As String
    Public Property _02Prop_NamaUser As String
    Public Property _03PropDataMasterSKK30 As New DataTable
    Public Property _04PropDataMasterSKK51 As New DataTable
    Public Property _05PropDataMasterRouting As New DataTable
    Public Property _06PropDataMasterMaterial21 As New DataTable
    Public Property _07PropDataMastert35 As New DataTable
    Public Property _08PropDataMastert36 As New DataTable
    Public Property _09PropDataMastert37 As New DataTable
    Public Property _10PropDataMasterGambar As New DataTable
    Public Property _11PropDataMaster23MasterStone As New DataTable
    Public Property _12PropDataMasterNCy51 As New DataTable

    Private pdt06CoreJC As DataTable
    Private ctrlNC06CoreJCSave As clsController06COREJOBCARD

    Private pdt35JOBCARD As DataTable
    Private ctrlMRP35JOBCARDSave As clsCtrlMRP35JOBCARD

    Private pdt36JOBCARDBOMGrid As DataTable
    Private ctrlMRP36JOBCARDBOMGrid As clsCtrlMRP36JOBCARDBOM

    Private pdt36JOBCARDBOMSave As DataTable
    Private ctrlMRP36JOBCARDBOMSave As clsCtrlMRP36JOBCARDBOM

    Private pdt31DesignMasterStoneGrid As DataTable
    Private ctrl31DesignMasterStoneGrid As clsCtrlMRP31DESIGNMASTERSTONE

    Private pdt37JOBCARDSTONESave As DataTable
    Private ctrl37JOBCARDSTONESave As clsCtrlMRP37JOBCARDSTONE

    Private pdt37JOBCARDSTONEGrid As DataTable
    Private ctrl37JOBCARDSTONEGrid As clsCtrlMRP37JOBCARDSTONE

    'repo lib grid
    Private _rscol01f01cKodeStoneType_v50 As repo51SKKValueMaster
    Private _rscol02f03cKodeStoneShape_v50 As repo51SKKValueMaster
    Private _rscol03f05cKodeStoneColor_v50 As repo51SKKValueMaster
    Private _rscol04f07cKodeStoneSize_v500 As repo51SKKValueMaster
    Private _rscol05k02cKodeStones_v50 As repo23MasterStoneMRP

    Private ChooseImg As New cls20FE01Gambar

    'booelean
    Private Revision As Boolean
    Private IsUpdate As Boolean

    Private Property pcValidasiCodeNEW As String = ""
    Private Property pcValidasiCodeOld As String = ""

    'TRANSALTE jobcard NC T06 & MRP T35
    Private Property JenisJOBCARD As String
    Private Property RMJOBCARD As String

#Region "Form : Event"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

        pdt31DesignMasterStoneGrid = New DataTable
        ctrl31DesignMasterStoneGrid = New clsCtrlMRP31DESIGNMASTERSTONE With {.prop_dt31DESIGNMASTERSTONE = pdt31DesignMasterStoneGrid}
        ctrl31DesignMasterStoneGrid.dtInit31DESIGNMASTERSTONE()

        pdt37JOBCARDSTONESave = New DataTable
        ctrl37JOBCARDSTONESave = New clsCtrlMRP37JOBCARDSTONE With {.prop_dt37JOBCARDSTONE = pdt37JOBCARDSTONESave}
        ctrl37JOBCARDSTONESave.dtInit37JOBCARDSTONE()

        pdt37JOBCARDSTONEGrid = New DataTable
        ctrl37JOBCARDSTONEGrid = New clsCtrlMRP37JOBCARDSTONE With {.prop_dt37JOBCARDSTONE = pdt37JOBCARDSTONESave}
        ctrl37JOBCARDSTONEGrid.dtInit37JOBCARDSTONE()

        'init class Datatabel virtual t35
        pdt35JOBCARD = New DataTable
        ctrlMRP35JOBCARDSave = New clsCtrlMRP35JOBCARD With {.prop_dt35JOBCARD = pdt35JOBCARD}
        ctrlMRP35JOBCARDSave.dtInit35JOBCARD()

        'init class vr t06
        pdt06CoreJC = New DataTable
        ctrlNC06CoreJCSave = New clsController06COREJOBCARD With {.prop_dt06COREJOBCARD = pdt06CoreJC}
        ctrlNC06CoreJCSave.dtInit06COREJOBCARD()

        'init class Datatabel virtual t36 for temporary grid
        pdt36JOBCARDBOMGrid = New DataTable
        ctrlMRP36JOBCARDBOMGrid = New clsCtrlMRP36JOBCARDBOM With {.prop_dt36JOBCARDBOM = pdt36JOBCARDBOMGrid}
        ctrlMRP36JOBCARDBOMGrid.dtInit36JOBCARDBOM()

        'init class Datatabel virtual t36 for save
        pdt36JOBCARDBOMSave = New DataTable
        ctrlMRP36JOBCARDBOMSave = New clsCtrlMRP36JOBCARDBOM With {.prop_dt36JOBCARDBOM = pdt36JOBCARDBOMSave}
        ctrlMRP36JOBCARDBOMSave.dtInit36JOBCARDBOM()

    End Sub

    Private Sub ucMRP20FI02JOBCARD_Load(sender As Object, e As EventArgs) Handles Me.Load
        _03GetdataSource()
        _04BindingAwal()
    End Sub


#End Region

#Region "Private : Methods"

    Private Function _pm01CreateNoValidasi(ByVal prmKodeSBU As String, ByVal prmIDAutoNumber As String, ByVal prmDesignMasterCode As String) As String
        Dim Noval As String = ""
        Dim pdtHasil As New DataTable
        ' Noval = mdlP7AY01Public.CreateNoWOSKU(mdlP7AY01Public._enumIDAutoNumbering._idPRODEV)

        Using objCreatNoSKU As clsMRP_iface = New clsMRP_impl With {
            .prop_KeyString01 = prmKodeSBU,
            .prop_KeyString02 = prmIDAutoNumber,
            .prop_KeyInt03Tahun = Year(Now.Date),
            .prop_KeyString03 = prmDesignMasterCode}

            pdtHasil = objCreatNoSKU.Get30CreateSKUJobCard()
        End Using

        For Each dtrow As DataRow In pdtHasil.Rows
            ' pcHasil = dtrow("f03cReserve01_v50") + dtrow("f04cReserve02_v100") + dtrow("f05nReserve02_int").ToString
            Noval = dtrow("f04cPrefix1_v3") + dtrow("f05cPrefix2_v2") + String.Format("{0:0000}", dtrow("f07nLastNumber_int"))
        Next

        Return Noval
    End Function

    Private Function _pm02ByteArrayToImage(ByVal byteArrayIn As Byte()) As Image
        Dim ms As MemoryStream = New MemoryStream(byteArrayIn)
        Dim returnImage As Image = Image.FromStream(ms)
        Return returnImage
    End Function

    Private Function _pm02imgToByteArray(ByVal img As Image) As Byte()
        Using mStream As MemoryStream = New MemoryStream()
            img.Save(mStream, img.RawFormat)
            Return mStream.ToArray()
        End Using
    End Function

    Private Function _pm03GetRouting(ByVal KMRouting As String) As DataTable
        Dim result As DataTable
        Dim pdtCopy As DataTable
        pdtCopy = _05PropDataMasterRouting

        Dim pdDataRow() As DataRow
        pdDataRow = pdtCopy.Select("k01cKodeMasterRouting_v50 = '" & KMRouting & "'")
        If pdDataRow.Count > 0 Then
            result = pdDataRow.CopyToDataTable
        Else
            result = Nothing
        End If

        Return result
    End Function

    Private Function _pm04GetMaterial(ByVal KodeItem As String) As DataRow()
        Dim pdtCopy As DataTable
        pdtCopy = _06PropDataMasterMaterial21

        Dim pdDataRow() As DataRow
        pdDataRow = pdtCopy.Select("k01cKodeItemCastedParts_v50 = '" & KodeItem & "'")
        Return pdDataRow
    End Function

    Private Sub _pm05SaveData()

        If _28cGetFrom.EditValue = "" Then
            pcValidasiCodeNEW = _01ck01cKodeValidation_v50.EditValue
        Else
            pcValidasiCodeNEW = _pm01CreateNoValidasi("SKK", "JOBCARD", _06cMasterCode.EditValue)
            pcValidasiCodeOld = _28cGetFrom.EditValue
        End If

        ' pcValidasiCodeNEW = _01ck01cKodeValidation_v50.EditValue

        If pcValidasiCodeNEW <> "" Then

            If Revision Then '--> JIka Revision

                '*********** -- SAVE UPDATE t35 ***************
                Dim Image3D01 As Byte() = Nothing
                Dim Image3D02 As Byte() = Nothing
                Dim Image3D03 As Byte() = Nothing

                If _pe3DPicture_01.Image IsNot Nothing Then
                    Image3D01 = _pm02imgToByteArray(_pe3DPicture_01.Image)
                End If
                If _pe3DPicture_02.Image IsNot Nothing Then
                    Image3D02 = _pm02imgToByteArray(_pe3DPicture_02.Image)
                End If
                If _pe3DPicture_03.Image IsNot Nothing Then
                    Image3D03 = _pm02imgToByteArray(_pe3DPicture_03.Image)
                End If

                ctrlMRP35JOBCARDSave.prop_dt35JOBCARD.Clear()
                ctrlMRP35JOBCARDSave.dtAddNew35JOBCARD(pcValidasiCodeNEW, _019cPilihRouting.EditValue, _06cMasterCode.EditValue,
                                                       _02c_Protype.EditValue, _02c_Protype.Text,
                                                       _03c_ProSubType.EditValue, _03c_ProSubType.Text,
                                                       _04cInputDate.EditValue, _05cDeliveryDate.EditValue,
                                                       _07cItemProduct.EditValue, _07cItemProduct.Text,
                                                       _08cSubItemProduct.EditValue, _08cSubItemProduct.Text,
                                                       _09cSize.EditValue, _09cSize.Text,
                                                       _010cProductProcess.EditValue, _010cProductProcess.Text,
                                                       _011cPlating.EditValue, _011cPlating.Text,
                                                       _012cFinishing.EditValue, _012cFinishing.Text,
                                                       _015cMasterType.EditValue, _015cMasterType.Text,
                                                       _016cStatusOrder.EditValue, _016cStatusOrder.Text,
                                                       _017cProjectName.EditValue, _017cProjectName.Text,
                                                       _018cProductName.EditValue, _018cProductName.Text,
                                                       _013cEstimasiBerat.EditValue,
                                                       _014cDesignerName.EditValue, _014cDesignerName.Text,
                                                       Image3D01, Image3D02, Image3D03,
                                                       _26cKeterangan.EditValue, _27cPoint.EditValue,
                                                       _29cTypeSPK.EditValue, _29cTypeSPK.Text, pcValidasiCodeOld,
                                                       _01Prop_UserID, _02Prop_NamaUser, Date.Now)


                Using objSave As clsMRP_iface = New clsMRP_impl With {.prop_KeyDataTable01 = ctrlMRP35JOBCARDSave.prop_dt35JOBCARD}
                    objSave.Save35JOBCARD()
                End Using
                '*********** -- END SAVE UPDATE t35 ***************

                '*********** -- SAVE t36BOMJOBCARD ***************
                ctrlMRP36JOBCARDBOMSave.prop_dt36JOBCARDBOM.Clear()
                For Each dtRow As DataRow In ctrlMRP36JOBCARDBOMGrid.prop_dt36JOBCARDBOM.Rows

                    ctrlMRP36JOBCARDBOMSave.dtAddNew36JOBCARDBOM(pcValidasiCodeNEW, dtRow("k02cKodeItemCastedParts_v50"),
                                                    dtRow("f01cKodeMaterial_v50"),
                                                    dtRow("f02cMaterialDesc_v50"),
                                                    dtRow("f03nQty"),
                                                    dtRow("f04nGram_n92"),
                                                    _01Prop_UserID, _02Prop_NamaUser, Date.Now)
                Next

                Using objSave36 As clsMRP_iface = New clsMRP_impl With {.prop_KeyDataTable01 = ctrlMRP36JOBCARDBOMSave.prop_dt36JOBCARDBOM}
                    objSave36.Save36JOBCARDBOM()
                End Using
                '*********** -- END SAVE t36 ***************

                ''save desinMasterStone to 37JobcardStone
                '*********** -- SAVE UPDATE to 37 ***************
                ctrl37JOBCARDSTONESave.prop_dt37JOBCARDSTONE.Clear()
                For Each dtRow As DataRow In ctrl37JOBCARDSTONEGrid.prop_dt37JOBCARDSTONE.Rows
                    ctrl37JOBCARDSTONESave.dtAddNew37JOBCARDSTONE(pcValidasiCodeNEW, _06cMasterCode.EditValue, dtRow("k03cKodeStones_v50"),
                                                                        dtRow("f01cKodeStoneType_v50"), dtRow("f02cNamaStoneType_v50"),
                                                                        dtRow("f03cKodeStoneShape_v50"), dtRow("f04cNamaStoneShape_v50"),
                                                                        dtRow("f05cKodeStoneColor_v50"), dtRow("f06cNamaStoneColor_v50"),
                                                                        dtRow("f07cKodeStoneSize_v50"), dtRow("f08cNamaStoneSize_v50"),
                                                                        dtRow("f09nButir_int"), dtRow("f10nBerat_n94"),
                                                                        dtRow("f11nStoneDistribution_n92"),
                                                                        _01Prop_UserID, _02Prop_NamaUser, Date.Now)
                Next

                Using objSave37 As clsMRP_iface = New clsMRP_impl With {.prop_KeyDataTable01 = ctrl37JOBCARDSTONESave.prop_dt37JOBCARDSTONE}
                    objSave37.Save37JOBCARDSTONE()
                End Using
                '*********** -- END SAVE UPDATE save to 37 ***************

                MsgBox("SAVE DONE ...", MsgBoxStyle.Information, "Infromasi")

                Revision = False
                _04BindingAwal()
                _03GetdataSource()

            Else '-->jika Tidak Revision
                '*********** -- SAVE t35 ***************
                ' process awal entry jobcard belum bisa Upload Gambar 3D
                ' gambar 3D di set Nothing
                Dim Image3D01 As Byte() = Nothing
                Dim Image3D02 As Byte() = Nothing
                Dim Image3D03 As Byte() = Nothing

                If _28cGetFrom.EditValue <> "" Then
                    If _pe3DPicture_01.Image IsNot Nothing Then
                        Image3D01 = _pm02imgToByteArray(_pe3DPicture_01.Image)
                    End If
                    If _pe3DPicture_02.Image IsNot Nothing Then
                        Image3D02 = _pm02imgToByteArray(_pe3DPicture_02.Image)
                    End If
                    If _pe3DPicture_03.Image IsNot Nothing Then
                        Image3D03 = _pm02imgToByteArray(_pe3DPicture_03.Image)
                    End If
                End If

                ctrlMRP35JOBCARDSave.prop_dt35JOBCARD.Clear()
                ctrlMRP35JOBCARDSave.dtAddNew35JOBCARD(pcValidasiCodeNEW, _019cPilihRouting.EditValue, _06cMasterCode.EditValue,
                                                       _02c_Protype.EditValue, _02c_Protype.Text,
                                                       _03c_ProSubType.EditValue, _03c_ProSubType.Text,
                                                       _04cInputDate.EditValue, _05cDeliveryDate.EditValue,
                                                       _07cItemProduct.EditValue, _07cItemProduct.Text,
                                                       _08cSubItemProduct.EditValue, _08cSubItemProduct.Text,
                                                       _09cSize.EditValue, _09cSize.Text,
                                                       _010cProductProcess.EditValue, _010cProductProcess.Text,
                                                       _011cPlating.EditValue, _011cPlating.Text,
                                                       _012cFinishing.EditValue, _012cFinishing.Text,
                                                       _015cMasterType.EditValue, _015cMasterType.Text,
                                                       _016cStatusOrder.EditValue, _016cStatusOrder.Text,
                                                       _017cProjectName.EditValue, _017cProjectName.Text,
                                                       _018cProductName.EditValue, _018cProductName.Text,
                                                       _013cEstimasiBerat.EditValue,
                                                       _014cDesignerName.EditValue, _014cDesignerName.Text,
                                                       Image3D01, Image3D02, Image3D03,
                                                       _26cKeterangan.EditValue, _27cPoint.EditValue,
                                                        _29cTypeSPK.EditValue, _29cTypeSPK.Text, pcValidasiCodeOld,
                                                       _01Prop_UserID, _02Prop_NamaUser, Date.Now)

                Using objSave As clsMRP_iface = New clsMRP_impl With {.prop_KeyDataTable01 = ctrlMRP35JOBCARDSave.prop_dt35JOBCARD}
                    objSave.Save35JOBCARD()
                End Using
                '*********** -- END SAVE t35 ***************

                '*********** -- SAVE to t06CoreJObcard NC ***************
                ' melengkapi data t06coreJobcard dari entrian Jobcard

                ctrlNC06CoreJCSave.prop_dt06COREJOBCARD.Clear()
                ctrlNC06CoreJCSave.dtAddNew06COREJOBCARD(pcValidasiCodeNEW, _04cInputDate.EditValue, _pm010TransalteMRPtoNC(_12PropDataMasterNCy51, _03c_ProSubType.EditValue),
                                                     "P0100", _06cMasterCode.EditValue, "NOPO t06", "Costumer to6", _06cMasterCode.EditValue,
                                                     "NORO t06", _07cItemProduct.EditValue, "Kode Stok Pesanan t06", 0, _pm010TransalteMRPtoNC(_12PropDataMasterNCy51, _015cMasterType.EditValue),
                                                     _05cDeliveryDate.EditValue, 0, _013cEstimasiBerat.EditValue, _27cPoint.EditValue, "Kode SAP",
                                                     _018cProductName.Text, _017cProjectName.EditValue, _014cDesignerName.Text, "AlasanRevisi t06",
                                                     _26cKeterangan.EditValue, _06cMasterCode.EditValue, "3000-01-01", "Kode Tingkat Kesulitan t06",
                                                     _020Brand.EditValue)

                Using objSavet35to06 As clsNEWCENTRAL_iface = New clsNEWCENTRAL_impl With {.prop_tp18TIMBANGAN = ctrlNC06CoreJCSave.prop_dt06COREJOBCARD}
                    objSavet35to06.Save06CoreJC()
                End Using
                '*********** -- END to t06 NC ***************

                '*********** -- SAVE t36BOMJOBCARD ***************
                ctrlMRP36JOBCARDBOMSave.prop_dt36JOBCARDBOM.Clear()
                For Each dtRow As DataRow In ctrlMRP36JOBCARDBOMGrid.prop_dt36JOBCARDBOM.Rows

                    ctrlMRP36JOBCARDBOMSave.dtAddNew36JOBCARDBOM(pcValidasiCodeNEW, dtRow("k02cKodeItemCastedParts_v50"),
                                                    dtRow("f01cKodeMaterial_v50"),
                                                    dtRow("f02cMaterialDesc_v50"),
                                                    dtRow("f03nQty"),
                                                    dtRow("f04nGram_n92"),
                                                    _01Prop_UserID, _02Prop_NamaUser, Date.Now)
                Next

                Using objSave36 As clsMRP_iface = New clsMRP_impl With {.prop_KeyDataTable01 = ctrlMRP36JOBCARDBOMSave.prop_dt36JOBCARDBOM}
                    objSave36.Save36JOBCARDBOM()
                End Using
                '*********** -- END SAVE t36 ***************

                ''save desinMasterStone from 31 to 37JobcardStone
                '*********** -- SAVE copy from 30 and save to 37 ***************
                ctrl37JOBCARDSTONESave.prop_dt37JOBCARDSTONE.Clear()
                For Each dtRow As DataRow In ctrl31DesignMasterStoneGrid.prop_dt31DESIGNMASTERSTONE.Rows
                    ctrl37JOBCARDSTONESave.dtAddNew37JOBCARDSTONE(pcValidasiCodeNEW, _06cMasterCode.EditValue, dtRow("k02cKodeStones_v50"),
                                                                    dtRow("f01cKodeStoneType_v50"), dtRow("f02cNamaStoneType_v50"),
                                                                    dtRow("f03cKodeStoneShape_v50"), dtRow("f04cNamaStoneShape_v50"),
                                                                    dtRow("f05cKodeStoneColor_v50"), dtRow("f06cNamaStoneColor_v50"),
                                                                    dtRow("f07cKodeStoneSize_v50"), dtRow("f08cNamaStoneSize_v50"),
                                                                    dtRow("f09nButir_int"), dtRow("f10nBerat_n94"),
                                                                    dtRow("f11nStoneDistribution_n92"),
                                                                    _01Prop_UserID, _02Prop_NamaUser, Date.Now)
                Next
                Using objSave37 As clsMRP_iface = New clsMRP_impl With {.prop_KeyDataTable01 = ctrl37JOBCARDSTONESave.prop_dt37JOBCARDSTONE}
                    objSave37.Save37JOBCARDSTONE()
                End Using
                '*********** -- END SAVE copy from 30 and save to 37 ***************
                MsgBox("SAVE DONE ...." & "New No Validation Code = " & pcValidasiCodeNEW, MsgBoxStyle.Information, "Infromasi")

                Revision = False
                _04BindingAwal()
                _03GetdataSource()
            End If

        End If

    End Sub

    Private Sub _pm08SetFillDataSize(ByVal prmKodeItem As String)

        '_09cSize.SetEditValue("")
        Dim KodeItem As String = prmKodeItem
        Dim IdGrupSizeItem As String = ""

        '#IdSizeItem=> "RINGSIZES","WOMENBANGLESIZES","NECKLACESSIZE"

        Select Case KodeItem
            Case "MTIPEC", "MTIPEM", "MTIPEW", "MTIPEA", "MTIPEY"
                IdGrupSizeItem = "RINGSIZES"
            Case "MTIPEE"
                IdGrupSizeItem = "WOMENBANGLESIZES"
            Case "MTIPER"
                IdGrupSizeItem = "NECKLACESSIZE"
        End Select

        If IdGrupSizeItem <> "" Then
            With _09cSize
                ._01prop_dtMasterSKK = _04PropDataMasterSKK51
                ._02prop_FilterKodeMasterSKK = IdGrupSizeItem
                ._03BindingAwalDataSource()
                ._04FilterDataViewMasterSKK()
            End With
        End If

    End Sub

    Private Sub _pm09setImageByNovalidation(ByVal prmNoval As String)

        Dim pdRowt35 As DataRow()
        pdRowt35 = _07PropDataMastert35.Select("k01cKodeValidation_v50 = '" & prmNoval & "'")
        If pdRowt35.Count > 0 Then
            For Each itemRow As Object In pdRowt35

                If Not TypeOf itemRow("f30objGambar3D01") Is DBNull Then
                    _pe3DPicture_01.Image = _pm02ByteArrayToImage(itemRow("f30objGambar3D01"))
                Else
                    _pe3DPicture_01.Image = Nothing
                End If

                If Not TypeOf itemRow("f31objGambar3D02") Is DBNull Then
                    _pe3DPicture_02.Image = _pm02ByteArrayToImage(itemRow("f31objGambar3D02"))
                Else
                    _pe3DPicture_02.Image = Nothing
                End If

                If Not TypeOf itemRow("f32objGambar3D03") Is DBNull Then
                    _pe3DPicture_03.Image = _pm02ByteArrayToImage(itemRow("f32objGambar3D03"))
                Else
                    _pe3DPicture_03.Image = Nothing
                End If

            Next
        End If

    End Sub

    Private Function _pm010TransalteMRPtoNC(ByVal prmDataTable As DataTable, ByVal kodeTranslateMRP As String) As String
        Dim SetName As String

        'Tc01
        'Dim pdRow() As DataRow = _12PropDataMasterNCy51.Select("f05cKodeMRPTranslate_v50 = '" & kodeTranslateMRP & "'")
        Dim pdRow() As DataRow = prmDataTable.Select("f05cKodeMRPTranslate_v50 = '" & kodeTranslateMRP & "'")
        If pdRow.Count > 0 Then
            SetName = pdRow(0).Item("k01cKodeFieldValueMaster_v50")
            'For Each itemRow As Object In pdRow
            '    SetName = itemRow("k01cKodeFieldValueMaster_v50")
            'Next
        End If


        Return SetName
    End Function

    '*** retrun String nama Stone
    Private Function _cm011GetNamaByCode(ByVal prmDataTable As DataTable, ByVal KodeType As String) As String
        Dim SetName As String
        Dim pdRow() As DataRow = prmDataTable.Select("k01cKodeFieldValueMaster_v50 = '" & KodeType & "'")
        If pdRow.Count > 0 Then
            SetName = pdRow(0).Item("f01cIsiFieldValueMaster_v50")
        End If
        Return SetName
    End Function

    '**** RETRUN datrow get 
    'Private Function _cm011GetNamaByCode(ByVal prmDataTable As DataTable, ByVal KodeType As String) As DataRow()
    '    Dim pdRow() As DataRow = prmDataTable.Select("k01cKodeFieldValueMaster_v50 = '" & KodeType & "'")
    '    If pdRow.Count > 0 Then
    '        Return pdRow
    '    End If
    'End Function

    Private Function IsValid() As Boolean
        Dim plHasil As Boolean = True
        Dim pcMsgErr As String = ""


        If _02c_Protype.EditValue = "" Then
            plHasil = False
            pcMsgErr = " ProType kosong ... !!"
        End If

        If plHasil Then
            If _03c_ProSubType.EditValue = "" Then
                plHasil = False
                pcMsgErr = " ProType kosong ... !!"
            End If
        End If

        If plHasil Then
            If _06cMasterCode.EditValue = "" Then
                plHasil = False
                pcMsgErr = " Master Code kosong ... !!"
            End If
        End If

        If plHasil Then
            If _07cItemProduct.EditValue = "" Then
                plHasil = False
                pcMsgErr = " Item  kosong ... !!"
            End If
        End If

        If plHasil Then
            If _08cSubItemProduct.EditValue = "" Then
                plHasil = False
                pcMsgErr = " Sub Item kosong ... !!"
            End If
        End If


        If plHasil Then
            If _010cProductProcess.EditValue = "" Then
                plHasil = False
                pcMsgErr = " Product Process kosong ... !!"
            End If
        End If

        If plHasil Then
            If _011cPlating.EditValue = "" Then
                plHasil = False
                pcMsgErr = " Plating kosong ... !!"
            End If
        End If

        If plHasil Then
            If _012cFinishing.EditValue = "" Then
                plHasil = False
                pcMsgErr = " Finishing kosong ... !!"
            End If
        End If


        If plHasil Then
            If _014cDesignerName.EditValue = "" Then
                plHasil = False
                pcMsgErr = " Designer Name kosong ... !!"
            End If
        End If

        If plHasil Then
            If _015cMasterType.EditValue = "" Then
                plHasil = False
                pcMsgErr = " Master Type kosong ... !!"
            End If
        End If

        If plHasil Then
            If _016cStatusOrder.EditValue = "" Then
                plHasil = False
                pcMsgErr = " Status Order kosong ... !!"
            End If
        End If
        If plHasil Then
            If _017cProjectName.EditValue = "" Then
                plHasil = False
                pcMsgErr = " Project Name kosong ... !!"
            End If
        End If
        If plHasil Then
            If _018cProductName.EditValue = "" Then
                plHasil = False
                pcMsgErr = " Product Name kosong ... !!"
            End If
        End If
        If plHasil Then
            If _019cPilihRouting.EditValue = "" Then
                plHasil = False
                pcMsgErr = " Routing kosong ... !!"
            End If
        End If

        If Not plHasil Then
            MsgBox(pcMsgErr, MsgBoxStyle.Information, "Informasi..")
        End If

        Return plHasil
    End Function

    Private Sub _pm012ShowDataEditFrom35(ByVal prmKodeValidation As String)
        'set value from t35
        Dim KodeVd As String = prmKodeValidation
        Dim pdRow35 As DataRow()
        pdRow35 = _07PropDataMastert35.Select("k01cKodeValidation_v50 = '" & KodeVd & "'")

        If pdRow35.Count > 0 Then

            For Each itemRow As Object In pdRow35
                _02c_Protype.EditValue = CStr(itemRow("f01cKodeJCProductType_v50"))
                _03c_ProSubType.EditValue = CStr(itemRow("f03cKodeJCProductSubtype_v50"))
                _04cInputDate.EditValue = CStr(itemRow("f05dInputDateAdmin"))
                _05cDeliveryDate.EditValue = CStr(itemRow("f06dDeliveryDate"))
                _06cMasterCode.EditValue = CStr(itemRow("k03cKodeDesignMaster"))
                _07cItemProduct.EditValue = CStr(itemRow("f07cKodeItemProduct_v50"))

                _pm08SetFillDataSize(CStr(itemRow("f07cKodeItemProduct_v50")))

                _08cSubItemProduct.EditValue = CStr(itemRow("f09cKodeSubItemProduct_v50"))
                _09cSize.SetEditValue(itemRow("f11cKodeSize_v50"))
                _010cProductProcess.SetEditValue(CStr(itemRow("f13cKodeProductionProcess_v50")))
                _011cPlating.SetEditValue(itemRow("f15cKodePlating_v50"))
                _012cFinishing.SetEditValue(itemRow("f17cKodeKodeFinishing_v50"))
                _013cEstimasiBerat.EditValue = CStr(itemRow("f27nEstimasiBerat_n92"))
                _015cMasterType.EditValue = CStr(itemRow("f19cKodeMasterType_v50"))
                _016cStatusOrder.EditValue = CStr(itemRow("f21cKodeStatusOrder_v50"))
                _017cProjectName.EditValue = CStr(itemRow("f23cKodeProject_v50"))
                _018cProductName.EditValue = CStr(itemRow("f25cKodeProduct_v50"))
                _013cEstimasiBerat.EditValue = CStr(itemRow("f27nEstimasiBerat_n92"))
                _014cDesignerName.EditValue = CStr(itemRow("f28cKodeDesigner_v50"))
                _019cPilihRouting.EditValue = CStr(itemRow("k02cKodeMasterRouting_v50"))
                _26cKeterangan.EditValue = CStr(itemRow("f33cKeterangan_v100"))
                _27cPoint.EditValue = CStr(itemRow("f34nPoint_n92"))
                _29cTypeSPK.EditValue = CStr(itemRow("f35cKodeTypeSPK"))
            Next

            'set brand
            Dim pdRow As DataRow()
            pdRow = _03PropDataMasterSKK30.Select("k01cKodeDesignMaster_v50 = '" & _06cMasterCode.EditValue & "' ")
            For Each itemRow As Object In pdRow
                _020Brand.EditValue = CStr(itemRow("f01cKodeBrand_v50"))
            Next

            'Set grid Stone from 37JobcardStone
            Dim pdRow37 As DataRow()
            pdRow37 = _09PropDataMastert37.Select("k01cKodeValidation_v50 = '" & KodeVd & "'")

            If pdRow37.Count > 0 Then
                ctrl37JOBCARDSTONEGrid.prop_dt37JOBCARDSTONE.Clear()
                ctrl37JOBCARDSTONEGrid.prop_dt37JOBCARDSTONE = pdRow37.CopyToDataTable
                _gcJCStone.DataSource = Nothing
                _gcJCStone.DataSource = ctrl37JOBCARDSTONEGrid.prop_dt37JOBCARDSTONE
                _gcJCStone.Refresh()
            Else
                _cm02InitFieldGridStone37()
            End If

            'set Image
            _pm09setImageByNovalidation(KodeVd)

            'set 36JCBOM grid
            Dim pdRow36 As DataRow()
            pdRow36 = _08PropDataMastert36.Select("k01cKodeValidation_v50 = '" & KodeVd & "'")
            If pdRow36.Count > 0 Then
                ctrlMRP36JOBCARDBOMGrid.prop_dt36JOBCARDBOM.Clear()
                ctrlMRP36JOBCARDBOMGrid.prop_dt36JOBCARDBOM = pdRow36.CopyToDataTable
                _gcBOM.DataSource = Nothing
                _gcBOM.DataSource = ctrlMRP36JOBCARDBOMGrid.prop_dt36JOBCARDBOM
            End If
        Else
            MsgBox("Maaf... NO Validasi Tidak Ditemukan ...", MsgBoxStyle.MsgBoxRight, "Information")
            _04BindingAwal()
        End If
    End Sub

    Private Sub _pm013ShowDataEditFrom30(ByVal prmKodeValidations As String)

        Dim pdRow As DataRow()
        Dim pcSKUJOBCARD As String
        pcSKUJOBCARD = prmKodeValidations
        pdRow = _03PropDataMasterSKK30.Select("f01cNoJobCard_v50 = '" & pcSKUJOBCARD & "' ") 'from dt30 triger sko jobcard

        If pdRow.Count > 0 Then
            For Each itemRow As Object In pdRow
                _06cMasterCode.EditValue = CStr(itemRow("k01cKodeDesignMaster_v50"))
                _07cItemProduct.EditValue = CStr(itemRow("f07cKodeItemProduct_v50"))

                _pm08SetFillDataSize(CStr(itemRow("f07cKodeItemProduct_v50")))

                _08cSubItemProduct.EditValue = CStr(itemRow("f09cKodeSubItemProduct_v50"))
                _09cSize.SetEditValue(CStr(itemRow("f18cKodeSize_v50")))
                _010cProductProcess.SetEditValue(itemRow("f11cKodeProductionProcess_v50"))
                _011cPlating.SetEditValue(itemRow("f13cKodePlating_v50"))
                _012cFinishing.SetEditValue(itemRow("f15cKodeFinishing_v50"))
                _013cEstimasiBerat.EditValue = CStr(itemRow("f17nGrossWeight_n94"))
                _017cProjectName.EditValue = CStr(itemRow("f03cKodeProject_v50"))
                _018cProductName.EditValue = CStr(itemRow("f05cKodeNamingProduct_v50"))
                _020Brand.EditValue = CStr(itemRow("f01cKodeBrand_v50"))
            Next

            'Set grid Design Stone
            _cm02InitFieldGridStone31()

            Dim pdtMaster31 As DataTable
            Using objMaster31 As clsMRP_iface = New clsMRP_impl With {.prop_KeyString01 = _06cMasterCode.EditValue}
                pdtMaster31 = objMaster31.Sele31DESIGNMASTERSTONE()
            End Using

            If pdtMaster31.Rows.Count > 0 Then
                ctrl31DesignMasterStoneGrid.prop_dt31DESIGNMASTERSTONE.Clear()
                ctrl31DesignMasterStoneGrid.prop_dt31DESIGNMASTERSTONE = pdtMaster31
                _gcJCStone.DataSource = Nothing
                _gcJCStone.DataSource = ctrl31DesignMasterStoneGrid.prop_dt31DESIGNMASTERSTONE
                _gcJCStone.Refresh()
            End If
        Else
            MsgBox("Maaf... NO Validasi Tidak Ditemukan ...", MsgBoxStyle.MsgBoxRight, "Information")
            _04BindingAwal()
        End If

    End Sub

    Private Sub _pm014ShowDataGetFrom(ByVal prmKodeValidation As String)
        'set value from t35
        Dim KodeVd As String = prmKodeValidation
        Dim pdRow35 As DataRow()
        pdRow35 = _07PropDataMastert35.Select("k01cKodeValidation_v50 = '" & KodeVd & "'")

        If pdRow35.Count > 0 Then

            For Each itemRow As Object In pdRow35
                _01ck01cKodeValidation_v50.EditValue = CStr(itemRow("k01cKodeValidation_v50"))
                _02c_Protype.EditValue = CStr(itemRow("f01cKodeJCProductType_v50"))
                _03c_ProSubType.EditValue = CStr(itemRow("f03cKodeJCProductSubtype_v50"))
                _04cInputDate.EditValue = CStr(itemRow("f05dInputDateAdmin"))
                _05cDeliveryDate.EditValue = CStr(itemRow("f06dDeliveryDate"))
                _06cMasterCode.EditValue = CStr(itemRow("k03cKodeDesignMaster"))
                _07cItemProduct.EditValue = CStr(itemRow("f07cKodeItemProduct_v50"))

                _pm08SetFillDataSize(CStr(itemRow("f07cKodeItemProduct_v50")))

                _08cSubItemProduct.EditValue = CStr(itemRow("f09cKodeSubItemProduct_v50"))
                _09cSize.SetEditValue(itemRow("f11cKodeSize_v50"))
                _010cProductProcess.SetEditValue(CStr(itemRow("f13cKodeProductionProcess_v50")))
                _011cPlating.SetEditValue(itemRow("f15cKodePlating_v50"))
                _012cFinishing.SetEditValue(itemRow("f17cKodeKodeFinishing_v50"))
                _013cEstimasiBerat.EditValue = CStr(itemRow("f27nEstimasiBerat_n92"))
                _015cMasterType.EditValue = CStr(itemRow("f19cKodeMasterType_v50"))
                _016cStatusOrder.EditValue = CStr(itemRow("f21cKodeStatusOrder_v50"))
                _017cProjectName.EditValue = CStr(itemRow("f23cKodeProject_v50"))
                _018cProductName.EditValue = CStr(itemRow("f25cKodeProduct_v50"))
                _013cEstimasiBerat.EditValue = CStr(itemRow("f27nEstimasiBerat_n92"))
                _014cDesignerName.EditValue = CStr(itemRow("f28cKodeDesigner_v50"))
                _019cPilihRouting.EditValue = CStr(itemRow("k02cKodeMasterRouting_v50"))
                _26cKeterangan.EditValue = CStr(itemRow("f33cKeterangan_v100"))
                _27cPoint.EditValue = CStr(itemRow("f34nPoint_n92"))
                _29cTypeSPK.EditValue = CStr(itemRow("f35cKodeTypeSPK"))
            Next

            'set brand
            Dim pdRow As DataRow()
            pdRow = _03PropDataMasterSKK30.Select("k01cKodeDesignMaster_v50 = '" & _06cMasterCode.EditValue & "' ")
            For Each itemRow As Object In pdRow
                _020Brand.EditValue = CStr(itemRow("f01cKodeBrand_v50"))
            Next

            'Set grid Stone from 37JobcardStone
            Dim pdRow37 As DataRow()
            pdRow37 = _09PropDataMastert37.Select("k01cKodeValidation_v50 = '" & KodeVd & "'")

            If pdRow37.Count > 0 Then
                ctrl37JOBCARDSTONEGrid.prop_dt37JOBCARDSTONE.Clear()
                ctrl37JOBCARDSTONEGrid.prop_dt37JOBCARDSTONE = pdRow37.CopyToDataTable
                _gcJCStone.DataSource = Nothing
                _gcJCStone.DataSource = ctrl37JOBCARDSTONEGrid.prop_dt37JOBCARDSTONE
                _gcJCStone.Refresh()
            Else
                _cm02InitFieldGridStone37()
            End If

            'set Image
            _pm09setImageByNovalidation(KodeVd)

            'set 36JCBOM grid
            Dim pdRow36 As DataRow()
            pdRow36 = _08PropDataMastert36.Select("k01cKodeValidation_v50 = '" & KodeVd & "'")
            If pdRow36.Count > 0 Then
                ctrlMRP36JOBCARDBOMGrid.prop_dt36JOBCARDBOM.Clear()
                ctrlMRP36JOBCARDBOMGrid.prop_dt36JOBCARDBOM = pdRow36.CopyToDataTable
                _gcBOM.DataSource = Nothing
                _gcBOM.DataSource = ctrlMRP36JOBCARDBOMGrid.prop_dt36JOBCARDBOM
            End If
        Else
            MsgBox("Maaf... NO Validasi Tidak Ditemukan ...", MsgBoxStyle.MsgBoxRight, "Information")
            _04BindingAwal()
        End If
    End Sub

#End Region

#Region "Public : Custom Methods"

    Public Sub _cm01InitControl()

        'With _01ck01cKodeValidation_v50
        '    ._01prop_dtMasterSKOJobcard = _03PropDataMasterSKK30
        '    ._02BindingAwalDataSurce()
        'End With

        With _02c_Protype
            ._01prop_dtMasterSKK = _04PropDataMasterSKK51
            ._02prop_FilterKodeMasterSKK = "JCTYPE"
            ._03BindingAwalDataSurce()
            ._04FilterDataViewMasterSKK()
        End With

        With _03c_ProSubType
            ._01prop_dtMasterSKK = _04PropDataMasterSKK51
            ._02prop_FilterKodeMasterSKK = "JCSUBTYPE"
            ._03BindingAwalDataSurce()
            ._04FilterDataViewMasterSKK()
        End With

        With _06cMasterCode
            ._01prop_dtDesignMasterSKK = _03PropDataMasterSKK30
            ._02BindingAwalDataSurce()
        End With

        With _07cItemProduct
            ._01prop_dtMasterSKK = _04PropDataMasterSKK51
            ._02prop_FilterKodeMasterSKK = "ITEMPRODUCT"
            ._03BindingAwalDataSurce()
            ._04FilterDataViewMasterSKK()
        End With

        _pm08SetFillDataSize(_07cItemProduct.EditValue)

        With _08cSubItemProduct
            ._01prop_dtMasterSKK = _04PropDataMasterSKK51
            ._02prop_FilterKodeMasterSKK = "SUBITEMPRODUCT"
            ._03BindingAwalDataSurce()
            ._04FilterDataViewMasterSKK()
        End With

        With _010cProductProcess
            ._01prop_dtMasterSKK = _04PropDataMasterSKK51
            ._02prop_FilterKodeMasterSKK = "PRODUCTIONPROCESS"
            ._03BindingAwalDataSource()
            ._04FilterDataViewMasterSKK()
        End With

        With _011cPlating
            ._01prop_dtMasterSKK = _04PropDataMasterSKK51
            ._02prop_FilterKodeMasterSKK = "PLATING"
            ._03BindingAwalDataSource()
            ._04FilterDataViewMasterSKK()
        End With

        With _012cFinishing
            ._01prop_dtMasterSKK = _04PropDataMasterSKK51
            ._02prop_FilterKodeMasterSKK = "FINISHING"
            ._03BindingAwalDataSource()
            ._04FilterDataViewMasterSKK()
        End With

        'from MRP
        'With _014cDesignerName
        '    ._01prop_dtMasterSKK = _04PropDataMasterSKK51
        '    ._02prop_FilterKodeMasterSKK = "JCDESIGNER"
        '    ._03BindingAwalDataSurce()
        '    ._04FilterDataViewMasterSKK()
        'End With

        '******** From NCy51
        With _014cDesignerName
            ._01prop_dtMasterSKK = _12PropDataMasterNCy51
            '._02prop_FilterKodeMasterSKK = "OPRJCAD"
            ._02prop_FilterKodeMasterSKK = "PDEVOPR3DDESIGN"
            ._03BindingAwalDataSurce()
            ._04FilterDataViewMasterSKK()
        End With

        With _29cTypeSPK
            ._01prop_dtMasterSKK = _12PropDataMasterNCy51
            ._02prop_FilterKodeMasterSKK = "MJSPK"
            ._03BindingAwalDataSurce()
            ._04FilterDataViewMasterSKK()
        End With

        '******** From NCy51

        With _015cMasterType
            ._01prop_dtMasterSKK = _04PropDataMasterSKK51
            ._02prop_FilterKodeMasterSKK = "JCMASTER"
            ._03BindingAwalDataSurce()
            ._04FilterDataViewMasterSKK()
        End With

        With _016cStatusOrder
            ._01prop_dtMasterSKK = _04PropDataMasterSKK51
            ._02prop_FilterKodeMasterSKK = "JCORDERSTATUS"
            ._03BindingAwalDataSurce()
            ._04FilterDataViewMasterSKK()
        End With

        With _017cProjectName
            ._01prop_dtMasterSKK = _04PropDataMasterSKK51
            ._02prop_FilterKodeMasterSKK = "PROJECTDESIGN"
            ._03BindingAwalDataSurce()
            ._04FilterDataViewMasterSKK()
        End With

        With _018cProductName
            ._01prop_dtMasterSKK = _04PropDataMasterSKK51
            ._02prop_FilterKodeMasterSKK = "NAMINGPRODUCT"
            ._03BindingAwalDataSurce()
            ._04FilterDataViewMasterSKK()
        End With

        With _019cPilihRouting
            ._01prop_dt20MasterRouting = _05PropDataMasterRouting
            ._02BindingAwalDataSurce()
            ._05FilterRoutingJOBCARD()
        End With

        With _020Brand
            ._01prop_dtMasterSKK = _04PropDataMasterSKK51
            ._02prop_FilterKodeMasterSKK = "BRAND"
            ._03BindingAwalDataSurce()
            ._04FilterDataViewMasterSKK()
        End With

        'master Material
        With _25cMasterMaterial
            ._01prop_dt21MCMaterialSKK = _06PropDataMasterMaterial21
            ._04BindingAwalDataSurce()
        End With

    End Sub

    Sub _cm02InitFieldGridStone31()

        'set grid 31desigmaster
        With _gvJCStone

            col01_f01cKodeStoneType_v50.FieldName = "f01cKodeStoneType_v50"
            col02_f03cKodeStoneShape_v50.FieldName = "f03cKodeStoneShape_v50"
            col03_f05cKodeStoneColor_v50.FieldName = "f05cKodeStoneColor_v50"
            col04_f07cKodeStoneSize_v50.FieldName = "f07cKodeStoneSize_v50"
            col05_f09nButir_int.FieldName = "f09nButir_int"
            col06_f10nBerat_n94.FieldName = "f10nBerat_n94"
            col07_f11nStoneDistribution_n92.FieldName = "f11nStoneDistribution_n92"
            col08_f02cNamaStoneType_v50.FieldName = "f02cNamaStoneType_v50"
            col08_f02cNamaStoneType_v50.Visible = False
            col09_f04cNamaStoneShape_v50.FieldName = "f04cNamaStoneShape_v50"
            col09_f04cNamaStoneShape_v50.Visible = False
            col10_f06cNamaStoneColor_v50.FieldName = "f06cNamaStoneColor_v50"
            col10_f06cNamaStoneColor_v50.Visible = False
            col11_f08cNamaStoneSize_v50.FieldName = "f08cNamaStoneSize_v50"
            col11_f08cNamaStoneSize_v50.Visible = False
            col12_k02cKodeStones_v50.Caption = "STONE CODE"
            col12_k02cKodeStones_v50.FieldName = "k02cKodeStones_v50"

            _gcJCStone.DataSource = Nothing
            ctrl31DesignMasterStoneGrid.prop_dt31DESIGNMASTERSTONE.Clear()
            _gcJCStone.DataSource = ctrl31DesignMasterStoneGrid.prop_dt31DESIGNMASTERSTONE
            _gcJCStone.Refresh()

        End With

    End Sub

    Sub _cm02InitFieldGridStone37()

        'set grid 37JCStones
        With _gvJCStone

            col01_f01cKodeStoneType_v50.FieldName = "f01cKodeStoneType_v50"
            col02_f03cKodeStoneShape_v50.FieldName = "f03cKodeStoneShape_v50"
            col03_f05cKodeStoneColor_v50.FieldName = "f05cKodeStoneColor_v50"
            col04_f07cKodeStoneSize_v50.FieldName = "f07cKodeStoneSize_v50"
            col05_f09nButir_int.FieldName = "f09nButir_int"
            col06_f10nBerat_n94.FieldName = "f10nBerat_n94"
            col07_f11nStoneDistribution_n92.FieldName = "f11nStoneDistribution_n92"
            col08_f02cNamaStoneType_v50.FieldName = "f02cNamaStoneType_v50"
            col08_f02cNamaStoneType_v50.Visible = False
            col09_f04cNamaStoneShape_v50.FieldName = "f04cNamaStoneShape_v50"
            col09_f04cNamaStoneShape_v50.Visible = False
            col10_f06cNamaStoneColor_v50.FieldName = "f06cNamaStoneColor_v50"
            col10_f06cNamaStoneColor_v50.Visible = False
            col11_f08cNamaStoneSize_v50.FieldName = "f08cNamaStoneSize_v50"
            col11_f08cNamaStoneSize_v50.Visible = False
            col12_k02cKodeStones_v50.Caption = "STONE CODE"
            col12_k02cKodeStones_v50.FieldName = "k03cKodeStones_v50"

            _gcJCStone.DataSource = Nothing
            ctrl37JOBCARDSTONEGrid.prop_dt37JOBCARDSTONE.Clear()
            _gcJCStone.DataSource = ctrl37JOBCARDSTONEGrid.prop_dt37JOBCARDSTONE
            _gcJCStone.Refresh()

        End With

    End Sub

    Sub _cm03InitFieldgridBOM()
        'Grid 36JOBCARDBOM
        With _gcBOM
            With _gvBOM
                With .Appearance

                    With .HeaderPanel
                        .Options.UseBackColor = True
                        .TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                        .Font = New Font("Arial", 9, FontStyle.Bold, GraphicsUnit.Point)
                    End With

                End With

            End With
            col01_k01cKodeMaterial_v50.FieldName = "f01cKodeMaterial_v50"
            col01_k01cKodeMaterial_v50.Caption = "MATERIAL CODE"
            col02_f03cRawMaterialDesc_v50.FieldName = "f02cMaterialDesc_v50"
            col02_f03cRawMaterialDesc_v50.Caption = "MATERIAL DESC"
            col03_f03nQty.FieldName = "f03nQty"
            col03_f03nQty.Caption = "QTY"
            col04_Berat.FieldName = "f04nGram_n92"
            col04_Berat.Caption = "GRAM"
            col05_k02cKodeItemCastedParts_v50.FieldName = "k02cKodeItemCastedParts_v50"

            ctrlMRP36JOBCARDBOMGrid.prop_dt36JOBCARDBOM.Clear()
            _gcBOM.DataSource = Nothing
            _gcBOM.DataSource = ctrlMRP36JOBCARDBOMGrid.prop_dt36JOBCARDBOM
            _gcBOM.Refresh()

        End With
    End Sub

    Sub _cm04InitFieldGridRouting()
        'grid Routing
        _019cPilihRouting.EditValue = ""
        With _gvRouting
            .OptionsView.ShowGroupPanel = False
            _col01NoUrut.FieldName = "f05nNoUrutRouting_int"
            _col01NoUrut.Caption = "NO"
            _col01NoUrut.Width = 20

            _col02Process.FieldName = "k02cKodeProsesProduksi_v50"
            _col02Process.Caption = "KODE PROCESS"
            col03_f06cNamaProsesProduksi_v50.FieldName = "f06cNamaProsesProduksi_v50"
            col03_f06cNamaProsesProduksi_v50.Caption = "PROCESS"
        End With
        _gcRouting.DataSource = Nothing
        _gcRouting.Refresh()
    End Sub

    Sub _cm05EntryClear()

        If Revision Then
            _28cRevision.Checked = True
        Else
            _28cRevision.Checked = False
            _01ck01cKodeValidation_v50.EditValue = ""
        End If
        '_28cRevision.Checked = False
        '_01ck01cKodeValidation_v50.EditValue = ""
        lytKodeValidasi.Enabled = True
        _02c_Protype.EditValue = ""
        _03c_ProSubType.EditValue = ""
        _04cInputDate.EditValue = Date.Today
        _05cDeliveryDate.EditValue = Date.Today.AddDays(3) 'Format(DateAdd(DateInterval.Day, 3, _04cInputDate.EditValue), "dd/MM/yyyy")
        _06cMasterCode.Text = ""
        _07cItemProduct.EditValue = ""
        _08cSubItemProduct.EditValue = ""
        _09cSize.SetEditValue("")
        _010cProductProcess.SetEditValue("")
        _011cPlating.SetEditValue("")
        _012cFinishing.SetEditValue("")
        _015cMasterType.EditValue = ""
        _016cStatusOrder.EditValue = ""
        _017cProjectName.EditValue = ""
        _018cProductName.EditValue = ""
        _013cEstimasiBerat.EditValue = 0
        '_019cPilihRouting.EditValue = ""
        _020Brand.EditValue = ""
        _014cDesignerName.EditValue = ""
        _26cKeterangan.EditValue = ""
        _27cPoint.EditValue = 0
        _28cGetFrom.EditValue = ""
        _29cTypeSPK.EditValue = ""

        JenisJOBCARD = ""
        RMJOBCARD = ""

        _pe3DPicture_01.Image = Nothing
        _pe3DPicture_02.Image = Nothing
        _pe3DPicture_03.Image = Nothing

    End Sub

    Sub _cm06InitRepo()

        _rscol01f01cKodeStoneType_v50 = New repo51SKKValueMaster With {._prop_01dt51ValueMasterSKK = _04PropDataMasterSKK51, ._prop_02cTargetGroupMaster = "STONETYPE"}
        _rscol01f01cKodeStoneType_v50._01BindingAwalDataSurce()
        _rscol01f01cKodeStoneType_v50._02FilterDataProsesProdMRP()
        col01_f01cKodeStoneType_v50.ColumnEdit = _rscol01f01cKodeStoneType_v50

        _rscol02f03cKodeStoneShape_v50 = New repo51SKKValueMaster With {._prop_01dt51ValueMasterSKK = _04PropDataMasterSKK51, ._prop_02cTargetGroupMaster = "STONESHAPE"}
        _rscol02f03cKodeStoneShape_v50._01BindingAwalDataSurce()
        _rscol02f03cKodeStoneShape_v50._02FilterDataProsesProdMRP()
        col02_f03cKodeStoneShape_v50.ColumnEdit = _rscol02f03cKodeStoneShape_v50

        _rscol03f05cKodeStoneColor_v50 = New repo51SKKValueMaster With {._prop_01dt51ValueMasterSKK = _04PropDataMasterSKK51, ._prop_02cTargetGroupMaster = "STONECOLOR"}
        _rscol03f05cKodeStoneColor_v50._01BindingAwalDataSurce()
        _rscol03f05cKodeStoneColor_v50._02FilterDataProsesProdMRP()
        col03_f05cKodeStoneColor_v50.ColumnEdit = _rscol03f05cKodeStoneColor_v50

        _rscol04f07cKodeStoneSize_v500 = New repo51SKKValueMaster With {._prop_01dt51ValueMasterSKK = _04PropDataMasterSKK51, ._prop_02cTargetGroupMaster = "STONESIZE"}
        _rscol04f07cKodeStoneSize_v500._01BindingAwalDataSurce()
        _rscol04f07cKodeStoneSize_v500._02FilterDataProsesProdMRP()
        col04_f07cKodeStoneSize_v50.ColumnEdit = _rscol04f07cKodeStoneSize_v500

        _rscol05k02cKodeStones_v50 = New repo23MasterStoneMRP With {._prop_01dt23MasterStoneMRP = _11PropDataMaster23MasterStone}
        _rscol05k02cKodeStones_v50._01BindingAwalDataSurce()
        col12_k02cKodeStones_v50.ColumnEdit = _rscol05k02cKodeStones_v50

    End Sub

#End Region

#Region "Control : Event"

    Private Sub _06cMasterCode_EditValueChanged(sender As Object, e As EventArgs)
        'If _06cMasterCode.EditValue <> "" Then

        '    Dim KodeDesigMaster As String
        '    KodeDesigMaster = _06cMasterCode.EditValue

        '    Dim pdRow As DataRow()
        '    pdRow = _06cMasterCode._03GetRecordTerpilih 'from dt30

        '    For Each itemRow As Object In pdRow
        '        _07cItemProduct.EditValue = CStr(itemRow("f07cKodeItemProduct_v50"))
        '        _08cSubItemProduct.EditValue = CStr(itemRow("f09cKodeSubItemProduct_v50"))
        '        _09cSize.SetEditValue(itemRow("f07cKodeItemProduct_v50"))
        '        _010cProductProcess.SetEditValue(itemRow("f11cKodeProductionProcess_v50"))
        '        _011cPlating.SetEditValue(itemRow("f13cKodePlating_v50"))
        '        _012cFinishing.SetEditValue(itemRow("f15cKodeFinishing_v50"))
        '        _017cProjectName.EditValue = CStr(itemRow("f04cNamaProject_v50"))
        '        _018cProductName.EditValue = CStr(itemRow("f06cNamaNamingProduct_v50"))
        '        _013cEstimasiBerat.EditValue = CStr(itemRow("f17nGrossWeight_n94"))
        '    Next

        '    'Set grid Design Stone
        '    Dim pdtMaster31 As DataTable

        '    Using objMaster31 As clsMRP_iface = New clsMRP_impl With {.prop_KeyString01 = _06cMasterCode.EditValue}
        '        pdtMaster31 = objMaster31.Sele31DESIGNMASTERSTONE()
        '    End Using

        '    If pdtMaster31.Rows.Count > 0 Then
        '        ctrl31DesignMasterStoneGrid.prop_dt31DESIGNMASTERSTONE.Clear()
        '        ctrl31DesignMasterStoneGrid.prop_dt31DESIGNMASTERSTONE = pdtMaster31
        '        _gcJCStone.DataSource = Nothing
        '        _gcJCStone.DataSource = ctrl31DesignMasterStoneGrid.prop_dt31DESIGNMASTERSTONE
        '        _gcJCStone.Refresh()
        '    Else
        '        _gcJCStone.DataSource = Nothing
        '        _gcJCStone.Refresh()
        '    End If

        '    _pm08SetFillDataSize(_07cItemProduct.EditValue)

        'Else
        '    _gcJCStone.DataSource = Nothing
        '    _gcJCStone.Refresh()

        'End If
    End Sub

    Private Sub _wUIBtnPnl_ButtonClick(sender As Object, e As ButtonEventArgs) Handles _wUIBtnPnl.ButtonClick

        Dim tag As String = CType(e.Button, WindowsUIButton).Tag

        Select Case tag

            Case "save"
                If IsValid() Then
                    _pm05SaveData()
                End If
            Case "clear"
                _03GetdataSource()
                _04BindingAwal()
        End Select

    End Sub

    Private Sub _015cMasterType_EditValueChanged(sender As Object, e As EventArgs) Handles _015cMasterType.EditValueChanged

        If _015cMasterType.EditValue <> "" Then

        End If

    End Sub

    Private Sub _019cPilihRouting_EditValueChanged(sender As Object, e As EventArgs) Handles _019cPilihRouting.EditValueChanged
        If _019cPilihRouting.EditValue <> "" Then

            'set gridControl DataSource
            _gcRouting.DataSource = Nothing
            _gcRouting.DataSource = _pm03GetRouting(_019cPilihRouting.EditValue)
            _gcRouting.Refresh()

        End If
    End Sub

    Private Sub _pe3DPicture_01_Click(sender As Object, e As EventArgs) Handles _pe3DPicture_01.Click
        ChooseImg._cm01ChooseImage(_pe3DPicture_01)
    End Sub

    Private Sub _pe3DPicture_02_Click(sender As Object, e As EventArgs) Handles _pe3DPicture_02.Click
        ChooseImg._cm01ChooseImage(_pe3DPicture_02)
    End Sub

    Private Sub _pe3DPicture_03_Click(sender As Object, e As EventArgs) Handles _pe3DPicture_03.Click
        ChooseImg._cm01ChooseImage(_pe3DPicture_03)
    End Sub

    Private Sub _28cRevision_CheckedChanged(sender As Object, e As EventArgs) Handles _28cRevision.CheckedChanged
        If _28cRevision.CheckState = CheckState.Checked Then
            Revision = True
            lytGetFrom.Enabled = False
            _cloadGetFrom.Enabled = False
            _04BindingAwal()
        Else
            Revision = False
            lytGetFrom.Enabled = True
            _cloadGetFrom.Enabled = True
            _04BindingAwal()
        End If
    End Sub

    Private Sub _01ck01cKodeValidation_v50_LostFocus(sender As Object, e As EventArgs) Handles _01ck01cKodeValidation_v50.LostFocus

        If _01ck01cKodeValidation_v50.EditValue <> "" Then

            If Revision Then
                _pm012ShowDataEditFrom35(_01ck01cKodeValidation_v50.EditValue)
            Else
                _pm013ShowDataEditFrom30(_01ck01cKodeValidation_v50.EditValue)
            End If
        End If

    End Sub

    Private Sub _28cGetFrom_EditValueChanged(sender As Object, e As EventArgs) Handles _28cGetFrom.EditValueChanged
        If _28cGetFrom.EditValue <> "" Then
            _pm014ShowDataGetFrom(_28cGetFrom.EditValue)
            lytKodeValidasi.Enabled = False
        End If
    End Sub

    Private Sub _cloadGetFrom_Click(sender As Object, e As EventArgs) Handles _cloadGetFrom.Click
        Cursor = Cursors.WaitCursor
        _cm05EntryClear()
        With _28cGetFrom
            ._01BindingAwalDataSurce()
        End With
        _28cGetFrom._03RefreshDataSourceSKU()

        Cursor = Cursors.Default
    End Sub
#End Region

#Region "Grid : Event"

    Private Sub _gvBOM_KeyDown(sender As Object, e As KeyEventArgs) Handles _gvBOM.KeyDown
        If e.KeyCode = 46 Then

            'If (MessageBox.Show("Delete row?", "Confirmation", MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return
            'Dim view As GridView = CType(sender, GridView)
            'view.DeleteRow(view.FocusedRowHandle)

            If (MessageBox.Show("Apakah Anda akan Menghapus Baris Terpilih?", "Confirmation", MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return
            If _gvBOM.RowCount > 0 Then
                _gvBOM.DeleteSelectedRows()

                ctrlMRP36JOBCARDBOMGrid.prop_dt36JOBCARDBOM.AcceptChanges()
                _gcBOM.RefreshDataSource()

                MsgBox("Data Berhasil... Dihapus", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Infromasi")
            End If
            'MsgBox("Data Batal... Dihapus", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Infromasi")

        End If
    End Sub

    Private Sub _gvJCStone_KeyDown(sender As Object, e As KeyEventArgs) Handles _gvJCStone.KeyDown
        If e.KeyCode = 46 Then

            If (MessageBox.Show("Apakah Anda akan Menghapus Baris Terpilih?", "Confirmation", MessageBoxButtons.YesNo) <> DialogResult.Yes) Then Return
            If _gvJCStone.RowCount > 0 Then
                _gvJCStone.DeleteSelectedRows()

                If Revision Then
                    ctrl37JOBCARDSTONEGrid.prop_dt37JOBCARDSTONE.AcceptChanges()
                Else
                    ctrl31DesignMasterStoneGrid.prop_dt31DESIGNMASTERSTONE.AcceptChanges()
                End If
                _gcJCStone.RefreshDataSource()

                MsgBox("Data Berhasil... Dihapus", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Infromasi")
            End If
            'MsgBox("Data Batal... Dihapus", MsgBoxStyle.OkOnly + MsgBoxStyle.Information, "Infromasi")

        End If
    End Sub

    Private Sub _gvBOM_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles _gvBOM.CellValueChanged

        Dim KodeItem As String
        Dim KodeMaterial As String
        Dim MaterialDesc As String
        Dim TotalGram As Double

        Select Case e.Column.FieldName

            Case "k02cKodeItemCastedParts_v50"
                KodeItem = e.Value

                'TotalGram = CType(_013cEstimasiBerat.EditValue * 4, Double)
                TotalGram = CType(_013cEstimasiBerat.EditValue, Double)
                'Dim pdRow() As DataRow = _06PropDataMasterMaterial21.Select("k01cKodeItemCastedParts_v50 = '" & KodeItem & "'")
                Dim pdRow() As DataRow = _pm04GetMaterial(KodeItem)
                If pdRow.Count > 0 Then
                    For Each Item As DataRow In pdRow
                        KodeMaterial = Item("f02cKodeRawMaterial_v50")
                        MaterialDesc = Item("f03cRawMaterialDesc_v50")
                    Next

                    _gvBOM.SetFocusedRowCellValue("f01cKodeMaterial_v50", KodeMaterial)
                    _gvBOM.SetFocusedRowCellValue("f02cMaterialDesc_v50", MaterialDesc)
                    _gvBOM.SetFocusedRowCellValue("f04nGram_n92", TotalGram)

                End If

        End Select
    End Sub

    Private Sub _gvJCStone_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles _gvJCStone.CellValueChanged

        Dim KodeStone As String
        Dim SetName As String
        Dim pcKode As String
        ' Dim pcCodeValue As String
        Dim Pcs As Double = 0
        Dim Weight As Double = 0
        Dim StoneDistribution As Double = 0
        Dim pnBeratPerPcs As Double = 0

        If Revision Then
            KodeStone = "k03cKodeStones_v50"
        Else
            KodeStone = "k02cKodeStones_v50"
        End If

        Select Case e.Column.FieldName

            Case KodeStone
                pcKode = e.Value
                'SetName = _cm011GetNamaByCode(_04PropDataMasterSKK51, pcKode)
                Dim pdRow As DataRow() = _11PropDataMaster23MasterStone.Select("k01cKodeStones_v50 = '" & pcKode & "' ")
                For Each pcItem As Object In pdRow
                    'set code
                    _gvJCStone.SetFocusedRowCellValue("f01cKodeStoneType_v50", CStr(pcItem("f02cKodeStonesType_v50")))
                    _gvJCStone.SetFocusedRowCellValue("f03cKodeStoneShape_v50", CStr(pcItem("f04KodeShape_v50")))
                    _gvJCStone.SetFocusedRowCellValue("f05cKodeStoneColor_v50", CStr(pcItem("f06cKodeWarna_v50")))
                    _gvJCStone.SetFocusedRowCellValue("f07cKodeStoneSize_v50", CStr(pcItem("f08cKodeSize_v50")))
                Next

            Case "f01cKodeStoneType_v50"
                pcKode = e.Value
                SetName = _cm011GetNamaByCode(_04PropDataMasterSKK51, pcKode)
                _gvJCStone.SetFocusedRowCellValue("f02cNamaStoneType_v50", SetName)
            Case "f03cKodeStoneShape_v50"
                pcKode = e.Value
                SetName = _cm011GetNamaByCode(_04PropDataMasterSKK51, pcKode)
                _gvJCStone.SetFocusedRowCellValue("f04cNamaStoneShape_v50", SetName)
            Case "f05cKodeStoneColor_v50"
                pcKode = e.Value
                SetName = _cm011GetNamaByCode(_04PropDataMasterSKK51, pcKode)
                _gvJCStone.SetFocusedRowCellValue("f06cNamaStoneColor_v50", SetName)
            Case "f07cKodeStoneSize_v50"
                pcKode = e.Value
                SetName = _cm011GetNamaByCode(_04PropDataMasterSKK51, pcKode)
                _gvJCStone.SetFocusedRowCellValue("f08cNamaStoneSize_v50", SetName)

            Case "f09nButir_int"
                pcKode = CType(_gvJCStone.GetFocusedRowCellValue(KodeStone), String)
                Dim pdRow As DataRow() = _11PropDataMaster23MasterStone.Select("k01cKodeStones_v50 = '" & pcKode & "' ")
                For Each pcItem As Object In pdRow
                    pnBeratPerPcs = CType(pcItem("f14nBeratPerButir_n92"), Double)
                Next
                _gvJCStone.SetFocusedRowCellValue("f10nBerat_n94", pnBeratPerPcs * CInt(e.Value))
                _gvJCStone.SetFocusedRowCellValue("f11nStoneDistribution_n92", ((pnBeratPerPcs * CInt(e.Value)) / _013cEstimasiBerat.EditValue) * 100)
                'Case "f10nBerat_n94"
                '    Pcs = _gvJCStone.GetFocusedRowCellValue("f09nButir_int")
                '    Weight = _gvJCStone.GetFocusedRowCellValue("f10nBerat_n94")
                '    StoneDistribution = ((Weight / Pcs) * 100)
                '    _gvJCStone.SetFocusedRowCellValue("f11nStoneDistribution_n92", StoneDistribution)
        End Select
        _gvJCStone.RefreshData()
    End Sub

#End Region

    'untuk load dari class 35Jobcard
#Region "For Class Loaded"

    Public Sub _03GetdataSource()

        Dim pdDataMasterNEWCENTRALy51 As New DataTable

        Dim pdDataMasterRoutingSKK20 As New DataTable
        Dim pdDataMasterMaterialSKK21 As New DataTable
        Dim pdDataMasterStoneSKK23 As New DataTable
        Dim pdDataMasterDesignMasterSKK30 As New DataTable
        Dim pdDataMasterJOBCARDSKK35 As New DataTable
        Dim pdDataMasterJOBCARDBOMSKK36 As New DataTable
        Dim pdDataMasterJOBCARDSTONESKK37 As New DataTable
        Dim pdDataMasterSKK51 As New DataTable
        Dim pdDataMasterSKKGambar As New DataTable

        ''get dt2122 
        'Using objSKKMasterMaterial2122 As clsMRP_iface = New clsMRP_impl
        '    pdDataMasterMaterialSKK2122 = objSKKMasterMaterial2122.Get2122MasterMaterial
        'End Using

        'get dt20 MasterRouting
        Using objSKKMaster20 As clsMRP_iface = New clsMRP_impl With {
            .prop_KeyString01 = "",
            .prop_KeyString02 = ""
            }
            pdDataMasterRoutingSKK20 = objSKKMaster20.Sele20MASTERROUTING
        End Using

        'get dt21 MCRawMaterial
        Using objSKKMaster21 As clsMRP_iface = New clsMRP_impl With {
            .prop_KeyString01 = ""
            }
            pdDataMasterMaterialSKK21 = objSKKMaster21.Sele21MCRAWMATERIAL
        End Using

        'get dt23 MasterSTone
        Using objSKKMaster23 As clsMRP_iface = New clsMRP_impl With {
            .prop_KeyString01 = ""
            }
            pdDataMasterStoneSKK23 = objSKKMaster23.Sele23MCSTONES()
        End Using

        'get dt30 DesigMaster
        Using objSKKMaster30 As clsMRP_iface = New clsMRP_impl With {
            .prop_KeyString01 = ""
            }
            pdDataMasterDesignMasterSKK30 = objSKKMaster30.Sele30DESIGNMASTER()
        End Using

        'get dt35 jobcard
        Using objSKKMaster35 As clsMRP_iface = New clsMRP_impl With {
            .prop_KeyString01 = ""
            }
            pdDataMasterJOBCARDSKK35 = objSKKMaster35.Sele35JOBCARD()
        End Using

        'get dt36 jobcardBOM
        Using objSKKMaster36 As clsMRP_iface = New clsMRP_impl With {
            .prop_KeyString01 = ""
            }
            pdDataMasterJOBCARDBOMSKK36 = objSKKMaster36.Sele36JOBCARDBOM()
        End Using

        'get dt37 jobcardStone
        Using objSKKMaster37 As clsMRP_iface = New clsMRP_impl With {
            .prop_KeyString01 = "",
            .prop_KeyString02 = ""
            }
            pdDataMasterJOBCARDSTONESKK37 = objSKKMaster37.Sele37JOBCARDSTONE()
        End Using

        'get dt51
        Using objSKKMaster As clsMRP_iface = New clsMRP_impl
            pdDataMasterSKK51 = objSKKMaster.Get51MasterAllNewSKK()
        End Using

        'get 51 NC
        Using objSKKNCMaster51 As clsNEWCENTRAL_iface = New clsNEWCENTRAL_impl
            pdDataMasterNEWCENTRALy51 = objSKKNCMaster51.Seley51NC()
        End Using

        'get gambar all
        'Using objSKKMasterGambar As clsMRP_iface = New clsMRP_impl With {
        '    .prop_KeyString01 = ""
        '    }
        '    pdDataMasterSKKGambar = objSKKMasterGambar.GetGambar()
        'End Using

        'set DataSource
        _03PropDataMasterSKK30 = pdDataMasterDesignMasterSKK30
        _04PropDataMasterSKK51 = pdDataMasterSKK51
        _05PropDataMasterRouting = pdDataMasterRoutingSKK20
        _06PropDataMasterMaterial21 = pdDataMasterMaterialSKK21
        _07PropDataMastert35 = pdDataMasterJOBCARDSKK35
        _08PropDataMastert36 = pdDataMasterJOBCARDBOMSKK36
        _09PropDataMastert37 = pdDataMasterJOBCARDSTONESKK37
        '_10PropDataMasterGambar = pdDataMasterSKKGambar
        _11PropDataMaster23MasterStone = pdDataMasterStoneSKK23

        _12PropDataMasterNCy51 = pdDataMasterNEWCENTRALy51

    End Sub

    Public Sub _04BindingAwal()
        _cm01InitControl()
        _cm02InitFieldGridStone31()
        _cm02InitFieldGridStone37()
        _cm03InitFieldgridBOM()
        _cm04InitFieldGridRouting()
        _cm05EntryClear()
        _cm06InitRepo()

    End Sub

    Private Sub _01ck01cKodeValidation_v50_EditValueChanged(sender As Object, e As EventArgs) Handles _01ck01cKodeValidation_v50.EditValueChanged

    End Sub


#End Region

End Class
