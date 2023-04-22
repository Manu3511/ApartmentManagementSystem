<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomerEditForm
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
        Me.RoomNoLabel = New System.Windows.Forms.Label()
        Me.FNameTextBox = New System.Windows.Forms.TextBox()
        Me.LNameTextBox = New System.Windows.Forms.TextBox()
        Me.OccupationTextBox = New System.Windows.Forms.TextBox()
        Me.PhoneTextBox = New System.Windows.Forms.TextBox()
        Me.AadharTextBox = New System.Windows.Forms.TextBox()
        Me.AddressTextBox = New System.Windows.Forms.TextBox()
        Me.OkButton = New System.Windows.Forms.Button()
        Me.EditCheckBox = New System.Windows.Forms.CheckBox()
        Me.DOBPicker = New System.Windows.Forms.DateTimePicker()
        Me.AgeTextBox = New System.Windows.Forms.TextBox()
        Me.EditCustomerCheckBox = New System.Windows.Forms.CheckBox()
        Me.SuspendLayout()
        '
        'RoomNoLabel
        '
        Me.RoomNoLabel.AutoSize = True
        Me.RoomNoLabel.Location = New System.Drawing.Point(351, 27)
        Me.RoomNoLabel.Name = "RoomNoLabel"
        Me.RoomNoLabel.Size = New System.Drawing.Size(53, 20)
        Me.RoomNoLabel.TabIndex = 0
        Me.RoomNoLabel.Text = "Label1"
        '
        'FNameTextBox
        '
        Me.FNameTextBox.Location = New System.Drawing.Point(47, 79)
        Me.FNameTextBox.Name = "FNameTextBox"
        Me.FNameTextBox.PlaceholderText = "First Name"
        Me.FNameTextBox.ReadOnly = True
        Me.FNameTextBox.Size = New System.Drawing.Size(258, 27)
        Me.FNameTextBox.TabIndex = 1
        '
        'LNameTextBox
        '
        Me.LNameTextBox.Location = New System.Drawing.Point(361, 79)
        Me.LNameTextBox.Name = "LNameTextBox"
        Me.LNameTextBox.PlaceholderText = "Last Name"
        Me.LNameTextBox.ReadOnly = True
        Me.LNameTextBox.Size = New System.Drawing.Size(258, 27)
        Me.LNameTextBox.TabIndex = 2
        '
        'OccupationTextBox
        '
        Me.OccupationTextBox.Location = New System.Drawing.Point(47, 168)
        Me.OccupationTextBox.Name = "OccupationTextBox"
        Me.OccupationTextBox.PlaceholderText = "Occupation"
        Me.OccupationTextBox.ReadOnly = True
        Me.OccupationTextBox.Size = New System.Drawing.Size(258, 27)
        Me.OccupationTextBox.TabIndex = 4
        '
        'PhoneTextBox
        '
        Me.PhoneTextBox.Location = New System.Drawing.Point(47, 220)
        Me.PhoneTextBox.Name = "PhoneTextBox"
        Me.PhoneTextBox.PlaceholderText = "Phone Number"
        Me.PhoneTextBox.ReadOnly = True
        Me.PhoneTextBox.Size = New System.Drawing.Size(258, 27)
        Me.PhoneTextBox.TabIndex = 5
        '
        'AadharTextBox
        '
        Me.AadharTextBox.Location = New System.Drawing.Point(47, 272)
        Me.AadharTextBox.Name = "AadharTextBox"
        Me.AadharTextBox.PlaceholderText = "Aadhar Number"
        Me.AadharTextBox.ReadOnly = True
        Me.AadharTextBox.Size = New System.Drawing.Size(258, 27)
        Me.AadharTextBox.TabIndex = 6
        '
        'AddressTextBox
        '
        Me.AddressTextBox.Location = New System.Drawing.Point(361, 168)
        Me.AddressTextBox.Multiline = True
        Me.AddressTextBox.Name = "AddressTextBox"
        Me.AddressTextBox.PlaceholderText = "Permanent Address"
        Me.AddressTextBox.ReadOnly = True
        Me.AddressTextBox.Size = New System.Drawing.Size(306, 134)
        Me.AddressTextBox.TabIndex = 7
        '
        'OkButton
        '
        Me.OkButton.Location = New System.Drawing.Point(532, 327)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(100, 41)
        Me.OkButton.TabIndex = 8
        Me.OkButton.Text = "Ok"
        Me.OkButton.UseVisualStyleBackColor = True
        '
        'EditCheckBox
        '
        Me.EditCheckBox.AutoSize = True
        Me.EditCheckBox.Location = New System.Drawing.Point(437, 344)
        Me.EditCheckBox.Name = "EditCheckBox"
        Me.EditCheckBox.Size = New System.Drawing.Size(57, 24)
        Me.EditCheckBox.TabIndex = 9
        Me.EditCheckBox.Text = "Edit"
        Me.EditCheckBox.UseVisualStyleBackColor = True
        Me.EditCheckBox.Visible = False
        '
        'DOBPicker
        '
        Me.DOBPicker.Enabled = False
        Me.DOBPicker.Location = New System.Drawing.Point(47, 123)
        Me.DOBPicker.Name = "DOBPicker"
        Me.DOBPicker.Size = New System.Drawing.Size(258, 27)
        Me.DOBPicker.TabIndex = 10
        '
        'AgeTextBox
        '
        Me.AgeTextBox.Location = New System.Drawing.Point(361, 125)
        Me.AgeTextBox.Name = "AgeTextBox"
        Me.AgeTextBox.PlaceholderText = "Age"
        Me.AgeTextBox.ReadOnly = True
        Me.AgeTextBox.Size = New System.Drawing.Size(258, 27)
        Me.AgeTextBox.TabIndex = 11
        '
        'EditCustomerCheckBox
        '
        Me.EditCustomerCheckBox.AutoSize = True
        Me.EditCustomerCheckBox.Location = New System.Drawing.Point(351, 344)
        Me.EditCustomerCheckBox.Name = "EditCustomerCheckBox"
        Me.EditCustomerCheckBox.Size = New System.Drawing.Size(57, 24)
        Me.EditCustomerCheckBox.TabIndex = 12
        Me.EditCustomerCheckBox.Text = "Edit"
        Me.EditCustomerCheckBox.UseVisualStyleBackColor = True
        '
        'CustomerEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ApartmentManagementSystem.My.Resources.Resources._1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.EditCustomerCheckBox)
        Me.Controls.Add(Me.AgeTextBox)
        Me.Controls.Add(Me.DOBPicker)
        Me.Controls.Add(Me.EditCheckBox)
        Me.Controls.Add(Me.OkButton)
        Me.Controls.Add(Me.AddressTextBox)
        Me.Controls.Add(Me.AadharTextBox)
        Me.Controls.Add(Me.PhoneTextBox)
        Me.Controls.Add(Me.OccupationTextBox)
        Me.Controls.Add(Me.LNameTextBox)
        Me.Controls.Add(Me.FNameTextBox)
        Me.Controls.Add(Me.RoomNoLabel)
        Me.Name = "CustomerEditForm"
        Me.Text = "CustomerEditForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RoomNoLabel As Label
    Friend WithEvents FNameTextBox As TextBox
    Friend WithEvents LNameTextBox As TextBox
    Friend WithEvents OccupationTextBox As TextBox
    Friend WithEvents PhoneTextBox As TextBox
    Friend WithEvents AadharTextBox As TextBox
    Friend WithEvents AddressTextBox As TextBox
    Friend WithEvents OkButton As Button
    Friend WithEvents EditCheckBox As CheckBox
    Friend WithEvents DOBPicker As DateTimePicker
    Friend WithEvents AgeTextBox As TextBox
    Friend WithEvents EditCustomerCheckBox As CheckBox
End Class
