Imports System.Data
Imports System.Data.SqlClient
Imports System.IO
Public Class Cat_RFC_EMISOR_SAT_FACTURACION
    'Dim Utilidades As New dllData
    Dim ParametersX_Global() As System.Data.SqlClient.SqlParameter
    Public isSelected As Boolean = False
    Dim x As String
    Dim y As String
    Dim c As Integer
    Dim modifico As Boolean
    Dim existe2 As Boolean = False
    Dim cambio As Boolean
    Dim dt_cambiado As DataTable
    Dim RFC2 As String
    Dim RowIndex As Integer
    Dim rowindex2 As Integer = -1
    Dim boton As String
    Public ME_EMISOR_RECEPTOR As String
    Public ME_EMPRESA As String
    Dim URL_Relativa_Key, URL_Relativa_Cer As String

    Sub New(Emisor_Receptor As Boolean, Empresa As Boolean)

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        Application.Session("ME_EMISOR_RECEPTOR") = Emisor_Receptor
        ME_EMISOR_RECEPTOR = Emisor_Receptor
        ME_EMPRESA = Empresa
    End Sub
    Sub New()

        ' Esta llamada es exigida por el diseñador.
        InitializeComponent()

        ' Agregue cualquier inicialización después de la llamada a InitializeComponent().
        ME_EMISOR_RECEPTOR = Application.Session("ME_EMISOR_RECEPTOR")
        ME_EMPRESA = False
    End Sub

    Private Sub Cat_RFC_Load() Handles Me.Load
        SubCatalogos()
        SubConsultar()
        'SplitContainer1.Panel1MinSize = "150"
        If ME_EMISOR_RECEPTOR = True Then
            GBEmisor.Visible = True
            'DataGridView1.Visible = False
            'SplitContainer1.Panel2Collapsed = True
            CARGAR_EMISOR()
            lbReceptor.Visible = False
            CbxReceptor.Visible = False
        Else
            GBEmisor.Visible = False
            lbReceptor.Visible = True
            CbxReceptor.Visible = True
        End If

        If ME_EMPRESA = True Then
            Utilidades.ParametersX_Global(0) = New SqlClient.SqlParameter("@Cve_Cliente", Application.Session("Cve_Cliente"))
            CbxReceptor.LlenarListBox("pFACTURACION_EMPRESA", "Cve_Receptor", "ReceptorX", Utilidades.ParametersX_Global)
        Else
            CbxReceptor.LlenarListBox("pFACTURACION_RECEPTOR", "Cve_Receptor", "ReceptorX")
        End If

        If Not String.IsNullOrWhiteSpace(Application.Session("Cve_Cliente")) Then
            CbxReceptor.SelectedValue = Application.Session("Cve_Cliente")
            CbxReceptor.Enabled = False
        End If
        ReDim Utilidades.ParametersX_Global(0)
        Utilidades.ParametersX_Global(0) = New SqlClient.SqlParameter("@Cve_Operador", Application.Session("Cve_Operador"))
        CbxClientes.LlenarListBox("pCAT_CLIENTES_B", "Cve_Cliente", "Nombre_Cliente", Utilidades.ParametersX_Global)
        CbxClientes.SelectedIndex = 0
        'dt_cambiado = New DataTable
        'dt_cambiado.Columns.Add("Valor")
        'dt_cambiado.Columns.Add("posicion")

    End Sub


    Private Sub RibbonBar1_ItemClick(sender As Object, e As Ext.RibbonBar.RibbonBarItemEventArgs) Handles RibbonBar1.ItemClick


        Select Case e.Item.Name

            Case RBBNuevo.Name
                TxtRFC.Enabled = True
                RBBI_Guardar.Text = "Guardar"
                Me.Tag = Nothing
                SubCatalogos()


                TxtRFC.Clear()
                TxtRazonSocial.Clear()
                TxtTelefono.Clear()
                Txtmail.Clear()
                TxtCalle.Clear()
                TxtNo_Exterior.Clear()
                TxtNo_Interior.Clear()
                MTBCP.Clear()
                TxtColonia.Clear()
                TxtLocalidad.Clear()
                'cbbEstado.Clear()
                cbbMunicipio.SelectedIndex = -1
                cbbEstado.SelectedIndex = -1

                TxtRFC.Enabled = True
                CBBSRegimen.SelectedIndex = -1
                TBKey.Text = Nothing
                TBCer.Text = Nothing
                TBCLAVEP.Text = Nothing
                ErrorProvider1.SetError(TxtRFC, Nothing)
                ErrorProvider1.SetError(TxtRazonSocial, Nothing)
                ErrorProvider1.SetError(TxtTelefono, Nothing)
                ErrorProvider1.SetError(Txtmail, Nothing)
                ErrorProvider1.SetError(TxtCalle, Nothing)
                ErrorProvider1.SetError(TxtNo_Exterior, Nothing)
                ErrorProvider1.SetError(TxtNo_Interior, Nothing)
                ErrorProvider1.SetError(MTBCP, Nothing)
                ErrorProvider1.SetError(TxtColonia, Nothing)
                ErrorProvider1.SetError(cbbEstado, Nothing)
                ErrorProvider1.SetError(cbbMunicipio, Nothing)
                ErrorProvider1.SetError(TxtLocalidad, Nothing)
                ErrorProvider1.SetError(Opc_Tipo_Moral, Nothing)
                ErrorProvider1.SetError(Opc_Tipo_Fisica, Nothing)
                ErrorProvider1.SetError(CBBSRegimen, Nothing)
                Opc_Tipo_Moral.Checked = True
                Opc_Tipo_Fisica.Checked = True
                ErrorProvider1.SetError(CBBSRegimen, Nothing)
                ErrorProvider1.SetError(TBKey, Nothing)
                ErrorProvider1.SetError(TBCer, Nothing)
                ErrorProvider1.SetError(TBCLAVEP, Nothing)
            Case RBBGuardar.Name
                Verificar()

            Case RBBSalir.Name
                Me.Close()


            Case "Imprimir"
                'imprimir()
        End Select
    End Sub
    'Sub imprimir()



    '    Dim sReportName, sProcedureName, sWhere, X As String
    '    Dim bTipoReporte As Boolean = True
    '    sReportName = "R_RFC_DATOS"

    '    sProcedureName = "pCAT_RFC_B"

    '    sWhere = "@RFC='" & TxtRFC.Text & "'"


    '    If Trim(sReportName) <> Nothing Then
    '        AspPageBox1.Path = Nothing
    '        Application.Session("ReportName") = sReportName
    '        Application.Session("ProcedureName") = sProcedureName & Space(1) & sWhere
    '        Application.Session("DocumentCached") = Nothing
    '        AspPageBox1.Path = "ReportView.aspx"
    '        Me.AspPageBox1.Update()
    '    End If



    ''End Sub






    Sub SubConsultar()
        ME_EMISOR_RECEPTOR = Application.Session("ME_EMISOR_RECEPTOR")
        ME_EMPRESA = False
        Try
            Me.DataSet_pCAT_RFC_EMISOR_SAT_FACTURACION_B.Clear()
            Dim myDA As New SqlDataAdapter
            If ME_EMISOR_RECEPTOR = True Then
                myDA = New SqlClient.SqlDataAdapter("[pCAT_RFC_EMISOR_SAT_FACTURACION_B]", Utilidades.sConexion)
            Else
                myDA = New SqlClient.SqlDataAdapter("[pCAT_RFC_receptor_SAT_FACTURACION_B]", Utilidades.sConexion)
            End If
            'myDA.SelectCommand.Parameters.AddWithValue("@Estatus", True)
            myDA.SelectCommand.Parameters.AddWithValue("@Cve_Cliente", Application.Session("Cve_Cliente"))
            If rbHabilitado.Checked Then
                myDA.SelectCommand.Parameters.AddWithValue("@Estatus", True)
            Else
                myDA.SelectCommand.Parameters.AddWithValue("@Estatus", False)

            End If
            myDA.SelectCommand.CommandType = CommandType.StoredProcedure
            myDA.Fill(Me.DataSet_pCAT_RFC_EMISOR_SAT_FACTURACION_B.pCAT_RFC_EMISOR_SAT_FACTURACION_B)
            myDA.Dispose()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try

    End Sub

    Sub SubCatalogos()

        'Utilidades.Llenar_Listbox("pCAT_ESTADOS_B", "Cve_Estado", "Estado", cbbEstado, , True)
        cbbEstado.LlenarListBox("pCAT_ESTADOS_B", "Cve_Estado", "Estado")
        'Utilidades.Llenar_Listbox("pCAT_REEGIMENFISCAL_SAT_FACTURACION", "c_RegimenFiscal", "descripcionx", CBBSRegimen, , True)
        CBBSRegimen.LlenarListBox("pCAT_REEGIMENFISCAL_SAT_FACTURACION", "c_RegimenFiscal", "descripcionx")

    End Sub



    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit





        If IsDBNull(DataGridView1.CurrentRow.Cells(2).Value) Then
            DataGridView1.ClearSelection()
            SubConsultar()
            Exit Sub
        End If


        x = ""
        x = DataGridView1.CurrentRow.Cells(2).Value

        If rowindex2 <> e.RowIndex Then
            rowindex2 = e.RowIndex
            guardar_RFC()
        Else
            rowindex2 = -1


        End If


    End Sub

    Private Function existe(ByVal RFC As String) As Boolean
        Dim es As Boolean = False
        Utilidades.Conectar()
        Dim cDataReader As Data.SqlClient.SqlDataReader
        Try
            Utilidades.cCommand = New SqlClient.SqlCommand("[pCAT_RFC_EMISOR_SAT_FACTURACION_B]", Utilidades.cConnect)
            Utilidades.cCommand.CommandType = CommandType.StoredProcedure
            Utilidades.cCommand.Parameters.AddWithValue("@RFC", RFC)
            cDataReader = Utilidades.cCommand.ExecuteReader(CommandBehavior.CloseConnection)
            If cDataReader.HasRows Then
                es = True
            End If
        Catch ex As SystemException
            MessageBox.Show("Error: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Finally
            If IsNothing(cDataReader) = False Then
                If cDataReader.IsClosed = False Then cDataReader.Close()
            End If
            Utilidades.Desconectar()
        End Try
        Return es
    End Function
    Private Sub guardar_RFC()
        Dim p As String = ""
        Try



            If existe(DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value.Trim) = True And Trim(Me.Tag) = Nothing Then
                MessageBox.Show("El RFC " + DataGridView1.Rows(DataGridView1.CurrentRow.Index).Cells(2).Value + " ya existe en la base de datos ")
                DataGridView1.ClearSelection()
                Exit Sub

            End If

            If x <> y Then
                ReDim Utilidades.ParametersX_Global(3)
                Utilidades.ParametersX_Global(0) = New SqlClient.SqlParameter("@RFC", y)
                Utilidades.ParametersX_Global(1) = New SqlClient.SqlParameter("@RFC_2", x)

                p = Utilidades.EjecutarProcedure_Id("pCAT_ACTUALIZA_RFC", "@Parametro", Utilidades.ParametersX_Global, True, SqlDbType.VarChar, 15)
            End If
            If p <> "" Or p <> Nothing Then
                modifico = True
            Else
                modifico = False
                For i As Integer = 0 To dt_cambiado.Rows.Count - 1
                    If dt_cambiado.Rows(i).Item(0) = x Then
                        dt_cambiado.Rows(i).Delete()
                    End If
                Next
                Exit Sub
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
        x = ""
        y = ""
        'DataGridView1.Update()

        MessageBox.Show("RFC ACTUALIZADA", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Information)

        DataGridView1.ClearSelection()
    End Sub
    Private Sub DataGridView1_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim sTipo_Persona As String

        y = ""
        y = DataGridView1.CurrentRow.Cells(2).Value
        c = 0

        If e.ColumnIndex = 0 Then

            RFC2 = DataGridView1.Item(DGVRFC.Index, e.RowIndex).Value
            Dim result As DialogResult = MessageBox.Show("¿Desea eliminar el registro actual? " & vbCrLf & "RFC : " & DataGridView1.CurrentRow.Cells(DGVRFC.Index).Value &
            "", "CONFIRMACION", MessageBoxButtons.YesNo)
            If result = DialogResult.Yes Then
                msgBoxHandler()
            End If
            'MessageBox.Show("¿Desea eliminar el registro actual? " & vbCrLf & "RFC : " & DataGridView1.CurrentRow.Cells(DGVRFC.Index).Value & "", "CONFIRMACION", MessageBoxButtons.YesNo, AddressOf msgBoxHandler)


        ElseIf e.ColumnIndex = 1 Then

            Me.Tag = DataGridView1.Item(DGVRFC.Index, e.RowIndex).Value
            TxtRFC.Text = DataGridView1.Item(DGVRFC.Index, e.RowIndex).Value
            TxtRazonSocial.Text = DataGridView1.Item(DGVRazon_Social.Index, e.RowIndex).Value
            TxtTelefono.Text = DataGridView1.Item(DGVTelefono.Index, e.RowIndex).Value
            Txtmail.Text = DataGridView1.Item(DGVE_Mail.Index, e.RowIndex).Value
            TxtCalle.Text = DataGridView1.Item(DGVCalle.Index, e.RowIndex).Value
            TxtNo_Exterior.Text = DataGridView1.Item(DGVNo_Exterior.Index, e.RowIndex).Value
            TxtNo_Interior.Text = DataGridView1.Item(DGVNo_Interior.Index, e.RowIndex).Value
            MTBCP.Text = DataGridView1.Item(DGVCodigo_Postal.Index, e.RowIndex).Value
            TxtColonia.Text = DataGridView1.Item(DGVColonia.Index, e.RowIndex).Value
            cbbEstado.SelectedValue = DataGridView1.Item(DGVCve_estado.Index, e.RowIndex).Value
            cbbMunicipio.SelectedValue = DataGridView1.Item(DGVCve_Municipio.Index, e.RowIndex).Value
            TxtLocalidad.Text = DataGridView1.Item(DGVLocalidad.Index, e.RowIndex).Value
            sTipo_Persona = DataGridView1.Item(DGVTipo_Persona.Index, e.RowIndex).Value
            CBBSRegimen.SelectedValue = IIf(DataGridView1.Item(DGVCRegimen.Index, e.RowIndex).Value = 1, -1, DataGridView1.Item(DGVCRegimen.Index, e.RowIndex).Value)
            'CbxReceptor.SelectedValue = DataGridView1.Item(cCve_Receptor.Index, e.RowIndex).Value
            CbxReceptor.Text = DataGridView1.Item(cReceptorX.Index, e.RowIndex).Value
            If ME_EMISOR_RECEPTOR = True Then
                CBBSRegimen.SelectedValue = DataGridView1.Item(DGVCRegimen.Index, e.RowIndex).Value
            End If
            If ME_EMISOR_RECEPTOR = True Then
                TBKey.Text = DataGridView1.Item(DGVCLlave.Index, e.RowIndex).Value
                TBCer.Text = DataGridView1.Item(DGVCCer.Index, e.RowIndex).Value
            End If

            If sTipo_Persona = "MORAL" Then
                Opc_Tipo_Moral.Checked = True
            Else
                Opc_Tipo_Fisica.Checked = True
            End If
            Chk_Habilitado.Checked = DataGridView1.Item(DGVEstatus.Index, e.RowIndex).Value

            RBBI_Guardar.Text = "Actualizar"
            TxtRFC.Enabled = False
            TBCLAVEP.Text = IIf(IsDBNull(DataGridView1.Item(ClavePrivada.Index, e.RowIndex).Value), "", (DataGridView1.Item(ClavePrivada.Index, e.RowIndex).Value))
            'CBProdefecto.Checked = IIf(IsDBNull(DataGridView1.Item(PorDefecto.Index, e.RowIndex).Value), False, DataGridView1.Item(PorDefecto.Index, e.RowIndex).Value)


        End If
        ' DataGridView1.ClearSelection()
    End Sub

    Private Sub msgBoxHandler()
        ''Dim msgForm As Form = TryCast(sender, Form)
        'If msgForm IsNot Nothing Then
        '    If msgForm.DialogResult = DialogResult.Yes Then
        ReDim Utilidades.ParametersX_Global(2)
        Utilidades.ParametersX_Global(0) = New SqlClient.SqlParameter("@RFC", RFC2)


        If Utilidades.EjecutarProcedure_Id("pCAT_RFC_EMISOR_SAT_FACTURACION_E", "@PARAMETRO", Utilidades.ParametersX_Global, False) Then
            SubConsultar()


            TxtRFC.Clear()
            TxtRazonSocial.Clear()
            TxtTelefono.Clear()
            Txtmail.Clear()
            TxtCalle.Clear()
            TxtNo_Exterior.Clear()
            TxtNo_Interior.Clear()
            MTBCP.Clear()
            TxtColonia.Clear()
            TxtLocalidad.Clear()
            cbbEstado.Clear()
            cbbMunicipio.SelectedIndex = -1
            cbbEstado.SelectedIndex = -1
            Rinactivo.Checked = False
            Ractivo.Checked = False
            TxtRFC.Enabled = True
            CBBSRegimen.SelectedIndex = -1
            TBKey.Text = Nothing
            TBCer.Text = Nothing
            TBCLAVEP.Text = Nothing
            'CBProdefecto.Checked = False

        End If

        '    End If
        'End If
    End Sub
    Sub guardar(sender As Object, e As EventArgs)
        Try

            Dim msgForm As Form = TryCast(sender, Form)
            If msgForm IsNot Nothing Then
                If msgForm.DialogResult = DialogResult.Yes Then
                    GuardarRegistro()

                End If
            Else
                GuardarRegistro()

            End If


        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub


    Sub GuardarRegistro()


        If TxtRFC.Enabled Then

            For i As Integer = 0 To Me.DataSet_pCAT_RFC_EMISOR_SAT_FACTURACION_B.pCAT_RFC_EMISOR_SAT_FACTURACION_B.Rows.Count - 1

                If TxtRFC.Text.ToUpper = DataSet_pCAT_RFC_EMISOR_SAT_FACTURACION_B.pCAT_RFC_EMISOR_SAT_FACTURACION_B.Rows(i).Item("RFC").ToString.ToUpper Then

                    MessageBox.Show("El RFC Ya Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)

                    Exit Sub

                End If

            Next

        End If

        Dim sDevuelveId As String
        Try
            ReDim Utilidades.ParametersX_Global(20)


            Utilidades.ParametersX_Global(0) = New SqlClient.SqlParameter("@RFC", TxtRFC.Text)
            Utilidades.ParametersX_Global(1) = New SqlClient.SqlParameter("@Razon_Social", TxtRazonSocial.Text)
            Utilidades.ParametersX_Global(2) = New SqlClient.SqlParameter("@Telefono", TxtTelefono.Text)
            Utilidades.ParametersX_Global(3) = New SqlClient.SqlParameter("@E_Mail", Txtmail.Text)
            Utilidades.ParametersX_Global(4) = New SqlClient.SqlParameter("@Calle", TxtCalle.Text)
            Utilidades.ParametersX_Global(5) = New SqlClient.SqlParameter("@No_Exterior", TxtNo_Exterior.Text)
            Utilidades.ParametersX_Global(6) = New SqlClient.SqlParameter("@No_Interior", TxtNo_Interior.Text)
            Utilidades.ParametersX_Global(7) = New SqlClient.SqlParameter("@Codigo_Postal", MTBCP.Text)
            Utilidades.ParametersX_Global(8) = New SqlClient.SqlParameter("@Colonia", TxtColonia.Text)
            Utilidades.ParametersX_Global(9) = New SqlClient.SqlParameter("@Estado ", IIf(cbbEstado.SelectedIndex = -1, 27, cbbEstado.SelectedValue))
            Utilidades.ParametersX_Global(10) = New SqlClient.SqlParameter("@Municipio", IIf(cbbMunicipio.SelectedIndex = -1, 4, cbbMunicipio.SelectedValue))
            Utilidades.ParametersX_Global(11) = New SqlClient.SqlParameter("@Localidad", TxtLocalidad.Text)

            If ME_EMISOR_RECEPTOR = True Then
                Utilidades.ParametersX_Global(12) = New SqlClient.SqlParameter("@LLAVE", TBKey.Text)
                Utilidades.ParametersX_Global(13) = New SqlClient.SqlParameter("@REGIMEN", CBBSRegimen.SelectedValue)
                Utilidades.ParametersX_Global(14) = New SqlClient.SqlParameter("@CER", TBCer.Text)
                Utilidades.ParametersX_Global(15) = New SqlClient.SqlParameter("@clave_privada", TBCLAVEP.Text)
                Utilidades.ParametersX_Global(16) = New SqlClient.SqlParameter("@default", 1)
                Utilidades.ParametersX_Global(20) = New SqlClient.SqlParameter("@Cve_Cliente", CbxClientes.SelectedValue)


            Else
                'Utilidades.ParametersX_Global(12) = New SqlClient.SqlParameter("@Cve_Receptor", CbxReceptor.SelectedValue)
                'Utilidades.ParametersX_Global(13) = New SqlClient.SqlParameter("@Receptor_Descripcion", CbxReceptor.ObtenerDescripcion("Recptor_Descripcion"))

            End If



            Utilidades.ParametersX_Global(17) = New SqlClient.SqlParameter("@Estatus", IIf(Chk_Habilitado.Checked, 1, 0))
            If Opc_Tipo_Fisica.Checked = True Then
                Utilidades.ParametersX_Global(18) = New SqlClient.SqlParameter("@Tipo_Persona", "FISICA")
            Else
                Utilidades.ParametersX_Global(19) = New SqlClient.SqlParameter("@Tipo_Persona", "MORAL")
            End If


            If ME_EMISOR_RECEPTOR = True Then
                sDevuelveId = Utilidades.EjecutarProcedure_Id("[pCAT_RFC_EMISOR_SAT_FACTURACION_G]", "@Parametro", Utilidades.ParametersX_Global, , SqlDbType.VarChar, 50)
            Else
                sDevuelveId = Utilidades.EjecutarProcedure_Id("[pCAT_RFC_RECEPTOR_SAT_FACTURACION_G]", "@Parametro", Utilidades.ParametersX_Global, , SqlDbType.VarChar, 50)

            End If


            If Trim(sDevuelveId) <> Nothing And Trim(sDevuelveId) <> "0" Then
                Application.Session("RFC_obtenido") = sDevuelveId
                isSelected = True
                TxtRFC.Enabled = False
                Me.Tag = sDevuelveId
                SubConsultar()
                Dim stipoPerosna As String = IIf(Opc_Tipo_Fisica.Checked, "FISICA", "MORAL")
                Dim sBody As String = String.Format("rfc={0}&razon_social={1}&telefono={2}&email´={3}&tipo_persona´={3}&contratadas´={3}", TxtRFC.Text, TxtRazonSocial.Text, TxtTelefono.Text, Txtmail.Text, stipoPerosna, 0)

                MessageBox.Show("Registro Guardado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            ElseIf sDevuelveId = "-1" Then
                MessageBox.Show("La Clave Ya Existe", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            Else
                MessageBox.Show("Este registro 'NO' se guardo, satisfactoriamente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try



    End Sub





    Function Verificar() As Boolean
        ErrorProvider1.SetError(TxtRFC, Nothing)
        ErrorProvider1.SetError(TxtRazonSocial, Nothing)
        ErrorProvider1.SetError(TxtTelefono, Nothing)
        ErrorProvider1.SetError(Txtmail, Nothing)
        ErrorProvider1.SetError(TxtCalle, Nothing)
        ErrorProvider1.SetError(TxtNo_Exterior, Nothing)
        ErrorProvider1.SetError(TxtNo_Interior, Nothing)
        ErrorProvider1.SetError(MTBCP, Nothing)
        ErrorProvider1.SetError(TxtColonia, Nothing)
        ErrorProvider1.SetError(cbbEstado, Nothing)
        ErrorProvider1.SetError(cbbMunicipio, Nothing)
        ErrorProvider1.SetError(TxtLocalidad, Nothing)
        ErrorProvider1.SetError(Opc_Tipo_Moral, Nothing)
        ErrorProvider1.SetError(Opc_Tipo_Fisica, Nothing)

        ErrorProvider1.SetError(CBBSRegimen, Nothing)
        ErrorProvider1.SetError(TBKey, Nothing)
        ErrorProvider1.SetError(TBCer, Nothing)

        ErrorProvider1.SetError(TBCLAVEP, Nothing)


        Verificar = True
        For Each item In GroupBox5.Controls
            If item.name = "TxtNo_Interior" Then Continue For
            If item.name = "TxtLocalidad" Then Continue For
            If item.name = "TxtTelefono" Then Continue For
            If item.name = "TxtCalle" Then Continue For
            If item.name = "TxtNo_Exterior" Then Continue For
            If item.name = "MTBCP" Then Continue For
            If item.name = "TxtColonia" Then Continue For
            If item.name = "cbbEstado" Then Continue For
            If item.name = "cbbMunicipio" Then Continue For
            If item.name = "Txtmail" Then Continue For



            If TypeOf item Is TextBox Then
                If item.name = "MTBCP" Then
                    Dim st As String = item.text
                    If Len(st) <> 5 Then
                        ErrorProvider1.SetError(item, "Dato Requerido")
                        Verificar = False
                        Exit Function
                    End If

                Else
                    If item.text = Nothing Then
                        ErrorProvider1.SetError(item, "Dato Requerido")
                        Verificar = False
                        Exit Function
                    End If
                End If


                'ElseIf TypeOf item Is ComboWisax Then
                '    If item.SelectedINDEX = -1 Then
                '        ErrorProvider1.SetError(item, "Dato Requerido")
                '        Verificar = False
                '        Exit Function
                '    End If
            End If

        Next
        If GBEmisor.Visible = True Then
            For Each item In GBEmisor.Controls
                If TypeOf item Is TextBox Then
                    If item.text = Nothing Then
                        ErrorProvider1.SetError(item, "Dato Requerido")
                        Verificar = False
                        Exit Function
                    End If
                ElseIf TypeOf item Is combosax Then
                    If item.SelectedINDEX = -1 Then
                        ErrorProvider1.SetError(item, "Dato Requerido")
                        Verificar = False
                        Exit Function
                    End If
                End If
            Next
        End If
        If Opc_Tipo_Moral.Checked = False And Opc_Tipo_Fisica.Checked = False Then
            ErrorProvider1.SetError(Opc_Tipo_Moral, "Dato Requerido")
            ErrorProvider1.SetError(Opc_Tipo_Fisica, "Dato Requerido")
            Verificar = False
            Exit Function
        End If

        guardar(1, Nothing)

        If Application.Session("COBRANZA") Then
            Application.Session("RFC") = TxtRFC.Text

        End If

        'If Dataset_pCAT_RFC_B1.Tables(0).Select("RFC  like '%" & TxtRFC.Text & "%'").Length > 0 Then
        '    'MessageBox.Show("¿Desea Actualizar? ", "Confirmación", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question, AddressOf guardar)
        'Else
        '    guardar(1, Nothing)
        'End If
        'If EMISOR_RECEPTOR = "EMISOR" Then


        '    For i As Integer = 0 To DataGridView1.Rows.Count - 1
        '        If DataGridView1.Item(DGVRFC.Index, i).Value <> TxtRFC.Text Then
        '            If DataGridView1.Item(PorDefecto.Index, i).Value = True Then
        '                CBProdefecto.Checked = False
        '                MessageBox.Show("Ya existe un valor por defecto " & DataGridView1.Item(DGVRFC.Index, i).Value)

        '            End If
        '        End If

        '    Next
        'End If

        Return Verificar
    End Function
    Private Sub cbbEstado_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbbEstado.SelectedIndexChanged
        If cbbEstado.SelectedIndex = -1 Then Exit Sub

        ReDim Utilidades.ParametersX_Global(0)
        Utilidades.ParametersX_Global(0) = New SqlClient.SqlParameter("@Cve_Estado", cbbEstado.SelectedValue)

        'Utilidades.Llenar_Listbox("pCAT_MUNICIPIOS_B", "Cve_Municipio", "Municipio", cbbMunicipio, Utilidades.ParametersX_Global)
        cbbMunicipio.LlenarListBox("pCAT_MUNICIPIOS_B", "Cve_Municipio", "Municipio", Utilidades.ParametersX_Global)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)
        boton = sender.name.replace("BT", "").trim
        ErrorProvider1.SetError(TxtRFC, Nothing)
        If TxtRFC.Text = Nothing Then
            ErrorProvider1.SetError(TxtRFC, "Es necesario este dato")
            Exit Sub
        End If
        Dim ofd As New OpenFileDialog
        AddHandler ofd.FileOk, AddressOf archivos
        ofd.ShowDialog()

    End Sub

    Sub archivos(sender As OpenFileDialog, e As Object)
        Try


            Dim archivos = sender.FileNames
            Dim PATH = HttpContext.Current.Server.MapPath("~\Resources\SAT\")
            If (Not System.IO.Directory.Exists(PATH & TxtRFC.Text & "\")) Then
                System.IO.Directory.CreateDirectory(PATH & TxtRFC.Text & "\")



            End If
            Dim ARCHIVO = sender.FileName
            If Not System.IO.File.Exists(PATH & TxtRFC.Text & "\" & TxtRFC.Text & "." & boton) Then
                System.IO.File.Copy(sender.FileName, PATH & TxtRFC.Text & "\" & TxtRFC.Text & "." & boton)
            End If

            Select Case boton
                Case "Key"
                    TBKey.Text = TxtRFC.Text & "." & boton
                Case "Cer"
                    TBCer.Text = TxtRFC.Text & "." & boton
            End Select

        Catch ex As Exception

        End Try
    End Sub


    Sub CARGAR_EMISOR()
        If DataGridView1.Rows.Count <> 0 Then


            Dim stipo_persona As String
            Dim ROWINDEX = 0
            Me.Tag = DataGridView1.Item(DGVRFC.Index, ROWINDEX).Value
            TxtRFC.Text = DataGridView1.Item(DGVRFC.Index, ROWINDEX).Value
            TxtRazonSocial.Text = DataGridView1.Item(DGVRazon_Social.Index, ROWINDEX).Value
            TxtTelefono.Text = DataGridView1.Item(DGVTelefono.Index, ROWINDEX).Value
            Txtmail.Text = DataGridView1.Item(DGVE_Mail.Index, ROWINDEX).Value
            TxtCalle.Text = DataGridView1.Item(DGVCalle.Index, ROWINDEX).Value
            TxtNo_Exterior.Text = DataGridView1.Item(DGVNo_Exterior.Index, ROWINDEX).Value
            TxtNo_Interior.Text = DataGridView1.Item(DGVNo_Interior.Index, ROWINDEX).Value
            MTBCP.Text = DataGridView1.Item(DGVCodigo_Postal.Index, ROWINDEX).Value
            TxtColonia.Text = DataGridView1.Item(DGVColonia.Index, ROWINDEX).Value
            cbbEstado.SelectedValue = DataGridView1.Item(DGVCve_estado.Index, ROWINDEX).Value
            cbbMunicipio.SelectedValue = DataGridView1.Item(DGVCve_Municipio.Index, ROWINDEX).Value
            TxtLocalidad.Text = DataGridView1.Item(DGVLocalidad.Index, ROWINDEX).Value
            CBBSRegimen.SelectedValue = DataGridView1.Item(DGVCRegimen.Index, ROWINDEX).Value
            stipo_persona = DataGridView1.Item(DGVTipo_Persona.Index, ROWINDEX).Value
            If ME_EMISOR_RECEPTOR = "EMISOR" Then
                CBBSRegimen.SelectedValue = DataGridView1.Item(DGVCRegimen.Index, ROWINDEX).Value
            End If

            TBKey.Text = DataGridView1.Item(DGVCLlave.Index, ROWINDEX).Value
            TBCer.Text = DataGridView1.Item(DGVCCer.Index, ROWINDEX).Value
            If stipo_persona = "MORAL" Then
                Opc_Tipo_Moral.Checked = True
            Else
                Opc_Tipo_Fisica.Checked = True
            End If


            RBBI_Guardar.Text = "Actualizar"
            TxtRFC.Enabled = False
            TBCLAVEP.Text = IIf(IsDBNull(DataGridView1.Item(ClavePrivada.Index, ROWINDEX).Value), "", (DataGridView1.Item(ClavePrivada.Index, ROWINDEX).Value))
        End If
    End Sub

    Sub GUARDAR_RELACION_PACIENTE()
        ReDim Utilidades.ParametersX_Global(2)


        Utilidades.ParametersX_Global(0) = New SqlClient.SqlParameter("@RFC", TxtRFC.Text)
        Utilidades.ParametersX_Global(1) = New SqlClient.SqlParameter("@CVE_PACIENTE", TxtRazonSocial.Text)
        Dim sDevuelveId = Utilidades.EjecutarProcedure_Id("[pCAT_PACIENTE_RFC_SAT_G]", "@Parametro", Utilidades.ParametersX_Global, , SqlDbType.VarChar, 50)

    End Sub

    Private Sub Upload2_Uploaded(sender As Object, e As UploadedEventArgs) Handles Upload2.Uploaded
        Dim ArchivoOriginal = Application.StartupPath & "\Resources\SAT\" & TxtRFC.Text & "\" & TBKey.Text
        If File.Exists(ArchivoOriginal) Then
            TBCer.Text = Nothing
            'System.IO.File.Delete(ArchivoOriginal)
        End If
        URL_Relativa_Cer = "Resources\SAT\" & TxtRFC.Text
        Dim clave As Upload = CType(sender, Upload)
        Dim URL_Carpeta_Server_Key = Application.StartupPath & "\" & URL_Relativa_Cer
        If Not Directory.Exists(URL_Carpeta_Server_Key) Then
            Directory.CreateDirectory(URL_Carpeta_Server_Key)
        End If
        If e.Files.Count > 0 Then
            Dim ArchivoKey = DirectCast(e.Files(0), HttpPostedFile)
            Dim Extension = Path.GetExtension(ArchivoKey.FileName)
            Dim Archivo_RAW = Path.GetFileNameWithoutExtension(ArchivoKey.FileName)

            TBCer.Tag = Archivo_RAW & Extension
            If ArchivoKey.ContentLength > 0 Then
                Dim urlArchivoGuardado As String = System.IO.Path.Combine(Application.StartupPath, Application.StartupPath & "\" & URL_Relativa_Cer, TBCer.Tag)

                Try
                    ArchivoKey.SaveAs(urlArchivoGuardado)
                    TBCer.Text = Archivo_RAW & Extension
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Cargar archivo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub pictureContrasena_Click(sender As Object, e As EventArgs) Handles pictureContrasena.Click
        If TBCLAVEP.InputType.Type = TextBoxType.Text Then
            TBCLAVEP.InputType.Type = TextBoxType.Password
        Else
            TBCLAVEP.InputType.Type = TextBoxType.Text
        End If
        'TBCLAVEP.InputType.Type = Not TextBoxType.Password
        Dim image As String = IIf(TBCLAVEP.InputType.Type, "Resources\Images\Menu\25\eye.png", "Resources\Images\Menu\25\eye-slash.png")
        pictureContrasena.ImageSource = image
    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles rbHabilitado.CheckedChanged
        SubConsultar()
    End Sub

    Private Sub Upload1_Uploaded(sender As Object, e As UploadedEventArgs) Handles Upload1.Uploaded
        Dim ArchivoOriginal = Application.StartupPath & "\Resources\SAT\" & TxtRFC.Text & "\" & TBKey.Text
        If File.Exists(ArchivoOriginal) Then
            TBKey.Text = Nothing
            'System.IO.File.Delete(ArchivoOriginal)
        End If
        URL_Relativa_Key = "Resources\SAT\" & TxtRFC.Text
        Dim clave As Upload = CType(sender, Upload)
        Dim URL_Carpeta_Server_Key = Application.StartupPath & "\" & URL_Relativa_Key
        If Not Directory.Exists(URL_Carpeta_Server_Key) Then
            Directory.CreateDirectory(URL_Carpeta_Server_Key)
        End If
        If e.Files.Count > 0 Then
            Dim ArchivoKey = DirectCast(e.Files(0), HttpPostedFile)
            Dim Extension = Path.GetExtension(ArchivoKey.FileName)
            Dim Archivo_RAW = Path.GetFileNameWithoutExtension(ArchivoKey.FileName)

            TBKey.Tag = Archivo_RAW & Extension
            If ArchivoKey.ContentLength > 0 Then
                Dim urlArchivoGuardado As String = System.IO.Path.Combine(Application.StartupPath, Application.StartupPath & "\" & URL_Relativa_Key, TBKey.Tag)

                Try
                    ArchivoKey.SaveAs(urlArchivoGuardado)
                    TBKey.Text = Archivo_RAW & Extension
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Cargar archivo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If

    End Sub



    'Private Sub msgBoxHandler(ByVal sender As Object, ByVal e As EventArgs)
    '    Dim msgForm As Form = TryCast(sender, Form)
    '    If msgForm IsNot Nothing Then
    '        If msgForm.DialogResult = Gizmox.WebGUI.Forms.DialogResult.Yes Then
    '            ReDim Utilidades.ParametersX_Global(2)
    '            Utilidades.ParametersX_Global(2) = New SqlClient.SqlParameter("@RFC", DataGridView1.CurrentRow.Cells(DGVRFC.Index).Value)
    '            If Utilidades.fGuardar_O_EliminarXProcedure("pCAT_EMPRESAS_E", "@Parametro", Utilidades.ParametersX_Global, False, False) Then
    '                Consultar()
    '            Else
    '                MessageBox.Show("El RFC Contiene Resultados Almacenados", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
    '            End If
    '        End If

    '    End If
    'End Sub



End Class
