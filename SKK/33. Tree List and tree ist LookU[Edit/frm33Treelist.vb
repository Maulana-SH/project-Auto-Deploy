Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Columns
Imports DevExpress.XtraTreeList.Nodes
Imports DevExpress.XtraTreeList.StyleFormatConditions
Imports System.ComponentModel.DataAnnotations

Public Class frm33Treelist
    Private Sub frm33Treelist_Load(sender As Object, e As EventArgs) Handles Me.Load
        Dim treeList1 As TreeList = New TreeList()
        treeList1.Parent = Me
        treeList1.Dock = DockStyle.Fill
        'Specify the fields that arrange underlying data as a hierarchy.
        treeList1.KeyFieldName = "ID"
        treeList1.ParentFieldName = "RegionID"
        'Allow the treelist to create columns bound to the fields the KeyFieldName and ParentFieldName properties specify.
        treeList1.OptionsBehavior.PopulateServiceColumns = True
        'Specify the data source.
        treeList1.DataSource = SalesDataGenerator.CreateData()
        'The treelist automatically creates columns for the public fields found in the data source. 
        'You do not need to call the TreeList.PopulateColumns method unless the treeList1.OptionsBehavior.AutoPopulateColumns option is disabled.

        'Change the row height.
        treeList1.RowHeight = 23

        'Access the automatically created columns.
        Dim colRegion As TreeListColumn = treeList1.Columns("Region")
        Dim colMarchSales As TreeListColumn = treeList1.Columns("MarchSales")
        Dim colSeptemberSales As TreeListColumn = treeList1.Columns("SeptemberSales")
        Dim colMarchSalesPrev As TreeListColumn = treeList1.Columns("MarchSalesPrev")
        Dim colSeptemberSalesPrev As TreeListColumn = treeList1.Columns("SeptemberSalesPrev")
        Dim colMarketShare As TreeListColumn = treeList1.Columns("MarketShare")

        'Hide the key columns. An end-user can access them from the Customization Form.
        treeList1.Columns(treeList1.KeyFieldName).Visible = False
        treeList1.Columns(treeList1.ParentFieldName).Visible = False

        'Format column headers and cell values.
        colMarchSalesPrev.Caption = "<i>Previous <b>March</b> Sales</i>"
        colSeptemberSalesPrev.Caption = "<i>Previous <b>September</b> Sales</i>"
        treeList1.OptionsView.AllowHtmlDrawHeaders = True
        colMarchSalesPrev.AppearanceCell.Font = New System.Drawing.Font(colMarchSalesPrev.AppearanceCell.Font, System.Drawing.FontStyle.Italic)
        colSeptemberSalesPrev.AppearanceCell.Font = New System.Drawing.Font(colSeptemberSalesPrev.AppearanceCell.Font, System.Drawing.FontStyle.Italic)

        'Create two hidden unbound columns that calculate their values from expressions.
        Dim colUnboundMarchChange As TreeListColumn = treeList1.Columns.AddField("FromPrevMarchChange")
        colUnboundMarchChange.Caption = "Change from prev March"
        colUnboundMarchChange.UnboundDataType = GetType(Decimal)
        colUnboundMarchChange.UnboundExpression = "[MarchSales]-[MarchSalesPrev]"
        Dim colUnboundSeptemberChange As TreeListColumn = treeList1.Columns.AddField("FromPrevSepChange")
        colUnboundSeptemberChange.Caption = "Change from prev September"
        colUnboundSeptemberChange.UnboundDataType = GetType(Decimal)
        colUnboundSeptemberChange.UnboundExpression = "[SeptemberSales]-[SeptemberSalesPrev]"
        colUnboundMarchChange.OptionsColumn.ShowInCustomizationForm = False
        colUnboundSeptemberChange.OptionsColumn.ShowInCustomizationForm = False

        'Make the Region column read-only.
        colRegion.OptionsColumn.ReadOnly = True

        'Sort data against the Region column
        colRegion.SortIndex = 0

        'Apply a filter.
        treeList1.ActiveFilterString = "[MarchSales] > 10000"

        'Calculate two total summaries against root nodes.
        colMarchSales.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Sum
        colMarchSales.SummaryFooterStrFormat = "Total={0:c0}"
        colMarchSales.AllNodesSummary = False
        colSeptemberSales.SummaryFooter = DevExpress.XtraTreeList.SummaryItemType.Sum
        colSeptemberSales.SummaryFooterStrFormat = "Total={0:c0}"
        colSeptemberSales.AllNodesSummary = False
        treeList1.OptionsView.ShowSummaryFooter = True

        'Use a 'SpinEdit' in-place editor for the *Sales columns.
        Dim riSpinEdit As RepositoryItemSpinEdit = New RepositoryItemSpinEdit()
        riSpinEdit.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        riSpinEdit.DisplayFormat.FormatString = "c0"
        treeList1.RepositoryItems.Add(riSpinEdit)
        colMarchSales.ColumnEdit = riSpinEdit
        colMarchSalesPrev.ColumnEdit = riSpinEdit
        colSeptemberSales.ColumnEdit = riSpinEdit
        colSeptemberSalesPrev.ColumnEdit = riSpinEdit

        'Apply Excel-style formatting: display predefined 'Up Arrow' and 'Down Arrow' icons based on the unbound column values.
        Dim rule1 As TreeListFormatRule = New TreeListFormatRule()
        rule1.Rule = createThreeTrianglesIconSetRule()
        rule1.Column = colUnboundMarchChange
        rule1.ColumnApplyTo = colMarchSales
        Dim rule2 As TreeListFormatRule = New TreeListFormatRule()
        rule2.Rule = createThreeTrianglesIconSetRule()
        rule2.Column = colUnboundSeptemberChange
        rule2.ColumnApplyTo = colSeptemberSales
        treeList1.FormatRules.Add(rule1)
        treeList1.FormatRules.Add(rule2)

        'Do not stretch columns to the treelist width.
        treeList1.OptionsView.AutoWidth = False

        'Locate a node by a value it contains.
        Dim node1 As TreeListNode = treeList1.FindNodeByFieldValue("Region", "North America")
        'Focus and expand this node.
        treeList1.FocusedNode = node1
        node1.Expanded = True

        'Locate a node by its key field value and expand it.
        Dim node2 As TreeListNode = treeList1.FindNodeByKeyID(32) 'Node 'Asia'
        node2.Expand()

        'Calculate the optimal column widths after the treelist is shown.
        Me.BeginInvoke(New MethodInvoker(Sub()
                                             treeList1.BestFitColumns()
                                         End Sub))
    End Sub

    Private Function createThreeTrianglesIconSetRule() As FormatConditionRuleIconSet
        Dim ruleIconSet As FormatConditionRuleIconSet = New FormatConditionRuleIconSet()
        Dim iconSet As FormatConditionIconSet = New FormatConditionIconSet()
        ruleIconSet.IconSet = iconSet
        Dim icon1 As FormatConditionIconSetIcon = New FormatConditionIconSetIcon()
        Dim icon2 As FormatConditionIconSetIcon = New FormatConditionIconSetIcon()
        Dim icon3 As FormatConditionIconSetIcon = New FormatConditionIconSetIcon()
        'Choose predefined icons. 
        icon1.PredefinedName = "Triangles3_3.png"
        icon2.PredefinedName = "Triangles3_2.png"
        icon3.PredefinedName = "Triangles3_1.png"
        'Specify the type of threshold values. 
        iconSet.ValueType = FormatConditionValueType.Number
        'Define ranges to which icons are applied by setting threshold values. 
        icon1.Value = Decimal.MinValue
        icon1.ValueComparison = FormatConditionComparisonType.GreaterOrEqual
        icon2.Value = 0
        icon2.ValueComparison = FormatConditionComparisonType.GreaterOrEqual
        icon3.Value = 0
        icon3.ValueComparison = FormatConditionComparisonType.Greater
        'Add icons to the icon set. 
        iconSet.Icons.Add(icon1)
        iconSet.Icons.Add(icon2)
        iconSet.Icons.Add(icon3)
        Return ruleIconSet
    End Function
End Class

Public Class SalesData
    Shared UniqueID As Integer = 37

    Public Sub New()
        ID = Math.Min(System.Threading.Interlocked.Increment(UniqueID), UniqueID - 1)
    End Sub

    Public Sub New(ByVal id As Integer, ByVal regionId As Integer, ByVal region As String, ByVal marchSales As Decimal, ByVal septemberSales As Decimal, ByVal marchSalesPrev As Decimal, ByVal septermberSalesPrev As Decimal, ByVal marketShare As Double)
        Me.ID = id
        Me.RegionID = regionId
        Me.Region = region
        Me.MarchSales = marchSales
        Me.SeptemberSales = septemberSales
        Me.MarchSalesPrev = marchSalesPrev
        Me.SeptemberSalesPrev = septermberSalesPrev
        Me.MarketShare = marketShare
    End Sub

    Public Property ID As Integer
    Public Property RegionID As Integer
    Public Property Region As String
    Public Property MarchSales As Decimal
    Public Property SeptemberSales As Decimal
    Public Property MarchSalesPrev As Decimal
    Public Property SeptemberSalesPrev As Decimal
    <DisplayFormat(DataFormatString:="p0")>
    Public Property MarketShare As Double
End Class

Public Class SalesDataGenerator
    Public Shared Function CreateData() As List(Of SalesData)
        Dim sales As List(Of SalesData) = New List(Of SalesData)()
        sales.Add(New SalesData(0, -1, "Western Europe", 30540, 33000, 32220, 35500, 0.7))
        sales.Add(New SalesData(1, 0, "Austria", 22000, 28000, 26120, 28500, 0.92))
        sales.Add(New SalesData(2, 0, "France", 23020, 27000, 20120, 29200, 0.51))
        sales.Add(New SalesData(3, 0, "Germany", 30540, 33000, 32220, 35500, 0.93))
        sales.Add(New SalesData(4, 0, "Spain", 12900, 10300, 14300, 9900, 0.82))
        sales.Add(New SalesData(5, 0, "Switzerland", 9323, 10730, 7244, 9400, 0.14))
        sales.Add(New SalesData(6, 0, "United Kingdom", 14580, 13967, 15200, 16900, 0.91))
        sales.Add(New SalesData(17, -1, "Eastern Europe", 22500, 24580, 21225, 22698, 0.62))
        sales.Add(New SalesData(18, 17, "Belarus", 7315, 18800, 8240, 17480, 0.34))
        sales.Add(New SalesData(19, 17, "Bulgaria", 6300, 2821, 5200, 10880, 0.8))
        sales.Add(New SalesData(20, 17, "Croatia", 4200, 3890, 3880, 4430, 0.29))
        sales.Add(New SalesData(21, 17, "Russia", 22500, 24580, 21225, 22698, 0.85))
        sales.Add(New SalesData(26, -1, "North America", 31400, 32800, 30300, 31940, 0.84))
        sales.Add(New SalesData(27, 26, "USA", 31400, 32800, 30300, 31940, 0.87))
        sales.Add(New SalesData(28, 26, "Canada", 25390, 27000, 5200, 29880, 0.64))
        sales.Add(New SalesData(29, -1, "South America", 16380, 17590, 15400, 16680, 0.32))
        sales.Add(New SalesData(30, 29, "Argentina", 16380, 17590, 15400, 16680, 0.88))
        sales.Add(New SalesData(31, 29, "Brazil", 4560, 9480, 3900, 6100, 0.1))
        sales.Add(New SalesData(32, -1, "Asia", 20388, 22547, 22500, 25756, 0.52))
        sales.Add(New SalesData(34, 32, "India", 4642, 5320, 4200, 6470, 0.44))
        sales.Add(New SalesData(35, 32, "Japan", 9457, 12859, 8300, 8733, 0.7))
        sales.Add(New SalesData(36, 32, "China", 20388, 22547, 22500, 25756, 0.82))
        Return sales
    End Function
End Class