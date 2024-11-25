Public Class RealtimeReports

#Region "Fields / Objects"
    Private ReadOnly recordsRepo As New RecordsRepo
    Private ReadOnly roomsRepo As New RoomsRepo
#End Region

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

#Region "Event Handlers"
    Private Async Sub RealtimeReports_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Not Me.Visible Then Return

        Await Me.LoadRealtime
    End Sub

    Private Async Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Await Me.LoadRealtime
    End Sub
#End Region

#Region "Private Methods"
    Private Async Function LoadRealtime() As Task
        Try
            Dim rooms = Await Me.roomsRepo.HttpGet1000

            Dim dict As New Dictionary(Of Integer, Task(Of Integer))
            For Each kvp In rooms
                Dim room = kvp.Item1
                dict.Add(room.ID, Me.recordsRepo.HttpGetRoomCount(room.ID))
            Next

            Me.dgRealtime.Rows.Clear()

            For Each kvp In rooms
                Dim room = kvp.Item1
                Dim count = Await dict(room.ID)
                Me.dgRealtime.Rows.Add(room.ID, room.Name, room.Type, room.Price, count, room.Price * count)
            Next

            Me.dgRealtime.ClearSelection()
            Me.lblCount.Text = $"Count: <b>{Me.dgRealtime.RowCount}</b>"
        Catch ex As Exception
            MessageBox.Show($"Something went wrong.{vbCrLf}Please try again later", "Failed to load Realtime Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
#End Region
End Class
