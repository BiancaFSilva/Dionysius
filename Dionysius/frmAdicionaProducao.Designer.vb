<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAdicionaProducao
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAdicionaProducao))
        Me.cmbFornecedores = New System.Windows.Forms.ComboBox()
        Me.txtDataInicio = New System.Windows.Forms.MaskedTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TxtDataFim = New System.Windows.Forms.MaskedTextBox()
        Me.cmbProcesso = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cmbProduto = New System.Windows.Forms.ComboBox()
        Me.btnCadastraProducao = New System.Windows.Forms.Button()
        Me.lblId = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmbFornecedores
        '
        Me.cmbFornecedores.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.cmbFornecedores.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.cmbFornecedores.FormattingEnabled = True
        Me.cmbFornecedores.ItemHeight = 13
        Me.cmbFornecedores.Location = New System.Drawing.Point(53, 272)
        Me.cmbFornecedores.Name = "cmbFornecedores"
        Me.cmbFornecedores.Size = New System.Drawing.Size(390, 21)
        Me.cmbFornecedores.TabIndex = 109
        '
        'txtDataInicio
        '
        Me.txtDataInicio.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.txtDataInicio.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.txtDataInicio.Location = New System.Drawing.Point(53, 211)
        Me.txtDataInicio.Mask = "00/00/0000"
        Me.txtDataInicio.Name = "txtDataInicio"
        Me.txtDataInicio.Size = New System.Drawing.Size(185, 20)
        Me.txtDataInicio.TabIndex = 108
        Me.txtDataInicio.ValidatingType = GetType(Date)
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label7.Location = New System.Drawing.Point(255, 190)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 13)
        Me.Label7.TabIndex = 102
        Me.Label7.Text = "Data do Término (Previsão)"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label8.Location = New System.Drawing.Point(50, 190)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(75, 13)
        Me.Label8.TabIndex = 101
        Me.Label8.Text = "Data do Início"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(50, 128)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(78, 13)
        Me.Label4.TabIndex = 97
        Me.Label4.Text = "Processo Atual"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(50, 50)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 13)
        Me.Label2.TabIndex = 92
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
        Me.Label1.Size = New System.Drawing.Size(323, 42)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Processo Produtivo"
        '
        'TxtDataFim
        '
        Me.TxtDataFim.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.TxtDataFim.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.TxtDataFim.Location = New System.Drawing.Point(258, 211)
        Me.TxtDataFim.Mask = "00/00/0000"
        Me.TxtDataFim.Name = "TxtDataFim"
        Me.TxtDataFim.Size = New System.Drawing.Size(185, 20)
        Me.TxtDataFim.TabIndex = 113
        Me.TxtDataFim.ValidatingType = GetType(Date)
        '
        'cmbProcesso
        '
        Me.cmbProcesso.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.cmbProcesso.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.cmbProcesso.FormattingEnabled = True
        Me.cmbProcesso.ItemHeight = 13
        Me.cmbProcesso.Location = New System.Drawing.Point(53, 150)
        Me.cmbProcesso.Name = "cmbProcesso"
        Me.cmbProcesso.Size = New System.Drawing.Size(390, 21)
        Me.cmbProcesso.TabIndex = 114
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(50, 250)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(191, 13)
        Me.Label6.TabIndex = 115
        Me.Label6.Text = "Fornecedores Associados ao Processo"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(50, 313)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(107, 13)
        Me.Label3.TabIndex = 117
        Me.Label3.Text = "Produto Relacionado"
        '
        'cmbProduto
        '
        Me.cmbProduto.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.cmbProduto.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.cmbProduto.FormattingEnabled = True
        Me.cmbProduto.ItemHeight = 13
        Me.cmbProduto.Location = New System.Drawing.Point(53, 335)
        Me.cmbProduto.Name = "cmbProduto"
        Me.cmbProduto.Size = New System.Drawing.Size(390, 21)
        Me.cmbProduto.TabIndex = 116
        '
        'btnCadastraProducao
        '
        Me.btnCadastraProducao.BackColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btnCadastraProducao.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.btnCadastraProducao.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCadastraProducao.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCadastraProducao.ForeColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnCadastraProducao.Location = New System.Drawing.Point(155, 395)
        Me.btnCadastraProducao.Margin = New System.Windows.Forms.Padding(4)
        Me.btnCadastraProducao.Name = "btnCadastraProducao"
        Me.btnCadastraProducao.Size = New System.Drawing.Size(191, 43)
        Me.btnCadastraProducao.TabIndex = 118
        Me.btnCadastraProducao.Text = "Adicionar Processo"
        Me.btnCadastraProducao.UseVisualStyleBackColor = False
        '
        'lblId
        '
        Me.lblId.AutoSize = True
        Me.lblId.ForeColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.lblId.Location = New System.Drawing.Point(400, 87)
        Me.lblId.Name = "lblId"
        Me.lblId.Size = New System.Drawing.Size(21, 13)
        Me.lblId.TabIndex = 120
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
        Me.txtId.TabIndex = 119
        Me.txtId.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        Me.txtId.Visible = False
        '
        'frmAdicionaProducao
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(500, 480)
        Me.Controls.Add(Me.lblId)
        Me.Controls.Add(Me.txtId)
        Me.Controls.Add(Me.btnCadastraProducao)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbProduto)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TxtDataFim)
        Me.Controls.Add(Me.cmbFornecedores)
        Me.Controls.Add(Me.txtDataInicio)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.cmbProcesso)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "frmAdicionaProducao"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmAdicionaProducao"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbFornecedores As ComboBox
    Friend WithEvents txtDataInicio As MaskedTextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents TxtDataFim As MaskedTextBox
    Friend WithEvents cmbProcesso As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents cmbProduto As ComboBox
    Friend WithEvents btnCadastraProducao As Button
    Friend WithEvents lblId As Label
    Friend WithEvents txtId As TextBox
End Class
