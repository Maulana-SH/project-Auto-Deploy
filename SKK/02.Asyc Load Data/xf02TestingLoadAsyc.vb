Public Class xf02TestingLoadAsyc
    Implements IDisposable

    'Private Function PdfsMovingAsync() As Task
    '    Return Task.Run(Sub() _cm04DisplayPivotSaldoSKU())
    'End Function

    Private Function _cm04DisplayPivotSaldoSKU() As DataTable

        Dim pdtTempTbl As New DataTable
        Using objMenuUtama As NCMODELlib.clsNEWCENTRAL_iface = New NCMODELlib.clsNEWCENTRAL_impl With {.prop_nTarget = 1,
                                                                                                       .prop_11dTanggal = Date.Now}
            pdtTempTbl = objMenuUtama.GetP6KG01SaldoSKU()
        End Using

        Return pdtTempTbl
    End Function

    Private Function HandleFileAsync()
        Console.WriteLine("Load Data enter")

        ' Open the file.
        Dim pdtTempTbl As New DataTable
        Using objMenuUtama As NCMODELlib.clsNEWCENTRAL_iface = New NCMODELlib.clsNEWCENTRAL_impl With {.prop_nTarget = 1,
                                                                                                       .prop_11dTanggal = Date.Now}
            pdtTempTbl = objMenuUtama.GetP6KG01SaldoSKU()
        End Using


        Console.WriteLine("Load data exit")
        Return pdtTempTbl
    End Function




#Region " Asycn Function v2 "
    ' https://stackoverflow.com/questions/41064994/using-async-await-correctly-in-vb (Gridview autogebneratae View 1by 1)

#End Region

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click

    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

    End Sub
End Class