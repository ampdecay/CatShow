Imports System.Configuration

Namespace CatShow
    Friend Class Utility

        Friend Shared Function GetConnectionString() As String

            Dim returnValue As String = Nothing

            Dim settings As ConnectionStringSettings = ConfigurationManager.ConnectionStrings("CatShow.My.MySettings.CatShowConnectionString")

            If settings IsNot Nothing Then
                returnValue = settings.ConnectionString
            End If

            Return returnValue

        End Function

    End Class
End Namespace