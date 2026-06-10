'********** create .NET Controller : clsController23MCSTONES.vb ****************

Public Class cls24Chat
        Implements IDisposable

    Public Property prop_dtChat As DataTable

    Private Function dtCreate23MCSTONES() As DataTable
        Dim dtDataTable As New DataTable

        Dim fieldK01IdUser_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "K01IdUser_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldK01IdUser_v50)

        Dim fieldf01Pesan0 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f01Pesan", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf01Pesan0)

        Dim fieldff30SendDate As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.DateTime"), .ColumnName = "f30SendDate", .DefaultValue = "3000-01-01"}
        dtDataTable.Columns.Add(fieldff30SendDate)

        Return dtDataTable
    End Function

    Public Sub dtInitChat()
        prop_dtChat = Nothing
        prop_dtChat = dtCreate23MCSTONES()
        prop_dtChat.Clear()
    End Sub

    Public Sub dtAddNewChat(ByVal prmK01IdUser_v50 As String, ByVal prmf01Pesan As String, ByVal prmf30SendDate As Date)

        Dim oDataRow As DataRow = prop_dtChat.NewRow()

        oDataRow("K01IdUser_v50") = prmK01IdUser_v50
        oDataRow("f01Pesan") = prmf01Pesan
        oDataRow("f30SendDate") = prmf30SendDate

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

'********** end of .NET Controller : clsController23MCSTONES.vb ****************
