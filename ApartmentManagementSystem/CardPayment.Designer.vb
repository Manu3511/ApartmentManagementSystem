<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CardPayment
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
        Me.components = New System.ComponentModel.Container()
        Me.OkButton = New System.Windows.Forms.Button()
        Me.CardNumberTextBox = New System.Windows.Forms.TextBox()
        Me.FullNameTextBox = New System.Windows.Forms.TextBox()
        Me.CVVTextbox = New System.Windows.Forms.TextBox()
        Me.DateTextBox = New System.Windows.Forms.TextBox()
        Me.MonthTextBox = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DelayTimer = New System.Windows.Forms.Timer(Me.components)
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'OkButton
        '
        Me.OkButton.Location = New System.Drawing.Point(343, 299)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(105, 48)
        Me.OkButton.TabIndex = 0
        Me.OkButton.Text = "OK"
        Me.OkButton.UseVisualStyleBackColor = True
        '
        'CardNumberTextBox
        '
        Me.CardNumberTextBox.Location = New System.Drawing.Point(372, 80)
        Me.CardNumberTextBox.Name = "CardNumberTextBox"
        Me.CardNumberTextBox.Size = New System.Drawing.Size(176, 27)
        Me.CardNumberTextBox.TabIndex = 1
        '
        'FullNameTextBox
        '
        Me.FullNameTextBox.Location = New System.Drawing.Point(372, 130)
        Me.FullNameTextBox.Name = "FullNameTextBox"
        Me.FullNameTextBox.Size = New System.Drawing.Size(176, 27)
        Me.FullNameTextBox.TabIndex = 2
        '
        'CVVTextbox
        '
        Me.CVVTextbox.Location = New System.Drawing.Point(372, 182)
        Me.CVVTextbox.Name = "CVVTextbox"
        Me.CVVTextbox.Size = New System.Drawing.Size(67, 27)
        Me.CVVTextbox.TabIndex = 3
        Me.CVVTextbox.UseSystemPasswordChar = True
        '
        'DateTextBox
        '
        Me.DateTextBox.Location = New System.Drawing.Point(372, 229)
        Me.DateTextBox.Name = "DateTextBox"
        Me.DateTextBox.Size = New System.Drawing.Size(34, 27)
        Me.DateTextBox.TabIndex = 4
        '
        'MonthTextBox
        '
        Me.MonthTextBox.Location = New System.Drawing.Point(441, 229)
        Me.MonthTextBox.Name = "MonthTextBox"
        Me.MonthTextBox.Size = New System.Drawing.Size(34, 27)
        Me.MonthTextBox.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 13.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(412, 229)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(23, 31)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "/"
        '
        'DelayTimer
        '
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(237, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(98, 20)
        Me.Label2.TabIndex = 8
        Me.Label2.Text = "Card Number"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(237, 137)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 20)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Card Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(237, 189)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 20)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "CVV"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(237, 236)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(120, 20)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Card Expiry Date"
        '
        'CardPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ApartmentManagementSystem.My.Resources.Resources._2
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.MonthTextBox)
        Me.Controls.Add(Me.DateTextBox)
        Me.Controls.Add(Me.CVVTextbox)
        Me.Controls.Add(Me.FullNameTextBox)
        Me.Controls.Add(Me.CardNumberTextBox)
        Me.Controls.Add(Me.OkButton)
        Me.Name = "CardPayment"
        Me.Text = "CardPayment"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents OkButton As Button
    Friend WithEvents CardNumberTextBox As TextBox
    Friend WithEvents FullNameTextBox As TextBox
    Friend WithEvents CVVTextbox As TextBox
    Friend WithEvents DateTextBox As TextBox
    Friend WithEvents MonthTextBox As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DelayTimer As Timer
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
End Class
