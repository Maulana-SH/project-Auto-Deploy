Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI

Public Class JCReportParent2D
    Implements IDisposable

    Public Property _01prop_dt30 As DataTable
    Public Property _02prop_dt31 As DataTable
    Public Property _03DesignerName As String
    Public Property _04prop_Img2D As Image

    Private Sub JCReportParent2D_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.BeforePrint
        _cm01InirPrint()
    End Sub

#Region "Costumm Methods"


    Sub _cm01InirPrint()

        col01_k01cKodeValidation_v50.Text = "[f01cNoJobCard_v50]"
        col02_f42dCreatedDate.Text = Format(CDate(GetCurrentColumnValue("f42dCreatedDate")), "dd-MMMM-yyyy")
        col03_k01cKodeDesignMaster_v50.Text = "[k01cKodeDesignMaster_v50]"
        col04_f08cNamaItemProduct_v50.Text = "[f08cNamaItemProduct_v50]"
        col05_f10cNamaSubItemProduct_v50.Text = "[f10cNamaSubItemProduct_v50]"
        col06_f19cNamaSize_v50.Text = "[f19cNamaSize_v50]"
        col07_f12cNamaProductionProcess_v50.Text = "[f12cNamaProductionProcess_v50]"
        col08_f14cNamaPlating_v50.Text = "[f14cNamaPlating_v50]"
        col09_f16cNamaFinishing_v50.Text = "[f16cNamaFinishing_v50]"
        col010_f17nGrossWeight_n94.Text = "[f17nGrossWeight_n94]"
        col011_f20cKeterangan_v150.Text = "Keterangan : " & "[f20cKeterangan_v150]"
        col11_f02cNamaBrand_v50.Text = "[f02cNamaBrand_v50]"
        col12_f04cNamaProject_v50.Text = "[f04cNamaProject_v50]"
        col13_f06cNamaNamingProduct_v50.Text = "[f06cNamaNamingProduct_v50]"
        col14_f22cNamaDesigner_v50.Text = "[f22cNamaDesigner_v50]"

    End Sub

    Sub _cm02PrintPreview(ByVal PrinterName As String)

        Dim objPrinterSetting As New PrinterSettings

        Dim objJCParent As New JCReportParent2D
        Dim objJCReportIMG2D As New JCReportImg2D
        Dim objJCReportStoneList As New JCReportStoneList


        With objJCParent
            .DataSource = _01prop_dt30

            'paper setting
            .PaperKind = PaperKind.A4
            'Margins(Left, Right, Top, Bottom)
            .Margins = New Margins(25, 25, 25, 25)
        End With

        'setstone list
        If _02prop_dt31.Rows.Count > 0 Then
            objJCParent.SubReportStoneList.ReportSource = objJCReportStoneList
            With objJCReportStoneList
                .DataSource = _02prop_dt31
            End With
        End If

        'setIMG 2D
        objJCParent.SubReportImg2D.ReportSource = objJCReportIMG2D
        With objJCReportIMG2D
            ' ._01Prop_NamaImage = "Gambar 2D [1:1]"
            ._01Prop_NamaImage = "2D PICTURE [1:1]"
            '._02Prop_Image = _04prop_Img2D
        End With

        objPrinterSetting.PrinterName = PrinterName
        'objPrinterSetting.Copies = CopiesTo
        ' objJCParent.Print
        objJCParent.ShowPreview

    End Sub


    Sub _cm03PrintDoc(ByVal PrinterName As String)

        Dim objPrinterSetting As New PrinterSettings

        Dim objJCParent As New JCReportParent2D
        Dim objJCReportIMG2D As New JCReportImg2D
        Dim objJCReportStoneList As New JCReportStoneList

        With objJCParent
            .DataSource = _01prop_dt30

            'paper setting
            .PaperKind = PaperKind.A4
            'Margins(Left, Right, Top, Bottom)
            .Margins = New Margins(25, 25, 25, 25)
        End With

        'setstone list
        If _02prop_dt31.Rows.Count > 0 Then
            objJCParent.SubReportStoneList.ReportSource = objJCReportStoneList
            With objJCReportStoneList
                .DataSource = _02prop_dt31
            End With
        End If

        'setIMG 2D
        objJCParent.SubReportImg2D.ReportSource = objJCReportIMG2D
        With objJCReportIMG2D
            ._01Prop_NamaImage = "Gambar 2D [1:1]"
            ._02Prop_Image = _04prop_Img2D
        End With

        objPrinterSetting.PrinterName = PrinterName
        'objPrinterSetting.Copies = CopiesTo
        objJCParent.Print

    End Sub
#End Region
End Class