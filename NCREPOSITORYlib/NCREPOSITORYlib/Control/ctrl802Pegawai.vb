Imports System.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid

Public Class ctrl802Pegawai
    Inherits SearchLookUpEdit
    Implements IDisposable

    Public Property _prop_802Pegawai As New DataTable

    Private objColValueMember As GridColumn
    Private objColDisplayMember As GridColumn

    Public Sub _01BindingAwalDataSurce()
        Const pcfieldValueMember As String = "k01cNIK_v50"
        Const pcfieldDisplayMember As String = "f01cNamaKaryawan_v50"

        objColValueMember = New GridColumn With {.Caption = "NIK", .FieldName = pcfieldValueMember, .VisibleIndex = 0}
        objColDisplayMember = New GridColumn With {.Caption = "Nama", .FieldName = pcfieldDisplayMember, .VisibleIndex = 1}

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
        Dim pcKolomData = New String() {"k01cNIK_v50", "f01cNamaKaryawan_v50"}
        Dim dvView As DataView = New DataView(_prop_802Pegawai)

        dtTemp = dvView.ToTable(True, pcKolomData)
        dv52ProsesProduksi = New DataView(dtTemp)

        Return dv52ProsesProduksi
    End Function

End Class
