Imports System.Data.SqlClient
Imports System.Data
Imports System.IO

Public Class Cat_Operadores
    Dim alertas As New Notificaciones
    Dim cveOperador As String = ""
    Dim posicion As Integer = -1
    Dim cargarHabilitados As Boolean = True
    Dim agregandoNuevo As Boolean = False
    Private imagenAGuardar As String = ""
    Private fotoTemporal As String = ""
    Private urlImagenGuardada As String = ""
    Private url_relativa_carpeta As String
    Private exten As String
    Private url_img_usuario As String
    Private contador As Integer = 0

    Private Sub Cat_Operadores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        subLlenarCombos()
        RBBCANCELAR.Enabled = False
        txtCve_Operador.Enabled = False
        isBindingVacio()
        FiltroGrillaSax1.meDatagrid = DGV_Operadores
        RBBNUEVO.ToolTipText = "Limpiar todos los campos"
        RBBGUARDAR.ToolTipText = "Guarda / Actualiza el registro"
        RBBCANCELAR.ToolTipText = "Seguir editando los registros"
        RBBSALIR.ToolTipText = "Cerrar la ventana"
    End Sub
    Private Sub RibbonBar1_ButtonClick(sender As Object, e As Ext.RibbonBar.RibbonBarItemEventArgs) Handles RibbonBar1.ItemClick
        Select Case e.Item.Name
            Case RBBNUEVO.Name
                Nuevo()
            Case RBBGUARDAR.Name
                Guardar()
            Case RBBCANCELAR.Name
                BindingSource1.ResumeBinding()
                CambiarTabla()
                cancelarEditando()
            Case RBBSALIR.Name
                Close()
        End Select
    End Sub

    Sub Nuevo()
        If agregandoNuevo = False Then
            txtCve_Operador.Enabled = True
            agregandoNuevo = True
            RBBGUARDAR.Enabled = True
            RBBNUEVO.Enabled = False
            RBBCANCELAR.Enabled = True
            posicion = BindingSource1.Position
            cargarHabilitados = rbHabilitado.Checked
            BindingSource1.SuspendBinding()
            BindingNavigator1.MoveFirstItem.Enabled = False
            BindingNavigator1.MovePreviousItem.Enabled = False
            BindingNavigator1.MoveNextItem.Enabled = False
            BindingNavigator1.MoveLastItem.Enabled = False
        End If
    End Sub
    Sub Guardar()
        If validado() Then
            Try
                ReDim Utilidades.ParametersX_Global(6)
                Utilidades.ParametersX_Global(0) = New SqlParameter("@CVE_OPERADOR", txtCve_Operador.Text)
                Utilidades.ParametersX_Global(1) = New SqlParameter("@ESTATUS", ckdEstatus.Checked)
                Utilidades.ParametersX_Global(2) = New SqlParameter("@CONTRASENA", txtContra.Text)
                Utilidades.ParametersX_Global(3) = New SqlParameter("@PassphraseEnteredByUser", Utilidades.sConstante_KEY)
                Utilidades.ParametersX_Global(4) = New SqlParameter("@CVE_ROL", cmbRol.SelectedValue)
                Utilidades.ParametersX_Global(5) = New SqlParameter("@URL_FOTOGRAFIA", urlImagenGuardada)
                Utilidades.ParametersX_Global(6) = New SqlParameter("@NOMBRE", tbxNombreOperador.Text)
                cveOperador = Utilidades.EjecutarProcedure_Id("pCAT_OPERADORES_G", "@PARAMETRO", Utilidades.ParametersX_Global, False, SqlDbType.VarChar, 50)

                If (cveOperador <> Nothing) Then
                    alertas.NotificacionExito("Datos guardados correctamente...", "Éxito")
                    ' Utilidades.MessageBox("Datos guardados correctamente", "Guardar cambios", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    BindingSource1.ResumeBinding()
                    fotoTemporal = ""
                    If Not agregandoNuevo Then posicion = BindingSource1.Position
                    cargar()
                    cancelarEditando()
                Else
                    alertas.NotificacionError("Error, Datos no guardados", "Error")
                    ' Utilidades.MessageBox("Datos no guardados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Guardar", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End If
    End Sub
    Sub cargar()
        Try
            Utilidades.Limpiar(Me)
            DataSet_pCAT_OPERADORES_B.Clear()
            Dim myDA = New SqlDataAdapter("pCAT_OPERADORES_B", Utilidades.sConexion)
            myDA.SelectCommand.CommandType = CommandType.StoredProcedure
            myDA.SelectCommand.Parameters.AddWithValue("@PassphraseEnteredByUser", Utilidades.sConstante_KEY)
            myDA.SelectCommand.Parameters.AddWithValue("@Habilitado", rbHabilitado.Checked)
            myDA.Fill(DataSet_pCAT_OPERADORES_B.pCAT_OPERADORES_B)
            myDA.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Inicio", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Private Function validado() As Boolean
        Dim validar = True

        If Trim(txtCve_Operador.Text) = Nothing Then
            ErrorProvider1.SetError(txtCve_Operador, "Escriba la clave del operador")
            validar = False
        Else
            Me.ErrorProvider1.SetError(txtCve_Operador, Nothing)
        End If

        If Trim(txtContra.Text) = Nothing Then
            ErrorProvider1.SetError(txtContra, "Escriba una contraseña")
            validar = False
        Else
            ErrorProvider1.SetError(txtContra, Nothing)
        End If
        If (cmbRol.SelectedIndex = -1) Then
            ErrorProvider1.SetError(cmbRol, "Seleccione un elemento de la lista")
            validar = False
        Else
            ErrorProvider1.SetError(cmbRol, Nothing)
        End If
        Return validar
    End Function
    Private Sub cancelarEditando()
        If agregandoNuevo = True Then
            txtCve_Operador.Enabled = True
            agregandoNuevo = False
            RBBNUEVO.Enabled = True
            RBBCANCELAR.Enabled = False
            If BindingSource1.Position = 0 Then cargarDatosNovinculados()
        End If
        txtCve_Operador.Enabled = False
        retomarPosiscion(posicion, DGV_Operadores, BindingSource1)
        isBindingVacio()
        quitarErrorProvider()
    End Sub
    Sub retomarPosiscion(posicionBinding As Integer, dgvTabla As DataGridView, binding As BindingSource)
        If binding.Count > 0 Then
            If posicionBinding >= binding.Count Then
                posicionBinding = binding.Count - 1
            End If
            If posicionBinding < 0 Then
                posicionBinding = 0
            End If
            binding.Position = posicionBinding
            dgvTabla.ClearSelection()
            dgvTabla.Rows(posicionBinding).Selected = True
            paginacion()
        End If
    End Sub
    Private Sub isBindingVacio()
        If BindingSource1.Count > 0 Then
            RBBGUARDAR.Enabled = True
        Else
            RBBGUARDAR.Enabled = False
        End If
    End Sub
    Private Sub cargarDatosNovinculados()
        Try
            If BindingSource1.Count > 0 And Not agregandoNuevo Then
                ckdEstatus.Checked = DirectCast(BindingSource1.Current, DataRowView).Item("ESTATUS")
                cmbRol.Text = DirectCast(BindingSource1.Current, DataRowView).Item("ROL")
                txtContra.Text = DirectCast(BindingSource1.Current, DataRowView).Item("CONTRASENA")
                txtCve_Operador.Text = DirectCast(BindingSource1.Current, DataRowView).Item("Cve_Operador")
                tbxNombreOperador.Text = DirectCast(BindingSource1.Current, DataRowView).Item("Nombre")
                imagenAGuardar = DirectCast(BindingSource1.Current, DataRowView).Item("URL_Fotografia").ToString
            End If
        Catch ex As Exception
            MessageBox.Show("Error" & ex.Message, "Cargar datos no vinculados", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            ' Utilidades.MessageBox("Error" & ex.Message, "Cargar datos no vinculados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub

    Private Sub BindingNavigator1_ButtonClick(sender As Object, e As ToolBarButtonClickEventArgs) Handles BindingNavigator1.Click
        Dim nomb = e.Button.Name.ToString
        Select Case nomb
            Case "BindingNavigatorMoveNextItem", "BindingNavigatorMoveLastItem", "BindingNavigatorMoveFirstItem", "BindingNavigatorMovePreviousItem"
                DataSet_pCAT_OPERADORES_B.RejectChanges()
                posicion = BindingSource1.Position
                retomarPosiscion(posicion, DGV_Operadores, BindingSource1)
        End Select
    End Sub

    Private Sub rbHabilitado_CheckedChanged(sender As Object, e As EventArgs) Handles rbHabilitado.CheckedChanged
        cargar()
    End Sub
    Private Function CambiarTabla() As Boolean
        Dim cargado As Boolean = IIf(cargarHabilitados = rbHabilitado.Checked, False, True)
        If agregandoNuevo Then

            If (cargarHabilitados) Then
                rbHabilitado.Checked = True
            Else
                rbInhabilitado.Checked = True
            End If
        End If
        Return cargado
    End Function
    Private Sub paginacion()
        'Dim pag As Integer = Math.Ceiling((BindingSource1.Position() / DGV_Operadores.ItemsPerPage()) + 0.01)
        'DGV_Operadores.CurrentPage() = pag
    End Sub
    Sub subLlenarCombos()
        Try
            ReDim Utilidades.ParametersX_Global(1)
            Utilidades.ParametersX_Global(0) = New SqlParameter("@HABILITADO", 1)
            Utilidades.Llenar_Catalogos_Parametros("pCAT_ROL_B ", "CVE_ROL", "ROL", cmbRol, Utilidades.ParametersX_Global)
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "cargar datos no vinculados", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End Try
    End Sub
    Private Sub MoverBinding(sender As Object, e As EventArgs) Handles BindingSource1.PositionChanged
        If agregandoNuevo = False Then
            isBindingVacio()
            cargarDatosNovinculados()
        End If
    End Sub

    Private Sub CBxMostrar_CheckedChanged(sender As Object, e As EventArgs) Handles CBxMostrar.CheckedChanged
        If CBxMostrar.Checked = True Then
            txtContra.InputType.Type = TextBoxType.Text
        Else
            txtContra.InputType.Type = TextBoxType.Password
        End If
    End Sub
    Private Sub quitarErrorProvider()
        Me.ErrorProvider1.SetError(txtCve_Operador, Nothing)
        Me.ErrorProvider1.SetError(txtContra, Nothing)
        Me.ErrorProvider1.SetError(cmbRol, Nothing)
    End Sub

    Private Sub DGV_Operadores_CurrentCellChanged(sender As Object, e As EventArgs) Handles DGV_Operadores.CurrentCellChanged
        'necesita ser declarado aunque no se implemente
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        OpenFileDialog1.Title = "Archivo a Fotografía"
        OpenFileDialog1.Multiselect = False
        OpenFileDialog1.ShowDialog()
    End Sub



    Sub eliminarImagen1(img As String)
        If (img <> "") Then
            If (System.IO.File.Exists(img)) Then
                '   System.IO.File.Delete(("Images.Fotografias." & img))
                fotoTemporal = ""
            End If
        End If
    End Sub



End Class