Imports System.Drawing
Imports DevExpress.XtraEditors
Public Class repo50MasterNewCentral
    Inherits Repository.RepositoryItemLookUpEdit
    Implements IDisposable

    Public Property _01prop_dtMasterNewCentral As New DataTable

    Public Sub _02BindingAwalDataSurce()
        Const pcfieldValueMember As String = "k01cKodeMaster_v50"
        Const pcfieldDisplayMember As String = "f01cNamaMaster_v50"

        Dim objColValueMember As Controls.LookUpColumnInfo = New Controls.LookUpColumnInfo() With {.Caption = "Code",
                                                                  .FieldName = pcfieldValueMember,
                                                                  .Width = 100}
        Dim objColDisplayMember As Controls.LookUpColumnInfo = New Controls.LookUpColumnInfo() With {.Caption = "Dimensi",
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

        Me.DataSource = dvMasterNewCentral()
    End Sub

    Private Function dvMasterNewCentral() As DataView

        Dim dtTemp As New DataTable
        Dim pcKolomData = New String() {"k01cKodeMaster_v50", "f01cNamaMaster_v50"}
        Dim dvView As DataView = New DataView(_01prop_dtMasterNewCentral)

        dtTemp = dvView.ToTable(True, pcKolomData)
        dvMasterNewCentral = New DataView(dtTemp)

        Return dvMasterNewCentral
    End Function

End Class
