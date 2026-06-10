Public Class xfConditionalProps

    Private _cxLoading As xfLoadingFULL
    Dim AutoHide As New Timer

    Dim isUpdate As Boolean = False
    Dim setWaktu As New Timer

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _cxLoading = New xfLoadingFULL
    End Sub

    Private Sub xfConditionalProps_Load(sender As Object, e As EventArgs) Handles Me.Load
        _cmInitControl()
    End Sub

    Sub _cmInitControl()
        If Not isUpdate Then
            pnlLoading.Visible = False
            lblStatus.Text = "Init Awal ...."
        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        'isUpdate = True
        'setWaktu.Interval = 3000
        'setWaktu.Start()
        'AddHandler setWaktu.Tick, AddressOf delayview

        'If isUpdate Then
        '    lblStatus.Text = "Loading ..."
        '    pnlLoading.Visible = True
        '    isUpdate = False
        'End If

        _Showloding()

    End Sub

    Private Sub delayview(sender As Object, e As EventArgs)

        setWaktu.Stop()
        isUpdate = False
        _cmInitControl()
    End Sub

    Private Sub _Showloding()

        With _cxLoading
            .Caption = "Ini Caption"
            .Desc = "ini Desc..."
            ._setLoding()
        End With

        AddHandler AutoHide.Tick, AddressOf SetAutoHide
        AutoHide.Interval = 3000
        AutoHide.Start()
        _cxLoading.ShowDialog()

    End Sub

    Private Sub SetAutoHide(sender As Object, e As EventArgs)
        _cxLoading.Hide()
        AutoHide.Stop()
    End Sub
End Class