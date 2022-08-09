<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cat_Retenciones
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
        Me.RBBActualizar = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RbbGuardar = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RbbSalir = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.Panel1 = New Wisej.Web.Panel()
        Me.Panel2 = New Wisej.Web.Panel()
        Me.DataGridView1 = New Wisej.Web.DataGridView()
        Me.Panel3 = New Wisej.Web.Panel()
        Me.TableLayoutPanel1 = New Wisej.Web.TableLayoutPanel()
        Me.GroupBox3 = New Wisej.Web.GroupBox()
        Me.TasaoCuotaRIVA = New Wisej.Web.ComboBox()
        Me.Label14 = New Wisej.Web.Label()
        Me.MTBRISR = New Wisej.Web.MaskedTextBox()
        Me.Label15 = New Wisej.Web.Label()
        Me.Label16 = New Wisej.Web.Label()
        Me.CBSRIVA = New FactuSax.ComboWisax()
        Me.GroupBox2 = New Wisej.Web.GroupBox()
        Me.TasaoCuotaISR = New Wisej.Web.ComboBox()
        Me.Label11 = New Wisej.Web.Label()
        Me.CBSRISR = New FactuSax.ComboWisax()
        Me.Label13 = New Wisej.Web.Label()
        Me.Label12 = New Wisej.Web.Label()
        Me.MTBRIVA = New Wisej.Web.MaskedTextBox()
        Me.GroupBox1 = New Wisej.Web.GroupBox()
        Me.TasaoCuotaIVA = New Wisej.Web.ComboBox()
        Me.MTBIVA = New Wisej.Web.MaskedTextBox()
        Me.Label10 = New Wisej.Web.Label()
        Me.Label9 = New Wisej.Web.Label()
        Me.Label8 = New Wisej.Web.Label()
        Me.CBSIVA = New FactuSax.ComboWisax()
        Me.Chk_AplicaIVA = New Wisej.Web.CheckBox()
        Me.Chk_AplicaISR = New Wisej.Web.CheckBox()
        Me.Chk_AplicaIEPS = New Wisej.Web.CheckBox()
        Me.DataSet_pCAT_IMPUESTOS_SAT_FACTURACION_B = New FactuSax.DataSet_pCAT_IMPUESTOS_SAT_FACTURACION_B()
        Me.BS_Impuestos = New Wisej.Web.BindingSource(Me.components)
        Me.PCAT_IMPUESTOS_SAT_FACTURACION_BTableAdapter = New FactuSax.DataSet_pCAT_IMPUESTOS_SAT_FACTURACION_BTableAdapters.pCAT_IMPUESTOS_SAT_FACTURACION_BTableAdapter()
        Me.colC_Impuesto = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colDescripcionx = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colAplica = New Wisej.Web.DataGridViewCheckBoxColumn()
        Me.colTasaocuota = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.colValor = New Wisej.Web.DataGridViewTextBoxColumn()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataSet_pCAT_IMPUESTOS_SAT_FACTURACION_B, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BS_Impuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonBar1
        '
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Pages.Add(Me.RibbonBarPage1)
        Me.RibbonBar1.Size = New System.Drawing.Size(863, 109)
        '
        'RibbonBarPage1
        '
        Me.RibbonBarPage1.Groups.Add(Me.RibbonBarGroup1)
        Me.RibbonBarPage1.Name = "RibbonBarPage1"
        Me.RibbonBarPage1.Text = "Menu"
        '
        'RibbonBarGroup1
        '
        Me.RibbonBarGroup1.Items.Add(Me.RBBActualizar)
        Me.RibbonBarGroup1.Items.Add(Me.RbbGuardar)
        Me.RibbonBarGroup1.Items.Add(Me.RbbSalir)
        Me.RibbonBarGroup1.Name = "RibbonBarGroup1"
        Me.RibbonBarGroup1.Text = "Procesos"
        '
        'RBBActualizar
        '
        Me.RBBActualizar.ImageSource = "Resources\Images\Menu\64\actualizar_64.png"
        Me.RBBActualizar.Name = "RBBActualizar"
        Me.RBBActualizar.Text = "Actualizar"
        '
        'RbbGuardar
        '
        Me.RbbGuardar.ImageSource = "Resources\Images\Menu\64\Save Filled-64.png"
        Me.RbbGuardar.Name = "RbbGuardar"
        Me.RbbGuardar.Text = "Guardar"
        '
        'RbbSalir
        '
        Me.RbbSalir.ImageSource = "Resources\Images\Menu\64\exit_sign.png"
        Me.RbbSalir.Name = "RbbSalir"
        Me.RbbSalir.Text = "Salir"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Panel2)
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = Wisej.Web.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 109)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(863, 371)
        Me.Panel1.TabIndex = 1
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.DataGridView1)
        Me.Panel2.Dock = Wisej.Web.DockStyle.Fill
        Me.Panel2.Location = New System.Drawing.Point(0, 132)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(863, 239)
        Me.Panel2.TabIndex = 0
        '
        'DataGridView1
        '
        Me.DataGridView1.Columns.AddRange(New Wisej.Web.DataGridViewColumn() {Me.colC_Impuesto, Me.colDescripcionx, Me.colAplica, Me.colTasaocuota, Me.colValor})
        Me.DataGridView1.DataSource = Me.BS_Impuestos
        Me.DataGridView1.Dock = Wisej.Web.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.Size = New System.Drawing.Size(863, 239)
        Me.DataGridView1.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel3.Dock = Wisej.Web.DockStyle.Top
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(863, 132)
        Me.Panel3.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 33.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 34.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 33.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox3, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 1, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(863, 132)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Chk_AplicaIEPS)
        Me.GroupBox3.Controls.Add(Me.TasaoCuotaRIVA)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.MTBRISR)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Controls.Add(Me.Label16)
        Me.GroupBox3.Controls.Add(Me.CBSRIVA)
        Me.GroupBox3.Dock = Wisej.Web.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(580, 3)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(280, 126)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.Text = "Retención IEPS"
        '
        'TasaoCuotaRIVA
        '
        Me.TasaoCuotaRIVA.FormattingEnabled = True
        Me.TasaoCuotaRIVA.Items.AddRange(New Object() {"Tasa", "Cuota"})
        Me.TasaoCuotaRIVA.Location = New System.Drawing.Point(113, 71)
        Me.TasaoCuotaRIVA.Name = "TasaoCuotaRIVA"
        Me.TasaoCuotaRIVA.Size = New System.Drawing.Size(129, 22)
        Me.TasaoCuotaRIVA.TabIndex = 16
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(23, 101)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 15)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Valor "
        '
        'MTBRISR
        '
        Me.MTBRISR.Location = New System.Drawing.Point(113, 97)
        Me.MTBRISR.Mask = "0.000000"
        Me.MTBRISR.Name = "MTBRISR"
        Me.MTBRISR.Size = New System.Drawing.Size(129, 22)
        Me.MTBRISR.TabIndex = 15
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(23, 75)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 15)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "Tasa o Cuota"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(23, 48)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(58, 15)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "Impuesto"
        '
        'CBSRIVA
        '
        Me.CBSRIVA.BackColor = System.Drawing.Color.Transparent
        Me.CBSRIVA.Cursor = Wisej.Web.Cursors.Hand
        Me.CBSRIVA.Location = New System.Drawing.Point(113, 44)
        Me.CBSRIVA.Name = "CBSRIVA"
        Me.CBSRIVA.Size = New System.Drawing.Size(129, 22)
        Me.CBSRIVA.TabIndex = 14
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Chk_AplicaISR)
        Me.GroupBox2.Controls.Add(Me.TasaoCuotaISR)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.CBSRISR)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.MTBRIVA)
        Me.GroupBox2.Dock = Wisej.Web.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(287, 3)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(287, 126)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.Text = "Retención ISR"
        '
        'TasaoCuotaISR
        '
        Me.TasaoCuotaISR.FormattingEnabled = True
        Me.TasaoCuotaISR.Items.AddRange(New Object() {"Tasa", "Cuota"})
        Me.TasaoCuotaISR.Location = New System.Drawing.Point(112, 71)
        Me.TasaoCuotaISR.Name = "TasaoCuotaISR"
        Me.TasaoCuotaISR.Size = New System.Drawing.Size(129, 22)
        Me.TasaoCuotaISR.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(22, 101)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 15)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Valor "
        '
        'CBSRISR
        '
        Me.CBSRISR.BackColor = System.Drawing.Color.Transparent
        Me.CBSRISR.Cursor = Wisej.Web.Cursors.Hand
        Me.CBSRISR.Location = New System.Drawing.Point(112, 44)
        Me.CBSRISR.Name = "CBSRISR"
        Me.CBSRISR.Size = New System.Drawing.Size(129, 22)
        Me.CBSRISR.TabIndex = 14
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(24, 48)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(58, 15)
        Me.Label13.TabIndex = 12
        Me.Label13.Text = "Impuesto"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(22, 75)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 15)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Tasa o Cuota"
        '
        'MTBRIVA
        '
        Me.MTBRIVA.Location = New System.Drawing.Point(112, 97)
        Me.MTBRIVA.Mask = "0.000000"
        Me.MTBRIVA.Name = "MTBRIVA"
        Me.MTBRIVA.Size = New System.Drawing.Size(129, 22)
        Me.MTBRIVA.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Chk_AplicaIVA)
        Me.GroupBox1.Controls.Add(Me.TasaoCuotaIVA)
        Me.GroupBox1.Controls.Add(Me.MTBIVA)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.CBSIVA)
        Me.GroupBox1.Dock = Wisej.Web.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(278, 126)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.Text = "IVA"
        '
        'TasaoCuotaIVA
        '
        Me.TasaoCuotaIVA.FormattingEnabled = True
        Me.TasaoCuotaIVA.Items.AddRange(New Object() {"Tasa", "Cuota"})
        Me.TasaoCuotaIVA.Location = New System.Drawing.Point(111, 71)
        Me.TasaoCuotaIVA.Name = "TasaoCuotaIVA"
        Me.TasaoCuotaIVA.Size = New System.Drawing.Size(129, 22)
        Me.TasaoCuotaIVA.TabIndex = 16
        '
        'MTBIVA
        '
        Me.MTBIVA.Location = New System.Drawing.Point(111, 97)
        Me.MTBIVA.Mask = "0.000000"
        Me.MTBIVA.Name = "MTBIVA"
        Me.MTBIVA.Size = New System.Drawing.Size(129, 22)
        Me.MTBIVA.TabIndex = 15
        Me.MTBIVA.TextAlign = Wisej.Web.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(21, 101)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 15)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Valor "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(21, 75)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 15)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Tasa o Cuota"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(21, 48)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(58, 15)
        Me.Label8.TabIndex = 13
        Me.Label8.Text = "Impuesto"
        '
        'CBSIVA
        '
        Me.CBSIVA.BackColor = System.Drawing.Color.Transparent
        Me.CBSIVA.Cursor = Wisej.Web.Cursors.Hand
        Me.CBSIVA.Location = New System.Drawing.Point(111, 44)
        Me.CBSIVA.Name = "CBSIVA"
        Me.CBSIVA.Size = New System.Drawing.Size(129, 22)
        Me.CBSIVA.TabIndex = 14
        '
        'Chk_AplicaIVA
        '
        Me.Chk_AplicaIVA.Location = New System.Drawing.Point(108, 18)
        Me.Chk_AplicaIVA.Name = "Chk_AplicaIVA"
        Me.Chk_AplicaIVA.Size = New System.Drawing.Size(68, 22)
        Me.Chk_AplicaIVA.TabIndex = 17
        Me.Chk_AplicaIVA.Text = "Aplica"
        '
        'Chk_AplicaISR
        '
        Me.Chk_AplicaISR.Location = New System.Drawing.Point(112, 16)
        Me.Chk_AplicaISR.Name = "Chk_AplicaISR"
        Me.Chk_AplicaISR.Size = New System.Drawing.Size(68, 22)
        Me.Chk_AplicaISR.TabIndex = 18
        Me.Chk_AplicaISR.Text = "Aplica"
        '
        'Chk_AplicaIEPS
        '
        Me.Chk_AplicaIEPS.Location = New System.Drawing.Point(113, 16)
        Me.Chk_AplicaIEPS.Name = "Chk_AplicaIEPS"
        Me.Chk_AplicaIEPS.Size = New System.Drawing.Size(68, 22)
        Me.Chk_AplicaIEPS.TabIndex = 18
        Me.Chk_AplicaIEPS.Text = "Aplica"
        '
        'DataSet_pCAT_IMPUESTOS_SAT_FACTURACION_B
        '
        Me.DataSet_pCAT_IMPUESTOS_SAT_FACTURACION_B.DataSetName = "DataSet_pCAT_IMPUESTOS_SAT_FACTURACION_B"
        Me.DataSet_pCAT_IMPUESTOS_SAT_FACTURACION_B.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'BS_Impuestos
        '
        Me.BS_Impuestos.DataMember = "pCAT_IMPUESTOS_SAT_FACTURACION_B"
        Me.BS_Impuestos.DataSource = Me.DataSet_pCAT_IMPUESTOS_SAT_FACTURACION_B
        '
        'PCAT_IMPUESTOS_SAT_FACTURACION_BTableAdapter
        '
        Me.PCAT_IMPUESTOS_SAT_FACTURACION_BTableAdapter.ClearBeforeFill = True
        '
        'colC_Impuesto
        '
        Me.colC_Impuesto.DataPropertyName = "c_Impuesto"
        Me.colC_Impuesto.HeaderText = "c_Impuesto"
        Me.colC_Impuesto.Name = "colC_Impuesto"
        '
        'colDescripcionx
        '
        Me.colDescripcionx.DataPropertyName = "DescripcionX"
        Me.colDescripcionx.HeaderText = "DescripcionX"
        Me.colDescripcionx.Name = "colDescripcionx"
        Me.colDescripcionx.ReadOnly = True
        '
        'colAplica
        '
        Me.colAplica.DataPropertyName = "Aplica"
        Me.colAplica.HeaderText = "Aplica"
        Me.colAplica.Name = "colAplica"
        '
        'colTasaocuota
        '
        Me.colTasaocuota.DataPropertyName = "TasaOCuota"
        Me.colTasaocuota.HeaderText = "TasaOCuota"
        Me.colTasaocuota.Name = "colTasaocuota"
        '
        'colValor
        '
        Me.colValor.DataPropertyName = "Valor"
        Me.colValor.HeaderText = "Valor"
        Me.colValor.Name = "colValor"
        '
        'Cat_Retenciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(863, 480)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RibbonBar1)
        Me.Name = "Cat_Retenciones"
        Me.Text = "Retenciones"
        Me.Panel1.ResumeLayout(False)
        Me.Panel2.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataSet_pCAT_IMPUESTOS_SAT_FACTURACION_B, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BS_Impuestos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RibbonBar1 As Ext.RibbonBar.RibbonBar
    Friend WithEvents RibbonBarPage1 As Ext.RibbonBar.RibbonBarPage
    Friend WithEvents RibbonBarGroup1 As Ext.RibbonBar.RibbonBarGroup
    Friend WithEvents RBBActualizar As Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents RbbGuardar As Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents RbbSalir As Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TasaoCuotaIVA As ComboBox
    Friend WithEvents MTBIVA As MaskedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents CBSIVA As ComboWisax
    Friend WithEvents TasaoCuotaISR As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents CBSRISR As ComboWisax
    Friend WithEvents Label13 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents MTBRIVA As MaskedTextBox
    Friend WithEvents TasaoCuotaRIVA As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents MTBRISR As MaskedTextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents CBSRIVA As ComboWisax
    Friend WithEvents Chk_AplicaIEPS As CheckBox
    Friend WithEvents Chk_AplicaISR As CheckBox
    Friend WithEvents Chk_AplicaIVA As CheckBox
    Friend WithEvents colC_Impuesto As DataGridViewTextBoxColumn
    Friend WithEvents colDescripcionx As DataGridViewTextBoxColumn
    Friend WithEvents colAplica As DataGridViewCheckBoxColumn
    Friend WithEvents colTasaocuota As DataGridViewTextBoxColumn
    Friend WithEvents colValor As DataGridViewTextBoxColumn
    Friend WithEvents BS_Impuestos As BindingSource
    Friend WithEvents DataSet_pCAT_IMPUESTOS_SAT_FACTURACION_B As DataSet_pCAT_IMPUESTOS_SAT_FACTURACION_B
    Friend WithEvents PCAT_IMPUESTOS_SAT_FACTURACION_BTableAdapter As DataSet_pCAT_IMPUESTOS_SAT_FACTURACION_BTableAdapters.pCAT_IMPUESTOS_SAT_FACTURACION_BTableAdapter
End Class
