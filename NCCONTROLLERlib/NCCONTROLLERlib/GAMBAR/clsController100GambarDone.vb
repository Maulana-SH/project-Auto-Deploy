'********** create .NET Controller : clsController100GambarDone.vb ****************

Public Class clsController100GambarDone
     Implements IDisposable

Public Property prop_dt100GambarDone As DataTable

Private Function dtCreate100GambarDone As DataTable
        Dim dtDataTable As New DataTable


        Dim fieldk01cKodeGambar_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k01cKodeGambar_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldk01cKodeGambar_v50)

        Dim fieldf02cKodeFGorComponent_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f02cKodeFGorComponent_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf02cKodeFGorComponent_v50)

     Dim fieldf03cStatus As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f03cStatus", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf03cStatus)

        Return dtDataTable
End Function

Public Sub dtInit100GambarDone()
     prop_dt100GambarDone = Nothing
     prop_dt100GambarDone = dtCreate100GambarDone()
     prop_dt100GambarDone.Clear()
End Sub

    Public Sub dtAddNew100GambarDone(ByVal prmk01cKodeGambar_v50 As String, ByVal prmf02cKodeFGorComponent_v50 As String, ByVal prmf03cStatus As String)

        Dim oDataRow As DataRow = prop_dt100GambarDone.NewRow()

        oDataRow("k01cKodeGambar_v50") = prmk01cKodeGambar_v50
        oDataRow("f02cKodeFGorComponent_v50") = prmf02cKodeFGorComponent_v50
        oDataRow("f03cStatus") = prmf03cStatus

        prop_dt100GambarDone.Rows.Add(oDataRow)
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

'********** end of .NET Controller : clsController100GambarDone.vb ****************
