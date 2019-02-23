<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InstallScreen
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(InstallScreen))
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.lblContact = New System.Windows.Forms.Label()
        Me.btnInstall = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblVersion
        '
        Me.lblVersion.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblVersion.BackColor = System.Drawing.Color.Transparent
        Me.lblVersion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.lblVersion.Location = New System.Drawing.Point(1046, 623)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(100, 16)
        Me.lblVersion.TabIndex = 5
        Me.lblVersion.Text = "R"
        Me.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'lblCopyright
        '
        Me.lblCopyright.Anchor = System.Windows.Forms.AnchorStyles.Bottom
        Me.lblCopyright.AutoSize = True
        Me.lblCopyright.BackColor = System.Drawing.Color.Transparent
        Me.lblCopyright.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.lblCopyright.Location = New System.Drawing.Point(529, 623)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(22, 19)
        Me.lblCopyright.TabIndex = 4
        Me.lblCopyright.Text = "M"
        Me.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblContact
        '
        Me.lblContact.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.lblContact.AutoSize = True
        Me.lblContact.BackColor = System.Drawing.Color.Transparent
        Me.lblContact.ForeColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.lblContact.Location = New System.Drawing.Point(6, 623)
        Me.lblContact.Name = "lblContact"
        Me.lblContact.Size = New System.Drawing.Size(18, 19)
        Me.lblContact.TabIndex = 3
        Me.lblContact.Text = "L"
        Me.lblContact.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'btnInstall
        '
        Me.btnInstall.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnInstall.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnInstall.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnInstall.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnInstall.Location = New System.Drawing.Point(683, 424)
        Me.btnInstall.Name = "btnInstall"
        Me.btnInstall.Size = New System.Drawing.Size(350, 50)
        Me.btnInstall.TabIndex = 6
        Me.btnInstall.Text = "Install SoulSong Analysis"
        Me.btnInstall.UseVisualStyleBackColor = False
        '
        'btnCancel
        '
        Me.btnCancel.BackColor = System.Drawing.SystemColors.ControlDarkDark
        Me.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCancel.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold)
        Me.btnCancel.ForeColor = System.Drawing.SystemColors.ControlLight
        Me.btnCancel.Location = New System.Drawing.Point(683, 492)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(350, 50)
        Me.btnCancel.TabIndex = 7
        Me.btnCancel.Text = "Cancel Installation"
        Me.btnCancel.UseVisualStyleBackColor = False
        '
        'InstallScreen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 19.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.InstallScreen.My.Resources.Resources.InstallScreen
        Me.ClientSize = New System.Drawing.Size(1150, 648)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnInstall)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.lblContact)
        Me.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "InstallScreen"
        Me.Text = "InstallScreen"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblVersion As Label
    Friend WithEvents lblCopyright As Label
    Friend WithEvents lblContact As Label
    Friend WithEvents btnInstall As Button
    Friend WithEvents btnCancel As Button
End Class
