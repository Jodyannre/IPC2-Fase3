<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="moduloInventario.aspx.cs" Inherits="Presentacion_moduloInventario" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <h2>Módulo inventario</h2>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td style="width: 416px">
                <asp:Button ID="Button3" runat="server" Text="Gestión de bodega" />
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Transacciones por bodega" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 416px">
                <asp:Button ID="Button4" runat="server" Text="Gestión de costos" />
            </td>
            <td>
                <asp:Button ID="Button2" runat="server" Text="Transferencias entre bodegas" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 416px">
                <asp:Button ID="Button5" runat="server" Text="Generar informes" />
            </td>
            <td>
                <asp:Button ID="Button6" runat="server" Text="Salir" />
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>

