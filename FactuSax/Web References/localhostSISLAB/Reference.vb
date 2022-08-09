﻿'------------------------------------------------------------------------------
' <auto-generated>
'     Este código fue generado por una herramienta.
'     Versión de runtime:4.0.30319.42000
'
'     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
'     se vuelve a generar el código.
' </auto-generated>
'------------------------------------------------------------------------------

Option Strict Off
Option Explicit On

Imports System
Imports System.ComponentModel
Imports System.Diagnostics
Imports System.Web.Services
Imports System.Web.Services.Protocols
Imports System.Xml.Serialization

'
'Microsoft.VSDesigner generó automáticamente este código fuente, versión=4.0.30319.42000.
'
Namespace localhostSISLAB
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="Actualizar_EstatusSoap", [Namespace]:="http://Sislab_actualizo.org/")>  _
    Partial Public Class Actualizar_Estatus
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private ActualizarOperationCompleted As System.Threading.SendOrPostCallback
        
        Private Actualizarv2OperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.FactuSax.My.MySettings.Default.FactuSax_localhostSISLAB_Actualizar_Estatus
            If (Me.IsLocalFileSystemWebService(Me.Url) = true) Then
                Me.UseDefaultCredentials = true
                Me.useDefaultCredentialsSetExplicitly = false
            Else
                Me.useDefaultCredentialsSetExplicitly = true
            End If
        End Sub
        
        Public Shadows Property Url() As String
            Get
                Return MyBase.Url
            End Get
            Set
                If (((Me.IsLocalFileSystemWebService(MyBase.Url) = true)  _
                            AndAlso (Me.useDefaultCredentialsSetExplicitly = false))  _
                            AndAlso (Me.IsLocalFileSystemWebService(value) = false)) Then
                    MyBase.UseDefaultCredentials = false
                End If
                MyBase.Url = value
            End Set
        End Property
        
        Public Shadows Property UseDefaultCredentials() As Boolean
            Get
                Return MyBase.UseDefaultCredentials
            End Get
            Set
                MyBase.UseDefaultCredentials = value
                Me.useDefaultCredentialsSetExplicitly = true
            End Set
        End Property
        
        '''<remarks/>
        Public Event ActualizarCompleted As ActualizarCompletedEventHandler
        
        '''<remarks/>
        Public Event Actualizarv2Completed As Actualizarv2CompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://Sislab_actualizo.org/Actualizar", RequestNamespace:="http://Sislab_actualizo.org/", ResponseNamespace:="http://Sislab_actualizo.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Sub Actualizar(ByVal folio As String, ByVal uuid As String, ByVal estatus As String, ByVal rfc As String, ByVal folio_movimiento As String, ByVal fecha_facturado As Date)
            Me.Invoke("Actualizar", New Object() {folio, uuid, estatus, rfc, folio_movimiento, fecha_facturado})
        End Sub
        
        '''<remarks/>
        Public Overloads Sub ActualizarAsync(ByVal folio As String, ByVal uuid As String, ByVal estatus As String, ByVal rfc As String, ByVal folio_movimiento As String, ByVal fecha_facturado As Date)
            Me.ActualizarAsync(folio, uuid, estatus, rfc, folio_movimiento, fecha_facturado, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub ActualizarAsync(ByVal folio As String, ByVal uuid As String, ByVal estatus As String, ByVal rfc As String, ByVal folio_movimiento As String, ByVal fecha_facturado As Date, ByVal userState As Object)
            If (Me.ActualizarOperationCompleted Is Nothing) Then
                Me.ActualizarOperationCompleted = AddressOf Me.OnActualizarOperationCompleted
            End If
            Me.InvokeAsync("Actualizar", New Object() {folio, uuid, estatus, rfc, folio_movimiento, fecha_facturado}, Me.ActualizarOperationCompleted, userState)
        End Sub
        
        Private Sub OnActualizarOperationCompleted(ByVal arg As Object)
            If (Not (Me.ActualizarCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent ActualizarCompleted(Me, New System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://Sislab_actualizo.org/Actualizarv2", RequestNamespace:="http://Sislab_actualizo.org/", ResponseNamespace:="http://Sislab_actualizo.org/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function Actualizarv2(ByVal folio As String, ByVal uuid As String, ByVal estatus As String, ByVal rfc As String, ByVal folio_movimiento As String, ByVal fecha_facturado As Date) As Object
            Dim results() As Object = Me.Invoke("Actualizarv2", New Object() {folio, uuid, estatus, rfc, folio_movimiento, fecha_facturado})
            Return CType(results(0),Object)
        End Function
        
        '''<remarks/>
        Public Overloads Sub Actualizarv2Async(ByVal folio As String, ByVal uuid As String, ByVal estatus As String, ByVal rfc As String, ByVal folio_movimiento As String, ByVal fecha_facturado As Date)
            Me.Actualizarv2Async(folio, uuid, estatus, rfc, folio_movimiento, fecha_facturado, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub Actualizarv2Async(ByVal folio As String, ByVal uuid As String, ByVal estatus As String, ByVal rfc As String, ByVal folio_movimiento As String, ByVal fecha_facturado As Date, ByVal userState As Object)
            If (Me.Actualizarv2OperationCompleted Is Nothing) Then
                Me.Actualizarv2OperationCompleted = AddressOf Me.OnActualizarv2OperationCompleted
            End If
            Me.InvokeAsync("Actualizarv2", New Object() {folio, uuid, estatus, rfc, folio_movimiento, fecha_facturado}, Me.Actualizarv2OperationCompleted, userState)
        End Sub
        
        Private Sub OnActualizarv2OperationCompleted(ByVal arg As Object)
            If (Not (Me.Actualizarv2CompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent Actualizarv2Completed(Me, New Actualizarv2CompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
            End If
        End Sub
        
        '''<remarks/>
        Public Shadows Sub CancelAsync(ByVal userState As Object)
            MyBase.CancelAsync(userState)
        End Sub
        
        Private Function IsLocalFileSystemWebService(ByVal url As String) As Boolean
            If ((url Is Nothing)  _
                        OrElse (url Is String.Empty)) Then
                Return false
            End If
            Dim wsUri As System.Uri = New System.Uri(url)
            If ((wsUri.Port >= 1024)  _
                        AndAlso (String.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) = 0)) Then
                Return true
            End If
            Return false
        End Function
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")>  _
    Public Delegate Sub ActualizarCompletedEventHandler(ByVal sender As Object, ByVal e As System.ComponentModel.AsyncCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")>  _
    Public Delegate Sub Actualizarv2CompletedEventHandler(ByVal sender As Object, ByVal e As Actualizarv2CompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class Actualizarv2CompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As Object
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),Object)
            End Get
        End Property
    End Class
End Namespace
