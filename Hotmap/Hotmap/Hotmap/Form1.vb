Public Class Form1

#Region "Fields"
    Private ReadOnly tabToMenu As New Dictionary(Of TabPage, ToolStripMenuItem)
#End Region

#Region "Event Handlers"
    Private Sub miManageRooms_Click(sender As Object, e As EventArgs) Handles miManageRooms.Click
        If Me.miManageRooms.Checked Then Return

        Me.OpenFeature("Manage Rooms", New ManageRooms, Me.miManageRooms)

        Me.miManageRooms.Checked = True
    End Sub

    Private Sub miCloseTab_Click(sender As Object, e As EventArgs) Handles miCloseTab.Click
        Dim tab = Me.tcArea.SelectedTab
        Me.tcArea.TabPages.Remove(tab)
        Me.tabToMenu(tab).Checked = False
    End Sub
#End Region

#Region "Private Methods"
    Private Sub OpenFeature(name As String, ui As UserControl, menu As ToolStripMenuItem)
        ui.Dock = DockStyle.Fill
        Dim tab As New TabPage With {.Text = name, .Padding = New Padding(0)}
        tab.Controls.Add(ui)
        Me.tcArea.TabPages.Add(tab)
        Me.tabToMenu.Add(tab, menu)
    End Sub
#End Region
End Class
