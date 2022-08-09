

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ComboGridSax
    Inherits Wisej.Web.UserControl

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
        Me.SplitContainer1 = New Wisej.Web.SplitContainer()
        Me.TextBox1 = New Wisej.Web.TextBox()
        Me.PictureBox1 = New Wisej.Web.PictureBox()
        Me.BtnActivador = New Wisej.Web.PictureBox()
        Me.ContextMenuStrip1 = New Wisej.Web.ContextMenu()
        Me.ToolTip1 = New Wisej.Web.ToolTip(Me.components)
        Me.Panel1 = New Wisej.Web.Panel()
        Me.BindingSource1 = New Wisej.Web.BindingSource(Me.components)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BtnActivador, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.AutoValidate = Wisej.Web.AutoValidate.EnablePreventFocusChange
        Me.SplitContainer1.Dock = Wisej.Web.DockStyle.Top
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.PictureBox1)
        Me.SplitContainer1.Panel2.Controls.Add(Me.BtnActivador)
        Me.SplitContainer1.Size = New System.Drawing.Size(448, 21)
        Me.SplitContainer1.SplitterDistance = 418
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 2
        '
        'TextBox1
        '
        Me.TextBox1.Dock = Wisej.Web.DockStyle.Fill
        Me.TextBox1.Location = New System.Drawing.Point(0, 0)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(418, 21)
        Me.TextBox1.TabIndex = 0
        Me.TextBox1.Watermark = "Ingrese Texto (Enter)..."
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Me.PictureBox1.BackgroundImageLayout = Wisej.Web.ImageLayout.Center
        Me.PictureBox1.BackgroundImageSource = "Resources/Images/Combo/BOTONELIMINAR40.jpg"
        Me.PictureBox1.Dock = Wisej.Web.DockStyle.Right
        Me.PictureBox1.Location = New System.Drawing.Point(-23, 0)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(25, 19)
        '
        'BtnActivador
        '
        Me.BtnActivador.BackColor = System.Drawing.Color.FromArgb(240, 240, 240)
        Me.BtnActivador.BackgroundImageLayout = Wisej.Web.ImageLayout.Center
        Me.BtnActivador.BackgroundImageSource = "Combo.BOTON.jpg"
        Me.BtnActivador.Cursor = Wisej.Web.Cursors.Hand
        Me.BtnActivador.Dock = Wisej.Web.DockStyle.Right
        Me.BtnActivador.ImageSource = "Resources\Images\Menu\16\vision.png"
        Me.BtnActivador.Location = New System.Drawing.Point(2, 0)
        Me.BtnActivador.Name = "BtnActivador"
        Me.BtnActivador.Size = New System.Drawing.Size(25, 19)
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        '
        'Panel1
        '
        Me.Panel1.Dock = Wisej.Web.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 21)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(448, 0)
        Me.Panel1.TabIndex = 3
        Me.Panel1.TabStop = True
        '
        'ComboGridSax
        '
        Me.BackColor = System.Drawing.Color.Transparent
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Cursor = Wisej.Web.Cursors.Hand
        Me.Name = "ComboGridSax"
        Me.Size = New System.Drawing.Size(448, 21)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BtnActivador, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents BtnActivador As PictureBox
    Friend WithEvents ToolTip1 As ToolTip
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ContextMenuStrip1 As ContextMenu
    Friend WithEvents BindingSource1 As BindingSource
    Friend WithEvents Panel1 As Panel
    Friend WithEvents TextBox1 As TextBox
End Class