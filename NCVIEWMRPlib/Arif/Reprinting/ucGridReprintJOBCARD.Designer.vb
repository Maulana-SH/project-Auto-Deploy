<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucGridReprintJOBCARD
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
        Dim WindowsUIButtonImageOptions1 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucGridReprintJOBCARD))
        Dim WindowsUIButtonImageOptions2 As DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions = New DevExpress.XtraBars.Docking2010.WindowsUIButtonImageOptions()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me._btnPrintPreview = New DevExpress.XtraEditors.SimpleButton()
        Me._btnPrint = New DevExpress.XtraEditors.SimpleButton()
        Me._WUIBPanel = New DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel()
        Me._02cCheckAll = New DevExpress.XtraEditors.CheckEdit()
        Me._gcJOBCARD = New DevExpress.XtraGrid.GridControl()
        Me._gvJOBCARD = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col01_nCheck = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col02_bCheck = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col03_k01cKodeValidation_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col04_k02cKodeMasterRouting_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col05_k03cKodeDesignMaster = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col06_f02cNameJCProductType_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col07_f04cNameJCProductSubtype_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col08_f05dInputDateAdmin = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col09_f06dDeliveryDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col10_f08cNameItemProduct_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col11_f20cNameMasterType_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col12_f24cNameProject_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col13_f27nEstimasiBerat_n92 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me._rscol13_f27nEstimasiBerat_n92 = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.col14_CreatDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col15_Copyprint = New DevExpress.XtraGrid.Columns.GridColumn()
        Me._rscol14_Copyprint = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me._01cCbprinterName = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me._02cBtnPrint = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me._02cCheckAll.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._gcJOBCARD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._gvJOBCARD, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._rscol13_f27nEstimasiBerat_n92, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._rscol14_Copyprint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._01cCbprinterName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me._btnPrintPreview)
        Me.LayoutControl1.Controls.Add(Me._btnPrint)
        Me.LayoutControl1.Controls.Add(Me._WUIBPanel)
        Me.LayoutControl1.Controls.Add(Me._02cCheckAll)
        Me.LayoutControl1.Controls.Add(Me._gcJOBCARD)
        Me.LayoutControl1.Controls.Add(Me._01cCbprinterName)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1281, 688)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        '_btnPrintPreview
        '
        Me._btnPrintPreview.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question
        Me._btnPrintPreview.Appearance.Font = New System.Drawing.Font("Arial", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnPrintPreview.Appearance.Options.UseBackColor = True
        Me._btnPrintPreview.Appearance.Options.UseFont = True
        Me._btnPrintPreview.Location = New System.Drawing.Point(636, 14)
        Me._btnPrintPreview.Name = "_btnPrintPreview"
        Me._btnPrintPreview.Size = New System.Drawing.Size(209, 33)
        Me._btnPrintPreview.StyleController = Me.LayoutControl1
        Me._btnPrintPreview.TabIndex = 16
        Me._btnPrintPreview.Text = "Show Preview"
        '
        '_btnPrint
        '
        Me._btnPrint.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me._btnPrint.Appearance.Font = New System.Drawing.Font("Arial", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._btnPrint.Appearance.Options.UseBackColor = True
        Me._btnPrint.Appearance.Options.UseFont = True
        Me._btnPrint.Location = New System.Drawing.Point(399, 14)
        Me._btnPrint.Name = "_btnPrint"
        Me._btnPrint.Size = New System.Drawing.Size(233, 33)
        Me._btnPrint.StyleController = Me.LayoutControl1
        Me._btnPrint.TabIndex = 15
        Me._btnPrint.Text = "Print"
        '
        '_WUIBPanel
        '
        WindowsUIButtonImageOptions1.EnableTransparency = True
        WindowsUIButtonImageOptions1.Image = CType(resources.GetObject("WindowsUIButtonImageOptions1.Image"), System.Drawing.Image)
        WindowsUIButtonImageOptions2.EnableTransparency = True
        WindowsUIButtonImageOptions2.Image = CType(resources.GetObject("WindowsUIButtonImageOptions2.Image"), System.Drawing.Image)
        Me._WUIBPanel.Buttons.AddRange(New DevExpress.XtraEditors.ButtonPanel.IBaseButton() {New DevExpress.XtraBars.Docking2010.WindowsUIButton("Print", True, WindowsUIButtonImageOptions1, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Print Document", -1, True, Nothing, True, False, True, "print", -1, False), New DevExpress.XtraBars.Docking2010.WindowsUIButton("Clear", True, WindowsUIButtonImageOptions2, DevExpress.XtraBars.Docking2010.ButtonStyle.PushButton, "Clear", -1, True, Nothing, True, False, True, "clear", -1, False)})
        Me._WUIBPanel.ForeColor = System.Drawing.Color.Black
        Me._WUIBPanel.Location = New System.Drawing.Point(861, 2)
        Me._WUIBPanel.Name = "_WUIBPanel"
        Me._WUIBPanel.Size = New System.Drawing.Size(0, 63)
        Me._WUIBPanel.TabIndex = 14
        Me._WUIBPanel.Text = "WindowsUIButtonPanel1"
        Me._WUIBPanel.Visible = False
        '
        '_02cCheckAll
        '
        Me._02cCheckAll.Location = New System.Drawing.Point(14, 46)
        Me._02cCheckAll.Name = "_02cCheckAll"
        Me._02cCheckAll.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._02cCheckAll.Properties.Appearance.Options.UseFont = True
        Me._02cCheckAll.Properties.Caption = "Select All"
        Me._02cCheckAll.Size = New System.Drawing.Size(381, 27)
        Me._02cCheckAll.StyleController = Me.LayoutControl1
        Me._02cCheckAll.TabIndex = 11
        '
        '_gcJOBCARD
        '
        Me._gcJOBCARD.Location = New System.Drawing.Point(2, 89)
        Me._gcJOBCARD.MainView = Me._gvJOBCARD
        Me._gcJOBCARD.Name = "_gcJOBCARD"
        Me._gcJOBCARD.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me._rscol14_Copyprint, Me._rscol13_f27nEstimasiBerat_n92})
        Me._gcJOBCARD.Size = New System.Drawing.Size(1277, 597)
        Me._gcJOBCARD.TabIndex = 4
        Me._gcJOBCARD.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me._gvJOBCARD})
        '
        '_gvJOBCARD
        '
        Me._gvJOBCARD.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col01_nCheck, Me.col02_bCheck, Me.col03_k01cKodeValidation_v50, Me.col04_k02cKodeMasterRouting_v50, Me.col05_k03cKodeDesignMaster, Me.col06_f02cNameJCProductType_v50, Me.col07_f04cNameJCProductSubtype_v50, Me.col08_f05dInputDateAdmin, Me.col09_f06dDeliveryDate, Me.col10_f08cNameItemProduct_v50, Me.col11_f20cNameMasterType_v50, Me.col12_f24cNameProject_v50, Me.col13_f27nEstimasiBerat_n92, Me.col14_CreatDate, Me.col15_Copyprint})
        Me._gvJOBCARD.GridControl = Me._gcJOBCARD
        Me._gvJOBCARD.Name = "_gvJOBCARD"
        Me._gvJOBCARD.OptionsView.ShowGroupPanel = False
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
        'col03_k01cKodeValidation_v50
        '
        Me.col03_k01cKodeValidation_v50.Caption = "No Validation"
        Me.col03_k01cKodeValidation_v50.MinWidth = 30
        Me.col03_k01cKodeValidation_v50.Name = "col03_k01cKodeValidation_v50"
        Me.col03_k01cKodeValidation_v50.Visible = True
        Me.col03_k01cKodeValidation_v50.VisibleIndex = 2
        Me.col03_k01cKodeValidation_v50.Width = 112
        '
        'col04_k02cKodeMasterRouting_v50
        '
        Me.col04_k02cKodeMasterRouting_v50.Caption = "Routing Code"
        Me.col04_k02cKodeMasterRouting_v50.MinWidth = 30
        Me.col04_k02cKodeMasterRouting_v50.Name = "col04_k02cKodeMasterRouting_v50"
        Me.col04_k02cKodeMasterRouting_v50.Visible = True
        Me.col04_k02cKodeMasterRouting_v50.VisibleIndex = 3
        Me.col04_k02cKodeMasterRouting_v50.Width = 112
        '
        'col05_k03cKodeDesignMaster
        '
        Me.col05_k03cKodeDesignMaster.Caption = "Design Master Code"
        Me.col05_k03cKodeDesignMaster.MinWidth = 30
        Me.col05_k03cKodeDesignMaster.Name = "col05_k03cKodeDesignMaster"
        Me.col05_k03cKodeDesignMaster.Visible = True
        Me.col05_k03cKodeDesignMaster.VisibleIndex = 4
        Me.col05_k03cKodeDesignMaster.Width = 112
        '
        'col06_f02cNameJCProductType_v50
        '
        Me.col06_f02cNameJCProductType_v50.Caption = "Pro Type"
        Me.col06_f02cNameJCProductType_v50.MinWidth = 30
        Me.col06_f02cNameJCProductType_v50.Name = "col06_f02cNameJCProductType_v50"
        Me.col06_f02cNameJCProductType_v50.Visible = True
        Me.col06_f02cNameJCProductType_v50.VisibleIndex = 5
        Me.col06_f02cNameJCProductType_v50.Width = 112
        '
        'col07_f04cNameJCProductSubtype_v50
        '
        Me.col07_f04cNameJCProductSubtype_v50.Caption = "Pro Subtype"
        Me.col07_f04cNameJCProductSubtype_v50.MinWidth = 30
        Me.col07_f04cNameJCProductSubtype_v50.Name = "col07_f04cNameJCProductSubtype_v50"
        Me.col07_f04cNameJCProductSubtype_v50.Visible = True
        Me.col07_f04cNameJCProductSubtype_v50.VisibleIndex = 6
        Me.col07_f04cNameJCProductSubtype_v50.Width = 112
        '
        'col08_f05dInputDateAdmin
        '
        Me.col08_f05dInputDateAdmin.Caption = "Input"
        Me.col08_f05dInputDateAdmin.MinWidth = 30
        Me.col08_f05dInputDateAdmin.Name = "col08_f05dInputDateAdmin"
        Me.col08_f05dInputDateAdmin.Visible = True
        Me.col08_f05dInputDateAdmin.VisibleIndex = 7
        Me.col08_f05dInputDateAdmin.Width = 112
        '
        'col09_f06dDeliveryDate
        '
        Me.col09_f06dDeliveryDate.Caption = "Delivery"
        Me.col09_f06dDeliveryDate.MinWidth = 30
        Me.col09_f06dDeliveryDate.Name = "col09_f06dDeliveryDate"
        Me.col09_f06dDeliveryDate.Visible = True
        Me.col09_f06dDeliveryDate.VisibleIndex = 8
        Me.col09_f06dDeliveryDate.Width = 112
        '
        'col10_f08cNameItemProduct_v50
        '
        Me.col10_f08cNameItemProduct_v50.Caption = "Prodcut"
        Me.col10_f08cNameItemProduct_v50.MinWidth = 30
        Me.col10_f08cNameItemProduct_v50.Name = "col10_f08cNameItemProduct_v50"
        Me.col10_f08cNameItemProduct_v50.Visible = True
        Me.col10_f08cNameItemProduct_v50.VisibleIndex = 9
        Me.col10_f08cNameItemProduct_v50.Width = 112
        '
        'col11_f20cNameMasterType_v50
        '
        Me.col11_f20cNameMasterType_v50.Caption = "Master Type"
        Me.col11_f20cNameMasterType_v50.MinWidth = 30
        Me.col11_f20cNameMasterType_v50.Name = "col11_f20cNameMasterType_v50"
        Me.col11_f20cNameMasterType_v50.Visible = True
        Me.col11_f20cNameMasterType_v50.VisibleIndex = 10
        Me.col11_f20cNameMasterType_v50.Width = 112
        '
        'col12_f24cNameProject_v50
        '
        Me.col12_f24cNameProject_v50.Caption = "Project"
        Me.col12_f24cNameProject_v50.MinWidth = 30
        Me.col12_f24cNameProject_v50.Name = "col12_f24cNameProject_v50"
        Me.col12_f24cNameProject_v50.Visible = True
        Me.col12_f24cNameProject_v50.VisibleIndex = 11
        Me.col12_f24cNameProject_v50.Width = 112
        '
        'col13_f27nEstimasiBerat_n92
        '
        Me.col13_f27nEstimasiBerat_n92.Caption = "Weight Estimation"
        Me.col13_f27nEstimasiBerat_n92.ColumnEdit = Me._rscol13_f27nEstimasiBerat_n92
        Me.col13_f27nEstimasiBerat_n92.DisplayFormat.FormatString = "n02"
        Me.col13_f27nEstimasiBerat_n92.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col13_f27nEstimasiBerat_n92.MinWidth = 30
        Me.col13_f27nEstimasiBerat_n92.Name = "col13_f27nEstimasiBerat_n92"
        Me.col13_f27nEstimasiBerat_n92.Visible = True
        Me.col13_f27nEstimasiBerat_n92.VisibleIndex = 12
        Me.col13_f27nEstimasiBerat_n92.Width = 112
        '
        '_rscol13_f27nEstimasiBerat_n92
        '
        Me._rscol13_f27nEstimasiBerat_n92.AutoHeight = False
        Me._rscol13_f27nEstimasiBerat_n92.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._rscol13_f27nEstimasiBerat_n92.Name = "_rscol13_f27nEstimasiBerat_n92"
        '
        'col14_CreatDate
        '
        Me.col14_CreatDate.Caption = "GridColumn1"
        Me.col14_CreatDate.MinWidth = 30
        Me.col14_CreatDate.Name = "col14_CreatDate"
        Me.col14_CreatDate.Visible = True
        Me.col14_CreatDate.VisibleIndex = 13
        Me.col14_CreatDate.Width = 112
        '
        'col15_Copyprint
        '
        Me.col15_Copyprint.Caption = "Print To"
        Me.col15_Copyprint.ColumnEdit = Me._rscol14_Copyprint
        Me.col15_Copyprint.MinWidth = 30
        Me.col15_Copyprint.Name = "col15_Copyprint"
        Me.col15_Copyprint.Visible = True
        Me.col15_Copyprint.VisibleIndex = 14
        Me.col15_Copyprint.Width = 112
        '
        '_rscol14_Copyprint
        '
        Me._rscol14_Copyprint.AutoHeight = False
        Me._rscol14_Copyprint.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._rscol14_Copyprint.Name = "_rscol14_Copyprint"
        '
        '_01cCbprinterName
        '
        Me._01cCbprinterName.Location = New System.Drawing.Point(113, 14)
        Me._01cCbprinterName.Name = "_01cCbprinterName"
        Me._01cCbprinterName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._01cCbprinterName.Size = New System.Drawing.Size(282, 28)
        Me._01cCbprinterName.StyleController = Me.LayoutControl1
        Me._01cCbprinterName.TabIndex = 5
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlGroup1, Me.LayoutControlItem7, Me.EmptySpaceItem1})
        Me.Root.Name = "Root"
        Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(0, 0, 0, 0)
        Me.Root.Size = New System.Drawing.Size(1281, 688)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me._gcJOBCARD
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 87)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1281, 601)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem3, Me.LayoutControlItem5})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(859, 87)
        Me.LayoutControlGroup1.Text = "Options"
        Me.LayoutControlGroup1.TextVisible = False
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me._01cCbprinterName
        Me.LayoutControlItem2.ControlAlignment = System.Drawing.ContentAlignment.TopLeft
        Me.LayoutControlItem2.CustomizationFormText = "Select Printer"
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 2, 2, 2)
        Me.LayoutControlItem2.Size = New System.Drawing.Size(385, 32)
        Me.LayoutControlItem2.Text = "Select Printer"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(93, 19)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me._02cCheckAll
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 32)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(385, 31)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me._btnPrint
        Me.LayoutControlItem3.Location = New System.Drawing.Point(385, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(237, 63)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me._btnPrintPreview
        Me.LayoutControlItem5.Location = New System.Drawing.Point(622, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(213, 63)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.Control = Me._WUIBPanel
        Me.LayoutControlItem7.Location = New System.Drawing.Point(859, 0)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Size = New System.Drawing.Size(4, 87)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        Me.LayoutControlItem7.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(863, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(418, 87)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
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
        Me._02cBtnPrint.TabIndex = 6
        Me._02cBtnPrint.Text = "Print"
        '
        'ucGridReprintJOBCARD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange
        Me.Controls.Add(Me.LayoutControl1)
        Me.LookAndFeel.SkinName = "DevExpress Style"
        Me.LookAndFeel.UseDefaultLookAndFeel = False
        Me.Name = "ucGridReprintJOBCARD"
        Me.Size = New System.Drawing.Size(1281, 688)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me._02cCheckAll.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._gcJOBCARD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._gvJOBCARD, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._rscol13_f27nEstimasiBerat_n92, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._rscol14_Copyprint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._01cCbprinterName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents _gcJOBCARD As DevExpress.XtraGrid.GridControl
    Friend WithEvents _gvJOBCARD As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents _01cCbprinterName As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents _02cBtnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents _02cCheckAll As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents col01_nCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col02_bCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col03_k01cKodeValidation_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col04_k02cKodeMasterRouting_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col05_k03cKodeDesignMaster As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col06_f02cNameJCProductType_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col07_f04cNameJCProductSubtype_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col08_f05dInputDateAdmin As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col09_f06dDeliveryDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col10_f08cNameItemProduct_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col11_f20cNameMasterType_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col12_f24cNameProject_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col13_f27nEstimasiBerat_n92 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents _rscol13_f27nEstimasiBerat_n92 As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents col15_Copyprint As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents _rscol14_Copyprint As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents _WUIBPanel As DevExpress.XtraBars.Docking2010.WindowsUIButtonPanel
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents _btnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents col14_CreatDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents _btnPrintPreview As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
End Class
