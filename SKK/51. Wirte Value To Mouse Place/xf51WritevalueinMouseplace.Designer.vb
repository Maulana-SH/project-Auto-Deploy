<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xf51WritevalueinMouseplace
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
        Me.cpnTimbangan = New SKK.cpn22CK01Timbangan()
        Me._03Berat = New DevExpress.XtraEditors.SpinEdit()
        CType(Me._03Berat.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(26, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(191, 67)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "Start"
        '
        'cpnTimbangan
        '
        Me.cpnTimbangan.Location = New System.Drawing.Point(254, -3)
        Me.cpnTimbangan.Name = "cpnTimbangan"
        Me.cpnTimbangan.Size = New System.Drawing.Size(506, 284)
        Me.cpnTimbangan.TabIndex = 1
        '
        '_03Berat
        '
        Me._03Berat.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me._03Berat.Location = New System.Drawing.Point(305, 301)
        Me._03Berat.Name = "_03Berat"
        Me._03Berat.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._03Berat.Properties.DisplayFormat.FormatString = "n2"
        Me._03Berat.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me._03Berat.Properties.EditFormat.FormatString = "n2"
        Me._03Berat.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me._03Berat.Size = New System.Drawing.Size(150, 28)
        Me._03Berat.TabIndex = 2
        '
        'xf51WritevalueinMouseplace
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(772, 492)
        Me.Controls.Add(Me._03Berat)
        Me.Controls.Add(Me.cpnTimbangan)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Name = "xf51WritevalueinMouseplace"
        Me.Text = "xf51WritevalueinMouseplace"
        CType(Me._03Berat.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents cpnTimbangan As cpn22CK01Timbangan
    Friend WithEvents _03Berat As DevExpress.XtraEditors.SpinEdit
End Class
