


Imports Wisej.Web.Ext.RibbonBar

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cat_Operadores
    Inherits Form

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
        Me.RibbonBar1 = New Wisej.Web.Ext.RibbonBar.RibbonBar()
        Me.RibbonBarPage1 = New Wisej.Web.Ext.RibbonBar.RibbonBarPage()
        Me.RibbonBarGroup1 = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.RBBNUEVO = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBBGUARDAR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBBCANCELAR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RibbonBarGroup2 = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.RBBSALIR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.Panel1 = New Wisej.Web.Panel()
        Me.GroupBox1 = New Wisej.Web.GroupBox()
        Me.LstCheck_Clientes = New Wisej.Web.CheckedListBox()
        Me.GroupBox2 = New Wisej.Web.GroupBox()
        Me.tbxNombreOperador = New Wisej.Web.TextBox()
        Me.BindingSource1 = New Wisej.Web.BindingSource(Me.components)
        Me.DataSet_pCAT_OPERADORES_B = New FactuSax.DataSet_pCAT_OPERADORES_B()
        Me.Label5 = New Wisej.Web.Label()
        Me.Panel4 = New Wisej.Web.Panel()
        Me.rbInhabilitado = New Wisej.Web.RadioButton()
        Me.Label4 = New Wisej.Web.Label()
        Me.rbHabilitado = New Wisej.Web.RadioButton()
        Me.cmbRol = New Wisej.Web.ComboBox()
        Me.CBxMostrar = New Wisej.Web.CheckBox()
        Me.ckdEstatus = New Wisej.Web.CheckBox()
        Me.Label1 = New Wisej.Web.Label()
        Me.Label3 = New Wisej.Web.Label()
        Me.Label2 = New Wisej.Web.Label()
        Me.txtContra = New Wisej.Web.TextBox()
        Me.txtCve_Operador = New Wisej.Web.TextBox()
        Me.DGV_Operadores = New Wisej.Web.DataGridView()
        Me.DGVI_EDITAR = New Wisej.Web.DataGridViewImageColumn()
        Me.Cve_Operador = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.Contrasena = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.Fecha_Alta = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.Cve_Rol = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.ROL = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.Nombre = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.BindingNavigator1 = New Wisej.Web.BindingNavigator(Me.components)
        Me.buttonMoveFirst = New Wisej.Web.Button()
        Me.buttonMovePrevious = New Wisej.Web.Button()
        Me.separatorLeft = New Wisej.Web.Line()
        Me.textBoxPosition = New Wisej.Web.TextBox()
        Me.labelCount = New Wisej.Web.Label()
        Me.separatorRight = New Wisej.Web.Line()
        Me.buttonMoveNext = New Wisej.Web.Button()
        Me.buttonMoveLast = New Wisej.Web.Button()
        Me.separatorControl = New Wisej.Web.Line()
        Me.ErrorProvider1 = New Wisej.Web.ErrorProvider(Me.components)
        Me.OpenFileDialog1 = New Wisej.Web.OpenFileDialog(Me.components)
        Me.ToolTip1 = New Wisej.Web.ToolTip(Me.components)
        Me.FiltroGrillaSax1 = New FactuSax.filtroGrillaSax()
        Me.DataSet_pCAT_CLIENTES_B = New FactuSax.DataSet_pCAT_CLIENTES_B()
        Me.DataSet_pCAT_CLIENTES_BUSQUEDA_B = New FactuSax.DataSet_pCAT_CLIENTES_BUSQUEDA_B()
        Me.BS_Clientes = New Wisej.Web.BindingSource(Me.components)
        Me.Panel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_pCAT_OPERADORES_B, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        CType(Me.DGV_Operadores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DGV_Operadores.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_pCAT_CLIENTES_B, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_pCAT_CLIENTES_BUSQUEDA_B, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_Clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonBar1
        '
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Pages.Add(Me.RibbonBarPage1)
        Me.RibbonBar1.Size = New System.Drawing.Size(1225, 145)
        '
        'RibbonBarPage1
        '
        Me.RibbonBarPage1.Groups.Add(Me.RibbonBarGroup1)
        Me.RibbonBarPage1.Groups.Add(Me.RibbonBarGroup2)
        Me.RibbonBarPage1.Name = "RibbonBarPage1"
        Me.RibbonBarPage1.Text = "Menú"
        '
        'RibbonBarGroup1
        '
        Me.RibbonBarGroup1.Items.Add(Me.RBBNUEVO)
        Me.RibbonBarGroup1.Items.Add(Me.RBBGUARDAR)
        Me.RibbonBarGroup1.Items.Add(Me.RBBCANCELAR)
        Me.RibbonBarGroup1.Name = "RibbonBarGroup1"
        Me.RibbonBarGroup1.Text = "Procesos"
        '
        'RBBNUEVO
        '
        Me.RBBNUEVO.ImageSource = "Resources\Images\Menu\64\Add List Filled-64.png"
        Me.RBBNUEVO.Name = "RBBNUEVO"
        Me.RBBNUEVO.Text = "Nuevo"
        '
        'RBBGUARDAR
        '
        Me.RBBGUARDAR.ImageSource = "Resources\Images\Menu\64\Save Filled-64.png"
        Me.RBBGUARDAR.Name = "RBBGUARDAR"
        Me.RBBGUARDAR.Text = "Guardar"
        '
        'RBBCANCELAR
        '
        Me.RBBCANCELAR.ImageSource = "Resources\Images\Menu\64\Cancel File Filled-64.png"
        Me.RBBCANCELAR.Name = "RBBCANCELAR"
        Me.RBBCANCELAR.Text = "Cancelar"
        '
        'RibbonBarGroup2
        '
        Me.RibbonBarGroup2.Items.Add(Me.RBBSALIR)
        Me.RibbonBarGroup2.Name = "RibbonBarGroup2"
        Me.RibbonBarGroup2.Text = "Salir"
        '
        'RBBSALIR
        '
        Me.RBBSALIR.ImageSource = "Resources\Images\Menu\64\exit_sign.png"
        Me.RBBSALIR.Name = "RBBSALIR"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.GroupBox1)
        Me.Panel1.Controls.Add(Me.GroupBox2)
        Me.Panel1.Dock = Wisej.Web.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 145)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1225, 165)
        Me.Panel1.TabIndex = 2
        Me.Panel1.TabStop = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.LstCheck_Clientes)
        Me.GroupBox1.Dock = Wisej.Web.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(742, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(483, 165)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.Text = "Clientes"
        Me.GroupBox1.Visible = False
        '
        'LstCheck_Clientes
        '
        Me.LstCheck_Clientes.Dock = Wisej.Web.DockStyle.Fill
        Me.LstCheck_Clientes.Location = New System.Drawing.Point(3, 18)
        Me.LstCheck_Clientes.Name = "LstCheck_Clientes"
        Me.LstCheck_Clientes.Size = New System.Drawing.Size(477, 144)
        Me.LstCheck_Clientes.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.tbxNombreOperador)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Panel4)
        Me.GroupBox2.Controls.Add(Me.cmbRol)
        Me.GroupBox2.Controls.Add(Me.CBxMostrar)
        Me.GroupBox2.Controls.Add(Me.ckdEstatus)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtContra)
        Me.GroupBox2.Controls.Add(Me.txtCve_Operador)
        Me.GroupBox2.Dock = Wisej.Web.DockStyle.Left
        Me.GroupBox2.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(742, 165)
        Me.GroupBox2.TabIndex = 3
        Me.GroupBox2.Text = "Datos Operador"
        '
        'tbxNombreOperador
        '
        Me.tbxNombreOperador.DataBindings.Add(New Wisej.Web.Binding("Text", Me.BindingSource1, "Nombre", True))
        Me.tbxNombreOperador.Location = New System.Drawing.Point(417, 63)
        Me.tbxNombreOperador.Name = "tbxNombreOperador"
        Me.tbxNombreOperador.Size = New System.Drawing.Size(167, 22)
        Me.tbxNombreOperador.TabIndex = 1
        Me.tbxNombreOperador.Tag = "Contrasena/1"
        Me.ToolTip1.SetToolTip(Me.tbxNombreOperador, "Inserte el nombre del operador")
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "pCAT_OPERADORES_B"
        Me.BindingSource1.DataSource = Me.DataSet_pCAT_OPERADORES_B
        '
        'DataSet_pCAT_OPERADORES_B
        '
        Me.DataSet_pCAT_OPERADORES_B.DataSetName = "DataSet_pCAT_OPERADORES_B"
        Me.DataSet_pCAT_OPERADORES_B.EnforceConstraints = False
        Me.DataSet_pCAT_OPERADORES_B.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(287, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(123, 14)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Nombre del Operador" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(191, 219, 255)
        Me.Panel4.Controls.Add(Me.rbInhabilitado)
        Me.Panel4.Controls.Add(Me.Label4)
        Me.Panel4.Controls.Add(Me.rbHabilitado)
        Me.Panel4.Dock = Wisej.Web.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(3, 140)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(736, 22)
        Me.Panel4.TabIndex = 13
        Me.Panel4.TabStop = True
        '
        'rbInhabilitado
        '
        Me.rbInhabilitado.Location = New System.Drawing.Point(241, 2)
        Me.rbInhabilitado.Name = "rbInhabilitado"
        Me.rbInhabilitado.Size = New System.Drawing.Size(111, 22)
        Me.rbInhabilitado.TabIndex = 1
        Me.rbInhabilitado.Text = "Desactivados"
        Me.ToolTip1.SetToolTip(Me.rbInhabilitado, "Mostrar los registros desactivados")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(0, 6)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(126, 15)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Mostrar los registros:"
        '
        'rbHabilitado
        '
        Me.rbHabilitado.Checked = True
        Me.rbHabilitado.Location = New System.Drawing.Point(130, 2)
        Me.rbHabilitado.Name = "rbHabilitado"
        Me.rbHabilitado.Size = New System.Drawing.Size(97, 22)
        Me.rbHabilitado.TabIndex = 1
        Me.rbHabilitado.TabStop = True
        Me.rbHabilitado.Text = "Habilitados"
        Me.ToolTip1.SetToolTip(Me.rbHabilitado, "Mostrar los registros habilitados")
        '
        'cmbRol
        '
        Me.cmbRol.DataBindings.Add(New Wisej.Web.Binding("SelectedValue", Me.BindingSource1, "Cve_Rol", True))
        Me.cmbRol.FormattingEnabled = True
        Me.cmbRol.Location = New System.Drawing.Point(104, 65)
        Me.cmbRol.Name = "cmbRol"
        Me.cmbRol.Size = New System.Drawing.Size(167, 22)
        Me.cmbRol.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.cmbRol, "Seleccione el rol")
        '
        'CBxMostrar
        '
        Me.CBxMostrar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.CBxMostrar.Location = New System.Drawing.Point(591, 25)
        Me.CBxMostrar.Name = "CBxMostrar"
        Me.CBxMostrar.Size = New System.Drawing.Size(140, 21)
        Me.CBxMostrar.TabIndex = 4
        Me.CBxMostrar.Text = "Mostrar contraseña"
        Me.ToolTip1.SetToolTip(Me.CBxMostrar, "Haga clic aquí para mostrar contraseña")
        '
        'ckdEstatus
        '
        Me.ckdEstatus.DataBindings.Add(New Wisej.Web.Binding("Checked", Me.BindingSource1, "Estatus", True))
        Me.ckdEstatus.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.ckdEstatus.Location = New System.Drawing.Point(306, 104)
        Me.ckdEstatus.Name = "ckdEstatus"
        Me.ckdEstatus.Size = New System.Drawing.Size(89, 21)
        Me.ckdEstatus.TabIndex = 4
        Me.ckdEstatus.Text = "Habilitado"
        Me.ToolTip1.SetToolTip(Me.ckdEstatus, "Habilita / Desactiva el registro")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(3, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(88, 14)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clave operador"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.Location = New System.Drawing.Point(65, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(23, 14)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Rol"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.Location = New System.Drawing.Point(303, 26)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(66, 14)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "contraseña"
        '
        'txtContra
        '
        Me.txtContra.DataBindings.Add(New Wisej.Web.Binding("Text", Me.BindingSource1, "Contrasena", True))
        Me.txtContra.InputType.Type = Wisej.Web.TextBoxType.Password
        Me.txtContra.Location = New System.Drawing.Point(417, 25)
        Me.txtContra.Name = "txtContra"
        Me.txtContra.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtContra.Size = New System.Drawing.Size(167, 22)
        Me.txtContra.TabIndex = 1
        Me.txtContra.Tag = "Contrasena/1"
        Me.ToolTip1.SetToolTip(Me.txtContra, "Inserte la contraseña")
        '
        'txtCve_Operador
        '
        Me.txtCve_Operador.DataBindings.Add(New Wisej.Web.Binding("Text", Me.BindingSource1, "Cve_Operador", True))
        Me.txtCve_Operador.Location = New System.Drawing.Point(104, 26)
        Me.txtCve_Operador.Name = "txtCve_Operador"
        Me.txtCve_Operador.Size = New System.Drawing.Size(167, 22)
        Me.txtCve_Operador.TabIndex = 1
        Me.txtCve_Operador.Tag = "Cve_Operador/NA"
        Me.ToolTip1.SetToolTip(Me.txtCve_Operador, "Inserte la clave de operador+")
        '
        'DGV_Operadores
        '
        Me.DGV_Operadores.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = Wisej.Web.DataGridViewTriState.[True]
        Me.DGV_Operadores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Operadores.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.DGVI_EDITAR, Me.Cve_Operador, Me.Contrasena, Me.Fecha_Alta, Me.Cve_Rol, Me.ROL, Me.Nombre})
        Me.DGV_Operadores.Controls.Add(Me.BindingNavigator1)
        Me.DGV_Operadores.DataSource = Me.BindingSource1
        Me.DGV_Operadores.Dock = Wisej.Web.DockStyle.Fill
        Me.DGV_Operadores.Location = New System.Drawing.Point(0, 340)
        Me.DGV_Operadores.Name = "DGV_Operadores"
        Me.DGV_Operadores.RowHeadersVisible = False
        Me.DGV_Operadores.Size = New System.Drawing.Size(1225, 310)
        Me.DGV_Operadores.TabIndex = 3
        '
        'DGVI_EDITAR
        '
        Me.DGVI_EDITAR.CellImage = Global.FactuSax.My.Resources.Resources.Edit_File_Filled
        Me.DGVI_EDITAR.CellImageAlignment = Wisej.Web.DataGridViewContentAlignment.NotSet
        Me.DGVI_EDITAR.HeaderText = " "
        Me.DGVI_EDITAR.Name = "DGVI_EDITAR"
        Me.DGVI_EDITAR.ReadOnly = True
        Me.DGVI_EDITAR.Resizable = Wisej.Web.DataGridViewTriState.[False]
        Me.DGVI_EDITAR.ToolTipText = "Editar"
        Me.DGVI_EDITAR.Width = 22
        '
        'Cve_Operador
        '
        Me.Cve_Operador.DataPropertyName = "Cve_Operador"
        Me.Cve_Operador.HeaderText = "Clave"
        Me.Cve_Operador.Name = "Cve_Operador"
        Me.Cve_Operador.ReadOnly = True
        Me.Cve_Operador.Resizable = Wisej.Web.DataGridViewTriState.[False]
        Me.Cve_Operador.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        '
        'Contrasena
        '
        Me.Contrasena.DataPropertyName = "Contrasena"
        Me.Contrasena.HeaderText = "contraseña"
        Me.Contrasena.Name = "Contrasena"
        Me.Contrasena.ReadOnly = True
        Me.Contrasena.Resizable = Wisej.Web.DataGridViewTriState.[False]
        Me.Contrasena.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.Contrasena.Visible = False
        '
        'Fecha_Alta
        '
        Me.Fecha_Alta.DataPropertyName = "Fecha_Alta"
        Me.Fecha_Alta.HeaderText = "Fecha Alta"
        Me.Fecha_Alta.Name = "Fecha_Alta"
        Me.Fecha_Alta.ReadOnly = True
        Me.Fecha_Alta.Resizable = Wisej.Web.DataGridViewTriState.[False]
        Me.Fecha_Alta.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        '
        'Cve_Rol
        '
        Me.Cve_Rol.DataPropertyName = "Cve_Rol"
        Me.Cve_Rol.HeaderText = "Clave Rol"
        Me.Cve_Rol.Name = "Cve_Rol"
        Me.Cve_Rol.ReadOnly = True
        Me.Cve_Rol.Resizable = Wisej.Web.DataGridViewTriState.[False]
        Me.Cve_Rol.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.Cve_Rol.Visible = False
        '
        'ROL
        '
        Me.ROL.DataPropertyName = "ROL"
        Me.ROL.HeaderText = "Rol"
        Me.ROL.Name = "ROL"
        Me.ROL.ReadOnly = True
        Me.ROL.Resizable = Wisej.Web.DataGridViewTriState.[False]
        Me.ROL.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "Nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.Resizable = Wisej.Web.DataGridViewTriState.[False]
        Me.Nombre.SortMode = Wisej.Web.DataGridViewColumnSortMode.NotSortable
        Me.Nombre.Width = 300
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Nothing
        Me.BindingNavigator1.BindingSource = Me.BindingSource1
        Me.BindingNavigator1.Controls.Add(Me.buttonMoveFirst)
        Me.BindingNavigator1.Controls.Add(Me.buttonMovePrevious)
        Me.BindingNavigator1.Controls.Add(Me.separatorLeft)
        Me.BindingNavigator1.Controls.Add(Me.textBoxPosition)
        Me.BindingNavigator1.Controls.Add(Me.labelCount)
        Me.BindingNavigator1.Controls.Add(Me.separatorRight)
        Me.BindingNavigator1.Controls.Add(Me.buttonMoveNext)
        Me.BindingNavigator1.Controls.Add(Me.buttonMoveLast)
        Me.BindingNavigator1.Controls.Add(Me.separatorControl)
        Me.BindingNavigator1.CountItem = Me.labelCount
        Me.BindingNavigator1.DeleteItem = Nothing
        Me.BindingNavigator1.Dock = Wisej.Web.DockStyle.Bottom
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 284)
        Me.BindingNavigator1.MoveFirstItem = Me.buttonMoveFirst
        Me.BindingNavigator1.MoveLastItem = Me.buttonMoveLast
        Me.BindingNavigator1.MoveNextItem = Me.buttonMoveNext
        Me.BindingNavigator1.MovePreviousItem = Me.buttonMovePrevious
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.textBoxPosition
        Me.BindingNavigator1.Size = New System.Drawing.Size(1223, 24)
        Me.BindingNavigator1.TabIndex = 0
        Me.BindingNavigator1.TabStop = True
        '
        'buttonMoveFirst
        '
        Me.buttonMoveFirst.ImageSource = "icon-first"
        Me.buttonMoveFirst.Location = New System.Drawing.Point(3, 3)
        Me.buttonMoveFirst.Name = "buttonMoveFirst"
        Me.buttonMoveFirst.Size = New System.Drawing.Size(37, 28)
        Me.buttonMoveFirst.TabIndex = 0
        '
        'buttonMovePrevious
        '
        Me.buttonMovePrevious.ImageSource = "icon-left"
        Me.buttonMovePrevious.Location = New System.Drawing.Point(46, 3)
        Me.buttonMovePrevious.Name = "buttonMovePrevious"
        Me.buttonMovePrevious.Size = New System.Drawing.Size(37, 28)
        Me.buttonMovePrevious.TabIndex = 1
        '
        'separatorLeft
        '
        Me.separatorLeft.Location = New System.Drawing.Point(89, 3)
        Me.separatorLeft.Name = "separatorLeft"
        Me.separatorLeft.Orientation = Wisej.Web.Orientation.Vertical
        Me.separatorLeft.Padding = New Wisej.Web.Padding(0, 5, 0, 5)
        Me.separatorLeft.Size = New System.Drawing.Size(14, 28)
        '
        'textBoxPosition
        '
        Me.textBoxPosition.AutoSize = False
        Me.textBoxPosition.Location = New System.Drawing.Point(109, 3)
        Me.textBoxPosition.Name = "textBoxPosition"
        Me.textBoxPosition.Size = New System.Drawing.Size(50, 28)
        Me.textBoxPosition.TabIndex = 6
        Me.textBoxPosition.Text = "0"
        '
        'labelCount
        '
        Me.labelCount.Location = New System.Drawing.Point(165, 3)
        Me.labelCount.Name = "labelCount"
        Me.labelCount.Size = New System.Drawing.Size(39, 28)
        Me.labelCount.TabIndex = 7
        Me.labelCount.Text = "de {0}"
        Me.labelCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'separatorRight
        '
        Me.separatorRight.Location = New System.Drawing.Point(210, 3)
        Me.separatorRight.Name = "separatorRight"
        Me.separatorRight.Orientation = Wisej.Web.Orientation.Vertical
        Me.separatorRight.Padding = New Wisej.Web.Padding(0, 5, 0, 5)
        Me.separatorRight.Size = New System.Drawing.Size(14, 28)
        '
        'buttonMoveNext
        '
        Me.buttonMoveNext.ImageSource = "icon-right"
        Me.buttonMoveNext.Location = New System.Drawing.Point(230, 3)
        Me.buttonMoveNext.Name = "buttonMoveNext"
        Me.buttonMoveNext.Size = New System.Drawing.Size(37, 28)
        Me.buttonMoveNext.TabIndex = 2
        '
        'buttonMoveLast
        '
        Me.buttonMoveLast.ImageSource = "icon-last"
        Me.buttonMoveLast.Location = New System.Drawing.Point(273, 3)
        Me.buttonMoveLast.Name = "buttonMoveLast"
        Me.buttonMoveLast.Size = New System.Drawing.Size(37, 28)
        Me.buttonMoveLast.TabIndex = 3
        '
        'separatorControl
        '
        Me.separatorControl.Location = New System.Drawing.Point(316, 3)
        Me.separatorControl.Name = "separatorControl"
        Me.separatorControl.Orientation = Wisej.Web.Orientation.Vertical
        Me.separatorControl.Padding = New Wisej.Web.Padding(0, 5, 0, 5)
        Me.separatorControl.Size = New System.Drawing.Size(14, 28)
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.BlinkRate = 3
        Me.ErrorProvider1.ContainerControl = Me
        '
        'FiltroGrillaSax1
        '
        Me.FiltroGrillaSax1.AutoValidate = Wisej.Web.AutoValidate.EnablePreventFocusChange
        Me.FiltroGrillaSax1.Dock = Wisej.Web.DockStyle.Top
        Me.FiltroGrillaSax1.Location = New System.Drawing.Point(0, 310)
        Me.FiltroGrillaSax1.Name = "FiltroGrillaSax1"
        Me.FiltroGrillaSax1.Size = New System.Drawing.Size(1225, 30)
        Me.FiltroGrillaSax1.TabIndex = 5
        '
        'DataSet_pCAT_CLIENTES_B
        '
        Me.DataSet_pCAT_CLIENTES_B.DataSetName = "DataSet_pCAT_CLIENTES_B"
        Me.DataSet_pCAT_CLIENTES_B.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'DataSet_pCAT_CLIENTES_BUSQUEDA_B
        '
        Me.DataSet_pCAT_CLIENTES_BUSQUEDA_B.DataSetName = "DataSet_pCAT_CLIENTES_BUSQUEDA_B"
        Me.DataSet_pCAT_CLIENTES_BUSQUEDA_B.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BS_Clientes
        '
        Me.BS_Clientes.DataSource = Me.DataSet_pCAT_CLIENTES_BUSQUEDA_B
        Me.BS_Clientes.Position = 0
        '
        'Cat_Operadores
        '
        Me.ClientSize = New System.Drawing.Size(1225, 650)
        Me.Controls.Add(Me.DGV_Operadores)
        Me.Controls.Add(Me.FiltroGrillaSax1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RibbonBar1)
        Me.Name = "Cat_Operadores"
        Me.Text = "Catálogo Operadores"
        Me.WindowState = Wisej.Web.FormWindowState.Maximized
        Me.Panel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_pCAT_OPERADORES_B, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.DGV_Operadores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DGV_Operadores.ResumeLayout(False)
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_pCAT_CLIENTES_B, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_pCAT_CLIENTES_BUSQUEDA_B, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_Clientes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonBar1 As RibbonBar
    Friend WithEvents RibbonBarPage1 As RibbonBarPage
    Friend WithEvents RibbonBarGroup1 As RibbonBarGroup
    Friend WithEvents RBBNUEVO As RibbonBarItemButton
    Friend WithEvents RBBGUARDAR As RibbonBarItemButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents txtContra As TextBox
    Friend WithEvents txtCve_Operador As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ckdEstatus As CheckBox
    Friend WithEvents Label3 As Label
    Friend WithEvents CBxMostrar As CheckBox
    Friend WithEvents DGV_Operadores As DataGridView
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents DataSet_pCAT_OPERADORES_B As DataSet_pCAT_OPERADORES_B
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents DGVI_EDITAR As DataGridViewImageColumn
    Friend WithEvents Cve_Operador As DataGridViewTextBoxColumn
    Friend WithEvents Contrasena As DataGridViewTextBoxColumn
    Friend WithEvents Fecha_Alta As DataGridViewTextBoxColumn
    Friend WithEvents Cve_Rol As DataGridViewTextBoxColumn
    Friend WithEvents ROL As DataGridViewTextBoxColumn
    Friend WithEvents RBBCANCELAR As RibbonBarItemButton
    Friend WithEvents Panel4 As Panel
    Friend WithEvents rbInhabilitado As RadioButton
    Friend WithEvents Label4 As Label
    Friend WithEvents rbHabilitado As RadioButton
    Friend WithEvents cmbRol As ComboBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents FiltroGrillaSax1 As filtroGrillaSax
    Friend WithEvents tbxNombreOperador As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents RibbonBarGroup2 As RibbonBarGroup
    Friend WithEvents RBBSALIR As RibbonBarItemButton
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents buttonMoveFirst As Button
    Friend WithEvents buttonMovePrevious As Button
    Friend WithEvents separatorLeft As Line
    Friend WithEvents textBoxPosition As TextBox
    Friend WithEvents labelCount As Label
    Friend WithEvents separatorRight As Line
    Friend WithEvents buttonMoveNext As Button
    Friend WithEvents buttonMoveLast As Button
    Friend WithEvents separatorControl As Line
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents LstCheck_Clientes As CheckedListBox
    Friend WithEvents DataSet_pCAT_CLIENTES_B As DataSet_pCAT_CLIENTES_B
    Friend WithEvents DataSet_pCAT_CLIENTES_BUSQUEDA_B As DataSet_pCAT_CLIENTES_BUSQUEDA_B
    Friend WithEvents BS_Clientes As BindingSource
End Class