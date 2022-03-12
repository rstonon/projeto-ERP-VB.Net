<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmMenu
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmMenu))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CadastrosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ColaboradoresToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProdutosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UnidadesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.UsuáriosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip2 = New System.Windows.Forms.ToolStrip()
        Me.NomeUsuario = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.DataDia = New System.Windows.Forms.ToolStripLabel()
        Me.IPServidor = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BancoDeDados = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripButton1 = New System.Windows.Forms.ToolStripButton()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip2.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.BackColor = System.Drawing.SystemColors.Control
        Me.MenuStrip1.Font = New System.Drawing.Font("Arial", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CadastrosToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1264, 25)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CadastrosToolStripMenuItem
        '
        Me.CadastrosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CategoriasToolStripMenuItem, Me.CidadesToolStripMenuItem, Me.ColaboradoresToolStripMenuItem, Me.ProdutosToolStripMenuItem, Me.UnidadesToolStripMenuItem, Me.UsuáriosToolStripMenuItem})
        Me.CadastrosToolStripMenuItem.Name = "CadastrosToolStripMenuItem"
        Me.CadastrosToolStripMenuItem.Size = New System.Drawing.Size(88, 21)
        Me.CadastrosToolStripMenuItem.Text = "Cadastros"
        '
        'CategoriasToolStripMenuItem
        '
        Me.CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem"
        Me.CategoriasToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CategoriasToolStripMenuItem.Text = "Categorias"
        '
        'CidadesToolStripMenuItem
        '
        Me.CidadesToolStripMenuItem.Name = "CidadesToolStripMenuItem"
        Me.CidadesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.CidadesToolStripMenuItem.Text = "Cidades"
        '
        'ColaboradoresToolStripMenuItem
        '
        Me.ColaboradoresToolStripMenuItem.Name = "ColaboradoresToolStripMenuItem"
        Me.ColaboradoresToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ColaboradoresToolStripMenuItem.Text = "Colaboradores"
        '
        'ProdutosToolStripMenuItem
        '
        Me.ProdutosToolStripMenuItem.Name = "ProdutosToolStripMenuItem"
        Me.ProdutosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ProdutosToolStripMenuItem.Text = "Produtos"
        '
        'UnidadesToolStripMenuItem
        '
        Me.UnidadesToolStripMenuItem.Name = "UnidadesToolStripMenuItem"
        Me.UnidadesToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UnidadesToolStripMenuItem.Text = "Unidades"
        '
        'UsuáriosToolStripMenuItem
        '
        Me.UsuáriosToolStripMenuItem.Name = "UsuáriosToolStripMenuItem"
        Me.UsuáriosToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.UsuáriosToolStripMenuItem.Text = "Usuários"
        '
        'ToolStrip2
        '
        Me.ToolStrip2.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.ToolStrip2.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip2.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NomeUsuario, Me.ToolStripSeparator1, Me.DataDia, Me.IPServidor, Me.ToolStripSeparator2, Me.BancoDeDados})
        Me.ToolStrip2.Location = New System.Drawing.Point(0, 704)
        Me.ToolStrip2.Name = "ToolStrip2"
        Me.ToolStrip2.Size = New System.Drawing.Size(1264, 25)
        Me.ToolStrip2.TabIndex = 2
        Me.ToolStrip2.Text = "ToolStrip2"
        '
        'NomeUsuario
        '
        Me.NomeUsuario.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.NomeUsuario.Image = CType(resources.GetObject("NomeUsuario.Image"), System.Drawing.Image)
        Me.NomeUsuario.Name = "NomeUsuario"
        Me.NomeUsuario.Size = New System.Drawing.Size(116, 22)
        Me.NomeUsuario.Text = "Nome do Usuário"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'DataDia
        '
        Me.DataDia.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.DataDia.Image = CType(resources.GetObject("DataDia.Image"), System.Drawing.Image)
        Me.DataDia.Name = "DataDia"
        Me.DataDia.Size = New System.Drawing.Size(84, 22)
        Me.DataDia.Text = "Data do Dia"
        '
        'IPServidor
        '
        Me.IPServidor.Image = CType(resources.GetObject("IPServidor.Image"), System.Drawing.Image)
        Me.IPServidor.Name = "IPServidor"
        Me.IPServidor.Size = New System.Drawing.Size(96, 22)
        Me.IPServidor.Text = "IP do Servidor"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'BancoDeDados
        '
        Me.BancoDeDados.Image = CType(resources.GetObject("BancoDeDados.Image"), System.Drawing.Image)
        Me.BancoDeDados.Name = "BancoDeDados"
        Me.BancoDeDados.Size = New System.Drawing.Size(108, 22)
        Me.BancoDeDados.Text = "Banco de Dados"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripButton1})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 25)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.Size = New System.Drawing.Size(1264, 39)
        Me.ToolStrip1.TabIndex = 3
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripButton1
        '
        Me.ToolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.ToolStripButton1.Image = CType(resources.GetObject("ToolStripButton1.Image"), System.Drawing.Image)
        Me.ToolStripButton1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None
        Me.ToolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.ToolStripButton1.Name = "ToolStripButton1"
        Me.ToolStripButton1.Size = New System.Drawing.Size(36, 36)
        Me.ToolStripButton1.Text = "ToolStripButton1"
        '
        'FrmMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.ClientSize = New System.Drawing.Size(1264, 729)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.ToolStrip2)
        Me.Controls.Add(Me.MenuStrip1)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "FrmMenu"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Projeto Sistema"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip2.ResumeLayout(False)
        Me.ToolStrip2.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CadastrosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CidadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ColaboradoresToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProdutosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UnidadesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents UsuáriosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip2 As ToolStrip
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents ToolStripButton1 As ToolStripButton
    Friend WithEvents NomeUsuario As ToolStripLabel
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents DataDia As ToolStripLabel
    Friend WithEvents BancoDeDados As ToolStripLabel
    Friend WithEvents IPServidor As ToolStripLabel
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
End Class
