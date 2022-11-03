Imports System
Imports Wisej.Web
Imports System.Data.SqlClient
Imports Wisej.Web.Ext.RibbonBar
Imports System.Data
Imports System.IO

Public Class MyDesktop
    Dim dicParametros As New Dictionary(Of String, String)
    Private url_relativa_carpeta As String
    Dim exten As String
    Dim sModulo As String
    Dim ParametersX() As SqlClient.SqlParameter
    Public alternateSucursal As String
    Dim Alertas As New Notificaciones
    Dim posicion As Integer = 0

    Private Sub MyDesktop_Load(sender As Object, e As EventArgs) Handles Me.Load
        ''Dim sPath = "/Resources/images/Fondo02.jpeg"
        'AlertBox.Show("Hola Mundo")
        Application.Title = "FactuSax"
        Application.FavIconSource = "Resources\Icons\FavIcon.ico"
        Dim sPath = "Resources/Images/LOGOS/Wallpaper/isiscol_portada.jpeg"
        If Application.Session("Wallpaper") = "NA" Then
            Me.Wallpaper = sPath
        Else
            Me.Wallpaper = Application.Session("Wallpaper")
        End If
        CargarDatos()
        'Application.LoadTheme(Application.Session("TEMA"))
        'MOSTAR_ULTIMA_conexion()
        'guardar_ultima_vez()

    End Sub

    Private Sub CargarDatos()
        Try
            Try
                Dim sqlConnection1 As New SqlConnection(Utilidades.sConexion)
                Dim cmd As New SqlCommand
                Dim reader As SqlDataReader
                cmd.CommandText = "pACCESOS_MODULOS_ACCESOS_MODULOS_ROL_B"
                cmd.CommandType = CommandType.StoredProcedure
                cmd.Parameters.Add("@CVE_ROL", Application.Session("Cve_Rol"))
                cmd.Parameters.Add("@TIPO", "MODULO")
                cmd.Connection = sqlConnection1
                sqlConnection1.Open()
                reader = cmd.ExecuteReader()
                While reader.Read()
                    PopularMenu(reader("MODULO"), Usuario, Application.Session("Cve_Operador").ToString, reader("MODULO"))
                End While
                sqlConnection1.Close()
            Catch ex As Exception
                MessageBox.Show("error: " & ex.Message, "Inicio",
            MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        Catch ex As Exception
            MessageBox.Show("Error: " & ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Sub PopularMenu(ByVal sModulo As String, ByVal Control As Wisej.Web.Ext.RibbonBar.RibbonBarGroup, ByVal sCve_Operador As String, Optional ByVal sSubModulo As String = Nothing, Optional ByVal sCve_Acceso_PadreX As String = Nothing)
        Utilidades.Conectar()
        Dim cDataReader As Data.SqlClient.SqlDataReader
        Try
            Utilidades.cCommand = New SqlClient.SqlCommand("pACCESOS_MODULOS_RIBBON", Utilidades.cConnect)
            Utilidades.cCommand.CommandType = CommandType.StoredProcedure
            Utilidades.cCommand.Parameters.AddWithValue("@USUARIO", sCve_Operador)
            Utilidades.cCommand.Parameters.AddWithValue("@Modulo", sModulo)
            If Application.Session("Cve_Rol") <> "1" Then
                Utilidades.cCommand.Parameters.AddWithValue("@habilitado", True)
            End If
            If Trim(sSubModulo) <> Nothing Then
                Utilidades.cCommand.Parameters.AddWithValue("@SubModulo", sSubModulo)
            End If
            cDataReader = Utilidades.cCommand.ExecuteReader(CommandBehavior.CloseConnection)
            Dim sCve_Acceso_Padre As String
            Dim SubMenuItem, SubMenu As MenuItem
            Dim group, grupo_principal As Ext.RibbonBar.RibbonBarGroup
            Dim item_menu As Ext.RibbonBar.RibbonBarItemButton
            Dim page_r As Ext.RibbonBar.RibbonBarPage
            Dim tag_page, tag_items, tag_submenu
            Dim CONT As ContextMenu
            CONT = New ContextMenu
            If cDataReader.HasRows Then
                While (cDataReader.Read)
                    'If Trim(sCve_Acceso_Padre) <> cDataReader.Item("Cve_Acceso_Padre") Then
                    '    tag_page = cDataReader.Item("CVE_ACCESO_PADRE")

                    '    '------------------------------- < Aqui es el code para colocar los modulos en pestañas, no lo quiten alv>------------
                    If cDataReader.Item("Tipo") = "MODULO" Then
                        '        page_r = New RibbonBarPage
                        '        page_r.Text = cDataReader.Item("descripcion")
                        '        tag_page = cDataReader.Item("CVE_ACCESO")
                        '        tag_items = cDataReader.Item("CVE_ACCESO")
                        grupo_principal = New RibbonBarGroup
                        grupo_principal.Text = cDataReader.Item("descripcion")
                        '        RibbonBar1.Pages.Add(page_r)
                        '        page_r.Groups.Add(grupo_principal)
                        '    End If
                        pgADMIN.Groups.Insert(posicion, grupo_principal)
                        'pgADMIN.Groups.Add(grupo_principal)
                        posicion += 1
                    End If
                    '-------------------------------------
                    If cDataReader.Item("Tipo") = "SUBMODULO" Then
                        If tag_page = cDataReader.Item("CVE_ACCESO_PADRE") Then
                            If cDataReader.Item("BOTON") = "C" Then
                                item_menu = New RibbonBarItemButton
                                item_menu.ImageSource = "Resources\Images\Menu\" & cDataReader.Item("icono")
                                'item_menu.Image = "Resources\Images\Menu\" & cDataReader.Item("icono")

                                item_menu.Text = cDataReader.Item("descripcion")
                                item_menu.Name = cDataReader.Item("url")
                                grupo_principal.Items.Add(item_menu)
                                tag_page = cDataReader.Item("CVE_ACCESO")
                                'tag_items = cDataReader.Item("CVE_ACCESO")
                            Else
                                'Dim ss As RibbonBarItemButton = item_menu
                                SubMenu = New MenuItem
                                'item_menu = New Ext.RibbonBar.RibbonBarItemButton
                                SubMenu.IconSource = cDataReader.Item("icono")
                                SubMenu.Text = cDataReader.Item("descripcion")
                                SubMenu.Name = cDataReader.Item("url")
                                SubMenu.Tag = cDataReader.Item("url")
                                item_menu.MenuItems.AddRange(New Wisej.Web.MenuItem() {SubMenu})
                                AddHandler SubMenu.Click, AddressOf handlemenuclick2
                                grupo_principal.Items.Add(item_menu)
                                tag_page = cDataReader.Item("CVE_ACCESO_PADRE")
                                'tag_items = cDataReader.Item("CVE_ACCESO_PADRE")
                            End If
                        ElseIf tag_items = cDataReader.Item("CVE_ACCESO_PADRE") Then
                            If cDataReader.Item("BOTON") = "C" Then
                                item_menu = New RibbonBarItemButton
                                item_menu.ImageSource = "Resources\Images\Menu\" & cDataReader.Item("icono")
                                'item_menu.Image = "Resources\Images\Menu\" & cDataReader.Item("icono")

                                item_menu.Text = cDataReader.Item("descripcion")
                                item_menu.Name = cDataReader.Item("url")
                                grupo_principal.Items.Add(item_menu)
                                tag_page = cDataReader.Item("CVE_ACCESO")
                                'tag_items = cDataReader.Item("CVE_ACCESO")
                            Else

                                'Dim ss As RibbonBarItemButton = item_menu
                                SubMenu = New MenuItem
                                'item_menu = New Ext.RibbonBar.RibbonBarItemButton
                                SubMenu.IconSource = cDataReader.Item("icono")
                                SubMenu.Text = cDataReader.Item("descripcion")
                                SubMenu.Name = cDataReader.Item("url")
                                SubMenu.Tag = cDataReader.Item("url")
                                item_menu.MenuItems.AddRange(New Wisej.Web.MenuItem() {SubMenu})
                                AddHandler SubMenu.Click, AddressOf handlemenuclick2
                                'grupo_principal.Items.Add(item_menu)
                                tag_page = cDataReader.Item("CVE_ACCESO_PADRE")
                                'tag_items = cDataReader.Item("CVE_ACCESO_PADRE")

                            End If
                        Else
                            If cDataReader.Item("BOTON") = "C" Then
                                item_menu = New RibbonBarItemButton
                                item_menu.ImageSource = "Resources\Images\Menu\" & cDataReader.Item("icono")
                                'item_menu.Image = "Resources\Images\Menu\" & cDataReader.Item("icono")

                                item_menu.Text = cDataReader.Item("descripcion")
                                item_menu.Name = cDataReader.Item("url")
                                'grupo_principal = New RibbonBarGroup
                                'grupo_principal.Text = cDataReader.Item("descripcion")
                                'grupo_principal.Items.Add(item_menu)

                                tag_page = cDataReader.Item("CVE_ACCESO")
                                grupo_principal.Items.Add(item_menu)
                                'tag_items = cDataReader.Item("CVE_ACCESO")
                            ElseIf cDataReader.Item("BOTON") = "SC" Then

                                'Dim ss As RibbonBarItemButton = item_menu
                                SubMenu = New MenuItem
                                'item_menu = New Ext.RibbonBar.RibbonBarItemButton
                                SubMenu.IconSource = cDataReader.Item("icono")
                                SubMenu.Text = cDataReader.Item("descripcion")
                                SubMenu.Name = cDataReader.Item("url")
                                SubMenu.Tag = cDataReader.Item("url")
                                item_menu.MenuItems.AddRange(New Wisej.Web.MenuItem() {SubMenu})
                                AddHandler SubMenu.Click, AddressOf handlemenuclick2
                                'grupo_principal.Items.Add(item_menu)
                                tag_page = cDataReader.Item("CVE_ACCESO_PADRE")
                                'tag_items = cDataReader.Item("CVE_ACCESO_PADRE")
                            End If
                        End If
                    End If
                End While


            End If
        Catch ex As SystemException
            MessageBox.Show("Error: " & ex.Message, "Aviso")

        Finally
            If IsNothing(cDataReader) = False Then
                If cDataReader.IsClosed = False Then cDataReader.Close()
            End If
            Utilidades.Desconectar()
        End Try
    End Sub

    Private Sub handlemenuclick2(sender As Object, e As EventArgs)
        If sender.Text = "Emisor" Then
            Application.Session("ME_EMISOR_RECEPTOR") = True
        ElseIf sender.Text = "Receptor" Then
            Application.Session("ME_EMISOR_RECEPTOR") = False
        End If
        Mostrar_Formulario(sender.tag)
    End Sub
    Private Sub handlemenuclick11(sender As Object, e As EventArgs)
        Mostrar_Formulario(sender.tag)
    End Sub
    Sub Mostrar_Formulario(ByVal cNodo As String)
        Dim objcontrol As Object = Nothing
        If cNodo = Nothing Then
            Exit Sub
        End If
        Try

            Dim wSTproyecto As String = System.Reflection.Assembly.GetExecutingAssembly.GetName.Name
            Dim ensamblado As System.Reflection.Assembly = System.Reflection.Assembly.GetExecutingAssembly()

            For Each a As Form In Application.OpenForms
                If a.Name = cNodo Then
                    a.WindowState = FormWindowState.Normal
                    a.Activate()
                    Exit Sub
                Else
                    Dim f As Form = ensamblado.CreateInstance(wSTproyecto + "." + cNodo, True)
                    f.Show()
                    Exit Sub
                End If
            Next
            Dim form As Form = ensamblado.CreateInstance(wSTproyecto + "." + cNodo, True)
            form.Show()

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub
    Private Sub RibbonBar1_ItemClick(sender As Object, e As Ext.RibbonBar.RibbonBarItemEventArgs) Handles RibbonBar1.ItemClick
        Select Case e.Item.Text
            Case "Cerrar Sesión"
                cerrar()
            Case "Cambiar Contraseña"
                Mostrar_Formulario("Perfil")
            Case "Inf. de Usuario"
                Mostrar_Formulario("Perfil")
            Case "Cambiar Tema"
                ReDim Utilidades.ParametersX_Global(2)
                Utilidades.ParametersX_Global(0) = New SqlParameter("@INTERFAZ", "MODERNA")
                Utilidades.ParametersX_Global(1) = New SqlParameter("@CVE_OPERADOR", Application.Session("Cve_Operador"))
                Utilidades.ParametersX_Global(2) = New SqlParameter("@WALLPAPER", Me.Wallpaper)
                Dim parametro = Utilidades.EjecutarProcedure_Id("pCAT_OPERADORES_Skin_G", "@Parametro", Utilidades.ParametersX_Global,, SqlDbType.VarChar, 50)
                If parametro = "" Then

                End If

                Dim Desktop As New MyDesktop
                Application.Desktop = Desktop


            Case "Cambiar Fondo"
                Dim Archivo As New Upload
                AddHandler Archivo.Uploaded, AddressOf CambiarWallpaper
                Archivo.UploadFiles()
            Case Else
                Try
                    Application.Session("TIPO_PAQUETE") = e.Item.Text
                    Mostrar_Formulario(e.Item.Name)


                Catch ex As Exception
                    Select Case e.Item.Name
                        Case Else
                            Mostrar_Formulario(e.Item.Name)
                    End Select
                End Try


        End Select


    End Sub


    Public Sub CambiarWallpaper(sender As Object, e As UploadedEventArgs)
        If File.Exists(Application.StartupPath & "\" & Me.Wallpaper) Then
            System.IO.File.Delete(Application.StartupPath & "\" & Me.Wallpaper)
        End If
        url_relativa_carpeta = "Resources\Fondos\FondoColegio\"
        Dim foto As Upload = CType(sender, Upload)
        Dim url_carpeta_server = Application.StartupPath & "\" & url_relativa_carpeta
        If Not Directory.Exists(url_carpeta_server) Then
            Directory.CreateDirectory(url_carpeta_server)
        End If
        If e.Files.Count > 0 Then
            Dim archivoFoto = DirectCast(e.Files(0), HttpPostedFile)
            exten = Path.GetExtension(archivoFoto.FileName)
            Dim fechaformato = "_" & Format(Now, "ddMMyyyy") & "_" & Format(Now, "hhmmss")
            Dim ef = Path.GetFileNameWithoutExtension(archivoFoto.FileName) & fechaformato
            If archivoFoto.ContentLength > 0 Then


                Dim urlLogoColegioGuardada As String = System.IO.Path.Combine(Application.StartupPath, Application.StartupPath & "\" & url_relativa_carpeta, ef & exten) 'Guardo el directorio recursos + nombre imagen

                Try
                    archivoFoto.SaveAs(urlLogoColegioGuardada) '---------------------------------Guarda la imagen en el servidor-------------------
                    Dim Renombre = "Wallpaper" & Application.Session("Colegio_Abreviatura") & fechaformato
                    Dim x As String = Application.StartupPath & "\" & url_relativa_carpeta & Renombre & exten
                    Rename(urlLogoColegioGuardada, x)
                    Me.Wallpaper = url_relativa_carpeta & Renombre & exten

                    ReDim Utilidades.ParametersX_Global(3)
                    Utilidades.ParametersX_Global(0) = New SqlParameter("@INTERFAZ", "CLASICA")
                    Utilidades.ParametersX_Global(1) = New SqlParameter("@CVE_OPERADOR", Application.Session("Cve_Operador"))
                    Utilidades.ParametersX_Global(2) = New SqlParameter("@WALLPAPER", url_relativa_carpeta & Renombre & exten)
                    Dim parametro = Utilidades.EjecutarProcedure_Id("pCAT_OPERADORES_Skin_G", "@Parametro", Utilidades.ParametersX_Global,, SqlDbType.VarChar, 50)
                    If parametro = "" Then
                        Alertas.NotificacionError("No se pudo cambiar el Wallpaper", "Error")
                    Else
                        Alertas.NotificacionExito("Se ha cambiado el Wallpaper correctamente", "Exito")
                    End If
                Catch ex As Exception
                    MessageBox.Show(ex.Message, "Cargar archivo", MessageBoxButtons.OK, MessageBoxIcon.Error)
                End Try
            End If
        End If
    End Sub

    Private Sub CambiarTema(tema As String)
        ReDim Utilidades.ParametersX_Global(1)
        Utilidades.ParametersX_Global(0) = New SqlClient.SqlParameter("@USUARIO", Application.Session("USUARIO"))
        Utilidades.ParametersX_Global(1) = New SqlClient.SqlParameter("@TEMA", tema)
        Dim RESULSET = Utilidades.EjecutarProcedure("pACTUALIZA_TEMA", "@PARAM", Utilidades.ParametersX_Global, , False)
        If RESULSET = 1 Then
            MessageBox.Show("ERROR AL GUARDAR EL TEMA", MessageBoxIcon.Information)
        Else
            MessageBox.Show("TEMA GUARDADO: " & tema, MessageBoxIcon.Information)
            Application.LoadTheme(tema)
        End If
    End Sub

    Private Sub Tema_ItemClicked(sender As Object, e As RibbonBarMenuItemEventArgs)
        CambiarTema(e.MenuItem.Text)
    End Sub
    Private Sub cerrar()
        If (MessageBox.Show("¿Deseas Cerrar Session ahora?", "Cerrar Session", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            Application.Session.clear()
            Application.Session.IsLoggedOn = False
            Dim f = New Login()
            f.Show()
            Application.Desktop = Nothing

        End If
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs)
        If (MessageBox.Show("¿Deseas Cerrar Session ahora?", "Cerrar Session", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then
            Application.Session.clear()
            Application.Session.IsLoggedOn = False
            Application.Exit()
        End If
    End Sub

    Private Sub MyDesktop_ItemClick(sender As Object, e As DesktopTaskBarItemClickEventArgs) Handles Me.ItemClick
        If e.Item.Tag = "dat" Then
            If (MessageBox.Show("¿Deseas Cerrar Session ahora?", "Cerrar Session", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes) Then

            End If
        End If
    End Sub

End Class
