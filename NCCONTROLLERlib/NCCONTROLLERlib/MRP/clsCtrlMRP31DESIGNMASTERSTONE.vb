'********** create .NET Controller : clsController31DESIGNMASTERSTONE.vb ****************

Public Class clsCtrlMRP31DESIGNMASTERSTONE
    Implements IDisposable

    Public Property prop_dt31DESIGNMASTERSTONE As DataTable

    Private Function dtCreate31DESIGNMASTERSTONE() As DataTable
        Dim dtDataTable As New DataTable

        Dim fieldk01cKodeDesignMaster_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k01cKodeDesignMaster_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldk01cKodeDesignMaster_v50)

        Dim fieldk02cKodeStones_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k02cKodeStones_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldk02cKodeStones_v50)

        Dim fieldf01cKodeStoneType_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f01cKodeStoneType_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf01cKodeStoneType_v50)

        Dim fieldf02cNamaStoneType_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f02cNamaStoneType_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf02cNamaStoneType_v50)

        Dim fieldf03cKodeStoneShape_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f03cKodeStoneShape_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf03cKodeStoneShape_v50)

        Dim fieldf04cNamaStoneShape_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f04cNamaStoneShape_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf04cNamaStoneShape_v50)

        Dim fieldf05cKodeStoneColor_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f05cKodeStoneColor_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf05cKodeStoneColor_v50)

        Dim fieldf06cNamaStoneColor_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f06cNamaStoneColor_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf06cNamaStoneColor_v50)

        Dim fieldf07cKodeStoneSize_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f07cKodeStoneSize_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf07cKodeStoneSize_v50)

        Dim fieldf08cNamaStoneSize_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f08cNamaStoneSize_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf08cNamaStoneSize_v50)

        Dim fieldf09nButir_int As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Int32"), .ColumnName = "f09nButir_int", .DefaultValue = 0}
        dtDataTable.Columns.Add(fieldf09nButir_int)

        Dim fieldf10nBerat_n94 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Double"), .ColumnName = "f10nBerat_n94", .DefaultValue = 0}
        dtDataTable.Columns.Add(fieldf10nBerat_n94)

        Dim fieldf11nStoneDistribution_n92 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Double"), .ColumnName = "f11nStoneDistribution_n92", .DefaultValue = 0}
        dtDataTable.Columns.Add(fieldf11nStoneDistribution_n92)

        Dim fieldf40cIDUser_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f40cIDUser_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf40cIDUser_v50)

        Dim fieldf41cNamaUser_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f41cNamaUser_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf41cNamaUser_v50)

        Dim fieldf42dCreatedDate As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.DateTime"), .ColumnName = "f42dCreatedDate", .DefaultValue = "3000-01-01"}
        dtDataTable.Columns.Add(fieldf42dCreatedDate)

        Return dtDataTable
    End Function

    Public Sub dtInit31DESIGNMASTERSTONE()
        prop_dt31DESIGNMASTERSTONE = Nothing
        prop_dt31DESIGNMASTERSTONE = dtCreate31DESIGNMASTERSTONE()
        prop_dt31DESIGNMASTERSTONE.Clear()
    End Sub

    Public Sub dtAddNew31DESIGNMASTERSTONE(ByVal prmk01cKodeDesignMaster_v50 As String, ByVal prmk02cKodeStones_v50 As String, ByVal prmf01cKodeStoneType_v50 As String, ByVal prmf02cNamaStoneType_v50 As String, ByVal prmf03cKodeStoneShape_v50 As String, ByVal prmf04cNamaStoneShape_v50 As String, ByVal prmf05cKodeStoneColor_v50 As String, ByVal prmf06cNamaStoneColor_v50 As String, ByVal prmf07cKodeStoneSize_v50 As String, ByVal prmf08cNamaStoneSize_v50 As String, ByVal prmf09nButir_int As Integer, ByVal prmf10nBerat_n94 As Double, ByVal prmf11nStoneDistribution_n92 As Double, ByVal prmf40cIDUser_v50 As String, ByVal prmf41cNamaUser_v50 As String, ByVal prmf42dCreatedDate As Date)

        Dim oDataRow As DataRow = prop_dt31DESIGNMASTERSTONE.NewRow()

        oDataRow("k01cKodeDesignMaster_v50") = prmk01cKodeDesignMaster_v50
        oDataRow("k02cKodeStones_v50") = prmk02cKodeStones_v50
        oDataRow("f01cKodeStoneType_v50") = prmf01cKodeStoneType_v50
        oDataRow("f02cNamaStoneType_v50") = prmf02cNamaStoneType_v50
        oDataRow("f03cKodeStoneShape_v50") = prmf03cKodeStoneShape_v50
        oDataRow("f04cNamaStoneShape_v50") = prmf04cNamaStoneShape_v50
        oDataRow("f05cKodeStoneColor_v50") = prmf05cKodeStoneColor_v50
        oDataRow("f06cNamaStoneColor_v50") = prmf06cNamaStoneColor_v50
        oDataRow("f07cKodeStoneSize_v50") = prmf07cKodeStoneSize_v50
        oDataRow("f08cNamaStoneSize_v50") = prmf08cNamaStoneSize_v50
        oDataRow("f09nButir_int") = prmf09nButir_int
        oDataRow("f10nBerat_n94") = prmf10nBerat_n94
        oDataRow("f11nStoneDistribution_n92") = prmf11nStoneDistribution_n92
        oDataRow("f40cIDUser_v50") = prmf40cIDUser_v50
        oDataRow("f41cNamaUser_v50") = prmf41cNamaUser_v50
        oDataRow("f42dCreatedDate") = prmf42dCreatedDate

        prop_dt31DESIGNMASTERSTONE.Rows.Add(oDataRow)
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

'********** end of .NET Controller : clsController31DESIGNMASTERSTONE.vb ****************
