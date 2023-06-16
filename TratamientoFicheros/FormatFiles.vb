Public Class FormatFiles

    Private Sub FormatFiles_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        materialBtn(btn_DirSelection, "normal")
        materialBtn(btn_letsgo, "normal")
    End Sub

    Private Sub btn_DirSelection_Click(sender As System.Object, e As System.EventArgs) Handles btn_DirSelection.Click
        formatDateNames(fbDialog_formatDate, txt_ruta)
    End Sub

    Private Sub btn_letsgo_Click(sender As System.Object, e As System.EventArgs) Handles btn_letsgo.Click
        movingFilesSurname(fbDialog_moving_from, fbDialog_moving_to, txt_rutaMoveFrom, txt_rutaMoveTo)
    End Sub

    Private Sub SplitContainer1_Panel1_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel1.Paint

    End Sub
End Class