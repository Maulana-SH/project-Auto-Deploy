Imports System.Drawing
Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI

Public Class BOMReportFCP

    Public Property _01prop_ImageBOMFcpImage As Image

#Region "Costume : Method"
    Private Sub _cm01SetFieldNameTable()
        'add image in cell
        Dim objImage As New XRPictureBox

        With objImage
            .Borders = DevExpress.XtraPrinting.BorderSide.None
            .Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
            .Size = New Size(55, 55)
            .Image = _01prop_ImageBOMFcpImage
        End With

        BOMFcpPicture.Controls.Add(objImage)
        BOMFCf01cItemFindingComponentDesc_v50.Text = "[f01cItemFindingComponentDesc_v50]"
        BOMFcpk02cKodeItemFindingComponent_v50.Text = "[k02cKodeItemFindingComponent_v50]"
        BOMFcpf10nWeightPerPcs_n92.Text = "[f10nWeightPerPcs_n92]"
        BOMPCf02nPcs_int.Text = "[f02nPcs_int]"
        BOMFCf03nBerat_n92.Text = "[f03nBerat_n92]"
        BOMFcpf05cAssemblyDesc_v50.Text = "[f05cAssemblyDesc_v50]"
        BOMFcpf06cPerintahFinishing_v50.Text = "[f06cPerintahFinishing_v50]"
        BOMfCF08cPlatingDesc_v50.Text = "[f08cPlatingDesc_v50]"
        BOMFcpf09cNotes_v50.Text = "[f09cNotes_v50]"

    End Sub

    Public Sub _cm02SetBackColorTableByMaterial(TypeMaterial As String)
        'Throw New NotImplementedException()
        If TypeMaterial.Equals("GOLD") Then
            'Kuning
            BOMFCPHeaderTable.BackColor = Color.Gold
            BOMFCFooterTable.BackColor = Color.LightYellow
        ElseIf TypeMaterial.Equals("DIAMON") Then
            'Biru
            BOMFCPHeaderTable.BackColor = Color.LightBlue
            BOMFCFooterTable.BackColor = Color.LightCyan
        ElseIf TypeMaterial.Equals("SILVER") Then
            'Merah
            BOMFCPHeaderTable.BackColor = Color.DarkGray
            BOMFCFooterTable.BackColor = Color.WhiteSmoke
        End If
    End Sub

#End Region

    Private Sub FCP_Rep_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.BeforePrint
        _cm01SetFieldNameTable()
    End Sub

End Class