<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cat_Clientes
    Inherits Wisej.Web.Form

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
        Me.RBBNuevo = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBBGuardar = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBBCancelar = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RibbonBarGroup2 = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.RBBSalir = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.Panel1 = New Wisej.Web.Panel()
        Me.Panel3 = New Wisej.Web.Panel()
        Me.DGV_Clientes = New Wisej.Web.DataGridView()
        Me.DGV_Editar = New Wisej.Web.DataGridViewImageColumn()
        Me.colCve_Cliente = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colNombre_Cliente = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colAlias = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colSistema = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colCve_Operador = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colNombre_Operador = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colFACTORUM_USER = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colContrasenafact = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colCant_Timbres = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colHabilitado = New Wisej.Web.DataGridViewCheckBoxColumn()
        Me.BS_Clientes = New Wisej.Web.BindingSource(Me.components)
        Me.DataSet_pCAT_CLIENTES_BUSQUEDA_B = New FactuSax.DataSet_pCAT_CLIENTES_BUSQUEDA_B()
        Me.Panel4 = New Wisej.Web.Panel()
        Me.rbInhabilitado = New Wisej.Web.RadioButton()
        Me.rbHabilitado = New Wisej.Web.RadioButton()
        Me.Label3 = New Wisej.Web.Label()
        Me.Panel2 = New Wisej.Web.Panel()
        Me.GroupBox1 = New Wisej.Web.GroupBox()
        Me.pictureContrasena = New Wisej.Web.PictureBox()
        Me.Num_Timbres = New Wisej.Web.NumericUpDown()
        Me.Chk_Habilitado = New Wisej.Web.CheckBox()
        Me.TBXPDUserPass = New Wisej.Web.TextBox()
        Me.TBXPDUser = New Wisej.Web.TextBox()
        Me.Label6 = New Wisej.Web.Label()
        Me.Label5 = New Wisej.Web.Label()
        Me.GroupBox2 = New Wisej.Web.GroupBox()
        Me.ChkList_Sistemas = New Wisej.Web.CheckedListBox()
        Me.TBAlias = New Wisej.Web.TextBox()
        Me.TBNombre = New Wisej.Web.TextBox()
        Me.TBClave = New Wisej.Web.TextBox()
        Me.Label4 = New Wisej.Web.Label()
        Me.Label2 = New Wisej.Web.Label()
        Me.Label1 = New Wisej.Web.Label()
        Me.PCAT_CLIENTES_BTableAdapter = New FactuSax.DataSet_pCAT_CLIENTES_BTableAdapters.pCAT_CLIENTES_BTableAdapter()
        Me.DataSet_pCAT_SISTEMAS_B = New FactuSax.DataSet_pCAT_SISTEMAS_B()
        Me.BindingSource1 = New Wisej.Web.BindingSource(Me.components)
        Me.PCAT_CLIENTES_BUSQUEDA_BTableAdapter = New FactuSax.DataSet_pCAT_CLIENTES_BUSQUEDA_BTableAdapters.pCAT_CLIENTES_BUSQUEDA_BTableAdapter()
        Me.Label7 = New Wisej.Web.Label()
        Me.Upload1 = New Wisej.Web.Upload()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        CType(Me.DGV_Clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_Clientes, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_pCAT_CLIENTES_BUSQUEDA_B, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.pictureContrasena, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Num_Timbres, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.DataSet_pCAT_SISTEMAS_B, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonBar1
        '
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Pages.Add(Me.RibbonBarPage1)
        Me.RibbonBar1.Size = New System.Drawing.Size(1187, 113)
        '
        'RibbonBarPage1
        '
        Me.RibbonBarPage1.Groups.Add(Me.RibbonBarGroup1)
        Me.RibbonBarPage1.Groups.Add(Me.RibbonBarGroup2)
        Me.RibbonBarPage1.Name = "RibbonBarPage1"
        Me.RibbonBarPage1.Text = "Menu"
        '
        'RibbonBarGroup1
        '
        Me.RibbonBarGroup1.Items.Add(Me.RBBNuevo)
        Me.RibbonBarGroup1.Items.Add(Me.RBBGuardar)
        Me.RibbonBarGroup1.Items.Add(Me.RBBCancelar)
        Me.RibbonBarGroup1.Name = "RibbonBarGroup1"
        Me.RibbonBarGroup1.Text = "Procesos"
        '
        'RBBNuevo
        '
        Me.RBBNuevo.ImageSource = "Resources\Images\Menu\64\Add List Filled-64.png"
        Me.RBBNuevo.Name = "RBBNuevo"
        Me.RBBNuevo.Text = "Nuevo"
        '
        'RBBGuardar
        '
        Me.RBBGuardar.ImageSource = "Resources\Images\Menu\64\Save Filled-64.png"
        Me.RBBGuardar.Name = "RBBGuardar"
        Me.RBBGuardar.Text = "Guardar"
        '
        'RBBCancelar
        '
        Me.RBBCancelar.ImageSource = "Resources\Images\Menu\64\Cancel File Filled-64.png"
        Me.RBBCancelar.Name = "RBBCancelar"
        Me.RBBCancelar.Text = "Cancelar"
        '
        'RibbonBarGroup2
        '
        Me.RibbonBarGroup2.Items.Add(Me.RBBSalir)
        Me.RibbonBarGroup2.Name = "RibbonBarGroup2"
        Me.RibbonBarGroup2.Text = "Salir"
        '
        'RBBSalir
        '
        Me.RBBSalir.ImageSource = "Resources\Images\Menu\64\exit_sign.png"
        Me.RBBSalir.Name = "RBBSalir"
        Me.RBBSalir.Text = "  "
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Dock = Wisej.Web.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 113)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1187, 554)
        Me.Panel1.TabIndex = 1
        Me.Panel1.TabStop = True
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.DGV_Clientes)
        Me.Panel3.Controls.Add(Me.Panel4)
        Me.Panel3.Dock = Wisej.Web.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 171)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(1187, 383)
        Me.Panel3.TabIndex = 1
        Me.Panel3.TabStop = True
        '
        'DGV_Clientes
        '
        Me.DGV_Clientes.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.DGV_Editar, Me.colCve_Cliente, Me.colNombre_Cliente, Me.colAlias, Me.colSistema, Me.colCve_Operador, Me.colNombre_Operador, Me.colFACTORUM_USER, Me.colContrasenafact, Me.colCant_Timbres, Me.colHabilitado})
        Me.DGV_Clientes.DataSource = Me.BS_Clientes
        Me.DGV_Clientes.Dock = Wisej.Web.DockStyle.Fill
        Me.DGV_Clientes.Location = New System.Drawing.Point(0, 25)
        Me.DGV_Clientes.Name = "DGV_Clientes"
        Me.DGV_Clientes.RowHeadersVisible = False
        Me.DGV_Clientes.Size = New System.Drawing.Size(1187, 358)
        Me.DGV_Clientes.TabIndex = 6
        '
        'DGV_Editar
        '
        Me.DGV_Editar.CellImage = Global.FactuSax.My.Resources.Resources.Edit_File_Filled
        Me.DGV_Editar.CellImageAlignment = Wisej.Web.DataGridViewContentAlignment.NotSet
        Me.DGV_Editar.HeaderText = "  "
        Me.DGV_Editar.Name = "DGV_Editar"
        Me.DGV_Editar.Width = 35
        '
        'colCve_Cliente
        '
        Me.colCve_Cliente.DataPropertyName = "Cve_Cliente"
        Me.colCve_Cliente.HeaderText = "Cve_Cliente"
        Me.colCve_Cliente.Name = "colCve_Cliente"
        '
        'colNombre_Cliente
        '
        Me.colNombre_Cliente.DataPropertyName = "Nombre_Cliente"
        Me.colNombre_Cliente.HeaderText = "Nombre_Cliente"
        Me.colNombre_Cliente.Name = "colNombre_Cliente"
        '
        'colAlias
        '
        Me.colAlias.DataPropertyName = "Alias"
        Me.colAlias.HeaderText = "Alias"
        Me.colAlias.Name = "colAlias"
        '
        'colSistema
        '
        Me.colSistema.DataPropertyName = "Sistema"
        Me.colSistema.HeaderText = "Sistema"
        Me.colSistema.Name = "colSistema"
        '
        'colCve_Operador
        '
        Me.colCve_Operador.DataPropertyName = "Cve_Operador"
        Me.colCve_Operador.HeaderText = "Cve_Operador"
        Me.colCve_Operador.Name = "colCve_Operador"
        '
        'colNombre_Operador
        '
        Me.colNombre_Operador.DataPropertyName = "Nombre_Operador"
        Me.colNombre_Operador.HeaderText = "Nombre_Operador"
        Me.colNombre_Operador.Name = "colNombre_Operador"
        '
        'colFACTORUM_USER
        '
        Me.colFACTORUM_USER.DataPropertyName = "FACTORUM_USER"
        Me.colFACTORUM_USER.HeaderText = "FACTORUM_USER"
        Me.colFACTORUM_USER.Name = "colFACTORUM_USER"
        '
        'colContrasenafact
        '
        Me.colContrasenafact.DataPropertyName = "ContrasenaFact"
        Me.colContrasenafact.HeaderText = "ContrasenaFact"
        Me.colContrasenafact.Name = "colContrasenafact"
        Me.colContrasenafact.ReadOnly = True
        '
        'colCant_Timbres
        '
        Me.colCant_Timbres.DataPropertyName = "Cant_Timbres"
        Me.colCant_Timbres.HeaderText = "Cant_Timbres"
        Me.colCant_Timbres.Name = "colCant_Timbres"
        '
        'colHabilitado
        '
        Me.colHabilitado.DataPropertyName = "Habilitado"
        Me.colHabilitado.HeaderText = "Habilitado"
        Me.colHabilitado.Name = "colHabilitado"
        '
        'BS_Clientes
        '
        Me.BS_Clientes.DataMember = "pCAT_CLIENTES_BUSQUEDA_B"
        Me.BS_Clientes.DataSource = Me.DataSet_pCAT_CLIENTES_BUSQUEDA_B
        '
        'DataSet_pCAT_CLIENTES_BUSQUEDA_B
        '
        Me.DataSet_pCAT_CLIENTES_BUSQUEDA_B.DataSetName = "DataSet_pCAT_CLIENTES_BUSQUEDA_B"
        Me.DataSet_pCAT_CLIENTES_BUSQUEDA_B.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(191, 219, 255)
        Me.Panel4.Controls.Add(Me.rbInhabilitado)
        Me.Panel4.Controls.Add(Me.rbHabilitado)
        Me.Panel4.Controls.Add(Me.Label3)
        Me.Panel4.Dock = Wisej.Web.DockStyle.Top
        Me.Panel4.Location = New System.Drawing.Point(0, 0)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(1187, 25)
        Me.Panel4.TabIndex = 5
        Me.Panel4.TabStop = True
        '
        'rbInhabilitado
        '
        Me.rbInhabilitado.Location = New System.Drawing.Point(223, 2)
        Me.rbInhabilitado.Name = "rbInhabilitado"
        Me.rbInhabilitado.Size = New System.Drawing.Size(111, 22)
        Me.rbInhabilitado.TabIndex = 1
        Me.rbInhabilitado.Text = "Desactivados"
        '
        'rbHabilitado
        '
        Me.rbHabilitado.Checked = True
        Me.rbHabilitado.Location = New System.Drawing.Point(125, 2)
        Me.rbHabilitado.Name = "rbHabilitado"
        Me.rbHabilitado.Size = New System.Drawing.Size(97, 22)
        Me.rbHabilitado.TabIndex = 1
        Me.rbHabilitado.TabStop = True
        Me.rbHabilitado.Text = "Habilitados"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 6)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Mostrar los registros:"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.GroupBox1)
        Me.Panel2.Dock = Wisej.Web.DockStyle.Top
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1187, 171)
        Me.Panel2.TabIndex = 0
        Me.Panel2.TabStop = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Upload1)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.pictureContrasena)
        Me.GroupBox1.Controls.Add(Me.Num_Timbres)
        Me.GroupBox1.Controls.Add(Me.Chk_Habilitado)
        Me.GroupBox1.Controls.Add(Me.TBXPDUserPass)
        Me.GroupBox1.Controls.Add(Me.TBXPDUser)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.TBAlias)
        Me.GroupBox1.Controls.Add(Me.TBNombre)
        Me.GroupBox1.Controls.Add(Me.TBClave)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Dock = Wisej.Web.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(0, 0)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(1187, 171)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.Text = "Datos Principales"
        '
        'pictureContrasena
        '
        Me.pictureContrasena.ImageSource = "Resources\Images\Menu\25\eye-slash.png"
        Me.pictureContrasena.Location = New System.Drawing.Point(671, 60)
        Me.pictureContrasena.Name = "pictureContrasena"
        Me.pictureContrasena.Size = New System.Drawing.Size(24, 24)
        '
        'Num_Timbres
        '
        Me.Num_Timbres.LabelText = "Timbres Permitidos"
        Me.Num_Timbres.Location = New System.Drawing.Point(440, 89)
        Me.Num_Timbres.Name = "Num_Timbres"
        Me.Num_Timbres.Size = New System.Drawing.Size(120, 42)
        Me.Num_Timbres.TabIndex = 21
        '
        'Chk_Habilitado
        '
        Me.Chk_Habilitado.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Bottom) _
            Or Wisej.Web.AnchorStyles.Left), Wisej.Web.AnchorStyles)
        Me.Chk_Habilitado.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Chk_Habilitado.Location = New System.Drawing.Point(440, 137)
        Me.Chk_Habilitado.Name = "Chk_Habilitado"
        Me.Chk_Habilitado.Size = New System.Drawing.Size(90, 22)
        Me.Chk_Habilitado.TabIndex = 20
        Me.Chk_Habilitado.Text = "Habilitado"
        '
        'TBXPDUserPass
        '
        Me.TBXPDUserPass.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Bottom) _
            Or Wisej.Web.AnchorStyles.Left), Wisej.Web.AnchorStyles)
        Me.TBXPDUserPass.InputType.Type = Wisej.Web.TextBoxType.Password
        Me.TBXPDUserPass.Location = New System.Drawing.Point(440, 61)
        Me.TBXPDUserPass.Name = "TBXPDUserPass"
        Me.TBXPDUserPass.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBXPDUserPass.Size = New System.Drawing.Size(216, 22)
        Me.TBXPDUserPass.TabIndex = 19
        '
        'TBXPDUser
        '
        Me.TBXPDUser.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Bottom) _
            Or Wisej.Web.AnchorStyles.Left), Wisej.Web.AnchorStyles)
        Me.TBXPDUser.Location = New System.Drawing.Point(440, 31)
        Me.TBXPDUser.Name = "TBXPDUser"
        Me.TBXPDUser.Size = New System.Drawing.Size(216, 22)
        Me.TBXPDUser.TabIndex = 18
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(318, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(106, 15)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Contraseña XPD:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(341, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(83, 15)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Usuario XPD:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.ChkList_Sistemas)
        Me.GroupBox2.Dock = Wisej.Web.DockStyle.Right
        Me.GroupBox2.Location = New System.Drawing.Point(777, 18)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(407, 150)
        Me.GroupBox2.TabIndex = 15
        Me.GroupBox2.Text = "Sistemas"
        '
        'ChkList_Sistemas
        '
        Me.ChkList_Sistemas.Dock = Wisej.Web.DockStyle.Fill
        Me.ChkList_Sistemas.Location = New System.Drawing.Point(3, 18)
        Me.ChkList_Sistemas.Name = "ChkList_Sistemas"
        Me.ChkList_Sistemas.Size = New System.Drawing.Size(401, 129)
        Me.ChkList_Sistemas.TabIndex = 0
        '
        'TBAlias
        '
        Me.TBAlias.Location = New System.Drawing.Point(73, 91)
        Me.TBAlias.Name = "TBAlias"
        Me.TBAlias.Size = New System.Drawing.Size(216, 22)
        Me.TBAlias.TabIndex = 14
        '
        'TBNombre
        '
        Me.TBNombre.Location = New System.Drawing.Point(73, 59)
        Me.TBNombre.Name = "TBNombre"
        Me.TBNombre.Size = New System.Drawing.Size(216, 22)
        Me.TBNombre.TabIndex = 13
        '
        'TBClave
        '
        Me.TBClave.Location = New System.Drawing.Point(73, 28)
        Me.TBClave.Name = "TBClave"
        Me.TBClave.Size = New System.Drawing.Size(216, 22)
        Me.TBClave.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(21, 95)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(36, 15)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Alias:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 63)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(54, 15)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(16, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 15)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Clave:"
        '
        'PCAT_CLIENTES_BTableAdapter
        '
        Me.PCAT_CLIENTES_BTableAdapter.ClearBeforeFill = True
        '
        'DataSet_pCAT_SISTEMAS_B
        '
        Me.DataSet_pCAT_SISTEMAS_B.DataSetName = "DataSet_pCAT_SISTEMAS_B"
        Me.DataSet_pCAT_SISTEMAS_B.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BindingSource1
        '
        Me.BindingSource1.DataSource = Me.DataSet_pCAT_SISTEMAS_B
        Me.BindingSource1.Position = 0
        '
        'PCAT_CLIENTES_BUSQUEDA_BTableAdapter
        '
        Me.PCAT_CLIENTES_BUSQUEDA_BTableAdapter.ClearBeforeFill = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(3, 123)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(58, 15)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Logotipo:"
        '
        'Upload1
        '
        Me.Upload1.HideValue = True
        Me.Upload1.Location = New System.Drawing.Point(73, 119)
        Me.Upload1.Name = "Upload1"
        Me.Upload1.Size = New System.Drawing.Size(78, 22)
        Me.Upload1.TabIndex = 23
        Me.Upload1.Text = "Cargar"
        '
        'Cat_Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1187, 667)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RibbonBar1)
        Me.Name = "Cat_Clientes"
        Me.Text = "Clientes"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        CType(Me.DGV_Clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_Clientes, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_pCAT_CLIENTES_BUSQUEDA_B, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.pictureContrasena, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Num_Timbres, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.DataSet_pCAT_SISTEMAS_B, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RibbonBar1 As Ext.RibbonBar.RibbonBar
    Friend WithEvents RibbonBarPage1 As Ext.RibbonBar.RibbonBarPage
    Friend WithEvents RibbonBarGroup1 As Ext.RibbonBar.RibbonBarGroup
    Friend WithEvents RBBNuevo As Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents RBBGuardar As Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents RBBCancelar As Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents RibbonBarGroup2 As Ext.RibbonBar.RibbonBarGroup
    Friend WithEvents RBBSalir As Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DGV_Clientes As DataGridView
    Friend WithEvents Panel4 As Panel
    Friend WithEvents rbInhabilitado As RadioButton
    Friend WithEvents rbHabilitado As RadioButton
    Friend WithEvents Label3 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TBAlias As TextBox
    Friend WithEvents TBNombre As TextBox
    Friend WithEvents TBClave As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents colCve_Cliente As DataGridViewTextBoxColumn
    Friend WithEvents colNombre_Cliente As DataGridViewTextBoxColumn
    Friend WithEvents colSistema As DataGridViewTextBoxColumn
    Friend WithEvents colCve_Operador As DataGridViewTextBoxColumn
    Friend WithEvents colNombre_Operador As DataGridViewTextBoxColumn
    Friend WithEvents colFACTORUM_USER As DataGridViewTextBoxColumn
    Friend WithEvents colContrasenafact As DataGridViewTextBoxColumn
    Friend WithEvents DataSet_pCAT_CLIENTES_BUSQUEDA_B As DataSet_pCAT_CLIENTES_BUSQUEDA_B
    Friend WithEvents PCAT_CLIENTES_BTableAdapter As DataSet_pCAT_CLIENTES_BTableAdapters.pCAT_CLIENTES_BTableAdapter
    Friend WithEvents Label5 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents ChkList_Sistemas As CheckedListBox
    Friend WithEvents TBXPDUserPass As TextBox
    Friend WithEvents TBXPDUser As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents DGV_Editar As DataGridViewImageColumn
    Friend WithEvents Chk_Habilitado As CheckBox
    Friend WithEvents Num_Timbres As NumericUpDown
    Friend WithEvents colAlias As DataGridViewTextBoxColumn
    Friend WithEvents colCant_Timbres As DataGridViewTextBoxColumn
    Friend WithEvents colHabilitado As DataGridViewCheckBoxColumn
    Friend WithEvents DataSet_pCAT_SISTEMAS_B As DataSet_pCAT_SISTEMAS_B
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents BS_Clientes As BindingSource
    Friend WithEvents PCAT_CLIENTES_BUSQUEDA_BTableAdapter As DataSet_pCAT_CLIENTES_BUSQUEDA_BTableAdapters.pCAT_CLIENTES_BUSQUEDA_BTableAdapter
    Friend WithEvents pictureContrasena As PictureBox
    Friend WithEvents Upload1 As Upload
    Friend WithEvents Label7 As Label
End Class
