<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xf31GetRowfilterGridview
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
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.gcFilter = New DevExpress.XtraGrid.GridControl()
        Me.gvFilter = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.dtfCol01_k01cKodeItemVault_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dtfCol02_f01cNamaItemVault_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dtfCol03_f09cNamaKadar_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dtfCol04_f07cNamaWarna_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.gcData = New DevExpress.XtraGrid.GridControl()
        Me.gvData = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.dtCol01_k01cKodeItemVault_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dtCol02_f01cNamaItemVault_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dtCol03_f09cNamaKadar_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.dtCol04_f07cNamaWarna_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.btnLopingFilter = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.gcFilter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvFilter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.gcFilter)
        Me.LayoutControl1.Controls.Add(Me.gcData)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl1.Controls.Add(Me.btnLopingFilter)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1383, 677)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'gcFilter
        '
        Me.gcFilter.Location = New System.Drawing.Point(749, 12)
        Me.gcFilter.MainView = Me.gvFilter
        Me.gcFilter.Name = "gcFilter"
        Me.gcFilter.Size = New System.Drawing.Size(622, 653)
        Me.gcFilter.TabIndex = 5
        Me.gcFilter.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvFilter})
        '
        'gvFilter
        '
        Me.gvFilter.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.dtfCol01_k01cKodeItemVault_v50, Me.dtfCol02_f01cNamaItemVault_v50, Me.dtfCol03_f09cNamaKadar_v50, Me.dtfCol04_f07cNamaWarna_v50})
        Me.gvFilter.GridControl = Me.gcFilter
        Me.gvFilter.Name = "gvFilter"
        '
        'dtfCol01_k01cKodeItemVault_v50
        '
        Me.dtfCol01_k01cKodeItemVault_v50.Caption = "Kode"
        Me.dtfCol01_k01cKodeItemVault_v50.MinWidth = 30
        Me.dtfCol01_k01cKodeItemVault_v50.Name = "dtfCol01_k01cKodeItemVault_v50"
        Me.dtfCol01_k01cKodeItemVault_v50.Visible = True
        Me.dtfCol01_k01cKodeItemVault_v50.VisibleIndex = 0
        Me.dtfCol01_k01cKodeItemVault_v50.Width = 112
        '
        'dtfCol02_f01cNamaItemVault_v50
        '
        Me.dtfCol02_f01cNamaItemVault_v50.Caption = "Desc"
        Me.dtfCol02_f01cNamaItemVault_v50.MinWidth = 30
        Me.dtfCol02_f01cNamaItemVault_v50.Name = "dtfCol02_f01cNamaItemVault_v50"
        Me.dtfCol02_f01cNamaItemVault_v50.Visible = True
        Me.dtfCol02_f01cNamaItemVault_v50.VisibleIndex = 1
        Me.dtfCol02_f01cNamaItemVault_v50.Width = 112
        '
        'dtfCol03_f09cNamaKadar_v50
        '
        Me.dtfCol03_f09cNamaKadar_v50.Caption = "Kadar"
        Me.dtfCol03_f09cNamaKadar_v50.MinWidth = 30
        Me.dtfCol03_f09cNamaKadar_v50.Name = "dtfCol03_f09cNamaKadar_v50"
        Me.dtfCol03_f09cNamaKadar_v50.Visible = True
        Me.dtfCol03_f09cNamaKadar_v50.VisibleIndex = 2
        Me.dtfCol03_f09cNamaKadar_v50.Width = 112
        '
        'dtfCol04_f07cNamaWarna_v50
        '
        Me.dtfCol04_f07cNamaWarna_v50.Caption = "Warna"
        Me.dtfCol04_f07cNamaWarna_v50.MinWidth = 30
        Me.dtfCol04_f07cNamaWarna_v50.Name = "dtfCol04_f07cNamaWarna_v50"
        Me.dtfCol04_f07cNamaWarna_v50.Visible = True
        Me.dtfCol04_f07cNamaWarna_v50.VisibleIndex = 3
        Me.dtfCol04_f07cNamaWarna_v50.Width = 112
        '
        'gcData
        '
        Me.gcData.Location = New System.Drawing.Point(12, 48)
        Me.gcData.MainView = Me.gvData
        Me.gcData.Name = "gcData"
        Me.gcData.Size = New System.Drawing.Size(617, 617)
        Me.gcData.TabIndex = 4
        Me.gcData.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvData})
        '
        'gvData
        '
        Me.gvData.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.dtCol01_k01cKodeItemVault_v50, Me.dtCol02_f01cNamaItemVault_v50, Me.dtCol03_f09cNamaKadar_v50, Me.dtCol04_f07cNamaWarna_v50})
        Me.gvData.GridControl = Me.gcData
        Me.gvData.Name = "gvData"
        '
        'dtCol01_k01cKodeItemVault_v50
        '
        Me.dtCol01_k01cKodeItemVault_v50.Caption = "Kode"
        Me.dtCol01_k01cKodeItemVault_v50.MinWidth = 30
        Me.dtCol01_k01cKodeItemVault_v50.Name = "dtCol01_k01cKodeItemVault_v50"
        Me.dtCol01_k01cKodeItemVault_v50.Visible = True
        Me.dtCol01_k01cKodeItemVault_v50.VisibleIndex = 0
        Me.dtCol01_k01cKodeItemVault_v50.Width = 112
        '
        'dtCol02_f01cNamaItemVault_v50
        '
        Me.dtCol02_f01cNamaItemVault_v50.Caption = "Desc"
        Me.dtCol02_f01cNamaItemVault_v50.MinWidth = 30
        Me.dtCol02_f01cNamaItemVault_v50.Name = "dtCol02_f01cNamaItemVault_v50"
        Me.dtCol02_f01cNamaItemVault_v50.Visible = True
        Me.dtCol02_f01cNamaItemVault_v50.VisibleIndex = 1
        Me.dtCol02_f01cNamaItemVault_v50.Width = 112
        '
        'dtCol03_f09cNamaKadar_v50
        '
        Me.dtCol03_f09cNamaKadar_v50.Caption = "Kadar"
        Me.dtCol03_f09cNamaKadar_v50.MinWidth = 30
        Me.dtCol03_f09cNamaKadar_v50.Name = "dtCol03_f09cNamaKadar_v50"
        Me.dtCol03_f09cNamaKadar_v50.Visible = True
        Me.dtCol03_f09cNamaKadar_v50.VisibleIndex = 2
        Me.dtCol03_f09cNamaKadar_v50.Width = 112
        '
        'dtCol04_f07cNamaWarna_v50
        '
        Me.dtCol04_f07cNamaWarna_v50.Caption = "Warna"
        Me.dtCol04_f07cNamaWarna_v50.MinWidth = 30
        Me.dtCol04_f07cNamaWarna_v50.Name = "dtCol04_f07cNamaWarna_v50"
        Me.dtCol04_f07cNamaWarna_v50.Visible = True
        Me.dtCol04_f07cNamaWarna_v50.VisibleIndex = 3
        Me.dtCol04_f07cNamaWarna_v50.Width = 112
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(633, 136)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(112, 32)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 6
        Me.SimpleButton1.Text = ">>"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(12, 12)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(115, 32)
        Me.SimpleButton2.StyleController = Me.LayoutControl1
        Me.SimpleButton2.TabIndex = 7
        Me.SimpleButton2.Text = "Get Data"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.EmptySpaceItem1, Me.LayoutControlItem3, Me.EmptySpaceItem2, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.EmptySpaceItem3})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1383, 677)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.gcData
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 36)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(621, 621)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.gcFilter
        Me.LayoutControlItem2.Location = New System.Drawing.Point(737, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(626, 657)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(621, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(116, 124)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.SimpleButton1
        Me.LayoutControlItem3.Location = New System.Drawing.Point(621, 124)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(116, 36)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(621, 160)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(116, 497)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.SimpleButton2
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(119, 36)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'btnLopingFilter
        '
        Me.btnLopingFilter.Location = New System.Drawing.Point(131, 12)
        Me.btnLopingFilter.Name = "btnLopingFilter"
        Me.btnLopingFilter.Size = New System.Drawing.Size(170, 32)
        Me.btnLopingFilter.StyleController = Me.LayoutControl1
        Me.btnLopingFilter.TabIndex = 8
        Me.btnLopingFilter.Text = "CekRowView"
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.btnLopingFilter
        Me.LayoutControlItem5.Location = New System.Drawing.Point(119, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(174, 36)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(293, 0)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(328, 36)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'xf31GetRowfilterGridview
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1383, 677)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "xf31GetRowfilterGridview"
        Me.Text = "xf31GetRowfilterGridview"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.gcFilter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvFilter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents gcFilter As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvFilter As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents gcData As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvData As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents dtCol01_k01cKodeItemVault_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtCol02_f01cNamaItemVault_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtCol03_f09cNamaKadar_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtCol04_f07cNamaWarna_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtfCol01_k01cKodeItemVault_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtfCol02_f01cNamaItemVault_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtfCol03_f09cNamaKadar_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents dtfCol04_f07cNamaWarna_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnLopingFilter As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
End Class
