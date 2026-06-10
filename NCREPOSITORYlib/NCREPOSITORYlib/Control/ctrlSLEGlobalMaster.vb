Imports System.Drawing
Imports DevExpress.XtraBars.Alerter
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid

Public Class ctrlSLEGlobalMaster
        Inherits SearchLookUpEdit
        Implements IDisposable

    Public Property _01prop_dtDesignMasterSKK As New DataTable
    Public Property _02prop_fieldValueMember As String
    Public Property _03prop_fieldDisplayMember As String

    Private objColValueMember As GridColumn
    Private objColDisplayMember As GridColumn

    Public Sub _04BindingAwalDataSurce()
        Dim pcfieldValueMember As String = _02prop_fieldValueMember
        Dim pcfieldDisplayMember As String = _03prop_fieldDisplayMember

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

        objGridView.Columns(pcfieldValueMember).Width = 25
        objGridView.Columns(pcfieldDisplayMember).Width = 75

        With Properties
            .Appearance.Font = New Font("Courier New", 10, FontStyle.Regular, GraphicsUnit.Point)
            .PopupFormMinSize = New Size With {.Height = 400, .Width = 500}

            ' Initialize data source
            .DisplayMember = pcfieldDisplayMember
            .ValueMember = pcfieldValueMember

            .NullText = ""
            .View = objGridView
        End With

        Properties.DataSource = _01prop_dtDesignMasterSKK
    End Sub

    Public Function _03GetRecordTerpilih() As DataRow()
            Dim pdtCopy As DataTable
            pdtCopy = _01prop_dtDesignMasterSKK

            Dim pdDataRow() As DataRow
            pdDataRow = pdtCopy.Select("k01cKodeDesignMaster_v50 = '" & Me.EditValue & "'")

            Return pdDataRow
        End Function

    End Class
