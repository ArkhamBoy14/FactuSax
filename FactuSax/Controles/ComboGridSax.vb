Imports System.Data


Public Class ComboGridSax
    Dim f As New Form
    Public Gridview As DataGridView
    Dim dv As DataView
    Dim Filter As String
    Public Event SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
    Public SelectedValue_DEFAULT As String
    Public SelectedItem_DEFAULT As String
    Public DataSource As DataTable
    Dim SelectedValue_VALUE As String = ""
    Dim applyFilterOnExpand As Boolean = True
    Dim _hideOverFlowGridWidth As Boolean = True
    Dim SelectedItem_VALUE As String
    Dim SelectedIndex_VALUE As Integer = -1
    Dim sparametros As String
    Dim sColumnFilter As String = ""
    Dim fp As New UserPopup
    Dim MinWidth As Integer = 0


#Region "Interacciones"

    Private Sub TextBox1_EnterKeyDown(objSender As Object, objArgs As KeyEventArgs) Handles TextBox1.KeyDown
        If IsNothing(sColumnFilter) Or sColumnFilter = "" Then Exit Sub
        Try
            dv.RowFilter = "" & Me.sColumnFilter & " like '%" & TextBox1.Text & "%' "
            Gridview.DataSource.DataSource = dv
            If Count > 0 Then
                If f.Tag = True Then
                    f.Tag = False
                    Exit Sub
                End If
                f.Tag = True


                If Count = 1 Then
                    f.Height = 73
                ElseIf Count <= 14 Then
                    f.Height = 52 + (Count * 22)
                Else

                    f.Height = 52 + (14 * 22)
                End If
                If _hideOverFlowGridWidth Then
                    f.Width = Me.Width
                Else
                    f.Width = DataGridViewColumsWidth()
                End If
                f.Controls.Add(Panel1)
                'f.ShowPopup(Me, DialogAlignment.Below)
                f.Show()
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Function DataGridViewColumsWidth() As Integer
        Dim width As Integer = Gridview.Columns.GetColumnsWidth(DataGridViewElementStates.Visible)
        width += IIf(Gridview.RowHeadersVisible, Gridview.RowHeadersWidth, 0)
        Return width
    End Function

    Sub Clear()
        SelectedValue_VALUE = ""
        SelectedItem_VALUE = ""
        SelectedIndex = -1
    End Sub


    Public Sub AddGrid(ByVal Grid As DataGridView, ByVal BvSelectedValue As String, ByVal BvSelectedItem As String, sparametross As String)
        sparametros = sparametross
        If IsNothing(Grid.DataSource) Then
            Exit Sub
        End If
        Gridview = Grid
        SelectedValue_DEFAULT = BvSelectedValue
        SelectedItem_DEFAULT = BvSelectedItem
        Gridview.Dock = DockStyle.Fill

        If IsNothing(DataSource) = True Then
            DataSource = Grid.DataSource.DataSource.Tables(0)
        End If

        If IsNothing(dv) = True Then
            dv = New DataView(Gridview.DataSource.DataSource.Tables(0), "", "", DataViewRowState.CurrentRows)
        Else

        End If
        Clear()
        Gridview.Visible = True
        AddHandler Gridview.CellClick, AddressOf CellClick
        Panel1.Controls.Clear()
        Panel1.Controls.Add(Gridview)


    End Sub
    Public Sub CellClick(sender As Object, e As DataGridViewCellEventArgs)
        If e.RowIndex <> -1 Then

            TextBox1.Text = Gridview.Item(SelectedItem_DEFAULT, e.RowIndex).Value

            SelectedValue_VALUE = Gridview.Item(SelectedValue_DEFAULT, e.RowIndex).Value
            SelectedIndex_VALUE = e.RowIndex
            If TextBox1.Focus = False Then
                TextBox1.Focus()
            End If

        End If
        RaiseEvent SelectedIndexChanged(Me, Nothing)

        f.Close()

    End Sub

    Private Sub ComboGridSax_Load(sender As Object, e As EventArgs) Handles Me.Load

        f.Tag = False
        SplitContainer1.SplitterDistance = SplitContainer1.Width - BtnActivador.Width
        AddHandler f.FormClosed, AddressOf closed
    End Sub

    Private Sub Activacion_Click(sender As Object, e As EventArgs) Handles BtnActivador.Click

        If Count > 0 Then
            dv.RowFilter = "" & Me.sColumnFilter & " like '%" & IIf(applyFilterOnExpand, TextBox1.Text, "") & "%' "
            Gridview.DataSource.DataSource = dv

            If fp.Tag = True Then
                fp.Tag = False
                Exit Sub
            End If
            fp.Tag = True


            If Count = 1 Then
                fp.Height = 73
                fp.Width = SplitContainer1.Width
            ElseIf Count <= 14 Then
                fp.Height = 52 + (Count * 22)
                fp.Width = SplitContainer1.Width
            Else

                fp.Height = 52 + (14 * 22)
                fp.Width = SplitContainer1.Width
            End If


            'If Screen.PrimaryScreen.Bounds.Width > Me.Width Then
            '    f.Width = Screen.PrimaryScreen.Bounds.Width
            'Else
            If _hideOverFlowGridWidth Then
                fp.Width = Me.Width
            Else
                'fp.Width = DataGridViewColumsWidth()
            End If
            'End If


            fp.Controls.Add(Panel1)
            fp.MinimumSize() = New Drawing.Size(MinWidth, 0)
            'f.ShowPopup(Me, DialogAlignment.Below)
            fp.ShowPopup(Me)
        End If
    End Sub
    Sub closed()
        'If Me.WindowState = FormWindowState.Maximized Then
        If Me.ParentForm.WindowState = FormWindowState.Maximized Then

            If CInt(Me.Location.X) + Me.Width + 3 > MousePosition.X And CInt(Me.Location.X) + Me.Width - 28 < MousePosition.X Then
                f.Tag = True
            Else
                f.Tag = False
            End If
        Else
            If CInt(Me.Location.X) + CInt(Me.ParentForm.Location.X) + Me.Width + 3 > MousePosition.X And CInt(Me.Location.X) + CInt(Me.ParentForm.Location.X) + Me.Width - 28 < MousePosition.X Then
                f.Tag = True
            Else
                f.Tag = False
            End If
        End If


    End Sub


    'Private Sub Tprespuesta_Click(sender As Object, e As EventArgs) Handles Tprespuesta.Click
    '    If "ADMIN" = Application.Session("Cve_Operador") Then
    '        Tprespuesta.Text = sparametros
    '        Tprespuesta.SelectAll()
    '    End If
    'End Sub
#End Region


#Region "propiedades"

    Public Property FilterOnExpand As Boolean
        Get
            Return Me.applyFilterOnExpand
        End Get
        Set(value As Boolean)
            Me.applyFilterOnExpand = value
        End Set
    End Property

    Public Property HideOverFlowGridWidth As Boolean
        Get
            Return Me._hideOverFlowGridWidth
        End Get
        Set(value As Boolean)
            Me._hideOverFlowGridWidth = value
        End Set
    End Property

    Public ReadOnly Property Count As Integer

        Get
            If IsNothing(Gridview) = True Then
                Count = 0
            Else
                Count = Gridview.RowCount
            End If

        End Get
    End Property

    Public Property ColumnFilter() As String
        Get
            Return sColumnFilter
        End Get
        Set(value As String)
            sColumnFilter = value
        End Set
    End Property


    Public Property SelectedValue() As String
        Get
            SelectedValue = SelectedValue_VALUE
        End Get
        Set(ByVal value As String)

            Try

                If value <> Nothing Then
                    Dim searchedRow = (From row As DataGridViewRow In Gridview.Rows Where row.Cells(SelectedValue_DEFAULT).Value = value Select row).FirstOrDefault()

                    If Not searchedRow Is Nothing Then
                        Me.SelectedIndex = searchedRow.Index
                    End If

                End If
            Catch ex As NullReferenceException
                MessageBox.Show("Error Del combo " & Me.Name.ToString & " al querer asignar el valor " & value & " el cual no existe", "combosax_mV5", MessageBoxButtons.OK, MessageBoxIcon.Warning)
            End Try
        End Set
    End Property

    Public Property SelectedIndex As Integer
        Get
            SelectedIndex = SelectedIndex_VALUE
        End Get
        Set(value As Integer)
            If Not SelectedValue_DEFAULT Is Nothing And Not SelectedItem_DEFAULT Is Nothing Then
                If value = -1 Then
                    SelectedItem_VALUE = ""
                    SelectedValue_VALUE = ""
                Else
                    SelectedItem_VALUE = Gridview.Item(SelectedItem_DEFAULT, value).Value
                    SelectedValue_VALUE = Gridview.Item(SelectedValue_DEFAULT, value).Value
                End If

                TextBox1.Text = SelectedItem_VALUE
            End If

            SelectedIndex_VALUE = value
            RaiseEvent SelectedIndexChanged(Me, Nothing)
        End Set
    End Property
    Public Property MinimunWidthGrid As Integer

        Get
            MinimunWidthGrid = MinWidth
        End Get

        Set(value As Integer)
            MinWidth = value

        End Set
    End Property



    Public Property datagrid As DataGridView
        Get
            datagrid = Gridview
        End Get
        Set(value As DataGridView)


            Gridview = value




        End Set
    End Property

#End Region








End Class


