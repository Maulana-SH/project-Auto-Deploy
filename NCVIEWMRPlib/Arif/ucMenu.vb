Imports NCMODELlib

Public Class ucMenu

    Public Property _01Prop_UserID As String
    Public Property _02Prop_NamaUser As String

    'class conettor 35entry
    Private cls35JC As cls35JOBCARD

    Private Sub DesignMasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesignMasterToolStripMenuItem.Click

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

        Dim objuc As New uc05GridDesignMasterStoneDetail With {.Dock = DockStyle.Fill,
                                                               ._04prop_t30DESIGNMASTER = pdDataMaster30,
                                                               ._05prop_t31DESIGNMASTERSTONE = pdDataMaster31}

        pnlRoot.Visible = True
        _lblCaption.Text = "DESIGN MASTER"
        pnlContent.Controls.Clear()
        pnlContent.Controls.Add(objuc)
    End Sub

    Private Sub ucMenu_Load(sender As Object, e As EventArgs) Handles Me.Load

        'cls35JC = New cls35JOBCARD

        _lytContronBackground.AppearanceGroup.BackColor = ColorTranslator.FromHtml("#a4acc4")

        With pnlRoot
            '.BackColor = ColorTranslator.FromHtml("#f5cc84")
            '_lblCaption.AppearanceItemCaption.ForeColor = Color.Black

            .BackColor = ColorTranslator.FromHtml("#3b4f81")
            _lblCaption.AppearanceItemCaption.ForeColor = Color.White

        End With
    End Sub

    Private Sub FindingComponentToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FindingComponentToolStripMenuItem.Click


        Dim pdDataMaster As New DataTable
        Using objSKKMaster As clsMRP_iface = New clsMRP_impl With {.prop_KeyString01 = ""}
            pdDataMaster = objSKKMaster.Sele22MCFINDINGCOMPONENT()
        End Using

        Dim objuc As New uc02GridFindingComponent With {
            .Dock = DockStyle.Fill,
            .prop_01dt22MCFINDINGCOMPONENT = pdDataMaster
        }

        pnlRoot.Visible = True
        _lblCaption.Text = "FINDING COMPONENT"
        pnlContent.Controls.Clear()
        pnlContent.Controls.Add(objuc)
    End Sub

    Private Sub RawMaterialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RawMaterialToolStripMenuItem.Click

        Dim pdDataMaster As New DataTable
        Using objSKKMaster As clsMRP_iface = New clsMRP_impl With {.prop_KeyString01 = ""}
            pdDataMaster = objSKKMaster.Sele21MCRAWMATERIAL()
        End Using

        Dim objuc As New uc01GridRawMaterial With {
            .Dock = DockStyle.Fill,
            .prop_02dt21MCRAWMATERIAL = pdDataMaster
        }

        pnlRoot.Visible = True
        _lblCaption.Text = "RAW MATERIAL"
        pnlContent.Controls.Clear()
        pnlContent.Controls.Add(objuc)
    End Sub

    Private Sub StoneMasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StoneMasterToolStripMenuItem.Click

        Dim pdDataMaster As New DataTable
        Using objSKKMaster As clsMRP_iface = New clsMRP_impl With {.prop_KeyString01 = ""}
            pdDataMaster = objSKKMaster.Sele23MCSTONES()
        End Using

        Dim objuc As New uc03GridMasterStone With {
            .Dock = DockStyle.Fill,
          .prop_01dt23MCSTONES = pdDataMaster
           }
        pnlRoot.Visible = True
        _lblCaption.Text = "STONE MASTER"
        pnlContent.Controls.Clear()
        pnlContent.Controls.Add(objuc)
    End Sub

    Private Sub ProductToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProductToolStripMenuItem.Click

        Dim pdDataMaster As New DataTable
        Using objSKKMaster As clsMRP_iface = New clsMRP_impl With {.prop_KeyInt01 = 1,
                                                                   .prop_KeyString01 = "",
                                                                   .prop_KeyString02 = ""}
            pdDataMaster = objSKKMaster.Sele32PRODUCT()
        End Using

        Dim objuc As New uc06GridProduct With {.Dock = DockStyle.Fill,
                                                .prop_01dt32PRODUCT = pdDataMaster
                                              }

        pnlRoot.Visible = True
        _lblCaption.Text = "PRODUCT"
        pnlContent.Controls.Clear()
        pnlContent.Controls.Add(objuc)
    End Sub

    Private Sub BIllOfMaterialToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BIllOfMaterialToolStripMenuItem.Click
        Dim pdDataMaster25 As New DataTable
        Dim pdDataMaster26 As New DataTable
        Dim pdDataMaster27 As New DataTable


        'get t25
        Using objSKKMaster25 As clsMRP_iface = New clsMRP_impl With {.prop_KeyString01 = "",
                                                                   .prop_KeyString02 = "",
                                                                   .prop_KeyString03 = "",
                                                                   .prop_KeyString04 = ""}
            pdDataMaster25 = objSKKMaster25.Sele25BOMCASTEDPARTS()
        End Using

        'get t26
        Using objSKKMaster26 As clsMRP_iface = New clsMRP_impl With {.prop_KeyString01 = "",
                                                                   .prop_KeyString02 = "",
                                                                   .prop_KeyString03 = ""}
            pdDataMaster26 = objSKKMaster26.Sele26BOMFINDINGCOMPONENT()
        End Using


        'get t27
        Using objSKKMaster27 As clsMRP_iface = New clsMRP_impl With {.prop_KeyString01 = "",
                                                                   .prop_KeyString02 = "",
                                                                   .prop_KeyString03 = ""}
            pdDataMaster27 = objSKKMaster27.Sele27BOMSTONES()
        End Using

        Dim objuc As New uc04GridBOMMasterDetail With {.Dock = DockStyle.Fill,
                                                              .prop_01dt25BOMCASTEDPARTS = pdDataMaster25,
                                                              .prop_02dt26BOMFINDINGCOMPONENT = pdDataMaster26,
                                                              .prop_03dt27BOMSTONES = pdDataMaster27
                                                             }
        pnlRoot.Visible = True
        _lblCaption.Text = "BILL OF MATERIAL"
        pnlContent.Controls.Clear()
        pnlContent.Controls.Add(objuc)
    End Sub

    Private Sub BOMToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BOMToolStripMenuItem.Click

        'Dim pdDataMaster20 As New DataTable
        'Dim pdDataMaster25 As New DataTable
        'Dim pdDataMaster26 As New DataTable
        'Dim pdDataMaster27 As New DataTable
        'Dim pdDataMaster32 As New DataTable

        ''get t32Prodcut
        'Using objMastert32 As clsMRP_iface = New clsMRP_impl With {
        '      .prop_KeyInt01 = 1,
        '      .prop_KeyString01 = "",
        '      .prop_KeyString02 = ""
        '    }
        '    pdDataMaster32 = objMastert32.Sele32PRODUCT
        'End Using

        ''get t20MasterRouting
        'Using objSKKMaster20 As clsMRP_iface = New clsMRP_impl With {
        '      .prop_KeyString01 = "",
        '      .prop_KeyString02 = ""
        '    }
        '    pdDataMaster20 = objSKKMaster20.Sele20MASTERROUTING
        'End Using

        ''get t25
        'Using objSKKMaster25 As clsMRP_iface = New clsMRP_impl With {
        '      .prop_KeyString01 = "",
        '      .prop_KeyString02 = "",
        '      .prop_KeyString03 = "",
        '      .prop_KeyString04 = ""
        '    }
        '    pdDataMaster25 = objSKKMaster25.Sele25BOMCASTEDPARTS()
        'End Using

        ''get t26
        'Using objSKKMaster26 As clsMRP_iface = New clsMRP_impl With {
        '      .prop_KeyString01 = "",
        '      .prop_KeyString02 = "",
        '      .prop_KeyString03 = ""
        '    }
        '    pdDataMaster26 = objSKKMaster26.Sele26BOMFINDINGCOMPONENT
        'End Using

        ''get t27
        'Using objSKKMaster27 As clsMRP_iface = New clsMRP_impl With {
        '      .prop_KeyString01 = "",
        '      .prop_KeyString02 = "",
        '      .prop_KeyString03 = ""
        '    }
        '    pdDataMaster27 = objSKKMaster27.Sele27BOMSTONES
        'End Using

        'Dim objuc As New ucGridReprintBOM With {
        '    .Dock = DockStyle.Fill,
        '    ._01prop_t32Product = pdDataMaster32,
        '    ._02prop_t25BOMCASTEDPARTS = pdDataMaster25,
        '    ._03prop_t26BOMFINDINGCOMPONENT = pdDataMaster26,
        '    ._04prop_t27BOMSTONES = pdDataMaster27,
        '    ._05prop_t20MASTERROUTING = pdDataMaster20
        '}

        Dim objuc As New ucGridReprintBOM

        With objuc
            .Dock = DockStyle.Fill
            .prop_gcUserID_v50 = _01Prop_UserID
            .prop_gcNamaUser_v50 = _02Prop_NamaUser
            ._cm01GetDataSource()
        End With

        pnlRoot.Visible = True
        _lblCaption.Text = "BILL OF MATERIAL"
        pnlContent.Controls.Clear()
        pnlContent.Controls.Add(objuc)
    End Sub

    Private Sub _btnClose_Click(sender As Object, e As EventArgs) Handles _btnClose.Click
        pnlContent.Controls.Clear()
        pnlRoot.Visible = False
    End Sub


    Private Sub PRODUCTIONORDERToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PRODUCTIONORDERToolStripMenuItem.Click

        'Dim pdDataMaster24 As New DataTable
        Dim pdDataMaster2122MasterBOMforPRO As New DataTable
        Dim pdDataMaster28BOMFCI As New DataTable
        Dim pdDataMaster28COREPRO As New DataTable
        Dim pdDataMaster29 As New DataTable

        'get t2122MasterMaterialBOMforPRO
        Using objMaster2122 As clsMRP_iface = New clsMRP_impl
            pdDataMaster2122MasterBOMforPRO = objMaster2122.Get2122MaterialBOMForPRO
        End Using

        'get t28cORE PRO
        Using objSKKMaster28 As clsMRP_iface = New clsMRP_impl With {
            .prop_KeyString01 = "",
            .prop_KeyString02 = "",
            .prop_KeyString03 = ""
            }
            pdDataMaster28COREPRO = objSKKMaster28.Sele28COREPRO()
        End Using

        'get t28cORE PRO
        Using objGetMaster28BOMFCI As clsMRP_iface = New clsMRP_impl With {
            .prop_KeyString01 = ""}
            pdDataMaster28BOMFCI = objGetMaster28BOMFCI.Sele28BOMFCI
        End Using


        Dim objuc As New ucGridReprintPROPreparation With {
           .Dock = DockStyle.Fill,
           ._01prop_t2122MaterialBOMforPRO = pdDataMaster2122MasterBOMforPRO,
           ._01prop_t28BOMFCI = pdDataMaster28BOMFCI,
           ._02prop_t28COREPRO = pdDataMaster28COREPRO}
        ' }

        pnlRoot.Visible = True
        _lblCaption.Text = "PRODUCTION ORDER"
        pnlContent.Controls.Clear()
        pnlContent.Controls.Add(objuc)

    End Sub

    Private Sub DesigMasterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DesigMasterToolStripMenuItem.Click
        'get data
        Dim pdDataMasterSKK23 As New DataTable
        Dim pdDataMasterSKK51 As New DataTable

        Using objSKKMaster As clsMRP_iface = New clsMRP_impl
            pdDataMasterSKK51 = objSKKMaster.Get51MasterAllNewSKK()
        End Using


        'get dt23 MasterSTone
        Using objSKKMaster23 As clsMRP_iface = New clsMRP_impl With {
            .prop_KeyString01 = ""
            }
            pdDataMasterSKK23 = objSKKMaster23.Sele23MCSTONES()
        End Using

        Dim objuc As New ucMRP20EV01DesignMaster With {
          .Dock = DockStyle.Fill,
          .prop_01dvAll51DataMasterSKK = pdDataMasterSKK51,
          .prop_02cUserID = _01Prop_UserID,
          .prop_03cNamaUser = _02Prop_NamaUser,
          .prop_04dvAllDataMaster23 = pdDataMasterSKK23
         }

        pnlRoot.Visible = True
        _lblCaption.Text = "Design Master"
        pnlContent.Controls.Clear()
        pnlContent.Controls.Add(objuc)

    End Sub

    Private Sub JOBCardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles JOBCardToolStripMenuItem.Click

        Me.Cursor = Cursors.WaitCursor

        Dim objuc As New ucMRP20FI02JOBCARD With {
            .Dock = DockStyle.Fill,
            ._01Prop_UserID = _01Prop_UserID,
            ._02Prop_NamaUser = _02Prop_NamaUser
            }


        Me.Cursor = Cursors.Default
        pnlRoot.Visible = True
        _lblCaption.Text = "JOB CARD"
        pnlContent.Controls.Clear()
        pnlContent.Controls.Add(objuc)
    End Sub

    Private Sub PRODUCTIONToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PRODUCTIONToolStripMenuItem.Click

        'Dim pdDataMasterPro28 As New DataTable
        'Dim pdDataMasterProFCI28 As New DataTable
        'Dim pdDataMaster25 As New DataTable
        'Dim pdDataMaster26 As New DataTable
        'Dim pdDataMaster27 As New DataTable
        'Dim pdDataMaster28 As New DataTable
        'Dim pdDataMaster29 As New DataTable

        ''get t25
        'Using objSKKMaster25 As clsMRP_iface = New clsMRP_impl With {
        '      .prop_KeyString01 = "",
        '      .prop_KeyString02 = "",
        '      .prop_KeyString03 = "",
        '      .prop_KeyString04 = ""
        '    }
        '    pdDataMaster25 = objSKKMaster25.Sele25BOMCASTEDPARTS()
        'End Using

        ''get t26
        'Using objSKKMaster26 As clsMRP_iface = New clsMRP_impl With {
        '      .prop_KeyString01 = "",
        '      .prop_KeyString02 = "",
        '      .prop_KeyString03 = ""
        '    }
        '    pdDataMaster26 = objSKKMaster26.Sele26BOMFINDINGCOMPONENT
        'End Using

        ''get t27
        'Using objSKKMaster27 As clsMRP_iface = New clsMRP_impl With {
        '      .prop_KeyString01 = "",
        '      .prop_KeyString02 = "",
        '      .prop_KeyString03 = ""
        '    }
        '    pdDataMaster27 = objSKKMaster27.Sele27BOMSTONES
        'End Using


        '''get t28
        ''Using objSKKMaster28 As clsMRP_iface = New clsMRP_impl With {
        ''     .prop_KeyString01 = "",
        ''     .prop_KeyString02 = "",
        ''     .prop_KeyString03 = ""
        ''    }
        ''    pdDataMaster28 = objSKKMaster28.Sele28COREPRO()
        ''End Using

        ''********************* coreproe t28 **************************
        '' 1 = brj,emas & brj Perak
        '' 2 = Finding Component, Semi finis Good

        ''get data reprint 28PRO
        'Using objSKKMaster28PRO As clsMRP_iface = New clsMRP_impl With {
        '     .prop_KeyInt01 = 1}
        '    pdDataMasterPro28 = objSKKMaster28PRO.SeleReprint28COREPRO()
        'End Using

        ''get data reprint 28PROFCI 
        'Using objSKKMaster28PROFCI As clsMRP_iface = New clsMRP_impl With {
        '     .prop_KeyInt01 = 2}
        '    pdDataMasterProFCI28 = objSKKMaster28PROFCI.SeleReprint28COREPRO()
        'End Using

        ''********************* coreproe t28 **************************

        'Dim objuc As New ucGridReprintPRO With {
        '   .Dock = DockStyle.Fill,
        '   ._01prop_t25BOMCASTEDPARTS = pdDataMaster25,
        '   ._02prop_t26BOMFINDINGCOMPONENT = pdDataMaster26,
        '   ._03prop_t27BOMSTONES = pdDataMaster27,
        '   ._04prop_t28COREPRO = pdDataMasterPro28,
        '   ._05prop_t28COREPROFCI = pdDataMasterProFCI28}

        Dim objuc As New ucGridReprintPRO

        With objuc
            .Dock = DockStyle.Fill
            .prop_gcJudulForm = ""
            .prop_gcUserID_v50 = _01Prop_UserID
            .prop_gcNamaUser_v50 = _02Prop_NamaUser
            ._cm03GetDataSource()
        End With

        pnlRoot.Visible = True
        _lblCaption.Text = "PRODUCTION"
        pnlContent.Controls.Clear()
        pnlContent.Controls.Add(objuc)

    End Sub

    Private Sub JOBCARDToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles JOBCARDToolStripMenuItem1.Click
        Me.Cursor = Cursors.WaitCursor

        'Dim pdDataMaster20Routing As New DataTable
        'Dim pdDataMaster31DSM As New DataTable
        'Dim pdDataMaster35JC As New DataTable
        'Dim pdDataMaster36JCBOM As New DataTable
        'Dim pdDataMaster37JCSTONES As New DataTable

        'Using objSKKMaster20 As clsMRP_iface = New clsMRP_impl With {
        '    .prop_KeyString01 = "",
        '    .prop_KeyString02 = ""
        '    }
        '    pdDataMaster20Routing = objSKKMaster20.Sele20MASTERROUTING
        'End Using

        'Using ObjSKKMaster31 As clsMRP_iface = New clsMRP_impl With {.prop_KeyString01 = ""}
        '    pdDataMaster31DSM = ObjSKKMaster31.Sele31DESIGNMASTERSTONE()
        'End Using

        'Using objSKKMaster35 As clsMRP_iface = New clsMRP_impl With {
        '     .prop_KeyString01 = ""
        '    }
        '    pdDataMaster35JC = objSKKMaster35.Sele35JOBCARD
        'End Using

        'Using objSKKMaster36 As clsMRP_iface = New clsMRP_impl With {
        '    .prop_KeyString01 = ""
        '    }
        '    pdDataMaster36JCBOM = objSKKMaster36.Sele36JOBCARDBOM()
        'End Using

        ''get dt37 jobcardSTONES
        'Using objSKKMaster37 As clsMRP_iface = New clsMRP_impl With {
        '    .prop_KeyString01 = "",
        '    .prop_KeyString02 = ""
        '    }
        '    pdDataMaster37JCSTONES = objSKKMaster37.Sele37JOBCARDSTONE()
        'End Using


        'Dim objuc As New ucGridReprintJOBCARD With {
        '   .Dock = DockStyle.Fill,
        '   ._01propdtMaster35JC = pdDataMaster35JC,
        '   ._02propdtMaster36JCBOM = pdDataMaster36JCBOM,
        '   ._03propdtMaster20Routing = pdDataMaster20Routing,
        '   ._04propdtMaster31DSM = pdDataMaster31DSM,
        '   ._05propdtMaster37JCSTONE = pdDataMaster37JCSTONES
        ' }

        Dim objuc As New ucGridReprintJOBCARD

        With objuc
            .Dock = DockStyle.Fill
            .prop_gcUserID_v50 = _01Prop_UserID
            .prop_gcNamaUser_v50 = _02Prop_NamaUser
            .prop_gcJudulForm = ""
            ._cm02GetDataSource()
        End With

        Me.Cursor = Cursors.Default

        pnlRoot.Visible = True
        _lblCaption.Text = "JOBCARD"
        pnlContent.Controls.Clear()
        pnlContent.Controls.Add(objuc)


    End Sub

    Private Sub Upload2DJobcardToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Upload2DJobcardToolStripMenuItem.Click
        Dim pdDataMaster35JC As New DataTable
        Dim pdDataMaster22FCI As New DataTable
        Dim pdDataMaster30 As New DataTable

        Using objSKKMaster35 As clsMRP_iface = New clsMRP_impl With {
             .prop_KeyString01 = ""
            }
            pdDataMaster35JC = objSKKMaster35.Sele35JOBCARD
        End Using

        Using objSKKMaster22 As clsMRP_iface = New clsMRP_impl With {
             .prop_KeyString01 = ""
            }
            pdDataMaster22FCI = objSKKMaster22.Sele22MCFINDINGCOMPONENT
        End Using

        Using objSKKMaster30 As clsMRP_iface = New clsMRP_impl With {
             .prop_KeyString01 = ""
            }
            pdDataMaster30 = objSKKMaster30.Sele30DESIGNMASTER()
        End Using

        Dim objuc As New ucMRPUpload2DJOBCARD With {
          .Dock = DockStyle.Fill,
          ._01PropDataMastert35 = pdDataMaster35JC,
          ._04PropDataMastert30 = pdDataMaster30,
          ._02PropDataMastertMRP22 = pdDataMaster22FCI
        }

        pnlRoot.Visible = True
        _lblCaption.Text = "UPLOAD PICTURE 2D-JOBCARD"
        pnlContent.Controls.Clear()
        pnlContent.Controls.Add(objuc)
        Me.UseWaitCursor = False

    End Sub

    Private Sub DesignMasterToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles DesignMasterToolStripMenuItem1.Click

        'class loaded
        Me.Cursor = Cursors.WaitCursor
        Dim objuc As New ucGridReprintDesignMasterStone
        With objuc
            .Dock = DockStyle.Fill
            ._01prop_gcUserID_v50 = _01Prop_UserID
            ._02prop_gcNamaUser_v50 = _02Prop_NamaUser
            ._cm05GetDataSource()
        End With

        pnlRoot.Visible = True
        _lblCaption.Text = "Reprint Design Master 2D"
        pnlContent.Controls.Clear()
        pnlContent.Controls.Add(objuc)
        Me.Cursor = Cursors.Default
    End Sub

    Private Sub ucMenu_Disposed(sender As Object, e As EventArgs) Handles Me.Disposed

    End Sub

End Class
