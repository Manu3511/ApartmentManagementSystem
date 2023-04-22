Imports System.Data.SqlClient

Public Class Rooms
    Private Sub RoomNumber101Button_Click(sender As Object, e As EventArgs) Handles RoomNumber101Button.Click
        Dim editForm As New RoomEditForm(101, connectionString)
        'Show the edit form
        editForm.ShowDialog()
    End Sub

    Private Sub RoomNumber102Button_Click(sender As Object, e As EventArgs) Handles RoomNumber102Button.Click
        Dim editForm As New RoomEditForm(102, connectionString)
        editForm.ShowDialog()
    End Sub

    Private Sub RoomNumber103Button_Click(sender As Object, e As EventArgs) Handles RoomNumber103Button.Click
        Dim editForm As New RoomEditForm(103, connectionString)
        editForm.ShowDialog()
    End Sub

    Private Sub RoomNumber104Button_Click(sender As Object, e As EventArgs) Handles RoomNumber104Button.Click
        Dim editForm As New RoomEditForm(104, connectionString)
        editForm.ShowDialog()
    End Sub

    Private Sub RoomNumber105Button_Click(sender As Object, e As EventArgs) Handles RoomNumber105Button.Click
        Dim editForm As New RoomEditForm(105, connectionString)
        'Show the edit form
        editForm.ShowDialog()
    End Sub

    Private Sub RoomNumber201Button_Click(sender As Object, e As EventArgs)
        Dim editForm As New RoomEditForm(201, connectionString)
        'Show the edit form
        editForm.ShowDialog()
    End Sub

    Private Sub RoomNumber202Button_Click(sender As Object, e As EventArgs)
        Dim editForm As New RoomEditForm(202, connectionString)
        'Show the edit form
        editForm.ShowDialog()
    End Sub

    Private Sub RoomNumber203Button_Click(sender As Object, e As EventArgs)
        Dim editForm As New RoomEditForm(203, connectionString)
        'Show the edit form
        editForm.ShowDialog()
    End Sub

    Private Sub RoomNumber204Button_Click(sender As Object, e As EventArgs)
        Dim editForm As New RoomEditForm(204, connectionString)
        'Show the edit form
        editForm.ShowDialog()
    End Sub

    Private Sub RoomNumber205Button_Click(sender As Object, e As EventArgs)
        Dim editForm As New RoomEditForm(205, connectionString)
        'Show the edit form
        editForm.ShowDialog()
    End Sub

    Private Sub RoomNumber301Button_Click(sender As Object, e As EventArgs)
        Dim editForm As New RoomEditForm(301, connectionString)
        'Show the edit form
        editForm.ShowDialog()
    End Sub

    Private Sub RoomNumber302Button_Click(sender As Object, e As EventArgs)
        Dim editForm As New RoomEditForm(302, connectionString)
        'Show the edit form
        editForm.ShowDialog()
    End Sub

    Private Sub RoomNumber303Button_Click(sender As Object, e As EventArgs)
        Dim editForm As New RoomEditForm(303, connectionString)
        'Show the edit form
        editForm.ShowDialog()
    End Sub

    Private Sub RoomNumber304Button_Click(sender As Object, e As EventArgs)
        Dim editForm As New RoomEditForm(304, connectionString)
        'Show the edit form
        editForm.ShowDialog()
    End Sub

    Private Sub RoomNumber305Button_Click(sender As Object, e As EventArgs)
        Dim editForm As New RoomEditForm(305, connectionString)
        'Show the edit form
        editForm.ShowDialog()
    End Sub

    Private Sub Rooms_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim query As String = "SELECT ROOM_NO, IS_OCCUPIED FROM ROOM_DETAILS"
        Using connection As New SqlConnection(connectionString)
            Using command As New SqlCommand(query, connection)
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()
                While reader.Read()
                    Dim occupied As Boolean = CBool(reader("IS_OCCUPIED"))
                    Dim roomNo As Integer = CInt(reader("ROOM_NO"))
                    For Each ctrl As Control In Me.Controls
                        If TypeOf ctrl Is Button AndAlso ctrl.Text = roomNo Then
                            If occupied = True Then
                                ctrl.BackColor = Color.Green
                                Exit For
                            Else
                                ctrl.BackColor = Color.Red
                                Exit For
                            End If
                        End If
                    Next
                End While
            End Using
        End Using
    End Sub
End Class