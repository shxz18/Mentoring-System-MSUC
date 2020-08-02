Imports System.Net.Mail
Public Class Sending

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        Try
            Dim Smtp_Server As New SmtpClient
            Dim e_mail As New MailMessage
            Smtp_Server.UseDefaultCredentials = False
            Smtp_Server.Credentials = New Net.NetworkCredential("bitrab118@gmail.com", "")
            Smtp_Server.Port = 587
            Smtp_Server.EnableSsl = True
            Smtp_Server.Host = "smtp.gmail.com"
            e_mail = New MailMessage()
            e_mail.From = New MailAddress(MailIdTxt.Text)
            e_mail.To.Add(ToTxt.Text)
            e_mail.Subject = SubjectTxt.Text
            e_mail.IsBodyHtml = False
            e_mail.Body = MessageTxt.Text
            Smtp_Server.Send(e_mail)
            MsgBox("Mail Sended, Thank You")



        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

    End Sub
End Class