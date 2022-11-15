<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCadastraFornecedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCadastraFornecedor))
        Me.txtCep = New System.Windows.Forms.MaskedTextBox()
        Me.txtFone = New System.Windows.Forms.MaskedTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtRamo = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnCadastrar = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.txtProdutoFornecido = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtCep
        '
        Me.txtCep.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.txtCep.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txtCep.Location = New System.Drawing.Point(758, 427)
        Me.txtCep.Mask = "00000-000"
        Me.txtCep.Name = "txtCep"
        Me.txtCep.Size = New System.Drawing.Size(185, 20)
        Me.txtCep.TabIndex = 63
        '
        'txtFone
        '
        Me.txtFone.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.txtFone.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txtFone.Location = New System.Drawing.Point(553, 427)
        Me.txtFone.Mask = "(99) 00000-0000"
        Me.txtFone.Name = "txtFone"
        Me.txtFone.Size = New System.Drawing.Size(185, 20)
        Me.txtFone.TabIndex = 62
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(755, 406)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 13)
        Me.Label9.TabIndex = 58
        Me.Label9.Text = "Código Postal (CEP)"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(550, 406)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(49, 13)
        Me.Label10.TabIndex = 57
        Me.Label10.Text = "Telefone"
        '
        'txtRamo
        '
        Me.txtRamo.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.txtRamo.Font = New System.Drawing.Font("Bahnschrift", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRamo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txtRamo.Location = New System.Drawing.Point(553, 228)
        Me.txtRamo.Name = "txtRamo"
        Me.txtRamo.Size = New System.Drawing.Size(390, 24)
        Me.txtRamo.TabIndex = 54
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(550, 208)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(93, 13)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Ramo de Atuação"
        '
        'txtNome
        '
        Me.txtNome.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.txtNome.Font = New System.Drawing.Font("Bahnschrift", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txtNome.Location = New System.Drawing.Point(553, 161)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(390, 24)
        Me.txtNome.TabIndex = 52
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(550, 141)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 51
        Me.Label4.Text = "Nome"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.txtEmail.Font = New System.Drawing.Font("Bahnschrift", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(553, 361)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(390, 24)
        Me.txtEmail.TabIndex = 48
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(550, 341)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 13)
        Me.Label3.TabIndex = 47
        Me.Label3.Text = "E-mail"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(550, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 46
        Me.Label2.Text = "DIONYSIUS"
        '
        'btnCadastrar
        '
        Me.btnCadastrar.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btnCadastrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCadastrar.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadastrar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnCadastrar.Location = New System.Drawing.Point(655, 510)
        Me.btnCadastrar.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCadastrar.Name = "btnCadastrar"
        Me.btnCadastrar.Size = New System.Drawing.Size(191, 43)
        Me.btnCadastrar.TabIndex = 45
        Me.btnCadastrar.Text = "Adicionar Fornecedor"
        Me.btnCadastrar.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(546, 63)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(237, 42)
        Me.Label1.TabIndex = 44
        Me.Label1.Text = "Fornecedores"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(-1, -4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(499, 620)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 43
        Me.PictureBox1.TabStop = False
        '
        'txtProdutoFornecido
        '
        Me.txtProdutoFornecido.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.txtProdutoFornecido.Font = New System.Drawing.Font("Bahnschrift", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtProdutoFornecido.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txtProdutoFornecido.Location = New System.Drawing.Point(553, 295)
        Me.txtProdutoFornecido.Name = "txtProdutoFornecido"
        Me.txtProdutoFornecido.Size = New System.Drawing.Size(390, 24)
        Me.txtProdutoFornecido.TabIndex = 65
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(550, 275)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(94, 13)
        Me.Label5.TabIndex = 64
        Me.Label5.Text = "Produto Fornecido"
        '
        'txtId
        '
        Me.txtId.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.txtId.Location = New System.Drawing.Point(918, 87)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(25, 13)
        Me.txtId.TabIndex = 66
        Me.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtId.Visible = False
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.lblId.Location = New System.Drawing.Point(900, 87)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(21, 13)
        Me.lblId.TabIndex = 67
        Me.lblId.Text = "ID:"
        Me.lblId.Visible = False
        '
        'frmCadastraFornecedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1009, 611)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.txtProdutoFornecido)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCep)
        Me.Controls.Add(Me.txtFone)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtRamo)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCadastrar)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmCadastraFornecedor"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dionysius - Fornecedor"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtCep As MaskedTextBox
    Friend WithEvents txtFone As MaskedTextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents txtRamo As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnCadastrar As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents txtProdutoFornecido As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents lblId As Label
End Class
