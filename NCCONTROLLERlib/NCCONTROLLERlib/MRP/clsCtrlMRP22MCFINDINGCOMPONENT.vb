'********** create .NET Controller : clsController22MCFINDINGCOMPONENT.vb ****************

Public Class clsCtrlMRP22MCFINDINGCOMPONENT
     Implements IDisposable

    Public Property prop_dt22MCFINDINGCOMPONENT As DataTable

    Public Property prop_lGridForImage As Boolean = False

    Private Function dtCreate22MCFINDINGCOMPONENT As DataTable
        Dim dtDataTable As New DataTable

        Dim fieldk01cKodeItemFindingComponent_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k01cKodeItemFindingComponent_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldk01cKodeItemFindingComponent_v50)

        Dim fieldf01cItemFindingComponentDesc_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f01cItemFindingComponentDesc_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf01cItemFindingComponentDesc_v50)

     Dim fieldf02cKodeJenisFindingComponent_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f02cKodeJenisFindingComponent_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf02cKodeJenisFindingComponent_v50)

     Dim fieldf03cJenisFindingComponentDesc_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f03cJenisFindingComponentDesc_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf03cJenisFindingComponentDesc_v50)

     Dim fieldf04cSize_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f04cSize_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf04cSize_v50)

     Dim fieldf05cKodeKadar_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f05cKodeKadar_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf05cKodeKadar_v50)

     Dim fieldf06cKadarDesc_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f06cKadarDesc_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf06cKadarDesc_v50)

     Dim fieldf07cKodeWarna_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f07cKodeWarna_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf07cKodeWarna_v50)

     Dim fieldf08cWarnaDesc_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f08cWarnaDesc_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf08cWarnaDesc_v50)

     Dim fieldf09nBeratPerPcs_n92 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Double"), .ColumnName = "f09nBeratPerPcs_n92", .DefaultValue = 0}
        dtDataTable.Columns.Add(fieldf09nBeratPerPcs_n92)

        Dim fieldf10cKodeRawMaterial_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f10cKodeRawMaterial_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf10cKodeRawMaterial_v50)

        Dim fieldf11cRawMaterialDesc_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f11cRawMaterialDesc_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf11cRawMaterialDesc_v50)

        Dim fieldf12cKodeSupplier_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f12cKodeSupplier_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf12cKodeSupplier_v50)

        Dim fieldf13cSupplierDesc_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f13cSupplierDesc_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf13cSupplierDesc_v50)

        Dim fieldf30cIDUser_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f30cIDUser_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf30cIDUser_v50)

     Dim fieldf31cNamaUser_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f31cNamaUser_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf31cNamaUser_v50)

     Dim fieldf32dCreatedDate As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.DateTime"), .ColumnName = "f32dCreatedDate", .DefaultValue = "3000-01-01"}
     dtDataTable.Columns.Add(fieldf32dCreatedDate)

        If prop_lGridForImage Then
            Dim fieldf50Image As DataColumn = New DataColumn() With {.DataType = GetType(Byte()), .ColumnName = "f50Image"}
            dtDataTable.Columns.Add(fieldf50Image)
        End If

        Return dtDataTable
End Function

Public Sub dtInit22MCFINDINGCOMPONENT()
     prop_dt22MCFINDINGCOMPONENT = Nothing
     prop_dt22MCFINDINGCOMPONENT = dtCreate22MCFINDINGCOMPONENT()
     prop_dt22MCFINDINGCOMPONENT.Clear()
End Sub

    Public Sub dtAddNew22MCFINDINGCOMPONENT(ByVal prmk01cKodeItemFindingComponent_v50 As String, ByVal prmf01cItemFindingComponentDesc_v50 As String,
                                            ByVal prmf02cKodeJenisFindingComponent_v50 As String, ByVal prmf03cJenisFindingComponentDesc_v50 As String,
                                            ByVal prmf04cSize_v50 As String, ByVal prmf05cKodeKadar_v50 As String, ByVal prmf06cKadarDesc_v50 As String,
                                            ByVal prmf07cKodeWarna_v50 As String, ByVal prmf08cWarnaDesc_v50 As String, ByVal prmf09nBeratPerPcs_n92 As Double,
                                            ByVal prmf10cKodeRawMaterial_v50 As String, ByVal prmf11cRawMaterialDesc_v50 As String,
                                            ByVal prmf12cKodeSupplier_v50 As String, ByVal prmf13cSupplierDesc_v50 As String,
                                            ByVal prmf30cIDUser_v50 As String, ByVal prmf31cNamaUser_v50 As String, ByVal prmf32dCreatedDate As Date,
                                            Optional prmf50Image As Byte() = Nothing)

        Dim oDataRow As DataRow = prop_dt22MCFINDINGCOMPONENT.NewRow()

        oDataRow("k01cKodeItemFindingComponent_v50") = prmk01cKodeItemFindingComponent_v50
        oDataRow("f01cItemFindingComponentDesc_v50") = prmf01cItemFindingComponentDesc_v50
        oDataRow("f02cKodeJenisFindingComponent_v50") = prmf02cKodeJenisFindingComponent_v50
        oDataRow("f03cJenisFindingComponentDesc_v50") = prmf03cJenisFindingComponentDesc_v50
        oDataRow("f04cSize_v50") = prmf04cSize_v50
        oDataRow("f05cKodeKadar_v50") = prmf05cKodeKadar_v50
        oDataRow("f06cKadarDesc_v50") = prmf06cKadarDesc_v50
        oDataRow("f07cKodeWarna_v50") = prmf07cKodeWarna_v50
        oDataRow("f08cWarnaDesc_v50") = prmf08cWarnaDesc_v50
        oDataRow("f09nBeratPerPcs_n92") = prmf09nBeratPerPcs_n92
        oDataRow("f10cKodeRawMaterial_v50") = prmf10cKodeRawMaterial_v50
        oDataRow("f11cRawMaterialDesc_v50") = prmf11cRawMaterialDesc_v50
        oDataRow("f12cKodeSupplier_v50") = prmf12cKodeSupplier_v50
        oDataRow("f13cSupplierDesc_v50") = prmf13cSupplierDesc_v50
        oDataRow("f30cIDUser_v50") = prmf30cIDUser_v50
        oDataRow("f31cNamaUser_v50") = prmf31cNamaUser_v50
        oDataRow("f32dCreatedDate") = prmf32dCreatedDate

        If prop_lGridForImage Then
            oDataRow("f50Image") = prmf50Image
        End If

        prop_dt22MCFINDINGCOMPONENT.Rows.Add(oDataRow)
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

'********** end of .NET Controller : clsController22MCFINDINGCOMPONENT.vb ****************
