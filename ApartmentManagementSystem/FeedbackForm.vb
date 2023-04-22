Imports System.Data.SqlClient

Public Class FeedbackForm
    Private Sub FeedbackForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IsAdmin Then
            Me.Controls.Remove(AddButton)
            FeedbackTextBox.ReadOnly = True
            LoadRoomNumber()
        Else
            Me.Controls.Remove(ViewButton)
        End If
    End Sub

    Private Sub ViewButton_Click(sender As Object, e As EventArgs) Handles ViewButton.Click
        Dim query As String = "SELECT FEEDBACK_MESSAGE FROM FEEDBACK_TABLE WHERE FEEDBACK_DATE = @noticeDate AND ROOM_NO = @roomNo"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@noticeDate", Today)
                command.Parameters.AddWithValue("@roomNo", RoomNumberComboBox.Text)
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()
                If reader.Read() Then
                    FeedbackTextBox.Text = CStr(reader("FEEDBACK_MESSAGE"))
                End If
            End Using
        End Using
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim query As String = "INSERT INTO FEEDBACK_TABLE(ROOM_NO, FEEDBACK_DATE, FEEDBACK_MESSAGE) VALUES (@roomNo, @feedbackDate, @feedbackMsg)"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@feedbackDate", Today)
                command.Parameters.AddWithValue("@roomNo", CurrentRoomNumber)
                command.Parameters.AddWithValue("@feedbackMsg", FeedbackTextBox.Text)
                connection.Open()
                command.ExecuteNonQuery()
            End Using
        End Using
    End Sub

    Private Sub DeleteAllButton_Click(sender As Object, e As EventArgs) Handles DeleteAllButton.Click
        Dim query As String
        If (String.IsNullOrEmpty(RoomNumberComboBox.Text)) Then
            query = "DELETE FROM FEEDBACK WHERE FEEDBACK_DATE < getdate()"
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Deleted all previous feedback.")
        Else
            query = "DELETE FROM FEEDBACK_TABLE WHERE ROOM_NO = @roomNo"
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@noticeID", RoomNumberComboBox.Text)
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                    Catch ex As Exception
                        If ex.Message.Contains("UNIQUE") Then
                            MessageBox.Show("Enter valid Room Number or leave empty to delete all previous feedback.")
                            Return
                        End If
                    End Try
                    MessageBox.Show($"Feedback for Room Number {RoomNumberComboBox.Text} was deleted.")
                End Using
            End Using
        End If
        LoadRoomNumber()
    End Sub

    Private Sub LoadRoomNumber()
        Dim query As String = "SELECT ROOM_NO FROM FEEDBACK_TABLE WHERE FEEDBACK_DATE = @fdate"
        Dim dataTable As New DataTable
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Using dataAdapter As New SqlDataAdapter(query, connection)
                dataAdapter.SelectCommand.Parameters.AddWithValue("@fdate", Today)
                dataAdapter.Fill(dataTable)
            End Using
        End Using
        With RoomNumberComboBox
            .DataSource = dataTable
            .DisplayMember = "ROOM_NO"
            .ValueMember = "ROOM_NO"
        End With
    End Sub
End Class