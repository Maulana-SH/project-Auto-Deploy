Public Class clsCtrlMRP35JOBCARD
    Implements IDisposable

    Public Property prop_dt35JOBCARD As DataTable

    Private Function dtCreate35JOBCARD() As DataTable
        Dim dtDataTable As New DataTable

        Dim fieldk01cKodeValidation_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k01cKodeValidation_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldk01cKodeValidation_v50)

        Dim fieldk02cKodeMasterRouting_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k02cKodeMasterRouting_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldk02cKodeMasterRouting_v50)

        Dim fieldk03cKodeDesignMaster As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k03cKodeDesignMaster", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldk03cKodeDesignMaster)

        Dim fieldf01cKodeProduct_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f01cKodeJCProductType_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf01cKodeProduct_v50)

        Dim fieldf02cNameProduct_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f02cNameJCProductType_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf02cNameProduct_v50)

        Dim fieldf03cKodeSubtypeProduct_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f03cKodeJCProductSubtype_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf03cKodeSubtypeProduct_v50)

        Dim fieldf04cNameSubtypeProduct_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f04cNameJCProductSubtype_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf04cNameSubtypeProduct_v50)

        Dim fieldf05dInputDateAdmin As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.DateTime"), .ColumnName = "f05dInputDateAdmin", .DefaultValue = "3000-01-01"}
        dtDataTable.Columns.Add(fieldf05dInputDateAdmin)

        Dim fieldf06dDeliveryDate As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.DateTime"), .ColumnName = "f06dDeliveryDate", .DefaultValue = "3000-01-01"}
        dtDataTable.Columns.Add(fieldf06dDeliveryDate)

        Dim fieldf07cKodeItemProduct_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f07cKodeItemProduct_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf07cKodeItemProduct_v50)

        Dim fieldf08cNameItemProduct_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f08cNameItemProduct_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf08cNameItemProduct_v50)

        Dim fieldf09cKodeSubItemProduct_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f09cKodeSubItemProduct_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf09cKodeSubItemProduct_v50)

        Dim fieldf10cNameSubItemProduct_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f10cNameSubItemProduct_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf10cNameSubItemProduct_v50)

        Dim fieldf11cSize_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f11cKodeSize_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf11cSize_v50)

        Dim fieldf12cNameSize_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f12cNameSize_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf12cNameSize_v50)

        Dim fieldf13cKodeProductionProcess_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f13cKodeProductionProcess_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf13cKodeProductionProcess_v50)

        Dim fieldf14cNameProductionProcess_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f14cNameProductionProcess_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf14cNameProductionProcess_v50)

        Dim fieldf15cKodePlating_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f15cKodePlating_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf15cKodePlating_v50)

        Dim fieldf16cNamePlating_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f16cNamePlating_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf16cNamePlating_v50)

        Dim fieldf17cKodeKodeFinishing_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f17cKodeKodeFinishing_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf17cKodeKodeFinishing_v50)

        Dim fieldf18cNameFinishing_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f18cNameFinishing_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf18cNameFinishing_v50)

        Dim fieldf19cKodeMasterType_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f19cKodeMasterType_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf19cKodeMasterType_v50)

        Dim fieldf20cNameMasterType_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f20cNameMasterType_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf20cNameMasterType_v50)

        Dim fieldf21cKodeStatusOrder_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f21cKodeStatusOrder_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf21cKodeStatusOrder_v50)

        Dim fieldf22cNameStatusOrder_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f22cNameStatusOrder_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf22cNameStatusOrder_v50)

        Dim fieldf23cKodeProject_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f23cKodeProject_v50", .DefaultValue = 0}
        dtDataTable.Columns.Add(fieldf23cKodeProject_v50)

        Dim fieldf24cNameProject_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f24cNameProject_v50", .DefaultValue = 0}
        dtDataTable.Columns.Add(fieldf24cNameProject_v50)

        Dim fieldf25cKodeProduct_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f25cKodeProduct_v50", .DefaultValue = 0}
        dtDataTable.Columns.Add(fieldf25cKodeProduct_v50)

        Dim fieldf26cNameProduct_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f26cNameProduct_v50", .DefaultValue = 0}
        dtDataTable.Columns.Add(fieldf26cNameProduct_v50)

        Dim fieldf27nEstimasiBerat_n92 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Double"), .ColumnName = "f27nEstimasiBerat_n92", .DefaultValue = 0}
        dtDataTable.Columns.Add(fieldf27nEstimasiBerat_n92)

        Dim fieldf28cKodeDesigner_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f28cKodeDesigner_v50", .DefaultValue = 0}
        dtDataTable.Columns.Add(fieldf28cKodeDesigner_v50)

        Dim fieldf29cNameDesigner_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f29cNameDesigner_v50", .DefaultValue = 0}
        dtDataTable.Columns.Add(fieldf29cNameDesigner_v50)

        Dim fieldf30objGambar3D01 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Byte[]"), .ColumnName = "f30objGambar3D01"}
        dtDataTable.Columns.Add(fieldf30objGambar3D01)

        Dim fieldf31objGambar3D02 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Byte[]"), .ColumnName = "f31objGambar3D02"}
        dtDataTable.Columns.Add(fieldf31objGambar3D02)

        Dim fieldf32objGambar3D03 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Byte[]"), .ColumnName = "f32objGambar3D03"}
        dtDataTable.Columns.Add(fieldf32objGambar3D03)

        Dim fieldf33cKeterangan_v100 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f33cKeterangan_v100", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf33cKeterangan_v100)

        Dim fieldf34nPoint_n92 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Double"), .ColumnName = "f34nPoint_n92", .DefaultValue = 0}
        dtDataTable.Columns.Add(fieldf34nPoint_n92)

        Dim fieldf35cKodeTypeSPK As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f35cKodeTypeSPK", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf35cKodeTypeSPK)

        Dim fieldf36cNamaTypeSPK As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f36cNamaTypeSPK", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf36cNamaTypeSPK)

        Dim fieldf37cKodeValidationLama As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f37cKodeValidationLama", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf37cKodeValidationLama)

        Dim fieldf40cIDUser_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f40cIDUser_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf40cIDUser_v50)

        Dim fieldf41cNamaUser_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f41cNamaUser_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf41cNamaUser_v50)

        Dim fieldf42dCreatedDate As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.DateTime"), .ColumnName = "f42dCreatedDate", .DefaultValue = "3000-01-01"}
        dtDataTable.Columns.Add(fieldf42dCreatedDate)

        Return dtDataTable
    End Function


    Public Sub dtInit35JOBCARD()
        prop_dt35JOBCARD = Nothing
        prop_dt35JOBCARD = dtCreate35JOBCARD()
        prop_dt35JOBCARD.Clear()
    End Sub

    Public Sub dtAddNew35JOBCARD(ByVal prmk01cKodeValidation As String, ByVal prmk02cKodeMasterRouting As String, ByVal prmk03cKodeDesignMaster As String,
                                 ByVal prmf01cKodeJCProductType As String, ByVal prmf02cNameJCProductType As String,
                                 ByVal prmf03cKodeJCProductSubtype As String, ByVal prmf04cNameJCProductSubtype As String,
                                 ByVal prmf05dInputDateAdmin As Date, ByVal prmf06dDeliveryDate As Date,
                                 ByVal prmf07cKodeItemProduct As String, ByVal prmf08cNameItemProduct As String,
                                 ByVal prmf09cKodeSubItemProduct As String, ByVal prmf10cNameSubItemProduct As String,
                                 ByVal prmf11cKodeSize As String, ByVal prmf12cNameSize As String,
                                 ByVal prmf13KodeProductionProcess As String, ByVal prmf14cNameProductionProcess As String,
                                 ByVal prmff15cKodePlating As String, ByVal prmf16cNamePlating As String,
                                 ByVal prmf17cKodeKodeFinishing As String, ByVal prmf18cNameFinishing As String,
                                 ByVal prmf19cKodeMasterType As String, ByVal prmf20cNameMasterType As String,
                                 ByVal prmf21cKodeStatusOrder As String, ByVal prmf22cNameStatusOrder As String,
                                 ByVal prmf23cKodeProject As String, ByVal prmf24cNameProject As String,
                                 ByVal prmf25cKodeProduct As String, ByVal prmf26cNameProduct As String,
                                 ByVal prmf27nEstimasiBerat As Double,
                                 ByVal prmf28cKodeDesigner As String, ByVal prmf29cNameDesigner As String,
                                 ByVal prmf30objGambar3D01 As Byte(), ByVal prmf31objGambar3D02 As Byte(), ByVal prmf32objGambar3D03 As Byte(),
                                 ByVal prmf33cKeterangan As String, ByVal prmf34nPoint As Double,
                                 ByVal prmf35KodeTypeSPK As String, ByVal prmf36NamaTypeSPK As String, ByVal prmf37KodeValidasiLama As String,
                                 ByVal prmf40cIDUser_v50 As String, ByVal prmf41cNamaUser_v50 As String, ByVal prmf42dCreatedDate As DateTime)

        Dim oDataRow As DataRow = prop_dt35JOBCARD.NewRow()

        oDataRow("k01cKodeValidation_v50") = prmk01cKodeValidation
        oDataRow("k02cKodeMasterRouting_v50") = prmk02cKodeMasterRouting
        oDataRow("k03cKodeDesignMaster") = prmk03cKodeDesignMaster
        oDataRow("f01cKodeJCProductType_v50") = prmf01cKodeJCProductType
        oDataRow("f02cNameJCProductType_v50") = prmf02cNameJCProductType
        oDataRow("f03cKodeJCProductSubtype_v50") = prmf03cKodeJCProductSubtype
        oDataRow("f04cNameJCProductSubtype_v50") = prmf04cNameJCProductSubtype
        oDataRow("f05dInputDateAdmin") = prmf05dInputDateAdmin
        oDataRow("f06dDeliveryDate") = prmf06dDeliveryDate
        oDataRow("f07cKodeItemProduct_v50") = prmf07cKodeItemProduct
        oDataRow("f08cNameItemProduct_v50") = prmf08cNameItemProduct
        oDataRow("f09cKodeSubItemProduct_v50") = prmf09cKodeSubItemProduct
        oDataRow("f10cNameSubItemProduct_v50") = prmf10cNameSubItemProduct
        oDataRow("f11cKodeSize_v50") = prmf11cKodeSize
        oDataRow("f12cNameSize_v50") = prmf12cNameSize
        oDataRow("f13cKodeProductionProcess_v50") = prmf13KodeProductionProcess
        oDataRow("f14cNameProductionProcess_v50") = prmf14cNameProductionProcess
        oDataRow("f15cKodePlating_v50") = prmff15cKodePlating
        oDataRow("f16cNamePlating_v50") = prmf16cNamePlating
        oDataRow("f17cKodeKodeFinishing_v50") = prmf17cKodeKodeFinishing
        oDataRow("f18cNameFinishing_v50") = prmf18cNameFinishing
        oDataRow("f19cKodeMasterType_v50") = prmf19cKodeMasterType
        oDataRow("f20cNameMasterType_v50") = prmf20cNameMasterType
        oDataRow("f21cKodeStatusOrder_v50") = prmf21cKodeStatusOrder
        oDataRow("f22cNameStatusOrder_v50") = prmf22cNameStatusOrder
        oDataRow("f23cKodeProject_v50") = prmf23cKodeProject
        oDataRow("f24cNameProject_v50") = prmf24cNameProject
        oDataRow("f25cKodeProduct_v50") = prmf25cKodeProduct
        oDataRow("f26cNameProduct_v50") = prmf26cNameProduct
        oDataRow("f27nEstimasiBerat_n92") = prmf27nEstimasiBerat
        oDataRow("f28cKodeDesigner_v50") = prmf28cKodeDesigner
        oDataRow("f29cNameDesigner_v50") = prmf29cNameDesigner
        oDataRow("f30objGambar3D01") = prmf30objGambar3D01
        oDataRow("f31objGambar3D02") = prmf31objGambar3D02
        oDataRow("f32objGambar3D03") = prmf32objGambar3D03
        oDataRow("f33cKeterangan_v100") = prmf33cKeterangan
        oDataRow("f34nPoint_n92") = prmf34nPoint
        oDataRow("f35cKodeTypeSPK") = prmf35KodeTypeSPK
        oDataRow("f36cNamaTypeSPK") = prmf36NamaTypeSPK
        oDataRow("f37cKodeValidationLama") = prmf37KodeValidasiLama
        oDataRow("f40cIDUser_v50") = prmf40cIDUser_v50
        oDataRow("f41cNamaUser_v50") = prmf41cNamaUser_v50
        oDataRow("f42dCreatedDate") = prmf42dCreatedDate


        prop_dt35JOBCARD.Rows.Add(oDataRow)
    End Sub

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        ' TODO: uncomment the following line if Finalize() is overridden above.
        ' GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
