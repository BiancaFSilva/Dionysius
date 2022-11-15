<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmAdicionaProduto
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdicionaProduto))
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtDescricao = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtPais = New System.Windows.Forms.MaskedTextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRegião = New System.Windows.Forms.MaskedTextBox()
        Me.cmbTipo = New System.Windows.Forms.ComboBox()
        Me.txtSafra = New System.Windows.Forms.MaskedTextBox()
        Me.cmbUva = New System.Windows.Forms.ComboBox()
        Me.txtNome = New System.Windows.Forms.MaskedTextBox()
        Me.cmbClasse = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txtPreco = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtTeorAlcoolico = New System.Windows.Forms.MaskedTextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txtProdutores = New System.Windows.Forms.MaskedTextBox()
        Me.txtQtdeEmEstoque = New System.Windows.Forms.MaskedTextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.txtHarmonizacao = New System.Windows.Forms.MaskedTextBox()
        Me.txtVisual = New System.Windows.Forms.MaskedTextBox()
        Me.btnAdicionaProduto = New System.Windows.Forms.Button()
        Me.imgProduto = New System.Windows.Forms.PictureBox()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.lblId = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        CType(Me.imgProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label10.Location = New System.Drawing.Point(51, 413)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(64, 13)
        Me.Label10.TabIndex = 86
        Me.Label10.Text = "Produtor(es)"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label11.Location = New System.Drawing.Point(256, 358)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(41, 13)
        Me.Label11.TabIndex = 81
        Me.Label11.Text = "Região"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label9.Location = New System.Drawing.Point(457, 297)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(32, 13)
        Me.Label9.TabIndex = 79
        Me.Label9.Text = "Safra"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(457, 183)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(28, 13)
        Me.Label8.TabIndex = 77
        Me.Label8.Text = "Tipo"
        '
        'txtDescricao
        '
        Me.txtDescricao.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.txtDescricao.Font = New System.Drawing.Font("Bahnschrift", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDescricao.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txtDescricao.Location = New System.Drawing.Point(53, 232)
        Me.txtDescricao.Multiline = True
        Me.txtDescricao.Name = "txtDescricao"
        Me.txtDescricao.Size = New System.Drawing.Size(390, 48)
        Me.txtDescricao.TabIndex = 76
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(50, 212)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(55, 13)
        Me.Label6.TabIndex = 75
        Me.Label6.Text = "Descrição"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(51, 158)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 73
        Me.Label4.Text = "Nome"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(51, 358)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(29, 13)
        Me.Label5.TabIndex = 72
        Me.Label5.Text = "País"
        '
        'txtPais
        '
        Me.txtPais.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.txtPais.Culture = New System.Globalization.CultureInfo("pt-BR")
        Me.txtPais.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txtPais.Location = New System.Drawing.Point(54, 378)
        Me.txtPais.Name = "txtPais"
        Me.txtPais.Size = New System.Drawing.Size(185, 20)
        Me.txtPais.TabIndex = 71
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(51, 297)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(27, 13)
        Me.Label3.TabIndex = 69
        Me.Label3.Text = "Uva"
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
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(46, 63)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(159, 42)
        Me.Label1.TabIndex = 66
        Me.Label1.Text = "Produtos"
        '
        'txtRegião
        '
        Me.txtRegião.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.txtRegião.Culture = New System.Globalization.CultureInfo("pt-BR")
        Me.txtRegião.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txtRegião.Location = New System.Drawing.Point(259, 378)
        Me.txtRegião.Name = "txtRegião"
        Me.txtRegião.Size = New System.Drawing.Size(185, 20)
        Me.txtRegião.TabIndex = 80
        '
        'cmbTipo
        '
        Me.cmbTipo.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.cmbTipo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbTipo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.cmbTipo.FormattingEnabled = True
        Me.cmbTipo.Location = New System.Drawing.Point(461, 204)
        Me.cmbTipo.Name = "cmbTipo"
        Me.cmbTipo.Size = New System.Drawing.Size(130, 21)
        Me.cmbTipo.TabIndex = 93
        '
        'txtSafra
        '
        Me.txtSafra.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.txtSafra.Culture = New System.Globalization.CultureInfo("pt-BR")
        Me.txtSafra.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txtSafra.Location = New System.Drawing.Point(461, 317)
        Me.txtSafra.Name = "txtSafra"
        Me.txtSafra.Size = New System.Drawing.Size(130, 20)
        Me.txtSafra.TabIndex = 95
        '
        'cmbUva
        '
        Me.cmbUva.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.cmbUva.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbUva.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.cmbUva.FormattingEnabled = True
        Me.cmbUva.Location = New System.Drawing.Point(54, 317)
        Me.cmbUva.Name = "cmbUva"
        Me.cmbUva.Size = New System.Drawing.Size(390, 21)
        Me.cmbUva.TabIndex = 96
        '
        'txtNome
        '
        Me.txtNome.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.txtNome.Culture = New System.Globalization.CultureInfo("pt-BR")
        Me.txtNome.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txtNome.Location = New System.Drawing.Point(53, 176)
        Me.txtNome.Name = "txtNome"
        Me.txtNome.Size = New System.Drawing.Size(390, 20)
        Me.txtNome.TabIndex = 97
        '
        'cmbClasse
        '
        Me.cmbClasse.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.cmbClasse.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.cmbClasse.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.cmbClasse.FormattingEnabled = True
        Me.cmbClasse.Location = New System.Drawing.Point(461, 261)
        Me.cmbClasse.Name = "cmbClasse"
        Me.cmbClasse.Size = New System.Drawing.Size(130, 21)
        Me.cmbClasse.TabIndex = 100
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label13.Location = New System.Drawing.Point(458, 240)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(69, 13)
        Me.Label13.TabIndex = 98
        Me.Label13.Text = "Classificação"
        '
        'txtPreco
        '
        Me.txtPreco.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.txtPreco.Culture = New System.Globalization.CultureInfo("pt-BR")
        Me.txtPreco.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txtPreco.Location = New System.Drawing.Point(461, 378)
        Me.txtPreco.Name = "txtPreco"
        Me.txtPreco.Size = New System.Drawing.Size(130, 20)
        Me.txtPreco.TabIndex = 106
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(457, 358)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 105
        Me.Label7.Text = "Preço"
        '
        'txtTeorAlcoolico
        '
        Me.txtTeorAlcoolico.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.txtTeorAlcoolico.Culture = New System.Globalization.CultureInfo("pt-BR")
        Me.txtTeorAlcoolico.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txtTeorAlcoolico.Location = New System.Drawing.Point(461, 435)
        Me.txtTeorAlcoolico.Name = "txtTeorAlcoolico"
        Me.txtTeorAlcoolico.Size = New System.Drawing.Size(130, 20)
        Me.txtTeorAlcoolico.TabIndex = 108
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label15.Location = New System.Drawing.Point(457, 413)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(75, 13)
        Me.Label15.TabIndex = 107
        Me.Label15.Text = "Teor Alcóolico"
        '
        'txtProdutores
        '
        Me.txtProdutores.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.txtProdutores.Culture = New System.Globalization.CultureInfo("pt-BR")
        Me.txtProdutores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txtProdutores.Location = New System.Drawing.Point(53, 435)
        Me.txtProdutores.Name = "txtProdutores"
        Me.txtProdutores.Size = New System.Drawing.Size(390, 20)
        Me.txtProdutores.TabIndex = 109
        '
        'txtQtdeEmEstoque
        '
        Me.txtQtdeEmEstoque.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.txtQtdeEmEstoque.Culture = New System.Globalization.CultureInfo("pt-BR")
        Me.txtQtdeEmEstoque.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txtQtdeEmEstoque.Location = New System.Drawing.Point(461, 490)
        Me.txtQtdeEmEstoque.Name = "txtQtdeEmEstoque"
        Me.txtQtdeEmEstoque.Size = New System.Drawing.Size(130, 20)
        Me.txtQtdeEmEstoque.TabIndex = 115
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label12.Location = New System.Drawing.Point(457, 470)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 13)
        Me.Label12.TabIndex = 114
        Me.Label12.Text = "Qtde. em Estoque"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(255, 470)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(87, 13)
        Me.Label14.TabIndex = 113
        Me.Label14.Text = "Aspectos Visuais"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label16.Location = New System.Drawing.Point(50, 470)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(196, 13)
        Me.Label16.TabIndex = 111
        Me.Label16.Text = "Harmonização com Alimentos e Bebidas"
        '
        'txtHarmonizacao
        '
        Me.txtHarmonizacao.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.txtHarmonizacao.Culture = New System.Globalization.CultureInfo("pt-BR")
        Me.txtHarmonizacao.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txtHarmonizacao.Location = New System.Drawing.Point(53, 490)
        Me.txtHarmonizacao.Name = "txtHarmonizacao"
        Me.txtHarmonizacao.Size = New System.Drawing.Size(185, 20)
        Me.txtHarmonizacao.TabIndex = 110
        '
        'txtVisual
        '
        Me.txtVisual.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.txtVisual.Culture = New System.Globalization.CultureInfo("pt-BR")
        Me.txtVisual.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txtVisual.Location = New System.Drawing.Point(258, 490)
        Me.txtVisual.Name = "txtVisual"
        Me.txtVisual.Size = New System.Drawing.Size(185, 20)
        Me.txtVisual.TabIndex = 112
        '
        'btnAdicionaProduto
        '
        Me.btnAdicionaProduto.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btnAdicionaProduto.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.btnAdicionaProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnAdicionaProduto.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdicionaProduto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnAdicionaProduto.Location = New System.Drawing.Point(233, 539)
        Me.btnAdicionaProduto.Margin = New System.Windows.Forms.Padding(4)
        Me.btnAdicionaProduto.Name = "btnAdicionaProduto"
        Me.btnAdicionaProduto.Size = New System.Drawing.Size(191, 43)
        Me.btnAdicionaProduto.TabIndex = 116
        Me.btnAdicionaProduto.Text = "Adicionar Produto"
        Me.btnAdicionaProduto.UseVisualStyleBackColor = False
        '
        'imgProduto
        '
        Me.imgProduto.BackgroundImage = CType(resources.GetObject("imgProduto.BackgroundImage"), System.Drawing.Image)
        Me.imgProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.imgProduto.Location = New System.Drawing.Point(491, 50)
        Me.imgProduto.Name = "imgProduto"
        Me.imgProduto.Size = New System.Drawing.Size(100, 110)
        Me.imgProduto.TabIndex = 117
        Me.imgProduto.TabStop = False
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.lblId.Location = New System.Drawing.Point(401, 87)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(21, 13)
        Me.lblId.TabIndex = 119
        Me.lblId.Text = "ID:"
        Me.lblId.Visible = False
        '
        'txtId
        '
        Me.txtId.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.txtId.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txtId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.txtId.Location = New System.Drawing.Point(419, 87)
        Me.txtId.Name = "txtId"
        Me.txtId.ReadOnly = True
        Me.txtId.Size = New System.Drawing.Size(25, 13)
        Me.txtId.TabIndex = 118
        Me.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtId.Visible = False
        '
        'frmAdicionaProduto
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(650, 630)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.imgProduto)
        Me.Controls.Add(Me.btnAdicionaProduto)
        Me.Controls.Add(Me.txtQtdeEmEstoque)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.txtHarmonizacao)
        Me.Controls.Add(Me.txtVisual)
        Me.Controls.Add(Me.txtProdutores)
        Me.Controls.Add(Me.txtTeorAlcoolico)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtPreco)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.cmbClasse)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.txtNome)
        Me.Controls.Add(Me.txtSafra)
        Me.Controls.Add(Me.cmbTipo)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.txtDescricao)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtPais)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtRegião)
        Me.Controls.Add(Me.cmbUva)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAdicionaProduto"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dionysius - Produto"
        CType(Me.imgProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents txtDescricao As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents txtPais As MaskedTextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRegião As MaskedTextBox
    Friend WithEvents cmbTipo As ComboBox
    Friend WithEvents txtSafra As MaskedTextBox
    Friend WithEvents cmbUva As ComboBox
    Friend WithEvents txtNome As MaskedTextBox
    Friend WithEvents cmbClasse As ComboBox
    Friend WithEvents Label13 As Label
    Friend WithEvents txtPreco As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents txtTeorAlcoolico As MaskedTextBox
    Friend WithEvents Label15 As Label
    Friend WithEvents txtProdutores As MaskedTextBox
    Friend WithEvents txtQtdeEmEstoque As MaskedTextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label14 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents txtHarmonizacao As MaskedTextBox
    Friend WithEvents txtVisual As MaskedTextBox
    Friend WithEvents btnAdicionaProduto As Button
    Friend WithEvents imgProduto As PictureBox
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
    Friend WithEvents lblId As Label
    Friend WithEvents txtId As TextBox
End Class
