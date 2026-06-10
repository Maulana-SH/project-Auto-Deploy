'********** create .NET Controller : clsController34RUBBERSILVERMASTER.vb ****************

Public Class clsCtrlMRP34RUBBERSILVERMASTER
     Implements IDisposable

Public Property prop_dt34RUBBERSILVERMASTER As DataTable

Private Function dtCreate34RUBBERSILVERMASTER As DataTable
     Dim dtDataTable As New DataTable

     Dim fieldk01cRubberSilverCode_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k01cRubberSilverCode_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldk01cRubberSilverCode_v50)

     Dim fieldf01dDate As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.DateTime"), .ColumnName = "f01dDate", .DefaultValue = "3000-01-01"}
     dtDataTable.Columns.Add(fieldf01dDate)

     Dim fieldf02cInOutRevision_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f02cInOutRevision_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf02cInOutRevision_v50)

     Dim fieldf03cGroupRubberSilver_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f03cGroupRubberSilver_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf03cGroupRubberSilver_v50)

     Dim fieldf04cKodeKaretLama_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f04cKodeKaretLama_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf04cKodeKaretLama_v50)

     Dim fieldf05cKodeDesignMaster_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f05cKodeDesignMaster_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf05cKodeDesignMaster_v50)

     Dim fieldf06cKodeMaterial_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f06cKodeMaterial_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf06cKodeMaterial_v50)

     Dim fieldf07cNamaMaterial_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f07cNamaMaterial_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf07cNamaMaterial_v50)

     Dim fieldf08cKodeBrand_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f08cKodeBrand_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf08cKodeBrand_v50)

     Dim fieldf09cNamaBrand_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f09cNamaBrand_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf09cNamaBrand_v50)

     Dim fieldf10cKodeProject_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f10cKodeProject_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf10cKodeProject_v50)

     Dim fieldf11cNamaProject_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f11cNamaProject_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf11cNamaProject_v50)

     Dim fieldf12cKodeProductNaming_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f12cKodeProductNaming_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf12cKodeProductNaming_v50)

     Dim fieldf13cNamaProductNaming_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f13cNamaProductNaming_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf13cNamaProductNaming_v50)

     Dim fieldf14cKodeItem_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f14cKodeItem_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf14cKodeItem_v50)

     Dim fieldf15cNamaItem_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f15cNamaItem_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf15cNamaItem_v50)

     Dim fieldf16cKodeStatus_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f16cKodeStatus_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf16cKodeStatus_v50)

     Dim fieldf17cNamaStatus_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f17cNamaStatus_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf17cNamaStatus_v50)

     Dim fieldf18nSizeManual_n92 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Double"), .ColumnName = "f18nSizeManual_n92", .DefaultValue = 0}
     dtDataTable.Columns.Add(fieldf18nSizeManual_n92)

     Dim fieldf19cSizeSML As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f19cSizeSML", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf19cSizeSML)

        Dim fieldf20nJmlRepeat_int As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Int32"), .ColumnName = "f20nJmlRepeat_int", .DefaultValue = 0}
        dtDataTable.Columns.Add(fieldf20nJmlRepeat_int)

     Dim fieldf21cOrderDecision_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f21cOrderDecision_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf21cOrderDecision_v50)

     Dim fieldf22cCatatan_v150 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f22cCatatan_v150", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf22cCatatan_v150)

     Dim fieldf40cIDUser_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f40cIDUser_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf40cIDUser_v50)

     Dim fieldf41cNamaUser_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f41cNamaUser_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf41cNamaUser_v50)

     Dim fieldf42dCreatedDate As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.DateTime"), .ColumnName = "f42dCreatedDate", .DefaultValue = "3000-01-01"}
     dtDataTable.Columns.Add(fieldf42dCreatedDate)

     Return dtDataTable
End Function

Public Sub dtInit34RUBBERSILVERMASTER()
     prop_dt34RUBBERSILVERMASTER = Nothing
     prop_dt34RUBBERSILVERMASTER = dtCreate34RUBBERSILVERMASTER()
     prop_dt34RUBBERSILVERMASTER.Clear()
End Sub

    Public Sub dtAddNew34RUBBERSILVERMASTER(ByVal prmk01cRubberSilverCode_v50 As String,
           ByVal prmf01dDate As Date, ByVal prmf02cInOutRevision_v50 As String,
           ByVal prmf03cGroupRubberSilver_v50 As String, ByVal prmf04cKodeKaretLama_v50 As String,
           ByVal prmf05cKodeDesignMaster_v50 As String, ByVal prmf06cKodeMaterial_v50 As String,
           ByVal prmf07cNamaMaterial_v50 As String, ByVal prmf08cKodeBrand_v50 As String,
           ByVal prmf09cNamaBrand_v50 As String, ByVal prmf10cKodeProject_v50 As String,
           ByVal prmf11cNamaProject_v50 As String, ByVal prmf12cKodeProductNaming_v50 As String,
           ByVal prmf13cNamaProductNaming_v50 As String, ByVal prmf14cKodeItem_v50 As String,
           ByVal prmf15cNamaItem_v50 As String, ByVal prmf16cKodeStatus_v50 As String,
           ByVal prmf17cNamaStatus_v50 As String, ByVal prmf18nSizeManual_n92 As Double,
           ByVal prmf19cSizeSML As String, ByVal prmf20nJmlRepeat_int As Integer,
           ByVal prmf21cOrderDecision_v50 As String, ByVal prmf22cCatatan_v150 As String,
           ByVal prmf40cIDUser_v50 As String, ByVal prmf41cNamaUser_v50 As String,
           ByVal prmf42dCreatedDate As Date)

        Dim oDataRow As DataRow = prop_dt34RUBBERSILVERMASTER.NewRow()

        oDataRow("k01cRubberSilverCode_v50") = prmk01cRubberSilverCode_v50
        oDataRow("f01dDate") = prmf01dDate
        oDataRow("f02cInOutRevision_v50") = prmf02cInOutRevision_v50
        oDataRow("f03cGroupRubberSilver_v50") = prmf03cGroupRubberSilver_v50
        oDataRow("f04cKodeKaretLama_v50") = prmf04cKodeKaretLama_v50
        oDataRow("f05cKodeDesignMaster_v50") = prmf05cKodeDesignMaster_v50
        oDataRow("f06cKodeMaterial_v50") = prmf06cKodeMaterial_v50
        oDataRow("f07cNamaMaterial_v50") = prmf07cNamaMaterial_v50
        oDataRow("f08cKodeBrand_v50") = prmf08cKodeBrand_v50
        oDataRow("f09cNamaBrand_v50") = prmf09cNamaBrand_v50
        oDataRow("f10cKodeProject_v50") = prmf10cKodeProject_v50
        oDataRow("f11cNamaProject_v50") = prmf11cNamaProject_v50
        oDataRow("f12cKodeProductNaming_v50") = prmf12cKodeProductNaming_v50
        oDataRow("f13cNamaProductNaming_v50") = prmf13cNamaProductNaming_v50
        oDataRow("f14cKodeItem_v50") = prmf14cKodeItem_v50
        oDataRow("f15cNamaItem_v50") = prmf15cNamaItem_v50
        oDataRow("f16cKodeStatus_v50") = prmf16cKodeStatus_v50
        oDataRow("f17cNamaStatus_v50") = prmf17cNamaStatus_v50
        oDataRow("f18nSizeManual_n92") = prmf18nSizeManual_n92
        oDataRow("f19cSizeSML") = prmf19cSizeSML
        oDataRow("f20nJmlRepeat_int") = prmf20nJmlRepeat_int
        oDataRow("f21cOrderDecision_v50") = prmf21cOrderDecision_v50
        oDataRow("f22cCatatan_v150") = prmf22cCatatan_v150
        oDataRow("f40cIDUser_v50") = prmf40cIDUser_v50
        oDataRow("f41cNamaUser_v50") = prmf41cNamaUser_v50
        oDataRow("f42dCreatedDate") = prmf42dCreatedDate

        prop_dt34RUBBERSILVERMASTER.Rows.Add(oDataRow)
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

'********** end of .NET Controller : clsController34RUBBERSILVERMASTER.vb ****************
