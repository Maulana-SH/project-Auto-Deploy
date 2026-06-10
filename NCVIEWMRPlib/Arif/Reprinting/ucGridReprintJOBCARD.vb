Imports System.Drawing.Printing
Imports System.IO
Imports DevExpress.XtraBars.Docking2010
Imports DevExpress.XtraGrid.Views.Base
Imports DevExpress.XtraGrid.Views.Grid
Imports NCMODELlib

Public Class ucGridReprintJOBCARD
    Implements IDisposable

    Public Property prop_gcUserID_v50 As String = ""
    Public Property prop_gcNamaUser_v50 As String = ""
    Public Property prop_gcTitle As String = ""
    Public Property prop_gcJudulForm As String = ""

    Public Property _01propdtMaster35JC As DataTable
    Public Property _02propdtMaster36JCBOM As DataTable
    Public Property _03propdtMaster20Routing As DataTable
    Public Property _04propdtMaster31DSM As DataTable
    Public Property _05propdtMaster37JCSTONE As DataTable
    Private Property prop_cCheckJC As DataTable '=> for cek colomn nCheck untuk Reprint

    Private ReprintJobcard As cls35JOBCARD

    Private Sub ucGridReprintJOBCARD_Load(sender As Object, e As EventArgs) Handles Me.Load
        '_cm04BindingAwal()
        _pcm01GetPrinterName()
        _pm04IniFieldGrid()
        ReprintJobcard = New cls35JOBCARD
    End Sub


#Region "Custom Color Code"

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
                _01cCbprinterName.Properties.Items.Add(strPrinter)
            Next
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        _01cCbprinterName.EditValue = objSettings.PrinterName.ToString
    End Sub

    Private Function _pm02ByteArrayToImage(ByVal byteArrayIn As Byte()) As Image
        Dim ms As MemoryStream = New MemoryStream(byteArrayIn)
        Dim returnImage As Image = Image.FromStream(ms)
        Return returnImage
    End Function

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

    Private Sub _pm03Print3D(ByVal prmPrinterName As String, ByVal prmKodeValld As String, ByVal prmKodeDMS As String, ByVal prmKodeMRouting As String, ByVal Copiesto As Integer)

        Dim pdRowt35 As DataRow()
        Dim pdCopy35 As New DataTable
        pdRowt35 = _01propdtMaster35JC.Select("k01cKodeValidation_v50 = '" & prmKodeValld & "'")
        If pdRowt35.Count > 0 Then
            pdCopy35 = pdRowt35.CopyToDataTable
        End If

        Dim pdRowt36 As DataRow()
        Dim pdCopy36 As New DataTable
        pdRowt36 = _02propdtMaster36JCBOM.Select("k01cKodeValidation_v50 = '" & prmKodeValld & "'")
        If pdRowt36.Count > 0 Then
            pdCopy36 = pdRowt36.CopyToDataTable
        End If

        Dim pdRowt20 As DataRow()
        Dim pdCopy20 As New DataTable
        pdRowt20 = _03propdtMaster20Routing.Select("k01cKodeMasterRouting_v50 = '" & prmKodeMRouting & "'")
        If pdRowt20.Count > 0 Then
            pdCopy20 = pdRowt20.CopyToDataTable
        Else
            pdCopy20 = Nothing
        End If

        'set Prop Report Parent
        Dim objReportParent3D As New JCReportParent3D
        With objReportParent3D

            'pasing datatable
            ._01prop_dt35 = pdCopy35
            ._02prop_dt36 = pdCopy36
            ._04prop_dtRouting = pdCopy20

            'pasing IMG 3D

            If pdRowt35.Count > 0 Then
                For Each itemRow As Object In pdRowt35

                    If Not TypeOf itemRow("f30objGambar3D01") Is DBNull Then
                        ._IMG3D_No1 = _pm02ByteArrayToImage(itemRow("f30objGambar3D01"))
                    Else
                        ._IMG3D_No1 = Nothing
                    End If

                    If Not TypeOf itemRow("f31objGambar3D02") Is DBNull Then
                        ._IMG3D_No2 = _pm02ByteArrayToImage(itemRow("f31objGambar3D02"))
                    Else
                        ._IMG3D_No2 = Nothing
                    End If

                    If Not TypeOf itemRow("f32objGambar3D03") Is DBNull Then
                        ._IMG3D_No3 = _pm02ByteArrayToImage(itemRow("f32objGambar3D03"))
                    Else
                        ._IMG3D_No3 = Nothing
                    End If


                Next
            Else
                MsgBox("Gambar 3D Tidak Ditemukan, Pastikan Gambar Telah di Upload pada Entry JOBCARD", MsgBoxStyle.Information, "INFROMATION...!!")
            End If

            For i = 1 To Copiesto
                ._cm03PrintDoc(prmPrinterName)
            Next
        End With

    End Sub

    Public Sub _pm04IniFieldGrid()

        With _gvJOBCARD

            'grid Style
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
            col03_k01cKodeValidation_v50.FieldName = "k01cKodeValidation_v50"
            col04_k02cKodeMasterRouting_v50.FieldName = "k02cKodeMasterRouting_v50"
            col05_k03cKodeDesignMaster.FieldName = "k03cKodeDesignMaster"
            col06_f02cNameJCProductType_v50.FieldName = "f02cNameJCProductType_v50"
            col07_f04cNameJCProductSubtype_v50.FieldName = "f04cNameJCProductSubtype_v50"
            col08_f05dInputDateAdmin.FieldName = "f05dInputDateAdmin"
            col09_f06dDeliveryDate.FieldName = "f06dDeliveryDate"
            col10_f08cNameItemProduct_v50.FieldName = "f08cNameItemProduct_v50"
            col11_f20cNameMasterType_v50.FieldName = "f20cNameMasterType_v50"
            col12_f24cNameProject_v50.FieldName = "f24cNameProject_v50"
            col13_f27nEstimasiBerat_n92.FieldName = "f27nEstimasiBerat_n92"
            col14_CreatDate.FieldName = "f42dCreatedDate"
            col14_CreatDate.Caption = "Created"
            col15_Copyprint.FieldName = "Copyprint"

            _gcJOBCARD.DataSource = Nothing
            _gcJOBCARD.DataSource = _pcm02COpyDataTabelForReprint(_01propdtMaster35JC)
            prop_cCheckJC = _gcJOBCARD.DataSource
            _gcJOBCARD.Refresh()


        End With

    End Sub

#End Region

#Region "Control Event"

    Private Sub _gvJOBCARD_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles _gvJOBCARD.CellValueChanged
        _gvJOBCARD.PostEditor()

        If e.Column.FieldName = "Copyprint" Then
            If CType(_gvJOBCARD.GetFocusedRowCellValue("Copyprint"), Integer) < 1 Then
                _gvJOBCARD.SetFocusedRowCellValue("Copyprint", 1)
                MsgBox("Minimal Print = 1", MsgBoxStyle.Information, "Information")
            End If
        End If

        If e.Column.FieldName = "bCheck" Then
            If CType(_gvJOBCARD.GetFocusedRowCellValue("bCheck"), Boolean) = True Then
                _gvJOBCARD.SetFocusedRowCellValue("nCheck", 1)
            Else
                _gvJOBCARD.SetFocusedRowCellValue("nCheck", 0)
            End If
        End If

    End Sub

    Private Sub _02cCheckAll_CheckedChanged(sender As Object, e As EventArgs) Handles _02cCheckAll.CheckedChanged
        _gvJOBCARD.PostEditor()
        For Each dtRow As DataRow In prop_cCheckJC.Rows
            If _02cCheckAll.Checked = True Then
                dtRow("nCheck") = 1
                dtRow("bCheck") = True
            Else
                dtRow("nCheck") = 0
                dtRow("bCheck") = False
            End If
        Next
        _gvJOBCARD.RefreshData()
    End Sub

    Private Sub _btnPrint_Click(sender As Object, e As EventArgs) Handles _btnPrint.Click
        Dim CopyPrint As Integer
        Dim Novalidation As String
        Dim KodeMRouting As String
        Dim KodeDMS As String

        For Each dtRow As DataRow In prop_cCheckJC.Rows
            If dtRow("nCheck") = 1 Then

                Novalidation = dtRow("k01cKodeValidation_v50")
                KodeMRouting = dtRow("k02cKodeMasterRouting_v50")
                KodeDMS = dtRow("k03cKodeDesignMaster")
                CopyPrint = dtRow("Copyprint")

                _pm03Print3D(_01cCbprinterName.EditValue, Novalidation, KodeDMS, KodeMRouting, CopyPrint)

                'With ReprintJobcard
                '    ._cm02ShowPreview3D(_01cCbprinterName.EditValue, Novalidation, KodeDMS, KodeMRouting, CopyPrint)
                'End With
            End If
        Next
    End Sub

    Private Sub _btnPrintPreview_Click(sender As Object, e As EventArgs) Handles _btnPrintPreview.Click

        Dim CopyPrint As Integer
        Dim Novalidation As String
        Dim KodeMRouting As String
        Dim KodeDMS As String

        For Each dtRow As DataRow In prop_cCheckJC.Rows
            If dtRow("nCheck") = 1 Then

                Novalidation = dtRow("k01cKodeValidation_v50")
                KodeMRouting = dtRow("k02cKodeMasterRouting_v50")
                KodeDMS = dtRow("k03cKodeDesignMaster")
                CopyPrint = dtRow("Copyprint")

                With ReprintJobcard
                    ._03Prop_Kodevalidation = Novalidation
                    ._04Prop_KodeMasterRouting = KodeMRouting
                    ._05Prop_PrinterName = _01cCbprinterName.EditValue
                End With

                Dim i As Integer
                For i = 0 To CopyPrint - 1
                    ReprintJobcard._cm01ShowPreviewDoc()
                Next

            End If
        Next
    End Sub

#End Region

    'for load to class
#Region "Get DataSource"

    Public Sub _cm02GetDataSource()

        Dim pdDataMaster20Routing As New DataTable
        Dim pdDataMaster31DSM As New DataTable
        Dim pdDataMaster35JC As New DataTable
        Dim pdDataMaster36JCBOM As New DataTable
        Dim pdDataMaster37JCSTONES As New DataTable

        Using objSKKMaster20 As clsMRP_iface = New clsMRP_impl With {
            .prop_KeyString01 = "",
            .prop_KeyString02 = ""
            }
            pdDataMaster20Routing = objSKKMaster20.Sele20MASTERROUTING
        End Using

        Using ObjSKKMaster31 As clsMRP_iface = New clsMRP_impl With {.prop_KeyString01 = ""}
            pdDataMaster31DSM = ObjSKKMaster31.Sele31DESIGNMASTERSTONE()
        End Using

        Using objSKKMaster35 As clsMRP_iface = New clsMRP_impl With {
             .prop_KeyString01 = ""
            }
            pdDataMaster35JC = objSKKMaster35.Sele35JOBCARD
        End Using

        Using objSKKMaster36 As clsMRP_iface = New clsMRP_impl With {
            .prop_KeyString01 = ""
            }
            pdDataMaster36JCBOM = objSKKMaster36.Sele36JOBCARDBOM()
        End Using

        'get dt37 jobcardSTONES
        Using objSKKMaster37 As clsMRP_iface = New clsMRP_impl With {
            .prop_KeyString01 = "",
            .prop_KeyString02 = ""
            }
            pdDataMaster37JCSTONES = objSKKMaster37.Sele37JOBCARDSTONE()
        End Using

        With Me
            ._01propdtMaster35JC = pdDataMaster35JC
            ._02propdtMaster36JCBOM = pdDataMaster36JCBOM
            ._03propdtMaster20Routing = pdDataMaster20Routing
            ._04propdtMaster31DSM = pdDataMaster31DSM
            ._05propdtMaster37JCSTONE = pdDataMaster37JCSTONES
        End With

    End Sub

#End Region


End Class
