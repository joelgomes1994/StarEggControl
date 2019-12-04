Public Class FrmEstoqueNovoLancamento

    Private data As DateTime = Now

    Private Sub FrmEstoqueNovoLancamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AtualizarListaProdutos(CmbProduto)

        'Limpar Campos
        TxtPrecoTotal.Clear()
        TxtPrecoUnid.Clear()
        TxtQuantidade.Value = 1

    End Sub

    Private Sub TxtPrecoUnid_TextChanged(sender As Object, e As EventArgs) Handles TxtPrecoUnid.TextChanged
        If Not (TxtPrecoUnid.Text = "") Then
            TxtPrecoTotal.Text = CDbl((TxtPrecoUnid.Text).Replace(".", ",")) * Integer.Parse(TxtQuantidade.Value)
        End If
    End Sub

    Private Sub TxtQuantidade_ValueChanged(sender As Object, e As EventArgs) Handles TxtQuantidade.ValueChanged
        If Not (TxtPrecoUnid.Text = "") Then
            TxtPrecoTotal.Text = CDbl((TxtPrecoUnid.Text).Replace(".", ",")) * Integer.Parse(TxtQuantidade.Value)
        End If
    End Sub

    Private Sub BtnLancar_Click(sender As Object, e As EventArgs) Handles BtnLancar.Click
        If (TxtPrecoTotal.Text <> "") And (CmbProduto.Text <> "") And (CmbTipo.Text <> "") Then
            RealizarLancamento({(CmbProduto.SelectedIndex + 1), TxtQuantidade.Text, TxtPrecoUnid.Text.Replace(",", "."), CmbTipo.Text})
            Close()
        Else
            MsgBox("Preencha todos os campos!")
        End If
    End Sub

End Class