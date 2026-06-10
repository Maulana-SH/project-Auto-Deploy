'********** create .NET Controller : clsController446MASTERVAULT.vb ****************

Public Class clsCtrlCasting446MASTERVAULT
    Implements IDisposable

    Public Property prop_dt446MASTERVAULT As DataTable

    Private Function dtCreate446MASTERVAULT() As DataTable
        Dim dtDataTable As New DataTable

        Dim fieldk01cKodeItemVault_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k01cKodeItemVault_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldk01cKodeItemVault_v50)

        Dim fieldf01cNamaItemVault_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f01cNamaItemVault_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf01cNamaItemVault_v50)

        Dim fieldf02cKodeGroupVault_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f02cKodeGroupVault_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf02cKodeGroupVault_v50)

        Dim fieldf03cNamaGroupVault_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f03cNamaGroupVault_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf03cNamaGroupVault_v50)

        Dim fieldf04cKodeRawMaterial_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f04cKodeRawMaterial_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf04cKodeRawMaterial_v50)

        Dim fieldf05cNamaRawMaterial_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f05cNamaRawMaterial_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf05cNamaRawMaterial_v50)

        Dim fieldf06cKodeWarna_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f06cKodeWarna_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf06cKodeWarna_v50)

        Dim fieldf07cNamaWarna_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f07cNamaWarna_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf07cNamaWarna_v50)

        Dim fieldf08cKodeKadar_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f08cKodeKadar_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf08cKodeKadar_v50)

        Dim fieldf09cNamaKadar_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f09cNamaKadar_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf09cNamaKadar_v50)

        Dim fieldf10cMerek_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f10cMerek_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf10cMerek_v50)

        Dim fieldf11cKodeSupplier_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f11cKodeSupplier_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf11cKodeSupplier_v50)

        Dim fieldf12cReserved_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f12cReserved_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf12cReserved_v50)

        Dim fieldf13cReserved_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f13cReserved_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf13cReserved_v50)

        Dim fieldf14nReserved_n92 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Double"), .ColumnName = "f14nReserved_n92", .DefaultValue = 0}
        dtDataTable.Columns.Add(fieldf14nReserved_n92)

        Dim fieldf15nReserved_n92 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Double"), .ColumnName = "f15nReserved_n92", .DefaultValue = 0}
        dtDataTable.Columns.Add(fieldf15nReserved_n92)

        Dim fieldf16nPosterSaldoInGram_n92 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Double"), .ColumnName = "f16nPosterSaldoInGram_n92", .DefaultValue = 0}
        dtDataTable.Columns.Add(fieldf16nPosterSaldoInGram_n92)

        Dim fieldf17cKodeAlloy_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f17cKodeAlloy_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf17cKodeAlloy_v50)

        Dim fieldf18cNamaSubItemVault_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f18cNamaSubItemVault_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf18cNamaSubItemVault_v50)

        Dim fieldf20cUserIDCreate_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f20cUserIDCreate_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf20cUserIDCreate_v50)

        Dim fieldf21cUserNameCreate_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f21cUserNameCreate_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf21cUserNameCreate_v50)

        Dim fieldf22dTglCreate As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.DateTime"), .ColumnName = "f22dTglCreate", .DefaultValue = "3000-01-01"}
        dtDataTable.Columns.Add(fieldf22dTglCreate)

        Dim fieldf23cUserIDUpdate_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f23cUserIDUpdate_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf23cUserIDUpdate_v50)

        Dim fieldf24cUserNameUpdate_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f24cUserNameUpdate_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf24cUserNameUpdate_v50)

        Dim fieldf25dTglUpdate As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.DateTime"), .ColumnName = "f25dTglUpdate", .DefaultValue = "3000-01-01"}
        dtDataTable.Columns.Add(fieldf25dTglUpdate)


        Return dtDataTable
    End Function

    Public Sub dtInit446MASTERVAULT()
        prop_dt446MASTERVAULT = Nothing
        prop_dt446MASTERVAULT = dtCreate446MASTERVAULT()
        prop_dt446MASTERVAULT.Clear()
    End Sub

    Public Sub dtAddNew446MASTERVAULT(ByVal prmk01cKodeItemVault_v50 As String, ByVal prmf01cNamaItemVault_v50 As String, ByVal prmf02cKodeGroupVault_v50 As String, ByVal prmf03cNamaGroupVault_v50 As String, ByVal prmf04cKodeRawMaterial_v50 As String, ByVal prmf05cNamaRawMaterial_v50 As String, ByVal prmf06cKodeWarna_v50 As String, ByVal prmf07cNamaWarna_v50 As String, ByVal prmf08cKodeKadar_v50 As String, ByVal prmf09cNamaKadar_v50 As String, ByVal prmf10cMerek_v50 As String, ByVal prmf11cKodeSupplier_v50 As String, ByVal prmf12cReserved_v50 As String, ByVal prmf13cReserved_v50 As String, ByVal prmf14nReserved_n92 As Double, ByVal prmf15nReserved_n92 As Double, ByVal prmf16nPosterSaldoInGram_n92 As Double, ByVal prmf17cKodeAlloy_v50 As String, ByVal prmf18cNamaSubItemVault_v50 As String, ByVal prmf20cUserIDCreate_v50 As String, ByVal prmf21cUserNameCreate_v50 As String, ByVal prmf22dTglCreate As Date, ByVal prmf23cUserIDUpdate_v50 As String, ByVal prmf24cUserNameUpdate_v50 As String, ByVal prmf25dTglUpdate As Date)

        Dim oDataRow As DataRow = prop_dt446MASTERVAULT.NewRow()


        oDataRow("k01cKodeItemVault_v50") = prmk01cKodeItemVault_v50
        oDataRow("f01cNamaItemVault_v50") = prmf01cNamaItemVault_v50
        oDataRow("f02cKodeGroupVault_v50") = prmf02cKodeGroupVault_v50
        oDataRow("f03cNamaGroupVault_v50") = prmf03cNamaGroupVault_v50
        oDataRow("f04cKodeRawMaterial_v50") = prmf04cKodeRawMaterial_v50
        oDataRow("f05cNamaRawMaterial_v50") = prmf05cNamaRawMaterial_v50
        oDataRow("f06cKodeWarna_v50") = prmf06cKodeWarna_v50
        oDataRow("f07cNamaWarna_v50") = prmf07cNamaWarna_v50
        oDataRow("f08cKodeKadar_v50") = prmf08cKodeKadar_v50
        oDataRow("f09cNamaKadar_v50") = prmf09cNamaKadar_v50
        oDataRow("f10cMerek_v50") = prmf10cMerek_v50
        oDataRow("f11cKodeSupplier_v50") = prmf11cKodeSupplier_v50
        oDataRow("f12cReserved_v50") = prmf12cReserved_v50
        oDataRow("f13cReserved_v50") = prmf13cReserved_v50
        oDataRow("f14nReserved_n92") = prmf14nReserved_n92
        oDataRow("f15nReserved_n92") = prmf15nReserved_n92
        oDataRow("f16nPosterSaldoInGram_n92") = prmf16nPosterSaldoInGram_n92
        oDataRow("f17cKodeAlloy_v50") = prmf17cKodeAlloy_v50
        oDataRow("f18cNamaSubItemVault_v50") = prmf18cNamaSubItemVault_v50
        oDataRow("f20cUserIDCreate_v50") = prmf20cUserIDCreate_v50
        oDataRow("f21cUserNameCreate_v50") = prmf21cUserNameCreate_v50
        oDataRow("f22dTglCreate") = prmf22dTglCreate
        oDataRow("f23cUserIDUpdate_v50") = prmf23cUserIDUpdate_v50
        oDataRow("f24cUserNameUpdate_v50") = prmf24cUserNameUpdate_v50
        oDataRow("f25dTglUpdate") = prmf25dTglUpdate

        prop_dt446MASTERVAULT.Rows.Add(oDataRow)
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

'********** end of .NET Controller : clsController446MASTERVAULT.vb ****************
