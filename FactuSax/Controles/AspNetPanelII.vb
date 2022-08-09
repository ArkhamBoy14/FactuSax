Imports System
Imports Wisej.Web

Public Class AspNetPanelII
    Inherits AspNetPanel

    Const sDefault As String = "Controles\AspNetPanelIIDefault.html"
    Sub New()
        InitializeComponent()
        MyBase.PageSource = sDefault
    End Sub


    Overloads Property PageSource As String
        Get
            Return MyBase.PageSource
        End Get
        Set(value As String)
            If value Is Nothing Then value = sDefault
            Dim sRuta as String = "random=" & DateTime.Now.ToString("yyyyMMddHHmmss")
            If value.Contains("?") Then sRuta = "&" + sRuta Else sRuta = "?" + sRuta
            MyBase.PageSource = value + sRuta
        End Set
    End Property


End Class

