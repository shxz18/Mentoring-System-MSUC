

Public Class Subject


    Private Sub GunaGroupBox1_Click(sender As Object, e As EventArgs) Handles GunaGroupBox1.Click

    End Sub

    Private Sub MentorBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub Subject_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet2.Mentor' table. You can move, or remove it, as needed.
        Me.MentorTableAdapter.Fill(Me.Database1DataSet2.Mentor)
        'TODO: This line of code loads data into the 'Database1DataSet1.Mentor' table. You can move, or remove it, as needed.
        Me.MentorTableAdapter.Fill(Me.Database1DataSet2.Mentor)
        'TODO: This line of code loads data into the 'Database1DataSet.Mentor' table. You can move, or remove it, as needed.



    End Sub

    Private Sub GunaGroupBox2_Click(sender As Object, e As EventArgs) Handles GunaGroupBox2.Click
        MentorBindingSource.AddNew()
    End Sub

    Private Sub MentorBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MentorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet2)

    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        MentorBindingSource.RemoveCurrent()
    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        Try
            MentorBindingSource.EndEdit()
            MentorTableAdapter.Update(Database1DataSet2.Mentor)
            MessageBox.Show("Data Saved")


        Catch ex As Exception
            MessageBox.Show("Error occured while saving data")
        End Try
    End Sub

    Private Sub GunaAdvenceTileButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton2.Click
        Close()
    End Sub

    Private Sub MentorBindingNavigatorSaveItem_Click_2(sender As Object, e As EventArgs)
        Me.Validate()
        Me.MentorBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet2)

    End Sub

    Private Sub SearchBtn_Click(sender As Object, e As EventArgs) Handles SearchBtn.Click
        On Error GoTo SearchErr

        If SearchTxt.Text = "" Then
            Exit Sub

        Else
            Dim cantFine As String = SearchTxt.Text

            MentorBindingSource.Filter = "(Convert(NoMatrik, 'System.String') LIKE '" & SearchTxt.Text & "')"


        End If
SearchErr:
    End Sub

End Class