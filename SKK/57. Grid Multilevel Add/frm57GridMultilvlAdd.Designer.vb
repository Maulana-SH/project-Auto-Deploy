<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm57GridMultilvlAdd
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
        Dim GridLevelNode2 As DevExpress.XtraGrid.GridLevelNode = New DevExpress.XtraGrid.GridLevelNode()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.GridControl2 = New DevExpress.XtraGrid.GridControl()
        Me.GridView2 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col01_LevelBOM = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col02_ParentLevel = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col03_Nama = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col04_Qty = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col05_Berat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col06_TotalBerat = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rscol06_BeratMaterial = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.rscol07_Qty = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.rscol08_TotalBeratMaterial = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.btnAddRoot = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDelet = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGetFlat = New DevExpress.XtraEditors.SimpleButton()
        Me.btnClear = New DevExpress.XtraEditors.SimpleButton()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.TabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rscol06_BeratMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rscol07_Qty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rscol08_TotalBeratMaterial, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.GridControl2)
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Controls.Add(Me.btnAddRoot)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.btnDelet)
        Me.LayoutControl1.Controls.Add(Me.btnGetFlat)
        Me.LayoutControl1.Controls.Add(Me.btnClear)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1037, 637)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'GridControl2
        '
        Me.GridControl2.Location = New System.Drawing.Point(24, 113)
        Me.GridControl2.MainView = Me.GridView2
        Me.GridControl2.Name = "GridControl2"
        Me.GridControl2.Size = New System.Drawing.Size(989, 464)
        Me.GridControl2.TabIndex = 8
        Me.GridControl2.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView2})
        '
        'GridView2
        '
        Me.GridView2.GridControl = Me.GridControl2
        Me.GridView2.Name = "GridView2"
        '
        'GridControl1
        '
        GridLevelNode2.RelationName = "Level1"
        Me.GridControl1.LevelTree.Nodes.AddRange(New DevExpress.XtraGrid.GridLevelNode() {GridLevelNode2})
        Me.GridControl1.Location = New System.Drawing.Point(24, 113)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rscol06_BeratMaterial, Me.rscol07_Qty, Me.rscol08_TotalBeratMaterial})
        Me.GridControl1.Size = New System.Drawing.Size(989, 500)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col01_LevelBOM, Me.col02_ParentLevel, Me.col03_Nama, Me.col04_Qty, Me.col05_Berat, Me.col06_TotalBerat})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'col01_LevelBOM
        '
        Me.col01_LevelBOM.Caption = "lvl"
        Me.col01_LevelBOM.MinWidth = 30
        Me.col01_LevelBOM.Name = "col01_LevelBOM"
        Me.col01_LevelBOM.Width = 112
        '
        'col02_ParentLevel
        '
        Me.col02_ParentLevel.Caption = "Parent"
        Me.col02_ParentLevel.MinWidth = 30
        Me.col02_ParentLevel.Name = "col02_ParentLevel"
        Me.col02_ParentLevel.Width = 112
        '
        'col03_Nama
        '
        Me.col03_Nama.Caption = "Nama"
        Me.col03_Nama.MinWidth = 30
        Me.col03_Nama.Name = "col03_Nama"
        Me.col03_Nama.Visible = True
        Me.col03_Nama.VisibleIndex = 0
        Me.col03_Nama.Width = 112
        '
        'col04_Qty
        '
        Me.col04_Qty.Caption = "QTY"
        Me.col04_Qty.MinWidth = 30
        Me.col04_Qty.Name = "col04_Qty"
        Me.col04_Qty.Visible = True
        Me.col04_Qty.VisibleIndex = 1
        Me.col04_Qty.Width = 112
        '
        'col05_Berat
        '
        Me.col05_Berat.Caption = "Berat"
        Me.col05_Berat.MinWidth = 30
        Me.col05_Berat.Name = "col05_Berat"
        Me.col05_Berat.Visible = True
        Me.col05_Berat.VisibleIndex = 2
        Me.col05_Berat.Width = 112
        '
        'col06_TotalBerat
        '
        Me.col06_TotalBerat.Caption = "Total"
        Me.col06_TotalBerat.MinWidth = 30
        Me.col06_TotalBerat.Name = "col06_TotalBerat"
        Me.col06_TotalBerat.Visible = True
        Me.col06_TotalBerat.VisibleIndex = 3
        Me.col06_TotalBerat.Width = 112
        '
        'rscol06_BeratMaterial
        '
        Me.rscol06_BeratMaterial.AutoHeight = False
        Me.rscol06_BeratMaterial.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rscol06_BeratMaterial.Name = "rscol06_BeratMaterial"
        '
        'rscol07_Qty
        '
        Me.rscol07_Qty.AutoHeight = False
        Me.rscol07_Qty.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rscol07_Qty.Name = "rscol07_Qty"
        '
        'rscol08_TotalBeratMaterial
        '
        Me.rscol08_TotalBeratMaterial.AutoHeight = False
        Me.rscol08_TotalBeratMaterial.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rscol08_TotalBeratMaterial.Name = "rscol08_TotalBeratMaterial"
        '
        'btnAddRoot
        '
        Me.btnAddRoot.Location = New System.Drawing.Point(12, 12)
        Me.btnAddRoot.Name = "btnAddRoot"
        Me.btnAddRoot.Size = New System.Drawing.Size(250, 32)
        Me.btnAddRoot.StyleController = Me.LayoutControl1
        Me.btnAddRoot.TabIndex = 5
        Me.btnAddRoot.Text = "Delete Rows"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(824, 12)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(201, 32)
        Me.SimpleButton2.StyleController = Me.LayoutControl1
        Me.SimpleButton2.TabIndex = 6
        Me.SimpleButton2.Text = "Get Flatt Datatables"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(711, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(109, 32)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 7
        Me.SimpleButton1.Text = "clear"
        '
        'btnDelet
        '
        Me.btnDelet.Location = New System.Drawing.Point(24, 581)
        Me.btnDelet.Name = "btnDelet"
        Me.btnDelet.Size = New System.Drawing.Size(304, 32)
        Me.btnDelet.StyleController = Me.LayoutControl1
        Me.btnDelet.TabIndex = 9
        Me.btnDelet.Text = "Delete Selected"
        '
        'btnGetFlat
        '
        Me.btnGetFlat.Location = New System.Drawing.Point(578, 581)
        Me.btnGetFlat.Name = "btnGetFlat"
        Me.btnGetFlat.Size = New System.Drawing.Size(435, 32)
        Me.btnGetFlat.StyleController = Me.LayoutControl1
        Me.btnGetFlat.TabIndex = 10
        Me.btnGetFlat.Text = "Get Flat Datatables"
        '
        'btnClear
        '
        Me.btnClear.Location = New System.Drawing.Point(332, 581)
        Me.btnClear.Name = "btnClear"
        Me.btnClear.Size = New System.Drawing.Size(242, 32)
        Me.btnClear.StyleController = Me.LayoutControl1
        Me.btnClear.TabIndex = 11
        Me.btnClear.Text = " Clear"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.EmptySpaceItem1, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.EmptySpaceItem2, Me.TabbedControlGroup1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1037, 637)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.btnAddRoot
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(254, 36)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 36)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(1017, 20)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.SimpleButton2
        Me.LayoutControlItem3.Location = New System.Drawing.Point(812, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(205, 36)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.SimpleButton1
        Me.LayoutControlItem4.Location = New System.Drawing.Point(699, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(113, 36)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(254, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(445, 36)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'TabbedControlGroup1
        '
        Me.TabbedControlGroup1.Location = New System.Drawing.Point(0, 56)
        Me.TabbedControlGroup1.Name = "TabbedControlGroup1"
        Me.TabbedControlGroup1.SelectedTabPage = Me.LayoutControlGroup1
        Me.TabbedControlGroup1.Size = New System.Drawing.Size(1017, 561)
        Me.TabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup1, Me.LayoutControlGroup2})
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5, Me.LayoutControlItem7, Me.LayoutControlItem6, Me.LayoutControlItem8})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(993, 504)
        Me.LayoutControlGroup2.Text = "USING CLASS"
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.GridControl2
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(993, 468)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.btnGetFlat
        Me.LayoutControlItem7.Location = New System.Drawing.Point(554, 468)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(439, 36)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.btnDelet
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 468)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(308, 36)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.btnClear
        Me.LayoutControlItem8.Location = New System.Drawing.Point(308, 468)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(246, 36)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(993, 504)
        Me.LayoutControlGroup1.Text = "UISNG manual"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(993, 504)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'frm57GridMultilvlAdd
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1037, 637)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frm57GridMultilvlAdd"
        Me.Text = "frm57GridMultilvlAdd"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridControl2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rscol06_BeratMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rscol07_Qty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rscol08_TotalBeratMaterial, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents rscol06_BeratMaterial As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents rscol07_Qty As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents rscol08_TotalBeratMaterial As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnAddRoot As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents col01_LevelBOM As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col02_ParentLevel As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col03_Nama As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col04_Qty As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col05_Berat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col06_TotalBerat As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridControl2 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView2 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents TabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnDelet As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGetFlat As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnClear As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
End Class
