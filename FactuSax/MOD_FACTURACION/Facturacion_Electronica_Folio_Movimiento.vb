Imports System
Imports Wisej.Web
Imports System.Data
Imports System.Data.SqlClient
Imports System.Math

Public Class Facturacion_Electronica_Folio_Movimiento
    Dim Seria_activa As Integer
    Dim clave As String = Application.Session("Cve_Cliente")
    Dim folios, DESCUENTOX, CveDocumento As String
    Dim descuentoacero As Boolean
    Dim c As Boolean
    Dim FOLIOS_FACTURA As String
    Dim seriex, folio As String
    Public FOLIO_COBRANZA As String
    Public DESCUENTO_COBRANZA As String
    Dim Alertas As New Notificaciones
    Private ME_FOLIO_FACTURAS As String
    Dim AplicaIVA, AplicaISR, AplicaIEPS As Boolean
    Dim ValorIVA, ValorISR, ValorIEPS As String
    Dim TasaIVA, TasaISR, TasaIEPS As String
    Public Function getFolioFactura() As String
        Return ME_FOLIO_FACTURAS
    End Function
    Private Sub RibbonBar7_ItemClick(sender As Object, e As Ext.RibbonBar.RibbonBarItemEventArgs) Handles RibbonBar7.ItemClick
        Select Case e.Item.Name
            Case RBBNuevo.Name

                limpiar(True)
                CBSTipoComprobante.SelectedValue = "I"
            Case RBBBuscar.Name

                If CbxClientes.SelectedIndex <> -1 Then
                    Consultar(CbxClientes.SelectedValue)
                Else
                    Consultar()
                End If
                limpiar(False)
            Case RBBSerie.Name
                If CbxClientes.SelectedIndex <> -1 Then
                    Dim f As New CAT_SERIE_FOLIO_SAT_FACTURACION(CbxClientes.SelectedValue)
                    f.Show()
                    AddHandler f.FormClosed, AddressOf serie
                Else
                    Alertas.NotificacionAdvertencia("Seleccione una sucursal")
                End If
            Case RBBPFacturar.Name
                If verificar() = True Then

                    CREAR_XML()
                    serie()
                    limpiar(True)


                Else
                    descuentoacero = False
                End If
            Case RBBSalir.Name
                Me.Close()
        End Select
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


    Sub Consultar(Optional Cve_Cliente As String = "-99")
        DTPFechaEmision.Value = Date.Now
        MaskedTextBox2.Text = Format(Now, "HH:mm")
        Me.DataSet_pFACTURACION_CAPTURA_FOLIO_MOVIMIENTO.Clear()

        Dim myDA = New SqlClient.SqlDataAdapter("pFACTURACION_CAPTURA_FOLIO_MOVIMIENTO", Utilidades.sConexion)
        myDA.SelectCommand.CommandType = CommandType.StoredProcedure
        myDA.SelectCommand.Parameters.AddWithValue("@Cve_Cliente", Cve_Cliente)
        If CbxReceptor.SelectedIndex <> -1 Then
            myDA.SelectCommand.Parameters.AddWithValue("@Cve_Receptor", CbxReceptor.SelectedValue)
        End If
        myDA.Fill(Me.DataSet_pFACTURACION_CAPTURA_FOLIO_MOVIMIENTO.pFACTURACION_CAPTURA_FOLIO_MOVIMIENTO)
        myDA.Dispose()

        'CbxReceptor.Clear()
        'CbxReceptor.LlenarListBox("pFACTURACION_EMPRESA", "Cve_Receptor", "ReceptorX", Utilidades.ParametersX_Global)
    End Sub
    Private Sub FactuSax_CFD_33_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        DTPFechaEmision.Value = Date.Now
        MaskedTextBox2.Text = Format(Now, "HH:mm")
        'CBTraslado.Checked = True
        ReDim Utilidades.ParametersX_Global(1)
        Utilidades.ParametersX_Global(0) = New SqlClient.SqlParameter("@Cve_Operador", Application.Session("Cve_Operador"))
        CBSTipoComprobante.LlenarListBox("pCAT_TIPOCOMPROBANTE_SAT_FACTURACION_B", "c_TipoDeComprobante", "DescripcionX")
        CBSFormaPago.LlenarListBox("pCAT_FORMAPAGO_SAT_FACTURACION_B", "c_Formapago", "DescripcionX")
        CBSMoneda.LlenarListBox("pCAT_MONEDA_SAT_FACTURACION_B", "c_Moneda", "DescripcionX")

        CBSMetodoPago.LlenarListBox("pCAT_METODOPAGO_SAT_FACTURACION_B", "c_MetodoPago", "DescripcionX")

        CbxClientes.LlenarListBox("pCAT_CLIENTES_B", "Cve_Cliente", "Nombre_Cliente", Utilidades.ParametersX_Global)
        CbxClientes.SelectedIndex = 0
        'CBSIVA.LlenarListBox("pCAT_IMPUESTOS_SAT_FACTURACION_B", "c_Impuesto", "DescripcionX")
        'CBSRISR.LlenarListBox("pCAT_IMPUESTOS_SAT_FACTURACION_B", "c_Impuesto", "DescripcionX")
        'CBSRIVA.LlenarListBox("pCAT_IMPUESTOS_SAT_FACTURACION_B", "c_Impuesto", "DescripcionX")
        'ReDim Utilidades.ParametersX_Global(0)
        'CBEmisor.LlenarListBox("pCAT_RFC_EMISOR_SAT_FACTURACION_B", "RFC", "RFCX")
        SplitContainer1.Panel1MinSize = 340
        'ReDim Utilidades.ParametersX_Global(0)
        'CBSReceptor.LlenarListBox("pCAT_RFC_RECEPTOR_SAT_FACTURACION_B", "RFC", "RFCX")
        'CBSReceptor.SelectedIndex = 0
        CargarRFC()
        Dim TIPO_PERSONA As String = CBSReceptor.ObtenerDescripcion("Tipo_Persona")
        If TIPO_PERSONA = "FISICA" Then
            ReDim Utilidades.ParametersX_Global(0)
            Utilidades.ParametersX_Global(0) = New SqlClient.SqlParameter("@FISICA", "SI")
        Else
            ReDim Utilidades.ParametersX_Global(0)
            Utilidades.ParametersX_Global(0) = New SqlClient.SqlParameter("@MORAL", "SI")
        End If
        CBSUsoCFDI.LlenarListBox("pCAT_USOCFDI_SAT_FACTURACION_B", "c_UsoCFDI", "DescripcionX", Utilidades.ParametersX_Global)
        ReDim Utilidades.ParametersX_Global(0)
        'Utilidades.ParametersX_Global(0) = New SqlParameter("@Cve_Cliente", CbxClientes.SelectedValue)
        CbxReceptor.LlenarListBox("pFACTURACION_EMPRESA", "Cve_Receptor", "ReceptorX", Utilidades.ParametersX_Global)
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
        If CBEmisor.SelectedIndex <> -1 Then
            'Dim datasetx = CBEmisor.DataSource
            Dim tabla_datos As DataTable = CBEmisor.dataTable()
            MTBCP.Text = tabla_datos.Rows(0).Item("Codigo_Postal")
        End If
        CBSTipoComprobante.SelectedValue = "I"
        PREDETERMINADOS()
        If FOLIO_COBRANZA <> Nothing Then
            Consultar()
            conceptos(FOLIO_COBRANZA, "", DESCUENTO_COBRANZA)
            SplitContainer1.Panel1Collapsed = True
            'SplitContainer3.Visible = False
            Me.WindowState = FormWindowState.Normal

        End If
        'serie()
    End Sub

    Sub CargarRFC()
        ReDim Utilidades.ParametersX_Global(1)
        Utilidades.ParametersX_Global(0) = New SqlParameter("@Cve_Cliente", CbxClientes.SelectedValue)
        CbxReceptor.Clear()
        CbxReceptor.LlenarListBox("pFACTURACION_EMPRESA", "Cve_Receptor", "ReceptorX", Utilidades.ParametersX_Global)
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

    Private Sub RDBManual_CheckedChanged(sender As Object, e As EventArgs) Handles RDBManual.CheckedChanged

        SplitContainer1.Panel1Collapsed = RDBManual.Checked
        DGVConceptos.Rows.Clear()
        DGVConceptos.AllowUserToAddRows = True
    End Sub

    Private Sub RDBSolicitrud_CheckedChanged(sender As Object, e As EventArgs) Handles RDBSolicitrud.CheckedChanged

        SplitContainer1.Panel1Collapsed = IIf(RDBSolicitrud.Checked = True, False, True)
        DGVConceptos.Rows.Clear()
        DGVConceptos.AllowUserToAddRows = False

    End Sub

    Private Sub BTRerceptor_Click(sender As Object, e As EventArgs) Handles BTEm.Click, BTRec.Click
        Dim Emisor_Receptor As Boolean
        If sender.NAME = "BTEm" Then
            Emisor_Receptor = 1

        ElseIf sender.name = "BTRec" Then
            Emisor_Receptor = 0
        End If
        Dim f = New Cat_RFC_EMISOR_SAT_FACTURACION(Emisor_Receptor, 1)
        f.Show()

        AddHandler f.FormClosed, AddressOf cerrado_emisor
    End Sub

    Sub cerrado_emisor()


        CBEmisor.LlenarListBox("pCAT_RFC_EMISOR_SAT_FACTURACION_B", "RFC", "RFCX")
        Dim dt_defecto = CBEmisor.dataTable()
        For i As Integer = 0 To dt_defecto.Rows.Count - 1
            If dt_defecto.Rows(i).Item("pordefecto") = True Then
                CBEmisor.SelectedValue = dt_defecto.Rows(i).Item("RFC")
            End If
        Next
        CBSReceptor.LlenarListBox("pCAT_RFC_RECEPTOR_SAT_FACTURACION_B", "RFC", "RFCX")

    End Sub



    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
        If CBEmisor.SelectedIndex = -1 Then Exit Sub
        'Dim datasetx = CBEmisor.DataSource
        Dim tabla_datos As DataTable = CBEmisor.dataTable()
        MTBCP.Text = tabla_datos.Rows(0).Item("Codigo_Postal")

    End Sub


    Private Sub DataGridView2_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs)
        If e.ColumnIndex = 5 Then


            If DGVConceptos.Rows(e.RowIndex).Cells("cCantidad").Value <> Nothing AndAlso DGVConceptos.Rows(e.RowIndex).Cells("cValorUnitario").Value Then
                DGVConceptos.Rows(e.RowIndex).Cells("cImporte").Value = DGVConceptos.Rows(e.RowIndex).Cells("cCantidad").Value * DGVConceptos.Rows(e.RowIndex).Cells("cValorUnitario").Value

            End If

        End If
    End Sub



    Sub serie()
        Try
            ReDim Utilidades.ParametersX_Global(0)
            Utilidades.ParametersX_Global(0) = New SqlClient.SqlParameter("@Cve_Cliente", Application.Session("Cve_Cliente"))
            Dim dt_serie = Utilidades.llenar_dt("pCAT_SERIE_FOLIO_SAT_FACTURACION_B", Utilidades.ParametersX_Global)
            For i As Integer = 0 To dt_serie.Rows.Count - 1
                If dt_serie.Rows(i).Item(4) <> Nothing Then
                    seriex = dt_serie.Rows(i).Item(1)
                    folio = dt_serie.Rows(i).Item(2)

                    Exit For
                End If
            Next
        Catch ex As Exception
            Alertas.NotificacionAdvertencia("Asigne una serie al cliente actual")
        End Try
    End Sub



    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Try
            If e.ColumnIndex = 0 Then
                Dim descuento As Double
                Dim Abonos As Double
                Dim DescuentoFactura As Double
                Dim Saldos As Double

                folios = ""
                CveDocumento = ""
                Abonos = 0
                Saldos = 0


                For i As Integer = 0 To DataGridView1.Rows.Count - 1
                    If DataGridView1.Rows(i).Cells(0).Value = True Then
                        folios += DataGridView1.Rows(i).Cells(1).Value & ","
                        CveDocumento += CbxClientes.SelectedValue & ","
                        Abonos += DataGridView1.Rows(i).Cells(cImporteTotal.Name).Value + 0
                        descuento += DataGridView1.Rows(i).Cells("Descuento").Value + 0
                        DescuentoFactura += DataGridView1.Rows(i).Cells(Me.Descuento_Factura.Name).Value + 0
                    End If
                Next
                If Saldos > 0 Then
                    CBSMetodoPago.SelectedValue = "PPD"
                    CBSMetodoPago.Enabled = False
                Else
                    CBSMetodoPago.Enabled = True

                End If
                If RB_Detallada.Checked = True Then
                    conceptos(folios, CveDocumento, DescuentoFactura)
                Else
                    Sencilla(Abonos, CveDocumento, descuento)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Sub CREAR_XML()
        Dim splithora As String() = MaskedTextBox2.Text.Split(":")
        Dim fecha_factura As DateTime = New DateTime(DTPFechaEmision.Value.Year, DTPFechaEmision.Value.Month, DTPFechaEmision.Value.Day, splithora(0), splithora(1), "00")
        Dim cuerpo As New Dictionary(Of String, String)
        Dim conceptos As New List(Of String)
        Dim imptraslado As New List(Of String)
        Dim impretencciones As New List(Of String)
        Dim FACTURA As New Factura
        Dim RFC_EMISOR As String = CBEmisor.SelectedValue
        Dim NOMBRE_EMISOR As String = CBEmisor.ObtenerDescripcion("Razon_Social")
        Dim EMISOR_REGIMENFISCAL As String = CBEmisor.ObtenerDescripcion("regimen")
        Dim emisor = RFC_EMISOR & "|" & NOMBRE_EMISOR & "|" & EMISOR_REGIMENFISCAL
        Dim rfc_receptor As String = CBSReceptor.SelectedValue
        Dim nombre_receptor As String = CBSReceptor.ObtenerDescripcion("Razon_Social")
        Dim uso_cfdi As String = CBSUsoCFDI.SelectedValue
        Dim receptor = rfc_receptor & "|" & nombre_receptor & "|" & uso_cfdi
        Dim llave = Application.StartupPath & "\Resources\SAT\" & RFC_EMISOR & "\" & CBEmisor.ObtenerDescripcion("llave")
        Dim cer = Application.StartupPath & "\Resources\SAT\" & RFC_EMISOR & "\" & CBEmisor.ObtenerDescripcion("cer")
        Dim claveprivada = CBEmisor.ObtenerDescripcion("claveprivada")
        cuerpo.Add("Folio", folio)
        cuerpo.Add("CveDocumento", CveDocumento)
        cuerpo.Add("NoDocumento", folios)
        cuerpo.Add("Serie", seriex)
        cuerpo.Add("Foma_Pago", CBSFormaPago.SelectedValue)
        cuerpo.Add("Subtotal", TBSubTotal.Text.Replace("$", ""))
        cuerpo.Add("Moneda", CBSMoneda.SelectedValue)

        cuerpo.Add("Total", TBTotal.Text.Replace("$", ""))
        cuerpo.Add("Tipo_comprobante", CBSTipoComprobante.SelectedValue)
        cuerpo.Add("Metodo_pago", CBSMetodoPago.SelectedValue)
        cuerpo.Add("Lugarexpedicion", MTBCP.Text)
        cuerpo.Add("Descuento", IIf(TBDescuento.Text.Replace("$", "") = "0", 0, TBDescuento.Text.Replace("$", "")))
        cuerpo.Add("Tipo_Cambio", TBTipoCambio.Text)
        cuerpo.Add("Condiciones_Pago", IIf(RTBCondicionPago.Text = "", Nothing, RTBCondicionPago.Text))
        cuerpo.Add("TipoRelacion", "NA")
        If DGVConceptos.Rows.Count <> 0 Then
            For i As Integer = 0 To DGVConceptos.Rows.Count - 1
                If DGVConceptos.Rows(i).Cells(0).Value = Nothing Then Exit For
                conceptos.Add(DGVConceptos.Rows(i).Cells(0).Value & "|" & DGVConceptos.Rows(i).Cells(1).Value & "|" & DGVConceptos.Rows(i).Cells(2).Value & "|" & DGVConceptos.Rows(i).Cells(3).Value & "|" & DGVConceptos.Rows(i).Cells(4).Value & "|" & DGVConceptos.Rows(i).Cells(5).Value & "|" & DGVConceptos.Rows(i).Cells(6).Value & "|" & DGVConceptos.Rows(i).Cells(7).Value)
            Next
        End If

        'If CBTraslado.Checked = True Then
        imptraslado.Add("002" & "|" & ValorIVA & "|" & TasaIVA)
        'End If

        If AplicaISR = True Then
            impretencciones.Add("001" & "|" & ValorISR & "|" & TasaISR)
            If AplicaIEPS = True Then
                impretencciones.Add("003" & "|" & ValorIEPS & "|" & TasaIEPS)

            End If
            Dim totalretenciones = TBRISR.Text + TBRIVA.Text
            FACTURA.factura_html(emisor, receptor, cuerpo, cer, llave, claveprivada, conceptos, imptraslado, TBIva.Text, clave, fecha_factura, totalretenciones, impretencciones, ME_FOLIO_FACTURAS)
        Else
            Dim respuesta As String = FACTURA.factura_Movimiento_html(emisor, receptor, cuerpo, cer, llave, claveprivada, conceptos, imptraslado, TBIva.Text, clave, fecha_factura,,, ME_FOLIO_FACTURAS)
            If respuesta <> Nothing Then
                Dim UUID As String = respuesta
                Dim SPLIT As String() = folios.Split(",")

                Dim dt_folios As New DataTable
                ReDim Utilidades.ParametersX_Global(1)
                Utilidades.ParametersX_Global(0) = New SqlClient.SqlParameter("@Folio_Movimiento", SPLIT(0))
                dt_folios = Utilidades.llenar_dt("pFACTURACION_CAPTURA_EGRESOS_FOLIO_MOVIMIENTO", Utilidades.ParametersX_Global)
                For I As Integer = 0 To dt_folios.Rows.Count - 1
                    If dt_folios.Rows(I).Item("Folio") <> "" Then
                        If CbxClientes.ObtenerDescripcion("Sistema") = "iSISLAB" Then
                            Dim Insertar As New WebService_InsercionSISLAB.Actualizar_Estatus()
                            Insertar.Actualizar(dt_folios.Rows(I).Item("Folio"), UUID, "TIMBRADA", CBSReceptor.SelectedValue, dt_folios.Rows(I).Item("Folio_Movimiento"), Now())
                        End If
                    End If
                Next



                Application.Session("DocumentCached") = Nothing
                Application.Session("ReportName") = "R_Representacion_Fisica_CFDi33"

                AspPageBox1.Update()
            End If
            'If  <> Nothing Then
            '    Utilidades.ExportarPlantilla(Me,)
            'End If

        End If


        'FACTURA.factura_html(TBSerie.Text, TBFolio.Text, CBEmisor.SelectedValue)
    End Sub

    'Sub ACTUALIZAR_FOLIO()
    '    Dim sDevuelveId
    '    ReDim Utilidades.ParametersX_Global(0)
    '    Utilidades.ParametersX_Global(0) = New SqlClient.SqlParameter("@ID", Seria_activa)
    '    sDevuelveId = Utilidades.fGuardar_O_EliminarXProcedure_DevuelveId("[pCAT_SERIE_FOLIO_SAT_FACTURACION_INCREMENTAL]", "@Parametro", Utilidades.ParametersX_Global, , SqlDbType.VarChar, 50)
    '    serie()
    'End Sub

    Sub limpiar(b As Boolean)
        CBSReceptor.SelectedIndex = -1
        RTBCondicionPago.Text = Nothing
        DGVConceptos.Rows.Clear()
        If b = True Then
            Me.DataSet_pFACTURACION_CAPTURA_FOLIO_MOVIMIENTO.Clear()
        End If

        TBDescuento.Text = "$0"
        TBIva.Text = "$0"
        TBSubTotal.Text = "$0"
        TBRISR.Text = "$0"
        TBRIVA.Text = "$0"
        TBTotal.Text = "$0"
        Me.ME_FOLIO_FACTURAS = Nothing
    End Sub

    Private Sub CBSTipoComprobante_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBSTipoComprobante.SelectedIndexChanged
        If CBSTipoComprobante.SelectedIndex = -1 Then Exit Sub


        If CBSTipoComprobante.SelectedValue = "P" Then
            'GroupBox2.Visible = False
            SplitContainer1.Panel1Collapsed = True
            DGVConceptos.Rows.Clear()
            CBSMoneda.SelectedValue = "XXX"
            TBTipoCambio.Text = Nothing
            TBTipoCambio.Enabled = False
            RTBCondicionPago.Text = Nothing
            RTBCondicionPago.Enabled = False
            Dim parametros As String()
            ReDim parametros(7)
            parametros(0) = "1" : parametros(1) = "84111506 - Servicio de Facturacion" : parametros(2) = "ACT" : parametros(3) = "Pago" : parametros(4) = 0 : parametros(5) = 0 : parametros(6) = 0 : parametros(7) = ""
            DGVConceptos.Rows.Add(parametros)
            CBSMetodoPago.SelectedIndex = -1
            CBSMetodoPago.Enabled = False
            CBSFormaPago.SelectedIndex = -1
            CBSFormaPago.Enabled = False

            c = 1
        Else
            'GroupBox2.Visible = True
            SplitContainer1.Panel1Collapsed = False
            DGVConceptos.Rows.Clear()
            PREDETERMINADOS()
        End If


    End Sub

    Function verificar() As Boolean
        If DGVConceptos.Rows.Count = 0 Then
            Return False
        End If
        If CbxClientes.SelectedIndex = -1 Then
            ErrorProvider1.SetError(CbxClientes, "Seleccione el cliente")
            Alertas.NotificacionAdvertencia("Seleccione el cliente que va a facturar")
            Return False
        Else
            ErrorProvider1.SetError(CbxClientes, "")
        End If
        If CBSReceptor.SelectedIndex = -1 Then
            ErrorProvider1.SetError(CBSReceptor, "Seleccione Receptor")
            Alertas.NotificacionAdvertencia("Seleccione el receptor")

            Return False
        Else
            ErrorProvider1.SetError(CBSReceptor, "")
        End If

        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            If DataGridView1.Rows(I).Cells(0).Value = True Then
                If DataGridView1.Rows(I).Cells("Descuento").Value = 0 Then
                    descuentoacero = True
                    Exit For
                End If
            End If


        Next
        For I As Integer = 0 To DataGridView1.Rows.Count - 1
            If descuentoacero = True Then
                If DataGridView1.Rows(I).Cells(0).Value = True Then
                    If DataGridView1.Rows(I).Cells("Descuento").Value <> 0 Then
                        MessageBox.Show("No se puede facturar folios Con Descuento y Sin Descuento Junto" & vbCrLf & "Favor de Verificar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Return False
                    End If
                End If
            End If


        Next

        'If Not Utilidades.TieneTimbresDisponibles(CBEmisor.SelectedValue) Then

        'MessageBox.Show("No quedan timbres disponibles en tu paquete contratado")
        '    Return False
        'End If
        Return True
    End Function

    Private Sub CbxEmpresa_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxClientes.SelectedIndexChanged
        Application.Session("Facturauser") = CbxClientes.ObtenerDescripcion("FACTORUM_USER")
        Application.Session("FacturaContrasena") = CbxClientes.ObtenerDescripcion("ContrasenaFact")
        Application.Session("Cve_Cliente") = CbxClientes.ObtenerDescripcion("Cve_Cliente")
        CargarRetenciones()
        Consultar(CbxClientes.SelectedValue)
        limpiar(False)
        serie()
        CargarRFC()
        PREDETERMINADOS()



    End Sub


    Private Sub DGVConceptos_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs)
        If e.ColumnIndex = cDescuento.Index Or e.ColumnIndex = cValorUnitario.Index Or e.ColumnIndex = cCantidad.Index Then
            Dim valor = DGVConceptos.Item(e.ColumnIndex, e.RowIndex).Value
            Dim DescuentoManual As Double
            If IsNumeric(valor) Then
                If RDBManual.Checked = True Then

                    Dim total, iva, riva, risr, totaldesc, preciosiniva As Double
                    Dim SUBTOTAL As Double
                    DGVConceptos.Item(cImporte.Name, e.RowIndex).Value = (DGVConceptos.Item(cValorUnitario.Name, e.RowIndex).Value) * (DGVConceptos.Item(cCantidad.Name, e.RowIndex).Value)

                    For i = 0 To DGVConceptos.Rows.Count - 1
                        total = DGVConceptos.Item(cImporte.Name, e.RowIndex).Value + 0
                        DescuentoManual += DGVConceptos.Item(cDescuento.Name, e.RowIndex).Value + 0

                    Next
                    totaldesc = total - DescuentoManual
                    iva = totaldesc * Double.Parse(ValorIVA)
                    SUBTOTAL = totaldesc
                    'If CBRetencion.Checked Then
                    '    risr = SUBTOTAL * (MTBRISR.Text)
                    '    riva = SUBTOTAL * (MTBRIVA.Text)
                    'End If


                    TBSubTotal.Text = FormatCurrency(total)
                    TBDescuento.Text = FormatCurrency(DescuentoManual)
                    TBIva.Text = FormatCurrency(iva)
                    TBRISR.Text = FormatCurrency(risr + 0)
                    TBRIVA.Text = FormatCurrency(riva + 0)
                    total = SUBTOTAL + iva - risr - riva
                    TBTotal.Text = FormatCurrency(total)
                End If
            End If

        End If


    End Sub

    Private Sub DGVConceptos_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs)
        DGVConceptos.Item(cImporte.Name, e.RowIndex).Value = 0
        DGVConceptos.Item(cDescuento.Name, e.RowIndex).Value = 0
    End Sub

    Private Sub RB_Sencilla_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Sencilla.CheckedChanged
        For Each fila As DataGridViewRow In DataGridView1.Rows
            fila.Cells(0).Value = False
        Next
        DGVConceptos.Rows.Clear()
    End Sub

    Private Sub CBSUsoCFDI_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBSReceptor.SelectedIndexChanged

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

    Private Sub CheckBox1_CheckedChanged_1(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            For Each fila As DataGridViewRow In DataGridView1.Rows
                fila.Cells(0).Value = True
            Next
            CalcularMasivo()
        Else
            For Each fila As DataGridViewRow In DataGridView1.Rows
                fila.Cells(0).Value = False
            Next
            DGVConceptos.Rows.Clear()
        End If
    End Sub

    Sub CalcularMasivo()
        Try
            Dim descuento As Double
            Dim Abonos As Double
            Dim DescuentoFactura As Double

            folios = ""
            CveDocumento = ""
            Abonos = 0

            For i As Integer = 0 To DataGridView1.Rows.Count - 1
                If DataGridView1.Rows(i).Cells(0).Value = True Then
                    folios += DataGridView1.Rows(i).Cells(1).Value & ","
                    CveDocumento += CbxClientes.SelectedValue & ","
                    Abonos += DataGridView1.Rows(i).Cells(cImporteTotal.Name).Value + 0
                    descuento += DataGridView1.Rows(i).Cells(Descuento_Factura.Name).Value + 0
                    DescuentoFactura += DataGridView1.Rows(i).Cells(Me.Descuento_Factura.Name).Value + 0
                End If
            Next
            If RB_Detallada.Checked = True Then
                conceptos(folios, CveDocumento, DescuentoFactura)
            Else
                Sencilla(Abonos, CveDocumento, descuento)
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub CbxReceptor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxReceptor.SelectedIndexChanged
        If CbxClientes.SelectedIndex <> -1 Then
            Consultar(CbxClientes.SelectedValue)
        Else
            Consultar()
        End If
    End Sub

    Sub PREDETERMINADOS()

        If c = 1 Then
            CBSTipoComprobante.SelectedValue = "I"
            c = 0
        End If


        CBSMoneda.SelectedValue = "MXN"
        CBSUsoCFDI.SelectedValue = "P01"
        CBSFormaPago.SelectedValue = "01"
        CBSMetodoPago.SelectedValue = "PUE"
        'CBSIVA.SelectedValue = "002"
        'MTBIVA.Text = "0.160000"
        'MTBRIVA.Text = "0.106666"
        'MTBRISR.Text = "0.100000"
        'CBSRIVA.SelectedValue = "002"
        RDBSolicitrud.Checked = True
        'CBSRISR.SelectedValue = "001"
        Dim dt_defecto = CBEmisor.dataTable
        For i As Integer = 0 To dt_defecto.Rows.Count - 1
            If dt_defecto.Rows(i).Item("pordefecto") = True Then
                CBEmisor.SelectedValue = dt_defecto.Rows(i).Item("RFC")
            End If
        Next
        If CBEmisor.SelectedIndex <> -1 Then
            'Dim datasetx = CBEmisor.DataSource
            Dim tabla_datos As DataTable = CBEmisor.dataTable()
            MTBCP.Text = tabla_datos.Rows(0).Item("Codigo_Postal")
        End If

        TBTipoCambio.Text = 1
        TBTipoCambio.Enabled = True
        RTBCondicionPago.Enabled = True
        'TasaoCuotaIVA.SelectedItem = "Tasa"
        CBSMetodoPago.SelectedValue = "PUE"
        CBSMetodoPago.Enabled = True
        CBSFormaPago.Enabled = True

    End Sub
    Sub conceptos(folios As String, Documentos As String, descuento As Double)
        Dim total, iva, riva, risr, totaldesc, preciosiniva As Double
        Dim SUBTOTAL As Double
        RTBCondicionPago.Text = "Factura Tipo =  " & CBSMetodoPago.SelectedItem & " De los Folios = " & folios
        Me.ME_FOLIO_FACTURAS = folios
        Application.Session("documentos_factura") = Documentos

        Dim dt_conceptos As New DataTable
        ReDim Utilidades.ParametersX_Global(1)
        Utilidades.ParametersX_Global(0) = New SqlClient.SqlParameter("@Folio_Movimiento", folios)
        Utilidades.ParametersX_Global(1) = New SqlClient.SqlParameter("@Cve_Cliente", CbxClientes.SelectedValue)

        dt_conceptos = Utilidades.llenar_dt("pFACTURACION_CAPTURA_CONCEPTOS_FOLIO_MOVIMIENTO", Utilidades.ParametersX_Global)
        DGVConceptos.Rows.Clear()
        For i As Integer = 0 To dt_conceptos.Rows.Count - 1
            DGVConceptos.Rows.Insert(DGVConceptos.Rows.Count)
            Dim filaNueva = DGVConceptos.Rows(DGVConceptos.Rows.Count - 1)
            'Dim parametros As String()
            'ReDim parametros(7)
            Dim split As String() = dt_conceptos.Rows(i).Item("Producto").split("-")
            filaNueva(cCantidad.Name).Value = dt_conceptos.Rows(i).Item("Cantidad")
            filaNueva(cbClaveProdServ.Name).Value = "84111506 - Servicios de facturación"
            filaNueva(cbClaveUnidad.Name).Value = "E48"
            filaNueva(cDescripcion.Name).Value = split(1).Trim
            filaNueva(cValorUnitario.Name).Value = Round(dt_conceptos.Rows(i).Item("Unitario"), 4)
            filaNueva(cImporte.Name).Value = Round(dt_conceptos.Rows(i).Item("IMPORTE"), 4)
            filaNueva(cDescuento.Name).Value = Round(dt_conceptos.Rows(i).Item("Descuento"), 4)
            filaNueva(cNoIdentificacion.Name).Value = split(0).Trim
            'DGVConceptos.Rows.Add(filaNueva)

            'TfBTotal.Text += Decimal.Parse(dt_conceptos.Rows(i).Item(3))
        Next
        For i As Integer = 0 To dt_conceptos.Rows.Count - 1
            total += Round(dt_conceptos.Rows(i).Item("IMPORTE"), 4)
        Next
        Dim DESCUENTOX As Double
        'DESCUENTOX = (descuento * 100 / total) / 100
        For I As Integer = 0 To DGVConceptos.Rows.Count - 1
            DESCUENTOX = descuento + DGVConceptos.Rows(I).Cells("cDescuento").Value
            'DGVConceptos.Rows(I).Cells("cDescuento").Value = Round((DGVConceptos.Rows(I).Cells("cImporte").Value * DESCUENTOX), 2)
        Next
        'Dim totalDescuento = descuento +
        totaldesc = total - DESCUENTOX
        iva = total * Double.Parse(ValorIVA)
        SUBTOTAL = totaldesc
        'SUBTOTAL = total
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

    Sub Sencilla(Subtotal As Double, Documentos As String, Descuento As Double)
        'DGVConceptos.Rows.Clear()
        Dim total, iva, riva, risr, totaldesc, preciosiniva As Double
        Dim ME_SUBTOTAL As Double
        RTBCondicionPago.Text = "Factura Tipo =  " & CBSMetodoPago.SelectedItem & " De los Folios = " & folios
        Me.ME_FOLIO_FACTURAS = folios
        Application.Session("documentos_factura") = Documentos
        DGVConceptos.Rows.Clear()
        DGVConceptos.Rows.Insert(DGVConceptos.Rows.Count)
        Dim filaNueva = DGVConceptos.Rows(DGVConceptos.Rows.Count - 1)



        filaNueva(cCantidad.Name).Value = "1"
        filaNueva(cbClaveProdServ.Name).Value = "84111506 - Servicios de facturación"
        filaNueva(cbClaveUnidad.Name).Value = "E48"
        filaNueva(cDescripcion.Name).Value = RTBCondicionPago.Text
        filaNueva(cValorUnitario.Name).Value = Subtotal
        filaNueva(cImporte.Name).Value = Subtotal
        filaNueva(cDescuento.Name).Value = Descuento
        filaNueva(cNoIdentificacion.Name).Value = "GLOBAL"

        For i As Integer = 0 To DGVConceptos.Rows.Count - 1
            total += DGVConceptos.Rows(i).Item(cValorUnitario.Name).Value
        Next

        totaldesc = total - Descuento
        iva = total * Double.Parse(ValorIVA)
        Subtotal = totaldesc
        If AplicaISR = True Then
            risr = Subtotal * (ValorISR)
        End If
        If AplicaIEPS = True Then
            riva = Subtotal * (ValorIEPS)

        End If
        TBSubTotal.Text = FormatCurrency(total)
        TBDescuento.Text = FormatCurrency(Descuento)
        TBIva.Text = FormatCurrency(iva)
        TBRISR.Text = FormatCurrency(risr + 0)
        TBRIVA.Text = FormatCurrency(riva + 0)
        total = Subtotal + iva - risr - riva
        TBTotal.Text = FormatCurrency(total)
    End Sub



End Class