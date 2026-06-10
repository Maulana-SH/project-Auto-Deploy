<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm34VpnConnections
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
        Me.btnConnect = New DevExpress.XtraEditors.SimpleButton()
        Me.btnDisconnect = New DevExpress.XtraEditors.SimpleButton()
        Me.txtHost = New DevExpress.XtraEditors.TextEdit()
        Me.txtUserName = New DevExpress.XtraEditors.TextEdit()
        Me.txtPassword = New DevExpress.XtraEditors.TextEdit()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.cmbTimer = New System.Windows.Forms.ComboBox()
        Me.lblCounterTimer = New System.Windows.Forms.Label()
        CType(Me.txtHost.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtUserName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnConnect
        '
        Me.btnConnect.Location = New System.Drawing.Point(12, 278)
        Me.btnConnect.Name = "btnConnect"
        Me.btnConnect.Size = New System.Drawing.Size(137, 44)
        Me.btnConnect.TabIndex = 0
        Me.btnConnect.Text = "Conected"
        '
        'btnDisconnect
        '
        Me.btnDisconnect.Location = New System.Drawing.Point(174, 278)
        Me.btnDisconnect.Name = "btnDisconnect"
        Me.btnDisconnect.Size = New System.Drawing.Size(135, 44)
        Me.btnDisconnect.TabIndex = 1
        Me.btnDisconnect.Text = "Disconected"
        '
        'txtHost
        '
        Me.txtHost.Location = New System.Drawing.Point(13, 83)
        Me.txtHost.Name = "txtHost"
        Me.txtHost.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtHost.Properties.Appearance.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtHost.Properties.Appearance.Options.UseBackColor = True
        Me.txtHost.Properties.Appearance.Options.UseFont = True
        Me.txtHost.Properties.ReadOnly = True
        Me.txtHost.Size = New System.Drawing.Size(297, 30)
        Me.txtHost.TabIndex = 2
        '
        'txtUserName
        '
        Me.txtUserName.Location = New System.Drawing.Point(12, 122)
        Me.txtUserName.Name = "txtUserName"
        Me.txtUserName.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtUserName.Properties.Appearance.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUserName.Properties.Appearance.Options.UseBackColor = True
        Me.txtUserName.Properties.Appearance.Options.UseFont = True
        Me.txtUserName.Properties.ReadOnly = True
        Me.txtUserName.Size = New System.Drawing.Size(297, 30)
        Me.txtUserName.TabIndex = 3
        '
        'txtPassword
        '
        Me.txtPassword.Location = New System.Drawing.Point(16, 166)
        Me.txtPassword.Name = "txtPassword"
        Me.txtPassword.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me.txtPassword.Properties.Appearance.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtPassword.Properties.Appearance.Options.UseBackColor = True
        Me.txtPassword.Properties.Appearance.Options.UseFont = True
        Me.txtPassword.Properties.ReadOnly = True
        Me.txtPassword.Size = New System.Drawing.Size(297, 30)
        Me.txtPassword.TabIndex = 4
        '
        'Timer1
        '
        '
        'cmbTimer
        '
        Me.cmbTimer.BackColor = System.Drawing.Color.White
        Me.cmbTimer.Font = New System.Drawing.Font("Arial Narrow", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbTimer.FormattingEnabled = True
        Me.cmbTimer.Location = New System.Drawing.Point(14, 214)
        Me.cmbTimer.Name = "cmbTimer"
        Me.cmbTimer.Size = New System.Drawing.Size(295, 32)
        Me.cmbTimer.TabIndex = 5
        Me.cmbTimer.Visible = False
        '
        'lblCounterTimer
        '
        Me.lblCounterTimer.BackColor = System.Drawing.Color.Black
        Me.lblCounterTimer.Font = New System.Drawing.Font("Courier New", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCounterTimer.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.lblCounterTimer.Location = New System.Drawing.Point(12, 23)
        Me.lblCounterTimer.Name = "lblCounterTimer"
        Me.lblCounterTimer.Size = New System.Drawing.Size(295, 52)
        Me.lblCounterTimer.TabIndex = 6
        Me.lblCounterTimer.Text = "Label1"
        Me.lblCounterTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'frm34VpnConnections
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(327, 348)
        Me.Controls.Add(Me.lblCounterTimer)
        Me.Controls.Add(Me.cmbTimer)
        Me.Controls.Add(Me.txtPassword)
        Me.Controls.Add(Me.txtUserName)
        Me.Controls.Add(Me.txtHost)
        Me.Controls.Add(Me.btnDisconnect)
        Me.Controls.Add(Me.btnConnect)
        Me.Name = "frm34VpnConnections"
        Me.Text = "VPN"
        CType(Me.txtHost.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtUserName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.txtPassword.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnConnect As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnDisconnect As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents txtHost As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtUserName As DevExpress.XtraEditors.TextEdit
    Friend WithEvents txtPassword As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Timer1 As Timer
    Friend WithEvents cmbTimer As ComboBox
    Friend WithEvents lblCounterTimer As Label
End Class
