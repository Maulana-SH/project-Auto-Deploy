<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class PROReportTCD
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
        Me.XrLine2 = New DevExpress.XtraReports.UI.XRLine()
        Me.ImgTCD02 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.ImgTCD03 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.ImgTCD01 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
        Me.XrLine1 = New DevExpress.XtraReports.UI.XRLine()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 1.0!
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 26.0!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrLine2, Me.ImgTCD02, Me.ImgTCD03, Me.ImgTCD01, Me.XrLabel2, Me.XrLine1})
        Me.Detail.HeightF = 186.1527!
        Me.Detail.Name = "Detail"
        '
        'XrLine2
        '
        Me.XrLine2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 180.959!)
        Me.XrLine2.Name = "XrLine2"
        Me.XrLine2.SizeF = New System.Drawing.SizeF(787.4016!, 2.083328!)
        '
        'ImgTCD02
        '
        Me.ImgTCD02.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.ImgTCD02.LocationFloat = New DevExpress.Utils.PointFloat(262.2047!, 17.30341!)
        Me.ImgTCD02.Name = "ImgTCD02"
        Me.ImgTCD02.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 4, 4, 100.0!)
        Me.ImgTCD02.SizeF = New System.Drawing.SizeF(262.2047!, 157.4803!)
        Me.ImgTCD02.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        Me.ImgTCD02.StylePriority.UseBorders = False
        Me.ImgTCD02.StylePriority.UsePadding = False
        '
        'ImgTCD03
        '
        Me.ImgTCD03.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.ImgTCD03.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter
        Me.ImgTCD03.LocationFloat = New DevExpress.Utils.PointFloat(525.1969!, 17.30342!)
        Me.ImgTCD03.Name = "ImgTCD03"
        Me.ImgTCD03.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 4, 4, 100.0!)
        Me.ImgTCD03.SizeF = New System.Drawing.SizeF(262.2047!, 157.4803!)
        Me.ImgTCD03.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        Me.ImgTCD03.StylePriority.UseBorders = False
        Me.ImgTCD03.StylePriority.UsePadding = False
        '
        'ImgTCD01
        '
        Me.ImgTCD01.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.ImgTCD01.LocationFloat = New DevExpress.Utils.PointFloat(0!, 17.30341!)
        Me.ImgTCD01.Name = "ImgTCD01"
        Me.ImgTCD01.Padding = New DevExpress.XtraPrinting.PaddingInfo(4, 4, 4, 4, 100.0!)
        Me.ImgTCD01.SizeF = New System.Drawing.SizeF(262.2047!, 157.4803!)
        Me.ImgTCD01.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        Me.ImgTCD01.StylePriority.UseBorders = False
        Me.ImgTCD01.StylePriority.UsePadding = False
        '
        'XrLabel2
        '
        Me.XrLabel2.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.XrLabel2.CanShrink = True
        Me.XrLabel2.Font = New DevExpress.Drawing.DXFont("Calibri", 9.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me.XrLabel2.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrLabel2.Multiline = True
        Me.XrLabel2.Name = "XrLabel2"
        Me.XrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me.XrLabel2.SizeF = New System.Drawing.SizeF(128.0603!, 17.30341!)
        Me.XrLabel2.StylePriority.UseBorders = False
        Me.XrLabel2.StylePriority.UseFont = False
        Me.XrLabel2.Text = "TECHNICAL DRAWING "
        '
        'XrLine1
        '
        Me.XrLine1.LocationFloat = New DevExpress.Utils.PointFloat(128.0603!, 7.249704!)
        Me.XrLine1.Name = "XrLine1"
        Me.XrLine1.SizeF = New System.Drawing.SizeF(658.5048!, 3.010178!)
        '
        'PROReportTCD
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail})
        Me.Font = New DevExpress.Drawing.DXFont("Arial", 9.75!)
        Me.Margins = New DevExpress.Drawing.DXMargins(0, 39, 1, 26)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4
        Me.Version = "19.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents XrLine2 As DevExpress.XtraReports.UI.XRLine
    Friend WithEvents ImgTCD02 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents ImgTCD03 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents ImgTCD01 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrLabel2 As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrLine1 As DevExpress.XtraReports.UI.XRLine
End Class
