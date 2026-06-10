
Public Class MasterCOA
    'Kode	NameInd	NameEng	Id	ParentId	Lvl 

    Public Property kodeMaster() As String
    Public Property NamaMaster() As String
    Public Property NamaMaster2() As String
    Public Property IdMaster() As String
    Public Property ParentId() As String
    Public Property LevelMaster() As String

    Public Sub New(ByVal prmKodeMaster As String, ByVal prmNamaMaster As String, ByVal prmNamaMaser2 As String, ByVal prmIdMaster As String, ByVal prmParentId As String, ByVal prmLevelMaster As String)
        Me.kodeMaster = prmKodeMaster
        Me.NamaMaster = prmNamaMaster
        Me.NamaMaster2 = prmNamaMaser2
        Me.IdMaster = prmIdMaster
        Me.ParentId = prmParentId
        Me.LevelMaster = prmLevelMaster
    End Sub


End Class
