Public Class frmChoosePhoto

    Private Sub btnSelectPhoto_Click(sender As Object, e As EventArgs) Handles btnSelectPhoto.Click
        'Show the open file dialog box
        If ofdSelectPhoto.ShowDialog = DialogResult.OK Then
            'Load photo into picture box
            picShowPhoto.Image = Image.FromFile(ofdSelectPhoto.FileName)

        End If

    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        'Close window
        Me.Close()
    End Sub



    Private Sub btnOptions_Click(sender As Object, e As EventArgs) Handles btnOptions.Click
        OptionsForm.ShowDialog()
    End Sub


End Class
