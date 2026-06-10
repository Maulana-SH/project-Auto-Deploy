
'Link Tutor http://www.g2gsoft.com/webboard/forum.php?mod=viewthread&tid=196
Public Class frm34VpnConnections

    '// การนับเวลา
    Private TimeCounter As Integer

    '// กำหนดให้แสดงหรือซ่อน DOS Screen
    Dim blnStart As Boolean = True

    '// กำหนด Path ของ Batch File
    Dim strVpn As String = MyPath(Application.StartupPath)
    '// ค่าคงที่ของชื่อโฟลเดอร์
    Const strFolder As String = "MyVPN"

#Region " Costume Methods"

    Private Sub cm01ConnectVpn()
        '// หากไม่พบไดเรคตอรี่ ให้สร้าง Directory (Folder นั่นแหละ) ขึ้นมาใหม่
        If Not IO.Directory.Exists(strVpn & strFolder) Then
            IO.Directory.CreateDirectory(strVpn & strFolder)
        End If
        '// RASDIAL
        'https://docs.microsoft.com/en-us/previous-versions/orphan-topics/ws.10/dd450369(v=ws.10)
        '// Create PhoneBook (pbk extension)
        IO.File.WriteAllText(
                (
                strVpn & strFolder & "\connection.pbk"),
                "[VPN]" & vbNewLine &
                "MEDIA=rastapi" & vbNewLine &
                "Port=VPN2-0" & vbNewLine &
                "Device=WAN Miniport (IKEv2)" & vbNewLine &
                "DEVICE=vpn" & vbNewLine &
                "PhoneNumber=" & txtHost.Text
                )

        '// Create BAT File เพื่อให้รันคำสั่ง Rasdial และใช้ข้อมูลใน Phonebook
        IO.File.WriteAllText(
                (
                strVpn & strFolder & "\connection.bat"),
                "rasdial ""VPN"" " &
                txtUserName.Text & " " &
                txtPassword.Text & " /phonebook:" & """" &
                strVpn & strFolder & "\connection.pbk" & """"
                )

        Try
            Dim connect As System.Diagnostics.Process
            connect = New System.Diagnostics.Process()
            connect.StartInfo.FileName = strVpn & strFolder & "\connection.bat"
            '// หาก Start Program กำหนดให้ blnStart = True
            If blnStart Then
                connect.StartInfo.WindowStyle = ProcessWindowStyle.Normal
            Else
                '// หากทำการ Re-Connect ให้ซ่อนหน้าจอ DOS
                connect.StartInfo.WindowStyle = ProcessWindowStyle.Hidden
            End If
            '//
            connect.Start()
            connect.WaitForExit()
            btnConnect.Enabled = False
            btnDisconnect.Enabled = True
            'MessageBox.Show("Connect VPN already.")
            lblCounterTimer.Text = "00:00:00"

            '// TEST
            'Timer1.Interval = 50    '<-- ไว้ทดสอบเพราะจะนับเร็วมาก
            'TimeCounter = 60 '<-- 60 วิMenitไว้ทดสอบ
            '// 1000 ms = 1 Sec. (ตอนทดสอบตั้งค่าไว้สัก 50 จะทำให้เร็วขึ้น)

            '' TImer Connection
            'Timer1.Interval = 1000
            ''// นำค่า 2 หลักแรกใน ComboBox มาคูณ 60
            'TimeCounter = Val(Microsoft.VisualBasic.Left(cmbTimer.Text, 2)) * 60
            'cmbTimer.Enabled = False

            Timer1.Start()
            connect.Dispose()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub cm02Disconent()
        IO.File.WriteAllText((strVpn & strFolder & "\disconnect.bat"), "rasdial/d")
        Dim connect As System.Diagnostics.Process
        connect = New System.Diagnostics.Process()
        connect.StartInfo.FileName = strVpn & strFolder & "\disconnect.bat"
        connect.StartInfo.WindowStyle = ProcessWindowStyle.Normal
        '//
        connect.Start()
        connect.WaitForExit()
        btnConnect.Enabled = True
        btnDisconnect.Enabled = False
        '//
        Timer1.Stop()
        Timer1.Enabled = False
        lblCounterTimer.Text = "00:00"
        cmbTimer.Enabled = True
        blnStart = True
    End Sub

    Private Function CountDownTime() As String
        Dim HH As String    '<< ชั่วโมง
        Dim MM As String    '<< Menit
        Dim SS As String    '<< วิMenit
        '// 1 ชั่วโมง = 3600 วิMenit
        HH = TimeCounter \ 3600

        '// การ Mod ด้วย 3600 ก็คือ 60 Menitมีค่าเท่ากับ 3600 วิMenit (การนับรวมชั่วโมง)
        '// การหารตัดเศษ \ ด้วย 60 คือต้องการแสดงผลในรูปแบบMenit
        MM = (TimeCounter Mod 3600) \ 60

        '// การ Mod ด้วย 60 (ค่าวิMenit) จะทำให้ค่าสูงสุดอยู่ที่ 59 วิMenit
        SS = (TimeCounter Mod 60)
        '// แสดงผล
        HH = Microsoft.VisualBasic.Right("00" & HH, 2)
        MM = Microsoft.VisualBasic.Right("00" & MM, 2)
        SS = Microsoft.VisualBasic.Right("00" & SS, 2)
        'Return HH & ":" & MM & ":" & SS
        '// เอาเฉพาะMenit-วิMenit
        Return HH & ":" & MM & ":" & SS
    End Function


    ' / --------------------------------------------------------------------------------
    ' / Get my project path
    ' / AppPath = C:\My Project\bin\debug
    ' / Replace "\bin\debug" with ""
    ' / Return : C:\My Project\
    Function MyPath(ByVal AppPath As String) As String
        '/ MessageBox.Show(AppPath);
        AppPath = AppPath.ToLower()
        '/ Return Value
        MyPath = AppPath.Replace("\bin\debug", "").Replace("\bin\release", "").Replace("\bin\x86\debug", "").Replace("\bin\x86\release", "")
        '// If not found folder then put the \ (BackSlash) at the end.
        If Microsoft.VisualBasic.Right(MyPath, 1) <> "" Then MyPath = MyPath & ""
    End Function


#End Region


    Private Sub frm34VpnConnections_Load(sender As Object, e As EventArgs) Handles Me.Load

        Dim host As String = "103.247.218.155"
        Dim userID As String = "Userapp01"
        Dim userPass As String = "skk@123"

        txtHost.Text = host
        txtUserName.Text = userID
        txtPassword.Text = userPass
        '//
        lblCounterTimer.Text = ""
        With cmbTimer
            .Items.Add("01 Menit")
            .Items.Add("05 Menit")
            .Items.Add("10 Menit")
            .Items.Add("20 Menit")
            .Items.Add("30 Menit")
            .Items.Add("40 Menit")
            .Items.Add("50 Menit")
            .Items.Add("60 Menit")
        End With
        cmbTimer.SelectedIndex = 0
        lblCounterTimer.Text = "00:00"
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        'If TimeCounter > 0 Then
        '    TimeCounter -= 1
        '    lblCounterTimer.Text = CountDownTime()
        'Else
        '    Timer1.Enabled = False
        '    '// TEST
        '    'TimeCounter = 60 '<-- 60 วิMenitไว้ทดสอบ
        '    TimeCounter = Val(Microsoft.VisualBasic.Left(cmbTimer.Text, 2)) * 60
        '    Timer1.Start()
        '    '//MsgBox("Time Out.", vbOKOnly + vbInformation, "Report Status")
        '    lblCounterTimer.Text = "00:00"
        '    '// เวลา Re-Connect ทุกๆครั้งจะได้ไม่ต้องแสดงผลหน้าจอ DOS
        '    blnStart = False
        '    '// กลับไปสั่งให้ Re-Connect อีกรอบ
        '    cm02Disconent()
        'End If

        TimeCounter += 1
        lblCounterTimer.Text = CountDownTime()
    End Sub


    Private Sub btnDisconnect_Click(sender As Object, e As EventArgs) Handles btnDisconnect.Click
        cm02Disconent()
    End Sub

    Private Sub frm34VpnConnections_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        '// จะปิดหรือค้าง Connection เอาไว้ก็เลือกเอาครับ
        cm02Disconent()
        Me.Dispose()
        Application.Exit()
    End Sub

    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click

        cm01ConnectVpn()
    End Sub
End Class