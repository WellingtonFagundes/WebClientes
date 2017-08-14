Imports BLL

Public Class Consulta
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

        Try
            Dim clienteBLL As New ClientesBLL

            grvClientes.DataSource = clienteBLL.ListarTodos()
            grvClientes.DataBind()
        Catch ex As Exception
            lblMensagem.Text = ex.Message
        End Try
    End Sub

    Protected Sub btnPesquisar_Click(sender As Object, e As EventArgs)
        Try
            Dim clientePesqBLL As New ClientesBLL
            Dim strNome As String

            strNome = txtNomePesquisa.Text
            lblMensagem.Text = String.Empty

            grvClientes.DataSource = clientePesqBLL.PesquisarPorNome(strNome)
            grvClientes.DataBind()

            If (grvClientes.Rows.Count = 0) Then
                lblMensagem.Text = "Nenhum cliente foi encontrado com a pesquisa informada!!"
                lblMensagem.ForeColor = Drawing.Color.Blue
            End If
        Catch ex As Exception
            lblMensagem.Text = ex.Message
        End Try
    End Sub
End Class