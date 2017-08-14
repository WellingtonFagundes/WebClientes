<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Detalhes.aspx.vb" Inherits="WebClientes.Detalhes" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.css" rel="stylesheet" type="text/css" />
    <script src="Scripts/bootstrap.min.js"></script>
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="container">
        <div class="col-lg-offset-1">
            <div class="row">
                <h3 class="well">Detalhes do Cliente <asp:Image runat="server" ID="imgDetalhes" ImageUrl="~/Image/edit-11-32.ico" /></h3>
                <hr />
                <br />
                Informe o Código:<br />
                <asp:TextBox ID="txtCodigo" runat="server" CssClass="form-control" Width="5%"></asp:TextBox>
                <br />
                <asp:Button ID="btnPesquisa" runat="server" CssClass="btn btn-primary" Text="Pesquisar" OnClick="btnPesquisa_Click" />
                <a href="Default.aspx" class="btn btn-default">Voltar</a>
                <br /><br />
                
                <p>
                    <asp:Label ID="lblMensagem" runat="server" ForeColor="Red"></asp:Label>
                </p>                

                <asp:Panel ID="pnlDados" runat="server">
                    Nome:<br />
                    <asp:TextBox ID="txtNome" CssClass="form-control" runat="server" Width="45%"></asp:TextBox>
                    <br /><br />

                    Endereço:<br />
                    <asp:TextBox ID="txtEndereco" CssClass="form-control" runat="server" Width="45%"></asp:TextBox>
                    <br /><br />

                    Email:<br />
                    <asp:TextBox ID="txtEmail" CssClass="form-control" runat="server" Width="45%"></asp:TextBox>
                    <br /><br />

                    Cidade:<br />
                    <asp:TextBox ID="txtCidade" CssClass="form-control" runat="server" Width="35%"></asp:TextBox>
                    <br /><br />

                    Telefone:<br />
                    <asp:TextBox ID="txtTelefone" CssClass="form-control" runat="server" Width="30%"></asp:TextBox>
                    <br /><br />

                    <asp:RadioButton ID="rbtAtivo" Text="Ativo"  runat="server" GroupName="ClienteGroup"/>
                    <asp:RadioButton ID="rbtInativo" Text="Inativo" runat="server"  GroupName="ClienteGroup"/>
                    <br />

                    <asp:Button ID="btnAtualizar" Text="Atualizar" CssClass="btn btn-success" runat="server" />&nbsp
                    <asp:Button ID="btnExcluir" Text="Excluir" CssClass="btn btn-danger" runat="server" />
                </asp:Panel>

            </div>
        </div>
    </div>
    </form>
</body>
</html>
