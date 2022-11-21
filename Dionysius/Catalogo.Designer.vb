<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Catalogo
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Catalogo))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DionysiusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatálogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FornecedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EventosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairDoSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.lblNomeSafraProduto = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtBusca = New System.Windows.Forms.TextBox()
        Me.btnBusca = New System.Windows.Forms.Button()
        Me.btnCatalogo = New System.Windows.Forms.Button()
        Me.lstBuscaProduto = New System.Windows.Forms.ListBox()
        Me.imgProduto = New System.Windows.Forms.PictureBox()
        Me.lblTipoClasseProduto = New System.Windows.Forms.Label()
        Me.lblDescricaoProduto = New System.Windows.Forms.Label()
        Me.lblDadosGerais = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.imgProduto, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DionysiusToolStripMenuItem, Me.CatálogoToolStripMenuItem, Me.FornecedoresToolStripMenuItem, Me.EventosToolStripMenuItem, Me.LoginToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(45, 10, 45, 10)
        Me.MenuStrip1.Size = New System.Drawing.Size(1174, 43)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'DionysiusToolStripMenuItem
        '
        Me.DionysiusToolStripMenuItem.Font = New System.Drawing.Font("Bahnschrift", 12.0!)
        Me.DionysiusToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.DionysiusToolStripMenuItem.Image = CType(resources.GetObject("DionysiusToolStripMenuItem.Image"), System.Drawing.Image)
        Me.DionysiusToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.DionysiusToolStripMenuItem.Name = "DionysiusToolStripMenuItem"
        Me.DionysiusToolStripMenuItem.Padding = New System.Windows.Forms.Padding(4, 0, 280, 0)
        Me.DionysiusToolStripMenuItem.Size = New System.Drawing.Size(383, 23)
        Me.DionysiusToolStripMenuItem.Text = "Dionysius"
        '
        'CatálogoToolStripMenuItem
        '
        Me.CatálogoToolStripMenuItem.Font = New System.Drawing.Font("Bahnschrift", 9.75!)
        Me.CatálogoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.CatálogoToolStripMenuItem.Name = "CatálogoToolStripMenuItem"
        Me.CatálogoToolStripMenuItem.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.CatálogoToolStripMenuItem.Size = New System.Drawing.Size(102, 23)
        Me.CatálogoToolStripMenuItem.Text = "Catálogo"
        '
        'FornecedoresToolStripMenuItem
        '
        Me.FornecedoresToolStripMenuItem.Font = New System.Drawing.Font("Bahnschrift", 9.75!)
        Me.FornecedoresToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.FornecedoresToolStripMenuItem.Name = "FornecedoresToolStripMenuItem"
        Me.FornecedoresToolStripMenuItem.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.FornecedoresToolStripMenuItem.Size = New System.Drawing.Size(132, 23)
        Me.FornecedoresToolStripMenuItem.Text = "Fornecedores"
        '
        'EventosToolStripMenuItem
        '
        Me.EventosToolStripMenuItem.Font = New System.Drawing.Font("Bahnschrift", 9.75!)
        Me.EventosToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.EventosToolStripMenuItem.Name = "EventosToolStripMenuItem"
        Me.EventosToolStripMenuItem.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        Me.EventosToolStripMenuItem.Size = New System.Drawing.Size(98, 23)
        Me.EventosToolStripMenuItem.Text = "Eventos"
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.LoginToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SairDoSistemaToolStripMenuItem})
        Me.LoginToolStripMenuItem.Image = CType(resources.GetObject("LoginToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(28, 23)
        Me.LoginToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'SairDoSistemaToolStripMenuItem
        '
        Me.SairDoSistemaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.SairDoSistemaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.SairDoSistemaToolStripMenuItem.Image = CType(resources.GetObject("SairDoSistemaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SairDoSistemaToolStripMenuItem.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.SairDoSistemaToolStripMenuItem.Name = "SairDoSistemaToolStripMenuItem"
        Me.SairDoSistemaToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.SairDoSistemaToolStripMenuItem.Text = "Sair do Sistema"
        '
        'lblNomeSafraProduto
        '
        Me.lblNomeSafraProduto.AutoSize = True
        Me.lblNomeSafraProduto.Font = New System.Drawing.Font("Bahnschrift", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNomeSafraProduto.ForeColor = System.Drawing.Color.White
        Me.lblNomeSafraProduto.Location = New System.Drawing.Point(101, 260)
        Me.lblNomeSafraProduto.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNomeSafraProduto.Name = "lblNomeSafraProduto"
        Me.lblNomeSafraProduto.Size = New System.Drawing.Size(26, 42)
        Me.lblNomeSafraProduto.TabIndex = 16
        Me.lblNomeSafraProduto.Text = "."
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(406, 129)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(30, 13)
        Me.Label2.TabIndex = 15
        Me.Label2.Text = "Dica:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Bahnschrift", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(442, 129)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(309, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "você pode buscar por nome, tipo, safra (ano) ou classificação"
        '
        'txtBusca
        '
        Me.txtBusca.Location = New System.Drawing.Point(314, 95)
        Me.txtBusca.Name = "txtBusca"
        Me.txtBusca.Size = New System.Drawing.Size(516, 20)
        Me.txtBusca.TabIndex = 12
        '
        'btnBusca
        '
        Me.btnBusca.BackgroundImage = CType(resources.GetObject("btnBusca.BackgroundImage"), System.Drawing.Image)
        Me.btnBusca.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnBusca.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btnBusca.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnBusca.ForeColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnBusca.Location = New System.Drawing.Point(839, 90)
        Me.btnBusca.Name = "btnBusca"
        Me.btnBusca.Size = New System.Drawing.Size(33, 32)
        Me.btnBusca.TabIndex = 13
        Me.btnBusca.UseVisualStyleBackColor = True
        '
        'btnCatalogo
        '
        Me.btnCatalogo.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.btnCatalogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.btnCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnCatalogo.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCatalogo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btnCatalogo.Image = CType(resources.GetObject("btnCatalogo.Image"), System.Drawing.Image)
        Me.btnCatalogo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnCatalogo.Location = New System.Drawing.Point(886, 189)
        Me.btnCatalogo.Name = "btnCatalogo"
        Me.btnCatalogo.Size = New System.Drawing.Size(173, 36)
        Me.btnCatalogo.TabIndex = 18
        Me.btnCatalogo.Text = "    Catálogo Completo"
        Me.btnCatalogo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText
        Me.btnCatalogo.UseVisualStyleBackColor = False
        '
        'lstBuscaProduto
        '
        Me.lstBuscaProduto.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.lstBuscaProduto.FormattingEnabled = True
        Me.lstBuscaProduto.Location = New System.Drawing.Point(314, 121)
        Me.lstBuscaProduto.Name = "lstBuscaProduto"
        Me.lstBuscaProduto.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple
        Me.lstBuscaProduto.Size = New System.Drawing.Size(516, 91)
        Me.lstBuscaProduto.TabIndex = 23
        Me.lstBuscaProduto.Visible = False
        '
        'imgProduto
        '
        Me.imgProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.imgProduto.Location = New System.Drawing.Point(108, 348)
        Me.imgProduto.Name = "imgProduto"
        Me.imgProduto.Size = New System.Drawing.Size(197, 263)
        Me.imgProduto.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.imgProduto.TabIndex = 24
        Me.imgProduto.TabStop = False
        '
        'lblTipoClasseProduto
        '
        Me.lblTipoClasseProduto.AutoSize = True
        Me.lblTipoClasseProduto.Font = New System.Drawing.Font("Bahnschrift", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTipoClasseProduto.ForeColor = System.Drawing.Color.White
        Me.lblTipoClasseProduto.Location = New System.Drawing.Point(108, 303)
        Me.lblTipoClasseProduto.Margin = New System.Windows.Forms.Padding(80, 10, 38, 6)
        Me.lblTipoClasseProduto.Name = "lblTipoClasseProduto"
        Me.lblTipoClasseProduto.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.lblTipoClasseProduto.Size = New System.Drawing.Size(11, 18)
        Me.lblTipoClasseProduto.TabIndex = 25
        Me.lblTipoClasseProduto.Text = "."
        Me.lblTipoClasseProduto.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lblDescricaoProduto
        '
        Me.lblDescricaoProduto.AutoSize = True
        Me.lblDescricaoProduto.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDescricaoProduto.ForeColor = System.Drawing.Color.White
        Me.lblDescricaoProduto.Location = New System.Drawing.Point(344, 348)
        Me.lblDescricaoProduto.Margin = New System.Windows.Forms.Padding(15, 0, 15, 6)
        Me.lblDescricaoProduto.MaximumSize = New System.Drawing.Size(700, 200)
        Me.lblDescricaoProduto.Name = "lblDescricaoProduto"
        Me.lblDescricaoProduto.Size = New System.Drawing.Size(10, 16)
        Me.lblDescricaoProduto.TabIndex = 26
        Me.lblDescricaoProduto.Text = "."
        '
        'lblDadosGerais
        '
        Me.lblDadosGerais.AutoSize = True
        Me.lblDadosGerais.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDadosGerais.ForeColor = System.Drawing.Color.White
        Me.lblDadosGerais.Location = New System.Drawing.Point(344, 480)
        Me.lblDadosGerais.Margin = New System.Windows.Forms.Padding(15, 0, 15, 0)
        Me.lblDadosGerais.MaximumSize = New System.Drawing.Size(700, 0)
        Me.lblDadosGerais.Name = "lblDadosGerais"
        Me.lblDadosGerais.Size = New System.Drawing.Size(10, 16)
        Me.lblDadosGerais.TabIndex = 27
        Me.lblDadosGerais.Text = "."
        '
        'Catalogo
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1174, 701)
        Me.Controls.Add(Me.imgProduto)
        Me.Controls.Add(Me.lblTipoClasseProduto)
        Me.Controls.Add(Me.lblDescricaoProduto)
        Me.Controls.Add(Me.lblDadosGerais)
        Me.Controls.Add(Me.lstBuscaProduto)
        Me.Controls.Add(Me.btnCatalogo)
        Me.Controls.Add(Me.lblNomeSafraProduto)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnBusca)
        Me.Controls.Add(Me.txtBusca)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Catalogo"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dionysius - Catálogo de Vinho & Espumantes"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.imgProduto, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DionysiusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CatálogoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FornecedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EventosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents lblNomeSafraProduto As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnBusca As Button
    Friend WithEvents txtBusca As TextBox
    Friend WithEvents SairDoSistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents btnCatalogo As Button
    Friend WithEvents lstBuscaProduto As ListBox
    Friend WithEvents imgProduto As PictureBox
    Friend WithEvents lblTipoClasseProduto As Label
    Friend WithEvents lblDescricaoProduto As Label
    Friend WithEvents lblDadosGerais As Label
End Class
