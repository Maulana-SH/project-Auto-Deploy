Imports System.Drawing.Printing
Imports DevExpress.Utils
Imports DevExpress.XtraGrid.Views.Base
Imports NCMODELlib

Public Class ucGridReprintBOM
    Implements IDisposable
    Public Property prop_gcUserID_v50 As String = ""
    Public Property prop_gcNamaUser_v50 As String = ""
    Public Property prop_gcTitle As String = ""
    Public Property prop_gcJudulForm As String = ""
    Public Property prop_objPicture As Byte()

    Public Property prop_cCheckBOM As DataTable '=> for cek colomn nCheck untuk Reprint
    Public Property _01prop_t32Product As DataTable
    Public Property _02prop_t25BOMCASTEDPARTS As DataTable
    Public Property _03prop_t26BOMFINDINGCOMPONENT As DataTable
    Public Property _04prop_t27BOMSTONES As DataTable
    Public Property _05prop_t20MASTERROUTING As DataTable

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

#End Region

#Region "From : event"
    Private Sub ucGridBOMReprint_Load(sender As Object, e As EventArgs) Handles Me.Load
        _cm02nitFillGrid()
        _pcm01GetPrinterName()
    End Sub
#End Region

#Region "Costum : Methods"

    Public Sub _cm01GetDataSource()
        Dim pdDataMaster20 As New DataTable
        Dim pdDataMaster25 As New DataTable
        Dim pdDataMaster26 As New DataTable
        Dim pdDataMaster27 As New DataTable
        Dim pdDataMaster32 As New DataTable

        'get t32Prodcut
        Using objMastert32 As clsMRP_iface = New clsMRP_impl With {
              .prop_KeyInt01 = 1,
              .prop_KeyString01 = "",
              .prop_KeyString02 = ""
            }
            pdDataMaster32 = objMastert32.Sele32PRODUCT
        End Using

        'get t20MasterRouting
        Using objSKKMaster20 As clsMRP_iface = New clsMRP_impl With {
              .prop_KeyString01 = "",
              .prop_KeyString02 = ""
            }
            pdDataMaster20 = objSKKMaster20.Sele20MASTERROUTING
        End Using

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

        _01prop_t32Product = pdDataMaster32
        _02prop_t25BOMCASTEDPARTS = pdDataMaster25
        _03prop_t26BOMFINDINGCOMPONENT = pdDataMaster26
        _04prop_t27BOMSTONES = pdDataMaster27
        _05prop_t20MASTERROUTING = pdDataMaster20
    End Sub

    Sub _cm02nitFillGrid()

        With _gvBOM

            With .Appearance

                With .HeaderPanel
                    .Options.UseBackColor = True
                    .TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center
                    .Font = New Font("Arial", 9, FontStyle.Bold, GraphicsUnit.Point)
                    '.BackColor = _cmColorByHtml(Backcolor_Panel01)
                    '.ForeColor = _cmColorByHtml(Textcolor_01)
                End With

            End With

            col01_k01cKodeProduct_v50.FieldName = "k01cKodeProduct_v50"
            col02_f02cKodeDesignMaster_v50.FieldName = "f02cKodeDesignMaster_v50"
            col03_f01cNamaProduct_v50.FieldName = "f01cNamaProduct_v50"
            col04_f05cTipeBRJDesc_v50.FieldName = "f04cNamaItemProduct_v50"
            col05_f06cSize_v50.FieldName = "f06cNamaBrand_v50"
            col06_f12cRawMaterialDesc_v50.FieldName = "f14cNamaSize_v50"
            col07_f32dCreatedDate.FieldName = "f42dCreatedDate"
            col08_CopiesPrint.FieldName = "Copyprint"
            col09_nCheck.FieldName = "nCheck"
            col09_nCheck.Visible = False
            col010_bCheck.FieldName = "bCheck"
            col010_bCheck.Caption = "Pilih"

            _gcBOM.DataSource = Nothing
            '_gcBOM.DataSource = _01prop_t32Product
            _gcBOM.DataSource = _pcm02COpyDataTabelForReprint(_01prop_t32Product)
            prop_cCheckBOM = _gcBOM.DataSource
            _gcBOM.Refresh()

        End With



    End Sub

#End Region

#Region "Control Event"

    Private Sub _02cBtnPrint_Click(sender As Object, e As EventArgs) Handles _02cBtnPrint.Click

        Dim clsCetakBOMFG As New clsMRPReprintPRO
        Dim clsCetakTD As New clsReprintTD

        Dim objReportParent As New BOMReportParent
        Dim CopyPrint As Integer
        Dim ProdcutCode As String

        For Each dtRow As DataRow In prop_cCheckBOM.Rows
            If dtRow("nCheck") = 1 Then
                ProdcutCode = dtRow("k01cKodeProduct_v50")
                CopyPrint = dtRow("Copyprint")

                With clsCetakBOMFG
                    .prop_01cProductCode = ProdcutCode
                    .prop_02cPRONumber = ""
                End With

                With clsCetakTD
                    .prop01_ProductCode = ProdcutCode
                End With

                ''looping perintah print 
                For i = 1 To CopyPrint
                    clsCetakBOMFG._01DisplayReportBOMFG()
                    clsCetakTD._02DisplayPreview()
                Next

            End If
        Next
    End Sub

    Private Sub _03cCheckAll_CheckedChanged(sender As Object, e As EventArgs) Handles _03cCheckAll.CheckedChanged
        _gvBOM.PostEditor()
        For Each dtRow As DataRow In prop_cCheckBOM.Rows
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

#Region "Grid Event"

    Private Sub _gvBOM_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles _gvBOM.CellValueChanged

        If e.Column.FieldName = "Copyprint" Then
            If CType(_gvBOM.GetFocusedRowCellValue("Copyprint"), Integer) < 1 Then
                _gvBOM.SetFocusedRowCellValue("Copyprint", 1)
                MsgBox("Minimal Print = 1", MsgBoxStyle.Information, "Information")
            End If
        End If

        If e.Column.FieldName = "bCheck" Then
            If CType(_gvBOM.GetFocusedRowCellValue("bCheck"), Boolean) = True Then
                _gvBOM.SetFocusedRowCellValue("nCheck", 1)
            Else
                _gvBOM.SetFocusedRowCellValue("nCheck", 0)
            End If
        End If

    End Sub


#End Region

End Class
