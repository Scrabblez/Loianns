<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Me.dateChooseDoB = New System.Windows.Forms.DateTimePicker()
        Me.txtAge = New System.Windows.Forms.TextBox()
        Me.txtSpiral = New System.Windows.Forms.TextBox()
        Me.lblAge = New System.Windows.Forms.Label()
        Me.lblSpiral = New System.Windows.Forms.Label()
        Me.lblStage = New System.Windows.Forms.Label()
        Me.txtStage = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'dateChooseDoB
        '
        Me.dateChooseDoB.Location = New System.Drawing.Point(32, 63)
        Me.dateChooseDoB.MaxDate = New Date(2025, 12, 31, 0, 0, 0, 0)
        Me.dateChooseDoB.MinDate = New Date(1920, 1, 1, 0, 0, 0, 0)
        Me.dateChooseDoB.Name = "dateChooseDoB"
        Me.dateChooseDoB.Size = New System.Drawing.Size(171, 22)
        Me.dateChooseDoB.TabIndex = 0
        '
        'txtAge
        '
        Me.txtAge.Location = New System.Drawing.Point(95, 119)
        Me.txtAge.Name = "txtAge"
        Me.txtAge.Size = New System.Drawing.Size(60, 22)
        Me.txtAge.TabIndex = 2
        Me.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'txtSpiral
        '
        Me.txtSpiral.Location = New System.Drawing.Point(95, 147)
        Me.txtSpiral.Name = "txtSpiral"
        Me.txtSpiral.Size = New System.Drawing.Size(175, 22)
        Me.txtSpiral.TabIndex = 3
        '
        'lblAge
        '
        Me.lblAge.AutoSize = True
        Me.lblAge.Location = New System.Drawing.Point(29, 124)
        Me.lblAge.Name = "lblAge"
        Me.lblAge.Size = New System.Drawing.Size(33, 17)
        Me.lblAge.TabIndex = 4
        Me.lblAge.Text = "Age"
        Me.lblAge.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblSpiral
        '
        Me.lblSpiral.AutoSize = True
        Me.lblSpiral.Location = New System.Drawing.Point(29, 152)
        Me.lblSpiral.Name = "lblSpiral"
        Me.lblSpiral.Size = New System.Drawing.Size(44, 17)
        Me.lblSpiral.TabIndex = 5
        Me.lblSpiral.Text = "Spiral"
        Me.lblSpiral.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblStage
        '
        Me.lblStage.AutoSize = True
        Me.lblStage.Location = New System.Drawing.Point(29, 180)
        Me.lblStage.Name = "lblStage"
        Me.lblStage.Size = New System.Drawing.Size(45, 17)
        Me.lblStage.TabIndex = 6
        Me.lblStage.Text = "Stage"
        Me.lblStage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txtStage
        '
        Me.txtStage.Location = New System.Drawing.Point(95, 175)
        Me.txtStage.Name = "txtStage"
        Me.txtStage.Size = New System.Drawing.Size(175, 22)
        Me.txtStage.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(282, 253)
        Me.Controls.Add(Me.txtStage)
        Me.Controls.Add(Me.lblStage)
        Me.Controls.Add(Me.lblSpiral)
        Me.Controls.Add(Me.lblAge)
        Me.Controls.Add(Me.txtSpiral)
        Me.Controls.Add(Me.txtAge)
        Me.Controls.Add(Me.dateChooseDoB)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dateChooseDoB As DateTimePicker
    Friend WithEvents txtAge As TextBox
    Friend WithEvents txtSpiral As TextBox
    Friend WithEvents lblAge As Label
    Friend WithEvents lblSpiral As Label
    Friend WithEvents lblStage As Label
    Friend WithEvents txtStage As TextBox
End Class
