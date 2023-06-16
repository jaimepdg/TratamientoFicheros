<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Chat
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
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.lbl_userListTitle = New System.Windows.Forms.Label()
        Me.list_users = New System.Windows.Forms.ListBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.lbl_avatar = New System.Windows.Forms.Label()
        Me.lbl_destinatario = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.btn_actualizarChat = New System.Windows.Forms.Button()
        Me.btn_send = New System.Windows.Forms.Button()
        Me.txt_mensaje = New System.Windows.Forms.TextBox()
        Me.panel_msg = New System.Windows.Forms.Panel()
        Me.txt_mensajes = New System.Windows.Forms.RichTextBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel3.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.panel_msg.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.Panel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.SplitContainer1.Panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel3)
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.panel_msg)
        Me.SplitContainer1.Size = New System.Drawing.Size(790, 427)
        Me.SplitContainer1.SplitterDistance = 121
        Me.SplitContainer1.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.Panel1.Controls.Add(Me.lbl_userListTitle)
        Me.Panel1.Controls.Add(Me.list_users)
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(170, 427)
        Me.Panel1.TabIndex = 1
        '
        'lbl_userListTitle
        '
        Me.lbl_userListTitle.AutoSize = True
        Me.lbl_userListTitle.BackColor = System.Drawing.Color.Transparent
        Me.lbl_userListTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_userListTitle.ForeColor = System.Drawing.Color.White
        Me.lbl_userListTitle.Location = New System.Drawing.Point(3, 13)
        Me.lbl_userListTitle.Name = "lbl_userListTitle"
        Me.lbl_userListTitle.Size = New System.Drawing.Size(114, 32)
        Me.lbl_userListTitle.TabIndex = 1
        Me.lbl_userListTitle.Text = "Usuarios"
        '
        'list_users
        '
        Me.list_users.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.list_users.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.list_users.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.list_users.ForeColor = System.Drawing.Color.White
        Me.list_users.FormattingEnabled = True
        Me.list_users.ItemHeight = 21
        Me.list_users.Location = New System.Drawing.Point(0, 70)
        Me.list_users.Name = "list_users"
        Me.list_users.Size = New System.Drawing.Size(210, 357)
        Me.list_users.TabIndex = 0
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Panel3.Controls.Add(Me.lbl_avatar)
        Me.Panel3.Controls.Add(Me.lbl_destinatario)
        Me.Panel3.Location = New System.Drawing.Point(-1, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(943, 76)
        Me.Panel3.TabIndex = 1
        '
        'lbl_avatar
        '
        Me.lbl_avatar.BackColor = System.Drawing.Color.Transparent
        Me.lbl_avatar.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_avatar.ForeColor = System.Drawing.Color.White
        Me.lbl_avatar.Image = Global.TratamientoFicheros.My.Resources.Resources.profile_48x49_white
        Me.lbl_avatar.Location = New System.Drawing.Point(18, 13)
        Me.lbl_avatar.Name = "lbl_avatar"
        Me.lbl_avatar.Size = New System.Drawing.Size(48, 48)
        Me.lbl_avatar.TabIndex = 1
        '
        'lbl_destinatario
        '
        Me.lbl_destinatario.AutoSize = True
        Me.lbl_destinatario.BackColor = System.Drawing.Color.Transparent
        Me.lbl_destinatario.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_destinatario.ForeColor = System.Drawing.Color.White
        Me.lbl_destinatario.Location = New System.Drawing.Point(74, 22)
        Me.lbl_destinatario.Name = "lbl_destinatario"
        Me.lbl_destinatario.Size = New System.Drawing.Size(89, 32)
        Me.lbl_destinatario.TabIndex = 1
        Me.lbl_destinatario.Text = "Label1"
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.Panel2.Controls.Add(Me.btn_actualizarChat)
        Me.Panel2.Controls.Add(Me.btn_send)
        Me.Panel2.Controls.Add(Me.txt_mensaje)
        Me.Panel2.Location = New System.Drawing.Point(-1, 373)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(666, 54)
        Me.Panel2.TabIndex = 1
        '
        'btn_actualizarChat
        '
        Me.btn_actualizarChat.BackgroundImage = Global.TratamientoFicheros.My.Resources.Resources.refresh_white
        Me.btn_actualizarChat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_actualizarChat.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_actualizarChat.FlatAppearance.BorderSize = 0
        Me.btn_actualizarChat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_actualizarChat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_actualizarChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_actualizarChat.Location = New System.Drawing.Point(11, 10)
        Me.btn_actualizarChat.Name = "btn_actualizarChat"
        Me.btn_actualizarChat.Size = New System.Drawing.Size(32, 32)
        Me.btn_actualizarChat.TabIndex = 2
        Me.btn_actualizarChat.UseVisualStyleBackColor = True
        '
        'btn_send
        '
        Me.btn_send.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_send.BackgroundImage = Global.TratamientoFicheros.My.Resources.Resources.icons8_enviado_48
        Me.btn_send.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_send.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_send.FlatAppearance.BorderSize = 0
        Me.btn_send.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_send.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_send.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_send.ForeColor = System.Drawing.Color.FromArgb(CType(CType(28, Byte), Integer), CType(CType(60, Byte), Integer), CType(CType(73, Byte), Integer))
        Me.btn_send.Location = New System.Drawing.Point(618, -1)
        Me.btn_send.Name = "btn_send"
        Me.btn_send.Size = New System.Drawing.Size(45, 50)
        Me.btn_send.TabIndex = 1
        Me.btn_send.UseVisualStyleBackColor = True
        '
        'txt_mensaje
        '
        Me.txt_mensaje.BackColor = System.Drawing.SystemColors.Menu
        Me.txt_mensaje.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_mensaje.Location = New System.Drawing.Point(49, 12)
        Me.txt_mensaje.Name = "txt_mensaje"
        Me.txt_mensaje.Size = New System.Drawing.Size(563, 29)
        Me.txt_mensaje.TabIndex = 0
        '
        'panel_msg
        '
        Me.panel_msg.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.panel_msg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.panel_msg.Controls.Add(Me.txt_mensajes)
        Me.panel_msg.Location = New System.Drawing.Point(0, 70)
        Me.panel_msg.Name = "panel_msg"
        Me.panel_msg.Size = New System.Drawing.Size(665, 354)
        Me.panel_msg.TabIndex = 2
        '
        'txt_mensajes
        '
        Me.txt_mensajes.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_mensajes.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.txt_mensajes.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_mensajes.ForeColor = System.Drawing.Color.White
        Me.txt_mensajes.Location = New System.Drawing.Point(23, 3)
        Me.txt_mensajes.Name = "txt_mensajes"
        Me.txt_mensajes.Size = New System.Drawing.Size(642, 304)
        Me.txt_mensajes.TabIndex = 0
        Me.txt_mensajes.Text = ""
        '
        'Chat
        '
        Me.AcceptButton = Me.btn_send
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(790, 427)
        Me.Controls.Add(Me.SplitContainer1)
        Me.ForeColor = System.Drawing.Color.Transparent
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Chat"
        Me.Text = "Tareas"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.panel_msg.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents list_users As System.Windows.Forms.ListBox
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents btn_send As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents txt_mensaje As System.Windows.Forms.TextBox
    Friend WithEvents panel_msg As System.Windows.Forms.Panel
    Friend WithEvents txt_mensajes As System.Windows.Forms.RichTextBox
    Friend WithEvents lbl_destinatario As System.Windows.Forms.Label
    Friend WithEvents lbl_userListTitle As System.Windows.Forms.Label
    Friend WithEvents btn_actualizarChat As System.Windows.Forms.Button
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents lbl_avatar As System.Windows.Forms.Label
End Class
