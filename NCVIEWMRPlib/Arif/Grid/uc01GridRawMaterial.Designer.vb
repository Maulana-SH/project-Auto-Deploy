<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc01GridRawMaterial
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
        Me._gcMCRawmaterial = New DevExpress.XtraGrid.GridControl()
        Me._gvMCRawmaterial = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me._col01_k01cKodeItemCastedParts_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me._col02_f01cItemCastedPartsDesc_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me._col03_f03cRawMaterialDesc_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me._col04_f05cKadarDesc_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me._rs_col04_f05cKadarDesc_v50 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me._col05_f07cWarnaDesc_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me._col06_f09cGoldTypeDesc_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me._col07_f32dCreatedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me._gcMCRawmaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._gvMCRawmaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._rs_col04_f05cKadarDesc_v50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me._gcMCRawmaterial)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1183, 642)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        '_gcMCRawmaterial
        '
        Me._gcMCRawmaterial.Location = New System.Drawing.Point(2, 2)
        Me._gcMCRawmaterial.MainView = Me._gvMCRawmaterial
        Me._gcMCRawmaterial.Name = "_gcMCRawmaterial"
        Me._gcMCRawmaterial.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me._rs_col04_f05cKadarDesc_v50})
        Me._gcMCRawmaterial.Size = New System.Drawing.Size(1179, 638)
        Me._gcMCRawmaterial.TabIndex = 4
        Me._gcMCRawmaterial.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me._gvMCRawmaterial})
        '
        '_gvMCRawmaterial
        '
        Me._gvMCRawmaterial.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me._col01_k01cKodeItemCastedParts_v50, Me._col02_f01cItemCastedPartsDesc_v50, Me._col03_f03cRawMaterialDesc_v50, Me._col04_f05cKadarDesc_v50, Me._col05_f07cWarnaDesc_v50, Me._col06_f09cGoldTypeDesc_v50, Me._col07_f32dCreatedDate})
        Me._gvMCRawmaterial.GridControl = Me._gcMCRawmaterial
        Me._gvMCRawmaterial.Name = "_gvMCRawmaterial"
        '
        '_col01_k01cKodeItemCastedParts_v50
        '
        Me._col01_k01cKodeItemCastedParts_v50.AppearanceCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._col01_k01cKodeItemCastedParts_v50.AppearanceCell.Options.UseFont = True
        Me._col01_k01cKodeItemCastedParts_v50.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._col01_k01cKodeItemCastedParts_v50.AppearanceHeader.Options.UseFont = True
        Me._col01_k01cKodeItemCastedParts_v50.Caption = "Castedpart Code"
        Me._col01_k01cKodeItemCastedParts_v50.MinWidth = 30
        Me._col01_k01cKodeItemCastedParts_v50.Name = "_col01_k01cKodeItemCastedParts_v50"
        Me._col01_k01cKodeItemCastedParts_v50.Visible = True
        Me._col01_k01cKodeItemCastedParts_v50.VisibleIndex = 0
        Me._col01_k01cKodeItemCastedParts_v50.Width = 190
        '
        '_col02_f01cItemCastedPartsDesc_v50
        '
        Me._col02_f01cItemCastedPartsDesc_v50.AppearanceCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._col02_f01cItemCastedPartsDesc_v50.AppearanceCell.Options.UseFont = True
        Me._col02_f01cItemCastedPartsDesc_v50.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._col02_f01cItemCastedPartsDesc_v50.AppearanceHeader.Options.UseFont = True
        Me._col02_f01cItemCastedPartsDesc_v50.Caption = "CastedParts "
        Me._col02_f01cItemCastedPartsDesc_v50.MinWidth = 30
        Me._col02_f01cItemCastedPartsDesc_v50.Name = "_col02_f01cItemCastedPartsDesc_v50"
        Me._col02_f01cItemCastedPartsDesc_v50.Visible = True
        Me._col02_f01cItemCastedPartsDesc_v50.VisibleIndex = 1
        Me._col02_f01cItemCastedPartsDesc_v50.Width = 194
        '
        '_col03_f03cRawMaterialDesc_v50
        '
        Me._col03_f03cRawMaterialDesc_v50.AppearanceCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._col03_f03cRawMaterialDesc_v50.AppearanceCell.Options.UseFont = True
        Me._col03_f03cRawMaterialDesc_v50.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._col03_f03cRawMaterialDesc_v50.AppearanceHeader.Options.UseFont = True
        Me._col03_f03cRawMaterialDesc_v50.Caption = "Material "
        Me._col03_f03cRawMaterialDesc_v50.MinWidth = 30
        Me._col03_f03cRawMaterialDesc_v50.Name = "_col03_f03cRawMaterialDesc_v50"
        Me._col03_f03cRawMaterialDesc_v50.Visible = True
        Me._col03_f03cRawMaterialDesc_v50.VisibleIndex = 2
        Me._col03_f03cRawMaterialDesc_v50.Width = 189
        '
        '_col04_f05cKadarDesc_v50
        '
        Me._col04_f05cKadarDesc_v50.AppearanceCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._col04_f05cKadarDesc_v50.AppearanceCell.Options.UseFont = True
        Me._col04_f05cKadarDesc_v50.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._col04_f05cKadarDesc_v50.AppearanceHeader.Options.UseFont = True
        Me._col04_f05cKadarDesc_v50.Caption = "Kadar "
        Me._col04_f05cKadarDesc_v50.ColumnEdit = Me._rs_col04_f05cKadarDesc_v50
        Me._col04_f05cKadarDesc_v50.MinWidth = 30
        Me._col04_f05cKadarDesc_v50.Name = "_col04_f05cKadarDesc_v50"
        Me._col04_f05cKadarDesc_v50.Visible = True
        Me._col04_f05cKadarDesc_v50.VisibleIndex = 3
        Me._col04_f05cKadarDesc_v50.Width = 189
        '
        '_rs_col04_f05cKadarDesc_v50
        '
        Me._rs_col04_f05cKadarDesc_v50.AutoHeight = False
        Me._rs_col04_f05cKadarDesc_v50.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._rs_col04_f05cKadarDesc_v50.Name = "_rs_col04_f05cKadarDesc_v50"
        '
        '_col05_f07cWarnaDesc_v50
        '
        Me._col05_f07cWarnaDesc_v50.AppearanceCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._col05_f07cWarnaDesc_v50.AppearanceCell.Options.UseFont = True
        Me._col05_f07cWarnaDesc_v50.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._col05_f07cWarnaDesc_v50.AppearanceHeader.Options.UseFont = True
        Me._col05_f07cWarnaDesc_v50.Caption = "Warna"
        Me._col05_f07cWarnaDesc_v50.MinWidth = 30
        Me._col05_f07cWarnaDesc_v50.Name = "_col05_f07cWarnaDesc_v50"
        Me._col05_f07cWarnaDesc_v50.Visible = True
        Me._col05_f07cWarnaDesc_v50.VisibleIndex = 4
        Me._col05_f07cWarnaDesc_v50.Width = 189
        '
        '_col06_f09cGoldTypeDesc_v50
        '
        Me._col06_f09cGoldTypeDesc_v50.AppearanceCell.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._col06_f09cGoldTypeDesc_v50.AppearanceCell.Options.UseFont = True
        Me._col06_f09cGoldTypeDesc_v50.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._col06_f09cGoldTypeDesc_v50.AppearanceHeader.Options.UseFont = True
        Me._col06_f09cGoldTypeDesc_v50.Caption = "Type"
        Me._col06_f09cGoldTypeDesc_v50.MinWidth = 30
        Me._col06_f09cGoldTypeDesc_v50.Name = "_col06_f09cGoldTypeDesc_v50"
        Me._col06_f09cGoldTypeDesc_v50.Visible = True
        Me._col06_f09cGoldTypeDesc_v50.VisibleIndex = 5
        Me._col06_f09cGoldTypeDesc_v50.Width = 192
        '
        '_col07_f32dCreatedDate
        '
        Me._col07_f32dCreatedDate.Caption = "Created"
        Me._col07_f32dCreatedDate.MinWidth = 30
        Me._col07_f32dCreatedDate.Name = "_col07_f32dCreatedDate"
        Me._col07_f32dCreatedDate.Visible = True
        Me._col07_f32dCreatedDate.VisibleIndex = 6
        Me._col07_f32dCreatedDate.Width = 112
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.Root.Name = "Root"
        Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.Root.Size = New System.Drawing.Size(1183, 642)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me._gcMCRawmaterial
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1183, 642)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'uc01GridRawMaterial
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "uc01GridRawMaterial"
        Me.Size = New System.Drawing.Size(1183, 642)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me._gcMCRawmaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._gvMCRawmaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._rs_col04_f05cKadarDesc_v50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents _gcMCRawmaterial As DevExpress.XtraGrid.GridControl
    Friend WithEvents _gvMCRawmaterial As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents _col01_k01cKodeItemCastedParts_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents _col02_f01cItemCastedPartsDesc_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents _col03_f03cRawMaterialDesc_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents _col04_f05cKadarDesc_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents _col05_f07cWarnaDesc_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents _col06_f09cGoldTypeDesc_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents _rs_col04_f05cKadarDesc_v50 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents _col07_f32dCreatedDate As DevExpress.XtraGrid.Columns.GridColumn
End Class
