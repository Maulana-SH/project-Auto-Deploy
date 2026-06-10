Imports NCCONTROLLERlib
Imports NCREPOSITORYlib
Imports System.IO
Public Class uc01GridRawMaterial
    Implements IDisposable

    Public Property prop_gcUserID_v50 As String = ""
    Public Property prop_gcNamaUser_v50 As String = ""
    Public Property prop_gcTitle As String = ""
    Public Property prop_gcJudulForm As String = ""

    Public Property prop_02dt21MCRAWMATERIAL As New DataTable   'ambil 21


#Region "Costum Color Code"

    Private Property Backcolor_Panel01 As String = "#ccd5f0"
    Private Property Backcolor_Panel02 As String = ""

    Private Property TitelTextcolor_01 As String = "#5d6b99"
    Private Property Textcolor_01 As String = "#313131"
    Private Property Textcolor_02 As String = ""
#End Region

#Region "peivate : Property"
    'call controler
    Private ctrlRawMaterial As clsCtrlMRP21MCRAWMATERIAL
    Private dtctrlRawMaterial As DataTable
    Private _rscol01_k01cKodeItemCastedParts_v50 As repo51SKKValueMaster
    Private _rscol02_f01cItemCastedPartsDesc_v50 As repo51SKKValueMaster
    Private _rscol03_f03cRawMaterialDesc_v50 As repo51SKKValueMaster
    Private _rscol04_f05cKadarDesc_v50 As repo51SKKValueMaster
    Private _rscol05_f07cWarnaDesc_v50 As repo51SKKValueMaster
    Private _rscol06_f09cGoldTypeDesc_v50 As repo51SKKValueMaster

#End Region

#Region "from :Event"

#End Region

#Region "Costume : private Methods"
    Private Function _cmColorByHtml(ByVal Code As String) As Color
        Return ColorTranslator.FromHtml(Code)
    End Function

    Private Sub _pm01Intrepository()
        ''Kode Castedpart
        '_rscol01_k01cKodeItemCastedParts_v50 = New repo51SKKValueMaster With {._prop_01dt51ValueMasterSKK = prop_01dtValueMasterSKK,
        '                                                                      ._prop_02cTargetGroupMaster = ""}
        '_rscol01_k01cKodeItemCastedParts_v50._01BindingAwalDataSurce()
        '_rscol01_k01cKodeItemCastedParts_v50._02FilterDataProsesProdMRP()
        '_col01_k01cKodeItemCastedParts_v50.ColumnEdit = _rscol01_k01cKodeItemCastedParts_v50

        ''Kode Castedpart  des
        '_rscol02_f01cItemCastedPartsDesc_v50 = New repo2122MasterMaterialMRP With {._prop_01dt2122MasterMaterialMRP = prop_01dtValueMasterSKK}
        '_rscol02_f01cItemCastedPartsDesc_v50._01BindingAwalDataSurce()
        '_rscol02_f01cItemCastedPartsDesc_v50._02FilterDataProsesProdMRP(repo2122MasterMaterialMRP.enumFilterTblMaterialMRP.t21MCRAWMATERIAL)
        '_col02_f01cItemCastedPartsDesc_v50.ColumnEdit = _rscol02_f01cItemCastedPartsDesc_v50

        ''RawMaterial
        '_rscol03_f03cRawMaterialDesc_v50 = New repo2122MasterMaterialMRP With {._prop_01dt2122MasterMaterialMRP = prop_01dtValueMasterSKK}
        '_rscol03_f03cRawMaterialDesc_v50._01BindingAwalDataSurce()
        '_rscol03_f03cRawMaterialDesc_v50._02FilterDataProsesProdMRP(repo2122MasterMaterialMRP.enumFilterTblMaterialMRP.t21MCRAWMATERIAL)
        '_col03_f03cRawMaterialDesc_v50.ColumnEdit = _rscol01_k01cKodeItemCastedParts_v50

        ''Kadar
        '_rscol04_f05cKadarDesc_v50 = New repo2122MasterMaterialMRP With {._prop_01dt2122MasterMaterialMRP = prop_01dtValueMasterSKK}
        '_rscol04_f05cKadarDesc_v50._01BindingAwalDataSurce()
        '_rscol04_f05cKadarDesc_v50._02FilterDataProsesProdMRP(repo2122MasterMaterialMRP.enumFilterTblMaterialMRP.t21MCRAWMATERIAL)
        '_col04_f05cKadarDesc_v50.ColumnEdit = _rscol04_f05cKadarDesc_v50

        ''Warna
        '_rscol05_f07cWarnaDesc_v50 = New repo2122MasterMaterialMRP With {._prop_01dt2122MasterMaterialMRP = prop_01dtValueMasterSKK}
        '_rscol05_f07cWarnaDesc_v50._01BindingAwalDataSurce()
        '_rscol05_f07cWarnaDesc_v50._02FilterDataProsesProdMRP(repo2122MasterMaterialMRP.enumFilterTblMaterialMRP.t21MCRAWMATERIAL)
        '_col05_f07cWarnaDesc_v50.ColumnEdit = _rscol05_f07cWarnaDesc_v50

        ''type
        '_rscol06_f09cGoldTypeDesc_v50 = New repo2122MasterMaterialMRP With {._prop_01dt2122MasterMaterialMRP = prop_01dtValueMasterSKK}
        '_rscol06_f09cGoldTypeDesc_v50._01BindingAwalDataSurce()
        '_rscol06_f09cGoldTypeDesc_v50._02FilterDataProsesProdMRP(repo2122MasterMaterialMRP.enumFilterTblMaterialMRP.t21MCRAWMATERIAL)
        '_col06_f09cGoldTypeDesc_v50.ColumnEdit = _rscol06_f09cGoldTypeDesc_v50

    End Sub

    Private Sub _pm01InitFillGrid()

        With _gvMCRawmaterial

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

            'initial field Name column grid
            _col01_k01cKodeItemCastedParts_v50.FieldName = "k01cKodeItemCastedParts_v50"
            _col02_f01cItemCastedPartsDesc_v50.FieldName = "f01cItemCastedPartsDesc_v50"
            _col03_f03cRawMaterialDesc_v50.FieldName = "f03cRawMaterialDesc_v50"
            _col04_f05cKadarDesc_v50.FieldName = "f05cKadarDesc_v50"
            _col05_f07cWarnaDesc_v50.FieldName = "f07cWarnaDesc_v50"
            _col06_f09cGoldTypeDesc_v50.FieldName = "f09cGoldTypeDesc_v50"
            _col07_f32dCreatedDate.FieldName = "f32dCreatedDate"
        End With


        _gcMCRawmaterial.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        _gcMCRawmaterial.LookAndFeel.UseDefaultLookAndFeel = False
        _gcMCRawmaterial.DataSource = Nothing
        _gcMCRawmaterial.DataSource = prop_02dt21MCRAWMATERIAL
        _gcMCRawmaterial.Refresh()

    End Sub

#End Region

#Region "Costume : Public Methods"

    Private Sub ucGridRawMaterial_Load(sender As Object, e As EventArgs) Handles Me.Load
        _pm01InitFillGrid()
    End Sub



#End Region

#Region "Control :event"

#End Region

#Region "Grid :Event"
    Private Sub _gcMCRawmaterial_Click(sender As Object, e As EventArgs) Handles _gcMCRawmaterial.Click
        _gcMCRawmaterial.ShowPrintPreview()
    End Sub
#End Region

End Class
