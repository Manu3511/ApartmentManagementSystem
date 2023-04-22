Imports System.Data.SqlClient

Public Class RoomEditForm
    Private ReadOnly _roomNumber As Integer
    Private ReadOnly _connectionString As String

    Public Sub New(roomNumber As Integer, connectionString As String)
        InitializeComponent()
        _roomNumber = roomNumber
        _connectionString = connectionString

        If AdminCustomerShare.IsAdmin Then
            EditCheckBox.Visible = True
        Else
            EditCheckBox.Visible = False
        End If

        'Load the current details of the selected room from the database
        Dim query As String = "SELECT * FROM ROOM_DETAILS WHERE ROOM_NO = @RoomNo"
        Using connection As New SqlConnection(_connectionString)
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@RoomNo", _roomNumber)
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.Read() Then
                RoomNoLabel.Text = $"Room No {_roomNumber}"
                IsOccupiedCheckBox.Checked = CBool(reader("IS_OCCUPIED"))
                FurnishingTextBox.Text = CStr(reader("FURNISHING"))
                HasBalconyCheckBox.Checked = CBool(reader("HAS_BALCONY"))
                RentTextBox.Text = CInt(reader("RENT"))
            End If
            reader.Close()
        End Using
    End Sub

    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        'Update the details of the selected room in the database
        Dim query As String = "UPDATE ROOM_DETAILS SET IS_OCCUPIED = @IsOccupied, FURNISHING = @Furnishing, HAS_BALCONY = @HasBalcony, RENT = @Rent WHERE ROOM_NO = @RoomNo"
        Using connection As New SqlConnection(_connectionString)
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@IsOccupied", IsOccupiedCheckBox.Checked)
            command.Parameters.AddWithValue("@Furnishing", FurnishingTextBox.Text)
            command.Parameters.AddWithValue("@HasBalcony", HasBalconyCheckBox.Checked)
            command.Parameters.AddWithValue("@Rent", RentTextBox.Text)
            command.Parameters.AddWithValue("@RoomNo", _roomNumber)
            connection.Open()
            command.ExecuteNonQuery()
        End Using

        'Close the edit form
        Close()
    End Sub

    Private Sub EditCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles EditCheckBox.CheckedChanged
        If EditCheckBox.Checked Then
            IsOccupiedCheckBox.Enabled = True
            HasBalconyCheckBox.Enabled = True
            FurnishingTextBox.ReadOnly = False
            RentTextBox.ReadOnly = False
        Else
            IsOccupiedCheckBox.Enabled = False
            HasBalconyCheckBox.Enabled = False
            FurnishingTextBox.ReadOnly = True
            RentTextBox.ReadOnly = True
        End If
    End Sub

    Private Sub IsOccupiedCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles IsOccupiedCheckBox.CheckedChanged
        If Not IsOccupiedCheckBox.Checked Then
            Dim result As DialogResult = MessageBox.Show("Are you sure you want to vacate this room?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning)
            If result = DialogResult.Yes Then
                Using connection As New SqlConnection(_connectionString)
                    Dim query As String = "DELETE FROM CUSTOMER_DETAILS WHERE ROOM_NO = @roomNo"
                    Using command As New SqlCommand(query, connection)
                        command.Parameters.AddWithValue("@roomNo", _roomNumber)
                        connection.Open()
                        command.ExecuteNonQuery()
                        MessageBox.Show("The Room has been vacated.")
                    End Using
                End Using
            Else
                IsOccupiedCheckBox.Checked = Not IsOccupiedCheckBox.Checked
            End If
        End If
    End Sub
End Class
