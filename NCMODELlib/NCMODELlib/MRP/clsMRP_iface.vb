'********** create .NET Model : INTERFACE (property) ****************

Public Interface clsMRP_iface
    Inherits IDisposable

    Property prop_KeyString01 As String
    Property prop_KeyString02 As String
    Property prop_KeyString03 As String
    Property prop_KeyString04 As String

    Property prop_KeyInt01 As Integer
    Property prop_KeyInt02 As Integer
    Property prop_KeyInt03Tahun As Int16

    Property prop_KeyDouble01 As Double
    Property prop_KeyDouble02 As Double

    Property prop_KeyDataTable01 As DataTable
    Property prop_KeyDataTable02 As DataTable
    Property prop_KeyDataTable03 As DataTable
    Property prop_KeyDataTable04 As DataTable
    Property prop_KeyDataTable05 As DataTable

    Sub Save20MASTERROUTING()
    Function Sele20MASTERROUTING() As DataTable

    Sub Save21MCRAWMATERIAL()
     Function Sele21MCRAWMATERIAL() as DataTable
     Sub Save22MCFINDINGCOMPONENT()
     Function Sele22MCFINDINGCOMPONENT() as DataTable
     Sub Save23MCSTONES()
    Function Sele23MCSTONES() As DataTable

    Sub Save24MCFINISHEDGOOD()
    Function Sele24MCFINISHEDGOOD() As DataTable
    Function SeleReprint24MCFINISHEDGOOD() As DataTable '=> For Reprinting

    Sub Save24MCMULTIPLE()
    Function Sele24MCMULTIPLE() As DataTable
    Sub Save25BOMCASTEDPARTS()
    Function Sele25BOMCASTEDPARTS() As DataTable
    Sub Save26BOMFINDINGCOMPONENT()
    Function Sele26BOMFINDINGCOMPONENT() As DataTable
    Sub Save27BOMSTONES()
    Function Sele27BOMSTONES() As DataTable

    Sub Save28COREPRO()
    Function Sele28COREPRO() As DataTable
    Function SeleReprint28COREPRO() As DataTable ' => For Reprinting

    Function Sele28BOMFCI() As DataTable

    Sub Save29ROUTINGBOM()
    Function Sele29ROUTINGBOM() As DataTable

    Function Get2122MasterMaterial() As DataTable
    Function Get2122MaterialBOMForPRO() As DataTable

    Function GetGambar() As DataTable
    Function GetGambarMRP() As DataTable
    Function GetImageTypeFGorComponent() As DataTable
    Function GetImageFromGUID() As DataTable

    Sub Save02GAMBARTRANSAKSI()
    Function Sele02GAMBARTRANSAKSI() As DataTable


    Sub SaveHeaderBOM()

    Function Get30CreateSKUJobCard() As DataTable
    Sub Save30DESIGNMASTER()
    Function Sele30DESIGNMASTER() As DataTable
    Sub Save31DESIGNMASTERSTONE()
    Function Sele31DESIGNMASTERSTONE() As DataTable

    Sub Save3031AllSaveDesignMaster()

    Sub Save32PRODUCT()
    Function Sele32PRODUCT() As DataTable
    Function GetTEST() As DataTable

    Sub Save33SALESORDER()
    Function Sele33SALESORDER() As DataTable

    Sub Save34RUBBERSILVERMASTER()
    Function Sele34RUBBERSILVERMASTER() As DataTable
    Function Get34JumlahRubberSilverCode() As DataTable

    Sub Save35JOBCARD()
    Function Sele35JOBCARD() As DataTable

    Sub Save36JOBCARDBOM()
    Function Sele36JOBCARDBOM() As DataTable

    Sub Save37JOBCARDSTONE()
    Function Sele37JOBCARDSTONE() As DataTable
    Function sele21FG01ReprintGP() As DataTable

    Function Sele21GetProductAPI() As DataTable

    Sub SaveGambarJOBCARD3D()

    Function Get51MasterAllNewSKK() As DataTable

    Function Get52CreateIDNumbering() As DataTable

    Sub SaveDataExecl()

    Sub SaveGambarDONE()


    'hanya untuk Testing datagrid saja
    Function seleGambarProduct() As DataTable


    Function Sele30RFIDCODE() As DataTable
    Function Get01COMPLAINMANAGEMENT() As DataTable


    Function seleGet_Castedpart() As DataTable
    Function sele446MASTERVAULT() As DataTable

    Function sele01WS() As DataTable
    Sub save01WS()
End Interface

'********** end of .NET Model : INTERFACE (property) ****************
