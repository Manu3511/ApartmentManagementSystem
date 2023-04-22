<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RoomEditForm
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
        Me.IsOccupiedCheckBox = New System.Windows.Forms.CheckBox()
        Me.FurnishingTextBox = New System.Windows.Forms.TextBox()
        Me.HasBalconyCheckBox = New System.Windows.Forms.CheckBox()
        Me.OkButton = New System.Windows.Forms.Button()
        Me.RoomNoLabel = New System.Windows.Forms.Label()
        Me.EditCheckBox = New System.Windows.Forms.CheckBox()
        Me.RentTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'IsOccupiedCheckBox
        '
        Me.IsOccupiedCheckBox.AutoSize = True
        Me.IsOccupiedCheckBox.Enabled = False
        Me.IsOccupiedCheckBox.Location = New System.Drawing.Point(254, 118)
        Me.IsOccupiedCheckBox.Name = "IsOccupiedCheckBox"
        Me.IsOccupiedCheckBox.Size = New System.Drawing.Size(108, 24)
        Me.IsOccupiedCheckBox.TabIndex = 0
        Me.IsOccupiedCheckBox.Text = "Is Occupied"
        Me.IsOccupiedCheckBox.UseVisualStyleBackColor = True
        '
        'FurnishingTextBox
        '
        Me.FurnishingTextBox.Location = New System.Drawing.Point(339, 214)
        Me.FurnishingTextBox.Name = "FurnishingTextBox"
        Me.FurnishingTextBox.PlaceholderText = "Furnishing"
        Me.FurnishingTextBox.ReadOnly = True
        Me.FurnishingTextBox.Size = New System.Drawing.Size(125, 27)
        Me.FurnishingTextBox.TabIndex = 1
        '
        'HasBalconyCheckBox
        '
        Me.HasBalconyCheckBox.AutoSize = True
        Me.HasBalconyCheckBox.Enabled = False
        Me.HasBalconyCheckBox.Location = New System.Drawing.Point(254, 160)
        Me.HasBalconyCheckBox.Name = "HasBalconyCheckBox"
        Me.HasBalconyCheckBox.Size = New System.Drawing.Size(83, 24)
        Me.HasBalconyCheckBox.TabIndex = 2
        Me.HasBalconyCheckBox.Text = "Balcony"
        Me.HasBalconyCheckBox.UseVisualStyleBackColor = True
        '
        'OkButton
        '
        Me.OkButton.Location = New System.Drawing.Point(275, 339)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(106, 40)
        Me.OkButton.TabIndex = 4
        Me.OkButton.Text = "Ok"
        Me.OkButton.UseVisualStyleBackColor = True
        '
        'RoomNoLabel
        '
        Me.RoomNoLabel.AutoSize = True
        Me.RoomNoLabel.Location = New System.Drawing.Point(294, 31)
        Me.RoomNoLabel.Name = "RoomNoLabel"
        Me.RoomNoLabel.Size = New System.Drawing.Size(53, 20)
        Me.RoomNoLabel.TabIndex = 5
        Me.RoomNoLabel.Text = "Label1"
        '
        'EditCheckBox
        '
        Me.EditCheckBox.AutoSize = True
        Me.EditCheckBox.Location = New System.Drawing.Point(12, 277)
        Me.EditCheckBox.Name = "EditCheckBox"
        Me.EditCheckBox.Size = New System.Drawing.Size(57, 24)
        Me.EditCheckBox.TabIndex = 6
        Me.EditCheckBox.Text = "Edit"
        Me.EditCheckBox.UseVisualStyleBackColor = True
        Me.EditCheckBox.Visible = False
        '
        'RentTextBox
        '
        Me.RentTextBox.Location = New System.Drawing.Point(302, 274)
        Me.RentTextBox.Name = "RentTextBox"
        Me.RentTextBox.PlaceholderText = "Rent"
        Me.RentTextBox.ReadOnly = True
        Me.RentTextBox.Size = New System.Drawing.Size(125, 27)
        Me.RentTextBox.TabIndex = 7
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(254, 217)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(79, 20)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Furnishing:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(254, 277)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(42, 20)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Rent:"
        '
        'RoomEditForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ApartmentManagementSystem.My.Resources.Resources.wp24495252
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RentTextBox)
        Me.Controls.Add(Me.EditCheckBox)
        Me.Controls.Add(Me.RoomNoLabel)
        Me.Controls.Add(Me.OkButton)
        Me.Controls.Add(Me.HasBalconyCheckBox)
        Me.Controls.Add(Me.FurnishingTextBox)
        Me.Controls.Add(Me.IsOccupiedCheckBox)
        Me.Name = "RoomEditForm"
        Me.Text = "RoomEditForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IsOccupiedCheckBox As CheckBox
    Friend WithEvents FurnishingTextBox As TextBox
    Friend WithEvents HasBalconyCheckBox As CheckBox
    Friend WithEvents OkButton As Button
    Friend WithEvents RoomNoLabel As Label
    Friend WithEvents EditCheckBox As CheckBox
    Friend WithEvents RentTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
