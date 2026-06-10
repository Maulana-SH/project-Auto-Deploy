Imports System.Drawing
Imports System.Drawing.Printing
Imports System.IO
Imports DevExpress.XtraReports.UI

Public Class PROReportFCP

#Region "Costum: Method"
    Private Function _pm02ByteArrayToImage(ByVal byteArrayIn As Byte()) As Image
        Dim ms As MemoryStream = New MemoryStream(byteArrayIn)
        Dim returnImage As Image = Image.FromStream(ms)
        Return returnImage
    End Function
    Private Sub _cm01SetFieldNameTable()
        If CType(GetCurrentColumnValue("f01objGambar"), Byte()) IsNot Nothing Then
            Dim objIMG As New XRPictureBox
            XrPictureBox1.Borders = DevExpress.XtraPrinting.BorderSide.None
            XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
            XrPictureBox1.Size = New Size(85, 45)
            ' objIMG.Image = _pm02ByteArrayToImage(CType(GetCurrentColumnValue("f01objGambar"), Byte()))
            ProFCPictures.Controls.Add(XrPictureBox1)
        End If

        ProFCf01cItemFindingComponentDesc_v50.Text = "[f01cItemFindingComponentDesc_v50]"
        ProFCf02nPcs_int.Text = "[f02nPcs_int]"
        ProFCf03nBerat_n92.Text = "[f03nBerat_n92]"
        ProFCf09cNotes_v50.Text = "[f09cNotes_v50]"
    End Sub

    Public Sub _cm02SetBackColorTableByBrand(Brand As String)
        'Throw New NotImplementedException()
        If Brand.Equals("SDW") Then
            PROFcHeaderTable.BackColor = Color.Gold
        ElseIf Brand.Equals("ABC") Then
            'Biru
            PROFcHeaderTable.BackColor = Color.LightBlue
        ElseIf Brand.Equals("EFG") Then
            'Merah
            PROFcHeaderTable.BackColor = Color.LightGray
        End If
    End Sub

#End Region
    Private Sub ReportFCProductionOrder_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.BeforePrint
        _cm01SetFieldNameTable()
    End Sub

    Private Sub XrPictureBox1_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles XrPictureBox1.BeforePrint
        If CType(GetCurrentColumnValue("f01objGambar"), Byte()) IsNot Nothing Then
            Dim ms As New MemoryStream(CType(GetCurrentColumnValue("f01objGambar"), Byte()))
            CType(sender, XRPictureBox).Image = Image.FromStream(ms)
        End If
    End Sub

End Class