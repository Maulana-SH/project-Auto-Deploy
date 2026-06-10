<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class PROPreparationReportBomPreparation
    Inherits DevExpress.XtraReports.UI.XtraReport

    'XtraReport overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.PROBomFooterTable = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.ProPreparationBOMf12cRawMaterialDesc_v50 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ProPreparationBOMf06cSize_v50 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ProPreparationBOMf25cNotes_v250 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.ProPrepBomHeaderTable = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        CType(Me.PROBomFooterTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProPrepBomHeaderTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 0!
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 0.7637872!
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
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.ProPreparationBOMf12cRawMaterialDesc_v50, Me.ProPreparationBOMf06cSize_v50, Me.ProPreparationBOMf25cNotes_v250})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.0R
        '
        'ProPreparationBOMf12cRawMaterialDesc_v50
        '
        Me.ProPreparationBOMf12cRawMaterialDesc_v50.Multiline = True
        Me.ProPreparationBOMf12cRawMaterialDesc_v50.Name = "ProPreparationBOMf12cRawMaterialDesc_v50"
        Me.ProPreparationBOMf12cRawMaterialDesc_v50.Weight = 2.5619184475164674R
        '
        'ProPreparationBOMf06cSize_v50
        '
        Me.ProPreparationBOMf06cSize_v50.Multiline = True
        Me.ProPreparationBOMf06cSize_v50.Name = "ProPreparationBOMf06cSize_v50"
        Me.ProPreparationBOMf06cSize_v50.Weight = 0.63445093114148288R
        '
        'ProPreparationBOMf25cNotes_v250
        '
        Me.ProPreparationBOMf25cNotes_v250.Multiline = True
        Me.ProPreparationBOMf25cNotes_v250.Name = "ProPreparationBOMf25cNotes_v250"
        Me.ProPreparationBOMf25cNotes_v250.Weight = 2.1574768064295142R
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.ProPrepBomHeaderTable})
        Me.PageHeader.HeightF = 60.0!
        Me.PageHeader.Name = "PageHeader"
        '
        'ProPrepBomHeaderTable
        '
        Me.ProPrepBomHeaderTable.BackColor = System.Drawing.Color.Transparent
        Me.ProPrepBomHeaderTable.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.ProPrepBomHeaderTable.Font = New DevExpress.Drawing.DXFont("Calibri", 6.75!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.ProPrepBomHeaderTable.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.ProPrepBomHeaderTable.Name = "ProPrepBomHeaderTable"
        Me.ProPrepBomHeaderTable.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.ProPrepBomHeaderTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3, Me.XrTableRow1})
        Me.ProPrepBomHeaderTable.SizeF = New System.Drawing.SizeF(480.0!, 60.0!)
        Me.ProPrepBomHeaderTable.StylePriority.UseBackColor = False
        Me.ProPrepBomHeaderTable.StylePriority.UseBorders = False
        Me.ProPrepBomHeaderTable.StylePriority.UseFont = False
        Me.ProPrepBomHeaderTable.StylePriority.UseTextAlignment = False
        Me.ProPrepBomHeaderTable.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
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
        Me.XrTableCell16.Text = "BILL OFF MATERIAL  (PREPARATION)"
        Me.XrTableCell16.Weight = 5.3538461538461544R
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell4})
        Me.XrTableRow1.Font = New DevExpress.Drawing.DXFont("Calibri", 8.25!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.StylePriority.UseFont = False
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Multiline = True
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Text = "MATERIAL"
        Me.XrTableCell2.Weight = 2.5619184962056192R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Multiline = True
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Text = "QTY"
        Me.XrTableCell3.Weight = 0.63445091397248343R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Multiline = True
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Text = "NOTE"
        Me.XrTableCell4.Weight = 2.1574767436680524R
        '
        'PROPreparationReportBomPreparation
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail, Me.PageHeader})
        Me.Font = New DevExpress.Drawing.DXFont("Arial", 9.75!)
        Me.Margins = New DevExpress.Drawing.DXMargins(1, 345, 0, 1)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4
        Me.Version = "19.2"
        CType(Me.PROBomFooterTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProPrepBomHeaderTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents ProPrepBomHeaderTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents PROBomFooterTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents ProPreparationBOMf12cRawMaterialDesc_v50 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ProPreparationBOMf06cSize_v50 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ProPreparationBOMf25cNotes_v250 As DevExpress.XtraReports.UI.XRTableCell
End Class
