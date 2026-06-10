<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xfsaveImagetopath
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
        Me._02Loading = New DevExpress.XtraEditors.ProgressBarControl()
        Me._01ProductCode = New DevExpress.XtraEditors.TextEdit()
        Me.gcImage = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col01_f01objGambar = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rs_col01_f01objGambar = New DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit()
        Me.col02_f02cKodeFGorComponent_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col03_k01cKodeGambar_v50 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnSimpan = New DevExpress.XtraEditors.SimpleButton()
        Me.btnGetdate = New DevExpress.XtraEditors.SimpleButton()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me._03labelData = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.lblNama = New DevExpress.XtraLayout.SimpleLabelItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me._02Loading.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._01ProductCode.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.gcImage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rs_col01_f01objGambar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._03labelData, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lblNama, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me._02Loading)
        Me.LayoutControl1.Controls.Add(Me._01ProductCode)
        Me.LayoutControl1.Controls.Add(Me.gcImage)
        Me.LayoutControl1.Controls.Add(Me.btnSimpan)
        Me.LayoutControl1.Controls.Add(Me.btnGetdate)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1139, 614)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        '_02Loading
        '
        Me._02Loading.Location = New System.Drawing.Point(119, 35)
        Me._02Loading.Name = "_02Loading"
        Me._02Loading.Properties.Appearance.BackColor = System.Drawing.Color.FromArgb(CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(224, Byte), Integer))
        Me._02Loading.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me._02Loading.Properties.EndColor = System.Drawing.Color.ForestGreen
        Me._02Loading.Properties.ShowTitle = True
        Me._02Loading.Properties.Step = 0
        Me._02Loading.Size = New System.Drawing.Size(555, 22)
        Me._02Loading.StyleController = Me.LayoutControl1
        Me._02Loading.TabIndex = 8
        '
        '_01ProductCode
        '
        Me._01ProductCode.Location = New System.Drawing.Point(785, 12)
        Me._01ProductCode.Name = "_01ProductCode"
        Me._01ProductCode.Size = New System.Drawing.Size(342, 26)
        Me._01ProductCode.StyleController = Me.LayoutControl1
        Me._01ProductCode.TabIndex = 6
        '
        'gcImage
        '
        Me.gcImage.Location = New System.Drawing.Point(12, 87)
        Me.gcImage.MainView = Me.GridView1
        Me.gcImage.Name = "gcImage"
        Me.gcImage.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rs_col01_f01objGambar})
        Me.gcImage.Size = New System.Drawing.Size(662, 515)
        Me.gcImage.TabIndex = 4
        Me.gcImage.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col01_f01objGambar, Me.col02_f02cKodeFGorComponent_v50, Me.col03_k01cKodeGambar_v50})
        Me.GridView1.GridControl = Me.gcImage
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.RowAutoHeight = True
        '
        'col01_f01objGambar
        '
        Me.col01_f01objGambar.Caption = "IMG"
        Me.col01_f01objGambar.ColumnEdit = Me.rs_col01_f01objGambar
        Me.col01_f01objGambar.MinWidth = 30
        Me.col01_f01objGambar.Name = "col01_f01objGambar"
        Me.col01_f01objGambar.Visible = True
        Me.col01_f01objGambar.VisibleIndex = 0
        Me.col01_f01objGambar.Width = 112
        '
        'rs_col01_f01objGambar
        '
        Me.rs_col01_f01objGambar.Name = "rs_col01_f01objGambar"
        Me.rs_col01_f01objGambar.PictureStoreMode = DevExpress.XtraEditors.Controls.PictureStoreMode.ByteArray
        Me.rs_col01_f01objGambar.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
        '
        'col02_f02cKodeFGorComponent_v50
        '
        Me.col02_f02cKodeFGorComponent_v50.Caption = "Nama Gambar"
        Me.col02_f02cKodeFGorComponent_v50.MinWidth = 30
        Me.col02_f02cKodeFGorComponent_v50.Name = "col02_f02cKodeFGorComponent_v50"
        Me.col02_f02cKodeFGorComponent_v50.Visible = True
        Me.col02_f02cKodeFGorComponent_v50.VisibleIndex = 1
        Me.col02_f02cKodeFGorComponent_v50.Width = 112
        '
        'col03_k01cKodeGambar_v50
        '
        Me.col03_k01cKodeGambar_v50.Caption = "Kode gambar"
        Me.col03_k01cKodeGambar_v50.MinWidth = 30
        Me.col03_k01cKodeGambar_v50.Name = "col03_k01cKodeGambar_v50"
        Me.col03_k01cKodeGambar_v50.Visible = True
        Me.col03_k01cKodeGambar_v50.VisibleIndex = 2
        Me.col03_k01cKodeGambar_v50.Width = 112
        '
        'btnSimpan
        '
        Me.btnSimpan.Location = New System.Drawing.Point(678, 570)
        Me.btnSimpan.Name = "btnSimpan"
        Me.btnSimpan.Size = New System.Drawing.Size(449, 32)
        Me.btnSimpan.StyleController = Me.LayoutControl1
        Me.btnSimpan.TabIndex = 5
        Me.btnSimpan.Text = "Simpan Gambar"
        '
        'btnGetdate
        '
        Me.btnGetdate.Location = New System.Drawing.Point(678, 42)
        Me.btnGetdate.Name = "btnGetdate"
        Me.btnGetdate.Size = New System.Drawing.Size(449, 32)
        Me.btnGetdate.StyleController = Me.LayoutControl1
        Me.btnGetdate.TabIndex = 7
        Me.btnGetdate.Text = "Get Gambar"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.LayoutControlItem2, Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem5, Me._03labelData, Me.lblNama})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1139, 614)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.gcImage
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 75)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(666, 519)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(666, 66)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(453, 492)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.btnSimpan
        Me.LayoutControlItem2.Location = New System.Drawing.Point(666, 558)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(453, 36)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me._01ProductCode
        Me.LayoutControlItem3.Location = New System.Drawing.Point(666, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(453, 30)
        Me.LayoutControlItem3.Text = "product Code"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(95, 19)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me.btnGetdate
        Me.LayoutControlItem4.Location = New System.Drawing.Point(666, 30)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(453, 36)
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem4.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me._02Loading
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 23)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(666, 26)
        Me.LayoutControlItem5.Text = "Proses data"
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(95, 19)
        '
        '_03labelData
        '
        Me._03labelData.AllowHotTrack = False
        Me._03labelData.Location = New System.Drawing.Point(0, 0)
        Me._03labelData.Name = "_03labelData"
        Me._03labelData.Size = New System.Drawing.Size(666, 23)
        Me._03labelData.Text = "-"
        Me._03labelData.TextSize = New System.Drawing.Size(95, 19)
        '
        'lblNama
        '
        Me.lblNama.AllowHotTrack = False
        Me.lblNama.AppearanceItemCaption.Font = New System.Drawing.Font("Calibri", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.AppearanceItemCaption.Options.UseFont = True
        Me.lblNama.Location = New System.Drawing.Point(0, 49)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(666, 26)
        Me.lblNama.Text = "-"
        Me.lblNama.TextSize = New System.Drawing.Size(95, 22)
        '
        'xfsaveImagetopath
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1139, 614)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "xfsaveImagetopath"
        Me.Text = "xfsaveImagetopath"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me._02Loading.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._01ProductCode.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.gcImage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rs_col01_f01objGambar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._03labelData, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lblNama, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents _01ProductCode As DevExpress.XtraEditors.TextEdit
    Friend WithEvents gcImage As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents btnSimpan As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents btnGetdate As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents col01_f01objGambar As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rs_col01_f01objGambar As DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit
    Friend WithEvents col02_f02cKodeFGorComponent_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col03_k01cKodeGambar_v50 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents _02Loading As DevExpress.XtraEditors.ProgressBarControl
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents _03labelData As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents lblNama As DevExpress.XtraLayout.SimpleLabelItem
End Class
