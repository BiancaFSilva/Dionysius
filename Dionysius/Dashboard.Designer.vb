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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboard))
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.dgvDadosVinho = New System.Windows.Forms.DataGridView()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DionysiusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatálogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FornecedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EventosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.tabControlDashboard = New System.Windows.Forms.TabControl()
        Me.tabProdutos = New System.Windows.Forms.TabPage()
        Me.tabProducao = New System.Windows.Forms.TabPage()
        Me.tabVendas = New System.Windows.Forms.TabPage()
        Me.tabEventos = New System.Windows.Forms.TabPage()
        Me.tabFornecedores = New System.Windows.Forms.TabPage()
        Me.tabUsuarios = New System.Windows.Forms.TabPage()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Column = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nome = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column10 = New System.Windows.Forms.DataGridViewLinkColumn()
        Me.Editar = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Excluir = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgvDadosProducao = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn1 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn2 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgvDadosEvento = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn3 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn4 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvDadosFornecedores = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewImageColumn5 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn6 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgvDadosUsuarios = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column15 = New System.Windows.Forms.DataGridViewCheckBoxColumn()
        Me.DataGridViewImageColumn7 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DataGridViewImageColumn8 = New System.Windows.Forms.DataGridViewImageColumn()
        Me.Chart1 = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.Label5 = New System.Windows.Forms.Label()
        CType(Me.dgvDadosVinho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.tabControlDashboard.SuspendLayout()
        Me.tabProdutos.SuspendLayout()
        Me.tabProducao.SuspendLayout()
        Me.tabVendas.SuspendLayout()
        Me.tabEventos.SuspendLayout()
        Me.tabFornecedores.SuspendLayout()
        Me.tabUsuarios.SuspendLayout()
        CType(Me.dgvDadosProducao, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDadosEvento, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDadosFornecedores, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvDadosUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgvDadosVinho
        '
        Me.dgvDadosVinho.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDadosVinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDadosVinho.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column, Me.Nome, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Editar, Me.Excluir})
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
        resources.ApplyResources(Me.LoginToolStripMenuItem, "LoginToolStripMenuItem")
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
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
        Me.tabProdutos.Controls.Add(Me.Label6)
        Me.tabProdutos.Controls.Add(Me.dgvDadosVinho)
        resources.ApplyResources(Me.tabProdutos, "tabProdutos")
        Me.tabProdutos.Name = "tabProdutos"
        Me.tabProdutos.UseVisualStyleBackColor = True
        '
        'tabProducao
        '
        Me.tabProducao.Controls.Add(Me.Label1)
        Me.tabProducao.Controls.Add(Me.dgvDadosProducao)
        resources.ApplyResources(Me.tabProducao, "tabProducao")
        Me.tabProducao.Name = "tabProducao"
        Me.tabProducao.UseVisualStyleBackColor = True
        '
        'tabVendas
        '
        Me.tabVendas.Controls.Add(Me.Label5)
        Me.tabVendas.Controls.Add(Me.Chart1)
        resources.ApplyResources(Me.tabVendas, "tabVendas")
        Me.tabVendas.Name = "tabVendas"
        Me.tabVendas.UseVisualStyleBackColor = True
        '
        'tabEventos
        '
        Me.tabEventos.Controls.Add(Me.Label2)
        Me.tabEventos.Controls.Add(Me.dgvDadosEvento)
        resources.ApplyResources(Me.tabEventos, "tabEventos")
        Me.tabEventos.Name = "tabEventos"
        Me.tabEventos.UseVisualStyleBackColor = True
        '
        'tabFornecedores
        '
        Me.tabFornecedores.Controls.Add(Me.Label3)
        Me.tabFornecedores.Controls.Add(Me.dgvDadosFornecedores)
        resources.ApplyResources(Me.tabFornecedores, "tabFornecedores")
        Me.tabFornecedores.Name = "tabFornecedores"
        Me.tabFornecedores.UseVisualStyleBackColor = True
        '
        'tabUsuarios
        '
        Me.tabUsuarios.Controls.Add(Me.Label4)
        Me.tabUsuarios.Controls.Add(Me.dgvDadosUsuarios)
        resources.ApplyResources(Me.tabUsuarios, "tabUsuarios")
        Me.tabUsuarios.Name = "tabUsuarios"
        Me.tabUsuarios.UseVisualStyleBackColor = True
        '
        'Label6
        '
        resources.ApplyResources(Me.Label6, "Label6")
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Name = "Label6"
        '
        'Column
        '
        resources.ApplyResources(Me.Column, "Column")
        Me.Column.Name = "Column"
        '
        'Nome
        '
        resources.ApplyResources(Me.Nome, "Nome")
        Me.Nome.Name = "Nome"
        '
        'Column1
        '
        resources.ApplyResources(Me.Column1, "Column1")
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        resources.ApplyResources(Me.Column2, "Column2")
        Me.Column2.Name = "Column2"
        '
        'Column3
        '
        resources.ApplyResources(Me.Column3, "Column3")
        Me.Column3.Name = "Column3"
        '
        'Column4
        '
        resources.ApplyResources(Me.Column4, "Column4")
        Me.Column4.Name = "Column4"
        '
        'Column5
        '
        resources.ApplyResources(Me.Column5, "Column5")
        Me.Column5.Name = "Column5"
        '
        'Column6
        '
        resources.ApplyResources(Me.Column6, "Column6")
        Me.Column6.Name = "Column6"
        '
        'Column7
        '
        resources.ApplyResources(Me.Column7, "Column7")
        Me.Column7.Name = "Column7"
        '
        'Column8
        '
        resources.ApplyResources(Me.Column8, "Column8")
        Me.Column8.Name = "Column8"
        '
        'Column9
        '
        resources.ApplyResources(Me.Column9, "Column9")
        Me.Column9.Name = "Column9"
        '
        'Column10
        '
        resources.ApplyResources(Me.Column10, "Column10")
        Me.Column10.Name = "Column10"
        Me.Column10.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
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
        'Label1
        '
        resources.ApplyResources(Me.Label1, "Label1")
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Name = "Label1"
        '
        'dgvDadosProducao
        '
        Me.dgvDadosProducao.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDadosProducao.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDadosProducao.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewImageColumn1, Me.DataGridViewImageColumn2})
        resources.ApplyResources(Me.dgvDadosProducao, "dgvDadosProducao")
        Me.dgvDadosProducao.Name = "dgvDadosProducao"
        '
        'DataGridViewTextBoxColumn1
        '
        resources.ApplyResources(Me.DataGridViewTextBoxColumn1, "DataGridViewTextBoxColumn1")
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
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
        resources.ApplyResources(Me.DataGridViewTextBoxColumn4, "DataGridViewTextBoxColumn4")
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
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
        'Label2
        '
        resources.ApplyResources(Me.Label2, "Label2")
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Name = "Label2"
        '
        'dgvDadosEvento
        '
        Me.dgvDadosEvento.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDadosEvento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDadosEvento.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.Column13, Me.DataGridViewTextBoxColumn9, Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.Column11, Me.Column12, Me.DataGridViewImageColumn3, Me.DataGridViewImageColumn4})
        resources.ApplyResources(Me.dgvDadosEvento, "dgvDadosEvento")
        Me.dgvDadosEvento.Name = "dgvDadosEvento"
        '
        'DataGridViewTextBoxColumn7
        '
        resources.ApplyResources(Me.DataGridViewTextBoxColumn7, "DataGridViewTextBoxColumn7")
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
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
        'DataGridViewTextBoxColumn9
        '
        resources.ApplyResources(Me.DataGridViewTextBoxColumn9, "DataGridViewTextBoxColumn9")
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'DataGridViewTextBoxColumn10
        '
        resources.ApplyResources(Me.DataGridViewTextBoxColumn10, "DataGridViewTextBoxColumn10")
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        '
        'DataGridViewTextBoxColumn11
        '
        resources.ApplyResources(Me.DataGridViewTextBoxColumn11, "DataGridViewTextBoxColumn11")
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
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
        'Label3
        '
        resources.ApplyResources(Me.Label3, "Label3")
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Name = "Label3"
        '
        'dgvDadosFornecedores
        '
        Me.dgvDadosFornecedores.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDadosFornecedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDadosFornecedores.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14, Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17, Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn18, Me.DataGridViewImageColumn5, Me.DataGridViewImageColumn6})
        resources.ApplyResources(Me.dgvDadosFornecedores, "dgvDadosFornecedores")
        Me.dgvDadosFornecedores.Name = "dgvDadosFornecedores"
        '
        'DataGridViewTextBoxColumn13
        '
        resources.ApplyResources(Me.DataGridViewTextBoxColumn13, "DataGridViewTextBoxColumn13")
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        resources.ApplyResources(Me.DataGridViewTextBoxColumn14, "DataGridViewTextBoxColumn14")
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'DataGridViewTextBoxColumn15
        '
        resources.ApplyResources(Me.DataGridViewTextBoxColumn15, "DataGridViewTextBoxColumn15")
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        '
        'DataGridViewTextBoxColumn16
        '
        resources.ApplyResources(Me.DataGridViewTextBoxColumn16, "DataGridViewTextBoxColumn16")
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        resources.ApplyResources(Me.DataGridViewTextBoxColumn17, "DataGridViewTextBoxColumn17")
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'DataGridViewTextBoxColumn19
        '
        resources.ApplyResources(Me.DataGridViewTextBoxColumn19, "DataGridViewTextBoxColumn19")
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        '
        'DataGridViewTextBoxColumn18
        '
        resources.ApplyResources(Me.DataGridViewTextBoxColumn18, "DataGridViewTextBoxColumn18")
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
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
        'Label4
        '
        resources.ApplyResources(Me.Label4, "Label4")
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Name = "Label4"
        '
        'dgvDadosUsuarios
        '
        Me.dgvDadosUsuarios.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.dgvDadosUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDadosUsuarios.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24, Me.DataGridViewTextBoxColumn26, Me.Column14, Me.DataGridViewTextBoxColumn25, Me.Column15, Me.DataGridViewImageColumn7, Me.DataGridViewImageColumn8})
        resources.ApplyResources(Me.dgvDadosUsuarios, "dgvDadosUsuarios")
        Me.dgvDadosUsuarios.Name = "dgvDadosUsuarios"
        '
        'DataGridViewTextBoxColumn20
        '
        resources.ApplyResources(Me.DataGridViewTextBoxColumn20, "DataGridViewTextBoxColumn20")
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
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
        resources.ApplyResources(Me.DataGridViewTextBoxColumn25, "DataGridViewTextBoxColumn25")
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        '
        'Column15
        '
        resources.ApplyResources(Me.Column15, "Column15")
        Me.Column15.Name = "Column15"
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
        'Label5
        '
        resources.ApplyResources(Me.Label5, "Label5")
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Name = "Label5"
        '
        'Dashboard
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.Controls.Add(Me.tabControlDashboard)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Dashboard"
        CType(Me.dgvDadosVinho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.tabControlDashboard.ResumeLayout(False)
        Me.tabProdutos.ResumeLayout(False)
        Me.tabProdutos.PerformLayout()
        Me.tabProducao.ResumeLayout(False)
        Me.tabProducao.PerformLayout()
        Me.tabVendas.ResumeLayout(False)
        Me.tabVendas.PerformLayout()
        Me.tabEventos.ResumeLayout(False)
        Me.tabEventos.PerformLayout()
        Me.tabFornecedores.ResumeLayout(False)
        Me.tabFornecedores.PerformLayout()
        Me.tabUsuarios.ResumeLayout(False)
        Me.tabUsuarios.PerformLayout()
        CType(Me.dgvDadosProducao, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDadosEvento, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDadosFornecedores, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvDadosUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.Chart1, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents Column As DataGridViewTextBoxColumn
    Friend WithEvents Nome As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents Column3 As DataGridViewTextBoxColumn
    Friend WithEvents Column4 As DataGridViewTextBoxColumn
    Friend WithEvents Column5 As DataGridViewTextBoxColumn
    Friend WithEvents Column6 As DataGridViewTextBoxColumn
    Friend WithEvents Column7 As DataGridViewTextBoxColumn
    Friend WithEvents Column8 As DataGridViewTextBoxColumn
    Friend WithEvents Column9 As DataGridViewTextBoxColumn
    Friend WithEvents Column10 As DataGridViewLinkColumn
    Friend WithEvents Editar As DataGridViewImageColumn
    Friend WithEvents Excluir As DataGridViewImageColumn
    Friend WithEvents Label1 As Label
    Friend WithEvents dgvDadosProducao As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn1 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn2 As DataGridViewImageColumn
    Friend WithEvents Label2 As Label
    Friend WithEvents dgvDadosEvento As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents Column13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents Column11 As DataGridViewTextBoxColumn
    Friend WithEvents Column12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn3 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn4 As DataGridViewImageColumn
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvDadosFornecedores As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewImageColumn5 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn6 As DataGridViewImageColumn
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvDadosUsuarios As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents Column14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents Column15 As DataGridViewCheckBoxColumn
    Friend WithEvents DataGridViewImageColumn7 As DataGridViewImageColumn
    Friend WithEvents DataGridViewImageColumn8 As DataGridViewImageColumn
    Friend WithEvents Label5 As Label
    Friend WithEvents Chart1 As DataVisualization.Charting.Chart
End Class
