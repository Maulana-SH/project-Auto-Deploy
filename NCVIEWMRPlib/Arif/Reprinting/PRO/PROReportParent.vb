Imports System.Drawing.Printing
Imports DevExpress.XtraPrinting.BarCode
Imports DevExpress.XtraReports.UI

Public Class PROReportParent



    Public Property _01Prop_DsReportHeadert28 As DataTable
    Public Property _02Prop_DsReportBOMCASTEDPARTS25 As DataTable
    Public Property _03Prop_DsReportBOMFINDINGCOMPONENT26 As DataTable
    Public Property _04Prop_DsReportBOMSTONES27 As DataTable
    Public Property _05PropdtMasterRoutingByFGCODE As DataTable

    'prop image
    Public Property _06prop_IMGBRJ As Image
    Public Property _07prop_IMGTampak01 As Image
    Public Property _08prop_IMGTampak02 As Image
    Public Property _09prop_IMGTampak03 As Image

    Public Property _012Prop_NoSKUPRO As String
    Public Property _013Prop_Brand As String
    Public Property _014Prop_Lot As Integer


#Region "Costum : Method"

    Private Sub _cm01SetFieldNameTable()
        'Head 1
        ProHeadk01cNoPRO_v50.Text = GetCurrentColumnValue("k01cNoPRO_v50").ToString()
        _01ProHeadf01KodeMaterial_v50.Text = GetCurrentColumnValue("k02cKodeMaterialOrFG_v50").ToString()
        _02ProHeadf12cBrandDesc_v50.Text = GetCurrentColumnValue("f12cBrandDesc_v50").ToString()
        _03ProHeadf07cOrderStatusDesc_v50.Text = GetCurrentColumnValue("f07cOrderStatusDesc_v50").ToString()
        _04ProHeadf08dOrderDate.Text = Format(CDate(GetCurrentColumnValue("f08dOrderDate")), "dd-MMMM-yyyy")
        _05ProHeadf09dDeliveryDate.Text = Format(CDate(GetCurrentColumnValue("f09dDeliveryDate")), "dd-MMMM-yyyy")
        _06ProHeadf10cMTOS_v50.Text = GetCurrentColumnValue("f10cMTOS_v50").ToString()
        _07ProHeadf14cCustomerDesc_v50.Text = GetCurrentColumnValue("f12cBrandDesc_v50").ToString()
        _08ProHeadf16cProjectDesc_v50.Text = GetCurrentColumnValue("f14cCustomerDesc_v50").ToString()
        _10ProHeadf02MaterialDesc_v50.Text = GetCurrentColumnValue("f02MaterialOrFGDesc_v50").ToString()
        _09ProHeadf17cNamaProduk_v50.Text = GetCurrentColumnValue("f17cNamaProduk_v50").ToString()

        ''Head 2
        ProHeadf19cItemBRJDesc_v50.Text = GetCurrentColumnValue("f19cItemBRJDesc_v50").ToString()
        ProHEadf21cWarnaFGDesc_v50.Text = GetCurrentColumnValue("f21cWarnaFGDesc_v50").ToString()
        ProHEadf23cKadarDesc_v50.Text = GetCurrentColumnValue("f23cKadarDesc_v50").ToString()
        ProHeadf24cSize_v50.Text = GetCurrentColumnValue("f24cSize_v50").ToString()
        ProaHeadf03nLot_int.Text = GetCurrentColumnValue("f03nLot_int").ToString()
        ProHeadf04nBerat_n92.Text = GetCurrentColumnValue("f04nBerat_n92").ToString()
        ProHeadf05cEngrave_v50.Text = GetCurrentColumnValue("f05cEngrave_v50").ToString()
        ProHeadf25cNotes_v250.Text = GetCurrentColumnValue("f25cNotes_v250").ToString()

    End Sub

    'set backcolor and brand logo
    Public Sub _cm02SetBackColorTableByBrand(ByVal Brand As String)
        'Throw New NotImplementedException()
        If Brand.Equals("SDW") Then
            PRORowHeader.BackColor = Color.Gold
            PictureBoxBrandLogo.Image = My.Resources.SDW_Gold
            'Biru
        ElseIf Brand.Equals("ABC") Then
            PRORowHeader.BackColor = Color.LightBlue
            PictureBoxBrandLogo.Image = My.Resources.HALA_Gold
        ElseIf Brand.Equals("EFG") Then
            'Merah
            PRORowHeader.BackColor = Color.LightGray
            PictureBoxBrandLogo.Image = My.Resources.GJ_Gold
        End If
    End Sub

    Public Sub _cm04CreatQRCode(ByVal VarCode As String)
        ProHeadQRcode.Size = New System.Drawing.Size(175, 175)
        ProHeadQRcode.AutoModule = True
        ProHeadQRcode.Text = VarCode
        ProHeadQRcode.ShowText = False
        Dim symb As QRCodeGenerator = New QRCodeGenerator()
        ProHeadQRcode.Symbology = symb
        symb.CompactionMode = QRCodeCompactionMode.AlphaNumeric
        symb.ErrorCorrectionLevel = QRCodeErrorCorrectionLevel.H
        symb.Version = QRCodeVersion.AutoVersion
    End Sub

    Public Sub _cm01PreparePrintSHow()
        Me.DataSource = _01Prop_DsReportHeadert28

        _cm01SetFieldNameTable()
        _cm04CreatQRCode(_012Prop_NoSKUPRO)

        'Dim objReportProParent As New PROReportParent
        Dim objReportProFC As New PROReportFCP
        Dim objReportProBOM As New PROReportBOM
        Dim objReportStonePRO As New PROReportStones
        Dim ObjReportRoutingPRO As New PROReportRouting
        Dim objReportIMGBRJ As New PROReportProImageSatu
        Dim objReportTampakBRJ As New PROReportTCD

        'Report 25BOMCASTEDPARTS
        If _02Prop_DsReportBOMCASTEDPARTS25.Rows.Count > 0 Then
            objReportProBOM.DataSource = _02Prop_DsReportBOMCASTEDPARTS25
            Me.SubReporProBOM.ReportSource = objReportProBOM
        End If

        'Report finding Component
        If _03Prop_DsReportBOMFINDINGCOMPONENT26.Rows.Count > 0 Then
            objReportProFC.DataSource = _03Prop_DsReportBOMFINDINGCOMPONENT26
            objReportProBOM.SubReportProFC.ReportSource = objReportProFC
        End If

        'Report STone
        If _04Prop_DsReportBOMSTONES27.Rows.Count > 0 Then
            objReportStonePRO.DataSource = _04Prop_DsReportBOMSTONES27
            objReportProBOM.SubReportProStones.ReportSource = objReportStonePRO
        End If

        'Report Routing
        If _05PropdtMasterRoutingByFGCODE.Rows.Count > 0 Then
            ObjReportRoutingPRO.DataSource = _05PropdtMasterRoutingByFGCODE
            Me.SubReportProRouting.ReportSource = ObjReportRoutingPRO
        End If

        'Report IMage BRJ
        If _06prop_IMGBRJ IsNot Nothing Then
            objReportIMGBRJ.prop_IMG01 = _06prop_IMGBRJ
            Me.SubReportImage.ReportSource = objReportIMGBRJ
        End If

        'Image Tampak BRJ
        Me.SubreportTCD.ReportSource = objReportTampakBRJ
        With objReportTampakBRJ
            .prop_imgTcd01 = _07prop_IMGTampak01
            .prop_imgTcd02 = _08prop_IMGTampak02
            .prop_imgTcd03 = _09prop_IMGTampak03
        End With

        Me.Margins = New Margins(50, 50, 50, 50)
        Me.PaperKind = System.Drawing.Printing.PaperKind.A4
        Me.ShowPreview
    End Sub

#End Region
    Private Sub ReportParentProductionOrder_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles MyBase.BeforePrint

        _cm01SetFieldNameTable()
    End Sub

End Class