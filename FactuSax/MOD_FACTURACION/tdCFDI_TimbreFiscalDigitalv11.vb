'------------------------------------------------------------------------------
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

Imports System.Xml.Serialization

'
'Este código fuente fue generado automáticamente por xsd, Versión=4.6.1055.0.
'

'''<comentarios/>
<System.CodeDom.Compiler.GeneratedCodeAttribute("xsd", "4.6.1055.0"),  _
 System.SerializableAttribute(),  _
 System.Diagnostics.DebuggerStepThroughAttribute(),  _
 System.ComponentModel.DesignerCategoryAttribute("code"),  _
 System.Xml.Serialization.XmlTypeAttribute(AnonymousType:=true, [Namespace]:="http://www.sat.gob.mx/TimbreFiscalDigital"),  _
 System.Xml.Serialization.XmlRootAttribute([Namespace]:="http://www.sat.gob.mx/TimbreFiscalDigital", IsNullable:=false)>  _
Partial Public Class TimbreFiscalDigital
    
    Private versionField As String
    
    Private uUIDField As String
    
    Private fechaTimbradoField As Date
    
    Private rfcProvCertifField As String
    
    Private leyendaField As String
    
    Private selloCFDField As String
    
    Private noCertificadoSATField As String
    
    Private selloSATField As String
    
    Public Sub New()
        MyBase.New
        Me.versionField = "1.1"
    End Sub
    
    '''<comentarios/>
    <System.Xml.Serialization.XmlAttributeAttribute()>  _
    Public Property Version() As String
        Get
            Return Me.versionField
        End Get
        Set
            Me.versionField = value
        End Set
    End Property
    
    '''<comentarios/>
    <System.Xml.Serialization.XmlAttributeAttribute()>  _
    Public Property UUID() As String
        Get
            Return Me.uUIDField
        End Get
        Set
            Me.uUIDField = value
        End Set
    End Property
    
    '''<comentarios/>
    <System.Xml.Serialization.XmlAttributeAttribute()>  _
    Public Property FechaTimbrado() As Date
        Get
            Return Me.fechaTimbradoField
        End Get
        Set
            Me.fechaTimbradoField = value
        End Set
    End Property
    
    '''<comentarios/>
    <System.Xml.Serialization.XmlAttributeAttribute()>  _
    Public Property RfcProvCertif() As String
        Get
            Return Me.rfcProvCertifField
        End Get
        Set
            Me.rfcProvCertifField = value
        End Set
    End Property
    
    '''<comentarios/>
    <System.Xml.Serialization.XmlAttributeAttribute()>  _
    Public Property Leyenda() As String
        Get
            Return Me.leyendaField
        End Get
        Set
            Me.leyendaField = value
        End Set
    End Property
    
    '''<comentarios/>
    <System.Xml.Serialization.XmlAttributeAttribute()>  _
    Public Property SelloCFD() As String
        Get
            Return Me.selloCFDField
        End Get
        Set
            Me.selloCFDField = value
        End Set
    End Property
    
    '''<comentarios/>
    <System.Xml.Serialization.XmlAttributeAttribute()>  _
    Public Property NoCertificadoSAT() As String
        Get
            Return Me.noCertificadoSATField
        End Get
        Set
            Me.noCertificadoSATField = value
        End Set
    End Property
    
    '''<comentarios/>
    <System.Xml.Serialization.XmlAttributeAttribute()>  _
    Public Property SelloSAT() As String
        Get
            Return Me.selloSATField
        End Get
        Set
            Me.selloSATField = value
        End Set
    End Property
End Class
