Imports System.Data.SqlClient


Public Class viewEvents
    Private Sub viewEvents_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim connection As SqlConnection = New SqlConnection()
        connection.ConnectionString = CatShow.Utility.GetConnectionString()
        connection.Open()
        Dim adp As SqlDataAdapter = New SqlDataAdapter("Select * from events", connection)
        Dim ds As DataSet = New DataSet()
        adp.Fill(ds)
        eventsGrid.DataSource = ds.Tables(0)
    End Sub
End Class