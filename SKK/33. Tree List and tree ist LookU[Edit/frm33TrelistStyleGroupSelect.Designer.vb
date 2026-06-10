<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm33TrelistStyleGroupSelect
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
        Me._01MasterCOA = New SKK.clsCtrlTreeListLookupEditCOA()
        Me.ClsCtrlTreeListLookupEditCOA1TreeList = New DevExpress.XtraTreeList.TreeList()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col01_k03String = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col02_k04String = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col03_k05String = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col04_f01String = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me._01MasterCOA.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClsCtrlTreeListLookupEditCOA1TreeList, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_01MasterCOA
        '
        Me._01MasterCOA._01DataSource = Nothing
        Me._01MasterCOA.Id = Nothing
        Me._01MasterCOA.Kode = Nothing
        Me._01MasterCOA.LevelMaster = Nothing
        Me._01MasterCOA.Location = New System.Drawing.Point(39, 41)
        Me._01MasterCOA.Nama = Nothing
        Me._01MasterCOA.Name = "_01MasterCOA"
        Me._01MasterCOA.ParentId = Nothing
        Me._01MasterCOA.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._01MasterCOA.Properties.TreeList = Me.ClsCtrlTreeListLookupEditCOA1TreeList
        Me._01MasterCOA.Size = New System.Drawing.Size(490, 26)
        Me._01MasterCOA.TabIndex = 0
        '
        'ClsCtrlTreeListLookupEditCOA1TreeList
        '
        Me.ClsCtrlTreeListLookupEditCOA1TreeList.Location = New System.Drawing.Point(0, 0)
        Me.ClsCtrlTreeListLookupEditCOA1TreeList.Name = "ClsCtrlTreeListLookupEditCOA1TreeList"
        Me.ClsCtrlTreeListLookupEditCOA1TreeList.OptionsView.ShowIndentAsRowStyle = True
        Me.ClsCtrlTreeListLookupEditCOA1TreeList.Size = New System.Drawing.Size(400, 200)
        Me.ClsCtrlTreeListLookupEditCOA1TreeList.TabIndex = 0
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(535, 36)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(142, 34)
        Me.SimpleButton1.TabIndex = 1
        Me.SimpleButton1.Text = "Get "
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(30, 145)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1154, 373)
        Me.GridControl1.TabIndex = 2
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col01_k03String, Me.col02_k04String, Me.col03_k05String, Me.col04_f01String})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'col01_k03String
        '
        Me.col01_k03String.Caption = "FS"
        Me.col01_k03String.MinWidth = 30
        Me.col01_k03String.Name = "col01_k03String"
        Me.col01_k03String.Visible = True
        Me.col01_k03String.VisibleIndex = 0
        Me.col01_k03String.Width = 112
        '
        'col02_k04String
        '
        Me.col02_k04String.Caption = "Group Fs"
        Me.col02_k04String.MinWidth = 30
        Me.col02_k04String.Name = "col02_k04String"
        Me.col02_k04String.Visible = True
        Me.col02_k04String.VisibleIndex = 1
        Me.col02_k04String.Width = 112
        '
        'col03_k05String
        '
        Me.col03_k05String.Caption = "Kode Sub Group"
        Me.col03_k05String.MinWidth = 30
        Me.col03_k05String.Name = "col03_k05String"
        Me.col03_k05String.Visible = True
        Me.col03_k05String.VisibleIndex = 2
        Me.col03_k05String.Width = 112
        '
        'col04_f01String
        '
        Me.col04_f01String.Caption = "Account"
        Me.col04_f01String.MinWidth = 30
        Me.col04_f01String.Name = "col04_f01String"
        Me.col04_f01String.Visible = True
        Me.col04_f01String.VisibleIndex = 3
        Me.col04_f01String.Width = 112
        '
        'frm33TrelistStyleGroupSelect
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1234, 599)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me._01MasterCOA)
        Me.Name = "frm33TrelistStyleGroupSelect"
        Me.Text = "frm33TrelistStyleGroupSelect"
        CType(Me._01MasterCOA.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClsCtrlTreeListLookupEditCOA1TreeList, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents _01MasterCOA As clsCtrlTreeListLookupEditCOA
    Friend WithEvents ClsCtrlTreeListLookupEditCOA1TreeList As DevExpress.XtraTreeList.TreeList
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col01_k03String As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col02_k04String As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col03_k05String As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col04_f01String As DevExpress.XtraGrid.Columns.GridColumn
End Class
