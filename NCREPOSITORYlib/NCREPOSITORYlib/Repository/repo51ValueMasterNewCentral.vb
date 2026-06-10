Imports System.Drawing
Imports DevExpress.XtraEditors
Public Class repo51ValueMasterNewCentral
    Inherits Repository.RepositoryItemLookUpEdit
    Implements IDisposable

    Public Property _01prop_dtMasterNewCentral As New DataTable
    Public Property _02prop_FilterKodeMasterNewCentral As String

    Private dvViewMasterNewCentral As New DataView

    Public Sub _02BindingAwalDataSurce()
        Const pcfieldValueMember As String = "k01cKodeFieldValueMaster_v50"
        Const pcfieldDisplayMember As String = "f01cIsiFieldValueMaster_v50"

        Dim objColValueMember As Controls.LookUpColumnInfo = New Controls.LookUpColumnInfo() With {.Caption = "Code",
                                                                  .FieldName = pcfieldValueMember,
                                                                  .Width = 100}
        Dim objColDisplayMember As Controls.LookUpColumnInfo = New Controls.LookUpColumnInfo() With {.Caption = "Value Dimensi",
                                                                    .FieldName = pcfieldDisplayMember,
                                                                    .Width = 300}

        With Me
            .Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {objColValueMember, objColDisplayMember})
            .ValueMember = pcfieldValueMember
            .DisplayMember = pcfieldDisplayMember

            .NullText = ""
            With .AppearanceDropDownHeader
                .Font = New Font("Tahoma", 8, FontStyle.Bold, GraphicsUnit.Point)
                .ForeColor = Color.Red
                .TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
            End With

        End With

        dvViewMasterNewCentral = dvMasterNewCentral()
        Me.DataSource = dvViewMasterNewCentral
    End Sub

    Public Sub _03FilterDataViewMasterNewCentral()
        With dvViewMasterNewCentral
            .Sort = [String].Empty
            .RowFilter = [String].Empty
        End With

        With dvViewMasterNewCentral
            .Sort = "k01cKodeMaster_v50"
            .RowFilter = String.Format(" k01cKodeMaster_v50 = '{0}' ", _02prop_FilterKodeMasterNewCentral)
            .RowStateFilter = DataViewRowState.CurrentRows
        End With

        Me.DataSource = Nothing
        Me.DataSource = dvViewMasterNewCentral

    End Sub

    Private Function dvMasterNewCentral() As DataView

        Dim dtTemp As New DataTable
        Dim pcKolomData = New String() {"k01cKodeMaster_v50", "k01cKodeFieldValueMaster_v50", "f01cIsiFieldValueMaster_v50"}
        Dim dvView As DataView = New DataView(_01prop_dtMasterNewCentral)

        dtTemp = dvView.ToTable(True, pcKolomData)
        dvMasterNewCentral = New DataView(dtTemp)

        Return dvMasterNewCentral
    End Function
End Class
