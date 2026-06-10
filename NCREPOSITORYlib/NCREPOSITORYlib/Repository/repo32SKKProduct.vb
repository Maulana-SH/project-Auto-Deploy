
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraEditors.Repository
Imports System.Drawing

Public Class repo32SKKProduct
    Inherits RepositoryItemLookUpEdit
    Implements IDisposable

    Public Property _prop_01dt32ProductSKK As New DataTable

    Public Sub _02BindingAwalDataSurce()
        Const pcfieldValueMember As String = "k01cKodeProduct_v50"
        Const pcfieldDisplayMember As String = "f01cNamaProduct_v50"

        Dim objColValueMember As LookUpColumnInfo = New LookUpColumnInfo() With {.Caption = "Code",
                                                    .FieldName = pcfieldValueMember, .Width = 100}
        Dim objColDisplayMember As LookUpColumnInfo = New LookUpColumnInfo() With {.Caption = "Name",
                                                      .FieldName = pcfieldDisplayMember, .Width = 300}

        With Me
            .PopulateColumns()
            .Columns.AddRange(New LookUpColumnInfo() {objColValueMember, objColDisplayMember})
            .ValueMember = pcfieldValueMember
            .DisplayMember = pcfieldValueMember

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

        Me.DataSource = _prop_01dt32ProductSKK

        Me.DropDownRows = _prop_01dt32ProductSKK.Rows.Count
    End Sub

    Public Function _03GetRecordTerpilih(ByVal prmcKodeProduct As String) As DataRow()
        Dim pdDataRow() As DataRow
        pdDataRow = _prop_01dt32ProductSKK.Select("k01cKodeProduct_v50 = '" & prmcKodeProduct & "'")

        Return pdDataRow
    End Function

End Class