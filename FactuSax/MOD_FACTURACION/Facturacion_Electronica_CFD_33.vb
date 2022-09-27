
Imports System.Math
Imports System.Globalization
Imports DevExpress.XtraReports.UI
Imports System.Data
Imports System.Data.SqlClient

Public Class Facturacion_Electronica_CFD_33
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
            Case RBBImpuestos.Name
                Dim Retenciones As New Cat_Retenciones
                Retenciones.ShowDialogAsync()
                AddHandler Retenciones.FormClosed, AddressOf CargarRetenciones
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

        Me.DataSet_pFACTURACION_RECEPTOR_PADRE_HIJO.Clear()
        Dim myDA = New SqlClient.SqlDataAdapter("pFACTURACION_RECEPTOR_PADRE_HIJO", Utilidades.sConexion)
        myDA.SelectCommand.CommandType = CommandType.StoredProcedure
        myDA.SelectCommand.Parameters.AddWithValue("@Cve_Cliente", CbxClientes.SelectedValue)
        myDA.SelectCommand.Parameters.AddWithValue("@Fecha1", Format(Me.cFecha1.Value, "yyyyMMdd"))
        myDA.SelectCommand.Parameters.AddWithValue("@Fecha2", Format(Me.cFecha2.Value, "yyyyMMdd"))
        myDA.SelectCommand.Parameters.AddWithValue("@AplicaSaldo", Chk_SaldoPendiente.Checked)
        myDA.Fill(DataSet_pFACTURACION_RECEPTOR_PADRE_HIJO.pFACTURACION_RECEPTOR_PADRE_HIJO)
        myDA.Dispose()
        CargarParent()

        For i = 0 To DGV_Receptor.Rows.Count - 1
            If DGV_Receptor.Item(colChecked.Index, i).Value = 0 Then
                DGV_Receptor.Rows(i).Cells(cCheckPadre.Index).ReadOnly = True
                DGV_Receptor.Rows(i).Cells(cCheckPadre.Index).ToolTipText = "No se puede seleccionar múltiple si hay saldo pendiente"

            Else
                DGV_Receptor.Rows(i).Cells(cCheckPadre.Index).ReadOnly = False


            End If
        Next


    End Sub
    Private Sub FactuSax_CFD_33_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.WindowState = FormWindowState.Maximized
        DTPFechaEmision.Value = Date.Now
        dgvEliminar.Visible = False
        MaskedTextBox2.Text = Format(Now, "HH:mm")
        'CBTraslado.Checked = True
        cFecha1.Value = Now
        cFecha2.Value = Now
        ReDim Utilidades.ParametersX_Global(1)
        Utilidades.ParametersX_Global(0) = New SqlClient.SqlParameter("@Cve_Operador", Application.Session("Cve_Operador"))
        CBSTipoComprobante.LlenarListBox("pCAT_TIPOCOMPROBANTE_SAT_FACTURACION_B", "c_TipoDeComprobante", "DescripcionX")
        CBSFormaPago.LlenarListBox("pCAT_FORMAPAGO_SAT_FACTURACION_B", "c_Formapago", "DescripcionX")
        CBSMoneda.LlenarListBox("pCAT_MONEDA_SAT_FACTURACION_B", "c_Moneda", "DescripcionX")

        CBSMetodoPago.LlenarListBox("pCAT_METODOPAGO_SAT_FACTURACION_B", "c_MetodoPago", "DescripcionX")

        CbxClientes.LlenarListBox("pCAT_CLIENTES_B", "Cve_Cliente", "Nombre_Cliente", Utilidades.ParametersX_Global)
        CbxClientes.SelectedIndex = 0

        SplitContainer1.Panel1MinSize = 340
        ReDim Utilidades.ParametersX_Global(0)
        'Utilidades.ParametersX_Global(0) = New SqlClient.SqlParameter("@emisor_receptor", "RECEPTOR")
        ''CBSReceptor.SelectedIndex = 0
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

            Me.WindowState = FormWindowState.Normal

        End If
        'serie()
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

    Private Sub RDBManual_CheckedChanged(sender As Object, e As EventArgs) Handles RDBManual.CheckedChanged

        SplitContainer1.Panel1Collapsed = RDBManual.Checked
        DGVConceptos.Rows.Clear()
        DGVConceptos.AllowUserToAddRows = True
    End Sub

    Private Sub RDBSolicitrud_CheckedChanged(sender As Object, e As EventArgs) Handles RDBSolicitrud.CheckedChanged

        SplitContainer1.Panel1Collapsed = IIf(RDBSolicitrud.Checked = True, False, True)
        DGVConceptos.Rows.Clear()
        DGVConceptos.AllowUserToAddRows = False
        dgvEliminar.Visible = IIf(RDBManual.Checked = True, True, False)

    End Sub

    Private Sub BTRerceptor_Click(sender As Object, e As EventArgs) Handles BTEm.Click, BTRec.Click
        Dim Emisor_Receptor As Boolean
        If sender.NAME = "BTEm" Then
            Emisor_Receptor = 1

        ElseIf sender.name = "BTRec" Then
            Emisor_Receptor = 0
        End If
        Application.Session("Cve_Cliente") = CbxClientes.SelectedValue
        Dim f = New Cat_RFC_EMISOR_SAT_FACTURACION(Emisor_Receptor, 0)
        f.Show()

        AddHandler f.FormClosed, AddressOf cerrado_emisor
    End Sub

    Sub cerrado_emisor()

        ReDim Utilidades.ParametersX_Global(0)
        CBEmisor.LlenarListBox("pCAT_RFC_EMISOR_SAT_FACTURACION_B", "RFC", "RFCX", Utilidades.ParametersX_Global)
        Dim dt_defecto = CBEmisor.dataTable()
        For i As Integer = 0 To dt_defecto.Rows.Count - 1
            If dt_defecto.Rows(i).Item("pordefecto") = True Then
                CBEmisor.SelectedValue = dt_defecto.Rows(i).Item("RFC")
            End If
        Next
        ReDim Utilidades.ParametersX_Global(0)
        CBSReceptor.LlenarListBox("pCAT_RFC_RECEPTOR_SAT_FACTURACION_B", "RFC", "RFCX", Utilidades.ParametersX_Global)

    End Sub



    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs)
        If CBEmisor.SelectedIndex = -1 Then Exit Sub
        'Dim datasetx = CBEmisor.DataSource
        Dim tabla_datos As DataTable = CBEmisor.dataTable()
        MTBCP.Text = tabla_datos.Rows(0).Item("Codigo_Postal")

    End Sub


    Private Sub DataGridView2_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs)
        If e.ColumnIndex = 0 Then
            DGVConceptos.Rows.RemoveAt(e.RowIndex)
            CalculoManual()

        End If

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
    Private Sub DataGridView1_CellClick(sender As Object, e As Integer)

        Try
            If e = 0 Then
                Dim descuento As Double
                Dim Abonos As Double
                Dim DescuentoFactura As Double
                Dim Saldos As Double
                Dim Importe As Double = 0
                Dim MetodoPago As String

                folios = ""
                CveDocumento = ""
                Abonos = 0
                Saldos = 0
                RTBCondicionPago.Text = Nothing
                For i As Integer = 0 To sender.Rows.Count - 1
                    If sender.Rows(i).Cells(0).Value = 1 Then

                        folios += sender.Rows(i).Cells(1).Value & ","
                        CveDocumento += CbxClientes.SelectedValue & ","
                        Abonos += sender.Rows(i).Cells(cUnitario.Name).Value + 0
                        descuento += sender.Rows(i).Cells("Descuento").Value + 0
                        DescuentoFactura += sender.Rows(i).Cells(Me.Descuento_Factura.Name).Value + 0
                        Saldos += sender.Rows(i).Cells(cSaldo.Name).Value
                        If sender.Rows(i).Cells(colImporte_Total.Name).value > Importe Then
                            MetodoPago = sender.Rows(i).Cells(colTipo_Pago.Name).value
                            Importe = sender.Rows(i).Cells(colImporte_Total.Name).value
                        End If
                    End If
                Next

                If Saldos > 0 Then
                    CBSMetodoPago.SelectedValue = "PPD"
                    CBSMetodoPago.Enabled = False
                Else
                    CBSMetodoPago.Enabled = True

                End If

                SeleccionMetodoPago(MetodoPago)

                If RB_Detallada.Checked = True Then
                    conceptos(folios, CveDocumento, DescuentoFactura)
                Else
                    Sencilla(Abonos, CveDocumento, descuento)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub


    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Facturas.CellClick
        Try
            If e.ColumnIndex = 0 Then
                Dim descuento As Double
                Dim Abonos As Double
                Dim DescuentoFactura As Double
                Dim Saldos As Double
                Dim Importe As Double = 0
                Dim MetodoPago As String


                folios = ""
                CveDocumento = ""
                Abonos = 0
                Saldos = 0
                RTBCondicionPago.Text = Nothing

                For i As Integer = 0 To sender.Rows.Count - 1
                    If sender.Rows(i).Cells(0).Value = 1 Then

                        folios += sender.Rows(i).Cells(1).Value & ","
                        CveDocumento += CbxClientes.SelectedValue & ","
                        Abonos += sender.Rows(i).Cells(cUnitario.Name).Value + 0
                        descuento += sender.Rows(i).Cells("Descuento").Value + 0
                        DescuentoFactura += sender.Rows(i).Cells(Me.Descuento_Factura.Name).Value + 0
                        Saldos += sender.Rows(i).Cells(cSaldo.Name).Value
                        If sender.Rows(i).Cells(colImporte_Total.Name).value > Importe Then
                            MetodoPago = sender.Rows(i).Cells(colTipo_Pago.Name).value
                            Importe = sender.Rows(i).Cells(colImporte_Total.Name).value
                        End If
                    End If
                Next
                If Saldos > 0 Then
                    CBSMetodoPago.SelectedValue = "PPD"
                    CBSMetodoPago.Enabled = False
                Else
                    CBSMetodoPago.Enabled = True

                End If
                SeleccionMetodoPago(MetodoPago)

                If RB_Detallada.Checked = True Then
                    conceptos(folios, CveDocumento, DescuentoFactura)
                Else
                    Sencilla(Abonos, CveDocumento, descuento)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Sub SeleccionMetodoPago(ByVal MetodoPago As String)
        Select Case MetodoPago
            Case "Efectivo"
                CBSFormaPago.SelectedValue = "01"
            Case "Tarjeta"
                CBSFormaPago.SelectedValue = "04"
            Case "Deposito Bancario"
                CBSFormaPago.SelectedValue = "03"
            Case "Trans. Electronica"
                CBSFormaPago.SelectedValue = "03"
            Case "NA"
                CBSFormaPago.SelectedValue = "99"
        End Select

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
                If DGVConceptos.Rows(i).Cells(cCantidad.Name).Value = Nothing Then Exit For
                conceptos.Add(DGVConceptos.Rows(i).Cells(cCantidad.Name).Value & "|" & DGVConceptos.Rows(i).Cells(cbClaveProdServ.Name).Value & "|" & DGVConceptos.Rows(i).Cells(cbClaveUnidad.Name).Value & "|" & DGVConceptos.Rows(i).Cells(cDescripcion.Name).Value & "|" & DGVConceptos.Rows(i).Cells(cValorUnitario.Name).Value & "|" & DGVConceptos.Rows(i).Cells(cImporte.Name).Value & "|" & DGVConceptos.Rows(i).Cells(cDescuento.Name).Value & "|" & DGVConceptos.Rows(i).Cells(cNoIdentificacion.Name).Value)
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
            Dim respuesta As String = FACTURA.factura_html(emisor, receptor, cuerpo, cer, llave, claveprivada, conceptos, imptraslado, TBIva.Text, clave, fecha_factura,,, ME_FOLIO_FACTURAS)
            If respuesta <> Nothing Then
                Dim UUID As String = respuesta
                'ReDim Utilidades.ParametersX_Global(3)
                'Utilidades.ParametersX_Global(0) = New SqlParameter("@Folio", folio)
                'Utilidades.ParametersX_Global(1) = New SqlParameter("@Estatus", "FACTURADO")
                ''Utilidades.ParametersX_Global(2) = New SqlParameter("@Cve_Receptor", folio)
                'Utilidades.ParametersX_Global(2) = New SqlParameter("@Cve_Cliente", CbxClientes.SelectedValue)
                'Dim fACTUR = Utilidades.EjecutarProcedure_Id("pFACTURACION_G", "@PARAMETRO", Utilidades.ParametersX_Global)


                For Each fila As DataGridViewRow In DGV_Receptor.Rows

                    Dim ControlGrilla As DataGridView = fila.Cells(0).Control
                    If ControlGrilla IsNot Nothing Then
                        For Each filaHijo As DataGridViewRow In ControlGrilla.Rows
                            If CbxClientes.ObtenerDescripcion("Sistema") = "iSISLAB" Then
                                Dim Insertar As New WebService_InsercionSISLAB.Actualizar_Estatus()
                                If filaHijo.Cells(0).Value = 1 Then
                                    Insertar.Actualizar(filaHijo.Cells(cFolio.Name).Value, UUID, "TIMBRADA", CBSReceptor.SelectedValue, filaHijo.Cells(cFolio_Movimiento.Name).Value, Now())
                                End If
                            End If
                        Next

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
        If CbxClientes.SelectedIndex <> -1 Then
            Consultar(CbxClientes.SelectedValue)
        Else
            Consultar()
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
            Me.DataSet_pFACTURACION_CAPTURA_EGRESOS1.Clear()
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

        For I As Integer = 0 To DGV_Facturas.Rows.Count - 1
            If DGV_Facturas.Rows(I).Cells(0).Value = True Then
                If DGV_Facturas.Rows(I).Cells("Descuento").Value = 0 Then
                    descuentoacero = True
                    Exit For
                End If
            End If


        Next
        For I As Integer = 0 To DGV_Facturas.Rows.Count - 1
            If descuentoacero = True Then
                If DGV_Facturas.Rows(I).Cells(0).Value = True Then
                    If DGV_Facturas.Rows(I).Cells("Descuento").Value <> 0 Then
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
        'CbxReceptor.SelectedIndex = -1
        ReDim Utilidades.ParametersX_Global(0)
        Utilidades.ParametersX_Global(0) = New SqlClient.SqlParameter("@Cve_Cliente", CbxClientes.ObtenerDescripcion("Cve_Cliente"))
        'CbxReceptor.LlenarListBox("pFACTURACION_RECEPTOR", "Cve_Receptor", "ReceptorX", Utilidades.ParametersX_Global)
        Consultar(CbxClientes.SelectedValue)
        CargarRFC()
        limpiar(False)
        serie()



    End Sub


    Private Sub DGVConceptos_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs)
        If e.ColumnIndex = cDescuento.Index Or e.ColumnIndex = cValorUnitario.Index Or e.ColumnIndex = cCantidad.Index Then
            Dim valor = DGVConceptos.Item(e.ColumnIndex, e.RowIndex).Value
            If IsNumeric(valor) Then
                If RDBManual.Checked = True Then
                    DGVConceptos.Item(cImporte.Name, e.RowIndex).Value = (DGVConceptos.Item(cValorUnitario.Name, e.RowIndex).Value) * (DGVConceptos.Item(cCantidad.Name, e.RowIndex).Value)
                    CalculoManual()

                End If
            End If

        End If


    End Sub

    Sub CalculoManual()
        Dim total, iva, riva, risr, totaldesc, preciosiniva As Double
        Dim SUBTOTAL As Double
        Dim DescuentoManual As Double


        For i = 0 To DGVConceptos.Rows.Count - 1
            total += DGVConceptos.Item(cImporte.Name, i).Value + 0
            DescuentoManual += DGVConceptos.Item(cDescuento.Name, i).Value + 0

        Next
        totaldesc = total - DescuentoManual
        iva = totaldesc * Double.Parse(iva)
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
    End Sub
    Private Sub DGVConceptos_RowsAdded(sender As Object, e As DataGridViewRowsAddedEventArgs)
        DGVConceptos.Item(cImporte.Name, e.RowIndex).Value = 0
        DGVConceptos.Item(cDescuento.Name, e.RowIndex).Value = 0
    End Sub

    Private Sub RB_Sencilla_CheckedChanged(sender As Object, e As EventArgs) Handles RB_Sencilla.CheckedChanged

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
            For Each fila As DataGridViewRow In DGV_Facturas.Rows
                fila.Cells(0).Value = True
            Next
            CalcularMasivo()
        Else
            For Each fila As DataGridViewRow In DGV_Facturas.Rows
                fila.Cells(0).Value = False
            Next
            DGVConceptos.Rows.Clear()
        End If
    End Sub

    Private Sub DGV_Receptor_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Receptor.CellClick
        If e.RowIndex <> -1 Then
            CBSReceptor.SelectedValue = DGV_Receptor.Item(colRFC.Index, e.RowIndex).Value
            If e.ColumnIndex = cCheckPadre.Index Then
                DGV_Receptor.Rows(e.RowIndex).Expand()
            End If
        End If
    End Sub

    Sub CheckDatos()

    End Sub


    Sub CalcularMasivo()
        Try
            Dim descuento As Double
            Dim Abonos As Double
            Dim DescuentoFactura As Double

            folios = ""
            CveDocumento = ""
            Abonos = 0

            For i As Integer = 0 To DGV_Facturas.Rows.Count - 1
                If DGV_Facturas.Rows(i).Cells(0).Value = True Then
                    folios += DGV_Facturas.Rows(i).Cells(1).Value & ","
                    CveDocumento += CbxClientes.SelectedValue & ","
                    Abonos += DGV_Facturas.Rows(i).Cells(cUnitario.Name).Value + 0
                    descuento += DGV_Facturas.Rows(i).Cells(Descuento_Factura.Name).Value + 0
                    DescuentoFactura += DGV_Facturas.Rows(i).Cells(Me.Descuento_Factura.Name).Value + 0
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


    Private Sub cFecha1_ValueChanged(sender As Object, e As EventArgs) Handles cFecha1.ValueChanged
        If CbxClientes.SelectedIndex <> -1 Then
            Consultar(CbxClientes.SelectedValue)
        Else
            Consultar()
        End If
    End Sub

    Private Sub cFecha2_ValueChanged(sender As Object, e As EventArgs) Handles cFecha2.ValueChanged
        If CbxClientes.SelectedIndex <> -1 Then
            Consultar(CbxClientes.SelectedValue)
        Else
            Consultar()
        End If
    End Sub

    'Private Sub CbxReceptor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxReceptor.SelectedIndexChanged
    '    If CbxClientes.SelectedIndex <> -1 Then
    '        Consultar(CbxClientes.SelectedValue)
    '    Else
    '        Consultar()
    '    End If
    '    If CbxReceptor.ObtenerDescripcion("RFC") <> "" Then
    '        CBSReceptor.SelectedValue = CbxReceptor.ObtenerDescripcion("RFC")
    '    End If
    'End Sub
    'Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)
    '    'CalcularMasivo()
    'End Sub

    Sub PREDETERMINADOS()

        If c = 1 Then
            CBSTipoComprobante.SelectedValue = "I"
            c = 0
        End If


        CBSMoneda.SelectedValue = "MXN"
        CBSUsoCFDI.SelectedValue = "P01"
        CBSFormaPago.SelectedValue = "01"
        CBSMetodoPago.SelectedValue = "PUE"
        If ValorIVA = Nothing Then
            'CBSIVA.SelectedValue = "002"
            'MTBIVA.Text = "0.160000"
            'MTBRIVA.Text = "0.106666"
            'MTBRISR.Text = "0.100000"
            'CBSRIVA.SelectedValue = "002"
            'CBSRISR.SelectedValue = "001"

        End If

        RDBSolicitrud.Checked = True
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
        Utilidades.ParametersX_Global(0) = New SqlClient.SqlParameter("@Folio", folios)
        Utilidades.ParametersX_Global(1) = New SqlClient.SqlParameter("@Cve_Cliente", CbxClientes.SelectedValue)

        dt_conceptos = Utilidades.llenar_dt("pFACTURACION_CAPTURA_EGRESOS_CONCEPTOS", Utilidades.ParametersX_Global)
        DGVConceptos.Rows.Clear()
        For i As Integer = 0 To dt_conceptos.Rows.Count - 1
            If RbDescuentoVisible.Checked = True Then
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
                filaNueva(cDescuento.Name).Value = Round(dt_conceptos.Rows(i).Item("Descuento_Total"), 0)
                filaNueva(cNoIdentificacion.Name).Value = split(0).Trim
                'DGVConceptos.Rows.Add(filaNueva)
            Else
                DGVConceptos.Rows.Insert(DGVConceptos.Rows.Count)
                Dim filaNueva = DGVConceptos.Rows(DGVConceptos.Rows.Count - 1)
                'Dim parametros As String()
                'ReDim parametros(7)
                Dim split As String() = dt_conceptos.Rows(i).Item("Producto").split("-")
                filaNueva(cCantidad.Name).Value = dt_conceptos.Rows(i).Item("Cantidad")
                filaNueva(cbClaveProdServ.Name).Value = "84111506 - Servicios de facturación"
                filaNueva(cbClaveUnidad.Name).Value = "E48"
                filaNueva(cDescripcion.Name).Value = split(1).Trim
                filaNueva(cValorUnitario.Name).Value = Round(dt_conceptos.Rows(i).Item("Descuento_Unitario"), 4)
                filaNueva(cImporte.Name).Value = Round(dt_conceptos.Rows(i).Item("Descuento_Aplicado"), 4)
                filaNueva(cDescuento.Name).Value = 0
                filaNueva(cNoIdentificacion.Name).Value = split(0).Trim
            End If


            'TfBTotal.Text += Decimal.Parse(dt_conceptos.Rows(i).Item(3))
        Next
        For i As Integer = 0 To dt_conceptos.Rows.Count - 1
            If RbDescuentoVisible.Checked = True Then
                total += Round(dt_conceptos.Rows(i).Item("Unitario"), 4)

            Else
                total += Round(dt_conceptos.Rows(i).Item("Descuento_Unitario"), 4)
            End If
        Next
        Dim DESCUENTOX As Double
        'DESCUENTOX = (descuento * 100 / total) / 100
        For I As Integer = 0 To DGVConceptos.Rows.Count - 1
            'DESCUENTOX = descuento + DGVConceptos.Rows(I).Cells("cDescuento").Value
            DESCUENTOX += DGVConceptos.Rows(I).Cells("cDescuento").Value

            'DGVConceptos.Rows(I).Cells("cDescuento").Value = Round((DGVConceptos.Rows(I).Cells("cImporte").Value * DESCUENTOX), 2)
        Next
        'DESCUENTOX = DESCUENTOX + descuento
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
        If DGVConceptos.Rows.Count > 1 Then
            'CBSMetodoPago.SelectedValue = "PPD"
        End If

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

    Sub CargarParent()
        Try
            If DGV_Receptor.Rows.Count > 0 Then
                For i = 0 To DGV_Receptor.Rows.Count - 1
                    If DGV_Receptor.Item("colTIPO_PARENT", i).Value = "HIJO" Then
                        DGV_Receptor.Rows(i).ParentRow = DGV_Receptor.Rows(i - 1)
                        DGV_Receptor.Rows(i)(0).Style.ColSpan = DGV_Receptor.Columns.GetColumnCount(DataGridViewElementStates.None) - 1
                        DGV_Receptor.Rows(i - 1).Collapse()

                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DGV_Receptor_RowExpanded(sender As Object, e As DataGridViewRowEventArgs) Handles DGV_Receptor.RowExpanded


        If DGV_Receptor.Rows(e.RowIndex + 1).Cells(0).Control Is Nothing Then
            Dim miGrilla As DataGridView
            miGrilla = Utilidades.ClonarDGV(DGV_Facturas)
            miGrilla.DataSource = CargarPagosRelacionados(DGV_Receptor.Item("colRFC", e.RowIndex).Value)
            miGrilla.Visible = True
            miGrilla.AutoGenerateColumns = False
            DGV_Receptor.Rows(e.RowIndex + 1).Cells(0).Style.Padding = New Padding(30, 1, 0, 0)
            DGV_Receptor.Rows(e.RowIndex + 1).Cells(0).Control = miGrilla
            miGrilla.Dock = Dock.Fill
            AddHandler miGrilla.CellClick, AddressOf DataGridView1_CellClick
            miGrilla.ScrollBars = ScrollBars.Horizontal
            Dim minH As Integer = (20 * (miGrilla.Rows.Count)) + 20 + 30
            minH = IIf(minH > 280, 280, minH)
            miGrilla.MinimumSize = New Drawing.Size(1020, minH)
            DGV_Receptor.Rows(e.RowIndex + 1).MinimumHeight = minH
            DGV_Receptor.Rows(e.RowIndex + 1).ReadOnly = False
            miGrilla.Columns(cCHK.Index).Width = 35
        End If

        Dim ControlGrilla As DataGridView = DGV_Receptor.Rows(e.RowIndex + 1).Cells(0).Control
        If ControlGrilla IsNot Nothing Then
            If DGV_Receptor.Item(cCheckPadre.Index, e.RowIndex).Value Then
                For i = 0 To ControlGrilla.Rows.Count - 1
                    ControlGrilla.Item(cCHK.Index, i).Value = 1
                    DataGridView1_CellClick(ControlGrilla, 0)
                Next
            Else
                For i = 0 To ControlGrilla.Rows.Count - 1
                    ControlGrilla.Item(cCHK.Index, i).Value = 0
                    DataGridView1_CellClick(ControlGrilla, 0)
                Next
            End If
        End If


    End Sub

    Private Function CargarPagosRelacionados(ByVal RFC As String)
        Dim DataSetFacturas = New DataSet_pFACTURACION_CAPTURA_EGRESOS
        Dim BSFacturas As New BindingSource
        DataSetFacturas.EnforceConstraints = False

        Try
            Dim myDA = New SqlClient.SqlDataAdapter("dbo.pFACTURACION_CAPTURA_EGRESOS", Utilidades.sConexion)
            myDA.SelectCommand.CommandType = CommandType.StoredProcedure
            myDA.SelectCommand.Parameters.AddWithValue("@Fecha1", Format(Me.cFecha1.Value, "yyyyMMdd"))
            myDA.SelectCommand.Parameters.AddWithValue("@Fecha2", Format(Me.cFecha2.Value, "yyyyMMdd"))
            myDA.SelectCommand.Parameters.AddWithValue("@Cve_Cliente", CbxClientes.SelectedValue)
            myDA.SelectCommand.Parameters.AddWithValue("@Folio_Movimiento", "NA")
            myDA.SelectCommand.Parameters.AddWithValue("@AplicaSaldo", Chk_SaldoPendiente.Checked)
            'If CbxReceptor.SelectedIndex <> -1 Then
            myDA.SelectCommand.Parameters.AddWithValue("@RFC", RFC)
            'End If
            myDA.Fill(DataSetFacturas.Tables(0))
            myDA.Dispose()
            BSFacturas.DataSource = DataSetFacturas
            BSFacturas.DataMember = DataSetFacturas.Tables(0).TableName
        Catch ex As Exception

        End Try
        Return BSFacturas
    End Function
    Private Sub Chk_SaldoPendiente_CheckedChanged(sender As Object, e As EventArgs) Handles Chk_SaldoPendiente.CheckedChanged
        If CbxClientes.SelectedIndex <> -1 Then
            Consultar(CbxClientes.SelectedValue)
        Else
            Consultar()
        End If
    End Sub


End Class