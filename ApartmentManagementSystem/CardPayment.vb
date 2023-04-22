Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Public Class CardPayment

    Private ReadOnly _roomNumber As String

    Public Sub New(roomNumber As String)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        _roomNumber = roomNumber
    End Sub
    Private Sub CardNumber_Validation(sender As Object, e As EventArgs) Handles CardNumberTextBox.Validating
        If (String.IsNullOrEmpty(CardNumberTextBox.Text) = False) Then
            If (IsNumeric(CardNumberTextBox.Text) = False) OrElse
           (CardNumberTextBox.Text.Length <> 16) Then
                MessageBox.Show("Invalid Card Number.")
                CardNumberTextBox.Text = ""
                Return
            End If
        End If
    End Sub

    Private Sub CVV_Validation(sender As Object, e As EventArgs) Handles CVVTextbox.Validating
        If (String.IsNullOrEmpty(CVVTextbox.Text) = False) Then
            If (IsNumeric(CVVTextbox.Text) = False) OrElse CVVTextbox.Text.Length <> 3 Then
                MessageBox.Show("Invalid CVV.")
                CVVTextbox.Text = ""
                Return
            End If
        End If
    End Sub

    Private Sub Month_Validation(sender As Object, e As EventArgs) Handles MonthTextBox.Validating
        If Not String.IsNullOrEmpty(MonthTextBox.Text) Then
            If (IsNumeric(MonthTextBox.Text) = False) OrElse CInt(MonthTextBox.Text) > 12 Then
                MessageBox.Show("Enter Correct Month.")
                MonthTextBox.Text = ""
                Return
            End If
        End If
    End Sub

    Private Sub Date_Validation(sender As Object, e As EventArgs) Handles DateTextBox.Validating
        If Not String.IsNullOrEmpty(DateTextBox.Text) Then
            If (IsNumeric(DateTextBox.Text) = False) OrElse CInt(DateTextBox.Text) > 31 Then
                MessageBox.Show("Enter Correct Date.")
                DateTextBox.Text = ""
                Return
            End If
        End If
    End Sub

    Private Sub FullName_Validation(sender As Object, e As EventArgs) Handles FullNameTextBox.Validating
        If FullNameTextBox.Text.Trim() = "" OrElse Not Regex.IsMatch(FullNameTextBox.Text, "^[a-zA-Z ]+$") Then
            MessageBox.Show("Please enter a valid name.")
            FullNameTextBox.Text = ""
            Return
        End If
    End Sub

    Private Sub OkButton_Click(sender As Object, e As EventArgs) Handles OkButton.Click
        If ValidateAllTextBoxes(Me, Array.Empty(Of TextBox)()) Then
            Using connection As New SqlConnection(connectionString)
                Dim query As String = "UPDATE RENT_PAYMENT SET IS_PAID = 1 WHERE ROOM_NO = @roomNo"
                Using command As New SqlCommand(query, connection)
                    command.Parameters.AddWithValue("@roomNo", _roomNumber)
                    connection.Open()
                    command.ExecuteNonQuery()
                End Using
            End Using
            DelayTimer.Interval = 2000
            DelayTimer.Start()
        End If
    End Sub

    Private Sub DelayTimer_Tick(sender As Object, e As EventArgs) Handles DelayTimer.Tick
        DelayTimer.Stop()
        MessageBox.Show("Payment was Successful.")
        Close()
    End Sub


End Class