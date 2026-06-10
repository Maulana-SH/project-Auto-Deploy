Imports System.Drawing.Printing
Imports DevExpress.XtraPrinting.Drawing
Imports DevExpress.XtraReports.UI

Public Class BOMReportParent
    Implements IDisposable

    '==> Prop lama
    'Public Property _01Propdt20MASTERROUTING As DataTable
    'Public Property _02Propdt24MCFINISHEDGOOD As DataTable
    'Public Property _03Propdt25BOMCASTEDPARTS As DataTable
    'Public Property _04Propdt26BOMFINDINGCOMPONENT As DataTable
    'Public Property _05Propdt27BOMSTONES As DataTable
    'Public Property _06prop_TotalCPWeight As Decimal = 0
    'Public Property _07prop_TotalFCPWeight As Decimal = 0
    'Public Property _08prop_TotalStonesWeight As Decimal = 0
    'Public Property _09prop_TotalWeight As Decimal = 0
    'Public Property _010prop_imageHeader As Image
    'Public Property _011prop_ImageBOMCastePartImage As Image
    'Public Property _012prop_ImageBOMFcpImage As Image


    Public Property prop_01dtSourceParent As DataTable
    Public Property prop_02dtSourceCastedParts As DataTable
    Public Property prop_03dtSourceFindingComponents As DataTable
    Public Property prop_04dtSourceStone As DataTable
    Public Property prop_05nTotalWeight As Double
    Public Property prop_06objImageHeader As Image
    Public Property prop_07dtSourceRouting As DataTable

#Region "Before : Print"

    Private Sub ParentReport_BeforePrint(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles Me.BeforePrint

        _cm03PreparePrint()

    End Sub

#End Region

#Region "Costum : Method"

    Public Sub _CM01SetLayout()
        BOMHeadPicture.Borders = DevExpress.XtraPrinting.BorderSide.None
        BOMHeadPicture.Sizing = DevExpress.XtraPrinting.ImageSizeMode.Squeeze

        If prop_06objImageHeader IsNot Nothing Then
            BOMHeadPicture.ImageSource = New ImageSource(New Bitmap(prop_06objImageHeader))
        End If

        BOMHeadKodeFinishedGood.Text = "[k01cKodeProduct_v50]"
        BOMHeadKodeDesign.Text = "[f02cKodeDesignMaster_v50]"
        ''BOMHeadf14cProductionTypeDesc_v50.Text = "[f14cProductionTypeDesc_v50]"
        BOMHeadFinishedGoodDesc.Text = "[f01cNamaProduct_v50]"
    End Sub

    Public Sub _cm02SetBackColorTableByMaterial(TypeMaterial As String)
        'Throw New NotImplementedException()
        If TypeMaterial.Equals("GOLD") Then
            'Kuning
            BOMParentTableTotalWeight.BackColor = Color.Gold
            'BOMApprovalHeaderTable.BackColor = Color.Gold
        ElseIf TypeMaterial.Equals("DIAMON") Then
            'Biru
            BOMParentTableTotalWeight.BackColor = Color.LightBlue
            'BOMApprovalHeaderTable.BackColor = Color.LightBlue
        ElseIf TypeMaterial = "SILVER" Then
            'ABu-abu
            BOMParentTableTotalWeight.BackColor = Color.DarkGray
            'BOMApprovalHeaderTable.BackColor = Color.DarkGray
        End If
    End Sub

    Sub _cm03PreparePrint()
        'Parent
        Me.DataSource = prop_01dtSourceParent

        _CM01SetLayout()

        'CastesParts
        If prop_02dtSourceCastedParts.Rows.Count > 0 Then
            Dim objRepCastedPart As New BOMReportCastedParts

            objRepCastedPart.DataSource = prop_02dtSourceCastedParts
            Me.SubReportCastedPart.ReportSource = objRepCastedPart
        End If

        'Finding Components
        If prop_03dtSourceFindingComponents.Rows.Count > 0 Then
            Dim objRepFindingComponents As New BOMReportFCP

            objRepFindingComponents.DataSource = prop_03dtSourceFindingComponents
            Me.SubReportFCP.ReportSource = objRepFindingComponents
        End If

        'Zircon
        If prop_04dtSourceStone.Rows.Count > 0 Then
            Dim objRepStones As New BOMReportStones

            objRepStones.DataSource = prop_04dtSourceStone
            Me.SubReportStones.ReportSource = objRepStones
        End If

        'Report Aproval
        Dim objRepAproval As New BOMReportAproval '-> CITRIX
        Me.SubreportAproval.ReportSource = objRepAproval

        'Routing
        If prop_07dtSourceRouting.Rows.Count > 0 Then
            Dim objRepRouting As New BOMReportRouting

            objRepRouting.DataSource = prop_07dtSourceRouting
            Me.SubReportRouting.ReportSource = objRepRouting
        End If

        'Total Weight
        Me.BOMParentTotalWeight.Text = prop_05nTotalWeight.ToString("N2")

        Me._cm02SetBackColorTableByMaterial("GOLD")

        Me.PaperKind = PaperKind.A4
        Me.Margins = New Margins(50, 50, 50, 60)
    End Sub

    'Public Sub _cm03PrintingDoc(ByVal PrinterName As String, ByVal FGCODE As String, ByVal CopiesTo As Integer)
    '    Dim objPrintSettings As New PrinterSettings

    '    Dim objReportParent As New BOMReportParent
    '    Dim objRepCastedPart As New BOMReportCastedParts
    '    Dim objRepStones As New BOMReportStones
    '    Dim objRepFCP As New BOMReportFCP
    '    Dim objRepRoutingBOM As New BOMReportRouting
    '    Dim objRepBOMAPPROVAL As New BOMReportAPPROVAL

    '    'var data Table
    '    'Dim objDataTableRouting As DataTable
    '    'Dim objDataTabelStones As DataTable
    '    'Dim objDataTabelCp As DataTable
    '    'Dim objDataTabelFcp As DataTable
    '    'Dim objDataTabelParent As DataTable

    '    'Var Total Weight
    '    Dim TotalCPWeight As Decimal = 0
    '    Dim TotalFCPWeight As Decimal = 0
    '    Dim TotalStonesWeight As Decimal = 0
    '    Dim TotalWeight As Decimal = 0

    '    'for (Report perent) => dt24
    '    With objReportParent
    '        .DataSource = _02Propdt24MCFINISHEDGOOD
    '        ._01cImageHeader.Image = _010prop_imageHeader
    '        ' ._cm02SetBackColorTableByMaterial(Material)

    '        'report BOM Approval
    '        .SubReportBOMAPPROVAL.ReportSource = objRepBOMAPPROVAL
    '    End With

    '    'for (Report CastesParts) => dt25
    '    If _03Propdt25BOMCASTEDPARTS.Rows.Count <= 0 Then
    '        objReportParent.SubReportCastedPart.Visible = False
    '    Else
    '        objReportParent.SubReportCastedPart.ReportSource = objRepCastedPart
    '        With objRepCastedPart
    '            .DataSource = _03Propdt25BOMCASTEDPARTS
    '            '._cm02SetBackColorTableByMaterial(Material)
    '            ._01prop_BOMCastePartImage = _011prop_ImageBOMCastePartImage
    '        End With
    '        TotalCPWeight = _06prop_TotalCPWeight
    '    End If

    '    'for (Report Finding Component) => dt26
    '    If _04Propdt26BOMFINDINGCOMPONENT.Rows.Count <= 0 Then
    '        objReportParent.SubReportFCP.Visible = False
    '    Else
    '        objReportParent.SubReportFCP.ReportSource = objRepFCP
    '        With objRepFCP
    '            .DataSource = _04Propdt26BOMFINDINGCOMPONENT
    '            ._01prop_ImageBOMFcpImage = _012prop_ImageBOMFcpImage
    '            '._cm02SetBackColorTableByMaterial(Material)
    '        End With
    '        TotalFCPWeight = _07prop_TotalFCPWeight
    '    End If

    '    'for (Report Stone) => dt27
    '    If _05Propdt27BOMSTONES.Rows.Count <= 0 Then
    '        objReportParent.SubReportStones.Visible = False
    '    Else
    '        objReportParent.SubReportStones.ReportSource = objRepStones
    '        With objRepStones
    '            .DataSource = _05Propdt27BOMSTONES
    '            '_cm02SetBackColorTableByMaterial(Material)
    '        End With
    '        TotalStonesWeight = _08prop_TotalStonesWeight
    '    End If

    '    'for (report RoutingBOM) => dt20
    '    If _01Propdt20MASTERROUTING.Rows.Count <= 0 Then
    '        objReportParent.SubReportRoutingBOM.Visible = False
    '    Else
    '        objReportParent.SubReportRoutingBOM.ReportSource = objRepRoutingBOM
    '        With objRepRoutingBOM
    '            .DataSource = _01Propdt20MASTERROUTING
    '        End With

    '    End If

    '    'Get Total Weight From Field
    '    TotalWeight = TotalCPWeight + TotalFCPWeight + TotalStonesWeight
    '    objReportParent.BOMParentTotalWeight.Text = TotalWeight

    '    objReportParent.PaperKind = PaperKind.A4
    '    objReportParent.Margins = New Margins(50, 50, 50, 50)

    '    objPrintSettings.PrinterName = PrinterName
    '    objPrintSettings.Copies = CopiesTo
    '    objReportParent.ShowPreview
    '    'objReportParent.Print(PrinterName)


    'End Sub


#End Region

End Class