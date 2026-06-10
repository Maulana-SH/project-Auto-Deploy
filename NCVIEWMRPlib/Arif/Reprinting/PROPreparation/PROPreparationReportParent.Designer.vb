<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Public Class PROPreparationReportParent
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
        Dim QrCodeGenerator1 As DevExpress.XtraPrinting.BarCode.QRCodeGenerator = New DevExpress.XtraPrinting.BarCode.QRCodeGenerator()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PROPreparationReportParent))
        Me.TopMargin = New DevExpress.XtraReports.UI.TopMarginBand()
        Me.BottomMargin = New DevExpress.XtraReports.UI.BottomMarginBand()
        Me.XrPageInfo1 = New DevExpress.XtraReports.UI.XRPageInfo()
        Me.XrLabel7 = New DevExpress.XtraReports.UI.XRLabel()
        Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
        Me.SubReportPROPreparationIMG = New DevExpress.XtraReports.UI.XRSubreport()
        Me.SubReportRouting = New DevExpress.XtraReports.UI.XRSubreport()
        Me.SubReportBOMPreparation = New DevExpress.XtraReports.UI.XRSubreport()
        Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
        Me.XrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
        Me.ProHeadf25cNotes_v250 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrTable3 = New DevExpress.XtraReports.UI.XRTable()
        Me.ProPrepParentHeaderTable = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell33 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell34 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell35 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell36 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell2 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell39 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow9 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.ProHeadf19cItemBRJDesc_v50 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ProHEadf21cWarnaFGDesc_v50 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ProHEadf23cKadarDesc_v50 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ProHeadf04nBerat_n92 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ProHead_f03nLot_int = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ProHeadf24cSize_v50 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTable2 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow3 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell3 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell4 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ProHeadk02cKodeMaterialOrFG_v50 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow4 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell9 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell10 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ProHeadf02MaterialOrFGDesc_v50 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow5 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell15 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell16 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ProHeadf07cOrderStatusDesc_v50 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow6 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell21 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell22 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ProHeadf08dOrderDate = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow7 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell27 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ProHeadf09dDeliveryDate = New DevExpress.XtraReports.UI.XRTableCell()
        Me.LnHeader = New DevExpress.XtraReports.UI.XRLine()
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow1 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell1 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.ProPrepHeadk01cNoPRO_v50 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ProPrepHeadQRcode = New DevExpress.XtraReports.UI.XRBarCode()
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 0!
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPageInfo1, Me.XrLabel7})
        Me.BottomMargin.HeightF = 13.15751!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'XrPageInfo1
        '
        Me.XrPageInfo1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrPageInfo1.Font = New DevExpress.Drawing.DXFont("Calibri", 6.75!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrPageInfo1.LocationFloat = New DevExpress.Utils.PointFloat(702.2044!, 0!)
        Me.XrPageInfo1.Name = "XrPageInfo1"
        Me.XrPageInfo1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrPageInfo1.SizeF = New System.Drawing.SizeF(74.79561!, 13.15751!)
        Me.XrPageInfo1.StylePriority.UseBorders = False
        Me.XrPageInfo1.StylePriority.UseFont = False
        Me.XrPageInfo1.TextFormatString = "Page {0} Of {1}"
        '
        'XrLabel7
        '
        Me.XrLabel7.Font = New DevExpress.Drawing.DXFont("Calibri", 6.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel7.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0.00002252774!)
        Me.XrLabel7.Multiline = True
        Me.XrLabel7.Name = "XrLabel7"
        Me.XrLabel7.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel7.SizeF = New System.Drawing.SizeF(74.79559!, 13.15748!)
        Me.XrLabel7.StylePriority.UseFont = False
        Me.XrLabel7.Text = "Form.20200318"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.SubReportPROPreparationIMG, Me.SubReportRouting, Me.SubReportBOMPreparation})
        Me.Detail.HeightF = 101.5468!
        Me.Detail.Name = "Detail"
        '
        'SubReportPROPreparationIMG
        '
        Me.SubReportPROPreparationIMG.LocationFloat = New DevExpress.Utils.PointFloat(0!, 57.71345!)
        Me.SubReportPROPreparationIMG.Name = "SubReportPROPreparationIMG"
        Me.SubReportPROPreparationIMG.SizeF = New System.Drawing.SizeF(777.0!, 43.83333!)
        '
        'SubReportRouting
        '
        Me.SubReportRouting.LocationFloat = New DevExpress.Utils.PointFloat(486.4271!, 0.00003178914!)
        Me.SubReportRouting.Name = "SubReportRouting"
        Me.SubReportRouting.SizeF = New System.Drawing.SizeF(290.573!, 53.03022!)
        '
        'SubReportBOMPreparation
        '
        Me.SubReportBOMPreparation.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.SubReportBOMPreparation.Name = "SubReportBOMPreparation"
        Me.SubReportBOMPreparation.SizeF = New System.Drawing.SizeF(486.4271!, 53.03027!)
        '
        'PageHeader
        '
        Me.PageHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLabel1, Me.ProHeadf25cNotes_v250, Me.XrTable3, Me.XrTable2, Me.LnHeader, Me.XrTable1, Me.ProPrepHeadQRcode})
        Me.PageHeader.HeightF = 307.6704!
        Me.PageHeader.Name = "PageHeader"
        '
        'XrLabel1
        '
        Me.XrLabel1.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel1.Font = New DevExpress.Drawing.DXFont("Calibri", 8.25!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 262.4193!)
        Me.XrLabel1.Multiline = True
        Me.XrLabel1.Name = "XrLabel1"
        Me.XrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel1.SizeF = New System.Drawing.SizeF(39.49685!, 13.00536!)
        Me.XrLabel1.StylePriority.UseBorders = False
        Me.XrLabel1.StylePriority.UseFont = False
        Me.XrLabel1.Text = "Notes:"
        '
        'ProHeadf25cNotes_v250
        '
        Me.ProHeadf25cNotes_v250.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.ProHeadf25cNotes_v250.Font = New DevExpress.Drawing.DXFont("Calibri", 6.75!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.ProHeadf25cNotes_v250.LocationFloat = New DevExpress.Utils.PointFloat(0.00003973643!, 275.4247!)
        Me.ProHeadf25cNotes_v250.Multiline = True
        Me.ProHeadf25cNotes_v250.Name = "ProHeadf25cNotes_v250"
        Me.ProHeadf25cNotes_v250.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 4, 4, 100.0!)
        Me.ProHeadf25cNotes_v250.SizeF = New System.Drawing.SizeF(777.0!, 22.24582!)
        Me.ProHeadf25cNotes_v250.StylePriority.UseBorders = False
        Me.ProHeadf25cNotes_v250.StylePriority.UseFont = False
        Me.ProHeadf25cNotes_v250.StylePriority.UsePadding = False
        Me.ProHeadf25cNotes_v250.Text = "Notes:"
        '
        'XrTable3
        '
        Me.XrTable3.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable3.Font = New DevExpress.Drawing.DXFont("Calibri", 9.75!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTable3.LocationFloat = New DevExpress.Utils.PointFloat(0.000007947286!, 207.8672!)
        Me.XrTable3.Name = "XrTable3"
        Me.XrTable3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTable3.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.ProPrepParentHeaderTable, Me.XrTableRow9})
        Me.XrTable3.SizeF = New System.Drawing.SizeF(777.0001!, 43.30708!)
        Me.XrTable3.StylePriority.UseBorders = False
        Me.XrTable3.StylePriority.UseFont = False
        Me.XrTable3.StylePriority.UseTextAlignment = False
        Me.XrTable3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'ProPrepParentHeaderTable
        '
        Me.ProPrepParentHeaderTable.BackColor = System.Drawing.Color.Transparent
        Me.ProPrepParentHeaderTable.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell33, Me.XrTableCell34, Me.XrTableCell35, Me.XrTableCell36, Me.XrTableCell2, Me.XrTableCell39})
        Me.ProPrepParentHeaderTable.Font = New DevExpress.Drawing.DXFont("Calibri", 8.25!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.ProPrepParentHeaderTable.Name = "ProPrepParentHeaderTable"
        Me.ProPrepParentHeaderTable.StylePriority.UseBackColor = False
        Me.ProPrepParentHeaderTable.StylePriority.UseFont = False
        Me.ProPrepParentHeaderTable.Weight = 0.86614173228346458R
        '
        'XrTableCell33
        '
        Me.XrTableCell33.Multiline = True
        Me.XrTableCell33.Name = "XrTableCell33"
        Me.XrTableCell33.Text = "ITEM" & Global.Microsoft.VisualBasic.ChrW(9)
        Me.XrTableCell33.Weight = 1.5466169356952744R
        '
        'XrTableCell34
        '
        Me.XrTableCell34.Multiline = True
        Me.XrTableCell34.Name = "XrTableCell34"
        Me.XrTableCell34.Text = "FG COLOR"
        Me.XrTableCell34.Weight = 1.6664223963274023R
        '
        'XrTableCell35
        '
        Me.XrTableCell35.Multiline = True
        Me.XrTableCell35.Name = "XrTableCell35"
        Me.XrTableCell35.Text = "KADAR"
        Me.XrTableCell35.Weight = 1.017770952731301R
        '
        'XrTableCell36
        '
        Me.XrTableCell36.Multiline = True
        Me.XrTableCell36.Name = "XrTableCell36"
        Me.XrTableCell36.Text = "GRAM"
        Me.XrTableCell36.Weight = 1.240644753427204R
        '
        'XrTableCell2
        '
        Me.XrTableCell2.Multiline = True
        Me.XrTableCell2.Name = "XrTableCell2"
        Me.XrTableCell2.Text = "LOT"
        Me.XrTableCell2.Weight = 0.92907007045283518R
        '
        'XrTableCell39
        '
        Me.XrTableCell39.Multiline = True
        Me.XrTableCell39.Name = "XrTableCell39"
        Me.XrTableCell39.Text = "SIZE"
        Me.XrTableCell39.Weight = 1.7067844915085146R
        '
        'XrTableRow9
        '
        Me.XrTableRow9.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.ProHeadf19cItemBRJDesc_v50, Me.ProHEadf21cWarnaFGDesc_v50, Me.ProHEadf23cKadarDesc_v50, Me.ProHeadf04nBerat_n92, Me.ProHead_f03nLot_int, Me.ProHeadf24cSize_v50})
        Me.XrTableRow9.Font = New DevExpress.Drawing.DXFont("Calibri", 6.75!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableRow9.Name = "XrTableRow9"
        Me.XrTableRow9.StylePriority.UseFont = False
        Me.XrTableRow9.Weight = 0.86614173228346458R
        '
        'ProHeadf19cItemBRJDesc_v50
        '
        Me.ProHeadf19cItemBRJDesc_v50.Multiline = True
        Me.ProHeadf19cItemBRJDesc_v50.Name = "ProHeadf19cItemBRJDesc_v50"
        Me.ProHeadf19cItemBRJDesc_v50.Weight = 1.5466169356952744R
        '
        'ProHEadf21cWarnaFGDesc_v50
        '
        Me.ProHEadf21cWarnaFGDesc_v50.Multiline = True
        Me.ProHEadf21cWarnaFGDesc_v50.Name = "ProHEadf21cWarnaFGDesc_v50"
        Me.ProHEadf21cWarnaFGDesc_v50.Weight = 1.6664223963274023R
        '
        'ProHEadf23cKadarDesc_v50
        '
        Me.ProHEadf23cKadarDesc_v50.Multiline = True
        Me.ProHEadf23cKadarDesc_v50.Name = "ProHEadf23cKadarDesc_v50"
        Me.ProHEadf23cKadarDesc_v50.Weight = 1.017770952731301R
        '
        'ProHeadf04nBerat_n92
        '
        Me.ProHeadf04nBerat_n92.Multiline = True
        Me.ProHeadf04nBerat_n92.Name = "ProHeadf04nBerat_n92"
        Me.ProHeadf04nBerat_n92.Weight = 1.240644753427204R
        '
        'ProHead_f03nLot_int
        '
        Me.ProHead_f03nLot_int.Multiline = True
        Me.ProHead_f03nLot_int.Name = "ProHead_f03nLot_int"
        Me.ProHead_f03nLot_int.Weight = 0.92907007045283518R
        '
        'ProHeadf24cSize_v50
        '
        Me.ProHeadf24cSize_v50.Multiline = True
        Me.ProHeadf24cSize_v50.Name = "ProHeadf24cSize_v50"
        Me.ProHeadf24cSize_v50.Weight = 1.7067844915085146R
        '
        'XrTable2
        '
        Me.XrTable2.Font = New DevExpress.Drawing.DXFont("Calibri", 8.25!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTable2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 79.68988!)
        Me.XrTable2.Name = "XrTable2"
        Me.XrTable2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTable2.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow3, Me.XrTableRow4, Me.XrTableRow5, Me.XrTableRow6, Me.XrTableRow7})
        Me.XrTable2.SizeF = New System.Drawing.SizeF(777.0!, 114.5833!)
        Me.XrTable2.StylePriority.UseFont = False
        '
        'XrTableRow3
        '
        Me.XrTableRow3.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.XrTableRow3.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell3, Me.XrTableCell4, Me.ProHeadk02cKodeMaterialOrFG_v50})
        Me.XrTableRow3.Name = "XrTableRow3"
        Me.XrTableRow3.StylePriority.UseBorders = False
        Me.XrTableRow3.Weight = 1.0R
        '
        'XrTableCell3
        '
        Me.XrTableCell3.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell3.Font = New DevExpress.Drawing.DXFont("Calibri", 8.25!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell3.Multiline = True
        Me.XrTableCell3.Name = "XrTableCell3"
        Me.XrTableCell3.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100.0!)
        Me.XrTableCell3.StylePriority.UseBorders = False
        Me.XrTableCell3.StylePriority.UseFont = False
        Me.XrTableCell3.StylePriority.UsePadding = False
        Me.XrTableCell3.StylePriority.UseTextAlignment = False
        Me.XrTableCell3.Text = "MATERIAL/FG CODE"
        Me.XrTableCell3.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell3.Weight = 0.96038501799595211R
        '
        'XrTableCell4
        '
        Me.XrTableCell4.Font = New DevExpress.Drawing.DXFont("Microsoft Sans Serif", 8.25!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell4.Multiline = True
        Me.XrTableCell4.Name = "XrTableCell4"
        Me.XrTableCell4.StylePriority.UseFont = False
        Me.XrTableCell4.StylePriority.UseTextAlignment = False
        Me.XrTableCell4.Text = ":"
        Me.XrTableCell4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell4.Weight = 0.14434283042021961R
        '
        'ProHeadk02cKodeMaterialOrFG_v50
        '
        Me.ProHeadk02cKodeMaterialOrFG_v50.Borders = CType((DevExpress.XtraPrinting.BorderSide.Top Or DevExpress.XtraPrinting.BorderSide.Right), DevExpress.XtraPrinting.BorderSide)
        Me.ProHeadk02cKodeMaterialOrFG_v50.Font = New DevExpress.Drawing.DXFont("Calibri", 8.25!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.ProHeadk02cKodeMaterialOrFG_v50.Multiline = True
        Me.ProHeadk02cKodeMaterialOrFG_v50.Name = "ProHeadk02cKodeMaterialOrFG_v50"
        Me.ProHeadk02cKodeMaterialOrFG_v50.StylePriority.UseBorders = False
        Me.ProHeadk02cKodeMaterialOrFG_v50.StylePriority.UseFont = False
        Me.ProHeadk02cKodeMaterialOrFG_v50.StylePriority.UseTextAlignment = False
        Me.ProHeadk02cKodeMaterialOrFG_v50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.ProHeadk02cKodeMaterialOrFG_v50.Weight = 5.4224210479587063R
        '
        'XrTableRow4
        '
        Me.XrTableRow4.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell9, Me.XrTableCell10, Me.ProHeadf02MaterialOrFGDesc_v50})
        Me.XrTableRow4.Name = "XrTableRow4"
        Me.XrTableRow4.Weight = 1.0R
        '
        'XrTableCell9
        '
        Me.XrTableCell9.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrTableCell9.Font = New DevExpress.Drawing.DXFont("Calibri", 8.25!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell9.Multiline = True
        Me.XrTableCell9.Name = "XrTableCell9"
        Me.XrTableCell9.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100.0!)
        Me.XrTableCell9.StylePriority.UseBorders = False
        Me.XrTableCell9.StylePriority.UseFont = False
        Me.XrTableCell9.StylePriority.UsePadding = False
        Me.XrTableCell9.StylePriority.UseTextAlignment = False
        Me.XrTableCell9.Text = "DESCRIPTION"
        Me.XrTableCell9.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell9.Weight = 0.96038493710441442R
        '
        'XrTableCell10
        '
        Me.XrTableCell10.Font = New DevExpress.Drawing.DXFont("Microsoft Sans Serif", 8.25!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell10.Multiline = True
        Me.XrTableCell10.Name = "XrTableCell10"
        Me.XrTableCell10.StylePriority.UseFont = False
        Me.XrTableCell10.StylePriority.UseTextAlignment = False
        Me.XrTableCell10.Text = ":"
        Me.XrTableCell10.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell10.Weight = 0.14434288387107713R
        '
        'ProHeadf02MaterialOrFGDesc_v50
        '
        Me.ProHeadf02MaterialOrFGDesc_v50.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.ProHeadf02MaterialOrFGDesc_v50.Font = New DevExpress.Drawing.DXFont("Calibri", 8.25!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.ProHeadf02MaterialOrFGDesc_v50.Multiline = True
        Me.ProHeadf02MaterialOrFGDesc_v50.Name = "ProHeadf02MaterialOrFGDesc_v50"
        Me.ProHeadf02MaterialOrFGDesc_v50.StylePriority.UseBorders = False
        Me.ProHeadf02MaterialOrFGDesc_v50.StylePriority.UseFont = False
        Me.ProHeadf02MaterialOrFGDesc_v50.StylePriority.UseTextAlignment = False
        Me.ProHeadf02MaterialOrFGDesc_v50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.ProHeadf02MaterialOrFGDesc_v50.Weight = 5.4224210753993862R
        '
        'XrTableRow5
        '
        Me.XrTableRow5.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell15, Me.XrTableCell16, Me.ProHeadf07cOrderStatusDesc_v50})
        Me.XrTableRow5.Name = "XrTableRow5"
        Me.XrTableRow5.Weight = 1.0R
        '
        'XrTableCell15
        '
        Me.XrTableCell15.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrTableCell15.Font = New DevExpress.Drawing.DXFont("Calibri", 8.25!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell15.Multiline = True
        Me.XrTableCell15.Name = "XrTableCell15"
        Me.XrTableCell15.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100.0!)
        Me.XrTableCell15.StylePriority.UseBorders = False
        Me.XrTableCell15.StylePriority.UseFont = False
        Me.XrTableCell15.StylePriority.UsePadding = False
        Me.XrTableCell15.StylePriority.UseTextAlignment = False
        Me.XrTableCell15.Text = "ORDER STATUS"
        Me.XrTableCell15.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell15.Weight = 0.96038493710441442R
        '
        'XrTableCell16
        '
        Me.XrTableCell16.Font = New DevExpress.Drawing.DXFont("Microsoft Sans Serif", 8.25!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell16.Multiline = True
        Me.XrTableCell16.Name = "XrTableCell16"
        Me.XrTableCell16.StylePriority.UseFont = False
        Me.XrTableCell16.StylePriority.UseTextAlignment = False
        Me.XrTableCell16.Text = ":"
        Me.XrTableCell16.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell16.Weight = 0.14434288387107713R
        '
        'ProHeadf07cOrderStatusDesc_v50
        '
        Me.ProHeadf07cOrderStatusDesc_v50.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.ProHeadf07cOrderStatusDesc_v50.Font = New DevExpress.Drawing.DXFont("Calibri", 8.25!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.ProHeadf07cOrderStatusDesc_v50.Multiline = True
        Me.ProHeadf07cOrderStatusDesc_v50.Name = "ProHeadf07cOrderStatusDesc_v50"
        Me.ProHeadf07cOrderStatusDesc_v50.StylePriority.UseBorders = False
        Me.ProHeadf07cOrderStatusDesc_v50.StylePriority.UseFont = False
        Me.ProHeadf07cOrderStatusDesc_v50.StylePriority.UseTextAlignment = False
        Me.ProHeadf07cOrderStatusDesc_v50.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.ProHeadf07cOrderStatusDesc_v50.Weight = 5.4224210753993862R
        '
        'XrTableRow6
        '
        Me.XrTableRow6.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell21, Me.XrTableCell22, Me.ProHeadf08dOrderDate})
        Me.XrTableRow6.Name = "XrTableRow6"
        Me.XrTableRow6.Weight = 1.0R
        '
        'XrTableCell21
        '
        Me.XrTableCell21.Borders = DevExpress.XtraPrinting.BorderSide.Left
        Me.XrTableCell21.Font = New DevExpress.Drawing.DXFont("Calibri", 8.25!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell21.Multiline = True
        Me.XrTableCell21.Name = "XrTableCell21"
        Me.XrTableCell21.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100.0!)
        Me.XrTableCell21.StylePriority.UseBorders = False
        Me.XrTableCell21.StylePriority.UseFont = False
        Me.XrTableCell21.StylePriority.UsePadding = False
        Me.XrTableCell21.StylePriority.UseTextAlignment = False
        Me.XrTableCell21.Text = "ORDER DATE"
        Me.XrTableCell21.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell21.Weight = 0.96038493710441442R
        '
        'XrTableCell22
        '
        Me.XrTableCell22.Font = New DevExpress.Drawing.DXFont("Microsoft Sans Serif", 8.25!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell22.Multiline = True
        Me.XrTableCell22.Name = "XrTableCell22"
        Me.XrTableCell22.StylePriority.UseFont = False
        Me.XrTableCell22.StylePriority.UseTextAlignment = False
        Me.XrTableCell22.Text = ":"
        Me.XrTableCell22.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell22.Weight = 0.14434288387107713R
        '
        'ProHeadf08dOrderDate
        '
        Me.ProHeadf08dOrderDate.Borders = DevExpress.XtraPrinting.BorderSide.Right
        Me.ProHeadf08dOrderDate.Font = New DevExpress.Drawing.DXFont("Calibri", 8.25!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.ProHeadf08dOrderDate.Multiline = True
        Me.ProHeadf08dOrderDate.Name = "ProHeadf08dOrderDate"
        Me.ProHeadf08dOrderDate.StylePriority.UseBorders = False
        Me.ProHeadf08dOrderDate.StylePriority.UseFont = False
        Me.ProHeadf08dOrderDate.StylePriority.UseTextAlignment = False
        Me.ProHeadf08dOrderDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.ProHeadf08dOrderDate.Weight = 5.4224210753993862R
        '
        'XrTableRow7
        '
        Me.XrTableRow7.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableRow7.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell27, Me.XrTableCell28, Me.ProHeadf09dDeliveryDate})
        Me.XrTableRow7.Name = "XrTableRow7"
        Me.XrTableRow7.StylePriority.UseBorders = False
        Me.XrTableRow7.Weight = 1.0R
        '
        'XrTableCell27
        '
        Me.XrTableCell27.Borders = CType((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTableCell27.Font = New DevExpress.Drawing.DXFont("Calibri", 8.25!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell27.Multiline = True
        Me.XrTableCell27.Name = "XrTableCell27"
        Me.XrTableCell27.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 2, 0, 0, 100.0!)
        Me.XrTableCell27.StylePriority.UseBorders = False
        Me.XrTableCell27.StylePriority.UseFont = False
        Me.XrTableCell27.StylePriority.UsePadding = False
        Me.XrTableCell27.StylePriority.UseTextAlignment = False
        Me.XrTableCell27.Text = "DELIVERY DATE"
        Me.XrTableCell27.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.XrTableCell27.Weight = 0.96038493710441442R
        '
        'XrTableCell28
        '
        Me.XrTableCell28.Font = New DevExpress.Drawing.DXFont("Microsoft Sans Serif", 8.25!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell28.Multiline = True
        Me.XrTableCell28.Name = "XrTableCell28"
        Me.XrTableCell28.StylePriority.UseFont = False
        Me.XrTableCell28.StylePriority.UseTextAlignment = False
        Me.XrTableCell28.Text = ":"
        Me.XrTableCell28.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell28.Weight = 0.14434288387107713R
        '
        'ProHeadf09dDeliveryDate
        '
        Me.ProHeadf09dDeliveryDate.Borders = CType((DevExpress.XtraPrinting.BorderSide.Right Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.ProHeadf09dDeliveryDate.Font = New DevExpress.Drawing.DXFont("Calibri", 8.25!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.ProHeadf09dDeliveryDate.Multiline = True
        Me.ProHeadf09dDeliveryDate.Name = "ProHeadf09dDeliveryDate"
        Me.ProHeadf09dDeliveryDate.StylePriority.UseBorders = False
        Me.ProHeadf09dDeliveryDate.StylePriority.UseFont = False
        Me.ProHeadf09dDeliveryDate.StylePriority.UseTextAlignment = False
        Me.ProHeadf09dDeliveryDate.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleLeft
        Me.ProHeadf09dDeliveryDate.Weight = 5.4224210753993862R
        '
        'LnHeader
        '
        Me.LnHeader.BackColor = System.Drawing.Color.Transparent
        Me.LnHeader.Borders = DevExpress.XtraPrinting.BorderSide.Top
        Me.LnHeader.BorderWidth = 12.0!
        Me.LnHeader.ForeColor = System.Drawing.Color.Transparent
        Me.LnHeader.LocationFloat = New DevExpress.Utils.PointFloat(0!, 65.6496!)
        Me.LnHeader.Name = "LnHeader"
        Me.LnHeader.SizeF = New System.Drawing.SizeF(777.0!, 3.240746!)
        Me.LnHeader.StylePriority.UseBackColor = False
        Me.LnHeader.StylePriority.UseBorders = False
        Me.LnHeader.StylePriority.UseBorderWidth = False
        Me.LnHeader.StylePriority.UseForeColor = False
        '
        'XrTable1
        '
        Me.XrTable1.Font = New DevExpress.Drawing.DXFont("Calibri", 12.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(270.6016!, 0!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow1, Me.XrTableRow2})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(233.3333!, 63.54165!)
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UseTextAlignment = False
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow1
        '
        Me.XrTableRow1.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell1})
        Me.XrTableRow1.Name = "XrTableRow1"
        Me.XrTableRow1.Weight = 1.0R
        '
        'XrTableCell1
        '
        Me.XrTableCell1.Borders = DevExpress.XtraPrinting.BorderSide.Bottom
        Me.XrTableCell1.Font = New DevExpress.Drawing.DXFont("Calibri", 15.75!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell1.Multiline = True
        Me.XrTableCell1.Name = "XrTableCell1"
        Me.XrTableCell1.StylePriority.UseBorders = False
        Me.XrTableCell1.StylePriority.UseFont = False
        Me.XrTableCell1.Text = "PRODUCTION ORDER"
        Me.XrTableCell1.Weight = 1.0R
        '
        'XrTableRow2
        '
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.ProPrepHeadk01cNoPRO_v50})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.Weight = 1.0R
        '
        'ProPrepHeadk01cNoPRO_v50
        '
        Me.ProPrepHeadk01cNoPRO_v50.Font = New DevExpress.Drawing.DXFont("Calibri", 14.25!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.ProPrepHeadk01cNoPRO_v50.Multiline = True
        Me.ProPrepHeadk01cNoPRO_v50.Name = "ProPrepHeadk01cNoPRO_v50"
        Me.ProPrepHeadk01cNoPRO_v50.StylePriority.UseFont = False
        Me.ProPrepHeadk01cNoPRO_v50.Text = "ZN190000"
        Me.ProPrepHeadk01cNoPRO_v50.Weight = 1.0R
        '
        'ProPrepHeadQRcode
        '
        Me.ProPrepHeadQRcode.Font = New DevExpress.Drawing.DXFont("Arial", 8.25!, DevExpress.Drawing.DXFontStyle.Italic, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.ProPrepHeadQRcode.LocationFloat = New DevExpress.Utils.PointFloat(0!, 2.657477!)
        Me.ProPrepHeadQRcode.Name = "ProPrepHeadQRcode"
        Me.ProPrepHeadQRcode.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 4, 4, 100.0!)
        Me.ProPrepHeadQRcode.ShowText = False
        Me.ProPrepHeadQRcode.SizeF = New System.Drawing.SizeF(68.89764!, 62.99212!)
        Me.ProPrepHeadQRcode.StylePriority.UseFont = False
        Me.ProPrepHeadQRcode.StylePriority.UsePadding = False
        Me.ProPrepHeadQRcode.StylePriority.UseTextAlignment = False
        Me.ProPrepHeadQRcode.Symbology = QrCodeGenerator1
        Me.ProPrepHeadQRcode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
        '
        'PROPreparationReportParent
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail, Me.PageHeader})
        Me.Font = New DevExpress.Drawing.DXFont("Arial", 9.75!)
        Me.Margins = New DevExpress.Drawing.DXMargins(0, 48, 0, 13)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4
        Me.Version = "19.2"
        Me.Watermark.ImageAlign = System.Drawing.ContentAlignment.TopRight
        Me.Watermark.ImageSource = New DevExpress.XtraPrinting.Drawing.ImageSource("img", resources.GetString("PROPreparationReportParent.Watermark.ImageSource"))
        CType(Me.XrTable3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents PageHeader As DevExpress.XtraReports.UI.PageHeaderBand
    Friend WithEvents LnHeader As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow1 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell1 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents ProPrepHeadk01cNoPRO_v50 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ProPrepHeadQRcode As DevExpress.XtraReports.UI.XRBarCode
    Friend WithEvents XrTable2 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow3 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell3 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell4 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ProHeadk02cKodeMaterialOrFG_v50 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow4 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell9 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell10 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ProHeadf02MaterialOrFGDesc_v50 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow5 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell15 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell16 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ProHeadf07cOrderStatusDesc_v50 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow6 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell21 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell22 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ProHeadf08dOrderDate As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow7 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell27 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell28 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ProHeadf09dDeliveryDate As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents SubReportRouting As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents SubReportBOMPreparation As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents XrTable3 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents ProPrepParentHeaderTable As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell33 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell34 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell35 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell36 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell39 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableRow9 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents ProHeadf19cItemBRJDesc_v50 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ProHEadf21cWarnaFGDesc_v50 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ProHEadf23cKadarDesc_v50 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ProHeadf04nBerat_n92 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ProHeadf24cSize_v50 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel1 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents ProHeadf25cNotes_v250 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLabel7 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPageInfo1 As DevExpress.XtraReports.UI.XRPageInfo
    Friend WithEvents SubReportPROPreparationIMG As DevExpress.XtraReports.UI.XRSubreport
    Friend WithEvents XrTableCell2 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents ProHead_f03nLot_int As DevExpress.XtraReports.UI.XRTableCell
End Class
