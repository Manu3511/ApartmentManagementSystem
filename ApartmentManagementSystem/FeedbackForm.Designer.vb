<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FeedbackForm
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
        Me.FeedbackTextBox = New System.Windows.Forms.TextBox()
        Me.AddButton = New System.Windows.Forms.Button()
        Me.ViewButton = New System.Windows.Forms.Button()
        Me.RoomNumberComboBox = New System.Windows.Forms.ComboBox()
        Me.DeleteAllButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FeedbackTextBox
        '
        Me.FeedbackTextBox.Location = New System.Drawing.Point(209, 76)
        Me.FeedbackTextBox.Multiline = True
        Me.FeedbackTextBox.Name = "FeedbackTextBox"
        Me.FeedbackTextBox.Size = New System.Drawing.Size(299, 202)
        Me.FeedbackTextBox.TabIndex = 0
        '
        'AddButton
        '
        Me.AddButton.Location = New System.Drawing.Point(307, 319)
        Me.AddButton.Name = "AddButton"
        Me.AddButton.Size = New System.Drawing.Size(110, 45)
        Me.AddButton.TabIndex = 1
        Me.AddButton.Text = "Add"
        Me.AddButton.UseVisualStyleBackColor = True
        '
        'ViewButton
        '
        Me.ViewButton.Location = New System.Drawing.Point(307, 393)
        Me.ViewButton.Name = "ViewButton"
        Me.ViewButton.Size = New System.Drawing.Size(110, 45)
        Me.ViewButton.TabIndex = 3
        Me.ViewButton.Text = "View"
        Me.ViewButton.UseVisualStyleBackColor = True
        '
        'RoomNumberComboBox
        '
        Me.RoomNumberComboBox.FormattingEnabled = True
        Me.RoomNumberComboBox.Location = New System.Drawing.Point(278, 12)
        Me.RoomNumberComboBox.Name = "RoomNumberComboBox"
        Me.RoomNumberComboBox.Size = New System.Drawing.Size(151, 28)
        Me.RoomNumberComboBox.TabIndex = 4
        '
        'DeleteAllButton
        '
        Me.DeleteAllButton.Location = New System.Drawing.Point(571, 255)
        Me.DeleteAllButton.Name = "DeleteAllButton"
        Me.DeleteAllButton.Size = New System.Drawing.Size(94, 29)
        Me.DeleteAllButton.TabIndex = 5
        Me.DeleteAllButton.Text = "Delete"
        Me.DeleteAllButton.UseVisualStyleBackColor = True
        '
        'FeedbackForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ApartmentManagementSystem.My.Resources.Resources._11
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DeleteAllButton)
        Me.Controls.Add(Me.RoomNumberComboBox)
        Me.Controls.Add(Me.ViewButton)
        Me.Controls.Add(Me.AddButton)
        Me.Controls.Add(Me.FeedbackTextBox)
        Me.Name = "FeedbackForm"
        Me.Text = "FeedbackForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents FeedbackTextBox As TextBox
    Friend WithEvents AddButton As Button
    Friend WithEvents ViewButton As Button
    Friend WithEvents RoomNumberComboBox As ComboBox
    Friend WithEvents DeleteAllButton As Button
End Class
