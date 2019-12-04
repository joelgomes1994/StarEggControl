Public Class FormRelatorios

    Private tipoRelatorio As String
    Private listaRelatorio As ArrayList

    Private Sub Relatorio()
        Dim Sql = "select * from lancamentos"
        Rs = Db.Execute(Sql)

        Do While Rs.EOF
            listaRelatorio.Add({
                               Rs.Fields(0).Value,
                               Rs.Fields(1).Value,
                               Rs.Fields(2).Value,
                               Rs.Fields(3).Value,
                               Rs.Fields(4).Value,
                               Rs.Fields(5).Value,
                               Rs.Fields(6).Value
                               })
        Loop

    End Sub




    Public Sub New(tipo As String)
        InitializeComponent()


        tipoRelatorio = tipo ' Qual tipo de relatorio sera gerado?
        listaRelatorio = New ArrayList ' Inicializando a lista!

        Relatorio()

    End Sub

End Class