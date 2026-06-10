<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucGridReprintDesignMasterStone
    Inherits DevExpress.XtraEditors.XtraUserControl

    'UserControl overrides dispose to clean up the component list.
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
        Me._btnShowPreview = New DevExpress.XtraEditors.SimpleButton()
        Me._gcDMS = New DevExpress.XtraGrid.GridControl()
        Me._gvDMS = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col01_nCheck = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col02_bCheck = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col12_Novalidasi = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col03_k01cKodeDesignMaster_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col04_f02cNamaBrand_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col05_f06cNamaNamingProduct_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col07_f17nGrossWeight_n94 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col08_f18cKodeSize_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col09_f08cNamaItemProduct_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col10_f10cNamaSubItemProduct_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col11_Copyto = New DevExpress.XtraGrid.Columns.GridColumn()
        Me._rscol11_Copyto = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me._01cCbprinterName = New DevExpress.XtraEditors.ComboBoxEdit()
        Me._02cCheckAll = New DevExpress.XtraEditors.CheckEdit()
        Me._btnPrint = New DevExpress.XtraEditors.SimpleButton()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me._gcDMS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._gvDMS, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._rscol11_Copyto, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._01cCbprinterName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._02cCheckAll.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me._btnShowPreview)
        Me.LayoutControl1.Controls.Add(Me._gcDMS)
        Me.LayoutControl1.Controls.Add(Me._01cCbprinterName)
        Me.LayoutControl1.Controls.Add(Me._02cCheckAll)
        Me.LayoutControl1.Controls.Add(Me._btnPrint)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1083, 622)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        '_btnShowPreview
        '
        Me._btnShowPreview.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question
        Me._btnShowPreview.Appearance.Font = New System.Drawing.Font("Arial", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnShowPreview.Appearance.Options.UseBackColor = True
        Me._btnShowPreview.Appearance.Options.UseFont = True
        Me._btnShowPreview.Location = New System.Drawing.Point(574, 14)
        Me._btnShowPreview.Name = "_btnShowPreview"
        Me._btnShowPreview.Size = New System.Drawing.Size(177, 32)
        Me._btnShowPreview.StyleController = Me.LayoutControl1
        Me._btnShowPreview.TabIndex = 17
        Me._btnShowPreview.Text = "Show Preview"
        '
        '_gcDMS
        '
        Me._gcDMS.Location = New System.Drawing.Point(5, 98)
        Me._gcDMS.MainView = Me._gvDMS
        Me._gcDMS.Name = "_gcDMS"
        Me._gcDMS.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me._rscol11_Copyto})
        Me._gcDMS.Size = New System.Drawing.Size(1073, 519)
        Me._gcDMS.TabIndex = 16
        Me._gcDMS.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me._gvDMS})
        '
        '_gvDMS
        '
        Me._gvDMS.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col01_nCheck, Me.col02_bCheck, Me.col12_Novalidasi, Me.col03_k01cKodeDesignMaster_v50, Me.col04_f02cNamaBrand_v50, Me.col05_f06cNamaNamingProduct_v50, Me.col07_f17nGrossWeight_n94, Me.col08_f18cKodeSize_v50, Me.col09_f08cNamaItemProduct_v50, Me.col10_f10cNamaSubItemProduct_v50, Me.col11_Copyto})
        Me._gvDMS.GridControl = Me._gcDMS
        Me._gvDMS.Name = "_gvDMS"
        Me._gvDMS.OptionsView.ShowGroupPanel = False
        '
        'col01_nCheck
        '
        Me.col01_nCheck.Caption = "GridColumn1"
        Me.col01_nCheck.MinWidth = 30
        Me.col01_nCheck.Name = "col01_nCheck"
        Me.col01_nCheck.Visible = True
        Me.col01_nCheck.VisibleIndex = 0
        Me.col01_nCheck.Width = 112
        '
        'col02_bCheck
        '
        Me.col02_bCheck.Caption = "Pilih"
        Me.col02_bCheck.MinWidth = 30
        Me.col02_bCheck.Name = "col02_bCheck"
        Me.col02_bCheck.Visible = True
        Me.col02_bCheck.VisibleIndex = 1
        Me.col02_bCheck.Width = 112
        '
        'col12_Novalidasi
        '
        Me.col12_Novalidasi.Caption = "No Validasi"
        Me.col12_Novalidasi.MinWidth = 30
        Me.col12_Novalidasi.Name = "col12_Novalidasi"
        Me.col12_Novalidasi.Visible = True
        Me.col12_Novalidasi.VisibleIndex = 2
        Me.col12_Novalidasi.Width = 112
        '
        'col03_k01cKodeDesignMaster_v50
        '
        Me.col03_k01cKodeDesignMaster_v50.Caption = "Master Code"
        Me.col03_k01cKodeDesignMaster_v50.MinWidth = 30
        Me.col03_k01cKodeDesignMaster_v50.Name = "col03_k01cKodeDesignMaster_v50"
        Me.col03_k01cKodeDesignMaster_v50.Visible = True
        Me.col03_k01cKodeDesignMaster_v50.VisibleIndex = 3
        Me.col03_k01cKodeDesignMaster_v50.Width = 112
        '
        'col04_f02cNamaBrand_v50
        '
        Me.col04_f02cNamaBrand_v50.Caption = "Brand"
        Me.col04_f02cNamaBrand_v50.MinWidth = 30
        Me.col04_f02cNamaBrand_v50.Name = "col04_f02cNamaBrand_v50"
        Me.col04_f02cNamaBrand_v50.Visible = True
        Me.col04_f02cNamaBrand_v50.VisibleIndex = 4
        Me.col04_f02cNamaBrand_v50.Width = 112
        '
        'col05_f06cNamaNamingProduct_v50
        '
        Me.col05_f06cNamaNamingProduct_v50.Caption = "Product"
        Me.col05_f06cNamaNamingProduct_v50.MinWidth = 30
        Me.col05_f06cNamaNamingProduct_v50.Name = "col05_f06cNamaNamingProduct_v50"
        Me.col05_f06cNamaNamingProduct_v50.Visible = True
        Me.col05_f06cNamaNamingProduct_v50.VisibleIndex = 5
        Me.col05_f06cNamaNamingProduct_v50.Width = 112
        '
        'col07_f17nGrossWeight_n94
        '
        Me.col07_f17nGrossWeight_n94.Caption = "Gross Weight"
        Me.col07_f17nGrossWeight_n94.DisplayFormat.FormatString = "n02"
        Me.col07_f17nGrossWeight_n94.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col07_f17nGrossWeight_n94.MinWidth = 30
        Me.col07_f17nGrossWeight_n94.Name = "col07_f17nGrossWeight_n94"
        Me.col07_f17nGrossWeight_n94.Visible = True
        Me.col07_f17nGrossWeight_n94.VisibleIndex = 6
        Me.col07_f17nGrossWeight_n94.Width = 112
        '
        'col08_f18cKodeSize_v50
        '
        Me.col08_f18cKodeSize_v50.Caption = "Size Code"
        Me.col08_f18cKodeSize_v50.MinWidth = 30
        Me.col08_f18cKodeSize_v50.Name = "col08_f18cKodeSize_v50"
        Me.col08_f18cKodeSize_v50.Visible = True
        Me.col08_f18cKodeSize_v50.VisibleIndex = 7
        Me.col08_f18cKodeSize_v50.Width = 112
        '
        'col09_f08cNamaItemProduct_v50
        '
        Me.col09_f08cNamaItemProduct_v50.Caption = "Item"
        Me.col09_f08cNamaItemProduct_v50.MinWidth = 30
        Me.col09_f08cNamaItemProduct_v50.Name = "col09_f08cNamaItemProduct_v50"
        Me.col09_f08cNamaItemProduct_v50.Visible = True
        Me.col09_f08cNamaItemProduct_v50.VisibleIndex = 8
        Me.col09_f08cNamaItemProduct_v50.Width = 112
        '
        'col10_f10cNamaSubItemProduct_v50
        '
        Me.col10_f10cNamaSubItemProduct_v50.Caption = "Sub Item"
        Me.col10_f10cNamaSubItemProduct_v50.MinWidth = 30
        Me.col10_f10cNamaSubItemProduct_v50.Name = "col10_f10cNamaSubItemProduct_v50"
        Me.col10_f10cNamaSubItemProduct_v50.Visible = True
        Me.col10_f10cNamaSubItemProduct_v50.VisibleIndex = 9
        Me.col10_f10cNamaSubItemProduct_v50.Width = 112
        '
        'col11_Copyto
        '
        Me.col11_Copyto.Caption = "Print To"
        Me.col11_Copyto.ColumnEdit = Me._rscol11_Copyto
        Me.col11_Copyto.MinWidth = 30
        Me.col11_Copyto.Name = "col11_Copyto"
        Me.col11_Copyto.Visible = True
        Me.col11_Copyto.VisibleIndex = 10
        Me.col11_Copyto.Width = 112
        '
        '_rscol11_Copyto
        '
        Me._rscol11_Copyto.AutoHeight = False
        Me._rscol11_Copyto.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._rscol11_Copyto.Name = "_rscol11_Copyto"
        '
        '_01cCbprinterName
        '
        Me._01cCbprinterName.Location = New System.Drawing.Point(113, 14)
        Me._01cCbprinterName.Name = "_01cCbprinterName"
        Me._01cCbprinterName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._01cCbprinterName.Size = New System.Drawing.Size(279, 28)
        Me._01cCbprinterName.StyleController = Me.LayoutControl1
        Me._01cCbprinterName.TabIndex = 5
        '
        '_02cCheckAll
        '
        Me._02cCheckAll.Location = New System.Drawing.Point(14, 50)
        Me._02cCheckAll.Name = "_02cCheckAll"
        Me._02cCheckAll.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._02cCheckAll.Properties.Appearance.Options.UseFont = True
        Me._02cCheckAll.Properties.Caption = "Select All"
        Me._02cCheckAll.Size = New System.Drawing.Size(117, 29)
        Me._02cCheckAll.StyleController = Me.LayoutControl1
        Me._02cCheckAll.TabIndex = 11
        '
        '_btnPrint
        '
        Me._btnPrint.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me._btnPrint.Appearance.Font = New System.Drawing.Font("Arial", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnPrint.Appearance.Options.UseBackColor = True
        Me._btnPrint.Appearance.Options.UseFont = True
        Me._btnPrint.Location = New System.Drawing.Point(396, 14)
        Me._btnPrint.Name = "_btnPrint"
        Me._btnPrint.Size = New System.Drawing.Size(174, 32)
        Me._btnPrint.StyleController = Me.LayoutControl1
        Me._btnPrint.TabIndex = 15
        Me._btnPrint.Text = "Print"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup2, Me.LayoutControlGroup3})
        Me.Root.Name = "Root"
        Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.Root.Size = New System.Drawing.Size(1083, 622)
        Me.Root.TextVisible = False
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.CustomizationFormText = "Options"
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(0, 93)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(1083, 529)
        Me.LayoutControlGroup2.Text = "Options"
        Me.LayoutControlGroup2.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me._gcDMS
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1077, 523)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.CustomizationFormText = "Options"
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem3, Me.EmptySpaceItem2, Me.LayoutControlItem5, Me.EmptySpaceItem1})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(1083, 93)
        Me.LayoutControlGroup3.Text = "Options"
        Me.LayoutControlGroup3.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me._01cCbprinterName
        Me.LayoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem2.CustomizationFormText = "Select Printer"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 2, 2, 2)
        Me.LayoutControlItem2.Size = New System.Drawing.Size(382, 36)
        Me.LayoutControlItem2.Text = "Select Printer"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(93, 19)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me._02cCheckAll
        Me.LayoutControlItem4.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem4.CustomizationFormText = "LayoutControlItem4"
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 36)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(121, 33)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me._btnPrint
        Me.LayoutControlItem3.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem3.CustomizationFormText = "LayoutControlItem3"
        Me.LayoutControlItem3.Location = New System.Drawing.Point(382, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(178, 36)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(121, 36)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(938, 33)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me._btnShowPreview
        Me.LayoutControlItem5.Location = New System.Drawing.Point(560, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(181, 36)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(741, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(318, 36)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'ucGridReprintDesignMasterStone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "ucGridReprintDesignMasterStone"
        Me.Size = New System.Drawing.Size(1083, 622)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me._gcDMS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._gvDMS, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._rscol11_Copyto, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._01cCbprinterName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._02cCheckAll.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents _01cCbprinterName As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents _02cCheckAll As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents _btnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents _gcDMS As DevExpress.XtraGrid.GridControl
    Friend WithEvents _gvDMS As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents col01_nCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col02_bCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col03_k01cKodeDesignMaster_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col04_f02cNamaBrand_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col05_f06cNamaNamingProduct_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col07_f17nGrossWeight_n94 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col08_f18cKodeSize_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col09_f08cNamaItemProduct_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col10_f10cNamaSubItemProduct_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col11_Copyto As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents _btnShowPreview As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents _rscol11_Copyto As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents col12_Novalidasi As DevExpress.XtraGrid.Columns.GridColumn
End Class
