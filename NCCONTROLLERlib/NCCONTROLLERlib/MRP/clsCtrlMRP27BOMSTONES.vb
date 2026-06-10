'********** create .NET Controller : clsController27BOMSTONES.vb ****************

Public Class clsCtrlMRP27BOMSTONES
     Implements IDisposable

Public Property prop_dt27BOMSTONES As DataTable

Private Function dtCreate27BOMSTONES As DataTable
        Dim dtDataTable As New DataTable

        Dim fieldk01cKodeFinishedGood_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k01cKodeFinishedGood_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldk01cKodeFinishedGood_v50)

        Dim fieldk02cKodeStones_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k02cKodeStones_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldk02cKodeStones_v50)

        Dim fieldk03cVersionBOM_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k03cVersionBOM_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldk03cVersionBOM_v50)

        Dim fieldf01cStonesDesc_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f01cStonesDesc_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf01cStonesDesc_v50)

     Dim fieldf02cSizeDesc_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f02cSizeDesc_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf02cSizeDesc_v50)

     Dim fieldf03cQualityDesc_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f03cQualityDesc_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf03cQualityDesc_v50)

     Dim fieldf04cBrandDesc_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f04cBrandDesc_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf04cBrandDesc_v50)

     Dim fieldf05nButir_int As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Int32"), .ColumnName = "f05nButir_int", .DefaultValue = 0}
     dtDataTable.Columns.Add(fieldf05nButir_int)

     Dim fieldf06nBeratGram_n93 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Double"), .ColumnName = "f06nBeratGram_n93", .DefaultValue = 0}
     dtDataTable.Columns.Add(fieldf06nBeratGram_n93)

     Dim fieldf07cKodeSetting_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f07cKodeSetting_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf07cKodeSetting_v50)

     Dim fieldf08cSettingDesc_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f08cSettingDesc_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf08cSettingDesc_v50)

        Dim fieldf09nWeightPerPcs_n93 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Double"), .ColumnName = "f09nWeightPerPcs_n93", .DefaultValue = 0}
        dtDataTable.Columns.Add(fieldf09nWeightPerPcs_n93)

        Dim fieldf30cIDUser_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f30cIDUser_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf30cIDUser_v50)

     Dim fieldf31cNamaUser_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f31cNamaUser_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf31cNamaUser_v50)

     Dim fieldf32dCreatedDate As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.DateTime"), .ColumnName = "f32dCreatedDate", .DefaultValue = "3000-01-01"}
     dtDataTable.Columns.Add(fieldf32dCreatedDate)

        Return dtDataTable
End Function

Public Sub dtInit27BOMSTONES()
     prop_dt27BOMSTONES = Nothing
     prop_dt27BOMSTONES = dtCreate27BOMSTONES()
     prop_dt27BOMSTONES.Clear()
End Sub

    Public Sub dtAddNew27BOMSTONES(ByVal prmk01cKodeFinishedGood_v50 As String, ByVal prmk02cKodeStones_v50 As String, ByVal prmk03cVersionBOM_v50 As String,
                               ByVal prmf01cStonesDesc_v50 As String, ByVal prmf02cSizeDesc_v50 As String, ByVal prmf03cQualityDesc_v50 As String,
                               ByVal prmf04cBrandDesc_v50 As String, ByVal prmf05nButir_int As Integer, ByVal prmf06nBeratGram_n93 As Double,
                               ByVal prmf07cKodeSetting_v50 As String, ByVal prmf08cSettingDesc_v50 As String, ByVal prmf09nWeightPerPcs_n93 As Double,
                                   ByVal prmf30cIDUser_v50 As String, ByVal prmf31cNamaUser_v50 As String, ByVal prmf32dCreatedDate As Date)

        Dim oDataRow As DataRow = prop_dt27BOMSTONES.NewRow()

        oDataRow("k01cKodeFinishedGood_v50") = prmk01cKodeFinishedGood_v50
        oDataRow("k02cKodeStones_v50") = prmk02cKodeStones_v50
        oDataRow("k03cVersionBOM_v50") = prmk03cVersionBOM_v50
        oDataRow("f01cStonesDesc_v50") = prmf01cStonesDesc_v50
        oDataRow("f02cSizeDesc_v50") = prmf02cSizeDesc_v50
        oDataRow("f03cQualityDesc_v50") = prmf03cQualityDesc_v50
        oDataRow("f04cBrandDesc_v50") = prmf04cBrandDesc_v50
        oDataRow("f05nButir_int") = prmf05nButir_int
        oDataRow("f06nBeratGram_n93") = prmf06nBeratGram_n93
        oDataRow("f07cKodeSetting_v50") = prmf07cKodeSetting_v50
        oDataRow("f08cSettingDesc_v50") = prmf08cSettingDesc_v50
        oDataRow("f09nWeightPerPcs_n93") = prmf09nWeightPerPcs_n93
        oDataRow("f30cIDUser_v50") = prmf30cIDUser_v50
        oDataRow("f31cNamaUser_v50") = prmf31cNamaUser_v50
        oDataRow("f32dCreatedDate") = prmf32dCreatedDate

        prop_dt27BOMSTONES.Rows.Add(oDataRow)
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

'********** end of .NET Controller : clsController27BOMSTONES.vb ****************
