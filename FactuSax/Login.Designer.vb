<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Login
    Inherits Wisej.Web.Page

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
        Me.PanelLogin = New Wisej.Web.Panel()
        Me.PanelForm = New Wisej.Web.Panel()
        Me.bLogin = New Wisej.Web.Button()
        Me.LabelError = New Wisej.Web.Label()
        Me.Label2 = New Wisej.Web.Label()
        Me.Label1 = New Wisej.Web.Label()
        Me.cContrasena = New Wisej.Web.TextBox()
        Me.cUsuario = New Wisej.Web.TextBox()
        Me.ErrorProvider1 = New Wisej.Web.ErrorProvider(Me.components)
        Me.PictureBoxLogo = New Wisej.Web.PictureBox()
        Me.PanelLogin.SuspendLayout()
        Me.PanelForm.SuspendLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PanelLogin
        '
        Me.PanelLogin.BackColor = System.Drawing.Color.Transparent
        Me.PanelLogin.Controls.Add(Me.PanelForm)
        Me.PanelLogin.Dock = Wisej.Web.DockStyle.Bottom
        Me.PanelLogin.ForeColor = System.Drawing.Color.Black
        Me.PanelLogin.Location = New System.Drawing.Point(0, 475)
        Me.PanelLogin.Name = "PanelLogin"
        Me.PanelLogin.Size = New System.Drawing.Size(1157, 260)
        Me.PanelLogin.TabIndex = 2
        Me.PanelLogin.TabStop = True
        '
        'PanelForm
        '
        Me.PanelForm.BackColor = System.Drawing.Color.Transparent
        Me.PanelForm.BorderStyle = Wisej.Web.BorderStyle.Solid
        Me.PanelForm.Controls.Add(Me.bLogin)
        Me.PanelForm.Controls.Add(Me.LabelError)
        Me.PanelForm.Controls.Add(Me.Label2)
        Me.PanelForm.Controls.Add(Me.Label1)
        Me.PanelForm.Controls.Add(Me.cContrasena)
        Me.PanelForm.Controls.Add(Me.cUsuario)
        Me.PanelForm.CssStyle = "border-color: #fffff;"
        Me.PanelForm.Location = New System.Drawing.Point(478, 36)
        Me.PanelForm.Name = "PanelForm"
        Me.PanelForm.Size = New System.Drawing.Size(241, 221)
        Me.PanelForm.TabIndex = 1
        Me.PanelForm.TabStop = True
        '
        'bLogin
        '
        Me.bLogin.Font = New System.Drawing.Font("@defaultBold", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.bLogin.Location = New System.Drawing.Point(27, 136)
        Me.bLogin.Name = "bLogin"
        Me.bLogin.Size = New System.Drawing.Size(189, 27)
        Me.bLogin.TabIndex = 2
        Me.bLogin.Text = "Entrar"
        '
        'LabelError
        '
        Me.LabelError.AutoSize = True
        Me.LabelError.Font = New System.Drawing.Font("default", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.LabelError.ForeColor = System.Drawing.Color.Red
        Me.LabelError.Location = New System.Drawing.Point(27, 190)
        Me.LabelError.Name = "LabelError"
        Me.LabelError.Size = New System.Drawing.Size(188, 15)
        Me.LabelError.TabIndex = 4
        Me.LabelError.Text = "Error de usuario / Contraseña"
        Me.LabelError.Visible = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("default", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label2.ForeColor = System.Drawing.Color.FromName("@desktop")
        Me.Label2.Location = New System.Drawing.Point(80, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(76, 15)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Contraseña"
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("default", 13.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel)
        Me.Label1.ForeColor = System.Drawing.Color.FromName("@desktop")
        Me.Label1.Location = New System.Drawing.Point(3, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(235, 16)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Usuario"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'cContrasena
        '
        Me.cContrasena.InputType.Type = Wisej.Web.TextBoxType.Password
        Me.cContrasena.Location = New System.Drawing.Point(24, 98)
        Me.cContrasena.Name = "cContrasena"
        Me.cContrasena.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.cContrasena.Size = New System.Drawing.Size(192, 22)
        Me.cContrasena.TabIndex = 1
        '
        'cUsuario
        '
        Me.cUsuario.InputType.Type = Wisej.Web.TextBoxType.Email
        Me.cUsuario.Location = New System.Drawing.Point(24, 38)
        Me.cUsuario.Name = "cUsuario"
        Me.cUsuario.Size = New System.Drawing.Size(192, 22)
        Me.cUsuario.TabIndex = 0
        '
        'ErrorProvider1
        '
        Me.ErrorProvider1.ContainerControl = Me
        '
        'PictureBoxLogo
        '
        Me.PictureBoxLogo.BackColor = System.Drawing.Color.Transparent
        Me.PictureBoxLogo.Dock = Wisej.Web.DockStyle.Top
        Me.PictureBoxLogo.Location = New System.Drawing.Point(0, 0)
        Me.PictureBoxLogo.Name = "PictureBoxLogo"
        Me.PictureBoxLogo.Size = New System.Drawing.Size(1157, 475)
        Me.PictureBoxLogo.SizeMode = Wisej.Web.PictureBoxSizeMode.Zoom
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(31, 31, 31)
        Me.Controls.Add(Me.PanelLogin)
        Me.Controls.Add(Me.PictureBoxLogo)
        Me.Name = "Login"
        Me.Size = New System.Drawing.Size(1140, 581)
        Me.PanelLogin.ResumeLayout(False)
        Me.PanelForm.ResumeLayout(False)
        Me.PanelForm.PerformLayout()
        CType(Me.ErrorProvider1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBoxLogo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PanelLogin As Panel
    Friend WithEvents PanelForm As Panel
    Friend WithEvents bLogin As Button
    Friend WithEvents LabelError As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents cContrasena As TextBox
    Friend WithEvents cUsuario As TextBox
    Friend WithEvents ErrorProvider1 As ErrorProvider
    Friend WithEvents PictureBoxLogo As PictureBox
End Class
