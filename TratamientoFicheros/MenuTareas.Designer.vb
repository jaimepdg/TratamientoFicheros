<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MenuTareas
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
        Me.btn_completed = New System.Windows.Forms.Button()
        Me.btn_cancelled = New System.Windows.Forms.Button()
        Me.btn_add = New System.Windows.Forms.Button()
        Me.btn_enProceso = New System.Windows.Forms.Button()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
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
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_completed)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_cancelled)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_add)
        Me.SplitContainer1.Panel1.Controls.Add(Me.btn_enProceso)
        Me.SplitContainer1.Size = New System.Drawing.Size(897, 355)
        Me.SplitContainer1.SplitterDistance = 60
        Me.SplitContainer1.SplitterWidth = 1
        Me.SplitContainer1.TabIndex = 0
        '
        'btn_completed
        '
        Me.btn_completed.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_completed.BackgroundImage = Global.TratamientoFicheros.My.Resources.Resources.completed_65_white
        Me.btn_completed.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_completed.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_completed.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btn_completed.FlatAppearance.BorderSize = 0
        Me.btn_completed.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btn_completed.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btn_completed.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btn_completed.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_completed.Location = New System.Drawing.Point(10, 250)
        Me.btn_completed.Name = "btn_completed"
        Me.btn_completed.Size = New System.Drawing.Size(40, 40)
        Me.btn_completed.TabIndex = 0
        Me.btn_completed.UseVisualStyleBackColor = True
        '
        'btn_cancelled
        '
        Me.btn_cancelled.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_cancelled.BackgroundImage = Global.TratamientoFicheros.My.Resources.Resources.binned_65_white
        Me.btn_cancelled.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_cancelled.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancelled.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btn_cancelled.FlatAppearance.BorderSize = 0
        Me.btn_cancelled.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btn_cancelled.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btn_cancelled.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btn_cancelled.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_cancelled.Location = New System.Drawing.Point(6, 304)
        Me.btn_cancelled.Name = "btn_cancelled"
        Me.btn_cancelled.Size = New System.Drawing.Size(48, 48)
        Me.btn_cancelled.TabIndex = 0
        Me.btn_cancelled.UseVisualStyleBackColor = True
        '
        'btn_add
        '
        Me.btn_add.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_add.BackgroundImage = Global.TratamientoFicheros.My.Resources.Resources.add_65_whitev3
        Me.btn_add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_add.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_add.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btn_add.FlatAppearance.BorderSize = 0
        Me.btn_add.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btn_add.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btn_add.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_add.Location = New System.Drawing.Point(6, 12)
        Me.btn_add.Name = "btn_add"
        Me.btn_add.Size = New System.Drawing.Size(48, 48)
        Me.btn_add.TabIndex = 0
        Me.btn_add.UseVisualStyleBackColor = True
        '
        'btn_enProceso
        '
        Me.btn_enProceso.Anchor = CType(((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_enProceso.BackgroundImage = Global.TratamientoFicheros.My.Resources.Resources.inprocess_65_white
        Me.btn_enProceso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btn_enProceso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_enProceso.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btn_enProceso.FlatAppearance.BorderSize = 0
        Me.btn_enProceso.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btn_enProceso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btn_enProceso.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(93, Byte), Integer))
        Me.btn_enProceso.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_enProceso.Location = New System.Drawing.Point(6, 188)
        Me.btn_enProceso.Name = "btn_enProceso"
        Me.btn_enProceso.Size = New System.Drawing.Size(48, 48)
        Me.btn_enProceso.TabIndex = 0
        Me.btn_enProceso.UseVisualStyleBackColor = True
        '
        'MenuTareas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(58, Byte), Integer), CType(CType(90, Byte), Integer), CType(CType(103, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(897, 355)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "MenuTareas"
        Me.Text = "MenuTareas"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents btn_completed As System.Windows.Forms.Button
    Friend WithEvents btn_cancelled As System.Windows.Forms.Button
    Friend WithEvents btn_enProceso As System.Windows.Forms.Button
    Friend WithEvents btn_add As System.Windows.Forms.Button
End Class
