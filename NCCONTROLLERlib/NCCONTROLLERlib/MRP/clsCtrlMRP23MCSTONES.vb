'********** create .NET Controller : clsController23MCSTONES.vb ****************

Public Class clsCtrlMRP23MCSTONES
    Implements IDisposable

    Public Property prop_dt23MCSTONES As DataTable

    Private Function dtCreate23MCSTONES() As DataTable
        Dim dtDataTable As New DataTable

        Dim fieldk01cKodeStones_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k01cKodeStones_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldk01cKodeStones_v50)

        Dim fieldf01cStonesDesc_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f01cStonesDesc_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf01cStonesDesc_v50)

        Dim fieldf02cKodeStonesType_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f02cKodeStonesType_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf02cKodeStonesType_v50)

        Dim fieldf03cStonesTypeDesc_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f03cStonesTypeDesc_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf03cStonesTypeDesc_v50)

        Dim fieldf04KodeShape_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f04KodeShape_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf04KodeShape_v50)

        Dim fieldf05cShapeDesc_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f05cShapeDesc_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf05cShapeDesc_v50)

        Dim fieldf06cKodeWarna_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f06cKodeWarna_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf06cKodeWarna_v50)

        Dim fieldf07cWarnaDesc_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f07cWarnaDesc_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf07cWarnaDesc_v50)

        Dim fieldf08cKodeSize_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f08cKodeSize_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf08cKodeSize_v50)

        Dim fieldf09cSizeDesc_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f09cSizeDesc_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf09cSizeDesc_v50)

        Dim fieldf10cKodeQuality_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f10cKodeQuality_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf10cKodeQuality_v50)

        Dim fieldf11cQualityDesc_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f11cQualityDesc_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf11cQualityDesc_v50)

        Dim fieldf12cKodeBrand_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f12cKodeBrand_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf12cKodeBrand_v50)

        Dim fieldf13cBrandDesc_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f13cBrandDesc_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf13cBrandDesc_v50)

        Dim fieldf14nBeratPerButir_n92 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Double"), .ColumnName = "f14nBeratPerButir_n92", .DefaultValue = 0}
        dtDataTable.Columns.Add(fieldf14nBeratPerButir_n92)

        Dim fieldf15nHargaPerGram_n92 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Double"), .ColumnName = "f15nHargaPerGram_n92", .DefaultValue = 0}
        dtDataTable.Columns.Add(fieldf15nHargaPerGram_n92)

        Dim fieldf30cIDUser_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f30cIDUser_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf30cIDUser_v50)

        Dim fieldf31cNamaUser_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f31cNamaUser_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf31cNamaUser_v50)

        Dim fieldf32dCreatedDate As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.DateTime"), .ColumnName = "f32dCreatedDate", .DefaultValue = "3000-01-01"}
        dtDataTable.Columns.Add(fieldf32dCreatedDate)

        Return dtDataTable
    End Function

    Public Sub dtInit23MCSTONES()
        prop_dt23MCSTONES = Nothing
        prop_dt23MCSTONES = dtCreate23MCSTONES()
        prop_dt23MCSTONES.Clear()
    End Sub

    Public Sub dtAddNew23MCSTONES(ByVal prmk01cKodeStones_v50 As String, ByVal prmf01cStonesDesc_v50 As String, ByVal prmf02cKodeStonesType_v50 As String, ByVal prmf03cStonesTypeDesc_v50 As String, ByVal prmf04KodeShape_v50 As String, ByVal prmf05cShapeDesc_v50 As String, ByVal prmf06cKodeWarna_v50 As String, ByVal prmf07cWarnaDesc_v50 As String, ByVal prmf08cKodeSize_v50 As String, ByVal prmf09cSizeDesc_v50 As String, ByVal prmf10cKodeQuality_v50 As String, ByVal prmf11cQualityDesc_v50 As String, ByVal prmf12cKodeBrand_v50 As String, ByVal prmf13cBrandDesc_v50 As String, ByVal prmf14nBeratPerButir_n92 As Double, ByVal prmf15nHargaPerGram_n92 As Double, ByVal prmf30cIDUser_v50 As String, ByVal prmf31cNamaUser_v50 As String, ByVal prmf32dCreatedDate As Date)

        Dim oDataRow As DataRow = prop_dt23MCSTONES.NewRow()

        oDataRow("k01cKodeStones_v50") = prmk01cKodeStones_v50
        oDataRow("f01cStonesDesc_v50") = prmf01cStonesDesc_v50
        oDataRow("f02cKodeStonesType_v50") = prmf02cKodeStonesType_v50
        oDataRow("f03cStonesTypeDesc_v50") = prmf03cStonesTypeDesc_v50
        oDataRow("f04KodeShape_v50") = prmf04KodeShape_v50
        oDataRow("f05cShapeDesc_v50") = prmf05cShapeDesc_v50
        oDataRow("f06cKodeWarna_v50") = prmf06cKodeWarna_v50
        oDataRow("f07cWarnaDesc_v50") = prmf07cWarnaDesc_v50
        oDataRow("f08cKodeSize_v50") = prmf08cKodeSize_v50
        oDataRow("f09cSizeDesc_v50") = prmf09cSizeDesc_v50
        oDataRow("f10cKodeQuality_v50") = prmf10cKodeQuality_v50
        oDataRow("f11cQualityDesc_v50") = prmf11cQualityDesc_v50
        oDataRow("f12cKodeBrand_v50") = prmf12cKodeBrand_v50
        oDataRow("f13cBrandDesc_v50") = prmf13cBrandDesc_v50
        oDataRow("f14nBeratPerButir_n92") = prmf14nBeratPerButir_n92
        oDataRow("f15nHargaPerGram_n92") = prmf15nHargaPerGram_n92
        oDataRow("f30cIDUser_v50") = prmf30cIDUser_v50
        oDataRow("f31cNamaUser_v50") = prmf31cNamaUser_v50
        oDataRow("f32dCreatedDate") = prmf32dCreatedDate

        prop_dt23MCSTONES.Rows.Add(oDataRow)
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
