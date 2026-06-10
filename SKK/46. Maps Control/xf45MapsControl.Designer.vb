<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class xf45MapsControl
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
        Me.components = New System.ComponentModel.Container()
        Dim MiniMap1 As DevExpress.XtraMap.MiniMap = New DevExpress.XtraMap.MiniMap()
        Dim DynamicMiniMapBehavior1 As DevExpress.XtraMap.DynamicMiniMapBehavior = New DevExpress.XtraMap.DynamicMiniMapBehavior()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xf45MapsControl))
        Me.MiniMapImageTilesLayer1 = New DevExpress.XtraMap.MiniMapImageTilesLayer()
        Me.BingMapDataProvider2 = New DevExpress.XtraMap.BingMapDataProvider()
        Me.MiniMapVectorItemsLayer1 = New DevExpress.XtraMap.MiniMapVectorItemsLayer()
        Me.MapItemStorage1 = New DevExpress.XtraMap.MapItemStorage()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.MapControl1 = New DevExpress.XtraMap.MapControl()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.MySvgCol = New DevExpress.Utils.SvgImageCollection(Me.components)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.MapControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MySvgCol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        Me.MiniMapImageTilesLayer1.DataProvider = Me.BingMapDataProvider2
        Me.BingMapDataProvider2.BingKey = "YOUR BING MAPS KEY"
        Me.MiniMapVectorItemsLayer1.Data = Me.MapItemStorage1
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.MapControl1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1373, 651)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'MapControl1
        '
        Me.MapControl1.Location = New System.Drawing.Point(12, 12)
        MiniMap1.Behavior = DynamicMiniMapBehavior1
        MiniMap1.Layers.Add(Me.MiniMapImageTilesLayer1)
        MiniMap1.Layers.Add(Me.MiniMapVectorItemsLayer1)
        MiniMap1.Visible = False
        Me.MapControl1.MiniMap = MiniMap1
        Me.MapControl1.Name = "MapControl1"
        Me.MapControl1.Size = New System.Drawing.Size(1349, 627)
        Me.MapControl1.TabIndex = 4
        Me.MapControl1.ZoomLevel = 14.0R
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1373, 651)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.MapControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1353, 631)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'MySvgCol
        '
        Me.MySvgCol.Add("HomeSolid.svg", CType(resources.GetObject("MySvgCol.HomeSolid.svg"), DevExpress.Utils.Svg.SvgImage))
        Me.MySvgCol.Add("indonesia", CType(resources.GetObject("MySvgCol.indonesia"), DevExpress.Utils.Svg.SvgImage))
        '
        'xf45MapsControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1373, 651)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "xf45MapsControl"
        Me.Text = "xf45MapsControl"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.MapControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MySvgCol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents MapControl1 As DevExpress.XtraMap.MapControl
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents BingMapDataProvider2 As DevExpress.XtraMap.BingMapDataProvider
    Friend WithEvents MapItemStorage1 As DevExpress.XtraMap.MapItemStorage
    Friend WithEvents MiniMapImageTilesLayer1 As DevExpress.XtraMap.MiniMapImageTilesLayer
    Friend WithEvents MiniMapVectorItemsLayer1 As DevExpress.XtraMap.MiniMapVectorItemsLayer
    Friend WithEvents MySvgCol As DevExpress.Utils.SvgImageCollection
End Class
