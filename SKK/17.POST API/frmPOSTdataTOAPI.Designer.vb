<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmPOSTdataTOAPI
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.ocKirimSKUPerpcs = New DevExpress.XtraEditors.CheckEdit()
        Me.ocKirimParent = New DevExpress.XtraEditors.CheckEdit()
        Me.ocSelectAll = New DevExpress.XtraEditors.CheckEdit()
        Me.ocFilter = New DevExpress.XtraEditors.CheckEdit()
        Me._02tglAkhir = New DevExpress.XtraEditors.DateEdit()
        Me._01TglAwal = New DevExpress.XtraEditors.DateEdit()
        Me.gcBridging = New DevExpress.XtraGrid.GridControl()
        Me.gvBridging = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.colB00_bCheck = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rscol00_bCheck = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.colB01_k02SPK = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colB03_k04DesignCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colB04_NamaNORO = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colB05_NamaWarnaEmas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colB06_NamaKadar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colB07_NamaTipeBRJ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colB08_NamaSize = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colB09_NamaBrand = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colB10_NamaMaterial = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colB11_NamaGender = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colB12_NamaEngrave = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colB13_OrderStatus = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colB14_NoDocument = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colB15_PCSSKU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colB16_ButirSTone = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colB17_BeratGrosss = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colB18_BeratNett = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colB19_TglInbound = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colB02_k03ProductCode = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colB20_f01NamaUser = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.colB21_nTtlGrossPCS = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.CheckEdit1 = New DevExpress.XtraEditors.CheckEdit()
        Me._clblData = New DevExpress.XtraEditors.LabelControl()
        Me._03Response = New DevExpress.XtraEditors.MemoEdit()
        Me.btnsend = New DevExpress.XtraEditors.SimpleButton()
        Me._02JsonString = New DevExpress.XtraEditors.MemoEdit()
        Me.btnGetdata = New DevExpress.XtraEditors.SimpleButton()
        Me._01NoDO = New DevExpress.XtraEditors.TextEdit()
        Me._gridResult = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col01_f03cSKU = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col02_f02cKodeKaret = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col03_f12nQtyLot = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col04_f13nBeratGross = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col05_f15nTGramZircon = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col06_f14nBeratNett = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col07_f18cCustomers = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col08_f11cNamaTipeBRJ = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col09_f08cNamaMaterial_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col10_f09cNamaKadarEmas = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col11_f20cNamaPlating_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col12_f17nSize = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnGEtDataInbound = New DevExpress.XtraEditors.SimpleButton()
        Me.btnRetransferBridging = New DevExpress.XtraEditors.SimpleButton()
        Me.btnExport = New DevExpress.XtraEditors.SimpleButton()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.TabbedControlGroup1 = New DevExpress.XtraLayout.TabbedControlGroup()
        Me.LayoutControlGroup3 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyt_01TglAwal = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyt_02tglAkhir = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem11 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem13 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem9 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.EmptySpaceItem5 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup4 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem10 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem14 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem12 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem15 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem3 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem7 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lytResponseJIms = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem8 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.ocKirimSKUPerpcs.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ocKirimParent.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ocSelectAll.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ocFilter.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._02tglAkhir.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._02tglAkhir.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._01TglAwal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._01TglAwal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcBridging, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gvBridging, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rscol00_bCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._03Response.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._02JsonString.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._01NoDO.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._gridResult, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyt_01TglAwal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyt_02tglAkhir, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lytResponseJIms, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.ocKirimSKUPerpcs)
        Me.LayoutControl1.Controls.Add(Me.ocKirimParent)
        Me.LayoutControl1.Controls.Add(Me.ocSelectAll)
        Me.LayoutControl1.Controls.Add(Me.ocFilter)
        Me.LayoutControl1.Controls.Add(Me._02tglAkhir)
        Me.LayoutControl1.Controls.Add(Me._01TglAwal)
        Me.LayoutControl1.Controls.Add(Me.gcBridging)
        Me.LayoutControl1.Controls.Add(Me.CheckEdit1)
        Me.LayoutControl1.Controls.Add(Me._clblData)
        Me.LayoutControl1.Controls.Add(Me._03Response)
        Me.LayoutControl1.Controls.Add(Me.btnsend)
        Me.LayoutControl1.Controls.Add(Me._02JsonString)
        Me.LayoutControl1.Controls.Add(Me.btnGetdata)
        Me.LayoutControl1.Controls.Add(Me._01NoDO)
        Me.LayoutControl1.Controls.Add(Me._gridResult)
        Me.LayoutControl1.Controls.Add(Me.btnGEtDataInbound)
        Me.LayoutControl1.Controls.Add(Me.btnRetransferBridging)
        Me.LayoutControl1.Controls.Add(Me.btnExport)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1410, 951)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'ocKirimSKUPerpcs
        '
        Me.ocKirimSKUPerpcs.EditValue = True
        Me.ocKirimSKUPerpcs.Location = New System.Drawing.Point(1058, 101)
        Me.ocKirimSKUPerpcs.Name = "ocKirimSKUPerpcs"
        Me.ocKirimSKUPerpcs.Properties.Caption = "SKU Per PCS"
        Me.ocKirimSKUPerpcs.Size = New System.Drawing.Size(146, 27)
        Me.ocKirimSKUPerpcs.StyleController = Me.LayoutControl1
        Me.ocKirimSKUPerpcs.TabIndex = 20
        '
        'ocKirimParent
        '
        Me.ocKirimParent.EditValue = True
        Me.ocKirimParent.Location = New System.Drawing.Point(914, 101)
        Me.ocKirimParent.Name = "ocKirimParent"
        Me.ocKirimParent.Properties.Caption = "HEADER"
        Me.ocKirimParent.Size = New System.Drawing.Size(140, 27)
        Me.ocKirimParent.StyleController = Me.LayoutControl1
        Me.ocKirimParent.TabIndex = 19
        '
        'ocSelectAll
        '
        Me.ocSelectAll.Location = New System.Drawing.Point(24, 113)
        Me.ocSelectAll.Name = "ocSelectAll"
        Me.ocSelectAll.Properties.Caption = "Select All"
        Me.ocSelectAll.Size = New System.Drawing.Size(96, 27)
        Me.ocSelectAll.StyleController = Me.LayoutControl1
        Me.ocSelectAll.TabIndex = 18
        '
        'ocFilter
        '
        Me.ocFilter.Location = New System.Drawing.Point(24, 57)
        Me.ocFilter.Name = "ocFilter"
        Me.ocFilter.Properties.Caption = "Filter"
        Me.ocFilter.Size = New System.Drawing.Size(66, 27)
        Me.ocFilter.StyleController = Me.LayoutControl1
        Me.ocFilter.TabIndex = 17
        '
        '_02tglAkhir
        '
        Me._02tglAkhir.EditValue = Nothing
        Me._02tglAkhir.Location = New System.Drawing.Point(359, 57)
        Me._02tglAkhir.Name = "_02tglAkhir"
        Me._02tglAkhir.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._02tglAkhir.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._02tglAkhir.Size = New System.Drawing.Size(209, 26)
        Me._02tglAkhir.StyleController = Me.LayoutControl1
        Me._02tglAkhir.TabIndex = 14
        '
        '_01TglAwal
        '
        Me._01TglAwal.EditValue = Nothing
        Me._01TglAwal.Location = New System.Drawing.Point(136, 57)
        Me._01TglAwal.Name = "_01TglAwal"
        Me._01TglAwal.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._01TglAwal.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._01TglAwal.Size = New System.Drawing.Size(195, 26)
        Me._01TglAwal.StyleController = Me.LayoutControl1
        Me._01TglAwal.TabIndex = 13
        '
        'gcBridging
        '
        Me.gcBridging.Location = New System.Drawing.Point(24, 149)
        Me.gcBridging.MainView = Me.gvBridging
        Me.gcBridging.Name = "gcBridging"
        Me.gcBridging.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rscol00_bCheck})
        Me.gcBridging.Size = New System.Drawing.Size(1352, 778)
        Me.gcBridging.TabIndex = 12
        Me.gcBridging.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gvBridging})
        '
        'gvBridging
        '
        Me.gvBridging.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colB00_bCheck, Me.colB01_k02SPK, Me.colB03_k04DesignCode, Me.colB04_NamaNORO, Me.colB05_NamaWarnaEmas, Me.colB06_NamaKadar, Me.colB07_NamaTipeBRJ, Me.colB08_NamaSize, Me.colB09_NamaBrand, Me.colB10_NamaMaterial, Me.colB11_NamaGender, Me.colB12_NamaEngrave, Me.colB13_OrderStatus, Me.colB14_NoDocument, Me.colB15_PCSSKU, Me.colB16_ButirSTone, Me.colB17_BeratGrosss, Me.colB18_BeratNett, Me.colB19_TglInbound, Me.colB02_k03ProductCode, Me.colB20_f01NamaUser, Me.colB21_nTtlGrossPCS})
        Me.gvBridging.GridControl = Me.gcBridging
        Me.gvBridging.Name = "gvBridging"
        Me.gvBridging.OptionsView.ShowFooter = True
        '
        'colB00_bCheck
        '
        Me.colB00_bCheck.Caption = "#"
        Me.colB00_bCheck.ColumnEdit = Me.rscol00_bCheck
        Me.colB00_bCheck.MinWidth = 30
        Me.colB00_bCheck.Name = "colB00_bCheck"
        Me.colB00_bCheck.Visible = True
        Me.colB00_bCheck.VisibleIndex = 0
        Me.colB00_bCheck.Width = 48
        '
        'rscol00_bCheck
        '
        Me.rscol00_bCheck.AutoHeight = False
        Me.rscol00_bCheck.Name = "rscol00_bCheck"
        Me.rscol00_bCheck.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'colB01_k02SPK
        '
        Me.colB01_k02SPK.Caption = "SPK"
        Me.colB01_k02SPK.MinWidth = 30
        Me.colB01_k02SPK.Name = "colB01_k02SPK"
        Me.colB01_k02SPK.Visible = True
        Me.colB01_k02SPK.VisibleIndex = 1
        Me.colB01_k02SPK.Width = 70
        '
        'colB03_k04DesignCode
        '
        Me.colB03_k04DesignCode.Caption = "Deign Code"
        Me.colB03_k04DesignCode.MinWidth = 30
        Me.colB03_k04DesignCode.Name = "colB03_k04DesignCode"
        Me.colB03_k04DesignCode.Visible = True
        Me.colB03_k04DesignCode.VisibleIndex = 3
        Me.colB03_k04DesignCode.Width = 70
        '
        'colB04_NamaNORO
        '
        Me.colB04_NamaNORO.Caption = "NO/RO"
        Me.colB04_NamaNORO.MinWidth = 30
        Me.colB04_NamaNORO.Name = "colB04_NamaNORO"
        Me.colB04_NamaNORO.Visible = True
        Me.colB04_NamaNORO.VisibleIndex = 4
        Me.colB04_NamaNORO.Width = 70
        '
        'colB05_NamaWarnaEmas
        '
        Me.colB05_NamaWarnaEmas.Caption = "Warna"
        Me.colB05_NamaWarnaEmas.MinWidth = 30
        Me.colB05_NamaWarnaEmas.Name = "colB05_NamaWarnaEmas"
        Me.colB05_NamaWarnaEmas.Visible = True
        Me.colB05_NamaWarnaEmas.VisibleIndex = 5
        Me.colB05_NamaWarnaEmas.Width = 70
        '
        'colB06_NamaKadar
        '
        Me.colB06_NamaKadar.Caption = "Kadar"
        Me.colB06_NamaKadar.MinWidth = 30
        Me.colB06_NamaKadar.Name = "colB06_NamaKadar"
        Me.colB06_NamaKadar.Visible = True
        Me.colB06_NamaKadar.VisibleIndex = 6
        Me.colB06_NamaKadar.Width = 70
        '
        'colB07_NamaTipeBRJ
        '
        Me.colB07_NamaTipeBRJ.Caption = "Item"
        Me.colB07_NamaTipeBRJ.MinWidth = 30
        Me.colB07_NamaTipeBRJ.Name = "colB07_NamaTipeBRJ"
        Me.colB07_NamaTipeBRJ.Visible = True
        Me.colB07_NamaTipeBRJ.VisibleIndex = 7
        Me.colB07_NamaTipeBRJ.Width = 70
        '
        'colB08_NamaSize
        '
        Me.colB08_NamaSize.Caption = "Size"
        Me.colB08_NamaSize.MinWidth = 30
        Me.colB08_NamaSize.Name = "colB08_NamaSize"
        Me.colB08_NamaSize.Visible = True
        Me.colB08_NamaSize.VisibleIndex = 8
        Me.colB08_NamaSize.Width = 71
        '
        'colB09_NamaBrand
        '
        Me.colB09_NamaBrand.Caption = "Brand"
        Me.colB09_NamaBrand.MinWidth = 30
        Me.colB09_NamaBrand.Name = "colB09_NamaBrand"
        Me.colB09_NamaBrand.Visible = True
        Me.colB09_NamaBrand.VisibleIndex = 9
        Me.colB09_NamaBrand.Width = 69
        '
        'colB10_NamaMaterial
        '
        Me.colB10_NamaMaterial.Caption = "Material"
        Me.colB10_NamaMaterial.MinWidth = 30
        Me.colB10_NamaMaterial.Name = "colB10_NamaMaterial"
        Me.colB10_NamaMaterial.Visible = True
        Me.colB10_NamaMaterial.VisibleIndex = 10
        Me.colB10_NamaMaterial.Width = 69
        '
        'colB11_NamaGender
        '
        Me.colB11_NamaGender.Caption = "Gender"
        Me.colB11_NamaGender.MinWidth = 30
        Me.colB11_NamaGender.Name = "colB11_NamaGender"
        Me.colB11_NamaGender.Visible = True
        Me.colB11_NamaGender.VisibleIndex = 11
        Me.colB11_NamaGender.Width = 69
        '
        'colB12_NamaEngrave
        '
        Me.colB12_NamaEngrave.Caption = "Engrave"
        Me.colB12_NamaEngrave.MinWidth = 30
        Me.colB12_NamaEngrave.Name = "colB12_NamaEngrave"
        Me.colB12_NamaEngrave.Visible = True
        Me.colB12_NamaEngrave.VisibleIndex = 12
        Me.colB12_NamaEngrave.Width = 69
        '
        'colB13_OrderStatus
        '
        Me.colB13_OrderStatus.Caption = "Order Status"
        Me.colB13_OrderStatus.MinWidth = 30
        Me.colB13_OrderStatus.Name = "colB13_OrderStatus"
        Me.colB13_OrderStatus.Visible = True
        Me.colB13_OrderStatus.VisibleIndex = 13
        Me.colB13_OrderStatus.Width = 69
        '
        'colB14_NoDocument
        '
        Me.colB14_NoDocument.Caption = "No Doc"
        Me.colB14_NoDocument.MinWidth = 30
        Me.colB14_NoDocument.Name = "colB14_NoDocument"
        Me.colB14_NoDocument.Visible = True
        Me.colB14_NoDocument.VisibleIndex = 14
        Me.colB14_NoDocument.Width = 69
        '
        'colB15_PCSSKU
        '
        Me.colB15_PCSSKU.Caption = "Lot"
        Me.colB15_PCSSKU.MinWidth = 30
        Me.colB15_PCSSKU.Name = "colB15_PCSSKU"
        Me.colB15_PCSSKU.Visible = True
        Me.colB15_PCSSKU.VisibleIndex = 15
        Me.colB15_PCSSKU.Width = 69
        '
        'colB16_ButirSTone
        '
        Me.colB16_ButirSTone.Caption = "Butir"
        Me.colB16_ButirSTone.MinWidth = 30
        Me.colB16_ButirSTone.Name = "colB16_ButirSTone"
        Me.colB16_ButirSTone.Visible = True
        Me.colB16_ButirSTone.VisibleIndex = 16
        Me.colB16_ButirSTone.Width = 69
        '
        'colB17_BeratGrosss
        '
        Me.colB17_BeratGrosss.Caption = "Gross"
        Me.colB17_BeratGrosss.MinWidth = 30
        Me.colB17_BeratGrosss.Name = "colB17_BeratGrosss"
        Me.colB17_BeratGrosss.Visible = True
        Me.colB17_BeratGrosss.VisibleIndex = 17
        Me.colB17_BeratGrosss.Width = 69
        '
        'colB18_BeratNett
        '
        Me.colB18_BeratNett.Caption = "Nett"
        Me.colB18_BeratNett.MinWidth = 30
        Me.colB18_BeratNett.Name = "colB18_BeratNett"
        Me.colB18_BeratNett.Visible = True
        Me.colB18_BeratNett.VisibleIndex = 18
        Me.colB18_BeratNett.Width = 69
        '
        'colB19_TglInbound
        '
        Me.colB19_TglInbound.Caption = "Tgl Inbound"
        Me.colB19_TglInbound.MinWidth = 30
        Me.colB19_TglInbound.Name = "colB19_TglInbound"
        Me.colB19_TglInbound.Visible = True
        Me.colB19_TglInbound.VisibleIndex = 20
        Me.colB19_TglInbound.Width = 97
        '
        'colB02_k03ProductCode
        '
        Me.colB02_k03ProductCode.Caption = "Product"
        Me.colB02_k03ProductCode.MinWidth = 30
        Me.colB02_k03ProductCode.Name = "colB02_k03ProductCode"
        Me.colB02_k03ProductCode.Visible = True
        Me.colB02_k03ProductCode.VisibleIndex = 2
        Me.colB02_k03ProductCode.Width = 112
        '
        'colB20_f01NamaUser
        '
        Me.colB20_f01NamaUser.Caption = "Nama User"
        Me.colB20_f01NamaUser.MinWidth = 30
        Me.colB20_f01NamaUser.Name = "colB20_f01NamaUser"
        Me.colB20_f01NamaUser.Visible = True
        Me.colB20_f01NamaUser.VisibleIndex = 21
        Me.colB20_f01NamaUser.Width = 112
        '
        'colB21_nTtlGrossPCS
        '
        Me.colB21_nTtlGrossPCS.Caption = "Total Gross ByPCS"
        Me.colB21_nTtlGrossPCS.MinWidth = 30
        Me.colB21_nTtlGrossPCS.Name = "colB21_nTtlGrossPCS"
        Me.colB21_nTtlGrossPCS.Visible = True
        Me.colB21_nTtlGrossPCS.VisibleIndex = 19
        Me.colB21_nTtlGrossPCS.Width = 112
        '
        'CheckEdit1
        '
        Me.CheckEdit1.Location = New System.Drawing.Point(24, 770)
        Me.CheckEdit1.Name = "CheckEdit1"
        Me.CheckEdit1.Properties.Appearance.Font = New System.Drawing.Font("Calibri", 11.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.CheckEdit1.Properties.Appearance.Options.UseFont = True
        Me.CheckEdit1.Properties.Caption = "Show Responses JIMS"
        Me.CheckEdit1.Size = New System.Drawing.Size(1362, 31)
        Me.CheckEdit1.StyleController = Me.LayoutControl1
        Me.CheckEdit1.TabIndex = 11
        '
        '_clblData
        '
        Me._clblData.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._clblData.Appearance.Options.UseFont = True
        Me._clblData.Location = New System.Drawing.Point(26, 109)
        Me._clblData.Name = "_clblData"
        Me._clblData.Size = New System.Drawing.Size(1358, 22)
        Me._clblData.StyleController = Me.LayoutControl1
        Me._clblData.TabIndex = 10
        Me._clblData.Text = "-"
        '
        '_03Response
        '
        Me._03Response.Location = New System.Drawing.Point(26, 832)
        Me._03Response.Name = "_03Response"
        Me._03Response.Size = New System.Drawing.Size(1358, 93)
        Me._03Response.StyleController = Me.LayoutControl1
        Me._03Response.TabIndex = 9
        '
        'btnsend
        '
        Me.btnsend.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Primary
        Me.btnsend.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsend.Appearance.Options.UseBackColor = True
        Me.btnsend.Appearance.Options.UseFont = True
        Me.btnsend.Enabled = False
        Me.btnsend.Location = New System.Drawing.Point(895, 57)
        Me.btnsend.Name = "btnsend"
        Me.btnsend.Padding = New System.Windows.Forms.Padding(4)
        Me.btnsend.Size = New System.Drawing.Size(169, 40)
        Me.btnsend.StyleController = Me.LayoutControl1
        Me.btnsend.TabIndex = 8
        Me.btnsend.Text = "Re-Transfer To JIMS"
        '
        '_02JsonString
        '
        Me._02JsonString.Location = New System.Drawing.Point(1119, 203)
        Me._02JsonString.Name = "_02JsonString"
        Me._02JsonString.Size = New System.Drawing.Size(255, 551)
        Me._02JsonString.StyleController = Me.LayoutControl1
        Me._02JsonString.TabIndex = 7
        '
        'btnGetdata
        '
        Me.btnGetdata.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.btnGetdata.Appearance.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnGetdata.Appearance.Options.UseBackColor = True
        Me.btnGetdata.Appearance.Options.UseFont = True
        Me.btnGetdata.Location = New System.Drawing.Point(708, 57)
        Me.btnGetdata.Name = "btnGetdata"
        Me.btnGetdata.Padding = New System.Windows.Forms.Padding(4)
        Me.btnGetdata.Size = New System.Drawing.Size(183, 40)
        Me.btnGetdata.StyleController = Me.LayoutControl1
        Me.btnGetdata.TabIndex = 6
        Me.btnGetdata.Text = "Get Data Citrix"
        '
        '_01NoDO
        '
        Me._01NoDO.Location = New System.Drawing.Point(183, 65)
        Me._01NoDO.Name = "_01NoDO"
        Me._01NoDO.Properties.Appearance.Font = New System.Drawing.Font("Tahoma", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._01NoDO.Properties.Appearance.Options.UseFont = True
        Me._01NoDO.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me._01NoDO.Size = New System.Drawing.Size(513, 30)
        Me._01NoDO.StyleController = Me.LayoutControl1
        Me._01NoDO.TabIndex = 5
        '
        '_gridResult
        '
        Me._gridResult.Location = New System.Drawing.Point(24, 137)
        Me._gridResult.MainView = Me.GridView1
        Me._gridResult.Name = "_gridResult"
        Me._gridResult.Size = New System.Drawing.Size(1079, 629)
        Me._gridResult.TabIndex = 4
        Me._gridResult.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FooterPanel.Font = New System.Drawing.Font("Calibri", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GridView1.Appearance.FooterPanel.Options.UseFont = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col01_f03cSKU, Me.col02_f02cKodeKaret, Me.col03_f12nQtyLot, Me.col04_f13nBeratGross, Me.col05_f15nTGramZircon, Me.col06_f14nBeratNett, Me.col07_f18cCustomers, Me.col08_f11cNamaTipeBRJ, Me.col09_f08cNamaMaterial_v50, Me.col10_f09cNamaKadarEmas, Me.col11_f20cNamaPlating_v50, Me.col12_f17nSize})
        Me.GridView1.GridControl = Me._gridResult
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'col01_f03cSKU
        '
        Me.col01_f03cSKU.AppearanceHeader.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col01_f03cSKU.AppearanceHeader.Options.UseFont = True
        Me.col01_f03cSKU.AppearanceHeader.Options.UseTextOptions = True
        Me.col01_f03cSKU.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col01_f03cSKU.Caption = "SKU"
        Me.col01_f03cSKU.MinWidth = 30
        Me.col01_f03cSKU.Name = "col01_f03cSKU"
        Me.col01_f03cSKU.Visible = True
        Me.col01_f03cSKU.VisibleIndex = 0
        Me.col01_f03cSKU.Width = 112
        '
        'col02_f02cKodeKaret
        '
        Me.col02_f02cKodeKaret.AppearanceHeader.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col02_f02cKodeKaret.AppearanceHeader.Options.UseFont = True
        Me.col02_f02cKodeKaret.AppearanceHeader.Options.UseTextOptions = True
        Me.col02_f02cKodeKaret.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col02_f02cKodeKaret.Caption = "Kode Karet"
        Me.col02_f02cKodeKaret.MinWidth = 30
        Me.col02_f02cKodeKaret.Name = "col02_f02cKodeKaret"
        Me.col02_f02cKodeKaret.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "Total")})
        Me.col02_f02cKodeKaret.Visible = True
        Me.col02_f02cKodeKaret.VisibleIndex = 1
        Me.col02_f02cKodeKaret.Width = 112
        '
        'col03_f12nQtyLot
        '
        Me.col03_f12nQtyLot.AppearanceHeader.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col03_f12nQtyLot.AppearanceHeader.Options.UseFont = True
        Me.col03_f12nQtyLot.AppearanceHeader.Options.UseTextOptions = True
        Me.col03_f12nQtyLot.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col03_f12nQtyLot.Caption = "LOT"
        Me.col03_f12nQtyLot.MinWidth = 30
        Me.col03_f12nQtyLot.Name = "col03_f12nQtyLot"
        Me.col03_f12nQtyLot.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "f12nQtyLot", "{0:n0}")})
        Me.col03_f12nQtyLot.Visible = True
        Me.col03_f12nQtyLot.VisibleIndex = 2
        Me.col03_f12nQtyLot.Width = 112
        '
        'col04_f13nBeratGross
        '
        Me.col04_f13nBeratGross.AppearanceHeader.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col04_f13nBeratGross.AppearanceHeader.Options.UseFont = True
        Me.col04_f13nBeratGross.AppearanceHeader.Options.UseTextOptions = True
        Me.col04_f13nBeratGross.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col04_f13nBeratGross.Caption = "W.Gross"
        Me.col04_f13nBeratGross.MinWidth = 30
        Me.col04_f13nBeratGross.Name = "col04_f13nBeratGross"
        Me.col04_f13nBeratGross.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "f13nBeratGross", "{0:n2}")})
        Me.col04_f13nBeratGross.Visible = True
        Me.col04_f13nBeratGross.VisibleIndex = 3
        Me.col04_f13nBeratGross.Width = 112
        '
        'col05_f15nTGramZircon
        '
        Me.col05_f15nTGramZircon.AppearanceHeader.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col05_f15nTGramZircon.AppearanceHeader.Options.UseFont = True
        Me.col05_f15nTGramZircon.AppearanceHeader.Options.UseTextOptions = True
        Me.col05_f15nTGramZircon.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col05_f15nTGramZircon.Caption = "Carat"
        Me.col05_f15nTGramZircon.MinWidth = 30
        Me.col05_f15nTGramZircon.Name = "col05_f15nTGramZircon"
        Me.col05_f15nTGramZircon.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "f15nTGramZircon", "{0:n3}")})
        Me.col05_f15nTGramZircon.Visible = True
        Me.col05_f15nTGramZircon.VisibleIndex = 4
        Me.col05_f15nTGramZircon.Width = 112
        '
        'col06_f14nBeratNett
        '
        Me.col06_f14nBeratNett.AppearanceHeader.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col06_f14nBeratNett.AppearanceHeader.Options.UseFont = True
        Me.col06_f14nBeratNett.AppearanceHeader.Options.UseTextOptions = True
        Me.col06_f14nBeratNett.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col06_f14nBeratNett.Caption = "W.Nett"
        Me.col06_f14nBeratNett.MinWidth = 30
        Me.col06_f14nBeratNett.Name = "col06_f14nBeratNett"
        Me.col06_f14nBeratNett.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "", "{0:n3}")})
        Me.col06_f14nBeratNett.Visible = True
        Me.col06_f14nBeratNett.VisibleIndex = 5
        Me.col06_f14nBeratNett.Width = 112
        '
        'col07_f18cCustomers
        '
        Me.col07_f18cCustomers.AppearanceHeader.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col07_f18cCustomers.AppearanceHeader.Options.UseFont = True
        Me.col07_f18cCustomers.AppearanceHeader.Options.UseTextOptions = True
        Me.col07_f18cCustomers.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col07_f18cCustomers.Caption = "Costumer"
        Me.col07_f18cCustomers.MinWidth = 30
        Me.col07_f18cCustomers.Name = "col07_f18cCustomers"
        Me.col07_f18cCustomers.Visible = True
        Me.col07_f18cCustomers.VisibleIndex = 6
        Me.col07_f18cCustomers.Width = 112
        '
        'col08_f11cNamaTipeBRJ
        '
        Me.col08_f11cNamaTipeBRJ.AppearanceHeader.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col08_f11cNamaTipeBRJ.AppearanceHeader.Options.UseFont = True
        Me.col08_f11cNamaTipeBRJ.AppearanceHeader.Options.UseTextOptions = True
        Me.col08_f11cNamaTipeBRJ.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col08_f11cNamaTipeBRJ.Caption = "Tipe"
        Me.col08_f11cNamaTipeBRJ.MinWidth = 30
        Me.col08_f11cNamaTipeBRJ.Name = "col08_f11cNamaTipeBRJ"
        Me.col08_f11cNamaTipeBRJ.Visible = True
        Me.col08_f11cNamaTipeBRJ.VisibleIndex = 7
        Me.col08_f11cNamaTipeBRJ.Width = 112
        '
        'col09_f08cNamaMaterial_v50
        '
        Me.col09_f08cNamaMaterial_v50.AppearanceHeader.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col09_f08cNamaMaterial_v50.AppearanceHeader.Options.UseFont = True
        Me.col09_f08cNamaMaterial_v50.AppearanceHeader.Options.UseTextOptions = True
        Me.col09_f08cNamaMaterial_v50.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col09_f08cNamaMaterial_v50.Caption = "RM"
        Me.col09_f08cNamaMaterial_v50.MinWidth = 30
        Me.col09_f08cNamaMaterial_v50.Name = "col09_f08cNamaMaterial_v50"
        Me.col09_f08cNamaMaterial_v50.Visible = True
        Me.col09_f08cNamaMaterial_v50.VisibleIndex = 8
        Me.col09_f08cNamaMaterial_v50.Width = 112
        '
        'col10_f09cNamaKadarEmas
        '
        Me.col10_f09cNamaKadarEmas.AppearanceHeader.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col10_f09cNamaKadarEmas.AppearanceHeader.Options.UseFont = True
        Me.col10_f09cNamaKadarEmas.AppearanceHeader.Options.UseTextOptions = True
        Me.col10_f09cNamaKadarEmas.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col10_f09cNamaKadarEmas.Caption = "Kadar"
        Me.col10_f09cNamaKadarEmas.MinWidth = 30
        Me.col10_f09cNamaKadarEmas.Name = "col10_f09cNamaKadarEmas"
        Me.col10_f09cNamaKadarEmas.Visible = True
        Me.col10_f09cNamaKadarEmas.VisibleIndex = 9
        Me.col10_f09cNamaKadarEmas.Width = 112
        '
        'col11_f20cNamaPlating_v50
        '
        Me.col11_f20cNamaPlating_v50.AppearanceHeader.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col11_f20cNamaPlating_v50.AppearanceHeader.Options.UseFont = True
        Me.col11_f20cNamaPlating_v50.AppearanceHeader.Options.UseTextOptions = True
        Me.col11_f20cNamaPlating_v50.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col11_f20cNamaPlating_v50.Caption = "Color"
        Me.col11_f20cNamaPlating_v50.MinWidth = 30
        Me.col11_f20cNamaPlating_v50.Name = "col11_f20cNamaPlating_v50"
        Me.col11_f20cNamaPlating_v50.Visible = True
        Me.col11_f20cNamaPlating_v50.VisibleIndex = 10
        Me.col11_f20cNamaPlating_v50.Width = 112
        '
        'col12_f17nSize
        '
        Me.col12_f17nSize.AppearanceHeader.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.col12_f17nSize.AppearanceHeader.Options.UseFont = True
        Me.col12_f17nSize.AppearanceHeader.Options.UseTextOptions = True
        Me.col12_f17nSize.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.col12_f17nSize.Caption = "Size"
        Me.col12_f17nSize.MinWidth = 30
        Me.col12_f17nSize.Name = "col12_f17nSize"
        Me.col12_f17nSize.Visible = True
        Me.col12_f17nSize.VisibleIndex = 11
        Me.col12_f17nSize.Width = 112
        '
        'btnGEtDataInbound
        '
        Me.btnGEtDataInbound.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question
        Me.btnGEtDataInbound.Appearance.Options.UseBackColor = True
        Me.btnGEtDataInbound.Location = New System.Drawing.Point(572, 57)
        Me.btnGEtDataInbound.Name = "btnGEtDataInbound"
        Me.btnGEtDataInbound.Size = New System.Drawing.Size(103, 32)
        Me.btnGEtDataInbound.StyleController = Me.LayoutControl1
        Me.btnGEtDataInbound.TabIndex = 15
        Me.btnGEtDataInbound.Text = "Refresh"
        '
        'btnRetransferBridging
        '
        Me.btnRetransferBridging.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.btnRetransferBridging.Appearance.Options.UseBackColor = True
        Me.btnRetransferBridging.Location = New System.Drawing.Point(1208, 101)
        Me.btnRetransferBridging.Name = "btnRetransferBridging"
        Me.btnRetransferBridging.Size = New System.Drawing.Size(156, 32)
        Me.btnRetransferBridging.StyleController = Me.LayoutControl1
        Me.btnRetransferBridging.TabIndex = 16
        Me.btnRetransferBridging.Text = "Retransfer Bridging"
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(808, 113)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(90, 32)
        Me.btnExport.StyleController = Me.LayoutControl1
        Me.btnExport.TabIndex = 21
        Me.btnExport.Text = "Export"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.TabbedControlGroup1})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1410, 951)
        Me.Root.TextVisible = False
        '
        'TabbedControlGroup1
        '
        Me.TabbedControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.TabbedControlGroup1.Name = "TabbedControlGroup1"
        Me.TabbedControlGroup1.SelectedTabPage = Me.LayoutControlGroup3
        Me.TabbedControlGroup1.Size = New System.Drawing.Size(1390, 931)
        Me.TabbedControlGroup1.TabPages.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlGroup1, Me.LayoutControlGroup3})
        '
        'LayoutControlGroup3
        '
        Me.LayoutControlGroup3.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem6, Me.lyt_01TglAwal, Me.lyt_02tglAkhir, Me.LayoutControlItem11, Me.EmptySpaceItem2, Me.LayoutControlItem13, Me.LayoutControlItem9, Me.EmptySpaceItem4, Me.EmptySpaceItem5, Me.LayoutControlGroup4, Me.LayoutControlItem15, Me.EmptySpaceItem3})
        Me.LayoutControlGroup3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup3.Name = "LayoutControlGroup3"
        Me.LayoutControlGroup3.Size = New System.Drawing.Size(1366, 874)
        Me.LayoutControlGroup3.Text = "Retransfer Bridging Jims"
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.gcBridging
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 92)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(1356, 782)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'lyt_01TglAwal
        '
        Me.lyt_01TglAwal.Control = Me._01TglAwal
        Me.lyt_01TglAwal.Location = New System.Drawing.Point(70, 0)
        Me.lyt_01TglAwal.MaxSize = New System.Drawing.Size(241, 30)
        Me.lyt_01TglAwal.MinSize = New System.Drawing.Size(241, 30)
        Me.lyt_01TglAwal.Name = "lyt_01TglAwal"
        Me.lyt_01TglAwal.Size = New System.Drawing.Size(241, 36)
        Me.lyt_01TglAwal.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lyt_01TglAwal.Text = "From"
        Me.lyt_01TglAwal.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.lyt_01TglAwal.TextSize = New System.Drawing.Size(37, 19)
        Me.lyt_01TglAwal.TextToControlDistance = 5
        '
        'lyt_02tglAkhir
        '
        Me.lyt_02tglAkhir.Control = Me._02tglAkhir
        Me.lyt_02tglAkhir.Location = New System.Drawing.Point(311, 0)
        Me.lyt_02tglAkhir.MaxSize = New System.Drawing.Size(237, 30)
        Me.lyt_02tglAkhir.MinSize = New System.Drawing.Size(237, 30)
        Me.lyt_02tglAkhir.Name = "lyt_02tglAkhir"
        Me.lyt_02tglAkhir.Size = New System.Drawing.Size(237, 36)
        Me.lyt_02tglAkhir.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.lyt_02tglAkhir.Text = "To"
        Me.lyt_02tglAkhir.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.lyt_02tglAkhir.TextSize = New System.Drawing.Size(19, 19)
        Me.lyt_02tglAkhir.TextToControlDistance = 5
        '
        'LayoutControlItem11
        '
        Me.LayoutControlItem11.Control = Me.btnGEtDataInbound
        Me.LayoutControlItem11.Location = New System.Drawing.Point(548, 0)
        Me.LayoutControlItem11.MaxSize = New System.Drawing.Size(107, 36)
        Me.LayoutControlItem11.MinSize = New System.Drawing.Size(107, 36)
        Me.LayoutControlItem11.Name = "LayoutControlItem11"
        Me.LayoutControlItem11.Size = New System.Drawing.Size(107, 36)
        Me.LayoutControlItem11.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem11.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem11.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(655, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(223, 36)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem13
        '
        Me.LayoutControlItem13.Control = Me.ocFilter
        Me.LayoutControlItem13.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem13.Name = "LayoutControlItem13"
        Me.LayoutControlItem13.Size = New System.Drawing.Size(70, 36)
        Me.LayoutControlItem13.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem13.TextVisible = False
        '
        'LayoutControlItem9
        '
        Me.LayoutControlItem9.Control = Me.ocSelectAll
        Me.LayoutControlItem9.Location = New System.Drawing.Point(0, 56)
        Me.LayoutControlItem9.Name = "LayoutControlItem9"
        Me.LayoutControlItem9.Size = New System.Drawing.Size(100, 36)
        Me.LayoutControlItem9.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem9.TextVisible = False
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(1356, 0)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(10, 874)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'EmptySpaceItem5
        '
        Me.EmptySpaceItem5.AllowHotTrack = False
        Me.EmptySpaceItem5.Location = New System.Drawing.Point(0, 36)
        Me.EmptySpaceItem5.Name = "EmptySpaceItem5"
        Me.EmptySpaceItem5.Size = New System.Drawing.Size(878, 20)
        Me.EmptySpaceItem5.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup4
        '
        Me.LayoutControlGroup4.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem10, Me.LayoutControlItem14, Me.LayoutControlItem12})
        Me.LayoutControlGroup4.Location = New System.Drawing.Point(878, 0)
        Me.LayoutControlGroup4.Name = "LayoutControlGroup4"
        Me.LayoutControlGroup4.Size = New System.Drawing.Size(478, 92)
        Me.LayoutControlGroup4.Text = "Options Retransfer"
        '
        'LayoutControlItem10
        '
        Me.LayoutControlItem10.Control = Me.ocKirimParent
        Me.LayoutControlItem10.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem10.Name = "LayoutControlItem10"
        Me.LayoutControlItem10.Size = New System.Drawing.Size(144, 36)
        Me.LayoutControlItem10.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem10.TextVisible = False
        '
        'LayoutControlItem14
        '
        Me.LayoutControlItem14.Control = Me.ocKirimSKUPerpcs
        Me.LayoutControlItem14.Location = New System.Drawing.Point(144, 0)
        Me.LayoutControlItem14.Name = "LayoutControlItem14"
        Me.LayoutControlItem14.Size = New System.Drawing.Size(150, 36)
        Me.LayoutControlItem14.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem14.TextVisible = False
        '
        'LayoutControlItem12
        '
        Me.LayoutControlItem12.Control = Me.btnRetransferBridging
        Me.LayoutControlItem12.Location = New System.Drawing.Point(294, 0)
        Me.LayoutControlItem12.Name = "LayoutControlItem12"
        Me.LayoutControlItem12.Size = New System.Drawing.Size(160, 36)
        Me.LayoutControlItem12.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem12.TextVisible = False
        '
        'LayoutControlItem15
        '
        Me.LayoutControlItem15.Control = Me.btnExport
        Me.LayoutControlItem15.Location = New System.Drawing.Point(784, 56)
        Me.LayoutControlItem15.Name = "LayoutControlItem15"
        Me.LayoutControlItem15.Size = New System.Drawing.Size(94, 36)
        Me.LayoutControlItem15.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem15.TextVisible = False
        '
        'EmptySpaceItem3
        '
        Me.EmptySpaceItem3.AllowHotTrack = False
        Me.EmptySpaceItem3.Location = New System.Drawing.Point(100, 56)
        Me.EmptySpaceItem3.Name = "EmptySpaceItem3"
        Me.EmptySpaceItem3.Size = New System.Drawing.Size(684, 36)
        Me.EmptySpaceItem3.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem2, Me.LayoutControlItem1, Me.LayoutControlItem5, Me.EmptySpaceItem1, Me.LayoutControlItem7, Me.LayoutControlItem3, Me.lytResponseJIms, Me.LayoutControlGroup2, Me.LayoutControlItem8})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(1366, 874)
        Me.LayoutControlGroup1.Text = "Retransfer API"
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.AppearanceItemCaption.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem2.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem2.Control = Me._01NoDO
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Padding = New DevExpress.XtraLayout.Utils.Padding(10, 10, 10, 10)
        Me.LayoutControlItem2.Size = New System.Drawing.Size(684, 50)
        Me.LayoutControlItem2.Text = "NO DO"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(139, 22)
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.btnGetdata
        Me.LayoutControlItem1.Location = New System.Drawing.Point(684, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(187, 50)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.btnsend
        Me.LayoutControlItem5.Location = New System.Drawing.Point(871, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(173, 50)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(1044, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(322, 50)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem7
        '
        Me.LayoutControlItem7.AppearanceItemCaptionDisabled.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem7.AppearanceItemCaptionDisabled.Options.UseFont = True
        Me.LayoutControlItem7.Control = Me._clblData
        Me.LayoutControlItem7.Location = New System.Drawing.Point(0, 50)
        Me.LayoutControlItem7.Name = "LayoutControlItem7"
        Me.LayoutControlItem7.Padding = New DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4)
        Me.LayoutControlItem7.Size = New System.Drawing.Size(1366, 30)
        Me.LayoutControlItem7.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem7.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me._gridResult
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 80)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(1083, 633)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'lytResponseJIms
        '
        Me.lytResponseJIms.AppearanceItemCaption.Font = New System.Drawing.Font("Calibri", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lytResponseJIms.AppearanceItemCaption.Options.UseFont = True
        Me.lytResponseJIms.AppearanceItemCaptionDisabled.Font = New System.Drawing.Font("Calibri", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lytResponseJIms.AppearanceItemCaptionDisabled.Options.UseFont = True
        Me.lytResponseJIms.Control = Me._03Response
        Me.lytResponseJIms.Location = New System.Drawing.Point(0, 748)
        Me.lytResponseJIms.Name = "lytResponseJIms"
        Me.lytResponseJIms.Padding = New DevExpress.XtraLayout.Utils.Padding(4, 4, 4, 4)
        Me.lytResponseJIms.Size = New System.Drawing.Size(1366, 126)
        Me.lytResponseJIms.Text = "Respon From JIMS"
        Me.lytResponseJIms.TextLocation = DevExpress.Utils.Locations.Top
        Me.lytResponseJIms.TextSize = New System.Drawing.Size(139, 22)
        Me.lytResponseJIms.Visibility = DevExpress.XtraLayout.Utils.LayoutVisibility.Never
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem4})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(1083, 80)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(283, 633)
        Me.LayoutControlGroup2.Text = "Data Post To Api"
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me._02JsonString
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(259, 577)
        Me.LayoutControlItem4.Text = "Data JSON"
        Me.LayoutControlItem4.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(139, 19)
        '
        'LayoutControlItem8
        '
        Me.LayoutControlItem8.Control = Me.CheckEdit1
        Me.LayoutControlItem8.Location = New System.Drawing.Point(0, 713)
        Me.LayoutControlItem8.Name = "LayoutControlItem8"
        Me.LayoutControlItem8.Size = New System.Drawing.Size(1366, 35)
        Me.LayoutControlItem8.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem8.TextVisible = False
        '
        'frmPOSTdataTOAPI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1410, 951)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmPOSTdataTOAPI"
        Me.Text = "CITRIX-Retransfer Data"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.ocKirimSKUPerpcs.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ocKirimParent.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ocSelectAll.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ocFilter.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._02tglAkhir.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._02tglAkhir.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._01TglAwal.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._01TglAwal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcBridging, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gvBridging, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rscol00_bCheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CheckEdit1.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._03Response.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._02JsonString.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._01NoDO.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._gridResult, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TabbedControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyt_01TglAwal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyt_02tglAkhir, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem11, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem13, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem9, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem10, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem14, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem15, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem7, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lytResponseJIms, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem8, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents btnGetdata As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents _01NoDO As DevExpress.XtraEditors.TextEdit
    Friend WithEvents _gridResult As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents _02JsonString As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnsend As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents _03Response As DevExpress.XtraEditors.MemoEdit
    Friend WithEvents lytResponseJIms As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents col01_f03cSKU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col02_f02cKodeKaret As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col03_f12nQtyLot As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col04_f13nBeratGross As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col05_f15nTGramZircon As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col06_f14nBeratNett As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col07_f18cCustomers As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col08_f11cNamaTipeBRJ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col09_f08cNamaMaterial_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col10_f09cNamaKadarEmas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col11_f20cNamaPlating_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col12_f17nSize As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents _clblData As DevExpress.XtraEditors.LabelControl
    Friend WithEvents CheckEdit1 As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem8 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents TabbedControlGroup1 As DevExpress.XtraLayout.TabbedControlGroup
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem7 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlGroup3 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents gcBridging As DevExpress.XtraGrid.GridControl
    Friend WithEvents gvBridging As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colB00_bCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rscol00_bCheck As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents colB01_k02SPK As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colB03_k04DesignCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colB04_NamaNORO As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colB05_NamaWarnaEmas As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colB06_NamaKadar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colB07_NamaTipeBRJ As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colB08_NamaSize As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colB09_NamaBrand As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colB10_NamaMaterial As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colB11_NamaGender As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colB12_NamaEngrave As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colB13_OrderStatus As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colB14_NoDocument As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colB15_PCSSKU As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colB16_ButirSTone As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colB17_BeratGrosss As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colB18_BeratNett As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents colB19_TglInbound As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents _02tglAkhir As DevExpress.XtraEditors.DateEdit
    Friend WithEvents _01TglAwal As DevExpress.XtraEditors.DateEdit
    Friend WithEvents lyt_01TglAwal As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents lyt_02tglAkhir As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnGEtDataInbound As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem11 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents colB02_k03ProductCode As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnRetransferBridging As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem12 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ocFilter As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem13 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents ocSelectAll As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem9 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents colB20_f01NamaUser As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ocKirimSKUPerpcs As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents ocKirimParent As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlGroup4 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem10 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem14 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents EmptySpaceItem5 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents colB21_nTtlGrossPCS As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents btnExport As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem15 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem3 As DevExpress.XtraLayout.EmptySpaceItem
End Class
