<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class JCReportRouting
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
        Me.XrTable1 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow2 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.col01_ProcessName = New DevExpress.XtraReports.UI.XRTableCell()
        Me.col02_Operator = New DevExpress.XtraReports.UI.XRTableCell()
        Me.col03_StartDate = New DevExpress.XtraReports.UI.XRTableCell()
        Me.col04_finishingDate = New DevExpress.XtraReports.UI.XRTableCell()
        Me.col05_Approval = New DevExpress.XtraReports.UI.XRTableCell()
        Me.col06_BeratAwal = New DevExpress.XtraReports.UI.XRTableCell()
        Me.col07_BeratAkhir = New DevExpress.XtraReports.UI.XRTableCell()
        Me.col08_poin = New DevExpress.XtraReports.UI.XRTableCell()
        Me.col09_Note = New DevExpress.XtraReports.UI.XRTableCell()
        Me.ReportHeader = New DevExpress.XtraReports.UI.ReportHeaderBand()
        Me.XrTable4 = New DevExpress.XtraReports.UI.XRTable()
        Me.XrTableRow14 = New DevExpress.XtraReports.UI.XRTableRow()
        Me.XrTableCell18 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell23 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell25 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell28 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell31 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell32 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell34 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell35 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrTableCell33 = New DevExpress.XtraReports.UI.XRTableCell()
        Me.XrLabel3 = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 2.0!
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 25.0!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable1})
        Me.Detail.HeightF = 40.0!
        Me.Detail.Name = "Detail"
        '
        'XrTable1
        '
        Me.XrTable1.BackColor = System.Drawing.Color.LightGray
        Me.XrTable1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable1.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTable1.ForeColor = System.Drawing.Color.Black
        Me.XrTable1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrTable1.Name = "XrTable1"
        Me.XrTable1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrTable1.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow2})
        Me.XrTable1.SizeF = New System.Drawing.SizeF(777.0!, 40.0!)
        Me.XrTable1.StylePriority.UseBackColor = False
        Me.XrTable1.StylePriority.UseBorders = False
        Me.XrTable1.StylePriority.UseFont = False
        Me.XrTable1.StylePriority.UseForeColor = False
        Me.XrTable1.StylePriority.UseTextAlignment = False
        Me.XrTable1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow2
        '
        Me.XrTableRow2.BackColor = System.Drawing.Color.Transparent
        Me.XrTableRow2.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.col01_ProcessName, Me.col02_Operator, Me.col03_StartDate, Me.col04_finishingDate, Me.col05_Approval, Me.col06_BeratAwal, Me.col07_BeratAkhir, Me.col08_poin, Me.col09_Note})
        Me.XrTableRow2.Name = "XrTableRow2"
        Me.XrTableRow2.StylePriority.UseBackColor = False
        Me.XrTableRow2.Weight = 1.7777777777777777R
        '
        'col01_ProcessName
        '
        Me.col01_ProcessName.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Regular, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.col01_ProcessName.Multiline = True
        Me.col01_ProcessName.Name = "col01_ProcessName"
        Me.col01_ProcessName.StylePriority.UseFont = False
        Me.col01_ProcessName.StylePriority.UseTextAlignment = False
        Me.col01_ProcessName.Text = "3D DESIGN"
        Me.col01_ProcessName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.col01_ProcessName.Weight = 1.7834470437910079R
        '
        'col02_Operator
        '
        Me.col02_Operator.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.col02_Operator.Multiline = True
        Me.col02_Operator.Name = "col02_Operator"
        Me.col02_Operator.StylePriority.UseFont = False
        Me.col02_Operator.Text = " "
        Me.col02_Operator.Weight = 1.362416726089015R
        '
        'col03_StartDate
        '
        Me.col03_StartDate.Multiline = True
        Me.col03_StartDate.Name = "col03_StartDate"
        Me.col03_StartDate.Text = " "
        Me.col03_StartDate.Weight = 1.4613732083925304R
        '
        'col04_finishingDate
        '
        Me.col04_finishingDate.Multiline = True
        Me.col04_finishingDate.Name = "col04_finishingDate"
        Me.col04_finishingDate.Text = " "
        Me.col04_finishingDate.Weight = 1.6222930063279013R
        '
        'col05_Approval
        '
        Me.col05_Approval.Multiline = True
        Me.col05_Approval.Name = "col05_Approval"
        Me.col05_Approval.Text = " "
        Me.col05_Approval.Weight = 1.4983236227967924R
        '
        'col06_BeratAwal
        '
        Me.col06_BeratAwal.Multiline = True
        Me.col06_BeratAwal.Name = "col06_BeratAwal"
        Me.col06_BeratAwal.Text = " "
        Me.col06_BeratAwal.Weight = 1.4735533126263583R
        '
        'col07_BeratAkhir
        '
        Me.col07_BeratAkhir.Multiline = True
        Me.col07_BeratAkhir.Name = "col07_BeratAkhir"
        Me.col07_BeratAkhir.Text = " "
        Me.col07_BeratAkhir.Weight = 1.8451046978401346R
        '
        'col08_poin
        '
        Me.col08_poin.Multiline = True
        Me.col08_poin.Name = "col08_poin"
        Me.col08_poin.Text = " "
        Me.col08_poin.Weight = 0.94099695300121478R
        '
        'col09_Note
        '
        Me.col09_Note.Multiline = True
        Me.col09_Note.Name = "col09_Note"
        Me.col09_Note.Text = " "
        Me.col09_Note.Weight = 1.869874206759794R
        '
        'ReportHeader
        '
        Me.ReportHeader.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrTable4, Me.XrLabel3})
        Me.ReportHeader.HeightF = 45.5!
        Me.ReportHeader.Name = "ReportHeader"
        '
        'XrTable4
        '
        Me.XrTable4.BackColor = System.Drawing.Color.LightGray
        Me.XrTable4.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrTable4.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTable4.ForeColor = System.Drawing.Color.Black
        Me.XrTable4.LocationFloat = New DevExpress.Utils.PointFloat(0.0001271566!, 23.0!)
        Me.XrTable4.Name = "XrTable4"
        Me.XrTable4.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 96.0!)
        Me.XrTable4.Rows.AddRange(New DevExpress.XtraReports.UI.XRTableRow() {Me.XrTableRow14})
        Me.XrTable4.SizeF = New System.Drawing.SizeF(777.0!, 22.5!)
        Me.XrTable4.StylePriority.UseBackColor = False
        Me.XrTable4.StylePriority.UseBorders = False
        Me.XrTable4.StylePriority.UseFont = False
        Me.XrTable4.StylePriority.UseForeColor = False
        Me.XrTable4.StylePriority.UseTextAlignment = False
        Me.XrTable4.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        '
        'XrTableRow14
        '
        Me.XrTableRow14.BackColor = System.Drawing.Color.Transparent
        Me.XrTableRow14.Cells.AddRange(New DevExpress.XtraReports.UI.XRTableCell() {Me.XrTableCell18, Me.XrTableCell23, Me.XrTableCell25, Me.XrTableCell28, Me.XrTableCell31, Me.XrTableCell32, Me.XrTableCell34, Me.XrTableCell35, Me.XrTableCell33})
        Me.XrTableRow14.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableRow14.Name = "XrTableRow14"
        Me.XrTableRow14.StylePriority.UseBackColor = False
        Me.XrTableRow14.StylePriority.UseFont = False
        Me.XrTableRow14.Weight = 1.0R
        '
        'XrTableCell18
        '
        Me.XrTableCell18.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell18.Multiline = True
        Me.XrTableCell18.Name = "XrTableCell18"
        Me.XrTableCell18.StylePriority.UseFont = False
        Me.XrTableCell18.StylePriority.UseTextAlignment = False
        Me.XrTableCell18.Text = "PROCESS"
        Me.XrTableCell18.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter
        Me.XrTableCell18.Weight = 1.7834470437910079R
        '
        'XrTableCell23
        '
        Me.XrTableCell23.Font = New DevExpress.Drawing.DXFont("Calibri", 8.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrTableCell23.Multiline = True
        Me.XrTableCell23.Name = "XrTableCell23"
        Me.XrTableCell23.StylePriority.UseFont = False
        Me.XrTableCell23.Text = "OPERATOR"
        Me.XrTableCell23.Weight = 1.362416726089015R
        '
        'XrTableCell25
        '
        Me.XrTableCell25.Multiline = True
        Me.XrTableCell25.Name = "XrTableCell25"
        Me.XrTableCell25.Text = "START DATE"
        Me.XrTableCell25.Weight = 1.4613732083925304R
        '
        'XrTableCell28
        '
        Me.XrTableCell28.Multiline = True
        Me.XrTableCell28.Name = "XrTableCell28"
        Me.XrTableCell28.Text = "FINISHI DATE"
        Me.XrTableCell28.Weight = 1.6222930063279013R
        '
        'XrTableCell31
        '
        Me.XrTableCell31.Multiline = True
        Me.XrTableCell31.Name = "XrTableCell31"
        Me.XrTableCell31.Text = "APROVAL"
        Me.XrTableCell31.Weight = 1.4983236227967924R
        '
        'XrTableCell32
        '
        Me.XrTableCell32.Multiline = True
        Me.XrTableCell32.Name = "XrTableCell32"
        Me.XrTableCell32.Text = "START WEIGHT"
        Me.XrTableCell32.Weight = 1.4735533126263583R
        '
        'XrTableCell34
        '
        Me.XrTableCell34.Multiline = True
        Me.XrTableCell34.Name = "XrTableCell34"
        Me.XrTableCell34.Text = "FINISH WEIGHT"
        Me.XrTableCell34.Weight = 1.8451046978401346R
        '
        'XrTableCell35
        '
        Me.XrTableCell35.Multiline = True
        Me.XrTableCell35.Name = "XrTableCell35"
        Me.XrTableCell35.Text = "POIN"
        Me.XrTableCell35.Weight = 0.94099695300121478R
        '
        'XrTableCell33
        '
        Me.XrTableCell33.Multiline = True
        Me.XrTableCell33.Name = "XrTableCell33"
        Me.XrTableCell33.Text = "NOTE"
        Me.XrTableCell33.Weight = 1.869874206759794R
        '
        'XrLabel3
        '
        Me.XrLabel3.Font = New DevExpress.Drawing.DXFont("Calibri", 14.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel3.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel3.Multiline = True
        Me.XrLabel3.Name = "XrLabel3"
        Me.XrLabel3.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel3.SizeF = New System.Drawing.SizeF(186.8056!, 23.0!)
        Me.XrLabel3.StylePriority.UseFont = False
        Me.XrLabel3.Text = "ROUTING"
        '
        'JCReportRouting
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail, Me.ReportHeader})
        Me.Font = New DevExpress.Drawing.DXFont("Arial", 9.75!)
        Me.Margins = New DevExpress.Drawing.DXMargins(0, 49, 2, 25)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4
        Me.Version = "19.2"
        CType(Me.XrTable1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XrTable4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents ReportHeader As DevExpress.XtraReports.UI.ReportHeaderBand
    Friend WithEvents XrTable1 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow2 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents col01_ProcessName As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents col02_Operator As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents col03_StartDate As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents col04_finishingDate As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents col05_Approval As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents col06_BeratAwal As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents col07_BeratAkhir As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents col08_poin As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents col09_Note As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTable4 As DevExpress.XtraReports.UI.XRTable
    Friend WithEvents XrTableRow14 As DevExpress.XtraReports.UI.XRTableRow
    Friend WithEvents XrTableCell18 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell23 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell25 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell28 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell31 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell32 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell34 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell35 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrTableCell33 As DevExpress.XtraReports.UI.XRTableCell
    Friend WithEvents XrLabel3 As DevExpress.XtraReports.UI.XRLabel
End Class
