﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class CheckInOut
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        dgRooms = New Guna.UI2.WinForms.Guna2DataGridView()
        colAction = New DataGridViewTextBoxColumn()
        colID = New DataGridViewTextBoxColumn()
        colName = New DataGridViewTextBoxColumn()
        colType = New DataGridViewTextBoxColumn()
        colPrice = New DataGridViewTextBoxColumn()
        colCheckIn = New DataGridViewTextBoxColumn()
        colCheckOut = New DataGridViewTextBoxColumn()
        lblCount = New Guna.UI2.WinForms.Guna2HtmlLabel()
        CType(dgRooms, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtSearch
        ' 
        txtSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtSearch.CustomizableEdges = CustomizableEdges1
        txtSearch.DefaultText = ""
        txtSearch.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtSearch.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtSearch.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtSearch.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtSearch.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtSearch.Font = New Font("Segoe UI", 9F)
        txtSearch.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtSearch.Location = New Point(3, 3)
        txtSearch.Name = "txtSearch"
        txtSearch.PasswordChar = ChrW(0)
        txtSearch.PlaceholderText = "Search Rooms..."
        txtSearch.SelectedText = ""
        txtSearch.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txtSearch.Size = New Size(983, 36)
        txtSearch.TabIndex = 1
        ' 
        ' dgRooms
        ' 
        dgRooms.AllowUserToAddRows = False
        dgRooms.AllowUserToDeleteRows = False
        dgRooms.AllowUserToResizeColumns = False
        dgRooms.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        dgRooms.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgRooms.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgRooms.BorderStyle = BorderStyle.FixedSingle
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.Fuchsia
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.Fuchsia
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgRooms.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgRooms.ColumnHeadersHeight = 30
        dgRooms.Columns.AddRange(New DataGridViewColumn() {colAction, colID, colName, colType, colPrice, colCheckIn, colCheckOut})
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = Color.White
        DataGridViewCellStyle4.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle4.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle4.WrapMode = DataGridViewTriState.False
        dgRooms.DefaultCellStyle = DataGridViewCellStyle4
        dgRooms.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgRooms.Location = New Point(3, 45)
        dgRooms.Name = "dgRooms"
        dgRooms.RowHeadersVisible = False
        dgRooms.Size = New Size(983, 572)
        dgRooms.TabIndex = 3
        dgRooms.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgRooms.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgRooms.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgRooms.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgRooms.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgRooms.ThemeStyle.BackColor = Color.White
        dgRooms.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgRooms.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        dgRooms.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgRooms.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dgRooms.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgRooms.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgRooms.ThemeStyle.HeaderStyle.Height = 30
        dgRooms.ThemeStyle.ReadOnly = False
        dgRooms.ThemeStyle.RowsStyle.BackColor = Color.White
        dgRooms.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgRooms.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        dgRooms.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgRooms.ThemeStyle.RowsStyle.Height = 25
        dgRooms.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgRooms.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' colAction
        ' 
        colAction.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        colAction.DividerWidth = 1
        colAction.HeaderText = "Actions"
        colAction.Name = "colAction"
        colAction.ReadOnly = True
        colAction.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' colID
        ' 
        colID.DividerWidth = 1
        colID.HeaderText = "ID"
        colID.Name = "colID"
        colID.ReadOnly = True
        ' 
        ' colName
        ' 
        colName.DividerWidth = 1
        colName.HeaderText = "Name"
        colName.Name = "colName"
        colName.ReadOnly = True
        ' 
        ' colType
        ' 
        colType.DividerWidth = 1
        colType.HeaderText = "Type"
        colType.Name = "colType"
        colType.ReadOnly = True
        ' 
        ' colPrice
        ' 
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight
        colPrice.DefaultCellStyle = DataGridViewCellStyle3
        colPrice.DividerWidth = 1
        colPrice.HeaderText = "Price"
        colPrice.Name = "colPrice"
        colPrice.ReadOnly = True
        ' 
        ' colCheckIn
        ' 
        colCheckIn.DividerWidth = 1
        colCheckIn.HeaderText = "Check In"
        colCheckIn.Name = "colCheckIn"
        colCheckIn.ReadOnly = True
        ' 
        ' colCheckOut
        ' 
        colCheckOut.HeaderText = "Check Out"
        colCheckOut.Name = "colCheckOut"
        colCheckOut.ReadOnly = True
        ' 
        ' lblCount
        ' 
        lblCount.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblCount.BackColor = Color.Transparent
        lblCount.Location = New Point(3, 623)
        lblCount.Name = "lblCount"
        lblCount.Size = New Size(49, 17)
        lblCount.TabIndex = 4
        lblCount.Text = "Count: <b>0</b>"
        ' 
        ' CheckInOut
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(lblCount)
        Controls.Add(dgRooms)
        Controls.Add(txtSearch)
        Name = "CheckInOut"
        Size = New Size(989, 643)
        CType(dgRooms, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dgRooms As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents lblCount As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents colAction As DataGridViewTextBoxColumn
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents colType As DataGridViewTextBoxColumn
    Friend WithEvents colPrice As DataGridViewTextBoxColumn
    Friend WithEvents colCheckIn As DataGridViewTextBoxColumn
    Friend WithEvents colCheckOut As DataGridViewTextBoxColumn

End Class
