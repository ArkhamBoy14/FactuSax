<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Factura_Cancelacion
    Inherits Wisej.Web.Form

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Wisej Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Wisej Designer
    'It can be modified using the Wisej Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.RibbonBar1 = New Wisej.Web.Ext.RibbonBar.RibbonBar()
        Me.RibbonBarPage1 = New Wisej.Web.Ext.RibbonBar.RibbonBarPage()
        Me.RibbonBarGroup1 = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.RBBConsultar = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBBCancelar = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBBSalir = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.Panel1 = New Wisej.Web.Panel()
        Me.Label2 = New Wisej.Web.Label()
        Me.Label18 = New Wisej.Web.Label()
        Me.UUID_RELACIONADO = New Wisej.Web.TextBox()
        Me.cFecha1 = New Wisej.Web.DateTimePicker()
        Me.cFecha2 = New Wisej.Web.DateTimePicker()
        Me.Label19 = New Wisej.Web.Label()
        Me.Label1 = New Wisej.Web.Label()
        Me.DataGridView1 = New Wisej.Web.DataGridView()
        Me.Column0 = New Wisej.Web.DataGridViewCheckBoxColumn()
        Me.colUUID = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colFecha = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colTipodecomprobante = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colSubtotal = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colTotal = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colMoneda = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colFormapago = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colSerie = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colFolio = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colEmisor_Rfc = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colEmisor_Nombre = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colEmisro_Regimen_Fiscal = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colReceptor_RFC = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colReceptor_Usocfdi = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colReceptor_Nombnre = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colDescuento = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colTipocambio = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colCondicionespago = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colEstatus = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colMetodopago = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colLugarexpedicion = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colCadena_Original = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colNocertificado_Emisor = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colTipo_Relacion = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.BindingSource1 = New Wisej.Web.BindingSource(Me.components)
        Me.DataSet_pFACTURA_SAT_CFDI_B21 = New FactuSax.DataSet_pFACTURA_SAT_CFDI_B2()
        Me.PFACTURA_SAT_CFDI_B2TableAdapter = New FactuSax.DataSet_pFACTURA_SAT_CFDI_B2TableAdapters.pFACTURA_SAT_CFDI_B2TableAdapter()
        Me.RBBEstatus = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.FiltroGrillaSax1 = New FactuSax.filtroGrillaSax()
        Me.CbxMotivoCancelacion = New FactuSax.ComboWisax()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataGridView1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_pFACTURA_SAT_CFDI_B21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonBar1
        '
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Pages.Add(Me.RibbonBarPage1)
        Me.RibbonBar1.Size = New System.Drawing.Size(831, 110)
        '
        'RibbonBarPage1
        '
        Me.RibbonBarPage1.Groups.Add(Me.RibbonBarGroup1)
        Me.RibbonBarPage1.Name = "RibbonBarPage1"
        Me.RibbonBarPage1.Text = "Menu"
        '
        'RibbonBarGroup1
        '
        Me.RibbonBarGroup1.Items.Add(Me.RBBConsultar)
        Me.RibbonBarGroup1.Items.Add(Me.RBBEstatus)
        Me.RibbonBarGroup1.Items.Add(Me.RBBCancelar)
        Me.RibbonBarGroup1.Items.Add(Me.RBBSalir)
        Me.RibbonBarGroup1.Name = "RibbonBarGroup1"
        Me.RibbonBarGroup1.Text = "Procesos"
        '
        'RBBConsultar
        '
        Me.RBBConsultar.ImageSource = "Resources\Images\Menu\64\busqueda_facturas.png"
        Me.RBBConsultar.Name = "RBBConsultar"
        Me.RBBConsultar.Text = "Consultar"
        '
        'RBBCancelar
        '
        Me.RBBCancelar.ImageSource = "Resources\Images\Menu\64\cancelar_factura.png"
        Me.RBBCancelar.Name = "RBBCancelar"
        Me.RBBCancelar.Text = "Cancelar"
        '
        'RBBSalir
        '
        Me.RBBSalir.ImageSource = "Resources\Images\Menu\64\exit_sign.png"
        Me.RBBSalir.Name = "RBBSalir"
        Me.RBBSalir.Text = "Salir"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Controls.Add(Me.UUID_RELACIONADO)
        Me.Panel1.Controls.Add(Me.cFecha1)
        Me.Panel1.Controls.Add(Me.cFecha2)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.CbxMotivoCancelacion)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = Wisej.Web.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 110)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(831, 157)
        Me.Panel1.TabIndex = 2
        Me.Panel1.TabStop = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(36, 15)
        Me.Label2.TabIndex = 11
        Me.Label2.Text = "UUID"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(21, 13)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(35, 15)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "Inicio"
        '
        'UUID_RELACIONADO
        '
        Me.UUID_RELACIONADO.Location = New System.Drawing.Point(20, 121)
        Me.UUID_RELACIONADO.Name = "UUID_RELACIONADO"
        Me.UUID_RELACIONADO.Size = New System.Drawing.Size(290, 22)
        Me.UUID_RELACIONADO.TabIndex = 9
        '
        'cFecha1
        '
        Me.cFecha1.CustomFormat = "dd/MM/yyyy"
        Me.cFecha1.Format = Wisej.Web.DateTimePickerFormat.Custom
        Me.cFecha1.Location = New System.Drawing.Point(20, 34)
        Me.cFecha1.Name = "cFecha1"
        Me.cFecha1.Size = New System.Drawing.Size(103, 22)
        Me.cFecha1.TabIndex = 7
        Me.cFecha1.Value = New Date(2010, 5, 4, 18, 20, 0, 0)
        '
        'cFecha2
        '
        Me.cFecha2.CustomFormat = "dd/MM/yyyy"
        Me.cFecha2.Format = Wisej.Web.DateTimePickerFormat.Custom
        Me.cFecha2.Location = New System.Drawing.Point(207, 34)
        Me.cFecha2.Name = "cFecha2"
        Me.cFecha2.Size = New System.Drawing.Size(103, 22)
        Me.cFecha2.TabIndex = 8
        Me.cFecha2.Value = New Date(2010, 5, 4, 18, 20, 0, 0)
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(207, 13)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(23, 15)
        Me.Label19.TabIndex = 10
        Me.Label19.Text = "Fin"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Motivo de cancelación"
        '
        'DataGridView1
        '
        Me.DataGridView1.BorderStyle = Wisej.Web.BorderStyle.None
        Me.DataGridView1.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.Column0, Me.colUUID, Me.colFecha, Me.colTipodecomprobante, Me.colSubtotal, Me.colTotal, Me.colMoneda, Me.colFormapago, Me.colSerie, Me.colFolio, Me.colEmisor_Rfc, Me.colEmisor_Nombre, Me.colEmisro_Regimen_Fiscal, Me.colReceptor_RFC, Me.colReceptor_Usocfdi, Me.colReceptor_Nombnre, Me.colDescuento, Me.colTipocambio, Me.colCondicionespago, Me.colEstatus, Me.colMetodopago, Me.colLugarexpedicion, Me.colCadena_Original, Me.colNocertificado_Emisor, Me.colTipo_Relacion})
        Me.DataGridView1.Controls.Add(Me.FiltroGrillaSax1)
        Me.DataGridView1.DataSource = Me.BindingSource1
        Me.DataGridView1.Dock = Wisej.Web.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 267)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = Wisej.Web.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(831, 213)
        Me.DataGridView1.TabIndex = 5
        '
        'Column0
        '
        Me.Column0.HeaderText = "   "
        Me.Column0.Name = "Column0"
        '
        'colUUID
        '
        Me.colUUID.DataPropertyName = "UUID"
        Me.colUUID.HeaderText = "UUID"
        Me.colUUID.Name = "colUUID"
        '
        'colFecha
        '
        Me.colFecha.DataPropertyName = "Fecha"
        Me.colFecha.HeaderText = "Fecha"
        Me.colFecha.Name = "colFecha"
        '
        'colTipodecomprobante
        '
        Me.colTipodecomprobante.DataPropertyName = "TipodeComprobante"
        Me.colTipodecomprobante.HeaderText = "TipodeComprobante"
        Me.colTipodecomprobante.Name = "colTipodecomprobante"
        '
        'colSubtotal
        '
        Me.colSubtotal.DataPropertyName = "Subtotal"
        Me.colSubtotal.HeaderText = "Subtotal"
        Me.colSubtotal.Name = "colSubtotal"
        '
        'colTotal
        '
        Me.colTotal.DataPropertyName = "Total"
        Me.colTotal.HeaderText = "Total"
        Me.colTotal.Name = "colTotal"
        '
        'colMoneda
        '
        Me.colMoneda.DataPropertyName = "Moneda"
        Me.colMoneda.HeaderText = "Moneda"
        Me.colMoneda.Name = "colMoneda"
        '
        'colFormapago
        '
        Me.colFormapago.DataPropertyName = "FormaPago"
        Me.colFormapago.HeaderText = "FormaPago"
        Me.colFormapago.Name = "colFormapago"
        '
        'colSerie
        '
        Me.colSerie.DataPropertyName = "Serie"
        Me.colSerie.HeaderText = "Serie"
        Me.colSerie.Name = "colSerie"
        '
        'colFolio
        '
        Me.colFolio.DataPropertyName = "Folio"
        Me.colFolio.HeaderText = "Folio"
        Me.colFolio.Name = "colFolio"
        '
        'colEmisor_Rfc
        '
        Me.colEmisor_Rfc.DataPropertyName = "Emisor_Rfc"
        Me.colEmisor_Rfc.HeaderText = "Emisor_Rfc"
        Me.colEmisor_Rfc.Name = "colEmisor_Rfc"
        '
        'colEmisor_Nombre
        '
        Me.colEmisor_Nombre.DataPropertyName = "Emisor_Nombre"
        Me.colEmisor_Nombre.HeaderText = "Emisor_Nombre"
        Me.colEmisor_Nombre.Name = "colEmisor_Nombre"
        '
        'colEmisro_Regimen_Fiscal
        '
        Me.colEmisro_Regimen_Fiscal.DataPropertyName = "Emisro_Regimen_Fiscal"
        Me.colEmisro_Regimen_Fiscal.HeaderText = "Emisro_Regimen_Fiscal"
        Me.colEmisro_Regimen_Fiscal.Name = "colEmisro_Regimen_Fiscal"
        '
        'colReceptor_RFC
        '
        Me.colReceptor_RFC.DataPropertyName = "Receptor_RFC"
        Me.colReceptor_RFC.HeaderText = "Receptor_RFC"
        Me.colReceptor_RFC.Name = "colReceptor_RFC"
        '
        'colReceptor_Usocfdi
        '
        Me.colReceptor_Usocfdi.DataPropertyName = "receptor_UsoCFDI"
        Me.colReceptor_Usocfdi.HeaderText = "receptor_UsoCFDI"
        Me.colReceptor_Usocfdi.Name = "colReceptor_Usocfdi"
        '
        'colReceptor_Nombnre
        '
        Me.colReceptor_Nombnre.DataPropertyName = "Receptor_Nombnre"
        Me.colReceptor_Nombnre.HeaderText = "Receptor_Nombnre"
        Me.colReceptor_Nombnre.Name = "colReceptor_Nombnre"
        '
        'colDescuento
        '
        Me.colDescuento.DataPropertyName = "Descuento"
        Me.colDescuento.HeaderText = "Descuento"
        Me.colDescuento.Name = "colDescuento"
        '
        'colTipocambio
        '
        Me.colTipocambio.DataPropertyName = "TipoCambio"
        Me.colTipocambio.HeaderText = "TipoCambio"
        Me.colTipocambio.Name = "colTipocambio"
        '
        'colCondicionespago
        '
        Me.colCondicionespago.DataPropertyName = "CondicionesPago"
        Me.colCondicionespago.HeaderText = "CondicionesPago"
        Me.colCondicionespago.Name = "colCondicionespago"
        '
        'colEstatus
        '
        Me.colEstatus.DataPropertyName = "Estatus"
        Me.colEstatus.HeaderText = "Estatus"
        Me.colEstatus.Name = "colEstatus"
        '
        'colMetodopago
        '
        Me.colMetodopago.DataPropertyName = "MetodoPago"
        Me.colMetodopago.HeaderText = "MetodoPago"
        Me.colMetodopago.Name = "colMetodopago"
        '
        'colLugarexpedicion
        '
        Me.colLugarexpedicion.DataPropertyName = "LugarExpedicion"
        Me.colLugarexpedicion.HeaderText = "LugarExpedicion"
        Me.colLugarexpedicion.Name = "colLugarexpedicion"
        '
        'colCadena_Original
        '
        Me.colCadena_Original.DataPropertyName = "Cadena_Original"
        Me.colCadena_Original.HeaderText = "Cadena_Original"
        Me.colCadena_Original.Name = "colCadena_Original"
        '
        'colNocertificado_Emisor
        '
        Me.colNocertificado_Emisor.DataPropertyName = "NoCertificado_Emisor"
        Me.colNocertificado_Emisor.HeaderText = "NoCertificado_Emisor"
        Me.colNocertificado_Emisor.Name = "colNocertificado_Emisor"
        '
        'colTipo_Relacion
        '
        Me.colTipo_Relacion.DataPropertyName = "Tipo_Relacion"
        Me.colTipo_Relacion.HeaderText = "Tipo_Relacion"
        Me.colTipo_Relacion.Name = "colTipo_Relacion"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "pFACTURA_SAT_CFDI_B2"
        Me.BindingSource1.DataSource = Me.DataSet_pFACTURA_SAT_CFDI_B21
        '
        'DataSet_pFACTURA_SAT_CFDI_B21
        '
        Me.DataSet_pFACTURA_SAT_CFDI_B21.DataSetName = "DataSet_pFACTURA_SAT_CFDI_B2"
        Me.DataSet_pFACTURA_SAT_CFDI_B21.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PFACTURA_SAT_CFDI_B2TableAdapter
        '
        Me.PFACTURA_SAT_CFDI_B2TableAdapter.ClearBeforeFill = True
        '
        'RBBEstatus
        '
        Me.RBBEstatus.ImageSource = "Resources\Images\Menu\64\factura_pagos.png"
        Me.RBBEstatus.Name = "RBBEstatus"
        Me.RBBEstatus.Text = "Consultar Estatus"
        '
        'FiltroGrillaSax1
        '
        Me.FiltroGrillaSax1.Dock = Wisej.Web.DockStyle.Top
        Me.FiltroGrillaSax1.Name = "FiltroGrillaSax1"
        Me.FiltroGrillaSax1.Size = New System.Drawing.Size(831, 30)
        Me.FiltroGrillaSax1.TabIndex = 0
        '
        'CbxMotivoCancelacion
        '
        Me.CbxMotivoCancelacion.Location = New System.Drawing.Point(20, 79)
        Me.CbxMotivoCancelacion.Name = "CbxMotivoCancelacion"
        Me.CbxMotivoCancelacion.TabIndex = 4
        '
        'Factura_Cancelacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(831, 480)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RibbonBar1)
        Me.Name = "Factura_Cancelacion"
        Me.Text = "Factura_Cancelacion"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataGridView1.ResumeLayout(False)
        Me.DataGridView1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_pFACTURA_SAT_CFDI_B21, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RibbonBar1 As Ext.RibbonBar.RibbonBar
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents CbxMotivoCancelacion As ComboWisax
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents DataSet_pFACTURA_SAT_CFDI_B21 As DataSet_pFACTURA_SAT_CFDI_B2
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents PFACTURA_SAT_CFDI_B2TableAdapter As DataSet_pFACTURA_SAT_CFDI_B2TableAdapters.pFACTURA_SAT_CFDI_B2TableAdapter
    Friend WithEvents colUUID As DataGridViewTextBoxColumn
    Friend WithEvents colFecha As DataGridViewTextBoxColumn
    Friend WithEvents colTipodecomprobante As DataGridViewTextBoxColumn
    Friend WithEvents colSubtotal As DataGridViewTextBoxColumn
    Friend WithEvents colTotal As DataGridViewTextBoxColumn
    Friend WithEvents colMoneda As DataGridViewTextBoxColumn
    Friend WithEvents colFormapago As DataGridViewTextBoxColumn
    Friend WithEvents colSerie As DataGridViewTextBoxColumn
    Friend WithEvents colFolio As DataGridViewTextBoxColumn
    Friend WithEvents colEmisor_Rfc As DataGridViewTextBoxColumn
    Friend WithEvents colEmisor_Nombre As DataGridViewTextBoxColumn
    Friend WithEvents colEmisro_Regimen_Fiscal As DataGridViewTextBoxColumn
    Friend WithEvents colReceptor_RFC As DataGridViewTextBoxColumn
    Friend WithEvents colReceptor_Usocfdi As DataGridViewTextBoxColumn
    Friend WithEvents colReceptor_Nombnre As DataGridViewTextBoxColumn
    Friend WithEvents colDescuento As DataGridViewTextBoxColumn
    Friend WithEvents colTipocambio As DataGridViewTextBoxColumn
    Friend WithEvents colCondicionespago As DataGridViewTextBoxColumn
    Friend WithEvents colEstatus As DataGridViewTextBoxColumn
    Friend WithEvents colMetodopago As DataGridViewTextBoxColumn
    Friend WithEvents colLugarexpedicion As DataGridViewTextBoxColumn
    Friend WithEvents colCadena_Original As DataGridViewTextBoxColumn
    Friend WithEvents colNocertificado_Emisor As DataGridViewTextBoxColumn
    Friend WithEvents colTipo_Relacion As DataGridViewTextBoxColumn
    Friend WithEvents Column0 As DataGridViewCheckBoxColumn
    Friend WithEvents UUID_RELACIONADO As TextBox
    Friend WithEvents RibbonBarPage1 As Ext.RibbonBar.RibbonBarPage
    Friend WithEvents RibbonBarGroup1 As Ext.RibbonBar.RibbonBarGroup
    Friend WithEvents RBBSalir As Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents FiltroGrillaSax1 As filtroGrillaSax
    Friend WithEvents RBBConsultar As Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents RBBCancelar As Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents Label2 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents cFecha1 As DateTimePicker
    Friend WithEvents cFecha2 As DateTimePicker
    Friend WithEvents Label19 As Label
    Friend WithEvents RBBEstatus As Ext.RibbonBar.RibbonBarItemButton
End Class
