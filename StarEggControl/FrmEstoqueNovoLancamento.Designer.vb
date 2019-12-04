<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmEstoqueNovoLancamento
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEstoqueNovoLancamento))
        Me.CmbProduto = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtQuantidade = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label = New System.Windows.Forms.Label()
        Me.CmbTipo = New System.Windows.Forms.ComboBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TxtPrecoTotal = New System.Windows.Forms.TextBox()
        Me.TxtPrecoUnid = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.BtnLancar = New System.Windows.Forms.Button()
        Me.TxtEstoque = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        CType(Me.TxtQuantidade, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'CmbProduto
        '
        Me.CmbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbProduto.FormattingEnabled = True
        Me.CmbProduto.Location = New System.Drawing.Point(86, 12)
        Me.CmbProduto.Name = "CmbProduto"
        Me.CmbProduto.Size = New System.Drawing.Size(249, 21)
        Me.CmbProduto.TabIndex = 25
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 15)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(44, 13)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Produto"
        '
        'TxtQuantidade
        '
        Me.TxtQuantidade.Location = New System.Drawing.Point(86, 69)
        Me.TxtQuantidade.Maximum = New Decimal(New Integer() {99999, 0, 0, 0})
        Me.TxtQuantidade.Name = "TxtQuantidade"
        Me.TxtQuantidade.Size = New System.Drawing.Size(76, 20)
        Me.TxtQuantidade.TabIndex = 27
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 28
        Me.Label2.Text = "Quantidade"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 13)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "Unidade R$"
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.Location = New System.Drawing.Point(12, 42)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(28, 13)
        Me.Label.TabIndex = 32
        Me.Label.Text = "Tipo"
        '
        'CmbTipo
        '
        Me.CmbTipo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbTipo.FormattingEnabled = True
        Me.CmbTipo.Items.AddRange(New Object() {"Entrada", "Saída"})
        Me.CmbTipo.Location = New System.Drawing.Point(86, 39)
        Me.CmbTipo.Name = "CmbTipo"
        Me.CmbTipo.Size = New System.Drawing.Size(249, 21)
        Me.CmbTipo.TabIndex = 31
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.TxtPrecoTotal)
        Me.GroupBox1.Controls.Add(Me.TxtPrecoUnid)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Location = New System.Drawing.Point(15, 95)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(320, 51)
        Me.GroupBox1.TabIndex = 33
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Preço"
        '
        'TxtPrecoTotal
        '
        Me.TxtPrecoTotal.BackColor = System.Drawing.Color.White
        Me.TxtPrecoTotal.Location = New System.Drawing.Point(220, 19)
        Me.TxtPrecoTotal.Name = "TxtPrecoTotal"
        Me.TxtPrecoTotal.ReadOnly = True
        Me.TxtPrecoTotal.Size = New System.Drawing.Size(94, 20)
        Me.TxtPrecoTotal.TabIndex = 33
        Me.TxtPrecoTotal.Text = "0,00"
        '
        'TxtPrecoUnid
        '
        Me.TxtPrecoUnid.BackColor = System.Drawing.Color.White
        Me.TxtPrecoUnid.Location = New System.Drawing.Point(76, 19)
        Me.TxtPrecoUnid.Name = "TxtPrecoUnid"
        Me.TxtPrecoUnid.Size = New System.Drawing.Size(71, 20)
        Me.TxtPrecoUnid.TabIndex = 32
        Me.TxtPrecoUnid.Text = "0,00"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(166, 22)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(48, 13)
        Me.Label4.TabIndex = 31
        Me.Label4.Text = "Total R$"
        '
        'BtnLancar
        '
        Me.BtnLancar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnLancar.Location = New System.Drawing.Point(15, 152)
        Me.BtnLancar.Name = "BtnLancar"
        Me.BtnLancar.Size = New System.Drawing.Size(320, 23)
        Me.BtnLancar.TabIndex = 34
        Me.BtnLancar.Text = "Lancar"
        Me.BtnLancar.UseVisualStyleBackColor = True
        '
        'TxtEstoque
        '
        Me.TxtEstoque.BackColor = System.Drawing.Color.White
        Me.TxtEstoque.Location = New System.Drawing.Point(235, 69)
        Me.TxtEstoque.Name = "TxtEstoque"
        Me.TxtEstoque.ReadOnly = True
        Me.TxtEstoque.Size = New System.Drawing.Size(100, 20)
        Me.TxtEstoque.TabIndex = 36
        Me.TxtEstoque.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(183, 71)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 35
        Me.Label7.Text = "Estoque"
        '
        'FrmEstoqueNovoLancamento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(342, 183)
        Me.Controls.Add(Me.TxtEstoque)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.BtnLancar)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.CmbTipo)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtQuantidade)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CmbProduto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmEstoqueNovoLancamento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Novo lançamento"
        CType(Me.TxtQuantidade, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbProduto As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtQuantidade As NumericUpDown
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label As Label
    Friend WithEvents CmbTipo As ComboBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TxtPrecoTotal As TextBox
    Friend WithEvents TxtPrecoUnid As TextBox
    Friend WithEvents BtnLancar As Button
    Friend WithEvents TxtEstoque As TextBox
    Friend WithEvents Label7 As Label
End Class
