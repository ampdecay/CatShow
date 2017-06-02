Imports System.Data.SqlClient
Public Class AddEventForm

    Dim connection As SqlConnection = New SqlConnection()
    Dim eventID As Integer

    Private Sub genID_Button_Click(sender As Object, e As EventArgs) Handles genID_Button.Click

        connection.ConnectionString = CatShow.Utility.GetConnectionString()
        Dim rng = New Random()
        'generate random number between 1000 and 9999 to use as event ID
        eventID = rng.Next(1000, 10000)
        Dim query As String = String.Empty
        query &= "Select event_id from Events where event_id = @id"
        Dim idCMD As New SqlCommand
        With idCMD
            .Connection = connection
            .CommandType = CommandType.Text
            .CommandText = query
            .Parameters.AddWithValue("@id", eventID)
        End With
        connection.Open()
        Dim results As Int32 = CInt(idCMD.ExecuteScalar())

        While results = eventID
            'keep generating new ID's until an unused one is found
            eventID = rng.Next(1000, 10000)
        End While
        connection.Close()
        eventID_Box.Text = eventID.ToString()
    End Sub

    Private Sub addEvent_button_Click(sender As Object, e As EventArgs) Handles addEvent_button.Click
        Dim eventID = eventID_Box.Text
        If eventID = "" Then
            MessageBox.Show("Please generate an event ID first before creating an Event!!!")

        ElseIf date_selector.Value <= Date.Today Then
            MessageBox.Show("Please enter a date later than todays date!!!")
        Else
            'insert event into database
            Dim location As String = location_box.Text
            Dim eventDate = date_selector.Value.Date.ToShortDateString()
            Dim query As String = String.Empty
            query &= "INSERT INTO Events VALUES (@eventID, @location, @date)"
            Using comm As New SqlCommand()
                With comm
                    .Connection = connection
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@eventID", eventID)
                    .Parameters.AddWithValue("@location", location)
                    .Parameters.AddWithValue("@date", eventDate)
                End With
                Try
                    connection.Open()
                    Dim result As Int16 = comm.ExecuteNonQuery()
                    MessageBox.Show("Event Added Successfully!")
                Catch ex As SqlException
                    MessageBox.Show(ex.Message.ToString, "Error Message")
                End Try
            End Using
            connection.Close()
        End If
    End Sub

    Private Sub AddEventForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'sets dateselector to current day
        date_selector.Value = Date.Today
    End Sub
End Class