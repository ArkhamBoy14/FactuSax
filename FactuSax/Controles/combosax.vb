
Imports System.Drawing
Imports Wisej.Web
Imports System.Data

Public Class combosax
    Private ME_PROCEDURE_DATASET As String
    Private ME_CONEXION As String
    Private ME_COLUMNA_ID As String
    Private ME_COLUMNA_DESCRIPCION As String
    Private ME_TABLA_DEFAULT As DataTable
    Private ME_DATASET_ORIGINAL As DataSet
    Private ME_DATASET_FILTRADO As DataSet
    Private IS_VALOR_SELECTED As Boolean = False

    Dim LIMITAR_REGISTROS As Boolean = False
    Dim ReadOnlyi As Boolean = False
    Private ME_MOSTRAR_MENSAJE As Boolean = False

    Dim userPop As UserPopup

    Dim Num_Registros As Integer = 0
    Public Event SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs)




    Private Sub Combosax_B_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        userPop = New UserPopup
        ME_TABLA_DEFAULT = New DataTable

        list_llenado.Font = Me.Font
        list_llenado.Enabled = Me.Enabled
        userPop.Width = Me.Width
        txtBuscador.Clear()
        txtBuscador.Font = Me.Font
        txtBuscador.Enabled = Me.Enabled
        Me.btnDesplegar.CssStyle = "border-style: solid; border-Width:0px 0px 0px 1px;border-color: #bdbfbf;"
        Me.btnLimpiar.CssStyle = "border-style: solid; border-Width:0px 0px 0px 1px;border-color: #bdbfbf;"
    End Sub
    Public Sub llenar_lis_nuevo(ByVal sId As String, ByVal sDescripcion As String, ByVal parametros As String, ByVal cConnect As String)
        Try
            ME_PROCEDURE_DATASET = parametros
            ME_COLUMNA_ID = sId
            ME_COLUMNA_DESCRIPCION = sDescripcion
            ME_CONEXION = cConnect

            Dim myDA As Data.SqlClient.SqlDataAdapter = New Data.SqlClient.SqlDataAdapter(parametros, cConnect)
            myDA.SelectCommand.CommandType = CommandType.Text
            myDA.SelectCommand.CommandTimeout = 5000
            ME_DATASET_ORIGINAL = New DataSet
            myDA.Fill(ME_DATASET_ORIGINAL, "SQLX")
            ME_TABLA_DEFAULT = ME_DATASET_ORIGINAL.Tables(0)

            ME_DATASET_FILTRADO = New DataSet
            ME_DATASET_FILTRADO = ME_DATASET_ORIGINAL.Copy()

            'list_llenado.Dispose()
            list_llenado.DataSource = Nothing
            list_llenado.Items.Clear()
            list_llenado.DisplayMember = ME_DATASET_ORIGINAL.Tables(0).Columns(sDescripcion).ColumnName
            list_llenado.DataSource = ME_DATASET_ORIGINAL.Tables(0)
            list_llenado.ValueMember = ME_DATASET_ORIGINAL.Tables(0).Columns(sId).ColumnName

            'listfiltrado.Dispose()
            listfiltrado.DataSource = Nothing
            listfiltrado.Items.Clear()
            listfiltrado.DisplayMember = ME_DATASET_FILTRADO.Tables(0).Columns(sDescripcion).ColumnName
            listfiltrado.DataSource = ME_DATASET_FILTRADO.Tables(0)
            listfiltrado.ValueMember = ME_DATASET_FILTRADO.Tables(0).Columns(sId).ColumnName

        Catch ex As NullReferenceException
            MessageBox.Show("Columna Invalida " & Space(1) & sDescripcion & "o " & sId & " Del combo " & Me.Name.ToString, "combosax_mV5", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub
    Public Sub Clear(Optional cleanDS As Boolean = True)
        SelectedIndex = -1
        txtBuscador.Tag = Nothing
        Num_Registros = 0

        If cleanDS Then
            If (Me.ME_DATASET_ORIGINAL IsNot Nothing) Then
                If (Me.ME_DATASET_ORIGINAL.Tables.Count > 0) Then
                    If (Me.ME_DATASET_ORIGINAL.Tables(0) IsNot Nothing) Then
                        Me.ME_DATASET_ORIGINAL.Tables(0).Clear()
                    End If
                End If
            End If
        End If

        If cleanDS Then '() agregado Oscar :v
            If (Me.ME_DATASET_FILTRADO IsNot Nothing) Then
                If (Me.ME_DATASET_FILTRADO.Tables.Count > 0) Then
                    If (Me.ME_DATASET_FILTRADO.Tables(0) IsNot Nothing) Then
                        Me.ME_DATASET_FILTRADO.Tables(0).Clear()
                    End If
                End If
            End If
        End If
    End Sub



    Private Sub list_llenado_Click(sender As Object, e As EventArgs) Handles list_llenado.Click
        If ReadOnlyi = False Then
            If list_llenado.SelectedIndex <> -1 Then
                txtBuscador.Text = list_llenado.Items(list_llenado.SelectedIndex).Row.Item(ME_COLUMNA_DESCRIPCION).ToString
                ToolTip1.SetToolTip(txtBuscador, txtBuscador.Text)
                listfiltrado.SelectedValue = list_llenado.SelectedValue
                txtBuscador.Tag = list_llenado.SelectedValue
                Me.btnLimpiar.Visible = True
                userPop.Close()
                txtBuscador.Focus()
                txtBuscador.SelectionStart = txtBuscador.Text.Length
                IS_VALOR_SELECTED = True
                RaiseEvent SelectedIndexChanged(Me, Nothing)
            End If
        Else
            userPop.Close()
        End If
    End Sub



    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        limpiarFiltroDelList()
        If userPop IsNot Nothing Then userPop.Close()
        txtBuscador.Text = Nothing
        btnLimpiar.Visible = False
        IS_VALOR_SELECTED = False
        RaiseEvent SelectedIndexChanged(Me, e)

    End Sub


    Private Sub Mostrar_lista(autoSeleccionar As Boolean)
        If DataSource Is Nothing Then Exit Sub
        If list_llenado.Items.Count = 0 Then Exit Sub

        If list_llenado.Items.Count = 1 And autoSeleccionar Then
            list_llenado_Click(Me, Nothing)


        Else
            If list_llenado.Items.Count >= 5 Then
                userPop.Height = 120
            Else
                userPop.Height = 1 + (list_llenado.Items.Count * 24)
            End If
            userPop.Width = Me.Width

            userPop.Controls.Clear()
            userPop.Controls.Add(list_llenado)
            list_llenado.Dock = DockStyle.Fill
            list_llenado.BringToFront()
            'userPop.TabIndex = 1
            userPop.CssStyle = "border-style:solid; border-Width: 0px 1px 1px 1px;border-color: #bdbfbf;"
            userPop.ShowPopup(Me)
            list_llenado.Focusable = True
            list_llenado.Focus()
        End If

    End Sub

    Private Sub txtbuscador_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtBuscador.KeyPress
        If Convert.ToChar(Keys.Escape) <> e.KeyChar And Convert.ToChar(Keys.Tab) <> e.KeyChar Then
            IS_VALOR_SELECTED = False
        End If

        If e.KeyChar = Convert.ToChar(13) Then
            If txtBuscador.Text = "" Then
                limpiarFiltroDelList()
                Mostrar_lista(True)
            Else
                filtrarListDesplegado()
                Mostrar_lista(True)
            End If
        Else
            'se rompe al escribir rápido
            'Try
            '    Me.BringToFront()
            '    If ME_DATASET_ORIGINAL IsNot Nothing Then
            '        Dim filtroWhere As String = ""
            '        If TODOS <> True Then
            '            If Me.txtBuscador.Text <> Nothing Then
            '                filtroWhere = ME_COLUMNA_DESCRIPCION & "  like '%" & CStr(Me.txtBuscador.Text) & "%'"
            '            End If
            '        End If
            '        'limpiarFiltroDelList()

            '        Dim dataViewFiltrado = ME_DATASET_ORIGINAL.Tables(0).DefaultView
            '        dataViewFiltrado.RowFilter = filtroWhere
            '        Dim objDT = dataViewFiltrado.ToTable()

            '        list_llenado.DataSource = Nothing
            '        list_llenado.Items.Clear()
            '        list_llenado.ValueMember = ME_COLUMNA_ID
            '        list_llenado.DisplayMember = ME_COLUMNA_DESCRIPCION
            '        list_llenado.DataSource = objDT

            '        Dim max As Integer = 0
            '        For Each row As DataRow In Me.DataSource.Tables(0).Rows
            '            frmForm.Width = Me.Width
            '            If max < Len(row(ME_COLUMNA_DESCRIPCION).ToString) Then
            '                max = Len(row(ME_COLUMNA_DESCRIPCION).ToString)
            '                If max * 8 > Me.Width Then
            '                    list_llenado.Width = max * 8
            '                    list_llenado.Dock = DockStyle.None
            '                    list_llenado.Top = 0
            '                Else
            '                    list_llenado.Dock = DockStyle.Fill
            '                End If
            '            End If
            '        Next
            '    End If

            '    'If e.KeyChar = Convert.ToChar(Keys.Backspace) Or e.KeyChar = Convert.ToChar(Keys.Subtract) Then
            '    '    Mostrar_lista(False)
            '    'Else
            '    Mostrar_lista(False) ' lo deje así sin el if porque puede ser confuso para el usuario
            '    'End If

            'Catch ex As NullReferenceException
            '    MessageBox.Show("Error del combo " & Me.Name.ToString, "CombosaxV5", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            'End Try

        End If

    End Sub


    Public Sub filtrarCombo(where As String, Optional concatenarFiltros As Boolean = True)
        If ME_DATASET_FILTRADO IsNot Nothing Then

            Dim dv As DataView = Nothing
            If concatenarFiltros Then
                dv = ME_DATASET_FILTRADO.Tables(0).DefaultView
            Else
                dv = ME_TABLA_DEFAULT.DefaultView
            End If
            dv.RowFilter = where
            Dim ndt As DataTable = dv.ToTable()
            ME_DATASET_FILTRADO.Tables.RemoveAt(0)
            ME_DATASET_FILTRADO.Tables.Add(ndt)
            With listfiltrado
                .DataSource = Nothing
                .Items.Clear()
                .ValueMember = ME_DATASET_FILTRADO.Tables(0).Columns(ME_COLUMNA_ID).ColumnName
                .DataSource = ME_DATASET_FILTRADO.Tables(0)
                .DisplayMember = ME_DATASET_FILTRADO.Tables(0).Columns(ME_COLUMNA_DESCRIPCION).ColumnName
            End With


            Dim dv2 As DataView = Nothing
            If concatenarFiltros Then
                dv2 = ME_DATASET_ORIGINAL.Tables(0).DefaultView
            Else
                dv2 = ME_TABLA_DEFAULT.DefaultView
            End If
            dv2.RowFilter = where
            Dim ndt2 As DataTable = dv2.ToTable()
            ME_DATASET_ORIGINAL.Tables.RemoveAt(0)
            ME_DATASET_ORIGINAL.Tables.Add(ndt2)
            With listfiltrado
                .DataSource = Nothing
                .Items.Clear()
                .ValueMember = ME_DATASET_ORIGINAL.Tables(0).Columns(ME_COLUMNA_ID).ColumnName
                .DataSource = ME_DATASET_ORIGINAL.Tables(0)
                .DisplayMember = ME_DATASET_ORIGINAL.Tables(0).Columns(ME_COLUMNA_DESCRIPCION).ColumnName
            End With


        End If
    End Sub

    Public Sub limpiarFiltro()
        If ME_DATASET_ORIGINAL IsNot Nothing And ME_DATASET_FILTRADO IsNot Nothing Then

            ME_DATASET_ORIGINAL.Tables.RemoveAt(0)
            ME_DATASET_ORIGINAL.Tables.Add(ME_TABLA_DEFAULT)
            With listfiltrado
                .DataSource = Nothing
                .Items.Clear()
                .ValueMember = ME_DATASET_ORIGINAL.Tables(0).Columns(ME_COLUMNA_ID).ColumnName
                .DataSource = ME_DATASET_ORIGINAL.Tables(0)
                .DisplayMember = ME_DATASET_ORIGINAL.Tables(0).Columns(ME_COLUMNA_DESCRIPCION).ColumnName
            End With


            With list_llenado
                .DataSource = Nothing
                .Items.Clear()
                .ValueMember = ME_DATASET_ORIGINAL.Tables(0).Columns(ME_COLUMNA_ID).ColumnName
                .DataSource = ME_DATASET_ORIGINAL.Tables(0)
                .DisplayMember = ME_DATASET_ORIGINAL.Tables(0).Columns(ME_COLUMNA_DESCRIPCION).ColumnName
            End With


            ME_DATASET_FILTRADO.Tables.RemoveAt(0)
            ME_DATASET_FILTRADO.Tables.Add(ME_TABLA_DEFAULT)
            With listfiltrado
                .DataSource = Nothing
                .Items.Clear()
                .ValueMember = ME_DATASET_FILTRADO.Tables(0).Columns(ME_COLUMNA_ID).ColumnName
                .DataSource = ME_DATASET_FILTRADO.Tables(0)
                .DisplayMember = ME_DATASET_FILTRADO.Tables(0).Columns(ME_COLUMNA_DESCRIPCION).ColumnName
            End With


            With list_llenado
                .DataSource = Nothing
                .Items.Clear()
                .ValueMember = ME_DATASET_FILTRADO.Tables(0).Columns(ME_COLUMNA_ID).ColumnName
                .DataSource = ME_DATASET_FILTRADO.Tables(0)
                .DisplayMember = ME_DATASET_FILTRADO.Tables(0).Columns(ME_COLUMNA_DESCRIPCION).ColumnName
            End With
        End If
    End Sub

    Public Property Count() As Integer
        Get
            Count = list_llenado.Items.Count
        End Get
        Set(ByVal value As Integer)
        End Set
    End Property

    Public Property DataSource() As System.Data.DataSet
        Get
            DataSource = ME_DATASET_ORIGINAL
        End Get
        Set(ByVal value As System.Data.DataSet)
            ME_DATASET_ORIGINAL = value
        End Set
    End Property

    Public Property DataSourceSelect() As System.Data.DataSet
        Get
            DataSource = ME_DATASET_FILTRADO
        End Get
        Set(ByVal value As System.Data.DataSet)

            ME_DATASET_FILTRADO = value
        End Set
    End Property

    Protected Overridable Function GetCustomDropDown() As Form
        Return Nothing
    End Function
    Private ReadOnly Property DropDownHandler As EventHandler
        Get
        End Get
    End Property


    Private Sub OnDropDown(ByVal objEventArgs As EventArgs)
        Dim dropDownHandler As EventHandler = Me.DropDownHandler
        If (dropDownHandler IsNot Nothing) Then
            dropDownHandler(Me, objEventArgs)
        End If
    End Sub

    Public Property Watermark() As String
        Get
            Return txtBuscador.Watermark
        End Get

        Set(value As String)
            If value <> Nothing Then
                txtBuscador.Watermark = value
            End If
        End Set
    End Property

    Public Property SelectedIndex() As Integer
        Get
            Dim I As Integer
            If txtBuscador.Text = Nothing Then
                I = -1
            Else
                I = listfiltrado.SelectedIndex
            End If
            SelectedIndex = I
        End Get

        Set(ByVal value As Integer)
            IS_VALOR_SELECTED = False
            Try

                If value <> -1 Then
                    If list_llenado IsNot Nothing Then
                        If value < list_llenado.Items.Count Then
                            list_llenado.SelectedIndex = value
                            txtBuscador.Text = list_llenado.Items(list_llenado.SelectedIndex).Row.Item(ME_COLUMNA_DESCRIPCION).ToString
                            ToolTip1.SetToolTip(txtBuscador, txtBuscador.Text)
                            listfiltrado.SelectedValue = list_llenado.SelectedValue
                            txtBuscador.Tag = list_llenado.SelectedValue
                            IS_VALOR_SELECTED = True
                            btnLimpiar.Visible = True
                        End If
                    End If
                Else
                    ToolTip1.SetToolTip(txtBuscador, "")
                    txtBuscador.Text = Nothing
                    txtBuscador.Tag = Nothing
                    listfiltrado.SelectedIndex = -1
                    btnLimpiar.Visible = False
                    If listfiltrado.Items.Count > 0 Then
                        If userPop IsNot Nothing Then
                            userPop.Close()
                        End If

                    End If
                End If
                RaiseEvent SelectedIndexChanged(Me, Nothing)
            Catch ex As Exception
                list_llenado.SelectedIndex = -1
                MessageBox.Show("Error: Argumento Invalido: " & " Nombre del parametro SelectedIndex = " & value & ".", "Cargar listas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End Set
    End Property



    Public Property SelectedValue() As String
        Get
            If txtBuscador.Text <> Nothing Then

                SelectedValue = listfiltrado.SelectedValue
            Else
                SelectedValue = Nothing
                listfiltrado.SelectedIndex = -1
            End If
        End Get
        Set(ByVal value As String)
            IS_VALOR_SELECTED = False
            Try
                If value <> Nothing Then
                    ToolTip1.SetToolTip(txtBuscador, value)
                    txtBuscador.Tag = value
                    listfiltrado.SelectedValue = value
                    txtBuscador.Text = listfiltrado.SelectedItem.Row.Item(ME_COLUMNA_DESCRIPCION).ToString
                    btnLimpiar.Visible = True
                    IS_VALOR_SELECTED = True
                Else
                    SelectedIndex = -1
                End If
                RaiseEvent SelectedIndexChanged(Me, Nothing)

            Catch ex As NullReferenceException
                If ME_MOSTRAR_MENSAJE Then
                    MessageBox.Show("Error Del combo " & Me.Name.ToString & " al querer asignar el valor " & value & " el cual no existe", "combosax", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    SelectedIndex = -1
                End If
            End Try
        End Set
    End Property

    Public Property SelectedItem() As String
        Get
            If txtBuscador.Text <> Nothing Then
                SelectedItem = txtBuscador.Text
            Else
                SelectedItem = ""
            End If
        End Get
        Set(ByVal value As String)
            If value <> Nothing Then
                txtBuscador.Text = value
                If LIMITAR_REGISTROS = True Then
                    'checar TXTBUSQUEDA_TextChanged(1, Nothing)
                Else
                    Dim index As Integer = listfiltrado.FindString(txtBuscador.Text)
                    If index <> -1 Then
                        listfiltrado.SetSelected(0, False)
                        listfiltrado.SetSelected(index, True)
                    Else
                        listfiltrado.SelectedIndex = -1
                    End If
                End If
                ToolTip1.SetToolTip(txtBuscador, value)
            End If
        End Set
    End Property


    Private Sub limpiarFiltroDelList()
        If ME_DATASET_ORIGINAL IsNot Nothing Then

            Dim dataViewFiltrado = ME_DATASET_ORIGINAL.Tables(0).DefaultView
            dataViewFiltrado.RowFilter = ""
            Dim objDT = dataViewFiltrado.ToTable()

            list_llenado.DataSource = Nothing
            list_llenado.Items.Clear()
            list_llenado.ValueMember = ME_COLUMNA_ID
            list_llenado.DisplayMember = ME_COLUMNA_DESCRIPCION
            list_llenado.DataSource = objDT

        End If
    End Sub
    Private Sub combosax_Leave(sender As Object, e As EventArgs) Handles MyBase.Leave
        If Not IS_VALOR_SELECTED Then
            btnLimpiar_Click(btnLimpiar, Nothing)
        ElseIf (listfiltrado.Items(listfiltrado.SelectedIndex).Row.Item(ME_COLUMNA_DESCRIPCION).ToString) <> txtBuscador.Text Then
            btnLimpiar_Click(btnLimpiar, Nothing)
        End If
    End Sub

    Private Sub filtrarListDesplegado()
        Dim filtroWhere As String = ""
        If Me.txtBuscador.Text <> "" Then
            filtroWhere = ME_COLUMNA_DESCRIPCION & "  like '%" & CStr(Me.txtBuscador.Text) & "%'"
        End If
        If ME_DATASET_ORIGINAL IsNot Nothing Then

            Dim dataViewFiltrado = ME_DATASET_ORIGINAL.Tables(0).DefaultView
            dataViewFiltrado.RowFilter = filtroWhere
            Dim objDT = dataViewFiltrado.ToTable()

            list_llenado.DataSource = Nothing
            list_llenado.Items.Clear()
            list_llenado.ValueMember = ME_COLUMNA_ID
            list_llenado.DisplayMember = ME_COLUMNA_DESCRIPCION
            list_llenado.DataSource = objDT

        End If
    End Sub


    Public Property [ReadOnly]() As Boolean
        Get
            [ReadOnly] = ReadOnlyi
        End Get

        Set(ByVal value As Boolean)
            ReadOnlyi = value
        End Set
    End Property

    <System.ComponentModel.Description("Esta función limita la búsqueda  a 3 caracteres para evitar la carga a la base de datos")>
    Public Property Limitar() As Boolean
        Get
            Limitar = LIMITAR_REGISTROS
        End Get
        Set(ByVal value As Boolean)
            LIMITAR_REGISTROS = value
        End Set
    End Property

    Public ReadOnly Property OBTENERLISTLLENADO() As System.Data.DataTable
        Get
            Return listfiltrado.DataSource
        End Get

    End Property
#Region "Propiedades descontinuadas"
    Public Property procedure() As System.Data.DataTable
        Get
        End Get
        Set(ByVal value As System.Data.DataTable)
        End Set
    End Property
    Public Property Negritas As Boolean
        Get
        End Get
        Set(ByVal value As Boolean)

        End Set
    End Property

    Public Property amarillo() As Boolean
        Get
        End Get
        Set(ByVal value As Boolean)

        End Set
    End Property

    Public Property gris() As Boolean
        Get
        End Get
        Set(ByVal value As Boolean)

        End Set
    End Property

    Public Property ColorAtras As System.Drawing.Color
        Get
        End Get
        Set(ByVal value As System.Drawing.Color)
        End Set
    End Property

    Public Property Letra As System.Drawing.Font
        Get
        End Get
        Set(ByVal value As System.Drawing.Font)
        End Set
    End Property

    Public Property TODOSS() As Boolean
        Get
            'TODOSS = TODOS
        End Get
        Set(ByVal value As Boolean)
            'TODOS = value
        End Set
    End Property
    Public Property MensajeAgua() As String
        Get
            'TODOSS = TODOS
        End Get
        Set(ByVal value As String)
            'TODOS = value
        End Set
    End Property



    Public Property mostrarMensaje() As Boolean
        Get
            Return ME_MOSTRAR_MENSAJE
        End Get

        Set(ByVal value As Boolean)
            ME_MOSTRAR_MENSAJE = value

        End Set
    End Property

    Public Property Ancho() As String
        Get
            'TODOSS = TODOS
        End Get
        Set(ByVal value As String)
            'TODOS = value
        End Set
    End Property



#End Region
#Region "procedimientos descontinuados"

    Public Sub lenar_combo_real(dt As DataTable, cve_column As String, descripcion As String)
        Dim ds As New DataSet
        ds = dt.DataSet
        With list_llenado
            .DataSource = Nothing
            .Items.Clear()
            .ValueMember = ds.Tables(0).Columns(cve_column).ColumnName
            .DataSource = ds.Tables(0)
            .DisplayMember = ds.Tables(0).Columns(descripcion).ColumnName

        End With
        ME_DATASET_ORIGINAL = ds
        ME_TABLA_DEFAULT = ME_DATASET_ORIGINAL.Tables(0)
        ME_COLUMNA_ID = cve_column
        ME_COLUMNA_DESCRIPCION = descripcion
        Dim max As Integer = 0
        For Each row As DataRow In Me.DataSource.Tables(0).Rows

            If max < Len(row(ME_COLUMNA_DESCRIPCION).ToString) Then
                max = Len(row(ME_COLUMNA_DESCRIPCION).ToString)
                If max * 8 > Me.Width Then
                    list_llenado.Width = max * 8
                    list_llenado.Dock = DockStyle.None
                    list_llenado.Top = 0
                Else
                    list_llenado.Dock = DockStyle.Fill
                End If
            End If
        Next
        RaiseEvent SelectedIndexChanged(Me, Nothing)

    End Sub
#End Region
    Public ReadOnly Property ObtenerDescripcion(sColumnaName As String) As Object


        Get
            Try
                If Me.SelectedIndex <> -1 Then
                    Return Me.listfiltrado.DataSource.defaultview.table.Rows.Item(Me.SelectedIndex).Item(sColumnaName)
                Else
                    Dim DT As DataTable = Me.listfiltrado.DataSource.defaultview.table
                    Return fDevTypeDefault(DT, sColumnaName)
                End If
                Return ""
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try



        End Get

    End Property
    Public ReadOnly Property ObtenerRow(sColumnaName As String) As DataRow

        Get
            Dim meRow As DataRow = Nothing
            Try
                If Me.SelectedIndex <> -1 Then
                    If Me.listfiltrado.DataSource.defaultview.table.Rows.count() = 1 Then
                        meRow = Me.listfiltrado.DataSource.defaultview.table.Rows(0)
                    End If
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Return meRow
        End Get

    End Property
    Function fDevTypeDefault(ByVal dt As DataTable, sColumnaName As String) As Object
        Dim C = dt.Columns(sColumnaName).DataType
        Dim x As Object
        Select Case C.Name
            Case "Boolean"
                x = False
            Case "Integer", "UShort", "ULong", "Int32", "Int16"
                x = 0
            Case "Byte"
                x = 0
            Case "DateTime "
                x = Now.Date


        End Select
    End Function

    Private Sub btnDesplegar_Click(sender As Object, e As EventArgs) Handles btnDesplegar.Click

        If Me.ME_DATASET_ORIGINAL IsNot Nothing Then
            limpiarFiltroDelList()
            Mostrar_lista(False)
            ToolTip1.Active = True
        End If

    End Sub

    Private Sub btnDesplegar_MouseClick(sender As Object, e As MouseEventArgs) Handles btnDesplegar.MouseClick
        If e.Button = MouseButtons.Right Then
            Dim txtProcedure As TextBox = Nothing

            Dim popProcedure As New UserPopup()
            AddHandler popProcedure.Leave, AddressOf popProcedure_Leave
            popProcedure.Height = 25

            Dim pnl As Panel = New Panel
            pnl.Dock = DockStyle.Fill
            pnl.AutoScroll = True
            pnl.BackColor = Drawing.Color.FromArgb(245, 245, 245)
            pnl.Padding = New Padding(1)

            Dim lblActualizar As New Label()
            lblActualizar.Text = "Actualizar"
            lblActualizar.TextAlign = ContentAlignment.MiddleLeft
            lblActualizar.Height = 24
            lblActualizar.Margin = New Padding(0)
            lblActualizar.Font = New System.Drawing.Font("default", 13.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            AddHandler lblActualizar.Click, AddressOf actualizarCombo
            AddHandler lblActualizar.MouseHover, AddressOf LabelActualizar_MouseHover
            AddHandler lblActualizar.MouseLeave, AddressOf LabelActualizar_MouseLeave
            pnl.Controls.Add(lblActualizar)
            lblActualizar.Dock = DockStyle.Top
            lblActualizar.BringToFront()

            If Wisej.Web.Application.Session("Cve_Operador") <> Nothing Then
                If Wisej.Web.Application.Session("Cve_Operador").ToString.ToUpper = "NA" Then
                    txtProcedure = New TextBox()
                    txtProcedure.Text = ME_PROCEDURE_DATASET
                    txtProcedure.Height = 24
                    txtProcedure.Width = 300
                    pnl.Controls.Add(txtProcedure)
                    txtProcedure.Dock = DockStyle.Top
                    txtProcedure.BringToFront()
                End If
            End If

            popProcedure.CssStyle = "border-style:solid; border-Width: 1px;border-color: #bdbfbf;"
            popProcedure.AutoSize = True
            popProcedure.AutoSizeMode = AutoSizeMode.GrowAndShrink
            popProcedure.AutoScroll = True
            popProcedure.Controls.Add(pnl)
            popProcedure.ShowPopup(btnDesplegar)
            If txtProcedure IsNot Nothing Then
                popProcedure.Height = 50
                txtProcedure.Focus()
                txtProcedure.SelectAll()
            End If
        End If
    End Sub


    Private Sub popProcedure_Leave(sender As UserPopup, e As EventArgs)
        sender.Dispose()
    End Sub

    Private Sub actualizarCombo(sender As Label, e As EventArgs)
        Me.btnLimpiar_Click(btnLimpiar, Nothing)
        Try
            If ME_COLUMNA_ID <> Nothing And ME_COLUMNA_DESCRIPCION <> Nothing And ME_PROCEDURE_DATASET <>
            Nothing And ME_CONEXION <> Nothing And ME_DATASET_ORIGINAL IsNot Nothing Then


                Dim myDA As Data.SqlClient.SqlDataAdapter = New Data.SqlClient.SqlDataAdapter(ME_PROCEDURE_DATASET, ME_CONEXION)
                myDA.SelectCommand.CommandType = CommandType.Text
                ME_DATASET_ORIGINAL = New DataSet
                myDA.Fill(ME_DATASET_ORIGINAL, "SQLX")
                ME_TABLA_DEFAULT = ME_DATASET_ORIGINAL.Tables(0)

                ME_DATASET_FILTRADO = New DataSet
                ME_DATASET_FILTRADO = ME_DATASET_ORIGINAL.Copy()

                list_llenado.DataSource = Nothing
                list_llenado.Items.Clear()

                list_llenado.ValueMember = ME_DATASET_ORIGINAL.Tables(0).Columns(ME_COLUMNA_ID).ColumnName
                list_llenado.DataSource = ME_DATASET_ORIGINAL.Tables(0)
                list_llenado.DisplayMember = ME_DATASET_ORIGINAL.Tables(0).Columns(ME_COLUMNA_DESCRIPCION).ColumnName

                listfiltrado.DataSource = Nothing
                listfiltrado.Items.Clear()
                listfiltrado.ValueMember = ME_DATASET_FILTRADO.Tables(0).Columns(ME_COLUMNA_ID).ColumnName
                listfiltrado.DataSource = ME_DATASET_FILTRADO.Tables(0)
                listfiltrado.DisplayMember = ME_DATASET_FILTRADO.Tables(0).Columns(ME_COLUMNA_DESCRIPCION).ColumnName

                txtBuscador.Focus()

                If sender IsNot Nothing Then
                    DirectCast(sender.Parent.Parent, UserPopup).Dispose()
                End If
            End If
        Catch ex As NullReferenceException
            MessageBox.Show("Columna Invalida " & Space(1) & ME_COLUMNA_DESCRIPCION & "o " & ME_COLUMNA_ID & " Del combo " & Me.Name.ToString, "combosax_mV5", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

    Private Sub list_llenado_KeyPress(sender As Object, e As KeyPressEventArgs) Handles list_llenado.KeyPress
        If e.KeyChar = Convert.ToChar(Keys.Escape) Or e.KeyChar = Convert.ToChar(Keys.Tab) Then
            txtBuscador.Focus()
        ElseIf e.KeyChar = Convert.ToChar(Keys.Enter) Then
            If list_llenado.SelectedIndex <> -1 Then
                txtBuscador.Text = list_llenado.Items(list_llenado.SelectedIndex).Row.Item(ME_COLUMNA_DESCRIPCION).ToString
                ToolTip1.SetToolTip(txtBuscador, txtBuscador.Text)
                listfiltrado.SelectedValue = list_llenado.SelectedValue
                txtBuscador.Tag = list_llenado.SelectedValue
                Me.btnLimpiar.Visible = True
                userPop.Close()
                txtBuscador.Focus()
                txtBuscador.SelectionStart = txtBuscador.Text.Length
                IS_VALOR_SELECTED = True
                RaiseEvent SelectedIndexChanged(Me, Nothing)
            End If
        End If
    End Sub

    Private Sub txtBuscador_Leave(sender As Object, e As EventArgs) Handles txtBuscador.Leave
        If userPop IsNot Nothing Then
            userPop.Close()
        End If
    End Sub

    Private Sub btn_MouseHover(sender As PictureBox, e As EventArgs) Handles btnDesplegar.MouseHover, btnLimpiar.MouseHover
        sender.BackColor = Color.FromArgb(213, 234, 255)

    End Sub

    Private Sub btn_MouseLeave(sender As PictureBox, e As EventArgs) Handles btnDesplegar.MouseLeave, btnLimpiar.MouseLeave
        sender.BackColor = Color.FromArgb(241, 241, 241)

    End Sub

    'Private Sub combosax_EnabledChanged(sender As combosax, e As EventArgs) Handles Me.EnabledChanged, MyBase.EnabledChanged
    '    EnabledChilds(Me, sender.Enabled)
    'End Sub

    Public Overloads Function Focus() As Boolean
        Me.txtBuscador.Focus()
        Return Me.txtBuscador.Focus

    End Function
    Public Overloads Property Enabled() As Boolean
        Get
            Return MyBase.Enabled
        End Get

        Set(ByVal value As Boolean)
            MyBase.Enabled = value
            ActicarDesactivar(value)
        End Set


    End Property
    Private Sub ActicarDesactivar(enable As Boolean)
        Me.txtBuscador.Enabled = enable
        Me.btnDesplegar.Enabled = enable
        Me.btnLimpiar.Enabled = enable
        If userPop IsNot Nothing Then Me.userPop.Enabled = enable
        Me.list_llenado.Enabled = enable
        Me.listfiltrado.Enabled = enable
        If Enabled Then
            Me.txtBuscador.BackColor = System.Drawing.Color.FromName("@window")
            Me.btnDesplegar.BackColor = Color.FromArgb(241, 241, 241)
            Me.btnLimpiar.BackColor = Color.FromArgb(241, 241, 241)
        Else
            Me.txtBuscador.BackColor = Color.FromArgb(218, 218, 218)
            Me.btnDesplegar.BackColor = Color.FromArgb(218, 218, 218)
            Me.btnLimpiar.BackColor = Color.FromArgb(218, 218, 218)
        End If
    End Sub


    Private Sub LabelActualizar_MouseHover(sender As Label, e As EventArgs)
        sender.BackColor = Color.FromArgb(213, 234, 255)

    End Sub
    Private Sub LabelActualizar_MouseLeave(sender As Object, e As EventArgs)
        sender.BackColor = Color.Transparent

    End Sub

    Public Sub Actualizar()
        actualizarCombo(Nothing, Nothing)
    End Sub
End Class
