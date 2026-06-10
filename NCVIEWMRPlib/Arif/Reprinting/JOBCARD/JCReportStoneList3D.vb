Imports System.Drawing.Printing

Public Class JCReportStoneList3D
    Private Sub JCReportStoneList3D_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.BeforePrint
        _cm01InitPrint()
    End Sub


#Region "Costume Methods"

    Sub _cm01InitPrint()

        col01_k02cKodeStones_v50.Text = "[k03cKodeStones_v50]"
        col02_f04cNamaStoneShape_v50.Text = "[f04cNamaStoneShape_v50]"
        col03_f06cNamaStoneColor_v50.Text = "[f06cNamaStoneColor_v50]"
        col04_f08cNamaStoneSize_v50.Text = "[f08cNamaStoneSize_v50]"
        col05_f09nButir_int.Text = "[f09nButir_int]"
        col06_f10nBerat_n94.Text = "[f10nBerat_n94]"
    End Sub

#End Region
End Class