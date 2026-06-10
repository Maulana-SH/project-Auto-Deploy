Public Class clsControllerSKUSaja
    Implements IDisposable

    Public Property prop_dtSKUSaja As DataTable

    Private Function dtCreateSKUSaja() As DataTable
        Dim dtDataTable As New DataTable

        Dim fieldk01cSKU_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k01cSKU_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldk01cSKU_v50)

        Return dtDataTable
    End Function

    Public Sub dtInitSKUSaja()
        prop_dtSKUSaja = Nothing
        prop_dtSKUSaja = dtCreateSKUSaja()
        prop_dtSKUSaja.Clear()
    End Sub

    Public Sub dtAddNewSKUSaja(ByVal prmk01cSKU_v50 As String)
        Dim oDataRow As DataRow = prop_dtSKUSaja.NewRow()

        oDataRow("k01cSKU_v50") = prmk01cSKU_v50

        prop_dtSKUSaja.Rows.Add(oDataRow)
    End Sub

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        ' TODO: uncomment the following line if Finalize() is overridden above.
        ' GC.SuppressFinalize(Me)
    End Sub
#End Region


End Class
