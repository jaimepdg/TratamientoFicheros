<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ficheros
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
        Me.components = New System.ComponentModel.Container()
        Me.grid_ficheros = New System.Windows.Forms.DataGridView()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.lbl_directorio = New System.Windows.Forms.Label()
        Me.txt_ruta = New System.Windows.Forms.TextBox()
        Me.btn_selectDirectory = New System.Windows.Forms.Button()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.pic_viewer = New System.Windows.Forms.PictureBox()
        Me.btn_openDir = New System.Windows.Forms.Button()
        Me.btn_open = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_editName = New System.Windows.Forms.Button()
        Me.txt_lastedit = New System.Windows.Forms.TextBox()
        Me.lbl_LastEdit = New System.Windows.Forms.Label()
        Me.txt_creation = New System.Windows.Forms.TextBox()
        Me.lbl_fxCreacion = New System.Windows.Forms.Label()
        Me.txt_nameEdit = New System.Windows.Forms.TextBox()
        Me.lbl_nameEdit = New System.Windows.Forms.Label()
        Me.txt_type = New System.Windows.Forms.TextBox()
        Me.lbl_tipoTitle = New System.Windows.Forms.Label()
        Me.lbl_size = New System.Windows.Forms.Label()
        Me.tooltip_delete = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_refreshGrid = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.grid_ficheros, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.pic_viewer, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'grid_ficheros
        '
        Me.grid_ficheros.AllowUserToAddRows = False
        Me.grid_ficheros.AllowUserToDeleteRows = False
        Me.grid_ficheros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.grid_ficheros.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.grid_ficheros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_ficheros.Dock = System.Windows.Forms.DockStyle.Fill
        Me.grid_ficheros.Location = New System.Drawing.Point(0, 0)
        Me.grid_ficheros.MultiSelect = False
        Me.grid_ficheros.Name = "grid_ficheros"
        Me.grid_ficheros.ReadOnly = True
        Me.grid_ficheros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_ficheros.Size = New System.Drawing.Size(505, 412)
        Me.grid_ficheros.TabIndex = 2
        '
        'lbl_directorio
        '
        Me.lbl_directorio.AutoSize = True
        Me.lbl_directorio.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_directorio.ForeColor = System.Drawing.Color.White
        Me.lbl_directorio.Location = New System.Drawing.Point(14, 6)
        Me.lbl_directorio.Name = "lbl_directorio"
        Me.lbl_directorio.Size = New System.Drawing.Size(146, 17)
        Me.lbl_directorio.TabIndex = 9
        Me.lbl_directorio.Text = "Directorio de ficheros:"
        '
        'txt_ruta
        '
        Me.txt_ruta.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txt_ruta.Location = New System.Drawing.Point(17, 26)
        Me.txt_ruta.Name = "txt_ruta"
        Me.txt_ruta.ReadOnly = True
        Me.txt_ruta.Size = New System.Drawing.Size(373, 25)
        Me.txt_ruta.TabIndex = 8
        '
        'btn_selectDirectory
        '
        Me.btn_selectDirectory.Location = New System.Drawing.Point(396, 26)
        Me.btn_selectDirectory.Name = "btn_selectDirectory"
        Me.btn_selectDirectory.Size = New System.Drawing.Size(86, 25)
        Me.btn_selectDirectory.TabIndex = 7
        Me.btn_selectDirectory.Text = "Seleccionar"
        Me.btn_selectDirectory.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Top
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_close)
        Me.SplitContainer1.Panel1.Controls.Add(Me.pic_viewer)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_openDir)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_open)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_delete)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_editName)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_lastedit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lbl_LastEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_creation)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lbl_fxCreacion)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_nameEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lbl_nameEdit)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_type)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lbl_tipoTitle)
        Me.SplitContainer1.Panel1.Controls.Add(Me.lbl_size)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.grid_ficheros)
        Me.SplitContainer1.Size = New System.Drawing.Size(806, 412)
        Me.SplitContainer1.SplitterDistance = 297
        Me.SplitContainer1.TabIndex = 10
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btn_close.BackgroundImage = Global.TratamientoFicheros.My.Resources.Resources.arrowLeft_50_white
        Me.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close.FlatAppearance.BorderSize = 0
        Me.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btn_close.Location = New System.Drawing.Point(253, 20)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(30, 30)
        Me.btn_close.TabIndex = 5
        Me.btn_close.TabStop = False
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'pic_viewer
        '
        Me.pic_viewer.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.pic_viewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pic_viewer.Location = New System.Drawing.Point(17, 12)
        Me.pic_viewer.Name = "pic_viewer"
        Me.pic_viewer.Size = New System.Drawing.Size(275, 175)
        Me.pic_viewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pic_viewer.TabIndex = 7
        Me.pic_viewer.TabStop = False
        '
        'btn_openDir
        '
        Me.btn_openDir.BackgroundImage = Global.TratamientoFicheros.My.Resources.Resources.dir_30px_colored
        Me.btn_openDir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_openDir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_openDir.FlatAppearance.BorderSize = 0
        Me.btn_openDir.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btn_openDir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_openDir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_openDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_openDir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_openDir.Location = New System.Drawing.Point(265, 340)
        Me.btn_openDir.Name = "btn_openDir"
        Me.btn_openDir.Size = New System.Drawing.Size(30, 30)
        Me.btn_openDir.TabIndex = 4
        Me.tooltip_delete.SetToolTip(Me.btn_openDir, "Abrir ubicación")
        Me.btn_openDir.UseVisualStyleBackColor = False
        '
        'btn_open
        '
        Me.btn_open.BackgroundImage = Global.TratamientoFicheros.My.Resources.Resources.openfile_30px_colored
        Me.btn_open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_open.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_open.FlatAppearance.BorderSize = 0
        Me.btn_open.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btn_open.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_open.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_open.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_open.Location = New System.Drawing.Point(229, 340)
        Me.btn_open.Name = "btn_open"
        Me.btn_open.Size = New System.Drawing.Size(30, 30)
        Me.btn_open.TabIndex = 4
        Me.tooltip_delete.SetToolTip(Me.btn_open, "Abrir fichero")
        Me.btn_open.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.BackgroundImage = Global.TratamientoFicheros.My.Resources.Resources.bin_30px_red
        Me.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete.FlatAppearance.BorderSize = 0
        Me.btn_delete.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btn_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_delete.Location = New System.Drawing.Point(193, 343)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(30, 30)
        Me.btn_delete.TabIndex = 4
        Me.tooltip_delete.SetToolTip(Me.btn_delete, "Eliminar fichero")
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'btn_editName
        '
        Me.btn_editName.Location = New System.Drawing.Point(208, 206)
        Me.btn_editName.Name = "btn_editName"
        Me.btn_editName.Size = New System.Drawing.Size(84, 23)
        Me.btn_editName.TabIndex = 4
        Me.btn_editName.Text = "Renombrar"
        Me.btn_editName.UseVisualStyleBackColor = True
        '
        'txt_lastedit
        '
        Me.txt_lastedit.Location = New System.Drawing.Point(16, 345)
        Me.txt_lastedit.Name = "txt_lastedit"
        Me.txt_lastedit.Size = New System.Drawing.Size(137, 22)
        Me.txt_lastedit.TabIndex = 3
        '
        'lbl_LastEdit
        '
        Me.lbl_LastEdit.AutoSize = True
        Me.lbl_LastEdit.ForeColor = System.Drawing.Color.White
        Me.lbl_LastEdit.Location = New System.Drawing.Point(13, 328)
        Me.lbl_LastEdit.Name = "lbl_LastEdit"
        Me.lbl_LastEdit.Size = New System.Drawing.Size(106, 13)
        Me.lbl_LastEdit.TabIndex = 2
        Me.lbl_LastEdit.Text = "Fecha modificación"
        '
        'txt_creation
        '
        Me.txt_creation.Location = New System.Drawing.Point(17, 296)
        Me.txt_creation.Name = "txt_creation"
        Me.txt_creation.Size = New System.Drawing.Size(138, 22)
        Me.txt_creation.TabIndex = 3
        '
        'lbl_fxCreacion
        '
        Me.lbl_fxCreacion.AutoSize = True
        Me.lbl_fxCreacion.ForeColor = System.Drawing.Color.White
        Me.lbl_fxCreacion.Location = New System.Drawing.Point(14, 279)
        Me.lbl_fxCreacion.Name = "lbl_fxCreacion"
        Me.lbl_fxCreacion.Size = New System.Drawing.Size(83, 13)
        Me.lbl_fxCreacion.TabIndex = 2
        Me.lbl_fxCreacion.Text = "Fecha creación"
        '
        'txt_nameEdit
        '
        Me.txt_nameEdit.Location = New System.Drawing.Point(17, 206)
        Me.txt_nameEdit.Name = "txt_nameEdit"
        Me.txt_nameEdit.Size = New System.Drawing.Size(185, 22)
        Me.txt_nameEdit.TabIndex = 3
        '
        'lbl_nameEdit
        '
        Me.lbl_nameEdit.AutoSize = True
        Me.lbl_nameEdit.ForeColor = System.Drawing.Color.White
        Me.lbl_nameEdit.Location = New System.Drawing.Point(12, 190)
        Me.lbl_nameEdit.Name = "lbl_nameEdit"
        Me.lbl_nameEdit.Size = New System.Drawing.Size(48, 13)
        Me.lbl_nameEdit.TabIndex = 2
        Me.lbl_nameEdit.Text = "Nombre"
        '
        'txt_type
        '
        Me.txt_type.Location = New System.Drawing.Point(17, 247)
        Me.txt_type.Name = "txt_type"
        Me.txt_type.Size = New System.Drawing.Size(85, 22)
        Me.txt_type.TabIndex = 3
        '
        'lbl_tipoTitle
        '
        Me.lbl_tipoTitle.AutoSize = True
        Me.lbl_tipoTitle.ForeColor = System.Drawing.Color.White
        Me.lbl_tipoTitle.Location = New System.Drawing.Point(15, 231)
        Me.lbl_tipoTitle.Name = "lbl_tipoTitle"
        Me.lbl_tipoTitle.Size = New System.Drawing.Size(30, 13)
        Me.lbl_tipoTitle.TabIndex = 2
        Me.lbl_tipoTitle.Text = "Tipo"
        '
        'lbl_size
        '
        Me.lbl_size.AutoSize = True
        Me.lbl_size.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_size.ForeColor = System.Drawing.Color.White
        Me.lbl_size.Location = New System.Drawing.Point(112, 250)
        Me.lbl_size.Name = "lbl_size"
        Me.lbl_size.Size = New System.Drawing.Size(65, 19)
        Me.lbl_size.TabIndex = 1
        Me.lbl_size.Text = "00.00MB"
        '
        'btn_refreshGrid
        '
        Me.btn_refreshGrid.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btn_refreshGrid.BackgroundImage = Global.TratamientoFicheros.My.Resources.Resources.refresh_white
        Me.btn_refreshGrid.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_refreshGrid.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_refreshGrid.FlatAppearance.BorderSize = 0
        Me.btn_refreshGrid.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btn_refreshGrid.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btn_refreshGrid.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_refreshGrid.ForeColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.btn_refreshGrid.Location = New System.Drawing.Point(488, 23)
        Me.btn_refreshGrid.Name = "btn_refreshGrid"
        Me.btn_refreshGrid.Size = New System.Drawing.Size(30, 30)
        Me.btn_refreshGrid.TabIndex = 5
        Me.btn_refreshGrid.TabStop = False
        Me.btn_refreshGrid.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(38, Byte), Integer), CType(CType(70, Byte), Integer), CType(CType(83, Byte), Integer))
        Me.Panel1.Controls.Add(Me.txt_ruta)
        Me.Panel1.Controls.Add(Me.btn_selectDirectory)
        Me.Panel1.Controls.Add(Me.btn_refreshGrid)
        Me.Panel1.Controls.Add(Me.lbl_directorio)
        Me.Panel1.Location = New System.Drawing.Point(0, 406)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(806, 61)
        Me.Panel1.TabIndex = 11
        '
        'Ficheros
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(806, 466)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ficheros"
        Me.Text = "Ficheros"
        CType(Me.grid_ficheros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.pic_viewer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents grid_ficheros As System.Windows.Forms.DataGridView
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents lbl_directorio As System.Windows.Forms.Label
    Friend WithEvents txt_ruta As System.Windows.Forms.TextBox
    Friend WithEvents btn_selectDirectory As System.Windows.Forms.Button
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btn_editName As System.Windows.Forms.Button
    Friend WithEvents txt_lastedit As System.Windows.Forms.TextBox
    Friend WithEvents lbl_LastEdit As System.Windows.Forms.Label
    Friend WithEvents txt_creation As System.Windows.Forms.TextBox
    Friend WithEvents lbl_fxCreacion As System.Windows.Forms.Label
    Friend WithEvents txt_nameEdit As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nameEdit As System.Windows.Forms.Label
    Friend WithEvents txt_type As System.Windows.Forms.TextBox
    Friend WithEvents lbl_tipoTitle As System.Windows.Forms.Label
    Friend WithEvents lbl_size As System.Windows.Forms.Label
    Friend WithEvents btn_openDir As System.Windows.Forms.Button
    Friend WithEvents btn_open As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents tooltip_delete As System.Windows.Forms.ToolTip
    Friend WithEvents pic_viewer As System.Windows.Forms.PictureBox
    Friend WithEvents btn_refreshGrid As System.Windows.Forms.Button
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
End Class
