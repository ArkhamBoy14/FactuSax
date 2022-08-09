Imports System
Imports Wisej.Web

Public Class Mostrar_Asp
    Private Sub RibbonBar1_ButtonClick(ByVal sender As Object, ByVal e As Ext.RibbonBar.RibbonBarItemEventArgs) Handles RibbonBar1.ItemClick
        Select Case e.Item.Name

            Case RBBACTUALIZAR.Name
                Actualizar()
            Case RBBSALIR.Name
                Me.Close()

        End Select
    End Sub
    Private Sub Mostrar_Asp_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        load_Primero()
    End Sub
    Sub load_Primero()
        If Trim(Application.Session("Modulo")) <> Nothing Then
            Me.AspNetPanel1.PageSource = Application.Session("Modulo")
            AspNetPanel1.Tag = Application.Session("Modulo")

            AspNetPanel1.Update()
        End If
    End Sub
    Sub Actualizar()
        If AspNetPanel1.Tag <> Nothing Then
            Me.AspNetPanel1.PageSource = AspNetPanel1.Tag
            AspNetPanel1.Update()

        End If
    End Sub
End Class
