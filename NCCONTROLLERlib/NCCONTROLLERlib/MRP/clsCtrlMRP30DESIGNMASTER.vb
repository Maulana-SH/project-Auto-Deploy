'********** create .NET Controller : clsController30DESIGNMASTER.vb ****************

Public Class clsCtrlMRP30DESIGNMASTER
    Implements IDisposable

    Public Property prop_dt30DESIGNMASTER As DataTable

    Private Function dtCreate30DESIGNMASTER() As DataTable
        Dim dtDataTable As New DataTable

        Dim fieldk01cKodeDesignMaster_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k01cKodeDesignMaster_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldk01cKodeDesignMaster_v50)

        Dim fieldf01cKodeBrand_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f01cKodeBrand_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf01cKodeBrand_v50)

        Dim fieldf02cNamaBrand_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f02cNamaBrand_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf02cNamaBrand_v50)

        Dim fieldf03cKodeProject_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f03cKodeProject_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf03cKodeProject_v50)

        Dim fieldf04cNamaProject_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f04cNamaProject_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf04cNamaProject_v50)

        Dim fieldf05cKodeNamingProduct_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f05cKodeNamingProduct_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf05cKodeNamingProduct_v50)

        Dim fieldf06cNamaNamingProduct_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f06cNamaNamingProduct_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf06cNamaNamingProduct_v50)

        Dim fieldf07cKodeItemProduct_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f07cKodeItemProduct_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf07cKodeItemProduct_v50)

        Dim fieldf08cNamaItemProduct_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f08cNamaItemProduct_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf08cNamaItemProduct_v50)

        Dim fieldf09cKodeSubItemProduct_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f09cKodeSubItemProduct_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf09cKodeSubItemProduct_v50)

        Dim fieldf10cNamaSubItemProduct_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f10cNamaSubItemProduct_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf10cNamaSubItemProduct_v50)

        Dim fieldf11cKodeProductionProcess_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f11cKodeProductionProcess_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf11cKodeProductionProcess_v50)

        Dim fieldf12cNamaProductionProcess_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f12cNamaProductionProcess_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf12cNamaProductionProcess_v50)

        Dim fieldf13cKodePlating_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f13cKodePlating_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf13cKodePlating_v50)

        Dim fieldf14cNamaPlating_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f14cNamaPlating_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf14cNamaPlating_v50)

        Dim fieldf15cKodeFinishing_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f15cKodeFinishing_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf15cKodeFinishing_v50)

        Dim fieldf16cNamaFinishing_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f16cNamaFinishing_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf16cNamaFinishing_v50)

        Dim fieldf17nGrossWeight_n94 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Double"), .ColumnName = "f17nGrossWeight_n94", .DefaultValue = 0}
        dtDataTable.Columns.Add(fieldf17nGrossWeight_n94)

        Dim fieldf18cKodeSize_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f18cKodeSize_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf18cKodeSize_v50)

        Dim fieldf19cNamaSize_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f19cNamaSize_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf19cNamaSize_v50)

        Dim fieldf20cKeterangan_v150 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f20cKeterangan_v150", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf20cKeterangan_v150)

        Dim fieldf40cIDUser_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f40cIDUser_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf40cIDUser_v50)

        Dim fieldf41cNamaUser_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f41cNamaUser_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf41cNamaUser_v50)

        Dim fieldf42dCreatedDate As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.DateTime"), .ColumnName = "f42dCreatedDate", .DefaultValue = "3000-01-01"}
        dtDataTable.Columns.Add(fieldf42dCreatedDate)

        Return dtDataTable
    End Function

    Public Sub dtInit30DESIGNMASTER()
        prop_dt30DESIGNMASTER = Nothing
        prop_dt30DESIGNMASTER = dtCreate30DESIGNMASTER()
        prop_dt30DESIGNMASTER.Clear()
    End Sub

    Public Sub dtAddNew30DESIGNMASTER(ByVal prmk01cKodeDesignMaster_v50 As String, ByVal prmf01cKodeBrand_v50 As String, ByVal prmf02cNamaBrand_v50 As String, ByVal prmf03cKodeProject_v50 As String, ByVal prmf04cNamaProject_v50 As String, ByVal prmf05cKodeNamingProduct_v50 As String, ByVal prmf06cNamaNamingProduct_v50 As String, ByVal prmf07cKodeItemProduct_v50 As String, ByVal prmf08cNamaItemProduct_v50 As String, ByVal prmf09cKodeSubItemProduct_v50 As String, ByVal prmf10cNamaSubItemProduct_v50 As String, ByVal prmf11cKodeProductionProcess_v50 As String, ByVal prmf12cNamaProductionProcess_v50 As String, ByVal prmf13cKodePlating_v50 As String, ByVal prmf14cNamaPlating_v50 As String, ByVal prmf15cKodeFinishing_v50 As String, ByVal prmf16cNamaFinishing_v50 As String, ByVal prmf17nGrossWeight_n94 As Double, ByVal prmf18cKodeSize_v50 As String, ByVal prmf19cNamaSize_v50 As String, ByVal prmf20cKeterangan_v150 As String, ByVal prmf40cIDUser_v50 As String, ByVal prmf41cNamaUser_v50 As String, ByVal prmf42dCreatedDate As Date)

        Dim oDataRow As DataRow = prop_dt30DESIGNMASTER.NewRow()

        oDataRow("k01cKodeDesignMaster_v50") = prmk01cKodeDesignMaster_v50
        oDataRow("f01cKodeBrand_v50") = prmf01cKodeBrand_v50
        oDataRow("f02cNamaBrand_v50") = prmf02cNamaBrand_v50
        oDataRow("f03cKodeProject_v50") = prmf03cKodeProject_v50
        oDataRow("f04cNamaProject_v50") = prmf04cNamaProject_v50
        oDataRow("f05cKodeNamingProduct_v50") = prmf05cKodeNamingProduct_v50
        oDataRow("f06cNamaNamingProduct_v50") = prmf06cNamaNamingProduct_v50
        oDataRow("f07cKodeItemProduct_v50") = prmf07cKodeItemProduct_v50
        oDataRow("f08cNamaItemProduct_v50") = prmf08cNamaItemProduct_v50
        oDataRow("f09cKodeSubItemProduct_v50") = prmf09cKodeSubItemProduct_v50
        oDataRow("f10cNamaSubItemProduct_v50") = prmf10cNamaSubItemProduct_v50
        oDataRow("f11cKodeProductionProcess_v50") = prmf11cKodeProductionProcess_v50
        oDataRow("f12cNamaProductionProcess_v50") = prmf12cNamaProductionProcess_v50
        oDataRow("f13cKodePlating_v50") = prmf13cKodePlating_v50
        oDataRow("f14cNamaPlating_v50") = prmf14cNamaPlating_v50
        oDataRow("f15cKodeFinishing_v50") = prmf15cKodeFinishing_v50
        oDataRow("f16cNamaFinishing_v50") = prmf16cNamaFinishing_v50
        oDataRow("f17nGrossWeight_n94") = prmf17nGrossWeight_n94
        oDataRow("f18cKodeSize_v50") = prmf18cKodeSize_v50
        oDataRow("f19cNamaSize_v50") = prmf19cNamaSize_v50
        oDataRow("f20cKeterangan_v150") = prmf20cKeterangan_v150
        oDataRow("f40cIDUser_v50") = prmf40cIDUser_v50
        oDataRow("f41cNamaUser_v50") = prmf41cNamaUser_v50
        oDataRow("f42dCreatedDate") = prmf42dCreatedDate

        prop_dt30DESIGNMASTER.Rows.Add(oDataRow)
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

'********** end of .NET Controller : clsController30DESIGNMASTER.vb ****************
