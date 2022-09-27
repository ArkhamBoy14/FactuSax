Imports System.Data
Imports System.Data.SqlClient


Public Class Cat_Rol
    Dim Alertas As New Notificaciones
    Dim cveAsociaciones As String = ""
    Dim posicion As Integer = -1
    Dim cargarHabilitados As Boolean = True
    Dim agregandoNuevo As Boolean = False
    Private Sub Cat_Rol_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        RBBCANCELAR.Enabled = False
        Me.BindingNavigator1.AddNewItem.Visible = False
        Me.BindingNavigator1.DeleteItem.Visible = False
        txtCveRol.Enabled = False
        isBindingVacio()
        FiltroGrillaSax1.meDatagrid = DGVRol
        RBBNUEVO.ToolTipText = "Limpiar todos los campos"
        RBBGUARDAR.ToolTipText = "Guarda / Actualiza el registro"
        RBBCANCELAR.ToolTipText = "Seguir editando los registros"
        RBBSALIR.ToolTipText = "Cerrar la ventana"

    End Sub


    Sub Nuevo()
        If agregandoNuevo = False Then
            agregandoNuevo = True
            posicion = BindingSource1.Position
            RBBNUEVO.Enabled = False
            RBBCANCELAR.Enabled = True
            RBBGUARDAR.Enabled = True
            cargarHabilitados = rbHabilitado.Checked
            BindingSource1.SuspendBinding()
            'Me.Dataset_pCAT_ROL_B.RejectChanges()
            limpiar()
            'txtCveRol.Enabled = True
            BindingNavigator1.MoveFirstItem.Enabled = False
            BindingNavigator1.MovePreviousItem.Enabled = False
            BindingNavigator1.MoveNextItem.Enabled = False
            BindingNavigator1.MoveLastItem.Enabled = False
        End If
    End Sub

    Sub Guardar()
        'If validar() Then
        Try
                ReDim Utilidades.ParametersX_Global(2)
                Utilidades.ParametersX_Global(0) = New SqlParameter("@CVE_ROL", txtCveRol.Text)
                Utilidades.ParametersX_Global(1) = New SqlParameter("@ROL", txtDescripcion.Text)
                Utilidades.ParametersX_Global(2) = New SqlParameter("@HABILITADO", ckdEstatus.Checked)
                cveAsociaciones = Utilidades.EjecutarProcedure_Id("[pCAT_ROL_G]", "@PARAMETRO", Utilidades.ParametersX_Global, , SqlDbType.VarChar, 50)

                If cveAsociaciones <> Nothing Then
                    'MessageBox.Show("Datos guardados correctamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Alertas.NotificacionExito("Datos guardados correctamente...", "Éxito")
                    BindingSource1.ResumeBinding()
                    If Not agregandoNuevo Then posicion = BindingSource1.Position
                    Cargar()
                    cancelarEditando()
                Else
                    Alertas.NotificacionError("Error, Datos no guardados", "Error")
                    'MessageBox.Show("Datos no guardados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error al guardar los datos", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        'Else
        'Alertas.NotificacionError("No se pueden Guardar datos vacios", "Error")
        ' MessageBox.Show("No puede guardar datos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        'End If
    End Sub
    Sub Cargar()
        Try
            limpiar()
            Dataset_pCAT_ROL_B.Clear()
            Dim myDA = New SqlDataAdapter("pCAT_ROL_B", Utilidades.sConexion)
            myDA.SelectCommand.CommandType = CommandType.StoredProcedure
            myDA.SelectCommand.Parameters.AddWithValue("@Habilitado", rbHabilitado.Checked)
            myDA.Fill(Me.Dataset_pCAT_ROL_B.pCAT_ROL_B)
            myDA.Dispose()
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Inicio", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub
    Function validar() As Integer
        If Trim(txtCveRol.Text) = "" Or Trim(txtDescripcion.Text) = "" Then
            Return False
        End If
        Return True
    End Function
    Private Sub BindingNavigator1_ButtonClick_1(sender As Object, e As ToolBarButtonClickEventArgs) Handles BindingNavigator1.Click
        Dim nomb = e.Button.Name.ToString
        Select Case nomb
            Case "BindingNavigatorMoveNextItem", "BindingNavigatorMoveLastItem", "BindingNavigatorMoveFirstItem", "BindingNavigatorMovePreviousItem"
                'Me.Dataset_pCAT_ROL_B.RejectChanges()
                posicion = BindingSource1.Position
                retomarPosiscion(posicion, DGVRol, BindingSource1)
        End Select
    End Sub
    Private Sub cancelarEditando()
        If agregandoNuevo = True Then
            agregandoNuevo = False
            RBBNUEVO.Enabled = True
            RBBCANCELAR.Enabled = False
            If BindingSource1.Position = 0 Then cargarDatosNovinculados()
        End If
        retomarPosiscion(posicion, DGVRol, BindingSource1)
        txtCveRol.Enabled = False
        isBindingVacio()
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
        If BindingSource1.Count > 0 And Not agregandoNuevo Then
            txtCveRol.Text = DirectCast(BindingSource1.Current, DataRowView).Item("Cve_Rol")
            txtDescripcion.Text = DirectCast(BindingSource1.Current, DataRowView).Item("ROL")
            ckdEstatus.Checked = DirectCast(BindingSource1.Current, DataRowView).Item("Habilitado")
        End If
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
        'Dim pag As Integer = Math.Ceiling((BindingSource1.Position() / DGVRol.ItemsPerPage()) + 0.01)
        'DGVRol.CurrentPage() = pag
    End Sub
    Private Sub limpiar()
        txtCveRol.Text = ""
        txtDescripcion.Text = ""
        cveAsociaciones = ""
    End Sub
    Private Sub rbHabilitado_CheckedChanged(sender As Object, e As EventArgs) Handles rbHabilitado.CheckedChanged
        Cargar()
    End Sub

    Private Sub BindingSource1_PositionChanged(sender As Object, e As EventArgs) Handles BindingSource1.PositionChanged
        If Not agregandoNuevo Then
            isBindingVacio()
            cargarDatosNovinculados()
        End If
    End Sub

    Private Sub RibbonBar1_ButtonClick(sender As Object, e As Ext.RibbonBar.RibbonBarItemEventArgs) Handles RibbonBar1.ItemClick
        Select Case e.Item.Name
            Case RBBNUEVO.Name
                Nuevo()
            Case RBBGUARDAR.Name
                Guardar()
            Case RBBCANCELAR.Name
                Cancelar()
            Case RBBSALIR.Name
                BindingSource1.ResumeBinding()
                CambiarTabla()
                cancelarEditando()
                Close()
        End Select
    End Sub
    Sub Cancelar()
        RBBNUEVO.Enabled = True
        RBBCANCELAR.Enabled = False
        RBBGUARDAR.Enabled = False
        txtDescripcion.Text = ""
        ckdEstatus.Checked = False
    End Sub


    Private Sub DGVRol_CurrentCellChanged(sender As Object, e As EventArgs) Handles DGVRol.CurrentCellChanged
        '
    End Sub
End Class
