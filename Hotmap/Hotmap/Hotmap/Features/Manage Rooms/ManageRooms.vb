Public Class ManageRooms
#Region "Properties"

#End Region

#Region "Events"
    Public Event Popup(show As Boolean)
#End Region

#Region "Event Handlers"
    Private Sub btnAdd_Click() Handles btnAdd.Click
        RaiseEvent Popup(True)

        Dim addRoom As New AddRoom
        AddHandler addRoom.Closing,
            Sub()
                RaiseEvent Popup(False)
            End Sub

        addRoom.ShowDialog(Me.ParentForm)
    End Sub
#End Region
End Class
