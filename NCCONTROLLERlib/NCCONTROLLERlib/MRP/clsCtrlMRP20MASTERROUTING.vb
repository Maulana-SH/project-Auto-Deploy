'********** create .NET Controller : clsController20MASTERROUTING.vb ****************

Public Class clsCtrlMRP20MASTERROUTING
     Implements IDisposable

Public Property prop_dt20MASTERROUTING As DataTable

Private Function dtCreate20MASTERROUTING As DataTable
        Dim dtDataTable As New DataTable

        Dim fieldk01cKodeMasterRouting_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k01cKodeMasterRouting_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldk01cKodeMasterRouting_v50)

        Dim fieldk02cKodeProsesProduksi_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k02cKodeProsesProduksi_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldk02cKodeProsesProduksi_v50)

        Dim fieldf01cMasterRoutingDesc_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f01cMasterRoutingDesc_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf01cMasterRoutingDesc_v50)

     Dim fieldf02cKodeRawMaterial_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f02cKodeRawMaterial_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf02cKodeRawMaterial_v50)

     Dim fieldf03cKodeTipeBarang_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f03cKodeTipeBarang_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf03cKodeTipeBarang_v50)

     Dim fieldf04nJmlWarnaRawMaterial_int As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Int32"), .ColumnName = "f04nJmlWarnaRawMaterial_int", .DefaultValue = 0}
     dtDataTable.Columns.Add(fieldf04nJmlWarnaRawMaterial_int)

     Dim fieldf05nNoUrutRouting_int As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Int32"), .ColumnName = "f05nNoUrutRouting_int", .DefaultValue = 0}
     dtDataTable.Columns.Add(fieldf05nNoUrutRouting_int)

     Dim fieldf20dDateCreated As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.DateTime"), .ColumnName = "f20dDateCreated", .DefaultValue = "3000-01-01"}
     dtDataTable.Columns.Add(fieldf20dDateCreated)

     Dim fieldf21cUserID_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f21cUserID_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf21cUserID_v50)

     Dim fieldf22cUserName_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f22cUserName_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf22cUserName_v50)

        Return dtDataTable
End Function

Public Sub dtInit20MASTERROUTING()
     prop_dt20MASTERROUTING = Nothing
     prop_dt20MASTERROUTING = dtCreate20MASTERROUTING()
     prop_dt20MASTERROUTING.Clear()
End Sub

    Public Sub dtAddNew20MASTERROUTING(ByVal prmk01cKodeMasterRouting_v50 As String, ByVal prmk02cKodeProsesProduksi_v50 As String,
                                       ByVal prmf01cMasterRoutingDesc_v50 As String, ByVal prmf02cKodeRawMaterial_v50 As String,
                                       ByVal prmf03cKodeTipeBarang_v50 As String, ByVal prmf04nJmlWarnaRawMaterial_int As Integer,
                                       ByVal prmf05nNoUrutRouting_int As Integer, ByVal prmf20dDateCreated As Date,
                                       ByVal prmf21cUserID_v50 As String, ByVal prmf22cUserName_v50 As String)

        Dim oDataRow As DataRow = prop_dt20MASTERROUTING.NewRow()

        oDataRow("k01cKodeMasterRouting_v50") = prmk01cKodeMasterRouting_v50
        oDataRow("k02cKodeProsesProduksi_v50") = prmk02cKodeProsesProduksi_v50
        oDataRow("f01cMasterRoutingDesc_v50") = prmf01cMasterRoutingDesc_v50
        oDataRow("f02cKodeRawMaterial_v50") = prmf02cKodeRawMaterial_v50
        oDataRow("f03cKodeTipeBarang_v50") = prmf03cKodeTipeBarang_v50
        oDataRow("f04nJmlWarnaRawMaterial_int") = prmf04nJmlWarnaRawMaterial_int
        oDataRow("f05nNoUrutRouting_int") = prmf05nNoUrutRouting_int
        oDataRow("f20dDateCreated") = prmf20dDateCreated
        oDataRow("f21cUserID_v50") = prmf21cUserID_v50
        oDataRow("f22cUserName_v50") = prmf22cUserName_v50


        prop_dt20MASTERROUTING.Rows.Add(oDataRow)
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

'********** end of .NET Controller : clsController20MASTERROUTING.vb ****************
