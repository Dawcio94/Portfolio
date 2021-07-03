<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Woman_Bra_Push.aspx.cs" Inherits="Pages_Woman_Bra_Push" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" Runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <table>
        <tr>
            <td rowspan="4">
                <asp:Image ID="imgProduct" runat="server" CssClass="detailsImage" />
            </td>
            <td>
                <h2>
                    <asp:Label ID="lblTitle" runat="server"></asp:Label></h2>
                <hr />
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblDescription" runat="server" CssClass="detailsDescription"></asp:Label>
            </td>
            <td >
                <asp:Label ID="lblPrice" runat="server" CssClass="detailsPrice"></asp:Label><br />
                Ilość:<asp:DropDownList ID="ddlAmount" runat="server"></asp:DropDownList><br />
                <asp:Button ID="btnAdd" runat="server" CssClass="button" OnClick="btnAdd_Click" Text="Dodaj do koszyka" />
                <br />
                <asp:Label ID="lblResult" runat="server"></asp:Label>
            </td>
        </tr>
        <tr>
            <td>Numer productu:
                <br />
                <asp:Label ID="lblItemNr" runat="server" Style="font-style: italic"></asp:Label>
            </td>
        </tr>
        <tr>
            <td class="auto-style2">&nbsp;<asp:Label ID="lblAvailable" runat="server" CssClass="productPrice">Dostępne!</asp:Label>
            </td>
        </tr>
    </table>
</asp:Content>

