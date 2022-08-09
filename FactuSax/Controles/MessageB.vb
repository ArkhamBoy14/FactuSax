
Imports Wisej.Web

Public Class MessageB
    Private _sLinea1 As String = ""
    Private _sLinea2 As String = ""

    Public Sub New(ByVal sLinea1 As String, ByVal sLinea2 As String)
        InitializeComponent()
        Me.Linea1.Text = sLinea1
        Me.Linea2.Text = sLinea2
        'Me.Opacity = 1
    End Sub

    Public Sub New()
        InitializeComponent()
    End Sub

    Property sLinea1 As String
        Get
            Return _sLinea1
        End Get
        Set(ByVal value As String)
            _sLinea1 = value
        End Set
    End Property

    Property sLinea2 As String
        Get
            Return _sLinea2
        End Get
        Set(ByVal value As String)
            _sLinea2 = value
        End Set
    End Property

End Class

