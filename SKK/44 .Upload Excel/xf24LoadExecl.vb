Public Class xf24LoadExecl

    Implements IDisposable

#Region " form Evnt "

#End Region

#Region " Custome Methods "

    Private Sub cm02LoadFIel()
        Dim hlper As New clsHelperExcel
        GridControl1.DataSource = Nothing
        GridControl1.DataSource = hlper.cm01UploadFileExecl("SOFCI")

    End Sub

#End Region

#Region " Control Evnt "

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        cm02LoadFIel()
    End Sub

#End Region

#Region " Grid Evnt "

#End Region


End Class