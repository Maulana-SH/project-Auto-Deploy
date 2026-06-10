Imports DevExpress.XtraEditors
Imports System.Drawing

Public Class repo23MasterStoneMRP
    Inherits Repository.RepositoryItemLookUpEdit
    Implements IDisposable

    Public Property _prop_01dt23MasterStoneMRP As New DataTable

    Public Sub _01BindingAwalDataSurce()
        Const pcfieldValueMember As String = "k01cKodeStones_v50"
        Const pcfieldDisplayMember As String = "f01cStonesDesc_v50"

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

        Me.DataSource = dv23MasterStoneMRP()
    End Sub

    Private Function dv23MasterStoneMRP() As DataView
        Dim dtTemp As New DataTable
        Dim pcKolomData = New String() {"k01cKodeStones_v50", "f01cStonesDesc_v50"}
        Dim dvView As DataView = New DataView(_prop_01dt23MasterStoneMRP)

        dtTemp = dvView.ToTable(True, pcKolomData)
        dv23MasterStoneMRP = New DataView(dtTemp)

        Return dv23MasterStoneMRP
    End Function



End Class
