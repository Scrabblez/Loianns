Module SelectPhoto
    Public Sub OpenPhoto()
        'Show the openfile dialog box.
        If frmChoosePhoto.ofdSelectPhoto.ShowDialog = DialogResult.OK Then
            'Load the photo into the picture box
            frmChoosePhoto.picShowPhoto.Image =
                Image.FromFile(frmChoosePhoto.ofdSelectPhoto.FileName)
        End If
    End Sub

    'Draw border around picture box
    Public Sub DrawBorder(ByRef objPictureBox As PictureBox)
        Dim objGraphics As Graphics
        objGraphics = objPictureBox.Parent.CreateGraphics
        objGraphics.Clear(System.Drawing.SystemColors.Control)
        objGraphics.DrawRectangle(System.Drawing.Pens.Blue, objPictureBox.Left - 1,
                                  objPictureBox.Top - 1,
                                  objPictureBox.Width + 1, objPictureBox.Height + 1)
        objGraphics.Dispose()
    End Sub
End Module
