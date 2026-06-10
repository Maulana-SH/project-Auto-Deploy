Imports NCCONTROLLERlib
Imports NCMODELlib

Public Class clsAdd30MRP06NC

    Private pdt06CoreJC As DataTable
    Private ctrlNC06CoreJCSave As clsController06COREJOBCARD
    Public Sub New()

        'init class vr t06
        pdt06CoreJC = New DataTable
        ctrlNC06CoreJCSave = New clsController06COREJOBCARD With {.prop_dt06COREJOBCARD = pdt06CoreJC}
        ctrlNC06CoreJCSave.dtInit06COREJOBCARD()
    End Sub

#Region "CARA PAKAI CLASS"

    'Delcarasi awal
    'Dim cls30to06Nc As New clsAdd30MRP06NC

    'cls30to06Nc._cm01SaveData(prmValuenya)

#End Region

#Region "Custom Methods"

    Public Sub _cm01SaveData(ByVal prmk01cSKUJobCard_v50 As String, ByVal prmf01dTanggalEntry As Date, ByVal prmf02cJenisJobCard_v50 As String,
                                     ByVal prmf03cKodeDivisi_v50 As String, ByVal prmf04cKodeFinishGoods_v50 As String, ByVal prmf05cNoPO_v50 As String,
                                     ByVal prmf06cCustomer_v50 As String, ByVal prmf07cKodeKaretLama_v50 As String, ByVal prmf08cNORO_v50 As String,
                                     ByVal prmf09cKodeTipeBRJ_v50 As String, ByVal prmf10cKodeStockPesanan_v50 As String, ByVal prmf11nSize_int As Int32,
                                     ByVal prmf12cKodeRMJobCard_v50 As String, ByVal prmf13dTglDeliveryTime As Date, ByVal prmf14nJmlKomponent_int As Int32,
                                     ByVal prmf15nBeratAkhir_n92 As Double, ByVal prmf16nPoint_n92 As Double, ByVal prmf17cKodeSAP_v50 As String,
                                     ByVal prmf18cNamingProduct_v50 As String, ByVal prmf19cNamaProject_v50 As String, ByVal prmf20cDesigner_v50 As String,
                                     ByVal prmf21cAlasanRevisi_v50 As String, ByVal prmf22cKeterangan_v50 As String, ByVal prmf23cNamaGambar_v50 As String,
                                     ByVal prmf24dTglCloseJobCard As Date, ByVal prmf25cKodeTingkatKesulitan_v50 As String, ByVal prmf26cKodeBrandProduct_v50 As String)


        ctrlNC06CoreJCSave.prop_dt06COREJOBCARD.Clear()
        ctrlNC06CoreJCSave.dtAddNew06COREJOBCARD(prmk01cSKUJobCard_v50, prmf01dTanggalEntry, prmf02cJenisJobCard_v50,
                                                     prmf03cKodeDivisi_v50, prmf04cKodeFinishGoods_v50, prmf05cNoPO_v50, prmf06cCustomer_v50, prmf07cKodeKaretLama_v50,
                                                     prmf08cNORO_v50, prmf09cKodeTipeBRJ_v50, prmf10cKodeStockPesanan_v50, prmf11nSize_int, prmf12cKodeRMJobCard_v50,
                                                     prmf13dTglDeliveryTime, prmf14nJmlKomponent_int, prmf15nBeratAkhir_n92, prmf16nPoint_n92, prmf17cKodeSAP_v50,
                                                     prmf18cNamingProduct_v50, prmf19cNamaProject_v50, prmf20cDesigner_v50, prmf21cAlasanRevisi_v50,
                                                     prmf22cKeterangan_v50, prmf23cNamaGambar_v50, prmf24dTglCloseJobCard, prmf25cKodeTingkatKesulitan_v50,
                                                    prmf26cKodeBrandProduct_v50)

        Using objSavet35to06 As clsNEWCENTRAL_iface = New clsNEWCENTRAL_impl With {.prop_tp18TIMBANGAN = ctrlNC06CoreJCSave.prop_dt06COREJOBCARD}
            objSavet35to06.Save06CoreJC()
        End Using

    End Sub

#End Region

End Class
