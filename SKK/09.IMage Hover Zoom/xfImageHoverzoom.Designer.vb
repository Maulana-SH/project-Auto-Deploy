<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class xfImageHoverzoom
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
        Me.panCloseup = New System.Windows.Forms.Panel()
        Me.picCloseup = New System.Windows.Forms.PictureBox()
        Me.picWhole = New System.Windows.Forms.PictureBox()
        Me.panCloseup.SuspendLayout()
        CType(Me.picCloseup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picWhole, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'panCloseup
        '
        Me.panCloseup.Controls.Add(Me.picCloseup)
        Me.panCloseup.Location = New System.Drawing.Point(576, 12)
        Me.panCloseup.Name = "panCloseup"
        Me.panCloseup.Size = New System.Drawing.Size(879, 624)
        Me.panCloseup.TabIndex = 1
        '
        'picCloseup
        '
        Me.picCloseup.Location = New System.Drawing.Point(3, 24)
        Me.picCloseup.Name = "picCloseup"
        Me.picCloseup.Size = New System.Drawing.Size(873, 613)
        Me.picCloseup.TabIndex = 1
        Me.picCloseup.TabStop = False
        '
        'picWhole
        '
        Me.picWhole.Image = Global.SKK.My.Resources.Resources.UTB8h0P5CarFXKJk43Ovq6ybnpXaQ
        Me.picWhole.Location = New System.Drawing.Point(95, 85)
        Me.picWhole.Name = "picWhole"
        Me.picWhole.Size = New System.Drawing.Size(399, 346)
        Me.picWhole.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picWhole.TabIndex = 0
        Me.picWhole.TabStop = False
        '
        'xfImageHoverzoom
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1492, 783)
        Me.Controls.Add(Me.panCloseup)
        Me.Controls.Add(Me.picWhole)
        Me.Name = "xfImageHoverzoom"
        Me.Text = "xfImageHoverzoom"
        Me.panCloseup.ResumeLayout(False)
        CType(Me.picCloseup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picWhole, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picWhole As PictureBox
    Friend WithEvents panCloseup As Panel
    Friend WithEvents picCloseup As PictureBox
End Class
