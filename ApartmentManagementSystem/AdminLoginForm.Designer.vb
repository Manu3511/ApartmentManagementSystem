<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class AdminLoginForm
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
        Me.ShowPasswordCheckBox = New System.Windows.Forms.CheckBox()
        Me.LoginButton = New System.Windows.Forms.Button()
        Me.UsernameTextBox = New System.Windows.Forms.TextBox()
        Me.PasswordTextBox = New System.Windows.Forms.TextBox()
        Me.CancelFormButton = New System.Windows.Forms.Button()
        Me.ResetButton = New System.Windows.Forms.Button()
        Me.CustomerLoginCheckBox = New System.Windows.Forms.CheckBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'ShowPasswordCheckBox
        '
        Me.ShowPasswordCheckBox.AutoSize = True
        Me.ShowPasswordCheckBox.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ShowPasswordCheckBox.Location = New System.Drawing.Point(654, 186)
        Me.ShowPasswordCheckBox.Name = "ShowPasswordCheckBox"
        Me.ShowPasswordCheckBox.Size = New System.Drawing.Size(140, 24)
        Me.ShowPasswordCheckBox.TabIndex = 0
        Me.ShowPasswordCheckBox.Text = "Show Password"
        Me.ShowPasswordCheckBox.UseVisualStyleBackColor = True
        '
        'LoginButton
        '
        Me.LoginButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.LoginButton.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LoginButton.Location = New System.Drawing.Point(560, 232)
        Me.LoginButton.Name = "LoginButton"
        Me.LoginButton.Size = New System.Drawing.Size(103, 43)
        Me.LoginButton.TabIndex = 1
        Me.LoginButton.Text = "Login"
        Me.LoginButton.UseVisualStyleBackColor = False
        '
        'UsernameTextBox
        '
        Me.UsernameTextBox.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.UsernameTextBox.Location = New System.Drawing.Point(654, 94)
        Me.UsernameTextBox.Name = "UsernameTextBox"
        Me.UsernameTextBox.PlaceholderText = "Username"
        Me.UsernameTextBox.Size = New System.Drawing.Size(163, 27)
        Me.UsernameTextBox.TabIndex = 2
        '
        'PasswordTextBox
        '
        Me.PasswordTextBox.Font = New System.Drawing.Font("Segoe UI Variable Display Semib", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.PasswordTextBox.Location = New System.Drawing.Point(654, 138)
        Me.PasswordTextBox.Name = "PasswordTextBox"
        Me.PasswordTextBox.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.PasswordTextBox.PlaceholderText = "Password"
        Me.PasswordTextBox.Size = New System.Drawing.Size(163, 27)
        Me.PasswordTextBox.TabIndex = 3
        '
        'CancelFormButton
        '
        Me.CancelFormButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.CancelFormButton.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CancelFormButton.Location = New System.Drawing.Point(819, 232)
        Me.CancelFormButton.Name = "CancelFormButton"
        Me.CancelFormButton.Size = New System.Drawing.Size(94, 43)
        Me.CancelFormButton.TabIndex = 4
        Me.CancelFormButton.Text = "Cancel"
        Me.CancelFormButton.UseVisualStyleBackColor = False
        '
        'ResetButton
        '
        Me.ResetButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.ResetButton.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ResetButton.Location = New System.Drawing.Point(688, 232)
        Me.ResetButton.Name = "ResetButton"
        Me.ResetButton.Size = New System.Drawing.Size(94, 43)
        Me.ResetButton.TabIndex = 5
        Me.ResetButton.Text = "Reset"
        Me.ResetButton.UseVisualStyleBackColor = False
        '
        'CustomerLoginCheckBox
        '
        Me.CustomerLoginCheckBox.AutoSize = True
        Me.CustomerLoginCheckBox.BackColor = System.Drawing.SystemColors.GradientActiveCaption
        Me.CustomerLoginCheckBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.CustomerLoginCheckBox.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CustomerLoginCheckBox.FlatAppearance.BorderColor = System.Drawing.Color.Blue
        Me.CustomerLoginCheckBox.Font = New System.Drawing.Font("Segoe UI Variable Small Semibol", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CustomerLoginCheckBox.Location = New System.Drawing.Point(654, 309)
        Me.CustomerLoginCheckBox.Name = "CustomerLoginCheckBox"
        Me.CustomerLoginCheckBox.Size = New System.Drawing.Size(161, 26)
        Me.CustomerLoginCheckBox.TabIndex = 7
        Me.CustomerLoginCheckBox.Text = "Customer Login"
        Me.CustomerLoginCheckBox.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Franklin Gothic Medium", 18.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(228, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(511, 38)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "APARTMENT MANAGEMENT SYSTEM"
        '
        'AdminLoginForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ApartmentManagementSystem.My.Resources.Resources.WhatsApp_Image_2023_02_23_at_10_33_49
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(961, 502)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CustomerLoginCheckBox)
        Me.Controls.Add(Me.ResetButton)
        Me.Controls.Add(Me.CancelFormButton)
        Me.Controls.Add(Me.PasswordTextBox)
        Me.Controls.Add(Me.UsernameTextBox)
        Me.Controls.Add(Me.LoginButton)
        Me.Controls.Add(Me.ShowPasswordCheckBox)
        Me.Name = "AdminLoginForm"
        Me.Text = "AdminLoginForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ShowPasswordCheckBox As CheckBox
    Friend WithEvents LoginButton As Button
    Friend WithEvents UsernameTextBox As TextBox
    Friend WithEvents PasswordTextBox As TextBox
    Friend WithEvents CancelFormButton As Button
    Friend WithEvents ResetButton As Button
    Friend WithEvents CustomerLoginCheckBox As CheckBox
    Friend WithEvents Label1 As Label
End Class
