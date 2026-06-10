<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class PROPreparationIMG
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
        Me.ProPrepPicture01 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.ProPrepPicture02 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.ProPrepPicture03 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me.XrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 0!
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 6.0!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPanel1})
        Me.Detail.HeightF = 217.3611!
        Me.Detail.Name = "Detail"
        '
        'ProPrepPicture01
        '
        Me.ProPrepPicture01.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.ProPrepPicture01.LocationFloat = New DevExpress.Utils.PointFloat(10.0!, 10.00002!)
        Me.ProPrepPicture01.Name = "ProPrepPicture01"
        Me.ProPrepPicture01.SizeF = New System.Drawing.SizeF(233.5227!, 197.3611!)
        Me.ProPrepPicture01.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        Me.ProPrepPicture01.StylePriority.UseBorders = False
        '
        'ProPrepPicture02
        '
        Me.ProPrepPicture02.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.ProPrepPicture02.LocationFloat = New DevExpress.Utils.PointFloat(254.4827!, 10.00002!)
        Me.ProPrepPicture02.Name = "ProPrepPicture02"
        Me.ProPrepPicture02.SizeF = New System.Drawing.SizeF(250.0!, 197.3611!)
        Me.ProPrepPicture02.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        Me.ProPrepPicture02.StylePriority.UseBorders = False
        '
        'ProPrepPicture03
        '
        Me.ProPrepPicture03.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me.ProPrepPicture03.LocationFloat = New DevExpress.Utils.PointFloat(511.9392!, 10.00002!)
        Me.ProPrepPicture03.Name = "ProPrepPicture03"
        Me.ProPrepPicture03.SizeF = New System.Drawing.SizeF(252.0607!, 197.3611!)
        Me.ProPrepPicture03.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        Me.ProPrepPicture03.StylePriority.UseBorders = False
        '
        'XrPanel1
        '
        Me.XrPanel1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.ProPrepPicture03, Me.ProPrepPicture02, Me.ProPrepPicture01})
        Me.XrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me.XrPanel1.Name = "XrPanel1"
        Me.XrPanel1.SizeF = New System.Drawing.SizeF(773.9999!, 217.3611!)
        Me.XrPanel1.StylePriority.UseBorders = False
        '
        'PROPreparationIMG
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail})
        Me.Font = New DevExpress.Drawing.DXFont("Arial", 9.75!)
        Me.Margins = New DevExpress.Drawing.DXMargins(0, 53, 0, 6)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4
        Me.Version = "19.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents ProPrepPicture01 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents ProPrepPicture02 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents ProPrepPicture03 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents XrPanel1 As DevExpress.XtraReports.UI.XRPanel
End Class
