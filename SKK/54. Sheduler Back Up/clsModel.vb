'********** create .NET Controller : clsControlleraldoStonesMEI.vb ****************

Public Class clsModel
        Implements IDisposable

    Public Property prop_dtclsModel As DataTable

    Private Function dtModel() As DataTable
        Dim dtDataTable As New DataTable


        Dim fieldbCheck As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Boolean"), .ColumnName = "bCheck", .DefaultValue = False}
        dtDataTable.Columns.Add(fieldbCheck)

        Dim fieldk01cKodeLama As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k01cNamafile", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldk01cKodeLama)

        Dim fieldK02cKodeBaru As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f01cFileSize", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldK02cKodeBaru)


        Dim fieldf02dTglBackUp As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.DateTime"), .ColumnName = "f02dTglBackUp", .DefaultValue = "3000-01-01"}
        dtDataTable.Columns.Add(fieldf02dTglBackUp)


        Dim fieldf03ccStatusCopy As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f03cStatusCopy", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf03ccStatusCopy)

        Return dtDataTable
    End Function

    Public Sub dtInitTabel()
        prop_dtclsModel = Nothing
        prop_dtclsModel = dtModel()
        prop_dtclsModel.Clear()
    End Sub

    Public Sub dtAddNewaldoStonesMEI(ByVal prmbCheck As Boolean, ByVal prmk01cKodeLama As String, ByVal prmK02cKodeBaru As String, ByVal prmDateCreated As DateTime, ByVal prmf03cStatusCopy As String)

        Dim oDataRow As DataRow = prop_dtclsModel.NewRow()

        oDataRow("bCheck") = prmbCheck
        oDataRow("k01cNamafile") = prmk01cKodeLama
        oDataRow("f01cFileSize") = prmK02cKodeBaru
        oDataRow("f02dTglBackUp") = prmDateCreated
        oDataRow("f03cStatusCopy") = prmf03cStatusCopy

        prop_dtclsModel.Rows.Add(oDataRow)
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

'********** end of .NET Controller : clsControlleraldoStonesMEI.vb ****************
