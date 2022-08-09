Imports System.Runtime.CompilerServices

Module ListExtension
    ''' <summary>
    ''' Convierte una lista Generica a lista de String si ésta tiene un tipo de dato con el método ToString,
    ''' en caso contrario devuelve una lista vacía
    ''' </summary>
    ''' <typeparam name="T"></typeparam>
    ''' <param name="Lista"></param>
    ''' <returns></returns>
    <Extension()>
    Public Function ToStringList(Of V)(ByVal Lista As List(Of V)) As List(Of String)
        Dim listType As Type = Lista.GetType().GetGenericArguments()(0)
        Dim result As List(Of String) = New List(Of String)
        If listType.ConvertibleAString() Then
            result = Lista.Select(Function(x As V) x.ToString()).ToList()
        End If
        Return result
    End Function
End Module
