Public Class FormRelatorio

    Sub PreencherDgRelatorio()
        Try
            Sql = "select * from lancamentos"
            Rs = Db.Execute(Sql)
            DgRelatorio.Rows.Clear()

            Do While Not Rs.EOF
                DgRelatorio.Rows.Add(Rs.Fields(4).Value, Rs.Fields(5).Value, Rs.Fields(2).Value, Rs.Fields(3).Value)
                Rs.MoveNext()
            Loop
        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try
    End Sub

    Public Sub SetRelatorio(index As Integer)
        CmbTipoRelatorio.SelectedIndex = index
    End Sub

    Private Sub FormRelatorio_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CmbTipoRelatorio.SelectedIndex = 0
    End Sub

    Private Sub CmbTipoRelatorio_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbTipoRelatorio.SelectedIndexChanged
        AtualizarListaProdutos(CmbProduto)
        RelatorioAtual.Text = CmbTipoRelatorio.Text
        PreencherDgRelatorio()
    End Sub

    Private Sub CmbProduto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbProduto.SelectedIndexChanged
        PreencherDgRelatorio()
    End Sub

    Private Sub BtnProdutosTodos_Click(sender As Object, e As EventArgs) Handles BtnProdutosTodos.Click
        CmbProduto.Enabled = IIf(BtnProdutosTodos.Checked = True, False, True)
        PreencherDgRelatorio()
    End Sub
End Class