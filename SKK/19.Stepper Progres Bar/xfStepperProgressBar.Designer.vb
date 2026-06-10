<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class xfStepperProgressBar
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(xfStepperProgressBar))
        Me.StepProgressBar1 = New DevExpress.XtraEditors.StepProgressBar()
        Me.StepProgressBarItem1 = New DevExpress.XtraEditors.StepProgressBarItem()
        Me.StepProgressBarItem2 = New DevExpress.XtraEditors.StepProgressBarItem()
        Me.StepProgressBarItem3 = New DevExpress.XtraEditors.StepProgressBarItem()
        Me.StepProgressBarItem4 = New DevExpress.XtraEditors.StepProgressBarItem()
        Me.stpTracking = New DevExpress.XtraEditors.StepProgressBar()
        Me.SimpleButton1 = New DevExpress.XtraEditors.SimpleButton()
        Me._01SKU = New DevExpress.XtraEditors.TextEdit()
        CType(Me.StepProgressBar1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.stpTracking, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me._01SKU.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'StepProgressBar1
        '
        Me.StepProgressBar1.ConnectorLineThickness = 5
        Me.StepProgressBar1.ItemOptions.Indicator.ActiveStateDrawMode = DevExpress.XtraEditors.IndicatorDrawMode.Outline
        Me.StepProgressBar1.Items.Add(Me.StepProgressBarItem1)
        Me.StepProgressBar1.Items.Add(Me.StepProgressBarItem2)
        Me.StepProgressBar1.Items.Add(Me.StepProgressBarItem3)
        Me.StepProgressBar1.Items.Add(Me.StepProgressBarItem4)
        Me.StepProgressBar1.Location = New System.Drawing.Point(820, 260)
        Me.StepProgressBar1.Name = "StepProgressBar1"
        Me.StepProgressBar1.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.StepProgressBar1.SelectedItemIndex = 1
        Me.StepProgressBar1.Size = New System.Drawing.Size(356, 392)
        Me.StepProgressBar1.TabIndex = 0
        '
        'StepProgressBarItem1
        '
        Me.StepProgressBarItem1.Appearance.ActiveIndicatorColor = System.Drawing.Color.Lime
        Me.StepProgressBarItem1.ContentBlock1.ActiveStateImageOptions.SvgImage = CType(resources.GetObject("StepProgressBarItem1.ContentBlock1.ActiveStateImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.StepProgressBarItem1.ContentBlock1.ActiveStateImageOptions.SvgImageSize = New System.Drawing.Size(25, 25)
        Me.StepProgressBarItem1.ContentBlock1.Appearance.Caption.Font = New System.Drawing.Font("Tahoma", 9.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StepProgressBarItem1.ContentBlock1.Appearance.Caption.ForeColor = System.Drawing.Color.Red
        Me.StepProgressBarItem1.ContentBlock1.Appearance.Caption.Options.UseFont = True
        Me.StepProgressBarItem1.ContentBlock1.Appearance.Caption.Options.UseForeColor = True
        Me.StepProgressBarItem1.ContentBlock1.Appearance.CaptionActive.Font = New System.Drawing.Font("Tahoma", 8.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.StepProgressBarItem1.ContentBlock1.Appearance.CaptionActive.Options.UseFont = True
        Me.StepProgressBarItem1.ContentBlock1.Caption = "PPIC"
        Me.StepProgressBarItem1.ContentBlock2.Caption = "20-06-2021"
        Me.StepProgressBarItem1.ContentBlock2.Description = "Berat awal 20, Lot 15"
        Me.StepProgressBarItem1.Name = "StepProgressBarItem1"
        Me.StepProgressBarItem1.Options.ConnectorOffset = 20
        Me.StepProgressBarItem1.Options.Indicator.ActiveStateDrawMode = DevExpress.XtraEditors.IndicatorDrawMode.Outline
        Me.StepProgressBarItem1.Options.Indicator.ActiveStateImageOptions.SvgImage = CType(resources.GetObject("StepProgressBarItem1.Options.Indicator.ActiveStateImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.StepProgressBarItem1.Options.Indicator.InactiveStateImageOptions.SvgImage = CType(resources.GetObject("StepProgressBarItem1.Options.Indicator.InactiveStateImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.StepProgressBarItem1.State = DevExpress.XtraEditors.StepProgressBarItemState.Active
        '
        'StepProgressBarItem2
        '
        Me.StepProgressBarItem2.Appearance.ActiveIndicatorColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.StepProgressBarItem2.ContentBlock1.Appearance.Caption.Options.UseTextOptions = True
        Me.StepProgressBarItem2.ContentBlock1.Appearance.Caption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
        Me.StepProgressBarItem2.ContentBlock1.Caption = "3D Printing"
        Me.StepProgressBarItem2.ContentBlock2.Caption = "20-06-2021"
        Me.StepProgressBarItem2.ContentBlock2.Description = "Berat 20, lot 15"
        Me.StepProgressBarItem2.Name = "StepProgressBarItem2"
        Me.StepProgressBarItem2.Options.Indicator.ActiveStateDrawMode = DevExpress.XtraEditors.IndicatorDrawMode.Outline
        Me.StepProgressBarItem2.Options.Indicator.ActiveStateImageOptions.SvgImage = CType(resources.GetObject("StepProgressBarItem2.Options.Indicator.ActiveStateImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.StepProgressBarItem2.Options.Indicator.InactiveStateImageOptions.SvgImage = CType(resources.GetObject("StepProgressBarItem2.Options.Indicator.InactiveStateImageOptions.SvgImage"), DevExpress.Utils.Svg.SvgImage)
        Me.StepProgressBarItem2.State = DevExpress.XtraEditors.StepProgressBarItemState.Active
        '
        'StepProgressBarItem3
        '
        Me.StepProgressBarItem3.Appearance.InactiveIndicatorColor = System.Drawing.Color.Gray
        Me.StepProgressBarItem3.ContentBlock2.Caption = "Item3"
        Me.StepProgressBarItem3.Name = "StepProgressBarItem3"
        '
        'StepProgressBarItem4
        '
        Me.StepProgressBarItem4.ContentBlock2.Caption = "Item4"
        Me.StepProgressBarItem4.Name = "StepProgressBarItem4"
        '
        'stpTracking
        '
        Me.stpTracking.ContentAlignment = System.Drawing.ContentAlignment.MiddleCenter
        Me.stpTracking.Location = New System.Drawing.Point(26, 12)
        Me.stpTracking.Name = "stpTracking"
        Me.stpTracking.Orientation = System.Windows.Forms.Orientation.Vertical
        Me.stpTracking.ScrollMode = DevExpress.XtraEditors.Controls.StepProgressBar.ScrollMode.Fluent
        Me.stpTracking.Size = New System.Drawing.Size(483, 640)
        Me.stpTracking.TabIndex = 1
        '
        'SimpleButton1
        '
        Me.SimpleButton1.Location = New System.Drawing.Point(531, 63)
        Me.SimpleButton1.Name = "SimpleButton1"
        Me.SimpleButton1.Size = New System.Drawing.Size(112, 34)
        Me.SimpleButton1.TabIndex = 2
        Me.SimpleButton1.Text = "Cek"
        '
        '_01SKU
        '
        Me._01SKU.Location = New System.Drawing.Point(531, 31)
        Me._01SKU.Name = "_01SKU"
        Me._01SKU.Size = New System.Drawing.Size(150, 26)
        Me._01SKU.TabIndex = 3
        '
        'xfStepperProgressBar
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1173, 664)
        Me.Controls.Add(Me._01SKU)
        Me.Controls.Add(Me.SimpleButton1)
        Me.Controls.Add(Me.stpTracking)
        Me.Controls.Add(Me.StepProgressBar1)
        Me.Name = "xfStepperProgressBar"
        Me.Text = "xfStepperProgressBar"
        CType(Me.StepProgressBar1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.stpTracking, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me._01SKU.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents StepProgressBar1 As DevExpress.XtraEditors.StepProgressBar
    Friend WithEvents StepProgressBarItem1 As DevExpress.XtraEditors.StepProgressBarItem
    Friend WithEvents StepProgressBarItem2 As DevExpress.XtraEditors.StepProgressBarItem
    Friend WithEvents StepProgressBarItem3 As DevExpress.XtraEditors.StepProgressBarItem
    Friend WithEvents StepProgressBarItem4 As DevExpress.XtraEditors.StepProgressBarItem
    Friend WithEvents stpTracking As DevExpress.XtraEditors.StepProgressBar
    Friend WithEvents SimpleButton1 As DevExpress.XtraEditors.SimpleButton
    Friend WithEvents _01SKU As DevExpress.XtraEditors.TextEdit
End Class
