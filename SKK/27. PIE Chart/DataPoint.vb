Public Class DataPoint
    Public Property Argument() As String
    Public Property Value() As Double
    Public Property Color() As String

    Public Shared Function GetDataPoints() As List(Of DataPoint)
        Return New List(Of DataPoint) From {
            New DataPoint With {.Argument = "SBC", .Value = 650, .Color = "255; 255; 0"},
            New DataPoint With {.Argument = "LM", .Value = 250, .Color = "255;192;0 "},
            New DataPoint With {.Argument = "ALLOY", .Value = 250, .Color = "198; 217; 240"}
        }
    End Function
End Class
