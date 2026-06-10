Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Views.Grid

Public Class uc04GridBOMMasterDetail
    Implements IDisposable

    Public Property prop_gcUserID_v50 As String = ""
    Public Property prop_gcNamaUser_v50 As String = ""
    Public Property prop_gcTitle As String = ""
    Public Property prop_gcJudulForm As String = ""

    Public Property prop_01dt25BOMCASTEDPARTS As DataTable   'ambil 25
    Public Property prop_02dt26BOMFINDINGCOMPONENT As DataTable   'ambil 26
    Public Property prop_03dt27BOMSTONES As DataTable   'ambil 27


#Region "Costum Color Code"
    Private Property Backcolor_Panel01 As String = "#ccd5f0"
    Private Property Backcolor_Panel02 As String = ""
    Private Property TitelTextcolor_01 As String = "#5d6b99"
    Private Property Textcolor_01 As String = "#313131"
    Private Property Textcolor_02 As String = ""
#End Region

#Region " Form : Event"

    Private Sub ucGridBOMMasterDetail_Load(sender As Object, e As EventArgs) Handles Me.Load
        _cmInitFillGrid()
    End Sub

#End Region

#Region " Costume : Methods"
    Private Function _cmColorByHtml(ByVal Code As String) As Color
        Return ColorTranslator.FromHtml(Code)
    End Function
    Sub _cmInitFillGrid()

        With _gvBOM

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

            .ViewCaption = "BOM COMPONENT"
            col01_k01cKodeFinishedGood_v50.FieldName = "k01cKodeFinishedGood_v50"
            col02_f01cItemCastedPartsDesc_v50.FieldName = "f01cItemCastedPartsDesc_v50"
            col03_f32dCreatedDate.FieldName = "f32dCreatedDate"
        End With

        Dim Ds As New DataSet()
        Dim view As New DataView(prop_01dt25BOMCASTEDPARTS)
        Dim dtHeader As DataTable = view.ToTable(True, "k01cKodeFinishedGood_v50", "f01cItemCastedPartsDesc_v50", "f32dCreatedDate")
        'dataset tbl name
        dtHeader.TableName = "Header"
        prop_01dt25BOMCASTEDPARTS.TableName = "t25"
        prop_02dt26BOMFINDINGCOMPONENT.TableName = "t26"
        prop_03dt27BOMSTONES.TableName = "t27"

        'add DataTable to Dataset
        Ds.Tables.Add(dtHeader.Copy)
        Ds.Tables.Add(prop_01dt25BOMCASTEDPARTS.Copy)
        Ds.Tables.Add(prop_02dt26BOMFINDINGCOMPONENT.Copy)
        Ds.Tables.Add(prop_03dt27BOMSTONES.Copy)

        'set key colums
        Dim primaryKey As DataColumn = Ds.Tables("Header").Columns("k01cKodeFinishedGood_v50")
        Dim foreignKey25 As DataColumn = Ds.Tables("t25").Columns("k01cKodeFinishedGood_v50")
        Dim foreignKey26 As DataColumn = Ds.Tables("t26").Columns("k01cKodeFinishedGood_v50")
        Dim foreignKey27 As DataColumn = Ds.Tables("t27").Columns("k01cKodeFinishedGood_v50")
        'relasi hedaer 
        Ds.Relations.Add("rsHeaderTo25", primaryKey, foreignKey25)
        Ds.Relations.Add("rsHeaderTo26", primaryKey, foreignKey26)
        Ds.Relations.Add("rsHeaderTo27", primaryKey, foreignKey27)

        ''detail 25 Bom Component
        Dim gvDetail25 As New GridView(_gcBOM)
        _gcBOM.LevelTree.Nodes.Add("rsHeaderTo25", gvDetail25)
        With gvDetail25

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

            .ViewCaption = "Bom Component"
            .PopulateColumns(Ds.Tables("t25"))

            'List colom visible
            .Columns("k01cKodeFinishedGood_v50").VisibleIndex = -1
            .Columns("k02cKodeRubber_v50").VisibleIndex = -1
            .Columns("k03cKodeItemCastedParts_v50").VisibleIndex = -1
            .Columns("k04cVersionBOM_v50").VisibleIndex = -1
            .Columns("f04cKodeAssembly_v50").VisibleIndex = -1
            .Columns("f04cKodeAssembly_v50").VisibleIndex = -1
            .Columns("f07cKodePlating_v50").VisibleIndex = -1
            .Columns("f10cKodeFinishing_v50").VisibleIndex = -1
            .Columns("f30cIDUser_v50").VisibleIndex = -1
            .Columns("f31cNamaUser_v50").VisibleIndex = -1
            '.Columns("f32dCreatedDate").VisibleIndex = -1

            'Set Caption
            .Columns("k02cKodeRubber_v50").Caption = "Rubber Code"
            .Columns("f01cItemCastedPartsDesc_v50").Caption = "Item"

            .Columns("f02nPcs_int").Caption = "Pcs"
            .Columns("f02nPcs_int").ColumnEdit = New RepositoryItemSpinEdit()
            .Columns("f02nPcs_int").ColumnEditName = "rsdt25_f02nPcs_int"

            .Columns("f03nBerat_n92").Caption = "Weight"
            .Columns("f03nBerat_n92").ColumnEdit = New RepositoryItemSpinEdit()
            .Columns("f03nBerat_n92").ColumnEditName = "rsdt25_f03nBerat_n92"

            .Columns("f05cAssemblyDesc_v50").Caption = "Assembly"
            .Columns("f06cPerintahFinishing_v50").Caption = "Finishing"
            .Columns("f08cPlatingDesc_v50").Caption = "Plating"

            .Columns("f09nWeightPerPcs_n92").Caption = "W /Pcs"
            .Columns("f09nWeightPerPcs_n92").ColumnEdit = New RepositoryItemSpinEdit()
            .Columns("f09nWeightPerPcs_n92").ColumnEditName = "rsdt25_f09nWeightPerPcs_n92"

            .Columns("f11cKeyGUIDGambar_v50").Caption = "Image"
            .Columns("f11cKeyGUIDGambar_v50").ColumnEdit = New RepositoryItemPictureEdit()
            .Columns("f11cKeyGUIDGambar_v50").ColumnEditName = "rsdt25_f11cKeyGUIDGambar_v50"
            .Columns("f12cNote_v100").Caption = "Notes"

            .Columns("f32dCreatedDate").Caption = "Created"
        End With

        ''detail 26 Finding Component
        Dim gvDetail26 As New GridView(_gcBOM)
        _gcBOM.LevelTree.Nodes.Add("rsHeaderTo26", gvDetail26)
        With gvDetail26
            .ViewCaption = "BOM FINDING COMPONENT"
            .PopulateColumns(Ds.Tables("t26"))

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

            'set visible colmn code
            .Columns("k01cKodeFinishedGood_v50").VisibleIndex = -1
            .Columns("f11cKodeFinishing_v50").VisibleIndex = -1
            .Columns("k02cKodeItemFindingComponent_v50").VisibleIndex = -1
            .Columns("k03cVersionBOM_v50").VisibleIndex = -1
            .Columns("f04cKodeAssembly_v50").VisibleIndex = -1
            .Columns("f07cKodePlating_v50").VisibleIndex = -1
            .Columns("f30cIDUser_v50").VisibleIndex = -1
            .Columns("f31cNamaUser_v50").VisibleIndex = -1
            '.Columns("f32dCreatedDate").VisibleIndex = -1

            'Set View Caption
            .Columns("f01cItemFindingComponentDesc_v50").Caption = "Item"
            .Columns("f02nPcs_int").Caption = "Pcs"
            .Columns("f02nPcs_int").ColumnEdit = New RepositoryItemBaseSpinEdit()
            .Columns("f02nPcs_int").ColumnEditName = "rsdt26_f02nPcs_int"

            .Columns("f03nBerat_n92").Caption = "Weight"
            .Columns("f03nBerat_n92").ColumnEdit = New RepositoryItemBaseSpinEdit()
            .Columns("f03nBerat_n92").ColumnEditName = "rsdt26_f03nBerat_n92"

            .Columns("f05cAssemblyDesc_v50").Caption = "Assembly"
            .Columns("f06cPerintahFinishing_v50").Caption = "Finishing"
            .Columns("f08cPlatingDesc_v50").Caption = "Plating"
            .Columns("f09cNotes_v50").Caption = "Notes"

            .Columns("f10nWeightPerPcs_n92").Caption = "W / Pcs"
            .Columns("f10nWeightPerPcs_n92").ColumnEdit = New RepositoryItemBaseSpinEdit()
            .Columns("f10nWeightPerPcs_n92").ColumnEditName = "rsdt26_f10nWeightPerPcs_n92"

            .Columns("f32dCreatedDate").Caption = "Created"
        End With

        'Detail 27
        Dim gvDetail27 As New GridView(_gcBOM)
        _gcBOM.LevelTree.Nodes.Add("rsHeaderTo27", gvDetail27)
        With gvDetail27
            .ViewCaption = "BOM Stones"
            .PopulateColumns(Ds.Tables("t27"))

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

            'Set Visibel Columns
            .Columns("k01cKodeFinishedGood_v50").VisibleIndex = -1
            .Columns("k02cKodeStones_v50").VisibleIndex = -1
            .Columns("k03cVersionBOM_v50").VisibleIndex = -1
            .Columns("f07cKodeSetting_v50").VisibleIndex = -1
            .Columns("f07cKodeSetting_v50").VisibleIndex = -1
            .Columns("f30cIDUser_v50").VisibleIndex = -1
            .Columns("f31cNamaUser_v50").VisibleIndex = -1
            '.Columns("f32dCreatedDate").VisibleIndex = -1

            'Set Caption
            .Columns("f01cStonesDesc_v50").Caption = "Stone"

            .Columns("f02cSizeDesc_v50").Caption = "Size"
            .Columns("f02cSizeDesc_v50").ColumnEdit = New RepositoryItemBaseSpinEdit()
            .Columns("f02cSizeDesc_v50").ColumnEditName = "rsdt27_f02cSizeDesc_v50"

            .Columns("f03cQualityDesc_v50").Caption = "Qty"
            .Columns("f04cBrandDesc_v50").Caption = "Brand"

            .Columns("f05nButir_int").Caption = "Pcs"
            .Columns("f05nButir_int").ColumnEdit = New RepositoryItemBaseSpinEdit()
            .Columns("f05nButir_int").ColumnEditName = "rsdt27_f05nButir_int"

            .Columns("f06nBeratGram_n93").Caption = "Weight"
            .Columns("f06nBeratGram_n93").ColumnEdit = New RepositoryItemBaseSpinEdit()
            .Columns("f06nBeratGram_n93").ColumnEditName = "rsdt27_f06nBeratGram_n93"

            .Columns("f08cSettingDesc_v50").Caption = "Setting"

            .Columns("f09nWeightPerPcs_n93").Caption = "W / Pcs"
            .Columns("f09nWeightPerPcs_n93").ColumnEdit = New RepositoryItemBaseSpinEdit()
            .Columns("f09nWeightPerPcs_n93").ColumnEditName = "rsdt27_f09nWeightPerPcs_n93"
            .Columns("f32dCreatedDate").Caption = "Created"
        End With

        _gvBOM.OptionsPrint.PrintDetails = True
        _gvBOM.OptionsPrint.ExpandAllDetails = True

        _gcBOM.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
        _gcBOM.LookAndFeel.UseDefaultLookAndFeel = False
        _gcBOM.DataSource = Nothing
        _gcBOM.DataSource = Ds.Tables("Header")
        _gcBOM.ForceInitialize()
    End Sub

#End Region

#Region " Grid : Event"

    Private Sub _gcBOM_DoubleClick(sender As Object, e As EventArgs) Handles _gcBOM.DoubleClick
        _gcBOM.ShowPrintPreview()
    End Sub

#End Region

End Class
