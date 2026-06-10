Imports System.ComponentModel
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.XtraGrid
Imports DevExpress.XtraGrid.Columns
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports NCCONTROLLERlib

Public Class frm57GridMultilvlAdd

    Implements IDisposable


    Public Property prm01GridControl As GridControl
    Public Property prm02GridView As GridView

    Private rootList As BindingList(Of BOMItem)
    Private bomList As List(Of BOMItem)

    Private HelperGridRecrusive As clsGridRecrusiveEntry
#Region " form Evnt "

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        HelperGridRecrusive = New clsGridRecrusiveEntry
    End Sub


    Private Sub frm57GridMultilvlAdd_Load(sender As Object, e As EventArgs) Handles Me.Load


        HelperGridRecrusive.cm01InitGridRecrusive(GridControl2, GridView2)

        'Dari dalam class ini
        'prm01GridControl = GridControl1
        'prm02GridView = GridView1
        'Master_InitSetting()

    End Sub

    Private Sub Master_InitSetting()
        prm02GridView.IndicatorWidth = 50
        prm02GridView.OptionsView.NewItemRowPosition = NewItemRowPosition.Top
        prm02GridView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.True
        prm02GridView.OptionsDetail.AllowExpandEmptyDetails = True

        prm02GridView.OptionsDetail.ShowDetailTabs = False ' unutk detail child tabs nya

        prm02GridView.OptionsNavigation.EnterMoveNextColumn = False
        prm02GridView.OptionsBehavior.Editable = True

        col01_LevelBOM.FieldName = "LevelBOM"
        col02_ParentLevel.FieldName = "ParentLevel"
        col03_Nama.FieldName = "Nama"
        col04_Qty.FieldName = "Qty"
        col05_Berat.FieldName = "Berat"
        col06_TotalBerat.FieldName = "TotalBerat"


        'bomList = GetBOMData()
        ' Root node (parent is Nothing)
        'GridControl1.DataSource = bomList.Where(Function(x) x.ParentLevel Is Nothing).ToList()
        'GridView1.OptionsDetail.AllowExpandEmptyDetails = True

        bomList = GetBOMData()
        rootList = New BindingList(Of BOMItem)(bomList.Where(Function(x) x.ParentLevel Is Nothing).ToList())
        prm01GridControl.DataSource = rootList

        ' Events untuk master-detail recursive
        AddHandler prm02GridView.InitNewRow, AddressOf Master_RowInitNewRow
        AddHandler prm02GridView.MasterRowGetChildList, AddressOf Master_RowGetChildList
        AddHandler prm02GridView.MasterRowGetRelationName, AddressOf Master_RowGetRelationName
        AddHandler prm02GridView.MasterRowGetRelationCount, AddressOf Master_RowGetRelationCount
        AddHandler prm02GridView.MasterRowEmpty, AddressOf Master_RowEmpty
        AddHandler prm02GridView.MasterRowGetLevelDefaultView, AddressOf Master_RowGetLevelDefaultView
        AddHandler prm02GridView.CellValueChanged, AddressOf Master_CellValueChange
        AddHandler prm02GridView.RowUpdated, AddressOf Master_RowUpdated
        AddHandler prm02GridView.CustomDrawRowIndicator, AddressOf Master_CustomDrawRowIndicator
        AddHandler prm02GridView.ValidatingEditor, AddressOf Master_ValidatingEditor
    End Sub


    Private Sub Master_RowGetLevelDefaultView(sender As Object, e As DevExpress.XtraGrid.Views.Grid.MasterRowGetLevelDefaultViewEventArgs)
        Dim parentView As GridView = CType(sender, GridView)
        Dim grid As GridControl = parentView.GridControl

        ' Buat view baru
        Dim newView As New GridView(grid)
        grid.ViewCollection.Add(newView)

        ' Konfigurasi kolom
        Dim colLevelBOM = newView.Columns.AddVisible("LevelBOM")
        colLevelBOM.Visible = False

        Dim colParentLevel = newView.Columns.AddVisible("ParentLevel")
        colParentLevel.Visible = False

        newView.Columns.AddVisible("Nama")
        newView.Columns.AddVisible("Qty")
        newView.Columns.AddVisible("Berat")


        Dim colTotalBerat = newView.Columns.AddVisible("TotalBerat")
        colTotalBerat.OptionsColumn.ReadOnly = True

        ' Konfigurasi tampilan
        newView.OptionsView.ShowGroupPanel = False
        newView.OptionsView.NewItemRowPosition = NewItemRowPosition.Top
        newView.OptionsDetail.AllowExpandEmptyDetails = True

        newView.OptionsDetail.ShowDetailTabs = False ' unutk detail child tabs nya

        ' Tambahkan handler detail view (rekursif)
        AddHandler newView.MasterRowGetChildList, AddressOf Master_RowGetChildList
        AddHandler newView.MasterRowGetRelationCount, AddressOf Master_RowGetRelationCount
        AddHandler newView.MasterRowGetRelationName, AddressOf Master_RowGetRelationName
        AddHandler newView.MasterRowEmpty, AddressOf Master_RowEmpty
        AddHandler newView.MasterRowGetLevelDefaultView, AddressOf Master_RowGetLevelDefaultView
        AddHandler newView.CellValueChanged, AddressOf Master_CellValueChange

        ' Tambahkan handler baris baru dan update
        AddHandler newView.InitNewRow, AddressOf DetailView_InitNewRow
        AddHandler newView.RowUpdated, AddressOf DetailView_RowUpdated

        ' Tetapkan sebagai default view untuk level tersebut
        e.DefaultView = newView
    End Sub

    '' untuk parent jika ad new Rows
    Private Sub Master_RowInitNewRow(sender As Object, e As InitNewRowEventArgs)
        ' untuk New Root lavel
        Dim view As GridView = CType(sender, GridView)
        Dim newItem As New BOMItem With {
            .LevelBOM = GetNextRootLevel(),
            .ParentLevel = Nothing,
            .Nama = "",
            .Qty = 1,
            .Berat = 0.5D
        }

        view.SetRowCellValue(e.RowHandle, "LevelBOM", newItem.LevelBOM)
        view.SetRowCellValue(e.RowHandle, "ParentLevel", newItem.ParentLevel)
        'view.SetRowCellValue(e.RowHandle, "Nama", newItem.Nama)
        view.FocusedColumn = view.Columns("Nama")
        view.SetRowCellValue(e.RowHandle, "Qty", newItem.Qty)
        view.SetRowCellValue(e.RowHandle, "Berat", newItem.Berat)

        ' Tambahkan ke root list dan master list
        'rootList.Add(newItem)
        'bomList.Add(newItem)

    End Sub

    Private Sub Master_ValidatingEditor(sender As Object, e As BaseContainerValidateEditorEventArgs)
        Dim view As GridView = CType(sender, GridView)
        Dim col = view.FocusedColumn.FieldName

        If col = "LevelBOM" AndAlso String.IsNullOrWhiteSpace(CStr(e.Value)) Then
            e.Valid = False
            e.ErrorText = "LevelBOM tidak boleh kosong."
        End If

    End Sub

    Private Sub Master_CellValueChange(sender As Object, e As CellValueChangedEventArgs)
        'If e.Column.FieldName = "Nama" Then
        '    'col03_Nama

        '    'MsgBox($"casted part kode {e.Value}")
        'End If

        Dim view As GridView = CType(sender, GridView)

        If e.Column.FieldName = "Nama" Then
            Dim rowHandle = e.RowHandle
            Dim namaParent = view.GetRowCellValue(rowHandle, "Nama")?.ToString()

            If String.IsNullOrEmpty(namaParent) Then Return

            ' Ambil BOMItem parent
            Dim parentItem As BOMItem = CType(view.GetRow(rowHandle), BOMItem)

            ' Filter detail dari DataTable lookup
            Dim foundDetails As DataTable = cmGetMasterPart(e.Value)

            If foundDetails.Rows.Count > 0 Then
                For Each row As DataRow In foundDetails.Rows

                    ' kalau nOll = parent nya
                    If row("parentID") > 0 Then

                        Dim childItem As New BOMItem With {
                        .ParentLevel = parentItem.LevelBOM,
                        .LevelBOM = GenerateNextLevelCode(parentItem.LevelBOM),
                        .Nama = row("f01cItemCastedPartsDesc_v50").ToString(),
                        .Qty = 1,' Convert.ToDecimal(row("Qty")),
                        .Berat = Convert.ToDecimal(row("nKadarNum"))
                             }

                        bomList.Add(childItem)
                    End If

                Next

                ' Refresh view dan expand
                view.RefreshData()
                view.ExpandMasterRow(rowHandle)
            End If

        End If
    End Sub

    ' Event: ambil child list
    Private Sub Master_RowGetChildList(sender As Object, e As DevExpress.XtraGrid.Views.Grid.MasterRowGetChildListEventArgs)
        'Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        'Dim parentRow As BOMItem = CType(view.GetRow(e.RowHandle), BOMItem)
        'e.ChildList = bomList.Where(Function(x) x.ParentLevel = parentRow.LevelBOM).ToList()

        Dim view As GridView = CType(sender, GridView)
        Dim parentItem As BOMItem = CType(view.GetRow(e.RowHandle), BOMItem)

        ' FILTER anak-anaknya
        Dim children = bomList.Where(Function(x) x.ParentLevel = parentItem.LevelBOM).ToList()

        ' ✅ Gunakan BindingList agar mendukung penambahan data secara dinamis
        e.ChildList = New BindingList(Of BOMItem)(children)
    End Sub

    ' Event: selalu 1 relasi
    Private Sub Master_RowGetRelationCount(sender As Object, e As DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationCountEventArgs)
        e.RelationCount = 1
    End Sub

    ' Event: nama relasi
    Private Sub Master_RowGetRelationName(sender As Object, e As DevExpress.XtraGrid.Views.Grid.MasterRowGetRelationNameEventArgs)
        e.RelationName = "Detail BOM"
    End Sub

    ' Event: cek apakah ada anak
    Private Sub Master_RowEmpty(sender As Object, e As DevExpress.XtraGrid.Views.Grid.MasterRowEmptyEventArgs)
        ' Dim view As DevExpress.XtraGrid.Views.Grid.GridView = CType(sender, DevExpress.XtraGrid.Views.Grid.GridView)
        ' Dim row As BOMItem = CType(view.GetRow(e.RowHandle), BOMItem)
        'e.IsEmpty = Not bomList.Any(Function(x) x.ParentLevel = row.LevelBOM)

        ' Selalu katakan bahwa baris tidak kosong, supaya expand icon muncul
        e.IsEmpty = False
    End Sub

    Private Sub Master_RowUpdated(sender As Object, e As RowObjectEventArgs)
        ' untuk setting aprent jika di haopus parent tidak jalan
        Dim newItem As BOMItem = TryCast(e.Row, BOMItem)

        If newItem IsNot Nothing AndAlso Not bomList.Contains(newItem) Then
            bomList.Add(newItem) ' Tambahkan ke list utama setelah selesai input
        End If
    End Sub

    Private Sub Master_CustomDrawRowIndicator(sender As Object, e As RowIndicatorCustomDrawEventArgs)
        ' Put This code in Init FieldName    
        ' GridView1.IndicatorWidth = 50 

        '# Methods In GridView
        'CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1 'e.RowHandle.ToString()
        End If
    End Sub

    Private Sub DetailView_InitNewRow(sender As Object, e As InitNewRowEventArgs)
        Dim view As GridView = CType(sender, GridView)
        Dim parent As BOMItem = CType(view.ParentView.GetRow(view.SourceRowHandle), BOMItem)
        Dim newItem As BOMItem = New BOMItem With {
            .ParentLevel = parent.LevelBOM,
            .LevelBOM = GenerateNextLevelCode(parent.LevelBOM),
            .Nama = "",
            .Qty = 0,
            .Berat = 0
        }

        view.SetRowCellValue(e.RowHandle, "LevelBOM", newItem.LevelBOM)
        view.SetRowCellValue(e.RowHandle, "ParentLevel", newItem.ParentLevel)
        ' view.SetRowCellValue(e.RowHandle, "Nama", newItem.Nama)
        view.FocusedColumn = view.Columns("Nama")
        view.SetRowCellValue(e.RowHandle, "Qty", 1D)
        view.SetRowCellValue(e.RowHandle, "Berat", 0.1D)

    End Sub

    Private Sub DetailView_RowUpdated(sender As Object, e As RowObjectEventArgs)
        '*************************************
        'Dim view As GridView = CType(sender, GridView)
        'Dim newRow As BOMItem = CType(e.Row, BOMItem)
        '' Tambah ke list utama
        'bomList.Add(newRow)
        '' Refresh jika perlu
        'view.RefreshData()
        '*************************************

        'v2 agar yg data baru bisa di add Detail 
        Dim view As GridView = CType(sender, GridView)
        Dim newRow As BOMItem = CType(e.Row, BOMItem)

        ' Tambah ke list jika belum ada
        If Not bomList.Any(Function(x) x.LevelBOM = newRow.LevelBOM) Then
            bomList.Add(newRow)
        End If

        ' ✅ Refresh parent agar master-detail tau bahwa item ini bisa expand
        Dim parentView As GridView = TryCast(view.ParentView, GridView)
        If parentView IsNot Nothing Then
            parentView.RefreshData()
        End If
    End Sub

    Private Function GenerateNextLevelCode(parentLevel As String) As String
        ' Unutk ambil levekl saat child si input
        ' Ambil semua anak dari parent ini
        Dim children = bomList.Where(Function(x) x.ParentLevel = parentLevel).ToList()

        ' Jika belum ada anak, maka tambahkan ".1"
        If children.Count = 0 Then
            Return parentLevel & ".1"
        End If

        ' Ambil angka terakhir dari LevelBOM anak-anaknya
        Dim lastNumbers = children.
        Select(Function(c)
                   Dim parts = c.LevelBOM.Split("."c)
                   Return Integer.Parse(parts(parts.Length - 1))
               End Function)

        Dim nextNumber = lastNumbers.Max() + 1

        Return parentLevel & "." & nextNumber.ToString()
    End Function

    Private Function GetNextRootLevel() As String
        ' untuk ambil level saat PArent di Ambil
        Dim maxLevel = bomList.Where(Function(x) x.ParentLevel Is Nothing).
        Select(Function(x) Integer.Parse(x.LevelBOM)).
        DefaultIfEmpty(0).Max()
        Return (maxLevel + 1).ToString()
    End Function

    Private Sub DeleteSelectedRow()
        Dim focusView As GridView = TryCast(prm01GridControl.FocusedView, GridView)
        If focusView Is Nothing Then Return

        Dim rowHandle As Integer = focusView.FocusedRowHandle
        If rowHandle < 0 Then Return

        Dim item As BOMItem = CType(focusView.GetRow(rowHandle), BOMItem)
        If item Is Nothing Then Return

        ' Konfirmasi penghapusan
        If MessageBox.Show($"Hapus item: {item.LevelBOM} - {item.Nama}?", "Konfirmasi", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Return
        End If

        ' Hapus dari list utama
        bomList.RemoveAll(Function(x) x.LevelBOM = item.LevelBOM OrElse x.ParentLevel = item.LevelBOM)

        ' Refresh data
        focusView.DeleteRow(rowHandle)

        ' Refresh parent agar struktur master-detail update
        Dim parentView As GridView = TryCast(focusView.ParentView, GridView)
        If parentView IsNot Nothing Then
            parentView.RefreshData()
        Else
            prm02GridView.RefreshData()
        End If
    End Sub

    Private Sub ClearGrid()
        ' Clear data di kedua list
        bomList.Clear()
        rootList.Clear()

        ' Refresh GridControl untuk merefleksikan perubahan
        prm01GridControl.RefreshDataSource()
    End Sub


#End Region

#Region " Custome Methods PUBLIC AKSES"

    Private Function GetBOMData() As List(Of BOMItem)

        '    Return New List(Of BOMItem) From {
        '  New BOMItem With {.LevelBOM = "1", .ParentLevel = Nothing, .Nama = "RI221355-010", .Qty = 1, .Berat = 0.5D},
        'New BOMItem With {.LevelBOM = "1.1", .ParentLevel = "1", .Nama = "RI22135 A", .Qty = 2, .Berat = 0.4D},
        'New BOMItem With {.LevelBOM = "1.1.1", .ParentLevel = "1.1", .Nama = "AU375YLCT", .Qty = 1, .Berat = 0.25D},
        'New BOMItem With {.LevelBOM = "1.1.1.1", .ParentLevel = "1.1.1", .Nama = "LM", .Qty = 3, .Berat = 0.1D},
        'New BOMItem With {.LevelBOM = "1.1.1.2", .ParentLevel = "1.1.1", .Nama = "ALLOY", .Qty = 2, .Berat = 0.2D},
        'New BOMItem With {.LevelBOM = "1.2", .ParentLevel = "1", .Nama = "RI22135 B", .Qty = 2, .Berat = 0.3D},
        'New BOMItem With {.LevelBOM = "1.2.1", .ParentLevel = "1.2", .Nama = "AU375YLCT", .Qty = 1, .Berat = 0.25D},
        'New BOMItem With {.LevelBOM = "1.2.2", .ParentLevel = "1.2.1", .Nama = "LM", .Qty = 1, .Berat = 0.15D},
        'New BOMItem With {.LevelBOM = "1.2.3", .ParentLevel = "1.2.1", .Nama = "ALLOY", .Qty = 1, .Berat = 0.15D},
        'New BOMItem With {.LevelBOM = "1.3", .ParentLevel = "1", .Nama = "PPM200065", .Qty = 1, .Berat = 0.5D},
        'New BOMItem With {.LevelBOM = "1.3.1", .ParentLevel = "1.3", .Nama = "AU375YLCT", .Qty = 2, .Berat = 0.3D},
        'New BOMItem With {.LevelBOM = "1.3.2", .ParentLevel = "1.3.1", .Nama = "LM", .Qty = 1, .Berat = 0.1D},
        'New BOMItem With {.LevelBOM = "1.3.3", .ParentLevel = "1.3.1", .Nama = "ALLOY", .Qty = 1, .Berat = 0.1D}
        '}

        'Return New List(Of BOMItem) From {
        'New BOMItem With {.LevelBOM = "1", .ParentLevel = Nothing, .Nama = "RI221355-010", .Qty = 1, .Berat = 0.5D},
        'New BOMItem With {.LevelBOM = "1.1", .ParentLevel = "1", .Nama = "RI22135 A", .Qty = 2, .Berat = 0.4D},
        'New BOMItem With {.LevelBOM = "1.1.1", .ParentLevel = "1.1", .Nama = "AU375YLCT", .Qty = 1, .Berat = 0.25D},
        'New BOMItem With {.LevelBOM = "1.1.1.1", .ParentLevel = "1.1.1", .Nama = "LM", .Qty = 3, .Berat = 0.1D},
        'New BOMItem With {.LevelBOM = "1.1.1.2", .ParentLevel = "1.1.1", .Nama = "ALLOY", .Qty = 2, .Berat = 0.2D}
        '}

        Return New List(Of BOMItem)
    End Function

    Private Function FlattenBOMList(bomItems As List(Of BOMItem)) As List(Of BOMItem)
        Dim flatList As New List(Of BOMItem)

        ' Cek null list
        If bomItems Is Nothing OrElse bomItems.Count = 0 Then
            Return flatList
        End If

        ' Tangani null ParentLevel dengan aman
        Dim roots = bomItems.Where(Function(x) String.IsNullOrEmpty(x.ParentLevel)).ToList()

        If roots Is Nothing OrElse roots.Count = 0 Then
            MessageBox.Show("Tidak ditemukan data root (ParentLevel kosong).")
            Return flatList
        End If

        ' Mulai flatten
        For Each root As BOMItem In roots
            FlattenRecursive(root, bomItems, flatList)
        Next

        Return flatList
    End Function

    Private Sub FlattenRecursive(item As BOMItem, allItems As List(Of BOMItem), result As List(Of BOMItem))
        ' Tambahkan item sekarang ke list flat
        result.Add(item)

        ' Cari anak dari item sekarang
        Dim children = allItems.Where(Function(x) x.ParentLevel = item.LevelBOM).ToList()

        ' Rekursif ke setiap anak
        For Each child In children
            FlattenRecursive(child, allItems, result)
        Next
    End Sub

    Private Function ToDataTable(flatList As List(Of BOMItem)) As DataTable
        Dim dt As New DataTable()
        dt.Columns.Add("LevelBOM")
        dt.Columns.Add("ParentLevel")
        dt.Columns.Add("Nama")
        dt.Columns.Add("Qty", GetType(Decimal))
        dt.Columns.Add("Berat", GetType(Decimal))
        dt.Columns.Add("TotalBerat", GetType(Decimal))

        For Each item In flatList
            dt.Rows.Add(item.LevelBOM, item.ParentLevel, item.Nama, item.Qty, item.Berat, item.TotalBerat)
        Next

        Return dt
    End Function

    Private Function cmGetMasterPart(ByVal prmCastedPart As String)
        Dim pdtHasil As New DataTable()

        Using ObjGetMaster As NCMODELlib.clsNEWCENTRAL_iface = New NCMODELlib.clsNEWCENTRAL_impl With {.prop_nTarget = 2, .prop_k01cNoKey_v50 = prmCastedPart}
            pdtHasil = ObjGetMaster.SeleMAsterCadtedPart
        End Using

        Return pdtHasil
    End Function

#End Region

#Region " Control Evnt "

    Private Sub btnAddRoot_Click(sender As Object, e As EventArgs) Handles btnAddRoot.Click
        'CekLastLevelBOM()
        DeleteSelectedRow()
    End Sub


    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        Dim flatList As List(Of BOMItem) = FlattenBOMList(bomList)
        Dim dt As DataTable = ToDataTable(flatList)

        ' Tampilkan ke GridControl atau DataGridView
        ' GridControl1.DataSource = dt
    End Sub


    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ClearGrid()
    End Sub

    Private Sub btnGetFlat_Click(sender As Object, e As EventArgs) Handles btnGetFlat.Click
        Dim dt As DataTable = HelperGridRecrusive.cm02GetFlateDataTable()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        HelperGridRecrusive.cm04Clear()

    End Sub

    Private Sub btnDelet_Click(sender As Object, e As EventArgs) Handles btnDelet.Click

        HelperGridRecrusive.cm03DeleteSelected()
    End Sub


#End Region

#Region " Grid Evnt "


#End Region


End Class

' tutup di class yang di
'Public Class BOMItem
'    Public Property LevelBOM As String         ' e.g. "1.2.1"
'    Public Property ParentLevel As String      ' e.g. "1.2"
'    Public Property Nama As String             ' e.g. "Sub Komponen"
'    Public Property Qty As Decimal
'    Public Property Berat As Decimal

'    Public ReadOnly Property TotalBerat As Decimal
'        Get
'            Return Qty * Berat
'        End Get
'    End Property
'End Class