Public Class CheckInOut
#Region "Fields / Objects"
    Private Const CheckInMessage = "✅ Check In"
    Private Const CheckOutMessage = "❌ Check Out"

    Private ReadOnly roomsRepo As New RoomsRepo
    Private ReadOnly checkInOutRepo As New CheckInOutRepo

    Private ReadOnly rooms As New Dictionary(Of Integer, RoomModel)
    Private ReadOnly checkInOut As New Dictionary(Of Integer, CheckInOutModel)
#End Region

#Region "Events"

#End Region

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

#Region "Event Handlers"
    Private Async Sub CheckInOut_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Not Me.Visible Then Return

        Await Me.LoadData
    End Sub

    Private Async Sub txtSearch_Search() Handles txtSearch.Search
        Await Me.LoadData
    End Sub

    Private Async Sub dgRooms_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgRooms.CellClick
        If e.RowIndex < 0 Then Return

        Select Case e.ColumnIndex
            Case Me.colAction.Index

                Dim action = Me.dgRooms.Rows(e.RowIndex).Cells(Me.colAction.Index).Value.ToString
                Dim id As Integer = Integer.Parse(Me.dgRooms.Rows(e.RowIndex).Cells(Me.colID.Index).Value)

                Select Case action
                    Case CheckInMessage

                        Dim res = MessageBox.Show("Are you sure you want to check in this room?", "Check In", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        If Not res = vbYes Then Exit Select

                        Try
                            Await Me.checkInOutRepo.Save(id, 8)

                            Await Me.LoadData

                            MessageBox.Show("Successfully set the status of room to Check In.", "Check In", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Catch ex As Exception
                            MessageBox.Show($"Something went wrong.{vbCrLf}Please try again later.", "Unable to Check In", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try

                    Case CheckOutMessage

                        Dim res = MessageBox.Show("Are you sure you want to check out this room?", "Check Out", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                        If Not res = vbYes Then Exit Select

                        Try
                            Await Me.checkInOutRepo.Delete(id)

                            Await Me.LoadData

                            MessageBox.Show("Successfully set the status of room to Check Out.", "Check Out", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Catch ex As Exception
                            MessageBox.Show($"Something went wrong.{vbCrLf}Please try again later.", "Unable to Check Out", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try
                End Select
        End Select
    End Sub
#End Region

#Region "Private Methods"
    Private Async Function LoadData() As Task
        Try
            Dim rooms = Await Me.roomsRepo.Get1000(Me.txtSearch.Text)
            Dim checkInOut = Await Me.checkInOutRepo.Get1000

            Me.checkInOut.Clear()
            For Each check In checkInOut
                Me.checkInOut.Add(check.ID, check)
            Next

            Me.rooms.Clear()
            Me.dgRooms.Rows.Clear()

            For Each kvp In rooms
                Dim room = kvp.Item1
                Me.rooms.Add(room.ID, room)

                Dim checkedIn = Me.checkInOut.ContainsKey(room.ID)
                Dim status = If(checkedIn, Me.checkInOut(room.ID), Nothing)

                Dim action = If(checkedIn, CheckOutMessage, CheckInMessage)
                Dim checkIn As String = If(checkedIn, status.CheckIn.ToString, "Available")
                Dim checkOut As String = If(checkedIn, status.CheckOut.ToString, "--------")
                Me.dgRooms.Rows.Add(action, room.ID, room.Name, room.Type, room.Price, checkIn, checkOut)
            Next

            Me.dgRooms.ClearSelection()
            Me.lblCount.Text = $"Count: <b>{Me.dgRooms.RowCount}</b>"

        Catch ex As Exception
            MessageBox.Show($"Something went wrong.{vbCrLf}Please try again later.", "Failed to Load Rooms", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
#End Region
End Class
