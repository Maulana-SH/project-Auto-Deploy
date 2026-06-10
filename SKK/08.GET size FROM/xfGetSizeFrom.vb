Public Class xfGetSizeFrom
    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        Dim width As Integer = 0
        width = Me.Width

        _01cZisefrom.Text = Me.Width.ToString
        _02User.Text = CInt(width / 2).ToString


        splitINduk.SplitterPosition = CInt(width / 2)


        Dim heigthPanelKanan As Integer = 0  'with
        Dim widthhPanelKiri As Integer = 0 ' height
        heigthPanelKanan = CInt(splitINduk.Panel2.Height)
        widthhPanelKiri = CInt(splitINduk.Panel1.Width)

        splitKanan.Dock = DockStyle.Fill
        splitKiri.Dock = DockStyle.Fill
        splitKanan.SplitterPosition = heigthPanelKanan / 2
        splitKiri.SplitterPosition = widthhPanelKiri / 2


        MsgBox("Update width")
    End Sub

    Private Sub xfGetSizeFrom_Load(sender As Object, e As EventArgs) Handles Me.Load

        _01cZisefrom.Text = Me.Width.ToString
    End Sub


End Class