<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ucMRPUpload2DJOBCARD
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ucMRPUpload2DJOBCARD))
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.fciMultipel = New NCREPOSITORYlib.clsMltp22FCI()
        Me.SimpleButton2 = New DevExpress.XtraEditors.SimpleButton()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me._01Novalidation = New NCREPOSITORYlib.ctrlSLEGlobalMaster()
        Me.CtrlSLEGlobalMaster2View = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.btnSelectIMG = New DevExpress.XtraEditors.SimpleButton()
        Me._peIMG2D = New DevExpress.XtraEditors.PictureEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem4 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem5 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem2 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.lyt = New DevExpress.XtraLayout.LayoutControlItem()
        Me._cKodeGambar = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem6 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.fciMultipel.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._01Novalidation.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CtrlSLEGlobalMaster2View, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._peIMG2D.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.lyt, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._cKodeGambar.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me._cKodeGambar)
        Me.LayoutControl1.Controls.Add(Me.fciMultipel)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton2)
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me._01Novalidation)
        Me.LayoutControl1.Controls.Add(Me.btnSelectIMG)
        Me.LayoutControl1.Controls.Add(Me._peIMG2D)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(1159, 574)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'fciMultipel
        '
        Me.fciMultipel._01prop_dtMasterSKK = Nothing
        Me.fciMultipel._02prop_FilterKodeMasterSKK = Nothing
        Me.fciMultipel.EditValue = ""
        Me.fciMultipel.Location = New System.Drawing.Point(709, 112)
        Me.fciMultipel.Name = "fciMultipel"
        Me.fciMultipel.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.fciMultipel.Size = New System.Drawing.Size(438, 28)
        Me.fciMultipel.StyleController = Me.LayoutControl1
        Me.fciMultipel.TabIndex = 10
        '
        'SimpleButton2
        '
        Me.SimpleButton2.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Question
        Me.SimpleButton2.Appearance.Font = New System.Drawing.Font("Arial Narrow", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton2.Appearance.Options.UseBackColor = True
        Me.SimpleButton2.Appearance.Options.UseFont = True
        Me.SimpleButton2.Location = New System.Drawing.Point(870, 76)
        Me.SimpleButton2.Name = "SimpleButton2"
        Me.SimpleButton2.Size = New System.Drawing.Size(277, 32)
        Me.SimpleButton2.StyleController = Me.LayoutControl1
        Me.SimpleButton2.TabIndex = 9
        Me.SimpleButton2.Text = "Upload Picture"
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Warning
        Me.SimpleButton1.Appearance.Font = New System.Drawing.Font("Arial Narrow", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SimpleButton1.Appearance.Options.UseBackColor = True
        Me.SimpleButton1.Appearance.Options.UseFont = True
        Me.SimpleButton1.Location = New System.Drawing.Point(591, 76)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(275, 32)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 8
        Me.SimpleButton1.Text = "Show Picture"
        '
        '_01Novalidation
        '
        Me._01Novalidation._02prop_fieldValueMember = Nothing
        Me._01Novalidation._03prop_fieldDisplayMember = Nothing
        Me._01Novalidation.Location = New System.Drawing.Point(709, 44)
        Me._01Novalidation.Name = "_01Novalidation"
        Me._01Novalidation.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._01Novalidation.Properties.PopupView = Me.CtrlSLEGlobalMaster2View
        Me._01Novalidation.Size = New System.Drawing.Size(438, 28)
        Me._01Novalidation.StyleController = Me.LayoutControl1
        Me._01Novalidation.TabIndex = 7
        '
        'CtrlSLEGlobalMaster2View
        '
        Me.CtrlSLEGlobalMaster2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus
        Me.CtrlSLEGlobalMaster2View.Name = "CtrlSLEGlobalMaster2View"
        Me.CtrlSLEGlobalMaster2View.OptionsSelection.EnableAppearanceFocusedCell = False
        Me.CtrlSLEGlobalMaster2View.OptionsView.ShowGroupPanel = False
        '
        'btnSelectIMG
        '
        Me.btnSelectIMG.Appearance.BackColor = DevExpress.LookAndFeel.DXSkinColors.FillColors.Success
        Me.btnSelectIMG.Appearance.Font = New System.Drawing.Font("Arial Narrow", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnSelectIMG.Appearance.Options.UseBackColor = True
        Me.btnSelectIMG.Appearance.Options.UseFont = True
        Me.btnSelectIMG.Location = New System.Drawing.Point(12, 12)
        Me.btnSelectIMG.Name = "btnSelectIMG"
        Me.btnSelectIMG.Size = New System.Drawing.Size(565, 32)
        Me.btnSelectIMG.StyleController = Me.LayoutControl1
        Me.btnSelectIMG.TabIndex = 5
        Me.btnSelectIMG.Text = "Select Picture 2D"
        '
        '_peIMG2D
        '
        Me._peIMG2D.Location = New System.Drawing.Point(12, 48)
        Me._peIMG2D.Name = "_peIMG2D"
        Me._peIMG2D.Properties.Appearance.Font = New System.Drawing.Font("Arial Narrow", 10.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._peIMG2D.Properties.Appearance.Options.UseFont = True
        Me._peIMG2D.Properties.NullText = "Picture 2D"
        Me._peIMG2D.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.[Auto]
        Me._peIMG2D.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch
        Me._peIMG2D.Size = New System.Drawing.Size(565, 514)
        Me._peIMG2D.StyleController = Me.LayoutControl1
        Me._peIMG2D.TabIndex = 4
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.LayoutControlItem2, Me.LayoutControlItem4, Me.LayoutControlItem3, Me.LayoutControlItem5, Me.EmptySpaceItem2, Me.lyt, Me.LayoutControlItem6})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(1159, 574)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me._peIMG2D
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 36)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(569, 518)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(579, 132)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(560, 422)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.btnSelectIMG
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(569, 36)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        'LayoutControlItem4
        '
        Me.LayoutControlItem4.AppearanceItemCaption.Font = New System.Drawing.Font("Arial Narrow", 11.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LayoutControlItem4.AppearanceItemCaption.Options.UseFont = True
        Me.LayoutControlItem4.Control = Me._01Novalidation
        Me.LayoutControlItem4.Location = New System.Drawing.Point(579, 32)
        Me.LayoutControlItem4.Name = "LayoutControlItem4"
        Me.LayoutControlItem4.Size = New System.Drawing.Size(560, 32)
        Me.LayoutControlItem4.Text = "No Validation"
        Me.LayoutControlItem4.TextSize = New System.Drawing.Size(115, 26)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me.SimpleButton1
        Me.LayoutControlItem3.Location = New System.Drawing.Point(579, 64)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(279, 36)
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem3.TextVisible = False
        '
        'LayoutControlItem5
        '
        Me.LayoutControlItem5.Control = Me.SimpleButton2
        Me.LayoutControlItem5.Location = New System.Drawing.Point(858, 64)
        Me.LayoutControlItem5.Name = "LayoutControlItem5"
        Me.LayoutControlItem5.Size = New System.Drawing.Size(281, 36)
        Me.LayoutControlItem5.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem5.TextVisible = False
        '
        'EmptySpaceItem2
        '
        Me.EmptySpaceItem2.AllowHotTrack = False
        Me.EmptySpaceItem2.Location = New System.Drawing.Point(569, 0)
        Me.EmptySpaceItem2.Name = "EmptySpaceItem2"
        Me.EmptySpaceItem2.Size = New System.Drawing.Size(10, 554)
        Me.EmptySpaceItem2.TextSize = New System.Drawing.Size(0, 0)
        '
        'lyt
        '
        Me.lyt.Control = Me.fciMultipel
        Me.lyt.Location = New System.Drawing.Point(579, 100)
        Me.lyt.Name = "lyt"
        Me.lyt.Size = New System.Drawing.Size(560, 32)
        Me.lyt.TextSize = New System.Drawing.Size(115, 19)
        '
        '_cKodeGambar
        '
        Me._cKodeGambar.Location = New System.Drawing.Point(709, 12)
        Me._cKodeGambar.Name = "_cKodeGambar"
        Me._cKodeGambar.Size = New System.Drawing.Size(438, 28)
        Me._cKodeGambar.StyleController = Me.LayoutControl1
        Me._cKodeGambar.TabIndex = 11
        '
        'LayoutControlItem6
        '
        Me.LayoutControlItem6.Control = Me._cKodeGambar
        Me.LayoutControlItem6.Location = New System.Drawing.Point(579, 0)
        Me.LayoutControlItem6.Name = "LayoutControlItem6"
        Me.LayoutControlItem6.Size = New System.Drawing.Size(560, 32)
        Me.LayoutControlItem6.Text = "Cari Gambar"
        Me.LayoutControlItem6.TextSize = New System.Drawing.Size(115, 19)
        '
        'ucMRPUpload2DJOBCARD
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "ucMRPUpload2DJOBCARD"
        Me.Size = New System.Drawing.Size(1159, 574)
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.fciMultipel.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._01Novalidation.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CtrlSLEGlobalMaster2View, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._peIMG2D.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.lyt, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._cKodeGambar.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents btnSelectIMG As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents _peIMG2D As DevExpress.XtraEditors.PictureEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents _01Novalidation As NCREPOSITORYlib.ctrlSLEGlobalMaster
    Friend WithEvents CtrlSLEGlobalMaster2View As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents LayoutControlItem4 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents SimpleButton2 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents LayoutControlItem5 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem2 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents fciMultipel As NCREPOSITORYlib.clsMltp22FCI
    Friend WithEvents lyt As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents _cKodeGambar As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem6 As DevExpress.XtraLayout.LayoutControlItem
End Class
