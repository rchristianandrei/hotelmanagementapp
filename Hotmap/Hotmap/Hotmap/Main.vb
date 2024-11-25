Public Class Main

#Region "Fields"
    Private ReadOnly tabToMenu As New Dictionary(Of TabPage, ToolStripMenuItem)
#End Region

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
    End Sub

#Region "Event Handlers"
    Private Sub miCheckInOut_Click(sender As Object, e As EventArgs) Handles miCheckInOut.Click
        If Me.OpenFeature("Check In / Out", New CheckInOut, Me.miCheckInOut) Then Return
    End Sub

    Private Sub miRealtime_Click(sender As Object, e As EventArgs) Handles miRealtime.Click
        If Me.OpenFeature("Realtime Reports", New RealtimeReports, Me.miRealtime) Then Return
    End Sub

    Private Sub miRawRecords_Click(sender As Object, e As EventArgs) Handles miRawRecords.Click
        If Me.OpenFeature("Raw Reports", New RawRecords, Me.miRawRecords) Then Return
    End Sub

    Private Sub miManageRooms_Click(sender As Object, e As EventArgs) Handles miManageRooms.Click
        If Me.OpenFeature("Manage Rooms", New ManageRooms, Me.miManageRooms) Then Return
    End Sub

    Private Sub miManageUsers_Click(sender As Object, e As EventArgs) Handles miManageUsers.Click
        If Me.OpenFeature("Manage Users", New ManageUsers, Me.miManageUsers) Then Return
    End Sub

    Private Sub miCloseTab_Click(sender As Object, e As EventArgs) Handles miCloseTab.Click
        Dim tab = Me.tcArea.SelectedTab
        Me.tcArea.TabPages.Remove(tab)
        Me.tabToMenu(tab).Checked = False
    End Sub

    Private Sub Main_FormClosing(sender As Object, e As FormClosingEventArgs) Handles MyBase.FormClosing
        Login.Show()
    End Sub
#End Region

#Region "Private Methods"
    ''' <summary>
    ''' 
    ''' </summary>
    ''' <param name="name"></param>
    ''' <param name="ui"></param>
    ''' <param name="menu"></param>
    ''' <returns>Return is already opened</returns>
    Private Function OpenFeature(name As String, ui As UserControl, ByRef menu As ToolStripMenuItem) As Boolean
        If menu.Checked Then Return True

        ui.Dock = DockStyle.Fill
        Dim tab As New TabPage With {.Text = name, .Padding = New Padding(0)}
        tab.Controls.Add(ui)
        Me.tcArea.TabPages.Add(tab)
        Me.tabToMenu.Add(tab, menu)
        Me.tcArea.SelectedTab = tab

        menu.Checked = True

        Return False
    End Function
#End Region
End Class
