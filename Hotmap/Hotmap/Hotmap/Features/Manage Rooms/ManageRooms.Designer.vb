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
        Dim DataGridViewCellStyle1 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim CustomizableEdges1 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges2 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        dgRooms = New Guna.UI2.WinForms.Guna2DataGridView()
        colEdit = New DataGridViewTextBoxColumn()
        colID = New DataGridViewTextBoxColumn()
        colName = New DataGridViewTextBoxColumn()
        colType = New DataGridViewTextBoxColumn()
        colPrice = New DataGridViewTextBoxColumn()
        colDelete = New DataGridViewTextBoxColumn()
        lblCount = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnAdd = New Guna.UI2.WinForms.Guna2Button()
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
        dgRooms.Columns.AddRange(New DataGridViewColumn() {colEdit, colID, colName, colType, colPrice, colDelete})
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.White
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle5.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        dgRooms.DefaultCellStyle = DataGridViewCellStyle5
        dgRooms.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
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
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight
        colPrice.DefaultCellStyle = DataGridViewCellStyle3
        colPrice.DividerWidth = 1
        colPrice.HeaderText = "Price"
        colPrice.Name = "colPrice"
        colPrice.ReadOnly = True
        ' 
        ' colDelete
        ' 
        colDelete.AutoSizeMode = DataGridViewAutoSizeColumnMode.None
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        colDelete.DefaultCellStyle = DataGridViewCellStyle4
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
        btnAdd.TabIndex = 7
        btnAdd.Text = "Add Room"
        ' 
        ' txtSearch
        ' 
        txtSearch.Anchor = AnchorStyles.Top Or AnchorStyles.Left Or AnchorStyles.Right
        txtSearch.BackColor = Color.Transparent
        txtSearch.Location = New Point(3, 3)
        txtSearch.Name = "txtSearch"
        txtSearch.Placeholder = "Search Rooms..."
        txtSearch.Size = New Size(644, 36)
        txtSearch.TabIndex = 8
        ' 
        ' ManageRooms
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(txtSearch)
        Controls.Add(btnAdd)
        Controls.Add(lblCount)
        Controls.Add(dgRooms)
        Name = "ManageRooms"
        Size = New Size(749, 549)
        CType(dgRooms, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents dgRooms As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents lblCount As Guna.UI2.WinForms.Guna2HtmlLabel
    Public WithEvents btnAdd As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents colEdit As DataGridViewTextBoxColumn
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents colType As DataGridViewTextBoxColumn
    Friend WithEvents colPrice As DataGridViewTextBoxColumn
    Friend WithEvents colDelete As DataGridViewTextBoxColumn
    Friend WithEvents txtSearch As SearchField

End Class
