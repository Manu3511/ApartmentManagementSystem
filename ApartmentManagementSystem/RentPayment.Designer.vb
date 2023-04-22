<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RentPayment
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
        Me.RentDataGrid = New System.Windows.Forms.DataGridView()
        Me.PayButton = New System.Windows.Forms.Button()
        Me.OkButton = New System.Windows.Forms.Button()
        CType(Me.RentDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RentDataGrid
        '
        Me.RentDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RentDataGrid.Location = New System.Drawing.Point(220, 67)
        Me.RentDataGrid.Name = "RentDataGrid"
        Me.RentDataGrid.ReadOnly = True
        Me.RentDataGrid.RowHeadersWidth = 51
        Me.RentDataGrid.RowTemplate.Height = 29
        Me.RentDataGrid.Size = New System.Drawing.Size(317, 197)
        Me.RentDataGrid.TabIndex = 0
        '
        'PayButton
        '
        Me.PayButton.Location = New System.Drawing.Point(315, 353)
        Me.PayButton.Name = "PayButton"
        Me.PayButton.Size = New System.Drawing.Size(118, 52)
        Me.PayButton.TabIndex = 1
        Me.PayButton.Text = "Pay"
        Me.PayButton.UseVisualStyleBackColor = True
        '
        'OkButton
        '
        Me.OkButton.Location = New System.Drawing.Point(315, 298)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(118, 49)
        Me.OkButton.TabIndex = 2
        Me.OkButton.Text = "OK"
        Me.OkButton.UseVisualStyleBackColor = True
        '
        'RentPayment
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.ApartmentManagementSystem.My.Resources.Resources._21
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.OkButton)
        Me.Controls.Add(Me.PayButton)
        Me.Controls.Add(Me.RentDataGrid)
        Me.Name = "RentPayment"
        Me.Text = "RentPayment"
        CType(Me.RentDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RentDataGrid As DataGridView
    Friend WithEvents PayButton As Button
    Friend WithEvents OkButton As Button
End Class
