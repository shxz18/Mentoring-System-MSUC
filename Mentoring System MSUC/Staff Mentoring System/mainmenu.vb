Public Class mainmenu


    Private Sub mainmenu_Load(sender As Object, e As EventArgs) Handles Me.Load
        Guna.UI.Lib.GraphicsHelper.ShadowForm(Me)
        Guna.UI.Lib.GraphicsHelper.DrawLineShadow(pnlInformation, Color.Black, 20, 5, Guna.UI.WinForms.VerHorAlign.HoriziontalTop)

    End Sub

    Private Sub BtnInfo_Click(sender As Object, e As EventArgs)
        StudentRegistration.Show()
    End Sub

    Private Sub BtnLogOut_Click(sender As Object, e As EventArgs) Handles BtnLogOut.Click
        Me.Close()
        Form1.Show()
    End Sub

    Private Sub BtnGems_Click(sender As Object, e As EventArgs)
        Gems.Show()
    End Sub

    Private Sub BtnResult_Click(sender As Object, e As EventArgs)
        Result.Show()
    End Sub

    Private Sub BtnRegistraton_Click(sender As Object, e As EventArgs)
        SubjectRegistration.Show()

    End Sub

    Private Sub GunaAdvenceTileButton1_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton1.Click
        StudentRegistration.Show()
    End Sub

    Private Sub GunaAdvenceTileButton2_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton2.Click
        Subject.Show()
    End Sub

    Private Sub GunaAdvenceTileButton3_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton3.Click
        Gems.Show()
    End Sub

    Private Sub GunaAdvenceTileButton4_Click(sender As Object, e As EventArgs) Handles GunaAdvenceTileButton4.Click
        Result.Show()
    End Sub
End Class