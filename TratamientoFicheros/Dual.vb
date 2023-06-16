Imports System.IO
Imports iTextSharp.text
Imports iTextSharp.text.pdf


Public Class Dual


    Private formularioCargado As Boolean = False

    Private Sub Dual_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        btn_close.Visible = False
        btn_close2.Visible = False
        btn_compareTxt.Enabled = True
        RichTextBox1.Visible = False
        RichTextBox2.Visible = False
        Me.AllowDrop = True
        materialBtn(btn_compareTxt, "normal")


        btn_pathBack_left.Enabled = True
        btn_pathBackRight.Enabled = True
        btn_rutaIzq.Enabled = True
        btn_rutaDrcha.Enabled = True
        btn_filtro.Enabled = True
        btn_refresh.Enabled = True
        btn_mergePDFs_left.Visible = False
        btn_pdfWm_right.Visible = False
        btn_mergePDFs_right.Visible = False
        btn_pdfWm_left.Visible = False
        btn_compareTxt.Visible = False

        PDFToolStripMenuItem.Visible = False
        DescomprimirToolStripMenuItemR.Visible = False
        PDFToolStripMenuItemR.Visible = False

        materialBtn(btn_mergePDFs_left, "normal")
        materialBtn(btn_mergePDFs_right, "normal")
        materialBtn(btn_newPdf_left, "normal")
        materialBtn(btn_newPdf_right, "normal")
        materialBtn(btn_pdfWm_left, "normal")
        materialBtn(btn_pdfWm_right, "normal")
    End Sub






    'CON ESTE BOTON RECOGMOS LOS ELEMENTOS SELECCIONADOS EN EL CHECKEDLISTBOX    ATENCION TOMAR COMO EJEMPLO, Y ESTUDAIR, ES UN EJEMPLO DE INTERNET
    Private Sub Button3_Click(sender As Object, e As System.EventArgs) Handles btn_compareTxt.Click

        If CheckedListBox1.SelectedItems.Count <> 0 And CheckedListBox2.SelectedItems.Count <> 0 Then


            If (File.Exists(obtenerRutaFicheroIzq)) AndAlso (File.Exists(obtenerRutaFicheroDer)) Then
                RichTextBox1.Visible = True
                RichTextBox2.Visible = True
                btn_close.Visible = True
                btn_close2.Visible = True
                compareTxt(RichTextBox1, RichTextBox2, obtenerRutaFicheroIzq, obtenerRutaFicheroDer)

            Else
                MsgBox("Ambos ficheros deben tener extensión .txt")
            End If
        Else
            MsgBox("Debes seleccionar dos ficheros.")
        End If



    End Sub

    Private Sub btn_rutaIzq_Click(sender As System.Object, e As System.EventArgs) Handles btn_rutaIzq.Click, btn_rutaDrcha.Click
        rellenarLista(txt_pathLeft, fbd_listaLeft, CheckedListBox1)

    End Sub

    Private Sub btn_rutaDrch_Click(sender As System.Object, e As System.EventArgs)
        rellenarLista(txt_pathRight, fbd_listaRight, CheckedListBox2)
    End Sub

    Private Sub txt_pathRight_TextChanged(sender As Object, e As System.EventArgs) Handles txt_pathRight.TextChanged

        listarFicheros(txt_pathRight.Text, CheckedListBox2)
        btn_mergePDFs_left.Visible = False
        btn_pdfWm_right.Visible = False
        btn_mergePDFs_right.Visible = False
        btn_pdfWm_left.Visible = False
        btn_compareTxt.Visible = False
    End Sub

    Private Sub txt_pathLeft_TextChanged(sender As Object, e As System.EventArgs) Handles txt_pathLeft.TextChanged

        listarFicheros(txt_pathLeft.Text, CheckedListBox1)
        btn_mergePDFs_left.Visible = False
        btn_pdfWm_right.Visible = False
        btn_mergePDFs_right.Visible = False
        btn_pdfWm_left.Visible = False
        btn_compareTxt.Visible = False

    End Sub

    Private Sub btn_pathBack_left_Click(sender As System.Object, e As System.EventArgs) Handles btn_pathBack_left.Click
        txt_pathLeft.Text = txt_pathLeft.Text & "\.."
        txt_pathLeft.Text = Path.GetFullPath(txt_pathLeft.Text)
    End Sub

    Private Sub btn_pathBackRight_Click(sender As System.Object, e As System.EventArgs) Handles btn_pathBackRight.Click
        txt_pathRight.Text = txt_pathRight.Text & "\.."
        txt_pathRight.Text = Path.GetFullPath(txt_pathRight.Text)
    End Sub

    Private Sub CheckedListBox1_DoubleClick(sender As Object, e As System.EventArgs) Handles CheckedListBox1.DoubleClick
        Dim newRuta As String
        newRuta = Path.Combine(txt_pathLeft.Text, CheckedListBox1.SelectedItem.ToString.Substring(3))

        Dim isFile As String = Dir(newRuta)
        If isFile <> Nothing Then
            openfile(newRuta)
        Else
            txt_pathLeft.Text = newRuta
        End If

    End Sub

    Private Sub CheckedListBox2_DoubleClick(sender As Object, e As System.EventArgs) Handles CheckedListBox2.DoubleClick
        Dim newRuta As String

        Try
            newRuta = Path.Combine(txt_pathRight.Text, CheckedListBox2.SelectedItem.ToString.Substring(3))


            Dim isFile As String = Dir(newRuta)
            If isFile <> Nothing Then
                openfile(newRuta)
            Else
                txt_pathRight.Text = newRuta
            End If

        Catch ex As Exception

        End Try

    End Sub

    Private Sub CheckedListBox1_DragDrop(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles CheckedListBox1.DragDrop
        Dim files() As String = e.Data.GetData(DataFormats.FileDrop)
        For Each Path In files
            Dim fileInfo As New FileInfo(Path)
            copyFile(Path, System.IO.Path.Combine(txt_pathLeft.Text, fileInfo.Name))
            refreshListas()
        Next
    End Sub

    Private Sub CheckedListBox1_DragEnter(sender As Object, e As System.Windows.Forms.DragEventArgs) Handles CheckedListBox1.DragEnter
        If e.Data.GetDataPresent(DataFormats.FileDrop) Then
            e.Effect = DragDropEffects.Copy
        End If
    End Sub





    Private Sub btn_moveToRight_Click(sender As System.Object, e As System.EventArgs) Handles btn_moveToRight.Click
        Try
            moveFile(obtenerRutaOrigenFichero(True), obtenerRutaDestinoFichero(False))
            refreshListas()
        Catch ex As Exception
            MsgBox("Selecciona un fichero")
        End Try

    End Sub

    Private Sub btn_moveToLeft_Click(sender As System.Object, e As System.EventArgs) Handles btn_moveToLeft.Click
        Try
            moveFile(obtenerRutaOrigenFichero(False), obtenerRutaDestinoFichero(True))
            refreshListas()
        Catch ex As Exception

            MsgBox("Selecciona un fichero")
        End Try


    End Sub




















    Private Sub btn_createTxtLeft_Click(sender As System.Object, e As System.EventArgs) Handles btn_createTxtLeft.Click
        createTxt(txt_pathLeft.Text)
        Me.Enabled = False

    End Sub

    Private Sub btn_delete_Click(sender As System.Object, e As System.EventArgs) Handles btn_deleteLeft.Click

        Dim sourcePath As String = txt_pathLeft.Text
        Dim pathList As New List(Of String)
        For Each item As Object In CheckedListBox1.CheckedItems
            Dim checkedItem As String = item.ToString
            deleteFile(Path.Combine(sourcePath, checkedItem.Substring(3)))

        Next

        refreshListas()




    End Sub

    Private Sub btn_close_Click(sender As System.Object, e As System.EventArgs) Handles btn_close.Click, btn_close2.Click
        RichTextBox1.Clear()
        RichTextBox1.Visible = False
        RichTextBox2.Clear()
        RichTextBox2.Visible = False
        btn_close.Visible = False
        btn_close2.Visible = False

    End Sub

    Private Sub btn_close_MouseEnter(sender As Object, e As System.EventArgs) Handles btn_close.MouseEnter, btn_close2.MouseEnter
        btn_close.BackgroundImage = My.Resources.close_48_gray
        btn_close2.BackgroundImage = My.Resources.close_48_gray

    End Sub

    Private Sub btn_close_MouseLeave(sender As Object, e As System.EventArgs) Handles btn_close.MouseLeave, btn_close2.MouseLeave
        btn_close.BackgroundImage = My.Resources.close_48_colored
        btn_close2.BackgroundImage = My.Resources.close_48_colored
    End Sub




















    Public Sub refreshListas()
        listarFicheros(txt_pathLeft.Text, CheckedListBox1)
        listarFicheros(txt_pathRight.Text, CheckedListBox2)
    End Sub

    Public Function obtenerRutaFicheroIzq() As String
        Try
            Return Path.Combine(txt_pathLeft.Text, CheckedListBox1.SelectedItem.ToString.Substring(3))
        Catch ex As Exception
            Return Nothing
        End Try

    End Function

    Public Function obtenerRutaFicheroDer() As String
        Try
            Return Path.Combine(txt_pathRight.Text, CheckedListBox2.SelectedItem.ToString.Substring(3))
        Catch ex As Exception
            Return Nothing
        End Try

    End Function


    Public Function obtenerRutaOrigenFichero(izquierda As Boolean) As String
        If izquierda Then
            Return Path.Combine(txt_pathLeft.Text, CheckedListBox1.SelectedItem.ToString.Substring(3))
        Else
            Return Path.Combine(txt_pathRight.Text, CheckedListBox2.SelectedItem.ToString.Substring(3))
        End If


    End Function
    Public Function obtenerRutaDestinoFichero(izquierda As Boolean) As String
        If izquierda Then
            Return Path.Combine(txt_pathLeft.Text, CheckedListBox2.SelectedItem.ToString.Substring(3))
        Else
            Return Path.Combine(txt_pathRight.Text, CheckedListBox1.SelectedItem.ToString.Substring(3))
        End If

    End Function

    Private Sub btn_createDir_Click(sender As System.Object, e As System.EventArgs) Handles btn_createDirLeft.Click
        Dim dirName As String
        Dim Answer As String = InputBox("Introduzca el nombre de la carpeta", DefaultResponse:=vbCr)
        If Answer = "" Then

        ElseIf Answer = vbCr Then
            dirName = "Nueva Carpeta"
            createDir(Path.Combine(txt_pathLeft.Text, dirName))
            refreshListas()
        Else
            dirName = Answer
            createDir(Path.Combine(txt_pathLeft.Text, dirName.Trim))
            refreshListas()
        End If
    End Sub







    Private Sub CheckedListBox1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles CheckedListBox1.MouseDown
        If e.Button = MouseButtons.Right Then
            Try
                CheckedListBox1.SelectedIndex = CheckedListBox1.IndexFromPoint(e.X, e.Y)
                cms_left.Show(Cursor.Position.X, Cursor.Position.Y)
                If CheckedListBox1.SelectedItem.ToString.EndsWith(".pdf") Then
                    PDFToolStripMenuItem.Visible = True
                Else
                    PDFToolStripMenuItem.Visible = False
                End If
                If CheckedListBox1.SelectedItem.ToString.EndsWith(".zip") Or CheckedListBox1.SelectedItem.ToString.EndsWith(".rar") Then
                    DescomprimirToolStripMenuItem.Visible = True
                Else
                    DescomprimirToolStripMenuItem.Visible = False
                End If
            Catch ex As Exception

            End Try

        End If


    End Sub

    Private Sub CheckedListBox2_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles CheckedListBox2.MouseDown
        If e.Button = MouseButtons.Right Then
            Try
                CheckedListBox2.SelectedIndex = CheckedListBox2.IndexFromPoint(e.X, e.Y)
                cms_right.Show(Cursor.Position.X, Cursor.Position.Y)
                If CheckedListBox2.SelectedItem.ToString.EndsWith(".pdf") Then
                    PDFToolStripMenuItemR.Visible = True
                Else
                    PDFToolStripMenuItemR.Visible = False
                End If
                If CheckedListBox2.SelectedItem.ToString.EndsWith(".zip") Or CheckedListBox1.SelectedItem.ToString.EndsWith(".rar") Then
                    DescomprimirToolStripMenuItemR.Visible = True
                Else
                    DescomprimirToolStripMenuItemR.Visible = False
                End If
            Catch ex As Exception

            End Try
        End If


    End Sub

    Private Sub tsmi_eliminarLeft_Click(sender As System.Object, e As System.EventArgs) Handles tsmi_eliminarLeft.Click
        deleteFile(obtenerRutaFicheroIzq)

        refreshListas()
    End Sub

    Private Sub tsmi_copiarLeft_Click(sender As System.Object, e As System.EventArgs) Handles tsmi_copiarLeft.Click
        Try
            Clipboard.SetText(obtenerRutaFicheroIzq)
        Catch ex As Exception

        End Try


    End Sub
    Private Sub tsmi_eliminarRight_Click(sender As System.Object, e As System.EventArgs) Handles tsmi_eliminarRight.Click
        deleteFile(obtenerRutaFicheroDer)

        refreshListas()
    End Sub

    Private Sub tsm_copiarRight_Click(sender As System.Object, e As System.EventArgs) Handles tsmi_copiarRight.Click

        Try
            Clipboard.SetText(obtenerRutaFicheroDer)
        Catch ex As Exception

        End Try


    End Sub

    Private Sub tsmi_pegarLeft_Click(sender As System.Object, e As System.EventArgs) Handles tsmi_pegarLeft.Click
        Dim sourcePath As String = Clipboard.GetText
        Dim pathTo As String = Path.Combine(txt_pathLeft.Text, Path.GetFileName(sourcePath))

        If File.Exists(sourcePath) Then
            copyFile(sourcePath, pathTo)
        Else
            copyDir(sourcePath, Path.Combine(txt_pathLeft.Text))
        End If
        copyFile(sourcePath, pathTo)
        refreshListas()
    End Sub


    Private Sub tsmi_pegarRight_Click(sender As Object, e As System.EventArgs) Handles tsmi_pegarRight.Click
        Dim sourcePath As String = Clipboard.GetText
        Dim pathTo As String = Path.Combine(txt_pathRight.Text, Path.GetFileName(sourcePath))
        copyFile(sourcePath, pathTo)
        refreshListas()
    End Sub

    Private Sub btn_deleteRight_Click(sender As Object, e As System.EventArgs) Handles btn_deleteRight.Click
        Dim sourcePath As String = txt_pathRight.Text
        Dim pathList As New List(Of String)
        For Each item As Object In CheckedListBox2.CheckedItems
            Dim checkedItem As String = item.ToString
            deleteFile(Path.Combine(sourcePath, checkedItem.Substring(3)))

        Next

        refreshListas()


    End Sub

    Private Sub btn_deleteRight_MouseEnter(sender As Object, e As System.EventArgs) Handles btn_deleteRight.MouseEnter
        btn_deleteRight.BackgroundImage = My.Resources.binned_65_colored
    End Sub

    Private Sub btn_deleteRight_MouseLeave(sender As Object, e As System.EventArgs) Handles btn_deleteRight.MouseLeave
        btn_deleteRight.BackgroundImage = My.Resources.binned_65_white
    End Sub

    Private Sub btn_createDirRight_Click(sender As Object, e As System.EventArgs) Handles btn_createDirRight.Click
        Dim dirName As String
        'If resultado <> "" Then
        '    dirName = resultado
        '    createDir(Path.Combine(txt_pathRight.Text, dirName))
        '    refreshListas()
        'ElseIf resultado = "" Then
        '    dirName = "Nueva Carpeta"
        '    createDir(Path.Combine(txt_pathRight.Text, dirName))
        '    refreshListas()
        'ElseIf resultado Is Nothing Then


        ' End If

        Dim Answer As String = InputBox("Introduzca el nombre de la carpeta", DefaultResponse:=vbCr)
        If Answer = "" Then

        ElseIf Answer = vbCr Then
            dirName = "Nueva Carpeta"
            createDir(Path.Combine(txt_pathRight.Text, dirName))
            refreshListas()
        Else
            dirName = Answer
            createDir(Path.Combine(txt_pathRight.Text, dirName))
            refreshListas()
        End If



    End Sub

    Private Sub btn_createDirRight_MouseEnter(sender As Object, e As System.EventArgs) Handles btn_createDirRight.MouseEnter

        btn_createDirRight.BackgroundImage = My.Resources.newDir_48_colored
    End Sub

    Private Sub btn_createDirRight_MouseLeave(sender As Object, e As System.EventArgs) Handles btn_createDirRight.MouseLeave
        btn_createDirRight.BackgroundImage = My.Resources.newDir_48_white
    End Sub

    Private Sub btn_createTextRight_MouseEnter(sender As Object, e As System.EventArgs) Handles btn_createTextRight.MouseEnter
        btn_createTextRight.BackgroundImage = My.Resources.newFile_48_colored
    End Sub

    Private Sub btn_createTextRight_MouseLeave(sender As Object, e As System.EventArgs) Handles btn_createTextRight.MouseLeave
        btn_createTextRight.BackgroundImage = My.Resources.newFile_48_white
    End Sub

    Private Sub btn_createTxtLeft_MouseEnter(sender As Object, e As System.EventArgs) Handles btn_createTxtLeft.MouseEnter
        btn_createTxtLeft.BackgroundImage = My.Resources.newFile_48_colored
    End Sub

    Private Sub btn_createTxtLeft_MouseLeave(sender As Object, e As System.EventArgs) Handles btn_createTxtLeft.MouseLeave
        btn_createTxtLeft.BackgroundImage = My.Resources.newFile_48_white
    End Sub

    Private Sub btn_deleteLeft_MouseEnter(sender As Object, e As System.EventArgs) Handles btn_deleteLeft.MouseEnter
        btn_deleteLeft.BackgroundImage = My.Resources.binned_65_colored
    End Sub

    Private Sub btn_deleteLeft_MouseLeave(sender As Object, e As System.EventArgs) Handles btn_deleteLeft.MouseLeave
        btn_deleteLeft.BackgroundImage = My.Resources.binned_65_white
    End Sub

    Private Sub btn_createDirLeft_MouseEnter(sender As Object, e As System.EventArgs) Handles btn_createDirLeft.MouseEnter
        btn_createDirLeft.BackgroundImage = My.Resources.newDir_48_colored
    End Sub

    Private Sub btn_createDirLeft_MouseLeave(sender As Object, e As System.EventArgs) Handles btn_createDirLeft.MouseLeave
        btn_createDirLeft.BackgroundImage = My.Resources.newDir_48_white
    End Sub

    Private Sub btn_createTextRight_Click(sender As System.Object, e As System.EventArgs) Handles btn_createTextRight.Click
        createTxt(txt_pathRight.Text)
        Me.Enabled = False

    End Sub















    'FILTRO PARA EL NAVEGADOR DE FICHEROS
    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btn_filtro.Click
        Dim filtro As String = InputBox("Introduzca el filtro", "")
        Dim carpetas As String() = Directory.GetDirectories(txt_pathLeft.Text)
        Dim archivos As String() = Directory.GetFiles(txt_pathLeft.Text)
        CheckedListBox1.Items.Clear()


        If filtro = "" Then

        Else
            For Each carpeta As String In carpetas
                If Path.GetFileName(carpeta).ToLower.Contains(filtro.ToLower) Then
                    CheckedListBox1.Items.Add("📁 " & Path.GetFileName(carpeta))

                End If
            Next

            ' Agregar los archivos que cumplan con el filtro al CheckedListBox
            For Each archivo As String In archivos
                If Path.GetFileName(archivo).ToLower.Contains(filtro.ToLower) Then
                    CheckedListBox1.Items.Add("📄 " & Path.GetFileName(archivo))

                End If
            Next
        End If

    End Sub

    Private Sub btn_refresh_Click(sender As System.Object, e As System.EventArgs) Handles btn_refresh.Click
        refreshListas()
    End Sub



    Private Sub NuevaCarpetaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevaCarpetaToolStripMenuItem.Click
        Dim dirName As String
        'If resultado <> "" Then
        '    dirName = resultado
        '    createDir(Path.Combine(txt_pathRight.Text, dirName))
        '    refreshListas()
        'ElseIf resultado = "" Then
        '    dirName = "Nueva Carpeta"
        '    createDir(Path.Combine(txt_pathRight.Text, dirName))
        '    refreshListas()
        'ElseIf resultado Is Nothing Then


        ' End If

        Dim Answer As String = InputBox("Introduzca el nombre de la carpeta", DefaultResponse:=vbCr)
        If Answer = "" Then

        ElseIf Answer = vbCr Then
            dirName = "Nueva Carpeta"
            createDir(Path.Combine(txt_pathRight.Text, dirName.Trim))
            refreshListas()
        Else
            dirName = Answer
            createDir(Path.Combine(txt_pathRight.Text, dirName.Trim))
            refreshListas()
        End If


    End Sub

    Private Sub NuevaCarpetaToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles NuevaCarpetaToolStripMenuItem1.Click
        Dim dirName As String
        'If resultado <> "" Then
        '    dirName = resultado
        '    createDir(Path.Combine(txt_pathRight.Text, dirName))
        '    refreshListas()
        'ElseIf resultado = "" Then
        '    dirName = "Nueva Carpeta"
        '    createDir(Path.Combine(txt_pathRight.Text, dirName))
        '    refreshListas()
        'ElseIf resultado Is Nothing Then


        ' End If

        Dim Answer As String = InputBox("Introduzca el nombre de la carpeta", DefaultResponse:=vbCr)
        If Answer = "" Then

        ElseIf Answer = vbCr Then
            dirName = "Nueva Carpeta"
            createDir(Path.Combine(txt_pathLeft.Text, dirName.Trim))
            refreshListas()
        Else
            dirName = Answer
            createDir(Path.Combine(txt_pathLeft.Text, dirName.Trim))
            refreshListas()
        End If

    End Sub

    Private Sub NuevoFicheroDeTextoToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles NuevoFicheroDeTextoToolStripMenuItem.Click
        createTxt(txt_pathRight.Text)
        Me.Enabled = False
    End Sub


    Private Sub NuevoFicheroDeTextoToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles NuevoFicheroDeTextoToolStripMenuItem1.Click
        createTxt(txt_pathLeft.Text)
        Me.Enabled = False
    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs) Handles btn_filtroD.Click, Button2.Click
        Dim filtro As String = InputBox("Introduzca el filtro", "")
        Dim carpetas As String() = Directory.GetDirectories(txt_pathRight.Text)
        Dim archivos As String() = Directory.GetFiles(txt_pathRight.Text)
        CheckedListBox2.Items.Clear()


        If filtro = "" Then

        Else
            For Each carpeta As String In carpetas
                If Path.GetFileName(carpeta).ToLower.Contains(filtro.ToLower) Then
                    CheckedListBox2.Items.Add("📁 " & Path.GetFileName(carpeta))

                End If
            Next


            For Each archivo As String In archivos
                If Path.GetFileName(archivo).ToLower.Contains(filtro.ToLower) Then
                    CheckedListBox2.Items.Add("📄 " & Path.GetFileName(archivo))

                End If
            Next
        End If
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles btn_refreshD.Click
        refreshListas()
    End Sub


    Private Sub btn_filtro_MouseEnter(sender As Object, e As System.EventArgs) Handles btn_filtro.MouseEnter
        btn_filtro.BackgroundImage = My.Resources.find_48_colored
    End Sub

    Private Sub btn_filtro_MouseLeave(sender As Object, e As System.EventArgs) Handles btn_filtro.MouseLeave
        btn_filtro.BackgroundImage = My.Resources.find_48_white
    End Sub

    Private Sub btn_refresh_MouseEnter(sender As Object, e As System.EventArgs) Handles btn_refresh.MouseEnter
        btn_refresh.BackgroundImage = My.Resources.refresh_hover
    End Sub

    Private Sub btn_refresh_MouseLeave(sender As Object, e As System.EventArgs) Handles btn_refresh.MouseLeave
        btn_refresh.BackgroundImage = My.Resources.refresh_white
    End Sub


    Private Sub btn_filtroD_MouseEnter(sender As Object, e As System.EventArgs) Handles btn_filtroD.MouseEnter
        btn_filtroD.BackgroundImage = My.Resources.find_48_white
    End Sub

    Private Sub btn_filtroD_MouseLeave(sender As Object, e As System.EventArgs) Handles btn_filtroD.MouseLeave
        btn_filtroD.BackgroundImage = My.Resources.find_48_white
    End Sub

    Private Sub btn_refreshD_MouseEnter(sender As Object, e As System.EventArgs) Handles btn_refreshD.MouseEnter
        btn_refreshD.BackgroundImage = My.Resources.refresh_hover
    End Sub

    Private Sub btn_refreshD_MouseLeave(sender As Object, e As System.EventArgs) Handles btn_refreshD.MouseLeave
        btn_refreshD.BackgroundImage = My.Resources.refresh_white
    End Sub

    Private Sub btn_rutaIzq_MouseEnter(sender As Object, e As System.EventArgs) Handles btn_rutaIzq.MouseEnter
        btn_rutaIzq.BackgroundImage = My.Resources.openDir_48_colored
    End Sub

    Private Sub btn_rutaIzq_MouseLeave(sender As Object, e As System.EventArgs) Handles btn_rutaIzq.MouseLeave
        btn_rutaIzq.BackgroundImage = My.Resources.dir_48_colored
    End Sub


    Private Sub btn_rutaDrcha_MouseEnter(sender As Object, e As System.EventArgs) Handles btn_rutaDrcha.MouseEnter
        btn_rutaDrcha.BackgroundImage = My.Resources.openDir_48_colored
    End Sub

    Private Sub btn_rutaDrcha_MouseLeave(sender As Object, e As System.EventArgs) Handles btn_rutaDrcha.MouseLeave
        btn_rutaDrcha.BackgroundImage = My.Resources.dir_48_colored
    End Sub

    Private Sub btn_pathBack_left_MouseEnter(sender As Object, e As System.EventArgs) Handles btn_pathBack_left.MouseEnter
        btn_pathBack_left.BackgroundImage = My.Resources.arrowLeft_68_colored
    End Sub

    Private Sub btn_pathBack_left_MouseLeave(sender As Object, e As System.EventArgs) Handles btn_pathBack_left.MouseLeave
        btn_pathBack_left.BackgroundImage = My.Resources.arrowLeft_50_white
    End Sub

    Private Sub btn_pathBackRight_MouseEnter(sender As Object, e As System.EventArgs) Handles btn_pathBackRight.MouseEnter
        btn_pathBackRight.BackgroundImage = My.Resources.arrowLeft_68_colored
    End Sub

    Private Sub btn_pathBackRight_MouseLeave(sender As Object, e As System.EventArgs) Handles btn_pathBackRight.MouseLeave
        btn_pathBackRight.BackgroundImage = My.Resources.arrowLeft_50_white
    End Sub

    Private Sub btn_moveToRight_MouseEnter(sender As Object, e As System.EventArgs) Handles btn_moveToRight.MouseEnter
        btn_moveToRight.BackgroundImage = My.Resources.arrowRight_68_colored
    End Sub

    Private Sub btn_moveToRight_MouseLeave(sender As Object, e As System.EventArgs) Handles btn_moveToRight.MouseLeave
        btn_moveToRight.BackgroundImage = My.Resources.arrowRight_68_white
    End Sub
    Private Sub btn_moveToLeft_MouseEnter(sender As Object, e As System.EventArgs) Handles btn_moveToLeft.MouseEnter
        btn_moveToLeft.BackgroundImage = My.Resources.arrowLeft_68_colored
    End Sub

    Private Sub btn_moveToLeft_MouseLeave(sender As Object, e As System.EventArgs) Handles btn_moveToLeft.MouseLeave
        btn_moveToLeft.BackgroundImage = My.Resources.arrowLeft_68_white
    End Sub


    Private Sub CheckedListBox1_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CheckedListBox1.SelectedIndexChanged


        If CheckedListBox1.SelectedItems.Count <> 0 And CheckedListBox2.SelectedItems.Count <> 0 Then
            Try
                If CheckedListBox1.SelectedItem.ToString.EndsWith(".txt") And CheckedListBox2.SelectedItem.ToString.EndsWith(".txt") Then
                    btn_compareTxt.Visible = True
                Else
                    btn_compareTxt.Visible = False
                End If
            Catch ex As Exception

            End Try


        End If






        Try
            If CheckedListBox1.SelectedItem.ToString.EndsWith(".pdf") Then
                btn_pdfWm_left.Visible = True
            Else
                btn_pdfWm_left.Visible = False
            End If

        Catch ex As Exception

        End Try

        Dim mergeIsEnabled = False
        If CheckedListBox1.CheckedItems.Count > 1 Then
            For Each item As Object In CheckedListBox1.CheckedItems

                If item.ToString.EndsWith(".pdf") Then
                    mergeIsEnabled = True
                Else
                    mergeIsEnabled = False
                    Exit For

                End If
            Next
        End If

        If mergeIsEnabled = True Then
            btn_mergePDFs_left.Visible = True
        Else
            btn_mergePDFs_left.Visible = False
        End If

        Try
            Label1.Text = CheckedListBox1.SelectedItem.ToString
        Catch ex As Exception

        End Try


    End Sub

    Private Sub CheckedListBox2_SelectedIndexChanged(sender As System.Object, e As System.EventArgs) Handles CheckedListBox2.SelectedIndexChanged
        If CheckedListBox1.SelectedItems.Count <> 0 And CheckedListBox2.SelectedItems.Count <> 0 Then
            If CheckedListBox1.SelectedItem.ToString.EndsWith(".txt") And CheckedListBox2.SelectedItem.ToString.EndsWith(".txt") Then
                btn_compareTxt.Visible = True
            Else
                btn_compareTxt.Visible = False
            End If

        End If


        Try

        Catch ex As Exception
            If CheckedListBox2.SelectedItem.ToString.EndsWith(".pdf") Then
                btn_pdfWm_right.Visible = True
            Else
                btn_pdfWm_right.Visible = False
            End If
        End Try


        Dim mergeIsEnabled = False
        If CheckedListBox2.CheckedItems.Count > 1 Then
            For Each item As Object In CheckedListBox2.CheckedItems

                Try
                    If item.ToString.EndsWith(".pdf") Then
                        mergeIsEnabled = True
                    Else
                        mergeIsEnabled = False
                        Exit For

                    End If
                Catch ex As Exception

                End Try

            Next
        End If

        If mergeIsEnabled = True Then
            btn_mergePDFs_right.Visible = True
        Else
            btn_mergePDFs_right.Visible = False
        End If

        Try
            Label2.Text = CheckedListBox2.SelectedItem.ToString
        Catch ex As Exception

        End Try

    End Sub



    Private Sub Button1_Click_2(sender As System.Object, e As System.EventArgs) Handles btn_newPdf_left.Click
        newPdf.Show()
        Form1.Enabled = False
        refreshListas()


    End Sub




    Private Sub ComprimirToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles ComprimirToolStripMenuItem1.Click

    End Sub

    Private Sub ComprimirToolStripMenuItem2_Click(sender As System.Object, e As System.EventArgs) Handles ComprimirToolStripMenuItem2.Click
        Dim file As String = obtenerRutaFicheroDer()
        zipfile(file, txt_pathRight.Text, CheckedListBox2.SelectedItem.ToString.Substring(3))
        refreshListas()
    End Sub


    Private Sub ComprimirToolStripMenuItem3_Click(sender As System.Object, e As System.EventArgs) Handles ComprimirToolStripMenuItem3.Click
        Dim file As String = obtenerRutaFicheroIzq()
        zipfile(file, txt_pathLeft.Text, CheckedListBox1.SelectedItem.ToString.Substring(3))
        refreshListas()
    End Sub


    Private Sub AbrirUbicaciónToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles AbrirUbicaciónToolStripMenuItem.Click
        openfileDir(obtenerRutaFicheroDer)
    End Sub

    Private Sub AbrirUbicaciónToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles AbrirUbicaciónToolStripMenuItem1.Click
        openfileDir(obtenerRutaFicheroIzq)
    End Sub

    Private Sub Button1_Click_3(sender As System.Object, e As System.EventArgs) Handles btn_pdfWm_left.Click
        If Path.GetExtension(obtenerRutaFicheroIzq) = ".pdf" Then
            If fbd_listaLeft.ShowDialog() = DialogResult.OK Then
                Dim dest As String = Path.Combine(fbd_listaLeft.SelectedPath, Path.GetFileName(obtenerRutaFicheroIzq))

                Dim dir As String = Path.GetDirectoryName(dest)
                Dim name As String = Path.GetFileNameWithoutExtension(dest)
                Dim ext As String = Path.GetExtension(dest)

                Dim contador As Integer = 1


                While File.Exists(dest)
                    dest = Path.Combine(dir, (name & "(copia)" & ext))
                End While

                marcagua(obtenerRutaFicheroIzq, dest)
                refreshListas()
            End If
        Else
            MsgBox("selecciona un fichero")
        End If



    End Sub

    Private Sub Button1_Click_4(sender As System.Object, e As System.EventArgs) Handles btn_mergePDFs_left.Click

        Dim ispdf As Boolean = False

        Dim pdf(CheckedListBox1.CheckedItems.Count - 1) As String
        For i As Integer = 0 To CheckedListBox1.CheckedItems.Count - 1
            pdf(i) = Path.Combine(txt_pathLeft.Text, CheckedListBox1.CheckedItems(i).ToString.Substring(3))

        Next
        For Each pdfs As String In pdf
            If Path.GetExtension(pdfs) = ".pdf" Then
                ispdf = True

            Else
                ispdf = False
                MsgBox("Debe seleccionar sólo ficheros pdf.")
                Exit For
            End If
        Next
        If ispdf = True Then
            If fbd_listaLeft.ShowDialog = DialogResult.OK Then
            End If
            Dim newFileName As String = InputBox("Escribe el nombre del fichero que quieres crear:")
            Dim DestPath As String = fbd_listaLeft.SelectedPath
            mergePdfs(pdf, newFileName, DestPath)
            refreshListas()
        End If



    End Sub

    Private Sub btn_mergePDFs_right_Click(sender As System.Object, e As System.EventArgs) Handles btn_mergePDFs_right.Click
        Dim ispdf As Boolean = False

        Dim pdf(CheckedListBox2.CheckedItems.Count - 1) As String
        For i As Integer = 0 To CheckedListBox2.CheckedItems.Count - 1
            pdf(i) = Path.Combine(txt_pathRight.Text, CheckedListBox2.CheckedItems(i).ToString.Substring(3))

        Next
        For Each pdfs As String In pdf
            If Path.GetExtension(pdfs) = ".pdf" Then
                ispdf = True

            Else
                ispdf = False
                MsgBox("Debe seleccionar sólo ficheros pdf.")
                Exit For
            End If
        Next
        If ispdf = True Then
            If fbd_listaRight.ShowDialog = DialogResult.OK Then
            End If
            Dim newFileName As String = InputBox("Escribe el nombre del fichero que quieres crear:")
            Dim DestPath As String = fbd_listaRight.SelectedPath
            mergePdfs(pdf, newFileName, DestPath)
            refreshListas()
        End If


    End Sub

    Private Sub btn_pdfWm_right_Click(sender As System.Object, e As System.EventArgs) Handles btn_pdfWm_right.Click
        If Path.GetExtension(obtenerRutaFicheroDer) = ".pdf" Then
            If fbd_listaRight.ShowDialog() = DialogResult.OK Then
                Dim dest As String = Path.Combine(fbd_listaRight.SelectedPath, Path.GetFileName(obtenerRutaFicheroDer))

                Dim dir As String = Path.GetDirectoryName(dest)
                Dim name As String = Path.GetFileNameWithoutExtension(dest)
                Dim ext As String = Path.GetExtension(dest)

                Dim contador As Integer = 1


                While File.Exists(dest)
                    dest = Path.Combine(dir, (name & "(copia)" & ext))
                End While

                marcagua(obtenerRutaFicheroDer, dest)
                refreshListas()
            End If
        Else
            MsgBox("selecciona un fichero")
        End If

    End Sub

    Private Sub btn_newPdf_right_Click(sender As System.Object, e As System.EventArgs) Handles btn_newPdf_right.Click
        newPdf.Show()
        Form1.Enabled = False
        refreshListas()
    End Sub

    Private Sub ProtegerConContraseñaToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles ProtegerConContraseñaToolStripMenuItem.Click
        If CheckedListBox1.SelectedItem.ToString.EndsWith(".pdf") Then
            PassToPdf.lbl_path.Tag = obtenerRutaFicheroIzq()
            PassToPdf.Label1.Tag = txt_pathLeft.Text
            PassToPdf.Show()
        Else
            MsgBox("Selecciona un fichero pdf.")
        End If


    End Sub

    Private Sub PropiedadesToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles PropiedadesToolStripMenuItem.Click
        If CheckedListBox1.SelectedItem.ToString.EndsWith(".pdf") Then
            readMetadataPdf(obtenerRutaFicheroIzq)
        Else
            MsgBox("Debes seleccionar un fichero PDF.")
        End If

    End Sub

    Private Sub DescomprimirToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs) Handles DescomprimirToolStripMenuItemR.Click
        unzipFile(obtenerRutaFicheroDer, txt_pathRight.Text & "\" & Path.GetFileNameWithoutExtension(obtenerRutaFicheroDer))
    End Sub

    Private Sub DescomprimirToolStripMenuItem1_Click(sender As System.Object, e As System.EventArgs) Handles DescomprimirToolStripMenuItem.Click
        unzipFile(obtenerRutaFicheroIzq, txt_pathLeft.Text & "\" & Path.GetFileNameWithoutExtension(obtenerRutaFicheroIzq))
    End Sub

    Private Sub FirmaDigitalToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button1_Click_5(sender As System.Object, e As System.EventArgs)
        Dim selecteditems As New List(Of String)
        For Each selecteditem As Object In CheckedListBox1.CheckedItems
            selecteditems.Add(Path.Combine(txt_pathLeft.Text, selecteditem.ToString().Substring(3)))
        Next
    End Sub

    Private Sub Button1_Click_6(sender As System.Object, e As System.EventArgs) Handles Button1.Click
        EliminarCapas(obtenerRutaFicheroIzq, Path.Combine(txt_pathRight.Text, Path.GetFileNameWithoutExtension(obtenerRutaFicheroIzq) & " (sinmarquita).pdf"))
    End Sub
End Class