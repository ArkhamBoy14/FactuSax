Imports Wisej.Web
Imports Wisej.Web.Ext.RibbonBar
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Mostrar_Asp
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
        Me.RibbonBar1 = New Wisej.Web.Ext.RibbonBar.RibbonBar()
        Me.RibbonBarPage1 = New Wisej.Web.Ext.RibbonBar.RibbonBarPage()
        Me.RibbonBarGroup1 = New Wisej.Web.Ext.RibbonBar.RibbonBarGroup()
        Me.RBBACTUALIZAR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.RBBSALIR = New Wisej.Web.Ext.RibbonBar.RibbonBarItemButton()
        Me.AspNetPanel1 = New Wisej.Web.AspNetPanel()
        Me.SuspendLayout()
        '
        'RibbonBar1
        '
        Me.RibbonBar1.Name = "RibbonBar1"
        Me.RibbonBar1.Pages.Add(Me.RibbonBarPage1)
        Me.RibbonBar1.Size = New System.Drawing.Size(984, 145)
        '
        'RibbonBarPage1
        '
        Me.RibbonBarPage1.Groups.Add(Me.RibbonBarGroup1)
        Me.RibbonBarPage1.Text = "Menu"
        '
        'RibbonBarGroup1
        '
        Me.RibbonBarGroup1.Items.Add(Me.RBBACTUALIZAR)
        Me.RibbonBarGroup1.Items.Add(Me.RBBSALIR)
        Me.RibbonBarGroup1.Text = "Procesos"
        '
        'RBBACTUALIZAR
        '
        Me.RBBACTUALIZAR.ImageSource = "Resources\Images\Menu\64\actualizar_64.png"
        Me.RBBACTUALIZAR.Name = "RBBACTUALIZAR"
        Me.RBBACTUALIZAR.Text = "Actualizar"
        '
        'RBBSALIR
        '
        Me.RBBSALIR.ImageSource = "Resources\Images\Menu\64\exit_sign.png"
        Me.RBBSALIR.Name = "RBBSALIR"
        Me.RBBSALIR.Text = "Salir"
        '
        'AspNetPanel1
        '
        Me.AspNetPanel1.Dock = Wisej.Web.DockStyle.Fill
        Me.AspNetPanel1.Location = New System.Drawing.Point(0, 145)
        Me.AspNetPanel1.Name = "AspNetPanel1"
        Me.AspNetPanel1.PageSource = "DocumentViewer.aspx"
        Me.AspNetPanel1.Size = New System.Drawing.Size(984, 409)
        Me.AspNetPanel1.TabIndex = 1
        Me.AspNetPanel1.Text = "AspNetPanel1"
        '
        'Mostrar_Asp
        '
        Me.ClientSize = New System.Drawing.Size(984, 554)
        Me.Controls.Add(Me.AspNetPanel1)
        Me.Controls.Add(Me.RibbonBar1)
        Me.Name = "Mostrar_Asp"
        Me.WindowState = Wisej.Web.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents RibbonBar1 As RibbonBar
    Friend WithEvents RibbonBarPage1 As RibbonBarPage
    Friend WithEvents RibbonBarGroup1 As RibbonBarGroup
    Friend WithEvents RBBACTUALIZAR As RibbonBarItemButton
    Friend WithEvents RBBSALIR As RibbonBarItemButton
    Friend WithEvents AspNetPanel1 As AspNetPanel
End Class
