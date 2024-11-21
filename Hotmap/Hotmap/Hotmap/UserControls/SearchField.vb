Public Class SearchField
#Region "Properties"
    Public Property Placeholder() As String
        Get
            Return Me.txtSearch.PlaceholderText
        End Get
        Set(ByVal value As String)
            Me.txtSearch.PlaceholderText = value
        End Set
    End Property
#End Region

#Region "Events"
    Public Event Search(value As String)
#End Region

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.btnSearch.FillColor = Theme.SecondaryColor
    End Sub

#Region "Event Handlers"
    Private Sub txtSearch_KeyDown(sender As Object, e As KeyEventArgs) Handles txtSearch.KeyDown
        If e.KeyValue = Keys.Enter Then RaiseEvent Search(Me.txtSearch.Text)
    End Sub

    Private Sub btnSearch_Click(sender As Object, e As EventArgs) Handles btnSearch.Click
        RaiseEvent Search(Me.txtSearch.Text)
    End Sub
#End Region
End Class
