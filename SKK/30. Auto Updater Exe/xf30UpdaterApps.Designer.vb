<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class xf30UpdaterApps
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
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
    Private Sub InitializeComponent()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me._01Url = New DevExpress.XtraEditors.TextEdit()
        CType(Me._01Url.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Tahoma", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl1.Appearance.Options.UseFont = True
        Me.LabelControl1.Location = New System.Drawing.Point(174, 58)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(108, 34)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "V. 2.0.3"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(132, 221)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(173, 34)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "Cek Updated"
        '
        '_01Url
        '
        Me._01Url.Location = New System.Drawing.Point(12, 160)
        Me._01Url.Name = "_01Url"
        Me._01Url.Size = New System.Drawing.Size(446, 26)
        Me._01Url.TabIndex = 2
        '
        'xf30UpdaterApps
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(470, 406)
        Me.Controls.Add(Me._01Url)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.LabelControl1)
        Me.Name = "xf30UpdaterApps"
        Me.Text = "xf30UpdaterApps"
        CType(Me._01Url.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents _01Url As DevExpress.XtraEditors.TextEdit
End Class
