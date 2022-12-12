<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="consultaoficiosmassolic.aspx.vb" Inherits="ProyectoFinalWebApp.consultaoficiosmassolic" %>

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
            <asp:Label ID="Label1" runat="server" Text="Consulta Oficios mas solicitados." Font-Size="X-Large"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <asp:GridView ID="gvCustomers" runat="server" AutoGenerateColumns="false" AllowPaging="true" >
            <Columns>
                    <asp:BoundField DataField="Oficio_Nombre" HeaderText="Oficio_Nombre" ItemStyle-Width="50" />
                    <asp:BoundField DataField="Contador_Registros" HeaderText="Contador_registros" ItemStyle-Width="50" />
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
