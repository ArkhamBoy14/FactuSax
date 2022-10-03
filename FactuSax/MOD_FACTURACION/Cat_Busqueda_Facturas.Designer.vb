<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cat_Busqueda_Facturas
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
        Me.SplitContainer1 = New Wisej.Web.SplitContainer()
        Me.Panel1 = New Wisej.Web.Panel()
        Me.cFecha2 = New Wisej.Web.DateTimePicker()
        Me.Label19 = New Wisej.Web.Label()
        Me.CbxCliente = New FactuSax.ComboWisax()
        Me.Label1 = New Wisej.Web.Label()
        Me.cFecha1 = New Wisej.Web.DateTimePicker()
        Me.Label18 = New Wisej.Web.Label()
        Me.Panel2 = New Wisej.Web.Panel()
        Me.DGV_Busqueda = New Wisej.Web.DataGridView()
        Me.DGV_Parent = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.cPDF = New Wisej.Web.DataGridViewImageColumn()
        Me.cXML = New Wisej.Web.DataGridViewImageColumn()
        Me.colFOLIO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colUUID = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colFECHA = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colCONDICIONESPAGO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colParent = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.cNombre_Archivo = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.cMetodoPago = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.BS_CFDI = New Wisej.Web.BindingSource(Me.components)
        Me.DataSet_pFACTURA_SAT_CFDI_B = New FactuSax.DataSet_pFACTURA_SAT_CFDI_B()
        Me.RibbonBar1 = New Wisej.Web.Ext.RibbonBar.RibbonBar()
        Me.RibbonBarPage1 = New Wisej.Web.Ext.RibbonBar.RibbonBarPage()
        Me.RibbonBarGroup1 = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.RBBBuscar = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBBSalir = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.DGV_Pagos = New Wisej.Web.DataGridView()
        Me.colPDF = New Wisej.Web.DataGridViewImageColumn()
        Me.colXML = New Wisej.Web.DataGridViewImageColumn()
        Me.colUUID_1 = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colMETODOPAGO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colPARCIALIDAD = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colIMPORTE_PAGADO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colSALDO_ANTERIOR = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colSALDO_INSOLUTO = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.PFACTURA_SAT_CFDI_BTableAdapter = New FactuSax.DataSet_pFACTURA_SAT_CFDI_BTableAdapters.pFACTURA_SAT_CFDI_BTableAdapter()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DGV_Busqueda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_CFDI, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_pFACTURA_SAT_CFDI_B, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DGV_Pagos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = Wisej.Web.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 110)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(888, 461)
        Me.SplitContainer1.SplitterDistance = 179
        Me.SplitContainer1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.cFecha2)
        Me.Panel1.Controls.Add(Me.Label19)
        Me.Panel1.Controls.Add(Me.CbxCliente)
        Me.Panel1.Controls.Add(Me.Label1)
        Me.Panel1.Controls.Add(Me.cFecha1)
        Me.Panel1.Controls.Add(Me.Label18)
        Me.Panel1.Dock = Wisej.Web.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(177, 459)
        Me.Panel1.TabIndex = 7
        Me.Panel1.TabStop = True
        '
        'cFecha2
        '
        Me.cFecha2.CustomFormat = "dd/MM/yyyy"
        Me.cFecha2.Format = Wisej.Web.DateTimePickerFormat.Custom
        Me.cFecha2.Location = New System.Drawing.Point(112, 124)
        Me.cFecha2.Name = "cFecha2"
        Me.cFecha2.Size = New System.Drawing.Size(103, 22)
        Me.cFecha2.TabIndex = 4
        Me.cFecha2.Value = New Date(2022, 7, 5, 13, 58, 56, 800)
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(112, 103)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(23, 15)
        Me.Label19.TabIndex = 6
        Me.Label19.Text = "Fin"
        '
        'CbxCliente
        '
        Me.CbxCliente.Location = New System.Drawing.Point(3, 53)
        Me.CbxCliente.Name = "CbxCliente"
        Me.CbxCliente.Size = New System.Drawing.Size(213, 22)
        Me.CbxCliente.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(0, 35)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(49, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Cliente:"
        '
        'cFecha1
        '
        Me.cFecha1.CustomFormat = "dd/MM/yyyy"
        Me.cFecha1.Format = Wisej.Web.DateTimePickerFormat.Custom
        Me.cFecha1.Location = New System.Drawing.Point(3, 124)
        Me.cFecha1.Name = "cFecha1"
        Me.cFecha1.Size = New System.Drawing.Size(103, 22)
        Me.cFecha1.TabIndex = 3
        Me.cFecha1.Value = New Date(2022, 7, 5, 13, 58, 56, 825)
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(3, 103)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(35, 15)
        Me.Label18.TabIndex = 5
        Me.Label18.Text = "Inicio"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DGV_Busqueda)
        Me.Panel2.Dock = Wisej.Web.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(701, 459)
        Me.Panel2.TabIndex = 0
        Me.Panel2.TabStop = True
        '
        'DGV_Busqueda
        '
        Me.DGV_Busqueda.AutoGenerateColumns = False
        Me.DGV_Busqueda.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.DGV_Parent, Me.cPDF, Me.cXML, Me.colFOLIO, Me.colUUID, Me.colFECHA, Me.colCONDICIONESPAGO, Me.colParent, Me.cNombre_Archivo, Me.cMetodoPago})
        Me.DGV_Busqueda.DataSource = Me.BS_CFDI
        Me.DGV_Busqueda.Dock = Wisej.Web.DockStyle.Fill
        Me.DGV_Busqueda.Location = New System.Drawing.Point(0, 0)
        Me.DGV_Busqueda.Name = "DGV_Busqueda"
        Me.DGV_Busqueda.RowHeadersVisible = False
        Me.DGV_Busqueda.Size = New System.Drawing.Size(701, 459)
        Me.DGV_Busqueda.TabIndex = 0
        '
        'DGV_Parent
        '
        Me.DGV_Parent.HeaderText = "  "
        Me.DGV_Parent.Name = "DGV_Parent"
        Me.DGV_Parent.ReadOnly = True
        Me.DGV_Parent.Width = 30
        '
        'cPDF
        '
        Me.cPDF.CellImage = Global.FactuSax.My.Resources.Resources.pdf1
        Me.cPDF.CellImageAlignment = Wisej.Web.DataGridViewContentAlignment.NotSet
        Me.cPDF.HeaderText = "   "
        Me.cPDF.Name = "cPDF"
        Me.cPDF.Width = 35
        '
        'cXML
        '
        Me.cXML.CellImage = Global.FactuSax.My.Resources.Resources.xml1
        Me.cXML.CellImageAlignment = Wisej.Web.DataGridViewContentAlignment.NotSet
        Me.cXML.HeaderText = " "
        Me.cXML.Name = "cXML"
        Me.cXML.Width = 35
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
        Me.colUUID.AutoSizeMode = Wisej.Web.DataGridViewAutoSizeColumnMode.AllCells
        Me.colUUID.DataPropertyName = "UUID"
        Me.colUUID.HeaderText = "UUID"
        Me.colUUID.Name = "colUUID"
        '
        'colFECHA
        '
        Me.colFECHA.DataPropertyName = "Fecha"
        Me.colFECHA.HeaderText = "FECHA"
        Me.colFECHA.Name = "colFECHA"
        Me.colFECHA.ReadOnly = True
        '
        'colCONDICIONESPAGO
        '
        Me.colCONDICIONESPAGO.DataPropertyName = "CondicionesPago"
        Me.colCONDICIONESPAGO.HeaderText = "CONDICIONESPAGO"
        Me.colCONDICIONESPAGO.Name = "colCONDICIONESPAGO"
        Me.colCONDICIONESPAGO.ReadOnly = True
        Me.colCONDICIONESPAGO.Width = 500
        '
        'colParent
        '
        Me.colParent.DataPropertyName = "tipo_parent"
        Me.colParent.HeaderText = "colParent"
        Me.colParent.Name = "colParent"
        Me.colParent.ReadOnly = True
        Me.colParent.Visible = False
        '
        'cNombre_Archivo
        '
        Me.cNombre_Archivo.DataPropertyName = "Nombre_Archivo"
        Me.cNombre_Archivo.HeaderText = "cNombre_Archivo"
        Me.cNombre_Archivo.Name = "cNombre_Archivo"
        Me.cNombre_Archivo.Visible = False
        '
        'cMetodoPago
        '
        Me.cMetodoPago.DataPropertyName = "MetodoPago"
        Me.cMetodoPago.HeaderText = "cMetodoPago"
        Me.cMetodoPago.Name = "cMetodoPago"
        Me.cMetodoPago.Visible = False
        '
        'BS_CFDI
        '
        Me.BS_CFDI.DataMember = "pFACTURA_SAT_CFDI_B"
        Me.BS_CFDI.DataSource = Me.DataSet_pFACTURA_SAT_CFDI_B
        '
        'DataSet_pFACTURA_SAT_CFDI_B
        '
        Me.DataSet_pFACTURA_SAT_CFDI_B.DataSetName = "DataSet_pFACTURA_SAT_CFDI_B"
        Me.DataSet_pFACTURA_SAT_CFDI_B.EnforceConstraints = False
        Me.DataSet_pFACTURA_SAT_CFDI_B.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RibbonBar1
        '
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Pages.Add(Me.RibbonBarPage1)
        Me.RibbonBar1.Size = New System.Drawing.Size(888, 110)
        '
        'RibbonBarPage1
        '
        Me.RibbonBarPage1.Groups.Add(Me.RibbonBarGroup1)
        Me.RibbonBarPage1.Name = "RibbonBarPage1"
        Me.RibbonBarPage1.Text = "Menu"
        '
        'RibbonBarGroup1
        '
        Me.RibbonBarGroup1.Items.Add(Me.RBBBuscar)
        Me.RibbonBarGroup1.Items.Add(Me.RBBSalir)
        Me.RibbonBarGroup1.Name = "RibbonBarGroup1"
        Me.RibbonBarGroup1.Text = "Procesos"
        '
        'RBBBuscar
        '
        Me.RBBBuscar.ImageSource = "Resources\Images\Menu\64\lupa.png"
        Me.RBBBuscar.Name = "RBBBuscar"
        Me.RBBBuscar.Text = "Buscar"
        '
        'RBBSalir
        '
        Me.RBBSalir.ImageSource = "Resources\Images\Menu\64\exit_sign.png"
        Me.RBBSalir.Name = "RBBSalir"
        Me.RBBSalir.Text = "Salir"
        '
        'DGV_Pagos
        '
        DataGridViewCellStyle1.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.Color.LightSteelBlue
        DataGridViewCellStyle1.Font = New System.Drawing.Font("tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0)
        DataGridViewCellStyle1.WrapMode = Wisej.Web.DataGridViewTriState.[True]
        Me.DGV_Pagos.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.DGV_Pagos.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.colPDF, Me.colXML, Me.colUUID_1, Me.colMETODOPAGO, Me.colPARCIALIDAD, Me.colIMPORTE_PAGADO, Me.colSALDO_ANTERIOR, Me.colSALDO_INSOLUTO})
        Me.DGV_Pagos.Location = New System.Drawing.Point(295, 43)
        Me.DGV_Pagos.Name = "DGV_Pagos"
        Me.DGV_Pagos.RowHeadersVisible = False
        Me.DGV_Pagos.RowTemplate.Height = 20
        Me.DGV_Pagos.ShowColumnVisibilityMenu = False
        Me.DGV_Pagos.Size = New System.Drawing.Size(616, 49)
        Me.DGV_Pagos.TabIndex = 0
        Me.DGV_Pagos.Visible = False
        '
        'colPDF
        '
        Me.colPDF.CellImage = Global.FactuSax.My.Resources.Resources.pdf1
        Me.colPDF.CellImageAlignment = Wisej.Web.DataGridViewContentAlignment.NotSet
        Me.colPDF.HeaderText = " "
        Me.colPDF.Name = "colPDF"
        Me.colPDF.Width = 35
        '
        'colXML
        '
        Me.colXML.CellImage = Global.FactuSax.My.Resources.Resources.xml1
        Me.colXML.CellImageAlignment = Wisej.Web.DataGridViewContentAlignment.NotSet
        Me.colXML.HeaderText = " "
        Me.colXML.Name = "colXML"
        Me.colXML.Width = 35
        '
        'colUUID_1
        '
        Me.colUUID_1.DataPropertyName = "UUID_HIJO"
        Me.colUUID_1.HeaderText = "UUID"
        Me.colUUID_1.Name = "colUUID_1"
        '
        'colMETODOPAGO
        '
        Me.colMETODOPAGO.DataPropertyName = "MetodoPago"
        Me.colMETODOPAGO.HeaderText = "METODOPAGO"
        Me.colMETODOPAGO.Name = "colMETODOPAGO"
        '
        'colPARCIALIDAD
        '
        Me.colPARCIALIDAD.DataPropertyName = "PARCIALIDAD"
        Me.colPARCIALIDAD.HeaderText = "PARCIALIDAD"
        Me.colPARCIALIDAD.Name = "colPARCIALIDAD"
        Me.colPARCIALIDAD.ReadOnly = True
        '
        'colIMPORTE_PAGADO
        '
        Me.colIMPORTE_PAGADO.DataPropertyName = "IMPORTE_PAGADO"
        Me.colIMPORTE_PAGADO.HeaderText = "IMPORTE_PAGADO"
        Me.colIMPORTE_PAGADO.Name = "colIMPORTE_PAGADO"
        Me.colIMPORTE_PAGADO.ReadOnly = True
        '
        'colSALDO_ANTERIOR
        '
        Me.colSALDO_ANTERIOR.DataPropertyName = "SALDO_ANTERIOR"
        Me.colSALDO_ANTERIOR.HeaderText = "SALDO_ANTERIOR"
        Me.colSALDO_ANTERIOR.Name = "colSALDO_ANTERIOR"
        Me.colSALDO_ANTERIOR.ReadOnly = True
        '
        'colSALDO_INSOLUTO
        '
        Me.colSALDO_INSOLUTO.DataPropertyName = "SALDO_INSOLUTO"
        Me.colSALDO_INSOLUTO.HeaderText = "SALDO_INSOLUTO"
        Me.colSALDO_INSOLUTO.Name = "colSALDO_INSOLUTO"
        Me.colSALDO_INSOLUTO.ReadOnly = True
        '
        'PFACTURA_SAT_CFDI_BTableAdapter
        '
        Me.PFACTURA_SAT_CFDI_BTableAdapter.ClearBeforeFill = True
        '
        'Cat_Busqueda_Facturas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(888, 571)
        Me.Controls.Add(Me.DGV_Pagos)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.RibbonBar1)
        Me.Name = "Cat_Busqueda_Facturas"
        Me.Text = "Busqueda de Facturas"
        Me.WindowState = Wisej.Web.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        CType(Me.DGV_Busqueda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_CFDI, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_pFACTURA_SAT_CFDI_B, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DGV_Pagos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents CbxCliente As ComboWisax
    Friend WithEvents Label1 As Label
    Friend WithEvents RibbonBar1 As Ext.RibbonBar.RibbonBar
    Friend WithEvents RibbonBarPage1 As Ext.RibbonBar.RibbonBarPage
    Friend WithEvents RibbonBarGroup1 As Ext.RibbonBar.RibbonBarGroup
    Friend WithEvents RBBBuscar As Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents RBBSalir As Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents Label18 As Label
    Friend WithEvents cFecha1 As DateTimePicker
    Friend WithEvents cFecha2 As DateTimePicker
    Friend WithEvents Label19 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DGV_Busqueda As DataGridView
    Friend WithEvents DGV_Parent As DataGridViewTextBoxColumn
    Friend WithEvents colFOLIO As DataGridViewTextBoxColumn
    Friend WithEvents colUUID As DataGridViewTextBoxColumn
    Friend WithEvents colFECHA As DataGridViewTextBoxColumn
    Friend WithEvents colCONDICIONESPAGO As DataGridViewTextBoxColumn
    Friend WithEvents DataSet_pFACTURA_SAT_CFDI_B As DataSet_pFACTURA_SAT_CFDI_B
    Friend WithEvents colParent As DataGridViewTextBoxColumn
    Friend WithEvents DGV_Pagos As DataGridView
    Friend WithEvents colUUID_1 As DataGridViewTextBoxColumn
    Friend WithEvents colMETODOPAGO As DataGridViewTextBoxColumn
    Friend WithEvents colPARCIALIDAD As DataGridViewTextBoxColumn
    Friend WithEvents colIMPORTE_PAGADO As DataGridViewTextBoxColumn
    Friend WithEvents colSALDO_ANTERIOR As DataGridViewTextBoxColumn
    Friend WithEvents colSALDO_INSOLUTO As DataGridViewTextBoxColumn
    Friend WithEvents BS_CFDI As BindingSource
    Friend WithEvents PFACTURA_SAT_CFDI_BTableAdapter As DataSet_pFACTURA_SAT_CFDI_BTableAdapters.pFACTURA_SAT_CFDI_BTableAdapter
    Friend WithEvents cPDF As DataGridViewImageColumn
    Friend WithEvents cNombre_Archivo As DataGridViewTextBoxColumn
    Friend WithEvents cMetodoPago As DataGridViewTextBoxColumn
    Friend WithEvents cXML As DataGridViewImageColumn
    Friend WithEvents colPDF As DataGridViewImageColumn
    Friend WithEvents colXML As DataGridViewImageColumn
End Class
