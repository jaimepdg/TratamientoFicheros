Public Class MenuTareas
    Dim tareas As New Tareas
    Dim tareasCompletadas As New Tareas
    Dim tareasDesechadas As New Tareas
    Dim newTarea As New NewTarea

    

    Private Sub MenuTareas_Load(sender As Object, e As System.EventArgs) Handles Me.Load

    End Sub


    Private Sub bnt_add_Click(sender As System.Object, e As System.EventArgs) Handles btn_add.Click
        newTarea = New NewTarea
        newTarea.Show()
        tareasCompletadas.Close()
        tareasDesechadas.Close()
        tareas.Close()

        newTarea.TopLevel = False
        newTarea.FormBorderStyle = FormBorderStyle.None
        newTarea.Dock = DockStyle.Fill
        SplitContainer1.Panel2.Controls.Add(newTarea)
        newTarea.Show()
        newTarea.BringToFront()
        addIconColored = True
        completedIconcolored = False
        binnedIconColored = False
        processIconcolored = False
        btn_add.BackgroundImage = My.Resources.add_65_colored
        btn_enProceso.BackgroundImage = My.Resources.inprocess_65_white
        btn_completed.BackgroundImage = My.Resources.completed_65_white
        btn_cancelled.BackgroundImage = My.Resources.binned_65_white
    End Sub

    Private Sub btn_enpProceso_Click(sender As System.Object, e As System.EventArgs) Handles btn_enProceso.Click
        tareas = New Tareas
        tareas.Show()
        tareasCompletadas.Close()
        tareasDesechadas.Close()
        newTarea.Close()

        tareas.TopLevel = False
        tareas.FormBorderStyle = FormBorderStyle.None
        tareas.Dock = DockStyle.Fill
        SplitContainer1.Panel2.Controls.Add(tareas)
        tareas.Show()
        tareas.BringToFront()
        completedIconcolored = False
        binnedIconColored = False
        processIconcolored = True
        addIconColored = False
        btn_enProceso.BackgroundImage = My.Resources.inprocess_65_colored
        btn_completed.BackgroundImage = My.Resources.completed_65_white
        btn_cancelled.BackgroundImage = My.Resources.binned_65_white
        btn_add.BackgroundImage = My.Resources.add_65_whitev3
    End Sub

    Private Sub btn_cancelled_Click(sender As System.Object, e As System.EventArgs) Handles btn_cancelled.Click
        Dim tareasDesechadas As New Tareas
        tareasDesechadas.Show()
        tareas.Close()
        tareasCompletadas.Close()
        newTarea.Close()

        tareasDesechadas.TopLevel = False
        tareasDesechadas.FormBorderStyle = FormBorderStyle.None
        tareasDesechadas.Dock = DockStyle.Fill
        SplitContainer1.Panel2.Controls.Add(tareasDesechadas)
        tareasDesechadas.Show()
        tareasDesechadas.BringToFront()
        completedIconcolored = False
        binnedIconColored = True
        processIconcolored = False
        addIconColored = False
        btn_cancelled.BackgroundImage = My.Resources.binned_65_colored
        btn_enProceso.BackgroundImage = My.Resources.inprocess_65_white
        btn_completed.BackgroundImage = My.Resources.completed_65_white
        btn_add.BackgroundImage = My.Resources.add_65_whitev3

    End Sub

    Private Sub btn_completed_Click(sender As System.Object, e As System.EventArgs) Handles btn_completed.Click
        Dim tareasCompletadas As New Tareas
        tareasCompletadas.Show()
        tareasDesechadas.Close()
        tareas.Close()
        newTarea.Close()

        tareasCompletadas.TopLevel = False
        tareasCompletadas.FormBorderStyle = FormBorderStyle.None
        tareasCompletadas.Dock = DockStyle.Fill
        SplitContainer1.Panel2.Controls.Add(tareasCompletadas)
        tareasCompletadas.Show()
        tareasCompletadas.BringToFront()
        completedIconcolored = True
        binnedIconColored = False
        processIconcolored = False
        addIconColored = False
        btn_completed.BackgroundImage = My.Resources.completed_65_colored
        btn_cancelled.BackgroundImage = My.Resources.binned_65_white
        btn_enProceso.BackgroundImage = My.Resources.inprocess_65_white
        btn_add.BackgroundImage = My.Resources.add_65_whitev3

    End Sub









    Private Sub btn_enProceso_MouseEnter(sender As Object, e As System.EventArgs) Handles btn_enProceso.MouseEnter
        btn_enProceso.BackgroundImage = My.Resources.inprocess_65_colored
        btn_enProceso.BackColor = Color.FromArgb(48, 80, 93)
    End Sub
    Private Sub btn_refreshGrid_MouseLeave(sender As Object, e As System.EventArgs) Handles btn_enProceso.MouseLeave

        If Not processIconcolored Then
            btn_enProceso.BackgroundImage = My.Resources.inprocess_65_white
        End If

    End Sub

    Private Sub btn_cancelled_MouseEnter(sender As Object, e As System.EventArgs) Handles btn_cancelled.MouseEnter
        btn_cancelled.BackgroundImage = My.Resources.binned_65_colored
        btn_cancelled.BackColor = Color.FromArgb(48, 80, 93)
    End Sub

    Private Sub btn_cancelled_MouseLeave(sender As Object, e As System.EventArgs) Handles btn_cancelled.MouseLeave
        If Not binnedIconColored Then
            btn_cancelled.BackgroundImage = My.Resources.binned_65_white
        End If

    End Sub


    Private Sub btn_completed_MouseEnter(sender As Object, e As System.EventArgs) Handles btn_completed.MouseEnter
        btn_completed.BackgroundImage = My.Resources.completed_65_colored
        btn_completed.BackColor = Color.FromArgb(48, 80, 93)
    End Sub

    Private Sub btn_completed_MouseLeave(sender As Object, e As System.EventArgs) Handles btn_completed.MouseLeave


        If Not completedIconcolored Then
            btn_completed.BackgroundImage = My.Resources.completed_65_white
        End If
    End Sub

   
    
    Private Sub btn_add_MouseEnter(sender As Object, e As System.EventArgs) Handles btn_add.MouseEnter
        btn_add.BackgroundImage = My.Resources.add_65_colored
    End Sub

    Private Sub btn_add_MouseLeave(sender As Object, e As System.EventArgs) Handles btn_add.MouseLeave
        If Not addIconColored Then
            btn_add.BackgroundImage = My.Resources.add_65_whitev3
        End If

    End Sub
End Class