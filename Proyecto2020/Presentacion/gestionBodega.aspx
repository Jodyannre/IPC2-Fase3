<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="gestionBodega.aspx.cs" Inherits="Presentacion_gestionBodega" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <h2> Gestión de bodega </h2>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td>
                <asp:Button ID="Button3" runat="server" Text="Crear bodega" />
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Crear pasillo" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button4" runat="server" Text="Crear estante" />
            </td>
            <td>
                <asp:Button ID="Button2" runat="server" Text="Crear nivel" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="Button5" runat="server" Text="Salir" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

