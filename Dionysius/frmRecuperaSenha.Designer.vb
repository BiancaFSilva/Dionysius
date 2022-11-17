<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmRecuperaSenha
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmRecuperaSenha))
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtSenha = New System.Windows.Forms.MaskedTextBox()
        Me.txtEmail = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnRedefineSenha = New System.Windows.Forms.Button()
        Me.txtRepeteSenha = New System.Windows.Forms.MaskedTextBox()
        Me.chkVerSenha = New System.Windows.Forms.CheckBox()
        Me.imgVerSenha = New System.Windows.Forms.PictureBox()
        CType(Me.imgVerSenha, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(50, 20)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "DIONYSIUS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(46, 30)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(291, 42)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Recuperar Senha"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.Transparent
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(255, 167)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(75, 13)
        Me.Label11.TabIndex = 49
        Me.Label11.Text = "Repetir Senha"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.Transparent
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(50, 167)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(38, 13)
        Me.Label5.TabIndex = 47
        Me.Label5.Text = "Senha"
        '
        'txtSenha
        '
        Me.txtSenha.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.txtSenha.Culture = New System.Globalization.CultureInfo("pt-BR")
        Me.txtSenha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txtSenha.Location = New System.Drawing.Point(53, 187)
        Me.txtSenha.Name = "txtSenha"
        Me.txtSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtSenha.Size = New System.Drawing.Size(185, 20)
        Me.txtSenha.TabIndex = 46
        '
        'txtEmail
        '
        Me.txtEmail.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.txtEmail.Font = New System.Drawing.Font("Bahnschrift", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEmail.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txtEmail.Location = New System.Drawing.Point(53, 125)
        Me.txtEmail.Name = "txtEmail"
        Me.txtEmail.Size = New System.Drawing.Size(390, 24)
        Me.txtEmail.TabIndex = 45
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.Transparent
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(50, 109)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 44
        Me.Label3.Text = "CPF ou E-mail"
        '
        'btnRedefineSenha
        '
        Me.btnRedefineSenha.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btnRedefineSenha.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.btnRedefineSenha.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnRedefineSenha.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnRedefineSenha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnRedefineSenha.Location = New System.Drawing.Point(146, 264)
        Me.btnRedefineSenha.Margin = New System.Windows.Forms.Padding(4)
        Me.btnRedefineSenha.Name = "btnRedefineSenha"
        Me.btnRedefineSenha.Size = New System.Drawing.Size(191, 43)
        Me.btnRedefineSenha.TabIndex = 43
        Me.btnRedefineSenha.Text = "Redefinir Senha"
        Me.btnRedefineSenha.UseVisualStyleBackColor = False
        '
        'txtRepeteSenha
        '
        Me.txtRepeteSenha.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.txtRepeteSenha.Culture = New System.Globalization.CultureInfo("pt-BR")
        Me.txtRepeteSenha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txtRepeteSenha.Location = New System.Drawing.Point(258, 187)
        Me.txtRepeteSenha.Name = "txtRepeteSenha"
        Me.txtRepeteSenha.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtRepeteSenha.Size = New System.Drawing.Size(185, 20)
        Me.txtRepeteSenha.TabIndex = 48
        '
        'chkVerSenha
        '
        Me.chkVerSenha.Appearance = System.Windows.Forms.Appearance.Button
        Me.chkVerSenha.AutoSize = True
        Me.chkVerSenha.BackColor = System.Drawing.Color.Transparent
        Me.chkVerSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.chkVerSenha.CheckAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkVerSenha.FlatAppearance.BorderSize = 0
        Me.chkVerSenha.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.chkVerSenha.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkVerSenha.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.chkVerSenha.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.chkVerSenha.Location = New System.Drawing.Point(328, 206)
        Me.chkVerSenha.Name = "chkVerSenha"
        Me.chkVerSenha.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.chkVerSenha.Size = New System.Drawing.Size(99, 23)
        Me.chkVerSenha.TabIndex = 50
        Me.chkVerSenha.Text = "Visualizar senha"
        Me.chkVerSenha.TextAlign = System.Drawing.ContentAlignment.BottomRight
        Me.chkVerSenha.UseVisualStyleBackColor = False
        '
        'imgVerSenha
        '
        Me.imgVerSenha.BackColor = System.Drawing.Color.Transparent
        Me.imgVerSenha.BackgroundImage = CType(resources.GetObject("imgVerSenha.BackgroundImage"), System.Drawing.Image)
        Me.imgVerSenha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgVerSenha.Image = CType(resources.GetObject("imgVerSenha.Image"), System.Drawing.Image)
        Me.imgVerSenha.Location = New System.Drawing.Point(423, 209)
        Me.imgVerSenha.Name = "imgVerSenha"
        Me.imgVerSenha.Size = New System.Drawing.Size(20, 20)
        Me.imgVerSenha.TabIndex = 51
        Me.imgVerSenha.TabStop = False
        '
        'frmRecuperaSenha
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(494, 331)
        Me.Controls.Add(Me.imgVerSenha)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtSenha)
        Me.Controls.Add(Me.txtEmail)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnRedefineSenha)
        Me.Controls.Add(Me.txtRepeteSenha)
        Me.Controls.Add(Me.chkVerSenha)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmRecuperaSenha"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dionysius - Recuperar Senha"
        CType(Me.imgVerSenha, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents imgVerSenha As PictureBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtSenha As MaskedTextBox
    Friend WithEvents txtEmail As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents btnRedefineSenha As Button
    Friend WithEvents txtRepeteSenha As MaskedTextBox
    Friend WithEvents chkVerSenha As CheckBox
End Class
