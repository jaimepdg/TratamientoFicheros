Imports iTextSharp.text
Imports iTextSharp.text.pdf
Imports System.IO

Public Class Home

    Private Sub Home_Load(sender As Object, e As System.EventArgs) Handles Me.Load

    End Sub

    Private Sub Button1_Click(sender As System.Object, e As System.EventArgs)
        newPdf.Show()
        Form1.Enabled = False





    End Sub

    Private Sub Button2_Click(sender As System.Object, e As System.EventArgs)


        marcagua("C:\pdf\PDFDEFINITIVO.pdf", "C:\pdf\vamonosnnio2.pdf")

    End Sub

    Private Sub Button3_Click(sender As System.Object, e As System.EventArgs)
        Dual.Show()

    End Sub

    Private Sub PictureBox1_Click(sender As System.Object, e As System.EventArgs) Handles PictureBox1.Click

    End Sub

    Private Sub Button4_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button5_Click(sender As System.Object, e As System.EventArgs)
        formatPdfg("C:\pdf\headerandfooter.pdf", "C:\pdf\vamonosnnio3.pdf", "C:\icons\dir_30px_colored.png")
    End Sub

    Private Sub Button6_Click(sender As System.Object, e As System.EventArgs)
        unzipFile("C:\Users\usuario\Downloads\howto_net_use_dotnetzip.zip", "C:\pdf\zip")
    End Sub

    Private Sub Button7_Click(sender As System.Object, e As System.EventArgs)

    End Sub

    Private Sub Button8_Click(sender As System.Object, e As System.EventArgs)
        Navegador.Show()

    End Sub

    Private Sub Button9_Click(sender As System.Object, e As System.EventArgs)
        addPass("C:\pdf\a.pdf", "C:\pdf\a(passworded).pdf", "", "")
    End Sub
End Class