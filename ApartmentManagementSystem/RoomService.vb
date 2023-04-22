Imports System.Data.SqlClient

Public Class RoomService
    Private Sub RoomService_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IsAdmin Then
            Dim query As String = "SELECT * FROM ROOM_SERVICE"
            Dim dataTable As New DataTable()
            Using connection As New SqlConnection(connectionString)
                Dim dataAdapter As New SqlDataAdapter(query, connection)
                connection.Open()
                dataAdapter.Fill(dataTable)
                With RoomServiceDataGrid
                    .DataSource = dataTable
                    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    .ReadOnly = False
                End With
            End Using
        Else
            Dim query As String = "SELECT * FROM ROOM_SERVICE WHERE ROOM_NO = @roomNo"
            Dim dataTable As New DataTable()
            Using connection As New SqlConnection(connectionString)
                Dim dataAdapter As New SqlDataAdapter(query, connection)
                dataAdapter.SelectCommand.Parameters.AddWithValue("@roomNo", CurrentRoomNumber)
                connection.Open()
                dataAdapter.Fill(dataTable)
                With RoomServiceDataGrid
                    .DataSource = dataTable
                    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    .AllowUserToDeleteRows = False
                End With
            End Using
        End If
    End Sub

    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        ' Create a new DataTable to hold the changes made to the DataGridView
        Dim changes As DataTable = CType(RoomServiceDataGrid.DataSource, DataTable).GetChanges()

        ' Create a new DataAdapter to update the changes to the database
        Using connection As New SqlConnection(connectionString)
            Dim adapter As New SqlDataAdapter("SELECT * FROM ROOM_SERVICE", connection)
            Dim builder As New SqlCommandBuilder(adapter)

            ' Update the database with the changes made to the DataTable
            adapter.UpdateCommand = builder.GetUpdateCommand()
            adapter.InsertCommand = builder.GetInsertCommand()
            adapter.DeleteCommand = builder.GetDeleteCommand()
            adapter.Update(changes)

            ' Update the original DataTable with the changes from the database
            CType(RoomServiceDataGrid.DataSource, DataTable).AcceptChanges()
        End Using
        Close()

    End Sub

    Private Sub RoomServiceDataGrid_CellClick(sender As Object, e As EventArgs) Handles RoomServiceDataGrid.CellEndEdit
        Dim CurrentRoomNo As Integer = CInt(CurrentRoomNumber)
        If Not IsAdmin Then
            If RoomServiceDataGrid.CurrentCell.ColumnIndex = 0 Then
                If RoomServiceDataGrid.CurrentCell.Value <> CurrentRoomNo Then
                    MessageBox.Show("Enter Your Own Room Number.")
                    RoomServiceDataGrid.Rows.RemoveAt(RoomServiceDataGrid.CurrentCell.RowIndex)
                    Return
                End If
            ElseIf RoomServiceDataGrid.CurrentCell.ColumnIndex = 1 Then
                If CDate(RoomServiceDataGrid.CurrentCell.Value) < Today.Date Then
                    MessageBox.Show("Enter Your Own Room Number.")
                    RoomServiceDataGrid.Rows.RemoveAt(RoomServiceDataGrid.CurrentCell.RowIndex)
                End If
            End If
        End If
    End Sub

End Class