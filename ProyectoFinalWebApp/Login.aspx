<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Login.aspx.vb" Inherits="ProyectoFinalWebApp.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 31px;
        }
        .auto-style2 {
            height: 31px;
            width: 192px;
        }
        .auto-style3 {
            width: 192px;
        }
        .auto-style4 {
            height: 30px;
            width: 192px;
        }
        .auto-style5 {
            height: 30px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="height: 113px; width: 893px">
            <br />
            <asp:Label ID="Label1" runat="server" Text="Crear y Actualizar Oficios" Font-Size="X-Large"></asp:Label>
            <br />
            <br />
            <br />
        </div>
        <p>
            &nbsp;</p>
        <div style="width: 896px">
            <br />
            <br />
            <table border="0">
                <tr>
                    <td class="auto-style2" aria-sort="descending" style="font-size: x-large">Login</td>
                    <td class="auto-style1"></td>
                </tr>
                <tr>
                    <td class="auto-style4"></td>
                    <td class="auto-style5"></td>
                </tr>
                <tr>
                    <td class="auto-style3">Usuario</td>
                    <td>
                        <asp:TextBox ID="txt_usuario" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">Contraseña:</td>
                    <td class="auto-style1">
                        <asp:TextBox ID="txt_contrasena" runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style1">
                        <asp:Button ID="Button1" runat="server" Text="Login" Width="149px" Font-Size="Larger" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style1">&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style2">&nbsp;</td>
                    <td class="auto-style1">
                        <asp:Button ID="Button2" runat="server" Text="Registrarse" Width="140px" Font-Size="Larger" />
                    </td>
                </tr>
            </table>
            <br />
            <br />
            <br />
        </div>
    </form>
</body>
</html>
