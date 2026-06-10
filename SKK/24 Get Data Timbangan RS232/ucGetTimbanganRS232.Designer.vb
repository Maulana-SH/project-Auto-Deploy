<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucGetTimbanganRS232
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
    <System.Diagnostics.DebuggerStepThrough()>
    <Obsolete>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.txtViewBerat = New DevExpress.XtraEditors.SpinEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.txtDisplay = New DevExpress.XtraEditors.TextEdit()
        Me._03CbListPort = New System.Windows.Forms.ComboBox()
        Me._02SCbJenisTimbangan = New System.Windows.Forms.ComboBox()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.comSerialPort = New ZylSoft.Serial.SerialPort(Me.components)
        Me.textOutput = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.txtViewBerat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisplay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.textOutput.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.textOutput)
        Me.LayoutControl1.Controls.Add(Me.txtViewBerat)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me.txtDisplay)
        Me.LayoutControl1.Controls.Add(Me._03CbListPort)
        Me.LayoutControl1.Controls.Add(Me._02SCbJenisTimbangan)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton3)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1439, 599)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'txtViewBerat
        '
        Me.txtViewBerat.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.txtViewBerat.Location = New System.Drawing.Point(358, 42)
        Me.txtViewBerat.Name = "txtViewBerat"
        Me.txtViewBerat.Properties.Appearance.BackColor = System.Drawing.Color.Black
        Me.txtViewBerat.Properties.Appearance.Font = New System.Drawing.Font("Digital-7 Mono", 48.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtViewBerat.Properties.Appearance.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.txtViewBerat.Properties.Appearance.Options.UseBackColor = True
        Me.txtViewBerat.Properties.Appearance.Options.UseFont = True
        Me.txtViewBerat.Properties.Appearance.Options.UseForeColor = True
        Me.txtViewBerat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.txtViewBerat.Size = New System.Drawing.Size(1069, 102)
        Me.txtViewBerat.StyleController = Me.LayoutControl1
        Me.txtViewBerat.TabIndex = 20
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(12, 112)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(342, 32)
        Me.SimpleButton2.StyleController = Me.LayoutControl1
        Me.SimpleButton2.TabIndex = 6
        Me.SimpleButton2.Text = "konek Timbangan"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 184)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(342, 32)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 5
        Me.SimpleButton1.Text = "Get Timbangan"
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(111, 12)
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.Size = New System.Drawing.Size(1316, 26)
        Me.txtDisplay.StyleController = Me.LayoutControl1
        Me.txtDisplay.TabIndex = 4
        '
        '_03CbListPort
        '
        Me._03CbListPort.FormattingEnabled = True
        Me._03CbListPort.Location = New System.Drawing.Point(111, 77)
        Me._03CbListPort.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me._03CbListPort.Name = "_03CbListPort"
        Me._03CbListPort.Size = New System.Drawing.Size(243, 27)
        Me._03CbListPort.TabIndex = 18
        '
        '_02SCbJenisTimbangan
        '
        Me._02SCbJenisTimbangan.FormattingEnabled = True
        Me._02SCbJenisTimbangan.Items.AddRange(New Object() {"A&D", "METLER TOLEDO"})
        Me._02SCbJenisTimbangan.Location = New System.Drawing.Point(111, 42)
        Me._02SCbJenisTimbangan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me._02SCbJenisTimbangan.Name = "_02SCbJenisTimbangan"
        Me._02SCbJenisTimbangan.Size = New System.Drawing.Size(243, 27)
        Me._02SCbJenisTimbangan.TabIndex = 19
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Location = New System.Drawing.Point(12, 148)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(342, 32)
        Me.SimpleButton3.StyleController = Me.LayoutControl1
        Me.SimpleButton3.TabIndex = 21
        Me.SimpleButton3.Text = "Disconnet Timbangan"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem2, Me.EmptySpaceItem2, Me.EmptySpaceItem1, Me.LayoutControlItem1, Me.LayoutControlItem5, Me.LayoutControlItem4, Me.LayoutControlItem6, Me.LayoutControlItem7, Me.LayoutControlItem8})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1439, 599)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.SimpleButton2
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 100)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(346, 36)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.SimpleButton1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 172)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(346, 36)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(0, 208)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(346, 309)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(346, 172)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(1073, 345)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.txtDisplay
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1419, 30)
        Me.LayoutControlItem1.Text = "Dsiplay Text"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(87, 19)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me._02SCbJenisTimbangan
        Me.LayoutControlItem5.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem5.CustomizationFormText = "Type"
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 30)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(346, 35)
        Me.LayoutControlItem5.Text = "Type"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(87, 19)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me._03CbListPort
        Me.LayoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem4.CustomizationFormText = "PORT"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 65)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(346, 35)
        Me.LayoutControlItem4.Text = "PORT"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(87, 19)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.txtViewBerat
        Me.LayoutControlItem6.Location = New System.Drawing.Point(346, 30)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(1073, 142)
        Me.LayoutControlItem6.Text = "lytBErat'"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.SimpleButton3
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 136)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(346, 36)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'comSerialPort
        '
        Me.comSerialPort.AutoReceive = True
        Me.comSerialPort.AutoReconnect = False
        Me.comSerialPort.AutoReconnectCheckInterval = 4000
        Me.comSerialPort.BaudRate = ZylSoft.Serial.SerialBaudRate.Br004800
        Me.comSerialPort.CloseWhenLineStatusIsZero = True
        Me.comSerialPort.CustomBaudRate = CType(0UI, UInteger)
        Me.comSerialPort.CustomPortName = "port1"
        Me.comSerialPort.DataWidth = ZylSoft.Serial.SerialDataWidth.Dw8Bits
        Me.comSerialPort.Delay = 100
        Me.comSerialPort.DiscardNulls = False
        Me.comSerialPort.DsrSensitivity = False
        Me.comSerialPort.EnableDtrOnOpen = True
        Me.comSerialPort.EnableRtsOnOpen = True
        Me.comSerialPort.EofChar = CType(26UI, UInteger)
        Me.comSerialPort.ErrorChar = CType(0UI, UInteger)
        Me.comSerialPort.EvtChar = CType(26UI, UInteger)
        Me.comSerialPort.HardwareFlowControl = ZylSoft.Serial.SerialHardwareFlowControl.None
        Me.comSerialPort.IdleInterval = 0
        Me.comSerialPort.InputBuffer = 4096
        Me.comSerialPort.Interval = 100
        Me.comSerialPort.LogDateTime = False
        Me.comSerialPort.LogFile = Nothing
        Me.comSerialPort.LogInput = False
        Me.comSerialPort.MaxLineLength = 0
        Me.comSerialPort.MinCheckDisconnectedInterval = 25
        Me.comSerialPort.NeedSynchronization = False
        Me.comSerialPort.NewLine = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        Me.comSerialPort.OutputBuffer = 4096
        Me.comSerialPort.PacketSize = CType(0UI, UInteger)
        Me.comSerialPort.ParityBits = ZylSoft.Serial.SerialParityBits.None
        Me.comSerialPort.ParityCheck = False
        Me.comSerialPort.Port = ZylSoft.Serial.SerialCommPort.None
        Me.comSerialPort.Priority = System.Threading.ThreadPriority.Normal
        Me.comSerialPort.ReadIntervalTimeout = CType(4294967295UI, UInteger)
        Me.comSerialPort.ReadTotalTimeoutConstant = CType(0UI, UInteger)
        Me.comSerialPort.ReadTotalTimeoutMultiplier = CType(0UI, UInteger)
        Me.comSerialPort.ReplaceParityErrors = False
        Me.comSerialPort.SkipSetupFailed = False
        Me.comSerialPort.SoftwareFlowControl = ZylSoft.Serial.SerialSoftwareFlowControl.None
        Me.comSerialPort.StopBits = ZylSoft.Serial.SerialStopBits.Sb1Bit
        Me.comSerialPort.TxContinueOnXoff = False
        Me.comSerialPort.WriteTotalTimeoutConstant = 1000
        Me.comSerialPort.WriteTotalTimeoutMultiplier = 100
        Me.comSerialPort.XoffChar = CType(19UI, UInteger)
        Me.comSerialPort.XoffLim = CType(1US, UShort)
        Me.comSerialPort.XonChar = CType(17UI, UInteger)
        Me.comSerialPort.XonLim = CType(0US, UShort)
        '
        'textOutput
        '
        Me.textOutput.Location = New System.Drawing.Point(12, 551)
        Me.textOutput.Name = "textOutput"
        Me.textOutput.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 12.0!)
        Me.textOutput.Properties.Appearance.Options.UseFont = True
        Me.textOutput.Size = New System.Drawing.Size(1415, 36)
        Me.textOutput.StyleController = Me.LayoutControl1
        Me.textOutput.TabIndex = 22
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.textOutput
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 517)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(1419, 62)
        Me.LayoutControlItem8.Text = "Log console"
        Me.LayoutControlItem8.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(87, 19)
        '
        'ucGetTimbanganRS232
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1439, 599)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "ucGetTimbanganRS232"
        Me.Text = "ucGetTimbanganRS232"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.txtViewBerat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDisplay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.textOutput.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents comSerialPort As ZylSoft.Serial.SerialPort
    Friend WithEvents txtDisplay As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents _03CbListPort As ComboBox
    Friend WithEvents _02SCbJenisTimbangan As ComboBox
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents txtViewBerat As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents textOutput As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
End Class
