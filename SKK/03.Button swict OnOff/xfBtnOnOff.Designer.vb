<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xfBtnOnOff
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
        Me._tgsOnOff = New DevExpress.XtraEditors.ToggleSwitch()
        Me._02cStatus = New DevExpress.XtraEditors.TextEdit()
        CType(Me._tgsOnOff.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._02cStatus.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_tgsOnOff
        '
        Me._tgsOnOff.Location = New System.Drawing.Point(50, 30)
        Me._tgsOnOff.Name = "_tgsOnOff"
        Me._tgsOnOff.Properties.Appearance.Font = New System.Drawing.Font("HelveticaNeue", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._tgsOnOff.Properties.Appearance.Options.UseFont = True
        Me._tgsOnOff.Properties.OffText = "Off"
        Me._tgsOnOff.Properties.OnText = "On"
        Me._tgsOnOff.Size = New System.Drawing.Size(115, 29)
        Me._tgsOnOff.TabIndex = 0
        '
        '_02cStatus
        '
        Me._02cStatus.Location = New System.Drawing.Point(50, 65)
        Me._02cStatus.Name = "_02cStatus"
        Me._02cStatus.Size = New System.Drawing.Size(188, 28)
        Me._02cStatus.TabIndex = 1
        '
        'xfBtnOnOff
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(707, 403)
        Me.Controls.Add(Me._02cStatus)
        Me.Controls.Add(Me._tgsOnOff)
        Me.Name = "xfBtnOnOff"
        Me.Text = "xfBtnOnOff"
        CType(Me._tgsOnOff.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._02cStatus.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents _tgsOnOff As DevExpress.XtraEditors.ToggleSwitch
    Friend WithEvents _02cStatus As DevExpress.XtraEditors.TextEdit
End Class
