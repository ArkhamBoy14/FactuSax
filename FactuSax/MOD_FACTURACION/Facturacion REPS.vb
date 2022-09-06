Imports System.Data
Imports System.Data.SqlClient

Public Class Facturacion_REPS
    'Dim Utilidades As New dllData
    Dim Seria_activa As Integer
    Dim clave As String = Application.Session("Cve_Cliente")
    Dim FOLIOS As String
    Dim SERIE As String
    Dim FOLIO As String
    Dim valor As String
    Dim contador As Integer
    Dim Alertas As New Notificaciones
    Private Sub Combosax2_Load(sender As Object, e As EventArgs) Handles Me.Load
        'serieX()
        TBMonto.Text = 0
        RBFecha.Checked = True
        Me.WindowState = FormWindowState.Maximized
        cFecha1.Value = Now
        cFecha2.Value = Now
        DTPFechaEmision.Value = Now()
        DTPFechaPago.Value = Now()


        ReDim Utilidades.ParametersX_Global(1)
        Utilidades.ParametersX_Global(0) = New SqlClient.SqlParameter("@Cve_Operador", Application.Session("Cve_Operador"))

        CBSTipoComprobante.LlenarListBox("pCAT_TIPOCOMPROBANTE_SAT_FACTURACION_B", "c_TipoDeComprobante", "DescripcionX")

        CBSFormaPago.LlenarListBox("pCAT_FORMAPAGO_SAT_FACTURACION_B", "c_Formapago", "DescripcionX")

        CBSMoneda.LlenarListBox("pCAT_MONEDA_SAT_FACTURACION_B", "c_Moneda", "DescripcionX")
        CBSBancoBeneficiario.LlenarListBox("pCAT_BANCOS_SAT_B", "Clave", "Clave")
        CBSBancoEmisor.LlenarListBox("pCAT_BANCOS_SAT_B", "Clave", "Clave")
        'Utilidades.LlenarListBox("pCAT_METODOPAGO_SAT_FACTURACION_B", "c_MetodoPago", "DescripcionX", CBSMetodoPago, , True)
        CbxClientes.LlenarListBox("pCAT_CLIENTES_B", "Cve_Cliente", "Nombre_Cliente", Utilidades.ParametersX_Global)
        CbxClientes.SelectedIndex = 0
        CBSMoneda.SelectedValue = "MXN"
        CBSTipoComprobante.SelectedValue = "P"
        'CBSFormaPago.SelectedValue = "01"
        CBEmisor.LlenarListBox("pCAT_RFC_EMISOR_SAT_FACTURACION_B", "RFC", "RFCX")
        SplitContainer1.Panel1MinSize = 340
        CBSReceptor.LlenarListBox("pCAT_RFC_RECEPTOR_SAT_FACTURACION_B", "RFC", "RFCX")
        Utilidades.ParametersX_Global(0) = New SqlClient.SqlParameter("@emisor_receptor", "RECEPTOR")
        CBSReceptor.SelectedIndex = 0
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
        Dim dt_defecto = CBEmisor.dataTable()
        For i As Integer = 0 To dt_defecto.Rows.Count - 1
            If dt_defecto.Rows(i).Item("pordefecto") = True Then
                CBEmisor.SelectedValue = dt_defecto.Rows(i).Item("RFC")
            End If
        Next
        If CBEmisor.SelectedIndex <> -1 Then
            'Dim datasetx = 
            Dim tabla_datos As DataTable = CBEmisor.dataTable
            MTBCP.Text = tabla_datos.Rows(0).Item("Codigo_Postal")
        End If
        serieX()
    End Sub
    Private Sub RibbonBar7_ButtonClick(sender As Object, e As Ext.RibbonBar.RibbonBarItemEventArgs) Handles RibbonBar7.ItemClick
        Select Case e.Item.Name
            Case RBBNuevo.Name
                'limpiar(True)
                CBSTipoComprobante.SelectedValue = "P"
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


    Private Sub CBSBancoEmisor_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBSBancoEmisor.SelectedIndexChanged, CBSBancoBeneficiario.SelectedIndexChanged
        Select Case sender.NAME
            Case "CBSBancoEmisor"
                TBBRFCancoE.Text = CBSBancoEmisor.ObtenerDescripcion("RFC")
            Case Else
                TBRFCbancoB.Text = CBSBancoBeneficiario.ObtenerDescripcion("RFC")
        End Select


    End Sub

    Private Sub CBSFormaPago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBSFormaPago.SelectedIndexChanged
        If CBSFormaPago.SelectedValue = "03" Then
            gbbANCOS.Visible = True
        Else
            gbbANCOS.Visible = False
        End If
    End Sub



    Sub CONSULTAR()

        Me.DataSet_pFACTURA_SAT_CFDI_PAGOS_B.Clear()

        Dim myDA = New SqlClient.SqlDataAdapter("pFACTURA_SAT_CFDI_PAGOS_B", Utilidades.sConexion)
        myDA.SelectCommand.CommandType = CommandType.StoredProcedure
        If RBFolio.Checked Then
            If InStr(RichTextBox1.Text, "-") Then
                myDA.SelectCommand.Parameters.AddWithValue("@Entre", 1)
                Dim split = RichTextBox1.Text.Split("-")
                myDA.SelectCommand.Parameters.AddWithValue("@Serei1", split(0))
                myDA.SelectCommand.Parameters.AddWithValue("@Serie2", split(1))
            ElseIf InStr(RichTextBox1.Text, ",") Then
                myDA.SelectCommand.Parameters.AddWithValue("@Series", RichTextBox1.Text)
            Else
                myDA.SelectCommand.Parameters.AddWithValue("@Serie", RichTextBox1.Text)
            End If
        End If

        myDA.SelectCommand.Parameters.AddWithValue("@Fecha1", Format(Me.cFecha1.Value, "yyyyMMdd"))
        myDA.SelectCommand.Parameters.AddWithValue("@Fecha2", Format(Me.cFecha2.Value, "yyyyMMdd"))
        If CbxReceptor.SelectedIndex <> -1 Then
            myDA.SelectCommand.Parameters.AddWithValue("@Cve_Receptor", CbxReceptor.SelectedValue)
        End If
        If CbxClientes.SelectedIndex <> -1 Then
            myDA.SelectCommand.Parameters.AddWithValue("@Cve_Cliente", CbxClientes.SelectedValue)
        End If
        myDA.Fill(Me.DataSet_pFACTURA_SAT_CFDI_PAGOS_B.pFACTURA_SAT_CFDI_PAGOS_B)
        myDA.Dispose()

    End Sub



    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RBFecha.CheckedChanged, RBFolio.CheckedChanged, RadioButton2.CheckedChanged, RadioButton1.CheckedChanged

        pserie.Visible = RBFolio.Checked
        pfECHA.Visible = RBFecha.Checked
        RichTextBox1.Text = Nothing

    End Sub



    Private Sub DGVUUID_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVUUID.CellClick
        'Dim FOLIOS As String = ""
        For i As Integer = 0 To DGVUUID.Rows.Count - 1
            If DGVUUID.Rows(i).Cells(0).Value = True Then
                FOLIOS += DGVUUID.Rows(i).Cells(2).Value & ","
            End If
        Next
        RTBObservaciones.Text = "COMPORBANTE DE PAGO DE LAS FACTURAS : " & FOLIOS
        ReDim Utilidades.ParametersX_Global(0)
        Utilidades.ParametersX_Global(0) = New SqlClient.SqlParameter("@UUID", FOLIOS)
        Dim DATATABLE_UUID As New DataTable
        DATATABLE_UUID = Utilidades.llenar_dt("[pFACTURA_SAT_CFDI_PAGOS_UUID_B]", Utilidades.ParametersX_Global)


        DGVConceptosUUID.DataSource = DATATABLE_UUID
        'DGVConceptosUUID.DataMember = DATATABLE_UUID

    End Sub

    Sub CREAR_XML()
        Dim splithora As String() = MTBHoraEmision.Text.Split(":")
        Dim fecha_factura As DateTime = New DateTime(DTPFechaEmision.Value.Year, DTPFechaEmision.Value.Month, DTPFechaEmision.Value.Day, splithora(0), splithora(1), "00")
        Dim splithorap As String() = MTBHoraPago.Text.Split(":")
        Dim FechaPago As DateTime = New DateTime(DTPFechaPago.Value.Year, DTPFechaPago.Value.Month, DTPFechaPago.Value.Day, splithorap(0), splithorap(1), "00")
        Dim monto As Integer
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
        cuerpo.Add("Tipo_comprobante", CBSTipoComprobante.SelectedValue)
        cuerpo.Add("Lugarexpedicion", MTBCP.Text)
        ''faltantes ------------------------------------
        cuerpo.Add("Foma_Pago", "NA")
        cuerpo.Add("Subtotal", "0")
        cuerpo.Add("Moneda", "XXX")
        cuerpo.Add("Metodo_pago", "NA")
        cuerpo.Add("Total", "0")
        'cuerpo.Add("Tipo_comprobante", "P")
        cuerpo.Add("Descuento", "0")
        cuerpo.Add("Condiciones_Pago", RTBObservaciones.Text)
        cuerpo.Add("Tipo_Cambio", "NA")
        cuerpo.Add("TipoRelacion", "NA")

        ''------------------------------------



        pagos_fac.Add("Forma_Pago", CBSFormaPago.SelectedValue)
        pagos_fac.Add("Moneda", CBSMoneda.SelectedValue)


        If gbbANCOS.Visible = True Then
            pagos_fac.Add("CtaBeneficiaro", TBCtabeneficiario.Text)
            'pagos_fac.Add("CtaOrdenate", TBCtaEmisro.Text)
            pagos_fac.Add("RfcEmisorCtaBen", TBRFCbancoB.Text)
            pagos_fac.Add("RfcEmisorCtaOrd", TBBRFCancoE.Text)

        Else
            pagos_fac.Add("CtaBeneficiaro", Nothing)
            pagos_fac.Add("CtaOrdenate", Nothing)
            pagos_fac.Add("RfcEmisorCtaBen", Nothing)
            pagos_fac.Add("RfcEmisorCtaOrd", Nothing)

        End If

        Dim lista_concepto As New Dictionary(Of String, Dictionary(Of String, String))
        For i As Integer = 0 To DGVConceptosUUID.Rows.Count - 1
            If IsDBNull(DGVConceptosUUID.Rows(i).Cells(colUUID_1).Value) Then Exit For
            monto += DGVConceptosUUID.Rows(i).Cells(colIMPORTE_PAGADO).Value
            Dim conceptosx As New Dictionary(Of String, String)
            conceptosx.Add("UUUID", DGVConceptosUUID.Rows(i).Cells(colUUID_1).Value)
            conceptosx.Add("FOLIO", DGVConceptosUUID.Rows(i).Cells(colFOLIO_1).Value)
            conceptosx.Add("IMPORTE_PAGADO", DGVConceptosUUID.Rows(i).Cells(colIMPORTE_PAGADO).Value)
            conceptosx.Add("SALDO_ANTERIOR", DGVConceptosUUID.Rows(i).Cells(colSALDO_ANTERIOR).Value)
            conceptosx.Add("SALDO_INSOLUTO", DGVConceptosUUID.Rows(i).Cells(colSALDO_INSOLUTO).Value)
            conceptosx.Add("METODOPAGO", DGVConceptosUUID.Rows(i).Cells(colMETODOPAGO).Value)
            conceptosx.Add("MONEDA", DGVConceptosUUID.Rows(i).Cells(colMONEDA).Value)
            conceptosx.Add("PARCIALIDAD", DGVConceptosUUID.Rows(i).Cells(colPARCIALIDAD).Value)
            conceptosx.Add("SERIE", DGVConceptosUUID.Rows(i).Cells(colSERIE).Value)
            lista_concepto.Add(DGVConceptosUUID.Rows(i).Cells(colPARCIALIDAD).Value, conceptosx)
        Next
        pagos_fac.Add("Monto", monto)
        Dim FACTURAX As New Factura

        Dim respuesta = FACTURAX.factura_pagos_html(emisor, receptor, cuerpo, cer, llave, claveprivada, clave, fecha_factura, pagos_fac, lista_concepto, FechaPago, RTBObservaciones.Text)




        If respuesta <> Nothing Then
            Dim split As String() = respuesta.Split("-")

            Application.Session("DocumentCached") = Nothing
            Application.Session("ReportName") = "R_Representacion_Fisica_CFDi33_Pagos"
            Application.Session("Modulo") = "DocumentViewer.aspx"
            Dim asp As New Mostrar_Asp
            asp.Actualizar()
            asp.Show()
        End If
        contador = 0
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
        For i As Integer = 0 To DGVConceptosUUID.Rows.Count - 1
            If DGVConceptosUUID.Rows(0).Cells(colIMPORTE_PAGADO).Value = 0 Then
                MessageBox.Show("El Importe pagado no puede ser 0")
                Return False
            End If

        Next
        For i As Integer = 0 To DGVConceptosUUID.Rows.Count - 1
            total += DGVConceptosUUID.Rows(0).Cells(colSALDO_INSOLUTO).Value

        Next
        If total < 0 Then
            MessageBox.Show("El monto es mayor que el saldo adeudado")
            total = ""
            Return False
        End If
        If CBSReceptor.SelectedIndex = -1 Then
            ErrorProvider1.SetError(CBSReceptor, "Seleccione un Emisor")
            Return False
        End If
        If CBSFormaPago.SelectedIndex = -1 Then
            ErrorProvider1.SetError(CBSFormaPago, "Seleccione una forma de Pago")
            Alertas.NotificacionAdvertencia("Seleccione una forma de pago")
            Return False
        End If
        total = ""

        Return True
    End Function

    Sub limpiar()
        DGVConceptosUUID.DataSource = Nothing
        Me.DataSet_pFACTURA_SAT_CFDI_PAGOS_B.Clear()
        TBMonto.Text = 0
        CBSBancoEmisor.SelectedIndex = -1
        RichTextBox1.Text = Nothing
        FOLIOS = ""
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

    Private Sub DGVConceptosUUID_CellValueChanged(sender As Object, e As DataGridViewCellEventArgs) Handles DGVConceptosUUID.CellValueChanged
        If DGVConceptosUUID.Columns(colIMPORTE_PAGADO.Index).Index = e.ColumnIndex Then
            Try
                DGVConceptosUUID.Rows(e.RowIndex + 1).Cells(colIMPORTE_PAGADO).Value = valor - DGVConceptosUUID.Rows(e.RowIndex).Cells(colIMPORTE_PAGADO).Value
                valor = valor - DGVConceptosUUID.Rows(e.RowIndex).Cells(colIMPORTE_PAGADO).Value
                DGVConceptosUUID.Rows(e.RowIndex + 1).Cells(colIMPORTE_PAGADO).Value = valor
            Catch ex As Exception

            End Try


        End If
    End Sub
    Private Sub DGVConceptosUUID_Cellleave(sender As Object, e As DataGridViewCellEventArgs) Handles DGVConceptosUUID.CellLeave
        If DGVConceptosUUID.Rows.Count <> 0 Then

            For i As Integer = 0 To DGVConceptosUUID.Rows.Count - 1
                If DGVConceptosUUID.Rows(i).Cells(colIMPORTE_PAGADO).Value = "0" Then Exit For
                If DGVConceptosUUID.Rows(i).Cells(colSALDO_ANTERIOR).Value - DGVConceptosUUID.Rows(i).Cells(colIMPORTE_PAGADO).Value < 0 Then
                    MessageBox.Show("El Saldo anterior no puede ser menor que el importe pagado")
                Else

                    DGVConceptosUUID.Rows(i).Cells(colSALDO_INSOLUTO).Value = DGVConceptosUUID.Rows(i).Cells(colSALDO_ANTERIOR).Value - DGVConceptosUUID.Rows(i).Cells(colIMPORTE_PAGADO).Value
                End If

            Next

        End If



    End Sub

    Private Sub TBMonto_KeyDown(sender As Object, e As KeyEventArgs) Handles TBMonto.KeyDown
        If e.KeyCode = Keys.Enter Then
            If DGVConceptosUUID.Rows.Count = 1 Then

                If DGVConceptosUUID.Rows(0).Cells(colSALDO_ANTERIOR).Value - TBMonto.Text < 0 Then
                    MessageBox.Show("El monto es mayor que el saldo adeudado")
                    RBBFactura.Enabled = False
                Else

                    DGVConceptosUUID.Rows(0).Cells(colIMPORTE_PAGADO).Value = TBMonto.Text
                    DGVConceptosUUID.Rows(0).Cells(colSALDO_INSOLUTO).Value = DGVConceptosUUID.Rows(0).Cells(colSALDO_ANTERIOR).Value - TBMonto.Text
                    RBBFactura.Enabled = True
                End If
            Else
                valor = TBMonto.Text
            End If
        End If
    End Sub


    Private Sub CbxClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxClientes.SelectedIndexChanged
        Application.Session("Facturauser") = CbxClientes.ObtenerDescripcion("FACTORUM_USER")
        Application.Session("FacturaContrasena") = CbxClientes.ObtenerDescripcion("ContrasenaFact")
        Application.Session("Cve_Cliente") = CbxClientes.ObtenerDescripcion("Cve_Cliente")
        ReDim Utilidades.ParametersX_Global(0)
        Utilidades.ParametersX_Global(0) = New SqlClient.SqlParameter("@Cve_Cliente", CbxClientes.ObtenerDescripcion("Cve_Cliente"))
        CbxReceptor.LlenarListBox("pFACTURACION_RECEPTOR", "Cve_Receptor", "ReceptorX", Utilidades.ParametersX_Global)
        CONSULTAR()
        'limpiar()
        serieX()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles BtnAnexarPago.Click
        contador += 1
        If contador = 1 Then
            If DGVConceptosUUID.Rows(contador - 1).Cells("colSALDO_ANTERIOR").Value - TBMonto.Text < 0 Then
                MessageBox.Show("El monto es mayor que el saldo adeudado")
                RBBFactura.Enabled = False
                contador = 0
            Else
                DGVConceptosUUID.Rows(contador - 1).Cells("colIMPORTE_PAGADO").Value = TBMonto.Text
                DGVConceptosUUID.Rows(contador - 1).Cells("colSALDO_INSOLUTO").Value = DGVConceptosUUID.Rows(0).Cells("colSALDO_ANTERIOR").Value - TBMonto.Text
                RBBFactura.Enabled = True
                TBMonto.Text = 0
            End If
        ElseIf contador > 1 Then
            Try
                Dim DT As New DataTable
                DT = DGVConceptosUUID.DataSource
                Dim FILA As DataRow
                FILA = DT.NewRow

                For i As Integer = DT.Rows.Count - 1 To 0 Step -1
                    For x As Integer = 0 To DT.Columns.Count - 1

                        Select Case DT.Columns(x).ColumnName
                            Case "SALDO_ANTERIOR"
                                FILA(x) = DT.Rows(i).Item("SALDO_INSOLUTO")
                                If DT.Rows(i).Item("SALDO_INSOLUTO") - TBMonto.Text < 0 Then
                                    MessageBox.Show("El monto es mayor que el saldo adeudado")
                                    Exit Sub
                                End If
                            Case "IMPORTE_PAGADO"
                                FILA(x) = TBMonto.Text
                            Case "SALDO_INSOLUTO"
                                FILA(x) = DT.Rows(i).Item(x) - TBMonto.Text
                            Case "PARCIALIDAD"
                                FILA(x) = DT.Rows(i).Item(x) + 1
                            Case Else
                                FILA(x) = DT.Rows(i).Item(x)
                        End Select
                    Next
                    DT.Rows.Add(FILA)
                    TBMonto.Text = 0
                    Exit For
                Next


                DGVConceptosUUID.DataSource = DT


            Catch ex As Exception

            End Try
        End If

    End Sub
End Class
