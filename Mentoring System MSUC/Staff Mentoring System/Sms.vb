Imports System.Net
Imports System.Web
Imports System.Collections.Specialized
Imports System.IO
Imports System.Text

Public Class Sms

    Private Sub GunaButton1_Click(sender As Object, e As EventArgs) Handles GunaButton1.Click
        Dim apikey = txtApi.Text
        Dim message = SmsTxt.Text
        Dim numbers = PhoneTxt.Text
        Dim strGet As String
        Dim senderName = SenderTxt.Text
        Dim url As String = "https://api.txtlocal.com/send/?"
        '  Dim strPost As String
        'uK/LSxR4bFg-4fNIWKmo1ivrvk09Mwr1nQlmAcqHBp


        strGet = url + "apikey=" + apikey _
        + "&numbers=" + numbers _
        + "&message=" + WebUtility.UrlEncode(message) _
        + "&sender=" + senderName

        Dim webClient As New System.Net.WebClient
        Dim result As String = webClient.DownloadString(strGet)
        MessageBox.Show(result, "Message sent Succesfully", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub


End Class