<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RoomService
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
        Me.RoomServiceDataGrid = New System.Windows.Forms.DataGridView()
        Me.OkButton = New System.Windows.Forms.Button()
        CType(Me.RoomServiceDataGrid, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RoomServiceDataGrid
        '
        Me.RoomServiceDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RoomServiceDataGrid.Location = New System.Drawing.Point(39, 29)
        Me.RoomServiceDataGrid.Name = "RoomServiceDataGrid"
        Me.RoomServiceDataGrid.RowHeadersWidth = 51
        Me.RoomServiceDataGrid.RowTemplate.Height = 29
        Me.RoomServiceDataGrid.Size = New System.Drawing.Size(702, 308)
        Me.RoomServiceDataGrid.TabIndex = 0
        '
        'OkButton
        '
        Me.OkButton.Location = New System.Drawing.Point(342, 356)
        Me.OkButton.Name = "OkButton"
        Me.OkButton.Size = New System.Drawing.Size(126, 59)
        Me.OkButton.TabIndex = 1
        Me.OkButton.Text = "OK"
        Me.OkButton.UseVisualStyleBackColor = True
        '
        'RoomService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.OkButton)
        Me.Controls.Add(Me.RoomServiceDataGrid)
        Me.Name = "RoomService"
        Me.Text = "RoomService"
        CType(Me.RoomServiceDataGrid, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RoomServiceDataGrid As DataGridView
    Friend WithEvents OkButton As Button
End Class
