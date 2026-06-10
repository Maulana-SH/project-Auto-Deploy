'********** create .NET Controller : clsController29ROUTINGBOM.vb ****************

Public Class clsCtrlMRP29ROUTINGBOM
     Implements IDisposable

Public Property prop_dt29ROUTINGBOM As DataTable

Private Function dtCreate29ROUTINGBOM As DataTable
     Dim dtDataTable As New DataTable

     Dim fieldk01cKodeFinishedGood_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k01cKodeFinishedGood_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldk01cKodeFinishedGood_v50)

     Dim fieldk02cVersionBOM_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k02cVersionBOM_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldk02cVersionBOM_v50)

     Dim fieldk03nNoUrutRouting_int As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Int32"), .ColumnName = "k03nNoUrutRouting_int", .DefaultValue = 0}
     dtDataTable.Columns.Add(fieldk03nNoUrutRouting_int)

     Dim fieldf01cKodeProsesProduksi_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f01cKodeProsesProduksi_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf01cKodeProsesProduksi_v50)

     Dim fieldf02cKodeMasterRouting_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f02cKodeMasterRouting_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf02cKodeMasterRouting_v50)

     Dim fieldf20dDateCreated As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.DateTime"), .ColumnName = "f20dDateCreated", .DefaultValue = "3000-01-01"}
     dtDataTable.Columns.Add(fieldf20dDateCreated)

     Dim fieldf21cUserID_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f21cUserID_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf21cUserID_v50)

     Dim fieldf22cUserName_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f22cUserName_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf22cUserName_v50)

     Return dtDataTable
End Function

Public Sub dtInit29ROUTINGBOM()
     prop_dt29ROUTINGBOM = Nothing
     prop_dt29ROUTINGBOM = dtCreate29ROUTINGBOM()
     prop_dt29ROUTINGBOM.Clear()
End Sub

Public Sub dtAddNew29ROUTINGBOM(ByVal prmk01cKodeFinishedGood_v50 As String,ByVal prmk02cVersionBOM_v50 As String,ByVal prmk03nNoUrutRouting_int As Integer,
                                ByVal prmf01cKodeProsesProduksi_v50 As String,ByVal prmf02cKodeMasterRouting_v50 As String,
                                ByVal prmf20dDateCreated As Date,ByVal prmf21cUserID_v50 As String,ByVal prmf22cUserName_v50 As String)

     Dim oDataRow As DataRow = prop_dt29ROUTINGBOM.NewRow()

     oDataRow("k01cKodeFinishedGood_v50") = prmk01cKodeFinishedGood_v50
     oDataRow("k02cVersionBOM_v50") = prmk02cVersionBOM_v50
     oDataRow("k03nNoUrutRouting_int") = prmk03nNoUrutRouting_int
     oDataRow("f01cKodeProsesProduksi_v50") = prmf01cKodeProsesProduksi_v50
     oDataRow("f02cKodeMasterRouting_v50") = prmf02cKodeMasterRouting_v50
     oDataRow("f20dDateCreated") = prmf20dDateCreated
     oDataRow("f21cUserID_v50") = prmf21cUserID_v50
     oDataRow("f22cUserName_v50") = prmf22cUserName_v50

     prop_dt29ROUTINGBOM.Rows.Add(oDataRow)
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

'********** end of .NET Controller : clsController29ROUTINGBOM.vb ****************
