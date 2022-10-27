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
Namespace mx.com.expidetufactura.cancelacionxpd.produccion.v3
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Web.Services.WebServiceBindingAttribute(Name:="CancelacionPortSoap11", [Namespace]:="http://concretepage.com/soap")>  _
    Partial Public Class CancelacionPortService
        Inherits System.Web.Services.Protocols.SoapHttpClientProtocol
        
        Private cancelacionMultipleOperationCompleted As System.Threading.SendOrPostCallback
        
        Private useDefaultCredentialsSetExplicitly As Boolean
        
        '''<remarks/>
        Public Sub New()
            MyBase.New
            Me.Url = Global.FactuSax.My.MySettings.Default.FactuSax_mx_com_expidetufactura_cancelacionxpd_Produccion_CancelacionPortService
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
        Public Event cancelacionMultipleCompleted As cancelacionMultipleCompletedEventHandler
        
        '''<remarks/>
        <System.Web.Services.Protocols.SoapDocumentMethodAttribute("", Use:=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle:=System.Web.Services.Protocols.SoapParameterStyle.Bare)>  _
        Public Function cancelacionMultiple(<System.Xml.Serialization.XmlElementAttribute([Namespace]:="http://concretepage.com/soap")> ByVal cancelacionMultipleRequest As cancelacionMultipleRequest) As <System.Xml.Serialization.XmlArrayAttribute("cancelacionMultipleResponse", [Namespace]:="http://concretepage.com/soap"), System.Xml.Serialization.XmlArrayItemAttribute(IsNullable:=false)> respuestaCliente()
            Dim results() As Object = Me.Invoke("cancelacionMultiple", New Object() {cancelacionMultipleRequest})
            Return CType(results(0),respuestaCliente())
        End Function
        
        '''<remarks/>
        Public Overloads Sub cancelacionMultipleAsync(ByVal cancelacionMultipleRequest As cancelacionMultipleRequest)
            Me.cancelacionMultipleAsync(cancelacionMultipleRequest, Nothing)
        End Sub
        
        '''<remarks/>
        Public Overloads Sub cancelacionMultipleAsync(ByVal cancelacionMultipleRequest As cancelacionMultipleRequest, ByVal userState As Object)
            If (Me.cancelacionMultipleOperationCompleted Is Nothing) Then
                Me.cancelacionMultipleOperationCompleted = AddressOf Me.OncancelacionMultipleOperationCompleted
            End If
            Me.InvokeAsync("cancelacionMultiple", New Object() {cancelacionMultipleRequest}, Me.cancelacionMultipleOperationCompleted, userState)
        End Sub
        
        Private Sub OncancelacionMultipleOperationCompleted(ByVal arg As Object)
            If (Not (Me.cancelacionMultipleCompletedEvent) Is Nothing) Then
                Dim invokeArgs As System.Web.Services.Protocols.InvokeCompletedEventArgs = CType(arg,System.Web.Services.Protocols.InvokeCompletedEventArgs)
                RaiseEvent cancelacionMultipleCompleted(Me, New cancelacionMultipleCompletedEventArgs(invokeArgs.Results, invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState))
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
     System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true, [Namespace]:="http://concretepage.com/soap")>  _
    Partial Public Class cancelacionMultipleRequest
        
        Private usuarioField As String
        
        Private contrasenaField As String
        
        Private correoField As String
        
        Private correoCopiaField As String
        
        Private pdfGenerarField As Boolean
        
        Private pdfGenerarFieldSpecified As Boolean
        
        Private pdfNoPlantillaField As String
        
        Private telefonoField As String
        
        Private parametrosField() As parametrosCancelaMultiple
        
        '''<remarks/>
        Public Property usuario() As String
            Get
                Return Me.usuarioField
            End Get
            Set
                Me.usuarioField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property contrasena() As String
            Get
                Return Me.contrasenaField
            End Get
            Set
                Me.contrasenaField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property correo() As String
            Get
                Return Me.correoField
            End Get
            Set
                Me.correoField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property correoCopia() As String
            Get
                Return Me.correoCopiaField
            End Get
            Set
                Me.correoCopiaField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property pdfGenerar() As Boolean
            Get
                Return Me.pdfGenerarField
            End Get
            Set
                Me.pdfGenerarField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlIgnoreAttribute()>  _
        Public Property pdfGenerarSpecified() As Boolean
            Get
                Return Me.pdfGenerarFieldSpecified
            End Get
            Set
                Me.pdfGenerarFieldSpecified = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property pdfNoPlantilla() As String
            Get
                Return Me.pdfNoPlantillaField
            End Get
            Set
                Me.pdfNoPlantillaField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property telefono() As String
            Get
                Return Me.telefonoField
            End Get
            Set
                Me.telefonoField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("parametros")>  _
        Public Property parametros() As parametrosCancelaMultiple()
            Get
                Return Me.parametrosField
            End Get
            Set
                Me.parametrosField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://concretepage.com/soap")>  _
    Partial Public Class parametrosCancelaMultiple
        
        Private noCertificadoField As String
        
        Private rfcEmisorField As String
        
        Private rfcReceptorField As String
        
        Private totalField As String
        
        Private uuidField As String
        
        Private motivoField As String
        
        Private folioSustitucionField As String
        
        Private xmlB64Field As String
        
        '''<remarks/>
        Public Property noCertificado() As String
            Get
                Return Me.noCertificadoField
            End Get
            Set
                Me.noCertificadoField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property rfcEmisor() As String
            Get
                Return Me.rfcEmisorField
            End Get
            Set
                Me.rfcEmisorField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property rfcReceptor() As String
            Get
                Return Me.rfcReceptorField
            End Get
            Set
                Me.rfcReceptorField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property total() As String
            Get
                Return Me.totalField
            End Get
            Set
                Me.totalField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property uuid() As String
            Get
                Return Me.uuidField
            End Get
            Set
                Me.uuidField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property motivo() As String
            Get
                Return Me.motivoField
            End Get
            Set
                Me.motivoField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property folioSustitucion() As String
            Get
                Return Me.folioSustitucionField
            End Get
            Set
                Me.folioSustitucionField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property xmlB64() As String
            Get
                Return Me.xmlB64Field
            End Get
            Set
                Me.xmlB64Field = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://concretepage.com/soap")>  _
    Partial Public Class xmlRelacionado
        
        Private xmlField As String
        
        Private uuidField As String
        
        Private emisorField As String
        
        Private receptorField As String
        
        Private tipoField As String
        
        Private pdfField() As Byte
        
        '''<remarks/>
        Public Property xml() As String
            Get
                Return Me.xmlField
            End Get
            Set
                Me.xmlField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property uuid() As String
            Get
                Return Me.uuidField
            End Get
            Set
                Me.uuidField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property emisor() As String
            Get
                Return Me.emisorField
            End Get
            Set
                Me.emisorField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property receptor() As String
            Get
                Return Me.receptorField
            End Get
            Set
                Me.receptorField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property tipo() As String
            Get
                Return Me.tipoField
            End Get
            Set
                Me.tipoField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(DataType:="hexBinary")>  _
        Public Property pdf() As Byte()
            Get
                Return Me.pdfField
            End Get
            Set
                Me.pdfField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Xml", "4.8.4084.0"),  _
     System.SerializableAttribute(),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code"),  _
     System.Xml.Serialization.XmlTypeAttribute([Namespace]:="http://concretepage.com/soap")>  _
    Partial Public Class respuestaCliente
        
        Private codigoField As String
        
        Private mensajeField As String
        
        Private responseCancelarField As String
        
        Private responseConsultaField As String
        
        Private responseRelacionadosField As String
        
        Private idTransaccionField As String
        
        Private pdfField() As Byte
        
        Private xmlRelacionadosField() As xmlRelacionado
        
        '''<remarks/>
        Public Property codigo() As String
            Get
                Return Me.codigoField
            End Get
            Set
                Me.codigoField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property mensaje() As String
            Get
                Return Me.mensajeField
            End Get
            Set
                Me.mensajeField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property responseCancelar() As String
            Get
                Return Me.responseCancelarField
            End Get
            Set
                Me.responseCancelarField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property responseConsulta() As String
            Get
                Return Me.responseConsultaField
            End Get
            Set
                Me.responseConsultaField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property responseRelacionados() As String
            Get
                Return Me.responseRelacionadosField
            End Get
            Set
                Me.responseRelacionadosField = value
            End Set
        End Property
        
        '''<remarks/>
        Public Property idTransaccion() As String
            Get
                Return Me.idTransaccionField
            End Get
            Set
                Me.idTransaccionField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute(DataType:="hexBinary")>  _
        Public Property pdf() As Byte()
            Get
                Return Me.pdfField
            End Get
            Set
                Me.pdfField = value
            End Set
        End Property
        
        '''<remarks/>
        <System.Xml.Serialization.XmlElementAttribute("xmlRelacionados")>  _
        Public Property xmlRelacionados() As xmlRelacionado()
            Get
                Return Me.xmlRelacionadosField
            End Get
            Set
                Me.xmlRelacionadosField = value
            End Set
        End Property
    End Class
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")>  _
    Public Delegate Sub cancelacionMultipleCompletedEventHandler(ByVal sender As Object, ByVal e As cancelacionMultipleCompletedEventArgs)
    
    '''<remarks/>
    <System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0"),  _
     System.Diagnostics.DebuggerStepThroughAttribute(),  _
     System.ComponentModel.DesignerCategoryAttribute("code")>  _
    Partial Public Class cancelacionMultipleCompletedEventArgs
        Inherits System.ComponentModel.AsyncCompletedEventArgs
        
        Private results() As Object
        
        Friend Sub New(ByVal results() As Object, ByVal exception As System.Exception, ByVal cancelled As Boolean, ByVal userState As Object)
            MyBase.New(exception, cancelled, userState)
            Me.results = results
        End Sub
        
        '''<remarks/>
        Public ReadOnly Property Result() As respuestaCliente()
            Get
                Me.RaiseExceptionIfNecessary
                Return CType(Me.results(0),respuestaCliente())
            End Get
        End Property
    End Class
End Namespace
