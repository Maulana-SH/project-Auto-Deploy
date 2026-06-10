Public Class xfLoadingFULL
    Implements IDisposable

    Public Property Caption As String
    Public Property Desc As String

    Public Sub _setLoding()
        With _pgLoding
            .Caption = Caption
            .Description = Desc
        End With
    End Sub

End Class