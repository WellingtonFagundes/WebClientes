<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Default.aspx.vb" Inherits="WebClientes._Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link href="Content/bootstrap.css" type="text/css" rel="stylesheet" />
    <script src="Scripts/jquery-1.9.1.min.js"></script>
    <script src="Scripts/bootstrap.min.js"></script>

    <title>Home</title>
</head>
<body>
    <form id="form1" runat="server">
    <div class="jumbotron">
        <h1>Projeto CRUD - Controle de Clientes</h1>
        <hr />
        <asp:Image ID="Image1" runat="server" ImageUrl="~/Image/user.png" />
        Selecione uma opção desejada:
        <asp:DropDownList runat="server" ID="ddlMenu">
            <asp:ListItem Value="0" Text=" - Escolha uma opção - "></asp:ListItem>
            <asp:ListItem Value="1" Text="Cadastrar Cliente"></asp:ListItem>
            <asp:ListItem Value="2" Text="Consultar Cliente"></asp:ListItem>
            <asp:ListItem Value="3" Text="Obter os dados do cliente"></asp:ListItem> 
        </asp:DropDownList>

        <asp:Button runat="server" ID="btnAcessar" CssClass="btn btn-primary" Text="Acessar"
               OnClick="btnAcessar_Click" /> 

        <p>
            <asp:Label runat="server" ID="lblMensagem" ForeColor="Red"></asp:Label>
        </p>
    </div>
    </form>
</body>
</html>
