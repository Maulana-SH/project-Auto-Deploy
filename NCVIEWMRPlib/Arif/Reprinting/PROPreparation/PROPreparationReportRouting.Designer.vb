<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class PROPreparationReportRouting
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
        Me.ProBOMNoUrut_k03nNoUrutRouting_int = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ProPrepRouting_f03cNamaProsesProduksi_v50 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ProBOMf02nPcs_int = New DevExpress.XtraReports.UI.XRTableCell()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.ProPrepRoutingHeaderTable = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        CType(Me.PROBomFooterTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProPrepRoutingHeaderTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 0!
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 0!
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
        Me.PROBomFooterTable.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.PROBomFooterTable.Font = New DevExpress.Drawing.DXFont("Calibri", 6.75!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.PROBomFooterTable.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.PROBomFooterTable.Name = "PROBomFooterTable"
        Me.PROBomFooterTable.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.PROBomFooterTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.PROBomFooterTable.SizeF = New System.Drawing.SizeF(290.0!, 28.33335!)
        Me.PROBomFooterTable.StylePriority.UseBorders = False
        Me.PROBomFooterTable.StylePriority.UseFont = False
        Me.PROBomFooterTable.StylePriority.UseTextAlignment = False
        Me.PROBomFooterTable.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.ProBOMNoUrut_k03nNoUrutRouting_int, Me.ProPrepRouting_f03cNamaProsesProduksi_v50, Me.ProBOMf02nPcs_int})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.0R
        '
        'ProBOMNoUrut_k03nNoUrutRouting_int
        '
        Me.ProBOMNoUrut_k03nNoUrutRouting_int.Multiline = True
        Me.ProBOMNoUrut_k03nNoUrutRouting_int.Name = "ProBOMNoUrut_k03nNoUrutRouting_int"
        Me.ProBOMNoUrut_k03nNoUrutRouting_int.Weight = 0.43756758918537275R
        '
        'ProPrepRouting_f03cNamaProsesProduksi_v50
        '
        Me.ProPrepRouting_f03cNamaProsesProduksi_v50.Multiline = True
        Me.ProPrepRouting_f03cNamaProsesProduksi_v50.Name = "ProPrepRouting_f03cNamaProsesProduksi_v50"
        Me.ProPrepRouting_f03cNamaProsesProduksi_v50.Weight = 2.1087991677607278R
        '
        'ProBOMf02nPcs_int
        '
        Me.ProBOMf02nPcs_int.Multiline = True
        Me.ProBOMf02nPcs_int.Name = "ProBOMf02nPcs_int"
        Me.ProBOMf02nPcs_int.Weight = 1.4029211823121415R
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.ProPrepRoutingHeaderTable})
        Me.PageHeader.HeightF = 60.0!
        Me.PageHeader.Name = "PageHeader"
        '
        'ProPrepRoutingHeaderTable
        '
        Me.ProPrepRoutingHeaderTable.BackColor = System.Drawing.Color.Transparent
        Me.ProPrepRoutingHeaderTable.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.ProPrepRoutingHeaderTable.Font = New DevExpress.Drawing.DXFont("Calibri", 6.75!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.ProPrepRoutingHeaderTable.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.ProPrepRoutingHeaderTable.Name = "ProPrepRoutingHeaderTable"
        Me.ProPrepRoutingHeaderTable.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.ProPrepRoutingHeaderTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3, Me.XrTableRow1})
        Me.ProPrepRoutingHeaderTable.SizeF = New System.Drawing.SizeF(290.0!, 60.0!)
        Me.ProPrepRoutingHeaderTable.StylePriority.UseBackColor = False
        Me.ProPrepRoutingHeaderTable.StylePriority.UseBorders = False
        Me.ProPrepRoutingHeaderTable.StylePriority.UseFont = False
        Me.ProPrepRoutingHeaderTable.StylePriority.UseTextAlignment = False
        Me.ProPrepRoutingHeaderTable.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
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
        Me.XrTableCell16.Text = "ROUTING"
        Me.XrTableCell16.Weight = 5.3538461538461544R
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell4})
        Me.XrTableRow1.Font = New DevExpress.Drawing.DXFont("Calibri", 8.25!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.StylePriority.UseBorders = False
        Me.XrTableRow1.StylePriority.UseFont = False
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Multiline = True
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.Text = "NO"
        Me.XrTableCell1.Weight = 0.59318785374067118R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Multiline = True
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Text = "MATERIAL"
        Me.XrTableCell2.Weight = 2.8587905024307076R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Multiline = True
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Text = "PENGRAJIN"
        Me.XrTableCell4.Weight = 1.9018677976747755R
        '
        'PROPreparationReportRouting
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail, Me.PageHeader})
        Me.Font = New DevExpress.Drawing.DXFont("Arial", 9.75!)
        Me.Margins = New DevExpress.Drawing.DXMargins(0, 558, 0, 0)
        Me.Version = "19.2"
        CType(Me.PROBomFooterTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProPrepRoutingHeaderTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents ProPrepRoutingHeaderTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents PROBomFooterTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents ProBOMNoUrut_k03nNoUrutRouting_int As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ProPrepRouting_f03cNamaProsesProduksi_v50 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ProBOMf02nPcs_int As DevExpress.XtraReports.UI.XRTableCell
End Class
