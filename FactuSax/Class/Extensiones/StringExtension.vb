
Imports System.Runtime.CompilerServices
Module StringExtension
    <Extension()>
    Public Function Times(ByVal Str As String, ByVal XTimes As Integer, Optional ByVal JoinCharacter As String = "") As String
        Return String.Join(JoinCharacter, Enumerable.Repeat(Str, XTimes))
    End Function
End Module
