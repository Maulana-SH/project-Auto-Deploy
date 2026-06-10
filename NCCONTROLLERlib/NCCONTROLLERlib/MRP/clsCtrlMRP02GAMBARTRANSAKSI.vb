'********** create .NET Controller : clsController02GAMBARTRANSAKSI.vb ****************

Public Class clsCtrlMRP02GAMBARTRANSAKSI
     Implements IDisposable

Public Property prop_dt02GAMBARTRANSAKSI As DataTable

Private Function dtCreate02GAMBARTRANSAKSI As DataTable
     Dim dtDataTable As New DataTable

     Dim fieldk01cNoDocTransaksi_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k01cNoDocTransaksi_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldk01cNoDocTransaksi_v50)

     Dim fieldk02KeyGUIDGambar_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k02KeyGUIDGambar_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldk02KeyGUIDGambar_v50)

     Dim fieldk03cKodeFGorComponent_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k03cKodeFGorComponent_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldk03cKodeFGorComponent_v50)

     Dim fieldf01cNamaForm_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f01cNamaForm_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf01cNamaForm_v50)

     Dim fieldf20cIDUser_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f20cIDUser_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf20cIDUser_v50)

     Dim fieldf21cNamaUser_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f21cNamaUser_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf21cNamaUser_v50)

     Dim fieldf22dCreatedDate As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.DateTime"), .ColumnName = "f22dCreatedDate", .DefaultValue = "3000-01-01"}
     dtDataTable.Columns.Add(fieldf22dCreatedDate)

     Return dtDataTable
End Function

Public Sub dtInit02GAMBARTRANSAKSI()
     prop_dt02GAMBARTRANSAKSI = Nothing
     prop_dt02GAMBARTRANSAKSI = dtCreate02GAMBARTRANSAKSI()
     prop_dt02GAMBARTRANSAKSI.Clear()
End Sub

    Public Sub dtAddNew02GAMBARTRANSAKSI(ByVal prmk01cNoDocTransaksi_v50 As String, ByVal prmk02KeyGUIDGambar_v50 As String, ByVal prmk03cKodeFGorComponent_v50 As String, ByVal prmf01cNamaForm_v50 As String, ByVal prmf20cIDUser_v50 As String, ByVal prmf21cNamaUser_v50 As String, ByVal prmf22dCreatedDate As Date)

        Dim oDataRow As DataRow = prop_dt02GAMBARTRANSAKSI.NewRow()

        oDataRow("k01cNoDocTransaksi_v50") = prmk01cNoDocTransaksi_v50
        oDataRow("k02KeyGUIDGambar_v50") = prmk02KeyGUIDGambar_v50
        oDataRow("k03cKodeFGorComponent_v50") = prmk03cKodeFGorComponent_v50
        oDataRow("f01cNamaForm_v50") = prmf01cNamaForm_v50
        oDataRow("f20cIDUser_v50") = prmf20cIDUser_v50
        oDataRow("f21cNamaUser_v50") = prmf21cNamaUser_v50
        oDataRow("f22dCreatedDate") = prmf22dCreatedDate

        prop_dt02GAMBARTRANSAKSI.Rows.Add(oDataRow)
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

'********** end of .NET Controller : clsController02GAMBARTRANSAKSI.vb ****************
