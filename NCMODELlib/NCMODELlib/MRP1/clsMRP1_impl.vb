Imports NCCORElib

Public Class clsMRP1_impl
    Implements clsMRP1_iface

    Public Property prop_KeyString01 As String Implements clsMRP1_iface.prop_KeyString01

    Public Property prop_KeyString02 As String Implements clsMRP1_iface.prop_KeyString02

    Public Property prop_KeyString03 As String Implements clsMRP1_iface.prop_KeyString03

    Public Property prop_KeyString04 As String Implements clsMRP1_iface.prop_KeyString04

    Public Property prop_KeyString05 As String Implements clsMRP1_iface.prop_KeyString05

    Public Property prop_Gambar01 As Byte() Implements clsMRP1_iface.prop_Gambar01

    Public Property prop_DataTable1 As DataTable Implements clsMRP1_iface.prop_DataTable1


    Public Sub AddNewGambar() Implements clsMRP1_iface.AddNewGambar
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb03GAMBAR),
             .SAKA2011_P6_NameStoredProcedure = "spGambarAdd",
             .SAKA2011_PRM_01Param = "@k01cKodeGambar_v50", .SAKA2011_PRM_01Value = prop_KeyString01,
             .SAKA2011_PRM_02Param = "@f01objGambar", .SAKA2011_PRM_02Value = prop_Gambar01,
             .SAKA2011_PRM_03Param = "@f02cKodeFGorComponent_v50", .SAKA2011_PRM_03Value = prop_KeyString02,
             .SAKA2011_PRM_04Param = "@f03cKodeWarna_v50", .SAKA2011_PRM_04Value = prop_KeyString03,
             .SAKA2011_PRM_05Param = "@f21cUserId_v50", .SAKA2011_PRM_05Value = prop_KeyString04,
             .SAKA2011_PRM_06Param = "@f22cUserName_v50", .SAKA2011_PRM_06Value = prop_KeyString05}
            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Function SeleGambar() As DataTable Implements clsMRP1_iface.SeleGambar
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb03GAMBAR),
             .SAKA2011_P3_NamaDataSet = "spGambarSelect",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "spGambarSelect",
             .SAKA2011_PRM_01Param = "@k01cKodeGambar_v50", .SAKA2011_PRM_01Value = prop_KeyString01}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function


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
