Public Class AdministratorAreaForm
    Private Sub AdministratorAreaForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCurrentDate.Text = Date.Now.ToString("MMM/dd/yyyy")
    End Sub


    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Me.Close()
    End Sub

    Private Sub dateChooseDoB_ValueChanged(sender As Object, e As EventArgs) Handles dateChooseDoB.ValueChanged
        Dim DoB As Date = dateChooseDoB.Value
        Dim Age As Double = Gbl_AgeYears(DoB)
        txtAge.Text = Age
        Dim Spiral As String = Gbl_SpiralName(Age)
        txtSpiral.Text = Spiral
        Dim Stage As String = Gbl_StageName(Age)
        txtStage.Text = Stage
    End Sub
End Class