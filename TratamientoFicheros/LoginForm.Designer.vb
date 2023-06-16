<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LoginForm
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
        Me.txt_username = New System.Windows.Forms.TextBox()
        Me.txt_password = New System.Windows.Forms.TextBox()
        Me.lbl_username = New System.Windows.Forms.Label()
        Me.lbl_password = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.btn_login = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_username
        '
        Me.txt_username.Location = New System.Drawing.Point(85, 301)
        Me.txt_username.Name = "txt_username"
        Me.txt_username.Size = New System.Drawing.Size(174, 27)
        Me.txt_username.TabIndex = 0
        '
        'txt_password
        '
        Me.txt_password.Location = New System.Drawing.Point(85, 354)
        Me.txt_password.Name = "txt_password"
        Me.txt_password.Size = New System.Drawing.Size(174, 27)
        Me.txt_password.TabIndex = 1
        Me.txt_password.UseSystemPasswordChar = True
        '
        'lbl_username
        '
        Me.lbl_username.AutoSize = True
        Me.lbl_username.BackColor = System.Drawing.Color.Transparent
        Me.lbl_username.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_username.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.lbl_username.Location = New System.Drawing.Point(196, 278)
        Me.lbl_username.Name = "lbl_username"
        Me.lbl_username.Size = New System.Drawing.Size(63, 20)
        Me.lbl_username.TabIndex = 3
        Me.lbl_username.Text = "Usuario"
        '
        'lbl_password
        '
        Me.lbl_password.AutoSize = True
        Me.lbl_password.BackColor = System.Drawing.Color.Transparent
        Me.lbl_password.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_password.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.lbl_password.Location = New System.Drawing.Point(171, 331)
        Me.lbl_password.Name = "lbl_password"
        Me.lbl_password.Size = New System.Drawing.Size(88, 20)
        Me.lbl_password.TabIndex = 1
        Me.lbl_password.Text = "Contraseña"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.TratamientoFicheros.My.Resources.Resources.carpeta1
        Me.PictureBox1.Location = New System.Drawing.Point(95, 45)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(153, 127)
        Me.PictureBox1.TabIndex = 2
        Me.PictureBox1.TabStop = False
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.Color.Transparent
        Me.lbl_title.Font = New System.Drawing.Font("Segoe UI Black", 42.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_title.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.lbl_title.Location = New System.Drawing.Point(82, 156)
        Me.lbl_title.Margin = New System.Windows.Forms.Padding(0)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(185, 74)
        Me.lbl_title.TabIndex = 1
        Me.lbl_title.Text = "Login"
        '
        'btn_login
        '
        Me.btn_login.FlatAppearance.BorderSize = 0
        Me.btn_login.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_login.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_login.Location = New System.Drawing.Point(85, 387)
        Me.btn_login.Name = "btn_login"
        Me.btn_login.Size = New System.Drawing.Size(85, 29)
        Me.btn_login.TabIndex = 3
        Me.btn_login.TabStop = False
        Me.btn_login.Text = "Log in"
        Me.btn_login.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.Transparent
        Me.btn_close.BackgroundImage = Global.TratamientoFicheros.My.Resources.Resources.icons8_eliminar_32
        Me.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.ForeColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.btn_close.Location = New System.Drawing.Point(311, 12)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(25, 25)
        Me.btn_close.TabIndex = 2
        Me.btn_close.TabStop = False
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'LoginForm
        '
        Me.AcceptButton = Me.btn_login
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(233, Byte), Integer), CType(CType(196, Byte), Integer), CType(CType(106, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(348, 438)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_login)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.lbl_password)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.lbl_username)
        Me.Controls.Add(Me.txt_password)
        Me.Controls.Add(Me.txt_username)
        Me.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "LoginForm"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds
        Me.Text = "LoginForm"
        Me.TopMost = True
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_username As System.Windows.Forms.TextBox
    Friend WithEvents txt_password As System.Windows.Forms.TextBox
    Friend WithEvents lbl_username As System.Windows.Forms.Label
    Friend WithEvents lbl_password As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lbl_title As System.Windows.Forms.Label
    Friend WithEvents btn_login As System.Windows.Forms.Button
    Friend WithEvents btn_close As System.Windows.Forms.Button
End Class
