Imports DevExpress.XtraEditors
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Columns
Imports DevExpress.XtraTreeList.Nodes

Public Class repoTreelistLookUpEditCOA
    Inherits Repository.RepositoryItemTreeListLookUpEdit
    ' Inherits TreeListLookUpEdit
    Implements IDisposable

    Public Property _01DataSource As List(Of MasterCOA)

    ' === Properti hasil pilihan ===
    Public Property KodeAccount As String
    Public Property NamaAccount As String
    Public Property Id As String
    Public Property ParentId As String
    Public Property LevelMaster As String

    Public Sub cm01BindingAwal()

        ' pastikan TreeList di-reset dulu
        Dim tree = Me.TreeList
        tree.Columns.Clear()

        ' tambahkan kolom
        Dim colKode As New TreeListColumn() With {
            .Caption = "Kode",
            .FieldName = "KodeMaster",
            .Visible = True,
            .VisibleIndex = -1
        }

        Dim colNamaMaster As New TreeListColumn() With {
            .Caption = "Nama (Ind)",
            .FieldName = "NamaMaster",
            .Visible = True,
            .VisibleIndex = 0
        }

        tree.Columns.AddRange(New TreeListColumn() {colKode, colNamaMaster})

        ' set opsi tampilan
        With tree.OptionsView
            .ShowIndicator = False
            .ShowColumns = True

            ' Atur properti untuk menyembunyikan garis horizontal dan vertikal
            .ShowHorzLines = False
            .ShowVertLines = False

            ' Jika Anda juga ingin menyembunyikan judul kolom (header)
            .ShowColumns = False

            ' Jika Anda ingin menyembunyikan panel indikator (nomor baris) di sisi kiri
            .ShowIndicator = False
            ' 2. Menyembunyikan tombol expand/collapse
            .ShowButtons = False
        End With

        ' Tambahkan handler event saat item dipilih 
        'AddHandler tree.FocusedNodeChanged, AddressOf Me.OnNodeSelected
        AddHandler Me.EditValueChanged, AddressOf OnEditValueChanged

        ' --- Menangani event untuk membuat font tebal ---
        AddHandler tree.NodeCellStyle, AddressOf TreeList_NodeCellStyle

        ' --- Event untuk mencegah hover & klik pada group ---
        AddHandler tree.CustomDrawNodeCell, AddressOf TreeList_CustomDrawNodeCell
        AddHandler tree.FocusedNodeChanged, AddressOf TreeList_FocusedNodeChanged

        ' Tambahkan di dalam prosedur ConfigureTreeListLookUpEdit()
        AddHandler Me.EditValueChanging, AddressOf TreeListLookUpEdit_EditValueChanging



        ' set struktur hierarki
        tree.KeyFieldName = "IdMaster"
        tree.ParentFieldName = "ParentId"

        ' binding data
        Me.DataSource = _01DataSource

        ' set properti tampilan lookup
        With Me
            .DisplayMember = "NamaMaster"
            .ValueMember = "kodeMaster"
            .NullText = ""
        End With

        ' expand semua node
        tree.ExpandAll()
    End Sub


    Private Sub TreeList_NodeCellStyle(sender As Object, e As DevExpress.XtraTreeList.GetCustomNodeCellStyleEventArgs)
        ' Periksa apakah node saat ini memiliki anak
        If e.Node.HasChildren Then
            ' Atur properti Font dari appearance menjadi tebal
            e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Bold)
        End If
    End Sub

    ' 🔹 Nonaktifkan hover highlight di node group
    Private Sub TreeList_CustomDrawNodeCell(sender As Object, e As CustomDrawNodeCellEventArgs)
        Dim tl As TreeList = TryCast(sender, TreeList)
        Dim node As TreeListNode = e.Node

        ' Deteksi apakah ini node group
        Dim isGroup As Boolean = node.HasChildren OrElse String.IsNullOrEmpty(Convert.ToString(node.GetValue("IdMaster")))

        If isGroup Then
            ' Hapus background hover (gambar manual)
            e.Appearance.BackColor = Color.White
            e.Appearance.ForeColor = Color.Black
            e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Bold)
            e.Handled = False
        End If
    End Sub
    ' 🔹 Cegah pindah fokus ke node group saat dihover atau dipilih
    Private Sub TreeList_FocusedNodeChanged(sender As Object, e As FocusedNodeChangedEventArgs)
        Dim tl As TreeList = TryCast(sender, TreeList)
        If e.Node IsNot Nothing AndAlso (e.Node.HasChildren OrElse String.IsNullOrEmpty(Convert.ToString(e.Node.GetValue("IdMaster")))) Then
            tl.FocusedNode = Nothing
        End If
    End Sub

    Private Sub TreeListLookUpEdit_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs)
        ' Ambil kontrol TreeListLookUpEdit yang memicu event
        Dim editor As TreeListLookUpEdit = CType(sender, TreeListLookUpEdit)

        ' Cari node yang akan dipilih berdasarkan nilai yang baru (NewValue)
        Dim node As DevExpress.XtraTreeList.Nodes.TreeListNode = editor.Properties.TreeList.FindNodeByFieldValue("IdMaster", e.NewValue)

        ' Periksa apakah node tersebut memiliki anak (HasChildren)
        If node IsNot Nothing AndAlso node.HasChildren Then
            ' Jika memiliki anak, batalkan pemilihan dengan mengatur e.Cancel = True
            e.Cancel = True
        Else

        End If
    End Sub

    ' === Saat nilai dipilih di dropdown ===
    Private Sub OnEditValueChanged(sender As Object, e As EventArgs)
        Try
            Dim editor As TreeListLookUpEdit = TryCast(Me.OwnerEdit, TreeListLookUpEdit)
            If editor Is Nothing OrElse editor.EditValue Is Nothing Then Return

            Dim tl As TreeList = editor.Properties.TreeList
            Dim node As TreeListNode = tl.FindNodeByKeyID(editor.EditValue)

            If node IsNot Nothing Then
                KodeAccount = Convert.ToString(node.GetValue("KodeAccount"))
                NamaAccount = Convert.ToString(node.GetValue("NamaAccount"))
                Id = Convert.ToString(node.GetValue("Id"))
                ParentId = Convert.ToString(node.GetValue("ParentId"))
                LevelMaster = Convert.ToString(node.GetValue("LevelMaster"))
            Else
                ResetValues()
            End If
        Catch
            ResetValues()
        End Try
    End Sub

    Private Sub ResetValues()
        KodeAccount = Nothing
        NamaAccount = Nothing
        Id = Nothing
        ParentId = Nothing
        LevelMaster = Nothing
    End Sub

End Class
