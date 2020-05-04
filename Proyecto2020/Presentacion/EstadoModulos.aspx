<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="EstadoModulos.aspx.cs" Inherits="EstadoModulos" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <h2 class="tm-page-header">Ventana agregar/eliminar módulos</h2>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RadioButton ID="RadioButton1" runat="server" Text="Instalado" />
            </td>
            <td>
                <asp:RadioButton ID="RadioButton4" runat="server" Text="No instalado" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RadioButton ID="RadioButton2" runat="server" Text="Instalado" />
            </td>
            <td>
                <asp:RadioButton ID="RadioButton5" runat="server" Text="No instalado" />
            </td>
        </tr>
        <tr>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RadioButton ID="RadioButton3" runat="server" Text="Instalado" />
            </td>
            <td>
                <asp:RadioButton ID="RadioButton6" runat="server" Text="No instalado" />
            </td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server" style="margin-bottom: 4px"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Button ID="Button2" runat="server" Text="Aceptar" />
            </td>
            <td>
                <asp:Button ID="Button1" runat="server" Text="Regresar" />
            </td>
            <td>
                <asp:Button ID="Button3" runat="server" Text="Salir" />
            </td>
        </tr>
    </table>
</asp:Content>

