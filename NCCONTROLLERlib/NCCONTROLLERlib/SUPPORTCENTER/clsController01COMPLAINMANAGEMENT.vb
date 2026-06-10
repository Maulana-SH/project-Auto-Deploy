Public Class clsController01COMPLAINMANAGEMENT
    Implements IDisposable

    Public Property prop_dt01COMPLAINMANAGEMENT As DataTable

    Private Function dtCreate01COMPLAINMANAGEMENT() As DataTable
        Dim dtDataTable As New DataTable

        Dim fieldk01cKomplainCode_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k01cKomplainCode_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldk01cKomplainCode_v50)

        Dim fieldf01cNamaProses_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f01cNamaProses_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf01cNamaProses_v50)

        Dim fieldf02cKeterangan_v500 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f02cKeterangan_v500", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf02cKeterangan_v500)

        Dim fieldf03cIDuser_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f03cIDuser_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf03cIDuser_v50)

        Dim fieldf04cNamaUser_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f04cNamaUser_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf04cNamaUser_v50)

        Dim fieldf05DateCreated_date As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.DateTime"), .ColumnName = "f05DateCreated_date", .DefaultValue = "3000-01-01"}
        dtDataTable.Columns.Add(fieldf05DateCreated_date)

        Dim fieldf06DateApprove_date As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.DateTime"), .ColumnName = "f06DateApprove_date", .DefaultValue = "3000-01-01"}
        dtDataTable.Columns.Add(fieldf06DateApprove_date)

        Dim fieldf07DateFixed_date As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.DateTime"), .ColumnName = "f07DateFixed_date", .DefaultValue = "3000-01-01"}
        dtDataTable.Columns.Add(fieldf07DateFixed_date)

        Dim fieldf08cSolusion_v500 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f08cSolusion_v500", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf08cSolusion_v500)

        Dim fieldf09cStatus_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f09cStatus_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf09cStatus_v50)

        Dim f10cIdUserApprove_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f10cIdUserApprove_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(f10cIdUserApprove_v50)

        Dim f11cNamaUserApprove_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f11cNamaUserApprove_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(f11cNamaUserApprove_v50)

        Dim f12cReserve_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f12cReserve_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(f12cReserve_v50)

        Dim f13nReserve_int As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Int32"), .ColumnName = "f13nReserve_int", .DefaultValue = 0}
        dtDataTable.Columns.Add(f13nReserve_int)


        Return dtDataTable
    End Function

    Public Sub dtInit01COMPLAINMANAGEMENT()
        prop_dt01COMPLAINMANAGEMENT = Nothing
        prop_dt01COMPLAINMANAGEMENT = dtCreate01COMPLAINMANAGEMENT()
        prop_dt01COMPLAINMANAGEMENT.Clear()
    End Sub

    Public Sub dtAddNew01COMPLAINMANAGEMENT(ByVal prmk01cKomplainCode_v50 As String, ByVal prmf01cNamaProses_v50 As String, ByVal prmf02cKeterangan_v500 As String,
                                           ByVal prmf03cIDuser_v50 As String, ByVal prmf04cNamaUser_v50 As String,
                                           ByVal prmf05DateCreated_date As Date, ByVal prmf06DateApprove_date As Date, ByVal prmf07DateFixed_date As Date,
                                           ByVal prmf08cSolusion_v500 As String, ByVal prmf09cStatus_v50 As String,
                                           ByVal prmf10cIdUserApprove_v50 As String, ByVal prmf11cNamaUserApprove_v50 As String,
                                           ByVal prmf12cReserve_v50 As String, ByVal prmf13nReserve_int As Integer)

        Dim oDataRow As DataRow = prop_dt01COMPLAINMANAGEMENT.NewRow()

        oDataRow("k01cKomplainCode_v50") = prmk01cKomplainCode_v50
        oDataRow("f01cNamaProses_v50") = prmf01cNamaProses_v50
        oDataRow("f02cKeterangan_v500") = prmf02cKeterangan_v500
        oDataRow("f03cIDuser_v50") = prmf03cIDuser_v50
        oDataRow("f04cNamaUser_v50") = prmf04cNamaUser_v50
        oDataRow("f05DateCreated_date") = prmf05DateCreated_date
        oDataRow("f06DateApprove_date") = prmf06DateApprove_date
        oDataRow("f07DateFixed_date") = prmf07DateFixed_date
        oDataRow("f08cSolusion_v500") = prmf08cSolusion_v500
        oDataRow("f09cStatus_v50") = prmf09cStatus_v50
        oDataRow("f10cIdUserApprove_v50") = prmf10cIdUserApprove_v50
        oDataRow("f11cNamaUserApprove_v50") = prmf11cNamaUserApprove_v50
        oDataRow("f12cReserve_v50") = prmf12cReserve_v50
        oDataRow("f13nReserve_int") = prmf13nReserve_int

        prop_dt01COMPLAINMANAGEMENT.Rows.Add(oDataRow)
    End Sub


#Region " IDisposable Support"
    Private disposedValue As Boolean

    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects)
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override finalizer
            ' TODO: set large fields to null
            disposedValue = True
        End If
    End Sub

    ' ' TODO: override finalizer only if 'Dispose(disposing As Boolean)' has code to free unmanaged resources
    ' Protected Overrides Sub Finalize()
    '     ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
    '     Dispose(disposing:=False)
    '     MyBase.Finalize()
    ' End Sub

    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code. Put cleanup code in 'Dispose(disposing As Boolean)' method
        Dispose(disposing:=True)
        GC.SuppressFinalize(Me)
    End Sub

#End Region
End Class
