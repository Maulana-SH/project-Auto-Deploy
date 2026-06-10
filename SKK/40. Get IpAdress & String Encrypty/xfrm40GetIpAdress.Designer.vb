<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xfrm40GetIpAdress
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
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col01_k01cUserID_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col02_f01cNamaUser_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col03_f02cKeyPass_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col04_f10cKeyPassOld_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.txtResult = New System.Windows.Forms.RichTextBox()
        Me.t03 = New DevExpress.XtraEditors.TextEdit()
        Me.t02 = New DevExpress.XtraEditors.TextEdit()
        Me.t01 = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t03.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t02.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.t01.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Controls.Add(Me.txtResult)
        Me.LayoutControl1.Controls.Add(Me.t03)
        Me.LayoutControl1.Controls.Add(Me.t02)
        Me.LayoutControl1.Controls.Add(Me.t01)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton3)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton4)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1267, 582)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(553, 180)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(702, 390)
        Me.GridControl1.TabIndex = 11
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col01_k01cUserID_v50, Me.col02_f01cNamaUser_v50, Me.col03_f02cKeyPass_v50, Me.col04_f10cKeyPassOld_v50})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'col01_k01cUserID_v50
        '
        Me.col01_k01cUserID_v50.Caption = "ID user"
        Me.col01_k01cUserID_v50.MinWidth = 30
        Me.col01_k01cUserID_v50.Name = "col01_k01cUserID_v50"
        Me.col01_k01cUserID_v50.Visible = True
        Me.col01_k01cUserID_v50.VisibleIndex = 0
        Me.col01_k01cUserID_v50.Width = 112
        '
        'col02_f01cNamaUser_v50
        '
        Me.col02_f01cNamaUser_v50.Caption = "nama User"
        Me.col02_f01cNamaUser_v50.MinWidth = 30
        Me.col02_f01cNamaUser_v50.Name = "col02_f01cNamaUser_v50"
        Me.col02_f01cNamaUser_v50.Visible = True
        Me.col02_f01cNamaUser_v50.VisibleIndex = 1
        Me.col02_f01cNamaUser_v50.Width = 112
        '
        'col03_f02cKeyPass_v50
        '
        Me.col03_f02cKeyPass_v50.Caption = "pass Encript"
        Me.col03_f02cKeyPass_v50.MinWidth = 30
        Me.col03_f02cKeyPass_v50.Name = "col03_f02cKeyPass_v50"
        Me.col03_f02cKeyPass_v50.Visible = True
        Me.col03_f02cKeyPass_v50.VisibleIndex = 2
        Me.col03_f02cKeyPass_v50.Width = 112
        '
        'col04_f10cKeyPassOld_v50
        '
        Me.col04_f10cKeyPassOld_v50.Caption = "Descrypt"
        Me.col04_f10cKeyPassOld_v50.MinWidth = 30
        Me.col04_f10cKeyPassOld_v50.Name = "col04_f10cKeyPassOld_v50"
        Me.col04_f10cKeyPassOld_v50.Visible = True
        Me.col04_f10cKeyPassOld_v50.VisibleIndex = 3
        Me.col04_f10cKeyPassOld_v50.Width = 112
        '
        'txtResult
        '
        Me.txtResult.Location = New System.Drawing.Point(12, 186)
        Me.txtResult.Name = "txtResult"
        Me.txtResult.Size = New System.Drawing.Size(537, 384)
        Me.txtResult.TabIndex = 7
        Me.txtResult.Text = ""
        '
        't03
        '
        Me.t03.Location = New System.Drawing.Point(655, 66)
        Me.t03.Name = "t03"
        Me.t03.Size = New System.Drawing.Size(588, 26)
        Me.t03.StyleController = Me.LayoutControl1
        Me.t03.TabIndex = 6
        '
        't02
        '
        Me.t02.Location = New System.Drawing.Point(114, 86)
        Me.t02.Name = "t02"
        Me.t02.Size = New System.Drawing.Size(423, 26)
        Me.t02.StyleController = Me.LayoutControl1
        Me.t02.TabIndex = 5
        '
        't01
        '
        Me.t01.Location = New System.Drawing.Point(114, 56)
        Me.t01.Name = "t01"
        Me.t01.Size = New System.Drawing.Size(423, 26)
        Me.t01.StyleController = Me.LayoutControl1
        Me.t01.TabIndex = 4
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(24, 116)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(513, 32)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 8
        Me.SimpleButton1.Text = "Proses"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Danger
        Me.SimpleButton2.Appearance.Options.UseBackColor = True
        Me.SimpleButton2.Location = New System.Drawing.Point(906, 96)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(337, 32)
        Me.SimpleButton2.StyleController = Me.LayoutControl1
        Me.SimpleButton2.TabIndex = 9
        Me.SimpleButton2.Text = "Encrypt"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.SimpleButton3.Appearance.Options.UseBackColor = True
        Me.SimpleButton3.Location = New System.Drawing.Point(565, 96)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(337, 32)
        Me.SimpleButton3.StyleController = Me.LayoutControl1
        Me.SimpleButton3.TabIndex = 10
        Me.SimpleButton3.Text = "Decrypt"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Location = New System.Drawing.Point(553, 144)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(702, 32)
        Me.SimpleButton4.StyleController = Me.LayoutControl1
        Me.SimpleButton4.TabIndex = 12
        Me.SimpleButton4.Text = "Get Data & Encprit"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlGroup1, Me.LayoutControlItem8, Me.EmptySpaceItem2, Me.LayoutControlGroup2, Me.LayoutControlItem9})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1267, 582)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.txtResult
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 152)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(541, 410)
        Me.LayoutControlItem4.Text = "Log"
        Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(78, 19)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem5})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(541, 152)
        Me.LayoutControlGroup1.Text = "Get IP Adress"
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.t01
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(517, 30)
        Me.LayoutControlItem1.Text = "Ip Adress"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(78, 19)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.t02
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 30)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(517, 30)
        Me.LayoutControlItem2.Text = "Host Name"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(78, 19)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.SimpleButton1
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 60)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(517, 36)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.GridControl1
        Me.LayoutControlItem8.Location = New System.Drawing.Point(541, 168)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(706, 394)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(541, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(706, 10)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem6, Me.LayoutControlItem7})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(541, 10)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(706, 122)
        Me.LayoutControlGroup2.Text = "Endcrypt & Descript Password"
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.t03
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(682, 30)
        Me.LayoutControlItem3.Text = "Password"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(78, 19)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.SimpleButton2
        Me.LayoutControlItem6.Location = New System.Drawing.Point(341, 30)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(341, 36)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.SimpleButton3
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 30)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(341, 36)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.SimpleButton4
        Me.LayoutControlItem9.Location = New System.Drawing.Point(541, 132)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(706, 36)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'xfrm40GetIpAdress
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1267, 582)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "xfrm40GetIpAdress"
        Me.Text = "xfrm40GetIpAdress"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t03.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t02.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.t01.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtResult As RichTextBox
    Friend WithEvents t03 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents t02 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents t01 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col01_k01cUserID_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col02_f01cNamaUser_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col03_f02cKeyPass_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col04_f10cKeyPassOld_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
End Class
