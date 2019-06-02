<%@ Page Title="" Language="C#" MasterPageFile="~/PaginaPrincipal.Master" AutoEventWireup="true" CodeBehind="PasoTres.aspx.cs" Inherits="WEB.PasoTres" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">

</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <div>
            <h1 class="body" >Carga tus Datos</h1>
    </div>
    <table>
        <tr>
            <td class ="celdaPropiedad">
                <%--<br />--%>
                DNI:
            </td>
            <td class="celdaValor">
                <asp:TextBox runat="server" ID="txtDNI" type="text" class="form-control" style="width:200px;" maxlength="8" onkeypress='return event.charCode >= 48 && event.charCode <= 57' />
            <%--<input id="textoDNI" type="text" class="form-control" style="width:200px;" maxlength="8" onkeypress='return event.charCode >= 48 && event.charCode <= 57'/></td>--%>
        </tr>
        <tr>
            <td class ="celdaPropiedad">
                Nombre:
            </td>
            <td class="celdaValor">
                <asp:textbox runat="server" ID="txtNombre" type="text" class="form-control" style="width:300px;"/>
                <%--<input id="textoNombre" type="text" class="form-control" style="width:300px;" />--%>
            </td>
             <td class ="celdaPropiedad">
                Apellido:
            </td>
            <td class="celdaValor">
                <asp:textbox runat="server" ID="txtApellido" type="text" class="form-control" style="width:300px;"/>
                <%--<input id="textoApellido" type="text" class="form-control" style="width:300px;" />--%>
            </td>
        </tr>
         <tr>
            <td class ="celdaPropiedad">
                Email:
            </td>
            <td class="celdaValor">
                <asp:textbox runat="server" ID="txtEmail" type="text" class="form-control" style="width:300px;"/>
                <%--<input id="textoEmail" type="text" class="form-control" style="width:350px;" />--%>
            </td>
        </tr>
        <tr>
            <td class ="celdaPropiedad">
                Direccion:
            </td>
            <td class="celdaValor">
                <asp:textbox runat="server" ID="txtDireccion" type="text" class="form-control" style="width:300px;"/>
                <%--<input id="textoDireccion" type="text" class="form-control" style="width:350px;" />--%>
            </td>
             <td class ="celdaPropiedad">
                Ciudad:
            </td>
            <td class="celdaValor">
                <asp:textbox runat="server" ID="txtCiudad" type="text" class="form-control" style="width:250px;"/>
                <%--<input id="textoCiudad" type="text" class="form-control" style="width:200px;" />--%>
            </td>
            <td class ="celdaPropiedad">
                CP:
            </td>
            <td class="celdaValor">
                 <asp:TextBox runat="server" ID="txtCP" type="text" class="form-control" style="width:100px;" maxlength="8" onkeypress='return event.charCode >= 48 && event.charCode <= 57' />
                <%--<input id="textoCP" type="text" class="form-control" style="width:100px;" maxlength="4" onkeypress='return event.charCode >= 48 && event.charCode <= 57'/>--%>
            </td>
        </tr>
        <tr>
            <td colspan="4" style="text-align:center;padding-top:45px;">
                <%--<button id="botonGuardar" type="button" class="btn btn-sm btn-primary" title="Pulsar Para Guardar">Guardar</button>--%>
                <asp:Button Text="GUARDAR" title="Pulsar Para Guardar" runat="server" CssClass="btn btn-sm btn-primary" OnClick="btnGuardar_Click" />
            </td>
        </tr>
    </table>
</asp:Content>
