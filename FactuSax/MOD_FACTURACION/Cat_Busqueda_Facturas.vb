﻿Imports System
Imports Wisej.Web
Imports System.Data
Imports System.Data.SqlClient

Public Class Cat_Busqueda_Facturas
    Dim ME_CARGADO As Boolean = False

    Private Sub RibbonBar1_ItemClick(sender As Object, e As Ext.RibbonBar.RibbonBarItemEventArgs) Handles RibbonBar1.ItemClick
        Select Case e.Item.Name
            Case RBBBuscar.Name
                Cargar()
            Case RBBSalir.Name
                Me.Close()
        End Select
    End Sub
    Private Sub Cat_Busqueda_Facturas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cFecha1.Value = Now
        cFecha2.Value = Now
        CargarCombos()
        ME_CARGADO = True
    End Sub

    Sub CargarCombos()
        ReDim Utilidades.ParametersX_Global(1)
        Utilidades.ParametersX_Global(0) = New SqlClient.SqlParameter("@Cve_Operador", Application.Session("Cve_Operador"))
        CbxCliente.LlenarListBox("pCAT_CLIENTES_B", "Cve_Cliente", "Nombre_Cliente", Utilidades.ParametersX_Global)
        CbxCliente.SelectedIndex = 0
    End Sub

    Private Sub CbxCliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CbxCliente.SelectedIndexChanged
        Cargar(CbxCliente.SelectedValue)
    End Sub

    Sub Cargar(Optional Cve_Cliente As String = "-99")
        Me.DataSet_pFACTURA_SAT_CFDI_B.Clear()
        Dim myDA = New SqlDataAdapter("pFACTURA_SAT_CFDI_B", Utilidades.sConexion)
        myDA.SelectCommand.CommandType = CommandType.StoredProcedure
        myDA.SelectCommand.Parameters.AddWithValue("@Fecha1", Format(Me.cFecha1.Value, "yyyyMMdd"))
        myDA.SelectCommand.Parameters.AddWithValue("@Fecha2", Format(Me.cFecha2.Value, "yyyyMMdd"))
        If CbxCliente.SelectedIndex <> -1 Then
            myDA.SelectCommand.Parameters.AddWithValue("@Cve_Cliente", CbxCliente.SelectedValue)
        End If
        myDA.Fill(Me.DataSet_pFACTURA_SAT_CFDI_B.pFACTURA_SAT_CFDI_B)
        myDA.Dispose()
        CargaParent()


    End Sub

    Sub CargaParent()
        Try
            If DGV_Busqueda.Rows.Count > 0 Then
                For i = DGV_Busqueda.Rows.Count - 1 To 0 Step -1
                    If DGV_Busqueda.Item(colParent.Index, i).Value = "HIJO" Then
                        If DGV_Busqueda.Item(cMetodoPago.Index, i).Value = "PUE" Then
                            DGV_Busqueda.Rows.RemoveAt(i)
                        Else
                            DGV_Busqueda.Rows(i).ParentRow = DGV_Busqueda.Rows(i - 1)
                            DGV_Busqueda.Rows(i)(0).Style.ColSpan = DGV_Busqueda.Columns.GetColumnCount(DataGridViewElementStates.None) - 1
                            DGV_Busqueda.Rows(i - 1).Collapse()
                            DGV_Busqueda.Rows(i - 1).Cells(cPDF).ReadOnly = True
                            DGV_Busqueda.Rows(i - 1).Cells(cXML).ReadOnly = True

                        End If
                    End If
                Next
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub DGV_Busqueda_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGV_Busqueda.CellClick
        If e.ColumnIndex <> -1 Then
            If e.ColumnIndex = cPDF.Index Then
                Select Case DGV_Busqueda.Item(cMetodoPago.Index, e.RowIndex).Value
                    Case "PUE"
                        DocumentDownload(DGV_Busqueda.Item(colUUID.Name, e.RowIndex).Value, "PUE")

                    Case "PPD"
                        Application.Session("Historial_Pagos") = 1
                        DocumentDownload(DGV_Busqueda.Item(colUUID.Name, e.RowIndex).Value, "PPD")
                End Select
            End If
            If e.ColumnIndex = cXML.Index Then

            End If
        End If
    End Sub
    Private Sub DGV_SubFacturas(sender As Object, e As DataGridViewCellEventArgs)
        If e.ColumnIndex <> -1 Then
            If e.ColumnIndex = colPDF.Index Then
                Select Case DGV_Busqueda.Item(cMetodoPago.Index, e.RowIndex).Value
                    Case "PUE"
                        DocumentDownload(sender.Item(colUUID_1.Name, e.RowIndex).Value, "PUE")
                    Case "PPD"
                        Application.Session("Historial_Pagos") = 0
                        DocumentDownload(sender.Item(colUUID_1.Name, e.RowIndex).Value, "PPD")
                End Select
            End If
            If e.ColumnIndex = cXML.Index Then

            End If
        End If
    End Sub
    Private Sub DGV_Busqueda_CellClick(sender As Object, e As Integer)
        If e <> -1 Then
            If sender.ColumnIndex = colPDF.Index Then
                'Select Case DGV_Busqueda.Item(cMetodoPago.Index, sender.RowIndex).Value
                '    Case "PUE"
                DocumentDownload(DGV_Busqueda.Item(colUUID_1.Name, sender.RowIndex).Value, "PPD")
                '    Case "PPD"
                '        'DocumentDownload(DGV_Busqueda.Item(colUUID.Name, e.RowIndex).Value, "PPD")
                'End Select

                'End If
            End If
            If sender.ColumnIndex = cXML.Index Then

            End If
        End If
    End Sub
    Sub DocumentDownload(ByVal UUID As String, TipoReporte As String)
        Application.Session("UUID_SAT") = UUID
        Dim sReportName As String
        Select Case TipoReporte
            Case "PUE"
                sReportName = "R_Representacion_Fisica_CFDi33"
            Case "PPD"
                sReportName = "R_Representacion_Fisica_CFDi33_Pagos"
        End Select
        If Trim(sReportName <> Nothing) Then
            Application.Session("ReportName") = sReportName
            Application.Session("DocumentCached") = Nothing
            Application.Session("Modulo") = "DocumentViewer.aspx"
            Dim Asp As New Mostrar_Asp()
            Asp.Actualizar()
            Asp.Show()
        End If

    End Sub

    Private Sub DGV_Busqueda_RowExpanded(sender As Object, e As DataGridViewRowEventArgs) Handles DGV_Busqueda.RowExpanded
        Dim miGrilla As DataGridView
        miGrilla = Utilidades.ClonarDGV(DGV_Pagos)
        miGrilla.DataSource = CargarPagosRelacionados(DGV_Busqueda.Item(colUUID.Index, e.RowIndex).Value)
        miGrilla.Visible = True
        AddHandler miGrilla.CellClick, AddressOf DGV_SubFacturas
        DGV_Busqueda.Rows(e.RowIndex + 1).Cells(0).Style.Padding = New Padding(30, 1, 0, 0)
        DGV_Busqueda.Rows(e.RowIndex + 1).Cells(0).Control = miGrilla
        miGrilla.Dock = DockStyle.Fill
        miGrilla.ScrollBars = ScrollBars.Horizontal
        miGrilla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
        Dim minH As Integer = (20 * (miGrilla.Rows.Count)) + 20 + 30
        minH = IIf(minH > 280, 280, minH)
        miGrilla.MinimumSize = New Drawing.Size(1020, minH)
        DGV_Busqueda.Rows(e.RowIndex + 1).MinimumHeight = minH
        DGV_Busqueda.Rows(e.RowIndex + 1).ReadOnly = True
    End Sub



    Private Function CargarPagosRelacionados(ByVal UUID As String)
        Dim DatasetPagos = New DataSet_pFACTURA_SAT_CFD_PAGOS_RELACIONADOS_B
        Dim BSPagos As New BindingSource
        DatasetPagos.EnforceConstraints = False
        Try
            DatasetPagos.Clear()
            Dim myDA = New SqlDataAdapter("pFACTURA_SAT_CFD_PAGOS_RELACIONADOS_B", Utilidades.sConexion)
            myDA.SelectCommand.CommandType = CommandType.StoredProcedure
            myDA.SelectCommand.Parameters.AddWithValue("@UUID", UUID)
            myDA.Fill(DatasetPagos.Tables(0))
            myDA.Dispose()
            BSPagos.DataSource = DatasetPagos
            BSPagos.DataMember = DatasetPagos.Tables(0).TableName
        Catch ex As Exception

        End Try
        Return BSPagos
    End Function

    Private Sub cFecha1_ValueChanged(sender As Object, e As EventArgs) Handles cFecha1.ValueChanged, cFecha2.ValueChanged
        If ME_CARGADO = True Then
            Cargar()
        End If
    End Sub



End Class
