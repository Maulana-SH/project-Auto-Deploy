<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGougeControl
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim ArcScaleRange1 As DevExpress.XtraGauges.Core.Model.ArcScaleRange = New DevExpress.XtraGauges.Core.Model.ArcScaleRange()
        Dim ArcScaleRange2 As DevExpress.XtraGauges.Core.Model.ArcScaleRange = New DevExpress.XtraGauges.Core.Model.ArcScaleRange()
        Dim ArcScaleRange3 As DevExpress.XtraGauges.Core.Model.ArcScaleRange = New DevExpress.XtraGauges.Core.Model.ArcScaleRange()
        Dim LinearScaleRange1 As DevExpress.XtraGauges.Core.Model.LinearScaleRange = New DevExpress.XtraGauges.Core.Model.LinearScaleRange()
        Dim LinearScaleRange2 As DevExpress.XtraGauges.Core.Model.LinearScaleRange = New DevExpress.XtraGauges.Core.Model.LinearScaleRange()
        Dim LinearScaleRange3 As DevExpress.XtraGauges.Core.Model.LinearScaleRange = New DevExpress.XtraGauges.Core.Model.LinearScaleRange()
        Me.GaugeControl1 = New DevExpress.XtraGauges.Win.GaugeControl()
        Me.circularGauge1 = New DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge()
        Me.ArcScaleBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent()
        Me.ArcScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent()
        Me.ArcScaleNeedleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent()
        Me.ArcScaleSpindleCapComponent1 = New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent()
        Me.SpinEdit1 = New DevExpress.XtraEditors.SpinEdit()
        Me.GaugeControl2 = New DevExpress.XtraGauges.Win.GaugeControl()
        Me.linearGauge1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge()
        Me.LinearScaleBackgroundLayerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent()
        Me.LinearScaleComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent()
        Me.LinearScaleLevelComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent()
        Me.LinearScaleMarkerComponent1 = New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleMarkerComponent()
        Me.SpinEdit2 = New DevExpress.XtraEditors.SpinEdit()
        Me.SpinEdit3 = New DevExpress.XtraEditors.SpinEdit()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ArcScaleSpindleCapComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.linearGauge1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LinearScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LinearScaleComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LinearScaleLevelComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LinearScaleMarkerComponent1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit2.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SpinEdit3.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GaugeControl1
        '
        Me.GaugeControl1.AutoLayout = False
        Me.GaugeControl1.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.circularGauge1})
        Me.GaugeControl1.Location = New System.Drawing.Point(42, 12)
        Me.GaugeControl1.Name = "GaugeControl1"
        Me.GaugeControl1.Size = New System.Drawing.Size(165, 550)
        Me.GaugeControl1.TabIndex = 0
        '
        'circularGauge1
        '
        Me.circularGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent() {Me.ArcScaleBackgroundLayerComponent1})
        Me.circularGauge1.Bounds = New System.Drawing.Rectangle(6, 6, 153, 119)
        Me.circularGauge1.Name = "circularGauge1"
        Me.circularGauge1.Needles.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent() {Me.ArcScaleNeedleComponent1})
        Me.circularGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent() {Me.ArcScaleComponent1})
        Me.circularGauge1.SpindleCaps.AddRange(New DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent() {Me.ArcScaleSpindleCapComponent1})
        '
        'ArcScaleBackgroundLayerComponent1
        '
        Me.ArcScaleBackgroundLayerComponent1.ArcScale = Me.ArcScaleComponent1
        Me.ArcScaleBackgroundLayerComponent1.Name = "bg"
        Me.ArcScaleBackgroundLayerComponent1.ScaleCenterPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5!, 0.695!)
        Me.ArcScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.CircularHalf_Style16
        Me.ArcScaleBackgroundLayerComponent1.Size = New System.Drawing.SizeF(250.0!, 179.0!)
        Me.ArcScaleBackgroundLayerComponent1.ZOrder = 1000
        '
        'ArcScaleComponent1
        '
        Me.ArcScaleComponent1.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent1.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent1.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent1.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.ArcScaleComponent1.AppearanceTickmarkText.Font = New System.Drawing.Font("Courier New", 5.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ArcScaleComponent1.AppearanceTickmarkText.Format = New DevExpress.XtraGauges.Core.Drawing.StringFormatObject(System.Drawing.StringAlignment.Center, System.Drawing.StringAlignment.Center, System.Drawing.StringTrimming.Character, System.Drawing.StringFormatFlags.DirectionRightToLeft)
        Me.ArcScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#484E5A")
        Me.ArcScaleComponent1.Center = New DevExpress.XtraGauges.Core.Base.PointF2D(125.0!, 165.0!)
        Me.ArcScaleComponent1.EndAngle = 0!
        Me.ArcScaleComponent1.MajorTickCount = 9
        Me.ArcScaleComponent1.MajorTickmark.FormatString = "{0:F1}"
        Me.ArcScaleComponent1.MajorTickmark.Multiplier = 0.5!
        Me.ArcScaleComponent1.MajorTickmark.ShapeOffset = -13.0!
        Me.ArcScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_1
        Me.ArcScaleComponent1.MajorTickmark.TextOrientation = DevExpress.XtraGauges.Core.Model.LabelOrientation.LeftToRight
        Me.ArcScaleComponent1.MaxValue = 200.0!
        Me.ArcScaleComponent1.MinorTickCount = 4
        Me.ArcScaleComponent1.MinorTickmark.ShapeOffset = -12.0!
        Me.ArcScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Circular_Style16_2
        Me.ArcScaleComponent1.Name = "scale1"
        Me.ArcScaleComponent1.RadiusX = 98.0!
        Me.ArcScaleComponent1.RadiusY = 98.0!
        ArcScaleRange1.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#FF8080")
        ArcScaleRange1.EndThickness = 14.0!
        ArcScaleRange1.EndValue = 75.0!
        ArcScaleRange1.Name = "Range0"
        ArcScaleRange1.ShapeOffset = 0!
        ArcScaleRange1.StartThickness = 14.0!
        ArcScaleRange2.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#FED96D")
        ArcScaleRange2.EndThickness = 14.0!
        ArcScaleRange2.EndValue = 150.0!
        ArcScaleRange2.Name = "Range1"
        ArcScaleRange2.ShapeOffset = 0!
        ArcScaleRange2.StartThickness = 14.0!
        ArcScaleRange2.StartValue = 75.0!
        ArcScaleRange3.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:Lime")
        ArcScaleRange3.EndThickness = 15.0!
        ArcScaleRange3.EndValue = 200.0!
        ArcScaleRange3.Name = "Range2"
        ArcScaleRange3.ShapeOffset = 0!
        ArcScaleRange3.StartThickness = 14.0!
        ArcScaleRange3.StartValue = 150.0!
        Me.ArcScaleComponent1.Ranges.AddRange(New DevExpress.XtraGauges.Core.Model.IRange() {ArcScaleRange1, ArcScaleRange2, ArcScaleRange3})
        Me.ArcScaleComponent1.StartAngle = -180.0!
        Me.ArcScaleComponent1.Value = 20.0!
        '
        'ArcScaleNeedleComponent1
        '
        Me.ArcScaleNeedleComponent1.ArcScale = Me.ArcScaleComponent1
        Me.ArcScaleNeedleComponent1.EndOffset = 3.0!
        Me.ArcScaleNeedleComponent1.Name = "needle"
        Me.ArcScaleNeedleComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.NeedleShapeType.CircularFull_Style16
        Me.ArcScaleNeedleComponent1.ZOrder = -50
        '
        'ArcScaleSpindleCapComponent1
        '
        Me.ArcScaleSpindleCapComponent1.ArcScale = Me.ArcScaleComponent1
        Me.ArcScaleSpindleCapComponent1.Name = "circularGauge1_SpindleCap1"
        Me.ArcScaleSpindleCapComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.SpindleCapShapeType.CircularFull_Style16
        Me.ArcScaleSpindleCapComponent1.Size = New System.Drawing.SizeF(25.0!, 25.0!)
        Me.ArcScaleSpindleCapComponent1.ZOrder = -100
        '
        'SpinEdit1
        '
        Me.SpinEdit1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit1.Location = New System.Drawing.Point(213, 12)
        Me.SpinEdit1.Name = "SpinEdit1"
        Me.SpinEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEdit1.Properties.DisplayFormat.FormatString = "n3"
        Me.SpinEdit1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SpinEdit1.Properties.EditFormat.FormatString = "n3"
        Me.SpinEdit1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SpinEdit1.Size = New System.Drawing.Size(150, 28)
        Me.SpinEdit1.TabIndex = 1
        '
        'GaugeControl2
        '
        Me.GaugeControl2.AutoLayout = False
        Me.GaugeControl2.Gauges.AddRange(New DevExpress.XtraGauges.Base.IGauge() {Me.linearGauge1})
        Me.GaugeControl2.Location = New System.Drawing.Point(765, 12)
        Me.GaugeControl2.Name = "GaugeControl2"
        Me.GaugeControl2.Size = New System.Drawing.Size(219, 532)
        Me.GaugeControl2.TabIndex = 2
        '
        'linearGauge1
        '
        Me.linearGauge1.BackgroundLayers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent() {Me.LinearScaleBackgroundLayerComponent1})
        Me.linearGauge1.Bounds = New System.Drawing.Rectangle(1, 0, 215, 544)
        Me.linearGauge1.Levels.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent() {Me.LinearScaleLevelComponent1})
        Me.linearGauge1.Markers.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleMarkerComponent() {Me.LinearScaleMarkerComponent1})
        Me.linearGauge1.Name = "linearGauge1"
        Me.linearGauge1.OptionsToolTip.TooltipTitleFormat = "{0}"
        Me.linearGauge1.Scales.AddRange(New DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent() {Me.LinearScaleComponent1})
        '
        'LinearScaleBackgroundLayerComponent1
        '
        Me.LinearScaleBackgroundLayerComponent1.LinearScale = Me.LinearScaleComponent1
        Me.LinearScaleBackgroundLayerComponent1.Name = "bg1"
        Me.LinearScaleBackgroundLayerComponent1.ScaleStartPos = New DevExpress.XtraGauges.Core.Base.PointF2D(0.5!, 0.85!)
        Me.LinearScaleBackgroundLayerComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.BackgroundLayerShapeType.Linear_Style19
        Me.LinearScaleBackgroundLayerComponent1.ZOrder = 1000
        '
        'LinearScaleComponent1
        '
        Me.LinearScaleComponent1.AppearanceMajorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.LinearScaleComponent1.AppearanceMajorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.LinearScaleComponent1.AppearanceMinorTickmark.BorderBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.LinearScaleComponent1.AppearanceMinorTickmark.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:White")
        Me.LinearScaleComponent1.AppearanceTickmarkText.Font = New System.Drawing.Font("Tahoma", 9.0!)
        Me.LinearScaleComponent1.AppearanceTickmarkText.TextBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#A4D6F7")
        Me.LinearScaleComponent1.AutoRescaling = True
        Me.LinearScaleComponent1.EndPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5!, 38.0!)
        Me.LinearScaleComponent1.MajorTickCount = 9
        Me.LinearScaleComponent1.MajorTickmark.FormatString = "{0:F0}"
        Me.LinearScaleComponent1.MajorTickmark.ShapeOffset = -23.0!
        Me.LinearScaleComponent1.MajorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style19_1
        Me.LinearScaleComponent1.MajorTickmark.TextOffset = -35.0!
        Me.LinearScaleComponent1.MaxValue = 100.0!
        Me.LinearScaleComponent1.MinorTickCount = 4
        Me.LinearScaleComponent1.MinorTickmark.ShapeOffset = -23.0!
        Me.LinearScaleComponent1.MinorTickmark.ShapeType = DevExpress.XtraGauges.Core.Model.TickmarkShapeType.Linear_Style19_2
        Me.LinearScaleComponent1.Name = "scale1"
        LinearScaleRange1.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#059172")
        LinearScaleRange1.EndThickness = 14.0!
        LinearScaleRange1.EndValue = 33.0!
        LinearScaleRange1.Name = "Range0"
        LinearScaleRange1.ShapeOffset = -23.0!
        LinearScaleRange1.StartThickness = 14.0!
        LinearScaleRange2.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#CAB461")
        LinearScaleRange2.EndThickness = 14.0!
        LinearScaleRange2.EndValue = 66.0!
        LinearScaleRange2.Name = "Range1"
        LinearScaleRange2.ShapeOffset = -23.0!
        LinearScaleRange2.StartThickness = 14.0!
        LinearScaleRange2.StartValue = 33.0!
        LinearScaleRange3.AppearanceRange.ContentBrush = New DevExpress.XtraGauges.Core.Drawing.SolidBrushObject("Color:#A5648E")
        LinearScaleRange3.EndThickness = 14.0!
        LinearScaleRange3.EndValue = 100.0!
        LinearScaleRange3.Name = "Range2"
        LinearScaleRange3.ShapeOffset = -23.0!
        LinearScaleRange3.StartThickness = 14.0!
        LinearScaleRange3.StartValue = 66.0!
        Me.LinearScaleComponent1.Ranges.AddRange(New DevExpress.XtraGauges.Core.Model.IRange() {LinearScaleRange1, LinearScaleRange2, LinearScaleRange3})
        Me.LinearScaleComponent1.RescalingBestValues = True
        Me.LinearScaleComponent1.StartPoint = New DevExpress.XtraGauges.Core.Base.PointF2D(62.5!, 212.0!)
        Me.LinearScaleComponent1.Value = 75.3!
        '
        'LinearScaleLevelComponent1
        '
        Me.LinearScaleLevelComponent1.LinearScale = Me.LinearScaleComponent1
        Me.LinearScaleLevelComponent1.Name = "level1"
        Me.LinearScaleLevelComponent1.ShapeType = DevExpress.XtraGauges.Core.Model.LevelShapeSetType.Style4
        Me.LinearScaleLevelComponent1.Value = 0!
        Me.LinearScaleLevelComponent1.ZOrder = -50
        '
        'LinearScaleMarkerComponent1
        '
        Me.LinearScaleMarkerComponent1.LinearScale = Me.LinearScaleComponent1
        Me.LinearScaleMarkerComponent1.Name = "linearGauge1_Marker1"
        Me.LinearScaleMarkerComponent1.Value = 0!
        Me.LinearScaleMarkerComponent1.ZOrder = -150
        '
        'SpinEdit2
        '
        Me.SpinEdit2.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit2.Location = New System.Drawing.Point(547, 66)
        Me.SpinEdit2.Name = "SpinEdit2"
        Me.SpinEdit2.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEdit2.Properties.DisplayFormat.FormatString = "n2"
        Me.SpinEdit2.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SpinEdit2.Properties.EditFormat.FormatString = "n2"
        Me.SpinEdit2.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SpinEdit2.Size = New System.Drawing.Size(171, 28)
        Me.SpinEdit2.TabIndex = 4
        '
        'SpinEdit3
        '
        Me.SpinEdit3.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.SpinEdit3.Location = New System.Drawing.Point(547, 133)
        Me.SpinEdit3.Name = "SpinEdit3"
        Me.SpinEdit3.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.SpinEdit3.Properties.DisplayFormat.FormatString = "n2"
        Me.SpinEdit3.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SpinEdit3.Properties.EditFormat.FormatString = "n2"
        Me.SpinEdit3.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.SpinEdit3.Size = New System.Drawing.Size(171, 28)
        Me.SpinEdit3.TabIndex = 5
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(547, 45)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(85, 19)
        Me.LabelControl1.TabIndex = 6
        Me.LabelControl1.Text = "Taget Kadar"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(547, 108)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(90, 19)
        Me.LabelControl2.TabIndex = 7
        Me.LabelControl2.Text = "kadar Values"
        '
        'frmGougeControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1102, 668)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.SpinEdit3)
        Me.Controls.Add(Me.SpinEdit2)
        Me.Controls.Add(Me.GaugeControl2)
        Me.Controls.Add(Me.SpinEdit1)
        Me.Controls.Add(Me.GaugeControl1)
        Me.Name = "frmGougeControl"
        Me.Text = "frmGougeControl"
        CType(Me.circularGauge1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleNeedleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ArcScaleSpindleCapComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.linearGauge1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LinearScaleBackgroundLayerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LinearScaleComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LinearScaleLevelComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LinearScaleMarkerComponent1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit2.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SpinEdit3.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GaugeControl1 As DevExpress.XtraGauges.Win.GaugeControl
    Friend WithEvents circularGauge1 As DevExpress.XtraGauges.Win.Gauges.Circular.CircularGauge
    Private WithEvents ArcScaleBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleBackgroundLayerComponent
    Private WithEvents ArcScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleComponent
    Private WithEvents ArcScaleNeedleComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleNeedleComponent
    Private WithEvents ArcScaleSpindleCapComponent1 As DevExpress.XtraGauges.Win.Gauges.Circular.ArcScaleSpindleCapComponent
    Friend WithEvents SpinEdit1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents GaugeControl2 As DevExpress.XtraGauges.Win.GaugeControl
    Friend WithEvents linearGauge1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearGauge
    Private WithEvents LinearScaleBackgroundLayerComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleBackgroundLayerComponent
    Private WithEvents LinearScaleComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleComponent
    Private WithEvents LinearScaleLevelComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleLevelComponent
    Private WithEvents LinearScaleMarkerComponent1 As DevExpress.XtraGauges.Win.Gauges.Linear.LinearScaleMarkerComponent
    Friend WithEvents SpinEdit2 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SpinEdit3 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
End Class
