<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PrimaryButton
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
        Button = New Guna.UI2.WinForms.Guna2Button()
        SuspendLayout()
        ' 
        ' Button
        ' 
        Button.BorderRadius = 10
        Button.CustomizableEdges = CustomizableEdges1
        Button.DisabledState.BorderColor = Color.DarkGray
        Button.DisabledState.CustomBorderColor = Color.DarkGray
        Button.DisabledState.FillColor = Color.FromArgb(CByte(169), CByte(169), CByte(169))
        Button.DisabledState.ForeColor = Color.FromArgb(CByte(141), CByte(141), CByte(141))
        Button.Dock = DockStyle.Fill
        Button.FillColor = Theme.PrimaryColor
        Button.Font = New Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        Button.ForeColor = Color.White
        Button.Location = New Point(0, 0)
        Button.Name = "Button"
        Button.ShadowDecoration.CustomizableEdges = CustomizableEdges2
        Button.Size = New Size(180, 45)
        Button.TabIndex = 0
        Button.Text = "Action"
        ' 
        ' PrimaryButton
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.Transparent
        Controls.Add(Button)
        Name = "PrimaryButton"
        Size = New Size(180, 45)
        ResumeLayout(False)
    End Sub

    Public WithEvents Button As Guna.UI2.WinForms.Guna2Button

End Class
