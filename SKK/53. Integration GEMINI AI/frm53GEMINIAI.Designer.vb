<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm53GEMINIAI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm53GEMINIAI))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.TileView1 = New DevExpress.XtraGrid.Views.Tile.TileView()
        Me.col01_K01IdUser_v50 = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.col02_f01Pesan = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.col03_f30SendDate = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me._04RichTextbox = New System.Windows.Forms.RichTextBox()
        Me._03RichEdit = New DevExpress.XtraRichEdit.RichEditControl()
        Me.btnSend = New DevExpress.XtraEditors.SimpleButton()
        Me._01prompt = New DevExpress.XtraEditors.MemoEdit()
        Me._02Response = New System.Windows.Forms.RichTextBox()
        Me.btnSkip = New DevExpress.XtraEditors.SimpleButton()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.TabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TileView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._01prompt.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Controls.Add(Me._04RichTextbox)
        Me.LayoutControl1.Controls.Add(Me._03RichEdit)
        Me.LayoutControl1.Controls.Add(Me.btnSend)
        Me.LayoutControl1.Controls.Add(Me._01prompt)
        Me.LayoutControl1.Controls.Add(Me._02Response)
        Me.LayoutControl1.Controls.Add(Me.btnSkip)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1446, 681)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(24, 57)
        Me.GridControl1.MainView = Me.TileView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1398, 454)
        Me.GridControl1.TabIndex = 10
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.TileView1})
        '
        'TileView1
        '
        Me.TileView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col01_K01IdUser_v50, Me.col02_f01Pesan, Me.col03_f30SendDate})
        Me.TileView1.GridControl = Me.GridControl1
        Me.TileView1.Name = "TileView1"
        Me.TileView1.OptionsHtmlTemplate.ItemAutoHeight = True
        Me.TileView1.OptionsTiles.IndentBetweenGroups = 6
        Me.TileView1.OptionsTiles.ItemPadding = New System.Windows.Forms.Padding(5)
        Me.TileView1.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List
        Me.TileView1.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TileView1.OptionsTiles.Padding = New System.Windows.Forms.Padding(13)
        Me.TileView1.TileHtmlTemplate.Styles = resources.GetString("TileView1.TileHtmlTemplate.Styles")
        Me.TileView1.TileHtmlTemplate.Template = resources.GetString("TileView1.TileHtmlTemplate.Template")
        '
        'col01_K01IdUser_v50
        '
        Me.col01_K01IdUser_v50.Caption = "Id USer"
        Me.col01_K01IdUser_v50.MinWidth = 30
        Me.col01_K01IdUser_v50.Name = "col01_K01IdUser_v50"
        Me.col01_K01IdUser_v50.Visible = True
        Me.col01_K01IdUser_v50.VisibleIndex = 0
        Me.col01_K01IdUser_v50.Width = 112
        '
        'col02_f01Pesan
        '
        Me.col02_f01Pesan.Caption = "Pesan"
        Me.col02_f01Pesan.MinWidth = 30
        Me.col02_f01Pesan.Name = "col02_f01Pesan"
        Me.col02_f01Pesan.Visible = True
        Me.col02_f01Pesan.VisibleIndex = 1
        Me.col02_f01Pesan.Width = 112
        '
        'col03_f30SendDate
        '
        Me.col03_f30SendDate.Caption = "Date"
        Me.col03_f30SendDate.MinWidth = 30
        Me.col03_f30SendDate.Name = "col03_f30SendDate"
        Me.col03_f30SendDate.Visible = True
        Me.col03_f30SendDate.VisibleIndex = 2
        Me.col03_f30SendDate.Width = 112
        '
        '_04RichTextbox
        '
        Me._04RichTextbox.Location = New System.Drawing.Point(24, 57)
        Me._04RichTextbox.Name = "_04RichTextbox"
        Me._04RichTextbox.Size = New System.Drawing.Size(1398, 454)
        Me._04RichTextbox.TabIndex = 8
        Me._04RichTextbox.Text = ""
        '
        '_03RichEdit
        '
        Me._03RichEdit.Appearance.Text.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._03RichEdit.Appearance.Text.Options.UseFont = True
        Me._03RichEdit.Location = New System.Drawing.Point(24, 57)
        Me._03RichEdit.Name = "_03RichEdit"
        Me._03RichEdit.Options.DocumentSaveOptions.CurrentFormat = DevExpress.XtraRichEdit.DocumentFormat.PlainText
        Me._03RichEdit.Options.HorizontalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden
        Me._03RichEdit.Options.VerticalRuler.Visibility = DevExpress.XtraRichEdit.RichEditRulerVisibility.Hidden
        Me._03RichEdit.Size = New System.Drawing.Size(1398, 454)
        Me._03RichEdit.TabIndex = 7
        Me._03RichEdit.Text = "RichEditControl1"
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(1252, 637)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(182, 32)
        Me.btnSend.StyleController = Me.LayoutControl1
        Me.btnSend.TabIndex = 6
        Me.btnSend.Text = "Send"
        '
        '_01prompt
        '
        Me._01prompt.Location = New System.Drawing.Point(12, 549)
        Me._01prompt.Name = "_01prompt"
        Me._01prompt.Size = New System.Drawing.Size(1236, 120)
        Me._01prompt.StyleController = Me.LayoutControl1
        Me._01prompt.TabIndex = 5
        '
        '_02Response
        '
        Me._02Response.Location = New System.Drawing.Point(24, 57)
        Me._02Response.Name = "_02Response"
        Me._02Response.Size = New System.Drawing.Size(1398, 454)
        Me._02Response.TabIndex = 4
        Me._02Response.Text = ""
        '
        'btnSkip
        '
        Me.btnSkip.Location = New System.Drawing.Point(1252, 601)
        Me.btnSkip.Name = "btnSkip"
        Me.btnSkip.Size = New System.Drawing.Size(182, 32)
        Me.btnSkip.StyleController = Me.LayoutControl1
        Me.btnSkip.TabIndex = 9
        Me.btnSkip.Text = "SKIP"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.EmptySpaceItem1, Me.TabbedControlGroup1, Me.LayoutControlItem6})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1446, 681)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me._01prompt
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 515)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(1240, 146)
        Me.LayoutControlItem2.Text = "Prompt"
        Me.LayoutControlItem2.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(52, 19)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.btnSend
        Me.LayoutControlItem3.Location = New System.Drawing.Point(1240, 625)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(186, 36)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(1240, 515)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(186, 74)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'TabbedControlGroup1
        '
        Me.TabbedControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.TabbedControlGroup1.Name = "TabbedControlGroup1"
        Me.TabbedControlGroup1.SelectedTabPage = Me.LayoutControlGroup4
        Me.TabbedControlGroup1.Size = New System.Drawing.Size(1426, 515)
        Me.TabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlGroup3, Me.LayoutControlGroup1, Me.LayoutControlGroup4})
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(1402, 458)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.GridControl1
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(1402, 458)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1402, 458)
        Me.LayoutControlGroup2.Text = "Respons Default MD"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me._02Response
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1402, 458)
        Me.LayoutControlItem1.Text = "Respons MD"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(1402, 458)
        Me.LayoutControlGroup3.Text = "Response Convert Html Text"
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me._04RichTextbox
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(1402, 458)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1402, 458)
        Me.LayoutControlGroup1.Text = "Respons Md Convert To HTML"
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me._03RichEdit
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(1402, 458)
        Me.LayoutControlItem4.Text = "Response"
        Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.btnSkip
        Me.LayoutControlItem6.Location = New System.Drawing.Point(1240, 589)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(186, 36)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'frm53GEMINIAI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1446, 681)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frm53GEMINIAI"
        Me.Text = "frm53GEMINIAI"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TileView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._01prompt.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents btnSend As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents _01prompt As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents _02Response As RichTextBox
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents _03RichEdit As DevExpress.XtraRichEdit.RichEditControl
    Friend WithEvents _04RichTextbox As RichTextBox
    Friend WithEvents btnSkip As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TileView1 As DevExpress.XtraGrid.Views.Tile.TileView
    Friend WithEvents col01_K01IdUser_v50 As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents col02_f01Pesan As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents col03_f30SendDate As DevExpress.XtraGrid.Columns.TileViewColumn
End Class
