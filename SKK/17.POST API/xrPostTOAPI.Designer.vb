<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xrPostTOAPI
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
        Me.btnSend = New DevExpress.XtraEditors.SimpleButton()
        Me._01Data = New DevExpress.XtraEditors.MemoEdit()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton3 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton4 = New DevExpress.XtraEditors.SimpleButton()
        Me.result = New DevExpress.XtraEditors.MemoEdit()
        Me._NoDOTI = New DevExpress.XtraEditors.TextEdit()
        CType(Me._01Data.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.result.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._NoDOTI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSend
        '
        Me.btnSend.Location = New System.Drawing.Point(12, 12)
        Me.btnSend.Name = "btnSend"
        Me.btnSend.Size = New System.Drawing.Size(155, 33)
        Me.btnSend.TabIndex = 0
        Me.btnSend.Text = "Send"
        '
        '_01Data
        '
        Me._01Data.Location = New System.Drawing.Point(12, 93)
        Me._01Data.Name = "_01Data"
        Me._01Data.Properties.Appearance.BackColor = System.Drawing.Color.White
        Me._01Data.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._01Data.Properties.Appearance.ForeColor = System.Drawing.Color.Black
        Me._01Data.Properties.Appearance.Options.UseBackColor = True
        Me._01Data.Properties.Appearance.Options.UseFont = True
        Me._01Data.Properties.Appearance.Options.UseForeColor = True
        Me._01Data.Properties.Appearance.Options.UseTextOptions = True
        Me._01Data.Properties.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Near
        Me._01Data.Size = New System.Drawing.Size(419, 311)
        Me._01Data.TabIndex = 1
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(988, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(194, 42)
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "poST tO apI"
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(173, 12)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(130, 33)
        Me.SimpleButton2.TabIndex = 3
        Me.SimpleButton2.Text = "CekKoneksi"
        '
        'SimpleButton3
        '
        Me.SimpleButton3.Location = New System.Drawing.Point(473, 12)
        Me.SimpleButton3.Name = "SimpleButton3"
        Me.SimpleButton3.Size = New System.Drawing.Size(134, 33)
        Me.SimpleButton3.TabIndex = 4
        Me.SimpleButton3.Text = "Hpus %"
        '
        'SimpleButton4
        '
        Me.SimpleButton4.Location = New System.Drawing.Point(12, 51)
        Me.SimpleButton4.Name = "SimpleButton4"
        Me.SimpleButton4.Size = New System.Drawing.Size(149, 33)
        Me.SimpleButton4.TabIndex = 5
        Me.SimpleButton4.Text = "GEt Json Respon"
        '
        'result
        '
        Me.result.Location = New System.Drawing.Point(644, 93)
        Me.result.Name = "result"
        Me.result.Size = New System.Drawing.Size(780, 145)
        Me.result.TabIndex = 6
        '
        '_NoDOTI
        '
        Me._NoDOTI.Location = New System.Drawing.Point(698, 19)
        Me._NoDOTI.Name = "_NoDOTI"
        Me._NoDOTI.Size = New System.Drawing.Size(273, 26)
        Me._NoDOTI.TabIndex = 7
        '
        'xrPostTOAPI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1436, 743)
        Me.Controls.Add(Me._NoDOTI)
        Me.Controls.Add(Me.result)
        Me.Controls.Add(Me.SimpleButton4)
        Me.Controls.Add(Me.SimpleButton3)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me._01Data)
        Me.Controls.Add(Me.btnSend)
        Me.Name = "xrPostTOAPI"
        Me.Text = "xrPostTOAPI"
        CType(Me._01Data.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.result.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._NoDOTI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSend As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents _01Data As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton3 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton4 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents result As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents _NoDOTI As DevExpress.XtraEditors.TextEdit
End Class
