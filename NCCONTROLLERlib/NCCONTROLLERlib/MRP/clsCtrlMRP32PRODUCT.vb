'********** create .NET Controller : clsController32PRODUCT.vb ****************

Public Class clsCtrlMRP32PRODUCT
     Implements IDisposable

    Public Property prop_dt32PRODUCT As DataTable
    Public Property prop_lGridForImage As Boolean = False

    Private Function dtCreate32PRODUCT As DataTable
     Dim dtDataTable As New DataTable

     Dim fieldk01cKodeProduct_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k01cKodeProduct_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldk01cKodeProduct_v50)

     Dim fieldf01cNamaProduct_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f01cNamaProduct_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf01cNamaProduct_v50)

     Dim fieldf02cKodeDesignMaster_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f02cKodeDesignMaster_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf02cKodeDesignMaster_v50)

     Dim fieldf03cKodeItemProduct_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f03cKodeItemProduct_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf03cKodeItemProduct_v50)

     Dim fieldf04cNamaItemProduct_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f04cNamaItemProduct_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf04cNamaItemProduct_v50)

     Dim fieldf05cKodeBrand_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f05cKodeBrand_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf05cKodeBrand_v50)

     Dim fieldf06cNamaBrand_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f06cNamaBrand_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf06cNamaBrand_v50)

     Dim fieldf07cKodeMaterial_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f07cKodeMaterial_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf07cKodeMaterial_v50)

     Dim fieldf08cNamaMaterial_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f08cNamaMaterial_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf08cNamaMaterial_v50)

     Dim fieldf09cKodeKadar_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f09cKodeKadar_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf09cKodeKadar_v50)

     Dim fieldf10cNamaKadar_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f10cNamaKadar_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf10cNamaKadar_v50)

     Dim fieldf11cKodeColor_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f11cKodeColor_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf11cKodeColor_v50)

     Dim fieldf12cNamaColor_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f12cNamaColor_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf12cNamaColor_v50)

     Dim fieldf13cKodeSize_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f13cKodeSize_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf13cKodeSize_v50)

     Dim fieldf14cNamaSize_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f14cNamaSize_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf14cNamaSize_v50)

     Dim fieldf15cKodeEngrave_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f15cKodeEngrave_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf15cKodeEngrave_v50)

     Dim fieldf16cNamaEngrave_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f16cNamaEngrave_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf16cNamaEngrave_v50)

     Dim fieldf17cKodeGender_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f17cKodeGender_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf17cKodeGender_v50)

     Dim fieldf18cNamaGender_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f18cNamaGender_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf18cNamaGender_v50)

     Dim fieldf19cKodePlating_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f19cKodePlating_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf19cKodePlating_v50)

     Dim fieldf20cNamaPlating_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f20cNamaPlating_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf20cNamaPlating_v50)

     Dim fieldf21cKodeFinishing_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f21cKodeFinishing_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf21cKodeFinishing_v50)

     Dim fieldf22cNamaFinishing_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f22cNamaFinishing_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf22cNamaFinishing_v50)

     Dim fieldf23cKodeStoneType_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f23cKodeStoneType_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf23cKodeStoneType_v50)

     Dim fieldf24cNamaStoneType_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f24cNamaStoneType_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf24cNamaStoneType_v50)

     Dim fieldf25cKodeStoneColor_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f25cKodeStoneColor_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf25cKodeStoneColor_v50)

     Dim fieldf26cNamaStoneColor_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f26cNamaStoneColor_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf26cNamaStoneColor_v50)

     Dim fieldf27cKodeFinding_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f27cKodeFinding_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf27cKodeFinding_v50)

     Dim fieldf28cNamaFinding_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f28cNamaFinding_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf28cNamaFinding_v50)

     Dim fieldf40cIDUser_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f40cIDUser_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf40cIDUser_v50)

     Dim fieldf41cNamaUser_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f41cNamaUser_v50", .DefaultValue = ""}
     dtDataTable.Columns.Add(fieldf41cNamaUser_v50)

     Dim fieldf42dCreatedDate As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.DateTime"), .ColumnName = "f42dCreatedDate", .DefaultValue = "3000-01-01"}
     dtDataTable.Columns.Add(fieldf42dCreatedDate)

        If prop_lGridForImage Then
            Dim fieldf50ImageFG As DataColumn = New DataColumn() With {.DataType = GetType(Byte()), .ColumnName = "f50ImageFG"}
            dtDataTable.Columns.Add(fieldf50ImageFG)

            Dim fieldf51ImageTehnik1 As DataColumn = New DataColumn() With {.DataType = GetType(Byte()), .ColumnName = "f51ImageTehnik1"}
            dtDataTable.Columns.Add(fieldf51ImageTehnik1)

            Dim fieldf52ImageTehnik2 As DataColumn = New DataColumn() With {.DataType = GetType(Byte()), .ColumnName = "f52ImageTehnik2"}
            dtDataTable.Columns.Add(fieldf52ImageTehnik2)

            Dim fieldf53ImageTehnik3 As DataColumn = New DataColumn() With {.DataType = GetType(Byte()), .ColumnName = "f53ImageTehnik3"}
            dtDataTable.Columns.Add(fieldf53ImageTehnik3)
        End If

        Return dtDataTable
End Function

Public Sub dtInit32PRODUCT()
     prop_dt32PRODUCT = Nothing
     prop_dt32PRODUCT = dtCreate32PRODUCT()
     prop_dt32PRODUCT.Clear()
End Sub

    Public Sub dtAddNew32PRODUCT(ByVal prmk01cKodeProduct_v50 As String, ByVal prmf01cNamaProduct_v50 As String, ByVal prmf02cKodeDesignMaster_v50 As String, ByVal prmf03cKodeItemProduct_v50 As String, ByVal prmf04cNamaItemProduct_v50 As String, ByVal prmf05cKodeBrand_v50 As String, ByVal prmf06cNamaBrand_v50 As String, ByVal prmf07cKodeMaterial_v50 As String, ByVal prmf08cNamaMaterial_v50 As String, ByVal prmf09cKodeKadar_v50 As String, ByVal prmf10cNamaKadar_v50 As String, ByVal prmf11cKodeColor_v50 As String, ByVal prmf12cNamaColor_v50 As String, ByVal prmf13cKodeSize_v50 As String, ByVal prmf14cNamaSize_v50 As String, ByVal prmf15cKodeEngrave_v50 As String, ByVal prmf16cNamaEngrave_v50 As String, ByVal prmf17cKodeGender_v50 As String, ByVal prmf18cNamaGender_v50 As String, ByVal prmf19cKodePlating_v50 As String, ByVal prmf20cNamaPlating_v50 As String, ByVal prmf21cKodeFinishing_v50 As String, ByVal prmf22cNamaFinishing_v50 As String, ByVal prmf23cKodeStoneType_v50 As String, ByVal prmf24cNamaStoneType_v50 As String, ByVal prmf25cKodeStoneColor_v50 As String, ByVal prmf26cNamaStoneColor_v50 As String, ByVal prmf27cKodeFinding_v50 As String, ByVal prmf28cNamaFinding_v50 As String, ByVal prmf40cIDUser_v50 As String, ByVal prmf41cNamaUser_v50 As String, ByVal prmf42dCreatedDate As Date,
                                 Optional prmf50ImageFG As Byte() = Nothing, Optional prmf51ImageTehnik1 As Byte() = Nothing,
                                 Optional prmf52ImageTehnik2 As Byte() = Nothing, Optional prmf53ImageTehnik3 As Byte() = Nothing)

        Dim oDataRow As DataRow = prop_dt32PRODUCT.NewRow()

        oDataRow("k01cKodeProduct_v50") = prmk01cKodeProduct_v50
        oDataRow("f01cNamaProduct_v50") = prmf01cNamaProduct_v50
        oDataRow("f02cKodeDesignMaster_v50") = prmf02cKodeDesignMaster_v50
        oDataRow("f03cKodeItemProduct_v50") = prmf03cKodeItemProduct_v50
        oDataRow("f04cNamaItemProduct_v50") = prmf04cNamaItemProduct_v50
        oDataRow("f05cKodeBrand_v50") = prmf05cKodeBrand_v50
        oDataRow("f06cNamaBrand_v50") = prmf06cNamaBrand_v50
        oDataRow("f07cKodeMaterial_v50") = prmf07cKodeMaterial_v50
        oDataRow("f08cNamaMaterial_v50") = prmf08cNamaMaterial_v50
        oDataRow("f09cKodeKadar_v50") = prmf09cKodeKadar_v50
        oDataRow("f10cNamaKadar_v50") = prmf10cNamaKadar_v50
        oDataRow("f11cKodeColor_v50") = prmf11cKodeColor_v50
        oDataRow("f12cNamaColor_v50") = prmf12cNamaColor_v50
        oDataRow("f13cKodeSize_v50") = prmf13cKodeSize_v50
        oDataRow("f14cNamaSize_v50") = prmf14cNamaSize_v50
        oDataRow("f15cKodeEngrave_v50") = prmf15cKodeEngrave_v50
        oDataRow("f16cNamaEngrave_v50") = prmf16cNamaEngrave_v50
        oDataRow("f17cKodeGender_v50") = prmf17cKodeGender_v50
        oDataRow("f18cNamaGender_v50") = prmf18cNamaGender_v50
        oDataRow("f19cKodePlating_v50") = prmf19cKodePlating_v50
        oDataRow("f20cNamaPlating_v50") = prmf20cNamaPlating_v50
        oDataRow("f21cKodeFinishing_v50") = prmf21cKodeFinishing_v50
        oDataRow("f22cNamaFinishing_v50") = prmf22cNamaFinishing_v50
        oDataRow("f23cKodeStoneType_v50") = prmf23cKodeStoneType_v50
        oDataRow("f24cNamaStoneType_v50") = prmf24cNamaStoneType_v50
        oDataRow("f25cKodeStoneColor_v50") = prmf25cKodeStoneColor_v50
        oDataRow("f26cNamaStoneColor_v50") = prmf26cNamaStoneColor_v50
        oDataRow("f27cKodeFinding_v50") = prmf27cKodeFinding_v50
        oDataRow("f28cNamaFinding_v50") = prmf28cNamaFinding_v50
        oDataRow("f40cIDUser_v50") = prmf40cIDUser_v50
        oDataRow("f41cNamaUser_v50") = prmf41cNamaUser_v50
        oDataRow("f42dCreatedDate") = prmf42dCreatedDate

        If prop_lGridForImage Then
            oDataRow("f50ImageFG") = prmf50ImageFG
            oDataRow("f51ImageTehnik1") = prmf51ImageTehnik1
            oDataRow("f52ImageTehnik2") = prmf52ImageTehnik2
            oDataRow("f53ImageTehnik3") = prmf53ImageTehnik3
        End If

        prop_dt32PRODUCT.Rows.Add(oDataRow)
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

'********** end of .NET Controller : clsController32PRODUCT.vb ****************
