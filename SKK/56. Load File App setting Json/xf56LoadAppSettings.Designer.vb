<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xf56LoadAppSettings
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
        Me.btnGEt = New DevExpress.XtraEditors.SimpleButton()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SuspendLayout()
        '
        'btnGEt
        '
        Me.btnGEt.Location = New System.Drawing.Point(52, 68)
        Me.btnGEt.Name = "btnGEt"
        Me.btnGEt.Size = New System.Drawing.Size(112, 34)
        Me.btnGEt.TabIndex = 0
        Me.btnGEt.Text = "GET Data"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(52, 139)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(935, 407)
        Me.RichTextBox1.TabIndex = 1
        Me.RichTextBox1.Text = ""
        '
        'xf56LoadAppSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1060, 587)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.btnGEt)
        Me.Name = "xf56LoadAppSettings"
        Me.Text = "xf56LoadAppSettings"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnGEt As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RichTextBox1 As RichTextBox
End Class
