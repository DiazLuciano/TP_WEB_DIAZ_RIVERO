<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="PasoDos.aspx.cs" Inherits="WEB.PasoDos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <h1 class="body">Elegi Tu Premio</h1>
    </div>
    <table>
        <tr>
            <td style="height: 138px; width: 85px;">
                <div>
                    <asp:ImageButton ID="ImagenBotonMochila" runat="server" ImageUrl="" OnClick="ImagenBotonMochila_Click" Width="100" />
                    <asp:Label ID="LABEL" Text="hola" runat="server"/>
                </div>
                <div>
                    <asp:Label ID="lblNombreMochila" Text="text" runat="server" />

                </div>
                <div>
                    <asp:Label ID="lblDescripcionMochila" Text="text" runat="server" />
                    

                </div>

                <%-- <h1>Mochila</h1>
                <p>Mochila muy resistente</p>--%>
               
            </td>

            <td style="height: 138px">
                  <div>
                  
                    <asp:ImageButton ID="ImagenBotonCelular" runat="server" ImageUrl="" OnClick="ImagenBotonCelular_Click" Width="100" />

                </div>
                <div>
                    <asp:Label ID="lblNombreCelular" Text="text" runat="server" />

                </div>
                <div>
                    <asp:Label ID="lblDescripcionCelular" Text="text" runat="server" />

                </div>
                
                 
                <%--<asp:ImageButton ID="ImageButton2" runat="server" ImageUrl="~/Images/notebook.jpg" OnClick="ImageButton2_Click" Width="100" />
                <h1>NoteBook</h1>
                <p>Notebook 15 pulgadas</p>--%>
            </td>

            <td style="height: 138px">

                 <div>
                    <asp:ImageButton ID="ImagenBotonNotebook" runat="server" ImageUrl="" OnClick="ImagenBotonNotebook_Click" Width="100" />

                </div>
                <div>
                    <asp:Label ID="lblNombreNotebook" Text="text" runat="server" />

                </div>
                <div>
                    <asp:Label ID="lblDescripcionNotebook" Text="text" runat="server" />

                </div>

                
                <%--<asp:ImageButton ID="ImageButton3" runat="server" ImageUrl="~/Images/celular.jpg" OnClick="ImageButton3_Click" Width="100" />
                <h1>Celular</h1>
                <p>Celular ultima generacion</p>--%>
            </td>
        </tr>
    </table>
    
</asp:Content>
