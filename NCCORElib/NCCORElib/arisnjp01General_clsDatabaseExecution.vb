Imports System.Data.SqlClient

Public Class arisnjp01General_clsDatabaseExecution
    Implements IDisposable

    Public Property SAKA2011_P1_Server() As String
    Public Property SAKA2011_P1_NamaDatabaseTarget() As String
    Public Property SAKA2011_P2_PerintahSQL() As String
    Public Property SAKA2011_P3_NamaDataSet() As String
    Public Property SAKA2011_P4_ObjectDataSet() As DataSet
    Public Property SAKA2011_P5_ObjectDataView() As DataView
    Public Property SAKA2011_P6_Corp As String

    Public Sub New()
        SAKA2011_P6_Corp = "SIMATIK767@2013 - " & Year(Now.Date)
    End Sub

    Public Sub SAKA2011_1_IsiDataSet_P1P2P3P4()
        Using objConnDB As New SqlConnection(arisnjp01General_clsDatabaseAndServer.SAKA2011_NET_ConnectionSTRING(SAKA2011_P1_Server, SAKA2011_P1_NamaDatabaseTarget))
            objConnDB.Open()

            Dim objAdapter As SqlDataAdapter = New SqlDataAdapter(SAKA2011_P2_PerintahSQL, objConnDB)

            SAKA2011_P4_ObjectDataSet.Clear()
            objAdapter.Fill(SAKA2011_P4_ObjectDataSet, SAKA2011_P3_NamaDataSet)

            objAdapter.Dispose()
            objConnDB.Close()
        End Using
    End Sub

    Public Function SAKA2011_2_ExecuteNonQuery_P1P2(Optional ByVal prmcIntiSQL_IUD As String = "I", _
                                            Optional ByVal prmbDisplayPesan As Boolean = True) As Boolean
        Dim plHasil As Boolean = False

        Dim pcPesan As String = ""

        Select Case prmcIntiSQL_IUD
            Case "I" 'INSERT
                pcPesan = "INSERT DATA"
            Case "U" 'UPDATE
                pcPesan = "UPDATE DATA"
            Case "D" 'DELETE
                pcPesan = "DELETE DATA"
            Case Else
        End Select

        Dim pnQuestionResult As MsgBoxResult
        If prmbDisplayPesan Then
            pnQuestionResult = MsgBox(String.Format("Anda yakin akan melakukan proses {0} ini ...?", pcPesan), MsgBoxStyle.YesNo, SAKA2011_P6_Corp)
        Else
            pnQuestionResult = MsgBoxResult.Yes
        End If

        If pnQuestionResult = MsgBoxResult.Yes Then
            Try
                plHasil = SAKA2011_ExecuteSQL()
            Catch ex As Exception
                MsgBox(ex.Message)
            End Try

        Else
            MsgBox(String.Format("Proses {0} ... DIBATALKAN....", pcPesan), MsgBoxStyle.OkOnly + MsgBoxStyle.Information, SAKA2011_P6_Corp)
        End If

        If pnQuestionResult = MsgBoxResult.Yes Then
            If prmbDisplayPesan Then
                If plHasil Then
                    MsgBox(String.Format("Proses {0} ... BERHASIL....", pcPesan), MsgBoxStyle.OkOnly + MsgBoxStyle.Information, SAKA2011_P6_Corp)
                Else
                    MsgBox(String.Format("Proses {0} ... G A G A L....", pcPesan), MsgBoxStyle.OkOnly + MsgBoxStyle.Information, SAKA2011_P6_Corp)
                End If
            End If
        End If

        Return plHasil
    End Function

    Public Sub SAKA2011_3_IsiDataTableView_P1P2P3P4P5(ByVal prmcNamaFieldSort As String)
        SAKA2011_1_IsiDataSet_P1P2P3P4()

        SAKA2011_P5_ObjectDataView = New DataView(SAKA2011_P4_ObjectDataSet.Tables(SAKA2011_P3_NamaDataSet)) With {.Sort = prmcNamaFieldSort}
    End Sub

    Public Function SAKA2011_4_RowCount_P1P2P3P4() As Integer
        SAKA2011_4_RowCount_P1P2P3P4 = 0

        SAKA2011_1_IsiDataSet_P1P2P3P4()
        SAKA2011_4_RowCount_P1P2P3P4 = SAKA2011_P4_ObjectDataSet.Tables(0).Rows.Count

        Return SAKA2011_4_RowCount_P1P2P3P4
    End Function

    Private Function SAKA2011_ExecuteSQL() As Boolean
        Dim plHasil As Boolean = True

        Using objConnDB As SqlConnection = New SqlConnection(arisnjp01General_clsDatabaseAndServer.SAKA2011_NET_ConnectionSTRING(SAKA2011_P1_Server, SAKA2011_P1_NamaDatabaseTarget))
            With objConnDB
                .Open()

                Dim objCommand As SqlCommand = .CreateCommand()
                Dim nHasil As Integer = 0

                With objCommand

                    ' Must assign both transaction object and connection
                    ' to Command object for a pending local transaction.
                    Try
                        .CommandText = SAKA2011_P2_PerintahSQL
                        .CommandType = CommandType.Text
                        .Connection = objConnDB

                        nHasil = .ExecuteNonQuery()

                    Catch ex As Exception
                        plHasil = False

                    End Try

                End With
                objCommand.Dispose()

                .Close()
            End With
        End Using

        Return plHasil

    End Function

    'Public Shared Function SAKA2011_3_IsThereRecords(ByVal prmcSQLQuery As String, ByVal prmcServer As String, ByVal prmcNamaDatabase As String, _
    '                                                 ByVal prmcPesanError As String, _
    '                                                 Optional ByVal plDisplayErrorJikaFalse As Boolean = True, _
    '                                                 Optional ByVal plDisplayPesanError As Boolean = True) As Boolean
    '    Dim plHasil As Boolean = False

    '    Using objNASAConnection As New SqlConnection(aiONE01General_clsDatabaseAndServer.SAKA2011_NET_ConnectionSTRING(prmcServer, prmcNamaDatabase))
    '        Dim objCommand As New SqlCommand(prmcSQLQuery, objNASAConnection)
    '        objNASAConnection.Open()

    '        Dim objNASA_Reader As SqlDataReader = objCommand.ExecuteReader()

    '        With objNASA_Reader
    '            If .HasRows Then
    '                plHasil = True
    '            End If
    '            .Close()
    '        End With

    '        objNASA_Reader = Nothing
    '        objCommand.Dispose()
    '    End Using

    '    If plDisplayPesanError Then
    '        If plDisplayErrorJikaFalse Then
    '            If Not plHasil Then
    '                MsgBox(prmcPesanError, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, aiONE01General_clsVariabelGlobal.prop_vg007_gcaiONE_Corp)
    '            End If
    '        Else
    '            If plHasil Then
    '                MsgBox(prmcPesanError, MsgBoxStyle.OkOnly + MsgBoxStyle.Information, aiONE01General_clsVariabelGlobal.prop_vg007_gcaiONE_Corp)
    '            End If
    '        End If
    '    End If

    '    Return plHasil
    'End Function

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

    ' TODO: override Finalize() only if Dispose(ByVal disposing As Boolean) above has code to free unmanaged resources.
    'Protected Overrides Sub Finalize()
    '    ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
    '    Dispose(False)
    '    MyBase.Finalize()
    'End Sub

    ' This code added by Visual Basic to correctly implement the disposable pattern.
    Public Sub Dispose() Implements IDisposable.Dispose
        ' Do not change this code.  Put cleanup code in Dispose(ByVal disposing As Boolean) above.
        Dispose(True)
        GC.SuppressFinalize(Me)
    End Sub
#End Region


End Class
