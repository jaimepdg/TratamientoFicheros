<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PDFProperties
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
        Me.lbl_title = New System.Windows.Forms.Label()
        Me.lbl_author = New System.Windows.Forms.Label()
        Me.lbl_subject = New System.Windows.Forms.Label()
        Me.lbl_keywords = New System.Windows.Forms.Label()
        Me.txt_title = New System.Windows.Forms.TextBox()
        Me.txt_author = New System.Windows.Forms.TextBox()
        Me.txt_subject = New System.Windows.Forms.TextBox()
        Me.txt_keywords = New System.Windows.Forms.TextBox()
        Me.txt_name = New System.Windows.Forms.TextBox()
        Me.lbl_nombre = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'lbl_title
        '
        Me.lbl_title.AutoSize = True
        Me.lbl_title.Location = New System.Drawing.Point(29, 121)
        Me.lbl_title.Name = "lbl_title"
        Me.lbl_title.Size = New System.Drawing.Size(43, 17)
        Me.lbl_title.TabIndex = 0
        Me.lbl_title.Text = "Título:"
        '
        'lbl_author
        '
        Me.lbl_author.AutoSize = True
        Me.lbl_author.Location = New System.Drawing.Point(29, 201)
        Me.lbl_author.Name = "lbl_author"
        Me.lbl_author.Size = New System.Drawing.Size(43, 17)
        Me.lbl_author.TabIndex = 1
        Me.lbl_author.Text = "Autor:"
        '
        'lbl_subject
        '
        Me.lbl_subject.AutoSize = True
        Me.lbl_subject.Location = New System.Drawing.Point(29, 283)
        Me.lbl_subject.Name = "lbl_subject"
        Me.lbl_subject.Size = New System.Drawing.Size(51, 17)
        Me.lbl_subject.TabIndex = 2
        Me.lbl_subject.Text = "Asunto:"
        '
        'lbl_keywords
        '
        Me.lbl_keywords.AutoSize = True
        Me.lbl_keywords.Location = New System.Drawing.Point(29, 372)
        Me.lbl_keywords.Name = "lbl_keywords"
        Me.lbl_keywords.Size = New System.Drawing.Size(94, 17)
        Me.lbl_keywords.TabIndex = 3
        Me.lbl_keywords.Text = "Palabras clave:"
        '
        'txt_title
        '
        Me.txt_title.Location = New System.Drawing.Point(32, 141)
        Me.txt_title.Name = "txt_title"
        Me.txt_title.Size = New System.Drawing.Size(364, 25)
        Me.txt_title.TabIndex = 4
        '
        'txt_author
        '
        Me.txt_author.Location = New System.Drawing.Point(32, 221)
        Me.txt_author.Name = "txt_author"
        Me.txt_author.Size = New System.Drawing.Size(364, 25)
        Me.txt_author.TabIndex = 5
        '
        'txt_subject
        '
        Me.txt_subject.Location = New System.Drawing.Point(32, 303)
        Me.txt_subject.Name = "txt_subject"
        Me.txt_subject.Size = New System.Drawing.Size(364, 25)
        Me.txt_subject.TabIndex = 6
        '
        'txt_keywords
        '
        Me.txt_keywords.Location = New System.Drawing.Point(32, 392)
        Me.txt_keywords.Multiline = True
        Me.txt_keywords.Name = "txt_keywords"
        Me.txt_keywords.Size = New System.Drawing.Size(364, 101)
        Me.txt_keywords.TabIndex = 7
        '
        'txt_name
        '
        Me.txt_name.Location = New System.Drawing.Point(32, 73)
        Me.txt_name.Name = "txt_name"
        Me.txt_name.Size = New System.Drawing.Size(364, 25)
        Me.txt_name.TabIndex = 9
        '
        'lbl_nombre
        '
        Me.lbl_nombre.AutoSize = True
        Me.lbl_nombre.Location = New System.Drawing.Point(29, 53)
        Me.lbl_nombre.Name = "lbl_nombre"
        Me.lbl_nombre.Size = New System.Drawing.Size(60, 17)
        Me.lbl_nombre.TabIndex = 8
        Me.lbl_nombre.Text = "Nombre:"
        '
        'PDFProperties
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(451, 548)
        Me.Controls.Add(Me.txt_name)
        Me.Controls.Add(Me.lbl_nombre)
        Me.Controls.Add(Me.txt_keywords)
        Me.Controls.Add(Me.txt_subject)
        Me.Controls.Add(Me.txt_author)
        Me.Controls.Add(Me.txt_title)
        Me.Controls.Add(Me.lbl_keywords)
        Me.Controls.Add(Me.lbl_subject)
        Me.Controls.Add(Me.lbl_author)
        Me.Controls.Add(Me.lbl_title)
        Me.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "PDFProperties"
        Me.Text = "PDFProperties"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lbl_title As System.Windows.Forms.Label
    Friend WithEvents lbl_author As System.Windows.Forms.Label
    Friend WithEvents lbl_subject As System.Windows.Forms.Label
    Friend WithEvents lbl_keywords As System.Windows.Forms.Label
    Friend WithEvents txt_title As System.Windows.Forms.TextBox
    Friend WithEvents txt_author As System.Windows.Forms.TextBox
    Friend WithEvents txt_subject As System.Windows.Forms.TextBox
    Friend WithEvents txt_keywords As System.Windows.Forms.TextBox
    Friend WithEvents txt_name As System.Windows.Forms.TextBox
    Friend WithEvents lbl_nombre As System.Windows.Forms.Label
End Class
