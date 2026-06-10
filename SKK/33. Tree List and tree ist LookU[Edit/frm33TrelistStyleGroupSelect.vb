Imports System.Data.SqlClient
Imports DevExpress.XtraGrid.Views.Base
Imports NCCONTROLLERlib

Public Class frm33TrelistStyleGroupSelect
    Implements IDisposable

    Private connectionString As String = "Server=(local);Database=KMP;User ID=sa;Password=asdf@123;Encrypt=False;"

    Private Property pdtMasterCOA As New DataTable

    Private pdtTemp As DataTable
    Private Mdlaccount As clsControllerTABLE01

    Private listMaster As List(Of MasterCOA)
    Private repocol04_f01String As repoTreelistLookUpEditCOA
#Region " form Evnt "

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        pdtTemp = New DataTable
        Mdlaccount = New clsControllerTABLE01 With {.prop_dtABLE01 = pdtTemp}
        Mdlaccount.dtInitABLE01()

        listMaster = New List(Of MasterCOA)
    End Sub


    Private Sub frm33TrelistStyleGroupSelect_Load(sender As Object, e As EventArgs) Handles Me.Load
        LoadHierarchyData()

        cm01BindingData()
        cm02IniField()
    End Sub

#End Region

#Region " Custome Methods "

    Private Sub LoadHierarchyData()
        pdtMasterCOA.Clear()
        Dim query As String = "SELECT * FROM vwMasterCOA ORDER BY Kode"

        Using conn As New SqlConnection(connectionString)
            Using cmd As New SqlCommand(query, conn)
                Try
                    conn.Open()

                    Dim adapter As New SqlDataAdapter(cmd)
                    Dim dt As New DataTable()
                    adapter.Fill(dt)

                    ' tampilkan di DataGridView (misal)
                    'DataGridView1.DataSource = dt
                    pdtMasterCOA = dt
                    ' atau kalau kamu pakai DevExpress GridControl:
                    ' GridControl1.DataSource = dt

                Catch ex As Exception
                    MessageBox.Show("Gagal memuat data: " & ex.Message)
                End Try
            End Using
        End Using
    End Sub

    Private Sub cm01BindingData()

        If pdtMasterCOA.Rows.Count > 0 Then

            listMaster.Clear()

            For Each itm As DataRow In pdtMasterCOA.Rows

                Dim items As New MasterCOA(
                            itm("Kode").ToString(),
                            itm("NameInd").ToString(),
                            itm("NameEng").ToString(),
                            itm("IdUnique").ToString(),
                            itm("ParentIdUnique").ToString(),
                            itm("Lvl").ToString()
                        )
                listMaster.Add(items)
            Next

            _01MasterCOA._01DataSource = listMaster
            _01MasterCOA.cm01BindingAwal()

        End If

    End Sub

    Private Sub cm02IniField()


        GridView1.OptionsView.NewItemRowPosition = DevExpress.XtraGrid.Views.Grid.NewItemRowPosition.Top

        col01_k03String.FieldName = "k03String"
        col02_k04String.FieldName = "k04String"
        col03_k05String.FieldName = "k05String"
        col04_f01String.FieldName = "f01String" ' untuk Repo

        'Repo
        repocol04_f01String = New repoTreelistLookUpEditCOA With {._01DataSource = listMaster}
        repocol04_f01String.cm01BindingAwal()
        col04_f01String.ColumnEdit = repocol04_f01String

        GridControl1.DataSource = Mdlaccount.prop_dtABLE01
    End Sub


#End Region

#Region " Control Evnt "

    Private Sub _01MasterCOA_EditValueChanged(sender As Object, e As EventArgs) Handles _01MasterCOA.EditValueChanged
        Dim Hasil As String

        Hasil = $" Kode {_01MasterCOA.Kode} , nama {_01MasterCOA.Nama}, Id {_01MasterCOA.Id}, Parent {_01MasterCOA.ParentId}, Lvl {_01MasterCOA.LevelMaster}"

        'MsgBox(Hasil)
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim Hasil As String

        Hasil = $" Kode {_01MasterCOA.EditValue} , nama {_01MasterCOA.Text}"
        MsgBox(Hasil)
    End Sub

#End Region

#Region " Grid Evnt "

    Private Sub GridView1_CellValueChanged(sender As Object, e As CellValueChangedEventArgs) Handles GridView1.CellValueChanged
        Dim prmKodeAccount As String = ""

        'col04_f01String
        If e.Column.FieldName = "f01String" Then

            prmKodeAccount = e.Value
            GridView1.SetFocusedRowCellValue(col01_k03String, repocol04_f01String.KodeAccount)
            MsgBox($"Kode Akun Grid {prmKodeAccount} , dari Repo {repocol04_f01String.KodeAccount}")

        End If

    End Sub
#End Region

End Class