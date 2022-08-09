Imports System
Imports Wisej.Web
Imports System.Drawing
Imports System.Data
Imports System.Data.SqlClient

Public Class FiltroGrillaCheck
    Private ExcelIcon As String = "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"
    Private closeIcon As String = "iVBORw0KGgoAAAANSUhEUgAAABQAAAAUCAYAAACNiR0NAAAABmJLR0QA/wD/AP+gvaeTAAABcElEQVQ4jc2SP0/CUBTFz62YQJwYwMUwu2po4kewTcQBg0ak/WwFa4SEwT8pfgOHoo7ubsLAosEB33Ep0ELbIIPxTu/d987vnvPygP9eEt6UTeuYxO6vAJTX/oNzuwQsH9oVCG/Wc8WK32vdAYA2b3NvHRgAkLI/Xc+BWjS+AKMEvRJgEOmEtNrS9QCmBtltAc4ATEJHEwHO1SC7kzQwFkggL4Vx1e812yJSD6ATEan7vWZbCuMqgXycNpMQCxBp6aatfM/p6KYNAAjWNZKtJFkyEMiQvNINe9P3HBcAyoZ1QtJN08VGDpcScqG1uF/Z4URE6v0gJjCLrKW5THZINkJv5pJ0ddOu+Z7TEeAiyWnsFAFGapjr6oZ1SvJyeo+kqxuWbI3fup+50pBAcSUggbxW/HqP+RoZAtcfudIQQCE9sopGSPpnQUVhIW3oDeUlBZBaSsPTjBI+0I3GESEHAmysAiLwrQSPz17zfl0zf18/giaT9w/NuV8AAAAASUVORK5CYII="
    Private bMuestraExportDBF As Boolean = False
    Private I_EXCEPTIONS As Boolean = False
    Private I_TOOLTIP As New ToolTip
    Private I_TABLA_EXPRESIONES As DataTable = Nothing
    Private I_ETIQUETAS_BACKCOLOR As Color = Color.AliceBlue
    Private I_ETIQUETAS_BORDERCOLOR As Color = Color.FromArgb(153, 196, 218)
    Private I_FILTRAR_VACIOS As Boolean = False
    Private I_DISTANCIA_IZQ As Integer = 0
    Private I_MODO_COMPACTO As Boolean = 0
    Private I_COLUMNAS_OMITIR As String() = Nothing
    Public sFileNameExportDBF As String = "Export"
    '
    Private I_TABLA As DataTable = Nothing
    Private I_DATAGRIDVIEW As Wisej.Web.DataGridView = Nothing
    Private I_DATAList As Wisej.Web.ListView = Nothing
    Private I_BINDING_NAVIGATOR As BindingNavigator() = Nothing
    Private I_FRM_PARENT As Wisej.Web.Form = Nothing
    Private I_COUNT_BINDINGS As Integer = 0
    Private I_PARAMETROS_DATASET As String = ""
    '
    Public _TipoExport As TipoExportado
    Private _Dataview As DataView
    Private sProcedureName, WHERE_PUB As String
    '
    Private I_DEFAULT_ITEM_FILA As Object = "50"
    Public Event End_Buscar_Quit_Filtro(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Public CountFiltros As Integer
    Private Icono As Image

    Public Enum TipoExportado
        _Default = 0 'Como estaba 
        Directo = 1 'se exporta la tabla que se esta visualizando , se omite columnas no visibles
        Procedure = 2 'se exporta normal con el procedure y los parametros quue tiene la tabla
        Directo_All = 3 'se exporta la tabla con todas las columnas
        expResponseDt = 4 'Exporta el datatable, con los filtros que tiene al exportar los datos mediante el response.
    End Enum


    Private Sub FiltroGrillaCheck_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim imgBytes As Byte() = Nothing
        imgBytes = Convert.FromBase64String(ExcelIcon)
        Dim ms As New IO.MemoryStream(imgBytes)
        Dim icono = Image.FromStream(ms)
        BtnExportar.Image = icono

        imgBytes = Convert.FromBase64String(closeIcon)

        Dim memStr As New IO.MemoryStream(imgBytes)
        Me.Icono = Image.FromStream(memStr)


        Me.BackColor = Color.LightSteelBlue
        Try
            crearExpresiones()
            If cmbConcatenar.Items.Count > 0 Then cmbConcatenar.SelectedIndex = 0
            If cmbExpresion.Items.Count > 0 Then cmbExpresion.SelectedIndex = 0

            'dtpFecha.Value = Now
            I_TOOLTIP.SetToolTip(cmbBuscar, "Columna a filtrar")
            I_TOOLTIP.SetToolTip(cmbFiltro, "Valor para filtrar")
            I_TOOLTIP.SetToolTip(btnBuscar, "Filtrar")
            I_TOOLTIP.SetToolTip(btnLimpiar, "Quitar todos los filtros")

            meExporGridxVista = TipoExportado._Default

            btnBDFile.Visible = bMuestraExportDBF
            'btnElegirColumnas.Visible = bMuestraElegirColums
        Catch ex As NullReferenceException
            MessageBox.Show("" & ex.Message)
        End Try
    End Sub

#Region "propiedades"
    Public Property meModoCompacto() As Boolean
        Get
            Return I_MODO_COMPACTO
        End Get
        Set(ByVal compacto As Boolean)
            'I_MODO_COMPACTO = compacto
            'Me.PanelFilas.Visible = Not I_MODO_COMPACTO

            'If I_MODO_COMPACTO Then
            '    cmbBuscar.Width = 155  '40px
            '    cbm_filtro.Width = 115 '45px
            '    cmbConcatenar.Location = New Point(210, cmbConcatenar.Location.Y)
            '    cmbExpresion.Location = New Point(260, cmbExpresion.Location.Y)
            '    cbm_filtro.Location = New Point(315, cbm_filtro.Location.Y)
            '    dtpFecha.Location = New Point(315, dtpFecha.Location.Y)
            '    btnBuscar.Location = New Point(435, btnBuscar.Location.Y) '520
            '    btnLimpiar.Location = New Point(465, btnLimpiar.Location.Y) '550
            '    BtnExportar.Location = New Point(495, BtnExportar.Location.Y) '580

            'Else
            '    cmbBuscar.Width = 195  '40px
            '    cbm_filtro.Width = 160 '45px
            '    cmbConcatenar.Location = New Point(250, cmbConcatenar.Location.Y)
            '    cmbExpresion.Location = New Point(300, cmbExpresion.Location.Y)
            '    cbm_filtro.Location = New Point(355, cbm_filtro.Location.Y)
            '    dtpFecha.Location = New Point(355, dtpFecha.Location.Y)

            '    If cbm_filtro.Visible Then
            '        btnBuscar.Location = New Point(520, btnBuscar.Location.Y) '520
            '        btnLimpiar.Location = New Point(550, btnLimpiar.Location.Y) '550
            '        BtnExportar.Location = New Point(580, BtnExportar.Location.Y) '580
            '    Else
            '        btnBuscar.Location = New Point(475, btnBuscar.Location.Y) '520
            '        btnLimpiar.Location = New Point(505, btnLimpiar.Location.Y) '550
            '        BtnExportar.Location = New Point(535, BtnExportar.Location.Y) '580

            '    End If
            'End If
        End Set
    End Property
    Public ReadOnly Property mePanelFiltros() As Wisej.Web.Panel
        Get
            Return Me.panelFiltros
        End Get
    End Property
    Public ReadOnly Property mePanelEtiquetas() As Wisej.Web.FlowLayoutPanel
        Get
            Return Me.panelEtiquetas
        End Get
    End Property
    Public ReadOnly Property meLabelColumna() As Wisej.Web.Label
        Get
            Return Me.lblBuscar
        End Get
    End Property
    Public ReadOnly Property meBotonBuscar() As Wisej.Web.Button
        Get
            Return Me.btnBuscar
        End Get
    End Property
    Public ReadOnly Property meBotonLimpiar() As Wisej.Web.Button
        Get
            Return Me.btnLimpiar
        End Get
    End Property
    Public ReadOnly Property meComboColumnas() As Wisej.Web.ComboBox
        Get
            Return Me.cmbBuscar
        End Get
    End Property
    Public ReadOnly Property meTextBoxFiltro() As Wisej.Web.ComboBox
        Get
            Return Me.cmbFiltro
        End Get
    End Property
    Public ReadOnly Property meDataview() As DataView
        Get
            Return _Dataview
        End Get
    End Property
    Public Property meExporGridxVista() As TipoExportado
        Get
            Return _TipoExport
        End Get
        Set(value As TipoExportado)
            _TipoExport = value
        End Set
    End Property
    Public Property mostrarDBFileExport() As Boolean
        Get
            Return bMuestraExportDBF
        End Get
        Set(value As Boolean)
            bMuestraExportDBF = value
            btnBDFile.Visible = bMuestraExportDBF
        End Set
    End Property


    'Public Property mostrarElegirColumns() As Boolean
    '    Get
    '        Return bMuestraElegirColums
    '    End Get
    '    Set(value As Boolean)
    '        bMuestraElegirColums = value
    '        btnElegirColumnas.Visible = bMuestraElegirColums
    '    End Set
    'End Property

    Public Property meDatagrid() As Wisej.Web.DataGridView
        Get
            Return I_DATAGRIDVIEW
        End Get
        Set(grid As Wisej.Web.DataGridView)
            If I_DATAGRIDVIEW IsNot Nothing Then
                quitarFiltros()
            End If
            ReDim I_BINDING_NAVIGATOR(-1) : I_COUNT_BINDINGS = 0
            I_DATAGRIDVIEW = grid
            Try
                If I_DATAGRIDVIEW IsNot Nothing Then
                    I_FRM_PARENT = grid.FindForm()

                    'If cbIPP.Items.Contains(I_DATAGRIDVIEW.) Then
                    '    cbIPP.SelectedItem() = I_DATAGRIDVIEW.ItemsPerPage
                    'Else
                    '    I_DATAGRIDVIEW.ItemsPerPage = IIf(cbIPP.SelectedItem() = Nothing, "50", cbIPP.SelectedItem())
                    'End If
                    Dim binding As BindingSource = TryCast(Me.I_DATAGRIDVIEW.DataSource, BindingSource)
                    If binding IsNot Nothing Then
                        I_TABLA = binding.DataSource.Tables(binding.DataMember)
                    Else
                        If Me.I_DATAGRIDVIEW.DataSource IsNot Nothing Then
                            Dim typeAsignadoDT = Me.I_DATAGRIDVIEW.DataSource.GetType()
                            If Me.I_DATAGRIDVIEW.DataSource.GetType.ToString = "System.Data.DataView" Then
                                I_TABLA = TryCast(Me.I_DATAGRIDVIEW.DataSource, DataView).Table
                            ElseIf Me.I_DATAGRIDVIEW.DataSource.GetType.ToString = "System.Data.DataTable" Then
                                I_TABLA = TryCast(Me.I_DATAGRIDVIEW.DataSource, DataTable)
                            ElseIf typeAsignadoDT.BaseType.BaseType.FullName.ToString = "System.Data.DataTable" Then
                                I_TABLA = TryCast(Me.I_DATAGRIDVIEW.DataSource, DataTable)

                            End If
                            If I_TABLA Is Nothing Then
                                I_TABLA = TryCast(Me.I_DATAGRIDVIEW.DataSource.tables(0), DataTable)
                            End If
                        End If

                    End If
                Else
                    I_TABLA = Nothing
                End If

                If I_TABLA IsNot Nothing Then
                    llenarCombo()
                    If I_FRM_PARENT IsNot Nothing Then
                        asignarBindings(I_FRM_PARENT)
                    End If
                Else
                    Me.cmbBuscar.DataSource = Nothing
                End If


            Catch ex As Exception
                lanzarException(ex)
            End Try
        End Set
    End Property


    Public Property meDataList() As Wisej.Web.ListView
        Get
            Return I_DATAList
        End Get
        Set(grid As Wisej.Web.ListView)
            quitarFiltros()
            ReDim I_BINDING_NAVIGATOR(-1) : I_COUNT_BINDINGS = 0
            I_DATAList = grid
            Try
                If I_DATAList IsNot Nothing Then
                    I_FRM_PARENT = grid.FindForm()
                    Dim binding As BindingSource = TryCast(Me.I_DATAList.DataBindings(I_DATAList.DataBindings.Count - 1).DataSource, BindingSource)
                    If binding IsNot Nothing Then
                        I_TABLA = binding.DataSource.Tables(0)
                    Else

                        If Me.I_DATAList.DataBindings(I_DATAList.DataBindings.Count - 1).DataSource IsNot Nothing Then
                            If Me.I_DATAList.DataBindings(I_DATAList.DataBindings.Count - 1).DataSource.GetType.ToString = "System.Data.DataView" Then
                                I_TABLA = TryCast(Me.I_DATAList.DataBindings(I_DATAList.DataBindings.Count - 1).DataSource, DataView).Table
                            End If
                            If I_TABLA Is Nothing Then
                                I_TABLA = TryCast(Me.I_DATAList.DataBindings(I_DATAList.DataBindings.Count - 1).DataSource.tables(0), DataTable)
                            End If
                        End If

                    End If
                Else
                    I_TABLA = Nothing
                End If

                If I_TABLA IsNot Nothing Then
                    llenarCombo()
                    If I_FRM_PARENT IsNot Nothing Then
                        asignarBindings(I_FRM_PARENT)
                    End If
                End If
            Catch ex As Exception
                lanzarException(ex)
            End Try
        End Set
    End Property


    Public ReadOnly Property meSprocedure() As String
        Get
            If I_TABLA IsNot Nothing Then
                sProcedureName = IIf(I_TABLA.DataSet IsNot Nothing, I_TABLA.TableName, "DATATABLE")
            End If
            Return sProcedureName
        End Get

    End Property
    Public ReadOnly Property me_sWhere() As String
        Get
            Return WHERE_PUB
        End Get


    End Property
    Public Property meParametrosDataSet() As String
        Get
            Return I_PARAMETROS_DATASET
        End Get
        Set(ByVal parametroWhere As String)
            I_PARAMETROS_DATASET = parametroWhere
        End Set

    End Property
    Public Property meLanzarException() As Boolean
        Get
            Return I_EXCEPTIONS
        End Get
        Set(ByVal exceptions As Boolean)
            I_EXCEPTIONS = exceptions
        End Set
    End Property

    Public Property meFiltrarVacios() As Boolean
        Get
            Return I_FILTRAR_VACIOS
        End Get
        Set(ByVal filtrarVacios As Boolean)
            I_FILTRAR_VACIOS = filtrarVacios
        End Set
    End Property

    Public Property meBackcolorEtiquetas() As Drawing.Color
        Get
            Return I_ETIQUETAS_BACKCOLOR
        End Get
        Set(ByVal color As Color)
            I_ETIQUETAS_BACKCOLOR = color
        End Set
    End Property

    'Public Property meBorderColorEtiquetas() As Color
    '    Get
    '        Return I_ETIQUETAS_BORDERCOLOR
    '    End Get
    '    Set(ByVal color As Color)
    '        I_ETIQUETAS_BORDERCOLOR = color
    '    End Set
    'End Property

    Public Property meBorderStyleEtiquetas() As BorderStyle = BorderStyle.None

    Public Property meDistanciaIzquierda() As Integer
        Get
            Return I_DISTANCIA_IZQ
        End Get
        Set(ByVal distancia As Integer)
            Dim mover As Integer = distancia - I_DISTANCIA_IZQ
            I_DISTANCIA_IZQ = distancia
            'For Each c As Control In panelFiltros.Controls
            '    c.Location() = New Point(c.Location.X + mover, c.Location.Y)
            'Next
        End Set
    End Property

    Public Property meColumnasOmitir() As String()
        Get
            Return I_COLUMNAS_OMITIR
        End Get
        Set(ByVal columnas As String())
            I_COLUMNAS_OMITIR = columnas
            llenarCombo()
        End Set
    End Property
#End Region
    Public Sub CleanFiltros()
        quitarFiltros()
    End Sub


#Region "Eventos"


    Private Sub etiquetaFiltroClick(sender As Object, e As EventArgs)
        Try
            Dim c As Control = sender
            panelEtiquetas.Controls.Remove(c.Parent)
            If panelEtiquetas.Controls.Count = 0 Then
                panelEtiquetas.Padding = New Padding(0)
            End If
            filtrarGrilla()
            CountFiltros -= 1
            RaiseEvent End_Buscar_Quit_Filtro(Me, e)
        Catch ex As Exception
            lanzarException(ex)
        End Try
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Dim textoFiltro As String = ""
        If (Me.cmbBuscar.SelectedIndex <> -1 And (cmbFiltro.Text.Trim <> Nothing Or I_FILTRAR_VACIOS = True) And cmbExpresion.SelectedIndex <> -1) Then
            textoFiltro &= cmbFiltro.Text.Trim
            crearEtiquetaFiltro(Me.cmbBuscar.Text & " " & cmbExpresion.Text & " " & textoFiltro, cmbBuscar.SelectedValue, textoFiltro, panelEtiquetas.Controls.Count + 1, cmbExpresion.Text)
        End If
        cmbFiltro.Focus()
        RaiseEvent End_Buscar_Quit_Filtro(Me, e)
    End Sub

    Private Sub btnLimpiar_Click(sender As Object, e As EventArgs) Handles btnLimpiar.Click
        CountFiltros = 0
        quitarFiltros()
    End Sub
    Private Sub cmbExpresion_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbExpresion.SelectedIndexChanged
        If cmbExpresion.SelectedIndex <> -1 Then

            I_TOOLTIP.SetToolTip(cmbExpresion, cmbExpresion.SelectedValue)
        End If

    End Sub

    Private Sub cmbBuscar_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbBuscar.SelectedIndexChanged
        If cmbBuscar.SelectedIndex <> -1 Then
            habilitarExpresiones()
            LlenarCombocheck(cmbBuscar.SelectedValue)
        End If

    End Sub
    Private Sub cbm_filtro_EnterKeyDown(objSender As Object, e As EventArgs) Handles cmbFiltro.SelectedIndexChanged
        If cmbFiltro.SelectedValue = Convert.ToChar(13) Then
            btnBuscar.Focus()
            btnBuscar_Click(btnBuscar, Nothing)
        End If
    End Sub
#End Region
#Region "métodos"


    Private Sub quitarFiltros()
        Try
            panelEtiquetas.Padding = New Padding(0)
            For i = panelEtiquetas.Controls.Count - 1 To 0 Step -1
                panelEtiquetas.Controls.RemoveAt(i)
            Next
            'quitar los filtros
            If I_TABLA IsNot Nothing Then
                Dim defaultV As DataView = I_TABLA.DefaultView
                defaultV.RowFilter = ""

                If I_DATAList IsNot Nothing Then
                    'Me.I_DATAList.DataSource = defaultV
                    Me.I_DATAList.DataBindings(I_DATAList.DataBindings.Count - 1).DataSource.Tables(0) = defaultV
                ElseIf I_DATAGRIDVIEW Is Nothing Then
                    Me.I_DATAGRIDVIEW.DataSource = defaultV
                End If
            End If
            '
            If I_BINDING_NAVIGATOR IsNot Nothing Then
                For i = 0 To I_BINDING_NAVIGATOR.Length - 1
                    I_BINDING_NAVIGATOR(0).BindingSource.Filter() = ""
                Next
            End If
            RaiseEvent End_Buscar_Quit_Filtro(Me, Nothing)
        Catch ex As Exception
            lanzarException(ex)
        End Try
    End Sub
    Private Sub crearExpresiones()
        Dim datos As New Dictionary(Of String, String)
        'Agregar par de datos a mostrar en el combo, (tooltip, descripcion)--->
        datos.Add("Contiene", "%")
        'datos.Add("Entre", "><")
        datos.Add("Igual", "=")
        datos.Add("Diferente", "<>")
        datos.Add("Mayor que", ">")
        datos.Add("Menor que", "<")
        datos.Add("Mayor o igual que", ">=")
        datos.Add("Menor o igual que", "<=")
        datos.Add("No contiene", "!%")

        '<---- checar metodo "habilitarExpresiones" si se agregan o se quitan datos
        Try
            I_TABLA_EXPRESIONES = New DataTable("COMBO")
            I_TABLA_EXPRESIONES.Columns.Add("valor")
            I_TABLA_EXPRESIONES.Columns.Add("descripcion")
            For Each pair In datos
                Dim Row = I_TABLA_EXPRESIONES.NewRow()
                Row("valor") = pair.Key
                Row("descripcion") = pair.Value
                I_TABLA_EXPRESIONES.Rows.Add(Row)
            Next
            cmbExpresion.ValueMember = "valor"
            cmbExpresion.DisplayMember = "descripcion"
            cmbExpresion.DataSource = I_TABLA_EXPRESIONES
            cmbExpresion.SelectedIndex = 0
        Catch ex As Exception
            lanzarException(ex)
        End Try

    End Sub
    Private Sub habilitarExpresiones()
        If I_TABLA_EXPRESIONES IsNot Nothing Then

            Dim col = I_TABLA.Columns().Item(cmbBuscar.SelectedValue)
            Dim defaultV As DataView = I_TABLA_EXPRESIONES.DefaultView
            If col.DataType.Name.Contains("Int") Or col.DataType.Name.Contains("Decimal") Or col.DataType.Name.Contains("Date") Or col.DataType.Name.Contains("Double") Then
                defaultV.RowFilter = " valor <> 'Contiene' and valor <> 'No contiene'"
            Else
                defaultV.RowFilter = " valor <> 'Mayor que' and valor <> 'Menor que' and valor <> 'Mayor o igual que' and valor <> 'Menor o igual que'"
            End If
            cmbExpresion.DataSource = defaultV
        End If
    End Sub

    Private Sub asignarBindings(Formulario As Control)
        For Each c As Control In Formulario.Controls
            If c.HasChildren Then
                asignarBindings(c)
            Else
                If c.GetType.Name.Contains("BindingNavigator") Then
                    Dim bindingNav = TryCast(c, BindingNavigator)
                    If bindingNav.BindingSource IsNot Nothing Then
                        If bindingNav.BindingSource.DataMember IsNot Nothing Then
                            If TryCast(c, BindingNavigator).BindingSource.DataMember.ToString = I_TABLA.ToString Then
                                ReDim Preserve I_BINDING_NAVIGATOR(I_COUNT_BINDINGS)
                                I_BINDING_NAVIGATOR(I_COUNT_BINDINGS) = TryCast(c, BindingNavigator)
                                I_COUNT_BINDINGS += 1
                            End If
                        End If
                    End If
                End If
            End If
        Next
    End Sub
    Public Sub llenarCombo()
        Try
            Dim tabla As DataTable = New DataTable("COMBO")
            tabla.Columns.Add("valor")
            tabla.Columns.Add("descripcion")

            If I_DATAGRIDVIEW Is Nothing Then
                If I_DATAList IsNot Nothing Then
                    For i = 0 To I_DATAList.Columns.Count - 1
                        If I_DATAList.Columns(i).Text <> Nothing And I_DATAList.Columns(i).GetType.FullName = "System.String" Then
                            tabla.Rows.Add(I_DATAList.Columns(i).Tag, I_DATAList.Columns(i).Text)
                        End If
                    Next
                End If
            Else
                For i = 0 To I_DATAGRIDVIEW.ColumnCount - 1
                    If I_DATAGRIDVIEW.Columns(i).Visible = True And (I_DATAGRIDVIEW.Columns(i).CellType.Name = "DataGridViewTextBoxCell" Or I_DATAGRIDVIEW.Columns(i).CellType.Name = "DataGridViewLinkCell") Then
                        If I_DATAGRIDVIEW.Columns(i).DataPropertyName <> Nothing Then
                            If I_TABLA.Columns(I_DATAGRIDVIEW.Columns(i).DataPropertyName) IsNot Nothing Then
                                If I_COLUMNAS_OMITIR IsNot Nothing Then
                                    For x = 0 To I_COLUMNAS_OMITIR.Length - 1
                                        If I_COLUMNAS_OMITIR(x) = I_DATAGRIDVIEW.Columns(i).Name Then
                                            GoTo omitirColumna
                                        End If
                                    Next
                                End If
                                tabla.Rows.Add(I_DATAGRIDVIEW.Columns(i).DataPropertyName, I_DATAGRIDVIEW.Columns(i).HeaderText)
omitirColumna:
                            End If
                        End If
                    End If
                Next
            End If

            Me.cmbBuscar.ValueMember = "valor"
            Me.cmbBuscar.DisplayMember = "descripcion"
            Me.cmbBuscar.DataSource = tabla
        Catch ex As Exception
            lanzarException(ex)
        End Try
    End Sub

    Public Sub LlenarCombocheck(column As String)
        cmbFiltro.Items.Clear()
        Dim names = From row In I_TABLA.AsEnumerable()
                    Select row.Field(Of Object)(column) Distinct

        For Each row In names
            cmbFiltro.Items.Add(row)
        Next
    End Sub

    Private Sub filtrarGrilla()
        Dim Where As String = "" : Dim cm1 As String = "" : Dim cm2 As String = "'" : Dim separador As String = " " : Dim expresion As String = ""
        Try


            For i = 0 To panelEtiquetas.Controls.Count - 1
                Dim label As MePanel = panelEtiquetas.Controls(i)
                expresion = label.exp
                Dim col = I_TABLA.Columns().Item(label.field)

                If col.DataType.Name.Contains("Int") Or col.DataType.Name.Contains("Decimal") Then 'si es númerico, se transforma a un double y  se cambia "like" por "="
                    label.value = Double.Parse(rellenar(label.value, 8, True))
                End If

                If expresion = "%" Then
                    cm1 = " Like '%" : cm2 = "%'"
                ElseIf expresion = "!%" Then
                    cm1 = " Not Like '%" : cm2 = "%'"
                Else
                    cm1 = " " & expresion & " '" : cm2 = "'"
                End If

                Where &= separador & "[" & label.field & "]" & cm1 & label.value & cm2
                separador = IIf(cmbConcatenar.SelectedIndex = 1, " or ", " and ")
            Next

            Dim defaultV As DataView = I_TABLA.DefaultView
            defaultV.RowFilter = Where
            WHERE_PUB = Where

            If I_DATAGRIDVIEW Is Nothing Then
                Me.I_DATAList.DataBindings(I_DATAList.DataBindings.Count - 1).DataSource.tables(0) = defaultV

            Else


                Me.I_DATAGRIDVIEW.DataSource = defaultV
            End If
            _Dataview = defaultV


            For i = 0 To I_BINDING_NAVIGATOR.Length - 1
                I_BINDING_NAVIGATOR(0).BindingSource.Filter() = Where
            Next
        Catch ex As Exception
            lanzarException(ex)
        End Try

    End Sub
    Private Function rellenar(ByVal texto As String, decimales As Integer, negativo As Boolean)
        Dim numeros As Char()
        If (decimales > 0) Then
            numeros = texto.ToCharArray()
            texto = ""
            For i = 0 To numeros.Length - 1
                If ((numeros(i) >= "0" And numeros(i) <= "9") Or numeros(i) = ".") Then
                    texto += numeros(i)
                ElseIf negativo And numeros(0) = "-" Then
                    texto += numeros(i)
                End If
            Next i
            If texto.Contains(".") Then
                Dim entero_decimal() As String = texto.Split(".")
                If entero_decimal(1).Length >= decimales Then
                    entero_decimal(1) = entero_decimal(1).Substring(0, decimales)
                    texto = entero_decimal(0) & "." & entero_decimal(1)
                Else
                    texto = entero_decimal(0) & "."
                    For i = 1 To decimales - entero_decimal(1).Length
                        entero_decimal(1) += "0"
                    Next
                    texto += entero_decimal(1)
                End If
            Else
                texto = texto & "."
                For i = 1 To decimales
                    texto = texto & "0"
                Next
            End If
        Else
            Dim entero As String() = texto.Split(".")
            numeros = entero(0).ToCharArray()
            texto = ""
            For i = 0 To numeros.Length - 1
                If (numeros(i) >= "0" And numeros(i) <= "9") Then
                    texto += numeros(i)
                ElseIf negativo And numeros(0) = "-" Then
                    texto += numeros(i)
                End If
            Next i
        End If
        If texto.Length > 0 Then
            If texto.Substring(0, 1) = "." Then texto = "0" + texto
        Else texto = "0"
        End If
        Return texto
    End Function

#End Region
    'Clase creada para poder agregar campo de la base de datos y valor a filtrar
    Private Class MePanel
        Inherits Wisej.Web.Panel
        Protected Friend field As String = Nothing
        Protected Friend value As String = Nothing
        Protected Friend exp As String = Nothing

    End Class



    Private Sub crearEtiquetaFiltro(texto As String, campo As String, valor As String, Id As Integer, expresion As String)
        Try
            Dim filtro As MePanel = New MePanel
            Dim boton As New Button
            Dim label As New Label
            '
            '
            '  
            boton.BackgroundImageLayout = Wisej.Web.ImageLayout.OriginalSize
            boton.BackgroundImage = Me.Icono
            boton.BorderStyle = Wisej.Web.BorderStyle.None
            boton.BackColor = System.Drawing.Color.Transparent
            boton.TextAlign = ContentAlignment.MiddleCenter
            boton.ForeColor = Color.DimGray
            boton.Font = New Font("Arial", 8.25!, FontStyle.Bold)
            boton.Name = "boton_" & Id
            boton.Size = New System.Drawing.Size(20, 20)
            boton.Margin = New Padding(0)
            boton.Padding = New Padding(0)


            AddHandler boton.Click, AddressOf etiquetaFiltroClick
            '
            label.MinimumSize = New Size(0, 20)
            label.AutoSize = True
            label.Name = "label_" & Id
            label.Text = texto
            label.Font = New Font("Arial", 9.25!, FontStyle.Regular)
            label.TextAlign = ContentAlignment.MiddleCenter
            label.Margin = New Padding(0)
            label.Padding = New Padding(0)
            '
            filtro.MinimumSize = New Size(0, 22)
            filtro.value = valor
            filtro.field = campo
            filtro.exp = expresion
            filtro.AutoSizeMode = AutoSizeMode.GrowAndShrink
            filtro.AutoSize = True
            filtro.Controls.Add(boton)
            filtro.Controls.Add(label)
            filtro.BackColor = I_ETIQUETAS_BACKCOLOR
            filtro.Name = "filtro_" & Id

            'boton.Location = New Point()
            label.Location = New Point(18, boton.Location.Y)


            panelEtiquetas.Controls.Add(filtro)

            filtro.CssStyle = "top: 4px; left: 4px; border-style: solid; border-radius: 5px; border-width: 1px;" &
            "border-color: rgb(" & I_ETIQUETAS_BORDERCOLOR.R & "," & I_ETIQUETAS_BORDERCOLOR.G & "," & I_ETIQUETAS_BORDERCOLOR.B & ");"
            boton.CssStyle = "Margin: 0px; border-style: none;"

            CountFiltros += 1
            filtrarGrilla()
            Me.cmbFiltro.Text = Nothing
        Catch ex As Exception
            lanzarException(ex)
        End Try
    End Sub



    Public Sub lanzarException(ex As Exception)
        If I_EXCEPTIONS Then
            Throw ex 'creado por si se desea manejar alguna exception que ocurra
        End If

    End Sub

    Private Sub ToolStripTextBox1_Click(sender As Object, e As EventArgs) Handles ToolStripTextBox1.Click, MenuItem1.Click
        If "ADMIN" = Wisej.Web.Application.Session("CVE_OPERADOR") Then
            ToolStripTextBox1.Text = meSprocedure
            Wisej.Web.Clipboard.SetClientText(ToolStripTextBox1.Text)
            Me.Eval("Wisej.Core.copy();")
        End If
    End Sub

    Private Sub BtnExportar_Click(sender As Object, e As EventArgs) Handles BtnExportar.Click
        If meDatagrid IsNot Nothing Then
            If Me.meDatagrid.RowCount > 0 Then
                Dim sExportar As New Utilidades.ExportarInformacion
                Utilidades.Configuracion.ME_PROCEDURE = Me.meSprocedure
                Export_procedure(Me.ParentForm)

            End If

        End If
    End Sub

    Public Function tablaSinFiltros() As DataTable
        I_TABLA.Copy()
        Dim tablaClear As New DataTable("default")
        tablaClear = I_TABLA.Copy()
        tablaClear.DefaultView.RowFilter = ""
        'Dim defaultV As New DataView()
        'defaultV = I_TABLA.DefaultView
        'defaultV.RowFilter = ""
        'tablaClear = defaultV.ToTable()


        Return tablaClear

    End Function


    'Private Sub _dllData_ClosedFormtHandle(sender As Form, e As EventArgs) Handles _dllData.ClosedFormtHandle
    '    If _FiltroGrillaSaxColumns IsNot Nothing AndAlso _FiltroGrillaSaxColumns.dgvColumns.RowCount > 0 And _FiltroGrillaSaxColumns.bGuardo Then
    '        meDatagrid = _FiltroGrillaSaxColumns.gridClone
    '        I_TABLA = _FiltroGrillaSaxColumns.DT
    '    End If
    'End Sub
    Private Sub Export_procedure(ByVal Formx As Form)

        Try
            Dim AspX As New AspNetPanel
            For Each cntrl In Formx.Controls
                If cntrl.tag = "Downloaded ASPX" Then
                    Formx.Controls.Remove(cntrl)
                End If
            Next
            Formx.Controls.Add(AspX)
            AspX.Size = New Size(0, 0)
            AspX.Location = New Point(0, 0)
            AspX.PageSource = "Exportar_Por_Procedure.aspx"
            AspX.Update()
        Catch ex As Exception

        End Try
    End Sub

    'Private Sub cmbFiltro_Click(sender As Object, e As EventArgs) Handles cmbFiltro.Click
    '    If cmbFiltro.Items.Count = 0 Then
    '        LlenarCombocheck(cmbBuscar.SelectedValue)
    '    End If
    'End Sub

    Private Sub cmbFiltro_ToolClick(sender As Object, e As ToolClickEventArgs) Handles cmbFiltro.ToolClick

    End Sub

    Private Sub cmbFiltro_DropDown(sender As Object, e As EventArgs) Handles cmbFiltro.DropDown
        If cmbFiltro.Items.Count = 0 Then
            LlenarCombocheck(cmbBuscar.SelectedValue)
        End If
    End Sub

    Private Sub cmbFiltro_KeyDown(sender As Object, e As KeyEventArgs) Handles cmbFiltro.KeyDown
        If e.KeyValue = Keys.Enter Then
            btnBuscar_Click(btnBuscar, Nothing)
        End If
    End Sub

    Shared Sub exportarProcedure(ByVal responseX As HttpResponse)



        Dim table As DataTable = New DataTable("Sheet1")
        Try
            'LicenseHelper.ModifyInMemory.ActivateMemoryPatching()
            Utilidades.Conectar()
            Dim cmd As SqlClient.SqlCommand = New SqlClient.SqlCommand()
            cmd.Connection = New SqlClient.SqlConnection(Utilidades.sConexion)
            cmd.CommandText = Utilidades.Configuracion.ME_PROCEDURE
            cmd.CommandType = CommandType.StoredProcedure
            If Utilidades.Configuracion.ME_PARAMETROS Is Nothing = False Then
                If Utilidades.Configuracion.ME_PARAMETROS.Length > 0 Then
                    For n = 0 To Utilidades.Configuracion.ME_PARAMETROS.Length - 1
                        cmd.Parameters.Add(Utilidades.Configuracion.ME_PARAMETROS(n))
                    Next
                End If
            End If
            Dim da As SqlClient.SqlDataAdapter = New SqlClient.SqlDataAdapter()
            da.SelectCommand = cmd
            da.Fill(table)
            Utilidades.Desconectar()

            responseX.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"

            Dim cellExport As New Spire.DataExport.XLS.CellExport
            Dim worksheet1 As New Spire.DataExport.XLS.WorkSheet
            worksheet1.DataSource = Spire.DataExport.Common.ExportSource.DataTable
            worksheet1.DataTable = table
            worksheet1.StartDataCol = (0)
            cellExport.Sheets.Add(worksheet1)
            cellExport.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView
            Dim memoriaStream As New IO.MemoryStream
            'cellExport.SaveToStream(memoriaStream)
            cellExport.SaveToHttpResponse(Utilidades.OpcionesExportar.NombreArchivo & ".xls", responseX)
        Catch ex As Exception
        End Try

    End Sub


End Class




