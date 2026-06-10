<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xf54ShcedulerBackup
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xf54ShcedulerBackup))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.ocSelectAll = New DevExpress.XtraEditors.CheckEdit()
        Me._03JamSiang = New System.Windows.Forms.DateTimePicker()
        Me.lblJAM = New DevExpress.XtraEditors.LabelControl()
        Me._02PathTujuan = New DevExpress.XtraEditors.TextEdit()
        Me._01PathAsal = New DevExpress.XtraEditors.TextEdit()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.col00_bCheck = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.rscol00_bCheck = New DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit()
        Me.col02_k01cNamafile = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col03_f01cFileSize = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col04_f02dTglBackUp = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.col05_f03cStatusCopy = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.btnLoad = New DevExpress.XtraEditors.SimpleButton()
        Me.btnCopyFile = New DevExpress.XtraEditors.SimpleButton()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlGroup1 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem4 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lyt_03JamBackup = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.lytctrl = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LabelStatus = New DevExpress.XtraLayout.SimpleLabelItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.tmJam = New System.Windows.Forms.Timer(Me.components)
        Me.tmBackUp = New System.Windows.Forms.Timer(Me.components)
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.ocSelectAll.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._02PathTujuan.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._01PathAsal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.rscol00_bCheck, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyt_03JamBackup, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lytctrl, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LabelStatus, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.ocSelectAll)
        Me.LayoutControl1.Controls.Add(Me._03JamSiang)
        Me.LayoutControl1.Controls.Add(Me.lblJAM)
        Me.LayoutControl1.Controls.Add(Me._02PathTujuan)
        Me.LayoutControl1.Controls.Add(Me._01PathAsal)
        Me.LayoutControl1.Controls.Add(Me.GridControl1)
        Me.LayoutControl1.Controls.Add(Me.btnLoad)
        Me.LayoutControl1.Controls.Add(Me.btnCopyFile)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1289, 796)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'ocSelectAll
        '
        Me.ocSelectAll.Location = New System.Drawing.Point(12, 164)
        Me.ocSelectAll.Name = "ocSelectAll"
        Me.ocSelectAll.Properties.Caption = "Select All"
        Me.ocSelectAll.Size = New System.Drawing.Size(109, 27)
        Me.ocSelectAll.StyleController = Me.LayoutControl1
        Me.ocSelectAll.TabIndex = 13
        '
        '_03JamSiang
        '
        Me._03JamSiang.Location = New System.Drawing.Point(767, 78)
        Me._03JamSiang.Name = "_03JamSiang"
        Me._03JamSiang.Size = New System.Drawing.Size(219, 27)
        Me._03JamSiang.TabIndex = 12
        '
        'lblJAM
        '
        Me.lblJAM.Appearance.BackColor = System.Drawing.Color.Black
        Me.lblJAM.Appearance.Font = New System.Drawing.Font("Calibri", 14.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJAM.Appearance.ForeColor = DevExpress.LookAndFeel.DXSkinColors.ForeColors.Warning
        Me.lblJAM.Appearance.Options.UseBackColor = True
        Me.lblJAM.Appearance.Options.UseFont = True
        Me.lblJAM.Appearance.Options.UseForeColor = True
        Me.lblJAM.Location = New System.Drawing.Point(580, 56)
        Me.lblJAM.Name = "lblJAM"
        Me.lblJAM.Padding = New System.Windows.Forms.Padding(10)
        Me.lblJAM.Size = New System.Drawing.Size(183, 55)
        Me.lblJAM.StyleController = Me.LayoutControl1
        Me.lblJAM.TabIndex = 11
        Me.lblJAM.Text = "LabelControl1"
        '
        '_02PathTujuan
        '
        Me._02PathTujuan.Location = New System.Drawing.Point(169, 86)
        Me._02PathTujuan.Name = "_02PathTujuan"
        Me._02PathTujuan.Size = New System.Drawing.Size(383, 26)
        Me._02PathTujuan.StyleController = Me.LayoutControl1
        Me._02PathTujuan.TabIndex = 8
        '
        '_01PathAsal
        '
        Me._01PathAsal.Location = New System.Drawing.Point(169, 56)
        Me._01PathAsal.Name = "_01PathAsal"
        Me._01PathAsal.Size = New System.Drawing.Size(383, 26)
        Me._01PathAsal.StyleController = Me.LayoutControl1
        Me._01PathAsal.TabIndex = 7
        '
        'GridControl1
        '
        Me.GridControl1.Location = New System.Drawing.Point(12, 195)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.rscol00_bCheck})
        Me.GridControl1.Size = New System.Drawing.Size(1265, 589)
        Me.GridControl1.TabIndex = 4
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Appearance.FocusedRow.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.GridView1.Appearance.FocusedRow.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.GridView1.Appearance.FocusedRow.Options.UseBackColor = True
        Me.GridView1.Appearance.FocusedRow.Options.UseForeColor = True
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.col00_bCheck, Me.col02_k01cNamafile, Me.col03_f01cFileSize, Me.col04_f02dTglBackUp, Me.col05_f03cStatusCopy})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsView.ShowFooter = True
        Me.GridView1.OptionsView.ShowGroupPanel = False
        '
        'col00_bCheck
        '
        Me.col00_bCheck.Caption = "#"
        Me.col00_bCheck.ColumnEdit = Me.rscol00_bCheck
        Me.col00_bCheck.MinWidth = 30
        Me.col00_bCheck.Name = "col00_bCheck"
        Me.col00_bCheck.Visible = True
        Me.col00_bCheck.VisibleIndex = 0
        Me.col00_bCheck.Width = 57
        '
        'rscol00_bCheck
        '
        Me.rscol00_bCheck.AutoHeight = False
        Me.rscol00_bCheck.Name = "rscol00_bCheck"
        Me.rscol00_bCheck.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Unchecked
        '
        'col02_k01cNamafile
        '
        Me.col02_k01cNamafile.Caption = "FIleName"
        Me.col02_k01cNamafile.MinWidth = 30
        Me.col02_k01cNamafile.Name = "col02_k01cNamafile"
        Me.col02_k01cNamafile.OptionsColumn.ReadOnly = True
        Me.col02_k01cNamafile.Visible = True
        Me.col02_k01cNamafile.VisibleIndex = 1
        Me.col02_k01cNamafile.Width = 386
        '
        'col03_f01cFileSize
        '
        Me.col03_f01cFileSize.Caption = "Size"
        Me.col03_f01cFileSize.DisplayFormat.FormatString = "{0:n0} KB"
        Me.col03_f01cFileSize.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric
        Me.col03_f01cFileSize.MinWidth = 30
        Me.col03_f01cFileSize.Name = "col03_f01cFileSize"
        Me.col03_f01cFileSize.OptionsColumn.ReadOnly = True
        Me.col03_f01cFileSize.Visible = True
        Me.col03_f01cFileSize.VisibleIndex = 2
        Me.col03_f01cFileSize.Width = 307
        '
        'col04_f02dTglBackUp
        '
        Me.col04_f02dTglBackUp.Caption = "Tgl. BackUp"
        Me.col04_f02dTglBackUp.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss"
        Me.col04_f02dTglBackUp.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime
        Me.col04_f02dTglBackUp.MinWidth = 30
        Me.col04_f02dTglBackUp.Name = "col04_f02dTglBackUp"
        Me.col04_f02dTglBackUp.Visible = True
        Me.col04_f02dTglBackUp.VisibleIndex = 3
        Me.col04_f02dTglBackUp.Width = 200
        '
        'col05_f03cStatusCopy
        '
        Me.col05_f03cStatusCopy.Caption = "Status"
        Me.col05_f03cStatusCopy.MinWidth = 30
        Me.col05_f03cStatusCopy.Name = "col05_f03cStatusCopy"
        Me.col05_f03cStatusCopy.OptionsColumn.ReadOnly = True
        Me.col05_f03cStatusCopy.Visible = True
        Me.col05_f03cStatusCopy.VisibleIndex = 4
        Me.col05_f03cStatusCopy.Width = 112
        '
        'btnLoad
        '
        Me.btnLoad.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question
        Me.btnLoad.Appearance.Options.UseBackColor = True
        Me.btnLoad.Location = New System.Drawing.Point(24, 116)
        Me.btnLoad.Name = "btnLoad"
        Me.btnLoad.Size = New System.Drawing.Size(103, 32)
        Me.btnLoad.StyleController = Me.LayoutControl1
        Me.btnLoad.TabIndex = 5
        Me.btnLoad.Text = "Load"
        '
        'btnCopyFile
        '
        Me.btnCopyFile.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.btnCopyFile.Appearance.Options.UseBackColor = True
        Me.btnCopyFile.Location = New System.Drawing.Point(568, 127)
        Me.btnCopyFile.Name = "btnCopyFile"
        Me.btnCopyFile.Size = New System.Drawing.Size(709, 32)
        Me.btnCopyFile.StyleController = Me.LayoutControl1
        Me.btnCopyFile.TabIndex = 6
        Me.btnCopyFile.Text = "RUN BACKUP"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.LayoutControlGroup1, Me.LayoutControlGroup2, Me.LayoutControlItem6, Me.lytctrl, Me.LabelStatus, Me.EmptySpaceItem2})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1289, 796)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.GridControl1
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 183)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(1269, 593)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'LayoutControlGroup1
        '
        Me.LayoutControlGroup1.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem3, Me.LayoutControlItem4, Me.LayoutControlItem2, Me.EmptySpaceItem4})
        Me.LayoutControlGroup1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlGroup1.Name = "LayoutControlGroup1"
        Me.LayoutControlGroup1.Size = New System.Drawing.Size(556, 152)
        Me.LayoutControlGroup1.Text = "Directory Path"
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me._01PathAsal
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(532, 30)
        Me.LayoutControlItem3.Text = "Resource Directory"
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(133, 19)
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.Control = Me._02PathTujuan
        Me.LayoutControlItem4.Location = New System.Drawing.Point(0, 30)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(532, 30)
        Me.LayoutControlItem4.Text = "Target Directory"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(133, 19)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.btnLoad
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 60)
        Me.LayoutControlItem2.MaxSize = New System.Drawing.Size(107, 36)
        Me.LayoutControlItem2.MinSize = New System.Drawing.Size(107, 36)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(107, 36)
        Me.LayoutControlItem2.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'EmptySpaceItem4
        '
        Me.EmptySpaceItem4.AllowHotTrack = False
        Me.EmptySpaceItem4.Location = New System.Drawing.Point(107, 60)
        Me.EmptySpaceItem4.Name = "EmptySpaceItem4"
        Me.EmptySpaceItem4.Size = New System.Drawing.Size(425, 36)
        Me.EmptySpaceItem4.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem5, Me.lyt_03JamBackup, Me.EmptySpaceItem1})
        Me.LayoutControlGroup2.Location = New System.Drawing.Point(556, 0)
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(713, 115)
        Me.LayoutControlGroup2.Text = "Backup"
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.lblJAM
        Me.LayoutControlItem5.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(187, 59)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'lyt_03JamBackup
        '
        Me.lyt_03JamBackup.Control = Me._03JamSiang
        Me.lyt_03JamBackup.Location = New System.Drawing.Point(187, 0)
        Me.lyt_03JamBackup.Name = "lyt_03JamBackup"
        Me.lyt_03JamBackup.Size = New System.Drawing.Size(223, 59)
        Me.lyt_03JamBackup.Text = "BACKUP SIANG"
        Me.lyt_03JamBackup.TextLocation = DevExpress.Utils.Locations.Top
        Me.lyt_03JamBackup.TextSize = New System.Drawing.Size(133, 19)
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me.ocSelectAll
        Me.LayoutControlItem6.Location = New System.Drawing.Point(0, 152)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(113, 31)
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem6.TextVisible = False
        '
        'lytctrl
        '
        Me.lytctrl.Control = Me.btnCopyFile
        Me.lytctrl.Location = New System.Drawing.Point(556, 115)
        Me.lytctrl.Name = "lytctrl"
        Me.lytctrl.Size = New System.Drawing.Size(713, 37)
        Me.lytctrl.TextSize = New System.Drawing.Size(0, 0)
        Me.lytctrl.TextVisible = False
        '
        'LabelStatus
        '
        Me.LabelStatus.AllowHotTrack = False
        Me.LabelStatus.AppearanceItemCaption.Font = New System.Drawing.Font("Tahoma", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelStatus.AppearanceItemCaption.Options.UseFont = True
        Me.LabelStatus.Location = New System.Drawing.Point(123, 152)
        Me.LabelStatus.Name = "LabelStatus"
        Me.LabelStatus.Size = New System.Drawing.Size(1146, 31)
        Me.LabelStatus.Text = "-"
        Me.LabelStatus.TextAlignMode = DevExpress.XtraLayout.TextAlignModeItem.AutoSize
        Me.LabelStatus.TextSize = New System.Drawing.Size(7, 22)
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(113, 152)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(10, 31)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'tmJam
        '
        '
        'tmBackUp
        '
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(410, 0)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(279, 59)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'xf54ShcedulerBackup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1289, 796)
        Me.Controls.Add(Me.LayoutControl1)
        Me.IconOptions.Image = CType(resources.GetObject("xf54ShcedulerBackup.IconOptions.Image"), System.Drawing.Image)
        Me.Name = "xf54ShcedulerBackup"
        Me.Text = "COPY DATABASE"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.ocSelectAll.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._02PathTujuan.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._01PathAsal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.rscol00_bCheck, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyt_03JamBackup, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lytctrl, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LabelStatus, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents btnLoad As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents col00_bCheck As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col02_k01cNamafile As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents col03_f01cFileSize As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents rscol00_bCheck As DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit
    Friend WithEvents btnCopyFile As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents lytctrl As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents _02PathTujuan As DevExpress.XtraEditors.TextEdit
    Friend WithEvents _01PathAsal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents col04_f02dTglBackUp As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents tmJam As Timer
    Friend WithEvents LayoutControlGroup1 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents lblJAM As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem4 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents _03JamSiang As DateTimePicker
    Friend WithEvents lyt_03JamBackup As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents tmBackUp As Timer
    Friend WithEvents col05_f03cStatusCopy As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents ocSelectAll As DevExpress.XtraEditors.CheckEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LabelStatus As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
End Class
