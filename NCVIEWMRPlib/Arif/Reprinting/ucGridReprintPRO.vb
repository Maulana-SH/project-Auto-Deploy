Imports System.Drawing.Printing
Imports DevExpress.XtraGrid.Views.Base
Imports NCMODELlib

Public Class ucGridReprintPRO
    Implements IDisposable

    Public Property prop_gcUserID_v50 As String = ""
    Public Property prop_gcNamaUser_v50 As String = ""
    Public Property prop_gcTitle As String = ""
    Public Property prop_gcJudulForm As String = ""
    Public Property prop_objPicture As Byte()

    Public Property _01prop_t25BOMCASTEDPARTS As DataTable
    Public Property _02prop_t26BOMFINDINGCOMPONENT As DataTable
    Public Property _03prop_t27BOMSTONES As DataTable
    Public Property _04prop_t28COREPRO As DataTable
    Public Property _05prop_t28COREPROFCI As DataTable
    Public Property _06prop_t29ROUTINGBOM As DataTable

    Property prop_cCheckPROFCI As DataTable '=> untuk check columns nChek bCheck Copiprint
    Property prop_cCheckPRO As DataTable '=> untuk check columns nChek bCheck Copiprint


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

#Region "form Evnt"

    Private Sub ucGridPROReprinting_Load(sender As Object, e As EventArgs) Handles Me.Load
        _cm01InitFillGridPRO()
        _cm01InitFillGridPROFCI()
        _pcm01GetPrinterName()
    End Sub

#End Region

#Region "Private Methods"
    Private Sub _pcm01GetPrinterName()
        Dim objSettings As New PrinterSettings
        Dim strPrinter As String
        Try
            For Each strPrinter In PrinterSettings.InstalledPrinters
                _01cCbprinterName.Properties.Items.Add(strPrinter)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        _01cCbprinterName.EditValue = objSettings.PrinterName.ToString
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

    Public Sub _cm03GetDataSource()
        Dim pdDataMasterPro28 As New DataTable
        Dim pdDataMasterProFCI28 As New DataTable
        Dim pdDataMaster25 As New DataTable
        Dim pdDataMaster26 As New DataTable
        Dim pdDataMaster27 As New DataTable
        Dim pdDataMaster28 As New DataTable
        Dim pdDataMaster29 As New DataTable

        'get t25
        Using objSKKMaster25 As clsMRP_iface = New clsMRP_impl With {
              .prop_KeyString01 = "",
              .prop_KeyString02 = "",
              .prop_KeyString03 = "",
              .prop_KeyString04 = ""
            }
            pdDataMaster25 = objSKKMaster25.Sele25BOMCASTEDPARTS()
        End Using

        'get t26
        Using objSKKMaster26 As clsMRP_iface = New clsMRP_impl With {
              .prop_KeyString01 = "",
              .prop_KeyString02 = "",
              .prop_KeyString03 = ""
            }
            pdDataMaster26 = objSKKMaster26.Sele26BOMFINDINGCOMPONENT
        End Using

        'get t27
        Using objSKKMaster27 As clsMRP_iface = New clsMRP_impl With {
              .prop_KeyString01 = "",
              .prop_KeyString02 = "",
              .prop_KeyString03 = ""
            }
            pdDataMaster27 = objSKKMaster27.Sele27BOMSTONES
        End Using

        '********************* coreproe t28 **************************
        ' 1 = brj,emas & brj Perak
        ' 2 = Finding Component, Semi finis Good

        'get data reprint 28PRO
        Using objSKKMaster28PRO As clsMRP_iface = New clsMRP_impl With {
             .prop_KeyInt01 = 1}
            pdDataMasterPro28 = objSKKMaster28PRO.SeleReprint28COREPRO()
        End Using

        'get data reprint 28PROFCI 
        Using objSKKMaster28PROFCI As clsMRP_iface = New clsMRP_impl With {
             .prop_KeyInt01 = 2}
            pdDataMasterProFCI28 = objSKKMaster28PROFCI.SeleReprint28COREPRO()
        End Using

        '********************* coreproe t28 **************************

        With Me
            ._01prop_t25BOMCASTEDPARTS = pdDataMaster25
            ._02prop_t26BOMFINDINGCOMPONENT = pdDataMaster26
            ._03prop_t27BOMSTONES = pdDataMaster27
            ._04prop_t28COREPRO = pdDataMasterPro28
            ._05prop_t28COREPROFCI = pdDataMasterProFCI28
        End With

    End Sub

#End Region


#Region " Reprint PRO"
    Sub _cm01InitFillGridPRO()

        With _gvPRO

            With .Appearance

                With .HeaderPanel
                    .Options.UseBackColor = True
                    .TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    .Font = New Font("Arial", 9, FontStyle.Bold, GraphicsUnit.Point)
                End With

            End With

            col01_bCheck.FieldName = "bCheck"
            col01_bCheck.Caption = "Pilih"
            col02_nCheck.FieldName = "nCheck"
            col02_nCheck.Visible = False
            col03_k01cNoPRO_v50.FieldName = "k01cNoPRO_v50"
            col04_k02cKodeMaterialOrFG_v50.FieldName = "k02cKodeMaterialOrFG_v50"
            col05_f01cNoSalesOrder_v50.FieldName = "k02cKodeMaterialOrFG_v50"
            col06_f02MaterialOrFGDesc_v50.FieldName = "f02MaterialOrFGDesc_v50"
            col08_f07cOrderStatusDesc_v50.FieldName = "f07cOrderStatusDesc_v50"
            col09_f08dOrderDate.FieldName = "f08dOrderDate"
            col010_f09dDeliveryDate.FieldName = "f09dDeliveryDate"
            col011_f12cBrandDesc_v50.FieldName = "f12cBrandDesc_v50"
            col012_f17cNamaProduk_v50.FieldName = "f12cBrandDesc_v50"
            col013_f19cItemBRJDesc_v50.FieldName = "f19cItemBRJDesc_v50"
            col014_f23cKadarDesc_v50.FieldName = "f23cKadarDesc_v50"
            col015_f24cSize_v50.FieldName = "f24cSize_v50"
            col016_f25cNotes_v250.FieldName = "f25cNotes_v250"
            col017_f32dCreatedDate.FieldName = "f32dCreatedDate"
            col018_Copyprint.FieldName = "Copyprint"

            _gcPRO.DataSource = Nothing
            '_gcPRO.DataSource = _04prop_t28COREPRO
            _gcPRO.DataSource = _pcm02COpyDataTabelForReprint(_04prop_t28COREPRO)
            prop_cCheckPRO = _gcPRO.DataSource
            _gcPRO.Refresh()

        End With

    End Sub

    Sub _cmPrintDocPRO()
        ' Dim objPROPARENT As New PROReportParent
        Dim clsCtrlReprintPRO As New clsMRPReprintPRO

        Dim CopyPrint As Integer
        Dim FGCode As String
        Dim NOPRO As String
        Dim Brand As String

        For Each dtRow As DataRow In prop_cCheckPRO.Rows
            If dtRow("nCheck") = 1 Then
                FGCode = dtRow("k02cKodeMaterialOrFG_v50")
                NOPRO = dtRow("k01cNoPRO_v50")
                Brand = dtRow("f12cBrandDesc_v50")
                CopyPrint = dtRow("Copyprint")

                With clsCtrlReprintPRO
                    .prop_01cProductCode = ""
                    .prop_02cPRONumber = NOPRO
                    .prop_03PrintCopies = CInt(CopyPrint)
                End With

                For i = 0 To CopyPrint - 1
                    clsCtrlReprintPRO._02DisplayReportPROFG()
                Next

            End If
        Next
    End Sub



#Region "Grid Event"
    Private Sub _gvPRO_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles _gvPRO.CellValueChanged
        If e.Column.FieldName = "Copyprint" Then
            If CType(_gvPRO.GetFocusedRowCellValue("Copyprint"), Integer) < 1 Then
                _gvPRO.SetFocusedRowCellValue("Copyprint", 1)
                MsgBox("Minimal Print = 1", MsgBoxStyle.Information, "Information")
            End If
        End If

        If e.Column.FieldName = "bCheck" Then
            If CType(_gvPRO.GetFocusedRowCellValue("bCheck"), Boolean) = True Then
                _gvPRO.SetFocusedRowCellValue("nCheck", 1)
            Else
                _gvPRO.SetFocusedRowCellValue("nCheck", 0)
            End If
        End If
        _gvPRO.RefreshData()
    End Sub

#End Region

#Region "Control Evnt"

    Private Sub _02cBtnPrint_Click(sender As Object, e As EventArgs) Handles _02cBtnPrintPRO.Click
        _cmPrintDocPRO()
    End Sub

    Private Sub _03cCheckAll_CheckedChanged(sender As Object, e As EventArgs) Handles _03cCheckAll.CheckedChanged
        _gvPRO.PostEditor()
        For Each dtRow As DataRow In prop_cCheckPRO.Rows
            If _03cCheckAll.Checked = True Then
                dtRow("nCheck") = 1
                dtRow("bCheck") = True
            Else
                dtRow("nCheck") = 0
                dtRow("bCheck") = False
            End If
        Next
    End Sub

#End Region

#End Region


#Region " Reprint PROFCI"

    Sub _cm01InitFillGridPROFCI()

        With _gvProFCI

            With .Appearance

                With .HeaderPanel
                    .Options.UseBackColor = True
                    .TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    .Font = New Font("Arial", 9, FontStyle.Bold, GraphicsUnit.Point)
                End With

            End With

            col01_bCheck_PROFCI.FieldName = "bCheck"
            col01_bCheck_PROFCI.Caption = "Pilih"
            col02_nCheck_PROFCI.FieldName = "nCheck"
            col02_nCheck_PROFCI.Visible = False
            col03_k01cNoPRO_v50_PROFCI.FieldName = "k01cNoPRO_v50"
            col04_k02cKodeMaterialOrFG_v50_PROFCI.FieldName = "k02cKodeMaterialOrFG_v50"
            col05_f01cNoSalesOrder_v50_PROFCI.FieldName = "k02cKodeMaterialOrFG_v50"
            col06_f02MaterialOrFGDesc_v50_PROFCI.FieldName = "f02MaterialOrFGDesc_v50"
            col08_f07cOrderStatusDesc_v50_PROFCI.FieldName = "f07cOrderStatusDesc_v50"
            col09_f08dOrderDate_PROFCI.FieldName = "f08dOrderDate"
            col010_f09dDeliveryDate_PROFCI.FieldName = "f09dDeliveryDate"
            col011_f12cBrandDesc_v50_PROFCI.FieldName = "f12cBrandDesc_v50"
            col012_f17cNamaProduk_v50_PROFCI.FieldName = "f12cBrandDesc_v50"
            col013_f19cItemBRJDesc_v50_PROFCI.FieldName = "f19cItemBRJDesc_v50"
            col014_f23cKadarDesc_v50_PROFCI.FieldName = "f23cKadarDesc_v50"
            col015_f24cSize_v50_PROFCI.FieldName = "f24cSize_v50"
            col016_f25cNotes_v250_PROFCI.FieldName = "f25cNotes_v250"
            col017_f32dCreatedDate_PROFCI.FieldName = "f32dCreatedDate"
            col018_Copyprint_PROFCI.FieldName = "Copyprint"

            _gcPROFCI.DataSource = Nothing
            '_gcPRO.DataSource = _04prop_t28COREPRO
            _gcPROFCI.DataSource = _pcm02COpyDataTabelForReprint(_05prop_t28COREPROFCI)
            prop_cCheckPROFCI = _gcPROFCI.DataSource
            _gcPROFCI.Refresh()

        End With

    End Sub

    Private Sub _ctkCoreProFCI()

        Dim objReportPROFCI As New clsMRPReprintPROFCI

        Dim CopyPrint As Integer
        Dim FGCode As String
        Dim NOPRO As String
        Dim Brand As String

        For Each dtRow As DataRow In prop_cCheckPROFCI.Rows
            If dtRow("nCheck") = 1 Then
                FGCode = dtRow("k02cKodeMaterialOrFG_v50")
                NOPRO = dtRow("k01cNoPRO_v50")
                Brand = dtRow("f12cBrandDesc_v50")
                CopyPrint = dtRow("Copyprint")

                'objPROPARENT._cm05PrintDoc()
                With objReportPROFCI
                    .prop_01cKodeCorePro = NOPRO
                    .prop_02cKodeFCI = FGCode
                End With

                For i = 0 To CopyPrint - 1
                    objReportPROFCI._cm01DisplayReport()
                Next

            End If
        Next

    End Sub


#Region "Grid Event"

    Private Sub _gvProFCI_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles _gvProFCI.CellValueChanged
        If e.Column.FieldName = "Copyprint" Then
            If CType(_gvProFCI.GetFocusedRowCellValue("Copyprint"), Integer) < 1 Then
                _gvProFCI.SetFocusedRowCellValue("Copyprint", 1)
                MsgBox("Minimal Print = 1", MsgBoxStyle.Information, "Information")
            End If
        End If

        If e.Column.FieldName = "bCheck" Then
            If CType(_gvProFCI.GetFocusedRowCellValue("bCheck"), Boolean) = True Then
                _gvProFCI.SetFocusedRowCellValue("nCheck", 1)
            Else
                _gvProFCI.SetFocusedRowCellValue("nCheck", 0)
            End If
        End If
        _gvProFCI.RefreshData()
    End Sub

#End Region

#Region "Control Event"
    Private Sub checkAllProFCI_CheckedChanged(sender As Object, e As EventArgs) Handles checkAllProFCI.CheckedChanged
        _gvProFCI.PostEditor()
        For Each dtRow As DataRow In prop_cCheckPROFCI.Rows
            If checkAllProFCI.Checked = True Then
                dtRow("nCheck") = 1
                dtRow("bCheck") = True
            Else
                dtRow("nCheck") = 0
                dtRow("bCheck") = False
            End If
        Next
    End Sub

    Private Sub BtnPrintFCI_Click(sender As Object, e As EventArgs) Handles BtnPrintFCI.Click
        '_cmPrintDocPROFCI()
        _ctkCoreProFCI()
    End Sub

#End Region

#End Region


End Class
