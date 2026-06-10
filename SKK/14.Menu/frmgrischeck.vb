Public Class frmgrischeck

    Private Property pdtDATATABLE_FCI As New DataTable
    Private Sub frmgrischeck_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _cm01initGrid()
    End Sub

    Sub _cm01initGrid()

        Using objGetdata As NCMODELlib.clsMRP_iface = New NCMODELlib.clsMRP_impl With {.prop_KeyString01 = ""}
            pdtDATATABLE_FCI = objGetdata.Sele22MCFINDINGCOMPONENT
        End Using


        col03KodePRO.FieldName = "k01cKodeItemFindingComponent_v50"
        col03KodePRO.Caption = "KOde"
        col04NamaPRO.FieldName = "f01cItemFindingComponentDesc_v50"
        col04NamaPRO.Caption = "nAMA"

        GridControl1.DataSource = Nothing
        GridControl1.DataSource = pdtDATATABLE_FCI


    End Sub



End Class