Imports System.Data.SqlClient
Imports System.Diagnostics.Eventing.Reader

Public Class AdminLoginForm
    Private Sub LoginButton_Click(sender As Object, e As EventArgs) Handles LoginButton.Click
        'Check if username and password are valid
        If AdminCustomerShare.IsAdmin Then
            If String.IsNullOrEmpty(UsernameTextBox.Text) OrElse Not UsernameTextBox.Text.Equals("admin") Then
                MessageBox.Show("Invalid username")
                Return
            End If
            If String.IsNullOrEmpty(PasswordTextBox.Text) OrElse Not PasswordTextBox.Text.Equals("password") Then
                MessageBox.Show("Invalid password")
                Return
            End If
        Else
            Dim connectionString As String = "Data Source=HPLAP12\SQLEXPRESS;Initial Catalog=APR;Integrated Security=True"
            Dim query = "SELECT * FROM CUSTOMER_LOGIN WHERE USERID = @userId AND PASSWORD = @password"
            Using connection As New SqlConnection(connectionString)
                Dim command As New SqlCommand(query, connection)
                command.Parameters.AddWithValue("@userId", UsernameTextBox.Text)
                command.Parameters.AddWithValue("@password", PasswordTextBox.Text)
                connection.Open()
                Dim reader As SqlDataReader = command.ExecuteReader()
                If Not reader.HasRows Then
                    MessageBox.Show("Invalid username or password. Try again")
                    Return
                Else
                    AdminCustomerShare.CurrentRoomNumber = UsernameTextBox.Text
                End If
                reader.Close()
            End Using
        End If

        'Login successful

        Dim MainPageForm As New MainPageForm()
        MainPageForm.Show()
    End Sub

    Private Sub ShowPasswordCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles ShowPasswordCheckBox.CheckedChanged
        'Change the password character
        If ShowPasswordCheckBox.Checked Then
            PasswordTextBox.PasswordChar = ControlChars.NullChar
        Else
            PasswordTextBox.PasswordChar = "*"c
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles CancelFormButton.Click
        Application.Exit()
    End Sub

    Private Sub ResetButton_Click(sender As Object, e As EventArgs) Handles ResetButton.Click
        UsernameTextBox.Text = ""
        PasswordTextBox.Text = ""
    End Sub

    Private Sub LoginButton_MouseEnter(sender As Object, e As EventArgs) Handles LoginButton.MouseEnter
        LoginButton.BackColor = Color.LightGreen

    End Sub

    Private Sub LoginButton_MouseLeave(sender As Object, e As EventArgs) Handles LoginButton.MouseLeave
        LoginButton.BackColor = Color.LightBlue
    End Sub

    Private Sub CancelButton_MouseEnter(sender As Object, e As EventArgs) Handles CancelFormButton.MouseEnter
        CancelFormButton.BackColor = Color.IndianRed
    End Sub

    Private Sub CancelButton_MouseLeave(sender As Object, e As EventArgs) Handles CancelFormButton.MouseLeave
        CancelFormButton.BackColor = Color.LightBlue
    End Sub

    Private Sub ResetButton_MouseEnter(sender As Object, e As EventArgs) Handles ResetButton.MouseEnter
        ResetButton.BackColor = Color.White
    End Sub

    Private Sub ResetButton_MouseLeave(sender As Object, e As EventArgs) Handles ResetButton.MouseLeave
        ResetButton.BackColor = Color.LightBlue
    End Sub

    Private Sub CustomerLoginCheckBox_CheckedChanged(sender As Object, e As EventArgs) Handles CustomerLoginCheckBox.CheckedChanged
        If CustomerLoginCheckBox.Checked Then
            AdminCustomerShare.IsAdmin = False
        Else
            AdminCustomerShare.IsAdmin = True
        End If
    End Sub

End Class


