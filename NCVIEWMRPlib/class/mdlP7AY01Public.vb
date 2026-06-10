Imports NCMODELlib

Public Module mdlP7AY01Public

    Public Enum IsDJorZC
        IsDJZC = 0
        IsDJ = 1
        IsZC = 2
    End Enum

    Public Enum TargetTransaksiZirconSisaTambah
        ProcurementZircon = 0
        PermintaanSKTambahZircon = 1
        ProsesSKSisaZircon = 2
        ApproveTambahZircon = 3
        ApproveSisaZircon = 4
    End Enum

    Public Enum _enumTargetGridProsesTK
        ProsesCORAkhir = 0
        ProsesTKAwal = 1
        ProsesTKAkhir = 2
        ProsesTKDisplay = 3
    End Enum

    Public Enum _enumIDAutoNumbering
        _idWOTK = 0
        _idBONZIRCON = 1
        _idDOTI = 2
        _idGAGALPRODUKSI = 3
        _idLEBUR = 4
        _idDEPOSITBOX = 5
        _idPOHONEMAS = 6
        _idCOREMAS = 7
        _idJCAD = 8
        _idPRODEV = 9
        _idPDDOMUTASI = 10
        _idPDWOOPERATOR = 11
        _idPDPROJECTS = 12
        _idPDDOCBOM = 13
        _idPACKTB = 14
    End Enum
    'pcSKU = CreateNoWOSKU(_enumIDAutoNumbering._idPRODEV)
    Public Function CreateNoWOSKU(ByVal idAutoNumbering As _enumIDAutoNumbering) As String
        Dim plHasil As String = ""
        Dim pcidAutoNumbering As String = ""

        Select Case idAutoNUmbering
            Case _enumIDAutoNumbering._idWOTK
                pcidAutoNumbering = "WOTK"
            Case _enumIDAutoNumbering._idBONZIRCON
                pcidAutoNumbering = "BONZIRCON"
            Case _enumIDAutoNumbering._idDOTI
                pcidAutoNumbering = "DOTI"
            Case _enumIDAutoNumbering._idGAGALPRODUKSI
                pcidAutoNumbering = "GAGALPRODUKSI"
            Case _enumIDAutoNumbering._idLEBUR
                pcidAutoNumbering = "LEBUR"
            Case _enumIDAutoNumbering._idDEPOSITBOX
                pcidAutoNumbering = "DEPOSITBOX"
            Case _enumIDAutoNumbering._idPOHONEMAS
                pcidAutoNumbering = "POHONEMAS"
            Case _enumIDAutoNumbering._idCOREMAS
                pcidAutoNumbering = "COREMAS"
            Case _enumIDAutoNumbering._idJCAD
                pcidAutoNumbering = "JCAD"
            Case _enumIDAutoNumbering._idPRODEV
                pcidAutoNumbering = "PRODEV"
            Case _enumIDAutoNumbering._idPDDOMUTASI
                pcidAutoNumbering = "PDDOMUTASI"
            Case _enumIDAutoNumbering._idPDWOOPERATOR
                pcidAutoNumbering = "PDWOOPERATOR"
            Case _enumIDAutoNumbering._idPDPROJECTS
                pcidAutoNumbering = "PDPROJECTS"
            Case _enumIDAutoNumbering._idPDDOCBOM
                pcidAutoNumbering = "PDEVDOCBOM"
            Case _enumIDAutoNumbering._idPACKTB
                pcidAutoNumbering = "PACKTB"
        End Select

        'create no WO Tukang
        Dim pdtNoDokumen As New DataTable
        Using objCreateNoDoc As NCMODELlib.clsNEWCENTRAL_impl = New clsNEWCENTRAL_impl With {.prop_04cKodeSBU = "MSBU1",
                                                                                             .prop_05cIDAutoNumber = pcidAutoNumbering,
                                                                                             .prop_06nTahun_int = Year(Now.Date),
                                                                                             .prop_07nIncrementNumber = 1}

            pdtNoDokumen = objCreateNoDoc.Get92CreateSKU()
        End Using

        For Each dtrow As DataRow In pdtNoDokumen.Rows
            plHasil = dtrow("f04cPrefix1_v2") + dtrow("f05cPrefix2_v2") + dtrow("f07nLastNumber_int").ToString
        Next

        Return plHasil
    End Function

End Module

