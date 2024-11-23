Imports System.Net.Http

Module Http
    Private _HttpClient As New HttpClient
    Public ReadOnly Property HttpClient() As HttpClient
        Get
            Return _HttpClient
        End Get
    End Property
End Module
