Imports System.Runtime.CompilerServices

Module GenericTypeExtension
    ''' <summary>
    ''' Busca si el objeto pasado como parámetro tiene el método ToString
    ''' </summary>
    ''' <typeparam name="V"></typeparam>
    ''' <param name="Valor"></param>
    ''' <returns></returns>
    <Extension()>
    Public Function ConvertibleAString(Of V)(ByVal Valor As V) As Boolean
        Dim type = Valor.GetType()
        If type <> Nothing Then
            Return (type.GetMethods().Where(Function(m) m.Name = "ToString").ToList().Count > 0)
        End If
        Return False
    End Function

End Module
