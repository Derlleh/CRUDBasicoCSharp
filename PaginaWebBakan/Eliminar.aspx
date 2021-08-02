<%@ Page Title="" Language="C#" MasterPageFile="~/PAGINAAAAAAAMAESTRAAAAAAAA.Master" AutoEventWireup="true" CodeBehind="Eliminar.aspx.cs" Inherits="PaginaWebBakan.Eliminar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h2>Eliminar Empleado Con Rut</h2>

    <table style="width: 100%;">
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Ingresar Rut de Empleado a Eliminar: </td>
            <td>
                <asp:TextBox ID="txtRut" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" Width="104px" OnClick="btnEliminar_Click" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>

</asp:Content>
