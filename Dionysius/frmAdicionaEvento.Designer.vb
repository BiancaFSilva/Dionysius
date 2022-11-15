<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdicionaEvento
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdicionaEvento))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbParticipantes = New System.Windows.Forms.ComboBox()
        Me.txtData = New System.Windows.Forms.MaskedTextBox()
        Me.txtCep = New System.Windows.Forms.MaskedTextBox()
        Me.txtHora = New System.Windows.Forms.MaskedTextBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtNome = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtBairro = New System.Windows.Forms.MaskedTextBox()
        Me.txtEndereco = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnAdicionarEvento = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtCidade = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtUf = New System.Windows.Forms.TextBox()
        Me.lblId = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(50, 445)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 86
        Me.Label10.Text = "Participantes"
        '
        'cmbParticipantes
        '
        Me.cmbParticipantes.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.cmbParticipantes.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.cmbParticipantes.FormattingEnabled = True
        Me.cmbParticipantes.ItemHeight = 13
        Me.cmbParticipantes.Location = New System.Drawing.Point(53, 461)
        Me.cmbParticipantes.Name = "cmbParticipantes"
        Me.cmbParticipantes.Size = New System.Drawing.Size(390, 21)
        Me.cmbParticipantes.TabIndex = 85
        '
        'txtData
        '
        Me.txtData.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.txtData.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txtData.Location = New System.Drawing.Point(53, 290)
        Me.txtData.Mask = "00/00/0000"
        Me.txtData.Name = "txtData"
        Me.txtData.Size = New System.Drawing.Size(120, 20)
        Me.txtData.TabIndex = 84
        Me.txtData.ValidatingType = GetType(Date)
        '
        'txtCep
        '
        Me.txtCep.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.txtCep.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txtCep.Location = New System.Drawing.Point(323, 290)
        Me.txtCep.Mask = "00000-000"
        Me.txtCep.Name = "txtCep"
        Me.txtCep.Size = New System.Drawing.Size(120, 20)
        Me.txtCep.TabIndex = 83
        '
        'txtHora
        '
        Me.txtHora.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.txtHora.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txtHora.Location = New System.Drawing.Point(188, 290)
        Me.txtHora.Mask = "00:00"
        Me.txtHora.Name = "txtHora"
        Me.txtHora.Size = New System.Drawing.Size(120, 20)
        Me.txtHora.TabIndex = 82
        Me.txtHora.ValidatingType = GetType(Date)
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(255, 388)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(40, 13)
        Me.Label11.TabIndex = 81
        Me.Label11.Text = "Cidade"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(320, 269)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 13)
        Me.Label9.TabIndex = 79
        Me.Label9.Text = "Código Postal (CEP)"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(185, 269)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(30, 13)
        Me.Label7.TabIndex = 78
        Me.Label7.Text = "Hora"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(50, 269)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(30, 13)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "Data"
        '
        'txtDescricao
        '
        Me.txtDescricao.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.txtDescricao.Font = New System.Drawing.Font("Bahnschrift", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescricao.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txtDescricao.Location = New System.Drawing.Point(53, 206)
        Me.txtDescricao.Multiline = True
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(390, 48)
        Me.txtDescricao.TabIndex = 76
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(50, 186)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "Descrição"
        '
        'txtNome
        '
        Me.txtNome.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.txtNome.Font = New System.Drawing.Font("Bahnschrift", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txtNome.Location = New System.Drawing.Point(53, 148)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(390, 24)
        Me.txtNome.TabIndex = 74
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(50, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Nome"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(50, 388)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(34, 13)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "Bairro"
        '
        'txtBairro
        '
        Me.txtBairro.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.txtBairro.Culture = New System.Globalization.CultureInfo("pt-BR")
        Me.txtBairro.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txtBairro.Location = New System.Drawing.Point(53, 408)
        Me.txtBairro.Name = "txtBairro"
        Me.txtBairro.ReadOnly = True
        Me.txtBairro.Size = New System.Drawing.Size(185, 20)
        Me.txtBairro.TabIndex = 71
        '
        'txtEndereco
        '
        Me.txtEndereco.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.txtEndereco.Font = New System.Drawing.Font("Bahnschrift", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtEndereco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txtEndereco.Location = New System.Drawing.Point(53, 346)
        Me.txtEndereco.Name = "txtEndereco"
        Me.txtEndereco.Size = New System.Drawing.Size(255, 24)
        Me.txtEndereco.TabIndex = 70
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(50, 326)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 13)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Endereço"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(50, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 68
        Me.Label2.Text = "DIONYSIUS"
        '
        'btnAdicionarEvento
        '
        Me.btnAdicionarEvento.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btnAdicionarEvento.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.btnAdicionarEvento.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdicionarEvento.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdicionarEvento.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnAdicionarEvento.Location = New System.Drawing.Point(155, 513)
        Me.btnAdicionarEvento.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdicionarEvento.Name = "btnAdicionarEvento"
        Me.btnAdicionarEvento.Size = New System.Drawing.Size(191, 43)
        Me.btnAdicionarEvento.TabIndex = 67
        Me.btnAdicionarEvento.Text = "Adicionar Evento"
        Me.btnAdicionarEvento.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(46, 63)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(144, 42)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Eventos"
        '
        'txtCidade
        '
        Me.txtCidade.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.txtCidade.Culture = New System.Globalization.CultureInfo("pt-BR")
        Me.txtCidade.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txtCidade.Location = New System.Drawing.Point(258, 408)
        Me.txtCidade.Name = "txtCidade"
        Me.txtCidade.ReadOnly = True
        Me.txtCidade.Size = New System.Drawing.Size(185, 20)
        Me.txtCidade.TabIndex = 80
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(320, 328)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(123, 13)
        Me.Label12.TabIndex = 88
        Me.Label12.Text = "Unidade Federativa (UF)"
        '
        'txtUf
        '
        Me.txtUf.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.txtUf.Font = New System.Drawing.Font("Bahnschrift", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUf.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txtUf.Location = New System.Drawing.Point(323, 346)
        Me.txtUf.Name = "txtUf"
        Me.txtUf.ReadOnly = True
        Me.txtUf.Size = New System.Drawing.Size(120, 24)
        Me.txtUf.TabIndex = 89
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.lblId.Location = New System.Drawing.Point(400, 87)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(21, 13)
        Me.lblId.TabIndex = 91
        Me.lblId.Text = "ID:"
        Me.lblId.Visible = False
        '
        'txtId
        '
        Me.txtId.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.txtId.Location = New System.Drawing.Point(418, 87)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(25, 13)
        Me.txtId.TabIndex = 90
        Me.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtId.Visible = False
        '
        'frmAdicionaEvento
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(500, 610)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.txtUf)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.cmbParticipantes)
        Me.Controls.Add(Me.txtData)
        Me.Controls.Add(Me.txtCep)
        Me.Controls.Add(Me.txtHora)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtBairro)
        Me.Controls.Add(Me.txtEndereco)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnAdicionarEvento)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCidade)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAdicionaEvento"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dionysius - Eventos"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents cmbParticipantes As ComboBox
    Friend WithEvents txtData As MaskedTextBox
    Friend WithEvents txtCep As MaskedTextBox
    Friend WithEvents txtHora As MaskedTextBox
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents txtNome As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtBairro As MaskedTextBox
    Friend WithEvents txtEndereco As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents btnAdicionarEvento As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents txtCidade As MaskedTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents txtUf As TextBox
    Friend WithEvents lblId As Label
    Friend WithEvents txtId As TextBox
End Class
