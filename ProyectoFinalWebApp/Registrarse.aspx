<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="Registrarse.aspx.vb" Inherits="ProyectoFinalWebApp.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 735px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div class="auto-style1">
            <br />
            <br />
            <br />
            <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="XX-Large" Text="Registro de Usuario"></asp:Label>
            <br />
            <div>
                <br />
                <table border="0" style="width:100%;">
                    <tr>
                        <td>Registrarse</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>Nombre</td>
                        <td>
                            <asp:TextBox ID="txt_nombre" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Apellido</td>
                        <td>
                            <asp:TextBox ID="txt_apellido" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Correo Electronico</td>
                        <td>
                            <asp:TextBox ID="txt_correo" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>Usuario</td>
                        <td>
                            <asp:TextBox ID="txt_usuario" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>Contraseña</td>
                        <td>
                            <asp:TextBox ID="txt_contrasena" runat="server"></asp:TextBox>
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>
            <asp:Button ID="btn_registrar" runat="server" Text="Registrar" />
                        </td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>&nbsp;</td>
                    </tr>
                    <tr>
                        <td>&nbsp;</td>
                        <td>
            <asp:Button ID="btn_cancelar" runat="server" Text="Cancelar" />
                        </td>
                    </tr>
                </table>
                <br />
                <br />
                <br />
                <br />
            </div>
        </div>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
