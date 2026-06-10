Public Class arisnjp01General_clsDatabaseAndServer
    Implements IDisposable

    Public Enum SAKA2011ServerLokasi
        arisnjp_Server = 1
    End Enum

    Public Shared Function SAKA2011ServerLokasiName(ByVal prmcaiONE_Server As SAKA2011ServerLokasi) As String
        SAKA2011ServerLokasiName = ""

        Select Case prmcaiONE_Server
            Case 1
                SAKA2011ServerLokasiName = arisnjp01General_clsVariabelGlobal.prop_arisnjp11svrAddress
        End Select

        Return SAKA2011ServerLokasiName
        'Return SAKA2011ServerLokasiName = arisnjp01General_clsVariabelGlobal.prop_arisnjp11svrAddress
    End Function

    Public Enum SAKA2011Database
        arisnjpdb01NC = 1
        arisnjpdb02aris18 = 2
        arisnjpdb03aris18harian = 3

        arisnjpdb04MRP = 4
        arisnjpdb03GAMBAR = 5
        arisnjpdb06PRODUCTION = 6
        arisnjpdb07SUPPORTCENTER = 7
        arisnjpdb08WS = 8

    End Enum

    Public Shared Function SAKA2011DatabaseName(ByVal prmcaiONE_Database As SAKA2011Database) As String
        SAKA2011DatabaseName = ""

        Select Case prmcaiONE_Database
           
            Case 1
                SAKA2011DatabaseName = arisnjp01General_clsVariabelGlobal.prop_arisnjpdb01NC
            'Case 2
            '    SAKA2011DatabaseName = arisnjp01General_clsVariabelGlobal.prop_db01aris18
            'Case 3
            '    SAKA2011DatabaseName = arisnjp01General_clsVariabelGlobal.prop_db01aris18harian
            Case 4
                SAKA2011DatabaseName = arisnjp01General_clsVariabelGlobal.prop_arisnjpdb02MRP
            Case 5
                SAKA2011DatabaseName = arisnjp01General_clsVariabelGlobal.prop_arisnjpdb03GAMBAR
            Case 6
                SAKA2011DatabaseName = arisnjp01General_clsVariabelGlobal.prop_arisnjpdb04PRODUCTION
            Case 7
                SAKA2011DatabaseName = arisnjp01General_clsVariabelGlobal.prop_arisnjpdb05SUPPORTCENTER
            Case 8
                SAKA2011DatabaseName = arisnjp01General_clsVariabelGlobal.prop_arisnjpdb09WS
            Case Else
        End Select

        Return SAKA2011DatabaseName
    End Function

    Public Shared Function SAKA2011_NET_ConnectionSTRING(ByVal prmcNASA_Server As String, ByVal prmcNamaDatabase As String) As String
        Dim pcAdmin As String = arisnjp01General_clsVariabelGlobal.prop_arisnjp12UserSQL
        Dim pcKey As String = arisnjp01General_clsVariabelGlobal.prop_arisnjp13Keys

        Dim pcNASA_Str As String = String.Format("Server = {0};Database = {1};USER ID = {2};PASSWORD= {3}", prmcNASA_Server, prmcNamaDatabase, pcAdmin, pcKey)

        Return pcNASA_Str
    End Function

    Public Shared Function SAKA2011_NET_ExecuteNonQuery(ByVal prmcSQL As String, ByVal prmcServer As SAKA2011ServerLokasi, ByVal prmcNamaDatabase As SAKA2011Database) As Boolean

        Dim plHasil As Boolean = False

        Using objExe As New arisnjp01General_clsDatabaseExecution() With {
                                         .SAKA2011_P1_Server = SAKA2011ServerLokasiName(prmcServer),
                                         .SAKA2011_P1_NamaDatabaseTarget = SAKA2011DatabaseName(prmcNamaDatabase),
                                         .SAKA2011_P2_PerintahSQL = prmcSQL}
            plHasil = objExe.SAKA2011_2_ExecuteNonQuery_P1P2("I", False)
        End Using

        Return plHasil
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

    ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
