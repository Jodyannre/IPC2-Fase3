<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="InicioAdminServicios.aspx.cs" Inherits="InicioAdminServicios" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
<h2 class="tm-page-header">Inicio Admin de Servicios</h2>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Agregar/eliminar módulos" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="Button2" runat="server" Text="Permisos" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="Button3" runat="server" Text="Crear Usuario" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button4" runat="server" Text="Aceptar" />
            </td>
            <td>
                <asp:Button ID="Button5" runat="server" Text="Regresar" />
            </td>
            <td>
                <asp:Button ID="Button6" runat="server" Text="Salir" />
            </td>
        </tr>
    </table>
</asp:Content>

