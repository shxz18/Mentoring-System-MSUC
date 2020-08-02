Public Class StudentInformation




    Private Sub GunaPanel1_Paint(sender As Object, e As PaintEventArgs) Handles GunaPanel1.Paint

    End Sub

    Private Sub StudentBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StudentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StaffDataSetUpdated)

    End Sub

    Private Sub StudentInformation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StaffDataSetUpdated.Student' table. You can move, or remove it, as needed.
        'Me.StudentTableAdapter.Fill(Me.StaffDataSetUpdated.Student)


    End Sub





    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        Try
            StudentBindingSource.EndEdit()
            '  StudentTableAdapter.Update(StaffDataSetBaru.Student)
            MessageBox.Show("Student Added")

        Catch ex As Exception
            MessageBox.Show("Error occured while Register student")
        End Try
    End Sub

    Private Sub GunaAdvenceTileButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton2.Click
        Close()
    End Sub

    Private Sub StudentBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs) Handles StudentBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.StudentBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.StaffDataSetUpdated)

    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        StudentBindingSource.AddNew()
    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        StudentBindingSource.RemoveCurrent()
    End Sub

    Private Sub GunaAdvenceButton4_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton4.Click
        OpenFileDialog1.Filter = "image file(*.jpg, * .bmp, *.png) | *.jpg; *.bmp; *.png | all files (*.*) | *.*"
        If OpenFileDialog1.ShowDialog <> System.Windows.Forms.DialogResult.Cancel Then
            PicPictureBox.Image = Image.FromFile(OpenFileDialog1.FileName)

        End If
    End Sub
End Class