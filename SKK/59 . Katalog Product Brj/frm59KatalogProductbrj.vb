'*** GENERATE FROM CASE 2022 *** 
'===============================
'INFORMATION  
'Author : Maulana SH 
'VISUAL STUDIo Version : 2022  
'Devexpress Version : V21.2.5  
'******************************* 
Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports NCMODELlib

Public Class frm59KatalogProductbrj

    Private pdtReport As DataTable

#Region "From Event"

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        'Add any initialization after the InitializeComponent() call.

        pdtReport = New DataTable
    End Sub

    Private Sub xfrm59KatalogProductbrj_Load(sender As Object, e As EventArgs) Handles Me.Load
        cm01InitControl()
        cm02InitField()
    End Sub

#End Region

#Region "Custome Methods"

    Private Sub cm01InitControl()
        'Lyt_01TglAwal.Enabled = False
        'Lyt_02TglAkhir.Enabled = False
        '_01TglAwal.EditValue = Date.Now
        '_02TglAkhir.EditValue = Date.Now
    End Sub
    Private Sub cm02InitField()
        '*** Gridcontrol Field ***
        'GridView1.OptionsView.ColumnAutoWidth = False
        'GridView1.OptionsView.RowAutoHeight = True

        TileView1.OptionsHtmlTemplate.ItemAutoHeight = True

        gcCol01_k02String.FieldName = "k02String"
        gcCol02_f02String.FieldName = "f02String"
        gcCol03_f06String.FieldName = "f06String"
        gcCol04_f08String.FieldName = "f08String"
        gcCol05_f10String.FieldName = "f10String"
        gcCol06_f12String.FieldName = "f12String"
        gcCol07_f16String.FieldName = "f16String"
        gcCol08_f20String.FieldName = "f20String"
        gcCol09_f22String.FieldName = "f22String"
        gcCol10_Berat.FieldName = "Berat"
        gcCol11_HargaBarcode.FieldName = "HargaBarcode"
        gcCol12_ImgProduct.FieldName = "ImgProduct"

        ' setting tinggi gambar
        rpgcCol12_ImgProduct.CustomHeight = 65
        rpgcCol12_ImgProduct.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Squeeze
    End Sub
    Private Sub cm03Getdata()
        Me.Cursor = Cursors.WaitCursor

        pdtReport.Clear()
        ' spBRJKatalog
        Using objGet As clsSUPPORTCENTER_iface = New clsSUPPORTCENTER_impl
            pdtReport = objGet.selectNoparam("spBRJKatalog")
        End Using

        If pdtReport.Rows.Count > 0 Then

            'PivotGridControl1.DataSource = Nothing
            'PivotGridControl1.DataSource = pdtReport
            'PivotGridControl1.RefreshData()
            'PivotGridControl1.BestFit()

            GridControl1.DataSource = Nothing
            GridControl1.DataSource = pdtReport
            GridControl1.RefreshDataSource()
            ' GridView1.BestFitColumns()

        Else

            'Dim Pesan As String = " Maaf " & propGlobal._02cNamaUser & vbNewLine &
            '    " Tidak ada Yang Di Temukan pada Periode " & _01TglAwal.Text & " S/d " & _02TglAkhir.Text

            'XtraMessageBox.Show(Pesan, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question, DefaultBoolean.True)

        End If

        Me.Cursor = Cursors.Default

    End Sub


    'Private Sub cm04FilterData()

    '    Dim prmDataToday As DateTime = Date.Now
    '    Dim prmTglAwal As Date
    '    Dim prmTglAkhir As Date

    '    If ocFilter.CheckState = CheckState.Checked Then
    '        isFilterData = True

    '        prmTglAwal = New DateTime(prmDataToday.Year, prmDataToday.Month, 1)
    '        prmTglAkhir = prmTglAwal.AddMonths(1).AddDays(-1)

    '        Lyt_01TglAwal.Enabled = True
    '        Lyt_02TglAkhir.Enabled = True

    '    Else
    '        isFilterData = False
    '        prmTglAwal = Date.Now
    '        prmTglAkhir = Date.Now

    '        Lyt_01TglAwal.Enabled = False
    '        Lyt_02TglAkhir.Enabled = False
    '    End If

    '    _01TglAwal.EditValue = prmTglAwal
    '    _02TglAkhir.EditValue = prmTglAkhir

    'End Sub
    'Private Function cm05Validasi()
    '    Dim isValid As Boolean = True
    '    Dim prmMsg As String = ""

    '    If _01TglAwal.EditValue > _02TglAkhir.EditValue Then
    '        isValid = False
    '        prmMsg = " Masukan Tgl Dengan Benar Tgl Awal > Tgl Akhir"
    '    Else
    '        If _02TglAkhir.EditValue < _01TglAwal.EditValue Then
    '            isValid = False
    '            prmMsg = " Masukan Tgl Dengan Benar Tgl Akhir < Tgl Awal "
    '        Else
    '            If _01TglAwal.EditValue Is Nothing AndAlso _02TglAkhir.EditValue Is Nothing Then
    '                isValid = False
    '                prmMsg = " Tgl Awal & AKhir Tidak Boleh Kosong "
    '            End If
    '        End If
    '    End If

    '    If Not isValid Then
    '        XtraMessageBox.Show(prmMsg, "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question, DefaultBoolean.True)
    '    End If

    '    Return isValid

    'End Function

#End Region

#Region "Control Event"

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        cm03Getdata()
    End Sub



#End Region
End Class
