Public Class Form1
    'To Do: check to see if DoB is in database
    Public Sub dateChooseDoB_ValueChanged(sender As Object, e As EventArgs) Handles dateChooseDoB.ValueChanged
        Dim DoB As Date = dateChooseDoB.Value
        Dim Age As Double = Gbl_AgeYears(DoB)
        txtAge.Text = Age
        Dim Spiral As String = Gbl_SpiralName(Age)
        txtSpiral.Text = Spiral
        Dim Stage As String = Gbl_StageName(Age)
        txtStage.Text = Stage
    End Sub

End Class

