


'Imports System.Windows.Forms

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class filtroGrillaSax
    Inherits Wisej.Web.UserControl
    'Inherits  UserControl

    'UserControl1 overrides dispose to clean up the component list.
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
        Me.lblBuscar = New Wisej.Web.Label()
        Me.cmbBuscar = New Wisej.Web.ComboBox()
        Me.txtFiltros = New Wisej.Web.TextBox()
        Me.panelEtiquetas = New Wisej.Web.FlowLayoutPanel()
        Me.panelFiltros = New Wisej.Web.Panel()
        Me.btnElegirColumnas = New Wisej.Web.Button()
        Me.btnBDFile = New Wisej.Web.Button()
        Me.BtnExportar = New Wisej.Web.Button()
        Me.cmbConcatenar = New Wisej.Web.ComboBox()
        Me.dtpFecha = New Wisej.Web.DateTimePicker()
        Me.cmbExpresion = New Wisej.Web.ComboBox()
        Me.btnLimpiar = New Wisej.Web.Button()
        Me.btnBuscar = New Wisej.Web.Button()
        Me.ToolTip1 = New Wisej.Web.ToolTip(Me.components)
        Me.ContextMenu1 = New Wisej.Web.ContextMenu()
        Me.MenuItem1 = New Wisej.Web.MenuItem()
        Me.panelFiltros.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblBuscar
        '
        Me.lblBuscar.AutoSize = True
        Me.lblBuscar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lblBuscar.Location = New System.Drawing.Point(4, 8)
        Me.lblBuscar.Name = "lblBuscar"
        Me.lblBuscar.Size = New System.Drawing.Size(33, 14)
        Me.lblBuscar.TabIndex = 1
        Me.lblBuscar.Text = "Filtrar"
        Me.lblBuscar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cmbBuscar
        '
        Me.cmbBuscar.Anchor = Wisej.Web.AnchorStyles.Left
        Me.cmbBuscar.AutoCompleteMode = Wisej.Web.AutoCompleteMode.SuggestAppend
        Me.cmbBuscar.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList
        Me.cmbBuscar.FormattingEnabled = True
        Me.cmbBuscar.Location = New System.Drawing.Point(43, 4)
        Me.cmbBuscar.Name = "cmbBuscar"
        Me.cmbBuscar.Size = New System.Drawing.Size(176, 22)
        Me.cmbBuscar.TabIndex = 0
        '
        'txtFiltros
        '
        Me.txtFiltros.Anchor = Wisej.Web.AnchorStyles.Left
        Me.txtFiltros.Location = New System.Drawing.Point(315, 4)
        Me.txtFiltros.Margin = New Wisej.Web.Padding(0)
        Me.txtFiltros.Name = "txtFiltros"
        Me.txtFiltros.Size = New System.Drawing.Size(153, 22)
        Me.txtFiltros.TabIndex = 3
        '
        'panelEtiquetas
        '
        Me.panelEtiquetas.AutoSize = True
        Me.panelEtiquetas.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink
        Me.panelEtiquetas.BackColor = System.Drawing.Color.White
        Me.panelEtiquetas.Dock = Wisej.Web.DockStyle.Fill
        Me.panelEtiquetas.Location = New System.Drawing.Point(0, 30)
        Me.panelEtiquetas.MinimumSize = New System.Drawing.Size(777, 0)
        Me.panelEtiquetas.Name = "panelEtiquetas"
        Me.panelEtiquetas.Size = New System.Drawing.Size(777, 0)
        Me.panelEtiquetas.TabIndex = 0
        Me.panelEtiquetas.TabStop = True
        '
        'panelFiltros
        '
        Me.panelFiltros.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink
        Me.panelFiltros.BackColor = System.Drawing.Color.Transparent
        Me.panelFiltros.Controls.Add(Me.btnElegirColumnas)
        Me.panelFiltros.Controls.Add(Me.btnBDFile)
        Me.panelFiltros.Controls.Add(Me.BtnExportar)
        Me.panelFiltros.Controls.Add(Me.cmbConcatenar)
        Me.panelFiltros.Controls.Add(Me.dtpFecha)
        Me.panelFiltros.Controls.Add(Me.cmbExpresion)
        Me.panelFiltros.Controls.Add(Me.lblBuscar)
        Me.panelFiltros.Controls.Add(Me.cmbBuscar)
        Me.panelFiltros.Controls.Add(Me.btnLimpiar)
        Me.panelFiltros.Controls.Add(Me.btnBuscar)
        Me.panelFiltros.Controls.Add(Me.txtFiltros)
        Me.panelFiltros.Dock = Wisej.Web.DockStyle.Top
        Me.panelFiltros.Location = New System.Drawing.Point(0, 0)
        Me.panelFiltros.Name = "panelFiltros"
        Me.panelFiltros.Size = New System.Drawing.Size(777, 30)
        Me.panelFiltros.TabIndex = 1
        Me.panelFiltros.TabStop = True
        '
        'btnElegirColumnas
        '
        Me.btnElegirColumnas.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink
        Me.btnElegirColumnas.BackgroundImageLayout = Wisej.Web.ImageLayout.Center
        Me.btnElegirColumnas.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnElegirColumnas.Location = New System.Drawing.Point(553, 3)
        Me.btnElegirColumnas.Name = "btnElegirColumnas"
        Me.btnElegirColumnas.Size = New System.Drawing.Size(23, 23)
        Me.btnElegirColumnas.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.btnElegirColumnas, "Elegir Columnas de Tabla (Mostrar/Ocultar)")
        Me.btnElegirColumnas.Visible = False
        '
        'btnBDFile
        '
        Me.btnBDFile.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink
        Me.btnBDFile.BackgroundImageLayout = Wisej.Web.ImageLayout.Center
        Me.btnBDFile.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnBDFile.Location = New System.Drawing.Point(581, 3)
        Me.btnBDFile.Name = "btnBDFile"
        Me.btnBDFile.Size = New System.Drawing.Size(23, 23)
        Me.btnBDFile.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.btnBDFile, "Exportar a DBF file")
        Me.btnBDFile.Visible = False
        '
        'BtnExportar
        '
        Me.BtnExportar.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink
        Me.BtnExportar.BackColor = System.Drawing.Color.FromName("@controlLight")
        Me.BtnExportar.BackgroundImageLayout = Wisej.Web.ImageLayout.Center
        Me.BtnExportar.BackgroundImageSource = "Resources/Images/filtro grilla/icon_csv.png"
        Me.BtnExportar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnExportar.Location = New System.Drawing.Point(526, 3)
        Me.BtnExportar.Name = "BtnExportar"
        Me.BtnExportar.Size = New System.Drawing.Size(23, 23)
        Me.BtnExportar.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.BtnExportar, "Exportar a Excel ")
        '
        'cmbConcatenar
        '
        Me.cmbConcatenar.Anchor = Wisej.Web.AnchorStyles.Left
        Me.cmbConcatenar.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList
        Me.cmbConcatenar.DropDownWidth = 40
        Me.cmbConcatenar.FormattingEnabled = True
        Me.cmbConcatenar.Items.AddRange(New Object() {"Y", "O"})
        Me.cmbConcatenar.Location = New System.Drawing.Point(221, 4)
        Me.cmbConcatenar.Name = "cmbConcatenar"
        Me.cmbConcatenar.Size = New System.Drawing.Size(44, 22)
        Me.cmbConcatenar.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.cmbConcatenar, "Operador/ Tipo de Busqueda...")
        '
        'dtpFecha
        '
        Me.dtpFecha.Anchor = Wisej.Web.AnchorStyles.Left
        Me.dtpFecha.Checked = False
        Me.dtpFecha.CustomFormat = "dd/MM/yyyy"
        Me.dtpFecha.Format = Wisej.Web.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(313, 4)
        Me.dtpFecha.Mask = "##/##/####"
        Me.dtpFecha.MaxDate = New Date(2030, 12, 31, 0, 0, 0, 0)
        Me.dtpFecha.MinDate = New Date(1900, 1, 1, 0, 0, 0, 0)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.ShowCalendar = False
        Me.dtpFecha.Size = New System.Drawing.Size(97, 22)
        Me.dtpFecha.TabIndex = 2
        Me.dtpFecha.Value = New Date(2020, 4, 24, 11, 27, 30, 189)
        Me.dtpFecha.Visible = False
        '
        'cmbExpresion
        '
        Me.cmbExpresion.Anchor = Wisej.Web.AnchorStyles.Left
        Me.cmbExpresion.DropDownStyle = Wisej.Web.ComboBoxStyle.DropDownList
        Me.cmbExpresion.DropDownWidth = 40
        Me.cmbExpresion.FormattingEnabled = True
        Me.cmbExpresion.Location = New System.Drawing.Point(267, 4)
        Me.cmbExpresion.Name = "cmbExpresion"
        Me.cmbExpresion.Size = New System.Drawing.Size(44, 22)
        Me.cmbExpresion.TabIndex = 1
        '
        'btnLimpiar
        '
        Me.btnLimpiar.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromName("@controlLight")
        Me.btnLimpiar.BackgroundImageLayout = Wisej.Web.ImageLayout.Center
        Me.btnLimpiar.BackgroundImageSource = "Resources/Images/filtro grilla/icono_limpiar.png"
        Me.btnLimpiar.Font = New System.Drawing.Font("Tahoma", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.btnLimpiar.Location = New System.Drawing.Point(499, 3)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(23, 23)
        Me.btnLimpiar.TabIndex = 5
        '
        'btnBuscar
        '
        Me.btnBuscar.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink
        Me.btnBuscar.BackColor = System.Drawing.Color.FromName("@controlLight")
        Me.btnBuscar.BackgroundImageLayout = Wisej.Web.ImageLayout.Center
        Me.btnBuscar.BackgroundImageSource = "Resources/Images/filtro grilla/icono_buscar.png"
        Me.btnBuscar.Location = New System.Drawing.Point(472, 3)
        Me.btnBuscar.Name = "btnBuscar"
        Me.btnBuscar.Size = New System.Drawing.Size(23, 23)
        Me.btnBuscar.TabIndex = 4
        '
        'ContextMenu1
        '
        Me.ContextMenu1.MenuItems.AddRange(New Wisej.Web.MenuItem() {Me.MenuItem1})
        Me.ContextMenu1.Name = "ContextMenu1"
        '
        'MenuItem1
        '
        Me.MenuItem1.Index = 0
        Me.MenuItem1.Name = "MenuItem1"
        Me.MenuItem1.Text = "MenuItem1"
        '
        'filtroGrillaSax
        '
        Me.AutoSize = True
        Me.AutoSizeMode = Wisej.Web.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.LightSteelBlue
        Me.Controls.Add(Me.panelEtiquetas)
        Me.Controls.Add(Me.panelFiltros)
        Me.Name = "filtroGrillaSax"
        Me.Size = New System.Drawing.Size(777, 30)
        Me.panelFiltros.ResumeLayout(False)
        Me.panelFiltros.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents panelEtiquetas As Wisej.Web.FlowLayoutPanel
    Private WithEvents panelFiltros As Wisej.Web.Panel
    Private WithEvents lblBuscar As Wisej.Web.Label
    Private WithEvents cmbBuscar As Wisej.Web.ComboBox
    Private WithEvents txtFiltros As Wisej.Web.TextBox
    Private WithEvents btnBuscar As Wisej.Web.Button
    Private WithEvents btnLimpiar As Wisej.Web.Button
    Friend WithEvents cmbExpresion As Wisej.Web.ComboBox
    Friend WithEvents dtpFecha As Wisej.Web.DateTimePicker
    Friend WithEvents cmbConcatenar As Wisej.Web.ComboBox
    Friend WithEvents ContextMenuStrip1 As Wisej.Web.ContextMenu
    Friend WithEvents ToolStripTextBox1 As Wisej.Web.MenuItem
    Private WithEvents BtnExportar As Wisej.Web.Button
    Private WithEvents btnBDFile As Wisej.Web.Button
    Friend WithEvents ToolTip1 As Wisej.Web.ToolTip
    Private WithEvents btnElegirColumnas As Wisej.Web.Button
    Friend WithEvents ContextMenu1 As Wisej.Web.ContextMenu
    Friend WithEvents MenuItem1 As Wisej.Web.MenuItem
End Class
