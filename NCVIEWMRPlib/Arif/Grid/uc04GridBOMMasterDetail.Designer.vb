<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class uc04GridBOMMasterDetail
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me._gcBOM = New DevExpress.XtraGrid.GridControl()
        Me._gvBOM = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col01_k01cKodeFinishedGood_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col02_f01cItemCastedPartsDesc_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col03_f32dCreatedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me._gcBOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._gvBOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_gcBOM
        '
        Me._gcBOM.Location = New System.Drawing.Point(2, 2)
        Me._gcBOM.MainView = Me._gvBOM
        Me._gcBOM.Name = "_gcBOM"
        Me._gcBOM.Size = New System.Drawing.Size(1173, 637)
        Me._gcBOM.TabIndex = 4
        Me._gcBOM.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me._gvBOM})
        '
        '_gvBOM
        '
        Me._gvBOM.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col01_k01cKodeFinishedGood_v50, Me.col02_f01cItemCastedPartsDesc_v50, Me.col03_f32dCreatedDate})
        Me._gvBOM.GridControl = Me._gcBOM
        Me._gvBOM.Name = "_gvBOM"
        '
        'col01_k01cKodeFinishedGood_v50
        '
        Me.col01_k01cKodeFinishedGood_v50.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col01_k01cKodeFinishedGood_v50.AppearanceHeader.Options.UseFont = True
        Me.col01_k01cKodeFinishedGood_v50.Caption = "FG CODE"
        Me.col01_k01cKodeFinishedGood_v50.MinWidth = 30
        Me.col01_k01cKodeFinishedGood_v50.Name = "col01_k01cKodeFinishedGood_v50"
        Me.col01_k01cKodeFinishedGood_v50.Visible = True
        Me.col01_k01cKodeFinishedGood_v50.VisibleIndex = 0
        Me.col01_k01cKodeFinishedGood_v50.Width = 112
        '
        'col02_f01cItemCastedPartsDesc_v50
        '
        Me.col02_f01cItemCastedPartsDesc_v50.AppearanceHeader.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col02_f01cItemCastedPartsDesc_v50.AppearanceHeader.Options.UseFont = True
        Me.col02_f01cItemCastedPartsDesc_v50.Caption = "Item"
        Me.col02_f01cItemCastedPartsDesc_v50.MinWidth = 30
        Me.col02_f01cItemCastedPartsDesc_v50.Name = "col02_f01cItemCastedPartsDesc_v50"
        Me.col02_f01cItemCastedPartsDesc_v50.Visible = True
        Me.col02_f01cItemCastedPartsDesc_v50.VisibleIndex = 1
        Me.col02_f01cItemCastedPartsDesc_v50.Width = 112
        '
        'col03_f32dCreatedDate
        '
        Me.col03_f32dCreatedDate.Caption = "Created"
        Me.col03_f32dCreatedDate.MinWidth = 30
        Me.col03_f32dCreatedDate.Name = "col03_f32dCreatedDate"
        Me.col03_f32dCreatedDate.Visible = True
        Me.col03_f32dCreatedDate.VisibleIndex = 2
        Me.col03_f32dCreatedDate.Width = 112
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me._gcBOM)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1177, 641)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.Root.Name = "Root"
        Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.Root.Size = New System.Drawing.Size(1177, 641)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me._gcBOM
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1177, 641)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'uc04GridBOMMasterDetail
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "uc04GridBOMMasterDetail"
        Me.Size = New System.Drawing.Size(1177, 641)
        CType(Me._gcBOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._gvBOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents _gcBOM As DevExpress.XtraGrid.GridControl
    Friend WithEvents _gvBOM As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents col01_k01cKodeFinishedGood_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col02_f01cItemCastedPartsDesc_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col03_f32dCreatedDate As DevExpress.XtraGrid.Columns.GridColumn
End Class
