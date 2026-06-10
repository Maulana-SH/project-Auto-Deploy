Imports System.Data.SqlClient
Imports NCCORElib
Imports NCMODELlib

Public Class xf35AsycnsAwait
    Implements IDisposable

    Private pdtMaster As New DataTable

#Region "form Event"
    Private Sub xf35AsycnsAwait_Load(sender As Object, e As EventArgs) Handles Me.Load
        Console.WriteLine("Data Load")
        GridView1.OptionsView.ColumnAutoWidth = False

        'pdtMaster = Await cm01Getdata()
    End Sub


#End Region

#Region "Costume Methods"


    Private Async Function cm01Getdata() As Task(Of DataTable)
        Dim pdtHasil As New DataSet


        Try
            Using objConnDB As New SqlConnection(arisnjp01General_clsDatabaseAndServer.SAKA2011_NET_ConnectionSTRING("192.168.2.155", "MRP"))
                Await objConnDB.OpenAsync()

                Using objSQLCommand As New SqlCommand() With {.Connection = objConnDB,
                                                              .CommandText = "sp51MasterAllSKK",
                                                              .CommandType = CommandType.StoredProcedure}


                    pdtHasil.Clear()

                    Dim objAdapter As SqlDataAdapter = New SqlDataAdapter(objSQLCommand)

                    'objAdapter.SelectCommand.ExecuteNonQuery()
                    Await objAdapter.SelectCommand.ExecuteNonQueryAsync()
                    objAdapter.Fill(pdtHasil, "Dataset51W")


                End Using

                objConnDB.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Console.WriteLine("Data Load Selesai")
        Return pdtHasil.Tables(0)
    End Function

    Private Async Function cm02Getdata() As Task(Of DataTable)
        Dim pdtHasil As New DataTable

        Try
            Using objConnDB As New SqlConnection(arisnjp01General_clsDatabaseAndServer.SAKA2011_NET_ConnectionSTRING("192.168.2.155", "MRP"))
                Await objConnDB.OpenAsync()

                Using objSQLCommand As New SqlCommand() With {.Connection = objConnDB,
                                                              .CommandText = "sp51MasterAllSKK",
                                                              .CommandType = CommandType.StoredProcedure}


                    pdtHasil.Clear()

                    'Dim objAdapter As SqlDataAdapter = New SqlDataAdapter(objSQLCommand)

                    'objAdapter.SelectCommand.ExecuteNonQuery()
                    ' Await objAdapter.SelectCommand.ExecuteNonQueryAsync()
                    'objAdapter.Fill(pdtHasil, "Dataset51W")

                    Dim objReader As SqlDataReader
                    objReader = objSQLCommand.ExecuteReader()
                    Await objReader.ReadAsync
                    pdtHasil.Load(objReader)


                End Using

                objConnDB.Close()
            End Using
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        Console.WriteLine("Data Load Selesai")
        Return pdtHasil
    End Function


    Private Async Function cm03FromModel() As Task(Of DataTable)
        Dim pdtHasil As DataTable
        Using objGetdata As clsNEWCENTRAL_iface = New clsNEWCENTRAL_impl With {.prop_nTarget = 1, .prop_11dTanggal = Date.Now}
            pdtHasil = Await objGetdata.GetDataCurrent_Async
        End Using

        Return pdtHasil
    End Function

#End Region

#Region "Control Event"

    'Private Sub btnSycns_Click(sender As Object, e As EventArgs) Handles btnSycns.Click
    '    Me.Cursor = Cursors.WaitCursor

    '    GridControl1.DataSource = Nothing
    '    GridControl1.DataSource = cm01Getdata()
    '    GridView1.BestFitColumns()

    '    MsgBox("Get data Selesai...")
    '    Me.Cursor = Cursors.Default
    'End Sub


    Private Async Sub btnAsycns_Click(sender As Object, e As EventArgs) Handles btnAsycns.Click
        Console.WriteLine("Data Load")
        'Dim dt As DataTable = Await cm01Getdata()
        ' Dim dt As DataTable = Await cm02Getdata()

        'Dim dt As DataTable = Await cm03FromModel()
        GridView1.ShowLoadingPanel()

        GridControl1.DataSource = Await cm03FromModel()
        GridControl1.RefreshDataSource()

        Console.WriteLine("Data selesai Load")
        GridView1.HideLoadingPanel()

        'Dim jmlhData As Integer = 0
        'jmlhData = pdtMaster.Rows.Count
        'Console.WriteLine("Data =" & jmlhData)
    End Sub

    Private Sub btnSycns_Click(sender As Object, e As EventArgs) Handles btnSycns.Click
        MsgBox("Load data Berjalan")
    End Sub

#End Region

End Class