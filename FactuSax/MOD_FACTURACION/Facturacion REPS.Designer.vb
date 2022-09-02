

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Facturacion_REPS
    Inherits Wisej.Web.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim DataGridViewCellStyle2 As Wisej.Web.DataGridViewCellStyle = New Wisej.Web.DataGridViewCellStyle()
        Me.RibbonBar7 = New Wisej.Web.Ext.RibbonBar.RibbonBar()
        Me.RibbonBarPage1 = New Wisej.Web.Ext.RibbonBar.RibbonBarPage()
        Me.RibbonBarGroup1 = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.RBBNuevo = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBBConsultar = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBBFactura = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBBSalir = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.SplitContainer1 = New Wisej.Web.SplitContainer()
        Me.DGVUUID = New Wisej.Web.DataGridView()
        Me.DataGridViewCheckBoxColumn1 = New Wisej.Web.DataGridViewCheckBoxColumn()
        Me.colFOLIO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colUUID = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colFECHA = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colCONDICIONESPAGO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colSALDO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.BindingSource1 = New Wisej.Web.BindingSource(Me.components)
        Me.DataSet_pFACTURA_SAT_CFDI_PAGOS_B = New FactuSax.DataSet_pFACTURA_SAT_CFDI_PAGOS_B()
        Me.pserie = New Wisej.Web.Panel()
        Me.RichTextBox1 = New Wisej.Web.TextBox()
        Me.Label2 = New Wisej.Web.Label()
        Me.pfECHA = New Wisej.Web.Panel()
        Me.GroupBox5 = New Wisej.Web.GroupBox()
        Me.RbEmpresa = New Wisej.Web.RadioButton()
        Me.RbParticular = New Wisej.Web.RadioButton()
        Me.Label12 = New Wisej.Web.Label()
        Me.Label16 = New Wisej.Web.Label()
        Me.Label19 = New Wisej.Web.Label()
        Me.cFecha2 = New Wisej.Web.DateTimePicker()
        Me.cFecha1 = New Wisej.Web.DateTimePicker()
        Me.Label18 = New Wisej.Web.Label()
        Me.Panel3 = New Wisej.Web.Panel()
        Me.GroupBox1 = New Wisej.Web.GroupBox()
        Me.RBFolio = New Wisej.Web.RadioButton()
        Me.RBFecha = New Wisej.Web.RadioButton()
        Me.GroupBox2 = New Wisej.Web.GroupBox()
        Me.RadioButton1 = New Wisej.Web.RadioButton()
        Me.RadioButton2 = New Wisej.Web.RadioButton()
        Me.DGVConceptosUUID = New Wisej.Web.DataGridView()
        Me.colUUID_1 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colSERIE = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colFOLIO_1 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colMONEDA = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colMETODOPAGO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colPARCIALIDAD = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colIMPORTE_PAGADO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colSALDO_ANTERIOR = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colSALDO_INSOLUTO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.BindingSource2 = New Wisej.Web.BindingSource(Me.components)
        Me.DataSet_pFACTURA_SAT_CFDI_PAGOS_UUID_B = New FactuSax.DataSet_pFACTURA_SAT_CFDI_PAGOS_UUID_B()
        Me.Panel2 = New Wisej.Web.Panel()
        Me.gbbANCOS = New Wisej.Web.GroupBox()
        Me.TBRFCbancoB = New Wisej.Web.TextBox()
        Me.TBCtabeneficiario = New Wisej.Web.TextBox()
        Me.Label15 = New Wisej.Web.Label()
        Me.Label14 = New Wisej.Web.Label()
        Me.Label13 = New Wisej.Web.Label()
        Me.Label11 = New Wisej.Web.Label()
        Me.Label10 = New Wisej.Web.Label()
        Me.TBBRFCancoE = New Wisej.Web.TextBox()
        Me.SplitContainer2 = New Wisej.Web.SplitContainer()
        Me.GroupBox3 = New Wisej.Web.GroupBox()
        Me.BTEm = New Wisej.Web.Button()
        Me.GroupBox4 = New Wisej.Web.GroupBox()
        Me.Label17 = New Wisej.Web.Label()
        Me.BTRec = New Wisej.Web.Button()
        Me.Panel6 = New Wisej.Web.Panel()
        Me.RTBObservaciones = New Wisej.Web.TextBox()
        Me.Label1 = New Wisej.Web.Label()
        Me.MTBHoraPago = New Wisej.Web.MaskedTextBox()
        Me.MTBHoraEmision = New Wisej.Web.MaskedTextBox()
        Me.Label9 = New Wisej.Web.Label()
        Me.TBMonto = New Wisej.Web.TextBox()
        Me.Label8 = New Wisej.Web.Label()
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
        Me.AspPageBox1 = New Wisej.Web.AspNetPanel()
        Me.DataSet_pFACTURA_SAT_CFDI_PAGOS_B1 = New FactuSax.DataSet_pFACTURA_SAT_CFDI_PAGOS_B()
        Me.PFACTURA_SAT_CFDI_PAGOS_UUID_BTableAdapter = New FactuSax.DataSet_pFACTURA_SAT_CFDI_PAGOS_UUID_BTableAdapters.pFACTURA_SAT_CFDI_PAGOS_UUID_BTableAdapter()
        Me.BtnAnexarPago = New Wisej.Web.Button()
        Me.CbxReceptor = New FactuSax.ComboWisax()
        Me.CbxClientes = New FactuSax.ComboWisax()
        Me.CBSBancoEmisor = New FactuSax.ComboWisax()
        Me.CBSBancoBeneficiario = New FactuSax.ComboWisax()
        Me.CBEmisor = New FactuSax.ComboWisax()
        Me.CBSReceptor = New FactuSax.ComboWisax()
        Me.CBSUsoCFDI = New FactuSax.ComboWisax()
        Me.CBSFormaPago = New FactuSax.ComboWisax()
        Me.CBSTipoComprobante = New FactuSax.ComboWisax()
        Me.CBSMoneda = New FactuSax.ComboWisax()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DGVUUID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_pFACTURA_SAT_CFDI_PAGOS_B, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.pserie.SuspendLayout()
        Me.pfECHA.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DGVConceptosUUID, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_pFACTURA_SAT_CFDI_PAGOS_UUID_B, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.gbbANCOS.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_pFACTURA_SAT_CFDI_PAGOS_B1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonBar7
        '
        Me.RibbonBar7.Cursor = Wisej.Web.Cursors.Arrow
        Me.RibbonBar7.Name = "RibbonBar7"
        Me.RibbonBar7.Pages.Add(Me.RibbonBarPage1)
        Me.RibbonBar7.Size = New System.Drawing.Size(1192, 94)
        '
        'RibbonBarPage1
        '
        Me.RibbonBarPage1.Groups.Add(Me.RibbonBarGroup1)
        Me.RibbonBarPage1.Name = "RibbonBarPage1"
        Me.RibbonBarPage1.Text = "Menu"
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
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 94)
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
        Me.SplitContainer1.Panel2.Controls.Add(Me.DGVConceptosUUID)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1192, 661)
        Me.SplitContainer1.SplitterDistance = 371
        Me.SplitContainer1.TabIndex = 7
        '
        'DGVUUID
        '
        Me.DGVUUID.AllowUserToResizeColumns = False
        Me.DGVUUID.AllowUserToResizeRows = False
        Me.DGVUUID.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.DataGridViewCheckBoxColumn1, Me.colFOLIO, Me.colUUID, Me.colFECHA, Me.colCONDICIONESPAGO, Me.colSALDO})
        Me.DGVUUID.DataMember = "pFACTURA_SAT_CFDI_PAGOS_B"
        Me.DGVUUID.DataSource = Me.BindingSource1
        Me.DGVUUID.Dock = Wisej.Web.DockStyle.Fill
        Me.DGVUUID.Location = New System.Drawing.Point(0, 323)
        Me.DGVUUID.Name = "DGVUUID"
        Me.DGVUUID.RowHeadersVisible = False
        Me.DGVUUID.Size = New System.Drawing.Size(369, 336)
        Me.DGVUUID.TabIndex = 1
        '
        'DataGridViewCheckBoxColumn1
        '
        DataGridViewCellStyle2.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle2.NullValue = False
        Me.DataGridViewCheckBoxColumn1.DefaultCellStyle = DataGridViewCellStyle2
        Me.DataGridViewCheckBoxColumn1.HeaderText = "     "
        Me.DataGridViewCheckBoxColumn1.Name = "DataGridViewCheckBoxColumn1"
        Me.DataGridViewCheckBoxColumn1.Width = 30
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
        Me.BindingSource1.DataSource = Me.DataSet_pFACTURA_SAT_CFDI_PAGOS_B
        Me.BindingSource1.Position = 0
        '
        'DataSet_pFACTURA_SAT_CFDI_PAGOS_B
        '
        Me.DataSet_pFACTURA_SAT_CFDI_PAGOS_B.DataSetName = "DataSet_pFACTURA_SAT_CFDI_PAGOS_B"
        Me.DataSet_pFACTURA_SAT_CFDI_PAGOS_B.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'pserie
        '
        Me.pserie.Controls.Add(Me.RichTextBox1)
        Me.pserie.Controls.Add(Me.Label2)
        Me.pserie.Dock = Wisej.Web.DockStyle.Top
        Me.pserie.Location = New System.Drawing.Point(0, 230)
        Me.pserie.Name = "pserie"
        Me.pserie.Size = New System.Drawing.Size(369, 93)
        Me.pserie.TabIndex = 0
        Me.pserie.TabStop = True
        Me.pserie.Visible = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.Location = New System.Drawing.Point(9, 22)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(354, 22)
        Me.RichTextBox1.TabIndex = 2
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
        Me.pfECHA.Controls.Add(Me.GroupBox5)
        Me.pfECHA.Controls.Add(Me.Label12)
        Me.pfECHA.Controls.Add(Me.CbxReceptor)
        Me.pfECHA.Controls.Add(Me.Label16)
        Me.pfECHA.Controls.Add(Me.CbxClientes)
        Me.pfECHA.Controls.Add(Me.Label19)
        Me.pfECHA.Controls.Add(Me.cFecha2)
        Me.pfECHA.Controls.Add(Me.cFecha1)
        Me.pfECHA.Controls.Add(Me.Label18)
        Me.pfECHA.Dock = Wisej.Web.DockStyle.Top
        Me.pfECHA.Location = New System.Drawing.Point(0, 44)
        Me.pfECHA.Name = "pfECHA"
        Me.pfECHA.Size = New System.Drawing.Size(369, 186)
        Me.pfECHA.TabIndex = 0
        Me.pfECHA.TabStop = True
        Me.pfECHA.Visible = False
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.RbEmpresa)
        Me.GroupBox5.Controls.Add(Me.RbParticular)
        Me.GroupBox5.Dock = Wisej.Web.DockStyle.Top
        Me.GroupBox5.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(369, 55)
        Me.GroupBox5.TabIndex = 15
        Me.GroupBox5.Text = "Tipo de Facturas"
        '
        'RbEmpresa
        '
        Me.RbEmpresa.Location = New System.Drawing.Point(208, 26)
        Me.RbEmpresa.Name = "RbEmpresa"
        Me.RbEmpresa.Size = New System.Drawing.Size(91, 22)
        Me.RbEmpresa.TabIndex = 16
        Me.RbEmpresa.TabStop = True
        Me.RbEmpresa.Text = "Empresas"
        '
        'RbParticular
        '
        Me.RbParticular.Checked = True
        Me.RbParticular.Location = New System.Drawing.Point(15, 27)
        Me.RbParticular.Name = "RbParticular"
        Me.RbParticular.Size = New System.Drawing.Size(101, 22)
        Me.RbParticular.TabIndex = 15
        Me.RbParticular.TabStop = True
        Me.RbParticular.Text = "Particulares"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(9, 106)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(57, 15)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Receptor"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(9, 61)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(45, 15)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "Cliente"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(188, 163)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(23, 15)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "Fin"
        '
        'cFecha2
        '
        Me.cFecha2.Anchor = Wisej.Web.AnchorStyles.Top
        Me.cFecha2.CustomFormat = "dd/MM/yyyy"
        Me.cFecha2.Format = Wisej.Web.DateTimePickerFormat.Custom
        Me.cFecha2.Location = New System.Drawing.Point(217, 156)
        Me.cFecha2.Name = "cFecha2"
        Me.cFecha2.Size = New System.Drawing.Size(103, 22)
        Me.cFecha2.TabIndex = 0
        Me.cFecha2.Value = New Date(2010, 5, 4, 18, 20, 0, 0)
        '
        'cFecha1
        '
        Me.cFecha1.CustomFormat = "dd/MM/yyyy"
        Me.cFecha1.Format = Wisej.Web.DateTimePickerFormat.Custom
        Me.cFecha1.Location = New System.Drawing.Point(43, 157)
        Me.cFecha1.Name = "cFecha1"
        Me.cFecha1.Size = New System.Drawing.Size(103, 22)
        Me.cFecha1.TabIndex = 0
        Me.cFecha1.Value = New Date(2010, 5, 4, 18, 20, 0, 0)
        '
        'Label18
        '
        Me.Label18.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(9, 163)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(35, 15)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Inicio"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.GroupBox1)
        Me.Panel3.Controls.Add(Me.GroupBox2)
        Me.Panel3.Dock = Wisej.Web.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(369, 44)
        Me.Panel3.TabIndex = 0
        Me.Panel3.TabStop = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Bottom) _
            Or Wisej.Web.AnchorStyles.Left), Wisej.Web.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.RBFolio)
        Me.GroupBox1.Controls.Add(Me.RBFecha)
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
        Me.RBFecha.Checked = True
        Me.RBFecha.Location = New System.Drawing.Point(15, 17)
        Me.RBFecha.Name = "RBFecha"
        Me.RBFecha.Size = New System.Drawing.Size(69, 22)
        Me.RBFecha.TabIndex = 0
        Me.RBFecha.TabStop = True
        Me.RBFecha.Text = "Fecha"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Bottom) _
            Or Wisej.Web.AnchorStyles.Left), Wisej.Web.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.RadioButton1)
        Me.GroupBox2.Controls.Add(Me.RadioButton2)
        Me.GroupBox2.Location = New System.Drawing.Point(-125, 464)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(369, 69)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.Text = "Filtro"
        '
        'RadioButton1
        '
        Me.RadioButton1.Location = New System.Drawing.Point(208, 17)
        Me.RadioButton1.Name = "RadioButton1"
        Me.RadioButton1.Size = New System.Drawing.Size(63, 22)
        Me.RadioButton1.TabIndex = 0
        Me.RadioButton1.Text = "Serie"
        '
        'RadioButton2
        '
        Me.RadioButton2.Location = New System.Drawing.Point(15, 17)
        Me.RadioButton2.Name = "RadioButton2"
        Me.RadioButton2.Size = New System.Drawing.Size(69, 22)
        Me.RadioButton2.TabIndex = 0
        Me.RadioButton2.Text = "Fecha"
        '
        'DGVConceptosUUID
        '
        Me.DGVConceptosUUID.AutoGenerateColumns = False
        Me.DGVConceptosUUID.AutoSize = True
        Me.DGVConceptosUUID.AutoSizeColumnsMode = Wisej.Web.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DGVConceptosUUID.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.colUUID_1, Me.colSERIE, Me.colFOLIO_1, Me.colMONEDA, Me.colMETODOPAGO, Me.colPARCIALIDAD, Me.colIMPORTE_PAGADO, Me.colSALDO_ANTERIOR, Me.colSALDO_INSOLUTO})
        Me.DGVConceptosUUID.DataSource = Me.BindingSource2
        Me.DGVConceptosUUID.Dock = Wisej.Web.DockStyle.Fill
        Me.DGVConceptosUUID.Location = New System.Drawing.Point(0, 367)
        Me.DGVConceptosUUID.Name = "DGVConceptosUUID"
        Me.DGVConceptosUUID.Size = New System.Drawing.Size(813, 292)
        Me.DGVConceptosUUID.TabIndex = 1
        '
        'colUUID_1
        '
        Me.colUUID_1.DataPropertyName = "UUID"
        Me.colUUID_1.HeaderText = "UUID"
        Me.colUUID_1.Name = "colUUID_1"
        '
        'colSERIE
        '
        Me.colSERIE.DataPropertyName = "SERIE"
        Me.colSERIE.HeaderText = "Serie"
        Me.colSERIE.Name = "colSERIE"
        '
        'colFOLIO_1
        '
        Me.colFOLIO_1.DataPropertyName = "FOLIO"
        Me.colFOLIO_1.HeaderText = "Folio"
        Me.colFOLIO_1.Name = "colFOLIO_1"
        '
        'colMONEDA
        '
        Me.colMONEDA.DataPropertyName = "MONEDA"
        Me.colMONEDA.HeaderText = "Moneda"
        Me.colMONEDA.Name = "colMONEDA"
        '
        'colMETODOPAGO
        '
        Me.colMETODOPAGO.DataPropertyName = "METODOPAGO"
        Me.colMETODOPAGO.HeaderText = "Método de Pago"
        Me.colMETODOPAGO.Name = "colMETODOPAGO"
        '
        'colPARCIALIDAD
        '
        Me.colPARCIALIDAD.DataPropertyName = "PARCIALIDAD"
        Me.colPARCIALIDAD.HeaderText = "No. Parcialidad"
        Me.colPARCIALIDAD.Name = "colPARCIALIDAD"
        Me.colPARCIALIDAD.ReadOnly = True
        '
        'colIMPORTE_PAGADO
        '
        Me.colIMPORTE_PAGADO.DataPropertyName = "IMPORTE_PAGADO"
        Me.colIMPORTE_PAGADO.HeaderText = "Importe Pagado"
        Me.colIMPORTE_PAGADO.Name = "colIMPORTE_PAGADO"
        Me.colIMPORTE_PAGADO.ReadOnly = True
        '
        'colSALDO_ANTERIOR
        '
        Me.colSALDO_ANTERIOR.DataPropertyName = "SALDO_ANTERIOR"
        Me.colSALDO_ANTERIOR.HeaderText = "Saldo Anterior"
        Me.colSALDO_ANTERIOR.Name = "colSALDO_ANTERIOR"
        Me.colSALDO_ANTERIOR.ReadOnly = True
        '
        'colSALDO_INSOLUTO
        '
        Me.colSALDO_INSOLUTO.DataPropertyName = "SALDO_INSOLUTO"
        Me.colSALDO_INSOLUTO.HeaderText = "Saldo Insoluto"
        Me.colSALDO_INSOLUTO.Name = "colSALDO_INSOLUTO"
        Me.colSALDO_INSOLUTO.ReadOnly = True
        '
        'BindingSource2
        '
        Me.BindingSource2.DataMember = "pFACTURA_SAT_CFDI_PAGOS_UUID_B"
        Me.BindingSource2.DataSource = Me.DataSet_pFACTURA_SAT_CFDI_PAGOS_UUID_B
        '
        'DataSet_pFACTURA_SAT_CFDI_PAGOS_UUID_B
        '
        Me.DataSet_pFACTURA_SAT_CFDI_PAGOS_UUID_B.DataSetName = "DataSet_pFACTURA_SAT_CFDI_PAGOS_UUID_B"
        Me.DataSet_pFACTURA_SAT_CFDI_PAGOS_UUID_B.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.gbbANCOS)
        Me.Panel2.Controls.Add(Me.SplitContainer2)
        Me.Panel2.Controls.Add(Me.Panel6)
        Me.Panel2.Dock = Wisej.Web.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(813, 367)
        Me.Panel2.TabIndex = 0
        Me.Panel2.TabStop = True
        '
        'gbbANCOS
        '
        Me.gbbANCOS.Controls.Add(Me.CBSBancoEmisor)
        Me.gbbANCOS.Controls.Add(Me.TBRFCbancoB)
        Me.gbbANCOS.Controls.Add(Me.TBCtabeneficiario)
        Me.gbbANCOS.Controls.Add(Me.Label15)
        Me.gbbANCOS.Controls.Add(Me.Label14)
        Me.gbbANCOS.Controls.Add(Me.Label13)
        Me.gbbANCOS.Controls.Add(Me.Label11)
        Me.gbbANCOS.Controls.Add(Me.Label10)
        Me.gbbANCOS.Controls.Add(Me.TBBRFCancoE)
        Me.gbbANCOS.Controls.Add(Me.CBSBancoBeneficiario)
        Me.gbbANCOS.Dock = Wisej.Web.DockStyle.Top
        Me.gbbANCOS.Location = New System.Drawing.Point(0, 271)
        Me.gbbANCOS.Name = "gbbANCOS"
        Me.gbbANCOS.Size = New System.Drawing.Size(813, 100)
        Me.gbbANCOS.TabIndex = 3
        Me.gbbANCOS.Text = "Bancos"
        Me.gbbANCOS.Visible = False
        '
        'TBRFCbancoB
        '
        Me.TBRFCbancoB.Location = New System.Drawing.Point(237, 72)
        Me.TBRFCbancoB.Name = "TBRFCbancoB"
        Me.TBRFCbancoB.Size = New System.Drawing.Size(193, 22)
        Me.TBRFCbancoB.TabIndex = 1
        '
        'TBCtabeneficiario
        '
        Me.TBCtabeneficiario.Location = New System.Drawing.Point(464, 72)
        Me.TBCtabeneficiario.Name = "TBCtabeneficiario"
        Me.TBCtabeneficiario.Size = New System.Drawing.Size(329, 22)
        Me.TBCtabeneficiario.TabIndex = 1
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(5, 56)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(151, 15)
        Me.Label15.TabIndex = 3
        Me.Label15.Text = "Banco Benefeciario Pago"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(234, 56)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(143, 15)
        Me.Label14.TabIndex = 3
        Me.Label14.Text = "RFC Banco Beneficiario"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(461, 56)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(118, 15)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "Cuenta Beneficiario"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(234, 16)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(116, 15)
        Me.Label11.TabIndex = 3
        Me.Label11.Text = "RFC Banco Emisor"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(5, 16)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(119, 15)
        Me.Label10.TabIndex = 3
        Me.Label10.Text = "Banco Emisor Pago"
        '
        'TBBRFCancoE
        '
        Me.TBBRFCancoE.Location = New System.Drawing.Point(237, 33)
        Me.TBBRFCancoE.Name = "TBBRFCancoE"
        Me.TBBRFCancoE.Size = New System.Drawing.Size(193, 22)
        Me.TBBRFCancoE.TabIndex = 1
        '
        'SplitContainer2
        '
        Me.SplitContainer2.AutoValidate = Wisej.Web.AutoValidate.EnablePreventFocusChange
        Me.SplitContainer2.Dock = Wisej.Web.DockStyle.Top
        Me.SplitContainer2.FixedPanel = Wisej.Web.FixedPanel.Panel1
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 189)
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
        'BTRec
        '
        Me.BTRec.Location = New System.Drawing.Point(373, 17)
        Me.BTRec.Name = "BTRec"
        Me.BTRec.Size = New System.Drawing.Size(33, 23)
        Me.BTRec.TabIndex = 1
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.BtnAnexarPago)
        Me.Panel6.Controls.Add(Me.RTBObservaciones)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.CBSFormaPago)
        Me.Panel6.Controls.Add(Me.CBSTipoComprobante)
        Me.Panel6.Controls.Add(Me.MTBHoraPago)
        Me.Panel6.Controls.Add(Me.MTBHoraEmision)
        Me.Panel6.Controls.Add(Me.Label9)
        Me.Panel6.Controls.Add(Me.TBMonto)
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
        Me.Panel6.Size = New System.Drawing.Size(813, 189)
        Me.Panel6.TabIndex = 2
        Me.Panel6.TabStop = True
        '
        'RTBObservaciones
        '
        Me.RTBObservaciones.AutoSize = False
        Me.RTBObservaciones.Location = New System.Drawing.Point(97, 117)
        Me.RTBObservaciones.Name = "RTBObservaciones"
        Me.RTBObservaciones.Size = New System.Drawing.Size(710, 55)
        Me.RTBObservaciones.TabIndex = 13
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(5, 120)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(91, 15)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Observaciones"
        '
        'MTBHoraPago
        '
        Me.MTBHoraPago.Location = New System.Drawing.Point(188, 47)
        Me.MTBHoraPago.Mask = "00:00"
        Me.MTBHoraPago.Name = "MTBHoraPago"
        Me.MTBHoraPago.Size = New System.Drawing.Size(40, 22)
        Me.MTBHoraPago.TabIndex = 10
        Me.MTBHoraPago.Text = "1200"
        '
        'MTBHoraEmision
        '
        Me.MTBHoraEmision.Location = New System.Drawing.Point(188, 14)
        Me.MTBHoraEmision.Mask = "00:00"
        Me.MTBHoraEmision.Name = "MTBHoraEmision"
        Me.MTBHoraEmision.Size = New System.Drawing.Size(40, 22)
        Me.MTBHoraEmision.TabIndex = 10
        Me.MTBHoraEmision.Text = "1200"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label9.Location = New System.Drawing.Point(13, 80)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(49, 27)
        Me.Label9.TabIndex = 3
        Me.Label9.Text = "Monto a" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "pagar:"
        Me.Label9.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'TBMonto
        '
        Me.TBMonto.BackColor = System.Drawing.SystemColors.Info
        Me.TBMonto.Font = New System.Drawing.Font("Tahoma", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.TBMonto.Location = New System.Drawing.Point(79, 77)
        Me.TBMonto.Name = "TBMonto"
        Me.TBMonto.Size = New System.Drawing.Size(163, 25)
        Me.TBMonto.TabIndex = 1
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(281, 84)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 15)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Moneda"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(234, 48)
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
        Me.DTPFechaPago.Location = New System.Drawing.Point(96, 46)
        Me.DTPFechaPago.Name = "DTPFechaPago"
        Me.DTPFechaPago.Size = New System.Drawing.Size(83, 22)
        Me.DTPFechaPago.TabIndex = 1
        Me.DTPFechaPago.Value = New Date(2022, 4, 11, 16, 2, 49, 641)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(597, 18)
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
        Me.Label4.Location = New System.Drawing.Point(234, 17)
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
        Me.DTPFechaEmision.Location = New System.Drawing.Point(96, 13)
        Me.DTPFechaEmision.Name = "DTPFechaEmision"
        Me.DTPFechaEmision.Size = New System.Drawing.Size(83, 22)
        Me.DTPFechaEmision.TabIndex = 1
        Me.DTPFechaEmision.Value = New Date(2022, 4, 11, 16, 2, 49, 650)
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
        'AspPageBox1
        '
        Me.AspPageBox1.Location = New System.Drawing.Point(658, 38)
        Me.AspPageBox1.Name = "AspPageBox1"
        Me.AspPageBox1.Size = New System.Drawing.Size(10, 10)
        Me.AspPageBox1.TabIndex = 8
        '
        'DataSet_pFACTURA_SAT_CFDI_PAGOS_B1
        '
        Me.DataSet_pFACTURA_SAT_CFDI_PAGOS_B1.DataSetName = "DataSet_pFACTURA_SAT_CFDI_PAGOS_B"
        Me.DataSet_pFACTURA_SAT_CFDI_PAGOS_B1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PFACTURA_SAT_CFDI_PAGOS_UUID_BTableAdapter
        '
        Me.PFACTURA_SAT_CFDI_PAGOS_UUID_BTableAdapter.ClearBeforeFill = True
        '
        'BtnAnexarPago
        '
        Me.BtnAnexarPago.Location = New System.Drawing.Point(248, 76)
        Me.BtnAnexarPago.Name = "BtnAnexarPago"
        Me.BtnAnexarPago.Size = New System.Drawing.Size(31, 27)
        Me.BtnAnexarPago.TabIndex = 14
        Me.BtnAnexarPago.Text = "+"
        '
        'CbxReceptor
        '
        Me.CbxReceptor.Location = New System.Drawing.Point(9, 122)
        Me.CbxReceptor.Name = "CbxReceptor"
        Me.CbxReceptor.Size = New System.Drawing.Size(354, 22)
        Me.CbxReceptor.TabIndex = 12
        '
        'CbxClientes
        '
        Me.CbxClientes.Location = New System.Drawing.Point(9, 77)
        Me.CbxClientes.Name = "CbxClientes"
        Me.CbxClientes.Size = New System.Drawing.Size(354, 22)
        Me.CbxClientes.TabIndex = 10
        '
        'CBSBancoEmisor
        '
        Me.CBSBancoEmisor.BackColor = System.Drawing.Color.Transparent
        Me.CBSBancoEmisor.Cursor = Wisej.Web.Cursors.Hand
        Me.CBSBancoEmisor.Location = New System.Drawing.Point(8, 32)
        Me.CBSBancoEmisor.Name = "CBSBancoEmisor"
        Me.CBSBancoEmisor.Size = New System.Drawing.Size(191, 22)
        Me.CBSBancoEmisor.TabIndex = 0
        '
        'CBSBancoBeneficiario
        '
        Me.CBSBancoBeneficiario.BackColor = System.Drawing.Color.Transparent
        Me.CBSBancoBeneficiario.Cursor = Wisej.Web.Cursors.Hand
        Me.CBSBancoBeneficiario.Location = New System.Drawing.Point(8, 71)
        Me.CBSBancoBeneficiario.Name = "CBSBancoBeneficiario"
        Me.CBSBancoBeneficiario.Size = New System.Drawing.Size(191, 22)
        Me.CBSBancoBeneficiario.TabIndex = 0
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
        Me.CBSUsoCFDI.Location = New System.Drawing.Point(62, 44)
        Me.CBSUsoCFDI.Name = "CBSUsoCFDI"
        Me.CBSUsoCFDI.Size = New System.Drawing.Size(311, 22)
        Me.CBSUsoCFDI.TabIndex = 4
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
        Me.CBSTipoComprobante.Location = New System.Drawing.Point(342, 13)
        Me.CBSTipoComprobante.Name = "CBSTipoComprobante"
        Me.CBSTipoComprobante.Size = New System.Drawing.Size(245, 22)
        Me.CBSTipoComprobante.TabIndex = 11
        '
        'CBSMoneda
        '
        Me.CBSMoneda.BackColor = System.Drawing.Color.Transparent
        Me.CBSMoneda.Cursor = Wisej.Web.Cursors.Hand
        Me.CBSMoneda.Location = New System.Drawing.Point(336, 80)
        Me.CBSMoneda.Name = "CBSMoneda"
        Me.CBSMoneda.Size = New System.Drawing.Size(474, 22)
        Me.CBSMoneda.TabIndex = 5
        '
        'Facturacion_REPS
        '
        Me.ClientSize = New System.Drawing.Size(1192, 755)
        Me.Controls.Add(Me.AspPageBox1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.RibbonBar7)
        Me.Name = "Facturacion_REPS"
        Me.Text = "Facturacion_REPS"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DGVUUID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_pFACTURA_SAT_CFDI_PAGOS_B, System.ComponentModel.ISupportInitialize).EndInit()
        Me.pserie.ResumeLayout(False)
        Me.pserie.PerformLayout()
        Me.pfECHA.ResumeLayout(False)
        Me.pfECHA.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox5.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.DGVConceptosUUID, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_pFACTURA_SAT_CFDI_PAGOS_UUID_B, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.gbbANCOS.ResumeLayout(False)
        Me.gbbANCOS.PerformLayout()
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
        CType(Me.DataSet_pFACTURA_SAT_CFDI_PAGOS_B1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RibbonBar7 As Ext.RibbonBar.RibbonBar
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents DGVUUID As Wisej.Web.DataGridView
    Friend WithEvents DGVConceptosUUID As Wisej.Web.DataGridView
    Friend WithEvents pserie As Panel
    Friend WithEvents pfECHA As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents RBFolio As RadioButton
    Friend WithEvents RBFecha As RadioButton
    Friend WithEvents RichTextBox1 As TextBox
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
    Friend WithEvents TBMonto As TextBox
    Friend WithEvents gbbANCOS As GroupBox
    Friend WithEvents TBBRFCancoE As TextBox
    Friend WithEvents CBSBancoBeneficiario As ComboWisax
    Friend WithEvents Label9 As Label
    Friend WithEvents CBSBancoEmisor As ComboWisax
    Friend WithEvents TBRFCbancoB As TextBox
    Friend WithEvents TBCtabeneficiario As TextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents MTBHoraPago As MaskedTextBox
    Friend WithEvents MTBHoraEmision As MaskedTextBox
    Friend WithEvents CBSTipoComprobante As ComboWisax
    Friend WithEvents CBSFormaPago As ComboWisax
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents DataSet_pFACTURA_SAT_CFDI_PAGOS_B As DataSet_pFACTURA_SAT_CFDI_PAGOS_B
    Friend WithEvents RibbonBarPage1 As Ext.RibbonBar.RibbonBarPage
    Friend WithEvents RibbonBarGroup1 As Ext.RibbonBar.RibbonBarGroup
    Friend WithEvents RBBConsultar As Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents RBBFactura As Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents RBBSalir As Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents DataGridViewCheckBoxColumn1 As DataGridViewCheckBoxColumn
    Friend WithEvents Label17 As Label
    Friend WithEvents CBSUsoCFDI As ComboWisax
    Friend WithEvents Label20 As Label
    Friend WithEvents RTBObservaciones As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents DataSet_pFACTURA_SAT_CFDI_PAGOS_B1 As DataSet_pFACTURA_SAT_CFDI_PAGOS_B
    Friend WithEvents AspPageBox1 As AspNetPanel
    Friend WithEvents RBBNuevo As Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents colFOLIO As DataGridViewTextBoxColumn
    Friend WithEvents colUUID As DataGridViewTextBoxColumn
    Friend WithEvents colFECHA As DataGridViewTextBoxColumn
    Friend WithEvents colCONDICIONESPAGO As DataGridViewTextBoxColumn
    Friend WithEvents colSALDO As DataGridViewTextBoxColumn
    Friend WithEvents DataSet_pFACTURA_SAT_CFDI_PAGOS_UUID_B As DataSet_pFACTURA_SAT_CFDI_PAGOS_UUID_B
    Friend WithEvents colUUID_1 As DataGridViewTextBoxColumn
    Friend WithEvents colSERIE As DataGridViewTextBoxColumn
    Friend WithEvents colFOLIO_1 As DataGridViewTextBoxColumn
    Friend WithEvents colMONEDA As DataGridViewTextBoxColumn
    Friend WithEvents colMETODOPAGO As DataGridViewTextBoxColumn
    Friend WithEvents colPARCIALIDAD As DataGridViewTextBoxColumn
    Friend WithEvents colIMPORTE_PAGADO As DataGridViewTextBoxColumn
    Friend WithEvents colSALDO_ANTERIOR As DataGridViewTextBoxColumn
    Friend WithEvents colSALDO_INSOLUTO As DataGridViewTextBoxColumn
    Friend WithEvents BindingSource2 As BindingSource
    Friend WithEvents PFACTURA_SAT_CFDI_PAGOS_UUID_BTableAdapter As DataSet_pFACTURA_SAT_CFDI_PAGOS_UUID_BTableAdapters.pFACTURA_SAT_CFDI_PAGOS_UUID_BTableAdapter
    Friend WithEvents Label12 As Label
    Friend WithEvents CbxReceptor As ComboWisax
    Friend WithEvents Label16 As Label
    Friend WithEvents CbxClientes As ComboWisax
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents RbEmpresa As RadioButton
    Friend WithEvents RbParticular As RadioButton
    Friend WithEvents BtnAnexarPago As Button
End Class