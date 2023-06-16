Public Class Form1
    Dim Ficheros As New Ficheros
    Dim Directorios As New RutaDirectorios
    Dim Lotes As New Lotes
    Dim FormatFiles As New FormatFiles
    Dim Chat As New Chat
    Dim menuTareas As New MenuTareas
    Private Declare Function ReleaseCapture Lib "user32" () As Integer
    Private Declare Function SendMessage Lib "user32" Alias "SendMessageA" (ByVal hwnd As IntPtr, ByVal wMsg As Integer, ByVal wParam As Integer, ByVal lParam As Integer) As Integer
    Private Const WM_NCLBUTTONDOWN As Integer = &HA1
    Private Const HT_CAPTION As Integer = &H2




    Private Sub Form1_Load(sender As Object, e As System.EventArgs) Handles Me.Load
        materialBtn(btn_directorios, "normal")
        materialBtn(btn_ficheros, "normal")
        materialBtn(btn_analizarLotes, "normal")
        materialBtn(btn_formatFiles, "normal")
        materialBtn(btn_chat, "premium")
        materialBtn(btn_listas, "premium")
        materialBtn(btn_dual, "normal")
        materialBtn(btn_logInOut, "verde")
        materialBtn(btn_home, "amarillo")


        Home.TopLevel = False
        Home.FormBorderStyle = FormBorderStyle.None
        Home.Dock = DockStyle.Fill
        SplitContainer2.Panel2.Controls.Add(Home)
        Home.Show()
        lbl_title.Text = ""
        grp_credentials.Visible = False
        panel_premiumBtns.Visible = False
        panel_login.Visible = False
        lbl_title.Text = "Home"
    End Sub

    Private Sub DirectoriosToolStripMenuItem_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub SplitContainer1_Panel2_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer1.Panel2.Paint

    End Sub

    Private Sub btn_directorios_Click(sender As System.Object, e As System.EventArgs) Handles btn_directorios.Click
        Directorios.TopLevel = False
        Directorios.FormBorderStyle = FormBorderStyle.None
        Directorios.Dock = DockStyle.Fill
        SplitContainer2.Panel2.Controls.Add(Directorios)
        Directorios.Show()
        Directorios.BringToFront()
        lbl_title.Text = "Rutas de Directorios"

    End Sub

    Private Sub btn_ficheros_Click(sender As System.Object, e As System.EventArgs) Handles btn_ficheros.Click
        Ficheros.TopLevel = False
        Ficheros.FormBorderStyle = FormBorderStyle.None
        Ficheros.Dock = DockStyle.Fill
        SplitContainer2.Panel2.Controls.Add(Ficheros)
        Ficheros.Show()
        Ficheros.BringToFront()
        lbl_title.Text = "Lista de Ficheros"
    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs) Handles btn_close.Click
        Me.Close()
    End Sub

    Private Sub btn_maximize_Click(sender As System.Object, e As System.EventArgs) Handles btn_maximize.Click
        If Me.WindowState = FormWindowState.Maximized Then
            Me.WindowState = FormWindowState.Normal
        Else
            Me.WindowState = FormWindowState.Maximized
        End If
    End Sub

    Private Sub btn_minimize_Click(sender As System.Object, e As System.EventArgs) Handles btn_minimize.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub Panel1_MouseDown(sender As Object, e As System.Windows.Forms.MouseEventArgs) Handles Panel1.MouseDown
        If e.Button = MouseButtons.Left Then
            ReleaseCapture()
            SendMessage(Me.Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0)
        End If
    End Sub


    Private Sub SplitContainer2_Panel2_Paint(sender As System.Object, e As System.Windows.Forms.PaintEventArgs) Handles SplitContainer2.Panel2.Paint

    End Sub

    Private Sub btn_home_Click(sender As System.Object, e As System.EventArgs) Handles btn_home.Click
        Home.Show()
        Home.BringToFront()
        lbl_title.Text = "Home"
    End Sub

    Private Sub btn_close_MouseEnter(sender As Object, e As System.EventArgs) Handles btn_close.MouseEnter
        btn_close.BackColor = Color.FromArgb(231, 111, 81)
    End Sub

    Private Sub btn_close_MouseLeave(sender As Object, e As System.EventArgs) Handles btn_close.MouseLeave
        btn_close.BackColor = Color.Transparent
    End Sub

    Private Sub btn_analizarLotes_Click(sender As System.Object, e As System.EventArgs) Handles btn_analizarLotes.Click
        Lotes.TopLevel = False
        Lotes.FormBorderStyle = FormBorderStyle.None
        Lotes.Dock = DockStyle.Fill
        SplitContainer2.Panel2.Controls.Add(Lotes)
        Lotes.Show()
        Lotes.BringToFront()

        lbl_title.Text = "Vista por lotes"
    End Sub



    Private Sub btn_formatFiles_Click(sender As System.Object, e As System.EventArgs) Handles btn_formatFiles.Click
        FormatFiles.TopLevel = False
        FormatFiles.FormBorderStyle = FormBorderStyle.None
        FormatFiles.Dock = DockStyle.Fill
        SplitContainer2.Panel2.Controls.Add(FormatFiles)
        FormatFiles.Show()
        FormatFiles.BringToFront()
        lbl_title.Text = "Formatear pilas de archivos"
    End Sub

    Private Sub btn_logInOut_Click(sender As System.Object, e As System.EventArgs) Handles btn_logInOut.Click

        If isLogin = True Then
            isLogin = False
            usuario = ""
            password = ""
            MsgBox("Sesión cerrada correctamente.")
            Me.btn_logInOut.Text = "Log in"
            materialBtn(btn_logInOut, "verde")
            grp_credentials.Visible = False
            panel_premiumBtns.Visible = False
            Chat.Close()
            Chat.Hide()
            Tareas.Hide()
            menuTareas.Close()

        Else
            Dim loginform As New LoginForm ' Reemplaza "FormularioA" con el nombre de tu formulario

            ' Establecer el tamaño y posición del formulario dentro del panel
            loginform.TopLevel = False
            loginform.FormBorderStyle = FormBorderStyle.None
            loginform.Dock = DockStyle.Fill

            ' Agregar el formulario al panel
            panel_login.Controls.Add(loginform)

            ' Mostrar el formulario
            panel_login.Visible = True
            panel_login.BringToFront()
            loginform.Show()

        End If

    End Sub



    Private Sub btn_chat_Click(sender As System.Object, e As System.EventArgs) Handles btn_chat.Click
        Chat = New Chat
        Chat.TopLevel = False
        Chat.FormBorderStyle = FormBorderStyle.None
        Chat.Dock = DockStyle.Fill
        SplitContainer2.Panel2.Controls.Add(Chat)
        Chat.Show()
        Chat.BringToFront()
        menuTareas.Close()

        lbl_title.Text = "Chat"
    End Sub

    Private Sub btn_listas_Click(sender As System.Object, e As System.EventArgs) Handles btn_listas.Click
        menuTareas = New MenuTareas
        menuTareas.TopLevel = False
        menuTareas.FormBorderStyle = FormBorderStyle.None
        menuTareas.Dock = DockStyle.Fill
        SplitContainer2.Panel2.Controls.Add(menuTareas)
        menuTareas.Show()
        menuTareas.BringToFront()
        Chat.Close()

        lbl_title.Text = "Tus tareas"
    End Sub

    Private Sub Button1_Click_1(sender As System.Object, e As System.EventArgs) Handles btn_dual.Click
        Dual.Show()

    End Sub
End Class
