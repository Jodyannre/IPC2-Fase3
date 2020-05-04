<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="crearBodega.aspx.cs" Inherits="Presentacion_crearBodega" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <h2 class="tm-page-header">Crear bodega</h2>
</asp:Content>
    
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td style="width: 296px">
                <asp:Label ID="Label1" runat="server" Text="Código:"></asp:Label>
            </td>
            <td style="width: 390px">
                <asp:TextBox ID="TextBox1" runat="server" Width="339px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 296px; height: 31px">
                <asp:Label ID="Label2" runat="server" Text="Nombre:"></asp:Label>
            </td>
            <td style="height: 31px; width: 390px">
                <asp:TextBox ID="TextBox2" runat="server" Width="339px"></asp:TextBox>
            </td>
            <td style="height: 31px"></td>
        </tr>
        <tr>
            <td style="height: 31px; width: 296px">
                <asp:Label ID="Label3" runat="server" Text="Descripción:"></asp:Label>
            </td>
            <td style="height: 31px; width: 390px">
                <asp:TextBox ID="TextBox3" runat="server" Width="339px"></asp:TextBox>
            </td>
            <td style="height: 31px"></td>
        </tr>
        <tr>
            <td style="width: 296px">
                <asp:Label ID="Label4" runat="server" Text="Dirección física:"></asp:Label>
            </td>
            <td style="width: 390px">
                <asp:TextBox ID="TextBox4" runat="server" Width="339px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 296px">&nbsp;</td>
            <td style="width: 390px">&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="width: 296px">&nbsp;</td>
            <td style="width: 390px">
                <asp:Button ID="Button1" runat="server" Text="Crear" />
            </td>
            <td>
                <asp:Button ID="Button2" runat="server" Text="Cancelar" />
            </td>
        </tr>
    </table>
</asp:Content>

