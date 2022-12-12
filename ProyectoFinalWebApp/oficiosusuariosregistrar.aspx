<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="oficiosusuariosregistrar.aspx.vb" Inherits="ProyectoFinalWebApp.oficiosusuariosregistrar" %>

<!DOCTYPE html>

<script runat="server">

    Private Sub DeleteRowButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        OficiosxuserGridView.DeleteRow(OficiosxuserGridView.SelectedIndex)
    End Sub

</script>



<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    </head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            <asp:Label ID="Label1" runat="server" Font-Size="X-Large" Text="Registrar Oficios del Usuario"></asp:Label>
        </div>
        <p>
            ----------------------------------------------------------------------------</p>
        <div>
            <br />
            <br />
            <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label>
            <asp:TextBox ID="txt_nombre" runat="server" ReadOnly="True"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label3" runat="server" Text="Apellido"></asp:Label>
            <asp:TextBox ID="txt_apellido" runat="server" ReadOnly="True"></asp:TextBox>
            <br />
            <br />
            <asp:Label ID="Label4" runat="server" Text="Explicacion"></asp:Label>
            <br />
            <br />
            <asp:TextBox ID="txt_explicacion" runat="server" Width="606px"></asp:TextBox>
            <br />
            <br />
            Oficio:&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="Sqlds_oficios" DataTextField="descripcion" DataValueField="id" Width="193px">
            </asp:DropDownList>
            <asp:SqlDataSource ID="Sqlds_oficios" runat="server" ConnectionString="<%$ ConnectionStrings:OficiosConnectionString %>" SelectCommand="SELECT [id], [descripcion] FROM [oficios]"></asp:SqlDataSource>
            <br />
            <br />
            <asp:Button ID="btn_guardar" runat="server" Text="Guardar" Width="247px" />
            <br />
        </div>





    <div>
        <br />
        <br />
        -------------------------------------------------------------------------------<br />
        <br />

        <asp:gridview id="OficiosxuserGridView" 
            allowpaging="true"
            datasourceid="OficiosxuserSqlDataSource" 
            autogeneratecolumns="true"
            autogenerateselectbutton="true"
            datakeynames="ID_REGISTRO"
            selectedindex="0"   
            runat="server">
        
            <selectedrowstyle BackColor="lightblue"/>
        
          </asp:gridview>

          <asp:sqldatasource id="OficiosxuserSqlDataSource"  
            selectcommand="Select u.Id_registro,[Usuario],Oficio=o.descripcion,[Explicacion] From [usuariooficio] u,oficios o where u.id_oficio = o.id"
            deletecommand="Delete from usuariooficio where ID_registro = @ID_registro"
            connectionstring="Server=DESKTOP-EG9C4H1\SQLEXPRESS;Database=oficios;User Id=sa;Password=SSDSA;"
            runat="server">
          </asp:sqldatasource>


                    <br />
            <br />
            <br />

            
            <asp:button id="DeleteRowButton"
            text="Borrar Registro"
            onclick="DeleteRowButton_Click" 
            runat="server"/>

                   <br />
           <br />
           <br />
           <br />
           <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Principal.aspx">Retornar</asp:HyperLink>


    </div>





    </form>

</body>
</html>
