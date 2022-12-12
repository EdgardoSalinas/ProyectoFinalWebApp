<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Principal.aspx.vb" Inherits="ProyectoFinalWebApp.Principal" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Menu de Opciones"></asp:Label>
            <br />
            <br />
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Font-Bold="True" Font-Size="X-Large" Height="119px" Text="Registrar Oficio del Usuario" Width="533px" />
            <br />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Font-Bold="True" Font-Size="X-Large" Height="139px" Text="Lista de Oficios" Width="528px" />
            <br />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" Font-Bold="True" Font-Size="X-Large" Height="139px" Text="Consulta General" Width="528px" />
            <br />
            <br />
            <br />
            <asp:Button ID="Button4" runat="server" Font-Bold="True" Font-Size="X-Large" Height="139px" Text="Oficios mas solicitados" Width="528px" />
            <br />
            <br />
            <br />
            <asp:HyperLink ID="HyperLink1" runat="server" Font-Size="Larger" NavigateUrl="~/Login.aspx">Retornar a Login</asp:HyperLink>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
