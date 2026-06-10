<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xfMenu
    Inherits DevExpress.XtraBars.FluentDesignSystem.FluentDesignForm

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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xfMenu))
        Me._acMenu = New DevExpress.XtraBars.Navigation.AccordionControl()
        Me._acMenuPPIC = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.acPPIC_SPK = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.acPPIC_Absensi = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.acSK = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement4 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement5 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement6 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement7 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement8 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement1 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement3 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement2 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement9 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement10 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.acGeneral = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me.LayoutControlGroup2 = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.ToolbarFormManager1 = New DevExpress.XtraBars.ToolbarForm.ToolbarFormManager(Me.components)
        Me.barDockControlTop = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlBottom = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlLeft = New DevExpress.XtraBars.BarDockControl()
        Me.barDockControlRight = New DevExpress.XtraBars.BarDockControl()
        Me.FluentDesignFormContainer1 = New DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.pnlContent = New DevExpress.XtraEditors.PanelControl()
        CType(Me._acMenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ToolbarFormManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.pnlContent, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        '_acMenu
        '
        Me._acMenu.AnimationType = DevExpress.XtraBars.Navigation.AnimationType.Spline
        Me._acMenu.Appearance.AccordionControl.BackColor = System.Drawing.Color.WhiteSmoke
        Me._acMenu.Appearance.AccordionControl.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me._acMenu.Appearance.AccordionControl.Options.UseBackColor = True
        Me._acMenu.Appearance.AccordionControl.Options.UseForeColor = True
        Me._acMenu.Appearance.Group.Hovered.BackColor = System.Drawing.Color.Transparent
        Me._acMenu.Appearance.Group.Hovered.Options.UseBackColor = True
        Me._acMenu.Appearance.Group.Normal.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._acMenu.Appearance.Group.Normal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me._acMenu.Appearance.Group.Normal.Options.UseFont = True
        Me._acMenu.Appearance.Group.Normal.Options.UseForeColor = True
        Me._acMenu.Appearance.Item.Hovered.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(224, Byte), Integer), CType(CType(192, Byte), Integer))
        Me._acMenu.Appearance.Item.Hovered.Options.UseBackColor = True
        Me._acMenu.Appearance.Item.Normal.BackColor = System.Drawing.Color.WhiteSmoke
        Me._acMenu.Appearance.Item.Normal.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me._acMenu.Appearance.Item.Normal.Options.UseBackColor = True
        Me._acMenu.Appearance.Item.Normal.Options.UseForeColor = True
        Me._acMenu.ContextButtonsOptions.DisabledStateOpacity = 1.0!
        Me._acMenu.ContextButtonsOptions.NormalStateOpacity = 1.0!
        Me._acMenu.Dock = System.Windows.Forms.DockStyle.Left
        Me._acMenu.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me._acMenuPPIC, Me.acSK, Me.AccordionControlElement1, Me.acGeneral})
        Me._acMenu.Location = New System.Drawing.Point(0, 0)
        Me._acMenu.Name = "_acMenu"
        Me._acMenu.OptionsMinimizing.AllowMinimizeMode = DevExpress.Utils.DefaultBoolean.[True]
        Me._acMenu.ShowFilterControl = DevExpress.XtraBars.Navigation.ShowFilterControl.Always
        Me._acMenu.Size = New System.Drawing.Size(375, 554)
        Me._acMenu.TabIndex = 2
        Me._acMenu.Text = "s"
        Me._acMenu.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu
        '
        '_acMenuPPIC
        '
        Me._acMenuPPIC.Appearance.Normal.Font = New System.Drawing.Font("Arial", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._acMenuPPIC.Appearance.Normal.Options.UseFont = True
        Me._acMenuPPIC.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.acPPIC_SPK, Me.acPPIC_Absensi})
        Me._acMenuPPIC.ImageOptions.Image = CType(resources.GetObject("_acMenuPPIC.ImageOptions.Image"), System.Drawing.Image)
        Me._acMenuPPIC.Name = "_acMenuPPIC"
        Me._acMenuPPIC.Text = "PPIC"
        '
        'acPPIC_SPK
        '
        Me.acPPIC_SPK.ImageOptions.Image = CType(resources.GetObject("acPPIC_SPK.ImageOptions.Image"), System.Drawing.Image)
        Me.acPPIC_SPK.Name = "acPPIC_SPK"
        Me.acPPIC_SPK.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.acPPIC_SPK.Text = "SPK"
        '
        'acPPIC_Absensi
        '
        Me.acPPIC_Absensi.ImageOptions.Image = CType(resources.GetObject("acPPIC_Absensi.ImageOptions.Image"), System.Drawing.Image)
        Me.acPPIC_Absensi.Name = "acPPIC_Absensi"
        Me.acPPIC_Absensi.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.acPPIC_Absensi.Text = "Absensi"
        '
        'acSK
        '
        Me.acSK.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.AccordionControlElement4, Me.AccordionControlElement5, Me.AccordionControlElement6, Me.AccordionControlElement7, Me.AccordionControlElement8})
        Me.acSK.ImageOptions.Image = CType(resources.GetObject("acSK.ImageOptions.Image"), System.Drawing.Image)
        Me.acSK.Name = "acSK"
        Me.acSK.Text = "SK"
        '
        'AccordionControlElement4
        '
        Me.AccordionControlElement4.Name = "AccordionControlElement4"
        Me.AccordionControlElement4.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement4.Text = "Element4"
        '
        'AccordionControlElement5
        '
        Me.AccordionControlElement5.Name = "AccordionControlElement5"
        Me.AccordionControlElement5.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement5.Text = "Element5"
        '
        'AccordionControlElement6
        '
        Me.AccordionControlElement6.Name = "AccordionControlElement6"
        Me.AccordionControlElement6.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement6.Text = "Element6"
        '
        'AccordionControlElement7
        '
        Me.AccordionControlElement7.Name = "AccordionControlElement7"
        Me.AccordionControlElement7.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement7.Text = "Element7"
        '
        'AccordionControlElement8
        '
        Me.AccordionControlElement8.Name = "AccordionControlElement8"
        Me.AccordionControlElement8.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement8.Text = "Element8"
        '
        'AccordionControlElement1
        '
        Me.AccordionControlElement1.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me.AccordionControlElement3, Me.AccordionControlElement2, Me.AccordionControlElement9, Me.AccordionControlElement10})
        Me.AccordionControlElement1.Expanded = True
        Me.AccordionControlElement1.HeaderTemplate.AddRange(New DevExpress.XtraBars.Navigation.HeaderElementInfo() {New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Text), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.Image), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.HeaderControl), New DevExpress.XtraBars.Navigation.HeaderElementInfo(DevExpress.XtraBars.Navigation.HeaderElementType.ContextButtons)})
        Me.AccordionControlElement1.Name = "AccordionControlElement1"
        Me.AccordionControlElement1.Text = "Element1"
        '
        'AccordionControlElement3
        '
        Me.AccordionControlElement3.Name = "AccordionControlElement3"
        Me.AccordionControlElement3.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement3.Text = "Login"
        '
        'AccordionControlElement2
        '
        Me.AccordionControlElement2.Name = "AccordionControlElement2"
        Me.AccordionControlElement2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement2.Text = "Logout"
        '
        'AccordionControlElement9
        '
        Me.AccordionControlElement9.Name = "AccordionControlElement9"
        Me.AccordionControlElement9.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement9.Text = "Desig Master"
        '
        'AccordionControlElement10
        '
        Me.AccordionControlElement10.Name = "AccordionControlElement10"
        Me.AccordionControlElement10.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me.AccordionControlElement10.Text = "Gambar"
        '
        'acGeneral
        '
        Me.acGeneral.ImageOptions.Image = CType(resources.GetObject("acGeneral.ImageOptions.Image"), System.Drawing.Image)
        Me.acGeneral.Name = "acGeneral"
        Me.acGeneral.Text = "GENERAL"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.pnlContent)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(375, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.LayoutControlGroup2
        Me.LayoutControl1.Size = New System.Drawing.Size(702, 554)
        Me.LayoutControl1.TabIndex = 7
        '
        'LayoutControlGroup2
        '
        Me.LayoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.LayoutControlGroup2.GroupBordersVisible = False
        Me.LayoutControlGroup2.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1})
        Me.LayoutControlGroup2.Name = "LayoutControlGroup2"
        Me.LayoutControlGroup2.Size = New System.Drawing.Size(702, 554)
        Me.LayoutControlGroup2.TextVisible = False
        '
        'ToolbarFormManager1
        '
        Me.ToolbarFormManager1.DockControls.Add(Me.barDockControlTop)
        Me.ToolbarFormManager1.DockControls.Add(Me.barDockControlBottom)
        Me.ToolbarFormManager1.DockControls.Add(Me.barDockControlLeft)
        Me.ToolbarFormManager1.DockControls.Add(Me.barDockControlRight)
        Me.ToolbarFormManager1.Form = Me
        '
        'barDockControlTop
        '
        Me.barDockControlTop.CausesValidation = False
        Me.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top
        Me.barDockControlTop.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlTop.Manager = Me.ToolbarFormManager1
        Me.barDockControlTop.Size = New System.Drawing.Size(1077, 0)
        '
        'barDockControlBottom
        '
        Me.barDockControlBottom.CausesValidation = False
        Me.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.barDockControlBottom.Location = New System.Drawing.Point(0, 554)
        Me.barDockControlBottom.Manager = Me.ToolbarFormManager1
        Me.barDockControlBottom.Size = New System.Drawing.Size(1077, 0)
        '
        'barDockControlLeft
        '
        Me.barDockControlLeft.CausesValidation = False
        Me.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left
        Me.barDockControlLeft.Location = New System.Drawing.Point(0, 0)
        Me.barDockControlLeft.Manager = Me.ToolbarFormManager1
        Me.barDockControlLeft.Size = New System.Drawing.Size(0, 554)
        '
        'barDockControlRight
        '
        Me.barDockControlRight.CausesValidation = False
        Me.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right
        Me.barDockControlRight.Location = New System.Drawing.Point(1077, 0)
        Me.barDockControlRight.Manager = Me.ToolbarFormManager1
        Me.barDockControlRight.Size = New System.Drawing.Size(0, 554)
        '
        'FluentDesignFormContainer1
        '
        Me.FluentDesignFormContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.FluentDesignFormContainer1.Location = New System.Drawing.Point(375, 0)
        Me.FluentDesignFormContainer1.Name = "FluentDesignFormContainer1"
        Me.FluentDesignFormContainer1.Size = New System.Drawing.Size(702, 554)
        Me.FluentDesignFormContainer1.TabIndex = 8
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me.pnlContent
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(682, 534)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem1.TextVisible = False
        '
        'pnlContent
        '
        Me.pnlContent.Appearance.BackColor = System.Drawing.Color.WhiteSmoke
        Me.pnlContent.Appearance.Options.UseBackColor = True
        Me.pnlContent.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.pnlContent.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.Simple
        Me.pnlContent.Location = New System.Drawing.Point(12, 12)
        Me.pnlContent.Name = "pnlContent"
        Me.pnlContent.Size = New System.Drawing.Size(678, 530)
        Me.pnlContent.TabIndex = 6
        '
        'xfMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1077, 554)
        Me.ControlContainer = Me.FluentDesignFormContainer1
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.FluentDesignFormContainer1)
        Me.Controls.Add(Me._acMenu)
        Me.Controls.Add(Me.barDockControlLeft)
        Me.Controls.Add(Me.barDockControlBottom)
        Me.Controls.Add(Me.barDockControlTop)
        Me.Controls.Add(Me.barDockControlRight)
        Me.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow
        Me.LookAndFeel.UseWindowsXPTheme = True
        Me.Name = "xfMenu"
        Me.NavigationControl = Me._acMenu
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me._acMenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.LayoutControlGroup2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ToolbarFormManager1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.pnlContent, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents _acMenu As DevExpress.XtraBars.Navigation.AccordionControl
    Friend WithEvents _acMenuPPIC As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement2 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement3 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents acPPIC_SPK As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents acPPIC_Absensi As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement1 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents acSK As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement4 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement5 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement6 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement7 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement8 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents acGeneral As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement9 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents AccordionControlElement10 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents LayoutControlGroup2 As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents ToolbarFormManager1 As DevExpress.XtraBars.ToolbarForm.ToolbarFormManager
    Friend WithEvents barDockControlTop As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlBottom As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlLeft As DevExpress.XtraBars.BarDockControl
    Friend WithEvents barDockControlRight As DevExpress.XtraBars.BarDockControl
    Friend WithEvents FluentDesignFormContainer1 As DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer
    Friend WithEvents pnlContent As DevExpress.XtraEditors.PanelControl
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
End Class
