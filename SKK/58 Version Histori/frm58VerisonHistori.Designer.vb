<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm58VerisonHistori
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm58VerisonHistori))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.GridSplitContainer1 = New DevExpress.XtraGrid.GridSplitContainer()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.TileView1 = New DevExpress.XtraGrid.Views.Tile.TileView()
        Me.col01_f03nPatchVersion_int = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.col02_f00cBuildNumber_v50 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.col03_f04cNotesBuild_vMax = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.rscol03_f04cNotesBuild_vMax = New DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit()
        Me.col04_f10dCreated_datetime = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.col05_f11cPatchCode_v50 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.col06_k01cVersionApp_v50 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.col07_f01nMajorVersion_int = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.col08_f02nMinorVersion_int = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridSplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridSplitContainer1.Panel1.SuspendLayout()
        CType(Me.GridSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GridSplitContainer1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TileView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rscol03_f04cNotesBuild_vMax, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.GridSplitContainer1)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1523, 595)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'GridSplitContainer1
        '
        Me.GridSplitContainer1.Grid = Me.GridControl1
        Me.GridSplitContainer1.Location = New System.Drawing.Point(12, 48)
        Me.GridSplitContainer1.Name = "GridSplitContainer1"
        '
        'GridSplitContainer1.Panel1
        '
        Me.GridSplitContainer1.Panel1.Controls.Add(Me.GridControl1)
        Me.GridSplitContainer1.Size = New System.Drawing.Size(1499, 535)
        Me.GridSplitContainer1.TabIndex = 6
        '
        'GridControl1
        '
        Me.GridControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.GridControl1.Location = New System.Drawing.Point(0, 0)
        Me.GridControl1.MainView = Me.TileView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rscol03_f04cNotesBuild_vMax})
        Me.GridControl1.Size = New System.Drawing.Size(1499, 535)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.TileView1})
        '
        'TileView1
        '
        Me.TileView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col01_f03nPatchVersion_int, Me.col02_f00cBuildNumber_v50, Me.col03_f04cNotesBuild_vMax, Me.col04_f10dCreated_datetime, Me.col05_f11cPatchCode_v50, Me.col06_k01cVersionApp_v50, Me.col07_f01nMajorVersion_int, Me.col08_f02nMinorVersion_int})
        Me.TileView1.ColumnSet.GroupColumn = Me.col01_f03nPatchVersion_int
        Me.TileView1.GridControl = Me.GridControl1
        Me.TileView1.Name = "TileView1"
        Me.TileView1.OptionsEditForm.AllowHtmlCaptions = True
        Me.TileView1.OptionsHtmlTemplate.AllowContentSelection = DevExpress.Utils.DefaultBoolean.[True]
        Me.TileView1.OptionsTiles.ColumnCount = 1
        Me.TileView1.OptionsTiles.IndentBetweenGroups = 0
        Me.TileView1.OptionsTiles.IndentBetweenItems = 0
        Me.TileView1.OptionsTiles.ItemPadding = New System.Windows.Forms.Padding(0)
        Me.TileView1.OptionsTiles.ItemSize = New System.Drawing.Size(750, 120)
        Me.TileView1.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TileView1.OptionsTiles.Padding = New System.Windows.Forms.Padding(0)
        Me.TileView1.SortInfo.AddRange(New DevExpress.XtraGrid.Columns.GridColumnSortInfo() {New DevExpress.XtraGrid.Columns.GridColumnSortInfo(Me.col01_f03nPatchVersion_int, DevExpress.Data.ColumnSortOrder.Ascending)})
        Me.TileView1.TileHtmlTemplate.Styles = resources.GetString("TileView1.TileHtmlTemplate.Styles")
        Me.TileView1.TileHtmlTemplate.Template = resources.GetString("TileView1.TileHtmlTemplate.Template")
        '
        'col01_f03nPatchVersion_int
        '
        Me.col01_f03nPatchVersion_int.Caption = "Path Version"
        Me.col01_f03nPatchVersion_int.MinWidth = 30
        Me.col01_f03nPatchVersion_int.Name = "col01_f03nPatchVersion_int"
        Me.col01_f03nPatchVersion_int.Visible = True
        Me.col01_f03nPatchVersion_int.VisibleIndex = 0
        Me.col01_f03nPatchVersion_int.Width = 112
        '
        'col02_f00cBuildNumber_v50
        '
        Me.col02_f00cBuildNumber_v50.Caption = "Build Number"
        Me.col02_f00cBuildNumber_v50.MinWidth = 30
        Me.col02_f00cBuildNumber_v50.Name = "col02_f00cBuildNumber_v50"
        Me.col02_f00cBuildNumber_v50.Visible = True
        Me.col02_f00cBuildNumber_v50.VisibleIndex = 1
        Me.col02_f00cBuildNumber_v50.Width = 112
        '
        'col03_f04cNotesBuild_vMax
        '
        Me.col03_f04cNotesBuild_vMax.Caption = "Notes"
        Me.col03_f04cNotesBuild_vMax.ColumnEdit = Me.rscol03_f04cNotesBuild_vMax
        Me.col03_f04cNotesBuild_vMax.MinWidth = 30
        Me.col03_f04cNotesBuild_vMax.Name = "col03_f04cNotesBuild_vMax"
        Me.col03_f04cNotesBuild_vMax.Visible = True
        Me.col03_f04cNotesBuild_vMax.VisibleIndex = 2
        Me.col03_f04cNotesBuild_vMax.Width = 112
        '
        'rscol03_f04cNotesBuild_vMax
        '
        Me.rscol03_f04cNotesBuild_vMax.AutoHeight = False
        Me.rscol03_f04cNotesBuild_vMax.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.rscol03_f04cNotesBuild_vMax.Name = "rscol03_f04cNotesBuild_vMax"
        '
        'col04_f10dCreated_datetime
        '
        Me.col04_f10dCreated_datetime.Caption = "Ceated"
        Me.col04_f10dCreated_datetime.MinWidth = 30
        Me.col04_f10dCreated_datetime.Name = "col04_f10dCreated_datetime"
        Me.col04_f10dCreated_datetime.Visible = True
        Me.col04_f10dCreated_datetime.VisibleIndex = 3
        Me.col04_f10dCreated_datetime.Width = 112
        '
        'col05_f11cPatchCode_v50
        '
        Me.col05_f11cPatchCode_v50.Caption = "Path Code"
        Me.col05_f11cPatchCode_v50.MinWidth = 30
        Me.col05_f11cPatchCode_v50.Name = "col05_f11cPatchCode_v50"
        Me.col05_f11cPatchCode_v50.Visible = True
        Me.col05_f11cPatchCode_v50.VisibleIndex = 4
        Me.col05_f11cPatchCode_v50.Width = 112
        '
        'col06_k01cVersionApp_v50
        '
        Me.col06_k01cVersionApp_v50.Caption = "Verison"
        Me.col06_k01cVersionApp_v50.MinWidth = 30
        Me.col06_k01cVersionApp_v50.Name = "col06_k01cVersionApp_v50"
        Me.col06_k01cVersionApp_v50.Visible = True
        Me.col06_k01cVersionApp_v50.VisibleIndex = 5
        Me.col06_k01cVersionApp_v50.Width = 112
        '
        'col07_f01nMajorVersion_int
        '
        Me.col07_f01nMajorVersion_int.Caption = "Major"
        Me.col07_f01nMajorVersion_int.MinWidth = 30
        Me.col07_f01nMajorVersion_int.Name = "col07_f01nMajorVersion_int"
        Me.col07_f01nMajorVersion_int.Visible = True
        Me.col07_f01nMajorVersion_int.VisibleIndex = 6
        Me.col07_f01nMajorVersion_int.Width = 112
        '
        'col08_f02nMinorVersion_int
        '
        Me.col08_f02nMinorVersion_int.Caption = "Minor"
        Me.col08_f02nMinorVersion_int.MinWidth = 30
        Me.col08_f02nMinorVersion_int.Name = "col08_f02nMinorVersion_int"
        Me.col08_f02nMinorVersion_int.Visible = True
        Me.col08_f02nMinorVersion_int.VisibleIndex = 7
        Me.col08_f02nMinorVersion_int.Width = 112
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(136, 32)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 5
        Me.SimpleButton1.Text = "SimpleButton1"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.EmptySpaceItem1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1523, 595)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridSplitContainer1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 36)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1503, 539)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.SimpleButton1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(140, 36)
        Me.LayoutControlItem2.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(140, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(1363, 36)
        '
        'frm58VerisonHistori
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1523, 595)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frm58VerisonHistori"
        Me.Text = "frm58VerisonHistori"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridSplitContainer1.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridSplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.GridSplitContainer1.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridSplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GridSplitContainer1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TileView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rscol03_f04cNotesBuild_vMax, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents rscol03_f04cNotesBuild_vMax As DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit
    Friend WithEvents TileView1 As DevExpress.XtraGrid.Views.Tile.TileView
    Friend WithEvents col01_f03nPatchVersion_int As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents col02_f00cBuildNumber_v50 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents col03_f04cNotesBuild_vMax As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents col04_f10dCreated_datetime As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents col05_f11cPatchCode_v50 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents col06_k01cVersionApp_v50 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents col07_f01nMajorVersion_int As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents col08_f02nMinorVersion_int As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents GridSplitContainer1 As DevExpress.XtraGrid.GridSplitContainer
End Class
