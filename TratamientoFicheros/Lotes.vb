Imports System.IO
Imports System.Diagnostics

Public Class Lotes

    Private Sub Lotes_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        materialBtn(btn_selectDirectory, "normal")
        materialGrid(grid_ficheros)
    End Sub

    Private Sub btn_selectDirectory_Click(sender As System.Object, e As System.EventArgs) Handles btn_selectDirectory.Click
        grid_ficheros.Rows.Clear()
        grid_ficheros.Columns.Clear()

        analizaLotes(grid_ficheros, FolderBrowserDialog1, txt_ruta)
        grid_ficheros.ClearSelection()
    End Sub

    Private Sub grid_ficheros_CellContentClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles grid_ficheros.CellContentClick
        If e.ColumnIndex = 0 Then ' Cambiar "0" por el índice de la columna que deseas
            ' Obtener el nombre del archivo de la celda clicada
            Dim nombreArchivo As String = grid_ficheros.Rows(e.RowIndex).Cells(e.ColumnIndex).Value.ToString()

            ' Obtener la ruta completa del archivo
            Dim rutaArchivo As String = txt_ruta.Text ' Cambiar "directorio" por la ruta del directorio

            ' Verificar si el archivo existe
            If File.Exists(rutaArchivo) Then
                ' Abrir el archivo en el sistema
                Try
                    Process.Start(rutaArchivo)
                Catch ex As Exception
                    MsgBox("No se puede abrir el archivo: " & vbCrLf & ex.Message)
                End Try

            End If
        End If
    End Sub
End Class