
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraGrid.Views.Base
Imports NCCONTROLLERlib
Imports NCMODELlib
Imports NCREPOSITORYlib
Imports System.Data.SqlClient

Public Class ucMRP20EV01DesignMaster
    Implements IDisposable
    Public Property prop_01dvAll51DataMasterSKK As New DataTable
    Public Property prop_02cUserID As String
    Public Property prop_03cNamaUser As String
    Public Property prop_04dvAllDataMaster23 As New DataTable

    Private _rscol01f01cKodeStoneType_v50 As repo51SKKValueMaster
    Private _rscol02f03cKodeStoneShape_v50 As repo51SKKValueMaster
    Private _rscol03f05cKodeStoneColor_v50 As repo51SKKValueMaster
    Private _rscol04f07cKodeStoneSize_v500 As repo51SKKValueMaster
    Private _rscol05k02cKodeStones_v50 As repo23MasterStoneMRP

    Private _rsgcol01f01cKodeStoneType_v50 As repo51SKKValueMasterGridLookUpEdit

    Private pdt30DesignMaster As DataTable
    Private ctrl30DesignMasterSave As clsCtrlMRP30DESIGNMASTER

    Private pdt31DesignMasterGrid As DataTable
    Private ctrl31DesignMasterGrid As clsCtrlMRP31DESIGNMASTERSTONE

    Private pdt31DesignMasterSave As DataTable
    Private ctrl31DesignMasterSave As clsCtrlMRP31DESIGNMASTERSTONE

    Private clsAdd0630 As New clsAdd30MRP06NC

#Region "Form : event"
    Public Sub New()

        'This call is required by the designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call.
        pdt31DesignMasterGrid = New DataTable
        ctrl31DesignMasterGrid = New clsCtrlMRP31DESIGNMASTERSTONE With {.prop_dt31DESIGNMASTERSTONE = pdt31DesignMasterGrid}
        ctrl31DesignMasterGrid.dtInit31DESIGNMASTERSTONE()

        pdt31DesignMasterSave = New DataTable
        ctrl31DesignMasterSave = New clsCtrlMRP31DESIGNMASTERSTONE With {.prop_dt31DESIGNMASTERSTONE = pdt31DesignMasterSave}
        ctrl31DesignMasterSave.dtInit31DESIGNMASTERSTONE()

        pdt30DesignMaster = New DataTable
        ctrl30DesignMasterSave = New clsCtrlMRP30DESIGNMASTER With {.prop_dt30DESIGNMASTER = pdt30DesignMaster}
        ctrl30DesignMasterSave.dtInit30DESIGNMASTER()

    End Sub

    Private Sub ucMRP20EV01DesignMaster_Load(sender As Object, e As EventArgs) Handles Me.Load
        _cm01InitControl()
        _cm02InitRepo()
        _cm03IniFieldGrid()
        _cm05BersihkanEntrian()

        _lytCtrlRoot.BackColor = _cmColorByHtml(Backcolor_Panel02)
    End Sub

#End Region


#Region "Costum Color Code"

    Private Property Backcolor_Panel01 As String = "#ccd5f0"
    Private Property Backcolor_Panel02 As String = "#f2f5fc"

    Private Property TitelTextcolor_01 As String = "#5d6b99"
    Private Property Textcolor_01 As String = "#313131"
    Private Property Textcolor_02 As String = ""

    Private Function _cmColorByHtml(ByVal Code As String) As Color
        Return ColorTranslator.FromHtml(Code)
    End Function
#End Region


#Region "Costum : Methods"

    Private Sub _cm01InitControl()

        With _02cBrand
            ._01prop_dtMasterSKK = prop_01dvAll51DataMasterSKK
            ._02prop_FilterKodeMasterSKK = "BRAND"
            ._03BindingAwalDataSurce()
            ._04FilterDataViewMasterSKK()

        End With

        With _03cProjectName
            ._01prop_dtMasterSKK = prop_01dvAll51DataMasterSKK
            ._02prop_FilterKodeMasterSKK = "PROJECTDESIGN"
            ._03BindingAwalDataSurce()
            ._04FilterDataViewMasterSKK()
        End With

        With _04cProductName
            ._01prop_dtMasterSKK = prop_01dvAll51DataMasterSKK
            ._02prop_FilterKodeMasterSKK = "NAMINGPRODUCT"
            ._03BindingAwalDataSurce()
            ._04FilterDataViewMasterSKK()
        End With

        With _05cItemProduct
            ._01prop_dtMasterSKK = prop_01dvAll51DataMasterSKK
            ._02prop_FilterKodeMasterSKK = "ITEMPRODUCT"
            ._03BindingAwalDataSurce()
            ._04FilterDataViewMasterSKK()
        End With

        With _06cSubItemProduct
            ._01prop_dtMasterSKK = prop_01dvAll51DataMasterSKK
            ._02prop_FilterKodeMasterSKK = "SUBITEMPRODUCT"
            ._03BindingAwalDataSurce()
            ._04FilterDataViewMasterSKK()
        End With

        With _07cProductProcess
            ._01prop_dtMasterSKK = prop_01dvAll51DataMasterSKK
            ._02prop_FilterKodeMasterSKK = "PRODUCTIONPROCESS"
            ._03BindingAwalDataSurce()
            ._04FilterDataViewMasterSKK()
        End With

        With _08cPlating
            ._01prop_dtMasterSKK = prop_01dvAll51DataMasterSKK
            ._02prop_FilterKodeMasterSKK = "PLATING"
            ._03BindingAwalDataSurce()
            ._04FilterDataViewMasterSKK()
        End With

        With _09cFinishing
            ._01prop_dtMasterSKK = prop_01dvAll51DataMasterSKK
            ._02prop_FilterKodeMasterSKK = "FINISHING"
            ._03BindingAwalDataSurce()
            ._04FilterDataViewMasterSKK()
        End With

        With _13cDesignerName
            ._01prop_dtMasterSKK = prop_01dvAll51DataMasterSKK
            ._02prop_FilterKodeMasterSKK = "JCDESIGNER"
            ._03BindingAwalDataSurce()
            ._04FilterDataViewMasterSKK()
        End With


    End Sub

    Private Sub _cm02InitRepo()

        _rsgcol01f01cKodeStoneType_v50 = New repo51SKKValueMasterGridLookUpEdit With {._prop_01dt51ValueMasterSKK = prop_01dvAll51DataMasterSKK, ._prop_02cTargetGroupMaster = "STONETYPE"}
        _rsgcol01f01cKodeStoneType_v50._01BindingAwalDataSurce()
        _rsgcol01f01cKodeStoneType_v50._02FilterDataProsesProdMRP()
        _col01f01cKodeStoneType_v50.ColumnEdit = _rsgcol01f01cKodeStoneType_v50

        '_rscol01f01cKodeStoneType_v50 = New repo51SKKValueMaster With {._prop_01dt51ValueMasterSKK = prop_01dvAll51DataMasterSKK, ._prop_02cTargetGroupMaster = "STONETYPE"}
        '_rscol01f01cKodeStoneType_v50._01BindingAwalDataSurce()
        '_rscol01f01cKodeStoneType_v50._02FilterDataProsesProdMRP()
        '_col01f01cKodeStoneType_v50.ColumnEdit = _rscol01f01cKodeStoneType_v50

        _rscol02f03cKodeStoneShape_v50 = New repo51SKKValueMaster With {._prop_01dt51ValueMasterSKK = prop_01dvAll51DataMasterSKK, ._prop_02cTargetGroupMaster = "STONESHAPE"}
        _rscol02f03cKodeStoneShape_v50._01BindingAwalDataSurce()
        _rscol02f03cKodeStoneShape_v50._02FilterDataProsesProdMRP()
        _col02f03cKodeStoneShape_v50.ColumnEdit = _rscol02f03cKodeStoneShape_v50

        _rscol03f05cKodeStoneColor_v50 = New repo51SKKValueMaster With {._prop_01dt51ValueMasterSKK = prop_01dvAll51DataMasterSKK, ._prop_02cTargetGroupMaster = "STONECOLOR"}
        _rscol03f05cKodeStoneColor_v50._01BindingAwalDataSurce()
        _rscol03f05cKodeStoneColor_v50._02FilterDataProsesProdMRP()
        _col03f05cKodeStoneColor_v50.ColumnEdit = _rscol03f05cKodeStoneColor_v50

        _rscol04f07cKodeStoneSize_v500 = New repo51SKKValueMaster With {._prop_01dt51ValueMasterSKK = prop_01dvAll51DataMasterSKK, ._prop_02cTargetGroupMaster = "STONESIZE"}
        _rscol04f07cKodeStoneSize_v500._01BindingAwalDataSurce()
        _rscol04f07cKodeStoneSize_v500._02FilterDataProsesProdMRP()
        _col04f07cKodeStoneSize_v50.ColumnEdit = _rscol04f07cKodeStoneSize_v500

        _rscol05k02cKodeStones_v50 = New repo23MasterStoneMRP With {._prop_01dt23MasterStoneMRP = prop_04dvAllDataMaster23}
        _rscol05k02cKodeStones_v50._01BindingAwalDataSurce()
        _col16k02cKodeStones_v50.ColumnEdit = _rscol05k02cKodeStones_v50

    End Sub

    Private Sub _cm03IniFieldGrid()

        With gvStoneInformation

            With .Appearance

                With .GroupPanel
                    .Options.UseBackColor = True
                    .BackColor = _cmColorByHtml(Backcolor_Panel01)
                End With

                With .HeaderPanel
                    .Options.UseBackColor = True
                    .TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    .Font = New Font("Arial", 9, FontStyle.Bold, GraphicsUnit.Point)
                    .BackColor = _cmColorByHtml(Backcolor_Panel01)
                    .ForeColor = _cmColorByHtml(Textcolor_01)
                End With

            End With

            _col01f01cKodeStoneType_v50.FieldName = "f01cKodeStoneType_v50"
            _col02f03cKodeStoneShape_v50.FieldName = "f03cKodeStoneShape_v50"
            _col03f05cKodeStoneColor_v50.FieldName = "f05cKodeStoneColor_v50"
            _col04f07cKodeStoneSize_v50.FieldName = "f07cKodeStoneSize_v50"
            _col05f09nButir_int.FieldName = "f09nButir_int"
            _col06f10nBerat_n94.FieldName = "f10nBerat_n94"
            _col07f11nStoneDistribution_n92.FieldName = "f11nStoneDistribution_n92"

            _col012Namaf01cKodeStoneType_v50.FieldName = "f02cNamaStoneType_v50"
            _col012Namaf01cKodeStoneType_v50.Visible = False
            _col013Namaf03cKodeStoneShape_v50.FieldName = "f04cNamaStoneShape_v50"
            _col013Namaf03cKodeStoneShape_v50.Visible = False
            _col014Namaf05cKodeStoneColor_v50.FieldName = "f06cNamaStoneColor_v50"
            _col014Namaf05cKodeStoneColor_v50.Visible = False
            _col015Namaf07cKodeStoneSize_v50.FieldName = "f08cNamaStoneSize_v50"
            _col015Namaf07cKodeStoneSize_v50.Visible = False
            _col16k02cKodeStones_v50.FieldName = "k02cKodeStones_v50"

            'gcStoneInformation.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
            'gcStoneInformation.LookAndFeel.UseDefaultLookAndFeel = False

            gcStoneInformation.DataSource = Nothing
            gcStoneInformation.DataSource = ctrl31DesignMasterGrid.prop_dt31DESIGNMASTERSTONE
            gcStoneInformation.Refresh()

        End With

    End Sub

    Private Sub _cm04FillDataSize()

        Dim pcIsiItem As String = _05cItemProduct.EditValue

        Dim pcIDSize As String = ""

        ' "RINGSIZES","WOMENBANGLESIZES","NECKLACESSIZE"

        Select Case pcIsiItem
            Case "MTIPEC", "MTIPEM", "MTIPEW"
                pcIDSize = "RINGSIZES"
            Case "MTIPEE"
                pcIDSize = "WOMENBANGLESIZES"
            Case "MTIPER"
                pcIDSize = "NECKLACESSIZE"
        End Select

        _10cSize.EditValue = ""
        If pcIDSize <> "" Then
            With _10cSize
                ._01prop_dtMasterSKK = prop_01dvAll51DataMasterSKK
                ._02prop_FilterKodeMasterSKK = pcIDSize
                ._03BindingAwalDataSurce()
                ._04FilterDataViewMasterSKK()
            End With
        End If

    End Sub

    Private Sub _cm05BersihkanEntrian()
        _01DesignMasterCode.EditValue = ""
        _02cBrand.EditValue = ""
        _03cProjectName.EditValue = ""
        _04cProductName.EditValue = ""
        _05cItemProduct.EditValue = ""
        _06cSubItemProduct.EditValue = ""
        _07cProductProcess.EditValue = ""
        _08cPlating.EditValue = ""
        _09cFinishing.EditValue = ""

        ctrl31DesignMasterGrid.prop_dt31DESIGNMASTERSTONE.Clear()
        gcStoneInformation.RefreshDataSource()
        gcStoneInformation.Refresh()
    End Sub

    Private Sub _cm06SimpanData()

        'proses simpan Header
        ctrl30DesignMasterSave.prop_dt30DESIGNMASTER.Clear()
        ctrl30DesignMasterSave.dtAddNew30DESIGNMASTER(_01DesignMasterCode.EditValue,
                                                        _02cBrand.EditValue, _02cBrand.Text,
                                                        _03cProjectName.EditValue, _03cProjectName.Text,
                                                        _04cProductName.EditValue, _04cProductName.Text,
                                                        _05cItemProduct.EditValue, _05cItemProduct.Text,
                                                        _06cSubItemProduct.EditValue, _06cSubItemProduct.Text,
                                                        _07cProductProcess.EditValue, _07cProductProcess.Text,
                                                        _08cPlating.EditValue, _08cPlating.Text,
                                                        _09cFinishing.EditValue, _09cFinishing.Text,
                                                        _12cEstimasiBerat.EditValue, _10cSize.EditValue, _10cSize.Text,
                                                        _14cketerangan.EditValue,
                                                        prop_02cUserID, prop_03cNamaUser, Date.Now)

        Using objSave As clsMRP_iface = New clsMRP_impl With {.prop_KeyDataTable01 = ctrl30DesignMasterSave.prop_dt30DESIGNMASTER}
            objSave.Save30DESIGNMASTER()
        End Using

        With clsAdd0630
            ._cm01SaveData("", Date.Now, "Jenis Jobcard in30", "lode Divisi in30", _01DesignMasterCode.EditValue,
                           "NOPO in30", "costumer in30", _01DesignMasterCode.EditValue, "NORO in30", _05cItemProduct.EditValue,
                           "Kode Pesana in30", 0, "kode RMJObcard in30", "3000/01/01", 0, _12cEstimasiBerat.EditValue, 0, "Kode SAP in30",
                           _04cProductName.Text, _03cProjectName.Text, _13cDesignerName.EditValue, "Alsan Revisi in30",
                          _14cketerangan.EditValue, _01DesignMasterCode.EditValue, "3000/01/01", "Koede Kesulitan in30", _02cBrand.EditValue
                        )
        End With

        ' MsgBox("Data Header Berhasil Di Simpan", MsgBoxStyle.MsgBoxRight, "Messagge")

        'proses simpan Detail
        ctrl31DesignMasterSave.prop_dt31DESIGNMASTERSTONE.Clear()
        Dim pnIndex As Integer = 0
        For Each dtRow As DataRow In ctrl31DesignMasterGrid.prop_dt31DESIGNMASTERSTONE.Rows
            pnIndex += 1
            ctrl31DesignMasterSave.dtAddNew31DESIGNMASTERSTONE(_01DesignMasterCode.EditValue, dtRow("k02cKodeStones_v50"),
                                                                dtRow("f01cKodeStoneType_v50"), dtRow("f02cNamaStoneType_v50"),
                                                                dtRow("f03cKodeStoneShape_v50"), dtRow("f04cNamaStoneShape_v50"),
                                                                dtRow("f05cKodeStoneColor_v50"), dtRow("f06cNamaStoneColor_v50"),
                                                                dtRow("f07cKodeStoneSize_v50"), dtRow("f08cNamaStoneSize_v50"),
                                                                dtRow("f09nButir_int"), dtRow("f10nBerat_n94"),
                                                                dtRow("f11nStoneDistribution_n92"),
                                                                prop_02cUserID, prop_03cNamaUser, Date.Now)
        Next

        Using objSave31 As clsMRP_iface = New clsMRP_impl With {.prop_KeyDataTable01 = ctrl31DesignMasterSave.prop_dt31DESIGNMASTERSTONE}
            objSave31.Save31DESIGNMASTERSTONE()
        End Using

        ' MsgBox("Data Detail Berhasil Di Simpan", MsgBoxStyle.MsgBoxRight, "Messagge")
        MsgBox("Data Berhasil Di Simpan", MsgBoxStyle.MsgBoxRight, "Messagge")
        _cm05BersihkanEntrian()
    End Sub

    Private Function _cm07GetNamaByCode(ByVal prmDataTable As DataTable, ByVal KodeType As String) As String
        Dim SetName As String = String.Empty
        Dim pdRow() As DataRow = prmDataTable.Select("k01cKodeFieldValueMaster_v50 = '" & KodeType & "'")
        If pdRow.Count > 0 Then
            SetName = pdRow(0).Item("f01cIsiFieldValueMaster_v50")
        End If
        Return SetName
    End Function

#End Region

#Region " Control : Event"
    Private Sub _05cItemProduct_EditValueChanged(sender As Object, e As EventArgs) Handles _05cItemProduct.EditValueChanged
        _cm04FillDataSize()
    End Sub

    Private Sub gvStoneInformation_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles gvStoneInformation.CellValueChanged

        Dim SetName As String
        Dim Kode As String
        Dim Pcs As Double
        Dim Weight As Double
        Dim StoneDistribution As Double

        Select Case e.Column.FieldName

            Case "f01cKodeStoneType_v50"
                Kode = e.Value
                SetName = _cm07GetNamaByCode(prop_01dvAll51DataMasterSKK, Kode)
                gvStoneInformation.SetFocusedRowCellValue("f02cNamaStoneType_v50", SetName)
            Case "f03cKodeStoneShape_v50"
                Kode = e.Value
                SetName = _cm07GetNamaByCode(prop_01dvAll51DataMasterSKK, Kode)
                gvStoneInformation.SetFocusedRowCellValue("f04cNamaStoneShape_v50", SetName)
            Case "f05cKodeStoneColor_v50"
                Kode = e.Value
                SetName = _cm07GetNamaByCode(prop_01dvAll51DataMasterSKK, Kode)
                gvStoneInformation.SetFocusedRowCellValue("f06cNamaStoneColor_v50", SetName)
            Case "f07cKodeStoneSize_v50"
                Kode = e.Value
                SetName = _cm07GetNamaByCode(prop_01dvAll51DataMasterSKK, Kode)
                gvStoneInformation.SetFocusedRowCellValue("f08cNamaStoneSize_v50", SetName)
            Case "f10nBerat_n94"
                Pcs = gvStoneInformation.GetFocusedRowCellValue("f09nButir_int")
                Weight = gvStoneInformation.GetFocusedRowCellValue("f10nBerat_n94")
                StoneDistribution = ((Weight / Pcs) * 100)
                gvStoneInformation.SetFocusedRowCellValue("f11nStoneDistribution_n92", StoneDistribution)
        End Select


    End Sub

    Private Sub wuBtnPanel_ButtonClick(sender As Object, e As ButtonEventArgs) Handles wuBtnPanel.ButtonClick

        Dim tag As String = CType(e.Button, WindowsUIButton).Tag

        Select Case tag

            Case "save"
                If _01DesignMasterCode.Text = "" Then
                    MsgBox("Silahkan Input Master Code", MsgBoxStyle.Information, "Information")
                    _01DesignMasterCode.Select()
                ElseIf _02cBrand.Text = "" And _02cBrand.EditValue = "" Then
                    MsgBox("Silahkan Pilih Brand", MsgBoxStyle.Information, "Information")
                    _02cBrand.Select()
                ElseIf _03cProjectName.Text = "" Or _03cProjectName.EditValue = "" Then
                    MsgBox("Silahkan Pilih ProjectName", MsgBoxStyle.Information, "Information")
                    _03cProjectName.Select()
                ElseIf _04cProductName.Text = "" Or _04cProductName.EditValue = "" Then
                    MsgBox("Silahkan Pilih Product Name", MsgBoxStyle.Information, "Information")
                    _04cProductName.Select()
                ElseIf _05cItemProduct.Text = "" Or _05cItemProduct.EditValue = "" Then
                    MsgBox("Silahkan Pilih Item Product", MsgBoxStyle.Information, "Information")
                    _05cItemProduct.Select()
                ElseIf _06cSubItemProduct.Text = "" Or _06cSubItemProduct.EditValue = "" Then
                    MsgBox("Silahkan Pilih Sub Item Product", MsgBoxStyle.Information, "Information")
                    _06cSubItemProduct.Select()
                ElseIf _07cProductProcess.Text = "" Or _07cProductProcess.EditValue = "" Then
                    MsgBox("Silahkan Pilih Product Process", MsgBoxStyle.Information, "Information")
                    _07cProductProcess.Select()
                ElseIf _08cPlating.Text = "" Or _08cPlating.EditValue = "" Then
                    MsgBox("Silahkan Pilih Plating", MsgBoxStyle.Information, "Information")
                    _08cPlating.Select()
                ElseIf _09cFinishing.Text = "" Or _09cFinishing.EditValue = "" Then
                    MsgBox("Silahkan Pilih Finishing", MsgBoxStyle.Information, "Information")
                    _09cFinishing.Select()
                ElseIf _10cSize.Text = "" Or _10cSize.EditValue = "" Then
                    MsgBox("Silahkan Pilih Size", MsgBoxStyle.Information, "Information")
                    _10cSize.Select()
                ElseIf ctrl31DesignMasterGrid.prop_dt31DESIGNMASTERSTONE.Rows.Count <= 0 Then
                    MsgBox("Silahkan input Stone Master", MsgBoxStyle.Information, "Information")
                Else
                    _cm06SimpanData()
                End If
            Case "clear"
                _cm05BersihkanEntrian()
        End Select

    End Sub

#End Region


End Class
