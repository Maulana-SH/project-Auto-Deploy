Public Class frmGougeControl
    Private Sub SpinEdit1_EditValueChanged(sender As Object, e As EventArgs) Handles SpinEdit1.EditValueChanged

        'ArcScaleComponent1.Value = SpinEdit1.EditValue'

        LinearScaleLevelComponent1.Value = CSng(SpinEdit1.EditValue)

    End Sub

    Private Sub SpinEdit2_EditValueChanged(sender As Object, e As EventArgs) Handles SpinEdit2.EditValueChanged
        LinearScaleMarkerComponent1.Value = CSng(SpinEdit2.EditValue)
    End Sub

    Private Sub SpinEdit3_EditValueChanged(sender As Object, e As EventArgs) Handles SpinEdit3.EditValueChanged
        LinearScaleLevelComponent1.Value = CSng(SpinEdit3.EditValue)

    End Sub
End Class