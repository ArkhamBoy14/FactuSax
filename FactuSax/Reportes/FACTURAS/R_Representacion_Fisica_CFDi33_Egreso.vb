Imports System.Drawing.Printing
Imports System.IO
Imports System.Xml.Serialization
Imports System.Data
Imports System.Data.SqlClient

Public Class R_Representacion_Fisica_CFDi33_Egreso

    Private Sub GroupFooter2_BeforePrint(sender As Object, e As PrintEventArgs) Handles GroupFooter2.BeforePrint

    End Sub

    Private Sub R_Representacion_Fisica_CFDi33_Egreso_BeforePrint(sender As Object, e As Drawing.Printing.PrintEventArgs) Handles MyBase.BeforePrint
        Dim n As New Numalet
        Dim str As String = n.ToCustomString(Application.Session("total_comprobante"))
        Dim STRX = str.ToUpper.Replace("CON", "").Replace(".-", " MXN")
        XLConletras.Text = STRX

        XrBarCode1.Text = Application.Session("QR_SAT")


    End Sub

    Private Sub R_Representacion_Fisica_CFDi33_Egreso_DataSourceDemanded(sender As Object, e As EventArgs) Handles MyBase.DataSourceDemanded
        Me.DataSet_pREPRESENTACION_FISICA_CFDI_3_3_B1.Clear()


        Dim myDA = New SqlClient.SqlDataAdapter("[pREPRESENTACION_FISICA_CFDI_3_3_B]", Utilidades.sConexion)
        myDA.SelectCommand.CommandType = CommandType.StoredProcedure
        myDA.SelectCommand.Parameters.AddWithValue("@UUID", Application.Session("UUID_SAT"))

        myDA.Fill(Me.DataSet_pREPRESENTACION_FISICA_CFDI_3_3_B1.pREPRESENTACION_FISICA_CFDI_3_3_B)
        myDA.Dispose()


    End Sub
End Class