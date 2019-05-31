<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="PasoDos.aspx.cs" Inherits="WEB.PasoDos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
            <h1 class="body" >Elegi Tu Premio</h1>
    </div>
    <table>
        <tr>
            <td>
                <asp:ImageButton ID="ImageButton1" runat="server" ImageUrl="~/Images/mochila.jpg" OnClick="ImageButton1_Click" width="100"/>
                <h1>Mochila</h1>
                <p>Mochila muy resistente</p>
               
            </td>
           
            <td>
                <asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/Images/notebook.jpg" OnClick="ImageButton2_Click" Width="100" />
                <h1>NoteBook</h1>
                <p>Notebook 15 pulgadas</p>
            </td>

             <td>
                 <asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/Images/celular.jpg" OnClick="ImageButton3_Click" width="100"/>
                 <h1>Celular</h1>
                 <p>Celular ultima generacion</p>
            </td>
        </tr>

            
      
    </table>
</asp:Content>
