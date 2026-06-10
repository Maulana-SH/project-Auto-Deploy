'********** create .NET Controller : clsController25BOMCASTEDPARTS.vb ****************

Public Class clsCtrlMRP25BOMCASTEDPARTS
     Implements IDisposable

Public Property prop_dt25BOMCASTEDPARTS As DataTable

Private Function dtCreate25BOMCASTEDPARTS As DataTable
        Dim dtDataTable As New DataTable

        Dim fieldk01cKodeFinishedGood_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k01cKodeFinishedGood_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldk01cKodeFinishedGood_v50)

        Dim fieldk02cKodeRubber_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k02cKodeRubber_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldk02cKodeRubber_v50)

        Dim fieldk03cKodeItemCastedParts_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k03cKodeItemCastedParts_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldk03cKodeItemCastedParts_v50)

        Dim fieldk04cVersionBOM_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k04cVersionBOM_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldk04cVersionBOM_v50)

        Dim fieldf01cItemCastedPartsDesc_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f01cItemCastedPartsDesc_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf01cItemCastedPartsDesc_v50)

     Dim fieldf02nPcs_int As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Int32"), .ColumnName = "f02nPcs_int", .DefaultValue = 0}
     dtDataTable.Columns.Add(fieldf02nPcs_int)

     Dim fieldf03nBerat_n92 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Double"), .ColumnName = "f03nBerat_n92", .DefaultValue = 0}
     dtDataTable.Columns.Add(fieldf03nBerat_n92)

     Dim fieldf04cKodeAssembly_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f04cKodeAssembly_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf04cKodeAssembly_v50)

     Dim fieldf05cAssemblyDesc_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f05cAssemblyDesc_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf05cAssemblyDesc_v50)

     Dim fieldf06cPerintahFinishing_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f06cPerintahFinishing_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf06cPerintahFinishing_v50)

     Dim fieldf07cKodePlating_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f07cKodePlating_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf07cKodePlating_v50)

     Dim fieldf08cPlatingDesc_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f08cPlatingDesc_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf08cPlatingDesc_v50)

        Dim fieldf09nWeightPerPcs_n92 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Double"), .ColumnName = "f09nWeightPerPcs_n92", .DefaultValue = 0}
        dtDataTable.Columns.Add(fieldf09nWeightPerPcs_n92)

        Dim fieldf10cKodeFinishing_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f10cKodeFinishing_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf10cKodeFinishing_v50)

        Dim fieldf11cKeyGUIDGambar_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f11cKeyGUIDGambar_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf11cKeyGUIDGambar_v50)

        Dim fieldf12cNote_v100 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f12cNote_v100", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf12cNote_v100)

        Dim fieldf30cIDUser_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f30cIDUser_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf30cIDUser_v50)

     Dim fieldf31cNamaUser_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f31cNamaUser_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf31cNamaUser_v50)

     Dim fieldf32dCreatedDate As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.DateTime"), .ColumnName = "f32dCreatedDate", .DefaultValue = "3000-01-01"}
     dtDataTable.Columns.Add(fieldf32dCreatedDate)

        Return dtDataTable
End Function

Public Sub dtInit25BOMCASTEDPARTS()
     prop_dt25BOMCASTEDPARTS = Nothing
     prop_dt25BOMCASTEDPARTS = dtCreate25BOMCASTEDPARTS()
     prop_dt25BOMCASTEDPARTS.Clear()
End Sub

    Public Sub dtAddNew25BOMCASTEDPARTS(ByVal prmk01cKodeFinishedGood_v50 As String, ByVal prmk02cKodeRubber_v50 As String, ByVal prmk03cKodeItemCastedParts_v50 As String, ByVal prmk04cVersionBOM_v50 As String,
                                        ByVal prmf01cItemCastedPartsDesc_v50 As String, ByVal prmf02nPcs_int As Integer, ByVal prmf03nBerat_n92 As Double,
                                        ByVal prmf04cKodeAssembly_v50 As String, ByVal prmf05cAssemblyDesc_v50 As String, ByVal prmf06cPerintahFinishing_v50 As String,
                                        ByVal prmf07cKodePlating_v50 As String, ByVal prmf08cPlatingDesc_v50 As String, ByVal prmf09nWeightPerPcs_n92 As Double,
                                        ByVal prmf10cKodeFinishing_v50 As String, ByVal prmf11cKeyGUIDGambar_v50 As String, ByVal prmf12cNote_v100 As String,
                                        ByVal prmf30cIDUser_v50 As String, ByVal prmf31cNamaUser_v50 As String, ByVal prmf32dCreatedDate As Date)

        Dim oDataRow As DataRow = prop_dt25BOMCASTEDPARTS.NewRow()

        oDataRow("k01cKodeFinishedGood_v50") = prmk01cKodeFinishedGood_v50
        oDataRow("k02cKodeRubber_v50") = prmk02cKodeRubber_v50
        oDataRow("k03cKodeItemCastedParts_v50") = prmk03cKodeItemCastedParts_v50
        oDataRow("k04cVersionBOM_v50") = prmk04cVersionBOM_v50
        oDataRow("f01cItemCastedPartsDesc_v50") = prmf01cItemCastedPartsDesc_v50
        oDataRow("f02nPcs_int") = prmf02nPcs_int
        oDataRow("f03nBerat_n92") = prmf03nBerat_n92
        oDataRow("f04cKodeAssembly_v50") = prmf04cKodeAssembly_v50
        oDataRow("f05cAssemblyDesc_v50") = prmf05cAssemblyDesc_v50
        oDataRow("f06cPerintahFinishing_v50") = prmf06cPerintahFinishing_v50
        oDataRow("f07cKodePlating_v50") = prmf07cKodePlating_v50
        oDataRow("f08cPlatingDesc_v50") = prmf08cPlatingDesc_v50
        oDataRow("f09nWeightPerPcs_n92") = prmf09nWeightPerPcs_n92
        oDataRow("f10cKodeFinishing_v50") = prmf10cKodeFinishing_v50
        oDataRow("f11cKeyGUIDGambar_v50") = prmf11cKeyGUIDGambar_v50
        oDataRow("f12cNote_v100") = prmf12cNote_v100
        oDataRow("f30cIDUser_v50") = prmf30cIDUser_v50
        oDataRow("f31cNamaUser_v50") = prmf31cNamaUser_v50
        oDataRow("f32dCreatedDate") = prmf32dCreatedDate

        prop_dt25BOMCASTEDPARTS.Rows.Add(oDataRow)
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

'********** end of .NET Controller : clsController25BOMCASTEDPARTS.vb ****************
