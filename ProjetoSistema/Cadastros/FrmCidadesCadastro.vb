Imports MySql.Data.MySqlClient

Public Class FrmCidadesCadastro
    Dim Pesquisa As String
    Dim conn As New MySqlConnection
    Dim myCommand As New MySqlCommand
    Dim myAdapter As New MySqlDataAdapter
    Dim myData As New DataTable
    Dim myReader As MySqlDataReader
    Dim Item As String
    Public Modo As String
    Dim ds As DataSet = Nothing

    Private Sub LimparText()
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        ComboBox1.Text = ""
        CheckBox1.Checked = True
    End Sub

    Private Sub Salvar()
        If MessageBox.Show("Deseja realmente salvar?", "Salvar", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.No Then

            Me.Close()
            Exit Sub

        Else
            Dim sql As String

            Dim Conexao As New ConexaoBD
            Dim conn As New MySqlConnection(Conexao.strCon)

            If Modo = "Inclusão" Then
                sql = "Insert into cidades set cidade = '" & TextBox2.Text & "', uf = '" & ComboBox1.Text & "', codigo_ibge = '" & TextBox3.Text & "', status = " & CheckBox1.Checked
            Else
                sql = "update cidades set cidade = '" & TextBox2.Text & "', uf = '" & ComboBox1.Text & "', codigo_ibge = '" & TextBox3.Text & "', status = " & CheckBox1.Checked & " where id = '" & TextBox1.Text & "'"
            End If

            Try

                conn.Open()
                myCommand = New MySqlCommand(sql, conn)
                myCommand.ExecuteNonQuery()

                conn.Dispose()

            Catch ex As Exception
                MsgBox(“Houve um erro ao gravar”)
            End Try

            LimparText()
            Me.Close()

        End If
    End Sub

    Private Sub BtnSalvar_Click(sender As Object, e As EventArgs) Handles BtnSalvar.Click
        Salvar()
    End Sub

    Private Sub BtnCancelar_Click(sender As Object, e As EventArgs) Handles BtnCancelar.Click
        Salvar()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

        If TextBox1.Text <> "" Then

            Pesquisa = "Select * from cidades where id = '" & TextBox1.Text & "'"

            Dim Conexao As New ConexaoBD
            Dim conn As New MySqlConnection(Conexao.strCon)

            myCommand.Connection = conn
            myCommand.CommandText = Pesquisa
            conn.Open()

            myReader = myCommand.ExecuteReader()
            myReader.Read()

            TextBox2.Text = myReader("cidade").ToString
            TextBox3.Text = myReader("codigo_ibge").ToString
            ComboBox1.Text = myReader("uf").ToString
            CheckBox1.Checked = myReader("status")
        End If
    End Sub

    Private Sub FrmCidadesCadastro_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class