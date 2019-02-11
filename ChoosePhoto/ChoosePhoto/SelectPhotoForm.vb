Public Class frmChoosePhoto
    Private Sub btnSelectPhoto_Click(sender As Object, e As EventArgs) Handles btnSelectPhoto.Click
        'Choose Photo FIle
        OpenPhoto()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Cancel and Close
        Me.Close()
    End Sub
End Class
