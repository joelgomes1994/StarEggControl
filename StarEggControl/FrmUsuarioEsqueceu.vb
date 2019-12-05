Public Class FrmUsuarioEsqueceu
    Private Sub BtnRedefinir_Click(sender As Object, e As EventArgs) Handles BtnRedefinir.Click
        If TxtEmail.Text = "" Or TxtCpf.Text = "" Or TxtTelRes.Text = "" Or TxtTelCel.Text = "" Then
            MsgBox("Preencha todos os campos corretamente!", vbOKOnly + vbCritical, "Campos não preenchidos")
        Else
            Try
                Sql = "select * from usuarios u where u.email='" & TxtEmail.Text & "' " &
                    "and u.cpf='" & TxtCpf.Text & "' " &
                    "and u.telres='" & TxtTelRes.Text & "' " &
                    "and u.telcel='" & TxtTelCel.Text & "' "
                Rs = Db.Execute(Sql)

                If Not Rs.EOF Then
                    Sql = "update usuarios u set u.senha='1111' where u.email='" & TxtEmail.Text & "' " &
                        "and u.cpf='" & TxtCpf.Text & "' " &
                        "and u.telres='" & TxtTelRes.Text & "' " &
                        "and u.telcel='" & TxtTelCel.Text & "' "
                    Db.Execute(Sql)
                    MsgBox("Senha redefinida para 1111, entre e altere-a.", vbOKOnly + vbInformation, "Senha redefinida")
                    TxtEmail.Text = ""
                    TxtCpf.Text = ""
                    TxtTelRes.Text = ""
                    TxtTelCel.Text = ""
                    Me.Hide()
                Else
                    MsgBox("Informações incorretas! Tente novamente." & vbNewLine & Sql, vbOKOnly + vbExclamation, "Informações incorretas")
                End If
            Catch ex As Exception

            End Try
        End If
    End Sub
End Class