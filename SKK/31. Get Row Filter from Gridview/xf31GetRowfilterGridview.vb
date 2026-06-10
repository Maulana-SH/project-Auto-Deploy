Imports DevExpress.XtraGrid.Views.Base
Imports NCCONTROLLERlib

Public Class xf31GetRowfilterGridview
    Implements IDisposable

    Private pdt446 As DataTable
    Private ctrlDataFIlter As clsCtrlCasting446MASTERVAULT

#Region "From Evnt"
    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        pdt446 = New DataTable
        ctrlDataFIlter = New clsCtrlCasting446MASTERVAULT With {.prop_dt446MASTERVAULT = pdt446}
        ctrlDataFIlter.dtInit446MASTERVAULT()

    End Sub


    Private Sub xf31GetRowfilterGridview_Load(sender As Object, e As EventArgs) Handles Me.Load

        cm02Initfild()
    End Sub

#End Region

#Region "Custome Methods"

    Private Sub cm02Initfild()

        dtCol01_k01cKodeItemVault_v50.FieldName = "k01cKodeItemVault_v50"
        dtCol02_f01cNamaItemVault_v50.FieldName = "f01cNamaItemVault_v50"
        dtCol03_f09cNamaKadar_v50.FieldName = "f09cNamaKadar_v50"
        dtCol04_f07cNamaWarna_v50.FieldName = "f07cNamaWarna_v50"

        dtfCol01_k01cKodeItemVault_v50.FieldName = "k01cKodeItemVault_v50"
        dtfCol02_f01cNamaItemVault_v50.FieldName = "f01cNamaItemVault_v50"
        dtfCol03_f09cNamaKadar_v50.FieldName = "f09cNamaKadar_v50"
        dtfCol04_f07cNamaWarna_v50.FieldName = "f07cNamaWarna_v50"

        gcFilter.DataSource = Nothing
        gcFilter.DataSource = ctrlDataFIlter.prop_dt446MASTERVAULT

    End Sub

    Private Sub cm03GEtdata()

        Dim pdtHAsil As New DataTable

        pdtHAsil.Clear()

        Using objGetdata As NCMODELlib.clsMRP_iface = New NCMODELlib.clsMRP_impl
            pdtHAsil = objGetdata.sele446MASTERVAULT()
        End Using

        If pdtHAsil.Rows.Count > 0 Then

            gcData.DataSource = Nothing
            gcData.DataSource = pdtHAsil
            gcData.RefreshDataSource()

        End If

    End Sub

    Private Sub cm04GetGridFilter()
        'Senin , 26/12/2022

        'Notes JAdi yang di loping itu gridview nya
        ' untuk mendapatkan row yang di filter pada grid
        ' Bukan grid Control nya

        Dim prmJmlData As Integer = 0

        ctrlDataFIlter.prop_dt446MASTERVAULT.Clear()

        For i As Integer = 0 To gvData.RowCount - 1

            prmJmlData += 1
            Console.WriteLine(" Kode vault = " & gvData.GetRowCellValue(i, "f01cNamaItemVault_v50"))

            ctrlDataFIlter.dtAddNew446MASTERVAULT(gvData.GetRowCellValue(i, "k01cKodeItemVault_v50"),
                                                 gvData.GetRowCellValue(i, "f01cNamaItemVault_v50"),
                                                 gvData.GetRowCellValue(i, "f02cKodeGroupVault_v50"),
                                                 gvData.GetRowCellValue(i, "f03cNamaGroupVault_v50"),
                                                 gvData.GetRowCellValue(i, "f04cKodeRawMaterial_v50"),
                                                 gvData.GetRowCellValue(i, "f05cNamaRawMaterial_v50"),
                                                 gvData.GetRowCellValue(i, "f06cKodeWarna_v50"),
                                                 gvData.GetRowCellValue(i, "f07cNamaWarna_v50"),
                                                 gvData.GetRowCellValue(i, "f08cKodeKadar_v50"),
                                                 gvData.GetRowCellValue(i, "f09cNamaKadar_v50"),
                                                 gvData.GetRowCellValue(i, "f10cMerek_v50"),
                                                 gvData.GetRowCellValue(i, "f11cKodeSupplier_v50"),
                                                 gvData.GetRowCellValue(i, "f12cReserved_v50"),
                                                 gvData.GetRowCellValue(i, "f13cReserved_v50"),
                                                 gvData.GetRowCellValue(i, "f14nReserved_n92"),
                                                 gvData.GetRowCellValue(i, "f15nReserved_n92"),
                                                 gvData.GetRowCellValue(i, "f16nPosterSaldoInGram_n92"),
                                                 gvData.GetRowCellValue(i, "f17cKodeAlloy_v50"),
                                                 gvData.GetRowCellValue(i, "f18cNamaSubItemVault_v50"),
                                                 gvData.GetRowCellValue(i, "f20cUserIDCreate_v50"),
                                                 gvData.GetRowCellValue(i, "f21cUserNameCreate_v50"),
                                                 gvData.GetRowCellValue(i, "f22dTglCreate"),
                                                 gvData.GetRowCellValue(i, "f23cUserIDUpdate_v50"),
                                                 gvData.GetRowCellValue(i, "f24cUserNameUpdate_v50"),
                                                 gvData.GetRowCellValue(i, "f25dTglUpdate"))

            ctrlDataFIlter.prop_dt446MASTERVAULT.AcceptChanges()
            gvFilter.RefreshData()


        Next i

        Console.WriteLine(" jumlah Data = " & prmJmlData)

    End Sub

#End Region

#Region "Control Evnt"

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        cm03GEtdata()
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        cm04GetGridFilter()
    End Sub

    Private Sub btnLopingFilter_Click(sender As Object, e As EventArgs) Handles btnLopingFilter.Click
        ' gv data

    End Sub
#End Region

#Region "Grid Evnt"

#End Region


End Class