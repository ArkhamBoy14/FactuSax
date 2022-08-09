<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Notificaciones
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
        Me.JavaScript1 = New Wisej.Web.JavaScript(Me.components)
        Me.SuspendLayout()
        '
        'Notificaciones
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = Wisej.Web.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(612, 480)
        Me.Name = "Notificaciones"
        Me.Text = "Notificaciones"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents JavaScript1 As JavaScript
End Class
