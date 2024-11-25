Imports System.Net.Http
Imports System.Text.Json.Nodes

Public Class CheckInOutRepo
    Private ReadOnly connectionString = My.Settings.MySQL
    Private ReadOnly url As String = My.Settings.HotelApi & "/checkinout"

#Region "Create / Update"
    Public Async Function HttpPost(roomId As Integer, hour As Integer) As Task(Of String)
        Dim apiUrl = Me.url & $"/{roomId}/{hour}"

        Dim request As New HttpRequestMessage(HttpMethod.Post, apiUrl)
        request.Headers.Add("Authorization", Services.AuthToken)

        Dim response = Await Services.HttpClient.SendAsync(request)
        response.EnsureSuccessStatusCode()
        Return Await response.Content.ReadAsStringAsync()
    End Function
#End Region

#Region "Read"
    Public Async Function HttpGet1000() As Task(Of List(Of CheckInOutModel))
        Dim request As New HttpRequestMessage(HttpMethod.Get, Me.url)
        request.Headers.Add("Authorization", Services.AuthToken)

        Dim response = Await Services.HttpClient.SendAsync(request)
        response.EnsureSuccessStatusCode()

        Dim content = Await response.Content.ReadAsStringAsync

        Dim array = JsonNode.Parse(content)

        Dim list As New List(Of CheckInOutModel)

        For Each item In array.AsArray
            list.Add(New CheckInOutModel With {
                .ID = item("id"),
                .CheckIn = item("dCheckIn"),
                .CheckOut = item("dCheckOut")
            })
        Next

        Return list
    End Function
#End Region

#Region "Delete"
    Public Async Function HttpDelete(roomID As Integer) As Task(Of String)
        Dim apiUrl = Me.url & $"/{roomID}"
        Dim request As New HttpRequestMessage(HttpMethod.Delete, apiUrl)
        request.Headers.Add("Authorization", Services.AuthToken)

        Dim response = Await Services.HttpClient.SendAsync(request)
        response.EnsureSuccessStatusCode()
        Return Await response.Content.ReadAsStringAsync()
    End Function
#End Region
End Class
