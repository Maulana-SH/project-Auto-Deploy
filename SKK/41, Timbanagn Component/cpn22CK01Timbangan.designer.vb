<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class cpn22CK01Timbangan
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
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
    <Obsolete>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(cpn22CK01Timbangan))
        Me.DataLayoutControl1 = New DevExpress.XtraDataLayout.DataLayoutControl()
        Me.dGauge1 = New DevExpress.XtraEditors.SpinEdit()
        Me.BarManager1 = New DevExpress.XtraBars.BarManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.objConnectTimbangan = New DevExpress.XtraBars.BarButtonItem()
        Me.objConnectPrinter = New DevExpress.XtraBars.BarButtonItem()
        Me.objDisconnetTimbangan = New DevExpress.XtraBars.BarButtonItem()
        Me.PopupMenu1 = New DevExpress.XtraBars.PopupMenu(Me.components)
        Me._06Cable = New DevExpress.XtraEditors.ComboBoxEdit()
        Me._05SCbJenisTimbangan = New System.Windows.Forms.ComboBox()
        Me._04CbListPort = New System.Windows.Forms.ComboBox()
        Me.txtDisplay = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyt_txtDisplay = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.comSerialPort = New ZylSoft.Serial.SerialPort(Me.components)
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataLayoutControl1.SuspendLayout()
        CType(Me.dGauge1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._06Cable.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtDisplay.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyt_txtDisplay, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataLayoutControl1
        '
        Me.DataLayoutControl1.Controls.Add(Me.dGauge1)
        Me.DataLayoutControl1.Controls.Add(Me._06Cable)
        Me.DataLayoutControl1.Controls.Add(Me._05SCbJenisTimbangan)
        Me.DataLayoutControl1.Controls.Add(Me._04CbListPort)
        Me.DataLayoutControl1.Controls.Add(Me.txtDisplay)
        Me.DataLayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.DataLayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataLayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.DataLayoutControl1.Name = "DataLayoutControl1"
        Me.DataLayoutControl1.Root = Me.Root
        Me.DataLayoutControl1.Size = New System.Drawing.Size(483, 240)
        Me.DataLayoutControl1.TabIndex = 0
        Me.DataLayoutControl1.Text = "DataLayoutControl1"
        '
        'dGauge1
        '
        Me.dGauge1.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me.dGauge1.Location = New System.Drawing.Point(4, 4)
        Me.dGauge1.MenuManager = Me.BarManager1
        Me.dGauge1.Name = "dGauge1"
        Me.dGauge1.Properties.AllowMouseWheel = False
        Me.dGauge1.Properties.AppearanceReadOnly.BackColor = System.Drawing.Color.Black
        Me.dGauge1.Properties.AppearanceReadOnly.BackColor2 = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.dGauge1.Properties.AppearanceReadOnly.Font = New System.Drawing.Font("Tahoma", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dGauge1.Properties.AppearanceReadOnly.ForeColor = System.Drawing.Color.CornflowerBlue
        Me.dGauge1.Properties.AppearanceReadOnly.Options.UseBackColor = True
        Me.dGauge1.Properties.AppearanceReadOnly.Options.UseFont = True
        Me.dGauge1.Properties.AppearanceReadOnly.Options.UseForeColor = True
        Me.dGauge1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.dGauge1.Properties.DisplayFormat.FormatString = "n2"
        Me.dGauge1.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.dGauge1.Properties.EditFormat.FormatString = "n2"
        Me.dGauge1.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.dGauge1.Properties.ReadOnly = True
        Me.dGauge1.Size = New System.Drawing.Size(449, 94)
        Me.dGauge1.StyleController = Me.DataLayoutControl1
        Me.dGauge1.TabIndex = 22
        '
        'BarManager1
        '
        Me.BarManager1.DockControls.Add(Me.barDockControlTop)
        Me.BarManager1.DockControls.Add(Me.barDockControlBottom)
        Me.BarManager1.DockControls.Add(Me.barDockControlLeft)
        Me.BarManager1.DockControls.Add(Me.barDockControlRight)
        Me.BarManager1.Form = Me
        Me.BarManager1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.objConnectTimbangan, Me.objConnectPrinter, Me.objDisconnetTimbangan})
        Me.BarManager1.MaxItemId = 3
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.BarManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(483, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 240)
        Me.barDockControlBottom.Manager = Me.BarManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(483, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.BarManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 240)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(483, 0)
        Me.barDockControlRight.Manager = Me.BarManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 240)
        '
        'objConnectTimbangan
        '
        Me.objConnectTimbangan.Caption = "Connect Timbangan"
        Me.objConnectTimbangan.Id = 0
        Me.objConnectTimbangan.ImageOptions.SvgImage = CType(resources.GetObject("objConnectTimbangan.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.objConnectTimbangan.Name = "objConnectTimbangan"
        '
        'objConnectPrinter
        '
        Me.objConnectPrinter.Caption = "Connect Printer"
        Me.objConnectPrinter.Id = 1
        Me.objConnectPrinter.ImageOptions.SvgImage = CType(resources.GetObject("objConnectPrinter.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.objConnectPrinter.Name = "objConnectPrinter"
        '
        'objDisconnetTimbangan
        '
        Me.objDisconnetTimbangan.Caption = "Disconnect Timbangan"
        Me.objDisconnetTimbangan.Id = 2
        Me.objDisconnetTimbangan.ImageOptions.SvgImage = CType(resources.GetObject("objDisconnetTimbangan.ImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.objDisconnetTimbangan.Name = "objDisconnetTimbangan"
        '
        'PopupMenu1
        '
        Me.PopupMenu1.LinksPersistInfo.AddRange(New DevExpress.XtraBars.LinkPersistInfo() {New DevExpress.XtraBars.LinkPersistInfo(Me.objConnectTimbangan), New DevExpress.XtraBars.LinkPersistInfo(Me.objConnectPrinter), New DevExpress.XtraBars.LinkPersistInfo(Me.objDisconnetTimbangan)})
        Me.PopupMenu1.Manager = Me.BarManager1
        Me.PopupMenu1.Name = "PopupMenu1"
        '
        '_06Cable
        '
        Me._06Cable.Location = New System.Drawing.Point(155, 102)
        Me._06Cable.MenuManager = Me.BarManager1
        Me._06Cable.Name = "_06Cable"
        Me._06Cable.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._06Cable.Properties.Appearance.Options.UseFont = True
        Me._06Cable.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._06Cable.Properties.Items.AddRange(New Object() {"USB", "RS-232"})
        Me._06Cable.Size = New System.Drawing.Size(298, 28)
        Me._06Cable.StyleController = Me.DataLayoutControl1
        Me._06Cable.TabIndex = 21
        '
        '_05SCbJenisTimbangan
        '
        Me._05SCbJenisTimbangan.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._05SCbJenisTimbangan.FormattingEnabled = True
        Me._05SCbJenisTimbangan.Items.AddRange(New Object() {"AND", "METLER TOLEDO"})
        Me._05SCbJenisTimbangan.Location = New System.Drawing.Point(155, 134)
        Me._05SCbJenisTimbangan.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me._05SCbJenisTimbangan.Name = "_05SCbJenisTimbangan"
        Me._05SCbJenisTimbangan.Size = New System.Drawing.Size(298, 30)
        Me._05SCbJenisTimbangan.TabIndex = 19
        '
        '_04CbListPort
        '
        Me._04CbListPort.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._04CbListPort.FormattingEnabled = True
        Me._04CbListPort.Location = New System.Drawing.Point(155, 169)
        Me._04CbListPort.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me._04CbListPort.Name = "_04CbListPort"
        Me._04CbListPort.Size = New System.Drawing.Size(298, 30)
        Me._04CbListPort.TabIndex = 18
        '
        'txtDisplay
        '
        Me.txtDisplay.Location = New System.Drawing.Point(155, 240)
        Me.txtDisplay.Name = "txtDisplay"
        Me.txtDisplay.Size = New System.Drawing.Size(298, 26)
        Me.txtDisplay.StyleController = Me.DataLayoutControl1
        Me.txtDisplay.TabIndex = 17
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Location = New System.Drawing.Point(4, 204)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(449, 32)
        Me.SimpleButton1.StyleController = Me.DataLayoutControl1
        Me.SimpleButton1.TabIndex = 20
        Me.SimpleButton1.Text = "Get Berat"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4, Me.LayoutControlItem5, Me.LayoutControlItem1, Me.LayoutControlItem6, Me.LayoutControlItem2, Me.lyt_txtDisplay})
        Me.Root.Name = "Root"
        Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(2, 2, 2, 2)
        Me.Root.Size = New System.Drawing.Size(457, 270)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem4.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem4.Control = Me._05SCbJenisTimbangan
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 130)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(453, 35)
        Me.LayoutControlItem4.Text = "Type"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(139, 22)
        '
        'lyt_txtDisplay
        '
        Me.lyt_txtDisplay.Control = Me.txtDisplay
        Me.lyt_txtDisplay.Location = New System.Drawing.Point(0, 236)
        Me.lyt_txtDisplay.Name = "lyt_txtDisplay"
        Me.lyt_txtDisplay.Size = New System.Drawing.Size(453, 30)
        Me.lyt_txtDisplay.Text = "Display"
        Me.lyt_txtDisplay.TextSize = New System.Drawing.Size(139, 19)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.SimpleButton1
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 200)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(453, 36)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem1.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem1.Control = Me._04CbListPort
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 165)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(453, 35)
        Me.LayoutControlItem1.Text = "PORT"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(139, 22)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem6.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem6.Control = Me._06Cable
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 98)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(453, 32)
        Me.LayoutControlItem6.Text = "Cabel Connection"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(139, 22)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.dGauge1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(453, 98)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
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
        'cpn22CK01Timbangan
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.DataLayoutControl1)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlRight)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Name = "cpn22CK01Timbangan"
        Me.BarManager1.SetPopupContextMenu(Me, Me.PopupMenu1)
        Me.Size = New System.Drawing.Size(483, 240)
        CType(Me.DataLayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataLayoutControl1.ResumeLayout(False)
        CType(Me.dGauge1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BarManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PopupMenu1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._06Cable.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtDisplay.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyt_txtDisplay, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DataLayoutControl1 As DevExpress.XtraDataLayout.DataLayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents txtDisplay As DevExpress.XtraEditors.TextEdit
    Friend WithEvents lyt_txtDisplay As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents PopupMenu1 As DevExpress.XtraBars.PopupMenu
    Friend WithEvents BarManager1 As DevExpress.XtraBars.BarManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents objConnectTimbangan As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents objConnectPrinter As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents objDisconnetTimbangan As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents _04CbListPort As ComboBox
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents _05SCbJenisTimbangan As ComboBox
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents comSerialPort As ZylSoft.Serial.SerialPort
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents _06Cable As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents dGauge1 As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
End Class
