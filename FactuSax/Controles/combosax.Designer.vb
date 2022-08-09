
Imports System.Windows.Forms
Imports Wisej.Web

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class combosax
    Inherits Wisej.Web.UserControl

    'User overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
        Me.list_llenado = New Wisej.Web.ListBox()
        Me.listfiltrado = New Wisej.Web.ListBox()
        Me.ToolTip1 = New Wisej.Web.ToolTip(Me.components)
        Me.txtBuscador = New Wisej.Web.TextBox()
        Me.btnDesplegar = New Wisej.Web.PictureBox()
        Me.btnLimpiar = New Wisej.Web.PictureBox()
        Me.Panel1 = New Wisej.Web.Panel()
        CType(Me.btnDesplegar, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.btnLimpiar, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'list_llenado
        '
        Me.list_llenado.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.list_llenado.BorderStyle = Wisej.Web.BorderStyle.None
        Me.list_llenado.Location = New System.Drawing.Point(3, 22)
        Me.list_llenado.Name = "list_llenado"
        Me.list_llenado.Size = New System.Drawing.Size(291, 127)
        Me.list_llenado.TabIndex = 4
        Me.list_llenado.TabStop = False
        '
        'listfiltrado
        '
        Me.listfiltrado.BorderStyle = Wisej.Web.BorderStyle.None
        Me.listfiltrado.Location = New System.Drawing.Point(1, 22)
        Me.listfiltrado.Name = "listfiltrado"
        Me.listfiltrado.Size = New System.Drawing.Size(283, 115)
        Me.listfiltrado.TabIndex = 5
        Me.listfiltrado.TabStop = False
        '
        'txtBuscador
        '
        Me.txtBuscador.BorderStyle = Wisej.Web.BorderStyle.None
        Me.txtBuscador.Dock = Wisej.Web.DockStyle.Fill
        Me.txtBuscador.Location = New System.Drawing.Point(0, 0)
        Me.txtBuscador.Margin = New Wisej.Web.Padding(0)
        Me.txtBuscador.Name = "txtBuscador"
        Me.txtBuscador.Size = New System.Drawing.Size(293, 20)
        Me.txtBuscador.TabIndex = 1
        Me.txtBuscador.Watermark = "Seleccione una opción"
        Me.txtBuscador.WordWrap = False
        '
        'btnDesplegar
        '
        Me.btnDesplegar.BackColor = System.Drawing.Color.FromArgb(241, 241, 241)
        Me.btnDesplegar.BackgroundImageLayout = Wisej.Web.ImageLayout.Center
        Me.btnDesplegar.BackgroundImageSource = "Resources/Images/Combo/BOTON.jpg"
        Me.btnDesplegar.Cursor = Wisej.Web.Cursors.Hand
        Me.btnDesplegar.Dock = Wisej.Web.DockStyle.Right
        Me.btnDesplegar.Location = New System.Drawing.Point(314, 0)
        Me.btnDesplegar.Margin = New Wisej.Web.Padding(0)
        Me.btnDesplegar.Name = "btnDesplegar"
        Me.btnDesplegar.Size = New System.Drawing.Size(21, 20)
        '
        'btnLimpiar
        '
        Me.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(241, 241, 241)
        Me.btnLimpiar.BackgroundImageLayout = Wisej.Web.ImageLayout.Center
        Me.btnLimpiar.BackgroundImageSource = "Resources/Images/Combo/BOTONELIMINAR.jpg"
        Me.btnLimpiar.CssStyle = "border-Width:5px"
        Me.btnLimpiar.Cursor = Wisej.Web.Cursors.Hand
        Me.btnLimpiar.Dock = Wisej.Web.DockStyle.Right
        Me.btnLimpiar.Location = New System.Drawing.Point(293, 0)
        Me.btnLimpiar.Margin = New Wisej.Web.Padding(0)
        Me.btnLimpiar.Name = "btnLimpiar"
        Me.btnLimpiar.Size = New System.Drawing.Size(21, 20)
        Me.btnLimpiar.Visible = False
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.txtBuscador)
        Me.Panel1.Controls.Add(Me.btnLimpiar)
        Me.Panel1.Controls.Add(Me.btnDesplegar)
        Me.Panel1.Dock = Wisej.Web.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Margin = New Wisej.Web.Padding(0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(335, 20)
        Me.Panel1.TabIndex = 1
        Me.Panel1.TabStop = True
        '
        'combosax
        '
        Me.BorderStyle = Wisej.Web.BorderStyle.Solid
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.list_llenado)
        Me.Controls.Add(Me.listfiltrado)
        Me.Margin = New Wisej.Web.Padding(0)
        Me.Name = "combosax"
        Me.Size = New System.Drawing.Size(337, 22)
        CType(Me.btnDesplegar, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.btnLimpiar, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents list_llenado As Wisej.Web.ListBox
    Friend WithEvents listfiltrado As Wisej.Web.ListBox
    Friend WithEvents ToolTip1 As Wisej.Web.ToolTip
    Friend WithEvents btnDesplegar As Wisej.Web.PictureBox
    Friend WithEvents btnLimpiar As Wisej.Web.PictureBox
    Friend WithEvents txtBuscador As Wisej.Web.TextBox
    Friend WithEvents Panel1 As Wisej.Web.Panel
End Class
