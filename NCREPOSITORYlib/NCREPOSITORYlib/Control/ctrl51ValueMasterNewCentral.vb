Imports System.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Public Class ctrl51ValueMasterNewCentral
    Inherits SearchLookUpEdit
    Implements IDisposable

    Public Property _01prop_dtMasterNewCentral As New DataTable
    Public Property _02prop_FilterKodeMasterNewCentral As String

    Private dvViewMasterNewCentral As New DataView
    Private objColValueMember As GridColumn
    Private objColDisplayMember As GridColumn

    Public Sub _03BindingAwalDataSurce()
        Const pcfieldValueMember As String = "k01cKodeFieldValueMaster_v50"
        Const pcfieldDisplayMember As String = "f01cIsiFieldValueMaster_v50"

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

        dvViewMasterNewCentral = dvMasterNewCentral()
        Properties.DataSource = dvViewMasterNewCentral
    End Sub

    Private Function dvMasterNewCentral() As DataView

        Dim dtTemp As New DataTable
        Dim pcKolomData = New String() {"k01cKodeMaster_v50", "k01cKodeFieldValueMaster_v50", "f01cIsiFieldValueMaster_v50"}
        Dim dvView As DataView = New DataView(_01prop_dtMasterNewCentral)

        dtTemp = dvView.ToTable(True, pcKolomData)
        dvMasterNewCentral = New DataView(dtTemp)

        Return dvMasterNewCentral
    End Function

    Public Sub _04FilterDataViewMasterNewCentral()
        With dvViewMasterNewCentral
            .Sort = [String].Empty
            .RowFilter = [String].Empty
        End With

        With dvViewMasterNewCentral
            .Sort = "k01cKodeMaster_v50"
            .RowFilter = String.Format(" k01cKodeMaster_v50 = '{0}' ", _02prop_FilterKodeMasterNewCentral)
            .RowStateFilter = DataViewRowState.CurrentRows
        End With

        Properties.DataSource = Nothing
        Properties.DataSource = dvViewMasterNewCentral

    End Sub

End Class


'ALTER procedure [dbo].[sp50MasterAllNewCentral]
'as
'begin
'	select a.k01cKodeMaster_v50,a.f01cNamaMaster_v50,a.f02cKeterangan_v100,
'		   b.k01cKodeFieldValueMaster_v50,b.f01cIsiFieldValueMaster_v50
'	from y50MASTER as a
'	join y51VALUEMASTER as b
'	on a.k01cKodeMaster_v50 = b.f02cKodeMaster_v50
'	order by a.k01cKodeMaster_v50,b.k01cKodeFieldValueMaster_v50;
'end