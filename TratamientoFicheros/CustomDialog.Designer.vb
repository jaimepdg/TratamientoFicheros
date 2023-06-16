<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CustomDialog
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
        Me.btn_close = New System.Windows.Forms.Button()
        Me.FlowLayoutPanel1 = New System.Windows.Forms.FlowLayoutPanel()
        Me.btn_submit = New System.Windows.Forms.Button()
        Me.lbl_fileName = New System.Windows.Forms.Label()
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.txt_text = New System.Windows.Forms.TextBox()
        Me.lbl_text = New System.Windows.Forms.Label()
        Me.lbl_path = New System.Windows.Forms.Label()
        Me.FlowLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_close
        '
        Me.btn_close.BackgroundImage = Global.TratamientoFicheros.My.Resources.Resources.close_48_colored
        Me.btn_close.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_close.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_close.FlatAppearance.BorderColor = System.Drawing.SystemColors.Control
        Me.btn_close.FlatAppearance.BorderSize = 0
        Me.btn_close.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(220, Byte), Integer), CType(CType(52, Byte), Integer), CType(CType(52, Byte), Integer))
        Me.btn_close.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(82, Byte), Integer), CType(CType(82, Byte), Integer))
        Me.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_close.ForeColor = System.Drawing.SystemColors.Control
        Me.btn_close.Location = New System.Drawing.Point(544, 0)
        Me.btn_close.Margin = New System.Windows.Forms.Padding(0)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(33, 30)
        Me.btn_close.TabIndex = 0
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'FlowLayoutPanel1
        '
        Me.FlowLayoutPanel1.BackColor = System.Drawing.SystemColors.ControlLight
        Me.FlowLayoutPanel1.Controls.Add(Me.btn_close)
        Me.FlowLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.FlowLayoutPanel1.Margin = New System.Windows.Forms.Padding(0)
        Me.FlowLayoutPanel1.Name = "FlowLayoutPanel1"
        Me.FlowLayoutPanel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.FlowLayoutPanel1.Size = New System.Drawing.Size(577, 30)
        Me.FlowLayoutPanel1.TabIndex = 1
        '
        'btn_submit
        '
        Me.btn_submit.Font = New System.Drawing.Font("Segoe UI", 12.0!)
        Me.btn_submit.Location = New System.Drawing.Point(436, 285)
        Me.btn_submit.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btn_submit.Name = "btn_submit"
        Me.btn_submit.Size = New System.Drawing.Size(84, 34)
        Me.btn_submit.TabIndex = 2
        Me.btn_submit.Text = "Crear"
        Me.btn_submit.UseVisualStyleBackColor = True
        '
        'lbl_fileName
        '
        Me.lbl_fileName.AutoSize = True
        Me.lbl_fileName.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lbl_fileName.Location = New System.Drawing.Point(63, 106)
        Me.lbl_fileName.Name = "lbl_fileName"
        Me.lbl_fileName.Size = New System.Drawing.Size(62, 19)
        Me.lbl_fileName.TabIndex = 3
        Me.lbl_fileName.Text = "Nombre:"
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.BackColor = System.Drawing.SystemColors.ControlLight
        Me.lbl_title.Location = New System.Drawing.Point(8, 7)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(130, 15)
        Me.lbl_title.TabIndex = 4
        Me.lbl_title.Text = "Nuevo archivo de texto"
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(67, 129)
        Me.txt_name.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(212, 23)
        Me.txt_name.TabIndex = 5
        '
        'txt_text
        '
        Me.txt_text.Location = New System.Drawing.Point(65, 183)
        Me.txt_text.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.txt_text.Multiline = True
        Me.txt_text.Name = "txt_text"
        Me.txt_text.Size = New System.Drawing.Size(455, 94)
        Me.txt_text.TabIndex = 7
        '
        'lbl_text
        '
        Me.lbl_text.AutoSize = True
        Me.lbl_text.Font = New System.Drawing.Font("Segoe UI", 10.0!)
        Me.lbl_text.Location = New System.Drawing.Point(63, 160)
        Me.lbl_text.Name = "lbl_text"
        Me.lbl_text.Size = New System.Drawing.Size(44, 19)
        Me.lbl_text.TabIndex = 6
        Me.lbl_text.Text = "Texto:"
        '
        'lbl_path
        '
        Me.lbl_path.AutoSize = True
        Me.lbl_path.Font = New System.Drawing.Font("Segoe UI", 10.0!, System.Drawing.FontStyle.Bold)
        Me.lbl_path.Location = New System.Drawing.Point(63, 52)
        Me.lbl_path.Name = "lbl_path"
        Me.lbl_path.Size = New System.Drawing.Size(39, 19)
        Me.lbl_path.TabIndex = 8
        Me.lbl_path.Text = "Ruta"
        '
        'CustomDialog
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(576, 334)
        Me.Controls.Add(Me.lbl_path)
        Me.Controls.Add(Me.txt_text)
        Me.Controls.Add(Me.lbl_text)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.lbl_title)
        Me.Controls.Add(Me.lbl_fileName)
        Me.Controls.Add(Me.btn_submit)
        Me.Controls.Add(Me.FlowLayoutPanel1)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "CustomDialog"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "CustomDialog"
        Me.TopMost = True
        Me.FlowLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_close As System.Windows.Forms.Button
    Friend WithEvents FlowLayoutPanel1 As System.Windows.Forms.FlowLayoutPanel
    Friend WithEvents btn_submit As System.Windows.Forms.Button
    Friend WithEvents lbl_fileName As System.Windows.Forms.Label
    Friend WithEvents lbl_title As System.Windows.Forms.Label
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents txt_text As System.Windows.Forms.TextBox
    Friend WithEvents lbl_text As System.Windows.Forms.Label
    Friend WithEvents lbl_path As System.Windows.Forms.Label
End Class
