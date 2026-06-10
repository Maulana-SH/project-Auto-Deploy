Friend Class MenuMaster
    Private checklis As Boolean
    Private Id As Integer
    Private name As String
    Private parentId As Integer
    Private svgImage As String

    Public Sub New(checklis As Integer, Id As Integer, name As String, parentId As Integer, svgImage As String)
        Me.checklis = checklis
        Me.Id = Id
        Me.name = name
        Me.parentId = parentId
        Me.svgImage = svgImage
    End Sub
End Class
