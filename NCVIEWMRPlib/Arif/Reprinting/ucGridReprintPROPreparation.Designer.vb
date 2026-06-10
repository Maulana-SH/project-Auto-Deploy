<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ucGridReprintPROPreparation
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
        Me._03cCheckAll = New DevExpress.XtraEditors.CheckEdit()
        Me._btnPrint = New DevExpress.XtraEditors.SimpleButton()
        Me._01CbprinterName = New DevExpress.XtraEditors.ComboBoxEdit()
        Me._gcProPreparation = New DevExpress.XtraGrid.GridControl()
        Me._gvPROPreparation = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col01_nCheck = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col02_bCheck = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col03_k01cNoPRO_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col04_k02cKodeMaterialOrFG_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col05_f01cNoSalesOrder_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col06_f02MaterialOrFGDesc_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col07_f03nLot_int = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col08_f04nBerat_n92 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col09_f05cEngrave_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col010_f07cOrderStatusDesc_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col011_f08dOrderDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col012_f09dDeliveryDate = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col013_f12cBrandDesc_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col014_f14cCustomerDesc_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col015_f16cProjectDesc_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col016_f17cNamaProduk_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col017_f19cItemBRJDesc_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col018_f21cWarnaFGDesc_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col019_f23cKadarDesc_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col020_f24cSize_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col021_f25cNotes_v250 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col022_Copyprint = New DevExpress.XtraGrid.Columns.GridColumn()
        Me._rscol022_Copyprint = New DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.SimpleSeparator1 = New DevExpress.XtraLayout.SimpleSeparator()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me._02TypeBRJ = New DevExpress.XtraEditors.ComboBoxEdit()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me._03cCheckAll.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._01CbprinterName.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._gcProPreparation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._gvPROPreparation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._rscol022_Copyprint, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._02TypeBRJ.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.BackColor = System.Drawing.Color.White
        Me.LayoutControl1.Controls.Add(Me._02TypeBRJ)
        Me.LayoutControl1.Controls.Add(Me._03cCheckAll)
        Me.LayoutControl1.Controls.Add(Me._btnPrint)
        Me.LayoutControl1.Controls.Add(Me._01CbprinterName)
        Me.LayoutControl1.Controls.Add(Me._gcProPreparation)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1187, 559)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        '_03cCheckAll
        '
        Me._03cCheckAll.Location = New System.Drawing.Point(7, 39)
        Me._03cCheckAll.Name = "_03cCheckAll"
        Me._03cCheckAll.Properties.Appearance.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._03cCheckAll.Properties.Appearance.Options.UseFont = True
        Me._03cCheckAll.Properties.Caption = "Select All"
        Me._03cCheckAll.Size = New System.Drawing.Size(142, 29)
        Me._03cCheckAll.StyleController = Me.LayoutControl1
        Me._03cCheckAll.TabIndex = 8
        '
        '_btnPrint
        '
        Me._btnPrint.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me._btnPrint.Appearance.Options.UseBackColor = True
        Me._btnPrint.Location = New System.Drawing.Point(525, 7)
        Me._btnPrint.Name = "_btnPrint"
        Me._btnPrint.Size = New System.Drawing.Size(129, 32)
        Me._btnPrint.StyleController = Me.LayoutControl1
        Me._btnPrint.TabIndex = 6
        Me._btnPrint.Text = "Print"
        '
        '_01CbprinterName
        '
        Me._01CbprinterName.Location = New System.Drawing.Point(130, 7)
        Me._01CbprinterName.Name = "_01CbprinterName"
        Me._01CbprinterName.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._01CbprinterName.Size = New System.Drawing.Size(391, 28)
        Me._01CbprinterName.StyleController = Me.LayoutControl1
        Me._01CbprinterName.TabIndex = 5
        '
        '_gcProPreparation
        '
        Me._gcProPreparation.Location = New System.Drawing.Point(7, 72)
        Me._gcProPreparation.MainView = Me._gvPROPreparation
        Me._gcProPreparation.Name = "_gcProPreparation"
        Me._gcProPreparation.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me._rscol022_Copyprint})
        Me._gcProPreparation.Size = New System.Drawing.Size(1173, 480)
        Me._gcProPreparation.TabIndex = 4
        Me._gcProPreparation.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me._gvPROPreparation})
        '
        '_gvPROPreparation
        '
        Me._gvPROPreparation.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col01_nCheck, Me.col02_bCheck, Me.col03_k01cNoPRO_v50, Me.col04_k02cKodeMaterialOrFG_v50, Me.col05_f01cNoSalesOrder_v50, Me.col06_f02MaterialOrFGDesc_v50, Me.col07_f03nLot_int, Me.col08_f04nBerat_n92, Me.col09_f05cEngrave_v50, Me.col010_f07cOrderStatusDesc_v50, Me.col011_f08dOrderDate, Me.col012_f09dDeliveryDate, Me.col013_f12cBrandDesc_v50, Me.col014_f14cCustomerDesc_v50, Me.col015_f16cProjectDesc_v50, Me.col016_f17cNamaProduk_v50, Me.col017_f19cItemBRJDesc_v50, Me.col018_f21cWarnaFGDesc_v50, Me.col019_f23cKadarDesc_v50, Me.col020_f24cSize_v50, Me.col021_f25cNotes_v250, Me.col022_Copyprint})
        Me._gvPROPreparation.GridControl = Me._gcProPreparation
        Me._gvPROPreparation.Name = "_gvPROPreparation"
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
        'col03_k01cNoPRO_v50
        '
        Me.col03_k01cNoPRO_v50.Caption = "NO PRO"
        Me.col03_k01cNoPRO_v50.MinWidth = 30
        Me.col03_k01cNoPRO_v50.Name = "col03_k01cNoPRO_v50"
        Me.col03_k01cNoPRO_v50.Visible = True
        Me.col03_k01cNoPRO_v50.VisibleIndex = 2
        Me.col03_k01cNoPRO_v50.Width = 112
        '
        'col04_k02cKodeMaterialOrFG_v50
        '
        Me.col04_k02cKodeMaterialOrFG_v50.Caption = "FG CODE"
        Me.col04_k02cKodeMaterialOrFG_v50.MinWidth = 30
        Me.col04_k02cKodeMaterialOrFG_v50.Name = "col04_k02cKodeMaterialOrFG_v50"
        Me.col04_k02cKodeMaterialOrFG_v50.Visible = True
        Me.col04_k02cKodeMaterialOrFG_v50.VisibleIndex = 3
        Me.col04_k02cKodeMaterialOrFG_v50.Width = 112
        '
        'col05_f01cNoSalesOrder_v50
        '
        Me.col05_f01cNoSalesOrder_v50.Caption = "No Sales Order"
        Me.col05_f01cNoSalesOrder_v50.MinWidth = 30
        Me.col05_f01cNoSalesOrder_v50.Name = "col05_f01cNoSalesOrder_v50"
        Me.col05_f01cNoSalesOrder_v50.Visible = True
        Me.col05_f01cNoSalesOrder_v50.VisibleIndex = 4
        Me.col05_f01cNoSalesOrder_v50.Width = 112
        '
        'col06_f02MaterialOrFGDesc_v50
        '
        Me.col06_f02MaterialOrFGDesc_v50.Caption = "Material"
        Me.col06_f02MaterialOrFGDesc_v50.MinWidth = 30
        Me.col06_f02MaterialOrFGDesc_v50.Name = "col06_f02MaterialOrFGDesc_v50"
        Me.col06_f02MaterialOrFGDesc_v50.Visible = True
        Me.col06_f02MaterialOrFGDesc_v50.VisibleIndex = 5
        Me.col06_f02MaterialOrFGDesc_v50.Width = 112
        '
        'col07_f03nLot_int
        '
        Me.col07_f03nLot_int.Caption = "Pcs"
        Me.col07_f03nLot_int.MinWidth = 30
        Me.col07_f03nLot_int.Name = "col07_f03nLot_int"
        Me.col07_f03nLot_int.Visible = True
        Me.col07_f03nLot_int.VisibleIndex = 6
        Me.col07_f03nLot_int.Width = 112
        '
        'col08_f04nBerat_n92
        '
        Me.col08_f04nBerat_n92.Caption = "Weight"
        Me.col08_f04nBerat_n92.MinWidth = 30
        Me.col08_f04nBerat_n92.Name = "col08_f04nBerat_n92"
        Me.col08_f04nBerat_n92.Visible = True
        Me.col08_f04nBerat_n92.VisibleIndex = 7
        Me.col08_f04nBerat_n92.Width = 112
        '
        'col09_f05cEngrave_v50
        '
        Me.col09_f05cEngrave_v50.Caption = "Engrave"
        Me.col09_f05cEngrave_v50.MinWidth = 30
        Me.col09_f05cEngrave_v50.Name = "col09_f05cEngrave_v50"
        Me.col09_f05cEngrave_v50.Visible = True
        Me.col09_f05cEngrave_v50.VisibleIndex = 8
        Me.col09_f05cEngrave_v50.Width = 112
        '
        'col010_f07cOrderStatusDesc_v50
        '
        Me.col010_f07cOrderStatusDesc_v50.Caption = "Order Status"
        Me.col010_f07cOrderStatusDesc_v50.MinWidth = 30
        Me.col010_f07cOrderStatusDesc_v50.Name = "col010_f07cOrderStatusDesc_v50"
        Me.col010_f07cOrderStatusDesc_v50.Visible = True
        Me.col010_f07cOrderStatusDesc_v50.VisibleIndex = 9
        Me.col010_f07cOrderStatusDesc_v50.Width = 112
        '
        'col011_f08dOrderDate
        '
        Me.col011_f08dOrderDate.Caption = "Order Date"
        Me.col011_f08dOrderDate.MinWidth = 30
        Me.col011_f08dOrderDate.Name = "col011_f08dOrderDate"
        Me.col011_f08dOrderDate.Visible = True
        Me.col011_f08dOrderDate.VisibleIndex = 10
        Me.col011_f08dOrderDate.Width = 112
        '
        'col012_f09dDeliveryDate
        '
        Me.col012_f09dDeliveryDate.Caption = "Delivery Date"
        Me.col012_f09dDeliveryDate.MinWidth = 30
        Me.col012_f09dDeliveryDate.Name = "col012_f09dDeliveryDate"
        Me.col012_f09dDeliveryDate.Visible = True
        Me.col012_f09dDeliveryDate.VisibleIndex = 11
        Me.col012_f09dDeliveryDate.Width = 112
        '
        'col013_f12cBrandDesc_v50
        '
        Me.col013_f12cBrandDesc_v50.Caption = "Brand"
        Me.col013_f12cBrandDesc_v50.MinWidth = 30
        Me.col013_f12cBrandDesc_v50.Name = "col013_f12cBrandDesc_v50"
        Me.col013_f12cBrandDesc_v50.Visible = True
        Me.col013_f12cBrandDesc_v50.VisibleIndex = 12
        Me.col013_f12cBrandDesc_v50.Width = 112
        '
        'col014_f14cCustomerDesc_v50
        '
        Me.col014_f14cCustomerDesc_v50.Caption = "Costumer"
        Me.col014_f14cCustomerDesc_v50.MinWidth = 30
        Me.col014_f14cCustomerDesc_v50.Name = "col014_f14cCustomerDesc_v50"
        Me.col014_f14cCustomerDesc_v50.Visible = True
        Me.col014_f14cCustomerDesc_v50.VisibleIndex = 13
        Me.col014_f14cCustomerDesc_v50.Width = 112
        '
        'col015_f16cProjectDesc_v50
        '
        Me.col015_f16cProjectDesc_v50.Caption = "Project"
        Me.col015_f16cProjectDesc_v50.MinWidth = 30
        Me.col015_f16cProjectDesc_v50.Name = "col015_f16cProjectDesc_v50"
        Me.col015_f16cProjectDesc_v50.Visible = True
        Me.col015_f16cProjectDesc_v50.VisibleIndex = 14
        Me.col015_f16cProjectDesc_v50.Width = 112
        '
        'col016_f17cNamaProduk_v50
        '
        Me.col016_f17cNamaProduk_v50.Caption = "Product"
        Me.col016_f17cNamaProduk_v50.MinWidth = 30
        Me.col016_f17cNamaProduk_v50.Name = "col016_f17cNamaProduk_v50"
        Me.col016_f17cNamaProduk_v50.Visible = True
        Me.col016_f17cNamaProduk_v50.VisibleIndex = 15
        Me.col016_f17cNamaProduk_v50.Width = 112
        '
        'col017_f19cItemBRJDesc_v50
        '
        Me.col017_f19cItemBRJDesc_v50.Caption = "Item BRJ"
        Me.col017_f19cItemBRJDesc_v50.MinWidth = 30
        Me.col017_f19cItemBRJDesc_v50.Name = "col017_f19cItemBRJDesc_v50"
        Me.col017_f19cItemBRJDesc_v50.Visible = True
        Me.col017_f19cItemBRJDesc_v50.VisibleIndex = 16
        Me.col017_f19cItemBRJDesc_v50.Width = 112
        '
        'col018_f21cWarnaFGDesc_v50
        '
        Me.col018_f21cWarnaFGDesc_v50.Caption = "Color"
        Me.col018_f21cWarnaFGDesc_v50.MinWidth = 30
        Me.col018_f21cWarnaFGDesc_v50.Name = "col018_f21cWarnaFGDesc_v50"
        Me.col018_f21cWarnaFGDesc_v50.Visible = True
        Me.col018_f21cWarnaFGDesc_v50.VisibleIndex = 17
        Me.col018_f21cWarnaFGDesc_v50.Width = 112
        '
        'col019_f23cKadarDesc_v50
        '
        Me.col019_f23cKadarDesc_v50.Caption = "kadar"
        Me.col019_f23cKadarDesc_v50.MinWidth = 30
        Me.col019_f23cKadarDesc_v50.Name = "col019_f23cKadarDesc_v50"
        Me.col019_f23cKadarDesc_v50.Visible = True
        Me.col019_f23cKadarDesc_v50.VisibleIndex = 18
        Me.col019_f23cKadarDesc_v50.Width = 112
        '
        'col020_f24cSize_v50
        '
        Me.col020_f24cSize_v50.Caption = "Size"
        Me.col020_f24cSize_v50.MinWidth = 30
        Me.col020_f24cSize_v50.Name = "col020_f24cSize_v50"
        Me.col020_f24cSize_v50.Visible = True
        Me.col020_f24cSize_v50.VisibleIndex = 19
        Me.col020_f24cSize_v50.Width = 112
        '
        'col021_f25cNotes_v250
        '
        Me.col021_f25cNotes_v250.Caption = "Note"
        Me.col021_f25cNotes_v250.MinWidth = 30
        Me.col021_f25cNotes_v250.Name = "col021_f25cNotes_v250"
        Me.col021_f25cNotes_v250.Visible = True
        Me.col021_f25cNotes_v250.VisibleIndex = 20
        Me.col021_f25cNotes_v250.Width = 112
        '
        'col022_Copyprint
        '
        Me.col022_Copyprint.Caption = "Print To"
        Me.col022_Copyprint.ColumnEdit = Me._rscol022_Copyprint
        Me.col022_Copyprint.MinWidth = 30
        Me.col022_Copyprint.Name = "col022_Copyprint"
        Me.col022_Copyprint.Visible = True
        Me.col022_Copyprint.VisibleIndex = 21
        Me.col022_Copyprint.Width = 112
        '
        '_rscol022_Copyprint
        '
        Me._rscol022_Copyprint.AutoHeight = False
        Me._rscol022_Copyprint.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._rscol022_Copyprint.Name = "_rscol022_Copyprint"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlItem3, Me.SimpleSeparator1, Me.LayoutControlItem2, Me.LayoutControlItem5, Me.LayoutControlItem4})
        Me.Root.Name = "Root"
        Me.Root.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me.Root.Size = New System.Drawing.Size(1187, 559)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me._gcProPreparation
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 65)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1177, 484)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me._btnPrint
        Me.LayoutControlItem3.Location = New System.Drawing.Point(518, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(133, 65)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'SimpleSeparator1
        '
        Me.SimpleSeparator1.AllowHotTrack = False
        Me.SimpleSeparator1.AppearanceItemCaption.BackColor = System.Drawing.Color.White
        Me.SimpleSeparator1.AppearanceItemCaption.Options.UseBackColor = True
        Me.SimpleSeparator1.Location = New System.Drawing.Point(651, 0)
        Me.SimpleSeparator1.Name = "SimpleSeparator1"
        Me.SimpleSeparator1.Size = New System.Drawing.Size(526, 65)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.AppearanceItemCaption.Font = New System.Drawing.Font("Arial", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem2.Control = Me._01CbprinterName
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(518, 32)
        Me.LayoutControlItem2.Text = "Select Printer"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(120, 21)
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me._03cCheckAll
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 32)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(146, 33)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        '_02TypeBRJ
        '
        Me._02TypeBRJ.EditValue = "1. BRJ Emas"
        Me._02TypeBRJ.Location = New System.Drawing.Point(276, 39)
        Me._02TypeBRJ.Name = "_02TypeBRJ"
        Me._02TypeBRJ.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._02TypeBRJ.Properties.Items.AddRange(New Object() {"1. BRJ Emas", "2. BRJ Perak", "3. Finding Component", "4. Semi Finished Goods"})
        Me._02TypeBRJ.Size = New System.Drawing.Size(245, 28)
        Me._02TypeBRJ.StyleController = Me.LayoutControl1
        Me._02TypeBRJ.TabIndex = 9
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me._02TypeBRJ
        Me.LayoutControlItem4.Location = New System.Drawing.Point(146, 32)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(372, 33)
        Me.LayoutControlItem4.Text = "Type BRJ"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(120, 19)
        '
        'ucGridReprintPROPreparation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "ucGridReprintPROPreparation"
        Me.Size = New System.Drawing.Size(1187, 559)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me._03cCheckAll.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._01CbprinterName.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._gcProPreparation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._gvPROPreparation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._rscol022_Copyprint, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SimpleSeparator1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._02TypeBRJ.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents _btnPrint As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents _01CbprinterName As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents _gcProPreparation As DevExpress.XtraGrid.GridControl
    Friend WithEvents _gvPROPreparation As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleSeparator1 As DevExpress.XtraLayout.SimpleSeparator
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents col01_nCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col02_bCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col03_k01cNoPRO_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col04_k02cKodeMaterialOrFG_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col05_f01cNoSalesOrder_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col06_f02MaterialOrFGDesc_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col07_f03nLot_int As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col08_f04nBerat_n92 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col09_f05cEngrave_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col010_f07cOrderStatusDesc_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col011_f08dOrderDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col012_f09dDeliveryDate As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col013_f12cBrandDesc_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col014_f14cCustomerDesc_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col015_f16cProjectDesc_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col016_f17cNamaProduk_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col017_f19cItemBRJDesc_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col018_f21cWarnaFGDesc_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col019_f23cKadarDesc_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col020_f24cSize_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col021_f25cNotes_v250 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col022_Copyprint As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents _rscol022_Copyprint As DevExpress.XtraEditors.Repository.RepositoryItemSpinEdit
    Friend WithEvents _03cCheckAll As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents _02TypeBRJ As DevExpress.XtraEditors.ComboBoxEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
End Class
