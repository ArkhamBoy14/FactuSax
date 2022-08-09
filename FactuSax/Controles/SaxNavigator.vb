Imports System
Imports Wisej.Web

Public Class SaxNavigator

    Dim Bs_Principal As BindingSource = Nothing

    Public Sub RecordarPocision()
        Dim Inicio As String
        With Bs_Principal
            'If .Position = 0 Then
            Inicio = (.Position + 1).ToString
            'Else
            '    Inicio = (.Position).ToString
            'End If
            'Dim Final = .Count.ToString

            Lb_Contador.Text = Inicio & " de " & .Count.ToString + " Datos"
        End With
    End Sub

    Public Property meBindingSource() As Wisej.Web.BindingSource

        Get
            Return Bs_Principal
        End Get
        Set(BS As Wisej.Web.BindingSource)
            Bs_Principal = BS
        End Set
    End Property

    Private Sub Btn_Siguiente_Click(sender As Object, e As EventArgs) Handles Btn_Siguiente.Click
        Bs_Principal.MoveNext()
        'Bs_Principal.Position += 1
        RecordarPocision()
    End Sub

    Private Sub Btn_Inicio_Click(sender As Object, e As EventArgs) Handles Btn_Inicio.Click
        Bs_Principal.MoveFirst()
        'Bs_Principal.Position = 0
        RecordarPocision()
    End Sub

    Private Sub Btn_Anterior_Click(sender As Object, e As EventArgs) Handles Btn_Anterior.Click
        Bs_Principal.MovePrevious()
        'Bs_Principal.Position -= 1
        RecordarPocision()
    End Sub

    Private Sub Btn_Final_Click(sender As Object, e As EventArgs) Handles Btn_Final.Click
        Bs_Principal.MoveLast()
        'Bs_Principal.Position _
        '    = Bs_Principal.Count - 1
        RecordarPocision()
    End Sub
End Class
