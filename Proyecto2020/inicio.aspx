<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="inicio.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder2" Runat="Server">
    <h2 class="tm-page-header">Login</h2>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table style="width:100%;">
        <tr>
            <td>
                <asp:Label ID="lNombre" runat="server" Text="Nombre de usuario:"></asp:Label>
            </td>
            <td>
                
                <asp:TextBox ID="txtNombre" runat="server"></asp:TextBox>
                
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lPass" runat="server" Text="Contraseña: "></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtPass" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
            <td>
                &nbsp;</td>
            <td>
                <asp:Button ID="bIngresar" runat="server" Text="Ingresar" OnClick="bIngresar_Click" />
            </td>
        </tr>
    </table>
</asp:Content>

