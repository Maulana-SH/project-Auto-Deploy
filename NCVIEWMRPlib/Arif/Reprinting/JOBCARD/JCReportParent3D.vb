Imports System.Drawing.Printing
Imports DevExpress.XtraReports.UI

Public Class JCReportParent3D
    Implements IDisposable

    Public Property _01prop_dt35 As DataTable
    Public Property _02prop_dt36 As DataTable
    Public Property _03prop_dt37 As DataTable
    Public Property _04prop_dtRouting As DataTable
    Public Property _05prop_dt31 As DataTable

    Public Property _IMG3D_No1 As Image
    Public Property _IMG3D_No2 As Image
    Public Property _IMG3D_No3 As Image

    Private Sub JCReportParent3D_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.BeforePrint
        _cm01InitPrint()
    End Sub

#Region "Costum : Methods"

    Private Sub _cm01InitPrint()

        col01_k01cKodeValidation_v50.Text = "[k01cKodeValidation_v50]"
        col02_f02cNameJCProductType_v50.Text = "[f02cNameJCProductType_v50]"
        col03_f04cNameJCProductSubtype_v50.Text = "[f04cNameJCProductSubtype_v50]"
        col04_f05dInputDateAdmin.Text = Format(CDate(GetCurrentColumnValue("f05dInputDateAdmin")), "dd-MMMM-yyyy")
        col05_f06dDeliveryDate.Text = Format(CDate(GetCurrentColumnValue("f06dDeliveryDate")), "dd-MMMM-yyyy")
        col06_k03cKodeDesignMaster.Text = "[k03cKodeDesignMaster]"
        col07_f08cNameItemProduct_v50.Text = "[f08cNameItemProduct_v50]"
        col08_f12cNameSize_v50.Text = "[f12cNameSize_v50]"
        col09_f20cNameMasterType_v50.Text = "[f20cNameMasterType_v50]"
        col10_f22cNameStatusOrder_v50.Text = "[f22cNameStatusOrder_v50]"
        col11_f24cNameProject_v50.Text = "[f24cNameProject_v50]"
        col12_f26cNameProduct_v50.Text = "[f26cNameProduct_v50]"
        col13_f27nEstimasiBerat_n92.Text = "[f27nEstimasiBerat_n92]"
        'col15_f29cNameDesigner_v50.Text = "[f29cNameDesigner_v50]"
        col16_Keterangan.Text = "Keterangan :" & "[f33cKeterangan_v100]"

    End Sub

    Public Sub _cm02PrintPreviewDoc(ByVal PrinterName As String)

        Dim objPrinterSetting As New PrinterSettings

        Dim objJCParent As New JCReportParent3D
        Dim objJCReportBOM As New JCReportBom
        Dim objJCReportRouting As New JCReportRouting
        Dim objJCReportIMG3D As New JCReportImg3D
        Dim objJCReportStoneList As New JCReportStoneList3D

        With objJCParent
            .DataSource = _01prop_dt35
        End With

        ' set report BOM  
        If _02prop_dt36.Rows.Count > 0 Then
            objJCParent.SubReportBOM.ReportSource = objJCReportBOM
            objJCReportBOM.DataSource = _02prop_dt36
        End If

        'setstone List
        If _05prop_dt31.Rows.Count > 0 Then
            objJCParent.SubreportStone.ReportSource = objJCReportStoneList
            With objJCReportStoneList
                .DataSource = _05prop_dt31
            End With
        End If

        ' Set Report Routing
        If _04prop_dtRouting.Rows.Count > 0 Then
            objJCParent.SubreportRouting.ReportSource = objJCReportRouting
            objJCReportRouting.DataSource = _04prop_dtRouting
        End If

        'setReport IMG
        objJCParent.SubReportImg3D.ReportSource = objJCReportIMG3D
        With objJCReportIMG3D
            ._01prop_NameIMG = "3D Picture"
            ._02prop_ImgTampak01 = _IMG3D_No1
            ._03prop_ImgTampak02 = _IMG3D_No2
            ._04prop_ImgTampak03 = _IMG3D_No3
        End With

        objPrinterSetting.PrinterName = PrinterName
        ' objPrinterSetting.Copies = CopiesTo
        PaperKind = PaperKind.A4
        'Margins(Left, Right, Top, Bottom)
        Margins = New Margins(25, 25, 15, 25)
        objJCParent.ShowPreview
    End Sub

    Public Sub _cm03PrintDoc(ByVal PrinterName As String)

        Dim objPrinterSetting As New PrinterSettings

        Dim objJCParent As New JCReportParent3D
        Dim objJCReportBOM As New JCReportBom
        Dim objJCReportRouting As New JCReportRouting
        Dim objJCReportIMG3D As New JCReportImg3D

        With objJCParent
            .DataSource = _01prop_dt35

        End With

        ' set report BOM  
        If _02prop_dt36.Rows.Count > 0 Then
            objJCParent.SubReportBOM.ReportSource = objJCReportBOM
            objJCReportBOM.DataSource = _02prop_dt36
        End If

        ' Set Report Routing
        If _04prop_dtRouting.Rows.Count > 0 Then
            objJCParent.SubreportRouting.ReportSource = objJCReportRouting
            objJCReportRouting.DataSource = _04prop_dtRouting
        End If

        'setReport IMG
        objJCParent.SubReportImg3D.ReportSource = objJCReportIMG3D
        With objJCReportIMG3D
            ._01prop_NameIMG = "3D Picture"
            ._02prop_ImgTampak01 = _IMG3D_No1
            ._03prop_ImgTampak02 = _IMG3D_No2
            ._04prop_ImgTampak03 = _IMG3D_No3
        End With

        objPrinterSetting.PrinterName = PrinterName
        PaperKind = PaperKind.A4
        'Margins(Left, Right, Top, Bottom)
        Margins = New Margins(25, 25, 25, 25)
        objJCParent.Print

    End Sub


#End Region

End Class