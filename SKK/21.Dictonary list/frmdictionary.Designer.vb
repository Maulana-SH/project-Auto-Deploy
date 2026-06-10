<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmdictionary
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
        Me._01Buah = New DevExpress.XtraEditors.TextEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        CType(Me._01Buah.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_01Buah
        '
        Me._01Buah.Location = New System.Drawing.Point(26, 46)
        Me._01Buah.Name = "_01Buah"
        Me._01Buah.Size = New System.Drawing.Size(230, 26)
        Me._01Buah.TabIndex = 0
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(26, 78)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(112, 34)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "Add"
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(507, 32)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(562, 524)
        Me.RichTextBox1.TabIndex = 2
        Me.RichTextBox1.Text = ""
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(144, 78)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(112, 34)
        Me.SimpleButton2.TabIndex = 3
        Me.SimpleButton2.Text = "Delete"
        '
        'frmdictionary
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1081, 568)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.RichTextBox1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me._01Buah)
        Me.Name = "frmdictionary"
        Me.Text = "frmdictionary"
        CType(Me._01Buah.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents _01Buah As DevExpress.XtraEditors.TextEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents RichTextBox1 As RichTextBox
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
End Class
