Imports System.Data.SqlClient
Imports System.IO




Public Class DB_Controller
    Public conexion As New SqlConnection("Data Source=localhost\SQLEXPRESS; Initial Catalog=FileManager; Integrated Security=True;")

    Public Function login(username As String, pwd As String) As Boolean
        Dim sql As String
        Dim sqlGroup As String
        Dim command As New SqlCommand

        sql = "SELECT ID_user FROM Users WHERE username = '" & username & "' AND password = '" & pwd & "'"
        command.Connection = conexion
        command.CommandText = sql


        Try
            Dim resultado As Object
            command.Connection.Open()
            resultado = command.ExecuteScalar()
            If resultado IsNot Nothing Then
                idUsuario = resultado
                usuario = username
                password = pwd
                MsgBox("Bienvenido, " & usuario & " con id: " & idUsuario & ".")
                isLogin = True
                Form1.lbl_login.Text = usuario
                Form1.btn_logInOut.Text = "Log out"
                materialBtn(Form1.btn_logInOut, "rojo")
                Form1.grp_credentials.Visible = True
                Form1.panel_premiumBtns.Visible = True
                Form1.panel_login.Visible = False

                sqlGroup = "SELECT nombre FROM Grupos g INNER JOIN Users u ON u.ID_grupo = g.ID_grupo  WHERE username = '" & username & "'"
                command.CommandText = sqlGroup
                grupoLogin = command.ExecuteScalar



                Return True


            Else
                MsgBox("Los datos son incorrectos.")
                Return False

            End If
            sqlGroup = "SELECT nombre FROM Grupos g INNER JOIN Users u ON u.ID_grupo = g.ID_grupo  WHERE username = '" & username & "'"
            command.CommandText = sqlGroup
            grupoLogin = command.ExecuteScalar
        Catch ex As Exception
            MsgBox("Error al comprobar credenciales: " & vbCrLf & ex.Message)
            Return False
        Finally
            command.Connection.Close()

        End Try

    End Function



    Public Sub actualizaChat(destinatario As String, txt_mensajes As RichTextBox)
        Dim sql As String = "SELECT * FROM Mensajes_chat WHERE ((remitente = '" & usuario & "' AND destinatario = '" & destinatario.Trim & "') OR (remitente = '" & destinatario.Trim & "' AND destinatario = '" & usuario & "')) ORDER BY fecha, hora"
        Dim command As New SqlCommand

        command.CommandText = sql
        command.Connection = miClase.conexion

        txt_mensajes.Clear()

        Try
            command.Connection.Open()
            Dim drMensajes As SqlDataReader = command.ExecuteReader()
            While drMensajes.Read()


                Dim remitente As String = drMensajes("remitente").ToString()
                Dim mensaje As String = drMensajes("mensaje").ToString()
                Dim fecha As String = drMensajes("fecha").ToString()
                Dim hora As String = drMensajes("hora").ToString
                Dim esRemitente As Boolean = (remitente = usuario)
                Dim padding As Integer = 50 ' Ajusta el valor según tus necesidades
                Dim paddedMensaje As String = String.Format("{0,-" & padding & "}", mensaje)
                Dim paddedHora As String = String.Format("{0,-" & padding & "}", hora)

                If esRemitente Then
                    With txt_mensajes
                        .SelectionAlignment = HorizontalAlignment.Right
                        .ForeColor = Color.FromArgb(161, 217, 145)
                        .AppendText(Environment.NewLine)
                        .SelectionFont = New Font("segoe ui", 10, FontStyle.Regular)
                        .AppendText(paddedMensaje)
                        .AppendText(Environment.NewLine)
                        .SelectionColor = Color.FromArgb(129, 166, 162)
                        .SelectionFont = New Font("Courier New", 8, FontStyle.Italic)
                        .AppendText(paddedHora)
                        .AppendText(Environment.NewLine)
                        .AppendText(Environment.NewLine)
                    End With
                Else
                    With txt_mensajes
                        .SelectionAlignment = HorizontalAlignment.Left
                        .SelectionColor = Color.White
                        .SelectionFont = New Font("segoe ui", 10, FontStyle.Regular)
                        .AppendText(paddedMensaje)
                        .AppendText(Environment.NewLine)
                        .SelectionColor = Color.LightGray
                        .SelectionFont = New Font("Courier New", 8, FontStyle.Italic)
                        .AppendText(paddedHora)
                        .AppendText(Environment.NewLine)
                        .AppendText(Environment.NewLine)
                    End With
                End If
            End While
            drMensajes.Close()
            txt_mensajes.SelectionStart = txt_mensajes.Text.Length
            txt_mensajes.ScrollToCaret()
            command.Connection.Close()

        Catch ex As Exception
            command.Connection.Close()
            MsgBox("Error al obtener la conversación: " & vbCrLf & ex.Message)
        Finally
            command.Connection.Close()
        End Try

    End Sub





    'Public Sub listarUsuarios(listbox As ListBox)
    '    listbox.Items.Clear()
    '    Dim sql = "SELECT DISTINCT username FROM Users WHERE username <> '" & usuario & "'"
    '    Dim command As New SqlCommand
    '    command.Connection = conexion
    '    command.CommandText = sql
    '    Try
    '        command.Connection.Open()
    '        Dim drUsuarios As SqlDataReader = command.ExecuteReader()
    '        While drUsuarios.Read()
    '            listbox.Items.Add("  " & drUsuarios("username"))
    '        End While
    '        drUsuarios.Close()
    '        command.Connection.Close()
    '    Catch ex As Exception
    '        command.Connection.Close()
    '        MsgBox("Error al listar usuarios: " & vbCrLf & ex.Message)
    '    End Try
    'End Sub
    Public Sub fillList(listbox As ListBox, sql As String, columna As String)
        listbox.Items.Clear()

        Dim command As New SqlCommand
        command.Connection = conexion
        command.CommandText = sql
        Try
            command.Connection.Open()
            Dim drLista As SqlDataReader = command.ExecuteReader()
            While drLista.Read()
                listbox.Items.Add("  " & drLista(columna))
            End While
            drLista.Close()
            command.Connection.Close()
        Catch ex As Exception
            command.Connection.Close()
            MsgBox("Error al listar usuarios: " & vbCrLf & ex.Message)
        End Try
    End Sub

    'Public Sub listarUsuarios(panel As Panel)
    '    panel.Controls.Clear()
    '    Dim sql = "SELECT DISTINCT username FROM Users WHERE username <> '" & usuario & "'"
    '    Dim command As New SqlCommand
    '    command.Connection = conexion
    '    command.CommandText = sql
    '    Try
    '        command.Connection.Open()
    '        Dim drUsuarios As SqlDataReader = command.ExecuteReader()
    '        Dim yPos As Integer = 0 ' Variable para controlar la posición vertical de los paneles
    '        Dim color1 As Color = Color.FromArgb(42, 157, 143)
    '        Dim color2 As Color = Color.FromArgb(22, 137, 123)
    '        Dim currentColor As Color = color1
    '        While drUsuarios.Read()
    '            Dim panelUsuario As New Panel()
    '            panelUsuario.Height = 50
    '            panelUsuario.Width = 10000
    '            panelUsuario.Location = New Point(0, yPos)
    '            ' Establece la posición del panel en el panel principal
    '            panelUsuario.Tag = drUsuarios("username").ToString()

    '            Dim avatar As New PictureBox()
    '            avatar.BackgroundImage = Image.FromFile("C:\icons\profile_48x49_white.png")
    '            avatar.Size = New Size(48, 48)

    '            Dim label As New Label()
    '            label.Font = New Font("segoe ui", 12, FontStyle.Bold)
    '            label.Text = vbTab & drUsuarios("username").ToString()
    '            label.AutoSize = True
    '            label.Location = New Point(50, 12)
    '            label.ForeColor = Color.White ' Establece la posición del label dentro del panel






    '            panelUsuario.Controls.Add(avatar)
    '            panelUsuario.Controls.Add(label)


    '            panelUsuario.BackColor = currentColor

    '            panel.Controls.Add(panelUsuario)

    '            yPos += panelUsuario.Height + 0.1 ' Incrementa la posición vertical para el próximo panel
    '            If currentColor = color1 Then
    '                currentColor = color2
    '            Else
    '                currentColor = color1
    '            End If
    '        End While
    '        drUsuarios.Close()
    '        command.Connection.Close()
    '    Catch ex As Exception
    '        command.Connection.Close()
    '        MsgBox("Error al listar usuarios: " & vbCrLf & ex.Message)
    '    End Try
    'End Sub

    'Private Sub panel_Click(sender As Object, e As EventArgs)
    '    Dim panel As Panel = CType(sender, Panel)
    '    Dim destinatario As String = panel.Tag.ToString()
    '    actualizaChat(destinatario, Tareas.txt_mensajes, Tareas.lbl_destinatario) ' Obtiene el texto del label del panel
    '    ' Realiza las operaciones que desees con el username
    'End Sub





    Public Sub enviaMensaje(mensaje As TextBox, destinatario As String, mensajes As RichTextBox)
        Dim sql As String
        Dim command As New SqlCommand
        sql = "INSERT INTO Mensajes_chat (remitente, destinatario, mensaje, fecha, hora)" _
            & "VALUES ('" & usuario & "', '" & destinatario & "', '" & mensaje.Text & "', '" & DateTime.Now.ToString("yyyy-MM-dd") & "', '" & DateTime.Now.ToString("HH:mm") & "')"
        command.Connection = conexion
        command.CommandText = sql

        Try
            command.Connection.Open()
            command.ExecuteNonQuery()
            command.Connection.Close()
            mensaje.Clear()
            actualizaChat(destinatario, mensajes)
        Catch ex As Exception
            command.Connection.Close()
            MsgBox("Error al introducir el registro del mensaje: " & vbCrLf & ex.Message)
        End Try
    End Sub

    Public Sub checkState(nombreTarea As String, lblEstado As Label)
        Dim sql As String
        Dim command As New SqlCommand
        Dim estado As Integer

        sql = "SELECT et.ID_estado_tarea FROM Estados_tareas et " _
            & "INNER JOIN Tareas t ON t.ID_estado_tarea = et.ID_estado_tarea " _
            & "WHERE t.nombre = '" & nombreTarea & "'"

        Try
            command.CommandText = sql
            command.Connection = conexion
            command.Connection.Open()
            estado = command.ExecuteScalar

            Select Case estado
                Case 1
                    lblEstado.Text() = ""
                    lblEstado.BackgroundImage = Image.FromFile("C:\icons\done_48_colored.png")

                Case 2
                    lblEstado.Text = ""
                    lblEstado.BackgroundImage = Image.FromFile("C:\icons\loading_48_colored.png")

                Case 3
                    lblEstado.Text = ""
                    lblEstado.BackgroundImage = Image.FromFile("C:\icons\cancelled_48_colored.png")
            End Select

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            command.Connection.Close()
        End Try
    End Sub

    Public Sub fillComboboxAvanzado(combobox As ComboBox, sql As String, columna As String)
        Dim command As New SqlCommand
        Dim dr As SqlDataReader

        command.Connection = conexion
        command.CommandText = sql

        Try
            command.Connection.Open()
            dr = command.ExecuteReader
            combobox.Items.Add("*")
            While dr.Read
                combobox.Items.Add(dr(columna).ToString())
            End While
            command.Connection.Close()

        Catch ex As Exception
            MsgBox("No se ha podido realizar la lectura de datos: " & vbCrLf & ex.Message)
            command.Connection.Close()
        End Try
    End Sub

    Public Sub addData(sql As String)
        Dim command As New SqlCommand

        command.Connection = conexion
        command.CommandText = sql

        Try
            command.Connection.Open()
            command.ExecuteNonQuery()
            command.Connection.Close()
            MsgBox("Los datos se han introducido correctamente")

        Catch ex As Exception
            MsgBox("Los datos no se han podido introducir " & vbCrLf & ex.Message)
            command.Connection.Close()
        End Try

    End Sub
    Public Sub addTask(nombreTarea As String, descripcionTarea As String, nombreLista As String, nombreGrupo As String)
        Dim command As New SqlCommand

        command.Connection = conexion
        command.CommandText = "sp_InsertarTarea"
        command.CommandType = CommandType.StoredProcedure

        command.Parameters.AddWithValue("@nombre_tarea", nombreTarea)
        command.Parameters.AddWithValue("@descripcion_tarea", descripcionTarea)
        command.Parameters.AddWithValue("@nombre_lista", nombreLista)
        command.Parameters.AddWithValue("@nombre_grupo", nombreGrupo)
        Try
            command.Connection.Open()
            command.ExecuteNonQuery()

            MsgBox("Tarea añadida correctamente.")
        Catch ex As Exception
            MsgBox("Error al añadir tarea: " & vbCrLf & ex.Message)
        Finally
            command.Connection.Close()
        End Try

    End Sub
    Public Sub updateData(sql As String)
        Dim command As New SqlCommand

        Try
            command.Connection = conexion
            command.CommandText = sql
            command.Connection.Open()
            command.ExecuteNonQuery()

        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
            command.Connection.Close()
        End Try

    End Sub












End Class
