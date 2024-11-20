Public Class PrimaryButton
    Public Shadows Event Click()

    Private Sub Button_Click(sender As Object, e As EventArgs) Handles Button.Click
        RaiseEvent Click()
    End Sub
End Class
