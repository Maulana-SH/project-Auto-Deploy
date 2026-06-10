Imports System.Drawing
Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI

Public Class PROPreparationReportBomFG
    Implements IDisposable
    Public Property Prop_ImgBOMFG As Image

#Region "Costum : Method"

    Sub _cm01SetFieldName()
        'Set Picture in 
        Dim objImage As New XRPictureBox
        objImage.Borders = DevExpress.XtraPrinting.BorderSide.None
        objImage.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
        objImage.Size = New Size(85, 45)
        objImage.Image = Prop_ImgBOMFG

        ProPrepBOMFGPicture.Controls.Add(objImage)
        ProPrepBOMFGf12cRawMaterialDesc_v50.Text = "[f12cRawMaterialDesc_v50]"
        ProPrepBOMFGf06cSize_v50.Text = "[f06cSize_v50]"
        ProPrepBOMFGNote.Text = "[f25cNotes_v250]"
    End Sub

    Public Sub _cm02SetBackColorTableByBrand(ByVal Brand As String)
        'Throw New NotImplementedException()
        If Brand.Equals("SDW") Then
            ProPrepBomFGHeaderTable.BackColor = Color.Gold
        ElseIf Brand.Equals("ABC") Then
            'Biru
            ProPrepBomFGHeaderTable.BackColor = Color.LightBlue
        ElseIf Brand.Equals("EFG") Then
            'Merah
            ProPrepBomFGHeaderTable.BackColor = Color.LightGray
        End If
    End Sub

#End Region

    Private Sub PROPreparationReportBomFG_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.BeforePrint
        _cm01SetFieldName()
    End Sub

End Class