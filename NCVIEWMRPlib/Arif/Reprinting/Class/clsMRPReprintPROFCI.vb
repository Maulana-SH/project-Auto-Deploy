Imports System.IO
Imports NCMODELlib

Public Class clsMRPReprintPROFCI
    Implements IDisposable

    Public Property prop_01cKodeCorePro As String
    Public Property prop_02cKodeFCI As String

#Region "get data source"

    Private Function GetData28COREPRO() As DataTable
        Dim pdHasil28COREPRO As New DataTable
        Using obj28CorePRO As clsMRP_iface = New clsMRP_impl With {.prop_KeyString01 = prop_01cKodeCorePro,
                                                                   .prop_KeyString02 = "",
                                                                   .prop_KeyString03 = ""}
            pdHasil28COREPRO = obj28CorePRO.Sele28COREPRO()
        End Using

        Return pdHasil28COREPRO
    End Function

    Private Function GetData28BOMFCI() As DataTable
        Dim pdHasilBOMFCI As New DataTable
        Using obj28BOMFCI As clsMRP_iface = New clsMRP_impl With {.prop_KeyString01 = prop_02cKodeFCI}
            pdHasilBOMFCI = obj28BOMFCI.Sele28BOMFCI()
        End Using

        Return pdHasilBOMFCI
    End Function

    Private Function GetData29ROUTINGBOM() As DataTable
        Dim pdHasil29ROUTINGBOM As New DataTable
        Using obj29ROUTINGBOM As clsMRP_iface = New clsMRP_impl With {.prop_KeyString01 = prop_02cKodeFCI,
                                                                      .prop_KeyString02 = "",
                                                                      .prop_KeyInt01 = 0,
                                                                      .prop_KeyInt02 = 3}
            pdHasil29ROUTINGBOM = obj29ROUTINGBOM.Sele29ROUTINGBOM()
        End Using

        Return pdHasil29ROUTINGBOM
    End Function

    Private Function GetDataGAMBAR() As DataTable
        Dim pdtGambar As New DataTable
        Using objGambar As clsMRP_iface = New clsMRP_impl With {.prop_KeyInt01 = 1,
                                                                    .prop_KeyString01 = prop_02cKodeFCI,
                                                                    .prop_KeyString02 = ""}
            pdtGambar = objGambar.GetGambarMRP()
        End Using

        Return pdtGambar
    End Function

#End Region

#Region "custom - event"

    Public Sub _cm01DisplayReport()
        Dim pdt28CorePro As New DataTable
        pdt28CorePro = GetData28COREPRO()

        Dim pdt28BOMFCI As New DataTable
        pdt28BOMFCI = GetData28BOMFCI()

        Dim pdt29RoutingBOM As New DataTable
        pdt29RoutingBOM = GetData29ROUTINGBOM()

        Dim pdtGambar As New DataTable
        Dim pobjImage1 As Image = Nothing
        Dim pobjImage2 As Image = Nothing
        Dim pobjImage3 As Image = Nothing

        pdtGambar = GetDataGAMBAR()
        If pdtGambar.Rows.Count > 0 Then
            For Each dtRow As DataRow In pdtGambar.Rows
                If dtRow("f02cKodeFGorComponent_v50") = prop_02cKodeFCI & "_BOM1" Then
                    pobjImage1 = _cm02byteArrayToImage(dtRow("f01objGambar"))
                Else
                    If dtRow("f02cKodeFGorComponent_v50") = prop_02cKodeFCI & "_BOM2" Then
                        pobjImage2 = _cm02byteArrayToImage(dtRow("f01objGambar"))
                    Else
                        If dtRow("f02cKodeFGorComponent_v50") = prop_02cKodeFCI & "_BOM3" Then
                            pobjImage3 = _cm02byteArrayToImage(dtRow("f01objGambar"))
                        End If
                    End If
                End If
            Next
        End If

        Dim objReportPROFCI As New PROPreparationReportParent
        With objReportPROFCI
            ._01prop28BOMFCI = pdt28BOMFCI
            ._02prop28COREPRO = pdt28CorePro
            ._03prop29ROUTINGBOM = pdt29RoutingBOM

            ._04propImg01 = pobjImage1
            ._05propImg02 = pobjImage2
            ._06propImg03 = pobjImage3
        End With
        objReportPROFCI._cm04PrintDoc(prop_01cKodeCorePro)

    End Sub

    Private Function _cm02byteArrayToImage(ByVal byteArrayIn As Byte()) As Image
        Using mStream As MemoryStream = New MemoryStream(byteArrayIn)
            Return Image.FromStream(mStream)
        End Using
    End Function

#End Region

#Region "event - dispose"
    Private disposedValue As Boolean

    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects)
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override finalizer
            ' TODO: set large fields to null
            disposedValue = True
        End If
    End Sub

    ' ' TODO: override finalizer only if 'Dispose(disposing As Boolean)' has code to free unmanaged resources
    ' Protected Overrides Sub Finalize()
    '     ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
    '     Dispose(disposing:=False)
    '     MyBase.Finalize()
    ' End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
        Dispose(disposing:=True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class