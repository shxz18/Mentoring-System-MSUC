
Imports System.Data.OleDb
Imports System.Data
Public Class SignUp
    Dim connection As New OleDbConnection(My.Settings.StaffConnectionString)
    Private Sub SignUpBtn_Click(sender As Object, e As EventArgs) Handles SignUpBtn.Click
        If UsernameSignTxt.Text = Nothing Or PasswordSignTxt.Text = Nothing Or ConfirmPasswordTxt.Text = Nothing Then

            MsgBox("Please Fill The Form!", MsgBoxStyle.Critical)
        Else
            If connection.State = ConnectionState.Closed Then
                connection.Open()
            End If
            Dim cmd As New OleDbCommand("insert into Staff(Username,Password) values(?,?)", connection)
            cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = UsernameSignTxt.Text
            cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = PasswordSignTxt.Text

            cmd.ExecuteNonQuery()
            connection.Close()
            MsgBox("Account created succesfully!", MsgBoxStyle.Information)
        End If
    End Sub

    Private Sub BackLink_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Form1.Show()
    End Sub



    Private Sub GunaAdvenceTileButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton2.Click
        Close()
    End Sub
End Class