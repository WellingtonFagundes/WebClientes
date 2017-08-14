<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Cadastro.aspx.vb" Inherits="WebClientes.Cadastro" %>

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
        <div class="span10 offset1">
            <div class="row">
                <h3 class="well">Cadastro de Clientes <asp:Image ID="Image1" runat="server" ImageUrl="~/Image/add-folder-32.ico"/></h3>
                
                <br />

                Nome:<br />
                <asp:TextBox ID="txtNome" runat="server" placeholder="Digite o nome" CssClass="form-control" Width="45%"></asp:TextBox>
                <asp:RequiredFieldValidator
                    runat="server"
                    ControlToValidate="txtNome"
                    ErrorMessage = "Por favor digite o nome"
                    ForeColor="Red">
                </asp:RequiredFieldValidator>
                <br />

                Endereço: <br />
                <asp:TextBox ID="txtEndereco" runat="server" placeholder="Digite o Endereço" CssClass="form-control" Width="45%"></asp:TextBox>
                <asp:RequiredFieldValidator
                    runat="server"
                    ControlToValidate="txtEndereco"
                    ErrorMessage ="Por favor digite o endereço"
                    ForeColor="Red">
                </asp:RequiredFieldValidator>
                <br />

                Cidade: <br />
                <asp:TextBox ID="txtCidade" runat="server" placeholder="Digite a cidade" CssClass="form-control" Width="40%"></asp:TextBox>
                <asp:RequiredFieldValidator
                    runat="server"
                    ControlToValidate="txtCidade"
                    ErrorMessage = "Por favor digite a cidade"
                    ForeColor="Red"></asp:RequiredFieldValidator>
                <br />

                Telefone: <br />
                <asp:TextBox ID="txtTelefone" runat="server" placeholder="Digite o telefone" CssClass="form-control" Width="40%"></asp:TextBox>
                <asp:RequiredFieldValidator
                    runat="server"
                    ControlToValidate="txtTelefone"
                    ErrorMessage ="Por favor digite o telefone"
                    ForeColor="Red">
                </asp:RequiredFieldValidator>
                <br />

                Email: <br />
                <asp:TextBox ID="txtEmail" runat="server" placeholder="Digite o email" CssClass="form-control" Width="35%">
                </asp:TextBox>
                <asp:RequiredFieldValidator
                    runat="server"
                    ControlToValidate="txtEmail"
                    ErrorMessage = "Por favor digite o email"
                    ForeColor="Red">
                </asp:RequiredFieldValidator>
                <br />

                <asp:RadioButton ID="rbtAtivo" runat="server" Text="Ativo" GroupName="ClienteGroup"/>
 
                <asp:RadioButton ID="rbtInativo" runat="server"  Text="Inativo" GroupName="ClienteGroup"/>
                
                <p>
                    <asp:Label runat="server" ID="lblMensagem" ForeColor="Red"></asp:Label>
                </p>

                <asp:Button runat="server" ID="btnCadastrar" CssClass="btn btn-success" Text="Cadastrar" OnClick="btnCadastrar_Click" />
                <a href="Default.aspx" class="btn btn-default">Voltar</a>
            </div>
        </div>
    </div>
    </form>
</body>
</html>
