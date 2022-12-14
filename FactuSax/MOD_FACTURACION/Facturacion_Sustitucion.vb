Imports System.Data
Imports System.Data.SqlClient
Imports System.Math


Public Class Facturacion_Sustitucion
    Dim Seria_activa As Integer
    Dim clave As String = Application.Session("Cve_Cliente")
    Dim SERIE As String
    Dim FOLIO As String
    Dim valor As String
    Dim contador As Integer
    Dim Alertas As New Notificaciones
    Dim AplicaIVA, AplicaISR, AplicaIEPS As Boolean
    Dim ValorIVA, ValorISR, ValorIEPS As String
    Dim TasaIVA, TasaISR, TasaIEPS As String
    Private Sub Combosax2_Load(sender As Object, e As EventArgs) Handles Me.Load
        'serieX()
        'TBMonto.Text = 0
        RBFecha.Checked = True
        Me.WindowState = FormWindowState.Maximized
        cFecha1.Value = Now
        cFecha2.Value = Now
        MTBHoraEmision.Text = Now.Hour & ":" & Now.Minute
        MTBHoraPago.Text = Now.Hour & ":" & Now.Minute

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
        CBSMetodoPago.LlenarListBox("pCAT_METODOPAGO_SAT_FACTURACION_B", "c_MetodoPago", "DescripcionX")

        CBSMoneda.LlenarListBox("pCAT_MONEDA_SAT_FACTURACION_B", "c_Moneda", "DescripcionX")

        'Utilidades.LlenarListBox("pCAT_METODOPAGO_SAT_FACTURACION_B", "c_MetodoPago", "DescripcionX", CBSMetodoPago)
        CBS_TipoRelacion.LlenarListBox("[pCAT_TIPORELACION_SAT_FACTURACION_B]", "c_TipoRelacion", "descripcionx")

        CBSMoneda.SelectedValue = "MXN"
        CBSTipoComprobante.SelectedValue = "I"
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
        'CBSUsoCFDI.SelectedValue = "G02"

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


        Dim dt_defecto = CBEmisor.dataTable()
        For i As Integer = 0 To dt_defecto.Rows.Count - 1
            If dt_defecto.Rows(i).Item("pordefecto") = True Then
                CBEmisor.SelectedValue = dt_defecto.Rows(i).Item("RFC")
            End If
        Next
        If CBEmisor.SelectedIndex <> -1 Then
            MTBCP.Text = CBEmisor.ObtenerDescripcion("Codigo_Postal")
        End If
        CBS_TipoRelacion.SelectedValue = 4

        TBTipoCambio.Text = 1
        TBTipoCambio.Enabled = True
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

        Me.Dataset_pFACTURA_SAT_CFDI_SUSTITUCION_B.Clear()

        Dim myDA = New SqlClient.SqlDataAdapter("pFACTURA_SAT_CFDI_SUSTITUCION_B", Utilidades.sConexion)
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
        myDA.Fill(Me.Dataset_pFACTURA_SAT_CFDI_SUSTITUCION_B.pFACTURA_SAT_CFDI_SUSTITUCION_B)
        myDA.Dispose()

    End Sub



    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RBFecha.CheckedChanged, RBFolio.CheckedChanged

        pserie.Visible = RBFolio.Checked
        pfECHA.Visible = RBFecha.Checked
        TextBox1.Text = Nothing

    End Sub



    Private Sub DGVUUID_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVUUID.CellClick
        Dim FOLIOS As String = ""
        If RB_Sencilla.Checked = True Then
            Sencilla(DGVUUID.Rows(e.RowIndex).Cells(2).Value, DGVUUID.Rows(e.RowIndex).Cells(1).Value)
        Else
            conceptos(DGVUUID.Rows(e.RowIndex).Cells(2).Value, DGVUUID.Rows(e.RowIndex).Cells(1).Value)
        End If
        CBSReceptor.SelectedValue = DGVUUID.Rows(e.RowIndex).Cells(5).Value

        CBSMetodoPago.SelectedValue = DGVUUID.Rows(e.RowIndex).Cells(7).Value

    End Sub

    Sub conceptos(folios As String, ID As String)
        Application.Session("UUID_PADRE") = folios
        Dim total, iva, riva, risr, totaldesc, preciosiniva As Double
        Dim SUBTOTAL As Double
        CBS_TipoRelacion.SelectedValue = 4
        RTBObservaciones.Text = CBS_TipoRelacion.SelectedItem & " Del UUID = " & folios
        Application.Session("folios_factura") = folios

        Dim dt_conceptos As New DataTable
        ReDim Utilidades.ParametersX_Global(1)
        Utilidades.ParametersX_Global(0) = New SqlClient.SqlParameter("@UUID", folios)

        dt_conceptos = Utilidades.llenar_dt("pFACTURA_SAT_EGRESOS_CONCEPTOS", Utilidades.ParametersX_Global)
        DGVConceptos.Rows.Clear()
        For i As Integer = 0 To dt_conceptos.Rows.Count - 1
            DGVConceptos.Rows.Insert(DGVConceptos.Rows.Count)
            Dim filaNueva = DGVConceptos.Rows(DGVConceptos.Rows.Count - 1)
            Dim split As String() = dt_conceptos.Rows(i).Item("Producto").split("-")
            filaNueva(cCantidad.Name).Value = dt_conceptos.Rows(i).Item("Cantidad")

            If CbxClientes.ObtenerDescripcion("Sistema") = "iSISLAB" Then
                filaNueva(cbClaveProdServ.Name).Value = "85121800 - Laboratorios médicos"

            Else
                filaNueva(cbClaveProdServ.Name).Value = "84111506 - Servicios de facturación"

            End If
            filaNueva(cbClaveUnidad.Name).Value = "E48"
            filaNueva(cDescripcion.Name).Value = split(1).Trim
            filaNueva(cValorUnitario.Name).Value = Round(dt_conceptos.Rows(i).Item("Unitario"), 4)
            filaNueva(cImporte.Name).Value = Round(dt_conceptos.Rows(i).Item("IMPORTE"), 4)
            filaNueva(cDescuento.Name).Value = Round(dt_conceptos.Rows(i).Item("Descuento_Total"), 0)
            filaNueva(cNoIdentificacion.Name).Value = split(0).Trim
        Next
        For i As Integer = 0 To DGVConceptos.Rows.Count - 1
            total += DGVConceptos.Rows(i).Item(cValorUnitario.Name).Value
        Next
        Dim DESCUENTOX As Double
        For I As Integer = 0 To DGVConceptos.Rows.Count - 1
            DESCUENTOX += DGVConceptos.Rows(I).Cells("cDescuento").Value
        Next
        totaldesc = total - DESCUENTOX
        iva = total * Double.Parse(ValorIVA)
        SUBTOTAL = totaldesc
        If AplicaISR = True Then
            risr = SUBTOTAL * (ValorISR)
        End If
        If AplicaIEPS = True Then
            riva = SUBTOTAL * (ValorIEPS)

        End If
        TBSubTotal.Text = FormatCurrency(total)
        TBDescuento.Text = FormatCurrency(DESCUENTOX)
        TBIva.Text = FormatCurrency(iva)
        TBRISR.Text = FormatCurrency(risr + 0)
        TBRIVA.Text = FormatCurrency(riva + 0)
        total = SUBTOTAL + iva - risr - riva
        TBTotal.Text = FormatCurrency(total)
    End Sub

    Sub Sencilla(folios As String, ID As String)
        Application.Session("UUID_PADRE") = folios

        Dim total, iva, riva, risr, totaldesc, preciosiniva As Double
        Dim Descuento As Double
        Dim SUBTOTAL As Double
        CBS_TipoRelacion.SelectedValue = "04"
        RTBObservaciones.Text = CBS_TipoRelacion.SelectedItem & " Del UUID = " & folios
        Application.Session("folios_factura") = folios

        Dim dt_conceptos As New DataTable
        ReDim Utilidades.ParametersX_Global(1)
        Utilidades.ParametersX_Global(0) = New SqlClient.SqlParameter("@UUID", folios)

        dt_conceptos = Utilidades.llenar_dt("pFACTURA_SAT_CFDI_CONCEPTOS", Utilidades.ParametersX_Global)
        DGVConceptos.Rows.Clear()
        For i As Integer = 0 To dt_conceptos.Rows.Count - 1
            DGVConceptos.Rows.Insert(DGVConceptos.Rows.Count)
            Dim filaNueva = DGVConceptos.Rows(DGVConceptos.Rows.Count - 1)
            'Dim parametros As String()
            'ReDim parametros(7)
            Dim split As String() = dt_conceptos.Rows(i).Item("Descripcion").split("-")
            filaNueva(cCantidad.Name).Value = dt_conceptos.Rows(i).Item("Cantidad")
            If CbxClientes.ObtenerDescripcion("Sistema") = "iSISLAB" Then
                filaNueva(cbClaveProdServ.Name).Value = "85121800 - Laboratorios médicos"

            Else
                filaNueva(cbClaveProdServ.Name).Value = "84111506 - Servicios de facturación"

            End If
            'filaNueva(cbClaveProdServ.Name).Value = "84111506 - Servicios de facturación"
            filaNueva(cbClaveUnidad.Name).Value = "E48"
            filaNueva(cDescripcion.Name).Value = split(1).Trim
            filaNueva(cValorUnitario.Name).Value = dt_conceptos.Rows(i).Item("Valorunitario")
            filaNueva(cImporte.Name).Value = dt_conceptos.Rows(i).Item("Importe")
            filaNueva(cDescuento.Name).Value = dt_conceptos.Rows(i).Item("Descuento")
            filaNueva(cNoIdentificacion.Name).Value = dt_conceptos.Rows(i).Item("NoIdentificacion")
        Next
        For i As Integer = 0 To DGVConceptos.Rows.Count - 1
            total += DGVConceptos.Rows(i).Item(cValorUnitario.Name).Value
            Descuento = DGVConceptos.Rows(i).Item(cDescuento.Name).Value
        Next

        totaldesc = total - Descuento
        iva = total * Double.Parse(ValorIVA)
        SUBTOTAL = totaldesc
        If AplicaISR = True Then
            risr = SUBTOTAL * (ValorISR)
        End If
        If AplicaIEPS = True Then
            riva = SUBTOTAL * (ValorIEPS)

        End If
        TBSubTotal.Text = FormatCurrency(total)
        TBDescuento.Text = FormatCurrency(Descuento)
        TBIva.Text = FormatCurrency(iva)
        TBRISR.Text = FormatCurrency(risr + 0)
        TBRIVA.Text = FormatCurrency(riva + 0)
        total = SUBTOTAL + iva - risr - riva
        TBTotal.Text = FormatCurrency(total)
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
        Dim receptor = rfc_receptor & "|" & nombre_receptor & "|" & uso_cfdi
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
        cuerpo.Add("Tipo_Cambio", TBTipoCambio.Text)
        cuerpo.Add("Condiciones_Pago", IIf(RTBObservaciones.Text = "", Nothing, RTBObservaciones.Text))

        ''faltantes ------------------------------------
        cuerpo.Add("RelacionUIID", Application.Session("folios_factura"))
        cuerpo.Add("TipoRelacion", CBS_TipoRelacion.SelectedValue)
        cuerpo.Add("Descuento", "0")

        If DGVConceptos.Rows.Count <> 0 Then
            For i As Integer = 0 To DGVConceptos.Rows.Count - 1
                If DGVConceptos.Rows(i).Cells(0).Value = "" Then Exit For
                conceptos.Add(DGVConceptos.Rows(i).Cells(0).Value & "|" & DGVConceptos.Rows(i).Cells(1).Value & "|" & DGVConceptos.Rows(i).Cells(2).Value & "|" & DGVConceptos.Rows(i).Cells(3).Value & "|" & DGVConceptos.Rows(i).Cells(4).Value & "|" & DGVConceptos.Rows(i).Cells(5).Value & "|" & DGVConceptos.Rows(i).Cells(6).Value & "|" & DGVConceptos.Rows(i).Cells(7).Value)
            Next
        End If
        imptraslado.Add("002" & "|" & ValorIVA & "|" & TasaIVA)

        If AplicaISR = True Then
            impretencciones.Add("001" & "|" & ValorISR & "|" & TasaISR)
            If AplicaIEPS = True Then
                impretencciones.Add("003" & "|" & ValorIEPS & "|" & TasaIEPS)

            End If
            Dim totalretenciones = TBRISR.Text + TBRIVA.Text
            FACTURA.factura_html(emisor, receptor, cuerpo, cer, llave, claveprivada, conceptos, imptraslado, TBIva.Text, clave, fecha_factura, totalretenciones, impretencciones,, True)
        Else
            Dim respuesta As String = FACTURA.factura_html(emisor, receptor, cuerpo, cer, llave, claveprivada, conceptos, imptraslado, TBIva.Text, clave, fecha_factura, ,, Application.Session("folios_factura"), True)
            If respuesta <> Nothing Then




                Dim split As String() = respuesta.Split("-")
                Dim asp As New Mostrar_Asp
                Application.Session("DocumentCached") = Nothing
                Application.Session("ReportName") = "R_Representacion_Fisica_CFDi33"
                Application.Session("Modulo") = "DocumentViewer.aspx"
                asp.Actualizar()
                asp.Show()
            End If
        End If





    End Sub



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

            CBSUsoCFDI.LlenarListBox("pCAT_USOCFDI_SAT_FACTURACION_B", "c_UsoCFDI", "DescripcionX", Utilidades.ParametersX_Global)
            CBSUsoCFDI.SelectedValue = "P01"
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
            iva = 0
            subtotal = ImporteDescuento
            TBSubTotal.Text = FormatCurrency(ImporteDescuento)
            TBIva.Text = FormatCurrency(iva)
            TBTotal.Text = FormatCurrency(total)
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CBTraslado_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub CbxClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxClientes.SelectedIndexChanged
        Application.Session("Facturauser") = CbxClientes.ObtenerDescripcion("FACTORUM_USER")
        Application.Session("FacturaContrasena") = CbxClientes.ObtenerDescripcion("ContrasenaFact")
        Application.Session("Cve_Cliente") = CbxClientes.ObtenerDescripcion("Cve_Cliente")
        CargarRetenciones()
        'CbxReceptor.SelectedIndex = -1
        ReDim Utilidades.ParametersX_Global(0)
        Utilidades.ParametersX_Global(0) = New SqlClient.SqlParameter("@Cve_Cliente", CbxClientes.ObtenerDescripcion("Cve_Cliente"))
        'CbxReceptor.LlenarListBox("pFACTURACION_RECEPTOR", "Cve_Receptor", "ReceptorX", Utilidades.ParametersX_Global)
        CONSULTAR(CbxClientes.SelectedValue)
        CargarRFC()
        limpiar()
        'SERIE()
        PREDETERMINADOS()
    End Sub

    Sub CargarRFC()
        ReDim Utilidades.ParametersX_Global(0)
        Utilidades.ParametersX_Global(0) = New SqlParameter("@Cve_Cliente", CbxClientes.SelectedValue)
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
