Imports System
Imports System.Data
Imports System.Data.SqlClient
Imports Wisej.Web

Public Class ComboWisax
    Inherits Wisej.Web.ComboBox

    'NOTE: The following procedure is required by the Wisej Designer
    'It can be modified using the Wisej Designer.  
    'Do not modify it using the code editor.
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ComboWisax))
        Dim ComponentTool1 As Wisej.Web.ComponentTool = New Wisej.Web.ComponentTool()
        Me.SuspendLayout()
        '
        'ComboWisax
        '
        Me.AutoCompleteMode = Wisej.Web.AutoCompleteMode.Filter
        'Me.InitScript = resources.GetString("$this.InitScript")
        Me.Name = "ComboWisax"
        Me.Size = New System.Drawing.Size(290, 22)
        ComponentTool1.ImageSource = "Resources\Images\Combo\BOTONELIMINAR.png"
        ComponentTool1.Name = "toolBorrar"
        ComponentTool1.Visible = False
        Me.Tools.AddRange(New Wisej.Web.ComponentTool() {ComponentTool1})
        Me.ResumeLayout(False)

    End Sub



    ''' <summary>
    Private ME_ICON_BORRAR As String = "iVBORw0KGgoAAAANSUhEUgAAABMAAAATCAYAAAByUDbMAAABhGlDQ1BJQ0MgcHJvZmlsZQAAKJF9kT1Iw0AcxV+/aJFKBzuIiGSoThZERRylikWwUNoKrTqYXPoFTRqSFBdHwbXg4Mdi1cHFWVcHV0EQ/ABxcnRSdJES/5cUWsR4cNyPd/ced+8Ab6vGFMM/ASiqqWeSCSFfWBWCrwghgAhG4BeZoaWyizm4jq97ePh6F+dZ7uf+HP1y0WCARyCeY5puEm8Qz2yaGud94iiriDLxOfG4ThckfuS65PAb57LNXp4Z1XOZeeIosVDuYamHWUVXiKeJY7KiUr4377DMeYuzUmuwzj35C8NFdSXLdZrDSGIJKaQhQEIDVdRgIk6rSoqBDO0nXPxDtj9NLolcVTByLKAOBaLtB/+D390apalJJymcAAIvlvUxCgR3gXbTsr6PLat9AviegSu166+3gNlP0ptdLXYERLaBi+uuJu0BlzvA4JMm6qIt+Wh6SyXg/Yy+qQAM3AJ9a05vnX2cPgA56mr5Bjg4BMbKlL3u8u5Qb2//nun09wMlTHKIQw/ptgAAAAZiS0dEANEAzwDOq/nTXAAAAAlwSFlzAAAuIwAALiMBeKU/dgAAAAd0SU1FB+QIBQ8tLSgGCWAAAAAZdEVYdENvbW1lbnQAQ3JlYXRlZCB3aXRoIEdJTVBXgQ4XAAAAQklEQVQ4y2NgGAUjANTX1/+vr6//T0gMGTARYygyjQ8wEmMQMmhsbGQkyzB0A/EZRHWXMZHqIooiAGYQIS+OguEGAIdYJHY6vYpjAAAAAElFTkSuQmCC"
    ''' </summary>    '
    ' 
    ''''

    Private ME_CONEXION As New SqlConnection
    Private ME_DESCRIPCION_COMBO As String
    Private ME_DATATABLE_FILL As DataTable
    Private ME_PROCEDURE As String
    Private ME_COLUMNA_DESCRIPCION As String
    Private ME_COLUMNA_VALOR As String
    Private ME_PUEDE_ACTUALIZAR As Boolean
    Private ME_READ_ONLY As Boolean
    Private ME_MOSTRAR_MENSAJE As Boolean
    Private ME_ASCENDER_EVENT As Boolean
    Private ME_ASCENDER_LOAD_EVENT As Boolean
    Private ME_TOOL_LIMPIAR As ComponentTool
    'Private ME_LABEL_COMBO As LabelWrapper

    '
    '
    '
    'properties
#Region "propiedades"

    Public ReadOnly Property Count
        Get
            Return Me.Items.Count
        End Get
    End Property

    Public Property DescripcionCampo() As String
        Get
            If Me.ME_DESCRIPCION_COMBO Is Nothing Then
                Return Me.Name
            Else
                Return Me.ME_DESCRIPCION_COMBO

            End If
        End Get
        Set(ByVal descripcion As String)
            Me.ME_DESCRIPCION_COMBO = descripcion
        End Set
    End Property
    Public ReadOnly Property dataTable() As DataTable
        Get
            Return ME_DATATABLE_FILL
        End Get
    End Property

    Public Overloads Property SelectedItem() As String
        Get
            If ME_DATATABLE_FILL IsNot Nothing Then
                If MyBase.SelectedItem IsNot Nothing Then
                    Return MyBase.SelectedItem.ROW(ME_COLUMNA_DESCRIPCION)
                Else
                    Return Nothing
                End If
            Else
                Return Nothing
            End If
        End Get
        Set(ByVal value As String)
            Try

                If ME_DATATABLE_FILL IsNot Nothing Then
                    Dim filas As DataRow() = ME_DATATABLE_FILL.Select(ME_COLUMNA_DESCRIPCION & "='" & value & "'")
                    If filas.Length > 0 Then
                        MyBase.SelectedValue = filas(0).Item(ME_COLUMNA_VALOR)
                    End If
                End If

            Catch ex As Exception
                MessageBox.Show(ex.Message)

            End Try
        End Set
    End Property
#End Region

    Public Sub New()
        InitializeComponent()
        ScriptSearch()
        ME_TOOL_LIMPIAR = Me.Tools("toolBorrar")
        Dim icono As Drawing.Image = Nothing
        Dim imgBytes As Byte() = Nothing
        imgBytes = Convert.FromBase64String(ME_ICON_BORRAR)
        Dim ms As New IO.MemoryStream(imgBytes)
        icono = Drawing.Image.FromStream(ms)
        ME_TOOL_LIMPIAR.Image = icono
        ME_ASCENDER_LOAD_EVENT = True

    End Sub

    Private Sub ScriptSearch()
        Me.InitScript = "this.onFilterListItem = function (label, text) {

            if (text && label) {
                // match the beginning of the label. case insensitive.
                if (label.toLowerCase().includes(text.toLowerCase())){
                    // if (label.toLowerCase().indexOf(text.toLowerCase()) === 0)
                    return true; // show.
                }
            }
            else {
                // show the text is empty.
                return true;
            }

            // hide.
            return false;
        }"
    End Sub

    '
    '
    '
    '
    '
    Private Sub Conectar()
        Try
            If ME_CONEXION.State = ConnectionState.Closed Then
                ME_CONEXION.ConnectionString = Utilidades.sConexion
                ME_CONEXION.Open()
            End If
        Catch ex As SystemException
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub Desconectar()
        Try
            If ME_CONEXION.State <> ConnectionState.Closed Then ME_CONEXION.Close()
        Catch ex As SystemException
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Public Sub LlenarListBox(procedimiento As String, columnaValor As String, ColumnaDescripcion As String, Optional parametros() As SqlParameter = Nothing)
        Conectar()
        Try
            If parametros IsNot Nothing Then
                procedimiento = procedimiento & prepararConsulta(parametros)
            End If
            Me.ME_COLUMNA_DESCRIPCION = ColumnaDescripcion
            Me.ME_COLUMNA_VALOR = columnaValor
            Me.ME_PROCEDURE = procedimiento

            Dim SqlComm As SqlCommand = New SqlCommand(procedimiento, ME_CONEXION)
            Dim rs As SqlDataReader = SqlComm.ExecuteReader
            ME_DATATABLE_FILL = New DataTable(Me.Name & "_DataTable")
            ME_DATATABLE_FILL.Load(rs)

            Me.ValueMember = columnaValor
            Me.DisplayMember = ColumnaDescripcion
            ME_ASCENDER_EVENT = False
            Me.DataSource = ME_DATATABLE_FILL
            Me.SelectedIndex = -1
            ME_PUEDE_ACTUALIZAR = True
        Catch ex As Exception
            MessageBox.Show("Error: la consulta del combo " & Me.DescripcionCampo & " no pudo realizarse." & vbCrLf & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Desconectar()
    End Sub
    Private Sub comboPrincipal_ToolClick(sender As Object, e As ToolClickEventArgs) Handles MyBase.ToolClick
        If e.Tool.Name = "toolBorrar" Then
            Me.SelectedIndex = -1
        End If
    End Sub
    Public Function ObtenerDescripcion(nombreColumna As String) As String
        Dim valor As String = ""
        If ME_DATATABLE_FILL IsNot Nothing Then
            If ME_DATATABLE_FILL.Columns.Contains(nombreColumna) Then
                If Me.SelectedIndex <> -1 Then
                    valor = Me.dataTable.Rows.Item(Me.SelectedIndex).Item(nombreColumna).ToString()
                End If
            End If
        End If
        Return valor
    End Function
    Private Function prepararConsulta(parametros() As SqlParameter) As String
        Dim parametrosProcedure As String = ""
        Try
            If parametros IsNot Nothing Then
                Dim sep As String = " "
                For i = 0 To parametros.GetLength(0) - 1
                    If parametros(i) IsNot Nothing Then

                        If parametros(i).DbType = DbType.String Then
                            parametrosProcedure &= sep & parametros(i).ParameterName & " = '" & parametros(i).Value & "'"
                        ElseIf parametros(i).DbType = DbType.Boolean Then
                            parametrosProcedure &= sep & parametros(i).ParameterName & " = " & Convert.ToInt32(parametros(i).Value)
                        Else
                            parametrosProcedure += sep & parametros(i).ParameterName & " = " & parametros(i).Value
                        End If
                        sep = ", "
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show("Error: los parametros del combo " & Me.DescripcionCampo & " no pudieron cargarse." & vbCrLf & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        Return parametrosProcedure
    End Function
    Public Function contieneClave(clave As String)
        If Me.dataTable IsNot Nothing Then
            If Me.dataTable.Columns.Contains(Me.ValueMember) Then
                If Me.dataTable.Select(Me.ValueMember & "='" & clave & "'").Length > 0 Then
                    Return True
                End If
            End If
        End If
        Return False
    End Function
    Public Function contieneItem(Item As String)
        If Me.dataTable IsNot Nothing Then
            If Me.dataTable.Columns.Contains(Me.DisplayMember) Then
                If Me.dataTable.Select(Me.DisplayMember & "='" & Item & "'").Length > 0 Then
                    Return True
                End If
            End If
        End If
        Return False
    End Function
    Private Sub ComboWisax_KeyPress(sender As Object, e As KeyPressEventArgs) Handles MyBase.KeyPress
        If Convert.ToChar(Keys.Enter) = e.KeyChar Then
            Me.DroppedDown = True
        End If

    End Sub
    Private Sub ComboWisax_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        If Me.SelectedIndex = -1 Then
            Me.Text = ""
        Else
            If ME_DATATABLE_FILL IsNot Nothing Then
                If Me.Text <> ME_DATATABLE_FILL.Rows.Item(Me.SelectedIndex).Item(ME_COLUMNA_DESCRIPCION).ToString Then
                    Dim index As Integer = Me.SelectedIndex
                    Me.SelectedIndex = -1
                End If

            End If
        End If
    End Sub
    Private Sub txtProcedure_ToolClick(sender As TextBox, e As ToolClickEventArgs)
        If sender.Text <> "" Then
            Clipboard.SetClientText(sender.Text)
            If Clipboard.GetText IsNot Nothing Then
                Application.Eval("Wisej.Core.copy();")
            End If
        End If
    End Sub
    Public Sub LlenarConList(lista As List(Of String), column As String, procedure As String)

        Dim tablaList As New DataTable("Lista")
        Dim columnas As New DataColumn(column, "".GetType)
        tablaList.Columns.Add(columnas)
        For I = 0 To lista.Count - 1
            Dim fila As DataRow = tablaList.NewRow()
            fila.Item(column) = lista.Item(I)
            tablaList.Rows.Add(fila)
        Next
        Me.ME_DATATABLE_FILL = tablaList
        Me.ME_COLUMNA_DESCRIPCION = column
        Me.ME_COLUMNA_VALOR = column
        Me.ME_PROCEDURE = procedure

        Me.ValueMember = column
        Me.DisplayMember = column

        ME_ASCENDER_EVENT = False
        Me.DataSource = tablaList
        Me.SelectedIndex = -1
        ME_PUEDE_ACTUALIZAR = True
    End Sub
    Public Sub LlenarConList(lista As List(Of String))

        Dim tablaList As New DataTable("Lista")
        Dim columnas As New DataColumn("Clave", "".GetType)
        tablaList.Columns.Add(columnas)
        For I = 0 To lista.Count - 1
            Dim fila As DataRow = tablaList.NewRow()
            fila.Item("Clave") = lista.Item(I)
            tablaList.Rows.Add(fila)
        Next
        Me.ME_DATATABLE_FILL = tablaList
        Me.ME_COLUMNA_DESCRIPCION = "Clave"
        Me.ME_COLUMNA_VALOR = "Clave"
        Me.ME_PROCEDURE = ""

        Me.ValueMember = "Clave"
        Me.DisplayMember = "Clave"

        ME_ASCENDER_EVENT = False
        Me.DataSource = tablaList

        Me.SelectedIndex = -1
        ME_PUEDE_ACTUALIZAR = True
    End Sub
    Public Sub Clear()
        ME_PUEDE_ACTUALIZAR = False
        If ME_DATATABLE_FILL IsNot Nothing Then
            ME_DATATABLE_FILL.Clear()
        End If

        Me.DataSource = Nothing
        Me.DisplayMember = Nothing
        Me.ValueMember = Nothing
    End Sub
    Public Sub Actualizar()
        If ME_PUEDE_ACTUALIZAR Then
            Conectar()
            Try

                Dim SqlComm As SqlCommand = New SqlCommand(ME_PROCEDURE, ME_CONEXION)
                Dim rs As SqlDataReader = SqlComm.ExecuteReader
                ME_ASCENDER_EVENT = False
                Me.SelectedIndex = -1
                ME_ASCENDER_EVENT = False
                ME_DATATABLE_FILL = New DataTable
                ME_DATATABLE_FILL.Load(rs)
                Me.DataSource = ME_DATATABLE_FILL
                Me.ValueMember = ME_COLUMNA_VALOR
                Me.DisplayMember = ME_COLUMNA_DESCRIPCION
                Me.SelectedIndex = -1

            Catch ex As Exception
                MessageBox.Show("Error: la consulta del combo " & Me.DescripcionCampo & " no pudo realizarse." & vbCrLf & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            Desconectar()
            Me.Focus()

        End If
    End Sub

    Private Sub comboPrincipal_SelectedIndexChanged(sender As Object, e As EventArgs) Handles Me.SelectedIndexChanged

        If ME_ASCENDER_EVENT Then
            If MyBase.SelectedIndex <> -1 Then
                Me.ME_TOOL_LIMPIAR.Visible = True
            Else
                Me.ME_TOOL_LIMPIAR.Visible = False
            End If

        Else
            If ME_ASCENDER_LOAD_EVENT Then
                Me.SelectedIndex = -1
                ME_ASCENDER_LOAD_EVENT = False
            End If
            ME_ASCENDER_EVENT = True
        End If
    End Sub

    Private Sub ComboWisax_MouseClick(sender As Object, e As MouseEventArgs) Handles MyBase.MouseClick
        If e.Button = MouseButtons.Right Then
            Dim txtProcedure As TextBox = Nothing
            Dim ToolCopy As New ComponentTool

            Dim popProcedure As New UserPopup()
            AddHandler popProcedure.Leave, AddressOf popProcedure_Leave
            popProcedure.Height = 25
            popProcedure.Width = 250

            Dim pnl As Panel = New Panel
            pnl.Dock = DockStyle.Fill
            pnl.AutoScroll = True
            pnl.BackColor = Drawing.Color.FromArgb(245, 245, 245)
            pnl.Padding = New Padding(1)

            Dim lblActualizar As New Label()
            lblActualizar.Text = "Actualizar"
            lblActualizar.TextAlign = Drawing.ContentAlignment.MiddleLeft
            lblActualizar.Height = 24
            lblActualizar.Margin = New Padding(0)
            lblActualizar.Font = New System.Drawing.Font("default", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            AddHandler lblActualizar.Click, AddressOf Actualizar
            pnl.Controls.Add(lblActualizar)
            lblActualizar.Dock = DockStyle.Top
            lblActualizar.BringToFront()

            If Application.Session("Cve_Operador") <> Nothing Then
                If Application.Session("Cve_Operador").ToString.ToUpper = "NA" Then
                    txtProcedure = New TextBox()
                    txtProcedure.Text = ME_PROCEDURE
                    txtProcedure.Height = 25
                    txtProcedure.Width = 300
                    pnl.Controls.Add(txtProcedure)
                    txtProcedure.Dock = DockStyle.Top
                    ToolCopy.ImageSource = "Resources\Images\64x64\copy2.png"
                    ToolCopy.Name = "ToolCopy"
                    ToolCopy.ToolTipText = "Copiar"
                    txtProcedure.Tools.Add(ToolCopy)
                    txtProcedure.BringToFront()

                    AddHandler txtProcedure.ToolClick, AddressOf txtProcedure_ToolClick
                End If
            End If

            popProcedure.CssStyle = "border-style:solid; border-Width: 1px;border-color: #bdbfbf;"
            'popProcedure.AutoSize = True
            popProcedure.AutoSizeMode = AutoSizeMode.GrowAndShrink
            popProcedure.AutoScroll = True
            popProcedure.Controls.Add(pnl)
            popProcedure.ShowPopup(Me) '.Location.X + Me.Width, Me.Location.Y)
            If txtProcedure IsNot Nothing Then
                popProcedure.Height = 52
                txtProcedure.Focus()
                txtProcedure.SelectAll()
            End If
        End If
    End Sub
    Private Sub popProcedure_Leave(sender As UserPopup, e As EventArgs)
        sender.Dispose()
    End Sub
    Property MostrarMensaje() As Boolean
        Get
            Return True
        End Get
        Set(value As Boolean)

        End Set
    End Property

End Class
