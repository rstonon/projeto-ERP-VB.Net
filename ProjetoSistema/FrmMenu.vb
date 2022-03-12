Public Class FrmMenu
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DataDia.Text = Date.Now.ToString("dd/MM/yyyy")
    End Sub

    Private Sub CidadesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CidadesToolStripMenuItem.Click
        FrmCidades.Show()

    End Sub
End Class
