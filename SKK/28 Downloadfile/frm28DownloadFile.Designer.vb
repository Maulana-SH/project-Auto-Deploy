<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm28DownloadFile
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
        Me._01patch = New DevExpress.XtraEditors.TextEdit()
        CType(Me._01patch.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(573, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(118, 40)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "Download"
        '
        '_01patch
        '
        Me._01patch.Location = New System.Drawing.Point(12, 12)
        Me._01patch.Name = "_01patch"
        Me._01patch.Size = New System.Drawing.Size(555, 26)
        Me._01patch.TabIndex = 1
        '
        'frm28DownloadFile
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1216, 640)
        Me.Controls.Add(Me._01patch)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Name = "frm28DownloadFile"
        Me.Text = "frm28DownloadFile"
        CType(Me._01patch.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents _01patch As DevExpress.XtraEditors.TextEdit
End Class
