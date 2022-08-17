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
        Me.Panel3 = New Wisej.Web.Panel()
        Me.TableLayoutPanel1 = New Wisej.Web.TableLayoutPanel()
        Me.GroupBox3 = New Wisej.Web.GroupBox()
        Me.Chk_AplicaIEPS = New Wisej.Web.CheckBox()
        Me.TasaoCuotaIEPS = New Wisej.Web.ComboBox()
        Me.Label14 = New Wisej.Web.Label()
        Me.MTBIEPS = New Wisej.Web.MaskedTextBox()
        Me.Label15 = New Wisej.Web.Label()
        Me.GroupBox2 = New Wisej.Web.GroupBox()
        Me.Chk_AplicaISR = New Wisej.Web.CheckBox()
        Me.TasaoCuotaISR = New Wisej.Web.ComboBox()
        Me.Label11 = New Wisej.Web.Label()
        Me.Label12 = New Wisej.Web.Label()
        Me.MTBISR = New Wisej.Web.MaskedTextBox()
        Me.GroupBox1 = New Wisej.Web.GroupBox()
        Me.Chk_AplicaIVA = New Wisej.Web.CheckBox()
        Me.TasaoCuotaIVA = New Wisej.Web.ComboBox()
        Me.MTBIVA = New Wisej.Web.MaskedTextBox()
        Me.Label10 = New Wisej.Web.Label()
        Me.Label9 = New Wisej.Web.Label()
        Me.Panel2 = New Wisej.Web.Panel()
        Me.Label1 = New Wisej.Web.Label()
        Me.BS_Impuestos = New Wisej.Web.BindingSource(Me.components)
        Me.DataSet_pCAT_IMPUESTOS_SAT_FACTURACION_B = New FactuSax.DataSet_pCAT_IMPUESTOS_SAT_FACTURACION_B()
        Me.PCAT_IMPUESTOS_SAT_FACTURACION_BTableAdapter = New FactuSax.DataSet_pCAT_IMPUESTOS_SAT_FACTURACION_BTableAdapters.pCAT_IMPUESTOS_SAT_FACTURACION_BTableAdapter()
        Me.CbxClientes = New FactuSax.ComboWisax()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        CType(Me.BS_Impuestos, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSet_pCAT_IMPUESTOS_SAT_FACTURACION_B, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonBar1
        '
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Pages.Add(Me.RibbonBarPage1)
        Me.RibbonBar1.Size = New System.Drawing.Size(806, 109)
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
        Me.Panel1.Controls.Add(Me.Panel3)
        Me.Panel1.Dock = Wisej.Web.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 109)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(806, 326)
        Me.Panel1.TabIndex = 1
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.TableLayoutPanel1)
        Me.Panel3.Controls.Add(Me.Panel2)
        Me.Panel3.Dock = Wisej.Web.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(806, 326)
        Me.Panel3.TabIndex = 1
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 1
        Me.TableLayoutPanel1.ColumnStyles.Add(New Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 33.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox3, 2, 2)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox2, 2, 1)
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(436, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 3
        Me.TableLayoutPanel1.RowStyles.Add(New Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 108.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 111.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(370, 326)
        Me.TableLayoutPanel1.TabIndex = 0
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Chk_AplicaIEPS)
        Me.GroupBox3.Controls.Add(Me.TasaoCuotaIEPS)
        Me.GroupBox3.Controls.Add(Me.Label14)
        Me.GroupBox3.Controls.Add(Me.MTBIEPS)
        Me.GroupBox3.Controls.Add(Me.Label15)
        Me.GroupBox3.Dock = Wisej.Web.DockStyle.Fill
        Me.GroupBox3.Location = New System.Drawing.Point(3, 218)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(364, 105)
        Me.GroupBox3.TabIndex = 2
        Me.GroupBox3.Text = "Retención IEPS"
        '
        'Chk_AplicaIEPS
        '
        Me.Chk_AplicaIEPS.Location = New System.Drawing.Point(113, 16)
        Me.Chk_AplicaIEPS.Name = "Chk_AplicaIEPS"
        Me.Chk_AplicaIEPS.Size = New System.Drawing.Size(66, 22)
        Me.Chk_AplicaIEPS.TabIndex = 18
        Me.Chk_AplicaIEPS.Text = "Aplica"
        '
        'TasaoCuotaIEPS
        '
        Me.TasaoCuotaIEPS.FormattingEnabled = True
        Me.TasaoCuotaIEPS.Items.AddRange(New Object() {"Tasa", "Cuota"})
        Me.TasaoCuotaIEPS.Location = New System.Drawing.Point(113, 44)
        Me.TasaoCuotaIEPS.Name = "TasaoCuotaIEPS"
        Me.TasaoCuotaIEPS.Size = New System.Drawing.Size(129, 22)
        Me.TasaoCuotaIEPS.TabIndex = 16
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(23, 74)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(35, 15)
        Me.Label14.TabIndex = 11
        Me.Label14.Text = "Valor "
        '
        'MTBIEPS
        '
        Me.MTBIEPS.Location = New System.Drawing.Point(113, 70)
        Me.MTBIEPS.Mask = "0.000000"
        Me.MTBIEPS.Name = "MTBIEPS"
        Me.MTBIEPS.Size = New System.Drawing.Size(129, 22)
        Me.MTBIEPS.TabIndex = 15
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(23, 48)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(83, 15)
        Me.Label15.TabIndex = 12
        Me.Label15.Text = "Tasa o Cuota"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Chk_AplicaISR)
        Me.GroupBox2.Controls.Add(Me.TasaoCuotaISR)
        Me.GroupBox2.Controls.Add(Me.Label11)
        Me.GroupBox2.Controls.Add(Me.Label12)
        Me.GroupBox2.Controls.Add(Me.MTBISR)
        Me.GroupBox2.Dock = Wisej.Web.DockStyle.Fill
        Me.GroupBox2.Location = New System.Drawing.Point(3, 110)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(364, 102)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.Text = "Retención ISR"
        '
        'Chk_AplicaISR
        '
        Me.Chk_AplicaISR.Location = New System.Drawing.Point(112, 16)
        Me.Chk_AplicaISR.Name = "Chk_AplicaISR"
        Me.Chk_AplicaISR.Size = New System.Drawing.Size(66, 22)
        Me.Chk_AplicaISR.TabIndex = 18
        Me.Chk_AplicaISR.Text = "Aplica"
        '
        'TasaoCuotaISR
        '
        Me.TasaoCuotaISR.FormattingEnabled = True
        Me.TasaoCuotaISR.Items.AddRange(New Object() {"Tasa", "Cuota"})
        Me.TasaoCuotaISR.Location = New System.Drawing.Point(113, 44)
        Me.TasaoCuotaISR.Name = "TasaoCuotaISR"
        Me.TasaoCuotaISR.Size = New System.Drawing.Size(129, 22)
        Me.TasaoCuotaISR.TabIndex = 16
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(23, 74)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(35, 15)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Valor "
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(23, 48)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(83, 15)
        Me.Label12.TabIndex = 13
        Me.Label12.Text = "Tasa o Cuota"
        '
        'MTBISR
        '
        Me.MTBISR.Location = New System.Drawing.Point(113, 70)
        Me.MTBISR.Mask = "0.000000"
        Me.MTBISR.Name = "MTBISR"
        Me.MTBISR.Size = New System.Drawing.Size(129, 22)
        Me.MTBISR.TabIndex = 15
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Chk_AplicaIVA)
        Me.GroupBox1.Controls.Add(Me.TasaoCuotaIVA)
        Me.GroupBox1.Controls.Add(Me.MTBIVA)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Dock = Wisej.Web.DockStyle.Fill
        Me.GroupBox1.Location = New System.Drawing.Point(3, 3)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(364, 101)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.Text = "IVA"
        '
        'Chk_AplicaIVA
        '
        Me.Chk_AplicaIVA.Location = New System.Drawing.Point(108, 18)
        Me.Chk_AplicaIVA.Name = "Chk_AplicaIVA"
        Me.Chk_AplicaIVA.Size = New System.Drawing.Size(66, 22)
        Me.Chk_AplicaIVA.TabIndex = 17
        Me.Chk_AplicaIVA.Text = "Aplica"
        '
        'TasaoCuotaIVA
        '
        Me.TasaoCuotaIVA.FormattingEnabled = True
        Me.TasaoCuotaIVA.Items.AddRange(New Object() {"Tasa", "Cuota"})
        Me.TasaoCuotaIVA.Location = New System.Drawing.Point(113, 48)
        Me.TasaoCuotaIVA.Name = "TasaoCuotaIVA"
        Me.TasaoCuotaIVA.Size = New System.Drawing.Size(129, 22)
        Me.TasaoCuotaIVA.TabIndex = 16
        '
        'MTBIVA
        '
        Me.MTBIVA.Location = New System.Drawing.Point(113, 74)
        Me.MTBIVA.Mask = "0.000000"
        Me.MTBIVA.Name = "MTBIVA"
        Me.MTBIVA.Size = New System.Drawing.Size(129, 22)
        Me.MTBIVA.TabIndex = 15
        Me.MTBIVA.TextAlign = Wisej.Web.HorizontalAlignment.Center
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(23, 78)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 15)
        Me.Label10.TabIndex = 11
        Me.Label10.Text = "Valor "
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(23, 52)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(83, 15)
        Me.Label9.TabIndex = 12
        Me.Label9.Text = "Tasa o Cuota"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.CbxClientes)
        Me.Panel2.Dock = Wisej.Web.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 0)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(436, 326)
        Me.Panel2.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(19, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(45, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Cliente"
        '
        'BS_Impuestos
        '
        Me.BS_Impuestos.DataMember = "pCAT_IMPUESTOS_SAT_FACTURACION_B"
        Me.BS_Impuestos.DataSource = Me.DataSet_pCAT_IMPUESTOS_SAT_FACTURACION_B
        '
        'DataSet_pCAT_IMPUESTOS_SAT_FACTURACION_B
        '
        Me.DataSet_pCAT_IMPUESTOS_SAT_FACTURACION_B.DataSetName = "DataSet_pCAT_IMPUESTOS_SAT_FACTURACION_B"
        Me.DataSet_pCAT_IMPUESTOS_SAT_FACTURACION_B.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PCAT_IMPUESTOS_SAT_FACTURACION_BTableAdapter
        '
        Me.PCAT_IMPUESTOS_SAT_FACTURACION_BTableAdapter.ClearBeforeFill = True
        '
        'CbxClientes
        '
        Me.CbxClientes.Location = New System.Drawing.Point(19, 31)
        Me.CbxClientes.Name = "CbxClientes"
        Me.CbxClientes.TabIndex = 10
        '
        'Cat_Retenciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(806, 435)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.RibbonBar1)
        Me.Name = "Cat_Retenciones"
        Me.Text = "Retenciones"
        Me.Panel1.ResumeLayout(False)
        Me.Panel3.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.BS_Impuestos, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSet_pCAT_IMPUESTOS_SAT_FACTURACION_B, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents RibbonBar1 As Ext.RibbonBar.RibbonBar
    Friend WithEvents RibbonBarPage1 As Ext.RibbonBar.RibbonBarPage
    Friend WithEvents RibbonBarGroup1 As Ext.RibbonBar.RibbonBarGroup
    Friend WithEvents RBBActualizar As Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents RbbGuardar As Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents RbbSalir As Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents TasaoCuotaIVA As ComboBox
    Friend WithEvents MTBIVA As MaskedTextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents TasaoCuotaISR As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents MTBISR As MaskedTextBox
    Friend WithEvents Chk_AplicaISR As CheckBox
    Friend WithEvents Chk_AplicaIVA As CheckBox
    Friend WithEvents BS_Impuestos As BindingSource
    Friend WithEvents DataSet_pCAT_IMPUESTOS_SAT_FACTURACION_B As DataSet_pCAT_IMPUESTOS_SAT_FACTURACION_B
    Friend WithEvents PCAT_IMPUESTOS_SAT_FACTURACION_BTableAdapter As DataSet_pCAT_IMPUESTOS_SAT_FACTURACION_BTableAdapters.pCAT_IMPUESTOS_SAT_FACTURACION_BTableAdapter
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Chk_AplicaIEPS As CheckBox
    Friend WithEvents TasaoCuotaIEPS As ComboBox
    Friend WithEvents Label14 As Label
    Friend WithEvents MTBIEPS As MaskedTextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Label1 As Label
    Friend WithEvents CbxClientes As ComboWisax
End Class
