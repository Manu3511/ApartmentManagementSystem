<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class MainPageForm
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
        Me.FeePaymentButton = New System.Windows.Forms.Button()
        Me.NoticeButton = New System.Windows.Forms.Button()
        Me.MandFButton = New System.Windows.Forms.Button()
        Me.RoomDetailButton = New System.Windows.Forms.Button()
        Me.CustomerDetailButton = New System.Windows.Forms.Button()
        Me.LaundaryButton = New System.Windows.Forms.Button()
        Me.EventHallButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'FeePaymentButton
        '
        Me.FeePaymentButton.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.FeePaymentButton.Font = New System.Drawing.Font("Segoe UI Variable Display", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.FeePaymentButton.Location = New System.Drawing.Point(554, 42)
        Me.FeePaymentButton.Name = "FeePaymentButton"
        Me.FeePaymentButton.Size = New System.Drawing.Size(119, 90)
        Me.FeePaymentButton.TabIndex = 0
        Me.FeePaymentButton.Text = "Rent Payment"
        Me.FeePaymentButton.UseVisualStyleBackColor = False
        '
        'NoticeButton
        '
        Me.NoticeButton.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.NoticeButton.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.NoticeButton.Location = New System.Drawing.Point(316, 160)
        Me.NoticeButton.Name = "NoticeButton"
        Me.NoticeButton.Size = New System.Drawing.Size(119, 90)
        Me.NoticeButton.TabIndex = 1
        Me.NoticeButton.Text = "Notice"
        Me.NoticeButton.UseVisualStyleBackColor = False
        '
        'MandFButton
        '
        Me.MandFButton.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.MandFButton.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.MandFButton.Location = New System.Drawing.Point(264, 294)
        Me.MandFButton.Name = "MandFButton"
        Me.MandFButton.Size = New System.Drawing.Size(211, 106)
        Me.MandFButton.TabIndex = 2
        Me.MandFButton.Text = "Maintainence and Feedback"
        Me.MandFButton.UseVisualStyleBackColor = False
        '
        'RoomDetailButton
        '
        Me.RoomDetailButton.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.RoomDetailButton.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.RoomDetailButton.Location = New System.Drawing.Point(74, 42)
        Me.RoomDetailButton.Name = "RoomDetailButton"
        Me.RoomDetailButton.Size = New System.Drawing.Size(119, 90)
        Me.RoomDetailButton.TabIndex = 3
        Me.RoomDetailButton.Text = "Room Details"
        Me.RoomDetailButton.UseVisualStyleBackColor = False
        '
        'CustomerDetailButton
        '
        Me.CustomerDetailButton.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.CustomerDetailButton.Font = New System.Drawing.Font("Segoe UI Variable Display", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CustomerDetailButton.Location = New System.Drawing.Point(316, 42)
        Me.CustomerDetailButton.Name = "CustomerDetailButton"
        Me.CustomerDetailButton.Size = New System.Drawing.Size(119, 90)
        Me.CustomerDetailButton.TabIndex = 4
        Me.CustomerDetailButton.Text = "Customer Details"
        Me.CustomerDetailButton.UseVisualStyleBackColor = False
        '
        'LaundaryButton
        '
        Me.LaundaryButton.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.LaundaryButton.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.LaundaryButton.Location = New System.Drawing.Point(554, 160)
        Me.LaundaryButton.Name = "LaundaryButton"
        Me.LaundaryButton.Size = New System.Drawing.Size(119, 90)
        Me.LaundaryButton.TabIndex = 5
        Me.LaundaryButton.Text = "Laundry/ Room service"
        Me.LaundaryButton.UseVisualStyleBackColor = False
        '
        'EventHallButton
        '
        Me.EventHallButton.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.EventHallButton.Font = New System.Drawing.Font("Segoe UI Variable Display", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.EventHallButton.Location = New System.Drawing.Point(74, 160)
        Me.EventHallButton.Name = "EventHallButton"
        Me.EventHallButton.Size = New System.Drawing.Size(119, 90)
        Me.EventHallButton.TabIndex = 6
        Me.EventHallButton.Text = "EventHall Booking"
        Me.EventHallButton.UseVisualStyleBackColor = False
        '
        'MainPageForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ApartmentManagementSystem.My.Resources.Resources.wp2449525
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.EventHallButton)
        Me.Controls.Add(Me.LaundaryButton)
        Me.Controls.Add(Me.CustomerDetailButton)
        Me.Controls.Add(Me.RoomDetailButton)
        Me.Controls.Add(Me.MandFButton)
        Me.Controls.Add(Me.NoticeButton)
        Me.Controls.Add(Me.FeePaymentButton)
        Me.Name = "MainPageForm"
        Me.Text = "MainPageForm"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents FeePaymentButton As Button
    Friend WithEvents NoticeButton As Button
    Friend WithEvents MandFButton As Button
    Friend WithEvents RoomDetailButton As Button
    Friend WithEvents CustomerDetailButton As Button
    Friend WithEvents LaundaryButton As Button
    Friend WithEvents EventHallButton As Button
End Class
