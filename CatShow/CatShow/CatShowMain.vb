Public Class CatShowMain


    Private Sub addEvent_Button_Click(sender As Object, e As EventArgs) Handles addEvent_Button.Click
        My.Forms.AddEventForm.Show()
    End Sub

    Private Sub viewEvents_Button_Click(sender As Object, e As EventArgs) Handles viewEvents_Button.Click
        My.Forms.viewEvents.Show()
    End Sub
End Class
