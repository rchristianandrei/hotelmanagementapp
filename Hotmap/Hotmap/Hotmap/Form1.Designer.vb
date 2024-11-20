<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        msSystemAdmin = New MenuStrip()
        SystemAdminToolStripMenuItem = New ToolStripMenuItem()
        miManageRooms = New ToolStripMenuItem()
        tcArea = New TabControl()
        ctmTab = New Guna.UI2.WinForms.Guna2ContextMenuStrip()
        miCloseTab = New ToolStripMenuItem()
        msSystemAdmin.SuspendLayout()
        ctmTab.SuspendLayout()
        SuspendLayout()
        ' 
        ' msSystemAdmin
        ' 
        msSystemAdmin.Items.AddRange(New ToolStripItem() {SystemAdminToolStripMenuItem})
        msSystemAdmin.Location = New Point(0, 0)
        msSystemAdmin.Name = "msSystemAdmin"
        msSystemAdmin.Size = New Size(800, 24)
        msSystemAdmin.TabIndex = 0
        msSystemAdmin.Text = "MenuStrip1"
        ' 
        ' SystemAdminToolStripMenuItem
        ' 
        SystemAdminToolStripMenuItem.DropDownItems.AddRange(New ToolStripItem() {miManageRooms})
        SystemAdminToolStripMenuItem.Name = "SystemAdminToolStripMenuItem"
        SystemAdminToolStripMenuItem.Size = New Size(96, 20)
        SystemAdminToolStripMenuItem.Text = "System Admin"
        ' 
        ' miManageRooms
        ' 
        miManageRooms.Name = "miManageRooms"
        miManageRooms.Size = New Size(157, 22)
        miManageRooms.Text = "Manage Rooms"
        ' 
        ' tcArea
        ' 
        tcArea.ContextMenuStrip = ctmTab
        tcArea.Dock = DockStyle.Fill
        tcArea.Location = New Point(0, 24)
        tcArea.Name = "tcArea"
        tcArea.SelectedIndex = 0
        tcArea.Size = New Size(800, 426)
        tcArea.TabIndex = 1
        ' 
        ' ctmTab
        ' 
        ctmTab.Items.AddRange(New ToolStripItem() {miCloseTab})
        ctmTab.Name = "Guna2ContextMenuStrip1"
        ctmTab.RenderStyle.ArrowColor = Color.FromArgb(CByte(151), CByte(143), CByte(255))
        ctmTab.RenderStyle.BorderColor = Color.Gainsboro
        ctmTab.RenderStyle.ColorTable = Nothing
        ctmTab.RenderStyle.RoundedEdges = True
        ctmTab.RenderStyle.SelectionArrowColor = Color.White
        ctmTab.RenderStyle.SelectionBackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        ctmTab.RenderStyle.SelectionForeColor = Color.White
        ctmTab.RenderStyle.SeparatorColor = Color.Gainsboro
        ctmTab.RenderStyle.TextRenderingHint = Drawing.Text.TextRenderingHint.SystemDefault
        ctmTab.Size = New Size(146, 26)
        ' 
        ' miCloseTab
        ' 
        miCloseTab.Name = "miCloseTab"
        miCloseTab.Size = New Size(145, 22)
        miCloseTab.Text = "Close Feature"
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(800, 450)
        Controls.Add(tcArea)
        Controls.Add(msSystemAdmin)
        MainMenuStrip = msSystemAdmin
        Name = "Form1"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Hotmap"
        msSystemAdmin.ResumeLayout(False)
        msSystemAdmin.PerformLayout()
        ctmTab.ResumeLayout(False)
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents msSystemAdmin As MenuStrip
    Friend WithEvents SystemAdminToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents miManageRooms As ToolStripMenuItem
    Friend WithEvents tcArea As TabControl
    Friend WithEvents ctmTab As Guna.UI2.WinForms.Guna2ContextMenuStrip
    Friend WithEvents miCloseTab As ToolStripMenuItem

End Class
