'********** create .NET Model : INTERFACE (property) ****************

Public Interface clsNEWCENTRAL_iface
     Inherits IDisposable

    Property prop_k01cNoKey_v50 As String
     Property prop_k01cKodeKaret_v50 As String
     Property prop_k01cSKU_v50 As String
     Property prop_k02nNoUrutMutasiProses_int As Integer
     Property prop_k03cIDProsesProduksi_v50 As String
    Property prop_k01guidKeys As Guid

    Property prop_tp01SKUSAJA As DataTable
    Property prop_tp20BAHANPERLENGKAPAN As DataTable
     Property prop_tp21CORERK As DataTable
    Property prop_tp22MUTASIRK As DataTable

    Property prop_tp22STOCKHARIANMUTASI As DataTable
    Property prop_tp22STOCKHARIANPOSTER As DataTable

    Property prop_tp23PROSESTUKANG As DataTable
    Property prop_tp23PROSESTUKANGPLKP As DataTable
    Property prop_tp24CORECOSTING As DataTable

    Property prop_tp25PROSESJCAD As DataTable
    Property prop_tp26PROSESGAGAL As DataTable
    Property prop_tp27PROSESLEBUR As DataTable
     Property prop_tp27STONEAWAL As DataTable
    Property prop_tp28HASILPROSESSTONE As DataTable
    Property prop_tp29HASILPROSESZIRCON As DataTable
    Property prop_tp30ZIRCONSISATAMBAH As DataTable
    Property prop_tp31DEPOSITBOX As DataTable

    'filter
    Property prop_01cTarget As String
    Property prop_02cUserID As String
    Property prop_03cKeyPass As String

    'create SKU
    Property prop_04cKodeSBU As String
    Property prop_05cIDAutoNumber As String
    Property prop_06nTahun_int As Int16
    Property prop_07nIncrementNumber As Int16

    Enum nTargetProses
        PPICAdminSPK = 0
    End Enum
    Property prop_08nTargetProses As nTargetProses 'dipakai di "spP6J502GetSKUBelumApprove"
    Property prop_09cKodeDivisi As String

    'DO Mutasi
    Property prop_10cNoDOMutasi As String
    Property prop_cNoDokumen As String


    'Menu Utama
    Property prop_11dTanggal As Date

    Property prop_NIKTukang As String
    Property prop_NoWOTukang As String

    'Parcel
    Property prop_k04cIDProsesStone_v50 As String
    Property prop_k05nNoBaris_int As Int32
    Property prop_f01cParcel_v50 As String

    'Report
    Property prop_nTarget As Int16
    Property prop_dTglAwal As Date
    Property prop_dTglAkhir As Date

    Property prop_cKodeOperatorJCad As String

    'Zircon Sisa Tambah
    Property prop_k01cNoZCSisaTambah_v50 As String

    'Perlengkapan
    Property prop_cNoPerlengkapan As String
    Property prop_cProsesPerlengkapan As String

    'Core JObcard

    Function Seley51NC() As DataTable 'for translate in mrp
    Sub Save06CoreJC()

    Sub Dele20BAHANPERLENGKAPAN()
    Sub Save20BAHANPERLENGKAPAN()
    Function Sele20BAHANPERLENGKAPAN() As DataTable
    Sub Dele24CORECOSTING()
    Sub Save24CORECOSTING()
    Function Sele24CORECOSTING() As DataTable

     Sub Dele21CORERK()
     Sub Save21CORERK()
    Function Sele21CORERK() As DataTable
    Function Get21LastNoUrutRO() As DataTable

    'Mutasi
     Sub Dele22MUTASIRK()
     Sub Save22MUTASIRK()
    Function Sele22MUTASIRK() As DataTable

    'New Mutasi / Stock Harian
    Sub Save22STOCKHARIANMUTASI()
    Sub Save22STOCKHARIANPOSTER()

    Sub Dele23PROSESTUKANG()
    Sub Save23PROSESTUKANG()
    Sub Save23PROSESTUKANGPLKP()
    Function Sele23PROSESTUKANG() As DataTable
    Function Sele23PROSESTUKANGPLKP() As DataTable

    'Proses Lebur
    Sub Save27PROSESLEBUR()
    Sub Dele27PROSESLEBUR()
    Function Sele27PROSESLEBUR() As DataTable


    'Stone - DIAMOND
    Sub Save28HASILPROSESSTONE()
    Sub Dele28HASILPROSESSTONE()
    Function Sele28HASILPROSESSTONE_NEW() As DataTable

    'Stone - ZIRCON
    Sub Save29HASILPROSESZIRCON()
    Sub Dele29HASILPROSESZIRCON()
    Function Sele29HASILPROSESZIRCON_NEW() As DataTable

    'Master
    Function Sele50AllMasterNewCentral() As DataTable
    Function Sele52AllProsesProduksi() As DataTable
    Function SeleMAsterCadtedPart() As DataTable
    Function Sele53AturanMutasi() As DataTable
    Function Sele54AllMasterStoneAll() As DataTable

    Function Get90UserMaster() As DataTable
    Function Get92CreateSKU() As DataTable
    Function GetSKUBelumApprove() As DataTable

    Sub UpdateTP6J501ApproveMutasi()

    'DO Mutasi
    Function GetTP6JX02DOMutasi() As DataTable

    'DO Mutasi
    Function GetDATABONPB() As DataTable

    'Proses Tukang
    Function GetP6KB01SKUProsesTK() As DataTable

    'Menu Utama
    Function GetP6KE01TrackingSKU() As DataTable
    Function GetP6KE02SaldoPerDivisiPerProses() As DataTable
    Function GetP6KG01SaldoSKU() As DataTable

    'SKU
    Function Getrepo21SKUFromMutasi() As DataTable

    'tringger Save ZC FromA khir Casting
    Sub SaveTP6KB02TriggerSaveZCFromAkhirCasting()

    'WIP Tukang
    Function GetP7BP01WIPTukang() As DataTable


    Function Get90USER() As DataTable
    'Proses JCad
    Function Get25PROSESJCADSele() As DataTable
    Sub Save25PROSESJCAD()

    'Zircon ==> Sisa-Tambah-Procurement
    Function GetTP7CG01ZirconSisaTambah() As DataTable
    Sub Save30ZIRCONSISATAMBAH()
    Function Sele30ZIRCONSISATAMBAH() As DataTable
    Sub Dele30ZIRCONSISATAMBAH()

    'Report
    Function GetP7DY01InOut() As DataTable
    Function GetR7G502CetakWOTukang() As DataTable
    Function GetR7HH02CetakPLKPTukang() As DataTable  'ini bahan perlengkapan dari WO Tukangnya.
    Function GetR7HH01CetakDOMutasi() As DataTable

    Function GetR7HO01CetakBonPBZircon() As DataTable

    Function GetR7HI01ListDataCetakDOTransferItem() As DataTable
    Function GetR7HI01ListDataCetakBonPBZircon() As DataTable
    Function GetR7HI01ListDataCetakWOTukang() As DataTable

    Function GetR7IL01PackingZircon() As DataTable
    Function GetR7IM01AdditionalZircon() As DataTable
    Function GetR7IN01GagalProduksi() As DataTable

    'Gagal Produksi
    Sub SaveP7HY01GagalProduksiCoreRKSave()

    'Lebur
    Function GetTP7IU01ProsesLebur() As DataTable
    Function GetTP7I201DataLeburForEditing() As DataTable
    Function GetR7JJ01InformasiLebur() As DataTable
    Sub DeleTP7I202DataLebur()

    'Tanggal Transaksi
    Sub Save59TANGGALTRANSAKSI()

    'Deposit Box
    Sub Save31DEPOSITBOX()
    Function Gett31DEPOSITBOX() As DataTable

    'Pohon Emas
    Property prop_k01cIDPohon_v50 As String
    Property prop_cKodeKadar_v50 As String
    Property prop_tp32POHONEMAS As DataTable
    Property prop_tp32POHONEMASSKU As DataTable

    Sub Save32POHONEMASSave()
    Sub Save32POHONEMASSKUSave()
    Function Get32POHONEMASSele() As DataTable
    Function GetTP7KT01PrepareDataGPCorEmas() As DataTable
    Function GetR7KW01PohonEmas() As DataTable

    Sub Update32POHONEMASTanggal()

    'COR Emas
    Property prop_tp32COREmas As DataTable
    Property prop_tp32CORAlloy As DataTable

    Sub Save32COREmas()

    'Rekap Harian
    Function GetRekapHarian() As DataTable

    'Rekap Susut
    Function GetRekapSusut() As DataTable

    Function GetWOTukang() As DataTable

    Property prop_tp33SUSUTLEDGER As DataTable
    Sub save33SUSUTLEDGER()

    Function GetTP8EY01OutstandingSB() As DataTable

    Function Get23CariWOTukang() As DataTable

    Function Get25ProsesJCADReport() As DataTable

    Function GetR8JA01RekapDebetKredit() As DataTable

    Function GetR8JE01RekapDebetKreditALL() As DataTable

    Function GetR9AY01BasePO() As DataTable

    Property prop_tp18TIMBANGAN As DataTable
    Function Sele18SKUPoster() As DataTable
    Sub Save18TIMBANGAN()

    Function GetTP9HV01TransferFG2Bridging() As DataTable
    Function GetTP9HV02TransferFG2BridgingPerDoc() As DataTable

    Property prop_tp29HASILPROSESZIRCONNEW As DataTable

    Sub Save29HASILPROSESZIRCONNEW()
    Function Sele29HASILPROSESZIRCONNEW() As DataTable

    Function Sele29LOGPROSESZIRCONNEW() As DataTable

    Function Seley100Kalenderkerja() As DataTable

    Function GetR9KC01GoldLossTKFinal() As DataTable
    Function GetR20BL01GambarStockProduksi() As DataTable
    Function GetR20EU01LeadTime() As DataTable
    Function GetR20EU01LeadTimeNew() As DataTable '(ini sebenarnya tdk terpakai, sdh diganti dgn 'GetR20EU01LeadTimeFinal')
    Function GetR20EU01LeadTimeFinal() As DataTable
    Function GetDataCurrent_Async() As Threading.Tasks.Task(Of DataTable)
    Function Sele25AM01RetransferDataInbound() As DataTable
    Function Sele25AM02GetDataInboundBySPK() As DataTable
    Function SeleTetsing() As DataTable

End Interface

'********** end of .NET Model : INTERFACE (property) ****************
