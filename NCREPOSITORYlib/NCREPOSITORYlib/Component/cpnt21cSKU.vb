Imports System.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Imports NCMODELlib

Public Class cpnt21cSKU
    Inherits SearchLookUpEdit
    Implements IDisposable

    Public Property _02cTargetRM As String = ""    '"R" = Rangka atau "M" = Mutasi

    'jika SKU berasal dari "M" = Mutasi, maka ke dua property dibawah ini harus terisi
    Public Property _02cKodeDivisiPengrajin As String = ""
    Public Property _02cKodeProsesProduksi As String = ""

    Public Property _05GETnNoUrutMutasiProses As Int32 = 0

    Private objDataTable As DataTable

    Private objColValueMember As GridColumn
    Private objColDisplayMember As GridColumn
    Private objColDisplayMember1 As GridColumn
    Private objColDisplayMember2 As GridColumn
    Private objColDisplayMember3 As GridColumn
    Private objColDisplayMember4 As GridColumn

    Public Sub _01BindingAwalDataSurce()
        objDataTable = New DataTable

        Const pcfieldValueMember As String = "k01cSKU_v50"
        Const pcfieldDisplayMember As String = "f01cNoSeriLDKP_v50"
        Const pcfieldDisplayMember1 As String = "f02cKodeFinishGoods_v50"
        Const pcfieldDisplayMember2 As String = "f03cKodeKaret_v50"
        Const pcfieldDisplayMember3 As String = "f27nQtyLot_int"
        Const pcfieldDisplayMember4 As String = "f31cCustomer_v50"

        objColValueMember = New GridColumn With {.Caption = "SKU", .FieldName = pcfieldValueMember, .VisibleIndex = 0}
        objColDisplayMember = New GridColumn With {.Caption = "NoSeriLDKP", .FieldName = pcfieldDisplayMember, .VisibleIndex = 1}
        objColDisplayMember1 = New GridColumn With {.Caption = "FinishGoods", .FieldName = pcfieldDisplayMember1, .VisibleIndex = 2}
        objColDisplayMember2 = New GridColumn With {.Caption = "Karet", .FieldName = pcfieldDisplayMember2, .VisibleIndex = 3}
        objColDisplayMember3 = New GridColumn With {.Caption = "Lot", .FieldName = pcfieldDisplayMember3, .VisibleIndex = 4}
        objColDisplayMember4 = New GridColumn With {.Caption = "Customer", .FieldName = pcfieldDisplayMember4, .VisibleIndex = 5}

        Dim objGridView As GridView = New GridView()
        With objGridView
            .Columns.Clear()
            .Columns.AddRange(New GridColumn() {objColValueMember, objColDisplayMember, objColDisplayMember1, objColDisplayMember2, objColDisplayMember3, objColDisplayMember4})

            .Appearance.Row.Font = New Font("Courier New", 9, FontStyle.Regular, GraphicsUnit.Point)
            .Appearance.HeaderPanel.Font = New Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point)
            .Appearance.HeaderPanel.ForeColor = Color.Red
            .Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center

        End With

        objGridView.Columns(pcfieldValueMember).Width = 75
        objGridView.Columns(pcfieldDisplayMember).Width = 500

        With Properties
            .Appearance.Font = New Font("Courier New", 9, FontStyle.Regular, GraphicsUnit.Point)
            .PopupFormMinSize = New Size With {.Height = 400, .Width = 800}

            ' Initialize data source
            .DisplayMember = pcfieldValueMember
            .ValueMember = pcfieldValueMember

            .NullText = ""
            .View = objGridView
        End With

    End Sub

    Public Sub _03RefreshDataSourceSKU()
        objDataTable.Clear()

        '"R" = Rangka atau "M" = Mutasi
        Select Case _02cTargetRM
            Case "R"
                LoadDataSKUFromRangka()
            Case "M"
                LoadDataSKUFromMutasi()
        End Select
    End Sub

    Private Sub LoadDataSKUFromRangka()
        Cursor = Windows.Forms.Cursors.WaitCursor

        Try
            objDataTable.Clear()
            Using objTabel As NCMODELlib.clsNEWCENTRAL_iface = New NCMODELlib.clsNEWCENTRAL_impl() With {.prop_k01cSKU_v50 = ""}
                objDataTable = objTabel.Sele21CORERK()
            End Using

            If objDataTable.Rows.Count > 0 Then
                Properties.DataSource = objDataTable
            Else
                MsgBox("maaf ... data SKU kosong ...")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try


        Cursor = Windows.Forms.Cursors.Default
    End Sub

    Private Sub LoadDataSKUFromMutasi()
        Cursor = Windows.Forms.Cursors.WaitCursor

        Using objTabel As NCMODELlib.clsNEWCENTRAL_iface = New NCMODELlib.clsNEWCENTRAL_impl With {.prop_k03cIDProsesProduksi_v50 = _02cKodeProsesProduksi,
                                                                                                   .prop_09cKodeDivisi = _02cKodeDivisiPengrajin}
            objDataTable = objTabel.Getrepo21SKUFromMutasi()
        End Using

        Properties.DataSource = objDataTable

        Cursor = Windows.Forms.Cursors.Default
    End Sub

    Public Sub _04GETNoUrutMutasiProsesSKU()
        If _02cTargetRM = "M" Then
            Dim pcFilterSKU As String = String.Format(" k01cSKU_v50 = '{0}'", Me.EditValue)

            _05GETnNoUrutMutasiProses = 0

            Dim objDataRow As DataRow() = objDataTable.Select(pcFilterSKU)
            For Each dtRow As DataRow In objDataRow
                _05GETnNoUrutMutasiProses = dtRow("k02nNoUrutMutasiProses_int")
            Next
        End If
    End Sub
End Class
