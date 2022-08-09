Imports System.Text.RegularExpressions
Imports System
Imports iSISCOL.StringExtension
Imports iSISCOL.ListExtension
Imports iSISCOL.GenericTypeExtension

Public Class RenderizadorPlantillas
    Private Const FOR_LIST_KEYWORD As String = "FOR_LIST"
    Private Const DELIMITADOR_APERTURA As String = "["
    Private Const DELIMITADOR_CERRADO As String = "]"
    Private Const REGEX_NOMBRE_VARIABLE As String = "[A-Za-z-_]"


    Public Function Renderizar_Propiedad(Of U)(ByVal HTML As String, ByVal Propiedad_Remplazar As String, ByVal Valor As U) As String
        Dim patronRegexExpresiones As String = "\" & DELIMITADOR_APERTURA & "{2}\s*" & Propiedad_Remplazar & "\s*\" & DELIMITADOR_CERRADO & "{2}"
        Try
            Dim match As Match = Regex.Match(HTML, patronRegexExpresiones, RegexOptions.Multiline Or RegexOptions.IgnoreCase)
            If match.Success And Valor.ConvertibleAString() Then
                HTML = Regex.Replace(HTML, patronRegexExpresiones, Valor.ToString(), RegexOptions.Multiline Or RegexOptions.IgnoreCase)
            End If
        Catch ex As Exception
        End Try
        Return HTML
    End Function

    Public Function Renderizar_Lista_Simple(Of U)(ByVal HTML As String, ByVal Propiedad_Remplazar As String, ByVal Lista_Valores As List(Of U), Optional ByVal Agregar_Salto_Linea As Boolean = True) As String
        Dim patronRegexContenido As String = "\" & DELIMITADOR_APERTURA & "{2}\s*" & FOR_LIST_KEYWORD & "\s+(" & REGEX_NOMBRE_VARIABLE & "+)\s+in\s+" & Propiedad_Remplazar & "\s*" & DELIMITADOR_CERRADO & "{2}((?:.|\s)*?)\" & DELIMITADOR_APERTURA & "{2}\s*" & FOR_LIST_KEYWORD & "\s*\" & DELIMITADOR_CERRADO & "{2}"
        Try
            Dim _Lista_Valores As List(Of String) = Lista_Valores.ToStringList()

            Dim match As Match = Regex.Match(HTML, patronRegexContenido, RegexOptions.Multiline Or RegexOptions.IgnoreCase)
            If match.Success Then
                Dim Variable_Iteradora As String = match.Groups(1).Value.ToString().Trim()
                Dim Contenido As String = match.Groups(2).Value.ToString().Trim()
                If Contenido.Trim().Length > 0 Then
                    Dim patronRegexExpresiones As String = "\" & DELIMITADOR_APERTURA & "{2}\s*" & Variable_Iteradora & "\s*\" & DELIMITADOR_CERRADO & "{2}"
                    Dim Expresiones = Regex.Matches(Contenido, patronRegexExpresiones, RegexOptions.Multiline Or RegexOptions.IgnoreCase)
                    If Expresiones.Count > 0 Then
                        Dim Resultado_Contenido As String = ""
                        For Each Valor_Expresion In _Lista_Valores
                            Dim Temp_Contenido As String = Contenido
                            For Each Expresion As Match In Expresiones
                                Temp_Contenido = Regex.Replace(Temp_Contenido, patronRegexExpresiones, Valor_Expresion, RegexOptions.Multiline Or RegexOptions.IgnoreCase)
                            Next
                            Resultado_Contenido = Resultado_Contenido & IIf(Agregar_Salto_Linea, vbCrLf, "") + Temp_Contenido
                        Next
                        HTML = Regex.Replace(HTML, patronRegexContenido, Resultado_Contenido, RegexOptions.Multiline Or RegexOptions.IgnoreCase)
                    End If
                End If
            End If
        Catch ex As Exception
            Return HTML
        End Try
        Return HTML
    End Function

    Public Function Renderizar_Lista_Compleja(Of U As Class)(ByVal HTML As String, ByVal Propiedad_Remplazar As String, ByVal Lista_Valores As List(Of U), Optional ByVal Agregar_Salto_Linea As Boolean = True) As String

        Dim patronRegexContenido As String = "\" & DELIMITADOR_APERTURA & "{2}\s*" & FOR_LIST_KEYWORD & "\s+(" & REGEX_NOMBRE_VARIABLE & "+)\s+in\s+" & Propiedad_Remplazar & "\s*" & DELIMITADOR_CERRADO & "{2}((?:.|\s)*?)\" & DELIMITADOR_APERTURA & "{2}\s*" & FOR_LIST_KEYWORD & "\s*\" & DELIMITADOR_CERRADO & "{2}"
        Try
            Dim match As Match = Regex.Match(HTML, patronRegexContenido, RegexOptions.Multiline Or RegexOptions.IgnoreCase)
            If match.Success Then
                Dim Variable_Iteradora As String = match.Groups(1).Value.ToString().Trim()
                Dim Contenido As String = match.Groups(2).Value.ToString().Trim()
                If Contenido.Trim().Length > 0 Then
                    Dim patronRegexExpresiones As String = "\" & DELIMITADOR_APERTURA & "{2}\s*(" & Variable_Iteradora & "+\." & REGEX_NOMBRE_VARIABLE & "+)\s*\" & DELIMITADOR_CERRADO & "{2}"
                    Dim Expresiones = Regex.Matches(Contenido, patronRegexExpresiones, RegexOptions.Multiline Or RegexOptions.IgnoreCase)
                    If Expresiones.Count > 0 Then
                        Dim Resultado_Contenido As String = ""
                        For Each Item In Lista_Valores
                            Dim Temp_Contenido As String = Contenido
                            For Each Expresion As Match In Expresiones
                                Dim Cadena_Expresion As String = Expresion.Groups(1).Value.ToString()
                                Dim Propiedad_Expresion As String = Cadena_Expresion.Substring(Cadena_Expresion.IndexOf(".") + 1)
                                Dim Valor_Expresion As String = CallByName(Item, Propiedad_Expresion, CallType.Get, Nothing)
                                Temp_Contenido = Regex.Replace(Temp_Contenido, patronRegexExpresiones, Valor_Expresion, RegexOptions.Multiline Or RegexOptions.IgnoreCase)
                            Next
                            Resultado_Contenido = Resultado_Contenido & IIf(Agregar_Salto_Linea, vbCrLf, "") + Temp_Contenido
                        Next
                        HTML = Regex.Replace(HTML, patronRegexContenido, Resultado_Contenido, RegexOptions.Multiline Or RegexOptions.IgnoreCase)
                    End If
                End If
            End If
        Catch ex As Exception
            Return HTML
        End Try
        Return HTML
    End Function

End Class
