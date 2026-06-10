Imports NCMODELlib

Public Class xfGetDtFieldname


#Region " From Event"
    Private Sub xfGetDtFieldname_Load(sender As Object, e As EventArgs) Handles Me.Load

    End Sub


#End Region

#Region " Custome Event "

    Private Sub cm01GetData()


        'Dim pdtHAsil As New DataTable
        'Using objGetDataStones As clsMRP_iface = New clsMRP1_impl With {.prop_KeyString01 = ""}
        '    pdtHAsil = objGetDataStones.Sele23MCSTONES
        'End Using

        Dim pdtHAsil As New DataTable
        Using objDataFG2BridgingPerDoc As NCMODELlib.clsNEWCENTRAL_iface = New NCMODELlib.clsNEWCENTRAL_impl With {.prop_cNoDokumen = "TI21168"}
            pdtHAsil = objDataFG2BridgingPerDoc.GetTP9HV02TransferFG2BridgingPerDoc()
        End Using

        If pdtHAsil.Rows.Count > 0 Then

            cm02GetFIeldName(pdtHAsil)

        Else
            MsgBox("DO Tidak Ditemukan")
        End If

    End Sub

    Private Sub cm02GetFIeldName(ByVal prmDataTable As DataTable)

        _01ConsolLog.Text = ""
        For Each prmColumn As DataColumn In prmDataTable.Columns

            _01ConsolLog.Text += CStr(prmColumn.ColumnName) & vbNewLine

        Next

    End Sub

#End Region

#Region " Control Event"

    Private Sub btnGetdata_Click(sender As Object, e As EventArgs) Handles btnGetdata.Click
        cm01GetData()
    End Sub

#End Region

End Class