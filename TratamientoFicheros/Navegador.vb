Imports System.IO

Public Class Navegador

    Private Sub Navegador_Load(sender As Object, e As System.EventArgs) Handles Me.Load
    End Sub

    Private Sub lw_main_MouseDoubleClick(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lw_main.MouseDoubleClick
        Dim newRuta As String

        Try
            Dim elemento As String = lw_main.SelectedItems(0).Text
            newRuta = Path.Combine(txt_path.Text, elemento.Substring(3))


            Dim isFile As String = Dir(newRuta)
            If isFile <> Nothing Then
                openfile(newRuta)
            Else
                txt_path.Text = newRuta
            End If

        Catch ex As Exception

        End Try
    End Sub

    Private Sub lw_main_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles lw_main.MouseDown
        If e.Button = MouseButtons.Right Then
            Try
                Dim selectedItem As ListViewItem = lw_main.GetItemAt(e.X, e.Y)
                cms_left.Show(Cursor.Position.X, Cursor.Position.Y)
            Catch ex As Exception

            End Try

        End If
    End Sub

    Private Sub lw_main_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles lw_main.SelectedIndexChanged
        

    End Sub

    Private Sub txt_path_TextChanged(sender As Object, e As System.EventArgs) Handles txt_path.TextChanged
        listarFicherosLw(txt_path.Text, lw_main)
        TreeView1.Nodes.Clear()
        showDirTree(txt_path.Text, TreeView1)


    End Sub

    Private Sub btn_back_Click(sender As System.Object, e As System.EventArgs) Handles btn_back.Click
        txt_path.Text = txt_path.Text & "\.."
        txt_path.Text = Path.GetFullPath(txt_path.Text)
    End Sub
End Class