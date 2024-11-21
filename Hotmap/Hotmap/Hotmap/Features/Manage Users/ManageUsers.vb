Public Class ManageUsers

#Region "Fields / Objects"
    Private ReadOnly usersRepo As New UsersRepo

    Private ReadOnly users As New Dictionary(Of String, UserModel)
#End Region

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.

    End Sub

#Region "Event Handlers"
    Private Async Sub ManageUsers_VisibleChanged(sender As Object, e As EventArgs) Handles MyBase.VisibleChanged
        If Not Me.Visible Then Return

        Await Me.LoadData
    End Sub

    Private Sub btnAdd_Click() Handles btnAdd.Click
        Dim addRoom As New AddUser
        AddHandler addRoom.Closing, Async Sub() Await Me.LoadData()
        addRoom.ShowDialog(Me.ParentForm)
    End Sub

    Private Async Sub dgUsers_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgUsers.CellClick
        If e.RowIndex < 0 Then Return

        Dim id As String = Me.dgUsers.Rows(e.RowIndex).Cells(Me.colEmployeeId.Index).Value

        Select Case e.ColumnIndex
            Case Me.colDelete.Index
                ' Delete
                Dim res = MessageBox.Show("Are you sure you want to delete this User?", "Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question)
                If Not res = vbYes Then Exit Select

                Try
                    Await Me.usersRepo.Delete(id)

                    Await Me.LoadData

                    MessageBox.Show($"Successfully Deleted the User!.", "Deleted User", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Catch ex As Exception
                    MessageBox.Show($"Something went wrong.{vbCrLf}Please try again later.", "Unable to Delete User", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try

            Case Me.colEdit.Index
                ' Edit
                Dim addUser As New AddUser With {.User = Me.users(id)}
                AddHandler addUser.FormClosing, Async Sub() Await Me.LoadData
                addUser.ShowDialog(Me.ParentForm)
        End Select
    End Sub
#End Region

#Region "Private Method"
    Private Async Function LoadData() As Task
        Try
            Dim users = Await Me.usersRepo.Get1000

            Me.users.Clear()
            Me.dgUsers.Rows.Clear()

            For Each user In users
                Me.users.Add(user.EID, user)

                Me.dgUsers.Rows.Add("🖊️", user.EID, user.FirstName, user.LastName, user.HireDate.ToString("yyyy-MM-dd"), user.DateTimeAdded, "❌")
            Next

            Me.dgUsers.ClearSelection()
            Me.lblCount.Text = $"Count: <b>{Me.dgUsers.RowCount}</b>"
        Catch ex As Exception
            MessageBox.Show($"Something went wrong.{vbCrLf}Please try again later", "Unable to Load Users", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function
#End Region
End Class
