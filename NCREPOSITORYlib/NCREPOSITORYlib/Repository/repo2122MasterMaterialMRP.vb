Imports DevExpress.XtraEditors
Imports System.Drawing

Public Class repo2122MasterMaterialMRP
    Inherits Repository.RepositoryItemLookUpEdit
    Implements IDisposable

    Public Property _prop_01dt2122MasterMaterialMRP As New DataTable

    Private dvViewMasterMaterialMRP As New DataView

    Public Sub _01BindingAwalDataSurce()
        Const pcfieldValueMember As String = "cCode"
        Const pcfieldDisplayMember As String = "cName"

        Dim objColValueMember As Controls.LookUpColumnInfo = New Controls.LookUpColumnInfo() With {.Caption = "Code",
                                                                  .FieldName = pcfieldValueMember,
                                                                  .Width = 100}
        Dim objColDisplayMember As Controls.LookUpColumnInfo = New Controls.LookUpColumnInfo() With {.Caption = "Name",
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

        dvViewMasterMaterialMRP = dv2122MasterMaterialMRP()
        Me.DataSource = dvViewMasterMaterialMRP
    End Sub

    Public Enum enumFilterTblMaterialMRP
        t21MCRAWMATERIAL = 1
        t22MCFINDINGCOMPONENT = 2
    End Enum

    Public Sub _02FilterDataProsesProdMRP(ByVal prmcTargetFilter As enumFilterTblMaterialMRP)
        With dvViewMasterMaterialMRP
            .Sort = [String].Empty
            .RowFilter = [String].Empty
        End With

        Select Case prmcTargetFilter
            Case 1
                With dvViewMasterMaterialMRP
                    .Sort = "cAsalTbl"
                    .RowFilter = " cAsalTbl = 't21MCRAWMATERIAL' "
                    .RowStateFilter = DataViewRowState.CurrentRows
                End With
            Case 2
                With dvViewMasterMaterialMRP
                    .Sort = "cAsalTbl"
                    .RowFilter = " cAsalTbl = 't22MCFINDINGCOMPONENT' "
                    .RowStateFilter = DataViewRowState.CurrentRows
                End With
        End Select

        Me.DataSource = Nothing
        Me.DataSource = dvViewMasterMaterialMRP
    End Sub

    Private Function dv2122MasterMaterialMRP() As DataView
        Dim dtTemp As New DataTable
        Dim pcKolomData = New String() {"cCode", "cName", "nBeratPerPcs", "cAsalTbl"}
        Dim dvView As DataView = New DataView(_prop_01dt2122MasterMaterialMRP)

        dtTemp = dvView.ToTable(True, pcKolomData)
        dv2122MasterMaterialMRP = New DataView(dtTemp)

        Return dv2122MasterMaterialMRP
    End Function

End Class
