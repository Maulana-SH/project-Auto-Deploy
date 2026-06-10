<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm52RealtimeNotif
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
        Dim TableColumnDefinition1 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
        Dim TableColumnDefinition2 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
        Dim TableColumnDefinition3 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
        Dim TableColumnDefinition4 As DevExpress.XtraEditors.TableLayout.TableColumnDefinition = New DevExpress.XtraEditors.TableLayout.TableColumnDefinition()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm52RealtimeNotif))
        Dim TableRowDefinition1 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
        Dim TableRowDefinition2 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
        Dim TableRowDefinition3 As DevExpress.XtraEditors.TableLayout.TableRowDefinition = New DevExpress.XtraEditors.TableLayout.TableRowDefinition()
        Dim TableSpan1 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
        Dim TableSpan2 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
        Dim TableSpan3 As DevExpress.XtraEditors.TableLayout.TableSpan = New DevExpress.XtraEditors.TableLayout.TableSpan()
        Dim TileViewItemElement1 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement2 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Dim TileViewItemElement3 As DevExpress.XtraGrid.Views.Tile.TileViewItemElement = New DevExpress.XtraGrid.Views.Tile.TileViewItemElement()
        Me.tcol01_IdUser = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.tcol03_DateTime = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.tcol02_Pesan = New DevExpress.XtraGrid.Columns.TileViewColumn()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.logChat = New System.Windows.Forms.ListBox()
        Me.gcChat = New DevExpress.XtraGrid.GridControl()
        Me.TileView1 = New DevExpress.XtraGrid.Views.Tile.TileView()
        Me._03Pesan = New DevExpress.XtraEditors.MemoEdit()
        Me._02NamaUser = New DevExpress.XtraEditors.TextEdit()
        Me._01IpServer = New DevExpress.XtraEditors.TextEdit()
        Me.btnConnect = New DevExpress.XtraEditors.SimpleButton()
        Me.btnSend = New DevExpress.XtraEditors.SimpleButton()
        Me._04CbListUser = New System.Windows.Forms.ListBox()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.TabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.myAlert = New DevExpress.XtraBars.Alerter.AlertControl(Me.components)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.gcChat, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TileView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._03Pesan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._02NamaUser.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._01IpServer.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tcol01_IdUser
        '
        Me.tcol01_IdUser.Caption = "User"
        Me.tcol01_IdUser.MinWidth = 30
        Me.tcol01_IdUser.Name = "tcol01_IdUser"
        Me.tcol01_IdUser.Visible = True
        Me.tcol01_IdUser.VisibleIndex = 0
        Me.tcol01_IdUser.Width = 112
        '
        'tcol03_DateTime
        '
        Me.tcol03_DateTime.Caption = "Time"
        Me.tcol03_DateTime.DisplayFormat.FormatString = "dd-MM-yyyy HH:mm:ss"
        Me.tcol03_DateTime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.tcol03_DateTime.MinWidth = 30
        Me.tcol03_DateTime.Name = "tcol03_DateTime"
        Me.tcol03_DateTime.Visible = True
        Me.tcol03_DateTime.VisibleIndex = 2
        Me.tcol03_DateTime.Width = 112
        '
        'tcol02_Pesan
        '
        Me.tcol02_Pesan.Caption = "Pesan"
        Me.tcol02_Pesan.MinWidth = 30
        Me.tcol02_Pesan.Name = "tcol02_Pesan"
        Me.tcol02_Pesan.Visible = True
        Me.tcol02_Pesan.VisibleIndex = 1
        Me.tcol02_Pesan.Width = 112
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.logChat)
        Me.LayoutControl1.Controls.Add(Me.gcChat)
        Me.LayoutControl1.Controls.Add(Me._03Pesan)
        Me.LayoutControl1.Controls.Add(Me._02NamaUser)
        Me.LayoutControl1.Controls.Add(Me._01IpServer)
        Me.LayoutControl1.Controls.Add(Me.btnConnect)
        Me.LayoutControl1.Controls.Add(Me.btnSend)
        Me.LayoutControl1.Controls.Add(Me._04CbListUser)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1164, 622)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'logChat
        '
        Me.logChat.FormattingEnabled = True
        Me.logChat.ItemHeight = 19
        Me.logChat.Location = New System.Drawing.Point(440, 57)
        Me.logChat.Name = "logChat"
        Me.logChat.Size = New System.Drawing.Size(700, 403)
        Me.logChat.TabIndex = 10
        '
        'gcChat
        '
        Me.gcChat.Location = New System.Drawing.Point(440, 57)
        Me.gcChat.MainView = Me.TileView1
        Me.gcChat.Name = "gcChat"
        Me.gcChat.Size = New System.Drawing.Size(700, 406)
        Me.gcChat.TabIndex = 9
        Me.gcChat.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.TileView1})
        '
        'TileView1
        '
        Me.TileView1.Appearance.EmptySpace.BackColor = System.Drawing.Color.Transparent
        Me.TileView1.Appearance.EmptySpace.Options.UseBackColor = True
        Me.TileView1.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder
        Me.TileView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.tcol01_IdUser, Me.tcol02_Pesan, Me.tcol03_DateTime})
        Me.TileView1.GridControl = Me.gcChat
        Me.TileView1.Name = "TileView1"
        Me.TileView1.OptionsHtmlTemplate.ItemAutoHeight = True
        Me.TileView1.OptionsTiles.IndentBetweenGroups = 4
        Me.TileView1.OptionsTiles.ItemBorderVisibility = DevExpress.XtraEditors.TileItemBorderVisibility.Never
        Me.TileView1.OptionsTiles.ItemPadding = New System.Windows.Forms.Padding(0)
        Me.TileView1.OptionsTiles.ItemSize = New System.Drawing.Size(332, 196)
        Me.TileView1.OptionsTiles.LayoutMode = DevExpress.XtraGrid.Views.Tile.TileViewLayoutMode.List
        Me.TileView1.OptionsTiles.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.TileView1.OptionsTiles.Padding = New System.Windows.Forms.Padding(2)
        Me.TileView1.TileColumns.Add(TableColumnDefinition1)
        Me.TileView1.TileColumns.Add(TableColumnDefinition2)
        Me.TileView1.TileColumns.Add(TableColumnDefinition3)
        Me.TileView1.TileColumns.Add(TableColumnDefinition4)
        Me.TileView1.TileHtmlTemplate.Styles = resources.GetString("TileView1.TileHtmlTemplate.Styles")
        Me.TileView1.TileHtmlTemplate.Template = "<div id=""msgchat"" class='message'>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    <div id=""name"" class='name'>${IdUser}</di" &
    "v>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    <div id=""sent"" class='sent'>${DateTime}</div>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "    <div class='text'>${P" &
    "esan}</div>" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "</div>"
        TableRowDefinition1.Length.Value = 36.0R
        TableRowDefinition2.Length.Value = 34.0R
        TableRowDefinition3.Length.Value = 126.0R
        Me.TileView1.TileRows.Add(TableRowDefinition1)
        Me.TileView1.TileRows.Add(TableRowDefinition2)
        Me.TileView1.TileRows.Add(TableRowDefinition3)
        TableSpan1.ColumnSpan = 4
        TableSpan2.ColumnSpan = 4
        TableSpan2.RowIndex = 1
        TableSpan3.ColumnSpan = 4
        TableSpan3.RowIndex = 2
        Me.TileView1.TileSpans.Add(TableSpan1)
        Me.TileView1.TileSpans.Add(TableSpan2)
        Me.TileView1.TileSpans.Add(TableSpan3)
        TileViewItemElement1.Appearance.Normal.ForeColor = System.Drawing.Color.Black
        TileViewItemElement1.Appearance.Normal.Options.UseForeColor = True
        TileViewItemElement1.Column = Me.tcol01_IdUser
        TileViewItemElement1.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement1.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze
        TileViewItemElement1.StretchHorizontal = True
        TileViewItemElement1.StretchVertical = True
        TileViewItemElement1.Text = "tcol01_IdUser"
        TileViewItemElement1.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        TileViewItemElement2.Column = Me.tcol03_DateTime
        TileViewItemElement2.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement2.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze
        TileViewItemElement2.RowIndex = 1
        TileViewItemElement2.StretchHorizontal = True
        TileViewItemElement2.StretchVertical = True
        TileViewItemElement2.Text = "tcol03_DateTime"
        TileViewItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleLeft
        TileViewItemElement3.Column = Me.tcol02_Pesan
        TileViewItemElement3.ImageOptions.ImageAlignment = DevExpress.XtraEditors.TileItemContentAlignment.MiddleCenter
        TileViewItemElement3.ImageOptions.ImageScaleMode = DevExpress.XtraEditors.TileItemImageScaleMode.Squeeze
        TileViewItemElement3.RowIndex = 2
        TileViewItemElement3.StretchHorizontal = True
        TileViewItemElement3.StretchVertical = True
        TileViewItemElement3.Text = "tcol02_Pesan"
        TileViewItemElement3.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.TopLeft
        Me.TileView1.TileTemplate.Add(TileViewItemElement1)
        Me.TileView1.TileTemplate.Add(TileViewItemElement2)
        Me.TileView1.TileTemplate.Add(TileViewItemElement3)
        '
        '_03Pesan
        '
        Me._03Pesan.Location = New System.Drawing.Point(428, 501)
        Me._03Pesan.Name = "_03Pesan"
        Me._03Pesan.Size = New System.Drawing.Size(724, 73)
        Me._03Pesan.StyleController = Me.LayoutControl1
        Me._03Pesan.TabIndex = 7
        '
        '_02NamaUser
        '
        Me._02NamaUser.Location = New System.Drawing.Point(108, 42)
        Me._02NamaUser.Name = "_02NamaUser"
        Me._02NamaUser.Size = New System.Drawing.Size(316, 26)
        Me._02NamaUser.StyleController = Me.LayoutControl1
        Me._02NamaUser.TabIndex = 6
        '
        '_01IpServer
        '
        Me._01IpServer.Location = New System.Drawing.Point(108, 12)
        Me._01IpServer.Name = "_01IpServer"
        Me._01IpServer.Size = New System.Drawing.Size(316, 26)
        Me._01IpServer.StyleController = Me.LayoutControl1
        Me._01IpServer.TabIndex = 5
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(12, 72)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(412, 32)
        Me.btnConnect.StyleController = Me.LayoutControl1
        Me.btnConnect.TabIndex = 4
        Me.btnConnect.Text = "Connect . . ."
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(428, 578)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(724, 32)
        Me.btnSend.StyleController = Me.LayoutControl1
        Me.btnSend.TabIndex = 8
        Me.btnSend.Text = "Send"
        '
        '_04CbListUser
        '
        Me._04CbListUser.Font = New System.Drawing.Font("Tahoma", 8.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._04CbListUser.FormattingEnabled = True
        Me._04CbListUser.ItemHeight = 19
        Me._04CbListUser.Location = New System.Drawing.Point(12, 130)
        Me._04CbListUser.Name = "_04CbListUser"
        Me._04CbListUser.Size = New System.Drawing.Size(412, 479)
        Me._04CbListUser.TabIndex = 8
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem1, Me.LayoutControlItem4, Me.LayoutControlItem5, Me.TabbedControlGroup1, Me.LayoutControlItem8})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1164, 622)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me._01IpServer
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(416, 30)
        Me.LayoutControlItem2.Text = "IP-SERVER"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(84, 19)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me._02NamaUser
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 30)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(416, 30)
        Me.LayoutControlItem3.Text = "User Name"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(84, 19)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.btnConnect
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 60)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(416, 36)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me._03Pesan
        Me.LayoutControlItem4.Location = New System.Drawing.Point(416, 467)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(728, 99)
        Me.LayoutControlItem4.Text = "Pesan"
        Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(84, 19)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.btnSend
        Me.LayoutControlItem5.Location = New System.Drawing.Point(416, 566)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(728, 36)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'TabbedControlGroup1
        '
        Me.TabbedControlGroup1.Location = New System.Drawing.Point(416, 0)
        Me.TabbedControlGroup1.Name = "TabbedControlGroup1"
        Me.TabbedControlGroup1.SelectedTabPage = Me.LayoutControlGroup1
        Me.TabbedControlGroup1.Size = New System.Drawing.Size(728, 467)
        Me.TabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup1, Me.LayoutControlGroup2})
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem6})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(704, 410)
        Me.LayoutControlGroup1.Text = "Chat"
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.gcChat
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(704, 410)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem7})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(704, 410)
        Me.LayoutControlGroup2.Text = "Log_data"
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me.logChat
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(704, 410)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me._04CbListUser
        Me.LayoutControlItem8.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem8.CustomizationFormText = "ChatLog"
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 96)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(416, 506)
        Me.LayoutControlItem8.Text = "Online-User"
        Me.LayoutControlItem8.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(84, 19)
        '
        'frm52RealtimeNotif
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1164, 622)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frm52RealtimeNotif"
        Me.Text = "frm52RealtimeNotif"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.gcChat, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TileView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._03Pesan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._02NamaUser.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._01IpServer.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents _03Pesan As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents _02NamaUser As DevExpress.XtraEditors.TextEdit
    Friend WithEvents _01IpServer As DevExpress.XtraEditors.TextEdit
    Friend WithEvents btnConnect As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnSend As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents gcChat As DevExpress.XtraGrid.GridControl
    Friend WithEvents TabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents logChat As ListBox
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents _04CbListUser As ListBox
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TileView1 As DevExpress.XtraGrid.Views.Tile.TileView
    Friend WithEvents myAlert As DevExpress.XtraBars.Alerter.AlertControl
    Friend WithEvents tcol01_IdUser As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents tcol02_Pesan As DevExpress.XtraGrid.Columns.TileViewColumn
    Friend WithEvents tcol03_DateTime As DevExpress.XtraGrid.Columns.TileViewColumn
End Class
