'********** create .NET Controller : clsController28COREPRO.vb ****************

Public Class clsCtrlMRP28COREPRO
     Implements IDisposable

Public Property prop_dt28COREPRO As DataTable

Private Function dtCreate28COREPRO As DataTable
        Dim dtDataTable As New DataTable

        Dim fieldk01cNoPRO_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k01cNoPRO_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldk01cNoPRO_v50)

        Dim fieldk02cKodeMaterialOrFG_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k02cKodeMaterialOrFG_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldk02cKodeMaterialOrFG_v50)

        Dim fieldk03cVersionBOM_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k03cVersionBOM_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldk03cVersionBOM_v50)

        Dim fieldf01cNoSalesOrder_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f01cNoSalesOrder_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf01cNoSalesOrder_v50)

     Dim fieldf02MaterialOrFGDesc_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f02MaterialOrFGDesc_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf02MaterialOrFGDesc_v50)

     Dim fieldf03nLot_int As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Int32"), .ColumnName = "f03nLot_int", .DefaultValue = 0}
     dtDataTable.Columns.Add(fieldf03nLot_int)

     Dim fieldf04nBerat_n92 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Double"), .ColumnName = "f04nBerat_n92", .DefaultValue = 0}
     dtDataTable.Columns.Add(fieldf04nBerat_n92)

     Dim fieldf05cEngrave_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f05cEngrave_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf05cEngrave_v50)

     Dim fieldf06cKodeOrderStatus_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f06cKodeOrderStatus_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf06cKodeOrderStatus_v50)

     Dim fieldf07cOrderStatusDesc_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f07cOrderStatusDesc_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf07cOrderStatusDesc_v50)

     Dim fieldf08dOrderDate As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.DateTime"), .ColumnName = "f08dOrderDate", .DefaultValue = "3000-01-01"}
     dtDataTable.Columns.Add(fieldf08dOrderDate)

     Dim fieldf09dDeliveryDate As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.DateTime"), .ColumnName = "f09dDeliveryDate", .DefaultValue = "3000-01-01"}
     dtDataTable.Columns.Add(fieldf09dDeliveryDate)

     Dim fieldf10cMTOS_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f10cMTOS_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf10cMTOS_v50)

     Dim fieldf11cKodeBrand_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f11cKodeBrand_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf11cKodeBrand_v50)

     Dim fieldf12cBrandDesc_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f12cBrandDesc_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf12cBrandDesc_v50)

     Dim fieldf13cKodeCustomer_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f13cKodeCustomer_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf13cKodeCustomer_v50)

     Dim fieldf14cCustomerDesc_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f14cCustomerDesc_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf14cCustomerDesc_v50)

     Dim fieldf15cKodeProject_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f15cKodeProject_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf15cKodeProject_v50)

     Dim fieldf16cProjectDesc_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f16cProjectDesc_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf16cProjectDesc_v50)

     Dim fieldf17cNamaProduk_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f17cNamaProduk_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf17cNamaProduk_v50)

     Dim fieldf18cKodeItemBRJ_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f18cKodeItemBRJ_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf18cKodeItemBRJ_v50)

     Dim fieldf19cItemBRJDesc_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f19cItemBRJDesc_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf19cItemBRJDesc_v50)

     Dim fieldf20cKodeWarnaFG_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f20cKodeWarnaFG_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf20cKodeWarnaFG_v50)

     Dim fieldf21cWarnaFGDesc_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f21cWarnaFGDesc_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf21cWarnaFGDesc_v50)

     Dim fieldf22cKodeKadar_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f22cKodeKadar_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf22cKodeKadar_v50)

     Dim fieldf23cKadarDesc_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f23cKadarDesc_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf23cKadarDesc_v50)

     Dim fieldf24cSize_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f24cSize_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf24cSize_v50)

     Dim fieldf25cNotes_v250 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f25cNotes_v250", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf25cNotes_v250)

     Dim fieldf30cIDUser_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f30cIDUser_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf30cIDUser_v50)

     Dim fieldf31cNamaUser_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f31cNamaUser_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf31cNamaUser_v50)

     Dim fieldf32dCreatedDate As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.DateTime"), .ColumnName = "f32dCreatedDate", .DefaultValue = "3000-01-01"}
     dtDataTable.Columns.Add(fieldf32dCreatedDate)



        Return dtDataTable
End Function

Public Sub dtInit28COREPRO()
     prop_dt28COREPRO = Nothing
     prop_dt28COREPRO = dtCreate28COREPRO()
     prop_dt28COREPRO.Clear()
End Sub

    Public Sub dtAddNew28COREPRO(ByVal prmk01cNoPRO_v50 As String, ByVal prmk02cKodeMaterialOrFG_v50 As String, ByVal prmk03cVersionBOM_v50 As String,
                                 ByVal prmf01cNoSalesOrder_v50 As String, ByVal prmf02MaterialOrFGDesc_v50 As String, ByVal prmf03nLot_int As Integer,
                                 ByVal prmf04nBerat_n92 As Double, ByVal prmf05cEngrave_v50 As String, ByVal prmf06cKodeOrderStatus_v50 As String,
                                 ByVal prmf07cOrderStatusDesc_v50 As String, ByVal prmf08dOrderDate As Date, ByVal prmf09dDeliveryDate As Date,
                                 ByVal prmf10cMTOS_v50 As String, ByVal prmf11cKodeBrand_v50 As String, ByVal prmf12cBrandDesc_v50 As String,
                                 ByVal prmf13cKodeCustomer_v50 As String, ByVal prmf14cCustomerDesc_v50 As String, ByVal prmf15cKodeProject_v50 As String,
                                 ByVal prmf16cProjectDesc_v50 As String, ByVal prmf17cNamaProduk_v50 As String, ByVal prmf18cKodeItemBRJ_v50 As String,
                                 ByVal prmf19cItemBRJDesc_v50 As String, ByVal prmf20cKodeWarnaFG_v50 As String, ByVal prmf21cWarnaFGDesc_v50 As String,
                                 ByVal prmf22cKodeKadar_v50 As String, ByVal prmf23cKadarDesc_v50 As String, ByVal prmf24cSize_v50 As String,
                                 ByVal prmf25cNotes_v250 As String, ByVal prmf30cIDUser_v50 As String, ByVal prmf31cNamaUser_v50 As String,
                                 ByVal prmf32dCreatedDate As Date)

        Dim oDataRow As DataRow = prop_dt28COREPRO.NewRow()

        oDataRow("k01cNoPRO_v50") = prmk01cNoPRO_v50
        oDataRow("k02cKodeMaterialOrFG_v50") = prmk02cKodeMaterialOrFG_v50
        oDataRow("k03cVersionBOM_v50") = prmk03cVersionBOM_v50
        oDataRow("f01cNoSalesOrder_v50") = prmf01cNoSalesOrder_v50
        oDataRow("f02MaterialOrFGDesc_v50") = prmf02MaterialOrFGDesc_v50
        oDataRow("f03nLot_int") = prmf03nLot_int
        oDataRow("f04nBerat_n92") = prmf04nBerat_n92
        oDataRow("f05cEngrave_v50") = prmf05cEngrave_v50
        oDataRow("f06cKodeOrderStatus_v50") = prmf06cKodeOrderStatus_v50
        oDataRow("f07cOrderStatusDesc_v50") = prmf07cOrderStatusDesc_v50
        oDataRow("f08dOrderDate") = prmf08dOrderDate
        oDataRow("f09dDeliveryDate") = prmf09dDeliveryDate
        oDataRow("f10cMTOS_v50") = prmf10cMTOS_v50
        oDataRow("f11cKodeBrand_v50") = prmf11cKodeBrand_v50
        oDataRow("f12cBrandDesc_v50") = prmf12cBrandDesc_v50
        oDataRow("f13cKodeCustomer_v50") = prmf13cKodeCustomer_v50
        oDataRow("f14cCustomerDesc_v50") = prmf14cCustomerDesc_v50
        oDataRow("f15cKodeProject_v50") = prmf15cKodeProject_v50
        oDataRow("f16cProjectDesc_v50") = prmf16cProjectDesc_v50
        oDataRow("f17cNamaProduk_v50") = prmf17cNamaProduk_v50
        oDataRow("f18cKodeItemBRJ_v50") = prmf18cKodeItemBRJ_v50
        oDataRow("f19cItemBRJDesc_v50") = prmf19cItemBRJDesc_v50
        oDataRow("f20cKodeWarnaFG_v50") = prmf20cKodeWarnaFG_v50
        oDataRow("f21cWarnaFGDesc_v50") = prmf21cWarnaFGDesc_v50
        oDataRow("f22cKodeKadar_v50") = prmf22cKodeKadar_v50
        oDataRow("f23cKadarDesc_v50") = prmf23cKadarDesc_v50
        oDataRow("f24cSize_v50") = prmf24cSize_v50
        oDataRow("f25cNotes_v250") = prmf25cNotes_v250
        oDataRow("f30cIDUser_v50") = prmf30cIDUser_v50
        oDataRow("f31cNamaUser_v50") = prmf31cNamaUser_v50
        oDataRow("f32dCreatedDate") = prmf32dCreatedDate

        prop_dt28COREPRO.Rows.Add(oDataRow)
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

'********** end of .NET Controller : clsController28COREPRO.vb ****************
