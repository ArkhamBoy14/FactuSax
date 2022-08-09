Imports System
Imports Wisej.Web

Public Class Notificaciones

    Sub Tawk()
        Dim usuario As String = Application.Session("Cve_Operador").ToString
        JavaScript1.Eval("var USUARIO = '" + usuario + "';
        var Tawk_API=Tawk_API||{}, Tawk_LoadStart=new Date();

        (function(){
            Tawk_API.visitor = {
                name  : 'CICTAB-' +" + usuario + ",
                email : USUARIO + '@email.com'
            };

            var s1=document.createElement('script'),s0=document.getElementsByTagName('script')[0];
            s1.async=true;
            s1.src='https://embed.tawk.to/5a3be833bbdfe97b137fcc11/1c40kh7t4';
            s1.charset='UTF-8';
            s1.setAttribute('crossorigin','*');
            s0.parentNode.insertBefore(s1,s0);
        })();")
    End Sub

    Sub NotificacionExito(ByVal Mensaje As String, ByVal Titulo As String)
        CallNotifiaciones(Mensaje, Titulo, "success")
    End Sub
    Sub NotificacionInformacion(ByVal Mensaje As String, ByVal Titulo As String)
        CallNotifiaciones(Mensaje, Titulo, "info")
    End Sub
    Sub NotificacionAdvertencia(ByVal Mensaje As String, Optional ByVal Titulo As String = "Advertencia")
        CallNotifiaciones(Mensaje, Titulo, "warning")
    End Sub
    Sub NotificacionError(ByVal Mensaje As String, ByVal Titulo As String)
        CallNotifiaciones(Mensaje, Titulo, "error")
    End Sub
    Private Sub CallNotifiaciones(ByVal Mensaje As String, ByVal Titulo As String, ByVal Tipo As String)
        Try
            JavaScript1.Eval("toastr.options = {closeButton: true, progressBar: true, preventDuplicates:true, onclick: null};")
            Dim Invocar As String = "toastr." + Tipo + "('" + Mensaje + "', '" + Titulo + "', '');"
            JavaScript1.Eval(Invocar)
        Catch ex As Exception

        End Try
    End Sub
End Class
