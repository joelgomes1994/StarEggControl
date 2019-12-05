Public Class FormRelatorio

    Sub PreencherDgRelatorio()
        Try
            Dim TotalQtdeEnt, TotalValorEnt, TotalQtdeSaida, TotalValorSaida, TotalQtdeSaldo, TotalValorSaldo As Double
            Dim LinhasLotes As New Collection
            Dim LoteAtual, LinhaAtual As Integer

            Sql = "SELECT l.data, l.tipo, p.nome, " &
                "IIf(l.tipo='Entrada',l.quantidade,'') AS qtdEnt, IIf(l.tipo='Entrada',l.preco,'') AS precoUnitEnt, IIf(l.tipo='Entrada',l.quantidade*l.preco,'') AS valorEnt, " &
                "IIf(l.tipo='Saída',l.quantidade,'') AS qtdSaida, IIf(l.tipo='Saída',l.preco,'') AS precoUnitSaida, IIf(l.tipo='Saída',l.quantidade*l.preco,'') AS valorSaida " &
                "FROM lancamentos AS l LEFT JOIN produtos AS p ON p.id = l.produto "

            If Not BtnProdutosTodos.Checked Then
                Sql &= " WHERE p.nome = '" & CmbProduto.Text & "'"
            End If

            Rs = Db.Execute(Sql)
            DgRelatorio.Rows.Clear()

            ' Adicionar linha do lançamento inicial
            DgRelatorio.Rows.Add("", "Saldo Inicial",
                                 IIf(BtnProdutosTodos.Checked, "", CmbProduto.Text),
                                 "", "", "", "", "", "", "0", "0", "0")

            ' Adicionar linha com os dados do banco
            Do While Not Rs.EOF
                LinhaAtual = DgRelatorio.Rows.Add(
                    Rs.Fields(0).Value,
                    Rs.Fields(1).Value,
                    Rs.Fields(2).Value,
                    Rs.Fields(3).Value,
                    Rs.Fields(4).Value,
                    Rs.Fields(5).Value,
                    Rs.Fields(6).Value,
                    Rs.Fields(7).Value,
                    Rs.Fields(8).Value
                    )
                If Rs.Fields(1).Value = "Entrada" Then
                    LoteAtual = LinhaAtual
                End If

                ' Alterar cor de fundo da linha de acordo com tipo Entrada/Saída
                With DgRelatorio.Rows(DgRelatorio.Rows.Count - 1).DefaultCellStyle
                    If Rs.Fields(1).Value = "Entrada" Then
                        .BackColor = Color.PaleGreen
                        LinhasLotes.Add(DgRelatorio.Rows(DgRelatorio.Rows.Count - 1).Index)
                    Else
                        .BackColor = Color.LightPink
                    End If
                End With

                ' Realizar os cálculos para Média Ponderada
                If CmbTipoRelatorio.Text = "Média Ponderada" Then

                    With DgRelatorio.Rows(DgRelatorio.Rows.Count - 1)

                        ' Qtde Saldo
                        .Cells(9).Value =
                            StrDbl(DgRelatorio.Rows(DgRelatorio.Rows.Count - 2).Cells(9).Value) _
                            + StrDbl(.Cells(3).Value) _
                            - StrDbl(.Cells(6).Value)

                        ' Valor Saldo
                        .Cells(11).Value =
                            Double.Parse(DgRelatorio.Rows(DgRelatorio.Rows.Count - 2).Cells(11).Value) _
                            + StrDbl(.Cells(5).Value) _
                            - StrDbl(.Cells(8).Value)

                        ' Preço Unit Saldo
                        .Cells(10).Value = Math.Round(
                            StrDbl(.Cells(11).Value) _
                            / StrDbl(.Cells(9).Value), 2)

                        TotalQtdeEnt += StrDbl(Rs.Fields(3).Value)
                        TotalValorEnt += StrDbl(Rs.Fields(5).Value)
                        TotalQtdeSaida += StrDbl(Rs.Fields(6).Value)
                        TotalValorSaida += StrDbl(Rs.Fields(8).Value)
                        TotalQtdeSaldo = StrDbl(DgRelatorio.Rows(DgRelatorio.Rows.Count - 1).Cells(9).Value)
                        TotalValorSaldo = StrDbl(DgRelatorio.Rows(DgRelatorio.Rows.Count - 1).Cells(11).Value)

                    End With

                    ' Realizar os cálculos para PEPS
                ElseIf CmbTipoRelatorio.Text = "PEPS" Then

                    If DgRelatorio.Rows(LinhaAtual).Cells(1).Value = "Entrada" Then

                        With DgRelatorio.Rows(DgRelatorio.Rows.Count - 1)
                            ' Qtde Saldo
                            .Cells(9).Value =
                                StrDbl(DgRelatorio.Rows(DgRelatorio.Rows.Count - 2).Cells(9).Value) _
                                + StrDbl(.Cells(3).Value) _
                                - StrDbl(.Cells(6).Value)

                            ' Valor Saldo
                            .Cells(11).Value =
                                Double.Parse(DgRelatorio.Rows(DgRelatorio.Rows.Count - 2).Cells(11).Value) _
                                + StrDbl(.Cells(5).Value) _
                                - StrDbl(.Cells(8).Value)

                            ' Preço Unit Saldo
                            .Cells(10).Value = Math.Round(
                                StrDbl(.Cells(11).Value) _
                                / StrDbl(.Cells(9).Value), 2)
                        End With
                    Else
                        With DgRelatorio.Rows(DgRelatorio.Rows.Count - 1)
                            For Each Row As DataGridViewRow In DgRelatorio.Rows
                                If Row.Cells(1).Value = "Entrada" And Row.Cells(0).ToolTipText <> "0" Then

                                End If
                            Next
                        End With
                    End If
                End If
                Rs.MoveNext()
            Loop

            ' Adicionar linha ao final com os totais
            DgRelatorio.Rows.Add(
                "", "Totais", "",
                TotalQtdeEnt, "", TotalValorEnt, TotalQtdeSaida, "", TotalValorSaida,
                TotalQtdeSaldo, "", TotalValorSaldo
                )

        Catch ex As Exception

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

    Private Sub CmbProduto_Click(sender As Object, e As EventArgs) Handles CmbProduto.Click

    End Sub

    Private Sub BtnExcel_Click(sender As Object, e As EventArgs) Handles BtnExcel.Click
        DgRelatorio.SelectAll()
        My.Computer.Clipboard.SetText(DgRelatorio.GetClipboardContent().GetText())
        DgRelatorio.ClearSelection()
        MsgBox("Relatório copiado para a área de transferência!" & vbNewLine &
               "Cole o conteúdo em uma planilha de Excel.", vbOKOnly + vbInformation, "Relatório exportado")
    End Sub

End Class