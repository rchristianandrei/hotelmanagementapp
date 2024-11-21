<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddUser
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
        Dim CustomizableEdges9 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        Dim CustomizableEdges10 As Guna.UI2.WinForms.Suite.CustomizableEdges = New Guna.UI2.WinForms.Suite.CustomizableEdges()
        btnSave = New Guna.UI2.WinForms.Guna2Button()
        lblHireDate = New Guna.UI2.WinForms.Guna2HtmlLabel()
        lblLastName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txtLastName = New Guna.UI2.WinForms.Guna2TextBox()
        lblFirstName = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txtFirstName = New Guna.UI2.WinForms.Guna2TextBox()
        lblEID = New Guna.UI2.WinForms.Guna2HtmlLabel()
        txtEID = New Guna.UI2.WinForms.Guna2TextBox()
        dtpHireDate = New Guna.UI2.WinForms.Guna2DateTimePicker()
        SuspendLayout()
        ' 
        ' btnSave
        ' 
        btnSave.BorderRadius = 10
        btnSave.CustomizableEdges = CustomizableEdges1
        btnSave.DisabledState.BorderColor = Color.DarkGray
        btnSave.DisabledState.CustomBorderColor = Color.DarkGray
        btnSave.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        btnSave.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        btnSave.FillColor = Color.Fuchsia
        btnSave.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnSave.ForeColor = Color.White
        btnSave.Location = New Point(101, 207)
        btnSave.Name = "btnSave"
        btnSave.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        btnSave.Size = New Size(180, 45)
        btnSave.TabIndex = 10
        btnSave.Text = "Save User"
        ' 
        ' lblHireDate
        ' 
        lblHireDate.BackColor = Color.Transparent
        lblHireDate.Enabled = False
        lblHireDate.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblHireDate.IsSelectionEnabled = False
        lblHireDate.Location = New Point(58, 163)
        lblHireDate.Name = "lblHireDate"
        lblHireDate.Size = New Size(70, 22)
        lblHireDate.TabIndex = 12
        lblHireDate.TabStop = False
        lblHireDate.Text = "Hire Date:"
        ' 
        ' lblLastName
        ' 
        lblLastName.BackColor = Color.Transparent
        lblLastName.Enabled = False
        lblLastName.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblLastName.IsSelectionEnabled = False
        lblLastName.Location = New Point(52, 121)
        lblLastName.Name = "lblLastName"
        lblLastName.Size = New Size(76, 22)
        lblLastName.TabIndex = 11
        lblLastName.TabStop = False
        lblLastName.Text = "Last Name:"
        ' 
        ' txtLastName
        ' 
        txtLastName.CustomizableEdges = CustomizableEdges3
        txtLastName.DefaultText = ""
        txtLastName.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtLastName.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtLastName.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtLastName.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtLastName.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtLastName.Font = New Font("Segoe UI", 9F)
        txtLastName.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtLastName.Location = New Point(131, 114)
        txtLastName.MaxLength = 45
        txtLastName.Name = "txtLastName"
        txtLastName.PasswordChar = ChrW(0)
        txtLastName.PlaceholderText = ""
        txtLastName.SelectedText = ""
        txtLastName.ShadowDecoration.CustomizableEdges = CustomizableEdges4
        txtLastName.Size = New Size(200, 36)
        txtLastName.TabIndex = 2
        ' 
        ' lblFirstName
        ' 
        lblFirstName.BackColor = Color.Transparent
        lblFirstName.Enabled = False
        lblFirstName.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblFirstName.IsSelectionEnabled = False
        lblFirstName.Location = New Point(51, 79)
        lblFirstName.Name = "lblFirstName"
        lblFirstName.Size = New Size(77, 22)
        lblFirstName.TabIndex = 9
        lblFirstName.TabStop = False
        lblFirstName.Text = "First Name:"
        ' 
        ' txtFirstName
        ' 
        txtFirstName.CustomizableEdges = CustomizableEdges5
        txtFirstName.DefaultText = ""
        txtFirstName.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtFirstName.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtFirstName.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtFirstName.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtFirstName.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtFirstName.Font = New Font("Segoe UI", 9F)
        txtFirstName.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtFirstName.Location = New Point(131, 72)
        txtFirstName.MaxLength = 45
        txtFirstName.Name = "txtFirstName"
        txtFirstName.PasswordChar = ChrW(0)
        txtFirstName.PlaceholderText = ""
        txtFirstName.SelectedText = ""
        txtFirstName.ShadowDecoration.CustomizableEdges = CustomizableEdges6
        txtFirstName.Size = New Size(200, 36)
        txtFirstName.TabIndex = 1
        ' 
        ' lblEID
        ' 
        lblEID.BackColor = Color.Transparent
        lblEID.Enabled = False
        lblEID.Font = New Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblEID.IsSelectionEnabled = False
        lblEID.Location = New Point(99, 37)
        lblEID.Name = "lblEID"
        lblEID.Size = New Size(29, 22)
        lblEID.TabIndex = 15
        lblEID.TabStop = False
        lblEID.Text = "EID:"
        ' 
        ' txtEID
        ' 
        txtEID.CustomizableEdges = CustomizableEdges7
        txtEID.DefaultText = ""
        txtEID.DisabledState.BorderColor = Color.FromArgb(CByte(208), CByte(208), CByte(208))
        txtEID.DisabledState.FillColor = Color.FromArgb(CByte(226), CByte(226), CByte(226))
        txtEID.DisabledState.ForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtEID.DisabledState.PlaceholderForeColor = Color.FromArgb(CByte(138), CByte(138), CByte(138))
        txtEID.FocusedState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtEID.Font = New Font("Segoe UI", 9F)
        txtEID.HoverState.BorderColor = Color.FromArgb(CByte(94), CByte(148), CByte(255))
        txtEID.Location = New Point(131, 30)
        txtEID.MaxLength = 20
        txtEID.Name = "txtEID"
        txtEID.PasswordChar = ChrW(0)
        txtEID.PlaceholderText = ""
        txtEID.SelectedText = ""
        txtEID.ShadowDecoration.CustomizableEdges = CustomizableEdges8
        txtEID.Size = New Size(200, 36)
        txtEID.TabIndex = 0
        ' 
        ' dtpHireDate
        ' 
        dtpHireDate.Checked = True
        dtpHireDate.CustomizableEdges = CustomizableEdges9
        dtpHireDate.FillColor = Color.White
        dtpHireDate.Font = New Font("Segoe UI", 9F)
        dtpHireDate.Format = DateTimePickerFormat.Short
        dtpHireDate.Location = New Point(131, 156)
        dtpHireDate.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        dtpHireDate.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        dtpHireDate.Name = "dtpHireDate"
        dtpHireDate.ShadowDecoration.CustomizableEdges = CustomizableEdges10
        dtpHireDate.Size = New Size(200, 36)
        dtpHireDate.TabIndex = 3
        dtpHireDate.Value = New Date(2024, 11, 21, 23, 56, 36, 398)
        ' 
        ' AddUser
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(383, 265)
        Controls.Add(dtpHireDate)
        Controls.Add(lblEID)
        Controls.Add(txtEID)
        Controls.Add(btnSave)
        Controls.Add(lblHireDate)
        Controls.Add(lblLastName)
        Controls.Add(txtLastName)
        Controls.Add(lblFirstName)
        Controls.Add(txtFirstName)
        FormBorderStyle = FormBorderStyle.FixedDialog
        MaximizeBox = False
        Name = "AddUser"
        StartPosition = FormStartPosition.CenterScreen
        Text = "Add User"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Public WithEvents btnSave As Guna.UI2.WinForms.Guna2Button
    Friend WithEvents lblHireDate As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents lblLastName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtLastName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblFirstName As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtFirstName As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents lblEID As Guna.UI2.WinForms.Guna2HtmlLabel
    Friend WithEvents txtEID As Guna.UI2.WinForms.Guna2TextBox
    Friend WithEvents dtpHireDate As Guna.UI2.WinForms.Guna2DateTimePicker
End Class
