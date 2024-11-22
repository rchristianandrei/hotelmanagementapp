Imports MySql.Data.MySqlClient

Public Class UsersRepo
    Private ReadOnly connectionString = My.Settings.MySQL

#Region "Create / Update"
    Public Async Function Save(user As UserModel) As Task
        Dim query = $"INSERT INTO `tblusers`
                        (`id`, `dFirstName`, `dLastName`, `dHireDate`)
                    VALUES
                        (@ID, @FirstName, @LastName, @HireDate)
                    ON DUPLICATE KEY UPDATE
                        dFirstName = @FirstName, dLastName = @LastName, dHireDate = @HireDate;"
        Dim parameters As MySqlParameter() = {
            New MySqlParameter("@ID", user.EID),
            New MySqlParameter("@FirstName", user.FirstName),
            New MySqlParameter("@LastName", user.LastName),
            New MySqlParameter("@HireDate", user.HireDate.ToString("yyyy-MM-dd HH:mm:ss"))
        }
        Using conn As New MySqlConnection(Me.connectionString)
            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddRange(parameters)
                Await conn.OpenAsync()
                Await command.ExecuteNonQueryAsync()
            End Using
        End Using
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
    Public Async Function Get1000(Optional keyword As String = "") As Task(Of List(Of UserModel))
        Dim query = $"SELECT `id`, `dFirstName`, `dLastName`, `dHireDate`, `tDateTimeAdded` 
                    FROM `tblusers`
                    WHERE id LIKE @Keyword OR dFirstName LIKE @Keyword OR dLastName LIKE @Keyword OR dHireDate LIKE @Keyword
                    LIMIT 1000;"
        Dim list As New List(Of UserModel)
        Using conn As New MySqlConnection(Me.connectionString)
            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@Keyword", $"%{keyword}%")
                Await conn.OpenAsync()
                Using reader = Await command.ExecuteReaderAsync
                    While Await reader.ReadAsync
                        list.Add(New UserModel With {
                            .EID = reader("id"),
                            .FirstName = reader("dFirstName"),
                            .LastName = reader("dLastName"),
                            .HireDate = reader("dHireDate"),
                            .DateTimeAdded = reader("tDateTimeAdded")
                        })
                    End While
                End Using
            End Using
        End Using
        Return list
    End Function
#End Region

#Region "Delete"
    Public Async Function Delete(eid As String) As Task
        Dim query = $"DELETE FROM `tblusers` WHERE id = @ID;"
        Using conn As New MySqlConnection(Me.connectionString)
            Using command As New MySqlCommand(query, conn)
                command.Parameters.AddWithValue("@ID", eid)
                Await conn.OpenAsync()
                Await command.ExecuteNonQueryAsync
            End Using
        End Using
    End Function
#End Region
End Class
