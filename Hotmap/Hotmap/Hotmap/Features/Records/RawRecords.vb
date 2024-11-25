Public Class RawRecords

#Region "Fields / Objects"
    Private ReadOnly recordsRepo As New RecordsRepo
#End Region

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

#Region "Event Handlers"
    Private Async Sub RealtimeReports_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Not Me.Visible Then Return

        Await Me.LoadData
    End Sub

    Private Async Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Await Me.LoadData
    End Sub
#End Region

#Region "Private Methods"
    Private Async Function LoadData() As Task
        Try
            Dim records = Await Me.recordsRepo.HttpGet

            Me.dgRecords.Rows.Clear()

            For Each record In records
                Me.dgRecords.Rows.Add(record.ID, record.RoomID, record.RoomName, record.RoomType, record.RoomPrice, record.CheckIn, record.CheckOut)
            Next

            Me.dgRecords.ClearSelection()
            Me.lblCount.Text = $"Count: <b>{Me.dgRecords.RowCount}</b>"
        Catch ex As Exception
            MessageBox.Show($"Something went wrong.{vbCrLf}Please try again later", "Failed to load Realtime Report", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
#End Region
End Class
