Imports System.IO
Imports DevExpress.XtraReports.UI
Imports NCMODELlib

Public Class clsMRPReprintPRO
    Implements IDisposable

    Public Property prop_01cProductCode As String
    Public Property prop_02cPRONumber As String
    Public Property prop_03PrintCopies As Int32

    Private pdt25 As New DataTable
    Private pdt26 As New DataTable
    Private pdt27 As New DataTable
    Private pdt29 As New DataTable

    Private objImageFull As Image = Nothing
    Private objImageKerja1 As Image = Nothing
    Private objImageKerja2 As Image = Nothing
    Private objImageKerja3 As Image = Nothing

#Region "Get Data-Source"

    Private Function _cmGetData25BOMCASTEDPARTS() As DataTable
        Dim pdtHasil25 As New DataTable
        Using obj25 As clsMRP_iface = New clsMRP_impl With {.prop_KeyString01 = prop_01cProductCode,
                                                            .prop_KeyString02 = "",
                                                            .prop_KeyString03 = "",
                                                            .prop_KeyString04 = ""}
            pdtHasil25 = obj25.Sele25BOMCASTEDPARTS()
        End Using

        Return pdtHasil25
    End Function

    Private Function _cmGetData26BOMFINDINGCOMPONENT() As DataTable
        Dim pdtHasil26 As New DataTable
        Using obj26 As clsMRP_iface = New clsMRP_impl With {.prop_KeyString01 = prop_01cProductCode,
                                                            .prop_KeyString02 = "",
                                                            .prop_KeyString03 = ""}
            pdtHasil26 = obj26.Sele26BOMFINDINGCOMPONENT
        End Using

        Return pdtHasil26
    End Function

    Private Function _cmGetData27BOMSTONES() As DataTable
        Dim pdtHasil27 As New DataTable
        Using obj27 As clsMRP_iface = New clsMRP_impl With {.prop_KeyString01 = prop_01cProductCode,
                                                            .prop_KeyString02 = "",
                                                            .prop_KeyString03 = ""}
            pdtHasil27 = obj27.Sele27BOMSTONES()
        End Using

        Return pdtHasil27
    End Function

    Private Function _cmGetData29ROUTINGBOM() As DataTable
        Dim pdtHasil29 As New DataTable
        Using obj29 As clsMRP_iface = New clsMRP_impl With {.prop_KeyString01 = prop_01cProductCode,
                                                            .prop_KeyString02 = "",
                                                            .prop_KeyInt01 = 0,
                                                            .prop_KeyInt02 = 3}
            pdtHasil29 = obj29.Sele29ROUTINGBOM
        End Using

        Return pdtHasil29
    End Function

    Private Function _cmGetData32PRODUCT() As DataTable
        Dim pdtHasil32 As New DataTable
        Using obj32 As clsMRP_iface = New clsMRP_impl With {.prop_KeyInt01 = 2,
                                                            .prop_KeyString01 = prop_01cProductCode,
                                                            .prop_KeyString02 = ""}
            pdtHasil32 = obj32.Sele32PRODUCT()
        End Using

        Return pdtHasil32
    End Function

    Private Sub _cmGetDataImageBOMFG()

        Dim pdtHasilImage As New DataTable
        Using objGambar As clsMRP_iface = New clsMRP_impl With {.prop_KeyInt01 = 2,
                                                                .prop_KeyString01 = "",
                                                                .prop_KeyString02 = prop_01cProductCode}
            pdtHasilImage = objGambar.GetGambarMRP()
        End Using

        objImageFull = Nothing
        If pdtHasilImage.Rows.Count > 0 Then

            For Each dtRow As DataRow In pdtHasilImage.Rows
                objImageFull = _cm01byteArrayToImage(dtRow("f01objGambar"))
            Next
        End If
    End Sub

    Private Function _cm01byteArrayToImage(ByVal byteArrayIn As Byte()) As Image
        Using mStream As MemoryStream = New MemoryStream(byteArrayIn)
            Return Image.FromStream(mStream)
        End Using
    End Function

    Private Sub _cmGetDataImagePROFG()
        'get data gambar
        Dim pdtHasil As DataTable
        Using objSele As clsMRP_iface = New clsMRP_impl With {.prop_KeyInt01 = 3,
                                                              .prop_KeyString01 = "",
                                                              .prop_KeyString02 = prop_01cProductCode}
            pdtHasil = objSele.GetGambarMRP()
        End Using

        If pdtHasil.Rows.Count > 0 Then
            objImageFull = Nothing
            objImageKerja1 = Nothing
            objImageKerja2 = Nothing
            objImageKerja3 = Nothing

            For Each dtRow As DataRow In pdtHasil.Rows
                Select Case dtRow("f02cKodeFGorComponent_v50")
                    Case prop_01cProductCode
                        objImageFull = _cm01byteArrayToImage(dtRow("f01objGambar"))
                    Case prop_01cProductCode + "_1"
                        objImageKerja1 = _cm01byteArrayToImage(dtRow("f01objGambar"))
                    Case prop_01cProductCode + "_2"
                        objImageKerja2 = _cm01byteArrayToImage(dtRow("f01objGambar"))
                    Case prop_01cProductCode + "_3"
                        objImageKerja3 = _cm01byteArrayToImage(dtRow("f01objGambar"))
                End Select
            Next
        End If
    End Sub

    Private Sub _cmCollectDataBOM()
        pdt25 = _cmGetData25BOMCASTEDPARTS()
        pdt26 = _cmGetData26BOMFINDINGCOMPONENT()
        pdt27 = _cmGetData27BOMSTONES()
        pdt29 = _cmGetData29ROUTINGBOM()
    End Sub

#End Region

#Region "Set report Preview"

    ' ==> Untk BOM

    Public Sub _01DisplayReportBOMFG()
        _cmCollectDataBOM()
        _cmGetDataImageBOMFG()

        Dim pdt32 As New DataTable
        pdt32 = _cmGetData32PRODUCT()

        Dim nTotGramCastedPart As Decimal = 0
        Dim nTotGramFinding As Decimal = 0
        Dim nTotGramStone As Decimal = 0

        If pdt25.Rows.Count > 0 Then
            nTotGramCastedPart = pdt25.Compute("SUM(f03nBerat_n92)", Nothing)
        End If

        If pdt26.Rows.Count > 0 Then
            nTotGramFinding = pdt26.Compute("SUM(f03nBerat_n92)", Nothing)
        End If

        If pdt27.Rows.Count > 0 Then
            nTotGramStone = pdt27.Compute("SUM(f06nBeratGram_n93)", Nothing)
        End If

        Dim TotalWeight As Double = nTotGramCastedPart + nTotGramFinding + nTotGramStone

        Dim objReportBOMFG As New BOMReportParent

        With objReportBOMFG
            .prop_01dtSourceParent = pdt32
            .prop_02dtSourceCastedParts = pdt25
            .prop_03dtSourceFindingComponents = pdt26
            .prop_04dtSourceStone = pdt27
            .prop_05nTotalWeight = TotalWeight
            .prop_06objImageHeader = objImageFull
            .prop_07dtSourceRouting = pdt29
        End With

        objReportBOMFG.ShowPreview
    End Sub

    ' ==> Untk Production Order
    Public Sub _02DisplayReportPROFG()

        Dim pdt28COREPRO As New DataTable
        Using obj28CorePro As clsMRP_iface = New clsMRP_impl With {.prop_KeyString01 = prop_02cPRONumber,
                                                                   .prop_KeyString02 = "",
                                                                   .prop_KeyString03 = ""}
            pdt28COREPRO = obj28CorePro.Sele28COREPRO()
        End Using

        Dim pcProductCode As String = ""
        Dim pck01cNoPRO_v50 As String = ""
        Dim pcf12cBrandDesc_v50 As String = ""
        Dim pnf03nLot_int As Int32 = 0

        If pdt28COREPRO.Rows.Count > 0 Then
            For Each dtRow As DataRow In pdt28COREPRO.Rows
                pcProductCode = dtRow("k02cKodeMaterialOrFG_v50")
                pck01cNoPRO_v50 = dtRow("k01cNoPRO_v50")
                pcf12cBrandDesc_v50 = dtRow("f12cBrandDesc_v50")
                pnf03nLot_int = dtRow("f03nLot_int")
            Next
        End If

        If pcProductCode <> "" Then
            Me.prop_01cProductCode = pcProductCode

            _cmCollectDataBOM()
            _cmGetDataImagePROFG()

            Dim objReportPROFG As New PROReportParent
            With objReportPROFG
                ._01Prop_DsReportHeadert28 = pdt28COREPRO
                ._02Prop_DsReportBOMCASTEDPARTS25 = pdt25
                ._03Prop_DsReportBOMFINDINGCOMPONENT26 = pdt26
                ._04Prop_DsReportBOMSTONES27 = pdt27
                ._05PropdtMasterRoutingByFGCODE = pdt29

                ._06prop_IMGBRJ = objImageFull
                ._07prop_IMGTampak01 = objImageKerja1
                ._08prop_IMGTampak02 = objImageKerja2
                ._09prop_IMGTampak03 = objImageKerja3

                ._012Prop_NoSKUPRO = pck01cNoPRO_v50
                '.prop_11cBrand = pcf12cBrandDesc_v50
                '.prop_12nLot = pnf03nLot_int
            End With
            ' objReportPROFG.ShowPreview

            objReportPROFG._cm01PreparePrintSHow()


        End If
    End Sub

#End Region


#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        ' TODO: uncomment the following line if Finalize() is overridden above.
        ' GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
