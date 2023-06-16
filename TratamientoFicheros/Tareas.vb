Imports System.Data.SqlClient

Public Class Tareas

    Private Sub Teareas_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim sql As String = "SELECT DISTINCT nombre FROM Listas l INNER JOIN Listas_Tareas lt ON lt.ID_lista = l.ID_Lista " _
                            & "INNER JOIN Users u ON u.ID_grupo = lt.ID_grupo " _
                            & "WHERE username = '" & usuario & "'"
        miClase.fillList(list_listas, sql, "nombre")

        SplitContainer1.Panel2Collapsed = True
        SplitContainer2.Panel2Collapsed = True

        list_listas.DrawMode = DrawMode.OwnerDrawFixed
        list_tareas.DrawMode = DrawMode.OwnerDrawFixed

        


    End Sub

    Private Sub list_listas_DrawItem(sender As Object, e As System.Windows.Forms.DrawItemEventArgs) Handles list_listas.DrawItem
        e.DrawBackground()
        Dim listBox As ListBox = CType(sender, ListBox)
        Dim itemText As String = listBox.Items(e.Index).ToString()

        If listBox.SelectedIndex = e.Index Then
            Dim color As Color = color.FromArgb(38, 70, 83)
            Using brush As New SolidBrush(color)
                e.Graphics.FillRectangle(brush, e.Bounds)
            End Using
        End If

        e.Graphics.DrawString(itemText, e.Font, Brushes.White, e.Bounds, StringFormat.GenericDefault)
        e.DrawFocusRectangle()
    End Sub

    Private Sub list_listas_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles list_listas.SelectedIndexChanged
        SplitContainer2.Panel2Collapsed = False
        Dim sqlprocess As String
        Dim sqlcompleted As String
        Dim sqlbinned As String

        If list_listas.SelectedIndex <> -1 Then
            If processIconcolored Then
                sqlprocess = "SELECT  t.nombre FROM Tareas t INNER JOIN Listas_Tareas lt ON lt.ID_tarea = t.ID_tarea " _
                                & "INNER JOIN Listas l ON l.ID_lista = lt.ID_lista INNER JOIN Estados_tareas et ON et.ID_estado_tarea = t.ID_estado_tarea " _
                                & "WHERE l.nombre = '" & list_listas.SelectedItem.ToString.Trim & "' AND t.ID_estado_tarea = 1"
                miClase.fillList(list_tareas, sqlprocess, "nombre")
            ElseIf completedIconcolored Then
                sqlcompleted = "SELECT  t.nombre FROM Tareas t INNER JOIN Listas_Tareas lt ON lt.ID_tarea = t.ID_tarea " _
                                & "INNER JOIN Listas l ON l.ID_lista = lt.ID_lista INNER JOIN Estados_tareas et ON et.ID_estado_tarea = t.ID_estado_tarea " _
                                & "WHERE l.nombre = '" & list_listas.SelectedItem.ToString.Trim & "' AND t.ID_estado_tarea = 2"
                miClase.fillList(list_tareas, sqlcompleted, "nombre")
            ElseIf binnedIconColored Then
                sqlbinned = "SELECT  t.nombre FROM Tareas t INNER JOIN Listas_Tareas lt ON lt.ID_tarea = t.ID_tarea " _
                                & "INNER JOIN Listas l ON l.ID_lista = lt.ID_lista INNER JOIN Estados_tareas et ON et.ID_estado_tarea = t.ID_estado_tarea " _
                                & "WHERE l.nombre = '" & list_listas.SelectedItem.ToString.Trim & "' AND t.ID_estado_tarea = 3"
                miClase.fillList(list_tareas, sqlbinned, "nombre")

            End If


            list_listas.Invalidate()

            If Not processIconcolored Then
                btn_cancel.Visible = False
                btn_done.Visible = False
            End If
        End If
        
    End Sub

    Private Sub list_tareas_DrawItem(sender As Object, e As System.Windows.Forms.DrawItemEventArgs) Handles list_tareas.DrawItem
        e.DrawBackground()
        Dim listBox As ListBox = CType(sender, ListBox)
        Dim itemText As String = listBox.Items(e.Index).ToString()

        If listBox.SelectedIndex = e.Index Then
            Dim color As Color = color.FromArgb(38, 70, 83)
            Using brush As New SolidBrush(color)
                e.Graphics.FillRectangle(brush, e.Bounds)
            End Using
        End If

        e.Graphics.DrawString(itemText, e.Font, Brushes.White, e.Bounds, StringFormat.GenericDefault)
        e.DrawFocusRectangle()
    End Sub

    Private Sub list_tareas_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles list_tareas.SelectedIndexChanged
        SplitContainer1.Panel2Collapsed = False
        Panel3.Visible = True
        lbl_fichaTareaTitle.Text = list_tareas.SelectedItem.ToString.Trim
        lbl_selectedListaNombre.Text = list_listas.SelectedItem.ToString.Trim
        lbl_grupo.Text = grupoLogin

        Dim command As New SqlCommand
        Dim sqlDesc As String


        sqlDesc = "SELECT  t.descripcion FROM Tareas t INNER JOIN Listas_Tareas lt ON lt.ID_tarea = t.ID_tarea " _
                            & "INNER JOIN Users u ON u.ID_grupo = lt.ID_grupo " _
                            & "WHERE t.nombre = '" & lbl_fichaTareaTitle.Text & "'"

        command.Connection = miClase.conexion
        Try
            command.Connection.Open()
            command.CommandText = sqlDesc
            txt_descripcion.Text = command.ExecuteScalar

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            command.Connection.Close()
        End Try
        list_tareas.Invalidate()
    End Sub

    Private Sub btn_done_MouseEnter(sender As Object, e As System.EventArgs) Handles btn_done.MouseEnter
        btn_done.BackgroundImage = My.Resources.done_48_colored
    End Sub

    Private Sub btn_done_MouseLeave(sender As Object, e As System.EventArgs) Handles btn_done.MouseLeave
        btn_done.BackgroundImage = My.Resources.done_48_white
    End Sub

    Private Sub btn_cancel_MouseEnter(sender As Object, e As System.EventArgs) Handles btn_cancel.MouseEnter
        btn_cancel.BackgroundImage = My.Resources.cancelled_48_colored
    End Sub

    Private Sub btn_cancel_MouseLeave(sender As Object, e As System.EventArgs) Handles btn_cancel.MouseLeave
        btn_cancel.BackgroundImage = My.Resources.cancelled_48_white
    End Sub

    Private Sub btn_cancel_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancel.Click
        Dim sql As String
        Dim sqlprocess As String
        sql = "UPDATE Tareas SET ID_estado_tarea = 3 WHERE nombre = '" & lbl_fichaTareaTitle.Text & "'"
        miClase.updateData(sql)

        sqlprocess = "SELECT  t.nombre FROM Tareas t INNER JOIN Listas_Tareas lt ON lt.ID_tarea = t.ID_tarea " _
                               & "INNER JOIN Listas l ON l.ID_lista = lt.ID_lista INNER JOIN Estados_tareas et ON et.ID_estado_tarea = t.ID_estado_tarea " _
                               & "WHERE l.nombre = '" & list_listas.SelectedItem.ToString.Trim & "' AND t.ID_estado_tarea = 1"
        miClase.fillList(list_tareas, sqlprocess, "nombre")
        Panel3.Visible = False
    End Sub
End Class