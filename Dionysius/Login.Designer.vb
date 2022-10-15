<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Login
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Login))
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.btnCriaConta = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.txtSenha = New System.Windows.Forms.MaskedTextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.imgVerSenha = New System.Windows.Forms.PictureBox()
        Me.lblEsqueceuSenha = New System.Windows.Forms.LinkLabel()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.imgVerSenha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(425, -2)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(588, 618)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 0
        Me.PictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(45, 120)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(119, 42)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Entrar"
        '
        'btnLogin
        '
        Me.btnLogin.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btnLogin.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLogin.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnLogin.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnLogin.Location = New System.Drawing.Point(52, 457)
        Me.btnLogin.Margin = New System.Windows.Forms.Padding(4)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(187, 43)
        Me.btnLogin.TabIndex = 2
        Me.btnLogin.Text = "Entrar"
        Me.btnLogin.UseVisualStyleBackColor = False
        '
        'btnCriaConta
        '
        Me.btnCriaConta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnCriaConta.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btnCriaConta.FlatAppearance.BorderSize = 2
        Me.btnCriaConta.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCriaConta.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCriaConta.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btnCriaConta.Location = New System.Drawing.Point(52, 509)
        Me.btnCriaConta.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCriaConta.Name = "btnCriaConta"
        Me.btnCriaConta.Size = New System.Drawing.Size(187, 43)
        Me.btnCriaConta.TabIndex = 3
        Me.btnCriaConta.Text = "Solicitar uma Conta"
        Me.btnCriaConta.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(52, 107)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "DIONYSIUS"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(52, 233)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(50, 17)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "E-mail"
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.txtEmail.Font = New System.Drawing.Font("Bahnschrift", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(55, 253)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(300, 24)
        Me.txtEmail.TabIndex = 6
        '
        'txtSenha
        '
        Me.txtSenha.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.txtSenha.Culture = New System.Globalization.CultureInfo("pt-BR")
        Me.txtSenha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txtSenha.Location = New System.Drawing.Point(55, 314)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(300, 24)
        Me.txtSenha.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(52, 294)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(48, 17)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Senha"
        '
        'imgVerSenha
        '
        Me.imgVerSenha.Image = CType(resources.GetObject("imgVerSenha.Image"), System.Drawing.Image)
        Me.imgVerSenha.Location = New System.Drawing.Point(335, 314)
        Me.imgVerSenha.Name = "imgVerSenha"
        Me.imgVerSenha.Size = New System.Drawing.Size(20, 20)
        Me.imgVerSenha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.imgVerSenha.TabIndex = 10
        Me.imgVerSenha.TabStop = False
        '
        'lblEsqueceuSenha
        '
        Me.lblEsqueceuSenha.AutoSize = True
        Me.lblEsqueceuSenha.Font = New System.Drawing.Font("Bahnschrift", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblEsqueceuSenha.LinkColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.lblEsqueceuSenha.Location = New System.Drawing.Point(263, 341)
        Me.lblEsqueceuSenha.Name = "lblEsqueceuSenha"
        Me.lblEsqueceuSenha.Size = New System.Drawing.Size(92, 14)
        Me.lblEsqueceuSenha.TabIndex = 11
        Me.lblEsqueceuSenha.TabStop = True
        Me.lblEsqueceuSenha.Text = "Esqueci a senha"
        '
        'Login
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1009, 612)
        Me.Controls.Add(Me.lblEsqueceuSenha)
        Me.Controls.Add(Me.imgVerSenha)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnCriaConta)
        Me.Controls.Add(Me.btnLogin)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Font = New System.Drawing.Font("Bahnschrift", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Login"
        Me.Text = "Login de Usuário"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.imgVerSenha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents btnLogin As Button
    Friend WithEvents btnCriaConta As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents txtSenha As MaskedTextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents imgVerSenha As PictureBox
    Friend WithEvents lblEsqueceuSenha As LinkLabel
End Class
