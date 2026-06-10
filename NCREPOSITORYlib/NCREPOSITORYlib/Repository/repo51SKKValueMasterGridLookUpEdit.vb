
Imports System.Drawing
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Grid

Public Class repo51SKKValueMasterGridLookUpEdit
    Inherits RepositoryItemGridLookUpEdit
    Implements IDisposable


    Public Property _prop_01dt51ValueMasterSKK As New DataTable
    Public Property _prop_02cTargetGroupMaster As String

    Private dvMasterSKK As New DataView

    Public Sub _01BindingAwalDataSurce()
        Const pcfieldValueMember As String = "k01cKodeFieldValueMaster_v50"
        Const pcfieldDisplayMember As String = "f01cIsiFieldValueMaster_v50"

        ' Create two columns
        Dim colCode As New GridColumn
        colCode.FieldName = pcfieldValueMember
        colCode.Caption = "Code"
        colCode.VisibleIndex = 0

        Dim colDesc As New GridColumn
        colDesc.FieldName = pcfieldDisplayMember
        colDesc.Caption = "Name"
        colDesc.VisibleIndex = 1

        Dim gView As GridView = View
        With gView
            .Columns.Clear()
            .Columns.Add(colCode)
            .Columns.Add(colDesc)
            '.OptionsView.ShowGroupPanel = True

            With .Appearance.HeaderPanel

                .Font = New Font("Tahoma", 8, FontStyle.Bold, GraphicsUnit.Point)
                .ForeColor = Color.Red
                .TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            End With

        End With

        ' Initialize data source
        DisplayMember = pcfieldDisplayMember
        ValueMember = pcfieldValueMember
        dvMasterSKK = dv51ValueMasterSKK()
        NullText = ""
        Me.DataSource = dvMasterSKK

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
