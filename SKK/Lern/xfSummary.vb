'*** GENERATE FROM CASE 2022 *** 
'===============================
'INFORMATION  
'Author : Maulana SH 
'VISUAL STUDIo Version : 2022  
'Devexpress Version : V21.2.5  
'******************************* 
Imports DevExpress.PivotGrid.DataBinding
Imports DevExpress.XtraGrid
Imports DevExpress.XtraPivotGrid

Public Class xfSummary

    Private pdtMaster52Produksi As DataTable
    Private pdtSUmmarry As DataTable
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        pdtMaster52Produksi = New DataTable
        pdtSUmmarry = New DataTable
    End Sub

#Region "From Event"

    Private Sub xfSummary_Load(sender As Object, e As EventArgs) Handles Me.Load


        cm01InitControl()
        cm02InitField()
    End Sub

#End Region

#Region "Custome Methods"

    Private Sub cm01InitControl()

        pdtMaster52Produksi.Clear()

        Using ObjGetMaster As NCMODELlib.clsNEWCENTRAL_iface = New NCMODELlib.clsNEWCENTRAL_impl With {.prop_01cTarget = 1, .prop_02cUserID = "ARIS"}
            pdtMaster52Produksi = ObjGetMaster.Sele52AllProsesProduksi
        End Using

        With _02IDProses
            ._01prop_dt52ProsesProduksi = pdtMaster52Produksi
            ._02BindingAwalDataSurce()
        End With

        _01TglStock.EditValue = Date.Today


    End Sub

    Private Sub cm02InitField()
        '*** Pivot Field ***
        pcCol01_k01dTglStock.FieldName = "k01dTglStock"
        pcCol02_k02nNoUrutWIP_int.FieldName = "k02nNoUrutWIP_int"
        pcCol03_k03cIdProsesWIP_v50.FieldName = "k03cIdProsesWIP_v50"
        pcCol04_f01cSKU_v50.FieldName = "f01cSKU_v50"
        pcCol05_f02nNourutINOUT.FieldName = "f02nNourutINOUT"
        pcCol06_f03cIdProsesINOUT_v50.FieldName = "f03cIdProsesINOUT_v50"
        pcCol07_f04cNamaPRosesInOut_v50.FieldName = "f04cNamaPRosesInOut_v50"
        pcCol08_f05nPCSINOUT_int.FieldName = "f05nPCSINOUT_int"
        pcCol09_f06nGrossINOUT_n93.FieldName = "f06nGrossINOUT_n93"
        pcCol10_f07nButirCZINOUT_int.FieldName = "f07nButirCZINOUT_int"
        pcCol11_f08nGramCZINOUT_n93.FieldName = "f08nGramCZINOUT_n93"
        pcCol12_f09nWNettINOUT_n93.FieldName = "f09nWNettINOUT_n93"
        pcCol13_f10cGROUP_DATA.FieldName = "f10cGROUP_DATA"
        pcCol14_f11nNourutData_int.FieldName = "f11nNourutData_int"
        pcCol15_f12cKadarSpk_v50.FieldName = "f12cKadarSpk_v50"
        pcCol16_f13cGROUPTypeData.FieldName = "f13cGROUPTypeData"
        '*** Pivot Field ***
        gcCol01_k01dTglStock.FieldName = "k01dTglStock"
        gcCol02_k02nNoUrutWIP_int.FieldName = "k02nNoUrutWIP_int"
        gcCol03_k03cIdProsesWIP_v50.FieldName = "k03cIdProsesWIP_v50"
        gcCol04_f01cSKU_v50.FieldName = "f01cSKU_v50"
        gcCol05_f02nNourutINOUT.FieldName = "f02nNourutINOUT"
        gcCol06_f03cIdProsesINOUT_v50.FieldName = "f03cIdProsesINOUT_v50"
        gcCol07_f04cNamaPRosesInOut_v50.FieldName = "f04cNamaPRosesInOut_v50"
        gcCol08_f05nPCSINOUT_int.FieldName = "f05nPCSINOUT_int"
        gcCol09_f06nGrossINOUT_n93.FieldName = "f06nGrossINOUT_n93"
        gcCol10_f07nButirCZINOUT_int.FieldName = "f07nButirCZINOUT_int"
        gcCol11_f08nGramCZINOUT_n93.FieldName = "f08nGramCZINOUT_n93"
        gcCol12_f09nWNettINOUT_n93.FieldName = "f09nWNettINOUT_n93"
        gcCol13_f10cGROUP_DATA.FieldName = "f10cGROUP_DATA"
        gcCol14_f11nNourutData_int.FieldName = "f11nNourutData_int"
        gcCol15_f12cKadarSpk_v50.FieldName = "f12cKadarSpk_v50"
        gcCol16_f13cGROUPTypeData.FieldName = "f13cGROUPTypeData"


        'gcCol08_f05nPCSINOUT_int
        'gcCol09_f06nGrossINOUT_n93
        'gcCol10_f07nButirCZINOUT_int
        'gcCol11_f08nGramCZINOUT_n93
        'gcCol12_f09nWNettINOUT_n93
        ' Untuk Custom Summary
        'gcCol08_f05nPCSINOUT_int.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'gcCol08_f05nPCSINOUT_int.SummaryItem.FieldName = "f05nPCSINOUT_int"
        'gcCol08_f05nPCSINOUT_int.SummaryItem.DisplayFormat = "{0:n0}"

        'gcCol09_f06nGrossINOUT_n93.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'gcCol09_f06nGrossINOUT_n93.SummaryItem.FieldName = "f06nGrossINOUT_n93"
        'gcCol09_f06nGrossINOUT_n93.SummaryItem.DisplayFormat = "{0:n2}"

        'gcCol10_f07nButirCZINOUT_int.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'gcCol10_f07nButirCZINOUT_int.SummaryItem.FieldName = "f07nButirCZINOUT_int"
        'gcCol10_f07nButirCZINOUT_int.SummaryItem.DisplayFormat = "{0:n0}"

        'gcCol11_f08nGramCZINOUT_n93.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'gcCol11_f08nGramCZINOUT_n93.SummaryItem.FieldName = "f08nGramCZINOUT_n93"
        'gcCol11_f08nGramCZINOUT_n93.SummaryItem.DisplayFormat = "{0:n3}"

        'gcCol12_f09nWNettINOUT_n93.SummaryItem.SummaryType = DevExpress.Data.SummaryItemType.Sum
        'gcCol12_f09nWNettINOUT_n93.SummaryItem.FieldName = "f09nWNettINOUT_n93"
        'gcCol12_f09nWNettINOUT_n93.SummaryItem.DisplayFormat = "{0:n2}"

        Dim itemPCSGsumary As New GridGroupSummaryItem
        With itemPCSGsumary
            .FieldName = "f05nPCSINOUT_int"
            .ShowInGroupColumnFooter = GridView1.Columns("f05nPCSINOUT_int")
            .SummaryType = DevExpress.Data.SummaryItemType.Sum
            .DisplayFormat = "{0:n0}"
        End With
        GridView1.GroupSummary.Add(itemPCSGsumary)

        Dim itemGrossGsumary As New GridGroupSummaryItem
        With itemGrossGsumary
            .FieldName = "f06nGrossINOUT_n93"
            .ShowInGroupColumnFooter = GridView1.Columns("f06nGrossINOUT_n93")
            .SummaryType = DevExpress.Data.SummaryItemType.Sum
            .DisplayFormat = "{0:n2}"
        End With
        GridView1.GroupSummary.Add(itemGrossGsumary)

        Dim itemButirCZGsumary As New GridGroupSummaryItem
        With itemButirCZGsumary
            .FieldName = "f07nButirCZINOUT_int"
            .ShowInGroupColumnFooter = GridView1.Columns("f07nButirCZINOUT_int")
            .SummaryType = DevExpress.Data.SummaryItemType.Sum
            .DisplayFormat = "{0:n0}"
        End With
        GridView1.GroupSummary.Add(itemButirCZGsumary)

        Dim itemWCZGsumary As New GridGroupSummaryItem
        With itemWCZGsumary
            .FieldName = "f08nGramCZINOUT_n93"
            .ShowInGroupColumnFooter = GridView1.Columns("f08nGramCZINOUT_n93")
            .SummaryType = DevExpress.Data.SummaryItemType.Sum
            .DisplayFormat = "{0:n3}"
        End With
        GridView1.GroupSummary.Add(itemWCZGsumary)

        Dim itemWNettGsumary As New GridGroupSummaryItem
        With itemWNettGsumary
            .FieldName = "f09nWNettINOUT_n93"
            .ShowInGroupColumnFooter = GridView1.Columns("f09nWNettINOUT_n93")
            .SummaryType = DevExpress.Data.SummaryItemType.Sum
            .DisplayFormat = "{0:n2}"
        End With
        GridView1.GroupSummary.Add(itemWNettGsumary)

    End Sub

    Private Sub cm03GetData()
        Me.Cursor = Cursors.WaitCursor
        pdtSUmmarry.Clear()

        Using ObjGetMaster As NCMODELlib.clsNEWCENTRAL_iface = New NCMODELlib.clsNEWCENTRAL_impl With {.prop_dTglAwal = _01TglStock.EditValue,
                                                                                                    .prop_k03cIDProsesProduksi_v50 = _02IDProses.EditValue}
            pdtSUmmarry = ObjGetMaster.SeleTetsing
        End Using

        PivotGridControl1.DataSource = Nothing
        PivotGridControl1.DataSource = pdtSUmmarry
        PivotGridControl1.RefreshData()

        GridControl1.DataSource = Nothing
        GridControl1.DataSource = pdtSUmmarry
        GridControl1.RefreshDataSource()

        Me.Cursor = Cursors.Default
    End Sub

#End Region

#Region "Control Event"


    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        cm03GetData()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        PivotGridControl1.ShowPrintPreview()
    End Sub

    Private Sub PivotGridControl1_CustomAppearance(sender As Object, e As PivotCustomAppearanceEventArgs) Handles PivotGridControl1.CustomAppearance

        'If e.DataField Is pcCol09_f06nGrossINOUT_n93 Then

        '    Dim groupData As String = e.GetFieldValue(pcCol13_f10cGROUP_DATA).ToString()
        '    Dim beratGross As Double = e.Value

        '    If groupData = "DATA-SELISIH" AndAlso beratGross <> 0 Then
        '        e.Appearance.ForeColor = Color.Red
        '    End If

        'End If

        ' If e.DataField Is pcCol09_f06nGrossINOUT_n93 And e.ColumnValueType = PivotGridValueType.Value And e.RowValueType = PivotGridValueType.Value Then
        If e.ColumnValueType = PivotGridValueType.Value And e.RowValueType = PivotGridValueType.Value Then
            Dim groupData As String = CType(e.GetFieldValue(pcCol13_f10cGROUP_DATA), String) 'e.GetFieldValue(pcCol13_f10cGROUP_DATA).ToString()
            Dim cKadarStok As String = e.GetFieldValue(pcCol15_f12cKadarSpk_v50).ToString()

            If groupData = "SELISIH" Then
                If Not e.Value Is Nothing And Convert.ToDecimal(e.Value) <> 0.00 Then
                    e.Appearance.BackColor = Color.MistyRose
                    e.Appearance.ForeColor = Color.DarkRed
                    e.Appearance.FontStyleDelta = FontStyle.Italic
                End If
            End If

            ''Setting warna by kadar'
            'Select Case cKadarStok
            '    Case "34.00%"
            '        e.Appearance.BackColor = Color.Khaki
            '        e.Appearance.ForeColor = Color.Black
            '        'Case "37.50%"
            '        '    e.Appearance.BackColor = Color.MistyRose
            '        '    e.Appearance.ForeColor = Color.DarkRed
            '        'Case "67.10%"
            '        '    e.Appearance.BackColor = Color.MistyRose
            '        '    e.Appearance.ForeColor = Color.DarkRed
            '        'Case "75.50%"
            '        '    e.Appearance.BackColor = Color.MistyRose
            '        '    e.Appearance.ForeColor = Color.DarkRed
            'End Select

        End If

    End Sub

#End Region
End Class
