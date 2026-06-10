Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Threading

Module Server_UDP
    Sub Main()
        ' Mulai server TCP
        Dim server As New UdpServerMultiClient()
        server.Start()
    End Sub
End Module

Public Class UdpServerMultiClient
    Private Const PORT As Integer = 5000 ' Port yang digunakan
    Private clients As New Dictionary(Of IPEndPoint, String)() ' Daftar client dan nama mereka

    Public Sub Start()
        ' Ambil IP address dari mesin yang menjalankan aplikasi
        Dim hostName As String = Dns.GetHostName()
        Dim hostEntry As IPHostEntry = Dns.GetHostEntry(hostName)
        Dim ipAddress As IPAddress = hostEntry.AddressList.FirstOrDefault(Function(ip) ip.AddressFamily = AddressFamily.InterNetwork)

        ' Buat UDP listener pada port tertentu
        Dim udpClient As New UdpClient(PORT)
        Console.WriteLine("Server UDP Multipel Client berjalan di ip " & ipAddress.ToString & " port " & PORT & "...")


        ' Terima data dari client secara terus-menerus
        While True
            ' Terima data dari client
            Dim remoteEP As New IPEndPoint(IPAddress.Any, 0)
            Dim receivedBytes As Byte() = udpClient.Receive(remoteEP)
            Dim clientMessage As String = Encoding.ASCII.GetString(receivedBytes)

            ' Jika client baru, tambahkan ke daftar
            If Not clients.ContainsKey(remoteEP) Then
                clients.Add(remoteEP, clientMessage)
                Console.WriteLine("Client terhubung: " & remoteEP.ToString() & " dengan nama : " & clientMessage)
            Else
                ' Handle pesan dari client yang sudah terdaftar
                Console.WriteLine("Diterima dari client " & clients(remoteEP) & " : " & clientMessage)

                ' Periksa apakah pesan ditujukan ke klien tertentu
                If clientMessage.StartsWith("[TO:") Then

                    ' Temukan posisi penutup bracket `]`
                    Dim closingBracketIndex As Integer = clientMessage.IndexOf("]")
                    If closingBracketIndex > 0 Then
                        ' Ambil bagian "user1 - 172.20.21.8:49585"
                        Dim targetClientInfo As String = clientMessage.Substring(4, closingBracketIndex - 4)

                        ' Pisahkan nama user
                        Dim targetClientName As String = targetClientInfo.Split(" - ")(0)

                        ' Ambil pesan setelah `]`
                        Dim actualMessage As String = clientMessage.Substring(closingBracketIndex + 1).Trim()

                        ' Kirim pesan ke klien tertentu
                        Dim formattedMessage As String = clients(remoteEP) & " : " & actualMessage
                        SendMessageToSpecificClient(targetClientName, formattedMessage, udpClient)

                        ' Kirim pesan ke pengirim
                        Dim responseMessage As String = clients(remoteEP) & " : " & actualMessage
                        SendMessageToSpecificClient(clients(remoteEP), responseMessage, udpClient)
                    End If
                Else
                    ' Kirim pesan ke semua klien (broadcast)
                    Dim formattedMessage As String = clients(remoteEP) & " : " & clientMessage
                    BroadcastMessage(formattedMessage, udpClient)
                End If
            End If

            ' Kirim daftar klien ke semua klien
            BroadcastClientList(udpClient)
        End While
    End Sub

    Private Sub BroadcastMessage(message As String, udpClient As UdpClient)
        ' Kirim pesan ke semua client
        For Each clientEP As IPEndPoint In clients.Keys
            Try
                Dim sendBytes As Byte() = Encoding.ASCII.GetBytes(message)
                udpClient.Send(sendBytes, sendBytes.Length, clientEP)
            Catch ex As Exception
                Console.WriteLine("Gagal mengirim pesan ke client: " & ex.Message)
            End Try
        Next
    End Sub

    Private Sub BroadcastClientList(udpClient As UdpClient)
        ' Buat daftar klien yang terhubung
        Dim clientList As New StringBuilder()
        For Each kvp As KeyValuePair(Of IPEndPoint, String) In clients
            Dim clientEP As IPEndPoint = kvp.Key
            Dim clientName As String = kvp.Value

            ' Tambahkan nama dan IP ke daftar
            'clientList.AppendLine(clientName & " - " & clientEP.ToString())
            clientList.AppendLine(clientName)
        Next

        ' Kirim daftar klien ke semua klien
        For Each clientEP As IPEndPoint In clients.Keys
            Try
                Dim sendBytes As Byte() = Encoding.ASCII.GetBytes("[CLIENT_LIST]" & clientList.ToString())
                udpClient.Send(sendBytes, sendBytes.Length, clientEP)
            Catch ex As Exception
                Console.WriteLine("Gagal mengirim daftar klien ke client: " & ex.Message)
            End Try
        Next
    End Sub

    Private Sub SendMessageToSpecificClient(clientName As String, message As String, udpClient As UdpClient)
        ' Cari klien berdasarkan nama
        Dim targetClientEP As IPEndPoint = Nothing
        For Each kvp As KeyValuePair(Of IPEndPoint, String) In clients
            If kvp.Value = clientName Then
                targetClientEP = kvp.Key
                Exit For
            End If
        Next

        ' Jika klien ditemukan, kirim pesan
        If targetClientEP IsNot Nothing Then
            Try
                Dim sendBytes As Byte() = Encoding.ASCII.GetBytes(message)
                udpClient.Send(sendBytes, sendBytes.Length, targetClientEP)
            Catch ex As Exception
                Console.WriteLine("Gagal mengirim pesan ke client " & clientName & ": " & ex.Message)
            End Try
        Else
            Console.WriteLine("Client " & clientName & " tidak ditemukan.")
        End If
    End Sub


End Class