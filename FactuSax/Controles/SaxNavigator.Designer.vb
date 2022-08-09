<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SaxNavigator
    Inherits Wisej.Web.UserControl

    'SaxNavigator overrides dispose to clean up the component list.
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
        Me.Panel1 = New Wisej.Web.Panel()
        Me.Btn_Siguiente = New Wisej.Web.Button()
        Me.Btn_Anterior = New Wisej.Web.Button()
        Me.Btn_Final = New Wisej.Web.Button()
        Me.Lb_Contador = New Wisej.Web.Label()
        Me.Btn_Inicio = New Wisej.Web.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Btn_Siguiente)
        Me.Panel1.Controls.Add(Me.Btn_Anterior)
        Me.Panel1.Controls.Add(Me.Btn_Final)
        Me.Panel1.Controls.Add(Me.Lb_Contador)
        Me.Panel1.Controls.Add(Me.Btn_Inicio)
        Me.Panel1.Dock = Wisej.Web.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(366, 48)
        Me.Panel1.TabIndex = 0
        Me.Panel1.TabStop = True
        '
        'Btn_Siguiente
        '
        Me.Btn_Siguiente.ImageSource = "icon-right"
        Me.Btn_Siguiente.Location = New System.Drawing.Point(260, 10)
        Me.Btn_Siguiente.Name = "Btn_Siguiente"
        Me.Btn_Siguiente.Size = New System.Drawing.Size(40, 27)
        Me.Btn_Siguiente.TabIndex = 4
        '
        'Btn_Anterior
        '
        Me.Btn_Anterior.ImageSource = "icon-left"
        Me.Btn_Anterior.Location = New System.Drawing.Point(55, 10)
        Me.Btn_Anterior.Name = "Btn_Anterior"
        Me.Btn_Anterior.Size = New System.Drawing.Size(40, 27)
        Me.Btn_Anterior.TabIndex = 3
        '
        'Btn_Final
        '
        Me.Btn_Final.ImageSource = "scrollbar-arrow-right"
        Me.Btn_Final.Location = New System.Drawing.Point(306, 10)
        Me.Btn_Final.Name = "Btn_Final"
        Me.Btn_Final.Size = New System.Drawing.Size(46, 27)
        Me.Btn_Final.TabIndex = 2
        '
        'Lb_Contador
        '
        Me.Lb_Contador.Anchor = CType(((Wisej.Web.AnchorStyles.Top Or Wisej.Web.AnchorStyles.Left) _
            Or Wisej.Web.AnchorStyles.Right), Wisej.Web.AnchorStyles)
        Me.Lb_Contador.Location = New System.Drawing.Point(124, 15)
        Me.Lb_Contador.Name = "Lb_Contador"
        Me.Lb_Contador.Size = New System.Drawing.Size(119, 16)
        Me.Lb_Contador.TabIndex = 1
        Me.Lb_Contador.Text = "0 de 0 datos"
        Me.Lb_Contador.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Btn_Inicio
        '
        Me.Btn_Inicio.ImageSource = "scrollbar-arrow-left"
        Me.Btn_Inicio.Location = New System.Drawing.Point(3, 10)
        Me.Btn_Inicio.Name = "Btn_Inicio"
        Me.Btn_Inicio.Size = New System.Drawing.Size(46, 27)
        Me.Btn_Inicio.TabIndex = 0
        '
        'SaxNavigator
        '
        Me.Controls.Add(Me.Panel1)
        Me.Name = "SaxNavigator"
        Me.Size = New System.Drawing.Size(366, 48)
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Btn_Final As Button
    Friend WithEvents Lb_Contador As Label
    Friend WithEvents Btn_Inicio As Button
    Friend WithEvents Btn_Siguiente As Button
    Friend WithEvents Btn_Anterior As Button
End Class
