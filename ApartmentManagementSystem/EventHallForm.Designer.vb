<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EventHallForm
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
        Me.AddBookingLabel = New System.Windows.Forms.Label()
        Me.EventDatePicker = New System.Windows.Forms.DateTimePicker()
        Me.AddEventButton = New System.Windows.Forms.Button()
        Me.HallNumberListBox = New System.Windows.Forms.ListBox()
        Me.SuspendLayout()
        '
        'AddBookingLabel
        '
        Me.AddBookingLabel.AutoSize = True
        Me.AddBookingLabel.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.AddBookingLabel.Location = New System.Drawing.Point(342, 144)
        Me.AddBookingLabel.Name = "AddBookingLabel"
        Me.AddBookingLabel.Size = New System.Drawing.Size(142, 20)
        Me.AddBookingLabel.TabIndex = 2
        Me.AddBookingLabel.Text = "Add a booking date"
        '
        'EventDatePicker
        '
        Me.EventDatePicker.CalendarMonthBackground = System.Drawing.SystemColors.InactiveCaption
        Me.EventDatePicker.CalendarTrailingForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.EventDatePicker.Location = New System.Drawing.Point(342, 177)
        Me.EventDatePicker.Name = "EventDatePicker"
        Me.EventDatePicker.Size = New System.Drawing.Size(258, 27)
        Me.EventDatePicker.TabIndex = 1
        '
        'AddEventButton
        '
        Me.AddEventButton.BackColor = System.Drawing.SystemColors.ButtonShadow
        Me.AddEventButton.Location = New System.Drawing.Point(398, 289)
        Me.AddEventButton.Name = "AddEventButton"
        Me.AddEventButton.Size = New System.Drawing.Size(112, 38)
        Me.AddEventButton.TabIndex = 2
        Me.AddEventButton.Text = "Add"
        Me.AddEventButton.UseVisualStyleBackColor = False
        '
        'HallNumberListBox
        '
        Me.HallNumberListBox.FormattingEnabled = True
        Me.HallNumberListBox.ItemHeight = 20
        Me.HallNumberListBox.Items.AddRange(New Object() {"1", "2"})
        Me.HallNumberListBox.Location = New System.Drawing.Point(360, 239)
        Me.HallNumberListBox.Name = "HallNumberListBox"
        Me.HallNumberListBox.Size = New System.Drawing.Size(150, 24)
        Me.HallNumberListBox.TabIndex = 3
        '
        'EventHallForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ApartmentManagementSystem.My.Resources.Resources.hall
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(899, 489)
        Me.Controls.Add(Me.HallNumberListBox)
        Me.Controls.Add(Me.AddEventButton)
        Me.Controls.Add(Me.EventDatePicker)
        Me.Controls.Add(Me.AddBookingLabel)
        Me.Name = "EventHallForm"
        Me.Text = "EventHallForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AddBookingLabel As Label
    Friend WithEvents EventDatePicker As DateTimePicker
    Friend WithEvents AddEventButton As Button
    Friend WithEvents HallNumberListBox As ListBox
End Class
