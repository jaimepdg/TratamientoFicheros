<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PassToPdf
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PassToPdf))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_pass = New System.Windows.Forms.TextBox()
        Me.txt_editPass = New System.Windows.Forms.TextBox()
        Me.btn_ok = New System.Windows.Forms.Button()
        Me.lbl_path = New System.Windows.Forms.Label()
        Me.fbd_pass = New System.Windows.Forms.FolderBrowserDialog()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Contraseña"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(29, 106)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Contraseña de edición"
        '
        'txt_pass
        '
        Me.txt_pass.Location = New System.Drawing.Point(32, 73)
        Me.txt_pass.Name = "txt_pass"
        Me.txt_pass.Size = New System.Drawing.Size(144, 20)
        Me.txt_pass.TabIndex = 2
        '
        'txt_editPass
        '
        Me.txt_editPass.Location = New System.Drawing.Point(32, 122)
        Me.txt_editPass.Name = "txt_editPass"
        Me.txt_editPass.Size = New System.Drawing.Size(144, 20)
        Me.txt_editPass.TabIndex = 3
        '
        'btn_ok
        '
        Me.btn_ok.Location = New System.Drawing.Point(32, 166)
        Me.btn_ok.Name = "btn_ok"
        Me.btn_ok.Size = New System.Drawing.Size(82, 23)
        Me.btn_ok.TabIndex = 4
        Me.btn_ok.Text = "Contraseñear"
        Me.btn_ok.UseVisualStyleBackColor = True
        '
        'lbl_path
        '
        Me.lbl_path.AutoSize = True
        Me.lbl_path.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_path.Location = New System.Drawing.Point(29, 18)
        Me.lbl_path.Name = "lbl_path"
        Me.lbl_path.Size = New System.Drawing.Size(134, 17)
        Me.lbl_path.TabIndex = 5
        Me.lbl_path.Text = "Agregar contraseña"
        '
        'PassToPdf
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(222, 222)
        Me.Controls.Add(Me.lbl_path)
        Me.Controls.Add(Me.btn_ok)
        Me.Controls.Add(Me.txt_editPass)
        Me.Controls.Add(Me.txt_pass)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "PassToPdf"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PassToPdf"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_pass As System.Windows.Forms.TextBox
    Friend WithEvents txt_editPass As System.Windows.Forms.TextBox
    Friend WithEvents btn_ok As System.Windows.Forms.Button
    Friend WithEvents lbl_path As System.Windows.Forms.Label
    Friend WithEvents fbd_pass As System.Windows.Forms.FolderBrowserDialog
End Class
