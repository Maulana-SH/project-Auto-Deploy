Imports System.Windows.Controls
Imports NCMODELlib

Public Class xrFRMLogin

    Private Property Loginto As Integer = 1  '=> 0:Local 1:server Live

#Region "custom - methos"

    Private Sub _cm02EventLoginLOCAL()
        Dim pass As String = "1234"
        If _01cIdUser.EditValue = "" Then
            MsgBox("Id User Tidak Boleh Kosong", MsgBoxStyle.Information, "Information")
            _01cIdUser.Select()
        ElseIf _02cPass.EditValue = "" Then
            MsgBox("Password tidak Boleh Kosong", MsgBoxStyle.Information, "Information")
            _02cPass.Select()

        ElseIf _02cPass.EditValue <> pass Then
            MsgBox("Password Salah", MsgBoxStyle.Information, "Information")
            _02cPass.Select()
        Else
            Dim objformMenu As New NCVIEWMRPlib.ucMenu With {.Dock = DockStyle.Fill}
            Dim formMenu As New DevExpress.XtraEditors.XtraForm With {
            .Text = "© 2020 Copyright (Citrix Apps) ",
            .WindowState = FormWindowState.Maximized}

            With objformMenu
                ._01Prop_UserID = _01cIdUser.EditValue
                ._02Prop_NamaUser = _01cIdUser.EditValue
            End With
            Me.Text.Replace("Load data... 50%", "Ready to Running... 100%")
            formMenu.Controls.Add(objformMenu)
            formMenu.Show()

            _01cIdUser.EditValue = ""
            _02cPass.EditValue = ""
        End If
    End Sub

    Private Sub _cm01EventLogin()
        Me.Text = "Conection to System..."
        Dim userID As String = _01cIdUser.EditValue
        Dim pass As String = _02cPass.EditValue

        If _01cIdUser.EditValue = "" Then
            MsgBox("Id User Tidak Boleh Kosong", MsgBoxStyle.Information, "Information")
            _01cIdUser.Select()
            Me.Text = "© 2020 Citrix App v01.01"
        ElseIf _02cPass.EditValue = "" Then
            MsgBox("Password tidak Boleh Kosong", MsgBoxStyle.Information, "Information")
            _02cPass.Select()
            Me.Text = "© 2020 Citrix App v01.01"
        Else


            Dim dataLogin As DataTable
            Using ObjLOGIN As clsNEWCENTRAL_iface = New clsNEWCENTRAL_impl With {
                .prop_02cUserID = userID,
                .prop_03cKeyPass = pass}
                dataLogin = ObjLOGIN.Get90USER()
            End Using

            If dataLogin.Rows.Count > 0 Then
                Me.Text = "Load Mastering... 50%"
                MsgBox("Login Berhasil ..", MsgBoxStyle.Information, "Information")
                Dim objformMenu As New NCVIEWMRPlib.ucMenu With {.Dock = DockStyle.Fill}
                Dim formMenu As New DevExpress.XtraEditors.XtraForm With {
                .Text = "© 2020 Copyright (Citrix Apps) ",
                .WindowState = FormWindowState.Maximized}

                With objformMenu
                    ._01Prop_UserID = dataLogin.Rows(0).Item("k01cUserID_v50")
                    ._02Prop_NamaUser = dataLogin.Rows(0).Item("f01cNamaUser_v50")
                End With
                Me.Text = "Ready to Running... 100%"
                formMenu.Controls.Add(objformMenu)
                formMenu.Show()

                _01cIdUser.EditValue = ""
                _02cPass.EditValue = ""
            Else
                MsgBox("Login Gagal Pastikan Username & Password Benar", MsgBoxStyle.Information, "Information")
            End If

        End If
    End Sub

    Private Sub cm04CekSesionLogin()
        ' Tode CODe cek

        Dim user_login As Object
    End Sub

    Private Sub cm03LoadIPAddressfunct()
        ' todo code 
    End Sub
#End Region

    Private Sub xrFRMLogin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        _01cIdUser.EditValue = ""
        _02cPass.EditValue = ""
    End Sub

    Private Sub SimpleButton1_Click_1(sender As Object, e As EventArgs) Handles SimpleButton1.Click

        Dim setloginTo As Integer
        setloginTo = Loginto
        Select Case setloginTo
            Case 0
                _cm02EventLoginLOCAL()
            Case 1
                _cm01EventLogin()
        End Select
    End Sub

    Private Sub _02cPass_KeyDown(sender As Object, e As KeyEventArgs) Handles _02cPass.KeyDown

        If e.KeyCode = Keys.Enter Then
            Dim setloginTo As Integer
            setloginTo = Loginto
            Select Case setloginTo
                Case 0
                    _cm02EventLoginLOCAL()
                Case 1
                    _cm01EventLogin()
            End Select
        End If

    End Sub

    Private Sub _01cIdUser_KeyDown(sender As Object, e As KeyEventArgs) Handles _01cIdUser.KeyDown

        If e.KeyCode = Keys.Enter Then
            Dim setloginTo As Integer
            setloginTo = Loginto
            Select Case setloginTo
                Case 0
                    _cm02EventLoginLOCAL()
                Case 1
                    _cm01EventLogin()
            End Select
        End If
    End Sub

    Private Sub btnLogout_Click(sender As Object, e As EventArgs) Handles btnLogout.Click
        Dim yesNo As String
        yesNo = MsgBox("Keluar dari Aplikasi ..?", MsgBoxStyle.YesNo, "INFORMATION")
        If yesNo = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub
End Class