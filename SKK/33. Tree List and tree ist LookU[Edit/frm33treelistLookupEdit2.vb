Imports DevExpress.XtraEditors
Imports DevExpress.XtraTreeList
Imports DevExpress.XtraTreeList.Columns
Imports DevExpress.XtraTreeList.Nodes

' Link Tutor  https://docs.devexpress.com/WindowsForms/5597/controls-and-libraries/tree-list/feature-center/nodes/custom-nodes
Public Class frm33treelistLookupEdit2

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.


    End Sub

    Private Sub frm33treelistV2_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim list As New List(Of MyRecord)()
        list.Add(New MyRecord(0, -1, "Corporate Headquarters", 1000000, "Monterey"))
        list.Add(New MyRecord(1, 0, "Sales and Marketing", 22000, "San Francisco"))
        list.Add(New MyRecord(2, 0, "Finance", 40000, "Monterey"))
        list.Add(New MyRecord(3, 0, "Engineering", 1100000, "Monterey"))
        list.Add(New MyRecord(4, -1, "Customer Services", 850000, "Burlington, VT"))

        TreeList2.DataSource = list
        TreeList2.Columns("Budget").Format.FormatType = DevExpress.Utils.FormatType.Numeric
        TreeList2.Columns("Budget").Format.FormatString = "c0"

        cm01IinitTrelistLookUpedit(list)

        'Trelist COA
        Dim dtCOA As New List(Of dataCOA)()
        dtCOA.Add(New dataCOA(1, 0, "Neraca"))
        dtCOA.Add(New dataCOA(2, 0, "Laba Rugi"))
        dtCOA.Add(New dataCOA(3, 1, "Aset"))
        dtCOA.Add(New dataCOA(4, 3, "Piutang"))
        dtCOA.Add(New dataCOA(5, 3, "Bank dan Kas"))
        dtCOA.Add(New dataCOA(6, 3, "Aset Lancar"))
        dtCOA.Add(New dataCOA(7, 3, "Aset Tidak Lancar"))
        dtCOA.Add(New dataCOA(8, 3, "Beban Dibayar di Muka"))
        dtCOA.Add(New dataCOA(9, 3, "Aset Tetap"))
        dtCOA.Add(New dataCOA(10, 1, "Kewajiban"))
        dtCOA.Add(New dataCOA(11, 10, "Utang"))
        dtCOA.Add(New dataCOA(12, 10, "Kartu Kredit"))
        dtCOA.Add(New dataCOA(13, 10, "Kewajiban Lancar"))
        dtCOA.Add(New dataCOA(14, 10, "Kewajiban Tidak Lancar"))
        dtCOA.Add(New dataCOA(20, 2, "Pendapatan"))
        dtCOA.Add(New dataCOA(21, 2, "Beban"))
        dtCOA.Add(New dataCOA(22, 2, "Lain-Lain"))

        _02COA.Properties.ValueMember = "ID"
        _02COA.Properties.DisplayMember = "NameOfAccount"
        _02COA.Properties.DataSource = dtCOA

        ' --- Menangani event untuk membuat font tebal ---
        AddHandler _02COA.Properties.TreeList.NodeCellStyle, AddressOf TreeList_NodeCellStyle
        ' Tambahkan di dalam prosedur ConfigureTreeListLookUpEdit()
        AddHandler _02COA.EditValueChanging, AddressOf TreeListLookUpEdit_EditValueChanging


        ' --- Tambahkan kode ini untuk menghilangkan border ---
        ' Akses objek OptionsView dari TreeList
        Dim optionsView As DevExpress.XtraTreeList.TreeListOptionsView = _02COA.Properties.TreeList.OptionsView

        ' Atur properti untuk menyembunyikan garis horizontal dan vertikal
        optionsView.ShowHorzLines = False
        optionsView.ShowVertLines = False

        ' Jika Anda juga ingin menyembunyikan judul kolom (header)
        optionsView.ShowColumns = False

        ' Jika Anda ingin menyembunyikan panel indikator (nomor baris) di sisi kiri
        optionsView.ShowIndicator = False

        ' 2. Menyembunyikan tombol expand/collapse
        _02COA.Properties.TreeList.OptionsView.ShowButtons = False


        With _04Trelist
            .cm01BindingAwal()
        End With
    End Sub

    Private Sub TreeList_NodeCellStyle(sender As Object, e As DevExpress.XtraTreeList.GetCustomNodeCellStyleEventArgs)
        ' Periksa apakah node saat ini memiliki anak
        If e.Node.HasChildren Then
            ' Atur properti Font dari appearance menjadi tebal
            e.Appearance.Font = New Font(e.Appearance.Font, FontStyle.Bold)
        End If
    End Sub
    Private Sub TreeListLookUpEdit_EditValueChanging(sender As Object, e As DevExpress.XtraEditors.Controls.ChangingEventArgs)
        ' Ambil kontrol TreeListLookUpEdit yang memicu event
        Dim editor As TreeListLookUpEdit = CType(sender, TreeListLookUpEdit)

        ' Cari node yang akan dipilih berdasarkan nilai yang baru (NewValue)
        Dim node As DevExpress.XtraTreeList.Nodes.TreeListNode = editor.Properties.TreeList.FindNodeByFieldValue("ID", e.NewValue)

        ' Periksa apakah node tersebut memiliki anak (HasChildren)
        If node IsNot Nothing AndAlso node.HasChildren Then
            ' Jika memiliki anak, batalkan pemilihan dengan mengatur e.Cancel = True
            e.Cancel = True
        End If
    End Sub

    Private Sub cm01IinitTrelistLookUpedit(ByVal prmdataList As List(Of MyRecord))
        'Me.ID = id
        'Me.ParentID = parentID
        'Me.Department = department
        'Me.Budget = budget
        'Me.Location = Location

        Dim colID As New TreeListColumn With {.FieldName = "ID"}
        Dim colParentID As New TreeListColumn With {.FieldName = "ParentID"}
        Dim colDepartment As New TreeListColumn With {.FieldName = "Department"}
        Dim colBudget As New TreeListColumn With {.FieldName = "Budget"}
        Dim colLocation As New TreeListColumn With {.FieldName = "Location"}

        TreeListLookUpEdit1TreeList.Nodes.Add(New TreeListColumn() {colID, colParentID, colDepartment, colBudget, colLocation})

        With TreeListLookUpEdit1.Properties
            .NullText = ""
            .ValueMember = "Department"
            .DisplayMember = "Location"
        End With

        TreeListLookUpEdit1.Properties.DataSource = prmdataList
    End Sub
    Private Function GetParentIds(ByVal node As DevExpress.XtraTreeList.Nodes.TreeListNode) As List(Of Integer)
        Dim parentIds As New List(Of Integer)

        Dim currentNode As DevExpress.XtraTreeList.Nodes.TreeListNode = node

        ' Iterasi ke atas sampai tidak ada parent lagi
        While currentNode.ParentNode IsNot Nothing
            ' Dapatkan parent node
            currentNode = currentNode.ParentNode
            ' Ambil ID dari parent node dan tambahkan ke daftar
            parentIds.Add(CInt(currentNode.GetValue("ID")))
        End While

        ' Mengembalikan daftar ID parent
        Return parentIds
    End Function

    Private Sub TreeListLookUpEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles TreeListLookUpEdit1.EditValueChanged

        _01EditValues.EditValue = ""
        _02Text.EditValue = ""

        _01EditValues.EditValue = TreeListLookUpEdit1.EditValue
        _02Text.EditValue = TreeListLookUpEdit1.Text

    End Sub

    Private Sub _04Trelist_EditValueChanged(sender As Object, e As EventArgs) Handles _04Trelist.EditValueChanged


        _01CtrlEditValues.EditValue = ""
        _02CtrlDisplayText.EditValue = ""

        _01CtrlEditValues.EditValue = _04Trelist.EditValue
        _02CtrlDisplayText.EditValue = _04Trelist.Text
    End Sub

    Private Sub _02COA_EditValueChanged(sender As Object, e As EventArgs) Handles _02COA.EditValueChanged
        ' Ambil kontrol TreeListLookUpEdit
        Dim editor As TreeListLookUpEdit = CType(sender, TreeListLookUpEdit)

        ' Pastikan ada nilai yang dipilih
        If editor.EditValue IsNot Nothing Then
            ' Dapatkan node yang saat ini difokuskan
            Dim focusedNode As DevExpress.XtraTreeList.Nodes.TreeListNode = editor.Properties.TreeList.FocusedNode

            ' Periksa apakah focusedNode valid
            If focusedNode IsNot Nothing Then
                ' Panggil fungsi untuk mendapatkan semua ID parent
                Dim parentIds As List(Of Integer) = GetParentIds(focusedNode)

                ' Tambahkan ID node yang dipilih itu sendiri
                parentIds.Add(CInt(focusedNode.GetValue("ID")))

                ' Balik urutan daftar agar dari root ke anak
                parentIds.Reverse()

                ' Tampilkan hasilnya (misalnya di jendela debug atau kotak pesan)
                Dim result As String = "Selected ID: " & focusedNode.GetValue("ID").ToString() & vbCrLf & "Path: " & String.Join(" -> ", parentIds)
                MessageBox.Show(result, "Selected Node Path")
            End If
        End If
    End Sub
End Class

Public Class MyTreeList
    Inherits TreeList
    Public Sub New()
        MyBase.New()
        OptionsBehavior.AutoNodeHeight = False
    End Sub

    Protected Overrides Function CreateNode(ByVal nodeID As Integer, ByVal owner As TreeListNodes, ByVal tag As Object) As TreeListNode
        Return New MyTreeListNode(nodeID, owner)
    End Function
    Protected Overrides Sub InternalNodeChanged(ByVal node As TreeListNode, ByVal nodes As TreeListNodes, ByVal changeType As NodeChangeTypeEnum)
        If changeType = NodeChangeTypeEnum.User1 Then
            LayoutChanged()
        End If
        MyBase.InternalNodeChanged(node, nodes, changeType)
    End Sub
    Protected Overrides Sub RaiseCalcNodeHeight(ByVal node As TreeListNode, ByRef nodeHeight As Integer)
        Dim myNode As MyTreeListNode = CType(node, MyTreeListNode)
        If Not myNode Is Nothing Then
            nodeHeight = myNode.Height
        Else
            MyBase.RaiseCalcNodeHeight(node, nodeHeight)
        End If
    End Sub
    Public Overridable ReadOnly Property DefaultNodesHeight() As Integer
        Get
            Return 18
        End Get
    End Property
End Class

Public Class MyTreeListNode
    Inherits TreeListNode
    Const minHeight As Integer = 5
    Dim fHeight As Integer
    Public Sub New(ByVal id As Integer, ByVal owner As TreeListNodes)
        MyBase.New(id, owner)
        Me.fHeight = CType(owner.TreeList, MyTreeList).DefaultNodesHeight
    End Sub
    Public Property Height() As Integer
        Get
            Return fHeight
        End Get
        Set(ByVal Value As Integer)
            If fHeight = Value Or Value < minHeight Then Return
            fHeight = Value
            Changed(NodeChangeTypeEnum.User1)
        End Set
    End Property
End Class

Public Class MyRecord
    Public Property ID() As Integer
    Public Property ParentID() As Integer

    Public Property Department() As String
    Public Property Location() As String
    Public Property Budget() As Decimal

    Public Sub New(ByVal id As Integer, ByVal parentID As Integer, ByVal department As String, ByVal budget As Decimal, ByVal location As String)
        Me.ID = id
        Me.ParentID = parentID
        Me.Department = department
        Me.Budget = budget
        Me.Location = location
    End Sub
End Class


Public Class dataCOA
    Public Property ID() As Integer
    Public Property ParentID() As Integer

    Public Property NameOfAccount() As String

    Public Sub New(ByVal id As Integer, ByVal parentID As Integer, ByVal prmNameofAccount As String)
        Me.ID = id
        Me.ParentID = parentID
        Me.NameOfAccount = prmNameofAccount
    End Sub

End Class