<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="consulta.aspx.vb" Inherits="ProyectoFinalWebApp.consulta" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <hr />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Text="Consulta de Oficios por Usuario" Font-Size="X-Large"></asp:Label>
            <br />
            <br />
            <br />

            <asp:TextBox ID="txtSearch" runat="server" Width="485px"></asp:TextBox>
            <asp:Button Text="Search" runat="server" OnClick="Search" Font-Size="Larger"/>
            <br />
            <asp:Label ID="Label2" runat="server" Text="Escriba un texto a buscar en cualquier columna"></asp:Label>
            <br />
            <br />
            <asp:GridView ID="gvCustomers" runat="server" AutoGenerateColumns="false" AllowPaging="true"
                    OnPageIndexChanging="OnPaging">
            <Columns>
                    <asp:BoundField DataField="Usuario" HeaderText="Usuario" ItemStyle-Width="50" />
                    <asp:BoundField DataField="Nombre" HeaderText="Nombre" ItemStyle-Width="50" />
                    <asp:BoundField DataField="Apellido" HeaderText="Apellido" ItemStyle-Width="50" />
                    <asp:BoundField DataField="Oficio" HeaderText="Oficio" ItemStyle-Width="100" />
                    <asp:BoundField DataField="Explicacion" HeaderText="Explicacion" ItemStyle-Width="150" />
            </Columns>
            </asp:GridView>


            <br />
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Principal.aspx" Font-Size="Larger">Retornar</asp:HyperLink>


        </div>
    </form>
</body>
</html>
