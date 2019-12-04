Public Class FormRelatorio

    Public Sub SetRelatorio(index As Integer)
        cmbRelatorio.SelectedIndex = index
    End Sub

    Private Sub CmbRelatorio_TextChanged(sender As Object, e As EventArgs) Handles cmbRelatorio.TextChanged
        RelatorioAtual.Text = cmbRelatorio.Text
    End Sub
End Class