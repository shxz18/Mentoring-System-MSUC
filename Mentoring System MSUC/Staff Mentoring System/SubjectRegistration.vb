
Public Class SubjectRegistration
    'Open Database Gateway

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        MentorBindingSource.AddNew()
    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        MentorBindingSource.RemoveCurrent()

    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        Try
            MentorBindingSource.EndEdit()
            MentorTableAdapter.Update(Database1DataSet.Mentor)
            MessageBox.Show("Subject Added")

        Catch ex As Exception
            MessageBox.Show("Error occured while register subject")
        End Try
    End Sub

    Private Sub GunaAdvenceTileButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton1.Click
        Close()
    End Sub

    Private Sub SubjectRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet.Mentor' table. You can move, or remove it, as needed.


        Me.MentorTableAdapter.Fill(Me.Database1DataSet.Mentor)



        'End here
    End Sub




End Class