<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RawRecords
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
        Dim DataGridViewCellStyle6 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle9 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        btnRefresh = New Guna.UI2.WinForms.Guna2Button()
        lblCount = New Guna.UI2.WinForms.Guna2HtmlLabel()
        dgRecords = New Guna.UI2.WinForms.Guna2DataGridView()
        colID = New DataGridViewTextBoxColumn()
        colEdit = New DataGridViewTextBoxColumn()
        colName = New DataGridViewTextBoxColumn()
        colType = New DataGridViewTextBoxColumn()
        colPrice = New DataGridViewTextBoxColumn()
        colCheckIn = New DataGridViewTextBoxColumn()
        colCheckOut = New DataGridViewTextBoxColumn()
        CType(dgRecords, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel1.IsSelectionEnabled = False
        Guna2HtmlLabel1.Location = New Point(3, 5)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(129, 32)
        Guna2HtmlLabel1.TabIndex = 15
        Guna2HtmlLabel1.TabStop = False
        Guna2HtmlLabel1.Text = "Raw Records"
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnRefresh.BorderRadius = 10
        btnRefresh.CustomizableEdges = CustomizableEdges3
        btnRefresh.DisabledState.BorderColor = Color.DarkGray
        btnRefresh.DisabledState.CustomBorderColor = Color.DarkGray
        btnRefresh.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnRefresh.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnRefresh.FillColor = Color.Fuchsia
        btnRefresh.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRefresh.ForeColor = Color.White
        btnRefresh.Location = New Point(653, 3)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        btnRefresh.Size = New Size(93, 36)
        btnRefresh.TabIndex = 14
        btnRefresh.Text = "Refresh"
        ' 
        ' lblCount
        ' 
        lblCount.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblCount.BackColor = Color.Transparent
        lblCount.Location = New Point(3, 529)
        lblCount.Name = "lblCount"
        lblCount.Size = New Size(49, 17)
        lblCount.TabIndex = 13
        lblCount.Text = "Count: <b>0</b>"
        ' 
        ' dgRecords
        ' 
        dgRecords.AllowUserToAddRows = False
        dgRecords.AllowUserToDeleteRows = False
        dgRecords.AllowUserToResizeColumns = False
        dgRecords.AllowUserToResizeRows = False
        DataGridViewCellStyle6.BackColor = Color.White
        dgRecords.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle6
        dgRecords.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgRecords.BorderStyle = BorderStyle.FixedSingle
        DataGridViewCellStyle7.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle7.BackColor = Color.Fuchsia
        DataGridViewCellStyle7.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle7.ForeColor = Color.White
        DataGridViewCellStyle7.SelectionBackColor = Color.Fuchsia
        DataGridViewCellStyle7.SelectionForeColor = Color.White
        DataGridViewCellStyle7.WrapMode = DataGridViewTriState.True
        dgRecords.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle7
        dgRecords.ColumnHeadersHeight = 30
        dgRecords.Columns.AddRange(New DataGridViewColumn() {colID, colEdit, colName, colType, colPrice, colCheckIn, colCheckOut})
        DataGridViewCellStyle10.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle10.BackColor = Color.White
        DataGridViewCellStyle10.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle10.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle10.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle10.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle10.WrapMode = DataGridViewTriState.False
        dgRecords.DefaultCellStyle = DataGridViewCellStyle10
        dgRecords.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgRecords.Location = New Point(3, 45)
        dgRecords.Name = "dgRecords"
        dgRecords.RowHeadersVisible = False
        dgRecords.Size = New Size(743, 478)
        dgRecords.TabIndex = 12
        dgRecords.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgRecords.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgRecords.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgRecords.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgRecords.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgRecords.ThemeStyle.BackColor = Color.White
        dgRecords.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgRecords.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        dgRecords.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgRecords.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dgRecords.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgRecords.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgRecords.ThemeStyle.HeaderStyle.Height = 30
        dgRecords.ThemeStyle.ReadOnly = False
        dgRecords.ThemeStyle.RowsStyle.BackColor = Color.White
        dgRecords.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgRecords.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        dgRecords.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgRecords.ThemeStyle.RowsStyle.Height = 25
        dgRecords.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgRecords.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' colID
        ' 
        colID.HeaderText = "ID"
        colID.Name = "colID"
        colID.ReadOnly = True
        colID.Visible = False
        ' 
        ' colEdit
        ' 
        colEdit.DividerWidth = 1
        colEdit.HeaderText = "Room ID"
        colEdit.Name = "colEdit"
        colEdit.ReadOnly = True
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
        DataGridViewCellStyle8.Alignment = DataGridViewContentAlignment.MiddleRight
        colPrice.DefaultCellStyle = DataGridViewCellStyle8
        colPrice.DividerWidth = 1
        colPrice.HeaderText = "Price"
        colPrice.Name = "colPrice"
        colPrice.ReadOnly = True
        ' 
        ' colCheckIn
        ' 
        DataGridViewCellStyle9.Alignment = DataGridViewContentAlignment.MiddleCenter
        colCheckIn.DefaultCellStyle = DataGridViewCellStyle9
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
        ' RawRecords
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Guna2HtmlLabel1)
        Controls.Add(btnRefresh)
        Controls.Add(lblCount)
        Controls.Add(dgRecords)
        Name = "RawRecords"
        Size = New Size(749, 549)
        CType(dgRecords, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Public WithEvents btnRefresh As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblCount As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dgRecords As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents colID As DataGridViewTextBoxColumn
    Friend WithEvents colEdit As DataGridViewTextBoxColumn
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents colType As DataGridViewTextBoxColumn
    Friend WithEvents colPrice As DataGridViewTextBoxColumn
    Friend WithEvents colCheckIn As DataGridViewTextBoxColumn
    Friend WithEvents colCheckOut As DataGridViewTextBoxColumn

End Class
