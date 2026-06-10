<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm24BM01PlayVideo
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me._01URL = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.TabMain = New System.Windows.Forms.TabControl()
        Me._02CountView = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        '_01URL
        '
        Me._01URL.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._01URL.Location = New System.Drawing.Point(25, 39)
        Me._01URL.Name = "_01URL"
        Me._01URL.Size = New System.Drawing.Size(911, 30)
        Me._01URL.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(1193, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(195, 66)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "PLAY"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'TabMain
        '
        Me.TabMain.Location = New System.Drawing.Point(12, 84)
        Me.TabMain.Name = "TabMain"
        Me.TabMain.SelectedIndex = 0
        Me.TabMain.Size = New System.Drawing.Size(1376, 566)
        Me.TabMain.TabIndex = 3
        '
        '_02CountView
        '
        Me._02CountView.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._02CountView.Location = New System.Drawing.Point(942, 39)
        Me._02CountView.Name = "_02CountView"
        Me._02CountView.Size = New System.Drawing.Size(100, 30)
        Me._02CountView.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(947, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 20)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "View To"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 20)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "URL Video"
        '
        'frm24BM01PlayVideo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1400, 650)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me._02CountView)
        Me.Controls.Add(Me.TabMain)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me._01URL)
        Me.Name = "frm24BM01PlayVideo"
        Me.Text = "frm24BM01PlayVideo"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _01URL As TextBox
    Friend WithEvents Button1 As Button
    Friend WithEvents TabMain As TabControl
    Friend WithEvents _02CountView As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
