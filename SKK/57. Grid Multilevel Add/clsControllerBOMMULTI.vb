'********** create .NET Controller : clsControllerOMMULTI.vb ****************

Public Class clsControllerBOMMULTI
    Implements IDisposable

    Public Property prop_dtBOMMULTI As DataTable
    Private _nextID As Integer = 1

    Private Function dtCreateOMMULTI() As DataTable
        Dim dtDataTable As New DataTable

        Dim fieldNoUrut As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Int32"), .ColumnName = "NoUrut", .DefaultValue = 0}
        dtDataTable.Columns.Add(fieldNoUrut)

        Dim fieldID As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Int32"), .ColumnName = "ID", .DefaultValue = 0}
        dtDataTable.Columns.Add(fieldID)

        Dim fieldParentID As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Int32"), .ColumnName = "ParentID", .DefaultValue = 0}
        dtDataTable.Columns.Add(fieldParentID)

        Dim fieldLevelBOM As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "LevelBOM", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldLevelBOM)

        Dim fieldk01KodeBOM As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k01KodeBOM", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldk01KodeBOM)

        Dim fieldK02VersiBOM As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "K02VersiBOM", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldK02VersiBOM)

        Dim fieldMaterialCode As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "MaterialCode", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldMaterialCode)

        Dim fieldversiMaterial As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "versiMaterial", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldversiMaterial)

        Dim fieldBeratMaterial As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Double"), .ColumnName = "BeratMaterial", .DefaultValue = 0}
        dtDataTable.Columns.Add(fieldBeratMaterial)

        Dim fieldQty As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Int32"), .ColumnName = "Qty", .DefaultValue = 0}
        dtDataTable.Columns.Add(fieldQty)

        Dim fieldTotalBeratMaterial As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Double"), .ColumnName = "TotalBeratMaterial", .DefaultValue = 0}
        dtDataTable.Columns.Add(fieldTotalBeratMaterial)

        Return dtDataTable
    End Function

    Public Sub dtInitOMMULTI()
        prop_dtBOMMULTI = Nothing
        prop_dtBOMMULTI = dtCreateOMMULTI()
        prop_dtBOMMULTI.Clear()
    End Sub

    Public Sub dtAddNewOMMULTI(ByVal prmNoUrut As Integer,
                              ByVal prmID As Integer,
                            ByVal prmParentID As Integer, ByVal prmLevelBOM As String,
                                ByVal prmk01KodeBOM As String,
                              ByVal prmK02VersiBOM As String, ByVal prmMaterialCode As String, ByVal prmversiMaterial As String, ByVal prmBeratMaterial As Double, ByVal prmQty As Integer, ByVal prmTotalBeratMaterial As Double)

        Dim oDataRow As DataRow = prop_dtBOMMULTI.NewRow()

        oDataRow("NoUrut") = prmNoUrut
        oDataRow("ID") = prmID
        oDataRow("ParentID") = prmParentID
        oDataRow("LevelBOM") = prmLevelBOM
        oDataRow("k01KodeBOM") = prmk01KodeBOM
        oDataRow("K02VersiBOM") = prmK02VersiBOM
        oDataRow("MaterialCode") = prmMaterialCode
        oDataRow("versiMaterial") = prmversiMaterial
        oDataRow("BeratMaterial") = prmBeratMaterial
        oDataRow("Qty") = prmQty
        oDataRow("TotalBeratMaterial") = prmTotalBeratMaterial

        prop_dtBOMMULTI.Rows.Add(oDataRow)
    End Sub

    Public Function GetNextID() As Integer
        _nextID += 1
        Return _nextID
    End Function

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

'********** end of .NET Controller : clsControllerOMMULTI.vb ****************
