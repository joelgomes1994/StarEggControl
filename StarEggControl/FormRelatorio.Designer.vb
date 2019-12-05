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
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.CmbTipoRelatorio = New System.Windows.Forms.ToolStripComboBox()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.ToolStripLabel2 = New System.Windows.Forms.ToolStripLabel()
        Me.CmbProduto = New System.Windows.Forms.ToolStripComboBox()
        Me.BtnProdutosTodos = New System.Windows.Forms.ToolStripButton()
        Me.BtnExcel = New System.Windows.Forms.ToolStripButton()
        Me.DgRelatorio = New System.Windows.Forms.DataGridView()
        Me.Data = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Tipo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Produto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtdeEntrada = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecoUnitEnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorEnt = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtdeSaida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecoUnitSaida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorSaida = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtdeSaldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecoUnitSaldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ValorSaldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.RelatorioAtual = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip1.SuspendLayout()
        CType(Me.DgRelatorio, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.ToolStrip2.SuspendLayout()
        Me.SuspendLayout()
        '
        'ToolStrip1
        '
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripLabel1, Me.CmbTipoRelatorio, Me.ToolStripSeparator1, Me.ToolStripLabel2, Me.CmbProduto, Me.BtnProdutosTodos, Me.BtnExcel})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 0)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(819, 25)
        Me.ToolStrip1.TabIndex = 0
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(33, 22)
        Me.ToolStripLabel1.Text = "Tipo"
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
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'ToolStripLabel2
        '
        Me.ToolStripLabel2.Name = "ToolStripLabel2"
        Me.ToolStripLabel2.Size = New System.Drawing.Size(52, 22)
        Me.ToolStripLabel2.Text = "Produto"
        '
        'CmbProduto
        '
        Me.CmbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbProduto.Name = "CmbProduto"
        Me.CmbProduto.Size = New System.Drawing.Size(150, 25)
        '
        'BtnProdutosTodos
        '
        Me.BtnProdutosTodos.CheckOnClick = True
        Me.BtnProdutosTodos.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnProdutosTodos.Image = CType(resources.GetObject("BtnProdutosTodos.Image"), System.Drawing.Image)
        Me.BtnProdutosTodos.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnProdutosTodos.Margin = New System.Windows.Forms.Padding(1)
        Me.BtnProdutosTodos.Name = "BtnProdutosTodos"
        Me.BtnProdutosTodos.Size = New System.Drawing.Size(23, 23)
        Me.BtnProdutosTodos.Text = "Todos"
        Me.BtnProdutosTodos.ToolTipText = "Mostrar relatório para todos os produtos"
        '
        'BtnExcel
        '
        Me.BtnExcel.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BtnExcel.Image = CType(resources.GetObject("BtnExcel.Image"), System.Drawing.Image)
        Me.BtnExcel.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.BtnExcel.Margin = New System.Windows.Forms.Padding(1)
        Me.BtnExcel.Name = "BtnExcel"
        Me.BtnExcel.Size = New System.Drawing.Size(23, 23)
        Me.BtnExcel.Text = "Excel"
        Me.BtnExcel.ToolTipText = "Copiar relatório para a área de transferência, permitindo colar como planilha de " &
    "Excel."
        '
        'DgRelatorio
        '
        Me.DgRelatorio.AllowUserToAddRows = False
        Me.DgRelatorio.AllowUserToDeleteRows = False
        Me.DgRelatorio.AllowUserToResizeRows = False
        Me.DgRelatorio.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgRelatorio.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DgRelatorio.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.EnableAlwaysIncludeHeaderText
        Me.DgRelatorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgRelatorio.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Data, Me.Tipo, Me.Produto, Me.QtdeEntrada, Me.PrecoUnitEnt, Me.ValorEnt, Me.QtdeSaida, Me.PrecoUnitSaida, Me.ValorSaida, Me.QtdeSaldo, Me.PrecoUnitSaldo, Me.ValorSaldo})
        Me.DgRelatorio.Location = New System.Drawing.Point(0, 28)
        Me.DgRelatorio.Name = "DgRelatorio"
        Me.DgRelatorio.ReadOnly = True
        Me.DgRelatorio.RowHeadersVisible = False
        Me.DgRelatorio.Size = New System.Drawing.Size(819, 394)
        Me.DgRelatorio.TabIndex = 1
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
        Me.Tipo.Width = 80
        '
        'Produto
        '
        Me.Produto.HeaderText = "Produto"
        Me.Produto.Name = "Produto"
        Me.Produto.ReadOnly = True
        Me.Produto.Width = 150
        '
        'QtdeEntrada
        '
        Me.QtdeEntrada.HeaderText = "Qtde Ent"
        Me.QtdeEntrada.Name = "QtdeEntrada"
        Me.QtdeEntrada.ReadOnly = True
        Me.QtdeEntrada.Width = 90
        '
        'PrecoUnitEnt
        '
        Me.PrecoUnitEnt.HeaderText = "Preço Unit Ent"
        Me.PrecoUnitEnt.Name = "PrecoUnitEnt"
        Me.PrecoUnitEnt.ReadOnly = True
        Me.PrecoUnitEnt.Width = 120
        '
        'ValorEnt
        '
        Me.ValorEnt.HeaderText = "Valor Ent"
        Me.ValorEnt.Name = "ValorEnt"
        Me.ValorEnt.ReadOnly = True
        '
        'QtdeSaida
        '
        Me.QtdeSaida.HeaderText = "Qtde Saida"
        Me.QtdeSaida.Name = "QtdeSaida"
        Me.QtdeSaida.ReadOnly = True
        Me.QtdeSaida.Width = 90
        '
        'PrecoUnitSaida
        '
        Me.PrecoUnitSaida.HeaderText = "Preço Unit Saída"
        Me.PrecoUnitSaida.Name = "PrecoUnitSaida"
        Me.PrecoUnitSaida.ReadOnly = True
        Me.PrecoUnitSaida.Width = 120
        '
        'ValorSaida
        '
        Me.ValorSaida.HeaderText = "Valor Saída"
        Me.ValorSaida.Name = "ValorSaida"
        Me.ValorSaida.ReadOnly = True
        '
        'QtdeSaldo
        '
        Me.QtdeSaldo.HeaderText = "Qtde Saldo"
        Me.QtdeSaldo.Name = "QtdeSaldo"
        Me.QtdeSaldo.ReadOnly = True
        Me.QtdeSaldo.Width = 90
        '
        'PrecoUnitSaldo
        '
        Me.PrecoUnitSaldo.HeaderText = "Preço Unit Saldo"
        Me.PrecoUnitSaldo.Name = "PrecoUnitSaldo"
        Me.PrecoUnitSaldo.ReadOnly = True
        Me.PrecoUnitSaldo.Width = 120
        '
        'ValorSaldo
        '
        Me.ValorSaldo.HeaderText = "Valor Saldo"
        Me.ValorSaldo.Name = "ValorSaldo"
        Me.ValorSaldo.ReadOnly = True
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RelatorioAtual})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 425)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(819, 25)
        Me.ToolStrip2.TabIndex = 2
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'RelatorioAtual
        '
        Me.RelatorioAtual.Name = "RelatorioAtual"
        Me.RelatorioAtual.Size = New System.Drawing.Size(13, 22)
        Me.RelatorioAtual.Text = "-"
        '
        'FormRelatorio
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(819, 450)
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
    Friend WithEvents Produto As DataGridViewTextBoxColumn
    Friend WithEvents QtdeEntrada As DataGridViewTextBoxColumn
    Friend WithEvents PrecoUnitEnt As DataGridViewTextBoxColumn
    Friend WithEvents ValorEnt As DataGridViewTextBoxColumn
    Friend WithEvents QtdeSaida As DataGridViewTextBoxColumn
    Friend WithEvents PrecoUnitSaida As DataGridViewTextBoxColumn
    Friend WithEvents ValorSaida As DataGridViewTextBoxColumn
    Friend WithEvents QtdeSaldo As DataGridViewTextBoxColumn
    Friend WithEvents PrecoUnitSaldo As DataGridViewTextBoxColumn
    Friend WithEvents ValorSaldo As DataGridViewTextBoxColumn
    Friend WithEvents BtnExcel As ToolStripButton
End Class
