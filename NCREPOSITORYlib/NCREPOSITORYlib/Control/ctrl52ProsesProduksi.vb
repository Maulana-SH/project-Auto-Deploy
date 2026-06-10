Imports System.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Public Class ctrl52ProsesProduksi
    Inherits SearchLookUpEdit
    Implements IDisposable

    Public Property _01prop_dt52ProsesProduksi As New DataTable

    Private objColValueMember As GridColumn
    Private objColDisplayMember As GridColumn

    Public Sub _02BindingAwalDataSurce()
        Const pcfieldValueMember As String = "k01cIDProsesProduksi_v50"
        Const pcfieldDisplayMember As String = "f01cNamaProsesProduksi_v50"

        objColValueMember = New GridColumn With {.Caption = "Code", .FieldName = pcfieldValueMember, .VisibleIndex = 0}
        objColDisplayMember = New GridColumn With {.Caption = "Proses", .FieldName = pcfieldDisplayMember, .VisibleIndex = 1}

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

        Properties.DataSource = dv52ProsesProduksi()
    End Sub

    Private Function dv52ProsesProduksi() As DataView

        Dim dtTemp As New DataTable
        Dim pcKolomData = New String() {"k01cIDProsesProduksi_v50", "f01cNamaProsesProduksi_v50"}
        Dim dvView As DataView = New DataView(_01prop_dt52ProsesProduksi)

        dtTemp = dvView.ToTable(True, pcKolomData)
        dv52ProsesProduksi = New DataView(dtTemp)

        Return dv52ProsesProduksi
    End Function

End Class


'ALTER procedure [dbo].[sp52MasterAllProsesProduksi]
'as
'begin
'	select a.k01cIDProsesProduksi_v50,a.f01cNamaProsesProduksi_v50,a.f02cProsesORDokumen_v1,
'		   case when b.k01cIDFieldProsesProduksi_v50 is null then '' else b.k01cIDFieldProsesProduksi_v50 end as k01cIDFieldProsesProduksi_v50,
'		   case when b.f01cNamaFieldProsesProduksi_v50 is null then '' else b.f01cNamaFieldProsesProduksi_v50 end as f01cNamaFieldProsesProduksi_v50,
'		   case when b.f02cGroupTable_v50 is null then '' else b.f02cGroupTable_v50 end as f02cGroupTable_v50
'	from y52PROSESPRODUKSI as a
'	LEFT join y53PROSESDETAILPRODUKSI as b
'	on a.k01cIDProsesProduksi_v50 = b.f03cIDProsesProduksi_v50
'	order by a.k01cIDProsesProduksi_v50,b.k01cIDFieldProsesProduksi_v50;
'end