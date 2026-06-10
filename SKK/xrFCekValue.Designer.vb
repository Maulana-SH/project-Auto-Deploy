<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xrFCekValue
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xrFCekValue))
        Me.TextEdit1 = New DevExpress.XtraEditors.TextEdit()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.gridBON = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.masterKadar = New NCREPOSITORYlib.ctrl51SKKValueMaster()
        Me.Ctrl51SKKValueMaster1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gridBON, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.masterKadar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ctrl51SKKValueMaster1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TextEdit1
        '
        Me.TextEdit1.Location = New System.Drawing.Point(12, 12)
        Me.TextEdit1.Name = "TextEdit1"
        Me.TextEdit1.Size = New System.Drawing.Size(223, 26)
        Me.TextEdit1.TabIndex = 0
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(241, 12)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(130, 45)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "CEK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'gridBON
        '
        Me.gridBON.Location = New System.Drawing.Point(57, 184)
        Me.gridBON.MainView = Me.GridView1
        Me.gridBON.Name = "gridBON"
        Me.gridBON.Size = New System.Drawing.Size(757, 377)
        Me.gridBON.TabIndex = 2
        Me.gridBON.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.GridControl = Me.gridBON
        Me.GridView1.Name = "GridView1"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(57, 133)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(159, 45)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "CEK"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'masterKadar
        '
        Me.masterKadar._02prop_FilterKodeMasterSKK = Nothing
        Me.masterKadar._03Prop_IsEnamelMaster = False
        Me.masterKadar.Location = New System.Drawing.Point(512, 69)
        Me.masterKadar.Name = "masterKadar"
        Me.masterKadar.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.masterKadar.Properties.PopupView = Me.Ctrl51SKKValueMaster1View
        Me.masterKadar.Size = New System.Drawing.Size(364, 26)
        Me.masterKadar.TabIndex = 4
        '
        'Ctrl51SKKValueMaster1View
        '
        Me.Ctrl51SKKValueMaster1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.Ctrl51SKKValueMaster1View.Name = "Ctrl51SKKValueMaster1View"
        Me.Ctrl51SKKValueMaster1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.Ctrl51SKKValueMaster1View.OptionsView.ShowGroupPanel = False
        '
        'xrFCekValue
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1059, 610)
        Me.Controls.Add(Me.masterKadar)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.gridBON)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextEdit1)
        Me.Name = "xrFCekValue"
        Me.Text = "xrFCekValue"
        CType(Me.TextEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gridBON, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.masterKadar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ctrl51SKKValueMaster1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextEdit1 As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Button1 As Button
    Friend WithEvents gridBON As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Button2 As Button
    Friend WithEvents masterKadar As NCREPOSITORYlib.ctrl51SKKValueMaster
    Friend WithEvents Ctrl51SKKValueMaster1View As DevExpress.XtraGrid.Views.Grid.GridView
End Class
