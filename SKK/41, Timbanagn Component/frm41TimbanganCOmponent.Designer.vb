<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm41TimbanganCOmponent
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
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me._01BeratReal = New DevExpress.XtraEditors.SpinEdit()
        CType(Me._01BeratReal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(152, 28)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(172, 64)
        Me.SimpleButton1.TabIndex = 0
        Me.SimpleButton1.Text = "Konek Timbangan"
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(26, 171)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(36, 19)
        Me.LabelControl1.TabIndex = 2
        Me.LabelControl1.Text = "Berat"
        '
        '_01BeratReal
        '
        Me._01BeratReal.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me._01BeratReal.Location = New System.Drawing.Point(26, 196)
        Me._01BeratReal.Name = "_01BeratReal"
        Me._01BeratReal.Properties.Appearance.Font = New System.Drawing.Font("Courier New", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._01BeratReal.Properties.Appearance.Options.UseFont = True
        Me._01BeratReal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._01BeratReal.Properties.DisplayFormat.FormatString = "n2"
        Me._01BeratReal.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me._01BeratReal.Properties.EditFormat.FormatString = "n2"
        Me._01BeratReal.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me._01BeratReal.Size = New System.Drawing.Size(409, 42)
        Me._01BeratReal.TabIndex = 1
        '
        'frm41TimbanganCOmponent
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(485, 376)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me._01BeratReal)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Name = "frm41TimbanganCOmponent"
        Me.Text = "frm41TimbanganCOmponent"
        CType(Me._01BeratReal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents _01BeratReal As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
End Class
