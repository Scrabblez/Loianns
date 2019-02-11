<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AdministratorAreaForm
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(AdministratorAreaForm))
        Me.lblCurrentDate = New System.Windows.Forms.Label()
        Me.btnClientArea = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblStage = New System.Windows.Forms.Label()
        Me.lblSpiral = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.lblEmail = New System.Windows.Forms.Label()
        Me.lblFullName = New System.Windows.Forms.Label()
        Me.tabAdministrativeArea = New System.Windows.Forms.TabControl()
        Me.tabPractitionerProfile = New System.Windows.Forms.TabPage()
        Me.panPractitionerInformation = New System.Windows.Forms.Panel()
        Me.dateChooseDoB = New System.Windows.Forms.DateTimePicker()
        Me.lblFirstName = New System.Windows.Forms.Label()
        Me.txtFirstName = New System.Windows.Forms.TextBox()
        Me.lblLastName = New System.Windows.Forms.Label()
        Me.txtLastName = New System.Windows.Forms.TextBox()
        Me.lblBusinessName = New System.Windows.Forms.Label()
        Me.txtBusinessName = New System.Windows.Forms.TextBox()
        Me.lblDoB = New System.Windows.Forms.Label()
        Me.lblWebsite = New System.Windows.Forms.Label()
        Me.txtWebsite = New System.Windows.Forms.TextBox()
        Me.lblBusinessPhone = New System.Windows.Forms.Label()
        Me.txtBusinessPhone = New System.Windows.Forms.TextBox()
        Me.lblCellPhone = New System.Windows.Forms.Label()
        Me.txtCellPhone = New System.Windows.Forms.TextBox()
        Me.lblHomePhone = New System.Windows.Forms.Label()
        Me.txtHomePhone = New System.Windows.Forms.TextBox()
        Me.lblAddress = New System.Windows.Forms.Label()
        Me.txtAddress = New System.Windows.Forms.TextBox()
        Me.lblCity = New System.Windows.Forms.Label()
        Me.txtCity = New System.Windows.Forms.TextBox()
        Me.lblState = New System.Windows.Forms.Label()
        Me.txtState = New System.Windows.Forms.TextBox()
        Me.lblCountry = New System.Windows.Forms.Label()
        Me.txtCountry = New System.Windows.Forms.TextBox()
        Me.btnChoosePhoto = New System.Windows.Forms.Button()
        Me.picShowPhoto = New System.Windows.Forms.PictureBox()
        Me.tabAdministratorTools = New System.Windows.Forms.TabPage()
        Me.PanHeader = New System.Windows.Forms.Panel()
        Me.txtStage = New System.Windows.Forms.TextBox()
        Me.txtSpiral = New System.Windows.Forms.TextBox()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.picHeaderLogo = New System.Windows.Forms.PictureBox()
        Me.ofdSelectPhoto = New System.Windows.Forms.OpenFileDialog()
        Me.tabAdministrativeArea.SuspendLayout()
        Me.tabPractitionerProfile.SuspendLayout()
        Me.panPractitionerInformation.SuspendLayout()
        CType(Me.picShowPhoto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PanHeader.SuspendLayout()
        CType(Me.picHeaderLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblCurrentDate
        '
        Me.lblCurrentDate.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCurrentDate.AutoSize = True
        Me.lblCurrentDate.BackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.lblCurrentDate.ForeColor = System.Drawing.Color.White
        Me.lblCurrentDate.Location = New System.Drawing.Point(1171, 4)
        Me.lblCurrentDate.Name = "lblCurrentDate"
        Me.lblCurrentDate.Size = New System.Drawing.Size(90, 16)
        Me.lblCurrentDate.TabIndex = 7
        Me.lblCurrentDate.Text = "Current Date"
        Me.lblCurrentDate.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        '
        'btnClientArea
        '
        Me.btnClientArea.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClientArea.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnClientArea.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnClientArea.Location = New System.Drawing.Point(1108, 51)
        Me.btnClientArea.Name = "btnClientArea"
        Me.btnClientArea.Size = New System.Drawing.Size(150, 23)
        Me.btnClientArea.TabIndex = 11
        Me.btnClientArea.Text = "Client Area"
        Me.btnClientArea.UseVisualStyleBackColor = False
        '
        'btnQuit
        '
        Me.btnQuit.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnQuit.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnQuit.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnQuit.Location = New System.Drawing.Point(1108, 80)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(150, 23)
        Me.btnQuit.TabIndex = 12
        Me.btnQuit.Text = "Exit"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.BackColor = System.Drawing.Color.Transparent
        Me.lblAge.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblAge.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lblAge.Location = New System.Drawing.Point(168, 112)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(45, 19)
        Me.lblAge.TabIndex = 1
        Me.lblAge.Text = "Age:"
        Me.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStage
        '
        Me.lblStage.AutoSize = True
        Me.lblStage.BackColor = System.Drawing.Color.Transparent
        Me.lblStage.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblStage.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblStage.Location = New System.Drawing.Point(478, 112)
        Me.lblStage.MinimumSize = New System.Drawing.Size(50, 14)
        Me.lblStage.Name = "lblStage"
        Me.lblStage.Size = New System.Drawing.Size(60, 19)
        Me.lblStage.TabIndex = 5
        Me.lblStage.Text = "Stage:"
        Me.lblStage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSpiral
        '
        Me.lblSpiral.AutoSize = True
        Me.lblSpiral.BackColor = System.Drawing.Color.Transparent
        Me.lblSpiral.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblSpiral.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSpiral.Location = New System.Drawing.Point(279, 112)
        Me.lblSpiral.MinimumSize = New System.Drawing.Size(50, 14)
        Me.lblSpiral.Name = "lblSpiral"
        Me.lblSpiral.Size = New System.Drawing.Size(60, 19)
        Me.lblSpiral.TabIndex = 3
        Me.lblSpiral.Text = "Spiral:"
        Me.lblSpiral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtEmail.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(182, 195)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(273, 27)
        Me.txtEmail.TabIndex = 54
        Me.txtEmail.Text = "Email Address"
        '
        'lblEmail
        '
        Me.lblEmail.AutoSize = True
        Me.lblEmail.BackColor = System.Drawing.Color.Transparent
        Me.lblEmail.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblEmail.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEmail.Location = New System.Drawing.Point(8, 198)
        Me.lblEmail.MinimumSize = New System.Drawing.Size(50, 14)
        Me.lblEmail.Name = "lblEmail"
        Me.lblEmail.Size = New System.Drawing.Size(126, 19)
        Me.lblEmail.TabIndex = 53
        Me.lblEmail.Text = "Email Address:"
        Me.lblEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblFullName
        '
        Me.lblFullName.AutoSize = True
        Me.lblFullName.BackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.lblFullName.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFullName.ForeColor = System.Drawing.Color.White
        Me.lblFullName.Location = New System.Drawing.Point(168, 75)
        Me.lblFullName.Name = "lblFullName"
        Me.lblFullName.Padding = New System.Windows.Forms.Padding(3)
        Me.lblFullName.Size = New System.Drawing.Size(109, 30)
        Me.lblFullName.TabIndex = 0
        Me.lblFullName.Text = "Full Name"
        '
        'tabAdministrativeArea
        '
        Me.tabAdministrativeArea.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tabAdministrativeArea.Controls.Add(Me.tabPractitionerProfile)
        Me.tabAdministrativeArea.Controls.Add(Me.tabAdministratorTools)
        Me.tabAdministrativeArea.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tabAdministrativeArea.ItemSize = New System.Drawing.Size(180, 30)
        Me.tabAdministrativeArea.Location = New System.Drawing.Point(8, 150)
        Me.tabAdministrativeArea.Name = "tabAdministrativeArea"
        Me.tabAdministrativeArea.SelectedIndex = 0
        Me.tabAdministrativeArea.Size = New System.Drawing.Size(1244, 519)
        Me.tabAdministrativeArea.TabIndex = 55
        '
        'tabPractitionerProfile
        '
        Me.tabPractitionerProfile.Controls.Add(Me.panPractitionerInformation)
        Me.tabPractitionerProfile.Controls.Add(Me.btnChoosePhoto)
        Me.tabPractitionerProfile.Controls.Add(Me.picShowPhoto)
        Me.tabPractitionerProfile.Location = New System.Drawing.Point(4, 34)
        Me.tabPractitionerProfile.Name = "tabPractitionerProfile"
        Me.tabPractitionerProfile.Padding = New System.Windows.Forms.Padding(3)
        Me.tabPractitionerProfile.Size = New System.Drawing.Size(1236, 481)
        Me.tabPractitionerProfile.TabIndex = 0
        Me.tabPractitionerProfile.Text = "Practitioner Profile"
        Me.tabPractitionerProfile.UseVisualStyleBackColor = True
        '
        'panPractitionerInformation
        '
        Me.panPractitionerInformation.Controls.Add(Me.dateChooseDoB)
        Me.panPractitionerInformation.Controls.Add(Me.lblFirstName)
        Me.panPractitionerInformation.Controls.Add(Me.txtFirstName)
        Me.panPractitionerInformation.Controls.Add(Me.lblLastName)
        Me.panPractitionerInformation.Controls.Add(Me.txtLastName)
        Me.panPractitionerInformation.Controls.Add(Me.lblBusinessName)
        Me.panPractitionerInformation.Controls.Add(Me.txtBusinessName)
        Me.panPractitionerInformation.Controls.Add(Me.lblDoB)
        Me.panPractitionerInformation.Controls.Add(Me.lblWebsite)
        Me.panPractitionerInformation.Controls.Add(Me.txtWebsite)
        Me.panPractitionerInformation.Controls.Add(Me.lblEmail)
        Me.panPractitionerInformation.Controls.Add(Me.txtEmail)
        Me.panPractitionerInformation.Controls.Add(Me.lblBusinessPhone)
        Me.panPractitionerInformation.Controls.Add(Me.txtBusinessPhone)
        Me.panPractitionerInformation.Controls.Add(Me.lblCellPhone)
        Me.panPractitionerInformation.Controls.Add(Me.txtCellPhone)
        Me.panPractitionerInformation.Controls.Add(Me.lblHomePhone)
        Me.panPractitionerInformation.Controls.Add(Me.txtHomePhone)
        Me.panPractitionerInformation.Controls.Add(Me.lblAddress)
        Me.panPractitionerInformation.Controls.Add(Me.txtAddress)
        Me.panPractitionerInformation.Controls.Add(Me.lblCity)
        Me.panPractitionerInformation.Controls.Add(Me.txtCity)
        Me.panPractitionerInformation.Controls.Add(Me.lblState)
        Me.panPractitionerInformation.Controls.Add(Me.txtState)
        Me.panPractitionerInformation.Controls.Add(Me.lblCountry)
        Me.panPractitionerInformation.Controls.Add(Me.txtCountry)
        Me.panPractitionerInformation.Dock = System.Windows.Forms.DockStyle.Left
        Me.panPractitionerInformation.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.panPractitionerInformation.Location = New System.Drawing.Point(3, 3)
        Me.panPractitionerInformation.Name = "panPractitionerInformation"
        Me.panPractitionerInformation.Size = New System.Drawing.Size(458, 475)
        Me.panPractitionerInformation.TabIndex = 11
        '
        'dateChooseDoB
        '
        Me.dateChooseDoB.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.dateChooseDoB.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.dateChooseDoB.CalendarTitleForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.dateChooseDoB.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.dateChooseDoB.Location = New System.Drawing.Point(182, 130)
        Me.dateChooseDoB.MaxDate = New Date(2025, 12, 31, 0, 0, 0, 0)
        Me.dateChooseDoB.MinDate = New Date(1920, 1, 1, 0, 0, 0, 0)
        Me.dateChooseDoB.Name = "dateChooseDoB"
        Me.dateChooseDoB.Size = New System.Drawing.Size(273, 27)
        Me.dateChooseDoB.TabIndex = 65
        '
        'lblFirstName
        '
        Me.lblFirstName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblFirstName.AutoSize = True
        Me.lblFirstName.BackColor = System.Drawing.Color.Transparent
        Me.lblFirstName.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblFirstName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblFirstName.Location = New System.Drawing.Point(8, 38)
        Me.lblFirstName.MinimumSize = New System.Drawing.Size(50, 14)
        Me.lblFirstName.Name = "lblFirstName"
        Me.lblFirstName.Size = New System.Drawing.Size(100, 19)
        Me.lblFirstName.TabIndex = 0
        Me.lblFirstName.Text = "First Name:"
        Me.lblFirstName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtFirstName
        '
        Me.txtFirstName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtFirstName.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtFirstName.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtFirstName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtFirstName.Location = New System.Drawing.Point(182, 35)
        Me.txtFirstName.Name = "txtFirstName"
        Me.txtFirstName.Size = New System.Drawing.Size(273, 27)
        Me.txtFirstName.TabIndex = 1
        Me.txtFirstName.Text = "First Name"
        '
        'lblLastName
        '
        Me.lblLastName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblLastName.AutoSize = True
        Me.lblLastName.BackColor = System.Drawing.Color.Transparent
        Me.lblLastName.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblLastName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLastName.Location = New System.Drawing.Point(8, 70)
        Me.lblLastName.MinimumSize = New System.Drawing.Size(50, 14)
        Me.lblLastName.Name = "lblLastName"
        Me.lblLastName.Size = New System.Drawing.Size(98, 19)
        Me.lblLastName.TabIndex = 2
        Me.lblLastName.Text = "Last Name:"
        Me.lblLastName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtLastName
        '
        Me.txtLastName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtLastName.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtLastName.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtLastName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtLastName.Location = New System.Drawing.Point(182, 67)
        Me.txtLastName.Name = "txtLastName"
        Me.txtLastName.Size = New System.Drawing.Size(273, 27)
        Me.txtLastName.TabIndex = 3
        Me.txtLastName.Text = "Last Name"
        '
        'lblBusinessName
        '
        Me.lblBusinessName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBusinessName.AutoSize = True
        Me.lblBusinessName.BackColor = System.Drawing.Color.Transparent
        Me.lblBusinessName.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblBusinessName.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusinessName.Location = New System.Drawing.Point(8, 102)
        Me.lblBusinessName.MinimumSize = New System.Drawing.Size(50, 14)
        Me.lblBusinessName.Name = "lblBusinessName"
        Me.lblBusinessName.Size = New System.Drawing.Size(136, 19)
        Me.lblBusinessName.TabIndex = 4
        Me.lblBusinessName.Text = "Business Name:"
        Me.lblBusinessName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBusinessName
        '
        Me.txtBusinessName.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBusinessName.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtBusinessName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBusinessName.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtBusinessName.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtBusinessName.Location = New System.Drawing.Point(182, 99)
        Me.txtBusinessName.Name = "txtBusinessName"
        Me.txtBusinessName.Size = New System.Drawing.Size(273, 27)
        Me.txtBusinessName.TabIndex = 5
        Me.txtBusinessName.Text = "Business Name"
        '
        'lblDoB
        '
        Me.lblDoB.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblDoB.AutoSize = True
        Me.lblDoB.BackColor = System.Drawing.Color.Transparent
        Me.lblDoB.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblDoB.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDoB.Location = New System.Drawing.Point(8, 134)
        Me.lblDoB.MinimumSize = New System.Drawing.Size(50, 14)
        Me.lblDoB.Name = "lblDoB"
        Me.lblDoB.Size = New System.Drawing.Size(50, 19)
        Me.lblDoB.TabIndex = 6
        Me.lblDoB.Text = "DoB:"
        Me.lblDoB.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblWebsite
        '
        Me.lblWebsite.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblWebsite.AutoSize = True
        Me.lblWebsite.BackColor = System.Drawing.Color.Transparent
        Me.lblWebsite.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblWebsite.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblWebsite.Location = New System.Drawing.Point(8, 166)
        Me.lblWebsite.MinimumSize = New System.Drawing.Size(50, 14)
        Me.lblWebsite.Name = "lblWebsite"
        Me.lblWebsite.Size = New System.Drawing.Size(79, 19)
        Me.lblWebsite.TabIndex = 8
        Me.lblWebsite.Text = "Website:"
        Me.lblWebsite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtWebsite
        '
        Me.txtWebsite.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtWebsite.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtWebsite.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtWebsite.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtWebsite.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtWebsite.Location = New System.Drawing.Point(182, 163)
        Me.txtWebsite.Name = "txtWebsite"
        Me.txtWebsite.Size = New System.Drawing.Size(273, 27)
        Me.txtWebsite.TabIndex = 9
        Me.txtWebsite.Text = "Website"
        '
        'lblBusinessPhone
        '
        Me.lblBusinessPhone.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblBusinessPhone.AutoSize = True
        Me.lblBusinessPhone.BackColor = System.Drawing.Color.Transparent
        Me.lblBusinessPhone.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblBusinessPhone.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBusinessPhone.Location = New System.Drawing.Point(8, 230)
        Me.lblBusinessPhone.MinimumSize = New System.Drawing.Size(50, 14)
        Me.lblBusinessPhone.Name = "lblBusinessPhone"
        Me.lblBusinessPhone.Size = New System.Drawing.Size(142, 19)
        Me.lblBusinessPhone.TabIndex = 47
        Me.lblBusinessPhone.Text = "Business Phone:"
        Me.lblBusinessPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtBusinessPhone
        '
        Me.txtBusinessPhone.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtBusinessPhone.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtBusinessPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtBusinessPhone.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtBusinessPhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtBusinessPhone.Location = New System.Drawing.Point(182, 227)
        Me.txtBusinessPhone.Name = "txtBusinessPhone"
        Me.txtBusinessPhone.Size = New System.Drawing.Size(273, 27)
        Me.txtBusinessPhone.TabIndex = 48
        Me.txtBusinessPhone.Text = "Business Phone"
        '
        'lblCellPhone
        '
        Me.lblCellPhone.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCellPhone.AutoSize = True
        Me.lblCellPhone.BackColor = System.Drawing.Color.Transparent
        Me.lblCellPhone.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblCellPhone.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCellPhone.Location = New System.Drawing.Point(8, 262)
        Me.lblCellPhone.MinimumSize = New System.Drawing.Size(50, 14)
        Me.lblCellPhone.Name = "lblCellPhone"
        Me.lblCellPhone.Size = New System.Drawing.Size(99, 19)
        Me.lblCellPhone.TabIndex = 49
        Me.lblCellPhone.Text = "Cell Phone:"
        Me.lblCellPhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCellPhone
        '
        Me.txtCellPhone.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCellPhone.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtCellPhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCellPhone.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtCellPhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtCellPhone.Location = New System.Drawing.Point(182, 259)
        Me.txtCellPhone.Name = "txtCellPhone"
        Me.txtCellPhone.Size = New System.Drawing.Size(273, 27)
        Me.txtCellPhone.TabIndex = 50
        Me.txtCellPhone.Text = "Cell Phone"
        '
        'lblHomePhone
        '
        Me.lblHomePhone.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblHomePhone.AutoSize = True
        Me.lblHomePhone.BackColor = System.Drawing.Color.Transparent
        Me.lblHomePhone.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblHomePhone.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHomePhone.Location = New System.Drawing.Point(8, 294)
        Me.lblHomePhone.MinimumSize = New System.Drawing.Size(50, 14)
        Me.lblHomePhone.Name = "lblHomePhone"
        Me.lblHomePhone.Size = New System.Drawing.Size(115, 19)
        Me.lblHomePhone.TabIndex = 51
        Me.lblHomePhone.Text = "Home Phone:"
        Me.lblHomePhone.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtHomePhone
        '
        Me.txtHomePhone.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtHomePhone.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtHomePhone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtHomePhone.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtHomePhone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtHomePhone.Location = New System.Drawing.Point(182, 291)
        Me.txtHomePhone.Name = "txtHomePhone"
        Me.txtHomePhone.Size = New System.Drawing.Size(273, 27)
        Me.txtHomePhone.TabIndex = 52
        Me.txtHomePhone.Text = "Home Phone"
        '
        'lblAddress
        '
        Me.lblAddress.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblAddress.AutoSize = True
        Me.lblAddress.BackColor = System.Drawing.Color.Transparent
        Me.lblAddress.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblAddress.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAddress.Location = New System.Drawing.Point(9, 326)
        Me.lblAddress.MinimumSize = New System.Drawing.Size(50, 14)
        Me.lblAddress.Name = "lblAddress"
        Me.lblAddress.Size = New System.Drawing.Size(80, 19)
        Me.lblAddress.TabIndex = 57
        Me.lblAddress.Text = "Address:"
        Me.lblAddress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtAddress
        '
        Me.txtAddress.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtAddress.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtAddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtAddress.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtAddress.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtAddress.Location = New System.Drawing.Point(182, 323)
        Me.txtAddress.Name = "txtAddress"
        Me.txtAddress.Size = New System.Drawing.Size(273, 27)
        Me.txtAddress.TabIndex = 58
        Me.txtAddress.Text = "Address"
        '
        'lblCity
        '
        Me.lblCity.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCity.AutoSize = True
        Me.lblCity.BackColor = System.Drawing.Color.Transparent
        Me.lblCity.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblCity.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCity.Location = New System.Drawing.Point(9, 358)
        Me.lblCity.MinimumSize = New System.Drawing.Size(50, 14)
        Me.lblCity.Name = "lblCity"
        Me.lblCity.Size = New System.Drawing.Size(50, 19)
        Me.lblCity.TabIndex = 59
        Me.lblCity.Text = "City:"
        Me.lblCity.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCity
        '
        Me.txtCity.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCity.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtCity.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCity.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtCity.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtCity.Location = New System.Drawing.Point(182, 355)
        Me.txtCity.Name = "txtCity"
        Me.txtCity.Size = New System.Drawing.Size(273, 27)
        Me.txtCity.TabIndex = 60
        Me.txtCity.Text = "City"
        '
        'lblState
        '
        Me.lblState.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblState.AutoSize = True
        Me.lblState.BackColor = System.Drawing.Color.Transparent
        Me.lblState.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblState.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblState.Location = New System.Drawing.Point(9, 390)
        Me.lblState.MinimumSize = New System.Drawing.Size(50, 14)
        Me.lblState.Name = "lblState"
        Me.lblState.Size = New System.Drawing.Size(130, 19)
        Me.lblState.TabIndex = 61
        Me.lblState.Text = "Province/State:"
        Me.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtState
        '
        Me.txtState.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtState.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtState.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtState.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtState.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtState.Location = New System.Drawing.Point(182, 387)
        Me.txtState.Name = "txtState"
        Me.txtState.Size = New System.Drawing.Size(273, 27)
        Me.txtState.TabIndex = 62
        Me.txtState.Text = "Province/State"
        '
        'lblCountry
        '
        Me.lblCountry.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lblCountry.AutoSize = True
        Me.lblCountry.BackColor = System.Drawing.Color.Transparent
        Me.lblCountry.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.lblCountry.Font = New System.Drawing.Font("Arial", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountry.Location = New System.Drawing.Point(9, 422)
        Me.lblCountry.MinimumSize = New System.Drawing.Size(50, 14)
        Me.lblCountry.Name = "lblCountry"
        Me.lblCountry.Size = New System.Drawing.Size(79, 19)
        Me.lblCountry.TabIndex = 63
        Me.lblCountry.Text = "Country:"
        Me.lblCountry.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtCountry
        '
        Me.txtCountry.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txtCountry.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.txtCountry.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtCountry.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtCountry.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.txtCountry.Location = New System.Drawing.Point(182, 419)
        Me.txtCountry.Name = "txtCountry"
        Me.txtCountry.Size = New System.Drawing.Size(273, 27)
        Me.txtCountry.TabIndex = 64
        Me.txtCountry.Text = "Country"
        '
        'btnChoosePhoto
        '
        Me.btnChoosePhoto.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(198, Byte), Integer), CType(CType(212, Byte), Integer))
        Me.btnChoosePhoto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnChoosePhoto.Font = New System.Drawing.Font("Arial", 8.0!)
        Me.btnChoosePhoto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(53, Byte), Integer), CType(CType(68, Byte), Integer))
        Me.btnChoosePhoto.Location = New System.Drawing.Point(670, 207)
        Me.btnChoosePhoto.Name = "btnChoosePhoto"
        Me.btnChoosePhoto.Size = New System.Drawing.Size(82, 23)
        Me.btnChoosePhoto.TabIndex = 66
        Me.btnChoosePhoto.Text = "Choose Photo"
        Me.btnChoosePhoto.UseVisualStyleBackColor = False
        '
        'picShowPhoto
        '
        Me.picShowPhoto.BackgroundImage = Global.SoulSong_Analysis.My.Resources.Resources.FrameSpacer
        Me.picShowPhoto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picShowPhoto.Location = New System.Drawing.Point(623, 41)
        Me.picShowPhoto.Name = "picShowPhoto"
        Me.picShowPhoto.Size = New System.Drawing.Size(160, 160)
        Me.picShowPhoto.TabIndex = 12
        Me.picShowPhoto.TabStop = False
        '
        'tabAdministratorTools
        '
        Me.tabAdministratorTools.Location = New System.Drawing.Point(4, 34)
        Me.tabAdministratorTools.Name = "tabAdministratorTools"
        Me.tabAdministratorTools.Padding = New System.Windows.Forms.Padding(3)
        Me.tabAdministratorTools.Size = New System.Drawing.Size(1236, 481)
        Me.tabAdministratorTools.TabIndex = 1
        Me.tabAdministratorTools.Text = "Administrator Tools"
        Me.tabAdministratorTools.UseVisualStyleBackColor = True
        '
        'PanHeader
        '
        Me.PanHeader.AutoSize = True
        Me.PanHeader.BackColor = System.Drawing.Color.Transparent
        Me.PanHeader.BackgroundImage = Global.SoulSong_Analysis.My.Resources.Resources.BkgdHeader
        Me.PanHeader.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PanHeader.Controls.Add(Me.txtStage)
        Me.PanHeader.Controls.Add(Me.lblFullName)
        Me.PanHeader.Controls.Add(Me.lblAge)
        Me.PanHeader.Controls.Add(Me.lblSpiral)
        Me.PanHeader.Controls.Add(Me.txtSpiral)
        Me.PanHeader.Controls.Add(Me.lblStage)
        Me.PanHeader.Controls.Add(Me.lblCurrentDate)
        Me.PanHeader.Controls.Add(Me.txtAge)
        Me.PanHeader.Controls.Add(Me.btnClientArea)
        Me.PanHeader.Controls.Add(Me.btnQuit)
        Me.PanHeader.Controls.Add(Me.picHeaderLogo)
        Me.PanHeader.Dock = System.Windows.Forms.DockStyle.Top
        Me.PanHeader.ForeColor = System.Drawing.Color.White
        Me.PanHeader.Location = New System.Drawing.Point(0, 0)
        Me.PanHeader.Name = "PanHeader"
        Me.PanHeader.Size = New System.Drawing.Size(1264, 144)
        Me.PanHeader.TabIndex = 56
        '
        'txtStage
        '
        Me.txtStage.BackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.txtStage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtStage.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtStage.ForeColor = System.Drawing.Color.White
        Me.txtStage.Location = New System.Drawing.Point(568, 112)
        Me.txtStage.Name = "txtStage"
        Me.txtStage.Size = New System.Drawing.Size(116, 20)
        Me.txtStage.TabIndex = 15
        Me.txtStage.Text = "Stage"
        '
        'txtSpiral
        '
        Me.txtSpiral.BackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.txtSpiral.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtSpiral.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtSpiral.ForeColor = System.Drawing.Color.White
        Me.txtSpiral.Location = New System.Drawing.Point(345, 112)
        Me.txtSpiral.Name = "txtSpiral"
        Me.txtSpiral.Size = New System.Drawing.Size(116, 20)
        Me.txtSpiral.TabIndex = 14
        Me.txtSpiral.Tag = ""
        Me.txtSpiral.Text = "Spiral"
        '
        'txtAge
        '
        Me.txtAge.BackColor = System.Drawing.Color.FromArgb(CType(CType(101, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(150, Byte), Integer))
        Me.txtAge.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtAge.Font = New System.Drawing.Font("Arial", 10.0!)
        Me.txtAge.ForeColor = System.Drawing.Color.White
        Me.txtAge.Location = New System.Drawing.Point(219, 112)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(35, 20)
        Me.txtAge.TabIndex = 13
        Me.txtAge.TabStop = False
        Me.txtAge.Text = "Age"
        Me.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'picHeaderLogo
        '
        Me.picHeaderLogo.BackColor = System.Drawing.Color.Transparent
        Me.picHeaderLogo.BackgroundImage = Global.SoulSong_Analysis.My.Resources.Resources.HeaderLogo
        Me.picHeaderLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.picHeaderLogo.Location = New System.Drawing.Point(3, 4)
        Me.picHeaderLogo.Name = "picHeaderLogo"
        Me.picHeaderLogo.Size = New System.Drawing.Size(445, 137)
        Me.picHeaderLogo.TabIndex = 0
        Me.picHeaderLogo.TabStop = False
        '
        'ofdSelectPhoto
        '
        Me.ofdSelectPhoto.Filter = "PNG|*.png|Windows Bitmaps|*.bmp|JPEG|*.jpg"
        Me.ofdSelectPhoto.Title = "SelectPhoto"
        '
        'AdministratorAreaForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(161, Byte), Integer), CType(CType(171, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BackgroundImage = Global.SoulSong_Analysis.My.Resources.Resources.BkgdFormDark
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1264, 681)
        Me.Controls.Add(Me.tabAdministrativeArea)
        Me.Controls.Add(Me.PanHeader)
        Me.DoubleBuffered = True
        Me.Font = New System.Drawing.Font("Arial", 8.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "AdministratorAreaForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Administrator Area"
        Me.tabAdministrativeArea.ResumeLayout(False)
        Me.tabPractitionerProfile.ResumeLayout(False)
        Me.panPractitionerInformation.ResumeLayout(False)
        Me.panPractitionerInformation.PerformLayout()
        CType(Me.picShowPhoto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PanHeader.ResumeLayout(False)
        Me.PanHeader.PerformLayout()
        CType(Me.picHeaderLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCurrentDate As Label
    Friend WithEvents btnClientArea As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents lblAge As Label
    Friend WithEvents lblStage As Label
    Friend WithEvents lblSpiral As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents lblEmail As Label
    Friend WithEvents lblFullName As Label
    Friend WithEvents tabAdministrativeArea As TabControl
    Friend WithEvents tabPractitionerProfile As TabPage
    Friend WithEvents panPractitionerInformation As Panel
    Friend WithEvents txtCountry As TextBox
    Friend WithEvents txtHomePhone As TextBox
    Friend WithEvents lblCountry As Label
    Friend WithEvents txtState As TextBox
    Friend WithEvents lblHomePhone As Label
    Friend WithEvents lblState As Label
    Friend WithEvents txtCity As TextBox
    Friend WithEvents txtCellPhone As TextBox
    Friend WithEvents lblCity As Label
    Friend WithEvents txtAddress As TextBox
    Friend WithEvents lblCellPhone As Label
    Friend WithEvents lblAddress As Label
    Friend WithEvents lblBusinessName As Label
    Friend WithEvents txtBusinessPhone As TextBox
    Friend WithEvents lblBusinessPhone As Label
    Friend WithEvents txtLastName As TextBox
    Friend WithEvents txtBusinessName As TextBox
    Friend WithEvents lblLastName As Label
    Friend WithEvents lblFirstName As Label
    Friend WithEvents txtFirstName As TextBox
    Friend WithEvents lblDoB As Label
    Friend WithEvents lblWebsite As Label
    Friend WithEvents txtWebsite As TextBox
    Friend WithEvents tabAdministratorTools As TabPage
    Friend WithEvents PanHeader As Panel
    Friend WithEvents picHeaderLogo As PictureBox
    Friend WithEvents picShowPhoto As PictureBox
    Friend WithEvents btnChoosePhoto As Button
    Friend WithEvents ofdSelectPhoto As OpenFileDialog
    Friend WithEvents txtStage As TextBox
    Friend WithEvents txtSpiral As TextBox
    Friend WithEvents txtAge As TextBox
    Friend WithEvents dateChooseDoB As DateTimePicker
End Class
