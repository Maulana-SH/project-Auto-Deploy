Imports System.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid
Public Class ctrl2122MasterMaterialMRP
    Inherits SearchLookUpEdit
    Implements IDisposable

    Public Property _prop_01dt2122MasterMaterialMRP As New DataTable

    Private objColValueMember As GridColumn
    Private objColDisplayMember As GridColumn

    Public Sub _02BindingAwalDataSurce()
        Const pcfieldValueMember As String = "cCode"
        Const pcfieldDisplayMember As String = "cName"

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

        Properties.DataSource = dv2122MasterMaterialMRP()
    End Sub

    Public Function _03GetAsalTbl() As String
        Dim plHasil As String
        plHasil = ""

        For Each dtRow As DataRow In _prop_01dt2122MasterMaterialMRP.Rows
            If dtRow("cCode") = Me.EditValue Then
                plHasil = dtRow("cAsalTbl")
            End If
        Next

        Return plHasil
    End Function

    Private Function dv2122MasterMaterialMRP() As DataView
        Dim dtTemp As New DataTable
        Dim pcKolomData = New String() {"cCode", "cName", "nBeratPerPcs", "cAsalTbl"}
        Dim dvView As DataView = New DataView(_prop_01dt2122MasterMaterialMRP)

        dtTemp = dvView.ToTable(True, pcKolomData)
        dv2122MasterMaterialMRP = New DataView(dtTemp)

        Return dv2122MasterMaterialMRP
    End Function

End Class
