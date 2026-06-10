Imports System.Drawing.Printing

Public Class JCReportStoneList
    Implements IDisposable

    Private Sub JCReportStoneList_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.BeforePrint
        _cm01InitPrint()
    End Sub


#Region "Costume Methods"

    Sub _cm01InitPrint()

        col01_f04cNamaStoneShape_v50.Text = "[f04cNamaStoneShape_v50]"
        col02_f06cNamaStoneColor_v50.Text = "[f06cNamaStoneColor_v50]"
        col03_f08cNamaStoneSize_v50.Text = "[f08cNamaStoneSize_v50]"
        col04_f09nButir_int.Text = "[f09nButir_int]"
        col05_f10nBerat_n94.Text = "[f10nBerat_n94]"
        col06_k02cKodeStones_v50.Text = "[k02cKodeStones_v50]"
    End Sub

#End Region
End Class