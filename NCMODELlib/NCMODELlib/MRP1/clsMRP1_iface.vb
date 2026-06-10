Public Interface clsMRP1_iface
    Inherits IDisposable

    Property prop_KeyString01 As String
    Property prop_KeyString02 As String
    Property prop_KeyString03 As String
    Property prop_KeyString04 As String
    Property prop_KeyString05 As String

    Property prop_Gambar01 As Byte()

    Property prop_DataTable1 As DataTable

    Sub AddNewGambar()
    Function SeleGambar() As DataTable

End Interface
