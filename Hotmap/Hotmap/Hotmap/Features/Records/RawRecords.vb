Imports System.IO
Imports System.Text

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

    Private Sub btnExport_Click(sender As Object, e As EventArgs) Handles btnExport.Click
        ' Create and configure the SaveFileDialog
        Dim saveFileDialog As New SaveFileDialog With {
            .Filter = "CSV Files (*.csv)|*.csv",
            .DefaultExt = ".csv",
            .AddExtension = True,
            .Title = "Save CSV File"
        }

        ' Show the dialog and check if the user selected a file
        If Not saveFileDialog.ShowDialog() = DialogResult.OK Then Return

        Dim filePath As String = saveFileDialog.FileName
        Try
            ' Export the DataGridView data to CSV
            ExportDataGridViewToCSV(filePath)
            MessageBox.Show("File saved successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show("Error saving file: " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Async Sub btnRefresh_Click(sender As Object, e As EventArgs) Handles btnRefresh.Click
        Await LoadData()
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

    Private Sub ExportDataGridViewToCSV(filePath As String)
        ' Create a StringBuilder to construct the CSV content
        Dim csvContent As New StringBuilder()

        ' Export the column headers
        For i As Integer = 0 To Me.dgRecords.Columns.Count - 1
            csvContent.Append(Me.dgRecords.Columns(i).HeaderText)
            If i < Me.dgRecords.Columns.Count - 1 Then
                csvContent.Append(",")
            End If
        Next
        csvContent.AppendLine()

        ' Export the data rows
        For Each row As DataGridViewRow In Me.dgRecords.Rows
            If Not row.IsNewRow Then
                For i As Integer = 0 To Me.dgRecords.Columns.Count - 1
                    csvContent.Append(row.Cells(i).Value?.ToString().Replace(",", ";")) ' Handle commas in data
                    If i < Me.dgRecords.Columns.Count - 1 Then
                        csvContent.Append(",")
                    End If
                Next
                csvContent.AppendLine()
            End If
        Next

        ' Write the CSV content to the selected file
        File.WriteAllText(filePath, csvContent.ToString())
    End Sub
#End Region
End Class
