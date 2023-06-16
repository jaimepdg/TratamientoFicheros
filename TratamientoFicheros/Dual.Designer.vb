<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dual
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dual))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.btn_refresh = New System.Windows.Forms.Button()
        Me.btn_filtro = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.RichTextBox1 = New System.Windows.Forms.RichTextBox()
        Me.btn_pathBack_left = New System.Windows.Forms.Button()
        Me.btn_createDirLeft = New System.Windows.Forms.Button()
        Me.btn_deleteLeft = New System.Windows.Forms.Button()
        Me.btn_createTxtLeft = New System.Windows.Forms.Button()
        Me.CheckedListBox1 = New System.Windows.Forms.CheckedListBox()
        Me.btn_rutaIzq = New System.Windows.Forms.Button()
        Me.txt_pathLeft = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_refreshD = New System.Windows.Forms.Button()
        Me.btn_filtroD = New System.Windows.Forms.Button()
        Me.btn_close2 = New System.Windows.Forms.Button()
        Me.RichTextBox2 = New System.Windows.Forms.RichTextBox()
        Me.btn_createTextRight = New System.Windows.Forms.Button()
        Me.btn_createDirRight = New System.Windows.Forms.Button()
        Me.btn_pathBackRight = New System.Windows.Forms.Button()
        Me.btn_deleteRight = New System.Windows.Forms.Button()
        Me.CheckedListBox2 = New System.Windows.Forms.CheckedListBox()
        Me.btn_rutaDrcha = New System.Windows.Forms.Button()
        Me.txt_pathRight = New System.Windows.Forms.TextBox()
        Me.btn_moveToRight = New System.Windows.Forms.Button()
        Me.btn_moveToLeft = New System.Windows.Forms.Button()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.btn_mergePDFs_right = New System.Windows.Forms.Button()
        Me.btn_pdfWm_right = New System.Windows.Forms.Button()
        Me.btn_newPdf_right = New System.Windows.Forms.Button()
        Me.btn_mergePDFs_left = New System.Windows.Forms.Button()
        Me.btn_pdfWm_left = New System.Windows.Forms.Button()
        Me.btn_newPdf_left = New System.Windows.Forms.Button()
        Me.btn_compareTxt = New System.Windows.Forms.Button()
        Me.fbd_listaLeft = New System.Windows.Forms.FolderBrowserDialog()
        Me.fbd_listaRight = New System.Windows.Forms.FolderBrowserDialog()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.cms_left = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmi_copiarLeft = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_pegarLeft = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoFicheroDeTextoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaCarpetaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirUbicaciónToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprimirToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescomprimirToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PDFToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProtegerConContraseñaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PropiedadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_eliminarLeft = New System.Windows.Forms.ToolStripMenuItem()
        Me.cms_right = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.tsmi_copiarRight = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_pegarRight = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevoFicheroDeTextoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NuevaCarpetaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AbrirUbicaciónToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprimirToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ComprimirToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.DescomprimirToolStripMenuItemR = New System.Windows.Forms.ToolStripMenuItem()
        Me.PDFToolStripMenuItemR = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProtegerConContraseñaToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.PropiedadesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.tsmi_eliminarRight = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        Me.cms_left.SuspendLayout()
        Me.cms_right.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_refresh)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_filtro)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_close)
        Me.SplitContainer1.Panel1.Controls.Add(Me.RichTextBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_pathBack_left)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_createDirLeft)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_deleteLeft)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_createTxtLeft)
        Me.SplitContainer1.Panel1.Controls.Add(Me.CheckedListBox1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_rutaIzq)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_pathLeft)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_refreshD)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_filtroD)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_close2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.RichTextBox2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_createTextRight)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_createDirRight)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_pathBackRight)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_deleteRight)
        Me.SplitContainer1.Panel2.Controls.Add(Me.CheckedListBox2)
        Me.SplitContainer1.Panel2.Controls.Add(Me.btn_rutaDrcha)
        Me.SplitContainer1.Panel2.Controls.Add(Me.txt_pathRight)
        Me.SplitContainer1.Size = New System.Drawing.Size(1146, 563)
        Me.SplitContainer1.SplitterDistance = 573
        Me.SplitContainer1.SplitterWidth = 6
        Me.SplitContainer1.TabIndex = 0
        '
        'btn_refresh
        '
        Me.btn_refresh.BackgroundImage = Global.TratamientoFicheros.My.Resources.Resources.refresh_white
        Me.btn_refresh.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_refresh.FlatAppearance.BorderSize = 0
        Me.btn_refresh.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_refresh.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_refresh.Location = New System.Drawing.Point(406, 9)
        Me.btn_refresh.Name = "btn_refresh"
        Me.btn_refresh.Size = New System.Drawing.Size(32, 32)
        Me.btn_refresh.TabIndex = 12
        Me.btn_refresh.UseVisualStyleBackColor = True
        '
        'btn_filtro
        '
        Me.btn_filtro.BackgroundImage = Global.TratamientoFicheros.My.Resources.Resources.find_48_white
        Me.btn_filtro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_filtro.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_filtro.FlatAppearance.BorderSize = 0
        Me.btn_filtro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_filtro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_filtro.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_filtro.Location = New System.Drawing.Point(444, 8)
        Me.btn_filtro.Name = "btn_filtro"
        Me.btn_filtro.Size = New System.Drawing.Size(32, 32)
        Me.btn_filtro.TabIndex = 11
        Me.btn_filtro.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 532)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 30)
        Me.Label1.TabIndex = 3
        '
        'btn_close
        '
        Me.btn_close.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_close.BackgroundImage = Global.TratamientoFicheros.My.Resources.Resources.close_48_colored
        Me.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btn_close.FlatAppearance.BorderSize = 0
        Me.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_close.Location = New System.Drawing.Point(479, 283)
        Me.btn_close.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(33, 30)
        Me.btn_close.TabIndex = 9
        Me.btn_close.UseVisualStyleBackColor = False
        '
        'RichTextBox1
        '
        Me.RichTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox1.Location = New System.Drawing.Point(13, 288)
        Me.RichTextBox1.Name = "RichTextBox1"
        Me.RichTextBox1.Size = New System.Drawing.Size(463, 241)
        Me.RichTextBox1.TabIndex = 7
        Me.RichTextBox1.Text = ""
        '
        'btn_pathBack_left
        '
        Me.btn_pathBack_left.BackgroundImage = Global.TratamientoFicheros.My.Resources.Resources.arrowLeft_50_white
        Me.btn_pathBack_left.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_pathBack_left.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_pathBack_left.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_pathBack_left.FlatAppearance.BorderSize = 0
        Me.btn_pathBack_left.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_pathBack_left.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_pathBack_left.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pathBack_left.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_pathBack_left.Location = New System.Drawing.Point(13, 9)
        Me.btn_pathBack_left.Name = "btn_pathBack_left"
        Me.btn_pathBack_left.Size = New System.Drawing.Size(32, 32)
        Me.btn_pathBack_left.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.btn_pathBack_left, "Atrás")
        Me.btn_pathBack_left.UseVisualStyleBackColor = True
        '
        'btn_createDirLeft
        '
        Me.btn_createDirLeft.BackgroundImage = CType(resources.GetObject("btn_createDirLeft.BackgroundImage"), System.Drawing.Image)
        Me.btn_createDirLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_createDirLeft.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_createDirLeft.FlatAppearance.BorderSize = 0
        Me.btn_createDirLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_createDirLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_createDirLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_createDirLeft.Location = New System.Drawing.Point(482, 427)
        Me.btn_createDirLeft.Name = "btn_createDirLeft"
        Me.btn_createDirLeft.Size = New System.Drawing.Size(48, 48)
        Me.btn_createDirLeft.TabIndex = 10
        Me.ToolTip1.SetToolTip(Me.btn_createDirLeft, "Nueva carpeta")
        Me.btn_createDirLeft.UseVisualStyleBackColor = True
        '
        'btn_deleteLeft
        '
        Me.btn_deleteLeft.BackgroundImage = CType(resources.GetObject("btn_deleteLeft.BackgroundImage"), System.Drawing.Image)
        Me.btn_deleteLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_deleteLeft.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_deleteLeft.FlatAppearance.BorderSize = 0
        Me.btn_deleteLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_deleteLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_deleteLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_deleteLeft.Location = New System.Drawing.Point(482, 481)
        Me.btn_deleteLeft.Name = "btn_deleteLeft"
        Me.btn_deleteLeft.Size = New System.Drawing.Size(48, 48)
        Me.btn_deleteLeft.TabIndex = 6
        Me.ToolTip1.SetToolTip(Me.btn_deleteLeft, "Eliminar fichero")
        Me.btn_deleteLeft.UseVisualStyleBackColor = True
        '
        'btn_createTxtLeft
        '
        Me.btn_createTxtLeft.BackgroundImage = CType(resources.GetObject("btn_createTxtLeft.BackgroundImage"), System.Drawing.Image)
        Me.btn_createTxtLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_createTxtLeft.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_createTxtLeft.FlatAppearance.BorderSize = 0
        Me.btn_createTxtLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_createTxtLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_createTxtLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_createTxtLeft.Location = New System.Drawing.Point(482, 373)
        Me.btn_createTxtLeft.Name = "btn_createTxtLeft"
        Me.btn_createTxtLeft.Size = New System.Drawing.Size(48, 48)
        Me.btn_createTxtLeft.TabIndex = 5
        Me.ToolTip1.SetToolTip(Me.btn_createTxtLeft, "Crear fichero de texto")
        Me.btn_createTxtLeft.UseVisualStyleBackColor = True
        '
        'CheckedListBox1
        '
        Me.CheckedListBox1.AllowDrop = True
        Me.CheckedListBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.CheckedListBox1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CheckedListBox1.CheckOnClick = True
        Me.CheckedListBox1.ForeColor = System.Drawing.Color.White
        Me.CheckedListBox1.FormattingEnabled = True
        Me.CheckedListBox1.Location = New System.Drawing.Point(13, 43)
        Me.CheckedListBox1.Name = "CheckedListBox1"
        Me.CheckedListBox1.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.CheckedListBox1.Size = New System.Drawing.Size(463, 480)
        Me.CheckedListBox1.TabIndex = 2
        '
        'btn_rutaIzq
        '
        Me.btn_rutaIzq.BackgroundImage = Global.TratamientoFicheros.My.Resources.Resources.dir_48_colored
        Me.btn_rutaIzq.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_rutaIzq.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_rutaIzq.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_rutaIzq.FlatAppearance.BorderSize = 0
        Me.btn_rutaIzq.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_rutaIzq.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_rutaIzq.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_rutaIzq.ForeColor = System.Drawing.Color.White
        Me.btn_rutaIzq.Location = New System.Drawing.Point(355, 1)
        Me.btn_rutaIzq.Name = "btn_rutaIzq"
        Me.btn_rutaIzq.Size = New System.Drawing.Size(45, 45)
        Me.btn_rutaIzq.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.btn_rutaIzq, "Seleccionar directorio")
        Me.btn_rutaIzq.UseVisualStyleBackColor = True
        '
        'txt_pathLeft
        '
        Me.txt_pathLeft.Location = New System.Drawing.Point(51, 11)
        Me.txt_pathLeft.Name = "txt_pathLeft"
        Me.txt_pathLeft.Size = New System.Drawing.Size(298, 29)
        Me.txt_pathLeft.TabIndex = 0
        Me.txt_pathLeft.Text = "C:\"
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Bold)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Label2.Location = New System.Drawing.Point(93, 532)
        Me.Label2.Name = "Label2"
        Me.Label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label2.Size = New System.Drawing.Size(462, 41)
        Me.Label2.TabIndex = 4
        '
        'btn_refreshD
        '
        Me.btn_refreshD.BackgroundImage = Global.TratamientoFicheros.My.Resources.Resources.refresh_white
        Me.btn_refreshD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_refreshD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_refreshD.FlatAppearance.BorderSize = 0
        Me.btn_refreshD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_refreshD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_refreshD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_refreshD.Location = New System.Drawing.Point(131, 9)
        Me.btn_refreshD.Name = "btn_refreshD"
        Me.btn_refreshD.Size = New System.Drawing.Size(32, 32)
        Me.btn_refreshD.TabIndex = 14
        Me.btn_refreshD.UseVisualStyleBackColor = True
        '
        'btn_filtroD
        '
        Me.btn_filtroD.BackgroundImage = Global.TratamientoFicheros.My.Resources.Resources.find_48_white
        Me.btn_filtroD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_filtroD.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_filtroD.FlatAppearance.BorderSize = 0
        Me.btn_filtroD.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_filtroD.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_filtroD.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_filtroD.Location = New System.Drawing.Point(93, 9)
        Me.btn_filtroD.Name = "btn_filtroD"
        Me.btn_filtroD.Size = New System.Drawing.Size(32, 32)
        Me.btn_filtroD.TabIndex = 13
        Me.btn_filtroD.UseVisualStyleBackColor = True
        '
        'btn_close2
        '
        Me.btn_close2.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_close2.BackgroundImage = Global.TratamientoFicheros.My.Resources.Resources.close_48_colored
        Me.btn_close2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_close2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close2.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btn_close2.FlatAppearance.BorderSize = 0
        Me.btn_close2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btn_close2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_close2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close2.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_close2.Location = New System.Drawing.Point(57, 283)
        Me.btn_close2.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_close2.Name = "btn_close2"
        Me.btn_close2.Size = New System.Drawing.Size(33, 30)
        Me.btn_close2.TabIndex = 10
        Me.btn_close2.UseVisualStyleBackColor = False
        '
        'RichTextBox2
        '
        Me.RichTextBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.RichTextBox2.Location = New System.Drawing.Point(92, 283)
        Me.RichTextBox2.Name = "RichTextBox2"
        Me.RichTextBox2.Size = New System.Drawing.Size(463, 246)
        Me.RichTextBox2.TabIndex = 8
        Me.RichTextBox2.Text = ""
        '
        'btn_createTextRight
        '
        Me.btn_createTextRight.BackgroundImage = CType(resources.GetObject("btn_createTextRight.BackgroundImage"), System.Drawing.Image)
        Me.btn_createTextRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_createTextRight.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_createTextRight.FlatAppearance.BorderSize = 0
        Me.btn_createTextRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_createTextRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_createTextRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_createTextRight.Location = New System.Drawing.Point(38, 373)
        Me.btn_createTextRight.Name = "btn_createTextRight"
        Me.btn_createTextRight.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.btn_createTextRight.Size = New System.Drawing.Size(48, 48)
        Me.btn_createTextRight.TabIndex = 11
        Me.ToolTip1.SetToolTip(Me.btn_createTextRight, "Crear fichero de texto")
        Me.btn_createTextRight.UseVisualStyleBackColor = True
        '
        'btn_createDirRight
        '
        Me.btn_createDirRight.BackgroundImage = CType(resources.GetObject("btn_createDirRight.BackgroundImage"), System.Drawing.Image)
        Me.btn_createDirRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_createDirRight.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_createDirRight.FlatAppearance.BorderSize = 0
        Me.btn_createDirRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_createDirRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_createDirRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_createDirRight.Location = New System.Drawing.Point(38, 427)
        Me.btn_createDirRight.Name = "btn_createDirRight"
        Me.btn_createDirRight.Size = New System.Drawing.Size(48, 48)
        Me.btn_createDirRight.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.btn_createDirRight, "Nueva carpeta")
        Me.btn_createDirRight.UseVisualStyleBackColor = True
        '
        'btn_pathBackRight
        '
        Me.btn_pathBackRight.BackgroundImage = Global.TratamientoFicheros.My.Resources.Resources.arrowLeft_50_white
        Me.btn_pathBackRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_pathBackRight.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_pathBackRight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_pathBackRight.FlatAppearance.BorderSize = 0
        Me.btn_pathBackRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_pathBackRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_pathBackRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_pathBackRight.ForeColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_pathBackRight.Location = New System.Drawing.Point(523, 9)
        Me.btn_pathBackRight.Name = "btn_pathBackRight"
        Me.btn_pathBackRight.Size = New System.Drawing.Size(32, 32)
        Me.btn_pathBackRight.TabIndex = 4
        Me.ToolTip1.SetToolTip(Me.btn_pathBackRight, "Atrás")
        Me.btn_pathBackRight.UseVisualStyleBackColor = True
        '
        'btn_deleteRight
        '
        Me.btn_deleteRight.BackgroundImage = CType(resources.GetObject("btn_deleteRight.BackgroundImage"), System.Drawing.Image)
        Me.btn_deleteRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_deleteRight.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_deleteRight.FlatAppearance.BorderSize = 0
        Me.btn_deleteRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_deleteRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_deleteRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_deleteRight.Location = New System.Drawing.Point(38, 481)
        Me.btn_deleteRight.Name = "btn_deleteRight"
        Me.btn_deleteRight.Size = New System.Drawing.Size(48, 48)
        Me.btn_deleteRight.TabIndex = 12
        Me.ToolTip1.SetToolTip(Me.btn_deleteRight, "Eliminar fichero")
        Me.btn_deleteRight.UseVisualStyleBackColor = True
        '
        'CheckedListBox2
        '
        Me.CheckedListBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.CheckedListBox2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.CheckedListBox2.CheckOnClick = True
        Me.CheckedListBox2.ForeColor = System.Drawing.Color.White
        Me.CheckedListBox2.FormattingEnabled = True
        Me.CheckedListBox2.Location = New System.Drawing.Point(93, 43)
        Me.CheckedListBox2.Name = "CheckedListBox2"
        Me.CheckedListBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.CheckedListBox2.Size = New System.Drawing.Size(462, 480)
        Me.CheckedListBox2.TabIndex = 2
        '
        'btn_rutaDrcha
        '
        Me.btn_rutaDrcha.BackgroundImage = Global.TratamientoFicheros.My.Resources.Resources.dir_48_colored_mirror
        Me.btn_rutaDrcha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_rutaDrcha.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_rutaDrcha.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_rutaDrcha.FlatAppearance.BorderSize = 0
        Me.btn_rutaDrcha.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_rutaDrcha.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_rutaDrcha.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_rutaDrcha.ForeColor = System.Drawing.Color.White
        Me.btn_rutaDrcha.Location = New System.Drawing.Point(169, 1)
        Me.btn_rutaDrcha.Name = "btn_rutaDrcha"
        Me.btn_rutaDrcha.Size = New System.Drawing.Size(45, 45)
        Me.btn_rutaDrcha.TabIndex = 1
        Me.ToolTip1.SetToolTip(Me.btn_rutaDrcha, "Seleccionar directorio")
        Me.btn_rutaDrcha.UseVisualStyleBackColor = True
        '
        'txt_pathRight
        '
        Me.txt_pathRight.Location = New System.Drawing.Point(219, 11)
        Me.txt_pathRight.Name = "txt_pathRight"
        Me.txt_pathRight.Size = New System.Drawing.Size(298, 29)
        Me.txt_pathRight.TabIndex = 0
        Me.txt_pathRight.Text = "C:\"
        '
        'btn_moveToRight
        '
        Me.btn_moveToRight.BackgroundImage = Global.TratamientoFicheros.My.Resources.Resources.arrowRight_68_white
        Me.btn_moveToRight.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_moveToRight.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_moveToRight.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_moveToRight.FlatAppearance.BorderSize = 0
        Me.btn_moveToRight.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_moveToRight.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_moveToRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_moveToRight.Location = New System.Drawing.Point(400, 10)
        Me.btn_moveToRight.Name = "btn_moveToRight"
        Me.btn_moveToRight.Size = New System.Drawing.Size(70, 45)
        Me.btn_moveToRight.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.btn_moveToRight, "Mover a la derecha")
        Me.btn_moveToRight.UseVisualStyleBackColor = True
        '
        'btn_moveToLeft
        '
        Me.btn_moveToLeft.BackgroundImage = Global.TratamientoFicheros.My.Resources.Resources.arrowLeft_68_white
        Me.btn_moveToLeft.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_moveToLeft.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_moveToLeft.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_moveToLeft.FlatAppearance.BorderSize = 0
        Me.btn_moveToLeft.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_moveToLeft.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.btn_moveToLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_moveToLeft.Location = New System.Drawing.Point(671, 11)
        Me.btn_moveToLeft.Name = "btn_moveToLeft"
        Me.btn_moveToLeft.Size = New System.Drawing.Size(70, 45)
        Me.btn_moveToLeft.TabIndex = 3
        Me.ToolTip1.SetToolTip(Me.btn_moveToLeft, "Mover a la izquierda")
        Me.btn_moveToLeft.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer2.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.SplitContainer2.Name = "SplitContainer2"
        Me.SplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.SplitContainer1)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(53, Byte), Integer), CType(CType(85, Byte), Integer), CType(CType(98, Byte), Integer))
        Me.SplitContainer2.Panel2.Controls.Add(Me.Button1)
        Me.SplitContainer2.Panel2.Controls.Add(Me.btn_mergePDFs_right)
        Me.SplitContainer2.Panel2.Controls.Add(Me.btn_pdfWm_right)
        Me.SplitContainer2.Panel2.Controls.Add(Me.btn_newPdf_right)
        Me.SplitContainer2.Panel2.Controls.Add(Me.btn_mergePDFs_left)
        Me.SplitContainer2.Panel2.Controls.Add(Me.btn_pdfWm_left)
        Me.SplitContainer2.Panel2.Controls.Add(Me.btn_newPdf_left)
        Me.SplitContainer2.Panel2.Controls.Add(Me.btn_compareTxt)
        Me.SplitContainer2.Panel2.Controls.Add(Me.btn_moveToRight)
        Me.SplitContainer2.Panel2.Controls.Add(Me.btn_moveToLeft)
        Me.SplitContainer2.Size = New System.Drawing.Size(1146, 629)
        Me.SplitContainer2.SplitterDistance = 563
        Me.SplitContainer2.SplitterWidth = 6
        Me.SplitContainer2.TabIndex = 1
        '
        'btn_mergePDFs_right
        '
        Me.btn_mergePDFs_right.Location = New System.Drawing.Point(801, 16)
        Me.btn_mergePDFs_right.Name = "btn_mergePDFs_right"
        Me.btn_mergePDFs_right.Size = New System.Drawing.Size(108, 34)
        Me.btn_mergePDFs_right.TabIndex = 18
        Me.btn_mergePDFs_right.Text = "MergePDFs"
        Me.ToolTip1.SetToolTip(Me.btn_mergePDFs_right, "Marcar PDF")
        Me.btn_mergePDFs_right.UseVisualStyleBackColor = True
        '
        'btn_pdfWm_right
        '
        Me.btn_pdfWm_right.Location = New System.Drawing.Point(915, 16)
        Me.btn_pdfWm_right.Name = "btn_pdfWm_right"
        Me.btn_pdfWm_right.Size = New System.Drawing.Size(133, 34)
        Me.btn_pdfWm_right.TabIndex = 17
        Me.btn_pdfWm_right.Text = "PDF watermark"
        Me.ToolTip1.SetToolTip(Me.btn_pdfWm_right, "Marcar PDF")
        Me.btn_pdfWm_right.UseVisualStyleBackColor = True
        '
        'btn_newPdf_right
        '
        Me.btn_newPdf_right.Location = New System.Drawing.Point(1054, 16)
        Me.btn_newPdf_right.Name = "btn_newPdf_right"
        Me.btn_newPdf_right.Size = New System.Drawing.Size(75, 34)
        Me.btn_newPdf_right.TabIndex = 16
        Me.btn_newPdf_right.Text = "+pdf"
        Me.ToolTip1.SetToolTip(Me.btn_newPdf_right, "Crear PDF")
        Me.btn_newPdf_right.UseVisualStyleBackColor = True
        '
        'btn_mergePDFs_left
        '
        Me.btn_mergePDFs_left.Location = New System.Drawing.Point(236, 16)
        Me.btn_mergePDFs_left.Name = "btn_mergePDFs_left"
        Me.btn_mergePDFs_left.Size = New System.Drawing.Size(108, 34)
        Me.btn_mergePDFs_left.TabIndex = 15
        Me.btn_mergePDFs_left.Text = "MergePDFs"
        Me.ToolTip1.SetToolTip(Me.btn_mergePDFs_left, "Marcar PDF")
        Me.btn_mergePDFs_left.UseVisualStyleBackColor = True
        '
        'btn_pdfWm_left
        '
        Me.btn_pdfWm_left.Location = New System.Drawing.Point(93, 16)
        Me.btn_pdfWm_left.Name = "btn_pdfWm_left"
        Me.btn_pdfWm_left.Size = New System.Drawing.Size(137, 34)
        Me.btn_pdfWm_left.TabIndex = 14
        Me.btn_pdfWm_left.Text = "PDF watermark"
        Me.ToolTip1.SetToolTip(Me.btn_pdfWm_left, "Marcar PDF")
        Me.btn_pdfWm_left.UseVisualStyleBackColor = True
        '
        'btn_newPdf_left
        '
        Me.btn_newPdf_left.Location = New System.Drawing.Point(12, 15)
        Me.btn_newPdf_left.Name = "btn_newPdf_left"
        Me.btn_newPdf_left.Size = New System.Drawing.Size(75, 34)
        Me.btn_newPdf_left.TabIndex = 5
        Me.btn_newPdf_left.Text = "+pdf"
        Me.ToolTip1.SetToolTip(Me.btn_newPdf_left, "Crear PDF")
        Me.btn_newPdf_left.UseVisualStyleBackColor = True
        '
        'btn_compareTxt
        '
        Me.btn_compareTxt.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.btn_compareTxt.Location = New System.Drawing.Point(496, 6)
        Me.btn_compareTxt.Name = "btn_compareTxt"
        Me.btn_compareTxt.Size = New System.Drawing.Size(154, 42)
        Me.btn_compareTxt.TabIndex = 2
        Me.btn_compareTxt.Text = "Comparar txt"
        Me.btn_compareTxt.UseVisualStyleBackColor = True
        '
        'cms_left
        '
        Me.cms_left.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_copiarLeft, Me.tsmi_pegarLeft, Me.NuevoFicheroDeTextoToolStripMenuItem1, Me.NuevaCarpetaToolStripMenuItem1, Me.AbrirUbicaciónToolStripMenuItem1, Me.ComprimirToolStripMenuItem, Me.PDFToolStripMenuItem, Me.tsmi_eliminarLeft})
        Me.cms_left.Name = "ContextMenuStrip1"
        Me.cms_left.Size = New System.Drawing.Size(196, 180)
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
        Me.ComprimirToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComprimirToolStripMenuItem3, Me.DescomprimirToolStripMenuItem})
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
        'DescomprimirToolStripMenuItem
        '
        Me.DescomprimirToolStripMenuItem.Name = "DescomprimirToolStripMenuItem"
        Me.DescomprimirToolStripMenuItem.Size = New System.Drawing.Size(149, 22)
        Me.DescomprimirToolStripMenuItem.Text = "Descomprimir"
        '
        'PDFToolStripMenuItem
        '
        Me.PDFToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProtegerConContraseñaToolStripMenuItem, Me.PropiedadesToolStripMenuItem})
        Me.PDFToolStripMenuItem.Image = Global.TratamientoFicheros.My.Resources.Resources.adobepdf_48_colored
        Me.PDFToolStripMenuItem.Name = "PDFToolStripMenuItem"
        Me.PDFToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.PDFToolStripMenuItem.Text = "PDF"
        '
        'ProtegerConContraseñaToolStripMenuItem
        '
        Me.ProtegerConContraseñaToolStripMenuItem.Name = "ProtegerConContraseñaToolStripMenuItem"
        Me.ProtegerConContraseñaToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.ProtegerConContraseñaToolStripMenuItem.Text = "Proteger con contraseña"
        '
        'PropiedadesToolStripMenuItem
        '
        Me.PropiedadesToolStripMenuItem.Name = "PropiedadesToolStripMenuItem"
        Me.PropiedadesToolStripMenuItem.Size = New System.Drawing.Size(203, 22)
        Me.PropiedadesToolStripMenuItem.Text = "Propiedades"
        '
        'tsmi_eliminarLeft
        '
        Me.tsmi_eliminarLeft.Image = CType(resources.GetObject("tsmi_eliminarLeft.Image"), System.Drawing.Image)
        Me.tsmi_eliminarLeft.Name = "tsmi_eliminarLeft"
        Me.tsmi_eliminarLeft.Size = New System.Drawing.Size(195, 22)
        Me.tsmi_eliminarLeft.Text = "Eliminar"
        '
        'cms_right
        '
        Me.cms_right.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.tsmi_copiarRight, Me.tsmi_pegarRight, Me.NuevoFicheroDeTextoToolStripMenuItem, Me.NuevaCarpetaToolStripMenuItem, Me.AbrirUbicaciónToolStripMenuItem, Me.ComprimirToolStripMenuItem1, Me.PDFToolStripMenuItemR, Me.tsmi_eliminarRight})
        Me.cms_right.Name = "ContextMenuStrip1"
        Me.cms_right.Size = New System.Drawing.Size(196, 180)
        '
        'tsmi_copiarRight
        '
        Me.tsmi_copiarRight.Image = CType(resources.GetObject("tsmi_copiarRight.Image"), System.Drawing.Image)
        Me.tsmi_copiarRight.Name = "tsmi_copiarRight"
        Me.tsmi_copiarRight.Size = New System.Drawing.Size(195, 22)
        Me.tsmi_copiarRight.Text = "Copiar"
        '
        'tsmi_pegarRight
        '
        Me.tsmi_pegarRight.Image = CType(resources.GetObject("tsmi_pegarRight.Image"), System.Drawing.Image)
        Me.tsmi_pegarRight.Name = "tsmi_pegarRight"
        Me.tsmi_pegarRight.Size = New System.Drawing.Size(195, 22)
        Me.tsmi_pegarRight.Text = "Pegar"
        '
        'NuevoFicheroDeTextoToolStripMenuItem
        '
        Me.NuevoFicheroDeTextoToolStripMenuItem.Image = CType(resources.GetObject("NuevoFicheroDeTextoToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NuevoFicheroDeTextoToolStripMenuItem.Name = "NuevoFicheroDeTextoToolStripMenuItem"
        Me.NuevoFicheroDeTextoToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.NuevoFicheroDeTextoToolStripMenuItem.Text = "Nuevo fichero de texto"
        '
        'NuevaCarpetaToolStripMenuItem
        '
        Me.NuevaCarpetaToolStripMenuItem.Image = CType(resources.GetObject("NuevaCarpetaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.NuevaCarpetaToolStripMenuItem.Name = "NuevaCarpetaToolStripMenuItem"
        Me.NuevaCarpetaToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.NuevaCarpetaToolStripMenuItem.Text = "Nueva carpeta"
        '
        'AbrirUbicaciónToolStripMenuItem
        '
        Me.AbrirUbicaciónToolStripMenuItem.Image = Global.TratamientoFicheros.My.Resources.Resources.openDir_48_colored
        Me.AbrirUbicaciónToolStripMenuItem.Name = "AbrirUbicaciónToolStripMenuItem"
        Me.AbrirUbicaciónToolStripMenuItem.Size = New System.Drawing.Size(195, 22)
        Me.AbrirUbicaciónToolStripMenuItem.Text = "Abrir ubicación"
        '
        'ComprimirToolStripMenuItem1
        '
        Me.ComprimirToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ComprimirToolStripMenuItem2, Me.DescomprimirToolStripMenuItemR})
        Me.ComprimirToolStripMenuItem1.Image = Global.TratamientoFicheros.My.Resources.Resources.rar_48_colored
        Me.ComprimirToolStripMenuItem1.Name = "ComprimirToolStripMenuItem1"
        Me.ComprimirToolStripMenuItem1.Size = New System.Drawing.Size(195, 22)
        Me.ComprimirToolStripMenuItem1.Text = "Zip"
        '
        'ComprimirToolStripMenuItem2
        '
        Me.ComprimirToolStripMenuItem2.Name = "ComprimirToolStripMenuItem2"
        Me.ComprimirToolStripMenuItem2.Size = New System.Drawing.Size(149, 22)
        Me.ComprimirToolStripMenuItem2.Text = "Comprimir"
        '
        'DescomprimirToolStripMenuItemR
        '
        Me.DescomprimirToolStripMenuItemR.CheckOnClick = True
        Me.DescomprimirToolStripMenuItemR.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.DescomprimirToolStripMenuItemR.Name = "DescomprimirToolStripMenuItemR"
        Me.DescomprimirToolStripMenuItemR.Size = New System.Drawing.Size(149, 22)
        Me.DescomprimirToolStripMenuItemR.Text = "Descomprimir"
        '
        'PDFToolStripMenuItemR
        '
        Me.PDFToolStripMenuItemR.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProtegerConContraseñaToolStripMenuItem1, Me.PropiedadesToolStripMenuItem1})
        Me.PDFToolStripMenuItemR.Image = Global.TratamientoFicheros.My.Resources.Resources.adobepdf_48_colored
        Me.PDFToolStripMenuItemR.Name = "PDFToolStripMenuItemR"
        Me.PDFToolStripMenuItemR.Size = New System.Drawing.Size(195, 22)
        Me.PDFToolStripMenuItemR.Text = "PDF"
        '
        'ProtegerConContraseñaToolStripMenuItem1
        '
        Me.ProtegerConContraseñaToolStripMenuItem1.Name = "ProtegerConContraseñaToolStripMenuItem1"
        Me.ProtegerConContraseñaToolStripMenuItem1.Size = New System.Drawing.Size(203, 22)
        Me.ProtegerConContraseñaToolStripMenuItem1.Text = "Proteger con contraseña"
        '
        'PropiedadesToolStripMenuItem1
        '
        Me.PropiedadesToolStripMenuItem1.Name = "PropiedadesToolStripMenuItem1"
        Me.PropiedadesToolStripMenuItem1.Size = New System.Drawing.Size(203, 22)
        Me.PropiedadesToolStripMenuItem1.Text = "Propiedades"
        '
        'tsmi_eliminarRight
        '
        Me.tsmi_eliminarRight.Image = CType(resources.GetObject("tsmi_eliminarRight.Image"), System.Drawing.Image)
        Me.tsmi_eliminarRight.Name = "tsmi_eliminarRight"
        Me.tsmi_eliminarRight.Size = New System.Drawing.Size(195, 22)
        Me.tsmi_eliminarRight.Text = "Eliminar"
        '
        'Button2
        '
        Me.Button2.BackgroundImage = CType(resources.GetObject("Button2.BackgroundImage"), System.Drawing.Image)
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Hand
        Me.Button2.FlatAppearance.BorderSize = 0
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(93, 9)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(32, 32)
        Me.Button2.TabIndex = 13
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(355, 16)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(39, 34)
        Me.Button1.TabIndex = 19
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Dual
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 21.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1146, 629)
        Me.Controls.Add(Me.SplitContainer2)
        Me.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "Dual"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dual"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        Me.cms_left.ResumeLayout(False)
        Me.cms_right.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents SplitContainer2 As System.Windows.Forms.SplitContainer
    Friend WithEvents CheckedListBox1 As System.Windows.Forms.CheckedListBox
    Friend WithEvents btn_rutaIzq As System.Windows.Forms.Button
    Friend WithEvents txt_pathLeft As System.Windows.Forms.TextBox
    Friend WithEvents CheckedListBox2 As System.Windows.Forms.CheckedListBox
    Friend WithEvents txt_pathRight As System.Windows.Forms.TextBox
    Friend WithEvents btn_pathBack_left As System.Windows.Forms.Button
    Friend WithEvents btn_moveToRight As System.Windows.Forms.Button
    Friend WithEvents btn_pathBackRight As System.Windows.Forms.Button
    Friend WithEvents btn_moveToLeft As System.Windows.Forms.Button
    Friend WithEvents btn_compareTxt As System.Windows.Forms.Button
    Friend WithEvents fbd_listaLeft As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents fbd_listaRight As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btn_rutaDrcha As System.Windows.Forms.Button
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btn_createTxtLeft As System.Windows.Forms.Button
    Friend WithEvents btn_deleteLeft As System.Windows.Forms.Button
    Friend WithEvents RichTextBox1 As System.Windows.Forms.RichTextBox
    Friend WithEvents RichTextBox2 As System.Windows.Forms.RichTextBox
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents btn_close2 As System.Windows.Forms.Button
    Friend WithEvents btn_createDirLeft As System.Windows.Forms.Button
    Friend WithEvents cms_left As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmi_copiarLeft As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmi_eliminarLeft As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmi_pegarLeft As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents cms_right As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents tsmi_copiarRight As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmi_pegarRight As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents tsmi_eliminarRight As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_createDirRight As System.Windows.Forms.Button
    Friend WithEvents btn_deleteRight As System.Windows.Forms.Button
    Friend WithEvents btn_createTextRight As System.Windows.Forms.Button
    Friend WithEvents btn_filtro As System.Windows.Forms.Button
    Friend WithEvents btn_refresh As System.Windows.Forms.Button
    Friend WithEvents NuevaCarpetaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoFicheroDeTextoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevaCarpetaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents NuevoFicheroDeTextoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_refreshD As System.Windows.Forms.Button
    Friend WithEvents btn_filtroD As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_newPdf_left As System.Windows.Forms.Button
    Friend WithEvents ComprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprimirToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprimirToolStripMenuItem2 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DescomprimirToolStripMenuItemR As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ComprimirToolStripMenuItem3 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DescomprimirToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirUbicaciónToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AbrirUbicaciónToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents btn_pdfWm_left As System.Windows.Forms.Button
    Friend WithEvents btn_mergePDFs_left As System.Windows.Forms.Button
    Friend WithEvents btn_mergePDFs_right As System.Windows.Forms.Button
    Friend WithEvents btn_pdfWm_right As System.Windows.Forms.Button
    Friend WithEvents btn_newPdf_right As System.Windows.Forms.Button
    Friend WithEvents PDFToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProtegerConContraseñaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PropiedadesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PDFToolStripMenuItemR As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ProtegerConContraseñaToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PropiedadesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
