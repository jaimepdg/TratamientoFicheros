<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Navegador
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Navegador))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btn_back = New System.Windows.Forms.Button()
        Me.txt_path = New System.Windows.Forms.TextBox()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.TreeView1 = New System.Windows.Forms.TreeView()
        Me.lw_main = New System.Windows.Forms.ListView()
        Me.nombre = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.fecha = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.type = CType(New System.Windows.Forms.ColumnHeader(), System.Windows.Forms.ColumnHeader)
        Me.cms_left = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmi_copiarLeft = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_pegarLeft = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoFicheroDeTextoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaCarpetaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirUbicaciónToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprimirToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescomprimirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_eliminarLeft = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.FlowLayoutPanel1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.cms_left.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Anchor = CType((System.Windows.Forms.AnchorStyles.Left Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.FlowLayoutPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.SplitContainer2)
        Me.SplitContainer1.Size = New System.Drawing.Size(1217, 620)
        Me.SplitContainer1.SplitterDistance = 45
        Me.SplitContainer1.TabIndex = 0
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_back)
        Me.FlowLayoutPanel1.Controls.Add(Me.txt_path)
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_refresh)
        Me.FlowLayoutPanel1.Controls.Add(Me.TextBox1)
        Me.FlowLayoutPanel1.Controls.Add(Me.Button1)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.Padding = New System.Windows.Forms.Padding(10)
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(1217, 49)
        Me.FlowLayoutPanel1.TabIndex = 0
        '
        'btn_back
        '
        Me.btn_back.BackgroundImage = Global.TratamientoFicheros.My.Resources.Resources.izq_30
        Me.btn_back.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_back.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_back.FlatAppearance.BorderSize = 0
        Me.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_back.ForeColor = System.Drawing.Color.White
        Me.btn_back.Location = New System.Drawing.Point(10, 10)
        Me.btn_back.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_back.Name = "btn_back"
        Me.btn_back.Size = New System.Drawing.Size(44, 30)
        Me.btn_back.TabIndex = 0
        Me.btn_back.UseVisualStyleBackColor = True
        '
        'txt_path
        '
        Me.txt_path.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_path.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txt_path.Font = New System.Drawing.Font("Segoe UI", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_path.Location = New System.Drawing.Point(54, 10)
        Me.txt_path.Margin = New System.Windows.Forms.Padding(0)
        Me.txt_path.Name = "txt_path"
        Me.txt_path.Size = New System.Drawing.Size(814, 30)
        Me.txt_path.TabIndex = 1
        Me.txt_path.Text = "C:\"
        '
        'btn_refresh
        '
        Me.btn_refresh.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_refresh.BackgroundImage = Global.TratamientoFicheros.My.Resources.Resources.refresh_30
        Me.btn_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_refresh.ForeColor = System.Drawing.Color.White
        Me.btn_refresh.Location = New System.Drawing.Point(868, 10)
        Me.btn_refresh.Margin = New System.Windows.Forms.Padding(0, 0, 10, 0)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(30, 30)
        Me.btn_refresh.TabIndex = 2
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TextBox1.Font = New System.Drawing.Font("Segoe UI", 12.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TextBox1.Location = New System.Drawing.Point(908, 10)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(0, 0, 3, 0)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(265, 30)
        Me.TextBox1.TabIndex = 3
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackgroundImage = Global.TratamientoFicheros.My.Resources.Resources.find_30
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button1.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(1176, 10)
        Me.Button1.Margin = New System.Windows.Forms.Padding(0)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(30, 30)
        Me.Button1.TabIndex = 4
        Me.Button1.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.TreeView1)
        Me.SplitContainer2.Panel1.Padding = New System.Windows.Forms.Padding(15)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.lw_main)
        Me.SplitContainer2.Panel2.Padding = New System.Windows.Forms.Padding(15)
        Me.SplitContainer2.Size = New System.Drawing.Size(1217, 567)
        Me.SplitContainer2.SplitterDistance = 268
        Me.SplitContainer2.TabIndex = 0
        '
        'TreeView1
        '
        Me.TreeView1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.TreeView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TreeView1.Location = New System.Drawing.Point(15, 15)
        Me.TreeView1.Name = "TreeView1"
        Me.TreeView1.Size = New System.Drawing.Size(238, 537)
        Me.TreeView1.TabIndex = 0
        '
        'lw_main
        '
        Me.lw_main.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lw_main.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.nombre, Me.fecha, Me.type})
        Me.lw_main.Dock = System.Windows.Forms.DockStyle.Fill
        Me.lw_main.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lw_main.FullRowSelect = True
        Me.lw_main.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable
        Me.lw_main.Location = New System.Drawing.Point(15, 15)
        Me.lw_main.Name = "lw_main"
        Me.lw_main.Size = New System.Drawing.Size(915, 537)
        Me.lw_main.TabIndex = 0
        Me.lw_main.UseCompatibleStateImageBehavior = False
        Me.lw_main.View = System.Windows.Forms.View.Details
        '
        'nombre
        '
        Me.nombre.Text = "Nombre"
        Me.nombre.Width = 500
        '
        'fecha
        '
        Me.fecha.Text = "Fecha"
        Me.fecha.Width = 285
        '
        'type
        '
        Me.type.Text = "Tipo"
        Me.type.Width = 112
        '
        'cms_left
        '
        Me.cms_left.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_copiarLeft, Me.tsmi_pegarLeft, Me.NuevoFicheroDeTextoToolStripMenuItem1, Me.NuevaCarpetaToolStripMenuItem1, Me.AbrirUbicaciónToolStripMenuItem1, Me.ComprimirToolStripMenuItem, Me.tsmi_eliminarLeft})
        Me.cms_left.Name = "ContextMenuStrip1"
        Me.cms_left.Size = New System.Drawing.Size(196, 158)
        '
        'tsmi_copiarLeft
        '
        Me.tsmi_copiarLeft.Image = CType(resources.GetObject("tsmi_copiarLeft.Image"), System.Drawing.Image)
        Me.tsmi_copiarLeft.Name = "tsmi_copiarLeft"
        Me.tsmi_copiarLeft.Size = New System.Drawing.Size(195, 22)
        Me.tsmi_copiarLeft.Text = "Copiar"
        '
        'tsmi_pegarLeft
        '
        Me.tsmi_pegarLeft.Image = CType(resources.GetObject("tsmi_pegarLeft.Image"), System.Drawing.Image)
        Me.tsmi_pegarLeft.Name = "tsmi_pegarLeft"
        Me.tsmi_pegarLeft.Size = New System.Drawing.Size(195, 22)
        Me.tsmi_pegarLeft.Text = "Pegar"
        '
        'NuevoFicheroDeTextoToolStripMenuItem1
        '
        Me.NuevoFicheroDeTextoToolStripMenuItem1.Image = CType(resources.GetObject("NuevoFicheroDeTextoToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.NuevoFicheroDeTextoToolStripMenuItem1.Name = "NuevoFicheroDeTextoToolStripMenuItem1"
        Me.NuevoFicheroDeTextoToolStripMenuItem1.Size = New System.Drawing.Size(195, 22)
        Me.NuevoFicheroDeTextoToolStripMenuItem1.Text = "Nuevo fichero de texto"
        '
        'NuevaCarpetaToolStripMenuItem1
        '
        Me.NuevaCarpetaToolStripMenuItem1.Image = CType(resources.GetObject("NuevaCarpetaToolStripMenuItem1.Image"), System.Drawing.Image)
        Me.NuevaCarpetaToolStripMenuItem1.Name = "NuevaCarpetaToolStripMenuItem1"
        Me.NuevaCarpetaToolStripMenuItem1.Size = New System.Drawing.Size(195, 22)
        Me.NuevaCarpetaToolStripMenuItem1.Text = "Nueva carpeta"
        '
        'AbrirUbicaciónToolStripMenuItem1
        '
        Me.AbrirUbicaciónToolStripMenuItem1.Image = Global.TratamientoFicheros.My.Resources.Resources.openDir_48_colored
        Me.AbrirUbicaciónToolStripMenuItem1.Name = "AbrirUbicaciónToolStripMenuItem1"
        Me.AbrirUbicaciónToolStripMenuItem1.Size = New System.Drawing.Size(195, 22)
        Me.AbrirUbicaciónToolStripMenuItem1.Text = "abrir ubicación"
        '
        'ComprimirToolStripMenuItem
        '
        Me.ComprimirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComprimirToolStripMenuItem3, Me.DescomprimirToolStripMenuItem1})
        Me.ComprimirToolStripMenuItem.Image = Global.TratamientoFicheros.My.Resources.Resources.rar_48_colored
        Me.ComprimirToolStripMenuItem.Name = "ComprimirToolStripMenuItem"
        Me.ComprimirToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.ComprimirToolStripMenuItem.Text = "Zip"
        '
        'ComprimirToolStripMenuItem3
        '
        Me.ComprimirToolStripMenuItem3.Name = "ComprimirToolStripMenuItem3"
        Me.ComprimirToolStripMenuItem3.Size = New System.Drawing.Size(149, 22)
        Me.ComprimirToolStripMenuItem3.Text = "Comprimir"
        '
        'DescomprimirToolStripMenuItem1
        '
        Me.DescomprimirToolStripMenuItem1.Name = "DescomprimirToolStripMenuItem1"
        Me.DescomprimirToolStripMenuItem1.Size = New System.Drawing.Size(149, 22)
        Me.DescomprimirToolStripMenuItem1.Text = "Descomprimir"
        '
        'tsmi_eliminarLeft
        '
        Me.tsmi_eliminarLeft.Image = CType(resources.GetObject("tsmi_eliminarLeft.Image"), System.Drawing.Image)
        Me.tsmi_eliminarLeft.Name = "tsmi_eliminarLeft"
        Me.tsmi_eliminarLeft.Size = New System.Drawing.Size(195, 22)
        Me.tsmi_eliminarLeft.Text = "Eliminar"
        '
        'Navegador
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(1217, 620)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "Navegador"
        Me.Text = "Navegador"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.FlowLayoutPanel1.PerformLayout()
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.cms_left.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btn_back As System.Windows.Forms.Button
    Friend WithEvents txt_path As System.Windows.Forms.TextBox
    Friend WithEvents btn_refresh As System.Windows.Forms.Button
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents TreeView1 As System.Windows.Forms.TreeView
    Friend WithEvents lw_main As System.Windows.Forms.ListView
    Friend WithEvents nombre As System.Windows.Forms.ColumnHeader
    Friend WithEvents fecha As System.Windows.Forms.ColumnHeader
    Friend WithEvents type As System.Windows.Forms.ColumnHeader
    Friend WithEvents cms_left As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmi_copiarLeft As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmi_pegarLeft As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoFicheroDeTextoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevaCarpetaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirUbicaciónToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprimirToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DescomprimirToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmi_eliminarLeft As System.Windows.Forms.ToolStripMenuItem
End Class
