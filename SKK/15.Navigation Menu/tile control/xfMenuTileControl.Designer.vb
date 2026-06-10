<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class xfMenuTileControl
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
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
        Me.components = New System.ComponentModel.Container()
        Dim TileItemElement7 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement8 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement1 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement2 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemFrame1 As DevExpress.XtraEditors.TileItemFrame = New DevExpress.XtraEditors.TileItemFrame()
        Dim TileItemElement3 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement4 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemFrame2 As DevExpress.XtraEditors.TileItemFrame = New DevExpress.XtraEditors.TileItemFrame()
        Dim TileItemElement5 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Dim TileItemElement6 As DevExpress.XtraEditors.TileItemElement = New DevExpress.XtraEditors.TileItemElement()
        Me.TileControl1 = New DevExpress.XtraEditors.TileControl()
        Me.TileItem2 = New DevExpress.XtraEditors.TileItem()
        Me.TileItem5 = New DevExpress.XtraEditors.TileItem()
        Me.BehaviorManager1 = New DevExpress.Utils.Behaviors.BehaviorManager(Me.components)
        Me.TileGroup5 = New DevExpress.XtraEditors.TileGroup()
        Me.TileItem1 = New DevExpress.XtraEditors.TileItem()
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TileControl1
        '
        Me.TileControl1.BackColor = System.Drawing.Color.Teal
        Me.TileControl1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TileControl1.Groups.Add(Me.TileGroup5)
        Me.TileControl1.Location = New System.Drawing.Point(0, 0)
        Me.TileControl1.MaxId = 26
        Me.TileControl1.Name = "TileControl1"
        Me.TileControl1.Size = New System.Drawing.Size(1054, 593)
        Me.TileControl1.TabIndex = 0
        Me.TileControl1.Text = "TileControl1"
        '
        'TileItem2
        '
        TileItemElement7.Text = "TileItem2"
        Me.TileItem2.Elements.Add(TileItemElement7)
        Me.TileItem2.Id = 4
        Me.TileItem2.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
        Me.TileItem2.Name = "TileItem2"
        '
        'TileItem5
        '
        TileItemElement8.Text = "TileItem5"
        Me.TileItem5.Elements.Add(TileItemElement8)
        Me.TileItem5.Id = 9
        Me.TileItem5.ItemSize = DevExpress.XtraEditors.TileItemSize.Medium
        Me.TileItem5.Name = "TileItem5"
        '
        'TileGroup5
        '
        Me.TileGroup5.Items.Add(Me.TileItem1)
        Me.TileGroup5.Name = "TileGroup5"
        '
        'TileItem1
        '
        Me.TileItem1.CurrentFrameIndex = 1
        TileItemElement1.Appearance.Normal.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement1.Appearance.Normal.Options.UseFont = True
        TileItemElement1.Text = "PRODUCTION DASHBOARD"
        TileItemElement2.Text = "In Out, WIP"
        TileItemElement2.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        Me.TileItem1.Elements.Add(TileItemElement1)
        Me.TileItem1.Elements.Add(TileItemElement2)
        TileItemElement3.Text = "PRODUCTION DASHBOARD"
        TileItemElement4.Text = "Proses prroduksi "
        TileItemElement4.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        TileItemFrame1.Elements.Add(TileItemElement3)
        TileItemFrame1.Elements.Add(TileItemElement4)
        TileItemFrame1.UseText = False
        TileItemElement5.Appearance.Normal.Font = New System.Drawing.Font("Arial Rounded MT Bold", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        TileItemElement5.Appearance.Normal.Options.UseFont = True
        TileItemElement5.Text = "PRODUCTION DASHBOARD"
        TileItemElement6.Text = "In Out, WIP"
        TileItemElement6.TextAlignment = DevExpress.XtraEditors.TileItemContentAlignment.BottomCenter
        TileItemFrame2.Elements.Add(TileItemElement5)
        TileItemFrame2.Elements.Add(TileItemElement6)
        Me.TileItem1.Frames.Add(TileItemFrame1)
        Me.TileItem1.Frames.Add(TileItemFrame2)
        Me.TileItem1.Id = 25
        Me.TileItem1.ItemSize = DevExpress.XtraEditors.TileItemSize.Wide
        Me.TileItem1.Name = "TileItem1"
        '
        'xfMenuTileControl
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1054, 593)
        Me.Controls.Add(Me.TileControl1)
        Me.Name = "xfMenuTileControl"
        Me.Text = "xfMenuTileControl"
        CType(Me.BehaviorManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TileControl1 As DevExpress.XtraEditors.TileControl
    Friend WithEvents TileGroup1 As DevExpress.XtraEditors.TileGroup
    Friend WithEvents TileGroup3 As DevExpress.XtraEditors.TileGroup
    Friend WithEvents TileItem2 As DevExpress.XtraEditors.TileItem
    Friend WithEvents TileItem5 As DevExpress.XtraEditors.TileItem
    Friend WithEvents TileGroup2 As DevExpress.XtraEditors.TileGroup
    Friend WithEvents BehaviorManager1 As DevExpress.Utils.Behaviors.BehaviorManager
    Friend WithEvents TileGroup5 As DevExpress.XtraEditors.TileGroup
    Friend WithEvents TileItem1 As DevExpress.XtraEditors.TileItem
End Class
