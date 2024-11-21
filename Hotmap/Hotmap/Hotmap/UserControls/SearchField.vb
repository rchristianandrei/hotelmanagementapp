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

    Public Sub New()

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        Me.btnSearch.FillColor = Theme.PrimaryColor
    End Sub
End Class
