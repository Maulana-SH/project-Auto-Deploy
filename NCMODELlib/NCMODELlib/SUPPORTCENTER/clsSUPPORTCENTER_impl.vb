Imports NCCORElib

Public Class clsSUPPORTCENTER_impl
    Implements clsSUPPORTCENTER_iface
#Region " Property  "

    Private disposedValue As Boolean

    Public Property prop_keyString01 As String Implements clsSUPPORTCENTER_iface.prop_keyString01

    Public Property prop_keyString02 As String Implements clsSUPPORTCENTER_iface.prop_keyString02

    Public Property prop_keyString03 As String Implements clsSUPPORTCENTER_iface.prop_keyString03

    Public Property prop_keyString04 As String Implements clsSUPPORTCENTER_iface.prop_keyString04
    Public Property prop_keyString05 As String Implements clsSUPPORTCENTER_iface.prop_keyString05

    Public Property prop_keyInt01 As Integer Implements clsSUPPORTCENTER_iface.prop_keyInt01

    Public Property prop_keyInt02 As Integer Implements clsSUPPORTCENTER_iface.prop_keyInt02

    Public Property prop_keyNumeric As Double Implements clsSUPPORTCENTER_iface.prop_keyNumeric
    Public Property prop_keyDate01 As Date Implements clsSUPPORTCENTER_iface.prop_keyDate01
    Public Property prop_keyDate02 As Date Implements clsSUPPORTCENTER_iface.prop_keyDate02
    Public Property prop_keyDataTable01 As DataTable Implements clsSUPPORTCENTER_iface.prop_keyDataTable01

    Public Property prop_keyDataTable02 As DataTable Implements clsSUPPORTCENTER_iface.prop_keyDataTable02

    Public Property prop_Gambar01 As Byte() Implements clsSUPPORTCENTER_iface.prop_Gambar01
#End Region


#Region " methods Save"

    Public Sub SaveData(ByVal prmNamaStoredProcedure As String) Implements clsSUPPORTCENTER_iface.SaveData
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb07SUPPORTCENTER),
          .SAKA2011_P6_NameStoredProcedure = prmNamaStoredProcedure,
          .SAKA2011_PRM_01Param = "@tpDataForSaving", .SAKA2011_PRM_01Value = prop_keyDataTable01}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub


#End Region

#Region " Method sele"

    Public Function selectNoparam(ByVal prmNamaStoredProcedure As String) As DataTable Implements clsSUPPORTCENTER_iface.selectNoparam
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb07SUPPORTCENTER),
             .SAKA2011_P3_NamaDataSet = prmNamaStoredProcedure,
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = prmNamaStoredProcedure}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function select01targte_01String(ByVal prmNamaStoredProcedure As String) As DataTable Implements clsSUPPORTCENTER_iface.select01targte_01String
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb07SUPPORTCENTER),
             .SAKA2011_P3_NamaDataSet = prmNamaStoredProcedure,
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = prmNamaStoredProcedure,
             .SAKA2011_PRM_01Param = "@nTarget", .SAKA2011_PRM_01Value = prop_keyInt01,
             .SAKA2011_PRM_02Param = "@keyString01", .SAKA2011_PRM_02Value = prop_keyString01}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function select01targte_01String_01Int(ByVal prmNamaStoredProcedure As String) As DataTable Implements clsSUPPORTCENTER_iface.select01targte_01String_01int
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb07SUPPORTCENTER),
             .SAKA2011_P3_NamaDataSet = prmNamaStoredProcedure,
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = prmNamaStoredProcedure,
             .SAKA2011_PRM_01Param = "@nTarget", .SAKA2011_PRM_01Value = prop_keyInt01,
             .SAKA2011_PRM_02Param = "@keyString01", .SAKA2011_PRM_02Value = prop_keyString01,
             .SAKA2011_PRM_03Param = "@keyInt01", .SAKA2011_PRM_03Value = prop_keyInt02}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function select01targte_02String(ByVal prmNamaStoredProcedure As String) As DataTable Implements clsSUPPORTCENTER_iface.select01targte_02String
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb07SUPPORTCENTER),
             .SAKA2011_P3_NamaDataSet = prmNamaStoredProcedure,
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = prmNamaStoredProcedure,
             .SAKA2011_PRM_01Param = "@nTarget", .SAKA2011_PRM_01Value = prop_keyInt01,
             .SAKA2011_PRM_02Param = "@Key_String01", .SAKA2011_PRM_02Value = prop_keyString01,
             .SAKA2011_PRM_03Param = "@Key_String02", .SAKA2011_PRM_03Value = prop_keyString02}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

#End Region

#Region " ID Dispose "

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
