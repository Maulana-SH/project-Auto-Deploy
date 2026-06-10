Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading

Module Server_TCP
    Sub Main()
        ' Mulai server TCP
        Dim server As New TcpServerMultipelClient()
        server.Start()
    End Sub
End Module

Public Class TcpServerMultipelClient
    Private Const PORT As Integer = 5000 ' Port yang digunakan
    Private clients As New Dictionary(Of TcpClient, String)() ' Daftar client dan nama mereka

    Public Sub Start()
        ' Ambil IP address dari mesin yang menjalankan aplikasi
        Dim hostName As String = Dns.GetHostName()
        Dim hostEntry As IPHostEntry = Dns.GetHostEntry(hostName)
        Dim ipAddress As IPAddress = hostEntry.AddressList.FirstOrDefault(Function(ip) ip.AddressFamily = AddressFamily.InterNetwork)

        ' Buat listener TCP pada port tertentu
        Dim listener As New TcpListener(IPAddress.Any, PORT)
        listener.Start()
        Console.WriteLine("Server TCP Multipel Client berjalan di ip " & ipAddress.ToString & " port " & PORT & "...")

        ' Terima koneksi dari client secara terus-menerus
        While True
            Dim client As TcpClient = listener.AcceptTcpClient()
            Console.WriteLine("Client terhubung: " & client.Client.RemoteEndPoint.ToString())

            ' Minta nama klien
            Dim stream As NetworkStream = client.GetStream()
            Dim buffer(1024) As Byte
            Dim bytesRead As Integer = stream.Read(buffer, 0, buffer.Length)
            Dim clientName As String = Encoding.ASCII.GetString(buffer, 0, bytesRead)

            ' Tambahkan client dan nama ke daftar
            clients.Add(client, clientName)
            Console.WriteLine("Client " & clientName & " terhubung.")

            ' Kirim daftar klien ke semua klien
            BroadcastClientList()


            ' Handle client dalam thread terpisah
            Dim clientThread As New Thread(AddressOf HandleClient)
            clientThread.Start(client)
        End While
    End Sub

    Private Sub HandleClient(client As TcpClient)
        Dim stream As NetworkStream = client.GetStream()
        Dim buffer(1024) As Byte
        Dim bytesRead As Integer

        While True
            Try
                bytesRead = stream.Read(buffer, 0, buffer.Length)
                If bytesRead = 0 Then
                    Exit While
                End If

                '******************************************************************
                ' Kirim pesan Group semua yang terhubung di App
                '' Konversi data ke string
                'Dim message As String = Encoding.ASCII.GetString(buffer, 0, bytesRead)
                'Console.WriteLine("Diterima dari client: " & message)

                '' Ambil nama pengirim
                'Dim senderName As String = clients(client)

                '' Format pesan dengan nama pengirim
                'Dim formattedMessage As String = senderName & " : " & message

                '' Kirim pesan ke semua client, termasuk pengirim
                'BroadcastMessage(formattedMessage, client)
                '******************************************************************


                ' Konversi data ke string
                Dim message As String = Encoding.ASCII.GetString(buffer, 0, bytesRead)
                Dim senderName As String = clients(client)
                Console.WriteLine("Diterima dari client: " & message)

                ' Periksa apakah pesan ditujukan ke klien tertentu
                If message.StartsWith("[TO:") Then
                    ' Temukan posisi penutup bracket `]`
                    Dim closingBracketIndex As Integer = message.IndexOf("]")
                    If closingBracketIndex > 0 Then
                        ' Ambil bagian "user1 - 172.20.21.8:49585"
                        Dim targetClientInfo As String = message.Substring(4, closingBracketIndex - 4)

                        ' Pisahkan nama user dan IP
                        Dim targetClientName As String = targetClientInfo.Split(" - ")(0)

                        ' Ambil pesan setelah `]`
                        Dim actualMessage As String = message.Substring(closingBracketIndex + 1).Trim()

                        ' ********************************
                        ' Kirim pesan ke kline tertentu
                        '*********************************
                        Dim formattedMessage As String = senderName & " : " & actualMessage
                        ' SendMessageToSpesificClient(targetClientName, actualMessage)
                        SendMessageToSpesificClient(targetClientName, formattedMessage)

                        ' ********************************
                        ' Kirim pesan ke pengirim
                        '*********************************
                        Dim responseMessage As String = senderName & " : " & actualMessage
                        SendMessageToSpesificClient(senderName, responseMessage)


                    End If
                Else
                    ' Kirim pesan ke semua klien (broadcast)
                    Dim formattedMessage As String = senderName & ": " & message
                    BroadcastMessage(formattedMessage, client)
                End If


            Catch ex As Exception
                Console.WriteLine("Error: " & ex.Message)
                Exit While
            End Try
        End While

        ' Tutup koneksi dan hapus client dari daftar
        clients.Remove(client)
        Console.WriteLine("Client terputus: " & client.Client.RemoteEndPoint.ToString())
        client.Close()

        ' Kirim daftar klien yang terupdate ke semua klien
        BroadcastClientList()
    End Sub

    Private Sub BroadcastMessage(message As String, sender As TcpClient)
        ' Kirim pesan ke semua client kecuali pengirim
        'For Each client As TcpClient In clients
        '    If client IsNot sender AndAlso client.Connected Then
        '        Try
        '            Dim stream As NetworkStream = client.GetStream()
        '            Dim data As Byte() = Encoding.ASCII.GetBytes(message)
        '            stream.Write(data, 0, data.Length)
        '        Catch ex As Exception
        '            Console.WriteLine("Gagal mengirim pesan ke client: " & ex.Message)
        '        End Try
        '    End If
        'Next

        '' Kirim pesan ke semua client, termasuk pengirim
        'clients = VARIABEL PALING ATAS =  Private clients As New List(Of TcpClient)() ' Daftar client yang terhubung
        'For Each client As TcpClient In clients
        '    If client.Connected Then
        '        Try
        '            Dim stream As NetworkStream = client.GetStream()
        '            Dim data As Byte() = Encoding.ASCII.GetBytes(message)
        '            stream.Write(data, 0, data.Length)
        '        Catch ex As Exception
        '            Console.WriteLine("Gagal mengirim pesan ke client: " & ex.Message)
        '        End Try
        '    End If
        'Next

        ' Kirim pesan ke semua client, termasuk pengirim
        For Each kvp As KeyValuePair(Of TcpClient, String) In clients
            Dim client As TcpClient = kvp.Key
            Dim clientName As String = kvp.Value

            If client.Connected Then
                Try
                    Dim stream As NetworkStream = client.GetStream()
                    Dim data As Byte() = Encoding.ASCII.GetBytes(message)
                    stream.Write(data, 0, data.Length)
                Catch ex As Exception
                    Console.WriteLine("Gagal mengirim pesan ke client: " & ex.Message)
                End Try
            End If
        Next

    End Sub

    Private Sub BroadcastClientList()
        ' Buat daftar klien yang terhubung
        Dim clientList As New StringBuilder()
        For Each kvp As KeyValuePair(Of TcpClient, String) In clients
            Dim client As TcpClient = kvp.Key
            Dim clientName As String = kvp.Value
            Dim clientIP As String = client.Client.RemoteEndPoint.ToString()

            ' Tambahkan nama dan IP ke daftar
            ' clientList.AppendLine(clientName & " - " & clientIP)
            clientList.AppendLine(clientName)
        Next

        ' Kirim daftar klien ke semua klien
        For Each client As TcpClient In clients.Keys
            If client.Connected Then
                Try
                    Dim stream As NetworkStream = client.GetStream()
                    Dim data As Byte() = Encoding.ASCII.GetBytes("[CLIENT_LIST]" & clientList.ToString())
                    stream.Write(data, 0, data.Length)
                Catch ex As Exception
                    Console.WriteLine("Gagal mengirim daftar klien ke client: " & ex.Message)
                End Try
            End If
        Next
    End Sub

    Private Sub SendMessageToSpesificClient(clientName As String, message As String)
        'untuk kriim pesan ke pada user yang dilih saja

        ' Cari klien berdasarkan nama
        Dim targetClient As TcpClient = Nothing
        For Each kvp As KeyValuePair(Of TcpClient, String) In clients
            If kvp.Value = clientName Then
                targetClient = kvp.Key
                Exit For
            End If
        Next

        ' Jika klien ditemukan, kirim pesan
        If targetClient IsNot Nothing AndAlso targetClient.Connected Then
            Try
                Dim stream As NetworkStream = targetClient.GetStream()
                Dim data As Byte() = Encoding.ASCII.GetBytes(message)
                stream.Write(data, 0, data.Length)
            Catch ex As Exception
                Console.WriteLine("Gagal mengirim pesan ke client " & clientName & ": " & ex.Message)
            End Try
        Else
            Console.WriteLine("Client " & clientName & " tidak ditemukan atau terputus.")
        End If
    End Sub

End Class