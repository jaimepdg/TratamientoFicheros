<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NewTarea
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
        Me.lbl_newListTtle = New System.Windows.Forms.Label()
        Me.btn_addTask = New System.Windows.Forms.Button()
        Me.lbl_descripcionTitle = New System.Windows.Forms.Label()
        Me.lbl_newTaskTitle = New System.Windows.Forms.Label()
        Me.lbl_nombreTitle = New System.Windows.Forms.Label()
        Me.lbl_listaTitle = New System.Windows.Forms.Label()
        Me.lbl_grupoTitle = New System.Windows.Forms.Label()
        Me.combo_lista = New System.Windows.Forms.ComboBox()
        Me.combo_grupo = New System.Windows.Forms.ComboBox()
        Me.txt_descripcion = New System.Windows.Forms.TextBox()
        Me.txt_nombreTarea = New System.Windows.Forms.TextBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.lbl_newListTtle)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_addTask)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbl_descripcionTitle)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbl_newTaskTitle)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbl_nombreTitle)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbl_listaTitle)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbl_grupoTitle)
        Me.SplitContainer1.Panel2.Controls.Add(Me.combo_lista)
        Me.SplitContainer1.Panel2.Controls.Add(Me.combo_grupo)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txt_descripcion)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txt_nombreTarea)
        Me.SplitContainer1.Size = New System.Drawing.Size(913, 394)
        Me.SplitContainer1.SplitterDistance = 246
        Me.SplitContainer1.TabIndex = 0
        '
        'lbl_newListTtle
        '
        Me.lbl_newListTtle.AutoSize = True
        Me.lbl_newListTtle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_newListTtle.Location = New System.Drawing.Point(13, 13)
        Me.lbl_newListTtle.Name = "lbl_newListTtle"
        Me.lbl_newListTtle.Size = New System.Drawing.Size(142, 32)
        Me.lbl_newListTtle.TabIndex = 0
        Me.lbl_newListTtle.Text = "Nueva lista"
        '
        'btn_addTask
        '
        Me.btn_addTask.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_addTask.Location = New System.Drawing.Point(562, 359)
        Me.btn_addTask.Name = "btn_addTask"
        Me.btn_addTask.Size = New System.Drawing.Size(75, 23)
        Me.btn_addTask.TabIndex = 6
        Me.btn_addTask.Text = "Añadir"
        Me.btn_addTask.UseVisualStyleBackColor = True
        '
        'lbl_descripcionTitle
        '
        Me.lbl_descripcionTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_descripcionTitle.AutoSize = True
        Me.lbl_descripcionTitle.Location = New System.Drawing.Point(33, 225)
        Me.lbl_descripcionTitle.Name = "lbl_descripcionTitle"
        Me.lbl_descripcionTitle.Size = New System.Drawing.Size(67, 13)
        Me.lbl_descripcionTitle.TabIndex = 5
        Me.lbl_descripcionTitle.Text = "Descripción"
        '
        'lbl_newTaskTitle
        '
        Me.lbl_newTaskTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_newTaskTitle.AutoSize = True
        Me.lbl_newTaskTitle.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_newTaskTitle.Location = New System.Drawing.Point(30, 13)
        Me.lbl_newTaskTitle.Name = "lbl_newTaskTitle"
        Me.lbl_newTaskTitle.Size = New System.Drawing.Size(153, 32)
        Me.lbl_newTaskTitle.TabIndex = 0
        Me.lbl_newTaskTitle.Text = "Nueva tarea"
        '
        'lbl_nombreTitle
        '
        Me.lbl_nombreTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_nombreTitle.AutoSize = True
        Me.lbl_nombreTitle.Location = New System.Drawing.Point(33, 168)
        Me.lbl_nombreTitle.Name = "lbl_nombreTitle"
        Me.lbl_nombreTitle.Size = New System.Drawing.Size(48, 13)
        Me.lbl_nombreTitle.TabIndex = 5
        Me.lbl_nombreTitle.Text = "Nombre"
        '
        'lbl_listaTitle
        '
        Me.lbl_listaTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_listaTitle.AutoSize = True
        Me.lbl_listaTitle.Location = New System.Drawing.Point(33, 117)
        Me.lbl_listaTitle.Name = "lbl_listaTitle"
        Me.lbl_listaTitle.Size = New System.Drawing.Size(30, 13)
        Me.lbl_listaTitle.TabIndex = 5
        Me.lbl_listaTitle.Text = "Lista"
        '
        'lbl_grupoTitle
        '
        Me.lbl_grupoTitle.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_grupoTitle.AutoSize = True
        Me.lbl_grupoTitle.Location = New System.Drawing.Point(33, 67)
        Me.lbl_grupoTitle.Name = "lbl_grupoTitle"
        Me.lbl_grupoTitle.Size = New System.Drawing.Size(40, 13)
        Me.lbl_grupoTitle.TabIndex = 5
        Me.lbl_grupoTitle.Text = "Grupo"
        '
        'combo_lista
        '
        Me.combo_lista.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.combo_lista.FormattingEnabled = True
        Me.combo_lista.Location = New System.Drawing.Point(36, 133)
        Me.combo_lista.Name = "combo_lista"
        Me.combo_lista.Size = New System.Drawing.Size(270, 21)
        Me.combo_lista.TabIndex = 4
        '
        'combo_grupo
        '
        Me.combo_grupo.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.combo_grupo.FormattingEnabled = True
        Me.combo_grupo.Location = New System.Drawing.Point(36, 83)
        Me.combo_grupo.Name = "combo_grupo"
        Me.combo_grupo.Size = New System.Drawing.Size(270, 21)
        Me.combo_grupo.TabIndex = 3
        '
        'txt_descripcion
        '
        Me.txt_descripcion.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_descripcion.Location = New System.Drawing.Point(36, 241)
        Me.txt_descripcion.Multiline = True
        Me.txt_descripcion.Name = "txt_descripcion"
        Me.txt_descripcion.Size = New System.Drawing.Size(602, 102)
        Me.txt_descripcion.TabIndex = 2
        '
        'txt_nombreTarea
        '
        Me.txt_nombreTarea.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_nombreTarea.Location = New System.Drawing.Point(36, 184)
        Me.txt_nombreTarea.Name = "txt_nombreTarea"
        Me.txt_nombreTarea.Size = New System.Drawing.Size(331, 22)
        Me.txt_nombreTarea.TabIndex = 1
        '
        'NewTarea
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(913, 394)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NewTarea"
        Me.Text = "NewTarea"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents lbl_newListTtle As System.Windows.Forms.Label
    Friend WithEvents lbl_newTaskTitle As System.Windows.Forms.Label
    Friend WithEvents btn_addTask As System.Windows.Forms.Button
    Friend WithEvents lbl_descripcionTitle As System.Windows.Forms.Label
    Friend WithEvents lbl_nombreTitle As System.Windows.Forms.Label
    Friend WithEvents lbl_listaTitle As System.Windows.Forms.Label
    Friend WithEvents lbl_grupoTitle As System.Windows.Forms.Label
    Friend WithEvents combo_lista As System.Windows.Forms.ComboBox
    Friend WithEvents combo_grupo As System.Windows.Forms.ComboBox
    Friend WithEvents txt_descripcion As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombreTarea As System.Windows.Forms.TextBox
End Class
