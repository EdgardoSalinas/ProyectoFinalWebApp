<%@ Page Language="vb" AutoEventWireup="false" CodeBehind="oficios.aspx.vb" Inherits="ProyectoFinalWebApp.oficios" %>

<!DOCTYPE html>

<script runat="server">

    Private Sub DeleteRowButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        OficiosGridView.DeleteRow(OficiosGridView.SelectedIndex)
    End Sub

    Private Sub UpdateRowButton_Click(ByVal sender As Object, ByVal e As EventArgs)
        OficiosGridView.UpdateRow(OficiosGridView.EditIndex, True)
    End Sub

    Private Sub OficiosGridView_RowCommand(ByVal sender As Object, ByVal e As GridViewCommandEventArgs)
        Select Case e.CommandName
            Case "Edit"
                UpdateRowButton.Enabled = True
            Case "Cancel"
                UpdateRowButton.Enabled = False
            Case "Update"
                UpdateRowButton.Enabled = False
            Case Else
                UpdateRowButton.Enabled = False
        End Select
    End Sub

</script>


<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 263px;
        }
        .auto-style2 {
            width: 26%;
        }
        .auto-style3 {
            width: 263px;
            height: 31px;
        }
        .auto-style4 {
            height: 31px;
        }
    </style>
</head>

<body>
    <form id="form1" runat="server">

      <asp:Label ID="Label1" runat="server" Font-Bold="True" Font-Size="X-Large" Text="Mantenimiento de oficios"></asp:Label>

      <hr/>

      <div>

           <br />
           <br />

          <asp:gridview id="OficiosGridView" 
            allowpaging="true"
            datasourceid="OficiosSqlDataSource" 
            autogeneratecolumns="true"
            autogenerateselectbutton="true"
            autogenerateeditbutton="true"
            onrowcommand="OficiosGridView_RowCommand" 
            datakeynames="ID"
            selectedindex="0"   
            runat="server">
        
            <selectedrowstyle BackColor="lightblue"/>
        
          </asp:gridview>

          <asp:sqldatasource id="OficiosSqlDataSource"  
            selectcommand="Select [ID], [descripcion] From [Oficios]"
            deletecommand="Delete from oficios where ID = @ID"
            updatecommand="Update oficios SET descripcion=@descripcion WHERE (ID = @ID)"
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


            <asp:button id="UpdateRowButton"
                text="Actualizar Registro"
                enabled="false"
                onclick="UpdateRowButton_Click" 
                runat="server"/>



           <br />
           <br />
           <br />
           <br />
           <table border="1" class="auto-style2">
               <tr>
                   <td class="auto-style3">Crear nuevo oficio.</td>
                   <td class="auto-style4"></td>
               </tr>
               <tr>
                   <td class="auto-style1">&nbsp;</td>
                   <td>&nbsp;</td>
               </tr>
               <tr>
                   <td class="auto-style1">Oficio</td>
                   <td>
                       <asp:TextBox ID="txt_descripcion" runat="server"></asp:TextBox>
                   </td>
               </tr>
               <tr>
                   <td class="auto-style1">&nbsp;</td>
                   <td>&nbsp;</td>
               </tr>
               <tr>
                   <td class="auto-style1">&nbsp;</td>
                   <td>
                       <asp:Button ID="btn_agregar" runat="server" Text="Agregar" Width="185px" />
                   </td>
               </tr>
           </table>
           <br />
           <br />
           <br />
           <br />
           <asp:HyperLink ID="HyperLink1" runat="server" NavigateUrl="~/Principal.aspx">Retornar</asp:HyperLink>



        </div>
    </form>

</body>
</html>
