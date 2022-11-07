

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
        Me.RibbonBar1 = New Wisej.Web.Ext.RibbonBar.RibbonBar()
        Me.RibbonBarPage1 = New Wisej.Web.Ext.RibbonBar.RibbonBarPage()
        Me.RibbonBarGroup1 = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.RBBGuardar = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBBSalir = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.BindingSource1 = New Wisej.Web.BindingSource(Me.components)
        Me.DataSet_pCAT_SERIE_FOLIO_SAT_FACTURACION_B = New FactuSax.DataSet_pCAT_SERIE_FOLIO_SAT_FACTURACION_B()
        Me.PCAT_SERIE_FOLIO_SAT_FACTURACION_BTableAdapter = New FactuSax.DataSet_pCAT_SERIE_FOLIO_SAT_FACTURACION_BTableAdapters.pCAT_SERIE_FOLIO_SAT_FACTURACION_BTableAdapter()
        Me.Label1 = New Wisej.Web.Label()
        Me.Label2 = New Wisej.Web.Label()
        Me.Label3 = New Wisej.Web.Label()
        Me.CbxClientes = New FactuSax.ComboWisax()
        Me.TBSerie = New Wisej.Web.TextBox()
        Me.TBFolio = New Wisej.Web.TextBox()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_pCAT_SERIE_FOLIO_SAT_FACTURACION_B, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonBar1
        '
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Pages.Add(Me.RibbonBarPage1)
        Me.RibbonBar1.Size = New System.Drawing.Size(381, 84)
        '
        'RibbonBarPage1
        '
        Me.RibbonBarPage1.Groups.Add(Me.RibbonBarGroup1)
        Me.RibbonBarPage1.Name = "RibbonBarPage1"
        Me.RibbonBarPage1.Text = "Menú"
        '
        'RibbonBarGroup1
        '
        Me.RibbonBarGroup1.Items.Add(Me.RBBGuardar)
        Me.RibbonBarGroup1.Items.Add(Me.RBBSalir)
        Me.RibbonBarGroup1.Name = "RibbonBarGroup1"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(23, 132)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 15)
        Me.Label1.TabIndex = 18
        Me.Label1.Text = "Cliente"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(23, 162)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 15)
        Me.Label2.TabIndex = 19
        Me.Label2.Text = "Serie"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(23, 191)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(33, 15)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "Folio"
        '
        'CbxClientes
        '
        Me.CbxClientes.DataBindings.Add(New Wisej.Web.Binding("SelectedValue", Me.BindingSource1, "Cve_Cliente", True))
        Me.CbxClientes.Enabled = False
        Me.CbxClientes.Location = New System.Drawing.Point(88, 128)
        Me.CbxClientes.Name = "CbxClientes"
        Me.CbxClientes.Size = New System.Drawing.Size(229, 22)
        Me.CbxClientes.TabIndex = 21
        '
        'TBSerie
        '
        Me.TBSerie.DataBindings.Add(New Wisej.Web.Binding("Text", Me.BindingSource1, "Serie", True))
        Me.TBSerie.Location = New System.Drawing.Point(88, 159)
        Me.TBSerie.Name = "TBSerie"
        Me.TBSerie.Size = New System.Drawing.Size(229, 22)
        Me.TBSerie.TabIndex = 22
        '
        'TBFolio
        '
        Me.TBFolio.DataBindings.Add(New Wisej.Web.Binding("Text", Me.BindingSource1, "Folio", True))
        Me.TBFolio.Location = New System.Drawing.Point(88, 187)
        Me.TBFolio.Name = "TBFolio"
        Me.TBFolio.Size = New System.Drawing.Size(229, 22)
        Me.TBFolio.TabIndex = 23
        '
        'CAT_SERIE_FOLIO_SAT_FACTURACION
        '
        Me.ClientSize = New System.Drawing.Size(381, 296)
        Me.Controls.Add(Me.TBFolio)
        Me.Controls.Add(Me.TBSerie)
        Me.Controls.Add(Me.CbxClientes)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.RibbonBar1)
        Me.Name = "CAT_SERIE_FOLIO_SAT_FACTURACION"
        Me.Text = "Series"
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_pCAT_SERIE_FOLIO_SAT_FACTURACION_B, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents RibbonBar1 As Ext.RibbonBar.RibbonBar
    Friend WithEvents RibbonBarPage1 As Ext.RibbonBar.RibbonBarPage
    Friend WithEvents RibbonBarGroup1 As Ext.RibbonBar.RibbonBarGroup
    Friend WithEvents RBBGuardar As Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents RBBSalir As Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents DataSet_pCAT_SERIE_FOLIO_SAT_FACTURACION_B As DataSet_pCAT_SERIE_FOLIO_SAT_FACTURACION_B
    Friend WithEvents PCAT_SERIE_FOLIO_SAT_FACTURACION_BTableAdapter As DataSet_pCAT_SERIE_FOLIO_SAT_FACTURACION_BTableAdapters.pCAT_SERIE_FOLIO_SAT_FACTURACION_BTableAdapter
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents CbxClientes As ComboWisax
    Friend WithEvents TBSerie As TextBox
    Friend WithEvents TBFolio As TextBox
End Class