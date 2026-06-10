'********** create .NET Controller : clsControllerINISHGOODWHMasters.vb ****************

Public Class clsControllerINISHGOODWHMasters
     Implements IDisposable

Public Property prop_dtINISHGOODWHMasters As DataTable

Private Function dtCreateINISHGOODWHMasters As DataTable
     Dim dtDataTable As New DataTable

     Dim fieldId As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Int32"), .ColumnName = "Id", .DefaultValue = 0}
     dtDataTable.Columns.Add(fieldId)

     Dim fieldk02SPK As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k02SPK", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldk02SPK)

     Dim fieldk03ProductCode As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k03ProductCode", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldk03ProductCode)

     Dim fieldNamaNORO As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "NamaNORO", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldNamaNORO)

     Dim fieldNamaWarnaEmas As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "NamaWarnaEmas", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldNamaWarnaEmas)

     Dim fieldNamaSize As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "NamaSize", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldNamaSize)

     Dim fieldNamaBrand As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "NamaBrand", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldNamaBrand)

     Dim fieldOrderStatus As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "OrderStatus", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldOrderStatus)

     Dim fieldNoDocument As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "NoDocument", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldNoDocument)

     Dim fieldPCSSKU As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Int32"), .ColumnName = "PCSSKU", .DefaultValue = 0}
     dtDataTable.Columns.Add(fieldPCSSKU)

        Dim fieldBeratGrosss As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Double"), .ColumnName = "BeratGrosss", .DefaultValue = 0}
        dtDataTable.Columns.Add(fieldBeratGrosss)

        Dim fieldBeratNett As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Double"), .ColumnName = "BeratNett", .DefaultValue = 0}
        dtDataTable.Columns.Add(fieldBeratNett)

     Dim fieldf01Datetime As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.DateTime"), .ColumnName = "f01Datetime", .DefaultValue = "3000-01-01"}
     dtDataTable.Columns.Add(fieldf01Datetime)

     Dim fieldf01NamaUser As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f01NamaUser", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf01NamaUser)

     Return dtDataTable
End Function

Public Sub dtInitINISHGOODWHMasters()
     prop_dtINISHGOODWHMasters = Nothing
     prop_dtINISHGOODWHMasters = dtCreateINISHGOODWHMasters()
     prop_dtINISHGOODWHMasters.Clear()
End Sub

    Public Sub dtAddNewINISHGOODWHMasters(ByVal prmId As Integer, ByVal prmk02SPK As String, ByVal prmk03ProductCode As String, ByVal prmNamaNORO As String, ByVal prmNamaWarnaEmas As String, ByVal prmNamaSize As String, ByVal prmNamaBrand As String, ByVal prmOrderStatus As String, ByVal prmNoDocument As String, ByVal prmPCSSKU As Integer, ByVal prmBeratGrosss As Double, ByVal prmBeratNett As Double, ByVal prmf01Datetime As Date, ByVal prmf01NamaUser As String)

        Dim oDataRow As DataRow = prop_dtINISHGOODWHMasters.NewRow()

        oDataRow("Id") = prmId
        oDataRow("k02SPK") = prmk02SPK
        oDataRow("k03ProductCode") = prmk03ProductCode
        oDataRow("NamaNORO") = prmNamaNORO
        oDataRow("NamaWarnaEmas") = prmNamaWarnaEmas
        oDataRow("NamaSize") = prmNamaSize
        oDataRow("NamaBrand") = prmNamaBrand
        oDataRow("OrderStatus") = prmOrderStatus
        oDataRow("NoDocument") = prmNoDocument
        oDataRow("PCSSKU") = prmPCSSKU
        oDataRow("BeratGrosss") = prmBeratGrosss
        oDataRow("BeratNett") = prmBeratNett
        oDataRow("f01Datetime") = prmf01Datetime
        oDataRow("f01NamaUser") = prmf01NamaUser

        prop_dtINISHGOODWHMasters.Rows.Add(oDataRow)
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

'********** end of .NET Controller : clsControllerINISHGOODWHMasters.vb ****************
