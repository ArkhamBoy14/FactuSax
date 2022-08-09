Imports DevExpress.XtraReports.UI
Imports DevExpress.XtraReports.Web
Imports DevExpress.XtraPrinting
Imports System.IO

Public Class DocumentViewer
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        Try

            If Wisej.Web.Application.Session("DocumentCached") Is Nothing Then

                Dim sReportName As String = ""
                sReportName = Wisej.Web.Application.Session("ReportName")
                Dim DicX As New Dictionary(Of String, Object)
                DicX = Wisej.Web.Application.Session("DicParametros")
                If Trim(sReportName) <> Nothing Then

                    Dim _ReporteInstance As New XtraReport
                    Try
                        _ReporteInstance = Activator.CreateInstance(Type.GetType("FactuSax." & sReportName))

                        If DicX Is Nothing = False Then
                            For i = 0 To DicX.Count - 1
                                If Not IsNothing(_ReporteInstance.Parameters(DicX.Keys(i))) Then
                                    _ReporteInstance.Parameters(DicX.Keys(i)).Value = DicX.Values(i)
                                End If
                            Next
                        End If
                        _ReporteInstance.CreateDocument()
                        ASPxWebDocumentViewer1.OpenReport(_ReporteInstance)

                        Dim MS1 = New MemoryStream()
                        Dim opts1 As New DevExpress.XtraPrinting.PdfExportOptions
                        opts1.ShowPrintDialogOnOpen = True
                        MS1.Seek(0, SeekOrigin.Begin)
                        _ReporteInstance.ExportToPdf(MS1, opts1)
                        Dim report1 As Byte() = MS1.ToArray()
                        Page.Response.ContentType = "application/pdf"
                        Page.Response.Clear()
                        Page.Response.OutputStream.Write(report1, 0, report1.Length)
                        Response.Flush()


                    Catch ex1 As Exception
                        MessageBox.Show(ex1.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
                    End Try
                End If
            End If
            Wisej.Web.Application.Session("DicParametros") = Nothing
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning)
        End Try
    End Sub

End Class