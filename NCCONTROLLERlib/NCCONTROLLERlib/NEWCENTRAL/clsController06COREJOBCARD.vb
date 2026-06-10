'********** create .NET Controller : clsController06COREJOBCARD.vb ****************

Public Class clsController06COREJOBCARD
     Implements IDisposable

Public Property prop_dt06COREJOBCARD As DataTable

Private Function dtCreate06COREJOBCARD As DataTable
     Dim dtDataTable As New DataTable

        Dim fieldk01cSKUJobCard_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k01cSKUJobCard_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldk01cSKUJobCard_v50)

        Dim fieldf01dTanggalEntry As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.DateTime"), .ColumnName = "f01dTanggalEntry", .DefaultValue = "3000-01-01"}
     dtDataTable.Columns.Add(fieldf01dTanggalEntry)

     Dim fieldf02cJenisJobCard_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f02cJenisJobCard_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf02cJenisJobCard_v50)

     Dim fieldf03cKodeDivisi_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f03cKodeDivisi_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf03cKodeDivisi_v50)

     Dim fieldf04cKodeFinishGoods_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f04cKodeFinishGoods_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf04cKodeFinishGoods_v50)

     Dim fieldf05cNoPO_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f05cNoPO_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf05cNoPO_v50)

     Dim fieldf06cCustomer_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f06cCustomer_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf06cCustomer_v50)

     Dim fieldf07cKodeKaretLama_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f07cKodeKaretLama_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf07cKodeKaretLama_v50)

     Dim fieldf08cNORO_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f08cNORO_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf08cNORO_v50)

     Dim fieldf09cKodeTipeBRJ_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f09cKodeTipeBRJ_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf09cKodeTipeBRJ_v50)

     Dim fieldf10cKodeStockPesanan_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f10cKodeStockPesanan_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf10cKodeStockPesanan_v50)

        Dim fieldf11nSize_int As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Int32"), .ColumnName = "f11nSize_int", .DefaultValue = 0}
        dtDataTable.Columns.Add(fieldf11nSize_int)

     Dim fieldf12cKodeRMJobCard_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f12cKodeRMJobCard_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf12cKodeRMJobCard_v50)

     Dim fieldf13dTglDeliveryTime As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.DateTime"), .ColumnName = "f13dTglDeliveryTime", .DefaultValue = "3000-01-01"}
     dtDataTable.Columns.Add(fieldf13dTglDeliveryTime)

        Dim fieldf14nJmlKomponent_int As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Int32"), .ColumnName = "f14nJmlKomponent_int", .DefaultValue = 0}
        dtDataTable.Columns.Add(fieldf14nJmlKomponent_int)

     Dim fieldf15nBeratAkhir_n92 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Double"), .ColumnName = "f15nBeratAkhir_n92", .DefaultValue = 0}
     dtDataTable.Columns.Add(fieldf15nBeratAkhir_n92)

     Dim fieldf16nPoint_n92 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Double"), .ColumnName = "f16nPoint_n92", .DefaultValue = 0}
     dtDataTable.Columns.Add(fieldf16nPoint_n92)

     Dim fieldf17cKodeSAP_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f17cKodeSAP_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf17cKodeSAP_v50)

     Dim fieldf18cNamingProduct_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f18cNamingProduct_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf18cNamingProduct_v50)

     Dim fieldf19cNamaProject_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f19cNamaProject_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf19cNamaProject_v50)

     Dim fieldf20cDesigner_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f20cDesigner_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf20cDesigner_v50)

     Dim fieldf21cAlasanRevisi_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f21cAlasanRevisi_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf21cAlasanRevisi_v50)

     Dim fieldf22cKeterangan_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f22cKeterangan_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf22cKeterangan_v50)

     Dim fieldf23cNamaGambar_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f23cNamaGambar_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf23cNamaGambar_v50)

        Dim fieldf24dTglCloseJobCard As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.DateTime"), .ColumnName = "f24dTglCloseJobCard", .DefaultValue = "3000-01-01"}
        dtDataTable.Columns.Add(fieldf24dTglCloseJobCard)

        Dim fieldf25cKodeTingkatKesulitan_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f25cKodeTingkatKesulitan_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf25cKodeTingkatKesulitan_v50)

        Dim fieldf26cKodeBrandProduct_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f26cKodeBrandProduct_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf26cKodeBrandProduct_v50)

        Return dtDataTable
End Function

Public Sub dtInit06COREJOBCARD()
     prop_dt06COREJOBCARD = Nothing
     prop_dt06COREJOBCARD = dtCreate06COREJOBCARD()
     prop_dt06COREJOBCARD.Clear()
End Sub

    Public Sub dtAddNew06COREJOBCARD(ByVal prmk01cSKUJobCard_v50 As String, ByVal prmf01dTanggalEntry As Date, ByVal prmf02cJenisJobCard_v50 As String,
                                     ByVal prmf03cKodeDivisi_v50 As String, ByVal prmf04cKodeFinishGoods_v50 As String, ByVal prmf05cNoPO_v50 As String,
                                     ByVal prmf06cCustomer_v50 As String, ByVal prmf07cKodeKaretLama_v50 As String, ByVal prmf08cNORO_v50 As String,
                                     ByVal prmf09cKodeTipeBRJ_v50 As String, ByVal prmf10cKodeStockPesanan_v50 As String, ByVal prmf11nSize_int As Int32,
                                     ByVal prmf12cKodeRMJobCard_v50 As String, ByVal prmf13dTglDeliveryTime As Date, ByVal prmf14nJmlKomponent_int As Int32,
                                     ByVal prmf15nBeratAkhir_n92 As Double, ByVal prmf16nPoint_n92 As Double, ByVal prmf17cKodeSAP_v50 As String,
                                     ByVal prmf18cNamingProduct_v50 As String, ByVal prmf19cNamaProject_v50 As String, ByVal prmf20cDesigner_v50 As String,
                                     ByVal prmf21cAlasanRevisi_v50 As String, ByVal prmf22cKeterangan_v50 As String, ByVal prmf23cNamaGambar_v50 As String,
                                     ByVal prmf24dTglCloseJobCard As Date, ByVal prmf25cKodeTingkatKesulitan_v50 As String, ByVal prmf26cKodeBrandProduct_v50 As String)

        Dim oDataRow As DataRow = prop_dt06COREJOBCARD.NewRow()

        oDataRow("k01cSKUJobCard_v50") = prmk01cSKUJobCard_v50
        oDataRow("f01dTanggalEntry") = prmf01dTanggalEntry
        oDataRow("f02cJenisJobCard_v50") = prmf02cJenisJobCard_v50
        oDataRow("f03cKodeDivisi_v50") = prmf03cKodeDivisi_v50
        oDataRow("f04cKodeFinishGoods_v50") = prmf04cKodeFinishGoods_v50
        oDataRow("f05cNoPO_v50") = prmf05cNoPO_v50
        oDataRow("f06cCustomer_v50") = prmf06cCustomer_v50
        oDataRow("f07cKodeKaretLama_v50") = prmf07cKodeKaretLama_v50
        oDataRow("f08cNORO_v50") = prmf08cNORO_v50
        oDataRow("f09cKodeTipeBRJ_v50") = prmf09cKodeTipeBRJ_v50
        oDataRow("f10cKodeStockPesanan_v50") = prmf10cKodeStockPesanan_v50
        oDataRow("f11nSize_int") = prmf11nSize_int
        oDataRow("f12cKodeRMJobCard_v50") = prmf12cKodeRMJobCard_v50
        oDataRow("f13dTglDeliveryTime") = prmf13dTglDeliveryTime
        oDataRow("f14nJmlKomponent_int") = prmf14nJmlKomponent_int
        oDataRow("f15nBeratAkhir_n92") = prmf15nBeratAkhir_n92
        oDataRow("f16nPoint_n92") = prmf16nPoint_n92
        oDataRow("f17cKodeSAP_v50") = prmf17cKodeSAP_v50
        oDataRow("f18cNamingProduct_v50") = prmf18cNamingProduct_v50
        oDataRow("f19cNamaProject_v50") = prmf19cNamaProject_v50
        oDataRow("f20cDesigner_v50") = prmf20cDesigner_v50
        oDataRow("f21cAlasanRevisi_v50") = prmf21cAlasanRevisi_v50
        oDataRow("f22cKeterangan_v50") = prmf22cKeterangan_v50
        oDataRow("f23cNamaGambar_v50") = prmf23cNamaGambar_v50
        oDataRow("f24dTglCloseJobCard") = prmf24dTglCloseJobCard
        oDataRow("f25cKodeTingkatKesulitan_v50") = prmf25cKodeTingkatKesulitan_v50
        oDataRow("f26cKodeBrandProduct_v50") = prmf26cKodeBrandProduct_v50

        prop_dt06COREJOBCARD.Rows.Add(oDataRow)
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

'********** end of .NET Controller : clsController06COREJOBCARD.vb ****************
