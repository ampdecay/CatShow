Imports System.Data.SqlClient



Public Class AddEventForm

    Dim connection As SqlConnection = New SqlConnection()


    Private Sub genID_Button_Click(sender As Object, e As EventArgs) Handles genID_Button.Click

        connection.ConnectionString = CatShow.Utility.GetConnectionString()
        Dim rng = New Random()
        Dim eventID = rng.Next(100000, 200000)
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
            'generate random number between 1000 and 9999 to use as event ID
            eventID = rng.Next(1000, 10000)
        End While
        connection.Close()
        eventID_Box.Text = eventID.ToString()
    End Sub


End Class