Public Class BkGdForm
    Private Sub BkGdForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblCurrentDate.Text = Date.Now.ToLongDateString
        lblContact.Text = "Contact: crystalsingingbowls@gmail.com"
        lblCopyright.Text = "Copyright © 2017 Ann Reeves"
        lblVersion.Text = "Version: 1.0"
    End Sub
End Class
