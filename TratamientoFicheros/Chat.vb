Imports System.Data.SqlClient

Public Class Chat
    Private selectedIndex As Integer = -1
    Private Sub list_users_DrawItem(sender As Object, e As System.Windows.Forms.DrawItemEventArgs) Handles list_users.DrawItem
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


    Private Sub list_users_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles list_users.SelectedIndexChanged
        Dim destinatario As String = list_users.SelectedItem.ToString.Trim
        lbl_destinatario.Text = destinatario
        miClase.actualizaChat(destinatario, txt_mensajes)
        list_users.Invalidate()
        lbl_avatar.Image = My.Resources.profile_48x49_white



    End Sub


    Private Sub Tareas_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        'miClase.listarUsuarios(list_users)
        Dim sql As String = "SELECT DISTINCT username FROM Users WHERE username <> '" & usuario & "'"
        miClase.fillList(list_users, sql, "username")
        lbl_destinatario.Text = ""
        lbl_avatar.Image = Nothing
        list_users.DrawMode = DrawMode.OwnerDrawFixed
    End Sub







    Private Sub btn_send_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles btn_send.MouseDown
        btn_send.BackgroundImage = My.Resources.icons8_enviado_48
    End Sub
    Private Sub btn_send_MouseUp(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles btn_send.MouseUp
        btn_send.BackgroundImage = My.Resources.icons8_enviado_48
    End Sub
    Private Sub btn_send_MouseEnter(sender As Object, e As System.EventArgs) Handles btn_send.MouseEnter
        btn_send.BackgroundImage = My.Resources.enviado_48_hover
    End Sub

    Private Sub btn_send_MouseLeave(sender As Object, e As System.EventArgs) Handles btn_send.MouseLeave
        btn_send.BackgroundImage = My.Resources.icons8_enviado_48
    End Sub
    Private Sub btn_actualizarChat_MouseEnter(sender As Object, e As System.EventArgs) Handles btn_actualizarChat.MouseEnter
        btn_actualizarChat.BackgroundImage = My.Resources.refresh_hover
    End Sub

    Private Sub Chat_MouseLeave(sender As Object, e As System.EventArgs) Handles Me.MouseLeave
        btn_send.BackgroundImage = My.Resources.refresh_white
    End Sub





    Private Sub panel_msg_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles panel_msg.Paint

    End Sub

    Private Sub btn_send_Click(sender As System.Object, e As System.EventArgs) Handles btn_send.Click
        miClase.enviaMensaje(txt_mensaje, lbl_destinatario.Text, txt_mensajes)
    End Sub

    Private Sub btn_actualizarChat_Click(sender As System.Object, e As System.EventArgs) Handles btn_actualizarChat.Click
        miClase.actualizaChat(lbl_destinatario.Text, txt_mensajes)
    End Sub


End Class