'********** create .NET Controller : clsCtrlMRP24MCFINISHEDGOOD.vb ****************

Public Class clsCtrlMRP24MCFINISHEDGOOD
     Implements IDisposable

    Public Property prop_dt24MCFINISHEDGOOD As DataTable

    Public Property prop_lGridForImage As Boolean = False

    Private Function dtCreate24MCFINISHEDGOOD() As DataTable
        Dim dtDataTable As New DataTable

        Dim fieldk01cKodeFinishedGood_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k01cKodeFinishedGood_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldk01cKodeFinishedGood_v50)

        Dim fieldk02cVersionBOM_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "k02cVersionBOM_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldk02cVersionBOM_v50)

        Dim fieldf01cKodeDesign_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f01cKodeDesign_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf01cKodeDesign_v50)

        Dim fieldf02cKarakteristik_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f02cKarakteristik_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf02cKarakteristik_v50)

        Dim fieldf03cFinishedGoodDesc_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f03cFinishedGoodDesc_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf03cFinishedGoodDesc_v50)

        Dim fieldf04cKodeTipeBRJ_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f04cKodeTipeBRJ_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf04cKodeTipeBRJ_v50)

        Dim fieldf05cTipeBRJDesc_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f05cTipeBRJDesc_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf05cTipeBRJDesc_v50)

        Dim fieldf06cSize_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f06cSize_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf06cSize_v50)

        Dim fieldf07cKodeKadar_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f07cKodeKadar_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf07cKodeKadar_v50)

        Dim fieldf08cKadarDesc_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f08cKadarDesc_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf08cKadarDesc_v50)

        Dim fieldf09cKodeWarna_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f09cKodeWarna_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf09cKodeWarna_v50)

        Dim fieldf10cWarnaDesc_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f10cWarnaDesc_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf10cWarnaDesc_v50)

        Dim fieldf11cKodeRawMaterial_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f11cKodeRawMaterial_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf11cKodeRawMaterial_v50)

        Dim fieldf12cRawMaterialDesc_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f12cRawMaterialDesc_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf12cRawMaterialDesc_v50)

        Dim fieldf13cKodeProductionType_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f13cKodeProductionType_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf13cKodeProductionType_v50)

        Dim fieldf14cProductionTypeDesc_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f14cProductionTypeDesc_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf14cProductionTypeDesc_v50)

        Dim fieldf30cIDUser_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f30cIDUser_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf30cIDUser_v50)

        Dim fieldf31cNamaUser_v50 As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.String"), .ColumnName = "f31cNamaUser_v50", .DefaultValue = ""}
        dtDataTable.Columns.Add(fieldf31cNamaUser_v50)

        Dim fieldf32dCreatedDate As DataColumn = New DataColumn() With {.DataType = Type.GetType("System.DateTime"), .ColumnName = "f32dCreatedDate", .DefaultValue = "3000-01-01"}
        dtDataTable.Columns.Add(fieldf32dCreatedDate)

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

    Public Sub dtInit24MCFINISHEDGOOD()
        prop_dt24MCFINISHEDGOOD = Nothing
        prop_dt24MCFINISHEDGOOD = dtCreate24MCFINISHEDGOOD()
        prop_dt24MCFINISHEDGOOD.Clear()
    End Sub

    Public Sub dtAddNew24MCFINISHEDGOOD(ByVal prmk01cKodeFinishedGood_v50 As String, ByVal prmk02cVersionBOM_v50 As String,
                                 ByVal prmf01cKodeDesign_v50 As String, ByVal prmf02cKarakteristik_v50 As String, ByVal prmf03cFinishedGoodDesc_v50 As String,
                                 ByVal prmf04cKodeTipeBRJ_v50 As String, ByVal prmf05cTipeBRJDesc_v50 As String, ByVal prmf06cSize_v50 As String,
                                 ByVal prmf07cKodeKadar_v50 As String, ByVal prmf08cKadarDesc_v50 As String, ByVal prmf09cKodeWarna_v50 As String,
                                 ByVal prmf10cWarnaDesc_v50 As String, ByVal prmf11cKodeRawMaterial_v50 As String, ByVal prmf12cRawMaterialDesc_v50 As String,
                                 ByVal prmf13cKodeProductionType_v50 As String, ByVal prmf14cProductionTypeDesc_v50 As String,
                                 ByVal prmf30cIDUser_v50 As String, ByVal prmf31cNamaUser_v50 As String, ByVal prmf32dCreatedDate As Date,
                                 Optional prmf50ImageFG As Byte() = Nothing, Optional prmf51ImageTehnik1 As Byte() = Nothing,
                                 Optional prmf52ImageTehnik2 As Byte() = Nothing, Optional prmf53ImageTehnik3 As Byte() = Nothing)

        Dim oDataRow As DataRow = prop_dt24MCFINISHEDGOOD.NewRow()

        oDataRow("k01cKodeFinishedGood_v50") = prmk01cKodeFinishedGood_v50
        oDataRow("k02cVersionBOM_v50") = prmk02cVersionBOM_v50
        oDataRow("f01cKodeDesign_v50") = prmf01cKodeDesign_v50
        oDataRow("f02cKarakteristik_v50") = prmf02cKarakteristik_v50
        oDataRow("f03cFinishedGoodDesc_v50") = prmf03cFinishedGoodDesc_v50
        oDataRow("f04cKodeTipeBRJ_v50") = prmf04cKodeTipeBRJ_v50
        oDataRow("f05cTipeBRJDesc_v50") = prmf05cTipeBRJDesc_v50
        oDataRow("f06cSize_v50") = prmf06cSize_v50
        oDataRow("f07cKodeKadar_v50") = prmf07cKodeKadar_v50
        oDataRow("f08cKadarDesc_v50") = prmf08cKadarDesc_v50
        oDataRow("f09cKodeWarna_v50") = prmf09cKodeWarna_v50
        oDataRow("f10cWarnaDesc_v50") = prmf10cWarnaDesc_v50
        oDataRow("f11cKodeRawMaterial_v50") = prmf11cKodeRawMaterial_v50
        oDataRow("f12cRawMaterialDesc_v50") = prmf12cRawMaterialDesc_v50
        oDataRow("f13cKodeProductionType_v50") = prmf13cKodeProductionType_v50
        oDataRow("f14cProductionTypeDesc_v50") = prmf14cProductionTypeDesc_v50
        oDataRow("f30cIDUser_v50") = prmf30cIDUser_v50
        oDataRow("f31cNamaUser_v50") = prmf31cNamaUser_v50
        oDataRow("f32dCreatedDate") = prmf32dCreatedDate

        If prop_lGridForImage Then
            oDataRow("f50ImageFG") = prmf50ImageFG
            oDataRow("f51ImageTehnik1") = prmf51ImageTehnik1
            oDataRow("f52ImageTehnik2") = prmf52ImageTehnik2
            oDataRow("f53ImageTehnik3") = prmf53ImageTehnik3
        End If

        prop_dt24MCFINISHEDGOOD.Rows.Add(oDataRow)
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

'********** end of .NET Controller : clsCtrlMRP24MCFINISHEDGOOD.vb ****************
