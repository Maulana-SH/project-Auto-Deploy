<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm50SearchLookupEdit
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frm50SearchLookupEdit))
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me._02Sle = New DevExpress.XtraEditors.SearchLookUpEdit()
        Me.SearchLookUpEdit1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me._01Master = New NCREPOSITORYlib.ctrl51SKKValueMaster()
        Me.Ctrl51SKKValueMaster1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me._03MultipelFCI = New NCREPOSITORYlib.ctrl22SKKFindingMultipleGLE()
        Me.Ctrl22SKKFindingMultipleGLE1View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        CType(Me._02Sle.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._01Master.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ctrl51SKKValueMaster1View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._03MultipelFCI.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Ctrl22SKKFindingMultipleGLE1View, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(579, 37)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(139, 34)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "load"
        '
        '_02Sle
        '
        Me._02Sle.Location = New System.Drawing.Point(17, 105)
        Me._02Sle.Name = "_02Sle"
        Me._02Sle.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._02Sle.Properties.PopupView = Me.SearchLookUpEdit1View
        Me._02Sle.Size = New System.Drawing.Size(458, 26)
        Me._02Sle.TabIndex = 2
        '
        'SearchLookUpEdit1View
        '
        Me.SearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.SearchLookUpEdit1View.Name = "SearchLookUpEdit1View"
        Me.SearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.SearchLookUpEdit1View.OptionsView.ShowGroupPanel = False
        '
        'LabelControl1
        '
        Me.LabelControl1.Location = New System.Drawing.Point(12, 0)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(36, 19)
        Me.LabelControl1.TabIndex = 3
        Me.LabelControl1.Text = "Class"
        '
        'LabelControl2
        '
        Me.LabelControl2.Location = New System.Drawing.Point(12, 70)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(128, 19)
        Me.LabelControl2.TabIndex = 4
        Me.LabelControl2.Text = "Default Devexpres"
        '
        '_01Master
        '
        Me._01Master._02prop_FilterKodeMasterSKK = Nothing
        Me._01Master._03Prop_IsEnamelMaster = False
        Me._01Master.Location = New System.Drawing.Point(17, 25)
        Me._01Master.Name = "_01Master"
        Me._01Master.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._01Master.Properties.PopupView = Me.Ctrl51SKKValueMaster1View
        Me._01Master.Size = New System.Drawing.Size(453, 26)
        Me._01Master.TabIndex = 0
        '
        'Ctrl51SKKValueMaster1View
        '
        Me.Ctrl51SKKValueMaster1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.Ctrl51SKKValueMaster1View.Name = "Ctrl51SKKValueMaster1View"
        Me.Ctrl51SKKValueMaster1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.Ctrl51SKKValueMaster1View.OptionsView.ShowGroupPanel = False
        '
        '_03MultipelFCI
        '
        Me._03MultipelFCI.Location = New System.Drawing.Point(17, 207)
        Me._03MultipelFCI.Name = "_03MultipelFCI"
        Me._03MultipelFCI.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._03MultipelFCI.Properties.PopupView = Me.Ctrl22SKKFindingMultipleGLE1View
        Me._03MultipelFCI.Size = New System.Drawing.Size(439, 26)
        Me._03MultipelFCI.TabIndex = 5
        '
        'Ctrl22SKKFindingMultipleGLE1View
        '
        Me.Ctrl22SKKFindingMultipleGLE1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.Ctrl22SKKFindingMultipleGLE1View.Name = "Ctrl22SKKFindingMultipleGLE1View"
        Me.Ctrl22SKKFindingMultipleGLE1View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.Ctrl22SKKFindingMultipleGLE1View.OptionsView.ShowGroupPanel = False
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Location = New System.Drawing.Point(508, 199)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(139, 34)
        Me.SimpleButton2.TabIndex = 6
        Me.SimpleButton2.Text = "load"
        '
        'LabelControl3
        '
        Me.LabelControl3.Location = New System.Drawing.Point(17, 182)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(155, 19)
        Me.LabelControl3.TabIndex = 7
        Me.LabelControl3.Text = "Class GridLookup Edit"
        '
        'frm50SearchLookupEdit
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1012, 554)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.SimpleButton2)
        Me.Controls.Add(Me._03MultipelFCI)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me._02Sle)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me._01Master)
        Me.Name = "frm50SearchLookupEdit"
        Me.Text = "frm50SearchLookupEdit"
        CType(Me._02Sle.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SearchLookUpEdit1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._01Master.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ctrl51SKKValueMaster1View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._03MultipelFCI.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Ctrl22SKKFindingMultipleGLE1View, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents _01Master As NCREPOSITORYlib.ctrl51SKKValueMaster
    Friend WithEvents Ctrl51SKKValueMaster1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents _02Sle As DevExpress.XtraEditors.SearchLookUpEdit
    Friend WithEvents SearchLookUpEdit1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents _03MultipelFCI As NCREPOSITORYlib.ctrl22SKKFindingMultipleGLE
    Friend WithEvents Ctrl22SKKFindingMultipleGLE1View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
End Class
