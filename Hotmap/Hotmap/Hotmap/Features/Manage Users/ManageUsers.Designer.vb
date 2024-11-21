<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ManageUsers
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
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        btnAdd = New Guna.UI2.WinForms.Guna2Button()
        lblCount = New Guna.UI2.WinForms.Guna2HtmlLabel()
        dgUsers = New Guna.UI2.WinForms.Guna2DataGridView()
        colEdit = New DataGridViewTextBoxColumn()
        colEmployeeId = New DataGridViewTextBoxColumn()
        colFirstName = New DataGridViewTextBoxColumn()
        colLastName = New DataGridViewTextBoxColumn()
        colHireDate = New DataGridViewTextBoxColumn()
        colDateTimeAdded = New DataGridViewTextBoxColumn()
        colDelete = New DataGridViewTextBoxColumn()
        txtSearch = New SearchField()
        CType(dgUsers, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnAdd
        ' 
        btnAdd.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnAdd.BorderRadius = 10
        btnAdd.CustomizableEdges = CustomizableEdges1
        btnAdd.DisabledState.BorderColor = Color.DarkGray
        btnAdd.DisabledState.CustomBorderColor = Color.DarkGray
        btnAdd.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnAdd.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnAdd.FillColor = Color.Fuchsia
        btnAdd.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnAdd.ForeColor = Color.White
        btnAdd.Location = New Point(653, 3)
        btnAdd.Name = "btnAdd"
        btnAdd.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnAdd.Size = New Size(93, 36)
        btnAdd.TabIndex = 11
        btnAdd.Text = "Add User"
        ' 
        ' lblCount
        ' 
        lblCount.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblCount.BackColor = Color.Transparent
        lblCount.Location = New Point(3, 529)
        lblCount.Name = "lblCount"
        lblCount.Size = New Size(49, 17)
        lblCount.TabIndex = 10
        lblCount.Text = "Count: <b>0</b>"
        ' 
        ' dgUsers
        ' 
        dgUsers.AllowUserToAddRows = False
        dgUsers.AllowUserToDeleteRows = False
        dgUsers.AllowUserToResizeColumns = False
        dgUsers.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        dgUsers.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgUsers.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgUsers.BorderStyle = BorderStyle.FixedSingle
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.Fuchsia
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.Fuchsia
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgUsers.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgUsers.ColumnHeadersHeight = 30
        dgUsers.Columns.AddRange(New DataGridViewColumn() {colEdit, colEmployeeId, colFirstName, colLastName, colHireDate, colDateTimeAdded, colDelete})
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = Color.White
        DataGridViewCellStyle7.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle7.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle7.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle7.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.False
        dgUsers.DefaultCellStyle = DataGridViewCellStyle7
        dgUsers.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgUsers.Location = New Point(3, 45)
        dgUsers.Name = "dgUsers"
        dgUsers.RowHeadersVisible = False
        dgUsers.Size = New Size(743, 478)
        dgUsers.TabIndex = 9
        dgUsers.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgUsers.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgUsers.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgUsers.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgUsers.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgUsers.ThemeStyle.BackColor = Color.White
        dgUsers.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgUsers.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        dgUsers.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgUsers.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dgUsers.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgUsers.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgUsers.ThemeStyle.HeaderStyle.Height = 30
        dgUsers.ThemeStyle.ReadOnly = False
        dgUsers.ThemeStyle.RowsStyle.BackColor = Color.White
        dgUsers.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgUsers.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        dgUsers.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgUsers.ThemeStyle.RowsStyle.Height = 25
        dgUsers.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgUsers.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' colEdit
        ' 
        colEdit.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.ForeColor = Color.Fuchsia
        DataGridViewCellStyle3.SelectionForeColor = Color.Fuchsia
        colEdit.DefaultCellStyle = DataGridViewCellStyle3
        colEdit.DividerWidth = 1
        colEdit.HeaderText = "Edit"
        colEdit.Name = "colEdit"
        colEdit.ReadOnly = True
        colEdit.SortMode = DataGridViewColumnSortMode.NotSortable
        colEdit.Width = 35
        ' 
        ' colEmployeeId
        ' 
        colEmployeeId.DividerWidth = 1
        colEmployeeId.HeaderText = "Employee ID"
        colEmployeeId.Name = "colEmployeeId"
        colEmployeeId.ReadOnly = True
        ' 
        ' colFirstName
        ' 
        colFirstName.DividerWidth = 1
        colFirstName.HeaderText = "First Name"
        colFirstName.Name = "colFirstName"
        colFirstName.ReadOnly = True
        ' 
        ' colLastName
        ' 
        colLastName.DividerWidth = 1
        colLastName.HeaderText = "Last Name"
        colLastName.Name = "colLastName"
        colLastName.ReadOnly = True
        ' 
        ' colHireDate
        ' 
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleRight
        colHireDate.DefaultCellStyle = DataGridViewCellStyle4
        colHireDate.DividerWidth = 1
        colHireDate.HeaderText = "Hire Date"
        colHireDate.Name = "colHireDate"
        colHireDate.ReadOnly = True
        ' 
        ' colDateTimeAdded
        ' 
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleRight
        colDateTimeAdded.DefaultCellStyle = DataGridViewCellStyle5
        colDateTimeAdded.DividerWidth = 1
        colDateTimeAdded.HeaderText = "Date Time Added"
        colDateTimeAdded.Name = "colDateTimeAdded"
        colDateTimeAdded.ReadOnly = True
        colDateTimeAdded.SortMode = DataGridViewColumnSortMode.NotSortable
        ' 
        ' colDelete
        ' 
        colDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle6.ForeColor = Color.Maroon
        DataGridViewCellStyle6.SelectionForeColor = Color.Maroon
        colDelete.DefaultCellStyle = DataGridViewCellStyle6
        colDelete.HeaderText = "Delete"
        colDelete.Name = "colDelete"
        colDelete.ReadOnly = True
        colDelete.Width = 50
        ' 
        ' txtSearch
        ' 
        txtSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtSearch.BackColor = Color.Transparent
        txtSearch.Location = New Point(3, 3)
        txtSearch.Name = "txtSearch"
        txtSearch.Placeholder = "Search Users..."
        txtSearch.Size = New Size(644, 36)
        txtSearch.TabIndex = 12
        ' 
        ' ManageUsers
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(txtSearch)
        Controls.Add(btnAdd)
        Controls.Add(lblCount)
        Controls.Add(dgUsers)
        Name = "ManageUsers"
        Size = New Size(749, 549)
        CType(dgUsers, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Public WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblCount As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dgUsers As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents colEdit As DataGridViewTextBoxColumn
    Friend WithEvents colEmployeeId As DataGridViewTextBoxColumn
    Friend WithEvents colFirstName As DataGridViewTextBoxColumn
    Friend WithEvents colLastName As DataGridViewTextBoxColumn
    Friend WithEvents colHireDate As DataGridViewTextBoxColumn
    Friend WithEvents colDateTimeAdded As DataGridViewTextBoxColumn
    Friend WithEvents colDelete As DataGridViewTextBoxColumn
    Friend WithEvents txtSearch As SearchField

End Class
