Public Interface clsSUPPORTCENTER_iface
    Inherits IDisposable

#Region "property"
    Property prop_keyString01 As String
    Property prop_keyString02 As String
    Property prop_keyString03 As String
    Property prop_keyString04 As String
    Property prop_keyString05 As String

    Property prop_keyInt01 As Integer
    Property prop_keyInt02 As Integer

    Property prop_keyNumeric As Double

    Property prop_keyDate01 As Date
    Property prop_keyDate02 As Date

    Property prop_keyDataTable01 As DataTable
    Property prop_keyDataTable02 As DataTable

    Property prop_Gambar01 As Byte()
#End Region

    Sub SaveData(ByVal prmNamaStoredProcedure As String)

    Function selectNoparam(ByVal prmNamaStoredProcedure As String) As DataTable
    Function select01targte_01String(ByVal prmNamaStoredProcedure As String) As DataTable
    Function select01targte_01String_01int(ByVal prmNamaStoredProcedure As String) As DataTable
    Function select01targte_02String(ByVal prmNamaStoredProcedure As String) As DataTable

End Interface
