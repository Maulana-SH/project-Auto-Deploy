Imports NCMODELlib

Module mdl20AY01Public

    Public Enum _enumIDAutoNumbering
        _idSKU = 0
        _idSKUSILVER = 1
        _idSKUFINDING = 2
    End Enum

    Public Function CreateNoWOSKU(ByVal idAutoNumbering As _enumIDAutoNumbering) As String
        Dim plHasil As String = ""
        Dim pcidAutoNumbering As String = ""

        Select Case idAutoNumbering
            Case _enumIDAutoNumbering._idSKU
                pcidAutoNumbering = "SKU"
            Case _enumIDAutoNumbering._idSKUSILVER
                pcidAutoNumbering = "SKUSILVER"
            Case _enumIDAutoNumbering._idSKUFINDING
                pcidAutoNumbering = "SKUFINDING"
        End Select

        'create no WO Tukang
        'Dim pdtNoDokumen As New DataTable
        'Using objCreateNoDoc As clsNEWCENTRAL_impl = New clsNEWCENTRAL_impl With {.prop_04cKodeSBU = "MSBU1",
        '                                                                          .prop_05cIDAutoNumber = pcidAutoNumbering,
        '                                                                          .prop_06nTahun_int = Year(Now.Date),
        '                                                                          .prop_07nIncrementNumber = 1}

        '    pdtNoDokumen = objCreateNoDoc.Get92CreateSKU()
        'End Using

        'For Each dtrow As DataRow In pdtNoDokumen.Rows
        '    plHasil = dtrow("f04cPrefix1_v2") + dtrow("f05cPrefix2_v2") + dtrow("f07nLastNumber_int").ToString
        'Next

        Return plHasil
    End Function

    Public Enum _enumSKKIDAutoNumbering
        _idFCI = 0
        _idFCS = 1
    End Enum

    Public Function CreateSKKIDNumbering(ByVal idSKKAutoNumbering As _enumSKKIDAutoNumbering,
                                         ByVal prmnTahun As Integer) As String
        Dim plHasil As String = ""
        Dim pcidSKKAutoNumbering As String = ""

        Select Case idSKKAutoNumbering
            Case _enumSKKIDAutoNumbering._idFCI
                pcidSKKAutoNumbering = "FCI"
            Case _enumSKKIDAutoNumbering._idFCS
                pcidSKKAutoNumbering = "FCS"
        End Select

        'create SKK ID Numbering
        Dim pdtNoDokumen As New DataTable
        Using objCreateNoDoc As clsMRP_iface = New clsMRP_impl With {.prop_KeyString01 = "SKK",
                                                                     .prop_KeyString02 = pcidSKKAutoNumbering,
                                                                     .prop_KeyInt01 = prmnTahun,
                                                                     .prop_KeyInt02 = 1}

            pdtNoDokumen = objCreateNoDoc.Get52CreateIDNumbering()
        End Using

        For Each dtrow As DataRow In pdtNoDokumen.Rows
            plHasil = dtrow("f04cPrefix1_v3").ToString.Trim +
                      dtrow("f05cPrefix2_v2").ToString.Trim +
                      String.Format("{0:0000}", dtrow("f07nLastNumber_int"))
        Next

        Return plHasil
    End Function

End Module
