Imports System.Net.Http
Imports System.Text

Public Class LoginRepo
    Private ReadOnly url As String = My.Settings.HotelApi & "/auth"

#Region "Create / Update"
    Public Async Function Login(userID As String, password As String) As Task
        Dim apiUrl = Me.url
        Dim json = $"{{""id"": ""{userID}"", ""password"": ""{password}""}}"
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")
        Dim response = Await Services.HttpClient.PostAsync(apiUrl, content)
        response.EnsureSuccessStatusCode()
        Dim token = Await response.Content.ReadAsStringAsync()
        Services.AuthToken = $"Bearer {token}"
    End Function
#End Region
End Class
