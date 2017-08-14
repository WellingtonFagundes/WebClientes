Imports System.Data.SqlClient

Public Class Conexao

    Protected con As SqlConnection
    Protected cmd As SqlCommand
    Protected dr As SqlDataReader

    Protected Sub AbrirConexao()
        Try
            con = New SqlConnection("Data Source=NOTE;Initial Catalog=CRUD;Integrated Security=true")
            con.Open()
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub

    Protected Sub FecharConexao()
        Try
            If (con.State = ConnectionState.Open) Then
                con.Close()
            End If
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Sub


End Class
