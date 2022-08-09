Imports System.Runtime.CompilerServices

Module TextBoxExtension
    <Extension()>
    Public Function IsValid(ByVal textBox As TextBox) As Boolean
        Return (Not String.IsNullOrWhiteSpace(textBox.Text))
    End Function

    <Extension()>
    Public Function IsNotValid(ByVal textBox As TextBox) As Boolean
        Return String.IsNullOrWhiteSpace(textBox.Text)
    End Function

    <Extension()>
    Public Function IsValid(ByRef textBox As TextBox, ByRef errorProvider As ErrorProvider, ByVal Optional message As String = "Campo requerido") As Boolean
        Dim _isValid As Boolean = (Not String.IsNullOrWhiteSpace(textBox.Text))
        errorProvider.SetError(textBox, IIf(_isValid, Nothing, message))
        Return _isValid
    End Function

    <Extension()>
    Public Function IsNotValid(ByRef textBox As TextBox, ByRef errorProvider As ErrorProvider, ByVal Optional message As String = "Campo requerido") As Boolean
        Return IsValid(textBox, errorProvider, message)
    End Function
End Module
