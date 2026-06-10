'********** create .NET Controller : clsController21MCRAWMATERIAL.vb ****************

Public Class clsCtrlMRP21MCRAWMATERIAL
     Implements IDisposable

Public Property prop_dt21MCRAWMATERIAL As DataTable

Private Function dtCreate21MCRAWMATERIAL As DataTable
     Dim dtDataTable As New DataTable

        Dim fieldk01cKodeItemCastedParts_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k01cKodeItemCastedParts_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldk01cKodeItemCastedParts_v50)

        Dim fieldf01cItemCastedPartsDesc_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f01cItemCastedPartsDesc_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf01cItemCastedPartsDesc_v50)

     Dim fieldf02cKodeRawMaterial_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f02cKodeRawMaterial_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf02cKodeRawMaterial_v50)

     Dim fieldf03cRawMaterialDesc_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f03cRawMaterialDesc_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf03cRawMaterialDesc_v50)

     Dim fieldf04cKodeKadar_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f04cKodeKadar_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf04cKodeKadar_v50)

     Dim fieldf05cKadarDesc_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f05cKadarDesc_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf05cKadarDesc_v50)

     Dim fieldf06cKodeWarna_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f06cKodeWarna_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf06cKodeWarna_v50)

     Dim fieldf07cWarnaDesc_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f07cWarnaDesc_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf07cWarnaDesc_v50)

     Dim fieldf08cKodeGoldType_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f08cKodeGoldType_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf08cKodeGoldType_v50)

     Dim fieldf09cGoldTypeDesc_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f09cGoldTypeDesc_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf09cGoldTypeDesc_v50)

        Dim fieldf10cKodeAlloy_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f10cKodeAlloy_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf10cKodeAlloy_v50)

        Dim fieldf11cAlloyDesc_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f11cAlloyDesc_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf11cAlloyDesc_v50)

        Dim fieldf30cIDUser_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f30cIDUser_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf30cIDUser_v50)

     Dim fieldf31cNamaUser_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f31cNamaUser_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf31cNamaUser_v50)

     Dim fieldf32dCreatedDate As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.DateTime"), .ColumnName = "f32dCreatedDate", .DefaultValue = "3000-01-01"}
     dtDataTable.Columns.Add(fieldf32dCreatedDate)

        Return dtDataTable
End Function

Public Sub dtInit21MCRAWMATERIAL()
     prop_dt21MCRAWMATERIAL = Nothing
     prop_dt21MCRAWMATERIAL = dtCreate21MCRAWMATERIAL()
     prop_dt21MCRAWMATERIAL.Clear()
End Sub

    Public Sub dtAddNew21MCRAWMATERIAL(ByVal prmk01cKodeItemCastedParts_v50 As String, ByVal prmf01cItemCastedPartsDesc_v50 As String, ByVal prmf02cKodeRawMaterial_v50 As String, ByVal prmf03cRawMaterialDesc_v50 As String, ByVal prmf04cKodeKadar_v50 As String, ByVal prmf05cKadarDesc_v50 As String, ByVal prmf06cKodeWarna_v50 As String, ByVal prmf07cWarnaDesc_v50 As String, ByVal prmf08cKodeGoldType_v50 As String, ByVal prmf09cGoldTypeDesc_v50 As String, ByVal prmf10cKodeAlloy_v50 As String, ByVal prmf11cAlloyDesc_v50 As String, ByVal prmf30cIDUser_v50 As String, ByVal prmf31cNamaUser_v50 As String, ByVal prmf32dCreatedDate As Date)

        Dim oDataRow As DataRow = prop_dt21MCRAWMATERIAL.NewRow()

        oDataRow("k01cKodeItemCastedParts_v50") = prmk01cKodeItemCastedParts_v50
        oDataRow("f01cItemCastedPartsDesc_v50") = prmf01cItemCastedPartsDesc_v50
        oDataRow("f02cKodeRawMaterial_v50") = prmf02cKodeRawMaterial_v50
        oDataRow("f03cRawMaterialDesc_v50") = prmf03cRawMaterialDesc_v50
        oDataRow("f04cKodeKadar_v50") = prmf04cKodeKadar_v50
        oDataRow("f05cKadarDesc_v50") = prmf05cKadarDesc_v50
        oDataRow("f06cKodeWarna_v50") = prmf06cKodeWarna_v50
        oDataRow("f07cWarnaDesc_v50") = prmf07cWarnaDesc_v50
        oDataRow("f08cKodeGoldType_v50") = prmf08cKodeGoldType_v50
        oDataRow("f09cGoldTypeDesc_v50") = prmf09cGoldTypeDesc_v50
        oDataRow("f10cKodeAlloy_v50") = prmf10cKodeAlloy_v50
        oDataRow("f11cAlloyDesc_v50") = prmf11cAlloyDesc_v50
        oDataRow("f30cIDUser_v50") = prmf30cIDUser_v50
        oDataRow("f31cNamaUser_v50") = prmf31cNamaUser_v50
        oDataRow("f32dCreatedDate") = prmf32dCreatedDate

        prop_dt21MCRAWMATERIAL.Rows.Add(oDataRow)
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

'********** end of .NET Controller : clsController21MCRAWMATERIAL.vb ****************
