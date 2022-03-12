<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmCidades
    Inherits System.Windows.Forms.Form

    'Descartar substituições de formulário para limpar a lista de componentes.
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

    'Exigido pelo Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'OBSERVAÇÃO: o procedimento a seguir é exigido pelo Windows Form Designer
    'Pode ser modificado usando o Windows Form Designer.  
    'Não o modifique usando o editor de códigos.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(FrmCidades))
        Me.PnBotoes = New System.Windows.Forms.Panel()
        Me.BtnRelatorios = New System.Windows.Forms.Button()
        Me.BtnExcluir = New System.Windows.Forms.Button()
        Me.BtnAbrir = New System.Windows.Forms.Button()
        Me.BtnNovo = New System.Windows.Forms.Button()
        Me.BtnDados = New System.Windows.Forms.Button()
        Me.TbcDados = New System.Windows.Forms.TabControl()
        Me.TbpPesquisa = New System.Windows.Forms.TabPage()
        Me.PnPesquisa = New System.Windows.Forms.Panel()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TxtPalavraChave = New System.Windows.Forms.TextBox()
        Me.CbxStatus = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.CbxPesquisarPor = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.BtnPesquisar = New System.Windows.Forms.Button()
        Me.PnSelecionar = New System.Windows.Forms.Panel()
        Me.BtnSelecionar = New System.Windows.Forms.Button()
        Me.DgvDados = New System.Windows.Forms.DataGridView()
        Me.TbpRelatorios = New System.Windows.Forms.TabPage()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.PnSelecionarRel = New System.Windows.Forms.Panel()
        Me.BtnSelecionarRel = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.PnBotoes.SuspendLayout()
        Me.TbcDados.SuspendLayout()
        Me.TbpPesquisa.SuspendLayout()
        Me.PnPesquisa.SuspendLayout()
        Me.PnSelecionar.SuspendLayout()
        CType(Me.DgvDados, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TbpRelatorios.SuspendLayout()
        Me.PnSelecionarRel.SuspendLayout()
        Me.SuspendLayout()
        '
        'PnBotoes
        '
        Me.PnBotoes.Controls.Add(Me.BtnRelatorios)
        Me.PnBotoes.Controls.Add(Me.BtnExcluir)
        Me.PnBotoes.Controls.Add(Me.BtnAbrir)
        Me.PnBotoes.Controls.Add(Me.BtnNovo)
        Me.PnBotoes.Controls.Add(Me.BtnDados)
        Me.PnBotoes.Dock = System.Windows.Forms.DockStyle.Left
        Me.PnBotoes.Location = New System.Drawing.Point(0, 0)
        Me.PnBotoes.Name = "PnBotoes"
        Me.PnBotoes.Size = New System.Drawing.Size(130, 729)
        Me.PnBotoes.TabIndex = 0
        '
        'BtnRelatorios
        '
        Me.BtnRelatorios.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnRelatorios.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnRelatorios.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnRelatorios.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnRelatorios.Image = CType(resources.GetObject("BtnRelatorios.Image"), System.Drawing.Image)
        Me.BtnRelatorios.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnRelatorios.Location = New System.Drawing.Point(7, 161)
        Me.BtnRelatorios.Name = "BtnRelatorios"
        Me.BtnRelatorios.Size = New System.Drawing.Size(117, 46)
        Me.BtnRelatorios.TabIndex = 3
        Me.BtnRelatorios.Text = "Relatórios"
        Me.BtnRelatorios.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnRelatorios.UseVisualStyleBackColor = True
        '
        'BtnExcluir
        '
        Me.BtnExcluir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnExcluir.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnExcluir.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnExcluir.Image = CType(resources.GetObject("BtnExcluir.Image"), System.Drawing.Image)
        Me.BtnExcluir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnExcluir.Location = New System.Drawing.Point(7, 109)
        Me.BtnExcluir.Name = "BtnExcluir"
        Me.BtnExcluir.Size = New System.Drawing.Size(117, 46)
        Me.BtnExcluir.TabIndex = 2
        Me.BtnExcluir.Text = "Excluir"
        Me.BtnExcluir.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnExcluir.UseVisualStyleBackColor = True
        '
        'BtnAbrir
        '
        Me.BtnAbrir.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnAbrir.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnAbrir.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnAbrir.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnAbrir.Image = CType(resources.GetObject("BtnAbrir.Image"), System.Drawing.Image)
        Me.BtnAbrir.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnAbrir.Location = New System.Drawing.Point(7, 57)
        Me.BtnAbrir.Name = "BtnAbrir"
        Me.BtnAbrir.Size = New System.Drawing.Size(117, 46)
        Me.BtnAbrir.TabIndex = 1
        Me.BtnAbrir.Text = "Abrir"
        Me.BtnAbrir.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnAbrir.UseVisualStyleBackColor = True
        '
        'BtnNovo
        '
        Me.BtnNovo.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnNovo.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnNovo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnNovo.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnNovo.Image = CType(resources.GetObject("BtnNovo.Image"), System.Drawing.Image)
        Me.BtnNovo.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnNovo.Location = New System.Drawing.Point(7, 5)
        Me.BtnNovo.Name = "BtnNovo"
        Me.BtnNovo.Size = New System.Drawing.Size(117, 46)
        Me.BtnNovo.TabIndex = 0
        Me.BtnNovo.Text = "Novo"
        Me.BtnNovo.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnNovo.UseVisualStyleBackColor = True
        '
        'BtnDados
        '
        Me.BtnDados.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnDados.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnDados.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnDados.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnDados.Image = CType(resources.GetObject("BtnDados.Image"), System.Drawing.Image)
        Me.BtnDados.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnDados.Location = New System.Drawing.Point(7, 5)
        Me.BtnDados.Name = "BtnDados"
        Me.BtnDados.Size = New System.Drawing.Size(117, 46)
        Me.BtnDados.TabIndex = 4
        Me.BtnDados.Text = "Pesquisa"
        Me.BtnDados.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnDados.UseVisualStyleBackColor = True
        '
        'TbcDados
        '
        Me.TbcDados.Alignment = System.Windows.Forms.TabAlignment.Bottom
        Me.TbcDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TbcDados.Controls.Add(Me.TbpPesquisa)
        Me.TbcDados.Controls.Add(Me.TbpRelatorios)
        Me.TbcDados.Location = New System.Drawing.Point(136, 12)
        Me.TbcDados.Name = "TbcDados"
        Me.TbcDados.Padding = New System.Drawing.Point(50, 3)
        Me.TbcDados.SelectedIndex = 0
        Me.TbcDados.Size = New System.Drawing.Size(1116, 705)
        Me.TbcDados.TabIndex = 1
        '
        'TbpPesquisa
        '
        Me.TbpPesquisa.Controls.Add(Me.PnPesquisa)
        Me.TbpPesquisa.Controls.Add(Me.PnSelecionar)
        Me.TbpPesquisa.Controls.Add(Me.DgvDados)
        Me.TbpPesquisa.Location = New System.Drawing.Point(4, 4)
        Me.TbpPesquisa.Name = "TbpPesquisa"
        Me.TbpPesquisa.Padding = New System.Windows.Forms.Padding(3)
        Me.TbpPesquisa.Size = New System.Drawing.Size(1108, 677)
        Me.TbpPesquisa.TabIndex = 0
        Me.TbpPesquisa.Text = "Pesquisa"
        Me.TbpPesquisa.UseVisualStyleBackColor = True
        '
        'PnPesquisa
        '
        Me.PnPesquisa.Controls.Add(Me.Label3)
        Me.PnPesquisa.Controls.Add(Me.TxtPalavraChave)
        Me.PnPesquisa.Controls.Add(Me.CbxStatus)
        Me.PnPesquisa.Controls.Add(Me.Label2)
        Me.PnPesquisa.Controls.Add(Me.CbxPesquisarPor)
        Me.PnPesquisa.Controls.Add(Me.Label1)
        Me.PnPesquisa.Controls.Add(Me.BtnPesquisar)
        Me.PnPesquisa.Dock = System.Windows.Forms.DockStyle.Top
        Me.PnPesquisa.Location = New System.Drawing.Point(3, 3)
        Me.PnPesquisa.Name = "PnPesquisa"
        Me.PnPesquisa.Size = New System.Drawing.Size(1102, 85)
        Me.PnPesquisa.TabIndex = 0
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(318, 19)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(81, 15)
        Me.Label3.TabIndex = 10
        Me.Label3.Text = "Palavra Chave"
        '
        'TxtPalavraChave
        '
        Me.TxtPalavraChave.Location = New System.Drawing.Point(318, 37)
        Me.TxtPalavraChave.Name = "TxtPalavraChave"
        Me.TxtPalavraChave.Size = New System.Drawing.Size(278, 23)
        Me.TxtPalavraChave.TabIndex = 9
        '
        'CbxStatus
        '
        Me.CbxStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxStatus.FormattingEnabled = True
        Me.CbxStatus.Items.AddRange(New Object() {"Ativo", "Inativo", "Todos"})
        Me.CbxStatus.Location = New System.Drawing.Point(202, 37)
        Me.CbxStatus.Name = "CbxStatus"
        Me.CbxStatus.Size = New System.Drawing.Size(110, 23)
        Me.CbxStatus.TabIndex = 8
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(202, 19)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(39, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Status"
        '
        'CbxPesquisarPor
        '
        Me.CbxPesquisarPor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CbxPesquisarPor.FormattingEnabled = True
        Me.CbxPesquisarPor.Items.AddRange(New Object() {"Código", "Cidade", "UF"})
        Me.CbxPesquisarPor.Location = New System.Drawing.Point(20, 37)
        Me.CbxPesquisarPor.Name = "CbxPesquisarPor"
        Me.CbxPesquisarPor.Size = New System.Drawing.Size(176, 23)
        Me.CbxPesquisarPor.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(20, 19)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 15)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Pesquisar Por"
        '
        'BtnPesquisar
        '
        Me.BtnPesquisar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.BtnPesquisar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnPesquisar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnPesquisar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnPesquisar.Image = CType(resources.GetObject("BtnPesquisar.Image"), System.Drawing.Image)
        Me.BtnPesquisar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnPesquisar.Location = New System.Drawing.Point(972, 19)
        Me.BtnPesquisar.Name = "BtnPesquisar"
        Me.BtnPesquisar.Size = New System.Drawing.Size(117, 46)
        Me.BtnPesquisar.TabIndex = 4
        Me.BtnPesquisar.Text = "Pesquisar"
        Me.BtnPesquisar.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnPesquisar.UseVisualStyleBackColor = True
        '
        'PnSelecionar
        '
        Me.PnSelecionar.Controls.Add(Me.BtnSelecionar)
        Me.PnSelecionar.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnSelecionar.Location = New System.Drawing.Point(3, 589)
        Me.PnSelecionar.Name = "PnSelecionar"
        Me.PnSelecionar.Size = New System.Drawing.Size(1102, 85)
        Me.PnSelecionar.TabIndex = 1
        Me.PnSelecionar.Visible = False
        '
        'BtnSelecionar
        '
        Me.BtnSelecionar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSelecionar.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnSelecionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSelecionar.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnSelecionar.Image = CType(resources.GetObject("BtnSelecionar.Image"), System.Drawing.Image)
        Me.BtnSelecionar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSelecionar.Location = New System.Drawing.Point(972, 19)
        Me.BtnSelecionar.Name = "BtnSelecionar"
        Me.BtnSelecionar.Size = New System.Drawing.Size(117, 46)
        Me.BtnSelecionar.TabIndex = 4
        Me.BtnSelecionar.Text = "Selecionar"
        Me.BtnSelecionar.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnSelecionar.UseVisualStyleBackColor = True
        '
        'DgvDados
        '
        Me.DgvDados.AllowUserToAddRows = False
        Me.DgvDados.AllowUserToDeleteRows = False
        Me.DgvDados.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.DgvDados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDados.Location = New System.Drawing.Point(3, 94)
        Me.DgvDados.Name = "DgvDados"
        Me.DgvDados.ReadOnly = True
        Me.DgvDados.RowTemplate.Height = 25
        Me.DgvDados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DgvDados.Size = New System.Drawing.Size(1102, 577)
        Me.DgvDados.TabIndex = 4
        '
        'TbpRelatorios
        '
        Me.TbpRelatorios.Controls.Add(Me.ListBox1)
        Me.TbpRelatorios.Controls.Add(Me.PnSelecionarRel)
        Me.TbpRelatorios.Location = New System.Drawing.Point(4, 4)
        Me.TbpRelatorios.Name = "TbpRelatorios"
        Me.TbpRelatorios.Padding = New System.Windows.Forms.Padding(3)
        Me.TbpRelatorios.Size = New System.Drawing.Size(1108, 677)
        Me.TbpRelatorios.TabIndex = 1
        Me.TbpRelatorios.Text = "Relatórios"
        Me.TbpRelatorios.UseVisualStyleBackColor = True
        '
        'ListBox1
        '
        Me.ListBox1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.ItemHeight = 15
        Me.ListBox1.Items.AddRange(New Object() {"Não existem relatórios."})
        Me.ListBox1.Location = New System.Drawing.Point(3, 3)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(1102, 586)
        Me.ListBox1.TabIndex = 3
        '
        'PnSelecionarRel
        '
        Me.PnSelecionarRel.Controls.Add(Me.BtnSelecionarRel)
        Me.PnSelecionarRel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.PnSelecionarRel.Location = New System.Drawing.Point(3, 589)
        Me.PnSelecionarRel.Name = "PnSelecionarRel"
        Me.PnSelecionarRel.Size = New System.Drawing.Size(1102, 85)
        Me.PnSelecionarRel.TabIndex = 2
        Me.PnSelecionarRel.Visible = False
        '
        'BtnSelecionarRel
        '
        Me.BtnSelecionarRel.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BtnSelecionarRel.FlatAppearance.BorderColor = System.Drawing.Color.Silver
        Me.BtnSelecionarRel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BtnSelecionarRel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.BtnSelecionarRel.Image = CType(resources.GetObject("BtnSelecionarRel.Image"), System.Drawing.Image)
        Me.BtnSelecionarRel.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.BtnSelecionarRel.Location = New System.Drawing.Point(972, 19)
        Me.BtnSelecionarRel.Name = "BtnSelecionarRel"
        Me.BtnSelecionarRel.Size = New System.Drawing.Size(117, 46)
        Me.BtnSelecionarRel.TabIndex = 4
        Me.BtnSelecionarRel.Text = "Selecionar"
        Me.BtnSelecionarRel.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        Me.BtnSelecionarRel.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.Location = New System.Drawing.Point(136, 694)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(327, 31)
        Me.Panel1.TabIndex = 2
        '
        'FrmCidades
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1264, 729)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TbcDados)
        Me.Controls.Add(Me.PnBotoes)
        Me.MaximizeBox = False
        Me.Name = "FrmCidades"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cidades"
        Me.PnBotoes.ResumeLayout(False)
        Me.TbcDados.ResumeLayout(False)
        Me.TbpPesquisa.ResumeLayout(False)
        Me.PnPesquisa.ResumeLayout(False)
        Me.PnPesquisa.PerformLayout()
        Me.PnSelecionar.ResumeLayout(False)
        CType(Me.DgvDados, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TbpRelatorios.ResumeLayout(False)
        Me.PnSelecionarRel.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents PnBotoes As Panel
    Friend WithEvents BtnRelatorios As Button
    Friend WithEvents BtnExcluir As Button
    Friend WithEvents BtnAbrir As Button
    Friend WithEvents BtnNovo As Button
    Friend WithEvents TbcDados As TabControl
    Friend WithEvents TbpPesquisa As TabPage
    Friend WithEvents TbpRelatorios As TabPage
    Friend WithEvents PnPesquisa As Panel
    Friend WithEvents BtnPesquisar As Button
    Friend WithEvents PnSelecionar As Panel
    Friend WithEvents BtnSelecionar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TxtPalavraChave As TextBox
    Friend WithEvents CbxStatus As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents CbxPesquisarPor As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents BtnDados As Button
    Friend WithEvents PnSelecionarRel As Panel
    Friend WithEvents BtnSelecionarRel As Button
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents DgvDados As DataGridView
End Class
