Imports System.IO

Public Class PassToPdf

    Private Sub btn_ok_Click(sender As System.Object, e As System.EventArgs) Handles btn_ok.Click

        Dim destino As String = Path.Combine(Label1.Tag, Path.GetFileNameWithoutExtension(lbl_path.Tag) & "(passworded).pdf")
        If fbd_pass.ShowDialog = Windows.Forms.DialogResult.OK Then

            addPass(lbl_path.Tag, destino, txt_pass.Text, txt_editPass.Text)
            Me.Dispose()
        End If

        
    End Sub
End Class