Imports System.Data.SqlClient
Imports DTO

Public Class ClientesDAL
    Inherits Conexao

    Public Function Gravar(ByVal cliente As ClientesDTO) As Integer
        Try
            AbrirConexao()

            cmd = New SqlCommand("INSERT INTO Clientes(Nome,Endereco,Cidade,Telefone,Email,Ativo) VALUES(@Nome,@Endereco,@Cidade,@Telefone,@Email,@Ativo)")
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@Nome", cliente.Nome)
            cmd.Parameters.AddWithValue("@Endereco", cliente.Endereco)
            cmd.Parameters.AddWithValue("@Cidade", cliente.Cidade)
            cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone)
            cmd.Parameters.AddWithValue("@Email", cliente.Email)
            cmd.Parameters.AddWithValue("@Ativo", cliente.Ativo)

            Return cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            FecharConexao()
        End Try
    End Function

    Public Function Atualizar(ByVal cliente As ClientesDTO) As Integer
        Dim strSQL = ""

        Try
            AbrirConexao()

            strSQL = "UPDATE Clientes SET Nome = @Nome," &
                "Endereco = @Endereco," &
                "Cidade = @Cidade," &
                "Telefone = @Telefone," &
                "Email = @Email," &
                "Ativo = @Ativo " &
                " WHERE IdCliente = @IdCliente"

            cmd = New SqlCommand(strSQL)
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@IdCliente", cliente.IdCliente)
            cmd.Parameters.AddWithValue("@Nome", cliente.Nome)
            cmd.Parameters.AddWithValue("@Endereco", cliente.Endereco)
            cmd.Parameters.AddWithValue("@Cidade", cliente.Cidade)
            cmd.Parameters.AddWithValue("@Telefone", cliente.Telefone)
            cmd.Parameters.AddWithValue("@Email", cliente.Email)
            cmd.Parameters.AddWithValue("@Ativo", cliente.Ativo)

            Return cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            FecharConexao()
        End Try

    End Function

    Public Function Excluir(ByVal id As Integer) As Integer
        Try
            AbrirConexao()
            cmd = New SqlCommand("DELETE FROM Clientes WHERE IdCliente = @IdCliente")
            cmd.Connection = con
            cmd.Parameters.AddWithValue("@IdCliente", id)

            Return cmd.ExecuteNonQuery()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            FecharConexao()
        End Try
    End Function


    Public Function PesquisarPorCodigo(ByVal id As Integer) As ClientesDTO
        Try
            AbrirConexao()
            cmd = New SqlCommand("SELECT * FROM Clientes WHERE IdCliente = @IdCliente")
            cmd.Connection = con
            cmd.CommandType = CommandType.Text
            cmd.Parameters.AddWithValue("@IdCliente", id)

            dr = cmd.ExecuteReader()

            Dim clientes As ClientesDTO = Nothing

            If (dr.Read()) Then

                clientes = New ClientesDTO

                clientes.IdCliente = Convert.ToInt32(dr("IdCliente"))
                clientes.Nome = Convert.ToString(dr("Nome"))
                clientes.Endereco = Convert.ToString(dr("Endereco"))
                clientes.Email = Convert.ToString(dr("Email"))
                clientes.Cidade = Convert.ToString(dr("Cidade"))
                clientes.Telefone = Convert.ToString(dr("Telefone"))
                clientes.Ativo = dr("Ativo")

            End If
            dr.Close()

            Return clientes
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            FecharConexao()
        End Try
    End Function

    Public Function ListarTodos() As List(Of ClientesDTO)

        Try
            AbrirConexao()
            cmd = New SqlCommand("SELECT * FROM Clientes")
            cmd.Connection = con

            dr = cmd.ExecuteReader()

            Dim lista As New List(Of ClientesDTO)


            While (dr.Read())

                Dim clientes As New ClientesDTO

                clientes.IdCliente = Convert.ToInt32(dr("IdCliente"))
                clientes.Nome = Convert.ToString(dr("Nome"))
                clientes.Endereco = Convert.ToString(dr("Endereco"))
                clientes.Email = Convert.ToString(dr("Email"))
                clientes.Cidade = Convert.ToString(dr("Cidade"))
                clientes.Telefone = Convert.ToString(dr("Telefone"))
                clientes.Ativo = dr("Ativo")

                lista.Add(clientes)
            End While

            dr.Close()

            Return lista
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            FecharConexao()
        End Try

    End Function

    'Extra: Pesquisar por nome (com Like)
    '###################################################################
    Public Function PesquisarPorNome(ByVal nome As String) As List(Of ClientesDTO)

        Try
            Dim lista As New List(Of ClientesDTO)

            AbrirConexao()
            cmd = New SqlCommand("SELECT * FROM Clientes WHERE Nome LIKE '%" + nome + "%'")
            cmd.Connection = con
            cmd.CommandType = CommandType.Text

            dr = cmd.ExecuteReader()

            While (dr.Read())
                Dim cliente As New ClientesDTO

                cliente.Nome = Convert.ToString(dr("Nome"))
                cliente.Endereco = Convert.ToString(dr("Endereco"))
                cliente.Email = Convert.ToString(dr("Email"))
                cliente.Cidade = Convert.ToString(dr("Cidade"))
                cliente.Telefone = Convert.ToString(dr("Telefone"))
                cliente.IdCliente = Convert.ToInt32(dr("IdCliente"))
                cliente.Ativo = dr("Ativo")

                lista.Add(cliente)
            End While
            dr.Close()

            Return lista
        Catch ex As Exception
            Throw New Exception(ex.Message)
        Finally
            FecharConexao()

        End Try

    End Function

End Class
