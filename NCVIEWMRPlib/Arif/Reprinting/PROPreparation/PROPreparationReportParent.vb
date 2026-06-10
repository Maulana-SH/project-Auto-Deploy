Imports System.Drawing
Imports System.Drawing.Printing
Imports DevExpress.XtraPrinting.BarCode
Imports DevExpress.XtraReports.UI

Public Class PROPreparationReportParent

    Public Property _01prop28BOMFCI As DataTable
    Public Property _02prop28COREPRO As DataTable
    Public Property _03prop29ROUTINGBOM As DataTable
    Public Property _04propImg01 As Image
    Public Property _05propImg02 As Image
    Public Property _06propImg03 As Image

#Region "Costum Methods"

    Sub _cm01SetFieldName()
        'Head 1 
        ProPrepHeadk01cNoPRO_v50.Text = "[k01cNoPRO_v50]"
        ProHeadk02cKodeMaterialOrFG_v50.Text = "[k02cKodeMaterialOrFG_v50]"
        ProHeadf02MaterialOrFGDesc_v50.Text = "[f02MaterialOrFGDesc_v50]"
        ProHeadf07cOrderStatusDesc_v50.Text = "[f07cOrderStatusDesc_v50]"
        ProHeadf08dOrderDate.Text = Format(CDate(GetCurrentColumnValue("f08dOrderDate")), "dd-MMMM-yyyy")
        ProHeadf09dDeliveryDate.Text = Format(CDate(GetCurrentColumnValue("f09dDeliveryDate")), "dd-MMMM-yyyy")

        'Head2
        ProHeadf19cItemBRJDesc_v50.Text = "[f19cItemBRJDesc_v50]"
        ProHEadf21cWarnaFGDesc_v50.Text = "[f21cWarnaFGDesc_v50]"
        ProHEadf23cKadarDesc_v50.Text = "[f23cKadarDesc_v50]"
        ProHeadf04nBerat_n92.Text = "[f04nBerat_n92]"
        ProHead_f03nLot_int.Text = "[f03nLot_int]"
        ProHeadf24cSize_v50.Text = "[f24cSize_v50]"
        ProHeadf25cNotes_v250.Text = "[f25cNotes_v250]"

    End Sub

    Public Sub _cm03CreatQRCode(ByVal VarCode As String)
        ' ProPrepHeadQRcode.Size = New System.Drawing.Size(150, 150)
        ProPrepHeadQRcode.AutoModule = True
        ProPrepHeadQRcode.Text = VarCode
        ProPrepHeadQRcode.ShowText = False
        Dim symb As QRCodeGenerator = New QRCodeGenerator()
        ProPrepHeadQRcode.Symbology = symb
        symb.CompactionMode = QRCodeCompactionMode.AlphaNumeric
        symb.ErrorCorrectionLevel = QRCodeErrorCorrectionLevel.H
        symb.Version = QRCodeVersion.AutoVersion
    End Sub

    Sub _cm04PrintDoc(ByVal NOPRO As String, Optional PrinterName As String = "", Optional Brand As String = "")

        Dim objReportProPrepParent As New PROPreparationReportParent
        Dim objReportProPrepBOMPrepration As New PROPreparationReportBomPreparation
        Dim objReportProPrepRouting As New PROPreparationReportRouting
        Dim objReportProPrepIMG As New PROPreparationIMG

        'Set ( Report Parent ) => dt28
        With objReportProPrepParent
            .DataSource = _02prop28COREPRO

            'creat QRcode by nopro
            ._cm03CreatQRCode(NOPRO)

            'Report IMGE Fotter
            .SubReportPROPreparationIMG.ReportSource = objReportProPrepIMG
            With objReportProPrepIMG
                'set Picture
                .prop_01IMGPROPreparation = _04propImg01
                .prop_02IMGPROPreparation = _05propImg02
                .prop_03IMGPROPreparation = _06propImg03
            End With

        End With

        ''Set (Report BOMPreparation) 
        If _01prop28BOMFCI.Rows.Count <= 0 Then
            objReportProPrepParent.SubReportBOMPreparation.Visible = False
        Else
            objReportProPrepParent.SubReportBOMPreparation.ReportSource = objReportProPrepBOMPrepration
            With objReportProPrepBOMPrepration
                .DataSource = _01prop28BOMFCI
                '.prop_ImgBOMPreparation = My.Resources.GJ_Gold
            End With
        End If

        'for (Report Routing BOM) =>dt29
        If _03prop29ROUTINGBOM.Rows.Count <= 0 Then
            objReportProPrepParent.SubReportRouting.Visible = False
        Else
            objReportProPrepParent.SubReportRouting.ReportSource = objReportProPrepRouting
            With objReportProPrepRouting
                .DataSource = _03prop29ROUTINGBOM
            End With

        End If

        objReportProPrepParent.Margins = New Margins(25, 25, 25, 25)
        objReportProPrepParent.PaperKind = PaperKind.A4
        ' objReportProPrepParent.Print(PrinterName)
        'objReportProPrepParent.Print
        objReportProPrepParent.ShowPreview
    End Sub

#End Region

    Private Sub PRPReportParent_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.BeforePrint
        _cm01SetFieldName()
    End Sub

End Class