<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NoticeForm
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
        Me.NoticeMessageTextBox = New System.Windows.Forms.TextBox()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.NoticeDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.DeleteAllButton = New System.Windows.Forms.Button()
        Me.NoticeIDComboBox = New System.Windows.Forms.ComboBox()
        Me.LoadButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'NoticeMessageTextBox
        '
        Me.NoticeMessageTextBox.Location = New System.Drawing.Point(430, 88)
        Me.NoticeMessageTextBox.Multiline = True
        Me.NoticeMessageTextBox.Name = "NoticeMessageTextBox"
        Me.NoticeMessageTextBox.Size = New System.Drawing.Size(290, 189)
        Me.NoticeMessageTextBox.TabIndex = 0
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(458, 380)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(94, 29)
        Me.AddButton.TabIndex = 1
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'NoticeDatePicker
        '
        Me.NoticeDatePicker.Location = New System.Drawing.Point(140, 250)
        Me.NoticeDatePicker.Name = "NoticeDatePicker"
        Me.NoticeDatePicker.Size = New System.Drawing.Size(162, 27)
        Me.NoticeDatePicker.TabIndex = 2
        '
        'DeleteAllButton
        '
        Me.DeleteAllButton.Location = New System.Drawing.Point(626, 380)
        Me.DeleteAllButton.Name = "DeleteAllButton"
        Me.DeleteAllButton.Size = New System.Drawing.Size(94, 29)
        Me.DeleteAllButton.TabIndex = 3
        Me.DeleteAllButton.Text = "Delete"
        Me.DeleteAllButton.UseVisualStyleBackColor = True
        '
        'NoticeIDComboBox
        '
        Me.NoticeIDComboBox.FormattingEnabled = True
        Me.NoticeIDComboBox.Location = New System.Drawing.Point(140, 99)
        Me.NoticeIDComboBox.Name = "NoticeIDComboBox"
        Me.NoticeIDComboBox.Size = New System.Drawing.Size(151, 28)
        Me.NoticeIDComboBox.TabIndex = 4
        '
        'LoadButton
        '
        Me.LoadButton.Location = New System.Drawing.Point(168, 171)
        Me.LoadButton.Name = "LoadButton"
        Me.LoadButton.Size = New System.Drawing.Size(94, 29)
        Me.LoadButton.TabIndex = 5
        Me.LoadButton.Text = "Load"
        Me.LoadButton.UseVisualStyleBackColor = True
        '
        'NoticeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ApartmentManagementSystem.My.Resources.Resources._6_eOu3qheXC_transformed1
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.LoadButton)
        Me.Controls.Add(Me.NoticeIDComboBox)
        Me.Controls.Add(Me.DeleteAllButton)
        Me.Controls.Add(Me.NoticeDatePicker)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.NoticeMessageTextBox)
        Me.Name = "NoticeForm"
        Me.Text = "+--------------------------------------------------------------------------------" &
    "-------------------------------------"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents NoticeMessageTextBox As TextBox
    Friend WithEvents AddButton As Button
    Friend WithEvents NoticeDatePicker As DateTimePicker
    Friend WithEvents DeleteAllButton As Button
    Friend WithEvents NoticeIDComboBox As ComboBox
    Friend WithEvents LoadButton As Button
End Class
