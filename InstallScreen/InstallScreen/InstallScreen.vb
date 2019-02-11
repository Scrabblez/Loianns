Public Class InstallScreen
    Private Sub InstallScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblContact.Text = "Contact: crystalsingingbowls@gmail.com"
        lblCopyright.Text = "Copyright © 2017 Ann Reeves"
        lblVersion.Text = "Version: 1.0"
    End Sub

    Private Sub btnInstall_Click(sender As Object, e As EventArgs) Handles btnInstall.Click
        'Code to install program
        'If installed go to Splash Screen

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub
End Class
