<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class PROReportFCP
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
        Me.PROFcFooterTable = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.ProFCPictures = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.ProFCf01cItemFindingComponentDesc_v50 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ProFCf02nPcs_int = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ProFCf03nBerat_n92 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ProFCf09cNotes_v50 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.PROFcHeaderTable = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        CType(Me.PROFcFooterTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROFcHeaderTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 0!
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 2.147929!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.PROFcFooterTable})
        Me.Detail.HeightF = 20.03716!
        Me.Detail.Name = "Detail"
        '
        'PROFcFooterTable
        '
        Me.PROFcFooterTable.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.PROFcFooterTable.Font = New DevExpress.Drawing.DXFont("Calibri", 6.75!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.PROFcFooterTable.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.PROFcFooterTable.Name = "PROFcFooterTable"
        Me.PROFcFooterTable.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.PROFcFooterTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.PROFcFooterTable.SizeF = New System.Drawing.SizeF(275.0!, 20.0!)
        Me.PROFcFooterTable.StylePriority.UseBorders = False
        Me.PROFcFooterTable.StylePriority.UseFont = False
        Me.PROFcFooterTable.StylePriority.UseTextAlignment = False
        Me.PROFcFooterTable.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.ProFCPictures, Me.ProFCf01cItemFindingComponentDesc_v50, Me.ProFCf02nPcs_int, Me.ProFCf03nBerat_n92, Me.ProFCf09cNotes_v50})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.0R
        '
        'ProFCPictures
        '
        Me.ProFCPictures.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.ProFCPictures.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPictureBox1})
        Me.ProFCPictures.Multiline = True
        Me.ProFCPictures.Name = "ProFCPictures"
        Me.ProFCPictures.StylePriority.UseBorders = False
        Me.ProFCPictures.Weight = 0.91476923076923078R
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0.00001525879!, 0!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(83.0691!, 19.99999!)
        '
        'ProFCf01cItemFindingComponentDesc_v50
        '
        Me.ProFCf01cItemFindingComponentDesc_v50.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.ProFCf01cItemFindingComponentDesc_v50.Multiline = True
        Me.ProFCf01cItemFindingComponentDesc_v50.Name = "ProFCf01cItemFindingComponentDesc_v50"
        Me.ProFCf01cItemFindingComponentDesc_v50.StylePriority.UseBorders = False
        Me.ProFCf01cItemFindingComponentDesc_v50.Weight = 0.65999996009239781R
        '
        'ProFCf02nPcs_int
        '
        Me.ProFCf02nPcs_int.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.ProFCf02nPcs_int.Multiline = True
        Me.ProFCf02nPcs_int.Name = "ProFCf02nPcs_int"
        Me.ProFCf02nPcs_int.StylePriority.UseBorders = False
        Me.ProFCf02nPcs_int.Weight = 0.38246105957031251R
        '
        'ProFCf03nBerat_n92
        '
        Me.ProFCf03nBerat_n92.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.ProFCf03nBerat_n92.Multiline = True
        Me.ProFCf03nBerat_n92.Name = "ProFCf03nBerat_n92"
        Me.ProFCf03nBerat_n92.StylePriority.UseBorders = False
        Me.ProFCf03nBerat_n92.Weight = 0.44276974956805937R
        '
        'ProFCf09cNotes_v50
        '
        Me.ProFCf09cNotes_v50.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.ProFCf09cNotes_v50.Multiline = True
        Me.ProFCf09cNotes_v50.Name = "ProFCf09cNotes_v50"
        Me.ProFCf09cNotes_v50.StylePriority.UseBorders = False
        Me.ProFCf09cNotes_v50.Weight = 0.62834008097166039R
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.PROFcHeaderTable})
        Me.PageHeader.HeightF = 40.0!
        Me.PageHeader.Name = "PageHeader"
        '
        'PROFcHeaderTable
        '
        Me.PROFcHeaderTable.BackColor = System.Drawing.Color.Transparent
        Me.PROFcHeaderTable.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.PROFcHeaderTable.Font = New DevExpress.Drawing.DXFont("Calibri", 6.75!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.PROFcHeaderTable.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.PROFcHeaderTable.Name = "PROFcHeaderTable"
        Me.PROFcHeaderTable.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.PROFcHeaderTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3, Me.XrTableRow1})
        Me.PROFcHeaderTable.SizeF = New System.Drawing.SizeF(275.0!, 40.0!)
        Me.PROFcHeaderTable.StylePriority.UseBackColor = False
        Me.PROFcHeaderTable.StylePriority.UseBorders = False
        Me.PROFcHeaderTable.StylePriority.UseFont = False
        Me.PROFcHeaderTable.StylePriority.UseTextAlignment = False
        Me.PROFcHeaderTable.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow3
        '
        Me.XrTableRow3.BackColor = System.Drawing.Color.LightGray
        Me.XrTableRow3.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell2})
        Me.XrTableRow3.Font = New DevExpress.Drawing.DXFont("Calibri", 8.25!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.StylePriority.UseBackColor = False
        Me.XrTableRow3.StylePriority.UseBorders = False
        Me.XrTableRow3.StylePriority.UseFont = False
        Me.XrTableRow3.Weight = 1.0R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell2.Multiline = True
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.StylePriority.UseBorders = False
        Me.XrTableCell2.Text = "FINDING & COMPONENT"
        Me.XrTableCell2.Weight = 3.028340080971661R
        '
        'XrTableRow1
        '
        Me.XrTableRow1.BackColor = System.Drawing.Color.LightGray
        Me.XrTableRow1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell3, Me.XrTableCell4, Me.XrTableCell5, Me.XrTableCell6})
        Me.XrTableRow1.Font = New DevExpress.Drawing.DXFont("Calibri", 8.25!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.StylePriority.UseBackColor = False
        Me.XrTableRow1.StylePriority.UseBorders = False
        Me.XrTableRow1.StylePriority.UseFont = False
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell1.Multiline = True
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.StylePriority.UseBorders = False
        Me.XrTableCell1.Text = "PICTURE"
        Me.XrTableCell1.Weight = 0.91476915095402644R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell3.Multiline = True
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.StylePriority.UseBorders = False
        Me.XrTableCell3.Text = "MATERIAL"
        Me.XrTableCell3.Weight = 0.66000003990760214R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell4.Multiline = True
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.StylePriority.UseBorders = False
        Me.XrTableCell4.Text = "PCS"
        Me.XrTableCell4.Weight = 0.38246153846153852R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell5.Multiline = True
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.StylePriority.UseBorders = False
        Me.XrTableCell5.Text = "GRAM"
        Me.XrTableCell5.Weight = 0.44276927067683336R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell6.Multiline = True
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.StylePriority.UseBorders = False
        Me.XrTableCell6.Text = "NOTES"
        Me.XrTableCell6.Weight = 0.62834008097166039R
        '
        'PROReportFCP
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail, Me.PageHeader})
        Me.Font = New DevExpress.Drawing.DXFont("Arial", 9.75!)
        Me.Margins = New DevExpress.Drawing.DXMargins(0, 550, 0, 2)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4
        Me.Version = "19.2"
        CType(Me.PROFcFooterTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROFcHeaderTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PROFcFooterTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents ProFCPictures As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ProFCf01cItemFindingComponentDesc_v50 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ProFCf02nPcs_int As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ProFCf03nBerat_n92 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ProFCf09cNotes_v50 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PROFcHeaderTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
End Class
