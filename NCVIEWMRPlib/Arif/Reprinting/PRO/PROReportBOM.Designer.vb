<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class PROReportBOM
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
        Me.ProBOMPicture = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrPictureBox1 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.ProBOMk02cKodeRubber_v50 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ProBOMf01cItemCastedPartsDesc_v50 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ProBOMf02nPcs_int = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ProBOMf03nBerat_n92 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ProBOMf05cAssemblyDesc_v50 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ProBOMf08cPlatingDesc_v50 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ProBOMf06cPerintahFinishing_v50 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.PROBomHeaderTable = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell5 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell6 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell7 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell8 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.SubReportProFC = New DevExpress.XtraReports.UI.XRSubreport()
        Me.SubReportProStones = New DevExpress.XtraReports.UI.XRSubreport()
        CType(Me.PROBomFooterTable, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PROBomHeaderTable, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.Detail.HeightF = 20.0!
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
        Me.PROBomFooterTable.SizeF = New System.Drawing.SizeF(495.0!, 20.0!)
        Me.PROBomFooterTable.StylePriority.UseBorders = False
        Me.PROBomFooterTable.StylePriority.UseFont = False
        Me.PROBomFooterTable.StylePriority.UseTextAlignment = False
        Me.PROBomFooterTable.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.ProBOMPicture, Me.ProBOMk02cKodeRubber_v50, Me.ProBOMf01cItemCastedPartsDesc_v50, Me.ProBOMf02nPcs_int, Me.ProBOMf03nBerat_n92, Me.ProBOMf05cAssemblyDesc_v50, Me.ProBOMf08cPlatingDesc_v50, Me.ProBOMf06cPerintahFinishing_v50})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.0R
        '
        'ProBOMPicture
        '
        Me.ProBOMPicture.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPictureBox1})
        Me.ProBOMPicture.Multiline = True
        Me.ProBOMPicture.Name = "ProBOMPicture"
        Me.ProBOMPicture.Weight = 0.96653827092097355R
        '
        'XrPictureBox1
        '
        Me.XrPictureBox1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrPictureBox1.Name = "XrPictureBox1"
        Me.XrPictureBox1.SizeF = New System.Drawing.SizeF(89.36314!, 19.99999!)
        '
        'ProBOMk02cKodeRubber_v50
        '
        Me.ProBOMk02cKodeRubber_v50.Multiline = True
        Me.ProBOMk02cKodeRubber_v50.Name = "ProBOMk02cKodeRubber_v50"
        Me.ProBOMk02cKodeRubber_v50.Weight = 0.70576925800030044R
        '
        'ProBOMf01cItemCastedPartsDesc_v50
        '
        Me.ProBOMf01cItemCastedPartsDesc_v50.Multiline = True
        Me.ProBOMf01cItemCastedPartsDesc_v50.Name = "ProBOMf01cItemCastedPartsDesc_v50"
        Me.ProBOMf01cItemCastedPartsDesc_v50.Weight = 0.604615548001803R
        '
        'ProBOMf02nPcs_int
        '
        Me.ProBOMf02nPcs_int.Multiline = True
        Me.ProBOMf02nPcs_int.Name = "ProBOMf02nPcs_int"
        Me.ProBOMf02nPcs_int.Weight = 0.38076925800030048R
        '
        'ProBOMf03nBerat_n92
        '
        Me.ProBOMf03nBerat_n92.Multiline = True
        Me.ProBOMf03nBerat_n92.Name = "ProBOMf03nBerat_n92"
        Me.ProBOMf03nBerat_n92.Weight = 0.58192356708233217R
        '
        'ProBOMf05cAssemblyDesc_v50
        '
        Me.ProBOMf05cAssemblyDesc_v50.Multiline = True
        Me.ProBOMf05cAssemblyDesc_v50.Name = "ProBOMf05cAssemblyDesc_v50"
        Me.ProBOMf05cAssemblyDesc_v50.Weight = 0.7607686861478371R
        '
        'ProBOMf08cPlatingDesc_v50
        '
        Me.ProBOMf08cPlatingDesc_v50.Multiline = True
        Me.ProBOMf08cPlatingDesc_v50.Name = "ProBOMf08cPlatingDesc_v50"
        Me.ProBOMf08cPlatingDesc_v50.Weight = 0.73807695030799236R
        '
        'ProBOMf06cPerintahFinishing_v50
        '
        Me.ProBOMf06cPerintahFinishing_v50.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.ProBOMf06cPerintahFinishing_v50.Multiline = True
        Me.ProBOMf06cPerintahFinishing_v50.Name = "ProBOMf06cPerintahFinishing_v50"
        Me.ProBOMf06cPerintahFinishing_v50.StylePriority.UseBorders = False
        Me.ProBOMf06cPerintahFinishing_v50.Weight = 0.61538461538461542R
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.PROBomHeaderTable})
        Me.PageHeader.HeightF = 60.0!
        Me.PageHeader.Name = "PageHeader"
        '
        'PROBomHeaderTable
        '
        Me.PROBomHeaderTable.BackColor = System.Drawing.Color.Transparent
        Me.PROBomHeaderTable.Borders = CType(((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.PROBomHeaderTable.Font = New DevExpress.Drawing.DXFont("Calibri", 6.75!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.PROBomHeaderTable.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.PROBomHeaderTable.Name = "PROBomHeaderTable"
        Me.PROBomHeaderTable.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.PROBomHeaderTable.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3, Me.XrTableRow1})
        Me.PROBomHeaderTable.SizeF = New System.Drawing.SizeF(495.0!, 60.0!)
        Me.PROBomHeaderTable.StylePriority.UseBackColor = False
        Me.PROBomHeaderTable.StylePriority.UseBorders = False
        Me.PROBomHeaderTable.StylePriority.UseFont = False
        Me.PROBomHeaderTable.StylePriority.UseTextAlignment = False
        Me.PROBomHeaderTable.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow3
        '
        Me.XrTableRow3.BackColor = System.Drawing.Color.LightGray
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell16})
        Me.XrTableRow3.Font = New DevExpress.Drawing.DXFont("Calibri", 8.25!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.StylePriority.UseBackColor = False
        Me.XrTableRow3.StylePriority.UseFont = False
        Me.XrTableRow3.Weight = 0.5R
        '
        'XrTableCell16
        '
        Me.XrTableCell16.Multiline = True
        Me.XrTableCell16.Name = "XrTableCell16"
        Me.XrTableCell16.Text = "BILL OF MATERIAL"
        Me.XrTableCell16.Weight = 5.3538461538461544R
        '
        'XrTableRow1
        '
        Me.XrTableRow1.BackColor = System.Drawing.Color.LightGray
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1, Me.XrTableCell2, Me.XrTableCell3, Me.XrTableCell4, Me.XrTableCell5, Me.XrTableCell6, Me.XrTableCell7, Me.XrTableCell8})
        Me.XrTableRow1.Font = New DevExpress.Drawing.DXFont("Calibri", 8.25!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.StylePriority.UseBackColor = False
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
        Me.XrTableCell2.Text = "RUBBER CODE"
        Me.XrTableCell2.Weight = 0.70576925800030055R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Multiline = True
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Text = "MATERIAL"
        Me.XrTableCell3.Weight = 0.60461552757850068R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Multiline = True
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.Text = "QTY"
        Me.XrTableCell4.Weight = 0.3807692784236027R
        '
        'XrTableCell5
        '
        Me.XrTableCell5.Multiline = True
        Me.XrTableCell5.Name = "XrTableCell5"
        Me.XrTableCell5.Text = "WEIGHT"
        Me.XrTableCell5.Weight = 0.5819232403094956R
        '
        'XrTableCell6
        '
        Me.XrTableCell6.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell6.Multiline = True
        Me.XrTableCell6.Name = "XrTableCell6"
        Me.XrTableCell6.StylePriority.UseBorders = False
        Me.XrTableCell6.Text = "ASSEMBLY"
        Me.XrTableCell6.Weight = 0.760768686147837R
        '
        'XrTableCell7
        '
        Me.XrTableCell7.Multiline = True
        Me.XrTableCell7.Name = "XrTableCell7"
        Me.XrTableCell7.Text = "PLATING"
        Me.XrTableCell7.Weight = 0.73807719538761984R
        '
        'XrTableCell8
        '
        Me.XrTableCell8.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell8.Multiline = True
        Me.XrTableCell8.Name = "XrTableCell8"
        Me.XrTableCell8.StylePriority.UseBorders = False
        Me.XrTableCell8.Text = "FINISHING"
        Me.XrTableCell8.Weight = 0.61538461538461542R
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.SubReportProFC, Me.SubReportProStones})
        Me.ReportFooter.HeightF = 38.05555!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'SubReportProFC
        '
        Me.SubReportProFC.LocationFloat = New DevExpress.Utils.PointFloat(0!, 7.585419!)
        Me.SubReportProFC.Name = "SubReportProFC"
        Me.SubReportProFC.SizeF = New System.Drawing.SizeF(281.7476!, 30.47013!)
        '
        'SubReportProStones
        '
        Me.SubReportProStones.LocationFloat = New DevExpress.Utils.PointFloat(281.7476!, 7.585419!)
        Me.SubReportProStones.Name = "SubReportProStones"
        Me.SubReportProStones.SizeF = New System.Drawing.SizeF(219.7915!, 30.47013!)
        '
        'PROReportBOM
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail, Me.PageHeader, Me.ReportFooter})
        Me.Font = New DevExpress.Drawing.DXFont("Arial", 9.75!)
        Me.Margins = New DevExpress.Drawing.DXMargins(0, 323, 0, 0)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4
        Me.Version = "19.2"
        CType(Me.PROBomFooterTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PROBomHeaderTable, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PROBomFooterTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents ProBOMPicture As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ProBOMk02cKodeRubber_v50 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ProBOMf01cItemCastedPartsDesc_v50 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ProBOMf02nPcs_int As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ProBOMf03nBerat_n92 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ProBOMf05cAssemblyDesc_v50 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ProBOMf08cPlatingDesc_v50 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ProBOMf06cPerintahFinishing_v50 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents PROBomHeaderTable As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell5 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell6 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell7 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell8 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents SubReportProFC As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents SubReportProStones As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents XrPictureBox1 As DevExpress.XtraReports.UI.XRPictureBox
End Class
