Public Class AddRoom

#Region "Fields / Objects"
    Private roomsRepo As New RoomsRepo
#End Region

#Region "Properties"
    Public Property Room As RoomModel
#End Region

#Region "Event Handler"
    Private Sub AddRoom_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Not Me.Visible Or Room Is Nothing Then Return

        Me.txtName.Text = Me.Room.Name
        Me.txtType.Text = Me.Room.Type
        Me.txtPrice.Text = Me.Room.Price
    End Sub

    Private Async Sub btnSave_Click() Handles btnSave.Click
        Dim errorMessage = "Please input valid values on the following fields:"

        ' Validate Name
        Dim nameError = String.IsNullOrWhiteSpace(txtName.Text)
        If nameError Then errorMessage += $"{vbCrLf}Name"

        ' Validate Type
        Dim typeError = String.IsNullOrWhiteSpace(txtType.Text)
        If typeError Then errorMessage += $"{vbCrLf}Type"

        ' Validate Price
        Dim price = 0.0
        Dim priceError = Not Double.TryParse(txtPrice.Text, price)
        If priceError Then errorMessage += $"{vbCrLf}Price"

        If nameError Or typeError Or priceError Then
            MessageBox.Show(errorMessage, "Invalid Values", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        If Room Is Nothing Then Room = New RoomModel

        Me.Room.Name = txtName.Text
        Me.Room.Type = txtType.Text
        Me.Room.Price = Double.Parse(String.Format("{0:F2}", price))

        Try
            Dim res = Await Me.roomsRepo.HttpPost(Room)
            Me.txtName.Text = String.Empty
            Me.txtType.Text = String.Empty
            Me.txtPrice.Text = String.Empty

            MessageBox.Show("Successfully saved room!", "Saved Room", MessageBoxButtons.OK, MessageBoxIcon.Information)

            Me.Close()
        Catch ex As Exception
            MessageBox.Show($"Something went wrong.{vbCrLf}Please try again later.", "Unable to Save Room", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
#End Region
End Class