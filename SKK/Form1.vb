
Imports NCVIEWMRPlib
Imports NCCORElib
Imports NCMODELlib
Imports NCCONTROLLERlib

Public Class Form1

    Private reprintTD As clsReprintTD

#Region " Button Event"

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        Dim pdDataMaster As New DataTable
        Using objSKKMaster As clsMRP_iface = New clsMRP_impl With {.prop_KeyString01 = ""}
            pdDataMaster = objSKKMaster.Sele21MCRAWMATERIAL()
        End Using

        Dim objformRawMaterial As New NCVIEWMRPlib.uc01GridRawMaterial With {.Dock = DockStyle.Fill,
            .prop_02dt21MCRAWMATERIAL = pdDataMaster
        }
        Dim frmrawmaterial As New DevExpress.XtraEditors.XtraForm With {
                                                                          .Text = "RAW MATERIAL",
                                                                          .WindowState = FormWindowState.Maximized
                                                                         }

        frmrawmaterial.Controls.Add(objformRawMaterial)
        frmrawmaterial.Show()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click

        Dim pdDataMaster As New DataTable
        Using objSKKMaster As clsMRP_iface = New clsMRP_impl With {.prop_KeyString01 = ""}
            pdDataMaster = objSKKMaster.Sele22MCFINDINGCOMPONENT()
        End Using

        Dim objformFC As New NCVIEWMRPlib.uc02GridFindingComponent With {.Dock = DockStyle.Fill,
                                                                                .prop_01dt22MCFINDINGCOMPONENT = pdDataMaster
                                                                               }
        Dim frmFC As New DevExpress.XtraEditors.XtraForm With {
                                                                          .Text = "FINDING COMPONENT",
                                                                          .WindowState = FormWindowState.Maximized
                                                                         }

        frmFC.Controls.Add(objformFC)
        frmFC.Show()
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click

        Dim pdDataMaster As New DataTable
        Using objSKKMaster As clsMRP_iface = New clsMRP_impl With {.prop_KeyString01 = ""}
            pdDataMaster = objSKKMaster.Sele23MCSTONES()
        End Using

        Dim objformStones As New NCVIEWMRPlib.uc03GridMasterStone With {.Dock = DockStyle.Fill,
                                                                                .prop_01dt23MCSTONES = pdDataMaster
                                                                               }
        Dim frmstone As New DevExpress.XtraEditors.XtraForm With {
                                                                          .Text = "Stone",
                                                                          .WindowState = FormWindowState.Maximized
                                                                         }

        frmstone.Controls.Add(objformStones)
        frmstone.Show()

    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click

        Dim pdDataMaster As New DataTable
        Using objSKKMaster As clsMRP_iface = New clsMRP_impl With {.prop_KeyInt01 = 1,
                                                                   .prop_KeyString01 = "",
                                                                   .prop_KeyString02 = ""}
            pdDataMaster = objSKKMaster.Sele32PRODUCT()
        End Using

        Dim objformProduct As New NCVIEWMRPlib.uc06GridProduct With {.Dock = DockStyle.Fill,
                                                                  .prop_01dt32PRODUCT = pdDataMaster
                                                                 }
        Dim frmproduct As New DevExpress.XtraEditors.XtraForm With {
                                                                  .Text = "Product",
                                                                 .WindowState = FormWindowState.Maximized
                                                                 }

        frmproduct.Controls.Add(objformProduct)
        frmproduct.Show()

    End Sub

    Private Sub SimpleButton5_Click(sender As Object, e As EventArgs) Handles SimpleButton5.Click

        Dim pdDataMaster25 As New DataTable
        Dim pdDataMaster26 As New DataTable
        Dim pdDataMaster27 As New DataTable
        If _col01txtFGCode.EditValue <> "" Then
            Dim FGCODE As String
            FGCODE = _col01txtFGCode.EditValue

            'get t25
            Using objSKKMaster25 As clsMRP_iface = New clsMRP_impl With {.prop_KeyString01 = FGCODE,
                                                                   .prop_KeyString02 = "",
                                                                   .prop_KeyString03 = "",
                                                                   .prop_KeyString04 = ""}
                pdDataMaster25 = objSKKMaster25.Sele25BOMCASTEDPARTS()
            End Using

            'get t26
            Using objSKKMaster26 As clsMRP_iface = New clsMRP_impl With {.prop_KeyString01 = FGCODE,
                                                                   .prop_KeyString02 = "",
                                                                   .prop_KeyString03 = ""}
                pdDataMaster26 = objSKKMaster26.Sele26BOMFINDINGCOMPONENT()
            End Using


            'get t27
            Using objSKKMaster27 As clsMRP_iface = New clsMRP_impl With {.prop_KeyString01 = FGCODE,
                                                                   .prop_KeyString02 = "",
                                                                   .prop_KeyString03 = ""}
                pdDataMaster27 = objSKKMaster27.Sele27BOMSTONES()
            End Using

            Dim objformBOM As New NCVIEWMRPlib.uc04GridBOMMasterDetail With {.Dock = DockStyle.Fill,
                                                                  .prop_01dt25BOMCASTEDPARTS = pdDataMaster25,
                                                                  .prop_02dt26BOMFINDINGCOMPONENT = pdDataMaster26,
                                                                  .prop_03dt27BOMSTONES = pdDataMaster27
                                                                 }
            Dim frmbom As New DevExpress.XtraEditors.XtraForm With {
                                                                      .Text = "BOM",
                                                                     .WindowState = FormWindowState.Maximized
                                                                     }

            frmbom.Controls.Add(objformBOM)
            frmbom.Show()


        Else
            MsgBox("masukan FGCOde nya dulu")
        End If
    End Sub

    Private Sub SimpleButton6_Click(sender As Object, e As EventArgs) Handles SimpleButton6.Click

        Dim pdDataMaster30 As New DataTable
        Dim pdDataMaster31 As New DataTable
        'get30
        Using ObjSKKMaster As clsMRP_iface = New clsMRP_impl With {.prop_KeyString01 = ""}
            pdDataMaster30 = ObjSKKMaster.Sele30DESIGNMASTER()
        End Using

        'get31
        Using ObjSKKMaster31 As clsMRP_iface = New clsMRP_impl With {.prop_KeyString01 = ""}
            pdDataMaster31 = ObjSKKMaster31.Sele31DESIGNMASTERSTONE()
        End Using

        Dim objformMasterStones As New NCVIEWMRPlib.uc05GridDesignMasterStoneDetail With {.Dock = DockStyle.Fill,
                                                                                          ._04prop_t30DESIGNMASTER = pdDataMaster30,
                                                                                          ._05prop_t31DESIGNMASTERSTONE = pdDataMaster31}

        Dim formMasterStones As New DevExpress.XtraEditors.XtraForm With {.Text = "DESIGN MASTER STONES",
                                                                           .WindowState = FormWindowState.Maximized}

        formMasterStones.Controls.Add(objformMasterStones)
        formMasterStones.Show()


    End Sub

    Private Sub SimpleButton7_Click(sender As Object, e As EventArgs) Handles SimpleButton7.Click

        Dim pdDataMaster As New DataTable
        'get30
        Using ObjSKKMaster As clsMRP_iface = New clsMRP_impl With {.prop_KeyInt01 = 2,
                                                                   .prop_KeyString01 = "",
                                                                   .prop_KeyString02 = ""}
            pdDataMaster = ObjSKKMaster.GetGambarMRP()
        End Using


        Dim objformGAMBAR As New NCVIEWMRPlib.frmMultipleGambar With {.Dock = DockStyle.Fill,
                                                                             .prop_01dtGambar = pdDataMaster,
                                                                             .prop_02cDataGUIDGambar = "5A97EF16-52DE-4B05-8CB6-00283E959483"
                                                                             }

        objformGAMBAR.WindowState = FormWindowState.Maximized
        objformGAMBAR.Show()

    End Sub

    Private Sub SimpleButton8_Click(sender As Object, e As EventArgs) Handles SimpleButton8.Click

        'Dim objformMenu As New NCVIEWMRPlib.ucMenu With {.Dock = DockStyle.Fill}
        'Dim formMenu As New DevExpress.XtraEditors.XtraForm With {.Text = "APP NAME",
        '                                                                   .WindowState = FormWindowState.Maximized}
        'formMenu.Controls.Add(objformMenu)
        'formMenu.Show()

        Dim objformMenu As New uc26XScroolBars With {.Dock = DockStyle.Fill}
        Dim formMenu As New DevExpress.XtraEditors.XtraForm With {.Text = "APP NAME",
                                                                           .WindowState = FormWindowState.Maximized}
        formMenu.Controls.Add(objformMenu)
        formMenu.Show()
    End Sub

    Private Sub SimpleButton9_Click(sender As Object, e As EventArgs) Handles SimpleButton9.Click

        'Dim objReportGT As New NCVIEWMRPlib.ReportTecknicalDrawing

        'With objReportGT

        '    ._01prop_ProdcutCode = "PRO0011"
        '    ._02prop_IMG_SP = My.Resources.CN21
        '    ._03prop_IMG_As = My.Resources.DM
        'End With

        'objReportGT.Margins = New Margins(25, 25, 25, 25)
        'objReportGT.PaperKind = PaperKind.A4
        'objReportGT.ShowPreview

        If _productCode.EditValue <> "" Then

            With reprintTD
                .prop01_ProductCode = _productCode.EditValue
                ._02DisplayPreview()
            End With
        End If

    End Sub

    Private Sub SimpleButton10_Click(sender As Object, e As EventArgs) Handles SimpleButton10.Click




    End Sub

#End Region

#Region "Costum Methods"

    Public Sub _cm01InitGridLookupEdit()
        Dim getMaster51 As DataTable
        Using objSKKMaster As clsMRP_iface = New clsMRP_impl
            getMaster51 = objSKKMaster.Get51MasterAllNewSKK()
        End Using

        With _glTes
            .Properties.ValueMember = "k01cKodeFieldValueMaster_v50"
            .Properties.DisplayMember = "f01cIsiFieldValueMaster_v50"
            .Properties.DataSource = getMaster51
        End With

        With _02Enamel
            ._01prop_dtMasterSKK = getMaster51
            ._02prop_FilterKodeMasterSKK = "ENAMEL"
            ._03Prop_IsEnamelMaster = True
            ._03BindingAwalDataSurce()
            ._04FilterDataViewMasterSKK()
        End With

    End Sub


    Private Function cm18CalculaterToleransi()

        ' *** Total By DO (Timbang abrukan) 
        Dim prmTotalBeratLOT As Double = _02WFG.EditValue '_03WGross.EditValue

        ' *** TImbang Per PCs (Satuan)
        Dim prmTotalBeratPerPCS As Double = _04WInbound.EditValue ' GridView1.Columns("f01Double").SummaryItem.SummaryValue

        Dim prmTotalPcs As Integer = _01Lot.EditValue 'GridView1.RowCount
        Dim prmBeratChain As Double = _03WChain.EditValue '_28Toleransi.EditValue
        Dim prmToleransiPerPcs As Double = _06Toleransi.EditValue '_28Toleransi.EditValue

        Dim isToleransi As Boolean
        Dim prmToleransi As Decimal = 0.0 ' totalPCS x 0.005
        Dim prmToleransiAtas As Decimal = 0.0 ' totalBEratPerpcs +  prmToleransi
        Dim prmToleransiBawah As Decimal = 0.0 ' TotalBeratLot - prmToleransi

        '' BATAS ATAS
        prmToleransi = (prmTotalPcs * prmToleransiPerPcs)
        prmToleransiBawah = If(prmBeratChain > 0, prmTotalBeratLOT + prmBeratChain, prmTotalBeratLOT) - prmToleransi
        ' prmToleransiAtas = prmTotalBeratPerPCS + prmToleransi
        prmToleransiAtas = If(prmBeratChain > 0, prmTotalBeratLOT + prmBeratChain, prmTotalBeratLOT) + prmToleransi

        If prmTotalBeratPerPCS >= prmToleransiBawah AndAlso prmTotalBeratPerPCS <= prmToleransiAtas Then
            isToleransi = True
        Else
            isToleransi = False
        End If

        Return isToleransi
    End Function

    Private Sub cm14CalculateSelisih()
        ' *** Calulate selisih
        Dim prmTotalInbound As Double = _04WInbound.EditValue 'GridView1.Columns("f01Double").SummaryItem.SummaryValue

        'If _29BeratChain.EditValue > 0 Then
        '    _23SelisihGross.EditValue = (_03WGross.EditValue + _29BeratChain.EditValue) - prmTotalInbound
        'Else
        '    _23SelisihGross.EditValue = _03WGross.EditValue - prmTotalInbound
        'End If

        If _03WChain.EditValue > 0 Then
            _05SelesihInbound.EditValue = (_02WFG.EditValue + _03WChain.EditValue) - prmTotalInbound
        Else
            _05SelesihInbound.EditValue = _02WFG.EditValue - prmTotalInbound
        End If

    End Sub

#End Region

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        reprintTD = New clsReprintTD

        'Dim getMaster51 As DataTable
        'Using objSKKMaster As clsMRP_iface = New clsMRP_impl
        '    getMaster51 = objSKKMaster.Get51MasterAllNewSKK()
        'End Using


        ''NECKLACESSIZE
        ''RINGSIZES
        ''WOMENBANGLESIZES
        ''WOMENBRACELETS
        ''MENBRACELETS
        ''CHILDBRACELETS

        'With sizeAll
        '    ._01prop_dtMasterSKK = getMaster51
        '    ._02prop_FilterKodeMasterSKK = "'NECKLACESSIZE','RINGSIZES','WOMENBANGLESIZES'"
        '    ._03BindingAwalDataSurce()
        '    ._04SizeAll()
        'End With


        _cm01InitGridLookupEdit()
    End Sub

    Private Sub SimpleButton11_Click(sender As Object, e As EventArgs) Handles SimpleButton11.Click
        Dim MsgErr As String
        If Not cm18CalculaterToleransi() Then
            Dim totalPCS As Decimal = _01Lot.EditValue * _06Toleransi.EditValue 'GridView1.RowCount * _28Toleransi.EditValue

            MsgErr = "Toleransi Berat (±) " & totalPCS.ToString("N3")
        Else
            MsgErr = "Simpan Data"
        End If

        MsgBox(MsgErr)

    End Sub

    Private Sub _04WInbound_EditValueChanged(sender As Object, e As EventArgs) Handles _04WInbound.EditValueChanged
        cm14CalculateSelisih()
    End Sub
End Class
