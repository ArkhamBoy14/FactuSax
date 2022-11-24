Imports System
Imports Wisej.Web
Imports System.Data
Imports System.Data.SqlClient

Public Class Facturacion_Devolucion
    Dim Seria_activa As Integer
    Dim clave As String = Application.Session("Cve_Cliente")
    Dim SERIE As String
    Dim FOLIO As String
    Dim valor As String
    Dim contador As Integer
    Dim Alertas As New Notificaciones
    Dim ValorIVA, ValorISR, ValorIEPS As String
    Dim AplicaIVA, AplicaISR, AplicaIEPS As Boolean
    Dim TasaIVA, TasaISR, TasaIEPS As String


    Private Sub Combosax2_Load(sender As Object, e As EventArgs) Handles Me.Load
        'serieX()
        'TBMonto.Text = 0
        RBFecha.Checked = True
        Me.WindowState = FormWindowState.Maximized
        cFecha1.Value = Now
        cFecha2.Value = Now
        MTBHoraEmision.Text = Format(Now, "HH:mm")
        MTBHoraPago.Text = Format(Now, "HH:mm")

        'CBSIVA.LlenarListBox("pCAT_IMPUESTOS_SAT_FACTURACION_B", "c_Impuesto", "DescripcionX")
        'CBSRISR.LlenarListBox("pCAT_IMPUESTOS_SAT_FACTURACION_B", "c_Impuesto", "DescripcionX")
        'CBSRIVA.LlenarListBox("pCAT_IMPUESTOS_SAT_FACTURACION_B", "c_Impuesto", "DescripcionX")

        cFecha1.Value = Now
        cFecha2.Value = Now
        DTPFechaEmision.Value = Now
        DTPFechaPago.Value = Now


        ReDim Utilidades.ParametersX_Global(1)
        Utilidades.ParametersX_Global(0) = New SqlClient.SqlParameter("@Cve_Operador", Application.Session("Cve_Operador"))
        'Utilidades.LlenarListBox("pCAT_EMPRESAS_B", "Cve_Empresa", "Empresa2", cbbEmpresa)
        CBSTipoComprobante.LlenarListBox("pCAT_TIPOCOMPROBANTE_SAT_FACTURACION_B", "c_TipoDeComprobante", "DescripcionX")

        CbxClientes.LlenarListBox("pCAT_CLIENTES_B", "Cve_Cliente", "Nombre_Cliente", Utilidades.ParametersX_Global)
        CbxClientes.SelectedIndex = 0

        CBSFormaPago.LlenarListBox("pCAT_FORMAPAGO_SAT_FACTURACION_B", "c_Formapago", "DescripcionX")

        CBSMoneda.LlenarListBox("pCAT_MONEDA_SAT_FACTURACION_B", "c_Moneda", "DescripcionX")

        'Utilidades.LlenarListBox("pCAT_METODOPAGO_SAT_FACTURACION_B", "c_MetodoPago", "DescripcionX", CBSMetodoPago)
        CBS_TipoRelacion.LlenarListBox("[pCAT_TIPORELACION_SAT_FACTURACION_B]", "c_TipoRelacion", "descripcionx")
        CBS_TipoRelacion.SelectedValue = "03"
        CBSMoneda.SelectedValue = "MXN"
        CBSTipoComprobante.SelectedValue = "E"
        CBSFormaPago.SelectedValue = "01"

        'CBEmisor.LlenarListBox("pCAT_RFC_EMISOR_SAT_FACTURACION_B", "RFC", "RFCX")
        SplitContainer1.Panel1MinSize = 340

        'CBSReceptor.LlenarListBox("pCAT_RFC_RECEPTOR_SAT_FACTURACION_B", "RFC", "RFCX")
        'CBSReceptor.SelectedIndex = 0
        Dim TIPO_PERSONA As String = CBSReceptor.ObtenerDescripcion("Tipo_Persona")
        If TIPO_PERSONA = "FISICA" Then
            ReDim Utilidades.ParametersX_Global(0)
            Utilidades.ParametersX_Global(0) = New SqlClient.SqlParameter("@FISICA", "SI")
        Else
            ReDim Utilidades.ParametersX_Global(0)
            Utilidades.ParametersX_Global(0) = New SqlClient.SqlParameter("@MORAL", "SI")
        End If

        CBSUsoCFDI.LlenarListBox("pCAT_USOCFDI_SAT_FACTURACION_B", "c_UsoCFDI", "DescripcionX", Utilidades.ParametersX_Global)
        CBSUsoCFDI.SelectedValue = "G02"

        Dim dt_claveprocserv As New DataTable
        dt_claveprocserv = Utilidades.llenar_dt("pCAT_CLAVPRODSERV_SAT_FACTURACION")

        For i As Integer = 0 To dt_claveprocserv.Rows.Count - 1
            cbClaveProdServ.Items.Add(dt_claveprocserv.Rows(i).Item("DescripcionX"))
        Next
        Dim dt_unidad As New DataTable
        dt_unidad = Utilidades.llenar_dt("pCAT_CLAVEUNDAD_SAT_FACTURACION_B")
        For i As Integer = 0 To dt_unidad.Rows.Count - 1
            cbClaveUnidad.Items.Add(dt_unidad.Rows(i).Item("c_ClaveUnidad"))
        Next
        Dim dt_defecto = CBEmisor.dataTable()
        For i As Integer = 0 To dt_defecto.Rows.Count - 1
            If dt_defecto.Rows(i).Item("pordefecto") = True Then
                CBEmisor.SelectedValue = dt_defecto.Rows(i).Item("RFC")
            End If
        Next
        If CBEmisor.SelectedIndex <> -1 Then
            'Dim datasetx = CBEmisor.DataSource
            'Dim tabla_datos As DataTable = datasetx.Tables(0)
            MTBCP.Text = CBEmisor.ObtenerDescripcion("Codigo_Postal")
        End If
        serieX()
        PREDETERMINADOS()
    End Sub
    Sub CargarRetenciones()
        If CbxClientes.SelectedIndex = -1 Then Exit Sub
        Utilidades.Conectar()
        Dim DataReader As Data.SqlClient.SqlDataReader
        Dim Command As New SqlCommand

        Try
            Command = New SqlClient.SqlCommand("pCAT_RETENCIONES_B", Utilidades.cConnect)
            Command.CommandType = CommandType.StoredProcedure
            Command.Parameters.AddWithValue("@Cve_Cliente", CbxClientes.SelectedValue)
            DataReader = Command.ExecuteReader(CommandBehavior.CloseConnection)
            If DataReader.HasRows Then
                While (DataReader.Read)


                    TasaIVA = DataReader.Item("TasaCuotaIVA")
                    ValorIVA = DataReader.Item("ValorIVA")
                    AplicaIVA = DataReader.Item("AplicaIVA")
                    AplicaISR = DataReader.Item("AplicaISR")
                    TasaISR = DataReader.Item("TasaCuotaISR")
                    ValorISR = DataReader.Item("ValorISR")
                    AplicaIEPS = DataReader.Item("AplicaIEPS")
                    TasaIEPS = DataReader.Item("TasaCuotaIEPS")
                    ValorIEPS = DataReader.Item("ValorIEPS")


                End While
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Finally
            If IsNothing(DataReader) = False Then
                If DataReader.IsClosed = False Then DataReader.Close()
            End If
            Utilidades.Desconectar()
        End Try
    End Sub
    Sub PREDETERMINADOS()

        'If c = 1 Then
        '    CBSTipoComprobante.SelectedValue = "I"
        '    c = 0
        'End If


        'CBSMetodoPago.SelectedValue = "PUE"
        'CBSIVA.SelectedValue = "002"
        'MTBIVA.Text = "0.160000"
        'MTBRIVA.Text = "0.106666"
        'MTBRISR.Text = "0.100000"
        'CBSRIVA.SelectedValue = "002"
        'RDBSolicitrud.Checked = True
        'CBSRISR.SelectedValue = "001"
        Dim dt_defecto = CBEmisor.dataTable()
        For i As Integer = 0 To dt_defecto.Rows.Count - 1
            If dt_defecto.Rows(i).Item("pordefecto") = True Then
                CBEmisor.SelectedValue = dt_defecto.Rows(i).Item("RFC")
            End If
        Next
        If CBEmisor.SelectedIndex <> -1 Then
            MTBCP.Text = CBEmisor.ObtenerDescripcion("Codigo_Postal")
        End If

        'TBTipoCambio.Text = 1
        'TBTipoCambio.Enabled = True
        'RTBCondicionPago.Enabled = True
        'TasaoCuotaIVA.SelectedItem = "Tasa"
        'CBSMetodoPago.SelectedValue = "PUE"
        'CBSMetodoPago.Enabled = True
        'CBSFormaPago.Enabled = True

    End Sub
    Private Sub RibbonBar7_ButtonClick(sender As Object, e As Ext.RibbonBar.RibbonBarItemEventArgs) Handles RibbonBar7.ItemClick
        Select Case e.Item.Name
            Case RBBNuevo.Name
                limpiar()
                'limpiar(True)
                'CBSTipoComprobante.SelectedValue = "P"
            Case RBBConsultar.Name
                limpiar()
                valor = ""
                'If cbbEmpresa.SelectedIndex <> -1 Then
                '    ErrorProvider1.SetError(cbbEmpresa, "")

                CONSULTAR()

                serieX()
            'limpiar()
            'folios = ""

            Case RBBFactura.Name
                'Imprimir()

                'Exit Sub
                If verificar() = True Then
                    CREAR_XML()
                    serieX()
                    limpiar()
                Else

                End If
            Case RBBSalir.Name
                Me.Close()
        End Select
    End Sub






    Sub CONSULTAR(Optional Cve_Cliente As String = "-99")

        Me.DataSet_pFACTURA_SAT_CFDI_PAGOS_B.Clear()

        Dim myDA = New SqlClient.SqlDataAdapter("pFACTURA_SAT_CFDI_NOTA_CREDITO_B", Utilidades.sConexion)
        myDA.SelectCommand.CommandType = CommandType.StoredProcedure

        If RBFolio.Checked Then
            If InStr(TextBox1.Text, "-") Then
                myDA.SelectCommand.Parameters.AddWithValue("@Entre", 1)
                Dim split = TextBox1.Text.Split("-")
                myDA.SelectCommand.Parameters.AddWithValue("@Serei1", split(0))
                myDA.SelectCommand.Parameters.AddWithValue("@Serie2", split(1))
            ElseIf InStr(TextBox1.Text, ",") Then
                myDA.SelectCommand.Parameters.AddWithValue("@Series", TextBox1.Text)
            Else
                myDA.SelectCommand.Parameters.AddWithValue("@Serie", TextBox1.Text)
            End If
        End If
        myDA.SelectCommand.Parameters.AddWithValue("@Cve_Cliente", CbxClientes.SelectedValue)
        myDA.SelectCommand.Parameters.AddWithValue("@Fecha1", Format(Me.cFecha1.Value, "yyyyMMdd"))
        myDA.SelectCommand.Parameters.AddWithValue("@Fecha2", Format(Me.cFecha2.Value, "yyyyMMdd"))
        myDA.Fill(Me.DataSet_pFACTURA_SAT_CFDI_PAGOS_B.pFACTURA_SAT_CFDI_PAGOS_B)
        myDA.Dispose()

        CBS_TipoRelacion.SelectedValue = "03"

    End Sub



    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RBFecha.CheckedChanged, RBFolio.CheckedChanged

        pserie.Visible = RBFolio.Checked
        pfECHA.Visible = RBFecha.Checked
        TextBox1.Text = Nothing

    End Sub



    Private Sub DGVUUID_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVUUID.CellClick
        Dim FOLIOS As String = ""
        If e.ColumnIndex = 0 Then
            If RB_Completa.Checked = True Then
                conceptos_completos(DGVUUID.Rows(e.RowIndex).Cells(2).Value, DGVUUID.Rows(e.RowIndex).Cells(1).Value, DGVUUID.Rows(e.RowIndex).Cells(5).Value)
                TBMonto.Enabled = False
                BtnAnexarPago.Enabled = False
            Else
                conceptos(DGVUUID.Rows(e.RowIndex).Cells(2).Value, DGVUUID.Rows(e.RowIndex).Cells(1).Value)
                TBMonto.Enabled = True
                BtnAnexarPago.Enabled = True
            End If
            CBSReceptor.SelectedValue = DGVUUID.Rows(e.RowIndex).Cells(6).Value
        End If



    End Sub


    Sub conceptos(folios As String, ID As String, Optional saldo As Double = 0)


        Dim SUBTOTAL As Double
        RTBObservaciones.Text = CBS_TipoRelacion.SelectedItem & " Del UUID = " & folios
        Application.Session("folios_factura") = folios
        Dim dt As New DataTable
        For x As Integer = 0 To DGVConceptos.Columns.Count - 1
            dt.Columns.Add(DGVConceptos.Columns(x).HeaderText)
        Next
        DGVConceptos.Rows.Clear()
        Dim parametros As String()
        ReDim parametros(7)
        parametros(0) = "1" : parametros(1) = "84111506 - Servicio de Facturacion" : parametros(2) = "ACT" : parametros(3) = "Devolución" : parametros(4) = saldo : parametros(5) = saldo : parametros(6) = 0 : parametros(7) = ID
        DGVConceptos.Rows.Add(parametros)
    End Sub

    Sub conceptos_completos(folios As String, ID As String, Optional saldo As Double = 0)

        Dim SUBTOTAL As Double
        RTBObservaciones.Text = CBS_TipoRelacion.SelectedItem & " Del UUID = " & folios
        Application.Session("folios_factura") = folios
        Dim dt As New DataTable
        For x As Integer = 0 To DGVConceptos.Columns.Count - 1
            dt.Columns.Add(DGVConceptos.Columns(x).HeaderText)
        Next
        DGVConceptos.Rows.Clear()
        Dim parametros As String()
        ReDim parametros(7)
        parametros(0) = "1" : parametros(1) = "84111506 - Servicio de Facturacion" : parametros(2) = "ACT" : parametros(3) = "Devolución" : parametros(4) = saldo : parametros(5) = saldo : parametros(6) = 0 : parametros(7) = ID
        DGVConceptos.Rows.Add(parametros)
        Try
            Dim valor_clave = cbClaveProdServ.Items.Count - 1
            For e As Integer = 0 To DGVConceptos.Rows.Count - 1
                DGVConceptos(1, e).Value = "84111506 - Servicio de Facturacion"
                DGVConceptos(2, e).Value = "ACT"
                Dim total, iva, riva, risr, totaldesc, preciosiniva, calculoimporte As Double
                Dim Unidad = DGVConceptos.Rows(e).Cells(4).Value
                'Dim DescuentoUnidad = Unidad * Double.Parse(0.16)
                Dim DescuentoUnidad = Unidad
                'Dim ImporteDescuento = Unidad - DescuentoUnidad
                Dim ImporteDescuento = Unidad

                calculoimporte = CDbl(DGVConceptos.Rows(e).Cells(0).Value) * CDbl(DGVConceptos.Rows(e).Cells(4).Value)

                DGVConceptos(5, e).Value = ImporteDescuento
                For i As Integer = 0 To DGVConceptos.Rows.Count - 1
                    total += DGVConceptos.Rows(i).Cells(4).Value
                Next
                'Dim DESCUENTOX As Double
                'DESCUENTOX = (descuento * 100 / total) / 100
                'For I As Integer = 0 To DGVConceptos.Rows.Count - 1
                '    DGVConceptos.Rows(I).Cells("cDescuento").Value = Round((DGVConceptos.Rows(I).Cells("cImporte").Value * DESCUENTOX), 2)
                'Next

                ''If CBTraslado.Checked Then
                iva = 0
                SUBTOTAL = total
                ''End If
                'If CBRetencion.Checked Then
                '    risr = SUBTOTAL * (MTBRISR.Text)
                '    riva = SUBTOTAL * (MTBRIVA.Text)
                'End If

                TBSubTotal.Text = FormatCurrency(SUBTOTAL)
                'TBDescuento.Text = FormatCurrency(descuento)
                TBIva.Text = FormatCurrency(iva)
                'TBRISR.Text = FormatCurrency(risr + 0)
                'TBRIVA.Text = FormatCurrency(riva + 0)
                total = SUBTOTAL + iva
                TBTotal.Text = FormatCurrency(total)
            Next

        Catch ex As Exception

        End Try

    End Sub



    Sub CREAR_XML()
        Dim splithora As String() = MTBHoraEmision.Text.Split(":")
        Dim fecha_factura As DateTime = New DateTime(DTPFechaEmision.Value.Year, DTPFechaEmision.Value.Month, DTPFechaEmision.Value.Day, splithora(0), splithora(1), "00")
        Dim splithorap As String() = MTBHoraPago.Text.Split(":")
        Dim FechaPago As DateTime = New DateTime(DTPFechaPago.Value.Year, DTPFechaPago.Value.Month, DTPFechaPago.Value.Day, splithorap(0), splithorap(1), "00")

        Dim cuerpo As New Dictionary(Of String, String)
        Dim pagos_fac As New Dictionary(Of String, String)
        Dim conceptos As New List(Of String)
        Dim imptraslado As New List(Of String)
        Dim impretencciones As New List(Of String)
        Dim FACTURA As New Factura
        Dim uso_cfdi As String = CBSUsoCFDI.SelectedValue
        Dim RFC_EMISOR As String = CBEmisor.SelectedValue
        Dim NOMBRE_EMISOR As String = CBEmisor.ObtenerDescripcion("Razon_Social")
        Dim EMISOR_REGIMENFISCAL As String = CBEmisor.ObtenerDescripcion("regimen")
        Dim emisor = RFC_EMISOR & "|" & NOMBRE_EMISOR & "|" & EMISOR_REGIMENFISCAL
        Dim rfc_receptor As String = CBSReceptor.SelectedValue
        Dim nombre_receptor As String = CBSReceptor.ObtenerDescripcion("Razon_Social")
        Dim llave = Application.StartupPath & "\Resources\SAT\" & RFC_EMISOR & "\" & CBEmisor.ObtenerDescripcion("llave")
        Dim cer = Application.StartupPath & "\Resources\SAT\" & RFC_EMISOR & "\" & CBEmisor.ObtenerDescripcion("cer")
        Dim claveprivada = CBEmisor.ObtenerDescripcion("claveprivada")
        Dim RegimenReceptor As String = CBSReceptor.ObtenerDescripcion("regimen")
        Dim DomicilioReceptor As String = CBSReceptor.ObtenerDescripcion("Codigo_Postal")
        Dim receptor = rfc_receptor & "|" & nombre_receptor & "|" & uso_cfdi & "|" & RegimenReceptor & "|" & DomicilioReceptor
        cuerpo.Add("Folio", FOLIO)
        cuerpo.Add("Serie", SERIE)
        'cuerpo.Add("Tipo_comprobante", CBSTipoComprobante.SelectedValue)
        cuerpo.Add("Lugarexpedicion", MTBCP.Text)



        cuerpo.Add("Foma_Pago", CBSFormaPago.SelectedValue)
        cuerpo.Add("Subtotal", TBSubTotal.Text.Replace("$", ""))
        cuerpo.Add("Moneda", CBSMoneda.SelectedValue)

        cuerpo.Add("Total", TBTotal.Text.Replace("$", ""))
        cuerpo.Add("Tipo_comprobante", CBSTipoComprobante.SelectedValue)
        cuerpo.Add("Metodo_pago", "PUE")
        'cuerpo.Add("Lugarexpedicion", MTBCP.Text)
        'cuerpo.Add("Descuento", IIf(TBDescuento.Text.Replace("$", "") = "0", 0, TBDescuento.Text.Replace("$", "")))
        cuerpo.Add("Tipo_Cambio", Nothing)
        cuerpo.Add("Condiciones_Pago", IIf(RTBObservaciones.Text = "", Nothing, RTBObservaciones.Text))

        ''faltantes ------------------------------------
        cuerpo.Add("RelacionUIID", Application.Session("folios_factura"))
        cuerpo.Add("TipoRelacion", CBS_TipoRelacion.SelectedValue)

        'cuerpo.Add("Foma_Pago", "NA")


        'cuerpo.Add("Metodo_pago", "PUE")
        'cuerpo.Add("Total", "0")
        'cuerpo.Add("Tipo_comprobante", "P")
        cuerpo.Add("Descuento", "0")
        'cuerpo.Add("Condiciones_Pago", RTBObservaciones.Text)
        'cuerpo.Add("Tipo_Cambio", "NA")

        If DGVConceptos.Rows.Count <> 0 Then
            For i As Integer = 0 To DGVConceptos.Rows.Count - 1
                If DGVConceptos.Rows(i).Cells(0).Value = "" Then Exit For
                conceptos.Add(DGVConceptos.Rows(i).Cells(0).Value & "|" & DGVConceptos.Rows(i).Cells(1).Value & "|" & DGVConceptos.Rows(i).Cells(2).Value & "|" & DGVConceptos.Rows(i).Cells(3).Value & "|" & DGVConceptos.Rows(i).Cells(4).Value & "|" & DGVConceptos.Rows(i).Cells(5).Value & "|" & DGVConceptos.Rows(i).Cells(6).Value & "|" & DGVConceptos.Rows(i).Cells(7).Value)
            Next
        End If

        ''If CBTraslado.Checked = True Then
        imptraslado.Add("002" & "|" & "Tasa" & "|" & "0.000000" & "|" & 0)
        ''End If

        'impretencciones.Add(CBSRISR.SelectedValue & "|" & MTBRISR.Text & "|" & TasaoCuotaISR.Text)
        'impretencciones.Add(CBSRIVA.SelectedValue & "|" & MTBRIVA.Text & "|" & TasaoCuotaRIVA.Text)
        Dim totalretenciones = TBRISR.Text + TBRIVA.Text
        'FACTURA.factura_html(emisor, receptor, cuerpo, cer, llave, claveprivada, conceptos, imptraslado, TBIva.Text, clave, fecha_factura, totalretenciones, impretencciones)
        Dim FACTURAX As New Factura

        Dim respuesta As String = FACTURA.Factura_devolucion_html(emisor, receptor, cuerpo, cer, llave, claveprivada, conceptos, imptraslado, TBIva.Text, clave, fecha_factura, Application.Session("folios_factura"))
        If respuesta <> Nothing Then
            Dim split As String() = respuesta.Split("-")
            Dim asp As New Mostrar_Asp
            Application.Session("DocumentCached") = Nothing
            Application.Session("ReportName") = "R_Representacion_Fisica_CFDi33_Egreso"
            Application.Session("Modulo") = "DocumentViewer.aspx"
            asp.Actualizar()
            asp.Show()
        End If


        'If respuesta <> Nothing Then
        '    Dim split As String() = respuesta.Split("-")
        '    Application.Session("DocumentCached") = Nothing
        '    Application.Session("ReportName") = "R_Representacion_Fisica_CFDi33_Pagos"
        '    AspPageBox1.Path = "ReportView.aspx"
        '    AspPageBox1.Update()
        'End If




    End Sub


    'Sub Imprimir()
    '    'Dim AspPageBox1 As New AspPageBox
    '    '     Dim split As String() = respuesta.Split("-")
    '    'Variable para refresar. 
    '    Application.Session("DocumentCached") = Nothing
    '    'Para identificar el reporte
    '    Application.Session("ReportName") = "R_Representacion_Fisica_CFDi33_Pagos"
    '    '
    '= "ce139281-311d-4d86-aeb4-eef5758d6b33"
    '    '
    '    AspPageBox1.Path = "ReportView.aspx"
    '    AspPageBox1.Update()
    'End Sub


    Sub serieX()
        ReDim Utilidades.ParametersX_Global(0)
        Utilidades.ParametersX_Global(0) = New SqlClient.SqlParameter("@Cve_Cliente", clave)
        Dim dt_serie = Utilidades.llenar_dt("pCAT_SERIE_FOLIO_SAT_FACTURACION_B", Utilidades.ParametersX_Global)
        For i As Integer = 0 To dt_serie.Rows.Count - 1
            If dt_serie.Rows(i).Item(4) <> Nothing Then
                SERIE = dt_serie.Rows(i).Item(1)
                FOLIO = dt_serie.Rows(i).Item(2)

                Exit For
            End If
        Next
    End Sub





    Function verificar()
        Dim total As String

        If CBS_TipoRelacion.SelectedIndex = -1 Then
            Alertas.NotificacionAdvertencia("Selecccion un tipo de relacion")
            Return False
        End If

        If CBSReceptor.SelectedIndex = -1 Then
            Alertas.NotificacionAdvertencia("Seleccione un receptor")
            Return False
        End If

        Return True
    End Function

    Sub limpiar()
        DGVConceptos.DataSource = Nothing
        Me.DataSet_pFACTURA_SAT_CFDI_PAGOS_B.Clear()
        'TBMonto.Text = 0
        CBS_TipoRelacion.SelectedIndex = -1
        RTBObservaciones.Text = Nothing
    End Sub

    Private Sub CBSReceptor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBSReceptor.SelectedIndexChanged
        If CBSReceptor.SelectedIndex <> -1 Then

            Dim TIPO_PERSONA As String = CBSReceptor.ObtenerDescripcion("Tipo_Persona")
            If TIPO_PERSONA = "FISICA" Then
                ReDim Utilidades.ParametersX_Global(0)
                Utilidades.ParametersX_Global(0) = New SqlClient.SqlParameter("@FISICA", "SI")
            Else
                ReDim Utilidades.ParametersX_Global(0)
                Utilidades.ParametersX_Global(0) = New SqlClient.SqlParameter("@MORAL", "SI")
            End If

            'CBSUsoCFDI.LlenarListBox("pCAT_USOCFDI_SAT_FACTURACION_B", "c_UsoCFDI", "DescripcionX", Utilidades.ParametersX_Global)
        End If
    End Sub

    Private Sub CBS_TipoRelacion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBS_TipoRelacion.SelectedIndexChanged
        If CBS_TipoRelacion.SelectedIndex <> -1 Then
            RTBObservaciones.Text = CBS_TipoRelacion.SelectedItem & " Del UUID = " & Application.Session("folios_factura")
        End If
    End Sub

    Private Sub DGVConceptos_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DGVConceptos.CellEndEdit
        Try
            Dim valor_clave = cbClaveProdServ.Items.Count - 1
            DGVConceptos(1, e.RowIndex).Value = "84111506 - Servicio de Facturacion"
            DGVConceptos(2, e.RowIndex).Value = "ACT"
            Dim total, iva, riva, risr, totaldesc, preciosiniva, subtotal, calculoimporte As Double
            Dim Unidad = DGVConceptos.Rows(e.RowIndex).Cells(4).Value
            'Dim DescuentoUnidad = Unidad * Double.Parse(0.16)
            Dim DescuentoUnidad = Unidad
            'Dim ImporteDescuento = Unidad - DescuentoUnidad
            Dim ImporteDescuento = Unidad

            calculoimporte = CDbl(DGVConceptos.Rows(e.RowIndex).Cells(0).Value) * CDbl(DGVConceptos.Rows(e.RowIndex).Cells(4).Value)

            DGVConceptos(5, e.RowIndex).Value = ImporteDescuento
            For i As Integer = 0 To DGVConceptos.Rows.Count - 1
                total += DGVConceptos.Rows(i).Cells(4).Value
            Next
            'Dim DESCUENTOX As Double
            'DESCUENTOX = (descuento * 100 / total) / 100
            'For I As Integer = 0 To DGVConceptos.Rows.Count - 1
            '    DGVConceptos.Rows(I).Cells("cDescuento").Value = Round((DGVConceptos.Rows(I).Cells("cImporte").Value * DESCUENTOX), 2)
            'Next

            ''If CBTraslado.Checked Then
            iva = total * Double.Parse(ValorIVA)
            subtotal = total
            ''End If
            'If CBRetencion.Checked Then
            '    risr = SUBTOTAL * (MTBRISR.Text)
            '    riva = SUBTOTAL * (MTBRIVA.Text)
            'End If

            TBSubTotal.Text = FormatCurrency(subtotal)
            'TBDescuento.Text = FormatCurrency(descuento)
            TBIva.Text = FormatCurrency(iva)
            'TBRISR.Text = FormatCurrency(risr + 0)
            'TBRIVA.Text = FormatCurrency(riva + 0)
            total = subtotal + iva
            TBTotal.Text = FormatCurrency(total)
        Catch ex As Exception

        End Try
    End Sub


    Private Sub CbxClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxClientes.SelectedIndexChanged
        Application.Session("Facturauser") = CbxClientes.ObtenerDescripcion("FACTORUM_USER")
        Application.Session("FacturaContrasena") = CbxClientes.ObtenerDescripcion("ContrasenaFact")
        Application.Session("Cve_Cliente") = CbxClientes.ObtenerDescripcion("Cve_Cliente")
        'CargarRetenciones()
        'CbxReceptor.SelectedIndex = -1
        ReDim Utilidades.ParametersX_Global(0)
        Utilidades.ParametersX_Global(0) = New SqlClient.SqlParameter("@Cve_Cliente", CbxClientes.ObtenerDescripcion("Cve_Cliente"))
        'CbxReceptor.LlenarListBox("pFACTURACION_RECEPTOR", "Cve_Receptor", "ReceptorX", Utilidades.ParametersX_Global)
        CONSULTAR(CbxClientes.SelectedValue)
        CargarRFC()
        limpiar()
        'SERIE()
        CargarRetenciones()

        PREDETERMINADOS()
    End Sub

    'Private Sub DGVConceptosUUID_Cellleave(sender As Object, e As DataGridViewCellEventArgs)
    '    If DGVConceptosUUID.Rows.Count <> 0 Then

    '        For i As Integer = 0 To DGVConceptosUUID.Rows.Count - 1
    '            If DGVConceptosUUID.Rows(i).Cells("IMPORTE_PAGADO").Value = "0" Then Exit For
    '            If DGVConceptosUUID.Rows(i).Cells("SALDO_ANTERIOR").Value - DGVConceptosUUID.Rows(i).Cells("IMPORTE_PAGADO").Value < 0 Then
    '                MessageBox.Show("El Saldo anterior no puede ser menor que el importe pagado")
    '            Else

    '                DGVConceptosUUID.Rows(i).Cells("SALDO_INSOLUTO").Value = DGVConceptosUUID.Rows(i).Cells("SALDO_ANTERIOR").Value - DGVConceptosUUID.Rows(i).Cells("IMPORTE_PAGADO").Value
    '            End If

    '        Next

    '    End If



    'End Sub
    Sub CargarRFC()
        ReDim Utilidades.ParametersX_Global(2)
        Utilidades.ParametersX_Global(0) = New SqlParameter("@Cve_Cliente", CbxClientes.SelectedValue)
        Utilidades.ParametersX_Global(1) = New SqlParameter("@Estatus", 1)
        CBSReceptor.Clear()
        CBEmisor.Clear()
        CBSReceptor.LlenarListBox("pCAT_RFC_RECEPTOR_SAT_FACTURACION_B", "RFC", "RFCX", Utilidades.ParametersX_Global)
        CBEmisor.LlenarListBox("pCAT_RFC_EMISOR_SAT_FACTURACION_B", "RFC", "RFCX", Utilidades.ParametersX_Global)

        If CBEmisor.Items.Count > 0 Then
            CBEmisor.SelectedIndex = 0
        Else
            CBEmisor.SelectedIndex = -1
        End If

        If CBSReceptor.Items.Count > 0 Then
            CBSReceptor.SelectedIndex = 0
        Else
            CBSReceptor.SelectedIndex = -1
        End If


    End Sub

End Class
