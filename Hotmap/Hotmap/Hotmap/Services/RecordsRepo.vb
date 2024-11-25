Imports System.Net.Http
Imports System.Text
Imports System.Text.Json.Nodes

Public Class RecordsRepo

    Private ReadOnly url As String = My.Settings.HotelApi & "/records"

#Region "Create / Update"
    Public Async Function HttpPost(record As RecordModel) As Task(Of String)
        Dim apiUrl = Me.url
        Dim json = $"{{""roomID"": ""{record.RoomID}"", ""checkIn"": ""{record.CheckIn:yyyy-MM-dd HH:mm:ss}""}}"

        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        Dim request As New HttpRequestMessage(HttpMethod.Post, apiUrl)
        request.Headers.Add("Authorization", Services.AuthToken)
        request.Content = content

        Dim response As HttpResponseMessage = Await Services.HttpClient.SendAsync(request)
        response.EnsureSuccessStatusCode()
        Return Await response.Content.ReadAsStringAsync()
    End Function
#End Region

#Region "Read"
    Public Async Function HttpGet1000(Optional keyword As String = "") As Task(Of List(Of RecordModel))
        Dim apiUrl = Me.url & "/" & keyword
        Dim request As New HttpRequestMessage(HttpMethod.Get, apiUrl)
        request.Headers.Add("Authorization", Services.AuthToken)

        Dim response = Await Services.HttpClient.SendAsync(request)
        response.EnsureSuccessStatusCode()

        Dim content = Await response.Content.ReadAsStringAsync

        Dim array = JsonNode.Parse(content)

        Dim list As New List(Of RecordModel)

        For Each item In array.AsArray
            list.Add(New RecordModel With {
                 .ID = item("_id"),
                 .RoomID = item("RoomID"),
                 .CheckIn = item("CheckIn"),
                 .CheckOut = item("CheckOut")
            })
        Next

        Return list
    End Function
#End Region
End Class
