Public Class clsCtrlMRP36JOBCARDBOM
    Implements IDisposable

    Public Property prop_dt36JOBCARDBOM As DataTable

    Private Function dtCreate36JOBCARDBOM() As DataTable
        Dim dtDataTable As New DataTable

        Dim fieldk01cKodeValidation_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k01cKodeValidation_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldk01cKodeValidation_v50)

        Dim fieldk02cKodeItemCastedParts_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k02cKodeItemCastedParts_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldk02cKodeItemCastedParts_v50)

        Dim fieldf01cKodeMaterial_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f01cKodeMaterial_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf01cKodeMaterial_v50)

        Dim fieldf02cMaterialDesc_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f02cMaterialDesc_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf02cMaterialDesc_v50)

        Dim fieldf03nQty As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Int32"), .ColumnName = "f03nQty", .DefaultValue = 0}
        dtDataTable.Columns.Add(fieldf03nQty)

        Dim fieldf04nGram_n92 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Double"), .ColumnName = "f04nGram_n92", .DefaultValue = 0}
        dtDataTable.Columns.Add(fieldf04nGram_n92)

        Dim fieldf30cIDUser_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f30cIDUser_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf30cIDUser_v50)

        Dim fieldf31cNamaUser_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f31cNamaUser_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf31cNamaUser_v50)

        Dim fieldf32dCreatedDate As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.DateTime"), .ColumnName = "f32dCreatedDate", .DefaultValue = "3000-01-01"}
        dtDataTable.Columns.Add(fieldf32dCreatedDate)

        Return dtDataTable
    End Function

    Public Sub dtInit36JOBCARDBOM()
        prop_dt36JOBCARDBOM = Nothing
        prop_dt36JOBCARDBOM = dtCreate36JOBCARDBOM()
        prop_dt36JOBCARDBOM.Clear()
    End Sub

    Public Sub dtAddNew36JOBCARDBOM(ByVal prmKodeValidation As String, ByVal prmKodeItemCastedParts As String,
                                    ByVal prmKodeMaterial As String,
                                    ByVal prmMaterialDecs As String, ByVal prmQty As Integer,
                                    ByVal prmGram As Double, ByVal prmIdUser As String,
                                    ByVal prmNamaUSer As String, ByVal prmCreatedDate As Date)

        Dim oDataRow As DataRow = prop_dt36JOBCARDBOM.NewRow()
        oDataRow("k01cKodeValidation_v50") = prmKodeValidation
        oDataRow("k02cKodeItemCastedParts_v50") = prmKodeItemCastedParts
        oDataRow("f01cKodeMaterial_v50") = prmKodeMaterial
        oDataRow("f02cMaterialDesc_v50") = prmMaterialDecs
        oDataRow("f03nQty") = prmQty
        oDataRow("f04nGram_n92") = prmGram
        oDataRow("f30cIDUser_v50") = prmIdUser
        oDataRow("f31cNamaUser_v50") = prmNamaUSer
        oDataRow("f32dCreatedDate") = prmCreatedDate

        prop_dt36JOBCARDBOM.Rows.Add(oDataRow)
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








