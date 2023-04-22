Imports System.Data.SqlClient

Public Class CustomerEditForm
    Private ReadOnly _roomNumber As Integer
    Private ReadOnly _connectionString As String

    Public Sub New(roomNumber As Integer, connectionString As String)
        InitializeComponent()
        _roomNumber = roomNumber
        _connectionString = connectionString

        If AdminCustomerShare.IsAdmin Then
            EditCheckBox.Visible = True
            EditCustomerCheckBox.Visible = False
        Else
            EditCheckBox.Visible = False
            EditCustomerCheckBox.Visible = True
        End If

        'Load the current details of the selected customer from the database
        Dim query As String = "SELECT * FROM CUSTOMER_DETAILS WHERE ROOM_NO = @RoomNo"
        Using connection As New SqlConnection(_connectionString)
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@RoomNo", _roomNumber)
            connection.Open()
            Dim reader As SqlDataReader = command.ExecuteReader()
            If reader.Read() Then
                RoomNoLabel.Text = _roomNumber
                Try
                    FNameTextBox.Text = CStr(reader("FNAME"))
                    LNameTextBox.Text = CStr(reader("LNAME"))
                    AgeTextBox.Text = CInt(reader("AGE"))
                    DOBPicker.Value = CDate(reader("DOB"))
                    OccupationTextBox.Text = CStr(reader("OCCUPATION"))
                    PhoneTextBox.Text = CLng(reader("PHNO"))
                    AadharTextBox.Text = CLng(reader("AADHAR_NO"))
                    AddressTextBox.Text = CStr(reader("PERMANENT_ADDRESS"))
                    Text = $"{FNameTextBox.Text} {LNameTextBox.Text}"
                Catch ex As Exception
                    If ex.Message.Contains("DBNull") Then
                        FNameTextBox.Text = ""
                        LNameTextBox.Text = ""
                        AgeTextBox.Text = ""
                        DOBPicker.Value = Today()
                        OccupationTextBox.Text = ""
                        PhoneTextBox.Text = ""
                        AadharTextBox.Text = ""
                        AddressTextBox.Text = ""
                        Text = $"Renter for Room No.{_roomNumber}"
                    End If
                End Try
            End If
            reader.Close()
        End Using
    End Sub

    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        'Update the details of the selected room in the database
        Dim query As String = "UPDATE CUSTOMER_DETAILS SET FNAME = @FName, LNAME = @LName, AGE = @Age, DOB = @Dob, OCCUPATION = @Occupation, PHNO = @Phno, AADHAR_NO = @AadharNo, PERMANENT_ADDRESS = @Paddr WHERE ROOM_NO = @RoomNo"
        Using connection As New SqlConnection(_connectionString)
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@FName", FNameTextBox.Text)
            command.Parameters.AddWithValue("@LName", LNameTextBox.Text)
            command.Parameters.AddWithValue("@Age", AgeTextBox.Text)
            command.Parameters.AddWithValue("@Dob", DOBPicker.Value.Date)
            command.Parameters.AddWithValue("@Occupation", OccupationTextBox.Text)
            command.Parameters.AddWithValue("@Phno", PhoneTextBox.Text)
            command.Parameters.AddWithValue("@AadharNo", AadharTextBox.Text)
            command.Parameters.AddWithValue("@Paddr", AddressTextBox.Text)
            command.Parameters.AddWithValue("@RoomNo", _roomNumber)
            connection.Open()
            Try
                command.ExecuteNonQuery()
            Catch ex As SqlException
                If ex.Message.Contains("CHK_AADHAR_NO") Then
                    MessageBox.Show("The Aadhar Number you have entered is invalid. Please try again.")
                    Return
                ElseIf ex.Message.Contains("CHK_PHNO") Then
                    MessageBox.Show("The Phone Number you have entered is invalid. Please try again.")
                    Return
                ElseIf ex.Message.Contains("CHK_AGE") Then
                    MessageBox.Show("The age you have entered does not match with the DOB. Please try again")
                    Return
                End If
            End Try
        End Using

        'Close the edit form
        Close()
    End Sub

    Private Sub EditCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles EditCheckBox.CheckedChanged
        If EditCheckBox.Checked Then
            FNameTextBox.ReadOnly = False
            LNameTextBox.ReadOnly = False
            AgeTextBox.ReadOnly = False
            DOBPicker.Enabled = True
            OccupationTextBox.ReadOnly = False
            PhoneTextBox.ReadOnly = False
            AadharTextBox.ReadOnly = False
            AddressTextBox.ReadOnly = False
        Else
            FNameTextBox.ReadOnly = True
            LNameTextBox.ReadOnly = True
            AgeTextBox.ReadOnly = True
            DOBPicker.Enabled = False
            OccupationTextBox.ReadOnly = True
            PhoneTextBox.ReadOnly = True
            AadharTextBox.ReadOnly = True
            AddressTextBox.ReadOnly = True
        End If
    End Sub

    Private Sub EditCustomerCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles EditCustomerCheckBox.CheckedChanged
        If EditCustomerCheckBox.Checked Then
            OccupationTextBox.ReadOnly = False
            PhoneTextBox.ReadOnly = False
        Else
            OccupationTextBox.ReadOnly = True
            PhoneTextBox.ReadOnly = True
        End If
    End Sub

    Private Sub DOBPicker_ValueChanged(sender As Object, e As EventArgs) Handles DOBPicker.ValueChanged
        AgeTextBox.Text = DateDiff(DateInterval.Year, DOBPicker.Value.Date, Today())
    End Sub
End Class
