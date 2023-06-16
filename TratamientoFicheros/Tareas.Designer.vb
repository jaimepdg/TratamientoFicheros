<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tareas
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
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.list_listas = New System.Windows.Forms.ListBox()
        Me.lbl_listTitle = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.list_tareas = New System.Windows.Forms.ListBox()
        Me.lbl_tareasTitle = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.btn_cancel = New System.Windows.Forms.Button()
        Me.btn_done = New System.Windows.Forms.Button()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.lbl_selectedListaNombre = New System.Windows.Forms.Label()
        Me.lbl_DescripcionTitle = New System.Windows.Forms.Label()
        Me.lbl_selectedListaTitle = New System.Windows.Forms.Label()
        Me.lbl_grupo = New System.Windows.Forms.Label()
        Me.lbl_grupoTitle = New System.Windows.Forms.Label()
        Me.lbl_fichaTareaTitle = New System.Windows.Forms.Label()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.Panel3.SuspendLayout()
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
        Me.SplitContainer1.Panel1.Controls.Add(Me.SplitContainer2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.SplitContainer1.Panel2.Controls.Add(Me.Panel3)
        Me.SplitContainer1.Size = New System.Drawing.Size(913, 394)
        Me.SplitContainer1.SplitterDistance = 233
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 0
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
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
        Me.SplitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.SplitContainer2.Panel2.Controls.Add(Me.Panel2)
        Me.SplitContainer2.Size = New System.Drawing.Size(233, 394)
        Me.SplitContainer2.SplitterDistance = 153
        Me.SplitContainer2.SplitterWidth = 1
        Me.SplitContainer2.TabIndex = 0
        '
        'Panel1
        '
        Me.Panel1.Controls.Add(Me.list_listas)
        Me.Panel1.Controls.Add(Me.lbl_listTitle)
        Me.Panel1.Location = New System.Drawing.Point(0, 13)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(226, 131)
        Me.Panel1.TabIndex = 0
        '
        'list_listas
        '
        Me.list_listas.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.list_listas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.list_listas.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.list_listas.ForeColor = System.Drawing.Color.White
        Me.list_listas.FormattingEnabled = True
        Me.list_listas.ItemHeight = 21
        Me.list_listas.Location = New System.Drawing.Point(0, 39)
        Me.list_listas.Name = "list_listas"
        Me.list_listas.Size = New System.Drawing.Size(253, 105)
        Me.list_listas.TabIndex = 1
        '
        'lbl_listTitle
        '
        Me.lbl_listTitle.AutoSize = True
        Me.lbl_listTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_listTitle.Location = New System.Drawing.Point(-1, 4)
        Me.lbl_listTitle.Name = "lbl_listTitle"
        Me.lbl_listTitle.Size = New System.Drawing.Size(78, 32)
        Me.lbl_listTitle.TabIndex = 0
        Me.lbl_listTitle.Text = "Listas"
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.list_tareas)
        Me.Panel2.Controls.Add(Me.lbl_tareasTitle)
        Me.Panel2.Location = New System.Drawing.Point(0, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(265, 209)
        Me.Panel2.TabIndex = 0
        '
        'list_tareas
        '
        Me.list_tareas.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.list_tareas.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.list_tareas.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.list_tareas.ForeColor = System.Drawing.Color.White
        Me.list_tareas.FormattingEnabled = True
        Me.list_tareas.ItemHeight = 21
        Me.list_tareas.Location = New System.Drawing.Point(1, 38)
        Me.list_tareas.Name = "list_tareas"
        Me.list_tareas.Size = New System.Drawing.Size(261, 168)
        Me.list_tareas.TabIndex = 1
        '
        'lbl_tareasTitle
        '
        Me.lbl_tareasTitle.AutoSize = True
        Me.lbl_tareasTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_tareasTitle.Location = New System.Drawing.Point(0, 5)
        Me.lbl_tareasTitle.Name = "lbl_tareasTitle"
        Me.lbl_tareasTitle.Size = New System.Drawing.Size(87, 32)
        Me.lbl_tareasTitle.TabIndex = 0
        Me.lbl_tareasTitle.Text = "Tareas"
        '
        'Panel3
        '
        Me.Panel3.Controls.Add(Me.btn_cancel)
        Me.Panel3.Controls.Add(Me.btn_done)
        Me.Panel3.Controls.Add(Me.txt_descripcion)
        Me.Panel3.Controls.Add(Me.lbl_selectedListaNombre)
        Me.Panel3.Controls.Add(Me.lbl_DescripcionTitle)
        Me.Panel3.Controls.Add(Me.lbl_selectedListaTitle)
        Me.Panel3.Controls.Add(Me.lbl_grupo)
        Me.Panel3.Controls.Add(Me.lbl_grupoTitle)
        Me.Panel3.Controls.Add(Me.lbl_fichaTareaTitle)
        Me.Panel3.Dock = System.Windows.Forms.DockStyle.Fill
        Me.Panel3.Location = New System.Drawing.Point(0, 0)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(679, 394)
        Me.Panel3.TabIndex = 1
        '
        'btn_cancel
        '
        Me.btn_cancel.BackgroundImage = Global.TratamientoFicheros.My.Resources.Resources.cancelled_48_white
        Me.btn_cancel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_cancel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancel.FlatAppearance.BorderSize = 0
        Me.btn_cancel.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_cancel.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_cancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancel.Location = New System.Drawing.Point(59, 32)
        Me.btn_cancel.Name = "btn_cancel"
        Me.btn_cancel.Size = New System.Drawing.Size(30, 28)
        Me.btn_cancel.TabIndex = 2
        Me.btn_cancel.UseVisualStyleBackColor = True
        '
        'btn_done
        '
        Me.btn_done.BackgroundImage = Global.TratamientoFicheros.My.Resources.Resources.done_48_white
        Me.btn_done.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_done.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_done.FlatAppearance.BorderSize = 0
        Me.btn_done.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_done.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_done.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_done.Location = New System.Drawing.Point(17, 32)
        Me.btn_done.Name = "btn_done"
        Me.btn_done.Size = New System.Drawing.Size(30, 28)
        Me.btn_done.TabIndex = 2
        Me.btn_done.UseVisualStyleBackColor = True
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_descripcion.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.txt_descripcion.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_descripcion.Cursor = System.Windows.Forms.Cursors.Default
        Me.txt_descripcion.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descripcion.ForeColor = System.Drawing.Color.White
        Me.txt_descripcion.Location = New System.Drawing.Point(12, 161)
        Me.txt_descripcion.Multiline = True
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.txt_descripcion.Size = New System.Drawing.Size(667, 233)
        Me.txt_descripcion.TabIndex = 1
        '
        'lbl_selectedListaNombre
        '
        Me.lbl_selectedListaNombre.AutoSize = True
        Me.lbl_selectedListaNombre.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbl_selectedListaNombre.Location = New System.Drawing.Point(61, 97)
        Me.lbl_selectedListaNombre.Name = "lbl_selectedListaNombre"
        Me.lbl_selectedListaNombre.Size = New System.Drawing.Size(100, 21)
        Me.lbl_selectedListaNombre.TabIndex = 0
        Me.lbl_selectedListaNombre.Text = "Nombre lista"
        '
        'lbl_DescripcionTitle
        '
        Me.lbl_DescripcionTitle.AutoSize = True
        Me.lbl_DescripcionTitle.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.lbl_DescripcionTitle.Location = New System.Drawing.Point(12, 130)
        Me.lbl_DescripcionTitle.Name = "lbl_DescripcionTitle"
        Me.lbl_DescripcionTitle.Size = New System.Drawing.Size(114, 28)
        Me.lbl_DescripcionTitle.TabIndex = 0
        Me.lbl_DescripcionTitle.Text = "Descripción"
        '
        'lbl_selectedListaTitle
        '
        Me.lbl_selectedListaTitle.AutoSize = True
        Me.lbl_selectedListaTitle.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.lbl_selectedListaTitle.Location = New System.Drawing.Point(12, 91)
        Me.lbl_selectedListaTitle.Name = "lbl_selectedListaTitle"
        Me.lbl_selectedListaTitle.Size = New System.Drawing.Size(55, 28)
        Me.lbl_selectedListaTitle.TabIndex = 0
        Me.lbl_selectedListaTitle.Text = "Lista:"
        '
        'lbl_grupo
        '
        Me.lbl_grupo.AutoSize = True
        Me.lbl_grupo.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.lbl_grupo.Location = New System.Drawing.Point(79, 69)
        Me.lbl_grupo.Name = "lbl_grupo"
        Me.lbl_grupo.Size = New System.Drawing.Size(114, 21)
        Me.lbl_grupo.TabIndex = 0
        Me.lbl_grupo.Text = "Nombre grupo"
        '
        'lbl_grupoTitle
        '
        Me.lbl_grupoTitle.AutoSize = True
        Me.lbl_grupoTitle.Font = New System.Drawing.Font("Segoe UI", 15.0!)
        Me.lbl_grupoTitle.Location = New System.Drawing.Point(12, 63)
        Me.lbl_grupoTitle.Name = "lbl_grupoTitle"
        Me.lbl_grupoTitle.Size = New System.Drawing.Size(72, 28)
        Me.lbl_grupoTitle.TabIndex = 0
        Me.lbl_grupoTitle.Text = "Grupo:"
        '
        'lbl_fichaTareaTitle
        '
        Me.lbl_fichaTareaTitle.AutoSize = True
        Me.lbl_fichaTareaTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_fichaTareaTitle.Location = New System.Drawing.Point(6, 0)
        Me.lbl_fichaTareaTitle.Name = "lbl_fichaTareaTitle"
        Me.lbl_fichaTareaTitle.Size = New System.Drawing.Size(174, 32)
        Me.lbl_fichaTareaTitle.TabIndex = 0
        Me.lbl_fichaTareaTitle.Text = "Nombre tarea"
        '
        'Tareas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(913, 394)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Tareas"
        Me.Text = "Teareas"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.Panel3.ResumeLayout(False)
        Me.Panel3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents list_listas As System.Windows.Forms.ListBox
    Friend WithEvents lbl_listTitle As System.Windows.Forms.Label
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents list_tareas As System.Windows.Forms.ListBox
    Friend WithEvents lbl_tareasTitle As System.Windows.Forms.Label
    Friend WithEvents Panel3 As System.Windows.Forms.Panel
    Friend WithEvents btn_cancel As System.Windows.Forms.Button
    Friend WithEvents btn_done As System.Windows.Forms.Button
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents lbl_selectedListaNombre As System.Windows.Forms.Label
    Friend WithEvents lbl_DescripcionTitle As System.Windows.Forms.Label
    Friend WithEvents lbl_selectedListaTitle As System.Windows.Forms.Label
    Friend WithEvents lbl_grupo As System.Windows.Forms.Label
    Friend WithEvents lbl_grupoTitle As System.Windows.Forms.Label
    Friend WithEvents lbl_fichaTareaTitle As System.Windows.Forms.Label
End Class
