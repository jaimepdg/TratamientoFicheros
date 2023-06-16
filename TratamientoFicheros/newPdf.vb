Imports System.IO

Public Class newPdf
    Public Event btn_submitClick As EventHandler


    Private Sub btn_close_Click(sender As Object, e As System.EventArgs) Handles btn_close.Click
        Form1.Enabled = True
        Form1.Show()
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
                If fbd_newPdf.ShowDialog() = DialogResult.OK Then
                    Dim path As String = fbd_newPdf.SelectedPath
                    Dim fileName As String = txt_name.Text
                    Dim fileContent As String = txt_text.Text
                    createPdf(IO.Path.Combine(path, fileName & ".pdf"), fileName, fileContent)
                    Form1.Enabled = True
                    Form1.Show()
                    Me.Close()
                End If
            End If


        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message)

        End Try


    End Sub
End Class