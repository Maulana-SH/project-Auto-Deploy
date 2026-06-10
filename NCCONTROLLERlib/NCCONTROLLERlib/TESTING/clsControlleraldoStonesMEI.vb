'********** create .NET Controller : clsControlleraldoStonesMEI.vb ****************

Public Class clsControlleraldoStonesMEI
     Implements IDisposable

Public Property prop_dtaldoStonesMEI As DataTable

Private Function dtCreatealdoStonesMEI As DataTable
        Dim dtDataTable As New DataTable


        Dim fieldk01cKodeLama As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k01cKodeLama", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldk01cKodeLama)

        Dim fieldK02cKodeBaru As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "K02cKodeBaru", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldK02cKodeBaru)

        Dim fieldf01StoneType As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f01StoneType", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf01StoneType)

     Dim fieldf02StonesShape As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f02StonesShape", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf02StonesShape)

     Dim fieldf03cColorStones As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f03cColorStones", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf03cColorStones)

     Dim fieldf04cSize As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f04cSize", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf04cSize)

     Dim fieldf05cQuality As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f05cQuality", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf05cQuality)

     Dim fieldf06cBrand As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f06cBrand", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf06cBrand)

     Dim fieldf07nBeratPerButir As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Double"), .ColumnName = "f07nBeratPerButir", .DefaultValue = 0}
     dtDataTable.Columns.Add(fieldf07nBeratPerButir)

     Dim fieldf08nBeratPer10Butir As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Double"), .ColumnName = "f08nBeratPer10Butir", .DefaultValue = 0}
     dtDataTable.Columns.Add(fieldf08nBeratPer10Butir)

     Dim fieldf09nBeratTotal As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Double"), .ColumnName = "f09nBeratTotal", .DefaultValue = 0}
     dtDataTable.Columns.Add(fieldf09nBeratTotal)

     Dim fieldf10nEstimasiButir As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.Double"), .ColumnName = "f10nEstimasiButir", .DefaultValue = 0}
     dtDataTable.Columns.Add(fieldf10nEstimasiButir)


        Return dtDataTable
End Function

Public Sub dtInitaldoStonesMEI()
     prop_dtaldoStonesMEI = Nothing
     prop_dtaldoStonesMEI = dtCreatealdoStonesMEI()
     prop_dtaldoStonesMEI.Clear()
End Sub

    Public Sub dtAddNewaldoStonesMEI(ByVal prmk01cKodeLama As String, ByVal prmK02cKodeBaru As String, ByVal prmf01StoneType As String, ByVal prmf02StonesShape As String, ByVal prmf03cColorStones As String, ByVal prmf04cSize As String, ByVal prmf05cQuality As String, ByVal prmf06cBrand As String, ByVal prmf07nBeratPerButir As Double, ByVal prmf08nBeratPer10Butir As Double, ByVal prmf09nBeratTotal As Double, ByVal prmf10nEstimasiButir As Double)

        Dim oDataRow As DataRow = prop_dtaldoStonesMEI.NewRow()

        oDataRow("k01cKodeLama") = prmk01cKodeLama
        oDataRow("K02cKodeBaru") = prmK02cKodeBaru
        oDataRow("f01StoneType") = prmf01StoneType
        oDataRow("f02StonesShape") = prmf02StonesShape
        oDataRow("f03cColorStones") = prmf03cColorStones
        oDataRow("f04cSize") = prmf04cSize
        oDataRow("f05cQuality") = prmf05cQuality
        oDataRow("f06cBrand") = prmf06cBrand
        oDataRow("f07nBeratPerButir") = prmf07nBeratPerButir
        oDataRow("f08nBeratPer10Butir") = prmf08nBeratPer10Butir
        oDataRow("f09nBeratTotal") = prmf09nBeratTotal
        oDataRow("f10nEstimasiButir") = prmf10nEstimasiButir


        prop_dtaldoStonesMEI.Rows.Add(oDataRow)
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

'********** end of .NET Controller : clsControlleraldoStonesMEI.vb ****************
