Imports System.Data
Imports System.Drawing
Imports Wisej.Web



Public Class Combosax_B
    Dim sparametros As String
    Dim scConnect As String
    Dim Alto As Double
    Dim TEXTO_GUARDADO As String
    Dim sidt As String
    Dim sDescripciont As String
    Dim myDS As New DataSet
    Dim myDSelect As New DataSet
    Dim AltoOriginalPadre As Integer = False
    Dim bPASA As Boolean = False
    Dim CONTADOR As Integer = 1
    Dim Selectindexx As Integer = 1
    Dim TODOS As Boolean = False
    Dim LIMITAR_REGISTROS As Boolean = False
    Dim ReadOnlyi As Boolean = False
    Dim mostrar_Mensaje As Boolean = True
    Dim LocationVar As Point
    Dim f As New Form
    Dim a As New UserPopup
    Dim z As New Control
    Dim vAncho As Integer
    Private Const maxGarbage As Integer = 1000
    Private defaultTabla As New DataTable
    Dim Num_Registros As Integer = 0
    Dim mostrar As Boolean = True
    Dim water As String = Nothing
    Dim _MensajeError As String = Nothing
    Dim m As Boolean = True

    Public Event SelectedIndexChanged(ByVal sender As System.Object, ByVal e As EventArgs)

    Public Sub Clear(Optional cleanDS As Boolean = True)
        SelectedIndex = -1

        Txtbuscador.Tag = Nothing
        Num_Registros = 0

        If cleanDS Then
            If (Me.myDS IsNot Nothing) Then
                If (Me.myDS.Tables.Count > 0) Then
                    If (Me.myDS.Tables(0) IsNot Nothing) Then
                        Me.myDS.Tables(0).Clear()
                    End If
                End If
            End If
        End If

        If cleanDS Then '() agregado Oscar :v
            If (Me.myDSelect IsNot Nothing) Then
                If (Me.myDSelect.Tables.Count > 0) Then
                    If (Me.myDSelect.Tables(0) IsNot Nothing) Then
                        Me.myDSelect.Tables(0).Clear()
                    End If
                End If
            End If
        End If
    End Sub
    Private Sub TXTBUSQUEDA_TextChanged(objSender As Object, objArgs As KeyEventArgs)
        If ReadOnlyi = False Then
            Try
                If objArgs.KeyValue = 40 Then
                    list_llenado.Select()

                    Exit Sub

                End If

                If sparametros Is Nothing Then

                    Exit Sub

                End If

                If LIMITAR_REGISTROS = True Then
                    TODOS = False
                    If Trim(CStr(objSender.Text)).Length <= 2 Then

                        Exit Sub
                    End If
                End If

                Dim swhere As String
                If TODOS <> True Then

                    If objSender.Text <> Nothing Then
                        swhere = sDescripciont & "  like '%" & CStr(objSender.Text) & "%'"

                    End If
                End If

                list_llenado.DataSource.DefaultView.RowFilter = swhere
                If listfiltrado.Items.Count > 1 Then
                    If list_llenado.Items.Count = 1 Then
                        SelectedIndex = 0
                        'listfiltrado.SelectedValue = list_llenado.SelectedValue
                        RaiseEvent SelectedIndexChanged(Me, objArgs)

                        a.Close()
                    End If
                End If



            Catch ex As NullReferenceException
                MessageBox.Show("Error del combo " & Me.Name.ToString, "combosax_mV5", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        Else
            a.Close()
        End If


    End Sub

    Sub llenar_lis_nuevo(ByVal sId As String, ByVal sDescripcion As String, ByVal parametros As String, ByVal cConnect As String)
        Try
            sparametros = parametros
            sidt = sId
            sDescripciont = sDescripcion
            bPASA = Me.Height
            scConnect = cConnect

            Dim myDA As Data.SqlClient.SqlDataAdapter = New Data.SqlClient.SqlDataAdapter(parametros, cConnect)
            myDA.SelectCommand.CommandType = CommandType.Text
            myDS = New DataSet
            myDA.Fill(myDS, "SQLX")
            defaultTabla = myDS.Tables(0)

            With list_llenado
                .DataSource = Nothing
                .Items.Clear()
                .ValueMember = myDS.Tables(0).Columns(sId).ColumnName
                .DataSource = myDS.Tables(0)
                .DisplayMember = myDS.Tables(0).Columns(sDescripcion).ColumnName
                sidt = sId
                sDescripciont = sDescripcion
            End With



            Dim myDAselect As Data.SqlClient.SqlDataAdapter = New Data.SqlClient.SqlDataAdapter(parametros, cConnect)
            myDAselect.SelectCommand.CommandType = CommandType.Text
            myDSelect = New DataSet
            myDAselect.Fill(myDSelect, "SQLX")
            defaultTabla = myDSelect.Tables(0)

            With listfiltrado

                .DataSource = Nothing
                .Items.Clear()
                .ValueMember = myDSelect.Tables(0).Columns(sId).ColumnName
                .DataSource = myDSelect.Tables(0)
                .DisplayMember = myDSelect.Tables(0).Columns(sDescripcion).ColumnName

            End With




        Catch ex As NullReferenceException
            MessageBox.Show("Columna Invalida " & Space(1) & sDescripcion & "o " & sId & " Del combo " & Me.Name.ToString, "combosax_mV5", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub



    Private Sub Combosax_B_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        a.Tag = False
        list_llenado.Font = Me.Font
        Txtbuscador.Clear()
        Txtbuscador.Watermark = "Seleccione una opción..."
        Txtbuscador.Font = Me.Font

        list_llenado.Enabled = Me.Enabled

        Txtbuscador.Enabled = Me.Enabled
        a.Width = Me.Width
        Timer1.Interval = 5000
    End Sub



    Private Sub list_llenado_Click(sender As Object, e As EventArgs) Handles list_llenado.Click
        If ReadOnlyi = False Then
            If list_llenado.SelectedIndex <> -1 Then
                'Txtbuscador.Watermark = "Buscando"

                Txtbuscador.Text = list_llenado.Items(list_llenado.SelectedIndex).Row.Item(sDescripciont).ToString
                ToolTip1.SetToolTip(Txtbuscador, Txtbuscador.Text)



                listfiltrado.SelectedValue = list_llenado.SelectedValue


                Txtbuscador.Tag = list_llenado.SelectedValue


                RaiseEvent SelectedIndexChanged(Me, e)
                a.Close()
                mostrar = True


            End If
        Else
            a.Close()
        End If



    End Sub


    Private Sub BtnActivador_Click_1(sender As Object, e As EventArgs) Handles BtnActivador.Click
        If mostrar Then
            Mostrar_lista()
            mostrar = False
            ToolTip1.Active = True
        Else
            a.Close()
            mostrar = True
        End If

    End Sub

    Private Sub PictureBox1_Click_1(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Txtbuscador.ReadOnly = False
        a.Close()
        Txtbuscador.Text = Nothing
        Txtbuscador.Tag = Nothing
        SelectedIndex = -1
        If list_llenado.Items.Count > 0 Then
            RaiseEvent SelectedIndexChanged(Me, e)
        End If

        ToolTip1.SetToolTip(Txtbuscador, "Seleccione una opción..")
        mostrar = True
    End Sub


    Public Sub Mostrar_lista()
        AddHandler Txtbuscador.KeyUp, AddressOf TXTBUSQUEDA_TextChanged
        If DataSource Is Nothing Then
            Exit Sub
        End If
        If list_llenado.Items.Count = 0 Then
            Mensaje_Error()
            Exit Sub
        End If
        list_llenado.DataSource.DefaultView.RowFilter = Nothing

        If list_llenado.Items.Count = 1 Then
            a.Height = 21 + 26
            a.Width = TableLayoutPanel1.Width
        ElseIf list_llenado.Items.Count = 2 Then
            a.Height = 21 + 43
            a.Width = TableLayoutPanel1.Width
        ElseIf list_llenado.Items.Count = 3 Then
            a.Height = 21 + 64
            a.Width = TableLayoutPanel1.Width
        ElseIf list_llenado.Items.Count = 4 Then
            a.Height = 21 + 85
            a.Width = TableLayoutPanel1.Width
        Else
            a.Height = 200
            a.Width = TableLayoutPanel1.Width
        End If
        a.Controls.Clear()
        a.Controls.Add(list_llenado)
        list_llenado.Dock = DockStyle.Fill
        list_llenado.BringToFront()
        list_llenado.TabIndex = 1
        list_llenado.AutoSize = True
        a.ShowPopup(Me)
    End Sub


    'Private Sub Txtbuscador_KeyPress(sender As Object, e As KeyPressEventArgs) Handles Txtbuscador.KeyPress
    '    If Txtbuscador.ReadOnly = False Then
    '        Mostrar_lista()
    '    End If

    'End Sub

    Private Sub list_llenado_KeyDown(sender As Object, e As KeyEventArgs) Handles list_llenado.KeyDown

        Try
            If e.KeyCode = Keys.Enter Then

                If list_llenado.SelectedIndex <> -1 Then

                    Txtbuscador.Text = list_llenado.Items(list_llenado.SelectedIndex).Row.Item(sDescripciont).ToString
                    ToolTip1.SetToolTip(Txtbuscador, Txtbuscador.Text)



                    listfiltrado.SelectedValue = list_llenado.SelectedValue


                    Txtbuscador.Tag = list_llenado.SelectedValue
                    a.Close()

                End If

            ElseIf e.KeyCode = Keys.Escape Then

                Txtbuscador.Text = Nothing

                a.Close()


            ElseIf e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up Then

                list_llenado.Select()

            End If

        Catch ex As NullReferenceException

        End Try


    End Sub

    Private Sub Txtbuscador_KeyDown(sender As Object, e As KeyEventArgs) Handles Txtbuscador.KeyDown
        Try
            If e.KeyCode = Keys.Enter Then


                If list_llenado.SelectedIndex <> -1 Then

                    Txtbuscador.Text = list_llenado.Items(list_llenado.SelectedIndex).Row.Item(sDescripciont).ToString
                    ToolTip1.SetToolTip(Txtbuscador, Txtbuscador.Text)



                    listfiltrado.SelectedValue = list_llenado.SelectedValue

                    SelectedValue = listfiltrado.SelectedValue
                    Txtbuscador.Tag = list_llenado.SelectedValue
                    a.Close()
                End If

            ElseIf e.KeyCode = Keys.Escape Then
                If list_llenado.SelectedIndex = -1 Then
                    Txtbuscador.Text = Nothing
                End If


                a.Close()


            ElseIf e.KeyCode = Keys.Down Or e.KeyCode = Keys.Up Then
                list_llenado.Select()
            End If


            If e.KeyCode <> Keys.Tab And e.KeyCode = Keys.Enter Then
                Mostrar_lista()
            End If


        Catch ex As NullReferenceException
            MessageBox.Show("Error. " & ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try




    End Sub

    Public Sub filtrarCombo(where As String, Optional concatenarFiltros As Boolean = True)
        Dim dv As DataView = Nothing
        If concatenarFiltros Then
            dv = myDSelect.Tables(0).DefaultView
        Else
            dv = defaultTabla.DefaultView
        End If
        dv.RowFilter = where
        Dim ndt As DataTable = dv.ToTable()
        myDSelect.Tables.RemoveAt(0)
        myDSelect.Tables.Add(ndt)
        With listfiltrado
            .DataSource = Nothing
            .Items.Clear()
            .ValueMember = myDSelect.Tables(0).Columns(sidt).ColumnName
            .DataSource = myDSelect.Tables(0)
            .DisplayMember = myDSelect.Tables(0).Columns(sDescripciont).ColumnName
        End With


        Dim dv2 As DataView = Nothing
        If concatenarFiltros Then
            dv2 = myDS.Tables(0).DefaultView
        Else
            dv2 = defaultTabla.DefaultView
        End If
        dv2.RowFilter = where
        Dim ndt2 As DataTable = dv2.ToTable()
        myDS.Tables.RemoveAt(0)
        myDS.Tables.Add(ndt2)
        With listfiltrado
            .DataSource = Nothing
            .Items.Clear()
            .ValueMember = myDS.Tables(0).Columns(sidt).ColumnName
            .DataSource = myDS.Tables(0)
            .DisplayMember = myDS.Tables(0).Columns(sDescripciont).ColumnName
        End With


    End Sub
    Public Sub limpiarFiltro(where As String)
        myDS.Tables.RemoveAt(0)
        myDS.Tables.Add(defaultTabla)
        With listfiltrado
            .DataSource = Nothing
            .Items.Clear()
            .ValueMember = myDS.Tables(0).Columns(sidt).ColumnName
            .DataSource = myDS.Tables(0)
            .DisplayMember = myDS.Tables(0).Columns(sDescripciont).ColumnName
        End With


        With list_llenado
            .DataSource = Nothing
            .Items.Clear()
            .ValueMember = myDS.Tables(0).Columns(sidt).ColumnName
            .DataSource = myDS.Tables(0)
            .DisplayMember = myDS.Tables(0).Columns(sDescripciont).ColumnName
        End With


        myDSelect.Tables.RemoveAt(0)
        myDSelect.Tables.Add(defaultTabla)
        With listfiltrado
            .DataSource = Nothing
            .Items.Clear()
            .ValueMember = myDSelect.Tables(0).Columns(sidt).ColumnName
            .DataSource = myDSelect.Tables(0)
            .DisplayMember = myDSelect.Tables(0).Columns(sDescripciont).ColumnName
        End With


        With list_llenado
            .DataSource = Nothing
            .Items.Clear()
            .ValueMember = myDSelect.Tables(0).Columns(sidt).ColumnName
            .DataSource = myDSelect.Tables(0)
            .DisplayMember = myDSelect.Tables(0).Columns(sDescripciont).ColumnName
        End With
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
            DataSource = myDS
        End Get
        Set(ByVal value As System.Data.DataSet)

            myDS = value
        End Set
    End Property

    Public Property DataSourceSelect() As System.Data.DataSet
        Get
            DataSource = myDSelect
        End Get
        Set(ByVal value As System.Data.DataSet)

            myDSelect = value
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


        End Get

        Set(value As String)
            If value <> Nothing Then
                Txtbuscador.Watermark = value
            End If
        End Set
    End Property


    Public Property SelectedIndex() As Integer
        Get
            Dim I As Integer
            If Txtbuscador.Text = Nothing Then
                I = -1

            Else
                Txtbuscador.ReadOnly = True

                I = listfiltrado.SelectedIndex


            End If
            SelectedIndex = I

        End Get


        Set(ByVal value As Integer)
            Try

                If value <> -1 Then

                    list_llenado.SelectedIndex = value
                    Txtbuscador.Text = list_llenado.Items(list_llenado.SelectedIndex).Row.Item(sDescripciont).ToString

                    ToolTip1.SetToolTip(Txtbuscador, Txtbuscador.Text)
                    listfiltrado.SelectedValue = list_llenado.SelectedValue

                    'listfiltrado.Tag = list_llenado.SelectedValue
                    Txtbuscador.Tag = list_llenado.SelectedValue
                    'list_llenado.SelectedValue = list_llenado.SelectedValue


                Else
                    ToolTip1.SetToolTip(Txtbuscador, "")
                    Txtbuscador.Text = Nothing
                    Txtbuscador.Tag = Nothing
                    listfiltrado.SelectedIndex = -1
                    'list_llenado.SelectedValue = -1
                    'list_llenado.SelectedValue = Nothing
                    'listfiltrado.SelectedValue = Nothing


                    If listfiltrado.Items.Count > 0 Then


                        a.Close()

                    End If
                End If

                'RaiseEvent SelectedIndexChanged(Me, Nothing)


            Catch ex As Exception
                list_llenado.SelectedIndex = -1
                MessageBox.Show("Error: Argumento Invalido: " & " Nombre del parametro SelectedIndex = " & value & ".", "Cargar listas", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End Set
    End Property



    Public Property SelectedValue() As String
        Get

            If Txtbuscador.Text <> Nothing Then

                SelectedValue = listfiltrado.SelectedValue
            Else
                SelectedValue = Nothing
                listfiltrado.SelectedIndex = -1

            End If


        End Get
        Set(ByVal value As String)

            Try

                If value <> Nothing Then



                    ToolTip1.SetToolTip(Txtbuscador, value)
                    Txtbuscador.Tag = value
                    listfiltrado.SelectedValue = value

                    Txtbuscador.Text = listfiltrado.SelectedItem.Row.Item(sDescripciont).ToString

                Else
                    SelectedIndex = -1
                End If
                RaiseEvent SelectedIndexChanged(Me, Nothing)

            Catch ex As NullReferenceException
                If mostrar_Mensaje Then
                    MessageBox.Show("Error Del combo " & Me.Name.ToString & " al querer asignar el valor " & value & " el cual no existe", "combosax_mV5", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                Else
                    SelectedIndex = -1
                End If
            End Try
        End Set
    End Property

    Public Property SelectedItem() As String
        Get
            If Txtbuscador.Text <> Nothing Then
                SelectedItem = Txtbuscador.Text
            Else
                SelectedItem = ""
            End If
        End Get
        Set(ByVal value As String)
            If value <> Nothing Then
                Txtbuscador.Text = value
                If LIMITAR_REGISTROS = True Then
                    TXTBUSQUEDA_TextChanged(1, Nothing)
                Else
                    Dim index As Integer = listfiltrado.FindString(Txtbuscador.Text)
                    If index <> -1 Then
                        listfiltrado.SetSelected(0, False)
                        listfiltrado.SetSelected(index, True)

                    Else
                        listfiltrado.SelectedIndex = -1

                    End If
                End If



                ToolTip1.SetToolTip(Txtbuscador, value)
            Else

            End If
        End Set
    End Property

    Public Property [ReadOnly]() As Boolean
        Get

            [ReadOnly] = ReadOnlyi

        End Get

        Set(ByVal value As Boolean)

            ReadOnlyi = value
            'If value = True Then
            '    Txtbuscador.ReadOnly = True
            'End If
            'If value <> False Then
            '    listfiltrado.SelectedIndex = listfiltrado.SelectedIndex
            'End If

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



    Public Property OBTENERLISTLLENADO() As System.Data.DataTable
        Get
            OBTENERLISTLLENADO = listfiltrado.DataSource
        End Get
        Set(ByVal value As System.Data.DataTable)
        End Set
    End Property




    Public Property procedure() As System.Data.DataTable
        Get
        End Get
        Set(ByVal value As System.Data.DataTable)
        End Set
    End Property

    Private Sub combosax_m_EnabledChanged(sender As Object, e As EventArgs) Handles MyBase.EnabledChanged

        Txtbuscador.Enabled = Me.Enabled
        list_llenado.Enabled = Me.Enabled



    End Sub

    Public Sub RemoveItem(ByVal i As Integer)

        If i <> -1 Then
            list_llenado.Items.Remove(i)
            listfiltrado.Items.Remove(i)
        End If
    End Sub



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
            'TODOSS = TODOS
        End Get
        Set(ByVal value As Boolean)
            'TODOS = value
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

    Public Property MensajeError() As String
        Get
            Return _MensajeError
        End Get
        Set(value As String)
            _MensajeError = value

        End Set
    End Property


    Sub Mensaje_Error()
        If MensajeError <> Nothing Then
            If m Then
                Timer1.Start()
                AlertBox.Show(MensajeError, MessageBoxIcon.Error, MessageBoxButtons.AbortRetryIgnore, Drawing.ContentAlignment.TopCenter)
                m = False
            End If
        End If


    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Stop()
        m = True

    End Sub


    Public ReadOnly Property ObtenerDescripcion(sColumnaName As String) As Object


        Get
            Try
                If Me.SelectedIndex <> -1 Then
                    Return Me.listfiltrado.DataSource.defaultview.table.Rows.Item(Me.SelectedIndex).Item(sColumnaName)
                Else
                    Dim DT As DataTable = Me.listfiltrado.DataSource.defaultview.table
                    Return fDevTypeDefault(DT, sColumnaName)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try



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


End Class
