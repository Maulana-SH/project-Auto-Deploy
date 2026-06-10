'********** create .NET Controller : clsController33SALESORDER.vb ****************

Public Class clsCtrlMRP33SALESORDER
     Implements IDisposable

Public Property prop_dt33SALESORDER As DataTable

Private Function dtCreate33SALESORDER As DataTable
     Dim dtDataTable As New DataTable

     Dim fieldk01cNomorSalesOrder_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k01cNomorSalesOrder_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldk01cNomorSalesOrder_v50)

     Dim fieldf01cKodeCustomer_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f01cKodeCustomer_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf01cKodeCustomer_v50)

     Dim fieldf02cNamaCustomer_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f02cNamaCustomer_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf02cNamaCustomer_v50)

     Dim fieldf03cKodeSales_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f03cKodeSales_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf03cKodeSales_v50)

     Dim fieldf04cNamaSales_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f04cNamaSales_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf04cNamaSales_v50)

     Dim fieldf05dOrderDate As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.DateTime"), .ColumnName = "f05dOrderDate", .DefaultValue = "3000-01-01"}
     dtDataTable.Columns.Add(fieldf05dOrderDate)

     Dim fieldf06dDeliveryDate As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.DateTime"), .ColumnName = "f06dDeliveryDate", .DefaultValue = "3000-01-01"}
     dtDataTable.Columns.Add(fieldf06dDeliveryDate)

     Dim fieldf07cKeterangan_v150 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f07cKeterangan_v150", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf07cKeterangan_v150)

     Dim fieldf08cKodeProduct_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f08cKodeProduct_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf08cKodeProduct_v50)

     Dim fieldf09cKodeItemProduct_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f09cKodeItemProduct_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf09cKodeItemProduct_v50)

     Dim fieldf10cNamaItemProduct_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f10cNamaItemProduct_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf10cNamaItemProduct_v50)

     Dim fieldf11cKodeColor_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f11cKodeColor_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf11cKodeColor_v50)

     Dim fieldf12cNamaColor_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f12cNamaColor_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf12cNamaColor_v50)

     Dim fieldf13cKodeKadar_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f13cKodeKadar_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf13cKodeKadar_v50)

     Dim fieldf14cNamaKadar_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f14cNamaKadar_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf14cNamaKadar_v50)

     Dim fieldf15cKodeSize_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f15cKodeSize_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf15cKodeSize_v50)

     Dim fieldf16cNamaSize_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f16cNamaSize_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf16cNamaSize_v50)

     Dim fieldf17nAverageWeight_n94 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Double"), .ColumnName = "f17nAverageWeight_n94", .DefaultValue = 0}
     dtDataTable.Columns.Add(fieldf17nAverageWeight_n94)

     Dim fieldf18nQuantity_int As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Int32"), .ColumnName = "f18nQuantity_int", .DefaultValue = 0}
     dtDataTable.Columns.Add(fieldf18nQuantity_int)

     Dim fieldf19nTotalWeight_n94 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Double"), .ColumnName = "f19nTotalWeight_n94", .DefaultValue = 0}
     dtDataTable.Columns.Add(fieldf19nTotalWeight_n94)

     Dim fieldf20nAvailableStock_int As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Int32"), .ColumnName = "f20nAvailableStock_int", .DefaultValue = 0}
     dtDataTable.Columns.Add(fieldf20nAvailableStock_int)

     Dim fieldf21cCatatan_v150 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f21cCatatan_v150", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf21cCatatan_v150)

     Dim fieldf40cIDUser_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f40cIDUser_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf40cIDUser_v50)

     Dim fieldf41cNamaUser_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f41cNamaUser_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf41cNamaUser_v50)

     Dim fieldf42dCreatedDate As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.DateTime"), .ColumnName = "f42dCreatedDate", .DefaultValue = "3000-01-01"}
     dtDataTable.Columns.Add(fieldf42dCreatedDate)

     Return dtDataTable
End Function

Public Sub dtInit33SALESORDER()
     prop_dt33SALESORDER = Nothing
     prop_dt33SALESORDER = dtCreate33SALESORDER()
     prop_dt33SALESORDER.Clear()
End Sub

Public Sub dtAddNew33SALESORDER(ByVal prmk01cNomorSalesOrder_v50 As String,ByVal prmf01cKodeCustomer_v50 As String,ByVal prmf02cNamaCustomer_v50 As String,ByVal prmf03cKodeSales_v50 As String,ByVal prmf04cNamaSales_v50 As String,ByVal prmf05dOrderDate As Date,ByVal prmf06dDeliveryDate As Date,ByVal prmf07cKeterangan_v150 As String,ByVal prmf08cKodeProduct_v50 As String,ByVal prmf09cKodeItemProduct_v50 As String,ByVal prmf10cNamaItemProduct_v50 As String,ByVal prmf11cKodeColor_v50 As String,ByVal prmf12cNamaColor_v50 As String,ByVal prmf13cKodeKadar_v50 As String,ByVal prmf14cNamaKadar_v50 As String,ByVal prmf15cKodeSize_v50 As String,ByVal prmf16cNamaSize_v50 As String,ByVal prmf17nAverageWeight_n94 As Double,ByVal prmf18nQuantity_int As Integer,ByVal prmf19nTotalWeight_n94 As Double,ByVal prmf20nAvailableStock_int As Integer,ByVal prmf21cCatatan_v150 As String,ByVal prmf40cIDUser_v50 As String,ByVal prmf41cNamaUser_v50 As String,ByVal prmf42dCreatedDate As Date)

     Dim oDataRow As DataRow = prop_dt33SALESORDER.NewRow()

     oDataRow("k01cNomorSalesOrder_v50") = prmk01cNomorSalesOrder_v50
     oDataRow("f01cKodeCustomer_v50") = prmf01cKodeCustomer_v50
     oDataRow("f02cNamaCustomer_v50") = prmf02cNamaCustomer_v50
     oDataRow("f03cKodeSales_v50") = prmf03cKodeSales_v50
     oDataRow("f04cNamaSales_v50") = prmf04cNamaSales_v50
     oDataRow("f05dOrderDate") = prmf05dOrderDate
     oDataRow("f06dDeliveryDate") = prmf06dDeliveryDate
     oDataRow("f07cKeterangan_v150") = prmf07cKeterangan_v150
     oDataRow("f08cKodeProduct_v50") = prmf08cKodeProduct_v50
     oDataRow("f09cKodeItemProduct_v50") = prmf09cKodeItemProduct_v50
     oDataRow("f10cNamaItemProduct_v50") = prmf10cNamaItemProduct_v50
     oDataRow("f11cKodeColor_v50") = prmf11cKodeColor_v50
     oDataRow("f12cNamaColor_v50") = prmf12cNamaColor_v50
     oDataRow("f13cKodeKadar_v50") = prmf13cKodeKadar_v50
     oDataRow("f14cNamaKadar_v50") = prmf14cNamaKadar_v50
     oDataRow("f15cKodeSize_v50") = prmf15cKodeSize_v50
     oDataRow("f16cNamaSize_v50") = prmf16cNamaSize_v50
     oDataRow("f17nAverageWeight_n94") = prmf17nAverageWeight_n94
     oDataRow("f18nQuantity_int") = prmf18nQuantity_int
     oDataRow("f19nTotalWeight_n94") = prmf19nTotalWeight_n94
     oDataRow("f20nAvailableStock_int") = prmf20nAvailableStock_int
     oDataRow("f21cCatatan_v150") = prmf21cCatatan_v150
     oDataRow("f40cIDUser_v50") = prmf40cIDUser_v50
     oDataRow("f41cNamaUser_v50") = prmf41cNamaUser_v50
     oDataRow("f42dCreatedDate") = prmf42dCreatedDate

     prop_dt33SALESORDER.Rows.Add(oDataRow)
End Sub

#Region "IDisposable Support"
        Private disposedValue As Boolean ' To detect redundant calls

        ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        Me.disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub

#End Region

End Class

'********** end of .NET Controller : clsController33SALESORDER.vb ****************
