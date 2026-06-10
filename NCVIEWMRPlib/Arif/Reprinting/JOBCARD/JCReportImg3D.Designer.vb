<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class JCReportImg3D
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
        Me.XrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
        Me._02cImg_01 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me._03cImg_02 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me._04cImg_03 = New DevExpress.XtraReports.UI.XRPictureBox()
        Me._01cNameImg = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 25.0!
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 25.0!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.XrPanel1, Me._01cNameImg})
        Me.Detail.HeightF = 226.3889!
        Me.Detail.Name = "Detail"
        '
        'XrPanel1
        '
        Me.XrPanel1.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me.XrPanel1.BorderWidth = 1.0!
        Me.XrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me._02cImg_01, Me._03cImg_02, Me._04cImg_03})
        Me.XrPanel1.LocationFloat = New DevExpress.Utils.PointFloat(0!, 18.83331!)
        Me.XrPanel1.Name = "XrPanel1"
        Me.XrPanel1.SizeF = New System.Drawing.SizeF(775.0!, 202.6945!)
        Me.XrPanel1.StylePriority.UseBorders = False
        Me.XrPanel1.StylePriority.UseBorderWidth = False
        '
        '_02cImg_01
        '
        Me._02cImg_01.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me._02cImg_01.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter
        Me._02cImg_01.LocationFloat = New DevExpress.Utils.PointFloat(10.0!, 7.555559!)
        Me._02cImg_01.Name = "_02cImg_01"
        Me._02cImg_01.SizeF = New System.Drawing.SizeF(238.1944!, 190.0!)
        Me._02cImg_01.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        Me._02cImg_01.StylePriority.UseBorders = False
        '
        '_03cImg_02
        '
        Me._03cImg_02.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me._03cImg_02.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter
        Me._03cImg_02.LocationFloat = New DevExpress.Utils.PointFloat(260.0!, 7.555557!)
        Me._03cImg_02.Name = "_03cImg_02"
        Me._03cImg_02.SizeF = New System.Drawing.SizeF(250.0!, 190.0!)
        Me._03cImg_02.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        Me._03cImg_02.StylePriority.UseBorders = False
        '
        '_04cImg_03
        '
        Me._04cImg_03.Borders = DevExpress.XtraPrinting.BorderSide.None
        Me._04cImg_03.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter
        Me._04cImg_03.LocationFloat = New DevExpress.Utils.PointFloat(517.0!, 7.555557!)
        Me._04cImg_03.Name = "_04cImg_03"
        Me._04cImg_03.SizeF = New System.Drawing.SizeF(250.0!, 190.0!)
        Me._04cImg_03.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        Me._04cImg_03.StylePriority.UseBorders = False
        '
        '_01cNameImg
        '
        Me._01cNameImg.Font = New DevExpress.Drawing.DXFont("Calibri", 10.0!, DevExpress.Drawing.DXFontStyle.Bold, DevExpress.Drawing.DXGraphicsUnit.Point, New DevExpress.Drawing.DXFontAdditionalProperty() {New DevExpress.Drawing.DXFontAdditionalProperty("GdiCharSet", CType(0, Byte))})
        Me._01cNameImg.LocationFloat = New DevExpress.Utils.PointFloat(0!, 0!)
        Me._01cNameImg.Multiline = True
        Me._01cNameImg.Name = "_01cNameImg"
        Me._01cNameImg.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100.0!)
        Me._01cNameImg.SizeF = New System.Drawing.SizeF(100.0!, 18.83331!)
        Me._01cNameImg.StylePriority.UseFont = False
        Me._01cNameImg.Text = "QC NOTE"
        '
        'JCReportImg3D
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail})
        Me.Font = New DevExpress.Drawing.DXFont("Arial", 9.75!)
        Me.Margins = New DevExpress.Drawing.DXMargins(0, 50, 25, 25)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4
        Me.Version = "19.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents _01cNameImg As DevExpress.XtraReports.UI.XRLabel
    Friend WithEvents XrPanel1 As DevExpress.XtraReports.UI.XRPanel
    Friend WithEvents _02cImg_01 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents _03cImg_02 As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents _04cImg_03 As DevExpress.XtraReports.UI.XRPictureBox
End Class
