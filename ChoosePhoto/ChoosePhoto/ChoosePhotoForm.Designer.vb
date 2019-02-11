<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmChoosePhoto
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmChoosePhoto))
        Me.btnSelectPhoto = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.ofdSelectPhoto = New System.Windows.Forms.OpenFileDialog()
        Me.btnOptions = New System.Windows.Forms.Button()
        Me.picShowPhoto = New System.Windows.Forms.PictureBox()
        CType(Me.picShowPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnSelectPhoto
        '
        Me.btnSelectPhoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnSelectPhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnSelectPhoto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.btnSelectPhoto.Location = New System.Drawing.Point(312, 10)
        Me.btnSelectPhoto.Name = "btnSelectPhoto"
        Me.btnSelectPhoto.Size = New System.Drawing.Size(100, 23)
        Me.btnSelectPhoto.TabIndex = 0
        Me.btnSelectPhoto.Text = "Select Photo"
        Me.btnSelectPhoto.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.btnCancel.Location = New System.Drawing.Point(312, 40)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(100, 23)
        Me.btnCancel.TabIndex = 1
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'ofdSelectPhoto
        '
        Me.ofdSelectPhoto.Filter = "PNG Files|*.png|WIndows Bitmaps|*.bmp|JPEG Files|*.jpg"
        Me.ofdSelectPhoto.Title = "Select Photo"
        '
        'btnOptions
        '
        Me.btnOptions.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOptions.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.btnOptions.Location = New System.Drawing.Point(312, 189)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(100, 23)
        Me.btnOptions.TabIndex = 3
        Me.btnOptions.Text = "Options"
        Me.btnOptions.UseVisualStyleBackColor = False
        '
        'picShowPhoto
        '
        Me.picShowPhoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(131, Byte), Integer), CType(CType(144, Byte), Integer), CType(CType(171, Byte), Integer))
        Me.picShowPhoto.BackgroundImage = Global.ChoosePhoto.My.Resources.Resources.FrameSpacer
        Me.picShowPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.picShowPhoto.Location = New System.Drawing.Point(5, 10)
        Me.picShowPhoto.Name = "picShowPhoto"
        Me.picShowPhoto.Size = New System.Drawing.Size(300, 300)
        Me.picShowPhoto.TabIndex = 2
        Me.picShowPhoto.TabStop = False
        '
        'frmChoosePhoto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(415, 320)
        Me.Controls.Add(Me.btnOptions)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSelectPhoto)
        Me.Controls.Add(Me.picShowPhoto)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(80, Byte), Integer), CType(CType(93, Byte), Integer), CType(CType(119, Byte), Integer))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmChoosePhoto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Choose Photo"
        CType(Me.picShowPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents btnSelectPhoto As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents picShowPhoto As PictureBox
    Friend WithEvents ofdSelectPhoto As OpenFileDialog
    Friend WithEvents btnOptions As Button
End Class
