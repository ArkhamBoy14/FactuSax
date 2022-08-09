Imports System.Management
Imports System.Drawing
Imports System.Data
Imports Wisej.Web
Imports Wisej.Web.Form
Imports Wisej.Web.CommonDialog
Imports Wisej.Core

'.Resources
Imports System.IO
Imports System.Data.SqlClient

Imports ClosedXML.Excel
Imports DocumentFormat.OpenXml.Spreadsheet

Public Class CargaMasiva

    Private cConnect As New SqlConnection
    Dim myDS As DataSet
    Public Event FileError(ByVal descripcion As String)
    Public Event ErrorColumna(ByVal descripcion As String)
    Public Event DataError(ByVal column As Object, ByVal row As Object, ByVal descripcion As String)
    Public Event ErrorDescripcion(ByVal descripcion As String)
    Public Event ErrorGuardar(ByVal descripcion As String)
    Public Event GuardadoCompletado()
    Public Event Finalizado()
    Public Event Iniciado()
    'Modificados
    Public tablaFill As DataTable = New DataTable("CARGA_MASIVA_TABLA")
    Public errorCount As Integer = 0
    Public cargaCount As Integer = 0
    Public exError As String = ""
    Private rowData As Integer = 0
    Public stopIt As Boolean = False
    Public indexError As ArrayList = New ArrayList()
    Public cDevuelve As String
    Dim mensage As Boolean = True
    Sub New()
        _errores = False
        _parametros.Clear()
        _PassphraseEnteredByUser = Nothing
        '_savewitherrors = False
        _separatorInitId = "("
        _separatorEndId = ") - "
    End Sub

    Public ReadOnly Property Version() As String
        Get
            Version = Me.GetType.Assembly.GetName.
             Version.ToString
        End Get
    End Property

    Private _conexion As String
    Public Property Conexion() As String
        Get
            Return _conexion
        End Get
        Set(value As String)
            _conexion = value
        End Set
    End Property

    Private _PassphraseEnteredByUser As String
    Public Property PassphraseEnteredByUser() As String
        Get
            Return _PassphraseEnteredByUser
        End Get
        Set(value As String)
            _PassphraseEnteredByUser = value
        End Set
    End Property

    Private _parametros As New ArrayList
    Property Parametro() As ArrayList
        Get
            Return _parametros
        End Get
        Set(value As ArrayList)
            _parametros = value
        End Set
    End Property

    Private _separatorInitId As String
    Public Property SeparadorInicioId() As String
        Get
            Return _separatorInitId
        End Get
        Set(value As String)
            _separatorInitId = value
        End Set
    End Property

    Private _separatorEndId As String
    Public Property SeparadorFinId() As String
        Get
            Return _separatorEndId
        End Get
        Set(value As String)
            _separatorEndId = value
        End Set
    End Property

    Private _errores As Boolean
    Public ReadOnly Property HasError() As Boolean
        Get
            Return _errores
        End Get
    End Property

    Private _savewitherrors As Boolean
    Public Property SaveWithErrors() As Boolean
        Get
            Return _savewitherrors
        End Get
        Set(value As Boolean)
            _savewitherrors = value
        End Set
    End Property

    Private _sheetName As String = Nothing
    Public Property SheetName() As String
        Get
            Return _sheetName
        End Get
        Set(value As String)
            _sheetName = value
        End Set
    End Property

    Private _totalHojas As Integer = -1
    Public Property SheetCount() As String
        Get
            Return _totalHojas
        End Get
        Set(ByVal value As String)
            _totalHojas = value
        End Set
    End Property

    Private _sender As Object = Nothing
    Public Property Archivo() As Object
        Get
            Return _sender
        End Get
        Set(value As Object)
            _sender = value
        End Set
    End Property

    Public Sub Importar(ByRef sender As Object, ByVal Procedure As String, ByVal ProcedureToSave As String, Optional ByVal sColumnReturn As String = Nothing, Optional ByVal params As ArrayList = Nothing, Optional ByVal sheetName As String = Nothing, Optional ByVal dbtype As System.Data.SqlDbType = SqlDbType.Int, Optional ByVal sSize As Integer = 0)
        cargaCount = 0 : errorCount = 0 : indexError = New ArrayList : exError = "" : tablaFill.Clear()

        Try
            Dim filss = sender.FileSystem.OpenFileStream(sender.FileName, FileMode.Open, FileAccess.Read)
            sender.FileName = filss.name
            RaiseEvent Iniciado()

            Dim ParametersX_Global() As System.Data.SqlClient.SqlParameter = Nothing

            Dim dt As DataTable

            Dim rowData As Integer = 0

            Dim wb As XLWorkbook
            Dim ws As IXLWorksheet


            If FileValid(sender) = True Then

                Dim FileName As String

                FileName = sender.filename
                _errores = False

                Dim myDA As Data.SqlClient.SqlDataAdapter = New Data.SqlClient.SqlDataAdapter(Procedure, _conexion)
                myDA.SelectCommand.CommandType = CommandType.Text

                If Not _PassphraseEnteredByUser = Nothing Then
                    myDA.SelectCommand.Parameters.Add(New SqlClient.SqlParameter("@PassphraseEnteredByUser", _PassphraseEnteredByUser))
                End If

                myDS = New DataSet
                myDA.Fill(myDS, "SQLX")

                wb = New XLWorkbook(FileName)
                If Not sheetName = Nothing Then
                    'mensage = "La"
                    Dim a = wb.Worksheets.Count
                    For ab = 1 To a
                        Dim xx = wb.Worksheets.Worksheet(ab).Name.ToString
                        If wb.Worksheets.Worksheet(1).Name = sheetName Then
                            ws = wb.Worksheets.Worksheet(sheetName)
                            mensage = False
                            Exit For
                        Else
                            mensage = True
                        End If
                    Next
                    If mensage = True Then
                        RaiseEvent ErrorDescripcion("La hoja de trabajo del archivo (" & Path.GetFileName(sender.filename) & ") no coinciden con (" & sheetName & ").")

                    End If





                Else
                    ws = wb.Worksheets.Worksheet(1)
                End If

                _totalHojas = wb.Worksheets.Count

                If ws.ColumnsUsed.Count <> myDS.Tables(0).Columns.Count Then
                    _errores = True
                    RaiseEvent ErrorDescripcion("No coinciden los numeros de columna. Hay " & ws.ColumnsUsed.Count & " en la hoja de Excel y " & myDS.Tables(0).Columns.Count & "en el procedimiento.")
                    Exit Sub
                End If

                dt = New DataTable

                CreateColumns(myDS, ws, dt) : DataToDT(dt, ws)
                tablaFill = dt
                For Me.rowData = 0 To dt.Rows.Count - 1
                    FillParameters(ParametersX_Global, Me.rowData, dt)

                    If Parametro Is Nothing = False Then
                        AddParametersToExists(ParametersX_Global, _parametros)
                    End If

                    Dim c As String = SaveToDB(ProcedureToSave, sColumnReturn, ParametersX_Global, dbtype, sSize)
                    cDevuelve = c
                    If String.IsNullOrEmpty(c) Then
                        _errores = True
                        errorCount += 1
                        indexError.Add(Me.rowData)
                        If stopIt Then
                            Dim pico = dt.Rows.Count - 1
                            For k = Me.rowData + 1 To pico
                                tablaFill.Rows.Remove(tablaFill.Rows(tablaFill.Rows.Count - 1))
                            Next
                            Exit For
                        End If
                    Else
                        cargaCount += 1
                    End If
                Next
            Else
                _errores = True
                RaiseEvent ErrorDescripcion("El archivo (" & Path.GetFileName(sender.filename) & ") no es de tipo Excel... ")
                'RaiseEvent FileError("El archivo no es de tipo Excel.")
            End If


        Catch ex As Exception
            _errores = True
            RaiseEvent ErrorDescripcion(ex.ToString)


        Finally

            If _errores = False Then
                RaiseEvent GuardadoCompletado()
            End If

            RaiseEvent Finalizado()
        End Try
    End Sub

    Private Sub CreateColumns(ByVal myDS As DataSet, ByVal ws As IXLWorksheet, ByRef dt As DataTable)
        Try
            If myDS.Tables(0).Columns.Count = ws.ColumnsUsed.Count Then
                For i = 0 To ws.ColumnsUsed.Count - 1
                    Dim columna As String = ws.Cell(1, i + 1).Value.ToString().ToUpper()
                    If columna = myDS.Tables(0).Columns.Item(i).ColumnName.ToString().ToUpper() Then
                        dt.Columns.Add(myDS.Tables(0).Columns.Item(i).ColumnName.ToString().ToUpper(), myDS.Tables(0).Columns.Item(i).DataType)
                        dt.Columns(i).ReadOnly = True
                    Else
                        RaiseEvent ErrorDescripcion("Los nombres de las columnas no coinciden , Excel:" + columna + " , Procedimiento: " + myDS.Tables(0).Columns.Item(i).ColumnName.ToString().ToUpper())
                    End If
                Next
            End If
        Catch ex As Exception
            RaiseEvent ErrorDescripcion(ex.Message)
        End Try
    End Sub

    Private Sub DataToDT(ByRef dt As DataTable, ByVal ws As IXLWorksheet)
        Dim i As Integer, j As Integer
        Try
            Dim dr As DataRow

            For i = 1 To ws.RowsUsed.Count - 1
                dr = dt.NewRow()

                For j = 0 To ws.ColumnsUsed.Count - 1
                    dr.Item(j) = ws.Cell(i + 1, j + 1).Value

                Next

                dt.Rows.Add(dr)
            Next

        Catch ex As Exception
            _errores = True
            RaiseEvent ErrorDescripcion("error en la columna " & j & " y fila" & i & ex.Message)
            'RaiseEvent DataError(j, i, ex.Message)
        End Try
    End Sub

    Private Sub FillParameters(ByRef ParametersX_Global() As SqlClient.SqlParameter, ByVal i As Integer, ByVal dt As DataTable)
        Dim j As Integer, id As Object
        Try
            ReDim ParametersX_Global(dt.Columns.Count - 1)
            For j = 0 To dt.Columns.Count - 1

                id = dt.Rows(i).Item(j)

                If checkType(id, dt.Rows(i).Item(j).GetType()) Then
                    GetId(id)
                    ParametersX_Global(j) = New SqlClient.SqlParameter("@" & dt.Columns.Item(j).ColumnName.ToString(), id)
                Else
                    _errores = True
                    'RaiseEvent DataError(j, i, "El valor no coincide con el tipo de dato")
                    RaiseEvent ErrorDescripcion("error en la columna " & j & " y fila" & i & "El valor no coincide con el tipo de dato")
                End If
            Next
        Catch ex As Exception
            _errores = True
            RaiseEvent ErrorDescripcion("error en la columna " & j & " y fila" & i & ex.Message)
            'RaiseEvent DataError(j, i, ex.Message)
        End Try
    End Sub

    Private Sub AddParametersToExists(ByRef ParametersX_Global() As SqlClient.SqlParameter, ByVal params As ArrayList)
        ReDim Preserve ParametersX_Global((ParametersX_Global.Length + _parametros.Count) - 1)
        Dim l As Integer = 0
        For k As Integer = ParametersX_Global.Length - _parametros.Count To ParametersX_Global.Length - 1
            ParametersX_Global(k) = _parametros.Item(l) : l += 1
        Next
    End Sub

    Private Function SaveToDB(ByVal Procedure As String, Optional ByVal sColumnReturn As String = Nothing, Optional ByVal ParametersX_Global() As SqlClient.SqlParameter = Nothing, Optional ByVal dbtype As System.Data.SqlDbType = SqlDbType.Int, Optional ByVal sSize As Integer = 0) As String
        Conectar()

        Dim i As Integer

        Try
            Dim cCommand As SqlClient.SqlCommand = New SqlClient.SqlCommand(Procedure, cConnect)
            cCommand.CommandType = CommandType.StoredProcedure
            'cCommand.Parameters.Clear()

            If ParametersX_Global Is Nothing = False Then
                For i = 0 To ParametersX_Global.GetLength(0) - 1
                    Try
                        If ParametersX_Global(i) Is Nothing = False Then
                            cCommand.Parameters.Add(ParametersX_Global(i))
                        End If
                    Catch ex As Exception
                        _errores = True
                        RaiseEvent ErrorDescripcion("Error en el parametro: " & ParametersX_Global(i).ToString())
                    End Try
                Next
            End If

            Dim parameterConsecutivo As New SqlParameter(sColumnReturn, dbtype, sSize)
            parameterConsecutivo.Direction = ParameterDirection.Output
            cCommand.Parameters.Add(parameterConsecutivo)

            cCommand.ExecuteNonQuery()
            cCommand.Parameters.Clear()
            If Not parameterConsecutivo.Value Is Nothing And Not parameterConsecutivo.Value Is System.DBNull.Value Then
                SaveToDB = parameterConsecutivo.Value
            Else
                SaveToDB = Nothing
                _errores = True

                RaiseEvent ErrorDescripcion("Error al guardar")

            End If
        Catch ex As Exception

            SaveToDB = Nothing
            _errores = True
            RaiseEvent ErrorDescripcion(ex.Message)
            exError += "fila(" & rowData & ")" & ex.Message & vbCrLf
        Finally

            If _errores Then
                RaiseEvent Finalizado()
            End If

            Desconectar()

        End Try

    End Function

    Private Sub Conectar()
        Try
            If cConnect.State = ConnectionState.Closed Then
                cConnect.ConnectionString = _conexion
                cConnect.Open()
            End If

        Catch ex As SystemException
            'cErrors += " " & ex.Message
        End Try
    End Sub

    Private Sub Desconectar()
        Try
            If cConnect.State <> ConnectionState.Closed Then cConnect.Close()
        Catch ex As SystemException

        End Try
    End Sub

    Public Function checkType(ByVal valor As Object, ByVal tipo As Type) As Boolean

        If valor.GetType.Name.ToLower = tipo.Name.ToLower Then
            Return True
        Else
            Return False
        End If
    End Function

    Private Function validDataWithFormat(ByRef data As Object, tipo As Type) As Object
        Select Case tipo.Name.ToLower()
            Case "string"
                If String.IsNullOrEmpty(data.ToString()) Or String.IsNullOrWhiteSpace(data.ToString()) Then
                    Return Nothing
                ElseIf IsDate(data) Then
                    Return String.Format(data.ToString(), "yyyyMMdd")
                Else
                    Return data.ToString()
                End If
            Case "integer", "int16", "int32", "int64"
                'Return CInt(data)
                Return True
            Case "double"
                'Return CDbl(data)
                Return True
            Case "decimal"
                Return True

            Case "datetime"
                Return CDate(data)
            Case "boolean"
                Return True
            Case Else
                Return Nothing
        End Select
    End Function

    Private Sub GetId(ByRef cmId As Object)
        If InStr(cmId, _separatorInitId) = 1 AndAlso InStr(cmId, _separatorEndId) Then
            cmId = cmId.Substring(_separatorInitId.Length, InStr(cmId, _separatorEndId) - 2)
        End If
    End Sub

    Private Function FileValid(ByRef sender As Object) As Boolean
        Dim _Boolean As Boolean
        Try

            Dim ParametersX_Global() As System.Data.SqlClient.SqlParameter = Nothing, i As Integer = 0

            If checkType(sender, GetType(String)) Then
                _Boolean = True
            Else

                Dim objFileDialog As Wisej.Web.OpenFileDialog = CType(sender, Wisej.Web.OpenFileDialog)

                'If Not Directory.Exists(Application.StartupPath & "\Resources\Upload") Then
                '    Directory.CreateDirectory(Application.StartupPath & "\Resources" + Path.DirectorySeparatorChar + "Upload")
                'End If
                'Dim mstrDirectory As String = Application.StartupPath & "\Resources\Upload"
                Dim FileName As String = ""


                If Path.GetExtension(objFileDialog.FileName).ToLower = ".xls" Or Path.GetExtension(objFileDialog.FileName).ToLower = ".xlsx" Then

                    _Boolean = True

                Else
                    _errores = True


                    'RaiseEvent ErrorDescripcion("El archivo no es de tipo Excel.")
                    FileName = Nothing
                    _Boolean = False

                End If
            End If





        Catch ex As Exception
            MessageBox.Show("EROR" & ex.Message, "ERRORR", MessageBoxButtons.OK, MessageBoxIcon.Error)

            RaiseEvent ErrorDescripcion(ex.Message)

            Return _Boolean = False


        End Try
        Return _Boolean

    End Function



End Class