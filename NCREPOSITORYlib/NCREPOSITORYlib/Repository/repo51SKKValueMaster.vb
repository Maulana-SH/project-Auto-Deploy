Imports DevExpress.XtraEditors
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports System.Drawing

Public Class repo51SKKValueMaster
    Inherits RepositoryItemLookUpEdit
    Implements IDisposable

    Public Property _prop_01dt51ValueMasterSKK As New DataTable
    Public Property _prop_02cTargetGroupMaster As String

    Private dvMasterSKK As New DataView

    Public Sub _01BindingAwalDataSurce()
        'k01cKodeFieldValueMaster_v50,f01cIsiFieldValueMaster_v50,f02cKodeMaster_v50
        Const pcfieldValueMember As String = "k01cKodeFieldValueMaster_v50"
        Const pcfieldDisplayMember As String = "f01cIsiFieldValueMaster_v50"
        Const pcfieldDisplayMember1 As String = "f02cKodeMaster_v50"

        Dim objColValueMember As LookUpColumnInfo = New LookUpColumnInfo() With {.Caption = "Code",
                                                    .FieldName = pcfieldValueMember, .Width = 100}
        Dim objColDisplayMember As LookUpColumnInfo = New LookUpColumnInfo() With {.Caption = "Name",
                                                      .FieldName = pcfieldDisplayMember, .Width = 300}
        Dim objColDisplayMember1 As LookUpColumnInfo = New LookUpColumnInfo() With {.Caption = "Group",
                                                       .FieldName = pcfieldDisplayMember1, .Visible = False,
                                                       .Width = 300}
        With Me
            .PopulateColumns()
            .Columns.AddRange(New LookUpColumnInfo() {objColValueMember, objColDisplayMember, objColDisplayMember1})
            .ValueMember = pcfieldValueMember
            .DisplayMember = pcfieldDisplayMember

            .NullText = ""
            With .AppearanceDropDownHeader
                .Font = New Font("Tahoma", 8, FontStyle.Bold, GraphicsUnit.Point)
                .ForeColor = Color.Red
                .TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            End With
            .BestFitMode = BestFitMode.BestFitResizePopup
            .SearchMode = SearchMode.AutoComplete
            .AutoSearchColumnIndex = 1
        End With

        dvMasterSKK = dv51ValueMasterSKK()
        Me.DataSource = dvMasterSKK

        Me.DropDownRows = dvMasterSKK.Count
    End Sub

    Public Sub _02FilterDataProsesProdMRP()
        With dvMasterSKK
            .Sort = [String].Empty
            .RowFilter = [String].Empty
        End With

        With dvMasterSKK
            .Sort = "f02cKodeMaster_v50"
            .RowFilter = String.Format(" f02cKodeMaster_v50 = '{0}' ", _prop_02cTargetGroupMaster)
            .RowStateFilter = DataViewRowState.CurrentRows
        End With

        Me.DataSource = Nothing
        Me.DataSource = dvMasterSKK

        Me.DropDownRows = dvMasterSKK.Count
    End Sub

    Private Function dv51ValueMasterSKK() As DataView
        'k01cKodeFieldValueMaster_v50,f01cIsiFieldValueMaster_v50,f02cKodeMaster_v50
        Dim dtTemp As New DataTable
        Dim pcKolomData = New String() {"k01cKodeFieldValueMaster_v50", "f01cIsiFieldValueMaster_v50", "f02cKodeMaster_v50"}
        Dim dvView As DataView = New DataView(_prop_01dt51ValueMasterSKK)

        dtTemp = dvView.ToTable(True, pcKolomData)
        dv51ValueMasterSKK = New DataView(dtTemp)

        Return dv51ValueMasterSKK
    End Function

End Class