Imports System.IO
Imports System.Data
Imports System.Data.SqlClient
Imports System.Text.RegularExpressions
Imports System.Net.Mail
Imports System.Net
Imports System.Security.Cryptography.X509Certificates
Imports System.Security.Cryptography
Imports System.Net.Security
Imports System.Drawing
Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraPrinting
Imports Twilio
Imports Twilio.Rest.Api.V2010.Account
Imports Twilio.Types

Namespace Utilidades

#Region "Base de Datos"
    Module DataBase
        Public cConnect As New SqlClient.SqlConnection
        Public sConexion As String = System.Configuration.ConfigurationManager.ConnectionStrings("FacturasConnectionString").ConnectionString
        Public ParametersX_Global As SqlClient.SqlParameter() = {}
        Public Const sConstante_KEY = "$$SAXSOFT.COM_Y_FACTURAS$$"
        Public cCommand As New SqlCommand
        Dim cErrors As String
        Dim X As Integer
        Dim sPARAMETROS As String
        Dim alertas As New Notificaciones
        Public formulario As String




        Public Function ConexionAbierta() As Boolean
            Return (cConnect.State = ConnectionState.Open)

        End Function
        Public Function Conectar() As Boolean
            Try
                If cConnect.State = ConnectionState.Closed Then
                    cConnect.ConnectionString = sConexion
                    cConnect.Open()
                End If

            Catch ex As SystemException

            End Try
            Return ConexionAbierta()
        End Function

        Sub Desconectar()
            Try
                If cConnect.State <> ConnectionState.Closed Then cConnect.Close()

            Catch ex As SystemException
                Wisej.Web.MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                cErrors += " " & ex.Message
            End Try
        End Sub

        Public Function Login() As Boolean
            Dim Pass As Boolean = True
            Return Pass
        End Function

        Public Function Login(ByVal UserName As String, ByVal Password As String) As Boolean
            Try
                If Not Conectar() Then Return False
                If ConexionAbierta() Then

                    ReDim ParametersX_Global(2)
                    ParametersX_Global(0) = New Data.SqlClient.SqlParameter("@Cve_Operador", UserName)
                    ParametersX_Global(1) = New Data.SqlClient.SqlParameter("@Contrasena", Password)
                    ParametersX_Global(2) = New Data.SqlClient.SqlParameter("@PassphraseEnteredByUser", sConstante_KEY)

                    If EjecutarProcedure("pLOGIN", "@Parametro", ParametersX_Global, False) Then
                        Login = True
                    Else
                        Login = False
                    End If
                Else
                    Login = False
                End If
            Catch ex As Exception
                Login = False
            End Try
        End Function
        Function EjecutarProcedure(ByVal sProcedureName As String, Optional ByVal sNombreCampoRetornar As String = Nothing, Optional ByVal cParams() As SqlClient.SqlParameter = Nothing, Optional ByVal bMostrarMensaje As Boolean = True, Optional ByVal bEsTexto As Boolean = False) As Boolean
            Dim i As Integer
            Conectar()
            Try
                Dim cCommand As SqlClient.SqlCommand = New SqlClient.SqlCommand(sProcedureName, cConnect)
                If bEsTexto Then
                    cCommand.CommandType = CommandType.Text
                Else
                    cCommand.CommandType = CommandType.StoredProcedure
                End If
                If cParams Is Nothing = False Then
                    For i = 0 To cParams.GetLength(0) - 1
                        If cParams(i) Is Nothing = False Then
                            cCommand.Parameters.Add(cParams(i))
                        End If
                    Next
                End If
                'cCommand.Parameters.Clear()

                '***********************************************************
                If Trim(sNombreCampoRetornar) <> Nothing Then
                    Dim parameterConsecutivo As New SqlParameter(sNombreCampoRetornar, SqlDbType.Int)
                    parameterConsecutivo.Direction = ParameterDirection.Output
                    cCommand.Parameters.Add(parameterConsecutivo)
                    '***********************************************************
                    ' Open the database connection and execute the command
                    cCommand.ExecuteNonQuery()
                    If Not parameterConsecutivo.Value Is Nothing And Not parameterConsecutivo.Value Is System.DBNull.Value Then
                        EjecutarProcedure = True

                    Else
                        EjecutarProcedure = False
                        If bMostrarMensaje Then
                            'Messagebox.show("Error al realizar la operación,por favor, intentelo de nuevo ",Utilidades.MessageBoxStyle.Information, "Aviso")
                            cErrors += " " & "Error al realizar la operación, por favor, intentelo de nuevo "
                        End If
                    End If
                Else
                    cCommand.ExecuteNonQuery()
                    EjecutarProcedure = True
                End If
                cCommand.Parameters.Clear()
            Catch ex As Exception
                MessageBox.Show("Error: " & ex.Message.ToString, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Finally
                Desconectar()
            End Try
        End Function

        Sub Llenar_Listbox(ByVal sNameProcedure As String, ByVal sId As String, ByVal sDescripcion As String, ByVal cControl As Object, Optional ByVal cParams() As SqlParameter = Nothing, Optional ByVal bEsText As Boolean = False)

            Dim parametros As String
            Try
                parametros = sNameProcedure
                If cParams Is Nothing = False Then
                    parametros = sNameProcedure
                    Dim s As String = " "
                    For i = 0 To cParams.GetLength(0) - 1
                        If cParams(i) Is Nothing = False Then

                            If cParams(i).DbType = DbType.String Then
                                parametros += s & cParams(i).ParameterName & "='" & cParams(i).Value & "'"
                            ElseIf cParams(i).DbType = DbType.Boolean Then
                                parametros += s & cParams(i).ParameterName & "=" & Convert.ToInt32(cParams(i).Value)
                            Else
                                parametros += s & cParams(i).ParameterName & "=" & cParams(i).Value
                            End If
                            s = ", "
                        End If
                    Next


                End If
                cControl.CLEAR()
                cControl.llenar_lis_nuevo(sId, sDescripcion, parametros, sConexion)
            Catch ex As SystemException

            Finally
            End Try
        End Sub
        Function EjecutarProcedure_Id(ByVal sProcedureName As String, ByVal sNombreCampoRetornar As String, Optional ByVal cParams() As SqlParameter = Nothing, Optional ByVal bMostrarMensaje As Boolean = True, Optional ByVal dbtype As System.Data.SqlDbType = SqlDbType.Int, Optional ByVal sSize As Integer = 0) As String
            Dim i As Integer
            Conectar()
            Dim sPARAMETROS As String
            Try
                Dim cCommand As SqlClient.SqlCommand = New SqlClient.SqlCommand(sProcedureName, cConnect)
                cCommand.CommandType = CommandType.StoredProcedure
                Dim sql As String = ""

                If cParams Is Nothing = False Then
                    For i = 0 To cParams.GetLength(0) - 1
                        If cParams(i) Is Nothing = False Then
                            If i = 0 Then
                                If cParams(i).SqlDbType = SqlDbType.NVarChar Then
                                    sPARAMETROS = sPARAMETROS & cParams(i).ToString & "='" & cParams(i).Value & "'"
                                ElseIf cParams(i).SqlDbType <> SqlDbType.Structured Then
                                    sPARAMETROS = sPARAMETROS & cParams(i).ToString & "=" & cParams(i).Value
                                End If
                            Else
                                If cParams(i).SqlDbType = SqlDbType.NVarChar Then
                                    sPARAMETROS = sPARAMETROS & "," & cParams(i).ToString & "='" & cParams(i).Value & "'"
                                ElseIf cParams(i).SqlDbType <> SqlDbType.Structured Then
                                    sPARAMETROS = sPARAMETROS & "," & cParams(i).ToString & "=" & cParams(i).Value
                                End If
                            End If
                            cCommand.Parameters.Add(cParams(i))


                            Console.WriteLine(cParams(i))

                        End If
                    Next
                End If

                sPARAMETROS = sPARAMETROS & "," & sNombreCampoRetornar & "= 0"




                '***********************************************************
                Dim parameterConsecutivo As New SqlParameter(sNombreCampoRetornar, dbtype, sSize)
                parameterConsecutivo.Direction = ParameterDirection.Output
                cCommand.Parameters.Add(parameterConsecutivo)
                '***********************************************************
                ' Open the database connection and execute the command
                cCommand.ExecuteNonQuery()
                If Not parameterConsecutivo.Value Is Nothing And Not parameterConsecutivo.Value Is System.DBNull.Value Then
                    EjecutarProcedure_Id = parameterConsecutivo.Value
                Else
                    EjecutarProcedure_Id = Nothing
                    If bMostrarMensaje Then
                        alertas.NotificacionError("No se puedo guardar", "Error")
                    End If
                End If
            Catch ex As Exception
                alertas.NotificacionError(ex.Message, "Aviso")
                Dim NumeroError As String
                NumeroError = Guardar_Error(Application.Session("name_modulo"), ex.Message, Application.Session("Cve_Operador"), sProcedureName & " " & sPARAMETROS & "", formulario)
                If bMostrarMensaje Then
                    alertas.NotificacionError(ex.Message, "Error")
                End If
                EjecutarProcedure_Id = Nothing
                cCommand.Dispose()
            Finally
                Desconectar()
            End Try
        End Function
        Sub LlenarGrillaProcedure(ByVal GridX As Object, ByVal sProcedureName As String, Optional ByVal cParams() As SqlParameter = Nothing, Optional ByVal sNameDataMember As String = Nothing, Optional ByVal bEsText As Boolean = False, Optional ByVal bMostrarMensaje As Boolean = True, Optional ByVal bEsLisBox As Boolean = False)
            If bMostrarMensaje Then
            End If
            Dim i As Integer
            Dim myDA As SqlDataAdapter
            Dim myDS As DataSet = New DataSet
            Try
                myDA = New Data.SqlClient.SqlDataAdapter(sProcedureName, sConexion)
                If bEsText Then
                    myDA.SelectCommand.CommandType = CommandType.Text
                Else
                    myDA.SelectCommand.CommandType = CommandType.StoredProcedure
                    If cParams Is Nothing = False Then
                        For i = 0 To cParams.GetLength(0) - 1
                            If cParams(i) Is Nothing = False Then
                                myDA.SelectCommand.Parameters.Add(cParams(i))
                            End If
                        Next
                    End If
                End If
                '-------------------------------
                If Trim(sNameDataMember) = Nothing Then
                    sNameDataMember = sProcedureName
                End If
                '-------------------------------
                myDA.Fill(myDS, sNameDataMember)
                '---------------------------
                'LIMPIO PREVIAMENTE LOS DATOS
                GridX.DataSource = Nothing
                '---------------------------
                With GridX
                    If TypeName(GridX) = "DataGridView" Then
                        .RowsDefaultCellStyle.BackColor = Color.White
                        .AlternatingRowsDefaultCellStyle.BackColor = Color.AliceBlue
                    End If
                    If Not bEsLisBox Then
                        .DataMember = sNameDataMember
                    End If

                    .DataSource = myDS
                End With
            Catch ex As SystemException
                'MessageBox("Error: " & ex.Message, MessageBoxStyle.Critical, "Aviso")
            Finally
                If bMostrarMensaje Then
                    '     dlg.Close()
                End If
                myDA.Dispose()
            End Try
        End Sub

        Function Guardar_Error(ByVal MODULO As String, ByVal SERROR As String, ByVal OPERADOR As String, ByVal PROCESO As String, ByVal FORMULARIO As String)
            Dim ERROR2 As Integer

            ReDim ParametersX_Global(5)
            ParametersX_Global(0) = New SqlClient.SqlParameter("@MODULO", MODULO)
            ParametersX_Global(1) = New SqlClient.SqlParameter("@ERROR", SERROR)
            ParametersX_Global(2) = New SqlClient.SqlParameter("@OPERADOR", OPERADOR)
            ParametersX_Global(3) = New SqlClient.SqlParameter("@PROCESO", PROCESO)
            ParametersX_Global(4) = New SqlClient.SqlParameter("@FORMULARIO", FORMULARIO)

            ERROR2 = EjecutarProcedure_Id("pERROR_SISTEMA_G", "@Parametro", ParametersX_Global, False, SqlDbType.Int, 50)

            'Dim f As Mbox = New Mbox()
            'f.invokesparametros("error", "Hubo un inconveniente, lamentamos que esto haya pasado favor de comunicarlo al soporte mediante el chat con el número: " + ERROR2.ToString, "SOPORTE MESA AYUDA")
            'f.Show()
            'f.Close()

            'MessageBox.Show("EXISTE UN ERROR", SERROR, MessageBoxButtons.OK, MessageBoxIcon.Error)
            MessageBox.Show(SERROR, "Existe un error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End Function

        Sub Llenar_Catalogos(ByVal sProcedureName As String, ByRef DataSetName As DataSet, ByVal sNameMethod As String, Optional ByVal cParams() As System.Data.SqlClient.SqlParameter = Nothing)
            Dim i As Integer
            Conectar()
            Dim sPARAMETROS As String
            Try
                DataSetName.Clear()
                Dim myDA = New SqlClient.SqlDataAdapter(sProcedureName, cConnect)
                myDA.SelectCommand.CommandType = CommandType.StoredProcedure
                Dim sql As String = ""
                If cParams Is Nothing = False Then
                    For i = 0 To cParams.GetLength(0) - 1
                        If cParams(i) Is Nothing = False Then


                            If i = 0 Then
                                If cParams(i).SqlDbType = SqlDbType.NVarChar Then
                                    sPARAMETROS = sPARAMETROS & cParams(i).ToString & "='" & cParams(i).Value & "'"
                                Else
                                    sPARAMETROS = sPARAMETROS & cParams(i).ToString & "=" & cParams(i).Value
                                End If
                            Else
                                If cParams(i).SqlDbType = SqlDbType.NVarChar Then
                                    sPARAMETROS = sPARAMETROS & "," & cParams(i).ToString & "='" & cParams(i).Value & "'"
                                Else
                                    sPARAMETROS = sPARAMETROS & "," & cParams(i).ToString & "=" & cParams(i).Value
                                End If
                            End If
                            myDA.SelectCommand.Parameters.AddWithValue(cParams(i).ToString, cParams(i).Value)
                        End If
                    Next
                End If
                myDA.Fill(DataSetName.Tables(0))
                myDA.Dispose()

                '***********************************************************
            Catch ex As Exception
                Dim NumeroError As String
                NumeroError = Guardar_Error(Application.Session("name_modulo"), ex.Message, Application.Session("Cve_Operador"), "/*METODO DETONADOR: " + sNameMethod + " CONSULTA: */" + sProcedureName & " " & sPARAMETROS & "", formulario)
            Finally
                Desconectar()
            End Try

        End Sub

        Function LlenarComboGridSax(ByVal ComboGridSax As ComboGridSax, ByVal BvDataset As DataTable, ByVal pProcedure As String, ByVal Grid As DataGridView, ByVal BvSelectedValue As String, ByVal BvSelectedItem As String, Optional ByVal cParams() As SqlParameter = Nothing) As Integer

            BvDataset.Clear()
            Dim myDA = New SqlClient.SqlDataAdapter(pProcedure, sConexion)
            myDA.SelectCommand.CommandType = CommandType.StoredProcedure

            Dim sPARAMETROS As String = ""
            If cParams Is Nothing = False Then
                For i = 0 To cParams.GetLength(0) - 1
                    If cParams(i) Is Nothing = False Then

                        myDA.SelectCommand.Parameters.Add(cParams(i))

                        If i = 0 Then
                            If cParams(i).SqlDbType = SqlDbType.NVarChar Then
                                sPARAMETROS = sPARAMETROS & cParams(i).ToString & "='" & cParams(i).Value & "'"
                            Else
                                sPARAMETROS = sPARAMETROS & cParams(i).ToString & "=" & cParams(i).Value
                            End If
                        Else
                            If cParams(i).SqlDbType = SqlDbType.NVarChar Then
                                sPARAMETROS = sPARAMETROS & "," & cParams(i).ToString & "='" & cParams(i).Value & "'"
                            Else
                                sPARAMETROS = sPARAMETROS & "," & cParams(i).ToString & "=" & cParams(i).Value
                            End If
                        End If
                    End If
                Next
            End If

            myDA.Fill(BvDataset)
            myDA.Dispose()

            ComboGridSax.AddGrid(Grid, BvSelectedValue, BvSelectedItem, pProcedure + " " + sPARAMETROS)

        End Function
        Function ObtenerDescripcion(ByVal cControl As Object, Optional ByVal sColumnaName As String = "Descripcion", Optional ByVal sColumnaWHERE As String = Nothing, Optional ByVal WHERE As String = Nothing) As String
            Dim SWHERE As String
            If cControl.SelectedIndex = -1 Then
                Return Nothing
            Else
                SWHERE = cControl.list_llenado.ValueMember & "='" & cControl.SelectedValue & "'"
                If sColumnaWHERE <> Nothing Then
                    SWHERE = SWHERE + "AND " + sColumnaWHERE & "='" & WHERE & "'"
                End If
                Dim defaultV = cControl.DataSource.Tables(0).DefaultView
                defaultV.RowFilter = SWHERE

                Dim objDT = defaultV.ToTable()
                If objDT.Rows.Count <> 0 Then
                    Return objDT.Rows.Item(0).Item(sColumnaName).ToString()
                Else
                    Return Nothing

                End If
            End If
        End Function
        Function obTener_Descripcion2(ByVal cControl As combosax, Optional ByVal sColumnaName As String = "Descripcion", Optional ByVal sColumnaWHERE As String = Nothing, Optional ByVal WHERE As String = Nothing) As String
            Dim SWHERE As String
            If cControl.SelectedIndex = -1 Then
                Return Nothing
            Else
                SWHERE = cControl.list_llenado.ValueMember & "='" & cControl.SelectedValue & "'"
                If sColumnaWHERE <> Nothing Then
                    SWHERE = SWHERE + "AND " + sColumnaWHERE & "='" & WHERE & "'"
                End If
                Dim defaultV = cControl.DataSource.Tables(0).DefaultView
                defaultV.RowFilter = SWHERE

                Dim objDT = defaultV.ToTable()
                If objDT.Rows.Count <> 0 Then
                    Return objDT.Rows.Item(0).Item(sColumnaName).ToString()
                Else
                    Return Nothing

                End If
            End If
        End Function

        Function obetenerDescripcion4(ByVal cContrl2 As Combosax_B, Optional ByVal sColumnaName As String = "Descripcion", Optional ByVal sColumnaWHERE As String = Nothing, Optional ByVal WHERE As String = Nothing)
            Return cContrl2.DataSource.Tables(0).DefaultView.Table.Rows.Item(cContrl2.SelectedIndex).Item(sColumnaName)
        End Function
        Function obetenerDescripcion4(ByVal cContrl2 As combosax, Optional ByVal sColumnaName As String = "Descripcion", Optional ByVal sColumnaWHERE As String = Nothing, Optional ByVal WHERE As String = Nothing)
            Return cContrl2.DataSource.Tables(0).DefaultView.Table.Rows.Item(cContrl2.SelectedIndex).Item(sColumnaName)
        End Function

        Function obetenerDescripcion5(ByVal cContrl2 As combosax, Optional ByVal sColumnaName As String = "Descripcion", Optional ByVal sColumnaWHERE As String = Nothing, Optional ByVal WHERE As String = Nothing)
            Return cContrl2.DataSource.Tables(0).DefaultView.Table.Rows.Item(cContrl2.SelectedIndex).Item(sColumnaName)
        End Function
        Function ObtenerReporte(ByVal cControl As Object, Optional ByVal sColumnaName As String = "Descripcion") As String
            '----------------------------------
            If cControl.DataSource Is Nothing Then
                Return Nothing
            Else
                Dim dt As DataTable = DirectCast(cControl.DataSource, DataTable)

                Return dt.Rows.Item(cControl.SelectedIndex).Item(sColumnaName).ToString()
            End If
            '----------------------------------
        End Function

        Sub Llenar_Catalogos_Parametros(ByVal sNameProcedure As String, ByVal sId As String, ByVal sDescripcion As String, ByVal cControl As Object, Optional ByVal cParams() As SqlParameter = Nothing, Optional ByVal bEsText As Boolean = False)
            Dim sPARAMETROS As String
            Try
                Dim i As Integer
                Dim myDS As DataSet = New DataSet
                Dim myDA As Data.SqlClient.SqlDataAdapter = New Data.SqlClient.SqlDataAdapter(sNameProcedure, sConexion)
                If bEsText = True Then
                    myDA.SelectCommand.CommandType = CommandType.Text
                Else
                    myDA.SelectCommand.CommandType = CommandType.StoredProcedure
                    If cParams Is Nothing = False Then
                        For i = 0 To cParams.GetLength(0) - 1
                            If cParams(i) Is Nothing = False Then
                                If i = 0 Then
                                    If cParams(i).SqlDbType = SqlDbType.NVarChar Then
                                        sPARAMETROS = sPARAMETROS & cParams(i).ToString & "='" & cParams(i).Value & "'"
                                    Else
                                        sPARAMETROS = sPARAMETROS & cParams(i).ToString & "=" & cParams(i).Value
                                    End If
                                Else
                                    If cParams(i).SqlDbType = SqlDbType.NVarChar Then
                                        sPARAMETROS = sPARAMETROS & "," & cParams(i).ToString & "='" & cParams(i).Value & "'"
                                    Else
                                        sPARAMETROS = sPARAMETROS & "," & cParams(i).ToString & "=" & cParams(i).Value
                                    End If
                                End If
                                myDA.SelectCommand.Parameters.Add(cParams(i))
                            End If
                        Next
                    End If
                End If
                myDA.Fill(myDS, "SQLX")
                With cControl 'llenar los Catalogos}
                    .ValueMember = sId
                    .DisplayMember = sDescripcion
                    '.DataMember = "SQLX"
                    .DataSource = myDS.Tables(0)
                    '.Refresh()
                    '            combobox1.datasource = the second table
                    'combobox1.displaymember = the description in the second table
                    'combobox1.valuemebmer = the id in the second table
                End With





                '***********************************************************


            Catch ex As Exception
                Dim NumeroError As String
                NumeroError = Guardar_Error(Application.Session("name_modulo"), ex.Message, Application.Session("Cve_Operador"), sNameProcedure & " " & sPARAMETROS & "", formulario)
                alertas.NotificacionError(ex.Message, "Aviso")
            End Try
        End Sub

        Public Function llenar_dt(procedure As String, Optional ByVal cParams() As SqlParameter = Nothing, Optional ByVal nombre_tabla As String = Nothing) As DataTable
            Try
                If nombre_tabla = Nothing Then
                    Dim dt As New DataTable

                    Conectar()
                    Dim cmd As New SqlCommand(procedure, cConnect)
                    cmd.CommandType = CommandType.StoredProcedure
                    If cParams Is Nothing = False Then
                        For i = 0 To cParams.GetLength(0) - 1
                            If cParams(i) Is Nothing = False Then
                                cmd.Parameters.Add(cParams(i))
                            End If
                        Next
                    End If
                    Dim adapter As New Data.SqlClient.SqlDataAdapter
                    adapter.SelectCommand = cmd
                    adapter.Fill(dt)
                    Desconectar()
                    Return dt
                Else
                    Dim dt As New DataTable(nombre_tabla)

                    Conectar()
                    Dim cmd As New SqlCommand(procedure, cConnect)
                    cmd.CommandType = CommandType.StoredProcedure
                    If cParams Is Nothing = False Then
                        For i = 0 To cParams.GetLength(0) - 1
                            If cParams(i) Is Nothing = False Then
                                cmd.Parameters.Add(cParams(i))
                            End If
                        Next
                    End If
                    Dim adapter As New Data.SqlClient.SqlDataAdapter
                    adapter.SelectCommand = cmd
                    adapter.Fill(dt)
                    Desconectar()
                    Return dt
                End If

            Catch ex As Exception

            End Try
        End Function

        Function obTener_Descripcion_Tabla(ByVal cControl As Object) As DataTable
            '----------------------------------
            If cControl.DataSource Is Nothing Then
                Return Nothing
            Else
                Dim dt As DataTable = DirectCast(cControl.DataSource.tables(0), DataTable)

                Return dt
            End If
            '----------------------------------
        End Function
    End Module

#End Region

#Region "Procesos"
    Module Procesos
        Sub AlternatingColors_Grilla(ByVal GridX As DataGridView)

            'With GridX
            '    .RowHeadersDefaultCellStyle.BackColor = System.Drawing.Color.White
            '    .BackColor = System.Drawing.Color.AliceBlue
            'End With
            '''
        End Sub

        Public Function CrearDGV(ByVal PROCEDURE_GRILLA As String, Optional Parametros As Dictionary(Of String, Object) = Nothing) As DataGridView
            Dim TablasHijas As DataGridView = New DataGridView
            Dim dfs As New DataGridViewCellStyle
            dfs.Alignment = Wisej.Web.DataGridViewContentAlignment.MiddleCenter
            dfs.BackColor = System.Drawing.SystemColors.Control
            dfs.Font = New System.Drawing.Font("tahoma", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel)
            dfs.ForeColor = System.Drawing.Color.FromArgb(0, 0, 0)
            dfs.WrapMode = Wisej.Web.DataGridViewTriState.[True]
            TablasHijas.ColumnHeadersDefaultCellStyle = dfs
            TablasHijas.RowHeadersVisible = False
            TablasHijas.RowTemplate.Height = 20


            Dim BS As BindingSource
            Dim DS As DataSet = New DataSet
            Try
                DS.Tables.Clear()
                DS.Clear()
                Dim myDA = New SqlClient.SqlDataAdapter(PROCEDURE_GRILLA, Utilidades.sConexion)
                If Parametros IsNot Nothing Then
                    For i = 0 To Parametros.Count - 1
                        myDA.SelectCommand.Parameters.AddWithValue("@" & Parametros.Keys(i), Parametros.Values(i))
                    Next
                End If
                myDA.SelectCommand.CommandType = CommandType.StoredProcedure
                myDA.Fill(DS)
                myDA.Dispose()
                BS = New BindingSource(DS, DS.Tables(0).TableName)
                TablasHijas.DataSource = BS
                Return TablasHijas
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            Return Nothing
        End Function

        Public Function ClonarDGV(ByVal DGV As DataGridView, Optional dcs As DataGridViewCellStyle = Nothing)
            Dim NuevaDGV As New DataGridView
            Dim i = 0
            Try
                For Each col As DataGridViewColumn In DGV.Columns
                    NuevaDGV.Columns.Add(DirectCast(col.Clone, DataGridViewColumn))
                    NuevaDGV.Columns(i).Visible = DGV.Columns(i).Visible
                    i += 1
                Next

                For j As Integer = 0 To (DGV.Rows.Count - 1)
                    NuevaDGV.Rows.Add(DGV.Rows(j).Cells.Cast(Of DataGridViewCell).Select(Function(c) c.Value).ToArray())
                Next
                NuevaDGV.ColumnHeadersDefaultCellStyle = DGV.ColumnHeadersDefaultCellStyle
                NuevaDGV.RowTemplate = DGV.RowTemplate
                NuevaDGV.RowHeadersVisible = False
                NuevaDGV.ColumnHeadersHeight = DGV.ColumnHeadersHeight
                NuevaDGV.Focusable = False
                Return NuevaDGV
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            Return Nothing
        End Function
        Public Function esEmailValido(ByVal correo As String) As Boolean
            Dim es As Boolean

            es = Regex.IsMatch(correo,
                     "^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                     "(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$")
            Return es
        End Function

        Sub ExportarMultiplesDatos(ByVal Formx As Form, sFormato As String, ByVal Elementos As List(Of ElementoExportar))
            If Elementos Is Nothing Then
                MessageBox.Show("No se puede exportar Procedure", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Exit Sub
            End If
            Try

                Dim AspX As New AspNetPanelII
                'Oscar, no dejaba dar click en algunos botones o descargaba varios archivos después de la primera vez
                AspX.Tag = "Downloaded ASPX"
                For Each cntrl In Formx.Controls
                    If cntrl.tag = "Downloaded ASPX" Then
                        Formx.Controls.Remove(cntrl)
                    End If
                Next
                Formx.Controls.Add(AspX)


                AspX.PageSource = "ReportView_Exportar_Datos.aspx"
                Application.Session("Formato") = sFormato
                Application.Session("Tipo_Exportacion") = "MULTIPLE"
                Application.Session("Elementos") = Elementos
                AspX.Update()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub
        Sub ExportarDatosDGV(ByVal Formx As Form, sFormato As String, ByVal Tabla As DataTable)
            Try
                Dim AspX As New AspNetPanelII
                'Oscar, no dejaba dar click en algunos botones o descargaba varios archivos después de la primera vez
                AspX.Tag = "Downloaded ASPX"
                For Each cntrl In Formx.Controls
                    If cntrl.tag = "Downloaded ASPX" Then
                        Formx.Controls.Remove(cntrl)
                    End If
                Next
                Formx.Controls.Add(AspX)
                AspX.Width = 1
                AspX.Height = 1

                AspX.PageSource = "ReportView_Exportar_Datos.aspx"
                Application.Session("Formato") = sFormato
                Application.Session("Tipo_Exportacion") = "DGV"
                Application.Session("TablaDGV") = Tabla
                AspX.Update()

            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Sub
        Friend Sub loadConfigDataGridView(ByVal dgvTabla As DataGridView)
            ' Throw New NotImplementedException()
            With dgvTabla
                .RowHeadersVisible = False
                .ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize
                .AllowUserToAddRows = False
                .AllowUserToDeleteRows = False
                .SelectionMode = DataGridViewSelectionMode.FullRowSelect
                .ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter
                .ColumnHeadersDefaultCellStyle.ToString.ToLower()
                .Columns.ToString.ToLower()
            End With
        End Sub

        Sub Limpiar(ByVal c1 As Wisej.Web.Control, Optional checkeds As Boolean = False)
            For Each c As Wisej.Web.Control In c1.Controls
                If TypeOf c Is ComboBox Then
                    DirectCast(c, ComboBox).SelectedIndex = -1
                ElseIf (TypeOf (c) Is CheckBox) Then
                    If checkeds Then
                        CType(c, CheckBox).Checked = False
                    End If
                ElseIf TypeOf c Is DateTimePicker Then
                    CType(c, DateTimePicker).Value = Now ' eliminar el texto 
                ElseIf TypeOf c Is PictureBox Then
                    c.BackgroundImage = Nothing
                    DirectCast(c, PictureBox).Image = Nothing
                ElseIf TypeOf c Is combosax Then
                    DirectCast(c, combosax).SelectedIndex = -1
                ElseIf TypeOf c Is TextBox Then
                    c.Text = "" ' eliminar el texto
                ElseIf (TypeOf (c) Is RadioButton) Then
                    If checkeds Then
                        CType(c, RadioButton).Checked = False
                    End If
                Else
                    Limpiar(c)
                End If
            Next
        End Sub

        Public Function rellenar(ByVal texto As String, decimales As Integer, negativo As Boolean)
            Dim numeros As Char()
            If (decimales > 0) Then
                numeros = texto.ToCharArray()
                texto = ""
                Dim i = 0
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
                Dim j
                For j = 0 To numeros.Length - 1
                    If (numeros(j) >= "0" And numeros(j) <= "9") Then
                        texto += numeros(j)
                    ElseIf negativo And numeros(0) = "-" Then
                        texto += numeros(j)
                    End If
                Next
            End If
            If texto.Length > 0 Then
                If texto.Substring(0, 1) = "." Then texto = "0" + texto
            Else texto = "0"
            End If
            Return texto
        End Function
        Public Function arregloCorreos(ByVal cadena As String) As String()
            Dim arreglo As String()
            arreglo = cadena.Split(",")
            Return arreglo
        End Function
        Private Function customCertValidation(ByVal sender As Object,
                                                ByVal cert As X509Certificate,
                                                ByVal chain As X509Chain,
                                                ByVal errors As SslPolicyErrors) As Boolean

            Return True

        End Function
        Function Enviar_Mail(ByVal sSubject As String, ByVal sCuerpo As String, sFilePath As String, sEmail_A_Enviar As String, bEnviar_CC As Boolean, cEmail As combosax) As Boolean


            Dim usuario, pass, bandera, smtp, puerto, nom_arch As String
            Dim bsend As Boolean
            Dim nCont As Integer
            Dim sCorreo As String()
            Dim sCorreo_CC As String
            Dim FilePath_logox As String = HttpContext.Current.Server.MapPath("~\Resources\Images\Menu\64\Imagen1.png")

            Dim htmlView As AlternateView = AlternateView.CreateAlternateViewFromString(sCuerpo, Nothing, "text/html")
            sCorreo = arregloCorreos(sEmail_A_Enviar)
            nCont = sCorreo.Length
            usuario = ObtenerDescripcion(cEmail, "Email")
            pass = ObtenerDescripcion(cEmail, "Contrasena")
            smtp = ObtenerDescripcion(cEmail, "Servidor_Email")
            puerto = ObtenerDescripcion(cEmail, "Puerto")
            Dim mail As New MailMessage
            mail.From = New MailAddress(usuario)
            For i = 0 To nCont - 1
                If sCorreo(i) <> "" Then
                    If esEmailValido(sCorreo(i)) Then
                        mail.To.Add(sCorreo(i))
                    Else
                        MessageBox.Show("el correo " & sCorreo(i) & " tiene un formato incorrecto por favor verifiquelo ")
                        Exit Function
                    End If
                End If
            Next
            mail.IsBodyHtml = True

            If bEnviar_CC Then
                sCorreo_CC = ObtenerDescripcion(cEmail, "CC")
                If Trim(sCorreo_CC) <> Nothing Then
                    mail.CC.Add(sCorreo_CC)
                End If

            End If
            'mail.IsBodyHtml = True
            ' mail.AlternateViews.Add(htmlView1)
            mail.AlternateViews.Add(htmlView)
            mail.Subject = sSubject
            mail.Body = sCuerpo
            'Dim FilePath As String = 
            'el archivo se adjunta indicándole la ruta 
            If sFilePath <> Nothing Then
                'For i = 0 To nCont - 1
                '    If sArchivoAdjunto(i) <> "" Then
                '        mail.Attachments.Add(New Attachment(sArchivoAdjunto(i)))
                '    End If
                'Next
                mail.Attachments.Add(New Attachment(sFilePath))
            End If
            Dim mailClient As New SmtpClient()
            Dim auentificacion As New System.Net.NetworkCredential(usuario, pass)
            mailClient.Host = smtp
            mailClient.Port = puerto
            mailClient.UseDefaultCredentials = True
            mailClient.EnableSsl = True
            mailClient.Credentials = auentificacion
            Dim estado_user As Object = mail
            Try
                'you can also call client.Send(msg)
                ServicePointManager.ServerCertificateValidationCallback = New System.Net.Security.RemoteCertificateValidationCallback(AddressOf customCertValidation)

                mailClient.Send(mail)
                bsend = True
                mail.Dispose()
                mailClient.Dispose()
            Catch ex As System.Net.Mail.SmtpException
                mail.Dispose()
                mailClient.Dispose()
                bsend = False 'MessageBox.Show()
            End Try

            Return bsend

        End Function

        Public Sub filtrarGrilla(columna As String, valor As String, tabla As DataTable, grilla As DataGridView, Optional filtrarVacios As Boolean = False, Optional isLike As Boolean = True, Optional tException As Boolean = False) 'As Boolean

            Try
                If columna <> Nothing And Not tabla Is Nothing And Not grilla Is Nothing Then
                    Dim col = tabla.Columns().Item(columna)
                    If Not col Is Nothing Then 'VERIFICA si existe esa columna en la tabla
                        Dim sWhere As String = ""
                        If valor IsNot Nothing Or filtrarVacios Then 'Si recibe Nothing, limpia el filtro
                            Dim compare = " LIKE '%", compare2 As String = "%'"
                            If Not isLike Then compare = "='" : compare2 = "'" 'si no quieres usar like se cambia "like" por "="
                            If col.DataType.Name.Contains("Int") Or col.DataType.Name.Contains("Decimal") Then 'si es númerico, se transforma a un double y  se cambia "like" por "="
                                valor = rellenar(valor, 10, False) : compare = "=" : compare2 = ""
                            End If
                            If col.DataType.Name <> "DateTime" Then sWhere = columna & compare & valor & compare2 'Construye el filtro

                            Dim defaultV As DataView = tabla.DefaultView
                            defaultV.RowFilter = sWhere
                            grilla.DataSource = defaultV

                        Else
                            Dim defaultV As DataView = tabla.DefaultView
                            defaultV.RowFilter = ""
                            grilla.DataSource = defaultV
                        End If


                    End If
                End If
            Catch ex As Exception
                If tException Then
                    Throw ex
                Else
                    Dim defaultV As DataView = tabla.DefaultView
                    defaultV.RowFilter = ""
                    grilla.DataSource = defaultV
                End If
            End Try

        End Sub
        'Sub ExportarPlantilla(ByVal Frm As Control, ByVal sUrl As String)
        '    'Get FullPhysicalFilePath to send to Browser
        '    Dim myFilePath As String = ContextUtils.GetPhysicalPath(Frm, sUrl) '"Resources\Plantillas\" & sModulo & "\", sNombreArchivo)

        '    'Create File Download Manager
        '    Dim myDownload As New DownloadGateway(myFilePath)

        '    'Start Download
        '    myDownload.StartDownload(Frm)
        'End Sub

        Public Function eliminarArchivo(ByVal ruta As String) As Boolean
            Try
                If File.Exists(ruta) Then
                    File.Delete(ruta)
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Return False
            End Try
        End Function
        Public Function eliminarArchivoWhatsApp(ByVal ruta As String) As Boolean
            Dim RutaCompleta = Application.StartupPath & ruta
            Try
                If File.Exists(RutaCompleta) Then
                    File.Delete(RutaCompleta)
                    Return True
                Else
                    Return False
                End If
            Catch ex As Exception
                Return False
            End Try
        End Function

        Sub Ocultar_Botones_BindingNavigator(ByVal sObjeto As BindingNavigator, Optional ByVal Mostrar_Next As Boolean = False)
            sObjeto.MoveFirstItem.Visible = Mostrar_Next
            sObjeto.MoveLastItem.Visible = Mostrar_Next
            sObjeto.MoveNextItem.Visible = Mostrar_Next
            sObjeto.MovePreviousItem.Visible = Mostrar_Next
            sObjeto.AddNewItem.Visible = False
            sObjeto.DeleteItem.Visible = False
        End Sub
    End Module
#End Region

#Region "Facturacion"

    Module Facturacion
        Function CentavosAddR(ByVal NoCentavos As Int32, Optional ByVal Cetavos As String = "") As String
            Dim AddCentavos As String = ""
            If NoCentavos > Cetavos.Length Then
                NoCentavos = NoCentavos - Cetavos.Length
                For i = 1 To NoCentavos
                    AddCentavos += "0"
                Next
                AddCentavos = "." + Cetavos + AddCentavos
                Return AddCentavos
            Else
                Return "." + Cetavos
            End If

        End Function
        Function ConvertirTextoPlano(Texto As String)
            Const conAcentos = "áàäâÁÀÄÂéèëêÉÈËÊíìïîÍÌÏÎóòöôÓÒÖÔúùüûÚÙÜÛýÿÝ"
            Const sinAcentos = "aaaaAAAAeeeeEEEEiiiiIIIIooooOOOOuuuuUUUUyyY"
            Dim i As Integer
            For i = Len(conAcentos) To 1 Step -1
                Texto = Replace(Texto, Mid(conAcentos, i, 1), Mid(sinAcentos, i, 1))
            Next
            ConvertirTextoPlano = Texto
        End Function

        Function ConfiguracionMonedaRegionalEntrada(ByRef monedaAFormatear As String) As String
            If System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "," Then
                monedaAFormatear = monedaAFormatear.Replace(",", ".")
            End If
            If System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "." Then
                monedaAFormatear = monedaAFormatear.Replace(".", ",")
            End If
            Return monedaAFormatear
        End Function

        Function ConfiguraciónFormatoMoneda(ByVal monedaSinConvertir As String, Optional ByRef NoCentavos As Int32 = 2, Optional ByRef SignoMoneda As String = "$", Optional ByRef resultado As String = "", Optional ByRef AlmacenarCentavos As String = "", Optional ByRef primeraVez As Boolean = True) As String
            Try

                Dim ultimosDigitos As String
                If primeraVez Then
                    monedaSinConvertir = ConfiguracionMonedaRegionalEntrada(monedaSinConvertir)
                    Dim SepararPorPuntoDecimal() As String = monedaSinConvertir.Split(".")
                    If SepararPorPuntoDecimal.Length = 2 Then
                        AlmacenarCentavos = CentavosAddR(NoCentavos, SepararPorPuntoDecimal(1))
                    ElseIf SepararPorPuntoDecimal.Length = 1 Then
                        AlmacenarCentavos = CentavosAddR(NoCentavos)
                    Else
                        AlmacenarCentavos = "-1.INTRODUJO MÁS DE 1 '.' PERMITIDO"
                    End If
                    monedaSinConvertir = SepararPorPuntoDecimal(0)
                End If

                If monedaSinConvertir.Length <= 3 Then
                    Return SignoMoneda + " " + monedaSinConvertir + resultado + AlmacenarCentavos
                Else
                    ultimosDigitos = monedaSinConvertir.Substring(monedaSinConvertir.Length - 3, 3)
                    monedaSinConvertir = monedaSinConvertir.Substring(0, monedaSinConvertir.Length - 3)

                    If primeraVez Then
                        If monedaSinConvertir = "-" Then
                            resultado = ultimosDigitos
                        Else
                            resultado = "," + ultimosDigitos
                        End If

                    Else
                        If monedaSinConvertir = "-" Then
                            resultado = ultimosDigitos + resultado
                        Else
                            resultado = "," + ultimosDigitos + resultado
                        End If
                    End If

                    Return ConfiguraciónFormatoMoneda(monedaSinConvertir, NoCentavos, SignoMoneda, resultado, AlmacenarCentavos, False)
                End If
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
        End Function

        Function ConfiguracionMonedaRegionalSalida(ByVal monedaAFormatear As String) As String
            If monedaAFormatear = Nothing Then Exit Function
            If System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "," Then
                monedaAFormatear = monedaAFormatear.Replace(".", ",")
            ElseIf System.Globalization.CultureInfo.CurrentCulture.NumberFormat.CurrencyDecimalSeparator = "." Then
                monedaAFormatear = monedaAFormatear.Replace(",", ".")
            End If
            Return monedaAFormatear
        End Function

        Sub FormatoMoneda(ByRef CuadroDeTexto As TextBox, ByVal val_text As String)
            Try
                Dim valorDecimal = 0
                Decimal.TryParse(val_text, valorDecimal)

                'val_text = Math.Round(CDbl(val_text), 2)
                CuadroDeTexto.Tag = Format(valorDecimal, "n2")
                CuadroDeTexto.Text = Format(valorDecimal, "c2")
                'End If
            Catch ex As Exception
                Dim alertas As New Notificaciones
                alertas.NotificacionError(ex.Message, "Aviso")
            End Try
        End Sub
        Public Sub EnviarSolicitudControlTimbre(rfc As String, movimiento As String, valor As Integer)


            Dim EnviarTimbre As New WebService_Timbres.Timbres()
            EnviarTimbre.Credentials = New System.Net.NetworkCredential("Administrator", "SEnrX6pfUR")

            EnviarTimbre.GuardarTimbre(rfc, movimiento, valor)
            'Using Client As New HttpClient()
            '    'Client.BaseAddress = New Uri("")
            '    Try
            '        Client.DefaultRequestHeaders.Accept.Clear()


            '        Dim sUrl As String = Web.Configuration.WebConfigurationManager.AppSettings("WebServiceFactura")

            '        Dim request = New HttpRequestMessage()

            '        Dim sUri As String = String.Format("{0}" & sURLs, sUrl)

            '        request.RequestUri = New Uri(sUri)
            '        request.Method = HttpMethod.Post


            '        ''  Dim sBody As String = String.Format("rfc={0}&movimiento={1}&valor={2}", "A1", "CONTRATADAS", Lb_Contratadas.Text)

            '        request.Content = New StringContent(sBODY, Encoding.UTF8, "application/x-www-form-urlencoded")
            '        request.Headers.Clear()

            '        '  request.Content.Headers.ContentType = New Headers.MediaTypeHeaderValue("application/")



            '        Dim response As HttpResponseMessage = Client.SendAsync(request).GetAwaiter().GetResult()

            '        'If response.IsSuccessStatusCode Then
            '        '    MessageBox.Show("Actualizado Correctamente")
            '        'Else
            '        '    MessageBox.Show("No actualizado")

            '        'End If
            '    Catch ex As Exception

            '    End Try

            'End Using
        End Sub
    End Module


#End Region

#Region "Reportes"
    Module Reportes
        Public Function GenerarReporte(ByVal sReportName As String, ByVal sProcedureName As String, Optional ByVal dicParametros As Dictionary(Of String, String) = Nothing)
            Dim MOSTRAR_ASP As New Mostrar_Asp
            MOSTRAR_ASP.AspNetPanel1.PageSource = Nothing
            Application.Session("ReportName") = sReportName
            Application.Session("ProcedureName") = sProcedureName
            Application.Session("DicParametros") = dicParametros
            Application.Session("DocumentCached") = Nothing
            MOSTRAR_ASP.AspNetPanel1.PageSource = "ReportView.aspx"
            MOSTRAR_ASP.AspNetPanel1.Update()
            MOSTRAR_ASP.Show()
        End Function

        Public Function ObtenerImagen(ByVal Carpeta_Imagenes As String, ByVal Nombre_Imagen As Object, Optional ByVal remplazarParaSubcarpetas As Boolean = True) As Bitmap
            Dim image As Bitmap = Nothing
            Try
                If Not IsDBNull(Nombre_Imagen) Then
                    Dim path As String = HttpContext.Current.Server.MapPath("~\Resources\Images\" & Carpeta_Imagenes & "\") & IIf(remplazarParaSubcarpetas, Nombre_Imagen.ToString().Replace("._", "\"), Nombre_Imagen)
                    If System.IO.File.Exists(path) Then
                        Return New Bitmap(path, True)
                    End If
                End If
            Catch ex As Exception

            End Try
            Return image
        End Function
        Public Sub EstablecerImagenReporte(ByRef pictureBox As XRPictureBox, ByVal Carpeta_Imagenes As String, ByVal Nombre_Imagen As Object, Optional ByVal remplazarParaSubcarpetas As Boolean = True)
            pictureBox.Image = ObtenerImagen(Carpeta_Imagenes, Nombre_Imagen, remplazarParaSubcarpetas)

        End Sub
        Sub XrichtecFormatoMoneda(ByRef CuadroDeTexto As DevExpress.XtraReports.UI.XRLabel, ByVal val_text As String)
            Try
                'val_text = Math.Round(CDbl(val_text), 2)
                CuadroDeTexto.Tag = ConfiguracionMonedaRegionalSalida(val_text)
                CuadroDeTexto.Text = ConfiguraciónFormatoMoneda(val_text)
                'End If
            Catch ex As Exception
                Dim Alertas As New Notificaciones
                Alertas.NotificacionError(ex.Message, "Aviso")
            End Try
        End Sub

        Public Function Num2Text(ByVal value As Double) As String
            Select Case value
                Case 0 : Num2Text = "CERO"
                Case 1 : Num2Text = "UNO"
                Case 2 : Num2Text = "DOS"
                Case 3 : Num2Text = "TRES"
                Case 4 : Num2Text = "CUATRO"
                Case 5 : Num2Text = "CINCO"
                Case 6 : Num2Text = "SEIS"
                Case 7 : Num2Text = "SIETE"
                Case 8 : Num2Text = "OCHO"
                Case 9 : Num2Text = "NUEVE"
                Case 10 : Num2Text = "DIEZ"
                Case 11 : Num2Text = "ONCE"
                Case 12 : Num2Text = "DOCE"
                Case 13 : Num2Text = "TRECE"
                Case 14 : Num2Text = "CATORCE"
                Case 15 : Num2Text = "QUINCE"
                Case Is < 20 : Num2Text = "DIECI" & Num2Text(value - 10)
                Case 20 : Num2Text = "VEINTE"
                Case Is < 30 : Num2Text = "VEINTI" & Num2Text(value - 20)
                Case 30 : Num2Text = "TREINTA"
                Case 40 : Num2Text = "CUARENTA"
                Case 50 : Num2Text = "CINCUENTA"
                Case 60 : Num2Text = "SESENTA"
                Case 70 : Num2Text = "SETENTA"
                Case 80 : Num2Text = "OCHENTA"
                Case 90 : Num2Text = "NOVENTA"
                Case Is < 100 : Num2Text = Num2Text(Int(value \ 10) * 10) & " Y " & Num2Text(value Mod 10)
                Case 100 : Num2Text = "CIEN"
                Case Is < 200 : Num2Text = "CIENTO " & Num2Text(value - 100)
                Case 200, 300, 400, 600, 800 : Num2Text = Num2Text(Int(value \ 100)) & "CIENTOS"
                Case 500 : Num2Text = "QUINIENTOS"
                Case 700 : Num2Text = "SETECIENTOS"
                Case 900 : Num2Text = "NOVECIENTOS"
                Case Is < 1000 : Num2Text = Num2Text(Int(value \ 100) * 100) & " " & Num2Text(value Mod 100)
                Case 1000 : Num2Text = "MIL"
                Case Is < 2000 : Num2Text = "MIL " & Num2Text(value Mod 1000)
                Case Is < 1000000 : Num2Text = Num2Text(Int(value \ 1000)) & " MIL"
                    If value Mod 1000 Then Num2Text = Num2Text & " " & Num2Text(value Mod 1000)
                Case 1000000 : Num2Text = "UN MILLON"
                Case Is < 2000000 : Num2Text = "UN MILLON " & Num2Text(value Mod 1000000)
                Case Is < 1000000000000.0# : Num2Text = Num2Text(Int(value / 1000000)) & " MILLONES "
                    If (value - Int(value / 1000000) * 1000000) Then Num2Text = Num2Text & "" & Num2Text(value - Int(value / 1000000) * 1000000)
                Case 1000000000000.0# : Num2Text = "UN BILLON"
                Case Is < 2000000000000.0# : Num2Text = "UN BILLON " & Num2Text(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
                Case Else : Num2Text = Num2Text(Int(value / 1000000000000.0#)) & " BILLONES"
                    If (value - Int(value / 1000000000000.0#) * 1000000000000.0#) Then Num2Text = Num2Text & " " & Num2Text(value - Int(value / 1000000000000.0#) * 1000000000000.0#)
            End Select

        End Function

        Public Function Capitalizar(ByVal texto As String, Optional ByVal caracterSeparador As String = " ", Optional ByVal caracterUnion As String = " ", Optional ByVal soloPrimeraPalabra As Boolean = False) As String
            If texto.Length = 0 Then Return texto
            If texto.Length = 1 Then Return texto.ToUpper()
            Dim result = ""
            If soloPrimeraPalabra Then
                result = texto.Substring(0, 1).ToUpper() + texto.Substring(1).ToLower()
            Else
                Dim pattern As String = "\b(\w|['-])+\b"
                result = Regex.Replace(texto, pattern,
                    Function(m) m.Value(0).ToString().ToUpper() & m.Value.Substring(1).ToLower())
            End If
            Return result
        End Function
    End Module
#End Region

#Region "Exportar"

    Module Configuracion
        Public Property OpcionesExportar As ParametrosExportado
        Public ME_PROCEDURE As String = Nothing
        Public ME_PARAMETROS As System.Data.SqlClient.SqlParameter() = Nothing

    End Module

    Class ExportarInformacion

        Public Property sParametros As Wisej.Web.Ext.RibbonBar.RibbonBarItemButton
        Private sParametrosExportar As ParametrosExportado




        Public Sub Export_procedure(ByVal Formx As Form)
            'Dim sExportar As New ExportarInformacion
            'Configuracion.ME_PROCEDURE = "pCAT_DEPARTAMENTOS_b"
            'sExportar.Export_procedure(Me)

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
        Public Sub Export_To_sFiltro(ByVal Formx As Form)

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
                AspX.PageSource = "Exportar.aspx"
                AspX.Update()
            Catch ex As Exception

            End Try
        End Sub

        Public Sub exportarProcedure(ByVal responseX As HttpResponse)

            'Dim sExportar As New ExportarInformacion
            'Configuracion.ME_PROCEDURE = "pCAT_DEPARTAMENTOS_b"
            'sExportar.Export_procedure(Me)


            Dim table As DataTable = New DataTable("Sheet1")
            Try
                'LicenseHelper.ModifyInMemory.ActivateMemoryPatching()
                Utilidades.Conectar()
                Dim cmd As SqlCommand = New SqlCommand()
                cmd.Connection = New SqlConnection(Utilidades.sConexion)
                cmd.CommandText = Configuracion.ME_PROCEDURE
                cmd.CommandType = CommandType.StoredProcedure
                If Configuracion.ME_PARAMETROS Is Nothing = False Then
                    If Configuracion.ME_PARAMETROS.Length > 0 Then
                        For n = 0 To Configuracion.ME_PARAMETROS.Length - 1
                            cmd.Parameters.Add(Configuracion.ME_PARAMETROS(n))
                        Next
                    End If
                End If
                Dim da As SqlDataAdapter = New SqlDataAdapter()
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
                Dim memoriaStream As New MemoryStream
                'cellExport.SaveToStream(memoriaStream)
                cellExport.SaveToHttpResponse(OpcionesExportar.NombreArchivo & ".xls", responseX)
            Catch ex As Exception
            End Try

        End Sub


        Sub EXPORTAR_DATOS(ByVal responseX As HttpResponse)



            Dim table As DataTable = New DataTable("Sheet1")
            Try
                'LicenseHelper.ModifyInMemory.ActivateMemoryPatching()

            Catch ex As Exception

            End Try


            Dim sColumnWith As New Dictionary(Of String, Int64)
            If Configuracion.OpcionesExportar.DataGridView Is Nothing Then
                Utilidades.Conectar()
                Dim cmd As SqlCommand = New SqlCommand()
                cmd.Connection = New SqlConnection(Utilidades.sConexion)
                cmd.CommandText = OpcionesExportar.NombreProcedimiento
                If OpcionesExportar.Parametros Is Nothing = False Then
                    cmd.CommandType = CommandType.StoredProcedure
                    For n = 0 To OpcionesExportar.Parametros.Count - 1
                        cmd.Parameters.Add(OpcionesExportar.Parametros(n))
                    Next
                Else
                    cmd.CommandType = CommandType.Text
                End If
                Dim da As SqlDataAdapter = New SqlDataAdapter()
                da.SelectCommand = cmd
                da.Fill(table)
                Utilidades.Desconectar()
            Else
                Try
                    For p = 0 To OpcionesExportar.DataGridView.Columns.Count - 1
                        Dim sColumna As DataGridViewColumn = OpcionesExportar.DataGridView.Columns(p)
                        If GetRowColumnsValido(sColumna) Then
                            table.Columns.Add(New DataColumn With {.Caption = sColumna.HeaderText})

                        End If

                    Next



                    For r = 0 To OpcionesExportar.DataGridView.Rows.Count - 1
                        Dim Rows As New List(Of String)
                        For j = 0 To OpcionesExportar.DataGridView.Columns.Count - 1
                            Try
                                Dim sColumna As DataGridViewColumn = OpcionesExportar.DataGridView.Columns(j)
                                If GetRowColumnsValido(sColumna) Then

                                    Dim Dato As String = ""
                                    If IsDBNull(OpcionesExportar.DataGridView.Rows.Item(r).Cells(j).Value) Or OpcionesExportar.DataGridView.Rows.Item(r).Cells(j).Value Is Nothing Then
                                        Dato = ""
                                    Else
                                        Dato = OpcionesExportar.DataGridView.Rows.Item(r).Cells(j).Value
                                    End If

                                    If sColumnWith.ContainsKey(sColumna.Name) Then
                                        Dim sW As Int64 = sColumnWith(sColumna.Name)
                                        If sW < Dato.Length Then
                                            sColumnWith(sColumna.Name) = Dato.Length
                                        End If
                                    Else
                                        sColumnWith.Add(sColumna.Name, Dato.Length)
                                    End If

                                    Rows.Add(Dato)
                                End If
                            Catch ex As Exception
                                MessageBox.Show("Ocurrio un error => " & ex.Message)
                                Exit Sub
                            End Try

                        Next
                        table.Rows.Add(Rows.ToArray())
                    Next
                Catch ex As Exception

                End Try

            End If



            responseX.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"

            Select Case OpcionesExportar.sTipo
                Case TipoExport.Excel
                    Dim cellExport As New Spire.DataExport.XLS.CellExport
                    Dim worksheet1 As New Spire.DataExport.XLS.WorkSheet
                    worksheet1.DataSource = Spire.DataExport.Common.ExportSource.DataTable
                    worksheet1.DataTable = table
                    worksheet1.StartDataCol = (0)
                    If Not sColumnWith.Count = 0 Then
                        Dim i As Int64 = 0
                        For Each item In sColumnWith

                            worksheet1.SetColumnWidth(i, item.Value)
                            i += 1

                        Next
                    End If


                    cellExport.Sheets.Add(worksheet1)
                    cellExport.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView
                    Dim memoriaStream As New MemoryStream
                    'cellExport.SaveToStream(memoriaStream)
                    cellExport.SaveToHttpResponse(OpcionesExportar.NombreArchivo & ".xls", responseX)
                Case TipoExport.PDF
                    Dim pdfExport1 = New Spire.DataExport.PDF.PDFExport
                    pdfExport1.DataFormats.CultureName = "en-US"
                    pdfExport1.DataFormats.Currency = "c"
                    pdfExport1.PDFOptions.PageOptions.Format = Spire.DataExport.PDF.PageFormat.Letter
                    pdfExport1.PDFOptions.PageOptions.Orientation = Spire.DataExport.Common.PageOrientation.Landscape
                    pdfExport1.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView
                    pdfExport1.DataTable = table
                    pdfExport1.AutoFitColWidth = False
                    pdfExport1.DataSource = Spire.DataExport.Common.ExportSource.DataTable
                    'pdfExport1.ColumnsWidth(1) = 10
                    pdfExport1.PDFOptions.PageOptions.MarginBottom = 0.1
                    'pdfExport1.Columns(1).EndsWith(15)
                    pdfExport1.PDFOptions.PageOptions.MarginLeft = 0.1
                    pdfExport1.PDFOptions.PageOptions.MarginRight = 0.1
                    pdfExport1.PDFOptions.PageOptions.MarginTop = 0.1
                    pdfExport1.PDFOptions.DataFont.CustomFont = New System.Drawing.Font("Arial", 9)
                    pdfExport1.SaveToHttpResponse(OpcionesExportar.NombreArchivo & ".pdf", responseX)
                Case TipoExport.Txt
                    Dim documentExport = New Spire.DataExport.TXT.TXTExport
                    documentExport.DataTable = table
                    documentExport.DataSource = Spire.DataExport.Common.ExportSource.DataTable
                    documentExport.SaveToHttpResponse(OpcionesExportar.NombreArchivo & ".txt", responseX)
                Case TipoExport.Xml
                    Dim documentExport = New Spire.DataExport.XML.XMLExport
                    documentExport.DataTable = table
                    documentExport.DataSource = Spire.DataExport.Common.ExportSource.DataTable
                    documentExport.SaveToHttpResponse(OpcionesExportar.NombreArchivo & ".xml", responseX)
            End Select

        End Sub

        Function GetRowColumnsValido(sColumna As DataGridViewColumn) As Boolean
            If sColumna.Visible = False Then
                Return False
            ElseIf sColumna.HeaderText.Trim.Length = 0 Then
                Return False
            End If
            Return True
        End Function
        Public Sub ViewFile(fs As Stream, responseX As HttpResponse)
            responseX.Clear()
            responseX.ContentType = "application/vnd.ms-excel"
            responseX.AddHeader("Content-Disposition", "attachment; filename=filename.xls")
            responseX.AddHeader("Content-Length", fs.Length.ToString())
            fs.CopyTo(responseX.OutputStream)
            responseX.OutputStream.Flush()
            responseX.OutputStream.Close()
        End Sub

        Public Enum TipoExport
            Excel
            PDF
            Txt
            Html
            Xml
        End Enum


    End Class

    Structure ParametrosExportado
        Private sProcedureName As String
        Public Property NombreProcedimiento() As String
            Get
                Return sProcedureName
            End Get
            Set(ByVal value As String)
                sProcedureName = value
            End Set
        End Property

        Private sParametros As SqlParameter()
        Public Property Parametros() As SqlParameter()
            Get
                Return sParametros
            End Get
            Set(ByVal value As SqlParameter())
                sParametros = value
            End Set
        End Property

        Private sDataSet As DataGridView
        Public Property DataGridView() As DataGridView
            Get
                Return sDataSet
            End Get
            Set(ByVal value As DataGridView)
                sDataSet = value
            End Set
        End Property

        Public Property sTipo As TipoExport

        Private sNombreArchivo As String
        Public Property NombreArchivo() As String
            Get
                If sNombreArchivo Is Nothing Then
                    Return "Archivo"
                End If
                Return sNombreArchivo
            End Get
            Set(ByVal value As String)
                sNombreArchivo = value
            End Set
        End Property

        Public Property ColumnsWith As Dictionary(Of UShort, UShort)

    End Structure

    Public Enum TipoExport
        Excel = 0
        PDF = 1
        TXT = 2
    End Enum
    Module Exportar
        Sub Exportar_Elementos_Multiples(ByVal responseX As HttpResponse, ByVal sFormato As String, ByVal elementos As List(Of ElementoExportar))
            Dim cmd As SqlCommand = New SqlCommand()
            cmd.Connection = New SqlConnection(sConexion)
            Dim tables As List(Of DataTable) = New List(Of DataTable)
            Dim da As SqlDataAdapter = New SqlDataAdapter()
            Dim sheetName As String = ""
            Dim index As Integer = 1
            For Each elemento As ElementoExportar In elementos
                With elemento
                    cmd.CommandText = .Procedimiento

                    If Not IsNothing(.Parametros) Then
                        cmd.CommandType = CommandType.StoredProcedure
                        cmd.Parameters.Clear()
                        For n = 0 To elemento.Parametros.Count - 1
                            cmd.Parameters.AddWithValue(.Parametros(n).ParameterName, .Parametros(n).Value)
                        Next
                    Else
                        cmd.CommandType = CommandType.Text
                    End If
                    cmd.CommandTimeout = 300
                    da.SelectCommand = cmd
                    sheetName = IIf(IsNothing(.NombreHoja) Or .NombreHoja = "", "Sheet" & index, .NombreHoja)
                    Dim table As DataTable = New DataTable(sheetName)

                    da.Fill(table)
                    If .Where <> Nothing Then
                        table = table.Select(.Where).CopyToDataTable()
                    End If
                    If Not IsNothing(.Columnas) Then
                        table = SeleccionarColumnas(table, .Columnas)
                    End If
                    index += 1
                    tables.Add(table)
                End With
            Next
            Procesar_Multiple_Datos_Exportar(responseX, sFormato, tables)
            Desconectar()
        End Sub
        Private Function SeleccionarColumnas(ByVal table As DataTable, columnas As Dictionary(Of String, String)) As DataTable
            Dim dataView As DataView = New DataView(table)
            Dim _table As DataTable = New DataTable(table.TableName)

            Try
                _table = dataView.ToTable(table.TableName, True, columnas.Keys.ToArray())

                For Each column As DataColumn In _table.Columns
                    _table.Columns(column.ColumnName).ColumnName = columnas.Item(column.ColumnName)
                Next
            Catch ex As Exception
                Console.WriteLine(ex.Message)
            End Try
            Return _table
        End Function
        Private Sub Procesar_Multiple_Datos_Exportar(ByVal responseX As HttpResponse, ByVal sFormato As String, ByVal tables As List(Of DataTable))
            'LicenseHelper.ModifyInMemory.ActivateMemoryPatching()

            responseX.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
            If sFormato = "EXCEL" Then
                Dim cellExport As New Spire.DataExport.XLS.CellExport
                cellExport.AutoFitColWidth = True
                cellExport.AutoFitTitleWidth = True

                For Each table As DataTable In tables
                    Dim worksheet As New Spire.DataExport.XLS.WorkSheet
                    worksheet.AutoFitColWidth = True
                    worksheet.AutoFitTitleWidth = True

                    worksheet.DataSource = Spire.DataExport.Common.ExportSource.DataTable
                    worksheet.DataTable = table
                    worksheet.StartDataCol = (0)
                    worksheet.SheetName = table.TableName
                    cellExport.Sheets.Add(worksheet)

                Next

                cellExport.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView
                Dim memoriaStream As New MemoryStream
                cellExport.SaveToStream(memoriaStream)
                ViewFile(memoriaStream, responseX)
            End If
        End Sub
        Private Sub ViewFile(fs As Stream, responseX As HttpResponse)

            responseX.Clear()

            responseX.ContentType = "application/vnd.ms-excel"
            responseX.AddHeader("Content-Disposition", "attachment; filename=filename.xls")
            responseX.AddHeader("Content-Length", fs.Length.ToString())
            fs.CopyTo(responseX.OutputStream)
            responseX.OutputStream.Flush()
            responseX.OutputStream.Close()
        End Sub
        Sub Exportar_Datos(ByVal responseX As HttpResponse, ByVal sFormato As String, ByVal sProcedureName As String, Optional ByVal sWhere_DT As String = Nothing, Optional ByVal ParametersX As SqlClient.SqlParameterCollection = Nothing, Optional ByVal columnas As Dictionary(Of String, String) = Nothing)
            '-------------
            Dim cmd As SqlCommand = New SqlCommand()
            cmd.Connection = New SqlConnection(sConexion)
            cmd.CommandText = sProcedureName

            If Not IsNothing(ParametersX) Then
                cmd.CommandType = CommandType.StoredProcedure
                For n = 0 To ParametersX.Count - 1
                    cmd.Parameters.AddWithValue(ParametersX(n).ParameterName, ParametersX(n).Value)
                Next
            Else
                cmd.CommandType = CommandType.Text
            End If
            cmd.CommandTimeout = 300

            Dim da As SqlDataAdapter = New SqlDataAdapter()
            da.SelectCommand = cmd
            Dim table As DataTable = New DataTable("Sheet1")

            da.Fill(table)
            If sWhere_DT <> Nothing Then
                table = table.Select(sWhere_DT).CopyToDataTable()
            End If
            If Not IsNothing(columnas) Then
                table = SeleccionarColumnas(table, columnas)
            End If
            Procesar_Datos_Exportar(responseX, sFormato, table)
            Desconectar()
        End Sub
        Sub Procesar_Datos_Exportar(ByVal responseX As HttpResponse, ByVal sFormato As String, ByVal table As DataTable)
            Dim LData As String = "PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0idXRmLTgiIHN0YW5kYWxvbmU9InllcyI/Pgo8TGljZW5zZSBLZXk9ImNyOERaN1hKMkR5MUs2UUJBTkRPSVRLdlpjTzZkelVod2lsSHBnVlluQ3k0cXlHV2V6TFZubFJGeFAxNU1mSWZnUmdNWm1XaEdOQWRFNFRqZWZnQ1ovbFR2b1BkSXRIbDZXdDVBNWk1TVhFbnFkQnVPMUthRnovRFFzYUdWTGhzdjlySG1ybnRxSElFRGxJeGRxYUpNcGtLb0Frd1A3d1N6T01KMVkrbUNmVTVVRmV6REwvTjd1enJ4M0Y0d2I1SGErd0E2VFQ5VFJ3SzAzejlFS01aRmwzU1lSL3o0YVU3TE0wZFNYWTlqU0ZKZ2dqZlZzRFVLaUJyVm5td1ljaXVyOUVrYmw5Q3RaWTAzdG1yZm01QlplKzZnaHRFTm4wb2gzMzh0WlJleWpjcjc0QWs3MWhnWWtuTE9CQzE1VllmalhzcXVBVW13MlI2TWNWMlBPT2JyY1RSYlhBZ3pvUWJPeWQ4U2JFWmN3aE43NktQd1dzUVFTMUowdGlZSFVLeE9tMnQ0ZkJWMGhQVmhhOUI4Y0swNHFKUVp0MDBaMWNKRGEwd2I4VWx6RWs5QkhVVzJlbk9mVDE0UnlIQ2krWUdlbVBLY2RDUXJoMXpyWVRGN0ltb0x4N3h1NGV2RFRZc2xzV0JrbFFJb3g4NnJWckVVa1N0dXErQUNTWS9xVTM5L1Zhd3Y5S0FmUjVUZUVicGt3RGhTYjBOQkFqVDhBeXRsRFZkR2ZpZzBxS0czVllpVHBYRnc1cHRMVmgrYmtkK2RnN3Z4dHZyNDVaVVdKZXlyekdOR0g3YUZZZDZwLzJNRy9YSlRsR3ovU05RbzJDUExraU83SlhuOU5HZXhaN3BIbTBkZ3pNWmJHRVhxVmR2bG04MTJhL1hMMVNxeEdVWStvNVpsVUM3WTV4Z2dhRCtGZVA5enpoeUpxSUVwcDk3My9ScTRteG1wQWZMcVNzTzJSeHlTcStpdjFDc3AwQ3JvMDc4OEhybDFteWt4dVQweWRSWVpDNkRTeDhNMi9MWTNkOXNud3U3NkFmYjVDOVF1ZE9Zc0wzREh2aGZncmNVSWUvcUhmVFo5QWF6Y3pUanlyM2RPQkFjczBLZk12Y0xVUzRSeHZDdW1NNDVyNDJnMXJ3UGluN2JBcmYvZnNMTzZtS3g0WWRoSURNWlF6V3RjbkhFSTF5TXJ6aU9pdXhMdE8xalRBV25uU2VLVDJ0cXI3Tm42Qmg5TURHNjZZK2lJaW4xV05TUCtMdDFYdXRkajNKTyt4b1FNUVB5ZFpoZkJYZXpVMEhRMnd0eEdwdzRNczRTMTVJbFg1TEdXR3dXeUdYTWNjVWd3b1RDeFRGYmgyZFo0Vkg3OVZHTEVFR1JRWEZrNTRBdlFLdFBpdUcxY0w4RFo3WEoyRHkxSzZUUWVORE9YeFl2NFNveitCMHNBS0VwTVRrNCtTYWpYNksrSjlUOFhZVXRTOE8wWWZGUFZqZkhIYTZORWQyODdVcUlqMnJnQlF1bjVDV3hCczFHUm5BYmd1Z3MyL2ZQakcwZmdQemdSYzR5Q3ZObFg4V2pKUnloc3U5VFRKTjd1R3NOdnprU2IyZWlyQmhEaG1vQ0Jqa0wyYnMzT3I2d2pnNnBUNVpmNGhEdDF0STBJNXo1aytxQXVSZnRhd1lmamhXYmpMS0xKOTlUVk1kRDZaTCtTenNtQkNWN05lYm96V0RUTWgrRnJPT292R09ZbUk1bWp4Smd1MVRXNnI1V0JUK2oxSjBFNmJIb2tEMWo0Wm1DWUQreVBPUW1PMm1yUTNGdC9jVmZwQWlJdzliRkgwZ1FIbXQ4QnNuZnQ2MVV3c1h6cSs2akNvY1hOOUMvRXZPblhTczZuVlNGSkVBL3l1QmNIazZxOWdqanBnRG1NTEcrNlpxR1VjRWMzZEp2THpuK3pNT0p3TDI4WUQxN3BLSXBUNnd6WFBFVFJwWS9qNHhoMkQvaFhJRVNHcTk1eTVmZE9MNmx1QT09IiBWZXJzaW9uPSI5LjkiPgogICAgPFR5cGU+UnVudGltZTwvVHlwZT4KICAgIDxVc2VybmFtZT5Vc2VyTmFtZTwvVXNlcm5hbWU+CiAgICA8RW1haWw+ZU1haWxAaG9zdC5jb208L0VtYWlsPgogICAgPE9yZ2FuaXphdGlvbj5Pcmdhbml6YXRpb248L09yZ2FuaXphdGlvbj4KICAgIDxMaWNlbnNlZERhdGU+MjAxNi0wMS0wMVQxMjowMDowMFo8L0xpY2Vuc2VkRGF0ZT4KICAgIDxFeHBpcmVkRGF0ZT4yMDk5LTEyLTMxVDEyOjAwOjAwWjwvRXhwaXJlZERhdGU+CiAgICA8UHJvZHVjdHM+CiAgICAgICAgPFByb2R1Y3Q+CiAgICAgICAgICAgIDxOYW1lPlNwaXJlLk9mZmljZSBQbGF0aW51bTwvTmFtZT4KICAgICAgICAgICAgPFZlcnNpb24+OS45OTwvVmVyc2lvbj4KICAgICAgICAgICAgPFN1YnNjcmlwdGlvbj4KICAgICAgICAgICAgICAgIDxOdW1iZXJPZlBlcm1pdHRlZERldmVsb3Blcj45OTk5OTwvTnVtYmVyT2ZQZXJtaXR0ZWREZXZlbG9wZXI+CiAgICAgICAgICAgICAgICA8TnVtYmVyT2ZQZXJtaXR0ZWRTaXRlPjk5OTk5PC9OdW1iZXJPZlBlcm1pdHRlZFNpdGU+CiAgICAgICAgICAgIDwvU3Vic2NyaXB0aW9uPgogICAgICAgIDwvUHJvZHVjdD4KICAgIDwvUHJvZHVjdHM+CiAgICA8SXNzdWVyPgogICAgICAgIDxOYW1lPklzc3VlcjwvTmFtZT4KICAgICAgICA8RW1haWw+aXNzdWVyQGlzc3Vlci5jb208L0VtYWlsPgogICAgICAgIDxVcmw+aHR0cDovL3d3dy5pc3N1ZXIuY29tPC9Vcmw+CiAgICA8L0lzc3Vlcj4KPC9MaWNlbnNlPg=="

            'LicenseHelper.ModifyInMemory.ActivateMemoryPatching()

            responseX.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
            LData = "PD94bWwgdmVyc2lvbj0iMS4wIiBlbmNvZGluZz0idXRmLTgiIHN0YW5kYWxvbmU9InllcyI/Pg0KPExpY2Vuc2UgS2V5PSJjcjhEWjdYSjJEeTFLNlFCQU5ET0lUS3ZaY082ZHpVaHdpbEhwZ1ZZbkN5NHF5R1dlekxWbmxSRnhQMTVNZklmZ1JnTVptV2hHTkFkRTRUamVmZ0NaL2xUdm9QZEl0SGw2V3Q1QTVpNU1YRW5xZEJ1TzFLYUZ6L0RRc2FHVkxoc3Y5ckhtcm50cUhJRURsSXhkcWFKTXBrS29Ba3dQN3dTek9NSjFZK21DZlU1VUZlekRML043dXpyeDNGNHdiNUhhK3dBNlRUOVRSd0swM3o5RUtNWkZsM1NZUi96NGFVN0xNMGRTWFk5alNGSmdnamZWc0RVS2lCclZubXdZY2l1cjlFa2JsOUN0WlkwM3RtcmZtNUJaZSs2Z2h0RU5uMG9oMzM4dFpSZXlqY3I3NEFrNzFoZ1lrbkxPQkMxNVZZZmpYc3F1QVVtdzJSNk1jVjJQT09icmNUUmJYQWd6b1FiT3lkOFNiRVpjd2hONzZLUHdXc1FRUzFKMHRpWUhVS3hPbTJ0NGZCVjBoUFZoYTlCOGNLMDRxSlFadDAwWjFjSkRhMHdiOFVsekVrOUJIVVcyZW5PZlQxNFJ5SENpK1lHZW1QS2NkQ1FyaDF6cllURjdJbW9MeDd4dTRldkRUWXNsc1dCa2xRSW94ODZyVnJFVWtTdHVxK0FDU1kvcVUzOS9WYXd2OUtBZlI1VGVFYnBrd0RoU2IwTkJBalQ4QXl0bERWZEdmaWcwcUtHM1ZZaVRwWEZ3NXB0TFZoK2JrZCtkZzd2eHR2cjQ1WlVXSmV5cnpHTkdIN2FGWWQ2cC8yTUcvWEpUbEd6L1NOUW8yQ1BMa2lPN0pYbjlOR2V4WjdwSG0wZGd6TVpiR0VYcVZkdmxtODEyYS9YTDFTcXhHVVkrbzVabFVDN1k1eGdnYUQrRmVQOXp6aHlKcUlFcHA5NzMvUnE0bXhtcEFmTHFTc08yUnh5U3EraXYxQ3NwMENybzA3ODhIcmwxbXlreHVUMHlkUllaQzZEU3g4TTIvTFkzZDlzbnd1NzZBZmI1QzlRdWRPWXNMM0RIdmhmZ3JjVUllL3FIZlRaOUFhemN6VGp5cjNkT0JBY3MwS2ZNdmNMVVM0Unh2Q3VtTTQ1cjQyZzFyd1BpbjdiQXJmL2ZzTE82bUt4NFlkaElETVpReld0Y25IRUkxeU1yemlPaXV4THRPMWpUQVdublNlS1QydHFyN05uNkJoOU1ERzY2WStpSWluMVdOU1ArTHQxWHV0ZGozSk8reG9RTVFQeWRaaGZCWGV6VTBIUTJ3dHhHcHc0TXM0UzE1SWxYNUxHV0d3V3lHWE1jY1Vnd29UQ3hURmJoMmRaNFZINzlWR0xFRUdSUVhGazU0QXZRS3RQaXVHMWNMOERaN1hKMkR5MUs2VFFlTkRPWHhZdjRTb3orQjBzQUtFcE1UazQrU2FqWDZLK0o5VDhYWVV0UzhPMFlmRlBWamZISGE2TkVkMjg3VXFJajJyZ0JRdW41Q1d4QnMxR1JuQWJndWdzMi9mUGpHMGZnUHpnUmM0eUN2TmxYOFdqSlJ5aHN1OVRUSk43dUdzTnZ6a1NiMmVpckJoRGhtb0NCamtMMmJzM09yNndqZzZwVDVaZjRoRHQxdEkwSTV6NWsrcUF1UmZ0YXdZZmpoV2JqTEtMSjk5VFZNZEQ2WkwrU3pzbUJDVjdOZWJveldEVE1oK0ZyT09vdkdPWW1JNW1qeEpndTFUVzZyNVdCVCtqMUowRTZiSG9rRDFqNFptQ1lEK3lQT1FtTzJtclEzRnQvY1ZmcEFpSXc5YkZIMGdRSG10OEJzbmZ0NjFVd3NYenErNmpDb2NYTjlDL0V2T25YU3M2blZTRkpFQS95dUJjSGs2cTlnampwZ0RtTUxHKzZacUdVY0VjM2RKdkx6bit6TU9Kd0wyOFlEMTdwS0lwVDZ3elhQRVRScFkvajR4aDJEL2hYSUVTR3E5NXk1ZmRPTDZsdUE9PSIgVmVyc2lvbj0iOS45Ij4NCiAgICA8VHlwZT5SdW50aW1lPC9UeXBlPg0KICAgIDxVc2VybmFtZT5Vc2VyTmFtZTwvVXNlcm5hbWU+DQogICAgPEVtYWlsPmVNYWlsQGhvc3QuY29tPC9FbWFpbD4NCiAgICA8T3JnYW5pemF0aW9uPk9yZ2FuaXphdGlvbjwvT3JnYW5pemF0aW9uPg0KICAgIDxMaWNlbnNlZERhdGU+MjAxNi0wMS0wMVQxMjowMDowMFo8L0xpY2Vuc2VkRGF0ZT4NCiAgICA8RXhwaXJlZERhdGU+MjA5OS0xMi0zMVQxMjowMDowMFo8L0V4cGlyZWREYXRlPg0KICAgIDxQcm9kdWN0cz4NCiAgICAgICAgPFByb2R1Y3Q+DQogICAgICAgICAgICA8TmFtZT5TcGlyZS5PZmZpY2UgUGxhdGludW08L05hbWU+DQogICAgICAgICAgICA8VmVyc2lvbj45Ljk5PC9WZXJzaW9uPg0KICAgICAgICAgICAgPFN1YnNjcmlwdGlvbj4NCiAgICAgICAgICAgICAgICA8TnVtYmVyT2ZQZXJtaXR0ZWREZXZlbG9wZXI+OTk5OTk8L051bWJlck9mUGVybWl0dGVkRGV2ZWxvcGVyPg0KICAgICAgICAgICAgICAgIDxOdW1iZXJPZlBlcm1pdHRlZFNpdGU+OTk5OTk8L051bWJlck9mUGVybWl0dGVkU2l0ZT4NCiAgICAgICAgICAgIDwvU3Vic2NyaXB0aW9uPg0KICAgICAgICA8L1Byb2R1Y3Q+DQogICAgPC9Qcm9kdWN0cz4NCiAgICA8SXNzdWVyPg0KICAgICAgICA8TmFtZT5Jc3N1ZXI8L05hbWU+DQogICAgICAgIDxFbWFpbD5pc3N1ZXJAaXNzdWVyLmNvbTwvRW1haWw+DQogICAgICAgIDxVcmw+aHR0cDovL3d3dy5pc3N1ZXIuY29tPC9Vcmw+DQogICAgPC9Jc3N1ZXI+DQo8L0xpY2Vuc2U+"

            Spire.License.LicenseProvider.SetLicenseKey(LData)

            'LicenseHelper.ModifyInMemory.ActivateMemoryPatching() 'comentado by Oscar Sabe 

            responseX.ContentType = "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
            If sFormato = "EXCEL" Then
                'If table.Rows.Count > 65000 Then
                '    Dim cloWbook As New ClosedXML.Excel.XLWorkbook
                '    cloWbook.Worksheets.Add(table, "Export")
                '    Crear_ArchivosFisicos(cloWbook, "Export")
                'Else
                'Dim cellExport As New Spire.DataExport.XLS.CellExport

                Dim Wbook As Spire.Xls.Workbook = New Spire.Xls.Workbook()
                Dim WShet As Spire.Xls.Worksheet
                Wbook.Version = Spire.Xls.ExcelVersion.Version2013
                Wbook.Worksheets.Clear()
                WShet = Wbook.Worksheets.Add("Socios")


                WShet.InsertDataTable(table, True, 1, 1)

                Dim memoriaStream As New MemoryStream
                Wbook.SaveToHttpResponse("Descarga.xlsx", responseX)

            ElseIf sFormato = "DBF" Then
                Dim dbfExport1 = New Spire.DataExport.DBF.DBFExport
                'dbfExport1.ActionAfterExport = Spire.DataExport.Common.ActionType.OpenView
                dbfExport1.DataFormats.CultureName = "es-MX"
                dbfExport1.DataTable = table
                dbfExport1.DataSource = Spire.DataExport.Common.ExportSource.DataTable
                dbfExport1.SaveToHttpResponse("Export", responseX)
                '
            ElseIf sFormato = "HTML" Then

                Dim HtmExport1 = New Spire.DataExport.HTML.HTMLExport
                HtmExport1.DataTable = table
                HtmExport1.DataSource = Spire.DataExport.Common.ExportSource.DataTable
                HtmExport1.SaveToFile("Export")

            ElseIf sFormato = "PDF" Then
                Dim pdfExport1 = New Spire.DataExport.PDF.PDFExport
                pdfExport1.DataFormats.CultureName = "es-MX"
                pdfExport1.DataFormats.Currency = "c"

                pdfExport1.PDFOptions.PageOptions.Format = Spire.DataExport.PDF.PageFormat.Letter
                pdfExport1.PDFOptions.PageOptions.Orientation = Spire.DataExport.Common.PageOrientation.Landscape

                pdfExport1.DataTable = table
                pdfExport1.DataSource = Spire.DataExport.Common.ExportSource.DataTable
                pdfExport1.SaveToHttpResponse("Export", responseX)

            ElseIf sFormato = "RTF" Then

                Dim rtfExport1 = New Spire.DataExport.RTF.RTFExport

                rtfExport1.DataFormats.CultureName = "es-MX"
                rtfExport1.DataFormats.Currency = "c"

                rtfExport1.RTFOptions.DataStyle.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
                rtfExport1.RTFOptions.FooterStyle.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
                rtfExport1.RTFOptions.HeaderStyle.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World)
                rtfExport1.RTFOptions.TitleStyle.Alignment = Spire.DataExport.RTF.RtfTextAlignment.Center
                rtfExport1.RTFOptions.TitleStyle.Font = New System.Drawing.Font("Arial", 10.0!, System.Drawing.FontStyle.Bold)
                rtfExport1.DataTable = table
                rtfExport1.DataSource = Spire.DataExport.Common.ExportSource.DataTable
                rtfExport1.SaveToHttpResponse("Export.csv", responseX)

            ElseIf sFormato = "TXT" Then
                Dim txtExport1 = New Spire.DataExport.TXT.TXTExport

                txtExport1.CustomFormats.Text = "TXT"

                txtExport1.DataFormats.CultureName = "es-MX"

                txtExport1.DataTable = table
                txtExport1.DataSource = Spire.DataExport.Common.ExportSource.DataTable
                txtExport1.SaveToHttpResponse("Export", responseX)

            ElseIf sFormato = "XML" Then
                Dim xmlExport1 = New Spire.DataExport.XML.XMLExport
                xmlExport1.DataFormats.CultureName = "es-MX"

                xmlExport1.DataTable = table
                xmlExport1.DataSource = Spire.DataExport.Common.ExportSource.DataTable
                xmlExport1.SaveToHttpResponse("Export", responseX)

            ElseIf sFormato = "SQL" Then

                Dim sqlExport1 = New Spire.DataExport.SQL.SQLExport
                sqlExport1.DataFormats.CultureName = "es-MX"

                sqlExport1.DataTable = table
                sqlExport1.DataSource = Spire.DataExport.Common.ExportSource.DataTable
                sqlExport1.SaveToHttpResponse("Export", responseX)
            ElseIf sFormato = "CLIPBOARD" Then
            End If
        End Sub
    End Module
#End Region

#Region "Mensajería"

    '    Module Mensajeria
    '        Dim alertas As New Notificaciones
    '        Dim GuardarConteo As New ConteoMensajes.ConteoMsj
    '        Function WhastAppMsj(ByVal Mensaje As String)
    '            Dim id As String = "AC8c66580d161345a34e78de94fc5e28f3"
    '            Dim Token As String = "4c32140cffd21b3777248db885c43f47"

    '            Twilio.TwilioClient.Init(id, Token)
    '            Dim NumeroReceptor = New PhoneNumber("whatsapp:+5219934426437")
    '            Dim NumeroEmisor = New PhoneNumber("whatsapp:+14155238886")
    '            'Dim msj = MessageResource.Create([to]:=NumeroReceptor, from:=NumeroEmisor, body:="PruebaMsj")
    '            Dim MsjOptions = New CreateMessageOptions(NumeroReceptor)
    '            MsjOptions.From = NumeroEmisor
    '            MsjOptions.Body = Mensaje

    '            Dim msj = MessageResource.Create(MsjOptions)
    '            alertas.NotificacionExito(msj.Sid, "Exito")
    '            GuardarConteo.GuardarMs(Application.Session("Cve_Instituto"), 0, 1)
    '        End Function

    '        Function WhatsappDocuments(ByVal NombreDocumento As String)


    '            Dim id As String = "AC8c66580d161345a34e78de94fc5e28f3"
    '            Dim Token As String = "4c32140cffd21b3777248db885c43f47"





    '            Dim Url = New Uri("http://74.208.239.165/iSISCOL_DEMO" & NombreDocumento)
    '            Dim pdf1 As New List(Of Uri)
    '            pdf1.Add(Url)

    '            Twilio.TwilioClient.Init(id, Token)
    '            Dim NumeroReceptor = New PhoneNumber("whatsapp:+5219934426437")
    '            Dim NumeroEmisor = New PhoneNumber("whatsapp:+14155238886")
    '            'Dim msj = MessageResource.Create([to]:=NumeroReceptor, from:=NumeroEmisor, body:="PruebaMsj")
    '            Dim MsjOptions = New CreateMessageOptions(NumeroReceptor)
    '            MsjOptions.From = NumeroEmisor
    '            MsjOptions.Body = "Bienvenido"
    '            MsjOptions.MediaUrl = pdf1
    '            Dim msj = MessageResource.Create(MsjOptions)
    '            alertas.NotificacionExito(msj.Sid, "Exito")
    '            GuardarConteo.GuardarMs(Application.Session("Cve_Instituto"), 0, 1)

    '        End Function



    '    End Module

#End Region

#Region "Licencia y Encriptado"
    Module Encriptado
        Function Busqueda_Secreta() As String
            Try
                Dim strMACAddress As String = ""
                '
                ' Create the query, in SQL syntax, to retrieve the properties from
                ' the active Network Adapter.
                '
                Dim strQuery As String =
             "SELECT * FROM Win32_NetworkAdapterConfiguration WHERE IPEnabled = True"

                '
                ' Create a ManagementObjectSearcher object passing in the query to run.
                '
                Dim query As System.Management.ManagementObjectSearcher = New System.Management.ManagementObjectSearcher(strQuery)

                '
                ' Create a ManagementObjectCollection assigning it the results of the query.
                '
                Dim queryCollection As System.Management.ManagementObjectCollection = query.Get()

                '
                ' Loop through the results extracting the MAC Address.
                '
                Dim mo As System.Management.ManagementObject

                For Each mo In queryCollection
                    strMACAddress = mo("MacAddress").ToString().Replace(":", "")
                    Exit For
                Next

                Return strMACAddress & "HDD" & hddID()

            Catch ex As Exception
                Return ""
            End Try
        End Function
        Function hddID() As String
            Try
                Dim strSN As String = ""
                Dim strQuery As String = "SELECT * FROM Win32_PhysicalMedia"
                Dim query As System.Management.ManagementObjectSearcher = New System.Management.ManagementObjectSearcher(strQuery)
                Dim i As Integer = 0

                For Each mo As System.Management.ManagementObject In query.[Get]()


                    If mo("SerialNumber") IsNot Nothing Then
                        '    strSN = strSN & " " & "N/A Serial"
                        'Else
                        strSN = strSN & "" & mo("SerialNumber").ToString()
                    End If
                    i += 1
                Next

                Return Trim(strSN)

            Catch ex As Exception
                Return ""
            End Try
        End Function
        Public Function encriptar128BitRijndael(ByVal textoEncriptar As String, ByVal claveEncriptacion As String) As String
            Dim bytValue() As Byte
            Dim bytKey() As Byte
            Dim bytEncoded() As Byte = New Byte() {}
            Dim bytIV() As Byte = {121, 241, 10, 1, 132,
                                   74, 11, 39, 255, 91, 45,
                                   78, 14, 211, 22, 62}
            Dim intLength As Integer
            Dim intRemaining As Integer
            Dim objMemoryStream As New MemoryStream()
            Dim objCryptoStream As CryptoStream
            Dim objRijndaelManaged As RijndaelManaged


            'Quitar nulos en cadena de texto a encriptar
            textoEncriptar = textoEncriptar

            If textoEncriptar = "" Then
                Return ""
            End If

            bytValue = System.Text.Encoding.ASCII.GetBytes(textoEncriptar.ToCharArray)

            intLength = Len(claveEncriptacion)


            'La clave de cifrado debe ser de 256 bits de longitud (32 bytes)
            'Si tiene más de 32 bytes se truncará
            'Si es menor de 32 bytes se rellenará con X
            If intLength >= 32 Then
                claveEncriptacion = Strings.Left(claveEncriptacion, 32)
            Else
                intLength = Len(claveEncriptacion)
                intRemaining = 32 - intLength
                claveEncriptacion = claveEncriptacion & Strings.StrDup(intRemaining, "X")
            End If

            bytKey = System.Text.Encoding.ASCII.GetBytes(claveEncriptacion.ToCharArray)

            objRijndaelManaged = New RijndaelManaged()

            Try
                'Crear objeto Encryptor y escribir su valor 
                'después de que se convierta en array de bytes
                objCryptoStream = New CryptoStream(objMemoryStream,
                  objRijndaelManaged.CreateEncryptor(bytKey, bytIV),
                  CryptoStreamMode.Write)
                objCryptoStream.Write(bytValue, 0, bytValue.Length)

                objCryptoStream.FlushFinalBlock()

                bytEncoded = objMemoryStream.ToArray
                objMemoryStream.Close()
                objCryptoStream.Close()
            Catch ex As Exception
                MessageBox.Show("Error al encriptar cadena de texto: " &
                       ex.Message, MessageBoxButtons.OK + MessageBoxIcon.Information)
            End Try

            'Devolver el valor del texto encriptado
            'convertido de array de bytes a texto en base64
            Return Convert.ToBase64String(bytEncoded)
        End Function
        Public Function desencriptar128BitRijndael(
           ByVal textoEncriptado As String,
           ByVal claveDesencriptacion As String) As String

            Try

                Dim bytDataToBeDecrypted() As Byte
                Dim bytTemp() As Byte
                Dim bytIV() As Byte = {121, 241, 10, 1, 132,
                                       74, 11, 39, 255, 91,
                                       45, 78, 14, 211, 22, 62}
                Dim objRijndaelManaged As New RijndaelManaged()
                Dim objMemoryStream As MemoryStream
                Dim objCryptoStream As CryptoStream
                Dim bytDecryptionKey() As Byte

                Dim intLength As Integer
                Dim intRemaining As Integer
                Dim strReturnString As String = String.Empty

                If textoEncriptado = "" Then
                    Return ""
                End If

                'Convertir el valor encriptado base64 a array de bytes
                bytDataToBeDecrypted = Convert.FromBase64String(textoEncriptado)

                'La clave de desencriptación debe ser de 256 bits de longitud (32 bytes)
                'Si tiene más de 32 bytes se truncará
                'Si es menor de 32 bytes se rellenará con A
                intLength = Len(claveDesencriptacion)

                If intLength >= 32 Then
                    claveDesencriptacion = Strings.Left(claveDesencriptacion, 32)
                Else
                    intLength = Len(claveDesencriptacion)
                    intRemaining = 32 - intLength
                    claveDesencriptacion = claveDesencriptacion & Strings.StrDup(intRemaining, "X")
                End If

                bytDecryptionKey = System.Text.Encoding.ASCII.GetBytes(claveDesencriptacion.ToCharArray)

                ReDim bytTemp(bytDataToBeDecrypted.Length)

                objMemoryStream = New MemoryStream(bytDataToBeDecrypted)

                'Crear objeto Dencryptor y escribir su valor 
                'después de que se convierta en array de bytes
                objCryptoStream = New CryptoStream(objMemoryStream,
                   objRijndaelManaged.CreateDecryptor(bytDecryptionKey, bytIV),
                   CryptoStreamMode.Read)

                objCryptoStream.Read(bytTemp, 0, bytTemp.Length)

                'objCryptoStream.FlushFinalBlock()
                objMemoryStream.Close()
                objCryptoStream.Close()

                'Devolver la cadena de texto desencriptada
                'convertida de array de bytes a cadena de texto ASCII
                Return System.Text.Encoding.ASCII.GetString(bytTemp)
            Catch ex As Exception

                Exit Function
            End Try
        End Function
    End Module
#End Region


    Class ImportarImagen
        Private sRuta As String = Application.StartupPath & "\Resources\"
        Private Property sNombreArchivo As String
        '  Private Property sExtension As String
        Private Property sPictureBox As PictureBox


        Function Importar(ByRef sPictureBox As PictureBox, sNombreArchivo As String, Optional ByVal sRuta As String = Nothing) As String
            Me.sNombreArchivo = sNombreArchivo
            If sRuta IsNot Nothing Then Me.sRuta = sRuta
            Me.sPictureBox = sPictureBox
            Dim sUpload As New Upload
            sUpload.UploadFiles()
            AddHandler sUpload.Uploaded, AddressOf upload_uploaded
        End Function
        Private Sub upload_uploaded(sender As Object, e As UploadedEventArgs)
            sPictureBox.Image = Nothing
            sPictureBox.ImageSource = Nothing
            'sPictureBox.Dispose()
            Dim sRuta As String = FileValid(e)
            If sRuta IsNot Nothing Then sPictureBox.Image = New Bitmap(sRuta)
        End Sub

        Private Function FileValid(e As UploadedEventArgs) As String
            Try
                Dim ParametersX_Global() As System.Data.SqlClient.SqlParameter = Nothing, i As Integer = 0
                If Path.HasExtension(e.Files(0).FileName) Then
                    If Path.GetExtension(e.Files(0).FileName).ToLower = ".png" Or Path.GetExtension(e.Files(0).FileName).ToLower = ".jpg" Then
                        Dim sRutaCompleta As String = Me.sRuta & sNombreArchivo
                        If File.Exists(sRutaCompleta) Then
                            ' File.Delete(sRutaCompleta)
                        End If
                        Dim sfileStream As FileStream = File.Create(sRutaCompleta)
                        Using sFile As Stream = e.Files(0).InputStream
                            sFile.CopyTo(sfileStream)
                            sFile.Close()
                            ' sFile.Dispose()
                        End Using
                        If System.IO.File.Exists(sfileStream.Name) Then
                            sfileStream.Close()
                            'sfileStream.Dispose()
                            Return sfileStream.Name
                        End If
                    End If
                End If

            Catch ex As Exception
                ' RaiseEvent ErrorDescripcion(ex.Message)
                Return Nothing
            End Try
            Return Nothing

        End Function
    End Class


End Namespace