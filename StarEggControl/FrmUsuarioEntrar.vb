Public Class FrmUsuarioEntrar

    Private Sub BtnEntrar_Click(sender As Object, e As EventArgs) Handles BtnEntrar.Click
        Try
            If TxtUsuario.Text = "" Or TxtSenha.Text = "" Then
                MsgBox("Preencha corretamente os campos antes de continuar!", vbExclamation + vbOKOnly, "Campos vazios")
            Else
                Sql = "select * from usuarios where email = '" & TxtUsuario.Text & "' and senha = '" & TxtSenha.Text & "'"
                Rs = Db.Execute(Sql)

                If Rs.EOF = False Then
                    UsuarioId = Rs.Fields(0).Value
                    UsuarioNome = Rs.Fields(1).Value
                    UsuarioTipo = Rs.Fields(3).Value
                    AlternarCamposLogin()
                    'MsgBox("Autenticação realizada com sucesso!", vbInformation + vbOKOnly, "Login bem sucedido")
                    'Axo que não precisa da Janela do Tipo
                    TxtSenha.Text = ""
                    TxtSenha.Select()
                    Me.Hide()
                Else
                    MsgBox("Usuário ou senha incorretos!", vbCritical + vbOKOnly, "Dados incorretos")
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub FrmUsuarioEntrar_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Enter Then
            BtnEntrar.PerformClick()
        End If
    End Sub

    Private Sub BtnEsqueceu_Click(sender As Object, e As EventArgs) Handles BtnEsqueceu.Click
        FrmUsuarioEsqueceu.ShowDialog()
    End Sub
End Class