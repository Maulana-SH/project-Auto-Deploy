<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc03GridMasterStone
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me._gcMasterStone = New DevExpress.XtraGrid.GridControl()
        Me._gvMasterStones = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col01_k01cKodeStones_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col02_f03cStonesTypeDesc_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col03_f05cShapeDesc_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col04_f07cWarnaDesc_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col05_f09cSizeDesc_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me._rscol05_f09cSizeDesc_v50 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.col06_f11cQualityDesc_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col07_f13cBrandDesc_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col08_f14nBeratPerButir_n92 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me._rscol08_f14nBeratPerButir_n92 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.col09_f15nHargaPerGram_n92 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me._rscol09_f15nHargaPerGram_n92 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.col010_f32dCreatedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me._gcMasterStone, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._gvMasterStones, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._rscol05_f09cSizeDesc_v50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._rscol08_f14nBeratPerButir_n92, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._rscol09_f15nHargaPerGram_n92, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me._gcMasterStone)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1235, 591)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        '_gcMasterStone
        '
        Me._gcMasterStone.Location = New System.Drawing.Point(2, 2)
        Me._gcMasterStone.MainView = Me._gvMasterStones
        Me._gcMasterStone.Name = "_gcMasterStone"
        Me._gcMasterStone.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me._rscol05_f09cSizeDesc_v50, Me._rscol08_f14nBeratPerButir_n92, Me._rscol09_f15nHargaPerGram_n92})
        Me._gcMasterStone.Size = New System.Drawing.Size(1231, 587)
        Me._gcMasterStone.TabIndex = 4
        Me._gcMasterStone.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me._gvMasterStones})
        '
        '_gvMasterStones
        '
        Me._gvMasterStones.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col01_k01cKodeStones_v50, Me.col02_f03cStonesTypeDesc_v50, Me.col03_f05cShapeDesc_v50, Me.col04_f07cWarnaDesc_v50, Me.col05_f09cSizeDesc_v50, Me.col06_f11cQualityDesc_v50, Me.col07_f13cBrandDesc_v50, Me.col08_f14nBeratPerButir_n92, Me.col09_f15nHargaPerGram_n92, Me.col010_f32dCreatedDate})
        Me._gvMasterStones.GridControl = Me._gcMasterStone
        Me._gvMasterStones.Name = "_gvMasterStones"
        '
        'col01_k01cKodeStones_v50
        '
        Me.col01_k01cKodeStones_v50.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col01_k01cKodeStones_v50.AppearanceHeader.Options.UseFont = True
        Me.col01_k01cKodeStones_v50.Caption = "Stone Code"
        Me.col01_k01cKodeStones_v50.MinWidth = 30
        Me.col01_k01cKodeStones_v50.Name = "col01_k01cKodeStones_v50"
        Me.col01_k01cKodeStones_v50.Visible = True
        Me.col01_k01cKodeStones_v50.VisibleIndex = 0
        Me.col01_k01cKodeStones_v50.Width = 112
        '
        'col02_f03cStonesTypeDesc_v50
        '
        Me.col02_f03cStonesTypeDesc_v50.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col02_f03cStonesTypeDesc_v50.AppearanceHeader.Options.UseFont = True
        Me.col02_f03cStonesTypeDesc_v50.Caption = "Stone Type"
        Me.col02_f03cStonesTypeDesc_v50.MinWidth = 30
        Me.col02_f03cStonesTypeDesc_v50.Name = "col02_f03cStonesTypeDesc_v50"
        Me.col02_f03cStonesTypeDesc_v50.Visible = True
        Me.col02_f03cStonesTypeDesc_v50.VisibleIndex = 1
        Me.col02_f03cStonesTypeDesc_v50.Width = 112
        '
        'col03_f05cShapeDesc_v50
        '
        Me.col03_f05cShapeDesc_v50.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col03_f05cShapeDesc_v50.AppearanceHeader.Options.UseFont = True
        Me.col03_f05cShapeDesc_v50.Caption = "Shape"
        Me.col03_f05cShapeDesc_v50.MinWidth = 30
        Me.col03_f05cShapeDesc_v50.Name = "col03_f05cShapeDesc_v50"
        Me.col03_f05cShapeDesc_v50.Visible = True
        Me.col03_f05cShapeDesc_v50.VisibleIndex = 2
        Me.col03_f05cShapeDesc_v50.Width = 112
        '
        'col04_f07cWarnaDesc_v50
        '
        Me.col04_f07cWarnaDesc_v50.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col04_f07cWarnaDesc_v50.AppearanceHeader.Options.UseFont = True
        Me.col04_f07cWarnaDesc_v50.Caption = "Color"
        Me.col04_f07cWarnaDesc_v50.MinWidth = 30
        Me.col04_f07cWarnaDesc_v50.Name = "col04_f07cWarnaDesc_v50"
        Me.col04_f07cWarnaDesc_v50.Visible = True
        Me.col04_f07cWarnaDesc_v50.VisibleIndex = 3
        Me.col04_f07cWarnaDesc_v50.Width = 112
        '
        'col05_f09cSizeDesc_v50
        '
        Me.col05_f09cSizeDesc_v50.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col05_f09cSizeDesc_v50.AppearanceHeader.Options.UseFont = True
        Me.col05_f09cSizeDesc_v50.Caption = "Size"
        Me.col05_f09cSizeDesc_v50.ColumnEdit = Me._rscol05_f09cSizeDesc_v50
        Me.col05_f09cSizeDesc_v50.MinWidth = 30
        Me.col05_f09cSizeDesc_v50.Name = "col05_f09cSizeDesc_v50"
        Me.col05_f09cSizeDesc_v50.Visible = True
        Me.col05_f09cSizeDesc_v50.VisibleIndex = 4
        Me.col05_f09cSizeDesc_v50.Width = 112
        '
        '_rscol05_f09cSizeDesc_v50
        '
        Me._rscol05_f09cSizeDesc_v50.AutoHeight = False
        Me._rscol05_f09cSizeDesc_v50.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._rscol05_f09cSizeDesc_v50.Name = "_rscol05_f09cSizeDesc_v50"
        '
        'col06_f11cQualityDesc_v50
        '
        Me.col06_f11cQualityDesc_v50.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col06_f11cQualityDesc_v50.AppearanceHeader.Options.UseFont = True
        Me.col06_f11cQualityDesc_v50.Caption = "qty"
        Me.col06_f11cQualityDesc_v50.MinWidth = 30
        Me.col06_f11cQualityDesc_v50.Name = "col06_f11cQualityDesc_v50"
        Me.col06_f11cQualityDesc_v50.Visible = True
        Me.col06_f11cQualityDesc_v50.VisibleIndex = 5
        Me.col06_f11cQualityDesc_v50.Width = 112
        '
        'col07_f13cBrandDesc_v50
        '
        Me.col07_f13cBrandDesc_v50.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col07_f13cBrandDesc_v50.AppearanceHeader.Options.UseFont = True
        Me.col07_f13cBrandDesc_v50.Caption = "Brand"
        Me.col07_f13cBrandDesc_v50.MinWidth = 30
        Me.col07_f13cBrandDesc_v50.Name = "col07_f13cBrandDesc_v50"
        Me.col07_f13cBrandDesc_v50.Visible = True
        Me.col07_f13cBrandDesc_v50.VisibleIndex = 6
        Me.col07_f13cBrandDesc_v50.Width = 112
        '
        'col08_f14nBeratPerButir_n92
        '
        Me.col08_f14nBeratPerButir_n92.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col08_f14nBeratPerButir_n92.AppearanceHeader.Options.UseFont = True
        Me.col08_f14nBeratPerButir_n92.Caption = "Weight"
        Me.col08_f14nBeratPerButir_n92.ColumnEdit = Me._rscol08_f14nBeratPerButir_n92
        Me.col08_f14nBeratPerButir_n92.DisplayFormat.FormatString = "n3"
        Me.col08_f14nBeratPerButir_n92.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col08_f14nBeratPerButir_n92.MinWidth = 30
        Me.col08_f14nBeratPerButir_n92.Name = "col08_f14nBeratPerButir_n92"
        Me.col08_f14nBeratPerButir_n92.Visible = True
        Me.col08_f14nBeratPerButir_n92.VisibleIndex = 7
        Me.col08_f14nBeratPerButir_n92.Width = 112
        '
        '_rscol08_f14nBeratPerButir_n92
        '
        Me._rscol08_f14nBeratPerButir_n92.AutoHeight = False
        Me._rscol08_f14nBeratPerButir_n92.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._rscol08_f14nBeratPerButir_n92.Name = "_rscol08_f14nBeratPerButir_n92"
        '
        'col09_f15nHargaPerGram_n92
        '
        Me.col09_f15nHargaPerGram_n92.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col09_f15nHargaPerGram_n92.AppearanceHeader.Options.UseFont = True
        Me.col09_f15nHargaPerGram_n92.Caption = "Price/Weight"
        Me.col09_f15nHargaPerGram_n92.ColumnEdit = Me._rscol09_f15nHargaPerGram_n92
        Me.col09_f15nHargaPerGram_n92.DisplayFormat.FormatString = "n3"
        Me.col09_f15nHargaPerGram_n92.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col09_f15nHargaPerGram_n92.MinWidth = 30
        Me.col09_f15nHargaPerGram_n92.Name = "col09_f15nHargaPerGram_n92"
        Me.col09_f15nHargaPerGram_n92.Visible = True
        Me.col09_f15nHargaPerGram_n92.VisibleIndex = 8
        Me.col09_f15nHargaPerGram_n92.Width = 112
        '
        '_rscol09_f15nHargaPerGram_n92
        '
        Me._rscol09_f15nHargaPerGram_n92.AutoHeight = False
        Me._rscol09_f15nHargaPerGram_n92.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._rscol09_f15nHargaPerGram_n92.Name = "_rscol09_f15nHargaPerGram_n92"
        '
        'col010_f32dCreatedDate
        '
        Me.col010_f32dCreatedDate.Caption = "Created"
        Me.col010_f32dCreatedDate.MinWidth = 30
        Me.col010_f32dCreatedDate.Name = "col010_f32dCreatedDate"
        Me.col010_f32dCreatedDate.Visible = True
        Me.col010_f32dCreatedDate.VisibleIndex = 9
        Me.col010_f32dCreatedDate.Width = 112
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.Root.Name = "Root"
        Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.Root.Size = New System.Drawing.Size(1235, 591)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me._gcMasterStone
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1235, 591)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'uc03GridMasterStone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "uc03GridMasterStone"
        Me.Size = New System.Drawing.Size(1235, 591)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me._gcMasterStone, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._gvMasterStones, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._rscol05_f09cSizeDesc_v50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._rscol08_f14nBeratPerButir_n92, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._rscol09_f15nHargaPerGram_n92, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents _gcMasterStone As DevExpress.XtraGrid.GridControl
    Friend WithEvents _gvMasterStones As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col01_k01cKodeStones_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col02_f03cStonesTypeDesc_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col03_f05cShapeDesc_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col04_f07cWarnaDesc_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col05_f09cSizeDesc_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col06_f11cQualityDesc_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col07_f13cBrandDesc_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col08_f14nBeratPerButir_n92 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col09_f15nHargaPerGram_n92 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents _rscol05_f09cSizeDesc_v50 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents _rscol08_f14nBeratPerButir_n92 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents _rscol09_f15nHargaPerGram_n92 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents col010_f32dCreatedDate As DevExpress.XtraGrid.Columns.GridColumn
End Class
