<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="PasoUno.aspx.cs" Inherits="WEB.PasoUno" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label class="text-center textoGrande textoNegrita" ID="lblIngresa" runat="server" Text="Ingrese Código del Voucher" ForeColor="White" BorderStyle="None" ></asp:Label>
    
    <asp:TextBox ID="txtVoucher" runat="server" BackColor="#CCCCCC" TextMode="Password"></asp:TextBox>
    <p>
    <asp:Button ID="btnSiguiente" runat="server" Text="Siguiente" BackColor="#CCCCCC" Font-Bold="True" Font-Italic="False" ForeColor="Black" OnClick="btnSiguiente_Click" />
    </p>
</asp:Content>
