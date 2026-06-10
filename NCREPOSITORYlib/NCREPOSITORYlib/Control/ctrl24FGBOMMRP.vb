Imports System.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid

Public Class ctrl24FGBOMMRP
    Inherits SearchLookUpEdit
    Implements IDisposable

    Public Property _01prop_dt24CoreBOM As New DataTable

    Private objColValueMember As GridColumn
    Private objColDisplayMember As GridColumn
    Private objColDisplayMember1 As GridColumn

    Public Sub _02BindingAwalDataSurce()
        Const pcfieldValueMember As String = "k01cKodeFinishedGood_v50"
        Const pcfieldDisplayMember As String = "f03cFinishedGoodDesc_v50"
        Const pcfieldDisplayMember1 As String = "k02cVersionBOM_v50"

        objColValueMember = New GridColumn With {.Caption = "Code", .FieldName = pcfieldValueMember, .VisibleIndex = 0}
        objColDisplayMember = New GridColumn With {.Caption = "Name", .FieldName = pcfieldDisplayMember, .VisibleIndex = 1}
        objColDisplayMember1 = New GridColumn With {.Caption = "Version", .FieldName = pcfieldDisplayMember1, .VisibleIndex = 2}

        Dim objGridView As GridView = New GridView()
        With objGridView
            .Columns.Clear()
            .Columns.AddRange(New GridColumn() {objColValueMember, objColDisplayMember, objColDisplayMember1})

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

        Properties.DataSource = dv24CoreBOM()
    End Sub

    Private Function dv24CoreBOM() As DataView

        Dim dtTemp As New DataTable
        Dim pcKolomData = New String() {"k01cKodeFinishedGood_v50", "f03cFinishedGoodDesc_v50", "k02cVersionBOM_v50"}
        Dim dvView As DataView = New DataView(_01prop_dt24CoreBOM)

        dtTemp = dvView.ToTable(True, pcKolomData)
        dv24CoreBOM = New DataView(dtTemp)

        Return dv24CoreBOM
    End Function


End Class
