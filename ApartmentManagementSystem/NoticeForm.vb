Imports System.Data.SqlClient

Public Class NoticeForm
    Private Sub NoticeForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not IsAdmin Then
            Me.Controls.Remove(NoticeIDComboBox)
            Me.Controls.Remove(NoticeDatePicker)
            Me.Controls.Remove(AddButton)
            Me.Controls.Remove(DeleteAllButton)
            Me.Controls.Remove(LoadButton)
            NoticeMessageTextBox.Dock = DockStyle.Bottom
            NoticeMessageTextBox.ReadOnly = True
            Dim query As String = "SELECT NOTICE_MESSAGE FROM NOTICE WHERE NOTICE_DATE = @noticeDate"
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@noticeDate", Today)
                    connection.Open()
                    Dim reader As SqlDataReader = command.ExecuteReader()
                    If reader.Read() Then
                        NoticeMessageTextBox.Text = CStr(reader("NOTICE_MESSAGE"))
                    End If
                End Using
            End Using
        Else
            LoadNoticeID()
        End If
    End Sub
    Private Sub NoticeDateValidation(sender As Object, e As EventArgs) Handles NoticeDatePicker.Validating
        If NoticeDatePicker.Value.Date < Today Then
            MessageBox.Show("Enter a valid date.")
            Return
        End If
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click
        Dim query As String = "INSERT INTO NOTICE(NOTICE_DATE, NOTICE_MESSAGE) VALUES (@noticeDate, @noticeMsg)"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@noticeDate", NoticeDatePicker.Value.Date)
                command.Parameters.AddWithValue("@NoticeMsg", NoticeMessageTextBox.Text)
                connection.Open()
                Try
                    command.ExecuteNonQuery()
                Catch ex As Exception
                    If ex.Message.Contains("UNIQUE") Then
                        MessageBox.Show("Notice already exists on that date. Please delete the notice and try again.")
                        Return
                    End If
                End Try
            End Using
        End Using
        MessageBox.Show("Added Notice.")
        LoadNoticeID()
    End Sub

    Private Sub DeleteAllButton_Click(sender As Object, e As EventArgs) Handles DeleteAllButton.Click
        Dim query As String
        If (String.IsNullOrEmpty(NoticeIDComboBox.Text)) Then
            query = "DELETE FROM NOTICE WHERE NOTICE_DATE < convert(date, getdate())"
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
            MessageBox.Show("Deleted all previous notices.")
        Else
            query = "DELETE FROM NOTICE WHERE NOTICE_ID = @noticeID"
            Using connection As New SqlConnection(connectionString)
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@noticeID", NoticeIDComboBox.Text)
                    connection.Open()
                    Try
                        command.ExecuteNonQuery()
                    Catch ex As Exception
                        If ex.Message.Contains("Primary Key") Then
                            MessageBox.Show("Enter valid Notice ID or leave empty to delete all previous notices.")
                            Return
                        End If
                    End Try
                    MessageBox.Show($"Notice ID {NoticeIDComboBox.Text} was deleted.")
                End Using
            End Using
        End If
        LoadNoticeID()
    End Sub

    Private Sub LoadNoticeID()
        Dim query As String = "SELECT NOTICE_ID FROM NOTICE"
        Dim dataTable As New DataTable
        Using connection As New SqlConnection(connectionString)
            connection.Open()
            Using dataAdapter As New SqlDataAdapter(query, connection)
                dataAdapter.Fill(dataTable)
            End Using
        End Using
        With NoticeIDComboBox
            .DataSource = dataTable
            .DisplayMember = "NOTICE_ID"
            .ValueMember = "NOTICE_ID"
        End With
    End Sub

    Private Sub LoadButton_Click(sender As Object, e As EventArgs) Handles LoadButton.Click
        Dim query As String = "SELECT NOTICE_MESSAGE, NOTICE_DATE FROM NOTICE WHERE NOTICE_ID = @noticeID"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@noticeID", NoticeIDComboBox.Text)
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()
                While (reader.Read())
                    NoticeMessageTextBox.Text = CStr(reader("NOTICE_MESSAGE"))
                    NoticeDatePicker.Value = CDate(reader("NOTICE_DATE"))
                End While
            End Using
        End Using
    End Sub
End Class