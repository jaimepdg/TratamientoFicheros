<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormatFiles
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
        Me.fbDialog_formatDate = New System.Windows.Forms.FolderBrowserDialog()
        Me.btn_DirSelection = New System.Windows.Forms.Button()
        Me.txt_ruta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_letsgo = New System.Windows.Forms.Button()
        Me.txt_rutaMoveFrom = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_rutaMoveTo = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.fbDialog_moving_from = New System.Windows.Forms.FolderBrowserDialog()
        Me.fbDialog_moving_to = New System.Windows.Forms.FolderBrowserDialog()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_DirSelection
        '
        Me.btn_DirSelection.Location = New System.Drawing.Point(18, 44)
        Me.btn_DirSelection.Name = "btn_DirSelection"
        Me.btn_DirSelection.Size = New System.Drawing.Size(75, 23)
        Me.btn_DirSelection.TabIndex = 0
        Me.btn_DirSelection.Text = "Seleccionar"
        Me.btn_DirSelection.UseVisualStyleBackColor = True
        '
        'txt_ruta
        '
        Me.txt_ruta.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txt_ruta.Location = New System.Drawing.Point(18, 73)
        Me.txt_ruta.Name = "txt_ruta"
        Me.txt_ruta.Size = New System.Drawing.Size(470, 25)
        Me.txt_ruta.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(487, 32)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Formatear lote (fecha y hora de creación)"
        '
        'btn_letsgo
        '
        Me.btn_letsgo.Location = New System.Drawing.Point(18, 152)
        Me.btn_letsgo.Name = "btn_letsgo"
        Me.btn_letsgo.Size = New System.Drawing.Size(75, 23)
        Me.btn_letsgo.TabIndex = 0
        Me.btn_letsgo.Text = "Seleccionar"
        Me.btn_letsgo.UseVisualStyleBackColor = True
        '
        'txt_rutaMoveFrom
        '
        Me.txt_rutaMoveFrom.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txt_rutaMoveFrom.Location = New System.Drawing.Point(18, 202)
        Me.txt_rutaMoveFrom.Name = "txt_rutaMoveFrom"
        Me.txt_rutaMoveFrom.Size = New System.Drawing.Size(272, 25)
        Me.txt_rutaMoveFrom.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 117)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(289, 32)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Mover lote con formato"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(14, 178)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(47, 21)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Fom:"
        '
        'txt_rutaMoveTo
        '
        Me.txt_rutaMoveTo.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.txt_rutaMoveTo.Location = New System.Drawing.Point(18, 254)
        Me.txt_rutaMoveTo.Name = "txt_rutaMoveTo"
        Me.txt_rutaMoveTo.Size = New System.Drawing.Size(272, 25)
        Me.txt_rutaMoveTo.TabIndex = 1
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Segoe UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(14, 230)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(32, 21)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "To:"
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 0)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_DirSelection)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_ruta)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_letsgo)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_rutaMoveFrom)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label1)
        Me.SplitContainer1.Panel1.Controls.Add(Me.txt_rutaMoveTo)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Font = New System.Drawing.Font("Segoe UI", 9.75!)
        Me.SplitContainer1.Size = New System.Drawing.Size(913, 394)
        Me.SplitContainer1.SplitterDistance = 852
        Me.SplitContainer1.TabIndex = 3
        '
        'FormatFiles
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(913, 394)
        Me.Controls.Add(Me.SplitContainer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "FormatFiles"
        Me.Text = "FormatFiles"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents fbDialog_formatDate As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btn_DirSelection As System.Windows.Forms.Button
    Friend WithEvents txt_ruta As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_letsgo As System.Windows.Forms.Button
    Friend WithEvents txt_rutaMoveFrom As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_rutaMoveTo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents fbDialog_moving_from As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents fbDialog_moving_to As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
End Class
