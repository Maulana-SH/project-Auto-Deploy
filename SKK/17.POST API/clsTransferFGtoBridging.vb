Imports System.Data.SqlClient
Imports DevExpress.XtraEditors.ColorPick

Public Class clsTransferFGtoBridging
    Implements IDisposable

    Public Property prop_01dtSKUSaja As DataTable
    Public Property prop_cNoDokumen As String
    Public Property prop_SQLCopy As String
    Public Property prop_nTotalSPK As Integer

    ' SERVER BRIDGING
    'Const SERVERADDRESS As String = "172.25.0.4,4202"
    'Const DATABASE As String = "WH"
    'Const USER_ID As String = "sa"
    'Const PASSWORD As String = "nasa@123"

    ' ******************* SERVER JIMS SA *********************
    'Const SERVERADDRESS As String = "172.25.0.3,1500"
    'Const DATABASE As String = "WH"
    'Const USER_ID As String = "sa"
    'Const PASSWORD As String = "D-&:.4aC,Q5(}`<#~6m3t"

    Const SERVERADDRESS As String = "172.25.0.3,1500"
    Const DATABASE As String = "WH"
    Const USER_ID As String = "wh"
    Const PASSWORD As String = "qj;rCkU3F(/5c~QNVwRys!"
    ' ****************************************

    '' TESTINg
    'Const SERVERADDRESS As String = "MAULANADEV"
    'Const DATABASE As String = "WH"
    'Const USER_ID As String = "sa"
    'Const PASSWORD As String = "asdf@123"

#Region " Olld Methods"

    Private Function cm00GetConnectionStringSQL()

        ' karna ada character ; pada pass sql pakai  Sql builder string
        Dim builder As New SqlConnectionStringBuilder()
        builder.DataSource = SERVERADDRESS
        builder.InitialCatalog = DATABASE
        builder.UserID = USER_ID
        builder.Password = PASSWORD

        Return builder.ConnectionString
    End Function

    Private Function _cm01GetDataDO(ByVal prmcNoDocument As String) As DataTable
        Dim pdHasil As New DataTable

        'Ini UNtuk Trasfer Lamgsung Dari From MUTASIAN
        If prmcNoDocument = "" Then
            Using objDataFG2Bridging As NCMODELlib.clsNEWCENTRAL_iface = New NCMODELlib.clsNEWCENTRAL_impl With {.prop_tp01SKUSAJA = prop_01dtSKUSaja}
                pdHasil = objDataFG2Bridging.GetTP9HV01TransferFG2Bridging()
            End Using
        Else
            'Ini UNtuk Trasfer Lamgsung Dari Retransfer
            Using objDataFG2BridgingPerDoc As NCMODELlib.clsNEWCENTRAL_iface = New NCMODELlib.clsNEWCENTRAL_impl With {.prop_cNoDokumen = prmcNoDocument}
                pdHasil = objDataFG2BridgingPerDoc.GetTP9HV02TransferFG2BridgingPerDoc()
            End Using
        End If

        Return pdHasil
    End Function

    Private Function _cm02GetSQLString(ByVal prmcNoDocument As String) As String
        Dim pcSQL As String = ""
        Dim pcSIZE As String = ""
        Dim pcSQLFinal As String = ""

        Dim pdHasil As New DataTable
        pdHasil = _cm01GetDataDO(prmcNoDocument)

        Dim pnTotRows As Integer = pdHasil.Rows.Count
        If pdHasil.Rows.Count > 0 Then

            Dim size As Integer = 0
            For Each dtRow As DataRow In pdHasil.Rows

                '=================== UNTUK CEK SIZE ======================

                ' Jika Size bukan integer di set 0
                ' Untuk Krim ke APP JIMS (SBU)

                '=========================================================

                If Integer.TryParse(dtRow("f17nSize"), size) Then
                    'MsgBox("Value Benar Integer")
                    size = CInt(dtRow("f17nSize"))
                Else
                    'MsgBox("Value Bukan Integer")
                    size = 0
                End If

                pcSQL = "('" + dtRow("f01cNoDO").ToString + "','" + dtRow("f02cKodeKaret").ToString + "','" + dtRow("f03cSKU").ToString + "',
                        '" + dtRow("f04cKodeNORO").ToString + "','" + dtRow("f05cNamaNORO").ToString + "','" + dtRow("f06cKodeWarnaEmas").ToString + "',
                        '" & dtRow("f07cNamaWarnaEmas").ToString & "','" & dtRow("f08cKodeKadarEmas").ToString & "','" & dtRow("f09cNamaKadarEmas").ToString & "', 
                        '" & dtRow("f10cKodeTipeBRJ").ToString & "','" & dtRow("f11cNamaTipeBRJ").ToString & "'," & CDbl(dtRow("f12nQtyLot")) & ",
                        " & CDbl(dtRow("f13nBeratGross")) & "," & CDbl(dtRow("f14nBeratNett")) & "," & CDbl(dtRow("f15nTGramZircon")) & ",
                        " & CInt(dtRow("f16TButirZircon")) & ",'" & size & "','" & dtRow("f18cKodeProduksi").ToString & "')"

                pnTotRows = pnTotRows - 1
                If pnTotRows > 0 Then
                    pcSQLFinal = pcSQLFinal + pcSQL + ","
                Else
                    pcSQLFinal = pcSQLFinal + pcSQL
                End If
            Next
        End If

        prop_SQLCopy = pcSQLFinal

        Return pcSQLFinal
    End Function

    'Olld FUnctions
    'Public Sub _cm03TransferFG2Bridging(Optional prmcNoDocument As String = "")
    '    Dim connetionString As String
    '    Dim sql As String

    '    Dim pcSQL As String
    '    pcSQL = _cm02GetSQLString(prmcNoDocument)

    '    'connetionString = "Server = 192.168.3.211;Database = CITRIX;USER ID = sa;PASSWORD= gedung@08"
    '    'sql = "insert into FINISHGOODS " +
    '    '      "         ([f01cNoDO], [f02cKodeKaret], [f03cSKU], [f04cKodeNORO], [f05cNamaNORO], " +
    '    '      "          [f06cKodeWarnaEmas], [f07cNamaWarnaEmas], [f08cKodeKadarEmas], [f09cNamaKadarEmas], [f10cKodeTipeBRJ], " +
    '    '      "          [f11cNamaTipeBRJ], [f12nQtyLot], [f13nBeratGross], [f14nBeratNett], [f15nTGramZircon], " +
    '    '      "          [f16TButirZircon], [f17nSize]) " +
    '    '      " values " + pcSQL
    '    'gedung@08
    '    connetionString = "Server = 192.168.2.12;Database = CITRIX;USER ID = skk;PASSWORD= gedung@08"
    '    sql = "insert into FINISHGOODS " +
    '          "         ([f01cNoDO], [f02cKodeKaret], [f03cSKU], [f04cKodeNORO], [f05cNamaNORO], " +
    '          "          [f06cKodeWarnaEmas], [f07cNamaWarnaEmas], [f08cKodeKadarEmas], [f09cNamaKadarEmas], [f10cKodeTipeBRJ], " +
    '          "          [f11cNamaTipeBRJ], [f12nQtyLot], [f13nBeratGross], [f14nBeratNett], [f15nTGramZircon], " +
    '          "          [f16TButirZircon], [f17nSize], [f18cKodeProduksi]) " +
    '          " values " + pcSQL
    '    Try
    '        Using objConnDB As SqlConnection = New SqlConnection(connetionString)
    '            With objConnDB
    '                .Open()

    '                Dim objCommand As SqlCommand = .CreateCommand()
    '                Dim nHasil As Integer = 0

    '                With objCommand

    '                    ' Must assign both transaction object and connection
    '                    ' to Command object for a pending local transaction.
    '                    Try
    '                        Clipboard.SetText(sql)
    '                        .CommandText = sql
    '                        .CommandType = CommandType.Text
    '                        .Connection = objConnDB

    '                        nHasil = .ExecuteNonQuery()

    '                    Catch ex As Exception
    '                        MsgBox(ex.Message)

    '                    End Try

    '                End With
    '                objCommand.Dispose()

    '                .Close()
    '            End With
    '        End Using
    '    Catch ex As Exception
    '        MsgBox("Maaf ... koneksi ke server BRIDGING GAGAL ......... ! ", vbOKOnly + vbInformation, "NEW RJS")
    '    End Try

    'End Sub
#End Region


    Public Sub _cm03TransferFG2Bridging(ByVal prmDataInbound As DataTable)
        Dim connetionString As String

        'connetionString = "Server=172.25.0.4,4202;Database=WH;USERID=sa;PASSWORD=nasa@123"
        'connetionString = String.Format("Server = {0};Database = {1};USER ID = {2};PASSWORD= {3}", SERVERADDRESS, DATABASE, USER_ID, PASSWORD)
        connetionString = cm00GetConnectionStringSQL()

        Try
            Using objConnDB As SqlConnection = New SqlConnection(connetionString)
                With objConnDB
                    .Open()

                    Using objSqlCommand As New SqlCommand() With {.Connection = objConnDB,
                                                                  .CommandType = CommandType.StoredProcedure,
                                                                  .CommandText = "spFINISHGOODSSave",
                                                                  .CommandTimeout = 60}
                        objSqlCommand.Parameters.AddWithValue("@tpDataForSaving", prmDataInbound)

                        Dim objAdapter As SqlDataAdapter = New SqlDataAdapter(objSqlCommand)

                        Dim Result As Integer = objAdapter.SelectCommand.ExecuteNonQuery()

                        If Result > 0 Then
                            MsgBox($"( {prop_nTotalSPK} ) SPK, Dengan { Result } SKU BRIDGING Berhasil Di kirim ...")
                        Else
                            MsgBox("Data BRIDGING Gagal Di Simpan ...")
                        End If


                    End Using

                    objConnDB.Dispose()
                    .Close()
                End With
            End Using
        Catch ex As Exception
            MsgBox("Maaf ... koneksi ke server BRIDGING GAGAL ......... ! " & vbNewLine & ex.Message, vbOKOnly + vbInformation, "NEW RJS")
        End Try

    End Sub


    Public Sub _cm04TransferFG2BridgingHeader(ByVal prmDataInbound As DataTable)
        Dim connetionString As String

        'connetionString = "Server=172.25.0.4,4202;Database=WH;USERID=sa;PASSWORD=nasa@123"
        'connetionString = String.Format("Server={0};Database={1};USER ID={2};PASSWORD=\{3};", SERVERADDRESS, DATABASE, USER_ID, PASSWORD)
        connetionString = cm00GetConnectionStringSQL()

        Try
            Using objConnDB As SqlConnection = New SqlConnection(connetionString)
                With objConnDB
                    .Open()

                    Using objSqlCommand As New SqlCommand() With {.Connection = objConnDB,
                                                                  .CommandType = CommandType.StoredProcedure,
                                                                  .CommandText = "spINISHGOODWHMastersSave",
                                                                  .CommandTimeout = 60}
                        objSqlCommand.Parameters.AddWithValue("@tpDataForSaving", prmDataInbound)

                        Dim objAdapter As SqlDataAdapter = New SqlDataAdapter(objSqlCommand)

                        Dim Result As Integer = objAdapter.SelectCommand.ExecuteNonQuery()

                        If Result > 0 Then
                            MsgBox($" { Result } SPK Berhasil BRIDGING Berhasil Di kirim ...")
                        Else
                            MsgBox("Data BRIDGING Gagal Di Simpan ...")
                        End If


                    End Using

                    objConnDB.Dispose()
                    .Close()
                End With
            End Using
        Catch ex As Exception
            MsgBox("Maaf ... koneksi ke server BRIDGING GAGAL ......... ! " & vbNewLine & ex.Message, vbOKOnly + vbInformation, "NEW RJS")
        End Try

    End Sub

#Region "IDisposable Support"
    Private disposedValue As Boolean ' To detect redundant calls

    ' IDisposable
    Protected Overridable Sub Dispose(disposing As Boolean)
        If Not disposedValue Then
            If disposing Then
                ' TODO: dispose managed state (managed objects).
            End If

            ' TODO: free unmanaged resources (unmanaged objects) and override Finalize() below.
            ' TODO: set large fields to null.
        End If
        disposedValue = True
    End Sub

    ' TODO: override Finalize() only if Dispose(disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(disposing As Boolean) above.
        Dispose(True)
        ' TODO: uncomment the following line if Finalize() is overridden above.
        ' GC.SuppressFinalize(Me)
    End Sub
#End Region

End Class
