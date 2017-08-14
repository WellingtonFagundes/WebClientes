Imports BLL
Imports DTO

Public Class Cadastro
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnCadastrar_Click(sender As Object, e As EventArgs)
        Try
            Dim cod As Integer
            Dim cliente As New ClientesDTO
            cliente.Nome = txtNome.Text
            cliente.Endereco = txtEndereco.Text
            cliente.Cidade = txtCidade.Text
            cliente.Email = txtEmail.Text
            cliente.Telefone = txtTelefone.Text

            If (rbtAtivo.Checked) Then
                cliente.Ativo = True
            Else
                cliente.Ativo = False
            End If

            Dim clientesBLL As New ClientesBLL
            cod = clientesBLL.Gravar(cliente)

            If (cod > 0) Then
                lblMensagem.Text = "Cliente " + cliente.Nome + " inserido com sucesso!"
                txtCidade.Text = ""
                txtEmail.Text = ""
                txtEndereco.Text = ""
                txtNome.Text = ""
                txtTelefone.Text = ""
                rbtAtivo.Checked = True
                rbtInativo.Checked = False
            End If

        Catch ex As Exception
            lblMensagem.Text = ex.Message
        End Try
    End Sub
End Class