<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddRoom
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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
        Dim CustomizableEdges3 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges4 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges5 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges6 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges7 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges8 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        txtName = New Guna.UI2.WinForms.Guna2TextBox()
        lblName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        Guna2HtmlLabel1 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txtType = New Guna.UI2.WinForms.Guna2TextBox()
        Guna2HtmlLabel2 = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txtPrice = New Guna.UI2.WinForms.Guna2TextBox()
        btnSave = New Guna.UI2.WinForms.Guna2Button()
        SuspendLayout()
        ' 
        ' txtName
        ' 
        txtName.CustomizableEdges = CustomizableEdges1
        txtName.DefaultText = ""
        txtName.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtName.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtName.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtName.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtName.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtName.Font = New Font("Segoe UI", 9F)
        txtName.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtName.Location = New Point(142, 24)
        txtName.MaxLength = 45
        txtName.Name = "txtName"
        txtName.PasswordChar = ChrW(0)
        txtName.PlaceholderText = ""
        txtName.SelectedText = ""
        txtName.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        txtName.Size = New Size(200, 36)
        txtName.TabIndex = 0
        ' 
        ' lblName
        ' 
        lblName.BackColor = Color.Transparent
        lblName.Enabled = False
        lblName.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblName.IsSelectionEnabled = False
        lblName.Location = New Point(93, 31)
        lblName.Name = "lblName"
        lblName.Size = New Size(46, 22)
        lblName.TabIndex = 1
        lblName.TabStop = False
        lblName.Text = "Name:"
        ' 
        ' Guna2HtmlLabel1
        ' 
        Guna2HtmlLabel1.BackColor = Color.Transparent
        Guna2HtmlLabel1.Enabled = False
        Guna2HtmlLabel1.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel1.IsSelectionEnabled = False
        Guna2HtmlLabel1.Location = New Point(101, 73)
        Guna2HtmlLabel1.Name = "Guna2HtmlLabel1"
        Guna2HtmlLabel1.Size = New Size(38, 22)
        Guna2HtmlLabel1.TabIndex = 3
        Guna2HtmlLabel1.TabStop = False
        Guna2HtmlLabel1.Text = "Type:"
        ' 
        ' txtType
        ' 
        txtType.CustomizableEdges = CustomizableEdges3
        txtType.DefaultText = ""
        txtType.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtType.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtType.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtType.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtType.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtType.Font = New Font("Segoe UI", 9F)
        txtType.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtType.Location = New Point(142, 66)
        txtType.MaxLength = 45
        txtType.Name = "txtType"
        txtType.PasswordChar = ChrW(0)
        txtType.PlaceholderText = ""
        txtType.SelectedText = ""
        txtType.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        txtType.Size = New Size(200, 36)
        txtType.TabIndex = 1
        ' 
        ' Guna2HtmlLabel2
        ' 
        Guna2HtmlLabel2.BackColor = Color.Transparent
        Guna2HtmlLabel2.Enabled = False
        Guna2HtmlLabel2.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        Guna2HtmlLabel2.IsSelectionEnabled = False
        Guna2HtmlLabel2.Location = New Point(101, 115)
        Guna2HtmlLabel2.Name = "Guna2HtmlLabel2"
        Guna2HtmlLabel2.Size = New Size(38, 22)
        Guna2HtmlLabel2.TabIndex = 5
        Guna2HtmlLabel2.TabStop = False
        Guna2HtmlLabel2.Text = "Price:"
        ' 
        ' txtPrice
        ' 
        txtPrice.CustomizableEdges = CustomizableEdges5
        txtPrice.DefaultText = ""
        txtPrice.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtPrice.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtPrice.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtPrice.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtPrice.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtPrice.Font = New Font("Segoe UI", 9F)
        txtPrice.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtPrice.Location = New Point(142, 108)
        txtPrice.MaxLength = 45
        txtPrice.Name = "txtPrice"
        txtPrice.PasswordChar = ChrW(0)
        txtPrice.PlaceholderText = ""
        txtPrice.SelectedText = ""
        txtPrice.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        txtPrice.Size = New Size(200, 36)
        txtPrice.TabIndex = 2
        ' 
        ' btnSave
        ' 
        btnSave.BorderRadius = 10
        btnSave.CustomizableEdges = CustomizableEdges7
        btnSave.DisabledState.BorderColor = Color.DarkGray
        btnSave.DisabledState.CustomBorderColor = Color.DarkGray
        btnSave.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSave.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnSave.FillColor = Color.Fuchsia
        btnSave.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(127, 159)
        btnSave.Name = "btnSave"
        btnSave.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        btnSave.Size = New Size(180, 45)
        btnSave.TabIndex = 6
        btnSave.Text = "Save Room"
        ' 
        ' AddRoom
        ' 
        AcceptButton = btnSave
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(434, 232)
        Controls.Add(btnSave)
        Controls.Add(Guna2HtmlLabel2)
        Controls.Add(txtPrice)
        Controls.Add(Guna2HtmlLabel1)
        Controls.Add(txtType)
        Controls.Add(lblName)
        Controls.Add(txtName)
        DoubleBuffered = True
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "AddRoom"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add Room"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents Guna2HtmlLabel1 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtType As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents Guna2HtmlLabel2 As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtPrice As Guna.UI2.WinForms.Guna2TextBox
    Public WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
End Class
