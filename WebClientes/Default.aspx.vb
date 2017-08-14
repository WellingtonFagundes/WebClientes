Public Class _Default
    Inherits System.Web.UI.Page

    Protected Sub Page_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load

    End Sub

    Protected Sub btnAcessar_Click(sender As Object, e As EventArgs)

        If (ddlMenu.SelectedValue() = "0") Then
            lblMensagem.Text = "Por favor selecione uma opção válida"
        ElseIf (ddlMenu.SelectedValue() = "1") Then
            Response.Redirect("Cadastro.aspx")
        ElseIf (ddlMenu.SelectedValue = "2") Then
            Response.Redirect("Consulta.aspx")
        ElseIf (ddlMenu.SelectedValue() = "3") Then
            Response.Redirect("Detalhes.aspx")
        End If


    End Sub
End Class