Imports System.Drawing
Imports DevExpress.XtraEditors
Public Class repo52ProsesProduksi
    Inherits Repository.RepositoryItemLookUpEdit
    Implements IDisposable

    Public Property _01prop_dt52ProsesProduksi As New DataTable

    Public Sub _02BindingAwalDataSurce()
        Const pcfieldValueMember As String = "k01cIDProsesProduksi_v50"
        Const pcfieldDisplayMember As String = "f01cNamaProsesProduksi_v50"

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

        Me.DataSource = dv52ProsesProduksi()
    End Sub

    Private Function dv52ProsesProduksi() As DataView
        Dim dtTemp As New DataTable
        Dim pcKolomData = New String() {"k01cIDProsesProduksi_v50", "f01cNamaProsesProduksi_v50"}
        Dim dvView As DataView = New DataView(_01prop_dt52ProsesProduksi)

        dtTemp = dvView.ToTable(True, pcKolomData)
        dv52ProsesProduksi = New DataView(dtTemp)

        Return dv52ProsesProduksi
    End Function
End Class
