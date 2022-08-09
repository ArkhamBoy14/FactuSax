<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MyDesktop
    Inherits Wisej.Web.Desktop

    'Overrides dispose to clean up the component list.
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Wisej Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Wisej Form Designer
    'It can be modified using the Wisej Form Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Me.RibbonBar1 = New Wisej.Web.Ext.RibbonBar.RibbonBar()
        Me.pgADMIN = New Wisej.Web.Ext.RibbonBar.RibbonBarPage()
        Me.Modificar = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.RBBTEMA = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.Usuario = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.RBBINFO = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBBFONDO = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBBCERRAR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.SuspendLayout()
        '
        'RibbonBar1
        '
        Me.RibbonBar1.Font = New System.Drawing.Font("default, Arial", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Pages.Add(Me.pgADMIN)
        Me.RibbonBar1.Size = New System.Drawing.Size(1213, 123)
        '
        'pgADMIN
        '
        Me.pgADMIN.Groups.Add(Me.Modificar)
        Me.pgADMIN.Groups.Add(Me.Usuario)
        Me.pgADMIN.Name = "pgADMIN"
        Me.pgADMIN.Text = "Inicio"
        '
        'Modificar
        '
        Me.Modificar.Items.Add(Me.RBBTEMA)
        Me.Modificar.Name = "Modificar"
        Me.Modificar.Text = "Modificar"
        '
        'RBBTEMA
        '
        Me.RBBTEMA.ImageSource = "Resources\Images\Menu\64\intersection_color.png"
        Me.RBBTEMA.Name = "RBBTEMA"
        Me.RBBTEMA.Text = "Cambiar Tema"
        '
        'Usuario
        '
        Me.Usuario.Items.Add(Me.RBBINFO)
        Me.Usuario.Items.Add(Me.RBBFONDO)
        Me.Usuario.Items.Add(Me.RBBCERRAR)
        Me.Usuario.Name = "Usuario"
        Me.Usuario.Text = "Sesión y Usuario"
        '
        'RBBINFO
        '
        Me.RBBINFO.ImageSource = "Resources\Images\Menu\16\Worker Male Filled-16.png"
        Me.RBBINFO.Name = "RBBINFO"
        Me.RBBINFO.Orientation = Wisej.Web.Orientation.Horizontal
        Me.RBBINFO.Text = "Inf. de Usuario"
        '
        'RBBFONDO
        '
        Me.RBBFONDO.ImageSource = "Resources\Images\Menu\64\wallpaper.png"
        Me.RBBFONDO.Name = "RBBFONDO"
        Me.RBBFONDO.Orientation = Wisej.Web.Orientation.Horizontal
        Me.RBBFONDO.Text = "Cambiar Fondo"
        '
        'RBBCERRAR
        '
        Me.RBBCERRAR.ImageSource = "Resources\Images\Menu\64\Exit Filled-64.png"
        Me.RBBCERRAR.Name = "RBBCERRAR"
        Me.RBBCERRAR.Orientation = Wisej.Web.Orientation.Horizontal
        Me.RBBCERRAR.Text = "Cerrar Sesión"
        '
        'MyDesktop
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.Controls.Add(Me.RibbonBar1)
        Me.Name = "MyDesktop"
        Me.Size = New System.Drawing.Size(1213, 837)
        Me.ResumeLayout(False)

    End Sub


    Friend WithEvents RibbonBar1 As Ext.RibbonBar.RibbonBar
    Friend WithEvents pgADMIN As Ext.RibbonBar.RibbonBarPage
    Friend WithEvents Modificar As Ext.RibbonBar.RibbonBarGroup
    Friend WithEvents RBBTEMA As Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents Usuario As Ext.RibbonBar.RibbonBarGroup
    Friend WithEvents RBBINFO As Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents RBBCERRAR As Ext.RibbonBar.RibbonBarItemButton
    Friend WithEvents RBBFONDO As Ext.RibbonBar.RibbonBarItemButton
End Class
