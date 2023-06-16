<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Lotes
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
        Me.grid_ficheros = New System.Windows.Forms.DataGridView()
        Me.txt_ruta = New System.Windows.Forms.TextBox()
        Me.btn_selectDirectory = New System.Windows.Forms.Button()
        Me.FolderBrowserDialog1 = New System.Windows.Forms.FolderBrowserDialog()
        Me.lbl_directorio = New System.Windows.Forms.Label()
        CType(Me.grid_ficheros, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'grid_ficheros
        '
        Me.grid_ficheros.AllowUserToAddRows = False
        Me.grid_ficheros.AllowUserToDeleteRows = False
        Me.grid_ficheros.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.grid_ficheros.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.grid_ficheros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.grid_ficheros.Location = New System.Drawing.Point(0, -2)
        Me.grid_ficheros.MultiSelect = False
        Me.grid_ficheros.Name = "grid_ficheros"
        Me.grid_ficheros.ReadOnly = True
        Me.grid_ficheros.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.grid_ficheros.Size = New System.Drawing.Size(927, 375)
        Me.grid_ficheros.TabIndex = 5
        '
        'txt_ruta
        '
        Me.txt_ruta.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txt_ruta.Location = New System.Drawing.Point(12, 396)
        Me.txt_ruta.Name = "txt_ruta"
        Me.txt_ruta.Size = New System.Drawing.Size(373, 25)
        Me.txt_ruta.TabIndex = 4
        '
        'btn_selectDirectory
        '
        Me.btn_selectDirectory.Location = New System.Drawing.Point(391, 396)
        Me.btn_selectDirectory.Name = "btn_selectDirectory"
        Me.btn_selectDirectory.Size = New System.Drawing.Size(86, 25)
        Me.btn_selectDirectory.TabIndex = 3
        Me.btn_selectDirectory.Text = "Seleccionar"
        Me.btn_selectDirectory.UseVisualStyleBackColor = True
        '
        'lbl_directorio
        '
        Me.lbl_directorio.AutoSize = True
        Me.lbl_directorio.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_directorio.ForeColor = System.Drawing.Color.White
        Me.lbl_directorio.Location = New System.Drawing.Point(9, 376)
        Me.lbl_directorio.Name = "lbl_directorio"
        Me.lbl_directorio.Size = New System.Drawing.Size(39, 17)
        Me.lbl_directorio.TabIndex = 6
        Me.lbl_directorio.Text = "Lote:"
        '
        'Lotes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(929, 433)
        Me.Controls.Add(Me.lbl_directorio)
        Me.Controls.Add(Me.grid_ficheros)
        Me.Controls.Add(Me.txt_ruta)
        Me.Controls.Add(Me.btn_selectDirectory)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Lotes"
        Me.Text = "Lotes"
        CType(Me.grid_ficheros, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents grid_ficheros As System.Windows.Forms.DataGridView
    Friend WithEvents txt_ruta As System.Windows.Forms.TextBox
    Friend WithEvents btn_selectDirectory As System.Windows.Forms.Button
    Friend WithEvents FolderBrowserDialog1 As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents lbl_directorio As System.Windows.Forms.Label
End Class
