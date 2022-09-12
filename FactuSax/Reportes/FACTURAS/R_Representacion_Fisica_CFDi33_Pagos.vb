Imports System.Drawing.Printing
Imports System.IO
Imports System.Xml.Serialization
Imports Gizmox.WebGUI.Forms
Imports SISLAB_WEB_EMPRESARIAL
Imports System.Data
Imports System.Data.SqlClient

Public Class R_Representacion_Fisica_CFDi33_Pagos

    Private Sub R_Representacion_Fisica_CFDi33_BeforePrint(sender As Object, e As PrintEventArgs) Handles MyBase.BeforePrint
        'Dim n As New Numalet
        'Dim str As String = n.ToCustomString(VWGContext.Current.Session("total_comprobante"))
        'Dim STRX = str.ToUpper.Replace("CON", "").Replace(".-", " MXN")
        'XLConletras.Text = STRX

        'XrBarCode1.Text = VWGContext.Current.Session("QR_SAT")



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
        Dim myDA = New SqlClient.SqlDataAdapter
        Try
            Me.DataSet_pREPRESENTACION_FISICA_CFDI_3_3_PAGOS_B11.Clear()

            Dim sProcedimiento As String = Application.Session("ProcedureName")

            If Application.Session("Historial_Pagos") = 1 Then
                myDA = New SqlClient.SqlDataAdapter("[pREPRESENTACION_FISICA_CFDI_3_3_pagos_Historico_B]", Utilidades.sConexion)

            Else
                myDA = New SqlClient.SqlDataAdapter("[pREPRESENTACION_FISICA_CFDI_3_3_pagos_B]", Utilidades.sConexion)

            End If
            'Dim myDA = New SqlClient.SqlDataAdapter("[pREPRESENTACION_FISICA_CFDI_3_3_pagos_B]", Utilidades.sConexion)
            myDA.SelectCommand.CommandType = CommandType.StoredProcedure
            myDA.SelectCommand.Parameters.AddWithValue("@UUID", Application.Session("UUID_SAT"))

            myDA.Fill(Me.DataSet_pREPRESENTACION_FISICA_CFDI_3_3_PAGOS_B11.pREPRESENTACION_FISICA_CFDI_3_3_pagos_B)
            myDA.Dispose()

        Catch ex As Exception

        End Try


    End Sub



    Private Sub GroupFooter1_BeforePrint(sender As Object, e As PrintEventArgs) Handles GroupFooter1.BeforePrint
        Dim letra, letra2 As String
        Dim TOTAL As Double = GetCurrentColumnValue("total")
        letra2 = Utilidades.Num2Text(TOTAL)
        letra = StrConv((letra2), VbStrConv.ProperCase, 1)
        XLConletras.Text = letra
        If Application.Session("Historial_Pagos") = 1 Then
            Dim sWhere As String
            sWhere = "@UUID_PADRE='" & GetCurrentColumnValue("UUID_PADRE") & "'"
            Dim rpt4 As New R_Representacion_Fisica_CFDi33_Complementos
            Utilidades.LlenarGrillaProcedure(rpt4, "pREPRESENTACION_FISICA_CFDI_3_3_Complementos_B " & sWhere, , "REPORTX", True)
            Subreport1.ReportSource = rpt4
        Else
            Dim sWhere As String
            sWhere = "@UUID='" & Application.Session("UUID_SAT") & "'"
            Dim rpt4 As New R_Representacion_Fisica_CFDi33_Complementos
            Utilidades.LlenarGrillaProcedure(rpt4, "pREPRESENTACION_FISICA_CFDI_3_3_Complementos_Individual_B " & sWhere, , "REPORTX", True)
            Subreport1.ReportSource = rpt4
        End If


    End Sub
End Class