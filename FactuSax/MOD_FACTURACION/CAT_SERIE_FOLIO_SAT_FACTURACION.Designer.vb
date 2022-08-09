

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CAT_SERIE_FOLIO_SAT_FACTURACION
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
        Dim DataGridViewCellStyle1 As Wisej.Web.DataGridViewCellStyle = New Wisej.Web.DataGridViewCellStyle()
        Me.RibbonBar1 = New Wisej.Web.Ext.RibbonBar.RibbonBar()
        Me.RibbonBarPage1 = New Wisej.Web.Ext.RibbonBar.RibbonBarPage()
        Me.RibbonBarGroup1 = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.RBBNuevo = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBBGuardar = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBBSalir = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.Label1 = New Wisej.Web.Label()
        Me.Label2 = New Wisej.Web.Label()
        Me.SplitContainer1 = New Wisej.Web.SplitContainer()
        Me.TBSerie = New Wisej.Web.TextBox()
        Me.TBFolio = New Wisej.Web.TextBox()
        Me.DataGridView1 = New Wisej.Web.DataGridView()
        Me.colId = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colSerie = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colFolio = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colFecha = New Wisej.Web.DataGridViewDateTimePickerColumn()
        Me.BindingSource1 = New Wisej.Web.BindingSource(Me.components)
        Me.DataSet_pCAT_SERIE_FOLIO_SAT_FACTURACION_B = New FactuSax.DataSet_pCAT_SERIE_FOLIO_SAT_FACTURACION_B()
        Me.PCAT_SERIE_FOLIO_SAT_FACTURACION_BTableAdapter = New FactuSax.DataSet_pCAT_SERIE_FOLIO_SAT_FACTURACION_BTableAdapters.pCAT_SERIE_FOLIO_SAT_FACTURACION_BTableAdapter()
        Me.colCve_Instituto = New Wisej.Web.DataGridViewTextBoxColumn()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_pCAT_SERIE_FOLIO_SAT_FACTURACION_B, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonBar1
        '
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Pages.Add(Me.RibbonBarPage1)
        Me.RibbonBar1.Size = New System.Drawing.Size(1285, 84)
        '
        'RibbonBarPage1
        '
        Me.RibbonBarPage1.Groups.Add(Me.RibbonBarGroup1)
        Me.RibbonBarPage1.Name = "RibbonBarPage1"
        Me.RibbonBarPage1.Text = "Men�"
        '
        'RibbonBarGroup1
        '
        Me.RibbonBarGroup1.Items.Add(Me.RBBNuevo)
        Me.RibbonBarGroup1.Items.Add(Me.RBBGuardar)
        Me.RibbonBarGroup1.Items.Add(Me.RBBSalir)
        Me.RibbonBarGroup1.Name = "RibbonBarGroup1"
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
        'RBBSalir
        '
        Me.RBBSalir.ImageSource = "Resources\Images\Menu\64\exit_sign.png"
        Me.RBBSalir.Name = "RBBSalir"
        Me.RBBSalir.Text = "Salir"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(33, 15)
        Me.Label1.TabIndex = 15
        Me.Label1.Text = "Folio"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 13)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 15)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Serie"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.AutoValidate = Wisej.Web.AutoValidate.EnablePreventFocusChange
        Me.SplitContainer1.Dock = Wisej.Web.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = Wisej.Web.FixedPanel.Panel1
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 84)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = Wisej.Web.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TBSerie)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TBFolio)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridView1)
        Me.SplitContainer1.Size = New System.Drawing.Size(1285, 603)
        Me.SplitContainer1.SplitterDistance = 71
        Me.SplitContainer1.TabIndex = 16
        '
        'TBSerie
        '
        Me.TBSerie.Location = New System.Drawing.Point(66, 10)
        Me.TBSerie.Name = "TBSerie"
        Me.TBSerie.Size = New System.Drawing.Size(260, 22)
        Me.TBSerie.TabIndex = 16
        '
        'TBFolio
        '
        Me.TBFolio.Location = New System.Drawing.Point(66, 41)
        Me.TBFolio.Name = "TBFolio"
        Me.TBFolio.Size = New System.Drawing.Size(260, 22)
        Me.TBFolio.TabIndex = 16
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToResizeColumns = False
        Me.DataGridView1.AllowUserToResizeRows = False
        Me.DataGridView1.AutoSizeColumnsMode = Wisej.Web.DataGridViewAutoSizeColumnsMode.ColumnHeader
        Me.DataGridView1.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.colId, Me.colSerie, Me.colFolio, Me.colFecha, Me.colCve_Instituto})
        Me.DataGridView1.DataSource = Me.BindingSource1
        Me.DataGridView1.Dock = Wisej.Web.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(1285, 526)
        Me.DataGridView1.TabIndex = 0
        '
        'colId
        '
        Me.colId.DataPropertyName = "Id"
        Me.colId.HeaderText = "Id"
        Me.colId.Name = "colId"
        Me.colId.ReadOnly = True
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
        'colFecha
        '
        Me.colFecha.DataPropertyName = "fecha"
        DataGridViewCellStyle1.Format = "G"
        Me.colFecha.DefaultCellStyle = DataGridViewCellStyle1
        Me.colFecha.HeaderText = "fecha"
        Me.colFecha.Name = "colFecha"
        '
        'BindingSource1
        '
        Me.BindingSource1.DataMember = "pCAT_SERIE_FOLIO_SAT_FACTURACION_B"
        Me.BindingSource1.DataSource = Me.DataSet_pCAT_SERIE_FOLIO_SAT_FACTURACION_B
        '
        'DataSet_pCAT_SERIE_FOLIO_SAT_FACTURACION_B
        '
        Me.DataSet_pCAT_SERIE_FOLIO_SAT_FACTURACION_B.DataSetName = "DataSet_pCAT_SERIE_FOLIO_SAT_FACTURACION_B"
        Me.DataSet_pCAT_SERIE_FOLIO_SAT_FACTURACION_B.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PCAT_SERIE_FOLIO_SAT_FACTURACION_BTableAdapter
        '
        Me.PCAT_SERIE_FOLIO_SAT_FACTURACION_BTableAdapter.ClearBeforeFill = True
        '
        'colCve_Instituto
        '
        Me.colCve_Instituto.DataPropertyName = "Cve_Instituto"
        Me.colCve_Instituto.HeaderText = "Cve_Instituto"
        Me.colCve_Instituto.Name = "colCve_Instituto"
        '
        'CAT_SERIE_FOLIO_SAT_FACTURACION
        '
        Me.ClientSize = New System.Drawing.Size(1285, 687)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.RibbonBar1)
        Me.Name = "CAT_SERIE_FOLIO_SAT_FACTURACION"
        Me.Text = "CAT_SERIE_FOLIO"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_pCAT_SERIE_FOLIO_SAT_FACTURACION_B, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RibbonBar1 As Ext.RibbonBar.RibbonBar
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TBSerie As TextBox
    Friend WithEvents TBFolio As TextBox
    Friend WithEvents DataGridView1 As Wisej.Web.DataGridView
    Friend WithEvents RibbonBarPage1 As Ext.RibbonBar.RibbonBarPage
    Friend WithEvents RibbonBarGroup1 As Ext.RibbonBar.RibbonBarGroup
    Friend WithEvents RBBNuevo As Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents RBBGuardar As Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents RBBSalir As Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents DataSet_pCAT_SERIE_FOLIO_SAT_FACTURACION_B As DataSet_pCAT_SERIE_FOLIO_SAT_FACTURACION_B
    Friend WithEvents PCAT_SERIE_FOLIO_SAT_FACTURACION_BTableAdapter As DataSet_pCAT_SERIE_FOLIO_SAT_FACTURACION_BTableAdapters.pCAT_SERIE_FOLIO_SAT_FACTURACION_BTableAdapter
    Friend WithEvents colId As DataGridViewTextBoxColumn
    Friend WithEvents colSerie As DataGridViewTextBoxColumn
    Friend WithEvents colFolio As DataGridViewTextBoxColumn
    Friend WithEvents colFecha As DataGridViewDateTimePickerColumn
    Friend WithEvents colCve_Instituto As DataGridViewTextBoxColumn
End Class