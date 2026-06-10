Imports System.Drawing
Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI

Public Class BOMReportStones


#Region "Costume : Method"

    Private Sub _cm01SetFieldNameTabel()

        'add image in cell
        BOMStonesk02cKodeStones_v50.Text = "[k02cKodeStones_v50]"
        BOMStonesf01cStonesDesc_v50.Text = "[f01cStonesDesc_v50]"
        BOMStonesf02cSizeDesc_v50.Text = "[f02cSizeDesc_v50]"
        BOMStonesf09nWeightPerPcs_n93.Text = "[f09nWeightPerPcs_n93]"
        BOMStonesf05nButir_int.Text = "[f05nButir_int]"
        BOMStonesf06nBeratGram_n93.Text = "[f06nBeratGram_n93]"
        BOMStonesf03cQualityDesc_v50.Text = "[f03cQualityDesc_v50]"
        BOMStonesf04cBrandDesc_v50.Text = "[f04cBrandDesc_v50]"
        BOMStonesf08cSettingDesc_v50.Text = "[f08cSettingDesc_v50]"

    End Sub

    Public Sub _cm02SetBackColorTableByMaterial(TypeMaterial As String)
        'Throw New NotImplementedException()
        If TypeMaterial.Equals("GOLD") Then
            'Kuning
            BOMStonesHeaderTable.BackColor = Color.Gold
            BOMStonesFooterTable.BackColor = Color.LightYellow
        ElseIf TypeMaterial.Equals("DIAMON") Then
            'Biru
            BOMStonesHeaderTable.BackColor = Color.LightBlue
            BOMStonesFooterTable.BackColor = Color.LightCyan
        ElseIf TypeMaterial.Equals("SILVER") Then
            'Merah
            BOMStonesHeaderTable.BackColor = Color.DarkGray
            BOMStonesFooterTable.BackColor = Color.WhiteSmoke
        End If
    End Sub


#End Region

#Region "Before : Print"
    Private Sub Stones_Rep_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.BeforePrint

        _cm01SetFieldNameTabel()
    End Sub

#End Region

End Class