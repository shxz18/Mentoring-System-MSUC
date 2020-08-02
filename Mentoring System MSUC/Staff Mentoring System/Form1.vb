Imports System.Data.OleDb
Imports System.Data

Public Class Form1
    Dim connection As New OleDbConnection(My.Settings.StaffConnectionString)
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub UserNameTxt_TextChanged(sender As Object, e As EventArgs) Handles UserNameTxt.TextChanged

    End Sub

    Private Sub RegisterTxt_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles RegisterTxt.LinkClicked
        SignUp.Show()
    End Sub

    Private Sub ExitTxt_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs)
        Close()

    End Sub


    Private Sub GunaAdvenceTileButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton1.Click
        Close()
    End Sub

    Private Sub LoginBtn_Click_1(sender As Object, e As EventArgs) Handles LoginBtn.Click
        If UserNameTxt.Text = Nothing Or PasswordTxt.Text = Nothing Then
            MsgBox("Enter Username and Password", MsgBoxStyle.Exclamation)
        Else
            If connection.State = ConnectionState.Closed Then
                connection.Open()

            End If
            Dim cmd As New OleDbCommand("Select Count(*) from Staff where Username=? and Password=?", connection)
            cmd.Parameters.AddWithValue("@1", OleDbType.VarChar).Value = UserNameTxt.Text
            cmd.Parameters.AddWithValue("@2", OleDbType.VarChar).Value = PasswordTxt.Text
            Dim count = Convert.ToInt32(cmd.ExecuteScalar())


            If (count > 0) Then
                MsgBox("Login Succeed", MsgBoxStyle.Information)

                mainmenu.Show()

            Else
                MsgBox("Account not found, please register account", MsgBoxStyle.Critical)


            End If
        End If



    End Sub
End Class
