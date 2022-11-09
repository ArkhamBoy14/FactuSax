Imports System
Imports Wisej.Web
Imports System.Data
Imports System.Data.SqlClient

Public Class Login
    Dim bProcesa As Boolean
    Dim nCuentaVeces_Fallo As Integer
    Dim altura_Maxima_Imagen As Integer = 0
    Dim Command As New SqlCommand
    Public Function ValidarUsuario(ByVal User As String, ByVal Pass As String) As Boolean
        Try
            If Utilidades.Login(User, Pass) Then
                Return True
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Function

    Private Sub Centrar(ByVal Objeto As Object, Optional ByVal Horizontal As Boolean = True, Optional ByVal Vertical As Boolean = True)

        'Centrar un Formulario ...  
        If TypeOf Objeto Is Form Then
            Dim frm As Form = CType(Objeto, Form)
            With Screen.WorkingArea ' Dimensiones de la pantalla sin el TaskBar  
                If Vertical Then frm.Top = (.Height - frm.Height) \ 2
                If Horizontal Then frm.Left = (.Width - frm.Width) \ 2
            End With

            ' Centrar un control dentro del contenedor  
        Else
            ' referencia al control  
            Dim c As Control = CType(Objeto, Control)

            'le  establece el top y el Left dentro del Parent  
            With c
                If Vertical Then .Top = (.Parent.Size.Height - c.Height) \ 2
                If Horizontal Then .Left = (.Parent.Size.Width - c.Width) \ 2
            End With
        End If
    End Sub

    Private Sub ReajustarImagen()
        'altura_Maxima_Imagen = PanelLogin.Parent.Size.Height - PanelLogin.Height - PictureBoxLogo.Location.Y

        'With PictureBoxLogo
        '    Dim Ancho As Integer = .Image.Width
        '    Dim Alto As Integer = .Image.Height
        '    Dim radio As Double = Ancho / Alto
        '    .Height = altura_Maxima_Imagen
        '    .Width = altura_Maxima_Imagen * radio
        '    Centrar(PictureBoxLogo, Vertical:=False)
        'End With
    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        PanelForm.BackColor = System.Drawing.Color.FromArgb(76, 76, 76)

        ReajustarImagen()
        Centrar(PanelForm, Vertical:=False)
    End Sub

    Private Sub Login_SizeChanged(sender As Object, e As EventArgs) Handles MyBase.ClientSizeChanged
        ReajustarImagen()
        Centrar(PanelForm, Vertical:=False)
    End Sub

    Private Sub bLogin_Click(sender As Object, e As EventArgs) Handles bLogin.Click
        If String.IsNullOrWhiteSpace(cUsuario.Text) Then
            Exit Sub
        End If
        If String.IsNullOrWhiteSpace(cContrasena.Text) Then
            Exit Sub
        End If
        Entrada()
    End Sub


    Sub Entrada() 'Este es el reemplazo del Login
        If ValidarUsuario(cUsuario.Text, cContrasena.Text) Then
            Obtener_Datos(cUsuario.Text.ToUpper)
            'Obtener_Datos_Instituto()
            Configuracion_Inicial()
            Me.Dispose()

            Dim desktop As New MyDesktop()
            Application.Desktop = desktop

        Else
            LabelError.Visible = True

        End If
    End Sub

    Sub Obtener_Datos(ByVal Usuario As String)
        Utilidades.Conectar()
        Dim DataReader As Data.SqlClient.SqlDataReader

        Try
            Command = New SqlClient.SqlCommand("pCAT_OPERADORES_B", Utilidades.cConnect)
            Command.CommandType = CommandType.StoredProcedure
            Command.Parameters.AddWithValue("@Cve_Operador", Usuario)
            DataReader = Command.ExecuteReader(CommandBehavior.CloseConnection)
            If DataReader.HasRows Then
                While (DataReader.Read)

                    Application.Session("Cve_Operador") = DataReader.Item("Cve_Operador")
                    Application.Session("Nombre") = DataReader.Item("Nombre")
                    Application.Session("ROL") = DataReader.Item("ROL")
                    Application.Session("Cve_Rol") = DataReader.Item("Cve_Rol")
                    Application.Session("URL_Fotografia") = DataReader.Item("URL_Fotografia")
                    Application.Session("Interfaz") = DataReader.Item("InterfezTipo")
                    Application.Session("Tema") = DataReader.Item("Skin_Seleccionado")
                    Application.Session("Wallpaper") = DataReader.Item("Wallpaper")

                End While
            Else
                'Dim ConfiguracionColegio As New Cat_Instituto
                'ConfiguracionColegio.ShowDialog()
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



    Sub Configuracion_Inicial()
        'Utilidades.Conectar()
        'Dim cDataReader As Data.SqlClient.SqlDataReader
        'Try
        '    Utilidades.cCommand = New SqlClient.SqlCommand("pCAT_PARAMETROS_B", Utilidades.cConnect)
        '    Utilidades.cCommand.CommandType = CommandType.StoredProcedure
        '    'Utilidades.cCommand.Parameters.AddWithValue("@HABILITADO", 1)
        '    cDataReader = Utilidades.cCommand.ExecuteReader(CommandBehavior.CloseConnection)
        '    If cDataReader.HasRows Then
        '        While (cDataReader.Read)
        '            Application.Session("VisualizarCajasAbiertas") = cDataReader.Item("VisualizarCajasAbiertas")
        '            Application.Session("Folio_Cartas") = cDataReader.Item("Folio_Cartas")
        '            Application.Session("Adeudos") = "" & cDataReader.Item("Adeudos")
        '            Application.Session("Porcentaje_Eventos") = "" & cDataReader.Item("Porcentaje_Eventos")
        '            Application.Session("Agremiado_CambioCategoria") = cDataReader.Item("Agremiado_CambioCategoria")
        '        End While
        '    End If
        '    '<-- Agregar a Configuracion Inicial
        '    Application.Session("SalarioMinimo") = 88.36
        '    Application.Session("VidaUtil") = 30
        '    Application.Session("EdadEfectiva") = 25
        '    '---------
        'Catch ex As SystemException
        '    MessageBox.Show("Error: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        '    Exit Sub
        'Finally
        '    If IsNothing(cDataReader) = False Then
        '        If cDataReader.IsClosed = False Then cDataReader.Close()
        '    End If
        '    Utilidades.Desconectar()
        'End Try
    End Sub



    Private Sub CUsuario_EnterKeyDown(sender As Object, e As KeyEventArgs) Handles cUsuario.KeyDown
        If e.KeyCode = Keys.Enter Then
            Entrada()
        End If
    End Sub

    Private Sub CContrasena_KeyDown(sender As Object, e As KeyEventArgs) Handles cContrasena.KeyDown
        If e.KeyCode = Keys.Enter Then
            Entrada()
        End If
    End Sub
End Class


