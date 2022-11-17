<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Home
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Home))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.DionysiusToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CatálogoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FornecedoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EventosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoginToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FavoritosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SairDoSistemaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.btnVerCatalogo = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DionysiusToolStripMenuItem, Me.CatálogoToolStripMenuItem, Me.FornecedoresToolStripMenuItem, Me.EventosToolStripMenuItem, Me.LoginToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(45, 10, 45, 10)
        Me.MenuStrip1.Size = New System.Drawing.Size(1180, 43)
        Me.MenuStrip1.TabIndex = 10
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
        Me.LoginToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FavoritosToolStripMenuItem, Me.SairDoSistemaToolStripMenuItem})
        Me.LoginToolStripMenuItem.Image = CType(resources.GetObject("LoginToolStripMenuItem.Image"), System.Drawing.Image)
        Me.LoginToolStripMenuItem.Name = "LoginToolStripMenuItem"
        Me.LoginToolStripMenuItem.Size = New System.Drawing.Size(28, 23)
        Me.LoginToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopRight
        '
        'FavoritosToolStripMenuItem
        '
        Me.FavoritosToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.FavoritosToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.FavoritosToolStripMenuItem.Image = CType(resources.GetObject("FavoritosToolStripMenuItem.Image"), System.Drawing.Image)
        Me.FavoritosToolStripMenuItem.Name = "FavoritosToolStripMenuItem"
        Me.FavoritosToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.FavoritosToolStripMenuItem.Text = "Favoritos"
        '
        'SairDoSistemaToolStripMenuItem
        '
        Me.SairDoSistemaToolStripMenuItem.BackColor = System.Drawing.Color.FromArgb(CType(CType(89, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(2, Byte), Integer))
        Me.SairDoSistemaToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.SairDoSistemaToolStripMenuItem.Image = CType(resources.GetObject("SairDoSistemaToolStripMenuItem.Image"), System.Drawing.Image)
        Me.SairDoSistemaToolStripMenuItem.Name = "SairDoSistemaToolStripMenuItem"
        Me.SairDoSistemaToolStripMenuItem.Size = New System.Drawing.Size(154, 22)
        Me.SairDoSistemaToolStripMenuItem.Text = "Sair do Sistema"
        '
        'PictureBox2
        '
        Me.PictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(618, 21)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(505, 691)
        Me.PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox2.TabIndex = 18
        Me.PictureBox2.TabStop = False
        '
        'btnVerCatalogo
        '
        Me.btnVerCatalogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.btnVerCatalogo.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btnVerCatalogo.FlatAppearance.BorderSize = 2
        Me.btnVerCatalogo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnVerCatalogo.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnVerCatalogo.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.btnVerCatalogo.Location = New System.Drawing.Point(53, 512)
        Me.btnVerCatalogo.Margin = New System.Windows.Forms.Padding(4)
        Me.btnVerCatalogo.Name = "btnVerCatalogo"
        Me.btnVerCatalogo.Size = New System.Drawing.Size(187, 43)
        Me.btnVerCatalogo.TabIndex = 17
        Me.btnVerCatalogo.Text = "Visualizar Catálogo"
        Me.btnVerCatalogo.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(53, 265)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(415, 161)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = resources.GetString("Label4.Text")
        Me.Label4.UseCompatibleTextRendering = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Bahnschrift", 8.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(175, Byte), Integer), CType(CType(126, Byte), Integer), CType(CType(124, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(50, 115)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(62, 13)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "DIONYSIUS"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Bahnschrift", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(250, Byte), Integer), CType(CType(230, Byte), Integer), CType(CType(217, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(46, 128)
        Me.Label6.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(356, 42)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Vinhos e Espumantes"
        '
        'Home
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(7, Byte), Integer), CType(CType(8, Byte), Integer), CType(CType(12, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1180, 697)
        Me.Controls.Add(Me.btnVerCatalogo)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.PictureBox2)
        Me.Font = New System.Drawing.Font("Bahnschrift", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.MaximizeBox = False
        Me.Name = "Home"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Dionysius - Home"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents DionysiusToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CatálogoToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FornecedoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EventosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoginToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox2 As PictureBox
    Friend WithEvents btnVerCatalogo As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents SairDoSistemaToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FavoritosToolStripMenuItem As ToolStripMenuItem
End Class
