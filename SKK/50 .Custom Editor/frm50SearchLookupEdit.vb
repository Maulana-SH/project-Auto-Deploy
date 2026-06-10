Imports NCMODELlib

Public Class frm50SearchLookupEdit

    Dim pdtMAster51 As DataTable
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        pdtMAster51 = New DataTable
    End Sub

    Private Sub frm50SearchLookupEdit_Load(sender As Object, e As EventArgs) Handles Me.Load
        cm01InitControl()
    End Sub


    Private Sub cm01InitControl()

        pdtMAster51.Clear()

        Using objGet As NCMODELlib.clsMRP_iface = New NCMODELlib.clsMRP_impl
            pdtMAster51 = objGet.Get51MasterAllNewSKK
        End Using

        With _01Master
            ._01prop_dtMasterSKK = pdtMAster51
            ._02prop_FilterKodeMasterSKK = "BRAND"
            ._03BindingAwalDataSurce()
            ._04FilterDataViewMasterSKK()
        End With

        With _02Sle
            .Properties.DisplayMember = "k01cKodeFieldValueMaster_v50"
            .Properties.ValueMember = "f01cIsiFieldValueMaster_v50"
            .Properties.DataSource = pdtMAster51
        End With

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        pdtMAster51.Clear()

        Using objGet As NCMODELlib.clsMRP_iface = New NCMODELlib.clsMRP_impl
            pdtMAster51 = objGet.Get51MasterAllNewSKK
        End Using

        '_01Master._01prop_dtMasterSKK = Nothing
        '_01Master.Properties.DataSource = pdtMAster51
        '_01Master.Properties.View.RefreshData()

        _01Master._01prop_dtMasterSKK = pdtMAster51
        _01Master.cmRefreshData()


        _02Sle.Properties.DataSource = pdtMAster51
        ' _02Sle.Refresh()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click

        Dim pdtFCI As New DataTable
        pdtFCI.Clear()

        Using objFindingComponent As clsMRP_iface = New clsMRP_impl With {.prop_KeyString01 = ""}
            pdtFCI = objFindingComponent.Sele22MCFINDINGCOMPONENT()
        End Using

        With _03MultipelFCI
            ._01prop_dt22FindingComponent = pdtFCI
            ._pb01BindingAwalDataSurce()
        End With

    End Sub
End Class