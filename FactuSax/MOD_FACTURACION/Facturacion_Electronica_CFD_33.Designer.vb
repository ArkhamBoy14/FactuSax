
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
        Dim DataGridViewCellStyle2 As Wisej.Web.DataGridViewCellStyle = New Wisej.Web.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As Wisej.Web.DataGridViewCellStyle = New Wisej.Web.DataGridViewCellStyle()
        Me.RibbonBar7 = New Wisej.Web.Ext.RibbonBar.RibbonBar()
        Me.RibbonBarPage1 = New Wisej.Web.Ext.RibbonBar.RibbonBarPage()
        Me.RibbonBarGroup1 = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.RBBNuevo = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBBBuscar = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBBPFacturar = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBBSerie = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RibbonBarGroup2 = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.RBBImpuestos = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RibbonBarGroup3 = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.RBBSalir = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.SplitContainer1 = New Wisej.Web.SplitContainer()
        Me.DGV_Receptor = New Wisej.Web.DataGridView()
        Me.Column0 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.cCheckPadre = New Wisej.Web.DataGridViewCheckBoxColumn()
        Me.colRFC = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colRazon_Social = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colRFCX = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colTIPO_PARENT = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colChecked = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.BS_Receptor = New Wisej.Web.BindingSource(Me.components)
        Me.DataSet_pFACTURACION_RECEPTOR_PADRE_HIJO = New FactuSax.DataSet_pFACTURACION_RECEPTOR_PADRE_HIJO()
        Me.grpPersonalizado = New Wisej.Web.GroupBox()
        Me.Chk_SaldoPendiente = New Wisej.Web.CheckBox()
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
        Me.Panel2 = New Wisej.Web.GroupBox()
        Me.RbDescuentoAplicado = New Wisej.Web.RadioButton()
        Me.RbDescuentoVisible = New Wisej.Web.RadioButton()
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
        Me.DGV_Facturas = New Wisej.Web.DataGridView()
        Me.cCHK = New Wisej.Web.DataGridViewCheckBoxColumn()
        Me.cFolio = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.Descuento_Factura = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.Descuento = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colImporte_Total = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.Estatus = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.cSaldo = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.cImporteTotal = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.cFolio_Movimiento = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.cUnitario = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colTipo_Pago = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colFecha1 = New Wisej.Web.DataGridViewDateTimePickerColumn()
        Me.CheckBox1 = New Wisej.Web.CheckBox()
        Me.BindingSource1 = New Wisej.Web.BindingSource(Me.components)
        Me.DataSet_pFACTURACION_CAPTURA_EGRESOS1 = New FactuSax.DataSet_pFACTURACION_CAPTURA_EGRESOS()
        Me.Label3 = New Wisej.Web.Label()
        Me.RDBManual = New Wisej.Web.RadioButton()
        Me.RDBSolicitrud = New Wisej.Web.RadioButton()
        Me.GroupBox5 = New Wisej.Web.GroupBox()
        Me.ErrorProvider1 = New Wisej.Web.ErrorProvider(Me.components)
        Me.Label30 = New Wisej.Web.Label()
        Me.AspPageBox1 = New Wisej.Web.AspNetPanel()
        Me.PFACTURACION_RECEPTOR_PADRE_HIJOTableAdapter = New FactuSax.DataSet_pFACTURACION_RECEPTOR_PADRE_HIJOTableAdapters.pFACTURACION_RECEPTOR_PADRE_HIJOTableAdapter()
        Me.PFACTURACION_CAPTURA_EGRESOSTableAdapter = New FactuSax.DataSet_pFACTURACION_CAPTURA_EGRESOSTableAdapters.pFACTURACION_CAPTURA_EGRESOSTableAdapter()
        Me.CBSTipoComprobante = New FactuSax.ComboWisax()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DGV_Receptor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_Receptor, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_pFACTURACION_RECEPTOR_PADRE_HIJO, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpPersonalizado.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TPCONCEPTO.SuspendLayout()
        CType(Me.DGVConceptos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGV_Facturas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DGV_Facturas.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_pFACTURACION_CAPTURA_EGRESOS1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox5.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonBar7
        '
        Me.RibbonBar7.Cursor = Wisej.Web.Cursors.Arrow
        Me.RibbonBar7.Name = "RibbonBar7"
        Me.RibbonBar7.Pages.Add(Me.RibbonBarPage1)
        Me.RibbonBar7.Size = New System.Drawing.Size(1453, 102)
        '
        'RibbonBarPage1
        '
        Me.RibbonBarPage1.Groups.Add(Me.RibbonBarGroup1)
        Me.RibbonBarPage1.Groups.Add(Me.RibbonBarGroup2)
        Me.RibbonBarPage1.Groups.Add(Me.RibbonBarGroup3)
        Me.RibbonBarPage1.Name = "RibbonBarPage1"
        Me.RibbonBarPage1.Text = "Menú"
        '
        'RibbonBarGroup1
        '
        Me.RibbonBarGroup1.Items.Add(Me.RBBNuevo)
        Me.RibbonBarGroup1.Items.Add(Me.RBBBuscar)
        Me.RibbonBarGroup1.Items.Add(Me.RBBPFacturar)
        Me.RibbonBarGroup1.Items.Add(Me.RBBSerie)
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
        'RibbonBarGroup2
        '
        Me.RibbonBarGroup2.Items.Add(Me.RBBImpuestos)
        Me.RibbonBarGroup2.Name = "RibbonBarGroup2"
        Me.RibbonBarGroup2.Text = "Retenciones"
        '
        'RBBImpuestos
        '
        Me.RBBImpuestos.ImageSource = "Resources\Images\Menu\64\cotizacion.png"
        Me.RBBImpuestos.Name = "RBBImpuestos"
        Me.RBBImpuestos.Text = "Impuestos"
        '
        'RibbonBarGroup3
        '
        Me.RibbonBarGroup3.Items.Add(Me.RBBSalir)
        Me.RibbonBarGroup3.Name = "RibbonBarGroup3"
        Me.RibbonBarGroup3.Text = "Salir"
        '
        'RBBSalir
        '
        Me.RBBSalir.ImageSource = "Resources\Images\Menu\64\exit_sign.png"
        Me.RBBSalir.Name = "RBBSalir"
        Me.RBBSalir.Text = "  "
        '
        'SplitContainer1
        '
        Me.SplitContainer1.AutoValidate = Wisej.Web.AutoValidate.EnablePreventFocusChange
        Me.SplitContainer1.Dock = Wisej.Web.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 102)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DGV_Receptor)
        Me.SplitContainer1.Panel1.Controls.Add(Me.grpPersonalizado)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.TabControl1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.GroupBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1453, 767)
        Me.SplitContainer1.SplitterDistance = 426
        Me.SplitContainer1.TabIndex = 7
        '
        'DGV_Receptor
        '
        Me.DGV_Receptor.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.Column0, Me.cCheckPadre, Me.colRFC, Me.colRazon_Social, Me.colRFCX, Me.colTIPO_PARENT, Me.colChecked})
        Me.DGV_Receptor.DataSource = Me.BS_Receptor
        Me.DGV_Receptor.Dock = Wisej.Web.DockStyle.Fill
        Me.DGV_Receptor.Focusable = False
        Me.DGV_Receptor.Location = New System.Drawing.Point(0, 173)
        Me.DGV_Receptor.Name = "DGV_Receptor"
        Me.DGV_Receptor.RowHeadersVisible = False
        Me.DGV_Receptor.Size = New System.Drawing.Size(424, 592)
        Me.DGV_Receptor.TabIndex = 3
        '
        'Column0
        '
        Me.Column0.HeaderText = "  "
        Me.Column0.Name = "Column0"
        Me.Column0.Width = 35
        '
        'cCheckPadre
        '
        Me.cCheckPadre.HeaderText = "  "
        Me.cCheckPadre.Name = "cCheckPadre"
        Me.cCheckPadre.Width = 30
        '
        'colRFC
        '
        Me.colRFC.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.colRFC.DataPropertyName = "RFC"
        Me.colRFC.HeaderText = "RFC"
        Me.colRFC.Name = "colRFC"
        Me.colRFC.ReadOnly = True
        '
        'colRazon_Social
        '
        Me.colRazon_Social.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.Fill
        Me.colRazon_Social.DataPropertyName = "Razon_Social"
        Me.colRazon_Social.HeaderText = "Razon_Social"
        Me.colRazon_Social.Name = "colRazon_Social"
        Me.colRazon_Social.ReadOnly = True
        '
        'colRFCX
        '
        Me.colRFCX.DataPropertyName = "RFCX"
        Me.colRFCX.HeaderText = "RFCX"
        Me.colRFCX.Name = "colRFCX"
        Me.colRFCX.ReadOnly = True
        Me.colRFCX.Visible = False
        '
        'colTIPO_PARENT
        '
        Me.colTIPO_PARENT.DataPropertyName = "TIPO_PARENT"
        Me.colTIPO_PARENT.HeaderText = "TIPO_PARENT"
        Me.colTIPO_PARENT.Name = "colTIPO_PARENT"
        Me.colTIPO_PARENT.ReadOnly = True
        Me.colTIPO_PARENT.Visible = False
        '
        'colChecked
        '
        Me.colChecked.DataPropertyName = "Checked"
        Me.colChecked.HeaderText = "Checked"
        Me.colChecked.Name = "colChecked"
        Me.colChecked.ReadOnly = True
        Me.colChecked.Visible = False
        '
        'BS_Receptor
        '
        Me.BS_Receptor.DataMember = "pFACTURACION_RECEPTOR_PADRE_HIJO"
        Me.BS_Receptor.DataSource = Me.DataSet_pFACTURACION_RECEPTOR_PADRE_HIJO
        '
        'DataSet_pFACTURACION_RECEPTOR_PADRE_HIJO
        '
        Me.DataSet_pFACTURACION_RECEPTOR_PADRE_HIJO.DataSetName = "DataSet_pFACTURACION_RECEPTOR_PADRE_HIJO"
        Me.DataSet_pFACTURACION_RECEPTOR_PADRE_HIJO.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'grpPersonalizado
        '
        Me.grpPersonalizado.Controls.Add(Me.Chk_SaldoPendiente)
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
        Me.grpPersonalizado.Size = New System.Drawing.Size(424, 173)
        Me.grpPersonalizado.TabIndex = 2
        '
        'Chk_SaldoPendiente
        '
        Me.Chk_SaldoPendiente.Location = New System.Drawing.Point(286, 115)
        Me.Chk_SaldoPendiente.Name = "Chk_SaldoPendiente"
        Me.Chk_SaldoPendiente.Size = New System.Drawing.Size(167, 22)
        Me.Chk_SaldoPendiente.TabIndex = 10
        Me.Chk_SaldoPendiente.Text = "Aplica Saldo Pendiente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Receptor"
        Me.Label2.Visible = False
        '
        'CbxReceptor
        '
        Me.CbxReceptor.Location = New System.Drawing.Point(8, 78)
        Me.CbxReceptor.Name = "CbxReceptor"
        Me.CbxReceptor.TabIndex = 8
        Me.CbxReceptor.Visible = False
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
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TPCONCEPTO)
        Me.TabControl1.Dock = Wisej.Web.DockStyle.Fill
        Me.TabControl1.Location = New System.Drawing.Point(0, 296)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.PageInsets = New Wisej.Web.Padding(1, 35, 1, 1)
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(1019, 295)
        Me.TabControl1.TabIndex = 6
        '
        'TPCONCEPTO
        '
        Me.TPCONCEPTO.Controls.Add(Me.DGVConceptos)
        Me.TPCONCEPTO.Location = New System.Drawing.Point(1, 35)
        Me.TPCONCEPTO.Name = "TPCONCEPTO"
        Me.TPCONCEPTO.Size = New System.Drawing.Size(1017, 259)
        Me.TPCONCEPTO.Text = "CONCEPTO"
        '
        'DGVConceptos
        '
        Me.DGVConceptos.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.dgvEliminar, Me.cCantidad, Me.cbClaveProdServ, Me.cbClaveUnidad, Me.cDescripcion, Me.cValorUnitario, Me.cImporte, Me.cDescuento, Me.cNoIdentificacion})
        Me.DGVConceptos.Dock = Wisej.Web.DockStyle.Fill
        Me.DGVConceptos.Location = New System.Drawing.Point(0, 0)
        Me.DGVConceptos.Name = "DGVConceptos"
        Me.DGVConceptos.Size = New System.Drawing.Size(1017, 259)
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
        Me.cbClaveProdServ.HeaderText = "Clave Servicio"
        Me.cbClaveProdServ.Name = "cbClaveProdServ"
        '
        'cbClaveUnidad
        '
        Me.cbClaveUnidad.HeaderText = "Unidad"
        Me.cbClaveUnidad.Name = "cbClaveUnidad"
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
        Me.Panel3.Location = New System.Drawing.Point(0, 591)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1019, 174)
        Me.Panel3.TabIndex = 7
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
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.RbDescuentoAplicado)
        Me.Panel2.Controls.Add(Me.RbDescuentoVisible)
        Me.Panel2.Dock = Wisej.Web.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 244)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1019, 52)
        Me.Panel2.TabIndex = 5
        '
        'RbDescuentoAplicado
        '
        Me.RbDescuentoAplicado.Location = New System.Drawing.Point(155, 21)
        Me.RbDescuentoAplicado.Name = "RbDescuentoAplicado"
        Me.RbDescuentoAplicado.Size = New System.Drawing.Size(148, 22)
        Me.RbDescuentoAplicado.TabIndex = 1
        Me.RbDescuentoAplicado.Text = "Descuento Aplicado"
        '
        'RbDescuentoVisible
        '
        Me.RbDescuentoVisible.Anchor = Wisej.Web.AnchorStyles.Left
        Me.RbDescuentoVisible.Checked = True
        Me.RbDescuentoVisible.Location = New System.Drawing.Point(6, 21)
        Me.RbDescuentoVisible.Name = "RbDescuentoVisible"
        Me.RbDescuentoVisible.Size = New System.Drawing.Size(137, 22)
        Me.RbDescuentoVisible.TabIndex = 0
        Me.RbDescuentoVisible.TabStop = True
        Me.RbDescuentoVisible.Text = "Descuento Visible"
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
        Me.SplitContainer2.Size = New System.Drawing.Size(1019, 94)
        Me.SplitContainer2.SplitterDistance = 498
        Me.SplitContainer2.TabIndex = 1
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.CBEmisor)
        Me.GroupBox3.Controls.Add(Me.BTEm)
        Me.GroupBox3.Dock = Wisej.Web.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(496, 92)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.Text = "Emisor"
        '
        'CBEmisor
        '
        Me.CBEmisor.BackColor = System.Drawing.Color.Transparent
        Me.CBEmisor.Cursor = Wisej.Web.Cursors.Hand
        Me.CBEmisor.Location = New System.Drawing.Point(8, 19)
        Me.CBEmisor.Name = "CBEmisor"
        Me.CBEmisor.Size = New System.Drawing.Size(431, 22)
        Me.CBEmisor.TabIndex = 0
        '
        'BTEm
        '
        Me.BTEm.Location = New System.Drawing.Point(445, 17)
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
        Me.GroupBox4.Size = New System.Drawing.Size(513, 92)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.Text = "Receptor"
        '
        'CBSReceptor
        '
        Me.CBSReceptor.BackColor = System.Drawing.Color.Transparent
        Me.CBSReceptor.Cursor = Wisej.Web.Cursors.Hand
        Me.CBSReceptor.Location = New System.Drawing.Point(9, 19)
        Me.CBSReceptor.Name = "CBSReceptor"
        Me.CBSReceptor.Size = New System.Drawing.Size(431, 22)
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
        Me.BTRec.Location = New System.Drawing.Point(446, 17)
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
        Me.GroupBox1.Size = New System.Drawing.Size(1019, 150)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.Text = "Informacion Basica"
        '
        'MaskedTextBox2
        '
        Me.MaskedTextBox2.Location = New System.Drawing.Point(180, 28)
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
        Me.DTPFechaEmision.Location = New System.Drawing.Point(101, 28)
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
        Me.TBTipoCambio.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(313, 63)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(96, 15)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "Tipo de Cambio"
        Me.Label20.Visible = False
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
        Me.CBSMetodoPago.Location = New System.Drawing.Point(332, 26)
        Me.CBSMetodoPago.Name = "CBSMetodoPago"
        Me.CBSMetodoPago.Size = New System.Drawing.Size(283, 22)
        Me.CBSMetodoPago.TabIndex = 7
        '
        'CBSFormaPago
        '
        Me.CBSFormaPago.BackColor = System.Drawing.Color.Transparent
        Me.CBSFormaPago.Cursor = Wisej.Web.Cursors.Hand
        Me.CBSFormaPago.Location = New System.Drawing.Point(718, 26)
        Me.CBSFormaPago.Name = "CBSFormaPago"
        Me.CBSFormaPago.Size = New System.Drawing.Size(202, 22)
        Me.CBSFormaPago.TabIndex = 6
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(228, 33)
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
        Me.Label4.Location = New System.Drawing.Point(621, 31)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(94, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Forma de Pago"
        '
        'DGV_Facturas
        '
        Me.DGV_Facturas.AllowUserToResizeColumns = False
        Me.DGV_Facturas.AllowUserToResizeRows = False
        Me.DGV_Facturas.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black
        Me.DGV_Facturas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Facturas.ColumnHeadersHeight = 20
        Me.DGV_Facturas.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.cCHK, Me.cFolio, Me.DataGridViewTextBoxColumn3, Me.Descuento_Factura, Me.Descuento, Me.colImporte_Total, Me.Estatus, Me.cSaldo, Me.cImporteTotal, Me.cFolio_Movimiento, Me.cUnitario, Me.colTipo_Pago, Me.colFecha1})
        Me.DGV_Facturas.Controls.Add(Me.CheckBox1)
        Me.DGV_Facturas.DataSource = Me.BindingSource1
        Me.DGV_Facturas.Location = New System.Drawing.Point(1078, 15)
        Me.DGV_Facturas.Name = "DGV_Facturas"
        Me.DGV_Facturas.RowHeadersVisible = False
        Me.DGV_Facturas.RowHeadersWidth = 20
        Me.DGV_Facturas.RowTemplate.Height = 20
        Me.DGV_Facturas.Size = New System.Drawing.Size(298, 434)
        Me.DGV_Facturas.TabIndex = 0
        Me.DGV_Facturas.Visible = False
        '
        'cCHK
        '
        Me.cCHK.DataPropertyName = "Checked"
        DataGridViewCellStyle2.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.NullValue = False
        Me.cCHK.DefaultCellStyle = DataGridViewCellStyle2
        Me.cCHK.HeaderText = "      "
        Me.cCHK.Name = "cCHK"
        Me.cCHK.Width = 35
        '
        'cFolio
        '
        Me.cFolio.DataPropertyName = "Folio"
        Me.cFolio.HeaderText = "Folio"
        Me.cFolio.Name = "cFolio"
        Me.cFolio.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Cve_Receptor"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Cliente"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.ReadOnly = True
        Me.DataGridViewTextBoxColumn3.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.DataGridViewTextBoxColumn3.Visible = False
        '
        'Descuento_Factura
        '
        Me.Descuento_Factura.DataPropertyName = "Descuento_Factura"
        Me.Descuento_Factura.HeaderText = "Descuento"
        Me.Descuento_Factura.Name = "Descuento_Factura"
        Me.Descuento_Factura.ReadOnly = True
        Me.Descuento_Factura.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        '
        'Descuento
        '
        Me.Descuento.DataPropertyName = "Descuento"
        Me.Descuento.HeaderText = "Descuento"
        Me.Descuento.Name = "Descuento"
        Me.Descuento.ReadOnly = True
        Me.Descuento.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.Descuento.Visible = False
        '
        'colImporte_Total
        '
        Me.colImporte_Total.DataPropertyName = "Importe_Total"
        Me.colImporte_Total.HeaderText = "Importe Total"
        Me.colImporte_Total.Name = "colImporte_Total"
        Me.colImporte_Total.ReadOnly = True
        Me.colImporte_Total.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        '
        'Estatus
        '
        Me.Estatus.DataPropertyName = "Estatus"
        Me.Estatus.HeaderText = "Estatus"
        Me.Estatus.Name = "Estatus"
        Me.Estatus.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.Estatus.Visible = False
        '
        'cSaldo
        '
        Me.cSaldo.DataPropertyName = "Saldo"
        Me.cSaldo.HeaderText = "Saldo"
        Me.cSaldo.Name = "cSaldo"
        Me.cSaldo.ReadOnly = True
        Me.cSaldo.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        '
        'cImporteTotal
        '
        Me.cImporteTotal.DataPropertyName = "IMPORTE"
        Me.cImporteTotal.HeaderText = "Importe"
        Me.cImporteTotal.Name = "cImporteTotal"
        Me.cImporteTotal.ReadOnly = True
        Me.cImporteTotal.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.cImporteTotal.Visible = False
        '
        'cFolio_Movimiento
        '
        Me.cFolio_Movimiento.DataPropertyName = "Folio_Movimiento"
        Me.cFolio_Movimiento.HeaderText = "cFolio_Movimiento"
        Me.cFolio_Movimiento.Name = "cFolio_Movimiento"
        Me.cFolio_Movimiento.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.cFolio_Movimiento.Visible = False
        '
        'cUnitario
        '
        Me.cUnitario.DataPropertyName = "Unitario"
        Me.cUnitario.HeaderText = "Unitario"
        Me.cUnitario.Name = "cUnitario"
        Me.cUnitario.ReadOnly = True
        Me.cUnitario.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.cUnitario.Visible = False
        '
        'colTipo_Pago
        '
        Me.colTipo_Pago.DataPropertyName = "Tipo_Pago"
        Me.colTipo_Pago.HeaderText = "Tipo de Pago"
        Me.colTipo_Pago.Name = "colTipo_Pago"
        Me.colTipo_Pago.ReadOnly = True
        '
        'colFecha1
        '
        Me.colFecha1.DataPropertyName = "Fecha1"
        DataGridViewCellStyle3.Format = "G"
        Me.colFecha1.DefaultCellStyle = DataGridViewCellStyle3
        Me.colFecha1.HeaderText = "Fecha1"
        Me.colFecha1.Name = "colFecha1"
        Me.colFecha1.Visible = False
        '
        'CheckBox1
        '
        Me.CheckBox1.Location = New System.Drawing.Point(4, 3)
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
        'PFACTURACION_RECEPTOR_PADRE_HIJOTableAdapter
        '
        Me.PFACTURACION_RECEPTOR_PADRE_HIJOTableAdapter.ClearBeforeFill = True
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
        Me.ClientSize = New System.Drawing.Size(1453, 869)
        Me.Controls.Add(Me.DGV_Facturas)
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
        CType(Me.DGV_Receptor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_Receptor, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_pFACTURACION_RECEPTOR_PADRE_HIJO, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpPersonalizado.ResumeLayout(False)
        Me.grpPersonalizado.PerformLayout()
        Me.TabControl1.ResumeLayout(False)
        Me.TPCONCEPTO.ResumeLayout(False)
        CType(Me.DGVConceptos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGV_Facturas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DGV_Facturas.ResumeLayout(False)
        Me.DGV_Facturas.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_pFACTURACION_CAPTURA_EGRESOS1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonBar7 As Ext.RibbonBar.RibbonBar
    Friend WithEvents SplitContainer1 As SplitContainer
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
    Friend WithEvents DGV_Facturas As Wisej.Web.DataGridView
    Friend WithEvents BTEm As Button
    Friend WithEvents CBSUsoCFDI As ComboWisax
    Friend WithEvents Label17 As Label
    Friend WithEvents BTRec As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents RDBManual As RadioButton
    Friend WithEvents RDBSolicitrud As RadioButton
    Friend WithEvents GroupBox5 As GroupBox
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
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents cCHK As DataGridViewCheckBoxColumn
    Friend WithEvents Descuento_Factura As DataGridViewTextBoxColumn
    Friend WithEvents TBTipoCambio As TextBox
    Friend WithEvents Label20 As Label
    Friend WithEvents RTBCondicionPago As TextBox
    Friend WithEvents Label22 As Label
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
    Friend WithEvents RibbonBarGroup2 As Ext.RibbonBar.RibbonBarGroup
    Friend WithEvents RBBImpuestos As Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents RibbonBarGroup3 As Ext.RibbonBar.RibbonBarGroup
    Friend WithEvents RBBSalir As Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents RbDescuentoAplicado As RadioButton
    Friend WithEvents RbDescuentoVisible As RadioButton
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TPCONCEPTO As TabPage
    Friend WithEvents DGVConceptos As DataGridView
    Friend WithEvents dgvEliminar As DataGridViewImageColumn
    Friend WithEvents cCantidad As DataGridViewTextBoxColumn
    Friend WithEvents cDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents cValorUnitario As DataGridViewTextBoxColumn
    Friend WithEvents cImporte As DataGridViewTextBoxColumn
    Friend WithEvents cDescuento As DataGridViewTextBoxColumn
    Friend WithEvents cNoIdentificacion As DataGridViewTextBoxColumn
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
    Friend WithEvents Panel2 As GroupBox
    Friend WithEvents DGV_Receptor As DataGridView
    Public WithEvents Column0 As DataGridViewTextBoxColumn
    Friend WithEvents DataSet_pFACTURACION_RECEPTOR_PADRE_HIJO As DataSet_pFACTURACION_RECEPTOR_PADRE_HIJO
    Friend WithEvents PFACTURACION_RECEPTOR_PADRE_HIJOTableAdapter As DataSet_pFACTURACION_RECEPTOR_PADRE_HIJOTableAdapters.pFACTURACION_RECEPTOR_PADRE_HIJOTableAdapter
    Friend WithEvents BS_Receptor As BindingSource
    Friend WithEvents colRFC As DataGridViewTextBoxColumn
    Friend WithEvents colRazon_Social As DataGridViewTextBoxColumn
    Friend WithEvents colRFCX As DataGridViewTextBoxColumn
    Friend WithEvents colTIPO_PARENT As DataGridViewTextBoxColumn
    Friend WithEvents cCheckPadre As DataGridViewCheckBoxColumn
    Friend WithEvents Chk_SaldoPendiente As CheckBox
    Friend WithEvents colChecked As DataGridViewTextBoxColumn
    Friend WithEvents cbClaveProdServ As DataGridViewComboBoxColumn
    Friend WithEvents cbClaveUnidad As DataGridViewComboBoxColumn
    Friend WithEvents colImporte_Total As DataGridViewTextBoxColumn
    Friend WithEvents colTipo_Pago As DataGridViewTextBoxColumn
    Friend WithEvents colFecha1 As DataGridViewDateTimePickerColumn
End Class