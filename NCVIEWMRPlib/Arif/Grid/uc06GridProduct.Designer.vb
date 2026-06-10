<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class uc06GridProduct
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
        Me._gcProduct = New DevExpress.XtraGrid.GridControl()
        Me._gvProduct = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col01_k01cKodeProduct_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col02_f01cNamaProduct_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col03_f04cNamaItemProduct_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col04_f06cNamaBrand_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col05_f08cNamaMaterial_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col06_f10cNamaKadar_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me._rscol06_f10cNamaKadar_v50 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.col07_f12cNamaColor_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col08_f14cNamaSize_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me._rscol08_f14cNamaSize_v50 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.col09_f16cNamaEngrave_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col010_f18cNamaGender_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col011_f20cNamaPlating_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col012_f22cNamaFinishing_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col013_f24cNamaStoneType_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col014_f26cNamaStoneColor_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col015_f28cNamaFinding_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col016_f01objGambar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col017_f42dCreatedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me._gcProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._gvProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._rscol06_f10cNamaKadar_v50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._rscol08_f14cNamaSize_v50, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me._gcProduct)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1215, 538)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        '_gcProduct
        '
        Me._gcProduct.Location = New System.Drawing.Point(2, 2)
        Me._gcProduct.MainView = Me._gvProduct
        Me._gcProduct.Name = "_gcProduct"
        Me._gcProduct.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me._rscol08_f14cNamaSize_v50, Me._rscol06_f10cNamaKadar_v50})
        Me._gcProduct.Size = New System.Drawing.Size(1211, 534)
        Me._gcProduct.TabIndex = 4
        Me._gcProduct.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me._gvProduct})
        '
        '_gvProduct
        '
        Me._gvProduct.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col01_k01cKodeProduct_v50, Me.col02_f01cNamaProduct_v50, Me.col03_f04cNamaItemProduct_v50, Me.col04_f06cNamaBrand_v50, Me.col05_f08cNamaMaterial_v50, Me.col06_f10cNamaKadar_v50, Me.col07_f12cNamaColor_v50, Me.col08_f14cNamaSize_v50, Me.col09_f16cNamaEngrave_v50, Me.col010_f18cNamaGender_v50, Me.col011_f20cNamaPlating_v50, Me.col012_f22cNamaFinishing_v50, Me.col013_f24cNamaStoneType_v50, Me.col014_f26cNamaStoneColor_v50, Me.col015_f28cNamaFinding_v50, Me.col016_f01objGambar, Me.col017_f42dCreatedDate})
        Me._gvProduct.GridControl = Me._gcProduct
        Me._gvProduct.Name = "_gvProduct"
        '
        'col01_k01cKodeProduct_v50
        '
        Me.col01_k01cKodeProduct_v50.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col01_k01cKodeProduct_v50.AppearanceHeader.Options.UseFont = True
        Me.col01_k01cKodeProduct_v50.Caption = "Product Code"
        Me.col01_k01cKodeProduct_v50.MinWidth = 30
        Me.col01_k01cKodeProduct_v50.Name = "col01_k01cKodeProduct_v50"
        Me.col01_k01cKodeProduct_v50.Visible = True
        Me.col01_k01cKodeProduct_v50.VisibleIndex = 0
        Me.col01_k01cKodeProduct_v50.Width = 112
        '
        'col02_f01cNamaProduct_v50
        '
        Me.col02_f01cNamaProduct_v50.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col02_f01cNamaProduct_v50.AppearanceHeader.Options.UseFont = True
        Me.col02_f01cNamaProduct_v50.Caption = "Product Name"
        Me.col02_f01cNamaProduct_v50.MinWidth = 30
        Me.col02_f01cNamaProduct_v50.Name = "col02_f01cNamaProduct_v50"
        Me.col02_f01cNamaProduct_v50.Visible = True
        Me.col02_f01cNamaProduct_v50.VisibleIndex = 1
        Me.col02_f01cNamaProduct_v50.Width = 112
        '
        'col03_f04cNamaItemProduct_v50
        '
        Me.col03_f04cNamaItemProduct_v50.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col03_f04cNamaItemProduct_v50.AppearanceHeader.Options.UseFont = True
        Me.col03_f04cNamaItemProduct_v50.Caption = "Item Name"
        Me.col03_f04cNamaItemProduct_v50.MinWidth = 30
        Me.col03_f04cNamaItemProduct_v50.Name = "col03_f04cNamaItemProduct_v50"
        Me.col03_f04cNamaItemProduct_v50.Visible = True
        Me.col03_f04cNamaItemProduct_v50.VisibleIndex = 2
        Me.col03_f04cNamaItemProduct_v50.Width = 112
        '
        'col04_f06cNamaBrand_v50
        '
        Me.col04_f06cNamaBrand_v50.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col04_f06cNamaBrand_v50.AppearanceHeader.Options.UseFont = True
        Me.col04_f06cNamaBrand_v50.Caption = "Brand"
        Me.col04_f06cNamaBrand_v50.MinWidth = 30
        Me.col04_f06cNamaBrand_v50.Name = "col04_f06cNamaBrand_v50"
        Me.col04_f06cNamaBrand_v50.Visible = True
        Me.col04_f06cNamaBrand_v50.VisibleIndex = 3
        Me.col04_f06cNamaBrand_v50.Width = 112
        '
        'col05_f08cNamaMaterial_v50
        '
        Me.col05_f08cNamaMaterial_v50.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col05_f08cNamaMaterial_v50.AppearanceHeader.Options.UseFont = True
        Me.col05_f08cNamaMaterial_v50.Caption = "Material"
        Me.col05_f08cNamaMaterial_v50.MinWidth = 30
        Me.col05_f08cNamaMaterial_v50.Name = "col05_f08cNamaMaterial_v50"
        Me.col05_f08cNamaMaterial_v50.Visible = True
        Me.col05_f08cNamaMaterial_v50.VisibleIndex = 4
        Me.col05_f08cNamaMaterial_v50.Width = 112
        '
        'col06_f10cNamaKadar_v50
        '
        Me.col06_f10cNamaKadar_v50.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col06_f10cNamaKadar_v50.AppearanceHeader.Options.UseFont = True
        Me.col06_f10cNamaKadar_v50.Caption = "Kadar"
        Me.col06_f10cNamaKadar_v50.ColumnEdit = Me._rscol06_f10cNamaKadar_v50
        Me.col06_f10cNamaKadar_v50.MinWidth = 30
        Me.col06_f10cNamaKadar_v50.Name = "col06_f10cNamaKadar_v50"
        Me.col06_f10cNamaKadar_v50.Visible = True
        Me.col06_f10cNamaKadar_v50.VisibleIndex = 5
        Me.col06_f10cNamaKadar_v50.Width = 112
        '
        '_rscol06_f10cNamaKadar_v50
        '
        Me._rscol06_f10cNamaKadar_v50.AutoHeight = False
        Me._rscol06_f10cNamaKadar_v50.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._rscol06_f10cNamaKadar_v50.Name = "_rscol06_f10cNamaKadar_v50"
        '
        'col07_f12cNamaColor_v50
        '
        Me.col07_f12cNamaColor_v50.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col07_f12cNamaColor_v50.AppearanceHeader.Options.UseFont = True
        Me.col07_f12cNamaColor_v50.Caption = "Color"
        Me.col07_f12cNamaColor_v50.MinWidth = 30
        Me.col07_f12cNamaColor_v50.Name = "col07_f12cNamaColor_v50"
        Me.col07_f12cNamaColor_v50.Visible = True
        Me.col07_f12cNamaColor_v50.VisibleIndex = 6
        Me.col07_f12cNamaColor_v50.Width = 112
        '
        'col08_f14cNamaSize_v50
        '
        Me.col08_f14cNamaSize_v50.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col08_f14cNamaSize_v50.AppearanceHeader.Options.UseFont = True
        Me.col08_f14cNamaSize_v50.Caption = "Size"
        Me.col08_f14cNamaSize_v50.ColumnEdit = Me._rscol08_f14cNamaSize_v50
        Me.col08_f14cNamaSize_v50.MinWidth = 30
        Me.col08_f14cNamaSize_v50.Name = "col08_f14cNamaSize_v50"
        Me.col08_f14cNamaSize_v50.Visible = True
        Me.col08_f14cNamaSize_v50.VisibleIndex = 7
        Me.col08_f14cNamaSize_v50.Width = 112
        '
        '_rscol08_f14cNamaSize_v50
        '
        Me._rscol08_f14cNamaSize_v50.AutoHeight = False
        Me._rscol08_f14cNamaSize_v50.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._rscol08_f14cNamaSize_v50.Name = "_rscol08_f14cNamaSize_v50"
        '
        'col09_f16cNamaEngrave_v50
        '
        Me.col09_f16cNamaEngrave_v50.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col09_f16cNamaEngrave_v50.AppearanceHeader.Options.UseFont = True
        Me.col09_f16cNamaEngrave_v50.Caption = "Engrave"
        Me.col09_f16cNamaEngrave_v50.MinWidth = 30
        Me.col09_f16cNamaEngrave_v50.Name = "col09_f16cNamaEngrave_v50"
        Me.col09_f16cNamaEngrave_v50.Visible = True
        Me.col09_f16cNamaEngrave_v50.VisibleIndex = 8
        Me.col09_f16cNamaEngrave_v50.Width = 112
        '
        'col010_f18cNamaGender_v50
        '
        Me.col010_f18cNamaGender_v50.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col010_f18cNamaGender_v50.AppearanceHeader.Options.UseFont = True
        Me.col010_f18cNamaGender_v50.Caption = "Gender"
        Me.col010_f18cNamaGender_v50.MinWidth = 30
        Me.col010_f18cNamaGender_v50.Name = "col010_f18cNamaGender_v50"
        Me.col010_f18cNamaGender_v50.Visible = True
        Me.col010_f18cNamaGender_v50.VisibleIndex = 9
        Me.col010_f18cNamaGender_v50.Width = 112
        '
        'col011_f20cNamaPlating_v50
        '
        Me.col011_f20cNamaPlating_v50.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col011_f20cNamaPlating_v50.AppearanceHeader.Options.UseFont = True
        Me.col011_f20cNamaPlating_v50.Caption = "Plating"
        Me.col011_f20cNamaPlating_v50.MinWidth = 30
        Me.col011_f20cNamaPlating_v50.Name = "col011_f20cNamaPlating_v50"
        Me.col011_f20cNamaPlating_v50.Visible = True
        Me.col011_f20cNamaPlating_v50.VisibleIndex = 10
        Me.col011_f20cNamaPlating_v50.Width = 112
        '
        'col012_f22cNamaFinishing_v50
        '
        Me.col012_f22cNamaFinishing_v50.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col012_f22cNamaFinishing_v50.AppearanceHeader.Options.UseFont = True
        Me.col012_f22cNamaFinishing_v50.Caption = "Finising"
        Me.col012_f22cNamaFinishing_v50.MinWidth = 30
        Me.col012_f22cNamaFinishing_v50.Name = "col012_f22cNamaFinishing_v50"
        Me.col012_f22cNamaFinishing_v50.Visible = True
        Me.col012_f22cNamaFinishing_v50.VisibleIndex = 11
        Me.col012_f22cNamaFinishing_v50.Width = 112
        '
        'col013_f24cNamaStoneType_v50
        '
        Me.col013_f24cNamaStoneType_v50.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col013_f24cNamaStoneType_v50.AppearanceHeader.Options.UseFont = True
        Me.col013_f24cNamaStoneType_v50.Caption = "Stone Type"
        Me.col013_f24cNamaStoneType_v50.MinWidth = 30
        Me.col013_f24cNamaStoneType_v50.Name = "col013_f24cNamaStoneType_v50"
        Me.col013_f24cNamaStoneType_v50.Visible = True
        Me.col013_f24cNamaStoneType_v50.VisibleIndex = 12
        Me.col013_f24cNamaStoneType_v50.Width = 112
        '
        'col014_f26cNamaStoneColor_v50
        '
        Me.col014_f26cNamaStoneColor_v50.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col014_f26cNamaStoneColor_v50.AppearanceHeader.Options.UseFont = True
        Me.col014_f26cNamaStoneColor_v50.Caption = "Stone Color"
        Me.col014_f26cNamaStoneColor_v50.MinWidth = 30
        Me.col014_f26cNamaStoneColor_v50.Name = "col014_f26cNamaStoneColor_v50"
        Me.col014_f26cNamaStoneColor_v50.Visible = True
        Me.col014_f26cNamaStoneColor_v50.VisibleIndex = 13
        Me.col014_f26cNamaStoneColor_v50.Width = 112
        '
        'col015_f28cNamaFinding_v50
        '
        Me.col015_f28cNamaFinding_v50.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col015_f28cNamaFinding_v50.AppearanceHeader.Options.UseFont = True
        Me.col015_f28cNamaFinding_v50.Caption = "Finding"
        Me.col015_f28cNamaFinding_v50.MinWidth = 30
        Me.col015_f28cNamaFinding_v50.Name = "col015_f28cNamaFinding_v50"
        Me.col015_f28cNamaFinding_v50.Visible = True
        Me.col015_f28cNamaFinding_v50.VisibleIndex = 14
        Me.col015_f28cNamaFinding_v50.Width = 112
        '
        'col016_f01objGambar
        '
        Me.col016_f01objGambar.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col016_f01objGambar.AppearanceHeader.Options.UseFont = True
        Me.col016_f01objGambar.Caption = "Image"
        Me.col016_f01objGambar.MinWidth = 30
        Me.col016_f01objGambar.Name = "col016_f01objGambar"
        Me.col016_f01objGambar.Visible = True
        Me.col016_f01objGambar.VisibleIndex = 15
        Me.col016_f01objGambar.Width = 112
        '
        'col017_f42dCreatedDate
        '
        Me.col017_f42dCreatedDate.Caption = "Created"
        Me.col017_f42dCreatedDate.MinWidth = 30
        Me.col017_f42dCreatedDate.Name = "col017_f42dCreatedDate"
        Me.col017_f42dCreatedDate.Visible = True
        Me.col017_f42dCreatedDate.VisibleIndex = 16
        Me.col017_f42dCreatedDate.Width = 112
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.Root.Name = "Root"
        Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.Root.Size = New System.Drawing.Size(1215, 538)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me._gcProduct
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1215, 538)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'uc06GridProduct
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "uc06GridProduct"
        Me.Size = New System.Drawing.Size(1215, 538)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me._gcProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._gvProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._rscol06_f10cNamaKadar_v50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._rscol08_f14cNamaSize_v50, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents _gcProduct As DevExpress.XtraGrid.GridControl
    Friend WithEvents _gvProduct As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col01_k01cKodeProduct_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col02_f01cNamaProduct_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col03_f04cNamaItemProduct_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col04_f06cNamaBrand_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col05_f08cNamaMaterial_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col06_f10cNamaKadar_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col07_f12cNamaColor_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col08_f14cNamaSize_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents _rscol08_f14cNamaSize_v50 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents col09_f16cNamaEngrave_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col010_f18cNamaGender_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col011_f20cNamaPlating_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col012_f22cNamaFinishing_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col013_f24cNamaStoneType_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col014_f26cNamaStoneColor_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col015_f28cNamaFinding_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col016_f01objGambar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents _rscol06_f10cNamaKadar_v50 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents col017_f42dCreatedDate As DevExpress.XtraGrid.Columns.GridColumn
End Class
