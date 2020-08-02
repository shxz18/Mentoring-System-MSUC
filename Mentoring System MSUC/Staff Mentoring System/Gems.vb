Imports System.Data.OleDb
Public Class Gems
    Private con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\Staff.mdb")
    Dim dr As OleDbDataReader




    Private Sub GunaAdvenceTileButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton2.Click
        Close()
    End Sub

    Private Sub GunaGroupBox2_Click(sender As Object, e As EventArgs)

    End Sub




    Private Sub Gems_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StaffDataSetGems.Gems' table. You can move, or remove it, as needed.
        Me.GemsTableAdapter.Fill(Me.StaffDataSetGems.Gems)

        con.Open()
        ComboBox1.Items.Clear()

        Dim cmd As New OleDbCommand
        cmd.CommandText = "Select * from Gems"
        cmd.Connection = con
        dr = cmd.ExecuteReader
        While dr.Read

            ComboBox1.Items.Add(dr.GetString(2))

        End While
        dr.Close()

    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        GemsBindingSource.AddNew()
    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        Try
            GemsBindingSource.EndEdit()
            GemsTableAdapter.Update(StaffDataSetGems.Gems)
            MessageBox.Show("Data Saved")

        Catch ex As Exception
            MessageBox.Show("Error occured while saving data")
        End Try
    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        GemsBindingSource.RemoveCurrent()
    End Sub

    Private Sub GunaAdvenceButton10_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton10.Click
        On Error GoTo SearchErr

        If GunaTextBox2.Text = "" Then
            Exit Sub

        Else
            Dim cantFine As String = GunaTextBox2.Text

            GemsBindingSource.Filter = "(Convert(ID, 'System.String') LIKE '" & GunaTextBox2.Text & "')"


        End If
SearchErr:
    End Sub
End Class