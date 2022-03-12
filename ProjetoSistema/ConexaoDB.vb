Imports Microsoft.VisualBasic
Imports MySql.Data.MySqlClient
Imports System

Public Class ConexaoBD
    'Variavel Privada, variavel conexao.
    Public strCon As String

    'Método Construtor
    Public Sub New()
        Dim host As String
        Dim user As String
        Dim pass As String
        Dim banco As String
        Dim port As String

        host = "localhost"
        user = "root"
        pass = "m4n5mn45"
        banco = "projeto_sistema"
        port = "3306"


        strCon = "server=" & host & "; user id=" & user & "; password=" & pass & "; database=" & banco & "; port=" & port & ";"
    End Sub

    Public Function Conectar() As Boolean

        Dim Conexao As New MySqlConnection(strCon)

        Try
            Conexao.Open()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        'retorna variavel State Open 1, Close 0
        Return Conexao.State

    End Function
End Class
