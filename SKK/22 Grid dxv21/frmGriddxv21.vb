Imports DevExpress.XtraGrid.Views.WinExplorer

Public Class frmGriddxv21

#Region " from evnt "

    Private Sub frmGriddxv21_Load(sender As Object, e As EventArgs) Handles Me.Load
        cm00InitField()
    End Sub
#End Region


#Region " costume methods"

    Private Sub cm00InitField()

        col01_k01cKodeProduct_v50.FieldName = "k01cKodeProduct_v50"
        col02_f01cNamaProduct_v50.FieldName = "f01cNamaProduct_v50"
        col03_f01objGambar.FieldName = "f01objGambar"
        col04_f04cNamaItemProduct_v50.FieldName = "f04cNamaItemProduct_v50"

    End Sub

    Private Sub cm01Getdata()

        Me.Cursor = Cursors.WaitCursor

        Dim pdthasil As New DataTable
        pdthasil.Clear()

        Using objGEt As NCMODELlib.clsMRP_iface = New NCMODELlib.clsMRP_impl
            pdthasil = objGEt.seleGambarProduct
        End Using


        gcProduk.DataSource = Nothing
        gcProduk.DataSource = pdthasil
        gcProduk.Refresh()

        Me.Cursor = Cursors.Default
    End Sub

#End Region
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        cm01Getdata()
    End Sub

    Private Sub WinExplorerView1_CustomizeItem(sender As Object, e As CustomizeWinExplorerViewItemArgs) Handles WinExplorerView1.CustomizeItem

    End Sub
End Class