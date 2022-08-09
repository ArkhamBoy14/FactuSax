Imports System.Data
Public Class ElementoExportar
    Public Procedimiento As String = ""
    Public NombreHoja As String = ""
    Public Where As String = ""
    Public Parametros As SqlClient.SqlParameterCollection = Nothing
    Public Columnas As Dictionary(Of String, String) = Nothing
End Class
