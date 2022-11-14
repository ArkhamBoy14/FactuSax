Imports System.Data
Imports System.Data.SqlClient
Public Class CAT_SERIE_FOLIO_SAT_FACTURACION
    Dim sCve_Cliente As String

    Public Sub New(ByVal Cve_Cliente As String)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        sCve_Cliente = Cve_Cliente
    End Sub
    Private Sub RibbonBar1_ItemClick(sender As Object, e As Ext.RibbonBar.RibbonBarItemEventArgs) Handles RibbonBar1.ItemClick
        Select Case e.Item.Name
            Case RBBGuardar.Name
                guardar()
                CARGAR()
            Case RBBSalir.Name
                Me.Close()
        End Select
    End Sub

    Private Sub CAT_SERIE_FOLIO_SAT_FACTURACION_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ReDim Utilidades.ParametersX_Global(1)
        Utilidades.ParametersX_Global(0) = New SqlClient.SqlParameter("@Cve_Operador", Application.Session("Cve_Operador"))
        CbxClientes.LlenarListBox("pCAT_CLIENTES_B", "Cve_Cliente", "Nombre_Cliente", Utilidades.ParametersX_Global)
        CARGAR()
        'Utilidades.Llenar_Catalogos_Parametros("PCAT_SUCURSAL_B", "CLAVE", "descripcion", CSucursalindex, Utilidades.ParametersX_Global)
    End Sub

    Sub CARGAR()
        Me.DataSet_pCAT_SERIE_FOLIO_SAT_FACTURACION_B.Clear()
        Dim myDA = New SqlClient.SqlDataAdapter("[pCAT_SERIE_FOLIO_SAT_FACTURACION_B]", Utilidades.sConexion)
        myDA.SelectCommand.Parameters.AddWithValue("@Cve_Cliente", sCve_Cliente)
        myDA.SelectCommand.CommandType = CommandType.StoredProcedure

        myDA.Fill(Me.DataSet_pCAT_SERIE_FOLIO_SAT_FACTURACION_B.pCAT_SERIE_FOLIO_SAT_FACTURACION_B)
        myDA.Dispose()
    End Sub

    Sub guardar()

        ReDim Utilidades.ParametersX_Global(5)
        Utilidades.ParametersX_Global(1) = New SqlClient.SqlParameter("@folio", TBFolio.Text)
        Utilidades.ParametersX_Global(2) = New SqlClient.SqlParameter("@serie", TBSerie.Text)
        Utilidades.ParametersX_Global(3) = New SqlClient.SqlParameter("@Cve_Cliente", sCve_Cliente)
        Dim sDevuelveId = Utilidades.EjecutarProcedure_Id("[pCAT_SERIE_FOLIO_SAT_FACTURACION_G]", "@Parametro", Utilidades.ParametersX_Global, , SqlDbType.VarChar, 50)
        If sDevuelveId = "Guardado" Then
            MessageBox.Show("Registro Guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        ElseIf sDevuelveId = "Actualizado Folio" Then
            MessageBox.Show("Registro Actualizado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Else
            MessageBox.Show("Error", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
        End If
    End Sub

    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs)

    End Sub
End Class
