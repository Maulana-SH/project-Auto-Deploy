'********** create .NET Model : IMPLEMENTS (method) ****************

Imports NCCORElib
Imports NCMODELlib

Public Class clsNEWCENTRAL_impl
    Implements clsNEWCENTRAL_iface

    Public Property prop_k01cNoKey_v50 As String Implements clsNEWCENTRAL_iface.prop_k01cNoKey_v50
    Public Property prop_k01cKodeKaret_v50 As String Implements clsNEWCENTRAL_iface.prop_k01cKodeKaret_v50
    Public Property prop_k01cSKU_v50 As String Implements clsNEWCENTRAL_iface.prop_k01cSKU_v50
    Public Property prop_k02nNoUrutMutasiProses_int As Integer Implements clsNEWCENTRAL_iface.prop_k02nNoUrutMutasiProses_int
    Public Property prop_k03cIDProsesProduksi_v50 As String Implements clsNEWCENTRAL_iface.prop_k03cIDProsesProduksi_v50

    Public Property prop_tp01SKUSAJA As DataTable Implements clsNEWCENTRAL_iface.prop_tp01SKUSAJA
    Public Property prop_tp21CORERK As DataTable Implements clsNEWCENTRAL_iface.prop_tp21CORERK
    Public Property prop_tp22MUTASIRK As DataTable Implements clsNEWCENTRAL_iface.prop_tp22MUTASIRK

    Public Property prop_tp23PROSESTUKANG As DataTable Implements clsNEWCENTRAL_iface.prop_tp23PROSESTUKANG
    Public Property prop_tp25PROSESJCAD As DataTable Implements clsNEWCENTRAL_iface.prop_tp25PROSESJCAD
    Public Property prop_tp27STONEAWAL As DataTable Implements clsNEWCENTRAL_iface.prop_tp27STONEAWAL
    Public Property prop_tp28HASILPROSESSTONE As DataTable Implements clsNEWCENTRAL_iface.prop_tp28HASILPROSESSTONE
    Public Property prop_tp29HASILPROSESZIRCON As DataTable Implements clsNEWCENTRAL_iface.prop_tp29HASILPROSESZIRCON

    Public Property prop_01cTarget As String Implements clsNEWCENTRAL_iface.prop_01cTarget
    Public Property prop_02cUserID As String Implements clsNEWCENTRAL_iface.prop_02cUserID
    Public Property prop_03cKeyPass As String Implements clsNEWCENTRAL_iface.prop_03cKeyPass

    Public Property prop_04cKodeSBU As String Implements clsNEWCENTRAL_iface.prop_04cKodeSBU
    Public Property prop_05cIDAutoNumber As String Implements clsNEWCENTRAL_iface.prop_05cIDAutoNumber
    Public Property prop_06nTahun_int As Short Implements clsNEWCENTRAL_iface.prop_06nTahun_int
    Public Property prop_07nIncrementNumber As Short Implements clsNEWCENTRAL_iface.prop_07nIncrementNumber
    Public Property prop_08nTargetProses As clsNEWCENTRAL_iface.nTargetProses Implements clsNEWCENTRAL_iface.prop_08nTargetProses
    Public Property prop_09cKodeDivisi As String Implements clsNEWCENTRAL_iface.prop_09cKodeDivisi
    Public Property prop_10cNoDOMutasi As String Implements clsNEWCENTRAL_iface.prop_10cNoDOMutasi
    Public Property prop_11dTanggal As Date Implements clsNEWCENTRAL_iface.prop_11dTanggal
    Public Property prop_k01guidKeys As Guid Implements clsNEWCENTRAL_iface.prop_k01guidKeys

    Public Property prop_tp20BAHANPERLENGKAPAN As DataTable Implements clsNEWCENTRAL_iface.prop_tp20BAHANPERLENGKAPAN

    Public Property prop_tp24CORECOSTING As DataTable Implements clsNEWCENTRAL_iface.prop_tp24CORECOSTING

    Public Property prop_f01cParcel_v50 As String Implements clsNEWCENTRAL_iface.prop_f01cParcel_v50

    Public Property prop_k04cIDProsesStone_v50 As String Implements clsNEWCENTRAL_iface.prop_k04cIDProsesStone_v50

    Public Property prop_k05nNoBaris_int As Integer Implements clsNEWCENTRAL_iface.prop_k05nNoBaris_int

    Public Property prop_dTglAkhir As Date Implements clsNEWCENTRAL_iface.prop_dTglAkhir

    Public Property prop_dTglAwal As Date Implements clsNEWCENTRAL_iface.prop_dTglAwal

    Public Property prop_nTarget As Short Implements clsNEWCENTRAL_iface.prop_nTarget

    Public Property prop_cKodeOperatorJCad As String Implements clsNEWCENTRAL_iface.prop_cKodeOperatorJCad

    Public Property prop_cNoDokumen As String Implements clsNEWCENTRAL_iface.prop_cNoDokumen
    Public Property prop_k01cNoZCSisaTambah_v50 As String Implements clsNEWCENTRAL_iface.prop_k01cNoZCSisaTambah_v50
    Public Property prop_cNoPerlengkapan As String Implements clsNEWCENTRAL_iface.prop_cNoPerlengkapan
    Public Property prop_cProsesPerlengkapan As String Implements clsNEWCENTRAL_iface.prop_cProsesPerlengkapan
    Public Property prop_tp30ZIRCONSISATAMBAH As DataTable Implements clsNEWCENTRAL_iface.prop_tp30ZIRCONSISATAMBAH
    Public Sub SaveTP6KB02TriggerSaveZCFromAkhirCasting() Implements clsNEWCENTRAL_iface.SaveTP6KB02TriggerSaveZCFromAkhirCasting
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P6_NameStoredProcedure = "spTP6KB02TriggerSaveZCFromAkhirCasting",
             .SAKA2011_PRM_01Param = "@tp01SKUSAJA", .SAKA2011_PRM_01Value = prop_tp01SKUSAJA}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Function Sele20BAHANPERLENGKAPAN() As DataTable Implements clsNEWCENTRAL_iface.Sele20BAHANPERLENGKAPAN
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P3_NamaDataSet = "sp20BAHANPERLENGKAPANSele",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "sp20BAHANPERLENGKAPANSele",
             .SAKA2011_PRM_01Param = "@nTarget", .SAKA2011_PRM_01Value = prop_nTarget,
             .SAKA2011_PRM_02Param = "@f02cNoPerlengkapan_v50", .SAKA2011_PRM_02Value = prop_cNoPerlengkapan,
             .SAKA2011_PRM_03Param = "@f07cKodeProsesPerlengkapan_v50", .SAKA2011_PRM_03Value = prop_cProsesPerlengkapan,
             .SAKA2011_PRM_04Param = "@dTglAwal", .SAKA2011_PRM_04Value = prop_dTglAwal,
             .SAKA2011_PRM_05Param = "@dTglAkhir", .SAKA2011_PRM_05Value = prop_dTglAkhir}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Sub Save20BAHANPERLENGKAPAN() Implements clsNEWCENTRAL_iface.Save20BAHANPERLENGKAPAN
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P6_NameStoredProcedure = "sp20BAHANPERLENGKAPANSave",
             .SAKA2011_PRM_01Param = "@tp20BAHANPERLENGKAPAN", .SAKA2011_PRM_01Value = prop_tp20BAHANPERLENGKAPAN}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Sub Dele20BAHANPERLENGKAPAN() Implements clsNEWCENTRAL_iface.Dele20BAHANPERLENGKAPAN
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P6_NameStoredProcedure = "sp20BAHANPERLENGKAPANDele",
             .SAKA2011_PRM_01Param = "@k01guidKeys", .SAKA2011_PRM_01Value = prop_k01guidKeys}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Sub Dele21CORERK() Implements clsNEWCENTRAL_iface.Dele21CORERK

        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P6_NameStoredProcedure = "sp21CORERKDele",
             .SAKA2011_PRM_01Param = "@k01cSKU_v50", .SAKA2011_PRM_01Value = prop_k01cSKU_v50}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using

    End Sub

    Public Sub Save21CORERK() Implements clsNEWCENTRAL_iface.Save21CORERK

        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P6_NameStoredProcedure = "sp21CORERKSave",
             .SAKA2011_PRM_01Param = "@tp21CORERK", .SAKA2011_PRM_01Value = prop_tp21CORERK}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using

    End Sub

    Public Function Sele21CORERK() As DataTable Implements clsNEWCENTRAL_iface.Sele21CORERK

        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P3_NamaDataSet = "sp21CORERKSele",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "sp21CORERKSele",
             .SAKA2011_PRM_01Param = "@k01cSKU_v50", .SAKA2011_PRM_01Value = prop_k01cSKU_v50}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)

    End Function

    Public Function Get21LastNoUrutRO() As DataTable Implements clsNEWCENTRAL_iface.Get21LastNoUrutRO
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P3_NamaDataSet = "sp21GetLastNoUrutRO",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "sp21GetLastNoUrutRO",
             .SAKA2011_PRM_01Param = "@f03cKodeKaret_v50", .SAKA2011_PRM_01Value = prop_k01cKodeKaret_v50}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Sub Dele22MUTASIRK() Implements clsNEWCENTRAL_iface.Dele22MUTASIRK

        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P6_NameStoredProcedure = "sp22MUTASIRKDele",
             .SAKA2011_PRM_01Param = "@k01cSKU_v50", .SAKA2011_PRM_01Value = prop_k01cSKU_v50,
             .SAKA2011_PRM_02Param = "@k02nNoUrutMutasiProses_int", .SAKA2011_PRM_02Value = prop_k02nNoUrutMutasiProses_int,
             .SAKA2011_PRM_03Param = "@k03cIDProsesProduksi_v50", .SAKA2011_PRM_03Value = prop_k03cIDProsesProduksi_v50}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using

    End Sub

    Public Sub Save22MUTASIRK() Implements clsNEWCENTRAL_iface.Save22MUTASIRK

        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P6_NameStoredProcedure = "sp22MUTASIRKSave",
             .SAKA2011_PRM_01Param = "@tp22MUTASIRK", .SAKA2011_PRM_01Value = prop_tp22MUTASIRK}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using

    End Sub

    Public Function Sele22MUTASIRK() As DataTable Implements clsNEWCENTRAL_iface.Sele22MUTASIRK

        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P3_NamaDataSet = "sp22MUTASIRKSele",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "sp22MUTASIRKSele",
             .SAKA2011_PRM_01Param = "@k01cSKU_v50", .SAKA2011_PRM_01Value = prop_k01cSKU_v50,
             .SAKA2011_PRM_02Param = "@k02nNoUrutMutasiProses_int", .SAKA2011_PRM_02Value = prop_k02nNoUrutMutasiProses_int,
             .SAKA2011_PRM_03Param = "@k03cIDProsesProduksi_v50", .SAKA2011_PRM_03Value = prop_k03cIDProsesProduksi_v50}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)

    End Function

    Public Sub Dele23PROSESTUKANG() Implements clsNEWCENTRAL_iface.Dele23PROSESTUKANG
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P6_NameStoredProcedure = "sp23PROSESTUKANGDele",
             .SAKA2011_PRM_01Param = "@k01cSKU_v50", .SAKA2011_PRM_01Value = prop_k01cSKU_v50,
             .SAKA2011_PRM_02Param = "@k02nNoUrutMutasiProses_int", .SAKA2011_PRM_02Value = prop_k02nNoUrutMutasiProses_int,
             .SAKA2011_PRM_03Param = "@k03cIDProsesProduksi_v50", .SAKA2011_PRM_03Value = prop_k03cIDProsesProduksi_v50}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Sub Save23PROSESTUKANG() Implements clsNEWCENTRAL_iface.Save23PROSESTUKANG
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P6_NameStoredProcedure = "sp23PROSESTUKANGSave",
             .SAKA2011_PRM_01Param = "@tp23PROSESTUKANG", .SAKA2011_PRM_01Value = prop_tp23PROSESTUKANG}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Function Sele23PROSESTUKANG() As DataTable Implements clsNEWCENTRAL_iface.Sele23PROSESTUKANG
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P3_NamaDataSet = "sp23PROSESTUKANGSele",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "sp23PROSESTUKANGSele",
             .SAKA2011_PRM_01Param = "@k01cSKU_v50", .SAKA2011_PRM_01Value = prop_k01cSKU_v50,
             .SAKA2011_PRM_02Param = "@k02nNoUrutMutasiProses_int", .SAKA2011_PRM_02Value = prop_k02nNoUrutMutasiProses_int,
             .SAKA2011_PRM_03Param = "@k03cIDProsesProduksi_v50", .SAKA2011_PRM_03Value = prop_k03cIDProsesProduksi_v50}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Sub Dele24CORECOSTING() Implements clsNEWCENTRAL_iface.Dele24CORECOSTING
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P6_NameStoredProcedure = "sp24CORECOSTINGDele",
             .SAKA2011_PRM_01Param = "@k01cSKU_v50", .SAKA2011_PRM_01Value = prop_k01cSKU_v50}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Sub Save24CORECOSTING() Implements clsNEWCENTRAL_iface.Save24CORECOSTING
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P6_NameStoredProcedure = "sp24CORECOSTINGSave",
             .SAKA2011_PRM_01Param = "@tp24CORECOSTING", .SAKA2011_PRM_01Value = prop_tp24CORECOSTING}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Function Sele24CORECOSTING() As DataTable Implements clsNEWCENTRAL_iface.Sele24CORECOSTING
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P3_NamaDataSet = "sp24CORECOSTINGSele",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "sp24CORECOSTINGSele",
             .SAKA2011_PRM_01Param = "@k01cSKU_v50", .SAKA2011_PRM_01Value = prop_k01cSKU_v50}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Sub Save28HASILPROSESSTONE() Implements clsNEWCENTRAL_iface.Save28HASILPROSESSTONE

        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P6_NameStoredProcedure = "sp28HASILPROSESSTONESave",
             .SAKA2011_PRM_01Param = "@tp28HASILPROSESSTONE", .SAKA2011_PRM_01Value = prop_tp28HASILPROSESSTONE}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using

    End Sub

    Public Sub Dele28HASILPROSESSTONE() Implements clsNEWCENTRAL_iface.Dele28HASILPROSESSTONE
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P6_NameStoredProcedure = "sp28HASILPROSESSTONEDele",
             .SAKA2011_PRM_01Param = "@k01cSKU_v50", .SAKA2011_PRM_01Value = prop_k01cSKU_v50,
             .SAKA2011_PRM_02Param = "@k04cIDProsesStone_v50", .SAKA2011_PRM_02Value = prop_k04cIDProsesStone_v50,
             .SAKA2011_PRM_03Param = "@k05nNoBaris_int", .SAKA2011_PRM_03Value = prop_k05nNoBaris_int,
             .SAKA2011_PRM_04Param = "@f01cParcel_v50", .SAKA2011_PRM_04Value = prop_f01cParcel_v50}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Function Sele28HASILPROSESSTONE_NEW() As DataTable Implements clsNEWCENTRAL_iface.Sele28HASILPROSESSTONE_NEW
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P3_NamaDataSet = "sp28HASILPROSESSTONESele_NEW",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "sp28HASILPROSESSTONESele_NEW",
             .SAKA2011_PRM_01Param = "@k01cSKU_v50", .SAKA2011_PRM_01Value = prop_k01cSKU_v50,
             .SAKA2011_PRM_02Param = "@k04cIDProsesStone_v50", .SAKA2011_PRM_02Value = prop_k04cIDProsesStone_v50}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Sub Dele29HASILPROSESZIRCON() Implements clsNEWCENTRAL_iface.Dele29HASILPROSESZIRCON
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P6_NameStoredProcedure = "sp29HASILPROSESZIRCONDele",
             .SAKA2011_PRM_01Param = "@k01cSKU_v50", .SAKA2011_PRM_01Value = prop_k01cSKU_v50,
             .SAKA2011_PRM_02Param = "@k02cIDProsesStone_v50", .SAKA2011_PRM_02Value = prop_k04cIDProsesStone_v50,
             .SAKA2011_PRM_03Param = "@k03nNoBaris_int", .SAKA2011_PRM_03Value = prop_k05nNoBaris_int}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Sub Save29HASILPROSESZIRCON() Implements clsNEWCENTRAL_iface.Save29HASILPROSESZIRCON
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P6_NameStoredProcedure = "sp29HASILPROSESZIRCONSave",
             .SAKA2011_PRM_01Param = "@tp29HASILPROSESZIRCON", .SAKA2011_PRM_01Value = prop_tp29HASILPROSESZIRCON}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Function Sele29HASILPROSESZIRCON_NEW() As DataTable Implements clsNEWCENTRAL_iface.Sele29HASILPROSESZIRCON_NEW
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P3_NamaDataSet = "sp29HASILPROSESZIRCONSele_NEW",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "sp29HASILPROSESZIRCONSele_NEW",
             .SAKA2011_PRM_01Param = "@k01cSKU_v50", .SAKA2011_PRM_01Value = prop_k01cSKU_v50,
             .SAKA2011_PRM_02Param = "@k02cIDProsesStone_v50", .SAKA2011_PRM_02Value = prop_k04cIDProsesStone_v50,
             .SAKA2011_PRM_03Param = "@tp29HASILPROSESZIRCON_sele", .SAKA2011_PRM_03Value = prop_tp29HASILPROSESZIRCON}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function Sele50AllMasterNewCentral() As DataTable Implements clsNEWCENTRAL_iface.Sele50AllMasterNewCentral
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P3_NamaDataSet = "sp50MasterAllNewCentral",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "sp50MasterAllNewCentral"}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function Sele52AllProsesProduksi() As DataTable Implements clsNEWCENTRAL_iface.Sele52AllProsesProduksi
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P3_NamaDataSet = "sp52MasterAllProsesProduksi",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "sp52MasterAllProsesProduksi",
             .SAKA2011_PRM_01Param = "@cTarget", .SAKA2011_PRM_01Value = prop_01cTarget,
             .SAKA2011_PRM_02Param = "@f01cUserID_v50", .SAKA2011_PRM_02Value = prop_02cUserID}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function SeleMAsterCadtedPart() As DataTable Implements clsNEWCENTRAL_iface.SeleMAsterCadtedPart
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
             .SAKA2011_P3_NamaDataSet = "spGetMaterial",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "spGetMaterial",
             .SAKA2011_PRM_01Param = "@nTarget", .SAKA2011_PRM_01Value = prop_nTarget,
             .SAKA2011_PRM_02Param = "@cKodeItem", .SAKA2011_PRM_02Value = prop_k01cNoKey_v50}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function Sele53AturanMutasi() As DataTable Implements clsNEWCENTRAL_iface.Sele53AturanMutasi
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P3_NamaDataSet = "sp53ATURANMUTASISele",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "sp53ATURANMUTASISele"}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function Sele54AllMasterStoneAll() As DataTable Implements clsNEWCENTRAL_iface.Sele54AllMasterStoneAll
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P3_NamaDataSet = "sp54MasterStoneAll",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "sp54MasterStoneAll"}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function Get90User() As DataTable Implements clsNEWCENTRAL_iface.Get90User
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P3_NamaDataSet = "sp90GetUser",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "sp90GetUser",
             .SAKA2011_PRM_01Param = "@k01cUserID_v50", .SAKA2011_PRM_01Value = prop_02cUserID,
             .SAKA2011_PRM_02Param = "@f02cKeyPass_v50", .SAKA2011_PRM_02Value = prop_03cKeyPass}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function Get92CreateSKU() As DataTable Implements clsNEWCENTRAL_iface.Get92CreateSKU
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P3_NamaDataSet = "sp92CreateSKU",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "sp92CreateSKU",
             .SAKA2011_PRM_01Param = "@f01cKodeSBU_v50", .SAKA2011_PRM_01Value = prop_04cKodeSBU,
             .SAKA2011_PRM_02Param = "@f02cIDAutoNumber_v50", .SAKA2011_PRM_02Value = prop_05cIDAutoNumber,
             .SAKA2011_PRM_03Param = "@f06nTahun_int", .SAKA2011_PRM_03Value = prop_06nTahun_int,
             .SAKA2011_PRM_04Param = "@nIncrementNumber", .SAKA2011_PRM_04Value = prop_07nIncrementNumber}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Sub UpdateTP6J501ApproveMutasi() Implements clsNEWCENTRAL_iface.UpdateTP6J501ApproveMutasi

        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P6_NameStoredProcedure = "spTP6J501UpdateApproveMutasi",
             .SAKA2011_PRM_01Param = "@nTargetProses", .SAKA2011_PRM_01Value = prop_08nTargetProses,
             .SAKA2011_PRM_02Param = "@tp22MUTASIRK", .SAKA2011_PRM_02Value = prop_tp22MUTASIRK,
             .SAKA2011_PRM_03Param = "@cIDProsesProduksi_v50", .SAKA2011_PRM_03Value = prop_k03cIDProsesProduksi_v50}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using

    End Sub

    Public Function GetSKUBelumApprove() As DataTable Implements clsNEWCENTRAL_iface.GetSKUBelumApprove
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P3_NamaDataSet = "spP6J502GetSKUBelumApprove",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "spP6J502GetSKUBelumApprove",
             .SAKA2011_PRM_01Param = "@nTargetProses", .SAKA2011_PRM_01Value = prop_08nTargetProses,
             .SAKA2011_PRM_02Param = "@k03cIDProsesProduksi_v50", .SAKA2011_PRM_02Value = prop_k03cIDProsesProduksi_v50,
             .SAKA2011_PRM_03Param = "@f01cKodeDivisiPengrajin_v50", .SAKA2011_PRM_03Value = prop_09cKodeDivisi}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function GetTP6JX02DOMutasi() As DataTable Implements clsNEWCENTRAL_iface.GetTP6JX02DOMutasi
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P3_NamaDataSet = "spTP6JX02DOMutasi",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "spTP6JX02DOMutasi",
             .SAKA2011_PRM_01Param = "@nTargetProses", .SAKA2011_PRM_01Value = prop_08nTargetProses,
             .SAKA2011_PRM_02Param = "@k03cIDProsesProduksi_v50", .SAKA2011_PRM_02Value = prop_k03cIDProsesProduksi_v50,
             .SAKA2011_PRM_03Param = "@f01cKodeDivisiPengrajin_v50", .SAKA2011_PRM_03Value = prop_09cKodeDivisi,
             .SAKA2011_PRM_04Param = "@f02cNoDOMutasi_v50", .SAKA2011_PRM_04Value = prop_10cNoDOMutasi}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function


    Public Function GetDATABONPB() As DataTable Implements clsNEWCENTRAL_iface.GetDATABONPB
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P3_NamaDataSet = "spR7HI01ListDataCetakBonPBZircon",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "spR7HI01ListDataCetakBonPBZircon",
             .SAKA2011_PRM_01Param = "@k02cIDProsesStone_v50", .SAKA2011_PRM_01Value = prop_k01cNoKey_v50}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function GetP6KB01SKUProsesTK() As DataTable Implements clsNEWCENTRAL_iface.GetP6KB01SKUProsesTK
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P3_NamaDataSet = "spP6KB01GetSKUProsesTK",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "spP6KB01GetSKUProsesTK",
             .SAKA2011_PRM_01Param = "@nTargetProses", .SAKA2011_PRM_01Value = prop_08nTargetProses,
             .SAKA2011_PRM_02Param = "@cIDProsesProduksi", .SAKA2011_PRM_02Value = prop_k03cIDProsesProduksi_v50,
             .SAKA2011_PRM_03Param = "@cKodeDivisiPengrajin", .SAKA2011_PRM_03Value = prop_09cKodeDivisi,
             .SAKA2011_PRM_04Param = "@f02cNIKTukang_v50", .SAKA2011_PRM_04Value = prop_NIKTukang}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function GetP6KE01TrackingSKU() As DataTable Implements clsNEWCENTRAL_iface.GetP6KE01TrackingSKU
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P3_NamaDataSet = "spP6KE01TrackingSKU",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "spP6KE01TrackingSKU",
             .SAKA2011_PRM_01Param = "@k01cSKU_v50", .SAKA2011_PRM_01Value = prop_k01cSKU_v50}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function GetP6KE02SaldoPerDivisiPerProses() As DataTable Implements clsNEWCENTRAL_iface.GetP6KE02SaldoPerDivisiPerProses
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P3_NamaDataSet = "spP6KE02SaldoPerDivisiPerProses",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "spP6KE02SaldoPerDivisiPerProses",
             .SAKA2011_PRM_01Param = "@dTglStock", .SAKA2011_PRM_01Value = prop_11dTanggal}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function GetP6KG01SaldoSKU() As DataTable Implements clsNEWCENTRAL_iface.GetP6KG01SaldoSKU
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P3_NamaDataSet = "spP6KG01SaldoSKU",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "spP6KG01SaldoSKU",
             .SAKA2011_PRM_01Param = "@nTarget", .SAKA2011_PRM_01Value = prop_nTarget,
             .SAKA2011_PRM_02Param = "@dTglStock", .SAKA2011_PRM_02Value = prop_11dTanggal}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function Getrepo21SKUFromMutasi() As DataTable Implements clsNEWCENTRAL_iface.Getrepo21SKUFromMutasi

        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P3_NamaDataSet = "sprepo21SKUFromMutasi",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "sprepo21SKUFromMutasi",
             .SAKA2011_PRM_01Param = "@cIDProsesProduksi", .SAKA2011_PRM_01Value = prop_k03cIDProsesProduksi_v50,
             .SAKA2011_PRM_02Param = "@cKodeDivisiPengrajin", .SAKA2011_PRM_02Value = prop_09cKodeDivisi}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)

    End Function

    Public Function GetP7BP01WIPTukang() As DataTable Implements clsNEWCENTRAL_iface.GetP7BP01WIPTukang
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P3_NamaDataSet = "sprptP7BP01WIPTukang",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "sprptP7BP01WIPTukang",
             .SAKA2011_PRM_01Param = "@nTarget", .SAKA2011_PRM_01Value = prop_nTarget,
             .SAKA2011_PRM_02Param = "@dTglAwal", .SAKA2011_PRM_02Value = prop_dTglAwal,
             .SAKA2011_PRM_03Param = "@dTglAkhir", .SAKA2011_PRM_03Value = prop_dTglAkhir}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function Get25PROSESJCADSele() As DataTable Implements clsNEWCENTRAL_iface.Get25PROSESJCADSele
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P3_NamaDataSet = "sp25PROSESJCADSele",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "sp25PROSESJCADSele",
             .SAKA2011_PRM_01Param = "@nTarget_int", .SAKA2011_PRM_01Value = prop_nTarget,
             .SAKA2011_PRM_02Param = "@cKodeDivisiPengrajin_v50", .SAKA2011_PRM_02Value = prop_09cKodeDivisi,
             .SAKA2011_PRM_03Param = "@cKodeOperatorJCad_v50", .SAKA2011_PRM_03Value = prop_cKodeOperatorJCad,
             .SAKA2011_PRM_04Param = "@k03cIDProsesProduksi_v50", .SAKA2011_PRM_04Value = prop_k03cIDProsesProduksi_v50}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Sub Save25PROSESJCAD() Implements clsNEWCENTRAL_iface.Save25PROSESJCAD
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P6_NameStoredProcedure = "sp25PROSESJCADSave",
             .SAKA2011_PRM_01Param = "@tp25PROSESJCAD", .SAKA2011_PRM_01Value = prop_tp25PROSESJCAD}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Function GetTP7CG01ZirconSisaTambah() As DataTable Implements clsNEWCENTRAL_iface.GetTP7CG01ZirconSisaTambah
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P3_NamaDataSet = "spTP7CG01ZirconSisaTambah",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "spTP7CG01ZirconSisaTambah",
             .SAKA2011_PRM_01Param = "@nTargetProses", .SAKA2011_PRM_01Value = prop_nTarget,
             .SAKA2011_PRM_02Param = "@f01cKodeDivisiPengrajin_v50", .SAKA2011_PRM_02Value = prop_09cKodeDivisi,
             .SAKA2011_PRM_03Param = "@cNoDokumen_v50", .SAKA2011_PRM_03Value = prop_cNoDokumen}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function


    Public Function Get90UserMaster() As DataTable Implements clsNEWCENTRAL_iface.Get90UserMaster
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P3_NamaDataSet = "sp90USERSele",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "sp90USERSele",
             .SAKA2011_PRM_01Param = "@nTarget", .SAKA2011_PRM_01Value = prop_nTarget,
             .SAKA2011_PRM_02Param = "@k01cUserID_v50", .SAKA2011_PRM_02Value = prop_02cUserID}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Sub Save30ZIRCONSISATAMBAH() Implements clsNEWCENTRAL_iface.Save30ZIRCONSISATAMBAH
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P6_NameStoredProcedure = "sp30ZIRCONSISATAMBAHSave",
             .SAKA2011_PRM_01Param = "@tp30ZIRCONSISATAMBAH", .SAKA2011_PRM_01Value = prop_tp30ZIRCONSISATAMBAH}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Function Sele30ZIRCONSISATAMBAH() As DataTable Implements clsNEWCENTRAL_iface.Sele30ZIRCONSISATAMBAH
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P3_NamaDataSet = "sp30ZIRCONSISATAMBAHSele",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "sp30ZIRCONSISATAMBAHSele",
             .SAKA2011_PRM_01Param = "@nTargetProses", .SAKA2011_PRM_01Value = prop_nTarget,
             .SAKA2011_PRM_02Param = "@k01cNoZCSisaTambah_v50", .SAKA2011_PRM_02Value = prop_k01cNoZCSisaTambah_v50,
             .SAKA2011_PRM_03Param = "@k02cSKU_v50", .SAKA2011_PRM_03Value = prop_k01cSKU_v50,
             .SAKA2011_PRM_04Param = "@k03cIDProsesStone_v50", .SAKA2011_PRM_04Value = prop_k04cIDProsesStone_v50}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function GetP7DY01InOut() As DataTable Implements clsNEWCENTRAL_iface.GetP7DY01InOut
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P3_NamaDataSet = "sprptP7DY01InOut",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "sprptP7DY01InOut",
             .SAKA2011_PRM_01Param = "@dTglAwal", .SAKA2011_PRM_01Value = prop_dTglAwal,
             .SAKA2011_PRM_02Param = "@dTglAkhir", .SAKA2011_PRM_02Value = prop_dTglAkhir,
             .SAKA2011_PRM_03Param = "@cKodeDivisiPengrajin_v50", .SAKA2011_PRM_03Value = prop_09cKodeDivisi,
             .SAKA2011_PRM_04Param = "@cIDProsesProduksi_v50", .SAKA2011_PRM_04Value = prop_k03cIDProsesProduksi_v50,
             .SAKA2011_PRM_05Param = "@nTargetInOut", .SAKA2011_PRM_05Value = prop_nTarget}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function GetR7G502CetakWOTukang() As DataTable Implements clsNEWCENTRAL_iface.GetR7G502CetakWOTukang
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P3_NamaDataSet = "sprptR7G502CetakWOTukang",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "sprptR7G502CetakWOTukang",
             .SAKA2011_PRM_01Param = "@k01cSKU_v50", .SAKA2011_PRM_01Value = prop_k01cSKU_v50}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Property prop_NIKTukang As String Implements clsNEWCENTRAL_iface.prop_NIKTukang

    Public Property prop_tp23PROSESTUKANGPLKP As DataTable Implements clsNEWCENTRAL_iface.prop_tp23PROSESTUKANGPLKP

    Public Sub Save23PROSESTUKANGPLKP() Implements clsNEWCENTRAL_iface.Save23PROSESTUKANGPLKP
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
              .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
              .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
              .SAKA2011_P6_NameStoredProcedure = "sp23PROSESTUKANGPLKPSave",
              .SAKA2011_PRM_01Param = "@tp23PROSESTUKANGPLKP", .SAKA2011_PRM_01Value = prop_tp23PROSESTUKANGPLKP}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Property prop_NoWOTukang As String Implements clsNEWCENTRAL_iface.prop_NoWOTukang

    Public Function Sele23PROSESTUKANGPLKP() As DataTable Implements clsNEWCENTRAL_iface.Sele23PROSESTUKANGPLKP
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P3_NamaDataSet = "sp23PROSESTUKANGPLKPSele",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "sp23PROSESTUKANGPLKPSele",
             .SAKA2011_PRM_01Param = "@nTarget", .SAKA2011_PRM_01Value = prop_nTarget,
             .SAKA2011_PRM_02Param = "@k01cNoWorkOrderTK_v50", .SAKA2011_PRM_02Value = prop_NoWOTukang,
             .SAKA2011_PRM_03Param = "@dTglAwal", .SAKA2011_PRM_03Value = prop_dTglAwal,
             .SAKA2011_PRM_04Param = "@dTglAkhir", .SAKA2011_PRM_04Value = prop_dTglAkhir}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function GetR7HH01CetakDOMutasi() As DataTable Implements clsNEWCENTRAL_iface.GetR7HH01CetakDOMutasi
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P3_NamaDataSet = "sprptR7HH01CetakDOMutasi",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "sprptR7HH01CetakDOMutasi",
             .SAKA2011_PRM_01Param = "@f01cKodeDivisiPengrajin_v50", .SAKA2011_PRM_01Value = prop_09cKodeDivisi,
             .SAKA2011_PRM_02Param = "@k03cIDProsesProduksi_v50", .SAKA2011_PRM_02Value = prop_k03cIDProsesProduksi_v50,
             .SAKA2011_PRM_03Param = "@f02cNoDOMutasi_v50", .SAKA2011_PRM_03Value = prop_10cNoDOMutasi,
             .SAKA2011_PRM_04Param = "@nTarget", .SAKA2011_PRM_04Value = prop_nTarget}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function GetR7HH02CetakPLKPTukang() As DataTable Implements clsNEWCENTRAL_iface.GetR7HH02CetakPLKPTukang
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P3_NamaDataSet = "sprptR7HH02CetakPLKPTukang",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "sprptR7HH02CetakPLKPTukang",
             .SAKA2011_PRM_01Param = "@k01cNoWorkOrderTK_v50", .SAKA2011_PRM_01Value = prop_NoWOTukang}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function GetR7HO01CetakBonPBZircon() As DataTable Implements clsNEWCENTRAL_iface.GetR7HO01CetakBonPBZircon
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P3_NamaDataSet = "sprptR7HO01CetakBonPBZircon",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "sprptR7HO01CetakBonPBZircon",
             .SAKA2011_PRM_01Param = "@k01cSKU_v50", .SAKA2011_PRM_01Value = prop_k01cSKU_v50,
             .SAKA2011_PRM_02Param = "@k02cIDProsesStone_v50", .SAKA2011_PRM_02Value = prop_k04cIDProsesStone_v50}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Property prop_tp26PROSESGAGAL As DataTable Implements clsNEWCENTRAL_iface.prop_tp26PROSESGAGAL

    Public Sub SaveP7HY01GagalProduksiCoreRKSave() Implements clsNEWCENTRAL_iface.SaveP7HY01GagalProduksiCoreRKSave
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P6_NameStoredProcedure = "spP7HY01GagalProduksiCoreRKSave",
             .SAKA2011_PRM_01Param = "@tp26PROSESGAGAL", .SAKA2011_PRM_01Value = prop_tp26PROSESGAGAL}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Function GetR7HI01ListDataCetakBonPBZircon() As DataTable Implements clsNEWCENTRAL_iface.GetR7HI01ListDataCetakBonPBZircon
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P3_NamaDataSet = "spR7HI01ListDataCetakBonPBZircon",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "spR7HI01ListDataCetakBonPBZircon",
             .SAKA2011_PRM_01Param = "@k02cIDProsesStone_v50", .SAKA2011_PRM_01Value = prop_k04cIDProsesStone_v50}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function GetR7HI01ListDataCetakDOTransferItem() As DataTable Implements clsNEWCENTRAL_iface.GetR7HI01ListDataCetakDOTransferItem
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P3_NamaDataSet = "spR7HI01ListDataCetakDOTransferItem",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "spR7HI01ListDataCetakDOTransferItem",
             .SAKA2011_PRM_01Param = "@f01cKodeDivisiPengrajin_v50", .SAKA2011_PRM_01Value = prop_09cKodeDivisi,
             .SAKA2011_PRM_02Param = "@k03cIDProsesProduksi_v50", .SAKA2011_PRM_02Value = prop_k03cIDProsesProduksi_v50}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function GetR7HI01ListDataCetakWOTukang() As DataTable Implements clsNEWCENTRAL_iface.GetR7HI01ListDataCetakWOTukang
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P3_NamaDataSet = "spR7HI01ListDataCetakWOTukang",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "spR7HI01ListDataCetakWOTukang",
             .SAKA2011_PRM_01Param = "@k03cIDProsesProduksi_v50", .SAKA2011_PRM_01Value = prop_k03cIDProsesProduksi_v50,
             .SAKA2011_PRM_02Param = "@f01cKodeDivisiPengrajin_v50", .SAKA2011_PRM_02Value = prop_09cKodeDivisi,
             .SAKA2011_PRM_03Param = "@f02cNIKTukang_v50", .SAKA2011_PRM_03Value = prop_NIKTukang}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function GetR7IL01PackingZircon() As DataTable Implements clsNEWCENTRAL_iface.GetR7IL01PackingZircon
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
            .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
            .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
            .SAKA2011_P3_NamaDataSet = "sprptR7IL01PackingZircon",
            .SAKA2011_P4_ObjectDataSet = dsDataSet,
            .SAKA2011_P6_NameStoredProcedure = "sprptR7IL01PackingZircon",
            .SAKA2011_PRM_01Param = "@nTarget", .SAKA2011_PRM_01Value = prop_nTarget,
            .SAKA2011_PRM_02Param = "@dTglAwal", .SAKA2011_PRM_02Value = prop_dTglAwal,
            .SAKA2011_PRM_03Param = "@dTglAkhir", .SAKA2011_PRM_03Value = prop_dTglAkhir}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function GetR7IM01AdditionalZircon() As DataTable Implements clsNEWCENTRAL_iface.GetR7IM01AdditionalZircon
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
            .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
            .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
            .SAKA2011_P3_NamaDataSet = "sprptR7IM01AdditionalZircon",
            .SAKA2011_P4_ObjectDataSet = dsDataSet,
            .SAKA2011_P6_NameStoredProcedure = "sprptR7IM01AdditionalZircon",
            .SAKA2011_PRM_01Param = "@nTarget", .SAKA2011_PRM_01Value = prop_nTarget,
            .SAKA2011_PRM_02Param = "@dTglAwal", .SAKA2011_PRM_02Value = prop_dTglAwal,
            .SAKA2011_PRM_03Param = "@dTglAkhir", .SAKA2011_PRM_03Value = prop_dTglAkhir}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function GetR7IN01GagalProduksi() As DataTable Implements clsNEWCENTRAL_iface.GetR7IN01GagalProduksi
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
            .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
            .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
            .SAKA2011_P3_NamaDataSet = "sprptR7IN01GagalProduksi",
            .SAKA2011_P4_ObjectDataSet = dsDataSet,
            .SAKA2011_P6_NameStoredProcedure = "sprptR7IN01GagalProduksi",
            .SAKA2011_PRM_01Param = "@nTarget", .SAKA2011_PRM_01Value = prop_nTarget,
            .SAKA2011_PRM_02Param = "@dTglAwal", .SAKA2011_PRM_02Value = prop_dTglAwal,
            .SAKA2011_PRM_03Param = "@dTglAkhir", .SAKA2011_PRM_03Value = prop_dTglAkhir}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Sub Dele30ZIRCONSISATAMBAH() Implements clsNEWCENTRAL_iface.Dele30ZIRCONSISATAMBAH
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
            .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
            .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
            .SAKA2011_P6_NameStoredProcedure = "sp30ZIRCONSISATAMBAHDele",
            .SAKA2011_PRM_01Param = "@k01cNoZCSisaTambah_v50", .SAKA2011_PRM_01Value = prop_cNoDokumen,
            .SAKA2011_PRM_02Param = "@k02cSKU_v50", .SAKA2011_PRM_02Value = prop_k01cSKU_v50,
            .SAKA2011_PRM_03Param = "@k03cIDProsesStone_v50", .SAKA2011_PRM_03Value = prop_k04cIDProsesStone_v50,
            .SAKA2011_PRM_04Param = "@k04nNoBaris_int", .SAKA2011_PRM_04Value = prop_k05nNoBaris_int}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub
    Public Property prop_tp27PROSESLEBUR As DataTable Implements clsNEWCENTRAL_iface.prop_tp27PROSESLEBUR
    Public Sub Dele27PROSESLEBUR() Implements clsNEWCENTRAL_iface.Dele27PROSESLEBUR
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
                .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
                .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
                .SAKA2011_P6_NameStoredProcedure = "sp27PROSESLEBURDele",
                .SAKA2011_PRM_01Param = "@guidKeyLebur", .SAKA2011_PRM_01Value = prop_k01guidKeys}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Sub Save27PROSESLEBUR() Implements clsNEWCENTRAL_iface.Save27PROSESLEBUR
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
                .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
                .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
                .SAKA2011_P6_NameStoredProcedure = "sp27PROSESLEBURSave",
                .SAKA2011_PRM_01Param = "@tp27PROSESLEBUR", .SAKA2011_PRM_01Value = prop_tp27PROSESLEBUR}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Function Sele27PROSESLEBUR() As DataTable Implements clsNEWCENTRAL_iface.Sele27PROSESLEBUR
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
                .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
                .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
                .SAKA2011_P3_NamaDataSet = "sp27PROSESLEBURSele",
                .SAKA2011_P4_ObjectDataSet = dsDataSet,
                .SAKA2011_P6_NameStoredProcedure = "sp27PROSESLEBURSele",
                .SAKA2011_PRM_01Param = "@nTarget", .SAKA2011_PRM_01Value = prop_nTarget,
                .SAKA2011_PRM_02Param = "@k01cNoDokumentasiProses_v50", .SAKA2011_PRM_02Value = prop_cNoDokumen}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function GetTP7IU01ProsesLebur() As DataTable Implements clsNEWCENTRAL_iface.GetTP7IU01ProsesLebur
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
            .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
            .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
            .SAKA2011_P3_NamaDataSet = "spTP7IU01ProsesLebur",
            .SAKA2011_P4_ObjectDataSet = dsDataSet,
            .SAKA2011_P6_NameStoredProcedure = "spTP7IU01ProsesLebur",
            .SAKA2011_PRM_01Param = "@nTarget", .SAKA2011_PRM_01Value = prop_nTarget,
            .SAKA2011_PRM_02Param = "@cKodeTukang", .SAKA2011_PRM_02Value = prop_NIKTukang,
            .SAKA2011_PRM_03Param = "@cKodeDivisi_v50", .SAKA2011_PRM_03Value = prop_09cKodeDivisi,
            .SAKA2011_PRM_04Param = "@cNoDokumenProses", .SAKA2011_PRM_04Value = prop_cNoDokumen}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function GetTP7I201DataLeburForEditing() As DataTable Implements clsNEWCENTRAL_iface.GetTP7I201DataLeburForEditing
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
            .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
            .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
            .SAKA2011_P3_NamaDataSet = "spTP7I201GetDataLeburForEditing",
            .SAKA2011_P4_ObjectDataSet = dsDataSet,
            .SAKA2011_P6_NameStoredProcedure = "spTP7I201GetDataLeburForEditing"}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Sub DeleTP7I202DataLebur() Implements clsNEWCENTRAL_iface.DeleTP7I202DataLebur
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
                .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
                .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
                .SAKA2011_P6_NameStoredProcedure = "spTP7I202DataLeburDeleting",
                .SAKA2011_PRM_01Param = "@guidKeyLebur", .SAKA2011_PRM_01Value = prop_k01guidKeys}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Sub Save59TANGGALTRANSAKSI() Implements clsNEWCENTRAL_iface.Save59TANGGALTRANSAKSI
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
                .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
                .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
                .SAKA2011_P6_NameStoredProcedure = "sp59TANGGALTRANSAKSISave",
                .SAKA2011_PRM_01Param = "@f02cUserID_v50", .SAKA2011_PRM_01Value = prop_02cUserID}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Property prop_tp22STOCKHARIANMUTASI As DataTable Implements clsNEWCENTRAL_iface.prop_tp22STOCKHARIANMUTASI

    Public Property prop_tp22STOCKHARIANPOSTER As DataTable Implements clsNEWCENTRAL_iface.prop_tp22STOCKHARIANPOSTER

    Public Sub Save22STOCKHARIANMUTASI() Implements clsNEWCENTRAL_iface.Save22STOCKHARIANMUTASI
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
                .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
                .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
                .SAKA2011_P6_NameStoredProcedure = "sp22STOCKHARIANMUTASISave",
                .SAKA2011_PRM_01Param = "@nTarget", .SAKA2011_PRM_01Value = prop_nTarget,
                .SAKA2011_PRM_02Param = "@tp22STOCKHARIANMUTASI", .SAKA2011_PRM_02Value = prop_tp22STOCKHARIANMUTASI}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Sub Save22STOCKHARIANPOSTER() Implements clsNEWCENTRAL_iface.Save22STOCKHARIANPOSTER
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
                .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
                .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
                .SAKA2011_P6_NameStoredProcedure = "sp22STOCKHARIANPOSTERSave",
                .SAKA2011_PRM_01Param = "@nTarget", .SAKA2011_PRM_01Value = prop_nTarget,
                .SAKA2011_PRM_02Param = "@tp22STOCKHARIANPOSTER", .SAKA2011_PRM_02Value = prop_tp22STOCKHARIANPOSTER}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Property prop_tp31DEPOSITBOX As DataTable Implements clsNEWCENTRAL_iface.prop_tp31DEPOSITBOX

    Public Sub Save31DEPOSITBOX() Implements clsNEWCENTRAL_iface.Save31DEPOSITBOX
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
            .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
            .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
            .SAKA2011_P6_NameStoredProcedure = "sp31DEPOSITBOXSave",
            .SAKA2011_PRM_01Param = "@tp31DEPOSITBOX", .SAKA2011_PRM_01Value = prop_tp31DEPOSITBOX}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Function Gett31DEPOSITBOX() As DataTable Implements clsNEWCENTRAL_iface.Gett31DEPOSITBOX
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
            .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
            .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
            .SAKA2011_P3_NamaDataSet = "sp31DEPOSITBOXSele",
            .SAKA2011_P4_ObjectDataSet = dsDataSet,
            .SAKA2011_P6_NameStoredProcedure = "sp31DEPOSITBOXSele",
            .SAKA2011_PRM_01Param = "@nTarget", .SAKA2011_PRM_01Value = prop_nTarget,
            .SAKA2011_PRM_02Param = "@k01cNoDokumen_v50", .SAKA2011_PRM_02Value = prop_cNoDokumen,
            .SAKA2011_PRM_03Param = "@f01cKodeDivisiPengrajin_v50", .SAKA2011_PRM_03Value = prop_09cKodeDivisi,
            .SAKA2011_PRM_04Param = "@dTglAwal", .SAKA2011_PRM_04Value = prop_dTglAwal,
            .SAKA2011_PRM_05Param = "@dTglAkhir", .SAKA2011_PRM_05Value = prop_dTglAkhir}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function GetR7JJ01InformasiLebur() As DataTable Implements clsNEWCENTRAL_iface.GetR7JJ01InformasiLebur
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
                .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
                .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
                .SAKA2011_P3_NamaDataSet = "sprptR7JJ01InformasiLebur",
                .SAKA2011_P4_ObjectDataSet = dsDataSet,
                .SAKA2011_P6_NameStoredProcedure = "sprptR7JJ01InformasiLebur",
                .SAKA2011_PRM_01Param = "@nTarget", .SAKA2011_PRM_01Value = prop_nTarget,
                .SAKA2011_PRM_02Param = "@dTglAwal", .SAKA2011_PRM_02Value = prop_dTglAwal,
                .SAKA2011_PRM_03Param = "@dTglAkhir", .SAKA2011_PRM_03Value = prop_dTglAkhir}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function


    Public Property prop_cKodeKadar_v50 As String Implements clsNEWCENTRAL_iface.prop_cKodeKadar_v50

    Public Property prop_k01cIDPohon_v50 As String Implements clsNEWCENTRAL_iface.prop_k01cIDPohon_v50

    Public Property prop_tp32POHONEMAS As DataTable Implements clsNEWCENTRAL_iface.prop_tp32POHONEMAS

    Public Property prop_tp32POHONEMASSKU As DataTable Implements clsNEWCENTRAL_iface.prop_tp32POHONEMASSKU

    Public Function Get32POHONEMASSele() As DataTable Implements clsNEWCENTRAL_iface.Get32POHONEMASSele
        Dim dsDataSet As New DataSet


        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
            .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
            .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
            .SAKA2011_P3_NamaDataSet = "sp32POHONEMASSele",
            .SAKA2011_P4_ObjectDataSet = dsDataSet,
            .SAKA2011_P6_NameStoredProcedure = "sp32POHONEMASSele",
            .SAKA2011_PRM_01Param = "@nTarget", .SAKA2011_PRM_01Value = prop_nTarget,
            .SAKA2011_PRM_02Param = "@k01cIDPohon_v50", .SAKA2011_PRM_02Value = prop_k01cIDPohon_v50,
            .SAKA2011_PRM_03Param = "@cKodeKadar_v50", .SAKA2011_PRM_03Value = prop_cKodeKadar_v50}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)


    End Function

    Public Sub Save32POHONEMASSave() Implements clsNEWCENTRAL_iface.Save32POHONEMASSave
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
            .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
            .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
            .SAKA2011_P6_NameStoredProcedure = "sp32POHONEMASSave",
            .SAKA2011_PRM_01Param = "@nTarget", .SAKA2011_PRM_01Value = prop_nTarget,
            .SAKA2011_PRM_02Param = "@tp32POHONEMAS", .SAKA2011_PRM_02Value = prop_tp32POHONEMAS}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Sub Save32POHONEMASSKUSave() Implements clsNEWCENTRAL_iface.Save32POHONEMASSKUSave
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
            .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
            .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
            .SAKA2011_P6_NameStoredProcedure = "sp32POHONEMASSKUSave",
            .SAKA2011_PRM_01Param = "@tp32POHONEMASSKU", .SAKA2011_PRM_01Value = prop_tp32POHONEMASSKU}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Function GetTP7KT01PrepareDataGPCorEmas() As DataTable Implements clsNEWCENTRAL_iface.GetTP7KT01PrepareDataGPCorEmas
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
            .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
            .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
            .SAKA2011_P3_NamaDataSet = "spTP7KT01GetPrepareDataGPCorEmas",
            .SAKA2011_P4_ObjectDataSet = dsDataSet,
            .SAKA2011_P6_NameStoredProcedure = "spTP7KT01GetPrepareDataGPCorEmas",
            .SAKA2011_PRM_01Param = "@tp22MUTASIRK", .SAKA2011_PRM_01Value = prop_tp22MUTASIRK}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function GetR7KW01PohonEmas() As DataTable Implements clsNEWCENTRAL_iface.GetR7KW01PohonEmas
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
            .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
            .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
            .SAKA2011_P3_NamaDataSet = "sprptR7KW01PohonEmas",
            .SAKA2011_P4_ObjectDataSet = dsDataSet,
            .SAKA2011_P6_NameStoredProcedure = "sprptR7KW01PohonEmas",
            .SAKA2011_PRM_01Param = "@nTarget", .SAKA2011_PRM_01Value = prop_nTarget,
            .SAKA2011_PRM_02Param = "@dTglAwal", .SAKA2011_PRM_02Value = prop_dTglAwal,
            .SAKA2011_PRM_03Param = "@dTglAkhir", .SAKA2011_PRM_03Value = prop_dTglAkhir}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Sub Update32POHONEMASTanggal() Implements clsNEWCENTRAL_iface.Update32POHONEMASTanggal
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
            .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
            .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
            .SAKA2011_P6_NameStoredProcedure = "sp32POHONEMASUpdateTgl",
            .SAKA2011_PRM_01Param = "@nTarget", .SAKA2011_PRM_01Value = prop_nTarget,
            .SAKA2011_PRM_02Param = "@tp32POHONEMAS", .SAKA2011_PRM_02Value = prop_tp32POHONEMAS}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    '************* COR Emas *************
    Public Property prop_tp32CORAlloy As DataTable Implements clsNEWCENTRAL_iface.prop_tp32CORAlloy

    Public Property prop_tp32COREmas As DataTable Implements clsNEWCENTRAL_iface.prop_tp32COREmas

    Public Sub Save32COREmas() Implements clsNEWCENTRAL_iface.Save32COREmas
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
                                                                                    .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
                                                                                    .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
                                                                                    .SAKA2011_P6_NameStoredProcedure = "sp32POHONEMASCORSave",
                                                                                    .SAKA2011_PRM_01Param = "@tp32POHONEMASALLOY", .SAKA2011_PRM_01Value = prop_tp32CORAlloy,
                                                                                    .SAKA2011_PRM_02Param = "@tp32POHONEMASCOR", .SAKA2011_PRM_02Value = prop_tp32COREmas}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Function GetRekapHarian() As DataTable Implements clsNEWCENTRAL_iface.GetRekapHarian
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
            .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
            .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
            .SAKA2011_P3_NamaDataSet = "spR18EE01RekapHarian",
            .SAKA2011_P4_ObjectDataSet = dsDataSet,
            .SAKA2011_P6_NameStoredProcedure = "spR18EE01RekapHarian",
            .SAKA2011_PRM_01Param = "@nTarget", .SAKA2011_PRM_01Value = prop_nTarget,
            .SAKA2011_PRM_02Param = "@dTglRekap", .SAKA2011_PRM_02Value = prop_dTglAwal}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function GetRekapSusut() As DataTable Implements clsNEWCENTRAL_iface.GetRekapSusut
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
            .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
            .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
            .SAKA2011_P3_NamaDataSet = "spR18EE02RekapSusut",
            .SAKA2011_P4_ObjectDataSet = dsDataSet,
            .SAKA2011_P6_NameStoredProcedure = "spR18EE02RekapSusut",
            .SAKA2011_PRM_01Param = "@nTarget", .SAKA2011_PRM_01Value = prop_nTarget,
            .SAKA2011_PRM_02Param = "@dTglRekap", .SAKA2011_PRM_02Value = prop_dTglAwal}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function GetWOTukang() As DataTable Implements clsNEWCENTRAL_iface.GetWOTukang
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
            .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
            .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
            .SAKA2011_P3_NamaDataSet = "sp23PROSESTUKANGDOCSele",
            .SAKA2011_P4_ObjectDataSet = dsDataSet,
            .SAKA2011_P6_NameStoredProcedure = "sp23PROSESTUKANGDOCSele",
            .SAKA2011_PRM_01Param = "@nTarget", .SAKA2011_PRM_01Value = prop_nTarget,
            .SAKA2011_PRM_02Param = "@f01cNoWorkOrderTK_v50", .SAKA2011_PRM_02Value = prop_NoWOTukang}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Property prop_tp33SUSUTLEDGER As DataTable Implements clsNEWCENTRAL_iface.prop_tp33SUSUTLEDGER

    Public Property prop_tp18TIMBANGAN As DataTable Implements clsNEWCENTRAL_iface.prop_tp18TIMBANGAN

    Public Property prop_tp29HASILPROSESZIRCONNEW As DataTable Implements clsNEWCENTRAL_iface.prop_tp29HASILPROSESZIRCONNEW

    Public Sub save33SUSUTLEDGER() Implements clsNEWCENTRAL_iface.save33SUSUTLEDGER
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P6_NameStoredProcedure = "sp33SUSUTLEDGERSave",
             .SAKA2011_PRM_01Param = "@tp33SUSUTLEDGER", .SAKA2011_PRM_01Value = prop_tp33SUSUTLEDGER}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Function GetTP8EY01OutstandingSB() As DataTable Implements clsNEWCENTRAL_iface.GetTP8EY01OutstandingSB
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
                .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
                .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
                .SAKA2011_P3_NamaDataSet = "spTP8EY01OutstandingSB",
                .SAKA2011_P4_ObjectDataSet = dsDataSet,
                .SAKA2011_P6_NameStoredProcedure = "spTP8EY01OutstandingSB",
                .SAKA2011_PRM_01Param = "@nTarget", .SAKA2011_PRM_01Value = prop_nTarget,
                .SAKA2011_PRM_02Param = "@f06cNIKTukang_v50", .SAKA2011_PRM_02Value = prop_NIKTukang,
                .SAKA2011_PRM_03Param = "@f05cKodeKadarSB_v50", .SAKA2011_PRM_03Value = prop_cKodeKadar_v50,
                .SAKA2011_PRM_04Param = "@dTglAwal", .SAKA2011_PRM_04Value = prop_dTglAwal,
                .SAKA2011_PRM_05Param = "@dTglAkhir", .SAKA2011_PRM_05Value = prop_dTglAkhir,
                .SAKA2011_PRM_06Param = "@k03cIDProsesProduksi_v50", .SAKA2011_PRM_06Value = prop_k03cIDProsesProduksi_v50}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function Get23CariWOTukang() As DataTable Implements clsNEWCENTRAL_iface.Get23CariWOTukang
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
                .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
                .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
                .SAKA2011_P3_NamaDataSet = "sp23CariWOTukang",
                .SAKA2011_P4_ObjectDataSet = dsDataSet,
                .SAKA2011_P6_NameStoredProcedure = "sp23CariWOTukang",
                .SAKA2011_PRM_01Param = "@f02cNIKTukang_v50", .SAKA2011_PRM_01Value = prop_NIKTukang}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function Get25ProsesJCADReport() As DataTable Implements clsNEWCENTRAL_iface.Get25ProsesJCADReport
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
                .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
                .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
                .SAKA2011_P3_NamaDataSet = "sp25ProsesJCADReport",
                .SAKA2011_P4_ObjectDataSet = dsDataSet,
                .SAKA2011_P6_NameStoredProcedure = "sp25ProsesJCADReport",
                .SAKA2011_PRM_01Param = "@nTarget_int", .SAKA2011_PRM_01Value = prop_nTarget,
                .SAKA2011_PRM_02Param = "@f02dTglAwal", .SAKA2011_PRM_02Value = prop_dTglAwal,
                .SAKA2011_PRM_03Param = "@f03dTglAkhir", .SAKA2011_PRM_03Value = prop_dTglAkhir,
                .SAKA2011_PRM_04Param = "@f05cNoProses_v50", .SAKA2011_PRM_04Value = prop_k01cNoKey_v50}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function GetR8JA01RekapDebetKredit() As DataTable Implements clsNEWCENTRAL_iface.GetR8JA01RekapDebetKredit
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
                .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
                .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
                .SAKA2011_P3_NamaDataSet = "sprptR8JA01RekapDebetKredit",
                .SAKA2011_P4_ObjectDataSet = dsDataSet,
                .SAKA2011_P6_NameStoredProcedure = "sprptR8JA01RekapDebetKredit",
                .SAKA2011_PRM_01Param = "@nTarget", .SAKA2011_PRM_01Value = prop_nTarget,
                .SAKA2011_PRM_02Param = "@TglRekap", .SAKA2011_PRM_02Value = prop_11dTanggal,
                .SAKA2011_PRM_04Param = "@cIDProsesProduksi", .SAKA2011_PRM_04Value = prop_k03cIDProsesProduksi_v50}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function GetR8JE01RekapDebetKreditALL() As DataTable Implements clsNEWCENTRAL_iface.GetR8JE01RekapDebetKreditALL
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
                .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
                .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
                .SAKA2011_P3_NamaDataSet = "sprptR8JE01RekapDebetKreditALL",
                .SAKA2011_P4_ObjectDataSet = dsDataSet,
                .SAKA2011_P6_NameStoredProcedure = "sprptR8JE01RekapDebetKreditALL",
                .SAKA2011_PRM_01Param = "@dTglRekap", .SAKA2011_PRM_01Value = prop_11dTanggal,
                .SAKA2011_PRM_02Param = "@nTarget", .SAKA2011_PRM_02Value = prop_nTarget}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function GetR9AY01BasePO() As DataTable Implements clsNEWCENTRAL_iface.GetR9AY01BasePO
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
                .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
                .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
                .SAKA2011_P3_NamaDataSet = "spR9AY01BasePO",
                .SAKA2011_P4_ObjectDataSet = dsDataSet,
                .SAKA2011_P6_NameStoredProcedure = "spR9AY01BasePO"}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function


    Public Function Sele18SKUPoster() As DataTable Implements clsNEWCENTRAL_iface.Sele18SKUPoster
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P3_NamaDataSet = "sp18SKUPosterSele",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "sp18SKUPosterSele",
             .SAKA2011_PRM_01Param = "@nTarget", .SAKA2011_PRM_01Value = prop_nTarget,
             .SAKA2011_PRM_02Param = "@cKodeProsesProduksi", .SAKA2011_PRM_02Value = prop_k03cIDProsesProduksi_v50,
             .SAKA2011_PRM_03Param = "@cIDPohonEmas", .SAKA2011_PRM_03Value = prop_k01cIDPohon_v50}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Sub Save18TIMBANGAN() Implements clsNEWCENTRAL_iface.Save18TIMBANGAN
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P6_NameStoredProcedure = "sp18TIMBANGANSave",
             .SAKA2011_PRM_01Param = "@tp18TIMBANGAN", .SAKA2011_PRM_01Value = prop_tp18TIMBANGAN}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Function Seley51NC() As DataTable Implements clsNEWCENTRAL_iface.Seley51NC
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P3_NamaDataSet = "spy51VALUEMASTERsele",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "spy51VALUEMASTERsele"}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Sub Save06CoreJC() Implements clsNEWCENTRAL_iface.Save06CoreJC
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P6_NameStoredProcedure = "sp06COREJOBCARDSave",
             .SAKA2011_PRM_01Param = "@tp06COREJOBCARD", .SAKA2011_PRM_01Value = prop_tp18TIMBANGAN}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Function GetTP9HV01TransferFG2Bridging() As DataTable Implements clsNEWCENTRAL_iface.GetTP9HV01TransferFG2Bridging
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P3_NamaDataSet = "spTP9HV01TransferFG2Bridging",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "spTP9HV01TransferFG2Bridging",
             .SAKA2011_PRM_01Param = "@tp01SKUSAJA", .SAKA2011_PRM_01Value = prop_tp01SKUSAJA}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function GetTP9HV02TransferFG2BridgingPerDoc() As DataTable Implements clsNEWCENTRAL_iface.GetTP9HV02TransferFG2BridgingPerDoc
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P3_NamaDataSet = "spTP9HV02TransferFG2BridgingPerDoc",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "spTP9HV02TransferFG2BridgingPerDoc",
             .SAKA2011_PRM_01Param = "@cNoDOMutasi", .SAKA2011_PRM_01Value = prop_cNoDokumen}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Sub Save29HASILPROSESZIRCONNEW() Implements clsNEWCENTRAL_iface.Save29HASILPROSESZIRCONNEW
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
          .SAKA2011_P6_NameStoredProcedure = "sp29HASILPROSESZIRCONNEWSave",
          .SAKA2011_PRM_01Param = "@tp29HASILPROSESZIRCONNEW", .SAKA2011_PRM_01Value = prop_tp29HASILPROSESZIRCONNEW}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Function Sele29HASILPROSESZIRCONNEW() As DataTable Implements clsNEWCENTRAL_iface.Sele29HASILPROSESZIRCONNEW
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
          .SAKA2011_P3_NamaDataSet = "sp29HASILPROSESZIRCONNEWSele",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "sp29HASILPROSESZIRCONNEWSele",
          .SAKA2011_PRM_01Param = "@nTarget", .SAKA2011_PRM_01Value = prop_nTarget,
          .SAKA2011_PRM_02Param = "@k01cSKU_v50", .SAKA2011_PRM_02Value = prop_k01cSKU_v50,
          .SAKA2011_PRM_03Param = "@f02cIDProsesSetting_v50", .SAKA2011_PRM_03Value = prop_k03cIDProsesProduksi_v50,
          .SAKA2011_PRM_04Param = "@f10cNoBonZircon_v50", .SAKA2011_PRM_04Value = prop_cNoDokumen}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function Sele29LOGPROSESZIRCONNEW() As DataTable Implements clsNEWCENTRAL_iface.Sele29LOGPROSESZIRCONNEW
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
          .SAKA2011_P3_NamaDataSet = "sp29LOGPROSESZIRCONNEWSele",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "sp29LOGPROSESZIRCONNEWSele"}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function
    Public Function Seley100Kalenderkerja() As DataTable Implements clsNEWCENTRAL_iface.Seley100Kalenderkerja
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
          .SAKA2011_P3_NamaDataSet = "sp100KALENDERKERJASele",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "sp100KALENDERKERJASele",
          .SAKA2011_PRM_01Param = "@nYear", .SAKA2011_PRM_01Value = prop_06nTahun_int}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function GetR9KC01GoldLossTKFinal() As DataTable Implements clsNEWCENTRAL_iface.GetR9KC01GoldLossTKFinal
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
          .SAKA2011_P3_NamaDataSet = "spR9KC01GoldLossTKFinal",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "spR9KC01GoldLossTKFinal",
          .SAKA2011_PRM_01Param = "@dTglAwal", .SAKA2011_PRM_01Value = prop_dTglAwal,
          .SAKA2011_PRM_02Param = "@dTglAkhir", .SAKA2011_PRM_02Value = prop_dTglAkhir}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function GetR20BL01GambarStockProduksi() As DataTable Implements clsNEWCENTRAL_iface.GetR20BL01GambarStockProduksi
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
          .SAKA2011_P3_NamaDataSet = "spR20BL01GambarStockProduksi",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "spR20BL01GambarStockProduksi"}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function GetR20EU01LeadTime() As DataTable Implements clsNEWCENTRAL_iface.GetR20EU01LeadTime
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
          .SAKA2011_P3_NamaDataSet = "spR20EU01LeadTime",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "spR20EU01LeadTime",
          .SAKA2011_PRM_01Param = "@tglAwal", .SAKA2011_PRM_01Value = prop_dTglAwal,
          .SAKA2011_PRM_02Param = "@tglAkhir", .SAKA2011_PRM_02Value = prop_dTglAkhir}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function GetR20EU01LeadTimeNew() As DataTable Implements clsNEWCENTRAL_iface.GetR20EU01LeadTimeNew
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
          .SAKA2011_P3_NamaDataSet = "spR20EU01LeadTimeNew",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "spR20EU01LeadTimeNew",
          .SAKA2011_PRM_01Param = "@dTglAwal", .SAKA2011_PRM_01Value = prop_dTglAwal,
          .SAKA2011_PRM_02Param = "@dTglAkhir", .SAKA2011_PRM_02Value = prop_dTglAkhir}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function GetR20EU01LeadTimeFinal() As DataTable Implements clsNEWCENTRAL_iface.GetR20EU01LeadTimeFinal
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
          .SAKA2011_P3_NamaDataSet = "spR20EU01LeadTimeFinal",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "spR20EU01LeadTimeFinal",
          .SAKA2011_PRM_01Param = "@dTglAwal", .SAKA2011_PRM_01Value = prop_dTglAwal,
          .SAKA2011_PRM_02Param = "@dTglAkhir", .SAKA2011_PRM_02Value = prop_dTglAkhir}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function Sele25AM01RetransferDataInbound() As DataTable Implements clsNEWCENTRAL_iface.Sele25AM01RetransferDataInbound
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
          .SAKA2011_P3_NamaDataSet = "sp25AM01RetransferDataInboundSele",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "sp25AM01RetransferDataInboundSele",
          .SAKA2011_PRM_01Param = "@dTglAwal", .SAKA2011_PRM_01Value = prop_dTglAwal,
          .SAKA2011_PRM_02Param = "@dTglAkhir", .SAKA2011_PRM_02Value = prop_dTglAkhir}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function
    Public Function Sele25AM02GetDataInboundBySPK() As DataTable Implements clsNEWCENTRAL_iface.Sele25AM02GetDataInboundBySPK
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
          .SAKA2011_P3_NamaDataSet = "sp25AM02GetDataInboundBySPKSele",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "sp25AM02GetDataInboundBySPKSele",
          .SAKA2011_PRM_01Param = "@tp01SKUSAJA", .SAKA2011_PRM_01Value = prop_tp01SKUSAJA}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function


    Public Function SeleTetsing() As DataTable Implements clsNEWCENTRAL_iface.SeleTetsing
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
          .SAKA2011_P3_NamaDataSet = "spTestingSeleV2",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "spTestingSeleV2",
          .SAKA2011_PRM_01Param = "@dTgalStcok", .SAKA2011_PRM_01Value = prop_dTglAwal,
          .SAKA2011_PRM_02Param = "@IdProses", .SAKA2011_PRM_02Value = prop_k03cIDProsesProduksi_v50}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Async Function GetDataCurrent_Async() As Threading.Tasks.Task(Of DataTable) Implements clsNEWCENTRAL_iface.GetDataCurrent_Async
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb01NC),
             .SAKA2011_P3_NamaDataSet = "spP6KG01SaldoSKU",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "spP6KG01SaldoSKU",
             .SAKA2011_PRM_01Param = "@nTarget", .SAKA2011_PRM_01Value = prop_nTarget,
             .SAKA2011_PRM_02Param = "@dTglStock", .SAKA2011_PRM_02Value = prop_11dTanggal}

            Await objExecute.ExecMethodsSqlAdapter_Async()

            ' Await objExecute.ExecMethodsSqlDataReader_Async
        End Using

        Return dsDataSet.Tables(0)
    End Function

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not Me.disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        Me.disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub





#End Region

End Class


'********** end of .NET Model : IMPLEMENTS (method) ****************
