Public Class MdlChat
    Implements IDisposable

    Public Property prop_dtChat As DataTable

    Private Function dtCreateChat() As DataTable
        Dim dtDataTable As New DataTable

        Dim fieldk01cKodeTransaksi_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "IdUser", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldk01cKodeTransaksi_v50)

        Dim fieldf01cKodeMaster_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "Pesan", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf01cKodeMaster_v50)

        Dim fieldf42dCreatedDate As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.DateTime"), .ColumnName = "DateTime", .DefaultValue = "3000-01-01"}
        dtDataTable.Columns.Add(fieldf42dCreatedDate)

        Return dtDataTable
    End Function

    Public Sub dtInitChat()
        prop_dtChat = Nothing
        prop_dtChat = dtCreateChat()
        prop_dtChat.Clear()
    End Sub

    Public Sub dtAddNew(ByVal prmIdUser As String, ByVal prmPesan As String, ByVal prmDateTime As DateTime)

        Dim oDataRow As DataRow = prop_dtChat.NewRow()

        oDataRow("IdUser") = prmIdUser
        oDataRow("Pesan") = prmPesan
        oDataRow("DateTime") = prmDateTime


        prop_dtChat.Rows.Add(oDataRow)
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