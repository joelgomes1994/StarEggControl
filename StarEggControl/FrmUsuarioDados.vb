Public Class FrmUsuarioDados
    Private Sub FrmUsuarioDados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AtualizarFrmUsuarioDados()
    End Sub

    Private Sub CmbUsuario_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CmbUsuario.SelectedIndexChanged
        Try
            Sql = "select * from usuarios where email = '" & CmbUsuario.Text & "'"
            Rs = Db.Execute(Sql)

            If Rs.EOF = False Then
                TxtId.Text = Rs(0).Value
                TxtEmail.Text = Rs(1).Value
                TxtSenha.Text = Rs(2).Value
                TxtSenhaRep.Text = Rs(2).Value
                CmbPermissoes.Text = Rs(3).Value
                TxtNome.Text = Rs(4).Value
                TxtCpf.Text = Rs(5).Value
                TxtTelRes.Text = Rs(6).Value
                TxtTelCel.Text = Rs(7).Value
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnAlterar_Click(sender As Object, e As EventArgs) Handles BtnAlterar.Click
        Try
            If TxtSenha.Text <> TxtSenhaRep.Text Then
                MsgBox("As senhas devem coincidir!", vbExclamation + vbOKOnly, "Senhas diferentes")
                TxtSenha.Select()
            ElseIf TxtId.Text = "" Then
                MsgBox("Nenhum usuário selecionado!", vbExclamation + vbOKOnly)
            Else
                If MsgBox("Confirma as alterações para o usuário atual?", vbQuestion + vbYesNo, "Cofirmar alterações") = vbYes Then
                    Sql = "select * from usuarios where id = " & TxtId.Text
                    Rs = Db.Execute(Sql)

                    If Rs.EOF = False Then
                        Sql = "update usuarios set email='" & TxtEmail.Text & "', senha='" & TxtSenha.Text &
                            "', tipo='" & CmbPermissoes.Text & "', nome='" & TxtNome.Text & "', cpf='" & TxtCpf.Text &
                            "', telres='" & TxtTelRes.Text & "', telcel='" & TxtTelCel.Text &
                            "' where id=" & TxtId.Text
                        Rs = Db.Execute(Sql)
                        MsgBox("Alterações realizados com sucesso.", vbInformation + vbOKOnly, "Alterações realizadas")
                        AtualizarFrmUsuarioDados()
                    End If
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub

    Private Sub BtnLimpar_Click(sender As Object, e As EventArgs) Handles BtnLimpar.Click
        TxtId.Text = ""
        TxtEmail.Text = ""
        TxtSenha.Text = ""
        TxtSenhaRep.Text = ""
        CmbPermissoes.Text = "Estoquista"
        TxtNome.Text = ""
        TxtCpf.Text = ""
        TxtTelRes.Text = ""
        TxtTelCel.Text = ""

        TxtEmail.Select()
    End Sub

    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles BtnNovo.Click
        Try
            If TxtId.Text <> "" Then
                MsgBox("Limpe os campos antes de cadastrar um novo usuário!", vbExclamation + vbOKOnly, "Usuário ainda selecionado")
            ElseIf TxtEmail.Text = "" Or TxtSenha.Text = "" Or TxtNome.Text = "" Or TxtCpf.Text = "" Then
                MsgBox("Preencha os campos corretamente!", vbExclamation + vbOKOnly, "Informações insuficientes")
            ElseIf TxtSenha.Text <> TxtSenhaRep.Text Then
                MsgBox("As senhas devem coincidir!", vbExclamation + vbOKOnly, "Senhas diferentes")
            Else
                If MsgBox("Cadastrar novo usuário com as informações fornecidas?", vbQuestion + vbYesNo, "Confirmar novo cadastro") = vbYes Then
                    Sql = "insert into usuarios (email, senha, tipo, nome, cpf, telres, telcel) values ('" &
                        TxtEmail.Text & "', '" & TxtSenha.Text & "', '" & CmbPermissoes.Text & "', '" &
                        TxtNome.Text & "', '" & TxtCpf.Text & "', '" & TxtTelRes.Text & "', '" & TxtTelCel.Text & "')"
                    Db.Execute(Sql)
                    MsgBox("Usuário cadastrado com sucesso.", vbInformation + vbOKOnly, "Cadastro bem sucedido")
                    AtualizarFrmUsuarioDados()
                End If
            End If
        Catch ex As Exception

        End Try
    End Sub
End Class