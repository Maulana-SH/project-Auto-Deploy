Imports System.Net.Mail

Public Class frm49SendEmail
    Implements IDisposable


#Region "Credential Email"

    'Const UserEmail As String = "dev.akstudio@gmail.com"
    'Const PassUSer As String = "hrogajyzezlbpkzi" '"gpuzbekamoiuxvtb" hrog ajyz ezlb pkzi


    Const UserEmail As String = "arief@skkjewels.com"
    Const PassUSer As String = "sweatxzydrsiflwy"

#End Region


#Region " form Evnt "

#End Region

#Region " Custome Methods "

    Private Sub cm01SendEmail()


        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage()

            With Smtp_Server
                .UseDefaultCredentials = False
                .Credentials = New Net.NetworkCredential(UserEmail, PassUSer)
                .Port = 465
                .EnableSsl = True
                .Host = "smtp.gmail.com"
            End With

            With e_mail
                .From = New MailAddress(UserEmail)
                .To.Add(_02To.Text)
                .Subject = "Email Sending Tester"
                .IsBodyHtml = False
                .Body = _03Msg.Text
            End With

            Smtp_Server.Send(e_mail)
            MsgBox("Email terkirim .. Silahkan Cek Inbox")

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub cm02Send()

        Try
            Dim smtpServer As New SmtpClient()
            smtpServer.UseDefaultCredentials = False
            smtpServer.Credentials = New Net.NetworkCredential(UserEmail, PassUSer)
            smtpServer.Port = 587
            smtpServer.EnableSsl = True
            smtpServer.Host = "smtp.gmail.com"

            Dim mail As New MailMessage()
            mail = New MailMessage()
            mail.From = New MailAddress(UserEmail)
            mail.IsBodyHtml = True
            mail.To.Add(_02To.Text)
            mail.Subject = "Test Mail"
            mail.Body = _03Msg.Text


            smtpServer.Send(mail)
            Console.WriteLine("Mail Sent")
            MsgBox("Email Terkirim.. cek inbox")

        Catch ex As Exception
            Console.WriteLine(ex.ToString())

            MsgBox("gagal Error " & ex.ToString())
        End Try
    End Sub

#End Region

#Region " Control Evnt "

    Private Sub btnSend_Click(sender As Object, e As EventArgs) Handles btnSend.Click

        If _02To.Text = "" Then
            MsgBox("Silahkan Isi Penerima Dulu...")
        Else
            If _03Msg.Text = "" Then
                MsgBox("Silahkan Isi Pesan Dulu...")
            Else
                cm02Send()
            End If
        End If
    End Sub

#End Region

#Region " Grid Evnt "

#End Region

End Class