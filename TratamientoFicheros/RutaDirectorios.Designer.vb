<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RutaDirectorios
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
        Me.btn_selectDirectory = New System.Windows.Forms.Button()
        Me.txt_ruta = New System.Windows.Forms.TextBox()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btn_save = New System.Windows.Forms.Button()
        Me.pic_viewer = New System.Windows.Forms.PictureBox()
        Me.btn_openDir = New System.Windows.Forms.Button()
        Me.btn_open = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.txt_nameEdit = New System.Windows.Forms.TextBox()
        Me.lbl_nameEdit = New System.Windows.Forms.Label()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.pic_viewer, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_selectDirectory
        '
        Me.btn_selectDirectory.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.btn_selectDirectory.Location = New System.Drawing.Point(457, 13)
        Me.btn_selectDirectory.Name = "btn_selectDirectory"
        Me.btn_selectDirectory.Size = New System.Drawing.Size(91, 25)
        Me.btn_selectDirectory.TabIndex = 2
        Me.btn_selectDirectory.Text = "Seleccionar"
        Me.btn_selectDirectory.UseVisualStyleBackColor = True
        '
        'txt_ruta
        '
        Me.txt_ruta.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.txt_ruta.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_ruta.Location = New System.Drawing.Point(12, 13)
        Me.txt_ruta.Name = "txt_ruta"
        Me.txt_ruta.ReadOnly = True
        Me.txt_ruta.Size = New System.Drawing.Size(439, 25)
        Me.txt_ruta.TabIndex = 3
        '
        'TreeView1
        '
        Me.TreeView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.TreeView1.ForeColor = System.Drawing.Color.White
        Me.TreeView1.Location = New System.Drawing.Point(0, 0)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(589, 389)
        Me.TreeView1.TabIndex = 6
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.TreeView1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_save)
        Me.SplitContainer1.Panel2.Controls.Add(Me.pic_viewer)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_openDir)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_open)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_delete)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txt_nameEdit)
        Me.SplitContainer1.Panel2.Controls.Add(Me.lbl_nameEdit)
        Me.SplitContainer1.Panel2MinSize = 41
        Me.SplitContainer1.Size = New System.Drawing.Size(929, 389)
        Me.SplitContainer1.SplitterDistance = 589
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 7
        '
        'btn_save
        '
        Me.btn_save.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_save.BackgroundImage = Global.TratamientoFicheros.My.Resources.Resources.save_48_colored
        Me.btn_save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_save.FlatAppearance.BorderSize = 0
        Me.btn_save.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_save.Location = New System.Drawing.Point(301, 347)
        Me.btn_save.Name = "btn_save"
        Me.btn_save.Size = New System.Drawing.Size(32, 32)
        Me.btn_save.TabIndex = 23
        Me.btn_save.UseVisualStyleBackColor = True
        '
        'pic_viewer
        '
        Me.pic_viewer.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.pic_viewer.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.pic_viewer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.pic_viewer.Location = New System.Drawing.Point(58, 12)
        Me.pic_viewer.Name = "pic_viewer"
        Me.pic_viewer.Size = New System.Drawing.Size(275, 290)
        Me.pic_viewer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.pic_viewer.TabIndex = 22
        Me.pic_viewer.TabStop = False
        '
        'btn_openDir
        '
        Me.btn_openDir.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_openDir.BackgroundImage = Global.TratamientoFicheros.My.Resources.Resources.dir_30px_colored
        Me.btn_openDir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_openDir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_openDir.FlatAppearance.BorderSize = 0
        Me.btn_openDir.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btn_openDir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_openDir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_openDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_openDir.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_openDir.Location = New System.Drawing.Point(128, 347)
        Me.btn_openDir.Name = "btn_openDir"
        Me.btn_openDir.Size = New System.Drawing.Size(32, 32)
        Me.btn_openDir.TabIndex = 17
        Me.btn_openDir.UseVisualStyleBackColor = False
        '
        'btn_open
        '
        Me.btn_open.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_open.BackgroundImage = Global.TratamientoFicheros.My.Resources.Resources.openfile_30px_colored
        Me.btn_open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_open.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_open.FlatAppearance.BorderSize = 0
        Me.btn_open.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btn_open.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_open.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_open.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_open.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_open.Location = New System.Drawing.Point(92, 347)
        Me.btn_open.Name = "btn_open"
        Me.btn_open.Size = New System.Drawing.Size(32, 32)
        Me.btn_open.TabIndex = 20
        Me.btn_open.UseVisualStyleBackColor = False
        '
        'btn_delete
        '
        Me.btn_delete.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_delete.BackgroundImage = Global.TratamientoFicheros.My.Resources.Resources.bin_30px_red
        Me.btn_delete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btn_delete.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_delete.FlatAppearance.BorderSize = 0
        Me.btn_delete.FlatAppearance.CheckedBackColor = System.Drawing.Color.Transparent
        Me.btn_delete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent
        Me.btn_delete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent
        Me.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_delete.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_delete.Location = New System.Drawing.Point(56, 347)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(32, 32)
        Me.btn_delete.TabIndex = 19
        Me.btn_delete.UseVisualStyleBackColor = False
        '
        'txt_nameEdit
        '
        Me.txt_nameEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_nameEdit.Location = New System.Drawing.Point(58, 321)
        Me.txt_nameEdit.Name = "txt_nameEdit"
        Me.txt_nameEdit.Size = New System.Drawing.Size(275, 20)
        Me.txt_nameEdit.TabIndex = 13
        '
        'lbl_nameEdit
        '
        Me.lbl_nameEdit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.lbl_nameEdit.AutoSize = True
        Me.lbl_nameEdit.ForeColor = System.Drawing.Color.White
        Me.lbl_nameEdit.Location = New System.Drawing.Point(53, 305)
        Me.lbl_nameEdit.Name = "lbl_nameEdit"
        Me.lbl_nameEdit.Size = New System.Drawing.Size(44, 13)
        Me.lbl_nameEdit.TabIndex = 12
        Me.lbl_nameEdit.Text = "Nombre"
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
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.SplitContainer2.Panel2.Controls.Add(Me.btn_selectDirectory)
        Me.SplitContainer2.Panel2.Controls.Add(Me.txt_ruta)
        Me.SplitContainer2.Panel2MinSize = 41
        Me.SplitContainer2.Size = New System.Drawing.Size(929, 433)
        Me.SplitContainer2.SplitterDistance = 389
        Me.SplitContainer2.SplitterWidth = 1
        Me.SplitContainer2.TabIndex = 8
        '
        'RutaDirectorios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoScroll = True
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(929, 433)
        Me.Controls.Add(Me.SplitContainer2)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "RutaDirectorios"
        Me.Text = "Directorios"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.pic_viewer, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btn_selectDirectory As System.Windows.Forms.Button
    Friend WithEvents txt_ruta As System.Windows.Forms.TextBox
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents pic_viewer As System.Windows.Forms.PictureBox
    Friend WithEvents btn_openDir As System.Windows.Forms.Button
    Friend WithEvents btn_open As System.Windows.Forms.Button
    Friend WithEvents btn_delete As System.Windows.Forms.Button
    Friend WithEvents txt_nameEdit As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nameEdit As System.Windows.Forms.Label
    Friend WithEvents btn_save As System.Windows.Forms.Button
End Class
