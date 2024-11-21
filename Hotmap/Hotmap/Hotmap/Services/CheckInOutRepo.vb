Imports MySql.Data.MySqlClient

Public Class CheckInOutRepo
    Private ReadOnly connectionString = My.Settings.MySQL

#Region "Create / Update"
    Public Async Function Save(roomId As Integer, hour As Integer) As Task
        Dim query = $"INSERT INTO tblCheckInOut(id, dCheckOut)
                    VALUES({roomId}, DATE_ADD(CURRENT_TIMESTAMP, INTERVAL {hour} HOUR));"
        Using conn As New MySqlConnection(Me.connectionString)
            Using command As New MySqlCommand(query, conn)
                Await conn.OpenAsync()
                Await command.ExecuteNonQueryAsync
            End Using
        End Using
    End Function
#End Region

#Region "Read"
    Public Async Function Get1000() As Task(Of List(Of CheckInOutModel))
        Dim query = "SELECT id, dCheckIn, dCheckOut 
                    FROM tblCheckInOut
                    LIMIT 1000;"
        Dim list As New List(Of CheckInOutModel)
        Using conn As New MySqlConnection(Me.connectionString)
            Using command As New MySqlCommand(query, conn)
                Await conn.OpenAsync()
                Using reader = Await command.ExecuteReaderAsync
                    While reader.Read
                        list.Add(New CheckInOutModel With {
                            .ID = reader("id"),
                            .CheckIn = reader("dCheckIn"),
                            .CheckOut = reader("dCheckOut")
                        })
                    End While
                End Using
            End Using
        End Using
        Return list
    End Function
#End Region

#Region "Delete"
    Public Async Function Delete(checkInOutID As Integer) As Task
        Dim query = $"DELETE FROM tblCheckInOut WHERE id = {checkInOutID};"
        Using conn As New MySqlConnection(Me.connectionString)
            Using command As New MySqlCommand(query, conn)
                Await conn.OpenAsync()
                Await command.ExecuteNonQueryAsync
            End Using
        End Using
    End Function
#End Region
End Class
