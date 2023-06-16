Imports System.IO
Imports System.IO.Path
Imports System.Text.RegularExpressions
Imports System.Text
Imports iTextSharp.text.pdf
Imports Ionic.Zip
Imports System.Diagnostics
Imports Org.BouncyCastle.Pkcs
Imports Org.BouncyCastle.Security
Imports Org.BouncyCastle.X509
Imports Org.BouncyCastle.Crypto
Imports System.Security.Cryptography.X509Certificates
Imports iTextSharp.text.html.simpleparser
Imports System.Net
Imports System.Threading






Module Controller

    Public miClase As New DB_Controller
    Public usuario As String
    Public password As String
    Public idUsuario As Integer
    Public isLogin As Boolean = False
    Public grupoLogin As String

    Public processIconcolored As Boolean = False
    Public completedIconcolored As Boolean = False
    Public binnedIconColored As Boolean = False
    Public addIconColored As Boolean = False

    Public Sub materialBtn(button As Button, setColor As String)

        button.FlatStyle = FlatStyle.Flat
        button.FlatAppearance.BorderSize = 0
        button.ForeColor = Color.White
        button.Font = New Font("Segoe UI", 9, FontStyle.Bold)

        Select Case setColor
            Case "normal"
                button.BackColor = Color.FromArgb(42, 157, 143)
                button.FlatAppearance.MouseOverBackColor = Color.FromArgb(62, 177, 163)
                button.FlatAppearance.MouseDownBackColor = Color.FromArgb(38, 70, 83)

            Case "verde"

                button.BackColor = Color.FromArgb(113, 184, 115)
                button.FlatAppearance.MouseOverBackColor = Color.FromArgb(93, 164, 95)
                button.FlatAppearance.MouseDownBackColor = Color.FromArgb(73, 144, 75)
                button.Font = New Font("Segoe UI", 11, FontStyle.Bold)

            Case "amarillo"
                button.BackColor = Color.FromArgb(244, 162, 97)
                button.FlatAppearance.MouseOverBackColor = Color.FromArgb(233, 196, 106)
                button.FlatAppearance.MouseDownBackColor = Color.FromArgb(254, 216, 126)
            Case "naranja"

                button.BackColor = Color.FromArgb(244, 162, 97)
                button.FlatAppearance.MouseOverBackColor = Color.FromArgb(204, 122, 57)
                button.FlatAppearance.MouseDownBackColor = Color.FromArgb(194, 112, 47)
            Case "rojo"
                button.BackColor = Color.FromArgb(231, 111, 81)
                button.FlatAppearance.MouseOverBackColor = Color.FromArgb(251, 131, 101)
                button.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 151, 121)
            Case "premium"
                button.BackColor = Color.FromArgb(233, 196, 106)
                button.FlatAppearance.MouseOverBackColor = Color.FromArgb(203, 166, 76)
                button.FlatAppearance.MouseDownBackColor = Color.FromArgb(254, 216, 126)
                button.ForeColor = Color.Black
            Case "dual"
                button.BackColor = Color.FromArgb(78, 110, 123)
                button.FlatAppearance.MouseOverBackColor = Color.FromArgb(203, 166, 76)
                button.FlatAppearance.MouseDownBackColor = Color.FromArgb(254, 216, 126)
                button.ForeColor = Color.White
        End Select



        button.Cursor = Cursors.Hand
    End Sub


    Public Sub showDirTree(path As String, treeView As TreeView)


        Dim rootNode As TreeNode = treeView.Nodes.Add(path)

        MostrarEstructuraDirectorioInternoTreeView(path, rootNode)
        treeView.Nodes(0).Expand()
    End Sub

    Private Sub MostrarEstructuraDirectorioInternoTreeView(path As String, parentNode As TreeNode)
        Dim carpetas As String() = Directory.GetDirectories(path)
        Try
            For Each carpeta As String In carpetas
                Dim nombreCarpeta As String = System.IO.Path.GetFileName(carpeta)
                Dim nodoCarpeta As TreeNode = parentNode.Nodes.Add(nombreCarpeta)
                nodoCarpeta.Expand()
                MostrarEstructuraDirectorioInternoTreeView(carpeta, nodoCarpeta)
            Next

            Dim archivos As String() = Directory.GetFiles(path)

            For Each archivo As String In archivos
                Dim nombreArchivo As String = System.IO.Path.GetFileName(archivo)
                parentNode.Nodes.Add(nombreArchivo)
            Next

        Catch ex As Exception
        End Try

    End Sub

    Public Sub listarFicheros(path As String, lista As CheckedListBox)
        lista.Items.Clear()
        Try
            Try
                Dim elementosLista As New List(Of String)
                Dim carpetas As String() = Directory.GetDirectories(path)
                Dim archivos As String() = Directory.GetFiles(path)

                For Each carpeta As String In carpetas
                    Dim nombreCarpeta As String = System.IO.Path.GetFileName(carpeta)
                    '' Dim carpetaLista As String = lista.Items.Add(nombreCarpeta)


                    elementosLista.Add("📁 " & nombreCarpeta)


                Next

                For Each archivo As String In archivos
                    Dim nombreArchivo As String = System.IO.Path.GetFileName(archivo)
                    '' lista.Items.Add("---" & nombreArchivo) 
                    If nombreArchivo.Contains(".zip") Or nombreArchivo.Contains(".rar") Then
                        elementosLista.Add("📚 " & nombreArchivo)
                    ElseIf nombreArchivo.Contains(".jpg") Or nombreArchivo.Contains(".png") Then
                        elementosLista.Add("📷 " & nombreArchivo)
                    Else
                        elementosLista.Add("📄 " & nombreArchivo)
                    End If




                Next


                For Each elemento As String In elementosLista
                    lista.Items.Add(elemento)
                Next
            Catch ex As Exception
                Debug.Print("No se han podido añadir elementos a la lista")
            End Try
        Catch ex As Exception

        End Try


    End Sub

    Public Sub listarFicherosLw(path As String, lista As ListView)
        lista.Items.Clear()
        Try
            Try
                Dim elementosLista As New List(Of String)
                Dim carpetas As String() = Directory.GetDirectories(path)
                Dim archivos As String() = Directory.GetFiles(path)

                For Each carpeta As String In carpetas
                    Dim nombreCarpeta As String = System.IO.Path.GetFileName(carpeta)
                    '' Dim carpetaLista As String = lista.Items.Add(nombreCarpeta)


                    elementosLista.Add("📁 " & nombreCarpeta)


                Next

                For Each archivo As String In archivos
                    Dim nombreArchivo As String = System.IO.Path.GetFileName(archivo)
                    '' lista.Items.Add("---" & nombreArchivo) 
                    If nombreArchivo.Contains(".zip") Or nombreArchivo.Contains(".rar") Then
                        elementosLista.Add("📚 " & nombreArchivo)
                    ElseIf nombreArchivo.Contains(".jpg") Or nombreArchivo.Contains(".png") Then
                        elementosLista.Add("📷 " & nombreArchivo)
                    Else
                        elementosLista.Add("📄 " & nombreArchivo)
                    End If




                Next


                For Each elemento As String In elementosLista
                    Dim nombre As String = elemento
                    Dim infoFile As New FileInfo(System.IO.Path.Combine(path, nombre.Substring(3)))

                    Dim item As New ListViewItem(nombre)

                    item.SubItems.Add(infoFile.LastWriteTime.ToString("yyy/dd/MM"))
                    item.SubItems.Add(infoFile.Extension)
                    lista.Items.Add(item)




                Next
            Catch ex As Exception
                Debug.Print("No se han podido añadir elementos a la lista")
            End Try
        Catch ex As Exception

        End Try


    End Sub

    Public Sub rellenarLista(txt_ruta As TextBox, fbd_listas As FolderBrowserDialog, checkedListBox As CheckedListBox)
        If Not txt_ruta.Text = Nothing Then
            Try
                fbd_listas.SelectedPath = txt_ruta.Text
                If fbd_listas.ShowDialog = Windows.Forms.DialogResult.OK Then
                    Dim path As String = fbd_listas.SelectedPath

                    listarFicheros(path, checkedListBox)
                    txt_ruta.Text = path
                End If

            Catch ex As Exception
                MsgBox("La ruta no existe.")
            End Try
        Else
            If fbd_listas.ShowDialog = Windows.Forms.DialogResult.OK Then
                Dim path As String = fbd_listas.SelectedPath
                txt_ruta.Text = path


                listarFicheros(path, checkedListBox)
            End If
        End If
    End Sub


    Public Sub refrescarGridFicheros(grid_ficheros As DataGridView, ruta As String)
        grid_ficheros.Rows.Clear()
        grid_ficheros.Columns.Clear()
        Dim directorio As String
        directorio = ruta
        ' Obtiene la lista de archivos en el directorio seleccionado
        Dim archivos() As String = Directory.GetFiles(directorio)
        Dim carpetas() As String = Directory.GetDirectories(directorio)
        grid_ficheros.Columns.Add("NombreArchivo", "Nombre")
        grid_ficheros.Columns.Add("TipoArchivo", "Tipo")
        grid_ficheros.Columns.Add("FechaCreacion", "Fecha de Creación")
        grid_ficheros.Columns.Add("UltimaModificacion", "Última Modificación")
        grid_ficheros.Columns.Add("size", "Tamaño de archivo")

        For Each archivo As String In archivos
            Dim infoArchivo As New FileInfo(archivo)


            ' Obtiene los atributos del archivo
            Dim fechaCreacion As String = infoArchivo.CreationTime.ToString("yyy/dd/MM")
            Dim tipoArchivo As String = infoArchivo.Extension
            Dim ultimaModificacion As String = infoArchivo.LastWriteTime.ToString("yyy/dd/MM")
            Dim nombreArchivo As String = infoArchivo.Name
            Dim fileSize As Long = infoArchivo.Length

            Dim fileSizeMB As Double = fileSize / 1048576

            ' Formatear el tamaño como un número con decimales y la unidad "MB"
            Dim formattedSize As String = fileSizeMB.ToString("0.00") & " MB"

            ' Agrega una nueva fila con los datos del archivo al DataGridView
            grid_ficheros.Rows.Add(nombreArchivo, tipoArchivo, fechaCreacion, ultimaModificacion, formattedSize)
        Next

        For Each carpeta As String In carpetas

            Dim infoCarpeta As New DirectoryInfo(carpeta)

            ' Obtiene los atributos del archivo
            Dim fechaCreacion As String = infoCarpeta.CreationTime.ToString()
            Dim tipoArchivo As String = "Directorio"
            Dim ultimaModificacion As String = infoCarpeta.LastWriteTime.ToString()
            Dim nombreArchivo As String = infoCarpeta.Name

            ' Agrega una nueva fila con los datos del archivo al DataGridView
            grid_ficheros.Rows.Add(nombreArchivo, tipoArchivo, fechaCreacion, ultimaModificacion)
        Next

    End Sub
    Public Function copyDir(sourceDir As String, destDir As String) As Boolean



        Try
            If Not Directory.Exists(destDir) Then
                Directory.CreateDirectory(destDir)
            End If

            For Each archivo As String In Directory.GetFiles(sourceDir)
                Dim nombreArchivo As String = System.IO.Path.GetFileName(archivo)
                Dim destinoArchivo As String = System.IO.Path.Combine(destDir, nombreArchivo)
                File.Copy(archivo, destinoArchivo)
            Next

            For Each subcarpeta As String In Directory.GetDirectories(sourceDir)
                Dim nombreSubcarpeta As String = System.IO.Path.GetFileName(subcarpeta)
                Dim destinoSubcarpeta As String = System.IO.Path.Combine(destDir, nombreSubcarpeta)
                copyDir(subcarpeta, destinoSubcarpeta)
            Next


            Return True

        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message)
            Return False
        End Try

    End Function
    Public Sub copyFile(pathFrom As String, pathTo As String)
        Try
            Dim fileinfo As New FileInfo(pathFrom)
            fileinfo.CopyTo(pathTo, False)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub

    Public Sub getMeta(fbdialog As FolderBrowserDialog, grid_ficheros As DataGridView, txt_ruta As TextBox)
        If fbdialog.ShowDialog() = DialogResult.OK Then
            ' Obtiene la ruta del directorio seleccionado
            Dim directorio As String = fbdialog.SelectedPath
            txt_ruta.Text = directorio
            ' Obtiene la lista de archivos en el directorio seleccionado
            Dim archivos() As String = Directory.GetFiles(directorio)
            Dim carpetas() As String = Directory.GetDirectories(directorio)

            ' Configura las columnas del DataGridView
            grid_ficheros.Columns.Add("NombreArchivo", "Nombre")
            grid_ficheros.Columns.Add("TipoArchivo", "Tipo")
            grid_ficheros.Columns.Add("FechaCreacion", "Fecha de Creación")
            grid_ficheros.Columns.Add("UltimaModificacion", "Última Modificación")
            grid_ficheros.Columns.Add("size", "Tamaño de archivo")


            ' Itera sobre cada archivo y agrega los datos al DataGridView
            For Each archivo As String In archivos
                Dim infoArchivo As New FileInfo(archivo)


                ' Obtiene los atributos del archivo
                Dim fechaCreacion As String = infoArchivo.CreationTime.ToString("yyy/dd/MM")
                Dim tipoArchivo As String = infoArchivo.Extension
                Dim ultimaModificacion As String = infoArchivo.LastWriteTime.ToString("yyy/dd/MM")
                Dim nombreArchivo As String = infoArchivo.Name
                Dim fileSize As Long = infoArchivo.Length

                Dim fileSizeMB As Double = fileSize / 1048576

                ' Formatear el tamaño como un número con decimales y la unidad "MB"
                Dim formattedSize As String = fileSizeMB.ToString("0.00") & " MB"

                ' Agrega una nueva fila con los datos del archivo al DataGridView
                grid_ficheros.Rows.Add(nombreArchivo, tipoArchivo, fechaCreacion, ultimaModificacion, formattedSize)
            Next

            For Each carpeta As String In carpetas

                Dim infoCarpeta As New DirectoryInfo(carpeta)

                ' Obtiene los atributos del archivo
                Dim fechaCreacion As String = infoCarpeta.CreationTime.ToString()
                Dim tipoArchivo As String = "Directorio"
                Dim ultimaModificacion As String = infoCarpeta.LastWriteTime.ToString()
                Dim nombreArchivo As String = infoCarpeta.Name

                ' Agrega una nueva fila con los datos del archivo al DataGridView
                grid_ficheros.Rows.Add(nombreArchivo, tipoArchivo, fechaCreacion, ultimaModificacion)
            Next
        End If
    End Sub
    Public Sub materialGrid(dgv As DataGridView)
        ' Configuración del DataGridView
        dgv.BorderStyle = BorderStyle.None
        dgv.EnableHeadersVisualStyles = False
        dgv.RowHeadersVisible = False
        dgv.DefaultCellStyle.Font = New Font("Segoe UI", 9)
        dgv.BackgroundColor = Color.FromArgb(58, 90, 103)
        dgv.ForeColor = Color.White
        dgv.SelectionMode = DataGridViewSelectionMode.FullRowSelect
        dgv.DefaultCellStyle.SelectionBackColor = Color.FromArgb(42, 157, 143)
        dgv.AllowUserToResizeRows = False
        ' Configuración de las cabeceras de columna
        dgv.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None
        dgv.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(38, 70, 83)
        dgv.ColumnHeadersDefaultCellStyle.ForeColor = Color.White
        dgv.ColumnHeadersDefaultCellStyle.Font = New Font("Segoe UI", 9, FontStyle.Bold)

        ' Configuración de las líneas de separación entre celdas
        dgv.GridColor = Color.FromArgb(38, 70, 83)

        ' Configuración de las líneas horizontales entre filas
        dgv.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal
        dgv.AdvancedCellBorderStyle.Top = DataGridViewAdvancedCellBorderStyle.None
        dgv.AdvancedCellBorderStyle.Bottom = DataGridViewAdvancedCellBorderStyle.Single

        ' Configuración de las líneas verticales entre columnas
        dgv.AdvancedCellBorderStyle.Left = DataGridViewAdvancedCellBorderStyle.None
        dgv.AdvancedCellBorderStyle.Right = DataGridViewAdvancedCellBorderStyle.None

        ' Configuración de los estilos de las filas alternadas
        dgv.RowsDefaultCellStyle.BackColor = Color.FromArgb(52, 81, 92)
        dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(32, 61, 72)

        ' Configuración del estilo de desplazamiento vertical
        dgv.ScrollBars = ScrollBars.Both

        ' Configuración de la apariencia de la celda de edición
        dgv.EditMode = DataGridViewEditMode.EditProgrammatically
    End Sub

    Public Sub analizaLotes(dgv As DataGridView, fbdialog As FolderBrowserDialog, txt_ruta As TextBox)
        ' Limpiar DataGridView antes de agregar nuevos datos
        dgv.Rows.Clear()

        ' Obtener la ruta del directorio seleccionado
        If fbdialog.ShowDialog() = DialogResult.OK Then
            Dim directorio As String = fbdialog.SelectedPath
            txt_ruta.Text = directorio
            ' Obtener todos los archivos en el directorio
            Dim archivos As String() = Directory.GetFiles(directorio)

            ' Expresiones regulares para analizar los nombres de los archivos
            Dim regexInforme As New Regex("(\d{8})_(\w+)-(\w+)(\.\w+)")
            Dim regexRevision As New Regex("(\d+)-(\w+)-(\w+)(\.\w+)")
            Dim informeIsValid As Integer = 1
            Dim revisionIsValid As Integer = 1



            For Each archivo As String In archivos

                Dim nombreArchivo As String = Path.GetFileName(archivo)

                ' Comprobar formato de nombre y extraer información
                Dim informeMatch As Match = regexInforme.Match(nombreArchivo)
                Dim revisionMatch As Match = regexRevision.Match(nombreArchivo)

                ' Agregar información al DataGridView según el formato del nombre del archivo
                If informeMatch.Success Then
                    If informeIsValid = 1 Then
                        dgv.Columns.Add("Fecha Informe", "Fecha informe")
                        dgv.Columns.Add("Tipo informe", "Tipo informe")
                        dgv.Columns.Add("Obra", "Obra")
                        dgv.Columns.Add("Tipo archivo", "Tipo archivo")

                        informeIsValid = 0
                    End If

                    Dim fechaInforme As String = informeMatch.Groups(1).Value
                    ' Formatea la fecha para que sea legible en el gridview
                    fechaInforme = String.Format("{0}/{1}/{2}", fechaInforme.Substring(0, 2), fechaInforme.Substring(2, 2), fechaInforme.Substring(4, 4))
                    Dim tipoInforme As String = informeMatch.Groups(2).Value
                    Dim obra As String = informeMatch.Groups(3).Value
                    Dim extension As String = informeMatch.Groups(4).Value

                    dgv.Rows.Add(fechaInforme, tipoInforme, obra, extension)
                ElseIf revisionMatch.Success Then
                    If revisionIsValid = 1 Then
                        dgv.Columns.Add("Numero documento", "Número documento")
                        dgv.Columns.Add("Revision", "Revisión")
                        dgv.Columns.Add("Titulo", "Título")
                        dgv.Columns.Add("Tipo archivo", "Tipo archivo")
                        revisionIsValid = 0
                    End If

                    Dim numerodoc As String = revisionMatch.Groups(1).Value
                    Dim numeroRevision As String = revisionMatch.Groups(2).Value
                    Dim titulo As String = revisionMatch.Groups(3).Value
                    Dim extension As String = revisionMatch.Groups(4).Value

                    dgv.Rows.Add(numerodoc, numeroRevision, titulo, extension)
                Else
                    MsgBox("Algún archivo no coincide con el formato")
                    Return
                End If
            Next
        End If

    End Sub

    Public Sub formatDateNames(fbDialog As FolderBrowserDialog, txt_ruta As TextBox)
        If fbDialog.ShowDialog() = DialogResult.OK Then
            Dim directorio As String = fbDialog.SelectedPath
            txt_ruta.Text = directorio

            Dim archivos As String() = Directory.GetFiles(directorio)

            For Each archivo As String In archivos
                Dim infoArchivo As New FileInfo(archivo)
                Dim nombreArchivo As String = Path.GetFileName(archivo)
                Dim fechaCreacion As String = infoArchivo.CreationTime.ToString("yyyyMMdd_HHmmss")
                Dim rutaArchivo As String = directorio & "\" & nombreArchivo
                Dim nuevaRutaArchivo As String = directorio & "\" & fechaCreacion & "-" & nombreArchivo
                File.Move(rutaArchivo, nuevaRutaArchivo)
            Next
        End If
    End Sub

    Public Sub moveFile(rutaOrigen As String, rutaCompletaDestino As String)
        Try
            If File.Exists(rutaOrigen) Then
                File.Move(rutaOrigen, rutaCompletaDestino)
            Else
                MsgBox("Debes seleccionar un fichero")
            End If

        Catch ex As Exception
            MsgBox("Error FATALITY: " & vbCrLf & ex.Message)
        End Try

    End Sub


    Public Sub createTxt(path As String) 'nombre As String, ruta As String)
        Dim txtDialog As New CustomDialog
        txtDialog.Show()
        txtDialog.lbl_title.Text = "Creación de archivo de texto"
        txtDialog.lbl_path.Text = path








    End Sub

    Public Sub createDir(path As String)
        Directory.CreateDirectory(path)

    End Sub
    ''evento click del nuevo formulario customdialog creado en el metodo createtext
    'Private Sub btn_submitClick(sender As Object, e As EventArgs)

    'End Sub
    Public Sub movingFilesSurname(fbDialogFrom As FolderBrowserDialog, fbDialogTo As FolderBrowserDialog, txt_rutaFrom As TextBox, txt_rutaTo As TextBox)
        If fbDialogFrom.ShowDialog() = DialogResult.OK Then
            Dim directorio As String = fbDialogFrom.SelectedPath
            txt_rutaFrom.Text = directorio


            If fbDialogTo.ShowDialog() = DialogResult.OK Then
                Dim destino As String = fbDialogTo.SelectedPath
                txt_rutaTo.Text = destino


                Dim archivos As String() = Directory.GetFiles(directorio)
                Dim fileIndex As Integer = 1
                Dim confirmResult As DialogResult = MessageBox.Show("¿Estás seguro de que deseas copiar los archivos?", "Confirmar copia", MessageBoxButtons.YesNo)
                If confirmResult = DialogResult.Yes Then

                    For Each archivo As String In archivos

                        Dim nombreArchivo As String = Path.GetFileName(archivo)
                        Dim prefijo As String = fileIndex.ToString("D3") & "_"
                        Dim nuevoNombre As String = Path.Combine(destino, prefijo & nombreArchivo)

                        File.Copy(archivo, nuevoNombre)
                        fileIndex += 1
                    Next
                Else
                    MsgBox("Se canceló la operación")
                End If

            End If




        End If
    End Sub
    'Public Sub AnimateBackground(ByVal backgroundImage As Image, ByVal pictureBox As PictureBox)
    '    Dim backgroundImagePosition As Integer = 0
    '    Dim timer As New Timer()

    '    pictureBox.Image = backgroundImage
    '    pictureBox.SizeMode = PictureBoxSizeMode.StretchImage

    '    ' Configurar el intervalo del Timer en milisegundos (por ejemplo, 100 ms)
    '    timer.Interval = 10

    '    AddHandler timer.Tick, Sub(sender As Object, e As EventArgs)
    '                               ' Aumentar la posición de la imagen de fondo para simular el movimiento
    '                               backgroundImagePosition += 1

    '                               ' Si la imagen alcanza el ancho del PictureBox, reiniciar la posición
    '                               If backgroundImagePosition >= pictureBox.Width - 806 Then
    '                                   backgroundImagePosition -= 1
    '                               End If

    '                               ' Actualizar la posición de la imagen de fondo
    '                               pictureBox.Left = -backgroundImagePosition
    '                           End Sub

    '    ' Iniciar el Timer
    '    timer.Start()
    'End Sub
    Public Sub renameFile(name As String, newName As String, ext As String, ruta As String)
        newName = newName & "." & ext
        Dim rutaCompleta As String = ruta & name



        Try
            My.Computer.FileSystem.RenameFile(rutaCompleta, newName)
        Catch ex As Exception
            MsgBox("Error: " & vbCrLf & ex.Message)

        End Try
        MsgBox("El nombre del fichero ha sido cambiado")

    End Sub

    Public Sub setFileTypeIcon(fullFilePath As String, pic_viewer As PictureBox)
        If Directory.Exists(fullFilePath) Then
            ' La ruta es un directorio, mostrar el icono de carpeta
            pic_viewer.Image = Image.FromFile("C:\icons\dir_48_colored.png")
        Else
            Dim ext As String = Path.GetExtension(fullFilePath)
            Dim imgExt As String() = {".png", ".jpg", ".ico"}

            Select Case ext
                Case ".pdf"
                    pic_viewer.Image = Image.FromFile("C:\icons\pdf_48_red.png")
                Case ".txt"
                    pic_viewer.Image = Image.FromFile("C:\icons\txt_48_white.png")
                Case ".html"
                    pic_viewer.Image = Image.FromFile("C:\icons\html_48_white.png")
                Case Else
                    If imgExt.Contains(ext.ToLower()) Then
                        pic_viewer.Image = Image.FromFile(fullFilePath)
                    Else
                        pic_viewer.Image = Nothing
                    End If
            End Select
        End If
    End Sub
    Public Sub openfile(filePath As String)
        Process.Start(filePath)
    End Sub
    Public Sub openfileDir(filePath As String)
        Process.Start("explorer.exe", "/select," & filePath)
    End Sub
    Public Sub deleteFile(FilePath As String)
        Dim check1 As DialogResult = MessageBox.Show("¿Estás seguro de que quieres eliminar el fichero?", "Elimar fichero", MessageBoxButtons.YesNo)

        If check1 = DialogResult.Yes Then
            Try
                If File.Exists(FilePath) Then
                    File.Delete(FilePath)
                ElseIf Directory.Exists(FilePath) Then



                    Directory.Delete(FilePath, True)


                End If


                MsgBox("Fichero eliminado correctamente")

            Catch ex As Exception
                MsgBox("Error al eliminar el fichero:" & vbCrLf & ex.Message)
            End Try

        End If

    End Sub
    Public Sub compareTxt(rich1 As RichTextBox, rich2 As RichTextBox, txt1Path As String, txt2Path As String)

        Dim contador As Integer = 0
        Try
            rich1.Text = File.ReadAllText(txt1Path)
            rich2.Text = File.ReadAllText(txt2Path)
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        If rich1.TextLength <= rich2.TextLength Then
            For i As Integer = 0 To rich1.TextLength - 1

                If Not rich1.Text(i) = rich2.Text(i) Then
                    rich1.Select(i, 1)
                    rich1.SelectionColor = Color.Red
                    rich2.Select(i, 1)
                    rich2.SelectionColor = Color.Red
                Else
                    rich1.Select(i, 1)
                    rich1.SelectionColor = Color.Green
                    rich2.Select(i, 1)
                    rich2.SelectionColor = Color.Green
                End If
                contador = i
            Next
            For u As Integer = contador + 1 To rich2.TextLength - 1
                rich2.Select(u, 1)
                rich2.SelectionColor = Color.Red
            Next
        Else
            For i As Integer = 0 To rich2.TextLength - 1

                If Not rich1.Text(i) = rich2.Text(i) Then
                    rich1.Select(i, 1)
                    rich1.SelectionColor = Color.Red
                    rich2.Select(i, 1)
                    rich2.SelectionColor = Color.Red


                Else
                    rich1.Select(i, 1)
                    rich1.SelectionColor = Color.Green
                    rich2.Select(i, 1)
                    rich2.SelectionColor = Color.Green

                End If

                contador = i
            Next
            For u As Integer = contador + 1 To rich1.TextLength - 1
                rich1.Select(u, 1)
                rich1.SelectionColor = Color.Red
            Next
        End If


    End Sub

    Public Sub getBtnImage(btn As Button, img As String)
        btn.BackgroundImage = Image.FromFile("C:\icons\" & img)
    End Sub

    Public Sub createPdf(path As String, titulo As String, texto As String)
        Dim og As String = path
        Dim fs As New FileStream(og, FileMode.Create, FileAccess.Write, FileShare.None)
        Dim doc As New iTextSharp.text.Document(iTextSharp.text.PageSize.LETTER)
        Dim writer As PdfWriter = PdfWriter.GetInstance(doc, fs)
        doc.Open()
        doc.AddTitle("PDF de muestra")
        doc.AddAuthor("Jaime Pardo de Donlebún González")
        doc.AddSubject("a ver..")
        doc.AddCreator("Jaime Pardo de Donlebún González")
        doc.AddKeywords("iTextSharp, PDF, crear, albufeira, LaLiga, porito")
        doc.Add(New iTextSharp.text.Paragraph(texto))
        doc.NewPage()
        doc.Add(New iTextSharp.text.Paragraph("Esta es la segunda página del pdf" & vbCrLf & vbCrLf & vbCrLf & texto))


        doc.Close()



        Process.Start(path)
    End Sub
    Public Sub formatPdfg(ogFile As String, destFile As String, logoPath As String)
        Dim reader As New iTextSharp.text.pdf.PdfReader(ogFile)

        Using fs As New FileStream(destFile, FileMode.Create, FileAccess.Write, FileShare.None)

            Using stamper As New PdfStamper(reader, fs)

                Dim pagecount As Integer = reader.NumberOfPages
                Dim layer As New PdfLayer("HeaderAndFooter", stamper.Writer)



                For i = 1 To pagecount
                    'almacenamos las medidas de la pagina actual

                    Dim logo As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance(logoPath) 'Añadimos el logotipo a través de la interfaz de usuario
                    Dim rect As iTextSharp.text.Rectangle = reader.GetPageSize(i)
                    Dim cb As PdfContentByte = stamper.GetOverContent(i)
                    Dim ct As New ColumnText(cb)

                    cb.BeginLayer(layer)


                    Dim table As New PdfPTable(3)
                    table.TotalWidth = reader.GetPageSize(i).Width + 100

                    Dim columnWidths As Single() = {1.5F, 2.0F, 1.5F}
                    table.SetWidths(columnWidths)


                    Dim logoCell As New PdfPCell()
                    logo.ScaleToFit(30, 30)
                    logoCell.AddElement(logo)
                    logoCell.HorizontalAlignment = iTextSharp.text.Element.ALIGN_LEFT
                    logoCell.VerticalAlignment = iTextSharp.text.Element.ALIGN_TOP
                    logoCell.Border = Nothing
                    table.AddCell(logoCell)


                    Dim filename As New PdfPCell()
                    filename.AddElement(New iTextSharp.text.Phrase("Documento: " & My.Computer.FileSystem.GetName(destFile)))
                    filename.HorizontalAlignment = iTextSharp.text.Element.ALIGN_CENTER
                    filename.VerticalAlignment = iTextSharp.text.Element.ALIGN_TOP
                    filename.Border = Nothing
                    table.AddCell(filename)


                    Dim dateCell As New PdfPCell
                    dateCell.AddElement(New iTextSharp.text.Phrase(Date.Today.ToString("yyyy-MM-dd")))
                    dateCell.HorizontalAlignment = iTextSharp.text.Element.ALIGN_RIGHT
                    dateCell.VerticalAlignment = iTextSharp.text.Element.ALIGN_TOP
                    dateCell.Border = Nothing
                    table.AddCell(dateCell)


                    table.WriteSelectedRows(0, -1, 20, rect.Height - 10, cb)
                    cb.SetLiteral("q " & rect.Left & " " & rect.Bottom & " " & rect.Width & " " & rect.Height & " re W n")


                    Dim footer As New iTextSharp.text.Phrase("Página " & i.ToString) 'guardo en una variable el contenido del footer(en este caso es un string y no una tabla)
                    ColumnText.ShowTextAligned(cb, PdfContentByte.ALIGN_CENTER, footer, rect.Right() - 40, rect.Bottom + 10, 0)
                    cb.EndLayer()








                    'table.HorizontalAlignment = 0

                    'table.AddCell(logo)
                    'table.AddCell(New iTextSharp.text.Paragraph("Documento: " & My.Computer.FileSystem.GetName(destFile)))
                    'table.AddCell(New iTextSharp.text.Paragraph(Date.Today.ToString("yyyy-MM-dd")))
                    'table.WriteSelectedRows(0, 50, 40, 835, stamper.GetOverContent(i))
                    'table.WriteSelectedRows(1, 20, 300, 835, stamper.GetOverContent(i))
                    'table.WriteSelectedRows(2, 0, 400, 835, stamper.GetOverContent(i))






                Next
            End Using
        End Using
    End Sub
    Public Sub marcagua(ogFile As String, destFile As String)
        Dim og As String = ogFile
        Dim wmFile As String = destFile

        ' Creating iTextSharp.text.pdf.PdfReader object to read the Existing PDF Document
        Dim reader1 As iTextSharp.text.pdf.PdfReader = New iTextSharp.text.pdf.PdfReader(og)

        Using fs As FileStream = New FileStream(wmFile, FileMode.Create, FileAccess.Write, FileShare.None)
            ' Creating iTextSharp.text.pdf.PdfStamper object to write Data from iTextSharp.text.pdf.PdfReader object to FileStream object
            Using stamper As PdfStamper = New PdfStamper(reader1, fs)
                'Numero de páginas que contiene el documento
                Dim pageCount As Integer = reader1.NumberOfPages

                'Creación de capa para la marca de agua
                Dim layer As PdfLayer = New PdfLayer("WatermarkLayer", stamper.Writer)
                'Bucle que recorre cada pagina
                For i = 1 To pageCount
                    Dim rect As iTextSharp.text.Rectangle = reader1.GetPageSize(i)
                    Dim img As iTextSharp.text.Image = iTextSharp.text.Image.GetInstance("C:\icons\carpeta.png")
                    img.SetAbsolutePosition(rect.Width / 2, rect.Height / 2)
                    ' Get the ContentByte object
                    Dim cb As PdfContentByte = stamper.GetOverContent(i)



                    Dim header As New iTextSharp.text.Phrase(My.Computer.FileSystem.GetName(destFile)) 'guardo en una variable el contenido del header(en este caso es un string y no una tabla)
                    Dim footer As New iTextSharp.text.Phrase("Página " & i.ToString) 'guardo en una variable el contenido del footer(en este caso es un string y no una tabla)

                    'se añaden los elementos de header y footer
                    ColumnText.ShowTextAligned(cb, PdfContentByte.ALIGN_CENTER, header, (rect.Right() - rect.Left()) / 2, rect.Top() - 20, 0)

                    ColumnText.ShowTextAligned(cb, PdfContentByte.ALIGN_CENTER, footer, rect.Right() - 40, rect.Bottom + 10, 0)

                    cb.AddImage(img)

                    ' Tell the cb that the next commands should be "bound" to this new layer
                    cb.BeginLayer(layer)
                    cb.SetFontAndSize(BaseFont.CreateFont(BaseFont.HELVETICA, BaseFont.CP1252, BaseFont.NOT_EMBEDDED), 50)

                    Dim gState As PdfGState = New PdfGState()
                    gState.FillOpacity = 0.25F
                    cb.SetGState(gState)

                    cb.SetColorFill(iTextSharp.text.BaseColor.BLACK)
                    cb.BeginText()
                    'se añade la marca de agua
                    cb.ShowTextAligned(PdfContentByte.ALIGN_CENTER, "Marca de agua", rect.Width / 2, rect.Height / 2, 45.0F)
                    cb.EndText()

                    ' Close the layer
                    cb.EndLayer()

                Next


            End Using
        End Using
        reader1.Dispose()

        Process.Start(destFile)
    End Sub
    Public Function EliminarCapas(inputFile As String, unlayeredFile As String) As String
        Dim reader As New PdfReader(inputFile)
        reader.RemoveUnusedObjects()
        Dim page As PdfDictionary
        Dim contentArray As PdfArray

        Dim pagecount As Integer = reader.NumberOfPages
        For i = 1 To pagecount
            page = reader.GetPageN(i)
            contentArray = page.GetAsArray(PdfName.CONTENTS)
            If contentArray IsNot Nothing Then
                For j = 0 To contentArray.Size - 1
                    Dim stream As PRStream = contentArray.GetAsStream(j)
                    Dim content As String = Encoding.ASCII.GetString(PdfReader.GetStreamBytes(stream))

                    If content.IndexOf("/OC") >= 0 Then
                        stream.Put(PdfName.LENGTH, New PdfNumber(0))
                        stream.SetData(New Byte(-1) {})
                    End If

                Next
            End If
        Next

        ' Eliminar referencias a capas en el catálogo del documento
        Dim catalog As PdfDictionary = reader.Catalog
        If catalog.Contains(PdfName.OCPROPERTIES) Then
            catalog.Remove(PdfName.OCPROPERTIES)
        End If

        Dim fs As FileStream = New FileStream(unlayeredFile, FileMode.Create, FileAccess.Write, FileShare.None)
        Dim stamper As PdfStamper = New PdfStamper(reader, fs)
        stamper.Dispose()
        fs.Dispose()
        reader.Dispose()
        Return unlayeredFile
    End Function


    Public Sub mergePdfs(pdfs As String(), salida As String, destino As String)

        Dim document = New iTextSharp.text.Document()
        Dim outFile = Path.Combine(destino, salida & ".pdf") 'fichero de salida de la union de los pdf
        Dim writer = New PdfCopy(document, New FileStream(outFile, FileMode.Create))

        Try

            document.Open()
            For Each fileName As String In pdfs

                'Dim tempFile As String = Path.GetTempFileName


                Dim reader = New iTextSharp.text.pdf.PdfReader(fileName)

                For i As Integer = 1 To reader.NumberOfPages

                    'Dim fs As New FileStream(destino, FileMode.Create, FileAccess.Write, FileShare.None)
                    'Dim stamper As PdfStamper = New PdfStamper(reader, fs)
                    Dim page = writer.GetImportedPage(reader, i)
                    'Dim rect As iTextSharp.text.Rectangle = reader.GetPageSize(i)
                    'Dim cb As PdfContentByte = stamper.GetOverContent(i)

                    'Dim footer As New iTextSharp.text.Phrase("Página " & i.ToString)
                    'ColumnText.ShowTextAligned(cb, PdfContentByte.ALIGN_CENTER, footer, rect.Right() - 40, rect.Bottom + 10, 0)
                    'cb.EndLayer()
                    writer.AddPage(page)

                    'fs.Close()
                    'stamper.Close()

                Next

                reader.Dispose()

            Next

            writer.Dispose()
            document.Dispose()

            Dim nuevoFchero As String = EliminarCapas(outFile, "outfile2.pdf")
            File.Delete(outFile)
            File.Move("outfile2.pdf", outFile)

            Dim reader2 = New iTextSharp.text.pdf.PdfReader(outFile)



            Using fs As New FileStream("mipdf.pdf", FileMode.Create, FileAccess.Write, FileShare.None)



                Using stamper As New PdfStamper(reader2, fs)

                    For i As Integer = 1 To reader2.NumberOfPages
                        Dim layer As PdfLayer = New PdfLayer("pages", stamper.Writer)
                        Dim rect As iTextSharp.text.Rectangle = reader2.GetPageSize(i)
                        Dim cb As PdfContentByte = stamper.GetOverContent(i)
                        cb.BeginLayer(layer)

                        Dim footer As New iTextSharp.text.Phrase("Página " & i.ToString)
                        ColumnText.ShowTextAligned(cb, PdfContentByte.ALIGN_CENTER, footer, rect.Right() - 40, rect.Bottom + 10, 0)

                        cb.EndLayer()
                    Next



                End Using

            End Using

            reader2.Dispose()
            If File.Exists(outFile) Then
                File.Delete(outFile)
                File.Move("mipdf.pdf", outFile)
            Else
                MsgBox("Ojito")
            End If

        Catch ex As Exception
            MsgBox(ex.Message)

        Finally

            writer.Dispose()
            document.Dispose()

        End Try

    End Sub

    Public Sub unzipFile(rutaog As String, rutaDest As String)
        Dim fileToUnzip As String = rutaog
        Dim destDir As String = rutaDest
        Using zip1 As ZipFile = Ionic.Zip.ZipFile.Read(fileToUnzip)
            Dim e As ZipEntry
            For Each e In zip1
                e.Extract(rutaDest, ExtractExistingFileAction.OverwriteSilently)
            Next
        End Using

    End Sub
    Public Sub zipfile(file As String, destPath As String, name As String)
        Using zip As New ZipFile


            If System.IO.File.Exists(file) Then
                Try
                    zip.AddFile(file)
                    zip.Save(Path.Combine(destPath, name & ".zip"))
                Catch ex As Exception

                End Try

            ElseIf System.IO.Directory.Exists(file) Then
                Try
                    zip.AddDirectory(file)
                    zip.Save(Path.Combine(destPath, name & ".zip"))
                Catch ex As Exception

                End Try
            End If


        End Using
    End Sub

    Public Sub addPass(inputFile As String, outputFile As String, readPass As String, writePass As String)


        Using input As Stream = New FileStream(inputFile, FileMode.Open, FileAccess.Read, FileShare.Read)
            Using output As Stream = New FileStream(outputFile, FileMode.Create, FileAccess.Write, FileShare.None)
                Dim reader As iTextSharp.text.pdf.PdfReader = New iTextSharp.text.pdf.PdfReader(input)
                PdfEncryptor.Encrypt(reader, output, True, readPass, writePass, PdfWriter.ALLOW_SCREENREADERS)
            End Using
        End Using
    End Sub



    Public Sub readMetadataPdf(inputFile As String)
        Try
            Dim reader As New iTextSharp.text.pdf.PdfReader(inputFile)

            If reader.Info.ContainsKey("Author") Then
                Dim autor As String = reader.Info("Author")
                PDFProperties.txt_author.Text = autor
            End If

            If reader.Info.ContainsKey("Title") Then
                Dim titulo As String = reader.Info("Title")
                PDFProperties.txt_title.Text = titulo
            End If

            If reader.Info.ContainsKey("Subject") Then
                Dim asunto As String = reader.Info("Subject")
                PDFProperties.txt_subject.Text = asunto
            End If

            If reader.Info.ContainsKey("Keywords") Then
                Dim keywords As String = reader.Info("Keywords")
                PDFProperties.txt_keywords.Text = keywords
            End If

            PDFProperties.txt_name.Text = Path.GetFileNameWithoutExtension(inputFile)
            PDFProperties.Show()
        Catch ex As Exception
            MessageBox.Show("El documento no contiene metadatos")
        End Try
    End Sub












End Module
