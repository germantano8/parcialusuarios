<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Usuario.aspx.cs" Inherits="Web.Usuario" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 23px;
        }
        .auto-style2 {
            width: 300px;
        }
        .auto-style3 {
            height: 23px;
            width: 300px;
        }
        .auto-style4 {
            width: 371px;
        }
        .auto-style5 {
            height: 23px;
            width: 371px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
        </div>
        <table style="width:100%;">
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label1" runat="server" Text="Ingrese un nombre de usuario"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:TextBox ID="txtNombreUsuario" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:Button ID="btnRecuperar" runat="server" OnClick="btnRecuperar_Click" Text="Buscar" />
                </td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label2" runat="server" Text="Email:"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:Label ID="lblEmail" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style3">
                    <asp:Label ID="Label3" runat="server" Text="Tipo Usuario:"></asp:Label>
                </td>
                <td class="auto-style5">
                    <asp:Label ID="lblTipoUsuario" runat="server"></asp:Label>
                </td>
                <td class="auto-style1">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label4" runat="server" Text="Ultimo Ingreso:"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:Label ID="lblUltimoIngreso" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">
                    <asp:Label ID="Label5" runat="server" Text="Dias desde ultimo ingreso:"></asp:Label>
                </td>
                <td class="auto-style4">
                    <asp:Label ID="lblDias" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">&nbsp;</td>
                <td class="auto-style4">
                    <asp:Label ID="lblInforma" runat="server"></asp:Label>
                </td>
                <td>&nbsp;</td>
            </tr>
        </table>
    </form>
</body>
</html>
