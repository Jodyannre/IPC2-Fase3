<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="crearEstante.aspx.cs" Inherits="Presentacion_crearEstante" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <h2 class="tm-page-header">Crear estante</h2>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
        <table style="width:100%;">
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Id:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label2" runat="server" Text="Largo:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label3" runat="server" Text="Ancho:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label4" runat="server" Text="Altura:"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 60px">
                <asp:Label ID="Label5" runat="server" Text="Bodega:"></asp:Label>
            </td>
            <td style="height: 60px">
                <asp:DropDownList ID="DropDownList1" runat="server">
                </asp:DropDownList>
            </td>
            <td style="height: 60px"></td>
        </tr>
        <tr>
            <td style="height: 60px">
                <asp:Label ID="Label6" runat="server" Text="Pasillo:"></asp:Label>
            </td>
            <td style="height: 60px">
                <asp:DropDownList ID="DropDownList2" runat="server">
                </asp:DropDownList>
            </td>
            <td style="height: 60px">&nbsp;</td>
        </tr>
        <tr>
            <td style="height: 57px">
                <asp:Button ID="Button1" runat="server" Text="Agregar" />
            </td>
            <td style="height: 57px">
                <asp:Button ID="Button2" runat="server" Text="Aceptar" />
            </td>
            <td style="height: 57px">
                <asp:Button ID="Button3" runat="server" Text="Salir" />
            </td>
        </tr>
    </table>
</asp:Content>

