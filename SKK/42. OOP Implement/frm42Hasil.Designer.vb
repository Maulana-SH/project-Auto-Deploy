<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm42Hasil
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.lblHasil = New DevExpress.XtraEditors.LabelControl()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(128, 54)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(34, 19)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Hasil"
        '
        'lblHasil
        '
        Me.lblHasil.Appearance.Font = New System.Drawing.Font("Tahoma", 28.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHasil.Appearance.Options.UseFont = True
        Me.lblHasil.Location = New System.Drawing.Point(108, 93)
        Me.lblHasil.Name = "lblHasil"
        Me.lblHasil.Size = New System.Drawing.Size(72, 68)
        Me.lblHasil.TabIndex = 1
        Me.lblHasil.Text = "00"
        '
        'frm42Hasil
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(298, 253)
        Me.Controls.Add(Me.lblHasil)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "frm42Hasil"
        Me.Text = "frm42Hasil"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblHasil As DevExpress.XtraEditors.LabelControl
End Class
