Imports System.Drawing.Printing
Imports System.IO
Imports DevExpress.XtraGrid.Views.Base
Imports NCMODELlib

Public Class ucGridReprintPROPreparation
    Implements IDisposable

    Public Property prop_gcUserID_v50 As String = ""
    Public Property prop_gcNamaUser_v50 As String = ""
    Public Property prop_gcTitle As String = ""
    Public Property prop_gcJudulForm As String = ""

    Public Property _01prop_t2122MaterialBOMforPRO As DataTable
    Public Property _01prop_t28BOMFCI As DataTable
    Public Property _02prop_t28COREPRO As DataTable
    Public Property _03prop_t29ROUTINGBOM As DataTable
    Private Property _04prop_cCheckPRO As DataTable '=> untuk check columns nChek bCheck Copiprint
    Private Property filter_CorePro As New DataTable '=> untuk filter BRJ / Finding


#Region "Costum Color Code"

    Private Property Backcolor_Panel01 As String = "#ccd5f0"
    Private Property Backcolor_Panel02 As String = ""

    Private Property TitelTextcolor_01 As String = "#5d6b99"
    Private Property Textcolor_01 As String = "#313131"
    Private Property Textcolor_02 As String = ""

    Private Function _cmColorByHtml(ByVal Code As String) As Color
        Return ColorTranslator.FromHtml(Code)
    End Function
#End Region

#Region "Private Methods"
    Private Sub _pcm01GetPrinterName()
        Dim objSettings As New PrinterSettings
        Dim strPrinter As String
        Try
            For Each strPrinter In PrinterSettings.InstalledPrinters
                _01CbprinterName.Properties.Items.Add(strPrinter)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        _01CbprinterName.EditValue = objSettings.PrinterName.ToString
    End Sub

    Private Function _pcm02COpyDataTabelForReprint(ByVal prmDataTable As DataTable) As DataTable

        Dim pdResult As DataTable
        Dim pdCopy As DataTable
        pdCopy = prmDataTable.Clone()
        pdCopy = prmDataTable.Copy()

        'add colum nChec, bCheck, CopyPint
        pdCopy.Columns.Add(New DataColumn("nCheck", Type.GetType("System.Int32")))
        pdCopy.Columns.Add(New DataColumn("bCheck", Type.GetType("System.Boolean")))
        pdCopy.Columns.Add(New DataColumn("Copyprint", Type.GetType("System.Int32")))

        For i As Integer = 0 To pdCopy.Rows.Count - 1
            Dim dtRow As DataRow = pdCopy.Rows(i)
            dtRow("nCheck") = 0
            dtRow("bCheck") = False
            dtRow("Copyprint") = 1

        Next

        pdResult = pdCopy

        Return pdResult
    End Function

    Private Function _cm02byteArrayToImage(ByVal byteArrayIn As Byte()) As Image
        Using mStream As MemoryStream = New MemoryStream(byteArrayIn)
            Return Image.FromStream(mStream)
        End Using
    End Function
#End Region

#Region "Get Datasource For Action Print"

    Private Function GetData28COREPRO(ByVal prmKodePro As String) As DataTable
        Dim pdHasil28COREPRO As New DataTable
        Using obj28CorePRO As clsMRP_iface = New clsMRP_impl With {.prop_KeyString01 = prmKodePro,
                                                                   .prop_KeyString02 = "",
                                                                   .prop_KeyString03 = ""}
            pdHasil28COREPRO = obj28CorePRO.Sele28COREPRO()
        End Using

        Return pdHasil28COREPRO
    End Function

    Private Function GetData28BOMFCI(ByVal prmKodeFCI As String) As DataTable
        Dim pdHasilBOMFCI As New DataTable
        Using obj28BOMFCI As clsMRP_iface = New clsMRP_impl With {.prop_KeyString01 = prmKodeFCI}
            pdHasilBOMFCI = obj28BOMFCI.Sele28BOMFCI()
        End Using

        Return pdHasilBOMFCI
    End Function

    Private Function GetData29ROUTINGBOM(ByVal prmKodeFG As String) As DataTable
        Dim pdHasil29ROUTINGBOM As New DataTable
        Using obj29ROUTINGBOM As clsMRP_iface = New clsMRP_impl With {.prop_KeyString01 = prmKodeFG,
                                                                      .prop_KeyString02 = "",
                                                                      .prop_KeyInt01 = 0,
                                                                      .prop_KeyInt02 = 3}
            pdHasil29ROUTINGBOM = obj29ROUTINGBOM.Sele29ROUTINGBOM()
        End Using

        Return pdHasil29ROUTINGBOM
    End Function

    Private Function GetDataGAMBAR(ByVal prmKodeFCI As String) As DataTable
        Dim pdtGambar As New DataTable
        Using objGambar As clsMRP_iface = New clsMRP_impl With {.prop_KeyInt01 = 1,
                                                                    .prop_KeyString01 = prmKodeFCI,
                                                                    .prop_KeyString02 = ""}
            pdtGambar = objGambar.GetGambarMRP()
        End Using

        Return pdtGambar
    End Function

#End Region

#Region "Costume Methods"

    Sub _cm01InitFillGrid(ByVal prmDataTable As DataTable)

        With _gvPROPreparation

            With .Appearance

                With .HeaderPanel
                    .Options.UseBackColor = True
                    .TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    .Font = New Font("Arial", 9, FontStyle.Bold, GraphicsUnit.Point)
                    .BackColor = _cmColorByHtml(Backcolor_Panel01)
                    .ForeColor = _cmColorByHtml(Textcolor_01)
                End With

            End With

            col01_nCheck.FieldName = "nCheck"
            col01_nCheck.Visible = False
            col02_bCheck.FieldName = "bCheck"
            col03_k01cNoPRO_v50.FieldName = "k01cNoPRO_v50"
            col04_k02cKodeMaterialOrFG_v50.FieldName = "k02cKodeMaterialOrFG_v50"
            col05_f01cNoSalesOrder_v50.FieldName = "f01cNoSalesOrder_v50"
            col06_f02MaterialOrFGDesc_v50.FieldName = "f02MaterialOrFGDesc_v50"

            col07_f03nLot_int.FieldName = "f03nLot_int"
            col07_f03nLot_int.Visible = False

            col08_f04nBerat_n92.FieldName = "f04nBerat_n92"
            col08_f04nBerat_n92.Visible = False

            col09_f05cEngrave_v50.FieldName = "f05cEngrave_v50"
            col09_f05cEngrave_v50.Visible = False

            col010_f07cOrderStatusDesc_v50.FieldName = "f07cOrderStatusDesc_v50"
            col010_f07cOrderStatusDesc_v50.Visible = False

            col011_f08dOrderDate.FieldName = "f08dOrderDate"
            col012_f09dDeliveryDate.FieldName = "f09dDeliveryDate"
            col013_f12cBrandDesc_v50.FieldName = "f12cBrandDesc_v50"

            col014_f14cCustomerDesc_v50.FieldName = "f14cCustomerDesc_v50"
            col014_f14cCustomerDesc_v50.Visible = False

            col015_f16cProjectDesc_v50.FieldName = "f16cProjectDesc_v50"
            col015_f16cProjectDesc_v50.Visible = False
            col016_f17cNamaProduk_v50.FieldName = "f17cNamaProduk_v50"
            col017_f19cItemBRJDesc_v50.FieldName = "f19cItemBRJDesc_v50"
            col017_f19cItemBRJDesc_v50.Visible = False
            col018_f21cWarnaFGDesc_v50.FieldName = "f21cWarnaFGDesc_v50"
            col018_f21cWarnaFGDesc_v50.Visible = False
            col019_f23cKadarDesc_v50.FieldName = "f23cKadarDesc_v50"
            col019_f23cKadarDesc_v50.Visible = False
            col020_f24cSize_v50.FieldName = "f24cSize_v50"
            col021_f25cNotes_v250.FieldName = "f25cNotes_v250"
            col022_Copyprint.FieldName = "Copyprint"

            _gcProPreparation.LookAndFeel.Style = DevExpress.LookAndFeel.LookAndFeelStyle.Flat
            _gcProPreparation.LookAndFeel.UseDefaultLookAndFeel = False

            _gcProPreparation.DataSource = Nothing
            '_gcProPreparation.DataSource = _05prop_t28COREPRO
            '_gcProPreparation.DataSource = _pcm02COpyDataTabelForReprint(_02prop_t28COREPRO)
            _gcProPreparation.DataSource = _pcm02COpyDataTabelForReprint(prmDataTable)
            _04prop_cCheckPRO = _gcProPreparation.DataSource
            _gcProPreparation.Refresh()

        End With

    End Sub

    Sub _cm02Reprinting()

        Dim objPROPARENT As New PROPreparationReportParent

        Dim CopyPrint As Int32
        Dim FGCode As String
        Dim NOPRO As String
        Dim Brand As String

        For Each dtRow As DataRow In _04prop_cCheckPRO.Rows
            If dtRow("nCheck") = 1 Then

                NOPRO = dtRow("k01cNoPRO_v50")
                FGCode = dtRow("k02cKodeMaterialOrFG_v50")
                Brand = dtRow("f12cBrandDesc_v50")
                CopyPrint = dtRow("Copyprint")

                'for (Report Parent) => dt28
                'Dim pdCopy28 As DataTable
                'Dim pdDataRow28() As DataRow
                'pdCopy28 = _02prop_t28COREPRO
                'pdDataRow28 = pdCopy28.Select("k01cNoPRO_v50 = '" & NOPRO & "'")

                'for (Report BOM) => dt28BOMFCI
                'Dim pdCopy28BOMFCI As DataTable
                'Dim pdDataRow28BOMFCI() As DataRow
                'pdCopy28BOMFCI = _01prop_t28BOMFCI
                'pdDataRow28BOMFCI = pdCopy28BOMFCI.Select("k01cKodeFCI_v50 = '" & FGCode & "'")

                '''dt29
                'Dim pdDataMaster29 As New DataTable
                'Using objSKKMaster29 As clsMRP_iface = New clsMRP_impl With {
                '          .prop_KeyString01 = FGCode,
                '          .prop_KeyString02 = "",
                '          .prop_KeyInt01 = 1,
                '          .prop_KeyInt02 = 3
                '        }
                '    pdDataMaster29 = objSKKMaster29.Sele29ROUTINGBOM()
                'End Using

                Dim pdtGambar As New DataTable
                Dim pobjImage1 As Image = Nothing
                Dim pobjImage2 As Image = Nothing
                Dim pobjImage3 As Image = Nothing

                pdtGambar = GetDataGAMBAR(FGCode)
                If pdtGambar.Rows.Count > 0 Then
                    For Each pdtRow As DataRow In pdtGambar.Rows
                        If pdtRow("f02cKodeFGorComponent_v50") = FGCode & "_BOM1" Then
                            pobjImage1 = _cm02byteArrayToImage(pdtRow("f01objGambar"))
                        Else
                            If pdtRow("f02cKodeFGorComponent_v50") = FGCode & "_BOM2" Then
                                pobjImage2 = _cm02byteArrayToImage(pdtRow("f01objGambar"))
                            Else
                                If pdtRow("f02cKodeFGorComponent_v50") = FGCode & "_BOM3" Then
                                    pobjImage3 = _cm02byteArrayToImage(pdtRow("f01objGambar"))
                                End If
                            End If
                        End If
                    Next
                End If

                With objPROPARENT

                    '#pasing datatabel
                    ' Ganti Pake prop dari class NEWCENTRAL
                    '._01Prop_dt28COREPRO = GetData28COREPRO(NOPRO)
                    '._02Prop_dt28BOMFCI = GetData28BOMFCI(FGCode)
                    '._03Prop_dt29RoutingBOM = GetData29ROUTINGBOM(FGCode)

                    'parsing img
                    ._04propImg01 = pobjImage1
                    ._05propImg02 = pobjImage2
                    ._06propImg03 = pobjImage3

                End With

                'looping perintah print 
                For i = 1 To CopyPrint
                    objPROPARENT._cm04PrintDoc(_01CbprinterName.EditValue, NOPRO, Brand)
                Next

            End If
        Next

    End Sub

#End Region

#Region "Grid event"

    Private Sub _gvPROPreparation_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles _gvPROPreparation.CellValueChanged

        If e.Column.FieldName = "Copyprint" Then
            If CType(_gvPROPreparation.GetFocusedRowCellValue("Copyprint"), Integer) < 1 Then
                _gvPROPreparation.SetFocusedRowCellValue("Copyprint", 1)
                MsgBox("Minimal Print = 1", MsgBoxStyle.Information, "Information")
            End If
        End If

        If e.Column.FieldName = "bCheck" Then
            If CType(_gvPROPreparation.GetFocusedRowCellValue("bCheck"), Boolean) = True Then
                _gvPROPreparation.SetFocusedRowCellValue("nCheck", 1)
            Else
                _gvPROPreparation.SetFocusedRowCellValue("nCheck", 0)
            End If
        End If
        _gvPROPreparation.RefreshData()

    End Sub

#End Region

#Region "Control event"

    Private Sub _03cCheckAll_CheckedChanged(sender As Object, e As EventArgs) Handles _03cCheckAll.CheckedChanged
        _gvPROPreparation.PostEditor()
        For Each dtRow As DataRow In _04prop_cCheckPRO.Rows
            If _03cCheckAll.Checked = True Then
                dtRow("nCheck") = 1
                dtRow("bCheck") = True
            Else
                dtRow("nCheck") = 0
                dtRow("bCheck") = False
            End If
        Next
    End Sub
    Private Sub _btnPrint_Click(sender As Object, e As EventArgs) Handles _btnPrint.Click
        _cm02Reprinting()
    End Sub

#End Region

#Region "Form Event"

    Private Sub ucGridPROPreparation_Load(sender As Object, e As EventArgs) Handles Me.Load
        _pcm01GetPrinterName()
        '  _cm01InitFillGrid()
    End Sub

    Private Sub _02TypeBRJ_SelectedIndexChanged(sender As Object, e As EventArgs) Handles _02TypeBRJ.SelectedIndexChanged

        Select Case _02TypeBRJ.SelectedIndex
            Case 0, 1 '(1.Brj Emas, 2.Brj Perak)

            Case 2, 3 '(3.Finding Component, 2.Semi finis Goods)

        End Select

    End Sub

#End Region

End Class
