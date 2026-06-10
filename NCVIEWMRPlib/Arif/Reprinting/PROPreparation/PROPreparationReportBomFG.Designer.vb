<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class PROPreparationReportBomFG
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
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.PROBomFooterTable = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.ProPrepBOMFGPicture = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ProPrepBOMFGf12cRawMaterialDesc_v50 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ProPrepBOMFGf06cSize_v50 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ProPrepBOMFGNote = New DevExpress.XtraReports.UI.XRTableCell()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.ProPrepBomFGHeaderTable = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        CType(Me.PROBomFooterTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProPrepBomFGHeaderTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 2.0!
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 1.0!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.PROBomFooterTable})
        Me.Detail.HeightF = 28.33335!
        Me.Detail.Name = "Detail"
        '
        'PROBomFooterTable
        '
        Me.PROBomFooterTable.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.PROBomFooterTable.Font = New DevExpress.Drawing.DXFont("Calibri", 6.75!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.PROBomFooterTable.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.PROBomFooterTable.Name = "PROBomFooterTable"
        Me.PROBomFooterTable.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.PROBomFooterTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.PROBomFooterTable.SizeF = New System.Drawing.SizeF(480.0!, 28.33335!)
        Me.PROBomFooterTable.StylePriority.UseBorders = False
        Me.PROBomFooterTable.StylePriority.UseFont = False
        Me.PROBomFooterTable.StylePriority.UseTextAlignment = False
        Me.PROBomFooterTable.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.ProPrepBOMFGPicture, Me.ProPrepBOMFGf12cRawMaterialDesc_v50, Me.ProPrepBOMFGf06cSize_v50, Me.ProPrepBOMFGNote})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.0R
        '
        'ProPrepBOMFGPicture
        '
        Me.ProPrepBOMFGPicture.Multiline = True
        Me.ProPrepBOMFGPicture.Name = "ProPrepBOMFGPicture"
        Me.ProPrepBOMFGPicture.Weight = 0.96653827092097355R
        '
        'ProPrepBOMFGf12cRawMaterialDesc_v50
        '
        Me.ProPrepBOMFGf12cRawMaterialDesc_v50.Multiline = True
        Me.ProPrepBOMFGf12cRawMaterialDesc_v50.Name = "ProPrepBOMFGf12cRawMaterialDesc_v50"
        Me.ProPrepBOMFGf12cRawMaterialDesc_v50.Weight = 1.293296866989498R
        '
        'ProPrepBOMFGf06cSize_v50
        '
        Me.ProPrepBOMFGf06cSize_v50.Multiline = True
        Me.ProPrepBOMFGf06cSize_v50.Name = "ProPrepBOMFGf06cSize_v50"
        Me.ProPrepBOMFGf06cSize_v50.Weight = 1.1921431569910004R
        '
        'ProPrepBOMFGNote
        '
        Me.ProPrepBOMFGNote.Multiline = True
        Me.ProPrepBOMFGNote.Name = "ProPrepBOMFGNote"
        Me.ProPrepBOMFGNote.Weight = 1.901867858944682R
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.ProPrepBomFGHeaderTable})
        Me.PageHeader.HeightF = 67.54168!
        Me.PageHeader.Name = "PageHeader"
        '
        'ProPrepBomFGHeaderTable
        '
        Me.ProPrepBomFGHeaderTable.BackColor = System.Drawing.Color.Transparent
        Me.ProPrepBomFGHeaderTable.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.ProPrepBomFGHeaderTable.Font = New DevExpress.Drawing.DXFont("Calibri", 6.75!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.ProPrepBomFGHeaderTable.LocationFloat = New DevExpress.Utils.PointFloat(0!, 7.541679!)
        Me.ProPrepBomFGHeaderTable.Name = "ProPrepBomFGHeaderTable"
        Me.ProPrepBomFGHeaderTable.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.ProPrepBomFGHeaderTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3, Me.XrTableRow1})
        Me.ProPrepBomFGHeaderTable.SizeF = New System.Drawing.SizeF(480.0!, 60.0!)
        Me.ProPrepBomFGHeaderTable.StylePriority.UseBackColor = False
        Me.ProPrepBomFGHeaderTable.StylePriority.UseBorders = False
        Me.ProPrepBomFGHeaderTable.StylePriority.UseFont = False
        Me.ProPrepBomFGHeaderTable.StylePriority.UseTextAlignment = False
        Me.ProPrepBomFGHeaderTable.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell16})
        Me.XrTableRow3.Font = New DevExpress.Drawing.DXFont("Calibri", 8.25!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.StylePriority.UseFont = False
        Me.XrTableRow3.Weight = 0.5R
        '
        'XrTableCell16
        '
        Me.XrTableCell16.Multiline = True
        Me.XrTableCell16.Name = "XrTableCell16"
        Me.XrTableCell16.Text = "BILL OFF MATERIAL (FINISHED GOOD)"
        Me.XrTableCell16.Weight = 5.3538461538461544R
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell4})
        Me.XrTableRow1.Font = New DevExpress.Drawing.DXFont("Calibri", 8.25!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.StylePriority.UseFont = False
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Multiline = True
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Text = "PICTURE"
        Me.XrTableCell1.Weight = 0.96653835261418264R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Multiline = True
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Text = "MATERIAL"
        Me.XrTableCell2.Weight = 1.2932968669894982R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Multiline = True
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Text = "SIZE"
        Me.XrTableCell3.Weight = 1.1921431365676982R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Multiline = True
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Text = "NOTE"
        Me.XrTableCell4.Weight = 1.9018677976747755R
        '
        'PROPreparationReportBomFG
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail, Me.PageHeader})
        Me.Font = New DevExpress.Drawing.DXFont("Arial", 9.75!)
        Me.Margins = New DevExpress.Drawing.DXMargins(0, 370, 2, 1)
        Me.Version = "19.2"
        CType(Me.PROBomFooterTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProPrepBomFGHeaderTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents ProPrepBomFGHeaderTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents PROBomFooterTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents ProPrepBOMFGPicture As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ProPrepBOMFGf12cRawMaterialDesc_v50 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ProPrepBOMFGf06cSize_v50 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ProPrepBOMFGNote As DevExpress.XtraReports.UI.XRTableCell
End Class
