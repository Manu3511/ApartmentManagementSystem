Imports System.Data.SqlClient

Public Class RentPayment
    Private Sub RentPayment_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If IsAdmin Then
            Dim query As String = "SELECT * FROM RENT_PAYMENT"
            Dim dataTable As New DataTable()
            Using connection As New SqlConnection(connectionString)
                Dim dataAdapter As New SqlDataAdapter(query, connection)
                connection.Open()
                dataAdapter.Fill(dataTable)
                With RentDataGrid
                    .DataSource = dataTable
                    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    .ReadOnly = False
                End With
            End Using
            Controls.Remove(PayButton)
        Else
            Dim query As String = "SELECT * FROM RENT_PAYMENT WHERE ROOM_NO = @roomNo"
            Dim dataTable As New DataTable()
            Using connection As New SqlConnection(connectionString)
                Dim dataAdapter As New SqlDataAdapter(query, connection)
                dataAdapter.SelectCommand.Parameters.AddWithValue("@roomNo", CurrentRoomNumber)
                connection.Open()
                dataAdapter.Fill(dataTable)
                With RentDataGrid
                    .DataSource = dataTable
                    .AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                    .ReadOnly = True
                End With
            End Using

        End If
    End Sub

    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        If IsAdmin Then
            Try
                ' Create a new DataTable to hold the changes made to the DataGridView
                Dim changes As DataTable = CType(RentDataGrid.DataSource, DataTable).GetChanges()

                ' Create a new DataAdapter to update the changes to the database
                Using connection As New SqlConnection(connectionString)
                    Dim adapter As New SqlDataAdapter("SELECT * FROM RENT_PAYMENT", connection)
                    Dim builder As New SqlCommandBuilder(adapter)

                    ' Update the database with the changes made to the DataTable
                    adapter.UpdateCommand = builder.GetUpdateCommand()
                    adapter.InsertCommand = builder.GetInsertCommand()
                    adapter.DeleteCommand = builder.GetDeleteCommand()
                    adapter.Update(changes)

                    ' Update the original DataTable with the changes from the database
                    CType(RentDataGrid.DataSource, DataTable).AcceptChanges()
                End Using
            Catch ex As ArgumentNullException
                If ex.Message.Contains("Value cannot be null") Then
                    Close()
                    Return
                End If
            End Try
            Close()
        Else
            Close()
        End If
    End Sub

    Private Sub PayButton_Click(sender As Object, e As EventArgs) Handles PayButton.Click
        Dim cardPayment As New CardPayment(CurrentRoomNumber)
        cardPayment.Show()
    End Sub
End Class