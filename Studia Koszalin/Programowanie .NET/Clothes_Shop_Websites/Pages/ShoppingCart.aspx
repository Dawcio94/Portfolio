<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="ShoppingCart.aspx.cs" Inherits="Pages_ShoppingCart" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <asp:Panel ID="pnlShoppingCart" runat="server">
    </asp:Panel>
        <table>
            <tr>
                <td>
                    <b>Razem: </b>
                </td>
                <td>
                    <asp:Literal ID="litTotal" runat="server" Text=""></asp:Literal>
                </td>
            </tr>

            <tr>
                <td>
                    <b>Vat: </b>
                </td>
                <td>
                    <asp:Literal ID="litVat" runat="server" Text="" />
                </td>
            </tr>
            <tr>
                <td>
                    <b>Shipping: </b>
                </td>
                <td>
                    PLN 15
                </td>
            </tr>

            <tr>
                <td>
                    <b>Całkowita kwota: </b>
                </td>
                <td>
                    <asp:Literal ID="litTotalAmount" runat="server" Text="" />
                </td>
            </tr>

            <tr>
                <td>
                    <br />
                    <asp:LinkButton ID="LinkButton1" runat="server" PostBackUrl="~/Pages/Main_Page.aspx">Kontynuuj zakupy</asp:LinkButton> &nbsp;&nbsp; or                     
                    <asp:Button ID="btnCheckout" runat="server" Text="Potwierdź zakup" CssClass="button" Width="250px" PostBackUrl="~/Pages/Success.aspx" />
                    <br />
                </td>
            </tr>

        </table>
</asp:Content>

