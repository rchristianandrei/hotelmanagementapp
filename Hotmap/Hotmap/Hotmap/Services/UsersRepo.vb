Imports System.Net.Http
Imports System.Text
Imports System.Text.Json
Imports System.Text.Json.Nodes

Public Class UsersRepo
    Private ReadOnly url As String = My.Settings.HotelApi & "/users"

#Region "Create / Update"
    Public Async Function HttpPost(user As UserModel) As Task(Of String)
        Dim apiUrl = Me.url
        Dim json = JsonSerializer.Serialize(user)

        Dim content As New StringContent(json, Encoding.UTF8, "application/json")

        Dim request As New HttpRequestMessage(HttpMethod.Post, apiUrl)
        request.Headers.Add("Authorization", Services.AuthToken)
        request.Content = content

        Dim response As HttpResponseMessage = Await Services.HttpClient.SendAsync(request)
        response.EnsureSuccessStatusCode()
        Return Await response.Content.ReadAsStringAsync()
    End Function

    'Public Async Function Update(user As UserModel) As Task
    '    Dim query = $"INSERT INTO `tblusers`
    '                    (`id`, `dFirstName`, ,`dLastName`, `dHireDate`)
    '                VALUES
    '                    (@ID, @FirstName, @LastName, @HireDate)
    '                ON DUPLICATE KEY UPDATE
    '                    dFirstName = @FirstName, dLastName = @LastName, dHireDate = @HireDate;"
    '    Dim parameters As MySqlParameter() = {
    '        New MySqlParameter("@ID", user.EID),
    '        New MySqlParameter("@FirstName", user.FirstName),
    '        New MySqlParameter("@LastName", user.LastName),
    '        New MySqlParameter("@HireDate", user.HireDate.ToString("yyyy-MM-dd HH:mm:ss"))
    '    }
    '    Using conn As New MySqlConnection(Me.connectionString)
    '        Using command As New MySqlCommand(query, conn)
    '            command.Parameters.AddRange(parameters)
    '            Await conn.OpenAsync()
    '            Await command.ExecuteNonQueryAsync()
    '        End Using
    '    End Using
    'End Function
#End Region

#Region "Read"
    Public Async Function HttpGet1000(Optional keyword As String = "") As Task(Of List(Of UserModel))
        Dim apiUrl = Me.url & "/" & keyword
        Dim request As New HttpRequestMessage(HttpMethod.Get, apiUrl)
        request.Headers.Add("Authorization", Services.AuthToken)

        Dim response = Await Services.HttpClient.SendAsync(request)
        response.EnsureSuccessStatusCode()

        Dim content = Await response.Content.ReadAsStringAsync

        Dim array = JsonNode.Parse(content)

        Dim list As New List(Of UserModel)

        For Each item In array.AsArray
            list.Add(New UserModel With {
                .EID = item("id"),
                .FirstName = item("dFirstName"),
                .LastName = item("dLastName"),
                .HireDate = item("dHireDate"),
                .DateTimeAdded = item("tDateTimeAdded")
            })
        Next

        Return list
    End Function
#End Region

#Region "Delete"
    Public Async Function HttpDelete(userID As String) As Task(Of String)
        Dim apiUrl = Me.url & "/" & userID
        Dim request As New HttpRequestMessage(HttpMethod.Delete, apiUrl)
        request.Headers.Add("Authorization", Services.AuthToken)

        Dim response = Await Services.HttpClient.SendAsync(request)
        response.EnsureSuccessStatusCode()
        Return Await response.Content.ReadAsStringAsync()
    End Function
#End Region
End Class
