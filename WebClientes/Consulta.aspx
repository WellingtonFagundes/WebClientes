<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Consulta.aspx.vb" Inherits="WebClientes.Consulta" %>

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
        <div class="span10 col-lg-offset-1">
            <div class="row">
                <h3 class="well">Consulta de Clientes <asp:Image runat="server" ID="imgConsulta" ImageUrl="~/Image/Ver.ico" /></h3>

                <asp:GridView runat="server" ID="grvClientes" CssClass="table table-hover"
                    GridLines="None" AutoGenerateColumns="false" BackColor="Turquoise">

                    <Columns>
                        <asp:BoundField HeaderText="Código" DataField="idCliente" />
                        <asp:BoundField HeaderText="Nome" DataField="Nome" />
                        <asp:BoundField HeaderText="Endereço" DataField="Endereco" />
                        <asp:BoundField HeaderText="Email" DataField="Email" />
                        <asp:BoundField HeaderText="Cidade" DataField="Cidade" />
                        <asp:BoundField HeaderText="Telefone" DataField="Telefone" />
                        <asp:BoundField HeaderText="Ativo?" DataField="Ativo" />
                    </Columns>
                    <RowStyle CssClass="cursor-pointer" />

                </asp:GridView>

                <p>
                    <asp:Label ID="lblMensagem" runat="server" ForeColor="Red"></asp:Label>
                </p>

                <p>
                    Informe um nome para pesquisa:
                    <asp:TextBox runat="server" ID="txtNomePesquisa" CssClass="form-control" Width="45%"></asp:TextBox>
                    <asp:Button runat="server" ID="btnPesquisar" Text="Pesquisar" CssClass="btn btn-primary"  OnClick="btnPesquisar_Click"/> &nbsp
                    <a href="Default.aspx" class="btn btn-default">Voltar</a>
                </p>
                
            </div>
        </div>
    </div>
    </form>
</body>
</html>
