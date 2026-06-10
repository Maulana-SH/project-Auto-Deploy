<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmgrischeck
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
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col01nCheck = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col02bCheck = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col03KodePRO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col04NamaPRO = New DevExpress.XtraGrid.Columns.GridColumn()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(12, 66)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.Size = New System.Drawing.Size(1008, 542)
        Me.GridControl1.TabIndex = 0
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col01nCheck, Me.col02bCheck, Me.col03KodePRO, Me.col04NamaPRO})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        '
        'col01nCheck
        '
        Me.col01nCheck.Caption = "GridColumn1"
        Me.col01nCheck.MinWidth = 30
        Me.col01nCheck.Name = "col01nCheck"
        Me.col01nCheck.Visible = True
        Me.col01nCheck.VisibleIndex = 0
        Me.col01nCheck.Width = 112
        '
        'col02bCheck
        '
        Me.col02bCheck.Caption = "GridColumn2"
        Me.col02bCheck.MinWidth = 30
        Me.col02bCheck.Name = "col02bCheck"
        Me.col02bCheck.Visible = True
        Me.col02bCheck.VisibleIndex = 1
        Me.col02bCheck.Width = 112
        '
        'col03KodePRO
        '
        Me.col03KodePRO.Caption = "GridColumn3"
        Me.col03KodePRO.MinWidth = 30
        Me.col03KodePRO.Name = "col03KodePRO"
        Me.col03KodePRO.Visible = True
        Me.col03KodePRO.VisibleIndex = 2
        Me.col03KodePRO.Width = 112
        '
        'col04NamaPRO
        '
        Me.col04NamaPRO.Caption = "GridColumn4"
        Me.col04NamaPRO.MinWidth = 30
        Me.col04NamaPRO.Name = "col04NamaPRO"
        Me.col04NamaPRO.Visible = True
        Me.col04NamaPRO.VisibleIndex = 3
        Me.col04NamaPRO.Width = 112
        '
        'frmgrischeck
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1032, 620)
        Me.Controls.Add(Me.GridControl1)
        Me.Name = "frmgrischeck"
        Me.Text = "frmgrischeck"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents col01nCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col02bCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col03KodePRO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col04NamaPRO As DevExpress.XtraGrid.Columns.GridColumn
End Class
