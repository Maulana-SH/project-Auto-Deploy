Imports System.IO
Imports System.Net
Imports System.Net.Sockets
Imports System.Security.Cryptography
Imports System.Text
Imports System.Xml
Imports DevExpress.DataProcessing

Public Class xfrm40GetIpAdress
    Implements IDisposable

    'You should  not hard code the encryption key here
    ' jangan di gani kalo ganti di libNC arifLib ganti juga harus sama
    Dim EncryptionKey As String = "keyrahasia"

    Private pdtUserAkun As DataTable
#Region " Form Evnt "

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        pdtUserAkun = New DataTable

    End Sub
    Private Sub xfrm40GetIpAdress_Load(sender As Object, e As EventArgs) Handles Me.Load
        cminitFielGridPass()
    End Sub

#End Region

#Region " Costume Methods "

    Private Sub cm01GetIppAdress()
        Dim Result As String = ""

        Dim host_name As String = Dns.GetHostName()

        ' Dim ip_address As String = Dns.GetHostByName(host_name).AddressList(0).ToString()
        Dim ip_address() As IPAddress = Dns.GetHostAddresses(host_name)
        For Each address As IPAddress In ip_address
            If address.AddressFamily = AddressFamily.InterNetwork Then
                Console.WriteLine($"{address} is IPv4")
                txtResult.Text += address.ToString & vbNewLine
            End If
        Next

        Result = " Host Name " & host_name & vbNewLine

        'txtResult.Text = ""
        'txtResult.Text = Result

    End Sub
    'Encrypting a string
    Public Shared Function passwordEncrypt(ByVal inText As String, ByVal key As String) As String
        Dim bytesBuff As Byte() = Encoding.Unicode.GetBytes(inText)
        Using aes__1 As Aes = Aes.Create()
            Dim crypto As New Rfc2898DeriveBytes(key, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, &H65, &H64, &H76, &H65, &H64, &H65, &H76})
            aes__1.Key = crypto.GetBytes(32)
            aes__1.IV = crypto.GetBytes(16)
            Using mStream As New MemoryStream()
                Using cStream As New CryptoStream(mStream, aes__1.CreateEncryptor(), CryptoStreamMode.Write)
                    cStream.Write(bytesBuff, 0, bytesBuff.Length)
                    cStream.Close()
                End Using
                inText = Convert.ToBase64String(mStream.ToArray())
            End Using
        End Using
        Return inText
    End Function
    'Decrypting a string
    Public Shared Function passwordDecrypt(ByVal cryptTxt As String, ByVal key As String) As String
        cryptTxt = cryptTxt.Replace(" ", "+")
        Dim bytesBuff As Byte() = Convert.FromBase64String(cryptTxt)
        Using aes__1 As Aes = Aes.Create()
            Dim crypto As New Rfc2898DeriveBytes(key, New Byte() {&H49, &H76, &H61, &H6E, &H20, &H4D, &H65, &H64, &H76, &H65, &H64, &H65, &H76})
            aes__1.Key = crypto.GetBytes(32)
            aes__1.IV = crypto.GetBytes(16)
            Using mStream As New MemoryStream()
                Using cStream As New CryptoStream(mStream, aes__1.CreateDecryptor(), CryptoStreamMode.Write)
                    cStream.Write(bytesBuff, 0, bytesBuff.Length)
                    cStream.Close()
                End Using
                cryptTxt = Encoding.Unicode.GetString(mStream.ToArray())
            End Using
        End Using
        Return cryptTxt
    End Function

    Private Sub cminitFielGridPass()
        col01_k01cUserID_v50.FieldName = "k01cUserID_v50"
        col02_f01cNamaUser_v50.FieldName = "f01cNamaUser_v50"
        col03_f02cKeyPass_v50.FieldName = "f02cKeyPass_v50"
        col04_f10cKeyPassOld_v50.FieldName = "f10cKeyPassOld_v50"
    End Sub

    Private Sub cmGetallUser()

        pdtUserAkun.Clear()

        Using objlitsUser As NCMODELlib.clsNEWCENTRAL_iface = New NCMODELlib.clsNEWCENTRAL_impl With {.prop_nTarget = 1, .prop_02cUserID = ""}
            pdtUserAkun = objlitsUser.Get90UserMaster
        End Using

        If pdtUserAkun.Rows.Count > 0 Then

            Dim Endcryptpass As String = ""
            Dim Descryptpass As String = ""

            '' jika values EncryptionKey


            For Each itm As Object In pdtUserAkun.Rows
                Endcryptpass = ""
                Descryptpass = ""

                Endcryptpass = passwordEncrypt(itm("f10cKeyPassOld_v50"), EncryptionKey)
                Descryptpass = passwordDecrypt(Endcryptpass, EncryptionKey)

                itm("f02cKeyPass_v50") = Endcryptpass
                itm("f10cKeyPassOld_v50") = Descryptpass

            Next
            pdtUserAkun.AcceptChanges()

            GridControl1.DataSource = pdtUserAkun
            GridControl1.RefreshDataSource()
        Else
            MsgBox("Tidak ada USer yang Di temukan")

        End If

    End Sub

#End Region

#Region " Control Evnt "

    Private Sub SimpleButton1_Click(sender As Object, e As EventArgs) Handles SimpleButton1.Click
        cm01GetIppAdress()
    End Sub

    Private Sub SimpleButton2_Click(sender As Object, e As EventArgs) Handles SimpleButton2.Click

        Dim eStr As String = passwordEncrypt(t03.Text, EncryptionKey)

        Dim result As String = ""

        result = "string => " & t03.Text & vbNewLine &
                 "Encrypt => " & eStr

        txtResult.Text = ""
        txtResult.Text = result
    End Sub

    Private Sub SimpleButton3_Click(sender As Object, e As EventArgs) Handles SimpleButton3.Click
        Dim eStr As String = passwordDecrypt(t03.Text, EncryptionKey)

        Dim result As String = ""

        result = "Encrypt => " & t03.Text & vbNewLine &
                 "Descrypt => " & eStr

        txtResult.Text = ""
        txtResult.Text = result
    End Sub

    Private Sub SimpleButton4_Click(sender As Object, e As EventArgs) Handles SimpleButton4.Click
        cmGetallUser()
    End Sub


#End Region

#Region " Grid Evnt "

#End Region
End Class