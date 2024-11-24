Public Class AddUser

#Region "Fields / Objects"
    Private ReadOnly usersRepo As New UsersRepo
#End Region

#Region "Properties"
    Public Property User As UserModel
#End Region

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.dtpHireDate.Value = Date.Now
    End Sub

#Region "Event Handlers"
    Private Sub AddUser_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Not Me.Visible Or Me.User Is Nothing Then Return

        Me.txtEID.Text = Me.User.EID
        Me.txtEID.Enabled = False
        Me.txtFirstName.Text = Me.User.FirstName
        Me.txtLastName.Text = Me.User.LastName
        Me.dtpHireDate.Text = Me.User.HireDate
    End Sub

    Private Async Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim errorMessage = "Please input valid values on the following fields:"

        ' Validate Employee ID
        Dim idError = String.IsNullOrWhiteSpace(txtEID.Text)
        If idError Then errorMessage += $"{vbCrLf}Employee ID"

        ' Validate First name
        Dim firstNameError = String.IsNullOrWhiteSpace(txtFirstName.Text)
        If firstNameError Then errorMessage += $"{vbCrLf}First Name"

        ' Validate Last Name
        Dim lastNameError = String.IsNullOrWhiteSpace(txtLastName.Text)
        If lastNameError Then errorMessage += $"{vbCrLf}LastName"

        If idError Or firstNameError Or lastNameError Then
            MessageBox.Show(errorMessage, "Invalid Values", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Me.User Is Nothing Then Me.User = New UserModel

        Me.User.EID = Me.txtEID.Text
        Me.User.FirstName = Me.txtFirstName.Text
        Me.User.LastName = Me.txtLastName.Text
        Me.User.HireDate = Me.dtpHireDate.Value

        Try
            Await Me.usersRepo.HttpPost(Me.User)

            Me.txtEID.Text = String.Empty
            Me.txtFirstName.Text = String.Empty
            Me.txtLastName.Text = String.Empty

            MessageBox.Show("Successfully saved user!", "Saved User", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()
        Catch ex As Exception
            MessageBox.Show($"Something went wrong.{vbCrLf}Please try again later.", "Unable to Save User", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
End Class