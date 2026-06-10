Public Class ucTESTING
    Private plIsNewData As Boolean

    Private Sub _cm01BersihkanEntrian()
        plIsNewData = True
    End Sub

    Private Sub TextEdit1_LostFocus(sender As Object, e As EventArgs) Handles TextEdit1.LostFocus

        'pcRecord = "select * from tabel where KEY = '" & TextEdit1.EditValue & "'"

        'If pcRecord.rows.count > 0 Then
        '    plIsNewData = False
        'Else
        '    plIsNewData = True
        'End If
    End Sub

    Private Sub _cm02SimpanData()
        'Dim pcKodeProses As String
        'Dim pcOperational As String
        'If plIsNewData Then
        '    pcKodeProses = "P0100"
        '    pcOperational = "ADMIN"
        'Else
        '    pcKodeProses = "P0110"
        '    pcOperational = operator
        'End If
        ''IsiKeCOntroller
        ''execModelSimpan
    End Sub
End Class
