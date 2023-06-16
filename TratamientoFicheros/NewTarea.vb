Public Class NewTarea

    Private Sub NewTarea_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        Dim sqlGrupo As String
        Dim sqlLista As String

        sqlGrupo = "SELECT DISTINCT g.nombre FROM Grupos g " _
                  & "INNER JOIN Users u ON u.ID_grupo = g.ID_grupo " _
                  & "WHERE u.ID_user = '" & idUsuario & "' "
        sqlLista = "SELECT DISTINCT l.nombre FROM Listas l " _
                  & "INNER JOIN Listas_Tareas lt ON lt.ID_lista = l.ID_lista " _
                  & "INNER JOIN Users u ON u.ID_grupo = lt.ID_grupo " _
                  & "WHERE u.ID_user = '" & idUsuario & "' "


        miClase.fillComboboxAvanzado(combo_grupo, sqlGrupo, "nombre")
        miClase.fillComboboxAvanzado(combo_lista, sqlLista, "nombre")
    End Sub

    Private Sub btn_addTask_Click(sender As System.Object, e As System.EventArgs) Handles btn_addTask.Click
        miClase.addTask(txt_nombreTarea.Text, txt_descripcion.Text, combo_lista.SelectedItem.ToString, combo_grupo.SelectedItem.ToString)
    End Sub
End Class