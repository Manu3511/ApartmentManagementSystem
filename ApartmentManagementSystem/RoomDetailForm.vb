Imports System.Data.SqlClient
Public Class RoomDetailForm
    Private Sub RoomDetailForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String
        Dim connectionString As String = "Data Source=HPLAP12\SQLEXPRESS;Initial Catalog=APR;Integrated Security=True"
        Dim connection As New SqlConnection(connectionString)
        connection.Open()
        If AdminCustomerShare.IsAdmin Then
            'Query the ROOM_DETAILS
            query = "SELECT ROOM_NO FROM ROOM_DETAILS"
            Dim command As New SqlCommand(query, connection)
            Dim reader As SqlDataReader = command.ExecuteReader()

            'Loop through the list of rooms and create a button for each one
            While reader.Read()
                Dim roomNumber As Integer = CInt(reader("ROOM_NO"))

                'Create a new button for the room
                Dim roomButton As New Button With {
                    .Text = "Room " & roomNumber.ToString(),
                    .Name = "RoomButton" & roomNumber.ToString(),
                    .Size = New Size(100, 50),
                    .Location = New Point(50, (roomNumber - 101) * 60 + 50)
                }

                'Add a click event handler to the button
                AddHandler roomButton.Click, AddressOf RoomButton_Click

                'Add the button to the form
                Me.Controls.Add(roomButton)
            End While

            'Close the database connection
            reader.Close()
            connection.Close()

        Else
            'Query the ROOM_DETAILS
            query = "SELECT ROOM_NO FROM ROOM_DETAILS WHERE ROOM_NO = @roomNo"
            Dim command As New SqlCommand(query, connection)
            command.Parameters.AddWithValue("@roomNo", AdminCustomerShare.CurrentRoomNumber)
            Dim reader As SqlDataReader = command.ExecuteReader()

            'Loop through the list of rooms and create a button for each one
            While reader.Read()
                Dim roomNumber As Integer = CInt(reader("ROOM_NO"))

                'Create a new button for the room
                Dim roomButton As New Button With {
                    .Text = "Room " & roomNumber.ToString(),
                    .Name = "RoomButton" & roomNumber.ToString(),
                    .Size = New Size(100, 50),
                    .Location = New Point(50, (roomNumber - 101) * 60 + 50)
                }

                'Add a click event handler to the button
                AddHandler roomButton.Click, AddressOf RoomButton_Click

                'Add the button to the form
                Me.Controls.Add(roomButton)
            End While

            'Close the database connection
            reader.Close()
            connection.Close()
        End If


    End Sub

    Private Sub RoomButton_Click(sender As Object, e As EventArgs)

    End Sub





End Class
