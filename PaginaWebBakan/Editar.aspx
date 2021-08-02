<%@ Page Title="" Language="C#" MasterPageFile="~/PAGINAAAAAAAMAESTRAAAAAAAA.Master" AutoEventWireup="true" CodeBehind="Editar.aspx.cs" Inherits="PaginaWebBakan.Editar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h2>Editar Datos Empleado</h2>

    <table style="width: 100%;">
        <tr>
            <td>Rut Empleado no modificar</td>
            <td>
                <asp:TextBox ID="txtRut" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>DV</td>
            <td>
                <asp:TextBox ID="txtDV" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Nombre</td>
            <td>
                <asp:TextBox ID="TtxtNombre" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
         </tr>
        <tr>
            <td>Apellido</td>
            <td>
                <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:Button ID="btnModificar" runat="server" Text="Modificar" Width="137px" OnClick="btnModificar_Click" />
            </td>
        </tr>
         </tr>
        <tr>
            <td>Empresa </td>
            <td>
                <asp:DropDownList ID="DDLEmpresa" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="RazonSocial" DataValueField="Rut">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EmpresasConnectionString %>" SelectCommand="SELECT * FROM [Empresa]"></asp:SqlDataSource>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>

</asp:Content>
