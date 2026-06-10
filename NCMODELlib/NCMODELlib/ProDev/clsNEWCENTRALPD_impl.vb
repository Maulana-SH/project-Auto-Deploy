'********** create .NET Model : IMPLEMENTS (method) ****************

Imports NCCORElib
Imports NCMODELlib

Public Class clsNEWCENTRALPD_impl
    Implements clsNEWCENTRALPD_iface

    Public Property prop_KeyString01 As String Implements clsNEWCENTRALPD_iface.prop_KeyString01

    Public Property prop_KeyString02 As String Implements clsNEWCENTRALPD_iface.prop_KeyString02

    Public Property prop_keyString03 As String Implements clsNEWCENTRALPD_iface.prop_keyString03

    Public Property prop_KeyDate As Date Implements clsNEWCENTRALPD_iface.prop_KeyDate

    Public Property prop_KeyInteger As Integer Implements clsNEWCENTRALPD_iface.prop_KeyInteger

    Public Property prop_tpDataTable As DataTable Implements clsNEWCENTRALPD_iface.prop_tpDataTable

    Public Sub Save06COREJOBCARD() Implements clsNEWCENTRALPD_iface.Save06COREJOBCARD

        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
          .SAKA2011_P6_NameStoredProcedure = "sp06COREJOBCARDSave",
          .SAKA2011_PRM_01Param = "@tp06COREJOBCARD", .SAKA2011_PRM_01Value = prop_tpDataTable}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using

    End Sub

    Public Function Sele06COREJOBCARD() As DataTable Implements clsNEWCENTRALPD_iface.Sele06COREJOBCARD

        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
          .SAKA2011_P3_NamaDataSet = "sp06COREJOBCARDSele",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "sp06COREJOBCARDSele",
          .SAKA2011_PRM_01Param = "@k01cSKUJobCard_v50", .SAKA2011_PRM_01Value = prop_KeyString01}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)

    End Function

    Public Sub Save07MUTASIJOBCARD() Implements clsNEWCENTRALPD_iface.Save07MUTASIJOBCARD

        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
          .SAKA2011_P6_NameStoredProcedure = "sp07MUTASIJOBCARDSave",
          .SAKA2011_PRM_01Param = "@tp07MUTASIJOBCARD", .SAKA2011_PRM_01Value = prop_tpDataTable}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using

    End Sub

    Public Function Sele07MUTASIJOBCARD() As DataTable Implements clsNEWCENTRALPD_iface.Sele07MUTASIJOBCARD

        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
          .SAKA2011_P3_NamaDataSet = "sp07MUTASIJOBCARDSele",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "sp07MUTASIJOBCARDSele",
          .SAKA2011_PRM_01Param = "@k01cSKUJobCard_v50", .SAKA2011_PRM_01Value = prop_KeyString01,
          .SAKA2011_PRM_02Param = "@k02nNoUrutMutasiProses_int", .SAKA2011_PRM_02Value = prop_KeyInteger,
          .SAKA2011_PRM_03Param = "@k03cIDProsesProduksi_v50", .SAKA2011_PRM_03Value = prop_KeyString02}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)

    End Function

    Public Sub Save08PROSESJOBCARD() Implements clsNEWCENTRALPD_iface.Save08PROSESJOBCARD

        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
          .SAKA2011_P6_NameStoredProcedure = "sp08PROSESJOBCARDSave",
          .SAKA2011_PRM_01Param = "@tp08PROSESJOBCARD", .SAKA2011_PRM_01Value = prop_tpDataTable}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using

    End Sub

    Public Function Sele08PROSESJOBCARD() As DataTable Implements clsNEWCENTRALPD_iface.Sele08PROSESJOBCARD

        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
          .SAKA2011_P3_NamaDataSet = "sp08PROSESJOBCARDSele",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "sp08PROSESJOBCARDSele",
          .SAKA2011_PRM_01Param = "@k01cSKUJobCard_v50", .SAKA2011_PRM_01Value = prop_KeyString01,
          .SAKA2011_PRM_02Param = "@k02nNoUrutMutasiProses_int", .SAKA2011_PRM_02Value = prop_KeyInteger,
          .SAKA2011_PRM_03Param = "@k03cIDProsesProduksi_v50", .SAKA2011_PRM_03Value = prop_KeyString02}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)

    End Function

    Public Function Sele09POSTERJOBCARD() As DataTable Implements clsNEWCENTRALPD_iface.Sele09POSTERJOBCARD

        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
          .SAKA2011_P3_NamaDataSet = "sp09POSTERJOBCARDSele",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "sp09POSTERJOBCARDSele",
          .SAKA2011_PRM_01Param = "@k01cSKUJobCard_v50", .SAKA2011_PRM_01Value = prop_KeyString01,
          .SAKA2011_PRM_02Param = "@k02nNoUrutMutasiProses_int", .SAKA2011_PRM_02Value = prop_KeyInteger,
          .SAKA2011_PRM_03Param = "@k03cIDProsesProduksi_v50", .SAKA2011_PRM_03Value = prop_KeyString02}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)

    End Function

    Public Function Sele10STOCKPOSTERJOBCARD() As DataTable Implements clsNEWCENTRALPD_iface.Sele10STOCKPOSTERJOBCARD

        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
          .SAKA2011_P3_NamaDataSet = "sp10STOCKPOSTERJOBCARDSele",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "sp10STOCKPOSTERJOBCARDSele",
          .SAKA2011_PRM_01Param = "@k01dTglStock", .SAKA2011_PRM_01Value = prop_KeyDate,
          .SAKA2011_PRM_02Param = "@k02cSKU_v50", .SAKA2011_PRM_02Value = prop_KeyString01}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)

    End Function

    Public Function GetPDHP01GetMutasiApproveJobCard() As DataTable Implements clsNEWCENTRALPD_iface.GetPDHP01GetMutasiApproveJobCard
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
          .SAKA2011_P3_NamaDataSet = "spPDHP01GetMutasiApproveJobCard",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "spPDHP01GetMutasiApproveJobCard",
          .SAKA2011_PRM_01Param = "@nTarget", .SAKA2011_PRM_01Value = prop_KeyInteger,
          .SAKA2011_PRM_02Param = "@cIDProsesPoster", .SAKA2011_PRM_02Value = prop_KeyString01}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function GetPDHQ01GetProsesJobCard() As DataTable Implements clsNEWCENTRALPD_iface.GetPDHQ01GetProsesJobCard

        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
          .SAKA2011_P3_NamaDataSet = "spPDHQ01GetProsesJobCard",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "spPDHQ01GetProsesJobCard",
          .SAKA2011_PRM_01Param = "@nTarget", .SAKA2011_PRM_01Value = prop_KeyInteger,
          .SAKA2011_PRM_02Param = "@cIDProsesPoster", .SAKA2011_PRM_02Value = prop_KeyString01,
          .SAKA2011_PRM_03Param = "@cNIKTukang", .SAKA2011_PRM_03Value = prop_KeyString02}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)

    End Function

    Public Function GetPDHT01TrackingSKUJobCard() As DataTable Implements clsNEWCENTRALPD_iface.GetPDHT01TrackingSKUJobCard
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
          .SAKA2011_P3_NamaDataSet = "spPDHT01TrackingSKUJobCard",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "spPDHT01TrackingSKUJobCard",
          .SAKA2011_PRM_01Param = "@cSKUJobCard", .SAKA2011_PRM_01Value = prop_KeyString01}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Sub Save03BOMSTONE() Implements clsNEWCENTRALPD_iface.Save03BOMSTONE
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
          .SAKA2011_P6_NameStoredProcedure = "sp03BOMSTONESave",
          .SAKA2011_PRM_01Param = "@tp03BOMSTONE", .SAKA2011_PRM_01Value = prop_tpDataTable,
          .SAKA2011_PRM_02Param = "@nTarget", .SAKA2011_PRM_02Value = prop_KeyInteger}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Function Sele03BOMSTONE() As DataTable Implements clsNEWCENTRALPD_iface.Sele03BOMSTONE
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
          .SAKA2011_P3_NamaDataSet = "sp03BOMSTONESele",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "sp03BOMSTONESele",
          .SAKA2011_PRM_01Param = "@nTarget", .SAKA2011_PRM_01Value = prop_KeyInteger,
          .SAKA2011_PRM_02Param = "@k01cKodeKaret_v50", .SAKA2011_PRM_02Value = prop_KeyString01,
          .SAKA2011_PRM_03Param = "@f18cNoDocumentBOM_v50", .SAKA2011_PRM_03Value = prop_KeyString02}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Sub Save04BOMMETAL() Implements clsNEWCENTRALPD_iface.Save04BOMMETAL
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
          .SAKA2011_P6_NameStoredProcedure = "sp04BOMMETALSave",
          .SAKA2011_PRM_01Param = "@tp04BOMMETAL", .SAKA2011_PRM_01Value = prop_tpDataTable,
          .SAKA2011_PRM_02Param = "@nTarget", .SAKA2011_PRM_02Value = prop_KeyInteger}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Function Sele04BOMMETAL() As DataTable Implements clsNEWCENTRALPD_iface.Sele04BOMMETAL
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
          .SAKA2011_P3_NamaDataSet = "sp04BOMMETALSele",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "sp04BOMMETALSele",
          .SAKA2011_PRM_01Param = "@nTarget", .SAKA2011_PRM_01Value = prop_KeyInteger,
          .SAKA2011_PRM_02Param = "@k01cKodeKaret_v50", .SAKA2011_PRM_02Value = prop_KeyString01,
          .SAKA2011_PRM_03Param = "@f16cNoDocumentBOM_v50", .SAKA2011_PRM_03Value = prop_KeyString02}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using
        Return dsDataSet.Tables(0)
    End Function

    Public Sub Save05PDPROJECTPLAN() Implements clsNEWCENTRALPD_iface.Save05PDPROJECTPLAN
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
          .SAKA2011_P6_NameStoredProcedure = "sp05PDPROJECTPLANSave",
          .SAKA2011_PRM_01Param = "@tp05PDPROJECTPLAN", .SAKA2011_PRM_01Value = prop_tpDataTable}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Function Sele05PDPROJECTPLAN() As DataTable Implements clsNEWCENTRALPD_iface.Sele05PDPROJECTPLAN
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
          .SAKA2011_P3_NamaDataSet = "sp05PDPROJECTPLANSele",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "sp05PDPROJECTPLANSele",
          .SAKA2011_PRM_01Param = "@k01cKodeProjectPD_v50", .SAKA2011_PRM_01Value = prop_KeyString01}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Sub Save60TANGGALTRANSAKSIPD() Implements clsNEWCENTRALPD_iface.Save60TANGGALTRANSAKSIPD
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
          .SAKA2011_P6_NameStoredProcedure = "sp60TANGGALTRANSAKSIPDSave",
          .SAKA2011_PRM_01Param = "@f02cUserID_v50", .SAKA2011_PRM_01Value = prop_KeyString01}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        Me.disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub



#End Region

End Class

'********** end of .NET Model : IMPLEMENTS (method) ****************
