Public Class SubjectPrint
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        Dim x As Integer = 170
        Dim y As Integer = 360
        Dim width As Integer = 190

        Dim yHeight As Integer = 20
        Dim CellWidth As Integer = 300
        Dim CellHeight As Integer = 370

        Dim Fon As New Font(FontFamily.GenericSerif, 12, FontStyle.Regular)
        Dim rect As New Rectangle(x, 10, width, yHeight)
        Dim strings As New StringFormat

        '  strings.Alignment = StringAlignment.Center
        '  strings.LineAlignmnent = StringAlignment.Center
        '  e.Graphics.FillRectangle(Brushes.WhiteSmoke, rect)
        '  e.Graphics.DrawRectangle(Pens.Black, rect)
        ' e.Graphics.DrawString(SubjectRegistration.GunaDataGridView1.HeaderText, Fon, gBrushes.Black, rect, strings)
    End Sub
End Class