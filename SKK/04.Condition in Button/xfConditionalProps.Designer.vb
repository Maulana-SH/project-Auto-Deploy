<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xfConditionalProps
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
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.lblStatus = New DevExpress.XtraEditors.LabelControl()
        Me.pnlLoading = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.SuspendLayout()
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(48, 249)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(112, 34)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "Klik"
        '
        'lblStatus
        '
        Me.lblStatus.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStatus.Appearance.Options.UseFont = True
        Me.lblStatus.Location = New System.Drawing.Point(48, 159)
        Me.lblStatus.Name = "lblStatus"
        Me.lblStatus.Size = New System.Drawing.Size(64, 24)
        Me.lblStatus.TabIndex = 1
        Me.lblStatus.Text = "Status"
        '
        'pnlLoading
        '
        Me.pnlLoading.Appearance.BackColor = System.Drawing.Color.Transparent
        Me.pnlLoading.Appearance.Options.UseBackColor = True
        Me.pnlLoading.Location = New System.Drawing.Point(323, 159)
        Me.pnlLoading.Name = "pnlLoading"
        Me.pnlLoading.Size = New System.Drawing.Size(246, 66)
        Me.pnlLoading.TabIndex = 2
        Me.pnlLoading.Text = "ProgressPanel1"
        '
        'xfConditionalProps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(942, 538)
        Me.Controls.Add(Me.pnlLoading)
        Me.Controls.Add(Me.lblStatus)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Name = "xfConditionalProps"
        Me.Text = "xfConditionalProps"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lblStatus As DevExpress.XtraEditors.LabelControl
    Friend WithEvents pnlLoading As DevExpress.XtraWaitForm.ProgressPanel
End Class
