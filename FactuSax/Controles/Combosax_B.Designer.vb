<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Combosax_B
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
        Me.TableLayoutPanel1 = New Wisej.Web.TableLayoutPanel()
        Me.Txtbuscador = New Wisej.Web.TextBox()
        Me.BtnActivador = New Wisej.Web.PictureBox()
        Me.PictureBox1 = New Wisej.Web.PictureBox()
        Me.Timer1 = New Wisej.Web.Timer(Me.components)
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.BtnActivador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'list_llenado
        '
        Me.list_llenado.Focusable = False
        Me.list_llenado.HorizontalScrollbar = True
        Me.list_llenado.Location = New System.Drawing.Point(3, 53)
        Me.list_llenado.Name = "list_llenado"
        Me.list_llenado.Size = New System.Drawing.Size(441, 96)
        Me.list_llenado.TabIndex = 4
        '
        'listfiltrado
        '
        Me.listfiltrado.Focusable = False
        Me.listfiltrado.Location = New System.Drawing.Point(56, 172)
        Me.listfiltrado.Name = "listfiltrado"
        Me.listfiltrado.Size = New System.Drawing.Size(379, 96)
        Me.listfiltrado.TabIndex = 5
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Percent, 80.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New Wisej.Web.ColumnStyle(Wisej.Web.SizeType.Absolute, 30.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.Txtbuscador, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.BtnActivador, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.PictureBox1, 1, 0)
        Me.TableLayoutPanel1.Dock = Wisej.Web.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New Wisej.Web.RowStyle(Wisej.Web.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.RowStyles.Add(New Wisej.Web.RowStyle(Wisej.Web.SizeType.Absolute, 20.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(276, 21)
        Me.TableLayoutPanel1.TabIndex = 9
        Me.TableLayoutPanel1.TabStop = True
        '
        'Txtbuscador
        '
        Me.Txtbuscador.BorderStyle = Wisej.Web.BorderStyle.None
        Me.Txtbuscador.Dock = Wisej.Web.DockStyle.Fill
        Me.Txtbuscador.Location = New System.Drawing.Point(3, 3)
        Me.Txtbuscador.Name = "Txtbuscador"
        Me.Txtbuscador.Size = New System.Drawing.Size(210, 15)
        Me.Txtbuscador.TabIndex = 7
        Me.Txtbuscador.WordWrap = False
        '
        'BtnActivador
        '
        Me.BtnActivador.BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Me.BtnActivador.BackgroundImageLayout = Wisej.Web.ImageLayout.Center
        Me.BtnActivador.BackgroundImageSource = "Resources/Images/Combo/BOTON40.jpg"
        Me.BtnActivador.Cursor = Wisej.Web.Cursors.Hand
        Me.BtnActivador.Dock = Wisej.Web.DockStyle.Fill
        Me.BtnActivador.Location = New System.Drawing.Point(249, 3)
        Me.BtnActivador.Name = "BtnActivador"
        Me.BtnActivador.Size = New System.Drawing.Size(24, 15)
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Me.PictureBox1.BackgroundImageLayout = Wisej.Web.ImageLayout.Center
        Me.PictureBox1.BackgroundImageSource = "Resources/Images/Combo/BOTONELIMINAR.jpg"
        Me.PictureBox1.Dock = Wisej.Web.DockStyle.Fill
        Me.PictureBox1.Location = New System.Drawing.Point(219, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(24, 15)
        '
        'Timer1
        '
        '
        'Combosax_B
        '
        Me.BackColor = System.Drawing.Color.FromName("@window")
        Me.BorderStyle = Wisej.Web.BorderStyle.Solid
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.listfiltrado)
        Me.Controls.Add(Me.list_llenado)
        Me.Name = "Combosax_B"
        Me.Size = New System.Drawing.Size(278, 23)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.TableLayoutPanel1.PerformLayout()
        CType(Me.BtnActivador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents list_llenado As Wisej.Web.ListBox
    Friend WithEvents listfiltrado As Wisej.Web.ListBox
    Friend WithEvents ToolTip1 As Wisej.Web.ToolTip
    Friend WithEvents TableLayoutPanel1 As Wisej.Web.TableLayoutPanel
    Friend WithEvents Txtbuscador As Wisej.Web.TextBox
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents BtnActivador As PictureBox
    Friend WithEvents Timer1 As Timer
End Class
