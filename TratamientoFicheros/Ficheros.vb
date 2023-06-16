Imports System.IO

Imports System.Drawing

Public Class Ficheros
    Dim filePath As String
    Private Sub Ficheros_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        materialBtn(btn_selectDirectory, "normal")
        materialBtn(btn_editName, "normal")
        materialGrid(grid_ficheros)
        SplitContainer1.Panel1Collapsed = True
    End Sub

    Private Sub grid_ficheros_CellDoubleClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid_ficheros.CellDoubleClick


        Dim selectedRow As DataGridViewRow = grid_ficheros.Rows(e.RowIndex)


        If selectedRow.Cells(1).Value.ToString = "Directorio" Then
            MsgBox("Debe seleccionar un fichero y está seleccionando un directorio")
        Else
            Try
                SplitContainer1.Panel1Collapsed = False

                txt_nameEdit.Text = selectedRow.Cells(0).Value.ToString()
                txt_type.Text = selectedRow.Cells(1).Value.ToString().Substring(1)
                txt_creation.Text = selectedRow.Cells(2).Value.ToString()
                txt_lastedit.Text = selectedRow.Cells(3).Value.ToString()
                lbl_size.Text = selectedRow.Cells(4).Value.ToString()


                Dim imgExt As String()
                imgExt = {"png", "jpg", "ico"}


                'AÑADIR PLACEHODERS EN EL TAB DE PREVISUALIZACIÓN DEL ARCHIVO EN FUNCIÓN DE SU FORMATO
                If imgExt.Contains(txt_type.Text) Then
                    pic_viewer.Image = Image.FromFile(txt_ruta.Text & "\" & txt_nameEdit.Text)
                ElseIf txt_type.Text = "pdf" Then
                    'pic_viewer.Image = Image.FromFile("C:\icons\pdf_48_red.png")
                    pic_viewer.Image = My.Resources.pdf_48_red
                ElseIf txt_type.Text = "txt" Then
                    'pic_viewer.Image = Image.FromFile("C:\icons\txt_48_white.png")
                    pic_viewer.Image = My.Resources.txt_48_white
                ElseIf txt_type.Text = "html" Then
                    'pic_viewer.Image = Image.FromFile("C:\icons\html_48_white.png")
                    pic_viewer.Image = My.Resources.html_48_white
                Else
                    pic_viewer.Image = Nothing
                End If
            Catch ex As Exception
                MsgBox("Error: " & vbCrLf & ex.Message)
            End Try
            filePath = "\" & txt_nameEdit.Text
            txt_nameEdit.Text = txt_nameEdit.Text.Substring(0, txt_nameEdit.Text.LastIndexOf("."))
        End If
      
        



    End Sub
   
    Private Sub btn_selectDirectory_Click(sender As System.Object, e As System.EventArgs) Handles btn_selectDirectory.Click
        grid_ficheros.Rows.Clear()
        grid_ficheros.Columns.Clear()
        SplitContainer1.Panel1Collapsed = True

        getMeta(FolderBrowserDialog1, grid_ficheros, txt_ruta)
        grid_ficheros.ClearSelection()

    End Sub

    Private Sub btn_close_Click(sender As Object, e As System.EventArgs) Handles btn_close.Click
        SplitContainer1.Panel1Collapsed = True
    End Sub


    Private Sub btn_close_MouseEnter(sender As Object, e As System.EventArgs) Handles btn_close.MouseEnter
        btn_close.BackgroundImage = My.Resources.izq_48px_orange
        btn_close.BackColor = Color.FromArgb(38, 70, 83)
    End Sub

    Private Sub btn_close_MouseLeave(sender As Object, e As System.EventArgs) Handles btn_close.MouseLeave
        btn_close.BackgroundImage = My.Resources.izq_48px_white
    End Sub




    Private Sub btn_delete_MouseEnter(sender As Object, e As System.EventArgs) Handles btn_delete.MouseEnter
        btn_delete.BackgroundImage = My.Resources.bin_30px_white
        btn_delete.BackColor = Color.FromArgb(58, 90, 103)

    End Sub


    Private Sub btn_delete_MouseLeave(sender As Object, e As System.EventArgs) Handles btn_delete.MouseLeave
        btn_delete.BackgroundImage = My.Resources.bin_30px_red

    End Sub

    Private Sub btn_open_MouseEnter(sender As Object, e As System.EventArgs) Handles btn_open.MouseEnter
        btn_open.BackgroundImage = My.Resources.openfile_30px_white
        btn_open.BackColor = Color.FromArgb(58, 90, 103)
    End Sub
    Private Sub btn_open_MouseLeave(sender As Object, e As System.EventArgs) Handles btn_open.MouseLeave
        btn_open.BackgroundImage = My.Resources.openfile_30px_colored
    End Sub

    Private Sub btn_openDir_MouseEnter(sender As Object, e As System.EventArgs) Handles btn_openDir.MouseEnter
        btn_openDir.BackgroundImage = My.Resources.dir_30px_white
        btn_openDir.BackColor = Color.FromArgb(58, 90, 103)
    End Sub
    Private Sub btn_openDir_MouseLeave(sender As Object, e As System.EventArgs) Handles btn_openDir.MouseLeave
        btn_openDir.BackgroundImage = My.Resources.dir_30px_colored
    End Sub



    Private Sub btn_refreshGrid_MouseEnter(sender As Object, e As System.EventArgs) Handles btn_refreshGrid.MouseEnter
        btn_refreshGrid.BackgroundImage = My.Resources.refresh_hover
        btn_refreshGrid.BackColor = Color.FromArgb(38, 70, 83)
    End Sub
    Private Sub btn_refreshGrid_MouseLeave(sender As Object, e As System.EventArgs) Handles btn_refreshGrid.MouseLeave
        btn_refreshGrid.BackgroundImage = My.Resources.refresh_white
    End Sub










    Private Sub btn_editName_Click(sender As System.Object, e As System.EventArgs) Handles btn_editName.Click
        renameFile(filePath, txt_nameEdit.Text, txt_type.Text, txt_ruta.Text)
        refrescarGridFicheros(grid_ficheros, txt_ruta.Text)

    End Sub

    Private Sub btn_delete_Click(sender As System.Object, e As System.EventArgs) Handles btn_delete.Click
        Dim filePath As String = txt_ruta.Text & "\" & txt_nameEdit.Text & "." & txt_type.Text

        deleteFile(filePath)
        refrescarGridFicheros(grid_ficheros, txt_ruta.Text)
    End Sub

    Private Sub btn_refreshGrid_Click(sender As System.Object, e As System.EventArgs) Handles btn_refreshGrid.Click
        If grid_ficheros.Rows.Count > 0 Then
            refrescarGridFicheros(grid_ficheros, txt_ruta.Text)
        End If

    End Sub


    Private Sub btn_open_Click(sender As System.Object, e As System.EventArgs) Handles btn_open.Click
        Dim filePath As String = txt_ruta.Text & "\" & txt_nameEdit.Text & "." & txt_type.Text
        openfile(filePath)
    End Sub

    Private Sub btn_openDir_Click(sender As System.Object, e As System.EventArgs) Handles btn_openDir.Click
        Dim filePath As String = txt_ruta.Text & "\" & txt_nameEdit.Text & "." & txt_type.Text
        openfileDir(filePath)
    End Sub

    Private Sub txt_lastedit_TextChanged(sender As System.Object, e As System.EventArgs) Handles txt_lastedit.TextChanged

    End Sub
End Class