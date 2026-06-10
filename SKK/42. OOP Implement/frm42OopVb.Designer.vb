<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm42OopVb
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me._01NIlai = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me._01NIlai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 19)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nilai"
        '
        '_01NIlai
        '
        Me._01NIlai.Location = New System.Drawing.Point(62, 104)
        Me._01NIlai.Name = "_01NIlai"
        Me._01NIlai.Size = New System.Drawing.Size(150, 26)
        Me._01NIlai.TabIndex = 0
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(62, 25)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(112, 31)
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "New Form"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(66, 161)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(112, 34)
        Me.SimpleButton2.TabIndex = 3
        Me.SimpleButton2.Text = "Cek"
        '
        'frm42OopVb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(509, 392)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me._01NIlai)
        Me.Name = "frm42OopVb"
        Me.Text = "frm42OopVb"
        CType(Me._01NIlai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _01NIlai As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
End Class
