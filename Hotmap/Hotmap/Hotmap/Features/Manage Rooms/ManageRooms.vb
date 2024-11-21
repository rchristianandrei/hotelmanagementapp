Public Class ManageRooms

#Region "Fields / Objects"
    Private ReadOnly roomsRepo As New RoomsRepo

    Private ReadOnly rooms As New Dictionary(Of Integer, RoomModel)
#End Region

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.colPrice.HeaderCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter
    End Sub

#Region "Properties"
#End Region

#Region "Events"
#End Region

#Region "Event Handlers"
    Private Async Sub ManageRooms_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Not Me.Visible Then Return

        Await Me.LoadRooms()
    End Sub

    Private Sub btnAdd_Click() Handles btnAdd.Click
        Dim addRoom As New AddRoom
        AddHandler addRoom.Closing, Async Sub() Await Me.LoadRooms()
        addRoom.ShowDialog(Me.ParentForm)
    End Sub

    Private Async Sub dgRooms_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgRooms.CellClick
        If e.RowIndex < 0 Then Return

        Dim id As Integer = Me.dgRooms.Rows(e.RowIndex).Cells(Me.colID.Index).Value

        Select Case e.ColumnIndex
            Case Me.colDelete.Index
                ' Delete
                Dim res = MessageBox.Show("Are you sure you want to delete this room?", "Delete Room", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If Not res = vbYes Then Exit Select

                Try
                    Await Me.roomsRepo.Delete(id)

                    MessageBox.Show($"Successfully Deleted the Room!.", "Deleted Room", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show($"Something went wrong.{vbCrLf}Please try again later.", "Unable to Delete Room", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            Case Me.colEdit.Index
                ' Edit
                Dim addRoom As New AddRoom With {.Room = Me.rooms(id)}
                addRoom.ShowDialog(Me.ParentForm)
        End Select

        Await Me.LoadRooms
    End Sub
#End Region

#Region "Private Methods"
    Private Async Function LoadRooms() As Task
        Try
            Dim rooms = Await Me.roomsRepo.Get1000()

            Me.rooms.Clear()
            Me.dgRooms.Rows.Clear()

            For Each kvp In rooms
                Dim room = kvp.Item1
                Dim time = kvp.Item2
                Me.rooms.Add(room.ID, room)
                Me.dgRooms.Rows.Add("🖊️", room.ID, room.Name, room.Type, String.Format("{0:F2}", room.Price), "❌")
            Next

            Me.lblCount.Text = $"Count: <b>{Me.dgRooms.RowCount}</b>"
            Me.dgRooms.ClearSelection()
        Catch ex As Exception
            MessageBox.Show($"Something went wrong.{vbCrLf}Please try again later.", "Unable to Load Rooms", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
#End Region
End Class
