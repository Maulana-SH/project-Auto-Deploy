<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frm47PIVOTdataCUSTOM
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
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControl2 = New DevExpress.XtraLayout.LayoutControl()
        Me.PivotGridControl1 = New DevExpress.XtraPivotGrid.PivotGridControl()
        Me.pcCol01_f02Int = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pcCol02_f03Int = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pcCol03_f02String = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.pcCol04_f01Double = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.col_2024 = New DevExpress.XtraPivotGrid.PivotGridField()
        Me.col_2023 = New DevExpress.XtraPivotGrid.PivotGridField()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl2.SuspendLayout()
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Location = New System.Drawing.Point(411, 229)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(8, 8)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(20, 20)
        Me.Root.TextVisible = False
        '
        'LayoutControl2
        '
        Me.LayoutControl2.Controls.Add(Me.PivotGridControl1)
        Me.LayoutControl2.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl2.Name = "LayoutControl2"
        Me.LayoutControl2.Root = Me.LayoutControlGroup1
        Me.LayoutControl2.Size = New System.Drawing.Size(1659, 685)
        Me.LayoutControl2.TabIndex = 1
        Me.LayoutControl2.Text = "LayoutControl2"
        '
        'PivotGridControl1
        '
        Me.PivotGridControl1.Fields.AddRange(New DevExpress.XtraPivotGrid.PivotGridField() {Me.pcCol01_f02Int, Me.pcCol02_f03Int, Me.pcCol03_f02String, Me.pcCol04_f01Double, Me.col_2024, Me.col_2023})
        Me.PivotGridControl1.Location = New System.Drawing.Point(12, 48)
        Me.PivotGridControl1.Name = "PivotGridControl1"
        Me.PivotGridControl1.OptionsData.DataProcessingEngine = DevExpress.XtraPivotGrid.PivotDataProcessingEngine.Optimized
        Me.PivotGridControl1.Size = New System.Drawing.Size(1635, 625)
        Me.PivotGridControl1.TabIndex = 6
        '
        'pcCol01_f02Int
        '
        Me.pcCol01_f02Int.AreaIndex = 0
        Me.pcCol01_f02Int.Caption = "Tahun"
        Me.pcCol01_f02Int.CellFormat.FormatString = "n0"
        Me.pcCol01_f02Int.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.pcCol01_f02Int.GrandTotalCellFormat.FormatString = "n0"
        Me.pcCol01_f02Int.GrandTotalCellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.pcCol01_f02Int.Name = "pcCol01_f02Int"
        Me.pcCol01_f02Int.ValueFormat.FormatString = "n0"
        Me.pcCol01_f02Int.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'pcCol02_f03Int
        '
        Me.pcCol02_f03Int.Area = DevExpress.XtraPivotGrid.PivotArea.RowArea
        Me.pcCol02_f03Int.AreaIndex = 0
        Me.pcCol02_f03Int.Caption = "Bulan"
        Me.pcCol02_f03Int.CellFormat.FormatString = "n0"
        Me.pcCol02_f03Int.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.pcCol02_f03Int.Name = "pcCol02_f03Int"
        Me.pcCol02_f03Int.ValueFormat.FormatString = "n0"
        Me.pcCol02_f03Int.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'pcCol03_f02String
        '
        Me.pcCol03_f02String.AreaIndex = 1
        Me.pcCol03_f02String.Caption = "Brand"
        Me.pcCol03_f02String.Name = "pcCol03_f02String"
        '
        'pcCol04_f01Double
        '
        Me.pcCol04_f01Double.AreaIndex = 2
        Me.pcCol04_f01Double.Caption = "Weight"
        Me.pcCol04_f01Double.CellFormat.FormatString = "n3"
        Me.pcCol04_f01Double.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.pcCol04_f01Double.Name = "pcCol04_f01Double"
        Me.pcCol04_f01Double.ValueFormat.FormatString = "n3"
        Me.pcCol04_f01Double.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(12, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(1635, 32)
        Me.SimpleButton1.StyleController = Me.LayoutControl2
        Me.SimpleButton1.TabIndex = 5
        Me.SimpleButton1.Text = "SimpleButton1"
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup1.GroupBordersVisible = False
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2})
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1659, 685)
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.PivotGridControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 36)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1639, 629)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.SimpleButton1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(1639, 36)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'col_2024
        '
        Me.col_2024.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.col_2024.AreaIndex = 0
        Me.col_2024.Caption = "2024"
        Me.col_2024.CellFormat.FormatString = "n3"
        Me.col_2024.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_2024.Name = "col_2024"
        Me.col_2024.ValueFormat.FormatString = "n3"
        Me.col_2024.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'col_2023
        '
        Me.col_2023.Area = DevExpress.XtraPivotGrid.PivotArea.DataArea
        Me.col_2023.AreaIndex = 1
        Me.col_2023.Caption = "2023"
        Me.col_2023.CellFormat.FormatString = "n3"
        Me.col_2023.CellFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col_2023.Name = "col_2023"
        Me.col_2023.ValueFormat.FormatString = "n3"
        Me.col_2023.ValueFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        '
        'frm47PIVOTdataCUSTOM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1659, 685)
        Me.Controls.Add(Me.LayoutControl2)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frm47PIVOTdataCUSTOM"
        Me.Text = "frm47PIVOTdataCUSTOM"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl2.ResumeLayout(False)
        CType(Me.PivotGridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControl2 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents PivotGridControl1 As DevExpress.XtraPivotGrid.PivotGridControl
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents pcCol01_f02Int As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pcCol02_f03Int As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pcCol03_f02String As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents pcCol04_f01Double As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents col_2024 As DevExpress.XtraPivotGrid.PivotGridField
    Friend WithEvents col_2023 As DevExpress.XtraPivotGrid.PivotGridField
End Class
