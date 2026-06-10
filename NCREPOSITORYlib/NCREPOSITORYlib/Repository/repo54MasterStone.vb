Imports System.Drawing
Imports DevExpress.XtraEditors
Public Class repo54MasterStone
    Inherits Repository.RepositoryItemLookUpEdit
    Implements IDisposable

    Public Property _01prop_dtMasterStone As New DataTable
    Public Property _02prop_FilterKodeMasterStone As GroupMasterStone

    Private dvViewMasterStone As New DataView

    Public Enum GroupMasterStone
        PARCEL = 0
        PROSESSTONE = 1

        ZCBRAND = 3
        ZCSHAPE = 4
        ZCCOLOUR = 5
        ZCDIMENSI = 6
        ZCQUALITY = 7

        PROCUREMENT = 8
        SISATAMBAH = 9
    End Enum

    Public Sub _03BindingAwalDataSurce()
        Const pcfieldValueMember As String = "k01cKodeFieldValueMasterStone_v50"
        Const pcfieldDisplayMember As String = "f01cIsiFieldValueMasterStone_v50"

        Dim objColValueMember As Controls.LookUpColumnInfo = New Controls.LookUpColumnInfo() With {.Caption = "Code",
                                                                  .FieldName = pcfieldValueMember,
                                                                  .Width = 100}
        Dim objColDisplayMember As Controls.LookUpColumnInfo = New Controls.LookUpColumnInfo() With {.Caption = "Value",
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

        dvViewMasterStone = dvMasterStone()
        Me.DataSource = dvViewMasterStone
    End Sub

    Private Function dvMasterStone() As DataView

        Dim dtTemp As New DataTable
        Dim pcKolomData = New String() {"k01cKodeMasterStone_v50", "k01cKodeFieldValueMasterStone_v50", "f01cIsiFieldValueMasterStone_v50"}
        Dim dvView As DataView = New DataView(_01prop_dtMasterStone)

        dtTemp = dvView.ToTable(True, pcKolomData)
        dvMasterStone = New DataView(dtTemp)

        Return dvMasterStone
    End Function

    Public Sub _04FilterDataViewMasterStone()
        Dim pcFilter As String = ""

        Select Case _02prop_FilterKodeMasterStone
            Case GroupMasterStone.PARCEL
                pcFilter = "PARCEL"

            Case GroupMasterStone.PROSESSTONE
                pcFilter = "PROSES"

            Case GroupMasterStone.ZCBRAND
                pcFilter = "ZCBRAND"

            Case GroupMasterStone.ZCSHAPE
                pcFilter = "ZCSHAPE"

            Case GroupMasterStone.ZCCOLOUR
                pcFilter = "ZCCOLOUR"

            Case GroupMasterStone.ZCDIMENSI
                pcFilter = "ZCDIMENSI"

            Case GroupMasterStone.ZCQUALITY
                pcFilter = "ZCQUALITY"

            Case GroupMasterStone.PROCUREMENT
                pcFilter = "PROCUREMENT"

            Case GroupMasterStone.SISATAMBAH
                pcFilter = "SISATAMBAH"
        End Select

        With dvViewMasterStone
            .Sort = [String].Empty
            .RowFilter = [String].Empty
        End With

        With dvViewMasterStone
            .Sort = "k01cKodeMasterStone_v50"
            .RowFilter = String.Format(" k01cKodeMasterStone_v50 = '{0}' ", pcFilter)
            .RowStateFilter = DataViewRowState.CurrentRows
        End With

        Me.DataSource = Nothing
        Me.DataSource = dvViewMasterStone

    End Sub
End Class
