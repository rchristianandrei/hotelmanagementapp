Imports System.Net.Http
Imports System.Text
Imports System.Text.Json
Imports System.Text.Json.Nodes

Public Class RoomsRepo
    Private ReadOnly url As String = My.Settings.HotelApi & "/rooms"

#Region "Create / Update"
    Public Async Function HttpPost(room As RoomModel) As Task(Of String)
        Dim apiUrl = Me.url
        Dim json = JsonSerializer.Serialize(room)

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
    Public Async Function HttpGet1000(Optional keyword As String = "") As Task(Of List(Of (RoomModel, DateTimeModel)))
        Dim apiUrl = Me.url & "/" & keyword
        Dim request As New HttpRequestMessage(HttpMethod.Get, apiUrl)
        request.Headers.Add("Authorization", Services.AuthToken)

        Dim response = Await Services.HttpClient.SendAsync(request)
        response.EnsureSuccessStatusCode()

        Dim content = Await response.Content.ReadAsStringAsync

        Dim array = JsonNode.Parse(content)

        Dim list As New List(Of (RoomModel, DateTimeModel))

        For Each item In array.AsArray
            list.Add((New RoomModel With {
                .ID = item("id").ToString,
                .Name = item("dName").ToString,
                .Type = item("dType").ToString,
                .Price = Double.Parse(item("dPrice").ToString())
            }, New DateTimeModel With {
                .Created = item("tDateTimeCreated"),
                .Modified = item("tDateTimeModified")
            }))
        Next

        Return list
    End Function
#End Region

#Region "Delete"
    Public Async Function HttpDelete(roomID As Integer) As Task(Of String)
        Dim apiUrl = Me.url & "/" & roomID
        Dim request As New HttpRequestMessage(HttpMethod.Delete, apiUrl)
        request.Headers.Add("Authorization", Services.AuthToken)

        Dim response = Await Services.HttpClient.SendAsync(request)
        response.EnsureSuccessStatusCode()
        Return Await response.Content.ReadAsStringAsync()
    End Function
#End Region
End Class
