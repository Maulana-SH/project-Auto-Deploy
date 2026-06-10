Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports System.Drawing

Public Class ctrl53AturanMutasi
    Inherits SearchLookUpEdit
    Implements IDisposable


    Public Property _01prop_dt53AturanMutasi As New DataTable
    Public Property _02prop_cKodeAsalMutasi As String = "P1000"

    Private dvViewMasterAturanMutasi As New DataView
    Private objColValueMember As GridColumn
    Private objColDisplayMember As GridColumn

    Public Sub _02BindingAwalDataSource()
        Const pcfieldValueMember As String = "f03cIDProsesProduksiTujuan_v50"
        Const pcfieldDisplayMember As String = "f04cNamaProsesProduksiTujuan_v50"

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

        dvViewMasterAturanMutasi = dv53AturanMutasi()
        Properties.DataSource = dvViewMasterAturanMutasi
    End Sub

    Private Function dv53AturanMutasi() As DataView

        'Dim dtTemp As New DataTable
        'Dim pcKolomData = New String() {"f03cIDProsesProduksiTujuan_v50", "f04cNamaProsesProduksiTujuan_v50"}
        Dim dvView As DataView = New DataView(_01prop_dt53AturanMutasi) With {.Sort = "f01cIDProsesProduksiAsal_v50",
                                                                              .RowFilter = String.Format(" f01cIDProsesProduksiAsal_v50 = '{0}' and f05lBoleh_bit = 1 ", _02prop_cKodeAsalMutasi),
                                                                              .RowStateFilter = DataViewRowState.CurrentRows}

        'dtTemp = dvView.ToTable(True, pcKolomData)
        'dv53AturanMutasi = New DataView(dtTemp)

        'Return dv53AturanMutasi
        Return dvView
    End Function

    Public Sub _03FilterDataSourceAturanMutasi()
        With dvViewMasterAturanMutasi
            .Sort = [String].Empty
            .RowFilter = [String].Empty
        End With

        With dvViewMasterAturanMutasi
            .Sort = "f01cIDProsesProduksiAsal_v50"
            .RowFilter = String.Format(" f01cIDProsesProduksiAsal_v50 = '{0}' and f05lBoleh_bit = 1 ", _02prop_cKodeAsalMutasi)
            .RowStateFilter = DataViewRowState.CurrentRows
        End With

        Properties.DataSource = Nothing
        Properties.DataSource = dvViewMasterAturanMutasi
        Me.Refresh()

    End Sub

End Class
