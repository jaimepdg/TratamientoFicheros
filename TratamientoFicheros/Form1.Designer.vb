<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.panel_premiumBtns = New System.Windows.Forms.Panel()
        Me.btn_listas = New System.Windows.Forms.Button()
        Me.btn_dual = New System.Windows.Forms.Button()
        Me.btn_chat = New System.Windows.Forms.Button()
        Me.btn_logInOut = New System.Windows.Forms.Button()
        Me.btn_home = New System.Windows.Forms.Button()
        Me.grp_credentials = New System.Windows.Forms.Panel()
        Me.lbl_login = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_formatFiles = New System.Windows.Forms.Button()
        Me.btn_analizarLotes = New System.Windows.Forms.Button()
        Me.btn_ficheros = New System.Windows.Forms.Button()
        Me.btn_directorios = New System.Windows.Forms.Button()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_minimize = New System.Windows.Forms.Button()
        Me.btn_maximize = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.panel_login = New System.Windows.Forms.Panel()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.panel_premiumBtns.SuspendLayout()
        Me.grp_credentials.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.SplitContainer1.Panel1.Controls.Add(Me.panel_premiumBtns)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_dual)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_logInOut)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_home)
        Me.SplitContainer1.Panel1.Controls.Add(Me.grp_credentials)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_formatFiles)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_analizarLotes)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_ficheros)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_directorios)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(932, 466)
        Me.SplitContainer1.SplitterDistance = 125
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 2
        '
        'panel_premiumBtns
        '
        Me.panel_premiumBtns.Controls.Add(Me.btn_listas)
        Me.panel_premiumBtns.Controls.Add(Me.btn_chat)
        Me.panel_premiumBtns.Location = New System.Drawing.Point(0, 255)
        Me.panel_premiumBtns.Name = "panel_premiumBtns"
        Me.panel_premiumBtns.Size = New System.Drawing.Size(127, 125)
        Me.panel_premiumBtns.TabIndex = 7
        '
        'btn_listas
        '
        Me.btn_listas.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_listas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_listas.Location = New System.Drawing.Point(-7, 42)
        Me.btn_listas.Name = "btn_listas"
        Me.btn_listas.Size = New System.Drawing.Size(134, 42)
        Me.btn_listas.TabIndex = 2
        Me.btn_listas.Text = "Tareas"
        Me.btn_listas.UseVisualStyleBackColor = True
        '
        'btn_dual
        '
        Me.btn_dual.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_dual.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_dual.Location = New System.Drawing.Point(-7, 0)
        Me.btn_dual.Name = "btn_dual"
        Me.btn_dual.Size = New System.Drawing.Size(134, 42)
        Me.btn_dual.TabIndex = 2
        Me.btn_dual.Text = "Dual"
        Me.btn_dual.UseVisualStyleBackColor = True
        '
        'btn_chat
        '
        Me.btn_chat.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_chat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_chat.Location = New System.Drawing.Point(-7, 85)
        Me.btn_chat.Name = "btn_chat"
        Me.btn_chat.Size = New System.Drawing.Size(134, 42)
        Me.btn_chat.TabIndex = 2
        Me.btn_chat.Text = "Chat"
        Me.btn_chat.UseVisualStyleBackColor = True
        '
        'btn_logInOut
        '
        Me.btn_logInOut.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_logInOut.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btn_logInOut.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(231, Byte), Integer), CType(CType(111, Byte), Integer), CType(CType(81, Byte), Integer))
        Me.btn_logInOut.Location = New System.Drawing.Point(-4, 425)
        Me.btn_logInOut.Name = "btn_logInOut"
        Me.btn_logInOut.Size = New System.Drawing.Size(87, 41)
        Me.btn_logInOut.TabIndex = 2
        Me.btn_logInOut.Text = "Log in"
        Me.btn_logInOut.UseVisualStyleBackColor = True
        '
        'btn_home
        '
        Me.btn_home.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_home.BackgroundImage = Global.TratamientoFicheros.My.Resources.Resources.home_solid_white
        Me.btn_home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.btn_home.Location = New System.Drawing.Point(76, 425)
        Me.btn_home.Name = "btn_home"
        Me.btn_home.Size = New System.Drawing.Size(54, 41)
        Me.btn_home.TabIndex = 2
        Me.btn_home.UseVisualStyleBackColor = True
        '
        'grp_credentials
        '
        Me.grp_credentials.BackColor = System.Drawing.Color.FromArgb(CType(CType(18, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(63, Byte), Integer))
        Me.grp_credentials.Controls.Add(Me.lbl_login)
        Me.grp_credentials.Controls.Add(Me.PictureBox1)
        Me.grp_credentials.Location = New System.Drawing.Point(0, 376)
        Me.grp_credentials.Name = "grp_credentials"
        Me.grp_credentials.Size = New System.Drawing.Size(130, 57)
        Me.grp_credentials.TabIndex = 6
        '
        'lbl_login
        '
        Me.lbl_login.AutoSize = True
        Me.lbl_login.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_login.ForeColor = System.Drawing.Color.White
        Me.lbl_login.Location = New System.Drawing.Point(48, 16)
        Me.lbl_login.Name = "lbl_login"
        Me.lbl_login.Size = New System.Drawing.Size(74, 19)
        Me.lbl_login.TabIndex = 3
        Me.lbl_login.Text = "username"
        Me.lbl_login.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TratamientoFicheros.My.Resources.Resources.profile_48x49_white
        Me.PictureBox1.Location = New System.Drawing.Point(8, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(34, 34)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'btn_formatFiles
        '
        Me.btn_formatFiles.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_formatFiles.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_formatFiles.Location = New System.Drawing.Point(-7, 171)
        Me.btn_formatFiles.Name = "btn_formatFiles"
        Me.btn_formatFiles.Size = New System.Drawing.Size(134, 42)
        Me.btn_formatFiles.TabIndex = 1
        Me.btn_formatFiles.Text = "Formatear ficheros"
        Me.btn_formatFiles.UseVisualStyleBackColor = True
        Me.btn_formatFiles.Visible = False
        '
        'btn_analizarLotes
        '
        Me.btn_analizarLotes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_analizarLotes.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_analizarLotes.Location = New System.Drawing.Point(-7, 128)
        Me.btn_analizarLotes.Name = "btn_analizarLotes"
        Me.btn_analizarLotes.Size = New System.Drawing.Size(134, 42)
        Me.btn_analizarLotes.TabIndex = 1
        Me.btn_analizarLotes.Text = "Analizar lotes"
        Me.btn_analizarLotes.UseVisualStyleBackColor = True
        Me.btn_analizarLotes.Visible = False
        '
        'btn_ficheros
        '
        Me.btn_ficheros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_ficheros.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ficheros.Location = New System.Drawing.Point(-7, 85)
        Me.btn_ficheros.Name = "btn_ficheros"
        Me.btn_ficheros.Size = New System.Drawing.Size(134, 42)
        Me.btn_ficheros.TabIndex = 1
        Me.btn_ficheros.Text = "Lista de ficheros"
        Me.btn_ficheros.UseVisualStyleBackColor = True
        Me.btn_ficheros.Visible = False
        '
        'btn_directorios
        '
        Me.btn_directorios.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_directorios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_directorios.Location = New System.Drawing.Point(-7, 42)
        Me.btn_directorios.Name = "btn_directorios"
        Me.btn_directorios.Size = New System.Drawing.Size(134, 42)
        Me.btn_directorios.TabIndex = 1
        Me.btn_directorios.Text = "Explorar directorio"
        Me.btn_directorios.UseVisualStyleBackColor = True
        Me.btn_directorios.Visible = False
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1
        Me.SplitContainer2.IsSplitterFixed = True
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.panel_login)
        Me.SplitContainer2.Size = New System.Drawing.Size(806, 466)
        Me.SplitContainer2.SplitterDistance = 32
        Me.SplitContainer2.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(57, Byte), Integer), CType(CType(89, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.Panel1.Controls.Add(Me.PictureBox2)
        Me.Panel1.Controls.Add(Me.lbl_title)
        Me.Panel1.Controls.Add(Me.btn_minimize)
        Me.Panel1.Controls.Add(Me.btn_maximize)
        Me.Panel1.Controls.Add(Me.btn_close)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(806, 32)
        Me.Panel1.TabIndex = 4
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = Global.TratamientoFicheros.My.Resources.Resources.carpeta1
        Me.PictureBox2.Location = New System.Drawing.Point(4, 7)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(30, 20)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox2.TabIndex = 2
        Me.PictureBox2.TabStop = False
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.White
        Me.lbl_title.Location = New System.Drawing.Point(32, 10)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(30, 15)
        Me.lbl_title.TabIndex = 1
        Me.lbl_title.Text = "title"
        '
        'btn_minimize
        '
        Me.btn_minimize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_minimize.BackgroundImage = Global.TratamientoFicheros.My.Resources.Resources.minimize_32x32_white
        Me.btn_minimize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_minimize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_minimize.FlatAppearance.BorderSize = 0
        Me.btn_minimize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_minimize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_minimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_minimize.Location = New System.Drawing.Point(712, 7)
        Me.btn_minimize.Name = "btn_minimize"
        Me.btn_minimize.Size = New System.Drawing.Size(22, 22)
        Me.btn_minimize.TabIndex = 0
        Me.btn_minimize.UseVisualStyleBackColor = True
        '
        'btn_maximize
        '
        Me.btn_maximize.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_maximize.BackgroundImage = Global.TratamientoFicheros.My.Resources.Resources.maximize_32x32_white
        Me.btn_maximize.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_maximize.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_maximize.FlatAppearance.BorderSize = 0
        Me.btn_maximize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_maximize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_maximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_maximize.Location = New System.Drawing.Point(745, 5)
        Me.btn_maximize.Name = "btn_maximize"
        Me.btn_maximize.Size = New System.Drawing.Size(22, 22)
        Me.btn_maximize.TabIndex = 0
        Me.btn_maximize.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_close.BackgroundImage = Global.TratamientoFicheros.My.Resources.Resources.icons8_eliminar_32
        Me.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close.FlatAppearance.BorderSize = 0
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.Location = New System.Drawing.Point(779, 5)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(22, 22)
        Me.btn_close.TabIndex = 0
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'panel_login
        '
        Me.panel_login.BackColor = System.Drawing.Color.Transparent
        Me.panel_login.Location = New System.Drawing.Point(0, -1)
        Me.panel_login.Name = "panel_login"
        Me.panel_login.Size = New System.Drawing.Size(348, 438)
        Me.panel_login.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(932, 466)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.panel_premiumBtns.ResumeLayout(False)
        Me.grp_credentials.ResumeLayout(False)
        Me.grp_credentials.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btn_directorios As System.Windows.Forms.Button
    Friend WithEvents btn_ficheros As System.Windows.Forms.Button
    Friend WithEvents btn_home As System.Windows.Forms.Button
    Friend WithEvents btn_logInOut As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_minimize As System.Windows.Forms.Button
    Friend WithEvents btn_maximize As System.Windows.Forms.Button
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents lbl_title As System.Windows.Forms.Label
    Friend WithEvents btn_analizarLotes As System.Windows.Forms.Button
    Friend WithEvents btn_formatFiles As System.Windows.Forms.Button
    Friend WithEvents lbl_login As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents grp_credentials As System.Windows.Forms.Panel
    Friend WithEvents panel_premiumBtns As System.Windows.Forms.Panel
    Friend WithEvents btn_chat As System.Windows.Forms.Button
    Friend WithEvents panel_login As System.Windows.Forms.Panel
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_listas As System.Windows.Forms.Button
    Friend WithEvents btn_dual As System.Windows.Forms.Button

End Class
