<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Public Class JCReportImg2D
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
        Me._02cImg = New DevExpress.XtraReports.UI.XRPictureBox()
        Me._01cNameImg = New DevExpress.XtraReports.UI.XRLabel()
        CType(Me, System.ComponentModel.ISupportInitialize).BeginInit()
        '
        'TopMargin
        '
        Me.TopMargin.HeightF = 1.388889!
        Me.TopMargin.Name = "TopMargin"
        '
        'BottomMargin
        '
        Me.BottomMargin.HeightF = 25.0!
        Me.BottomMargin.Name = "BottomMargin"
        '
        'Detail
        '
        Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me._02cImg, Me._01cNameImg})
        Me.Detail.HeightF = 419.4445!
        Me.Detail.Name = "Detail"
        '
        '_02cImg
        '
        Me._02cImg.BorderColor = System.Drawing.Color.Empty
        Me._02cImg.Borders = CType((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) _
            Or DevExpress.XtraPrinting.BorderSide.Right) _
            Or DevExpress.XtraPrinting.BorderSide.Bottom), DevExpress.XtraPrinting.BorderSide)
        Me._02cImg.LocationFloat = New DevExpress.Utils.PointFloat(0!, 18.83331!)
        Me._02cImg.Name = "_02cImg"
        Me._02cImg.SizeF = New System.Drawing.SizeF(136.1111!, 109.5833!)
        Me._02cImg.Sizing = DevExpress.XtraPrinting.ImageSizeMode.AutoSize
        Me._02cImg.StylePriority.UseBorderColor = False
        Me._02cImg.StylePriority.UseBorders = False
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
        'JCReportImg2D
        '
        Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.TopMargin, Me.BottomMargin, Me.Detail})
        Me.Font = New DevExpress.Drawing.DXFont("Arial", 9.75!)
        Me.Margins = New DevExpress.Drawing.DXMargins(0, 25, 1, 25)
        Me.PageHeight = 1169
        Me.PageWidth = 827
        Me.PaperKind = DevExpress.Drawing.Printing.DXPaperKind.A4
        Me.Version = "19.2"
        CType(Me, System.ComponentModel.ISupportInitialize).EndInit()

    End Sub

    Friend WithEvents TopMargin As DevExpress.XtraReports.UI.TopMarginBand
    Friend WithEvents BottomMargin As DevExpress.XtraReports.UI.BottomMarginBand
    Friend WithEvents Detail As DevExpress.XtraReports.UI.DetailBand
    Friend WithEvents _02cImg As DevExpress.XtraReports.UI.XRPictureBox
    Friend WithEvents _01cNameImg As DevExpress.XtraReports.UI.XRLabel
End Class
