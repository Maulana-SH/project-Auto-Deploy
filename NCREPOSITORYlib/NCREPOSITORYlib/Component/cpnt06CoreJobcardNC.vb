Imports System.Drawing
Imports DevExpress.XtraEditors
    Imports DevExpress.XtraGrid.Columns
    Imports DevExpress.XtraGrid.Views.Grid
    Imports NCMODELlib

Public Class cpnt06CoreJobcardNC
    Inherits SearchLookUpEdit
    Implements IDisposable


    Private objDataTable As DataTable

    Private objColValueMember As GridColumn
    Private objColDisplayMember As GridColumn
    Private objColDisplayMember1 As GridColumn
    Private objColDisplayMember2 As GridColumn
    Private objColDisplayMember3 As GridColumn
    Private objColDisplayMember4 As GridColumn

    Public Sub _01BindingAwalDataSurce()
        objDataTable = New DataTable

        Const pcfieldValueMember As String = "k01cSKUJobCard_v50"
        Const pcfieldDisplayMember As String = "f18cNamingProduct_v50"
        Const pcfieldDisplayMember1 As String = "ft01cTipeBRJ"
        Const pcfieldDisplayMember2 As String = "f04cKodeFinishGoods_v50"
        Const pcfieldDisplayMember3 As String = "f07cKodeKaretLama_v50"
        Const pcfieldDisplayMember4 As String = "f20cDesigner_v50"

        objColValueMember = New GridColumn With {.Caption = "SKU JOBCARD", .FieldName = pcfieldValueMember, .VisibleIndex = 0}
        objColDisplayMember = New GridColumn With {.Caption = "Product", .FieldName = pcfieldDisplayMember, .VisibleIndex = 1}
        objColDisplayMember1 = New GridColumn With {.Caption = "Type Brj", .FieldName = pcfieldDisplayMember1, .VisibleIndex = 2}
        objColDisplayMember2 = New GridColumn With {.Caption = "FinishGoods", .FieldName = pcfieldDisplayMember2, .VisibleIndex = 3}
        objColDisplayMember3 = New GridColumn With {.Caption = "Karet", .FieldName = pcfieldDisplayMember3, .VisibleIndex = 4}
        objColDisplayMember4 = New GridColumn With {.Caption = "Designer", .FieldName = pcfieldDisplayMember4, .VisibleIndex = 5}

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
        objGridView.Columns(pcfieldDisplayMember).Width = 300

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
        LoadDataSKU()
    End Sub

    Private Sub LoadDataSKU()
        Cursor = Windows.Forms.Cursors.WaitCursor

        Using objTabel As NCMODELlib.clsNEWCENTRALPD_iface = New NCMODELlib.clsNEWCENTRALPD_impl With {.prop_KeyString01 = ""}
            objDataTable = objTabel.Sele06COREJOBCARD
        End Using

        Properties.DataSource = objDataTable

        Cursor = Windows.Forms.Cursors.Default
    End Sub
End Class
