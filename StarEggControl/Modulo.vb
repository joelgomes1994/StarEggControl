Module Modulo
    Public Db As New ADODB.Connection ' Variável do banco
    Public Rs As New ADODB.Recordset ' Variável da tabela
    Public Diretorio, Sql, Aux, Resp As String ' Query da tabela
    Public Conexao = Application.StartupPath & "\banco\staregg.mdb"
    Public UsuarioId, UsuarioNome, UsuarioTipo As String

    Sub ConectarBanco()
        Try
            Db = CreateObject("ADODB.Connection") ' String de conexão com o Access
            Db.Open("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" & Conexao)
        Catch ex As Exception
            MsgBox("Erro ao conectar ao banco de dados!", vbCritical + vbOKOnly, "Erro")
        End Try
    End Sub

    Sub AlternarCamposLogin()
        With FrmPrincipal
            If UsuarioTipo = "Gerente" Then
                .EstoqueToolStripMenuItem.Enabled = Not .EstoqueToolStripMenuItem.Enabled
                .RelatóriosToolStripMenuItem.Enabled = Not .RelatóriosToolStripMenuItem.Enabled

            ElseIf UsuarioTipo = "Estoquista" Then
                .EstoqueToolStripMenuItem.Enabled = Not .EstoqueToolStripMenuItem.Enabled
            End If

            .EntrarToolStripMenuItem.Enabled = Not .EntrarToolStripMenuItem.Enabled
            .DadosDoUsuárioToolStripMenuItem.Enabled = Not .DadosDoUsuárioToolStripMenuItem.Enabled
            .EncerrarSessãoToolStripMenuItem.Enabled = Not .EncerrarSessãoToolStripMenuItem.Enabled
        End With
    End Sub

    Sub AtualizarFrmUsuarioDados()
        Try
            With FrmUsuarioDados
                .CmbUsuario.Items.Clear()

                Sql = "select email from usuarios order by email"
                Rs = Db.Execute(Sql)

                Do While Rs.EOF = False
                    .CmbUsuario.Items.Add(Rs(0).Value)
                    Rs.MoveNext()
                Loop

                .CmbUsuario.Text = UsuarioNome

                If UsuarioTipo = "Administrador" Then
                    .CmbUsuario.Enabled = True
                    .CmbPermissoes.Enabled = True
                    .BtnLimpar.Enabled = True
                    .BtnNovo.Enabled = True
                    .TxtEmail.Enabled = True

                Else
                    .CmbUsuario.Enabled = False
                    .CmbPermissoes.Enabled = False
                    .BtnLimpar.Enabled = False
                    .BtnNovo.Enabled = False
                    .TxtEmail.Enabled = False

                End If
            End With
        Catch ex As Exception

        End Try
    End Sub

    Sub AtualizarListaProdutos(ByRef Cmb As Object)
        Try
            Cmb.Items.Clear()

            Sql = "select nome from produtos"
            Rs = Db.Execute(Sql)

            Do While Rs.EOF = False
                Cmb.Items.Add(Rs(0).Value)
                Rs.MoveNext()
            Loop

            Cmb.SelectedIndex = 0
        Catch ex As Exception

        End Try
    End Sub

    Sub RealizarLancamento(Lancamento As Array)
        Try
            Sql = "insert into lancamentos (Produto, Quantidade, Preco, Data, Tipo, Usuario) values " & vbNewLine _
                & "(" & Lancamento.GetValue(0) & "," & Lancamento.GetValue(1) & "," & Lancamento.GetValue(2) & ",NOW(),'" & Lancamento.GetValue(3) & "', " & UsuarioId & ")"
            Rs = Db.Execute(Sql)

            MsgBox("Lancamento Realizado Com Sucesso!")
            AtualizarQuantidadeEstoque()

        Catch ex As Exception
            Console.WriteLine(ex)
        End Try
    End Sub

    Sub AtualizarQuantidadeEstoque()
        With FrmEstoqueNovoLancamento
            Try
                Dim IdProduto As Integer
                Sql = "select id from produtos where nome='" & .CmbProduto.Text & "'"
                Rs = Db.Execute(Sql)

                If Not Rs.EOF Then
                    IdProduto = Rs.Fields(0).Value
                End If

                Sql = "select sum(r.quantidade) from " &
                      "(select iif(l.tipo='Saída', l.quantidade * -1, l.quantidade) as quantidade from lancamentos l " &
                      "where l.produto=" & IdProduto & ") r"
                Rs = Db.Execute(Sql)

                If Not Rs.EOF Then
                    If Not IsDBNull(Rs.Fields(0).Value) Then
                        .TxtEstoque.Text = Rs.Fields(0).Value
                        .TxtQuantidade.Maximum = IIf(.CmbTipo.Text = "Saída", Rs.Fields(0).Value, 99999)
                    Else
                        .TxtEstoque.Text = 0
                        .TxtQuantidade.Maximum = IIf(.CmbTipo.Text = "Saída", 0, 99999)
                    End If
                End If
            Catch ex As Exception

            End Try
        End With
    End Sub

End Module
