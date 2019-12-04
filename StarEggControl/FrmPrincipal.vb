Public Class FrmPrincipal
    Private Sub FrmPrincipal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ConectarBanco()
        FrmUsuarioEntrar.ShowDialog()
    End Sub

    Private Sub SairToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SairToolStripMenuItem.Click
        If MsgBox("Tem certeza de que quer sair do aplicativo?", vbQuestion + vbYesNo, "Confirmar saída") = vbYes Then
            Application.Exit()
        End If
    End Sub

    Private Sub DadosDoUsuárioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DadosDoUsuárioToolStripMenuItem.Click
        FrmUsuarioDados.ShowDialog()
    End Sub

    Private Sub EntrarToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntrarToolStripMenuItem.Click
        FrmUsuarioEntrar.ShowDialog()
    End Sub

    Private Sub EncerrarSessãoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EncerrarSessãoToolStripMenuItem.Click
        If MsgBox("Tem certeza de que quer encerrar a sessão?", vbQuestion + vbYesNo, "Confirmar logout") = vbYes Then
            AlternarCamposLogin()
            UsuarioId = ""
            UsuarioNome = ""
            UsuarioTipo = ""
        End If
    End Sub

    Private Sub ProdutosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ProdutosToolStripMenuItem.Click
        FrmEstoqueProduto.ShowDialog()
    End Sub

    Private Sub NovoLancamentoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NovoLancamentoToolStripMenuItem.Click
        FrmEstoqueNovoLancamento.ShowDialog()
    End Sub

    Private Sub PEPSToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FormRelatorio.SetRelatorio(0)
        FormRelatorio.Show()
    End Sub

    Private Sub UEPSToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FormRelatorio.SetRelatorio(1)
        FormRelatorio.Show()
    End Sub

    Private Sub MédiaPonderadaToolStripMenuItem_Click(sender As Object, e As EventArgs)
        FormRelatorio.SetRelatorio(2)
        FormRelatorio.Show()
    End Sub

    Private Sub RelatóriosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RelatóriosToolStripMenuItem.Click
        FormRelatorio.ShowDialog()
    End Sub
End Class
