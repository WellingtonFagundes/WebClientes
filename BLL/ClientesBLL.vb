Imports DAL
Imports DTO

Public Class ClientesBLL

    Public Function Gravar(ByVal cliente As ClientesDTO) As Integer
        Dim db As New ClientesDAL
        Dim cod As Integer

        Try
            cod = db.Gravar(cliente)

            Return cod

        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

    End Function

    Public Function Atualizar(ByVal cliente As ClientesDTO) As Integer
        Dim db As New ClientesDAL
        Dim cod As Integer

        Try
            cod = db.Atualizar(cliente)
            Return cod
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function Excluir(ByVal id As Integer) As Integer
        Dim db As New ClientesDAL
        Dim cod As Integer

        Try
            cod = db.Excluir(id)

            Return cod
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function PesquisarPorCodigo(ByVal id As Integer) As ClientesDTO
        Dim db As New ClientesDAL
        Dim cliente As New ClientesDTO

        Try
            cliente = db.PesquisarPorCodigo(id)
            Return cliente
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ListarTodos() As List(Of ClientesDTO)
        Dim db As New ClientesDAL
        Dim lista As List(Of ClientesDTO)

        Try
            lista = db.ListarTodos()

            Return lista
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function PesquisarPorNome(ByVal nome As String) As List(Of ClientesDTO)
        Dim db As New ClientesDAL
        Dim lista As List(Of ClientesDTO)

        Try
            lista = db.PesquisarPorNome(nome)

            Return lista
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function
End Class
