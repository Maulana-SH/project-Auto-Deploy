

Imports DevExpress.Utils
Imports DevExpress.XtraEditors
Imports NCMODELlib

Public Class xf24AC01StepProgressbar
    Implements IDisposable

#Region " form Evnt "

    Private Sub xf24AC01StepProgressbar_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' cm01Step()
    End Sub

#End Region

#Region " Custome Methods "

    Private Sub cm01Step()

        Dim listTask() = {"Cek Rubber", "CEK BOM", "CEK GOLD", "CEK FCI", "CEK STONES", "SETING ETA"}

        For i As Integer = 0 To listTask.Length - 1
            'MsgBox(listTask(i))

            Dim progressMRP As New StepProgressBarItem

            progressMRP.Name = listTask(i).ToString.Trim
            progressMRP.ContentBlock1.Caption = listTask(i).ToString
            progressMRP.ContentBlock2.Description = DateTime.Now
            'progressMRP.Progress = 50
            'System.Threading.Thread.Sleep(1000)
            'progressMRP.Progress = 100

            stepMRP.Items.Add(progressMRP)
        Next

    End Sub


    Private Function cm12CheckMaterial()
        '****************************
        ' cerated : Kmais 1 januari 2024
        ' Spname  =  sele24COSOMRP_v1
        ' Taget 
        ' 1 Cek Data Rubber Inventori
        ' 2 BOM Data Cheking
        ' 3 CEk FCI
        ' 4.CEK STONE
        ' 5 CEk GOLD
        ' 6 Cek saldo Material
        '****************************

        Dim pdtHasil As New DataTable
        pdtHasil.Clear()

        Using objGetData As clsMRP_iface = New clsMRP_impl

            '.prop_KeyInt01 = 0,
            pdtHasil = objGetData.seleGet_Castedpart
        End Using

        For Each itm As Object In pdtHasil.Rows
            Console.WriteLine(" item = " & itm("f01String") & "  Berat = " & itm("f02Double"))
        Next

        'GridView1.OptionsView.ColumnAutoWidth = False
        'GridControl1.DataSource = pdtHasil
        'GridControl1.RefreshDataSource()
        'GridView1.BestFitColumns()


        Return pdtHasil
    End Function

#End Region

#Region " Control Evnt "
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        'cm01Step()

        cm12CheckMaterial()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click

        Rubberproses.ContentBlock2.Caption = "Done"
        Rubberproses.ContentBlock2.Description = DateTime.Now

    End Sub
#End Region

#Region " Grid Evnt "

#End Region

End Class