Imports System.Data.SqlClient
Imports Microsoft.SqlServer
Imports System.Net
Imports System.Text
Imports System.Threading
Imports System.Net.Sockets
Imports DevExpress.LookAndFeel
Imports DevExpress.Utils
Imports System.Media
Imports System.Reflection
Imports System.ComponentModel
Imports DevExpress.XtraGrid.Views.Tile
Imports DevExpress.Utils.Html
Imports DevExpress.XtraGrid.Views.Items

Public Class frm52RealtimeNotif
    Implements IDisposable
    Private stringIP_server As String '= "172.25.1.46"
    Private clientName As String '= "172.25.1.46"

    ' Coba dengan UDP
    Private Const SERVER_PORT As Integer = 5000 ' Port server
    Private client_udp As New UdpClient() ' Client UDP
    Private serverEP As IPEndPoint ' Endpoint server
    Private clientName_UDP As String ' Nama client
    Private receiveThread_UDP As Thread ' Thread untuk menerima pesan

    Private pdtChat As DataTable
    Private MdlChat As New MdlChat


#Region " form Evnt "

    Private Sub frm52RealtimeNotif_Load(sender As Object, e As EventArgs) Handles Me.Load

        cm00InitControl()

    End Sub

    Private Sub frm52RealtimeNotif_Closing(sender As Object, e As CancelEventArgs) Handles Me.Closing

        If client_udp IsNot Nothing Then
            Disconnect()

        End If
    End Sub

#End Region

#Region "custome"

    Private Sub cm00InitControl()

        pdtChat = New DataTable
        MdlChat = New MdlChat With {.prop_dtChat = pdtChat}
        MdlChat.dtInitChat()
        MdlChat.prop_dtChat.Clear()

        TileView1.OptionsHtmlTemplate.ItemAutoHeight = True
        TileView1.OptionsList.DrawItemSeparators = DrawItemSeparatorsMode.None 'Hapus berder bawah jika layout list

        tcol01_IdUser.FieldName = "IdUser"
        tcol02_Pesan.FieldName = "Pesan"
        tcol03_DateTime.FieldName = "DateTime"


        gcChat.DataSource = Nothing
        gcChat.DataSource = MdlChat.prop_dtChat

    End Sub

    Private Sub cm01Connected_UDPServer()
        stringIP_server = _01IpServer.EditValue
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
                                  _04CbListUser.Items.Clear()
                                  _04CbListUser.Items.AddRange(clientList.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries))

                                  _04CbListUser.Items.Clear()
                                  _04CbListUser.Items.Add("Semua") ' Opsi untuk mengirim ke semua klien
                                  _04CbListUser.Items.AddRange(clientList.Split(New String() {Environment.NewLine}, StringSplitOptions.RemoveEmptyEntries))
                                  _04CbListUser.SelectedIndex = 0 ' Pilih "Semua" secara default


                              End Sub)
                Else
                    ' Tampilkan pesan biasa di ListBox
                    Me.Invoke(Sub()

                                  Dim arryMsg As String() = receivedMessage.Split("|"c)

                                  logChat.Items.Add(arryMsg(0) & " : " & arryMsg(1) & " : " & arryMsg(2))
                                  logChat.TopIndex = logChat.Items.Count - 1 ' Scroll ke item terbaru


                                  '**************************************************
                                  'chat
                                  MdlChat.dtAddNew(arryMsg(0), arryMsg(1), arryMsg(2))
                                  MdlChat.prop_dtChat.AcceptChanges()

                                  TileView1.RefreshData()
                                  gcChat.RefreshDataSource()
                                  '**************************************************

                                  Console.WriteLine("Server_response = " & receivedMessage)
                                  ' Memutar suara notifikasi
                                  ' Parsing nama user dan pesan
                                  Dim separatorIndex As Integer = receivedMessage.IndexOf(":")


                                  If Not arryMsg(0) = clientName Then
                                      ' Memutar suara notifikasi hanya jika pesan bukan dari diri sendiri
                                      ShowNorification(arryMsg(0), arryMsg(1))
                                      PlayNotificationSound()
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

    Public Sub cm03SendMessage_UDP(message As String)
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
        '' Tutup koneksi
        'client_udp.Close()
        'If receiveThread_UDP IsNot Nothing AndAlso receiveThread_UDP.IsAlive Then
        '    receiveThread_UDP.Abort()
        'End If
        'MessageBox.Show("Terputus dari server.")

        Dim disconnectMessage As Byte() = Encoding.ASCII.GetBytes("[DISCONNECT]")
        client_udp.Send(disconnectMessage, disconnectMessage.Length, serverEP)
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

#Region " Control Evnt "


    Private Sub btnConnect_Click(sender As Object, e As EventArgs) Handles btnConnect.Click
        cm01Connected_UDPServer()
    End Sub

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click

        cm03SendMessage_UDP(_03Pesan.EditValue)
        _03Pesan.EditValue = ""
    End Sub


    Private Sub TileView1_ItemCustomize(sender As Object, e As TileViewItemCustomizeEventArgs) Handles TileView1.ItemCustomize
        'id     -0
        ' Time  =1
        ' PEsan =2
        'Dim view As TileView = TryCast(sender, TileView)
        'Dim idUSer As String = CStr(view.GetRowCellValue(e.RowHandle, tcol01_IdUser))

        'Console.WriteLine("User = " & idUSer)
        'If view.GetRowCellValue(e.RowHandle, "IdUser") = "ADMIN" Then
        '    MsgBox("Sama")

        '    e.Item.Elements(0).Text = "Anda"
        '    e.Item.Elements(0).Appearance.Normal.BackColor = Color.LightBlue

        'End If


        'Dim panelMSG = e.HtmlElement?.FindElementById("message")
        'Dim container = e.HtmlElement.FindElementById("kotak_luar")
        'Dim container = e.HtmlElement.FindElementsByClass("container") 
        ' tcol01_IdUser

        Dim user As String = TileView1.GetRowCellValue(e.RowHandle, "IdUser")
        Dim isCurentUser As Boolean = (user = _02NamaUser.Text)

        If user = "ADM" Then
            MsgBox("sama")
            ' Container.Style.SetProperty("background-color", "#DDEB9D")
        End If

        'If container IsNot Nothing Then
        'End If

        'Dim pesanBOX = e.HtmlElement.FindElementById("msgchat")

        'If (_02NamaUser.Text = user) Then
        '    MsgBox("sama")
        'End If

    End Sub

#End Region

#Region " Grid Evnt "

#End Region


End Class