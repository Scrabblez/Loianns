<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmChoosePhoto
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnSelectPhoto = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.ofdSelectPhoto = New System.Windows.Forms.OpenFileDialog()
        Me.picShowPhoto = New System.Windows.Forms.PictureBox()
        CType(Me.picShowPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSelectPhoto
        '
        Me.btnSelectPhoto.Location = New System.Drawing.Point(158, 59)
        Me.btnSelectPhoto.Name = "btnSelectPhoto"
        Me.btnSelectPhoto.Size = New System.Drawing.Size(120, 23)
        Me.btnSelectPhoto.TabIndex = 0
        Me.btnSelectPhoto.Text = "Select Photo"
        Me.btnSelectPhoto.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(158, 112)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(120, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'ofdSelectPhoto
        '
        Me.ofdSelectPhoto.Filter = "PNG Files|*.png|Windows Bitmap|*.bmp|JPEG Files|*.jpg"
        Me.ofdSelectPhoto.Title = "Select Photo"
        '
        'picShowPhoto
        '
        Me.picShowPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picShowPhoto.Image = Global.ChoosePhoto.My.Resources.Resources.Photo_Frame
        Me.picShowPhoto.Location = New System.Drawing.Point(12, 12)
        Me.picShowPhoto.Name = "picShowPhoto"
        Me.picShowPhoto.Size = New System.Drawing.Size(140, 180)
        Me.picShowPhoto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.picShowPhoto.TabIndex = 2
        Me.picShowPhoto.TabStop = False
        '
        'frmChoosePhoto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 203)
        Me.Controls.Add(Me.picShowPhoto)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSelectPhoto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmChoosePhoto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Choose Photo"
        CType(Me.picShowPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSelectPhoto As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents ofdSelectPhoto As OpenFileDialog
    Friend WithEvents picShowPhoto As PictureBox
End Class
