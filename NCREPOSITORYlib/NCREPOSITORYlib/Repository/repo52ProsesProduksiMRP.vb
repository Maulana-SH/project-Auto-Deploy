Imports DevExpress.XtraEditors
Imports System.Drawing

Public Class repo52ProsesProduksiMRP
    Inherits Repository.RepositoryItemLookUpEdit
    Implements IDisposable

    Public Property _prop_01dt52MasterProsesProduksi As New DataTable

    Private dvViewProsesProdMRP As New DataView

    Public Sub _01BindingAwalDataSurce()
        Const pcfieldValueMember As String = "k01cIDProsesProduksi_v50"
        Const pcfieldDisplayMember As String = "f09cNamaEIS"

        Dim objColValueMember As Controls.LookUpColumnInfo = New Controls.LookUpColumnInfo() With {.Caption = "Code",
                                                                  .FieldName = pcfieldValueMember,
                                                                  .Width = 100}
        Dim objColDisplayMember As Controls.LookUpColumnInfo = New Controls.LookUpColumnInfo() With {.Caption = "Proses",
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

        dvViewProsesProdMRP = dv52ProsesProduksi()
        Me.DataSource = dvViewProsesProdMRP
    End Sub

    Public Enum enumFilterProsesProdMRP
        ASSEMBLY = 1
        STONE = 2
    End Enum

    Public Sub _02FilterDataProsesProdMRP(ByVal prmcTargetFilter As enumFilterProsesProdMRP)
        With dvViewProsesProdMRP
            .Sort = [String].Empty
            .RowFilter = [String].Empty
        End With

        Select Case prmcTargetFilter
            Case 1
                With dvViewProsesProdMRP
                    .Sort = "f13nMRPAssembly_int"
                    .RowFilter = " f13nMRPAssembly_int = 1 "
                    .RowStateFilter = DataViewRowState.CurrentRows
                End With
            Case 2
                With dvViewProsesProdMRP
                    .Sort = "f14nMRPStone_int"
                    .RowFilter = " f14nMRPStone_int = 1 "
                    .RowStateFilter = DataViewRowState.CurrentRows
                End With
        End Select

        Me.DataSource = Nothing
        Me.DataSource = dvViewProsesProdMRP
    End Sub

    Private Function dv52ProsesProduksi() As DataView
        Dim dtTemp As New DataTable
        Dim pcKolomData = New String() {"k01cIDProsesProduksi_v50", "f09cNamaEIS", "f13nMRPAssembly_int", "f14nMRPStone_int"}
        Dim dvView As DataView = New DataView(_prop_01dt52MasterProsesProduksi)

        dtTemp = dvView.ToTable(True, pcKolomData)
        dv52ProsesProduksi = New DataView(dtTemp)

        Return dv52ProsesProduksi
    End Function

End Class
