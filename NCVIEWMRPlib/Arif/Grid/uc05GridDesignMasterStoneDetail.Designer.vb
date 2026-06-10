<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uc05GridDesignMasterStoneDetail
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
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
        Dim GridLevelNode1 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me._gcMasterStones = New DevExpress.XtraGrid.GridControl()
        Me._gvMasterStones = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col01_k01cKodeDesignMaster_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col02_f02cNamaBrand_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col03_f04cNamaProject_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col04_f06cNamaNamingProduct_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col05_f08cNamaItemProduct_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col06_f10cNamaSubItemProduct_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col07_f12cNamaProductionProcess_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col08_f14cNamaPlating_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col09_f16cNamaFinishing_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col010_f17nGrossWeight_n94 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me._rscol010_f17nGrossWeight_n94 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.col011_f19cNamaSize_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me._rscol011_f19cNamaSize_v50 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.col012_f42dCreatedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me._gcMasterStones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._gvMasterStones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._rscol010_f17nGrossWeight_n94, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._rscol011_f19cNamaSize_v50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_gcMasterStones
        '
        Me._gcMasterStones.EmbeddedNavigator.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me._gcMasterStones.EmbeddedNavigator.Appearance.BackColor = System.Drawing.Color.Transparent
        Me._gcMasterStones.EmbeddedNavigator.Appearance.ForeColor = System.Drawing.Color.Blue
        Me._gcMasterStones.EmbeddedNavigator.Appearance.Options.UseBackColor = True
        Me._gcMasterStones.EmbeddedNavigator.Appearance.Options.UseForeColor = True
        GridLevelNode1.RelationName = "Level1"
        Me._gcMasterStones.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode1})
        Me._gcMasterStones.Location = New System.Drawing.Point(2, 2)
        Me._gcMasterStones.MainView = Me._gvMasterStones
        Me._gcMasterStones.Name = "_gcMasterStones"
        Me._gcMasterStones.Padding = New System.Windows.Forms.Padding(5)
        Me._gcMasterStones.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me._rscol011_f19cNamaSize_v50, Me._rscol010_f17nGrossWeight_n94})
        Me._gcMasterStones.Size = New System.Drawing.Size(1225, 583)
        Me._gcMasterStones.TabIndex = 4
        Me._gcMasterStones.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me._gvMasterStones})
        '
        '_gvMasterStones
        '
        Me._gvMasterStones.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col01_k01cKodeDesignMaster_v50, Me.col02_f02cNamaBrand_v50, Me.col03_f04cNamaProject_v50, Me.col04_f06cNamaNamingProduct_v50, Me.col05_f08cNamaItemProduct_v50, Me.col06_f10cNamaSubItemProduct_v50, Me.col07_f12cNamaProductionProcess_v50, Me.col08_f14cNamaPlating_v50, Me.col09_f16cNamaFinishing_v50, Me.col010_f17nGrossWeight_n94, Me.col011_f19cNamaSize_v50, Me.col012_f42dCreatedDate})
        Me._gvMasterStones.GridControl = Me._gcMasterStones
        Me._gvMasterStones.Name = "_gvMasterStones"
        '
        'col01_k01cKodeDesignMaster_v50
        '
        Me.col01_k01cKodeDesignMaster_v50.AppearanceHeader.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col01_k01cKodeDesignMaster_v50.AppearanceHeader.Options.UseFont = True
        Me.col01_k01cKodeDesignMaster_v50.Caption = "DM Code"
        Me.col01_k01cKodeDesignMaster_v50.MinWidth = 30
        Me.col01_k01cKodeDesignMaster_v50.Name = "col01_k01cKodeDesignMaster_v50"
        Me.col01_k01cKodeDesignMaster_v50.Visible = True
        Me.col01_k01cKodeDesignMaster_v50.VisibleIndex = 0
        Me.col01_k01cKodeDesignMaster_v50.Width = 106
        '
        'col02_f02cNamaBrand_v50
        '
        Me.col02_f02cNamaBrand_v50.AppearanceHeader.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col02_f02cNamaBrand_v50.AppearanceHeader.Options.UseFont = True
        Me.col02_f02cNamaBrand_v50.Caption = "Brand"
        Me.col02_f02cNamaBrand_v50.MinWidth = 30
        Me.col02_f02cNamaBrand_v50.Name = "col02_f02cNamaBrand_v50"
        Me.col02_f02cNamaBrand_v50.Visible = True
        Me.col02_f02cNamaBrand_v50.VisibleIndex = 1
        Me.col02_f02cNamaBrand_v50.Width = 106
        '
        'col03_f04cNamaProject_v50
        '
        Me.col03_f04cNamaProject_v50.AppearanceHeader.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col03_f04cNamaProject_v50.AppearanceHeader.Options.UseFont = True
        Me.col03_f04cNamaProject_v50.Caption = "Project Name"
        Me.col03_f04cNamaProject_v50.MinWidth = 30
        Me.col03_f04cNamaProject_v50.Name = "col03_f04cNamaProject_v50"
        Me.col03_f04cNamaProject_v50.Visible = True
        Me.col03_f04cNamaProject_v50.VisibleIndex = 2
        Me.col03_f04cNamaProject_v50.Width = 98
        '
        'col04_f06cNamaNamingProduct_v50
        '
        Me.col04_f06cNamaNamingProduct_v50.AppearanceHeader.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col04_f06cNamaNamingProduct_v50.AppearanceHeader.Options.UseFont = True
        Me.col04_f06cNamaNamingProduct_v50.Caption = "Product Name"
        Me.col04_f06cNamaNamingProduct_v50.MinWidth = 30
        Me.col04_f06cNamaNamingProduct_v50.Name = "col04_f06cNamaNamingProduct_v50"
        Me.col04_f06cNamaNamingProduct_v50.Visible = True
        Me.col04_f06cNamaNamingProduct_v50.VisibleIndex = 3
        Me.col04_f06cNamaNamingProduct_v50.Width = 106
        '
        'col05_f08cNamaItemProduct_v50
        '
        Me.col05_f08cNamaItemProduct_v50.AppearanceHeader.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col05_f08cNamaItemProduct_v50.AppearanceHeader.Options.UseFont = True
        Me.col05_f08cNamaItemProduct_v50.Caption = "Item"
        Me.col05_f08cNamaItemProduct_v50.MinWidth = 30
        Me.col05_f08cNamaItemProduct_v50.Name = "col05_f08cNamaItemProduct_v50"
        Me.col05_f08cNamaItemProduct_v50.Visible = True
        Me.col05_f08cNamaItemProduct_v50.VisibleIndex = 4
        Me.col05_f08cNamaItemProduct_v50.Width = 106
        '
        'col06_f10cNamaSubItemProduct_v50
        '
        Me.col06_f10cNamaSubItemProduct_v50.AppearanceHeader.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col06_f10cNamaSubItemProduct_v50.AppearanceHeader.Options.UseFont = True
        Me.col06_f10cNamaSubItemProduct_v50.Caption = "Sub Item"
        Me.col06_f10cNamaSubItemProduct_v50.MinWidth = 30
        Me.col06_f10cNamaSubItemProduct_v50.Name = "col06_f10cNamaSubItemProduct_v50"
        Me.col06_f10cNamaSubItemProduct_v50.Visible = True
        Me.col06_f10cNamaSubItemProduct_v50.VisibleIndex = 5
        Me.col06_f10cNamaSubItemProduct_v50.Width = 106
        '
        'col07_f12cNamaProductionProcess_v50
        '
        Me.col07_f12cNamaProductionProcess_v50.AppearanceHeader.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col07_f12cNamaProductionProcess_v50.AppearanceHeader.Options.UseFont = True
        Me.col07_f12cNamaProductionProcess_v50.Caption = "Processs"
        Me.col07_f12cNamaProductionProcess_v50.MinWidth = 30
        Me.col07_f12cNamaProductionProcess_v50.Name = "col07_f12cNamaProductionProcess_v50"
        Me.col07_f12cNamaProductionProcess_v50.Visible = True
        Me.col07_f12cNamaProductionProcess_v50.VisibleIndex = 6
        Me.col07_f12cNamaProductionProcess_v50.Width = 106
        '
        'col08_f14cNamaPlating_v50
        '
        Me.col08_f14cNamaPlating_v50.AppearanceHeader.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col08_f14cNamaPlating_v50.AppearanceHeader.Options.UseFont = True
        Me.col08_f14cNamaPlating_v50.Caption = "Plating"
        Me.col08_f14cNamaPlating_v50.MinWidth = 30
        Me.col08_f14cNamaPlating_v50.Name = "col08_f14cNamaPlating_v50"
        Me.col08_f14cNamaPlating_v50.Visible = True
        Me.col08_f14cNamaPlating_v50.VisibleIndex = 7
        Me.col08_f14cNamaPlating_v50.Width = 106
        '
        'col09_f16cNamaFinishing_v50
        '
        Me.col09_f16cNamaFinishing_v50.AppearanceHeader.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col09_f16cNamaFinishing_v50.AppearanceHeader.Options.UseFont = True
        Me.col09_f16cNamaFinishing_v50.Caption = "Finishing"
        Me.col09_f16cNamaFinishing_v50.MinWidth = 30
        Me.col09_f16cNamaFinishing_v50.Name = "col09_f16cNamaFinishing_v50"
        Me.col09_f16cNamaFinishing_v50.Visible = True
        Me.col09_f16cNamaFinishing_v50.VisibleIndex = 8
        Me.col09_f16cNamaFinishing_v50.Width = 106
        '
        'col010_f17nGrossWeight_n94
        '
        Me.col010_f17nGrossWeight_n94.AppearanceHeader.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col010_f17nGrossWeight_n94.AppearanceHeader.Options.UseFont = True
        Me.col010_f17nGrossWeight_n94.Caption = "Gross Weight"
        Me.col010_f17nGrossWeight_n94.ColumnEdit = Me._rscol010_f17nGrossWeight_n94
        Me.col010_f17nGrossWeight_n94.MinWidth = 30
        Me.col010_f17nGrossWeight_n94.Name = "col010_f17nGrossWeight_n94"
        Me.col010_f17nGrossWeight_n94.Visible = True
        Me.col010_f17nGrossWeight_n94.VisibleIndex = 9
        Me.col010_f17nGrossWeight_n94.Width = 106
        '
        '_rscol010_f17nGrossWeight_n94
        '
        Me._rscol010_f17nGrossWeight_n94.AutoHeight = False
        Me._rscol010_f17nGrossWeight_n94.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._rscol010_f17nGrossWeight_n94.Name = "_rscol010_f17nGrossWeight_n94"
        '
        'col011_f19cNamaSize_v50
        '
        Me.col011_f19cNamaSize_v50.AppearanceHeader.Font = New System.Drawing.Font("Arial Narrow", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col011_f19cNamaSize_v50.AppearanceHeader.Options.UseFont = True
        Me.col011_f19cNamaSize_v50.Caption = "Size"
        Me.col011_f19cNamaSize_v50.ColumnEdit = Me._rscol011_f19cNamaSize_v50
        Me.col011_f19cNamaSize_v50.MinWidth = 30
        Me.col011_f19cNamaSize_v50.Name = "col011_f19cNamaSize_v50"
        Me.col011_f19cNamaSize_v50.Visible = True
        Me.col011_f19cNamaSize_v50.VisibleIndex = 10
        Me.col011_f19cNamaSize_v50.Width = 117
        '
        '_rscol011_f19cNamaSize_v50
        '
        Me._rscol011_f19cNamaSize_v50.AutoHeight = False
        Me._rscol011_f19cNamaSize_v50.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._rscol011_f19cNamaSize_v50.Name = "_rscol011_f19cNamaSize_v50"
        '
        'col012_f42dCreatedDate
        '
        Me.col012_f42dCreatedDate.Caption = "Created"
        Me.col012_f42dCreatedDate.MinWidth = 30
        Me.col012_f42dCreatedDate.Name = "col012_f42dCreatedDate"
        Me.col012_f42dCreatedDate.Visible = True
        Me.col012_f42dCreatedDate.VisibleIndex = 11
        Me.col012_f42dCreatedDate.Width = 112
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me._gcMasterStones)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1229, 587)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.Root.Name = "Root"
        Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.Root.Size = New System.Drawing.Size(1229, 587)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me._gcMasterStones
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1229, 587)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'uc05GridDesignMasterStoneDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "uc05GridDesignMasterStoneDetail"
        Me.Size = New System.Drawing.Size(1229, 587)
        CType(Me._gcMasterStones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._gvMasterStones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._rscol010_f17nGrossWeight_n94, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._rscol011_f19cNamaSize_v50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents _gcMasterStones As DevExpress.XtraGrid.GridControl
    Friend WithEvents _gvMasterStones As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents col01_k01cKodeDesignMaster_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col02_f02cNamaBrand_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col03_f04cNamaProject_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col04_f06cNamaNamingProduct_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col05_f08cNamaItemProduct_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col06_f10cNamaSubItemProduct_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col07_f12cNamaProductionProcess_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col08_f14cNamaPlating_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col09_f16cNamaFinishing_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col010_f17nGrossWeight_n94 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col011_f19cNamaSize_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents _rscol010_f17nGrossWeight_n94 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents _rscol011_f19cNamaSize_v50 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents col012_f42dCreatedDate As DevExpress.XtraGrid.Columns.GridColumn
End Class
