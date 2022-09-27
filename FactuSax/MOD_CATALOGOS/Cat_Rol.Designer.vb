
Imports Wisej.Web.Ext.RibbonBar

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Cat_Rol
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
        Dim DataGridViewCellStyle1 As Wisej.Web.DataGridViewCellStyle = New Wisej.Web.DataGridViewCellStyle()
        Me.BindingSource1 = New Wisej.Web.BindingSource(Me.components)
        Me.Dataset_pCAT_ROL_B = New FactuSax.Dataset_pCAT_ROL_B()
        Me.DGVI_EDITAR = New Wisej.Web.DataGridViewImageColumn()
        Me.CVE_ROL = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.Label3 = New Wisej.Web.Label()
        Me.RibbonBarGroup1 = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.RBBNUEVO = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBBGUARDAR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBBCANCELAR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.ckdEstatus = New Wisej.Web.CheckBox()
        Me.rbHabilitado = New Wisej.Web.RadioButton()
        Me.ROL = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.Label2 = New Wisej.Web.Label()
        Me.RibbonBarPage1 = New Wisej.Web.Ext.RibbonBar.RibbonBarPage()
        Me.RibbonBarGroup2 = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.RBBSALIR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.rbInhabilitado = New Wisej.Web.RadioButton()
        Me.Label1 = New Wisej.Web.Label()
        Me.Panel2 = New Wisej.Web.Panel()
        Me.txtCveRol = New Wisej.Web.TextBox()
        Me.txtDescripcion = New Wisej.Web.TextBox()
        Me.Panel1 = New Wisej.Web.Panel()
        Me.RibbonBar1 = New Wisej.Web.Ext.RibbonBar.RibbonBar()
        Me.DGVRol = New Wisej.Web.DataGridView()
        Me.BindingNavigator1 = New Wisej.Web.BindingNavigator(Me.components)
        Me.buttonAddNew = New Wisej.Web.Button()
        Me.buttonMoveFirst = New Wisej.Web.Button()
        Me.buttonMovePrevious = New Wisej.Web.Button()
        Me.separatorLeft = New Wisej.Web.Line()
        Me.textBoxPosition = New Wisej.Web.TextBox()
        Me.labelCount = New Wisej.Web.Label()
        Me.separatorRight = New Wisej.Web.Line()
        Me.buttonMoveNext = New Wisej.Web.Button()
        Me.buttonMoveLast = New Wisej.Web.Button()
        Me.separatorControl = New Wisej.Web.Line()
        Me.buttonDelete = New Wisej.Web.Button()
        Me.ToolTip1 = New Wisej.Web.ToolTip(Me.components)
        Me.FiltroGrillaSax1 = New FactuSax.filtroGrillaSax()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Dataset_pCAT_ROL_B, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.DGVRol, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DGVRol.SuspendLayout()
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BindingNavigator1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "pCAT_ROL_B"
        Me.BindingSource1.DataSource = Me.Dataset_pCAT_ROL_B
        '
        'Dataset_pCAT_ROL_B
        '
        Me.Dataset_pCAT_ROL_B.DataSetName = "Dataset_pCAT_ROL_B"
        Me.Dataset_pCAT_ROL_B.EnforceConstraints = False
        Me.Dataset_pCAT_ROL_B.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'CVE_ROL
        '
        Me.CVE_ROL.DataPropertyName = "Cve_Rol"
        Me.CVE_ROL.HeaderText = "Clave"
        Me.CVE_ROL.Name = "CVE_ROL"
        Me.CVE_ROL.ReadOnly = True
        Me.CVE_ROL.Resizable = Wisej.Web.DataGridViewTriState.[False]
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 7)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(126, 15)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Mostrar los registros:"
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
        'ckdEstatus
        '
        Me.ckdEstatus.Location = New System.Drawing.Point(380, 29)
        Me.ckdEstatus.Name = "ckdEstatus"
        Me.ckdEstatus.Size = New System.Drawing.Size(90, 22)
        Me.ckdEstatus.TabIndex = 5
        Me.ckdEstatus.Text = "Habilitado"
        Me.ToolTip1.SetToolTip(Me.ckdEstatus, "Habilitar / Desactivar el registro")
        '
        'rbHabilitado
        '
        Me.rbHabilitado.Checked = True
        Me.rbHabilitado.Location = New System.Drawing.Point(122, 3)
        Me.rbHabilitado.Name = "rbHabilitado"
        Me.rbHabilitado.Size = New System.Drawing.Size(97, 22)
        Me.rbHabilitado.TabIndex = 1
        Me.rbHabilitado.TabStop = True
        Me.rbHabilitado.Text = "Habilitados"
        Me.ToolTip1.SetToolTip(Me.rbHabilitado, "Mostrar registros habilitados")
        '
        'ROL
        '
        Me.ROL.DataPropertyName = "ROL"
        Me.ROL.HeaderText = "Rol"
        Me.ROL.Name = "ROL"
        Me.ROL.ReadOnly = True
        Me.ROL.Resizable = Wisej.Web.DataGridViewTriState.[False]
        Me.ROL.Width = 250
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(127, 10)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(24, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Rol"
        '
        'RibbonBarPage1
        '
        Me.RibbonBarPage1.Groups.Add(Me.RibbonBarGroup1)
        Me.RibbonBarPage1.Groups.Add(Me.RibbonBarGroup2)
        Me.RibbonBarPage1.Name = "RibbonBarPage1"
        Me.RibbonBarPage1.Text = "Menú"
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
        'rbInhabilitado
        '
        Me.rbInhabilitado.Location = New System.Drawing.Point(208, 3)
        Me.rbInhabilitado.Name = "rbInhabilitado"
        Me.rbInhabilitado.Size = New System.Drawing.Size(111, 22)
        Me.rbInhabilitado.TabIndex = 2
        Me.rbInhabilitado.Text = "Desactivados"
        Me.ToolTip1.SetToolTip(Me.rbInhabilitado, "Mostrar registros desactivados")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 10)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Clave"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(191, 219, 255)
        Me.Panel2.Controls.Add(Me.rbInhabilitado)
        Me.Panel2.Controls.Add(Me.rbHabilitado)
        Me.Panel2.Controls.Add(Me.Label3)
        Me.Panel2.Dock = Wisej.Web.DockStyle.Bottom
        Me.Panel2.Location = New System.Drawing.Point(0, 57)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1122, 27)
        Me.Panel2.TabIndex = 4
        Me.Panel2.TabStop = True
        '
        'txtCveRol
        '
        Me.txtCveRol.Location = New System.Drawing.Point(12, 26)
        Me.txtCveRol.Name = "txtCveRol"
        Me.txtCveRol.Size = New System.Drawing.Size(100, 22)
        Me.txtCveRol.TabIndex = 2
        Me.ToolTip1.SetToolTip(Me.txtCveRol, "Escriba la nueva clave de Rol")
        '
        'txtDescripcion
        '
        Me.txtDescripcion.Location = New System.Drawing.Point(130, 26)
        Me.txtDescripcion.Name = "txtDescripcion"
        Me.txtDescripcion.Size = New System.Drawing.Size(231, 22)
        Me.txtDescripcion.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.txtDescripcion, "Escriba el rol")
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.ckdEstatus)
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.txtDescripcion)
        Me.Panel1.Controls.Add(Me.txtCveRol)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Dock = Wisej.Web.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 109)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(1122, 84)
        Me.Panel1.TabIndex = 1
        Me.Panel1.TabStop = True
        '
        'RibbonBar1
        '
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Pages.Add(Me.RibbonBarPage1)
        Me.RibbonBar1.Size = New System.Drawing.Size(1122, 109)
        '
        'DGVRol
        '
        Me.DGVRol.AutoGenerateColumns = False
        DataGridViewCellStyle1.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = Wisej.Web.DataGridViewTriState.[True]
        Me.DGVRol.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGVRol.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.DGVI_EDITAR, Me.CVE_ROL, Me.ROL})
        Me.DGVRol.Controls.Add(Me.BindingNavigator1)
        Me.DGVRol.DataSource = Me.BindingSource1
        Me.DGVRol.Dock = Wisej.Web.DockStyle.Fill
        Me.DGVRol.Location = New System.Drawing.Point(0, 223)
        Me.DGVRol.Name = "DGVRol"
        Me.DGVRol.RowHeadersVisible = False
        Me.DGVRol.RowHeadersWidthSizeMode = Wisej.Web.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders
        Me.DGVRol.Size = New System.Drawing.Size(1122, 438)
        Me.DGVRol.TabIndex = 2
        '
        'BindingNavigator1
        '
        Me.BindingNavigator1.AddNewItem = Me.buttonAddNew
        Me.BindingNavigator1.Controls.Add(Me.buttonMoveFirst)
        Me.BindingNavigator1.Controls.Add(Me.buttonMovePrevious)
        Me.BindingNavigator1.Controls.Add(Me.separatorLeft)
        Me.BindingNavigator1.Controls.Add(Me.textBoxPosition)
        Me.BindingNavigator1.Controls.Add(Me.labelCount)
        Me.BindingNavigator1.Controls.Add(Me.separatorRight)
        Me.BindingNavigator1.Controls.Add(Me.buttonMoveNext)
        Me.BindingNavigator1.Controls.Add(Me.buttonMoveLast)
        Me.BindingNavigator1.Controls.Add(Me.separatorControl)
        Me.BindingNavigator1.Controls.Add(Me.buttonAddNew)
        Me.BindingNavigator1.Controls.Add(Me.buttonDelete)
        Me.BindingNavigator1.CountItem = Me.labelCount
        Me.BindingNavigator1.CountItemFormat = "of {0}"
        Me.BindingNavigator1.DeleteItem = Me.buttonDelete
        Me.BindingNavigator1.Dock = Wisej.Web.DockStyle.Bottom
        Me.BindingNavigator1.Location = New System.Drawing.Point(0, 408)
        Me.BindingNavigator1.MoveFirstItem = Me.buttonMoveFirst
        Me.BindingNavigator1.MoveLastItem = Me.buttonMoveLast
        Me.BindingNavigator1.MoveNextItem = Me.buttonMoveNext
        Me.BindingNavigator1.MovePreviousItem = Me.buttonMovePrevious
        Me.BindingNavigator1.Name = "BindingNavigator1"
        Me.BindingNavigator1.PositionItem = Me.textBoxPosition
        Me.BindingNavigator1.Size = New System.Drawing.Size(1120, 28)
        Me.BindingNavigator1.TabIndex = 0
        Me.BindingNavigator1.TabStop = True
        '
        'buttonAddNew
        '
        Me.buttonAddNew.ImageSource = "table-row-new"
        Me.buttonAddNew.Location = New System.Drawing.Point(336, 3)
        Me.buttonAddNew.Name = "buttonAddNew"
        Me.buttonAddNew.Size = New System.Drawing.Size(37, 28)
        Me.buttonAddNew.TabIndex = 4
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
        Me.labelCount.Text = "of {0}"
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
        'buttonDelete
        '
        Me.buttonDelete.ImageSource = "icon-close"
        Me.buttonDelete.Location = New System.Drawing.Point(379, 3)
        Me.buttonDelete.Name = "buttonDelete"
        Me.buttonDelete.Size = New System.Drawing.Size(37, 28)
        Me.buttonDelete.TabIndex = 5
        '
        'FiltroGrillaSax1
        '
        Me.FiltroGrillaSax1.AutoValidate = Wisej.Web.AutoValidate.EnablePreventFocusChange
        Me.FiltroGrillaSax1.Dock = Wisej.Web.DockStyle.Top
        Me.FiltroGrillaSax1.Location = New System.Drawing.Point(0, 193)
        Me.FiltroGrillaSax1.Name = "FiltroGrillaSax1"
        Me.FiltroGrillaSax1.Size = New System.Drawing.Size(1122, 30)
        Me.FiltroGrillaSax1.TabIndex = 4
        '
        'Cat_Rol
        '
        Me.ClientSize = New System.Drawing.Size(1122, 661)
        Me.Controls.Add(Me.DGVRol)
        Me.Controls.Add(Me.FiltroGrillaSax1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RibbonBar1)
        Me.Name = "Cat_Rol"
        Me.Text = "Catálogo Rol"
        Me.WindowState = Wisej.Web.FormWindowState.Maximized
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Dataset_pCAT_ROL_B, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.DGVRol, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DGVRol.ResumeLayout(False)
        CType(Me.BindingNavigator1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BindingNavigator1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Dataset_pCAT_ROL_B As Dataset_pCAT_ROL_B
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DGVI_EDITAR As DataGridViewImageColumn
    Friend WithEvents CVE_ROL As DataGridViewTextBoxColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents RibbonBarGroup1 As RibbonBarGroup
    Friend WithEvents RBBNUEVO As RibbonBarItemButton
    Friend WithEvents RBBGUARDAR As RibbonBarItemButton
    Friend WithEvents RBBCANCELAR As RibbonBarItemButton
    Friend WithEvents ckdEstatus As CheckBox
    Friend WithEvents rbHabilitado As RadioButton
    Friend WithEvents ROL As DataGridViewTextBoxColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents RibbonBarPage1 As RibbonBarPage
    Friend WithEvents rbInhabilitado As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents txtCveRol As TextBox
    Friend WithEvents txtDescripcion As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents RibbonBar1 As RibbonBar
    Friend WithEvents DGVRol As DataGridView
    Friend WithEvents FiltroGrillaSax1 As filtroGrillaSax
    Friend WithEvents RibbonBarGroup2 As RibbonBarGroup
    Friend WithEvents RBBSALIR As RibbonBarItemButton
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents BindingNavigator1 As BindingNavigator
    Friend WithEvents buttonAddNew As Button
    Friend WithEvents buttonMoveFirst As Button
    Friend WithEvents buttonMovePrevious As Button
    Friend WithEvents separatorLeft As Line
    Friend WithEvents textBoxPosition As TextBox
    Friend WithEvents labelCount As Label
    Friend WithEvents separatorRight As Line
    Friend WithEvents buttonMoveNext As Button
    Friend WithEvents buttonMoveLast As Button
    Friend WithEvents separatorControl As Line
    Friend WithEvents buttonDelete As Button
End Class