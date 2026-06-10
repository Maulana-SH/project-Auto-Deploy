Imports System.Drawing.Printing
Imports System.IO
Imports DevExpress.XtraGrid.Views.Base
Imports NCMODELlib

Public Class ucGridReprintDesignMasterStone
    Implements IDisposable

    Public Property _01prop_gcUserID_v50 As String = ""
    Public Property _02prop_gcNamaUser_v50 As String = ""
    Public Property prop_gcTitle As String = ""
    Public Property prop_gcJudulForm As String = ""
    Public Property _03prop_t30DESIGNMASTER As DataTable
    Public Property _04prop_t31DESIGNMASTERSTONE As DataTable
    Public Property _05prop_t35JOBCARD As DataTable
    Private Property prop_dtCheck As DataTable

    Private Sub ucGridReprintDesignMasterStone_Load(sender As Object, e As EventArgs) Handles Me.Load
        _cm06InitFieldGrid()
    End Sub

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

    Private Function _pm03COpyDataTabelForReprint(ByVal prmDataTable As DataTable) As DataTable

        Dim pdResult As DataTable
        Dim pdCopy As DataTable
        ' pdCopy = prmDataTable.Clone()
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

        pdResult = pdCopy.Copy()

        Return pdResult
    End Function


#End Region

#Region "Custom Methods"

    Public Sub _cm05GetDataSource()
        Dim pdDataMaster30 As New DataTable
        Dim pdDataMaster31 As New DataTable
        Dim pdDataMaster35 As New DataTable
        'get30
        Using ObjSKKMaster As clsMRP_iface = New clsMRP_impl With {.prop_KeyString01 = ""}
            pdDataMaster30 = ObjSKKMaster.Sele30DESIGNMASTER()
        End Using

        'get31
        Using ObjSKKMaster31 As clsMRP_iface = New clsMRP_impl With {.prop_KeyString01 = ""}
            pdDataMaster31 = ObjSKKMaster31.Sele31DESIGNMASTERSTONE()
        End Using

        'get31
        Using ObjSKKMaster35 As clsMRP_iface = New clsMRP_impl With {.prop_KeyString01 = ""}
            pdDataMaster35 = ObjSKKMaster35.Sele35JOBCARD
        End Using

        _03prop_t30DESIGNMASTER = pdDataMaster30
        _04prop_t31DESIGNMASTERSTONE = pdDataMaster31
        _05prop_t35JOBCARD = pdDataMaster35

    End Sub

    Public Sub _cm06InitFieldGrid()
        _pcm01GetPrinterName()

        With _gvDMS
            'grid Style
            With .Appearance

                With .HeaderPanel
                    .Options.UseBackColor = True
                    .TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    .Font = New Font("Arial", 9, FontStyle.Bold, GraphicsUnit.Point)
                End With

            End With

            col01_nCheck.FieldName = "nCheck"
            col01_nCheck.Visible = False
        col02_bCheck.FieldName = "bCheck"
        col03_k01cKodeDesignMaster_v50.FieldName = "k01cKodeDesignMaster_v50"
        col04_f02cNamaBrand_v50.FieldName = "f02cNamaBrand_v50"
        col05_f06cNamaNamingProduct_v50.FieldName = "f06cNamaNamingProduct_v50"
        col07_f17nGrossWeight_n94.FieldName = "f17nGrossWeight_n94"
            'col08_f18cKodeSize_v50.FieldName = "f18cKodeSize_v50"
            col08_f18cKodeSize_v50.FieldName = "f19cNamaSize_v50"
            col09_f08cNamaItemProduct_v50.FieldName = "f08cNamaItemProduct_v50"
        col10_f10cNamaSubItemProduct_v50.FieldName = "f10cNamaSubItemProduct_v50"
        col10_f10cNamaSubItemProduct_v50.FieldName = "f10cNamaSubItemProduct_v50"
        col11_Copyto.FieldName = "Copyprint"
        col12_Novalidasi.FieldName = "f01cNoJobCard_v50"

        _gcDMS.DataSource = Nothing
        _gcDMS.DataSource = _pm03COpyDataTabelForReprint(_03prop_t30DESIGNMASTER)
        prop_dtCheck = _gcDMS.DataSource
        _gcDMS.Refresh()


        End With
    End Sub

    Private Sub _cm07ShowPreview2D(ByVal prmPrinterName As String, ByVal prmKodeValidation As String, ByVal prmKodeDMS As String)

        Dim objReportParent2D As New JCReportParent2D

        With objReportParent2D

            'for header report
            Dim pdRowt30 As DataRow()
            Dim pdCopy30 As New DataTable
            'pdRowt35 = _03prop_t30DESIGNMASTER.Select("k01cKodeValidation_v50 = '" & prmKodeValidation & "'")
            pdRowt30 = _03prop_t30DESIGNMASTER.Select("k01cKodeDesignMaster_v50 = '" & prmKodeDMS & "'")
            If pdRowt30.Count > 0 Then
                pdCopy30 = pdRowt30.CopyToDataTable
            End If

            Dim pdRowt31 As DataRow()
            Dim pdCopy31 As New DataTable
            pdRowt31 = _04prop_t31DESIGNMASTERSTONE.Select("k01cKodeDesignMaster_v50 = '" & prmKodeDMS & "'")
            If pdRowt31.Count > 0 Then
                pdCopy31 = pdRowt31.CopyToDataTable
            End If

            Dim pdRowt35 As DataRow()
            Dim pdCopy35 As New DataTable
            pdRowt35 = _05prop_t35JOBCARD.Select("k01cKodeValidation_v50 = '" & prmKodeValidation & "'")

            'pasing datatable
            ._01prop_dt30 = pdCopy30
            ._02prop_dt31 = pdCopy31
            ._03DesignerName = ""

            Dim pdDataMasterSKKGambar As DataTable
            Using objSKKMasterGambar As clsMRP_iface = New clsMRP_impl With {
            .prop_KeyString01 = prmKodeDMS
            }
                pdDataMasterSKKGambar = objSKKMasterGambar.GetGambar()
            End Using

            ''passing img 2D
            'If pdDataMasterSKKGambar.Rows.Count > 0 Then
            '    For Each itemRow As Object In pdDataMasterSKKGambar.Rows
            '        Dim objImgName As String = itemRow("f02cKodeFGorComponent_v50")
            '        Dim objIMG As Byte() = itemRow("f01objGambar")
            '        Dim _3CImgName As String = objImgName.Substring(objImgName.Length - 4)

            '        Select Case _3CImgName
            '            Case "2D00"
            '                ._04prop_Img2D = _pm02ByteArrayToImage(objIMG)
            '        End Select
            '    Next
            'Else
            '    MsgBox("data gambar tidak ada")
            '    ._04prop_Img2D = Nothing
            'End If

            ._cm02PrintPreview(prmPrinterName)

        End With

    End Sub

    Private Sub _cm08Print2D(ByVal prmPrinterName As String, ByVal prmKodeValidation As String, ByVal prmKodeDMS As String, ByVal Copiesto As Integer)

        Dim objReportParent2D As New JCReportParent2D

        With objReportParent2D

            'for header report
            Dim pdRowt30 As DataRow()
            Dim pdCopy30 As New DataTable
            'pdRowt35 = _03prop_t30DESIGNMASTER.Select("k01cKodeValidation_v50 = '" & prmKodeValidation & "'")
            pdRowt30 = _03prop_t30DESIGNMASTER.Select("k01cKodeDesignMaster_v50 = '" & prmKodeDMS & "'")
            If pdRowt30.Count > 0 Then
                pdCopy30 = pdRowt30.CopyToDataTable
            End If

            Dim pdRowt31 As DataRow()
            Dim pdCopy31 As New DataTable
            pdRowt31 = _04prop_t31DESIGNMASTERSTONE.Select("k01cKodeDesignMaster_v50 = '" & prmKodeDMS & "'")
            If pdRowt31.Count > 0 Then
                pdCopy31 = pdRowt31.CopyToDataTable
            End If

            'pasing datatable
            ._01prop_dt30 = pdCopy30
            ._02prop_dt31 = pdCopy31

            Dim pdDataMasterSKKGambar As DataTable
            Using objSKKMasterGambar As clsMRP_iface = New clsMRP_impl With {
            .prop_KeyString01 = prmKodeDMS
            }
                pdDataMasterSKKGambar = objSKKMasterGambar.GetGambar()
            End Using

            'passing img 2D
            If pdDataMasterSKKGambar.Rows.Count > 0 Then
                For Each itemRow As Object In pdDataMasterSKKGambar.Rows
                    Dim objImgName As String = itemRow("f02cKodeFGorComponent_v50")
                    Dim objIMG As Byte() = itemRow("f01objGambar")
                    Dim _3CImgName As String = objImgName.Substring(objImgName.Length - 4)

                    Select Case _3CImgName
                        Case "2D00"
                            ._04prop_Img2D = _pm02ByteArrayToImage(objIMG)
                    End Select
                Next
            Else
                MsgBox("data gambar tidak ada")
                ._04prop_Img2D = Nothing
            End If

            For i = 1 To Copiesto
                ._cm03PrintDoc(prmPrinterName)
            Next
        End With

    End Sub

#End Region

#Region "Grid Event"
    Private Sub _gvDMS_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles _gvDMS.CellValueChanged
        _gvDMS.PostEditor()

        If e.Column.FieldName = "bCheck" Then
            If CType(_gvDMS.GetFocusedRowCellValue("bCheck"), Boolean) = True Then
                _gvDMS.SetFocusedRowCellValue("nCheck", 1)
            Else
                _gvDMS.SetFocusedRowCellValue("nCheck", 0)
            End If
        ElseIf e.Column.FieldName = "Copyprint" Then
            If CType(_gvDMS.GetFocusedRowCellValue("Copyprint"), Integer) < 1 Then
                _gvDMS.SetFocusedRowCellValue("Copyprint", 1)
                MsgBox("Minimal Print = 1", MsgBoxStyle.Information, "Information")
            End If
        End If
    End Sub

#End Region

#Region "Control evnt"

    Private Sub _02cCheckAll_CheckedChanged(sender As Object, e As EventArgs) Handles _02cCheckAll.CheckedChanged
        _gvDMS.PostEditor()
        For Each dtRow As DataRow In prop_dtCheck.Rows
            If _02cCheckAll.Checked = True Then
                dtRow("nCheck") = 1
                dtRow("bCheck") = True
                MsgBox("Pilih semua")
            Else
                dtRow("nCheck") = 0
                dtRow("bCheck") = False
                MsgBox("Hapus Pilihan ")
            End If
        Next
        _gvDMS.RefreshData()
    End Sub

    Private Sub _btnPrint_Click(sender As Object, e As EventArgs) Handles _btnPrint.Click

        Dim CopyPrint As Integer
        Dim KodeDMS As String

        For Each dtRow As DataRow In prop_dtCheck.Rows
            If dtRow("nCheck") = 1 Then
                'Novalidation = dtRow("k01cKodeValidation_v50")
                KodeDMS = dtRow("k01cKodeDesignMaster_v50")
                CopyPrint = dtRow("Copyprint")

                _cm08Print2D(_01cCbprinterName.EditValue, "", KodeDMS, CopyPrint)
            End If
        Next
    End Sub

    Private Sub _btnShowPreview_Click(sender As Object, e As EventArgs) Handles _btnShowPreview.Click
        Dim Novalidation As String
        Dim KodeDMS As String

        For Each dtRow As DataRow In prop_dtCheck.Rows
            If dtRow("nCheck") = 1 Then
                'Novalidation = dtRow("k01cKodeValidation_v50")
                KodeDMS = dtRow("k01cKodeDesignMaster_v50")

                _cm07ShowPreview2D(_01cCbprinterName.EditValue, "", KodeDMS)
            End If
        Next
    End Sub


#End Region

End Class
