<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm52RealtimeClientTCP
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
        Me.components = New System.ComponentModel.Container()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me._01Ipserver = New DevExpress.XtraEditors.TextEdit()
        Me.lstMessages = New System.Windows.Forms.ListBox()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.lblStatus = New DevExpress.XtraEditors.LabelControl()
        Me._03txtMessage = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me._02NamaUser = New DevExpress.XtraEditors.TextEdit()
        Me.lstUserConnected = New System.Windows.Forms.ListBox()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.myAlert = New DevExpress.XtraBars.Alerter.AlertControl(Me.components)
        Me._04CbListUser = New System.Windows.Forms.ComboBox()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me._01Ipserver.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._03txtMessage.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._02NamaUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me._04CbListUser)
        Me.LayoutControl1.Controls.Add(Me._01Ipserver)
        Me.LayoutControl1.Controls.Add(Me.lstMessages)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.lblStatus)
        Me.LayoutControl1.Controls.Add(Me._03txtMessage)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl1.Controls.Add(Me._02NamaUser)
        Me.LayoutControl1.Controls.Add(Me.lstUserConnected)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1038, 601)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        '_01Ipserver
        '
        Me._01Ipserver.Location = New System.Drawing.Point(361, 12)
        Me._01Ipserver.Name = "_01Ipserver"
        Me._01Ipserver.Size = New System.Drawing.Size(293, 26)
        Me._01Ipserver.StyleController = Me.LayoutControl1
        Me._01Ipserver.TabIndex = 9
        '
        'lstMessages
        '
        Me.lstMessages.FormattingEnabled = True
        Me.lstMessages.ItemHeight = 19
        Me.lstMessages.Location = New System.Drawing.Point(265, 94)
        Me.lstMessages.Name = "lstMessages"
        Me.lstMessages.Size = New System.Drawing.Size(761, 422)
        Me.lstMessages.TabIndex = 8
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(932, 557)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(94, 32)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 6
        Me.SimpleButton1.Text = "Send"
        '
        'lblStatus
        '
        Me.lblStatus.Location = New System.Drawing.Point(771, 12)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(98, 19)
        Me.lblStatus.StyleController = Me.LayoutControl1
        Me.lblStatus.TabIndex = 5
        Me.lblStatus.Text = "LabelControl1"
        '
        '_03txtMessage
        '
        Me._03txtMessage.Location = New System.Drawing.Point(361, 527)
        Me._03txtMessage.Name = "_03txtMessage"
        Me._03txtMessage.Size = New System.Drawing.Size(665, 26)
        Me._03txtMessage.StyleController = Me.LayoutControl1
        Me._03txtMessage.TabIndex = 4
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(658, 12)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(109, 32)
        Me.SimpleButton2.StyleController = Me.LayoutControl1
        Me.SimpleButton2.TabIndex = 7
        Me.SimpleButton2.Text = "connect"
        '
        '_02NamaUser
        '
        Me._02NamaUser.Location = New System.Drawing.Point(361, 42)
        Me._02NamaUser.Name = "_02NamaUser"
        Me._02NamaUser.Properties.MaxLength = 50
        Me._02NamaUser.Size = New System.Drawing.Size(293, 26)
        Me._02NamaUser.StyleController = Me.LayoutControl1
        Me._02NamaUser.TabIndex = 4
        '
        'lstUserConnected
        '
        Me.lstUserConnected.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lstUserConnected.FormattingEnabled = True
        Me.lstUserConnected.ItemHeight = 19
        Me.lstUserConnected.Location = New System.Drawing.Point(12, 91)
        Me.lstUserConnected.Name = "lstUserConnected"
        Me.lstUserConnected.Size = New System.Drawing.Size(249, 498)
        Me.lstUserConnected.TabIndex = 8
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.EmptySpaceItem2, Me.LayoutControlItem3, Me.EmptySpaceItem1, Me.LayoutControlItem5, Me.LayoutControlItem7, Me.LayoutControlItem6, Me.LayoutControlItem4, Me.LayoutControlItem2, Me.LayoutControlItem8, Me.LayoutControlItem9})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1038, 601)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me._03txtMessage
        Me.LayoutControlItem1.Location = New System.Drawing.Point(253, 515)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(765, 30)
        Me.LayoutControlItem1.Text = "Pesan"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(84, 19)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(861, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(157, 60)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.SimpleButton1
        Me.LayoutControlItem3.Location = New System.Drawing.Point(920, 545)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(98, 36)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(253, 545)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(667, 36)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.lstMessages
        Me.LayoutControlItem5.Location = New System.Drawing.Point(253, 60)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(765, 455)
        Me.LayoutControlItem5.Text = "ChatLog"
        Me.LayoutControlItem5.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(84, 19)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me._01Ipserver
        Me.LayoutControlItem7.Location = New System.Drawing.Point(253, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(393, 30)
        Me.LayoutControlItem7.Text = "IP-SERVER"
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(84, 19)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me._02NamaUser
        Me.LayoutControlItem6.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem6.CustomizationFormText = "Pesan"
        Me.LayoutControlItem6.Location = New System.Drawing.Point(253, 30)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(393, 30)
        Me.LayoutControlItem6.Text = "Nama User"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(84, 19)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.SimpleButton2
        Me.LayoutControlItem4.Location = New System.Drawing.Point(646, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(113, 60)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.lblStatus
        Me.LayoutControlItem2.Location = New System.Drawing.Point(759, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(102, 60)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.lstUserConnected
        Me.LayoutControlItem8.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem8.CustomizationFormText = "ChatLog"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 57)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(253, 524)
        Me.LayoutControlItem8.Text = "Online-User"
        Me.LayoutControlItem8.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(84, 19)
        '
        '_04CbListUser
        '
        Me._04CbListUser.FormattingEnabled = True
        Me._04CbListUser.Location = New System.Drawing.Point(12, 34)
        Me._04CbListUser.Name = "_04CbListUser"
        Me._04CbListUser.Size = New System.Drawing.Size(249, 27)
        Me._04CbListUser.TabIndex = 10
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me._04CbListUser
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(253, 57)
        Me.LayoutControlItem9.Text = "Sen To"
        Me.LayoutControlItem9.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(84, 19)
        '
        'frm52RealtimeClientTCP
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1038, 601)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frm52RealtimeClientTCP"
        Me.Text = "frm52RealtimeClientTCP"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me._01Ipserver.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._03txtMessage.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._02NamaUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblStatus As DevExpress.XtraEditors.LabelControl
    Friend WithEvents _03txtMessage As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents _02NamaUser As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents lstMessages As ListBox
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents _01Ipserver As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lstUserConnected As ListBox
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents myAlert As DevExpress.XtraBars.Alerter.AlertControl
    Friend WithEvents _04CbListUser As ComboBox
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
End Class
