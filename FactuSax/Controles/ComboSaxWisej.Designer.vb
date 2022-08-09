<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ComboSaxWisej
    Inherits Wisej.Web.UserControl

    'ComboSaxWisej overrides dispose to clean up the component list.
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox1 = New Wisej.Web.TextBox()
        Me.ContextMenu1 = New Wisej.Web.ContextMenu()
        Me.PictureBox1 = New Wisej.Web.PictureBox()
        Me.PictureBox2 = New Wisej.Web.PictureBox()
        Me.ListBox1 = New Wisej.Web.ListBox()
        Me.SplitContainer1 = New Wisej.Web.SplitContainer()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(-1, 2)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(220, 22)
        Me.TextBox1.TabIndex = 0
        '
        'ContextMenu1
        '
        Me.ContextMenu1.Name = "ContextMenu1"
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(217, 1)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(32, 22)
        Me.PictureBox1.TabIndex = 1
        '
        'PictureBox2
        '
        Me.PictureBox2.Location = New System.Drawing.Point(250, 1)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(32, 22)
        Me.PictureBox2.TabIndex = 2
        '
        'ListBox1
        '
        Me.ListBox1.Location = New System.Drawing.Point(-1, 1)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(283, 119)
        Me.ListBox1.TabIndex = 3
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = Wisej.Web.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.PictureBox1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.ListBox1)
        Me.SplitContainer1.Size = New System.Drawing.Size(303, 158)
        Me.SplitContainer1.SplitterDistance = 25
        Me.SplitContainer1.TabIndex = 4
        '
        'ComboSaxWisej
        '
        Me.Controls.Add(Me.SplitContainer1)
        Me.Name = "ComboSaxWisej"
        Me.Size = New System.Drawing.Size(286, 160)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TextBox1 As Wisej.Web.TextBox
    Friend WithEvents ContextMenu1 As Wisej.Web.ContextMenu
    Friend WithEvents PictureBox1 As Wisej.Web.PictureBox
    Friend WithEvents PictureBox2 As Wisej.Web.PictureBox
    Friend WithEvents ListBox1 As Wisej.Web.ListBox
    Friend WithEvents SplitContainer1 As Wisej.Web.SplitContainer
End Class
