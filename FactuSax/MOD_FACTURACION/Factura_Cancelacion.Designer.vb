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
        Dim DataGridViewCellStyle3 As Wisej.Web.DataGridViewCellStyle = New Wisej.Web.DataGridViewCellStyle()
        Me.RibbonBar1 = New Wisej.Web.Ext.RibbonBar.RibbonBar()
        Me.Panel1 = New Wisej.Web.Panel()
        Me.UUID_RELACIONADO = New Wisej.Web.TextBox()
        Me.Button1 = New Wisej.Web.Button()
        Me.Button2 = New Wisej.Web.Button()
        Me.CbxMotivoCancelacion = New FactuSax.ComboWisax()
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
        Me.Button3 = New Wisej.Web.Button()
        Me.Panel1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_pFACTURA_SAT_CFDI_B21, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonBar1
        '
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Size = New System.Drawing.Size(738, 110)
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Button3)
        Me.Panel1.Controls.Add(Me.UUID_RELACIONADO)
        Me.Panel1.Controls.Add(Me.Button1)
        Me.Panel1.Controls.Add(Me.Button2)
        Me.Panel1.Controls.Add(Me.CbxMotivoCancelacion)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = Wisej.Web.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 110)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(738, 100)
        Me.Panel1.TabIndex = 2
        Me.Panel1.TabStop = True
        '
        'UUID_RELACIONADO
        '
        Me.UUID_RELACIONADO.Location = New System.Drawing.Point(195, 54)
        Me.UUID_RELACIONADO.Name = "UUID_RELACIONADO"
        Me.UUID_RELACIONADO.Size = New System.Drawing.Size(282, 22)
        Me.UUID_RELACIONADO.TabIndex = 9
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(504, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(100, 27)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Consultar"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(610, 16)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 27)
        Me.Button2.TabIndex = 6
        Me.Button2.Text = "Cancelar"
        '
        'CbxMotivoCancelacion
        '
        Me.CbxMotivoCancelacion.Location = New System.Drawing.Point(187, 24)
        Me.CbxMotivoCancelacion.Name = "CbxMotivoCancelacion"
        Me.CbxMotivoCancelacion.TabIndex = 4
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(48, 28)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(133, 15)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Motivo de cancelación"
        '
        'DataGridView1
        '
        Me.DataGridView1.BorderStyle = Wisej.Web.BorderStyle.None
        DataGridViewCellStyle3.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.WrapMode = Wisej.Web.DataGridViewTriState.[True]
        Me.DataGridView1.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.Column0, Me.colUUID, Me.colFecha, Me.colTipodecomprobante, Me.colSubtotal, Me.colTotal, Me.colMoneda, Me.colFormapago, Me.colSerie, Me.colFolio, Me.colEmisor_Rfc, Me.colEmisor_Nombre, Me.colEmisro_Regimen_Fiscal, Me.colReceptor_RFC, Me.colReceptor_Usocfdi, Me.colReceptor_Nombnre, Me.colDescuento, Me.colTipocambio, Me.colCondicionespago, Me.colEstatus, Me.colMetodopago, Me.colLugarexpedicion, Me.colCadena_Original, Me.colNocertificado_Emisor, Me.colTipo_Relacion})
        Me.DataGridView1.DataSource = Me.BindingSource1
        Me.DataGridView1.Dock = Wisej.Web.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 210)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = Wisej.Web.DataGridViewSelectionMode.CellSelect
        Me.DataGridView1.Size = New System.Drawing.Size(738, 270)
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
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(504, 49)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(100, 27)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Buscar UUID"
        '
        'Factura_Cancelacion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(738, 480)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RibbonBar1)
        Me.Name = "Factura_Cancelacion"
        Me.Text = "Factura_Cancelacion"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Button2 As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents UUID_RELACIONADO As TextBox
    Friend WithEvents Button3 As Button
End Class
