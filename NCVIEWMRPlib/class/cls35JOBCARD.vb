Imports System.Drawing.Printing
Imports System.IO
Imports DevExpress.XtraReports.UI
Imports NCMODELlib

Public Class cls35JOBCARD
    ' Inherits ucMRP20FI02JOBCARD

    Public Property _01Prop_UserID As String
    Public Property _02Prop_NamaUser As String
    Public Property _03Prop_Kodevalidation As String
    Public Property _04Prop_KodeMasterRouting As String
    Public Property _05Prop_PrinterName As String

    'dataTable Jobcard
    Private Property pdDataMasterSKK20 As DataTable
    Private Property pdDataMasterSKK35 As DataTable
    Private Property pdDataMasterSKK36 As DataTable
    Private Property pdDataMasterSKK37 As DataTable

    'prop IMG
    Public Property _IMG3D_No1 As Image
    Public Property _IMG3D_No2 As Image
    Public Property _IMG3D_No3 As Image

    Dim objFrmEntryJOBCARD As New ucMRP20FI02JOBCARD

#Region "Private Methods"
    Private Function _pm01ByteArrayToImage(ByVal byteArrayIn As Byte()) As Image
        Dim ms As MemoryStream = New MemoryStream(byteArrayIn)
        Dim returnImage As Image = Image.FromStream(ms)
        Return returnImage
    End Function

#End Region

#Region " For load Entry JOBCARD"

    'Public Sub _03GetdataSource()

    '    ' Cursor = Cursors.WaitCursor

    '    Dim pdDataMasterSKK20 As New DataTable
    '    Dim pdDataMasterSKK21 As New DataTable
    '    Dim pdDataMasterSKK30 As New DataTable
    '    Dim pdDataMasterSKK35 As New DataTable
    '    Dim pdDataMasterSKK36 As New DataTable
    '    Dim pdDataMasterSKK51 As New DataTable
    '    Dim pdDataMasterSKKGambar As New DataTable

    '    ''get dt2122 
    '    'Using objSKKMasterMaterial2122 As clsMRP_iface = New clsMRP_impl
    '    '    pdDataMasterMaterialSKK2122 = objSKKMasterMaterial2122.Get2122MasterMaterial
    '    'End Using

    '    'get dt20 MasterRouting
    '    Using objSKKMaster20 As clsMRP_iface = New clsMRP_impl With {
    '        .prop_KeyString01 = "",
    '        .prop_KeyString02 = ""
    '        }
    '        pdDataMasterSKK20 = objSKKMaster20.Sele20MASTERROUTING
    '    End Using

    '    'get dt21 MCRawMaterial
    '    Using objSKKMaster21 As clsMRP_iface = New clsMRP_impl With {
    '        .prop_KeyString01 = ""
    '        }
    '        pdDataMasterSKK21 = objSKKMaster21.Sele21MCRAWMATERIAL
    '    End Using

    '    'get dt30 DesigMaster
    '    Using objSKKMaster30 As clsMRP_iface = New clsMRP_impl With {
    '        .prop_KeyString01 = ""
    '        }
    '        pdDataMasterSKK30 = objSKKMaster30.Sele30DESIGNMASTER()
    '    End Using

    '    'get dt35 jobcard
    '    Using objSKKMaster35 As clsMRP_iface = New clsMRP_impl With {
    '        .prop_KeyString01 = ""
    '        }
    '        pdDataMasterSKK35 = objSKKMaster35.Sele35JOBCARD()
    '    End Using

    '    'get dt36 jobcardBOM
    '    Using objSKKMaster36 As clsMRP_iface = New clsMRP_impl With {
    '        .prop_KeyString01 = ""
    '        }
    '        pdDataMasterSKK36 = objSKKMaster36.Sele36JOBCARDBOM()
    '    End Using

    '    'get dt51
    '    Using objSKKMaster As clsMRP_iface = New clsMRP_impl
    '        pdDataMasterSKK51 = objSKKMaster.Get51MasterAllNewSKK()
    '    End Using

    '    'get gambar all
    '    Using objSKKMasterGambar As clsMRP_iface = New clsMRP_impl With {
    '        .prop_KeyString01 = ""
    '        }
    '        pdDataMasterSKKGambar = objSKKMasterGambar.GetGambar()
    '    End Using

    '    'set DataSource
    '    _03PropDataMasterSKK30 = pdDataMasterSKK30
    '    _04PropDataMasterSKK51 = pdDataMasterSKK51
    '    _05PropDataMasterRouting = pdDataMasterSKK20
    '    _06PropDataMasterMaterial21 = pdDataMasterSKK21
    '    _07PropDataMastert35 = pdDataMasterSKK35
    '    _08PropDataMastert36 = pdDataMasterSKK36
    '    _09PropDataMasterGambar = pdDataMasterSKKGambar

    '    MyBase._01Prop_UserID = _01Prop_UserID
    '    MyBase._02Prop_NamaUser = _02Prop_NamaUser

    '    Me.Cursor = Cursors.Default

    'End Sub

    'Sub _04BindingAwal()

    '    _cm01InitControl()
    '    _cm02InitFillGrid()
    '    _cm05InitRepo()
    '    _cm03EntryClear()

    'End Sub

#End Region

#Region " For load Reprint JOBCARD"

#Region "Get DataSource"

    Private Function _get20MasterRouting() As DataTable
        Dim pdHasil As New DataTable
        pdHasil.Clear()

        Using objSKKMaster20 As clsMRP_iface = New clsMRP_impl With {
            .prop_KeyString01 = _04Prop_KodeMasterRouting,
            .prop_KeyString02 = ""
            }
            pdHasil = objSKKMaster20.Sele20MASTERROUTING()
        End Using

        If pdHasil.Rows.Count > 0 Then
            Return pdHasil
        End If
        Return pdHasil
    End Function

    Private Function _get35() As DataTable
        Dim pdHasil As New DataTable
        pdHasil.Clear()

        ' get dt35 jobcard
        Using objSKKMaster35 As clsMRP_iface = New clsMRP_impl With {
                .prop_KeyString01 = _03Prop_Kodevalidation
                }
            pdHasil = objSKKMaster35.Sele35JOBCARD()
        End Using

        If pdHasil.Rows.Count > 0 Then
            Return pdHasil
        End If
        Return pdHasil
    End Function

    Private Function _get36() As DataTable
        Dim pdHasil As New DataTable
        pdHasil.Clear()

        'get dt36 jobcardBOM
        Using objSKKMaster36 As clsMRP_iface = New clsMRP_impl With {
            .prop_KeyString01 = _03Prop_Kodevalidation
            }
            pdHasil = objSKKMaster36.Sele36JOBCARDBOM()
        End Using

        If pdHasil.Rows.Count > 0 Then
            Return pdHasil
        End If
        Return pdHasil
    End Function

    Private Function _get37() As DataTable
        Dim pdHasil As New DataTable
        pdHasil.Clear()

        'get dt36 jobcardBOM
        Using objSKKMaster37 As clsMRP_iface = New clsMRP_impl With {
            .prop_KeyString01 = _03Prop_Kodevalidation,
            .prop_KeyString02 = ""
            }
            pdHasil = objSKKMaster37.Sele37JOBCARDSTONE
        End Using

        If pdHasil.Rows.Count > 0 Then
            Return pdHasil
        End If
        Return pdHasil
    End Function

    Public Sub _GetAllDataSource()

        pdDataMasterSKK20 = _get20MasterRouting()
        pdDataMasterSKK35 = _get35()
        pdDataMasterSKK36 = _get36()
        pdDataMasterSKK37 = _get37()

    End Sub

    Public Sub _SetImage3D()
        If pdDataMasterSKK35.Rows.Count > 0 Then
            'passing image
            For Each itemRow As Object In pdDataMasterSKK35.Rows

                If Not TypeOf itemRow("f30objGambar3D01") Is DBNull Then
                    _IMG3D_No1 = _pm01ByteArrayToImage(itemRow("f30objGambar3D01"))
                Else
                    _IMG3D_No1 = Nothing
                End If

                If Not TypeOf itemRow("f31objGambar3D02") Is DBNull Then
                    _IMG3D_No2 = _pm01ByteArrayToImage(itemRow("f31objGambar3D02"))
                Else
                    _IMG3D_No2 = Nothing
                End If

                If Not TypeOf itemRow("f32objGambar3D03") Is DBNull Then
                    _IMG3D_No3 = _pm01ByteArrayToImage(itemRow("f32objGambar3D03"))
                Else
                    _IMG3D_No3 = Nothing
                End If
            Next

        End If
    End Sub

#End Region

#Region "print 2D"

    'Public Sub _cm01ShowPreview2D(ByVal prmPrinterName As String, ByVal prmKodeValidation As String, ByVal prmKodeDMS As String, ByVal Copiesto As Integer)

    '    'dataTable Jobcard
    '    Dim pdDataMasterSKK35 As DataTable
    '    Dim pdDataMasterSKK37 As DataTable
    '    Dim pdDataMasterSKKGambar As DataTable

    '    ' get dt35 jobcard
    '    Using objSKKMaster35 As clsMRP_iface = New clsMRP_impl With {
    '            .prop_KeyString01 = prmKodeValidation
    '            }
    '        pdDataMasterSKK35 = objSKKMaster35.Sele35JOBCARD()
    '    End Using

    '    'get dt37 jobcardSTONES
    '    Using objSKKMaster37 As clsMRP_iface = New clsMRP_impl With {
    '        .prop_KeyString01 = prmKodeValidation,
    '        .prop_KeyString02 = ""
    '        }
    '        pdDataMasterSKK37 = objSKKMaster37.Sele37JOBCARDSTONE()
    '    End Using

    '    'get Gambar 2D
    '    Using objSKKMasterGambar As clsMRP_iface = New clsMRP_impl With {
    '        .prop_KeyString01 = prmKodeDMS
    '        }
    '        pdDataMasterSKKGambar = objSKKMasterGambar.GetGambar()
    '    End Using


    '    Dim objReportParent2D As New JCReportParent2D
    '    With objReportParent2D

    '        'pasing datatable
    '        'for header report
    '        If pdDataMasterSKK35.Rows.Count > 0 Then
    '            ._01prop_dt35 = pdDataMasterSKK35
    '        End If

    '        'for stone list
    '        If pdDataMasterSKK37.Rows.Count > 0 Then
    '            ._02prop_dt31 = pdDataMasterSKK37
    '        End If

    '        'passing img 2D
    '        If pdDataMasterSKKGambar.Rows.Count > 0 Then
    '            For Each itemRow As Object In pdDataMasterSKKGambar.Rows
    '                Dim objImgName As String = itemRow("f02cKodeFGorComponent_v50")
    '                Dim objIMG As Byte() = itemRow("f01objGambar")
    '                Dim _3CImgName As String = objImgName.Substring(objImgName.Length - 4)

    '                Select Case _3CImgName
    '                    Case "2D00"
    '                        ._04prop_Img2D = _pm01ByteArrayToImage(objIMG)
    '                End Select
    '            Next
    '        Else
    '            MsgBox("data gambar tidak ada")
    '            ._04prop_Img2D = Nothing
    '        End If

    '        For i = 1 To Copiesto
    '            ._cm02PrintDoc(prmPrinterName)
    '        Next
    '    End With

    'End Sub

#End Region

#Region "print 3D"

    Public Sub _cm01ShowPreviewDoc()

        _GetAllDataSource() ' ini hasil filter dari prop

        'pasing datatable
        Dim objPrinterSetting As New PrinterSettings

        Dim objJCParent As New JCReportParent3D
        Dim objJCReportBOM As New JCReportBom
        Dim objJCReportRouting As New JCReportRouting
        Dim objJCReportIMG3D As New JCReportImg3D
        Dim objJCReportStoneList As New JCReportStoneList3D

        If pdDataMasterSKK35.Rows.Count > 0 Then
            objJCParent.DataSource = pdDataMasterSKK35
            _SetImage3D() ' set IMG dari 35
            'setReport IMG
            objJCParent.SubReportImg3D.ReportSource = objJCReportIMG3D
            With objJCReportIMG3D
                ._01cNameImg.Text = "3D Picture"
                ._02cImg_01.Image = _IMG3D_No1
                ._03cImg_02.Image = _IMG3D_No2
                ._04cImg_03.Image = _IMG3D_No3
            End With
        End If

        ' set report BOM  
        If pdDataMasterSKK36.Rows.Count > 0 Then
            objJCParent.SubReportBOM.ReportSource = objJCReportBOM
            objJCReportBOM.DataSource = pdDataMasterSKK36
        End If

        'setstone List
        If pdDataMasterSKK37.Rows.Count > 0 Then
            objJCParent.SubreportStone.ReportSource = objJCReportStoneList
            objJCReportStoneList.DataSource = pdDataMasterSKK37
        End If

        ' Set Report Routing
        If pdDataMasterSKK20.Rows.Count > 0 Then
            objJCParent.SubreportRouting.ReportSource = objJCReportRouting
            objJCReportRouting.DataSource = pdDataMasterSKK20
        End If

        objPrinterSetting.PrinterName = _05Prop_PrinterName
        ' objPrinterSetting.Copies = CopiesTo
        objJCParent.PaperKind = PaperKind.A4
        'Margins(Left, Right, Top, Bottom)
        objJCParent.Margins = New Margins(25, 25, 15, 25)
        objJCParent.ShowPreview

    End Sub

#End Region

#End Region


End Class
