<%@ Page Title="" Language="C#" MasterPageFile="~/PAGINAAAAAAAMAESTRAAAAAAAA.Master" AutoEventWireup="true" CodeBehind="Agregar.aspx.cs" Inherits="PaginaWebBakan.Agregar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style2 {
            color: #FF0000;
        }
        .auto-style3 {
            width: 295px;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h2>Agregar Empleado Nuevo</h2>

    <table style="width: 100%;">
        <tr>
            <td class="auto-style2">Rut:</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtRut" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style2">Dv:</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtDV" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
          <tr>
            <td class="auto-style2">Nombre:</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
              </td>
            <td>&nbsp;</td>
        </tr>
          <tr>
            <td class="auto-style2">Apellido:</td>
            <td class="auto-style3">
                <asp:TextBox ID="txtApellido" runat="server"></asp:TextBox>
              </td>
            <td>&nbsp;</td>
        </tr>
          <tr>
            <td class="auto-style2">Empresa: </td>
            <td class="auto-style3">
                <asp:DropDownList ID="DDLempresa" runat="server" AutoPostBack="True" DataSourceID="SqlDataSource1" DataTextField="RazonSocial" DataValueField="Rut">
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:EmpresasConnectionString %>" SelectCommand="SELECT * FROM [Empresa]"></asp:SqlDataSource>
              </td>
            <td>&nbsp;</td>
        </tr>
          <tr>
            <td>
                <asp:Button ID="btnGuardar" runat="server" Text="Guardar Info" Width="123px" OnClick="btnGuardar_Click" />
              </td>
            <td class="auto-style3">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
      
    </table>

</asp:Content>
