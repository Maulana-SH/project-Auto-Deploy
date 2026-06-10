Imports System.Drawing
Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI

Public Class PROPreparationReportBomPreparation
    Implements IDisposable

    Public Property prop_ImgBOMPreparation As Image

#Region "Costum : Method"

    Sub _cm01SetFieldName()

        '28BOMGFCI
        ProPreparationBOMf12cRawMaterialDesc_v50.Text = "[f02cNamaCastedPart_v50]"
        ProPreparationBOMf06cSize_v50.Text = "[f07nQty_int]"
        ProPreparationBOMf25cNotes_v250.Text = "[f04cNote_v200]"

    End Sub

    Public Sub _cm02SetBackColorTableByBrand(ByVal Brand As String)
        'Throw New NotImplementedException()
        If Brand.Equals("SDW") Then
            ProPrepBomHeaderTable.BackColor = Color.Gold
        ElseIf Brand.Equals("ABC") Then
            'Biru
            ProPrepBomHeaderTable.BackColor = Color.LightBlue
        ElseIf Brand.Equals("EFG") Then
            'Merah
            ProPrepBomHeaderTable.BackColor = Color.LightGray
        End If
    End Sub

#End Region
    Private Sub PROPreparationReportBomPreparation_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.BeforePrint
        _cm01SetFieldName()
    End Sub
End Class