<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm49SendEmail
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
        Me._03Msg = New System.Windows.Forms.RichTextBox()
        Me._02To = New DevExpress.XtraEditors.TextEdit()
        Me._01From = New DevExpress.XtraEditors.TextEdit()
        Me.btnSend = New DevExpress.XtraEditors.SimpleButton()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me._02To.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._01From.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me._03Msg)
        Me.LayoutControl1.Controls.Add(Me._02To)
        Me.LayoutControl1.Controls.Add(Me._01From)
        Me.LayoutControl1.Controls.Add(Me.btnSend)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(784, 612)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        '_03Msg
        '
        Me._03Msg.Location = New System.Drawing.Point(86, 87)
        Me._03Msg.Name = "_03Msg"
        Me._03Msg.Size = New System.Drawing.Size(683, 456)
        Me._03Msg.TabIndex = 6
        Me._03Msg.Text = ""
        '
        '_02To
        '
        Me._02To.Location = New System.Drawing.Point(86, 51)
        Me._02To.Name = "_02To"
        Me._02To.Size = New System.Drawing.Size(683, 26)
        Me._02To.StyleController = Me.LayoutControl1
        Me._02To.TabIndex = 5
        '
        '_01From
        '
        Me._01From.Location = New System.Drawing.Point(86, 15)
        Me._01From.Name = "_01From"
        Me._01From.Size = New System.Drawing.Size(683, 26)
        Me._01From.StyleController = Me.LayoutControl1
        Me._01From.TabIndex = 4
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(12, 550)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(760, 32)
        Me.btnSend.StyleController = Me.LayoutControl1
        Me.btnSend.TabIndex = 7
        Me.btnSend.Text = "SEND Email"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(784, 612)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me._01From
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem1.Size = New System.Drawing.Size(764, 36)
        Me.LayoutControlItem1.Text = "From"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(59, 19)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 574)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(764, 18)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me._02To
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 36)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem2.Size = New System.Drawing.Size(764, 36)
        Me.LayoutControlItem2.Text = "To"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(59, 19)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me._03Msg
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 72)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.LayoutControlItem3.Size = New System.Drawing.Size(764, 466)
        Me.LayoutControlItem3.Text = "Message"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(59, 19)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.btnSend
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 538)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(764, 36)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'frm49SendEmail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(784, 612)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frm49SendEmail"
        Me.Text = "frm49SendEmail"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me._02To.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._01From.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents _03Msg As RichTextBox
    Friend WithEvents _02To As DevExpress.XtraEditors.TextEdit
    Friend WithEvents _01From As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnSend As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
End Class
