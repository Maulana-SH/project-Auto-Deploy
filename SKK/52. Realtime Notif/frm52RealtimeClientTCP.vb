Imports System.Media
Imports System.Net
Imports System.Net.Sockets
Imports System.Reflection
Imports System.Security.Cryptography.Pkcs
Imports System.Text
Imports System.Threading
Imports System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel
Imports DevExpress.CodeParser
Imports DevExpress.LookAndFeel
Imports DevExpress.Utils
Imports Microsoft.SqlServer

Public Class frm52RealtimeClientTCP
    Private client_tcp As New TcpClient
    Private stream As NetworkStream
    Private stringIP_server As String '= "172.25.1.46"
    Private clientName As String '= "172.25.1.46"
    Private receiveThread As Thread

    ' Coba dengan UDP
    Private Const SERVER_PORT As Integer = 5000 ' Port server
    Private client_udp As New UdpClient() ' Client UDP
    Private serverEP As IPEndPoint ' Endpoint server
    Private clientName_UDP As String ' Nama client
    Private receiveThread_UDP As Thread ' Thread untuk menerima pesan

    Private Sub frm52RealtimeClientTCP_Load(sender As Object, e As EventArgs) Handles Me.Load
        ' Inisialisasi client TCP 

    End Sub

    '#Region "Singgel CLient TCP"


    '    Private Sub cm01COnnectServer()
    '        Dim StatusConnected As String = ""
    '        Try
    '            ' Hubungkan ke server
    '            client.Connect("172.25.1.46", 5000) ' Ganti dengan IP server jika berbeda
    '            stream = client.GetStream()
    '            MessageBox.Show("Terhubung ke server!")
    '            StatusConnected = "Connected..."
    '        Catch ex As Exception
    '            StatusConnected = "Not..Connected"
    '            MessageBox.Show("Gagal terhubung ke server: " & ex.Message)
    '        End Try

    '        lblStatus.Text = StatusConnected
    '    End Sub

    '    Private Sub cm02SendPesan()
    '        Try
    '            ' Ambil nama user dan pesan
    '            Dim userName As String = _02NamaUser.Text
    '            Dim message As String = _03txtMessage.Text

    '            ' Gabungkan nama user dan pesan dalam format tertentu
    '            Dim fullMessage As String = userName & ": " & message

    '            ' Kirim pesan ke server
    '            Dim data As Byte() = Encoding.ASCII.GetBytes(fullMessage)
    '            stream.Write(data, 0, data.Length)

    '            ' Terima respons dari server
    '            Dim buffer(1024) As Byte
    '            Dim bytesRead As Integer = stream.Read(buffer, 0, buffer.Length)
    '            Dim response As String = Encoding.ASCII.GetString(buffer, 0, bytesRead)

    '            ''logResponse.Text += response & vbNewLine

    '            ' Memutar suara notifikasi
    '            PlayNotificationSound()
    '        Catch ex As Exception
    '            MessageBox.Show("Gagal mengirim pesan: " & ex.Message)
    '        End Try

    '        'Try
    '        '    ' Kirim pesan ke server
    '        '    Dim message As String = txtMessage.Text
    '        '    Dim data As Byte() = Encoding.ASCII.GetBytes(message)
    '        '    stream.Write(data, 0, data.Length)

    '        '    ' Terima respons dari server
    '        '    Dim buffer(1024) As Byte
    '        '    Dim bytesRead As Integer = stream.Read(buffer, 0, buffer.Length)
    '        '    Dim response As String = Encoding.ASCII.GetString(buffer, 0, bytesRead)
    '        '    ' lblResponse.Text = "Respons dari server: " & response
    '        '    logResponse.Text += response & vbNewLine

    '        '    PlayNotificationSound()
    '        'Catch ex As Exception
    '        '    MessageBox.Show("Gagal mengirim pesan: " & ex.Message)
    '        'End Try
    '    End Sub
    '#End Region

#Region " Multiperl CLient TCP (Bisa chat by USer yang pilih dan Chat group)"

    Private Sub cm01Conecnted_MultipelTCP()

        stringIP_server = _01Ipserver.EditValue
        'Try
        '    ' Hubungkan ke server
        '    client.Connect(stringIP_server, 5000) ' Ganti dengan IP server jika berbeda
        '    stream = client.GetStream()
        '    MessageBox.Show("Terhubung ke server!")

        '    ' Mulai thread untuk menerima pesan dari server
        '    receiveThread = New Thread(AddressOf ReceiveMessages)
        '    receiveThread.IsBackground = True ' Jadikan thread sebagai background thread
        '    receiveThread.Start()
        'Catch ex As Exception
        '    MessageBox.Show("Gagal terhubung ke server: " & ex.Message)
        'End Try

        Try
            ' Hubungkan ke server
            client_tcp.Connect(stringIP_server, 5000) ' Ganti dengan IP server jika berbeda
            stream = client_tcp.GetStream()
            MessageBox.Show("Terhubung ke server!")

            ' Kirim nama klien ke server
            clientName = _02NamaUser.EditValue ' Ganti dengan nama klien yang diinginkan
            Dim nameData As Byte() = Encoding.ASCII.GetBytes(clientName)
            stream.Write(nameData, 0, nameData.Length)

            ' Mulai thread untuk menerima pesan dari server
            receiveThread = New Thread(AddressOf ReceiveMessages)
            receiveThread.IsBackground = True ' Jadikan thread sebagai background thread
            receiveThread.Start()
        Catch ex As Exception
            MessageBox.Show("Gagal terhubung ke server: " & ex.Message)
        End Try
    End Sub

    Private Sub cm02SendMsgTCP()
        Try
            ' Pastikan stream tidak Nothing
            If stream Is Nothing OrElse Not client_tcp.Connected Then
                MessageBox.Show("Tidak terhubung ke server!")
                Return
            End If

            ' Pesan yng di tulis
            Dim message As String = _03txtMessage.Text

            ' Periksa apakah pesan ditujukan ke klien tertentu
            If _04CbListUser.SelectedItem IsNot Nothing AndAlso _04CbListUser.SelectedItem.ToString() <> "Semua" Then
                ' Kirim pesan ke klien tertentu
                Dim recipient As String = _04CbListUser.SelectedItem.ToString()
                message = "[TO:" & recipient & "] " & message
            End If


            ' Kirim pesan ke server
            Dim data As Byte() = Encoding.ASCII.GetBytes(message)
            stream.Write(data, 0, data.Length)


        Catch ex As Exception
            MessageBox.Show("Gagal mengirim pesan: " & ex.Message)
        End Try
    End Sub

    Private Sub ReceiveMessages()
        Dim buffer(1024) As Byte
        Dim bytesRead As Integer

        While True
            Try
                ' Terima pesan dari server
                bytesRead = stream.Read(buffer, 0, buffer.Length)
                If bytesRead = 0 Then
                    Exit While
                End If

                ' Konversi data ke string
                Dim message As String = Encoding.ASCII.GetString(buffer, 0, bytesRead)
                Console.WriteLine("Pesan diterima: " & message) ' Debugging

                '' Tampilkan pesan di ListBox menggunakan Invoke
                'Me.Invoke(Sub()
                '              lstMessages.Items.Add(message)
                '              lstMessages.TopIndex = lstMessages.Items.Count - 1 ' Scroll ke item terbaru


                '              ' Memutar suara notifikasi
                '              ' Parsing nama user dan pesan
                '              Dim separatorIndex As Integer = message.IndexOf(":")
                '              If separatorIndex > 0 Then
                '                  Dim userName As String = message.Substring(0, separatorIndex).Trim()

                '                  If Not userName = clientName Then
                '                      ' Memutar suara notifikasi hanya jika pesan bukan dari diri sendiri
                '                      PlayNotificationSound()
                '                  End If

                '              End If
                '          End Sub)


                ' Periksa apakah pesan adalah daftar klien
                If message.StartsWith("[CLIENT_LIST]") Then
                    ' Hapus prefix "[CLIENT_LIST]"
                    Dim clientList As String = message.Substring("[CLIENT_LIST]".Length)

                    ' Tampilkan daftar klien di ListBox atau kontrol lainnya
                    Me.Invoke(Sub()
                                  lstUserConnected.Items.Clear()
                                  lstUserConnected.Items.AddRange(clientList.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries))

                                  _04CbListUser.Items.Clear()
                                  _04CbListUser.Items.Add("Semua") ' Opsi untuk mengirim ke semua klien
                                  _04CbListUser.Items.AddRange(clientList.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries))
                                  _04CbListUser.SelectedIndex = 0 ' Pilih "Semua" secara default


                              End Sub)
                Else
                    ' Tampilkan pesan biasa di ListBox
                    Me.Invoke(Sub()
                                  lstMessages.Items.Add(message)
                                  lstMessages.TopIndex = lstMessages.Items.Count - 1 ' Scroll ke item terbaru

                                  ' Memutar suara notifikasi
                                  ' Parsing nama user dan pesan
                                  Dim separatorIndex As Integer = message.IndexOf(":")
                                  If separatorIndex > 0 Then
                                      Dim userName As String = message.Substring(0, separatorIndex).Trim()
                                      Dim userMessage As String = message.Substring(separatorIndex + 1).Trim()

                                      If Not userName = clientName Then
                                          ' Memutar suara notifikasi hanya jika pesan bukan dari diri sendiri
                                          ShowNorification(userName, userMessage)
                                          PlayNotificationSound()
                                      End If

                                  End If
                              End Sub)
                End If

            Catch ex As Exception
                ' Jika terjadi error, keluar dari loop
                Console.WriteLine("Error ReceiveMessages: " & ex.Message) ' Debugging
                Exit While
            End Try
        End While
    End Sub

    Private Sub PlayNotificationSound()
        Try
            ' Ambil resource suara dari assembly
            Dim assembly As Assembly = Assembly.GetExecutingAssembly()
            Dim soundStream As IO.Stream = assembly.GetManifestResourceStream("SKK.notification.wav") ' Ganti "SKK" dengan namespace proyek Anda
            If soundStream IsNot Nothing Then
                Dim player As New SoundPlayer(soundStream)
                player.Play()
            Else
                MessageBox.Show("File suara tidak ditemukan!")
            End If
        Catch ex As Exception
            MessageBox.Show("Gagal memutar suara: " & ex.Message)
        End Try
    End Sub

    Private Sub ShowNorification(ByVal prmNamaUser As String, ByVal prmPesan As String)
        Dim myicon As New SvgImageCollection

        myicon.Add("Mail", "image://svgimages/outlook inspired/glyph_mail.svg")

        'AlertControl1.FormLocation = AlertFormLocation.TopRight
        myAlert.LookAndFeel.UseDefaultLookAndFeel = False
        'myAlert.LookAndFeel.SetSkinStyle(SkinStyle.SevenClassic) 'them succes
        myAlert.LookAndFeel.SetSkinStyle(SkinStyle.Bezier) 'them succes
        myAlert.AllowHtmlText = True
        myAlert.ShowPinButton = False
        myAlert.Show(Me, "<color=white><size=11>" & prmNamaUser & "</color>", "Pesan baru", prmPesan, myicon.GetImage(0, New System.Drawing.Size(50, 50)))
        ' myAlert.Show(Me, "<color=Green><size=12>SUCCESS</color>", "<size=10>Mutasi ZN123432 Berhasil Ke proses Berikuta", "", iconSucces)


    End Sub

#End Region


#Region " UDP Server"

    Private Sub cm01Connected_UDPServer()
        stringIP_server = _01Ipserver.EditValue
        Try
            ' Set alamat server
            serverEP = New IPEndPoint(IPAddress.Parse(stringIP_server), SERVER_PORT)

            ' Simpan nama client
            clientName = _02NamaUser.EditValue

            ' Kirim nama client ke server
            Dim nameData As Byte() = Encoding.ASCII.GetBytes(clientName)
            client_udp.Send(nameData, nameData.Length, serverEP)

            ' Mulai thread untuk menerima pesan dari server
            receiveThread_UDP = New Thread(AddressOf ReceiveMessages_udp)
            receiveThread_UDP.IsBackground = True ' Jadikan thread sebagai background thread
            receiveThread_UDP.Start()

            MessageBox.Show("Terhubung ke server!")
        Catch ex As Exception
            MessageBox.Show("Gagal terhubung ke server: " & ex.Message)
        End Try

    End Sub

    Private Sub ReceiveMessages_udp()
        While True
            Try
                ' Terima pesan dari server
                Dim receiveBytes As Byte() = client_udp.Receive(serverEP)
                Dim receivedMessage As String = Encoding.ASCII.GetString(receiveBytes)

                ' Periksa apakah pesan adalah daftar klien
                If receivedMessage.StartsWith("[CLIENT_LIST]") Then
                    ' Hapus prefix "[CLIENT_LIST]"
                    Dim clientList As String = receivedMessage.Substring("[CLIENT_LIST]".Length)

                    ' Tampilkan daftar klien di ListBox atau kontrol lainnya
                    Me.Invoke(Sub()
                                  lstUserConnected.Items.Clear()
                                  lstUserConnected.Items.AddRange(clientList.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries))

                                  _04CbListUser.Items.Clear()
                                  _04CbListUser.Items.Add("Semua") ' Opsi untuk mengirim ke semua klien
                                  _04CbListUser.Items.AddRange(clientList.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries))
                                  _04CbListUser.SelectedIndex = 0 ' Pilih "Semua" secara default


                              End Sub)
                Else
                    ' Tampilkan pesan biasa di ListBox
                    Me.Invoke(Sub()

                                  Dim arryMsg As String() = receivedMessage.Split("|"c)



                                  lstMessages.Items.Add(arryMsg(0) & " : " & arryMsg(1) & " : " & arryMsg(2))
                                  lstMessages.TopIndex = lstMessages.Items.Count - 1 ' Scroll ke item terbaru

                                  Console.WriteLine("Server_response = " & receivedMessage)
                                  ' Memutar suara notifikasi
                                  ' Parsing nama user dan pesan
                                  Dim separatorIndex As Integer = receivedMessage.IndexOf(":")
                                  If separatorIndex > 0 Then
                                      Dim userName As String = receivedMessage.Substring(0, separatorIndex).Trim()
                                      Dim userMessage As String = receivedMessage.Substring(separatorIndex + 1).Trim()

                                      If Not userName = clientName Then
                                          ' Memutar suara notifikasi hanya jika pesan bukan dari diri sendiri
                                          ShowNorification(userName, userMessage)
                                          PlayNotificationSound()
                                      End If

                                  End If

                              End Sub)
                End If

                ' Tampilkan pesan ke UI (gunakan Invoke jika diperlukan)
                Console.WriteLine("Pesan dari server: " & receivedMessage)
            Catch ex As Exception
                Console.WriteLine("Error menerima pesan: " & ex.Message)
                Exit While
            End Try
        End While
    End Sub

    Public Sub SendMessage_UDP(message As String)
        Try


            ' Periksa apakah pesan ditujukan ke klien tertentu
            If _04CbListUser.SelectedItem IsNot Nothing AndAlso _04CbListUser.SelectedItem.ToString() <> "Semua" Then
                ' Kirim pesan ke klien tertentu
                Dim recipient As String = _04CbListUser.SelectedItem.ToString()
                message = "[TO:" & recipient & "] " & message
            End If

            ' Kirim pesan ke server
            Dim sendBytes As Byte() = Encoding.ASCII.GetBytes(message)
            client_udp.Send(sendBytes, sendBytes.Length, serverEP)
        Catch ex As Exception
            MessageBox.Show("Gagal mengirim pesan: " & ex.Message)
        End Try

    End Sub

    Public Sub Disconnect()
        ' Tutup koneksi
        client_udp.Close()
        If receiveThread IsNot Nothing AndAlso receiveThread.IsAlive Then
            receiveThread.Abort()
        End If
        MessageBox.Show("Terputus dari server.")
    End Sub

#End Region
    Private Sub frm52RealtimeClientTCP_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing
        ' Tutup koneksi saat form ditutup
        If client_tcp IsNot Nothing Then
            client_tcp.Close()
        End If

        If client_udp IsNot Nothing Then
            Disconnect()

        End If
    End Sub

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        cm02SendMsgTCP()

        'SendMessage_UDP(_03txtMessage.EditValue)

        _03txtMessage.EditValue = ""
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click
        cm01Conecnted_MultipelTCP()

        ' UDP SERVER
        'cm01Connected_UDPServer()


    End Sub


End Class