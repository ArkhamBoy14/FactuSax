Imports System
Imports Wisej.Web
Imports System.Data
Imports System.Data.SqlClient
Imports System.Web.UI.WebControls


Public Class Cat_Clientes
    Dim Alertas As New Notificaciones
    Private Sub RibbonBar1_ItemClick(sender As Object, e As Ext.RibbonBar.RibbonBarItemEventArgs) Handles RibbonBar1.ItemClick
        Select Case e.Item.Name
            Case RBBNuevo.Name
                RBBNuevo.Enabled = False
                RBBCancelar.Enabled = True
                Nuevo()
            Case RBBGuardar.Name
                Guardar()
            Case RBBCancelar.Name
                RBBNuevo.Enabled = True
                RBBCancelar.Enabled = False
                Nuevo()
            Case RBBSalir.Name
                Me.Close()
        End Select
    End Sub
    Private Sub Cat_Clientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Nuevo()
        Cargar()
    End Sub

    Sub Nuevo()
        TBClave.Text = Nothing
        TBNombre.Text = Nothing
        TBAlias.Text = Nothing
        TBXPDUser.Text = Nothing
        TBXPDUserPass.Text = Nothing
        Chk_Habilitado.Checked = True
    End Sub

    Sub Cargar()
        Me.DataSet_pCAT_CLIENTES_BUSQUEDA_B.Clear()
        Try
            Dim myDA = New SqlDataAdapter("pCAT_CLIENTES_BUSQUEDA_B", Utilidades.sConexion)
            myDA.SelectCommand.CommandType = CommandType.StoredProcedure
            'myDA.SelectCommand.Parameters.AddWithValue("@Habilitado", rbHabilitado.Checked)
            myDA.Fill(Me.DataSet_pCAT_CLIENTES_BUSQUEDA_B.pCAT_CLIENTES_BUSQUEDA_B)
            myDA.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

        Try
            ChkList_Sistemas.Items.Clear()
            ReDim Utilidades.ParametersX_Global(1)
            'Utilidades.ParametersX_Global(0) = New SqlParameter("@EXCLUIR", "NINGUNO")
            Utilidades.Llenar_Catalogos("pCAT_SISTEMAS_B", Me.DataSet_pCAT_SISTEMAS_B, "Cat_Operadores")
            For index = 0 To DataSet_pCAT_SISTEMAS_B.Tables(0).Rows.Count() - 1
                ChkList_Sistemas.Items.Add(New ListItem(DataSet_pCAT_SISTEMAS_B.Tables(0).Rows(index)("Sistema"), DataSet_pCAT_SISTEMAS_B.Tables(0).Rows(index)("Cve_Sistema")))
            Next
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Inicio", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub Guardar()
        Try
            ReDim Utilidades.ParametersX_Global(9)
            Utilidades.ParametersX_Global(0) = New SqlParameter("@Cve_Cliente", TBClave.Text)
            Utilidades.ParametersX_Global(1) = New SqlParameter("@Nombre", TBNombre.Text)
            Utilidades.ParametersX_Global(2) = New SqlParameter("@Cant_Timbres", Num_Timbres.Value)
            Utilidades.ParametersX_Global(3) = New SqlParameter("@Alias", TBAlias.Text)
            Utilidades.ParametersX_Global(4) = New SqlParameter("@FactorumUser", TBXPDUser.Text)
            Utilidades.ParametersX_Global(5) = New SqlParameter("@FactorumPass", TBXPDUserPass.Text)
            Utilidades.ParametersX_Global(6) = New SqlParameter("@PassphraseEnteredByUser", Utilidades.sConstante_KEY)
            Utilidades.ParametersX_Global(7) = New SqlParameter("@Habilitado", Chk_Habilitado.Checked)
            Dim Cliente = Utilidades.EjecutarProcedure_Id("pCAT_CLIENTES_G", "@PARAMETRO", Utilidades.ParametersX_Global,, SqlDbType.VarChar, 50)
            If Cliente = 1 Then
                Alertas.NotificacionExito("Se han guardado los datos con éxito", "Aviso")
                GuardarSistemas(TBClave.Text)
                Cargar()
            Else
                Alertas.NotificacionError("Hubo un problema al guardar los datos", "Aviso")
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub GuardarSistemas(Cve_Cliente As String)
        Dim Value As String
        ReDim Utilidades.ParametersX_Global(0)
        Utilidades.ParametersX_Global(0) = New SqlParameter("@Cve_Cliente", Cve_Cliente)
        Value = Utilidades.EjecutarProcedure_Id("pCLIENTES_SISTEMAS_E", "@PARAMETRO", Utilidades.ParametersX_Global, , SqlDbType.VarChar, 50)

        For index = 0 To ChkList_Sistemas.Items.Count - 1
            If ChkList_Sistemas.GetItemChecked(index) Then
                Dim x As ListItem = ChkList_Sistemas.Items(index)
                ReDim Utilidades.ParametersX_Global(1)
                Utilidades.ParametersX_Global(0) = New SqlParameter("@Cve_Cliente", Cve_Cliente)
                Utilidades.ParametersX_Global(1) = New SqlParameter("@Cve_Sistema", x.Value)
                Value = Utilidades.EjecutarProcedure_Id("pCLIENTES_SISTEMAS_G", "@PARAMETRO", Utilidades.ParametersX_Global, , SqlDbType.VarChar, 50)
            End If
        Next
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Clientes.CellClick
        If e.RowIndex <> -1 Then
            If e.ColumnIndex = DGV_Editar.Index Then
                CargarDatos(e.RowIndex)
                CargarSistemas(DGV_Clientes.Item(colCve_Cliente.Index, e.RowIndex).Value)
            End If
        End If
    End Sub

    Sub CargarDatos(index As Integer)
        TBClave.Text = "" & DGV_Clientes.Item(colCve_Cliente.Index, index).Value
        TBAlias.Text = "" & DGV_Clientes.Item(colAlias.Index, index).Value
        TBNombre.Text = "" & DGV_Clientes.Item(colNombre_Cliente.Index, index).Value
        TBXPDUser.Text = "" & DGV_Clientes.Item(colFACTORUM_USER.Index, index).Value
        TBXPDUserPass.Text = "" & DGV_Clientes.Item(colContrasenafact.Index, index).Value
        Chk_Habilitado.Checked = DGV_Clientes.Item(colHabilitado.Index, index).Value
        Num_Timbres.Text = DGV_Clientes.Item(colCant_Timbres.Index, index).Value
    End Sub

    Sub CargarSistemas(Cve_Cliente As String)
        ChkList_Sistemas.ClearSelected()
        For i = 0 To ChkList_Sistemas.Items.Count - 1
            ChkList_Sistemas.SetItemChecked(i, False)
        Next
        Utilidades.Conectar()
        Dim cCommand As SqlCommand = New SqlCommand("pCLIENTES_SISTEMAS_B", Utilidades.cConnect)
        cCommand.CommandType = CommandType.StoredProcedure
        cCommand.Parameters.Add(New SqlParameter("@Cve_Cliente", Cve_Cliente))
        Dim oDataReader As SqlDataReader
        oDataReader = cCommand.ExecuteReader()
        While oDataReader.Read()

            For i = 0 To ChkList_Sistemas.Items.Count - 1
                If ChkList_Sistemas.Items.Item(i).ToString = oDataReader("Sistema") Then
                    ChkList_Sistemas.SetItemChecked(i, True)
                End If
            Next
        End While
        oDataReader.Close()
        Utilidades.Desconectar()
    End Sub

    Private Sub pictureContrasena_Click(sender As Object, e As EventArgs) Handles pictureContrasena.Click
        If TBXPDUserPass.InputType.Type = TextBoxType.Text Then
            TBXPDUserPass.InputType.Type = TextBoxType.Password
        Else
            TBXPDUserPass.InputType.Type = TextBoxType.Text
        End If
        'TBCLAVEP.InputType.Type = Not TextBoxType.Password
        Dim image As String = IIf(TBXPDUserPass.InputType.Type, "Resources\Images\Menu\25\eye.png", "Resources\Images\Menu\25\eye-slash.png")
        pictureContrasena.ImageSource = image
    End Sub
End Class
