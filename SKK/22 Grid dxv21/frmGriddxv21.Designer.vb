<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGriddxv21
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmGriddxv21))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.gcProduk = New DevExpress.XtraGrid.GridControl()
        Me.WinExplorerView1 = New DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView()
        Me.col01_k01cKodeProduct_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col02_f01cNamaProduct_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col03_f01objGambar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rscol03_f01objGambar = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.col04_f04cNamaItemProduct_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.gcProduk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.WinExplorerView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rscol03_f01objGambar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.gcProduk)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1325, 674)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'gcProduk
        '
        Me.gcProduk.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(6)
        Me.gcProduk.Location = New System.Drawing.Point(12, 48)
        Me.gcProduk.MainView = Me.WinExplorerView1
        Me.gcProduk.Margin = New System.Windows.Forms.Padding(6)
        Me.gcProduk.Name = "gcProduk"
        Me.gcProduk.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rscol03_f01objGambar})
        Me.gcProduk.Size = New System.Drawing.Size(1301, 614)
        Me.gcProduk.TabIndex = 4
        Me.gcProduk.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.WinExplorerView1})
        '
        'WinExplorerView1
        '
        Me.WinExplorerView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col01_k01cKodeProduct_v50, Me.col02_f01cNamaProduct_v50, Me.col03_f01objGambar, Me.col04_f04cNamaItemProduct_v50})
        Me.WinExplorerView1.ColumnSet.DescriptionColumn = Me.col02_f01cNamaProduct_v50
        Me.WinExplorerView1.ColumnSet.ExtraLargeImageColumn = Me.col03_f01objGambar
        Me.WinExplorerView1.ColumnSet.LargeImageColumn = Me.col03_f01objGambar
        Me.WinExplorerView1.ColumnSet.SmallImageColumn = Me.col03_f01objGambar
        Me.WinExplorerView1.ColumnSet.TextColumn = Me.col01_k01cKodeProduct_v50
        Me.WinExplorerView1.GridControl = Me.gcProduk
        Me.WinExplorerView1.Name = "WinExplorerView1"
        Me.WinExplorerView1.OptionsView.AllowHtmlText = True
        Me.WinExplorerView1.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateAllContent
        Me.WinExplorerView1.OptionsView.Style = DevExpress.XtraGrid.Views.WinExplorer.WinExplorerViewStyle.Medium
        '
        '
        '
        Me.WinExplorerView1.OptionsViewStyles.ExtraLarge.HtmlTemplate.Template = resources.GetString("WinExplorerView1.OptionsViewStyles.ExtraLarge.HtmlTemplate.Template")
        '
        '
        '
        Me.WinExplorerView1.OptionsViewStyles.Medium.HtmlTemplate.Styles = resources.GetString("WinExplorerView1.OptionsViewStyles.Medium.HtmlTemplate.Styles")
        Me.WinExplorerView1.OptionsViewStyles.Medium.HtmlTemplate.Template = resources.GetString("WinExplorerView1.OptionsViewStyles.Medium.HtmlTemplate.Template")
        '
        'col01_k01cKodeProduct_v50
        '
        Me.col01_k01cKodeProduct_v50.Caption = "Proudtc Code"
        Me.col01_k01cKodeProduct_v50.MinWidth = 67
        Me.col01_k01cKodeProduct_v50.Name = "col01_k01cKodeProduct_v50"
        Me.col01_k01cKodeProduct_v50.Visible = True
        Me.col01_k01cKodeProduct_v50.VisibleIndex = 0
        Me.col01_k01cKodeProduct_v50.Width = 252
        '
        'col02_f01cNamaProduct_v50
        '
        Me.col02_f01cNamaProduct_v50.Caption = "Desc"
        Me.col02_f01cNamaProduct_v50.MinWidth = 67
        Me.col02_f01cNamaProduct_v50.Name = "col02_f01cNamaProduct_v50"
        Me.col02_f01cNamaProduct_v50.Visible = True
        Me.col02_f01cNamaProduct_v50.VisibleIndex = 1
        Me.col02_f01cNamaProduct_v50.Width = 252
        '
        'col03_f01objGambar
        '
        Me.col03_f01objGambar.Caption = "Img"
        Me.col03_f01objGambar.ColumnEdit = Me.rscol03_f01objGambar
        Me.col03_f01objGambar.MinWidth = 67
        Me.col03_f01objGambar.Name = "col03_f01objGambar"
        Me.col03_f01objGambar.Visible = True
        Me.col03_f01objGambar.VisibleIndex = 3
        Me.col03_f01objGambar.Width = 252
        '
        'rscol03_f01objGambar
        '
        Me.rscol03_f01objGambar.Name = "rscol03_f01objGambar"
        '
        'col04_f04cNamaItemProduct_v50
        '
        Me.col04_f04cNamaItemProduct_v50.Caption = "Item"
        Me.col04_f04cNamaItemProduct_v50.MinWidth = 30
        Me.col04_f04cNamaItemProduct_v50.Name = "col04_f04cNamaItemProduct_v50"
        Me.col04_f04cNamaItemProduct_v50.Visible = True
        Me.col04_f04cNamaItemProduct_v50.VisibleIndex = 2
        Me.col04_f04cNamaItemProduct_v50.Width = 112
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 12)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(116, 32)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 5
        Me.SimpleButton1.Text = "REFRESH"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.EmptySpaceItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1325, 674)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.gcProduk
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 36)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1305, 618)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.SimpleButton1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(120, 36)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(120, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(1185, 36)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'frmGriddxv21
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1325, 674)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmGriddxv21"
        Me.Text = "frmGriddxv21"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.gcProduk, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.WinExplorerView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rscol03_f01objGambar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents gcProduk As DevExpress.XtraGrid.GridControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents WinExplorerView1 As DevExpress.XtraGrid.Views.WinExplorer.WinExplorerView
    Friend WithEvents col01_k01cKodeProduct_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col02_f01cNamaProduct_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col03_f01objGambar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents rscol03_f01objGambar As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents col04_f04cNamaItemProduct_v50 As DevExpress.XtraGrid.Columns.GridColumn
End Class
