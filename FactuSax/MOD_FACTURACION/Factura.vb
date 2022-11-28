Imports System.IO
Imports System.Xml
Imports System.Xml.Serialization
Imports System.Text
Imports System.Data
Imports System.Data.SqlClient
Imports System.Math
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting

Public Class Factura
    Dim pathxml As String
    Dim codeXml As String
    Dim ImporteTraslado As Double

    Function factura_html(emisor As String, receptor As String, cuerpo_factura As Dictionary(Of String, String), certificado As String, llave As String, claveprivada As String, conceptos As List(Of String),
                       traslado As List(Of String), totaliva As String, serieactiva As String, fechafactura As DateTime, Optional totalretenciones As String = Nothing, Optional retenciones As List(Of String) = Nothing, Optional FOLIO_FACTURAS As String = Nothing, Optional Sustitucion As Boolean = 0, Optional Periodicidad As List(Of String) = Nothing)
        Try

            Dim sumatoria As Double

            Dim nombrefactura As String = cuerpo_factura("Serie") & "_" & cuerpo_factura("Folio")

            pathxml = Application.StartupPath & "\Resources\SAT\FACTURAS\PUE\factura_" & nombrefactura & ".xml"
            Dim pdf = Application.StartupPath & "\Resources\SAT\FACTURAS\PUE\factura_" & nombrefactura & ".pdf"
            Dim pdfx = "\Resources\SAT\FACTURAS\PUE\factura_" & nombrefactura & ".pdf"
            Dim htmlx = "\Resources\SAT\FACTURAS\PUE\factura_" & nombrefactura & ".xml"

            Dim numeroCertificado, aa, b, c As String
            Dim descuentofactura As String = 0
            Sellodigital.leerCER(certificado, aa, b, c, numeroCertificado)
            Dim Impuestotraslado As New List(Of String)
            Dim comprobante As New Comprobante
            comprobante.xsiSchemaLocation = comprobante.xsiSchemaLocation
            comprobante.Version = "4.0"
            comprobante.Folio = cuerpo_factura("Folio")
            comprobante.Serie = cuerpo_factura("Serie")
            Dim fecha As String = fechafactura.ToString("yyyy-MM-ddTHH:mm:ss")

            comprobante.Fecha = fecha
            'comprobante.Sello = "faltante"
            'comprobante.Certificado = "faltante"
            comprobante.NoCertificado = numeroCertificado
            comprobante.FormaPago = cuerpo_factura("Foma_Pago")
            comprobante.FormaPagoSpecified = True
            comprobante.SubTotal = cuerpo_factura("Subtotal")
            comprobante.Moneda = cuerpo_factura("Moneda")
            comprobante.Total = cuerpo_factura("Total")
            comprobante.TipoDeComprobante = cuerpo_factura("Tipo_comprobante")
            comprobante.MetodoPago = cuerpo_factura("Metodo_pago")
            comprobante.LugarExpedicion = cuerpo_factura("Lugarexpedicion")
            comprobante.MetodoPagoSpecified = True
            comprobante.Exportacion = "01"

            If cuerpo_factura("Descuento") <> 0 Then
                comprobante.Descuento = cuerpo_factura("Descuento")
                descuentofactura = cuerpo_factura("Descuento")
                comprobante.DescuentoSpecified = True
            End If


            If Not cuerpo_factura("Tipo_Cambio") = Nothing Then
                comprobante.TipoCambio = cuerpo_factura("Tipo_Cambio")
                comprobante.TipoCambioSpecified = True
            End If



            If Not cuerpo_factura("Condiciones_Pago") = Nothing Then
                comprobante.CondicionesDePago = cuerpo_factura("Condiciones_Pago")

            End If

            Dim ce As New ComprobanteEmisor
            Dim split_e = emisor.Split("|")
            ce.Rfc = split_e(0)
            ce.Nombre = split_e(1)
            ce.RegimenFiscal = split_e(2)



            Dim cr As New ComprobanteReceptor
            Dim split_r = receptor.Split("|")
            cr.Nombre = Utilidades.ConvertirTextoPlano(split_r(1))
            cr.Rfc = split_r(0)
            cr.UsoCFDI = split_r(2)
            cr.UsoCFDI = "S01"

            cr.RegimenFiscalReceptor = split_r(3)
            If cr.Rfc = "XAXX010101000" Then
                cr.DomicilioFiscalReceptor = cuerpo_factura("Lugarexpedicion")
            Else
                cr.DomicilioFiscalReceptor = split_r(4)
            End If
            comprobante.Emisor = ce
            comprobante.Receptor = cr

            If cr.Rfc = "XAXX010101000" Then
                Dim split_per = Periodicidad(0).Split("|")
                Dim infG As New ComprobanteInformacionGlobal
                infG.Periodicidad = split_per(0)
                infG.Meses = split_per(1)
                infG.Año = split_per(2)
                comprobante.InformacionGlobal = infG
            End If



            Dim concepto As New ComprobanteConcepto
            Dim conceptosx As New List(Of ComprobanteConcepto)
            For i As Integer = 0 To conceptos.Count - 1
                Dim str As String = conceptos(i)
                Dim split = str.Split("|")
                Dim splitx = split(1).Split("-")
                concepto.Cantidad = split(0)
                concepto.ClaveProdServ = splitx(0).Trim
                concepto.ClaveUnidad = split(2)
                concepto.Descripcion = split(3)
                concepto.ValorUnitario = split(4)
                concepto.Importe = split(5)
                concepto.ObjetoImp = "02"
                If split(6) <> "0" Then
                    concepto.Descuento = split(6)
                    concepto.DescuentoSpecified = True
                End If

                concepto.NoIdentificacion = split(7)
                Dim descuentoconcepto As String = split(6)

                Dim imp As New ComprobanteConceptoImpuestos


                Dim imptraslados As New ComprobanteConceptoImpuestosTraslado
                imptraslados.ImporteSpecified = True
                imptraslados.TasaOCuotaSpecified = True
                Dim listaimptraslado As New List(Of ComprobanteConceptoImpuestosTraslado)

                For x As Integer = 0 To traslado.Count - 1
                    Dim splittras = traslado(0).Split("|")
                    'imptraslados.Base = split(5) - descuentoconcepto
                    imptraslados.Base = split(5)

                    imptraslados.Impuesto = splittras(0)
                    imptraslados.TipoFactor = splittras(2)
                    imptraslados.TasaOCuota = splittras(1)
                    'imptraslados.Base = splittras()
                    'imptraslados.Importe = Round((split(5) * splittras(1)) - descuentoconcepto, 4)
                    imptraslados.Importe = Round((split(5) * splittras(1)), 4)
                    ImporteTraslado = split(5)
                    Impuestotraslado.Add(split(5) - descuentoconcepto & "|" & splittras(0) & "|" & splittras(1) & "|" & splittras(2) & "|" & Round((split(5) - descuentoconcepto) * splittras(1), 4))
                    listaimptraslado.Add(imptraslados)
                    'sumatoria += Round((split(5) * splittras(1)) - descuentoconcepto, 4)
                    sumatoria += Round((split(5) * splittras(1)), 2)

                Next
                imp.Traslados = listaimptraslado.ToArray
                If Not totalretenciones = Nothing Then
                    Dim impretencciones As New ComprobanteConceptoImpuestosRetencion
                    Dim listaretenciones As New List(Of ComprobanteConceptoImpuestosRetencion)
                    Dim Impuestoretencion As New List(Of String)
                    For y As Integer = 0 To retenciones.Count - 1
                        Dim splitrentenciones = retenciones(0).Split("|")
                        impretencciones.Base = split(5) - descuentoconcepto
                        impretencciones.Impuesto = splitrentenciones(0)
                        impretencciones.TipoFactor = splitrentenciones(1)
                        impretencciones.TasaOCuota = splitrentenciones(2)
                        impretencciones.Importe = (split(5) * splitrentenciones(1)) - descuentoconcepto
                        'Impuestoretencion.Add(split(5) - descuentoconcepto & "|" & splitrentenciones(0) splitrentenciones(2))

                        listaretenciones.Add(impretencciones)
                    Next
                    imp.Retenciones = listaretenciones.ToArray
                End If
                concepto.Impuestos = imp
                conceptosx.Add(concepto)
                concepto = New ComprobanteConcepto
                imp = New ComprobanteConceptoImpuestos
            Next

            comprobante.Conceptos = conceptosx.ToArray






            Dim cim As New ComprobanteImpuestos
            cim.TotalImpuestosTrasladados = Round(sumatoria, 2)
            cim.TotalImpuestosTrasladadosSpecified = True
            Dim cimt As New ComprobanteImpuestosTraslado
            Dim cimtl As New List(Of ComprobanteImpuestosTraslado)
            For x As Integer = 0 To traslado.Count - 1
                Dim splitt = traslado(0).Split("|")
                cimt.Impuesto = splitt(0)
                cimt.TipoFactor = splitt(2)
                cimt.TasaOCuotaSpecified = True
                cimt.TasaOCuota = splitt(1)
                cimt.Base = ImporteTraslado
                cimt.ImporteSpecified = True
                cimt.Importe = Round(sumatoria, 2)
                cimtl.Add(cimt)
            Next
            cim.Traslados = cimtl.ToArray

            If Not totalretenciones = Nothing Then
                Dim cimr As New ComprobanteImpuestosRetencion
                Dim cimrl As New List(Of ComprobanteImpuestosRetencion)
                cim.TotalImpuestosRetenidos = totalretenciones
                cim.TotalImpuestosRetenidosSpecified = True
                For x As Integer = 0 To retenciones.Count - 1
                    Dim splitr = retenciones(0).Split("|")
                    cimr.Impuesto = splitr(0)
                    cimr.Importe = Round((cuerpo_factura("Subtotal") - descuentofactura) * splitr(1), 4)
                    cimrl.Add(cimr)
                Next
                cim.Retenciones = cimrl.ToArray
            End If

            comprobante.Impuestos = cim
            crearxml(comprobante, pathxml, False, pdf)
            Dim co = cadena_original(pathxml)
            Dim sellodig As New Sellodigital
            comprobante.Certificado = sellodig.Certificado(certificado)

            comprobante.Sello = sellodig.Sellar(co, llave, claveprivada)

            Dim repuesta_timbre = crearxml(comprobante, pathxml, True, pdf)
            Dim splitx_resp = repuesta_timbre.split("|")
            If splitx_resp(0) = "200" Then
                Dim BO As Boolean = True
                ACTUALIZAR_FOLIO(Application.Session("Cve_Cliente"))
                If Not Guardar_CFDI(splitx_resp(1), emisor, receptor, cuerpo_factura, fecha, comprobante.NoCertificado, co) = True Then
                    BO = False
                End If
                If Not guardar_conceptos(splitx_resp(1), conceptos, Impuestotraslado) = True Then
                    BO = False
                End If

                If Not GUARDAR_IMPUESTOS_CFDI(splitx_resp(1), traslado, totaliva, descuentofactura, cuerpo_factura("Subtotal")) = True Then
                    BO = False
                End If
                If FOLIO_FACTURAS <> Nothing Then
                    If Sustitucion = False Then
                        GUARDAR_UUID_FOLIO(splitx_resp(1), FOLIO_FACTURAS)
                    Else
                        GUARDAR_UUID_SUSTITUCION(splitx_resp(1), FOLIO_FACTURAS)
                    End If
                End If

                'BO = False '---------------------- Quitar pq no esta el reporte, solo para probar que guarde
                If BO = True Then
                    Guardar_XLM(codeXml, splitx_resp(1))
                    'MessageBox.Show("Factura timbrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim GuardarTimbre As New WebService_Timbres.Timbres()
                    Dim sBody As String = String.Format("rfc={0}&movimiento={1}&valor={2}", split_e(0), "TIMBRADAS", 1)
                    Utilidades.EnviarSolicitudControlTimbre(split_e(0), "TIMBRADAS", 1)

                    Dim XTRAREPORT As New XtraReport


                    XTRAREPORT = New R_Representacion_Fisica_CFDi33
                    Using ms As New MemoryStream()
                        Dim opts As PdfExportOptions = XTRAREPORT.ExportOptions.Pdf
                        Dim path As String = pdf
                        opts.Compressed = True
                        opts.ImageQuality = DevExpress.XtraPrinting.PdfJpegImageQuality.High
                        opts.DocumentOptions.Author = "Saxsoft"
                        opts.DocumentOptions.Application = "application/pdf"
                        opts.DocumentOptions.Title = "R_Representacion_Fisica_CFDi33"
                        XTRAREPORT.CreateDocument()
                        XTRAREPORT.ExportToPdf(path, opts)
                    End Using
                    Dim sReportName = "R_Representacion_Fisica_CFDi33"
                    If Trim(sReportName <> Nothing) Then
                        Application.Session("ReportName") = sReportName
                        Application.Session("DocumentCached") = Nothing
                        Application.Session("Modulo") = "DocumentViewer.aspx"
                        Dim Asp As New Mostrar_Asp()
                        Asp.Actualizar()
                        Asp.Show()
                    End If
                    Return splitx_resp(1)

                Else

                    MessageBox.Show("Error En Guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return Nothing
                End If
            Else
                MessageBox.Show("Error En Generar Factura", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function
    Sub Guardar_XLM(XML As String, UUID As String)
        ReDim Utilidades.ParametersX_Global(1)
        Utilidades.ParametersX_Global(0) = New SqlParameter("@UUID", UUID)
        Utilidades.ParametersX_Global(1) = New SqlParameter("@XML", XML)

        Dim SaveXML = Utilidades.EjecutarProcedure_Id("pFACTURA_SAT_UUID_XML_G", "@Parametro", Utilidades.ParametersX_Global)

    End Sub
    Function cadena_original(patxml As String)
        Try


            Dim cadena_originalx As String = ""
            Dim cadena_originalpath = Application.StartupPath & "\Resources\SAT\CADENA_ORIGINAL\cadenaoriginal_4_0.xslt"
            Dim TRANSFORMADOR As System.Xml.Xsl.XslCompiledTransform = New System.Xml.Xsl.XslCompiledTransform(True)
            TRANSFORMADOR.Load(cadena_originalpath)
            Using sw As IO.StringWriter = New IO.StringWriter
                Using xw As XmlWriter = XmlWriter.Create(sw, TRANSFORMADOR.OutputSettings)
                    TRANSFORMADOR.Transform(patxml, xw)
                    cadena_originalx = sw.ToString
                End Using
            End Using
            Return cadena_originalx
        Catch ex As Exception
            MessageBox.Show(ex.Message)
            Return Nothing
        End Try
    End Function

    Function crearxml(Comprobante As Comprobante, pathxml As String, timbrarx As Boolean, PDF As String, Optional Pagos As Boolean = False)
        Dim CERTIFICADO_CSD As String
        Dim SELLO_CFDI As String
        Dim SELLO_SAT As String
        Dim FOLIO_FISCAL_UUID As String
        Dim NO_SERIE_CERTIFICADO_SAT As String
        Dim FECHA_CERTIFICACION As String
        Dim LEYENDA As String
        Dim RfcProvCertif As String

        Try


            Dim xmlNameSpace As XmlSerializerNamespaces = New XmlSerializerNamespaces()
            'xmlNameSpace.Add("tfd", "http://www.sat.gob.mx/TimbreFiscalDigital")
            xmlNameSpace.Add("xsi", "http://www.w3.org/2001/XMLSchema-instance")
            xmlNameSpace.Add("cfdi", "http://www.sat.gob.mx/cfd/4")
            If Pagos = True Then
                xmlNameSpace.Add("pago20", "http://www.sat.gob.mx/Pagos20")

            End If
            Dim xmlserial As New XmlSerializer(GetType(Comprobante))
            Dim strxml As String = ""
                Dim utf8noBOM As Encoding = New UTF8Encoding(False)
                Dim settings As XmlWriterSettings = New XmlWriterSettings()
                Using vw = New miselaneo.StringWriterWithEncoding(Encoding.UTF8)
                    Using writer As XmlWriter = XmlWriter.Create(vw, settings)
                        xmlserial.Serialize(writer, Comprobante, xmlNameSpace)
                        strxml = vw.ToString
                    End Using
                End Using


                'Dim strarregaldo = strxml.Replace("Comprobante", "cfdi:Comprobante")
                'strarregaldo = strarregaldo.Replace("utf-8", "UTF-8")
                'Dim xdoc As New XmlDocument
                'xdoc.LoadXml(strarregaldo)
                strxml = strxml.Replace("<cfdi:ComprobanteComplemento>", "")
                strxml = strxml.Replace("</cfdi:ComprobanteComplemento>", "")
                strxml = strxml.Replace("<cfdi:ComprobanteComplemento xsi:nil=" & Chr(34) & "true" & Chr(34) & " />", "")
                strxml = strxml.Replace("xmlns:pago20=" & Chr(34) & "http://www.sat.gob.mx/Pagos20" & Chr(34) & ">", ">")



                System.IO.File.WriteAllText(pathxml, strxml)




                If timbrarx = True Then
                    Dim b = System.IO.File.ReadAllBytes(pathxml)
                    Dim cad = Convert.ToBase64String(b)
                    'Dim servicio As New XpdProduccion.TimbradoWSService
                    Dim servicio As New xpdPruebas4_0.TimbradoWSSoapSingle
                    Dim respuesta As New xpdPruebas4_0.responseTimbrar
                    respuesta = servicio.timbrar(Application.Session("Facturauser"), Application.Session("FacturaContrasena"), b)


                    If respuesta.codigo = "200" Then

                        System.IO.File.WriteAllText(pathxml, respuesta.timbre)
                        codeXml = respuesta.timbre

                        Dim comprobantex = Comprobante
                        Dim serilizador As New XmlSerializer(GetType(Comprobante))
                        'Try
                        '    Using reader As StreamReader = New StreamReader(pathxml)
                        '        comprobantex = serilizador.Deserialize(reader)
                        '        For Each complementos In comprobantex.Complemento
                        '            For Each interior In complementos.Any
                        '                Dim seriliz As XmlSerializer = New XmlSerializer(GetType(TimbreFiscalDigital))
                        '                Using readerx As New StringReader(interior.OuterXml)
                        '                    comprobantex.timbrefiscaldigital = seriliz.Deserialize(readerx)

                        '                End Using
                        '            Next
                        '        Next
                        '    End Using
                        'Catch ex As Exception

                        'End Try
                        Try

                            Dim texto As String = ""
                            texto = codeXml
                            CERTIFICADO_CSD = texto.Substring(texto.IndexOf("NoCertificado=""") + 15, 20)
                            SELLO_CFDI = texto.Substring(texto.IndexOf("SelloCFD=""") + 10, 344)
                            SELLO_SAT = texto.Substring(texto.IndexOf("SelloSAT=""") + 10, 344)
                            FOLIO_FISCAL_UUID = texto.Substring(texto.IndexOf("""UUID=""") + 8, 36) 'se cambio a 8 porq ya existen  UUID relacionados dentro del xml y traia el anterior 
                            NO_SERIE_CERTIFICADO_SAT = texto.Substring(texto.IndexOf("NoCertificadoSAT=""") + 18, 20)
                            FECHA_CERTIFICACION = CType((texto.Substring(texto.IndexOf("FechaTimbrado=""") + 15, 19)), DateTime)
                            If texto.Contains("Leyenda=""") Then
                                Dim Inicio = (texto.IndexOf("Leyenda=""") + 9)
                                Dim Fin = texto.IndexOf(""" NoCertificadoSAT=""")

                                LEYENDA = texto.Substring(Inicio, Fin - Inicio)
                            End If
                            RfcProvCertif = texto.Substring(texto.IndexOf("RfcProvCertif=""") + 15, 12)
                        Catch ex As Exception
                            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                        End Try

                        Application.Session("total_comprobante") = comprobantex.Total


                        'GUARDAR_TIMBRE(respuesta.uuid, pathxml, PDF, comprobantex.timbrefiscaldigital.Leyenda, comprobantex.timbrefiscaldigital.NoCertificadoSAT, comprobantex.timbrefiscaldigital.RfcProvCertif, comprobantex.timbrefiscaldigital.SelloCFD, comprobantex.timbrefiscaldigital.SelloSAT, comprobantex.timbrefiscaldigital.FechaTimbrado)
                        GUARDAR_TIMBRE(respuesta.uuid, pathxml, PDF, LEYENDA, SELLO_SAT, RfcProvCertif, SELLO_CFDI, SELLO_SAT, FECHA_CERTIFICACION)

                        Application.Session("QR_SAT") = "https://verificacfdi.facturaelectronica.sat.gob.mx/default.aspx?id=" & respuesta.uuid & "&re=" & comprobantex.Emisor.Rfc & "&fe=" & comprobantex.Receptor.Rfc & "&tt=" & comprobantex.Total & "&fe=" & comprobantex.Sello.Substring(comprobantex.Sello.Length - 9, 8)
                        Application.Session("UUID_SAT") = respuesta.uuid





                        Return "200" & "|" & respuesta.uuid


                    Else
                        MessageBox.Show(respuesta.mensaje)
                        Return respuesta.mensaje
                    End If

                End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function


    Sub ACTUALIZAR_FOLIO(serie_activa As String)
        Dim sDevuelveId
        ReDim Utilidades.ParametersX_Global(0)
        Utilidades.ParametersX_Global(0) = New SqlParameter("@Cve_Cliente", serie_activa)
        sDevuelveId = Utilidades.EjecutarProcedure_Id("[pCAT_SERIE_FOLIO_SAT_FACTURACION_INCREMENTAL]", "@Parametro", Utilidades.ParametersX_Global, , SqlDbType.VarChar, 50)

    End Sub


    Function Guardar_CFDI(uuid As String, emisor As String, receptor As String, cuerpo_factura As Dictionary(Of String, String), FECHA As String, NOCERTIFICADO_EMISOR As String, CADENA_ORIGINAL As String)
        Dim split_e = emisor.Split("|")
        Dim split_r = receptor.Split("|")
        If cuerpo_factura("Condiciones_Pago") = "" Or cuerpo_factura("Condiciones_Pago") = Nothing Then
            cuerpo_factura("Condiciones_Pago") = "NA"
        End If
        Dim sDevuelveId
        ReDim Utilidades.ParametersX_Global(26)
        Utilidades.ParametersX_Global(1) = New SqlClient.SqlParameter("@UUID", uuid)
        Utilidades.ParametersX_Global(2) = New SqlClient.SqlParameter("@Fecha", FECHA)
        Utilidades.ParametersX_Global(3) = New SqlClient.SqlParameter("@TipodeComprobante", cuerpo_factura("Tipo_comprobante"))
        Utilidades.ParametersX_Global(4) = New SqlClient.SqlParameter("@Subtotal", cuerpo_factura("Subtotal"))
        Utilidades.ParametersX_Global(5) = New SqlClient.SqlParameter("@Total", cuerpo_factura("Total"))
        Utilidades.ParametersX_Global(6) = New SqlClient.SqlParameter("@Moneda", cuerpo_factura("Moneda"))
        Utilidades.ParametersX_Global(7) = New SqlClient.SqlParameter("@FormaPago", cuerpo_factura("Foma_Pago"))
        Utilidades.ParametersX_Global(8) = New SqlClient.SqlParameter("@Serie", cuerpo_factura("Serie"))
        Utilidades.ParametersX_Global(9) = New SqlClient.SqlParameter("@Folio", cuerpo_factura("Folio"))
        Utilidades.ParametersX_Global(10) = New SqlClient.SqlParameter("@Emisor_Rfc", split_e(0))
        Utilidades.ParametersX_Global(11) = New SqlClient.SqlParameter("@Emisor_Nombre", split_e(1))
        Utilidades.ParametersX_Global(12) = New SqlClient.SqlParameter("@Emisro_Regimen_Fiscal", split_e(2))
        Utilidades.ParametersX_Global(13) = New SqlClient.SqlParameter("@Receptor_RFC", split_r(0))
        Utilidades.ParametersX_Global(14) = New SqlClient.SqlParameter("@receptor_UsoCFDI", split_r(2))
        Utilidades.ParametersX_Global(15) = New SqlClient.SqlParameter("@Receptor_Nombnre", split_r(1))
        Utilidades.ParametersX_Global(16) = New SqlClient.SqlParameter("@Descuento", cuerpo_factura("Descuento"))
        Utilidades.ParametersX_Global(17) = New SqlClient.SqlParameter("@TipoCambio", cuerpo_factura("Tipo_Cambio"))
        Utilidades.ParametersX_Global(18) = New SqlClient.SqlParameter("@CondicionesPago", cuerpo_factura("Condiciones_Pago"))
        Utilidades.ParametersX_Global(19) = New SqlClient.SqlParameter("@Estatus", "Timbrada")
        Utilidades.ParametersX_Global(20) = New SqlClient.SqlParameter("@MetodoPago", cuerpo_factura("Metodo_pago"))
        Utilidades.ParametersX_Global(21) = New SqlClient.SqlParameter("@LugarExpedicion", cuerpo_factura("Lugarexpedicion"))
        Utilidades.ParametersX_Global(22) = New SqlClient.SqlParameter("@Certificado_Emisor", NOCERTIFICADO_EMISOR)
        Utilidades.ParametersX_Global(23) = New SqlClient.SqlParameter("@Cadena_Original", CADENA_ORIGINAL)
        Utilidades.ParametersX_Global(24) = New SqlClient.SqlParameter("@TipoRelacion", cuerpo_factura("TipoRelacion"))
        Utilidades.ParametersX_Global(25) = New SqlClient.SqlParameter("@RegimenFiscalReceptor", split_r(3))




        sDevuelveId = Utilidades.EjecutarProcedure_Id("pFACTURA_SAT_CFDI_G", "@Parametro", Utilidades.ParametersX_Global, , SqlDbType.VarChar, 50)
        If sDevuelveId = Nothing Then
            Return False
        End If
        Return True
    End Function
    Sub GUARDAR_UUID_SUSTITUCION(UUID As String, UUID_PADRE As String)
        ReDim Utilidades.ParametersX_Global(1)

        Utilidades.ParametersX_Global(0) = New SqlParameter("@UUID_PADRE", UUID_PADRE)
        Utilidades.ParametersX_Global(1) = New SqlParameter("@UUDI_SUST", UUID)

        Dim sust = Utilidades.EjecutarProcedure_Id("pFACTURACION_SUSTITUCION_UUID_RELACIONADOS_G", "@Parametro", Utilidades.ParametersX_Global)
        If sust = 1 Then

        End If
    End Sub

    Function guardar_conceptos(uuid As String, conceptos As List(Of String), IMPUESTTRASLADO As List(Of String))

        For i As Integer = 0 To conceptos.Count - 1
            Dim str As String = conceptos(i)
            Dim split = str.Split("|")
            Dim splitx = split(1).Split("-")
            Dim SPLITX2 = IMPUESTTRASLADO(i).Split("|")
            ReDim Utilidades.ParametersX_Global(15)

            Dim sDevuelveId = Nothing
            Utilidades.ParametersX_Global(1) = New SqlClient.SqlParameter("@UUID", uuid)
            Utilidades.ParametersX_Global(2) = New SqlClient.SqlParameter("@ClaveProdServ", splitx(0))
            Utilidades.ParametersX_Global(3) = New SqlClient.SqlParameter("@ClaveUnidad", split(2))
            Utilidades.ParametersX_Global(4) = New SqlClient.SqlParameter("@Descripcion", split(3))
            Utilidades.ParametersX_Global(5) = New SqlClient.SqlParameter("@Valorunitario", split(4))
            Utilidades.ParametersX_Global(7) = New SqlClient.SqlParameter("@Importe", split(5))
            Utilidades.ParametersX_Global(8) = New SqlClient.SqlParameter("@NoIndetificacion", split(7))
            Utilidades.ParametersX_Global(9) = New SqlClient.SqlParameter("@Descuiento", split(6))
            Utilidades.ParametersX_Global(10) = New SqlClient.SqlParameter("@Cantidad", split(0))
            Utilidades.ParametersX_Global(11) = New SqlClient.SqlParameter("@BASE", SPLITX2(0))
            Utilidades.ParametersX_Global(12) = New SqlClient.SqlParameter("@IMPUESTO", SPLITX2(1))
            Utilidades.ParametersX_Global(13) = New SqlClient.SqlParameter("@TIPOFACTOR", SPLITX2(2))
            Utilidades.ParametersX_Global(14) = New SqlClient.SqlParameter("@TASACUOTA", SPLITX2(3))
            Utilidades.ParametersX_Global(15) = New SqlClient.SqlParameter("@IMPORTE_imp", SPLITX2(4))
            sDevuelveId = Utilidades.EjecutarProcedure_Id("pFACTURA_SAT_CONCEPTO_G", "@Parametro", Utilidades.ParametersX_Global, , SqlDbType.VarChar, 50)
            If sDevuelveId = Nothing Then
                Return False
            End If
        Next


        Return True
    End Function

    Function GUARDAR_IMPUESTOS_CFDI(UUID As String, TRASLADO As List(Of String), totaliva As String, DESCUENTOFACTURA As String, CUERPO_FACTURA_SUBTOTAL As String)

        For I As Integer = 0 To TRASLADO.Count - 1
            Dim SPLITT = TRASLADO(I).Split("|")
            Dim sDevuelveId
            ReDim Utilidades.ParametersX_Global(6)
            Utilidades.ParametersX_Global(1) = New SqlClient.SqlParameter("@UUID", UUID)
            Utilidades.ParametersX_Global(2) = New SqlClient.SqlParameter("@TOTALIMPUESTOTRASLADO", totaliva)
            Utilidades.ParametersX_Global(3) = New SqlClient.SqlParameter("@IMPUESTO", SPLITT(0))
            Utilidades.ParametersX_Global(4) = New SqlClient.SqlParameter("@TIPOFACTOR", SPLITT(2))
            Utilidades.ParametersX_Global(5) = New SqlClient.SqlParameter("@TASACUOTA", SPLITT(1))
            Utilidades.ParametersX_Global(6) = New SqlClient.SqlParameter("@IMPORTE", Round((CUERPO_FACTURA_SUBTOTAL - DESCUENTOFACTURA) * SPLITT(1), 2))
            sDevuelveId = Utilidades.EjecutarProcedure_Id("pFACTURA_SAT_CFDI_IMPUESTOS_G", "@Parametro", Utilidades.ParametersX_Global, , SqlDbType.VarChar, 50)
            If sDevuelveId = Nothing Then
                Return False
            End If
        Next
        Return True

    End Function

    Sub GUARDAR_TIMBRE(UUID As String, XML As String, PDF As String, leyenda As String, nocerti As String, rfcprov As String, sellocfd As String, sellosat As String, fechatimbrado As String)
        ReDim Utilidades.ParametersX_Global(9)
        Utilidades.ParametersX_Global(1) = New SqlClient.SqlParameter("@UUID", UUID)
        Utilidades.ParametersX_Global(2) = New SqlClient.SqlParameter("@XML", XML)
        Utilidades.ParametersX_Global(3) = New SqlClient.SqlParameter("@Leyenda", leyenda)
        Utilidades.ParametersX_Global(4) = New SqlClient.SqlParameter("@NoCertifiT", nocerti)
        Utilidades.ParametersX_Global(5) = New SqlClient.SqlParameter("@RtfProvCert", rfcprov)
        Utilidades.ParametersX_Global(6) = New SqlClient.SqlParameter("@SelloCFD", sellocfd)
        Utilidades.ParametersX_Global(7) = New SqlClient.SqlParameter("@SellaSAT", sellosat)
        Utilidades.ParametersX_Global(8) = New SqlClient.SqlParameter("@FechaTimrado", fechatimbrado)
        Utilidades.ParametersX_Global(9) = New SqlClient.SqlParameter("@PDF", PDF)

        Dim sDevuelveId
        sDevuelveId = Utilidades.EjecutarProcedure_Id("pFACTURA_SAT_TIMBRADA_G", "@Parametro", Utilidades.ParametersX_Global, , SqlDbType.VarChar, 50)
    End Sub

    Sub GUARDAR_UUID_FOLIO(UUID As String, Folio_Factura As String)
        Dim SPLIT As String() = Folio_Factura.Split(",")
        Dim SPLIT2 As String() = Application.Session("documentos_factura").SPLIT(",")

        For I As Integer = 0 To SPLIT.Count - 1
            If SPLIT(I) <> "" Then
                ReDim Utilidades.ParametersX_Global(3)
                Utilidades.ParametersX_Global(1) = New SqlClient.SqlParameter("@Folio", SPLIT(I))
                Utilidades.ParametersX_Global(2) = New SqlClient.SqlParameter("@UUID", UUID)
                Utilidades.ParametersX_Global(3) = New SqlClient.SqlParameter("@Cve_Cliente", SPLIT2(I))

                Dim sDevuelveId
                sDevuelveId = Utilidades.EjecutarProcedure_Id("pFACTURACION_FACTURA_SAT_CFDI", "@Parametro", Utilidades.ParametersX_Global, , SqlDbType.VarChar, 50)
            End If
        Next


    End Sub
    Sub GUARDAR_UUID_MOVIMIENTO(UUID As String, Folio_Factura As String)
        Dim SPLIT As String() = Folio_Factura.Split(",")
        Dim SPLIT2 As String() = Application.Session("documentos_factura").SPLIT(",")

        Dim dt_folios As New DataTable
        ReDim Utilidades.ParametersX_Global(1)
        Utilidades.ParametersX_Global(0) = New SqlClient.SqlParameter("@Folio_Movimiento", SPLIT(0))
        Utilidades.ParametersX_Global(0) = New SqlClient.SqlParameter("@AplicaSaldo", 1)

        dt_folios = Utilidades.llenar_dt("pFACTURACION_CAPTURA_EGRESOS", Utilidades.ParametersX_Global)

        For I As Integer = 0 To dt_folios.Rows.Count - 1
            If dt_folios.Rows(I).Item("Folio") <> "" Then
                ReDim Utilidades.ParametersX_Global(3)
                Utilidades.ParametersX_Global(0) = New SqlClient.SqlParameter("@Folio", dt_folios.Rows(I).Item("Folio"))
                Utilidades.ParametersX_Global(1) = New SqlClient.SqlParameter("@UUID", UUID)
                Utilidades.ParametersX_Global(2) = New SqlClient.SqlParameter("@Cve_Cliente", dt_folios.Rows(I).Item("Cve_Cliente"))

                Dim sDevuelveId
                sDevuelveId = Utilidades.EjecutarProcedure_Id("pFACTURACION_FACTURA_SAT_CFDI", "@Parametro", Utilidades.ParametersX_Global, , SqlDbType.VarChar, 50)
            End If
        Next


    End Sub


    Function factura_pagos_html(emisor As String, receptor As String, cuerpo_factura As Dictionary(Of String, String), certificado As String, llave As String, claveprivada As String, serieactiva As String, fechafactura As DateTime, pagos As Dictionary(Of String, String), documentorelacionado As Dictionary(Of String, Dictionary(Of String, String)), fechapago As DateTime, OBSERVACIONES As String)
        Dim nombrefactura As String = cuerpo_factura("Folio") & "_" & cuerpo_factura("Serie")

        pathxml = Application.StartupPath & "\Resources\SAT\FACTURAS\PDD\factura_" & nombrefactura & ".xml"
        Dim pdf = Application.StartupPath & "\Resources\SAT\FACTURAS\PDD\factura_" & nombrefactura & ".pdf"
        Dim pdfx = "\Resources\SAT\FACTURAS\PDD\factura " & nombrefactura & ".pdf"
        Dim htmlx = "\Resources\SAT\FACTURAS\PDD\factura " & nombrefactura & ".xml"

        Dim numeroCertificado, aa, b, c As String
        Dim descuentofactura As String = 0
        Sellodigital.leerCER(certificado, aa, b, c, numeroCertificado)
        Dim Impuestotraslado As New List(Of String)
        Dim comprobante As New Comprobante
        comprobante.Version = "4.0"
        comprobante.xsiSchemaLocation = comprobante.xsiSchemaLocation & " http://www.sat.gob.mx/Pagos20 http://www.sat.gob.mx/sitio_internet/cfd/Pagos/Pagos20.xsd"
        comprobante.Folio = cuerpo_factura("Folio")
        comprobante.Serie = cuerpo_factura("Serie")
        Dim fecha As String = Now.ToString("yyyy-MM-ddTHH:mm:ss")

        comprobante.Fecha = fecha
        'comprobante.Sello = "faltante"
        'comprobante.Certificado = "faltante"
        comprobante.NoCertificado = numeroCertificado
        'comprobante.FormaPago = cuerpo_factura("Foma_Pago")
        'cuerpo_factura.Add("Foma_Pago", "NA")
        comprobante.FormaPagoSpecified = True
        comprobante.SubTotal = cuerpo_factura("Subtotal")
        comprobante.Moneda = cuerpo_factura("Moneda")
        comprobante.Total = cuerpo_factura("Total")
        comprobante.TipoDeComprobante = cuerpo_factura("Tipo_comprobante")

        comprobante.LugarExpedicion = cuerpo_factura("Lugarexpedicion")
        comprobante.MetodoPagoSpecified = True
        comprobante.Exportacion = "01"








        Dim ce As New ComprobanteEmisor
        Dim split_e = emisor.Split("|")
        ce.Rfc = split_e(0)
        ce.Nombre = split_e(1)
        ce.RegimenFiscal = split_e(2)

        Dim cr As New ComprobanteReceptor
        Dim split_r = receptor.Split("|")
        cr.Nombre = split_r(1)
        cr.Rfc = split_r(0)
        cr.UsoCFDI = "CP01"
        cr.DomicilioFiscalReceptor = split_r(4)
        cr.RegimenFiscalReceptor = split_r(3)
        comprobante.Emisor = ce
        comprobante.Receptor = cr

        Dim concepto As New ComprobanteConcepto
        Dim conceptosx As New List(Of ComprobanteConcepto)
        concepto.Cantidad = "1"
        concepto.ClaveProdServ = "84111506"
        concepto.ClaveUnidad = "ACT"
        concepto.Descripcion = "Pago"
        concepto.ValorUnitario = "0"
        concepto.Importe = "0"
        concepto.ObjetoImp = "01"

        conceptosx.Add(concepto)
        concepto = New ComprobanteConcepto


        comprobante.Conceptos = conceptosx.ToArray


        Dim opagos As New Pagos
        Dim listapagos As New List(Of PagosPago)
        Dim pago As New PagosPago
        'pago.MonedaP = pagos("Moneda")
        pago.MonedaP = c_Moneda.Parse(GetType(c_Moneda), pagos("Moneda"))


        pago.FormaDePagoP = pagos("Forma_Pago")

        pago.Monto = pagos("Monto")
        pago.FechaPago = fechapago.ToString("yyyy-MM-ddTHH:mm:ss")
        pago.TipoCambioP = 1
        pago.TipoCambioPSpecified = True
        If pagos("CtaBeneficiaro") <> Nothing Then
            pago.CtaBeneficiario = pagos("CtaBeneficiaro")
        End If
        If pagos("RfcEmisorCtaBen") <> Nothing Then
            pago.RfcEmisorCtaBen = pagos("RfcEmisorCtaBen")
        End If

        If pagos("RfcEmisorCtaOrd") <> Nothing Then
            pago.RfcEmisorCtaOrd = pagos("RfcEmisorCtaOrd")
        End If


        Dim pdocumentor As New PagosPagoDoctoRelacionado
        Dim listapdocumentosr As New List(Of PagosPagoDoctoRelacionado)
        'Dim impDR As New PagosPagoDoctoRelacionadoImpuestosDR
        'Dim impt As New PagosPagoDoctoRelacionadoImpuestosDRTrasladoDR
        'Dim Listimpt As New List(Of PagosPagoDoctoRelacionadoImpuestosDRTrasladoDR)

        Dim pagT As New PagosTotales
        pagT.MontoTotalPagos = pagos("Monto")
        'pagT.TotalTrasladosBaseIVA16 = pagos("Monto")
        'pagT.TotalTrasladosBaseIVA16Specified = True
        'pagT.TotalTrasladosImpuestoIVA16 = (pagos("Monto") * 0.16)
        'pagT.TotalTrasladosImpuestoIVA16Specified = True
        opagos.Totales = pagT


        Dim list As New List(Of String)(documentorelacionado.Keys)
        For Each documento In list
            Dim dic As New Dictionary(Of String, String)
            dic = documentorelacionado(documento)
            pdocumentor.Folio = dic("FOLIO")
            pdocumentor.IdDocumento = dic("UUUID")
            pdocumentor.ImpPagado = dic("IMPORTE_PAGADO")
            pdocumentor.ImpSaldoAnt = dic("SALDO_ANTERIOR")
            pdocumentor.ImpSaldoInsoluto = (dic("SALDO_INSOLUTO"))
            pdocumentor.MonedaDR = c_Moneda.Parse(GetType(c_Moneda), dic("MONEDA"))
            pdocumentor.NumParcialidad = dic("PARCIALIDAD")
            pdocumentor.Serie = dic("SERIE")
            pdocumentor.EquivalenciaDR = 1
            pdocumentor.EquivalenciaDRSpecified = True
            'impt.BaseDR = dic("IMPORTE_PAGADO")
            'impt.ImpuestoDR = c_Impuesto.Item002
            'impt.TipoFactorDR = c_TipoFactor.Tasa
            'impt.TasaOCuotaDR = "0.160000"
            'impt.TasaOCuotaDRSpecified = True
            'impt.ImporteDR = (dic("IMPORTE_PAGADO") * impt.TasaOCuotaDR)
            'impt.ImporteDRSpecified = True

            'Listimpt.Add(impt)
            'impDR.TrasladosDR = Listimpt.ToArray
            'pdocumentor.ImpuestosDR = impDR
            listapdocumentosr.Add(pdocumentor)
            pdocumentor = New PagosPagoDoctoRelacionado

        Next
        pago.DoctoRelacionado = listapdocumentosr.ToArray

        'Dim ImpP As New PagosPagoImpuestosP
        'Dim TrasP As New PagosPagoImpuestosPTrasladoP
        'ReDim ImpP.TrasladosP(1)
        'TrasP.BaseP = pagos("Monto")
        'TrasP.ImpuestoP = c_Impuesto.Item002
        'TrasP.TipoFactorP = c_TipoFactor.Tasa
        'TrasP.TasaOCuotaP = "0.160000"
        'TrasP.TasaOCuotaPSpecified = True
        'TrasP.ImporteP = (pagos("Monto") * TrasP.TasaOCuotaP)
        'TrasP.ImportePSpecified = True

        'ImpP.TrasladosP(0) = TrasP
        'pago.ImpuestosP = ImpP




        Dim cp As ComprobanteComplemento()
        ReDim cp(1)
        comprobante.Complemento = cp
        comprobante.Complemento(0) = New ComprobanteComplemento

        listapagos.Add(pago)
        opagos.Pago = listapagos.ToArray

        Dim docPago As XmlDocument = New XmlDocument()
        Dim xmlNameSpacePago As XmlSerializerNamespaces = New XmlSerializerNamespaces()
        xmlNameSpacePago.Add("pago20", "http://www.sat.gob.mx/Pagos20")
        Using writer As XmlWriter = docPago.CreateNavigator().AppendChild()
            Dim x As New XmlSerializer(opagos.GetType())
            x.Serialize(writer, opagos, xmlNameSpacePago)
        End Using

        Dim xmlelement As XmlElement()
        ReDim xmlelement(1)

        comprobante.Complemento(0).Any = xmlelement
        comprobante.Complemento(0).Any(0) = docPago.DocumentElement



        crearxml(comprobante, pathxml, False, pdf, True)
        Dim co = cadena_original(pathxml)
        Dim sellodig As New Sellodigital
        comprobante.Certificado = sellodig.Certificado(certificado)
        comprobante.Sello = sellodig.Sellar(co, llave, claveprivada)

        Dim repuesta_timbre = crearxml(comprobante, pathxml, True, pdf, True)
        Dim splitx_resp = repuesta_timbre.split("|")
        If splitx_resp(0) = "200" Then
            Dim BO As Boolean = True
            ACTUALIZAR_FOLIO(Application.Session("Cve_Cliente"))
            If Not Guardar_CFDI(splitx_resp(1), emisor, receptor, cuerpo_factura, fecha, comprobante.NoCertificado, co) = True Then
                BO = False
            End If
            If Not GUARDAR_COMPROBANTEPAGO(splitx_resp(1), pagos, OBSERVACIONES, fecha, fechapago) = True Then
                BO = False
            End If
            If Not GUARDAR_UUID_RELACIONADOS(splitx_resp(1), documentorelacionado) = True Then
                BO = False
            End If
            'If Not guardar_conceptos(splitx_resp(1), conceptos, Impuestotraslado) = True Then
            '    BO = False
            'End If

            ''If Not GUARDAR_IMPUESTOS_CFDI(splitx_resp(1), traslado, totaliva, descuentofactura, cuerpo_factura("Subtotal")) = True Then
            ''    BO = False
            ''End If

            'GUARDAR_UUID_FOLIO(splitx_resp(1))

            If BO = True Then
                Guardar_XLM(codeXml, splitx_resp(1))

                Dim sBody As String = String.Format("rfc={0}&movimiento={1}&valor={2}", split_e(0), "TIMBRADAS", 1)
                Utilidades.EnviarSolicitudControlTimbre(split_e(0), "TIMBRADAS", 1)

                MessageBox.Show("Comprovante de Pago timbrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Dim XTRAREPORT As New XtraReport
                Application.Session("Historial_Pagos") = 0

                XTRAREPORT = New R_Representacion_Fisica_CFDi33_Pagos
                Using ms As New MemoryStream()
                    Dim opts As PdfExportOptions = XTRAREPORT.ExportOptions.Pdf
                    Dim path As String = pdf
                    opts.Compressed = True
                    opts.ImageQuality = DevExpress.XtraPrinting.PdfJpegImageQuality.High
                    opts.DocumentOptions.Author = "Saxsoft"
                    opts.DocumentOptions.Application = "application/pdf"
                    opts.DocumentOptions.Title = "R_Representacion_Fisica_CFDi33"
                    XTRAREPORT.CreateDocument()
                    XTRAREPORT.ExportToPdf(path, opts)
                End Using
                Return pdfx & "-" & htmlx

            Else

                MessageBox.Show("Error En Guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Return Nothing
            End If
        Else
            MessageBox.Show("Error En Generar Factura", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Function


    Function GUARDAR_COMPROBANTEPAGO(UUID As String, pagos As Dictionary(Of String, String), observacion As String, FECHA As String, fechapago As DateTime)


        If observacion = "" Or observacion = Nothing Then
            observacion = "NA"
        End If
        ReDim Utilidades.ParametersX_Global(10)
        Utilidades.ParametersX_Global(0) = New SqlClient.SqlParameter("@UUID", UUID)
        Utilidades.ParametersX_Global(1) = New SqlClient.SqlParameter("@FECHA_PAGO", fechapago.ToString("yyyy-MM-ddTHH:mm:ss"))
        Utilidades.ParametersX_Global(2) = New SqlClient.SqlParameter("@FRMAPAGO", pagos("Forma_Pago"))
        Utilidades.ParametersX_Global(3) = New SqlClient.SqlParameter("@MONEDA", pagos("Moneda"))
        Utilidades.ParametersX_Global(4) = New SqlClient.SqlParameter("@MONTO", pagos("Monto"))
        Utilidades.ParametersX_Global(5) = New SqlClient.SqlParameter("@RfcEmisorCtaOrd", IIf(pagos("RfcEmisorCtaOrd") = Nothing, "NA", pagos("RfcEmisorCtaOrd")))
        Utilidades.ParametersX_Global(6) = New SqlClient.SqlParameter("@RfcEmisorCtaBen", IIf(pagos("RfcEmisorCtaBen") = Nothing, "NA", pagos("RfcEmisorCtaBen")))
        Utilidades.ParametersX_Global(7) = New SqlClient.SqlParameter("@CtaBeneficiario", IIf(pagos("CtaBeneficiaro") = Nothing, "NA", pagos("CtaBeneficiaro")))
        Utilidades.ParametersX_Global(8) = New SqlClient.SqlParameter("@OBSERVACIONES", observacion)
        Utilidades.ParametersX_Global(9) = New SqlClient.SqlParameter("@ESTATUS", "TIMBRADO")
        Utilidades.ParametersX_Global(10) = New SqlClient.SqlParameter("@FECHA_EMISION", FECHA)

        Dim sDevuelveId
        sDevuelveId = Utilidades.EjecutarProcedure_Id("pFACTURACION_SAT_COMPROBANTE_PAGO_G", "@Parametro", Utilidades.ParametersX_Global, , SqlDbType.VarChar, 50)
        '
        If sDevuelveId = Nothing Then
            Return False
        End If
        Return True
    End Function

    Function GUARDAR_UUID_RELACIONADOS(UUIDP As String, CONCEPTOSX As Dictionary(Of String, Dictionary(Of String, String)))

        Dim list As New List(Of String)(CONCEPTOSX.Keys)
        For Each documento In list
            Dim dic As New Dictionary(Of String, String)
            dic = CONCEPTOSX(documento)
            ReDim Utilidades.ParametersX_Global(6)
            Utilidades.ParametersX_Global(1) = New SqlClient.SqlParameter("@UUIDP", UUIDP)
            Utilidades.ParametersX_Global(2) = New SqlClient.SqlParameter("@UUID_CFDI", dic("UUUID"))
            Utilidades.ParametersX_Global(3) = New SqlClient.SqlParameter("@PARCIALIDAD", dic("PARCIALIDAD"))
            Utilidades.ParametersX_Global(4) = New SqlClient.SqlParameter("@IMPORTE_PAGADO", dic("IMPORTE_PAGADO"))
            Utilidades.ParametersX_Global(5) = New SqlClient.SqlParameter("@SALDO_ANTERIOR", dic("SALDO_ANTERIOR"))
            Utilidades.ParametersX_Global(6) = New SqlClient.SqlParameter("@IMPORTE_INSOLUTO", dic("SALDO_INSOLUTO"))
            Dim sDevuelveId
            sDevuelveId = Utilidades.EjecutarProcedure_Id("pFACTURACION_SAT_PAGOS_UUID_RELACIONADOS_G", "@Parametro", Utilidades.ParametersX_Global, , SqlDbType.VarChar, 50)

            If sDevuelveId = Nothing Then
                Return False
            End If

        Next
        Return True

    End Function

    Function GUARDAR_UUID_RELACIONADOS_NOT_CREDITO(UUIDP As String, UUID_RELACIONADO As String)





        ReDim Utilidades.ParametersX_Global(6)
        Utilidades.ParametersX_Global(1) = New SqlClient.SqlParameter("@UUIDP", UUIDP)
        Utilidades.ParametersX_Global(2) = New SqlClient.SqlParameter("@UUID_CFDI", UUID_RELACIONADO)
        Dim sDevuelveId
        sDevuelveId = Utilidades.EjecutarProcedure_Id("[pFACTURACION_SAT_NOTACREDITO_UUID_RELACIONADOS_G]", "@Parametro", Utilidades.ParametersX_Global, , SqlDbType.VarChar, 50)

        If sDevuelveId = Nothing Then
            Return False
        End If


        Return True

    End Function
    Function factura_emisor_html(emisor As String, receptor As String, cuerpo_factura As Dictionary(Of String, String), certificado As String, llave As String, claveprivada As String, conceptos As List(Of String),
                      traslado As List(Of String), totaliva As String, serieactiva As String, fechafactura As DateTime, UUID_RELACIONADO As String, Optional totalretenciones As String = Nothing, Optional retenciones As List(Of String) = Nothing)
        Try


            Dim nombrefactura As String = cuerpo_factura("Serie") & "_" & cuerpo_factura("Folio")

            pathxml = Application.StartupPath & "\Resources\SAT\FACTURAS\PUE\factura_" & nombrefactura & ".xml"
            Dim pdf = Application.StartupPath & "\Resources\SAT\FACTURAS\PUE\factura_" & nombrefactura & ".pdf"
            Dim pdfx = "\Resources\SAT\FACTURAS\PUE\factura_" & nombrefactura & ".pdf"
            Dim htmlx = "\Resources\SAT\FACTURAS\PUE\factura_" & nombrefactura & ".xml"
            Dim numeroCertificado, aa, b, c As String
            Dim descuentofactura As String = 0
            Sellodigital.leerCER(certificado, aa, b, c, numeroCertificado)
            Dim Impuestotraslado As New List(Of String)
            Dim comprobante As New Comprobante
            comprobante.Version = "4.0"
            comprobante.Folio = cuerpo_factura("Folio")
            comprobante.Serie = cuerpo_factura("Serie")
            Dim fecha As String = fechafactura.ToString("yyyy-MM-ddTHH:mm:ss")

            comprobante.Fecha = fecha
            'comprobante.Sello = "faltante"
            'comprobante.Certificado = "faltante"
            comprobante.NoCertificado = numeroCertificado
            comprobante.FormaPago = cuerpo_factura("Foma_Pago")
            comprobante.FormaPagoSpecified = True
            comprobante.SubTotal = cuerpo_factura("Subtotal")
            comprobante.Moneda = cuerpo_factura("Moneda")
            comprobante.Total = cuerpo_factura("Total")
            comprobante.TipoDeComprobante = cuerpo_factura("Tipo_comprobante")
            comprobante.MetodoPago = cuerpo_factura("Metodo_pago")
            comprobante.LugarExpedicion = cuerpo_factura("Lugarexpedicion")
            comprobante.MetodoPagoSpecified = True
            comprobante.Exportacion = "01"
            Dim RELACION As New ComprobanteCfdiRelacionados
            Dim RELACIONLIS As New ComprobanteCfdiRelacionadosCfdiRelacionado
            Dim RELACIONLISx As New List(Of ComprobanteCfdiRelacionadosCfdiRelacionado)
            RELACIONLIS.UUID = cuerpo_factura("RelacionUIID")

            RELACIONLISx.Add(RELACIONLIS)
            RELACION.CfdiRelacionado = RELACIONLISx.ToArray
            RELACION.TipoRelacion = cuerpo_factura("TipoRelacion")

            comprobante.CfdiRelacionados = RELACION
            comprobante.CfdiRelacionados.TipoRelacion = cuerpo_factura("TipoRelacion")
            'comprobante.CfdiRelacionados.TipoRelacion = "G03"
            'comprobante.CfdiRelacionados = "G03"
            If cuerpo_factura("Descuento") <> 0 Then
                comprobante.Descuento = cuerpo_factura("Descuento")
                descuentofactura = cuerpo_factura("Descuento")
                comprobante.DescuentoSpecified = True
            End If

            Dim ce As New ComprobanteEmisor
            Dim split_e = emisor.Split("|")
            ce.Rfc = split_e(0)
            ce.Nombre = split_e(1)
            ce.RegimenFiscal = split_e(2)

            Dim cr As New ComprobanteReceptor
            Dim split_r = receptor.Split("|")
            cr.Nombre = split_r(1)
            cr.Rfc = split_r(0)
            cr.UsoCFDI = split_r(2)
            cr.DomicilioFiscalReceptor = split_r(4)
            cr.RegimenFiscalReceptor = split_r(3)
            comprobante.Emisor = ce
            comprobante.Receptor = cr

            Dim concepto As New ComprobanteConcepto
            Dim conceptosx As New List(Of ComprobanteConcepto)
            For i As Integer = 0 To conceptos.Count - 1
                Dim str As String = conceptos(i)
                Dim split = str.Split("|")
                Dim splitx = split(1).Split("-")
                concepto.Cantidad = split(0)
                concepto.ClaveProdServ = splitx(0).Trim
                concepto.ClaveUnidad = split(2)
                concepto.Descripcion = split(3)
                concepto.ValorUnitario = split(4)
                concepto.Importe = split(5)
                concepto.ObjetoImp = "02"
                If split(6) <> "0" Then
                    concepto.Descuento = split(6)
                    concepto.DescuentoSpecified = True
                End If

                concepto.NoIdentificacion = split(7)
                Dim descuentoconcepto As String = split(6)

                Dim imp As New ComprobanteConceptoImpuestos


                Dim imptraslados As New ComprobanteConceptoImpuestosTraslado
                imptraslados.ImporteSpecified = True
                imptraslados.TasaOCuotaSpecified = True
                Dim listaimptraslado As New List(Of ComprobanteConceptoImpuestosTraslado)

                For x As Integer = 0 To traslado.Count - 1
                    Dim splittras = traslado(0).Split("|")
                    imptraslados.Base = split(4) - descuentoconcepto
                    imptraslados.Impuesto = splittras(0)
                    imptraslados.TipoFactor = splittras(2)
                    imptraslados.TasaOCuota = splittras(1)
                    imptraslados.Importe = Round((split(4) - descuentoconcepto) * splittras(1), 2)
                    Impuestotraslado.Add(split(5) - descuentoconcepto & "|" & splittras(0) & "|" & splittras(2) & "|" & splittras(1) & "|" & Round((split(4) - descuentoconcepto) * splittras(1), 3))
                    listaimptraslado.Add(imptraslados)
                Next
                imp.Traslados = listaimptraslado.ToArray
                If Not totalretenciones = Nothing Then
                    Dim impretencciones As New ComprobanteConceptoImpuestosRetencion
                    Dim listaretenciones As New List(Of ComprobanteConceptoImpuestosRetencion)
                    Dim Impuestoretencion As New List(Of String)
                    For y As Integer = 0 To retenciones.Count - 1
                        Dim splitrentenciones = retenciones(0).Split("|")
                        impretencciones.Base = split(5) - descuentoconcepto
                        impretencciones.Impuesto = splitrentenciones(0)
                        impretencciones.TipoFactor = splitrentenciones(2)
                        impretencciones.TasaOCuota = splitrentenciones(1)
                        impretencciones.Importe = (split(5) - descuentoconcepto) * splitrentenciones(1)
                        'Impuestoretencion.Add(split(5) - descuentoconcepto & "|" & splitrentenciones(0) splitrentenciones(2))

                        listaretenciones.Add(impretencciones)
                    Next
                    imp.Retenciones = listaretenciones.ToArray
                End If
                concepto.Impuestos = imp
                conceptosx.Add(concepto)
                concepto = New ComprobanteConcepto
                imp = New ComprobanteConceptoImpuestos
            Next

            comprobante.Conceptos = conceptosx.ToArray

            Dim cim As New ComprobanteImpuestos
            cim.TotalImpuestosTrasladados = totaliva
            cim.TotalImpuestosTrasladadosSpecified = True
            Dim cimt As New ComprobanteImpuestosTraslado
            Dim cimtl As New List(Of ComprobanteImpuestosTraslado)
            For x As Integer = 0 To traslado.Count - 1
                Dim splitt = traslado(0).Split("|")
                cimt.Base = cuerpo_factura("Subtotal")
                cimt.Impuesto = splitt(0)
                cimt.TasaOCuota = splitt(1)
                cimt.TasaOCuotaSpecified = True
                cimt.Importe = Round((cuerpo_factura("Subtotal") - descuentofactura) * splitt(1), 2)
                cimt.ImporteSpecified = True
                cimt.TipoFactor = splitt(2)
                cimtl.Add(cimt)
            Next
            cim.Traslados = cimtl.ToArray

            If Not totalretenciones = Nothing Then
                Dim cimr As New ComprobanteImpuestosRetencion
                Dim cimrl As New List(Of ComprobanteImpuestosRetencion)
                cim.TotalImpuestosRetenidos = totalretenciones
                cim.TotalImpuestosRetenidosSpecified = True
                For x As Integer = 0 To retenciones.Count - 1
                    Dim splitr = retenciones(0).Split("|")
                    cimr.Impuesto = splitr(0)
                    cimr.Importe = Round((cuerpo_factura("Subtotal") - descuentofactura) * splitr(1), 2)
                    cimrl.Add(cimr)
                Next
                cim.Retenciones = cimrl.ToArray
            End If

            comprobante.Impuestos = cim
            crearxml(comprobante, pathxml, False, pdf)
            Dim co = cadena_original(pathxml)
            Dim sellodig As New Sellodigital
            comprobante.Certificado = sellodig.Certificado(certificado)

            comprobante.Sello = sellodig.Sellar(co, llave, claveprivada)

            Dim repuesta_timbre = crearxml(comprobante, pathxml, True, pdf)
            Dim splitx_resp = repuesta_timbre.split("|")
            If splitx_resp(0) = "200" Then
                Dim BO As Boolean = True
                ACTUALIZAR_FOLIO(Application.Session("Cve_Sucursal"))
                If Not Guardar_CFDI(splitx_resp(1), emisor, receptor, cuerpo_factura, fecha, comprobante.NoCertificado, co) = True Then
                    BO = False
                End If

                If Not guardar_conceptos(splitx_resp(1), conceptos, Impuestotraslado) = True Then
                    BO = False
                End If

                If Not GUARDAR_IMPUESTOS_CFDI(splitx_resp(1), traslado, totaliva, descuentofactura, cuerpo_factura("Subtotal")) = True Then
                    BO = False
                End If

                If Not GUARDAR_UUID_RELACIONADOS_NOT_CREDITO(splitx_resp(1), UUID_RELACIONADO) = True Then
                    BO = False
                End If

                'GUARDAR_UUID_FOLIO(splitx_resp(1))

                If BO = True Then
                    Guardar_XLM(codeXml, splitx_resp(1))

                    'MessageBox.Show("Factura timbrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim XTRAREPORT As New XtraReport
                    Dim sBody As String = String.Format("rfc={0}&movimiento={1}&valor={2}", split_e(0), "TIMBRADAS", 1)
                    Utilidades.EnviarSolicitudControlTimbre(split_e(0), "TIMBRADAS", 1)

                    XTRAREPORT = New R_Representacion_Fisica_CFDi33
                    Using ms As New MemoryStream()
                        Dim opts As PdfExportOptions = XTRAREPORT.ExportOptions.Pdf
                        Dim path As String = pdf
                        opts.Compressed = True
                        opts.ImageQuality = DevExpress.XtraPrinting.PdfJpegImageQuality.High
                        opts.DocumentOptions.Author = "Saxsoft"
                        opts.DocumentOptions.Application = "application/pdf"
                        opts.DocumentOptions.Title = "R_Resultado_Adnlab_Mail"
                        XTRAREPORT.CreateDocument()
                        XTRAREPORT.ExportToPdf(path, opts)
                    End Using
                    Return pdfx & "-" & htmlx

                Else

                    MessageBox.Show("Error En Guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return Nothing
                End If
            Else
                MessageBox.Show("Error En Generar Factura", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    'Function Cancelar_Factura(LLAVE As String, CER As String, RFC_EMISOR As String, RFC_RECEPTOR As String, TOTAL As String, UUID As String)
    '    Dim cancelarx As New Expidetufactura_cancelacionCFDI.cancelacionMultipleRequest
    '    Dim cancelarxrespuesta() As Expidetufactura_cancelacionCFDI.respuestaCliente
    '    Dim respuesta As String
    '    Dim CLIENTE As New Expidetufactura_cancelacionCFDI.CancelacionPortClient
    '    Dim list As New List(Of Expidetufactura_cancelacionCFDI.parametrosCancelaMultiple)

    '    list.Add(New Expidetufactura_cancelacionCFDI.parametrosCancelaMultiple With {.noCertificado = CER, .rfcEmisor = RFC_EMISOR, .rfcReceptor = RFC_RECEPTOR, .TOTAL = TOTAL, .UUID = UUID})
    '    cancelarx.contrasena = Application.Session("FacturaContrasena")
    '    cancelarx.usuario = Application.Session("Facturauser")
    '    cancelarx.pdfGenerar = True
    '    cancelarx.correo = "arkhanan@gmail.com"
    '    cancelarx.pdfNoPlantilla = "1"
    '    cancelarx.parametros = list.ToArray
    '    cancelarxrespuesta = CLIENTE.cancelacionMultiple(cancelarx)
    '    If cancelarxrespuesta(0).codigo = "200" Then
    '        respuesta = cancelarxrespuesta(0).codigo + " |consulta:" + cancelarxrespuesta(0).responseConsulta
    '        Return respuesta
    '    Else
    '        Return respuesta
    '    End If
    'End Function

    Function factura_Movimiento_html(emisor As String, receptor As String, cuerpo_factura As Dictionary(Of String, String), certificado As String, llave As String, claveprivada As String, conceptos As List(Of String),
                      traslado As List(Of String), totaliva As String, serieactiva As String, fechafactura As DateTime, Optional totalretenciones As String = Nothing, Optional retenciones As List(Of String) = Nothing, Optional FOLIO_FACTURAS As String = Nothing)
        Try

            Dim sumatoria As Double

            Dim nombrefactura As String = cuerpo_factura("Serie") & "_" & cuerpo_factura("Folio")

            pathxml = Application.StartupPath & "\Resources\SAT\FACTURAS\PUE\factura_" & nombrefactura & ".xml"
            Dim pdf = Application.StartupPath & "\Resources\SAT\FACTURAS\PUE\factura_" & nombrefactura & ".pdf"
            Dim pdfx = "\Resources\SAT\FACTURAS\PUE\factura_" & nombrefactura & ".pdf"
            Dim htmlx = "\Resources\SAT\FACTURAS\PUE\factura_" & nombrefactura & ".xml"

            Dim numeroCertificado, aa, b, c As String
            Dim descuentofactura As String = 0
            Sellodigital.leerCER(certificado, aa, b, c, numeroCertificado)
            Dim Impuestotraslado As New List(Of String)
            Dim comprobante As New Comprobante
            comprobante.Version = "4.0"
            comprobante.Folio = cuerpo_factura("Folio")
            comprobante.Serie = cuerpo_factura("Serie")
            Dim fecha As String = fechafactura.ToString("yyyy-MM-ddTHH:mm:ss")

            comprobante.Fecha = fecha
            'comprobante.Sello = "faltante"
            'comprobante.Certificado = "faltante"
            comprobante.NoCertificado = numeroCertificado
            comprobante.FormaPago = cuerpo_factura("Foma_Pago")
            comprobante.FormaPagoSpecified = True
            comprobante.SubTotal = cuerpo_factura("Subtotal")
            comprobante.Moneda = cuerpo_factura("Moneda")
            comprobante.Total = cuerpo_factura("Total")
            comprobante.TipoDeComprobante = cuerpo_factura("Tipo_comprobante")
            comprobante.MetodoPago = cuerpo_factura("Metodo_pago")
            comprobante.LugarExpedicion = cuerpo_factura("Lugarexpedicion")
            comprobante.MetodoPagoSpecified = True


            If cuerpo_factura("Descuento") <> 0 Then
                comprobante.Descuento = cuerpo_factura("Descuento")
                descuentofactura = cuerpo_factura("Descuento")
                comprobante.DescuentoSpecified = True
            End If


            If Not cuerpo_factura("Tipo_Cambio") = Nothing Then
                comprobante.TipoCambio = cuerpo_factura("Tipo_Cambio")
                comprobante.TipoCambioSpecified = True
            End If



            If Not cuerpo_factura("Condiciones_Pago") = Nothing Then
                comprobante.CondicionesDePago = cuerpo_factura("Condiciones_Pago")

            End If

            Dim ce As New ComprobanteEmisor
            Dim split_e = emisor.Split("|")
            ce.Rfc = split_e(0)
            ce.Nombre = split_e(1)
            ce.RegimenFiscal = split_e(2)

            Dim cr As New ComprobanteReceptor
            Dim split_r = receptor.Split("|")
            cr.Nombre = split_r(1)
            cr.Rfc = split_r(0)
            cr.UsoCFDI = split_r(2)
            comprobante.Emisor = ce
            comprobante.Receptor = cr

            Dim concepto As New ComprobanteConcepto
            Dim conceptosx As New List(Of ComprobanteConcepto)
            For i As Integer = 0 To conceptos.Count - 1
                Dim str As String = conceptos(i)
                Dim split = str.Split("|")
                Dim splitx = split(1).Split("-")
                concepto.Cantidad = split(0)
                concepto.ClaveProdServ = splitx(0).Trim
                concepto.ClaveUnidad = split(2)
                concepto.Descripcion = split(3)
                concepto.ValorUnitario = split(4)
                concepto.Importe = split(5)
                If split(6) <> "0" Then
                    concepto.Descuento = split(6)
                    concepto.DescuentoSpecified = True
                End If

                concepto.NoIdentificacion = split(7)
                Dim descuentoconcepto As String = split(6)

                Dim imp As New ComprobanteConceptoImpuestos


                Dim imptraslados As New ComprobanteConceptoImpuestosTraslado
                imptraslados.ImporteSpecified = True
                imptraslados.TasaOCuotaSpecified = True
                Dim listaimptraslado As New List(Of ComprobanteConceptoImpuestosTraslado)

                For x As Integer = 0 To traslado.Count - 1
                    Dim splittras = traslado(0).Split("|")
                    imptraslados.Base = split(5) - descuentoconcepto
                    imptraslados.Impuesto = splittras(0)
                    imptraslados.TipoFactor = splittras(2)
                    imptraslados.TasaOCuota = splittras(1)
                    imptraslados.Importe = Round((split(5) - descuentoconcepto) * splittras(1), 4)
                    Impuestotraslado.Add(split(5) - descuentoconcepto & "|" & splittras(0) & "|" & splittras(2) & "|" & splittras(1) & "|" & Round((split(5) - descuentoconcepto) * splittras(1), 4))
                    listaimptraslado.Add(imptraslados)
                    sumatoria += Round((split(5) - descuentoconcepto) * splittras(1), 4)
                Next
                imp.Traslados = listaimptraslado.ToArray
                If Not totalretenciones = Nothing Then
                    Dim impretencciones As New ComprobanteConceptoImpuestosRetencion
                    Dim listaretenciones As New List(Of ComprobanteConceptoImpuestosRetencion)
                    Dim Impuestoretencion As New List(Of String)
                    For y As Integer = 0 To retenciones.Count - 1
                        Dim splitrentenciones = retenciones(0).Split("|")
                        impretencciones.Base = split(5) - descuentoconcepto
                        impretencciones.Impuesto = splitrentenciones(0)
                        impretencciones.TipoFactor = splitrentenciones(2)
                        impretencciones.TasaOCuota = splitrentenciones(1)
                        impretencciones.Importe = (split(5) - descuentoconcepto) * splitrentenciones(1)
                        'Impuestoretencion.Add(split(5) - descuentoconcepto & "|" & splitrentenciones(0) splitrentenciones(2))

                        listaretenciones.Add(impretencciones)
                    Next
                    imp.Retenciones = listaretenciones.ToArray
                End If
                concepto.Impuestos = imp
                conceptosx.Add(concepto)
                concepto = New ComprobanteConcepto
                imp = New ComprobanteConceptoImpuestos
            Next

            comprobante.Conceptos = conceptosx.ToArray






            Dim cim As New ComprobanteImpuestos
            cim.TotalImpuestosTrasladados = Round(sumatoria, 2)
            cim.TotalImpuestosTrasladadosSpecified = True
            Dim cimt As New ComprobanteImpuestosTraslado
            Dim cimtl As New List(Of ComprobanteImpuestosTraslado)
            For x As Integer = 0 To traslado.Count - 1
                Dim splitt = traslado(0).Split("|")
                cimt.Impuesto = splitt(0)
                cimt.TipoFactor = splitt(2)
                cimt.TasaOCuota = splitt(1)
                cimt.Importe = Round(sumatoria, 4)
                cimtl.Add(cimt)
            Next
            cim.Traslados = cimtl.ToArray

            If Not totalretenciones = Nothing Then
                Dim cimr As New ComprobanteImpuestosRetencion
                Dim cimrl As New List(Of ComprobanteImpuestosRetencion)
                cim.TotalImpuestosRetenidos = totalretenciones
                cim.TotalImpuestosRetenidosSpecified = True
                For x As Integer = 0 To retenciones.Count - 1
                    Dim splitr = retenciones(0).Split("|")
                    cimr.Impuesto = splitr(0)
                    cimr.Importe = Round((cuerpo_factura("Subtotal") - descuentofactura) * splitr(1), 4)
                    cimrl.Add(cimr)
                Next
                cim.Retenciones = cimrl.ToArray
            End If

            comprobante.Impuestos = cim
            crearxml(comprobante, pathxml, False, pdf)
            Dim co = cadena_original(pathxml)
            Dim sellodig As New Sellodigital
            comprobante.Certificado = sellodig.Certificado(certificado)

            comprobante.Sello = sellodig.Sellar(co, llave, claveprivada)

            Dim repuesta_timbre = crearxml(comprobante, pathxml, True, pdf)
            Dim splitx_resp = repuesta_timbre.split("|")
            If splitx_resp(0) = "200" Then
                Dim BO As Boolean = True
                ACTUALIZAR_FOLIO(Application.Session("Cve_Cliente"))
                If Not Guardar_CFDI(splitx_resp(1), emisor, receptor, cuerpo_factura, fecha, comprobante.NoCertificado, co) = True Then
                    BO = False
                End If
                If Not guardar_conceptos(splitx_resp(1), conceptos, Impuestotraslado) = True Then
                    BO = False
                End If

                If Not GUARDAR_IMPUESTOS_CFDI(splitx_resp(1), traslado, totaliva, descuentofactura, cuerpo_factura("Subtotal")) = True Then
                    BO = False
                End If
                GUARDAR_UUID_MOVIMIENTO(splitx_resp(1), FOLIO_FACTURAS)



                'BO = False '---------------------- Quitar pq no esta el reporte, solo para probar que guarde
                If BO = True Then
                    Guardar_XLM(codeXml, splitx_resp(1))

                    'MessageBox.Show("Factura timbrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim GuardarTimbre As New WebService_Timbres.Timbres()
                    Dim sBody As String = String.Format("rfc={0}&movimiento={1}&valor={2}", split_e(0), "TIMBRADAS", 1)
                    Utilidades.EnviarSolicitudControlTimbre(split_e(0), "TIMBRADAS", 1)

                    Dim XTRAREPORT As New XtraReport


                    XTRAREPORT = New R_Representacion_Fisica_CFDi33
                    Using ms As New MemoryStream()
                        Dim opts As PdfExportOptions = XTRAREPORT.ExportOptions.Pdf
                        Dim path As String = pdf
                        opts.Compressed = True
                        opts.ImageQuality = DevExpress.XtraPrinting.PdfJpegImageQuality.High
                        opts.DocumentOptions.Author = "Saxsoft"
                        opts.DocumentOptions.Application = "application/pdf"
                        opts.DocumentOptions.Title = "R_Representacion_Fisica_CFDi33"
                        XTRAREPORT.CreateDocument()
                        XTRAREPORT.ExportToPdf(path, opts)
                    End Using
                    Dim sReportName = "R_Representacion_Fisica_CFDi33"
                    If Trim(sReportName <> Nothing) Then
                        Application.Session("ReportName") = sReportName
                        Application.Session("DocumentCached") = Nothing
                        Application.Session("Modulo") = "DocumentViewer.aspx"
                        Dim Asp As New Mostrar_Asp()
                        Asp.Actualizar()
                        Asp.Show()
                    End If
                    Return splitx_resp(1)

                Else

                    MessageBox.Show("Error En Guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return Nothing
                End If
            Else
                MessageBox.Show("Error En Generar Factura", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Function Factura_devolucion_html(emisor As String, receptor As String, cuerpo_factura As Dictionary(Of String, String), certificado As String, llave As String, claveprivada As String, conceptos As List(Of String),
                      traslado As List(Of String), totaliva As String, serieactiva As String, fechafactura As DateTime, UUID_RELACIONADO As String, Optional totalretenciones As String = Nothing, Optional retenciones As List(Of String) = Nothing)
        Try

            Dim sumatoria As Double

            Dim nombrefactura As String = cuerpo_factura("Serie") & "_" & cuerpo_factura("Folio")

            pathxml = Application.StartupPath & "\Resources\SAT\FACTURAS\PUE\factura_" & nombrefactura & ".xml"
            Dim pdf = Application.StartupPath & "\Resources\SAT\FACTURAS\PUE\factura_" & nombrefactura & ".pdf"
            Dim pdfx = "\Resources\SAT\FACTURAS\PUE\factura_" & nombrefactura & ".pdf"
            Dim htmlx = "\Resources\SAT\FACTURAS\PUE\factura_" & nombrefactura & ".xml"

            Dim numeroCertificado, aa, b, c As String
            Dim descuentofactura As String = 0
            Sellodigital.leerCER(certificado, aa, b, c, numeroCertificado)
            Dim Impuestotraslado As New List(Of String)
            Dim comprobante As New Comprobante
            comprobante.Version = "4.0"
            comprobante.Folio = cuerpo_factura("Folio")
            comprobante.Serie = cuerpo_factura("Serie")
            Dim fecha As String = fechafactura.ToString("yyyy-MM-ddTHH:mm:ss")

            comprobante.Fecha = fecha
            'comprobante.Sello = "faltante"
            'comprobante.Certificado = "faltante"
            comprobante.NoCertificado = numeroCertificado
            comprobante.FormaPago = cuerpo_factura("Foma_Pago")
            comprobante.FormaPagoSpecified = True
            comprobante.SubTotal = cuerpo_factura("Subtotal")
            comprobante.Moneda = cuerpo_factura("Moneda")
            comprobante.Total = cuerpo_factura("Total")
            comprobante.TipoDeComprobante = cuerpo_factura("Tipo_comprobante")
            comprobante.MetodoPago = cuerpo_factura("Metodo_pago")
            comprobante.LugarExpedicion = cuerpo_factura("Lugarexpedicion")
            comprobante.MetodoPagoSpecified = True
            comprobante.Exportacion = "01"
            Dim RELACION As New ComprobanteCfdiRelacionados
            Dim RELACIONLIS As New ComprobanteCfdiRelacionadosCfdiRelacionado
            Dim RELACIONLISx As New List(Of ComprobanteCfdiRelacionadosCfdiRelacionado)
            RELACIONLIS.UUID = cuerpo_factura("RelacionUIID")

            RELACIONLISx.Add(RELACIONLIS)
            RELACION.CfdiRelacionado = RELACIONLISx.ToArray
            RELACION.TipoRelacion = cuerpo_factura("TipoRelacion")

            comprobante.CfdiRelacionados = RELACION
            comprobante.CfdiRelacionados.TipoRelacion = cuerpo_factura("TipoRelacion")



            If cuerpo_factura("Descuento") <> 0 Then
                comprobante.Descuento = cuerpo_factura("Descuento")
                descuentofactura = cuerpo_factura("Descuento")
                comprobante.DescuentoSpecified = True
            End If


            If Not cuerpo_factura("Tipo_Cambio") = Nothing Then
                comprobante.TipoCambio = cuerpo_factura("Tipo_Cambio")
                comprobante.TipoCambioSpecified = True
            End If



            If Not cuerpo_factura("Condiciones_Pago") = Nothing Then
                comprobante.CondicionesDePago = cuerpo_factura("Condiciones_Pago")

            End If

            Dim ce As New ComprobanteEmisor
            Dim split_e = emisor.Split("|")
            ce.Rfc = split_e(0)
            ce.Nombre = split_e(1)
            ce.RegimenFiscal = split_e(2)

            Dim cr As New ComprobanteReceptor
            Dim split_r = receptor.Split("|")
            cr.Nombre = split_r(1)
            cr.Rfc = split_r(0)
            cr.UsoCFDI = split_r(2)
            cr.DomicilioFiscalReceptor = split_r(4)
            cr.RegimenFiscalReceptor = split_r(3)
            comprobante.Emisor = ce
            comprobante.Receptor = cr

            Dim concepto As New ComprobanteConcepto
            Dim conceptosx As New List(Of ComprobanteConcepto)
            For i As Integer = 0 To conceptos.Count - 1
                Dim str As String = conceptos(i)
                Dim split = str.Split("|")
                Dim splitx = split(1).Split("-")
                concepto.Cantidad = split(0)
                concepto.ClaveProdServ = splitx(0).Trim
                concepto.ClaveUnidad = split(2)
                concepto.Descripcion = split(3)
                concepto.ValorUnitario = split(4)
                concepto.Importe = split(5)
                concepto.ObjetoImp = "02"
                If split(6) <> "0" Then
                    concepto.Descuento = split(6)
                    concepto.DescuentoSpecified = True
                End If

                concepto.NoIdentificacion = split(7)
                Dim descuentoconcepto As String = split(6)

                Dim imp As New ComprobanteConceptoImpuestos


                Dim imptraslados As New ComprobanteConceptoImpuestosTraslado
                imptraslados.ImporteSpecified = True
                imptraslados.TasaOCuotaSpecified = True
                Dim listaimptraslado As New List(Of ComprobanteConceptoImpuestosTraslado)

                For x As Integer = 0 To traslado.Count - 1
                    Dim splittras = traslado(0).Split("|")
                    imptraslados.Base = split(5) - descuentoconcepto
                    ImporteTraslado = imptraslados.Base
                    imptraslados.Impuesto = splittras(0)
                    imptraslados.TipoFactor = splittras(2)
                    imptraslados.TasaOCuota = splittras(1)
                    imptraslados.Importe = Round((split(5) - descuentoconcepto) * splittras(1), 4)
                    Impuestotraslado.Add(split(5) - descuentoconcepto & "|" & splittras(0) & "|" & splittras(2) & "|" & splittras(1) & "|" & Round((split(5) - descuentoconcepto) * splittras(1), 4))
                    listaimptraslado.Add(imptraslados)
                    sumatoria += Round((split(5) - descuentoconcepto) * splittras(1), 4)
                Next
                imp.Traslados = listaimptraslado.ToArray
                If Not totalretenciones = Nothing Then
                    Dim impretencciones As New ComprobanteConceptoImpuestosRetencion
                    Dim listaretenciones As New List(Of ComprobanteConceptoImpuestosRetencion)
                    Dim Impuestoretencion As New List(Of String)
                    For y As Integer = 0 To retenciones.Count - 1
                        Dim splitrentenciones = retenciones(0).Split("|")
                        impretencciones.Base = split(5) - descuentoconcepto
                        impretencciones.Impuesto = splitrentenciones(0)
                        impretencciones.TipoFactor = splitrentenciones(2)
                        impretencciones.TasaOCuota = splitrentenciones(1)
                        impretencciones.Importe = (split(5) - descuentoconcepto) * splitrentenciones(1)
                        'Impuestoretencion.Add(split(5) - descuentoconcepto & "|" & splitrentenciones(0) splitrentenciones(2))

                        listaretenciones.Add(impretencciones)
                    Next
                    imp.Retenciones = listaretenciones.ToArray
                End If
                concepto.Impuestos = imp
                conceptosx.Add(concepto)
                concepto = New ComprobanteConcepto
                imp = New ComprobanteConceptoImpuestos
            Next

            comprobante.Conceptos = conceptosx.ToArray






            Dim cim As New ComprobanteImpuestos
            cim.TotalImpuestosTrasladados = Round(sumatoria, 2)
            cim.TotalImpuestosTrasladadosSpecified = True
            Dim cimt As New ComprobanteImpuestosTraslado
            Dim cimtl As New List(Of ComprobanteImpuestosTraslado)
            For x As Integer = 0 To traslado.Count - 1
                Dim splitt = traslado(0).Split("|")
                cimt.Impuesto = splitt(0)
                cimt.Base = ImporteTraslado
                cimt.TipoFactor = splitt(2)
                cimt.TasaOCuota = splitt(1)
                cimt.TasaOCuotaSpecified = True
                cimt.Importe = Round(sumatoria, 4)
                cimt.ImporteSpecified = True
                cimtl.Add(cimt)
            Next
            cim.Traslados = cimtl.ToArray

            If Not totalretenciones = Nothing Then
                Dim cimr As New ComprobanteImpuestosRetencion
                Dim cimrl As New List(Of ComprobanteImpuestosRetencion)
                cim.TotalImpuestosRetenidos = totalretenciones
                cim.TotalImpuestosRetenidosSpecified = True
                For x As Integer = 0 To retenciones.Count - 1
                    Dim splitr = retenciones(0).Split("|")
                    cimr.Impuesto = splitr(0)
                    cimr.Importe = Round((cuerpo_factura("Subtotal") - descuentofactura) * splitr(1), 4)
                    cimrl.Add(cimr)
                Next
                cim.Retenciones = cimrl.ToArray
            End If

            comprobante.Impuestos = cim
            crearxml(comprobante, pathxml, False, pdf)
            Dim co = cadena_original(pathxml)
            Dim sellodig As New Sellodigital
            comprobante.Certificado = sellodig.Certificado(certificado)

            comprobante.Sello = sellodig.Sellar(co, llave, claveprivada)

            Dim repuesta_timbre = crearxml(comprobante, pathxml, True, pdf)
            Dim splitx_resp = repuesta_timbre.split("|")
            If splitx_resp(0) = "200" Then
                Dim BO As Boolean = True
                ACTUALIZAR_FOLIO(Application.Session("Cve_Cliente"))
                If Not Guardar_CFDI(splitx_resp(1), emisor, receptor, cuerpo_factura, fecha, comprobante.NoCertificado, co) = True Then
                    BO = False
                End If
                If Not guardar_conceptos(splitx_resp(1), conceptos, Impuestotraslado) = True Then
                    BO = False
                End If

                If Not GUARDAR_IMPUESTOS_CFDI(splitx_resp(1), traslado, totaliva, descuentofactura, cuerpo_factura("Subtotal")) = True Then
                    BO = False
                End If
                GUARDAR_UUID_RELACIONADOS_DEVOLUCION(splitx_resp(1), UUID_RELACIONADO)



                'BO = False '---------------------- Quitar pq no esta el reporte, solo para probar que guarde
                If BO = True Then
                    Guardar_XLM(codeXml, splitx_resp(1))

                    'MessageBox.Show("Factura timbrada", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Dim GuardarTimbre As New WebService_Timbres.Timbres()
                    Dim sBody As String = String.Format("rfc={0}&movimiento={1}&valor={2}", split_e(0), "TIMBRADAS", 1)
                    Utilidades.EnviarSolicitudControlTimbre(split_e(0), "TIMBRADAS", 1)

                    Dim XTRAREPORT As New XtraReport


                    XTRAREPORT = New R_Representacion_Fisica_CFDi33
                    Using ms As New MemoryStream()
                        Dim opts As PdfExportOptions = XTRAREPORT.ExportOptions.Pdf
                        Dim path As String = pdf
                        opts.Compressed = True
                        opts.ImageQuality = DevExpress.XtraPrinting.PdfJpegImageQuality.High
                        opts.DocumentOptions.Author = "Saxsoft"
                        opts.DocumentOptions.Application = "application/pdf"
                        opts.DocumentOptions.Title = "R_Representacion_Fisica_CFDi33"
                        XTRAREPORT.CreateDocument()
                        XTRAREPORT.ExportToPdf(path, opts)
                    End Using
                    Dim sReportName = "R_Representacion_Fisica_CFDi33"
                    If Trim(sReportName <> Nothing) Then
                        Application.Session("ReportName") = sReportName
                        Application.Session("DocumentCached") = Nothing
                        Application.Session("Modulo") = "DocumentViewer.aspx"
                        Dim Asp As New Mostrar_Asp()
                        Asp.Actualizar()
                        Asp.Show()
                    End If
                    Return splitx_resp(1)

                Else

                    MessageBox.Show("Error En Guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Return Nothing
                End If
            Else
                MessageBox.Show("Error En Generar Factura", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Function

    Function GUARDAR_UUID_RELACIONADOS_DEVOLUCION(UUIDP As String, UUID_RELACIONADO As String)





        ReDim Utilidades.ParametersX_Global(6)
        Utilidades.ParametersX_Global(1) = New SqlClient.SqlParameter("@UUIDP", UUIDP)
        Utilidades.ParametersX_Global(2) = New SqlClient.SqlParameter("@UUID_CFDI", UUID_RELACIONADO)
        Dim sDevuelveId
        sDevuelveId = Utilidades.EjecutarProcedure_Id("[pFACTURACION_SAT_DEVOLUCION_UUID_RELACIONADOS_G]", "@Parametro", Utilidades.ParametersX_Global, , SqlDbType.VarChar, 50)

        If sDevuelveId = Nothing Then
            Return False
        End If


        Return True

    End Function

End Class
