<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboard
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle4 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle5 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle8 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle6 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle7 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim DataGridViewCellStyle9 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle12 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle10 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle11 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle13 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle14 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle15 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle17 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle16 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.dgvDadosVinho = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DionysiusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatálogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FornecedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EventosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairDoSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tabControlDashboard = New System.Windows.Forms.TabControl()
        Me.tabProdutos = New System.Windows.Forms.TabPage()
        Me.btnAdicionaVinho = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tabProducao = New System.Windows.Forms.TabPage()
        Me.btnAdicionaProducao = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvDadosProducao = New System.Windows.Forms.DataGridView()
        Me.IdProducao = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.tabVendas = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.tabEventos = New System.Windows.Forms.TabPage()
        Me.btnAdicionaEvento = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvDadosEvento = New System.Windows.Forms.DataGridView()
        Me.IdEvento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataEvento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HoraEvento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.tabFornecedores = New System.Windows.Forms.TabPage()
        Me.btnAdicionaFornecedor = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvDadosFornecedores = New System.Windows.Forms.DataGridView()
        Me.IdFornecedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeFornecedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RamoDoFornecedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDoFornecedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TelefoneDoFornecedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProdutoFornecidoPeloFornecedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EnderecoDoFornecedor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn6 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.tabUsuarios = New System.Windows.Forms.TabPage()
        Me.btnAdicionaUsuario = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvDadosUsuarios = New System.Windows.Forms.DataGridView()
        Me.IdUsuario = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.Column16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn7 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn8 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn9 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn10 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.IdProduto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NomeProduto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescricaoProduto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TipoProduto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AcucarProduto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SafraProduto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UvaProduto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PaisRegiaoProduto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TeorAlcoolicoProduto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.HarmonizacaoProduto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtdeEmEstoqueProduto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PrecoProduto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.VisualProduto = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Editar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Excluir = New System.Windows.Forms.DataGridViewImageColumn()
        CType(Me.dgvDadosVinho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.tabControlDashboard.SuspendLayout()
        Me.tabProdutos.SuspendLayout()
        Me.tabProducao.SuspendLayout()
        CType(Me.dgvDadosProducao, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabVendas.SuspendLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabEventos.SuspendLayout()
        CType(Me.dgvDadosEvento, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabFornecedores.SuspendLayout()
        CType(Me.dgvDadosFornecedores, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.tabUsuarios.SuspendLayout()
        CType(Me.dgvDadosUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDadosVinho
        '
        Me.dgvDadosVinho.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.dgvDadosVinho.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDadosVinho.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.dgvDadosVinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDadosVinho.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProduto, Me.NomeProduto, Me.DescricaoProduto, Me.TipoProduto, Me.AcucarProduto, Me.SafraProduto, Me.UvaProduto, Me.PaisRegiaoProduto, Me.TeorAlcoolicoProduto, Me.HarmonizacaoProduto, Me.QtdeEmEstoqueProduto, Me.PrecoProduto, Me.VisualProduto, Me.Editar, Me.Excluir})
        DataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDadosVinho.DefaultCellStyle = DataGridViewCellStyle4
        resources.ApplyResources(Me.dgvDadosVinho, "dgvDadosVinho")
        Me.dgvDadosVinho.Name = "dgvDadosVinho"
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DionysiusToolStripMenuItem, Me.CatálogoToolStripMenuItem, Me.FornecedoresToolStripMenuItem, Me.EventosToolStripMenuItem, Me.LoginToolStripMenuItem})
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'DionysiusToolStripMenuItem
        '
        resources.ApplyResources(Me.DionysiusToolStripMenuItem, "DionysiusToolStripMenuItem")
        Me.DionysiusToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.DionysiusToolStripMenuItem.Name = "DionysiusToolStripMenuItem"
        Me.DionysiusToolStripMenuItem.Padding = New System.Windows.Forms.Padding(4, 0, 280, 0)
        '
        'CatálogoToolStripMenuItem
        '
        resources.ApplyResources(Me.CatálogoToolStripMenuItem, "CatálogoToolStripMenuItem")
        Me.CatálogoToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.CatálogoToolStripMenuItem.Name = "CatálogoToolStripMenuItem"
        Me.CatálogoToolStripMenuItem.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        '
        'FornecedoresToolStripMenuItem
        '
        resources.ApplyResources(Me.FornecedoresToolStripMenuItem, "FornecedoresToolStripMenuItem")
        Me.FornecedoresToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.FornecedoresToolStripMenuItem.Name = "FornecedoresToolStripMenuItem"
        Me.FornecedoresToolStripMenuItem.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        '
        'EventosToolStripMenuItem
        '
        resources.ApplyResources(Me.EventosToolStripMenuItem, "EventosToolStripMenuItem")
        Me.EventosToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.EventosToolStripMenuItem.Name = "EventosToolStripMenuItem"
        Me.EventosToolStripMenuItem.Padding = New System.Windows.Forms.Padding(20, 0, 20, 0)
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.LoginToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SairDoSistemaToolStripMenuItem})
        resources.ApplyResources(Me.LoginToolStripMenuItem, "LoginToolStripMenuItem")
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        '
        'SairDoSistemaToolStripMenuItem
        '
        Me.SairDoSistemaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.SairDoSistemaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        resources.ApplyResources(Me.SairDoSistemaToolStripMenuItem, "SairDoSistemaToolStripMenuItem")
        Me.SairDoSistemaToolStripMenuItem.Name = "SairDoSistemaToolStripMenuItem"
        '
        'tabControlDashboard
        '
        resources.ApplyResources(Me.tabControlDashboard, "tabControlDashboard")
        Me.tabControlDashboard.Controls.Add(Me.tabProdutos)
        Me.tabControlDashboard.Controls.Add(Me.tabProducao)
        Me.tabControlDashboard.Controls.Add(Me.tabVendas)
        Me.tabControlDashboard.Controls.Add(Me.tabEventos)
        Me.tabControlDashboard.Controls.Add(Me.tabFornecedores)
        Me.tabControlDashboard.Controls.Add(Me.tabUsuarios)
        Me.tabControlDashboard.Multiline = True
        Me.tabControlDashboard.Name = "tabControlDashboard"
        Me.tabControlDashboard.SelectedIndex = 0
        '
        'tabProdutos
        '
        Me.tabProdutos.Controls.Add(Me.btnAdicionaVinho)
        Me.tabProdutos.Controls.Add(Me.Label6)
        Me.tabProdutos.Controls.Add(Me.dgvDadosVinho)
        resources.ApplyResources(Me.tabProdutos, "tabProdutos")
        Me.tabProdutos.Name = "tabProdutos"
        Me.tabProdutos.UseVisualStyleBackColor = True
        '
        'btnAdicionaVinho
        '
        Me.btnAdicionaVinho.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(65, Byte), Integer))
        resources.ApplyResources(Me.btnAdicionaVinho, "btnAdicionaVinho")
        Me.btnAdicionaVinho.ForeColor = System.Drawing.Color.White
        Me.btnAdicionaVinho.Name = "btnAdicionaVinho"
        Me.btnAdicionaVinho.UseVisualStyleBackColor = False
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Name = "Label6"
        '
        'tabProducao
        '
        Me.tabProducao.Controls.Add(Me.btnAdicionaProducao)
        Me.tabProducao.Controls.Add(Me.Label1)
        Me.tabProducao.Controls.Add(Me.dgvDadosProducao)
        resources.ApplyResources(Me.tabProducao, "tabProducao")
        Me.tabProducao.Name = "tabProducao"
        Me.tabProducao.UseVisualStyleBackColor = True
        '
        'btnAdicionaProducao
        '
        Me.btnAdicionaProducao.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(65, Byte), Integer))
        resources.ApplyResources(Me.btnAdicionaProducao, "btnAdicionaProducao")
        Me.btnAdicionaProducao.ForeColor = System.Drawing.Color.White
        Me.btnAdicionaProducao.Name = "btnAdicionaProducao"
        Me.btnAdicionaProducao.UseVisualStyleBackColor = False
        '
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Name = "Label1"
        '
        'dgvDadosProducao
        '
        Me.dgvDadosProducao.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.dgvDadosProducao.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle5.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDadosProducao.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle5
        Me.dgvDadosProducao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDadosProducao.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdProducao, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewImageColumn1, Me.DataGridViewImageColumn2})
        DataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle8.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDadosProducao.DefaultCellStyle = DataGridViewCellStyle8
        resources.ApplyResources(Me.dgvDadosProducao, "dgvDadosProducao")
        Me.dgvDadosProducao.Name = "dgvDadosProducao"
        '
        'IdProducao
        '
        resources.ApplyResources(Me.IdProducao, "IdProducao")
        Me.IdProducao.Name = "IdProducao"
        '
        'DataGridViewTextBoxColumn2
        '
        resources.ApplyResources(Me.DataGridViewTextBoxColumn2, "DataGridViewTextBoxColumn2")
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        resources.ApplyResources(Me.DataGridViewTextBoxColumn3, "DataGridViewTextBoxColumn3")
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        DataGridViewCellStyle6.Format = "d"
        DataGridViewCellStyle6.NullValue = Nothing
        Me.DataGridViewTextBoxColumn4.DefaultCellStyle = DataGridViewCellStyle6
        resources.ApplyResources(Me.DataGridViewTextBoxColumn4, "DataGridViewTextBoxColumn4")
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        DataGridViewCellStyle7.Format = "d"
        DataGridViewCellStyle7.NullValue = Nothing
        Me.DataGridViewTextBoxColumn5.DefaultCellStyle = DataGridViewCellStyle7
        resources.ApplyResources(Me.DataGridViewTextBoxColumn5, "DataGridViewTextBoxColumn5")
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        resources.ApplyResources(Me.DataGridViewTextBoxColumn6, "DataGridViewTextBoxColumn6")
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewImageColumn1
        '
        resources.ApplyResources(Me.DataGridViewImageColumn1, "DataGridViewImageColumn1")
        Me.DataGridViewImageColumn1.Image = CType(resources.GetObject("DataGridViewImageColumn1.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn1.Name = "DataGridViewImageColumn1"
        Me.DataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewImageColumn2
        '
        resources.ApplyResources(Me.DataGridViewImageColumn2, "DataGridViewImageColumn2")
        Me.DataGridViewImageColumn2.Image = CType(resources.GetObject("DataGridViewImageColumn2.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn2.Name = "DataGridViewImageColumn2"
        '
        'tabVendas
        '
        Me.tabVendas.Controls.Add(Me.Label5)
        Me.tabVendas.Controls.Add(Me.Chart1)
        resources.ApplyResources(Me.tabVendas, "tabVendas")
        Me.tabVendas.Name = "tabVendas"
        Me.tabVendas.UseVisualStyleBackColor = True
        '
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Name = "Label5"
        '
        'Chart1
        '
        ChartArea1.Name = "ChartArea1"
        Me.Chart1.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Bebidas"
        Legend1.Title = "Produto"
        Me.Chart1.Legends.Add(Legend1)
        resources.ApplyResources(Me.Chart1, "Chart1")
        Me.Chart1.Name = "Chart1"
        Me.Chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Chocolate
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Bebidas"
        Series1.LegendText = "Vinho"
        Series1.Name = "Series1"
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Bebidas"
        Series2.LegendText = "Espumante"
        Series2.Name = "Series2"
        Me.Chart1.Series.Add(Series1)
        Me.Chart1.Series.Add(Series2)
        '
        'tabEventos
        '
        Me.tabEventos.Controls.Add(Me.btnAdicionaEvento)
        Me.tabEventos.Controls.Add(Me.Label2)
        Me.tabEventos.Controls.Add(Me.dgvDadosEvento)
        resources.ApplyResources(Me.tabEventos, "tabEventos")
        Me.tabEventos.Name = "tabEventos"
        Me.tabEventos.UseVisualStyleBackColor = True
        '
        'btnAdicionaEvento
        '
        Me.btnAdicionaEvento.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(65, Byte), Integer))
        resources.ApplyResources(Me.btnAdicionaEvento, "btnAdicionaEvento")
        Me.btnAdicionaEvento.ForeColor = System.Drawing.Color.White
        Me.btnAdicionaEvento.Name = "btnAdicionaEvento"
        Me.btnAdicionaEvento.UseVisualStyleBackColor = False
        '
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Name = "Label2"
        '
        'dgvDadosEvento
        '
        Me.dgvDadosEvento.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.dgvDadosEvento.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle9.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDadosEvento.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle9
        Me.dgvDadosEvento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDadosEvento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdEvento, Me.DataGridViewTextBoxColumn8, Me.Column13, Me.DataEvento, Me.HoraEvento, Me.DataGridViewTextBoxColumn11, Me.Column17, Me.DataGridViewTextBoxColumn12, Me.Column11, Me.Column12, Me.Column1, Me.DataGridViewImageColumn3, Me.DataGridViewImageColumn4})
        DataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle12.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle12.NullValue = Nothing
        DataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDadosEvento.DefaultCellStyle = DataGridViewCellStyle12
        resources.ApplyResources(Me.dgvDadosEvento, "dgvDadosEvento")
        Me.dgvDadosEvento.Name = "dgvDadosEvento"
        '
        'IdEvento
        '
        resources.ApplyResources(Me.IdEvento, "IdEvento")
        Me.IdEvento.Name = "IdEvento"
        '
        'DataGridViewTextBoxColumn8
        '
        resources.ApplyResources(Me.DataGridViewTextBoxColumn8, "DataGridViewTextBoxColumn8")
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'Column13
        '
        resources.ApplyResources(Me.Column13, "Column13")
        Me.Column13.Name = "Column13"
        '
        'DataEvento
        '
        DataGridViewCellStyle10.Format = "d"
        DataGridViewCellStyle10.NullValue = Nothing
        Me.DataEvento.DefaultCellStyle = DataGridViewCellStyle10
        resources.ApplyResources(Me.DataEvento, "DataEvento")
        Me.DataEvento.Name = "DataEvento"
        '
        'HoraEvento
        '
        DataGridViewCellStyle11.Format = "t"
        DataGridViewCellStyle11.NullValue = Nothing
        Me.HoraEvento.DefaultCellStyle = DataGridViewCellStyle11
        resources.ApplyResources(Me.HoraEvento, "HoraEvento")
        Me.HoraEvento.Name = "HoraEvento"
        '
        'DataGridViewTextBoxColumn11
        '
        resources.ApplyResources(Me.DataGridViewTextBoxColumn11, "DataGridViewTextBoxColumn11")
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'Column17
        '
        resources.ApplyResources(Me.Column17, "Column17")
        Me.Column17.Name = "Column17"
        '
        'DataGridViewTextBoxColumn12
        '
        resources.ApplyResources(Me.DataGridViewTextBoxColumn12, "DataGridViewTextBoxColumn12")
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'Column11
        '
        resources.ApplyResources(Me.Column11, "Column11")
        Me.Column11.Name = "Column11"
        '
        'Column12
        '
        resources.ApplyResources(Me.Column12, "Column12")
        Me.Column12.Name = "Column12"
        '
        'Column1
        '
        resources.ApplyResources(Me.Column1, "Column1")
        Me.Column1.Name = "Column1"
        '
        'DataGridViewImageColumn3
        '
        resources.ApplyResources(Me.DataGridViewImageColumn3, "DataGridViewImageColumn3")
        Me.DataGridViewImageColumn3.Image = CType(resources.GetObject("DataGridViewImageColumn3.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn3.Name = "DataGridViewImageColumn3"
        Me.DataGridViewImageColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewImageColumn4
        '
        resources.ApplyResources(Me.DataGridViewImageColumn4, "DataGridViewImageColumn4")
        Me.DataGridViewImageColumn4.Image = CType(resources.GetObject("DataGridViewImageColumn4.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn4.Name = "DataGridViewImageColumn4"
        '
        'tabFornecedores
        '
        Me.tabFornecedores.Controls.Add(Me.btnAdicionaFornecedor)
        Me.tabFornecedores.Controls.Add(Me.Label3)
        Me.tabFornecedores.Controls.Add(Me.dgvDadosFornecedores)
        resources.ApplyResources(Me.tabFornecedores, "tabFornecedores")
        Me.tabFornecedores.Name = "tabFornecedores"
        Me.tabFornecedores.UseVisualStyleBackColor = True
        '
        'btnAdicionaFornecedor
        '
        Me.btnAdicionaFornecedor.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(65, Byte), Integer))
        Me.btnAdicionaFornecedor.ForeColor = System.Drawing.Color.White
        resources.ApplyResources(Me.btnAdicionaFornecedor, "btnAdicionaFornecedor")
        Me.btnAdicionaFornecedor.Name = "btnAdicionaFornecedor"
        Me.btnAdicionaFornecedor.UseVisualStyleBackColor = False
        '
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Name = "Label3"
        '
        'dgvDadosFornecedores
        '
        Me.dgvDadosFornecedores.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.dgvDadosFornecedores.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle13.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle13.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle13.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDadosFornecedores.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle13
        Me.dgvDadosFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDadosFornecedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdFornecedor, Me.NomeFornecedor, Me.RamoDoFornecedor, Me.EmailDoFornecedor, Me.TelefoneDoFornecedor, Me.ProdutoFornecidoPeloFornecedor, Me.EnderecoDoFornecedor, Me.DataGridViewImageColumn5, Me.DataGridViewImageColumn6})
        DataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle14.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle14.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle14.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDadosFornecedores.DefaultCellStyle = DataGridViewCellStyle14
        resources.ApplyResources(Me.dgvDadosFornecedores, "dgvDadosFornecedores")
        Me.dgvDadosFornecedores.Name = "dgvDadosFornecedores"
        '
        'IdFornecedor
        '
        resources.ApplyResources(Me.IdFornecedor, "IdFornecedor")
        Me.IdFornecedor.Name = "IdFornecedor"
        '
        'NomeFornecedor
        '
        resources.ApplyResources(Me.NomeFornecedor, "NomeFornecedor")
        Me.NomeFornecedor.Name = "NomeFornecedor"
        '
        'RamoDoFornecedor
        '
        resources.ApplyResources(Me.RamoDoFornecedor, "RamoDoFornecedor")
        Me.RamoDoFornecedor.Name = "RamoDoFornecedor"
        '
        'EmailDoFornecedor
        '
        resources.ApplyResources(Me.EmailDoFornecedor, "EmailDoFornecedor")
        Me.EmailDoFornecedor.Name = "EmailDoFornecedor"
        '
        'TelefoneDoFornecedor
        '
        resources.ApplyResources(Me.TelefoneDoFornecedor, "TelefoneDoFornecedor")
        Me.TelefoneDoFornecedor.Name = "TelefoneDoFornecedor"
        '
        'ProdutoFornecidoPeloFornecedor
        '
        resources.ApplyResources(Me.ProdutoFornecidoPeloFornecedor, "ProdutoFornecidoPeloFornecedor")
        Me.ProdutoFornecidoPeloFornecedor.Name = "ProdutoFornecidoPeloFornecedor"
        '
        'EnderecoDoFornecedor
        '
        resources.ApplyResources(Me.EnderecoDoFornecedor, "EnderecoDoFornecedor")
        Me.EnderecoDoFornecedor.Name = "EnderecoDoFornecedor"
        '
        'DataGridViewImageColumn5
        '
        resources.ApplyResources(Me.DataGridViewImageColumn5, "DataGridViewImageColumn5")
        Me.DataGridViewImageColumn5.Image = CType(resources.GetObject("DataGridViewImageColumn5.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn5.Name = "DataGridViewImageColumn5"
        Me.DataGridViewImageColumn5.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewImageColumn6
        '
        resources.ApplyResources(Me.DataGridViewImageColumn6, "DataGridViewImageColumn6")
        Me.DataGridViewImageColumn6.Image = CType(resources.GetObject("DataGridViewImageColumn6.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn6.Name = "DataGridViewImageColumn6"
        '
        'tabUsuarios
        '
        Me.tabUsuarios.Controls.Add(Me.btnAdicionaUsuario)
        Me.tabUsuarios.Controls.Add(Me.Label4)
        Me.tabUsuarios.Controls.Add(Me.dgvDadosUsuarios)
        resources.ApplyResources(Me.tabUsuarios, "tabUsuarios")
        Me.tabUsuarios.Name = "tabUsuarios"
        Me.tabUsuarios.UseVisualStyleBackColor = True
        '
        'btnAdicionaUsuario
        '
        Me.btnAdicionaUsuario.BackColor = System.Drawing.Color.FromArgb(CType(CType(174, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(65, Byte), Integer))
        resources.ApplyResources(Me.btnAdicionaUsuario, "btnAdicionaUsuario")
        Me.btnAdicionaUsuario.ForeColor = System.Drawing.Color.White
        Me.btnAdicionaUsuario.Name = "btnAdicionaUsuario"
        Me.btnAdicionaUsuario.UseVisualStyleBackColor = False
        '
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Name = "Label4"
        '
        'dgvDadosUsuarios
        '
        Me.dgvDadosUsuarios.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.dgvDadosUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        DataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle15.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle15.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle15.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dgvDadosUsuarios.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle15
        Me.dgvDadosUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDadosUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IdUsuario, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn26, Me.Column14, Me.DataGridViewTextBoxColumn25, Me.Column15, Me.Column16, Me.DataGridViewImageColumn7, Me.DataGridViewImageColumn8})
        DataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle17.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle17.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(CType(CType(170, Byte), Integer), CType(CType(80, Byte), Integer), CType(CType(65, Byte), Integer))
        DataGridViewCellStyle17.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.dgvDadosUsuarios.DefaultCellStyle = DataGridViewCellStyle17
        resources.ApplyResources(Me.dgvDadosUsuarios, "dgvDadosUsuarios")
        Me.dgvDadosUsuarios.Name = "dgvDadosUsuarios"
        '
        'IdUsuario
        '
        resources.ApplyResources(Me.IdUsuario, "IdUsuario")
        Me.IdUsuario.Name = "IdUsuario"
        '
        'DataGridViewTextBoxColumn21
        '
        resources.ApplyResources(Me.DataGridViewTextBoxColumn21, "DataGridViewTextBoxColumn21")
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn22
        '
        resources.ApplyResources(Me.DataGridViewTextBoxColumn22, "DataGridViewTextBoxColumn22")
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn23
        '
        resources.ApplyResources(Me.DataGridViewTextBoxColumn23, "DataGridViewTextBoxColumn23")
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        resources.ApplyResources(Me.DataGridViewTextBoxColumn24, "DataGridViewTextBoxColumn24")
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'DataGridViewTextBoxColumn26
        '
        resources.ApplyResources(Me.DataGridViewTextBoxColumn26, "DataGridViewTextBoxColumn26")
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'Column14
        '
        resources.ApplyResources(Me.Column14, "Column14")
        Me.Column14.Name = "Column14"
        '
        'DataGridViewTextBoxColumn25
        '
        DataGridViewCellStyle16.Format = "d"
        DataGridViewCellStyle16.NullValue = Nothing
        Me.DataGridViewTextBoxColumn25.DefaultCellStyle = DataGridViewCellStyle16
        resources.ApplyResources(Me.DataGridViewTextBoxColumn25, "DataGridViewTextBoxColumn25")
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'Column15
        '
        resources.ApplyResources(Me.Column15, "Column15")
        Me.Column15.Name = "Column15"
        '
        'Column16
        '
        resources.ApplyResources(Me.Column16, "Column16")
        Me.Column16.Name = "Column16"
        '
        'DataGridViewImageColumn7
        '
        resources.ApplyResources(Me.DataGridViewImageColumn7, "DataGridViewImageColumn7")
        Me.DataGridViewImageColumn7.Image = CType(resources.GetObject("DataGridViewImageColumn7.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn7.Name = "DataGridViewImageColumn7"
        Me.DataGridViewImageColumn7.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewImageColumn8
        '
        resources.ApplyResources(Me.DataGridViewImageColumn8, "DataGridViewImageColumn8")
        Me.DataGridViewImageColumn8.Image = CType(resources.GetObject("DataGridViewImageColumn8.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn8.Name = "DataGridViewImageColumn8"
        '
        'DataGridViewImageColumn9
        '
        resources.ApplyResources(Me.DataGridViewImageColumn9, "DataGridViewImageColumn9")
        Me.DataGridViewImageColumn9.Image = CType(resources.GetObject("DataGridViewImageColumn9.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn9.Name = "DataGridViewImageColumn9"
        Me.DataGridViewImageColumn9.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'DataGridViewImageColumn10
        '
        resources.ApplyResources(Me.DataGridViewImageColumn10, "DataGridViewImageColumn10")
        Me.DataGridViewImageColumn10.Image = CType(resources.GetObject("DataGridViewImageColumn10.Image"), System.Drawing.Image)
        Me.DataGridViewImageColumn10.Name = "DataGridViewImageColumn10"
        '
        'IdProduto
        '
        resources.ApplyResources(Me.IdProduto, "IdProduto")
        Me.IdProduto.Name = "IdProduto"
        '
        'NomeProduto
        '
        resources.ApplyResources(Me.NomeProduto, "NomeProduto")
        Me.NomeProduto.Name = "NomeProduto"
        '
        'DescricaoProduto
        '
        resources.ApplyResources(Me.DescricaoProduto, "DescricaoProduto")
        Me.DescricaoProduto.Name = "DescricaoProduto"
        '
        'TipoProduto
        '
        resources.ApplyResources(Me.TipoProduto, "TipoProduto")
        Me.TipoProduto.Name = "TipoProduto"
        '
        'AcucarProduto
        '
        resources.ApplyResources(Me.AcucarProduto, "AcucarProduto")
        Me.AcucarProduto.Name = "AcucarProduto"
        '
        'SafraProduto
        '
        resources.ApplyResources(Me.SafraProduto, "SafraProduto")
        Me.SafraProduto.Name = "SafraProduto"
        '
        'UvaProduto
        '
        resources.ApplyResources(Me.UvaProduto, "UvaProduto")
        Me.UvaProduto.Name = "UvaProduto"
        '
        'PaisRegiaoProduto
        '
        resources.ApplyResources(Me.PaisRegiaoProduto, "PaisRegiaoProduto")
        Me.PaisRegiaoProduto.Name = "PaisRegiaoProduto"
        '
        'TeorAlcoolicoProduto
        '
        DataGridViewCellStyle2.Format = "N1"
        DataGridViewCellStyle2.NullValue = Nothing
        Me.TeorAlcoolicoProduto.DefaultCellStyle = DataGridViewCellStyle2
        resources.ApplyResources(Me.TeorAlcoolicoProduto, "TeorAlcoolicoProduto")
        Me.TeorAlcoolicoProduto.Name = "TeorAlcoolicoProduto"
        '
        'HarmonizacaoProduto
        '
        resources.ApplyResources(Me.HarmonizacaoProduto, "HarmonizacaoProduto")
        Me.HarmonizacaoProduto.Name = "HarmonizacaoProduto"
        '
        'QtdeEmEstoqueProduto
        '
        resources.ApplyResources(Me.QtdeEmEstoqueProduto, "QtdeEmEstoqueProduto")
        Me.QtdeEmEstoqueProduto.Name = "QtdeEmEstoqueProduto"
        '
        'PrecoProduto
        '
        DataGridViewCellStyle3.Format = "C2"
        DataGridViewCellStyle3.NullValue = "0,00"
        Me.PrecoProduto.DefaultCellStyle = DataGridViewCellStyle3
        resources.ApplyResources(Me.PrecoProduto, "PrecoProduto")
        Me.PrecoProduto.Name = "PrecoProduto"
        '
        'VisualProduto
        '
        resources.ApplyResources(Me.VisualProduto, "VisualProduto")
        Me.VisualProduto.Name = "VisualProduto"
        Me.VisualProduto.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Editar
        '
        resources.ApplyResources(Me.Editar, "Editar")
        Me.Editar.Image = CType(resources.GetObject("Editar.Image"), System.Drawing.Image)
        Me.Editar.Name = "Editar"
        Me.Editar.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        '
        'Excluir
        '
        resources.ApplyResources(Me.Excluir, "Excluir")
        Me.Excluir.Image = CType(resources.GetObject("Excluir.Image"), System.Drawing.Image)
        Me.Excluir.Name = "Excluir"
        '
        'Dashboard
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.Controls.Add(Me.tabControlDashboard)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.Name = "Dashboard"
        CType(Me.dgvDadosVinho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.tabControlDashboard.ResumeLayout(False)
        Me.tabProdutos.ResumeLayout(False)
        Me.tabProdutos.PerformLayout()
        Me.tabProducao.ResumeLayout(False)
        Me.tabProducao.PerformLayout()
        CType(Me.dgvDadosProducao, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabVendas.ResumeLayout(False)
        Me.tabVendas.PerformLayout()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabEventos.ResumeLayout(False)
        Me.tabEventos.PerformLayout()
        CType(Me.dgvDadosEvento, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabFornecedores.ResumeLayout(False)
        Me.tabFornecedores.PerformLayout()
        CType(Me.dgvDadosFornecedores, System.ComponentModel.ISupportInitialize).EndInit()
        Me.tabUsuarios.ResumeLayout(False)
        Me.tabUsuarios.PerformLayout()
        CType(Me.dgvDadosUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgvDadosVinho As DataGridView
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DionysiusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CatálogoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FornecedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EventosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tabControlDashboard As TabControl
    Friend WithEvents tabProdutos As TabPage
    Friend WithEvents tabProducao As TabPage
    Friend WithEvents tabVendas As TabPage
    Friend WithEvents tabEventos As TabPage
    Friend WithEvents tabFornecedores As TabPage
    Friend WithEvents tabUsuarios As TabPage
    Friend WithEvents Label6 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDadosProducao As DataGridView
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvDadosEvento As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvDadosFornecedores As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvDadosUsuarios As DataGridView
    Friend WithEvents Label5 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
    Friend WithEvents btnAdicionaVinho As Button
    Friend WithEvents btnAdicionaProducao As Button
    Friend WithEvents btnAdicionaEvento As Button
    Friend WithEvents btnAdicionaFornecedor As Button
    Friend WithEvents btnAdicionaUsuario As Button
    Friend WithEvents DataGridViewImageColumn9 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn10 As DataGridViewImageColumn
    Friend WithEvents SairDoSistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents IdFornecedor As DataGridViewTextBoxColumn
    Friend WithEvents NomeFornecedor As DataGridViewTextBoxColumn
    Friend WithEvents RamoDoFornecedor As DataGridViewTextBoxColumn
    Friend WithEvents EmailDoFornecedor As DataGridViewTextBoxColumn
    Friend WithEvents TelefoneDoFornecedor As DataGridViewTextBoxColumn
    Friend WithEvents ProdutoFornecidoPeloFornecedor As DataGridViewTextBoxColumn
    Friend WithEvents EnderecoDoFornecedor As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn5 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn6 As DataGridViewImageColumn
    Friend WithEvents IdEvento As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents DataEvento As DataGridViewTextBoxColumn
    Friend WithEvents HoraEvento As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents Column17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn3 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn4 As DataGridViewImageColumn
    Friend WithEvents IdProducao As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents IdUsuario As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewCheckBoxColumn
    Friend WithEvents Column16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn7 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn8 As DataGridViewImageColumn
    Friend WithEvents IdProduto As DataGridViewTextBoxColumn
    Friend WithEvents NomeProduto As DataGridViewTextBoxColumn
    Friend WithEvents DescricaoProduto As DataGridViewTextBoxColumn
    Friend WithEvents TipoProduto As DataGridViewTextBoxColumn
    Friend WithEvents AcucarProduto As DataGridViewTextBoxColumn
    Friend WithEvents SafraProduto As DataGridViewTextBoxColumn
    Friend WithEvents UvaProduto As DataGridViewTextBoxColumn
    Friend WithEvents PaisRegiaoProduto As DataGridViewTextBoxColumn
    Friend WithEvents TeorAlcoolicoProduto As DataGridViewTextBoxColumn
    Friend WithEvents HarmonizacaoProduto As DataGridViewTextBoxColumn
    Friend WithEvents QtdeEmEstoqueProduto As DataGridViewTextBoxColumn
    Friend WithEvents PrecoProduto As DataGridViewTextBoxColumn
    Friend WithEvents VisualProduto As DataGridViewLinkColumn
    Friend WithEvents Editar As DataGridViewImageColumn
    Friend WithEvents Excluir As DataGridViewImageColumn
End Class
