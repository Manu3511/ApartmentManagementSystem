Imports System.Data.Common
Imports System.Data.SqlClient

Public Class EventHallForm

    Private WithEvents EventGridView As New DataGridView()
    Private Sub EventHallForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If AdminCustomerShare.IsAdmin Then
            For Each ctrl As Control In Me.Controls
                ctrl.Visible = False
            Next
            Dim query As String = "SELECT * FROM EVENT_BOOKING"
            Dim connectionString As String = "Data Source=HPLAP12\SQLEXPRESS;Initial Catalog=APR;Integrated Security=True"
            Dim dataTable As New DataTable()

            Using connection As New SqlConnection(connectionString)
                Dim command As New SqlCommand(query, connection)
                Dim dataAdapter As New SqlDataAdapter(command)
                dataAdapter.Fill(dataTable)
            End Using

            With EventGridView
                .DataSource = dataTable
                .Dock = DockStyle.Fill
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
            End With
            Controls.Add(EventGridView)

        End If
    End Sub

    Private Sub AddEventButton_Click(sender As Object, e As EventArgs) Handles AddEventButton.Click
        If HallNumberListBox.SelectedItem <> Nothing Then
            Dim query As String = "INSERT INTO EVENT_BOOKING(ROOM_NO, EVENT_DATE, HALL_NUMBER) VALUES (@roomNo, @eventDate, @hallNumber)"
            Dim connectionString As String = "Data Source=HPLAP12\SQLEXPRESS;Initial Catalog=APR;Integrated Security=True"
            Using connection As New SqlConnection(connectionString)
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@roomNo", AdminCustomerShare.CurrentRoomNumber)
                command.Parameters.AddWithValue("@eventDate", EventDatePicker.Value.Date)
                command.Parameters.AddWithValue("@hallNumber", HallNumberListBox.SelectedItem.ToString())
                connection.Open()
                Try
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    If ex.Message.Contains("UNIQUE") Then
                        MessageBox.Show("The day you have selected is already booked. Please try for another date.")
                        Return
                    End If
                End Try
            End Using
            MessageBox.Show($"Hall has been booked for {EventDatePicker.Value.Date}")
            Close()
        Else
            MessageBox.Show("Select the Hall Number.")
            Return
        End If
    End Sub

    Private Sub EventDateValidation(sender As Object, e As EventArgs) Handles EventDatePicker.Validating
        If EventDatePicker.Value.Date < Today Then
            MessageBox.Show("Enter a valid date.")
            Return
        ElseIf (EventDatePicker.Value.Date.Month - Today.Month) > 2 Then
            MessageBox.Show("Booking is available only before two months.")
            Return
        End If
    End Sub

    Private Sub EventGridView_Update(sender As Object, e As EventArgs) Handles Me.FormClosing
        If IsAdmin Then
            Try
                Dim changes As DataTable = CType(EventGridView.DataSource, DataTable).GetChanges()

                ' Create a new DataAdapter to update the changes to the database
                Using connection As New SqlConnection(connectionString)
                    Dim adapter As New SqlDataAdapter("SELECT * FROM EVENT_BOOKING", connection)
                    Dim builder As New SqlCommandBuilder(adapter)

                    ' Update the database with the changes made to the DataTable
                    adapter.UpdateCommand = builder.GetUpdateCommand()
                    adapter.InsertCommand = builder.GetInsertCommand()
                    adapter.DeleteCommand = builder.GetDeleteCommand()
                    adapter.Update(changes)

                    ' Update the original DataTable with the changes from the database
                    CType(EventGridView.DataSource, DataTable).AcceptChanges()
                End Using
            Catch ex As ArgumentNullException
                If ex.Message.Contains("Value cannot be null") Then
                    RemoveHandler Me.FormClosing, AddressOf EventGridView_Update
                    Close()
                    Return
                End If
            End Try
        End If
        RemoveHandler Me.FormClosing, AddressOf EventGridView_Update
    End Sub

End Class