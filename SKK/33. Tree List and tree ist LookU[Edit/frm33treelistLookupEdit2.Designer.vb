<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frm33treelistLookupEdit2
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
        Me.TreeList2 = New DevExpress.XtraTreeList.TreeList()
        Me.TreeListLookUpEdit1 = New DevExpress.XtraEditors.TreeListLookUpEdit()
        Me.TreeListLookUpEdit1TreeList = New DevExpress.XtraTreeList.TreeList()
        Me._01EditValues = New DevExpress.XtraEditors.TextEdit()
        Me._02Text = New DevExpress.XtraEditors.TextEdit()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me._04Trelist = New NCREPOSITORYlib.ctrlCXTreelistLookUpedit()
        Me.CtrlCXTreelistLookUpedit1TreeList = New DevExpress.XtraTreeList.TreeList()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me._02CtrlDisplayText = New DevExpress.XtraEditors.TextEdit()
        Me._01CtrlEditValues = New DevExpress.XtraEditors.TextEdit()
        Me.TreeList1 = New DevExpress.XtraTreeList.TreeList()
        Me._02COA = New DevExpress.XtraEditors.TreeListLookUpEdit()
        Me.component = New SKK.clsCtrlTreeListLookupEditCOA()
        Me.ClsCtrlTreeListLookupEditCOA1TreeList = New DevExpress.XtraTreeList.TreeList()
        CType(Me.TreeList2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeListLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeListLookUpEdit1TreeList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._01EditValues.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._02Text.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._04Trelist.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CtrlCXTreelistLookUpedit1TreeList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._02CtrlDisplayText.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._01CtrlEditValues.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._02COA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.component.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClsCtrlTreeListLookupEditCOA1TreeList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TreeList2
        '
        Me.TreeList2.Location = New System.Drawing.Point(12, 417)
        Me.TreeList2.Name = "TreeList2"
        Me.TreeList2.Size = New System.Drawing.Size(972, 172)
        Me.TreeList2.TabIndex = 0
        Me.TreeList2.ViewStyle = DevExpress.XtraTreeList.TreeListViewStyle.TreeView
        '
        'TreeListLookUpEdit1
        '
        Me.TreeListLookUpEdit1.Location = New System.Drawing.Point(25, 91)
        Me.TreeListLookUpEdit1.Name = "TreeListLookUpEdit1"
        Me.TreeListLookUpEdit1.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.TreeListLookUpEdit1.Properties.TreeList = Me.TreeListLookUpEdit1TreeList
        Me.TreeListLookUpEdit1.Size = New System.Drawing.Size(335, 26)
        Me.TreeListLookUpEdit1.TabIndex = 1
        '
        'TreeListLookUpEdit1TreeList
        '
        Me.TreeListLookUpEdit1TreeList.Location = New System.Drawing.Point(0, 0)
        Me.TreeListLookUpEdit1TreeList.Name = "TreeListLookUpEdit1TreeList"
        Me.TreeListLookUpEdit1TreeList.OptionsView.ShowIndentAsRowStyle = True
        Me.TreeListLookUpEdit1TreeList.Size = New System.Drawing.Size(400, 200)
        Me.TreeListLookUpEdit1TreeList.TabIndex = 0
        '
        '_01EditValues
        '
        Me._01EditValues.Location = New System.Drawing.Point(112, 17)
        Me._01EditValues.Name = "_01EditValues"
        Me._01EditValues.Size = New System.Drawing.Size(240, 26)
        Me._01EditValues.TabIndex = 2
        '
        '_02Text
        '
        Me._02Text.Location = New System.Drawing.Point(112, 47)
        Me._02Text.Name = "_02Text"
        Me._02Text.Size = New System.Drawing.Size(240, 26)
        Me._02Text.TabIndex = 3
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(80, 19)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Edit Value"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Text"
        '
        '_04Trelist
        '
        Me._04Trelist._01DataSource = Nothing
        Me._04Trelist.Location = New System.Drawing.Point(505, 91)
        Me._04Trelist.Name = "_04Trelist"
        Me._04Trelist.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._04Trelist.Properties.TreeList = Me.CtrlCXTreelistLookUpedit1TreeList
        Me._04Trelist.Size = New System.Drawing.Size(331, 26)
        Me._04Trelist.TabIndex = 6
        '
        'CtrlCXTreelistLookUpedit1TreeList
        '
        Me.CtrlCXTreelistLookUpedit1TreeList.Location = New System.Drawing.Point(0, 0)
        Me.CtrlCXTreelistLookUpedit1TreeList.Name = "CtrlCXTreelistLookUpedit1TreeList"
        Me.CtrlCXTreelistLookUpedit1TreeList.OptionsView.ShowIndentAsRowStyle = True
        Me.CtrlCXTreelistLookUpedit1TreeList.Size = New System.Drawing.Size(400, 200)
        Me.CtrlCXTreelistLookUpedit1TreeList.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(414, 60)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 19)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Text"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(414, 29)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 19)
        Me.Label4.TabIndex = 9
        Me.Label4.Text = "Edit Value"
        '
        '_02CtrlDisplayText
        '
        Me._02CtrlDisplayText.Location = New System.Drawing.Point(505, 57)
        Me._02CtrlDisplayText.Name = "_02CtrlDisplayText"
        Me._02CtrlDisplayText.Size = New System.Drawing.Size(240, 26)
        Me._02CtrlDisplayText.TabIndex = 8
        '
        '_01CtrlEditValues
        '
        Me._01CtrlEditValues.Location = New System.Drawing.Point(505, 27)
        Me._01CtrlEditValues.Name = "_01CtrlEditValues"
        Me._01CtrlEditValues.Size = New System.Drawing.Size(240, 26)
        Me._01CtrlEditValues.TabIndex = 7
        '
        'TreeList1
        '
        Me.TreeList1.Location = New System.Drawing.Point(309, 200)
        Me.TreeList1.Name = "TreeList1"
        Me.TreeList1.OptionsView.ShowIndentAsRowStyle = True
        Me.TreeList1.Size = New System.Drawing.Size(400, 200)
        Me.TreeList1.TabIndex = 0
        '
        '_02COA
        '
        Me._02COA.Location = New System.Drawing.Point(25, 199)
        Me._02COA.Name = "_02COA"
        Me._02COA.Properties.AdvancedModeOptions.SelectionColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._02COA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._02COA.Properties.PopupBorderStyle = DevExpress.XtraEditors.Controls.PopupBorderStyles.NoBorder
        Me._02COA.Properties.TreeList = Me.TreeList1
        Me._02COA.Size = New System.Drawing.Size(327, 26)
        Me._02COA.TabIndex = 11
        '
        'component
        '
        Me.component._01DataSource = Nothing
        Me.component.Location = New System.Drawing.Point(505, 199)
        Me.component.Name = "component"
        Me.component.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.component.Properties.TreeList = Me.ClsCtrlTreeListLookupEditCOA1TreeList
        Me.component.Size = New System.Drawing.Size(331, 26)
        Me.component.TabIndex = 12
        '
        'ClsCtrlTreeListLookupEditCOA1TreeList
        '
        Me.ClsCtrlTreeListLookupEditCOA1TreeList.Location = New System.Drawing.Point(0, 0)
        Me.ClsCtrlTreeListLookupEditCOA1TreeList.Name = "ClsCtrlTreeListLookupEditCOA1TreeList"
        Me.ClsCtrlTreeListLookupEditCOA1TreeList.OptionsView.ShowIndentAsRowStyle = True
        Me.ClsCtrlTreeListLookupEditCOA1TreeList.Size = New System.Drawing.Size(400, 200)
        Me.ClsCtrlTreeListLookupEditCOA1TreeList.TabIndex = 0
        '
        'frm33treelistLookupEdit2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1019, 601)
        Me.Controls.Add(Me.component)
        Me.Controls.Add(Me._02COA)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me._02CtrlDisplayText)
        Me.Controls.Add(Me._01CtrlEditValues)
        Me.Controls.Add(Me._04Trelist)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me._02Text)
        Me.Controls.Add(Me._01EditValues)
        Me.Controls.Add(Me.TreeListLookUpEdit1)
        Me.Controls.Add(Me.TreeList2)
        Me.Name = "frm33treelistLookupEdit2"
        Me.Text = "frm33treelistV2"
        CType(Me.TreeList2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeListLookUpEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeListLookUpEdit1TreeList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._01EditValues.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._02Text.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._04Trelist.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CtrlCXTreelistLookUpedit1TreeList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._02CtrlDisplayText.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._01CtrlEditValues.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TreeList1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._02COA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.component.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClsCtrlTreeListLookupEditCOA1TreeList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TreeList2 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents TreeListLookUpEdit1 As DevExpress.XtraEditors.TreeListLookUpEdit
    Friend WithEvents TreeListLookUpEdit1TreeList As DevExpress.XtraTreeList.TreeList
    Friend WithEvents _01EditValues As DevExpress.XtraEditors.TextEdit
    Friend WithEvents _02Text As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents _04Trelist As NCREPOSITORYlib.ctrlCXTreelistLookUpedit
    Friend WithEvents CtrlCXTreelistLookUpedit1TreeList As DevExpress.XtraTreeList.TreeList
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents _02CtrlDisplayText As DevExpress.XtraEditors.TextEdit
    Friend WithEvents _01CtrlEditValues As DevExpress.XtraEditors.TextEdit
    Friend WithEvents TreeList1 As DevExpress.XtraTreeList.TreeList
    Friend WithEvents _02COA As DevExpress.XtraEditors.TreeListLookUpEdit
    Friend WithEvents component As clsCtrlTreeListLookupEditCOA
    Friend WithEvents ClsCtrlTreeListLookupEditCOA1TreeList As DevExpress.XtraTreeList.TreeList
End Class
