'********** create .NET Controller : clsControllerINISHGOODS.vb ****************

Public Class clsControllerFINISHGOODS
    Implements IDisposable

    Public Property prop_dtFINISHGOODS As DataTable

    Private Function dtCreateINISHGOODS() As DataTable
        Dim dtDataTable As New DataTable

        'Dim fieldParttionID As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Int32"), .ColumnName = "PartitionID", .DefaultValue = 0}
        'dtDataTable.Columns.Add(fieldParttionID)

        Dim fieldk01SKU As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k01SKU", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldk01SKU)

        Dim fieldk02SPK As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k02SPK", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldk02SPK)

        Dim fieldk03ProductCode As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k03ProductCode", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldk03ProductCode)

        Dim fieldk04DesignCode As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k04DesignCode", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldk04DesignCode)

        Dim fieldKodeVendor As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "KodeVendor", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldKodeVendor)

        Dim fieldNamaVendor As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "NamaVendor", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldNamaVendor)

        Dim fieldKodeNORO As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "KodeNORO", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldKodeNORO)

        Dim fieldNamaNORO As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "NamaNORO", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldNamaNORO)

        Dim fieldKodeWarnaEmas As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "KodeWarnaEmas", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldKodeWarnaEmas)

        Dim fieldNamaWarnaEmas As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "NamaWarnaEmas", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldNamaWarnaEmas)

        Dim fieldKodeKadar As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "KodeKadar", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldKodeKadar)

        Dim fieldNamaKadar As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "NamaKadar", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldNamaKadar)

        Dim fieldKodeTipeBRJ As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "KodeTipeBRJ", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldKodeTipeBRJ)

        Dim fieldNamaTipeBRJ As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "NamaTipeBRJ", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldNamaTipeBRJ)

        Dim fieldkodeSize As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "kodeSize", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldkodeSize)

        Dim fieldNamaSize As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "NamaSize", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldNamaSize)

        Dim fieldKodeBrand As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "KodeBrand", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldKodeBrand)

        Dim fieldNamaBrand As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "NamaBrand", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldNamaBrand)

        Dim fieldKodeMaterial As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "KodeMaterial", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldKodeMaterial)

        Dim fieldNamaMaterial As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "NamaMaterial", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldNamaMaterial)

        Dim fieldKodeGender As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "KodeGender", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldKodeGender)

        Dim fieldNamaGender As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "NamaGender", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldNamaGender)

        Dim fieldKodeEngrave As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "KodeEngrave", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldKodeEngrave)

        Dim fieldNamaEngrave As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "NamaEngrave", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldNamaEngrave)

        Dim fieldKodeFindings As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "KodeFindings", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldKodeFindings)

        Dim fieldNamaFindings As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "NamaFindings", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldNamaFindings)

        Dim fieldkodePlating As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "kodePlating", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldkodePlating)

        Dim fieldNamaPlating As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "NamaPlating", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldNamaPlating)

        Dim fieldKodeFhinising As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "KodeFhinising", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldKodeFhinising)

        Dim fieldNamaFhinising As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "NamaFhinising", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldNamaFhinising)

        Dim fieldKodeStoneType As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "KodeStoneType", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldKodeStoneType)

        Dim fieldNamaStoneType As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "NamaStoneType", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldNamaStoneType)

        Dim fieldGroupData As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "GroupData", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldGroupData)

        Dim fieldOrderStatus As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "OrderStatus", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldOrderStatus)

        Dim fieldNoDocument As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "NoDocument", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldNoDocument)

        Dim fieldSatuanItem As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "SatuanItem", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldSatuanItem)

        Dim fieldNOSOProduction As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "NOSOProduction", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldNOSOProduction)

        Dim fieldPCSSKU As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Int32"), .ColumnName = "PCSSKU", .DefaultValue = 0}
        dtDataTable.Columns.Add(fieldPCSSKU)

        Dim fieldkadar As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Int32"), .ColumnName = "kadar", .DefaultValue = 0}
        dtDataTable.Columns.Add(fieldkadar)

        Dim fieldHargaBarcode As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Int32"), .ColumnName = "HargaBarcode", .DefaultValue = 0}
        dtDataTable.Columns.Add(fieldHargaBarcode)

        Dim fieldButirSTone As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Int32"), .ColumnName = "ButirSTone", .DefaultValue = 0}
        dtDataTable.Columns.Add(fieldButirSTone)

        Dim fieldBeratGrosss As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Double"), .ColumnName = "BeratGrosss", .DefaultValue = 0}
        dtDataTable.Columns.Add(fieldBeratGrosss)

        Dim fieldGramBatuPerPCS As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Double"), .ColumnName = "GramBatuPerPCS", .DefaultValue = 0}
        dtDataTable.Columns.Add(fieldGramBatuPerPCS)

        Dim fieldBeratNett As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Double"), .ColumnName = "BeratNett", .DefaultValue = 0}
        dtDataTable.Columns.Add(fieldBeratNett)

        Dim fieldHargaTGP As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Double"), .ColumnName = "HargaTGP", .DefaultValue = 0}
        dtDataTable.Columns.Add(fieldHargaTGP)

        Dim fieldTglInbound As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.DateTime"), .ColumnName = "TglInbound", .DefaultValue = "3000-01-01"}
        dtDataTable.Columns.Add(fieldTglInbound)

        Dim fieldf50Reserve As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f50Reserve", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf50Reserve)

        Dim fieldf51Reserve As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f51Reserve", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf51Reserve)

        Dim fieldf52Reserve As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f52Reserve", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf52Reserve)

        Dim fieldf53Reserve As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f53Reserve", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf53Reserve)

        Dim fieldf54Reserve As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f54Reserve", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf54Reserve)

        Dim fieldf55Reserve As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f55Reserve", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf55Reserve)

        Dim fieldf02Date As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.DateTime"), .ColumnName = "f02Date", .DefaultValue = "3000-01-01"}
        dtDataTable.Columns.Add(fieldf02Date)

        Dim fieldf03Date As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.DateTime"), .ColumnName = "f03Date", .DefaultValue = "3000-01-01"}
        dtDataTable.Columns.Add(fieldf03Date)

        Dim fieldf04Date As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.DateTime"), .ColumnName = "f04Date", .DefaultValue = "3000-01-01"}
        dtDataTable.Columns.Add(fieldf04Date)

        Dim fieldf05Date As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.DateTime"), .ColumnName = "f05Date", .DefaultValue = "3000-01-01"}
        dtDataTable.Columns.Add(fieldf05Date)

        Dim fieldf01Datetime As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.DateTime"), .ColumnName = "f01Datetime", .DefaultValue = "3000-01-01"}
        dtDataTable.Columns.Add(fieldf01Datetime)

        Dim fieldf01IDUser As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f01IDUser", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf01IDUser)

        Dim fieldf01NamaUser As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f01NamaUser", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf01NamaUser)

        Return dtDataTable
    End Function

    Public Sub dtInitFINISHGOODS()
        prop_dtFINISHGOODS = Nothing
        prop_dtFINISHGOODS = dtCreateINISHGOODS()
        prop_dtFINISHGOODS.Clear()
    End Sub

    Public Sub dtAddNewINISHGOODS(ByVal prmk01SKU As String, ByVal prmk02SPK As String, ByVal prmk03ProductCode As String, ByVal prmk04DesignCode As String, ByVal prmKodeVendor As String, ByVal prmNamaVendor As String, ByVal prmKodeNORO As String, ByVal prmNamaNORO As String, ByVal prmKodeWarnaEmas As String, ByVal prmNamaWarnaEmas As String, ByVal prmKodeKadar As String, ByVal prmNamaKadar As String, ByVal prmKodeTipeBRJ As String, ByVal prmNamaTipeBRJ As String, ByVal prmkodeSize As String, ByVal prmNamaSize As String, ByVal prmKodeBrand As String, ByVal prmNamaBrand As String, ByVal prmKodeMaterial As String, ByVal prmNamaMaterial As String, ByVal prmKodeGender As String, ByVal prmNamaGender As String, ByVal prmKodeEngrave As String, ByVal prmNamaEngrave As String, ByVal prmKodeFindings As String, ByVal prmNamaFindings As String, ByVal prmkodePlating As String, ByVal prmNamaPlating As String, ByVal prmKodeFhinising As String, ByVal prmNamaFhinising As String, ByVal prmKodeStoneType As String, ByVal prmNamaStoneType As String, ByVal prmGroupData As String, ByVal prmOrderStatus As String, ByVal prmNoDocument As String, ByVal prmSatuanItem As String, ByVal prmNOSOProduction As String, ByVal prmPCSSKU As Integer, ByVal prmkadar As Integer, ByVal prmHargaBarcode As Integer, ByVal prmButirSTone As Integer, ByVal prmBeratGrosss As Double, ByVal prmGramBatuPerPCS As Double, ByVal prmBeratNett As Double, ByVal prmHargaTGP As Double, ByVal prmTglInbound As Date, ByVal prmf50Reserve As String, ByVal prmf51Reserve As String, ByVal prmf52Reserve As String, ByVal prmf53Reserve As String, ByVal prmf54Reserve As String, ByVal prmf55Reserve As String, ByVal prmf02Date As Date, ByVal prmf03Date As Date, ByVal prmf04Date As Date, ByVal prmf05Date As Date, ByVal prmf01Datetime As Date, ByVal prmf01IDUser As String, ByVal prmf01NamaUser As String)

        Dim oDataRow As DataRow = prop_dtFINISHGOODS.NewRow()
        'ByVal prmParttionID As Integer,
        'oDataRow("PartitionID") = prmParttionID
        oDataRow("k01SKU") = prmk01SKU
        oDataRow("k02SPK") = prmk02SPK
        oDataRow("k03ProductCode") = prmk03ProductCode
        oDataRow("k04DesignCode") = prmk04DesignCode
        oDataRow("KodeVendor") = prmKodeVendor
        oDataRow("NamaVendor") = prmNamaVendor
        oDataRow("KodeNORO") = prmKodeNORO
        oDataRow("NamaNORO") = prmNamaNORO
        oDataRow("KodeWarnaEmas") = prmKodeWarnaEmas
        oDataRow("NamaWarnaEmas") = prmNamaWarnaEmas
        oDataRow("KodeKadar") = prmKodeKadar
        oDataRow("NamaKadar") = prmNamaKadar
        oDataRow("KodeTipeBRJ") = prmKodeTipeBRJ
        oDataRow("NamaTipeBRJ") = prmNamaTipeBRJ
        oDataRow("kodeSize") = prmkodeSize
        oDataRow("NamaSize") = prmNamaSize
        oDataRow("KodeBrand") = prmKodeBrand
        oDataRow("NamaBrand") = prmNamaBrand
        oDataRow("KodeMaterial") = prmKodeMaterial
        oDataRow("NamaMaterial") = prmNamaMaterial
        oDataRow("KodeGender") = prmKodeGender
        oDataRow("NamaGender") = prmNamaGender
        oDataRow("KodeEngrave") = prmKodeEngrave
        oDataRow("NamaEngrave") = prmNamaEngrave
        oDataRow("KodeFindings") = prmKodeFindings
        oDataRow("NamaFindings") = prmNamaFindings
        oDataRow("kodePlating") = prmkodePlating
        oDataRow("NamaPlating") = prmNamaPlating
        oDataRow("KodeFhinising") = prmKodeFhinising
        oDataRow("NamaFhinising") = prmNamaFhinising
        oDataRow("KodeStoneType") = prmKodeStoneType
        oDataRow("NamaStoneType") = prmNamaStoneType
        oDataRow("GroupData") = prmGroupData
        oDataRow("OrderStatus") = prmOrderStatus
        oDataRow("NoDocument") = prmNoDocument
        oDataRow("SatuanItem") = prmSatuanItem
        oDataRow("NOSOProduction") = prmNOSOProduction
        oDataRow("PCSSKU") = prmPCSSKU
        oDataRow("kadar") = prmkadar
        oDataRow("HargaBarcode") = prmHargaBarcode
        oDataRow("ButirSTone") = prmButirSTone
        oDataRow("BeratGrosss") = prmBeratGrosss
        oDataRow("GramBatuPerPCS") = prmGramBatuPerPCS
        oDataRow("BeratNett") = prmBeratNett
        oDataRow("HargaTGP") = prmHargaTGP
        oDataRow("TglInbound") = prmTglInbound
        oDataRow("f50Reserve") = prmf50Reserve
        oDataRow("f51Reserve") = prmf51Reserve
        oDataRow("f52Reserve") = prmf52Reserve
        oDataRow("f53Reserve") = prmf53Reserve
        oDataRow("f54Reserve") = prmf54Reserve
        oDataRow("f55Reserve") = prmf55Reserve
        oDataRow("f02Date") = prmf02Date
        oDataRow("f03Date") = prmf03Date
        oDataRow("f04Date") = prmf04Date
        oDataRow("f05Date") = prmf05Date
        oDataRow("f01Datetime") = prmf01Datetime
        oDataRow("f01IDUser") = prmf01IDUser
        oDataRow("f01NamaUser") = prmf01NamaUser

        prop_dtFINISHGOODS.Rows.Add(oDataRow)
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

'********** end of .NET Controller : clsControllerINISHGOODS.vb ****************
