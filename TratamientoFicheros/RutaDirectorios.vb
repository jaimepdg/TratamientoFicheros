Imports System.IO

Public Class RutaDirectorios
    Dim fullPathSelectNode As String
    Private Sub Directorios_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        materialBtn(btn_selectDirectory, "normal")
        SplitContainer1.Panel2Collapsed = True
        btn_save.Visible = False
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btn_selectDirectory.Click
        TreeView1.Nodes.Clear()
        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            Dim selectedPath As String = FolderBrowserDialog1.SelectedPath
            txt_ruta.Text = selectedPath
            ' Llamar al método externo pasando el formulario y el directorio seleccionado
            showDirTree(txt_ruta.Text, TreeView1)
        End If
    End Sub


    Private Sub TreeView1_AfterSelect(sender As System.Object, e As System.Windows.Forms.TreeViewEventArgs) Handles TreeView1.AfterSelect
        SplitContainer1.Panel2Collapsed = False
        Dim currentNode As TreeNode = e.Node
        If currentNode.Text.Contains(".") Then
            fullPathSelectNode = currentNode.FullPath
            btn_save.Visible = False
        Else
            fullPathSelectNode = currentNode.FullPath
            btn_save.Visible = True
        End If
        Dim selectedNode As TreeNode = e.Node
        Dim name As String = selectedNode.Text

        ' Recorrer los nodos padres y construir la ruta completa
        While currentNode.Parent IsNot Nothing
            currentNode = currentNode.Parent
            fullPathSelectNode = Path.Combine(currentNode.Text, fullPathSelectNode)
        End While


        txt_nameEdit.Text = name
        setFileTypeIcon(fullPathSelectNode, pic_viewer)
    End Sub

    Private Sub btn_open_Click(sender As System.Object, e As System.EventArgs) Handles btn_open.Click
        openfile(fullPathSelectNode)
    End Sub

    Private Sub btn_openDir_Click(sender As System.Object, e As System.EventArgs) Handles btn_openDir.Click
        openfileDir(fullPathSelectNode)
    End Sub

    Private Sub btn_save_Click(sender As System.Object, e As System.EventArgs) Handles btn_save.Click

        If FolderBrowserDialog1.ShowDialog() = DialogResult.OK Then
            Dim selectedPath As String = FolderBrowserDialog1.SelectedPath

            If copyDir(fullPathSelectNode, selectedPath) Then

            End If
            
        End If

    End Sub

    Private Sub btn_delete_Click(sender As System.Object, e As System.EventArgs) Handles btn_delete.Click
        deleteFile(fullPathSelectNode)
        TreeView1.Nodes.Clear()
        showDirTree(txt_ruta.Text, TreeView1)
    End Sub
End Class