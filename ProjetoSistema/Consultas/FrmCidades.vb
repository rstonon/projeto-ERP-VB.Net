Imports MySql.Data.MySqlClient

Public Class FrmCidades
    Dim conn As New MySqlConnection ' referencia necessaria ADOBD
    Dim Pesquisa As String
    Dim myCommand As New MySqlCommand
    Dim myAdapter As New MySqlDataAdapter
    Dim myData As New DataTable
    Dim myReader As MySqlDataReader
    Dim ds As DataSet = Nothing

    Dim Item As String


    Private Sub AlteraBotoes(op)

        BtnNovo.Visible = False
        BtnAbrir.Visible = False
        BtnExcluir.Visible = False
        BtnRelatorios.Visible = False
        BtnDados.Visible = False
        TbcDados.Visible = False

        BtnSelecionar.Visible = False
        PnSelecionarRel.Visible = False
        ListBox1.Visible = False


        If (op = 1) Then
            BtnNovo.Visible = True
            BtnAbrir.Visible = True
            BtnExcluir.Visible = True
            BtnRelatorios.Visible = True
            BtnDados.Visible = False
            TbcDados.Visible = True
            TbcDados.SelectTab(0)
        End If

        If (op = 2) Then
            BtnNovo.Visible = False
            BtnAbrir.Visible = False
            BtnExcluir.Visible = False
            BtnRelatorios.Visible = False
            BtnDados.Visible = True
            ListBox1.Visible = True
            PnSelecionarRel.Visible = True
            TbcDados.Visible = True
            TbcDados.SelectTab(1)
        End If

    End Sub

    Private Sub PesquisaSql()

        Dim status As String
        status = ""

        If CbxStatus.Text <> "Todos" Then
            If CbxStatus.Text = "Inativo" Then
                status = " and status = 0"
            End If
            If CbxStatus.Text = "Ativo" Then
                status = " and status = 1"
            End If
        End If

            If CbxPesquisarPor.Text = "Cidade" Then
            Pesquisa = "Select * from cidades where cidade like '%" & TxtPalavraChave.Text & "%'" & status
        End If

        If CbxPesquisarPor.Text = "Código" Then
            Pesquisa = "Select * from cidades where id = '" & TxtPalavraChave.Text & "'" & status
        End If

        If CbxPesquisarPor.Text = "UF" Then
            Pesquisa = "Select * from cidades where uf = '" & TxtPalavraChave.Text & "'" & status
        End If

        CarregarGrid()

    End Sub

    Public Sub CarregarGrid()

        Dim Conexao As New ConexaoBD
        Dim conn As New MySqlConnection(Conexao.strCon)

        Try
            conn.Open()

            Try
                myData.Clear()

                myCommand.Connection = conn
                myCommand.CommandText = Pesquisa
                myAdapter.SelectCommand = myCommand
                myAdapter.Fill(myData)
                DgvDados.DataSource = myData
                DgvDados.Columns.Item(0).HeaderText = "Código"
                DgvDados.Columns.Item(0).Width = 80
                DgvDados.Columns.Item(1).HeaderText = "Cidade"
                DgvDados.Columns.Item(1).Width = 800
                DgvDados.Columns.Item(2).HeaderText = "UF"
                DgvDados.Columns.Item(2).Width = 60
                DgvDados.Columns.Item(3).Visible = False
                DgvDados.Columns.Item(4).Visible = False
            Catch myerro As MySqlException

                MsgBox("Erro de leitura no banco de dados : " & myerro.Message)

            End Try

            conn.Close()

        Catch myerro As MySqlException

            MessageBox.Show("Erro ao conectar com o Banco de dados : " & myerro.Message)

        Finally
            conn.Dispose()
        End Try

    End Sub

    Private Sub Excluir()
        Dim sql As String

        Item = DgvDados.CurrentRow.Cells("id").Value.ToString

        If Item = "" Then
            MsgBox("Selecione Corretamente um Item", vbInformation)
            DgvDados.Select()
            Exit Sub
        End If

        Dim Conexao As New ConexaoBD
        Dim conn As New MySqlConnection(Conexao.strCon)

        If MessageBox.Show("Tem certeza que deseja excluir o registro?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then
            Exit Sub
        End If

        sql = "delete from cidades where id = '" & Item & "'"

        Try
            conn.Open()
            myCommand = New MySqlCommand(sql, conn)
            myCommand.ExecuteNonQuery()

            conn.Dispose()

        Catch ex As Exception
            MsgBox(“Houve um erro ao excluir o registro!”)
        End Try
        CarregarGrid()
    End Sub

    Private Sub Abrir()
        If DgvDados.Rows.Count > 0 Then
            Item = DgvDados.CurrentRow.Cells("id").Value.ToString
        End If

        If Item = "" Then
            MessageBox.Show("Selecione Corretamente um Item", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information)
            DgvDados.Select()
            Exit Sub
        End If

        FrmCidadesCadastro.TextBox1.Text = Item
        FrmCidadesCadastro.Modo = "Edição"
        FrmCidadesCadastro.ShowDialog(Me)

    End Sub

    Private Sub FrmCidades_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CbxPesquisarPor.Text = "Cidade"
        CbxStatus.Text = "Ativo"
    End Sub

    Private Sub BtnRelatorios_Click(sender As Object, e As EventArgs) Handles BtnRelatorios.Click
        AlteraBotoes(2)
    End Sub

    Private Sub BtnDados_Click(sender As Object, e As EventArgs) Handles BtnDados.Click
        AlteraBotoes(1)
    End Sub

    Private Sub BtnNovo_Click(sender As Object, e As EventArgs) Handles BtnNovo.Click
        FrmCidadesCadastro.Modo = "Inclusão"
        FrmCidadesCadastro.ShowDialog()

    End Sub

    Private Sub BtnPesquisar_Click(sender As Object, e As EventArgs) Handles BtnPesquisar.Click
        PesquisaSql()
    End Sub

    Private Sub BtnExcluir_Click(sender As Object, e As EventArgs) Handles BtnExcluir.Click
        Excluir()
    End Sub

    Private Sub BtnAbrir_Click(sender As Object, e As EventArgs) Handles BtnAbrir.Click
        Abrir()
    End Sub

    Private Sub DgvDados_DoubleClick(sender As Object, e As EventArgs) Handles DgvDados.DoubleClick
        Abrir()
    End Sub
End Class