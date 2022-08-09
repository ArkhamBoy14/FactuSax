Imports System
Imports Wisej.Web
Imports System.Data
Imports System.Data.SqlClient

Public Class DGVSpan

    Private ME_DATASET_PADRE As DataSet
    Private ME_PROCEDURE As String
    Private ME_PARAMETROS As List(Of String)

    Public Sub CargarDatos()
        Dim myDA = New SqlDataAdapter(ME_PROCEDURE, Utilidades.sConexion)

        If Me.ME_PARAMETROS.Count > 0 Then

        End If


    End Sub


End Class
