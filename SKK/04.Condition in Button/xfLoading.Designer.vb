<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xfLoadingFULL
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
        Me._pgLoding = New DevExpress.XtraWaitForm.ProgressPanel()
        Me.SuspendLayout()
        '
        '_pgLoding
        '
        Me._pgLoding.Appearance.BackColor = System.Drawing.Color.Transparent
        Me._pgLoding.Appearance.Options.UseBackColor = True
        Me._pgLoding.Location = New System.Drawing.Point(102, 51)
        Me._pgLoding.Name = "_pgLoding"
        Me._pgLoding.Size = New System.Drawing.Size(316, 91)
        Me._pgLoding.TabIndex = 0
        Me._pgLoding.Text = "ProgressPanel1"
        '
        'xfLoading
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 192)
        Me.ControlBox = False
        Me.Controls.Add(Me._pgLoding)
        Me.IconOptions.ShowIcon = False
        Me.Name = "xfLoading"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents _pgLoding As DevExpress.XtraWaitForm.ProgressPanel
End Class
