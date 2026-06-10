Public Class frmLoopingcek

    Private Sub _cekPerent(ByVal prmString As String)
        Dim PDThASIL As New DataTable

        Using objGet As NCMODELlib.clsMRP_iface = New NCMODELlib.clsMRP_impl With {.prop_KeyInt01 = 2,
                                                                   .prop_KeyString01 = prmString,
                                                                   .prop_KeyInt02 = 5}
            PDThASIL = objGet.sele21FG01ReprintGP()
        End Using


    End Sub


    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

    End Sub
End Class