Public Class BOMItem
    Public Property LevelBOM As String         ' e.g. "1.2.1"
    Public Property ParentLevel As String      ' e.g. "1.2"
    Public Property Nama As String             ' e.g. "Sub Komponen"
    Public Property Qty As Decimal
    Public Property Berat As Decimal

    Public ReadOnly Property TotalBerat As Decimal
        Get
            Return Qty * Berat
        End Get
    End Property
End Class