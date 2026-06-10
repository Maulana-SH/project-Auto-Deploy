Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid

Public Class uc05GridDesignMasterStoneDetail
    Implements IDisposable
    Public Property prop_gcUserID_v50 As String = ""
    Public Property prop_gcNamaUser_v50 As String = ""
    Public Property prop_gcTitle As String = ""
    Public Property prop_gcJudulForm As String = ""
    Public Property _04prop_t30DESIGNMASTER As DataTable
    Public Property _05prop_t31DESIGNMASTERSTONE As DataTable

#Region "Costum Color Code"

    Private Property Backcolor_Panel01 As String = "#ccd5f0"
    Private Property Backcolor_Panel02 As String = ""

    Private Property TitelTextcolor_01 As String = "#5d6b99"
    Private Property Textcolor_01 As String = "#313131"
    Private Property Textcolor_02 As String = ""
#End Region

#Region "Costume : Methods"

    Private Function _cmColorByHtml(ByVal Code As String) As Color
        Return ColorTranslator.FromHtml(Code)
    End Function
    Sub _cmMAsterDetail()

        Dim ds As New DataSet()
        _04prop_t30DESIGNMASTER.TableName = "t30DESIGNMASTER"
        _05prop_t31DESIGNMASTERSTONE.TableName = "t31DESIGNMASTERSTONE"
        ds.Tables.Add(_04prop_t30DESIGNMASTER.Copy)
        ds.Tables.Add(_05prop_t31DESIGNMASTERSTONE.Copy)

        Dim primaryKey As DataColumn = ds.Tables("t30DESIGNMASTER").Columns("k01cKodeDesignMaster_v50")
        Dim forgenKey As DataColumn = ds.Tables("t31DESIGNMASTERSTONE").Columns("k01cKodeDesignMaster_v50")

        'Set relasi antar tabel
        ds.Relations.Add("rst30Tot31", primaryKey, forgenKey)

        With _gvMasterStones

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

            col01_k01cKodeDesignMaster_v50.FieldName = "k01cKodeDesignMaster_v50"
            col02_f02cNamaBrand_v50.FieldName = "f02cNamaBrand_v50"
            col03_f04cNamaProject_v50.FieldName = "f04cNamaProject_v50"
            col04_f06cNamaNamingProduct_v50.FieldName = "f06cNamaNamingProduct_v50"
            col05_f08cNamaItemProduct_v50.FieldName = "f08cNamaItemProduct_v50"
            col06_f10cNamaSubItemProduct_v50.FieldName = "f10cNamaSubItemProduct_v50"
            col07_f12cNamaProductionProcess_v50.FieldName = "f12cNamaProductionProcess_v50"
            col08_f14cNamaPlating_v50.FieldName = "f14cNamaPlating_v50"
            col09_f16cNamaFinishing_v50.FieldName = "f14cNamaPlating_v50"
            col010_f17nGrossWeight_n94.FieldName = "f17nGrossWeight_n94"
            col011_f19cNamaSize_v50.FieldName = "f19cNamaSize_v50"
            col012_f42dCreatedDate.FieldName = "f42dCreatedDate"

        End With

        'detail
        Dim gvDetail31 As New GridView(_gcMasterStones)
        _gcMasterStones.LevelTree.Nodes.Add("rst30Tot31", gvDetail31)

        With gvDetail31
            .ViewCaption = "Design Master Stone"
            .PopulateColumns(ds.Tables("t31DESIGNMASTERSTONE"))

            With .Appearance

                With .GroupPanel
                    .Options.UseBackColor = True
                    .BackColor = _cmColorByHtml("#ccd5f0")
                End With

                With .HeaderPanel
                    .TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    .Font = New Font("Arial", 9, FontStyle.Bold, GraphicsUnit.Point)
                    .Options.UseBackColor = True
                    .BackColor = _cmColorByHtml(Backcolor_Panel01)
                    .ForeColor = _cmColorByHtml(Textcolor_01)
                End With

            End With

            'set visibel colmn
            .Columns("k01cKodeDesignMaster_v50").VisibleIndex = -1
            .Columns("f01cKodeStoneType_v50").VisibleIndex = -1
            .Columns("f03cKodeStoneShape_v50").VisibleIndex = -1
            .Columns("f05cKodeStoneColor_v50").VisibleIndex = -1
            .Columns("f07cKodeStoneSize_v50").VisibleIndex = -1
            .Columns("f07cKodeStoneSize_v50").VisibleIndex = -1
            .Columns("f40cIDUser_v50").VisibleIndex = -1
            .Columns("f41cNamaUser_v50").VisibleIndex = -1


            'Set Caption
            .Columns("f02cNamaStoneType_v50").Caption = "Stone Type"
            .Columns("f04cNamaStoneShape_v50").Caption = "Stone Shape"
            .Columns("f06cNamaStoneColor_v50").Caption = "Stone Color"
            .Columns("f08cNamaStoneSize_v50").Caption = "Stone Size"
            .Columns("f08cNamaStoneSize_v50").ColumnEdit = New RepositoryItemSpinEdit()
            .Columns("f08cNamaStoneSize_v50").ColumnEditName = "_rsdtf08cNamaStoneSize_v50"
            .Columns("f09nButir_int").Caption = "Pcs"
            .Columns("f09nButir_int").ColumnEdit = New RepositoryItemSpinEdit()
            .Columns("f09nButir_int").ColumnEditName = "_rsdtf09nButir_int"
            .Columns("f10nBerat_n94").Caption = "Weight"
            .Columns("f10nBerat_n94").ColumnEdit = New RepositoryItemSpinEdit()
            .Columns("f10nBerat_n94").ColumnEditName = "_rsdtf10nBerat_n94"
            .Columns("f11nStoneDistribution_n92").Caption = "Stone Dist"
            .Columns("f11nStoneDistribution_n92").ColumnEdit = New RepositoryItemSpinEdit()
            .Columns("f11nStoneDistribution_n92").ColumnEditName = "_rsdtf11nStoneDistribution_n92"
            .Columns("f42dCreatedDate").Caption = "Created"
        End With

        '_gvMasterStones.OptionsBehavior.Editable = False
        _gvMasterStones.OptionsPrint.PrintDetails = True
        _gvMasterStones.OptionsPrint.ExpandAllDetails = True

        _gcMasterStones.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        _gcMasterStones.LookAndFeel.UseDefaultLookAndFeel = False
        _gcMasterStones.DataSource = ds.Tables("t30DESIGNMASTER")
        _gcMasterStones.ForceInitialize()
    End Sub
#End Region

#Region "Form : Event"

    Private Sub ucMasterDetail_Load(sender As Object, e As EventArgs) Handles Me.Load
        _cmMAsterDetail()
    End Sub

#End Region


#Region "Grid : Event"

    Private Sub gcBOM_ViewRegistered(sender As Object, e As ViewOperationEventArgs) Handles _gcMasterStones.ViewRegistered

        'Dim view As GridView = CType(e.View, GridView)

        'For Each col As GridColumn In view.Columns
        '    Select Case col.FieldName
        '        Case "k01cKodeDesignMaster_v50"
        '            col.Caption = "DMCODE"
        '            col.Visible = False
        '        Case "f01cKodeStoneType_v50"
        '            col.Visible = False
        '        Case "f02cNamaStoneType_v50"
        '            col.Caption = "Stone Name"
        '        Case "f03cKodeStoneShape_v50"
        '            col.Visible = False
        '        Case "f04cNamaStoneShape_v50"
        '            col.Caption = "Stone Shape"
        '        Case "f05cKodeStoneColor_v50"
        '            col.Visible = False
        '        Case "f06cNamaStoneColor_v50"
        '            col.Caption = "Stone Color"
        '        Case "f07cKodeStoneSize_v50"
        '            col.Visible = False
        '        Case "f08cNamaStoneSize_v50"
        '            col.Caption = "Stone Size"
        '            col.ColumnEdit = New RepositoryItemSpinEdit()
        '        Case "f09nButir_int"
        '            col.Caption = "PCS"
        '            col.ColumnEdit = New RepositoryItemSpinEdit()
        '            col.ColumnEditName = "rsdColf09nButir_int"
        '        Case "f10nBerat_n94"
        '            col.Caption = "Weight"
        '            col.ColumnEdit = New RepositoryItemSpinEdit()
        '        Case "f11nStoneDistribution_n92"
        '            col.Caption = "Stone Dist"
        '            col.ColumnEdit = New RepositoryItemSpinEdit()
        '        Case "f40cIDUser_v50"
        '            col.Visible = False
        '        Case "f41cNamaUser_v50"
        '            col.Visible = False
        '        Case "f42dCreatedDate"
        '            col.Visible = False
        '    End Select

        'Next col
    End Sub

    Private Sub gcBOM_DoubleClick(sender As Object, e As EventArgs) Handles _gcMasterStones.DoubleClick
        _gcMasterStones.ShowPrintPreview()
    End Sub


#End Region

End Class
