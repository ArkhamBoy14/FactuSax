Imports System
Imports Wisej.Web
Imports System.Data
Imports System.Data.SqlClient

Public Class Cat_Retenciones
    Private Sub RibbonBar1_ItemClick(sender As Object, e As Ext.RibbonBar.RibbonBarItemEventArgs) Handles RibbonBar1.ItemClick
        Select Case e.Item.Name
            Case RBBActualizar.Name
                Actualizar()
            Case RbbGuardar.Name
            Case RbbSalir.Name
                Me.Close()
        End Select
    End Sub
    Private Sub Cat_Retenciones_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Actualizar()
        CargarCombos()
        ColocarDatos()
    End Sub
    Sub Actualizar()
        Me.DataSet_pCAT_IMPUESTOS_SAT_FACTURACION_B.Clear()
        Try
            Dim myDA = New SqlDataAdapter("pCAT_IMPUESTOS_SAT_FACTURACION_B", Utilidades.sConexion)
            myDA.SelectCommand.CommandType = CommandType.StoredProcedure
            myDA.Fill(Me.DataSet_pCAT_IMPUESTOS_SAT_FACTURACION_B.pCAT_IMPUESTOS_SAT_FACTURACION_B)
            myDA.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Sub CargarCombos()
        CBSIVA.LlenarListBox("pCAT_IMPUESTOS_SAT_FACTURACION_B", "c_Impuesto", "DescripcionX")
        CBSIVA.SelectedValue = "001"
        CBSRISR.LlenarListBox("pCAT_IMPUESTOS_SAT_FACTURACION_B", "c_Impuesto", "DescripcionX")
        CBSRISR.SelectedValue = "002"
        CBSRIVA.LlenarListBox("pCAT_IMPUESTOS_SAT_FACTURACION_B", "c_Impuesto", "DescripcionX")
        CBSRIVA.SelectedValue = "003"


    End Sub

    Sub ColocarDatos()
        TasaoCuotaIVA.SelectedItem = CBSIVA.ObtenerDescripcion("TasaOCuota")
        TasaoCuotaISR.SelectedItem = CBSRISR.ObtenerDescripcion("TasaOCuota")
        TasaoCuotaRIVA.SelectedItem = CBSRIVA.ObtenerDescripcion("TasaOCuota")

        MTBIVA.Text = CBSIVA.ObtenerDescripcion("Valor")
        MTBRISR.Text = CBSRISR.ObtenerDescripcion("Valor")
        MTBRIVA.Text = CBSRIVA.ObtenerDescripcion("Valor")

        Chk_AplicaIVA.Checked = CBSIVA.ObtenerDescripcion("Valor")
        Chk_AplicaISR.Checked = CBSRISR.ObtenerDescripcion("Valor")
        Chk_AplicaIEPS.Checked = CBSRIVA.ObtenerDescripcion("Valor")

    End Sub


End Class
