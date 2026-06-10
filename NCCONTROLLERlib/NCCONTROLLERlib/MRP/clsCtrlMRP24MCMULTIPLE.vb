'********** create .NET Controller : clsController24MCMULTIPLE.vb ****************

Public Class clsCtrlMRP24MCMULTIPLE
     Implements IDisposable

Public Property prop_dt24MCMULTIPLE As DataTable

Private Function dtCreate24MCMULTIPLE As DataTable
     Dim dtDataTable As New DataTable

     Dim fieldk01cKodeTransaksi_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k01cKodeTransaksi_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldk01cKodeTransaksi_v50)

     Dim fieldf01cKodeMaster_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f01cKodeMaster_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf01cKodeMaster_v50)

     Dim fieldf02cNamaMaster_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f02cNamaMaster_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf02cNamaMaster_v50)

     Dim fieldf03cNamaMasterMultiple_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f03cNamaMasterMultiple_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf03cNamaMasterMultiple_v50)

     Dim fieldf04cNamaForm_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f04cNamaForm_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf04cNamaForm_v50)

     Dim fieldf40cIDUser_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f40cIDUser_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf40cIDUser_v50)

     Dim fieldf41cNamaUser_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f41cNamaUser_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf41cNamaUser_v50)

     Dim fieldf42dCreatedDate As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.DateTime"), .ColumnName = "f42dCreatedDate", .DefaultValue = "3000-01-01"}
     dtDataTable.Columns.Add(fieldf42dCreatedDate)

     Return dtDataTable
End Function

Public Sub dtInit24MCMULTIPLE()
     prop_dt24MCMULTIPLE = Nothing
     prop_dt24MCMULTIPLE = dtCreate24MCMULTIPLE()
     prop_dt24MCMULTIPLE.Clear()
End Sub

Public Sub dtAddNew24MCMULTIPLE(ByVal prmk01cKodeTransaksi_v50 As String,ByVal prmf01cKodeMaster_v50 As String,ByVal prmf02cNamaMaster_v50 As String,ByVal prmf03cNamaMasterMultiple_v50 As String,ByVal prmf04cNamaForm_v50 As String,ByVal prmf40cIDUser_v50 As String,ByVal prmf41cNamaUser_v50 As String,ByVal prmf42dCreatedDate As Date)

     Dim oDataRow As DataRow = prop_dt24MCMULTIPLE.NewRow()

     oDataRow("k01cKodeTransaksi_v50") = prmk01cKodeTransaksi_v50
     oDataRow("f01cKodeMaster_v50") = prmf01cKodeMaster_v50
     oDataRow("f02cNamaMaster_v50") = prmf02cNamaMaster_v50
     oDataRow("f03cNamaMasterMultiple_v50") = prmf03cNamaMasterMultiple_v50
     oDataRow("f04cNamaForm_v50") = prmf04cNamaForm_v50
     oDataRow("f40cIDUser_v50") = prmf40cIDUser_v50
     oDataRow("f41cNamaUser_v50") = prmf41cNamaUser_v50
     oDataRow("f42dCreatedDate") = prmf42dCreatedDate

     prop_dt24MCMULTIPLE.Rows.Add(oDataRow)
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

'********** end of .NET Controller : clsController24MCMULTIPLE.vb ****************
