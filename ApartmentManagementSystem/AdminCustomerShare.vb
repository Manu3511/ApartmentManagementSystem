Public Module AdminCustomerShare
    Public IsAdmin As Boolean = True
    Public CurrentRoomNumber As String
    Public ReadOnly connectionString As String = "Data Source=HPLAP12\SQLEXPRESS;Initial Catalog=APR;Integrated Security=True"

    Public Function ValidateAllTextBoxes(form As Form, ParamArray excludeTextBoxes() As TextBox) As Boolean
        For Each textBox As TextBox In form.Controls.OfType(Of TextBox)()
            If Not excludeTextBoxes.Contains(textBox) AndAlso String.IsNullOrEmpty(textBox.Text) Then
                MessageBox.Show("Please fill in all the required fields.")
                Return False
            End If
        Next
        Return True
    End Function
End Module