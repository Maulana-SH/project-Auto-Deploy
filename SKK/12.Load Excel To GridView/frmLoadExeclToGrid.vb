'Imports System.Data.OleDb

Imports System.Data.OleDb

Public Class frmLoadExeclToGrid
    Dim conn As OleDbConnection
    Dim da As OleDbDataAdapter
    Dim ds As New DataSet
    Dim cmd As OleDbCommand
    Dim objDialog As New OpenFileDialog
    Dim pdtSend As New DataTable
    Dim SheetName As String
    Dim prmGetdata As Boolean = False

    Dim pdtSave As DataTable
    Private ctrlSave As NCCONTROLLERlib.clsControlleraldoStonesMEI

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        pdtSave = New DataTable
        ctrlSave = New NCCONTROLLERlib.clsControlleraldoStonesMEI With {.prop_dtaldoStonesMEI = pdtSave}
        ctrlSave.dtInitaldoStonesMEI()
    End Sub

    Private Sub cm01LoadDataExecl()
        Me.Cursor = Cursors.WaitCursor
        On Error Resume Next
        SheetName = _01SheetName.EditValue & "$"
        objDialog.Filter = "(*.xls)|*.xls|(*.xlsx)|*.xlsx|All files (*.*)|*.*"
        objDialog.ShowDialog()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" & "data source='" & objDialog.FileName & "';Extended Properties=Excel 8.0;")
        da = New OleDbDataAdapter("select * from [MasterOrder$]", conn)
        conn.Open()
        ds.Clear()
        da.Fill(ds)
        gcExecl.DataSource = ds.Tables(0)
        pdtSend.Clear()
        pdtSend = gcExecl.DataSource
        lblFileName.Text = objDialog.FileName.ToString
        conn.Close()

        Dim nTotaldata As Integer

        nTotaldata = pdtSend.Rows.Count()

        lblTotal.Text = nTotaldata

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub cm00GetPacthInfo()
        On Error Resume Next
        objDialog.Filter = "(*.xls)|*.xls|(*.xlsx)|*.xlsx|All files (*.*)|*.*"
        objDialog.ShowDialog()
        lblFileName.Text = objDialog.FileName.ToString
    End Sub

    Private Sub cm01LoadataExcel()

        If _01SheetName.EditValue <> "" Then

            Me.Cursor = Cursors.WaitCursor

            On Error Resume Next
            SheetName = _01SheetName.EditValue & "$"

            conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" & "data source='" & lblFileName.Text & "';Extended Properties=Excel 8.0;")
            da = New OleDbDataAdapter("select * from [" & SheetName & "] ", conn)
            conn.Open()
            ds.Clear()
            da.Fill(ds)
            gcExecl.DataSource = Nothing
            gcExecl.DataSource = ds.Tables(0)
            pdtSend.Clear()
            pdtSend = gcExecl.DataSource
            conn.Close()

            Dim nTotaldata As Integer

            nTotaldata = pdtSend.Rows.Count()

            lblTotal.Text = nTotaldata

            Me.Cursor = Cursors.Default
        Else
            MsgBox("masukan nama Sheet yang akan di Tampilkan")
        End If

    End Sub

    Private Sub cm02LoadDataExecl()
        Me.Cursor = Cursors.WaitCursor
        On Error Resume Next
        SheetName = _01SheetName.EditValue & "$"
        objDialog.Filter = "(*.xls)|*.xls|(*.xlsx)|*.xlsx|All files (*.*)|*.*"
        objDialog.ShowDialog()

        conn = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;" & "data source='" & objDialog.FileName & "';Extended Properties=Excel 8.0;")
        da = New OleDbDataAdapter("select * from [SaldoStonesMEI$]", conn)
        conn.Open()
        ds.Clear()
        da.Fill(ds)
        gcExecl.DataSource = ds.Tables(0)
        pdtSend.Clear()
        pdtSend = gcExecl.DataSource
        lblFileName.Text = objDialog.FileName.ToString
        conn.Close()

        Dim nTotaldata As Integer

        nTotaldata = pdtSend.Rows.Count()

        lblTotal.Text = nTotaldata

        Me.Cursor = Cursors.Default
    End Sub

    Private Sub _cm02UploadDataExecl()
        Me.Cursor = Cursors.WaitCursor
        If pdtSend.Rows.Count > 0 Then

            ctrlSave.prop_dtaldoStonesMEI.Clear()

            For Each dtRow As DataRow In pdtSend.Rows

                'ctrlSave.dtAddNewaldoStonesMEI(CStr(dtRow("k01cKodeLama").ToString()), CStr(dtRow("K02cKodeBaru").ToString()),
                '                               CStr(dtRow("f01StoneType").ToString()), CStr(dtRow("f02StonesShape").ToString()),
                '                               CStr(dtRow("f03cColorStones").ToString()), CStr(dtRow("f04cSize").ToString()),
                '                               CStr(dtRow("f05cQuality").ToString()), CStr(dtRow("f06cBrand").ToString()),
                '                               CDbl(dtRow("f07nBeratPerButir")), CDbl(dtRow("f08nBeratPer10Butir")),
                '                               CDbl(dtRow("f09nBeratTotal")), CDbl(dtRow("f10nEstimasiButir")))

                ctrlSave.dtAddNewaldoStonesMEI(dtRow("k01cKodeLama"), dtRow("K02cKodeBaru"),
                                               dtRow("f01StoneType"), dtRow("f02StonesShape"),
                                               dtRow("f03cColorStones"), dtRow("f04cSize"),
                                               dtRow("f05cQuality"), dtRow("f06cBrand"),
                                               dtRow("f07nBeratPerButir"), dtRow("f08nBeratPer10Butir"),
                                               dtRow("f09nBeratTotal"), dtRow("f10nEstimasiButir"))

            Next
            ctrlSave.prop_dtaldoStonesMEI.AcceptChanges()

            Using objsave As NCMODELlib.clsMRP_iface = New NCMODELlib.clsMRP_impl With {.prop_KeyDataTable01 = ctrlSave.prop_dtaldoStonesMEI}
                objsave.SaveDataExecl()
            End Using
            MsgBox("Data Berhasil Di SImpan")
        Else
            MsgBox("Tidak Ada data Yang Akan Di Simpan")
        End If
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        ' cm00GetPacthInfo()
        ' cm01LoadataExcel()

        cm01LoadDataExecl()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        _cm02UploadDataExecl()
    End Sub

    Private Sub _01SheetName_KeyDown(sender As Object, e As KeyEventArgs) Handles _01SheetName.KeyDown
        If e.KeyCode = Keys.Enter Then
            cm01LoadataExcel()
        End If
    End Sub
End Class