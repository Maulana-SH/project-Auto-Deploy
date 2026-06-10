Imports System.Drawing
Imports DevExpress.XtraEditors
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Columns

Public Class ctrlCXTreelistLookUpedit
    Inherits TreeListLookUpEdit
    Implements IDisposable

    Public Property _01DataSource As DataTable

    'Private Treelist As New TreeList

    'Private objValueMamber As TreeListColumn
    'Private objDisplayMamber As TreeListColumn
    'Private objDisplayMamber1 As TreeListColumn
    'Private objDisplayMamber2 As TreeListColumn
    'Private objDisplayMamber3 As TreeListColumn

    Public Sub New()

    End Sub
    'Me.k01cIDCor_v50 = prmk01cIDCor_v50
    'Me.k02cSKU_v50 = prmk02cSKU_v50
    'Me.f02cNamaKadar_v50 = prmf02cNamaKadar_v50
    'Me.f04cNamaWarna_v50 = prmf04cNamaWarna_v50
    'Me.f06cNamaItem_v50 = prmf06cNamaItem_v50
    'Me.f07nInputRequest_n92 = prmf07nInputRequest_n92
    Public Sub cm01BindingAwal()

        Dim colID As New TreeListColumn With {.FieldName = "ID"}
        Dim colParentID As New TreeListColumn With {.FieldName = "ParentID"}
        Dim objValueMamber As New TreeListColumn With {.FieldName = "IDCor", .Width = 250}
        Dim objDisplayMamber1 As New TreeListColumn With {.FieldName = "Item"}
        Dim objDisplayMamber2 As New TreeListColumn With {.FieldName = "Request"}
        Dim objDisplayMamber3 As New TreeListColumn With {.FieldName = "Kadar"}

        Me.Properties.TreeList.Nodes.Add(New TreeListColumn() {colID, colParentID, objValueMamber, objDisplayMamber1, objDisplayMamber2, objDisplayMamber3})

        With Me.Properties

            With .TreeList

                With .OptionsView
                    .ShowIndicator = False
                    .AllowHtmlDrawHeaders = True
                End With
                .ExpandAll()
            End With


            .NullText = ""
            .ValueMember = "IDCor"
            .DisplayMember = "IDCor"
        End With

        'Data yang di pasrsing
        Dim prmdataList As New List(Of dataRecord)()
        prmdataList.Add(New dataRecord(0, -1, "CE220118", "75.50%", "ROSE GOLD", "", 234.12))
        prmdataList.Add(New dataRecord(1, 0, "PL220131", "75.50%", "ROSE GOLD", "PALTE", 12.22))
        prmdataList.Add(New dataRecord(2, 0, "PL220132", "75.50%", "ROSE GOLD", "PALTE", 103.22))
        prmdataList.Add(New dataRecord(3, -1, "CE220120", "75.50%", "ROSE GOLD", "", 321.33))
        prmdataList.Add(New dataRecord(4, 3, "WR220118", "35.50%", "ROSE GOLD", "PALTE", 122.22))
        prmdataList.Add(New dataRecord(5, 3, "WR220119", "35.50%", "ROSE GOLD", "PALTE", 89.74))

        Me.Properties.DataSource = prmdataList
    End Sub

    Private Sub ctrlCXTreelistLookUpedit_EditValueChanged(sender As Object, e As EventArgs) Handles Me.EditValueChanged

    End Sub
End Class

Public Class dataRecord
    Public Property ID() As Integer
    Public Property ParentID() As Integer
    Public Property IDCor() As String

    Public Property Kadar() As String
    Public Property Warna() As String
    Public Property Item() As String
    Public Property Request() As Double

    Public Sub New(ByVal id As Integer, ByVal parentID As Integer, ByVal prmk01cIDCor_v50 As String, ByVal prmf02cNamaKadar_v50 As String, ByVal prmf04cNamaWarna_v50 As String, ByVal prmf06cNamaItem_v50 As String, ByVal prmf07nInputRequest_n92 As Double)
        Me.ID = id
        Me.ParentID = parentID
        Me.IDCor = prmk01cIDCor_v50
        Me.Kadar = prmf02cNamaKadar_v50
        Me.Warna = prmf04cNamaWarna_v50
        Me.Item = prmf06cNamaItem_v50
        Me.Request = prmf07nInputRequest_n92
    End Sub
End Class