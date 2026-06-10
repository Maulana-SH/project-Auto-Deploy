<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xf48LabelPrinting
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
        Me._01Text = New DevExpress.XtraEditors.MemoEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me._01Nilai = New DevExpress.XtraEditors.SpinEdit()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.lbHasil = New DevExpress.XtraEditors.LabelControl()
        CType(Me._01Text.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._01Nilai.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_01Text
        '
        Me._01Text.Location = New System.Drawing.Point(12, -2)
        Me._01Text.Name = "_01Text"
        Me._01Text.Size = New System.Drawing.Size(809, 356)
        Me._01Text.TabIndex = 0
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 360)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(112, 34)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "Print Label"
        '
        '_01Nilai
        '
        Me._01Nilai.EditValue = New Decimal(New Integer() {0, 0, 0, 0})
        Me._01Nilai.Location = New System.Drawing.Point(105, 481)
        Me._01Nilai.Name = "_01Nilai"
        Me._01Nilai.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._01Nilai.Properties.Appearance.Options.UseFont = True
        Me._01Nilai.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._01Nilai.Properties.DisplayFormat.FormatString = "Rp. {0:n3}"
        Me._01Nilai.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me._01Nilai.Properties.EditFormat.FormatString = "n3"
        Me._01Nilai.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me._01Nilai.Size = New System.Drawing.Size(238, 30)
        Me._01Nilai.TabIndex = 2
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(349, 480)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(112, 34)
        Me.SimpleButton2.TabIndex = 3
        Me.SimpleButton2.Text = "pembulatan"
        '
        'lbHasil
        '
        Me.lbHasil.Appearance.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbHasil.Appearance.Options.UseFont = True
        Me.lbHasil.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.Horizontal
        Me.lbHasil.Location = New System.Drawing.Point(105, 529)
        Me.lbHasil.Name = "lbHasil"
        Me.lbHasil.Size = New System.Drawing.Size(125, 22)
        Me.lbHasil.TabIndex = 4
        Me.lbHasil.Text = "LabelControl1"
        '
        'xf48LabelPrinting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(833, 713)
        Me.Controls.Add(Me.lbHasil)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me._01Nilai)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me._01Text)
        Me.Name = "xf48LabelPrinting"
        Me.Text = "xf48LabelPrinting"
        CType(Me._01Text.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._01Nilai.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _01Text As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents _01Nilai As DevExpress.XtraEditors.SpinEdit
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lbHasil As DevExpress.XtraEditors.LabelControl
End Class
