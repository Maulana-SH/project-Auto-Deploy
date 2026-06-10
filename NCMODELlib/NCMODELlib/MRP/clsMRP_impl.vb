'********** create .NET Model : IMPLEMENTS (method) ****************

Imports NCCORElib

Public Class clsMRP_impl
     Implements clsMRP_iface

    Public Property prop_KeyString01 As String Implements clsMRP_iface.prop_KeyString01
    Public Property prop_KeyString02 As String Implements clsMRP_iface.prop_KeyString02
    Public Property prop_KeyString03 As String Implements clsMRP_iface.prop_KeyString03
    Public Property prop_KeyString04 As String Implements clsMRP_iface.prop_KeyString04

    Public Property prop_KeyInt03Tahun As Short Implements clsMRP_iface.prop_KeyInt03Tahun ' tahbahan untuk Create SKU JOBCARD

    Public Property prop_KeyInt01 As Integer Implements clsMRP_iface.prop_KeyInt01
    Public Property prop_KeyInt02 As Integer Implements clsMRP_iface.prop_KeyInt02

    Public Property prop_KeyDouble01 As Double Implements clsMRP_iface.prop_KeyDouble01
    Public Property prop_KeyDouble02 As Double Implements clsMRP_iface.prop_KeyDouble02

    Public Property prop_KeyDataTable01 As DataTable Implements clsMRP_iface.prop_KeyDataTable01
    Public Property prop_KeyDataTable02 As DataTable Implements clsMRP_iface.prop_KeyDataTable02
    Public Property prop_KeyDataTable03 As DataTable Implements clsMRP_iface.prop_KeyDataTable03
    Public Property prop_KeyDataTable04 As DataTable Implements clsMRP_iface.prop_KeyDataTable04
    Public Property prop_KeyDataTable05 As DataTable Implements clsMRP_iface.prop_KeyDataTable05

    Public Sub Save20MASTERROUTING() Implements clsMRP_iface.Save20MASTERROUTING

        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
          .SAKA2011_P6_NameStoredProcedure = "sp20MASTERROUTINGSave",
          .SAKA2011_PRM_01Param = "@tp20MASTERROUTING", .SAKA2011_PRM_01Value = prop_KeyDataTable01}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using

    End Sub

    Public Function Sele20MASTERROUTING() As DataTable Implements clsMRP_iface.Sele20MASTERROUTING

        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
          .SAKA2011_P3_NamaDataSet = "sp20MASTERROUTINGSele",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "sp20MASTERROUTINGSele",
          .SAKA2011_PRM_01Param = "@k01cKodeMasterRouting_v50", .SAKA2011_PRM_01Value = prop_KeyString01,
          .SAKA2011_PRM_02Param = "@k02cKodeProsesProduksi_v50", .SAKA2011_PRM_02Value = prop_KeyString02}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)

    End Function

    Public Sub Save21MCRAWMATERIAL() Implements clsMRP_iface.Save21MCRAWMATERIAL

        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
        .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
        .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
        .SAKA2011_P6_NameStoredProcedure = "sp21MCRAWMATERIALSave",
        .SAKA2011_PRM_01Param = "@tp21MCRAWMATERIAL", .SAKA2011_PRM_01Value = prop_KeyDataTable01}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using

    End Sub

    Public Function Sele21MCRAWMATERIAL() As DataTable Implements clsMRP_iface.Sele21MCRAWMATERIAL

        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
          .SAKA2011_P3_NamaDataSet = "sp21MCRAWMATERIALSele",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "sp21MCRAWMATERIALSele",
          .SAKA2011_PRM_01Param = "@k01cKodeItemCastedParts_v50", .SAKA2011_PRM_01Value = prop_KeyString01}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)

    End Function

    Public Sub Save22MCFINDINGCOMPONENT() Implements clsMRP_iface.Save22MCFINDINGCOMPONENT

        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
          .SAKA2011_P6_NameStoredProcedure = "sp22MCFINDINGCOMPONENTSave",
          .SAKA2011_PRM_01Param = "@tp22MCFINDINGCOMPONENT", .SAKA2011_PRM_01Value = prop_KeyDataTable01}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using

    End Sub

    Public Function Sele22MCFINDINGCOMPONENT() As DataTable Implements clsMRP_iface.Sele22MCFINDINGCOMPONENT

        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
          .SAKA2011_P3_NamaDataSet = "sp22MCFINDINGCOMPONENTSele",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "sp22MCFINDINGCOMPONENTSele",
          .SAKA2011_PRM_01Param = "@k01cKodeItemFindingComponent_v50", .SAKA2011_PRM_01Value = prop_KeyString01}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)

    End Function

    Public Sub Save23MCSTONES() Implements clsMRP_iface.Save23MCSTONES

        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
          .SAKA2011_P6_NameStoredProcedure = "sp23MCSTONESSave",
          .SAKA2011_PRM_01Param = "@tp23MCSTONES", .SAKA2011_PRM_01Value = prop_KeyDataTable01}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using

    End Sub

    Public Function Sele23MCSTONES() As DataTable Implements clsMRP_iface.Sele23MCSTONES

        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
          .SAKA2011_P3_NamaDataSet = "sp23MCSTONESSele",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "sp23MCSTONESSele",
          .SAKA2011_PRM_01Param = "@k01cKodeStones_v50", .SAKA2011_PRM_01Value = prop_KeyString01}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)

    End Function

    Public Sub Save24MCFINISHEDGOOD() Implements clsMRP_iface.Save24MCFINISHEDGOOD

        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
          .SAKA2011_P6_NameStoredProcedure = "sp24MCFINISHEDGOODSave",
          .SAKA2011_PRM_01Param = "@tp24MCFINISHEDGOOD", .SAKA2011_PRM_01Value = prop_KeyDataTable01}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using

    End Sub

    Public Function sele21FG01ReprintGP() As DataTable Implements clsMRP_iface.sele21FG01ReprintGP

        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
          .SAKA2011_P3_NamaDataSet = "sprpt21FG01ReprintGPSele",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "sprpt21FG01ReprintGPSele",
          .SAKA2011_PRM_01Param = "@nTarget", .SAKA2011_PRM_01Value = prop_KeyInt01,
          .SAKA2011_PRM_02Param = "@k01cNoPRO_v50", .SAKA2011_PRM_02Value = prop_KeyString01,
          .SAKA2011_PRM_03Param = "@k02nNoUrutMutasi", .SAKA2011_PRM_03Value = prop_KeyInt02}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)

    End Function

    Public Function Sele21GetProductAPI() As DataTable Implements clsMRP_iface.Sele21GetProductAPI

        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
          .SAKA2011_P3_NamaDataSet = "sp21GetProductAPISele",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "sp21GetProductAPISele",
          .SAKA2011_PRM_01Param = "@nTarget", .SAKA2011_PRM_01Value = prop_KeyInt01,
          .SAKA2011_PRM_02Param = "@k01cKodeProduct_v50", .SAKA2011_PRM_02Value = prop_KeyString01}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)

    End Function

    Public Function Sele24MCFINISHEDGOOD() As DataTable Implements clsMRP_iface.Sele24MCFINISHEDGOOD

        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
          .SAKA2011_P3_NamaDataSet = "sp24MCFINISHEDGOODSele",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "sp24MCFINISHEDGOODSele",
          .SAKA2011_PRM_01Param = "@k01cKodeFinishedGood_v50", .SAKA2011_PRM_01Value = prop_KeyString01,
          .SAKA2011_PRM_02Param = "@k02cVersionBOM_v50", .SAKA2011_PRM_02Value = prop_KeyString02}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)

    End Function

    'for reprinting #nCheck bCheck Copiprint
    Public Function SeleReprint24MCFINISHEDGOOD() As DataTable Implements clsMRP_iface.SeleReprint24MCFINISHEDGOOD

        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
          .SAKA2011_P3_NamaDataSet = "sp24MCFINISHEDGOODForReprintSele",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "sp24MCFINISHEDGOODForReprintSele"}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)

    End Function

    Public Sub Save24MCMULTIPLE() Implements clsMRP_iface.Save24MCMULTIPLE
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
          .SAKA2011_P6_NameStoredProcedure = "sp24MCMULTIPLESave",
          .SAKA2011_PRM_01Param = "@tp24MCMULTIPLE", .SAKA2011_PRM_01Value = prop_KeyDataTable01}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Function Sele24MCMULTIPLE() As DataTable Implements clsMRP_iface.Sele24MCMULTIPLE
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
             .SAKA2011_P3_NamaDataSet = "sp24MCMULTIPLESele",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "sp24MCMULTIPLESele",
             .SAKA2011_PRM_01Param = "@k01cKodeTransaksi_v50", .SAKA2011_PRM_01Value = prop_KeyString01}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Sub Save25BOMCASTEDPARTS() Implements clsMRP_iface.Save25BOMCASTEDPARTS

        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
          .SAKA2011_P6_NameStoredProcedure = "sp25BOMCASTEDPARTSSave",
          .SAKA2011_PRM_01Param = "@tp25BOMCASTEDPARTS", .SAKA2011_PRM_01Value = prop_KeyDataTable01}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using

    End Sub

    Public Function Sele25BOMCASTEDPARTS() As DataTable Implements clsMRP_iface.Sele25BOMCASTEDPARTS

        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
          .SAKA2011_P3_NamaDataSet = "sp25BOMCASTEDPARTSSele",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "sp25BOMCASTEDPARTSSele",
          .SAKA2011_PRM_01Param = "@k01cKodeFinishedGood_v50", .SAKA2011_PRM_01Value = prop_KeyString01,
          .SAKA2011_PRM_02Param = "@k02cKodeRubber_v50", .SAKA2011_PRM_02Value = prop_KeyString02,
          .SAKA2011_PRM_03Param = "@k03cKodeItemCastedParts_v50", .SAKA2011_PRM_03Value = prop_KeyString03,
          .SAKA2011_PRM_04Param = "@k04cVersionBOM_v50", .SAKA2011_PRM_04Value = prop_KeyString04}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)

    End Function

    Public Sub Save26BOMFINDINGCOMPONENT() Implements clsMRP_iface.Save26BOMFINDINGCOMPONENT

        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
          .SAKA2011_P6_NameStoredProcedure = "sp26BOMFINDINGCOMPONENTSave",
          .SAKA2011_PRM_01Param = "@tp26BOMFINDINGCOMPONENT", .SAKA2011_PRM_01Value = prop_KeyDataTable01}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using

    End Sub

    Public Function Sele26BOMFINDINGCOMPONENT() As DataTable Implements clsMRP_iface.Sele26BOMFINDINGCOMPONENT

        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
          .SAKA2011_P3_NamaDataSet = "sp26BOMFINDINGCOMPONENTSele",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "sp26BOMFINDINGCOMPONENTSele",
          .SAKA2011_PRM_01Param = "@k01cKodeFinishedGood_v50", .SAKA2011_PRM_01Value = prop_KeyString01,
          .SAKA2011_PRM_02Param = "@k02cKodeItemFindingComponent_v50", .SAKA2011_PRM_02Value = prop_KeyString02,
          .SAKA2011_PRM_03Param = "@k03cVersionBOM_v50", .SAKA2011_PRM_03Value = prop_KeyString03}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)

    End Function

    Public Sub Save27BOMSTONES() Implements clsMRP_iface.Save27BOMSTONES

        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
          .SAKA2011_P6_NameStoredProcedure = "sp27BOMSTONESSave",
          .SAKA2011_PRM_01Param = "@tp27BOMSTONES", .SAKA2011_PRM_01Value = prop_KeyDataTable01}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using

    End Sub

    Public Function Sele27BOMSTONES() As DataTable Implements clsMRP_iface.Sele27BOMSTONES

        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
          .SAKA2011_P3_NamaDataSet = "sp27BOMSTONESSele",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "sp27BOMSTONESSele",
          .SAKA2011_PRM_01Param = "@k01cKodeFinishedGood_v50", .SAKA2011_PRM_01Value = prop_KeyString01,
          .SAKA2011_PRM_02Param = "@k02cKodeStones_v50", .SAKA2011_PRM_02Value = prop_KeyString02,
          .SAKA2011_PRM_03Param = "@k03cVersionBOM_v50", .SAKA2011_PRM_03Value = prop_KeyString03}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)

    End Function

    Public Sub Save28COREPRO() Implements clsMRP_iface.Save28COREPRO

        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
          .SAKA2011_P6_NameStoredProcedure = "sp28COREPROSave",
          .SAKA2011_PRM_01Param = "@tp28COREPRO", .SAKA2011_PRM_01Value = prop_KeyDataTable01}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using

    End Sub

    Public Sub Save29ROUTINGBOM() Implements clsMRP_iface.Save29ROUTINGBOM
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
             .SAKA2011_P6_NameStoredProcedure = "sp29ROUTINGBOMSave",
             .SAKA2011_PRM_01Param = "@tp29ROUTINGBOM", .SAKA2011_PRM_01Value = prop_KeyDataTable01}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Function Sele29ROUTINGBOM() As DataTable Implements clsMRP_iface.Sele29ROUTINGBOM
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
             .SAKA2011_P3_NamaDataSet = "sp29ROUTINGBOMSele",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "sp29ROUTINGBOMSele",
             .SAKA2011_PRM_01Param = "@k01cKodeFinishedGood_v50", .SAKA2011_PRM_01Value = prop_KeyString01,
             .SAKA2011_PRM_02Param = "@k02cVersionBOM_v50", .SAKA2011_PRM_02Value = prop_KeyString02,
             .SAKA2011_PRM_03Param = "@k03nNoUrutRouting_int", .SAKA2011_PRM_03Value = prop_KeyInt01,
             .SAKA2011_PRM_04Param = "@nTarget", .SAKA2011_PRM_04Value = prop_KeyInt02}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function Sele28COREPRO() As DataTable Implements clsMRP_iface.Sele28COREPRO

        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
          .SAKA2011_P3_NamaDataSet = "sp28COREPROSele",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "sp28COREPROSele",
          .SAKA2011_PRM_01Param = "@k01cNoPRO_v50", .SAKA2011_PRM_01Value = prop_KeyString01,
          .SAKA2011_PRM_02Param = "@k02cKodeMaterialOrFG_v50", .SAKA2011_PRM_02Value = prop_KeyString02,
          .SAKA2011_PRM_03Param = "@k03cVersionBOM_v50", .SAKA2011_PRM_03Value = prop_KeyString03}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function Sele28BOMFCI() As DataTable Implements clsMRP_iface.Sele28BOMFCI
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
             .SAKA2011_P3_NamaDataSet = "sp28BOMFCISele",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "sp28BOMFCISele",
             .SAKA2011_PRM_01Param = "@k01cKodeFCI_v50", .SAKA2011_PRM_01Value = prop_KeyString01}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    'for reprinting t28 #nCheck bCheck Copiprint
    Public Function SeleReprint28COREPRO() As DataTable Implements clsMRP_iface.SeleReprint28COREPRO

        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
          .SAKA2011_P3_NamaDataSet = "sp28COREPROReprintSele",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "sp28COREPROReprintSele",
          .SAKA2011_PRM_01Param = "@nTarget", .SAKA2011_PRM_01Value = prop_KeyInt01}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function Get2122MasterMaterial() As DataTable Implements clsMRP_iface.Get2122MasterMaterial
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
          .SAKA2011_P3_NamaDataSet = "sp2122MasterMaterial",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "sp2122MasterMaterial"}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function Get2122MaterialBOMForPRO() As DataTable Implements clsMRP_iface.Get2122MaterialBOMForPRO
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
          .SAKA2011_P3_NamaDataSet = "sp2122MaterialBOMForPRO",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "sp2122MaterialBOMForPRO"}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function GetGambar() As DataTable Implements clsMRP_iface.GetGambar
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb03GAMBAR),
             .SAKA2011_P3_NamaDataSet = "spGambarSelect",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "spGambarSelect",
             .SAKA2011_PRM_01Param = "@k01cKodeGambar_v50", .SAKA2011_PRM_01Value = prop_KeyString01}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Sub SaveGambarJOBCARD3D() Implements clsMRP_iface.SaveGambarJOBCARD3D

        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
          .SAKA2011_P6_NameStoredProcedure = "spGambarAdd",
          .SAKA2011_PRM_01Param = "@k01cKodeGambar_v50", .SAKA2011_PRM_01Value = prop_KeyString01,
          .SAKA2011_PRM_02Param = "@f01objGambar", .SAKA2011_PRM_02Value = prop_KeyString02,
          .SAKA2011_PRM_03Param = "@f02cKodeFGorComponent_v50", .SAKA2011_PRM_03Value = prop_KeyString03,
          .SAKA2011_PRM_04Param = "@f03cKodeWarna_v50", .SAKA2011_PRM_04Value = prop_KeyString04}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using

    End Sub

    Public Function Get30CreateSKUJobCard() As DataTable Implements clsMRP_iface.Get30CreateSKUJobCard
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
             .SAKA2011_P3_NamaDataSet = "sp30CreateSKU",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "sp30CreateSKU",
             .SAKA2011_PRM_01Param = "@f01cKodeSBU_v50", .SAKA2011_PRM_01Value = prop_KeyString01,
             .SAKA2011_PRM_02Param = "@f02cIDAutoNumber_v50", .SAKA2011_PRM_02Value = prop_KeyString02,
             .SAKA2011_PRM_03Param = "@f06nTahun_int", .SAKA2011_PRM_03Value = prop_KeyInt03Tahun,
             .SAKA2011_PRM_04Param = "@pcDesignMasterCode", .SAKA2011_PRM_04Value = prop_KeyString03}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function


    Public Function GetGambarMRP() As DataTable Implements clsMRP_iface.GetGambarMRP

        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb03GAMBAR),
             .SAKA2011_P3_NamaDataSet = "spGambarSeleMRP",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "spGambarSeleMRP",
             .SAKA2011_PRM_01Param = "@nTarget", .SAKA2011_PRM_01Value = prop_KeyInt01,
             .SAKA2011_PRM_02Param = "@k01cKodeGambar_v50", .SAKA2011_PRM_02Value = prop_KeyString01,
             .SAKA2011_PRM_03Param = "@f02cKodeFGorComponent_v50", .SAKA2011_PRM_03Value = prop_KeyString02}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function GetImageTypeFGorComponent() As DataTable Implements clsMRP_iface.GetImageTypeFGorComponent
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb03GAMBAR),
             .SAKA2011_P3_NamaDataSet = "spGetImageTypeFGorComponent",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "spGetImageTypeFGorComponent",
             .SAKA2011_PRM_01Param = "@tpFGorComponent", .SAKA2011_PRM_01Value = prop_KeyDataTable01}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Sub SaveHeaderBOM() Implements clsMRP_iface.SaveHeaderBOM
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
             .SAKA2011_P6_NameStoredProcedure = "spSaveHeaderBOM",
             .SAKA2011_PRM_01Param = "@tpSaveHeaderBOM", .SAKA2011_PRM_01Value = prop_KeyDataTable01,
             .SAKA2011_PRM_02Param = "@tp25BOMCASTEDPARTS", .SAKA2011_PRM_02Value = prop_KeyDataTable02,
             .SAKA2011_PRM_03Param = "@tp26BOMFINDINGCOMPONENT", .SAKA2011_PRM_03Value = prop_KeyDataTable03,
             .SAKA2011_PRM_04Param = "@tp27BOMSTONES", .SAKA2011_PRM_04Value = prop_KeyDataTable04,
             .SAKA2011_PRM_05Param = "@tp29ROUTINGBOM", .SAKA2011_PRM_05Value = prop_KeyDataTable05}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Function Get51MasterAllNewSKK() As DataTable Implements clsMRP_iface.Get51MasterAllNewSKK
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
          .SAKA2011_P3_NamaDataSet = "sp51MasterAllSKK",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "sp51MasterAllSKK"}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function Get52CreateIDNumbering() As DataTable Implements clsMRP_iface.Get52CreateIDNumbering
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
             .SAKA2011_P3_NamaDataSet = "sp52CreateIDNumbering",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "sp52CreateIDNumbering",
             .SAKA2011_PRM_01Param = "@f01cKodeSBU_v50", .SAKA2011_PRM_01Value = prop_KeyString01,
             .SAKA2011_PRM_02Param = "@f02cIDAutoNumber_v50", .SAKA2011_PRM_02Value = prop_KeyString02,
             .SAKA2011_PRM_03Param = "@f06nTahun_int", .SAKA2011_PRM_03Value = prop_KeyInt01,
             .SAKA2011_PRM_04Param = "@nIncrementNumber", .SAKA2011_PRM_04Value = prop_KeyInt02}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function
    Public Function sele446MASTERVAULT() As DataTable Implements clsMRP_iface.sele446MASTERVAULT
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb06PRODUCTION),
             .SAKA2011_P3_NamaDataSet = "sp446MasterVault",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "sp446MasterVault",
             .SAKA2011_PRM_01Param = "@nTarget", .SAKA2011_PRM_01Value = 2,
             .SAKA2011_PRM_02Param = "@cKodeSLOCUser", .SAKA2011_PRM_02Value = "CS-003"} ' hnaya untukj testing data saja

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function seleGet_Castedpart() As DataTable Implements clsMRP_iface.seleGet_Castedpart
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
             .SAKA2011_P3_NamaDataSet = "sele24COSOMRP_v1_BC",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "sele24COSOMRP_v1_BC"} ' hnaya untukj testing data saja

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function sele01WS() As DataTable Implements clsMRP_iface.sele01WS
        ' Dipakai buat SO WH
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb08WS),
             .SAKA2011_P3_NamaDataSet = "spTABLE01Sele",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "spTABLE01Sele",
             .SAKA2011_PRM_01Param = "@nTarget", .SAKA2011_PRM_01Value = prop_KeyInt01,
             .SAKA2011_PRM_02Param = "@k01String", .SAKA2011_PRM_02Value = prop_KeyString01, ' SKU
             .SAKA2011_PRM_03Param = "@f01IDUser", .SAKA2011_PRM_03Value = prop_KeyString02} ' ID User (NIK)

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function


    Public Sub save01WS() Implements clsMRP_iface.save01WS
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb08WS),
          .SAKA2011_P6_NameStoredProcedure = "spWHTABLE01Save",
          .SAKA2011_PRM_01Param = "@tpDataForSaving", .SAKA2011_PRM_01Value = prop_KeyDataTable01}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub


    Public Function Sele30RFIDCODE() As DataTable Implements clsMRP_iface.Sele30RFIDCODE
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
          .SAKA2011_P3_NamaDataSet = "sp30RFIDCODESele",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "sp30RFIDCODESele",
          .SAKA2011_PRM_01Param = "@nTarget", .SAKA2011_PRM_01Value = prop_KeyInt01,
          .SAKA2011_PRM_02Param = "@k01cRFIDCODE_v50", .SAKA2011_PRM_02Value = prop_KeyString01}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)

    End Function

    Public Function Get01COMPLAINMANAGEMENT() As DataTable Implements clsMRP_iface.Get01COMPLAINMANAGEMENT
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
             .SAKA2011_P3_NamaDataSet = "spt01COMPLAINMANAGEMENTSele",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "spt01COMPLAINMANAGEMENTSele",
             .SAKA2011_PRM_01Param = "@nTarget", .SAKA2011_PRM_01Value = prop_KeyInt01,
             .SAKA2011_PRM_02Param = "@k01cKomplainCode_v50", .SAKA2011_PRM_02Value = prop_KeyString01} ' hnaya untukj testing data saja

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function seleGambarProduct() As DataTable Implements clsMRP_iface.seleGambarProduct
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
             .SAKA2011_P3_NamaDataSet = "spGambarProductSele",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "spGambarProductSele"}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Sub Save32PRODUCT() Implements clsMRP_iface.Save32PRODUCT
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
          .SAKA2011_P6_NameStoredProcedure = "sp32PRODUCTSave",
          .SAKA2011_PRM_01Param = "@tp32PRODUCT", .SAKA2011_PRM_01Value = prop_KeyDataTable01}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Function Sele32PRODUCT() As DataTable Implements clsMRP_iface.Sele32PRODUCT
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
          .SAKA2011_P3_NamaDataSet = "sp32PRODUCTSele",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "sp32PRODUCTSele",
          .SAKA2011_PRM_01Param = "@nTarget", .SAKA2011_PRM_01Value = prop_KeyInt01,
          .SAKA2011_PRM_02Param = "@k01cKodeProduct_v50", .SAKA2011_PRM_02Value = prop_KeyString01,
          .SAKA2011_PRM_03Param = "@f02cKodeDesignMaster_v50", .SAKA2011_PRM_03Value = prop_KeyString02}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function


    Public Function GetTEST() As DataTable Implements clsMRP_iface.GetTEST
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb08WS),
          .SAKA2011_P3_NamaDataSet = "spSDB10getReportBrand_copy",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "spSDB10getReportBrand_copy"}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Sub Save33SALESORDER() Implements clsMRP_iface.Save33SALESORDER
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
          .SAKA2011_P6_NameStoredProcedure = "sp33SALESORDERSave",
          .SAKA2011_PRM_01Param = "@tp33SALESORDER", .SAKA2011_PRM_01Value = prop_KeyDataTable01}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Function Sele33SALESORDER() As DataTable Implements clsMRP_iface.Sele33SALESORDER
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
          .SAKA2011_P3_NamaDataSet = "sp33SALESORDERSele",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "sp33SALESORDERSele",
          .SAKA2011_PRM_01Param = "@k01cNomorSalesOrder_v50", .SAKA2011_PRM_01Value = prop_KeyString01}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Sub Save30DESIGNMASTER() Implements clsMRP_iface.Save30DESIGNMASTER
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
          .SAKA2011_P6_NameStoredProcedure = "sp30DESIGNMASTERSave",
          .SAKA2011_PRM_01Param = "@tp30DESIGNMASTER", .SAKA2011_PRM_01Value = prop_KeyDataTable01}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Function Sele30DESIGNMASTER() As DataTable Implements clsMRP_iface.Sele30DESIGNMASTER
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
             .SAKA2011_P3_NamaDataSet = "sp30DESIGNMASTERSele",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "sp30DESIGNMASTERSele",
             .SAKA2011_PRM_01Param = "@k01cKodeDesignMaster_v50", .SAKA2011_PRM_01Value = prop_KeyString01}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Sub Save3031AllSaveDesignMaster() Implements clsMRP_iface.Save3031AllSaveDesignMaster
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
          .SAKA2011_P6_NameStoredProcedure = "sp3031AllSaveDesignMaster",
          .SAKA2011_PRM_01Param = "@tp24MCMULTIPLE", .SAKA2011_PRM_01Value = prop_KeyDataTable01,
          .SAKA2011_PRM_02Param = "@tp30DESIGNMASTER", .SAKA2011_PRM_02Value = prop_KeyDataTable02,
          .SAKA2011_PRM_03Param = "@tp31DESIGNMASTERSTONE", .SAKA2011_PRM_03Value = prop_KeyDataTable03}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Sub Save31DESIGNMASTERSTONE() Implements clsMRP_iface.Save31DESIGNMASTERSTONE
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
             .SAKA2011_P6_NameStoredProcedure = "sp31DESIGNMASTERSTONESave",
             .SAKA2011_PRM_01Param = "@tp31DESIGNMASTERSTONE", .SAKA2011_PRM_01Value = prop_KeyDataTable01}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Function Sele31DESIGNMASTERSTONE() As DataTable Implements clsMRP_iface.Sele31DESIGNMASTERSTONE
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
          .SAKA2011_P3_NamaDataSet = "sp31DESIGNMASTERSTONESele",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "sp31DESIGNMASTERSTONESele",
          .SAKA2011_PRM_01Param = "@k01cKodeDesignMaster_v50", .SAKA2011_PRM_01Value = prop_KeyString01}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Sub Save34RUBBERSILVERMASTER() Implements clsMRP_iface.Save34RUBBERSILVERMASTER
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
              .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
              .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
              .SAKA2011_P6_NameStoredProcedure = "sp34RUBBERSILVERMASTERSave",
              .SAKA2011_PRM_01Param = "@tp34RUBBERSILVERMASTER", .SAKA2011_PRM_01Value = prop_KeyDataTable01}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Function Sele34RUBBERSILVERMASTER() As DataTable Implements clsMRP_iface.Sele34RUBBERSILVERMASTER
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
              .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
              .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
              .SAKA2011_P3_NamaDataSet = "sp34RUBBERSILVERMASTERSele",
              .SAKA2011_P4_ObjectDataSet = dsDataSet,
              .SAKA2011_P6_NameStoredProcedure = "sp34RUBBERSILVERMASTERSele",
              .SAKA2011_PRM_01Param = "@nTarget", .SAKA2011_PRM_01Value = prop_KeyInt01,
              .SAKA2011_PRM_02Param = "@k01cRubberSilverCode_v50", .SAKA2011_PRM_02Value = prop_KeyString01}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Sub Save35JOBCARD() Implements clsMRP_iface.Save35JOBCARD
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
          .SAKA2011_P6_NameStoredProcedure = "sp35JOBCARDSave",
          .SAKA2011_PRM_01Param = "@tp35JOBCARD", .SAKA2011_PRM_01Value = prop_KeyDataTable01}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Function Sele35JOBCARD() As DataTable Implements clsMRP_iface.Sele35JOBCARD
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
          .SAKA2011_P3_NamaDataSet = "sp35JOBCARDSele",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "sp35JOBCARDSele",
          .SAKA2011_PRM_01Param = "@k01cKodeValidation_v50", .SAKA2011_PRM_01Value = prop_KeyString01}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)

    End Function

    Public Sub Save36JOBCARDBOM() Implements clsMRP_iface.Save36JOBCARDBOM
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
          .SAKA2011_P6_NameStoredProcedure = "sp36JOBCARDBOMSave",
          .SAKA2011_PRM_01Param = "@tp36JOBCARDBOM", .SAKA2011_PRM_01Value = prop_KeyDataTable01}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Function Sele36JOBCARDBOM() As DataTable Implements clsMRP_iface.Sele36JOBCARDBOM
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
          .SAKA2011_P3_NamaDataSet = "sp36JOBCARDBOMSele",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "sp36JOBCARDBOMSele",
          .SAKA2011_PRM_01Param = "@k01cKodeValidation_v50", .SAKA2011_PRM_01Value = prop_KeyString01}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)

    End Function

    Public Function Sele37JOBCARDSTONE() As DataTable Implements clsMRP_iface.Sele37JOBCARDSTONE
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
          .SAKA2011_P3_NamaDataSet = "sp37JOBCARDSTONESele",
          .SAKA2011_P4_ObjectDataSet = dsDataSet,
          .SAKA2011_P6_NameStoredProcedure = "sp37JOBCARDSTONESele",
          .SAKA2011_PRM_01Param = "@k01cKodeValidation_v50", .SAKA2011_PRM_01Value = prop_KeyString01,
          .SAKA2011_PRM_02Param = "@k02cKodeDesignMaster_v50", .SAKA2011_PRM_02Value = prop_KeyString02}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)

    End Function

    Public Sub Save37JOBCARDSTONE() Implements clsMRP_iface.Save37JOBCARDSTONE
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
          .SAKA2011_P6_NameStoredProcedure = "sp37JOBCARDSTONESave",
          .SAKA2011_PRM_01Param = "@tp37JOBCARDSTONE", .SAKA2011_PRM_01Value = prop_KeyDataTable01}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Sub SaveDataExecl() Implements clsMRP_iface.SaveDataExecl
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
          .SAKA2011_P6_NameStoredProcedure = "spaldoStonesMEISave",
          .SAKA2011_PRM_01Param = "@tpaldoStonesMEI", .SAKA2011_PRM_01Value = prop_KeyDataTable01}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Sub SaveGambarDONE() Implements clsMRP_iface.SaveGambarDONE
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
          .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
          .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb03GAMBAR),
          .SAKA2011_P6_NameStoredProcedure = "sp100GambarDoneSave",
          .SAKA2011_PRM_01Param = "@tp100GambarDone", .SAKA2011_PRM_01Value = prop_KeyDataTable01}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub


    Public Function Get34JumlahRubberSilverCode() As DataTable Implements clsMRP_iface.Get34JumlahRubberSilverCode
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
              .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
              .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
              .SAKA2011_P3_NamaDataSet = "sp34GetJumlahRubberSilverCode",
              .SAKA2011_P4_ObjectDataSet = dsDataSet,
              .SAKA2011_P6_NameStoredProcedure = "sp34GetJumlahRubberSilverCode",
              .SAKA2011_PRM_01Param = "@f03cGroupRubberSilver_v50", .SAKA2011_PRM_01Value = prop_KeyString01,
              .SAKA2011_PRM_02Param = "@f05cKodeDesignMaster_v50", .SAKA2011_PRM_02Value = prop_KeyString02,
              .SAKA2011_PRM_03Param = "@f18nSizeManual_n92", .SAKA2011_PRM_03Value = prop_KeyDouble01}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Function GetImageFromGUID() As DataTable Implements clsMRP_iface.GetImageFromGUID
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
              .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
              .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb04MRP),
              .SAKA2011_P3_NamaDataSet = "spGetImageFromGUID",
              .SAKA2011_P4_ObjectDataSet = dsDataSet,
              .SAKA2011_P6_NameStoredProcedure = "spGetImageFromGUID",
              .SAKA2011_PRM_01Param = "@KeyGUIDGambar", .SAKA2011_PRM_01Value = prop_KeyString01}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
        End Using

        Return dsDataSet.Tables(0)
    End Function

    Public Sub Save02GAMBARTRANSAKSI() Implements clsMRP_iface.Save02GAMBARTRANSAKSI
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb03GAMBAR),
             .SAKA2011_P6_NameStoredProcedure = "sp02GAMBARTRANSAKSISave",
             .SAKA2011_PRM_01Param = "@tp02GAMBARTRANSAKSI", .SAKA2011_PRM_01Value = prop_KeyDataTable01}

            objExecute.SAKA2011_SP_ExecuteNQ_P1P6()
        End Using
    End Sub

    Public Function Sele02GAMBARTRANSAKSI() As DataTable Implements clsMRP_iface.Sele02GAMBARTRANSAKSI
        Dim dsDataSet As New DataSet
        Using objExecute As New arisnjp01General_clsStoredProcedureExecution() With {
             .SAKA2011_P1_Server = arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasiName(arisnjp01General_clsDatabaseAndServer.SAKA2011ServerLokasi.arisnjp_Server),
             .SAKA2011_P1_NamaDatabaseTarget = arisnjp01General_clsDatabaseAndServer.SAKA2011DatabaseName(arisnjp01General_clsDatabaseAndServer.SAKA2011Database.arisnjpdb03GAMBAR),
             .SAKA2011_P3_NamaDataSet = "sp02GAMBARTRANSAKSISele",
             .SAKA2011_P4_ObjectDataSet = dsDataSet,
             .SAKA2011_P6_NameStoredProcedure = "sp02GAMBARTRANSAKSISele",
             .SAKA2011_PRM_01Param = "@k01cNoDocTransaksi_v50", .SAKA2011_PRM_01Value = prop_KeyString01,
             .SAKA2011_PRM_02Param = "@k02KeyGUIDGambar_v50", .SAKA2011_PRM_02Value = prop_KeyString02,
             .SAKA2011_PRM_03Param = "@k03cKodeFGorComponent_v50", .SAKA2011_PRM_03Value = prop_KeyString03}

            objExecute.SAKA2011_SP_IsiDataSet_P1P3P4P6()
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
