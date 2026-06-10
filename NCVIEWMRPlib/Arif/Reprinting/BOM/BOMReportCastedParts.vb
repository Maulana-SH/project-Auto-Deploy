Imports System.Drawing
Imports System.Drawing.Printing
Imports System.IO
Imports DevExpress.XtraReports.UI

Public Class BOMReportCastedParts

    Public Property _01prop_BOMCastePartImage As Image
    'Public Property _02prop_BOMCPKodeRuber As String
    'Public Property _03prop_BOMCPWeightPerPcs As String
    'Public Property _04prop_BOMCPKodeItemCastedParts As String
    'Public Property _05prop_BOMCPItemCastedPartsDesc As String
    'Public Property _06prop_BOMCPPcs As String
    'Public Property _07prop_BOMCPBerat As String
    'Public Property _08prop_BOMCPAssemblyDesc As String
    'Public Property _09prop_BOMCPPerintahFinishing As String
    'Public Property _010prop_BOMCPPlatingDesc As String


#Region "Costum : Methods"
    Private Sub _cm01SetFieldNameTable()

        If CType(GetCurrentColumnValue("f01objGambar"), Byte()) IsNot Nothing Then
            XrPictureBox1.Borders = DevExpress.XtraPrinting.BorderSide.None
            XrPictureBox1.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze
            XrPictureBox1.Size = New Size(165, 150)
            XrPictureBox1.LocationF = New Point(0, BOMCpImage.Size.Width - XrPictureBox1.Width)

            BOMCpImage.Controls.Add(XrPictureBox1)
        End If

        BOMCPk02cKodeRubber_v50.Text = "[k02cKodeRubber_v50]"
        BOMCpf09nWeightPerPcs_n92.Text = "[f09nWeightPerPcs_n92]"
        BOMCpk03cKodeItemCastedParts_v50.Text = "[k03cKodeItemCastedParts_v50]"
        BOMCPf01cItemCastedPartsDesc_v50.Text = "[f01cItemCastedPartsDesc_v50]"
        BOMCPf02nPcs_int.Text = "[f02nPcs_int]"
        BOMCPf03nBerat_n92.Text = "[f03nBerat_n92]"
        BOMCpf05cAssemblyDesc_v50.Text = "[f05cAssemblyDesc_v50]"
        BOMCpf06cPerintahFinishing_v50.Text = "[f06cPerintahFinishing_v50]"
        BOMCpf08cPlatingDesc_v50.Text = "[f08cPlatingDesc_v50]"
        BOMCpf12cNote_v100.Text = "[f12cNote_v100]"

    End Sub

    Public Sub _cm02SetBackColorTableByMaterial(ByVal TypeMaterial As String)
        'Throw New NotImplementedException()
        If TypeMaterial.Equals("GOLD") Then
            'Kuning
            BOMCpHeaderTable.BackColor = Color.Gold
            BOMCPFoterTable.BackColor = Color.LightYellow
        ElseIf TypeMaterial.Equals("DIAMON") Then
            'Biru
            BOMCpHeaderTable.BackColor = Color.LightBlue
            BOMCPFoterTable.BackColor = Color.LightCyan
        ElseIf TypeMaterial.Equals("SILVER") Then
            'ABu-abu
            BOMCpHeaderTable.BackColor = Color.DarkGray
            BOMCPFoterTable.BackColor = Color.WhiteSmoke
        End If
    End Sub


#End Region


    Private Sub ReportCastedParts_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.BeforePrint
        _cm01SetFieldNameTable()
    End Sub

    Private Sub XrPictureBox1_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles XrPictureBox1.BeforePrint
        If CType(GetCurrentColumnValue("f01objGambar"), Byte()) IsNot Nothing Then
            Dim ms As New MemoryStream(CType(GetCurrentColumnValue("f01objGambar"), Byte()))
            CType(sender, XRPictureBox).Image = Image.FromStream(ms)
        End If
    End Sub
End Class