Imports System.Data.SqlClient

Public Class CustomerSelection
    Private Sub R101_Click(sender As Object, e As EventArgs) Handles R101.Click
        Dim editForm As New CustomerEditForm(101, connectionString)
        editForm.Show()
    End Sub

    Private Sub R102_Click(sender As Object, e As EventArgs) Handles R102.Click
        Dim editForm As New CustomerEditForm(102, connectionString)
        editForm.Show()
    End Sub

    Private Sub R103_Click(sender As Object, e As EventArgs) Handles R103.Click
        Dim editForm As New CustomerEditForm(103, connectionString)
        editForm.Show()
    End Sub

    Private Sub R104_Click(sender As Object, e As EventArgs) Handles R104.Click
        Dim editForm As New CustomerEditForm(104, connectionString)
        editForm.Show()
    End Sub

    Private Sub R105_Click(sender As Object, e As EventArgs) Handles R105.Click
        Dim editForm As New CustomerEditForm(105, connectionString)
        editForm.Show()
    End Sub

    Private Sub R201_Click(sender As Object, e As EventArgs) Handles R201.Click
        Dim editForm As New CustomerEditForm(201, connectionString)
        editForm.Show()
    End Sub

    Private Sub R202_Click(sender As Object, e As EventArgs) Handles R202.Click
        Dim editForm As New CustomerEditForm(202, connectionString)
        editForm.Show()
    End Sub

    Private Sub R203_Click(sender As Object, e As EventArgs) Handles R203.Click
        Dim editForm As New CustomerEditForm(203, connectionString)
        editForm.Show()
    End Sub

    Private Sub R204_Click(sender As Object, e As EventArgs) Handles R204.Click
        Dim editForm As New CustomerEditForm(204, connectionString)
        editForm.Show()
    End Sub

    Private Sub R205_Click(sender As Object, e As EventArgs) Handles R205.Click
        Dim editForm As New CustomerEditForm(205, connectionString)
        editForm.Show()
    End Sub

    Private Sub R301_Click(sender As Object, e As EventArgs) Handles R301.Click
        Dim editForm As New CustomerEditForm(301, connectionString)
        editForm.Show()
    End Sub

    Private Sub R302_Click(sender As Object, e As EventArgs) Handles R302.Click
        Dim editForm As New CustomerEditForm(302, connectionString)
        editForm.Show()
    End Sub

    Private Sub R303_Click(sender As Object, e As EventArgs) Handles R303.Click
        Dim editForm As New CustomerEditForm(303, connectionString)
        editForm.Show()
    End Sub

    Private Sub R304_Click(sender As Object, e As EventArgs) Handles R304.Click
        Dim editForm As New CustomerEditForm(304, connectionString)
        editForm.Show()
    End Sub

    Private Sub R305_Click(sender As Object, e As EventArgs) Handles R305.Click
        Dim editForm As New CustomerEditForm(305, connectionString)
        editForm.Show()
    End Sub

    Private Sub CustomerSelection_Load(sender As Object, e As EventArgs) Handles MyBase.Load
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
