<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class BOMReportFCP
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Designer
    'It can be modified using the Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim XrSummary1 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary2 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Dim XrSummary3 As DevExpress.XtraReports.UI.XRSummary = New DevExpress.XtraReports.UI.XRSummary()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell11 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.BOMFcpPicture = New DevExpress.XtraReports.UI.XRTableCell()
        Me.BOMFcpk02cKodeItemFindingComponent_v50 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.BOMFCf01cItemFindingComponentDesc_v50 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.BOMFcpf10nWeightPerPcs_n92 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.BOMPCf02nPcs_int = New DevExpress.XtraReports.UI.XRTableCell()
        Me.BOMFCf03nBerat_n92 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.BOMFcpf05cAssemblyDesc_v50 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.BOMFcpf06cPerintahFinishing_v50 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.BOMfCF08cPlatingDesc_v50 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.BOMFcpf09cNotes_v50 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.BOMFCFooterTable = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell14 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.BOMFCPCellTotalPcs = New DevExpress.XtraReports.UI.XRTableCell()
        Me.BOMFCPCellTotalwiegth = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.BOMFCPHeaderTable = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell12 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BOMFCFooterTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BOMFCPHeaderTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TopMargin
        '
        Me.TopMargin.Dpi = 254.0!
        Me.TopMargin.HeightF = 0!
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.Dpi = 254.0!
        Me.BottomMargin.HeightF = 0!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable2})
        Me.Detail.Dpi = 254.0!
        Me.Detail.HeightF = 50.0!
        Me.Detail.Name = "Detail"
        '
        'XrTable2
        '
        Me.XrTable2.BackColor = System.Drawing.Color.Transparent
        Me.XrTable2.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable2.Dpi = 254.0!
        Me.XrTable2.Font = New DevExpress.Drawing.DXFont("Calibri", 6.75!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(1999.0!, 50.0!)
        Me.XrTable2.StylePriority.UseBackColor = False
        Me.XrTable2.StylePriority.UseBorders = False
        Me.XrTable2.StylePriority.UseFont = False
        Me.XrTable2.StylePriority.UseTextAlignment = False
        Me.XrTable2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell11, Me.BOMFcpPicture, Me.BOMFcpk02cKodeItemFindingComponent_v50, Me.BOMFCf01cItemFindingComponentDesc_v50, Me.BOMFcpf10nWeightPerPcs_n92, Me.BOMPCf02nPcs_int, Me.BOMFCf03nBerat_n92, Me.BOMFcpf05cAssemblyDesc_v50, Me.BOMFcpf06cPerintahFinishing_v50, Me.BOMfCF08cPlatingDesc_v50, Me.BOMFcpf09cNotes_v50})
        Me.XrTableRow2.Dpi = 254.0!
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.0R
        '
        'XrTableCell11
        '
        Me.XrTableCell11.Dpi = 254.0!
        Me.XrTableCell11.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumRecordNumber()")})
        Me.XrTableCell11.Multiline = True
        Me.XrTableCell11.Name = "XrTableCell11"
        XrSummary1.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.XrTableCell11.Summary = XrSummary1
        Me.XrTableCell11.Weight = 0.39756003876491564R
        '
        'BOMFcpPicture
        '
        Me.BOMFcpPicture.Dpi = 254.0!
        Me.BOMFcpPicture.Multiline = True
        Me.BOMFcpPicture.Name = "BOMFcpPicture"
        Me.BOMFcpPicture.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 10, 10, 254.0!)
        Me.BOMFcpPicture.StylePriority.UsePadding = False
        Me.BOMFcpPicture.StylePriority.UseTextAlignment = False
        Me.BOMFcpPicture.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.BOMFcpPicture.Weight = 0.8562832044372708R
        '
        'BOMFcpk02cKodeItemFindingComponent_v50
        '
        Me.BOMFcpk02cKodeItemFindingComponent_v50.Dpi = 254.0!
        Me.BOMFcpk02cKodeItemFindingComponent_v50.Multiline = True
        Me.BOMFcpk02cKodeItemFindingComponent_v50.Name = "BOMFcpk02cKodeItemFindingComponent_v50"
        Me.BOMFcpk02cKodeItemFindingComponent_v50.Weight = 1.4899282900709703R
        '
        'BOMFCf01cItemFindingComponentDesc_v50
        '
        Me.BOMFCf01cItemFindingComponentDesc_v50.Dpi = 254.0!
        Me.BOMFCf01cItemFindingComponentDesc_v50.Multiline = True
        Me.BOMFCf01cItemFindingComponentDesc_v50.Name = "BOMFCf01cItemFindingComponentDesc_v50"
        Me.BOMFCf01cItemFindingComponentDesc_v50.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.BOMFCf01cItemFindingComponentDesc_v50.StylePriority.UsePadding = False
        Me.BOMFCf01cItemFindingComponentDesc_v50.StylePriority.UseTextAlignment = False
        Me.BOMFCf01cItemFindingComponentDesc_v50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.BOMFCf01cItemFindingComponentDesc_v50.Weight = 2.1215337892987378R
        '
        'BOMFcpf10nWeightPerPcs_n92
        '
        Me.BOMFcpf10nWeightPerPcs_n92.Dpi = 254.0!
        Me.BOMFcpf10nWeightPerPcs_n92.Multiline = True
        Me.BOMFcpf10nWeightPerPcs_n92.Name = "BOMFcpf10nWeightPerPcs_n92"
        Me.BOMFcpf10nWeightPerPcs_n92.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.BOMFcpf10nWeightPerPcs_n92.StylePriority.UsePadding = False
        Me.BOMFcpf10nWeightPerPcs_n92.StylePriority.UseTextAlignment = False
        Me.BOMFcpf10nWeightPerPcs_n92.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.BOMFcpf10nWeightPerPcs_n92.Weight = 1.544199411479567R
        '
        'BOMPCf02nPcs_int
        '
        Me.BOMPCf02nPcs_int.Dpi = 254.0!
        Me.BOMPCf02nPcs_int.Multiline = True
        Me.BOMPCf02nPcs_int.Name = "BOMPCf02nPcs_int"
        Me.BOMPCf02nPcs_int.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.BOMPCf02nPcs_int.StylePriority.UsePadding = False
        Me.BOMPCf02nPcs_int.StylePriority.UseTextAlignment = False
        Me.BOMPCf02nPcs_int.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.BOMPCf02nPcs_int.Weight = 0.78070063015581992R
        '
        'BOMFCf03nBerat_n92
        '
        Me.BOMFCf03nBerat_n92.Dpi = 254.0!
        Me.BOMFCf03nBerat_n92.Multiline = True
        Me.BOMFCf03nBerat_n92.Name = "BOMFCf03nBerat_n92"
        Me.BOMFCf03nBerat_n92.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.BOMFCf03nBerat_n92.StylePriority.UsePadding = False
        Me.BOMFCf03nBerat_n92.StylePriority.UseTextAlignment = False
        Me.BOMFCf03nBerat_n92.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.BOMFCf03nBerat_n92.Weight = 1.0976866326019048R
        '
        'BOMFcpf05cAssemblyDesc_v50
        '
        Me.BOMFcpf05cAssemblyDesc_v50.Dpi = 254.0!
        Me.BOMFcpf05cAssemblyDesc_v50.Multiline = True
        Me.BOMFcpf05cAssemblyDesc_v50.Name = "BOMFcpf05cAssemblyDesc_v50"
        Me.BOMFcpf05cAssemblyDesc_v50.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.BOMFcpf05cAssemblyDesc_v50.StylePriority.UsePadding = False
        Me.BOMFcpf05cAssemblyDesc_v50.StylePriority.UseTextAlignment = False
        Me.BOMFcpf05cAssemblyDesc_v50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.BOMFcpf05cAssemblyDesc_v50.Weight = 0.9193420737938347R
        '
        'BOMFcpf06cPerintahFinishing_v50
        '
        Me.BOMFcpf06cPerintahFinishing_v50.Dpi = 254.0!
        Me.BOMFcpf06cPerintahFinishing_v50.Multiline = True
        Me.BOMFcpf06cPerintahFinishing_v50.Name = "BOMFcpf06cPerintahFinishing_v50"
        Me.BOMFcpf06cPerintahFinishing_v50.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.BOMFcpf06cPerintahFinishing_v50.StylePriority.UsePadding = False
        Me.BOMFcpf06cPerintahFinishing_v50.StylePriority.UseTextAlignment = False
        Me.BOMFcpf06cPerintahFinishing_v50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.BOMFcpf06cPerintahFinishing_v50.Weight = 0.99106299360055317R
        '
        'BOMfCF08cPlatingDesc_v50
        '
        Me.BOMfCF08cPlatingDesc_v50.Dpi = 254.0!
        Me.BOMfCF08cPlatingDesc_v50.Multiline = True
        Me.BOMfCF08cPlatingDesc_v50.Name = "BOMfCF08cPlatingDesc_v50"
        Me.BOMfCF08cPlatingDesc_v50.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.BOMfCF08cPlatingDesc_v50.StylePriority.UsePadding = False
        Me.BOMfCF08cPlatingDesc_v50.StylePriority.UseTextAlignment = False
        Me.BOMfCF08cPlatingDesc_v50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.BOMfCF08cPlatingDesc_v50.Weight = 1.0306124641985539R
        '
        'BOMFcpf09cNotes_v50
        '
        Me.BOMFcpf09cNotes_v50.Dpi = 254.0!
        Me.BOMFcpf09cNotes_v50.Multiline = True
        Me.BOMFcpf09cNotes_v50.Name = "BOMFcpf09cNotes_v50"
        Me.BOMFcpf09cNotes_v50.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 5, 5, 254.0!)
        Me.BOMFcpf09cNotes_v50.StylePriority.UsePadding = False
        Me.BOMFcpf09cNotes_v50.StylePriority.UseTextAlignment = False
        Me.BOMFcpf09cNotes_v50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.BOMFcpf09cNotes_v50.Weight = 0.99759084393448738R
        '
        'XrLabel1
        '
        Me.XrLabel1.BackColor = System.Drawing.Color.Transparent
        Me.XrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel1.Dpi = 254.0!
        Me.XrLabel1.Font = New DevExpress.Drawing.DXFont("Calibri", 9.75!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(1999.0!, 58.41998!)
        Me.XrLabel1.StylePriority.UseBackColor = False
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "FINDING / COMPONENTS "
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'BOMFCFooterTable
        '
        Me.BOMFCFooterTable.BackColor = System.Drawing.Color.WhiteSmoke
        Me.BOMFCFooterTable.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.BOMFCFooterTable.Dpi = 254.0!
        Me.BOMFCFooterTable.Font = New DevExpress.Drawing.DXFont("Calibri", 6.75!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.BOMFCFooterTable.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.BOMFCFooterTable.Name = "BOMFCFooterTable"
        Me.BOMFCFooterTable.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.BOMFCFooterTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3})
        Me.BOMFCFooterTable.SizeF = New System.Drawing.SizeF(1999.0!, 50.0!)
        Me.BOMFCFooterTable.StylePriority.UseBackColor = False
        Me.BOMFCFooterTable.StylePriority.UseBorders = False
        Me.BOMFCFooterTable.StylePriority.UseFont = False
        Me.BOMFCFooterTable.StylePriority.UseTextAlignment = False
        Me.BOMFCFooterTable.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow3
        '
        Me.XrTableRow3.BackColor = System.Drawing.Color.Transparent
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell14, Me.BOMFCPCellTotalPcs, Me.BOMFCPCellTotalwiegth, Me.XrTableCell24})
        Me.XrTableRow3.Dpi = 254.0!
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.StylePriority.UseBackColor = False
        Me.XrTableRow3.Weight = 1.0R
        '
        'XrTableCell14
        '
        Me.XrTableCell14.Dpi = 254.0!
        Me.XrTableCell14.Font = New DevExpress.Drawing.DXFont("Calibri", 8.25!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell14.Multiline = True
        Me.XrTableCell14.Name = "XrTableCell14"
        Me.XrTableCell14.StylePriority.UseFont = False
        Me.XrTableCell14.Text = "TOTAL"
        Me.XrTableCell14.Weight = 2.1175057565731259R
        '
        'BOMFCPCellTotalPcs
        '
        Me.BOMFCPCellTotalPcs.Dpi = 254.0!
        Me.BOMFCPCellTotalPcs.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([f02nPcs_int])")})
        Me.BOMFCPCellTotalPcs.Font = New DevExpress.Drawing.DXFont("Calibri", 8.25!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.BOMFCPCellTotalPcs.Multiline = True
        Me.BOMFCPCellTotalPcs.Name = "BOMFCPCellTotalPcs"
        Me.BOMFCPCellTotalPcs.StylePriority.UseFont = False
        XrSummary2.Running = DevExpress.XtraReports.UI.SummaryRunning.Page
        Me.BOMFCPCellTotalPcs.Summary = XrSummary2
        Me.BOMFCPCellTotalPcs.Weight = 0.25792015260054812R
        '
        'BOMFCPCellTotalwiegth
        '
        Me.BOMFCPCellTotalwiegth.Dpi = 254.0!
        Me.BOMFCPCellTotalwiegth.ExpressionBindings.AddRange(New DevExpress.XtraReports.UI.ExpressionBinding() {New DevExpress.XtraReports.UI.ExpressionBinding("BeforePrint", "Text", "sumSum([f03nBerat_n92])")})
        Me.BOMFCPCellTotalwiegth.Font = New DevExpress.Drawing.DXFont("Calibri", 8.25!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.BOMFCPCellTotalwiegth.Multiline = True
        Me.BOMFCPCellTotalwiegth.Name = "BOMFCPCellTotalwiegth"
        Me.BOMFCPCellTotalwiegth.StylePriority.UseFont = False
        XrSummary3.Running = DevExpress.XtraReports.UI.SummaryRunning.Report
        Me.BOMFCPCellTotalwiegth.Summary = XrSummary3
        Me.BOMFCPCellTotalwiegth.TextFormatString = "{0:n2}"
        Me.BOMFCPCellTotalwiegth.Weight = 0.3626422140431107R
        '
        'XrTableCell24
        '
        Me.XrTableCell24.Dpi = 254.0!
        Me.XrTableCell24.Multiline = True
        Me.XrTableCell24.Name = "XrTableCell24"
        Me.XrTableCell24.Weight = 1.3011965143639859R
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.BOMFCFooterTable})
        Me.ReportFooter.Dpi = 254.0!
        Me.ReportFooter.HeightF = 63.5!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.BOMFCPHeaderTable, Me.XrLabel1})
        Me.PageHeader.Dpi = 254.0!
        Me.PageHeader.HeightF = 108.42!
        Me.PageHeader.Name = "PageHeader"
        '
        'BOMFCPHeaderTable
        '
        Me.BOMFCPHeaderTable.BackColor = System.Drawing.Color.Transparent
        Me.BOMFCPHeaderTable.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.BOMFCPHeaderTable.Dpi = 254.0!
        Me.BOMFCPHeaderTable.Font = New DevExpress.Drawing.DXFont("Calibri", 8.25!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.BOMFCPHeaderTable.LocationFloat = New DevExpress.Utils.PointFloat(0!, 58.41996!)
        Me.BOMFCPHeaderTable.Name = "BOMFCPHeaderTable"
        Me.BOMFCPHeaderTable.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.BOMFCPHeaderTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1})
        Me.BOMFCPHeaderTable.SizeF = New System.Drawing.SizeF(1999.0!, 50.0!)
        Me.BOMFCPHeaderTable.StylePriority.UseBackColor = False
        Me.BOMFCPHeaderTable.StylePriority.UseBorders = False
        Me.BOMFCPHeaderTable.StylePriority.UseFont = False
        Me.BOMFCPHeaderTable.StylePriority.UseTextAlignment = False
        Me.BOMFCPHeaderTable.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell4, Me.XrTableCell12, Me.XrTableCell5, Me.XrTableCell6, Me.XrTableCell7, Me.XrTableCell8, Me.XrTableCell9, Me.XrTableCell10})
        Me.XrTableRow1.Dpi = 254.0!
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Dpi = 254.0!
        Me.XrTableCell1.Multiline = True
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Text = "NO"
        Me.XrTableCell1.Weight = 0.55571179271470283R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Dpi = 254.0!
        Me.XrTableCell2.Multiline = True
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Text = "IMAGE"
        Me.XrTableCell2.Weight = 1.196917783762411R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Dpi = 254.0!
        Me.XrTableCell3.Multiline = True
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Text = "MATERIAL CODE"
        Me.XrTableCell3.Weight = 2.0826305012289R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Dpi = 254.0!
        Me.XrTableCell4.Multiline = True
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Text = "MATERIAL DESC"
        Me.XrTableCell4.Weight = 2.9654930102501051R
        '
        'XrTableCell12
        '
        Me.XrTableCell12.Dpi = 254.0!
        Me.XrTableCell12.Multiline = True
        Me.XrTableCell12.Name = "XrTableCell12"
        Me.XrTableCell12.Text = "Wt / PCS"
        Me.XrTableCell12.Weight = 2.1584901886982961R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Dpi = 254.0!
        Me.XrTableCell5.Multiline = True
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Text = "PCS"
        Me.XrTableCell5.Weight = 1.0912668964386936R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Dpi = 254.0!
        Me.XrTableCell6.Multiline = True
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.Text = "T.Wt"
        Me.XrTableCell6.Weight = 1.5343545812800876R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Dpi = 254.0!
        Me.XrTableCell7.Multiline = True
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Text = "ASSEMBLY"
        Me.XrTableCell7.Weight = 1.2850615524590947R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.Dpi = 254.0!
        Me.XrTableCell8.Multiline = True
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.Text = "FINISHING"
        Me.XrTableCell8.Weight = 1.3853135684357181R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Dpi = 254.0!
        Me.XrTableCell9.Multiline = True
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.Text = "PLATING"
        Me.XrTableCell9.Weight = 1.4405942324325858R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.Dpi = 254.0!
        Me.XrTableCell10.Multiline = True
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.Text = "NOTE"
        Me.XrTableCell10.Weight = 1.3944412199995591R
        '
        'BOMReportFCP
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail, Me.ReportFooter, Me.PageHeader})
        Me.Dpi = 254.0!
        Me.Font = New DevExpress.Drawing.DXFont("Arial", 9.75!)
        Me.Margins = New DevExpress.Drawing.DXMargins(0, 101, 0, 0)
        Me.PageHeight = 2970
        Me.PageWidth = 2100
        Me.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.SnapGridSize = 25.0!
        Me.Version = "19.2"
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BOMFCFooterTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BOMFCPHeaderTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub


    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell11 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents BOMFcpPicture As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents BOMFcpk02cKodeItemFindingComponent_v50 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents BOMFCf01cItemFindingComponentDesc_v50 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents BOMPCf02nPcs_int As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents BOMFCf03nBerat_n92 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents BOMFcpf05cAssemblyDesc_v50 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents BOMFcpf06cPerintahFinishing_v50 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents BOMfCF08cPlatingDesc_v50 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents BOMFcpf09cNotes_v50 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents BOMFCFooterTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents BOMFCPCellTotalPcs As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents BOMFCPCellTotalwiegth As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell24 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrTableCell14 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents BOMFCPHeaderTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents BOMFcpf10nWeightPerPcs_n92 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell12 As DevExpress.XtraReports.UI.XRTableCell
End Class
