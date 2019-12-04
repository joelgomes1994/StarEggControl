<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmEstoqueProduto
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmEstoqueProduto))
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.BtnNovo = New System.Windows.Forms.Button()
        Me.BtnAlterar = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.CmbProduto = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtDescricao = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(12, 103)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TxtId.Size = New System.Drawing.Size(25, 20)
        Me.TxtId.TabIndex = 44
        Me.TxtId.Visible = False
        '
        'BtnLimpar
        '
        Me.BtnLimpar.Location = New System.Drawing.Point(12, 152)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(85, 23)
        Me.BtnLimpar.TabIndex = 40
        Me.BtnLimpar.Text = "Limpar"
        Me.BtnLimpar.UseVisualStyleBackColor = True
        '
        'BtnNovo
        '
        Me.BtnNovo.Location = New System.Drawing.Point(103, 152)
        Me.BtnNovo.Name = "BtnNovo"
        Me.BtnNovo.Size = New System.Drawing.Size(87, 23)
        Me.BtnNovo.TabIndex = 39
        Me.BtnNovo.Text = "Novo cadastro"
        Me.BtnNovo.UseVisualStyleBackColor = True
        '
        'BtnAlterar
        '
        Me.BtnAlterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAlterar.Location = New System.Drawing.Point(196, 152)
        Me.BtnAlterar.Name = "BtnAlterar"
        Me.BtnAlterar.Size = New System.Drawing.Size(174, 23)
        Me.BtnAlterar.TabIndex = 38
        Me.BtnAlterar.Text = "Alterar dados"
        Me.BtnAlterar.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(9, 42)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 34
        Me.Label5.Text = "Nome"
        '
        'TxtNome
        '
        Me.TxtNome.Location = New System.Drawing.Point(79, 39)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(286, 20)
        Me.TxtNome.TabIndex = 33
        '
        'CmbProduto
        '
        Me.CmbProduto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbProduto.FormattingEnabled = True
        Me.CmbProduto.Location = New System.Drawing.Point(12, 12)
        Me.CmbProduto.Name = "CmbProduto"
        Me.CmbProduto.Size = New System.Drawing.Size(355, 21)
        Me.CmbProduto.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(9, 68)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(55, 13)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "Descrição"
        '
        'TxtDescricao
        '
        Me.TxtDescricao.Location = New System.Drawing.Point(79, 65)
        Me.TxtDescricao.Multiline = True
        Me.TxtDescricao.Name = "TxtDescricao"
        Me.TxtDescricao.Size = New System.Drawing.Size(288, 72)
        Me.TxtDescricao.TabIndex = 45
        '
        'FrmEstoqueProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(377, 183)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtDescricao)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.BtnLimpar)
        Me.Controls.Add(Me.BtnNovo)
        Me.Controls.Add(Me.BtnAlterar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtNome)
        Me.Controls.Add(Me.CmbProduto)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmEstoqueProduto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Produtos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtId As TextBox
    Friend WithEvents BtnLimpar As Button
    Friend WithEvents BtnNovo As Button
    Friend WithEvents BtnAlterar As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtNome As TextBox
    Friend WithEvents CmbProduto As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtDescricao As TextBox
End Class
