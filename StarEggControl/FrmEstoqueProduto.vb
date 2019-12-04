Public Class FrmEstoqueProduto
    Private Sub FrmEstoqueProdutos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AtualizarListaProdutos(CmbProduto)
    End Sub

    Private Sub CmbProduto_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbProduto.SelectedIndexChanged
        Try
            Sql = "select * from produtos where nome = '" & CmbProduto.Text & "'"
            Rs = Db.Execute(Sql)

            If Rs.EOF = False Then
                TxtId.Text = Rs(0).Value
                TxtNome.Text = Rs(1).Value
                TxtDescricao.Text = Rs(2).Value
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        TxtId.Text = ""
        TxtNome.Text = ""
        TxtDescricao.Text = ""

        TxtNome.Select()
    End Sub

    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles BtnNovo.Click
        Try
            If TxtId.Text <> "" Then
                MsgBox("Limpe os campos antes de cadastrar um novo produto!", vbExclamation + vbOKOnly, "Produto ainda selecionado")
            ElseIf TxtNome.Text = "" Then
                MsgBox("Preencha os campos corretamente!", vbExclamation + vbOKOnly, "Informações insuficientes")
            Else
                If MsgBox("Cadastrar novo produto com as informações fornecidas?", vbQuestion + vbYesNo, "Confirmar novo cadastro") = vbYes Then
                    Sql = "insert into produtos (nome, descricao, preco) values ('" & TxtNome.Text & "', '" & TxtDescricao.Text & "')"
                    Db.Execute(Sql)
                    MsgBox("Produto cadastrado com sucesso.", vbInformation + vbOKOnly, "Cadastro bem sucedido")
                    AtualizarListaProdutos(CmbProduto)
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnAlterar_Click(sender As Object, e As EventArgs) Handles BtnAlterar.Click
        Try
            If TxtId.Text = "" Then
                MsgBox("Nenhum produto selecionado!", vbExclamation + vbOKOnly)
            Else
                If MsgBox("Confirma as alterações para o produto atual?", vbQuestion + vbYesNo, "Cofirmar alterações") = vbYes Then
                    Sql = "select * from produtos where id = " & TxtId.Text
                    Rs = Db.Execute(Sql)

                    If Rs.EOF = False Then
                        Sql = "update produtos set nome='" & TxtNome.Text & "', descricao='" & TxtDescricao.Text & "' where id=" & TxtId.Text
                        Rs = Db.Execute(Sql)
                        MsgBox("Alterações realizados com sucesso.", vbInformation + vbOKOnly, "Alterações realizadas")
                        AtualizarListaProdutos(CmbProduto)
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub TxtPreco_KeyPress(sender As Object, e As KeyPressEventArgs)
        If Not Char.IsDigit(e.KeyChar) And Not Char.IsControl(e.KeyChar) And Not e.KeyChar = "." Then
            e.Handled = True
        End If
    End Sub
End Class