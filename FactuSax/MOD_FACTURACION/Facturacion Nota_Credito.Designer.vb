

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Facturacion_Nota_Credito
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
        Me.RBBConsultar = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBBFactura = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBBSalir = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.SplitContainer1 = New Wisej.Web.SplitContainer()
        Me.DGVUUID = New Wisej.Web.DataGridView()
        Me.DataGridViewImageColumn1 = New Wisej.Web.DataGridViewImageColumn()
        Me.colFOLIO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colUUID = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colFECHA = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colCONDICIONESPAGO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colSALDO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.BindingSource1 = New Wisej.Web.BindingSource(Me.components)
        Me.DataSet_pFACTURA_SAT_CFDI_PAGOS_B = New FactuSax.DataSet_pFACTURA_SAT_CFDI_PAGOS_B()
        Me.pserie = New Wisej.Web.Panel()
        Me.TextBox1 = New Wisej.Web.TextBox()
        Me.Label2 = New Wisej.Web.Label()
        Me.pfECHA = New Wisej.Web.Panel()
        Me.Label10 = New Wisej.Web.Label()
        Me.CbxClientes = New FactuSax.ComboWisax()
        Me.Label19 = New Wisej.Web.Label()
        Me.cFecha2 = New Wisej.Web.DateTimePicker()
        Me.cFecha1 = New Wisej.Web.DateTimePicker()
        Me.Label18 = New Wisej.Web.Label()
        Me.Panel3 = New Wisej.Web.Panel()
        Me.GroupBox1 = New Wisej.Web.GroupBox()
        Me.RBFolio = New Wisej.Web.RadioButton()
        Me.RBFecha = New Wisej.Web.RadioButton()
        Me.DGVConceptos = New Wisej.Web.DataGridView()
        Me.cCantidad = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.cbClaveProdServ = New Wisej.Web.DataGridViewComboBoxColumn()
        Me.cbClaveUnidad = New Wisej.Web.DataGridViewComboBoxColumn()
        Me.cDescripcion = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.cValorUnitario = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.cImporte = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.cDescuento = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.cNoIdentificacion = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.Panel4 = New Wisej.Web.Panel()
        Me.Label33 = New Wisej.Web.Label()
        Me.TBDescuento = New Wisej.Web.TextBox()
        Me.TBTotal = New Wisej.Web.TextBox()
        Me.TBRISR = New Wisej.Web.TextBox()
        Me.TBRIVA = New Wisej.Web.TextBox()
        Me.TBIva = New Wisej.Web.TextBox()
        Me.TBSubTotal = New Wisej.Web.TextBox()
        Me.Label28 = New Wisej.Web.Label()
        Me.Label29 = New Wisej.Web.Label()
        Me.Label30 = New Wisej.Web.Label()
        Me.Label31 = New Wisej.Web.Label()
        Me.Label32 = New Wisej.Web.Label()
        Me.Panel2 = New Wisej.Web.Panel()
        Me.SplitContainer2 = New Wisej.Web.SplitContainer()
        Me.GroupBox3 = New Wisej.Web.GroupBox()
        Me.CBEmisor = New FactuSax.ComboWisax()
        Me.BTEm = New Wisej.Web.Button()
        Me.GroupBox4 = New Wisej.Web.GroupBox()
        Me.Label17 = New Wisej.Web.Label()
        Me.CBSReceptor = New FactuSax.ComboWisax()
        Me.CBSUsoCFDI = New FactuSax.ComboWisax()
        Me.BTRec = New Wisej.Web.Button()
        Me.Panel6 = New Wisej.Web.Panel()
        Me.CBS_TipoRelacion = New FactuSax.ComboWisax()
        Me.Label12 = New Wisej.Web.Label()
        Me.RTBObservaciones = New Wisej.Web.TextBox()
        Me.Label1 = New Wisej.Web.Label()
        Me.CBSFormaPago = New FactuSax.ComboWisax()
        Me.CBSTipoComprobante = New FactuSax.ComboWisax()
        Me.MTBHoraPago = New Wisej.Web.MaskedTextBox()
        Me.MTBHoraEmision = New Wisej.Web.MaskedTextBox()
        Me.Label8 = New Wisej.Web.Label()
        Me.CBSMoneda = New FactuSax.ComboWisax()
        Me.Label6 = New Wisej.Web.Label()
        Me.Label5 = New Wisej.Web.Label()
        Me.DTPFechaPago = New Wisej.Web.DateTimePicker()
        Me.Label7 = New Wisej.Web.Label()
        Me.MTBCP = New Wisej.Web.MaskedTextBox()
        Me.Label4 = New Wisej.Web.Label()
        Me.Label3 = New Wisej.Web.Label()
        Me.DTPFechaEmision = New Wisej.Web.DateTimePicker()
        Me.ErrorProvider1 = New Wisej.Web.ErrorProvider(Me.components)
        Me.Label20 = New Wisej.Web.Label()
        Me.PFACTURA_SAT_CFDI_PAGOS_BTableAdapter = New FactuSax.DataSet_pFACTURA_SAT_CFDI_PAGOS_BTableAdapters.pFACTURA_SAT_CFDI_PAGOS_BTableAdapter()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DGVUUID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_pFACTURA_SAT_CFDI_PAGOS_B, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pserie.SuspendLayout()
        Me.pfECHA.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DGVConceptos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonBar7
        '
        Me.RibbonBar7.Cursor = Wisej.Web.Cursors.Arrow
        Me.RibbonBar7.Name = "RibbonBar7"
        Me.RibbonBar7.Pages.Add(Me.RibbonBarPage1)
        Me.RibbonBar7.Size = New System.Drawing.Size(1192, 81)
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
        Me.RibbonBarGroup1.Items.Add(Me.RBBConsultar)
        Me.RibbonBarGroup1.Items.Add(Me.RBBFactura)
        Me.RibbonBarGroup1.Items.Add(Me.RBBSalir)
        Me.RibbonBarGroup1.Name = "RibbonBarGroup1"
        '
        'RBBNuevo
        '
        Me.RBBNuevo.ImageSource = "Resources\Images\Menu\64\Add List Filled-64.png"
        Me.RBBNuevo.Name = "RBBNuevo"
        Me.RBBNuevo.Text = "Nuevo"
        '
        'RBBConsultar
        '
        Me.RBBConsultar.ImageSource = "Resources\Images\Menu\64\lupa.png"
        Me.RBBConsultar.Name = "RBBConsultar"
        Me.RBBConsultar.Text = "Consultar"
        '
        'RBBFactura
        '
        Me.RBBFactura.ImageSource = "Resources\Images\Menu\64\factura.png"
        Me.RBBFactura.Name = "RBBFactura"
        Me.RBBFactura.Text = "Factura"
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
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 81)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.DGVUUID)
        Me.SplitContainer1.Panel1.Controls.Add(Me.pserie)
        Me.SplitContainer1.Panel1.Controls.Add(Me.pfECHA)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel3)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DGVConceptos)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel4)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1192, 787)
        Me.SplitContainer1.SplitterDistance = 371
        Me.SplitContainer1.TabIndex = 7
        '
        'DGVUUID
        '
        Me.DGVUUID.AllowUserToResizeColumns = False
        Me.DGVUUID.AllowUserToResizeRows = False
        Me.DGVUUID.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.DataGridViewImageColumn1, Me.colFOLIO, Me.colUUID, Me.colFECHA, Me.colCONDICIONESPAGO, Me.colSALDO})
        Me.DGVUUID.DataSource = Me.BindingSource1
        Me.DGVUUID.Dock = Wisej.Web.DockStyle.Fill
        Me.DGVUUID.Location = New System.Drawing.Point(0, 238)
        Me.DGVUUID.Name = "DGVUUID"
        Me.DGVUUID.RowHeadersVisible = False
        Me.DGVUUID.Size = New System.Drawing.Size(369, 547)
        Me.DGVUUID.TabIndex = 1
        '
        'DataGridViewImageColumn1
        '
        Me.DataGridViewImageColumn1.CellImageAlignment = Wisej.Web.DataGridViewContentAlignment.NotSet
        DataGridViewCellStyle1.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.NullValue = Nothing
        Me.DataGridViewImageColumn1.DefaultCellStyle = DataGridViewCellStyle1
        Me.DataGridViewImageColumn1.HeaderText = "   "
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Width = 40
        '
        'colFOLIO
        '
        Me.colFOLIO.DataPropertyName = "FOLIO"
        Me.colFOLIO.HeaderText = "FOLIO"
        Me.colFOLIO.Name = "colFOLIO"
        Me.colFOLIO.ReadOnly = True
        '
        'colUUID
        '
        Me.colUUID.DataPropertyName = "UUID"
        Me.colUUID.HeaderText = "UUID"
        Me.colUUID.Name = "colUUID"
        '
        'colFECHA
        '
        Me.colFECHA.DataPropertyName = "FECHA"
        Me.colFECHA.HeaderText = "FECHA"
        Me.colFECHA.Name = "colFECHA"
        '
        'colCONDICIONESPAGO
        '
        Me.colCONDICIONESPAGO.DataPropertyName = "CONDICIONESPAGO"
        Me.colCONDICIONESPAGO.HeaderText = "CONDICIONESPAGO"
        Me.colCONDICIONESPAGO.Name = "colCONDICIONESPAGO"
        '
        'colSALDO
        '
        Me.colSALDO.DataPropertyName = "SALDO"
        Me.colSALDO.HeaderText = "SALDO"
        Me.colSALDO.Name = "colSALDO"
        Me.colSALDO.ReadOnly = True
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "pFACTURA_SAT_CFDI_PAGOS_B"
        Me.BindingSource1.DataSource = Me.DataSet_pFACTURA_SAT_CFDI_PAGOS_B
        '
        'DataSet_pFACTURA_SAT_CFDI_PAGOS_B
        '
        Me.DataSet_pFACTURA_SAT_CFDI_PAGOS_B.DataSetName = "DataSet_pFACTURA_SAT_CFDI_PAGOS_B"
        Me.DataSet_pFACTURA_SAT_CFDI_PAGOS_B.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'pserie
        '
        Me.pserie.Controls.Add(Me.TextBox1)
        Me.pserie.Controls.Add(Me.Label2)
        Me.pserie.Dock = Wisej.Web.DockStyle.Top
        Me.pserie.Location = New System.Drawing.Point(0, 145)
        Me.pserie.Name = "pserie"
        Me.pserie.Size = New System.Drawing.Size(369, 93)
        Me.pserie.TabIndex = 0
        Me.pserie.TabStop = True
        Me.pserie.Visible = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(9, 22)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(354, 22)
        Me.TextBox1.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 6)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Serie"
        '
        'pfECHA
        '
        Me.pfECHA.Controls.Add(Me.Label10)
        Me.pfECHA.Controls.Add(Me.CbxClientes)
        Me.pfECHA.Controls.Add(Me.Label19)
        Me.pfECHA.Controls.Add(Me.cFecha2)
        Me.pfECHA.Controls.Add(Me.cFecha1)
        Me.pfECHA.Controls.Add(Me.Label18)
        Me.pfECHA.Dock = Wisej.Web.DockStyle.Top
        Me.pfECHA.Location = New System.Drawing.Point(0, 44)
        Me.pfECHA.Name = "pfECHA"
        Me.pfECHA.Size = New System.Drawing.Size(369, 101)
        Me.pfECHA.TabIndex = 0
        Me.pfECHA.TabStop = True
        Me.pfECHA.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(12, 9)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(45, 15)
        Me.Label10.TabIndex = 7
        Me.Label10.Text = "Cliente"
        '
        'CbxClientes
        '
        Me.CbxClientes.Location = New System.Drawing.Point(12, 25)
        Me.CbxClientes.Name = "CbxClientes"
        Me.CbxClientes.TabIndex = 6
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(161, 59)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(23, 15)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Fin"
        '
        'cFecha2
        '
        Me.cFecha2.CustomFormat = "dd/MM/yyyy"
        Me.cFecha2.Format = Wisej.Web.DateTimePickerFormat.Custom
        Me.cFecha2.Location = New System.Drawing.Point(182, 55)
        Me.cFecha2.Name = "cFecha2"
        Me.cFecha2.Size = New System.Drawing.Size(103, 22)
        Me.cFecha2.TabIndex = 0
        Me.cFecha2.Value = New Date(2010, 5, 4, 18, 20, 0, 0)
        '
        'cFecha1
        '
        Me.cFecha1.CustomFormat = "dd/MM/yyyy"
        Me.cFecha1.Format = Wisej.Web.DateTimePickerFormat.Custom
        Me.cFecha1.Location = New System.Drawing.Point(44, 55)
        Me.cFecha1.Name = "cFecha1"
        Me.cFecha1.Size = New System.Drawing.Size(103, 22)
        Me.cFecha1.TabIndex = 0
        Me.cFecha1.Value = New Date(2010, 5, 4, 18, 20, 0, 0)
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(12, 59)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(35, 15)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Inicio"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Dock = Wisej.Web.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(369, 44)
        Me.Panel3.TabIndex = 0
        Me.Panel3.TabStop = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.RBFolio)
        Me.GroupBox1.Controls.Add(Me.RBFecha)
        Me.GroupBox1.Dock = Wisej.Web.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(369, 44)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.Text = "Filtro"
        '
        'RBFolio
        '
        Me.RBFolio.Location = New System.Drawing.Point(208, 17)
        Me.RBFolio.Name = "RBFolio"
        Me.RBFolio.Size = New System.Drawing.Size(63, 22)
        Me.RBFolio.TabIndex = 0
        Me.RBFolio.Text = "Serie"
        '
        'RBFecha
        '
        Me.RBFecha.Location = New System.Drawing.Point(15, 17)
        Me.RBFecha.Name = "RBFecha"
        Me.RBFecha.Size = New System.Drawing.Size(69, 22)
        Me.RBFecha.TabIndex = 0
        Me.RBFecha.Text = "Fecha"
        '
        'DGVConceptos
        '
        Me.DGVConceptos.AllowUserToResizeRows = False
        Me.DGVConceptos.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.cCantidad, Me.cbClaveProdServ, Me.cbClaveUnidad, Me.cDescripcion, Me.cValorUnitario, Me.cImporte, Me.cDescuento, Me.cNoIdentificacion})
        Me.DGVConceptos.Dock = Wisej.Web.DockStyle.Fill
        Me.DGVConceptos.Location = New System.Drawing.Point(0, 281)
        Me.DGVConceptos.Name = "DGVConceptos"
        Me.DGVConceptos.Size = New System.Drawing.Size(813, 330)
        Me.DGVConceptos.TabIndex = 3
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
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.Label33)
        Me.Panel4.Controls.Add(Me.TBDescuento)
        Me.Panel4.Controls.Add(Me.TBTotal)
        Me.Panel4.Controls.Add(Me.TBRISR)
        Me.Panel4.Controls.Add(Me.TBRIVA)
        Me.Panel4.Controls.Add(Me.TBIva)
        Me.Panel4.Controls.Add(Me.TBSubTotal)
        Me.Panel4.Controls.Add(Me.Label28)
        Me.Panel4.Controls.Add(Me.Label29)
        Me.Panel4.Controls.Add(Me.Label30)
        Me.Panel4.Controls.Add(Me.Label31)
        Me.Panel4.Controls.Add(Me.Label32)
        Me.Panel4.Dock = Wisej.Web.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(0, 611)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(813, 174)
        Me.Panel4.TabIndex = 4
        Me.Panel4.TabStop = True
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
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Location = New System.Drawing.Point(8, 141)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(33, 15)
        Me.Label28.TabIndex = 0
        Me.Label28.Text = "Total"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(8, 115)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(106, 15)
        Me.Label29.TabIndex = 0
        Me.Label29.Text = "Retencion de ISR"
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(8, 89)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(106, 15)
        Me.Label30.TabIndex = 0
        Me.Label30.Text = "Retencion de IVA"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(8, 63)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(25, 15)
        Me.Label31.TabIndex = 0
        Me.Label31.Text = "IVA"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(8, 11)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(52, 15)
        Me.Label32.TabIndex = 0
        Me.Label32.Text = "Subtotal"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.SplitContainer2)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Dock = Wisej.Web.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(813, 281)
        Me.Panel2.TabIndex = 0
        Me.Panel2.TabStop = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.AutoValidate = Wisej.Web.AutoValidate.EnablePreventFocusChange
        Me.SplitContainer2.Dock = Wisej.Web.DockStyle.Top
        Me.SplitContainer2.FixedPanel = Wisej.Web.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 186)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.GroupBox3)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.GroupBox4)
        Me.SplitContainer2.Size = New System.Drawing.Size(813, 82)
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
        Me.GroupBox3.Size = New System.Drawing.Size(414, 80)
        Me.GroupBox3.TabIndex = 10
        Me.GroupBox3.Text = "Emisor"
        '
        'CBEmisor
        '
        Me.CBEmisor.BackColor = System.Drawing.Color.Transparent
        Me.CBEmisor.Cursor = Wisej.Web.Cursors.Hand
        Me.CBEmisor.Location = New System.Drawing.Point(3, 19)
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
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label17)
        Me.GroupBox4.Controls.Add(Me.CBSReceptor)
        Me.GroupBox4.Controls.Add(Me.CBSUsoCFDI)
        Me.GroupBox4.Controls.Add(Me.BTRec)
        Me.GroupBox4.Dock = Wisej.Web.DockStyle.Fill
        Me.GroupBox4.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(389, 80)
        Me.GroupBox4.TabIndex = 5
        Me.GroupBox4.Text = "Receptor"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(6, 48)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(62, 15)
        Me.Label17.TabIndex = 3
        Me.Label17.Text = "Uso CFDI"
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
        Me.CBSUsoCFDI.Location = New System.Drawing.Point(68, 44)
        Me.CBSUsoCFDI.Name = "CBSUsoCFDI"
        Me.CBSUsoCFDI.Size = New System.Drawing.Size(311, 22)
        Me.CBSUsoCFDI.TabIndex = 4
        '
        'BTRec
        '
        Me.BTRec.Location = New System.Drawing.Point(373, 17)
        Me.BTRec.Name = "BTRec"
        Me.BTRec.Size = New System.Drawing.Size(33, 23)
        Me.BTRec.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.CBS_TipoRelacion)
        Me.Panel6.Controls.Add(Me.Label12)
        Me.Panel6.Controls.Add(Me.RTBObservaciones)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.CBSFormaPago)
        Me.Panel6.Controls.Add(Me.CBSTipoComprobante)
        Me.Panel6.Controls.Add(Me.MTBHoraPago)
        Me.Panel6.Controls.Add(Me.MTBHoraEmision)
        Me.Panel6.Controls.Add(Me.Label8)
        Me.Panel6.Controls.Add(Me.CBSMoneda)
        Me.Panel6.Controls.Add(Me.Label6)
        Me.Panel6.Controls.Add(Me.Label5)
        Me.Panel6.Controls.Add(Me.DTPFechaPago)
        Me.Panel6.Controls.Add(Me.Label7)
        Me.Panel6.Controls.Add(Me.MTBCP)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.DTPFechaEmision)
        Me.Panel6.Dock = Wisej.Web.DockStyle.Top
        Me.Panel6.Location = New System.Drawing.Point(0, 0)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(813, 186)
        Me.Panel6.TabIndex = 2
        Me.Panel6.TabStop = True
        '
        'CBS_TipoRelacion
        '
        Me.CBS_TipoRelacion.BackColor = System.Drawing.Color.Transparent
        Me.CBS_TipoRelacion.Cursor = Wisej.Web.Cursors.Hand
        Me.CBS_TipoRelacion.Location = New System.Drawing.Point(93, 99)
        Me.CBS_TipoRelacion.Name = "CBS_TipoRelacion"
        Me.CBS_TipoRelacion.Size = New System.Drawing.Size(714, 22)
        Me.CBS_TipoRelacion.TabIndex = 12
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(5, 103)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(84, 15)
        Me.Label12.TabIndex = 3
        Me.Label12.Text = "Tipo Relacion"
        '
        'RTBObservaciones
        '
        Me.RTBObservaciones.AutoSize = False
        Me.RTBObservaciones.Location = New System.Drawing.Point(96, 127)
        Me.RTBObservaciones.Name = "RTBObservaciones"
        Me.RTBObservaciones.Size = New System.Drawing.Size(710, 53)
        Me.RTBObservaciones.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Observaciones"
        '
        'CBSFormaPago
        '
        Me.CBSFormaPago.BackColor = System.Drawing.Color.Transparent
        Me.CBSFormaPago.Cursor = Wisej.Web.Cursors.Hand
        Me.CBSFormaPago.Location = New System.Drawing.Point(319, 44)
        Me.CBSFormaPago.Name = "CBSFormaPago"
        Me.CBSFormaPago.Size = New System.Drawing.Size(474, 22)
        Me.CBSFormaPago.TabIndex = 12
        '
        'CBSTipoComprobante
        '
        Me.CBSTipoComprobante.BackColor = System.Drawing.Color.Transparent
        Me.CBSTipoComprobante.Cursor = Wisej.Web.Cursors.Hand
        Me.CBSTipoComprobante.Enabled = False
        Me.CBSTipoComprobante.Location = New System.Drawing.Point(345, 13)
        Me.CBSTipoComprobante.Name = "CBSTipoComprobante"
        Me.CBSTipoComprobante.Size = New System.Drawing.Size(245, 22)
        Me.CBSTipoComprobante.TabIndex = 11
        '
        'MTBHoraPago
        '
        Me.MTBHoraPago.Location = New System.Drawing.Point(187, 47)
        Me.MTBHoraPago.Mask = "00:00"
        Me.MTBHoraPago.Name = "MTBHoraPago"
        Me.MTBHoraPago.Size = New System.Drawing.Size(40, 22)
        Me.MTBHoraPago.TabIndex = 10
        Me.MTBHoraPago.Text = "1200"
        '
        'MTBHoraEmision
        '
        Me.MTBHoraEmision.Location = New System.Drawing.Point(187, 14)
        Me.MTBHoraEmision.Mask = "00:00"
        Me.MTBHoraEmision.Name = "MTBHoraEmision"
        Me.MTBHoraEmision.Size = New System.Drawing.Size(40, 22)
        Me.MTBHoraEmision.TabIndex = 10
        Me.MTBHoraEmision.Text = "1200"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(5, 73)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 15)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Moneda"
        '
        'CBSMoneda
        '
        Me.CBSMoneda.BackColor = System.Drawing.Color.Transparent
        Me.CBSMoneda.Cursor = Wisej.Web.Cursors.Hand
        Me.CBSMoneda.Location = New System.Drawing.Point(93, 70)
        Me.CBSMoneda.Name = "CBSMoneda"
        Me.CBSMoneda.Size = New System.Drawing.Size(714, 22)
        Me.CBSMoneda.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(234, 50)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(76, 15)
        Me.Label6.TabIndex = 3
        Me.Label6.Text = "Forma Pago"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(5, 50)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 15)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Fecha Pago"
        '
        'DTPFechaPago
        '
        Me.DTPFechaPago.CustomFormat = "dd/MM/yyyy"
        Me.DTPFechaPago.Format = Wisej.Web.DateTimePickerFormat.Custom
        Me.DTPFechaPago.Location = New System.Drawing.Point(95, 46)
        Me.DTPFechaPago.Name = "DTPFechaPago"
        Me.DTPFechaPago.Size = New System.Drawing.Size(83, 22)
        Me.DTPFechaPago.TabIndex = 1
        Me.DTPFechaPago.Value = New Date(2022, 3, 28, 14, 40, 59, 453)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(597, 19)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 15)
        Me.Label7.TabIndex = 3
        Me.Label7.Text = "CP Lugar Expedicion"
        '
        'MTBCP
        '
        Me.MTBCP.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MTBCP.Location = New System.Drawing.Point(731, 14)
        Me.MTBCP.Mask = "00000"
        Me.MTBCP.Name = "MTBCP"
        Me.MTBCP.Size = New System.Drawing.Size(62, 22)
        Me.MTBCP.TabIndex = 8
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(234, 19)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(112, 15)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Tipo Comprobante"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(90, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Fecha Emision"
        '
        'DTPFechaEmision
        '
        Me.DTPFechaEmision.CustomFormat = "dd/MM/yyyy"
        Me.DTPFechaEmision.Format = Wisej.Web.DateTimePickerFormat.Custom
        Me.DTPFechaEmision.Location = New System.Drawing.Point(95, 13)
        Me.DTPFechaEmision.Name = "DTPFechaEmision"
        Me.DTPFechaEmision.Size = New System.Drawing.Size(83, 22)
        Me.DTPFechaEmision.TabIndex = 1
        Me.DTPFechaEmision.Value = New Date(2022, 3, 28, 14, 40, 59, 468)
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkRate = 3
        Me.ErrorProvider1.ContainerControl = Me
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(289, 102)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(38, 13)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "Tipo de Cambio"
        '
        'PFACTURA_SAT_CFDI_PAGOS_BTableAdapter
        '
        Me.PFACTURA_SAT_CFDI_PAGOS_BTableAdapter.ClearBeforeFill = True
        '
        'Facturacion_Nota_Credito
        '
        Me.ClientSize = New System.Drawing.Size(1192, 868)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.RibbonBar7)
        Me.Name = "Facturacion_Nota_Credito"
        Me.Text = "Notas de Crédito"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DGVUUID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_pFACTURA_SAT_CFDI_PAGOS_B, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pserie.ResumeLayout(False)
        Me.pserie.PerformLayout()
        Me.pfECHA.ResumeLayout(False)
        Me.pfECHA.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DGVConceptos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RibbonBar7 As Ext.RibbonBar.RibbonBar
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents DGVUUID As Wisej.Web.DataGridView
    Friend WithEvents pserie As Panel
    Friend WithEvents pfECHA As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents RBFolio As RadioButton
    Friend WithEvents RBFecha As RadioButton
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents cFecha2 As DateTimePicker
    Friend WithEvents cFecha1 As DateTimePicker
    Friend WithEvents Label18 As Label
    Friend WithEvents DTPFechaEmision As DateTimePicker
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents CBEmisor As ComboWisax
    Friend WithEvents BTEm As Button
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents CBSReceptor As ComboWisax
    Friend WithEvents BTRec As Button
    Friend WithEvents Panel6 As Panel
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents DTPFechaPago As DateTimePicker
    Friend WithEvents Label7 As Label
    Friend WithEvents MTBCP As MaskedTextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents CBSMoneda As ComboWisax
    Friend WithEvents MTBHoraPago As MaskedTextBox
    Friend WithEvents MTBHoraEmision As MaskedTextBox
    Friend WithEvents CBSTipoComprobante As ComboWisax
    Friend WithEvents CBSFormaPago As ComboWisax
    'Friend WithEvents DataSet_pFACTURA_SAT_CFDI_PAGOS_B As DataSet_pFACTURA_SAT_CFDI_PAGOS_B
    Friend WithEvents RibbonBarPage1 As Ext.RibbonBar.RibbonBarPage
    Friend WithEvents RibbonBarGroup1 As Ext.RibbonBar.RibbonBarGroup
    Friend WithEvents RBBConsultar As Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents RBBFactura As Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents RBBSalir As Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label17 As Label
    Friend WithEvents CBSUsoCFDI As ComboWisax
    Friend WithEvents Label20 As Label
    Friend WithEvents RTBObservaciones As TextBox
    Friend WithEvents Label1 As Label
    'Friend WithEvents DataSet_pFACTURA_SAT_CFDI_PAGOS_B1 As DataSet_pFACTURA_SAT_CFDI_PAGOS_B
    'Friend WithEvents AspPageBox1 As Hosts.AspPageBox
    Friend WithEvents RBBNuevo As Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents CBS_TipoRelacion As ComboWisax
    Friend WithEvents Label12 As Label
    Friend WithEvents DGVConceptos As Wisej.Web.DataGridView
    Friend WithEvents cCantidad As DataGridViewTextBoxColumn
    Friend WithEvents cbClaveProdServ As DataGridViewComboBoxColumn
    Friend WithEvents cbClaveUnidad As DataGridViewComboBoxColumn
    Friend WithEvents cDescripcion As DataGridViewTextBoxColumn
    Friend WithEvents cValorUnitario As DataGridViewTextBoxColumn
    Friend WithEvents cImporte As DataGridViewTextBoxColumn
    Friend WithEvents cNoIdentificacion As DataGridViewTextBoxColumn
    Friend WithEvents cDescuento As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents Panel4 As Panel
    Friend WithEvents Label33 As Label
    Friend WithEvents TBDescuento As TextBox
    Friend WithEvents TBTotal As TextBox
    Friend WithEvents TBRISR As TextBox
    Friend WithEvents TBRIVA As TextBox
    Friend WithEvents TBIva As TextBox
    Friend WithEvents TBSubTotal As TextBox
    Friend WithEvents Label28 As Label
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents DataSet_pFACTURA_SAT_CFDI_PAGOS_B As DataSet_pFACTURA_SAT_CFDI_PAGOS_B
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents PFACTURA_SAT_CFDI_PAGOS_BTableAdapter As DataSet_pFACTURA_SAT_CFDI_PAGOS_BTableAdapters.pFACTURA_SAT_CFDI_PAGOS_BTableAdapter
    Friend WithEvents colFOLIO As DataGridViewTextBoxColumn
    Friend WithEvents colUUID As DataGridViewTextBoxColumn
    Friend WithEvents colFECHA As DataGridViewTextBoxColumn
    Friend WithEvents colCONDICIONESPAGO As DataGridViewTextBoxColumn
    Friend WithEvents colSALDO As DataGridViewTextBoxColumn
    Friend WithEvents Label10 As Label
    Friend WithEvents CbxClientes As ComboWisax
End Class