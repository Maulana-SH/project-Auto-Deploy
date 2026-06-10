Imports System.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid

Public Class ctrl22SKKFindingMultipleGLE
    Inherits GridLookUpEdit

    Public Property _01prop_dt22FindingComponent As New DataTable

    Private dvView446VaultMaster As New DataView
    Private objColDisplayCheck As GridColumn
    Private objColValueMember As GridColumn
    Private objColDisplayMember As GridColumn

    Public Sub _pb01BindingAwalDataSurce()
        Const pcfieldChek As String = "bCheck"
        Const pcfieldValueMember As String = "k01cKodeItemFindingComponent_v50"
        Const pcfieldDisplayMember As String = "cNamaFindingFull"

        objColDisplayCheck = New GridColumn With {.Caption = "#", .FieldName = pcfieldChek, .VisibleIndex = 0}
        objColValueMember = New GridColumn With {.Caption = "Code", .FieldName = pcfieldValueMember, .VisibleIndex = 1}
        objColDisplayMember = New GridColumn With {.Caption = "Desc", .FieldName = pcfieldDisplayMember, .VisibleIndex = 2}

        Dim objGridView As GridView = New GridView()
        With objGridView
            .Columns.Clear()
            .Columns.AddRange(New GridColumn() {objColValueMember, objColDisplayMember, objColDisplayCheck})

            .Appearance.Row.Font = New Font("Courier New", 12, FontStyle.Regular, GraphicsUnit.Point)
            With .Appearance.HeaderPanel
                .Font = New Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point)
                .ForeColor = Color.Red
                .TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            End With
        End With

        objGridView.Columns(pcfieldChek).Width = 50
        objGridView.Columns(pcfieldValueMember).Width = 100
        objGridView.Columns(pcfieldDisplayMember).Width = 500

        With Properties
            .Appearance.Font = New Font("Courier New", 12, FontStyle.Regular, GraphicsUnit.Point)
            .PopupFormMinSize = New Size With {.Height = 400, .Width = 800}

            ' Initialize data source
            .DisplayMember = pcfieldDisplayMember
            .ValueMember = pcfieldValueMember

            .NullText = ""
            .View = objGridView
        End With
        Me.Font = New Font("Courier New", 12, FontStyle.Regular, GraphicsUnit.Point)

        dvView446VaultMaster = _cmVaultMasterView()
        Properties.DataSource = dvView446VaultMaster
    End Sub

    Private Function _cmVaultMasterView() As DataView

        Dim dtTemp As New DataTable
        Dim pcKolomData = New String() {"bCheck", "k01cKodeItemFindingComponent_v50", "cNamaFindingFull"}
        Dim dvView As DataView = New DataView(_01prop_dt22FindingComponent)

        dtTemp = dvView.ToTable(True, pcKolomData)
        _cmVaultMasterView = New DataView(dtTemp)

        Return _cmVaultMasterView
    End Function

    Public Sub _pb03GetValueVaultMaster()
        Dim pdtCopy As DataTable
        pdtCopy = _01prop_dt22FindingComponent

        Dim pdDataRow() As DataRow
        pdDataRow = pdtCopy.Select("k01cKodeItemVault_v50 = '" & Me.EditValue & "'")

        '_cmClearVariabel()

        For Each objItem As Object In pdDataRow
            '   _03prop_f03cNamaGroupVault_v50 = objItem("f03cNamaGroupVault_v50").ToString
        Next

    End Sub

    'Private Sub _cmClearVariabel()
    '    _03prop_f03cNamaGroupVault_v50 = ""
    '    _04prop_f05cNamaRawMaterial_v50 = ""
    '    _05prop_f07cNamaWarna_v50 = ""
    '    _06prop_f09cNamaKadar_v50 = ""

    '    _07prop_f02cKodeGroupVault_v50 = ""
    '    _08prop_f04cKodeRawMaterial_v50 = ""
    '    _09prop_f06cKodeWarna_v50 = ""
    '    _10prop_f08cKodeKadar_v50 = ""
    '    _11prop_f16nPosterSaldoInGram_n92 = 0
    'End Sub

End Class
