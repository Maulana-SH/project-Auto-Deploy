<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xfrm01belajar
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
        Me.AccordionControl1 = New DevExpress.XtraBars.Navigation.AccordionControl()
        Me._01MenuSatu = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.AccordionControlElement2 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me._02Menu0201 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me._02Menu0202 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me._02Menu0203 = New DevExpress.XtraBars.Navigation.AccordionControlElement()
        Me.LayoutControl1 = New DevExpress.XtraLayout.LayoutControl()
        Me._03cHasil = New System.Windows.Forms.RichTextBox()
        Me._02dTgl = New DevExpress.XtraEditors.DateEdit()
        Me._01cNama = New DevExpress.XtraEditors.TextEdit()
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.LayoutControlItem3 = New DevExpress.XtraLayout.LayoutControlItem()
        CType(Me.AccordionControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me._02dTgl.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._02dTgl.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._01cNama.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AccordionControl1
        '
        Me.AccordionControl1.Dock = System.Windows.Forms.DockStyle.Left
        Me.AccordionControl1.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me._01MenuSatu, Me.AccordionControlElement2})
        Me.AccordionControl1.Location = New System.Drawing.Point(0, 0)
        Me.AccordionControl1.Name = "AccordionControl1"
        Me.AccordionControl1.Size = New System.Drawing.Size(287, 644)
        Me.AccordionControl1.TabIndex = 0
        '
        '_01MenuSatu
        '
        Me._01MenuSatu.Name = "_01MenuSatu"
        Me._01MenuSatu.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me._01MenuSatu.Text = "Menu 01"
        '
        'AccordionControlElement2
        '
        Me.AccordionControlElement2.Elements.AddRange(New DevExpress.XtraBars.Navigation.AccordionControlElement() {Me._02Menu0201, Me._02Menu0202, Me._02Menu0203})
        Me.AccordionControlElement2.Name = "AccordionControlElement2"
        Me.AccordionControlElement2.Text = "menu 02"
        '
        '_02Menu0201
        '
        Me._02Menu0201.Name = "_02Menu0201"
        Me._02Menu0201.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me._02Menu0201.Text = "sub 02.01"
        '
        '_02Menu0202
        '
        Me._02Menu0202.Name = "_02Menu0202"
        Me._02Menu0202.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me._02Menu0202.Text = "sub 02.02"
        '
        '_02Menu0203
        '
        Me._02Menu0203.Name = "_02Menu0203"
        Me._02Menu0203.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item
        Me._02Menu0203.Text = "sub 02.03"
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me._03cHasil)
        Me.LayoutControl1.Controls.Add(Me._02dTgl)
        Me.LayoutControl1.Controls.Add(Me._01cNama)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(287, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(943, 644)
        Me.LayoutControl1.TabIndex = 1
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        '_03cHasil
        '
        Me._03cHasil.Location = New System.Drawing.Point(12, 228)
        Me._03cHasil.Name = "_03cHasil"
        Me._03cHasil.Size = New System.Drawing.Size(919, 404)
        Me._03cHasil.TabIndex = 6
        Me._03cHasil.Text = ""
        '
        '_02dTgl
        '
        Me._02dTgl.EditValue = Nothing
        Me._02dTgl.Location = New System.Drawing.Point(117, 42)
        Me._02dTgl.Name = "_02dTgl"
        Me._02dTgl.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._02dTgl.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me._02dTgl.Size = New System.Drawing.Size(814, 26)
        Me._02dTgl.StyleController = Me.LayoutControl1
        Me._02dTgl.TabIndex = 5
        '
        '_01cNama
        '
        Me._01cNama.Location = New System.Drawing.Point(117, 12)
        Me._01cNama.Name = "_01cNama"
        Me._01cNama.Size = New System.Drawing.Size(814, 26)
        Me._01cNama.StyleController = Me.LayoutControl1
        Me._01cNama.TabIndex = 4
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.LayoutControlItem2, Me.LayoutControlItem3})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(943, 644)
        Me.Root.TextVisible = False
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me._01cNama
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(923, 30)
        Me.LayoutControlItem1.Text = "Nama"
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(93, 19)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 60)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(923, 134)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me._02dTgl
        Me.LayoutControlItem2.Location = New System.Drawing.Point(0, 30)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(923, 30)
        Me.LayoutControlItem2.Text = "Tgl Sekarang"
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(93, 19)
        '
        'LayoutControlItem3
        '
        Me.LayoutControlItem3.Control = Me._03cHasil
        Me.LayoutControlItem3.Location = New System.Drawing.Point(0, 194)
        Me.LayoutControlItem3.Name = "LayoutControlItem3"
        Me.LayoutControlItem3.Size = New System.Drawing.Size(923, 430)
        Me.LayoutControlItem3.Text = "Hasil"
        Me.LayoutControlItem3.TextLocation = DevExpress.Utils.Locations.Top
        Me.LayoutControlItem3.TextSize = New System.Drawing.Size(93, 19)
        '
        'xfrm01belajar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1230, 644)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Controls.Add(Me.AccordionControl1)
        Me.Name = "xfrm01belajar"
        Me.Text = "xfrm01belajar"
        CType(Me.AccordionControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me._02dTgl.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._02dTgl.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._01cNama.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AccordionControl1 As DevExpress.XtraBars.Navigation.AccordionControl
    Friend WithEvents AccordionControlElement2 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents _02Menu0201 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents _02Menu0202 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents _02Menu0203 As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents _01MenuSatu As DevExpress.XtraBars.Navigation.AccordionControlElement
    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents _02dTgl As DevExpress.XtraEditors.DateEdit
    Friend WithEvents _01cNama As DevExpress.XtraEditors.TextEdit
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents _03cHasil As RichTextBox
    Friend WithEvents LayoutControlItem3 As DevExpress.XtraLayout.LayoutControlItem
End Class
