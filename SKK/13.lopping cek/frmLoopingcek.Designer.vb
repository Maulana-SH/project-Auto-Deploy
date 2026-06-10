<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoopingcek
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
        Me.Root = New DevExpress.XtraLayout.LayoutControlGroup()
        Me._04SKUgagal = New DevExpress.XtraEditors.TextEdit()
        Me.LayoutControlItem1 = New DevExpress.XtraLayout.LayoutControlItem()
        Me.EmptySpaceItem1 = New DevExpress.XtraLayout.EmptySpaceItem()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me.LayoutControlItem2 = New DevExpress.XtraLayout.LayoutControlItem()
        Me._01lblCounter = New DevExpress.XtraLayout.SimpleLabelItem()
        Me._02lblHasil = New DevExpress.XtraLayout.SimpleLabelItem()
        Me._03lblAnak = New DevExpress.XtraLayout.SimpleLabelItem()
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.LayoutControl1.SuspendLayout()
        CType(Me.Root, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._04SKUgagal.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._01lblCounter, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._02lblHasil, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._03lblAnak, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LayoutControl1
        '
        Me.LayoutControl1.Controls.Add(Me.SimpleButton1)
        Me.LayoutControl1.Controls.Add(Me._04SKUgagal)
        Me.LayoutControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.LayoutControl1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControl1.Name = "LayoutControl1"
        Me.LayoutControl1.Root = Me.Root
        Me.LayoutControl1.Size = New System.Drawing.Size(893, 476)
        Me.LayoutControl1.TabIndex = 0
        Me.LayoutControl1.Text = "LayoutControl1"
        '
        'Root
        '
        Me.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.[True]
        Me.Root.GroupBordersVisible = False
        Me.Root.Items.AddRange(New DevExpress.XtraLayout.BaseLayoutItem() {Me.LayoutControlItem1, Me.EmptySpaceItem1, Me.LayoutControlItem2, Me._01lblCounter, Me._02lblHasil, Me._03lblAnak})
        Me.Root.Name = "Root"
        Me.Root.Size = New System.Drawing.Size(893, 476)
        Me.Root.TextVisible = False
        '
        '_04SKUgagal
        '
        Me._04SKUgagal.Location = New System.Drawing.Point(219, 12)
        Me._04SKUgagal.Name = "_04SKUgagal"
        Me._04SKUgagal.Size = New System.Drawing.Size(225, 26)
        Me._04SKUgagal.StyleController = Me.LayoutControl1
        Me._04SKUgagal.TabIndex = 4
        '
        'LayoutControlItem1
        '
        Me.LayoutControlItem1.Control = Me._04SKUgagal
        Me.LayoutControlItem1.Location = New System.Drawing.Point(0, 0)
        Me.LayoutControlItem1.Name = "LayoutControlItem1"
        Me.LayoutControlItem1.Size = New System.Drawing.Size(436, 36)
        Me.LayoutControlItem1.TextSize = New System.Drawing.Size(195, 19)
        '
        'EmptySpaceItem1
        '
        Me.EmptySpaceItem1.AllowHotTrack = False
        Me.EmptySpaceItem1.Location = New System.Drawing.Point(0, 153)
        Me.EmptySpaceItem1.Name = "EmptySpaceItem1"
        Me.EmptySpaceItem1.Size = New System.Drawing.Size(873, 303)
        Me.EmptySpaceItem1.TextSize = New System.Drawing.Size(0, 0)
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(448, 12)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(433, 32)
        Me.SimpleButton1.StyleController = Me.LayoutControl1
        Me.SimpleButton1.TabIndex = 5
        Me.SimpleButton1.Text = "SimpleButton1"
        '
        'LayoutControlItem2
        '
        Me.LayoutControlItem2.Control = Me.SimpleButton1
        Me.LayoutControlItem2.Location = New System.Drawing.Point(436, 0)
        Me.LayoutControlItem2.Name = "LayoutControlItem2"
        Me.LayoutControlItem2.Size = New System.Drawing.Size(437, 36)
        Me.LayoutControlItem2.TextSize = New System.Drawing.Size(0, 0)
        Me.LayoutControlItem2.TextVisible = False
        '
        '_01lblCounter
        '
        Me._01lblCounter.AllowHotTrack = False
        Me._01lblCounter.AppearanceItemCaption.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._01lblCounter.AppearanceItemCaption.Options.UseFont = True
        Me._01lblCounter.Location = New System.Drawing.Point(0, 36)
        Me._01lblCounter.Name = "_01lblCounter"
        Me._01lblCounter.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me._01lblCounter.Size = New System.Drawing.Size(873, 39)
        Me._01lblCounter.TextSize = New System.Drawing.Size(195, 29)
        '
        '_02lblHasil
        '
        Me._02lblHasil.AllowHotTrack = False
        Me._02lblHasil.AppearanceItemCaption.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._02lblHasil.AppearanceItemCaption.Options.UseFont = True
        Me._02lblHasil.Location = New System.Drawing.Point(0, 75)
        Me._02lblHasil.Name = "_02lblHasil"
        Me._02lblHasil.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me._02lblHasil.Size = New System.Drawing.Size(873, 39)
        Me._02lblHasil.TextSize = New System.Drawing.Size(195, 29)
        '
        '_03lblAnak
        '
        Me._03lblAnak.AllowHotTrack = False
        Me._03lblAnak.AppearanceItemCaption.Font = New System.Drawing.Font("Calibri", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me._03lblAnak.AppearanceItemCaption.Options.UseFont = True
        Me._03lblAnak.Location = New System.Drawing.Point(0, 114)
        Me._03lblAnak.Name = "_03lblAnak"
        Me._03lblAnak.Padding = New DevExpress.XtraLayout.Utils.Padding(5, 5, 5, 5)
        Me._03lblAnak.Size = New System.Drawing.Size(873, 39)
        Me._03lblAnak.TextSize = New System.Drawing.Size(195, 29)
        '
        'frmLoopingcek
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(893, 476)
        Me.Controls.Add(Me.LayoutControl1)
        Me.Name = "frmLoopingcek"
        Me.Text = "frmLoopingcek"
        CType(Me.LayoutControl1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.LayoutControl1.ResumeLayout(False)
        CType(Me.Root, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._04SKUgagal.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmptySpaceItem1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LayoutControlItem2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._01lblCounter, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._02lblHasil, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._03lblAnak, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents LayoutControl1 As DevExpress.XtraLayout.LayoutControl
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents _04SKUgagal As DevExpress.XtraEditors.TextEdit
    Friend WithEvents Root As DevExpress.XtraLayout.LayoutControlGroup
    Friend WithEvents LayoutControlItem1 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents EmptySpaceItem1 As DevExpress.XtraLayout.EmptySpaceItem
    Friend WithEvents LayoutControlItem2 As DevExpress.XtraLayout.LayoutControlItem
    Friend WithEvents _01lblCounter As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents _02lblHasil As DevExpress.XtraLayout.SimpleLabelItem
    Friend WithEvents _03lblAnak As DevExpress.XtraLayout.SimpleLabelItem
End Class
