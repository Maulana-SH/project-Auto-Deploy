<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm59KatalogProductbrj
    Inherits DevExpress.XtraEditors.XtraForm

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
'Genrate initcomponent
'NOTE: The following procedure is required by the Windows Form Designer
'It can be modified using the Windows Form Designer. 
'Do not modify it using the code editor.
<System.Diagnostics.DebuggerStepThrough()>
Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm59KatalogProductbrj))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.TileView1 = New DevExpress.XtraGrid.Views.Tile.TileView()
        Me.gcCol01_k02String = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.gcCol02_f02String = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.gcCol03_f06String = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.gcCol04_f08String = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.gcCol05_f10String = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.gcCol06_f12String = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.gcCol07_f16String = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.gcCol08_f20String = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.gcCol09_f22String = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.gcCol10_Berat = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.gcCol11_HargaBarcode = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.gcCol12_ImgProduct = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.rpgcCol12_ImgProduct = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TileView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rpgcCol12_ImgProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(944, 546)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(12, 48)
        Me.GridControl1.MainView = Me.TileView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rpgcCol12_ImgProduct})
        Me.GridControl1.Size = New System.Drawing.Size(920, 486)
        Me.GridControl1.TabIndex = 8
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.TileView1})
        '
        'TileView1
        '
        Me.TileView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.gcCol01_k02String, Me.gcCol02_f02String, Me.gcCol03_f06String, Me.gcCol04_f08String, Me.gcCol05_f10String, Me.gcCol06_f12String, Me.gcCol07_f16String, Me.gcCol08_f20String, Me.gcCol09_f22String, Me.gcCol10_Berat, Me.gcCol11_HargaBarcode, Me.gcCol12_ImgProduct})
        Me.TileView1.GridControl = Me.GridControl1
        Me.TileView1.Name = "TileView1"
        Me.TileView1.OptionsTiles.ItemSize = New System.Drawing.Size(248, 350)
        Me.TileView1.OptionsTiles.RowCount = 0
        Me.TileView1.TileHtmlTemplate.Styles = resources.GetString("TileView1.TileHtmlTemplate.Styles")
        Me.TileView1.TileHtmlTemplate.Template = resources.GetString("TileView1.TileHtmlTemplate.Template")
        '
        'gcCol01_k02String
        '
        Me.gcCol01_k02String.Caption = "SKU"
        Me.gcCol01_k02String.MinWidth = 50
        Me.gcCol01_k02String.Name = "gcCol01_k02String"
        Me.gcCol01_k02String.Visible = True
        Me.gcCol01_k02String.VisibleIndex = 0
        Me.gcCol01_k02String.Width = 100
        '
        'gcCol02_f02String
        '
        Me.gcCol02_f02String.Caption = "Master Code"
        Me.gcCol02_f02String.MinWidth = 50
        Me.gcCol02_f02String.Name = "gcCol02_f02String"
        Me.gcCol02_f02String.Visible = True
        Me.gcCol02_f02String.VisibleIndex = 1
        Me.gcCol02_f02String.Width = 100
        '
        'gcCol03_f06String
        '
        Me.gcCol03_f06String.Caption = "Order Type"
        Me.gcCol03_f06String.MinWidth = 50
        Me.gcCol03_f06String.Name = "gcCol03_f06String"
        Me.gcCol03_f06String.Visible = True
        Me.gcCol03_f06String.VisibleIndex = 2
        Me.gcCol03_f06String.Width = 100
        '
        'gcCol04_f08String
        '
        Me.gcCol04_f08String.Caption = "Warna"
        Me.gcCol04_f08String.MinWidth = 50
        Me.gcCol04_f08String.Name = "gcCol04_f08String"
        Me.gcCol04_f08String.Visible = True
        Me.gcCol04_f08String.VisibleIndex = 3
        Me.gcCol04_f08String.Width = 100
        '
        'gcCol05_f10String
        '
        Me.gcCol05_f10String.Caption = "Kadar"
        Me.gcCol05_f10String.MinWidth = 50
        Me.gcCol05_f10String.Name = "gcCol05_f10String"
        Me.gcCol05_f10String.Visible = True
        Me.gcCol05_f10String.VisibleIndex = 4
        Me.gcCol05_f10String.Width = 100
        '
        'gcCol06_f12String
        '
        Me.gcCol06_f12String.Caption = "Item"
        Me.gcCol06_f12String.MinWidth = 50
        Me.gcCol06_f12String.Name = "gcCol06_f12String"
        Me.gcCol06_f12String.Visible = True
        Me.gcCol06_f12String.VisibleIndex = 5
        Me.gcCol06_f12String.Width = 100
        '
        'gcCol07_f16String
        '
        Me.gcCol07_f16String.Caption = "Brand"
        Me.gcCol07_f16String.MinWidth = 50
        Me.gcCol07_f16String.Name = "gcCol07_f16String"
        Me.gcCol07_f16String.Visible = True
        Me.gcCol07_f16String.VisibleIndex = 6
        Me.gcCol07_f16String.Width = 100
        '
        'gcCol08_f20String
        '
        Me.gcCol08_f20String.Caption = "Gender"
        Me.gcCol08_f20String.MinWidth = 50
        Me.gcCol08_f20String.Name = "gcCol08_f20String"
        Me.gcCol08_f20String.Visible = True
        Me.gcCol08_f20String.VisibleIndex = 7
        Me.gcCol08_f20String.Width = 100
        '
        'gcCol09_f22String
        '
        Me.gcCol09_f22String.Caption = "Egrave"
        Me.gcCol09_f22String.MinWidth = 50
        Me.gcCol09_f22String.Name = "gcCol09_f22String"
        Me.gcCol09_f22String.Visible = True
        Me.gcCol09_f22String.VisibleIndex = 8
        Me.gcCol09_f22String.Width = 100
        '
        'gcCol10_Berat
        '
        Me.gcCol10_Berat.Caption = "Berat"
        Me.gcCol10_Berat.DisplayFormat.FormatString = "n2"
        Me.gcCol10_Berat.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.gcCol10_Berat.MinWidth = 50
        Me.gcCol10_Berat.Name = "gcCol10_Berat"
        Me.gcCol10_Berat.Visible = True
        Me.gcCol10_Berat.VisibleIndex = 9
        Me.gcCol10_Berat.Width = 100
        '
        'gcCol11_HargaBarcode
        '
        Me.gcCol11_HargaBarcode.Caption = "HargaBarcode"
        Me.gcCol11_HargaBarcode.MinWidth = 50
        Me.gcCol11_HargaBarcode.Name = "gcCol11_HargaBarcode"
        Me.gcCol11_HargaBarcode.Visible = True
        Me.gcCol11_HargaBarcode.VisibleIndex = 10
        Me.gcCol11_HargaBarcode.Width = 100
        '
        'gcCol12_ImgProduct
        '
        Me.gcCol12_ImgProduct.Caption = "ImgProduct"
        Me.gcCol12_ImgProduct.ColumnEdit = Me.rpgcCol12_ImgProduct
        Me.gcCol12_ImgProduct.MinWidth = 50
        Me.gcCol12_ImgProduct.Name = "gcCol12_ImgProduct"
        Me.gcCol12_ImgProduct.Visible = True
        Me.gcCol12_ImgProduct.VisibleIndex = 11
        Me.gcCol12_ImgProduct.Width = 100
        '
        'rpgcCol12_ImgProduct
        '
        Me.rpgcCol12_ImgProduct.Name = "rpgcCol12_ImgProduct"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(112, 32)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 9
        Me.SimpleButton1.Text = "SimpleButton1"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem5, Me.EmptySpaceItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(944, 546)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 36)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(924, 490)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.SimpleButton1
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(116, 36)
        Me.LayoutControlItem5.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(116, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(808, 36)
        '
        'frm59KatalogProductbrj
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(944, 546)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frm59KatalogProductbrj"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TileView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rpgcCol12_ImgProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    'Genrate Deklarasi compnent
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
     Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents rpgcCol12_ImgProduct As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents TileView1 As DevExpress.XtraGrid.Views.Tile.TileView
    Friend WithEvents gcCol01_k02String As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents gcCol02_f02String As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents gcCol03_f06String As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents gcCol04_f08String As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents gcCol05_f10String As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents gcCol06_f12String As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents gcCol07_f16String As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents gcCol08_f20String As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents gcCol09_f22String As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents gcCol10_Berat As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents gcCol11_HargaBarcode As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents gcCol12_ImgProduct As DevExpress.XtraGrid.Columns.TileViewColumn
End Class

' ********** End off Generate File from clsGenerateGUI .NET **********
