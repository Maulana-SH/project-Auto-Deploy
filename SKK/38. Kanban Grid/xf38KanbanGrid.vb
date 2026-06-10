Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Tile

Public Class xf38KanbanGrid
    Implements IDisposable

    Private pdtdataSC As DataTable

#Region " From Event "
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        pdtdataSC = New DataTable

    End Sub

    Private Sub xf38KanbanGrid_Load(sender As Object, e As EventArgs) Handles Me.Load
        cm02InitGrid()
    End Sub

#End Region

#Region "Costume Methods"
    'Private Sub cm02InitField()



    '    ' Specify the group column, by which tiles are distributed between groups.
    '    TileView1.ColumnSet.GroupColumn = tv10_f07cReserved02_v50
    '    '' Add three groups
    '    TileView1.OptionsKanban.Groups.Add(New KanbanGroup() With {
    '        .GroupValue = "TERSEDIA",
    '        .Caption = "Tersedia"
    '    })
    '    TileView1.OptionsKanban.Groups.Add(New KanbanGroup() With {
    '        .GroupValue = "REVISI"
    '    })
    '    TileView1.OptionsKanban.Groups.Add(New KanbanGroup() With {
    '        .GroupValue = "PENDING"
    '    })

    '    TileView1.OptionsKanban.Groups.Add(New KanbanGroup() With {
    '        .GroupValue = "DISPOSE"
    '    })

    '    With TileView1
    '        .OptionsDragDrop.AllowDrag = True
    '    End With

    '    TileView1.OptionsKanban.ShowGroupBackground = DefaultBoolean.True
    '    TileView1.OptionsKanban.GroupFooterButton.Visible = DefaultBoolean.True
    '    'TileView1.OptionsKanban.GroupFooterButton.Text = "Add a new card"
    '    '' Hide the footer button for the third group.
    '    'TileView1.OptionsKanban.Groups(2).FooterButton.Visible = DefaultBoolean.False

    '    tv01_k01cSKURubberSilver_v50.FieldName = "k01cSKURubberSilver_v50"
    '    tv02_k02cKodeSizeSilver_v50.FieldName = "k02cKodeSizeSilver_v50"
    '    tv03_f01cNamaSizeSilver_v100.FieldName = "f01cNamaSizeSilver_v100"
    '    tv04_f02nQtySizeSilver_int.FieldName = "f02nQtySizeSilver_int"
    '    tv05_f05nBeratSizeSilver_n92.FieldName = "f05nBeratSizeSilver_n92"
    '    tv06_f10nReserved05_n92.FieldName = "f10nReserved05_n92"
    '    tv07_nBeratNett.FieldName = "nBeratNett"
    '    tv08_f01objGambar.FieldName = "f01objGambar"
    '    tv09_f06cReserved01_v50.FieldName = "f06cReserved01_v50"
    '    tv10_f07cReserved02_v50.FieldName = "f07cReserved02_v50"

    '    GridControl1.DataSource = prop01_DataSize
    '    GridControl1.RefreshDataSource()

    'End Sub

    Private Sub cm02InitGrid()

        'Settinf Draggable
        TileView1.OptionsDragDrop.AllowDrag = True

        'SettingEdit Form
        TileView1.OptionsBehavior.EditingMode = DevExpress.XtraGrid.Views.Tile.TileViewEditingMode.EditForm

        'ShowGroup Bakcground
        TileView1.OptionsKanban.ShowGroupBackground = DevExpress.Utils.DefaultBoolean.True

        tv01_f09cStatus_v50.FieldName = "f09cStatus_v50"
        tv02_f05DateCreated_date.FieldName = "f05DateCreated_date"
        tv03_f01cNamaProses_v50.FieldName = "f01cNamaProses_v50"
        tv04_f02cKeterangan_v500.FieldName = "f02cKeterangan_v500"

        TileView1.OptionsKanban.GroupFooterButton.Visible = DefaultBoolean.True
        TileView1.OptionsKanban.GroupFooterButton.Text = "Add a new card"


        AddHandler TileView1.GroupFooterButtonClick, AddressOf TileView_GroupFooterButtonClick


        ' Grid bawah
        tv01_FullName.FieldName = "FullName"
        tv02_PrimaryTeam.FieldName = "PrimaryTeam"
        tv03_UserLanguages.FieldName = "UserLanguages"

    End Sub

    Private Sub cm03Getdata()
        Me.Cursor = Cursors.WaitCursor

        pdtdataSC.Clear()

        Using objGet As NCMODELlib.clsMRP_iface = New NCMODELlib.clsMRP_impl With {.prop_KeyInt01 = 1, .prop_KeyString01 = ""}
            pdtdataSC = objGet.Get01COMPLAINMANAGEMENT
        End Using

        GridControl1.DataSource = Nothing
        GridControl1.DataSource = pdtdataSC
        GridControl1.Refresh()

        Me.Cursor = Cursors.Default

    End Sub

    Private Sub cm04GEtDataList()
        Dim objData As New User

        Dim newFullName() As String = {"task 1", "task  2", "task 3"}

        objData.FullName = "User 1"
        objData.PrimaryTeam = "Developer"
        objData.UserLanguages = New List(Of String)(newFullName)

        GridControl2.DataSource = objData

    End Sub

#End Region

#Region " Control evnt "

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        'cm03Getdata()

        cm04GEtDataList()
    End Sub


#End Region

#Region " Tile View Event "
    Private Sub TileView_GroupFooterButtonClick(ByVal sender As Object, ByVal e As GroupFooterButtonClickEventArgs)
        MsgBox("Shooo From Add New Data")
    End Sub

    Private Sub TileView1_CustomColumnDisplayText(sender As Object, e As CustomColumnDisplayTextEventArgs) Handles TileView1.CustomColumnDisplayText

        'Totakl Dibawh Group Text
        If e.IsForGroupRow Then
            Dim kanbanGroup = TileView1.GetKanbanGroupByValue(e.Value)
            Dim count As Integer = TileView1.GetChildRowCount(kanbanGroup)
            Dim cards As String
            If count = 1 Then
                cards = " card"
            Else
                cards = " cards"
            End If
            e.DisplayText &= "<br><size=-2><r> " & CalcGroupCount(e.GroupRowHandle).ToString & cards
        End If

        ' Tyotal di samping Group Text
        'If e.IsForGroupRow Then
        '    e.DisplayText = String.Format("{0} ({1})", e.DisplayText, CalcGroupCount(e.GroupRowHandle))
        'End If
    End Sub

    Private Function CalcGroupCount(ByVal groupRowHandle As Integer) As Integer
        Dim groupIndex As Integer = Math.Abs(groupRowHandle) - 1
        Return TileView1.DataController.GroupInfo(groupIndex).ChildControllerRowCount
    End Function


    Private Sub TileView1_ItemDrag(sender As Object, e As ItemDragEventArgs) Handles TileView1.ItemDrag

        Dim Moduls As String = ""

        'Console.WriteLine("Item Drag")
    End Sub

    Private Sub TileView1_ItemDrop(sender As Object, e As ItemDropEventArgs) Handles TileView1.ItemDrop

        'Console.WriteLine("Item Drop")
    End Sub

    Private Sub TileView1_BeforeItemDrop(sender As Object, e As BeforeItemDropEventArgs) Handles TileView1.BeforeItemDrop

        Dim view As TileView = TryCast(sender, TileView)
        'Dim sourceRow = view.GetDataRow(e.ListSourceRowIndex)
        'Dim targetRow = view.GetDataRow(e.NewListSourceRowIndex)
        'Save(sourceRow, adventureWorks2012DataSet1.EmployeeDepartmentHistory.Rows.IndexOf(targetRow))

        Dim Modules As String = view.GetRowCellValue(e.IndexInGroup, "f01cNamaProses_v50")
        Dim prmStatus As String = view.GetFocusedRowCellValue(tv01_f09cStatus_v50)
        Dim prmStatusBAru As String = e.NewGroupColumnValue.ToString

        Console.WriteLine("Befotre Item Drop  = " & Modules & "   Status asal ===> " & prmStatus & " Jadi Statsu ==> " & prmStatusBAru)
        'e.Handled = True
    End Sub


#End Region
End Class
Public Class User
    Public Property FullName() As String
    Public Property PrimaryTeam() As String
    Public Property UserLanguages() As List(Of String)
End Class
