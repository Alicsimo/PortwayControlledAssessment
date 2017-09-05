<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
<Global.System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Naming", "CA1726")> _
Partial Class LoginForm
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
    Friend WithEvents LogoPictureBox As System.Windows.Forms.PictureBox
    Friend WithEvents UsernameLabel As System.Windows.Forms.Label
    Friend WithEvents lblPass As System.Windows.Forms.Label
    Friend WithEvents txbUsername As System.Windows.Forms.TextBox
    Friend WithEvents txbPassword As System.Windows.Forms.TextBox
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnCancel As System.Windows.Forms.Button

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.lblPass = New System.Windows.Forms.Label()
        Me.txbUsername = New System.Windows.Forms.TextBox()
        Me.txbPassword = New System.Windows.Forms.TextBox()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.radGuest = New System.Windows.Forms.RadioButton()
        Me.radStaff = New System.Windows.Forms.RadioButton()
        Me.btnHelp = New System.Windows.Forms.Button()
        Me.lblIncorrectLogin = New System.Windows.Forms.Label()
        Me.LogoPictureBox = New System.Windows.Forms.PictureBox()
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'UsernameLabel
        '
        Me.UsernameLabel.Location = New System.Drawing.Point(90, 179)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(220, 23)
        Me.UsernameLabel.TabIndex = 0
        Me.UsernameLabel.Text = "&User name"
        Me.UsernameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'lblPass
        '
        Me.lblPass.Location = New System.Drawing.Point(91, 257)
        Me.lblPass.Name = "lblPass"
        Me.lblPass.Size = New System.Drawing.Size(220, 23)
        Me.lblPass.TabIndex = 2
        Me.lblPass.Text = "&Password"
        Me.lblPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'txbUsername
        '
        Me.txbUsername.Location = New System.Drawing.Point(92, 199)
        Me.txbUsername.Name = "txbUsername"
        Me.txbUsername.Size = New System.Drawing.Size(220, 20)
        Me.txbUsername.TabIndex = 1
        '
        'txbPassword
        '
        Me.txbPassword.Location = New System.Drawing.Point(93, 277)
        Me.txbPassword.Name = "txbPassword"
        Me.txbPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txbPassword.Size = New System.Drawing.Size(220, 20)
        Me.txbPassword.TabIndex = 3
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(108, 314)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(94, 23)
        Me.btnOK.TabIndex = 4
        Me.btnOK.Text = "&OK"
        '
        'btnCancel
        '
        Me.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnCancel.Location = New System.Drawing.Point(211, 314)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(94, 23)
        Me.btnCancel.TabIndex = 5
        Me.btnCancel.Text = "&Exit"
        '
        'radGuest
        '
        Me.radGuest.AutoSize = True
        Me.radGuest.Checked = True
        Me.radGuest.Location = New System.Drawing.Point(96, 237)
        Me.radGuest.Name = "radGuest"
        Me.radGuest.Size = New System.Drawing.Size(53, 17)
        Me.radGuest.TabIndex = 6
        Me.radGuest.TabStop = True
        Me.radGuest.Text = "Guest"
        Me.radGuest.UseVisualStyleBackColor = True
        '
        'radStaff
        '
        Me.radStaff.AutoSize = True
        Me.radStaff.Location = New System.Drawing.Point(263, 237)
        Me.radStaff.Name = "radStaff"
        Me.radStaff.Size = New System.Drawing.Size(47, 17)
        Me.radStaff.TabIndex = 7
        Me.radStaff.TabStop = True
        Me.radStaff.Text = "Staff"
        Me.radStaff.UseVisualStyleBackColor = True
        '
        'btnHelp
        '
        Me.btnHelp.Location = New System.Drawing.Point(369, 314)
        Me.btnHelp.Name = "btnHelp"
        Me.btnHelp.Size = New System.Drawing.Size(20, 23)
        Me.btnHelp.TabIndex = 8
        Me.btnHelp.Text = "?"
        Me.btnHelp.UseVisualStyleBackColor = True
        '
        'lblIncorrectLogin
        '
        Me.lblIncorrectLogin.AutoSize = True
        Me.lblIncorrectLogin.ForeColor = System.Drawing.Color.Red
        Me.lblIncorrectLogin.Location = New System.Drawing.Point(92, 298)
        Me.lblIncorrectLogin.Name = "lblIncorrectLogin"
        Me.lblIncorrectLogin.Size = New System.Drawing.Size(133, 13)
        Me.lblIncorrectLogin.TabIndex = 10
        Me.lblIncorrectLogin.Text = "Incorrect Login Credentials"
        '
        'LogoPictureBox
        '
        Me.LogoPictureBox.Image = Global.Controlled_Assessment_Prototype.My.Resources.Resources.Portway_Logo
        Me.LogoPictureBox.Location = New System.Drawing.Point(96, 2)
        Me.LogoPictureBox.Name = "LogoPictureBox"
        Me.LogoPictureBox.Size = New System.Drawing.Size(197, 158)
        Me.LogoPictureBox.TabIndex = 0
        Me.LogoPictureBox.TabStop = False
        '
        'LoginForm
        '
        Me.AcceptButton = Me.btnOK
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnCancel
        Me.ClientSize = New System.Drawing.Size(401, 349)
        Me.Controls.Add(Me.lblIncorrectLogin)
        Me.Controls.Add(Me.btnHelp)
        Me.Controls.Add(Me.radStaff)
        Me.Controls.Add(Me.radGuest)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.txbPassword)
        Me.Controls.Add(Me.txbUsername)
        Me.Controls.Add(Me.lblPass)
        Me.Controls.Add(Me.UsernameLabel)
        Me.Controls.Add(Me.LogoPictureBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "LoginForm"
        Me.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Login"
        CType(Me.LogoPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents radGuest As System.Windows.Forms.RadioButton
    Friend WithEvents radStaff As System.Windows.Forms.RadioButton
    Friend WithEvents btnHelp As System.Windows.Forms.Button
    Friend WithEvents lblIncorrectLogin As System.Windows.Forms.Label

End Class
