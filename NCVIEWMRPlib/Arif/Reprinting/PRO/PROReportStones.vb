Imports System.Drawing
Imports System.Drawing.Printing

Public Class PROReportStones


#Region "Costum : Method"
    Private Sub _cm01SetFieldNameTable()
        ProStonesf04cBrandDesc_v50.Text = "[f01cStonesDesc_v50]"
        ProStunesf05nButir_int.Text = "[f05nButir_int]"
        ProStunesf06nBeratGram_n93.Text = "[f06nBeratGram_n93]"
        ProStunesf08cSettingDesc_v50.Text = "[f08cSettingDesc_v50]"

    End Sub

    Public Sub _cm02SetBackColorTableByBrand(Brand As String)
        'Throw New NotImplementedException()
        If Brand.Equals("SDW") Then
            PROStonesHeaderTable.BackColor = Color.Gold
        ElseIf Brand.Equals("ABC") Then
            'Biru
            PROStonesHeaderTable.BackColor = Color.LightBlue
        ElseIf Brand.Equals("EFG") Then
            'Merah
            PROStonesHeaderTable.BackColor = Color.LightGray
        End If
    End Sub

#End Region


    Private Sub ReportStonesProductionOrder_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.BeforePrint
        _cm01SetFieldNameTable()
    End Sub
End Class