<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RealtimeReports
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
        Dim DataGridViewCellStyle5 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As DataGridViewCellStyle = New DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As DataGridViewCellStyle = New DataGridViewCellStyle()
        btnRefresh = New Guna.UI2.WinForms.Guna2Button()
        lblCount = New Guna.UI2.WinForms.Guna2HtmlLabel()
        dgRealtime = New Guna.UI2.WinForms.Guna2DataGridView()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        colEdit = New DataGridViewTextBoxColumn()
        colName = New DataGridViewTextBoxColumn()
        colType = New DataGridViewTextBoxColumn()
        colPrice = New DataGridViewTextBoxColumn()
        colSales = New DataGridViewTextBoxColumn()
        colTotal = New DataGridViewTextBoxColumn()
        CType(dgRealtime, ComponentModel.ISupportInitialize).BeginInit()
        SuspendLayout()
        ' 
        ' btnRefresh
        ' 
        btnRefresh.Anchor = AnchorStyles.Top Or AnchorStyles.Right
        btnRefresh.BorderRadius = 10
        btnRefresh.CustomizableEdges = CustomizableEdges1
        btnRefresh.DisabledState.BorderColor = Color.DarkGray
        btnRefresh.DisabledState.CustomBorderColor = Color.DarkGray
        btnRefresh.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnRefresh.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnRefresh.FillColor = Color.Fuchsia
        btnRefresh.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnRefresh.ForeColor = Color.White
        btnRefresh.Location = New Point(653, 3)
        btnRefresh.Name = "btnRefresh"
        btnRefresh.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnRefresh.Size = New Size(93, 36)
        btnRefresh.TabIndex = 10
        btnRefresh.Text = "Refresh"
        ' 
        ' lblCount
        ' 
        lblCount.Anchor = AnchorStyles.Bottom Or AnchorStyles.Left
        lblCount.BackColor = Color.Transparent
        lblCount.Location = New Point(3, 529)
        lblCount.Name = "lblCount"
        lblCount.Size = New Size(49, 17)
        lblCount.TabIndex = 9
        lblCount.Text = "Count: <b>0</b>"
        ' 
        ' dgRealtime
        ' 
        dgRealtime.AllowUserToAddRows = False
        dgRealtime.AllowUserToDeleteRows = False
        dgRealtime.AllowUserToResizeColumns = False
        dgRealtime.AllowUserToResizeRows = False
        DataGridViewCellStyle1.BackColor = Color.White
        dgRealtime.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        dgRealtime.Anchor = AnchorStyles.Top Or AnchorStyles.Bottom Or AnchorStyles.Left Or AnchorStyles.Right
        dgRealtime.BorderStyle = BorderStyle.FixedSingle
        DataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = Color.Fuchsia
        DataGridViewCellStyle2.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        DataGridViewCellStyle2.ForeColor = Color.White
        DataGridViewCellStyle2.SelectionBackColor = Color.Fuchsia
        DataGridViewCellStyle2.SelectionForeColor = Color.White
        DataGridViewCellStyle2.WrapMode = DataGridViewTriState.True
        dgRealtime.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        dgRealtime.ColumnHeadersHeight = 30
        dgRealtime.Columns.AddRange(New DataGridViewColumn() {colEdit, colName, colType, colPrice, colSales, colTotal})
        DataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = Color.White
        DataGridViewCellStyle5.Font = New Font("Segoe UI", 9F)
        DataGridViewCellStyle5.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        DataGridViewCellStyle5.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        DataGridViewCellStyle5.WrapMode = DataGridViewTriState.False
        dgRealtime.DefaultCellStyle = DataGridViewCellStyle5
        dgRealtime.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgRealtime.Location = New Point(3, 45)
        dgRealtime.Name = "dgRealtime"
        dgRealtime.RowHeadersVisible = False
        dgRealtime.Size = New Size(743, 478)
        dgRealtime.TabIndex = 8
        dgRealtime.ThemeStyle.AlternatingRowsStyle.BackColor = Color.White
        dgRealtime.ThemeStyle.AlternatingRowsStyle.Font = Nothing
        dgRealtime.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty
        dgRealtime.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty
        dgRealtime.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty
        dgRealtime.ThemeStyle.BackColor = Color.White
        dgRealtime.ThemeStyle.GridColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgRealtime.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(CByte(100), CByte(88), CByte(255))
        dgRealtime.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.None
        dgRealtime.ThemeStyle.HeaderStyle.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        dgRealtime.ThemeStyle.HeaderStyle.ForeColor = Color.White
        dgRealtime.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        dgRealtime.ThemeStyle.HeaderStyle.Height = 30
        dgRealtime.ThemeStyle.ReadOnly = False
        dgRealtime.ThemeStyle.RowsStyle.BackColor = Color.White
        dgRealtime.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgRealtime.ThemeStyle.RowsStyle.Font = New Font("Segoe UI", 9F)
        dgRealtime.ThemeStyle.RowsStyle.ForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        dgRealtime.ThemeStyle.RowsStyle.Height = 25
        dgRealtime.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(CByte(231), CByte(229), CByte(255))
        dgRealtime.ThemeStyle.RowsStyle.SelectionForeColor = Color.FromArgb(CByte(71), CByte(69), CByte(94))
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Font = New Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel1.IsSelectionEnabled = False
        Guna2HtmlLabel1.Location = New Point(3, 5)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(171, 32)
        Guna2HtmlLabel1.TabIndex = 11
        Guna2HtmlLabel1.TabStop = False
        Guna2HtmlLabel1.Text = "Realtime Reports"
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
        DataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleRight
        colPrice.DefaultCellStyle = DataGridViewCellStyle3
        colPrice.DividerWidth = 1
        colPrice.HeaderText = "Price"
        colPrice.Name = "colPrice"
        colPrice.ReadOnly = True
        ' 
        ' colSales
        ' 
        DataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter
        colSales.DefaultCellStyle = DataGridViewCellStyle4
        colSales.DividerWidth = 1
        colSales.HeaderText = "Sales"
        colSales.Name = "colSales"
        colSales.ReadOnly = True
        ' 
        ' colTotal
        ' 
        colTotal.HeaderText = "Total"
        colTotal.Name = "colTotal"
        colTotal.ReadOnly = True
        ' 
        ' RealtimeReports
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        Controls.Add(Guna2HtmlLabel1)
        Controls.Add(btnRefresh)
        Controls.Add(lblCount)
        Controls.Add(dgRealtime)
        Name = "RealtimeReports"
        Size = New Size(749, 549)
        CType(dgRealtime, ComponentModel.ISupportInitialize).EndInit()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Public WithEvents btnRefresh As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblCount As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents dgRealtime As Guna.UI2.WinForms.Guna2DataGridView
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents colEdit As DataGridViewTextBoxColumn
    Friend WithEvents colName As DataGridViewTextBoxColumn
    Friend WithEvents colType As DataGridViewTextBoxColumn
    Friend WithEvents colPrice As DataGridViewTextBoxColumn
    Friend WithEvents colSales As DataGridViewTextBoxColumn
    Friend WithEvents colTotal As DataGridViewTextBoxColumn

End Class
