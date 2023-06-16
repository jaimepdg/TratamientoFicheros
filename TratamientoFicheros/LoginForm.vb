Public Class LoginForm


    Private Sub LoginForm_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        materialBtn(btn_login, "normal")
    End Sub
    Private Sub btn_close_Click(sender As System.Object, e As System.EventArgs) Handles btn_close.Click
        Me.Close()
        Form1.panel_login.Visible = False
    End Sub

    Private Sub btn_login_Click(sender As System.Object, e As System.EventArgs) Handles btn_login.Click
        If miClase.login(txt_username.Text, txt_password.Text) Then
            Me.Close()


        End If
    End Sub
    Private Sub btn_close_MouseEnter(sender As Object, e As System.EventArgs) Handles btn_close.MouseEnter
        btn_close.BackColor = Color.FromArgb(231, 111, 81)
    End Sub

    Private Sub btn_close_MouseLeave(sender As Object, e As System.EventArgs) Handles btn_close.MouseLeave
        btn_close.BackColor = Color.Transparent
    End Sub

End Class