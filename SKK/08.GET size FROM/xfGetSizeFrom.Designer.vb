<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xfGetSizeFrom
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
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me._02User = New DevExpress.XtraEditors.TextEdit()
        Me._01cZisefrom = New DevExpress.XtraEditors.TextEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.splitINduk = New DevExpress.XtraEditors.SplitContainerControl()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.splitKanan = New DevExpress.XtraEditors.SplitContainerControl()
        Me.splitKiri = New DevExpress.XtraEditors.SplitContainerControl()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me._02User.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._01cZisefrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitINduk, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitINduk.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitINduk.Panel1.SuspendLayout()
        CType(Me.splitINduk.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitINduk.Panel2.SuspendLayout()
        Me.splitINduk.SuspendLayout()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitKanan, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitKanan.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitKanan.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitKanan.SuspendLayout()
        CType(Me.splitKiri, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitKiri.Panel1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.splitKiri.Panel2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.splitKiri.SuspendLayout()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.splitINduk)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me._02User)
        Me.LayoutControl1.Controls.Add(Me._01cZisefrom)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(923, 545)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 72)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(899, 32)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 6
        Me.SimpleButton1.Text = "GEt Size"
        '
        '_02User
        '
        Me._02User.Location = New System.Drawing.Point(104, 42)
        Me._02User.Name = "_02User"
        Me._02User.Size = New System.Drawing.Size(807, 26)
        Me._02User.StyleController = Me.LayoutControl1
        Me._02User.TabIndex = 5
        '
        '_01cZisefrom
        '
        Me._01cZisefrom.Location = New System.Drawing.Point(104, 12)
        Me._01cZisefrom.Name = "_01cZisefrom"
        Me._01cZisefrom.Size = New System.Drawing.Size(807, 26)
        Me._01cZisefrom.StyleController = Me.LayoutControl1
        Me._01cZisefrom.TabIndex = 4
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(923, 545)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me._01cZisefrom
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(903, 30)
        Me.LayoutControlItem1.Text = "SIZE FORM"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(80, 19)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me._02User
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 30)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(903, 30)
        Me.LayoutControlItem2.Text = "SIZE / 2"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(80, 19)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.SimpleButton1
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 60)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(903, 36)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'splitINduk
        '
        Me.splitINduk.Location = New System.Drawing.Point(12, 108)
        Me.splitINduk.Name = "splitINduk"
        '
        'splitINduk.splitINduk_Panel1
        '
        Me.splitINduk.Panel1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.splitINduk.Panel1.Appearance.Options.UseBackColor = True
        Me.splitINduk.Panel1.Controls.Add(Me.splitKiri)
        Me.splitINduk.Panel1.Text = "Panel1"
        '
        'splitINduk.splitINduk_Panel2
        '
        Me.splitINduk.Panel2.Appearance.BackColor = System.Drawing.Color.Red
        Me.splitINduk.Panel2.Appearance.Options.UseBackColor = True
        Me.splitINduk.Panel2.Controls.Add(Me.splitKanan)
        Me.splitINduk.Panel2.Text = "Panel2"
        Me.splitINduk.Size = New System.Drawing.Size(899, 425)
        Me.splitINduk.SplitterPosition = 382
        Me.splitINduk.TabIndex = 7
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.splitINduk
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(903, 429)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'splitKanan
        '
        Me.splitKanan.Horizontal = False
        Me.splitKanan.Location = New System.Drawing.Point(67, 92)
        Me.splitKanan.Name = "splitKanan"
        '
        'splitKanan.splitKanan_Panel1
        '
        Me.splitKanan.Panel1.Text = "Panel1"
        '
        'splitKanan.splitKanan_Panel2
        '
        Me.splitKanan.Panel2.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me.splitKanan.Panel2.Appearance.Options.UseBackColor = True
        Me.splitKanan.Panel2.Text = "Panel2"
        Me.splitKanan.Size = New System.Drawing.Size(331, 229)
        Me.splitKanan.SplitterPosition = 113
        Me.splitKanan.TabIndex = 0
        '
        'splitKiri
        '
        Me.splitKiri.Location = New System.Drawing.Point(127, 118)
        Me.splitKiri.Name = "splitKiri"
        '
        'splitKiri.splitKiri_Panel1
        '
        Me.splitKiri.Panel1.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.splitKiri.Panel1.Appearance.Options.UseBackColor = True
        Me.splitKiri.Panel1.Text = "Panel1"
        '
        'splitKiri.splitKiri_Panel2
        '
        Me.splitKiri.Panel2.Text = "Panel2"
        Me.splitKiri.Size = New System.Drawing.Size(200, 153)
        Me.splitKiri.SplitterPosition = 78
        Me.splitKiri.TabIndex = 0
        '
        'xfGetSizeFrom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(923, 545)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "xfGetSizeFrom"
        Me.Text = "xfGetSizeFrom"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me._02User.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._01cZisefrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.splitINduk.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitINduk.Panel1.ResumeLayout(False)
        CType(Me.splitINduk.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitINduk.Panel2.ResumeLayout(False)
        CType(Me.splitINduk, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitINduk.ResumeLayout(False)
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.splitKanan.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.splitKanan.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.splitKanan, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitKanan.ResumeLayout(False)
        CType(Me.splitKiri.Panel1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.splitKiri.Panel2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.splitKiri, System.ComponentModel.ISupportInitialize).EndInit()
        Me.splitKiri.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents _02User As DevExpress.XtraEditors.TextEdit
    Friend WithEvents _01cZisefrom As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents splitINduk As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents splitKanan As DevExpress.XtraEditors.SplitContainerControl
    Friend WithEvents splitKiri As DevExpress.XtraEditors.SplitContainerControl
End Class
