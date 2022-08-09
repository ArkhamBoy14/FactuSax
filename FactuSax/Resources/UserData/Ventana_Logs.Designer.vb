
<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ventana_Logs
    Inherits Wisej.Web.form

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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lstLogs = New ListBox
        Me.SuspendLayout()
        '
        'lstLogs
        '
        Me.lstLogs.Dock = DockStyle.Fill
        Me.lstLogs.Location = New System.Drawing.Point(0, 0)
        Me.lstLogs.Name = "lstLogs"
        Me.lstLogs.Size = New System.Drawing.Size(772, 459)
        Me.lstLogs.TabIndex = 0
        '
        'Ventana_Logs
        '
        Me.Controls.Add(Me.lstLogs)
        Me.Size = New System.Drawing.Size(772, 461)
        Me.Text = "Ventana_Logs"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lstLogs As ListBox

End Class