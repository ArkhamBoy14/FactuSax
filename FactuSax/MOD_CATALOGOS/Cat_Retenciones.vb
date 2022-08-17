Imports System
Imports Wisej.Web
Imports System.Data
Imports System.Data.SqlClient

Public Class Cat_Retenciones
    Dim Command As New SqlCommand
    Dim Alertas As New Notificaciones

    Private Sub RibbonBar1_ItemClick(sender As Object, e As Ext.RibbonBar.RibbonBarItemEventArgs) Handles RibbonBar1.ItemClick
        Select Case e.Item.Name
            Case RBBActualizar.Name
                CargarCombos()
            Case RbbGuardar.Name
                Guardar()
            Case RbbSalir.Name
                Me.Close()
        End Select
    End Sub
    Private Sub Cat_Retenciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CargarCombos()
        ColocarDatos()
    End Sub

    Sub CargarCombos()
        ReDim Utilidades.ParametersX_Global(0)
        Utilidades.ParametersX_Global(0) = New SqlClient.SqlParameter("@Cve_Operador", Application.Session("Cve_Operador"))
        CbxClientes.LlenarListBox("pCAT_CLIENTES_B", "Cve_Cliente", "Nombre_Cliente", Utilidades.ParametersX_Global)
        CbxClientes.SelectedIndex = 0

    End Sub

    Sub ColocarDatos()
        If CbxClientes.SelectedIndex = -1 Then
            Alertas.NotificacionAdvertencia("Seleccione un cliente")
            Exit Sub
        End If
        Utilidades.Conectar()
        Dim DataReader As Data.SqlClient.SqlDataReader

        Try
            Command = New SqlClient.SqlCommand("pCAT_RETENCIONES_B", Utilidades.cConnect)
            Command.CommandType = CommandType.StoredProcedure
            Command.Parameters.AddWithValue("@Cve_Cliente", CbxClientes.SelectedValue)
            DataReader = Command.ExecuteReader(CommandBehavior.CloseConnection)
            If DataReader.HasRows Then
                While (DataReader.Read)

                    TasaoCuotaIVA.Text = DataReader.Item("TasaCuotaIVA")
                    MTBIVA.Text = DataReader.Item("ValorIVA")
                    Chk_AplicaIVA.Checked = DataReader.Item("AplicaIVA")
                    Chk_AplicaISR.Checked = DataReader.Item("AplicaISR")
                    TasaoCuotaISR.Text = DataReader.Item("TasaCuotaISR")
                    MTBISR.Text = DataReader.Item("ValorISR")
                    Chk_AplicaIEPS.Checked = DataReader.Item("AplicaIEPS")
                    TasaoCuotaIEPS.Text = DataReader.Item("TasaCuotaIEPS")
                    MTBIEPS.Text = DataReader.Item("ValorIEPS")


                End While
            Else

            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
            Exit Sub
        Finally
            If IsNothing(DataReader) = False Then
                If DataReader.IsClosed = False Then DataReader.Close()
            End If
            Utilidades.Desconectar()
        End Try

    End Sub

    Sub Guardar()
        Try
            If CbxClientes.SelectedIndex = -1 Then Exit Sub
            ReDim Utilidades.ParametersX_Global(9)
            Utilidades.ParametersX_Global(0) = New SqlParameter("@Cve_Cliente", CbxClientes.SelectedValue)
            Utilidades.ParametersX_Global(1) = New SqlParameter("@AplicaIVA", Chk_AplicaIVA.Checked)
            Utilidades.ParametersX_Global(2) = New SqlParameter("@TasaCuotaIVA", TasaoCuotaIVA.Text)
            Utilidades.ParametersX_Global(3) = New SqlParameter("@ValorIVA", Double.Parse(MTBIVA.Text))
            Utilidades.ParametersX_Global(4) = New SqlParameter("@AplicaISR", Chk_AplicaISR.Checked)
            Utilidades.ParametersX_Global(5) = New SqlParameter("@TasaCuotaISR", TasaoCuotaISR.Text)
            Utilidades.ParametersX_Global(6) = New SqlParameter("@ValorISR", Double.Parse(MTBISR.Text))
            Utilidades.ParametersX_Global(7) = New SqlParameter("@AplicaIEPS", Chk_AplicaIEPS.Checked)
            Utilidades.ParametersX_Global(8) = New SqlParameter("@TasaCuotaIEPS", TasaoCuotaIEPS.Text)
            Utilidades.ParametersX_Global(9) = New SqlParameter("@ValorIEPS", Double.Parse(MTBIEPS.Text))
            Dim reten = Utilidades.EjecutarProcedure_Id("pCAT_RETENCIONES_G", "@PARAMETRO", Utilidades.ParametersX_Global)
            If reten <> 0 Then
                Alertas.NotificacionExito("Valores de retenciones guardados con éxito", "Éxito")
                Me.Close()
            End If

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub CbxClientes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxClientes.SelectedIndexChanged
        ColocarDatos()
    End Sub
End Class
