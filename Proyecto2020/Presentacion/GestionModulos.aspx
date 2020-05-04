<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="GestionModulos.aspx.cs" Inherits="GestionModulos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <h2 class="tm-page-header">Gestión de módulos</h2>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td>
                <asp:DropDownList ID="DropDownList1" runat="server" style="margin-bottom: 0px">
                </asp:DropDownList>
            </td>
            <td>
                <asp:RadioButton ID="Habilitado" runat="server" />
            </td>
            <td>
                <asp:RadioButton ID="RadioButton2" runat="server" Text="Deshabilitado" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button2" runat="server" Text="Aceptar" />
            </td>
            <td>
                <asp:Button ID="Button3" runat="server" Text="Regresar" />
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Salir" />
            </td>
        </tr>
    </table>
</asp:Content>

