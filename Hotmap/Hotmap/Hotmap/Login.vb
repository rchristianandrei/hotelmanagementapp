Public Class Login
    Private ReadOnly loginRepo As New LoginRepo

    Private Async Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Try

            Await Me.loginRepo.Login(Me.txtUserId.Text, Me.txtPassword.Text)

            Main.Show()
            Me.Close()
        Catch ex As Exception
            MessageBox.Show("Please make sure the credentials are correct and you're connected to the internet", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
End Class