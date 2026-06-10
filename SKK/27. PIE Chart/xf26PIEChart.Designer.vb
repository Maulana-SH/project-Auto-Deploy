<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xf26PIEChart
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim Series1 As DevExpress.XtraCharts.Series = New DevExpress.XtraCharts.Series()
        Dim PieSeriesView1 As DevExpress.XtraCharts.PieSeriesView = New DevExpress.XtraCharts.PieSeriesView()
        Dim ChartTitle1 As DevExpress.XtraCharts.ChartTitle = New DevExpress.XtraCharts.ChartTitle()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.chart_pie = New DevExpress.XtraCharts.ChartControl()
        CType(Me.chart_pie, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(PieSeriesView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(37, 34)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(164, 54)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "SimpleButton1"
        '
        'chart_pie
        '
        Me.chart_pie.Location = New System.Drawing.Point(39, 105)
        Me.chart_pie.Name = "chart_pie"
        Series1.LabelsVisibility = DevExpress.Utils.DefaultBoolean.[True]
        Series1.Name = "nmSeris_01"
        PieSeriesView1.SweepDirection = DevExpress.XtraCharts.PieSweepDirection.Clockwise
        PieSeriesView1.TotalLabel.BackColor = System.Drawing.Color.FromArgb(CType(CType(79, Byte), Integer), CType(CType(129, Byte), Integer), CType(CType(189, Byte), Integer))
        PieSeriesView1.TotalLabel.Border.Color = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        PieSeriesView1.TotalLabel.Border.Thickness = 2
        PieSeriesView1.TotalLabel.Border.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        PieSeriesView1.TotalLabel.TextColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        PieSeriesView1.TotalLabel.TextPattern = "ALOKASI"
        PieSeriesView1.TotalLabel.Visible = True
        Series1.View = PieSeriesView1
        Me.chart_pie.SeriesSerializable = New DevExpress.XtraCharts.Series() {Series1}
        Me.chart_pie.Size = New System.Drawing.Size(547, 529)
        Me.chart_pie.TabIndex = 1
        ChartTitle1.Text = "ALOKASI BAHAN"
        ChartTitle1.Visibility = DevExpress.Utils.DefaultBoolean.[True]
        Me.chart_pie.Titles.AddRange(New DevExpress.XtraCharts.ChartTitle() {ChartTitle1})
        '
        'xf26PIEChart
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1705, 723)
        Me.Controls.Add(Me.chart_pie)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Name = "xf26PIEChart"
        Me.Text = "xf26PIEChart"
        CType(PieSeriesView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Series1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.chart_pie, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents chart_pie As DevExpress.XtraCharts.ChartControl
End Class
