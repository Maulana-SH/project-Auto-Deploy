<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPOSTAPIProductCode
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.gridProduct = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me._04GetAllData = New System.Windows.Forms.RichTextBox()
        Me._03GetByProductcode = New System.Windows.Forms.RichTextBox()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me._01ProductCode = New DevExpress.XtraEditors.TextEdit()
        Me._02objJSON = New System.Windows.Forms.RichTextBox()
        Me.btnPost = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGetOne = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGetAll = New DevExpress.XtraEditors.SimpleButton()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.gridProduct, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._01ProductCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.gridProduct)
        Me.LayoutControl1.Controls.Add(Me._04GetAllData)
        Me.LayoutControl1.Controls.Add(Me._03GetByProductcode)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me._01ProductCode)
        Me.LayoutControl1.Controls.Add(Me._02objJSON)
        Me.LayoutControl1.Controls.Add(Me.btnPost)
        Me.LayoutControl1.Controls.Add(Me.btnGetOne)
        Me.LayoutControl1.Controls.Add(Me.btnGetAll)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1588, 682)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'gridProduct
        '
        Me.gridProduct.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(4)
        Me.gridProduct.Location = New System.Drawing.Point(12, 48)
        Me.gridProduct.MainView = Me.GridView1
        Me.gridProduct.Margin = New System.Windows.Forms.Padding(4)
        Me.gridProduct.Name = "gridProduct"
        Me.gridProduct.Size = New System.Drawing.Size(1564, 321)
        Me.gridProduct.TabIndex = 12
        Me.gridProduct.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gridProduct
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ColumnAutoWidth = False
        '
        '_04GetAllData
        '
        Me._04GetAllData.Location = New System.Drawing.Point(1102, 395)
        Me._04GetAllData.Name = "_04GetAllData"
        Me._04GetAllData.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me._04GetAllData.Size = New System.Drawing.Size(474, 275)
        Me._04GetAllData.TabIndex = 10
        Me._04GetAllData.Text = ""
        '
        '_03GetByProductcode
        '
        Me._03GetByProductcode.Location = New System.Drawing.Point(548, 395)
        Me._03GetByProductcode.Name = "_03GetByProductcode"
        Me._03GetByProductcode.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me._03GetByProductcode.Size = New System.Drawing.Size(550, 275)
        Me._03GetByProductcode.TabIndex = 8
        Me._03GetByProductcode.Text = ""
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(365, 12)
        Me.SimpleButton1.Margin = New System.Windows.Forms.Padding(4)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(91, 32)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 6
        Me.SimpleButton1.Text = "Get data"
        '
        '_01ProductCode
        '
        Me._01ProductCode.Location = New System.Drawing.Point(165, 12)
        Me._01ProductCode.Margin = New System.Windows.Forms.Padding(4)
        Me._01ProductCode.Name = "_01ProductCode"
        Me._01ProductCode.Size = New System.Drawing.Size(196, 26)
        Me._01ProductCode.StyleController = Me.LayoutControl1
        Me._01ProductCode.TabIndex = 5
        '
        '_02objJSON
        '
        Me._02objJSON.Location = New System.Drawing.Point(12, 395)
        Me._02objJSON.Name = "_02objJSON"
        Me._02objJSON.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical
        Me._02objJSON.Size = New System.Drawing.Size(532, 275)
        Me._02objJSON.TabIndex = 4
        Me._02objJSON.Text = ""
        '
        'btnPost
        '
        Me.btnPost.Location = New System.Drawing.Point(460, 12)
        Me.btnPost.Margin = New System.Windows.Forms.Padding(4)
        Me.btnPost.Name = "btnPost"
        Me.btnPost.Size = New System.Drawing.Size(103, 32)
        Me.btnPost.StyleController = Me.LayoutControl1
        Me.btnPost.TabIndex = 7
        Me.btnPost.Text = "POST data"
        '
        'btnGetOne
        '
        Me.btnGetOne.Location = New System.Drawing.Point(567, 12)
        Me.btnGetOne.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGetOne.Name = "btnGetOne"
        Me.btnGetOne.Size = New System.Drawing.Size(117, 32)
        Me.btnGetOne.StyleController = Me.LayoutControl1
        Me.btnGetOne.TabIndex = 9
        Me.btnGetOne.Text = "Get Product"
        '
        'btnGetAll
        '
        Me.btnGetAll.Location = New System.Drawing.Point(1451, 12)
        Me.btnGetAll.Margin = New System.Windows.Forms.Padding(4)
        Me.btnGetAll.Name = "btnGetAll"
        Me.btnGetAll.Size = New System.Drawing.Size(125, 32)
        Me.btnGetAll.StyleController = Me.LayoutControl1
        Me.btnGetAll.TabIndex = 11
        Me.btnGetAll.Text = "Get All Data"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem1, Me.LayoutControlItem5, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8, Me.EmptySpaceItem1, Me.LayoutControlItem9})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1588, 682)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.SimpleButton1
        Me.LayoutControlItem3.Location = New System.Drawing.Point(353, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(95, 36)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me._01ProductCode
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(353, 36)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(141, 19)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.btnPost
        Me.LayoutControlItem4.Location = New System.Drawing.Point(448, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(107, 36)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me._02objJSON
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 361)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(536, 301)
        Me.LayoutControlItem1.Text = "JSON DATA"
        Me.LayoutControlItem1.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(141, 19)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me._03GetByProductcode
        Me.LayoutControlItem5.Location = New System.Drawing.Point(536, 361)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(554, 301)
        Me.LayoutControlItem5.Text = "Get By Product"
        Me.LayoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(141, 19)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.btnGetOne
        Me.LayoutControlItem6.Location = New System.Drawing.Point(555, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(121, 36)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me._04GetAllData
        Me.LayoutControlItem7.Location = New System.Drawing.Point(1090, 361)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(478, 301)
        Me.LayoutControlItem7.Text = "Get All Product "
        Me.LayoutControlItem7.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(141, 19)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.btnGetAll
        Me.LayoutControlItem8.Location = New System.Drawing.Point(1439, 0)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(129, 36)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(676, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(763, 36)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.gridProduct
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 36)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(1568, 325)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'frmPOSTAPIProductCode
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1588, 682)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmPOSTAPIProductCode"
        Me.Text = "frmPOSTAPIProductCode"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.gridProduct, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._01ProductCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents _02objJSON As RichTextBox
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents _01ProductCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnPost As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnGetOne As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents _03GetByProductcode As RichTextBox
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents _04GetAllData As RichTextBox
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnGetAll As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents gridProduct As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
End Class
