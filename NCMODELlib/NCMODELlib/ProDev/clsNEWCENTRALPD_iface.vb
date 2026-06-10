'********** create .NET Model : INTERFACE (property) ****************

Public Interface clsNEWCENTRALPD_iface
     Inherits IDisposable

    Property prop_KeyString01 As String
    Property prop_KeyString02 As String
    Property prop_keyString03 As String

    Property prop_KeyDate As Date
    Property prop_KeyInteger As Integer
    Property prop_tpDataTable As DataTable

    Sub Save03BOMSTONE()
    Function Sele03BOMSTONE() As DataTable
    Sub Save04BOMMETAL()
    Function Sele04BOMMETAL() As DataTable

    Sub Save05PDPROJECTPLAN()
    Function Sele05PDPROJECTPLAN() As DataTable

    Sub Save06COREJOBCARD()
     Function Sele06COREJOBCARD() as DataTable
     Sub Save07MUTASIJOBCARD()
     Function Sele07MUTASIJOBCARD() as DataTable
     Sub Save08PROSESJOBCARD()
    Function Sele08PROSESJOBCARD() As DataTable
    Function Sele09POSTERJOBCARD() As DataTable
    Function Sele10STOCKPOSTERJOBCARD() As DataTable

    Function GetPDHP01GetMutasiApproveJobCard() As DataTable

    Function GetPDHQ01GetProsesJobCard() As DataTable
    Function GetPDHT01TrackingSKUJobCard() As DataTable

    Sub Save60TANGGALTRANSAKSIPD()
End Interface

'********** end of .NET Model : INTERFACE (property) ****************
