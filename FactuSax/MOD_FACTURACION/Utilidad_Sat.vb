
Imports System
    Imports System.Collections.Generic
    Imports System.IO
    Imports System.Linq
    Imports System.Text
    Imports System.Threading.Tasks

Namespace miselaneo
    Public Class StringWriterWithEncoding
        Inherits StringWriter

        Public Sub New(ByVal encoding As Encoding)
            MyBase.New()
            Me.m_Encoding = encoding
        End Sub

        Private ReadOnly m_Encoding As Encoding

        Public Overrides ReadOnly Property Encoding As Encoding
            Get
                Return Me.m_Encoding
            End Get
        End Property
    End Class
End Namespace