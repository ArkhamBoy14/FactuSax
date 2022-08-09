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
Namespace ExpideTuFactura
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="TimbradoWSServiceSoapBinding", [Namespace]:="http://service.timbrado.xpd.mx/")>  _
    Partial Public Class TimbradoWSService
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private timbrarOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.FactuSax.My.MySettings.Default.FactuSax_ExpideTuFactura_TimbradoWSService
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
        Public Event timbrarCompleted As timbrarCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("timbrar", RequestNamespace:="http://service.timbrado.xpd.mx/", ResponseNamespace:="http://service.timbrado.xpd.mx/", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)>  _
        Public Function timbrar(<System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)> ByVal usuario As String, <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)> ByVal contrasena As String, <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified, DataType:="base64Binary")> ByVal cfdi() As Byte) As <System.Xml.Serialization.XmlElementAttribute("return", Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)> respuestaTimbrado
            Dim results() As Object = Me.Invoke("timbrar", New Object() {usuario, contrasena, cfdi})
            Return CType(results(0),respuestaTimbrado)
        End Function
        
        '''<remarks/>
        Public Overloads Sub timbrarAsync(ByVal usuario As String, ByVal contrasena As String, ByVal cfdi() As Byte)
            Me.timbrarAsync(usuario, contrasena, cfdi, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub timbrarAsync(ByVal usuario As String, ByVal contrasena As String, ByVal cfdi() As Byte, ByVal userState As Object)
            If (Me.timbrarOperationCompleted Is Nothing) Then
                Me.timbrarOperationCompleted = AddressOf Me.OntimbrarOperationCompleted
            End If
            Me.InvokeAsync("timbrar", New Object() {usuario, contrasena, cfdi}, Me.timbrarOperationCompleted, userState)
        End Sub
        
        Private Sub OntimbrarOperationCompleted(ByVal arg As Object)
            If (Not (Me.timbrarCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent timbrarCompleted(Me, New timbrarCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
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
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://service.timbrado.xpd.mx/")>  _
    Partial Public Class respuestaTimbrado
        
        Private codigoField As String
        
        Private mensajeField As String
        
        Private timbreField As String
        
        Private uuidField As String
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property codigo() As String
            Get
                Return Me.codigoField
            End Get
            Set
                Me.codigoField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property mensaje() As String
            Get
                Return Me.mensajeField
            End Get
            Set
                Me.mensajeField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property timbre() As String
            Get
                Return Me.timbreField
            End Get
            Set
                Me.timbreField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(Form:=System.Xml.Schema.XmlSchemaForm.Unqualified)>  _
        Public Property uuid() As String
            Get
                Return Me.uuidField
            End Get
            Set
                Me.uuidField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")>  _
    Public Delegate Sub timbrarCompletedEventHandler(ByVal sender As Object, ByVal e As timbrarCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class timbrarCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As respuestaTimbrado
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),respuestaTimbrado)
            End Get
        End Property
    End Class
End Namespace
