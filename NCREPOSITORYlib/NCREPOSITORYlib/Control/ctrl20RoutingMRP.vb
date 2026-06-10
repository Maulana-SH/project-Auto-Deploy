Imports System.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid

Public Class ctrl20RoutingMRP
    Inherits SearchLookUpEdit
    Implements IDisposable

    Public Property _01prop_dt20MasterRouting As New DataTable

    Private objColValueMember As GridColumn
    Private objColDisplayMember As GridColumn

    Private pdtSourceRouting As DataView

    Public Sub _02BindingAwalDataSurce()
        Const pcfieldValueMember As String = "k01cKodeMasterRouting_v50"
        Const pcfieldDisplayMember As String = "f01cMasterRoutingDesc_v50"

        objColValueMember = New GridColumn With {.Caption = "Code", .FieldName = pcfieldValueMember, .VisibleIndex = 0}
        objColDisplayMember = New GridColumn With {.Caption = "Name", .FieldName = pcfieldDisplayMember, .VisibleIndex = 1}

        Dim objGridView As GridView = New GridView()
        With objGridView
            .Columns.Clear()
            .Columns.AddRange(New GridColumn() {objColValueMember, objColDisplayMember})

            .Appearance.Row.Font = New Font("Courier New", 9, FontStyle.Regular, GraphicsUnit.Point)
            With .Appearance.HeaderPanel
                .Font = New Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point)
                .ForeColor = Color.Red
                .TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            End With
        End With

        objGridView.Columns(pcfieldValueMember).Width = 75
        objGridView.Columns(pcfieldDisplayMember).Width = 500

        With Properties
            .Appearance.Font = New Font("Courier New", 10, FontStyle.Regular, GraphicsUnit.Point)
            .PopupFormMinSize = New Size With {.Height = 400, .Width = 800}

            ' Initialize data source
            .DisplayMember = pcfieldDisplayMember
            .ValueMember = pcfieldValueMember

            .NullText = ""
            .View = objGridView
        End With

        pdtSourceRouting = dvMasterRouting()
        Properties.DataSource = pdtSourceRouting
    End Sub

    Private Function dvMasterRouting(Optional ByVal prmnTarget As Int32 = 0,
                                     Optional ByVal prmDataSourceRouting As DataTable = Nothing) As DataView
        Dim dtTemp As New DataTable
        Dim pcKolomData = New String() {"k01cKodeMasterRouting_v50", "f01cMasterRoutingDesc_v50"}

        Dim dtDistinct As New DataTable
        If prmnTarget > 0 Then
            dtDistinct = GetDistinctRecords(prmDataSourceRouting, pcKolomData)
        Else
            dtDistinct = GetDistinctRecords(_01prop_dt20MasterRouting, pcKolomData)
        End If
        Dim dvView As DataView = New DataView(dtDistinct)

        dtTemp = dvView.ToTable(True, pcKolomData)
        dvMasterRouting = New DataView(dtTemp)

        Return dvMasterRouting
    End Function

    Private Function GetDistinctRecords(ByVal dt As DataTable, ByVal Columns As String()) As DataTable
        '************ CARA PEMAKAIAN ************
        '    Dim TobeDistinct As String() = {"Name", "City", "State"}
        '    Dim dtDistinct As DataTable = GetDistinctRecords(DTwithDuplicate, TobeDistinct)
        '****************************************

        Dim dtUniqRecords As New DataTable

        dtUniqRecords = dt.DefaultView.ToTable(True, Columns)

        Return dtUniqRecords
    End Function

    Public Enum TargetFilterRouting
        RoutingForFCI = 0
    End Enum

    Public Sub _03FilterRouting(ByVal prmTargetFilterRouting As TargetFilterRouting)
        Dim pcCommandFilterRouting As String = ""

        Select Case prmTargetFilterRouting
            Case TargetFilterRouting.RoutingForFCI
                pcCommandFilterRouting = " k01cKodeMasterRouting_v50 like 'FCI*' "
        End Select

        Dim pdtMasterRouting_Copy As New DataTable
        pdtMasterRouting_Copy = _01prop_dt20MasterRouting.Copy

        Dim pdvMasterRouting_Copy As New DataView(pdtMasterRouting_Copy)
        With pdvMasterRouting_Copy
            .Sort = [String].Empty
            .RowFilter = [String].Empty
        End With

        With pdvMasterRouting_Copy
            .Sort = "k01cKodeMasterRouting_v50"
            .RowFilter = String.Format(pcCommandFilterRouting)
            .RowStateFilter = DataViewRowState.CurrentRows
        End With

        pdtSourceRouting.Table.Clear()

        pdtSourceRouting = dvMasterRouting(1, pdvMasterRouting_Copy.ToTable)
        Properties.DataSource = pdtSourceRouting
    End Sub

    Public Function _04GetDataRoutingJobCard(ByVal prmcProType As String,
                                             ByVal prmcProSubType As String,
                                             ByVal prmcMasterType As String) As DataTable

        Dim pdtMasterRouting_Copy As New DataTable
        pdtMasterRouting_Copy = _01prop_dt20MasterRouting.Copy

        Dim pdvMasterRouting_Copy As New DataView(pdtMasterRouting_Copy)
        With pdvMasterRouting_Copy
            .Sort = [String].Empty
            .RowFilter = [String].Empty
        End With

        With pdvMasterRouting_Copy
            .Sort = "f03cKodeTipeBarang_v50"
            .RowFilter = String.Format(" f03cKodeTipeBarang_v50 = '{0}' and f08cNamaItem_v50 = '{1}' and f10cDirect_v50 = '{2}' ",
                                         prmcProType, prmcProSubType, prmcMasterType)
            .RowStateFilter = DataViewRowState.CurrentRows
        End With

        Return pdvMasterRouting_Copy.ToTable()
    End Function

    Public Sub _05FilterRoutingJOBCARD()

        Dim pdtMasterRouting_Copy As New DataTable
        pdtMasterRouting_Copy = _01prop_dt20MasterRouting.Copy

        Dim pdvMasterRouting_Copy As New DataView(pdtMasterRouting_Copy)
        With pdvMasterRouting_Copy
            .Sort = [String].Empty
            .RowFilter = [String].Empty
        End With

        With pdvMasterRouting_Copy
            .Sort = "k01cKodeMasterRouting_v50"
            .RowFilter = String.Format(" k01cKodeMasterRouting_v50 like 'JC*' ")
            .RowStateFilter = DataViewRowState.CurrentRows
        End With

        pdtSourceRouting.Table.Clear()

        pdtSourceRouting = dvMasterRouting(1, pdvMasterRouting_Copy.ToTable)
        Properties.DataSource = pdtSourceRouting
    End Sub

End Class

'table.Select("ItemName LIKE '*product*'")