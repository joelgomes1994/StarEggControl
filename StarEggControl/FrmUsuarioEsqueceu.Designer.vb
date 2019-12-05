<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmUsuarioEsqueceu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmUsuarioEsqueceu))
        Me.TxtTelCel = New System.Windows.Forms.MaskedTextBox()
        Me.TxtTelRes = New System.Windows.Forms.MaskedTextBox()
        Me.TxtCpf = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtEmail = New System.Windows.Forms.TextBox()
        Me.BtnRedefinir = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'TxtTelCel
        '
        Me.TxtTelCel.Location = New System.Drawing.Point(260, 100)
        Me.TxtTelCel.Mask = "(00) 00000-0000"
        Me.TxtTelCel.Name = "TxtTelCel"
        Me.TxtTelCel.Size = New System.Drawing.Size(108, 20)
        Me.TxtTelCel.TabIndex = 30
        '
        'TxtTelRes
        '
        Me.TxtTelRes.Location = New System.Drawing.Point(80, 100)
        Me.TxtTelRes.Mask = "(00) 0000-0000"
        Me.TxtTelRes.Name = "TxtTelRes"
        Me.TxtTelRes.Size = New System.Drawing.Size(108, 20)
        Me.TxtTelRes.TabIndex = 29
        '
        'TxtCpf
        '
        Me.TxtCpf.Location = New System.Drawing.Point(80, 74)
        Me.TxtCpf.Mask = "000,000,000-00"
        Me.TxtCpf.Name = "TxtCpf"
        Me.TxtCpf.Size = New System.Drawing.Size(288, 20)
        Me.TxtCpf.TabIndex = 28
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(213, 103)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(39, 13)
        Me.Label7.TabIndex = 27
        Me.Label7.Text = "Celular"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(10, 103)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(49, 13)
        Me.Label8.TabIndex = 26
        Me.Label8.Text = "Telefone"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(10, 77)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(27, 13)
        Me.Label6.TabIndex = 25
        Me.Label6.Text = "CPF"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(10, 51)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 13)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "E-mail"
        '
        'TxtEmail
        '
        Me.TxtEmail.Location = New System.Drawing.Point(80, 48)
        Me.TxtEmail.Name = "TxtEmail"
        Me.TxtEmail.Size = New System.Drawing.Size(288, 20)
        Me.TxtEmail.TabIndex = 23
        '
        'BtnRedefinir
        '
        Me.BtnRedefinir.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnRedefinir.Location = New System.Drawing.Point(13, 136)
        Me.BtnRedefinir.Name = "BtnRedefinir"
        Me.BtnRedefinir.Size = New System.Drawing.Size(355, 23)
        Me.BtnRedefinir.TabIndex = 31
        Me.BtnRedefinir.Text = "Redefinir senha"
        Me.BtnRedefinir.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(22, 9)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(333, 26)
        Me.Label2.TabIndex = 32
        Me.Label2.Text = "Digite corretamente o seu e-mail e as informações da sua conta para " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "redefinir s" &
    "ua senha."
        '
        'FrmUsuarioEsqueceu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(380, 168)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.BtnRedefinir)
        Me.Controls.Add(Me.TxtTelCel)
        Me.Controls.Add(Me.TxtTelRes)
        Me.Controls.Add(Me.TxtCpf)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TxtEmail)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "FrmUsuarioEsqueceu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Redefinição de senha"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TxtTelCel As MaskedTextBox
    Friend WithEvents TxtTelRes As MaskedTextBox
    Friend WithEvents TxtCpf As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtEmail As TextBox
    Friend WithEvents BtnRedefinir As Button
    Friend WithEvents Label2 As Label
End Class
