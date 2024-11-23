Imports System.Net.Http
Imports System.Text
Imports System.Text.Json
Imports System.Text.Json.Nodes
Imports MySql.Data.MySqlClient

Public Class RoomsRepo
    Private ReadOnly connectionString = My.Settings.MySQL
    Private ReadOnly url As String = My.Settings.HotelApi

#Region "Create / Update"
    Public Async Function HttpPost(room As RoomModel) As Task(Of String)
        Dim apiUrl = Me.url & "/rooms"
        Dim json = JsonSerializer.Serialize(room)
        Dim content As New StringContent(json, Encoding.UTF8, "application/json")
        Dim response As HttpResponseMessage = Await Http.HttpClient.PostAsync(apiUrl, content)
        response.EnsureSuccessStatusCode()
        Return Await response.Content.ReadAsStringAsync()
    End Function

    'Public Async Function Save(room As RoomModel) As Task
    '    Dim update = room.ID > 0
    '    Dim id As String = If(update, room.ID, "null")
    '    Dim query = $"INSERT INTO `tblrooms`
    '                    (`id`, `dName`, `dType`, `dPrice`)
    '                VALUES
    '                    ({id}, @Name, @Type, @Price)
    '                ON DUPLICATE KEY UPDATE
    '                    dName = @Name, dType = @Type, dPrice = @Price, tDateTimeModified = CURRENT_TIMESTAMP();"
    '    Dim parameters As MySqlParameter() = {
    '        New MySqlParameter("@Name", room.Name),
    '        New MySqlParameter("@Type", room.Type),
    '        New MySqlParameter("@Price", room.Price)
    '    }
    '    Using conn As New MySqlConnection(Me.connectionString)
    '        Using command As New MySqlCommand(query, conn)
    '            command.Parameters.AddRange(parameters)
    '            Await conn.OpenAsync()
    '            Dim newID = Await command.ExecuteNonQueryAsync
    '            If Not update Then room.ID = newID
    '        End Using
    '    End Using
    'End Function
#End Region

#Region "Read"
    Public Async Function HttpGet1000(Optional keyword As String = "") As Task(Of List(Of (RoomModel, DateTimeModel)))
        Dim apiUrl = Me.url & "/rooms/" & keyword
        Dim response = Await Http.HttpClient.GetAsync(apiUrl)
        response.EnsureSuccessStatusCode()

        Dim content = Await response.Content.ReadAsStringAsync

        Dim array = JsonNode.Parse(content)

        Dim list As New List(Of (RoomModel, DateTimeModel))

        For Each item In array.AsArray
            Dim room = New RoomModel With {
                .ID = item("id").ToString,
                .Name = item("dName").ToString,
                .Type = item("dType").ToString,
                .Price = Double.Parse(item("dPrice").ToString())
            }
            list.Add((room, New DateTimeModel With {
                .Created = item("tDateTimeCreated"),
                .Modified = item("tDateTimeModified")
            }))
        Next

        Return list
    End Function

    Public Async Function Get1000(Optional keyword As String = "") As Task(Of List(Of (RoomModel, DateTimeModel)))
        Dim query = $"SELECT `id`, `dName`, `dType`, `dPrice`, `tDateTimeCreated`, `tDateTimeModified`
                        FROM `tblrooms`
                        WHERE dName LIKE @Keyword OR dType LIKE @Keyword OR dPrice LIKE @Keyword
                        LIMIT 1000;"
        Dim dict As New List(Of (RoomModel, DateTimeModel))
        Using conn As New MySqlConnection(Me.connectionString)
            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@Keyword", $"%{keyword}%")
                Await conn.OpenAsync()
                Using reader = Await command.ExecuteReaderAsync
                    While Await reader.ReadAsync
                        dict.Add((New RoomModel With {
                            .ID = reader("id"),
                            .Name = reader("dName"),
                            .Type = reader("dType"),
                            .Price = reader("dPrice")
                        }, New DateTimeModel With {
                            .Created = reader("tDateTimeCreated"),
                            .Modified = reader("tDateTimeModified")
                        }))
                    End While
                End Using
            End Using
        End Using
        Return dict
    End Function
#End Region

#Region "Delete"
    Public Async Function HttpDelete(roomID As Integer) As Task(Of String)
        Dim apiUrl = Me.url & "/rooms/" & roomID
        Dim response = Await Http.HttpClient.DeleteAsync(apiUrl)
        response.EnsureSuccessStatusCode()
        Return Await response.Content.ReadAsStringAsync()
    End Function

    'Public Async Function Delete(roomID As Integer) As Task
    '    Dim query = $"DELETE FROM `tblrooms` WHERE id = {roomID};"
    '    Using conn As New MySqlConnection(Me.connectionString)
    '        Using command As New MySqlCommand(query, conn)
    '            Await conn.OpenAsync()
    '            Await command.ExecuteNonQueryAsync()
    '        End Using
    '    End Using
    'End Function
#End Region
End Class
