Imports System.Runtime.CompilerServices

Module DataGridViewExtension
    <Extension()>
    Public Function CellValue(ByVal DGV As DataGridView, ByVal columnIndex As Integer, rowIndex As Integer) As Object
        Return DGV.Item(columnIndex, rowIndex).Value
    End Function

    <Extension()>
    Public Function CellValue(ByVal DGV As DataGridView, ByVal columnName As String, rowIndex As Integer) As Object
        Return DGV.Item(columnName, rowIndex).Value
    End Function
End Module
