Imports System.IO

Public Class CustomDialog
    Public Event btn_submitClick As EventHandler


    Private Sub btn_close_Click(sender As Object, e As System.EventArgs) Handles btn_close.Click
        Dual.Enabled = True
        Dual.Show()
        Me.Close()
        
    End Sub

    Private Sub btn_close_MouseEnter(sender As Object, e As System.EventArgs) Handles btn_close.MouseEnter
        btn_close.BackgroundImage = My.Resources.close_48_gray

    End Sub

    Private Sub btn_close_MouseLeave(sender As Object, e As System.EventArgs) Handles btn_close.MouseLeave
        btn_close.BackgroundImage = My.Resources.close_48_colored
    End Sub

    Private Sub btn_submit_Click(sender As System.Object, e As System.EventArgs) Handles btn_submit.Click

        Try

            If txt_name.Text = "" Or txt_text.Text = "" Then
                MsgBox("Debes escribir un nombre y un texto")
            Else
                File.WriteAllText(IO.Path.Combine(lbl_path.Text, txt_name.Text & ".txt"), txt_text.Text)
                File.Move(IO.Path.Combine(lbl_path.Text, txt_name.Text & ".txt"), IO.Path.Combine(lbl_path.Text, txt_name.Text & ".txt"))
                MsgBox("Fichero de texto creado correctamente.")
                Dual.refreshListas()
                Dual.Enabled = True
                Dual.Show()
                Me.Close()
            End If
           

        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message)

        End Try
        

    End Sub
End Class