<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        dgRooms = New Guna.UI2.WinForms.Guna2DataGridView()
        colAction = New DataGridViewTextBoxColumn()
        colID = New DataGridViewTextBoxColumn()
        colName = New DataGridViewTextBoxColumn()
        colType = New DataGridViewTextBoxColumn()
        colPrice = New DataGridViewTextBoxColumn()
        colCheckIn = New DataGridViewTextBoxColumn()
        colCheckOut = New DataGridViewTextBoxColumn()
        lblCount = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txtSearch = New SearchField()
        CType(dgRooms, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' dgRooms
        ' 
        dgRooms.AllowUserToAddRows = False
        dgRooms.AllowUserToDeleteRows = False
        dgRooms.AllowUserToResizeColumns = False
        dgRooms.AllowUserToResizeRows = False
        DataGridViewCellStyle5.BackColor = Color.White
        dgRooms.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle5
        dgRooms.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgRooms.BorderStyle = BorderStyle.FixedSingle
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.Fuchsia
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle6.ForeColor = Color.White
        DataGridViewCellStyle6.SelectionBackColor = Color.Fuchsia
        DataGridViewCellStyle6.SelectionForeColor = Color.White
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.True
        dgRooms.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle6
        dgRooms.ColumnHeadersHeight = 30
        dgRooms.Columns.AddRange(New DataGridViewColumn() {colAction, colID, colName, colType, colPrice, colCheckIn, colCheckOut})
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = Color.White
        DataGridViewCellStyle8.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle8.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle8.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle8.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle8.WrapMode = DataGridViewTriState.False
        dgRooms.DefaultCellStyle = DataGridViewCellStyle8
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
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleRight
        colPrice.DefaultCellStyle = DataGridViewCellStyle7
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
        ' txtSearch
        ' 
        txtSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtSearch.BackColor = Color.Transparent
        txtSearch.Location = New Point(3, 3)
        txtSearch.Name = "txtSearch"
        txtSearch.Placeholder = "Search Rooms..."
        txtSearch.Size = New Size(983, 36)
        txtSearch.TabIndex = 5
        ' 
        ' CheckInOut
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(txtSearch)
        Controls.Add(lblCount)
        Controls.Add(dgRooms)
        Name = "CheckInOut"
        Size = New Size(989, 643)
        CType(dgRooms, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents dgRooms As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents lblCount As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents colAction As DataGridViewTextBoxColumn
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents colType As DataGridViewTextBoxColumn
    Friend WithEvents colPrice As DataGridViewTextBoxColumn
    Friend WithEvents colCheckIn As DataGridViewTextBoxColumn
    Friend WithEvents colCheckOut As DataGridViewTextBoxColumn
    Friend WithEvents txtSearch As SearchField

End Class
