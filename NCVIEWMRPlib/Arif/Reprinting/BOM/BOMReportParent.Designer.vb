<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class BOMReportParent
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(BOMReportParent))
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.BOMParentTableTotalWeight = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow29 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell60 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.BOMParentTotalWeight = New DevExpress.XtraReports.UI.XRTableCell()
        Me.SubReportStones = New DevExpress.XtraReports.UI.XRSubreport()
        Me.SubReportFCP = New DevExpress.XtraReports.UI.XRSubreport()
        Me.SubReportCastedPart = New DevExpress.XtraReports.UI.XRSubreport()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.BOMHeadPicture = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrTable11 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow11 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.BOMHeadKodeFinishedGood = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow12 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell24 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.BOMHeadKodeDesign = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow14 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell27 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.BOMHeadf14cProductionTypeDesc_v50 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow13 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell25 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell26 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.BOMHeadFinishedGoodDesc = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        Me.ReportFooter = New DevExpress.XtraReports.UI.ReportFooterBand()
        Me.SubreportAproval = New DevExpress.XtraReports.UI.XRSubreport()
        Me.SubReportRouting = New DevExpress.XtraReports.UI.XRSubreport()
        Me.PLinqInstantFeedbackSource1 = New DevExpress.Data.PLinq.PLinqInstantFeedbackSource()
        CType(Me.BOMParentTableTotalWeight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable11, System.ComponentModel.ISupportInitialize).BeginInit()
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
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1, Me.XrLabel7})
        Me.BottomMargin.Dpi = 254.0!
        Me.BottomMargin.HeightF = 33.42007!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrPageInfo1.Dpi = 254.0!
        Me.XrPageInfo1.Font = New DevExpress.Drawing.DXFont("Calibri", 6.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(1810.019!, 0!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(189.9808!, 33.42007!)
        Me.XrPageInfo1.StylePriority.UseBorders = False
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.TextFormatString = "Page {0} Of {1}"
        '
        'XrLabel7
        '
        Me.XrLabel7.Dpi = 254.0!
        Me.XrLabel7.Font = New DevExpress.Drawing.DXFont("Calibri", 6.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0.00005722046!)
        Me.XrLabel7.Multiline = True
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(5, 5, 0, 0, 254.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(189.9808!, 33.42001!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.Text = "Form.20200304"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.BOMParentTableTotalWeight, Me.SubReportStones, Me.SubReportFCP, Me.SubReportCastedPart})
        Me.Detail.Dpi = 254.0!
        Me.Detail.HeightF = 331.7527!
        Me.Detail.Name = "Detail"
        '
        'BOMParentTableTotalWeight
        '
        Me.BOMParentTableTotalWeight.BackColor = System.Drawing.Color.DarkGray
        Me.BOMParentTableTotalWeight.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.BOMParentTableTotalWeight.Dpi = 254.0!
        Me.BOMParentTableTotalWeight.Font = New DevExpress.Drawing.DXFont("Calibri", 8.25!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.BOMParentTableTotalWeight.LocationFloat = New DevExpress.Utils.PointFloat(0!, 264.8541!)
        Me.BOMParentTableTotalWeight.Name = "BOMParentTableTotalWeight"
        Me.BOMParentTableTotalWeight.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.BOMParentTableTotalWeight.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow29})
        Me.BOMParentTableTotalWeight.SizeF = New System.Drawing.SizeF(1998.146!, 50.0!)
        Me.BOMParentTableTotalWeight.StylePriority.UseBackColor = False
        Me.BOMParentTableTotalWeight.StylePriority.UseBorders = False
        Me.BOMParentTableTotalWeight.StylePriority.UseFont = False
        Me.BOMParentTableTotalWeight.StylePriority.UseTextAlignment = False
        Me.BOMParentTableTotalWeight.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow29
        '
        Me.XrTableRow29.BackColor = System.Drawing.Color.Transparent
        Me.XrTableRow29.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell60, Me.BOMParentTotalWeight})
        Me.XrTableRow29.Dpi = 254.0!
        Me.XrTableRow29.Name = "XrTableRow29"
        Me.XrTableRow29.StylePriority.UseBackColor = False
        Me.XrTableRow29.Weight = 1.0R
        '
        'XrTableCell60
        '
        Me.XrTableCell60.Dpi = 254.0!
        Me.XrTableCell60.Multiline = True
        Me.XrTableCell60.Name = "XrTableCell60"
        Me.XrTableCell60.Text = "TOTAL BERAT"
        Me.XrTableCell60.Weight = 0.96934175235351572R
        '
        'BOMParentTotalWeight
        '
        Me.BOMParentTotalWeight.Dpi = 254.0!
        Me.BOMParentTotalWeight.Multiline = True
        Me.BOMParentTotalWeight.Name = "BOMParentTotalWeight"
        Me.BOMParentTotalWeight.TextFormatString = "{0:n2}"
        Me.BOMParentTotalWeight.Weight = 1.0306582476464843R
        '
        'SubReportStones
        '
        Me.SubReportStones.Dpi = 254.0!
        Me.SubReportStones.LocationFloat = New DevExpress.Utils.PointFloat(0!, 161.4549!)
        Me.SubReportStones.Name = "SubReportStones"
        Me.SubReportStones.SizeF = New System.Drawing.SizeF(1998.146!, 79.5867!)
        '
        'SubReportFCP
        '
        Me.SubReportFCP.Dpi = 254.0!
        Me.SubReportFCP.LocationFloat = New DevExpress.Utils.PointFloat(0!, 76.94088!)
        Me.SubReportFCP.Name = "SubReportFCP"
        Me.SubReportFCP.SizeF = New System.Drawing.SizeF(2000.0!, 71.64921!)
        '
        'SubReportCastedPart
        '
        Me.SubReportCastedPart.Dpi = 254.0!
        Me.SubReportCastedPart.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.SubReportCastedPart.Name = "SubReportCastedPart"
        Me.SubReportCastedPart.SizeF = New System.Drawing.SizeF(2000.0!, 63.71171!)
        '
        'PageHeader
        '
        Me.PageHeader.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.BOMHeadPicture, Me.XrTable11, Me.XrLabel1, Me.XrLine1})
        Me.PageHeader.Dpi = 254.0!
        Me.PageHeader.HeightF = 415.1241!
        Me.PageHeader.Name = "PageHeader"
        Me.PageHeader.StylePriority.UseBorders = False
        '
        'BOMHeadPicture
        '
        Me.BOMHeadPicture.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.BOMHeadPicture.Dpi = 254.0!
        Me.BOMHeadPicture.LocationFloat = New DevExpress.Utils.PointFloat(1.854296!, 0!)
        Me.BOMHeadPicture.Name = "BOMHeadPicture"
        Me.BOMHeadPicture.Padding = New DevExpress.XtraPrinting.PaddingInfo(10, 10, 10, 10, 254.0!)
        Me.BOMHeadPicture.SizeF = New System.Drawing.SizeF(766.834!, 404.9218!)
        Me.BOMHeadPicture.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        Me.BOMHeadPicture.StylePriority.UseBorders = False
        Me.BOMHeadPicture.StylePriority.UsePadding = False
        '
        'XrTable11
        '
        Me.XrTable11.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrTable11.Dpi = 254.0!
        Me.XrTable11.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTable11.LocationFloat = New DevExpress.Utils.PointFloat(1080.74!, 145.2052!)
        Me.XrTable11.Name = "XrTable11"
        Me.XrTable11.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrTable11.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow11, Me.XrTableRow12, Me.XrTableRow14, Me.XrTableRow13})
        Me.XrTable11.SizeF = New System.Drawing.SizeF(907.1339!, 194.4687!)
        Me.XrTable11.StylePriority.UseBorders = False
        Me.XrTable11.StylePriority.UseFont = False
        Me.XrTable11.StylePriority.UseTextAlignment = False
        Me.XrTable11.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrTableRow11
        '
        Me.XrTableRow11.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell21, Me.XrTableCell22, Me.BOMHeadKodeFinishedGood})
        Me.XrTableRow11.Dpi = 254.0!
        Me.XrTableRow11.Name = "XrTableRow11"
        Me.XrTableRow11.Weight = 1.0R
        '
        'XrTableCell21
        '
        Me.XrTableCell21.Dpi = 254.0!
        Me.XrTableCell21.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell21.Multiline = True
        Me.XrTableCell21.Name = "XrTableCell21"
        Me.XrTableCell21.StylePriority.UseFont = False
        Me.XrTableCell21.Text = "FG / MATERIAL CODE"
        Me.XrTableCell21.Weight = 0.63778655281641794R
        '
        'XrTableCell22
        '
        Me.XrTableCell22.Dpi = 254.0!
        Me.XrTableCell22.Font = New DevExpress.Drawing.DXFont("Calibri", 8.25!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell22.Multiline = True
        Me.XrTableCell22.Name = "XrTableCell22"
        Me.XrTableCell22.StylePriority.UseFont = False
        Me.XrTableCell22.StylePriority.UseTextAlignment = False
        Me.XrTableCell22.Text = ":"
        Me.XrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell22.Weight = 0.060413838853320377R
        '
        'BOMHeadKodeFinishedGood
        '
        Me.BOMHeadKodeFinishedGood.Dpi = 254.0!
        Me.BOMHeadKodeFinishedGood.Font = New DevExpress.Drawing.DXFont("Calibri", 8.25!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.BOMHeadKodeFinishedGood.Multiline = True
        Me.BOMHeadKodeFinishedGood.Name = "BOMHeadKodeFinishedGood"
        Me.BOMHeadKodeFinishedGood.StylePriority.UseFont = False
        Me.BOMHeadKodeFinishedGood.TextFormatString = ":"
        Me.BOMHeadKodeFinishedGood.Weight = 1.2938364431787344R
        '
        'XrTableRow12
        '
        Me.XrTableRow12.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell23, Me.XrTableCell24, Me.BOMHeadKodeDesign})
        Me.XrTableRow12.Dpi = 254.0!
        Me.XrTableRow12.Name = "XrTableRow12"
        Me.XrTableRow12.Weight = 1.0R
        '
        'XrTableCell23
        '
        Me.XrTableCell23.Dpi = 254.0!
        Me.XrTableCell23.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell23.Multiline = True
        Me.XrTableCell23.Name = "XrTableCell23"
        Me.XrTableCell23.StylePriority.UseFont = False
        Me.XrTableCell23.Text = "DESIGN CODE"
        Me.XrTableCell23.Weight = 0.63778677405851669R
        '
        'XrTableCell24
        '
        Me.XrTableCell24.Dpi = 254.0!
        Me.XrTableCell24.Font = New DevExpress.Drawing.DXFont("Calibri", 8.25!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell24.Multiline = True
        Me.XrTableCell24.Name = "XrTableCell24"
        Me.XrTableCell24.StylePriority.UseFont = False
        Me.XrTableCell24.StylePriority.UseTextAlignment = False
        Me.XrTableCell24.Text = ":"
        Me.XrTableCell24.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell24.Weight = 0.060413843462530745R
        '
        'BOMHeadKodeDesign
        '
        Me.BOMHeadKodeDesign.Dpi = 254.0!
        Me.BOMHeadKodeDesign.Font = New DevExpress.Drawing.DXFont("Calibri", 8.25!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.BOMHeadKodeDesign.Multiline = True
        Me.BOMHeadKodeDesign.Name = "BOMHeadKodeDesign"
        Me.BOMHeadKodeDesign.StylePriority.UseFont = False
        Me.BOMHeadKodeDesign.TextFormatString = ":{0}"
        Me.BOMHeadKodeDesign.Weight = 1.2938362173274252R
        '
        'XrTableRow14
        '
        Me.XrTableRow14.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell27, Me.XrTableCell28, Me.BOMHeadf14cProductionTypeDesc_v50})
        Me.XrTableRow14.Dpi = 254.0!
        Me.XrTableRow14.Name = "XrTableRow14"
        Me.XrTableRow14.Weight = 1.0R
        '
        'XrTableCell27
        '
        Me.XrTableCell27.Dpi = 254.0!
        Me.XrTableCell27.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell27.Multiline = True
        Me.XrTableCell27.Name = "XrTableCell27"
        Me.XrTableCell27.StylePriority.UseFont = False
        Me.XrTableCell27.Text = "PRODUCTION TYPE"
        Me.XrTableCell27.Weight = 0.63778669109272967R
        '
        'XrTableCell28
        '
        Me.XrTableCell28.Dpi = 254.0!
        Me.XrTableCell28.Font = New DevExpress.Drawing.DXFont("Calibri", 8.25!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell28.Multiline = True
        Me.XrTableCell28.Name = "XrTableCell28"
        Me.XrTableCell28.StylePriority.UseFont = False
        Me.XrTableCell28.StylePriority.UseTextAlignment = False
        Me.XrTableCell28.Text = ":"
        Me.XrTableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell28.Weight = 0.060413843462530779R
        '
        'BOMHeadf14cProductionTypeDesc_v50
        '
        Me.BOMHeadf14cProductionTypeDesc_v50.Dpi = 254.0!
        Me.BOMHeadf14cProductionTypeDesc_v50.Font = New DevExpress.Drawing.DXFont("Calibri", 8.25!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.BOMHeadf14cProductionTypeDesc_v50.Multiline = True
        Me.BOMHeadf14cProductionTypeDesc_v50.Name = "BOMHeadf14cProductionTypeDesc_v50"
        Me.BOMHeadf14cProductionTypeDesc_v50.StylePriority.UseFont = False
        Me.BOMHeadf14cProductionTypeDesc_v50.Weight = 1.2938363002932123R
        '
        'XrTableRow13
        '
        Me.XrTableRow13.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell25, Me.XrTableCell26, Me.BOMHeadFinishedGoodDesc})
        Me.XrTableRow13.Dpi = 254.0!
        Me.XrTableRow13.Name = "XrTableRow13"
        Me.XrTableRow13.Weight = 1.0R
        '
        'XrTableCell25
        '
        Me.XrTableCell25.Dpi = 254.0!
        Me.XrTableCell25.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell25.Multiline = True
        Me.XrTableCell25.Name = "XrTableCell25"
        Me.XrTableCell25.StylePriority.UseFont = False
        Me.XrTableCell25.StylePriority.UseTextAlignment = False
        Me.XrTableCell25.Text = "FG DESCRIPTION"
        Me.XrTableCell25.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.XrTableCell25.Weight = 0.63778669109272967R
        '
        'XrTableCell26
        '
        Me.XrTableCell26.Dpi = 254.0!
        Me.XrTableCell26.Font = New DevExpress.Drawing.DXFont("Calibri", 8.25!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell26.Multiline = True
        Me.XrTableCell26.Name = "XrTableCell26"
        Me.XrTableCell26.StylePriority.UseFont = False
        Me.XrTableCell26.StylePriority.UseTextAlignment = False
        Me.XrTableCell26.Text = ":"
        Me.XrTableCell26.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopCenter
        Me.XrTableCell26.Weight = 0.060413843462530779R
        '
        'BOMHeadFinishedGoodDesc
        '
        Me.BOMHeadFinishedGoodDesc.Dpi = 254.0!
        Me.BOMHeadFinishedGoodDesc.Font = New DevExpress.Drawing.DXFont("Calibri", 8.25!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.BOMHeadFinishedGoodDesc.Multiline = True
        Me.BOMHeadFinishedGoodDesc.Name = "BOMHeadFinishedGoodDesc"
        Me.BOMHeadFinishedGoodDesc.StylePriority.UseFont = False
        Me.BOMHeadFinishedGoodDesc.StylePriority.UseTextAlignment = False
        Me.BOMHeadFinishedGoodDesc.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        Me.BOMHeadFinishedGoodDesc.Weight = 1.2938363002932123R
        '
        'XrLabel1
        '
        Me.XrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLabel1.BorderWidth = 2.0!
        Me.XrLabel1.Dpi = 254.0!
        Me.XrLabel1.Font = New DevExpress.Drawing.DXFont("Calibri", 15.75!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(1076.886!, 58.52224!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 5, 0, 0, 254.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(910.9879!, 73.9837!)
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseBorderWidth = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.StylePriority.UsePadding = False
        Me.XrLabel1.StylePriority.UseTextAlignment = False
        Me.XrLabel1.Text = "BILL OF MATERIAL"
        Me.XrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        '
        'XrLine1
        '
        Me.XrLine1.BackColor = System.Drawing.Color.Transparent
        Me.XrLine1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrLine1.BorderWidth = 2.0!
        Me.XrLine1.Dpi = 254.0!
        Me.XrLine1.ForeColor = System.Drawing.Color.Transparent
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(1.853885!, 404.9218!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(1996.292!, 10.20224!)
        Me.XrLine1.StylePriority.UseBackColor = False
        Me.XrLine1.StylePriority.UseBorders = False
        Me.XrLine1.StylePriority.UseBorderWidth = False
        Me.XrLine1.StylePriority.UseForeColor = False
        '
        'ReportFooter
        '
        Me.ReportFooter.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.SubreportAproval, Me.SubReportRouting})
        Me.ReportFooter.Dpi = 254.0!
        Me.ReportFooter.HeightF = 752.7142!
        Me.ReportFooter.Name = "ReportFooter"
        '
        'SubreportAproval
        '
        Me.SubreportAproval.Dpi = 254.0!
        Me.SubreportAproval.LocationFloat = New DevExpress.Utils.PointFloat(0!, 17.71414!)
        Me.SubreportAproval.Name = "SubreportAproval"
        Me.SubreportAproval.SizeF = New System.Drawing.SizeF(1298.104!, 735.0!)
        '
        'SubReportRouting
        '
        Me.SubReportRouting.Dpi = 254.0!
        Me.SubReportRouting.LocationFloat = New DevExpress.Utils.PointFloat(1312.438!, 17.71414!)
        Me.SubReportRouting.Name = "SubReportRouting"
        Me.SubReportRouting.SizeF = New System.Drawing.SizeF(689.5619!, 735.0!)
        '
        'BOMReportParent
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail, Me.PageHeader, Me.ReportFooter})
        Me.ComponentStorage.AddRange(New System.ComponentModel.IComponent() {Me.PLinqInstantFeedbackSource1})
        Me.DataSource = Me.PLinqInstantFeedbackSource1
        Me.Dpi = 254.0!
        Me.Font = New DevExpress.Drawing.DXFont("Arial", 9.75!)
        Me.Margins = New DevExpress.Drawing.DXMargins(0, 98, 0, 33)
        Me.PageHeight = 2970
        Me.PageWidth = 2100
        Me.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4
        Me.ReportUnit = DevExpress.XtraReports.UI.ReportUnit.TenthsOfAMillimeter
        Me.SnapGridSize = 25.0!
        Me.Version = "19.2"
        Me.Watermark.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.Watermark.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("BOMReportParent.Watermark.ImageSource"))
        Me.Watermark.ImageTransparency = 200
        CType(Me.BOMParentTableTotalWeight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SubReportCastedPart As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents SubReportFCP As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents SubReportStones As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents ReportFooter As DevExpress.XtraReports.UI.ReportFooterBand
    Friend WithEvents XrTable11 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow11 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents BOMHeadKodeFinishedGood As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow12 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell23 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents BOMHeadKodeDesign As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow14 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell27 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents BOMHeadf14cProductionTypeDesc_v50 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents PLinqInstantFeedbackSource1 As DevExpress.Data.PLinq.PLinqInstantFeedbackSource
    Friend WithEvents XrTableCell22 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell24 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell28 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents BOMParentTableTotalWeight As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow29 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell60 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents BOMParentTotalWeight As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow13 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell25 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell26 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents BOMHeadFinishedGoodDesc As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents BOMHeadPicture As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents SubReportRouting As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents SubreportAproval As DevExpress.XtraReports.UI.XRSubreport
End Class
