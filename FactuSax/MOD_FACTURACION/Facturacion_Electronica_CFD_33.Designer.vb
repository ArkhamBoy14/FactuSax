
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Facturacion_Electronica_CFD_33
    Inherits Wisej.Web.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Visual WebGui Designer
    Private Shadows components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Visual WebGui Designer
    'It can be modified using the Visual WebGui Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle1 As Wisej.Web.DataGridViewCellStyle = New Wisej.Web.DataGridViewCellStyle()
        Me.RibbonBar7 = New Wisej.Web.Ext.RibbonBar.RibbonBar()
        Me.RibbonBarPage1 = New Wisej.Web.Ext.RibbonBar.RibbonBarPage()
        Me.RibbonBarGroup1 = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.RBBNuevo = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBBBuscar = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBBPFacturar = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBBSerie = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBBSalir = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.SplitContainer1 = New Wisej.Web.SplitContainer()
        Me.DataGridView1 = New Wisej.Web.DataGridView()
        Me.cCHK = New Wisej.Web.DataGridViewCheckBoxColumn()
        Me.cFolio = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.Descuento_Factura = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.Descuento = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.Estatus = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.cSaldo = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.cImporteTotal = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.cFolio_Movimiento = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.cUnitario = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.CheckBox1 = New Wisej.Web.CheckBox()
        Me.BindingSource1 = New Wisej.Web.BindingSource(Me.components)
        Me.DataSet_pFACTURACION_CAPTURA_EGRESOS1 = New FactuSax.DataSet_pFACTURACION_CAPTURA_EGRESOS()
        Me.grpPersonalizado = New Wisej.Web.GroupBox()
        Me.Label2 = New Wisej.Web.Label()
        Me.CbxReceptor = New FactuSax.ComboWisax()
        Me.RB_Detallada = New Wisej.Web.RadioButton()
        Me.RB_Sencilla = New Wisej.Web.RadioButton()
        Me.Label1 = New Wisej.Web.Label()
        Me.CbxClientes = New FactuSax.ComboWisax()
        Me.Label18 = New Wisej.Web.Label()
        Me.cFecha1 = New Wisej.Web.DateTimePicker()
        Me.cFecha2 = New Wisej.Web.DateTimePicker()
        Me.Label19 = New Wisej.Web.Label()
        Me.SplitContainer3 = New Wisej.Web.SplitContainer()
        Me.TabControl1 = New Wisej.Web.TabControl()
        Me.TPCONCEPTO = New Wisej.Web.TabPage()
        Me.DGVConceptos = New Wisej.Web.DataGridView()
        Me.dgvEliminar = New Wisej.Web.DataGridViewImageColumn()
        Me.cCantidad = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.cbClaveProdServ = New Wisej.Web.DataGridViewComboBoxColumn()
        Me.cbClaveUnidad = New Wisej.Web.DataGridViewComboBoxColumn()
        Me.cDescripcion = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.cValorUnitario = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.cImporte = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.cDescuento = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.cNoIdentificacion = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.Panel3 = New Wisej.Web.Panel()
        Me.Label33 = New Wisej.Web.Label()
        Me.TBDescuento = New Wisej.Web.TextBox()
        Me.TBTotal = New Wisej.Web.TextBox()
        Me.TBRISR = New Wisej.Web.TextBox()
        Me.TBRIVA = New Wisej.Web.TextBox()
        Me.TBIva = New Wisej.Web.TextBox()
        Me.TBSubTotal = New Wisej.Web.TextBox()
        Me.Label27 = New Wisej.Web.Label()
        Me.Label25 = New Wisej.Web.Label()
        Me.Label24 = New Wisej.Web.Label()
        Me.Label21 = New Wisej.Web.Label()
        Me.Label23 = New Wisej.Web.Label()
        Me.GroupBox2 = New Wisej.Web.GroupBox()
        Me.GBRetencionIVA = New Wisej.Web.GroupBox()
        Me.TasaoCuotaRIVA = New Wisej.Web.ComboBox()
        Me.Label14 = New Wisej.Web.Label()
        Me.MTBRISR = New Wisej.Web.MaskedTextBox()
        Me.Label15 = New Wisej.Web.Label()
        Me.Label16 = New Wisej.Web.Label()
        Me.CBSRIVA = New FactuSax.ComboWisax()
        Me.GBRetencionISR = New Wisej.Web.GroupBox()
        Me.TasaoCuotaISR = New Wisej.Web.ComboBox()
        Me.Label11 = New Wisej.Web.Label()
        Me.CBSRISR = New FactuSax.ComboWisax()
        Me.Label13 = New Wisej.Web.Label()
        Me.Label12 = New Wisej.Web.Label()
        Me.MTBRIVA = New Wisej.Web.MaskedTextBox()
        Me.GBIVA = New Wisej.Web.GroupBox()
        Me.TasaoCuotaIVA = New Wisej.Web.ComboBox()
        Me.MTBIVA = New Wisej.Web.MaskedTextBox()
        Me.Label10 = New Wisej.Web.Label()
        Me.Label9 = New Wisej.Web.Label()
        Me.Label8 = New Wisej.Web.Label()
        Me.CBSIVA = New FactuSax.ComboWisax()
        Me.Panel2 = New Wisej.Web.GroupBox()
        Me.RbDescuentoAplicado = New Wisej.Web.RadioButton()
        Me.RbDescuentoVisible = New Wisej.Web.RadioButton()
        Me.Panel1 = New Wisej.Web.Panel()
        Me.CBRetencion = New Wisej.Web.CheckBox()
        Me.SplitContainer2 = New Wisej.Web.SplitContainer()
        Me.GroupBox3 = New Wisej.Web.GroupBox()
        Me.CBEmisor = New FactuSax.ComboWisax()
        Me.BTEm = New Wisej.Web.Button()
        Me.GroupBox4 = New Wisej.Web.GroupBox()
        Me.CBSReceptor = New FactuSax.ComboWisax()
        Me.CBSUsoCFDI = New FactuSax.ComboWisax()
        Me.BTRec = New Wisej.Web.Button()
        Me.Label17 = New Wisej.Web.Label()
        Me.GroupBox1 = New Wisej.Web.GroupBox()
        Me.MaskedTextBox2 = New Wisej.Web.MaskedTextBox()
        Me.DTPFechaEmision = New Wisej.Web.DateTimePicker()
        Me.Label34 = New Wisej.Web.Label()
        Me.RTBCondicionPago = New Wisej.Web.TextBox()
        Me.Label22 = New Wisej.Web.Label()
        Me.TBTipoCambio = New Wisej.Web.TextBox()
        Me.Label20 = New Wisej.Web.Label()
        Me.MTBCP = New Wisej.Web.MaskedTextBox()
        Me.Label7 = New Wisej.Web.Label()
        Me.CBSMetodoPago = New FactuSax.ComboWisax()
        Me.CBSFormaPago = New FactuSax.ComboWisax()
        Me.Label6 = New Wisej.Web.Label()
        Me.CBSMoneda = New FactuSax.ComboWisax()
        Me.Label5 = New Wisej.Web.Label()
        Me.Label4 = New Wisej.Web.Label()
        Me.Label3 = New Wisej.Web.Label()
        Me.RDBManual = New Wisej.Web.RadioButton()
        Me.RDBSolicitrud = New Wisej.Web.RadioButton()
        Me.GroupBox5 = New Wisej.Web.GroupBox()
        Me.ErrorProvider1 = New Wisej.Web.ErrorProvider(Me.components)
        Me.Label30 = New Wisej.Web.Label()
        Me.AspPageBox1 = New Wisej.Web.AspNetPanel()
        Me.PFACTURACION_CAPTURA_EGRESOSTableAdapter = New FactuSax.DataSet_pFACTURACION_CAPTURA_EGRESOSTableAdapters.pFACTURACION_CAPTURA_EGRESOSTableAdapter()
        Me.CBSTipoComprobante = New FactuSax.ComboWisax()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DataGridView1.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_pFACTURACION_CAPTURA_EGRESOS1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPersonalizado.SuspendLayout()
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer3.Panel1.SuspendLayout()
        Me.SplitContainer3.Panel2.SuspendLayout()
        Me.SplitContainer3.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TPCONCEPTO.SuspendLayout()
        CType(Me.DGVConceptos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GBRetencionIVA.SuspendLayout()
        Me.GBRetencionISR.SuspendLayout()
        Me.GBIVA.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonBar7
        '
        Me.RibbonBar7.Cursor = Wisej.Web.Cursors.Arrow
        Me.RibbonBar7.Name = "RibbonBar7"
        Me.RibbonBar7.Pages.Add(Me.RibbonBarPage1)
        Me.RibbonBar7.Size = New System.Drawing.Size(1185, 102)
        '
        'RibbonBarPage1
        '
        Me.RibbonBarPage1.Groups.Add(Me.RibbonBarGroup1)
        Me.RibbonBarPage1.Name = "RibbonBarPage1"
        Me.RibbonBarPage1.Text = "Menú"
        '
        'RibbonBarGroup1
        '
        Me.RibbonBarGroup1.Items.Add(Me.RBBNuevo)
        Me.RibbonBarGroup1.Items.Add(Me.RBBBuscar)
        Me.RibbonBarGroup1.Items.Add(Me.RBBPFacturar)
        Me.RibbonBarGroup1.Items.Add(Me.RBBSerie)
        Me.RibbonBarGroup1.Items.Add(Me.RBBSalir)
        Me.RibbonBarGroup1.Name = "RibbonBarGroup1"
        '
        'RBBNuevo
        '
        Me.RBBNuevo.ImageSource = "Resources\Images\Menu\64\Add List Filled-64.png"
        Me.RBBNuevo.Name = "RBBNuevo"
        Me.RBBNuevo.Text = "Nuevo"
        '
        'RBBBuscar
        '
        Me.RBBBuscar.ImageSource = "Resources\Images\Menu\64\lupa.png"
        Me.RBBBuscar.Name = "RBBBuscar"
        Me.RBBBuscar.Text = "Buscar"
        '
        'RBBPFacturar
        '
        Me.RBBPFacturar.ImageSource = "Resources\Images\Menu\64\factura.png"
        Me.RBBPFacturar.Name = "RBBPFacturar"
        Me.RBBPFacturar.Text = "Facturar"
        '
        'RBBSerie
        '
        Me.RBBSerie.ImageSource = "Resources\Images\Menu\64\serie.png"
        Me.RBBSerie.Name = "RBBSerie"
        Me.RBBSerie.Text = "Serie"
        '
        'RBBSalir
        '
        Me.RBBSalir.ImageSource = "Resources\Images\Menu\64\exit_sign.png"
        Me.RBBSalir.Name = "RBBSalir"
        Me.RBBSalir.Text = "Salir"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.AutoValidate = Wisej.Web.AutoValidate.EnablePreventFocusChange
        Me.SplitContainer1.Dock = Wisej.Web.DockStyle.Fill
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 102)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.grpPersonalizado)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1185, 767)
        Me.SplitContainer1.SplitterDistance = 347
        Me.SplitContainer1.TabIndex = 7
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.cCHK, Me.cFolio, Me.DataGridViewTextBoxColumn3, Me.Descuento_Factura, Me.Descuento, Me.Estatus, Me.cSaldo, Me.cImporteTotal, Me.cFolio_Movimiento, Me.cUnitario})
        Me.DataGridView1.Controls.Add(Me.CheckBox1)
        Me.DataGridView1.DataSource = Me.BindingSource1
        Me.DataGridView1.Dock = Wisej.Web.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 173)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(345, 592)
        Me.DataGridView1.TabIndex = 0
        '
        'cCHK
        '
        DataGridViewCellStyle1.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = False
        Me.cCHK.DefaultCellStyle = DataGridViewCellStyle1
        Me.cCHK.HeaderText = "      "
        Me.cCHK.Name = "cCHK"
        '
        'cFolio
        '
        Me.cFolio.DataPropertyName = "Folio"
        Me.cFolio.HeaderText = "Folio"
        Me.cFolio.Name = "cFolio"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Cve_Receptor"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        '
        'Descuento_Factura
        '
        Me.Descuento_Factura.DataPropertyName = "Descuento_Factura"
        Me.Descuento_Factura.HeaderText = "Descuento_Factura"
        Me.Descuento_Factura.Name = "Descuento_Factura"
        Me.Descuento_Factura.ReadOnly = True
        '
        'Descuento
        '
        Me.Descuento.DataPropertyName = "Descuento"
        Me.Descuento.HeaderText = "Descuento"
        Me.Descuento.Name = "Descuento"
        Me.Descuento.ReadOnly = True
        Me.Descuento.Visible = False
        '
        'Estatus
        '
        Me.Estatus.DataPropertyName = "Estatus"
        Me.Estatus.HeaderText = "Estatus"
        Me.Estatus.Name = "Estatus"
        '
        'cSaldo
        '
        Me.cSaldo.DataPropertyName = "saldo"
        Me.cSaldo.HeaderText = "Saldo"
        Me.cSaldo.Name = "cSaldo"
        Me.cSaldo.ReadOnly = True
        '
        'cImporteTotal
        '
        Me.cImporteTotal.DataPropertyName = "IMPORTE"
        Me.cImporteTotal.HeaderText = "cImporteTotal"
        Me.cImporteTotal.Name = "cImporteTotal"
        Me.cImporteTotal.ReadOnly = True
        Me.cImporteTotal.Visible = False
        '
        'cFolio_Movimiento
        '
        Me.cFolio_Movimiento.DataPropertyName = "Folio_Movimiento"
        Me.cFolio_Movimiento.HeaderText = "cFolio_Movimiento"
        Me.cFolio_Movimiento.Name = "cFolio_Movimiento"
        '
        'cUnitario
        '
        Me.cUnitario.DataPropertyName = "Unitario"
        Me.cUnitario.HeaderText = "Unitario"
        Me.cUnitario.Name = "cUnitario"
        Me.cUnitario.ReadOnly = True
        Me.cUnitario.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(36, 5)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(32, 22)
        Me.CheckBox1.TabIndex = 8
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "pFACTURACION_CAPTURA_EGRESOS"
        Me.BindingSource1.DataSource = Me.DataSet_pFACTURACION_CAPTURA_EGRESOS1
        '
        'DataSet_pFACTURACION_CAPTURA_EGRESOS1
        '
        Me.DataSet_pFACTURACION_CAPTURA_EGRESOS1.DataSetName = "DataSet_pFACTURACION_CAPTURA_EGRESOS"
        Me.DataSet_pFACTURACION_CAPTURA_EGRESOS1.EnforceConstraints = False
        Me.DataSet_pFACTURACION_CAPTURA_EGRESOS1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grpPersonalizado
        '
        Me.grpPersonalizado.Controls.Add(Me.Label2)
        Me.grpPersonalizado.Controls.Add(Me.CbxReceptor)
        Me.grpPersonalizado.Controls.Add(Me.RB_Detallada)
        Me.grpPersonalizado.Controls.Add(Me.RB_Sencilla)
        Me.grpPersonalizado.Controls.Add(Me.Label1)
        Me.grpPersonalizado.Controls.Add(Me.CbxClientes)
        Me.grpPersonalizado.Controls.Add(Me.Label18)
        Me.grpPersonalizado.Controls.Add(Me.cFecha1)
        Me.grpPersonalizado.Controls.Add(Me.cFecha2)
        Me.grpPersonalizado.Controls.Add(Me.Label19)
        Me.grpPersonalizado.Dock = Wisej.Web.DockStyle.Top
        Me.grpPersonalizado.Location = New System.Drawing.Point(0, 0)
        Me.grpPersonalizado.Name = "grpPersonalizado"
        Me.grpPersonalizado.Size = New System.Drawing.Size(345, 173)
        Me.grpPersonalizado.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Receptor"
        '
        'CbxReceptor
        '
        Me.CbxReceptor.Location = New System.Drawing.Point(8, 78)
        Me.CbxReceptor.Name = "CbxReceptor"
        Me.CbxReceptor.TabIndex = 8
        '
        'RB_Detallada
        '
        Me.RB_Detallada.Location = New System.Drawing.Point(145, 113)
        Me.RB_Detallada.Name = "RB_Detallada"
        Me.RB_Detallada.Size = New System.Drawing.Size(135, 22)
        Me.RB_Detallada.TabIndex = 7
        Me.RB_Detallada.Text = "Factura Detallada"
        '
        'RB_Sencilla
        '
        Me.RB_Sencilla.Checked = True
        Me.RB_Sencilla.Location = New System.Drawing.Point(5, 113)
        Me.RB_Sencilla.Name = "RB_Sencilla"
        Me.RB_Sencilla.Size = New System.Drawing.Size(126, 22)
        Me.RB_Sencilla.TabIndex = 6
        Me.RB_Sencilla.TabStop = True
        Me.RB_Sencilla.Text = "Factura Sencilla"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(8, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Cliente"
        '
        'CbxClientes
        '
        Me.CbxClientes.Location = New System.Drawing.Point(8, 33)
        Me.CbxClientes.Name = "CbxClientes"
        Me.CbxClientes.TabIndex = 3
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(5, 147)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(35, 15)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Inicio"
        '
        'cFecha1
        '
        Me.cFecha1.CustomFormat = "dd/MM/yyyy"
        Me.cFecha1.Format = Wisej.Web.DateTimePickerFormat.Custom
        Me.cFecha1.Location = New System.Drawing.Point(43, 143)
        Me.cFecha1.Name = "cFecha1"
        Me.cFecha1.Size = New System.Drawing.Size(103, 22)
        Me.cFecha1.TabIndex = 0
        Me.cFecha1.Value = New Date(2010, 5, 4, 18, 20, 0, 0)
        '
        'cFecha2
        '
        Me.cFecha2.CustomFormat = "dd/MM/yyyy"
        Me.cFecha2.Format = Wisej.Web.DateTimePickerFormat.Custom
        Me.cFecha2.Location = New System.Drawing.Point(231, 143)
        Me.cFecha2.Name = "cFecha2"
        Me.cFecha2.Size = New System.Drawing.Size(103, 22)
        Me.cFecha2.TabIndex = 0
        Me.cFecha2.Value = New Date(2010, 5, 4, 18, 20, 0, 0)
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(207, 147)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(23, 15)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Fin"
        '
        'SplitContainer3
        '
        Me.SplitContainer3.AutoValidate = Wisej.Web.AutoValidate.EnablePreventFocusChange
        Me.SplitContainer3.Dock = Wisej.Web.DockStyle.Fill
        Me.SplitContainer3.FixedPanel = Wisej.Web.FixedPanel.Panel2
        Me.SplitContainer3.Location = New System.Drawing.Point(0, 244)
        Me.SplitContainer3.Name = "SplitContainer3"
        '
        'SplitContainer3.Panel1
        '
        Me.SplitContainer3.Panel1.Controls.Add(Me.TabControl1)
        Me.SplitContainer3.Panel1.Controls.Add(Me.Panel3)
        '
        'SplitContainer3.Panel2
        '
        Me.SplitContainer3.Panel2.Controls.Add(Me.GroupBox2)
        Me.SplitContainer3.Size = New System.Drawing.Size(833, 521)
        Me.SplitContainer3.SplitterDistance = 564
        Me.SplitContainer3.TabIndex = 4
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TPCONCEPTO)
        Me.TabControl1.Dock = Wisej.Web.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 0)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.PageInsets = New Wisej.Web.Padding(1, 35, 1, 1)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(562, 345)
        Me.TabControl1.TabIndex = 4
        '
        'TPCONCEPTO
        '
        Me.TPCONCEPTO.Controls.Add(Me.DGVConceptos)
        Me.TPCONCEPTO.Location = New System.Drawing.Point(1, 35)
        Me.TPCONCEPTO.Name = "TPCONCEPTO"
        Me.TPCONCEPTO.Size = New System.Drawing.Size(560, 309)
        Me.TPCONCEPTO.Text = "CONCEPTO"
        '
        'DGVConceptos
        '
        Me.DGVConceptos.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.dgvEliminar, Me.cCantidad, Me.cbClaveProdServ, Me.cbClaveUnidad, Me.cDescripcion, Me.cValorUnitario, Me.cImporte, Me.cDescuento, Me.cNoIdentificacion})
        Me.DGVConceptos.Dock = Wisej.Web.DockStyle.Fill
        Me.DGVConceptos.Location = New System.Drawing.Point(0, 0)
        Me.DGVConceptos.Name = "DGVConceptos"
        Me.DGVConceptos.Size = New System.Drawing.Size(560, 309)
        Me.DGVConceptos.TabIndex = 3
        '
        'dgvEliminar
        '
        Me.dgvEliminar.CellImage = Global.FactuSax.My.Resources.Resources.Eliminar
        Me.dgvEliminar.CellImageAlignment = Wisej.Web.DataGridViewContentAlignment.NotSet
        Me.dgvEliminar.HeaderText = "dgvEliminar"
        Me.dgvEliminar.Name = "dgvEliminar"
        Me.dgvEliminar.Width = 30
        '
        'cCantidad
        '
        Me.cCantidad.HeaderText = "Cant"
        Me.cCantidad.Name = "cCantidad"
        Me.cCantidad.Width = 50
        '
        'cbClaveProdServ
        '
        Me.cbClaveProdServ.FillWeight = 200.0!
        Me.cbClaveProdServ.HeaderText = "ClaveProdServ"
        Me.cbClaveProdServ.Name = "cbClaveProdServ"
        Me.cbClaveProdServ.Width = 300
        '
        'cbClaveUnidad
        '
        Me.cbClaveUnidad.HeaderText = "Unidad"
        Me.cbClaveUnidad.Name = "cbClaveUnidad"
        Me.cbClaveUnidad.Width = 70
        '
        'cDescripcion
        '
        Me.cDescripcion.HeaderText = "Descripcion"
        Me.cDescripcion.Name = "cDescripcion"
        Me.cDescripcion.Width = 300
        '
        'cValorUnitario
        '
        Me.cValorUnitario.HeaderText = "Unitario"
        Me.cValorUnitario.Name = "cValorUnitario"
        Me.cValorUnitario.Width = 75
        '
        'cImporte
        '
        Me.cImporte.HeaderText = "Importe"
        Me.cImporte.Name = "cImporte"
        Me.cImporte.ReadOnly = True
        Me.cImporte.Width = 75
        '
        'cDescuento
        '
        Me.cDescuento.HeaderText = "Descuento"
        Me.cDescuento.Name = "cDescuento"
        '
        'cNoIdentificacion
        '
        Me.cNoIdentificacion.HeaderText = "No. Id"
        Me.cNoIdentificacion.Name = "cNoIdentificacion"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.Label33)
        Me.Panel3.Controls.Add(Me.TBDescuento)
        Me.Panel3.Controls.Add(Me.TBTotal)
        Me.Panel3.Controls.Add(Me.TBRISR)
        Me.Panel3.Controls.Add(Me.TBRIVA)
        Me.Panel3.Controls.Add(Me.TBIva)
        Me.Panel3.Controls.Add(Me.TBSubTotal)
        Me.Panel3.Controls.Add(Me.Label27)
        Me.Panel3.Controls.Add(Me.Label25)
        Me.Panel3.Controls.Add(Me.Label24)
        Me.Panel3.Controls.Add(Me.Label21)
        Me.Panel3.Controls.Add(Me.Label23)
        Me.Panel3.Dock = Wisej.Web.DockStyle.Bottom
        Me.Panel3.Location = New System.Drawing.Point(0, 345)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(562, 174)
        Me.Panel3.TabIndex = 5
        Me.Panel3.TabStop = True
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(8, 37)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(67, 15)
        Me.Label33.TabIndex = 0
        Me.Label33.Text = "Descuento"
        '
        'TBDescuento
        '
        Me.TBDescuento.Location = New System.Drawing.Point(127, 34)
        Me.TBDescuento.Name = "TBDescuento"
        Me.TBDescuento.Size = New System.Drawing.Size(166, 22)
        Me.TBDescuento.TabIndex = 1
        '
        'TBTotal
        '
        Me.TBTotal.Location = New System.Drawing.Point(127, 138)
        Me.TBTotal.Name = "TBTotal"
        Me.TBTotal.Size = New System.Drawing.Size(166, 22)
        Me.TBTotal.TabIndex = 1
        '
        'TBRISR
        '
        Me.TBRISR.Location = New System.Drawing.Point(127, 112)
        Me.TBRISR.Name = "TBRISR"
        Me.TBRISR.Size = New System.Drawing.Size(166, 22)
        Me.TBRISR.TabIndex = 1
        '
        'TBRIVA
        '
        Me.TBRIVA.Location = New System.Drawing.Point(127, 86)
        Me.TBRIVA.Name = "TBRIVA"
        Me.TBRIVA.Size = New System.Drawing.Size(166, 22)
        Me.TBRIVA.TabIndex = 1
        '
        'TBIva
        '
        Me.TBIva.Location = New System.Drawing.Point(127, 60)
        Me.TBIva.Name = "TBIva"
        Me.TBIva.Size = New System.Drawing.Size(166, 22)
        Me.TBIva.TabIndex = 1
        '
        'TBSubTotal
        '
        Me.TBSubTotal.Location = New System.Drawing.Point(127, 8)
        Me.TBSubTotal.Name = "TBSubTotal"
        Me.TBSubTotal.Size = New System.Drawing.Size(166, 22)
        Me.TBSubTotal.TabIndex = 1
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(8, 141)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(33, 15)
        Me.Label27.TabIndex = 0
        Me.Label27.Text = "Total"
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(8, 115)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(106, 15)
        Me.Label25.TabIndex = 0
        Me.Label25.Text = "Retencion de ISR"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(8, 89)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(106, 15)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "Retencion de IVA"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(8, 63)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(25, 15)
        Me.Label21.TabIndex = 0
        Me.Label21.Text = "IVA"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(8, 11)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(52, 15)
        Me.Label23.TabIndex = 0
        Me.Label23.Text = "Subtotal"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.GBRetencionIVA)
        Me.GroupBox2.Controls.Add(Me.GBRetencionISR)
        Me.GroupBox2.Controls.Add(Me.GBIVA)
        Me.GroupBox2.Controls.Add(Me.Panel2)
        Me.GroupBox2.Controls.Add(Me.Panel1)
        Me.GroupBox2.Dock = Wisej.Web.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(261, 519)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.Text = "Impuestos"
        '
        'GBRetencionIVA
        '
        Me.GBRetencionIVA.Controls.Add(Me.TasaoCuotaRIVA)
        Me.GBRetencionIVA.Controls.Add(Me.Label14)
        Me.GBRetencionIVA.Controls.Add(Me.MTBRISR)
        Me.GBRetencionIVA.Controls.Add(Me.Label15)
        Me.GBRetencionIVA.Controls.Add(Me.Label16)
        Me.GBRetencionIVA.Controls.Add(Me.CBSRIVA)
        Me.GBRetencionIVA.Dock = Wisej.Web.DockStyle.Top
        Me.GBRetencionIVA.Location = New System.Drawing.Point(3, 337)
        Me.GBRetencionIVA.Name = "GBRetencionIVA"
        Me.GBRetencionIVA.Size = New System.Drawing.Size(255, 102)
        Me.GBRetencionIVA.TabIndex = 1
        Me.GBRetencionIVA.Text = "Retencion IVA"
        '
        'TasaoCuotaRIVA
        '
        Me.TasaoCuotaRIVA.FormattingEnabled = True
        Me.TasaoCuotaRIVA.Items.AddRange(New Object() {"Tasa", "Cuota"})
        Me.TasaoCuotaRIVA.Location = New System.Drawing.Point(97, 46)
        Me.TasaoCuotaRIVA.Name = "TasaoCuotaRIVA"
        Me.TasaoCuotaRIVA.Size = New System.Drawing.Size(129, 22)
        Me.TasaoCuotaRIVA.TabIndex = 10
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(7, 77)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 15)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "Valor "
        '
        'MTBRISR
        '
        Me.MTBRISR.Location = New System.Drawing.Point(97, 70)
        Me.MTBRISR.Mask = "0.000000"
        Me.MTBRISR.Name = "MTBRISR"
        Me.MTBRISR.Size = New System.Drawing.Size(129, 22)
        Me.MTBRISR.TabIndex = 9
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(7, 54)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 15)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Tasa o Cuota"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(7, 33)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(58, 15)
        Me.Label16.TabIndex = 3
        Me.Label16.Text = "Impuesto"
        '
        'CBSRIVA
        '
        Me.CBSRIVA.BackColor = System.Drawing.Color.Transparent
        Me.CBSRIVA.Cursor = Wisej.Web.Cursors.Hand
        Me.CBSRIVA.Location = New System.Drawing.Point(97, 23)
        Me.CBSRIVA.Name = "CBSRIVA"
        Me.CBSRIVA.Size = New System.Drawing.Size(129, 22)
        Me.CBSRIVA.TabIndex = 7
        '
        'GBRetencionISR
        '
        Me.GBRetencionISR.Controls.Add(Me.TasaoCuotaISR)
        Me.GBRetencionISR.Controls.Add(Me.Label11)
        Me.GBRetencionISR.Controls.Add(Me.CBSRISR)
        Me.GBRetencionISR.Controls.Add(Me.Label13)
        Me.GBRetencionISR.Controls.Add(Me.Label12)
        Me.GBRetencionISR.Controls.Add(Me.MTBRIVA)
        Me.GBRetencionISR.Dock = Wisej.Web.DockStyle.Top
        Me.GBRetencionISR.Location = New System.Drawing.Point(3, 237)
        Me.GBRetencionISR.Name = "GBRetencionISR"
        Me.GBRetencionISR.Size = New System.Drawing.Size(255, 100)
        Me.GBRetencionISR.TabIndex = 1
        Me.GBRetencionISR.Text = "Retencion del ISR"
        '
        'TasaoCuotaISR
        '
        Me.TasaoCuotaISR.FormattingEnabled = True
        Me.TasaoCuotaISR.Items.AddRange(New Object() {"Tasa", "Cuota"})
        Me.TasaoCuotaISR.Location = New System.Drawing.Point(97, 45)
        Me.TasaoCuotaISR.Name = "TasaoCuotaISR"
        Me.TasaoCuotaISR.Size = New System.Drawing.Size(129, 22)
        Me.TasaoCuotaISR.TabIndex = 10
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(7, 79)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 15)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "Valor "
        '
        'CBSRISR
        '
        Me.CBSRISR.BackColor = System.Drawing.Color.Transparent
        Me.CBSRISR.Cursor = Wisej.Web.Cursors.Hand
        Me.CBSRISR.Location = New System.Drawing.Point(97, 22)
        Me.CBSRISR.Name = "CBSRISR"
        Me.CBSRISR.Size = New System.Drawing.Size(129, 22)
        Me.CBSRISR.TabIndex = 7
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(9, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 15)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Impuesto"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(7, 53)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 15)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Tasa o Cuota"
        '
        'MTBRIVA
        '
        Me.MTBRIVA.Location = New System.Drawing.Point(97, 72)
        Me.MTBRIVA.Mask = "0.000000"
        Me.MTBRIVA.Name = "MTBRIVA"
        Me.MTBRIVA.Size = New System.Drawing.Size(129, 22)
        Me.MTBRIVA.TabIndex = 9
        '
        'GBIVA
        '
        Me.GBIVA.Controls.Add(Me.TasaoCuotaIVA)
        Me.GBIVA.Controls.Add(Me.MTBIVA)
        Me.GBIVA.Controls.Add(Me.Label10)
        Me.GBIVA.Controls.Add(Me.Label9)
        Me.GBIVA.Controls.Add(Me.Label8)
        Me.GBIVA.Controls.Add(Me.CBSIVA)
        Me.GBIVA.Dock = Wisej.Web.DockStyle.Top
        Me.GBIVA.Location = New System.Drawing.Point(3, 133)
        Me.GBIVA.Name = "GBIVA"
        Me.GBIVA.Size = New System.Drawing.Size(255, 104)
        Me.GBIVA.TabIndex = 1
        Me.GBIVA.Text = "IVA"
        '
        'TasaoCuotaIVA
        '
        Me.TasaoCuotaIVA.FormattingEnabled = True
        Me.TasaoCuotaIVA.Items.AddRange(New Object() {"Tasa", "Cuota"})
        Me.TasaoCuotaIVA.Location = New System.Drawing.Point(97, 47)
        Me.TasaoCuotaIVA.Name = "TasaoCuotaIVA"
        Me.TasaoCuotaIVA.Size = New System.Drawing.Size(129, 22)
        Me.TasaoCuotaIVA.TabIndex = 10
        '
        'MTBIVA
        '
        Me.MTBIVA.Location = New System.Drawing.Point(97, 73)
        Me.MTBIVA.Mask = "0.000000"
        Me.MTBIVA.Name = "MTBIVA"
        Me.MTBIVA.Size = New System.Drawing.Size(129, 22)
        Me.MTBIVA.TabIndex = 9
        Me.MTBIVA.TextAlign = Wisej.Web.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(7, 80)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 15)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Valor "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(7, 55)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 15)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Tasa o Cuota"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(7, 29)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 15)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Impuesto"
        '
        'CBSIVA
        '
        Me.CBSIVA.BackColor = System.Drawing.Color.Transparent
        Me.CBSIVA.Cursor = Wisej.Web.Cursors.Hand
        Me.CBSIVA.Location = New System.Drawing.Point(97, 19)
        Me.CBSIVA.Name = "CBSIVA"
        Me.CBSIVA.Size = New System.Drawing.Size(129, 22)
        Me.CBSIVA.TabIndex = 7
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RbDescuentoAplicado)
        Me.Panel2.Controls.Add(Me.RbDescuentoVisible)
        Me.Panel2.Dock = Wisej.Web.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(3, 63)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(255, 70)
        Me.Panel2.TabIndex = 2
        Me.Panel2.Text = "Descuento"
        '
        'RbDescuentoAplicado
        '
        Me.RbDescuentoAplicado.Location = New System.Drawing.Point(4, 41)
        Me.RbDescuentoAplicado.Name = "RbDescuentoAplicado"
        Me.RbDescuentoAplicado.Size = New System.Drawing.Size(148, 22)
        Me.RbDescuentoAplicado.TabIndex = 1
        Me.RbDescuentoAplicado.Text = "Descuento Aplicado"
        '
        'RbDescuentoVisible
        '
        Me.RbDescuentoVisible.Checked = True
        Me.RbDescuentoVisible.Location = New System.Drawing.Point(4, 21)
        Me.RbDescuentoVisible.Name = "RbDescuentoVisible"
        Me.RbDescuentoVisible.Size = New System.Drawing.Size(137, 22)
        Me.RbDescuentoVisible.TabIndex = 0
        Me.RbDescuentoVisible.TabStop = True
        Me.RbDescuentoVisible.Text = "Descuento Visible"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.CBRetencion)
        Me.Panel1.Dock = Wisej.Web.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(3, 18)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(255, 45)
        Me.Panel1.TabIndex = 0
        Me.Panel1.TabStop = True
        '
        'CBRetencion
        '
        Me.CBRetencion.Location = New System.Drawing.Point(4, 16)
        Me.CBRetencion.Name = "CBRetencion"
        Me.CBRetencion.Size = New System.Drawing.Size(91, 22)
        Me.CBRetencion.TabIndex = 0
        Me.CBRetencion.Text = "Retención"
        '
        'SplitContainer2
        '
        Me.SplitContainer2.AutoValidate = Wisej.Web.AutoValidate.EnablePreventFocusChange
        Me.SplitContainer2.Dock = Wisej.Web.DockStyle.Top
        Me.SplitContainer2.FixedPanel = Wisej.Web.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 150)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GroupBox3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox4)
        Me.SplitContainer2.Size = New System.Drawing.Size(833, 94)
        Me.SplitContainer2.SplitterDistance = 416
        Me.SplitContainer2.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CBEmisor)
        Me.GroupBox3.Controls.Add(Me.BTEm)
        Me.GroupBox3.Dock = Wisej.Web.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(414, 92)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.Text = "Emisor"
        '
        'CBEmisor
        '
        Me.CBEmisor.BackColor = System.Drawing.Color.Transparent
        Me.CBEmisor.Cursor = Wisej.Web.Cursors.Hand
        Me.CBEmisor.Location = New System.Drawing.Point(8, 19)
        Me.CBEmisor.Name = "CBEmisor"
        Me.CBEmisor.Size = New System.Drawing.Size(360, 22)
        Me.CBEmisor.TabIndex = 0
        '
        'BTEm
        '
        Me.BTEm.Location = New System.Drawing.Point(372, 17)
        Me.BTEm.Name = "BTEm"
        Me.BTEm.Size = New System.Drawing.Size(41, 23)
        Me.BTEm.TabIndex = 1
        Me.BTEm.Text = "+"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.CBSReceptor)
        Me.GroupBox4.Controls.Add(Me.CBSUsoCFDI)
        Me.GroupBox4.Controls.Add(Me.BTRec)
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Dock = Wisej.Web.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(409, 92)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.Text = "Receptor"
        '
        'CBSReceptor
        '
        Me.CBSReceptor.BackColor = System.Drawing.Color.Transparent
        Me.CBSReceptor.Cursor = Wisej.Web.Cursors.Hand
        Me.CBSReceptor.Location = New System.Drawing.Point(9, 19)
        Me.CBSReceptor.Name = "CBSReceptor"
        Me.CBSReceptor.Size = New System.Drawing.Size(364, 22)
        Me.CBSReceptor.TabIndex = 0
        '
        'CBSUsoCFDI
        '
        Me.CBSUsoCFDI.BackColor = System.Drawing.Color.Transparent
        Me.CBSUsoCFDI.Cursor = Wisej.Web.Cursors.Hand
        Me.CBSUsoCFDI.Location = New System.Drawing.Point(71, 57)
        Me.CBSUsoCFDI.Name = "CBSUsoCFDI"
        Me.CBSUsoCFDI.Size = New System.Drawing.Size(318, 22)
        Me.CBSUsoCFDI.TabIndex = 4
        '
        'BTRec
        '
        Me.BTRec.Location = New System.Drawing.Point(373, 17)
        Me.BTRec.Name = "BTRec"
        Me.BTRec.Size = New System.Drawing.Size(33, 23)
        Me.BTRec.TabIndex = 1
        Me.BTRec.Text = "+"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 60)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(62, 15)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Uso CFDI"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.MaskedTextBox2)
        Me.GroupBox1.Controls.Add(Me.DTPFechaEmision)
        Me.GroupBox1.Controls.Add(Me.Label34)
        Me.GroupBox1.Controls.Add(Me.RTBCondicionPago)
        Me.GroupBox1.Controls.Add(Me.Label22)
        Me.GroupBox1.Controls.Add(Me.TBTipoCambio)
        Me.GroupBox1.Controls.Add(Me.Label20)
        Me.GroupBox1.Controls.Add(Me.MTBCP)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.CBSMetodoPago)
        Me.GroupBox1.Controls.Add(Me.CBSFormaPago)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.CBSMoneda)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Dock = Wisej.Web.DockStyle.Top
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(833, 150)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.Text = "Informacion Basica"
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Location = New System.Drawing.Point(162, 28)
        Me.MaskedTextBox2.Mask = "00:00"
        Me.MaskedTextBox2.Name = "MaskedTextBox2"
        Me.MaskedTextBox2.Size = New System.Drawing.Size(40, 22)
        Me.MaskedTextBox2.TabIndex = 10
        Me.MaskedTextBox2.Text = "1200"
        '
        'DTPFechaEmision
        '
        Me.DTPFechaEmision.CustomFormat = "dd/MM/yy"
        Me.DTPFechaEmision.Format = Wisej.Web.DateTimePickerFormat.Custom
        Me.DTPFechaEmision.Location = New System.Drawing.Point(83, 28)
        Me.DTPFechaEmision.Name = "DTPFechaEmision"
        Me.DTPFechaEmision.Size = New System.Drawing.Size(76, 22)
        Me.DTPFechaEmision.TabIndex = 1
        Me.DTPFechaEmision.Value = New Date(2022, 2, 15, 14, 50, 36, 888)
        '
        'Label34
        '
        Me.Label34.AutoSize = True
        Me.Label34.Location = New System.Drawing.Point(9, 33)
        Me.Label34.Name = "Label34"
        Me.Label34.Size = New System.Drawing.Size(90, 15)
        Me.Label34.TabIndex = 0
        Me.Label34.Text = "Fecha Emision"
        '
        'RTBCondicionPago
        '
        Me.RTBCondicionPago.Location = New System.Drawing.Point(106, 92)
        Me.RTBCondicionPago.Name = "RTBCondicionPago"
        Me.RTBCondicionPago.Size = New System.Drawing.Size(719, 22)
        Me.RTBCondicionPago.TabIndex = 9
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(9, 95)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(91, 15)
        Me.Label22.TabIndex = 3
        Me.Label22.Text = "Observaciones"
        '
        'TBTipoCambio
        '
        Me.TBTipoCambio.Location = New System.Drawing.Point(405, 60)
        Me.TBTipoCambio.Name = "TBTipoCambio"
        Me.TBTipoCambio.Size = New System.Drawing.Size(95, 22)
        Me.TBTipoCambio.TabIndex = 1
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(313, 63)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(96, 15)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "Tipo de Cambio"
        '
        'MTBCP
        '
        Me.MTBCP.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MTBCP.Location = New System.Drawing.Point(645, 58)
        Me.MTBCP.Mask = "00000"
        Me.MTBCP.Name = "MTBCP"
        Me.MTBCP.Size = New System.Drawing.Size(48, 22)
        Me.MTBCP.TabIndex = 8
        Me.MTBCP.Visible = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(517, 63)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 15)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "CP Lugar Expedicion"
        Me.Label7.Visible = False
        '
        'CBSMetodoPago
        '
        Me.CBSMetodoPago.BackColor = System.Drawing.Color.Transparent
        Me.CBSMetodoPago.Cursor = Wisej.Web.Cursors.Hand
        Me.CBSMetodoPago.Location = New System.Drawing.Point(316, 26)
        Me.CBSMetodoPago.Name = "CBSMetodoPago"
        Me.CBSMetodoPago.Size = New System.Drawing.Size(184, 22)
        Me.CBSMetodoPago.TabIndex = 7
        '
        'CBSFormaPago
        '
        Me.CBSFormaPago.BackColor = System.Drawing.Color.Transparent
        Me.CBSFormaPago.Cursor = Wisej.Web.Cursors.Hand
        Me.CBSFormaPago.Location = New System.Drawing.Point(604, 26)
        Me.CBSFormaPago.Name = "CBSFormaPago"
        Me.CBSFormaPago.Size = New System.Drawing.Size(202, 22)
        Me.CBSFormaPago.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(212, 33)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(100, 15)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Metodo de Pago"
        '
        'CBSMoneda
        '
        Me.CBSMoneda.BackColor = System.Drawing.Color.Transparent
        Me.CBSMoneda.Cursor = Wisej.Web.Cursors.Hand
        Me.CBSMoneda.Location = New System.Drawing.Point(83, 58)
        Me.CBSMoneda.Name = "CBSMoneda"
        Me.CBSMoneda.Size = New System.Drawing.Size(218, 22)
        Me.CBSMoneda.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(51, 15)
        Me.Label5.TabIndex = 3
        Me.Label5.Text = "Moneda"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(503, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Forma de Pago"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(618, 46)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Tipo Comprobante"
        Me.Label3.Visible = False
        '
        'RDBManual
        '
        Me.RDBManual.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RDBManual.Location = New System.Drawing.Point(3, 24)
        Me.RDBManual.Name = "RDBManual"
        Me.RDBManual.Size = New System.Drawing.Size(83, 27)
        Me.RDBManual.TabIndex = 9
        Me.RDBManual.Text = "Manual"
        '
        'RDBSolicitrud
        '
        Me.RDBSolicitrud.Checked = True
        Me.RDBSolicitrud.Font = New System.Drawing.Font("Tahoma", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.RDBSolicitrud.Location = New System.Drawing.Point(92, 24)
        Me.RDBSolicitrud.Name = "RDBSolicitrud"
        Me.RDBSolicitrud.Size = New System.Drawing.Size(92, 27)
        Me.RDBSolicitrud.TabIndex = 9
        Me.RDBSolicitrud.TabStop = True
        Me.RDBSolicitrud.Text = "Solicitud"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.RDBSolicitrud)
        Me.GroupBox5.Controls.Add(Me.RDBManual)
        Me.GroupBox5.Location = New System.Drawing.Point(980, 36)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(196, 52)
        Me.GroupBox5.TabIndex = 10
        Me.GroupBox5.Text = "Tipo Factura"
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkRate = 3
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(7, 11)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(44, 13)
        Me.Label30.TabIndex = 1
        Me.Label30.Text = "Fecha del Pago"
        '
        'AspPageBox1
        '
        Me.AspPageBox1.Location = New System.Drawing.Point(927, 15)
        Me.AspPageBox1.Name = "AspPageBox1"
        Me.AspPageBox1.Size = New System.Drawing.Size(10, 10)
        Me.AspPageBox1.TabIndex = 11
        '
        'PFACTURACION_CAPTURA_EGRESOSTableAdapter
        '
        Me.PFACTURACION_CAPTURA_EGRESOSTableAdapter.ClearBeforeFill = True
        '
        'CBSTipoComprobante
        '
        Me.CBSTipoComprobante.BackColor = System.Drawing.Color.Transparent
        Me.CBSTipoComprobante.Cursor = Wisej.Web.Cursors.Hand
        Me.CBSTipoComprobante.Enabled = False
        Me.CBSTipoComprobante.Location = New System.Drawing.Point(724, 42)
        Me.CBSTipoComprobante.Name = "CBSTipoComprobante"
        Me.CBSTipoComprobante.Size = New System.Drawing.Size(218, 22)
        Me.CBSTipoComprobante.TabIndex = 2
        Me.CBSTipoComprobante.Visible = False
        '
        'Facturacion_Electronica_CFD_33
        '
        Me.ClientSize = New System.Drawing.Size(1185, 869)
        Me.Controls.Add(Me.AspPageBox1)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.CBSTipoComprobante)
        Me.Controls.Add(Me.RibbonBar7)
        Me.Name = "Facturacion_Electronica_CFD_33"
        Me.Text = "Crear Factura"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DataGridView1.ResumeLayout(False)
        Me.DataGridView1.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_pFACTURACION_CAPTURA_EGRESOS1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPersonalizado.ResumeLayout(False)
        Me.grpPersonalizado.PerformLayout()
        Me.SplitContainer3.Panel1.ResumeLayout(False)
        Me.SplitContainer3.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer3.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TPCONCEPTO.ResumeLayout(False)
        CType(Me.DGVConceptos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GBRetencionIVA.ResumeLayout(False)
        Me.GBRetencionIVA.PerformLayout()
        Me.GBRetencionISR.ResumeLayout(False)
        Me.GBRetencionISR.PerformLayout()
        Me.GBIVA.ResumeLayout(False)
        Me.GBIVA.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonBar7 As Ext.RibbonBar.RibbonBar
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GBRetencionIVA As GroupBox
    Friend WithEvents MTBRISR As MaskedTextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents CBSRIVA As ComboWisax
    Friend WithEvents GBRetencionISR As GroupBox
    Friend WithEvents CBSRISR As ComboWisax
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents MTBRIVA As MaskedTextBox
    Friend WithEvents GBIVA As GroupBox
    Friend WithEvents MTBIVA As MaskedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CBSIVA As ComboWisax
    Friend WithEvents Panel1 As Panel
    Friend WithEvents CBRetencion As CheckBox
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents MTBCP As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents CBSMetodoPago As ComboWisax
    Friend WithEvents CBSFormaPago As ComboWisax
    Friend WithEvents Label6 As Label
    Friend WithEvents CBSMoneda As ComboWisax
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CBSTipoComprobante As ComboWisax
    Friend WithEvents CBEmisor As ComboWisax
    Friend WithEvents CBSReceptor As ComboWisax
    Friend WithEvents DataGridView1 As Wisej.Web.DataGridView
    Friend WithEvents BTEm As Button
    Friend WithEvents CBSUsoCFDI As ComboWisax
    Friend WithEvents Label17 As Label
    Friend WithEvents BTRec As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents RDBManual As RadioButton
    Friend WithEvents RDBSolicitrud As RadioButton
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents Label14 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TasaoCuotaIVA As ComboBox
    Friend WithEvents TasaoCuotaRIVA As ComboBox
    Friend WithEvents TasaoCuotaISR As ComboBox
    Friend WithEvents DGVConceptos As Wisej.Web.DataGridView
    Friend WithEvents cCantidad As DataGridViewTextBoxColumn
    Friend WithEvents cbClaveProdServ As DataGridViewComboBoxColumn
    Friend WithEvents cbClaveUnidad As DataGridViewComboBoxColumn
    Friend WithEvents cDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents cValorUnitario As DataGridViewTextBoxColumn
    Friend WithEvents cImporte As DataGridViewTextBoxColumn
    Friend WithEvents cNoIdentificacion As DataGridViewTextBoxColumn
    Friend WithEvents SplitContainer3 As SplitContainer
    Friend WithEvents grpPersonalizado As GroupBox
    Friend WithEvents Label18 As Label
    Friend WithEvents cFecha1 As DateTimePicker
    Friend WithEvents cFecha2 As DateTimePicker
    Friend WithEvents Label19 As Label
    Friend WithEvents cFolio As DataGridViewTextBoxColumn
    Friend WithEvents RibbonBarPage1 As Ext.RibbonBar.RibbonBarPage
    Friend WithEvents RibbonBarGroup1 As Ext.RibbonBar.RibbonBarGroup
    Friend WithEvents RBBNuevo As Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents RBBBuscar As Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents RBBPFacturar As Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents RBBSerie As Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents RBBSalir As Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents cCHK As DataGridViewCheckBoxColumn
    Friend WithEvents Descuento_Factura As DataGridViewTextBoxColumn
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TPCONCEPTO As TabPage
    Friend WithEvents TBTipoCambio As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents RTBCondicionPago As TextBox
    Friend WithEvents Label22 As Label
    'Friend WithEvents DataSet_pPACIENTES_SOLICITUDES_B_CAPTURA_SAT_FACTURACION As DataSet_pPACIENTES_SOLICITUDES_B_CAPTURA_SAT_FACTURACION
    Friend WithEvents cDescuento As DataGridViewTextBoxColumn
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents Label30 As Label
    Friend WithEvents DTPFechaEmision As DateTimePicker
    Friend WithEvents Label34 As Label
    Friend WithEvents MaskedTextBox2 As MaskedTextBox
    Friend WithEvents AspPageBox1 As AspNetPanel
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents DataSet_pFACTURACION_CAPTURA_EGRESOS1 As DataSet_pFACTURACION_CAPTURA_EGRESOS
    Friend WithEvents PFACTURACION_CAPTURA_EGRESOSTableAdapter As DataSet_pFACTURACION_CAPTURA_EGRESOSTableAdapters.pFACTURACION_CAPTURA_EGRESOSTableAdapter
    Friend WithEvents Estatus As DataGridViewTextBoxColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents CbxClientes As ComboWisax
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Label33 As Label
    Friend WithEvents TBDescuento As TextBox
    Friend WithEvents TBTotal As TextBox
    Friend WithEvents TBRISR As TextBox
    Friend WithEvents TBRIVA As TextBox
    Friend WithEvents TBIva As TextBox
    Friend WithEvents TBSubTotal As TextBox
    Friend WithEvents Label27 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label21 As Label
    Friend WithEvents Label23 As Label
    Friend WithEvents RB_Detallada As RadioButton
    Friend WithEvents RB_Sencilla As RadioButton
    Friend WithEvents cSaldo As DataGridViewTextBoxColumn
    Friend WithEvents cImporteTotal As DataGridViewTextBoxColumn
    Friend WithEvents Descuento As DataGridViewTextBoxColumn
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents cFolio_Movimiento As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents CbxReceptor As ComboWisax
    Friend WithEvents cUnitario As DataGridViewTextBoxColumn
    Friend WithEvents Panel2 As GroupBox
    Friend WithEvents RbDescuentoAplicado As RadioButton
    Friend WithEvents RbDescuentoVisible As RadioButton
    Friend WithEvents dgvEliminar As DataGridViewImageColumn
End Class