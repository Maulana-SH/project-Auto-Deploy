Public Class frmanimLOADINGFULL
    Private Delay As Timer

    Public Sub _cm01Sholoading()

        Delay = New Timer

        AddHandler Delay.Tick, AddressOf hendel_delay
        Delay.Interval = 2500
        Delay.Start()



    End Sub

    Private Sub hendel_delay(sender As Object, e As EventArgs)
        Delay.Stop()
        Me.Hide()
    End Sub
End Class