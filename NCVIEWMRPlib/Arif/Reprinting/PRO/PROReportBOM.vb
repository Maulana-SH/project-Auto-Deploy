Imports System.Drawing
Imports System.Drawing.Printing
Imports System.IO
Imports DevExpress.XtraReports.UI

Public Class PROReportBOM

    'Public Property prop_img25BOMCP As Image

#Region "Costum : Method"

    Private Function _pm02ByteArrayToImage(ByVal byteArrayIn As Byte()) As Image
        Dim ms As MemoryStream = New MemoryStream(byteArrayIn)
        Dim returnImage As Image = Image.FromStream(ms)
        Return returnImage
    End Function
    Private Sub _cm01SetFieldNameTabel()
        If CType(GetCurrentColumnValue("f01objGambar"), Byte()) IsNot Nothing Then
            XrPictureBox1.ImageAlignment = DevExpress.XtraPrinting.ImageAlignment.MiddleCenter
            XrPictureBox1.Borders = DevExpress.XtraPrinting.BorderSide.None
            XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
            XrPictureBox1.Size = New Size(85, 45)
            ProBOMPicture.Controls.Add(XrPictureBox1)
        End If

        ProBOMk02cKodeRubber_v50.Text = "[k02cKodeRubber_v50]"
        ProBOMf01cItemCastedPartsDesc_v50.Text = "[f01cItemCastedPartsDesc_v50]"
        ProBOMf02nPcs_int.Text = "[f02nPcs_int]"
        ProBOMf03nBerat_n92.Text = "[f03nBerat_n92]"
        ProBOMf05cAssemblyDesc_v50.Text = "[f05cAssemblyDesc_v50]"
        ProBOMf08cPlatingDesc_v50.Text = "[f08cPlatingDesc_v50]"
        ProBOMf06cPerintahFinishing_v50.Text = "[f06cPerintahFinishing_v50]"

    End Sub

    Public Sub _cm02SetBackColorTableByBrand(Brand As String)
        'Throw New NotImplementedException()
        If Brand.Equals("SDW") Then
            PROBomHeaderTable.BackColor = Color.Gold
        ElseIf Brand.Equals("ABC") Then
            'Biru
            PROBomHeaderTable.BackColor = Color.LightBlue
        ElseIf Brand.Equals("EFG") Then
            'Merah
            PROBomHeaderTable.BackColor = Color.LightGray
        End If
    End Sub

#End Region
    Private Sub ReportBIllOfMaterialProductionOrder_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.BeforePrint
        _cm01SetFieldNameTabel()
    End Sub

    Private Sub XrPictureBox1_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles XrPictureBox1.BeforePrint
        If CType(GetCurrentColumnValue("f01objGambar"), Byte()) IsNot Nothing Then
            Dim ms As New MemoryStream(CType(GetCurrentColumnValue("f01objGambar"), Byte()))
            CType(sender, XRPictureBox).Image = Image.FromStream(ms)
        End If
    End Sub

End Class