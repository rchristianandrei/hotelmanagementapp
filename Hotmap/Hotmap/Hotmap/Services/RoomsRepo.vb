Imports MySql.Data.MySqlClient

Public Class RoomsRepo
    Private ReadOnly connectionString = My.Settings.MySQL

#Region "Create / Update"
    Public Async Function Save(room As RoomModel) As Task
        Dim update = room.ID > 0
        Dim id As String = If(update, room.ID, "null")
        Dim query = $"INSERT INTO `tblrooms`
                        (`id`, `dName`, `dType`, `dPrice`)
                    VALUES
                        ({id}, @Name, @Type, @Price)
                    ON DUPLICATE KEY UPDATE
                        dName = @Name, dType = @Type, dPrice = @Price, tDateTimeModified = CURRENT_TIMESTAMP();"
        Dim parameters As MySqlParameter() = {
            New MySqlParameter("@Name", room.Name),
            New MySqlParameter("@Type", room.Type),
            New MySqlParameter("@Price", room.Price)
        }
        Dim exs = Await Task.Run(
            Function()
                Try
                    Using conn As New MySqlConnection(Me.connectionString)
                        Using command As New MySqlCommand(query, conn)
                            command.Parameters.AddRange(parameters)
                            conn.Open()
                            Dim newID = command.ExecuteNonQuery
                            If Not update Then room.ID = newID
                        End Using
                    End Using
                    Return Nothing
                Catch ex As Exception
                    Return ex
                End Try
            End Function)
        If exs IsNot Nothing Then Throw exs
    End Function
#End Region

#Region "Read"
    Public Async Function Get1000() As Task(Of List(Of (RoomModel, DateTimeModel)))
        Dim query = $"SELECT `id`, `dName`, `dType`, `dPrice`, `tDateTimeCreated`, `tDateTimeModified`
                        FROM `tblrooms`
                        LIMIT 1000;"
        Dim dict As New List(Of (RoomModel, DateTimeModel))
        Dim exs = Await Task.Run(
            Function()
                Try
                    Using conn As New MySqlConnection(Me.connectionString)
                        Using command As New MySqlCommand(query, conn)
                            conn.Open()
                            Using reader = command.ExecuteReader
                                While reader.Read
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
                    Return Nothing
                Catch ex As Exception
                    Return ex
                End Try
            End Function)
        If exs IsNot Nothing Then Throw exs
        Return dict
    End Function
#End Region

#Region "Delete"
    Public Async Function Delete(roomID As Integer) As Task
        Dim query = $"DELETE FROM `tblrooms` WHERE id = {roomID};"
        Dim exs = Await Task.Run(
            Function()
                Try
                    Using conn As New MySqlConnection(Me.connectionString)
                        Using command As New MySqlCommand(query, conn)
                            conn.Open()
                            command.ExecuteNonQuery()
                        End Using
                    End Using
                    Return Nothing
                Catch ex As Exception
                    Return ex
                End Try
            End Function)
        If exs IsNot Nothing Then Throw exs
    End Function
#End Region
End Class
