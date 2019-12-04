<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormRelatorio
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FormRelatorio))
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.CmbTipoRelatorio = New System.Windows.Forms.ToolStripComboBox()
        Me.CmbProduto = New System.Windows.Forms.ToolStripComboBox()
        Me.DgRelatorio = New System.Windows.Forms.DataGridView()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.RelatorioAtual = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BtnProdutosTodos = New System.Windows.Forms.ToolStripButton()
        Me.Data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Quantidade = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecoUnit = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecoTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoInicial = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecoAquisicao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Saidas = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoTotal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SaldoFinal = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DgRelatorio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.CmbTipoRelatorio, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.CmbProduto, Me.BtnProdutosTodos})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'CmbTipoRelatorio
        '
        Me.CmbTipoRelatorio.AutoCompleteCustomSource.AddRange(New String() {"Média Ponderada", "PEPS", "UEPS"})
        Me.CmbTipoRelatorio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTipoRelatorio.Items.AddRange(New Object() {"Média Ponderada", "PEPS", "UEPS"})
        Me.CmbTipoRelatorio.Name = "CmbTipoRelatorio"
        Me.CmbTipoRelatorio.Size = New System.Drawing.Size(150, 25)
        Me.CmbTipoRelatorio.ToolTipText = "Método de relatório"
        '
        'CmbProduto
        '
        Me.CmbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbProduto.Name = "CmbProduto"
        Me.CmbProduto.Size = New System.Drawing.Size(150, 25)
        '
        'DgRelatorio
        '
        Me.DgRelatorio.AllowUserToAddRows = False
        Me.DgRelatorio.AllowUserToDeleteRows = False
        Me.DgRelatorio.AllowUserToResizeColumns = False
        Me.DgRelatorio.AllowUserToResizeRows = False
        Me.DgRelatorio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgRelatorio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgRelatorio.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DgRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgRelatorio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Data, Me.Tipo, Me.Quantidade, Me.PrecoUnit, Me.PrecoTotal, Me.SaldoInicial, Me.PrecoAquisicao, Me.Saidas, Me.SaldoTotal, Me.SaldoFinal})
        Me.DgRelatorio.Location = New System.Drawing.Point(0, 28)
        Me.DgRelatorio.Name = "DgRelatorio"
        Me.DgRelatorio.ReadOnly = True
        Me.DgRelatorio.RowHeadersVisible = False
        Me.DgRelatorio.Size = New System.Drawing.Size(800, 394)
        Me.DgRelatorio.TabIndex = 1
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RelatorioAtual})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 425)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(800, 25)
        Me.ToolStrip2.TabIndex = 2
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'RelatorioAtual
        '
        Me.RelatorioAtual.Name = "RelatorioAtual"
        Me.RelatorioAtual.Size = New System.Drawing.Size(13, 22)
        Me.RelatorioAtual.Text = "-"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(33, 22)
        Me.ToolStripLabel1.Text = "Tipo"
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripLabel2.Text = "Produto"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BtnProdutosTodos
        '
        Me.BtnProdutosTodos.CheckOnClick = True
        Me.BtnProdutosTodos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.BtnProdutosTodos.Image = CType(resources.GetObject("BtnProdutosTodos.Image"), System.Drawing.Image)
        Me.BtnProdutosTodos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnProdutosTodos.Margin = New System.Windows.Forms.Padding(1)
        Me.BtnProdutosTodos.Name = "BtnProdutosTodos"
        Me.BtnProdutosTodos.Size = New System.Drawing.Size(47, 23)
        Me.BtnProdutosTodos.Text = "Todos"
        Me.BtnProdutosTodos.ToolTipText = "Mostrar relatório para todos os produtos"
        '
        'Data
        '
        Me.Data.HeaderText = "Data"
        Me.Data.Name = "Data"
        Me.Data.ReadOnly = True
        Me.Data.Width = 125
        '
        'Tipo
        '
        Me.Tipo.HeaderText = "Tipo"
        Me.Tipo.Name = "Tipo"
        Me.Tipo.ReadOnly = True
        '
        'Quantidade
        '
        Me.Quantidade.HeaderText = "Quantidade"
        Me.Quantidade.Name = "Quantidade"
        Me.Quantidade.ReadOnly = True
        '
        'PrecoUnit
        '
        Me.PrecoUnit.HeaderText = "Preço Unitário"
        Me.PrecoUnit.Name = "PrecoUnit"
        Me.PrecoUnit.ReadOnly = True
        '
        'PrecoTotal
        '
        Me.PrecoTotal.HeaderText = "Preço Total"
        Me.PrecoTotal.Name = "PrecoTotal"
        Me.PrecoTotal.ReadOnly = True
        '
        'SaldoInicial
        '
        Me.SaldoInicial.HeaderText = "Saldo Inicial"
        Me.SaldoInicial.Name = "SaldoInicial"
        Me.SaldoInicial.ReadOnly = True
        '
        'PrecoAquisicao
        '
        Me.PrecoAquisicao.HeaderText = "Preço de Aquisição"
        Me.PrecoAquisicao.Name = "PrecoAquisicao"
        Me.PrecoAquisicao.ReadOnly = True
        '
        'Saidas
        '
        Me.Saidas.HeaderText = "Saídas"
        Me.Saidas.Name = "Saidas"
        Me.Saidas.ReadOnly = True
        '
        'SaldoTotal
        '
        Me.SaldoTotal.HeaderText = "Saldo Total"
        Me.SaldoTotal.Name = "SaldoTotal"
        Me.SaldoTotal.ReadOnly = True
        '
        'SaldoFinal
        '
        Me.SaldoFinal.HeaderText = "Saldo Final"
        Me.SaldoFinal.Name = "SaldoFinal"
        Me.SaldoFinal.ReadOnly = True
        '
        'FormRelatorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.DgRelatorio)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "FormRelatorio"
        Me.Text = "Relatórios"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        CType(Me.DgRelatorio, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents CmbTipoRelatorio As ToolStripComboBox
    Friend WithEvents DgRelatorio As DataGridView
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents RelatorioAtual As ToolStripLabel
    Friend WithEvents CmbProduto As ToolStripComboBox
    Friend WithEvents ToolStripLabel1 As ToolStripLabel
    Friend WithEvents ToolStripLabel2 As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents BtnProdutosTodos As ToolStripButton
    Friend WithEvents Data As DataGridViewTextBoxColumn
    Friend WithEvents Tipo As DataGridViewTextBoxColumn
    Friend WithEvents Quantidade As DataGridViewTextBoxColumn
    Friend WithEvents PrecoUnit As DataGridViewTextBoxColumn
    Friend WithEvents PrecoTotal As DataGridViewTextBoxColumn
    Friend WithEvents SaldoInicial As DataGridViewTextBoxColumn
    Friend WithEvents PrecoAquisicao As DataGridViewTextBoxColumn
    Friend WithEvents Saidas As DataGridViewTextBoxColumn
    Friend WithEvents SaldoTotal As DataGridViewTextBoxColumn
    Friend WithEvents SaldoFinal As DataGridViewTextBoxColumn
End Class
