Public Class MainPageForm

    Private Sub FeePaymentButton_Click(sender As Object, e As EventArgs) Handles FeePaymentButton.Click
        Dim rentPayment As New RentPayment()
        rentPayment.ShowDialog()
    End Sub

    Private Sub NoticeButton_Click(sender As Object, e As EventArgs) Handles NoticeButton.Click
        Dim noticeForm As New NoticeForm()
        noticeForm.ShowDialog()
        Return
    End Sub

    Private Sub RoomDetailButton_Click(sender As Object, e As EventArgs) Handles RoomDetailButton.Click
        If IsAdmin Then
            Dim roomSelection As New Rooms()
            roomSelection.ShowDialog()
        Else
            Dim customerView As New RoomEditForm(CInt(CurrentRoomNumber), connectionString)
            customerView.ShowDialog()
        End If

    End Sub

    Private Sub EventHallButton_Click(sender As Object, e As EventArgs) Handles EventHallButton.Click
        Dim eventHall As New EventHallForm()
        eventHall.ShowDialog()
    End Sub

    Private Sub CustomerDetailButton_Click(sender As Object, e As EventArgs) Handles CustomerDetailButton.Click
        If IsAdmin Then
            Dim customerView As New CustomerSelection()
            customerView.ShowDialog()
        Else
            Dim customerView As New CustomerEditForm(CInt(CurrentRoomNumber), connectionString)
            customerView.ShowDialog()
        End If
    End Sub

    Private Sub MainPageForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        If Not IsAdmin Then
            CustomerDetailButton.Text = "Profile"
        End If
    End Sub

    Private Sub MandFButton_Click(sender As Object, e As EventArgs) Handles MandFButton.Click
        Dim feedbackForm As New FeedbackForm()
        feedbackForm.ShowDialog()
    End Sub

    Private Sub LaundaryButton_Click(sender As Object, e As EventArgs) Handles LaundaryButton.Click
        Dim roomService As New RoomService()
        roomService.ShowDialog()
    End Sub
End Class