Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.XtraEditors
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid

Public Class ctrl51SKKValueMaster
    Inherits SearchLookUpEdit
    Implements IDisposable

    Public Property _01prop_dtMasterSKK As New DataTable
    Public Property _02prop_FilterKodeMasterSKK As String
    Public Property _03Prop_IsEnamelMaster As Boolean = False

    Private dvViewMasterSKK As New DataView
    Private objColValueMember As GridColumn
    Private objColDisplayMember As GridColumn
    Private objColDisplayMember1 As GridColumn

    Public Sub _03BindingAwalDataSurce()
        Const pcfieldValueMember As String = "k01cKodeFieldValueMaster_v50" '"k01cKodeFieldValueMaster_v50"
        Const pcfieldDisplayMember As String = "f01cIsiFieldValueMaster_v50" '"f01cIsiFieldValueMaster_v50"
        Const pcfieldDisplayMember1 As String = "f04cReserve02_v100" '"WARNA ENAMEL"

        objColValueMember = New GridColumn With {.Caption = "Code", .FieldName = pcfieldValueMember, .VisibleIndex = 0}
        objColDisplayMember = New GridColumn With {.Caption = "Name", .FieldName = pcfieldDisplayMember, .VisibleIndex = 1}
        objColDisplayMember1 = New GridColumn With {.Caption = "Color", .FieldName = pcfieldDisplayMember1, .VisibleIndex = 2}

        Dim objGridView As GridView = New GridView()
        With objGridView
            .Columns.Clear()

            If _03Prop_IsEnamelMaster Then
                .Columns.AddRange(New GridColumn() {objColValueMember, objColDisplayMember, objColDisplayMember1})
            Else
                .Columns.AddRange(New GridColumn() {objColValueMember, objColDisplayMember})
            End If

            .Appearance.Row.Font = New Font("Courier New", 9, FontStyle.Regular, GraphicsUnit.Point)
            With .Appearance.HeaderPanel
                .Font = New Font("Tahoma", 9, FontStyle.Bold, GraphicsUnit.Point)
                .ForeColor = Color.Red
                .TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            End With
        End With

        If _03Prop_IsEnamelMaster Then
            AddHandler objGridView.RowCellStyle, AddressOf objGridView_RowCellStyle
        End If

        'objGridView.Columns(pcfieldValueMember).Width = 75
        'objGridView.Columns(pcfieldDisplayMember).Width = 500

        With Properties
            .Appearance.Font = New Font("Courier New", 10, FontStyle.Regular, GraphicsUnit.Point)
            .PopupFormMinSize = New Size With {.Height = 400, .Width = 800}

            ' Initialize data source
            .DisplayMember = pcfieldDisplayMember
            .ValueMember = pcfieldValueMember

            .NullText = ""
            .View = objGridView
        End With

        dvViewMasterSKK = dvMasterSKK()
        Me.Properties.DataSource = dvViewMasterSKK
        ' BeginInvoke(New MethodInvoker(Sub() Me.Properties.View.RefreshData()))
    End Sub

    Private Sub objGridView_RowCellStyle(sender As Object, e As RowCellStyleEventArgs)

        Dim View As GridView = TryCast(sender, GridView)

        If e.RowHandle >= 0 Then
            Dim prmHEXColor As String = View.GetRowCellValue(e.RowHandle, View.Columns("f04cReserve02_v100"))

            If e.Column.FieldName = "f04cReserve02_v100" Then
                e.Appearance.BackColor = ColorTranslator.FromHtml(prmHEXColor.Trim)
            End If

            'If prmisChecked Then
            '    e.Appearance.BackColor = Color.LightGreen
            '    e.Appearance.ForeColor = Color.Navy
            'End If

        End If
    End Sub

    Private Function dvMasterSKK() As DataView

        Dim dtTemp As New DataTable
        Dim pcKolomData = New String() {"f02cKodeMaster_v50", "k01cKodeFieldValueMaster_v50", "f01cIsiFieldValueMaster_v50", "f04cReserve02_v100"}
        Dim dvView As DataView = New DataView(_01prop_dtMasterSKK)

        dtTemp = dvView.ToTable(True, pcKolomData)
        dvMasterSKK = New DataView(dtTemp)

        Return dvMasterSKK
    End Function

    Public Sub _04FilterDataViewMasterSKK()
        With dvViewMasterSKK
            .Sort = [String].Empty
            .RowFilter = [String].Empty
        End With

        With dvViewMasterSKK
            .Sort = "f02cKodeMaster_v50"
            .RowFilter = String.Format(" f02cKodeMaster_v50 = '{0}' ", _02prop_FilterKodeMasterSKK)
            .RowStateFilter = DataViewRowState.CurrentRows
        End With

        'Properties.DataSource = Nothing
        'Properties.DataSource = dvViewMasterSKK
    End Sub

    Public Sub _04SizeAll()
        With dvViewMasterSKK
            .Sort = [String].Empty
            .RowFilter = [String].Empty
        End With

        With dvViewMasterSKK
            .Sort = "f02cKodeMaster_v50"
            .RowFilter = String.Format(" f02cKodeMaster_v50 in (" & _02prop_FilterKodeMasterSKK & ") ")
            .RowStateFilter = DataViewRowState.CurrentRows
        End With

        Properties.DataSource = Nothing
        Properties.DataSource = dvViewMasterSKK
    End Sub

    Public Function _05GetRecordTerpilih() As DataRow()
        Dim pdtCopy As DataTable
        pdtCopy = _01prop_dtMasterSKK

        Dim pdDataRow() As DataRow
        pdDataRow = pdtCopy.Select("k01cKodeFieldValueMaster_v50 = '" & Me.EditValue & "'")

        Return pdDataRow
    End Function

    Public Sub cmRefreshData()

        dvViewMasterSKK = dvMasterSKK()
        Me.Properties.DataSource = dvViewMasterSKK
        _04FilterDataViewMasterSKK()
        ' BeginInvoke(New MethodInvoker(Sub() Me.Properties.View.RefreshData()))
    End Sub

End Class
