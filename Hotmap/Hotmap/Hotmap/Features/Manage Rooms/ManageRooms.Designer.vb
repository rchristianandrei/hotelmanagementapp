<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageRooms
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        txtSearch = New Guna.UI2.WinForms.Guna2TextBox()
        dgRooms = New Guna.UI2.WinForms.Guna2DataGridView()
        colEdit = New DataGridViewTextBoxColumn()
        colID = New DataGridViewTextBoxColumn()
        colName = New DataGridViewTextBoxColumn()
        colType = New DataGridViewTextBoxColumn()
        colPrice = New DataGridViewTextBoxColumn()
        colDelete = New DataGridViewTextBoxColumn()
        lblCount = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnAdd = New PrimaryButton()
        CType(dgRooms, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' txtSearch
        ' 
        txtSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtSearch.CustomizableEdges = CustomizableEdges3
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
        txtSearch.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        txtSearch.Size = New Size(644, 36)
        txtSearch.TabIndex = 0
        ' 
        ' dgRooms
        ' 
        dgRooms.AllowUserToAddRows = False
        dgRooms.AllowUserToDeleteRows = False
        dgRooms.AllowUserToResizeColumns = False
        dgRooms.AllowUserToResizeRows = False
        DataGridViewCellStyle4.BackColor = Color.White
        dgRooms.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle4
        dgRooms.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Theme.PrimaryColor
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle5.ForeColor = Color.White
        DataGridViewCellStyle5.SelectionBackColor = Color.DarkViolet
        DataGridViewCellStyle5.SelectionForeColor = Color.White
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.True
        dgRooms.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        dgRooms.ColumnHeadersHeight = 30
        dgRooms.Columns.AddRange(New DataGridViewColumn() {colEdit, colID, colName, colType, colPrice, colDelete})
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle6.BackColor = Color.White
        DataGridViewCellStyle6.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle6.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle6.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle6.WrapMode = DataGridViewTriState.False
        dgRooms.DefaultCellStyle = DataGridViewCellStyle6
        dgRooms.GridColor = Color.Black
        dgRooms.Location = New Point(3, 45)
        dgRooms.Name = "dgRooms"
        dgRooms.RowHeadersVisible = False
        dgRooms.Size = New Size(743, 478)
        dgRooms.TabIndex = 2
        dgRooms.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgRooms.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgRooms.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgRooms.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgRooms.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgRooms.ThemeStyle.BackColor = Color.White
        dgRooms.ThemeStyle.GridColor = Color.Black
        dgRooms.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        dgRooms.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgRooms.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F)
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
        ' colEdit
        ' 
        colEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        colEdit.DividerWidth = 1
        colEdit.HeaderText = "Edit"
        colEdit.Name = "colEdit"
        colEdit.ReadOnly = True
        colEdit.SortMode = DataGridViewColumnSortMode.NotSortable
        colEdit.Width = 35
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
        colPrice.DividerWidth = 1
        colPrice.HeaderText = "Price"
        colPrice.Name = "colPrice"
        colPrice.ReadOnly = True
        ' 
        ' colDelete
        ' 
        colDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        colDelete.HeaderText = "Delete"
        colDelete.Name = "colDelete"
        colDelete.ReadOnly = True
        colDelete.SortMode = DataGridViewColumnSortMode.NotSortable
        colDelete.Width = 50
        ' 
        ' lblCount
        ' 
        lblCount.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblCount.BackColor = Color.Transparent
        lblCount.Location = New Point(3, 529)
        lblCount.Name = "lblCount"
        lblCount.Size = New Size(49, 17)
        lblCount.TabIndex = 3
        lblCount.Text = "Count: <b>0</b>"
        ' 
        ' btnAdd
        ' 
        btnAdd.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAdd.BackColor = Color.Transparent
        btnAdd.Location = New Point(653, 3)
        btnAdd.Name = "btnAdd"
        btnAdd.Size = New Size(93, 36)
        btnAdd.TabIndex = 4
        ' 
        ' ManageRooms
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(btnAdd)
        Controls.Add(lblCount)
        Controls.Add(dgRooms)
        Controls.Add(txtSearch)
        Name = "ManageRooms"
        Size = New Size(749, 549)
        CType(dgRooms, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtSearch As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dgRooms As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents lblCount As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents colEdit As DataGridViewTextBoxColumn
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents colType As DataGridViewTextBoxColumn
    Friend WithEvents colPrice As DataGridViewTextBoxColumn
    Friend WithEvents colDelete As DataGridViewTextBoxColumn
    Friend WithEvents btnAdd As PrimaryButton

End Class
