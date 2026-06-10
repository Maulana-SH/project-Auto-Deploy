Public Class xfBtnOnOff
    Private Sub _tgsOnOff_IsOnChanged(sender As Object, e As EventArgs) Handles _tgsOnOff.IsOnChanged
        ' MsgBox("RFID DI NAYALAKan")
    End Sub

    Private Sub _tgsOnOff_Toggled(sender As Object, e As EventArgs) Handles _tgsOnOff.Toggled
        _02cStatus.EditValue = _tgsOnOff.EditValue.ToString
    End Sub
End Class