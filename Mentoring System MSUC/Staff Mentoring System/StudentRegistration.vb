
Public Class StudentRegistration


    Private Sub GunaAdvenceTileButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton2.Click
        Close()
    End Sub



    Private Sub StudentRegistration_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'Database1DataSet2.Parents' table. You can move, or remove it, as needed.
        Me.ParentsTableAdapter.Fill(Me.Database1DataSet2.Parents)
        'TODO: This line of code loads data into the 'Database1DataSet2.StudentInfo' table. You can move, or remove it, as needed.
        Me.StudentInfoTableAdapter.Fill(Me.Database1DataSet2.StudentInfo)
        'TODO: This line of code loads data into the 'Database1DataSet1.StudentInfo' table. You can move, or remove it, as needed.

        'TODO: This line of code loads data into the 'Database1DataSet.StudentInfo' table. You can move, or remove it, as needed.



    End Sub







    Private Sub StudentInfoBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub StudentInfoBindingNavigatorSaveItem_Click_1(sender As Object, e As EventArgs)


    End Sub

    Private Sub StudentInfoBindingNavigatorSaveItem_Click_2(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StudentInfoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet2)

    End Sub

    Private Sub StudentInfoBindingNavigatorSaveItem_Click_3(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StudentInfoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet2)

    End Sub

    Private Sub StudentInfoBindingNavigatorSaveItem_Click_4(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StudentInfoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet2)

    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        StudentInfoBindingSource.AddNew()
    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        StudentInfoBindingSource.RemoveCurrent()
    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        Try
            StudentInfoBindingSource.EndEdit()
            StudentInfoTableAdapter.Update(Database1DataSet2.StudentInfo)
            MessageBox.Show("Data Saved")


        Catch ex As Exception
            MessageBox.Show("Error occured while saving data")
        End Try
    End Sub



    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub GunaAdvenceButton5_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton5.Click
        On Error GoTo SearchErr

        If GunaTextBox1.Text = "" Then
            Exit Sub

        Else
            Dim cantFine As String = GunaTextBox1.Text

            StudentInfoBindingSource.Filter = "(Convert(ID, 'System.String') LIKE '" & GunaTextBox1.Text & "')"


        End If
SearchErr:
    End Sub

    Private Sub StudentInfoBindingNavigatorSaveItem_Click_5(sender As Object, e As EventArgs)
        Me.Validate()
        Me.StudentInfoBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.Database1DataSet2)

    End Sub

    Private Sub GunaAdvenceButton9_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton9.Click
        ParentsBindingSource.AddNew()
    End Sub

    Private Sub GunaAdvenceButton8_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton8.Click
        ParentsBindingSource.RemoveCurrent()
    End Sub

    Private Sub GunaAdvenceButton7_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton7.Click
        Try
            ParentsBindingSource.EndEdit()
            ParentsTableAdapter.Update(Database1DataSet2.Parents)
            MessageBox.Show("Data Saved")


        Catch ex As Exception
            MessageBox.Show("Error occured while saving data")
        End Try
    End Sub

    Private Sub GunaGroupBox2_Click(sender As Object, e As EventArgs) Handles GunaGroupBox2.Click

    End Sub

    Private Sub GunaAdvenceButton10_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton10.Click
        On Error GoTo SearchErr

        If GunaTextBox2.Text = "" Then
            Exit Sub

        Else
            Dim cantFine As String = GunaTextBox2.Text

            ParentsBindingSource.Filter = "(Convert(ID, 'System.String') LIKE '" & GunaTextBox2.Text & "')"


        End If
SearchErr:
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        OpenFileDialog1.Filter = "image file (*.jpg, *.bmp, *.png) | *.jpg; *.bmp; *.png| all files (*.*) | *.* "
        If OpenFileDialog1.ShowDialog <> System.Windows.Forms.DialogResult.Cancel Then
            PicPictureBox.Image = Image.FromFile(OpenFileDialog1.FileName)



        End If

    End Sub
End Class