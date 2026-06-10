Imports DevExpress.XtraEditors
Imports DevExpress.XtraSplashScreen
Imports DevExpress.XtraWaitForm


Public Class xfAnimasiLoading

    Dim splsM As SplashScreenManager
    Dim objLoading As IOverlaySplashScreenHandle

    Dim objWaitForm As New clsWitform
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

    Private Sub Loading()
        Dim options As New OverlayWindowOptions(
                             startupDelay:=1000,
                             backColor:=Color.Red,
                             opacity:=0.5,
                             fadeIn:=False,
                             fadeOut:=False
                             )
    End Sub

    Private Sub _LoadingForm(ByVal prmTarget As Integer)

        With objWaitForm
            .prop_SetCaption = "Ini Loading"
            .prop_SetDescription = "ini Description"
            ._cm01bindingAwal()
        End With

        Dim timer As New Timer
        AddHandler timer.Tick, AddressOf Delay_view
        timer.Interval = 2000
        timer.Start()
        objWaitForm.Show()
        'Select Case prmTarget
        '    Case 0
        '        objWaitForm.Show()
        '    Case 1
        '        objWaitForm.Hide()
        'End Select

    End Sub

    Private Sub Delay_view(sender As Object, e As EventArgs)
        '  objWaitForm.Dispose()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        '#Teknik 01
        ' objLoading = SplashScreenManager.ShowOverlayForm(Me, customPainter:=New cslCXLoading())

        '#Teknik 02
        'SplashScreenManager1.ShowWaitForm()
        'SplashScreenManager1.SetWaitFormCaption("Please wait")
        'SplashScreenManager1.SetWaitFormDescription("Deskripsi")
        '..HIDE.
        'SplashScreenManager1.CloseWaitForm()


        'SplashScreenManager.ShowForm(GetType(WaitForm1))
        'BeginInvoke(New Action(Sub()
        '                           '...
        '                           SplashScreenManager1.ShowWaitForm()
        '                           SplashScreenManager1.SetWaitFormCaption("Please wait")
        '                           SplashScreenManager1.SetWaitFormDescription(description)
        '                           '...
        '                           SplashScreenManager1.CloseWaitForm()
        '                       End Sub))

        ' XtraMessageBox.Show("Do you want to quit the application?", "Confirmation", MessageBoxButtons.YesNo)

        _LoadingForm(0)

        'SplashScreenManager1.ShowForm(GetType(objWaitForm))
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click

        'objWaitForm.Hide()

        _LoadingForm(1)

    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Dim objLoading As New frmanimLOADINGFULL

        objLoading._cm01Sholoading()
        objLoading.ShowDialog()

    End Sub
End Class