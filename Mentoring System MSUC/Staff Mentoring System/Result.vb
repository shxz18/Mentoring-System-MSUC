Imports System.Data.OleDb
Public Class Result
    Private con As New OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Application.StartupPath & "\Staff.mdb")
    Dim dr As OleDbDataReader

    Private Sub GunaAdvenceTileButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton2.Click
        Me.Close()
    End Sub

    Private Sub Result_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'StaffDataSet2.Result' table. You can move, or remove it, as needed.
        Me.ResultTableAdapter.Fill(Me.StaffDataSet2.Result)
        'TODO: This line of code loads data into the 'StaffDataSetResult.Result' table. You can move, or remove it, as needed.

        con.Open()
        GunaComboBox1.Items.Clear()

        Dim cmd As New OleDbCommand
        cmd.CommandText = "Select * from Gems"
        cmd.Connection = con
        dr = cmd.ExecuteReader
        While dr.Read

            GunaComboBox1.Items.Add(dr.GetString(2))

        End While
        dr.Close()

    End Sub

    Private Sub BindingNavigatorAddNewItem_Click(sender As Object, e As EventArgs)

    End Sub

    '  Private Bitmap As New Bitmap
    Private Sub GunaAdvenceButton4_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton4.Click
        Dim height As Integer = GunaDataGridView1.Height
        GunaDataGridView1.Height = GunaDataGridView1.RowCount * GunaDataGridView1.RowTemplate.Height
        '   Bitmap = New Bitmap(Me.GunaDataGridView1.Width, Me.GunaDataGridView1.Height)
        '  GunaDataGridView1.DrawToBitmap(Bitmap, New Rectangle(0, 0, Me.GunaDataGridView1.Width, Me.GunaDataGridView1.Height))
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
        GunaDataGridView1.Height = height


    End Sub

    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        '    e.Graphics.DrawImage(Bitmap, 0, 0)
        Dim rectPrint As RectangleF = e.PageSettings.PrintableArea
        If Me.GunaDataGridView1.Height - rectPrint.Height > 0 Then e.HasMorePages = True


    End Sub

    Private Sub BindingNavigatorMoveLastItem_Click(sender As Object, e As EventArgs) Handles BindingNavigatorMoveLastItem.Click

    End Sub

    Private Sub BtnResult_Click(sender As Object, e As EventArgs) Handles BtnResult.Click

    End Sub

    Private Sub GunaAdvenceButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton1.Click
        ResultBindingSource.AddNew()
    End Sub

    Private Sub GunaAdvenceButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton3.Click
        Try
            ResultBindingSource.EndEdit()
            ResultTableAdapter.Update(StaffDataSet2.Result)
            MessageBox.Show("Data Saved")


        Catch ex As Exception
            MessageBox.Show("Error occured while saving data")
        End Try
    End Sub

    Private Sub GunaAdvenceButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton2.Click
        ResultBindingSource.RemoveCurrent()

    End Sub

    Private Sub GunaGroupBox2_Click(sender As Object, e As EventArgs) Handles GunaGroupBox2.Click

    End Sub

    Private Sub GunaAdvenceButton10_Click(sender As Object, e As EventArgs) Handles GunaAdvenceButton10.Click
        On Error GoTo SearchErr

        If GunaTextBox2.Text = "" Then
            Exit Sub

        Else
            Dim cantFine As String = GunaTextBox2.Text

            ResultBindingSource.Filter = "(Convert(PNGK, 'System.String') LIKE '" & GunaTextBox2.Text & "')"


        End If
SearchErr:
    End Sub


End Class