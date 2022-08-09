Imports System.IO
Imports System.Xml.Serialization
Imports System.Data
Imports DevExpress.XtraReports.UI

Imports System.Data.SqlClient

Public Class R_Representacion_Fisica_CFDi33
    Private Sub R_Representacion_Fisica_CFDi33_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        Dim n As New Numalet
        Dim str As String = n.ToCustomString(Application.Session("total_comprobante"))
        Dim STRX = str.ToUpper.Replace("CON", "").Replace(".-", " MXN")
        XLConletras.Text = STRX

        XrBarCode1.Text = Application.Session("QR_SAT")



        '    Public string QR
        '{
        '    get
        '    {
        '        Byte[] qr = null;
        '        String sQR = "";
        '        String baseQR = "";

        '        qr = XMLToClassSAT.QR.createBarCode("https://verificacfdi.facturaelectronica.sat.gob.mx/default.aspx?id=" + TimbreFiscalDigital.UUID +
        '            "&re=" + Emisor.Rfc + "&fe=" + Receptor.Rfc + "&tt=" + Total + "&fe=" + Sello.Substring(Sello.Length - 9, 8));
        '        baseQR = System.Convert.ToBase64String(qr);
        '        sQR = System.String.Format("data:image/gif;base64,{0}", baseQR);

        '        Return sQR;
        '    }
        '}

    End Sub

    Private Sub R_Representacion_Fisica_CFDi33_DataSourceDemanded(sender As Object, e As EventArgs) Handles MyBase.DataSourceDemanded
        Try
            Me.DataSet_pREPRESENTACION_FISICA_CFDI_3_3_B1.Clear()


            Dim myDA = New SqlClient.SqlDataAdapter("[pREPRESENTACION_FISICA_CFDI_3_3_B]", Utilidades.sConexion)
            myDA.SelectCommand.CommandType = CommandType.StoredProcedure
            myDA.SelectCommand.Parameters.AddWithValue("@UUID", Application.Session("UUID_SAT"))
            myDA.Fill(Me.DataSet_pREPRESENTACION_FISICA_CFDI_3_3_B1.pREPRESENTACION_FISICA_CFDI_3_3_B)
            myDA.Dispose()
        Catch ex As Exception

        End Try



    End Sub


End Class