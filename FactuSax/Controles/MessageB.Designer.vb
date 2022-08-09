
Imports Wisej.Web

<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MessageB
    Inherits Wisej.Web.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
        Me.Linea1 = New Wisej.Web.Label()
        Me.Linea2 = New Wisej.Web.Label()
        Me.Panel1 = New Wisej.Web.Panel()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Linea1
        '
        Me.Linea1.AutoSize = True
        Me.Linea1.Location = New System.Drawing.Point(113, 31)
        Me.Linea1.Name = "Linea1"
        Me.Linea1.Size = New System.Drawing.Size(38, 13)
        Me.Linea1.TabIndex = 0
        Me.Linea1.Text = "Label1"
        Me.Linea1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Linea2
        '
        Me.Linea2.AutoSize = True
        Me.Linea2.Location = New System.Drawing.Point(113, 66)
        Me.Linea2.Name = "Linea2"
        Me.Linea2.Size = New System.Drawing.Size(38, 13)
        Me.Linea2.TabIndex = 1
        Me.Linea2.Text = "Label2"
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.Linea2)
        Me.Panel1.Controls.Add(Me.Linea1)
        Me.Panel1.Dock = Wisej.Web.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(303, 102)
        Me.Panel1.TabIndex = 2
        '
        'MessageB
        '
        Me.CloseBox = False
        Me.ControlBox = False
        Me.Controls.Add(Me.Panel1)
        Me.Size = New System.Drawing.Size(303, 102)
        Me.Text = "MessageBox"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Linea1 As Label
    Friend WithEvents Linea2 As Label
    Friend WithEvents Panel1 As Panel
End Class
