
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports DevExpress.XtraExport.Helpers
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports NCCONTROLLERlib
Imports NCMODELlib

Public Class frm41StokOpnameWH
    Implements IDisposable

    Public Property prop01_idUser As String
    Public Property prop02_NamaUser As String

    Private pdtFORCekSKU As DataTable

    Private pdtDisplayGrid As DataTable
    Private mdl01SOWHGrid As clsControllerTABLE01

    Private pdtMdl As DataTable
    Private mdl01SOWHSave As clsControllerTABLE01

#Region " Form Evnt "

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        pdtFORCekSKU = New DataTable

        pdtDisplayGrid = New DataTable
        mdl01SOWHGrid = New clsControllerTABLE01 With {.prop_dtABLE01 = pdtDisplayGrid}
        mdl01SOWHGrid.dtInitABLE01()

        pdtMdl = New DataTable
        mdl01SOWHSave = New clsControllerTABLE01 With {.prop_dtABLE01 = pdtMdl}
        mdl01SOWHSave.dtInitABLE01()
    End Sub

    Private Sub frm41StokOpnameWH_Load(sender As Object, e As EventArgs) Handles Me.Load
        cm06Clear()
        cm02InitField()
    End Sub
#End Region

#Region " Costume Methods "

    Private Sub cm01Inicontrol()
        lyt_01Nik.Enabled = False
        lyt_02Nama.Enabled = False

        prop01_idUser = _01Nik.EditValue
        prop02_NamaUser = _02Nama.EditValue

        _03Lemari.EditValue = ""
        _04Box.EditValue = ""
        _05SKU.EditValue = ""
        _06BeratSO.EditValue = 0
        _08ReaderSKU.EditValue = ""
        _09Pcs.EditValue = 1
        _10IdBatch.EditValue = ""


        With _07cpnTimbang
            ._01prop_BeratTimbngan = _06BeratSO
            .cm00BindingAwal()
        End With

        lyt_timbangan.Text = _07cpnTimbang._03StatusTimbangan

        mdl01SOWHSave.prop_dtABLE01.Clear()

        mdl01SOWHGrid.prop_dtABLE01.Clear()

        gcSO.DataSource = mdl01SOWHGrid.prop_dtABLE01
        gcSO.RefreshDataSource()

    End Sub

    Private Sub cm02InitField()
        GridView1.IndicatorWidth = 50
        With GridView1
            .OptionsView.ShowGroupPanel = False
            '.OptionsView.ColumnAutoWidth = False
            .OptionsView.ShowFooter = True

            .OptionsView.EnableAppearanceOddRow = True
            .Appearance.OddRow.BackColor = Color.WhiteSmoke
        End With

        col01_k01String.FieldName = "k01String"       ' => SKU
        col02_k03String.FieldName = "k03String"       ' => Lemari
        col03_k04String.FieldName = "k04String"       ' => BOX
        col04_f01Double.FieldName = "f01Double"       ' => berat SO
        col05_f01Date.FieldName = "f01Date"           ' => Date SO
        col06_f01Datetime.FieldName = "f01Datetime"       ' => datetime SO
        col07_f01IDUser.FieldName = "f01IDUser"   ' => Id USer
        col08_f01NamaUser.FieldName = "f01NamaUser"   ' => nama User
        col10_f01Int.FieldName = "f01Int"   ' => PCS



        col04_f01Double.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        col04_f01Double.SummaryItem.FieldName = "f01Double"
        col04_f01Double.SummaryItem.DisplayFormat = " {0:n2} Grams"

        col10_f01Int.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        col10_f01Int.SummaryItem.FieldName = "f01Int"
        col10_f01Int.SummaryItem.DisplayFormat = " {0:n0} Pcs"

        col01_k01String.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Count
        col01_k01String.SummaryItem.FieldName = "k01String"
        col01_k01String.SummaryItem.DisplayFormat = " {0:n0} SKU"


        mdl01SOWHGrid.prop_dtABLE01.AcceptChanges()
        gcSO.DataSource = mdl01SOWHGrid.prop_dtABLE01
        gcSO.RefreshDataSource()
        GridView1.RefreshData()


    End Sub


    Private Sub cm04MulaiSO()
        ' Sama dengan Get WIP yang sudah di SO kemarin (Get all Data BY Nik user)
        cm01Inicontrol()

        'SET BACT Number Random Int
        _10IdBatch.EditValue = ""
        '_10IdBatch.EditValue = cm10GenerateRandomNumber()
        _10IdBatch.EditValue = Guid.NewGuid.ToString

        mdl01SOWHGrid.prop_dtABLE01.Clear()

        mdl01SOWHGrid.prop_dtABLE01 = cm07GetDataSO(3, "", prop01_idUser)

        If mdl01SOWHGrid.prop_dtABLE01.Rows.Count > 0 Then

            mdl01SOWHGrid.prop_dtABLE01.AcceptChanges()
            gcSO.DataSource = mdl01SOWHGrid.prop_dtABLE01
            gcSO.Refresh()
            GridView1.RefreshData()
            GridView1.MoveLast()

            'Else
            '    MsgBox("")
        End If

    End Sub

    Private Function cm05ValidasiMulaiSO()
        Dim isValid As Boolean = True
        Dim prmMsg As String = ""

        If _01Nik.EditValue = "" Then
            isValid = False
            prmMsg = " Silahkan Masukan ID NIK ... "
        Else
            If _02Nama.EditValue = "" Then
                isValid = False
                prmMsg = " Silahkan Masukan Nama ... "
            End If
        End If

        If Not isValid Then
            XtraMessageBox.Show(prmMsg, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, DefaultBoolean.True)
        End If

        Return isValid
    End Function

    Private Sub cm06Clear()
        _01Nik.EditValue = ""
        _02Nama.EditValue = ""
        _03Lemari.EditValue = ""
        _04Box.EditValue = ""
        _05SKU.EditValue = ""
        _06BeratSO.EditValue = 0
        _08ReaderSKU.EditValue = ""
        _09Pcs.EditValue = 1
        _10IdBatch.EditValue = ""


        mdl01SOWHSave.prop_dtABLE01.Clear()
        mdl01SOWHGrid.prop_dtABLE01.Clear()
        GridView1.RefreshData()
        gcSO.RefreshDataSource()

        'btnReset.Enabled = False
        'btnMulaiSO.Enabled = True

        lyt_btnMulai.Enabled = True
        lyt_btnReset.Enabled = False

        lyt_01Nik.Enabled = True
        lyt_02Nama.Enabled = True
    End Sub

    Private Function cm07GetDataSO(ByVal prmnTarget As Integer, ByVal prmSKU As String, ByVal prmNIKUser As String) As DataTable
        ' 1. Get All
        ' 2. Get data By SPK
        ' 3. Get By Nik User

        Dim pdtHasil As New DataTable
        pdtHasil.Clear()

        Using objData As clsMRP_iface = New clsMRP_impl With {.prop_KeyInt01 = prmnTarget,
                                                            .prop_KeyString01 = prmSKU,
                                                            .prop_KeyString02 = prmNIKUser}
            pdtHasil = objData.sele01WS
        End Using

        Return pdtHasil
    End Function

    Private Sub cm08AutoSaveData(ByVal prm00Batch As String, ByVal prm01SKU As String, ByVal prm02Lemari As String, ByVal prm03Box As String, ByVal prm04Berat As Double, ByVal prm05Pcs As Double)
        ' AUto save SO saat scan barcode
        mdl01SOWHSave.prop_dtABLE01.Clear()

        mdl01SOWHSave.dtAddNewABLE01(prm01SKU, 0, prm02Lemari, prm03Box, prm00Batch,  '--> Key
                               "", "", "", "", "", "", "", "", "", "",                         '-> String
                               "", "", "", "", "", "", "", "", "", "",                                  '-> String
                               "", "", "", "", "", "", "", "", "", "",                                  '-> String
                               "", Nothing,                                                             '-> mem01, memo2(varbirnary max)
                               prm05Pcs, 0, 0, 0, 0, 0, 0,                                                     '-> INT
                               prm04Berat, 0, 0, 0, 0, 0, 0,                                                     '-> Double 9,2
                               0, 0, 0, 0, 0,                                                           '-> Double 16,3
                               Date.Now, ' -> tgl Proses
                               "3000-01-01", "3000-01-01", "3000-01-01", "3000-01-01",    '-> Date
                                DateTime.Now, '-> tgl & jam SO
                                "3000-01-01",                                             '-> DateTime
                               prop01_idUser, "",
                               prop02_NamaUser, "")

        mdl01SOWHSave.prop_dtABLE01.AcceptChanges()

        Using objSaveSo As clsMRP_iface = New clsMRP_impl With {.prop_KeyDataTable01 = mdl01SOWHSave.prop_dtABLE01}
            objSaveSo.save01WS()
        End Using

    End Sub

    Private Sub cm09DisplayToGrid(ByVal prmSKU As String)
        Dim pdtSKU As New DataTable
        pdtSKU.Clear()
        pdtSKU = cm07GetDataSO(2, prmSKU, "")

        If pdtSKU.Rows.Count > 0 Then

            For Each itm As Object In pdtSKU.Rows

                mdl01SOWHGrid.dtAddNewABLE01(prmSKU, 0, itm("k03String"), itm("k04String"), itm("k05String"),  '--> Key
                             "", "", "", "", "", "", "", "", "", "",                         '-> String
                             "", "", "", "", "", "", "", "", "", "",                                  '-> String
                             "", "", "", "", "", "", "", "", "", "",                                  '-> String
                             "", vbNull,                                                             '-> mem01, memo2(varbirnary max)
                             itm("f01Int"), 0, 0, 0, 0, 0, 0,                                                     '-> INT
                             itm("f01Double"), 0, 0, 0, 0, 0, 0,                                                     '-> Double 9,2
                             0, 0, 0, 0, 0,                                                           '-> Double 16,3
                            itm("f01Date"), ' -> tgl Proses
                             "3000-01-01", "3000-01-01", "3000-01-01", "3000-01-01",    '-> Date
                            itm("f01Datetime"), '-> tgl & jam SO
                              "3000-01-01",                                             '-> DateTime
                             itm("f01IDUser"), "",
                             itm("f01NamaUser"), "")



            Next

            Console.WriteLine(" Add To grid Function => data ditemukan")

            mdl01SOWHGrid.prop_dtABLE01.AcceptChanges()
            gcSO.DataSource = mdl01SOWHGrid.prop_dtABLE01
            gcSO.Refresh()
            GridView1.RefreshData()
            GridView1.MoveLast()


            'gcSO.RefreshDataSource()
            ' GridView1.MoveLast() ' setting focus last row
        Else
            Console.WriteLine(" Add To grid Function => data Tidak di temukan")
        End If

    End Sub

    Private Sub cm10CekSKUAlredyExistINDB(ByVal prmSKU As String)

        pdtFORCekSKU.Clear()
        pdtFORCekSKU = cm07GetDataSO(2, prmSKU, "")
        pdtFORCekSKU.AcceptChanges()

        '*****************************
        ' variabel untuk info Data Sudah di save
        Dim prcSKU As String = ""
        Dim prcLemari As String = ""
        Dim prcLaci As String = ""
        Dim prcJam As String = ""
        Dim prcUser As String = ""
        Dim prcPCS As Double = 0
        Dim prcBerat As Double = 0


        'k03String,'Leamri
        'k04String, ' laci
        'f01Datetime, ' Jamr
        'f01NamaUser ' Oleh


        Dim prmPesanInfo As String = ""

        If pdtFORCekSKU.Rows.Count > 0 Then
            '' SKU SUDAH PERNAH DI SCAN

            For Each itm As DataRow In pdtFORCekSKU.Rows
                prcSKU = itm("k01String")
                prcPCS = itm("f01Int")
                prcBerat = itm("f01Double")
                prcLemari = itm("k03String")
                prcLaci = itm("k04String")
                prcUser = itm("f01NamaUser")
                prcJam = itm("f01Datetime")
            Next

            prmPesanInfo = ""
            prmPesanInfo = "Maaf.. SKU " & prcSKU & " Sudah pernah Di Scan Seblum nya" & vbNewLine &
                           " Lemari   = " & prcLemari & vbNewLine &
                           " LACI/BOX = " & prcLaci & vbNewLine &
                           " PCS      = " & prcPCS & vbNewLine &
                           " Berat    = " & prcBerat & vbNewLine &
                           " Oleh = " & prcUser & " pada " & prcJam

            XtraMessageBox.Show(prmPesanInfo, "Warning", MessageBoxButtons.OK, DefaultBoolean.True)

        Else
            ' JIKA BELUM ADA DI DB INSERT INTO
            '01 Save To database
            cm08AutoSaveData(_10IdBatch.EditValue, _05SKU.EditValue, _03Lemari.EditValue,
                                 _04Box.EditValue, _06BeratSO.EditValue, _09Pcs.EditValue)

            '02.DisplaY Data SO to Grid
            cm09DisplayToGrid(_05SKU.EditValue)
        End If

    End Sub

    Private Sub cm11DeleteRows(sender As Object, e As EventArgs)
        GridView1.DeleteSelectedRows()
        mdl01SOWHSave.prop_dtABLE01.AcceptChanges()
        GridView1.RefreshData()
        '' GridView1.MoveLast()
        gcSO.RefreshDataSource()

    End Sub


#End Region

#Region " Control Evnt "

    Private Sub _06BeratSO_EditValueChanged(sender As Object, e As EventArgs) Handles _06BeratSO.EditValueChanged
        If _06BeratSO.EditValue > 0 Then

            '' Save Data SO
            'cm08AutoSaveData(_10IdBatch.EditValue, _05SKU.EditValue, _03Lemari.EditValue,
            '                 _04Box.EditValue, _06BeratSO.EditValue, _09Pcs.EditValue)

            '' Displat Data SO to Grid
            'cm09DisplayToGrid(_05SKU.EditValue)
        End If
    End Sub


    Private Sub _08ReaderSKU_KeyPress(sender As Object, e As KeyPressEventArgs) Handles _08ReaderSKU.KeyPress
        If e.KeyChar = ChrW(13) Then
            _05SKU.EditValue = ""
            _05SKU.EditValue = _08ReaderSKU.Text
            _08ReaderSKU.Text = ""
        End If
    End Sub

    Private Sub _05SKU_EditValueChanged(sender As Object, e As EventArgs) Handles _05SKU.EditValueChanged
        If _05SKU.EditValue <> "" Then
            _07cpnTimbang._cm01GetDataTimbangan()

            If _06BeratSO.EditValue > 0 Then

                cm10CekSKUAlredyExistINDB(_05SKU.EditValue)
            Else
                MsgBox("Maaf... Berat Timbangan Masih Nol (0) Pastikan Berat sudah Benar.. " & vbNewLine &
                       " Tekan Print Pada Timbangan Jika Berat Belum Berubah Di Display System ..", MsgBoxStyle.Exclamation + vbOKOnly, "Warning..")
            End If
        End If
    End Sub

    Private Sub btnMulaiSO_Click(sender As Object, e As EventArgs) Handles btnMulaiSO.Click
        If cm05ValidasiMulaiSO() Then
            cm04MulaiSO()

            'btnReset.Enabled = True
            'btnMulaiSO.Enabled = False

            lyt_btnMulai.Enabled = False
            lyt_btnReset.Enabled = True
        End If

    End Sub


    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'btnReset.Enabled = False
        'btnMulaiSO.Enabled = True
        cm06Clear()

        lyt_btnMulai.Enabled = True
        lyt_btnReset.Enabled = False
    End Sub

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        GridView1.ShowPrintPreview()
    End Sub




#End Region

#Region " Grid Evnt "

    Private Sub GridView1_CustomDrawRowIndicator(sender As Object, e As RowIndicatorCustomDrawEventArgs) Handles GridView1.CustomDrawRowIndicator

        ' Put This code in Init FieldName    
        ' GridView1.IndicatorWidth = 50 

        '# Methods In GridView
        'CustomDrawRowIndicator
        If e.RowHandle >= 0 Then
            e.Info.DisplayText = e.RowHandle + 1 'e.RowHandle.ToString()
        End If
    End Sub

    Private Sub GridView1_MouseDown(sender As Object, e As MouseEventArgs) Handles GridView1.MouseDown
        If e.Button = MouseButtons.Right Then

            Dim m As New ContextMenuStrip
            Dim itemDelete As New ToolStripMenuItem("Delete This Row")
            AddHandler itemDelete.Click, AddressOf cm11DeleteRows
            m.Items.Add(itemDelete)
            gcSO.ContextMenuStrip = m

        End If
    End Sub

    Private needMoveLastRow As Boolean = True
    Private Sub GridView1_RowLoaded(sender As Object, e As RowEventArgs) Handles GridView1.RowLoaded
        Dim view As ColumnView = TryCast(sender, ColumnView)

        If needMoveLastRow Then
            needMoveLastRow = False
            view.MoveLast()
        End If
    End Sub


#End Region

End Class

