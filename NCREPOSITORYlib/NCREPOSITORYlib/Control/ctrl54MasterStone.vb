Imports System.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Public Class ctrl54MasterStone
    Inherits SearchLookUpEdit
    Implements IDisposable

    Public Property _01prop_dtMasterStone As New DataTable
    Public Property _02prop_FilterKodeMasterStone As GroupMasterStone

    Private dvViewMasterStone As New DataView
    Private objColValueMember As GridColumn
    Private objColDisplayMember As GridColumn

    Public Enum GroupMasterStone
        PARCEL = 0
        PROSESSTONE = 1

        ZCBRAND = 3
        ZCSHAPE = 4
        ZCCOLOUR = 5
        ZCDIMENSI = 6
        ZCQUALITY = 7

        PROCUREMENT = 8
        SISATAMBAH = 9
    End Enum

    Public Sub _03BindingAwalDataSurce()
        Const pcfieldValueMember As String = "k01cKodeFieldValueMasterStone_v50"
        Const pcfieldDisplayMember As String = "f01cIsiFieldValueMasterStone_v50"

        objColValueMember = New GridColumn With {.Caption = "Code", .FieldName = pcfieldValueMember, .VisibleIndex = 0}
        objColDisplayMember = New GridColumn With {.Caption = "Value", .FieldName = pcfieldDisplayMember, .VisibleIndex = 1}

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

        dvViewMasterStone = dvMasterStone()
        Properties.DataSource = dvViewMasterStone
    End Sub

    Private Function dvMasterStone() As DataView

        Dim dtTemp As New DataTable
        Dim pcKolomData = New String() {"k01cKodeMasterStone_v50", "k01cKodeFieldValueMasterStone_v50", "f01cIsiFieldValueMasterStone_v50"}
        Dim dvView As DataView = New DataView(_01prop_dtMasterStone)

        dtTemp = dvView.ToTable(True, pcKolomData)
        dvMasterStone = New DataView(dtTemp)

        Return dvMasterStone
    End Function

    Public Sub _04FilterDataViewMasterStone()
        Dim pcFilter As String = ""

        Select Case _02prop_FilterKodeMasterStone
            Case GroupMasterStone.PARCEL
                pcFilter = "PARCEL"

            Case GroupMasterStone.PROSESSTONE
                pcFilter = "PROSES"

            Case GroupMasterStone.ZCBRAND
                pcFilter = "ZCBRAND"

            Case GroupMasterStone.ZCSHAPE
                pcFilter = "ZCSHAPE"

            Case GroupMasterStone.ZCCOLOUR
                pcFilter = "ZCCOLOUR"

            Case GroupMasterStone.ZCDIMENSI
                pcFilter = "ZCDIMENSI"

            Case GroupMasterStone.ZCQUALITY
                pcFilter = "ZCQUALITY"

            Case GroupMasterStone.PROCUREMENT
                pcFilter = "PROCUREMENT"

            Case GroupMasterStone.SISATAMBAH
                pcFilter = "SISATAMBAH"
        End Select

        With dvViewMasterStone
            .Sort = [String].Empty
            .RowFilter = [String].Empty
        End With

        With dvViewMasterStone
            .Sort = "k01cKodeMasterStone_v50"
            .RowFilter = String.Format(" k01cKodeMasterStone_v50 = '{0}' ", pcFilter)
            .RowStateFilter = DataViewRowState.CurrentRows
        End With

        Properties.DataSource = Nothing
        Properties.DataSource = dvViewMasterStone

    End Sub


End Class


'create procedure sp54MasterStoneAll
'as
'begin
'	select a.k01cKodeMasterStone_v50,a.f01cNamaMasterStone_v50,a.f02cKeterangan_v100,
'		   b.k01cKodeFieldValueMasterStone_v50,b.f01cIsiFieldValueMasterStone_v50,
'		   b.f03nRangeMin_n93,b.f04nRangeMax_n93,b.f05nHPPM_182,b.f06nHPPR_182
'	from NEWCENTRAL..y54MASTERSTONE as a
'	join NEWCENTRAL..y55VALUEMASTERSTONE as b
'	on a.k01cKodeMasterStone_v50 = b.f02cKodeMasterStone_v50
'	order by a.k01cKodeMasterStone_v50,b.k01cKodeFieldValueMasterStone_v50;
'end