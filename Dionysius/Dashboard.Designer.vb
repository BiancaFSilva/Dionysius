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
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DionysiusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.dgvDadosVinho = New System.Windows.Forms.DataGridView()
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
        Me.MenuStrip1.SuspendLayout()
        CType(Me.dgvDadosVinho, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DionysiusToolStripMenuItem, Me.LoginToolStripMenuItem})
        resources.ApplyResources(Me.MenuStrip1, "MenuStrip1")
        Me.MenuStrip1.Name = "MenuStrip1"
        '
        'DionysiusToolStripMenuItem
        '
        Me.DionysiusToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.DionysiusToolStripMenuItem.Name = "DionysiusToolStripMenuItem"
        Me.DionysiusToolStripMenuItem.Padding = New System.Windows.Forms.Padding(4, 0, 280, 0)
        resources.ApplyResources(Me.DionysiusToolStripMenuItem, "DionysiusToolStripMenuItem")
        '
        'LoginToolStripMenuItem
        '
        Me.LoginToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        resources.ApplyResources(Me.LoginToolStripMenuItem, "LoginToolStripMenuItem")
        '
        'dgvDadosVinho
        '
        Me.dgvDadosVinho.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDadosVinho.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Column, Me.Nome, Me.Column1, Me.Column2, Me.Column3, Me.Column4, Me.Column5, Me.Column6, Me.Column7, Me.Column8, Me.Column9, Me.Column10, Me.Editar, Me.Excluir})
        resources.ApplyResources(Me.dgvDadosVinho, "dgvDadosVinho")
        Me.dgvDadosVinho.Name = "dgvDadosVinho"
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
        'Dashboard
        '
        resources.ApplyResources(Me, "$this")
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.Controls.Add(Me.dgvDadosVinho)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Name = "Dashboard"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.dgvDadosVinho, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DionysiusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents dgvDadosVinho As DataGridView
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
End Class
