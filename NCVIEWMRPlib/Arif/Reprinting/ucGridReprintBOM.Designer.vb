<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucGridReprintBOM
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
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me._03cCheckAll = New DevExpress.XtraEditors.CheckEdit()
        Me._02cBtnPrint = New DevExpress.XtraEditors.SimpleButton()
        Me._01cCbprinterName = New DevExpress.XtraEditors.ComboBoxEdit()
        Me._gcBOM = New DevExpress.XtraGrid.GridControl()
        Me._gvBOM = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col09_nCheck = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col010_bCheck = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col01_k01cKodeProduct_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col02_f02cKodeDesignMaster_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col03_f01cNamaProduct_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col04_f05cTipeBRJDesc_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col05_f06cSize_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col06_f12cRawMaterialDesc_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col07_f32dCreatedDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col08_CopiesPrint = New DevExpress.XtraGrid.Columns.GridColumn()
        Me._rscol08_CopiesPrint = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.SimpleSeparator2 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me._03cCheckAll.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._01cCbprinterName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._gcBOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._gvBOM, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._rscol08_CopiesPrint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.BackColor = System.Drawing.Color.White
        Me.LayoutControl1.Controls.Add(Me._03cCheckAll)
        Me.LayoutControl1.Controls.Add(Me._02cBtnPrint)
        Me.LayoutControl1.Controls.Add(Me._01cCbprinterName)
        Me.LayoutControl1.Controls.Add(Me._gcBOM)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1171, 542)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        '_03cCheckAll
        '
        Me._03cCheckAll.Location = New System.Drawing.Point(42, 34)
        Me._03cCheckAll.Name = "_03cCheckAll"
        Me._03cCheckAll.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._03cCheckAll.Properties.Appearance.Options.UseFont = True
        Me._03cCheckAll.Properties.Caption = "Select All"
        Me._03cCheckAll.Size = New System.Drawing.Size(483, 29)
        Me._03cCheckAll.StyleController = Me.LayoutControl1
        Me._03cCheckAll.TabIndex = 10
        '
        '_02cBtnPrint
        '
        Me._02cBtnPrint.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me._02cBtnPrint.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._02cBtnPrint.Appearance.Options.UseBackColor = True
        Me._02cBtnPrint.Appearance.Options.UseFont = True
        Me._02cBtnPrint.Location = New System.Drawing.Point(529, 2)
        Me._02cBtnPrint.Name = "_02cBtnPrint"
        Me._02cBtnPrint.Size = New System.Drawing.Size(88, 32)
        Me._02cBtnPrint.StyleController = Me.LayoutControl1
        Me._02cBtnPrint.TabIndex = 6
        Me._02cBtnPrint.Text = "Print"
        '
        '_01cCbprinterName
        '
        Me._01cCbprinterName.Location = New System.Drawing.Point(128, 2)
        Me._01cCbprinterName.Name = "_01cCbprinterName"
        Me._01cCbprinterName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._01cCbprinterName.Size = New System.Drawing.Size(397, 28)
        Me._01cCbprinterName.StyleController = Me.LayoutControl1
        Me._01cCbprinterName.TabIndex = 5
        '
        '_gcBOM
        '
        Me._gcBOM.Location = New System.Drawing.Point(2, 67)
        Me._gcBOM.MainView = Me._gvBOM
        Me._gcBOM.Name = "_gcBOM"
        Me._gcBOM.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me._rscol08_CopiesPrint})
        Me._gcBOM.Size = New System.Drawing.Size(1167, 473)
        Me._gcBOM.TabIndex = 4
        Me._gcBOM.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me._gvBOM})
        '
        '_gvBOM
        '
        Me._gvBOM.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col09_nCheck, Me.col010_bCheck, Me.col01_k01cKodeProduct_v50, Me.col02_f02cKodeDesignMaster_v50, Me.col03_f01cNamaProduct_v50, Me.col04_f05cTipeBRJDesc_v50, Me.col05_f06cSize_v50, Me.col06_f12cRawMaterialDesc_v50, Me.col07_f32dCreatedDate, Me.col08_CopiesPrint})
        Me._gvBOM.GridControl = Me._gcBOM
        Me._gvBOM.Name = "_gvBOM"
        Me._gvBOM.OptionsView.ShowGroupPanel = False
        '
        'col09_nCheck
        '
        Me.col09_nCheck.Caption = "GridColumn1"
        Me.col09_nCheck.MinWidth = 30
        Me.col09_nCheck.Name = "col09_nCheck"
        Me.col09_nCheck.Visible = True
        Me.col09_nCheck.VisibleIndex = 0
        Me.col09_nCheck.Width = 112
        '
        'col010_bCheck
        '
        Me.col010_bCheck.Caption = "GridColumn2"
        Me.col010_bCheck.MinWidth = 30
        Me.col010_bCheck.Name = "col010_bCheck"
        Me.col010_bCheck.Visible = True
        Me.col010_bCheck.VisibleIndex = 1
        Me.col010_bCheck.Width = 112
        '
        'col01_k01cKodeProduct_v50
        '
        Me.col01_k01cKodeProduct_v50.Caption = "Product Code"
        Me.col01_k01cKodeProduct_v50.MinWidth = 30
        Me.col01_k01cKodeProduct_v50.Name = "col01_k01cKodeProduct_v50"
        Me.col01_k01cKodeProduct_v50.Visible = True
        Me.col01_k01cKodeProduct_v50.VisibleIndex = 2
        Me.col01_k01cKodeProduct_v50.Width = 112
        '
        'col02_f02cKodeDesignMaster_v50
        '
        Me.col02_f02cKodeDesignMaster_v50.Caption = "Master Code"
        Me.col02_f02cKodeDesignMaster_v50.MinWidth = 30
        Me.col02_f02cKodeDesignMaster_v50.Name = "col02_f02cKodeDesignMaster_v50"
        Me.col02_f02cKodeDesignMaster_v50.Visible = True
        Me.col02_f02cKodeDesignMaster_v50.VisibleIndex = 3
        Me.col02_f02cKodeDesignMaster_v50.Width = 112
        '
        'col03_f01cNamaProduct_v50
        '
        Me.col03_f01cNamaProduct_v50.Caption = "Product Name"
        Me.col03_f01cNamaProduct_v50.MinWidth = 30
        Me.col03_f01cNamaProduct_v50.Name = "col03_f01cNamaProduct_v50"
        Me.col03_f01cNamaProduct_v50.Visible = True
        Me.col03_f01cNamaProduct_v50.VisibleIndex = 4
        Me.col03_f01cNamaProduct_v50.Width = 112
        '
        'col04_f05cTipeBRJDesc_v50
        '
        Me.col04_f05cTipeBRJDesc_v50.Caption = "Item"
        Me.col04_f05cTipeBRJDesc_v50.MinWidth = 30
        Me.col04_f05cTipeBRJDesc_v50.Name = "col04_f05cTipeBRJDesc_v50"
        Me.col04_f05cTipeBRJDesc_v50.Visible = True
        Me.col04_f05cTipeBRJDesc_v50.VisibleIndex = 5
        Me.col04_f05cTipeBRJDesc_v50.Width = 112
        '
        'col05_f06cSize_v50
        '
        Me.col05_f06cSize_v50.Caption = "Brand"
        Me.col05_f06cSize_v50.MinWidth = 30
        Me.col05_f06cSize_v50.Name = "col05_f06cSize_v50"
        Me.col05_f06cSize_v50.Visible = True
        Me.col05_f06cSize_v50.VisibleIndex = 6
        Me.col05_f06cSize_v50.Width = 112
        '
        'col06_f12cRawMaterialDesc_v50
        '
        Me.col06_f12cRawMaterialDesc_v50.Caption = "Size"
        Me.col06_f12cRawMaterialDesc_v50.MinWidth = 30
        Me.col06_f12cRawMaterialDesc_v50.Name = "col06_f12cRawMaterialDesc_v50"
        Me.col06_f12cRawMaterialDesc_v50.Visible = True
        Me.col06_f12cRawMaterialDesc_v50.VisibleIndex = 7
        Me.col06_f12cRawMaterialDesc_v50.Width = 112
        '
        'col07_f32dCreatedDate
        '
        Me.col07_f32dCreatedDate.Caption = "Created"
        Me.col07_f32dCreatedDate.MinWidth = 30
        Me.col07_f32dCreatedDate.Name = "col07_f32dCreatedDate"
        Me.col07_f32dCreatedDate.Visible = True
        Me.col07_f32dCreatedDate.VisibleIndex = 8
        Me.col07_f32dCreatedDate.Width = 112
        '
        'col08_CopiesPrint
        '
        Me.col08_CopiesPrint.Caption = "Copies To"
        Me.col08_CopiesPrint.ColumnEdit = Me._rscol08_CopiesPrint
        Me.col08_CopiesPrint.MinWidth = 30
        Me.col08_CopiesPrint.Name = "col08_CopiesPrint"
        Me.col08_CopiesPrint.Visible = True
        Me.col08_CopiesPrint.VisibleIndex = 9
        Me.col08_CopiesPrint.Width = 112
        '
        '_rscol08_CopiesPrint
        '
        Me._rscol08_CopiesPrint.AutoHeight = False
        Me._rscol08_CopiesPrint.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._rscol08_CopiesPrint.Name = "_rscol08_CopiesPrint"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.SimpleSeparator1, Me.SimpleSeparator2, Me.LayoutControlItem4, Me.EmptySpaceItem1})
        Me.Root.Name = "Root"
        Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.Root.Size = New System.Drawing.Size(1171, 542)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me._gcBOM
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 65)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1171, 477)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.AppearanceItemCaption.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem2.Control = Me._01cCbprinterName
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 2, 2, 2)
        Me.LayoutControlItem2.Size = New System.Drawing.Size(527, 32)
        Me.LayoutControlItem2.Text = "Select Printer"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(120, 21)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me._02cBtnPrint
        Me.LayoutControlItem3.Location = New System.Drawing.Point(527, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(92, 36)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'SimpleSeparator1
        '
        Me.SimpleSeparator1.AllowHotTrack = False
        Me.SimpleSeparator1.Location = New System.Drawing.Point(619, 0)
        Me.SimpleSeparator1.Name = "SimpleSeparator1"
        Me.SimpleSeparator1.Size = New System.Drawing.Size(552, 65)
        '
        'SimpleSeparator2
        '
        Me.SimpleSeparator2.AllowHotTrack = False
        Me.SimpleSeparator2.Location = New System.Drawing.Point(527, 36)
        Me.SimpleSeparator2.Name = "SimpleSeparator2"
        Me.SimpleSeparator2.Size = New System.Drawing.Size(92, 29)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me._03cCheckAll
        Me.LayoutControlItem4.Location = New System.Drawing.Point(40, 32)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(487, 33)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 32)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(40, 33)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'ucGridReprintBOM
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "ucGridReprintBOM"
        Me.Size = New System.Drawing.Size(1171, 542)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me._03cCheckAll.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._01cCbprinterName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._gcBOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._gvBOM, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._rscol08_CopiesPrint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents _02cBtnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents _01cCbprinterName As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents _gcBOM As DevExpress.XtraGrid.GridControl
    Friend WithEvents _gvBOM As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents col01_k01cKodeProduct_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col02_f02cKodeDesignMaster_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col03_f01cNamaProduct_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col04_f05cTipeBRJDesc_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col07_f32dCreatedDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col05_f06cSize_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col06_f12cRawMaterialDesc_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col08_CopiesPrint As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents _rscol08_CopiesPrint As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents col09_nCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col010_bCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents SimpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents SimpleSeparator2 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents _03cCheckAll As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
End Class
