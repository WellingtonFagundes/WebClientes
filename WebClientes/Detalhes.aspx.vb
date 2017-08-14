Imports BLL
Imports DTO

Public Class Detalhes
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        pnlDados.Visible = False
    End Sub

    Protected Sub btnPesquisa_Click(sender As Object, e As EventArgs) Handles btnPesquisa.Click
        Try
            Dim cod As Integer
            cod = Integer.Parse(txtCodigo.Text)

            Dim clientesBLL As New ClientesBLL
            Dim clientes As New ClientesDTO

            clientes = clientesBLL.PesquisarPorCodigo(cod)

            If (Not clientes Is Nothing) Then
                pnlDados.Visible = True

                txtNome.Text = clientes.Nome
                txtEndereco.Text = clientes.Endereco
                txtEmail.Text = clientes.Cidade
                txtCidade.Text = clientes.Cidade
                txtTelefone.Text = clientes.Telefone

                If clientes.Ativo = True Then
                    rbtAtivo.Checked = True
                Else
                    rbtInativo.Checked = True
                End If
            Else
                pnlDados.Visible = False
                lblMensagem.Text = "Cliente não localizado"
                txtCodigo.Text = String.Empty
            End If
        Catch ex As Exception
            lblMensagem.Text = ex.Message
        End Try
    End Sub

    Protected Sub btnAtualizar_Click(sender As Object, e As EventArgs) Handles btnAtualizar.Click
        Try
            Dim clientes As New ClientesDTO
            clientes.IdCliente = Integer.Parse(txtCodigo.Text)
            clientes.Nome = txtNome.Text
            clientes.Endereco = txtEndereco.Text
            clientes.Email = txtEmail.Text
            clientes.Cidade = txtCidade.Text
            clientes.Telefone = txtTelefone.Text

            If rbtAtivo.Checked Then
                clientes.Ativo = True
            Else
                clientes.Ativo = False
            End If

            Dim clientesBLL As New ClientesBLL
            Dim result As Integer

            result = clientesBLL.Atualizar(clientes)

            If (result > 0) Then
                lblMensagem.Text = "Cliente alterado com sucesso!!"
                txtNome.Text = ""
                txtEndereco.Text = ""
                txtEmail.Text = ""
                txtCidade.Text = ""
                txtTelefone.Text = ""
                rbtAtivo.Checked = True
                rbtInativo.Checked = False
            End If

        Catch ex As Exception
            lblMensagem.Text = ex.Message
        End Try
    End Sub

    Protected Sub btnExcluir_Click(sender As Object, e As EventArgs) Handles btnExcluir.Click
        Try
            Dim cod, result As Integer
            Dim clientesBLL As New ClientesBLL

            cod = Integer.Parse(txtCodigo.Text)
            result = clientesBLL.Excluir(cod)

            If (result > 0) Then
                lblMensagem.Text = "Exclusão efetuada com sucesso!!"
                txtNome.Text = ""
                txtEndereco.Text = ""
                txtEmail.Text = ""
                txtCidade.Text = ""
                txtTelefone.Text = ""
                rbtAtivo.Checked = True
                rbtInativo.Checked = False
            End If
        Catch ex As Exception
            lblMensagem.Text = ex.Message
        End Try
    End Sub
End Class