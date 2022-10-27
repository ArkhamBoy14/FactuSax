Imports System
Imports System.Data
Imports FactuSax.mx.com.expidetufactura.cancelacionxpdv33
Imports Wisej.Web

Public Class Factura_Cancelacion
    Private Sub Factura_Cancelacion_Load(sender As Object, e As EventArgs) Handles Me.Load
        CbxMotivoCancelacion.LlenarListBox("pCAT_MOTIVOS_CANCELACION_SAT_B", "CLAVE", "descripx")
        consultar()

    End Sub

    Sub consultar()
        Dim myDA = New SqlClient.SqlDataAdapter("pFACTURA_SAT_CFDI_B2", Utilidades.sConexion)
        myDA.SelectCommand.CommandType = CommandType.StoredProcedure
        myDA.Fill(Me.DataSet_pFACTURA_SAT_CFDI_B21.pFACTURA_SAT_CFDI_B2)
        myDA.Dispose()
    End Sub

    Sub cancelarv3(index As Int16)
        Dim requestXpd, REQUESTDOS As New mx.com.expidetufactura.cancelacionxpd.Produccion.v3.cancelacionMultipleRequest
        Dim responseXpd() As mx.com.expidetufactura.cancelacionxpd.Produccion.v3.respuestaCliente
        Dim serviceClient As New mx.com.expidetufactura.cancelacionxpd.Produccion.v3.CancelacionPortService

        Dim rfcRecep As String = DataGridView1.Item(colReceptor_RFC, index).Value
        Dim rfcEmisor As String = DataGridView1.Item(colEmisor_Rfc, index).Value
        Dim ctotal As Double = DataGridView1.Item(colTotal, index).Value
        Dim ctotalXml As Object = DataGridView1.Item(colSubtotal, index).Value
        Dim sCERTIFICADO_CSD As String = DataGridView1.Item(colNocertificado_Emisor, index).Value
        Dim FOLIO_FISCAL_UUID As String = DataGridView1.Item(colUUID, index).Value


        requestXpd.usuario = "MARK800129HK4"
        requestXpd.contrasena = "NoydMPx5SblZ"
        requestXpd.pdfGenerar = True
        requestXpd.correo = "jose.lopez@saxsoft.com.mx" '"rousez2013@gmail.com"

        requestXpd.pdfNoPlantilla = "1"
        Dim sfolioSustitucion As String = UUID_RELACIONADO.Text

        Dim sMot As String = CbxMotivoCancelacion.SelectedValue



        Dim listParametros As New List(Of mx.com.expidetufactura.cancelacionxpd.Produccion.v3.parametrosCancelaMultiple)
        listParametros.Add(New mx.com.expidetufactura.cancelacionxpd.Produccion.v3.parametrosCancelaMultiple With
                {.noCertificado = sCERTIFICADO_CSD, .rfcEmisor = rfcEmisor, .rfcReceptor = rfcRecep, .total = ctotal, .uuid = FOLIO_FISCAL_UUID, .motivo = sMot, .folioSustitucion = sfolioSustitucion}
                           )


        requestXpd.parametros = listParametros.ToArray

        responseXpd = serviceClient.cancelacionMultiple(requestXpd)
        Dim respuestaa As String = responseXpd(0).mensaje
        Dim CANCE As Integer = 0
        If responseXpd.Length > 0 AndAlso responseXpd(0).codigo <> Nothing AndAlso responseXpd(0).mensaje = "Cancelado" Then
            CANCE = 1
        Else
            CANCE = 0
        End If



    End Sub



    Sub consultar_cfdi(index As Int16)
        Dim requestXpd, REQUESTDOS As New mx.com.expidetufactura.cancelacionxpd.Produccion.consultarCfdiRequest

        Dim serviceClient As New mx.com.expidetufactura.cancelacionxpd.Produccion.CancelacionPortService


        Dim rfcRecep As String = DataGridView1.Item(colReceptor_RFC, index).Value
        Dim rfcEmisor As String = DataGridView1.Item(colEmisor_Rfc, index).Value
        Dim ctotal As Double = DataGridView1.Item(colTotal, index).Value
        Dim ctotalXml As Object = DataGridView1.Item(colSubtotal, index).Value
        Dim sCERTIFICADO_CSD As String = DataGridView1.Item(colNocertificado_Emisor, index).Value
        Dim FOLIO_FISCAL_UUID As String = DataGridView1.Item(colUUID, index).Value

        requestXpd.usuario = "MARK800129HK4"
        requestXpd.contrasena = "NoydMPx5SblZ"


        Dim listParametrosx As New List(Of mx.com.expidetufactura.cancelacionxpd.Produccion.parametrosConsultarCfdi)
        listParametrosx.Add(New mx.com.expidetufactura.cancelacionxpd.Produccion.parametrosConsultarCfdi With
                {.noCertificado = sCERTIFICADO_CSD, .rfcEmisor = rfcEmisor, .rfcReceptor = rfcRecep,
                .total = ctotal, .uuid = FOLIO_FISCAL_UUID}
                          )



        requestXpd.parametros = listParametrosx.ToArray

        'verificar estatus del xml
        Dim xresponseXpd = serviceClient.consultarCfdi(requestXpd)
        Dim respuestaa As String = xresponseXpd(0).mensaje
        Dim CANCE As Integer = 0
        If xresponseXpd.Length > 0 AndAlso xresponseXpd(0).codigo <> Nothing AndAlso xresponseXpd(0).mensaje = "Vigente" Then
            MessageBox.Show("La factura es legible para cancelar")
        Else
            MessageBox.Show(xresponseXpd(0).mensaje)
        End If

    End Sub

    Sub cancelar_opcion_2(index As Int16)

        If CbxMotivoCancelacion.SelectedIndex = -1 Then
            MessageBox.Show("Favor de seleccionar un motivo")
            Exit Sub
        End If

        Dim requestXpd, REQUESTDOS As New mx.com.expidetufactura.cancelacionxpd.Produccion.cancelarCfdiRequest

        Dim serviceClient As New mx.com.expidetufactura.cancelacionxpd.Produccion.CancelacionPortService


        Dim rfcRecep As String = DataGridView1.Item(colReceptor_RFC, index).Value
        Dim rfcEmisor As String = DataGridView1.Item(colEmisor_Rfc, index).Value
        Dim ctotal As Double = DataGridView1.Item(colTotal, index).Value
        Dim ctotalXml As Object = DataGridView1.Item(colSubtotal, index).Value
        Dim sCERTIFICADO_CSD As String = DataGridView1.Item(colNocertificado_Emisor, index).Value
        Dim FOLIO_FISCAL_UUID As String = DataGridView1.Item(colUUID, index).Value

        requestXpd.usuario = "MARK800129HK4"
        requestXpd.contrasena = "NoydMPx5SblZ"



        Dim sfolioSustitucion As String = UUID_RELACIONADO.Text

        Dim sMot As String = CbxMotivoCancelacion.SelectedValue



        Dim listParametrosx As New List(Of mx.com.expidetufactura.cancelacionxpd.Produccion.parametrosCancelaCfdi)
        listParametrosx.Add(New mx.com.expidetufactura.cancelacionxpd.Produccion.parametrosCancelaCfdi With
                {.noCertificado = sCERTIFICADO_CSD, .rfcEmisor = rfcEmisor, .rfcReceptor = rfcRecep,
                .total = ctotal, .uuid = FOLIO_FISCAL_UUID, .motivo = sMot, .folioSustitucion = sfolioSustitucion}
                          )



        requestXpd.parametros = listParametrosx.ToArray


        'verificar estatus del xml
        Dim xresponseXpd = serviceClient.cancelarCfdi(requestXpd)
        Dim respuestaa As String = xresponseXpd(0).mensaje
        Dim CANCE As Integer = 0
        If xresponseXpd.Length > 0 AndAlso xresponseXpd(0).codigo <> Nothing AndAlso xresponseXpd(0).mensaje = "Cancelada" Then
            MessageBox.Show("La factura fue cancelada")
        Else
            MessageBox.Show(xresponseXpd(0).mensaje)
        End If

    End Sub



    Public Function Base64Encode(valor As String) As String
        Dim myByte As Byte() = System.Text.Encoding.UTF8.GetBytes(valor)
        Dim myBase64 As String = Convert.ToBase64String(myByte)
        Return myBase64
    End Function

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        For i As Int16 = 0 To DataGridView1.Rows.Count - 1
            If (DataGridView1.Item(Column0, i).Value = True) Then
                cancelarv3(i)
            End If

        Next
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        For i As Int16 = 0 To DataGridView1.Rows.Count - 1
            If (DataGridView1.Item(Column0, i).Value = True) Then
                consultar_cfdi(i)
            End If
        Next
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim facturacion As New Factura_Cancelacion
        facturacion.Show()
    End Sub
End Class
