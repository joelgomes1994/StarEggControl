<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmUsuarioDados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsuarioDados))
        Me.CmbUsuario = New System.Windows.Forms.ComboBox()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TxtSenha = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtSenhaRep = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.CmbPermissoes = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtNome = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.BtnAlterar = New System.Windows.Forms.Button()
        Me.BtnNovo = New System.Windows.Forms.Button()
        Me.BtnLimpar = New System.Windows.Forms.Button()
        Me.TxtCpf = New System.Windows.Forms.MaskedTextBox()
        Me.TxtTelRes = New System.Windows.Forms.MaskedTextBox()
        Me.TxtTelCel = New System.Windows.Forms.MaskedTextBox()
        Me.TxtId = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'CmbUsuario
        '
        Me.CmbUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbUsuario.Enabled = False
        Me.CmbUsuario.FormattingEnabled = True
        Me.CmbUsuario.Location = New System.Drawing.Point(15, 12)
        Me.CmbUsuario.Name = "CmbUsuario"
        Me.CmbUsuario.Size = New System.Drawing.Size(355, 21)
        Me.CmbUsuario.TabIndex = 0
        '
        'TxtEmail
        '
        Me.TxtEmail.Enabled = False
        Me.TxtEmail.Location = New System.Drawing.Point(82, 43)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(288, 20)
        Me.TxtEmail.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "E-mail"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(38, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Senha"
        '
        'TxtSenha
        '
        Me.TxtSenha.Location = New System.Drawing.Point(82, 69)
        Me.TxtSenha.Name = "TxtSenha"
        Me.TxtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TxtSenha.Size = New System.Drawing.Size(108, 20)
        Me.TxtSenha.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(215, 72)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(41, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Repetir"
        '
        'TxtSenhaRep
        '
        Me.TxtSenhaRep.Location = New System.Drawing.Point(262, 69)
        Me.TxtSenhaRep.Name = "TxtSenhaRep"
        Me.TxtSenhaRep.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TxtSenhaRep.Size = New System.Drawing.Size(108, 20)
        Me.TxtSenhaRep.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(12, 98)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Permissões"
        '
        'CmbPermissoes
        '
        Me.CmbPermissoes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CmbPermissoes.Enabled = False
        Me.CmbPermissoes.FormattingEnabled = True
        Me.CmbPermissoes.Items.AddRange(New Object() {"Administrador", "Gerente", "Estoquista"})
        Me.CmbPermissoes.Location = New System.Drawing.Point(82, 95)
        Me.CmbPermissoes.Name = "CmbPermissoes"
        Me.CmbPermissoes.Size = New System.Drawing.Size(288, 21)
        Me.CmbPermissoes.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(12, 125)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(35, 13)
        Me.Label5.TabIndex = 10
        Me.Label5.Text = "Nome"
        '
        'TxtNome
        '
        Me.TxtNome.Location = New System.Drawing.Point(82, 122)
        Me.TxtNome.Name = "TxtNome"
        Me.TxtNome.Size = New System.Drawing.Size(288, 20)
        Me.TxtNome.TabIndex = 9
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 151)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 12
        Me.Label6.Text = "CPF"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(215, 177)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Celular"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(12, 177)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "Telefone"
        '
        'BtnAlterar
        '
        Me.BtnAlterar.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnAlterar.Location = New System.Drawing.Point(196, 209)
        Me.BtnAlterar.Name = "BtnAlterar"
        Me.BtnAlterar.Size = New System.Drawing.Size(174, 23)
        Me.BtnAlterar.TabIndex = 17
        Me.BtnAlterar.Text = "Alterar dados"
        Me.BtnAlterar.UseVisualStyleBackColor = True
        '
        'BtnNovo
        '
        Me.BtnNovo.Enabled = False
        Me.BtnNovo.Location = New System.Drawing.Point(103, 209)
        Me.BtnNovo.Name = "BtnNovo"
        Me.BtnNovo.Size = New System.Drawing.Size(87, 23)
        Me.BtnNovo.TabIndex = 18
        Me.BtnNovo.Text = "Novo cadastro"
        Me.BtnNovo.UseVisualStyleBackColor = True
        '
        'BtnLimpar
        '
        Me.BtnLimpar.Enabled = False
        Me.BtnLimpar.Location = New System.Drawing.Point(12, 209)
        Me.BtnLimpar.Name = "BtnLimpar"
        Me.BtnLimpar.Size = New System.Drawing.Size(85, 23)
        Me.BtnLimpar.TabIndex = 19
        Me.BtnLimpar.Text = "Limpar"
        Me.BtnLimpar.UseVisualStyleBackColor = True
        '
        'TxtCpf
        '
        Me.TxtCpf.Location = New System.Drawing.Point(82, 148)
        Me.TxtCpf.Mask = "000,000,000-00"
        Me.TxtCpf.Name = "TxtCpf"
        Me.TxtCpf.Size = New System.Drawing.Size(288, 20)
        Me.TxtCpf.TabIndex = 20
        '
        'TxtTelRes
        '
        Me.TxtTelRes.Location = New System.Drawing.Point(82, 174)
        Me.TxtTelRes.Mask = "(00) 0000-0000"
        Me.TxtTelRes.Name = "TxtTelRes"
        Me.TxtTelRes.Size = New System.Drawing.Size(108, 20)
        Me.TxtTelRes.TabIndex = 21
        '
        'TxtTelCel
        '
        Me.TxtTelCel.Location = New System.Drawing.Point(262, 174)
        Me.TxtTelCel.Mask = "(00) 00000-0000"
        Me.TxtTelCel.Name = "TxtTelCel"
        Me.TxtTelCel.Size = New System.Drawing.Size(108, 20)
        Me.TxtTelCel.TabIndex = 22
        '
        'TxtId
        '
        Me.TxtId.Location = New System.Drawing.Point(363, 200)
        Me.TxtId.Name = "TxtId"
        Me.TxtId.PasswordChar = Global.Microsoft.VisualBasic.ChrW(8226)
        Me.TxtId.Size = New System.Drawing.Size(25, 20)
        Me.TxtId.TabIndex = 23
        Me.TxtId.Visible = False
        '
        'FrmUsuarioDados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(382, 240)
        Me.Controls.Add(Me.TxtId)
        Me.Controls.Add(Me.TxtTelCel)
        Me.Controls.Add(Me.TxtTelRes)
        Me.Controls.Add(Me.TxtCpf)
        Me.Controls.Add(Me.BtnLimpar)
        Me.Controls.Add(Me.BtnNovo)
        Me.Controls.Add(Me.BtnAlterar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TxtNome)
        Me.Controls.Add(Me.CmbPermissoes)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TxtSenhaRep)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TxtSenha)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtEmail)
        Me.Controls.Add(Me.CmbUsuario)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmUsuarioDados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dados de usuário"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents CmbUsuario As ComboBox
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents TxtSenha As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtSenhaRep As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents CmbPermissoes As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtNome As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents BtnAlterar As Button
    Friend WithEvents BtnNovo As Button
    Friend WithEvents BtnLimpar As Button
    Friend WithEvents TxtCpf As MaskedTextBox
    Friend WithEvents TxtTelRes As MaskedTextBox
    Friend WithEvents TxtTelCel As MaskedTextBox
    Friend WithEvents TxtId As TextBox
End Class
